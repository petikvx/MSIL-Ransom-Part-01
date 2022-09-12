using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns13;

[DesignerGenerated]
public class InformationForm : Form
{
	private IContainer icontainer_0;

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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnBack
	{
		[CompilerGenerated]
		get
		{
			return _btnBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnBack_Click;
			Button val = _btnBack;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnBack = value;
			val = _btnBack;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	public InformationForm()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		btnBack = new Button();
		Label9 = new Label();
		Label10 = new Label();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Comic Sans MS", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label1).set_Location(new Point(13, 13));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(185, 38));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Single Player");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label2).set_Location(new Point(31, 51));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(685, 23));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("- The objective of the game is to shoot your opponent with the bullet in the chamber");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label3).set_Location(new Point(31, 83));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(702, 23));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("- If you shoot yourself with the bullet in the chamber, or run out of Chances. You lose!");
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label4).set_Location(new Point(31, 119));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(654, 23));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("- You lose chances by Shooting the opponent and missing. You only have 2 chances");
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label5).set_Location(new Point(31, 154));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(734, 23));
		((Control)Label5).set_TabIndex(4);
		Label5.set_Text("- You play as the character on the left named Joker. Your enemy on the right is Mysterion");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Comic Sans MS", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label6).set_Location(new Point(13, 220));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(162, 38));
		((Control)Label6).set_TabIndex(5);
		Label6.set_Text("MultiPlayer");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Transparent);
		((Control)Label7).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label7).set_Location(new Point(31, 258));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(685, 23));
		((Control)Label7).set_TabIndex(6);
		Label7.set_Text("- The objective of the game is to shoot your opponent with the bullet in the chamber");
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.Transparent);
		((Control)Label8).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label8).set_Location(new Point(31, 292));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(696, 23));
		((Control)Label8).set_TabIndex(7);
		Label8.set_Text("- If you shoot your opponent and miss, you lose your chance at shooting until they miss");
		((ButtonBase)btnBack).set_BackColor(Color.Orange);
		((Control)btnBack).set_Location(new Point(35, 367));
		((Control)btnBack).set_Name("btnBack");
		((Control)btnBack).set_Size(new Size(202, 54));
		((Control)btnBack).set_TabIndex(8);
		((ButtonBase)btnBack).set_Text("Back");
		((ButtonBase)btnBack).set_UseVisualStyleBackColor(false);
		Label9.set_AutoSize(true);
		((Control)Label9).set_BackColor(Color.Transparent);
		((Control)Label9).set_Font(new Font("Comic Sans MS", 11f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label9).set_Location(new Point(31, 188));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(735, 21));
		((Control)Label9).set_TabIndex(9);
		Label9.set_Text("- Shoot Joker when you think the guns chamber is empty, shoot Mysterion if you think otherwise");
		Label10.set_AutoSize(true);
		((Control)Label10).set_BackColor(Color.Transparent);
		((Control)Label10).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Label10).set_Location(new Point(31, 324));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(595, 23));
		((Control)Label10).set_TabIndex(10);
		Label10.set_Text("- Player One is the Joker on the left, Player 2 is the player on the right");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(787, 453));
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)btnBack);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("InformationForm");
		((Form)this).set_Text("InformationForm");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnBack_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
