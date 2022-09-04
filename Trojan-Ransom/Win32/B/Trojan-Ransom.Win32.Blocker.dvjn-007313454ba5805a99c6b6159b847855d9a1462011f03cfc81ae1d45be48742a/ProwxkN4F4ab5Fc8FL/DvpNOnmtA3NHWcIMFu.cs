using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using NFmduQ34S2MxmSvjjW;
using p8oMX45d9JJEUKNpCD;
using wJDjjyMYp3BjGdXkEiH;

namespace ProwxkN4F4ab5Fc8FL;

internal sealed class DvpNOnmtA3NHWcIMFu
{
	private static string HWBYm1gMF2;

	private static string zwhYN2O7Z7;

	private static byte[] LnqYfb116C;

	private static Hashtable mikY54oM92;

	private static bool emIYDJyRtU;

	private static int nFAY3Ykxhk;

	[APDUpqftwyIc8jZ0EA]
	[TJARn1DPVaJesX0rAm]
	public static string VGXYlx2PBu(int int_0)
	{
		int_0 -= nFAY3Ykxhk;
		if (emIYDJyRtU)
		{
			string text = (string)mikY54oM92[int_0];
			if (text != null)
			{
				return text;
			}
		}
		int num = 0;
		int index = int_0;
		int num2 = LnqYfb116C[index++];
		if (((uint)num2 & 0x80u) != 0)
		{
			num = ((((uint)num2 & 0x40u) != 0) ? (((num2 & 0x1F) << 24) + (LnqYfb116C[index++] << 16) + (LnqYfb116C[index++] << 8) + LnqYfb116C[index++]) : (((num2 & 0x3F) << 8) + LnqYfb116C[index++]));
		}
		else
		{
			num = num2;
			if (num == 0)
			{
				return string.Empty;
			}
		}
		string result;
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(LnqYfb116C, index, num));
			string text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (emIYDJyRtU)
			{
				try
				{
					mikY54oM92.Add(int_0, text2);
				}
				catch
				{
				}
			}
			result = text2;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	static DvpNOnmtA3NHWcIMFu()
	{
		HWBYm1gMF2 = "1";
		zwhYN2O7Z7 = "79";
		LnqYfb116C = null;
		mikY54oM92 = null;
		emIYDJyRtU = false;
		nFAY3Ykxhk = 0;
		if (HWBYm1gMF2 == "1")
		{
			emIYDJyRtU = true;
			mikY54oM92 = new Hashtable();
		}
		nFAY3Ykxhk = Convert.ToInt32(zwhYN2O7Z7);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream("{beb2294b-b7a4-4145-a74a-8ca6ecf57cec}");
		int num = Convert.ToInt32(stream.Length);
		while (true)
		{
			byte[] array = new byte[num];
			while (true)
			{
				stream.Read(array, 0, num);
				while (true)
				{
					LnqYfb116C = Xt0rZtMMyc257ciMNOG.M9AuJbZsh2(array);
					while (true)
					{
						array = null;
						int num2 = 6;
						if (!Hk42VNou8ZtfSRlLiqJ())
						{
						}
						while (true)
						{
							switch (num2)
							{
							default:
								num2 = 2;
								if (!Hk42VNou8ZtfSRlLiqJ())
								{
								}
								continue;
							case 5:
								break;
							case 2:
								goto end_IL_00ab;
							case 1:
							case 3:
								goto end_IL_00bb;
							case 0:
							case 4:
								goto end_IL_00c8;
							case 6:
								stream.Close();
								return;
							}
							break;
						}
						continue;
						end_IL_00ab:
						break;
					}
					continue;
					end_IL_00bb:
					break;
				}
				continue;
				end_IL_00c8:
				break;
			}
		}
	}

	internal static bool FGrhKAoZyqSBkLC4Yih()
	{
		return true;
	}

	internal static bool Hk42VNou8ZtfSRlLiqJ()
	{
		return false;
	}
}
