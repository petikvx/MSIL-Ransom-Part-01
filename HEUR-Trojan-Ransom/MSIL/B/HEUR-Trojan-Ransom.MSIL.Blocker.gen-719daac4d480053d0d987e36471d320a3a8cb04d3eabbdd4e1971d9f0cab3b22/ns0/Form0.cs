using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Aeucbsggsshllavs;
using ns2;

namespace ns0;

internal class Form0 : Form
{
	private IContainer icontainer_0 = null;

	internal ListView listView_0;

	public Form0()
	{
		Class7.smethod_2(this);
	}

	internal void method_0(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		int? num = 12;
		for (int i = 0; i < 20; Thread.Sleep(1000), i++)
		{
			if (num.HasValue)
			{
				int valueOrDefault = num.GetValueOrDefault();
				if (true)
				{
					Console.WriteLine($"The nullable int 'maybe' has the value {valueOrDefault}");
					continue;
				}
			}
			Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
		}
		ClassLibrary val = new ClassLibrary();
		Console.Write("Enter a positive integer:");
		val.Data();
		decimal num2 = 10m;
		decimal num3;
		decimal num4 = (num3 = 1m);
		while (num4 <= num2)
		{
			decimal num5 = num4;
			num4 = num3 + num4;
			num3 = num5;
		}
		Console.WriteLine("The Fibonacci number following this is {0}", num4);
	}

	internal void method_1(object sender, EventArgs e)
	{
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}
}
