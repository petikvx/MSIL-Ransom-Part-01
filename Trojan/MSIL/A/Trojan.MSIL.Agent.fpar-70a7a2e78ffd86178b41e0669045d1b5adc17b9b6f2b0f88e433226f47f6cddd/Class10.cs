using System;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class10
{
	public static void smethod_0(GStruct2 gstruct2_0)
	{
		switch (gstruct2_0.byte_1)
		{
		case 0:
			smethod_1(gstruct2_0.object_0);
			break;
		case 1:
			smethod_2(gstruct2_0.object_0);
			break;
		case 2:
			smethod_3(gstruct2_0.object_0);
			break;
		case 3:
			smethod_4(gstruct2_0.object_0);
			break;
		case 4:
			smethod_5(gstruct2_0.object_0);
			break;
		case 5:
			smethod_6(gstruct2_0.object_0);
			break;
		}
	}

	public static void smethod_1(object[] object_0)
	{
		Guid guid_ = (Guid)object_0[0];
		string string_ = (string)object_0[1];
		smethod_7(guid_, string_);
	}

	public static void smethod_2(object[] object_0)
	{
		Guid guid_ = (Guid)object_0[0];
		string string_ = (string)object_0[1];
		long long_ = (long)object_0[2];
		string string_2 = (string)object_0[3];
		smethod_8(guid_, string_, long_, string_2);
	}

	public static void smethod_3(object[] object_0)
	{
		Guid guid_ = (Guid)object_0[0];
		string string_ = (string)object_0[1];
		long long_ = (long)object_0[2];
		long long_2 = (long)object_0[3];
		string string_2 = (string)object_0[4];
		smethod_9(guid_, string_, long_, long_2, string_2);
	}

	public static void smethod_4(object[] object_0)
	{
		Guid guid_ = (Guid)object_0[0];
		string string_ = (string)object_0[1];
		long long_ = (long)object_0[2];
		smethod_10(guid_, string_, long_);
	}

	public static void smethod_5(object[] object_0)
	{
		Guid guid_ = (Guid)object_0[0];
		string string_ = (string)object_0[1];
		long long_ = (long)object_0[2];
		byte[] byte_ = (byte[])object_0[3];
		smethod_11(guid_, string_, long_, byte_);
	}

	public static void smethod_6(object[] object_0)
	{
		Guid guid_ = (Guid)object_0[0];
		string string_ = (string)object_0[1];
		long long_ = (long)object_0[2];
		int int_ = (int)object_0[3];
		smethod_12(guid_, string_, long_, int_);
	}

	public static void smethod_7(Guid guid_0, string string_0)
	{
		GStruct3 gStruct = Class7.smethod_1(string_0);
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.FileCommand, 0, new object[3] { guid_0, gStruct.long_0, gStruct.string_0 });
	}

	public static void smethod_8(Guid guid_0, string string_0, long long_0, string string_1)
	{
		bool flag = Class7.smethod_2(string_0, long_0, string_1);
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.FileCommand, 1, new object[2] { guid_0, flag });
	}

	public static void smethod_9(Guid guid_0, string string_0, long long_0, long long_1, string string_1)
	{
		bool flag = Class7.smethod_3(string_0, long_0, long_1, string_1);
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.FileCommand, 2, new object[2] { guid_0, flag });
	}

	public static void smethod_10(Guid guid_0, string string_0, long long_0)
	{
		string text = Class7.smethod_4(string_0, long_0);
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.FileCommand, 3, new object[2] { guid_0, text });
	}

	public static void smethod_11(Guid guid_0, string string_0, long long_0, byte[] byte_0)
	{
		Class7.smethod_6(string_0, byte_0, long_0);
		Class8.smethod_90(Class18.string_0, bool_6: true, CommandType.FileCommand, 4, new object[2] { guid_0, byte_0.Length });
	}

	public static void smethod_12(Guid guid_0, string string_0, long long_0, int int_0)
	{
		byte[] array = Class7.smethod_5(string_0, long_0, int_0);
		Class8.smethod_90(Class18.string_0, bool_6: true, CommandType.FileCommand, 5, new object[2] { guid_0, array });
	}
}
