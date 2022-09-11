using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing.Design;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns21;

namespace ns27;

[ListBindable(true)]
[Editor("MySql.Data.MySqlClient.Design.DBParametersEditor,MySql.Design", typeof(UITypeEditor))]
internal sealed class Class151 : DbParameterCollection
{
	private readonly List<MySqlParameter> list_0 = new List<MySqlParameter>();

	private readonly Dictionary<string, int> dictionary_0;

	private readonly Dictionary<string, int> dictionary_1;

	internal bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	bool DbParameterCollection.IsFixedSize => ((IList)list_0).IsFixedSize;

	bool DbParameterCollection.IsReadOnly => ((IList)list_0).IsReadOnly;

	bool DbParameterCollection.IsSynchronized => ((ICollection)list_0).IsSynchronized;

	int DbParameterCollection.Count => list_0.Count;

	public new MySqlParameter this[int int_0]
	{
		get
		{
			return method_6(int_0);
		}
		set
		{
			method_9(int_0, value);
		}
	}

	public new MySqlParameter this[string string_0]
	{
		get
		{
			return method_7(string_0);
		}
		set
		{
			method_8(string_0, value);
		}
	}

	object DbParameterCollection.SyncRoot => ((ICollection)list_0).SyncRoot;

	internal Class151(MySqlCommand mySqlCommand_0)
	{
		dictionary_0 = new Dictionary<string, int>();
		dictionary_1 = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
		bool_0 = false;
		Clear();
	}

	public MySqlParameter method_0(string string_0, MySqlDbType mySqlDbType_0, int int_0, string string_1)
	{
		return Add(new MySqlParameter(string_0, mySqlDbType_0, int_0, string_1));
	}

	public MySqlParameter Add(MySqlParameter value)
	{
		return method_11(value, -1);
	}

	[Obsolete("Add(String parameterName, Object value) has been deprecated.  Use AddWithValue(String parameterName, Object value)")]
	public MySqlParameter method_1(string string_0, object object_0)
	{
		return Add(new MySqlParameter(string_0, object_0));
	}

	public MySqlParameter method_2(string string_0, object object_0)
	{
		return Add(new MySqlParameter(string_0, object_0));
	}

	public MySqlParameter method_3(string string_0, MySqlDbType mySqlDbType_0)
	{
		return Add(new MySqlParameter(string_0, mySqlDbType_0));
	}

	public MySqlParameter method_4(string string_0, MySqlDbType mySqlDbType_0, int int_0)
	{
		return Add(new MySqlParameter(string_0, mySqlDbType_0, int_0));
	}

	void DbParameterCollection.Clear()
	{
		foreach (MySqlParameter item in list_0)
		{
			item.Collection = null;
		}
		list_0.Clear();
		dictionary_0.Clear();
		dictionary_1.Clear();
	}

	private void method_5(int int_0)
	{
		if (int_0 < 0 || int_0 >= Count)
		{
			throw new IndexOutOfRangeException(getString_0(107350791));
		}
	}

	private MySqlParameter method_6(int int_0)
	{
		method_5(int_0);
		return list_0[int_0];
	}

	private MySqlParameter method_7(string string_0)
	{
		int num = IndexOf(string_0);
		if (num < 0)
		{
			if (string_0.StartsWith(getString_0(107409982), StringComparison.Ordinal) || string_0.StartsWith(getString_0(107409955), StringComparison.Ordinal))
			{
				string parameterName = string_0.Substring(1);
				num = IndexOf(parameterName);
				if (num != -1)
				{
					return list_0[num];
				}
			}
			throw new ArgumentException(getString_0(107350778) + string_0 + getString_0(107350729));
		}
		return list_0[num];
	}

	private void method_8(string string_0, MySqlParameter mySqlParameter_0)
	{
		int num = IndexOf(string_0);
		if (num < 0)
		{
			throw new ArgumentException(getString_0(107350778) + string_0 + getString_0(107350729));
		}
		method_9(num, mySqlParameter_0);
	}

	private void method_9(int int_0, MySqlParameter mySqlParameter_0)
	{
		if (mySqlParameter_0 == null)
		{
			throw new ArgumentException(Class121.NewValueShouldBeMySqlParameter);
		}
		method_5(int_0);
		MySqlParameter mySqlParameter = list_0[int_0];
		dictionary_0.Remove(mySqlParameter.ParameterName);
		dictionary_1.Remove(mySqlParameter.ParameterName);
		list_0[int_0] = mySqlParameter_0;
		dictionary_0.Add(mySqlParameter_0.ParameterName, int_0);
		dictionary_1.Add(mySqlParameter_0.ParameterName, int_0);
	}

	int DbParameterCollection.IndexOf(string parameterName)
	{
		int value = -1;
		if (!dictionary_0.TryGetValue(parameterName, out value) && !dictionary_1.TryGetValue(parameterName, out value))
		{
			return -1;
		}
		return value;
	}

	int DbParameterCollection.IndexOf(object value)
	{
		if (!(value is MySqlParameter item))
		{
			throw new ArgumentException(getString_0(107350720), getString_0(107393199));
		}
		return list_0.IndexOf(item);
	}

	internal void method_10(MySqlParameter mySqlParameter_0, string string_0, string string_1)
	{
		int value = IndexOf(string_0);
		dictionary_0.Remove(string_0);
		dictionary_1.Remove(string_0);
		dictionary_0.Add(string_1, value);
		dictionary_1.Add(string_1, value);
	}

