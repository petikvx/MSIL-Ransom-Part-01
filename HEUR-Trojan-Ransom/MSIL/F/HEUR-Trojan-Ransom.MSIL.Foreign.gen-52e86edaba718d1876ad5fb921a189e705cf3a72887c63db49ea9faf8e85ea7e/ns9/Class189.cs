using System;
using System.Collections.Generic;
using System.IO;
using MySql.Data.MySqlClient.Memcached;
using ns13;
using ns21;
using ns23;
using ns4;

namespace ns9;

internal abstract class Class189
{
	protected uint uint_0;

	protected string string_0;

	protected Stream stream_0;

	public static Class189 smethod_0(string string_1, uint uint_1, Enum53 enum53_0)
	{
		if ((enum53_0 | Enum53.flag_0) != 0)
		{
			return new Class190(string_1, uint_1);
		}
		if ((enum53_0 | Enum53.flag_1) != 0)
		{
			return new BinaryClient(string_1, uint_1);
		}
		return null;
	}

	public virtual void vmethod_0()
	{
		stream_0 = Class134.smethod_0(string_0, uint_0, null, 10u, default(Struct23), 60u);
	}

	public virtual void vmethod_1()
	{
		stream_0.Dispose();
	}

	protected Class189(string string_1, uint uint_1)
	{
		string_0 = string_1;
		uint_0 = uint_1;
	}

	public abstract void vmethod_2(string string_1, object object_0, TimeSpan timeSpan_0);

	public abstract void vmethod_3(string string_1, object object_0);

	public abstract void vmethod_4(string string_1, object object_0, TimeSpan timeSpan_0, ulong ulong_0);

	public abstract void vmethod_5(string string_1, int int_0);

	public abstract void vmethod_6(string string_1);

	public abstract void vmethod_7(TimeSpan timeSpan_0);

	public abstract KeyValuePair<string, object> vmethod_8(string string_1);

	public abstract void vmethod_9(string string_1, int int_0);

	public abstract void vmethod_10(string string_1, object object_0);

	public abstract void vmethod_11(string string_1, object object_0, TimeSpan timeSpan_0);

	public abstract void vmethod_12(string string_1, object object_0, TimeSpan timeSpan_0);
}
