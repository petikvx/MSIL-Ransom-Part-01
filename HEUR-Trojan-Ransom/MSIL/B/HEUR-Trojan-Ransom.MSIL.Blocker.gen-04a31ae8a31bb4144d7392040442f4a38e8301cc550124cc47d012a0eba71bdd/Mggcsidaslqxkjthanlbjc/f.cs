using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Mggcsidaslqxkjthanlbjc;

public sealed class f : Form
{
	private IContainer m_a;

	private Label m_b;

	private TextBox m_c;

	public f()
	{
		a();
	}

	private void a(object sender, EventArgs e)
	{
	}

	private void b(object sender, EventArgs e)
	{
	}

	private void c(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool a)
	{
		if (a && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		((Form)this).Dispose(a);
	}

	private void a()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		this.m_b = new Label();
		this.m_c = new TextBox();
		((Control)this).SuspendLayout();
		((Control)this.m_b).set_AutoSize(true);
		((Control)this.m_b).set_Location(new Point(0, 0));
		((Control)this.m_b).set_Name("label1");
		((Control)this.m_b).set_Size(new Size(35, 13));
		((Control)this.m_b).set_TabIndex(0);
		((Control)this.m_b).set_Text("label1");
		((Control)this.m_b).add_Click((EventHandler)b);
		((Control)this.m_c).set_Location(new Point(167, 139));
		((Control)this.m_c).set_Name("textBox1");
		((Control)this.m_c).set_Size(new Size(100, 20));
		((Control)this.m_c).set_TabIndex(1);
		((Control)this.m_c).add_TextChanged((EventHandler)c);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(578, 297));
		((Control)this).get_Controls().Add((Control)(object)this.m_c);
		((Control)this).get_Controls().Add((Control)(object)this.m_b);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
