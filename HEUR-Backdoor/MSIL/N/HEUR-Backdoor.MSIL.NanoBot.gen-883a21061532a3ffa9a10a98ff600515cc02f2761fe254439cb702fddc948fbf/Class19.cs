using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

internal sealed class Class19
{
	private GForm0 gform0_0;

	private Class18 class18_0;

	public Class19(GForm0 gform0_1)
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
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860100694), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		gform0_0.listBox_3.get_Items().Clear();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				Class8 @class = new Class8();
				@class.method_1(((DbDataReader)(object)val2)[Class9.smethod_0(-860096211)].ToString());
				@class.method_9(((DbDataReader)(object)val2)[Class9.smethod_0(-860100674)].ToString());
				@class.method_3(((DbDataReader)(object)val2)[Class9.smethod_0(-860100733)].ToString());
				@class.method_5(((DbDataReader)(object)val2)[Class9.smethod_0(-860100707)].ToString());
				@class.method_7(((DbDataReader)(object)val2)[Class9.smethod_0(-860101023)].ToString());
				gform0_0.listBox_3.get_Items().Add((object)@class);
			}
			gform0_0.int_4 = 0;
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
		gform0_0.int_4 = ((ListControl)gform0_0.listBox_3).get_SelectedIndex();
		method_2(null);
		class18_0.method_7();
	}

	public void method_2(string string_0)
	{
		if (string_0 != null)
		{
			gform0_0.int_4 = -1;
			foreach (Class8 item in gform0_0.listBox_3.get_Items())
			{
				gform0_0.int_4++;
				if (item.method_0() == string_0)
				{
					((ListControl)gform0_0.listBox_3).set_SelectedIndex(gform0_0.int_4);
					break;
				}
			}
		}
		if (!((gform0_0.listBox_3.get_Items().get_Count() == 0) | (gform0_0.int_4 < 0)))
		{
			Class8 class2 = new Class8();
			class2 = (Class8)gform0_0.listBox_3.get_Items().get_Item(gform0_0.int_4);
			gform0_0.gcontrol3_0.method_0(class2.method_0());
			gform0_0.gcontrol3_0.method_1(class2.method_6());
			gform0_0.gcontrol3_0.method_2(class2.method_2());
			gform0_0.gcontrol3_0.method_3(class2.method_4());
			gform0_0.gcontrol3_0.method_4(class2.method_8());
		}
	}

	public void method_3()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class8 @class = new Class8();
		@class.method_1(gform0_0.gcontrol3_0.method_5());
		@class.method_3(gform0_0.gcontrol3_0.method_7());
		@class.method_5(gform0_0.gcontrol3_0.method_8());
		@class.method_7(gform0_0.gcontrol3_0.method_6());
		@class.method_9(gform0_0.gcontrol3_0.method_9());
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860101005);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)@class.method_0());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100900), (object)@class.method_2());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100947), (object)@class.method_4());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100944), (object)@class.method_6());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100991), (object)@class.method_8());
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
			method_7(@class.method_0());
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
			method_0();
			method_2(@class.method_0());
		}
	}

	public void method_4()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class8 @class = new Class8();
		@class.method_1(gform0_0.gcontrol3_0.method_5());
		@class.method_3(gform0_0.gcontrol3_0.method_7());
		@class.method_5(gform0_0.gcontrol3_0.method_8());
		@class.method_7(gform0_0.gcontrol3_0.method_6());
		@class.method_9(gform0_0.gcontrol3_0.method_9());
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860100971);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)@class.method_0());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100900), (object)@class.method_2());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100947), (object)@class.method_4());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100944), (object)@class.method_6());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100991), (object)@class.method_8());
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
			method_2(@class.method_0());
		}
	}

	public void method_5()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		string text = ((Class8)gform0_0.listBox_3.get_SelectedItem()).method_0();
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860101173);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)text);
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			method_6(text);
			((DbCommand)(object)val).ExecuteNonQuery();
			gform0_0.listBox_3.get_Items().Remove((object)(Class8)gform0_0.listBox_3.get_SelectedItem());
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

	public void method_6(string string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860101188);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)string_0);
		val.set_Connection(gform0_0.sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
	}

	public void method_7(string string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		SqlCommand val = new SqlCommand();
		string text = ((Control)gform0_0.textBox_4).get_Text() + Class9.smethod_0(-860101519);
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860101559);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100046), (object)string_0);
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100081), (object)text);
		val.set_Connection(gform0_0.sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
	}

	public void method_8()
	{
		string string_ = gform0_0.gcontrol3_0.method_5();
		method_2(string_);
	}
}
