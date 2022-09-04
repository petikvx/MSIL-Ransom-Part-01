using System.Management;
using ns0;

namespace USB2;

public class USBSerialNumber
{
	private string string_0;

	private string string_1;

	public string getSerialNumberFromDriveLetter(string driveLetter)
	{
		string_1 = Delegate190.smethod_0(driveLetter);
		if (!Delegate83.smethod_0(string_1, ":"))
		{
			string_1 = Delegate271.smethod_0(string_1, ":");
		}
		method_0();
		return string_0;
	}

	private void method_0()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		ManagementObjectSearcher object_ = Delegate324.smethod_0("SELECT * FROM Win32_LogicalDiskToPartition");
		ManagementObjectEnumerator val = Delegate16.smethod_0(Delegate136.smethod_0(object_));
		try
		{
			while (Delegate204.smethod_0(val))
			{
				ManagementObject object_2 = (ManagementObject)Delegate149.smethod_0(val);
				string[] array = null;
				string text = method_2(Delegate337.smethod_0(Delegate163.smethod_0(object_2, "Dependent")));
				array = Delegate177.smethod_0(method_2(Delegate337.smethod_0(Delegate163.smethod_0(object_2, "Antecedent"))), new char[1] { ',' });
				string text2 = Delegate285.smethod_0(Delegate298.smethod_0(array[0], 0, 6));
				if (!Delegate218.smethod_0(text, string_1))
				{
					continue;
				}
				ManagementObjectSearcher object_3 = Delegate324.smethod_0("SELECT * FROM Win32_DiskDrive");
				ManagementObjectEnumerator val2 = Delegate16.smethod_0(Delegate136.smethod_0(object_3));
				try
				{
					while (Delegate204.smethod_0(val2))
					{
						ManagementObject object_4 = (ManagementObject)Delegate149.smethod_0(val2);
						if (Delegate218.smethod_0(Delegate337.smethod_0(Delegate163.smethod_0(object_4, "Name")), Delegate271.smethod_0("\\\\.\\PHYSICALDRIVE", text2)) & Delegate218.smethod_0(Delegate337.smethod_0(Delegate163.smethod_0(object_4, "InterfaceType")), "USB"))
						{
							string_0 = method_1(Delegate337.smethod_0(Delegate163.smethod_0(object_4, "PNPDeviceID")));
						}
					}
				}
				finally
				{
					if (val2 != null)
					{
						Delegate69.smethod_0(val2);
					}
				}
			}
		}
		finally
		{
			if (val != null)
			{
				Delegate69.smethod_0(val);
			}
		}
	}

	private string method_1(string string_2)
	{
		string[] array = Delegate177.smethod_0(string_2, new char[1] { '\\' });
		int num = array.Length - 1;
		string[] array2 = Delegate177.smethod_0(array[num], new char[1] { '&' });
		return array2[0];
	}

	private string method_2(string string_2)
	{
		string text = "";
		int num = 0;
		int num2 = 0;
		num = Delegate245.smethod_0(string_2, "\"");
		num2 = Delegate123.smethod_0(string_2, "\"", num + 1);
		return Delegate232.smethod_0(string_2, num + 1, num2 - num - 1);
	}
}
