using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Orcus;

public class InstallationPromptForm : Form
{
	private IContainer components;

	private Button button1;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Button button2;

	public InstallationPromptForm()
	{
		InitializeComponent();
	}

	protected override void OnShown(EventArgs e)
	{
		((Form)this).OnShown(e);
		((Control)button2).Focus();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(InstallationPromptForm));
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		button2 = new Button();
		((Control)this).SuspendLayout();
		button1.set_DialogResult((DialogResult)1);
		((Control)button1).set_Location(new Point(16, 164));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(83, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Install");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(41, 128, 185));
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(276, 21));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Would you like to install this software?");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI Semibold", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(13, 50));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(103, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Name: Orcus Client");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI Semibold", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(13, 69));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(156, 13));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Publisher: Orcus Technologies");
		((Control)label4).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(13, 104));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(459, 44));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("Orcus is a Remote Administration Tool for Windows. It allows the administrator to make changes to the system remotely. You should only install this client from sources you trust.");
		button2.set_DialogResult((DialogResult)2);
		((Control)button2).set_Location(new Point(105, 164));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(158, 23));
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("Don't Install");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Form)this).set_AcceptButton((IButtonControl)(object)button2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_CancelButton((IButtonControl)(object)button1);
		((Form)this).set_ClientSize(new Size(484, 199));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("InstallationPromptForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Install Orcus");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
