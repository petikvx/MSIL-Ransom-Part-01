using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using x5X;

namespace m8F9;

[DesignerGenerated]
public class Tx0d : Form
{
	private TextBox _txtAnswer;

	private Label _Label1;

	private PictureBox _PictureBox1;

	private Label _lblT1RndSide;

	private Label _lbltest;

	private Label _Label7;

	private Label _Label3;

	private Label _lblT1side_b;

	private Label _lblT1side_a;

	private Label _Label2;

	private Label _Label8;

	private int i;

	private int b;

	private int c;

	private int n;

	private int score;

	private object _globalvariables;

	internal IContainer T;

	internal Label U;

	internal Button J;

	internal Label b;

	internal Label y;

	internal Label d;

	internal Label c;

	internal int p;

	internal float f;

	internal bool s;

	internal bool g;

	internal object E;

	public object globalvariables
	{
		get
		{
			return _globalvariables;
		}
		set
		{
			_globalvariables = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Tx0d()
	{
		((Form)this).add_Load((EventHandler)n9CS);
		score = 0;
		g = false;
		t8X2();
	}

	protected override void Dq24(bool Ax73)
	{
		try
		{
			if (Ax73 && T != null)
			{
				T.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ax73);
		}
	}

	private void t8X2()
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
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Tx0d));
		f1W2(new Label());
		Xz3e(new TextBox());
		b9Z7(new Label());
		Wt6w(new PictureBox());
		Pc90(new Label());
		c6Z3(new Label());
		f9K0(new Button());
		d6AK(new Label());
		Af1m(new Label());
		a6N7(new Label());
		Mp7m(new Label());
		x2F3(new Label());
		s6YF(new Label());
		p6M4(new Label());
		w9RA(new Label());
		g6AH(new Label());
		Md6f(new Label());
		((ISupportInitialize)w5BA()).BeginInit();
		((Control)this).SuspendLayout();
		Kn20().set_AutoSize(true);
		((Control)Kn20()).set_Location(new Point(13, 13));
		((Control)Kn20()).set_Name("lblT1Question");
		((Control)Kn20()).set_Size(new Size(15, 13));
		((Control)Kn20()).set_TabIndex(0);
		Kn20().set_Text("Q");
		((Control)Jn53()).set_Location(new Point(60, 364));
		((Control)Jn53()).set_Name("txtAnswer");
		((Control)Jn53()).set_Size(new Size(100, 20));
		((Control)Jn53()).set_TabIndex(1);
		Lk86().set_AutoSize(true);
		((Control)Lk86()).set_Location(new Point(12, 367));
		((Control)Lk86()).set_Name("Label1");
		((Control)Lk86()).set_Size(new Size(45, 13));
		((Control)Lk86()).set_TabIndex(2);
		Lk86().set_Text("Answer:");
		w5BA().set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)w5BA()).set_Location(new Point(119, 90));
		((Control)w5BA()).set_Name("PictureBox1");
		((Control)w5BA()).set_Size(new Size(233, 172));
		w5BA().set_SizeMode((PictureBoxSizeMode)1);
		w5BA().set_TabIndex(3);
		w5BA().set_TabStop(false);
		b1W2().set_AutoSize(true);
		((Control)b1W2()).set_Location(new Point(127, 13));
		((Control)b1W2()).set_Name("lblT1RndSide");
		((Control)b1W2()).set_Size(new Size(15, 13));
		((Control)b1W2()).set_TabIndex(13);
		b1W2().set_Text("R");
		z3GB().set_AutoSize(true);
		((Control)z3GB()).set_Location(new Point(442, 115));
		((Control)z3GB()).set_Name("lbltest");
		((Control)z3GB()).set_Size(new Size(34, 13));
		((Control)z3GB()).set_TabIndex(14);
		z3GB().set_Text("lbltest");
		((Control)z3GB()).set_Visible(false);
		((Control)Wd3w()).set_Location(new Point(167, 364));
		((Control)Wd3w()).set_Name("btnT1CheckAnswer");
		((Control)Wd3w()).set_Size(new Size(92, 23));
		((Control)Wd3w()).set_TabIndex(15);
		((ButtonBase)Wd3w()).set_Text("Check Answer");
		((ButtonBase)Wd3w()).set_UseVisualStyleBackColor(true);
		Di9z().set_AutoSize(true);
		((Control)Di9z()).set_Location(new Point(338, 298));
		((Control)Di9z()).set_Name("Label7");
		((Control)Di9z()).set_Size(new Size(19, 13));
		((Control)Di9z()).set_TabIndex(36);
		Di9z().set_Text("c=");
		o4J8().set_AutoSize(true);
		((Control)o4J8()).set_Location(new Point(205, 298));
		((Control)o4J8()).set_Name("Label6");
		((Control)o4J8()).set_Size(new Size(19, 13));
		((Control)o4J8()).set_TabIndex(35);
		o4J8().set_Text("b=");
		e9BF().set_AutoSize(true);
		((Control)e9BF()).set_Location(new Point(88, 298));
		((Control)e9BF()).set_Name("Label5");
		((Control)e9BF()).set_Size(new Size(19, 13));
		((Control)e9BF()).set_TabIndex(34);
		e9BF().set_Text("a=");
		Gn3d().set_AutoSize(true);
		((Control)Gn3d()).set_Location(new Point(197, 269));
		((Control)Gn3d()).set_Name("Label3");
		((Control)Gn3d()).set_Size(new Size(13, 13));
		((Control)Gn3d()).set_TabIndex(33);
		Gn3d().set_Text("b");
		e8Y9().set_AutoSize(true);
		((Control)e8Y9()).set_Location(new Point(357, 298));
		((Control)e8Y9()).set_Name("lblT1side_c");
		((Control)e8Y9()).set_Size(new Size(13, 13));
		((Control)e8Y9()).set_TabIndex(32);
		e8Y9().set_Text("c");
		Zs52().set_AutoSize(true);
		((Control)Zs52()).set_Location(new Point(224, 298));
		((Control)Zs52()).set_Name("lblT1side_b");
		((Control)Zs52()).set_Size(new Size(13, 13));
		((Control)Zs52()).set_TabIndex(31);
		Zs52().set_Text("b");
		Dq30().set_AutoSize(true);
		((Control)Dq30()).set_Location(new Point(107, 298));
		((Control)Dq30()).set_Name("lblT1side_a");
		((Control)Dq30()).set_Size(new Size(13, 13));
		((Control)Dq30()).set_TabIndex(30);
		Dq30().set_Text("a");
		k9XK().set_AutoSize(true);
		((Control)k9XK()).set_Location(new Point(100, 164));
		((Control)k9XK()).set_Name("Label2");
		((Control)k9XK()).set_Size(new Size(13, 13));
		((Control)k9XK()).set_TabIndex(37);
		k9XK().set_Text("a");
		d4M5().set_AutoSize(true);
		((Control)d4M5()).set_Location(new Point(219, 150));
		((Control)d4M5()).set_Name("Label4");
		((Control)d4M5()).set_Size(new Size(13, 13));
		((Control)d4M5()).set_TabIndex(38);
		d4M5().set_Text("c");
		j9FR().set_AutoSize(true);
		((Control)j9FR()).set_Location(new Point(150, 13));
		((Control)j9FR()).set_Name("Label8");
		((Control)j9FR()).set_Size(new Size(109, 13));
		((Control)j9FR()).set_TabIndex(39);
		j9FR().set_Text("to two decimal places");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(524, 389));
		((Control)this).get_Controls().Add((Control)(object)j9FR());
		((Control)this).get_Controls().Add((Control)(object)d4M5());
		((Control)this).get_Controls().Add((Control)(object)k9XK());
		((Control)this).get_Controls().Add((Control)(object)Di9z());
		((Control)this).get_Controls().Add((Control)(object)o4J8());
		((Control)this).get_Controls().Add((Control)(object)e9BF());
		((Control)this).get_Controls().Add((Control)(object)Gn3d());
		((Control)this).get_Controls().Add((Control)(object)e8Y9());
		((Control)this).get_Controls().Add((Control)(object)Zs52());
		((Control)this).get_Controls().Add((Control)(object)Dq30());
		((Control)this).get_Controls().Add((Control)(object)Wd3w());
		((Control)this).get_Controls().Add((Control)(object)z3GB());
		((Control)this).get_Controls().Add((Control)(object)b1W2());
		((Control)this).get_Controls().Add((Control)(object)w5BA());
		((Control)this).get_Controls().Add((Control)(object)Lk86());
		((Control)this).get_Controls().Add((Control)(object)Jn53());
		((Control)this).get_Controls().Add((Control)(object)Kn20());
		((Control)this).set_Name("T1Question");
		((Form)this).set_Text("Pythagoras");
		((ISupportInitialize)w5BA()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Kn20()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1W2(Label b9T6)
	{
		Label val = (U = b9T6);
	}

	[SpecialName]
	internal virtual TextBox Jn53()
	{
		return _txtAnswer;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xz3e(TextBox Tf5d)
	{
		_txtAnswer = Tf5d;
	}

	[SpecialName]
	internal virtual Label Lk86()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9Z7(Label Rr7k)
	{
		_Label1 = Rr7k;
	}

	[SpecialName]
	internal virtual PictureBox w5BA()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wt6w(PictureBox Li6s)
	{
		_PictureBox1 = Li6s;
	}

	[SpecialName]
	internal virtual Label b1W2()
	{
		return _lblT1RndSide;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pc90(Label x0T9)
	{
		_lblT1RndSide = x0T9;
	}

	[SpecialName]
	internal virtual Label z3GB()
	{
		return _lbltest;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6Z3(Label z4JH)
	{
		_lbltest = z4JH;
	}

	[SpecialName]
	internal virtual Button Wd3w()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9K0(Button Kk3w)
	{
		EventHandler eventHandler = i7S3;
		Button j = J;
		if (j != null)
		{
			((Control)j).remove_Click(eventHandler);
		}
		Button val = (J = Kk3w);
		j = J;
		if (j != null)
		{
			((Control)j).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Di9z()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6AK(Label e9MT)
	{
		_Label7 = e9MT;
	}

	[SpecialName]
	internal virtual Label o4J8()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Af1m(Label Sx5o)
	{
		Label val = (b = Sx5o);
	}

	[SpecialName]
	internal virtual Label e9BF()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6N7(Label Qf1c)
	{
		Label val = (y = Qf1c);
	}

	[SpecialName]
	internal virtual Label Gn3d()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mp7m(Label Mo4p)
	{
		_Label3 = Mo4p;
	}

	[SpecialName]
	internal virtual Label e8Y9()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2F3(Label o1B5)
	{
		Label val = (d = o1B5);
	}

	[SpecialName]
	internal virtual Label Zs52()
	{
		return _lblT1side_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6YF(Label s1Z2)
	{
		_lblT1side_b = s1Z2;
	}

	[SpecialName]
	internal virtual Label Dq30()
	{
		return _lblT1side_a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p6M4(Label m0A5)
	{
		_lblT1side_a = m0A5;
	}

	[SpecialName]
	internal virtual Label k9XK()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w9RA(Label j4ZJ)
	{
		_Label2 = j4ZJ;
	}

	[SpecialName]
	internal virtual Label d4M5()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6AH(Label Ab48)
	{
		Label val = (c = Ab48);
	}

	[SpecialName]
	internal virtual Label j9FR()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Md6f(Label Hf4m)
	{
		_Label8 = Hf4m;
	}

	public void Tr63(string Lg0r)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		val.Open();
		OleDbDataAdapter val2 = new OleDbDataAdapter(Lg0r, val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		Kn20().set_Text(Conversions.ToString(dataTable.Rows[0][0]));
		val.Close();
		((Component)(object)val).Dispose();
	}

	public void n6Z9()
	{
		string lg0r = "SELECT Question FROM tblQuestions WHERE TopicNo = 1;";
		Tr63(lg0r);
	}

	public void Yp8x()
	{
		float num = (f = 0f);
		checked
		{
			if (i == 3)
			{
				this.c = (int)Math.Round(Math.Pow(p, 2.0) + Math.Pow(this.b, 2.0));
				float num2 = (f = (float)Math.Sqrt(this.c));
			}
			else if (i == 2)
			{
				this.b = (int)Math.Round(Math.Pow(this.c, 2.0) - Math.Pow(p, 2.0));
				float num3 = (f = (float)Math.Sqrt(this.b));
			}
			else if (i == 1)
			{
				int num4 = (p = (int)Math.Round(Math.Pow(this.c, 2.0) - Math.Pow(this.b, 2.0)));
				float num5 = (f = (float)Math.Sqrt(p));
			}
			float num6 = (f = (float)Math.Round(f, 2));
		}
	}

	public void n9KW()
	{
		int num = 9;
		int num2 = 2;
		VBMath.Randomize();
		checked
		{
			i = (int)Math.Floor(3f * VBMath.Rnd()) + 1;
			if (i == 1)
			{
				b1W2().set_Text("a");
			}
			else if (i == 2)
			{
				b1W2().set_Text("b");
			}
			else if (i == 3)
			{
				b1W2().set_Text("c");
			}
			if (i == 3)
			{
				int num3 = (p = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2);
				this.b = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
				Dq30().set_Text(Conversions.ToString(p));
				Zs52().set_Text(Conversions.ToString(this.b));
				e8Y9().set_Text("c");
			}
			else if (i == 2)
			{
				while (this.c <= p)
				{
					int num4 = (p = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2);
					this.c = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					Dq30().set_Text(Conversions.ToString(p));
					e8Y9().set_Text(Conversions.ToString(this.c));
					Zs52().set_Text("b");
				}
			}
			else if (i == 1)
			{
				while (this.c <= this.b)
				{
					this.b = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					this.c = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					Zs52().set_Text(Conversions.ToString(this.b));
					e8Y9().set_Text(Conversions.ToString(this.c));
					Dq30().set_Text("a");
				}
			}
		}
	}

	internal static string k5FY(string r3XF)
	{
		Type type = (Type)t2P.mDic[t2P.T];
		return Conversions.ToString(type.InvokeMember(r3XF, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	public void c8YS()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		string value = "";
		try
		{
			value = Jn53().get_Text();
			g = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("Please enter an answer");
			ProjectData.ClearProjectError();
		}
		float num = Convert.ToSingle(value);
		checked
		{
			if (num == f)
			{
				score++;
				Interaction.MsgBox((object)("Correct answer, Score is: " + Conversions.ToString(score)), (MsgBoxStyle)0, (object)null);
				n6Z9();
				n9KW();
				Yp8x();
				p = 0;
				this.b = 0;
				this.c = 0;
			}
			else
			{
				Interaction.MsgBox((object)("Incorrect, right answer is: " + Conversions.ToString(f) + " Your Score is: " + Conversions.ToString(score)), (MsgBoxStyle)0, (object)null);
				n6Z9();
				n9KW();
				Yp8x();
				p = 0;
				this.b = 0;
				this.c = 0;
			}
		}
	}

	private void n9CS(object sender, EventArgs e)
	{
		p = 0;
		this.b = 0;
		this.c = 0;
		float num = (f = 0f);
		n6Z9();
		n9KW();
		Yp8x();
		z3GB().set_Text(Conversions.ToString(f));
	}

	public void c3XD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		string text = "Score";
		OleDbConnection Mg = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		Mg.Open();
		string jn = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("UPDATE tblStudentScores SET " + text + " = " + Conversions.ToString(score) + " WHERE ID = "), NewLateBinding.LateGet(globalvariables, (Type)null, "StuID", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" AND TopicNo = 1"));
		Lq97(jn, ref Mg);
		Mg.Close();
		((Component)(object)Mg).Dispose();
	}

	private void i7S3(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (Operators.CompareString(Jn53().get_Text(), "", false) == 0)
			{
				Interaction.MsgBox((object)"Enter an answer", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				c8YS();
				if (n < 9)
				{
					Kn20().set_Text("");
					Jn53().set_Text("");
					n++;
					n6Z9();
					z3GB().set_Text(Conversions.ToString(f));
				}
				else
				{
					s = true;
				}
			}
			if (s)
			{
				Interaction.MsgBox((object)("You scored: " + Conversions.ToString(score)), (MsgBoxStyle)0, (object)null);
				c3XD();
				((Form)this).Close();
				NewLateBinding.LateCall(E, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void Lq97(string Jn63, ref OleDbConnection Mg37)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		OleDbCommand val = new OleDbCommand(Jn63, Mg37);
		try
		{
			val.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Failed:\r\n" + ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			((Component)(object)val).Dispose();
		}
	}

	internal static void Fk53(string x0L1)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		k5FY(x0L1);
	}
}
