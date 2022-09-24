using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

internal sealed class Class12
{
	private GForm0 gform0_0;

	private Class18 class18_0;

	public Class12(GForm0 gform0_1)
	{
		gform0_0 = gform0_1;
		class18_0 = new Class18(gform0_0);
	}

	public int method_0()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860101851), gform0_0.sqlConnection_0);
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
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860101865), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		gform0_0.listBox_1.get_Items().Clear();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				Class32 @class = new Class32();
				@class.method_1(((DbDataReader)(object)val2)[Class9.smethod_0(-860096183)].ToString());
				@class.method_3(((DbDataReader)(object)val2)[Class9.smethod_0(-860099857)].ToString());
				@class.method_5(((DbDataReader)(object)val2)[Class9.smethod_0(-860101663)].ToString());
				@class.method_7(((DbDataReader)(object)val2)[Class9.smethod_0(-860101804)].ToString());
				@class.method_9(((DbDataReader)(object)val2)[Class9.smethod_0(-860096343)].ToString());
				@class.method_11(((DbDataReader)(object)val2)[Class9.smethod_0(-860101635)].ToString());
				@class.method_13(((DbDataReader)(object)val2)[Class9.smethod_0(-860101683)].ToString());
				@class.method_19(new Class17(((DbDataReader)(object)val2)[Class9.smethod_0(-860101670)].ToString(), ((DbDataReader)(object)val2)[Class9.smethod_0(-860095850)].ToString()));
				@class.method_15(((DbDataReader)(object)val2)[Class9.smethod_0(-860096990)].ToString() + Class9.smethod_0(-860096477) + ((DbDataReader)(object)val2)[Class9.smethod_0(-860096970)].ToString());
				@class.method_17(((DbDataReader)(object)val2)[Class9.smethod_0(-860101720)].ToString());
				gform0_0.listBox_1.get_Items().Add((object)@class);
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
			method_10();
		}
	}

	public void method_2()
	{
		gform0_0.int_2 = ((ListControl)gform0_0.listBox_1).get_SelectedIndex();
		gform0_0.gcontrol0_0.listBox_0.get_Items().Clear();
		method_3(null);
		class18_0.method_7();
	}

	public void method_3(string string_0)
	{
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		if (string_0 != null)
		{
			gform0_0.int_2 = -1;
			foreach (Class32 item in gform0_0.listBox_1.get_Items())
			{
				gform0_0.int_2++;
				if (item.method_6() == string_0)
				{
					((ListControl)gform0_0.listBox_1).set_SelectedIndex(gform0_0.int_2);
					break;
				}
			}
		}
		if (!((gform0_0.listBox_1.get_Items().get_Count() == 0) | (gform0_0.int_2 < 0)))
		{
			Class32 class2 = new Class32();
			class2 = (Class32)gform0_0.listBox_1.get_Items().get_Item(gform0_0.int_2);
			gform0_0.gcontrol0_0.method_2(class2.method_0());
			gform0_0.gcontrol0_0.method_4(class2.method_2());
			gform0_0.gcontrol0_0.method_6(class2.method_4());
			gform0_0.gcontrol0_0.method_8(class2.method_6());
			gform0_0.gcontrol0_0.method_12(class2.method_18().method_2());
			gform0_0.gcontrol0_0.method_10(class2.method_8());
			gform0_0.gcontrol0_0.method_16(class2.method_12());
			gform0_0.gcontrol0_0.method_18(class2.method_14());
			gform0_0.gcontrol0_0.method_14(class2.method_18().method_0() + Class9.smethod_0(-860096477) + class2.method_18().method_2());
			gform0_0.gcontrol0_0.method_19(class2.method_16());
			new SqlCommand(Class9.smethod_0(-860101698) + gform0_0.gcontrol0_0.method_9(), gform0_0.sqlConnection_0);
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
			method_9(class2.method_6());
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
		}
	}

	public void method_4()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)gform0_0.gcontrol0_0.comboBox_0).get_SelectedIndex() > -1)
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
			Class32 @class = new Class32();
			@class.method_1(gform0_0.gcontrol0_0.method_3());
			@class.method_3(gform0_0.gcontrol0_0.method_5());
			@class.method_5(gform0_0.gcontrol0_0.method_7());
			@class.method_7(gform0_0.gcontrol0_0.method_0().ToString());
			@class.method_9(gform0_0.gcontrol0_0.method_11());
			@class.method_13(gform0_0.gcontrol0_0.method_17());
			@class.method_19(new Class17(gform0_0.gcontrol0_0.method_15(), gform0_0.gcontrol0_0.method_13()));
			@class.method_18().method_1(gform0_0.gcontrol0_0.method_15());
			@class.method_17(gform0_0.gcontrol0_0.method_20());
			SqlCommand val = new SqlCommand();
			((DbCommand)(object)val).CommandText = Class9.smethod_0(-860101905);
			((DbParameterCollection)(object)val.get_Parameters()).Clear();
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860099823), (object)@class.method_0());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860102372), (object)@class.method_2());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860102170), (object)@class.method_4());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860102159), (object)@class.method_6());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860099989), (object)@class.method_18().method_0());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860100101), (object)@class.method_8());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860102207), (object)@class.method_12());
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860102179), (object)@class.method_16());
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
				method_3(@class.method_6());
			}
		}
		MessageBox.Show(Class9.smethod_0(-860102238));
		gform0_0.gcontrol0_0.method_22();
		method_1();
	}

	public void method_5()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)gform0_0.gcontrol0_0.comboBox_0).get_SelectedIndex() > -1)
		{
			((DbConnection)(object)gform0_0.sqlConnection_0).Open();
			Class32 @class = new Class32();
			if (method_11(gform0_0.gcontrol0_0.method_20()))
			{
				@class.method_1(gform0_0.gcontrol0_0.method_3());
				@class.method_3(gform0_0.gcontrol0_0.method_5());
				@class.method_5(gform0_0.gcontrol0_0.method_7());
				@class.method_7(gform0_0.gcontrol0_0.method_9());
				@class.method_9(gform0_0.gcontrol0_0.method_11());
				@class.method_13(gform0_0.gcontrol0_0.method_17());
				@class.method_17(gform0_0.gcontrol0_0.method_20());
				@class.method_19(new Class17(gform0_0.gcontrol0_0.method_15(), gform0_0.gcontrol0_0.method_13()));
				SqlCommand val = new SqlCommand();
				((DbCommand)(object)val).CommandText = Class9.smethod_0(-860102561);
				((DbParameterCollection)(object)val.get_Parameters()).Clear();
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860099823), (object)@class.method_0());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860102372), (object)@class.method_2());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860102170), (object)@class.method_4());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860102159), (object)@class.method_6());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860100101), (object)@class.method_8());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860102207), (object)@class.method_12());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860102179), (object)@class.method_16());
				val.get_Parameters().AddWithValue(Class9.smethod_0(-860099989), (object)@class.method_18().method_0());
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
					method_3(@class.method_6());
				}
			}
			MessageBox.Show(Class9.smethod_0(-860102256));
			((DbConnection)(object)gform0_0.sqlConnection_0).Close();
			method_1();
			method_3(@class.method_6());
		}
		else
		{
			MessageBox.Show(Class9.smethod_0(-860102238));
			gform0_0.gcontrol0_0.method_22();
			method_1();
		}
	}

	public void method_6()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		string text = ((Class32)gform0_0.listBox_1.get_SelectedItem()).method_6();
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860100742);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860102159), (object)text);
		val.set_Connection(gform0_0.sqlConnection_0);
		try
		{
			method_7(text);
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
			class18_0.method_9();
		}
	}

	public void method_7(string string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		SqlCommand val = new SqlCommand();
		((DbCommand)(object)val).CommandText = Class9.smethod_0(-860100827);
		((DbParameterCollection)(object)val.get_Parameters()).Clear();
		val.get_Parameters().AddWithValue(Class9.smethod_0(-860102159), (object)string_0);
		val.set_Connection(gform0_0.sqlConnection_0);
		((DbCommand)(object)val).ExecuteNonQuery();
	}

	public void method_8()
	{
		string string_ = gform0_0.gcontrol0_0.method_9();
		method_3(string_);
	}

	public void method_9(string string_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		gform0_0.gcontrol0_0.listBox_0.get_Items().Clear();
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860100617), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860100646), (object)string_0));
		SqlDataReader val2 = val.ExecuteReader();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				gform0_0.gcontrol0_0.listBox_0.get_Items().Add((object)(((DbDataReader)(object)val2)[Class9.smethod_0(-860097481)].ToString() + Class9.smethod_0(-860096477) + ((DbDataReader)(object)val2)[Class9.smethod_0(-860096990)]?.ToString() + Class9.smethod_0(-860096477) + ((DbDataReader)(object)val2)[Class9.smethod_0(-860096970)]));
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
		finally
		{
			((DbDataReader)(object)val2).Close();
		}
	}

	public void method_10()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		((DbConnection)(object)gform0_0.sqlConnection_0).Open();
		gform0_0.gcontrol0_0.comboBox_0.get_Items().Clear();
		((Control)gform0_0.gcontrol0_0.comboBox_0).set_Text(string.Empty);
		SqlCommand val = new SqlCommand(Class9.smethod_0(-860097536), gform0_0.sqlConnection_0);
		((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
		val.get_Parameters().Add(new SqlParameter(Class9.smethod_0(-860094543), (object)((Control)gform0_0.textBox_4).get_Text()));
		SqlDataReader val2 = val.ExecuteReader();
		try
		{
			while (((DbDataReader)(object)val2).Read())
			{
				gform0_0.gcontrol0_0.comboBox_0.get_Items().Add((object)(((DbDataReader)(object)val2)[Class9.smethod_0(-860096211)].ToString() + Class9.smethod_0(-860096477) + ((DbDataReader)(object)val2)[Class9.smethod_0(-860095850)].ToString()));
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

	public bool method_11(string string_0)
	{
		foreach (string item in gform0_0.gcontrol0_0.listBox_0.get_Items())
		{
			string[] array = item.Split(new char[1] { ' ' });
			if (array[0].Equals(string_0))
			{
				return true;
			}
		}
		return false;
	}
}
