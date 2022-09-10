#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

public abstract class GClass0 : GInterface0
{
	protected GClass24 gclass24_0;

	protected string string_0;

	protected string string_1;

	public GClass24 GClass24_0
	{
		get
		{
			return gclass24_0;
		}
		protected set
		{
			gclass24_0 = value;
		}
	}

	public string String_0 => string_0;

	public string String_1 => string_1;

	internal GClass0()
	{
	}

	public virtual void imethod_0(ref MemoryStream memoryStream_0)
	{
		string_0 = smethod_0(ref memoryStream_0);
	}

	internal GClass0(GClass24 gclass24_1)
	{
		gclass24_0 = gclass24_1;
	}

	internal static string smethod_0(ref MemoryStream memoryStream_0)
	{
		Trace.WriteLine("Reading Name...");
		StringBuilder stringBuilder = new StringBuilder();
		uint num = (uint)memoryStream_0.ReadByte();
		Trace.WriteLine("Next is 0x" + num.ToString("x2"));
		int num5 = default(int);
		long position = default(long);
		uint num6 = default(uint);
		int num4 = default(int);
		int num11 = default(int);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = -688431093;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xEC211FE2u) % 16u)
				{
				case 14u:
					memoryStream_0.Position = num5;
					stringBuilder.Append(smethod_0(ref memoryStream_0));
					Trace.WriteLine(stringBuilder.ToString());
					memoryStream_0.Position = position;
					num = 0u;
					num2 = ((int)num3 * -1183342609) ^ 0x44989F66;
					continue;
				case 13u:
				{
					int num9;
					int num10;
					if (num6 == 192)
					{
						num9 = -1467242034;
						num10 = -1467242034;
					}
					else
					{
						num9 = -574131125;
						num10 = -574131125;
					}
					num2 = num9 ^ (int)(num3 * 1862896423);
					continue;
				}
				case 12u:
					Trace.WriteLine("0x" + num.ToString("x2"));
					num2 = ((int)num3 * -1127934584) ^ -1860036798;
					continue;
				case 11u:
					position = memoryStream_0.Position;
					num2 = ((int)num3 * -1698394261) ^ 0x7561A315;
					continue;
				case 10u:
					num4 = (int)(num11 & num) << 8;
					num2 = (int)(num3 * 954574395) ^ -1075001313;
					continue;
				case 9u:
					num2 = ((int)num3 * -661078819) ^ 0x39C30881;
					continue;
				case 7u:
					num11 = -193;
					num2 = ((int)num3 * -1236182447) ^ 0x31A5337F;
					continue;
				case 6u:
				{
					int num8;
					if (num == 0)
					{
						num2 = -963304259;
						num8 = -963304259;
					}
					else
					{
						num2 = -1330398361;
						num8 = -1330398361;
					}
					continue;
				}
				case 5u:
				{
					num6 = 0xC0u & num;
					int num7;
					if (num6 == 0)
					{
						num2 = -246120605;
						num7 = -246120605;
					}
					else
					{
						num2 = -1776400001;
						num7 = -1776400001;
					}
					continue;
				}
				case 4u:
					stringBuilder.Append(Encoding.ASCII.GetString(array) + ".");
					num = (uint)memoryStream_0.ReadByte();
					num2 = (int)(num3 * 1158754915) ^ -1749084574;
					continue;
				case 3u:
					num5 = memoryStream_0.ReadByte() + num4;
					num2 = (int)((num3 * 1271026454) ^ 0x31B45F7B);
					continue;
				case 1u:
					array = new byte[num];
					memoryStream_0.Read(array, 0, (int)num);
					num2 = -836869978;
					continue;
				case 0u:
					num2 = (int)((num3 * 1125610500) ^ 0x3A92C3A4);
					continue;
				case 8u:
					break;
				case 2u:
					throw new InvalidOperationException("There was a problem decompressing the DNS Message.");
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	internal string method_1(ref MemoryStream memoryStream_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = memoryStream_0.ReadByte();
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = -319907717;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xEE0EC6E1u) % 4u)
				{
				case 2u:
					array = new byte[num];
					num2 = (int)((num3 * 830285486) ^ 0x4E305C28);
					continue;
				case 1u:
					memoryStream_0.Read(array, 0, num);
					stringBuilder.Append(Encoding.ASCII.GetString(array));
					num2 = (int)(num3 * 235150664) ^ -1274461566;
					continue;
				case 0u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	public override string imethod_1()
	{
		return string_0;
	}

	public virtual byte[] imethod_2()
	{
		return new byte[0];
	}
}
