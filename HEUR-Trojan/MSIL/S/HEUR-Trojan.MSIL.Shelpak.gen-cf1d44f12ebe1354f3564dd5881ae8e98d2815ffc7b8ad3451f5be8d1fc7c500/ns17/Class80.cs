using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns17;

internal sealed class Class80
{
	[CompilerGenerated]
	private sealed class Class81
	{
		public string string_0;

		internal void _003CGetText_003Eb__0()
		{
			string_0 = Clipboard.GetText();
		}
	}

	[CompilerGenerated]
	private sealed class Class82
	{
		public string string_0;

		internal void _003CSetText_003Eb__0()
		{
			try
			{
				Clipboard.SetText(string_0);
			}
			catch
			{
			}
		}
	}

	public static string smethod_0()
	{
		string string_0 = string.Empty;
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				string_0 = Clipboard.GetText();
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}
		catch
		{
		}
		return string_0;
	}

	public static void smethod_1(string string_0)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				Clipboard.SetText(string_0);
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
