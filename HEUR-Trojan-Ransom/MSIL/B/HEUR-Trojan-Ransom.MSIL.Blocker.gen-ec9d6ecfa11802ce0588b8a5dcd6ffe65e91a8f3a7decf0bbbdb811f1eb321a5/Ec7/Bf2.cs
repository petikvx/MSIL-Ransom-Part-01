using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Eo8;
using Microsoft.VisualBasic.CompilerServices;
using Wi84;
using d4G;
using g7J;
using m5GN;

namespace Ec7;

[DesignerGenerated]
public class Bf2 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4728)]
	private struct Mc7
	{
	}

	private IContainer components;

	private Label _Label2;

	private TextBox _SRoll;

	private j6R Connection;

	private Ms8 Command;

	public DataTable dbDataSet;

	private static readonly object l;

	private static readonly Array y;

	private static readonly object g;

	internal static byte d/* Not supported: data(00) */;

	internal Label n;

	internal Button U;

	public Bf2()
	{
		((Form)this).add_Load((EventHandler)Ld3);
		dbDataSet = new DataTable();
		j9A();
	}

	protected override void s0J(bool b3K)
	{
		try
		{
			if (b3K && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(b3K);
		}
	}

	private void j9A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		No4(new Label());
		y3C(new Label());
		a3B(new TextBox());
		Xs7(new Button());
		((Control)this).SuspendLayout();
		Co1().set_AutoSize(true);
		((Control)Co1()).set_Location(new Point(70, 34));
		((Control)Co1()).set_Name("Label1");
		((Control)Co1()).set_Size(new Size(135, 13));
		((Control)Co1()).set_TabIndex(0);
		Co1().set_Text("For Editing Student Record");
		e4X().set_AutoSize(true);
		((Control)e4X()).set_Location(new Point(32, 96));
		((Control)e4X()).set_Name("Label2");
		((Control)e4X()).set_Size(new Size(65, 13));
		((Control)e4X()).set_TabIndex(1);
		e4X().set_Text("Roll Number");
		((Control)Nb4()).set_Location(new Point(103, 93));
		((Control)Nb4()).set_Name("SRoll");
		((Control)Nb4()).set_Size(new Size(142, 20));
		((Control)Nb4()).set_TabIndex(2);
		((Control)a5B()).set_Location(new Point(90, 143));
		((Control)a5B()).set_Name("Button1");
		((Control)a5B()).set_Size(new Size(75, 23));
		((Control)a5B()).set_TabIndex(3);
		((ButtonBase)a5B()).set_Text("Search");
		((ButtonBase)a5B()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 201));
		((Control)this).get_Controls().Add((Control)(object)a5B());
		((Control)this).get_Controls().Add((Control)(object)Nb4());
		((Control)this).get_Controls().Add((Control)(object)e4X());
		((Control)this).get_Controls().Add((Control)(object)Co1());
		((Control)this).set_Name("Form4");
		((Form)this).set_Text("Search Student Records");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Co1()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void No4(Label w1W)
	{
		Label val = (n = w1W);
	}

	[SpecialName]
	internal virtual Label e4X()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3C(Label By1)
	{
		_Label2 = By1;
	}

	[SpecialName]
	internal virtual TextBox Nb4()
	{
		return _SRoll;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a3B(TextBox w0A)
	{
		_SRoll = w0A;
	}

	[SpecialName]
	internal virtual Button a5B()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xs7(Button q2E)
	{
		EventHandler eventHandler = z9W;
		Button u = U;
		if (u != null)
		{
			((Control)u).remove_Click(eventHandler);
		}
		Button val = (U = q2E);
		u = U;
		if (u != null)
		{
			((Control)u).add_Click(eventHandler);
		}
	}

	private void z9W(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		if (Nb4().get_Text() == null)
		{
			MessageBox.Show("Enter Roll Number !");
			return;
		}
		Connection = new j6R();
		Connection.Jq8("server=localhost;userid=root;password=root;database=student;");
		Tw3 tw = new Tw3();
		BindingSource val = new BindingSource();
		try
		{
			Connection.f1N();
			_ = "Select * from student.student_info where Roll_Number like '" + Nb4().get_Text() + "';";
			Command = new Ms8();
			tw.Wj1(Command);
			tw.Gg4(dbDataSet);
			val.set_DataSource((object)dbDataSet);
			if (dbDataSet.Rows.Count == 1)
			{
				((Control)Lg27.Forms.Qo97()).Show();
				((Control)this).Hide();
				Connection.Dt5();
			}
			else
			{
				MessageBox.Show("No Matching Records Found !");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Connection.g5Z();
		}
	}

	internal static string e3B(string Mm2)
	{
		Type type = (Type)p1RD.mDic[p1RD.T];
		return Conversions.ToString(type.InvokeMember(Mm2, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	private void Ld3(object sender, EventArgs e)
	{
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
	}

	static Bf2()
	{
		y = new char[2364];
		char[] array = new char[8];
		array[0] = '⒓';
		array[7] = 'ᒻ';
		array[3] = 'ὃ';
		array[5] = 'ᄙ';
		array[6] = '\u0bc2';
		array[2] = 'ࡄ';
		array[4] = '㠈';
		array[1] = 'ደ';
		g = new string[131];
		l = array;
	}
}
