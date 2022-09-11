using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns20;
using ns6;
using ns9;

namespace MySql.Data.MySqlClient;

public sealed class MySqlHelper
{
	private enum Enum36 : byte
	{
		const_0,
		const_1,
		const_2
	}

	private static string string_0;

	private static string string_1;

	private static Enum36[] enum36_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static Task<DataRow> smethod_0(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_1(string_2, string_3, CancellationToken.None, mySqlParameter_0);
	}

	public static Task<DataRow> smethod_1(string string_2, string string_3, CancellationToken cancellationToken_0, params MySqlParameter[] mySqlParameter_0)
	{
		TaskCompletionSource<DataRow> taskCompletionSource = new TaskCompletionSource<DataRow>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataRow result = smethod_2(string_2, string_3, mySqlParameter_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static DataRow smethod_2(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		DataSet dataSet = smethod_4(string_2, string_3, mySqlParameter_0);
		if (dataSet == null)
		{
			return null;
		}
		if (dataSet.Tables.Count == 0)
		{
			return null;
		}
		if (dataSet.Tables[0].Rows.Count == 0)
		{
			return null;
		}
		return dataSet.Tables[0].Rows[0];
	}

	public static DataSet smethod_3(string string_2, string string_3)
	{
		return smethod_4(string_2, string_3, (MySqlParameter[])null);
	}

	public static DataSet smethod_4(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		using Class139 @class = new Class139(string_2);
		@class.Open();
		return smethod_6(@class, string_3, mySqlParameter_0);
	}

	public static DataSet smethod_5(Class139 class139_0, string string_2)
	{
		return smethod_6(class139_0, string_2, (MySqlParameter[])null);
	}

	public static DataSet smethod_6(Class139 class139_0, string string_2, params MySqlParameter[] mySqlParameter_0)
	{
		MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = class139_0;
		mySqlCommand.CommandText = string_2;
		mySqlCommand.CommandType = CommandType.Text;
		if (mySqlParameter_0 != null)
		{
			foreach (MySqlParameter value in mySqlParameter_0)
			{
				mySqlCommand.Parameters.Add(value);
			}
		}
		Class149 @class = new Class149(mySqlCommand);
		DataSet dataSet = new DataSet();
		@class.Fill(dataSet);
		mySqlCommand.Parameters.Clear();
		return dataSet;
	}

	public static void smethod_7(string string_2, string string_3, DataSet dataSet_0, string string_4)
	{
		Class139 @class = new Class139(string_2);
		@class.Open();
		Class149 class2 = new Class149(string_3, @class);
		new Class148(class2).ToString();
		class2.Update(dataSet_0, string_4);
		@class.Close();
	}

	public static Task<DataSet> smethod_8(string string_2, string string_3)
	{
		return smethod_11(string_2, string_3, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<DataSet> smethod_9(string string_2, string string_3, CancellationToken cancellationToken_0)
	{
		return smethod_11(string_2, string_3, cancellationToken_0, (MySqlParameter[])null);
	}

	public static Task<DataSet> smethod_10(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_11(string_2, string_3, CancellationToken.None, mySqlParameter_0);
	}

	public static Task<DataSet> smethod_11(string string_2, string string_3, CancellationToken cancellationToken_0, params MySqlParameter[] mySqlParameter_0)
	{
		TaskCompletionSource<DataSet> taskCompletionSource = new TaskCompletionSource<DataSet>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataSet result = smethod_4(string_2, string_3, mySqlParameter_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<DataSet> smethod_12(Class139 class139_0, string string_2)
	{
		return smethod_15(class139_0, string_2, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<DataSet> smethod_13(Class139 class139_0, string string_2, CancellationToken cancellationToken_0)
	{
		return smethod_15(class139_0, string_2, cancellationToken_0, (MySqlParameter[])null);
	}

	public static Task<DataSet> smethod_14(Class139 class139_0, string string_2, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_15(class139_0, string_2, CancellationToken.None, mySqlParameter_0);
	}

	public static Task<DataSet> smethod_15(Class139 class139_0, string string_2, CancellationToken cancellationToken_0, params MySqlParameter[] mySqlParameter_0)
	{
		TaskCompletionSource<DataSet> taskCompletionSource = new TaskCompletionSource<DataSet>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataSet result = smethod_6(class139_0, string_2, mySqlParameter_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task smethod_16(string string_2, string string_3, DataSet dataSet_0, string string_4)
	{
		return smethod_17(string_2, string_3, dataSet_0, string_4, CancellationToken.None);
	}

	public static Task smethod_17(string string_2, string string_3, DataSet dataSet_0, string string_4, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				smethod_7(string_2, string_3, dataSet_0, string_4);
				taskCompletionSource.SetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	private MySqlHelper()
	{
	}

	public static int smethod_18(Class139 class139_0, string string_2, params MySqlParameter[] mySqlParameter_0)
	{
		MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = class139_0;
		mySqlCommand.CommandText = string_2;
		mySqlCommand.CommandType = CommandType.Text;
		if (mySqlParameter_0 != null)
		{
			foreach (MySqlParameter value in mySqlParameter_0)
			{
				mySqlCommand.Parameters.Add(value);
			}
		}
		int result = mySqlCommand.ExecuteNonQuery();
		mySqlCommand.Parameters.Clear();
		return result;
	}

	public static int smethod_19(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		using Class139 @class = new Class139(string_2);
		@class.Open();
		return smethod_18(@class, string_3, mySqlParameter_0);
	}

	private static Class142 smethod_20(Class139 class139_0, Class181 class181_0, string string_2, MySqlParameter[] mySqlParameter_0, bool bool_0)
	{
		MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = class139_0;
		mySqlCommand.Transaction = class181_0;
		mySqlCommand.CommandText = string_2;
		mySqlCommand.CommandType = CommandType.Text;
		if (mySqlParameter_0 != null)
		{
			foreach (MySqlParameter value in mySqlParameter_0)
			{
				mySqlCommand.Parameters.Add(value);
			}
		}
		Class142 result = ((!bool_0) ? mySqlCommand.method_7(CommandBehavior.CloseConnection) : mySqlCommand.method_6());
		mySqlCommand.Parameters.Clear();
		return result;
	}

	public static Class142 smethod_21(string string_2, string string_3)
	{
		return smethod_23(string_2, string_3, (MySqlParameter[])null);
	}

	public static Class142 smethod_22(Class139 class139_0, string string_2)
	{
		return smethod_20(class139_0, null, string_2, null, bool_0: true);
	}

	public static Class142 smethod_23(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		Class139 @class = new Class139(string_2);
		@class.Open();
		return smethod_20(@class, null, string_3, mySqlParameter_0, bool_0: false);
	}

	public static Class142 smethod_24(Class139 class139_0, string string_2, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_20(class139_0, null, string_2, mySqlParameter_0, bool_0: true);
	}

	public static object smethod_25(string string_2, string string_3)
	{
		return smethod_26(string_2, string_3, (MySqlParameter[])null);
	}

	public static object smethod_26(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		using Class139 @class = new Class139(string_2);
		@class.Open();
		return smethod_28(@class, string_3, mySqlParameter_0);
	}

	public static object smethod_27(Class139 class139_0, string string_2)
	{
		return smethod_28(class139_0, string_2, (MySqlParameter[])null);
	}

	public static object smethod_28(Class139 class139_0, string string_2, params MySqlParameter[] mySqlParameter_0)
	{
		MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = class139_0;
		mySqlCommand.CommandText = string_2;
		mySqlCommand.CommandType = CommandType.Text;
		if (mySqlParameter_0 != null)
		{
			foreach (MySqlParameter value in mySqlParameter_0)
			{
				mySqlCommand.Parameters.Add(value);
			}
		}
		object result = mySqlCommand.ExecuteScalar();
		mySqlCommand.Parameters.Clear();
		return result;
	}

	private static Enum36[] smethod_29()
	{
		Enum36[] array = new Enum36[65536];
		string text = string_0;
		foreach (char c in text)
		{
			array[(uint)c] = Enum36.const_2;
		}
		text = string_1;
		foreach (char c2 in text)
		{
			array[(uint)c2] = Enum36.const_1;
		}
		return array;
	}

	private static bool smethod_30(string string_2)
	{
		return string_2.Any((char char_0) => enum36_0[(uint)char_0] != Enum36.const_0);
	}

	public static string smethod_31(string string_2)
	{
		if (!smethod_30(string_2))
		{
			return string_2;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in string_2)
		{
			if (enum36_0[(uint)c] != 0)
			{
				stringBuilder.Append(getString_0(107396541));
			}
			stringBuilder.Append(c);
		}
		return stringBuilder.ToString();
	}

	public static string smethod_32(string string_2)
	{
		if (!smethod_30(string_2))
		{
			return string_2;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in string_2)
		{
			switch (enum36_0[(uint)c])
			{
			case Enum36.const_1:
				stringBuilder.Append(c);
				break;
			case Enum36.const_2:
				stringBuilder.Append(getString_0(107396541));
				break;
			}
			stringBuilder.Append(c);
		}
		return stringBuilder.ToString();
	}

	public static Task<int> smethod_33(Class139 class139_0, string string_2, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_34(class139_0, string_2, CancellationToken.None, mySqlParameter_0);
	}

	public static Task<int> smethod_34(Class139 class139_0, string string_2, CancellationToken cancellationToken_0, params MySqlParameter[] mySqlParameter_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = smethod_18(class139_0, string_2, mySqlParameter_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<int> smethod_35(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_36(string_2, string_3, CancellationToken.None, mySqlParameter_0);
	}

	public static Task<int> smethod_36(string string_2, string string_3, CancellationToken cancellationToken_0, params MySqlParameter[] mySqlParameter_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = smethod_19(string_2, string_3, mySqlParameter_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	private static Task<Class142> smethod_37(Class139 class139_0, Class181 class181_0, string string_2, MySqlParameter[] mySqlParameter_0, bool bool_0)
	{
		return smethod_38(class139_0, class181_0, string_2, mySqlParameter_0, bool_0, CancellationToken.None);
	}

	private static Task<Class142> smethod_38(Class139 class139_0, Class181 class181_0, string string_2, MySqlParameter[] mySqlParameter_0, bool bool_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<Class142> taskCompletionSource = new TaskCompletionSource<Class142>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				Class142 result = smethod_20(class139_0, class181_0, string_2, mySqlParameter_0, bool_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<Class142> smethod_39(string string_2, string string_3)
	{
		return smethod_44(string_2, string_3, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<Class142> smethod_40(string string_2, string string_3, CancellationToken cancellationToken_0)
	{
		return smethod_44(string_2, string_3, cancellationToken_0, (MySqlParameter[])null);
	}

	public static Task<Class142> smethod_41(Class139 class139_0, string string_2)
	{
		return smethod_38(class139_0, null, string_2, null, bool_0: true, CancellationToken.None);
	}

	public static Task<Class142> smethod_42(Class139 class139_0, string string_2, CancellationToken cancellationToken_0)
	{
		return smethod_38(class139_0, null, string_2, null, bool_0: true, cancellationToken_0);
	}

	public static Task<Class142> smethod_43(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_44(string_2, string_3, CancellationToken.None, mySqlParameter_0);
	}

	public static Task<Class142> smethod_44(string string_2, string string_3, CancellationToken cancellationToken_0, params MySqlParameter[] mySqlParameter_0)
	{
		TaskCompletionSource<Class142> taskCompletionSource = new TaskCompletionSource<Class142>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				Class142 result = smethod_23(string_2, string_3, mySqlParameter_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<Class142> smethod_45(Class139 class139_0, string string_2, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_38(class139_0, null, string_2, mySqlParameter_0, bool_0: true, CancellationToken.None);
	}

	public static Task<Class142> smethod_46(Class139 class139_0, string string_2, CancellationToken cancellationToken_0, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_38(class139_0, null, string_2, mySqlParameter_0, bool_0: true, cancellationToken_0);
	}

	public static Task<object> smethod_47(string string_2, string string_3)
	{
		return smethod_50(string_2, string_3, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<object> smethod_48(string string_2, string string_3, CancellationToken cancellationToken_0)
	{
		return smethod_50(string_2, string_3, cancellationToken_0, (MySqlParameter[])null);
	}

	public static Task<object> smethod_49(string string_2, string string_3, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_50(string_2, string_3, CancellationToken.None, mySqlParameter_0);
	}

	public static Task<object> smethod_50(string string_2, string string_3, CancellationToken cancellationToken_0, params MySqlParameter[] mySqlParameter_0)
	{
		TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				object result = smethod_26(string_2, string_3, mySqlParameter_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<object> smethod_51(Class139 class139_0, string string_2)
	{
		return smethod_54(class139_0, string_2, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<object> smethod_52(Class139 class139_0, string string_2, CancellationToken cancellationToken_0)
	{
		return smethod_54(class139_0, string_2, cancellationToken_0, (MySqlParameter[])null);
	}

	public static Task<object> smethod_53(Class139 class139_0, string string_2, params MySqlParameter[] mySqlParameter_0)
	{
		return smethod_54(class139_0, string_2, CancellationToken.None, mySqlParameter_0);
	}

	public static Task<object> smethod_54(Class139 class139_0, string string_2, CancellationToken cancellationToken_0, params MySqlParameter[] mySqlParameter_0)
	{
		TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				object result = smethod_28(class139_0, string_2, mySqlParameter_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	static MySqlHelper()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlHelper));
		string_0 = getString_0(107351525);
		string_1 = getString_0(107351468);
		enum36_0 = smethod_29();
	}
}
