using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns11;
using ns2;
using ns21;
using ns22;
using ns27;
using ns6;

namespace ns15;

internal abstract class Class171
{
	protected MySqlCommand mySqlCommand_0;

	private readonly List<Class167> list_0;

	protected string string_0;

	[NonSerialized]
	internal static GetString getString_0;

	public virtual string ResolvedCommandText => string_0;

	protected Class143 Driver => mySqlCommand_0.Connection.class143_0;

	protected Class139 Connection => mySqlCommand_0.Connection;

	protected Class151 Parameters => mySqlCommand_0.Parameters;

	private Class171(MySqlCommand mySqlCommand_1)
	{
		mySqlCommand_0 = mySqlCommand_1;
		list_0 = new List<Class167>();
	}

	protected Class171(MySqlCommand mySqlCommand_1, string string_1)
		: this(mySqlCommand_1)
	{
		string_0 = string_1;
	}

	public virtual void vmethod_0(Class142 class142_0)
	{
	}

	public virtual void vmethod_1(bool bool_0)
	{
	}

	public virtual void vmethod_2()
	{
		vmethod_4();
		vmethod_3();
	}

	public virtual bool vmethod_3()
	{
		if (list_0.Count == 0)
		{
			return false;
		}
		Class167 class167_ = list_0[0];
		Driver.vmethod_4(class167_);
		list_0.RemoveAt(0);
		return true;
	}

	protected virtual void vmethod_4()
	{
		Class151 parameters = mySqlCommand_0.Parameters;
		int num = 0;
		do
		{
			method_0(ResolvedCommandText, parameters, null);
			if (mySqlCommand_0.Batch == null)
			{
				break;
			}
			while (num < mySqlCommand_0.Batch.Count)
			{
				MySqlCommand mySqlCommand = mySqlCommand_0.Batch[num++];
				Class167 @class = list_0[list_0.Count - 1];
				long num2 = mySqlCommand.method_19();
				if (@class.Length - 4 + num2 <= Connection.class143_0.MaxPacketSize)
				{
					list_0.RemoveAt(list_0.Count - 1);
					string resolvedCommandText = ResolvedCommandText;
					if (resolvedCommandText.StartsWith(getString_0(107410760), StringComparison.Ordinal))
					{
						@class.method_18(getString_0(107410355));
					}
					else
					{
						@class.method_18(getString_0(107410782));
					}
					method_0(resolvedCommandText, mySqlCommand.Parameters, @class);
					if (@class.Length - 4 > Connection.class143_0.MaxPacketSize)
					{
						parameters = mySqlCommand.Parameters;
						break;
					}
					continue;
				}
				parameters = mySqlCommand.Parameters;
				break;
			}
		}
		while (num != mySqlCommand_0.Batch.Count);
	}

	private void method_0(string string_1, Class151 class151_0, Class167 class167_0)
	{
		bool sqlServerMode = mySqlCommand_0.Connection.Settings.SqlServerMode;
		if (class167_0 == null)
		{
			class167_0 = new Class167(Driver.Encoding)
			{
				Version = Driver.Version
			};
			class167_0.method_3(0);
		}
		Class127 @class = new Class127(string_1)
		{
			ReturnComments = true,
			SqlServerMode = sqlServerMode
		};
		int num = 0;
		string text = @class.method_1();
		int num2 = 0;
		while (text != null)
		{
			class167_0.method_18(string_1.Substring(num, @class.StartIndex - num));
			num = @class.StopIndex;
			if (Class127.smethod_0(text))
			{
				if ((!class151_0.bool_0 && text.Length == 1 && num2 > 0) || (class151_0.bool_0 && text.Length > 1))
				{
					throw new MySqlException(Class121.MixedParameterNamingNotAllowed);
				}
				class151_0.bool_0 = text.Length == 1;
				if (method_1(class151_0, class167_0, text, num2))
				{
					text = null;
				}
				num2++;
			}
			if (text != null)
			{
				if (sqlServerMode && @class.Quoted && text.StartsWith(getString_0(107410956), StringComparison.Ordinal))
				{
					text = string.Format(getString_0(107371917), text.Substring(1, text.Length - 2));
				}
				class167_0.method_18(text);
			}
			text = @class.method_1();
		}
		list_0.Add(class167_0);
	}

	protected virtual bool vmethod_5(string string_1)
	{
		if (Connection.Settings.AllowUserVariables)
		{
			return true;
		}
		if (string_1.StartsWith(getString_0(107354166), StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		if (string_1.Length > 1 && (string_1[1] == '`' || string_1[1] == '\''))
		{
			return true;
		}
		return false;
	}

	private bool method_1(Class151 class151_0, Class167 class167_0, string string_1, int int_0)
	{
		MySqlParameter mySqlParameter = null;
		if (!class151_0.bool_0)
		{
			mySqlParameter = class151_0.method_15(string_1, bool_1: false);
		}
		else
		{
			if (int_0 > class151_0.Count)
			{
				throw new MySqlException(Class121.ParameterIndexNotFound);
			}
			mySqlParameter = class151_0[int_0];
		}
		if (mySqlParameter == null)
		{
			if (string_1.StartsWith(getString_0(107410941), StringComparison.Ordinal) && vmethod_5(string_1))
			{
				return false;
			}
			throw new MySqlException(string.Format(Class121.ParameterMustBeDefined, string_1));
		}
		mySqlParameter.method_3(class167_0, bool_3: false, Connection.Settings);
		return true;
	}

	static Class171()
	{
		Strings.CreateGetStringDelegate(typeof(Class171));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399383), getString_0(107399378)).Replace(getString_0(107399341), getString_0(107399336)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399331)))
		{
			throw new SecurityException(getString_0(107399306));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
