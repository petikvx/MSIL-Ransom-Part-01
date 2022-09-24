using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

internal sealed class Class15
{
	private GForm0 gform0_0;

	private Class18 class18_0;

	public Class15(GForm0 gform0_1)
	{
		gform0_0 = gform0_1;
		class18_0 = new Class18(gform0_0);
	}

	public int method_0()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860101621), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		SqlCommandBuilder.DeriveParameters(val);
		((DbCommand)(object)val).ExecuteNonQuery();
		((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		return (int)((DbParameter)(object)val.get_Parameters().get_Item(Class9.smethod_0(-860098459))).Value;
	}

	public void method_1()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860101604), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		gform0_0.listBox_7.get_Items().Clear();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				Class33 @class = new Class33();
				@class.method_1(((DbDataReader)(object)val2)[Class9.smethod_0(-860096211)].ToString());
				@class.method_3(((DbDataReader)(object)val2)[Class9.smethod_0(-860097481)].ToString());
				@class.method_5(((DbDataReader)(object)val2)[Class9.smethod_0(-860100417)].ToString());
				@class.method_7(((DbDataReader)(object)val2)[Class9.smethod_0(-860101394)].ToString());
				@class.method_9(((DbDataReader)(object)val2)[Class9.smethod_0(-860096990)].ToString());
				@class.method_11(((DbDataReader)(object)val2)[Class9.smethod_0(-860096970)].ToString());
				@class.method_13(((DbDataReader)(object)val2)[Class9.smethod_0(-860097557)].ToString());
				@class.method_15(((DbDataReader)(object)val2)[Class9.smethod_0(-860096183)].ToString());
				@class.method_19(((DbDataReader)(object)val2)[Class9.smethod_0(-860101635)].ToString());
				@class.method_17(((DbDataReader)(object)val2)[Class9.smethod_0(-860095850)].ToString());
				gform0_0.listBox_7.get_Items().Add((object)@class);
			}
			gform0_0.int_8 = 0;
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

	public void method_2()
	{
		gform0_0.int_8 = ((ListControl)gform0_0.listBox_7).get_SelectedIndex();
		method_3(null);
		class18_0.method_7();
	}

	public void method_3(string string_0)
	{
		if (string_0 != null)
		{
			gform0_0.int_8 = -1;
			foreach (Class33 item in gform0_0.listBox_7.get_Items())
			{
				gform0_0.int_8++;
				if (item.method_0() == string_0)
				{
					((ListControl)gform0_0.listBox_7).set_SelectedIndex(gform0_0.int_8);
					break;
				}
			}
		}
		if (!((gform0_0.listBox_7.get_Items().get_Count() == 0) | (gform0_0.int_8 < 0)))
		{
			Class33 class2 = new Class33();
			class2 = (Class33)gform0_0.listBox_7.get_Items().get_Item(gform0_0.int_8);
			gform0_0.gcontrol6_0.method_3(class2.method_0());
			gform0_0.gcontrol6_0.method_4(class2.method_2());
			gform0_0.gcontrol6_0.method_8(class2.method_4());
			gform0_0.gcontrol6_0.method_10(class2.method_6());
			gform0_0.gcontrol6_0.method_6(class2.method_8());
			gform0_0.gcontrol6_0.method_7(class2.method_10());
			gform0_0.gcontrol6_0.method_9(class2.method_12());
			gform0_0.gcontrol6_0.method_5(class2.method_14());
			gform0_0.gcontrol6_0.method_11(class2.method_16());
		}
	}

	public void method_4()
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class33 @class = new Class33();
		@class.method_1(gform0_0.gcontrol6_0.method_12());
		@class.method_3(gform0_0.gcontrol6_0.method_13());
		@class.method_15(gform0_0.gcontrol6_0.method_14());
		@class.method_9(gform0_0.gcontrol6_0.method_15());
		@class.method_11(gform0_0.gcontrol6_0.method_16());
		@class.method_5(gform0_0.gcontrol6_0.method_17());
		@class.method_7(gform0_0.gcontrol6_0.method_19());
		@class.method_13(gform0_0.gcontrol6_0.method_18());
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860101389);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099026), (object)@class.method_2());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)@class.method_0());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099070), (object)@class.method_4());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860098870), (object)@class.method_8());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860098851), (object)@class.method_10());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860098910), (object)@class.method_12());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099823), (object)@class.method_14());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860103721), (object)@class.method_6());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text());
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
			gform0_0.gcontrol6_0.method_2();
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
			method_1();
			method_3(@class.method_2());
		}
	}

	public void method_5()
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		Class33 @class = new Class33();
		@class.method_1(gform0_0.gcontrol6_0.method_12());
		@class.method_3(gform0_0.gcontrol6_0.method_13());
		@class.method_15(gform0_0.gcontrol6_0.method_14());
		@class.method_9(gform0_0.gcontrol6_0.method_15());
		@class.method_11(gform0_0.gcontrol6_0.method_16());
		@class.method_5(gform0_0.gcontrol6_0.method_17());
		@class.method_7(gform0_0.gcontrol6_0.method_19());
		@class.method_13(gform0_0.gcontrol6_0.method_18());
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860103749);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099026), (object)@class.method_2());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)@class.method_0());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099070), (object)@class.method_4());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860098870), (object)@class.method_8());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860098851), (object)@class.method_10());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860098910), (object)@class.method_12());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099823), (object)@class.method_14());
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860103721), (object)@class.method_6());
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
			method_3(@class.method_2());
		}
	}

	public void method_6()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		string text = ((Class33)gform0_0.listBox_7.get_SelectedItem()).method_0();
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860104016);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)text);
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
			gform0_0.listBox_7.get_Items().Remove((object)(Class33)gform0_0.listBox_7.get_SelectedItem());
			class18_0.method_11();
			class18_0.method_9();
			class18_0.method_13();
			class18_0.method_6();
			class18_0.method_7();
		}
		catch (Exception)
		{
			MessageBox.Show(Class9.smethod_0(-860104421));
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		}
	}

	public void method_7()
	{
		string string_ = gform0_0.gcontrol6_0.method_12();
		method_3(string_);
	}
}
