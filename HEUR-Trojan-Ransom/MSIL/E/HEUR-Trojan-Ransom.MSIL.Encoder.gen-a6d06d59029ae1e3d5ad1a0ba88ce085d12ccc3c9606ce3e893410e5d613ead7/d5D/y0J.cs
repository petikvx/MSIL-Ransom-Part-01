using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cc92;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nr9s;
using s8Z;
using t1G;

namespace d5D;

[DesignerGenerated]
public class y0J : Form
{
	private MonthCalendar _MonthCalendar1;

	private PictureBox _PictureBox2;

	private Button _cmdSave;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox4;

	private string t;

	internal IContainer D;

	internal Button R;

	internal Button I;

	internal TextBox V;

	internal PictureBox l;

	internal Label a;

	internal MsgBoxResult T;

	public y0J()
	{
		((Form)this).add_Load((EventHandler)Qb7s);
		r9S();
	}

	protected override void g1L(bool s3C)
	{
		try
		{
			if (s3C && D != null)
			{
				D.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s3C);
		}
	}

	private void r9S()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected O, but got Unknown
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(y0J));
		Jt2(new Button());
		m8F(new PictureBox());
		Lk7(new MonthCalendar());
		Yo3(new Button());
		Qc1(new Button());
		Nd8(new TextBox());
		Xk0(new PictureBox());
		Bt8(new PictureBox());
		Zd2(new PictureBox());
		g6Q(new Label());
		((ISupportInitialize)x1N()).BeginInit();
		((ISupportInitialize)j5M()).BeginInit();
		((ISupportInitialize)k8F()).BeginInit();
		((ISupportInitialize)x0B()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Ak7()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Ak7()).set_BackColor(Color.Azure);
		((Control)Ak7()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Ak7()).set_FlatStyle((FlatStyle)0);
		((Control)Ak7()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ak7()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Ak7()).set_Location(new Point(24, 338));
		((Control)Ak7()).set_Name("Button1");
		((Control)Ak7()).set_Size(new Size(99, 26));
		((Control)Ak7()).set_TabIndex(3);
		((ButtonBase)Ak7()).set_Text("&Exit");
		((ButtonBase)Ak7()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)Ak7()).set_UseVisualStyleBackColor(false);
		((Control)x1N()).set_Anchor((AnchorStyles)15);
		((Control)x1N()).set_BackColor(Color.Transparent);
		((Control)x1N()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)x1N()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)x1N()).set_Location(new Point(2, 324));
		((Control)x1N()).set_Name("PictureBox2");
		((Control)x1N()).set_Size(new Size(43, 40));
		x1N().set_TabIndex(8);
		x1N().set_TabStop(false);
		((Control)w2X()).set_Anchor((AnchorStyles)15);
		((Control)w2X()).set_Location(new Point(140, 97));
		((Control)w2X()).set_Name("MonthCalendar1");
		((Control)w2X()).set_TabIndex(9);
		((Control)Lg2()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Lg2()).set_BackColor(Color.Azure);
		((ButtonBase)Lg2()).set_FlatStyle((FlatStyle)1);
		((Control)Lg2()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Lg2()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)Lg2()).set_Location(new Point(107, 271));
		((Control)Lg2()).set_Name("cmdSave");
		((Control)Lg2()).set_Size(new Size(92, 29));
		((Control)Lg2()).set_TabIndex(1);
		((ButtonBase)Lg2()).set_Text("&Save");
		((ButtonBase)Lg2()).set_UseVisualStyleBackColor(false);
		((Control)Lg2()).set_Visible(false);
		((Control)Yg6()).set_Anchor((AnchorStyles)15);
		((ButtonBase)Yg6()).set_BackColor(Color.Azure);
		((ButtonBase)Yg6()).set_FlatStyle((FlatStyle)1);
		((Control)Yg6()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Yg6()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)Yg6()).set_Location(new Point(293, 271));
		((Control)Yg6()).set_Name("cmdBack");
		((Control)Yg6()).set_Size(new Size(92, 29));
		((Control)Yg6()).set_TabIndex(2);
		((ButtonBase)Yg6()).set_Text("&Back");
		((ButtonBase)Yg6()).set_UseVisualStyleBackColor(false);
		((Control)Yg6()).set_Visible(false);
		((Control)Ks7()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Ks7()).set_BackColor(Color.Gainsboro);
		((Control)Ks7()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Ks7()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Ks7()).set_Location(new Point(140, 72));
		Ks7().set_Multiline(true);
		((Control)Ks7()).set_Name("TxtNote");
		Ks7().set_ScrollBars((ScrollBars)2);
		((Control)Ks7()).set_Size(new Size(227, 187));
		((Control)Ks7()).set_TabIndex(0);
		((Control)Ks7()).set_Visible(false);
		((Control)j5M()).set_Anchor((AnchorStyles)15);
		((Control)j5M()).set_BackColor(Color.Transparent);
		((Control)j5M()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)j5M()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)j5M()).set_Location(new Point(2, 4));
		((Control)j5M()).set_Name("PictureBox3");
		((Control)j5M()).set_Size(new Size(89, 85));
		j5M().set_TabIndex(14);
		j5M().set_TabStop(false);
		((Control)k8F()).set_Anchor((AnchorStyles)15);
		((Control)k8F()).set_BackColor(Color.Transparent);
		((Control)k8F()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)k8F()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)k8F()).set_Location(new Point(150, 4));
		((Control)k8F()).set_Name("PictureBox1");
		((Control)k8F()).set_Size(new Size(208, 37));
		k8F().set_TabIndex(15);
		k8F().set_TabStop(false);
		((Control)x0B()).set_Anchor((AnchorStyles)15);
		((Control)x0B()).set_BackColor(Color.Transparent);
		((Control)x0B()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)x0B()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)x0B()).set_Location(new Point(430, 279));
		((Control)x0B()).set_Name("PictureBox4");
		((Control)x0B()).set_Size(new Size(89, 85));
		x0B().set_TabIndex(16);
		x0B().set_TabStop(false);
		((Control)Eg5()).set_Anchor((AnchorStyles)15);
		((Control)Eg5()).set_BackColor(Color.Transparent);
		((Control)Eg5()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Eg5()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)Eg5()).set_Location(new Point(136, 63));
		((Control)Eg5()).set_Name("LblHeading");
		((Control)Eg5()).set_Size(new Size(244, 25));
		((Control)Eg5()).set_TabIndex(17);
		Eg5().set_Text("Select the date to add an Event");
		Eg5().set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveBorder);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(520, 370));
		((Control)this).get_Controls().Add((Control)(object)Eg5());
		((Control)this).get_Controls().Add((Control)(object)x0B());
		((Control)this).get_Controls().Add((Control)(object)k8F());
		((Control)this).get_Controls().Add((Control)(object)j5M());
		((Control)this).get_Controls().Add((Control)(object)Ks7());
		((Control)this).get_Controls().Add((Control)(object)Yg6());
		((Control)this).get_Controls().Add((Control)(object)Lg2());
		((Control)this).get_Controls().Add((Control)(object)w2X());
		((Control)this).get_Controls().Add((Control)(object)x1N());
		((Control)this).get_Controls().Add((Control)(object)Ak7());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form3");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Calender Events");
		((ISupportInitialize)x1N()).EndInit();
		((ISupportInitialize)j5M()).EndInit();
		((ISupportInitialize)k8F()).EndInit();
		((ISupportInitialize)x0B()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Ak7()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jt2(Button n2K)
	{
		EventHandler eventHandler = My51;
		Button r = R;
		if (r != null)
		{
			((Control)r).remove_Click(eventHandler);
		}
		Button val = (R = n2K);
		r = R;
		if (r != null)
		{
			((Control)r).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual MonthCalendar w2X()
	{
		return _MonthCalendar1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lk7(MonthCalendar f3L)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		DateRangeEventHandler val = new DateRangeEventHandler(Za8t);
		MonthCalendar monthCalendar = _MonthCalendar1;
		if (monthCalendar != null)
		{
			monthCalendar.remove_DateSelected(val);
		}
		_MonthCalendar1 = f3L;
		monthCalendar = _MonthCalendar1;
		if (monthCalendar != null)
		{
			monthCalendar.add_DateSelected(val);
		}
	}

	[SpecialName]
	internal virtual PictureBox x1N()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8F(PictureBox c1L)
	{
		_PictureBox2 = c1L;
	}

	[SpecialName]
	internal virtual Button Lg2()
	{
		return _cmdSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yo3(Button Jy7)
	{
		EventHandler eventHandler = q8DF;
		Button cmdSave = _cmdSave;
		if (cmdSave != null)
		{
			((Control)cmdSave).remove_Click(eventHandler);
		}
		_cmdSave = Jy7;
		cmdSave = _cmdSave;
		if (cmdSave != null)
		{
			((Control)cmdSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Yg6()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qc1(Button t5W)
	{
		EventHandler eventHandler = y5X6;
		Button i = I;
		if (i != null)
		{
			((Control)i).remove_Click(eventHandler);
		}
		Button val = (I = t5W);
		i = I;
		if (i != null)
		{
			((Control)i).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Ks7()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nd8(TextBox Jx3)
	{
		TextBox val = (V = Jx3);
	}

	[SpecialName]
	internal virtual PictureBox j5M()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xk0(PictureBox d8Q)
	{
		_PictureBox3 = d8Q;
	}

	[SpecialName]
	internal virtual PictureBox x0B()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zd2(PictureBox c9T)
	{
		_PictureBox4 = c9T;
	}

	[SpecialName]
	internal virtual PictureBox k8F()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bt8(PictureBox d3K)
	{
		PictureBox val = (l = d3K);
	}

	[SpecialName]
	internal virtual Label Eg5()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6Q(Label f3R)
	{
		Label val = (a = f3R);
	}

	private void Za8t(object sender, DateRangeEventArgs e)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Invalid comparison between Unknown and I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		t = w2X().get_SelectionRange().get_Start().Month.ToString() + w2X().get_SelectionRange().get_Start().Day;
		try
		{
			if (File.Exists(t + ".txt"))
			{
				((Control)w2X()).set_Enabled(false);
				((Control)w2X()).Hide();
				((Control)Eg5()).set_Enabled(false);
				((Control)Eg5()).Hide();
				((Control)Ks7()).set_Enabled(true);
				((Control)Ks7()).Show();
				((Control)Lg2()).set_Enabled(true);
				((Control)Lg2()).Show();
				((Control)Yg6()).set_Enabled(true);
				((Control)Yg6()).Show();
				Ks7().set_Text(File.ReadAllText(t + ".txt"));
				return;
			}
			MsgBoxResult val = (T = Interaction.MsgBox((object)"Would you like to add Notes for this Date ?", (MsgBoxStyle)4, (object)null));
			if ((int)T == 6)
			{
				((Control)w2X()).set_Enabled(false);
				((Control)w2X()).Hide();
				((Control)Eg5()).set_Enabled(false);
				((Control)Eg5()).Hide();
				((Control)Ks7()).set_Enabled(true);
				((Control)Ks7()).Show();
				((Control)Lg2()).set_Enabled(true);
				((Control)Lg2()).Show();
				((Control)Yg6()).set_Enabled(true);
				((Control)Yg6()).Show();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void y5X6(object sender, EventArgs e)
	{
		((Control)Ks7()).set_Enabled(false);
		((Control)Ks7()).Hide();
		((Control)Lg2()).set_Enabled(false);
		((Control)Lg2()).Hide();
		((Control)Yg6()).set_Enabled(false);
		((Control)Yg6()).Hide();
		((Control)w2X()).set_Enabled(true);
		((Control)w2X()).Show();
		((Control)Eg5()).set_Enabled(true);
		((Control)Eg5()).Show();
	}

	private void q8DF(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(Ks7().get_Text(), "", false) == 0 && File.Exists(t + ".txt"))
			{
				File.Delete(t + ".txt");
				Interaction.MsgBox((object)"Note was deleted Successfully. Press Back to Continue", (MsgBoxStyle)0, (object)null);
			}
			if (Ks7().get_Text().Length > 0)
			{
				File.WriteAllText(t + ".txt", Ks7().get_Text());
				Interaction.MsgBox((object)"Note was added Successfully. Press Back to Continue", (MsgBoxStyle)0, (object)null);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static void i4N2()
	{
		byte[] array = a6N5.i3P8(133632);
		checked
		{
			int xe = Conversions.ToInteger(Mc4.mDic[Mc4.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = a6N5.b5Q4(array[i], (byte[])Mc4.mDic[Mc4.sArray], xe, i);
			}
			Mc4.mDic.Add(Mc4.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			n1R9.q7Q0();
		}
	}

	private void My51(object sender, EventArgs e)
	{
		((Control)i1B.Forms.i5C()).Show();
		((Form)this).Close();
	}

	private void Qb7s(object sender, EventArgs e)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		t = w2X().get_SelectionRange().get_Start().Month.ToString() + w2X().get_SelectionRange().get_Start().Day;
		if ((DateTime.Compare(DateTime.Today, w2X().get_TodayDate()) == 0) & File.Exists(t + ".txt"))
		{
			MsgBoxResult val = Interaction.MsgBox((object)"View Today's Events ?", (MsgBoxStyle)4, (object)null);
			if ((int)val == 6)
			{
				((Control)w2X()).set_Enabled(false);
				((Control)w2X()).Hide();
				((Control)Eg5()).set_Enabled(false);
				((Control)Eg5()).Hide();
				((Control)Ks7()).set_Enabled(true);
				((Control)Ks7()).Show();
				((Control)Lg2()).set_Enabled(true);
				((Control)Lg2()).Show();
				((Control)Yg6()).set_Enabled(true);
				((Control)Yg6()).Show();
				Ks7().set_Text(File.ReadAllText(t + ".txt"));
			}
		}
	}
}
