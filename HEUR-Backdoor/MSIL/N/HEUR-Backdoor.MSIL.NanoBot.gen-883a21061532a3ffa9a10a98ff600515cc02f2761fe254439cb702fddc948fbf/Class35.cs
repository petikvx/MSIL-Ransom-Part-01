using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

internal sealed class Class35
{
	private GForm0 gform0_0;

	private Class18 class18_0;

	public Class35(GForm0 gform0_1)
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
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860097536), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		gform0_0.listBox_5.get_Items().Clear();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				Class17 @class = new Class17();
				@class.method_3(((DbDataReader)(object)val2)[Class9.smethod_0(-860095850)].ToString());
				@class.method_1(((DbDataReader)(object)val2)[Class9.smethod_0(-860096211)].ToString());
				@class.method_5(((DbDataReader)(object)val2)[Class9.smethod_0(-860096183)].ToString());
				gform0_0.listBox_5.get_Items().Add((object)@class);
			}
			gform0_0.int_5 = 0;
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
		gform0_0.int_5 = ((ListControl)gform0_0.listBox_5).get_SelectedIndex();
		gform0_0.gcontrol4_0.listBox_0.get_Items().Clear();
		method_2(null);
		class18_0.method_7();
	}

	public void method_2(string string_0)
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		if (string_0 != null)
		{
			gform0_0.int_5 = -1;
			foreach (Class17 item in gform0_0.listBox_5.get_Items())
			{
				gform0_0.int_5++;
				if (item.method_0() == string_0)
				{
					((ListControl)gform0_0.listBox_5).set_SelectedIndex(gform0_0.int_5);
					break;
				}
			}
		}
		if (!((gform0_0.listBox_5.get_Items().get_Count() == 0) | (gform0_0.int_5 < 0)))
		{
			Class17 class2 = new Class17();
			class2 = (Class17)gform0_0.listBox_5.get_Items().get_Item(gform0_0.int_5);
			gform0_0.gcontrol4_0.method_2(class2.method_2());
			gform0_0.gcontrol4_0.method_0(class2.method_0());
			gform0_0.gcontrol4_0.method_4(class2.method_4());
			new SqlCommand(Class9.smethod_0(-860097513) + gform0_0.gcontrol4_0.method_1(), gform0_0.sqlConnection_0);
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
			method_8(class2.method_0());
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		}
	}

	public void method_3()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class17 @class = new Class17();
		@class.method_1(gform0_0.gcontrol4_0.method_1());
		@class.method_3(gform0_0.gcontrol4_0.method_3());
		@class.method_5(gform0_0.gcontrol4_0.method_5());
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860099719);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)@class.method_0());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096642), (object)@class.method_2());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099823), (object)@class.method_4());
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
			method_6(@class.method_0());
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
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class17 @class = new Class17();
		@class.method_1(gform0_0.gcontrol4_0.method_1());
		@class.method_3(gform0_0.gcontrol4_0.method_3());
		@class.method_5(gform0_0.gcontrol4_0.method_5());
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860099615);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)@class.method_0());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860096642), (object)@class.method_2());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099823), (object)@class.method_4());
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

	public void method_5(string string_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860099709), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860099989), (object)string_0));
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
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
			method_2(null);
			class18_0.method_11();
			class18_0.method_9();
			class18_0.method_6();
			class18_0.method_8();
		}
	}

	public void method_6(string string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		SqlCommand val = new SqlCommand();
		string text = ((Control)gform0_0.textBox_4).get_Text() + Class9.smethod_0(-860099976);
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860099984);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100046), (object)string_0);
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860100081), (object)text);
		val.set_Connection(gform0_0.sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
	}

	public void method_7()
	{
		string string_ = gform0_0.gcontrol4_0.method_1();
		method_2(string_);
	}

	public void method_8(string string_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		gform0_0.gcontrol4_0.listBox_0.get_Items().Clear();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860100071), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860099989), (object)string_0));
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				gform0_0.gcontrol4_0.listBox_0.get_Items().Add(((DbDataReader)(object)val2)[Class9.smethod_0(-860099857)]);
			}
			((DbDataReader)(object)val2).Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
	}
}
