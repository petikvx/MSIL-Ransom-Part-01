using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NamasteUnlock;

[Obfuscation(Exclude = false, Feature = "-rename")]
[ComVisible(true)]
public class BrowseClick
{
	public void openPaymentSite()
	{
		Process.Start("https://sellix.io/product/600dc38dbf44c");
	}

	public void openBrowser()
	{
		Process.Start("https://google.com");
	}
}
