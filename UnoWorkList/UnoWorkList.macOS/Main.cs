using AppKit;

namespace UnoWorkList.macOS
{
	static class MainClass
	{
		static void Main(string[] args)
		{
			NSApplication.Init();
			NSApplication.SharedApplication.Delegate = new App();
			NSApplication.Main(args);  
		}
	}
}

