using System.Net.NetworkInformation;
using System.Web;

namespace HealthCheckAssetExt;

internal class clsNetworking
{
	internal void addNetworkAdapters(string strClassName, string strGuid, string strFileName)
	{
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			string text = "";
			string text2 = "";
			clsCommon clsCommon2 = new clsCommon();
			int num = 0;
			NetworkInterface[] array = allNetworkInterfaces;
			foreach (NetworkInterface networkInterface in array)
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Tunnel)
				{
					text = "<PROPERTY NAME=\"Name\" TYPE=\"string\"><VALUE>" + HttpUtility.HtmlEncode(networkInterface.Name) + "</VALUE></PROPERTY>";
					text = text + "<PROPERTY NAME=\"Description\" TYPE=\"string\"><VALUE>" + HttpUtility.HtmlEncode(networkInterface.Description) + "</VALUE></PROPERTY>";
					text = text + "<PROPERTY NAME=\"NetworkInterfaceType\" TYPE=\"string\"><VALUE>" + networkInterface.NetworkInterfaceType.ToString() + "</VALUE></PROPERTY>";
					text = text + "<PROPERTY NAME=\"Speed\" TYPE=\"string\"><VALUE>" + networkInterface.Speed + "</VALUE></PROPERTY>";
					text = text + "<PROPERTY NAME=\"OperationalStatus\" TYPE=\"string\"><VALUE>" + networkInterface.OperationalStatus.ToString() + "</VALUE></PROPERTY>";
					object obj = text2;
					text2 = string.Concat(obj, "<SIMPLEREQ><IMETHODCALL NAME=\"CreateInstance\"><LOCALNAMESPACEPATH><NAMESPACE NAME=\"root\" /><NAMESPACE NAME=\"cimv2\" /></LOCALNAMESPACEPATH><IPARAMVALUE NAME=\"NewInstance\"><INSTANCE CLASSNAME=\"", strClassName, "\"><QUALIFIER NAME=\"ModTime\" TYPE=\"datetime\"><VALUE>20060608114719.538000+180</VALUE></QUALIFIER><PROPERTY NAME=\"Index\" TYPE=\"uint32\"><VALUE>", num, "</VALUE></PROPERTY><PROPERTY NAME=\"GUID\" TYPE=\"string\"><VALUE>", strGuid, "</VALUE></PROPERTY>", text, "</INSTANCE></IPARAMVALUE></IMETHODCALL></SIMPLEREQ>");
					num++;
					text = "";
				}
			}
			clsCommon2.writeXML(text2, strFileName);
		}
		catch
		{
		}
	}
}
