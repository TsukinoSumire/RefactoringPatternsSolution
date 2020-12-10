
namespace PatternsLibrary.Creational.Builder
{
    public class Director
    {
        IBuilder _builder;
        public IBuilder Builder { set { _builder = value; } }

        public void OnlyBoxBuild() => _builder.BuildBox();

        public void AllBuild()
        {
            _builder.BuildBox();
            _builder.BuildDoor();
            _builder.BuildWindows();
        }
    }
}
