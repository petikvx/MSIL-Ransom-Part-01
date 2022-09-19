using System.Threading;
using System.Windows.Forms;

namespace Clipper;

internal sealed class Clipboard
{
	public static string GetText()
	{
		string ReturnValue = string.Empty;
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				ReturnValue = Clipboard.GetText();
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}
		catch
		{
		}
		return ReturnValue;
	}

	public static void SetText(string text)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				Clipboard.SetText(text);
			}
			catch
			{
			}
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
	}
}
