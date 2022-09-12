using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using Je8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using k9F;

namespace d3BQ;

[DesignerGenerated]
public class Gy6b : Window, IComponentConnector
{
	private TextBox _txtname;

	private TextBox _txtdocname;

	private ComboBox _cbowardno;

	private TextBox _txtwardname;

	private Button _buttonUpdate;

	private Button _buttonSearch;

	private Button _buttonDelete;

	private Button _btnmovenext;

	private Button _btnmovelast;

	private Button _btnprevious;

	private Button _btnfirst;

	private Label _lblstring;

	private TextBox _txtnurseName;

	private TextBox _txtnurseID;

	private ComboBox _cbodiagnosis;

	private TextBox _txtadmissioNo;

	internal int N;

	internal DataTable p;

	internal TextBox V;

	internal DatePicker D;

	internal Button f;

	internal Button c;

	internal Button q;

	internal TextBox M;

	internal TextBox o;

	internal TextBox X;

	internal bool j;

	public Gy6b()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(e0G7));
		N = 0;
		DataTable dataTable = (p = new DataTable());
		Ye8p();
	}

	private void f3H2(object sender, MouseEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = Conversions.ToInteger(Jd78().get_Text());
			string text = Conversions.ToString(((ContentControl)f8S7()).get_Content());
			SqlConnection val = new SqlConnection(text);
			SqlCommand val2 = new SqlCommand();
			new SqlCommand();
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Patients_Diagnosis where Diagnosis_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			try
			{
				SqlDataReader val4 = val3;
				val4.Read();
				a1L0().set_Text(Conversions.ToString(val4.GetValue(2)));
				k3J1().set_Text(Conversions.ToString(val4.GetValue(3)));
				m1LS().set_Text(Conversions.ToString(val4.GetValue(4)));
				y3E6().set_Text(Conversions.ToString(val4.GetValue(5)));
				Sx6p().set_Text(Conversions.ToString(val4.GetValue(9)));
				k8H4().set_Text(Conversions.ToString(val4.GetValue(10)));
				val4 = null;
				val3.Close();
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
	}

	private void e0G7(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)f8S7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		SqlCommand val3 = new SqlCommand();
		SqlDataReader val4;
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Patients_Diagnosis");
			val4 = val2.ExecuteReader();
			SqlDataReader val5 = val4;
			while (val5.Read())
			{
				((ItemsControl)Jd78()).get_Items().Add(RuntimeHelpers.GetObjectValue(val5.GetValue(0)));
			}
			val5 = null;
			val4.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		val3.set_Connection(val);
		val3.set_CommandText("Select * from Wards");
		val4 = val3.ExecuteReader();
		try
		{
			SqlDataReader val6 = val4;
			while (val6.Read())
			{
				((ItemsControl)p0FG()).get_Items().Add(RuntimeHelpers.GetObjectValue(val6.GetValue(0)));
			}
			val6 = null;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		val4.Close();
		int num = (N = p.Rows.Count);
		i7LR(N);
	}

	private void Cm4t(object sender, MouseEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = Conversions.ToInteger(p0FG().get_Text());
			string text = Conversions.ToString(((ContentControl)f8S7()).get_Content());
			SqlConnection val = new SqlConnection(text);
			SqlCommand val2 = new SqlCommand();
			new SqlCommand();
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Wards where Ward_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			try
			{
				SqlDataReader val4 = val3;
				val4.Read();
				Np7q().set_Text(Conversions.ToString(val4.GetValue(2)));
				val4 = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void i1W0(object sender, RoutedEventArgs e)
	{
		Pm97().set_Text("");
		Jd78().set_Text("");
		a1L0().set_Text("");
		k3J1().set_Text("");
		m1LS().set_Text("");
		y3E6().set_Text("");
		Sx6p().set_Text("");
		k8H4().set_Text("");
		p0FG().set_Text("");
		Np7q().set_Text("");
		o2M4().set_Text("");
		Cs1a().set_Text("");
		int num = (N = checked(p.Rows.Count - 1));
		y0MZ(N);
	}

	internal static bool Fr51(string Be5g)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Be5g);
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

	public void y0MZ(int p3H6)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)f8S7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Ward_Admission");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(p);
		DataTable dataTable = p;
		try
		{
			int num = Conversions.ToInteger(dataTable.Rows[p3H6][0]);
			if (num == 0)
			{
				Pm97().set_Text(Conversions.ToString(0));
			}
			else
			{
				int num2 = checked(1 + num);
				Pm97().set_Text(Conversions.ToString(num2));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	private void p4B0(object sender, RoutedEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)f8S7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("insert into Ward_Admission(Ward_admission_No,Diagnosis_No,Patients_ID,Patients_name,Doc_ID,Doc_Name,Nurse_ID,Nurse_Name,Ward_No,Ward_Name,Bed_No,admission_date,Hospital_Bill) Values\n        ('" + Pm97().get_Text() + "','" + Jd78().get_Text() + "','" + a1L0().get_Text() + "','" + k3J1().get_Text() + "','" + m1LS().get_Text() + "','" + y3E6().get_Text() + "',\n        '" + Sx6p().get_Text() + "','" + k8H4().get_Text() + "','" + p0FG().get_Text() + "','" + Np7q().get_Text() + "',\n        '" + o2M4().get_Text() + "','" + Cs1a().get_Text() + "','" + c3CJ().get_Text() + "')");
			val2.ExecuteNonQuery();
			MessageBox.Show("Succesfully Admitted to ward", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int num = (N = checked(p.Rows.Count - 1));
		i7LR(N);
	}

	private void x6GP(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Ward_admission_No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)f8S7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Ward_Admission where Ward_admission_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			try
			{
				SqlDataReader val4 = val3;
				val4.Read();
				Pm97().set_Text(Conversions.ToString(val4.GetValue(0)));
				Jd78().set_Text(Conversions.ToString(val4.GetValue(1)));
				a1L0().set_Text(Conversions.ToString(val4.GetValue(2)));
				k3J1().set_Text(Conversions.ToString(val4.GetValue(3)));
				m1LS().set_Text(Conversions.ToString(val4.GetValue(4)));
				y3E6().set_Text(Conversions.ToString(val4.GetValue(5)));
				Sx6p().set_Text(Conversions.ToString(val4.GetValue(6)));
				k8H4().set_Text(Conversions.ToString(val4.GetValue(7)));
				p0FG().set_Text(Conversions.ToString(val4.GetValue(8)));
				Np7q().set_Text(Conversions.ToString(val4.GetValue(9)));
				o2M4().set_Text(Conversions.ToString(val4.GetValue(10)));
				Cs1a().set_Text(Conversions.ToString(val4.GetValue(11)));
				c3CJ().set_Text(Conversions.ToString(val4.GetValue(12)));
				val4 = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Eo1t(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)f8S7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		try
		{
			val2.set_CommandText("update Ward_Admission set Ward_admission_No='" + Pm97().get_Text() + "',Diagnosis_No='" + Jd78().get_Text() + "',Patients_ID='" + a1L0().get_Text() + "',Patients_name='" + k3J1().get_Text() + "',Doc_ID='" + m1LS().get_Text() + "'\n\t\t\t,Doc_Name='" + y3E6().get_Text() + "',Nurse_ID='" + Sx6p().get_Text() + "',Nurse_Name='" + k8H4().get_Text() + "',Ward_No='" + p0FG().get_Text() + "'\n\t\t\t,Ward_Name='" + Np7q().get_Text() + "',Bed_No='" + o2M4().get_Text() + "',admission_date='" + Cs1a().get_Text() + "',Hospital_Bill='" + c3CJ().get_Text() + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show(" Succesful Updated Ward Admission", "Kapenguria Patients MIS", (MessageBoxButton)1);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		val.Close();
	}

	private void Xm28(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Invalid comparison between Unknown and I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Ward Admission No to Delete", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)f8S7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		try
		{
			val2.set_CommandText("Select * from Ward_Admission where Ward_admission_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			try
			{
				SqlDataReader val4 = val3;
				val4.Read();
				Pm97().set_Text(Conversions.ToString(val4.GetValue(0)));
				Jd78().set_Text(Conversions.ToString(val4.GetValue(1)));
				a1L0().set_Text(Conversions.ToString(val4.GetValue(2)));
				k3J1().set_Text(Conversions.ToString(val4.GetValue(3)));
				m1LS().set_Text(Conversions.ToString(val4.GetValue(4)));
				y3E6().set_Text(Conversions.ToString(val4.GetValue(5)));
				Sx6p().set_Text(Conversions.ToString(val4.GetValue(6)));
				k8H4().set_Text(Conversions.ToString(val4.GetValue(7)));
				p0FG().set_Text(Conversions.ToString(val4.GetValue(8)));
				Np7q().set_Text(Conversions.ToString(val4.GetValue(9)));
				o2M4().set_Text(Conversions.ToString(val4.GetValue(10)));
				Cs1a().set_Text(Conversions.ToString(val4.GetValue(11)));
				c3CJ().set_Text(Conversions.ToString(val4.GetValue(12)));
				val4 = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		MessageBoxResult val5 = MessageBox.Show("Please confirm you delete this record", "Freeing Up Some Space", (MessageBoxButton)4);
		if ((int)val5 != 6)
		{
			if ((int)val5 == 7)
			{
			}
		}
		else
		{
			val2.set_CommandText("Delete from Ward_Admission where Ward_admission_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show("its been a pleasure Freeing up some space, Delete Succesfull");
			val.Close();
		}
	}

	internal static bool q4N5(int z5N1)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(z5N1 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				z5N1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				z5N1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				z5N1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hjk", false) == 0 && Operators.CompareString(text, "l", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) == 0)
		{
			return true;
		}
		return false;
	}

	public void i7LR(int z4E2)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)f8S7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Ward_Admission");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(p);
		DataTable dataTable = p;
		try
		{
			Pm97().set_Text(dataTable.Rows[z4E2][0].ToString());
			Jd78().set_Text(dataTable.Rows[z4E2][1].ToString());
			a1L0().set_Text(dataTable.Rows[z4E2][2].ToString());
			k3J1().set_Text(dataTable.Rows[z4E2][3].ToString());
			m1LS().set_Text(dataTable.Rows[z4E2][4].ToString());
			y3E6().set_Text(dataTable.Rows[z4E2][5].ToString());
			Sx6p().set_Text(dataTable.Rows[z4E2][6].ToString());
			k8H4().set_Text(dataTable.Rows[z4E2][7].ToString());
			p0FG().set_Text(dataTable.Rows[z4E2][8].ToString());
			Np7q().set_Text(dataTable.Rows[z4E2][9].ToString());
			o2M4().set_Text(dataTable.Rows[z4E2][10].ToString());
			Cs1a().set_Text(dataTable.Rows[z4E2][11].ToString());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	private void s5XH(object sender, RoutedEventArgs e)
	{
		checked
		{
			N++;
			i7LR(N);
		}
	}

	private void Ry1e(object sender, RoutedEventArgs e)
	{
		checked
		{
			N--;
			i7LR(N);
		}
	}

	private void x2LS(object sender, RoutedEventArgs e)
	{
		N = 0;
		i7LR(N);
	}

	private void z3Z9(object sender, RoutedEventArgs e)
	{
		int num = (N = checked(p.Rows.Count - 1));
		i7LR(N);
	}

	private void Pr2k(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		((Window)nq).set_Title("Ward Admission Report");
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_WardAdmission.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
	}

	internal static byte[] g4TJ(int d6FT, int d1P3)
	{
		if (d6FT <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[d1P3 + 1];
			for (int i = 0; i <= d1P3; i++)
			{
				int num = d6FT * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Nq6.Pn5(array, d1P3);
		}
	}

	[SpecialName]
	internal virtual TextBox k3J1()
	{
		return _txtname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rz63(TextBox j9W8)
	{
		_txtname = j9W8;
	}

	[SpecialName]
	internal virtual TextBox y3E6()
	{
		return _txtdocname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5D7(TextBox Eo6a)
	{
		_txtdocname = Eo6a;
	}

	[SpecialName]
	internal virtual ComboBox p0FG()
	{
		return _cbowardno;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z2SB(ComboBox b1EM)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Cm4t);
		ComboBox cbowardno = _cbowardno;
		if (cbowardno != null)
		{
			((UIElement)cbowardno).remove_MouseLeave(val);
		}
		_cbowardno = b1EM;
		cbowardno = _cbowardno;
		if (cbowardno != null)
		{
			((UIElement)cbowardno).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual TextBox Np7q()
	{
		return _txtwardname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cd52(TextBox Wr8e)
	{
		_txtwardname = Wr8e;
	}

	[SpecialName]
	internal virtual TextBox o2M4()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4TN(TextBox s7F1)
	{
		TextBox val = (V = s7F1);
	}

	[SpecialName]
	internal virtual DatePicker Cs1a()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3GZ(DatePicker w9JF)
	{
		DatePicker val = (D = w9JF);
	}

	[SpecialName]
	internal virtual Button b5TP()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void As8a(Button Ge82)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(i1W0);
		Button val2 = f;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (f = Ge82);
		val2 = f;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button p8R0()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7J2(Button Ea1z)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(p4B0);
		Button val2 = c;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (c = Ea1z);
		val2 = c;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button g3G4()
	{
		return _buttonUpdate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jt1p(Button j4X5)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Eo1t);
		Button buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).remove_Click(val);
		}
		_buttonUpdate = j4X5;
		buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Zz4q()
	{
		return _buttonSearch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2JM(Button b9GS)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(x6GP);
		Button buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).remove_Click(val);
		}
		_buttonSearch = b9GS;
		buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button p0L7()
	{
		return _buttonDelete;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ag16(Button p6D5)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Xm28);
		Button buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).remove_Click(val);
		}
		_buttonDelete = p6D5;
		buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Qz42()
	{
		return _btnmovenext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9Z3(Button Tn40)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(s5XH);
		Button btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).remove_Click(val);
		}
		_btnmovenext = Tn40;
		btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button e2GH()
	{
		return _btnmovelast;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4YX(Button o4Y1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(z3Z9);
		Button btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).remove_Click(val);
		}
		_btnmovelast = o4Y1;
		btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Ys0y()
	{
		return _btnprevious;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6C7(Button Yd0k)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Ry1e);
		Button btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).remove_Click(val);
		}
		_btnprevious = Yd0k;
		btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Af02()
	{
		return _btnfirst;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bf2d(Button Nq73)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(x2LS);
		Button btnfirst = _btnfirst;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).remove_Click(val);
		}
		_btnfirst = Nq73;
		btnfirst = _btnfirst;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button a4G0()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5ES(Button Nt42)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Pr2k);
		Button val2 = q;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (q = Nt42);
		val2 = q;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Label f8S7()
	{
		return _lblstring;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wr15(Label r4P9)
	{
		_lblstring = r4P9;
	}

	[SpecialName]
	internal virtual TextBox m1LS()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Po30(TextBox x4D9)
	{
		TextBox val = (M = x4D9);
	}

	[SpecialName]
	internal virtual TextBox a1L0()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4H7(TextBox a4MD)
	{
		TextBox val = (o = a4MD);
	}

	[SpecialName]
	internal virtual TextBox k8H4()
	{
		return _txtnurseName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xb6d(TextBox z0T9)
	{
		_txtnurseName = z0T9;
	}

	[SpecialName]
	internal virtual TextBox Sx6p()
	{
		return _txtnurseID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void An76(TextBox Yr70)
	{
		_txtnurseID = Yr70;
	}

	[SpecialName]
	internal virtual ComboBox Jd78()
	{
		return _cbodiagnosis;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dk7y(ComboBox m1K2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(f3H2);
		ComboBox cbodiagnosis = _cbodiagnosis;
		if (cbodiagnosis != null)
		{
			((UIElement)cbodiagnosis).remove_MouseLeave(val);
		}
		_cbodiagnosis = m1K2;
		cbodiagnosis = _cbodiagnosis;
		if (cbodiagnosis != null)
		{
			((UIElement)cbodiagnosis).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual TextBox Pm97()
	{
		return _txtadmissioNo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9HD(TextBox Cb04)
	{
		_txtadmissioNo = Cb04;
	}

	[SpecialName]
	internal virtual TextBox c3CJ()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2D1(TextBox Xp0z)
	{
		TextBox val = (X = Xp0z);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Ye8p()
	{
		if (!j)
		{
			j = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/wardadmission.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void f6Q3(int t2N8, object En06)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		switch (t2N8)
		{
		case 1:
			Rz63((TextBox)En06);
			break;
		case 2:
			c5D7((TextBox)En06);
			break;
		case 3:
			z2SB((ComboBox)En06);
			break;
		case 4:
			Cd52((TextBox)En06);
			break;
		case 5:
			d4TN((TextBox)En06);
			break;
		case 6:
			f3GZ((DatePicker)En06);
			break;
		case 7:
			As8a((Button)En06);
			break;
		case 8:
			e7J2((Button)En06);
			break;
		case 9:
			Jt1p((Button)En06);
			break;
		case 10:
			m2JM((Button)En06);
			break;
		case 11:
			Ag16((Button)En06);
			break;
		case 12:
			j9Z3((Button)En06);
			break;
		case 13:
			w4YX((Button)En06);
			break;
		case 14:
			t6C7((Button)En06);
			break;
		case 15:
			Bf2d((Button)En06);
			break;
		case 16:
			d5ES((Button)En06);
			break;
		case 17:
			Wr15((Label)En06);
			break;
		case 18:
			Po30((TextBox)En06);
			break;
		case 19:
			s4H7((TextBox)En06);
			break;
		case 20:
			Xb6d((TextBox)En06);
			break;
		case 21:
			An76((TextBox)En06);
			break;
		case 22:
			Dk7y((ComboBox)En06);
			break;
		case 23:
			d9HD((TextBox)En06);
			break;
		case 24:
			j2D1((TextBox)En06);
			break;
		default:
			j = true;
			break;
		}
	}
}
