using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eo8;
using Microsoft.VisualBasic.CompilerServices;
using Mw03;
using Wi84;
using d4G;
using g7J;
using m5GN;
using x5X;

namespace Lb5n;

[DesignerGenerated]
public class q9QN : Form
{
	private Label _Label1;

	private TextBox _TextBox1;

	private j6R Connection;

	public DataTable dbDataSet;

	internal IContainer c;

	internal Label s;

	internal Button o;

	internal Ms8 l;

	public q9QN()
	{
		((Form)this).add_Load((EventHandler)r7Q4);
		dbDataSet = new DataTable();
		k2C5();
	}

	protected override void t1L9(bool Wy7j)
	{
		try
		{
			if (Wy7j && c != null)
			{
				c.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wy7j);
		}
	}

	private void k2C5()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		r9W7(new Label());
		Pr32(new Label());
		Hz89(new TextBox());
		Wo6i(new Button());
		((Control)this).SuspendLayout();
		Pe2i().set_AutoSize(true);
		((Control)Pe2i()).set_Location(new Point(82, 26));
		((Control)Pe2i()).set_Name("Label1");
		((Control)Pe2i()).set_Size(new Size(93, 13));
		((Control)Pe2i()).set_TabIndex(0);
		Pe2i().set_Text("Enter Student Roll");
		p4WR().set_AutoSize(true);
		((Control)p4WR()).set_Location(new Point(12, 73));
		((Control)p4WR()).set_Name("Label2");
		((Control)p4WR()).set_Size(new Size(65, 13));
		((Control)p4WR()).set_TabIndex(1);
		p4WR().set_Text("Roll Number");
		((Control)o4K7()).set_Location(new Point(100, 70));
		((Control)o4K7()).set_Name("TextBox1");
		((Control)o4K7()).set_Size(new Size(149, 20));
		((Control)o4K7()).set_TabIndex(2);
		((Control)Dn5g()).set_Location(new Point(85, 120));
		((Control)Dn5g()).set_Name("Button1");
		((Control)Dn5g()).set_Size(new Size(75, 23));
		((Control)Dn5g()).set_TabIndex(3);
		((ButtonBase)Dn5g()).set_Text("Search");
		((ButtonBase)Dn5g()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(277, 195));
		((Control)this).get_Controls().Add((Control)(object)Dn5g());
		((Control)this).get_Controls().Add((Control)(object)o4K7());
		((Control)this).get_Controls().Add((Control)(object)p4WR());
		((Control)this).get_Controls().Add((Control)(object)Pe2i());
		((Control)this).set_Name("DisplayRecord");
		((Form)this).set_Text("DisplayRecord");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Pe2i()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9W7(Label p2R1)
	{
		_Label1 = p2R1;
	}

	[SpecialName]
	internal virtual Label p4WR()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pr32(Label n3YP)
	{
		Label val = (s = n3YP);
	}

	[SpecialName]
	internal virtual TextBox o4K7()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hz89(TextBox Hk9c)
	{
		_TextBox1 = Hk9c;
	}

	[SpecialName]
	internal virtual Button Dn5g()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wo6i(Button f1QD)
	{
		EventHandler eventHandler = Zp69;
		Button val = o;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (o = f1QD);
		val = o;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private void r7Q4(object sender, EventArgs e)
	{
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
	}

	internal static byte[] m7J0(int Pd0k)
	{
		return i2RH.Qw4q(Pd0k, checked(Pd0k + 1 - 34));
	}

	private void Zp69(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		Connection = new j6R();
		Connection.Jq8("server=localhost;userid=root;password=root;database=student;");
		Tw3 tw = new Tw3();
		BindingSource val = new BindingSource();
		try
		{
			_ = "Select * from student.student_info where Roll_Number like '" + o4K7().get_Text() + "';";
			Ms8 ms = (l = new Ms8());
			dbDataSet.Clear();
			tw.Wj1(l);
			tw.Gg4(dbDataSet);
			val.set_DataSource((object)dbDataSet);
			if (dbDataSet.Rows.Count > 0)
			{
				((Control)Lg27.Forms.n1X9()).Show();
				((Control)this).Hide();
				Connection.Dt5();
			}
			else
			{
				MessageBox.Show("No Matching Records Found !");
			}
			o4K7().set_Text((string)null);
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

	internal static byte Dy4c(byte q3FX, byte[] c8EJ, int As98, int f5LE)
	{
		q3FX = (byte)(q3FX ^ checked((byte)(c8EJ[unchecked(f5LE % c8EJ.Length)] ^ ((f5LE + unchecked(As98 % c8EJ.Length)) & As98))));
		return q3FX;
	}

	internal static void Wm54()
	{
		Ts5.d9D(p1RD.mDic[p1RD.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}
}
