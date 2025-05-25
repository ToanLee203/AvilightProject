using AnviLightCode.IService;
using AnviLightCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace AnviLightCode.Pages.User
{
    public class CartModel : PageModel
    {
        private readonly ICartService _cartService; 
        private readonly ICartItemService _cartItemService; 

        public CartModel(ICartService cartService, ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
            _cartService = cartService;
        }
        public class AddToCartRequest
        {
            public int ProductId { get; set; }
            public int VariantId { get; set; }
            public int Quantity { get; set; }
        }

        [BindProperty]
        public AddToCartRequest Input { get; set; }
        public List<CartItem> CartItems { get; set; } = new();
        public async Task<IActionResult> OnPostCartAsync([FromBody] AddToCartRequest data)
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr))
            {
                return new JsonResult(new { success = false, redirect = "/User/Login" });
            }

            if (data == null || data.VariantId <= 0 || data.Quantity < 1)
            {
                return BadRequest(new { success = false, message = "Dữ liệu không hợp lệ" });
            }

            int userId = int.Parse(userIdStr);

            // 1. Lấy hoặc tạo giỏ hàng (dùng GetByIdAsync & AddAsync như bạn)
            var cart = await _cartService.GetByIdAsync(userId);
            if (cart == null)
            {
                Cart newCart = new Cart
                {
                    MaNguoiDung = userId,
                    CreatedAt = DateTime.Now
                };
                await _cartService.AddAsync(newCart);
                cart = newCart;

            }

            // 2. Kiểm tra item đã tồn tại chưa
            var existingItem = (await _cartItemService.GetAllAsync()).Where(x=>x.CartId == cart.Id && x.MaBienThe == data.VariantId).FirstOrDefault();
            if (existingItem != null)
            {
                // Nếu đã có → cập nhật số lượng
                existingItem.Quantity += data.Quantity;
                await _cartItemService.UpdateAsync(existingItem);
            }
            else
            {
                // Nếu chưa có → thêm mới
                CartItem newItem = new CartItem
                {
                    CartId = cart.Id,
                    MaBienThe = data.VariantId,
                    Quantity = data.Quantity
                };
                await _cartItemService.AddAsync(newItem);
            }
            return new JsonResult(new { success = true });
        }
        public async Task OnGetAsync()
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr)) return;

            int userId = int.Parse(userIdStr);
            var cart = await _cartService.GetByIdAsync(userId);

            if (cart != null)
            {
                CartItems = await _cartItemService.GetByCartIdWithDetailsAsync(cart.Id);
            }
        }

    }
}
