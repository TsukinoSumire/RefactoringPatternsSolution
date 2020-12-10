

namespace PatternsLibrary.Structural.Adapter
{
    //нужная вилка в розетку
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetTarget()
        {
            var rsltAdapteeLogic = _adaptee.AdapteeLogic();
           
            return $"Now this is target)) {rsltAdapteeLogic}";
        }
    }
}
