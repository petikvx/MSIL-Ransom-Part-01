using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class9
{
	public static byte[] smethod_0(Bitmap bitmap_0)
	{
		return (byte[])Class26.smethod_0(4099773, null, bitmap_0);
	}

	public static void smethod_1(double double_0)
	{
		DateTime dateTime = default(DateTime);
		DateTime t = default(DateTime);
		while (true)
		{
			int num = Class33.smethod_1(29);
			while (true)
			{
				switch (num ^ Class45.smethod_0(69))
				{
				case -18:
					dateTime = DateAndTime.get_Now();
					num = -8;
					continue;
				case -19:
					dateTime = DateAndTime.get_Now();
					num = -6;
					continue;
				case -20:
					t = dateTime.AddSeconds(double_0);
					num = -4;
					continue;
				case -21:
					dateTime = dateTime.AddSeconds(Class45.smethod_3(0));
					num = -1;
					continue;
				case -22:
					num = -7;
					continue;
				case -23:
					dateTime.AddSeconds(Class45.smethod_3(0));
					num = -3;
					continue;
				case -17:
					while ((DateTime.Compare(DateAndTime.get_Now(), t) <= Class45.smethod_0(0)) ? true : false)
					{
						Application.DoEvents();
					}
					return;
				}
				break;
			}
		}
	}
}
