using System;
using System.Collections;
using System.Diagnostics;

namespace ns1;

internal sealed class Class25
{
	internal struct Struct22
	{
		public IntPtr intptr_0;

		public string string_0;

		public short short_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public IntPtr intptr_1;
	}

	private static string string_0 = Convert.ToString(Process.GetCurrentProcess().MainModule!.FileName);

	internal static string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	internal static ArrayList arrayList_0 = new ArrayList();

	internal static ArrayList arrayList_1 = new ArrayList();

	internal static T smethod_0<T>(ref T gparam_0, T gparam_1)
	{
		gparam_0 = gparam_1;
		return gparam_1;
	}
}
