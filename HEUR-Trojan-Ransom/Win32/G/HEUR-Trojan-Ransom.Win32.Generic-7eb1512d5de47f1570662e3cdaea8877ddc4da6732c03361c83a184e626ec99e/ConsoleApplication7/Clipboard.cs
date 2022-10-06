using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplication7;

public static class Clipboard
{
	public static string GetText()
	{
		string ReturnValue = string.Empty;
		Thread thread = new Thread((ThreadStart)delegate
		{
			ReturnValue = Clipboard.GetText();
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
		return ReturnValue;
	}

	public static void SetText(string txt)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			Clipboard.SetText(txt);
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
	}
}
