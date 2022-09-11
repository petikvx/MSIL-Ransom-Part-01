using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns13;
using ns14;
using ns21;
using ns26;
using ns27;
using ns6;
using ns7;

namespace MySql.Data.MySqlClient;

internal sealed class StoredProcedure : Class172
{
	private string string_1;

	internal const string string_2 = "_cnet_param_";

	private string string_3;

	[CompilerGenerated]
	private bool bool_0;

	[NonSerialized]
	internal static GetString getString_2;

	public bool ServerProvidingOutputParameters
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	public override string ResolvedCommandText => string_3;

	public StoredProcedure(MySqlCommand cmd, string text)
		: base(cmd, text)
	{
	}

	private MySqlParameter method_3()
	{
		return base.Parameters?.Cast<MySqlParameter>().FirstOrDefault((MySqlParameter mySqlParameter_0) => mySqlParameter_0.Direction == ParameterDirection.ReturnValue);
	}

	internal string method_4(string string_4)
	{
		string text = string.Empty;
		StringBuilder stringBuilder = new StringBuilder(string_4);
		stringBuilder.Append(getString_2(107410808));
		string text2 = getString_2(107399253);
		foreach (MySqlParameter parameter in mySqlCommand_0.Parameters)
		{
			if (parameter.Direction == ParameterDirection.ReturnValue)
			{
				text = getString_2(107375712);
				continue;
			}
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_2(107375707), new object[1] { text2 });
			text2 = getString_2(107406231);
		}
		stringBuilder.Append(getString_2(107410803));
		return text + stringBuilder.ToString();
	}

	private Class173 method_5(string string_4)
	{
		string text = method_4(string_4);
		return base.Connection.ProcedureCache.method_0(base.Connection, string_4, text);
	}

	public static string smethod_0(string string_4)
	{
		int num = string_4.Length - 1;
		while (num > 0 && (char.IsLetterOrDigit(string_4[num]) || string_4[num] == ' '))
		{
			num--;
		}
		return Class135.smethod_0(string_4.Substring(num));
	}

	private string method_6(string string_4)
	{
		string[] array = string_4.Split(new char[1] { '.' });
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].StartsWith(getString_2(107411366), StringComparison.Ordinal))
			{
				array[i] = string.Format(getString_2(107371965), array[i]);
			}
		}
		if (array.Length == 1)
		{
			return array[0];
		}
		return string.Format(getString_2(107371956), array[0], array[1]);
	}

	private MySqlParameter method_7(string string_4, Class177 class177_0, bool bool_1, MySqlParameter mySqlParameter_0)
	{
		_ = (string)class177_0[getString_2(107352328)];
		string text = (string)class177_0[getString_2(107353067)];
		if (class177_0[getString_2(107353014)].Equals(0))
		{
			if (mySqlParameter_0 == null)
			{
				throw new InvalidOperationException(string.Format(Class121.RoutineRequiresReturnParameter, string_4));
			}
			text = mySqlParameter_0.ParameterName;
		}
		MySqlParameter mySqlParameter = mySqlCommand_0.Parameters.method_15(text, bool_1: true);
		if (!mySqlParameter.TypeHasBeenSet)
		{
			string text2 = (string)class177_0[getString_2(107352932)];
			bool flag = smethod_0(class177_0[getString_2(107353000)].ToString()).IndexOf(getString_2(107352947)) != -1;
			mySqlParameter.MySqlDbType = Class123.smethod_3(text2, flag, bool_1, base.Connection);
		}
		return mySqlParameter;
	}

	private Class151 method_8(string string_4)
	{
		Class151 @class = new Class151(mySqlCommand_0);
		MySqlParameter mySqlParameter_ = method_3();
		Class173 class2 = method_5(string_4);
		if (class2.class176_0 != null && class2.class176_0.Rows.Count != 0)
		{
			bool bool_ = class2.class176_0.Rows[0][getString_2(107352966)].ToString()!.IndexOf(getString_2(107352921)) != -1;
			{
				foreach (Class177 row in class2.class176_1.Rows)
				{
					@class.Add(method_7(string_4, row, bool_, mySqlParameter_));
				}
				return @class;
			}
		}
		throw new InvalidOperationException(string.Format(Class121.RoutineNotFound, string_4));
	}

	public override void vmethod_1(bool bool_1)
	{
		if (ResolvedCommandText == null)
		{
			ServerProvidingOutputParameters = base.Driver.SupportsOutputParameters && bool_1;
			string text = string_0;
			if (text.IndexOf(getString_2(107399028)) == -1 && !string.IsNullOrEmpty(base.Connection.Database))
			{
				text = base.Connection.Database + getString_2(107399028) + text;
			}
			text = method_6(text);
			MySqlParameter mySqlParameter_ = method_3();
			Class151 class151_ = (mySqlCommand_0.Connection.Settings.CheckParameters ? method_8(text) : base.Parameters);
			string arg = method_9(class151_, bool_1);
			string arg2 = method_10(text, mySqlParameter_, class151_);
			string arg3 = method_11(class151_, bool_1);
			string_3 = string.Format(getString_2(107352245), arg, arg2, arg3);
		}
	}

	private string method_9(Class151 class151_0, bool bool_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (ServerProvidingOutputParameters)
		{
			return stringBuilder.ToString();
		}
		string text = string.Empty;
		foreach (MySqlParameter item in class151_0)
		{
			if (item.Direction == ParameterDirection.InputOutput)
			{
				string arg = getString_2(107410989) + item.BaseName;
				string arg2 = getString_2(107354214) + item.BaseName;
				string text2 = string.Format(getString_2(107371975), arg2, arg);
				if (mySqlCommand_0.Connection.Settings.AllowBatch && !bool_1)
				{
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_2(107406294), new object[2] { text, text2 });
					text = getString_2(107410830);
				}
				else
				{
					MySqlCommand mySqlCommand = new MySqlCommand(text2, mySqlCommand_0.Connection);
					mySqlCommand.Parameters.Add(item);
					mySqlCommand.ExecuteNonQuery();
				}
			}
		}
		if (stringBuilder.Length > 0)
		{
			stringBuilder.Append(getString_2(107410830));
		}
		return stringBuilder.ToString();
	}

	private string method_10(string string_4, MySqlParameter mySqlParameter_0, Class151 class151_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = string.Empty;
		foreach (MySqlParameter item in class151_0)
		{
			if (item.Direction != ParameterDirection.ReturnValue)
			{
				string text2 = getString_2(107410989) + item.BaseName;
				string text3 = getString_2(107354214) + item.BaseName;
				bool flag = item.Direction == ParameterDirection.Input || ServerProvidingOutputParameters;
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_2(107406294), new object[2]
				{
					text,
					flag ? text2 : text3
				});
				text = getString_2(107410403);
			}
		}
		if (mySqlParameter_0 == null)
		{
			return string.Format(getString_2(107371926), string_4, stringBuilder.ToString());
		}
		return string.Format(getString_2(107371905), getString_2(107354705), mySqlParameter_0.BaseName, string_4, stringBuilder.ToString());
	}

	private string method_11(Class151 class151_0, bool bool_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = string.Empty;
		foreach (MySqlParameter item in class151_0)
		{
			if (item.Direction != ParameterDirection.Input && ((item.Direction != ParameterDirection.InputOutput && item.Direction != ParameterDirection.Output) || !ServerProvidingOutputParameters))
			{
				_ = getString_2(107410989) + item.BaseName;
				string text2 = getString_2(107354214) + item.BaseName;
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_2(107406294), new object[2] { text, text2 });
				text = getString_2(107410403);
			}
		}
		if (stringBuilder.Length == 0)
		{
			return string.Empty;
		}
		if (mySqlCommand_0.Connection.Settings.AllowBatch && !bool_1)
		{
			return string.Format(getString_2(107371908), stringBuilder.ToString());
		}
		string_1 = string.Format(getString_2(107371859), stringBuilder.ToString());
		return string.Empty;
	}

	internal void method_12(Class142 class142_0)
	{
		method_13(class142_0);
		if ((class142_0.CommandBehavior & CommandBehavior.SchemaOnly) != 0)
		{
			return;
		}
		class142_0.Read();
		string text = getString_2(107354214);
		for (int i = 0; i < class142_0.FieldCount; i++)
		{
			string text2 = class142_0.GetName(i);
			if (text2.StartsWith(text, StringComparison.OrdinalIgnoreCase))
			{
				text2 = text2.Remove(0, text.Length);
			}
			mySqlCommand_0.Parameters.method_15(text2, bool_1: true).Value = class142_0.GetValue(i);
		}
	}

	private void method_13(Class142 class142_0)
	{
		for (int i = 0; i < class142_0.FieldCount; i++)
		{
			string text = class142_0.GetName(i);
			if (text.IndexOf(getString_2(107354705)) != -1)
			{
				text = text.Remove(0, getString_2(107354705).Length + 1);
			}
			Interface0 @interface = Class145.smethod_0(mySqlCommand_0.Parameters.method_15(text, bool_1: true).MySqlDbType);
			if (@interface is Struct7 @struct)
			{
				@struct.ReadAsString = true;
				class142_0.ResultSet.method_8(i, @struct);
			}
			else
			{
				class142_0.ResultSet.method_8(i, @interface);
			}
		}
	}

	public override void vmethod_0(Class142 class142_0)
	{
		base.vmethod_0(class142_0);
		if (string.IsNullOrEmpty(string_1) || (class142_0.CommandBehavior & CommandBehavior.SchemaOnly) != 0)
		{
			return;
		}
		using Class142 class142_ = new MySqlCommand(string_1, mySqlCommand_0.Connection).method_7(class142_0.CommandBehavior);
		method_12(class142_);
	}

	static StoredProcedure()
	{
		Strings.CreateGetStringDelegate(typeof(StoredProcedure));
	}
}
