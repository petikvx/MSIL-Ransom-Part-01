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
using Je8;
using Microsoft.VisualBasic.CompilerServices;

namespace Ky21;

[DesignerGenerated]
public class a3P4 : Window, IComponentConnector
{
	private Label _stringconn;

	private ComboBox _cboempno;

	private PasswordBox _txtpassword;

	private bool _contentLoaded;

	internal ComboBox q;

	internal Button k;

	public a3P4()
	{
		Tb54();
	}

	private void e7NQ(object sender, MouseEventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		((ItemsControl)t5E3()).get_Items().Clear();
		string text = Conversions.ToString(((ContentControl)Hm0c()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		new SqlCommand();
		string text2 = w1NQ().get_Text();
		switch (text2)
		{
		case "Management":
			try
			{
				val2.set_Connection(val);
				val.Open();
				val2.set_CommandText("Select * from Login_Details where CONVERT(VARCHAR, User_Type)='" + text2 + "'");
				SqlDataReader val3 = val2.ExecuteReader();
				SqlDataReader val8 = val3;
				while (val8.Read())
				{
					((ItemsControl)t5E3()).get_Items().Add(RuntimeHelpers.GetObjectValue(val8.GetValue(2)));
				}
				val8 = null;
				val3.Close();
				break;
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
				break;
			}
		case "Receptionist":
			try
			{
				val2.set_Connection(val);
				val.Open();
				val2.set_CommandText("Select * from Login_Details where CONVERT(VARCHAR, User_Type)='" + text2 + "'");
				SqlDataReader val3 = val2.ExecuteReader();
				SqlDataReader val7 = val3;
				while (val7.Read())
				{
					((ItemsControl)t5E3()).get_Items().Add(RuntimeHelpers.GetObjectValue(val7.GetValue(2)));
				}
				val7 = null;
				val3.Close();
				break;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
				break;
			}
		case "Billing Officer":
			try
			{
				val2.set_Connection(val);
				val.Open();
				val2.set_CommandText("Select * from Login_Details where CONVERT(VARCHAR, User_Type)='" + text2 + "'");
				SqlDataReader val3 = val2.ExecuteReader();
				SqlDataReader val6 = val3;
				while (val6.Read())
				{
					((ItemsControl)t5E3()).get_Items().Add(RuntimeHelpers.GetObjectValue(val6.GetValue(2)));
				}
				val6 = null;
				val3.Close();
				break;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				break;
			}
		case "Nurse":
			try
			{
				val2.set_Connection(val);
				val.Open();
				val2.set_CommandText("Select * from Login_Details where CONVERT(VARCHAR, User_Type)='" + text2 + "'");
				SqlDataReader val3 = val2.ExecuteReader();
				SqlDataReader val5 = val3;
				while (val5.Read())
				{
					t5E3().set_Text("");
					((ItemsControl)t5E3()).get_Items().Add(RuntimeHelpers.GetObjectValue(val5.GetValue(2)));
				}
				val5 = null;
				val3.Close();
				break;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				break;
			}
		case "Doctor":
			try
			{
				val2.set_Connection(val);
				val.Open();
				val2.set_CommandText("Select * from Login_Details where CONVERT(VARCHAR, User_Type)='" + text2 + "'");
				SqlDataReader val3 = val2.ExecuteReader();
				SqlDataReader val4 = val3;
				while (val4.Read())
				{
					((ItemsControl)t5E3()).get_Items().Add(RuntimeHelpers.GetObjectValue(val4.GetValue(2)));
				}
				val4 = null;
				val3.Close();
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	private void Zr59(object sender, RoutedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		string text = Conversions.ToString(((ContentControl)Hm0c()).get_Content());
		SqlConnection val = new SqlConnection(text);
		SqlCommand val2 = new SqlCommand();
		try
		{
			string text2 = w1NQ().get_Text();
			string text3 = t5E3().get_Text();
			string password = Gc24().get_Password();
			val2.set_Connection(val);
			val.Open();
			val2.set_CommandText("Select * from Login_Details where CONVERT(VARCHAR, User_Type)='" + text2 + "' AND CONVERT(VARCHAR, EmploymentNo)='" + text3 + "'");
			SqlDataReader val3 = val2.ExecuteReader();
			while (val3.Read())
			{
				try
				{
					string text4 = Conversions.ToString(val3.GetValue(1));
					if (Operators.CompareString(text4, password, false) != 0)
					{
						MessageBox.Show("Wrong Password,Try again", "Login Form", (MessageBoxButton)1);
						continue;
					}
					MessageBox.Show("Login Succesful", "Login Form", (MessageBoxButton)1);
					t0Q t0Q = new t0Q();
					((Window)t0Q).Show();
					((ContentControl)t0Q.q7Z()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)Hm0c()).get_Content()));
					switch (text2)
					{
					case "Management":
						((UIElement)t0Q.Pt7()).set_IsEnabled(true);
						((UIElement)t0Q.Tb4()).set_IsEnabled(true);
						((UIElement)t0Q.p2P()).set_IsEnabled(true);
						((UIElement)t0Q.m4C()).set_IsEnabled(true);
						((UIElement)t0Q.Sg5()).set_IsEnabled(true);
						break;
					case "Doctor":
						((UIElement)t0Q.r3D()).set_IsEnabled(true);
						break;
					case "Nurse":
						((UIElement)t0Q.Cj8()).set_IsEnabled(true);
						break;
					case "Receptionist":
						((UIElement)t0Q.Ly1()).set_IsEnabled(true);
						((UIElement)t0Q.z0E()).set_IsEnabled(true);
						break;
					case "Billing Officer":
						((UIElement)t0Q.w7R()).set_IsEnabled(true);
						break;
					}
					((Window)this).Hide();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	internal virtual Label Hm0c()
	{
		return _stringconn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8TN(Label t9AG)
	{
		_stringconn = t9AG;
	}

	[SpecialName]
	internal virtual ComboBox t5E3()
	{
		return _cboempno;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tw30(ComboBox Pn1a)
	{
		_cboempno = Pn1a;
	}

	[SpecialName]
	internal virtual PasswordBox Gc24()
	{
		return _txtpassword;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6A9(PasswordBox Nj91)
	{
		_txtpassword = Nj91;
	}

	[SpecialName]
	internal virtual ComboBox w1NQ()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6F8(ComboBox p9L3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MouseEventHandler val = new MouseEventHandler(e7NQ);
		ComboBox val2 = q;
		if (val2 != null)
		{
			((UIElement)val2).remove_MouseLeave(val);
		}
		ComboBox val3 = (q = p9L3);
		val2 = q;
		if (val2 != null)
		{
			((UIElement)val2).add_MouseLeave(val);
		}
	}

	[SpecialName]
	internal virtual Button Hm18()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q6KY(Button Xy4q)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Zr59);
		Button val2 = k;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (k = Xy4q);
		val2 = k;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Tb54()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/login.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Cw7i(int t3A5, object x6JR)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		switch (t3A5)
		{
		case 1:
			n8TN((Label)x6JR);
			break;
		case 2:
			Tw30((ComboBox)x6JR);
			break;
		case 3:
			r6A9((PasswordBox)x6JR);
			break;
		case 4:
			g6F8((ComboBox)x6JR);
			break;
		case 5:
			q6KY((Button)x6JR);
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
