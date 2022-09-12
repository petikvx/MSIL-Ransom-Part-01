using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns18;

[DesignerGenerated]
public class SomeoneWon : Form
{
	private IContainer icontainer_0;

	[field: AccessedThroughProperty("lblCongratz")]
	internal virtual Label lblCongratz
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnMenu
	{
		[CompilerGenerated]
		get
		{
			return _btnMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnMenu_Click;
			Button val = _btnMenu;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnMenu = value;
			val = _btnMenu;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblWinner")]
	internal virtual Label lblWinner
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SomeoneWon()
	{
		((Form)this).add_Load((EventHandler)SomeoneWon_Load);
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
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		lblCongratz = new Label();
		btnMenu = new Button();
		lblWinner = new Label();
		((Control)this).SuspendLayout();
		lblCongratz.set_AutoSize(true);
		((Control)lblCongratz).set_BackColor(Color.Transparent);
		((Control)lblCongratz).set_Font(new Font("Microsoft Sans Serif", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblCongratz).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblCongratz).set_Location(new Point(51, 30));
		((Control)lblCongratz).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblCongratz).set_Name("lblCongratz");
		((Control)lblCongratz).set_Size(new Size(205, 31));
		((Control)lblCongratz).set_TabIndex(0);
		lblCongratz.set_Text("Congratulations");
		((ButtonBase)btnMenu).set_BackColor(SystemColors.ButtonHighlight);
		((Control)btnMenu).set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnMenu).set_Location(new Point(87, 169));
		((Control)btnMenu).set_Margin(new Padding(4, 4, 4, 4));
		((Control)btnMenu).set_Name("btnMenu");
		((Control)btnMenu).set_Size(new Size(169, 52));
		((Control)btnMenu).set_TabIndex(1);
		((ButtonBase)btnMenu).set_Text("Return to Menu");
		((ButtonBase)btnMenu).set_UseVisualStyleBackColor(false);
		lblWinner.set_AutoSize(true);
		((Control)lblWinner).set_BackColor(Color.Transparent);
		((Control)lblWinner).set_Font(new Font("Microsoft Sans Serif", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblWinner).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblWinner).set_Location(new Point(100, 79));
		((Control)lblWinner).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblWinner).set_Name("lblWinner");
		((Control)lblWinner).set_Size(new Size(99, 31));
		((Control)lblWinner).set_TabIndex(3);
		lblWinner.set_Text("Winner");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(616, 298));
		((Control)this).get_Controls().Add((Control)(object)lblWinner);
		((Control)this).get_Controls().Add((Control)(object)btnMenu);
		((Control)this).get_Controls().Add((Control)(object)lblCongratz);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("SomeoneWon");
		((Form)this).set_Text("SomeoneWon");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btnMenu_Click(object sender, EventArgs e)
	{
		((Form)Class2.Forms.MultiPlayer).Close();
		((Control)Class2.Forms.MainMenu).Show();
		((Form)this).Close();
	}

	private void SomeoneWon_Load(object sender, EventArgs e)
	{
	}
}
