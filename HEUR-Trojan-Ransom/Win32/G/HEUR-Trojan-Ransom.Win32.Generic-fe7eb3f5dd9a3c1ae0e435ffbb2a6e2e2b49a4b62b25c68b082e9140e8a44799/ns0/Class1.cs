using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ns0;

internal class Class1
{
	public delegate byte[] Delegate0(Stream stream);

	private Class0 class0_0 = new Class0();

	private List<Stream> list_0 = new List<Stream>();

	public Class1(CultureInfo cultureInfo_0, bool bool_0)
	{
		foreach (DictionaryEntry item in Class5.XMeKRDOattcuzEDJVfeGRmVbTaqm.GetResourceSet(cultureInfo_0, bool_0, bool_0)!)
		{
			try
			{
				list_0.Add(new MemoryStream((byte[])item.Value));
			}
			catch
			{
			}
		}
	}

	private byte[] method_0(Stream stream_0, Delegate0 delegate0_0)
	{
		try
		{
			byte[] array = class0_0.method_2(delegate0_0(stream_0));
			if (array != null)
			{
				byte[] result = default(byte[]);
				while (true)
				{
					IL_0058:
					int num = -351981808;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(((~num2 - 1967548992) ^ -962193926) * -1230904707))) % 4u)
						{
						case 2u:
							goto IL_0018;
						default:
							goto end_IL_0027;
						case 3u:
							break;
						case 0u:
							goto end_IL_0027;
						case 1u:
							return result;
						}
						goto IL_0058;
						IL_0018:
						result = array;
						num = ((int)num3 * -1219112718) ^ -406848925;
						continue;
						end_IL_0027:
						break;
					}
					break;
				}
			}
		}
		catch
		{
		}
		return null;
	}

	public byte[] method_1(Delegate0 delegate0_0)
	{
		using (List<Stream>.Enumerator enumerator = list_0.GetEnumerator())
		{
			byte[] array = default(byte[]);
			Stream current = default(Stream);
			while (true)
			{
				IL_00bd:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1063102625;
					num2 = -1063102625;
				}
				else
				{
					num = 96061273;
					num2 = 96061273;
				}
				while (true)
				{
					int num3 = num;
					uint num4;
					switch ((num4 = (uint)(-(-(-(~(-(num3 ^ -14679164)))) * -336679963))) % 7u)
					{
					case 5u:
						num = 96061273;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (array == null)
						{
							num5 = 1463083769;
							num6 = 1463083769;
						}
						else
						{
							num5 = -1561573191;
							num6 = -1561573191;
						}
						num = num5 ^ (int)(num4 * 1800661307);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num = 696775614;
						continue;
					case 0u:
						array = method_0(current, delegate0_0);
						num = ((int)num4 * -27591816) ^ 0x1D5A5F7A;
						continue;
					default:
						goto end_IL_0071;
					case 6u:
						break;
					case 2u:
						goto end_IL_0071;
					case 3u:
						return array;
					}
					goto IL_00bd;
					continue;
					end_IL_0071:
					break;
				}
				break;
			}
		}
		return null;
	}
}
