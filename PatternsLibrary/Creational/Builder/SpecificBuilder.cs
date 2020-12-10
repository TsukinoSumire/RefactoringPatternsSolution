
namespace PatternsLibrary.Creational.Builder
{
    public class SpecificBuilder : IBuilder
    {
        BuilderProduct _product = new BuilderProduct();


        public void BuildBox() =>_product.Add("BuildBox");

        public void BuildDoor() => _product.Add("BuildDoor");
        
        public void BuildWindows() => _product.Add("BuildWindows");
        
        public BuilderProduct GetProduct()
        {
            var rslt = _product;
            EraseProduct();
            return rslt;
        }

        void EraseProduct() => _product = new BuilderProduct();
    }
}
