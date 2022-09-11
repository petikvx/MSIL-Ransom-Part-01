using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns11;
using ns12;
using ns13;
using ns17;
using ns2;
using ns22;
using ns7;

namespace ns21;

internal sealed class Class144 : Class143
{
	private static long long_1;

	private long long_2;

	private Class175 class175_0;

	private int int_2;

	[NonSerialized]
	internal static GetString getString_1;

	public Class144(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
		: base(mySqlConnectionStringBuilder_1)
	{
		long_2 = Interlocked.Increment(ref long_1);
	}

	public override void vmethod_0()
	{
		base.vmethod_0();
		MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_0, Class121.TraceOpenConnection, long_2, base.Settings.ConnectionString, base.ThreadID);
	}

	public override void vmethod_1()
	{
		base.vmethod_1();
		MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_1, Class121.TraceCloseConnection, long_2);
	}

	public override void vmethod_4(Class167 class167_0)
	{
		int_2 = 0;
		string text = base.Encoding.GetString(class167_0.Buffer, 5, class167_0.Length - 5);
		string text2 = null;
		if (text.Length > 300)
		{
			text2 = new QueryNormalizer().method_0(text);
			text = text.Substring(0, 300);
		}
		base.vmethod_4(class167_0);
		MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_2, Class121.TraceQueryOpened, long_2, base.ThreadID, text);
		if (text2 != null)
		{
			MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_13, Class121.TraceQueryNormalized, long_2, base.ThreadID, text2);
		}
	}

	protected override int vmethod_6(int int_3, ref int int_4, ref long long_3)
	{
		try
		{
			int num = base.vmethod_6(int_3, ref int_4, ref long_3);
			MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_3, Class121.TraceResult, long_2, num, int_4, long_3);
			return num;
		}
		catch (MySqlException ex)
		{
			MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_12, Class121.TraceOpenResultError, long_2, ex.Number, ex.Message);
			throw ex;
		}
	}

	public override Class175 vmethod_5(int int_3, bool bool_5)
	{
		if (class175_0 != null)
		{
			if (base.Settings.UseUsageAdvisor)
			{
				method_12(int_3, class175_0);
			}
			MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_4, Class121.TraceResultClosed, long_2, class175_0.TotalRows, class175_0.SkippedRows, int_2);
			int_2 = 0;
			class175_0 = null;
		}
		class175_0 = base.vmethod_5(int_3, bool_5);
		return class175_0;
	}

	public override int vmethod_10(string string_1, ref Class145[] class145_0)
	{
		int num = base.vmethod_10(string_1, ref class145_0);
		MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_6, Class121.TraceStatementPrepared, long_2, string_1, num);
		return num;
	}

	public override void vmethod_13(int int_3)
	{
		base.vmethod_13(int_3);
		MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_8, Class121.TraceStatementClosed, long_2, int_3);
	}

	public override void vmethod_11(string string_1)
	{
		base.vmethod_11(string_1);
		MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_9, Class121.TraceSetDatabase, long_2, string_1);
	}

	public override void vmethod_12(Class167 class167_0)
	{
		base.vmethod_12(class167_0);
		int position = class167_0.Position;
		class167_0.Position = 1;
		int num = class167_0.method_13(4);
		class167_0.Position = position;
		MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_7, Class121.TraceStatementExecuted, long_2, num, base.ThreadID);
	}

	public override bool vmethod_7(int int_3, int int_4)
	{
		try
		{
			bool num = base.vmethod_7(int_3, int_4);
			if (num)
			{
				int_2 += (interface1_0 as Class169).Packet.Length;
			}
			return num;
		}
		catch (MySqlException ex)
		{
			MySqlTrace.smethod_5(TraceEventType.Error, Enum47.const_12, Class121.TraceFetchError, long_2, ex.Number, ex.Message);
			throw ex;
		}
	}

	public override void vmethod_15(Class139 class139_0, int int_3)
	{
		base.vmethod_15(class139_0, int_3);
		MySqlTrace.smethod_5(TraceEventType.Information, Enum47.const_5, Class121.TraceQueryDone, long_2);
	}

	public override List<Class166> vmethod_3(Class139 class139_0)
	{
		List<Class166> list = base.vmethod_3(class139_0);
		foreach (Class166 item in list)
		{
			MySqlTrace.smethod_5(TraceEventType.Warning, Enum47.const_11, Class121.TraceWarning, long_2, item.Level, item.Code, item.Message);
		}
		return list;
	}

	private bool method_11(Class175 class175_1)
	{
		if (class175_1.Fields != null && class175_1.Fields.Length != 0)
		{
			int num = 0;
			while (true)
			{
				if (num < class175_1.Fields.Length)
				{
					if (!class175_1.method_7(num))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	private void method_12(int int_3, Class175 class175_1)
	{
		if (!base.Settings.UseUsageAdvisor)
		{
			return;
		}
		if (method_2(Enum38.flag_5))
		{
			MySqlTrace.smethod_5(TraceEventType.Warning, Enum47.const_10, Class121.TraceUAWarningNoIndex, long_2, UsageAdvisorWarningFlags.NoIndex);
		}
		else if (method_2(Enum38.flag_4))
		{
			MySqlTrace.smethod_5(TraceEventType.Warning, Enum47.const_10, Class121.TraceUAWarningBadIndex, long_2, UsageAdvisorWarningFlags.BadIndex);
		}
		if (class175_1.SkippedRows > 0)
		{
			MySqlTrace.smethod_5(TraceEventType.Warning, Enum47.const_10, Class121.TraceUAWarningSkippedRows, long_2, UsageAdvisorWarningFlags.SkippedRows, class175_1.SkippedRows);
		}
		if (!method_11(class175_1))
		{
			StringBuilder stringBuilder = new StringBuilder(getString_1(107399280));
			string arg = getString_1(107399280);
			for (int i = 0; i < class175_1.Size; i++)
			{
				if (!class175_1.method_7(i))
				{
					stringBuilder.AppendFormat(getString_1(107406321), arg, class175_1.Fields[i].string_1);
					arg = getString_1(107406258);
				}
			}
			MySqlTrace.smethod_5(TraceEventType.Warning, Enum47.const_10, Class121.TraceUAWarningSkippedColumns, long_2, UsageAdvisorWarningFlags.SkippedColumns, stringBuilder.ToString());
		}
		if (class175_1.Fields == null)
		{
			return;
		}
		Class145[] fields = class175_1.Fields;
		foreach (Class145 @class in fields)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			string arg2 = getString_1(107399280);
			foreach (Type typeConversion in @class.TypeConversions)
			{
				stringBuilder2.AppendFormat(getString_1(107406321), arg2, typeConversion.Name);
				arg2 = getString_1(107406258);
			}
			if (stringBuilder2.Length > 0)
			{
				MySqlTrace.smethod_5(TraceEventType.Warning, Enum47.const_10, Class121.TraceUAWarningFieldConversion, long_2, UsageAdvisorWarningFlags.FieldConversion, @class.string_1, stringBuilder2.ToString());
			}
		}
	}

	static Class144()
	{
		Strings.CreateGetStringDelegate(typeof(Class144));
	}
}
