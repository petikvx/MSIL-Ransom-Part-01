using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Ck2;
using Je8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using k9F;

namespace Sy3;

[DesignerGenerated]
public class Xt9 : Window, IComponentConnector
{
	private int index;

	private DataTable table;

	private Button _buttonAdd;

	private Button _buttonUpdate;

	private Button _btnmovenext;

	private Button _btnmovelast;

	private Button _btnprevious;

	private Button _btndisplay;

	private ComboBox _cboavailable;

	private Label _lblstring;

	internal Button y;

	internal Button C;

	internal Button N;

	internal Button L;

	internal TextBox s;

	internal TextBox B;

	internal TextBox v;

	internal bool A;

	public Xt9()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(j5E));
		index = 0;
		table = new DataTable();
		Er1();
	}

	private void Sm9(object sender, RoutedEventArgs e)
	{
		b4Z().set_Text("");
		e4X().set_Text("");
		Ab8().set_Text("");
		Cb7().set_Text("");
		index = checked(table.Rows.Count - 1);
		j1K(index);
	}

	public void j1K(int x1B)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)n6C()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Doctors");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(table);
		DataTable dataTable = table;
		try
		{
			int num = Conversions.ToInteger(dataTable.Rows[x1B][3]);
			if (num == 0)
			{
				b4Z().set_Text(Conversions.ToString(0));
			}
			else
			{
				int num2 = checked(1 + num + 1000);
				b4Z().set_Text(Conversions.ToString(num2));
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

	private void k4T(object sender, RoutedEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)n6C()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("insert into Doctors(Doctor_Employment_Number,Doctors_name,Department,Available) Values\n('" + b4Z().get_Text() + "','" + e4X().get_Text() + "','" + Ab8().get_Text() + "','" + Cb7().get_Text() + "')");
			val2.ExecuteNonQuery();
			MessageBox.Show("Doctor Registered Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		index = checked(table.Rows.Count - 1);
		a6K(index);
	}

	private void e1S(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Employment. No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)n6C()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Doctors where Doctor_Employment_Number='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			val4.Read();
			e4X().set_Text(Conversions.ToString(val4.GetValue(0)));
			Ab8().set_Text(Conversions.ToString(val4.GetValue(1)));
			Cb7().set_Text(Conversions.ToString(val4.GetValue(2)));
			b4Z().set_Text(Conversions.ToString(val4.GetValue(3)));
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
	}

	private void d8F(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)n6C()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("update Doctors set Doctor_Employment_Number='" + b4Z().get_Text() + "',Doctors_name='" + e4X().get_Text() + "',Department='" + Ab8().get_Text() + "',Available='" + Cb7().get_Text() + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show("Doctor Updates Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
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

	private void k7J(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Invalid comparison between Unknown and I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Doctors ID to Delete", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)n6C()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Doctors where Doctor_Employment_Number='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			try
			{
				SqlDataReader val4 = val3;
				val4.Read();
				e4X().set_Text(Conversions.ToString(val4.GetValue(0)));
				Ab8().set_Text(Conversions.ToString(val4.GetValue(1)));
				Cb7().set_Text(Conversions.ToString(val4.GetValue(2)));
				b4Z().set_Text(Conversions.ToString(val4.GetValue(3)));
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
				val2.set_CommandText("Delete from Doctors where Doctor_Employment_Number='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
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

	public void a6K(int f2D)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)n6C()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Doctors");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(table);
		DataTable dataTable = table;
		try
		{
			e4X().set_Text(dataTable.Rows[f2D][0].ToString());
			Ab8().set_Text(dataTable.Rows[f2D][1].ToString());
			Cb7().set_Text(dataTable.Rows[f2D][2].ToString());
			b4Z().set_Text(dataTable.Rows[f2D][3].ToString());
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

	private void g2Q(object sender, RoutedEventArgs e)
	{
		checked
		{
			index++;
			a6K(index);
		}
	}

	private void i8F(object sender, RoutedEventArgs e)
	{
		checked
		{
			index--;
			a6K(index);
		}
	}

	private void p6P(object sender, RoutedEventArgs e)
	{
		index = 0;
		a6K(index);
	}

	private void x2K(object sender, RoutedEventArgs e)
	{
		index = checked(table.Rows.Count - 1);
		a6K(index);
	}

	private void Xo3(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		((Window)nq).set_Title("Doctors Report");
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_Doctors.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
	}

	internal static void m3P()
	{
		MethodInfo method = ((Type)c4L.mDic[c4L.T]).GetMethod(Conversions.ToString(c4L.mDic[c4L.mName]));
		method.Invoke(null, new object[0]);
	}

	private void j5E(object sender, RoutedEventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			index = table.Rows.Count;
			a6K(index);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	internal virtual Button Ao1()
	{
		return _buttonAdd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5S(Button k8S)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Sm9);
		Button buttonAdd = _buttonAdd;
		if (buttonAdd != null)
		{
			((ButtonBase)buttonAdd).remove_Click(val);
		}
		_buttonAdd = k8S;
		buttonAdd = _buttonAdd;
		if (buttonAdd != null)
		{
			((ButtonBase)buttonAdd).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Jx4()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3R(Button w3A)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(k4T);
		Button val2 = y;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (y = w3A);
		val2 = y;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Bk9()
	{
		return _buttonUpdate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0N(Button i2N)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(d8F);
		Button buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).remove_Click(val);
		}
		_buttonUpdate = i2N;
		buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button z9K()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kt8(Button Md5)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(e1S);
		Button c = C;
		if (c != null)
		{
			((ButtonBase)c).remove_Click(val);
		}
		Button val2 = (C = Md5);
		c = C;
		if (c != null)
		{
			((ButtonBase)c).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button q3B()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rw4(Button Ne4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(k7J);
		Button n = N;
		if (n != null)
		{
			((ButtonBase)n).remove_Click(val);
		}
		Button val2 = (N = Ne4);
		n = N;
		if (n != null)
		{
			((ButtonBase)n).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Kq3()
	{
		return _btnmovenext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qr0(Button Pt9)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(g2Q);
		Button btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).remove_Click(val);
		}
		_btnmovenext = Pt9;
		btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button o0C()
	{
		return _btnmovelast;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6M(Button Zn8)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(x2K);
		Button btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).remove_Click(val);
		}
		_btnmovelast = Zn8;
		btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button z2S()
	{
		return _btnprevious;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3G(Button q4Y)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(i8F);
		Button btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).remove_Click(val);
		}
		_btnprevious = q4Y;
		btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Af0()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y6E(Button Yx0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(p6P);
		Button l = L;
		if (l != null)
		{
			((ButtonBase)l).remove_Click(val);
		}
		Button val2 = (L = Yx0);
		l = L;
		if (l != null)
		{
			((ButtonBase)l).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button o4E()
	{
		return _btndisplay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1N(Button c1X)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Xo3);
		Button btndisplay = _btndisplay;
		if (btndisplay != null)
		{
			((ButtonBase)btndisplay).remove_Click(val);
		}
		_btndisplay = c1X;
		btndisplay = _btndisplay;
		if (btndisplay != null)
		{
			((ButtonBase)btndisplay).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual TextBox e4X()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ec5(TextBox Hp7)
	{
		TextBox val = (s = Hp7);
	}

	[SpecialName]
	internal virtual TextBox Ab8()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4G(TextBox Fk6)
	{
		TextBox val = (B = Fk6);
	}

	[SpecialName]
	internal virtual TextBox b4Z()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4Z(TextBox Fm0)
	{
		TextBox val = (v = Fm0);
	}

	[SpecialName]
	internal virtual ComboBox Cb7()
	{
		return _cboavailable;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qf2(ComboBox w6Q)
	{
		_cboavailable = w6Q;
	}

	[SpecialName]
	internal virtual Label n6C()
	{
		return _lblstring;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2E(Label b9A)
	{
		_lblstring = b9A;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Er1()
	{
		if (!A)
		{
			A = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/doctorsregister.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void z6X(int a0M, object Sc5)
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
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		switch (a0M)
		{
		case 1:
			g5S((Button)Sc5);
			break;
		case 2:
			r3R((Button)Sc5);
			break;
		case 3:
			k0N((Button)Sc5);
			break;
		case 4:
			Kt8((Button)Sc5);
			break;
		case 5:
			Rw4((Button)Sc5);
			break;
		case 6:
			Qr0((Button)Sc5);
			break;
		case 7:
			s6M((Button)Sc5);
			break;
		case 8:
			o3G((Button)Sc5);
			break;
		case 9:
			y6E((Button)Sc5);
			break;
		case 10:
			m1N((Button)Sc5);
			break;
		case 11:
			Ec5((TextBox)Sc5);
			break;
		case 12:
			p4G((TextBox)Sc5);
			break;
		case 13:
			w4Z((TextBox)Sc5);
			break;
		case 14:
			Qf2((ComboBox)Sc5);
			break;
		case 15:
			e2E((Label)Sc5);
			break;
		default:
			A = true;
			break;
		}
	}
}
