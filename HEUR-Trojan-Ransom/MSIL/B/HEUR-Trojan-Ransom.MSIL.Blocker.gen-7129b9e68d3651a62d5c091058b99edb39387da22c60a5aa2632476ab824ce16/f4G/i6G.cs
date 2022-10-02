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
using k9W;

namespace f4G;

[DesignerGenerated]
public class i6G : Form
{
	private IContainer components;

	private Label _lblT1Question;

	private TextBox _txtAnswer;

	private Label _Label1;

	private Label _lbltest;

	private Button _btnT1CheckAnswer;

	private Label _Label5;

	private Label _Label3;

	private Label _lblT1side_c;

	private Label _lblT1side_b;

	private Label _lblT1side_a;

	private Label _Label2;

	private Label _Label4;

	private int i;

	private int a;

	private int b;

	private int c;

	private int n;

	private float answer;

	private bool valid;

	private object _globalvariables;

	internal PictureBox H;

	internal Label t;

	internal Label Y;

	internal Label B;

	internal Label c;

	internal int J;

	internal bool V;

	internal object S;

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

	public i6G()
	{
		((Form)this).add_Load((EventHandler)z2F);
		J = 0;
		valid = false;
		n6L();
	}

	protected override void t2Z(bool Yf5)
	{
		try
		{
			if (Yf5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Yf5);
		}
	}