	private MySqlParameter method_11(MySqlParameter mySqlParameter_0, int int_0)
	{
		if (mySqlParameter_0 == null)
		{
			throw new ArgumentException(getString_0(107350639), getString_0(107393199));
		}
		if (string.IsNullOrEmpty(mySqlParameter_0.ParameterName))
		{
			mySqlParameter_0.ParameterName = string.Format(getString_0(107351074), method_12());
		}
		if (IndexOf(mySqlParameter_0.ParameterName) >= 0)
		{
			throw new MySqlException(string.Format(Class121.ParameterAlreadyDefined, mySqlParameter_0.ParameterName));
		}
		string text = mySqlParameter_0.ParameterName;
		if (text[0] == '@' || text[0] == '?')
		{
			text = text.Substring(1, text.Length - 1);
		}
		if (IndexOf(text) >= 0)
		{
			throw new MySqlException(string.Format(Class121.ParameterAlreadyDefined, mySqlParameter_0.ParameterName));
		}
		if (int_0 == -1)
		{
			list_0.Add(mySqlParameter_0);
			int_0 = list_0.Count - 1;
		}
		else
		{
			list_0.Insert(int_0, mySqlParameter_0);
			method_13(int_0, bool_1: true);
		}
		dictionary_0.Add(mySqlParameter_0.ParameterName, int_0);
		dictionary_1.Add(mySqlParameter_0.ParameterName, int_0);
		mySqlParameter_0.Collection = this;
		return mySqlParameter_0;
	}

	private int method_12()
	{
		int num = Count + 1;
		while (true)
		{
			string key = getString_0(107351025) + num;
			if (!dictionary_1.ContainsKey(key))
			{
				break;
			}
			num++;
		}
		return num;
	}

	private static void smethod_0(Dictionary<string, int> dictionary_2, string string_0, int int_0, bool bool_1)
	{
		if (dictionary_2.ContainsKey(string_0))
		{
			int num = dictionary_2[string_0];
			if (num >= int_0)
			{
				dictionary_2[string_0] = ((!bool_1) ? (--num) : (++num));
			}
		}
	}

	private void method_13(int int_0, bool bool_1)
	{
		for (int i = 0; i < Count; i++)
		{
			string parameterName = list_0[i].ParameterName;
			smethod_0(dictionary_1, parameterName, int_0, bool_1);
			smethod_0(dictionary_0, parameterName, int_0, bool_1);
		}
	}

	private MySqlParameter method_14(string string_0)
	{
		int num = IndexOf(string_0);
		if (-1 == num)
		{
			num = IndexOf(getString_0(107409955) + string_0);
		}
		if (-1 == num)
		{
			num = IndexOf(getString_0(107409982) + string_0);
		}
		if (-1 != num)
		{
			return this[num];
		}
		return null;
	}

	internal MySqlParameter method_15(string string_0, bool bool_1)
	{
		string string_ = string_0;
		MySqlParameter mySqlParameter = method_14(string_);
		if (mySqlParameter != null)
		{
			return mySqlParameter;
		}
		if (string_0.StartsWith(getString_0(107409982), StringComparison.Ordinal) || string_0.StartsWith(getString_0(107409955), StringComparison.Ordinal))
		{
			string_ = string_0.Substring(1);
		}
		mySqlParameter = method_14(string_);
		if (mySqlParameter != null)
		{
			return mySqlParameter;
		}
		if (bool_1)
		{
			throw new ArgumentException(getString_0(107350778) + string_0 + getString_0(107350729));
		}
		return null;
	}

	void DbParameterCollection.AddRange(Array values)
	{
		foreach (DbParameter value in values)
		{
			Add(value);
		}
	}

	DbParameter DbParameterCollection.GetParameter(string parameterName)
	{
		return method_7(parameterName);
	}

	DbParameter DbParameterCollection.GetParameter(int index)
	{
		return method_6(index);
	}

	void DbParameterCollection.SetParameter(string parameterName, DbParameter value)
	{
		method_8(parameterName, value as MySqlParameter);
	}

	void DbParameterCollection.SetParameter(int index, DbParameter value)
	{
		method_9(index, value as MySqlParameter);
	}

	int DbParameterCollection.Add(object value)
	{
		if (!(value is MySqlParameter value2))
		{
			throw new MySqlException(getString_0(107351012));
		}
		MySqlParameter value3 = Add(value2);
		return IndexOf(value3);
	}

	bool DbParameterCollection.Contains(string value)
	{
		return IndexOf(value) != -1;
	}

	bool DbParameterCollection.Contains(object value)
	{
		if (!(value is MySqlParameter item))
		{
			throw new ArgumentException(getString_0(107350720), getString_0(107393199));
		}
		return list_0.Contains(item);
	}

	void DbParameterCollection.CopyTo(Array array, int index)
	{
		list_0.ToArray().CopyTo(array, index);
	}

	IEnumerator DbParameterCollection.GetEnumerator()
	{
		return list_0.GetEnumerator();
	}

	void DbParameterCollection.Insert(int index, object value)
	{
		if (!(value is MySqlParameter mySqlParameter_))
		{
			throw new MySqlException(getString_0(107351012));
		}
		method_11(mySqlParameter_, index);
	}

	void DbParameterCollection.Remove(object value)
	{
		MySqlParameter mySqlParameter = value as MySqlParameter;
		mySqlParameter.Collection = null;
		int int_ = IndexOf(mySqlParameter);
		list_0.Remove(mySqlParameter);
		dictionary_0.Remove(mySqlParameter.ParameterName);
		dictionary_1.Remove(mySqlParameter.ParameterName);
		method_13(int_, bool_1: false);
	}

	void DbParameterCollection.RemoveAt(string parameterName)
	{
		DbParameter parameter = GetParameter(parameterName);
		Remove(parameter);
	}

	void DbParameterCollection.RemoveAt(int index)
	{
		object value = list_0[index];
		Remove(value);
	}

	static Class151()
	{
		Strings.CreateGetStringDelegate(typeof(Class151));
	}
}
