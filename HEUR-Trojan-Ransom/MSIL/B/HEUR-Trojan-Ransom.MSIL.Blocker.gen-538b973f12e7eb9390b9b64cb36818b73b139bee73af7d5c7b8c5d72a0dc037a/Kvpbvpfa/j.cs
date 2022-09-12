using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Kvpbvpfa;

public sealed class j : Form
{
	private IContainer m_a;

	private MaskedTextBox b;

	private MaskedTextBox c;

	private MaskedTextBox d;

	private ListView e;

	private ListView f;

	public j()
	{
		a();
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		b = new MaskedTextBox();
		c = new MaskedTextBox();
		d = new MaskedTextBox();
		e = new ListView();
		f = new ListView();
		((Control)this).SuspendLayout();
		((Control)b).set_Location(new Point(0, 0));
		((Control)b).set_Name("maskedTextBox1");
		((Control)b).set_Size(new Size(100, 20));
		((Control)b).set_TabIndex(0);
		((Control)c).set_Location(new Point(8, 8));
		((Control)c).set_Name("maskedTextBox2");
		((Control)c).set_Size(new Size(100, 20));
		((Control)c).set_TabIndex(1);
		((Control)d).set_Location(new Point(16, 16));
		((Control)d).set_Name("maskedTextBox3");
		((Control)d).set_Size(new Size(100, 20));
		((Control)d).set_TabIndex(2);
		e.set_HideSelection(false);
		((Control)e).set_Location(new Point(24, 24));
		((Control)e).set_Name("listView1");
		((Control)e).set_Size(new Size(121, 97));
		((Control)e).set_TabIndex(3);
		e.set_UseCompatibleStateImageBehavior(false);
		f.set_HideSelection(false);
		((Control)f).set_Location(new Point(32, 32));
		((Control)f).set_Name("listView2");
		((Control)f).set_Size(new Size(121, 97));
		((Control)f).set_TabIndex(4);
		f.set_UseCompatibleStateImageBehavior(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(303, 256));
		((Control)this).get_Controls().Add((Control)(object)f);
		((Control)this).get_Controls().Add((Control)(object)e);
		((Control)this).get_Controls().Add((Control)(object)d);
		((Control)this).get_Controls().Add((Control)(object)c);
		((Control)this).get_Controls().Add((Control)(object)b);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
