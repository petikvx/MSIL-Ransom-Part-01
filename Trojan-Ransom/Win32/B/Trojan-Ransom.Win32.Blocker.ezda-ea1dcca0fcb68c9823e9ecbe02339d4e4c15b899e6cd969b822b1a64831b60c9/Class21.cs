using System.Collections.Generic;
using System.Net;
using UPNPLib;
using insomnia;

internal class Class21
{
	private static IPAddress ipaddress_0 = Delegate286.smethod_0(bool_0: true);

	private static UPnPService upnPService_0 = null;

	private static UPnPService smethod_0(UPnPDevice upnPDevice_0)
	{
		foreach (UPnPService service in upnPDevice_0.Services)
		{
			if (!Delegate278.smethod_0(service))
			{
				if (upnPDevice_0.HasChildren)
				{
					return Delegate279.smethod_0(upnPDevice_0.Children);
				}
				continue;
			}
			return service;
		}
		return null;
	}

	private static UPnPService smethod_1(UPnPDevices upnPDevices_0)
	{
		foreach (UPnPDevice item in upnPDevices_0)
		{
			UPnPService uPnPService = Delegate280.smethod_0(item);
			if (uPnPService != null)
			{
				return uPnPService;
			}
		}
		return null;
	}

	private static bool smethod_2(UPnPService upnPService_1)
	{
		return Delegate63.smethod_1(upnPService_1.ServiceTypeIdentifier, (string)_003CModule_003E.smethod_0(3647077960u));
	}

	public static bool smethod_3(int int_0, string string_0)
	{
		if (upnPService_0 == null)
		{
			return false;
		}
		object[] object_ = new object[3] { "", int_0, string_0 };
		object object_2 = Delegate281.smethod_0();
		try
		{
			upnPService_0.InvokeAction((string)_003CModule_003E.smethod_0(3658889706u), object_, ref object_2);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_4()
	{
		upnPService_0 = null;
		UPnPDeviceFinder uPnPDeviceFinder = (UPnPDeviceFinder)Delegate284.smethod_0(Delegate283.smethod_0(Delegate282.smethod_0((string)_003CModule_003E.smethod_0(757068720u))));
		upnPService_0 = Delegate279.smethod_0(uPnPDeviceFinder.FindByType((string)_003CModule_003E.smethod_0(757068679u), 0u));
		return upnPService_0 != null;
	}

	public static string smethod_5()
	{
		if (upnPService_0 == null)
		{
			return "";
		}
		object object_ = Delegate281.smethod_0();
		object object_2 = Delegate281.smethod_0();
		upnPService_0.InvokeAction((string)_003CModule_003E.smethod_0(2145384610u), object_, ref object_2);
		object[] array = (object[])object_2;
		return (string)array[0];
	}

	public static List<M> smethod_6()
	{
		if (upnPService_0 == null)
		{
			return null;
		}
		List<M> list = new List<M>();
		bool flag = false;
		int num = 0;
		while (!flag)
		{
			object[] object_ = new object[1] { num };
			object object_2 = Delegate281.smethod_0();
			try
			{
				upnPService_0.InvokeAction((string)_003CModule_003E.smethod_0(4022186141u), object_, ref object_2);
				object[] array = (object[])object_2;
				num++;
				M item = default(M);
				item.externalPort = (ushort)array[1];
				item.internalPort = (ushort)array[3];
				item.protocol = (string)array[2];
				item.description = (string)array[6];
				list.Add(item);
			}
			catch
			{
				flag = true;
			}
		}
		return list;
	}

	public static bool smethod_7(int int_0, string string_0)
	{
		if (upnPService_0 == null)
		{
			return false;
		}
		object[] object_ = new object[3] { "", int_0, string_0 };
		object object_2 = Delegate281.smethod_0();
		try
		{
			upnPService_0.InvokeAction((string)_003CModule_003E.smethod_0(3165352811u), object_, ref object_2);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_8(int int_0, int int_1, string string_0, string string_1, int int_2 = 0)
	{
		if (upnPService_0 != null && !Delegate285.smethod_0(int_0, string_0))
		{
			object[] object_ = new object[8]
			{
				"",
				int_0,
				string_0,
				int_1,
				Delegate69.smethod_0(ipaddress_0),
				true,
				string_1,
				int_2
			};
			object object_2 = Delegate281.smethod_0();
			try
			{
				upnPService_0.InvokeAction((string)_003CModule_003E.smethod_0(3971531340u), object_, ref object_2);
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}
}
