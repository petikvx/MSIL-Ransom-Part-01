using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Je8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d3BQ;
using k9F;

namespace Rk2t;

[DesignerGenerated]
public class Hg7a : Window, IComponentConnector
{
	private int index;

	private TextBox _txtwardname;

	private TextBox _txtwardno;

	private Button _buttonAdd;

	private Button _buttonSave;

	private Button _buttonUpdate;

	private Button _btnmovelast;

	private Button _btndisplay;

	private Label _lblstring;

	private bool _contentLoaded;

	internal DataTable M;

	internal TextBox N;

	internal Button u;

	internal Button r;

	internal Button x;

	internal Button a;

	internal Button S;

	public Hg7a()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(Qz0));
		index = 0;
		DataTable dataTable = (M = new DataTable());
		w2T();
	}

	private void m1LC(object sender, RoutedEventArgs e)
	{
		e6K().set_Text("");
		Yt6().set_Text("");
		a6X().set_Text("");
		index = checked(M.Rows.Count - 1);
		g7F2(index);
	}

	public void g7F2(int n6HP)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)a6F()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Wards");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(M);
		DataTable m = M;
		try
		{
			int num = Conversions.ToInteger(m.Rows[n6HP][0]);
			if (num == 0)
			{
				e6K().set_Text(Conversions.ToString(0));
			}
			else
			{
				int num2 = checked(1 + num);
				e6K().set_Text(Conversions.ToString(num2));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		m = null;
	}

	private void m3AF(object sender, RoutedEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)a6F()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("insert into Wards(Ward_No,Ward_Name,No_of_Beds) Values\n('" + e6K().get_Text() + "','" + Yt6().get_Text() + "','" + a6X().get_Text() + "')");
		val2.ExecuteNonQuery();
		MessageBox.Show("Ward Registered Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
		val.Close();
		index = checked(M.Rows.Count - 1);
		Sy7(index);
	}

	private void De25(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Ward. No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)a6F()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Wards where Ward_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		SqlDataReader val4 = val3;
		val4.Read();
		e6K().set_Text(Conversions.ToString(val4.GetValue(0)));
		Yt6().set_Text(Conversions.ToString(val4.GetValue(2)));
		a6X().set_Text(Conversions.ToString(val4.GetValue(1)));
		val4 = null;
		val3.Close();
	}

	private void p6C5(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)a6F()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("update Wards set Ward_No='" + e6K().get_Text() + "',Ward_Name='" + Yt6().get_Text() + "',No_of_Beds='" + a6X().get_Text() + "'");
		val2.ExecuteNonQuery();
		MessageBox.Show("Ward Updates Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
		val.Close();
	}

	private void a8YG(object sender, RoutedEventArgs e)
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
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Ward No to Delete", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)a6F()).get_Content());
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
			e6K().set_Text(Conversions.ToString(val4.GetValue(0)));
			Yt6().set_Text(Conversions.ToString(val4.GetValue(2)));
			a6X().set_Text(Conversions.ToString(val4.GetValue(1)));
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
			val2.set_CommandText("Delete from Wards where Ward_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show("its been a pleasure Freeing up some space, Delete Succesfull");
			val.Close();
		}
	}

	internal static bool z7M()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string be5g in array2)
				{
					if (!Gy6b.Fr51(be5g))
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

	public void Sy7(int y3D)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)a6F()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Wards");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(M);
		DataTable m = M;
		try
		{
			e6K().set_Text(m.Rows[y3D][0].ToString());
			Yt6().set_Text(m.Rows[y3D][2].ToString());
			a6X().set_Text(m.Rows[y3D][1].ToString());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		m = null;
	}

	private void Ds8(object sender, RoutedEventArgs e)
	{
		checked
		{
			index++;
			Sy7(index);
		}
	}

	private void Co7(object sender, RoutedEventArgs e)
	{
		checked
		{
			index--;
			Sy7(index);
		}
	}

	private void Mm8(object sender, RoutedEventArgs e)
	{
		index = 0;
		Sy7(index);
	}

	private void Dj1(object sender, RoutedEventArgs e)
	{
		index = checked(M.Rows.Count - 1);
		Sy7(index);
	}

	private void Js2(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		((Window)nq).set_Title("Ward Details");
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_Wards.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
	}

	private void Qz0(object sender, RoutedEventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			index = M.Rows.Count;
			Sy7(index);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	internal static string Hp8(string[] Jf1, int j3E, int Cb3)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = j3E; i <= Cb3; i = checked(i + 1))
		{
			stringBuilder.Append(Jf1[i]);
		}
		return stringBuilder.ToString();
	}

	[SpecialName]
	internal virtual TextBox Yt6()
	{
		return _txtwardname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2K(TextBox z0C)
	{
		_txtwardname = z0C;
	}

	[SpecialName]
	internal virtual TextBox e6K()
	{
		return _txtwardno;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9Y(TextBox r0J)
	{
		_txtwardno = r0J;
	}

	[SpecialName]
	internal virtual TextBox a6X()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ep1(TextBox g8L)
	{
		TextBox val = (N = g8L);
	}

	[SpecialName]
	internal virtual Button w8C()
	{
		return _buttonAdd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0N(Button s4X)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(m1LC);
		Button buttonAdd = _buttonAdd;
		if (buttonAdd != null)
		{
			((ButtonBase)buttonAdd).remove_Click(val);
		}
		_buttonAdd = s4X;
		buttonAdd = _buttonAdd;
		if (buttonAdd != null)
		{
			((ButtonBase)buttonAdd).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Bx0()
	{
		return _buttonSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8R(Button Zq1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(m3AF);
		Button buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).remove_Click(val);
		}
		_buttonSave = Zq1;
		buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button m4L()
	{
		return _buttonUpdate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dk0(Button Jc9)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(p6C5);
		Button buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).remove_Click(val);
		}
		_buttonUpdate = Jc9;
		buttonUpdate = _buttonUpdate;
		if (buttonUpdate != null)
		{
			((ButtonBase)buttonUpdate).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button s4G()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kf7(Button t6T)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(De25);
		Button val2 = u;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (u = t6T);
		val2 = u;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Xk1()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i2P(Button c2N)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(a8YG);
		Button val2 = r;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (r = c2N);
		val2 = r;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button We1()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0N(Button j1C)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Ds8);
		Button val2 = x;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (x = j1C);
		val2 = x;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button e0J()
	{
		return _btnmovelast;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lc6(Button q8Z)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Dj1);
		Button btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).remove_Click(val);
		}
		_btnmovelast = q8Z;
		btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Sg2()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6X(Button Sa3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Co7);
		Button val2 = a;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (a = Sa3);
		val2 = a;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Hm4()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fk9(Button Tg4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Mm8);
		Button s = S;
		if (s != null)
		{
			((ButtonBase)s).remove_Click(val);
		}
		Button val2 = (S = Tg4);
		s = S;
		if (s != null)
		{
			((ButtonBase)s).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Nm0()
	{
		return _btndisplay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nb6(Button j4T)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Js2);
		Button btndisplay = _btndisplay;
		if (btndisplay != null)
		{
			((ButtonBase)btndisplay).remove_Click(val);
		}
		_btndisplay = j4T;
		btndisplay = _btndisplay;
		if (btndisplay != null)
		{
			((ButtonBase)btndisplay).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Label a6F()
	{
		return _lblstring;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3A(Label Jk1)
	{
		_lblstring = Jk1;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void w2T()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/warddetails.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Xd3(int g9T, object w2L)
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
		switch (g9T)
		{
		case 1:
			d2K((TextBox)w2L);
			break;
		case 2:
			a9Y((TextBox)w2L);
			break;
		case 3:
			Ep1((TextBox)w2L);
			break;
		case 4:
			q0N((Button)w2L);
			break;
		case 5:
			r8R((Button)w2L);
			break;
		case 6:
			Dk0((Button)w2L);
			break;
		case 7:
			Kf7((Button)w2L);
			break;
		case 8:
			i2P((Button)w2L);
			break;
		case 9:
			n0N((Button)w2L);
			break;
		case 10:
			Lc6((Button)w2L);
			break;
		case 11:
			b6X((Button)w2L);
			break;
		case 12:
			Fk9((Button)w2L);
			break;
		case 13:
			Nb6((Button)w2L);
			break;
		case 14:
			c3A((Label)w2L);
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
