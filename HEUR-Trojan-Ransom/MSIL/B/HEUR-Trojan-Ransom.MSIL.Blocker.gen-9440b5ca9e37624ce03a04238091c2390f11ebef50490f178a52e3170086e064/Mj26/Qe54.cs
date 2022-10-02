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
using Km2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Mj26;

[DesignerGenerated]
public class Qe54 : Form
{
	private Label _lblT1Question;

	private TextBox _txtAnswer;

	private PictureBox _PictureBox1;

	private Label _lblT1RndSide;

	private Label _Label7;

	private Label _Label6;

	private Label _Label5;

	private Label _Label3;

	private Label _lblT1side_a;

	private int b;

	private int c;

	private int n;

	private int score;

	private readonly object Student_Menu;

	private object _globalvariables;

	internal IContainer B;

	internal Label y;

	internal Label l;

	internal Button T;

	internal Label p;

	internal Label F;

	internal Label Q;

	internal Label g;

	internal Label c;

	internal int o;

	internal int w;

	internal float s;

	internal bool e;

	internal bool u;

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

	public Qe54()
	{
		((Form)this).add_Load((EventHandler)Re9x);
		score = 0;
		u = false;
		r7SA();
	}

	protected override void Wy89(bool e0G4)
	{
		try
		{
			if (e0G4 && B != null)
			{
				B.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e0G4);
		}
	}

