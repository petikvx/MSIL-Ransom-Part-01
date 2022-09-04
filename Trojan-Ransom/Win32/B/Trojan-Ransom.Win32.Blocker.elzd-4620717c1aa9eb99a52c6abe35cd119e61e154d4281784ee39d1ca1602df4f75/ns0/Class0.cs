using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithoutUI;

namespace ns0;

internal sealed class Class0
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1826)]
	private struct Struct0
	{
	}

	internal static Struct1 struct1_0/* Not supported: data(24 4F E1 2E B8 AB EE 27 70 B4 41 C4 F2 98 EB AD DA 9E 75 62 08 98 3A 33 3A 7C A6 68 0F 14 61 53 3E 6F 25 9E 87 B0 53 DA 4C 97 39 C9 C8 B2 D3 D4 78 59 97 0F 74 47 0B 8B 15 AD F3 3B 05 85 17 5C 52 ED 86 83 72 4C 26 2A 4A 99 15 6F 5E 6F 6A 86 A8 D0 EE B4 7C 52 DE F6 63 98 89 D8 BC 18 D5 C6 7F DC 77 DA 2C 50 61 2C 33 6C C3 D9 31 9A 2D A5 43 6C 92 33 95 61 DF 00 0F 8F 1F D9 C2 4C 6D 32 C3 4E EE 81 F7 8E 5A 57 6E C2 81 0F 8D 04 C4 C7 6B E2 95 4F 84 A1 30 1D FC 76 CB 9B 30 87 69 E5 FE 91 16 E2 AB AB AC B4 12 3A C4 D2 DE CF 71 0A C9 57 6D DE B6 1D AD 21 1D D0 83 80 C1 BD 27 E5 58 9B 0F FB ED E1 1C BE 36 E0 3D 49 DC 5D 3E 2C 05 C1) */;

	internal static byte[] byte_0;

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[913];

	private static readonly object object_0;

	internal static byte byte_1/* Not supported: data(00) */;

	private static void Main(string[] args)
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		byte[] array = default(byte[]);
		int[] int_ = default(int[]);
		int num = default(int);
		object obj = default(object);
		int num2 = default(int);
		long num3 = default(long);
		int num4 = default(int);
		object obj2 = default(object);
		object obj3 = default(object);
		IEvidenceFactory val = default(IEvidenceFactory);
		object obj4 = default(object);
		int num5 = default(int);
		try
		{
			if (!UnhandledExceptionHandlerWithoutUI.AttachApp())
			{
				return;
			}
			array = byte_0;
			int_ = Class1.int_0;
			num = 3;
			Class2.Class3.smethod_2();
			obj = new object[0];
			num2 = Class2.Class3.smethod_3(new Random(), 300, 750, 182, 211);
			num = 4;
			num3 = Class2.Class3.smethod_5(805, 807);
			_ = Class2.Class3.smethod_5(8, 10) - num3;
			try
			{
				num4 = 5;
				obj2 = new ResourceManager(Class5.Class6.smethod_0(1372442932, 15L, 6), Class2.smethod_0(303, 289));
				num4 = 3;
				obj3 = smethod_0((byte[])Class2.smethod_2((ResourceManager)obj2, Class5.Class6.smethod_0(1372442931, 9L, 7), '\u008f', 246), Class5.Class6.smethod_0(1372442897, 14L, 1));
				num4 = 8;
				Class5.Class6.smethod_2(obj2 as ResourceManager, 'Ǯ', 494);
				val = (IEvidenceFactory)Class5.Class6.smethod_4(obj3 as byte[], 1002, 'ϝ');
				num4 = 1;
				if (Class2.Class3.smethod_6(val as Assembly, 1009, 971).GetParameters().Length > 0)
				{
					num4 = 0;
					obj4 = new object[1];
					((object[])obj4)[0] = args;
					obj = obj4 as object[];
					num4 = 7;
				}
				else
				{
					num4 = 7;
				}
				(val as Assembly).EntryPoint!.Invoke(null, (object[])obj);
			}
			catch
			{
			}
			num5 = 4;
		}
		catch (Exception exception_)
		{
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			UnhandledExceptionHandler.EntryPointException(exception_, new object[16]
			{
				obj, num2, num3, obj2, obj3, val, obj4, num6, num, num7,
				num4, array, int_, num8, num5, args
			});
		}
	}

	public static byte[] smethod_0(byte[] byte_2, string string_0)
	{
		int[] int_ = default(int[]);
		byte[] array = default(byte[]);
		object obj = default(object);
		int num = default(int);
		Array array2 = default(Array);
		Array array3 = default(Array);
		int num2 = default(int);
		int num3 = default(int);
		byte b = default(byte);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			int_ = Class1.int_0;
			array = byte_0;
			obj = Class2.Class3.smethod_7(Class2.smethod_3('ǯ', 404), string_0, 'ȉ', 592);
			num = 20;
			array2 = new byte[256];
			array3 = new byte[256];
			num2 = 0;
			num = 7;
			while (num2 < 256)
			{
				num = 16;
				(array2 as byte[])[num2] = (byte)num2;
				((byte[])array3)[num2] = (obj as byte[])[num2 % Class2.Class4.smethod_0((Array)(byte[])obj, 0, 311, 298)];
				num = 8;
				num2++;
				num = 7;
			}
			num = 12;
			num3 = 0;
			num2 = 0;
			num = 3;
			while (num2 < 256)
			{
				num = 4;
				num3 = (num3 + (array2 as byte[])[num2] + ((byte[])array3)[num2]) % 256;
				num = 19;
				b = ((byte[])array2)[num2];
				(array2 as byte[])[num2] = ((byte[])array2)[num3];
				num = 0;
				((byte[])array2)[num3] = b;
				num2++;
				num = 3;
			}
			num = 15;
			num3 = 0;
			num2 = 0;
			num4 = 0;
			num = 9;
			while (num4 < byte_2.GetLength(0))
			{
				num = 6;
				num2 = (num2 + 1) % 256;
				num3 = (num3 + (array2 as byte[])[num2]) % 256;
				num = 13;
				b = ((byte[])array2)[num2];
				((byte[])array2)[num2] = (array2 as byte[])[num3];
				num = 14;
				(array2 as byte[])[num3] = b;
				num5 = (((byte[])array2)[num2] + (array2 as byte[])[num3]) % 256;
				num = 1;
				byte_2[num4] ^= (array2 as byte[])[num5];
				num = 11;
				num4++;
				num = 9;
			}
			num = 17;
			return byte_2;
		}
		catch (Exception exception_)
		{
			int num6 = default(int);
			StackFrameHelper.CreateExceptionN(exception_, new object[14]
			{
				obj, array2, array3, b, num2, num3, num4, num5, num6, num,
				int_, array, byte_2, string_0
			});
			throw;
		}
	}

	public Class0()
	{
		try
		{
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}

	static Class0()
	{
		char[] array = new char[8];
		array[7] = '✜';
		array[1] = '៰';
		array[3] = '⽮';
		array[2] = '㪡';
		array[5] = '㼚';
		array[0] = '┒';
		array[6] = '\u10c9';
		array[4] = '㡍';
		object_0 = new string[46];
		array_0 = array;
	}
}
