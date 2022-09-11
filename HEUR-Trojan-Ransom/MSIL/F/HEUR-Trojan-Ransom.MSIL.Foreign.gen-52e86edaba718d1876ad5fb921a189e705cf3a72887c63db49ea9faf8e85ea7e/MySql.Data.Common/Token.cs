using ns15;

namespace MySql.Data.Common;

internal sealed class Token
{
	public Enum32 enum32_0;

	public string string_0;

	public bool bool_0;

	public bool IsRealToken
	{
		get
		{
			if (enum32_0 != Enum32.const_5 && enum32_0 != Enum32.const_6 && enum32_0 != Enum32.const_7)
			{
				return bool_0;
			}
			return false;
		}
	}

	public Token(Enum32 type, string text)
	{
		enum32_0 = type;
		string_0 = text;
		bool_0 = true;
	}
}
