using Cejudo_SportsStore.Models;
using Microsoft.AspNetCore.Mvc;
namespace Cejudo_SportsStore.Components
{
	public class CartSummaryViewComponent : ViewComponent
	{
		private Cart cart;
		public CartSummaryViewComponent(Cart cartService)
		{
			cart = cartService;
		}
		public IViewComponentResult Invoke()
		{
			return View(cart);
		}
	}
}
