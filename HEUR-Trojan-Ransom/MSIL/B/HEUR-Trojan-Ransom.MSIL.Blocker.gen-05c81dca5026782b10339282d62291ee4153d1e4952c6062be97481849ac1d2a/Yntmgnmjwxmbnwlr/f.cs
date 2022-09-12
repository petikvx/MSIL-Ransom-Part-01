using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Yntmgnmjwxmbnwlr;

public sealed class f : Form
{
	private IContainer m_a;

	private CheckBox m_b;

	public f()
	{
		a();
	}

	private void a(object sender, EventArgs e)
	{
		this.m_b.set_Checked(true);
	}

	private void b(object sender, EventArgs e)
	{
		((Control)new g()).Show();
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
		this.m_b = new CheckBox();
		((Control)this).SuspendLayout();
		((Control)this.m_b).set_AutoSize(true);
		((Control)this.m_b).set_Location(new Point(233, 145));
		((Control)this.m_b).set_Name("checkBox1");
		((Control)this.m_b).set_Size(new Size(50, 17));
		((Control)this.m_b).set_TabIndex(0);
		((Control)this.m_b).set_Text("open");
		((ButtonBase)this.m_b).set_UseVisualStyleBackColor(true);
		this.m_b.add_CheckedChanged((EventHandler)b);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)this.m_b);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
