using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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

namespace s5R;

[DesignerGenerated]
public class Te1 : Window, IComponentConnector
{
	private int index;

	private Button _buttonSave;

	private Button _btnmovenext;

	private Button _btnmovelast;

	private Button _btnprevious;

	private TextBox _txtname;

	private Label _lblstring;

	internal DataTable K;

	internal Button q;

	internal Button C;

	internal Button p;

	internal Button J;

	internal Button l;

	internal Button g;

	internal TextBox b;

	internal TextBox Y;

	internal bool e;

	public Te1()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(y4R));
		index = 0;
		DataTable dataTable = (K = new DataTable());
		Ay8();
	}

	private void Ja5(object sender, RoutedEventArgs e)
	{
		a7K().set_Text("");
		Ze8().set_Text("");
		Yo7().set_Text("");
		index = checked(K.Rows.Count - 1);
		Br1(index);
	}

	public void Br1(int Jc8)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)Zz7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Nurse_Details");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(K);
		DataTable k = K;
		try
		{
			int num = Conversions.ToInteger(k.Rows[Jc8][0]);
			if (num == 0)
			{
				a7K().set_Text(Conversions.ToString(0));
			}
			else
			{
				int num2 = checked(1 + num + 100);
				a7K().set_Text(Conversions.ToString(num2));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		k = null;
	}

	private void n3F(object sender, RoutedEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)Zz7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("insert into Nurse_Details(Nurse_employment_No,Nurse_Name,Department) Values\n('" + a7K().get_Text() + "','" + Ze8().get_Text() + "','" + Yo7().get_Text() + "')");
			val2.ExecuteNonQuery();
			MessageBox.Show("Nurse Registered Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void As2(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Employment. No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Zz7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Nurse_Details where Nurse_employment_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			val4.Read();
			Ze8().set_Text(Conversions.ToString(val4.GetValue(1)));
			Yo7().set_Text(Conversions.ToString(val4.GetValue(2)));
			a7K().set_Text(Conversions.ToString(val4.GetValue(0)));
			val4 = null;
			val3.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Ag7(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)Zz7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("update Nurse_Details set Nurse_employment_No='" + a7K().get_Text() + "',Nurse_Name='" + Ze8().get_Text() + "',Department='" + Yo7().get_Text() + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show("Nurse Updates Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Sx4(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Invalid comparison between Unknown and I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Nurse ID to Delete", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Zz7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Nurse_Details where Nurse_employment_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		try
		{
			SqlDataReader val4 = val3;
			val4.Read();
			Ze8().set_Text(Conversions.ToString(val4.GetValue(1)));
			Yo7().set_Text(Conversions.ToString(val4.GetValue(2)));
			a7K().set_Text(Conversions.ToString(val4.GetValue(0)));
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
			val2.set_CommandText("Delete from Nurse_Details where Nurse_employment_No='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show("its been a pleasure Freeing up some space, Delete Succesfull");
			val.Close();
		}
	}

	public void Xi6(int Az6)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = Conversions.ToString(((ContentControl)Zz7()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Nurse_Details");
		SqlDataAdapter val3 = new SqlDataAdapter(val2);
		((DbDataAdapter)(object)val3).Fill(K);
		DataTable k = K;
		try
		{
			Ze8().set_Text(k.Rows[Az6][1].ToString());
			Yo7().set_Text(k.Rows[Az6][2].ToString());
			a7K().set_Text(k.Rows[Az6][0].ToString());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		k = null;
	}

	private void c0D(object sender, RoutedEventArgs e)
	{
		checked
		{
			index++;
			Xi6(index);
		}
	}

	internal static string[] Sc7()
	{
		checked
		{
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				string[] array = (string[])NewLateBinding.LateGet(c4L.mDic["o"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				string[] array2 = array;
				foreach (string item in array2)
				{
					list.Add(item);
				}
				string[] array3 = new string[list.Count - 1 + 1];
				int num2 = array3.Length - 1;
				for (num = 0; num <= num2; num++)
				{
					array3[num] = list[num];
				}
				return array3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Af0(object sender, RoutedEventArgs e)
	{
		checked
		{
			index--;
			Xi6(index);
		}
	}

	private void d9J(object sender, RoutedEventArgs e)
	{
		index = 0;
		Xi6(index);
	}

	private void j3S(object sender, RoutedEventArgs e)
	{
		index = checked(K.Rows.Count - 1);
		Xi6(index);
	}

	private void a3N(object sender, RoutedEventArgs e)
	{
		Nq6 nq = new Nq6();
		((Window)nq).Show();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		((Window)nq).set_Title("Nurse Details Report");
		NewLateBinding.LateCall(objectValue, (Type)null, "Load", new object[1] { "..\\\\Ripoti_Nurses.rpt" }, (string[])null, (Type[])null, (bool[])null, true);
		nq.Ym4().get_ViewerCore().set_ReportSource(RuntimeHelpers.GetObjectValue(objectValue));
	}

	private void y4R(object sender, RoutedEventArgs e)
	{
		try
		{
			index = K.Rows.Count;
			Xi6(index);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	internal virtual Button Jw0()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hc9(Button Wk4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Ja5);
		Button val2 = q;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (q = Wk4);
		val2 = q;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button g7W()
	{
		return _buttonSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ed0(Button g0Z)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(n3F);
		Button buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).remove_Click(val);
		}
		_buttonSave = g0Z;
		buttonSave = _buttonSave;
		if (buttonSave != null)
		{
			((ButtonBase)buttonSave).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button p4L()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hn6(Button Co0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Ag7);
		Button c = C;
		if (c != null)
		{
			((ButtonBase)c).remove_Click(val);
		}
		Button val2 = (C = Co0);
		c = C;
		if (c != null)
		{
			((ButtonBase)c).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Xa4()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7T(Button z2Q)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(As2);
		Button val2 = p;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (p = z2Q);
		val2 = p;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Zi5()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5E(Button c5A)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Sx4);
		Button j = J;
		if (j != null)
		{
			((ButtonBase)j).remove_Click(val);
		}
		Button val2 = (J = c5A);
		j = J;
		if (j != null)
		{
			((ButtonBase)j).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Eo7()
	{
		return _btnmovenext;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9Z(Button Hx8)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(c0D);
		Button btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).remove_Click(val);
		}
		_btnmovenext = Hx8;
		btnmovenext = _btnmovenext;
		if (btnmovenext != null)
		{
			((ButtonBase)btnmovenext).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button f4B()
	{
		return _btnmovelast;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7Z(Button Ew5)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(j3S);
		Button btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).remove_Click(val);
		}
		_btnmovelast = Ew5;
		btnmovelast = _btnmovelast;
		if (btnmovelast != null)
		{
			((ButtonBase)btnmovelast).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button s1Z()
	{
		return _btnprevious;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sc0(Button b1F)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Af0);
		Button btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).remove_Click(val);
		}
		_btnprevious = b1F;
		btnprevious = _btnprevious;
		if (btnprevious != null)
		{
			((ButtonBase)btnprevious).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Fg7()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kf0(Button Qx9)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(d9J);
		Button val2 = l;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (l = Qx9);
		val2 = l;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button g7A()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4W(Button Sj2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(a3N);
		Button val2 = g;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (g = Sj2);
		val2 = g;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual TextBox Ze8()
	{
		return _txtname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw5(TextBox Rq5)
	{
		_txtname = Rq5;
	}

	[SpecialName]
	internal virtual TextBox Yo7()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Es2(TextBox Dn4)
	{
		TextBox val = (b = Dn4);
	}

	[SpecialName]
	internal virtual TextBox a7K()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hp0(TextBox Gq6)
	{
		TextBox val = (Y = Gq6);
	}

	[SpecialName]
	internal virtual Label Zz7()
	{
		return _lblstring;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ww6(Label e0F)
	{
		_lblstring = e0F;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Ay8()
	{
		if (!e)
		{
			e = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/nursedetails.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void m3K(int s5Q, object d4K)
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
		switch (s5Q)
		{
		case 1:
			Hc9((Button)d4K);
			break;
		case 2:
			Ed0((Button)d4K);
			break;
		case 3:
			Hn6((Button)d4K);
			break;
		case 4:
			k7T((Button)d4K);
			break;
		case 5:
			i5E((Button)d4K);
			break;
		case 6:
			f9Z((Button)d4K);
			break;
		case 7:
			a7Z((Button)d4K);
			break;
		case 8:
			Sc0((Button)d4K);
			break;
		case 9:
			Kf0((Button)d4K);
			break;
		case 10:
			g4W((Button)d4K);
			break;
		case 11:
			Pw5((TextBox)d4K);
			break;
		case 12:
			Es2((TextBox)d4K);
			break;
		case 13:
			Hp0((TextBox)d4K);
			break;
		case 14:
			Ww6((Label)d4K);
			break;
		default:
			e = true;
			break;
		}
	}
}
