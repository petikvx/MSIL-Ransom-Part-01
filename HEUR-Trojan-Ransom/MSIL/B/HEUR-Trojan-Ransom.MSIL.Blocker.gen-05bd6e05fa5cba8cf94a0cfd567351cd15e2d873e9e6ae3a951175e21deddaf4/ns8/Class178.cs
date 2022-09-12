using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;
using ns10;
using ns12;
using ns17;
using ns2;
using ns5;
using ns7;

namespace ns8;

internal class Class178 : Class176
{
	private string? string_0;

	private readonly List<JToken> list_0 = new List<JToken>();

	protected override IList<JToken> ChildrenTokens => list_0;

	public string? Name
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public override JTokenType Type => JTokenType.Constructor;

	public override JToken? this[object object_2]
	{
		get
		{
			Class113.smethod_0(object_2, "key");
			if (!(object_2 is int int_))
			{
				throw new ArgumentException("Accessed JConstructor values with invalid key value: {0}. Argument position index expected.".smethod_1(CultureInfo.InvariantCulture, Class4.smethod_269(object_2)));
			}
			return vmethod_16(int_);
		}
		set
		{
			Class113.smethod_0(object_2, "key");
			if (!(object_2 is int int_))
			{
				throw new ArgumentException("Set JConstructor values with invalid key value: {0}. Argument position index expected.".smethod_1(CultureInfo.InvariantCulture, Class4.smethod_269(object_2)));
			}
			vmethod_17(int_, value);
		}
	}

	internal override int vmethod_12(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return -1;
		}
		return list_0.smethod_8(jtoken_2);
	}

	internal override void vmethod_23(object object_2, Class194? class194_0)
	{
		if (object_2 is Class178 @class)
		{
			if (@class.Name != null)
			{
				Name = @class.Name;
			}
			Class4.smethod_580((Class176)this, (IEnumerable)@class, class194_0);
		}
	}

	public Class178()
	{
	}

	public Class178(Class178 class178_0)
		: base(class178_0)
	{
		string_0 = class178_0.Name;
	}

	public Class178(string string_1, params object[] object_2)
		: this(string_1, (object)object_2)
	{
	}

	public Class178(string string_1, object object_2)
		: this(string_1)
	{
		Add(object_2);
	}

	public Class178(string string_1)
	{
		if (string_1 == null)
		{
			throw new ArgumentNullException("name");
		}
		if (string_1.Length == 0)
		{
			throw new ArgumentException("Constructor name cannot be empty.", "name");
		}
		string_0 = string_1;
	}

	internal override bool vmethod_1(JToken jtoken_2)
	{
		if (jtoken_2 is Class178 @class && string_0 == @class.Name)
		{
			return method_10(@class);
		}
		return false;
	}

	internal override JToken vmethod_0()
	{
		return new Class178(this);
	}

	public override void vmethod_5(Class38 class38_0, params Class9[] class9_0)
	{
		class38_0.vmethod_7(string_0);
		int count = list_0.Count;
		for (int i = 0; i < count; i++)
		{
			list_0[i].vmethod_5(class38_0, class9_0);
		}
		class38_0.vmethod_8();
	}

	internal override int vmethod_6()
	{
		return (string_0?.GetHashCode() ?? 0) ^ method_16();
	}
}
