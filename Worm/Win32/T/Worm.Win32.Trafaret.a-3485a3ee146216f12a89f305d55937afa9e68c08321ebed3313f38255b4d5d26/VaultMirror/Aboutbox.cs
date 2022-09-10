using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace VaultMirror;

public class Aboutbox : Form
{
	private Label m_label;

	private Button button1;

	private Container components;

	public Aboutbox()
	{
		InitializeComponent();
		AssemblyName name = Assembly.GetExecutingAssembly().GetName();
		((Control)m_label).set_Text("Vault Mirror " + name.Version!.Major + "." + name.Version!.Minor + "." + name.Version!.Build + "\nFor use with ADMS 2008\nAuthor: Doug Redmond");
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
		m_label = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)m_label).set_Location(new Point(8, 8));
		((Control)m_label).set_Name("m_label");
		((Control)m_label).set_Size(new Size(240, 80));
		((Control)m_label).set_TabIndex(0);
		((Control)button1).set_Location(new Point(168, 88));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(80, 24));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("OK");
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(258, 118));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)m_label);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Aboutbox");
		((Control)this).set_Text("About Vault Mirror");
		((Control)this).ResumeLayout(false);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)1);
	}
}
