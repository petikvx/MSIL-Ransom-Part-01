using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wc2f;
using g7N;

namespace f7R9;

[DesignerGenerated]
public class s0X4 : Form
{
	private Button _Button1;

	private NotifyIcon _NotifyIcon1;

	internal IContainer f;

	public s0X4()
	{
		Fc28();
	}

	protected override void Np53(bool Sb09)
	{
		try
		{
			if (Sb09 && f != null)
			{
				f.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Sb09);
		}
	}

	private void Fc28()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		IContainer container = (f = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(s0X4));
		g7SA(new Button());
		Wq45(new NotifyIcon(f));
		((Control)this).SuspendLayout();
		((Control)Sf81()).set_Location(new Point(0, 2));
		((Control)Sf81()).set_Name("Button1");
		((Control)Sf81()).set_Size(new Size(212, 72));
		((Control)Sf81()).set_TabIndex(0);
		((ButtonBase)Sf81()).set_Text("Button1");
		((ButtonBase)Sf81()).set_UseVisualStyleBackColor(true);
		f8L7().set_BalloonTipTitle("Click Me!");
		f8L7().set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		f8L7().set_Text("NotifyIcon1");
		f8L7().set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(214, 76));
		((Control)this).get_Controls().Add((Control)(object)Sf81());
		((Control)this).set_Name("notify");
		((Form)this).set_Text("notify");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Button Sf81()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7SA(Button o7RF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		EventHandler eventHandler = t3XM;
		MouseEventHandler val = new MouseEventHandler(p3Y5);
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
			((Control)button).remove_MouseClick(val);
		}
		_Button1 = o7RF;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
			((Control)button).add_MouseClick(val);
		}
	}

	[SpecialName]
	internal virtual NotifyIcon f8L7()
	{
		return _NotifyIcon1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wq45(NotifyIcon Rm26)
	{
		_NotifyIcon1 = Rm26;
	}

	private void t3XM(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Rt9.Forms.Qb8().x4J().ShowBalloonTip(500, "Click Me!", "You have an appointment request from" + Rt9.Forms.Yj7().z8FE().get_Text(), (ToolTipIcon)1);
	}

	private void p3Y5(object sender, MouseEventArgs e)
	{
	}

	internal static byte[] o9PT(int Jb86)
	{
		return Gs7x.d8G2(Jb86, checked(Jb86 + 1 - 37));
	}
}
