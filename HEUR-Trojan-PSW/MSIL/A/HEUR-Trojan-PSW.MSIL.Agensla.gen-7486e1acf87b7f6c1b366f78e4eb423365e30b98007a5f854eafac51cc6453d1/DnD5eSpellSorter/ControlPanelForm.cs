using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DnD5eSpellSorter;

public class ControlPanelForm : Form
{
	private IContainer components = null;

	private Button buttonExit;

	private Button buttonPlay;

	private Button buttonDesign;

	public ControlPanelForm()
	{
		InitializeComponent();
	}

	private void buttonDesign_Click(object sender, EventArgs e)
	{
		Form val = (Form)(object)new MazeDesignerForm();
		((Control)val).Show();
		((Control)this).Hide();
	}

	private void buttonPlay_Click(object sender, EventArgs e)
	{
		Form val = (Form)(object)new PlayForm();
		((Control)val).Show();
		((Control)this).Hide();
	}

	private void buttonExit_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		buttonExit = new Button();
		buttonPlay = new Button();
		buttonDesign = new Button();
		((Control)this).SuspendLayout();
		((Control)buttonExit).set_BackColor(Color.MidnightBlue);
		((Control)buttonExit).set_Font(new Font("Ravie", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)buttonExit).set_ForeColor(SystemColors.Control);
		((Control)buttonExit).set_Location(new Point(333, 261));
		((Control)buttonExit).set_Name("buttonExit");
		((Control)buttonExit).set_Size(new Size(140, 75));
		((Control)buttonExit).set_TabIndex(14);
		((Control)buttonExit).set_Text("Exit");
		((ButtonBase)buttonExit).set_UseVisualStyleBackColor(false);
		((Control)buttonExit).add_Click((EventHandler)buttonExit_Click);
		((Control)buttonPlay).set_BackColor(Color.Blue);
		((Control)buttonPlay).set_Font(new Font("Ravie", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)buttonPlay).set_ForeColor(SystemColors.Control);
		((Control)buttonPlay).set_Location(new Point(473, 115));
		((Control)buttonPlay).set_Name("buttonPlay");
		((Control)buttonPlay).set_Size(new Size(140, 75));
		((Control)buttonPlay).set_TabIndex(13);
		((Control)buttonPlay).set_Text("Play");
		((ButtonBase)buttonPlay).set_UseVisualStyleBackColor(false);
		((Control)buttonPlay).add_Click((EventHandler)buttonPlay_Click);
		((Control)buttonDesign).set_BackColor(Color.BlueViolet);
		((Control)buttonDesign).set_Font(new Font("Ravie", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)buttonDesign).set_ForeColor(SystemColors.Control);
		((Control)buttonDesign).set_Location(new Point(188, 115));
		((Control)buttonDesign).set_Name("buttonDesign");
		((Control)buttonDesign).set_Size(new Size(140, 75));
		((Control)buttonDesign).set_TabIndex(12);
		((Control)buttonDesign).set_Text("Design");
		((ButtonBase)buttonDesign).set_UseVisualStyleBackColor(false);
		((Control)buttonDesign).add_Click((EventHandler)buttonDesign_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gainsboro);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)buttonExit);
		((Control)this).get_Controls().Add((Control)(object)buttonPlay);
		((Control)this).get_Controls().Add((Control)(object)buttonDesign);
		((Control)this).set_Name("ControlPanelForm");
		((Control)this).set_Text("QGameControlPanel");
		((Control)this).ResumeLayout(false);
	}
}
