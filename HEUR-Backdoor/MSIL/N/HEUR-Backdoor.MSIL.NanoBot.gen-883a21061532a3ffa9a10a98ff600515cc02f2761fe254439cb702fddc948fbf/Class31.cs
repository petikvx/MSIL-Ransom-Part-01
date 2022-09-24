using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

internal sealed class Class31
{
	private GForm0 gform0_0;

	private Class18 class18_0;

	public Class31(GForm0 gform0_1)
	{
		gform0_0 = gform0_1;
		class18_0 = new Class18(gform0_0);
	}

	public int method_0()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860096915), gform0_0.sqlConnection_0);
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text());
		int result = int.Parse(((DbCommand)(object)val).ExecuteScalar()!.ToString());
		((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		return result;
	}

	public void method_1()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860096936), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		gform0_0.listBox_2.get_Items().Clear();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				Class5 @class = new Class5();
				@class.method_1(((DbDataReader)(object)val2)[Class9.smethod_0(-860095497)].ToString());
				@class.method_3(((DbDataReader)(object)val2)[Class9.smethod_0(-860095850)].ToString());
				@class.method_5(((DbDataReader)(object)val2)[Class9.smethod_0(-860096990)].ToString() + Class9.smethod_0(-860096477) + ((DbDataReader)(object)val2)[Class9.smethod_0(-860096970)].ToString());
				@class.method_7(((DbDataReader)(object)val2)[Class9.smethod_0(-860097020)].ToString());
				gform0_0.listBox_2.get_Items().Add((object)@class);
			}
			gform0_0.int_3 = 0;
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
			((DbDataReader)(object)val2).Close();
			method_7();
		}
	}

	public void method_2()
	{
		gform0_0.int_3 = ((ListControl)gform0_0.listBox_2).get_SelectedIndex();
		method_3(null);
		((Control)gform0_0.button_6).set_Visible(true);
		((Control)gform0_0.button_8).set_Visible(true);
		((Control)gform0_0.button_12).set_Visible(false);
	}

	public void method_3(string string_0)
	{
		if (string_0 != null)
		{
			gform0_0.int_3 = -1;
			foreach (Class5 item in gform0_0.listBox_2.get_Items())
			{
				gform0_0.int_3++;
				if (item.method_0() == string_0)
				{
					((ListControl)gform0_0.listBox_2).set_SelectedIndex(gform0_0.int_3);
					break;
				}
			}
		}
		if (!((gform0_0.listBox_2.get_Items().get_Count() == 0) | (gform0_0.int_3 < 0)))
		{
			Class5 class2 = new Class5();
			class2 = (Class5)gform0_0.listBox_2.get_Items().get_Item(gform0_0.int_3);
			gform0_0.gcontrol1_0.method_2(class2.method_0());
			gform0_0.gcontrol1_0.method_3(class2.method_2());
			gform0_0.gcontrol1_0.method_4(class2.method_4());
			gform0_0.gcontrol1_0.method_5(class2.method_6() + Class9.smethod_0(-860096477) + class2.method_4());
		}
	}

	public void method_4()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)gform0_0.gcontrol1_0.comboBox_0).get_SelectedIndex() > -1)
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
			Class5 @class = new Class5();
			@class.method_1(gform0_0.gcontrol1_0.method_0().ToString());
			@class.method_3(gform0_0.gcontrol1_0.method_7());
			@class.method_7(gform0_0.gcontrol1_0.method_9());
			SqlCommand val = new SqlCommand();
			((DbCommand)(object)val).CommandText = Class9.smethod_0(-860096786);
			((DbParameterCollection)(object)val.get_Parameters()).Clear();
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860096708), (object)@class.method_0());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860096642), (object)@class.method_2());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860096871), (object)@class.method_6());
			val.set_Connection(gform0_0.sqlConnection_0);
			try
			{
				((DbCommand)(object)val).ExecuteNonQuery();
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
				return;
			}
			finally
			{
				((DbConnection)(object)gform0_0.sqlConnection_0).Close();
				method_1();
				method_3(@class.method_0());
			}
		}
		MessageBox.Show(Class9.smethod_0(-860097182));
		gform0_0.gcontrol1_0.method_11();
		method_1();
	}

	public void method_5()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)gform0_0.gcontrol1_0.comboBox_0).get_SelectedIndex() > -1)
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
			Class5 @class = new Class5();
			@class.method_1(gform0_0.gcontrol1_0.method_6());
			@class.method_3(gform0_0.gcontrol1_0.method_7());
			@class.method_7(gform0_0.gcontrol1_0.method_9());
			SqlCommand val = new SqlCommand();
			((DbCommand)(object)val).CommandText = Class9.smethod_0(-860097236);
			((DbParameterCollection)(object)val.get_Parameters()).Clear();
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860096708), (object)@class.method_0());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860096642), (object)@class.method_2());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860096871), (object)@class.method_6());
			val.set_Connection(gform0_0.sqlConnection_0);
			try
			{
				((DbCommand)(object)val).ExecuteNonQuery();
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
				return;
			}
			finally
			{
				((DbConnection)(object)gform0_0.sqlConnection_0).Close();
				method_1();
				method_3(@class.method_0());
			}
		}
		MessageBox.Show(Class9.smethod_0(-860097182));
		gform0_0.gcontrol1_0.method_11();
		method_1();
	}

	public void method_6(string string_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860097059), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860097115), (object)string_0));
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
		}
		catch (Exception)
		{
			MessageBox.Show(Class9.smethod_0(-860097138));
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
			method_1();
			method_3(null);
			class18_0.method_11();
			class18_0.method_9();
			class18_0.method_6();
			class18_0.method_8();
		}
	}

	public void method_7()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		gform0_0.gcontrol1_0.comboBox_0.get_Items().Clear();
		((Control)gform0_0.gcontrol1_0.comboBox_0).set_Text(string.Empty);
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860097491), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				string text = ((DbDataReader)(object)val2)[Class9.smethod_0(-860097481)].ToString() + Class9.smethod_0(-860096477) + ((DbDataReader)(object)val2)[Class9.smethod_0(-860096990)]?.ToString() + Class9.smethod_0(-860096477) + ((DbDataReader)(object)val2)[Class9.smethod_0(-860096970)];
				gform0_0.gcontrol1_0.comboBox_0.get_Items().Add((object)text);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbDataReader)(object)val2).Close();
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		}
	}

	public void method_8()
	{
		string string_ = gform0_0.gcontrol1_0.method_6();
		method_3(string_);
	}
}
