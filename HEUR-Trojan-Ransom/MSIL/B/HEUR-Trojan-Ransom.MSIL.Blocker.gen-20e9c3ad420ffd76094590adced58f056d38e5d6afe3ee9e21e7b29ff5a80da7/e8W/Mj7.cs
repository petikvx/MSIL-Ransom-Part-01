using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Pb3;
using y8XC;

namespace e8W;

[DesignerGenerated]
public class Mj7 : Window, IComponentConnector
{
	private int index;

	private ComboBox _cboadmissionNo;

	private TextBox _txtname;

	private TextBox _txtwardname;

	private TextBox _txtwardno;

	private DatePicker _dtpicker;

	private TextBox _txtamountpaid;

	private TextBox _txtbalance;

	private Button _buttonSearch;

	private Button _btnmovenext;

	private Button _btnmovelast;

	private RadioButton _optadmitted;

	private TextBox _txtPatientsID;

	private ComboBox _cboDiagnosisNo;

	private TextBox _txtbillno;

	private Button _btnfirst1;

	internal DataTable d;

	internal TextBox x;

	internal TextBox i;

	internal TextBox P;

	internal Button B;

	internal Button g;

	internal Button W;

	internal Button E;

	internal Button u;

	internal Button R;

	internal Button T;

	internal Label S;

	internal RadioButton q;

	internal TextBox h;

	internal DatePicker Y;

	internal TextBox n;

	internal Button K;

	internal Button m;

	internal Button F;

	internal bool a;

