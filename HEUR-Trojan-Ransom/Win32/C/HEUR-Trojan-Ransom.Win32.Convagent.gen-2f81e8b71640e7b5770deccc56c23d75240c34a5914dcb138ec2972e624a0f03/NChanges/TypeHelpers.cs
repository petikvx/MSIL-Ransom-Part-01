using System;
using System.Text.RegularExpressions;

namespace NChanges;

public static class TypeHelpers
{
	private static readonly Regex GenericTypesRegex = new Regex(",\\s*[^,]+\\s*,\\s*Version=\\d+\\.\\d+\\.\\d+\\.\\d+\\s*,\\s*Culture=[^,]+\\s*,\\s*PublicKeyToken=[^\\]]+", RegexOptions.IgnoreCase);

	private static readonly Regex NullablePrefixRegex = new Regex("^System.Nullable`1\\[\\[([^,\\]]+)");

	private static readonly Regex GenericTypePrefixRegex = new Regex("^([^`]+)`\\d+\\[(.+)\\]$");

	private static readonly Regex GenericTypeParameterRegex = new Regex("\\[([^]]+)\\]");

	public static string CleanUpGenericTypes(string type)
	{
		return GenericTypesRegex.Replace(type, "");
	}

	public static string NormalizeTypeName(string typeName)
	{
		typeName = CleanUpGenericTypes(typeName);
		Match match = NullablePrefixRegex.Match(typeName);
		if (match.Success)
		{
			return NormalizeTypeName(match.Groups[1].Value) + "?";
		}
		match = GenericTypePrefixRegex.Match(typeName);
		if (match.Success)
		{
			string text = GenericTypeParameterRegex.Replace(match.Groups[2].Value, (Match n) => NormalizeTypeName(n.Groups[1].Value));
			text = text.Replace(",", ", ");
			return NormalizeTypeName(match.Groups[1].Value) + "<" + text + ">";
		}
		if (typeName.EndsWith("[]"))
		{
			return NormalizeTypeName(typeName.Substring(0, typeName.Length - 2)) + "[]";
		}
		if (typeName.StartsWith("[") && typeName.EndsWith("]"))
		{
			typeName = typeName.Substring(1, typeName.Length - 2);
		}
		switch (typeName)
		{
		case "System.Double":
			return "double";
		case "System.Boolean":
			return "bool";
		case "System.Void":
			return "void";
		case "System.Object":
			return "object";
		case "System.UInt16":
			return "ushort";
		case "System.Decimal":
			return "decimal";
		case "System.Int16":
			return "short";
		case "System.Single":
			return "float";
		case "System.Int64":
			return "long";
		case "System.SByte":
			return "sbyte";
		case "System.Char":
			return "char";
		case "System.UInt32":
			return "uint";
		case "System.Byte":
			return "byte";
		case "System.String":
			return "string";
		default:
		{
			int num = typeName.LastIndexOf(".", StringComparison.Ordinal);
			if (num != -1)
			{
				return typeName.Substring(num + 1);
			}
			return typeName;
		}
		case "System.Int32":
			return "int";
		}
	}
}
