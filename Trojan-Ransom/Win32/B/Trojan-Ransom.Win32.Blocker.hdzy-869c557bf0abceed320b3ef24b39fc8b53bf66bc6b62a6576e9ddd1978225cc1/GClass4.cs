using System;
using System.Collections.Generic;
using System.Net;
using UPNPLib;

public static class GClass4
{
	private static IPAddress ipaddress_0 = GClass1.smethod_0(bool_0: true);

	private static UPnPService upnPService_0 = null;

	private static UPnPService smethod_0(UPnPDevice upnPDevice_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (UPnPService item in (IUPnPServices)((IUPnPDevice)upnPDevice_0).get_Services())
		{
			UPnPService val = item;
			if (!smethod_2(val))
			{
				if (((IUPnPDevice)upnPDevice_0).get_HasChildren())
				{
					return smethod_1(((IUPnPDevice)upnPDevice_0).get_Children());
				}
				continue;
			}
			return val;
		}
		return null;
	}

	private static UPnPService smethod_1(UPnPDevices upnPDevices_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		foreach (UPnPDevice item in (IUPnPDevices)upnPDevices_0)
		{
			UPnPDevice upnPDevice_ = item;
			UPnPService val = smethod_0(upnPDevice_);
			if (val != null)
			{
				return val;
			}
		}
		return null;
	}

	private static bool smethod_2(UPnPService upnPService_1)
	{
		return ((IUPnPService)upnPService_1).get_ServiceTypeIdentifier() == "urn:schemas-upnp-org:service:WANIPConnection:1";
	}

	public static bool smethod_3(int int_0, string string_0)
	{
		if (upnPService_0 == null)
		{
			return false;
		}
		object[] array = new object[3]
		{
			string.Empty,
			int_0,
			string_0
		};
		object obj = new object();
		try
		{
			((IUPnPService)upnPService_0).InvokeAction("DeletePortMapping", (object)array, ref obj);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_4()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		upnPService_0 = null;
		UPnPDeviceFinder val = (UPnPDeviceFinder)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("E2085F28-FEB7-404A-B8E7-E659BDEAAA02")));
		upnPService_0 = smethod_1(((IUPnPDeviceFinder)val).FindByType("urn:schemas-upnp-org:device:InternetGatewayDevice:1", 0u));
		return upnPService_0 != null;
	}

	public static string smethod_5()
	{
		if (upnPService_0 == null)
		{
			return string.Empty;
		}
		object obj = new object();
		object obj2 = new object();
		((IUPnPService)upnPService_0).InvokeAction("GetExternalIPAddress", obj, ref obj2);
		object[] array = (object[])obj2;
		return (string)array[0];
	}

	public static List<GStruct0> smethod_6()
	{
		if (upnPService_0 == null)
		{
			return null;
		}
		List<GStruct0> list = new List<GStruct0>();
		bool flag = false;
		int num = 0;
		while (!flag)
		{
			object[] array = new object[1] { num };
			object obj = new object();
			try
			{
				((IUPnPService)upnPService_0).InvokeAction("GetGenericPortMappingEntry", (object)array, ref obj);
				object[] array2 = (object[])obj;
				num++;
				GStruct0 item = default(GStruct0);
				item.ushort_0 = (ushort)array2[1];
				item.ushort_1 = (ushort)array2[3];
				item.string_0 = (string)array2[2];
				item.string_1 = (string)array2[6];
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
		object[] array = new object[3]
		{
			string.Empty,
			int_0,
			string_0
		};
		object obj = new object();
		try
		{
			((IUPnPService)upnPService_0).InvokeAction("GetSpecificPortMappingEntry", (object)array, ref obj);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_8(int int_0, int int_1, string string_0, string string_1)
	{
		int num = 0;
		if (upnPService_0 != null && !smethod_7(int_0, string_0))
		{
			object[] array = new object[8]
			{
				string.Empty,
				int_0,
				string_0,
				int_1,
				ipaddress_0.ToString(),
				true,
				string_1,
				num
			};
			object obj = new object();
			try
			{
				((IUPnPService)upnPService_0).InvokeAction("AddPortMapping", (object)array, ref obj);
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
