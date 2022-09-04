using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class Iz
{
	public static bool isPanel(object obj)
	{
		string text = obj.GetType().ToString();
		if (Operators.CompareString(text, peremens.ClassAplication + "F", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "runF", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "P", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "runP", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "DP", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "TPs", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "runTPs", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool isSostObj(object obj)
	{
		string text = obj.GetType().ToString();
		if (Operators.CompareString(text, peremens.ClassAplication + "TP", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "MM", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "MMs", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "CM", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "TPl", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool isSostMyObj(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		return isSostObj(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null)));
	}

	public static bool isObjSobitiya(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		Type typeFromHandle = typeof(Strings);
		object[] array = new object[1];
		array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		object obj3 = Operators.CompareObjectEqual(obj2, (object)(peremens.MyZnak + Strings.UCase(peremens.trans("Объект события"))), false);
		Type typeFromHandle2 = typeof(Strings);
		object[] array4 = new object[1];
		array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array5 = array4;
		bool[] array6 = new bool[1] { true };
		object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array5, (string[])null, (Type[])null, array6);
		if (array6[0])
		{
			NewLateBinding.LateSetComplex(obj, (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
		}
		if (Conversions.ToBoolean(Operators.OrObject(obj3, Operators.CompareObjectEqual(obj4, (object)(peremens.MyZnak + Strings.UCase(peremens.trans("Окно события"))), false))))
		{
			return true;
		}
		return false;
	}

	public static bool isMyObj(string txt)
	{
		if (txt.IndexOf("\r\n") == -1)
		{
			return false;
		}
		string key = txt.Substring(0, txt.IndexOf("\r\n"));
		if (peremens.Pustishki.ContainsKey(key))
		{
			return true;
		}
		return false;
	}

	public static bool isPoluObj(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
		{
			return true;
		}
		return false;
	}

	public static bool isPoleznie(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (Operators.CompareString(obj.GetType().ToString(), peremens.ClassAplication + "PoleznieObj", false) == 0)
		{
			return true;
		}
		if (IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))) && NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "myobjs", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "myobjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			return isPoleznie(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "myobjs", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "myobjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		return false;
	}

	public static bool isCode(string cod)
	{
		cod = Strings.Trim(cod);
		if (Operators.CompareString(cod, "", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(Conversions.ToString(cod[0]), "\"", false) != 0)
		{
			return true;
		}
		CodeString codeString = new CodeString(cod, "All", withFormating: false);
		if (codeString.PropuskKovich(0) != checked(cod.Length - 1))
		{
			return true;
		}
		return false;
	}

	public static bool isDouble(ref string str1)
	{
		if (Operators.CompareString(str1, "", false) == 0)
		{
			str1 = "0";
		}
		string text = str1;
		text = text;
		int num = checked(text.Length - 1);
		int num2 = 0;
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			if (num2 <= num)
			{
				if (!char.IsDigit(text[num2]))
				{
					if (!(((Operators.CompareString(Conversions.ToString(text[num2]), "+", false) == 0) | (Operators.CompareString(Conversions.ToString(text[num2]), "-", false) == 0)) && num2 == 0))
					{
						if (((Operators.CompareString(Conversions.ToString(text[num2]), peremens.PointSimb1, false) == 0) | (Operators.CompareString(Conversions.ToString(text[num2]), peremens.PointSimb2, false) == 0)) && !flag && !flag2)
						{
							flag = true;
						}
						else if (Operators.CompareString(Conversions.ToString(text[num2]), "E", false) == 0 && !flag2)
						{
							flag2 = true;
						}
						else
						{
							if (!(((Operators.CompareString(Conversions.ToString(text[num2]), "+", false) == 0) | (Operators.CompareString(Conversions.ToString(text[num2]), "-", false) == 0)) && flag2 && !flag3))
							{
								break;
							}
							flag3 = true;
						}
					}
				}
				else
				{
					flag4 = true;
					if (!flag2)
					{
						flag5 = true;
					}
					if (flag3)
					{
						flag6 = true;
					}
				}
				num2 = checked(num2 + 1);
				continue;
			}
			if (!flag4)
			{
				return false;
			}
			if (flag2 && !flag5)
			{
				return false;
			}
			if (flag3 && !flag6)
			{
				return false;
			}
			if (text.Length > 300)
			{
				return false;
			}
			if (flag2 && !flag3)
			{
				return false;
			}
			if (flag2 && Conversion.Val(text.Substring(checked(text.IndexOf("E") + 2))) > 300.0)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public static bool isInteger(ref string str1)
	{
		if (!isDouble(ref str1))
		{
			return false;
		}
		string text = str1;
		checked
		{
			if (text.IndexOf("E") == -1)
			{
				int num = text.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (!unchecked(((Operators.CompareString(Conversions.ToString(text[i]), "+", false) == 0) | (Operators.CompareString(Conversions.ToString(text[i]), "-", false) == 0)) && i == 0) && !char.IsDigit(text[i]))
					{
						return false;
					}
				}
			}
			else
			{
				object obj = 0;
				if (text.IndexOf(peremens.PointSimb1) != -1)
				{
					obj = text.IndexOf("E") - text.IndexOf(peremens.PointSimb1);
				}
				else if (text.IndexOf(peremens.PointSimb2) != -1)
				{
					obj = text.IndexOf("E") - text.IndexOf(peremens.PointSimb2);
				}
				int num2 = Conversions.ToInteger(text.Substring(text.IndexOf("E") + 2));
				if (Operators.ConditionalCompareObjectLess((object)num2, obj, false))
				{
					return false;
				}
			}
			double num3 = peremens.ToDouble(text);
			if (num3 > 2147483647.0)
			{
				return false;
			}
			return true;
		}
	}

	public static bool isNoSizeChange(object obj)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
		{
			return true;
		}
		string text = obj.GetType().ToString();
		if (Operators.CompareString(text, peremens.ClassAplication + "MMs", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool isNoMove(object obj)
	{
		string text = obj.GetType().ToString();
		if (Operators.CompareString(text, peremens.ClassAplication + "MMs", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool isMoveOnlyMarker(object obj)
	{
		string text = obj.GetType().ToString();
		if (Operators.CompareString(text, peremens.ClassAplication + "Tl", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "T", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "C", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "L", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "RT", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool isHavePlusik(object obj)
	{
		string text = obj.GetType().ToString();
		if (Operators.CompareString(text, peremens.ClassAplication + "TP", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "MM", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "MMs", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "CM", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "TPl", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool isNoControlObj(object obj)
	{
		string text = obj.GetType().ToString();
		if (Operators.CompareString(text, peremens.ClassAplication + "runCD", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "runFD", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "runPD", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "runSD", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "runOD", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "runPrD", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(text, peremens.ClassAplication + "runTm", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool isIncludeObj(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"IncludeObj", false))
		{
			return true;
		}
		return false;
	}

	public static bool IsContenerTree(object node)
	{
		if (node == null)
		{
			return false;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(node, (Type)null, "Tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"If", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(node, (Type)null, "Tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"ElseIf", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(node, (Type)null, "Tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Else", false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(node, (Type)null, "Tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"While", false))))
		{
			return true;
		}
		return false;
	}

	public static bool IsContenerIfs(TreeNode node)
	{
		if (node == null)
		{
			return false;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(node.get_Tag(), (object)"If", false), Operators.CompareObjectEqual(node.get_Tag(), (object)"ElseIf", false)), Operators.CompareObjectEqual(node.get_Tag(), (object)"Else", false))))
		{
			return true;
		}
		return false;
	}

	public static bool IsContenerIfs(string type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode val = new TreeNode();
		val.set_Tag((object)type);
		return IsContenerIfs(val);
	}

	public static bool IsEndsTree(TreeNode node)
	{
		if (node == null)
		{
			return false;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(node.get_Tag(), (object)"EndIf", false), Operators.CompareObjectEqual(node.get_Tag(), (object)"EndWhile", false))))
		{
			return true;
		}
		return false;
	}

	public static bool IsVnutreniyIf(TreeNode node)
	{
		if (node == null)
		{
			return false;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(node.get_Tag(), (object)"ElseIf", false), Operators.CompareObjectEqual(node.get_Tag(), (object)"Else", false))))
		{
			return true;
		}
		return false;
	}

	public static bool IsIfs(TreeNode node)
	{
		if (node == null)
		{
			return false;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(node.get_Tag(), (object)"If", false), Operators.CompareObjectEqual(node.get_Tag(), (object)"ElseIf", false)), Operators.CompareObjectEqual(node.get_Tag(), (object)"Else", false)), Operators.CompareObjectEqual(node.get_Tag(), (object)"EndIf", false))))
		{
			return true;
		}
		return false;
	}

	public static bool IsWhile(TreeNode node)
	{
		if (node == null)
		{
			return false;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(node.get_Tag(), (object)"While", false), Operators.CompareObjectEqual(node.get_Tag(), (object)"EndWhile", false))))
		{
			return true;
		}
		return false;
	}

	public static bool IsRodnyeTree(TreeNode node1, TreeNode node2)
	{
		if (node1 == null || node2 == null)
		{
			return false;
		}
		if (Conversions.ToBoolean(Operators.AndObject((object)((IsIfs(node1) & IsIfs(node2)) | (IsWhile(node1) & IsWhile(node2))), Operators.CompareObjectNotEqual(node1.get_Tag(), node2.get_Tag(), false))))
		{
			return true;
		}
		return false;
	}

	public static bool IsSobytCopy(string copy)
	{
		if (Operators.CompareString(copy, "", false) == 0)
		{
			return false;
		}
		string[] separator = new string[1] { "\r\n" };
		string[] array = copy.Split(separator, StringSplitOptions.None);
		if (array.Length > 4)
		{
			return Operators.CompareString(array[4], "Sobyt", false) == 0;
		}
		return false;
	}

	public static bool IsCommCopy(string copy)
	{
		if (Operators.CompareString(copy, "", false) == 0)
		{
			return false;
		}
		string[] separator = new string[1] { "\r\n" };
		string[] array = copy.Split(separator, StringSplitOptions.None);
		if (array.Length > 4)
		{
			return Operators.CompareString(array[4], "Comm", false) == 0;
		}
		return false;
	}

	public static bool IsFORM(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Forms", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsFORMobj(object Obj)
	{
		if (Obj == null)
		{
			return false;
		}
		if (Operators.CompareString(Obj.GetType().ToString(), peremens.ClassAplication + "F", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsFORMRunObj(object Obj)
	{
		if (Obj == null)
		{
			return false;
		}
		if (Operators.CompareString(Obj.GetType().ToString(), peremens.ClassAplication + "runF", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsDP(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "DPanel", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsMMs(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "MMenus", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsMM(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "MMenu", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsCM(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "CMenu", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsTPl(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "TPanel", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsTP(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "TPage", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsTPs(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "TPages", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsM(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Memory", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsMd(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Media", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsA(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Audio", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsCB(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "CheckBoks", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsW(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "WBrowser", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsTl(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Table", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsC(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "ComboBoks", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsL(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "ListBoks", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsCL(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "CheckedList", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsLLb(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "LinkLabel", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsRT(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "RichText", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsCDobj(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if ((Operators.CompareString(obj.GetType().ToString(), peremens.ClassAplication + "CD", false) == 0) | (Operators.CompareString(obj.GetType().ToString(), peremens.ClassAplication + "runCD", false) == 0))
		{
			return true;
		}
		return false;
	}

	public static bool IsFDobj(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if ((Operators.CompareString(obj.GetType().ToString(), peremens.ClassAplication + "FD", false) == 0) | (Operators.CompareString(obj.GetType().ToString(), peremens.ClassAplication + "runFD", false) == 0))
		{
			return true;
		}
		return false;
	}

	public static bool IsTm(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Timer", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsCr(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Calendar", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsTb(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "TrackBar", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsTbx(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "TextBoks", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsTr(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Trial", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsCS(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "ClientServer", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsI(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Internet", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsPrD(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if ((Operators.CompareString(obj.GetType().ToString(), peremens.ClassAplication + "PrD", false) == 0) | (Operators.CompareString(obj.GetType().ToString(), peremens.ClassAplication + "runPrD", false) == 0))
		{
			return true;
		}
		return false;
	}

	public static bool IsSobytCalls(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Polezniy", false))
		{
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "type", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(peremens.MyZnak + peremens.trans("Вызвать событие")), false))
		{
			return true;
		}
		return false;
	}

	public static bool IsTextPolezniy(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Polezniy", false))
		{
			return false;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "type", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(peremens.MyZnak + peremens.trans("Текст")), false))
		{
			return true;
		}
		return false;
	}

	public static bool IsSplitterPanel(object MyObj)
	{
		if (MyObj == null)
		{
			return false;
		}
		if (Operators.CompareString(MyObj.GetType().ToString(), "System.Windows.Forms.SplitterPanel", false) == 0)
		{
			return true;
		}
		return false;
	}
}
