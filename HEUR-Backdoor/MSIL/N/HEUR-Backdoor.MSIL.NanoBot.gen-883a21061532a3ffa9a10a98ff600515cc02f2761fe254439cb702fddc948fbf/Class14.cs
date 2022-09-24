using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

internal sealed class Class14
{
	private GForm0 gform0_0;

	private Class18 class18_0;

	public Class14(GForm0 gform0_1)
	{
		gform0_0 = gform0_1;
		class18_0 = new Class18(gform0_0);
	}

	public int method_0()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		if (((DbConnection)(object)gform0_0.sqlConnection_0).State == ConnectionState.Closed)
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		}
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860098151), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		SqlCommandBuilder.DeriveParameters(val);
		((DbCommand)(object)val).ExecuteNonQuery();
		int result = (int)((DbParameter)(object)val.get_Parameters().get_Item(Class9.smethod_0(-860098459))).Value;
		((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		return result;
	}

	public void method_1()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		if (((DbConnection)(object)gform0_0.sqlConnection_0).State == ConnectionState.Closed)
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		}
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860098487), gform0_0.sqlConnection_0);
		SqlDataReader val2 = val.ExecuteReader();
		gform0_0.listBox_0.get_Items().Clear();
		class18_0.method_6();
		method_7();
		while (((DbDataReader)(object)val2).Read())
		{
			Class2 @class = new Class2();
			@class.method_1(((DbDataReader)(object)val2)[Class9.smethod_0(-860095497)].ToString());
			@class.method_3(((DbDataReader)(object)val2)[Class9.smethod_0(-860095850)].ToString());
			@class.method_5(((DbDataReader)(object)val2)[Class9.smethod_0(-860098523)].ToString());
			@class.method_7(((DbDataReader)(object)val2)[Class9.smethod_0(-860098549)].ToString());
			@class.method_9(((DbDataReader)(object)val2)[Class9.smethod_0(-860098533)].ToString());
			gform0_0.listBox_0.get_Items().Add((object)@class);
		}
		((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		foreach (Class2 item in gform0_0.listBox_0.get_Items())
		{
			SqlCommand val3 = new SqlCommand(Class9.smethod_0(-860094524), gform0_0.sqlConnection_0);
			val3.get_Parameters().AddWithValue(Class9.smethod_0(-860094543), (object)item.method_0());
			item.method_7(((DbCommand)(object)val3).ExecuteScalar()!.ToString());
		}
		((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		gform0_0.int_1 = 1;
	}

	public void method_2()
	{
		if (((ListControl)gform0_0.listBox_0).get_SelectedIndex() > -1)
		{
			gform0_0.int_1 = ((ListControl)gform0_0.listBox_0).get_SelectedIndex() + 1;
			class18_0.method_5();
			method_16();
			method_19();
			class18_0.method_14();
			method_18();
			method_3(null);
			method_17();
			method_15();
			class18_0.method_11();
		}
	}

	public void method_3(string string_0)
	{
		if (string_0 != null)
		{
			gform0_0.int_1 = -1;
			foreach (Class2 item in gform0_0.listBox_0.get_Items())
			{
				gform0_0.int_1++;
				if (item.method_0() == string_0)
				{
					((ListControl)gform0_0.listBox_0).set_SelectedIndex(gform0_0.int_1);
					break;
				}
			}
		}
		if (!((gform0_0.listBox_0.get_Items().get_Count() == 0) | (gform0_0.int_1 < 0)))
		{
			Class2 class2 = new Class2();
			class2 = (Class2)gform0_0.listBox_0.get_Items().get_Item(gform0_0.int_1 - 1);
			((Control)gform0_0.textBox_4).set_Text(class2.method_0());
			((Control)gform0_0.textBox_3).set_Text(class2.method_2());
			((Control)gform0_0.textBox_1).set_Text(class2.method_4());
			((Control)gform0_0.textBox_0).set_Text(class2.method_6());
			((Control)gform0_0.textBox_2).set_Text(class2.method_8());
		}
	}

	public void method_4()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class2 @class = new Class2();
		@class.method_3(((Control)gform0_0.textBox_3).get_Text());
		@class.method_5(((Control)gform0_0.textBox_1).get_Text());
		@class.method_7(((Control)gform0_0.textBox_0).get_Text());
		@class.method_9(((Control)gform0_0.textBox_2).get_Text());
		@class.method_1(((Control)gform0_0.textBox_4).get_Text());
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860098326);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096642), (object)@class.method_2());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096694), (object)@class.method_4());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096673), (object)@class.method_6());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096722), (object)@class.method_8());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096708), (object)@class.method_0());
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
			gform0_0.method_3();
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
			method_1();
			method_3(@class.method_0());
		}
	}

	public void method_5()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class2 @class = new Class2();
		@class.method_3(((Control)gform0_0.textBox_3).get_Text());
		@class.method_5(((Control)gform0_0.textBox_1).get_Text());
		@class.method_7(((Control)gform0_0.textBox_0).get_Text());
		@class.method_9(((Control)gform0_0.textBox_2).get_Text());
		@class.method_1(((Control)gform0_0.textBox_4).get_Text());
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860096758);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096642), (object)@class.method_2());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096694), (object)@class.method_4());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096673), (object)@class.method_6());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096722), (object)@class.method_8());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096708), (object)@class.method_0());
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
			method_1();
			method_3(@class.method_0());
		}
	}

	public void method_6()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		string text = ((Class2)gform0_0.listBox_0.get_SelectedItem()).method_0();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860096609), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)text));
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
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
		((TextBoxBase)gform0_0.textBox_4).set_ReadOnly(true);
		((TextBoxBase)gform0_0.textBox_3).set_ReadOnly(true);
		((TextBoxBase)gform0_0.textBox_1).set_ReadOnly(true);
		((TextBoxBase)gform0_0.textBox_0).set_ReadOnly(true);
		((TextBoxBase)gform0_0.textBox_2).set_ReadOnly(true);
	}

	public void method_8()
	{
		((TextBoxBase)gform0_0.textBox_3).set_ReadOnly(false);
		((TextBoxBase)gform0_0.textBox_1).set_ReadOnly(false);
		((TextBoxBase)gform0_0.textBox_2).set_ReadOnly(false);
	}

	public void method_9()
	{
		((Control)gform0_0.textBox_2).set_Text(string.Empty);
		((Control)gform0_0.textBox_4).set_Text(string.Empty);
		((Control)gform0_0.textBox_1).set_Text(string.Empty);
		((Control)gform0_0.textBox_3).set_Text(string.Empty);
		((Control)gform0_0.textBox_0).set_Text(string.Empty);
	}

	public void method_10()
	{
		((Control)gform0_0.listBox_0).set_Enabled(false);
	}

	public void method_11()
	{
		((Control)gform0_0.listBox_0).set_Enabled(true);
	}

	public void method_12()
	{
		((ListControl)gform0_0.listBox_0).set_SelectedIndex(-1);
	}

	public void method_13()
	{
		((Control)gform0_0.button_15).set_Visible(false);
		((Control)gform0_0.button_14).set_Visible(false);
		((Control)gform0_0.button_13).set_Visible(false);
		((Control)gform0_0.button_17).set_Visible(true);
		((Control)gform0_0.button_16).set_Visible(true);
	}

	public void method_14()
	{
		((Control)gform0_0.button_15).set_Visible(true);
		((Control)gform0_0.button_14).set_Visible(false);
		((Control)gform0_0.button_13).set_Visible(false);
		((Control)gform0_0.button_17).set_Visible(false);
		((Control)gform0_0.button_16).set_Visible(false);
	}

	public void method_15()
	{
		((Control)gform0_0.button_15).set_Visible(true);
		((Control)gform0_0.button_14).set_Visible(true);
		((Control)gform0_0.button_13).set_Visible(true);
		((Control)gform0_0.button_17).set_Visible(false);
		((Control)gform0_0.button_16).set_Visible(false);
	}

	public void method_16()
	{
		gform0_0.listBox_1.get_Items().Clear();
		gform0_0.listBox_2.get_Items().Clear();
		gform0_0.listBox_3.get_Items().Clear();
		gform0_0.listBox_5.get_Items().Clear();
		gform0_0.listBox_4.get_Items().Clear();
		gform0_0.listBox_6.get_Items().Clear();
		gform0_0.listBox_7.get_Items().Clear();
	}

	public void method_17()
	{
		((Control)gform0_0.button_0).set_Visible(true);
		((Control)gform0_0.button_1).set_Visible(true);
		((Control)gform0_0.button_2).set_Visible(true);
		((Control)gform0_0.button_3).set_Visible(true);
		((Control)gform0_0.button_4).set_Visible(true);
		((Control)gform0_0.button_5).set_Visible(true);
		((Control)gform0_0.button_11).set_Visible(true);
	}

	public void method_18()
	{
		gform0_0.gcontrol0_0.method_21();
		gform0_0.gcontrol1_0.method_10();
		gform0_0.gcontrol3_0.method_10();
		gform0_0.gcontrol5_0.method_11();
		gform0_0.gcontrol4_0.method_6();
		gform0_0.gcontrol2_0.method_25();
		gform0_0.gcontrol6_0.method_21();
	}

	public void method_19()
	{
		((Control)gform0_0.gcontrol0_0).Hide();
		((Control)gform0_0.gcontrol1_0).Hide();
		((Control)gform0_0.gcontrol3_0).Hide();
		((Control)gform0_0.gcontrol5_0).Hide();
		((Control)gform0_0.gcontrol4_0).Hide();
		((Control)gform0_0.gcontrol2_0).Hide();
		((Control)gform0_0.gcontrol6_0).Hide();
	}
}