	private void n6L()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(i6G));
		c1X(new Label());
		b9N(new TextBox());
		t9X(new Label());
		Er3(new PictureBox());
		e4X(new Label());
		a0D(new Label());
		Jp8(new Button());
		Dz9(new Label());
		z6F(new Label());
		Tc7(new Label());
		Px8(new Label());
		i5S(new Label());
		p7P(new Label());
		Ad4(new Label());
		z8G(new Label());
		Mx1(new Label());
		c5D(new Label());
		((ISupportInitialize)p5A()).BeginInit();
		((Control)this).SuspendLayout();
		Ng2().set_AutoSize(true);
		((Control)Ng2()).set_Location(new Point(13, 13));
		((Control)Ng2()).set_Name("lblT1Question");
		((Control)Ng2()).set_Size(new Size(15, 13));
		((Control)Ng2()).set_TabIndex(0);
		Ng2().set_Text("Q");
		((Control)Rc6()).set_Location(new Point(60, 364));
		((Control)Rc6()).set_Name("txtAnswer");
		((Control)Rc6()).set_Size(new Size(100, 20));
		((Control)Rc6()).set_TabIndex(1);
		Mi9().set_AutoSize(true);
		((Control)Mi9()).set_Location(new Point(12, 367));
		((Control)Mi9()).set_Name("Label1");
		((Control)Mi9()).set_Size(new Size(45, 13));
		((Control)Mi9()).set_TabIndex(2);
		Mi9().set_Text("Answer:");
		p5A().set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)p5A()).set_Location(new Point(119, 90));
		((Control)p5A()).set_Name("PictureBox1");
		((Control)p5A()).set_Size(new Size(233, 172));
		p5A().set_SizeMode((PictureBoxSizeMode)1);
		p5A().set_TabIndex(3);
		p5A().set_TabStop(false);
		Zc0().set_AutoSize(true);
		((Control)Zc0()).set_Location(new Point(127, 13));
		((Control)Zc0()).set_Name("lblT1RndSide");
		((Control)Zc0()).set_Size(new Size(15, 13));
		((Control)Zc0()).set_TabIndex(13);
		Zc0().set_Text("R");
		Pk3().set_AutoSize(true);
		((Control)Pk3()).set_Location(new Point(442, 115));
		((Control)Pk3()).set_Name("lbltest");
		((Control)Pk3()).set_Size(new Size(34, 13));
		((Control)Pk3()).set_TabIndex(14);
		Pk3().set_Text("lbltest");
		((Control)Pk3()).set_Visible(false);
		((Control)x3E()).set_Location(new Point(167, 364));
		((Control)x3E()).set_Name("btnT1CheckAnswer");
		((Control)x3E()).set_Size(new Size(92, 23));
		((Control)x3E()).set_TabIndex(15);
		((ButtonBase)x3E()).set_Text("Check Answer");
		((ButtonBase)x3E()).set_UseVisualStyleBackColor(true);
		Qc4().set_AutoSize(true);
		((Control)Qc4()).set_Location(new Point(338, 298));
		((Control)Qc4()).set_Name("Label7");
		((Control)Qc4()).set_Size(new Size(19, 13));
		((Control)Qc4()).set_TabIndex(36);
		Qc4().set_Text("c=");
		t7Q().set_AutoSize(true);
		((Control)t7Q()).set_Location(new Point(205, 298));
		((Control)t7Q()).set_Name("Label6");
		((Control)t7Q()).set_Size(new Size(19, 13));
		((Control)t7Q()).set_TabIndex(35);
		t7Q().set_Text("b=");
		w2N().set_AutoSize(true);
		((Control)w2N()).set_Location(new Point(88, 298));
		((Control)w2N()).set_Name("Label5");
		((Control)w2N()).set_Size(new Size(19, 13));
		((Control)w2N()).set_TabIndex(34);
		w2N().set_Text("a=");
		Gb2().set_AutoSize(true);
		((Control)Gb2()).set_Location(new Point(197, 269));
		((Control)Gb2()).set_Name("Label3");
		((Control)Gb2()).set_Size(new Size(13, 13));
		((Control)Gb2()).set_TabIndex(33);
		Gb2().set_Text("b");
		g8W().set_AutoSize(true);
		((Control)g8W()).set_Location(new Point(357, 298));
		((Control)g8W()).set_Name("lblT1side_c");
		((Control)g8W()).set_Size(new Size(13, 13));
		((Control)g8W()).set_TabIndex(32);
		g8W().set_Text("c");
		o7L().set_AutoSize(true);
		((Control)o7L()).set_Location(new Point(224, 298));
		((Control)o7L()).set_Name("lblT1side_b");
		((Control)o7L()).set_Size(new Size(13, 13));
		((Control)o7L()).set_TabIndex(31);
		o7L().set_Text("b");
		g2H().set_AutoSize(true);
		((Control)g2H()).set_Location(new Point(107, 298));
		((Control)g2H()).set_Name("lblT1side_a");
		((Control)g2H()).set_Size(new Size(13, 13));
		((Control)g2H()).set_TabIndex(30);
		g2H().set_Text("a");
		t3H().set_AutoSize(true);
		((Control)t3H()).set_Location(new Point(100, 164));
		((Control)t3H()).set_Name("Label2");
		((Control)t3H()).set_Size(new Size(13, 13));
		((Control)t3H()).set_TabIndex(37);
		t3H().set_Text("a");
		i1D().set_AutoSize(true);
		((Control)i1D()).set_Location(new Point(219, 150));
		((Control)i1D()).set_Name("Label4");
		((Control)i1D()).set_Size(new Size(13, 13));
		((Control)i1D()).set_TabIndex(38);
		i1D().set_Text("c");
		Cd8().set_AutoSize(true);
		((Control)Cd8()).set_Location(new Point(150, 13));
		((Control)Cd8()).set_Name("Label8");
		((Control)Cd8()).set_Size(new Size(109, 13));
		((Control)Cd8()).set_TabIndex(39);
		Cd8().set_Text("to two decimal places");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(524, 389));
		((Control)this).get_Controls().Add((Control)(object)Cd8());
		((Control)this).get_Controls().Add((Control)(object)i1D());
		((Control)this).get_Controls().Add((Control)(object)t3H());
		((Control)this).get_Controls().Add((Control)(object)Qc4());
		((Control)this).get_Controls().Add((Control)(object)t7Q());
		((Control)this).get_Controls().Add((Control)(object)w2N());
		((Control)this).get_Controls().Add((Control)(object)Gb2());
		((Control)this).get_Controls().Add((Control)(object)g8W());
		((Control)this).get_Controls().Add((Control)(object)o7L());
		((Control)this).get_Controls().Add((Control)(object)g2H());
		((Control)this).get_Controls().Add((Control)(object)x3E());
		((Control)this).get_Controls().Add((Control)(object)Pk3());
		((Control)this).get_Controls().Add((Control)(object)Zc0());
		((Control)this).get_Controls().Add((Control)(object)p5A());
		((Control)this).get_Controls().Add((Control)(object)Mi9());
		((Control)this).get_Controls().Add((Control)(object)Rc6());
		((Control)this).get_Controls().Add((Control)(object)Ng2());
		((Control)this).set_Name("T1Question");
		((Form)this).set_Text("Pythagoras");
		((ISupportInitialize)p5A()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Ng2()
	{
		return _lblT1Question;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1X(Label Zn4)
	{
		_lblT1Question = Zn4;
	}

	[SpecialName]
	internal virtual TextBox Rc6()
	{
		return _txtAnswer;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9N(TextBox a6B)
	{
		_txtAnswer = a6B;
	}

	[SpecialName]
	internal virtual Label Mi9()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9X(Label Ab7)
	{
		_Label1 = Ab7;
	}

	[SpecialName]
	internal virtual PictureBox p5A()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Er3(PictureBox Ma6)
	{
		PictureBox val = (H = Ma6);
	}

	[SpecialName]
	internal virtual Label Zc0()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4X(Label g0E)
	{
		Label val = (t = g0E);
	}

	[SpecialName]
	internal virtual Label Pk3()
	{
		return _lbltest;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a0D(Label Aq3)
	{
		_lbltest = Aq3;
	}

	[SpecialName]
	internal virtual Button x3E()
	{
		return _btnT1CheckAnswer;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jp8(Button Gr3)
	{
		EventHandler eventHandler = Mr3;
		Button btnT1CheckAnswer = _btnT1CheckAnswer;
		if (btnT1CheckAnswer != null)
		{
			((Control)btnT1CheckAnswer).remove_Click(eventHandler);
		}
		_btnT1CheckAnswer = Gr3;
		btnT1CheckAnswer = _btnT1CheckAnswer;
		if (btnT1CheckAnswer != null)
		{
			((Control)btnT1CheckAnswer).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Qc4()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dz9(Label w7X)
	{
		Label val = (Y = w7X);
	}

	[SpecialName]
	internal virtual Label t7Q()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6F(Label Yb8)
	{
		Label val = (B = Yb8);
	}

	[SpecialName]
	internal virtual Label w2N()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tc7(Label n3W)
	{
		_Label5 = n3W;
	}

	[SpecialName]
	internal virtual Label Gb2()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Px8(Label Wg1)
	{
		_Label3 = Wg1;
	}

	[SpecialName]
	internal virtual Label g8W()
	{
		return _lblT1side_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5S(Label t4N)
	{
		_lblT1side_c = t4N;
	}

	[SpecialName]
	internal virtual Label o7L()
	{
		return _lblT1side_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7P(Label Dm2)
	{
		_lblT1side_b = Dm2;
	}

	[SpecialName]
	internal virtual Label g2H()
	{
		return _lblT1side_a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ad4(Label p3G)
	{
		_lblT1side_a = p3G;
	}

	[SpecialName]
	internal virtual Label t3H()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8G(Label Kk1)
	{
		_Label2 = Kk1;
	}

	[SpecialName]
	internal virtual Label i1D()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mx1(Label i1E)
	{
		_Label4 = i1E;
	}

	[SpecialName]
	internal virtual Label Cd8()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5D(Label Qd9)
	{
		Label val = (c = Qd9);
	}

	public void Yk9(string a4G)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		val.Open();
		OleDbDataAdapter val2 = new OleDbDataAdapter(a4G, val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		Ng2().set_Text(Conversions.ToString(dataTable.Rows[0][0]));
		val.Close();
		((Component)(object)val).Dispose();
	}

	public void So0()
	{
		string a4G = "SELECT Question FROM tblQuestions WHERE TopicNo = 1;";
		Yk9(a4G);
	}

	public void j5F()
	{
		answer = 0f;
		checked
		{
			if (i == 3)
			{
				this.c = (int)Math.Round(Math.Pow(a, 2.0) + Math.Pow(b, 2.0));
				answer = (float)Math.Sqrt(this.c);
			}
			else if (i == 2)
			{
				b = (int)Math.Round(Math.Pow(this.c, 2.0) - Math.Pow(a, 2.0));
				answer = (float)Math.Sqrt(b);
			}
			else if (i == 1)
			{
				a = (int)Math.Round(Math.Pow(this.c, 2.0) - Math.Pow(b, 2.0));
				answer = (float)Math.Sqrt(a);
			}
			answer = (float)Math.Round(answer, 2);
		}
	}

	public void e6Y()
	{
		int num = 9;
		int num2 = 2;
		VBMath.Randomize();
		checked
		{
			i = (int)Math.Floor(3f * VBMath.Rnd()) + 1;
			if (i == 1)
			{
				Zc0().set_Text("a");
			}
			else if (i == 2)
			{
				Zc0().set_Text("b");
			}
			else if (i == 3)
			{
				Zc0().set_Text("c");
			}
			if (i == 3)
			{
				a = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
				b = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
				g2H().set_Text(Conversions.ToString(a));
				o7L().set_Text(Conversions.ToString(b));
				g8W().set_Text("c");
			}
			else if (i == 2)
			{
				while (this.c <= a)
				{
					a = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					this.c = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					g2H().set_Text(Conversions.ToString(a));
					g8W().set_Text(Conversions.ToString(this.c));
					o7L().set_Text("b");
				}
			}
			else if (i == 1)
			{
				while (this.c <= b)
				{
					b = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					this.c = (int)Math.Floor((float)(num - num2 + 1) * VBMath.Rnd()) + num2;
					o7L().set_Text(Conversions.ToString(b));
					g8W().set_Text(Conversions.ToString(this.c));
					g2H().set_Text("a");
				}
			}
		}
	}

	internal static string j2C(string c8S)
	{
		Type type = (Type)Jp0.mDic[Jp0.T];
		return Conversions.ToString(type.InvokeMember(c8S, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	public void Sm8()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		string value = "";
		try
		{
			value = Rc6().get_Text();
			valid = true;
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
			if (num == answer)
			{
				J++;
				Interaction.MsgBox((object)("Correct answer, Score is: " + Conversions.ToString(J)), (MsgBoxStyle)0, (object)null);
				So0();
				e6Y();
				j5F();
				a = 0;
				b = 0;
				this.c = 0;
			}
			else
			{
				Interaction.MsgBox((object)("Incorrect, right answer is: " + Conversions.ToString(answer) + " Your Score is: " + Conversions.ToString(J)), (MsgBoxStyle)0, (object)null);
				So0();
				e6Y();
				j5F();
				a = 0;
				b = 0;
				this.c = 0;
			}
		}
	}

	private void z2F(object sender, EventArgs e)
	{
		a = 0;
		b = 0;
		this.c = 0;
		answer = 0f;
		So0();
		e6Y();
		j5F();
		Pk3().set_Text(Conversions.ToString(answer));
	}

	public void Pt4()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		string text = "Score";
		OleDbConnection a2G = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		a2G.Open();
		string p0J = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("UPDATE tblStudentScores SET " + text + " = " + Conversions.ToString(J) + " WHERE ID = "), NewLateBinding.LateGet(globalvariables, (Type)null, "StuID", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" AND TopicNo = 1"));
		y9E(p0J, ref a2G);
		a2G.Close();
		((Component)(object)a2G).Dispose();
	}

	private void Mr3(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (Operators.CompareString(Rc6().get_Text(), "", false) == 0)
			{
				Interaction.MsgBox((object)"Enter an answer", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				Sm8();
				if (n < 9)
				{
					Ng2().set_Text("");
					Rc6().set_Text("");
					n++;
					So0();
					Pk3().set_Text(Conversions.ToString(answer));
				}
				else
				{
					V = true;
				}
			}
			if (V)
			{
				Interaction.MsgBox((object)("You scored: " + Conversions.ToString(J)), (MsgBoxStyle)0, (object)null);
				Pt4();
				((Form)this).Close();
				NewLateBinding.LateCall(S, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void y9E(string p0J, ref OleDbConnection a2G)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		OleDbCommand val = new OleDbCommand(p0J, a2G);
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

	internal static void b3C(string j0B)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		j2C(j0B);
	}
}
