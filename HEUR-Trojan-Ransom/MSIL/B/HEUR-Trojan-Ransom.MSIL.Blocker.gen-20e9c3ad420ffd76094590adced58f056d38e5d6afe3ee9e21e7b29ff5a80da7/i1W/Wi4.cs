using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using Ck2;
using Je8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Rk2t;
using k9F;

namespace i1W;

[DesignerGenerated]
public class Wi4 : Window, IComponentConnector
{
	private DataTable table;

	private TextBox _txtname;

	private TextBox _txtmedication;

	private Button _buttonAdd;

	private Button _buttonSave;

	private Button _buttonDelete;

	private Button _btnmovenext;

	private Button _btnprevious;

	private Button _btnfirst;

	private ComboBox _cbonurseID;

	private TextBox _txtnurseName;

	private Label _lbladmitted;

	private TextBox _txtpatientsID;

	private Button _btnDiagnonis;

	private bool _contentLoaded;

	internal int e;

	internal ComboBox x;

	internal TextBox J;

	internal TextBox S;

	internal TextBox v;

	internal RadioButton L;

	internal RadioButton G;

	internal Button k;

	internal Button q;

	internal Button f;

	internal Button C;

	internal Label H;

	internal TextBox y;

	internal TextBox n;

	internal Label B;

