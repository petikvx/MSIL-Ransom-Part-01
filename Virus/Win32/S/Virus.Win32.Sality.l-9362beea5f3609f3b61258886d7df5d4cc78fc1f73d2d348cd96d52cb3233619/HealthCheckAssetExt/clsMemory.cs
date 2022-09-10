using System;
using System.Management;

namespace HealthCheckAssetExt;

internal class clsMemory
{
	internal void addMemoryInfo(string strClassName, string strGuid, string strFileName)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		try
		{
			clsCommon clsCommon2 = new clsCommon();
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text4 = ((ManagementBaseObject)val3).get_Item("Capacity").ToString();
					num += Convert.ToDouble(text4);
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			ManagementObjectEnumerator enumerator2 = val2.Get().GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					ManagementObject val4 = (ManagementObject)enumerator2.get_Current();
					text3 = ((ManagementBaseObject)val4).get_Item("TotalPhysicalMemory").ToString();
					num2 = Convert.ToDouble(text3);
				}
			}
			finally
			{
				((IDisposable)enumerator2)?.Dispose();
			}
			text = "<PROPERTY NAME=\"TotalMemory\" TYPE=\"string\"><VALUE>" + num + "</VALUE></PROPERTY>";
			if (num != num2)
			{
				num3 = num - num2;
				text = text + "<PROPERTY NAME=\"SystemMemory\" TYPE=\"string\"><VALUE>" + text3 + "</VALUE></PROPERTY>";
				text = text + "<PROPERTY NAME=\"GraphicsMemory\" TYPE=\"string\"><VALUE>" + num3 + "</VALUE></PROPERTY>";
			}
			string text5 = text2;
			text2 = text5 + "<SIMPLEREQ><IMETHODCALL NAME=\"CreateInstance\"><LOCALNAMESPACEPATH><NAMESPACE NAME=\"root\" /><NAMESPACE NAME=\"cimv2\" /></LOCALNAMESPACEPATH><IPARAMVALUE NAME=\"NewInstance\"><INSTANCE CLASSNAME=\"" + strClassName + "\"><QUALIFIER NAME=\"ModTime\" TYPE=\"datetime\"><VALUE>20060608114719.538000+180</VALUE></QUALIFIER><PROPERTY NAME=\"Index\" TYPE=\"uint32\"><VALUE>1</VALUE></PROPERTY><PROPERTY NAME=\"GUID\" TYPE=\"string\"><VALUE>" + strGuid + "</VALUE></PROPERTY>" + text + "</INSTANCE></IPARAMVALUE></IMETHODCALL></SIMPLEREQ>";
			text = "";
			clsCommon2.writeXML(text2, strFileName);
		}
		catch
		{
		}
	}
}
