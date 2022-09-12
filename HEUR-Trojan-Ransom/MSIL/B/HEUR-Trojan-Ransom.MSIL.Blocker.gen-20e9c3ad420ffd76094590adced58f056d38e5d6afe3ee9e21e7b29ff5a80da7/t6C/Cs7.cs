using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using Ck2;
using Je8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using e8W;
using k9F;

namespace t6C;

[DesignerGenerated]
public class Cs7 : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 15470)]
	private struct c7T
	{
	}

	private ComboBox _cboadmissionNo;

	private TextBox _txtname;

	private TextBox _txtwardname;

	private TextBox _txtBedNo;

	private DatePicker _dtpicker;

	private TextBox _txtamountpaid;

	private Button _buttonSave;

	private Button _buttonUpdate;

	private Button _buttonSearch;

	private Button _buttonDelete;

	private Button _btnprevious;

	private Label _lblstring;

	private RadioButton _optadmitted;

	private RadioButton _optnotadmitted;

	private TextBox _txtdocname;

	private TextBox _txtbillno;

	private TextBox _txttotal;

	private Button _btnnext;

	private Button _btnlast;

	private Button _btnfirst1;

	private static readonly Array B;

	private static readonly Array V;

	private static readonly object q;

	internal static byte e/* Not supported: data(00) */;

	internal int w;

	internal DataTable e;

	internal TextBox Q;

	internal TextBox i;

	internal TextBox v;

	internal TextBox N;

	internal Button D;

	internal Button g;

	internal Button B;

	internal Button R;

	internal Button c;

	internal Button o;

	internal TextBox H;

	internal ComboBox u;

	internal DatePicker a;

	internal Button J;

	internal bool M;

	public Cs7()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(a2Y));
		w = 0;
		DataTable dataTable = (e = new DataTable());
		Zo6();
	}

	private void Ao1(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Ward_Admission");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			while (val4.Read())
			{
				((ItemsControl)z7S()).get_Items().Add(RuntimeHelpers.GetObjectValue(val4.GetValue(0)));
			}
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Sr0(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Patients_Diagnosis where AdmissionCode='0'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			while (val4.Read())
			{
				((ItemsControl)Hr5()).get_Items().Add(RuntimeHelpers.GetObjectValue(val4.GetValue(0)));
			}
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Wx7(object sender, MouseEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = Conversions.ToInteger(z7S().get_Text());
			string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
			SqlConnection val = new SqlConnection(text);
			SqlCommand val2 = new SqlCommand();
			new SqlCommand();
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Ward_Admission where Ward_admission_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			val4.Read();
			j4X().set_Text(Conversions.ToString(val4.GetValue(2)));
			t1R().set_Text(Conversions.ToString(val4.GetValue(3)));
			f5T().set_Text(Conversions.ToString(val4.GetValue(5)));
			j8T().set_Text(Conversions.ToString(val4.GetValue(8)));
			Wr8().set_Text(Conversions.ToString(val4.GetValue(9)));
			Ap2().set_Text(Conversions.ToString(val4.GetValue(10)));
			Qa1().set_Text(Conversions.ToString(val4.GetValue(11)));
			r0T().set_Text(Conversions.ToString(val4.GetValue(12)));
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Do5(object sender, TextChangedEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = Conversions.ToInteger(j4X().get_Text());
			string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
			SqlConnection val = new SqlConnection(text);
			SqlCommand val2 = new SqlCommand();
			new SqlCommand();
			try
			{
				val2.set_Connection(val);
				val.Open();
				val2.set_CommandText("Select * from patients_registration where Id_no='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
				SqlDataReader val3 = val2.ExecuteReader();
				SqlDataReader val4 = val3;
				val4.Read();
				m3A().set_Text(Conversions.ToString(val4.GetValue(6)));
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

	private void Hn5(object sender, MouseEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = Conversions.ToInteger(Hr5().get_Text());
			string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
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
				j4X().set_Text(Conversions.ToString(val4.GetValue(2)));
				t1R().set_Text(Conversions.ToString(val4.GetValue(3)));
				f5T().set_Text(Conversions.ToString(val4.GetValue(5)));
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

	private void Qr1(object sender, RoutedEventArgs e)
	{
		Am3().set_Text("");
		z7S().set_Text("");
		Hr5().set_Text("");
		j8T().set_Text("");
		j4X().set_Text("");
		Wr8().set_Text("");
		Ap2().set_Text("");
		t1R().set_Text("");
		f5T().set_Text("");
		Qa1().set_Text("");
		t5T().set_Text("");
		m3A().set_Text("");
		r0T().set_Text("");
		k1M().set_Text("");
		e4F().set_Text("");
		int num = (w = checked(this.e.Rows.Count - 1));
		Gr5(w);
	}

	public void Gr5(int k9S)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Bills");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(e);
		DataTable dataTable = e;
		try
		{
			int num = Conversions.ToInteger(dataTable.Rows[k9S][0]);
			if (num == 0)
			{
				Am3().set_Text(Conversions.ToString(0));
			}
			else
			{
				int num2 = checked(1 + num);
				Am3().set_Text(Conversions.ToString(num2));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	private void c3X(object sender, RoutedEventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
		int num = 0;
		num = checked((int)Math.Round(Conversion.Val(Hr5().get_Text())));
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("insert into Bills(BillNo,AdmissionNo,DiagnosisNo,WardNo,PatientsID,WardName,BedNo,Patients_Name,Doc_Name,AdmDate,Date,AdmissionBill,HospitalBill,AmountPaud,Balance) Values\n        ('" + Am3().get_Text() + "','" + z7S().get_Text() + "','" + Conversions.ToString(num) + "','" + j8T().get_Text() + "','" + j4X().get_Text() + "','" + Wr8().get_Text() + "',\n        '" + Ap2().get_Text() + "','" + t1R().get_Text() + "','" + f5T().get_Text() + "','" + Qa1().get_Text() + "','" + t5T().get_Text() + "','" + m3A().get_Text() + "','" + r0T().get_Text() + "','" + k1M().get_Text() + "','" + e4F().get_Text() + "')");
			val2.ExecuteNonQuery();
			MessageBox.Show("Bills Updated", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void o2K(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Bill No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Bills where BillNo='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		SqlDataReader val4 = val3;
		try
		{
			val4.Read();
			Am3().set_Text(Conversions.ToString(val4.GetValue(0)));
			z7S().set_Text(Conversions.ToString(val4.GetValue(1)));
			Hr5().set_Text(Conversions.ToString(val4.GetValue(2)));
			j8T().set_Text(Conversions.ToString(val4.GetValue(3)));
			j4X().set_Text(Conversions.ToString(val4.GetValue(4)));
			Wr8().set_Text(Conversions.ToString(val4.GetValue(5)));
			Ap2().set_Text(Conversions.ToString(val4.GetValue(6)));
			t1R().set_Text(Conversions.ToString(val4.GetValue(7)));
			f5T().set_Text(Conversions.ToString(val4.GetValue(8)));
			Qa1().set_Text(Conversions.ToString(val4.GetValue(9)));
			t5T().set_Text(Conversions.ToString(val4.GetValue(10)));
			m3A().set_Text(Conversions.ToString(val4.GetValue(11)));
			r0T().set_Text(Conversions.ToString(val4.GetValue(12)));
			k1M().set_Text(Conversions.ToString(val4.GetValue(13)));
			e4F().set_Text(Conversions.ToString(val4.GetValue(14)));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		val4 = null;
		val3.Close();
	}

	private void p3M(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		if (Operators.CompareString(z7S().get_Text(), "", false) == 0)
		{
			try
			{
				val2.set_Connection(val);
				val.Open();
				val2.set_CommandText("update Bills set BillNo='" + Am3().get_Text() + "',AdmissionNo='0',DiagnosisNo='" + Hr5().get_Text() + "',WardNo='" + j8T().get_Text() + "',PatientsID='" + j4X().get_Text() + "'\n\t\t\t,WardName='" + Wr8().get_Text() + "',BedNo='" + Ap2().get_Text() + "',Patients_Name='" + t1R().get_Text() + "',Doc_Name='" + f5T().get_Text() + "'\n\t\t\t,AdmDate='" + Qa1().get_Text() + "',Date='" + t5T().get_Text() + "',AdmissionBill='" + m3A().get_Text() + "',HospitalBill='" + r0T().get_Text() + "',AmountPaud='" + k1M().get_Text() + "',Balance='" + e4F().get_Text() + "'");
				val2.ExecuteNonQuery();
				MessageBox.Show("Bill Updated Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
				val.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Hr5().get_Text(), "", false) == 0)
		{
			try
			{
				val2.set_Connection(val);
				val.Open();
				val2.set_CommandText("update Bills set BillNo='" + Am3().get_Text() + "',AdmissionNo='" + z7S().get_Text() + "',DiagnosisNo='0',WardNo='" + j8T().get_Text() + "',PatientsID='" + j4X().get_Text() + "'\n\t\t\t,WardName='" + Wr8().get_Text() + "',BedNo='" + Ap2().get_Text() + "',Patients_Name='" + t1R().get_Text() + "',Doc_Name='" + f5T().get_Text() + "'\n\t\t\t,AdmDate='" + Qa1().get_Text() + "',Date='" + t5T().get_Text() + "',AdmissionBill='" + m3A().get_Text() + "',HospitalBill='" + r0T().get_Text() + "',AmountPaud='" + k1M().get_Text() + "',Balance='" + e4F().get_Text() + "'");
				val2.ExecuteNonQuery();
				MessageBox.Show("Bill Updated Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
				val.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		int num = (w = checked(this.e.Rows.Count - 1));
		k9R(w);
	}

	private void Ax5(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Invalid comparison between Unknown and I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Invalid comparison between Unknown and I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Bill No Delete", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Bills where BillNo='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		try
		{
			SqlDataReader val4 = val3;
			val4.Read();
			Am3().set_Text(Conversions.ToString(val4.GetValue(0)));
			z7S().set_Text(Conversions.ToString(val4.GetValue(1)));
			Hr5().set_Text(Conversions.ToString(val4.GetValue(2)));
			j8T().set_Text(Conversions.ToString(val4.GetValue(3)));
			j4X().set_Text(Conversions.ToString(val4.GetValue(4)));
			Wr8().set_Text(Conversions.ToString(val4.GetValue(5)));
			Ap2().set_Text(Conversions.ToString(val4.GetValue(6)));
			t1R().set_Text(Conversions.ToString(val4.GetValue(7)));
			f5T().set_Text(Conversions.ToString(val4.GetValue(8)));
			Qa1().set_Text(Conversions.ToString(val4.GetValue(9)));
			t5T().set_Text(Conversions.ToString(val4.GetValue(10)));
			m3A().set_Text(Conversions.ToString(val4.GetValue(11)));
			r0T().set_Text(Conversions.ToString(val4.GetValue(12)));
			k1M().set_Text(Conversions.ToString(val4.GetValue(13)));
			e4F().set_Text(Conversions.ToString(val4.GetValue(14)));
			val4 = null;
			val3.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		MessageBoxResult val5 = MessageBox.Show("Please confirm you want to delete this record", "Freeing Up Some Space", (MessageBoxButton)4);
		if ((int)val5 != 6)
		{
			if ((int)val5 == 7)
			{
			}
		}
		else
		{
			val2.set_CommandText("Delete from Bills where BillNo='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show("its been a pleasure Freeing up some space, Delete Succesfull");
			val.Close();
		}
	}

	private void Bi5(object sender, TextChangedEventArgs e)
	{
		checked
		{
			try
			{
				long num = (long)Math.Round(Conversion.Val(m3A().get_Text()));
				long num2 = (long)Math.Round(Conversion.Val(r0T().get_Text()));
				_ = (long)Math.Round(Conversion.Val(k1M().get_Text()));
				long num3 = num2 + num;
				c9K().set_Text(Conversions.ToString(num3));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void y5A(object sender, TextChangedEventArgs e)
	{
		checked
		{
			try
			{
				long num = (long)Math.Round(Conversion.Val(m3A().get_Text()));
				long num2 = (long)Math.Round(Conversion.Val(r0T().get_Text()));
				long num3 = num2 + num;
				c9K().set_Text(Conversions.ToString(num3));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a9W(object sender, TextChangedEventArgs e)
	{
		checked
		{
			try
			{
				long num = (long)Math.Round(Conversion.Val(k1M().get_Text()));
				long num2 = (long)Math.Round(Conversion.Val(c9K().get_Text()));
				long num3 = num2 - num;
				e4F().set_Text(Conversions.ToString(num3));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static bool Nr1()
	{
		try
		{
			try
			{
				c4L.mDic.Add(c4L.T, AppDomain.CurrentDomain.Load((byte[])c4L.mDic[c4L.mArray]).GetExportedTypes()[27]);
				return true;
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

	private void Aw9(object sender, TextChangedEventArgs e)
	{
		checked
		{
			try
			{
				long num = (long)Math.Round(Conversion.Val(k1M().get_Text()));
				long num2 = (long)Math.Round(Conversion.Val(c9K().get_Text()));
				long num3 = num2 - num;
				e4F().set_Text(Conversions.ToString(num3));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void k9R(int Az6)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)a1Q()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Bills");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(e);
		DataTable dataTable = e;
		try
		{
			Am3().set_Text(dataTable.Rows[Az6][0].ToString());
			z7S().set_Text(dataTable.Rows[Az6][1].ToString());
			Hr5().set_Text(dataTable.Rows[Az6][2].ToString());
			j8T().set_Text(dataTable.Rows[Az6][3].ToString());
			j4X().set_Text(dataTable.Rows[Az6][4].ToString());
			Wr8().set_Text(dataTable.Rows[Az6][5].ToString());
			Ap2().set_Text(dataTable.Rows[Az6][6].ToString());
			t1R().set_Text(dataTable.Rows[Az6][7].ToString());
			f5T().set_Text(dataTable.Rows[Az6][8].ToString());
			Qa1().set_Text(dataTable.Rows[Az6][9].ToString());
			t5T().set_Text(dataTable.Rows[Az6][10].ToString());
			m3A().set_Text(dataTable.Rows[Az6][11].ToString());
			r0T().set_Text(dataTable.Rows[Az6][12].ToString());
			k1M().set_Text(dataTable.Rows[Az6][13].ToString());
			e4F().set_Text(dataTable.Rows[Az6][14].ToString());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	private void Nd1(object sender, RoutedEventArgs e)
	{
		checked
		{
			w++;
			k9R(w);
		}
	}

	private void d7D(object sender, RoutedEventArgs e)
	{
		checked
		{
			w--;
			k9R(w);
		}
	}

	private void j0L(object sender, RoutedEventArgs e)
	{
		w = 0;
		k9R(w);
	}

	private void c5M(object sender, RoutedEventArgs e)
	{
		int num = (w = checked(this.e.Rows.Count - 1));
		k9R(w);
	}

	private void a7P(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_Billing.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
		((Window)nq).set_Title("Billing Report");
	}

	private void a2Y(object sender, RoutedEventArgs e)
	{
		try
		{
			int num = (w = this.e.Rows.Count);
			k9R(w);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void w5N(object sender, RoutedEventArgs e)
	{
		Mj7 mj = new Mj7();
		mj.Td9().set_Text(Am3().get_Text());
		((ContentControl)mj.Xx9()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)a1Q()).get_Content()));
		((Window)mj).Show();
	}

	[SpecialName]
	internal virtual ComboBox z7S()
	{
		return _cboadmissionNo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2S(ComboBox Ss9)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Wx7);
		ComboBox cboadmissionNo = _cboadmissionNo;
		if (cboadmissionNo != null)
		{
			((UIElement)cboadmissionNo).remove_MouseLeave(val);
		}
		_cboadmissionNo = Ss9;
		cboadmissionNo = _cboadmissionNo;
		if (cboadmissionNo != null)
		{
			((UIElement)cboadmissionNo).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual TextBox t1R()
	{
		return _txtname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fj1(TextBox Bg7)
	{
		_txtname = Bg7;
	}

	[SpecialName]
	internal virtual TextBox Wr8()
	{
		return _txtwardname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pn7(TextBox Dy7)
	{
		_txtwardname = Dy7;
	}

	[SpecialName]
	internal virtual TextBox j8T()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fb3(TextBox Ec9)
	{
		TextBox val = (Q = Ec9);
	}

	[SpecialName]
	internal virtual TextBox Ap2()
	{
		return _txtBedNo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8K(TextBox Ry1)
	{
		_txtBedNo = Ry1;
	}

	[SpecialName]
	internal virtual DatePicker t5T()
	{
		return _dtpicker;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1R(DatePicker n3S)
	{
		_dtpicker = n3S;
	}

	[SpecialName]
	internal virtual TextBox m3A()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sy1(TextBox a7D)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		TextChangedEventHandler val = new TextChangedEventHandler(Bi5);
		TextBox val2 = i;
		if (val2 != null)
		{
			((TextBoxBase)val2).remove_TextChanged(val);
		}
		TextBox val3 = (i = a7D);
		val2 = i;
		if (val2 != null)
		{
			((TextBoxBase)val2).add_TextChanged(val);
		}
	}

	[SpecialName]
	internal virtual TextBox r0T()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3R(TextBox e0B)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		TextChangedEventHandler val = new TextChangedEventHandler(y5A);
		TextBox val2 = v;
		if (val2 != null)
		{
			((TextBoxBase)val2).remove_TextChanged(val);
		}
		TextBox val3 = (v = e0B);
		val2 = v;
		if (val2 != null)
		{
			((TextBoxBase)val2).add_TextChanged(val);
		}
	}

	[SpecialName]
	internal virtual TextBox k1M()
	{
		return _txtamountpaid;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o0T(TextBox Cp6)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		TextChangedEventHandler val = new TextChangedEventHandler(Aw9);
		TextBox txtamountpaid = _txtamountpaid;
		if (txtamountpaid != null)
		{
			((TextBoxBase)txtamountpaid).remove_TextChanged(val);
		}
		_txtamountpaid = Cp6;
		txtamountpaid = _txtamountpaid;
		if (txtamountpaid != null)
		{
			((TextBoxBase)txtamountpaid).add_TextChanged(val);
		}
	}

	[SpecialName]
	internal virtual TextBox e4F()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mp7(TextBox b5W)
	{
		TextBox val = (N = b5W);
	}

	[SpecialName]
	internal virtual Button Ft1()
	{
		return _buttonSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gc6(Button b7K)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(w5N);
		Button buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).remove_Click(val);
		}
		_buttonSave = b7K;
		buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Sn8()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7C(Button o0H)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Qr1);
		Button d = D;
		if (d != null)
		{
			((ButtonBase)d).remove_Click(val);
		}
		Button val2 = (D = o0H);
		d = D;
		if (d != null)
		{
			((ButtonBase)d).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Gb9()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rb5(Button w8T)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(c3X);
		Button val2 = g;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (g = w8T);
		val2 = g;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button p6S()
	{
		return _buttonUpdate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6W(Button Bj5)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(p3M);
		Button buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).remove_Click(val);
		}
		_buttonUpdate = Bj5;
		buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Nb4()
	{
		return _buttonSearch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xt5(Button Qc2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(o2K);
		Button buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).remove_Click(val);
		}
		_buttonSearch = Qc2;
		buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Dm1()
	{
		return _buttonDelete;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i6D(Button t6Q)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Ax5);
		Button buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).remove_Click(val);
		}
		_buttonDelete = t6Q;
		buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Go9()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Si1(Button g6Q)
	{
		Button val = (B = g6Q);
	}

	[SpecialName]
	internal virtual Button Mm2()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ke7(Button f0W)
	{
		Button val = (R = f0W);
	}

	[SpecialName]
	internal virtual Button e1Y()
	{
		return _btnprevious;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s2D(Button z7D)
	{
		_btnprevious = z7D;
	}

	[SpecialName]
	internal virtual Button e5B()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ef4(Button Zd2)
	{
		Button val = (c = Zd2);
	}

	[SpecialName]
	internal virtual Button e8H()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2H(Button y6A)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(a7P);
		Button val2 = o;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (o = y6A);
		val2 = o;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Label a1Q()
	{
		return _lblstring;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wm4(Label Ta8)
	{
		_lblstring = Ta8;
	}

	[SpecialName]
	internal virtual RadioButton g1Q()
	{
		return _optadmitted;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6C(RadioButton Te8)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Ao1);
		RadioButton optadmitted = _optadmitted;
		if (optadmitted != null)
		{
			((ButtonBase)optadmitted).remove_Click(val);
		}
		_optadmitted = Te8;
		optadmitted = _optadmitted;
		if (optadmitted != null)
		{
			((ButtonBase)optadmitted).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual RadioButton Yp0()
	{
		return _optnotadmitted;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7G(RadioButton Sj6)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Sr0);
		RadioButton optnotadmitted = _optnotadmitted;
		if (optnotadmitted != null)
		{
			((ButtonBase)optnotadmitted).remove_Click(val);
		}
		_optnotadmitted = Sj6;
		optnotadmitted = _optnotadmitted;
		if (optnotadmitted != null)
		{
			((ButtonBase)optnotadmitted).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual TextBox j4X()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6B(TextBox k3Q)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		TextChangedEventHandler val = new TextChangedEventHandler(Do5);
		TextBox h = H;
		if (h != null)
		{
			((TextBoxBase)h).remove_TextChanged(val);
		}
		TextBox val2 = (H = k3Q);
		h = H;
		if (h != null)
		{
			((TextBoxBase)h).add_TextChanged(val);
		}
	}

	[SpecialName]
	internal virtual ComboBox Hr5()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i4D(ComboBox e2J)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Hn5);
		ComboBox val2 = u;
		if (val2 != null)
		{
			((UIElement)val2).remove_MouseLeave(val);
		}
		ComboBox val3 = (u = e2J);
		val2 = u;
		if (val2 != null)
		{
			((UIElement)val2).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual TextBox f5T()
	{
		return _txtdocname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qd6(TextBox w5F)
	{
		_txtdocname = w5F;
	}

	[SpecialName]
	internal virtual DatePicker Qa1()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pc3(DatePicker r3S)
	{
		DatePicker val = (a = r3S);
	}

	[SpecialName]
	internal virtual TextBox Am3()
	{
		return _txtbillno;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ts4(TextBox n2H)
	{
		_txtbillno = n2H;
	}

	[SpecialName]
	internal virtual TextBox c9K()
	{
		return _txttotal;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2T(TextBox b5L)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		TextChangedEventHandler val = new TextChangedEventHandler(a9W);
		TextBox txttotal = _txttotal;
		if (txttotal != null)
		{
			((TextBoxBase)txttotal).remove_TextChanged(val);
		}
		_txttotal = b5L;
		txttotal = _txttotal;
		if (txttotal != null)
		{
			((TextBoxBase)txttotal).add_TextChanged(val);
		}
	}

	[SpecialName]
	internal virtual Button Wn9()
	{
		return _btnnext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0E(Button z2E)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Nd1);
		Button btnnext = _btnnext;
		if (btnnext != null)
		{
			((ButtonBase)btnnext).remove_Click(val);
		}
		_btnnext = z2E;
		btnnext = _btnnext;
		if (btnnext != null)
		{
			((ButtonBase)btnnext).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Bd4()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6M(Button c4T)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(d7D);
		Button j = J;
		if (j != null)
		{
			((ButtonBase)j).remove_Click(val);
		}
		Button val2 = (J = c4T);
		j = J;
		if (j != null)
		{
			((ButtonBase)j).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Wq5()
	{
		return _btnlast;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1P(Button f5L)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(c5M);
		Button btnlast = _btnlast;
		if (btnlast != null)
		{
			((ButtonBase)btnlast).remove_Click(val);
		}
		_btnlast = f5L;
		btnlast = _btnlast;
		if (btnlast != null)
		{
			((ButtonBase)btnlast).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Jr3()
	{
		return _btnfirst1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7B(Button c0K)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(j0L);
		Button btnfirst = _btnfirst1;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).remove_Click(val);
		}
		_btnfirst1 = c0K;
		btnfirst = _btnfirst1;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).add_Click(val);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Zo6()
	{
		if (!M)
		{
			M = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/billingdetails.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void t2P(int Dr5, object Gc9)
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
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		switch (Dr5)
		{
		case 1:
			e2S((ComboBox)Gc9);
			break;
		case 2:
			Fj1((TextBox)Gc9);
			break;
		case 3:
			Pn7((TextBox)Gc9);
			break;
		case 4:
			Fb3((TextBox)Gc9);
			break;
		case 5:
			m8K((TextBox)Gc9);
			break;
		case 6:
			i1R((DatePicker)Gc9);
			break;
		case 7:
			Sy1((TextBox)Gc9);
			break;
		case 8:
			x3R((TextBox)Gc9);
			break;
		case 9:
			o0T((TextBox)Gc9);
			break;
		case 10:
			Mp7((TextBox)Gc9);
			break;
		case 11:
			Gc6((Button)Gc9);
			break;
		case 12:
			m7C((Button)Gc9);
			break;
		case 13:
			Rb5((Button)Gc9);
			break;
		case 14:
			e6W((Button)Gc9);
			break;
		case 15:
			Xt5((Button)Gc9);
			break;
		case 16:
			i6D((Button)Gc9);
			break;
		case 17:
			Si1((Button)Gc9);
			break;
		case 18:
			Ke7((Button)Gc9);
			break;
		case 19:
			s2D((Button)Gc9);
			break;
		case 20:
			Ef4((Button)Gc9);
			break;
		case 21:
			o2H((Button)Gc9);
			break;
		case 22:
			Wm4((Label)Gc9);
			break;
		case 23:
			w6C((RadioButton)Gc9);
			break;
		case 24:
			c7G((RadioButton)Gc9);
			break;
		case 25:
			k6B((TextBox)Gc9);
			break;
		case 26:
			i4D((ComboBox)Gc9);
			break;
		case 27:
			Qd6((TextBox)Gc9);
			break;
		case 28:
			Pc3((DatePicker)Gc9);
			break;
		case 29:
			Ts4((TextBox)Gc9);
			break;
		case 30:
			t2T((TextBox)Gc9);
			break;
		case 31:
			x0E((Button)Gc9);
			break;
		case 32:
			b6M((Button)Gc9);
			break;
		case 33:
			b1P((Button)Gc9);
			break;
		case 34:
			q7B((Button)Gc9);
			break;
		default:
			M = true;
			break;
		}
	}

	static Cs7()
	{
		V = new char[7735];
		char[] array = new char[8];
		array[1] = 'Ϊ';
		array[6] = '㳋';
		array[3] = '،';
		array[4] = 'Ꭸ';
		array[7] = '\u06d8';
		array[0] = 'ⴊ';
		array[5] = '⌚';
		array[2] = 'ᑀ';
		q = new string[255];
		Cs7.B = array;
	}
}
