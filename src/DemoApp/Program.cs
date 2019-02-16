using System.Diagnostics;
using Sample3rdPartyDemoLibrary;

namespace DemoApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var x = new SampleClass();
			Debugger.Break();

			// And now Step into...
			int sum = x.Add(10, 20);
		}
	}
}
