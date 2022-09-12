using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RDP_CONNECT_V1._0;

public class Form3 : Form
{
	private IContainer components;

	private ComboBox comboBox1;

	private Button button1;

	public Form3()
	{
		InitializeComponent();
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Control)new Form4()).Show();
		((Control)this).Hide();
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
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		comboBox1 = new ComboBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[11]
		{
			"American Samoa", "Armenia", "Belarus", "Brazil", "China ", "France\"", "Germany", "India", "Korea", "Kyrgyzstan",
			"Yemen"
		});
		((Control)comboBox1).set_Location(new Point(12, 12));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(114, 21));
		((Control)comboBox1).set_TabIndex(1);
		comboBox1.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
		((Control)button1).set_Location(new Point(132, 12));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Next");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(40, 42, 54));
		((Form)this).set_ClientSize(new Size(213, 38));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form3");
		((Control)this).set_Text("Free RDP v0.1 | Laut Cat");
		((Control)this).ResumeLayout(false);
	}
}
