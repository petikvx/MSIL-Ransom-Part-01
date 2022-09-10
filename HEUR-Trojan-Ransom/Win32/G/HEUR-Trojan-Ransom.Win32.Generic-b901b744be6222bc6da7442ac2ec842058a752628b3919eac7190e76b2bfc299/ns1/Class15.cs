using System;

namespace ns1;

internal sealed class Class15
{
	private readonly Guid guid_0;

	private Class14 class14_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	private DateTime dateTime_0;

	private int int_0;

	internal Class15(Class14 class14_1, string string_3, string string_4, string string_5, DateTime dateTime_1, int int_1)
	{
		ref readonly Guid reference = ref guid_0;
		reference = new Guid("{E161255A-37C3-11D2-BCAA-00C04FD929DB}");
		if (class14_0 == null)
		{
			class14_0 = class14_1;
		}
		dateTime_0 = dateTime_1;
		int_0 = int_1;
		string_2 = string_5;
		string_0 = string_3;
		string_1 = string_4;
	}
}
