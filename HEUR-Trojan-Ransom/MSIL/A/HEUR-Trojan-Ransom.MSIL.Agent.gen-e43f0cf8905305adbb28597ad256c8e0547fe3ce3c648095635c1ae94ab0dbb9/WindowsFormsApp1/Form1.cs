using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns5;

namespace WindowsFormsApp1;

public class Form1 : Form
{
	internal enum Month
	{
		Jan,
		Feb,
		Mar,
		Apr,
		May,
		Jun,
		Jul,
		Aug,
		Sep,
		Oct,
		Nov,
		Dec
	}

	[CompilerGenerated]
	internal sealed class Class0
	{
		public string string_0;

		public byte method_0(int int_0)
		{
			return Convert.ToByte(string_0.Substring(int_0, 2), 16);
		}
	}

	private IContainer icontainer_0;

	[CompilerGenerated]
	internal static Func<int, bool> func_0;

	public Form1()
	{
		Class68.smethod_30(this);
	}

	internal void method_0(object sender, EventArgs e)
	{
		Class68.smethod_23(this);
		Class68.smethod_21(this);
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[CompilerGenerated]
	internal static bool smethod_0(int int_0)
	{
		return int_0 % 2 == 0;
	}
}
