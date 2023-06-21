using AkademiPlusObserver.DAL;

namespace AkademiPlusObserver.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);

    }
}
