using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

internal sealed class Class7
{
	private GForm0 gform0_0;

	private Class18 class18_0;

	public Class7(GForm0 gform0_1)
	{
		gform0_0 = gform0_1;
		class18_0 = new Class18(gform0_0);
	}

	public int method_0()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860100401), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		SqlCommandBuilder.DeriveParameters(val);
		((DbCommand)(object)val).ExecuteNonQuery();
		int result = (int)((DbParameter)(object)val.get_Parameters().get_Item(Class9.smethod_0(-860098459))).Value;
		((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		return result;
	}

	public void method_1()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860100396), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		gform0_0.listBox_6.get_Items().Clear();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				Class6 @class = new Class6();
				@class.method_1(((DbDataReader)(object)val2)[Class9.smethod_0(-860096211)].ToString());
				@class.method_3(((DbDataReader)(object)val2)[Class9.smethod_0(-860097481)].ToString());
				@class.method_5(((DbDataReader)(object)val2)[Class9.smethod_0(-860096183)].ToString());
				@class.method_7(((DbDataReader)(object)val2)[Class9.smethod_0(-860096990)].ToString());
				@class.method_9(((DbDataReader)(object)val2)[Class9.smethod_0(-860096970)].ToString());
				@class.method_11(((DbDataReader)(object)val2)[Class9.smethod_0(-860100417)].ToString());
				@class.method_13(((DbDataReader)(object)val2)[Class9.smethod_0(-860100471)].ToString());
				@class.method_15(((DbDataReader)(object)val2)[Class9.smethod_0(-860100452)].ToString());
				@class.method_17(((DbDataReader)(object)val2)[Class9.smethod_0(-860099857)].ToString());
				@class.method_19(((DbDataReader)(object)val2)[Class9.smethod_0(-860098719)].ToString());
				@class.method_21(((DbDataReader)(object)val2)[Class9.smethod_0(-860097557)].ToString());
				gform0_0.listBox_6.get_Items().Add((object)@class);
			}
			gform0_0.int_7 = 0;
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbDataReader)(object)val2).Close();
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
			method_8();
		}
	}

	public void method_2()
	{
		gform0_0.int_7 = ((ListControl)gform0_0.listBox_6).get_SelectedIndex();
		method_3(null);
		class18_0.method_7();
	}

	public void method_3(string string_0)
	{
		if (string_0 != null)
		{
			gform0_0.int_7 = -1;
			foreach (Class6 item in gform0_0.listBox_6.get_Items())
			{
				gform0_0.int_7++;
				if (item.method_0() == string_0)
				{
					((ListControl)gform0_0.listBox_6).set_SelectedIndex(gform0_0.int_7);
					break;
				}
			}
		}
		if (!((gform0_0.listBox_6.get_Items().get_Count() == 0) | (gform0_0.int_7 < 0)))
		{
			Class6 class2 = new Class6();
			class2 = (Class6)gform0_0.listBox_6.get_Items().get_Item(gform0_0.int_7);
			gform0_0.gcontrol2_0.method_3(class2.method_0());
			gform0_0.gcontrol2_0.method_4(class2.method_2());
			gform0_0.gcontrol2_0.method_5(class2.method_4());
			gform0_0.gcontrol2_0.method_6(class2.method_12());
			gform0_0.gcontrol2_0.method_7(class2.method_14());
			gform0_0.gcontrol2_0.method_8(class2.method_16());
			gform0_0.gcontrol2_0.method_11(class2.method_6());
			gform0_0.gcontrol2_0.method_12(class2.method_8());
			gform0_0.gcontrol2_0.method_13(class2.method_10());
			gform0_0.gcontrol2_0.method_9(class2.method_18() + Class9.smethod_0(-860096477) + class2.method_16());
			gform0_0.gcontrol2_0.method_14(class2.method_20());
		}
	}

	public void method_4()
	{
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)gform0_0.gcontrol2_0.comboBox_0).get_SelectedIndex() > -1)
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
			Class6 @class = new Class6();
			@class.method_1(gform0_0.gcontrol2_0.method_15());
			@class.method_3(gform0_0.gcontrol2_0.method_0().ToString());
			@class.method_5(gform0_0.gcontrol2_0.method_17());
			@class.method_7(gform0_0.gcontrol2_0.method_21());
			@class.method_9(gform0_0.gcontrol2_0.method_22());
			@class.method_11(gform0_0.gcontrol2_0.method_23());
			@class.method_13(gform0_0.gcontrol2_0.method_18());
			@class.method_15(gform0_0.gcontrol2_0.method_19());
			@class.method_17(gform0_0.gcontrol2_0.method_20());
			@class.method_21(gform0_0.gcontrol2_0.method_24());
			@class.method_19(gform0_0.gcontrol2_0.method_10());
			SqlCommand val = new SqlCommand();
			((DbCommand)(object)val).CommandText = Class9.smethod_0(-860098697);
			((DbParameterCollection)(object)val.get_Parameters()).Clear();
			try
			{
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860099026), (object)@class.method_2());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)@class.method_0());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860099010), (object)DateTime.Parse(@class.method_14()));
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860099070), (object)@class.method_10());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860099053), (object)@class.method_18());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860098848), (object)@class.method_12());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860098870), (object)@class.method_6());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860098851), (object)@class.method_8());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860098910), (object)@class.method_20());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860099823), (object)@class.method_4());
				val.set_Connection(gform0_0.sqlConnection_0);
				((DbCommand)(object)val).ExecuteNonQuery();
				gform0_0.gcontrol2_0.method_2();
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
		MessageBox.Show(Class9.smethod_0(-860098882));
		gform0_0.gcontrol2_0.method_26();
		method_1();
	}

	public void method_5()
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)gform0_0.gcontrol2_0.comboBox_0).get_SelectedIndex() > -1)
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
			Class6 @class = new Class6();
			@class.method_1(gform0_0.gcontrol2_0.method_15());
			@class.method_3(gform0_0.gcontrol2_0.method_16());
			@class.method_5(gform0_0.gcontrol2_0.method_17());
			@class.method_7(gform0_0.gcontrol2_0.method_21());
			@class.method_9(gform0_0.gcontrol2_0.method_22());
			@class.method_11(gform0_0.gcontrol2_0.method_23());
			@class.method_13(gform0_0.gcontrol2_0.method_18());
			@class.method_15(gform0_0.gcontrol2_0.method_19());
			@class.method_21(gform0_0.gcontrol2_0.method_24());
			@class.method_19(gform0_0.gcontrol2_0.method_10());
			SqlCommand val = new SqlCommand();
			((DbCommand)(object)val).CommandText = Class9.smethod_0(-860099231);
			((DbParameterCollection)(object)val.get_Parameters()).Clear();
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860099026), (object)@class.method_2());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)@class.method_0());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860099010), (object)DateTime.Parse(@class.method_14()));
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860099070), (object)@class.method_10());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860099053), (object)@class.method_18());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860098848), (object)@class.method_12());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860098870), (object)@class.method_6());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860098851), (object)@class.method_8());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860098910), (object)@class.method_20());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860099823), (object)@class.method_4());
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
		MessageBox.Show(Class9.smethod_0(-860098882));
		gform0_0.gcontrol2_0.method_26();
		method_1();
	}

	public void method_6()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		string text = ((Class6)gform0_0.listBox_6.get_SelectedItem()).method_0();
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860099519);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860099836), (object)text);
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			((DbCommand)(object)val).ExecuteNonQuery();
			gform0_0.listBox_6.get_Items().Remove((object)(Class6)gform0_0.listBox_6.get_SelectedItem());
			class18_0.method_11();
			class18_0.method_9();
			class18_0.method_13();
			class18_0.method_6();
			class18_0.method_7();
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860099364) + ex.Message);
		}
		finally
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		}
	}

	public void method_7()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		string text = gform0_0.gcontrol2_0.method_21();
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860099445), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860099427), (object)text));
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860101783), (object)gform0_0.int_1));
		SqlDataReader val2 = val.ExecuteReader();
		gform0_0.listBox_6.get_Items().Clear();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				Class6 @class = new Class6();
				@class.method_1(((DbDataReader)(object)val2)[Class9.smethod_0(-860096211)].ToString());
				@class.method_3(((DbDataReader)(object)val2)[Class9.smethod_0(-860097481)].ToString());
				@class.method_5(((DbDataReader)(object)val2)[Class9.smethod_0(-860096183)].ToString());
				@class.method_7(((DbDataReader)(object)val2)[Class9.smethod_0(-860096990)].ToString());
				@class.method_9(((DbDataReader)(object)val2)[Class9.smethod_0(-860096970)].ToString());
				@class.method_11(((DbDataReader)(object)val2)[Class9.smethod_0(-860100417)].ToString());
				@class.method_13(((DbDataReader)(object)val2)[Class9.smethod_0(-860100471)].ToString());
				@class.method_15(((DbDataReader)(object)val2)[Class9.smethod_0(-860101768)].ToString());
				@class.method_17(((DbDataReader)(object)val2)[Class9.smethod_0(-860099857)].ToString());
				@class.method_19(((DbDataReader)(object)val2)[Class9.smethod_0(-860098719)].ToString());
				@class.method_21(((DbDataReader)(object)val2)[Class9.smethod_0(-860097557)].ToString());
				gform0_0.listBox_6.get_Items().Add((object)@class);
			}
			gform0_0.int_7 = 0;
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
		method_3(null);
	}

	public void method_8()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		gform0_0.gcontrol2_0.comboBox_0.get_Items().Clear();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860101822), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				gform0_0.gcontrol2_0.comboBox_0.get_Items().Add((object)(((DbDataReader)(object)val2)[Class9.smethod_0(-860101804)].ToString() + Class9.smethod_0(-860096477) + ((DbDataReader)(object)val2)[Class9.smethod_0(-860099857)].ToString()));
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
}
