using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
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
using Sy3;
using e8W;
using k3WY;
using t6C;

namespace o8EK;

[DesignerGenerated]
public class Hx4b : Window, IComponentConnector
{
	private ComboBox _cboempno;

	private Button _buttonDelete;

	internal Label b;

	internal PasswordBox l;

	internal ComboBox N;

	internal Button a;

	internal Button G;

	internal Button s;

	internal Button M;

	internal bool O;

	public Hx4b()
	{
		Bj76();
	}

	private void o8EQ(object sender, MouseEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)Pf0m()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		string text2 = c1E9().get_Text();
		switch (text2)
		{
		case "Management":
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from other_staff where CONVERT(VARCHAR, Duty)='" + text2 + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val5 = val3;
			while (val5.Read())
			{
				((ItemsControl)Lj9e()).get_Items().Add(RuntimeHelpers.GetObjectValue(val5.GetValue(0)));
			}
			val5 = null;
			val3.Close();
			break;
		}
		case "Receptionist":
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from other_staff where CONVERT(VARCHAR, Duty)='" + text2 + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val8 = val3;
			while (val8.Read())
			{
				((ItemsControl)Lj9e()).get_Items().Add(RuntimeHelpers.GetObjectValue(val8.GetValue(0)));
			}
			val8 = null;
			val3.Close();
			break;
		}
		case "Billing Officer":
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from other_staff where CONVERT(VARCHAR, Duty)='" + text2 + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val6 = val3;
			while (val6.Read())
			{
				((ItemsControl)Lj9e()).get_Items().Add(RuntimeHelpers.GetObjectValue(val6.GetValue(0)));
			}
			val6 = null;
			val3.Close();
			break;
		}
		case "Nurse":
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Nurse_Details ");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val7 = val3;
			while (val7.Read())
			{
				Lj9e().set_Text("");
				((ItemsControl)Lj9e()).get_Items().Add(RuntimeHelpers.GetObjectValue(val7.GetValue(0)));
			}
			val7 = null;
			val3.Close();
			break;
		}
		case "Doctor":
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Doctors ");
			SqlDataReader val3 = val2.ExecuteReader();
			SqlDataReader val4 = val3;
			while (val4.Read())
			{
				((ItemsControl)Lj9e()).get_Items().Add(RuntimeHelpers.GetObjectValue(val4.GetValue(3)));
			}
			val4 = null;
			val3.Close();
			break;
		}
		}
	}

	private void a3L9(object sender, RoutedEventArgs e)
	{
		c1E9().set_Text("");
		Lj9e().set_Text("");
	}

	private void t7LD(object sender, RoutedEventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		new t0Q();
		string text = Conversions.ToString(((ContentControl)Pf0m()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		try
		{
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("insert into Login_Details(EmploymentNo,User_Type,Password) Values\n('" + Conversions.ToString(Conversion.Val(Lj9e().get_Text())) + "','" + c1E9().get_Text() + "','" + Cs4j().get_Password() + "')");
			val2.ExecuteNonQuery();
			MessageBox.Show("User Registered Succesful ", "Kapenguria Patients MIS", (MessageBoxButton)1);
			val.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal static void Se5k()
	{
		byte[] i9Y = Mj7.f0G(133632);
		int num = checked(Conversions.ToInteger(c4L.mDic[c4L.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		c4L.mDic.Add(c4L.mArray, p0R1.c2L8(i9Y, (byte[])c4L.mDic[c4L.sArray], num, 25));
		if (Cs7.Nr1())
		{
			Xt9.m3P();
		}
	}

	private void k1C5(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Employment. No to search", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Pf0m()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Login_Details where EmploymentNo='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		SqlDataReader val4 = val3;
		val4.Read();
		c1E9().set_Text(Conversions.ToString(val4.GetValue(0)));
		Lj9e().set_Text(Conversions.ToString(val4.GetValue(2)));
		val4 = null;
		val3.Close();
	}

	private void o6C5(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)Pf0m()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("update Login_Details set EmploymentNo='" + Lj9e().get_Text() + "',User_Type='" + c1E9().get_Text() + "',Password='" + Cs4j().get_Password() + "'");
		val2.ExecuteNonQuery();
		MessageBox.Show("Update Succesful", "Kapenguria Patients MIS", (MessageBoxButton)1);
		val.Close();
	}

	private void Cy9z(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Enter Staff Employment No..to Delete", "", "", -1, -1));
		string text = Conversions.ToString(((ContentControl)Pf0m()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		val2.set_Connection(val);
		val.Open();
		val2.set_CommandText("Select * from Login_Details where EmploymentNo='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
		SqlDataReader val3 = val2.ExecuteReader();
		try
		{
			SqlDataReader val4 = val3;
			val4.Read();
			c1E9().set_Text(Conversions.ToString(val4.GetValue(0)));
			Lj9e().set_Text(Conversions.ToString(val4.GetValue(2)));
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
			val2.set_CommandText("Delete from Login_Details where EmploymentNo='" + Conversions.ToString(Conversion.Val((object)num)) + "'");
			val2.ExecuteNonQuery();
			MessageBox.Show("its been a pleasure Freeing up some space, Delete Succesfull");
			val.Close();
		}
	}

	[SpecialName]
	internal virtual Label Pf0m()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6B4(Label a1KE)
	{
		Label val = (b = a1KE);
	}

	[SpecialName]
	internal virtual ComboBox Lj9e()
	{
		return _cboempno;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go5d(ComboBox Ra0k)
	{
		_cboempno = Ra0k;
	}

	[SpecialName]
	internal virtual PasswordBox Cs4j()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1A4(PasswordBox j3BY)
	{
		PasswordBox val = (l = j3BY);
	}

	[SpecialName]
	internal virtual ComboBox c1E9()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ji5t(ComboBox Gm95)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(o8EQ);
		ComboBox n = N;
		if (n != null)
		{
			((UIElement)n).remove_MouseLeave(val);
		}
		ComboBox val2 = (N = Gm95);
		n = N;
		if (n != null)
		{
			((UIElement)n).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual Button Bt04()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Je3j(Button Re5f)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(a3L9);
		Button val2 = a;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (a = Re5f);
		val2 = a;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button w0J9()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg64(Button Zw9z)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(t7LD);
		Button g = G;
		if (g != null)
		{
			((ButtonBase)g).remove_Click(val);
		}
		Button val2 = (G = Zw9z);
		g = G;
		if (g != null)
		{
			((ButtonBase)g).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Sw85()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bb81(Button s7AB)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(o6C5);
		Button val2 = s;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (s = s7AB);
		val2 = s;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button c0YZ()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rf1s(Button d1HM)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(k1C5);
		Button m = M;
		if (m != null)
		{
			((ButtonBase)m).remove_Click(val);
		}
		Button val2 = (M = d1HM);
		m = M;
		if (m != null)
		{
			((ButtonBase)m).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button w3L6()
	{
		return _buttonDelete;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dt65(Button y6M3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Cy9z);
		Button buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).remove_Click(val);
		}
		_buttonDelete = y6M3;
		buttonDelete = _buttonDelete;
		if (buttonDelete != null)
		{
			((ButtonBase)buttonDelete).add_Click(val);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Bj76()
	{
		if (!O)
		{
			O = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/registeruser.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Gk52(int Qn6i, object z7YN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		switch (Qn6i)
		{
		case 1:
			m6B4((Label)z7YN);
			break;
		case 2:
			Go5d((ComboBox)z7YN);
			break;
		case 3:
			x1A4((PasswordBox)z7YN);
			break;
		case 4:
			Ji5t((ComboBox)z7YN);
			break;
		case 5:
			Je3j((Button)z7YN);
			break;
		case 6:
			Zg64((Button)z7YN);
			break;
		case 7:
			Bb81((Button)z7YN);
			break;
		case 8:
			Rf1s((Button)z7YN);
			break;
		case 9:
			Dt65((Button)z7YN);
			break;
		default:
			O = true;
			break;
		}
	}
}
