using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Yn32;
using q4F8;

namespace q2AL;

[DesignerGenerated]
public class Fe1r : Form
{
	internal IContainer y;

	internal Button m;

	internal NotifyIcon D;

	public Fe1r()
	{
		t4GY();
	}

	protected override void Lw98(bool q1TK)
	{
		try
		{
			if (q1TK && y != null)
			{
				y.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q1TK);
		}
	}

	private void t4GY()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		IContainer container = (y = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Fe1r));
		Wn30(new Button());
		Gy9n(new NotifyIcon(y));
		((Control)this).SuspendLayout();
		((Control)f2AX()).set_Location(new Point(0, 2));
		((Control)f2AX()).set_Name("Button1");
		((Control)f2AX()).set_Size(new Size(212, 72));
		((Control)f2AX()).set_TabIndex(0);
		((ButtonBase)f2AX()).set_Text("Button1");
		((ButtonBase)f2AX()).set_UseVisualStyleBackColor(true);
		t3AG().set_BalloonTipTitle("Click Me!");
		t3AG().set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		t3AG().set_Text("NotifyIcon1");
		t3AG().set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(214, 76));
		((Control)this).get_Controls().Add((Control)(object)f2AX());
		((Control)this).set_Name("notify");
		((Form)this).set_Text("notify");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Button f2AX()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wn30(Button n8S1)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		EventHandler eventHandler = c0W6;
		MouseEventHandler val = new MouseEventHandler(Ja52);
		Button val2 = m;
		if (val2 != null)
		{
			((Control)val2).remove_Click(eventHandler);
			((Control)val2).remove_MouseClick(val);
		}
		Button val3 = (m = n8S1);
		val2 = m;
		if (val2 != null)
		{
			((Control)val2).add_Click(eventHandler);
			((Control)val2).add_MouseClick(val);
		}
	}

	[SpecialName]
	internal virtual NotifyIcon t3AG()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gy9n(NotifyIcon Rk1t)
	{
		NotifyIcon val = (D = Rk1t);
	}

	private void c0W6(object sender, EventArgs e)
	{
		((Control)this).Hide();
		d7H8.Forms.Gt79().Do4().ShowBalloonTip(500, "Click Me!", "You have an appointment request from" + d7H8.Forms.Lp3k().s9GB().get_Text(), (ToolTipIcon)1);
	}

	private void Ja52(object sender, MouseEventArgs e)
	{
	}

	internal static byte[] b5KX(int a7L4)
	{
		return d1D9.b2E3(a7L4, checked(a7L4 + 1 - 37));
	}
}
