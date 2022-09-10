using System.Printing;

namespace HealthCheckAssetExt;

internal class clsPrinters
{
	internal void addPrintersInfo(string strClassName, string strGuid, string strFileName)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			LocalPrintServer val = new LocalPrintServer((PrintSystemDesiredAccess)0);
			PrintQueue defaultPrintQueue = val.get_DefaultPrintQueue();
			string text = "";
			string text2 = "";
			clsCommon clsCommon2 = new clsCommon();
			text = "<PROPERTY NAME=\"Description\" TYPE=\"string\"><VALUE>" + defaultPrintQueue.get_Description() + "</VALUE></PROPERTY>";
			text = text + "<PROPERTY NAME=\"PortName\" TYPE=\"string\"><VALUE>" + ((PrintSystemObject)defaultPrintQueue.get_QueuePort()).get_Name() + "</VALUE></PROPERTY>";
			text = text + "<PROPERTY NAME=\"Status\" TYPE=\"string\"><VALUE>" + ((object)defaultPrintQueue.get_QueueStatus()).ToString() + "</VALUE></PROPERTY>";
			object obj = text2;
			text2 = string.Concat(obj, "<SIMPLEREQ><IMETHODCALL NAME=\"CreateInstance\"><LOCALNAMESPACEPATH><NAMESPACE NAME=\"root\" /><NAMESPACE NAME=\"cimv2\" /></LOCALNAMESPACEPATH><IPARAMVALUE NAME=\"NewInstance\"><INSTANCE CLASSNAME=\"", strClassName, "\"><QUALIFIER NAME=\"ModTime\" TYPE=\"datetime\"><VALUE>20060608114719.538000+180</VALUE></QUALIFIER><PROPERTY NAME=\"Index\" TYPE=\"uint32\"><VALUE>", 0, "</VALUE></PROPERTY><PROPERTY NAME=\"GUID\" TYPE=\"string\"><VALUE>", strGuid, "</VALUE></PROPERTY>", text, "</INSTANCE></IPARAMVALUE></IMETHODCALL></SIMPLEREQ>");
			clsCommon2.writeXML(text2, strFileName);
			((PrintSystemObject)defaultPrintQueue).Dispose();
			((PrintSystemObject)val).Dispose();
		}
		catch
		{
		}
	}
}
