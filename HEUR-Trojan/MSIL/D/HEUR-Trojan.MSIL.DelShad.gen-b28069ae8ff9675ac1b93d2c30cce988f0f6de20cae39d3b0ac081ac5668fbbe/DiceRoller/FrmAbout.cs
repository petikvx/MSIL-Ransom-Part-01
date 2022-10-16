using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace DiceRoller;

[DesignerGenerated]
public class FrmAbout : Form
{
	private IContainer components;

	internal virtual Button btnExit
	{
		[CompilerGenerated]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnExit_Click;
			Button val = _btnExit;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnExit = value;
			val = _btnExit;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblNotYahtzee")]
	internal virtual Label lblNotYahtzee
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmAbout()
	{
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		btnExit = new Button();
		lblNotYahtzee = new Label();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		LinkLabel1 = new LinkLabel();
		Label6 = new Label();
		((Control)this).SuspendLayout();
		((Control)btnExit).set_Location(new Point(106, 226));
		((Control)btnExit).set_Name("btnExit");
		((Control)btnExit).set_Size(new Size(75, 23));
		((Control)btnExit).set_TabIndex(0);
		((ButtonBase)btnExit).set_Text("Exit");
		((ButtonBase)btnExit).set_UseVisualStyleBackColor(true);
		lblNotYahtzee.set_AutoSize(true);
		((Control)lblNotYahtzee).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblNotYahtzee).set_Location(new Point(85, 9));
		((Control)lblNotYahtzee).set_Name("lblNotYahtzee");
		((Control)lblNotYahtzee).set_Size(new Size(119, 25));
		((Control)lblNotYahtzee).set_TabIndex(1);
		lblNotYahtzee.set_Text("Not Yahtzee");
		lblNotYahtzee.set_TextAlign((ContentAlignment)32);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(79, 34));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(128, 17));
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Christopher Guerin");
		Label1.set_TextAlign((ContentAlignment)32);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(122, 61));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(35, 15));
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("2018");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(12, 101));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(248, 13));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Dice Images 1 through 6 from Wikipedia Commons.");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(11, 114));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(254, 13));
		((Control)Label4).set_TabIndex(5);
		Label4.set_Text("By Nanami Kamimura with modifications made by Phj");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(23, 175));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(237, 13));
		((Control)Label5).set_TabIndex(6);
		Label5.set_Text("Licenced CC Attribution-ShareAlike 3.0 Unported");
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_Location(new Point(1, 188));
		((Control)LinkLabel1).set_Name("LinkLabel1");
		((Control)LinkLabel1).set_Size(new Size(281, 13));
		((Control)LinkLabel1).set_TabIndex(8);
		LinkLabel1.set_TabStop(true);
		LinkLabel1.set_Text("https://creativecommons.org/licenses/by-sa/3.0/deed.en");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Location(new Point(11, 140));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(261, 13));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("Padlock image by WiFiLeech via Wikipedia Commons");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)lblNotYahtzee);
		((Control)this).get_Controls().Add((Control)(object)btnExit);
		((Control)this).set_Name("FrmAbout");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("About");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		LinkLabel1.set_LinkVisited(true);
		Process.Start("https://creativecommons.org/licenses/by-sa/3.0/deed.en");
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
