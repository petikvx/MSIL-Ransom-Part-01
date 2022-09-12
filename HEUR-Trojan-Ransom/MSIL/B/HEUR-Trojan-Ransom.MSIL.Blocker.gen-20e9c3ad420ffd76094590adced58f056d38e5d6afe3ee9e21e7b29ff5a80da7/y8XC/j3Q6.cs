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
using i1W;
using k9F;
using s5R;

namespace y8XC;

[DesignerGenerated]
public class j3Q6 : Window, IComponentConnector
{
	private TextBox _txtidno;

	private Button _buttonAdd;

	private Button _buttonSearch;

	private Button _btnmovenext;

	private Button _btnmovelast;

	private Button _btnprevious;

	private Button _btnfirst;

	private Button _btndisplay;

	private RadioButton _optfemale;

	private Label _lblstring;

	private TextBox _txtregamount;

	internal int w;

	internal DataTable x;

	internal TextBox c;

	internal TextBox e;

	internal DatePicker k;

	internal Button P;

	internal Button Y;

	internal Button U;

	internal Label I;

	internal RadioButton F;

	internal ComboBox b;

	internal bool m;

	public j3Q6()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(Qj26));
		w = 0;
		DataTable dataTable = (x = new DataTable());
		g9H0();
	}

	private void i3J0(object sender, RoutedEventArgs e)
	{
		Tr24().set_Text("");
		n8AE().set_Text("");
		Nx03().set_Text("");
		Jf92().set_Text("");
		((ContentControl)Qk7n()).set_Content((object)"");
		Cy67().set_Text("0.00");
		int num = (w = checked(x.Rows.Count - 1));
		c3Z8(w);
	}

	public void c3Z8(int a3MR)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)Mc0x()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from patients_registration");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(x);
		DataTable dataTable = x;
		try
		{
			int num = Conversions.ToInteger(dataTable.Rows[a3MR][0]);
			if (num == 0)
			{
				Tr24().set_Text(Conversions.ToString(0));
			}
			else
			{
				int num2 = checked(1 + num);
				Tr24().set_Text(Conversions.ToString(num2));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	private void e3B9(object sender, RoutedEventArgs e)
	{
		((ContentControl)Qk7n()).set_Content((object)"Female");
	}

	private void Ym3b(object sender, RoutedEventArgs e)
	{
		((ContentControl)Qk7n()).set_Content((object)"male");
	}

	private void St12(object sender, RoutedEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)Mc0x()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("insert into patients_registration(Id_no,name,Address,Marital,Sex,Date,Registration_Amount) Values\n('" + Tr24().get_Text() + "','" + n8AE().get_Text() + "','" + Nx03().get_Text() + "','" + Jf92().get_Text() + "','"), ((ContentControl)Qk7n()).get_Content()), (object)"'\n,'"), (object)g2Z3().get_Text()), (object)"','"), (object)Cy67().get_Text()), (object)"')")));
			val2.ExecuteNonQuery();
			MessageBox.Show("Patient Registered Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int num = (w = checked(x.Rows.Count - 1));
		Pi5q(w);
	}

	private void d9F0(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter ID. No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Mc0x()).get_Content());
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
			n8AE().set_Text(Conversions.ToString(val4.GetValue(0)));
			Nx03().set_Text(Conversions.ToString(val4.GetValue(1)));
			Jf92().set_Text(Conversions.ToString(val4.GetValue(2)));
			((ContentControl)Qk7n()).set_Content(RuntimeHelpers.GetObjectValue(val4.GetValue(3)));
			g2Z3().set_Text(Conversions.ToString(val4.GetValue(4)));
			Tr24().set_Text(Conversions.ToString(val4.GetValue(5)));
			Cy67().set_Text(Conversions.ToString(val4.GetValue(6)));
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Zb34(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)Mc0x()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("update patients_registration set Id_no='" + Tr24().get_Text() + "',name='" + n8AE().get_Text() + "',Address='" + Nx03().get_Text() + "',Marital='" + Jf92().get_Text() + "',\n        Sex='"), ((ContentControl)Qk7n()).get_Content()), (object)"',Date='"), (object)g2Z3().get_Text()), (object)"',Registration_Amount='"), (object)Cy67().get_Text()), (object)"'")));
			val2.ExecuteNonQuery();
			MessageBox.Show("Patient Updates Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void a9N4(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Invalid comparison between Unknown and I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Patients ID to Delete", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Mc0x()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from patients_registration where Id_no='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			try
			{
				SqlDataReader val4 = val3;
				val4.Read();
				n8AE().set_Text(Conversions.ToString(val4.GetValue(0)));
				Nx03().set_Text(Conversions.ToString(val4.GetValue(1)));
				Jf92().set_Text(Conversions.ToString(val4.GetValue(2)));
				((ContentControl)Qk7n()).set_Content(RuntimeHelpers.GetObjectValue(val4.GetValue(3)));
				g2Z3().set_Text(Conversions.ToString(val4.GetValue(4)));
				Tr24().set_Text(Conversions.ToString(val4.GetValue(5)));
				Cy67().set_Text(Conversions.ToString(val4.GetValue(6)));
				val4 = null;
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
				val2.set_CommandText("Delete from patients_registration where Id_no='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
				val2.ExecuteNonQuery();
				MessageBox.Show("its been a pleasure Freeing up some space, Delete Succesfull");
				val.Close();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void Pi5q(int Tw6x)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)Mc0x()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from patients_registration");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(x);
		DataTable dataTable = x;
		try
		{
			n8AE().set_Text(dataTable.Rows[Tw6x][0].ToString());
			Nx03().set_Text(dataTable.Rows[Tw6x][1].ToString());
			Jf92().set_Text(dataTable.Rows[Tw6x][2].ToString());
			((ContentControl)Qk7n()).set_Content((object)dataTable.Rows[Tw6x][3].ToString());
			g2Z3().set_Text(dataTable.Rows[Tw6x][4].ToString());
			Tr24().set_Text(dataTable.Rows[Tw6x][5].ToString());
			Cy67().set_Text(dataTable.Rows[Tw6x][6].ToString());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		dataTable = null;
	}

	internal static string[] n3Q8()
	{
		Wi4.Mn9();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		c4L.mDic.Add("o", executingAssembly);
		return Te1.Sc7();
	}

	private void Gg0r(object sender, RoutedEventArgs e)
	{
		checked
		{
			w++;
			Pi5q(w);
		}
	}

	private void b8Y0(object sender, RoutedEventArgs e)
	{
		checked
		{
			w--;
			Pi5q(w);
		}
	}

	private void q1XR(object sender, RoutedEventArgs e)
	{
		w = 0;
		Pi5q(w);
	}

	private void f7WH(object sender, RoutedEventArgs e)
	{
		int num = (w = checked(x.Rows.Count - 1));
		Pi5q(w);
	}

	private void Jt74(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_registration.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
	}

	private void Qj26(object sender, RoutedEventArgs e)
	{
		try
		{
			int num = (w = x.Rows.Count);
			Pi5q(w);
			((ItemsControl)Jf92()).get_Items().Add((object)"Single");
			((ItemsControl)Jf92()).get_Items().Add((object)"Married");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	internal virtual TextBox Tr24()
	{
		return _txtidno;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eo05(TextBox Dr2d)
	{
		_txtidno = Dr2d;
	}

	[SpecialName]
	internal virtual TextBox n8AE()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1K3(TextBox k9Q3)
	{
		TextBox val = (c = k9Q3);
	}

	[SpecialName]
	internal virtual TextBox Nx03()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cq63(TextBox Xf8x)
	{
		TextBox val = (e = Xf8x);
	}

	[SpecialName]
	internal virtual DatePicker g2Z3()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1J5(DatePicker p3FN)
	{
		DatePicker val = (k = p3FN);
	}

	[SpecialName]
	internal virtual Button x0P2()
	{
		return _buttonAdd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qf80(Button s1ZD)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(i3J0);
		Button buttonAdd = _buttonAdd;
		if (buttonAdd != null)
		{
			((ButtonBase)buttonAdd).remove_Click(val);
		}
		_buttonAdd = s1ZD;
		buttonAdd = _buttonAdd;
		if (buttonAdd != null)
		{
			((ButtonBase)buttonAdd).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button x0E7()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bz2c(Button q5X3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(St12);
		Button p = P;
		if (p != null)
		{
			((ButtonBase)p).remove_Click(val);
		}
		Button val2 = (P = q5X3);
		p = P;
		if (p != null)
		{
			((ButtonBase)p).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button w0C1()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dc4t(Button Xq26)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Zb34);
		Button y = Y;
		if (y != null)
		{
			((ButtonBase)y).remove_Click(val);
		}
		Button val2 = (Y = Xq26);
		y = Y;
		if (y != null)
		{
			((ButtonBase)y).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button k2YE()
	{
		return _buttonSearch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zd5w(Button Gs8e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(d9F0);
		Button buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).remove_Click(val);
		}
		_buttonSearch = Gs8e;
		buttonSearch = _buttonSearch;
		if (buttonSearch != null)
		{
			((ButtonBase)buttonSearch).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button y3PS()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nw58(Button Fb61)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(a9N4);
		Button u = U;
		if (u != null)
		{
			((ButtonBase)u).remove_Click(val);
		}
		Button val2 = (U = Fb61);
		u = U;
		if (u != null)
		{
			((ButtonBase)u).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button m2XM()
	{
		return _btnmovenext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0ML(Button g5AX)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Gg0r);
		Button btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).remove_Click(val);
		}
		_btnmovenext = g5AX;
		btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button a6D5()
	{
		return _btnmovelast;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yi5g(Button x1Q6)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(f7WH);
		Button btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).remove_Click(val);
		}
		_btnmovelast = x1Q6;
		btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Ww96()
	{
		return _btnprevious;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2XG(Button Wp48)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(b8Y0);
		Button btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).remove_Click(val);
		}
		_btnprevious = Wp48;
		btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button d5FY()
	{
		return _btnfirst;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1QR(Button Mi38)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(q1XR);
		Button btnfirst = _btnfirst;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).remove_Click(val);
		}
		_btnfirst = Mi38;
		btnfirst = _btnfirst;
		if (btnfirst != null)
		{
			((ButtonBase)btnfirst).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button q0T6()
	{
		return _btndisplay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ek43(Button Ei5b)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Jt74);
		Button btndisplay = _btndisplay;
		if (btndisplay != null)
		{
			((ButtonBase)btndisplay).remove_Click(val);
		}
		_btndisplay = Ei5b;
		btndisplay = _btndisplay;
		if (btndisplay != null)
		{
			((ButtonBase)btndisplay).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Label Qk7n()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4TF(Label e3A2)
	{
		Label val = (I = e3A2);
	}

	[SpecialName]
	internal virtual RadioButton q1JL()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bw0d(RadioButton En72)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Ym3b);
		RadioButton f = F;
		if (f != null)
		{
			((ButtonBase)f).remove_Click(val);
		}
		RadioButton val2 = (F = En72);
		f = F;
		if (f != null)
		{
			((ButtonBase)f).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual RadioButton Ng45()
	{
		return _optfemale;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3RM(RadioButton At1b)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(e3B9);
		RadioButton optfemale = _optfemale;
		if (optfemale != null)
		{
			((ButtonBase)optfemale).remove_Click(val);
		}
		_optfemale = At1b;
		optfemale = _optfemale;
		if (optfemale != null)
		{
			((ButtonBase)optfemale).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Label Mc0x()
	{
		return _lblstring;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ri7o(Label Bp71)
	{
		_lblstring = Bp71;
	}

	[SpecialName]
	internal virtual TextBox Cy67()
	{
		return _txtregamount;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4NA(TextBox b9PR)
	{
		_txtregamount = b9PR;
	}

	[SpecialName]
	internal virtual ComboBox Jf92()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0YN(ComboBox Bf9w)
	{
		ComboBox val = (b = Bf9w);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void g9H0()
	{
		if (!m)
		{
			m = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/patientsregistration.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void r0FJ(int Nr2k, object b7B9)
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
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		switch (Nr2k)
		{
		case 1:
			Eo05((TextBox)b7B9);
			break;
		case 2:
			c1K3((TextBox)b7B9);
			break;
		case 3:
			Cq63((TextBox)b7B9);
			break;
		case 4:
			c1J5((DatePicker)b7B9);
			break;
		case 5:
			Qf80((Button)b7B9);
			break;
		case 6:
			Bz2c((Button)b7B9);
			break;
		case 7:
			Dc4t((Button)b7B9);
			break;
		case 8:
			Zd5w((Button)b7B9);
			break;
		case 9:
			Nw58((Button)b7B9);
			break;
		case 10:
			r0ML((Button)b7B9);
			break;
		case 11:
			Yi5g((Button)b7B9);
			break;
		case 12:
			a2XG((Button)b7B9);
			break;
		case 13:
			p1QR((Button)b7B9);
			break;
		case 14:
			Ek43((Button)b7B9);
			break;
		case 15:
			a4TF((Label)b7B9);
			break;
		case 16:
			Bw0d((RadioButton)b7B9);
			break;
		case 17:
			x3RM((RadioButton)b7B9);
			break;
		case 18:
			Ri7o((Label)b7B9);
			break;
		case 19:
			w4NA((TextBox)b7B9);
			break;
		case 20:
			c0YN((ComboBox)b7B9);
			break;
		default:
			m = true;
			break;
		}
	}
}
