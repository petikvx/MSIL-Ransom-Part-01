using System.Management;
using System.ServiceProcess;

namespace nbBC5z6UyEsRVOl4;

public class DViQSZoLzIUbQjlcdrIp8hak48 : ServiceController
{
	public string Description
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			string text = "Win32_Service.Name='" + ((ServiceController)this).get_ServiceName() + "'";
			ManagementPath val = new ManagementPath(text);
			ManagementObject val2 = new ManagementObject(val);
			if (((ManagementBaseObject)val2).get_Item("Description") != null)
			{
				return ((ManagementBaseObject)val2).get_Item("Description").ToString();
			}
			return null;
		}
	}

	public string StartupType
	{
		get
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			if (((ServiceController)this).get_ServiceName() != null)
			{
				string text = "Win32_Service.Name='" + ((ServiceController)this).get_ServiceName() + "'";
				ManagementPath val = new ManagementPath(text);
				ManagementObject val2 = new ManagementObject(val);
				return ((ManagementBaseObject)val2).get_Item("StartMode").ToString();
			}
			return null;
		}
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			switch (value)
			{
			}
			if (((ServiceController)this).get_ServiceName() != null)
			{
				string text = "Win32_Service.Name='" + ((ServiceController)this).get_ServiceName() + "'";
				ManagementPath val = new ManagementPath(text);
				ManagementObject val2 = new ManagementObject(val);
				val2.InvokeMethod("ChangeStartMode", new object[1] { value });
			}
		}
	}

	public DViQSZoLzIUbQjlcdrIp8hak48()
	{
	}

	public DViQSZoLzIUbQjlcdrIp8hak48(string name)
		: base(name)
	{
	}

	public DViQSZoLzIUbQjlcdrIp8hak48(string name, string machineName)
		: base(name, machineName)
	{
	}
}
