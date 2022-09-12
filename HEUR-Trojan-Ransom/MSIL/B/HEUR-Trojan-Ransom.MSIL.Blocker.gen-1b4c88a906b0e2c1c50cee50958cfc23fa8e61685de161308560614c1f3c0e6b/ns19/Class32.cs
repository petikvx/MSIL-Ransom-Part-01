using Newtonsoft.Json.Linq;
using ns0;
using ns10;
using ns12;
using ns14;
using ns18;
using ns9;

namespace ns19;

internal class Class32 : Class29, Interface1
{
	internal readonly JToken jtoken_0;

	private string? string_1;

	internal JToken? jtoken_1;

	internal JToken? jtoken_2;

	public JToken? CurrentToken => jtoken_2;

	int Interface1.LineNumber
	{
		get
		{
			if (state_0 == State.Start)
			{
				return 0;
			}
			return ((Interface1)jtoken_2)?.LineNumber ?? 0;
		}
	}

	int Interface1.LinePosition
	{
		get
		{
			if (state_0 == State.Start)
			{
				return 0;
			}
			return ((Interface1)jtoken_2)?.LinePosition ?? 0;
		}
	}

	public override string Path
	{
		get
		{
			string text = base.Path;
			if (string_1 == null)
			{
				string_1 = jtoken_0.Path;
			}
			if (!Class109.smethod_0(string_1))
			{
				if (Class109.smethod_0(text))
				{
					return string_1;
				}
				text = ((!text.smethod_7('[')) ? (string_1 + "." + text) : (string_1 + text));
			}
			return text;
		}
	}

	public Class32(JToken jtoken_3)
	{
		Class113.smethod_0(jtoken_3, "token");
		jtoken_0 = jtoken_3;
	}

	public Class32(JToken jtoken_3, string string_2)
		: this(jtoken_3)
	{
		string_1 = string_2;
	}

	public override bool vmethod_0()
	{
		if (state_0 != 0)
		{
			if (jtoken_2 == null)
			{
				return false;
			}
			if (jtoken_2 is Class176 @class && jtoken_1 != @class)
			{
				return Class7.smethod_535(this, @class);
			}
			return Class7.smethod_351(this, jtoken_2);
		}
		if (jtoken_2 == jtoken_0)
		{
			return false;
		}
		jtoken_2 = jtoken_0;
		Class7.smethod_614(this, jtoken_2);
		return true;
	}

	internal string? method_3(object? object_1)
	{
		return object_1?.ToString();
	}

	bool Interface1.imethod_0()
	{
		if (state_0 == State.Start)
		{
			return false;
		}
		return ((Interface1)jtoken_2)?.imethod_0() ?? false;
	}
}
