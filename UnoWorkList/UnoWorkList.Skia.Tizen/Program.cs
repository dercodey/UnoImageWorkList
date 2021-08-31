using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoWorkList.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoWorkList.App(), args);
            host.Run();
        }
    }
}
