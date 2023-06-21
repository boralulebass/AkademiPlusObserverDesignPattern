using AkademiPlusObserver.DAL;
using System;

namespace AkademiPlusObserver.ObserverPattern
{
    public class CreateMagazineAnnouncementObserver : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateMagazineAnnouncementObserver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim ve Teknoloji Dergisi",
                Content = "Mayıs sayısı mayimize gelmiştir."
            });
            context.SaveChanges();
        }
    }
}