	private void r7SA()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Qe54));
		Em96(new Label());
		e2N1(new TextBox());
		Bf70(new Label());
		Sa18(new PictureBox());
		j5DX(new Label());
		Tx37(new Label());
		p4M9(new Button());
		Rk65(new Label());
		Ft3i(new Label());
		Dr24(new Label());
		Jk4w(new Label());
		b3A9(new Label());
		Pz0s(new Label());
		q3PN(new Label());
		Ak37(new Label());
		Rs4o(new Label());
		s7KY(new Label());
		((ISupportInitialize)d9X6()).BeginInit();
		((Control)this).SuspendLayout();
		Ya46().set_AutoSize(true);
		((Control)Ya46()).set_Location(new Point(13, 13));
		((Control)Ya46()).set_Name("lblT1Question");
		((Control)Ya46()).set_Size(new Size(15, 13));
		((Control)Ya46()).set_TabIndex(0);
		Ya46().set_Text("Q");
		((Control)Xn56()).set_Location(new Point(60, 364));
		((Control)Xn56()).set_Name("txtAnswer");
		((Control)Xn56()).set_Size(new Size(100, 20));
		((Control)Xn56()).set_TabIndex(1);
		r7K4().set_AutoSize(true);
		((Control)r7K4()).set_Location(new Point(12, 367));
		((Control)r7K4()).set_Name("Label1");
		((Control)r7K4()).set_Size(new Size(45, 13));
		((Control)r7K4()).set_TabIndex(2);
		r7K4().set_Text("Answer:");
		d9X6().set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)d9X6()).set_Location(new Point(119, 90));
		((Control)d9X6()).set_Name("PictureBox1");
		((Control)d9X6()).set_Size(new Size(233, 172));
		d9X6().set_SizeMode((PictureBoxSizeMode)1);
		d9X6().set_TabIndex(3);
		d9X6().set_TabStop(false);
		Lm45().set_AutoSize(true);
		((Control)Lm45()).set_Location(new Point(127, 13));
		((Control)Lm45()).set_Name("lblT1RndSide");
		((Control)Lm45()).set_Size(new Size(15, 13));
		((Control)Lm45()).set_TabIndex(13);
		Lm45().set_Text("R");
		i9Z7().set_AutoSize(true);
		((Control)i9Z7()).set_Location(new Point(442, 115));
		((Control)i9Z7()).set_Name("lbltest");
		((Control)i9Z7()).set_Size(new Size(34, 13));
		((Control)i9Z7()).set_TabIndex(14);
		i9Z7().set_Text("lbltest");
		((Control)i9Z7()).set_Visible(false);
		((Control)x0Z5()).set_Location(new Point(167, 364));
		((Control)x0Z5()).set_Name("btnT1CheckAnswer");
		((Control)x0Z5()).set_Size(new Size(92, 23));
		((Control)x0Z5()).set_TabIndex(15);
		((ButtonBase)x0Z5()).set_Text("Check Answer");
		((ButtonBase)x0Z5()).set_UseVisualStyleBackColor(true);
		Sz98().set_AutoSize(true);
		((Control)Sz98()).set_Location(new Point(338, 298));
		((Control)Sz98()).set_Name("Label7");
		((Control)Sz98()).set_Size(new Size(19, 13));
		((Control)Sz98()).set_TabIndex(36);
		Sz98().set_Text("c=");
		q4Q5().set_AutoSize(true);
		((Control)q4Q5()).set_Location(new Point(205, 298));
		((Control)q4Q5()).set_Name("Label6");
		((Control)q4Q5()).set_Size(new Size(19, 13));
		((Control)q4Q5()).set_TabIndex(35);
		q4Q5().set_Text("b=");
		Ce7w().set_AutoSize(true);
		((Control)Ce7w()).set_Location(new Point(88, 298));
		((Control)Ce7w()).set_Name("Label5");
		((Control)Ce7w()).set_Size(new Size(19, 13));
		((Control)Ce7w()).set_TabIndex(34);
		Ce7w().set_Text("a=");
		f7A3().set_AutoSize(true);
		((Control)f7A3()).set_Location(new Point(197, 269));
		((Control)f7A3()).set_Name("Label3");
		((Control)f7A3()).set_Size(new Size(13, 13));
		((Control)f7A3()).set_TabIndex(33);
		f7A3().set_Text("b");
		Li52().set_AutoSize(true);
		((Control)Li52()).set_Location(new Point(357, 298));
		((Control)Li52()).set_Name("lblT1side_c");
		((Control)Li52()).set_Size(new Size(13, 13));
		((Control)Li52()).set_TabIndex(32);
		Li52().set_Text("c");
		n3SR().set_AutoSize(true);
		((Control)n3SR()).set_Location(new Point(224, 298));
		((Control)n3SR()).set_Name("lblT1side_b");
		((Control)n3SR()).set_Size(new Size(13, 13));
		((Control)n3SR()).set_TabIndex(31);
		n3SR().set_Text("b");
		n4Y9().set_AutoSize(true);
		((Control)n4Y9()).set_Location(new Point(107, 298));
		((Control)n4Y9()).set_Name("lblT1side_a");
		((Control)n4Y9()).set_Size(new Size(13, 13));
		((Control)n4Y9()).set_TabIndex(30);
		n4Y9().set_Text("a");
		t8GM().set_AutoSize(true);
		((Control)t8GM()).set_Location(new Point(100, 164));
		((Control)t8GM()).set_Name("Label2");
		((Control)t8GM()).set_Size(new Size(13, 13));
		((Control)t8GM()).set_TabIndex(37);
		t8GM().set_Text("a");
		Wa7d().set_AutoSize(true);
		((Control)Wa7d()).set_Location(new Point(219, 150));
		((Control)Wa7d()).set_Name("Label4");
		((Control)Wa7d()).set_Size(new Size(13, 13));
		((Control)Wa7d()).set_TabIndex(38);
		Wa7d().set_Text("c");
		Yb65().set_AutoSize(true);
		((Control)Yb65()).set_Location(new Point(150, 13));
		((Control)Yb65()).set_Name("Label8");
		((Control)Yb65()).set_Size(new Size(109, 13));
		((Control)Yb65()).set_TabIndex(39);
		Yb65().set_Text("to two decimal places");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(524, 389));
		((Control)this).get_Controls().Add((Control)(object)Yb65());
		((Control)this).get_Controls().Add((Control)(object)Wa7d());
		((Control)this).get_Controls().Add((Control)(object)t8GM());
		((Control)this).get_Controls().Add((Control)(object)Sz98());
		((Control)this).get_Controls().Add((Control)(object)q4Q5());
		((Control)this).get_Controls().Add((Control)(object)Ce7w());
		((Control)this).get_Controls().Add((Control)(object)f7A3());
		((Control)this).get_Controls().Add((Control)(object)Li52());
		((Control)this).get_Controls().Add((Control)(object)n3SR());
		((Control)this).get_Controls().Add((Control)(object)n4Y9());
		((Control)this).get_Controls().Add((Control)(object)x0Z5());
		((Control)this).get_Controls().Add((Control)(object)i9Z7());
		((Control)this).get_Controls().Add((Control)(object)Lm45());
		((Control)this).get_Controls().Add((Control)(object)d9X6());
		((Control)this).get_Controls().Add((Control)(object)r7K4());
		((Control)this).get_Controls().Add((Control)(object)Xn56());
		((Control)this).get_Controls().Add((Control)(object)Ya46());
		((Control)this).set_Name("T1Question");
		((Form)this).set_Text("Pythagoras");
		((ISupportInitialize)d9X6()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Ya46()
	{
		return _lblT1Question;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Em96(Label Di90)
	{
		_lblT1Question = Di90;
	}

	[SpecialName]
	internal virtual TextBox Xn56()
	{
		return _txtAnswer;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2N1(TextBox Qk9z)
	{
		_txtAnswer = Qk9z;
	}

	[SpecialName]
	internal virtual Label r7K4()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bf70(Label o0E8)
	{
		Label val = (y = o0E8);
	}

	[SpecialName]
	internal virtual PictureBox d9X6()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sa18(PictureBox Zt86)
	{
		_PictureBox1 = Zt86;
	}

	[SpecialName]
	internal virtual Label Lm45()
	{
		return _lblT1RndSide;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5DX(Label j8GN)
	{
		_lblT1RndSide = j8GN;
	}

	[SpecialName]
	internal virtual Label i9Z7()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tx37(Label Fj07)
	{
		Label val = (l = Fj07);
	}

	[SpecialName]
	internal virtual Button x0Z5()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4M9(Button Zy4s)
	{
		EventHandler eventHandler = Na0d;
		Button t = T;
		if (t != null)
		{
			((Control)t).remove_Click(eventHandler);
		}
		Button val = (T = Zy4s);
		t = T;
		if (t != null)
		{
			((Control)t).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Sz98()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rk65(Label o2RK)
	{
		_Label7 = o2RK;
	}

	[SpecialName]
	internal virtual Label q4Q5()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ft3i(Label e4B7)
	{
		_Label6 = e4B7;
	}

	[SpecialName]
	internal virtual Label Ce7w()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dr24(Label x2CT)
	{
		_Label5 = x2CT;
	}

	[SpecialName]
	internal virtual Label f7A3()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jk4w(Label Kx9c)
	{
		_Label3 = Kx9c;
	}

	[SpecialName]
	internal virtual Label Li52()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3A9(Label Hj46)
	{
		Label val = (p = Hj46);
	}

	[SpecialName]
	internal virtual Label n3SR()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pz0s(Label Dd0q)
	{
		Label val = (F = Dd0q);
	}

	[SpecialName]
	internal virtual Label n4Y9()
	{
		return _lblT1side_a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3PN(Label Wq93)
	{
		_lblT1side_a = Wq93;
	}

	[SpecialName]
	internal virtual Label t8GM()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ak37(Label Jz92)
	{
		Label val = (Q = Jz92);
	}

	[SpecialName]
	internal virtual Label Wa7d()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rs4o(Label Ks71)
	{
		Label val = (g = Ks71);
	}

	[SpecialName]
	internal virtual Label Yb65()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7KY(Label Jp8g)
	{
		Label val = (c = Jp8g);
	}

	public void w3CY(string y3W2)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		val.Open();
		OleDbDataAdapter val2 = new OleDbDataAdapter(y3W2, val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		Ya46().set_Text(Conversions.ToString(dataTable.Rows[0][0]));
		val.Close();
		((Component)(object)val).Dispose();
	}

	public void x6TK()
	{
		string y3W = "SELECT Question FROM tblQuestions WHERE TopicNo = 1;";
		w3CY(y3W);
	}

	public void Jg52()
	{
		float num = (s = 0f);
		checked
		{
			if (o == 3)
			{
				this.c = (int)Math.Round(Math.Pow(w, 2.0) + Math.Pow(b, 2.0));
				float num2 = (s = (float)Math.Sqrt(this.c));
			}
			else if (o == 2)
			{
				b = (int)Math.Round(Math.Pow(this.c, 2.0) - Math.Pow(w, 2.0));
				float num3 = (s = (float)Math.Sqrt(b));
			}
			else if (o == 1)
			{
				int num4 = (w = (int)Math.Round(Math.Pow(this.c, 2.0) - Math.Pow(b, 2.0)));
				float num5 = (s = (float)Math.Sqrt(w));
			}
			float num6 = (s = (float)Math.Round(s, 2));
		}
	}

	public void i7SM()
	{
		int num = 9;
		int num2 = 2;
		VBMath.Randomize();
		checked
		{
			int num3 = (o = (int)Math.Floor(3f * VBMath.Rnd()) + 1);
			if (o == 1)
			{
				Lm45().set_Text("a");
			}
			else if (o == 2)
			{
				Lm45().set_Text("b");
			}
			else if (o == 3)
			{
				Lm45().set_Text("c");
			}
			if (o == 3)
			{
				int num4 = (w = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2);
				b = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
				n4Y9().set_Text(Conversions.ToString(w));
				n3SR().set_Text(Conversions.ToString(b));
				Li52().set_Text("c");
			}
			else if (o == 2)
			{
				while (this.c <= w)
				{
					int num5 = (w = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2);
					this.c = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					n4Y9().set_Text(Conversions.ToString(w));
					Li52().set_Text(Conversions.ToString(this.c));
					n3SR().set_Text("b");
				}
			}
			else if (o == 1)
			{
				while (this.c <= b)
				{
					b = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					this.c = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					n3SR().set_Text(Conversions.ToString(b));
					Li52().set_Text(Conversions.ToString(this.c));
					n4Y9().set_Text("a");
				}
			}
		}
	}

	internal static string t4YX(string Be7b)
	{
		Type type = (Type)Rf6.mDic[Rf6.T];
		return Conversions.ToString(type.InvokeMember(Be7b, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	public void f2B1()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		string value = "";
		try
		{
			value = Xn56().get_Text();
			u = true;
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
			if (num == s)
			{
				score++;
				Interaction.MsgBox((object)("Correct answer, Score is: " + Conversions.ToString(score)), (MsgBoxStyle)0, (object)null);
				x6TK();
				i7SM();
				Jg52();
				w = 0;
				b = 0;
				this.c = 0;
			}
			else
			{
				Interaction.MsgBox((object)("Incorrect, right answer is: " + Conversions.ToString(s) + " Your Score is: " + Conversions.ToString(score)), (MsgBoxStyle)0, (object)null);
				x6TK();
				i7SM();
				Jg52();
				w = 0;
				b = 0;
				this.c = 0;
			}
		}
	}

	private void Re9x(object sender, EventArgs e)
	{
		w = 0;
		b = 0;
		this.c = 0;
		float num = (s = 0f);
		x6TK();
		i7SM();
		Jg52();
		i9Z7().set_Text(Conversions.ToString(s));
	}

	public void q5D0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		string text = "Score";
		OleDbConnection m7YJ = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		m7YJ.Open();
		string z3G = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("UPDATE tblStudentScores SET " + text + " = " + Conversions.ToString(score) + " WHERE ID = "), NewLateBinding.LateGet(globalvariables, (Type)null, "StuID", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" AND TopicNo = 1"));
		Lz7g(z3G, ref m7YJ);
		m7YJ.Close();
		((Component)(object)m7YJ).Dispose();
	}

	private void Na0d(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (Operators.CompareString(Xn56().get_Text(), "", false) == 0)
			{
				Interaction.MsgBox((object)"Enter an answer", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				f2B1();
				if (n < 9)
				{
					Ya46().set_Text("");
					Xn56().set_Text("");
					n++;
					x6TK();
					i9Z7().set_Text(Conversions.ToString(s));
				}
				else
				{
					this.e = true;
				}
			}
			if (this.e)
			{
				Interaction.MsgBox((object)("You scored: " + Conversions.ToString(score)), (MsgBoxStyle)0, (object)null);
				q5D0();
				((Form)this).Close();
				NewLateBinding.LateCall(Student_Menu, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void Lz7g(string z3G7, ref OleDbConnection m7YJ)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		OleDbCommand val = new OleDbCommand(z3G7, m7YJ);
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

	internal static void e7DW(string Ng4s)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		t4YX(Ng4s);
	}
}
