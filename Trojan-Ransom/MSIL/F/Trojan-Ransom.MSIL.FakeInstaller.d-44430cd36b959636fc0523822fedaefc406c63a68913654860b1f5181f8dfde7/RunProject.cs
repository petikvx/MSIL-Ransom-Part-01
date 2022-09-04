using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class RunProject
{
	public delegate void NodeStopEventHandler(TreeNode node, PropertysSobyt param);

	public delegate void StopRunEventHandler();

	public TreeView tree;

	private bool withOtladka;

	private string objects;

	public string pPath;

	public string iPath;

	public string iPathShort;

	public string pFileName;

	public string pIcon;

	public string pPicNameDef;

	public string pProgressForm;

	private TreeNode[] debugNodes;

	private TreeNode sledNode;

	public Forms[] f;

	public bool isRUN;

	public bool isSTEP;

	public bool isCLOSING;

	public bool isINITIALIZATED;

	public bool isONLYFORM;

	public PropertysSobyt Param;

	private NodeStopEventHandler NodeStopEvent;

	private StopRunEventHandler StopRunEvent;

	private Hashtable objs;

	public bool isPotok;

	public bool StopPr;

	public bool ClosAl;

	public bool GotFoc;

	public bool Pause;

	public bool CallRunBlock;

	public TreeNode newParent;

	public int newIndex;

	public PropertysSobyt newParam;

	public bool newStepOver;

	public bool newStepOut;

	public bool outRunString;

	public string outString;

	public string outType;

	public peremens.ErrString outResult;

	public bool UndoRedoNoWrite;

	public TreeNode NowNode;

	public int recurs;

	public bool alreadyRun;

	public event NodeStopEventHandler NodeStop
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			NodeStopEvent = (NodeStopEventHandler)Delegate.Combine(NodeStopEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			NodeStopEvent = (NodeStopEventHandler)Delegate.Remove(NodeStopEvent, value);
		}
	}

	public event StopRunEventHandler StopRun
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			StopRunEvent = (StopRunEventHandler)Delegate.Combine(StopRunEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			StopRunEvent = (StopRunEventHandler)Delegate.Remove(StopRunEvent, value);
		}
	}

	public RunProject(string objects)
	{
		tree = null;
		objs = null;
		isPotok = false;
		StopPr = false;
		ClosAl = false;
		GotFoc = false;
		Pause = false;
		CallRunBlock = false;
		newStepOver = false;
		newStepOut = false;
		outRunString = false;
		UndoRedoNoWrite = false;
		recurs = 0;
		alreadyRun = false;
		withOtladka = false;
		this.objects = objects;
	}

	public RunProject(TreeView tree, string objects)
	{
		this.tree = null;
		objs = null;
		isPotok = false;
		StopPr = false;
		ClosAl = false;
		GotFoc = false;
		Pause = false;
		CallRunBlock = false;
		newStepOver = false;
		newStepOut = false;
		outRunString = false;
		UndoRedoNoWrite = false;
		recurs = 0;
		alreadyRun = false;
		this.tree = tree;
		withOtladka = true;
		this.objects = objects;
	}

	public object NetTakNet(string str)
	{
		if ((Operators.CompareString(str, "", false) == 0) | (Operators.CompareString(Strings.UCase(str), Strings.UCase(peremens.trans("Никакой")), false) == 0))
		{
			return peremens.trans("Никакой");
		}
		return str;
	}

	public void GotFocus()
	{
		checked
		{
			int num = f.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(f[i].obj, (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
				{
					NewLateBinding.LateCall(f[i].obj, (Type)null, "Activate", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
		}
	}

	public object[] GetMyAllFromName(object name, string index = "", string formName = "")
	{
		int num = 0;
		object[] array = null;
		object[] array2 = null;
		if (Conversions.ToBoolean(Operators.OrObject((object)(NewLateBinding.LateGet(peremens2.proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null) == null), Operators.CompareObjectEqual(name, (object)"", false))))
		{
			return null;
		}
		array2 = ((Operators.CompareString(formName, "", false) == 0) ? GetMyFormsFromName(RuntimeHelpers.GetObjectValue(name), index) : GetMyFormsFromName(formName));
		if (array2 == null)
		{
			if (ActiveForm() == null)
			{
				return array;
			}
			array2 = GetMyFormsFromName(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(ActiveForm().obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		if (array2 == null)
		{
			return null;
		}
		checked
		{
			int num2 = array2.Length - 1;
			int num3 = 0;
			int num7 = default(int);
			while (true)
			{
				if (num3 <= num2)
				{
					if (NewLateBinding.LateGet(array2[num3], (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
					{
						break;
					}
					int num4 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(array2[num3], (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int i = 0; i <= num4; i++)
					{
						Type typeFromHandle = typeof(Strings);
						object[] array3 = new object[1];
						object[] array4 = array2;
						int num5 = num3;
						object obj = array4[num5];
						object[] array5 = new object[1] { i };
						string[] array6 = null;
						bool[] array7 = new bool[1] { true };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, "MyObjs", array5, array6, (Type[])null, array7);
						bool[] array8 = array7;
						int num6 = 0;
						if (array8[0])
						{
							num7 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
							i = num7;
						}
						object[] array9 = new object[0];
						string[] array10 = null;
						object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "obj", array9, array10, (Type[])null, (bool[])null);
						object[] array11 = new object[0];
						string[] array12 = null;
						array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Props", array11, array12, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array13 = array3;
						bool[] array14 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array13, (string[])null, (Type[])null, array14);
						if (array14[0])
						{
							object obj5 = NewLateBinding.LateGet(array2[num5], (Type)null, "MyObjs", array5, array6, (Type[])null, new bool[1] { true });
							if (array8[num6])
							{
								i = num7;
							}
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", array9, array10, (Type[])null, (bool[])null), (Type)null, "Props", array11, array12, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array13[0]) }, (string[])null, (Type[])null, true, true);
						}
						Type typeFromHandle2 = typeof(Strings);
						object[] array15 = new object[1] { RuntimeHelpers.GetObjectValue(name) };
						bool[] array16 = new bool[1] { true };
						object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array15, (string[])null, (Type[])null, array16);
						if (array16[0])
						{
							name = RuntimeHelpers.GetObjectValue(array15[0]);
						}
						object obj7 = Operators.CompareObjectEqual(obj4, obj6, false);
						object obj8 = array2[num3];
						object[] array17 = new object[1] { i };
						bool[] array18 = new bool[1] { true };
						object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "MyObjs", array17, (string[])null, (Type[])null, array18);
						if (array18[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(int));
						}
						object obj10 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array19 = new object[1] { index };
						object[] array20 = array19;
						bool[] array21 = new bool[1] { true };
						object obj11 = NewLateBinding.LateGet(obj10, (Type)null, "indexof", array20, (string[])null, (Type[])null, array21);
						if (array21[0])
						{
							index = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array19[0]), typeof(string));
						}
						if (Conversions.ToBoolean(Operators.AndObject(obj7, Operators.OrObject(Operators.CompareObjectEqual(obj11, (object)0, false), (object)(Operators.CompareString(Strings.UCase(index), Strings.UCase(peremens.trans("Все")), false) == 0)))))
						{
							array = (object[])Utils.CopyArray((Array)array, (Array)new object[num + 1]);
							object[] array22 = array;
							int num8 = num;
							object obj12 = array2[num3];
							object[] array23 = new object[1] { i };
							object[] array24 = array23;
							array21 = new bool[1] { true };
							object obj13 = NewLateBinding.LateGet(obj12, (Type)null, "MyObjs", array24, (string[])null, (Type[])null, array21);
							if (array21[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array23[0]), typeof(int));
							}
							array22[num8] = RuntimeHelpers.GetObjectValue(obj13);
							num++;
						}
					}
					num3++;
					continue;
				}
				return array;
			}
			return null;
		}
	}

	public bool ExistName(string name, object obj = null, object myForms = null)
	{
		object[] array = (object[])myForms;
		if (f == null)
		{
			return false;
		}
		checked
		{
			int num = f.Length - 1;
			int num2 = 0;
			int num7 = default(int);
			while (true)
			{
				if (num2 <= num)
				{
					if (f[num2] != null && f[num2].obj != obj)
					{
						Type typeFromHandle = typeof(Strings);
						object[] array2 = new object[1];
						object[] array3 = array2;
						object obj2 = f[num2].obj;
						object[] array4 = new object[0];
						object[] array5 = array4;
						string[] array6 = null;
						array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Props", array5, array6, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array7 = array2;
						object[] array8 = array7;
						bool[] array9 = new bool[1] { true };
						object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array8, (string[])null, (Type[])null, array9);
						if (array9[0])
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Props", array4, array6, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { RuntimeHelpers.GetObjectValue(array7[0]) }, (string[])null, (Type[])null, true, true);
						}
						if (Operators.ConditionalCompareObjectEqual(obj3, (object)Strings.UCase(name), false))
						{
							break;
						}
					}
					num2++;
					continue;
				}
				if (array == null)
				{
					array = (object[])NewLateBinding.LateGet(GetMyObjFromObj(RuntimeHelpers.GetObjectValue(obj)), (Type)null, "getMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				}
				if (array == null)
				{
					return false;
				}
				int num3 = array.Length - 1;
				for (num2 = 0; num2 <= num3; num2++)
				{
					if (NewLateBinding.LateGet(array[num2], (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
					{
						continue;
					}
					int num4 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(array[num2], (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int i = 0; i <= num4; i++)
					{
						object obj4 = array[num2];
						object[] array7 = new object[1] { i };
						object[] array10 = array7;
						bool[] array9 = new bool[1] { true };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "MyObjs", array10, (string[])null, (Type[])null, array9);
						if (array9[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(int));
						}
						if (NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null) == obj)
						{
							continue;
						}
						Type typeFromHandle2 = typeof(Strings);
						object[] array11 = new object[1];
						object[] array12 = array;
						int num5 = num2;
						object obj6 = array12[num5];
						array7 = new object[1] { i };
						object[] array13 = array7;
						string[] array6 = null;
						string[] array14 = array6;
						array9 = new bool[1] { true };
						object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "MyObjs", array13, array14, (Type[])null, array9);
						bool[] array15 = array9;
						int num6 = 0;
						if (array15[0])
						{
							num7 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(int));
							i = num7;
						}
						object[] array2 = new object[0];
						object[] array16 = array2;
						string[] array17 = null;
						object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "obj", array16, array17, (Type[])null, (bool[])null);
						object[] array4 = new object[0];
						object[] array18 = array4;
						string[] array19 = null;
						array11[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "Props", array18, array19, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array20 = array11;
						bool[] array21 = new bool[1] { true };
						object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array20, (string[])null, (Type[])null, array21);
						if (array21[0])
						{
							object obj10 = NewLateBinding.LateGet(array[num5], (Type)null, "MyObjs", array7, array6, (Type[])null, new bool[1] { true });
							if (array15[num6])
							{
								i = num7;
							}
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj10, (Type)null, "obj", array2, array17, (Type[])null, (bool[])null), (Type)null, "Props", array4, array19, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array20[0]) }, (string[])null, (Type[])null, true, true);
						}
						if (Operators.ConditionalCompareObjectEqual(obj9, (object)Strings.UCase(name), false))
						{
							return true;
						}
					}
				}
				return false;
			}
			return true;
		}
	}

	public object GetMyObjFromObj(object obj)
	{
		if (f == null)
		{
			return null;
		}
		checked
		{
			int num = f.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (f[num2] != null)
					{
						if (f[num2].obj == obj)
						{
							break;
						}
						if (f[num2].MyObjs != null)
						{
							int num3 = f[num2].MyObjs.Length - 1;
							for (int i = 0; i <= num3; i++)
							{
								if (obj == NewLateBinding.LateGet(f[num2].MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))
								{
									return f[num2].MyObjs[i];
								}
							}
						}
					}
					num2++;
					continue;
				}
				return null;
			}
			return f[num2];
		}
	}

	public TreeNode FindSobyt(string sobyt, TreeNode root)
	{
		if (root == null)
		{
			return null;
		}
		checked
		{
			int num = root.get_Nodes().get_Count() - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (Operators.CompareString(Strings.UCase(root.get_Nodes().get_Item(num2).get_Text()), Strings.UCase(sobyt), false) == 0)
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return root.get_Nodes().get_Item(num2);
		}
	}

	public TreeNode FindSobyt(TreeNode childSobytTreeNode)
	{
		while (true)
		{
			if (childSobytTreeNode != null)
			{
				if (Operators.ConditionalCompareObjectEqual(childSobytTreeNode.get_Tag(), (object)"Sobyt", false))
				{
					break;
				}
				childSobytTreeNode = childSobytTreeNode.get_Parent();
				continue;
			}
			return null;
		}
		return childSobytTreeNode;
	}

	public object GetAllObjects()
	{
		objs = new Hashtable();
		checked
		{
			int num = f.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = f[i].MyObjs.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(f[i].obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
					string text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(f[i].MyObjs[j], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
					string text3 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(f[i].MyObjs[j], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
					objs.Add(text + "." + text2 + "[" + text3 + "]", RuntimeHelpers.GetObjectValue(f[i].MyObjs[j]));
				}
			}
			object result = default(object);
			return result;
		}
	}

	public object GetObjFromUniqName(string uniqName)
	{
		object obj = GetMyObjFromUniqName(uniqName);
		if (obj != null && NewLateBinding.LateIndexGet(obj, new object[1] { 0 }, (string[])null) != null)
		{
			obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(obj, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		return obj;
	}

	public object[] GetMyObjFromUniqName(string uniqName)
	{
		object[] mass = null;
		if (Operators.CompareString(uniqName, "", false) == 0)
		{
			return null;
		}
		if (uniqName.IndexOf(".") == -1)
		{
			if (ActiveForm() == null)
			{
				return null;
			}
			uniqName = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ActiveForm().obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"."), (object)uniqName));
		}
		string text = uniqName.Split(new char[1] { '.' })[0];
		checked
		{
			string text2;
			string text3;
			if (uniqName.IndexOf("[") != -1)
			{
				text2 = uniqName.Split(new char[1] { '.' })[1].Split(new char[1] { '[' })[0];
				text3 = uniqName.Substring(uniqName.IndexOf("[") + 1);
				int num = text3.LastIndexOf("]");
				if (num > text3.IndexOf("["))
				{
					text3 = Strings.Left(text3, num);
				}
				if (!peremens.isCompilBest)
				{
					peremens.ErrString errString = TranslateALL("(" + text3 + ")");
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						Errors.MessangeCritic(errString.err);
						return null;
					}
					text3 = errString.str;
				}
				text3 = peremens.UbratKovich(text3).str;
			}
			else
			{
				text2 = uniqName.Split(new char[1] { '.' })[1];
				text3 = "0";
			}
			string text4 = default(string);
			if (text2.IndexOf("(") != -1)
			{
				text4 = text2.Split(new char[1] { '(' })[1].Split(new char[1] { ')' })[0];
				text2 = text2.Split(new char[1] { '(' })[0];
			}
			if (Operators.CompareString(Strings.UCase(text2), Strings.UCase(peremens.MyZnak + peremens.trans("Объект события")), false) == 0)
			{
				peremens.ReDims(ref mass);
				mass[mass.Length - 1] = RuntimeHelpers.GetObjectValue(Param.MyObj);
				return mass;
			}
			if (Strings.UCase(text2).IndexOf(Strings.UCase(peremens.MyZnak + peremens.trans("Хозяин") + " ")) == 0)
			{
				string name = text2.Substring((peremens.MyZnak + peremens.trans("Хозяин") + " ").Length);
				object[] myAllFromName = GetMyAllFromName(name, "", text);
				if (myAllFromName == null)
				{
					return null;
				}
				if (myAllFromName[0] != null)
				{
					myAllFromName = GetMyAllFromName(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(myAllFromName[0], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OwnerObject", new object[0], (string[])null, (Type[])null, (bool[])null)), "", text);
				}
				if (myAllFromName == null)
				{
					return null;
				}
				peremens.ReDims(ref mass);
				mass[mass.Length - 1] = RuntimeHelpers.GetObjectValue(myAllFromName[0]);
				return mass;
			}
			if (Operators.CompareString(Strings.UCase(text2), Strings.UCase(peremens.MyZnak + peremens.trans("Окно события")), false) == 0)
			{
				peremens.ReDims(ref mass);
				if (Param.MyObj != null)
				{
					mass[mass.Length - 1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Param.MyObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
				return mass;
			}
			if (objs != null)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(objs[text + "." + text2 + "[" + text3 + "]"]);
				if (objectValue != null)
				{
					return new object[1] { RuntimeHelpers.GetObjectValue(objectValue) };
				}
			}
			object[] myFormsFromName = GetMyFormsFromName(text);
			if (myFormsFromName == null)
			{
				return null;
			}
			int num2 = myFormsFromName.Length - 1;
			int num6 = default(int);
			for (int num = 0; num <= num2; num++)
			{
				int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(myFormsFromName[num], (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int i = 0; i <= num3; i++)
				{
					Type typeFromHandle = typeof(Strings);
					object[] array = new object[1];
					object[] array2 = array;
					int num4 = num;
					object obj = myFormsFromName[num4];
					object[] array3 = new object[1] { i };
					string[] array4 = null;
					string[] array5 = array4;
					bool[] array6 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "MyObjs", array3, array5, (Type[])null, array6);
					bool[] array7 = array6;
					int num5 = 0;
					if (array7[0])
					{
						num6 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
						i = num6;
					}
					object[] array8 = new object[0];
					string[] array9 = null;
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "obj", array8, array9, (Type[])null, (bool[])null);
					object[] array10 = new object[0];
					string[] array11 = null;
					array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Props", array10, array11, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
					object[] array12 = array;
					object[] array13 = array12;
					bool[] array14 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array13, (string[])null, (Type[])null, array14);
					if (array14[0])
					{
						object obj5 = NewLateBinding.LateGet(myFormsFromName[num4], (Type)null, "MyObjs", array3, array4, (Type[])null, new bool[1] { true });
						if (array7[num5])
						{
							i = num6;
						}
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", array8, array9, (Type[])null, (bool[])null), (Type)null, "Props", array10, array11, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array12[0]) }, (string[])null, (Type[])null, true, true);
					}
					object obj6 = Operators.CompareObjectEqual(obj4, (object)Strings.UCase(text2), false);
					object obj7 = myFormsFromName[num];
					object[] array15 = new object[1] { i };
					object[] array16 = array15;
					bool[] array17 = new bool[1] { true };
					object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "MyObjs", array16, (string[])null, (Type[])null, array17);
					if (array17[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(int));
					}
					if (!Conversions.ToBoolean(Operators.AndObject(obj6, Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)text3, false), (object)(Operators.CompareString(text3, peremens.trans("Все"), false) == 0)))))
					{
						continue;
					}
					object obj9 = myFormsFromName[num];
					object[] array18 = new object[1] { i };
					object[] array19 = array18;
					array17 = new bool[1] { true };
					object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "MyObjs", array19, (string[])null, (Type[])null, array17);
					if (array17[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array18[0]), typeof(int));
					}
					if (Iz.IsDP(RuntimeHelpers.GetObjectValue(obj10)))
					{
						object obj11 = myFormsFromName[num];
						array12 = new object[1] { i };
						object[] array20 = array12;
						array14 = new bool[1] { true };
						object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "MyObjs", array20, (string[])null, (Type[])null, array14);
						if (array14[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
						}
						NewLateBinding.LateSetComplex(obj12, (Type)null, "ActivePanel", new object[1] { text4 }, (string[])null, (Type[])null, false, true);
					}
					peremens.ReDims(ref mass);
					object[] array21 = mass;
					int num7 = mass.Length - 1;
					object obj13 = myFormsFromName[num];
					array18 = new object[1] { i };
					object[] array22 = array18;
					array17 = new bool[1] { true };
					object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "MyObjs", array22, (string[])null, (Type[])null, array17);
					if (array17[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array18[0]), typeof(int));
					}
					array21[num7] = RuntimeHelpers.GetObjectValue(obj14);
					if (peremens.isCompilBest)
					{
						return mass;
					}
				}
			}
			if (mass == null)
			{
				Errors.MessangeCritic(Errors.ObjIsNothing(uniqName));
			}
			return mass;
		}
	}

	public object[] GetMyFormsFromName(object name, string index = "")
	{
		object obj = 0;
		object[] array = null;
		if (f == null)
		{
			return null;
		}
		checked
		{
			int num = f.Length - 1;
			bool[] array11;
			for (int i = 0; i <= num; i++)
			{
				if (f[i] != null)
				{
					Type typeFromHandle = typeof(Strings);
					object[] array2 = new object[1];
					object obj2 = f[i].obj;
					object[] array3 = new object[0];
					string[] array4 = null;
					array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Props", array3, array4, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
					object[] array5 = array2;
					bool[] array6 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array5, (string[])null, (Type[])null, array6);
					if (array6[0])
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Props", array3, array4, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, true);
					}
					Type typeFromHandle2 = typeof(Strings);
					object[] array7 = new object[1] { RuntimeHelpers.GetObjectValue(name) };
					bool[] array8 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array7, (string[])null, (Type[])null, array8);
					if (array8[0])
					{
						name = RuntimeHelpers.GetObjectValue(array7[0]);
					}
					object obj5 = Operators.CompareObjectEqual(obj3, obj4, false);
					object obj6 = NewLateBinding.LateGet(NewLateBinding.LateGet(f[i].obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array9 = new object[1] { index };
					object[] array10 = array9;
					array11 = new bool[1] { true };
					object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "indexof", array10, (string[])null, (Type[])null, array11);
					if (array11[0])
					{
						index = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					if (Conversions.ToBoolean(Operators.AndObject(obj5, Operators.CompareObjectEqual(obj7, (object)0, false))))
					{
						array = (object[])Utils.CopyArray((Array)array, (Array)new object[Conversions.ToInteger(obj) + 1]);
						array[Conversions.ToInteger(obj)] = f[i];
						obj = Operators.AddObject(obj, (object)1);
					}
				}
			}
			Type typeFromHandle3 = typeof(Strings);
			object[] array12 = new object[1] { RuntimeHelpers.GetObjectValue(name) };
			object[] array13 = array12;
			array11 = new bool[1] { true };
			object obj8 = NewLateBinding.LateGet((object)null, typeFromHandle3, "UCase", array13, (string[])null, (Type[])null, array11);
			if (array11[0])
			{
				name = RuntimeHelpers.GetObjectValue(array12[0]);
			}
			if (Operators.ConditionalCompareObjectEqual(obj8, (object)Strings.UCase(peremens.MyZnak + peremens.trans("Окно события")), false))
			{
				array = new object[1];
				if (Param.MyObj != null)
				{
					array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Param.MyObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
				else if (Param.sender != null)
				{
					array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Param.sender, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
			}
			return array;
		}
	}

	public object giveName(object o)
	{
		return "";
	}

	public object ChangeName(object o, object b)
	{
		if (objs != null)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(GetMyObjFromObj(RuntimeHelpers.GetObjectValue(o)));
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "getMyForm", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(o, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text3 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(o, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
			objs.Remove(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text + "."), b), (object)"["), (object)text3), (object)"]"));
			objs.Add(text + "." + text2 + "[" + text3 + "]", RuntimeHelpers.GetObjectValue(objectValue));
		}
		return "";
	}

	public object ChangeIndex(object o, object b)
	{
		if (objs != null)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(GetMyObjFromObj(RuntimeHelpers.GetObjectValue(o)));
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "getMyForm", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(o, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text3 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(o, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
			objs.Remove(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(text + ".", text2), "["), b), (object)"]"));
			objs.Add(text + "." + text2 + "[" + text3 + "]", RuntimeHelpers.GetObjectValue(objectValue));
		}
		return "";
	}

	public Forms ActiveForm()
	{
		if (f == null)
		{
			return null;
		}
		Forms result = default(Forms);
		return result;
	}

	public void StopProject()
	{
		isCLOSING = true;
		CloseAll();
		StopRunEvent?.Invoke();
		isRUN = false;
	}

	public void CloseAll()
	{
		checked
		{
			int num = f.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				NewLateBinding.LateCall(f[i].obj, (Type)null, "close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				int num2 = f[i].MyObjs.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Iz.IsCS(RuntimeHelpers.GetObjectValue(f[i].MyObjs[j])))
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(f[i].MyObjs[j], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CloseServer", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
				}
			}
		}
	}

	public bool PrervaliPotok()
	{
		if (StopPr)
		{
			StopProject();
			return true;
		}
		if (ClosAl)
		{
			CloseAll();
			return true;
		}
		if (GotFoc)
		{
			GotFoc = false;
			GotFocus();
		}
		if (outRunString)
		{
			outResult = peremens.RunProj.RunString(outString, outType, Param);
			outRunString = false;
		}
		return false;
	}

	public void Run()
	{
		if (Operators.CompareString(pProgressForm, "yes", false) == 0)
		{
			if (((Control)peremens2.ProgressForm).get_InvokeRequired())
			{
				((Control)peremens2.ProgressForm).Invoke((Delegate)peremens.delegatProgressShow, new object[1] { peremens.transInfc("Загрузка") + "..." });
			}
			else
			{
				peremens.ProgressFormShow(peremens.transInfc("Загрузка") + "...");
			}
		}
		isINITIALIZATED = true;
		isRUN = true;
		string text = objects;
		bool withTree = withOtladka;
		ref Forms[] reference = ref f;
		ref TreeView reference2 = ref tree;
		object proj = this;
		peremens.CreateObjects(text, withTree, isRun: true, ref reference, ref reference2, ref peremens.Breaks, ref proj);
		isINITIALIZATED = false;
		if (Operators.CompareString(pProgressForm, "yes", false) == 0)
		{
			if (((Control)peremens2.ProgressForm).get_InvokeRequired())
			{
				Application.DoEvents();
				((Control)peremens2.ProgressForm).Invoke((Delegate)peremens.delegatProgressHide, new object[1] { "" });
			}
			else
			{
				((Control)peremens2.ProgressForm).Hide();
			}
		}
		if (!isPotok)
		{
			return;
		}
		while (true)
		{
			if (!Pause & isRUN)
			{
				Application.DoEvents();
			}
			Thread.Sleep(checked(peremens.timeSleep * (peremens.pauseCount * peremens.Int(Conversions.ToString(Pause)))));
			if (Pause & isRUN)
			{
				isRUN = false;
			}
			if (PrervaliPotok())
			{
				break;
			}
			if (CallRunBlock)
			{
				if (!isSTEP & !newStepOut & !newStepOver)
				{
					GotFocus();
				}
				CallRunBlock = false;
				if (newParent != null)
				{
					RunBlock(newParent, newIndex, newParam, IdtiNaVerhUrovni: true);
				}
			}
		}
	}

	public peremens.ErrString RunBlock(TreeNode parentNode, int ind, PropertysSobyt param, bool IdtiNaVerhUrovni, int WhileCount = 0)
	{
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected O, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected O, but got Unknown
		//IL_0e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected O, but got Unknown
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Expected O, but got Unknown
		checked
		{
			if (parentNode != null && !((parentNode.get_Nodes().get_Count() == 0) | !isRUN))
			{
				object obj = ind;
				alreadyRun = true;
				bool flag = default(bool);
				bool flag2 = default(bool);
				string text = default(string);
				bool flag3 = default(bool);
				bool flag4 = default(bool);
				TreeNode val2 = default(TreeNode);
				peremens.ErrString errString = default(peremens.ErrString);
				bool flag6 = default(bool);
				while (true)
				{
					TreeNode val;
					if (Operators.ConditionalCompareObjectLess(obj, (object)parentNode.get_Nodes().get_Count(), false))
					{
						Param = param;
						while (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Comm", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "indexof", new object[1] { "'" }, (string[])null, (Type[])null, (bool[])null), (object)0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "indexof", new object[1] { "#" }, (string[])null, (Type[])null, (bool[])null), (object)0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "indexof", new object[1] { "/" }, (string[])null, (Type[])null, (bool[])null), (object)0, false))))
						{
							obj = Operators.AddObject(obj, (object)1);
							if (!Operators.ConditionalCompareObjectGreater(obj, (object)(parentNode.get_Nodes().get_Count() - 1), false))
							{
								continue;
							}
							goto IL_0fea;
						}
						val = (NowNode = (TreeNode)NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null));
						if (peremens.Breaks == null)
						{
							peremens.Breaks = (TreeNode[])(object)new TreeNode[1];
						}
						if (Pause & isPotok)
						{
							flag = true;
						}
						unchecked
						{
							if (!isPotok || !PrervaliPotok())
							{
								if (newStepOver)
								{
									newStepOver = false;
									flag2 = true;
								}
								if (!flag & (((((Array.IndexOf(peremens.Breaks, val) == -1) & !isSTEP) && !flag2) & !newStepOut) | (param.bylBreakpoint == NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null))))
								{
									param.bylBreakpoint = null;
									if (!isPotok)
									{
										Application.DoEvents();
									}
									try
									{
										errString = RunString(val.get_Text(), Conversions.ToString(val.get_Tag()), param);
									}
									catch (Exception ex)
									{
										ProjectData.SetProjectError(ex);
										Exception ex2 = ex;
										if (!peremens.IgnorEr)
										{
											if (peremens.isRUN() && NowNode != null)
											{
												text = "\r\n" + peremens.trans("Действие") + ": \"" + NowNode.get_Text() + "\"";
											}
											Errors.MessangeCritic(ex2.Message + "\r\n" + peremens.trans("Событие") + ": \"" + parentNode.get_FullPath() + "\"" + text);
										}
										else
										{
											errString = default(peremens.ErrString);
										}
										ProjectData.ClearProjectError();
									}
									if (Operators.CompareString(errString.err, "BreakApplication", false) != 0)
									{
										if (Operators.CompareString(errString.err, "BreakEvent", false) != 0)
										{
											if (Operators.CompareString(errString.err, "BreakLoop", false) == 0)
											{
												if (flag3)
												{
													newStepOut = true;
												}
												if (EstIfOrWhile(val, "While", "EndWhile"))
												{
													alreadyRun = false;
													return errString;
												}
												errString.err = "";
											}
											else if (Operators.CompareString(errString.err, "StopIf", false) == 0)
											{
												if (flag3)
												{
													newStepOut = true;
												}
												if (EstIfOrWhile(val, "If", "EndIf"))
												{
													alreadyRun = false;
													return errString;
												}
												errString.err = "";
											}
											else if (Operators.CompareString(errString.err, "IgnoreErrors", false) == 0)
											{
												if (flag3)
												{
													newStepOut = true;
												}
												errString.err = "";
												flag4 = true;
											}
											else
											{
												if (Operators.CompareString(errString.err, "Empty", false) == 0)
												{
													if (flag3)
													{
														newStepOut = true;
													}
													alreadyRun = false;
													return errString;
												}
												if (Operators.CompareString(errString.err, "", false) != 0 && !flag4)
												{
													isRUN = false;
													ShowError(errString, (TreeNode)NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), param);
													goto IL_0b1b;
												}
											}
											if (Iz.IsContenerIfs(val))
											{
												errString = peremens.UbratKovich(errString.str);
												if (Operators.CompareString(errString.err, "", false) != 0 && !flag4)
												{
													isRUN = false;
													ShowError(errString, (TreeNode)NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), param);
													goto IL_0b1b;
												}
												bool flag5 = false;
												if (Operators.CompareString(Strings.UCase(errString.str), Strings.UCase(peremens.trans("Да")), false) == 0)
												{
													newStepOver = flag2;
													errString = RunBlock(val, 0, param, IdtiNaVerhUrovni: false);
													flag5 = true;
												}
												if (((Operators.CompareString(errString.err, "", false) != 0) & (Operators.CompareString(errString.err, "StopIf", false) != 0)) && !flag4)
												{
													alreadyRun = false;
													return errString;
												}
												if (Operators.CompareString(errString.err, "CloseRecurs", false) == 0)
												{
													alreadyRun = false;
													return errString;
												}
												if (!isRUN)
												{
													alreadyRun = false;
													break;
												}
												while (true)
												{
													obj = Operators.AddObject(obj, (object)1);
													if (Operators.ConditionalCompareObjectGreaterEqual(obj, (object)parentNode.get_Nodes().get_Count(), false))
													{
														break;
													}
													if (Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"ElseIf", false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Else", false)), (object)(!flag5))))
													{
														goto IL_07b3;
													}
													if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"EndIf", false))
													{
														continue;
													}
													goto IL_07c5;
												}
												if (!flag4)
												{
													isRUN = false;
													peremens.ErrString es = new peremens.ErrString("", Errors.NotEndIF(val.get_Text()));
													ShowError(es, (TreeNode)NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { Operators.SubtractObject(obj, (object)1) }, (string[])null, (Type[])null, (bool[])null), param);
													alreadyRun = false;
													break;
												}
											}
											else if (Operators.ConditionalCompareObjectEqual(val.get_Tag(), (object)"While", false))
											{
												errString = peremens.UbratKovich(errString.str);
												if (Operators.CompareString(errString.err, "", false) != 0 && !flag4)
												{
													isRUN = false;
													ShowError(errString, (TreeNode)NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), param);
													goto IL_0b1b;
												}
												if (Operators.CompareString(Strings.UCase(errString.str), Strings.UCase(peremens.trans("Да")), false) == 0)
												{
													newStepOver = flag2;
													errString = RunBlock(val, 0, param, IdtiNaVerhUrovni: false);
													if ((((Operators.CompareString(errString.err, "", false) != 0) & (Operators.CompareString(errString.err, "BreakLoop", false) != 0)) && !flag4) | !isRUN)
													{
														alreadyRun = false;
														return errString;
													}
													if (Operators.CompareString(errString.err, "CloseRecurs", false) == 0)
													{
														alreadyRun = false;
														return errString;
													}
													Application.DoEvents();
													if (!isRUN)
													{
														return errString;
													}
													if (Operators.CompareString(errString.err, "BreakLoop", false) == 0)
													{
														obj = Operators.AddObject(obj, (object)2);
														continue;
													}
												}
												else if (val2 == val)
												{
													obj = Operators.AddObject(obj, (object)2);
													continue;
												}
											}
											goto IL_0949;
										}
										if (flag3)
										{
											newStepOut = true;
										}
										alreadyRun = false;
										return errString;
									}
									if (flag3)
									{
										newStepOut = true;
									}
									StopProject();
									alreadyRun = false;
									break;
								}
								isRUN = false;
								goto IL_0b1b;
							}
							alreadyRun = false;
							return errString;
						}
					}
					if (flag2)
					{
						newStepOver = true;
					}
					if (flag3)
					{
						newStepOut = true;
					}
					if (IdtiNaVerhUrovni && Operators.ConditionalCompareObjectNotEqual(parentNode.get_Parent().get_Tag(), (object)"Obj", false))
					{
						ind = parentNode.get_Parent().get_Nodes().IndexOf(parentNode) + 1;
						if (ind >= parentNode.get_Parent().get_Nodes().get_Count())
						{
							alreadyRun = false;
							break;
						}
						TreeNode val3 = parentNode.get_Parent().get_Nodes().get_Item(ind);
						if (Iz.IsVnutreniyIf(val3))
						{
							obj = val3.get_Index() + 1;
							while (!Operators.ConditionalCompareObjectGreaterEqual(obj, (object)parentNode.get_Parent().get_Nodes().get_Count(), false))
							{
								if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)parentNode.get_Parent().get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"EndIf", false))
								{
									val3 = (TreeNode)NewLateBinding.LateGet((object)parentNode.get_Parent().get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null);
								}
								obj = Operators.AddObject(obj, (object)1);
							}
							if (!flag4)
							{
								isRUN = false;
								peremens.ErrString es = new peremens.ErrString("", Errors.NotEndIF(val3.get_Text()));
								ShowError(es, (TreeNode)NewLateBinding.LateGet((object)parentNode.get_Parent().get_Nodes(), (Type)null, "Item", new object[1] { Operators.SubtractObject(obj, (object)1) }, (string[])null, (Type[])null, (bool[])null), param);
								alreadyRun = false;
								break;
							}
						}
						errString = RunBlock(parentNode.get_Parent(), val3.get_Index(), param, IdtiNaVerhUrovni: false);
						if (!isRUN)
						{
							alreadyRun = false;
							break;
						}
					}
					if (flag6)
					{
						GotFocus();
					}
					alreadyRun = false;
					break;
					IL_0b1b:
					if (!(peremens.isRunAlg2Code & (Operators.CompareString(errString.err, "", false) != 0)))
					{
						if (isPotok)
						{
							param.err = errString;
							Thread thread = new Thread(peremens2.MnFrmPotok.RunProj_NodeStop);
							thread.Start(new object[2] { val, param });
							while (!isRUN)
							{
								Thread.Sleep(peremens.timeSleep * peremens.pauseCount);
								if (!PrervaliPotok())
								{
									continue;
								}
								goto IL_0fc2;
							}
							flag6 = true;
							flag = false;
							flag2 = false;
							flag3 = false;
							if (newStepOut)
							{
								newStepOut = false;
								flag3 = true;
							}
							if (FindSobyt(newParent) != FindSobyt(parentNode))
							{
								RunBlock(newParent, newIndex, newParam, IdtiNaVerhUrovni: true);
								alreadyRun = false;
								errString.err = "CloseRecurs";
								if (!flag4)
								{
									return errString;
								}
							}
							parentNode = newParent;
							obj = newIndex;
							param = newParam;
							Application.DoEvents();
							continue;
						}
						NodeStopEvent?.Invoke(val, param);
						alreadyRun = false;
						break;
					}
					return errString;
					IL_07c5:
					obj = Operators.SubtractObject(obj, (object)1);
					goto IL_0949;
					IL_0fc2:
					alreadyRun = false;
					break;
					IL_0949:
					if (Operators.ConditionalCompareObjectEqual(val.get_Tag(), (object)"EndWhile", false) && Operators.ConditionalCompareObjectGreater(obj, (object)0, false))
					{
						int num = Conversions.ToInteger(obj);
						while (true)
						{
							num--;
							if (num >= 0)
							{
								if (Operators.ConditionalCompareObjectEqual(parentNode.get_Nodes().get_Item(num).get_Tag(), (object)"While", false))
								{
									val2 = parentNode.get_Nodes().get_Item(num);
									break;
								}
								continue;
							}
							break;
						}
						if (num >= 0)
						{
							obj = num;
							continue;
						}
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet((object)parentNode.get_Nodes(), (Type)null, "Item", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"EndIf", false))
					{
						if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject(obj, (object)1), (object)0, false))
						{
							errString.err = peremens.trans("Лишнее действие \"Конец условия\"");
							return errString;
						}
						Type typeFromHandle = typeof(Iz);
						object[] array = new object[1];
						object[] array2 = array;
						TreeNodeCollection nodes = parentNode.get_Nodes();
						object[] array3 = new object[1];
						object[] array4 = array3;
						object obj2 = Operators.SubtractObject(obj, (object)1);
						array4[0] = RuntimeHelpers.GetObjectValue(obj2);
						array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)nodes, (Type)null, "Item", array3, (string[])null, (Type[])null, (bool[])null));
						object[] array5 = array;
						object[] array6 = array5;
						bool[] array7 = new bool[1] { true };
						object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle, "IsContenerIfs", array6, (string[])null, (Type[])null, array7);
						if (array7[0])
						{
							NewLateBinding.LateSetComplex((object)nodes, (Type)null, "Item", new object[2]
							{
								RuntimeHelpers.GetObjectValue(obj2),
								(object)(TreeNode)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(TreeNode))
							}, (string[])null, (Type[])null, true, false);
						}
						if (Operators.ConditionalCompareObjectEqual(obj3, (object)false, false))
						{
							errString.err = peremens.trans("Лишнее действие \"Конец условия\"");
							return errString;
						}
					}
					obj = Operators.AddObject(obj, (object)1);
					continue;
					IL_07b3:
					obj = Operators.SubtractObject(obj, (object)1);
					goto IL_0949;
					IL_0fea:
					alreadyRun = false;
					break;
				}
			}
			peremens.ErrString result = default(peremens.ErrString);
			return result;
		}
	}

	public void ShowError(peremens.ErrString es, TreeNode node, PropertysSobyt param)
	{
		if (Operators.CompareString(es.err, "!", false) == 0)
		{
			es.err = peremens.trans("Непредвиденная ошибка");
		}
		param.err = es;
		if (peremens.isRunAlg2Code)
		{
			CodeString codeString = new CodeString(peremens.UbratKluchSlova(Conversions.ToString(node.get_Tag()), node.get_Text()), "All", withFormating: false);
			string str = peremens.OutputRun(Conversions.ToString(node.get_Tag()), codeString.Split("naOdnomUrovne").texty, param);
			isRUN = true;
			Errors.MessangeCritic(str);
		}
		else if (isPotok)
		{
			Thread thread = new Thread(peremens2.MnFrmPotok.RunProj_NodeStop);
			thread.Start(new object[2] { node, param });
		}
		else
		{
			NodeStopEvent?.Invoke(node, param);
		}
	}

	public bool EstIfOrWhile(TreeNode node, string IfOrWhile, string EndIfOrEndWhile)
	{
		TreeNode parent = node.get_Parent();
		if (parent == null)
		{
			return false;
		}
		checked
		{
			while (true)
			{
				if (Operators.ConditionalCompareObjectNotEqual(parent.get_Tag(), (object)"Sobyt", false))
				{
					int i = parent.get_Index() + 1;
					parent = parent.get_Parent();
					if (parent == null)
					{
						break;
					}
					for (; i < parent.get_Nodes().get_Count() && !Operators.ConditionalCompareObjectEqual(parent.get_Nodes().get_Item(i).get_Tag(), (object)IfOrWhile, false); i++)
					{
						if (Operators.ConditionalCompareObjectEqual(parent.get_Nodes().get_Item(i).get_Tag(), (object)EndIfOrEndWhile, false))
						{
							return true;
						}
					}
					continue;
				}
				return false;
			}
			return false;
		}
	}

	public peremens.ErrString RunString(string str, string type, PropertysSobyt param)
	{
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		if (type.IndexOf("Empty") == 0)
		{
			return new peremens.ErrString(str, "Empty");
		}
		Param = param;
		checked
		{
			peremens.ErrString result = default(peremens.ErrString);
			if (Operators.CompareString(type, "Deist", false) == 0)
			{
				CodeString codeString = new CodeString(str, "All", withFormating: false);
				string[] texty = codeString.Split("naOdnomUrovne", "=").texty;
				if (texty.Length == 2)
				{
					result = TranslateALL("(" + texty[1] + ")");
					if (Operators.CompareString(result.err, "", false) != 0)
					{
						return result;
					}
				}
				else if (texty.Length == 1)
				{
					if (!isRUN)
					{
						result = TranslateALL("(" + texty[0] + ")");
					}
				}
				else if (texty.Length > 2)
				{
					return new peremens.ErrString(str, Errors.MnogoRavno());
				}
				peremens.ErrString result2 = isObj(texty[0]);
				if ((texty.Length == 2) | ((Operators.CompareString(result2.str, "", false) != 0) & (Operators.CompareString(result2.err, "", false) == 0)))
				{
					if (Operators.CompareString(result2.err, "", false) != 0)
					{
						return result2;
					}
					string prop = default(string);
					string[] args = default(string[]);
					object[] MyObjs = default(object[]);
					peremens.ErrString result3 = GetMyObjWithProps(texty[0], result2.str, ref prop, ref args, ref MyObjs);
					if (peremens.isCompilBest)
					{
						if (Operators.CompareString(result3.err, "", false) == 0)
						{
							result3 = GetVBCodeNameObjWithProps(texty[0], result2.str, ref prop, ref args, ref MyObjs);
						}
						else
						{
							result3 = TranslateALL("(" + texty[0] + ")");
							if (result3.str.Length > 2)
							{
								result3.str = result3.str.Substring(1, result3.str.Length - 2);
							}
						}
						if (result.str.Length > 2)
						{
							result.str = result.str.Substring(1, result.str.Length - 2);
						}
						else
						{
							result.str = "\"\"";
						}
						if (texty.Length == 2)
						{
							return new peremens.ErrString(result3.str + " = " + result.str);
						}
						if (texty.Length == 1)
						{
							return new peremens.ErrString(result.str);
						}
						if (texty.Length > 2)
						{
							return new peremens.ErrString(str, Errors.MnogoRavno());
						}
					}
					if (Operators.CompareString(result3.err, "", false) != 0)
					{
						return result3;
					}
					result = peremens.UbratKovich(result.str);
					if (Operators.CompareString(result.err, "", false) != 0)
					{
						return result;
					}
					if (args != null)
					{
						int num = args.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (Iz.isCode(args[i]))
							{
								codeString.Text = args[i];
								result3 = TranslateALL(args[i]);
								if (Operators.CompareString(result3.err, "", false) != 0)
								{
									return result3;
								}
								result3 = peremens.UbratKovich(result3.str);
							}
							else
							{
								result3 = peremens.UbratKovich(args[i]);
							}
							if (Operators.CompareString(result3.err, "", false) == 0)
							{
								args[i] = result3.str;
								continue;
							}
							return result3;
						}
					}
					if (!isRUN)
					{
						int num2 = MyObjs.Length - 1;
						int num3 = 0;
						while (true)
						{
							if (num3 <= num2)
							{
								result3 = Props.GetPropertyMethod(RuntimeHelpers.GetObjectValue(MyObjs[num3]), prop, "", args);
								if (Operators.CompareString(result3.err, "", false) == 0)
								{
									if (Operators.CompareString(result3.str, "", false) != 0)
									{
										if ((Operators.CompareString(result3.str, result.str, false) != 0) & (texty.Length > 1))
										{
											break;
										}
										num3++;
										continue;
									}
									return new peremens.ErrString("");
								}
								return result3;
							}
							if (texty.Length > 1)
							{
								return new peremens.ErrString(peremens.trans("Эти значения одинаковы"));
							}
							return result;
						}
						return new peremens.ErrString(peremens.trans("Эти значения не равны"));
					}
					int num4 = MyObjs.Length - 1;
					for (int num3 = 0; num3 <= num4; num3++)
					{
						result3 = Props.SetPropertyMethod(RuntimeHelpers.GetObjectValue(MyObjs[num3]), prop, result.str, args);
						if (Operators.CompareString(result3.err, "", false) != 0)
						{
							return result3;
						}
					}
				}
				else
				{
					if (!isRUN)
					{
						return result;
					}
					Interaction.MsgBox((object)result.str, (MsgBoxStyle)0, (object)null);
				}
			}
			else
			{
				if (Operators.CompareString(type, "Else", false) == 0)
				{
					if (!peremens.isCompilBest)
					{
						result.str = peremens.trans("Да");
						return result;
					}
					result.str = type;
					return result;
				}
				if (Iz.IsContenerIfs(type) | (Operators.CompareString(type, "While", false) == 0))
				{
					string text = str;
					text = (isRUN ? ("(" + peremens.UbratKluchSlova(type, text) + ")") : ((!peremens.isCompilBest) ? ("(" + text + ")") : ("returnBoolean(" + peremens.UbratKluchSlova(type, text) + ")")));
					string txt = text;
					MySplitStruct splStr = new MySplitStruct(false, text);
					peremens.SolvingTree st = new peremens.SolvingTree(txt, 0, CreateSolvingTree(splStr));
					st = CorrectingSolvingTree(st);
					result = TranslateSolvingTree(ref st);
					if (Operators.CompareString(result.err, "", false) != 0)
					{
						result.str = str;
						return result;
					}
					if (peremens.isCompilBest)
					{
						result.str = type + " " + result.str;
						if ((Operators.CompareString(type, "If", false) == 0) | (Operators.CompareString(type, "ElseIf", false) == 0))
						{
							result.str = result.str + " " + peremens.trans("тогда", toEng: true);
						}
						if (Operators.CompareString(type, "While", false) == 0)
						{
							result.str += "\r\nApplication.DoEvents()";
						}
					}
					return result;
				}
				if (((Operators.CompareString(type, "EndIf", false) == 0) | (Operators.CompareString(type, "EndWhile", false) == 0)) & peremens.isCompilBest)
				{
					result.str = peremens.trans(str, toEng: true);
					return result;
				}
			}
			peremens.ErrString result4 = default(peremens.ErrString);
			return result4;
		}
	}

	public peremens.SolvingTree CorrectingSolvingTree(peremens.SolvingTree st)
	{
		st = st.chld[0];
		if (st.chld != null)
		{
			st.chld[0].top = st;
		}
		st.top = null;
		return st;
	}

	public peremens.ErrString TranslateALL(string myCode)
	{
		MySplitStruct splStr = new MySplitStruct(false, myCode);
		peremens.SolvingTree st = new peremens.SolvingTree(myCode, 0, CreateSolvingTree(splStr));
		st = CorrectingSolvingTree(st);
		peremens.ErrString result = TranslateSolvingTree(ref st);
		if (Operators.CompareString(result.err, "", false) != 0)
		{
			result.str = myCode;
		}
		return result;
	}

	public peremens.SolvingTree[] CreateSolvingTree(MySplitStruct SplStr)
	{
		peremens.SolvingTree[] mass = null;
		checked
		{
			int num = SplStr.texty.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				MySplitStruct splStr = new CodeString(SplStr.texty[i], "All", withFormating: false).Split("naVtoromUrovne");
				peremens.SolvingTree solvingTree;
				if (Operators.CompareString(splStr.texty[0], SplStr.texty[i], false) != 0)
				{
					solvingTree = new peremens.SolvingTree(SplStr.texty[i], SplStr.indexy[i], CreateSolvingTree(splStr));
					int num2 = solvingTree.chld.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						solvingTree.chld[j].top = solvingTree;
					}
				}
				else
				{
					solvingTree = new peremens.SolvingTree(SplStr.texty[i], SplStr.indexy[i], null);
				}
				peremens.ReDims(ref mass);
				mass[mass.Length - 1] = solvingTree;
			}
			return mass;
		}
	}

	public peremens.ErrString TranslateSolvingTree(ref peremens.SolvingTree st)
	{
		checked
		{
			if (st.chld == null)
			{
				peremens.ErrString result = TranslateKuso4ek(st.txt);
				if (Operators.CompareString(result.err, "", false) != 0)
				{
					return result;
				}
				st.txt = result.str;
				if (st.top != null)
				{
					StringBuilder stringBuilder = new StringBuilder(st.top.txt);
					int num = Array.IndexOf(st.top.chld, st);
					if (st.oldvalue.Length > 0)
					{
						int num2 = st.oldvalue.Length + 1;
						if (num2 + st.index > stringBuilder.Length)
						{
							num2 = stringBuilder.Length - st.index;
						}
						stringBuilder = stringBuilder.Replace(st.oldvalue, st.txt, st.index, num2);
						st.top.txt = stringBuilder.ToString();
						int num3 = st.txt.Length - st.oldvalue.Length;
						int num4 = num + 1;
						int num5 = st.top.chld.Length - 1;
						for (int i = num4; i <= num5; i++)
						{
							peremens.SolvingTree top = st.top;
							peremens.SolvingTree[] chld = top.chld;
							int num6 = i;
							chld[num6].index = top.chld[num6].index + num3;
						}
					}
					peremens.DelDims(ref st.top.chld, num);
				}
			}
			else
			{
				for (int i = st.chld.Length - 1; i >= 0; i += -1)
				{
					peremens.ErrString result = TranslateSolvingTree(ref st.chld[i]);
					if (Operators.CompareString(result.err, "", false) != 0)
					{
						return result;
					}
				}
			}
			if (st.top == null)
			{
				if (st.chld != null)
				{
					peremens.ErrString result = TranslateSolvingTree(ref st);
					if (Operators.CompareString(result.err, "", false) != 0)
					{
						return result;
					}
				}
				if (st.chld == null)
				{
					if (!peremens.isCompilBest)
					{
						return TranslateWord(st.txt);
					}
					return new peremens.ErrString(st.txt);
				}
			}
			peremens.ErrString result2 = default(peremens.ErrString);
			return result2;
		}
	}

	public peremens.ErrString TranslateKuso4ek(string kusok)
	{
		if (Operators.CompareString(kusok, "", false) == 0)
		{
			return new peremens.ErrString(kusok);
		}
		checked
		{
			if (((Operators.CompareString(Conversions.ToString(kusok[0]), "(", false) == 0) & (Operators.CompareString(Conversions.ToString(kusok[kusok.Length - 1]), ")", false) == 0)) | ((Operators.CompareString(Conversions.ToString(kusok[0]), "[", false) == 0) & (Operators.CompareString(Conversions.ToString(kusok[kusok.Length - 1]), "]", false) == 0)))
			{
				CodeString codeString = new CodeString(kusok, "None", withFormating: false);
				while (Operators.ConditionalCompareObjectEqual(codeString.PropuskSkobok(0, Conversions.ToString(kusok[0]), Conversions.ToString(kusok[kusok.Length - 1])), (object)(kusok.Length - 1), false))
				{
					kusok = kusok.Substring(1, kusok.Length - 2);
					if (Operators.CompareString(kusok, "", false) == 0)
					{
						return new peremens.ErrString(kusok);
					}
				}
			}
			CodeString codeString2 = (peremens.isCompilBest ? new CodeString(kusok, "AllWithAndOr", withFormating: false) : new CodeString(kusok, "UslovsBezZapyatoi", withFormating: false));
			new StringBuilder(kusok);
			MySplitStruct mySplitStruct = codeString2.Split("vezde");
			object obj = 1;
			int num = 0;
			object[] array = peremens.Prioritets;
			if (peremens.isCompilBest)
			{
				array = (object[])Utils.CopyArray((Array)array, (Array)new object[peremens.Prioritets.Length + 1]);
				array[array.Length - 1] = new string[2] { "AND", "OR" };
			}
			if (mySplitStruct.splity != null)
			{
				int num2 = array.Length - 1;
				string text2 = default(string);
				for (num = 0; num <= num2; num++)
				{
					obj = 0;
					while (Operators.ConditionalCompareObjectLess(obj, (object)(mySplitStruct.texty.Length - 1), false))
					{
						obj = Operators.AddObject(obj, (object)1);
						string text = mySplitStruct.splity[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))];
						if (Array.IndexOf((Array)array[num], text) == -1 && ((!peremens.isCompilBest & ((Operators.CompareString(text, "[", false) != 0) | (Operators.CompareString(text, "]", false) != 0))) || (peremens.isCompilBest && ((Operators.CompareString(text, "[", false) != 0) & (Operators.CompareString(text, "]", false) != 0) & (Operators.CompareString(text, "(", false) != 0) & (Operators.CompareString(text, ")", false) != 0) & (Operators.CompareString(text, ",", false) != 0)))))
						{
							continue;
						}
						peremens.ErrString result = TranslateWord(mySplitStruct.texty[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))]);
						if (Operators.CompareString(result.err, "", false) == 0)
						{
							peremens.ErrString result2 = TranslateWord(mySplitStruct.texty[Conversions.ToInteger(obj)]);
							if (Operators.CompareString(result2.err, "", false) == 0)
							{
								if (peremens.isCompilBest)
								{
									if (Operators.CompareString(result2.str, "", false) == 0 && ((Array.IndexOf(peremens.uslovs, text) != -1) | (Array.IndexOf(peremens.opers, text) != -1) | (Operators.CompareString(text, ",", false) == 0) | (Operators.CompareString(text, "[", false) == 0) | (Operators.CompareString(text, "(", false) == 0)))
									{
										if (Operators.ConditionalCompareObjectEqual(obj, (object)(mySplitStruct.texty.Length - 1), false))
										{
											result2.str = "\"\"";
										}
										else if ((Array.IndexOf(peremens.uslovs, mySplitStruct.splity[Conversions.ToInteger(obj)]) != -1) | (Array.IndexOf(peremens.opers, mySplitStruct.splity[Conversions.ToInteger(obj)]) != -1) | (Operators.CompareString(mySplitStruct.splity[Conversions.ToInteger(obj)], ",", false) == 0) | (Operators.CompareString(mySplitStruct.splity[Conversions.ToInteger(obj)], "]", false) == 0) | (Operators.CompareString(mySplitStruct.splity[Conversions.ToInteger(obj)], ")", false) == 0))
										{
											result2.str = "\"\"";
										}
									}
									if ((Operators.CompareString(text, "+", false) == 0) | (Operators.CompareString(text, "-", false) == 0) | (Operators.CompareString(text, "*", false) == 0) | (Operators.CompareString(text, "/", false) == 0) | (Operators.CompareString(text, "\\", false) == 0) | (Operators.CompareString(text, "^", false) == 0) | (Operators.CompareString(text, ">", false) == 0) | (Operators.CompareString(text, "<", false) == 0) | (Operators.CompareString(text, ">=", false) == 0) | (Operators.CompareString(text, "=>", false) == 0) | (Operators.CompareString(text, "<=", false) == 0) | (Operators.CompareString(text, "=<", false) == 0))
									{
										if (!Versioned.IsNumeric((object)result.str))
										{
											result.str = Conversions.ToString(InsertToDouble(result.str));
										}
										if (!Versioned.IsNumeric((object)result2.str))
										{
											result2.str = Conversions.ToString(InsertToDouble(result2.str));
										}
										text2 = result.str + " " + text + " " + result2.str;
									}
									else if (Operators.CompareString(text, "=", false) == 0)
									{
										text2 = result.str + " <=> " + result2.str;
									}
									else if (Operators.CompareString(text, "<=>", false) == 0)
									{
										text2 = result.str + " = " + result2.str;
									}
									else if (Operators.CompareString(text, peremens.trans("_И"), false) == 0)
									{
										text2 = result.str + " And " + result2.str;
									}
									else if (Operators.CompareString(text, peremens.trans("_ИЛИ"), false) == 0)
									{
										text2 = result.str + " Or " + result2.str;
									}
									else
									{
										switch (text)
										{
										case "%":
											if (!Versioned.IsNumeric((object)result.str))
											{
												result.str = Conversions.ToString(InsertToDouble(result.str));
											}
											if (!Versioned.IsNumeric((object)result2.str))
											{
												result2.str = Conversions.ToString(InsertToDouble(result2.str));
											}
											text2 = result.str + " Mod " + result2.str;
											break;
										case "[":
										{
											CodeString codeString3 = new CodeString(result.str, "All", withFormating: false);
											MySplitStruct mySplitStruct2 = codeString3.Split("vezde");
											string text3 = mySplitStruct2.texty[mySplitStruct2.texty.Length - 1];
											text2 = result.str.Substring(0, result.str.Length - text3.Length);
											string text4 = text2;
											string prop = "";
											string[] args = null;
											object[] MyObjs = null;
											text2 = text4 + GetVBCodeNameObjWithProps("", text3, ref prop, ref args, ref MyObjs).str;
											text2 = text2 + " & \"[\" & " + result2.str;
											break;
										}
										case "]":
											text2 = result.str + " & \"]\")" + result2.str;
											break;
										default:
											text2 = ((!((Operators.CompareString(text, "AND", false) == 0) | (Operators.CompareString(text, "OR", false) == 0))) ? (result.str + " " + text + " " + result2.str) : (" returnBoolean( " + result.str + " ) " + text + " returnBoolean( " + result2.str + " ) "));
											break;
										}
									}
								}
								else if ((Operators.CompareString(text, "+", false) == 0) | (Operators.CompareString(text, "-", false) == 0) | (Operators.CompareString(text, "*", false) == 0) | (Operators.CompareString(text, "/", false) == 0) | (Operators.CompareString(text, "\\", false) == 0) | (Operators.CompareString(text, "%", false) == 0) | (Operators.CompareString(text, "^", false) == 0))
								{
									result = TranslateToDouble(result.str);
									if (Operators.CompareString(result.err, "", false) != 0)
									{
										return result;
									}
									result2 = TranslateToDouble(result2.str);
									if (Operators.CompareString(result2.err, "", false) != 0)
									{
										return result2;
									}
									unchecked
									{
										switch (text)
										{
										case "+":
											text2 = Conversions.ToString(peremens.ToDouble(result.str) + peremens.ToDouble(result2.str));
											break;
										case "-":
											text2 = Conversions.ToString(peremens.ToDouble(result.str) - peremens.ToDouble(result2.str));
											break;
										case "*":
											text2 = Conversions.ToString(peremens.ToDouble(result.str) * peremens.ToDouble(result2.str));
											break;
										case "/":
											if (peremens.ToDouble(result2.str) != 0.0)
											{
												text2 = Conversions.ToString(peremens.ToDouble(result.str) / peremens.ToDouble(result2.str));
												break;
											}
											return new peremens.ErrString(kusok, Errors.DivideByZero(kusok));
										case "\\":
											if (peremens.ToDouble(result2.str) != 0.0)
											{
												text2 = Conversions.ToString(checked((long)Math.Round(peremens.ToDouble(result.str))) / checked((long)Math.Round(peremens.ToDouble(result2.str))));
												break;
											}
											return new peremens.ErrString(kusok, Errors.DivideByZero(kusok));
										case "%":
											text2 = Conversions.ToString(peremens.ToDouble(result.str) % peremens.ToDouble(result2.str));
											break;
										case "^":
											text2 = Conversions.ToString(Math.Pow(peremens.ToDouble(result.str), peremens.ToDouble(result2.str)));
											break;
										}
										text2 = "\"" + text2 + "\"";
									}
								}
								else if ((Operators.CompareString(text, ">", false) == 0) | (Operators.CompareString(text, "<", false) == 0) | (Operators.CompareString(text, ">=", false) == 0) | (Operators.CompareString(text, "=>", false) == 0) | (Operators.CompareString(text, "<=", false) == 0) | (Operators.CompareString(text, "=<", false) == 0))
								{
									result = TranslateToDouble(result.str);
									if (Operators.CompareString(result.err, "", false) != 0)
									{
										return result;
									}
									result2 = TranslateToDouble(result2.str);
									if (Operators.CompareString(result2.err, "", false) != 0)
									{
										return result2;
									}
									if (Operators.CompareString(text, ">", false) == 0)
									{
										text2 = ((!(peremens.ToDouble(result.str) > peremens.ToDouble(result2.str))) ? peremens.trans("Нет") : peremens.trans("Да"));
									}
									else if (Operators.CompareString(text, "<", false) == 0)
									{
										text2 = ((!(peremens.ToDouble(result.str) < peremens.ToDouble(result2.str))) ? peremens.trans("Нет") : peremens.trans("Да"));
									}
									else if ((Operators.CompareString(text, ">=", false) == 0) | (Operators.CompareString(text, "=>", false) == 0))
									{
										text2 = ((!(peremens.ToDouble(result.str) >= peremens.ToDouble(result2.str))) ? peremens.trans("Нет") : peremens.trans("Да"));
									}
									else if ((Operators.CompareString(text, "<=", false) == 0) | (Operators.CompareString(text, "=<", false) == 0))
									{
										text2 = ((!(peremens.ToDouble(result.str) <= peremens.ToDouble(result2.str))) ? peremens.trans("Нет") : peremens.trans("Да"));
									}
								}
								else
								{
									result = peremens.UbratKovich(result.str);
									if (Operators.CompareString(result.err, "", false) != 0)
									{
										return result;
									}
									result2 = peremens.UbratKovich(result2.str);
									if (Operators.CompareString(result2.err, "", false) != 0)
									{
										return result2;
									}
									switch (text)
									{
									case "=":
										text2 = ((Operators.CompareString(Strings.UCase(result.str), Strings.UCase(result2.str), false) != 0) ? peremens.trans("Нет") : peremens.trans("Да"));
										break;
									case "<=>":
										text2 = ((Operators.CompareString(result.str, result2.str, false) != 0) ? peremens.trans("Нет") : peremens.trans("Да"));
										break;
									case "<>":
										text2 = ((Operators.CompareString(result.str, result2.str, false) == 0) ? peremens.trans("Нет") : peremens.trans("Да"));
										break;
									default:
										if (Operators.CompareString(text, peremens.trans("_И"), false) == 0)
										{
											text2 = ((!((Operators.CompareString(result.str, peremens.trans("Да"), false) == 0) & (Operators.CompareString(result2.str, peremens.trans("Да"), false) == 0))) ? peremens.trans("Нет") : peremens.trans("Да"));
										}
										else if (Operators.CompareString(text, peremens.trans("_ИЛИ"), false) == 0)
										{
											text2 = ((!((Operators.CompareString(result.str, peremens.trans("Да"), false) == 0) | (Operators.CompareString(result2.str, peremens.trans("Да"), false) == 0))) ? peremens.trans("Нет") : peremens.trans("Да"));
										}
										else if (Operators.CompareString(text, "&", false) == 0)
										{
											text2 = "\"" + peremens.CreateKovich(result.str + result2.str) + "\"";
										}
										break;
									}
								}
								peremens.DelDims(ref mySplitStruct.splity, Conversions.ToInteger(Operators.SubtractObject(obj, (object)1)));
								peremens.DelDims(ref mySplitStruct.texty, Conversions.ToInteger(Operators.SubtractObject(obj, (object)1)));
								mySplitStruct.texty[Conversions.ToInteger(Operators.SubtractObject(obj, (object)1))] = text2;
								obj = Operators.SubtractObject(obj, (object)1);
								continue;
							}
							return result2;
						}
						return result;
					}
				}
			}
			else if (peremens.isCompilBest)
			{
				return TranslateWord(kusok);
			}
			if ((mySplitStruct.texty.Length == 1) & !peremens.isCompilBest)
			{
				peremens.ErrString result3 = TranslateWord(mySplitStruct.texty[0]);
				if (Operators.CompareString(result3.err, "", false) != 0)
				{
					return result3;
				}
				mySplitStruct.texty[mySplitStruct.texty.Length - 1] = result3.str;
			}
			string text5 = mySplitStruct.texty[mySplitStruct.texty.Length - 1];
			codeString2 = new CodeString(text5, "All", withFormating: false);
			if (codeString2.IndexOf("<=>") != -1)
			{
				peremens.ErrString result4 = default(peremens.ErrString);
				result4.str = CreateSolvingTreeRavno(text5);
				return result4;
			}
			return new peremens.ErrString(mySplitStruct.texty[mySplitStruct.texty.Length - 1]);
		}
	}

	public object InsertToDouble(string str)
	{
		object obj = 0;
		object obj2 = 0;
		int num = 0;
		obj = str.IndexOf("(");
		while (Operators.ConditionalCompareObjectNotEqual(obj, (object)(-1), false))
		{
			obj2 = Operators.AddObject(obj2, (object)1);
			if (Operators.ConditionalCompareObjectGreaterEqual(Operators.AddObject(obj, (object)1), (object)str.Length, false))
			{
				break;
			}
			obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)str, (Type)null, "IndexOf", new object[2]
			{
				"(",
				Operators.AddObject(obj, (object)1)
			}, (string[])null, (Type[])null, (bool[])null));
		}
		obj = str.IndexOf(")");
		while (Operators.ConditionalCompareObjectNotEqual(obj, (object)(-1), false))
		{
			num = checked(num + 1);
			if (Operators.ConditionalCompareObjectGreaterEqual(Operators.AddObject(obj, (object)1), (object)str.Length, false))
			{
				break;
			}
			obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)str, (Type)null, "IndexOf", new object[2]
			{
				")",
				Operators.AddObject(obj, (object)1)
			}, (string[])null, (Type[])null, (bool[])null));
		}
		if (!Operators.ConditionalCompareObjectGreater(obj2, (object)num, false) && !Operators.ConditionalCompareObjectGreater((object)num, obj2, false) && ((0u - ((str.IndexOf("ToDouble(") != 0) ? 1u : 0u)) & (uint)str.IndexOf("ToDouble ( ")) != 0)
		{
			if (str.IndexOf("(") > str.IndexOf(")"))
			{
				return str;
			}
			CodeString codeString = new CodeString(str, "All", withFormating: false);
			int num2 = codeString.IndexOf(",", 0, naOdnomUrovne: true);
			if (num2 != -1)
			{
				return str;
			}
			str = "ToDouble(" + str + ")";
		}
		return str;
	}

	public string CreateSolvingTreeRavno(string myCode, bool bezSkovok = false)
	{
		if (!bezSkovok)
		{
			myCode = "(" + myCode + ")";
		}
		string text = "";
		MySplitStruct mySplitStruct = new CodeString(myCode, "<=> and high", withFormating: false).Split("naVtoromUrovne");
		checked
		{
			if (mySplitStruct.splity != null)
			{
				int num = mySplitStruct.splity.Length - 1;
				int i;
				for (i = 0; i <= num; i++)
				{
					text = ((Operators.CompareString(mySplitStruct.splity[i], "<=>", false) != 0) ? ((i <= 0 || Operators.CompareString(mySplitStruct.splity[i - 1], "<=>", false) != 0) ? (text + CreateSolvingTreeRavno(mySplitStruct.texty[i]) + " " + mySplitStruct.splity[i] + " ") : (text + SdelatUCase(CreateSolvingTreeRavno(mySplitStruct.texty[i])) + " " + mySplitStruct.splity[i] + " ")) : (text + SdelatUCase(CreateSolvingTreeRavno(mySplitStruct.texty[i])) + " = "));
				}
				return (Operators.CompareString(mySplitStruct.splity[i - 1], "<=>", false) != 0) ? (text + " " + CreateSolvingTreeRavno(mySplitStruct.texty[i])) : (text + SdelatUCase(CreateSolvingTreeRavno(mySplitStruct.texty[i])) + " ");
			}
			if (Operators.CompareString(myCode, mySplitStruct.texty[mySplitStruct.texty.Length - 1], false) == 0)
			{
				return myCode;
			}
			string text2 = mySplitStruct.texty[mySplitStruct.texty.Length - 1];
			int indL = default(int);
			int indR = default(int);
			string text3 = Conversions.ToString(GetStrIncludesSkobki(text2, ref indL, ref indR));
			string text4 = new CodeString(text2, "None").Split("naVtoromUrovne").texty[0];
			if (Operators.CompareString(Strings.Trim(text3), Strings.Trim(text4), false) == 0)
			{
				return Strings.Left(text2, indL) + CreateSolvingTreeRavno(text2, bezSkovok: true) + Strings.Right(text2, text2.Length - indR) + " ";
			}
			MySplitStruct mySplitStruct2 = new CodeString(text2, "Uslovs", withFormating: false).Split("naOdnomUrovne");
			if (mySplitStruct2.texty.Length == 1)
			{
				string text5 = text2.Substring(0, text2.Length - text4.Length - 2);
				int num2 = text5.LastIndexOf(")");
				text5 = text2.Substring(0, num2 + 1);
				string text6 = text2.Substring(num2 + 1);
				string txt = text5;
				string text7 = default(string);
				int indL2 = Conversions.ToInteger(text7);
				string text8 = default(string);
				int indR2 = Conversions.ToInteger(text8);
				GetStrIncludesSkobki(txt, ref indL2, ref indR2);
				text8 = Conversions.ToString(indR2);
				text7 = Conversions.ToString(indL2);
				string text9 = default(string);
				indR2 = Conversions.ToInteger(text9);
				string text10 = default(string);
				indL2 = Conversions.ToInteger(text10);
				GetStrIncludesSkobki(text6, ref indR2, ref indL2);
				text10 = Conversions.ToString(indL2);
				text9 = Conversions.ToString(indR2);
				return Strings.Left(text5, Conversions.ToInteger(text7)) + CreateSolvingTreeRavno(text5, bezSkovok: true) + Strings.Right(text5, (int)Math.Round((double)text5.Length - Conversions.ToDouble(text8))) + " " + Strings.Left(text6, Conversions.ToInteger(text9)) + CreateSolvingTreeRavno(text6, bezSkovok: true) + Strings.Right(text6, (int)Math.Round((double)text6.Length - Conversions.ToDouble(text10))) + " ";
			}
			text = "";
			int num3 = mySplitStruct2.texty.Length - 1;
			for (int i = 0; i <= num3; i++)
			{
				text += CreateSolvingTreeRavno("(" + mySplitStruct2.texty[i] + ")", bezSkovok: true);
				if (i < mySplitStruct2.splity.Length)
				{
					text = text + " " + mySplitStruct2.splity[i] + " ";
				}
			}
			return text;
		}
	}

	public object GetStrIncludesSkobki(string txt, ref int indL, ref int indR)
	{
		CodeString codeString = new CodeString(txt, "All", withFormating: false);
		indL = codeString.IndexOf("(");
		indR = codeString.LastIndexOf(")");
		int num = codeString.IndexOf("[");
		int num2 = codeString.LastIndexOf("]");
		if (num < indL && num != -1)
		{
			indL = num;
			indR = num2;
		}
		checked
		{
			if (indL == -1)
			{
				indL = 0;
			}
			else
			{
				indL++;
			}
			if (indR == -1)
			{
				indR = txt.Length;
			}
			return txt.Substring(indL, indR - indL);
		}
	}

	private string SdelatUCase(string str)
	{
		if (Operators.CompareString(str, "", false) == 0)
		{
			return "";
		}
		if (str.Replace(" ", "").IndexOf("UCase(") == 0)
		{
			return str;
		}
		return " UCase( " + str + ") ";
	}

	public peremens.ErrString TranslateWord(string word)
	{
		peremens.ErrString result = new peremens.ErrString(Strings.Trim(word));
		peremens.ErrString errString = new peremens.ErrString(Strings.Trim(word));
		if (Operators.CompareString(result.str, "", false) == 0)
		{
			return result;
		}
		checked
		{
			string prop = default(string);
			string[] args = default(string[]);
			object[] MyObjs = default(object[]);
			double num5 = default(double);
			do
			{
				if (((Operators.CompareString(Conversions.ToString(word[0]), "(", false) == 0) & (Operators.CompareString(Conversions.ToString(word[word.Length - 1]), ")", false) == 0)) | ((Operators.CompareString(Conversions.ToString(word[0]), "[", false) == 0) & (Operators.CompareString(Conversions.ToString(word[word.Length - 1]), "]", false) == 0)))
				{
					word = Strings.Trim(word.Substring(1, word.Length - 2));
					result.str = word;
					continue;
				}
				if (((Operators.CompareString(Conversions.ToString(word[0]), "\"", false) == 0) & (Operators.CompareString(Conversions.ToString(word[word.Length - 1]), "\"", false) == 0)) && result.str.Length > 1)
				{
					if (peremens.isCompilBest)
					{
						result.str = peremens.perevesti(Perevodi.getCompilLineLength(result.str), "\" & vbCrLf & \"");
					}
					return result;
				}
				if (Versioned.IsNumeric((object)word))
				{
					return result;
				}
				peremens.ErrString errString2 = isObj(word);
				if (Operators.CompareString(errString2.err, "", false) == 0)
				{
					errString = GetMyObjWithProps(word, errString2.str, ref prop, ref args, ref MyObjs);
					if (peremens.isCompilBest)
					{
						return GetVBCodeNameObjWithProps(word, errString2.str, ref prop, ref args, ref MyObjs);
					}
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					int num = MyObjs.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (args != null)
						{
							int num2 = args.Length - 1;
							for (int j = 0; j <= num2; j++)
							{
								errString = ((!Iz.isCode(args[j])) ? peremens.UbratKovich(args[j]) : TranslateALL(args[j]));
								if (Operators.CompareString(errString.err, "", false) == 0)
								{
									args[j] = errString.str;
									continue;
								}
								return errString;
							}
						}
						errString = Props.GetPropertyMethod(RuntimeHelpers.GetObjectValue(MyObjs[i]), prop, word, args);
						if (Operators.CompareString(errString.err, "", false) == 0)
						{
							if (i == 0)
							{
								result.str = errString.str;
							}
							if (Operators.CompareString(result.str, errString.str, false) != 0)
							{
								result.str = "";
								break;
							}
							continue;
						}
						return errString;
					}
					if (Operators.CompareString(peremens.UbratKovich(result.str).str, result.str, false) == 0)
					{
						if (Operators.CompareString(result.str, (string)null, false) != 0)
						{
							result.str = peremens.CreateKovich(result.str);
						}
						result.str = "\"" + result.str + "\"";
					}
					return result;
				}
				int num3 = -1;
				int num4 = peremens.DopFunsSimple.Length - 1;
				for (int i = 0; i <= num4; i++)
				{
					if (Strings.UCase(word).IndexOf(peremens.DopFunsSimple[i]) == 0 && (num3 == -1 || peremens.DopFunsSimple[num3].Length <= peremens.DopFunsSimple[i].Length))
					{
						num3 = i;
					}
				}
				if (num3 != -1)
				{
					if (peremens.isCompilBest)
					{
						if (Operators.CompareString(peremens.DopFunsSimple[num3].ToUpper(), result.str.ToUpper(), false) == 0)
						{
							result.str = peremens.trans(result.str, toEng: true).Replace(" ", "");
						}
						return result;
					}
					string str;
					if (word.IndexOf("\"") != -1)
					{
						str = word.Split(new char[1] { '"' })[1];
					}
					else
					{
						if (word.IndexOf("(") == -1)
						{
							return result;
						}
						str = Strings.Trim(word.Split(new char[1] { '(' })[1].Split(new char[1] { ')' })[0]);
					}
					if (Operators.CompareString(peremens.DopFunsSimple[num3], Strings.UCase(peremens.trans("Инвертировать")), false) != 0)
					{
						if (!Iz.isDouble(ref str))
						{
							result.err = Errors.notDouble(str, peremens.DopFunsSimple[num3]);
							return result;
						}
						num5 = peremens.ToDouble(str);
					}
					string text = peremens.DopFunsSimple[num3];
					if (Operators.CompareString(text, Strings.UCase(peremens.trans("Корень")), false) == 0)
					{
						result.str = "\"" + Props.Radical(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Корень3")), false) == 0)
					{
						result.str = "\"" + Props.Radical3(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Квадрат")), false) == 0)
					{
						result.str = "\"" + Props.Square(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Модуль")), false) == 0)
					{
						result.str = "\"" + Props.Absolute(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Синус")), false) == 0)
					{
						result.str = "\"" + Conversions.ToString(Props.Sine(Conversions.ToString(num5))) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Косинус")), false) == 0)
					{
						result.str = "\"" + Props.Cosine(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Тангенс")), false) == 0)
					{
						result.str = "\"" + Props.Tangent(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("АркСинус")), false) == 0)
					{
						result.str = "\"" + Props.ArcSine(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("АркКосинус")), false) == 0)
					{
						result.str = "\"" + Props.ArcCosine(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("АркТангенс")), false) == 0)
					{
						result.str = "\"" + Props.ArcTangent(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Экспонента")), false) == 0)
					{
						result.str = "\"" + Props.Exhibitor(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Логарифм")), false) == 0)
					{
						result.str = "\"" + Props.Logarithm(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Логарифм10")), false) == 0)
					{
						result.str = "\"" + Props.Logarithm10(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Округлить")), false) == 0)
					{
						result.str = "\"" + Props.Round(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Округлить денежное")), false) == 0)
					{
						result.str = "\"" + Props.RoundMoney(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сменить знак")), false) == 0)
					{
						result.str = "\"" + Props.ChangeSign(Conversions.ToString(num5)) + "\"";
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Инвертировать")), false) == 0)
					{
						if ((Operators.CompareString(Strings.Trim(str), "1", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(str)), Strings.UCase(Strings.Trim(peremens.trans("Да"))), false) == 0))
						{
							result.str = "\"" + peremens.trans("Нет") + "\"";
						}
						else
						{
							if (!((Operators.CompareString(Strings.Trim(str), "0", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(str)), Strings.UCase(Strings.Trim(peremens.trans("Нет"))), false) == 0)))
							{
								return new peremens.ErrString(Errors.notInvers(str));
							}
							result.str = "\"" + peremens.trans("Да") + "\"";
						}
					}
					else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Случайное число")), false) == 0)
					{
						result.str = "\"" + Props.RandomNumber(Conversions.ToString(num5)) + "\"";
					}
					return result;
				}
				object proj = peremens2.proj;
				object[] array = new object[1] { word };
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(proj, (Type)null, "GetMyObjFromUniqName", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					word = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				if (obj != null)
				{
					return result;
				}
				if (Array.IndexOf(peremens.AllHWUp, Strings.UCase(word)) != -1)
				{
					string text2 = Props.SrazuPerevoditHW(peremens.AllHW[Array.IndexOf(peremens.AllHWUp, Strings.UCase(word))]);
					if (text2 == null)
					{
						if (peremens.isCompilBest)
						{
							return new peremens.ErrString("\"" + peremens.AllHW[Array.IndexOf(peremens.AllHWUp, Strings.UCase(word))] + "\"");
						}
						return new peremens.ErrString("\"" + peremens.AllHW[Array.IndexOf(peremens.AllHWUp, Strings.UCase(word))] + "\"");
					}
					return new peremens.ErrString(text2);
				}
				if (peremens.isCompilBest)
				{
					if ((word.IndexOf(".") == 0) & (word.IndexOf(".Props.") != 0))
					{
						string prop2 = word.Substring(1);
						string[] args2 = null;
						array = null;
						return GetVBCodeNameObjWithProps("", "", ref prop2, ref args2, ref array);
					}
					return new peremens.ErrString(word);
				}
				return new peremens.ErrString("???", Errors.notUnderstand(word));
			}
			while (Operators.CompareString(result.str, "", false) != 0);
			return result;
		}
	}

	public peremens.ErrString GetVBCodeNameObjWithProps(string allStr, string objStr, ref string prop, ref string[] args, ref object[] MyObjs)
	{
		object obj = "";
		string text = "";
		checked
		{
			peremens.ErrString result = default(peremens.ErrString);
			if (Operators.CompareString(prop, "", false) == 0)
			{
				Match match = Regex.Match(objStr, peremens.noSimb + "+\\." + peremens.noSimb + "+");
				if (Operators.CompareString(Strings.Trim(match.Value), Strings.Trim(objStr), false) != 0)
				{
					return new peremens.ErrString(objStr);
				}
				result.str = "RunProj.GetObjFromUniqName(\"" + peremens.CreateKovich(objStr) + "\"";
			}
			else
			{
				if (Operators.CompareString(objStr, "", false) != 0)
				{
					obj = objStr.Substring(0, objStr.Length - prop.Length - 1);
					result.str = "RunProj.GetObjFromUniqName(\"" + peremens.CreateKovich(Conversions.ToString(obj)) + "\")";
				}
				bool flag = default(bool);
				if (prop.IndexOf(peremens.MyZnak) == 0)
				{
					prop = prop.Substring(1);
					flag = true;
				}
				text = ".Props." + peremens.trans(prop, toEng: true).Replace(" ", "");
				result.str += text;
				string text2 = peremens.MyZnak + peremens.trans("Полезные объекты") + ".";
				string text3 = peremens.MyZnak + peremens.trans("Объект события");
				object obj2 = flag;
				object obj3 = obj;
				object[] array = new object[1] { text2 };
				bool[] array2 = new bool[1] { true };
				object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "indexOf", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				object obj5 = Operators.CompareObjectNotEqual(obj4, (object)0, false);
				object obj6 = obj;
				object[] array3 = new object[1] { text3 };
				object[] array4 = array3;
				bool[] array5 = new bool[1] { true };
				object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "indexOf", array4, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					text3 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
				}
				if (Conversions.ToBoolean(Operators.AndObject(obj2, Operators.OrObject(obj5, Operators.CompareObjectEqual(obj7, (object)text2.Length, false)))))
				{
					if (Perevodi.rp.Param.ParamyUp == null)
					{
						ref PropertysSobyt param = ref Perevodi.rp.Param;
						param = new PropertysSobyt(null, null, null, peremens.MyZnak + "All");
					}
					if (Perevodi.rp.Param.ParamyUp.IndexOfKey(peremens.MyZnak + Strings.UCase(prop)) != -1)
					{
						result.str = "CurrentEvent.ParamyUp(MyZnak & \"" + Strings.UCase(prop) + "\")";
					}
				}
				if (Operators.CompareString(Strings.UCase(prop), Strings.UCase(peremens.trans("Завершить программу")), false) == 0)
				{
					result.str = "End\r\n";
				}
				if (Operators.CompareString(Strings.UCase(prop), Strings.UCase(peremens.trans("Завершить событие")), false) == 0)
				{
					result.str = "Exit sub\r\n";
				}
				if (Operators.CompareString(Strings.UCase(prop), Strings.UCase(peremens.trans("Завершить цикл")), false) == 0)
				{
					result.str = "Exit while\r\n";
				}
				if (Operators.CompareString(Strings.UCase(prop), Strings.UCase(peremens.trans("Пропускать ошибки")), false) == 0)
				{
					result.str = "On Error Resume Next\r\n" + result.str;
				}
				string[] array6 = (string[])NewLateBinding.LateGet(obj, (Type)null, "Split", new object[1] { "." }, (string[])null, (Type[])null, (bool[])null);
				if (((Operators.CompareString(Strings.UCase(array6[0]), peremens.MyZnak + Strings.UCase(peremens.trans("Полезные объекты")), false) == 0) & (array6.Length > 1)) && Operators.CompareString(Strings.UCase(array6[1]), peremens.MyZnak + Strings.UCase(peremens.trans("Вызвать событие")), false) == 0)
				{
					object proj = peremens2.proj;
					array3 = new object[3];
					object[] array7 = array3;
					string[] array8 = prop.Split(new char[1] { '_' });
					int num = 1;
					array7[0] = array8[1];
					array3[1] = Missing.Value;
					object[] array9 = array3;
					string[] array10 = prop.Split(new char[1] { '_' });
					string[] array11 = array10;
					int num2 = 0;
					array9[2] = array11[0];
					object[] array12 = array3;
					object[] array13 = array12;
					array5 = new bool[3] { true, false, true };
					object obj8 = NewLateBinding.LateGet(proj, (Type)null, "GetMyAllFromName", array13, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						array8[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(string));
					}
					if (array5[2])
					{
						array10[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[2]), typeof(string));
					}
					object objectValue = RuntimeHelpers.GetObjectValue(obj8);
					if (objectValue != null)
					{
						result.str = Perevodi.GetCompilName(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null))) + "_" + peremens.trans(prop.Split(new char[1] { '_' })[2], toEng: true).Replace(" ", "");
						result.str = result.str + "(" + Perevodi.GetCompilName(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null))) + ", nothing)\r\n";
					}
				}
				if (unchecked(array6.Length > 1 && !flag))
				{
					if (Operators.CompareString(Strings.UCase(array6[1]), peremens.MyZnak + Strings.UCase(peremens.trans("Объект события")), false) == 0)
					{
						result.str = "CurrentEvent.MyObj.obj" + text;
					}
					else if (Operators.CompareString(Strings.UCase(array6[1]), peremens.MyZnak + Strings.UCase(peremens.trans("Окно события")), false) == 0)
					{
						result.str = "CurrentEvent.MyObj.GetMyForm.obj" + text;
					}
					else
					{
						if (Operators.ConditionalCompareObjectEqual(obj, (object)"CurrentEvent.MyObj", false))
						{
							return new peremens.ErrString(allStr);
						}
						if (Strings.UCase(array6[1]).IndexOf(peremens.MyZnak + Strings.UCase(peremens.trans("Хозяин")) + " ") == 0)
						{
							string text4 = array6[1].Substring((peremens.MyZnak + peremens.trans("Хозяин") + " ").Length);
							result.str = "RunProj.GetObjFromUniqName(\"" + array6[0] + "." + text4 + "\").props.OwnerObject";
							result.str = "RunProj.GetObjFromUniqName(\"" + array6[0] + ".\" & " + result.str + ")" + text;
						}
					}
				}
				if (args != null)
				{
					int num3 = args.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						args[i] = TranslateKuso4ek(args[i]).str;
					}
					result.str = result.str + "(" + Strings.Join(args, ", ") + ")";
				}
			}
			return result;
		}
	}

	public peremens.ErrString GetMyObjWithProps(string allStr, string objStr, ref string prop, ref string[] args, ref object[] MyObjs)
	{
		checked
		{
			prop = objStr.Substring(objStr.LastIndexOf(".") + 1);
			if (objStr.Length == allStr.Length)
			{
				args = null;
			}
			else
			{
				if (allStr.IndexOf("(", objStr.Length - 1) != objStr.Length)
				{
					return new peremens.ErrString(allStr, Errors.InvalidPropObj());
				}
				args = new CodeString(allStr.Substring(objStr.Length - 1), "All", withFormating: false).Split("naVtoromUrovne").texty;
			}
			MyObjs = GetMyObjFromUniqName(objStr);
			if (MyObjs == null)
			{
				return new peremens.ErrString(allStr, Errors.ObjIsNothing());
			}
			peremens.ErrString result = default(peremens.ErrString);
			return result;
		}
	}

	public peremens.ErrString isObj(string str)
	{
		Match match = Regex.Match(str, peremens.noSimb + "+\\." + peremens.noSimb + "+(\\[.*\\])?\\." + peremens.noSimb + "+");
		if (match.Success & (match.Index == 0))
		{
			return new peremens.ErrString(match.Value);
		}
		return new peremens.ErrString(str, Errors.ObjIsNothing());
	}

	public peremens.ErrString TranslateToDouble(string word)
	{
		if ((Operators.CompareString(word, "", false) == 0) | (Operators.CompareString(word, "\"\"", false) == 0))
		{
			word = Conversions.ToString(0);
		}
		if (Operators.CompareString(Strings.UCase(word), Strings.UCase(peremens.trans("Да")), false) == 0)
		{
			word = Conversions.ToString(1);
		}
		if (Operators.CompareString(Strings.UCase(word), Strings.UCase(peremens.trans("Нет")), false) == 0)
		{
			word = Conversions.ToString(0);
		}
		checked
		{
			while (((Operators.CompareString(Conversions.ToString(word[0]), "(", false) == 0) & (Operators.CompareString(Conversions.ToString(word[word.Length - 1]), ")", false) == 0)) | ((Operators.CompareString(Conversions.ToString(word[0]), "[", false) == 0) & (Operators.CompareString(Conversions.ToString(word[word.Length - 1]), "]", false) == 0)))
			{
				word = word.Substring(1, word.Length - 2);
			}
			peremens.ErrString result = peremens.UbratKovich(word);
			if (Operators.CompareString(result.err, "", false) != 0)
			{
				return result;
			}
			if (!Iz.isDouble(ref result.str))
			{
				return new peremens.ErrString(result.str, "\"" + word + "\" - " + peremens.trans("это не число"));
			}
			return result;
		}
	}
}
