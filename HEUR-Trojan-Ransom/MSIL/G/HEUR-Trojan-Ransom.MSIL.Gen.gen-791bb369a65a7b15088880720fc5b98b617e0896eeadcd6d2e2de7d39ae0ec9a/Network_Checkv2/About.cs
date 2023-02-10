using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Network_Checkv2;

[DesignerGenerated]
public class About : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("btnExit")]
	internal virtual Button btnExit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual LinkLabel LinkLabel1
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			LinkLabel linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.add_LinkClicked(val);
			}
		}
	}

	[field: AccessedThroughProperty("RichTextBox10")]
	internal virtual RichTextBox RichTextBox10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox9")]
	internal virtual RichTextBox RichTextBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox1")]
	internal virtual RichTextBox RichTextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox8")]
	internal virtual RichTextBox RichTextBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox7")]
	internal virtual RichTextBox RichTextBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnCloseAbout
	{
		[CompilerGenerated]
		get
		{
			return _btnCloseAbout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnCloseAbout_Click_1;
			Button val = _btnCloseAbout;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnCloseAbout = value;
			val = _btnCloseAbout;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("RichTextBox6")]
	internal virtual RichTextBox RichTextBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox5")]
	internal virtual RichTextBox RichTextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox4")]
	internal virtual RichTextBox RichTextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox3")]
	internal virtual RichTextBox RichTextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox2")]
	internal virtual RichTextBox RichTextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public About()
	{
		((Form)this).add_Load((EventHandler)About_Load);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected O, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected O, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected O, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(About));
		btnExit = new Button();
		LinkLabel1 = new LinkLabel();
		RichTextBox10 = new RichTextBox();
		RichTextBox9 = new RichTextBox();
		RichTextBox1 = new RichTextBox();
		RichTextBox8 = new RichTextBox();
		RichTextBox7 = new RichTextBox();
		btnCloseAbout = new Button();
		RichTextBox6 = new RichTextBox();
		RichTextBox5 = new RichTextBox();
		RichTextBox4 = new RichTextBox();
		RichTextBox3 = new RichTextBox();
		RichTextBox2 = new RichTextBox();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)btnExit).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)btnExit).set_Location(new Point(17, 181));
		((Control)btnExit).set_Name("btnExit");
		((Control)btnExit).set_Size(new Size(75, 23));
		((Control)btnExit).set_TabIndex(1);
		((ButtonBase)btnExit).set_Text("&Exit");
		((ButtonBase)btnExit).set_UseVisualStyleBackColor(false);
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)LinkLabel1).set_Location(new Point(80, 409));
		((Control)LinkLabel1).set_Name("LinkLabel1");
		((Control)LinkLabel1).set_Size(new Size(187, 16));
		((Control)LinkLabel1).set_TabIndex(29);
		LinkLabel1.set_TabStop(true);
		LinkLabel1.set_Text("https://sapphire1.synology.me");
		((TextBoxBase)RichTextBox10).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox10).set_BorderStyle((BorderStyle)0);
		RichTextBox10.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox10).set_Location(new Point(11, 403));
		((Control)RichTextBox10).set_Name("RichTextBox10");
		((TextBoxBase)RichTextBox10).set_ReadOnly(true);
		((Control)RichTextBox10).set_Size(new Size(63, 28));
		((Control)RichTextBox10).set_TabIndex(28);
		RichTextBox10.set_Text("Website: ");
		((TextBoxBase)RichTextBox9).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox9).set_BorderStyle((BorderStyle)0);
		RichTextBox9.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox9).set_Location(new Point(17, 267));
		((Control)RichTextBox9).set_Name("RichTextBox9");
		((TextBoxBase)RichTextBox9).set_ReadOnly(true);
		((Control)RichTextBox9).set_Size(new Size(584, 28));
		((Control)RichTextBox9).set_TabIndex(27);
		RichTextBox9.set_Text("Finally, the Failed count box indicates the total number of Connection failures.");
		((TextBoxBase)RichTextBox1).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox1).set_BorderStyle((BorderStyle)0);
		RichTextBox1.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox1).set_Location(new Point(17, 348));
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((TextBoxBase)RichTextBox1).set_ReadOnly(true);
		((Control)RichTextBox1).set_Size(new Size(584, 28));
		((Control)RichTextBox1).set_TabIndex(26);
		RichTextBox1.set_Text("Ver:");
		((TextBoxBase)RichTextBox8).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox8).set_BorderStyle((BorderStyle)0);
		RichTextBox8.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox8).set_Location(new Point(17, 321));
		((Control)RichTextBox8).set_Name("RichTextBox8");
		((TextBoxBase)RichTextBox8).set_ReadOnly(true);
		((Control)RichTextBox8).set_Size(new Size(584, 28));
		((Control)RichTextBox8).set_TabIndex(25);
		RichTextBox8.set_Text("jonesadrian@btinternet.com");
		((TextBoxBase)RichTextBox7).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox7).set_BorderStyle((BorderStyle)0);
		RichTextBox7.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox7).set_Location(new Point(17, 294));
		((Control)RichTextBox7).set_Name("RichTextBox7");
		((TextBoxBase)RichTextBox7).set_ReadOnly(true);
		((Control)RichTextBox7).set_Size(new Size(584, 28));
		((Control)RichTextBox7).set_TabIndex(24);
		RichTextBox7.set_Text("Designed and Coded by A.K.Jones");
		((ButtonBase)btnCloseAbout).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)btnCloseAbout).set_Location(new Point(519, 408));
		((Control)btnCloseAbout).set_Name("btnCloseAbout");
		((Control)btnCloseAbout).set_Size(new Size(54, 23));
		((Control)btnCloseAbout).set_TabIndex(23);
		((ButtonBase)btnCloseAbout).set_Text("&Done");
		((ButtonBase)btnCloseAbout).set_UseVisualStyleBackColor(false);
		((TextBoxBase)RichTextBox6).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox6).set_BorderStyle((BorderStyle)0);
		RichTextBox6.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox6).set_Location(new Point(17, 239));
		((Control)RichTextBox6).set_Name("RichTextBox6");
		((TextBoxBase)RichTextBox6).set_ReadOnly(true);
		((Control)RichTextBox6).set_Size(new Size(582, 28));
		((Control)RichTextBox6).set_TabIndex(22);
		RichTextBox6.set_Text("In General router faults can be fixed by a re-boot (switch it off for 30 secs then back on)");
		((TextBoxBase)RichTextBox5).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox5).set_BorderStyle((BorderStyle)0);
		RichTextBox5.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox5).set_Location(new Point(17, 153));
		((Control)RichTextBox5).set_Name("RichTextBox5");
		((TextBoxBase)RichTextBox5).set_ReadOnly(true);
		((Control)RichTextBox5).set_Size(new Size(584, 86));
		((Control)RichTextBox5).set_TabIndex(21);
		RichTextBox5.set_Text(componentResourceManager.GetString("RichTextBox5.Text"));
		((TextBoxBase)RichTextBox4).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox4).set_BorderStyle((BorderStyle)0);
		RichTextBox4.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox4).set_Location(new Point(17, 113));
		((Control)RichTextBox4).set_Name("RichTextBox4");
		((TextBoxBase)RichTextBox4).set_ReadOnly(true);
		((Control)RichTextBox4).set_Size(new Size(584, 40));
		((Control)RichTextBox4).set_TabIndex(20);
		RichTextBox4.set_Text("Note: If your Computer Interface is down then the Router will also show as down and Red as the Computer cannot get to the Router anyway.");
		((TextBoxBase)RichTextBox3).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox3).set_BorderStyle((BorderStyle)0);
		RichTextBox3.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox3).set_Location(new Point(17, 73));
		((Control)RichTextBox3).set_Name("RichTextBox3");
		((TextBoxBase)RichTextBox3).set_ReadOnly(true);
		((Control)RichTextBox3).set_Size(new Size(584, 40));
		((Control)RichTextBox3).set_TabIndex(19);
		RichTextBox3.set_Text("The Router Information box display's information regarding both your Computer local Network Interface and also the Router itself. Both of these should be Green indicating Healthy. ");
		((TextBoxBase)RichTextBox2).set_BackColor(Color.FromArgb(255, 255, 192));
		((TextBoxBase)RichTextBox2).set_BorderStyle((BorderStyle)0);
		RichTextBox2.set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RichTextBox2).set_Location(new Point(17, 33));
		((Control)RichTextBox2).set_Name("RichTextBox2");
		((TextBoxBase)RichTextBox2).set_ReadOnly(true);
		((Control)RichTextBox2).set_Size(new Size(585, 40));
		((Control)RichTextBox2).set_TabIndex(18);
		RichTextBox2.set_Text("If there is no Computer Address then it's likely the Router has not allocated an Address and therefore it may be a Router fault. Normally a Re-Boot of the Router fixes this.");
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(17, 17));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(586, 16));
		((Control)Label1).set_TabIndex(17);
		Label1.set_Text("Designed to display the local computer name and is allocated IP Adress as given from the Router.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(622, 445));
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox10);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox9);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox8);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox7);
		((Control)this).get_Controls().Add((Control)(object)btnCloseAbout);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox6);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox5);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox4);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox3);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)btnExit);
		((Form)this).set_MaximumSize(new Size(638, 484));
		((Form)this).set_MinimumSize(new Size(638, 484));
		((Control)this).set_Name("About");
		((Form)this).set_Text("About");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void About_Load(object sender, EventArgs e)
	{
		RichTextBox1.set_Text("Version: " + ModBase.FindRunningVersion());
	}

	private void btnCloseAbout_Click_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(LinkLabel1.get_Text());
	}
}