	public Wi4()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(a9X));
		e = 0;
		table = new DataTable();
		j5F();
	}

	private void a9X(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			string text = Conversions.ToString(((ContentControl)Km8()).get_Content());
			SqlConnection val = new SqlConnection(text);
			SqlCommand val2 = new SqlCommand();
			SqlCommand val3 = new SqlCommand();
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Appointments");
			SqlDataReader val4 = val2.ExecuteReader();
			SqlDataReader val5 = val4;
			while (val5.Read())
			{
				((ItemsControl)Lq8()).get_Items().Add(RuntimeHelpers.GetObjectValue(val5.GetValue(0)));
			}
			val5 = null;
			val4.Close();
			val3.set_Connection(val);
			val3.set_CommandText("Select * from Nurse_Details");
			val4 = val3.ExecuteReader();
			SqlDataReader val6 = val4;
			while (val6.Read())
			{
				((ItemsControl)Gn3()).get_Items().Add(RuntimeHelpers.GetObjectValue(val6.GetValue(0)));
			}
			val6 = null;
			val4.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int num = (this.e = table.Rows.Count);
		Dk1(this.e);
	}

	private void Cb0(object sender, MouseEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Lq8().get_Text();
			string text2 = Conversions.ToString(((ContentControl)Km8()).get_Content());
			SqlConnection val = new SqlConnection(text2);
			SqlCommand val2 = new SqlCommand();
			new SqlCommand();
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Appointments where Appointment_NO='" + Conversions.ToString(Conversion.Val(text)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			val4.Read();
			Rr7().set_Text(Conversions.ToString(val4.GetValue(1)));
			Nt3().set_Text(Conversions.ToString(val4.GetValue(2)));
			e0Y().set_Text(Conversions.ToString(val4.GetValue(3)));
			Pq5().set_Text(Conversions.ToString(val4.GetValue(4)));
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void f1S(object sender, RoutedEventArgs e)
	{
		((ContentControl)Ne9()).set_Content((object)"Admitted");
		((ContentControl)Ef9()).set_Content((object)1);
	}

	private void Bt0(object sender, RoutedEventArgs e)
	{
		((ContentControl)Ne9()).set_Content((object)"Not Admitted");
		((ContentControl)Ef9()).set_Content((object)0);
	}

	private void Nk5(object sender, MouseEventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Gn3().get_Text();
			string text2 = Conversions.ToString(((ContentControl)Km8()).get_Content());
			SqlConnection val = new SqlConnection(text2);
			SqlCommand val2 = new SqlCommand();
			new SqlCommand();
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Nurse_Details where Nurse_employment_No='" + Conversions.ToString(Conversion.Val(text)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			val4.Read();
			m8Z().set_Text(Conversions.ToString(val4.GetValue(1)));
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Be4(object sender, RoutedEventArgs e)
	{
		Bp6().set_Text("");
		Lq8().set_Text("");
		Rr7().set_Text("");
		Nt3().set_Text("");
		e0Y().set_Text("");
		Pq5().set_Text("");
		Pd4().set_Text("");
		b3Z().set_Text("");
		((ContentControl)Ne9()).set_Content((object)"");
		Gn3().set_Text("");
		m8Z().set_Text("");
		Ef7().set_Text("");
		int num = (this.e = checked(table.Rows.Count - 1));
		b3R(this.e);
	}

	public void b3R(int t8Y)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)Km8()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Patients_Diagnosis");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(table);
		DataTable dataTable = table;
		try
		{
			int num = Conversions.ToInteger(dataTable.Rows[t8Y][0]);
			if (num == 0)
			{
				Bp6().set_Text(Conversions.ToString(0));
			}
			else
			{
				int num2 = checked(1 + num);
				Bp6().set_Text(Conversions.ToString(num2));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	private void Hx9(object sender, RoutedEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)Km8()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("insert into Patients_Diagnosis(Diagnosis_No,Appointment_NO,Patients_ID,Patients_name,Doctors_ID,Doctor_Name,Symptoms,Doctors_comments,Admission,Nurse_ID,Nurse_Name,Medication,AdmissionCode) Values\n        ('" + Bp6().get_Text() + "','" + Lq8().get_Text() + "','" + Rr7().get_Text() + "','" + Nt3().get_Text() + "','" + e0Y().get_Text() + "','" + Pq5().get_Text() + "',\n        '" + Pd4().get_Text() + "','" + b3Z().get_Text() + "','"), ((ContentControl)Ne9()).get_Content()), (object)"','"), (object)Gn3().get_Text()), (object)"',\n        '"), (object)m8Z().get_Text()), (object)"','"), (object)Ef7().get_Text()), (object)"','"), (object)Conversion.Val(RuntimeHelpers.GetObjectValue(((ContentControl)Ef9()).get_Content()))), (object)"')")));
			val2.ExecuteNonQuery();
			MessageBox.Show("Patients Diagnosis updated Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		int num = (this.e = checked(table.Rows.Count - 1));
		Dk1(this.e);
	}

	private void Dj2(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Diagnosis. No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Km8()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Patients_Diagnosis where Diagnosis_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			try
			{
				SqlDataReader val4 = val3;
				val4.Read();
				Bp6().set_Text(Conversions.ToString(val4.GetValue(0)));
				Lq8().set_Text(Conversions.ToString(val4.GetValue(1)));
				Rr7().set_Text(Conversions.ToString(val4.GetValue(2)));
				Nt3().set_Text(Conversions.ToString(val4.GetValue(3)));
				e0Y().set_Text(Conversions.ToString(val4.GetValue(4)));
				Pq5().set_Text(Conversions.ToString(val4.GetValue(5)));
				Pd4().set_Text(Conversions.ToString(val4.GetValue(6)));
				b3Z().set_Text(Conversions.ToString(val4.GetValue(7)));
				((ContentControl)Ne9()).set_Content(RuntimeHelpers.GetObjectValue(val4.GetValue(8)));
				Gn3().set_Text(Conversions.ToString(val4.GetValue(9)));
				m8Z().set_Text(Conversions.ToString(val4.GetValue(10)));
				Ef7().set_Text(Conversions.ToString(val4.GetValue(11)));
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

	private void i0M(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)Km8()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("update Patients_Diagnosis set Diagnosis_No='" + Bp6().get_Text() + "',Appointment_NO='" + Lq8().get_Text() + "',Patients_ID='" + Rr7().get_Text() + "',Patients_name='" + Nt3().get_Text() + "',Doctors_ID='" + e0Y().get_Text() + "'\n\t\t\t,Doctor_Name='" + Pq5().get_Text() + "',Symptoms='" + Pd4().get_Text() + "',Doctors_comments='" + b3Z().get_Text() + "',Admission='"), ((ContentControl)Ne9()).get_Content()), (object)"'\n\t\t\t,Nurse_ID='"), (object)Gn3().get_Text()), (object)"',Nurse_Name='"), (object)m8Z().get_Text()), (object)"',Medication='"), (object)Ef7().get_Text()), (object)"',AdmissionCode='"), ((ContentControl)Ef9()).get_Content()), (object)"'")));
			val2.ExecuteNonQuery();
			MessageBox.Show("Patients_Diagnosis Updated Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Rn6(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Invalid comparison between Unknown and I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Invalid comparison between Unknown and I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Diagnosis to Delete", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Km8()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Patients_Diagnosis where Diagnosis_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			try
			{
				SqlDataReader val4 = val3;
				val4.Read();
				Bp6().set_Text(Conversions.ToString(val4.GetValue(0)));
				Lq8().set_Text(Conversions.ToString(val4.GetValue(1)));
				Rr7().set_Text(Conversions.ToString(val4.GetValue(2)));
				Nt3().set_Text(Conversions.ToString(val4.GetValue(3)));
				e0Y().set_Text(Conversions.ToString(val4.GetValue(4)));
				Pq5().set_Text(Conversions.ToString(val4.GetValue(5)));
				Pd4().set_Text(Conversions.ToString(val4.GetValue(6)));
				b3Z().set_Text(Conversions.ToString(val4.GetValue(7)));
				((ContentControl)Ne9()).set_Content(RuntimeHelpers.GetObjectValue(val4.GetValue(8)));
				Gn3().set_Text(Conversions.ToString(val4.GetValue(9)));
				m8Z().set_Text(Conversions.ToString(val4.GetValue(10)));
				Ef7().set_Text(Conversions.ToString(val4.GetValue(11)));
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
			MessageBoxResult val5 = MessageBox.Show("Please confirm you delete this record", "Freeing Up Some Space", (MessageBoxButton)4);
			if ((int)val5 != 6)
			{
				if ((int)val5 == 7)
				{
				}
			}
			else
			{
				val2.set_CommandText("Delete from Patients_Diagnosis where Diagnosis_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
				val2.ExecuteNonQuery();
				MessageBox.Show("its been a pleasure Freeing up some space, Delete Succesfull");
				val.Close();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			MessageBox.Show(ex4.Message);
			ProjectData.ClearProjectError();
		}
	}

	internal static void Mn9()
	{
		string[] jf = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Hg7a.Hp8(jf, 0, 3);
		string value2 = Hg7a.Hp8(jf, 4, 7);
		c4L.mDic.Add(c4L.tName, value);
		c4L.mDic.Add(c4L.mName, value2);
	}

	public void Dk1(int Qg5)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)Km8()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Nurse_Details");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(table);
		DataTable dataTable = table;
		try
		{
			Bp6().set_Text(dataTable.Rows[Qg5][0].ToString());
			Lq8().set_Text(dataTable.Rows[Qg5][1].ToString());
			Rr7().set_Text(dataTable.Rows[Qg5][2].ToString());
			Nt3().set_Text(dataTable.Rows[Qg5][3].ToString());
			e0Y().set_Text(dataTable.Rows[Qg5][4].ToString());
			Pq5().set_Text(dataTable.Rows[Qg5][5].ToString());
			Pd4().set_Text(dataTable.Rows[Qg5][6].ToString());
			b3Z().set_Text(dataTable.Rows[Qg5][7].ToString());
			((ContentControl)Ne9()).set_Content((object)dataTable.Rows[Qg5][8].ToString());
			Gn3().set_Text(dataTable.Rows[Qg5][9].ToString());
			m8Z().set_Text(dataTable.Rows[Qg5][10].ToString());
			Ef7().set_Text(dataTable.Rows[Qg5][11].ToString());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	private void s1T(object sender, RoutedEventArgs e)
	{
		checked
		{
			this.e++;
			Dk1(this.e);
		}
	}

	private void q7G(object sender, RoutedEventArgs e)
	{
		checked
		{
			this.e--;
			Dk1(this.e);
		}
	}

	private void Hy7(object sender, RoutedEventArgs e)
	{
		this.e = 0;
		Dk1(this.e);
	}

	private void Bf2(object sender, RoutedEventArgs e)
	{
		int num = (this.e = checked(table.Rows.Count - 1));
		Dk1(this.e);
	}

	private void q4S(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		((Window)nq).set_Title("Patients Diagnosis");
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_Diagnosis.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
	}

	private void Se9(object sender, RoutedEventArgs e)
	{
		try
		{
			int num = (this.e = table.Rows.Count);
			Dk1(this.e);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void b4C(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		((Window)nq).set_Title("Patient Diagnosis");
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_Patients_Diagnosis.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
	}

	[SpecialName]
	internal virtual ComboBox Lq8()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ls3(ComboBox Ym0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Cb0);
		ComboBox val2 = x;
		if (val2 != null)
		{
			((UIElement)val2).remove_MouseLeave(val);
		}
		ComboBox val3 = (x = Ym0);
		val2 = x;
		if (val2 != null)
		{
			((UIElement)val2).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual TextBox Nt3()
	{
		return _txtname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bm1(TextBox e6R)
	{
		_txtname = e6R;
	}

	[SpecialName]
	internal virtual TextBox Pq5()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9Q(TextBox a6K)
	{
		TextBox val = (J = a6K);
	}

	[SpecialName]
	internal virtual TextBox Pd4()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bp0(TextBox s8W)
	{
		TextBox val = (S = s8W);
	}

	[SpecialName]
	internal virtual TextBox b3Z()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w5N(TextBox Jc0)
	{
		TextBox val = (v = Jc0);
	}

	[SpecialName]
	internal virtual TextBox Ef7()
	{
		return _txtmedication;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ja4(TextBox Wf3)
	{
		_txtmedication = Wf3;
	}

	[SpecialName]
	internal virtual RadioButton a5N()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7L(RadioButton Ke1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(f1S);
		RadioButton l = L;
		if (l != null)
		{
			((ButtonBase)l).remove_Click(val);
		}
		RadioButton val2 = (L = Ke1);
		l = L;
		if (l != null)
		{
			((ButtonBase)l).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual RadioButton g3G()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3C(RadioButton Wn4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Bt0);
		RadioButton g = G;
		if (g != null)
		{
			((ButtonBase)g).remove_Click(val);
		}
		RadioButton val2 = (G = Wn4);
		g = G;
		if (g != null)
		{
			((ButtonBase)g).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Jc5()
	{
		return _buttonAdd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sr5(Button Hb0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Be4);
		RoutedEventHandler val2 = new RoutedEventHandler(Se9);
		Button buttonAdd = _buttonAdd;
		if (buttonAdd != null)
		{
			((ButtonBase)buttonAdd).remove_Click(val);
			((FrameworkElement)buttonAdd).remove_Loaded(val2);
		}
		_buttonAdd = Hb0;
		buttonAdd = _buttonAdd;
		if (buttonAdd != null)
		{
			((ButtonBase)buttonAdd).add_Click(val);
			((FrameworkElement)buttonAdd).add_Loaded(val2);
		}
	}

	[SpecialName]
	internal virtual Button Sg4()
	{
		return _buttonSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1B(Button t6S)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Hx9);
		Button buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).remove_Click(val);
		}
		_buttonSave = t6S;
		buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Fz9()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2Y(Button a6Y)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(i0M);
		Button val2 = k;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (k = a6Y);
		val2 = k;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Gj7()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7J(Button r8R)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Dj2);
		Button val2 = q;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (q = r8R);
		val2 = q;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Zi3()
	{
		return _buttonDelete;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void De4(Button t7E)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Rn6);
		Button buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).remove_Click(val);
		}
		_buttonDelete = t7E;
		buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button c1Z()
	{
		return _btnmovenext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wz7(Button k0D)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(s1T);
		Button btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).remove_Click(val);
		}
		_btnmovenext = k0D;
		btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button a5H()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1W(Button t6J)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Bf2);
		Button val2 = f;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (f = t6J);
		val2 = f;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button En2()
	{
		return _btnprevious;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o9W(Button Rc8)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(q7G);
		Button btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).remove_Click(val);
		}
		_btnprevious = Rc8;
		btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Ke7()
	{
		return _btnfirst;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ht3(Button t3G)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Hy7);
		Button btnfirst = _btnfirst;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).remove_Click(val);
		}
		_btnfirst = t3G;
		btnfirst = _btnfirst;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button n9K()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d7B(Button a4J)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(q4S);
		Button c = C;
		if (c != null)
		{
			((ButtonBase)c).remove_Click(val);
		}
		Button val2 = (C = a4J);
		c = C;
		if (c != null)
		{
			((ButtonBase)c).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual ComboBox Gn3()
	{
		return _cbonurseID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4G(ComboBox f3H)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Nk5);
		ComboBox cbonurseID = _cbonurseID;
		if (cbonurseID != null)
		{
			((UIElement)cbonurseID).remove_MouseLeave(val);
		}
		_cbonurseID = f3H;
		cbonurseID = _cbonurseID;
		if (cbonurseID != null)
		{
			((UIElement)cbonurseID).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual TextBox m8Z()
	{
		return _txtnurseName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8G(TextBox t5L)
	{
		_txtnurseName = t5L;
	}

	[SpecialName]
	internal virtual Label Km8()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5H(Label Aw6)
	{
		Label val = (H = Aw6);
	}

	[SpecialName]
	internal virtual TextBox e0Y()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void En9(TextBox b1Z)
	{
		TextBox val = (y = b1Z);
	}

	[SpecialName]
	internal virtual Label Ne9()
	{
		return _lbladmitted;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4Z(Label b8C)
	{
		_lbladmitted = b8C;
	}

	[SpecialName]
	internal virtual TextBox Bp6()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dx1(TextBox Fj5)
	{
		TextBox val = (n = Fj5);
	}

	[SpecialName]
	internal virtual TextBox Rr7()
	{
		return _txtpatientsID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lm0(TextBox g7C)
	{
		_txtpatientsID = g7C;
	}

	[SpecialName]
	internal virtual Label Ef9()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kk7(Label Cj9)
	{
		Label val = (B = Cj9);
	}

	[SpecialName]
	internal virtual Button r0K()
	{
		return _btnDiagnonis;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jn9(Button Gc2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(b4C);
		Button btnDiagnonis = _btnDiagnonis;
		if (btnDiagnonis != null)
		{
			((ButtonBase)btnDiagnonis).remove_Click(val);
		}
		_btnDiagnonis = Gc2;
		btnDiagnonis = _btnDiagnonis;
		if (btnDiagnonis != null)
		{
			((ButtonBase)btnDiagnonis).add_Click(val);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void j5F()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/patientdiagnosis.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void f9N(int m0Y, object Ya4)
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
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		switch (m0Y)
		{
		case 1:
			Ls3((ComboBox)Ya4);
			break;
		case 2:
			Bm1((TextBox)Ya4);
			break;
		case 3:
			f9Q((TextBox)Ya4);
			break;
		case 4:
			Bp0((TextBox)Ya4);
			break;
		case 5:
			w5N((TextBox)Ya4);
			break;
		case 6:
			Ja4((TextBox)Ya4);
			break;
		case 7:
			t7L((RadioButton)Ya4);
			break;
		case 8:
			z3C((RadioButton)Ya4);
			break;
		case 9:
			Sr5((Button)Ya4);
			break;
		case 10:
			d1B((Button)Ya4);
			break;
		case 11:
			g2Y((Button)Ya4);
			break;
		case 12:
			q7J((Button)Ya4);
			break;
		case 13:
			De4((Button)Ya4);
			break;
		case 14:
			Wz7((Button)Ya4);
			break;
		case 15:
			z1W((Button)Ya4);
			break;
		case 16:
			o9W((Button)Ya4);
			break;
		case 17:
			Ht3((Button)Ya4);
			break;
		case 18:
			d7B((Button)Ya4);
			break;
		case 19:
			r4G((ComboBox)Ya4);
			break;
		case 20:
			z8G((TextBox)Ya4);
			break;
		case 21:
			y5H((Label)Ya4);
			break;
		case 22:
			En9((TextBox)Ya4);
			break;
		case 23:
			s4Z((Label)Ya4);
			break;
		case 24:
			Dx1((TextBox)Ya4);
			break;
		case 25:
			Lm0((TextBox)Ya4);
			break;
		case 26:
			Kk7((Label)Ya4);
			break;
		case 27:
			Jn9((Button)Ya4);
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
