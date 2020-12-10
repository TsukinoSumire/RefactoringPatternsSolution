
namespace PatternsLibrary.Behavioral.Observer
{
    public interface ISubject
    {
        void Notify();
        void Add(IObserver observer);
        void Delete(IObserver observer);
    }
}
