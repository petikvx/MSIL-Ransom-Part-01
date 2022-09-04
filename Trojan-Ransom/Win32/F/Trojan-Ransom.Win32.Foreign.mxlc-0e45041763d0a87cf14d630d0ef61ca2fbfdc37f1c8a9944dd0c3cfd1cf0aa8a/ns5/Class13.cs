using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ns5;

internal class Class13
{
	internal delegate int Delegate0(int int_0, int int_1, ref Struct5 struct5_0);

	public struct Struct5
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	private string string_0;

	internal static IntPtr intptr_0 = (IntPtr)0;

	internal static string string_1 = "";

	internal static Delegate0 delegate0_0 = null;

	public Class13(string string_2)
	{
		try
		{
			string_0 = string_2;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
