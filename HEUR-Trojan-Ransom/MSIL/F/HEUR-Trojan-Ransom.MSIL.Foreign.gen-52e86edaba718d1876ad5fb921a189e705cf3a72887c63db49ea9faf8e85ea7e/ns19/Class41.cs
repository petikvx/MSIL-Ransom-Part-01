using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns18;
using ns2;
using ns20;
using ns7;

namespace ns19;

internal sealed class Class41 : Class38
{
	[CompilerGenerated]
	private BaseSession baseSession_0;

	[NonSerialized]
	internal static GetString getString_1;

	public new BaseSession Session
	{
		[CompilerGenerated]
		get
		{
			return baseSession_0;
		}
		[CompilerGenerated]
		private set
		{
			baseSession_0 = value;
		}
	}

	internal Class41(BaseSession baseSession_1, string string_1)
		: base(null, string_1)
	{
		base.Schema = this;
		Session = baseSession_1;
	}

	public List<Class39> method_0()
	{
		return Session.XSession.method_20<Class39>(this, new string[1] { getString_1(107408538) });
	}

	public List<Class42> method_1()
	{
		return Session.XSession.method_20<Class42>(this, new string[2]
		{
			getString_1(107408489),
			getString_1(107408480)
		});
	}

	public Class39 method_2(string string_1, bool bool_0 = false)
	{
		Class39 @class = new Class40<Class43>(this, string_1);
		if (bool_0 && !@class.vmethod_0())
		{
			throw new MySqlException(string.Format(getString_1(107408503), string_1));
		}
		return @class;
	}

	public Class40<T> method_3<T>(string string_1)
	{
		return new Class40<T>(this, string_1);
	}

	public Class42 method_4(string string_1)
	{
		return method_5(string_1);
	}

	public Class42 method_5(string string_1)
	{
		return new Class42(this, string_1);
	}

	public Class39 method_6(string string_1, bool bool_0 = false)
	{
		Class39 @class = new Class39(this, string_1);
		if (bool_0 && @class.vmethod_0())
		{
			return @class;
		}
		Session.XSession.method_12(base.Name, string_1);
		return new Class39(this, string_1);
	}

	public void method_7(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			throw new ArgumentNullException(getString_1(107407914));
		}
		if (method_2(string_1).vmethod_0())
		{
			Session.XSession.method_13(base.Name, string_1);
		}
	}

	public override bool vmethod_0()
	{
		string text = string.Format(getString_1(107407905), base.Name);
		return (long)Session.InternalSession.method_4(text) > 0L;
	}

	static Class41()
	{
		Strings.CreateGetStringDelegate(typeof(Class41));
	}
}
