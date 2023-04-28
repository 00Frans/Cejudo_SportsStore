using Cejudo_SportsStore.Models;

namespace Cejudo_SportsStore.Models
{
	public interface IOrderRepository
	{
		IQueryable<Order> Orders { get; }
		void SaveOrder(Order order);
	}
}