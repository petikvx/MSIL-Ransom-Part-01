using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using Mysqlx.Datatypes;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySqlX.Protocol.X;

internal sealed class ExprUnparser
{
	private static HashSet<string> hashSet_0;

	[NonSerialized]
	internal static GetString getString_0;

	static ExprUnparser()
	{
		Strings.CreateGetStringDelegate(typeof(ExprUnparser));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397936), getString_0(107397931)).Replace(getString_0(107397894), getString_0(107397889)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397884)))
		{
			throw new SecurityException(getString_0(107397859));
		}
		hashSet_0 = new HashSet<string>();
		hashSet_0.Add(getString_0(107406773));
		hashSet_0.Add(getString_0(107406768));
	}

	private static string smethod_0(Scalar scalar_0)
	{
		switch (scalar_0.Type)
		{
		case Scalar.Types.Type.VSint:
			return string.Concat(scalar_0.VSignedInt);
		case Scalar.Types.Type.VNull:
			return getString_0(107404602);
		case Scalar.Types.Type.VOctets:
			return getString_0(107408642) + smethod_7(scalar_0.VOctets.Value.ToStringUtf8()) + getString_0(107408642);
		case Scalar.Types.Type.VDouble:
			return scalar_0.VDouble.ToString();
		default:
			throw new ArgumentException(getString_0(107404593) + scalar_0.Type);
		case Scalar.Types.Type.VBool:
			if (!scalar_0.VBool)
			{
				return getString_0(107404620);
			}
			return getString_0(107404579);
		case Scalar.Types.Type.VString:
			return getString_0(107408642) + smethod_7(scalar_0.VString.Value.ToStringUtf8()) + getString_0(107408642);
		}
	}

	private static string smethod_1(IList<DocumentPathItem> ilist_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (DocumentPathItem item in ilist_0)
		{
			switch (item.Type)
			{
			case DocumentPathItem.Class27.Enum9.const_1:
				stringBuilder.Append(getString_0(107397533)).Append(smethod_10(item.Value));
				break;
			case DocumentPathItem.Class27.Enum9.const_2:
				stringBuilder.Append(getString_0(107405685));
				break;
			case DocumentPathItem.Class27.Enum9.const_3:
				stringBuilder.Append(getString_0(107409509)).Append(string.Concat(item.Index)).Append(getString_0(107409504));
				break;
			case DocumentPathItem.Class27.Enum9.const_4:
				stringBuilder.Append(getString_0(107404568));
				break;
			case DocumentPathItem.Class27.Enum9.const_5:
				stringBuilder.Append(getString_0(107406205));
				break;
			}
		}
		return stringBuilder.ToString();
	}

	private static string smethod_2(ColumnIdentifier columnIdentifier_0)
	{
		string text = smethod_8(columnIdentifier_0.Name);
		if (!string.IsNullOrEmpty(columnIdentifier_0.TableName))
		{
			text = smethod_8(columnIdentifier_0.TableName) + getString_0(107397533) + text;
		}
		if (!string.IsNullOrEmpty(columnIdentifier_0.SchemaName))
		{
			text = smethod_8(columnIdentifier_0.SchemaName) + getString_0(107397533) + text;
		}
		if (columnIdentifier_0.DocumentPath.Count > 0)
		{
			text = text + getString_0(107404563) + smethod_1(columnIdentifier_0.DocumentPath);
		}
		return text;
	}

	private static string smethod_3(FunctionCall functionCall_0)
	{
		Identifier name = functionCall_0.Name;
		string text = smethod_8(name.Name);
		if (!string.IsNullOrEmpty(name.SchemaName))
		{
			text = smethod_8(name.SchemaName) + getString_0(107397533) + text;
		}
		text += getString_0(107409313);
		foreach (Expr item in functionCall_0.Param)
		{
			text = text + smethod_11(item) + getString_0(107408908);
		}
		text = Regex.Replace(text, getString_0(107404558), getString_0(107397758));
		return text + getString_0(107409308);
	}

	private static string smethod_4(List<string> list_0)
	{
		string text = getString_0(107409313);
		bool flag = true;
		foreach (string item in list_0)
		{
			if (!flag)
			{
				text += getString_0(107408908);
			}
			flag = false;
			text += item;
		}
		return text + getString_0(107409308);
	}

	private static string smethod_5(Operator operator_0)
	{
		string name = operator_0.Name;
		List<string> list = new List<string>();
		foreach (Expr item in operator_0.Param)
		{
			list.Add(smethod_11(item));
		}
		if (!getString_0(107406181).Equals(name) && !getString_0(107404521).Equals(name))
		{
			if (!getString_0(107406739).Equals(name) && !getString_0(107404458).Equals(name))
			{
				if (!getString_0(107406716).Equals(name) && !getString_0(107404423).Equals(name))
				{
					if (!getString_0(107406734).Equals(name) && !getString_0(107404911).Equals(getString_0(107408200)))
					{
						if (getString_0(107406311).Equals(name))
						{
							return string.Format(getString_0(107404856), list[0], list[1].Replace(getString_0(107408642), getString_0(107397758)));
						}
						if ((name.Length < 3 || hashSet_0.Contains(name)) && list.Count == 2)
						{
							return string.Format(getString_0(107404877), list[0], name, list[1]);
						}
						if (list.Count == 1)
						{
							return string.Format(getString_0(107404799), name, list[0]);
						}
						if (list.Count == 0)
						{
							return name;
						}
						return name + smethod_4(list);
					}
					name = name.Replace(getString_0(107404911), getString_0(107404862));
					return string.Format(getString_0(107404877), list[0], name, list[1]);
				}
				name = name.Replace(getString_0(107404423), getString_0(107404442));
				string text = string.Format(getString_0(107404429), list[0], name, list[1]);
				if (list.Count == 3)
				{
					text = text + getString_0(107404892) + list[2];
				}
				return text;
			}
			name = name.Replace(getString_0(107404458), getString_0(107404449));
			return string.Format(getString_0(107404472), list[0], name, smethod_4(list.GetRange(1, list.Count - 1)));
		}
		name = name.Replace(getString_0(107404521), getString_0(107404536));
		return string.Format(getString_0(107404487), list[0], name, list[1], list[2]);
	}

	private static string smethod_6(Mysqlx.Expr.Object object_0)
	{
		IEnumerable<string> values = object_0.Fld.Select((Mysqlx.Expr.Object.Types.ObjectField objectField_0) => string.Format(_003C_003Ec.getString_0(107404784), smethod_9(objectField_0.Key), smethod_11(objectField_0.Value)));
		return getString_0(107408939) + string.Join(getString_0(107408908), values) + getString_0(107408871);
	}

	public static string smethod_7(string string_0)
	{
		return string_0.Replace(getString_0(107408642), getString_0(107404822));
	}

	public static string smethod_8(string string_0)
	{
		if (!string_0.Contains(getString_0(107409871)) && !string_0.Contains(getString_0(107408642)) && !string_0.Contains(getString_0(107408026)) && !string_0.Contains(getString_0(107404563)) && !string_0.Contains(getString_0(107397533)))
		{
			return string_0;
		}
		return getString_0(107409871) + string_0.Replace(getString_0(107409871), getString_0(107404817)) + getString_0(107409871);
	}

	public static string smethod_9(string string_0)
	{
		return string_0.Replace(getString_0(107408026), getString_0(107404812));
	}

	public static string smethod_10(string string_0)
	{
		if (!Regex.IsMatch(string_0, getString_0(107404775)))
		{
			return getString_0(107408642) + string_0.Replace(getString_0(107408642), getString_0(107404786)) + getString_0(107408642);
		}
		return string_0;
	}

	public static string smethod_11(Expr expr_0)
	{
		return expr_0.Type switch
		{
			Expr.Types.Type.Ident => smethod_2(expr_0.Identifier), 
			Expr.Types.Type.Literal => smethod_0(expr_0.Literal), 
			Expr.Types.Type.Variable => getString_0(107409494) + smethod_8(expr_0.Variable), 
			Expr.Types.Type.FuncCall => smethod_3(expr_0.FunctionCall), 
			Expr.Types.Type.Operator => smethod_5(expr_0.Operator), 
			Expr.Types.Type.Placeholder => getString_0(107409444) + expr_0.Position, 
			Expr.Types.Type.Object => smethod_6(expr_0.Object), 
			_ => throw new ArgumentException(getString_0(107404593) + expr_0.Type), 
		};
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
