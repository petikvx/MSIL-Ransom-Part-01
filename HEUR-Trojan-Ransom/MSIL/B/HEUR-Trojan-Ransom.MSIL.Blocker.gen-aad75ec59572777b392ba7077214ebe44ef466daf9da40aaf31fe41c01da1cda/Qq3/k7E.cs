using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ez5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qm3;
using o6D;
using r8C;

namespace Qq3;

[DesignerGenerated]
public class k7E : Form
{
	private IContainer components;

	private Button _Button1;

	private MonthCalendar _MonthCalendar1;

	private Button _cmdBack;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox1;

	private MsgBoxResult m;

	private string t;

	internal PictureBox N;

	internal Button K;

	internal TextBox M;

	internal PictureBox p;

	internal Label b;

	public k7E()
	{
		((Form)this).add_Load((EventHandler)e6P);
		o3B();
	}

	protected override void r8C(bool Ns4)
	{
		try
		{
			if (Ns4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ns4);
		}
	}

	private void o3B()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(k7E));
		a0Q(new Button());
		Yy7(new PictureBox());
		w1P(new MonthCalendar());
		Me6(new Button());
		Ls3(new Button());
		j5A(new TextBox());
		p9T(new PictureBox());
		d9K(new PictureBox());
		St7(new PictureBox());
		y1L(new Label());
		((ISupportInitialize)Dn6()).BeginInit();
		((ISupportInitialize)w1K()).BeginInit();
		((ISupportInitialize)Cz3()).BeginInit();
		((ISupportInitialize)z6R()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)k4E()).set_Anchor((AnchorStyles)15);
		((ButtonBase)k4E()).set_BackColor(Color.Azure);
		((Control)k4E()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)k4E()).set_FlatStyle((FlatStyle)0);
		((Control)k4E()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)k4E()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)k4E()).set_Location(new Point(24, 338));
		((Control)k4E()).set_Name("Button1");
		((Control)k4E()).set_Size(new Size(99, 26));
		((Control)k4E()).set_TabIndex(3);
		((ButtonBase)k4E()).set_Text("&Exit");
		((ButtonBase)k4E()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)k4E()).set_UseVisualStyleBackColor(false);
		((Control)Dn6()).set_Anchor((AnchorStyles)15);
		((Control)Dn6()).set_BackColor(Color.Transparent);
		((Control)Dn6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Dn6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Dn6()).set_Location(new Point(2, 324));
		((Control)Dn6()).set_Name("PictureBox2");
		((Control)Dn6()).set_Size(new Size(43, 40));
		Dn6().set_TabIndex(8);
		Dn6().set_TabStop(false);
		((Control)t5X()).set_Anchor((AnchorStyles)15);
		((Control)t5X()).set_Location(new Point(140, 97));
		((Control)t5X()).set_Name("MonthCalendar1");
		((Control)t5X()).set_TabIndex(9);
		((Control)e6Z()).set_Anchor((AnchorStyles)15);
		((ButtonBase)e6Z()).set_BackColor(Color.Azure);
		((ButtonBase)e6Z()).set_FlatStyle((FlatStyle)1);
		((Control)e6Z()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)e6Z()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)e6Z()).set_Location(new Point(107, 271));
		((Control)e6Z()).set_Name("cmdSave");
		((Control)e6Z()).set_Size(new Size(92, 29));
		((Control)e6Z()).set_TabIndex(1);
		((ButtonBase)e6Z()).set_Text("&Save");
		((ButtonBase)e6Z()).set_UseVisualStyleBackColor(false);
		((Control)e6Z()).set_Visible(false);
		((Control)o6W()).set_Anchor((AnchorStyles)15);
		((ButtonBase)o6W()).set_BackColor(Color.Azure);
		((ButtonBase)o6W()).set_FlatStyle((FlatStyle)1);
		((Control)o6W()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)o6W()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)o6W()).set_Location(new Point(293, 271));
		((Control)o6W()).set_Name("cmdBack");
		((Control)o6W()).set_Size(new Size(92, 29));
		((Control)o6W()).set_TabIndex(2);
		((ButtonBase)o6W()).set_Text("&Back");
		((ButtonBase)o6W()).set_UseVisualStyleBackColor(false);
		((Control)o6W()).set_Visible(false);
		((Control)Ry2()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Ry2()).set_BackColor(Color.Gainsboro);
		((Control)Ry2()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Ry2()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Ry2()).set_Location(new Point(140, 72));
		Ry2().set_Multiline(true);
		((Control)Ry2()).set_Name("TxtNote");
		Ry2().set_ScrollBars((ScrollBars)2);
		((Control)Ry2()).set_Size(new Size(227, 187));
		((Control)Ry2()).set_TabIndex(0);
		((Control)Ry2()).set_Visible(false);
		((Control)w1K()).set_Anchor((AnchorStyles)15);
		((Control)w1K()).set_BackColor(Color.Transparent);
		((Control)w1K()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)w1K()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)w1K()).set_Location(new Point(2, 4));
		((Control)w1K()).set_Name("PictureBox3");
		((Control)w1K()).set_Size(new Size(89, 85));
		w1K().set_TabIndex(14);
		w1K().set_TabStop(false);
		((Control)Cz3()).set_Anchor((AnchorStyles)15);
		((Control)Cz3()).set_BackColor(Color.Transparent);
		((Control)Cz3()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Cz3()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Cz3()).set_Location(new Point(150, 4));
		((Control)Cz3()).set_Name("PictureBox1");
		((Control)Cz3()).set_Size(new Size(208, 37));
		Cz3().set_TabIndex(15);
		Cz3().set_TabStop(false);
		((Control)z6R()).set_Anchor((AnchorStyles)15);
		((Control)z6R()).set_BackColor(Color.Transparent);
		((Control)z6R()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)z6R()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)z6R()).set_Location(new Point(430, 279));
		((Control)z6R()).set_Name("PictureBox4");
		((Control)z6R()).set_Size(new Size(89, 85));
		z6R().set_TabIndex(16);
		z6R().set_TabStop(false);
		((Control)Zs3()).set_Anchor((AnchorStyles)15);
		((Control)Zs3()).set_BackColor(Color.Transparent);
		((Control)Zs3()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Zs3()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)Zs3()).set_Location(new Point(136, 63));
		((Control)Zs3()).set_Name("LblHeading");
		((Control)Zs3()).set_Size(new Size(244, 25));
		((Control)Zs3()).set_TabIndex(17);
		Zs3().set_Text("Select the date to add an Event");
		Zs3().set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveBorder);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(520, 370));
		((Control)this).get_Controls().Add((Control)(object)Zs3());
		((Control)this).get_Controls().Add((Control)(object)z6R());
		((Control)this).get_Controls().Add((Control)(object)Cz3());
		((Control)this).get_Controls().Add((Control)(object)w1K());
		((Control)this).get_Controls().Add((Control)(object)Ry2());
		((Control)this).get_Controls().Add((Control)(object)o6W());
		((Control)this).get_Controls().Add((Control)(object)e6Z());
		((Control)this).get_Controls().Add((Control)(object)t5X());
		((Control)this).get_Controls().Add((Control)(object)Dn6());
		((Control)this).get_Controls().Add((Control)(object)k4E());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form3");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Calender Events");
		((ISupportInitialize)Dn6()).EndInit();
		((ISupportInitialize)w1K()).EndInit();
		((ISupportInitialize)Cz3()).EndInit();
		((ISupportInitialize)z6R()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button k4E()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a0Q(Button o8C)
	{
		EventHandler eventHandler = Fw1;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = o8C;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual MonthCalendar t5X()
	{
		return _MonthCalendar1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1P(MonthCalendar Tf4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		DateRangeEventHandler val = new DateRangeEventHandler(q6J);
		MonthCalendar monthCalendar = _MonthCalendar1;
		if (monthCalendar != null)
		{
			monthCalendar.remove_DateSelected(val);
		}
		_MonthCalendar1 = Tf4;
		monthCalendar = _MonthCalendar1;
		if (monthCalendar != null)
		{
			monthCalendar.add_DateSelected(val);
		}
	}

	[SpecialName]
	internal virtual PictureBox Dn6()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yy7(PictureBox Pn9)
	{
		PictureBox val = (N = Pn9);
	}

	[SpecialName]
	internal virtual Button e6Z()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Me6(Button w3Y)
	{
		EventHandler eventHandler = f3X;
		Button k = K;
		if (k != null)
		{
			((Control)k).remove_Click(eventHandler);
		}
		Button val = (K = w3Y);
		k = K;
		if (k != null)
		{
			((Control)k).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button o6W()
	{
		return _cmdBack;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ls3(Button Lj4)
	{
		EventHandler eventHandler = Ns6;
		Button cmdBack = _cmdBack;
		if (cmdBack != null)
		{
			((Control)cmdBack).remove_Click(eventHandler);
		}
		_cmdBack = Lj4;
		cmdBack = _cmdBack;
		if (cmdBack != null)
		{
			((Control)cmdBack).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Ry2()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5A(TextBox k6M)
	{
		TextBox val = (M = k6M);
	}

	[SpecialName]
	internal virtual PictureBox w1K()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9T(PictureBox Ha8)
	{
		_PictureBox3 = Ha8;
	}

	[SpecialName]
	internal virtual PictureBox z6R()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void St7(PictureBox n9T)
	{
		PictureBox val = (p = n9T);
	}

	[SpecialName]
	internal virtual PictureBox Cz3()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9K(PictureBox Yn7)
	{
		_PictureBox1 = Yn7;
	}

	[SpecialName]
	internal virtual Label Zs3()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1L(Label p0Q)
	{
		Label val = (b = p0Q);
	}

	private void q6J(object sender, DateRangeEventArgs e)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		t = t5X().get_SelectionRange().get_Start().Month.ToString() + t5X().get_SelectionRange().get_Start().Day;
		try
		{
			if (File.Exists(t + ".txt"))
			{
				((Control)t5X()).set_Enabled(false);
				((Control)t5X()).Hide();
				((Control)Zs3()).set_Enabled(false);
				((Control)Zs3()).Hide();
				((Control)Ry2()).set_Enabled(true);
				((Control)Ry2()).Show();
				((Control)e6Z()).set_Enabled(true);
				((Control)e6Z()).Show();
				((Control)o6W()).set_Enabled(true);
				((Control)o6W()).Show();
				Ry2().set_Text(File.ReadAllText(t + ".txt"));
				return;
			}
			m = Interaction.MsgBox((object)"Would you like to add Notes for this Date ?", (MsgBoxStyle)4, (object)null);
			if ((int)m == 6)
			{
				((Control)t5X()).set_Enabled(false);
				((Control)t5X()).Hide();
				((Control)Zs3()).set_Enabled(false);
				((Control)Zs3()).Hide();
				((Control)Ry2()).set_Enabled(true);
				((Control)Ry2()).Show();
				((Control)e6Z()).set_Enabled(true);
				((Control)e6Z()).Show();
				((Control)o6W()).set_Enabled(true);
				((Control)o6W()).Show();
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

	private void Ns6(object sender, EventArgs e)
	{
		((Control)Ry2()).set_Enabled(false);
		((Control)Ry2()).Hide();
		((Control)e6Z()).set_Enabled(false);
		((Control)e6Z()).Hide();
		((Control)o6W()).set_Enabled(false);
		((Control)o6W()).Hide();
		((Control)t5X()).set_Enabled(true);
		((Control)t5X()).Show();
		((Control)Zs3()).set_Enabled(true);
		((Control)Zs3()).Show();
	}

	private void f3X(object sender, EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(Ry2().get_Text(), "", false) == 0 && File.Exists(t + ".txt"))
			{
				File.Delete(t + ".txt");
				Interaction.MsgBox((object)"Note was deleted Successfully. Press Back to Continue", (MsgBoxStyle)0, (object)null);
			}
			if (Ry2().get_Text().Length > 0)
			{
				File.WriteAllText(t + ".txt", Ry2().get_Text());
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

	internal static void m1Z()
	{
		byte[] array = y6F.r0Y(133632);
		checked
		{
			int lq = Conversions.ToInteger(Ya7.mDic[Ya7.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = y6F.Ls4(array[i], (byte[])Ya7.mDic[Ya7.sArray], lq, i);
			}
			Ya7.mDic.Add(Ya7.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Kb2.a3Z5();
		}
	}

	private void Fw1(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Ft0()).Show();
		((Form)this).Close();
	}

	private void e6P(object sender, EventArgs e)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		t = t5X().get_SelectionRange().get_Start().Month.ToString() + t5X().get_SelectionRange().get_Start().Day;
		if ((DateTime.Compare(DateTime.Today, t5X().get_TodayDate()) == 0) & File.Exists(t + ".txt"))
		{
			MsgBoxResult val = Interaction.MsgBox((object)"View Today's Events ?", (MsgBoxStyle)4, (object)null);
			if ((int)val == 6)
			{
				((Control)t5X()).set_Enabled(false);
				((Control)t5X()).Hide();
				((Control)Zs3()).set_Enabled(false);
				((Control)Zs3()).Hide();
				((Control)Ry2()).set_Enabled(true);
				((Control)Ry2()).Show();
				((Control)e6Z()).set_Enabled(true);
				((Control)e6Z()).Show();
				((Control)o6W()).set_Enabled(true);
				((Control)o6W()).Show();
				Ry2().set_Text(File.ReadAllText(t + ".txt"));
			}
		}
	}
}
