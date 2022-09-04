using System.Globalization;

namespace Lexplorer;

internal class Class18 : Class13
{
	public Class18()
	{
		methodTable.Add("SET", Set);
	}

	private bool Set(Class10 props, bool forced)
	{
		try
		{
			string name = props["V"];
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(name);
			string text = cultureInfo.LCID.ToString();
			string text2 = string.Empty;
			for (int i = 0; i < 8 - text.Length; i++)
			{
				text2 += "0";
			}
			text2 += text;
			Class3.ChangeKeyboardLayout(text2);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public override string ToString()
	{
		return $"Command type: LANGUAGE, Method={base.ExecutionMethodName}";
	}
}