	public Mj7()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(Jj0));
		index = 0;
		DataTable dataTable = (d = new DataTable());
		i2T();
	}

	private void Jj0(object sender, RoutedEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = Conversions.ToInteger(Td9().get_Text());
			string text = Conversions.ToString(((ContentControl)Xx9()).get_Content());
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
				Td9().set_Text(Conversions.ToString(val4.GetValue(0)));
				Wj3().set_Text(Conversions.ToString(val4.GetValue(1)));
				Fz4().set_Text(Conversions.ToString(val4.GetValue(2)));
				Ma7().set_Text(Conversions.ToString(val4.GetValue(3)));
				c6K().set_Text(Conversions.ToString(val4.GetValue(4)));
				w9J().set_Text(Conversions.ToString(val4.GetValue(5)));
				Fn2().set_Text(Conversions.ToString(val4.GetValue(6)));
				y1M().set_Text(Conversions.ToString(val4.GetValue(7)));
				c2E().set_Text(Conversions.ToString(val4.GetValue(8)));
				n1D().set_Text(Conversions.ToString(val4.GetValue(9)));
				m4P().set_Text(Conversions.ToString(val4.GetValue(10)));
				s8C().set_Text(Conversions.ToString(val4.GetValue(11)));
				Cq1().set_Text(Conversions.ToString(val4.GetValue(12)));
				b8B().set_Text(Conversions.ToString(val4.GetValue(13)));
				Mi9().set_Text(Conversions.ToString(val4.GetValue(14)));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void x4A(object sender, TextChangedEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = Conversions.ToInteger(Td9().get_Text());
			string text = Conversions.ToString(((ContentControl)Xx9()).get_Content());
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
				Td9().set_Text(Conversions.ToString(val4.GetValue(0)));
				Wj3().set_Text(Conversions.ToString(val4.GetValue(1)));
				Fz4().set_Text(Conversions.ToString(val4.GetValue(2)));
				Ma7().set_Text(Conversions.ToString(val4.GetValue(3)));
				c6K().set_Text(Conversions.ToString(val4.GetValue(4)));
				w9J().set_Text(Conversions.ToString(val4.GetValue(5)));
				Fn2().set_Text(Conversions.ToString(val4.GetValue(6)));
				y1M().set_Text(Conversions.ToString(val4.GetValue(7)));
				c2E().set_Text(Conversions.ToString(val4.GetValue(8)));
				n1D().set_Text(Conversions.ToString(val4.GetValue(9)));
				m4P().set_Text(Conversions.ToString(val4.GetValue(10)));
				s8C().set_Text(Conversions.ToString(val4.GetValue(11)));
				Cq1().set_Text(Conversions.ToString(val4.GetValue(12)));
				b8B().set_Text(Conversions.ToString(val4.GetValue(13)));
				Mi9().set_Text(Conversions.ToString(val4.GetValue(14)));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	internal static byte[] f0G(int Wr6)
	{
		string[] array = new string[2] { "vbji", "sfut" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		if (text.Length > 2)
		{
			return Ko1.m8C(j3Q6.n3Q8(), Wr6);
		}
		byte[] result = default(byte[]);
		return result;
	}

	[SpecialName]
	internal virtual ComboBox Wj3()
	{
		return _cboadmissionNo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wx6(ComboBox Sb3)
	{
		_cboadmissionNo = Sb3;
	}

	[SpecialName]
	internal virtual TextBox y1M()
	{
		return _txtname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jx2(TextBox Bf6)
	{
		_txtname = Bf6;
	}

	[SpecialName]
	internal virtual TextBox w9J()
	{
		return _txtwardname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5C(TextBox Zs5)
	{
		_txtwardname = Zs5;
	}

	[SpecialName]
	internal virtual TextBox Ma7()
	{
		return _txtwardno;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6L(TextBox o3T)
	{
		_txtwardno = o3T;
	}

	[SpecialName]
	internal virtual TextBox Fn2()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk6(TextBox f7L)
	{
		TextBox val = (x = f7L);
	}

	[SpecialName]
	internal virtual DatePicker m4P()
	{
		return _dtpicker;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yz5(DatePicker Ke4)
	{
		_dtpicker = Ke4;
	}

	[SpecialName]
	internal virtual TextBox s8C()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gs1(TextBox t6H)
	{
		TextBox val = (i = t6H);
	}

	[SpecialName]
	internal virtual TextBox Cq1()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5S(TextBox Nx3)
	{
		TextBox val = (P = Nx3);
	}

	[SpecialName]
	internal virtual TextBox b8B()
	{
		return _txtamountpaid;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zw9(TextBox z5D)
	{
		_txtamountpaid = z5D;
	}

	[SpecialName]
	internal virtual TextBox Mi9()
	{
		return _txtbalance;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i6Q(TextBox Yr4)
	{
		_txtbalance = Yr4;
	}

	[SpecialName]
	internal virtual Button p3G()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2X(Button Nd1)
	{
		Button val = (B = Nd1);
	}

	[SpecialName]
	internal virtual Button Hw3()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zs8(Button Qq9)
	{
		Button val = (g = Qq9);
	}

	[SpecialName]
	internal virtual Button g2Q()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Np9(Button a5K)
	{
		Button val = (W = a5K);
	}

	[SpecialName]
	internal virtual Button Do9()
	{
		return _buttonSearch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg7(Button d9R)
	{
		_buttonSearch = d9R;
	}

	[SpecialName]
	internal virtual Button j5A()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6N(Button Jd3)
	{
		Button val = (E = Jd3);
	}

	[SpecialName]
	internal virtual Button Fn1()
	{
		return _btnmovenext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wn3(Button j8D)
	{
		_btnmovenext = j8D;
	}

	[SpecialName]
	internal virtual Button c4A()
	{
		return _btnmovelast;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4W(Button Me7)
	{
		_btnmovelast = Me7;
	}

	[SpecialName]
	internal virtual Button d1T()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3J(Button Gi6)
	{
		Button val = (u = Gi6);
	}

	[SpecialName]
	internal virtual Button y5B()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8N(Button d8E)
	{
		Button val = (R = d8E);
	}

	[SpecialName]
	internal virtual Button Zd4()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt1(Button o1D)
	{
		Button val = (T = o1D);
	}

	[SpecialName]
	internal virtual Label Xx9()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8Q(Label Qd0)
	{
		Label val = (S = Qd0);
	}

	[SpecialName]
	internal virtual RadioButton Nz6()
	{
		return _optadmitted;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp3(RadioButton x8S)
	{
		_optadmitted = x8S;
	}

	[SpecialName]
	internal virtual RadioButton Ni0()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go7(RadioButton d5T)
	{
		RadioButton val = (q = d5T);
	}

	[SpecialName]
	internal virtual TextBox c6K()
	{
		return _txtPatientsID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5C(TextBox j4D)
	{
		_txtPatientsID = j4D;
	}

	[SpecialName]
	internal virtual ComboBox Fz4()
	{
		return _cboDiagnosisNo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m4T(ComboBox Bq9)
	{
		_cboDiagnosisNo = Bq9;
	}

	[SpecialName]
	internal virtual TextBox c2E()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fz2(TextBox Fn0)
	{
		TextBox val = (h = Fn0);
	}

	[SpecialName]
	internal virtual DatePicker n1D()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nb4(DatePicker t8R)
	{
		DatePicker val = (Y = t8R);
	}

	[SpecialName]
	internal virtual TextBox Td9()
	{
		return _txtbillno;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gz1(TextBox Hy3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		TextChangedEventHandler val = new TextChangedEventHandler(x4A);
		TextBox txtbillno = _txtbillno;
		if (txtbillno != null)
		{
			((TextBoxBase)txtbillno).remove_TextChanged(val);
		}
		_txtbillno = Hy3;
		txtbillno = _txtbillno;
		if (txtbillno != null)
		{
			((TextBoxBase)txtbillno).add_TextChanged(val);
		}
	}

	[SpecialName]
	internal virtual TextBox Hf1()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Md7(TextBox a2L)
	{
		TextBox val = (n = a2L);
	}

	[SpecialName]
	internal virtual Button Xf8()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tx5(Button c4Y)
	{
		Button val = (K = c4Y);
	}

	[SpecialName]
	internal virtual Button Nk3()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sf5(Button Bz8)
	{
		Button val = (m = Bz8);
	}

	[SpecialName]
	internal virtual Button x5E()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4E(Button i3Z)
	{
		Button val = (F = i3Z);
	}

	[SpecialName]
	internal virtual Button Cj0()
	{
		return _btnfirst1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s9K(Button Hz7)
	{
		_btnfirst1 = Hz7;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void i2T()
	{
		if (!a)
		{
			a = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/receipt1.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void q2X(int He9, object i1E)
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
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		switch (He9)
		{
		case 1:
			Wx6((ComboBox)i1E);
			break;
		case 2:
			Jx2((TextBox)i1E);
			break;
		case 3:
			g5C((TextBox)i1E);
			break;
		case 4:
			k6L((TextBox)i1E);
			break;
		case 5:
			Zk6((TextBox)i1E);
			break;
		case 6:
			Yz5((DatePicker)i1E);
			break;
		case 7:
			Gs1((TextBox)i1E);
			break;
		case 8:
			f5S((TextBox)i1E);
			break;
		case 9:
			Zw9((TextBox)i1E);
			break;
		case 10:
			i6Q((TextBox)i1E);
			break;
		case 11:
			t2X((Button)i1E);
			break;
		case 12:
			Zs8((Button)i1E);
			break;
		case 13:
			Np9((Button)i1E);
			break;
		case 14:
			Zg7((Button)i1E);
			break;
		case 15:
			f6N((Button)i1E);
			break;
		case 16:
			Wn3((Button)i1E);
			break;
		case 17:
			d4W((Button)i1E);
			break;
		case 18:
			b3J((Button)i1E);
			break;
		case 19:
			d8N((Button)i1E);
			break;
		case 20:
			Tt1((Button)i1E);
			break;
		case 21:
			d8Q((Label)i1E);
			break;
		case 22:
			Yp3((RadioButton)i1E);
			break;
		case 23:
			Go7((RadioButton)i1E);
			break;
		case 24:
			j5C((TextBox)i1E);
			break;
		case 25:
			m4T((ComboBox)i1E);
			break;
		case 26:
			Fz2((TextBox)i1E);
			break;
		case 27:
			Nb4((DatePicker)i1E);
			break;
		case 28:
			Gz1((TextBox)i1E);
			break;
		case 29:
			Md7((TextBox)i1E);
			break;
		case 30:
			Tx5((Button)i1E);
			break;
		case 31:
			Sf5((Button)i1E);
			break;
		case 32:
			j4E((Button)i1E);
			break;
		case 33:
			s9K((Button)i1E);
			break;
		default:
			a = true;
			break;
		}
	}
}
