using MealsManager.Application.Interfaces;

namespace MealsManager.Infrastructure.Services
{
    public class DateService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
