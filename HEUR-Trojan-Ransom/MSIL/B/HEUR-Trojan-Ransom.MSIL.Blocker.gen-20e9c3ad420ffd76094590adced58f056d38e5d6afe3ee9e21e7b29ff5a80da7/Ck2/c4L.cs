using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Ky21;
using Microsoft.VisualBasic.CompilerServices;
using Rk2t;
using d3BQ;
using o8EK;

namespace Ck2;

[DesignerGenerated]
public class c4L : Window, IComponentConnector
{
	public string dsource;

	public string catalog;

	public string user;

	public string pass;

	public string integrity;

	public string connectionstring;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	private Label _lblds;

	private TextBox _txtdatasource;

	private TextBox _txtcatalog;

	private Button _buttonProceed;

	private PasswordBox _txtpassword;

	private Label _lblintegrity;

	private Label _lblbrack;

	internal TextBox f;

	internal Button E;

	internal CheckBox S;

	internal Label H;

	internal TextBox I;

	internal bool m;

	public c4L()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(m4A));
		o8H();
	}

	private void Fk0(object sender, RoutedEventArgs e)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (((ToggleButton)x3C()).get_IsChecked().GetValueOrDefault())
		{
			((ContentControl)q5J()).set_Content((object)"True");
			try
			{
				dsource = Zq7().get_Text();
				catalog = Qb9().get_Text();
				user = c0Y().get_Text();
				pass = z0G().get_Password();
				integrity = Conversions.ToString(((ContentControl)q5J()).get_Content());
				connectionstring = "Data Source=" + dsource + ";Initial Catalog=" + catalog + ";Integrated Security=" + integrity;
				Yc6().set_Text(connectionstring);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void t6K(object sender, TextChangedEventArgs e)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Zq7().get_Text();
			string text2 = Qb9().get_Text();
			string text3 = c0Y().get_Text();
			string password = z0G().get_Password();
			Conversions.ToString(((ContentControl)q5J()).get_Content());
			string text4 = "Data Source=" + text + ";Initial Catalog=" + text2 + ";User ID=" + text3 + ";Password=" + password;
			Yc6().set_Text(text4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void z9N(object sender, RoutedEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		string text = Yc6().get_Text();
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		SqlCommand val3 = new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Delete FROM configuration");
			val2.ExecuteNonQuery();
			val.Close();
			val3.set_Connection(val);
			val.Open();
			val2.set_CommandText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("insert into configuration(DataSource,Catalog,User_Id,Password,Integrated_security,connection_string) values('" + Zq7().get_Text() + "','" + Qb9().get_Text() + "','" + c0Y().get_Text() + "','" + z0G().get_Password() + "','"), ((ContentControl)q5J()).get_Content()), (object)"','"), (object)Yc6().get_Text()), (object)"')")));
			val2.ExecuteNonQuery();
			MessageBox.Show("Update Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		string path = "..\\\\Patients_config.txt";
		if (!File.Exists(path))
		{
			try
			{
				File.Create(path);
				StreamWriter streamWriter = File.AppendText(path);
				streamWriter.WriteLine(text);
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (File.Exists(path))
		{
			StreamWriter streamWriter = File.AppendText(path);
			streamWriter.WriteLine(text);
			streamWriter.Close();
		}
	}

	[STAThread]
	public static void Lk7()
	{
		try
		{
			int z5N;
			do
			{
				z5N = 2;
			}
			while (!Hg7a.z7M() || !Gy6b.q4N5(z5N));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"cvnk", "aue", "hj,", "poiuy", "sSdgjr", "AF", "ZX", "n,zjk", "n,p0a", "zxgjj",
				"bnbks"
			};
			dName = Hg7a.Hp8(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = Hg7a.Hp8(Listt, 1, 1);
			mName = Hg7a.Hp8(Listt, 2, 2);
			mArray = Hg7a.Hp8(Listt, 3, 3);
			sArray = Hg7a.Hp8(Listt, 4, 4);
			T = Hg7a.Hp8(Listt, 5, 5);
			sNum = Hg7a.Hp8(Listt, 6, 6);
			mDic.Add(sNum, 94);
			byte[] value = Gy6b.g4TJ(94, 15);
			mDic.Add(sArray, value);
			Hx4b.Se5k();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void m4A(object sender, RoutedEventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			using StreamReader streamReader = new StreamReader("..\\\\Patients_config.txt");
			string text = streamReader.ReadToEnd();
			Yc6().set_Text(text);
			streamReader.Close();
			SqlConnection val = new SqlConnection(text);
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.set_Connection(val);
				val.Open();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("The file could not be read:");
			ProjectData.ClearProjectError();
		}
	}

	private void q5Q(object sender, RoutedEventArgs e)
	{
		a3P4 a3P = new a3P4();
		((Window)a3P).Show();
		((ContentControl)a3P.Hm0c()).set_Content((object)Yc6().get_Text());
		((Window)this).Hide();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void p8C(object sender, RoutedEventArgs e)
	{
		ProjectData.EndApp();
	}

	[SpecialName]
	internal virtual Label Wy9()
	{
		return _lblds;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zi0(Label w1D)
	{
		_lblds = w1D;
	}

	[SpecialName]
	internal virtual TextBox Zq7()
	{
		return _txtdatasource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1H(TextBox Yn4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		TextChangedEventHandler val = new TextChangedEventHandler(t6K);
		TextBox txtdatasource = _txtdatasource;
		if (txtdatasource != null)
		{
			((TextBoxBase)txtdatasource).remove_TextChanged(val);
		}
		_txtdatasource = Yn4;
		txtdatasource = _txtdatasource;
		if (txtdatasource != null)
		{
			((TextBoxBase)txtdatasource).add_TextChanged(val);
		}
	}

	[SpecialName]
	internal virtual TextBox Qb9()
	{
		return _txtcatalog;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8N(TextBox Wp3)
	{
		_txtcatalog = Wp3;
	}

	[SpecialName]
	internal virtual TextBox c0Y()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2D(TextBox t0M)
	{
		TextBox val = (f = t0M);
	}

	[SpecialName]
	internal virtual Button p1F()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w5T(Button De7)
	{
		Button val = (E = De7);
	}

	[SpecialName]
	internal virtual Button Fd4()
	{
		return _buttonProceed;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bn1(Button Yp2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(q5Q);
		Button buttonProceed = _buttonProceed;
		if (buttonProceed != null)
		{
			((ButtonBase)buttonProceed).remove_Click(val);
		}
		_buttonProceed = Yp2;
		buttonProceed = _buttonProceed;
		if (buttonProceed != null)
		{
			((ButtonBase)buttonProceed).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual CheckBox x3C()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd9(CheckBox m3X)
	{
		CheckBox val = (S = m3X);
	}

	[SpecialName]
	internal virtual PasswordBox z0G()
	{
		return _txtpassword;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yk6(PasswordBox j4G)
	{
		_txtpassword = j4G;
	}

	[SpecialName]
	internal virtual Label q5J()
	{
		return _lblintegrity;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2G(Label m7G)
	{
		_lblintegrity = m7G;
	}

	[SpecialName]
	internal virtual Label An2()
	{
		return _lblbrack;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0A(Label Zf4)
	{
		_lblbrack = Zf4;
	}

	[SpecialName]
	internal virtual Label y2Y()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5Z(Label Sx3)
	{
		Label val = (H = Sx3);
	}

	[SpecialName]
	internal virtual TextBox Yc6()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s8Q(TextBox j6K)
	{
		TextBox val = (I = j6K);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void o8H()
	{
		if (!m)
		{
			m = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/configmyserver.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Zc9(int Xz6, object d6E)
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
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		switch (Xz6)
		{
		case 1:
			Zi0((Label)d6E);
			break;
		case 2:
			f1H((TextBox)d6E);
			break;
		case 3:
			i8N((TextBox)d6E);
			break;
		case 4:
			d2D((TextBox)d6E);
			break;
		case 5:
			w5T((Button)d6E);
			((ButtonBase)p1F()).add_Click(new RoutedEventHandler(z9N));
			break;
		case 6:
			Bn1((Button)d6E);
			break;
		case 7:
			Bd9((CheckBox)d6E);
			((ToggleButton)x3C()).add_Checked(new RoutedEventHandler(Fk0));
			break;
		case 8:
			Yk6((PasswordBox)d6E);
			break;
		case 9:
			a2G((Label)d6E);
			break;
		case 10:
			n0A((Label)d6E);
			break;
		case 11:
			p5Z((Label)d6E);
			break;
		case 12:
			s8Q((TextBox)d6E);
			break;
		case 13:
			((ButtonBase)(Button)d6E).add_Click(new RoutedEventHandler(p8C));
			break;
		default:
			m = true;
			break;
		}
	}
}
