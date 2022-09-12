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
using System.Windows.Markup;
using Je8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using k9F;

namespace k3WY;

[DesignerGenerated]
public class p0R1 : Window, IComponentConnector
{
	private int index;

	private DataTable table;

	private Button _buttonSave;

	private Button _buttonUpdate;

	private Button _buttonSearch;

	private Button _buttonDelete;

	private Button _btnmovenext;

	private Button _btnfirst;

	private TextBox _txtempno;

	private ComboBox _cboduty;

	private Label _lblstring;

	internal Button e;

	internal Button h;

	internal Button i;

	internal Button f;

	internal TextBox J;

	internal bool A;

	public p0R1()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(r1X4));
		index = 0;
		table = new DataTable();
		Yo68();
	}

	private void t5N7(object sender, RoutedEventArgs e)
	{
		o0FA().set_Text("");
		Kr19().set_Text("");
		Kn57().set_Text("");
		index = checked(table.Rows.Count - 1);
		Lc63(index);
	}

	public void Lc63(int Em05)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)Zg98()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from other_staff");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(table);
		DataTable dataTable = table;
		try
		{
			int num = Conversions.ToInteger(dataTable.Rows[Em05][0]);
			if (num == 0)
			{
				o0FA().set_Text(Conversions.ToString(0));
			}
			else
			{
				int num2 = checked(1 + num + 10);
				o0FA().set_Text(Conversions.ToString(num2));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	private void a7TZ(object sender, RoutedEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)Zg98()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("insert into other_staff(EmploymentNo,Name,Duty) Values\n('" + o0FA().get_Text() + "','" + Kr19().get_Text() + "','" + Kn57().get_Text() + "')");
		val2.ExecuteNonQuery();
		MessageBox.Show("Staff Registered Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
		val.Close();
	}

	private void i6CZ(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Employment. No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Zg98()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from other_staff where EmploymentNo='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		SqlDataReader val4 = val3;
		val4.Read();
		Kr19().set_Text(Conversions.ToString(val4.GetValue(1)));
		Kn57().set_Text(Conversions.ToString(val4.GetValue(2)));
		o0FA().set_Text(Conversions.ToString(val4.GetValue(0)));
		val4 = null;
		val3.Close();
	}

	private void Qt7b(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)Zg98()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("update other_staff set EmploymentNo='" + o0FA().get_Text() + "',Name='" + Kr19().get_Text() + "',Duty='" + Kn57().get_Text() + "'");
		val2.ExecuteNonQuery();
		MessageBox.Show("Staff Update Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
		val.Close();
	}

	private void Sk8m(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Staff Employment No..to Delete", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Zg98()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from other_staff where EmploymentNo='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		try
		{
			SqlDataReader val4 = val3;
			val4.Read();
			Kr19().set_Text(Conversions.ToString(val4.GetValue(1)));
			Kn57().set_Text(Conversions.ToString(val4.GetValue(2)));
			o0FA().set_Text(Conversions.ToString(val4.GetValue(0)));
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
			val2.set_CommandText("Delete from other_staff where EmploymentNo='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show("its been a pleasure Freeing up some space, Delete Succesfull");
			val.Close();
		}
	}

	private void r1X4(object sender, RoutedEventArgs e)
	{
		((ItemsControl)Kn57()).get_Items().Add((object)"Management");
		((ItemsControl)Kn57()).get_Items().Add((object)"Receptionist");
		((ItemsControl)Kn57()).get_Items().Add((object)"Billing officer");
		index = table.Rows.Count;
		y0KE(index);
	}

	public void y0KE(int t5LA)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)Zg98()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from patients_registration");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(table);
		DataTable dataTable = table;
		try
		{
			Kr19().set_Text(dataTable.Rows[t5LA][1].ToString());
			Kn57().set_Text(dataTable.Rows[t5LA][2].ToString());
			o0FA().set_Text(dataTable.Rows[t5LA][0].ToString());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	internal static byte[] c2L8(byte[] i9Y8, byte[] Qm60, int Ck9s, int Hn36)
	{
		int num = checked(i9Y8.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			i9Y8[i] = (byte)(i9Y8[i] ^ checked((byte)(Qm60[unchecked(i % Qm60.Length)] ^ ((i + unchecked(Ck9s % Qm60.Length)) & Ck9s))));
		}
		return i9Y8;
	}

	private void t8M9(object sender, RoutedEventArgs e)
	{
		checked
		{
			index++;
			y0KE(index);
		}
	}

	private void Sn29(object sender, RoutedEventArgs e)
	{
		checked
		{
			index--;
			y0KE(index);
		}
	}

	private void q4XD(object sender, RoutedEventArgs e)
	{
		index = 0;
		y0KE(index);
	}

	private void Bf16(object sender, RoutedEventArgs e)
	{
		index = checked(table.Rows.Count - 1);
		y0KE(index);
	}

	private void y9K5(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		((Window)nq).set_Title("Staff Members");
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_staff.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
	}

	[SpecialName]
	internal virtual Button Pm24()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mp2k(Button w9T4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(t5N7);
		Button val2 = e;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (e = w9T4);
		val2 = e;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button z0K4()
	{
		return _buttonSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ep80(Button Jp35)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(a7TZ);
		Button buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).remove_Click(val);
		}
		_buttonSave = Jp35;
		buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button w9EP()
	{
		return _buttonUpdate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ji71(Button j1N7)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Qt7b);
		Button buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).remove_Click(val);
		}
		_buttonUpdate = j1N7;
		buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button d7PC()
	{
		return _buttonSearch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1T5(Button k6PC)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(i6CZ);
		Button buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).remove_Click(val);
		}
		_buttonSearch = k6PC;
		buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button m5ZA()
	{
		return _buttonDelete;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rz4b(Button r0N8)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Sk8m);
		Button buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).remove_Click(val);
		}
		_buttonDelete = r0N8;
		buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Qf0a()
	{
		return _btnmovenext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pi20(Button Na02)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(t8M9);
		Button btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).remove_Click(val);
		}
		_btnmovenext = Na02;
		btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button x2FA()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fd1z(Button Ga3k)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Bf16);
		Button val2 = h;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (h = Ga3k);
		val2 = h;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button o8F1()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wn9t(Button Hq3e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Sn29);
		Button val2 = i;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (i = Hq3e);
		val2 = i;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Wb60()
	{
		return _btnfirst;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7Z3(Button Az8f)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(q4XD);
		Button btnfirst = _btnfirst;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).remove_Click(val);
		}
		_btnfirst = Az8f;
		btnfirst = _btnfirst;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button a2A6()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bn1y(Button a6SP)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(y9K5);
		Button val2 = f;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (f = a6SP);
		val2 = f;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual TextBox Kr19()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jb87(TextBox x6W1)
	{
		TextBox val = (J = x6W1);
	}

	[SpecialName]
	internal virtual TextBox o0FA()
	{
		return _txtempno;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2S7(TextBox e3J9)
	{
		_txtempno = e3J9;
	}

	[SpecialName]
	internal virtual ComboBox Kn57()
	{
		return _cboduty;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5N2(ComboBox f6GA)
	{
		_cboduty = f6GA;
	}

	[SpecialName]
	internal virtual Label Zg98()
	{
		return _lblstring;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ki9j(Label f9AG)
	{
		_lblstring = f9AG;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Yo68()
	{
		if (!A)
		{
			A = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/register_otherstaff.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Dg8o(int Cp5y, object s4AG)
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
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		switch (Cp5y)
		{
		case 1:
			Mp2k((Button)s4AG);
			break;
		case 2:
			Ep80((Button)s4AG);
			break;
		case 3:
			Ji71((Button)s4AG);
			break;
		case 4:
			k1T5((Button)s4AG);
			break;
		case 5:
			Rz4b((Button)s4AG);
			break;
		case 6:
			Pi20((Button)s4AG);
			break;
		case 7:
			Fd1z((Button)s4AG);
			break;
		case 8:
			Wn9t((Button)s4AG);
			break;
		case 9:
			e7Z3((Button)s4AG);
			break;
		case 10:
			Bn1y((Button)s4AG);
			break;
		case 11:
			Jb87((TextBox)s4AG);
			break;
		case 12:
			g2S7((TextBox)s4AG);
			break;
		case 13:
			o5N2((ComboBox)s4AG);
			break;
		case 14:
			Ki9j((Label)s4AG);
			break;
		default:
			A = true;
			break;
		}
	}
}
