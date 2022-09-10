using System.Text;
using System.Web;
using Microsoft.Win32;

namespace HealthCheckAssetExt;

internal class clsPrograms
{
	internal void addProgramsInfo(string strClassName, string strGuid, string strFileName)
	{
		try
		{
			clsCommon clsCommon2 = new clsCommon();
			string text = "";
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			StringBuilder stringBuilder = new StringBuilder();
			if (Registry.LocalMachine.OpenSubKey(name) != null)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
				string[] subKeyNames = registryKey.GetSubKeyNames();
				if (subKeyNames == null)
				{
					return;
				}
				bool flag = false;
				object obj = null;
				object obj2 = null;
				int num = 0;
				string[] array = subKeyNames;
				foreach (string name2 in array)
				{
					flag = false;
					obj = registryKey.OpenSubKey(name2)!.GetValue("Publisher", null);
					if (obj == null)
					{
						flag = true;
					}
					obj2 = registryKey.OpenSubKey(name2)!.GetValue("SystemComponent", null);
					if (obj2 == null)
					{
						text2 = (string)registryKey.OpenSubKey(name2)!.GetValue("DisplayName");
						if (!flag && text2 != null && text2 != "")
						{
							text3 = (string)registryKey.OpenSubKey(name2)!.GetValue("Publisher");
							text4 = (string)registryKey.OpenSubKey(name2)!.GetValue("DisplayVersion");
							text = "<PROPERTY NAME=\"DisplayName\" TYPE=\"string\"><VALUE>" + HttpUtility.HtmlEncode(text2) + "</VALUE></PROPERTY>";
							text = text + "<PROPERTY NAME=\"Manufacturer\" TYPE=\"string\"><VALUE>" + HttpUtility.HtmlEncode(text3) + "</VALUE></PROPERTY>";
							text = text + "<PROPERTY NAME=\"Version\" TYPE=\"string\"><VALUE>" + HttpUtility.HtmlEncode(text4) + "</VALUE></PROPERTY>";
							stringBuilder.Append("<SIMPLEREQ><IMETHODCALL NAME=\"CreateInstance\"><LOCALNAMESPACEPATH><NAMESPACE NAME=\"root\" /><NAMESPACE NAME=\"cimv2\" /></LOCALNAMESPACEPATH><IPARAMVALUE NAME=\"NewInstance\"><INSTANCE CLASSNAME=\"" + strClassName + "\"><QUALIFIER NAME=\"ModTime\" TYPE=\"datetime\"><VALUE>20060608114719.538000+180</VALUE></QUALIFIER><PROPERTY NAME=\"Index\" TYPE=\"uint32\"><VALUE>" + num + "</VALUE></PROPERTY><PROPERTY NAME=\"GUID\" TYPE=\"string\"><VALUE>" + strGuid + "</VALUE></PROPERTY>" + text + "</INSTANCE></IPARAMVALUE></IMETHODCALL></SIMPLEREQ>");
							num++;
						}
					}
					text3 = "";
					text4 = "";
					text = "";
					obj = null;
					obj2 = null;
				}
			}
			clsCommon2.writeXML(stringBuilder.ToString(), strFileName);
		}
		catch
		{
		}
	}
}
