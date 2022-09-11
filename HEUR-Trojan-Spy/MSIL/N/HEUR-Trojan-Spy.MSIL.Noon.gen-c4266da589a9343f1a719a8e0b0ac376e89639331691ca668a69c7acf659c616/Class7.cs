using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class7
{
	public const int int_0 = 274;

	public const int int_1 = 61760;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetDesktopWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(int int_2, int int_3, int int_4, ref int int_5);

	public static bool smethod_0()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int desktopWindow = default(int);
		bool result = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int int_;
				int int_2;
				switch (try0001_dispatch)
				{
				default:
					Class7.smethod_1();
					num3 = -2;
					goto IL_000a;
				case 98:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0013:
					num = 3;
					int_ = desktopWindow;
					int_2 = 0;
					SendMessageA(int_, 274, 61760, ref int_2);
					break;
					IL_000a:
					num = 2;
					desktopWindow = GetDesktopWindow();
					goto IL_0013;
					end_IL_0001_2:
					break;
				}
				num = 4;
				result = Class7.smethod_3(Class7.smethod_2()) == 0;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				Class7.smethod_4((Exception)obj);
				try0001_dispatch = 98;
				continue;
			}
			throw Class7.smethod_5(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			Class7.smethod_1();
		}
		return result;
	}

	static void smethod_1()
	{
		ProjectData.ClearProjectError();
	}

	static ErrObject smethod_2()
	{
		return Information.Err();
	}

	static int smethod_3(ErrObject errObject_0)
	{
		return errObject_0.get_Number();
	}

	static void smethod_4(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static Exception smethod_5(int int_2)
	{
		return ProjectData.CreateProjectError(int_2);
	}
}
