using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConsoleApplication7;

public sealed class driveNotification
{
	public class NotificationForm : Form
	{
		private static string currentClipboard;

		protected override CreateParams CreateParams => null;

		private bool RegexResult(Regex regex_0)
		{
			return true;
		}

		protected override void WndProc(ref Message m)
		{
		}

		public static string GetText()
		{
			return null;
		}

		public static void SetText(string string_0)
		{
		}

		static NotificationForm()
		{
			Class0.smethod_13();
			currentClipboard = null;
		}
	}

	static driveNotification()
	{
		Class0.smethod_13();
	}
}
