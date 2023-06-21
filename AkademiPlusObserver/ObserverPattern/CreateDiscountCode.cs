using AkademiPlusObserver.DAL;
using System;
using System.Security.Cryptography.X509Certificates;

namespace AkademiPlusObserver.ObserverPattern
{
    public class CreateDiscountCode :IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "Sale20",
                DiscountAmount = 20,
                DiscountCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}
