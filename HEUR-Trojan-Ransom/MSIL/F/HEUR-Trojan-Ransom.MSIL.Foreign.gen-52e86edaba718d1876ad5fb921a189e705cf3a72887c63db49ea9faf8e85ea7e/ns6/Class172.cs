using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns15;
using ns21;
using ns22;
using ns7;

namespace ns6;

internal class Class172 : Class171
{
	private BitArray bitArray_0;

	private readonly List<MySqlParameter> list_1 = new List<MySqlParameter>();

	private Class167 class167_0;

	private int int_0;

	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	[NonSerialized]
	internal static GetString getString_1;

	public int ExecutionCount
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public bool IsPrepared => StatementId > 0;

	public int StatementId
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		private set
		{
			int_3 = value;
		}
	}

	public Class172(MySqlCommand mySqlCommand_1, string string_1)
		: base(mySqlCommand_1, string_1)
	{
	}

	public virtual void vmethod_6()
	{
		string string_;
		List<string> list = method_2(out string_);
		Class145[] class145_ = null;
		StatementId = base.Driver.vmethod_10(string_, ref class145_);
		int num = 0;
		while (true)
		{
			if (num < list.Count)
			{
				string arg = list[num];
				MySqlParameter mySqlParameter = base.Parameters.method_15(arg, bool_1: false);
				if (mySqlParameter != null)
				{
					mySqlParameter.Encoding = class145_[num].encoding_0;
					list_1.Add(mySqlParameter);
					num++;
					continue;
				}
				throw new InvalidOperationException(string.Format(Class121.ParameterNotFoundDuringPrepare, arg));
			}
			int num2 = 0;
			if (class145_ != null && class145_.Length != 0)
			{
				bitArray_0 = new BitArray(class145_.Length);
				num2 = (bitArray_0.Length + 7) / 8;
			}
			class167_0 = new Class167(base.Driver.Encoding);
			class167_0.method_3(0);
			class167_0.method_14(StatementId, 4);
			class167_0.method_3(0);
			class167_0.method_14(1L, 4);
			int_1 = class167_0.Position;
			class167_0.Position += num2;
			class167_0.method_3(1);
			foreach (MySqlParameter item in list_1)
			{
				class167_0.method_14(item.method_2(), 2);
			}
			break;
		}
		int_0 = class167_0.Position;
	}

	public override void vmethod_2()
	{
		if (!IsPrepared)
		{
			base.vmethod_2();
			return;
		}
		class167_0.Position = int_0;
		for (int i = 0; i < list_1.Count; i++)
		{
			MySqlParameter mySqlParameter = list_1[i];
			bitArray_0[i] = mySqlParameter.Value == DBNull.Value || mySqlParameter.Value == null || mySqlParameter.Direction == ParameterDirection.Output;
			if (!bitArray_0[i])
			{
				class167_0.Encoding = mySqlParameter.Encoding;
				mySqlParameter.method_3(class167_0, bool_3: true, base.Connection.Settings);
			}
		}
		bitArray_0?.CopyTo(class167_0.Buffer, int_1);
		ExecutionCount++;
		base.Driver.vmethod_12(class167_0);
	}

	public override bool vmethod_3()
	{
		if (!IsPrepared)
		{
			return base.vmethod_3();
		}
		return false;
	}

	private List<string> method_2(out string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		List<string> list = new List<string>();
		int num = 0;
		string resolvedCommandText = ResolvedCommandText;
		Class127 @class = new Class127(resolvedCommandText);
		for (string text = @class.method_2(); text != null; text = @class.method_2())
		{
			if (text.IndexOf(getString_1(107354653)) == -1)
			{
				stringBuilder.Append(resolvedCommandText.Substring(num, @class.StartIndex - num));
				stringBuilder.Append(getString_1(107410910));
				list.Add(text);
				num = @class.StopIndex;
			}
		}
		stringBuilder.Append(resolvedCommandText.Substring(num));
		string_1 = stringBuilder.ToString();
		return list;
	}

	public virtual void vmethod_7()
	{
		if (IsPrepared)
		{
			base.Driver.vmethod_13(StatementId);
			StatementId = 0;
		}
	}

	static Class172()
	{
		Strings.CreateGetStringDelegate(typeof(Class172));
	}
}
