using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Yt3k;
using s7YR;

namespace Lq12;

[DesignerGenerated]
public class f1PK : Form
{
	private NotifyIcon _NotifyIcon1;

	internal IContainer t;

	internal Button u;

	public f1PK()
	{
		z1J5();
	}

	protected override void Pe8w(bool f2LR)
	{
		try
		{
			if (f2LR && t != null)
			{
				t.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f2LR);
		}
	}

	private void z1J5()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		IContainer container = (t = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(f1PK));
		p9RM(new Button());
		y0XW(new NotifyIcon(t));
		((Control)this).SuspendLayout();
		((Control)i0KH()).set_Location(new Point(0, 2));
		((Control)i0KH()).set_Name("Button1");
		((Control)i0KH()).set_Size(new Size(212, 72));
		((Control)i0KH()).set_TabIndex(0);
		((ButtonBase)i0KH()).set_Text("Button1");
		((ButtonBase)i0KH()).set_UseVisualStyleBackColor(true);
		r6X0().set_BalloonTipTitle("Click Me!");
		r6X0().set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		r6X0().set_Text("NotifyIcon1");
		r6X0().set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(214, 76));
		((Control)this).get_Controls().Add((Control)(object)i0KH());
		((Control)this).set_Name("notify");
		((Form)this).set_Text("notify");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Button i0KH()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9RM(Button a4DB)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		EventHandler eventHandler = Wj01;
		MouseEventHandler val = new MouseEventHandler(e2YT);
		Button val2 = u;
		if (val2 != null)
		{
			((Control)val2).remove_Click(eventHandler);
			((Control)val2).remove_MouseClick(val);
		}
		Button val3 = (u = a4DB);
		val2 = u;
		if (val2 != null)
		{
			((Control)val2).add_Click(eventHandler);
			((Control)val2).add_MouseClick(val);
		}
	}

	[SpecialName]
	internal virtual NotifyIcon r6X0()
	{
		return _NotifyIcon1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0XW(NotifyIcon Wp6w)
	{
		_NotifyIcon1 = Wp6w;
	}

	private void Wj01(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Eo05.Forms.Rb03().Rp8().ShowBalloonTip(500, "Click Me!", "You have an appointment request from" + Eo05.Forms.Tk5w().t4E6().get_Text(), (ToolTipIcon)1);
	}

	private void e2YT(object sender, MouseEventArgs e)
	{
	}

	internal static byte[] z8BY(int Nc2z)
	{
		return Mf15.Xi26(Nc2z, checked(Nc2z + 1 - 37));
	}
}
