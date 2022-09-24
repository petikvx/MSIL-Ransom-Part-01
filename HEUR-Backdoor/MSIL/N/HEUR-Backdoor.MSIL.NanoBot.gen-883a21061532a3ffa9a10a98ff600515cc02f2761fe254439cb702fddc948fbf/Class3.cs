using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

internal sealed class Class3
{
	private GForm0 gform0_0;

	private Class18 class18_0;

	public Class3(GForm0 gform0_1)
	{
		gform0_0 = gform0_1;
		class18_0 = new Class18(gform0_0);
	}

	public void method_0()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860099854), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		gform0_0.listBox_4.get_Items().Clear();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				Class30 @class = new Class30();
				@class.method_1(((DbDataReader)(object)val2)[Class9.smethod_0(-860096343)].ToString());
				@class.method_3(((DbDataReader)(object)val2)[Class9.smethod_0(-860099902)].ToString());
				@class.method_5(((DbDataReader)(object)val2)[Class9.smethod_0(-860099888)].ToString());
				@class.method_9(((DbDataReader)(object)val2)[Class9.smethod_0(-860099935)].ToString());
				@class.method_11(((DbDataReader)(object)val2)[Class9.smethod_0(-860099918)].ToString());
				@class.method_7(((DbDataReader)(object)val2)[Class9.smethod_0(-860095850)].ToString());
				gform0_0.listBox_4.get_Items().Add((object)@class);
			}
			gform0_0.int_6 = 0;
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

	public void method_1()
	{
		gform0_0.int_6 = ((ListControl)gform0_0.listBox_4).get_SelectedIndex();
		method_2(null);
		class18_0.method_7();
	}

	public void method_2(string string_0)
	{
		if (string_0 != null)
		{
			gform0_0.int_6 = -1;
			foreach (Class30 item in gform0_0.listBox_4.get_Items())
			{
				gform0_0.int_6++;
				if (item.method_6() == string_0)
				{
					((ListControl)gform0_0.listBox_4).set_SelectedIndex(gform0_0.int_6);
					break;
				}
			}
		}
		if (!((gform0_0.listBox_4.get_Items().get_Count() == 0) | (gform0_0.int_6 < 0)))
		{
			Class30 class2 = new Class30();
			class2 = (Class30)gform0_0.listBox_4.get_Items().get_Item(gform0_0.int_6);
			gform0_0.gcontrol5_0.method_7(class2.method_6());
			gform0_0.gcontrol5_0.method_6(class2.method_0());
			gform0_0.gcontrol5_0.method_9(class2.method_2());
			gform0_0.gcontrol5_0.method_10(class2.method_4());
			gform0_0.gcontrol5_0.method_8(class2.method_8());
		}
	}

	public void method_3()
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class30 @class = new Class30();
		@class.method_7(gform0_0.gcontrol5_0.method_1());
		@class.method_1(gform0_0.gcontrol5_0.method_0());
		@class.method_3(gform0_0.gcontrol5_0.method_2());
		@class.method_5(gform0_0.gcontrol5_0.method_3());
		@class.method_9(gform0_0.gcontrol5_0.method_4());
		@class.method_11(gform0_0.gcontrol5_0.method_5(((Control)gform0_0.textBox_4).get_Text()));
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860099964);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		try
		{
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860096642), (object)@class.method_6());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860100101), (object)@class.method_0());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860097115), (object)@class.method_10());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860100105), (object)DateTime.Parse(@class.method_2()));
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860100156), (object)DateTime.Parse(@class.method_4()));
			val.set_Connection(gform0_0.sqlConnection_0);
			((DbCommand)(object)val).ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
			method_0();
			method_2(@class.method_6());
		}
	}

	public void method_4()
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class30 @class = new Class30();
		@class.method_7(gform0_0.gcontrol5_0.method_1());
		@class.method_1(gform0_0.gcontrol5_0.method_0());
		@class.method_3(gform0_0.gcontrol5_0.method_2());
		@class.method_5(gform0_0.gcontrol5_0.method_3());
		@class.method_9(gform0_0.gcontrol5_0.method_4());
		@class.method_11(gform0_0.gcontrol5_0.method_5(((Control)gform0_0.textBox_4).get_Text()));
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860100140);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096642), (object)@class.method_6());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100101), (object)@class.method_0());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100105), (object)DateTime.Parse(@class.method_2()));
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100156), (object)DateTime.Parse(@class.method_4()));
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860097115), (object)@class.method_10());
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
			method_0();
			method_2(@class.method_6());
		}
	}

	public void method_5()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		string text = ((Class30)gform0_0.listBox_4.get_SelectedItem()).method_6();
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860100602);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096642), (object)text);
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
			gform0_0.listBox_4.get_Items().Remove((object)(Class30)gform0_0.listBox_4.get_SelectedItem());
			class18_0.method_11();
			class18_0.method_9();
			class18_0.method_13();
			class18_0.method_6();
			class18_0.method_7();
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		}
	}

	public void method_6()
	{
		string string_ = gform0_0.gcontrol5_0.method_1();
		method_2(string_);
	}
}
