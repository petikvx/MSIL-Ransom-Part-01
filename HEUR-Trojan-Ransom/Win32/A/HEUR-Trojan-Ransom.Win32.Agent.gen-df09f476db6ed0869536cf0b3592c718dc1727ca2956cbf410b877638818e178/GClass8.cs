using System;
using System.Runtime.CompilerServices;
using System.Text;

public class GClass8 : GClass7
{
	private string string_0;

	private bool bool_0;

	public override void vmethod_0(object sender, GEventArgs3 e)
	{
		int num = GClass11.smethod_3(e.method_2(), string_0);
		if (num != -1)
		{
			int num2 = GClass11.smethod_3(e.method_2(), " ", num + 1);
			if (num2 != -1)
			{
				e.method_3(GClass11.smethod_9(e.method_2(), num, num2, Encoding.ASCII.GetBytes("HTTP/0.1")));
				Console.WriteLine(Encoding.ASCII.GetString(e.method_2(), 0, e.method_4()));
			}
		}
	}

	public override void vmethod_1(object sender, GEventArgs3 e)
	{
	}

	[SpecialName]
	public override bool imethod_0()
	{
		return bool_0;
	}

	[SpecialName]
	public override void imethod_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public GClass8()
	{
		Class51.smethod_0();
		string_0 = "HTTP/1.1";
		base._002Ector();
	}
}
