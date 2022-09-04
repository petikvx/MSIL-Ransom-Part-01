using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Handyware;

public class Form_MessageBox : Form
{
	private IContainer components = null;

	private Button button_ok;

	private Label label_text;

	public Form_MessageBox(string title, string text)
	{
		InitializeComponent();
		((Control)this).set_Text(title);
		((Control)label_text).set_Text(text);
	}

	private void button_ok_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_MessageBox));
		button_ok = new Button();
		label_text = new Label();
		((Control)this).SuspendLayout();
		((Control)button_ok).set_Anchor((AnchorStyles)14);
		((Control)button_ok).set_Location(new Point(12, 40));
		((Control)button_ok).set_Name("button_ok");
		((Control)button_ok).set_Size(new Size(119, 23));
		((Control)button_ok).set_TabIndex(0);
		((Control)button_ok).set_Text("OK");
		((ButtonBase)button_ok).set_UseVisualStyleBackColor(true);
		((Control)button_ok).add_Click((EventHandler)button_ok_Click);
		((Control)label_text).set_AutoSize(true);
		((Control)label_text).set_Location(new Point(12, 9));
		((Control)label_text).set_Name("label_text");
		((Control)label_text).set_Size(new Size(35, 13));
		((Control)label_text).set_TabIndex(1);
		((Control)label_text).set_Text("label1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Form)this).set_ClientSize(new Size(143, 75));
		((Control)this).get_Controls().Add((Control)(object)label_text);
		((Control)this).get_Controls().Add((Control)(object)button_ok);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form_MessageBox");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form_MessageBox");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
