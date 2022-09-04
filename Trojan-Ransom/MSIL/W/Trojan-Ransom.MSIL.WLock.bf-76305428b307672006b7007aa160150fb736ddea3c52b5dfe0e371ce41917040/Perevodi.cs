using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class Perevodi
{
	public static RunProject rp;

	public static string ToStrFromObj(object MyObj, bool withParentTree = false, bool toEng = false, bool isRun = false, bool withProgres = true, ref peremens.ObjsTreesText ObjsTres = null)
	{
		object[] mass = default(object[]);
		peremens.ReDims(ref mass);
		mass[0] = RuntimeHelpers.GetObjectValue(MyObj);
		return ToStrFromObj(mass, withParentTree, toEng, isRun, withProgres, ref ObjsTres);
	}

	public static string ToStrFromObj(object[] MyObj, bool withParentTree = false, bool toEng = false, bool isRun = false, bool withProgres = true, ref peremens.ObjsTreesText ObjsTres = null)
	{
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		string text = "";
		string text2 = "";
		object proj = peremens2.proj;
		object[] array = new object[1] { MyObj };
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(proj, (Type)null, "GetDo4ernieMyObjs", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			MyObj = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(object[]));
		}
		object[] array4 = (object[])obj;
		if (MyObj == null)
		{
			return null;
		}
		if ((toEng | (isRun & (MyObj.Length == 1))) && Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj[0])))
		{
			array4 = (object[])NewLateBinding.LateGet(MyObj[0], (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null);
		}
		object proj2 = peremens2.proj;
		object[] array5 = new object[1] { array4 };
		object[] array6 = array5;
		array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(proj2, (Type)null, "GetSortMyObjsByLevelConteiner", array6, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			array4 = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(object[]));
		}
		array4 = (object[])obj2;
		checked
		{
			int num = array4.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (withProgres)
				{
					peremens2.ProgressForm.ProgressBarValue = (int)Math.Round(100.0 / (double)array4.Length * (double)i);
				}
				if (ObjsTres != null)
				{
					int num2 = Array.IndexOf<object>(ObjsTres.Objs, RuntimeHelpers.GetObjectValue(array4[i]));
					if (num2 != -1)
					{
						if (text2.Length > 0)
						{
							ObjsTres.Starts[num2] = ObjsTres.popravka + text2.Length - 1;
						}
						else
						{
							ObjsTres.Starts[num2] = ObjsTres.popravka;
						}
					}
				}
				string text3 = NewLateBinding.LateGet(array4[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString()
					.Substring(peremens.ClassAplication.Length);
				text = text3 + "\r\n";
				object? objectValue = RuntimeHelpers.GetObjectValue(array4[i]);
				bool mozhno = false;
				Props.IzmenenieBylo2(objectValue, ref mozhno);
				int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(array4[i], (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				object[] array14;
				int num5;
				bool[] array16;
				for (int j = 0; j <= num3; j++)
				{
					string[] readOnlyProps = peremens.ReadOnlyProps;
					object obj3 = array4[i];
					array5 = new object[1] { j };
					object[] array7 = array5;
					array3 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "PropertysUp", array7, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
					}
					if (Array.IndexOf((Array)readOnlyProps, RuntimeHelpers.GetObjectValue(obj4)) != -1)
					{
						continue;
					}
					object? objectValue2 = RuntimeHelpers.GetObjectValue(array4[i]);
					object obj5 = array4[i];
					array5 = new object[1] { j };
					object[] array8 = array5;
					array3 = new bool[1] { true };
					object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Propertys", array8, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
					}
					peremens.ErrString property = Props.GetProperty(objectValue2, Conversions.ToString(obj6));
					bool num4 = Operators.CompareString(property.err, "", false) == 0;
					string[] noSaveProps = peremens.NoSaveProps;
					Type typeFromHandle = typeof(Strings);
					object[] array9 = new object[1];
					object[] array10 = array4;
					num5 = i;
					object obj7 = array10[num5];
					array5 = new object[1] { j };
					object[] array11 = array5;
					array3 = new bool[1] { true };
					object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "Propertys", array11, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
					}
					array9[0] = RuntimeHelpers.GetObjectValue(obj8);
					object[] array12 = array9;
					bool[] array13 = new bool[1] { true };
					object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array12, (string[])null, (Type[])null, array13);
					if (array13[0])
					{
						NewLateBinding.LateSetComplex(array4[num5], (Type)null, "Propertys", new object[2]
						{
							j,
							RuntimeHelpers.GetObjectValue(array12[0])
						}, (string[])null, (Type[])null, true, false);
					}
					if (num4 & (Array.IndexOf((Array)noSaveProps, RuntimeHelpers.GetObjectValue(obj9)) == -1))
					{
						string text4 = text;
						object obj10 = array4[i];
						array14 = new object[1] { j };
						object[] array15 = array14;
						array16 = new bool[1] { true };
						object obj11 = NewLateBinding.LateGet(obj10, (Type)null, "Propertys", array15, (string[])null, (Type[])null, array16);
						if (array16[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array14[0]), typeof(int));
						}
						text = Conversions.ToString(Operators.ConcatenateObject((object)text4, Operators.ConcatenateObject(obj11, (object)"\r\n")));
						property.str = peremens.perevesti(property.str, SdelatEnterOrSpecsimvol: false);
						text = text + property.str + "\r\n";
					}
				}
				text += "#Conteiner\r\n";
				if (NewLateBinding.LateGet(array4[i], (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
				{
					text = ((!Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(array4[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "typeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false)) ? (text + peremens.GetUNameObj(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array4[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null)))) : (text + peremens.GetUNameObj(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array4[i], (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(array4[i]))));
				}
				text += "\r\n";
				object obj12 = NewLateBinding.LateGet(NewLateBinding.LateGet(array4[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HistoryLevel", new object[0], (string[])null, (Type[])null, (bool[])null);
				array14 = new object[1];
				object[] array17 = array14;
				object[] array18 = array4;
				num5 = i;
				array17[0] = RuntimeHelpers.GetObjectValue(array18[num5]);
				object[] array19 = array14;
				object[] array20 = array19;
				array16 = new bool[1] { true };
				object obj13 = NewLateBinding.LateGet(obj12, (Type)null, "IndexOf", array20, (string[])null, (Type[])null, array16);
				if (array16[0])
				{
					array4[num5] = RuntimeHelpers.GetObjectValue(array19[0]);
				}
				int num6 = Conversions.ToInteger(obj13);
				if (num6 != -1)
				{
					text = text + "#HistoryLevel\r\n" + Conversions.ToString(num6) + "\r\n";
				}
				TreeNode[] array21 = (TreeNode[])(object)new TreeNode[1] { (TreeNode)NewLateBinding.LateGet(array4[i], (Type)null, "GetNode", new object[2]
				{
					Missing.Value,
					true
				}, (string[])null, (Type[])null, (bool[])null) };
				text += "#TreeNode\r\n";
				string text5 = text;
				object mainForm = peremens2.MainForm;
				array19 = new object[4] { array21, withParentTree, toEng, ObjsTres };
				object[] array22 = array19;
				array16 = new bool[4] { true, true, true, true };
				object obj14 = NewLateBinding.LateGet(mainForm, (Type)null, "GetCopyTree", array22, (string[])null, (Type[])null, array16);
				if (array16[0])
				{
					array21 = (TreeNode[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array19[0]), typeof(TreeNode[]));
				}
				if (array16[1])
				{
					withParentTree = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array19[1]), typeof(bool));
				}
				if (array16[2])
				{
					toEng = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array19[2]), typeof(bool));
				}
				if (array16[3])
				{
					ObjsTres = (peremens.ObjsTreesText)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array19[3]), typeof(peremens.ObjsTreesText));
				}
				text = Conversions.ToString(Operators.ConcatenateObject((object)text5, obj14));
				text += "#End\r\n\r\n";
				text2 += text;
				if (ObjsTres != null)
				{
					int num7 = Array.IndexOf<object>(ObjsTres.Objs, RuntimeHelpers.GetObjectValue(array4[i]));
					if (num7 != -1)
					{
						ObjsTres.Lengs[num7] = ObjsTres.popravka + text2.Length - ObjsTres.Starts[num7];
					}
				}
			}
			return text2;
		}
	}

	public static object ToObjFromStr(string str, bool isRun = false, bool fromEng = false, ref string ByRefProjParams = "")
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Invalid comparison between Unknown and I4
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Invalid comparison between Unknown and I4
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Invalid comparison between Unknown and I4
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Invalid comparison between Unknown and I4
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Invalid comparison between Unknown and I4
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Invalid comparison between Unknown and I4
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Invalid comparison between Unknown and I4
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Invalid comparison between Unknown and I4
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Invalid comparison between Unknown and I4
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Invalid comparison between Unknown and I4
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Invalid comparison between Unknown and I4
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Invalid comparison between Unknown and I4
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Invalid comparison between Unknown and I4
		object[] mass = null;
		object obj = 0;
		RichTextBox val = new RichTextBox();
		if (Operators.CompareString(str, "", false) == 0)
		{
			return null;
		}
		val.set_Text(str);
		string[] lines = ((TextBoxBase)val).get_Lines();
		checked
		{
			string[] mass2 = default(string[]);
			object obj2 = default(object);
			while (true)
			{
				if (Operators.ConditionalCompareObjectLess(obj, (object)(lines.Length - 1), false))
				{
					if (((Control)peremens2.ProgressForm).get_InvokeRequired())
					{
						((Control)peremens2.ProgressForm).Invoke((Delegate)peremens.delegatProgress, new object[1] { peremens.Int(Conversions.ToString(Operators.MultiplyObject((object)(100.0 / (double)lines.Length), obj))) });
					}
					else
					{
						peremens2.ProgressForm.ProgressBarValue = Conversions.ToInteger(Operators.MultiplyObject((object)(100.0 / (double)lines.Length), obj));
					}
					if ((Operators.CompareString(lines[Conversions.ToInteger(obj)], "", false) == 0) | (lines[Conversions.ToInteger(obj)].IndexOf("#") == 0))
					{
						obj = Operators.AddObject(obj, (object)1);
						continue;
					}
					peremens.ReDims(ref mass);
					string type = lines[Conversions.ToInteger(obj)];
					object MyObjs = mass;
					Props.CreateNewMyObjs(type, ref MyObjs, isRun, fromEng);
					mass = (object[])MyObjs;
					if (isRun)
					{
						if (peremens.RunProj == null)
						{
							break;
						}
						NewLateBinding.LateSet(mass[mass.Length - 1], (Type)null, "proj", new object[1] { peremens.RunProj }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(mass[mass.Length - 1], (Type)null, "tree", new object[1] { peremens.RunProj.tree }, (string[])null, (Type[])null);
					}
					obj = Operators.AddObject(obj, (object)1);
					bool flag = false;
					string value = "";
					bool flag2 = false;
					string value2 = "";
					bool flag3 = false;
					string value3 = "";
					bool flag4 = false;
					string value4 = "";
					bool flag5 = false;
					string value5 = "";
					bool flag6 = false;
					string value6 = "";
					bool flag7 = false;
					string value7 = "";
					bool flag8 = false;
					string value8 = "";
					bool flag9 = false;
					string value9 = "";
					bool flag10 = false;
					string value10 = "";
					while (lines[Conversions.ToInteger(obj)].IndexOf("#") != 0 && !Operators.ConditionalCompareObjectGreaterEqual(Operators.AddObject(obj, (object)1), (object)(lines.Length - 1), false))
					{
						if (Operators.CompareString(lines[Conversions.ToInteger(obj)], "", false) == 0)
						{
							obj = Operators.AddObject(obj, (object)1);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Видимый")), false) == 0)
						{
							flag = true;
							value = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Вышина")), false) == 0)
						{
							flag2 = true;
							value2 = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Ширина")), false) == 0)
						{
							flag3 = true;
							value3 = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Выделенная запись")), false) == 0)
						{
							flag4 = true;
							value4 = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("RTF код документа")), false) == 0)
						{
							flag5 = true;
							value5 = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Значение")), false) == 0)
						{
							flag6 = true;
							value6 = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Расстояние разделителя")), false) == 0)
						{
							flag7 = true;
							value7 = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Ширина столбцов")), false) == 0)
						{
							flag9 = true;
							value9 = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Вышина строк")), false) == 0)
						{
							flag10 = true;
							value10 = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Статус окна")), false) == 0 && isRun)
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass[mass.Length - 1], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StatusTemp", new object[1] { lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))] }, (string[])null, (Type[])null, false, true);
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (Operators.CompareString(Strings.UCase(lines[Conversions.ToInteger(obj)]), Strings.UCase(peremens.trans("Ассоциировать с расширениями")), false) == 0)
						{
							flag8 = true;
							value8 = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						if (isRun && Operators.CompareString(Props.SrazuPerevoditHW(lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))]), (string)null, false) != 0)
						{
							lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))] = peremens.UbratKovich(Props.SrazuPerevoditHW(lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))])).str;
						}
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(lines[Conversions.ToInteger(obj)], toEng: false, fromEng: true), lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))], fromEng);
						if (unchecked((int)val2) != 2)
						{
							obj = Operators.AddObject(obj, (object)2);
							continue;
						}
						return null;
					}
					if (flag5)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("RTF код документа"), toEng: false, fromEng: true), value5, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag2)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Вышина"), toEng: false, fromEng: true), value2, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag3)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Ширина"), toEng: false, fromEng: true), value3, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Видимый"), toEng: false, fromEng: true), value, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag2)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Вышина"), toEng: false, fromEng: true), value2, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag3)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Ширина"), toEng: false, fromEng: true), value3, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag7)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Расстояние разделителя"), toEng: false, fromEng: true), value7, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag4)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Выделенная запись"), toEng: false, fromEng: true), value4, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag6)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Значение"), toEng: false, fromEng: true), value6, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag9)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Ширина столбцов"), toEng: false, fromEng: true), value9, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag10)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Вышина строк"), toEng: false, fromEng: true), value10, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (flag8)
					{
						MsgBoxResult val2 = Props.SetProperty(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1]), peremens.trans(peremens.trans("Ассоциировать с расширениями"), toEng: false, fromEng: true), value8, fromEng);
						if (unchecked((int)val2) == 2)
						{
							return null;
						}
					}
					if (Iz.IsTl(RuntimeHelpers.GetObjectValue(mass[mass.Length - 1])))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[mass.Length - 1], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedColumns", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[mass.Length - 1], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "selCol", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					}
					if (Operators.CompareString(lines[Conversions.ToInteger(obj)], "#Conteiner", false) == 0)
					{
						peremens.ReDims(ref mass2);
						mass2[mass2.Length - 1] = lines[Conversions.ToInteger(Operators.AddObject(obj, (object)1))];
						obj = Operators.AddObject(obj, (object)2);
						NewLateBinding.LateSet(mass[mass.Length - 1], (Type)null, "OldFormTemp", new object[1] { mass2[mass2.Length - 1].Split(new char[1] { '.' })[0] }, (string[])null, (Type[])null);
						if (peremens.isOpening)
						{
							NewLateBinding.LateSet(mass[mass.Length - 1], (Type)null, "conteiner", new object[1] { null }, (string[])null, (Type[])null);
						}
					}
					if (Operators.CompareString(lines[Conversions.ToInteger(obj)], "#HistoryLevel", false) == 0)
					{
						obj = Operators.AddObject(obj, (object)1);
						NewLateBinding.LateSet(mass[mass.Length - 1], (Type)null, "HistoryTemp", new object[1] { lines[Conversions.ToInteger(obj)] }, (string[])null, (Type[])null);
						obj = Operators.AddObject(obj, (object)1);
					}
					string text = "";
					if (Operators.CompareString(lines[Conversions.ToInteger(obj)], "#TreeNode", false) == 0)
					{
						obj = Operators.AddObject(obj, (object)1);
						while (Operators.CompareString(lines[Conversions.ToInteger(obj)], "#End", false) != 0)
						{
							text = text + lines[Conversions.ToInteger(obj)] + "\r\n";
							obj = Operators.AddObject(obj, (object)1);
						}
						if (Operators.CompareString(text, "", false) != 0)
						{
							NewLateBinding.LateSet(mass[mass.Length - 1], (Type)null, "NodeTemp", new object[1] { ToTreeFromStr(text, fromEng).get_Nodes().get_Item(0) }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(mass[mass.Length - 1], (Type)null, "ParentTemp", new object[1] { peremens.GetNuzhPunkt("#Parent", text) }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(mass[mass.Length - 1], (Type)null, "IndexTemp", new object[1] { peremens.GetNuzhPunkt("#Index", text) }, (string[])null, (Type[])null);
						}
						obj = Operators.AddObject(obj, (object)1);
					}
					obj = Operators.AddObject(obj, (object)1);
					if (!Operators.ConditionalCompareObjectGreaterEqual(obj, (object)(lines.Length - 1), false))
					{
						if (Operators.CompareString(lines[Conversions.ToInteger(obj)], "#ProjectParams", false) == 0)
						{
							obj = Operators.AddObject(obj, (object)1);
							while (Operators.CompareString(lines[Conversions.ToInteger(obj)], "#EndProjectParams", false) != 0)
							{
								ByRefProjParams = ByRefProjParams + lines[Conversions.ToInteger(obj)] + "\r\n";
								obj = Operators.AddObject(obj, (object)1);
							}
							obj = Operators.AddObject(obj, (object)1);
						}
						continue;
					}
				}
				mass = peremens.GetSortTPsByPosition(mass);
				if (mass2 == null)
				{
					return mass;
				}
				if (ForLoopControl.ForLoopInitObj(obj, (object)0, (object)(mass2.Length - 1), (object)1, ref obj2, ref obj))
				{
					do
					{
						int num = mass.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (Iz.isPanel(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))) & (Operators.CompareString(peremens.GetUNameObj(RuntimeHelpers.GetObjectValue(mass[i])), peremens.GetCorrectUName(mass2[Conversions.ToInteger(obj)]), false) == 0))
							{
								if (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "DP", false) != 0)
								{
									if (!Iz.isPoluObj(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(mass[Conversions.ToInteger(obj)], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
									{
										try
										{
											object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
											object[] array = new object[1];
											object[] array2 = array;
											object[] array3 = mass;
											int num2 = Conversions.ToInteger(obj);
											array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array3[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
											object[] array4 = array;
											object[] array5 = array4;
											bool[] array6 = new bool[1] { true };
											NewLateBinding.LateCall(obj3, (Type)null, "add", array5, (string[])null, (Type[])null, array6, true);
											if (array6[0])
											{
												NewLateBinding.LateSetComplex(mass[num2], (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
											}
										}
										catch (Exception ex)
										{
											ProjectData.SetProjectError(ex);
											Exception ex2 = ex;
											Errors.MessangeCritic(ex2.Message);
											ProjectData.ClearProjectError();
											continue;
										}
										if (fromEng)
										{
											object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
											object[] array = new object[1];
											object[] array7 = array;
											object[] array8 = mass;
											int num2 = Conversions.ToInteger(obj);
											array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array8[num2], (Type)null, "HideMarker", new object[0], (string[])null, (Type[])null, (bool[])null));
											object[] array4 = array;
											object[] array9 = array4;
											bool[] array6 = new bool[1] { true };
											NewLateBinding.LateCall(obj4, (Type)null, "add", array9, (string[])null, (Type[])null, array6, true);
											if (array6[0])
											{
												NewLateBinding.LateSetComplex(mass[num2], (Type)null, "HideMarker", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
											}
										}
									}
								}
								else if (mass2[Conversions.ToInteger(obj)].IndexOf("(") != -1)
								{
									if (Operators.CompareString(mass2[Conversions.ToInteger(obj)].Split(new char[1] { '(' })[1].Split(new char[1] { ')' })[0], "Panel1", false) == 0)
									{
										object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
										object[] array10 = new object[1];
										object[] array11 = array10;
										object[] array12 = mass;
										int num2 = Conversions.ToInteger(obj);
										array11[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array12[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
										object[] array4 = array10;
										object[] array13 = array4;
										bool[] array6 = new bool[1] { true };
										NewLateBinding.LateCall(obj5, (Type)null, "add", array13, (string[])null, (Type[])null, array6, true);
										if (array6[0])
										{
											NewLateBinding.LateSetComplex(mass[num2], (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
										}
										if (fromEng)
										{
											object obj6 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
											object[] array = new object[1];
											object[] array14 = array;
											object[] array15 = mass;
											num2 = Conversions.ToInteger(obj);
											array14[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array15[num2], (Type)null, "HideMarker", new object[0], (string[])null, (Type[])null, (bool[])null));
											array4 = array;
											object[] array16 = array4;
											array6 = new bool[1] { true };
											NewLateBinding.LateCall(obj6, (Type)null, "add", array16, (string[])null, (Type[])null, array6, true);
											if (array6[0])
											{
												NewLateBinding.LateSetComplex(mass[num2], (Type)null, "HideMarker", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
											}
										}
									}
									else
									{
										object obj7 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
										object[] array = new object[1];
										object[] array17 = array;
										object[] array18 = mass;
										int num2 = Conversions.ToInteger(obj);
										array17[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array18[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
										object[] array4 = array;
										object[] array19 = array4;
										bool[] array6 = new bool[1] { true };
										NewLateBinding.LateCall(obj7, (Type)null, "add", array19, (string[])null, (Type[])null, array6, true);
										if (array6[0])
										{
											NewLateBinding.LateSetComplex(mass[num2], (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
										}
										if (fromEng)
										{
											object obj8 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
											array = new object[1];
											object[] array20 = array;
											object[] array21 = mass;
											num2 = Conversions.ToInteger(obj);
											array20[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array21[num2], (Type)null, "HideMarker", new object[0], (string[])null, (Type[])null, (bool[])null));
											array4 = array;
											object[] array22 = array4;
											array6 = new bool[1] { true };
											NewLateBinding.LateCall(obj8, (Type)null, "add", array22, (string[])null, (Type[])null, array6, true);
											if (array6[0])
											{
												NewLateBinding.LateSetComplex(mass[num2], (Type)null, "HideMarker", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
											}
										}
									}
								}
								if (NewLateBinding.LateGet(mass[Conversions.ToInteger(obj)], (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
								{
									NewLateBinding.LateSet(mass[Conversions.ToInteger(obj)], (Type)null, "conteiner", new object[1] { RuntimeHelpers.GetObjectValue(mass[i]) }, (string[])null, (Type[])null);
								}
								if (fromEng)
								{
									NewLateBinding.LateCall(NewLateBinding.LateGet(mass[Conversions.ToInteger(obj)], (Type)null, "HideMarker", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendToBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
								}
								break;
							}
							unchecked
							{
								if (!(Iz.isSostObj(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))) & (Operators.CompareString(peremens.GetUNameObj(RuntimeHelpers.GetObjectValue(mass[i])), peremens.GetCorrectUName(mass2[Conversions.ToInteger(obj)]), false) == 0)))
								{
									if (!Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)peremens.GetObjNameFromUName(mass2[Conversions.ToInteger(obj)]), false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)peremens.GetIndexFromUName(mass2[Conversions.ToInteger(obj)]), false)), (object)(Operators.CompareString(peremens.GetUNameObj(RuntimeHelpers.GetObjectValue(mass[i])), peremens.GetCorrectUName(mass2[Conversions.ToInteger(obj)]), false) == 0 || !isRun))))
									{
										continue;
									}
									bool flag11 = true;
									if (NewLateBinding.LateGet(mass[i], (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)mass2[Conversions.ToInteger(obj)].Split(new char[1] { '.' })[0], false))
									{
										flag11 = false;
									}
									if (!(!peremens.isOpening | (peremens.isOpening && flag11)))
									{
										continue;
									}
									if ((Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "TP", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "runTP", false) == 0))
									{
										object obj9 = mass[i];
										object[] array = new object[3];
										object[] array23 = array;
										object[] array24 = mass;
										int num2 = Conversions.ToInteger(obj);
										array23[0] = RuntimeHelpers.GetObjectValue(array24[num2]);
										array[1] = Missing.Value;
										array[2] = true;
										object[] array4 = array;
										object[] array25 = array4;
										bool[] array6 = new bool[3] { true, false, false };
										NewLateBinding.LateCall(obj9, (Type)null, "addTabPage", array25, (string[])null, (Type[])null, array6, true);
										if (array6[0])
										{
											mass[num2] = RuntimeHelpers.GetObjectValue(array4[0]);
										}
									}
									else if ((Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "MM", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "runMM", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "CM", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "runCM", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "MMs", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "runMMs", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "TPl", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "runTPl", false) == 0))
									{
										object obj10 = mass[i];
										object[] array = new object[1];
										object[] array26 = array;
										object[] array27 = mass;
										int num2 = Conversions.ToInteger(obj);
										array26[0] = RuntimeHelpers.GetObjectValue(array27[num2]);
										object[] array4 = array;
										object[] array28 = array4;
										bool[] array6 = new bool[1] { true };
										NewLateBinding.LateCall(obj10, (Type)null, "addMMenuItem", array28, (string[])null, (Type[])null, array6, true);
										if (array6[0])
										{
											mass[num2] = RuntimeHelpers.GetObjectValue(array4[0]);
										}
									}
									else if ((Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "DP", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "runDP", false) == 0))
									{
										if (Operators.CompareString(mass2[Conversions.ToInteger(obj)].Split(new char[1] { '(' })[1].Split(new char[1] { ')' })[0], "Panel1", false) == 0)
										{
											object obj11 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
											object[] array = new object[1];
											object[] array29 = array;
											object[] array30 = mass;
											int num2 = Conversions.ToInteger(obj);
											array29[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array30[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
											object[] array4 = array;
											object[] array31 = array4;
											bool[] array6 = new bool[1] { true };
											NewLateBinding.LateCall(obj11, (Type)null, "add", array31, (string[])null, (Type[])null, array6, true);
											if (array6[0])
											{
												NewLateBinding.LateSetComplex(mass[num2], (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
											}
											if (fromEng)
											{
												object obj12 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
												array = new object[1];
												object[] array32 = array;
												object[] array33 = mass;
												num2 = Conversions.ToInteger(obj);
												array32[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array33[num2], (Type)null, "HideMarker", new object[0], (string[])null, (Type[])null, (bool[])null));
												array4 = array;
												object[] array34 = array4;
												array6 = new bool[1] { true };
												NewLateBinding.LateCall(obj12, (Type)null, "add", array34, (string[])null, (Type[])null, array6, true);
												if (array6[0])
												{
													NewLateBinding.LateSetComplex(mass[num2], (Type)null, "HideMarker", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
												}
											}
										}
										else
										{
											object obj13 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
											object[] array = new object[1];
											object[] array35 = array;
											object[] array36 = mass;
											int num2 = Conversions.ToInteger(obj);
											array35[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array36[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
											object[] array4 = array;
											object[] array37 = array4;
											bool[] array6 = new bool[1] { true };
											NewLateBinding.LateCall(obj13, (Type)null, "add", array37, (string[])null, (Type[])null, array6, true);
											if (array6[0])
											{
												NewLateBinding.LateSetComplex(mass[num2], (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
											}
											if (fromEng)
											{
												object obj14 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
												array = new object[1];
												object[] array38 = array;
												object[] array39 = mass;
												num2 = Conversions.ToInteger(obj);
												array38[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array39[num2], (Type)null, "HideMarker", new object[0], (string[])null, (Type[])null, (bool[])null));
												array4 = array;
												object[] array40 = array4;
												array6 = new bool[1] { true };
												NewLateBinding.LateCall(obj14, (Type)null, "add", array40, (string[])null, (Type[])null, array6, true);
												if (array6[0])
												{
													NewLateBinding.LateSetComplex(mass[num2], (Type)null, "HideMarker", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
												}
											}
										}
									}
									else if (!Iz.isPoluObj(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(mass[Conversions.ToInteger(obj)], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
									{
										if (!Iz.isPanel(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))) | peremens.isOpening)
										{
											continue;
										}
										object obj15 = NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
										object[] array = new object[1];
										object[] array41 = array;
										object[] array42 = mass;
										int num2 = Conversions.ToInteger(obj);
										array41[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array42[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
										object[] array4 = array;
										object[] array43 = array4;
										bool[] array6 = new bool[1] { true };
										NewLateBinding.LateCall(obj15, (Type)null, "add", array43, (string[])null, (Type[])null, array6, true);
										if (array6[0])
										{
											NewLateBinding.LateSetComplex(mass[num2], (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
										}
										if (fromEng)
										{
											object obj16 = NewLateBinding.LateGet(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "controls", new object[0], (string[])null, (Type[])null, (bool[])null);
											array = new object[1];
											object[] array44 = array;
											object[] array45 = mass;
											num2 = Conversions.ToInteger(obj);
											array44[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array45[num2], (Type)null, "HideMarker", new object[0], (string[])null, (Type[])null, (bool[])null));
											array4 = array;
											object[] array46 = array4;
											array6 = new bool[1] { true };
											NewLateBinding.LateCall(obj16, (Type)null, "add", array46, (string[])null, (Type[])null, array6, true);
											if (array6[0])
											{
												NewLateBinding.LateSetComplex(mass[num2], (Type)null, "HideMarker", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
											}
										}
									}
									NewLateBinding.LateSet(mass[Conversions.ToInteger(obj)], (Type)null, "conteiner", new object[1] { RuntimeHelpers.GetObjectValue(mass[i]) }, (string[])null, (Type[])null);
									if (fromEng)
									{
										NewLateBinding.LateCall(NewLateBinding.LateGet(mass[Conversions.ToInteger(obj)], (Type)null, "HideMarker", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendToBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
									}
									continue;
								}
								if (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "TP", false) == 0)
								{
									object obj17 = mass[i];
									object[] array = new object[3];
									object[] array47 = array;
									object[] array48 = mass;
									int num2 = Conversions.ToInteger(obj);
									array47[0] = RuntimeHelpers.GetObjectValue(array48[num2]);
									array[1] = Missing.Value;
									array[2] = true;
									object[] array4 = array;
									object[] array49 = array4;
									bool[] array6 = new bool[3] { true, false, false };
									NewLateBinding.LateCall(obj17, (Type)null, "addTabPage", array49, (string[])null, (Type[])null, array6, true);
									if (array6[0])
									{
										mass[num2] = RuntimeHelpers.GetObjectValue(array4[0]);
									}
								}
								else if ((Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "MM", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "MMs", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "CM", false) == 0) | (Operators.CompareString(NewLateBinding.LateGet(mass[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "TPl", false) == 0))
								{
									object obj18 = mass[i];
									object[] array = new object[1];
									object[] array50 = array;
									object[] array51 = mass;
									int num2 = Conversions.ToInteger(obj);
									array50[0] = RuntimeHelpers.GetObjectValue(array51[num2]);
									object[] array4 = array;
									object[] array52 = array4;
									bool[] array6 = new bool[1] { true };
									NewLateBinding.LateCall(obj18, (Type)null, "addMMenuItem", array52, (string[])null, (Type[])null, array6, true);
									if (array6[0])
									{
										mass[num2] = RuntimeHelpers.GetObjectValue(array4[0]);
									}
								}
								NewLateBinding.LateSet(mass[Conversions.ToInteger(obj)], (Type)null, "conteiner", new object[1] { RuntimeHelpers.GetObjectValue(mass[i]) }, (string[])null, (Type[])null);
								break;
							}
						}
					}
					while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
				}
				return mass;
			}
			object result = default(object);
			return result;
		}
	}

	public static string ToStrFromTree(TreeNode node, bool toEng = false, ref peremens.ObjsTreesText ObjsTres = null)
	{
		object obj = "";
		object obj2 = "";
		string text = "";
		if (node == null)
		{
			return null;
		}
		checked
		{
			int num = node.get_Nodes().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = node.get_Level() - 1;
				for (int j = 0; j <= num2; j++)
				{
					obj2 = Operators.ConcatenateObject((object)" ", obj2);
				}
				obj = Operators.ConcatenateObject(obj2, (object)node.get_Nodes().get_Item(i).get_Text());
				obj = Operators.ConcatenateObject(obj, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"\r\n", obj2), (object)node.get_Nodes().get_Item(i).get_Name()), (object)"\r\n"), obj2), (object)node.get_Nodes().get_Item(i).get_ImageKey()), (object)"\r\n"), obj2), (object)node.get_Nodes().get_Item(i).get_SelectedImageKey()), (object)"\r\n"), obj2), node.get_Nodes().get_Item(i).get_Tag()));
				text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(obj, (object)"\r\n")));
				obj2 = "";
				if (node.get_Nodes().get_Item(i).get_Nodes()
					.get_Count() > 0)
				{
					text += ToStrFromTree(node.get_Nodes().get_Item(i), toEng, ref ObjsTres);
				}
			}
			return text;
		}
	}

	public static string ToStrFromTreeOneNode(TreeNode node, bool toEng = false)
	{
		object obj = "";
		object obj2 = "";
		string text = "";
		if (node == null)
		{
			return null;
		}
		obj = Operators.ConcatenateObject(obj2, (object)node.get_Text());
		obj = Operators.ConcatenateObject(obj, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"\r\n", obj2), (object)node.get_Name()), (object)"\r\n"), obj2), (object)node.get_ImageKey()), (object)"\r\n"), obj2), (object)node.get_SelectedImageKey()), (object)"\r\n"), obj2), node.get_Tag()));
		text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(obj, (object)"\r\n")));
		obj2 = "";
		return text;
	}

	public static TreeNode ToTreeFromStr(string txt, bool fromEng = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		TreeNode val = new TreeNode();
		string[] array = null;
		if (Operators.CompareString(txt, (string)null, false) == 0)
		{
			return null;
		}
		RichTextBox val2 = new RichTextBox();
		val2.set_Text(txt);
		array = ((TextBoxBase)val2).get_Lines();
		checked
		{
			int num = array.Length - 2;
			int num2;
			int num3 = default(int);
			for (num2 = 0; num2 <= num; num2++)
			{
				if ((Operators.CompareString(array[num2], "", false) == 0) | (array[num2].IndexOf("#") == 0))
				{
					num2++;
				}
				else
				{
					TreeNode val3 = val;
					while (Operators.CompareString(Conversions.ToString(array[num2][num3]), " ", false) == 0)
					{
						num3++;
						if (val3.get_Nodes().get_Count() > 0)
						{
							val3 = val3.get_Nodes().get_Item(val3.get_Nodes().get_Count() - 1);
						}
						if (num3 >= array[num2].Length)
						{
							break;
						}
					}
					val3.get_Nodes().Add(Strings.Trim(array[num2 + 1]), Strings.Trim(array[num2]), Strings.Trim(array[num2 + 2]), Strings.Trim(array[num2 + 2]));
					val3.get_Nodes().get_Item(val3.get_Nodes().get_Count() - 1).set_Tag((object)Strings.Trim(array[num2 + 4]));
					num2 += 4;
					num3 = 0;
				}
			}
			return val;
		}
	}

	public static int ToTreeFromAlgCode(ref TreeNode parent, string[] s, int ind)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		bool flag = false;
		checked
		{
			int num = s.Length - 1;
			int num2 = ind;
			while (true)
			{
				if (num2 <= num)
				{
					TreeNode parent2 = new TreeNode(s[num2]);
					parent2.set_Name(peremens.GetUIN());
					if (Strings.UCase(Strings.Trim(s[num2])).IndexOf(Strings.UCase(peremens.trans("ЕСЛИ"))) == 0)
					{
						parent2.set_Tag((object)"If");
					}
					else if (Strings.UCase(Strings.Trim(s[num2])).IndexOf(Strings.UCase(peremens.trans("ИЛИЕСЛИ"))) == 0)
					{
						parent2.set_Tag((object)"ElseIf");
						if (!flag)
						{
							return num2 - 1;
						}
					}
					else if (Strings.UCase(Strings.Trim(s[num2])).IndexOf(Strings.UCase(peremens.trans("В остальных случаях"))) == 0)
					{
						parent2.set_Tag((object)"Else");
						if (!flag)
						{
							return num2 - 1;
						}
					}
					else if (Strings.UCase(Strings.Trim(s[num2])).IndexOf(Strings.UCase(peremens.trans("Конец условия"))) == 0)
					{
						parent2.set_Tag((object)"EndIf");
						if (!flag)
						{
							return num2 - 1;
						}
					}
					else if (Strings.UCase(Strings.Trim(s[num2])).IndexOf(Strings.UCase(peremens.trans("ПОВТОРЯТЬСЯ ПОКА"))) == 0)
					{
						parent2.set_Tag((object)"While");
					}
					else if (Strings.UCase(Strings.Trim(s[num2])).IndexOf(Strings.UCase(peremens.trans("Конец цикла"))) == 0)
					{
						parent2.set_Tag((object)"EndWhile");
						if (!flag)
						{
							break;
						}
					}
					else
					{
						if ((Strings.Trim(s[num2]).IndexOf("#") == 0) | (Operators.CompareString(Strings.Trim(s[num2]), "", false) == 0))
						{
							goto IL_01e5;
						}
						parent2.set_Tag((object)"Deist");
					}
					flag = false;
					parent.get_Nodes().Add(parent2);
					if (Iz.IsContenerTree(parent2))
					{
						num2 = ToTreeFromAlgCode(ref parent2, s, num2 + 1);
						flag = true;
					}
					goto IL_01e5;
				}
				return ind;
				IL_01e5:
				num2++;
			}
			return num2 - 1;
		}
	}

	public static string ToStrCodeFromObj(object[] MyObj, bool withParentTree = false, bool toEng = false, bool isRun = false, bool withProgres = true)
	{
		//IL_1a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a09: Expected O, but got Unknown
		rp = new RunProject("");
		ref PropertysSobyt param = ref rp.Param;
		param = new PropertysSobyt(null, null, null, peremens.MyZnak + "All");
		ArrayList arrayList = new ArrayList();
		if (MyObj == null)
		{
			return null;
		}
		checked
		{
			int num = MyObj.Length - 1;
			object[] c;
			for (int i = 0; i <= num; i++)
			{
				if (Iz.isPoleznie(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					arrayList.Add(RuntimeHelpers.GetObjectValue(MyObj[i]));
				}
				object proj = peremens2.proj;
				object[] array = new object[3]
				{
					"",
					Missing.Value,
					null
				};
				object[] array2 = array;
				int num2 = i;
				object obj = MyObj[num2];
				object[] array3 = new object[0];
				object[] array4 = array3;
				string[] array5 = null;
				array2[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "obj", array4, array5, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
				object[] array6 = array;
				object[] array7 = array6;
				bool[] array8 = new bool[3] { false, false, true };
				object obj2 = NewLateBinding.LateGet(proj, (Type)null, "GetMyAllFromName", array7, (string[])null, (Type[])null, array8);
				if (array8[2])
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MyObj[num2], (Type)null, "obj", array3, array5, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array6[2]) }, (string[])null, (Type[])null, true, true);
				}
				c = (object[])obj2;
				arrayList.AddRange(c);
			}
			c = arrayList.ToArray();
			int num3 = c.Length - 1;
			string text2 = default(string);
			string text3 = default(string);
			string text4 = default(string);
			string text7 = default(string);
			string text = default(string);
			peremens.ErrString property = default(peremens.ErrString);
			string text10 = default(string);
			string text11 = default(string);
			string text13 = default(string);
			string text14 = default(string);
			string text12 = default(string);
			for (int i = 0; i <= num3; i++)
			{
				if (withProgres)
				{
					peremens2.ProgressForm.ProgressBarValue = (int)Math.Round(100.0 / (double)c.Length * (double)i);
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pProgressForm", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"yes", false))
				{
					if (unchecked(i % 5) == 0)
					{
						text = text + "ProgressForm.ProgressBar1.Value = " + Conversions.ToString(Props.Round(Conversions.ToString(25.0 / (double)c.Length * (double)i))) + "\r\n";
						text2 = text2 + "ProgressForm.ProgressBar1.Value = " + Conversions.ToString(25.0 + Props.Round(Conversions.ToString(10.0 / (double)c.Length * (double)i))) + "\r\n";
						text3 = text3 + "ProgressForm.ProgressBar1.Value = " + Conversions.ToString(35.0 + Props.Round(Conversions.ToString(10.0 / (double)c.Length * (double)i))) + "\r\n";
					}
					text4 = text4 + "ProgressForm.ProgressBar1.Value = " + Conversions.ToString(45.0 + Props.Round(Conversions.ToString(55.0 / (double)c.Length * (double)i))) + "\r\n";
				}
				string compilName = GetCompilName(RuntimeHelpers.GetObjectValue(c[i]));
				string compilName2 = GetCompilName(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "getMyForm", new object[0], (string[])null, (Type[])null, (bool[])null)));
				string text5 = NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString()
					.Substring(peremens.ClassAplication.Length);
				string text6 = c[i].GetType().ToString().Substring(peremens.ClassAplication.Length);
				if (Iz.isPoleznie(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))) & !Iz.IsFORM(RuntimeHelpers.GetObjectValue(c[i])))
				{
					text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("Public WithEvents " + compilName, " As New PoleznieObj(\""), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\")"), (object)"\r\n")));
					text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(compilName + ".MyObj = New ", text6), "(\""), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "type", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\")"), (object)"\r\n")));
				}
				else
				{
					text7 = text7 + "Public WithEvents " + compilName + " As New run" + text5 + "\r\n";
					text = ((!Iz.IsFORM(RuntimeHelpers.GetObjectValue(c[i]))) ? (text + compilName + ".MyObj = New " + text6 + "(True, True)\r\n") : (text + compilName + ".MyObj = New " + text6 + "(True, , True)\r\n"));
					if (Iz.IsCM(RuntimeHelpers.GetObjectValue(c[i])))
					{
						text7 = text7 + "Public WithEvents " + compilName + "CnMn As ContextMenuStrip = " + compilName + ".CnMn\r\n";
					}
				}
				text = text + compilName + ".MyObj.proj = proj\r\n";
				text = text + compilName + ".MyObj.obj = " + compilName + "\r\n";
				text = text + compilName + ".MyObj.VBname = \"" + compilName + "\"\r\n";
				text = text + compilName + ".MyObj.MyObj.MyForm = " + compilName2 + ".MyObj\r\n";
				if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(c[i])))
				{
					text = text + "ReDims(RunProj.f) : RunProj.f(RunProj.f.Length - 1) = " + compilName + ".MyObj\r\n";
				}
				text = text + "ReDimsO(" + compilName + ".MyObj.MyForm.MyObjs) : " + compilName + ".MyObj.MyForm.MyObjs(" + compilName + ".MyObj.MyForm.MyObjs.Length - 1) = " + compilName + ".MyObj\r\n\r\n";
				string[] array9 = new string[10]
				{
					Strings.UCase(peremens.trans("Вышина")),
					Strings.UCase(peremens.trans("Ширина")),
					Strings.UCase(peremens.trans("Видимый")),
					Strings.UCase(peremens.trans("Вышина")),
					Strings.UCase(peremens.trans("Ширина")),
					Strings.UCase(peremens.trans("Значение")),
					Strings.UCase(peremens.trans("Выделенная запись")),
					Strings.UCase(peremens.trans("RTF код документа")),
					Strings.UCase(peremens.trans("Расстояние разделителя")),
					Strings.UCase(peremens.trans("Ссылка"))
				};
				if ((NewLateBinding.LateGet(c[i], (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null) != null) & !Iz.isPoleznie(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					object? objectValue = RuntimeHelpers.GetObjectValue(c[i]);
					bool mozhno = false;
					Props.IzmenenieBylo2(objectValue, ref mozhno);
					int num4 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(c[i], (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int j = 0; j <= num4; j++)
					{
						string[] readOnlyProps = peremens.ReadOnlyProps;
						object obj3 = c[i];
						object[] array6 = new object[1] { j };
						object[] array10 = array6;
						bool[] array8 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "PropertysUp", array10, (string[])null, (Type[])null, array8);
						if (array8[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
						}
						if (Array.IndexOf((Array)readOnlyProps, RuntimeHelpers.GetObjectValue(obj4)) != -1)
						{
							continue;
						}
						object? objectValue2 = RuntimeHelpers.GetObjectValue(c[i]);
						object obj5 = c[i];
						array6 = new object[1] { j };
						object[] array11 = array6;
						array8 = new bool[1] { true };
						object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Propertys", array11, (string[])null, (Type[])null, array8);
						if (array8[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
						}
						property = Props.GetProperty(objectValue2, Conversions.ToString(obj6));
						bool num5 = !isRun;
						string str = property.str;
						object? objectValue3 = RuntimeHelpers.GetObjectValue(peremens.Pustishki[text5]);
						object obj7 = c[i];
						array6 = new object[1] { j };
						object[] array12 = array6;
						array8 = new bool[1] { true };
						object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "Propertys", array12, (string[])null, (Type[])null, array8);
						if (array8[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
						}
						bool num6 = (num5 | (Operators.CompareString(str, Props.GetProperty(objectValue3, Conversions.ToString(obj8)).str, false) != 0) | Iz.IsFORM(RuntimeHelpers.GetObjectValue(c[i]))) & (Operators.CompareString(property.err, "", false) == 0);
						string[] noSaveProps = peremens.NoSaveProps;
						Type typeFromHandle = typeof(Strings);
						object[] array13 = new object[1];
						object[] array14 = array13;
						object[] array15 = c;
						int num2 = i;
						object obj9 = array15[num2];
						object[] array3 = new object[1] { j };
						object[] array16 = array3;
						bool[] array17 = new bool[1] { true };
						object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "Propertys", array16, (string[])null, (Type[])null, array17);
						if (array17[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
						}
						array14[0] = RuntimeHelpers.GetObjectValue(obj10);
						object[] array18 = array13;
						object[] array19 = array18;
						bool[] array20 = new bool[1] { true };
						object obj11 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array19, (string[])null, (Type[])null, array20);
						if (array20[0])
						{
							NewLateBinding.LateSetComplex(c[num2], (Type)null, "Propertys", new object[2]
							{
								j,
								RuntimeHelpers.GetObjectValue(array18[0])
							}, (string[])null, (Type[])null, true, false);
						}
						bool num7 = num6 & (Array.IndexOf((Array)noSaveProps, RuntimeHelpers.GetObjectValue(obj11)) == -1);
						object obj12 = c[i];
						object[] array21 = new object[1] { j };
						object[] array22 = array21;
						bool[] array23 = new bool[1] { true };
						object obj13 = NewLateBinding.LateGet(obj12, (Type)null, "PropertysUp", array22, (string[])null, (Type[])null, array23);
						if (array23[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array21[0]), typeof(int));
						}
						if (!(num7 & (Array.IndexOf((Array)array9, RuntimeHelpers.GetObjectValue(obj13)) == -1)))
						{
							continue;
						}
						string text8 = "";
						property.str = peremens.CreateKovich(peremens.perevesti(property.str, SdelatEnterOrSpecsimvol: false));
						Type typeFromHandle2 = typeof(Strings);
						object[] array24 = new object[1];
						object[] array25 = array24;
						object[] array26 = c;
						num2 = i;
						object obj14 = array26[num2];
						object[] array27 = new object[1] { j };
						object[] array28 = array27;
						array23 = new bool[1] { true };
						object obj15 = NewLateBinding.LateGet(obj14, (Type)null, "Propertys", array28, (string[])null, (Type[])null, array23);
						if (array23[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array27[0]), typeof(int));
						}
						array25[0] = RuntimeHelpers.GetObjectValue(obj15);
						array18 = array24;
						object[] array29 = array18;
						array20 = new bool[1] { true };
						object obj16 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array29, (string[])null, (Type[])null, array20);
						if (array20[0])
						{
							NewLateBinding.LateSetComplex(c[num2], (Type)null, "Propertys", new object[2]
							{
								j,
								RuntimeHelpers.GetObjectValue(array18[0])
							}, (string[])null, (Type[])null, true, false);
						}
						if (Operators.ConditionalCompareObjectEqual(obj16, (object)Strings.UCase(peremens.trans("Статус окна")), false))
						{
							text4 = Conversions.ToString(Operators.ConcatenateObject((object)text4, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(compilName + ".StatusTemp = \""), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowState", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\""), (object)"\r\n")));
							continue;
						}
						Type typeFromHandle3 = typeof(Strings);
						array24 = new object[1];
						object[] array30 = array24;
						object[] array31 = c;
						num2 = i;
						object obj17 = array31[num2];
						array27 = new object[1] { j };
						object[] array32 = array27;
						array23 = new bool[1] { true };
						object obj18 = NewLateBinding.LateGet(obj17, (Type)null, "Propertys", array32, (string[])null, (Type[])null, array23);
						if (array23[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array27[0]), typeof(int));
						}
						array30[0] = RuntimeHelpers.GetObjectValue(obj18);
						array18 = array24;
						object[] array33 = array18;
						array20 = new bool[1] { true };
						object obj19 = NewLateBinding.LateGet((object)null, typeFromHandle3, "UCase", array33, (string[])null, (Type[])null, array20);
						if (array20[0])
						{
							NewLateBinding.LateSetComplex(c[num2], (Type)null, "Propertys", new object[2]
							{
								j,
								RuntimeHelpers.GetObjectValue(array18[0])
							}, (string[])null, (Type[])null, true, false);
						}
						object obj20 = Operators.CompareObjectEqual(obj19, (object)Strings.UCase(peremens.trans("Вложенное всплывающее меню")), false);
						Type typeFromHandle4 = typeof(Strings);
						object[] array = new object[1];
						object[] array34 = array;
						object[] array35 = c;
						int num8 = i;
						object obj21 = array35[num8];
						array6 = new object[1] { j };
						object[] array36 = array6;
						array17 = new bool[1] { true };
						object obj22 = NewLateBinding.LateGet(obj21, (Type)null, "Propertys", array36, (string[])null, (Type[])null, array17);
						if (array17[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
						}
						array34[0] = RuntimeHelpers.GetObjectValue(obj22);
						array3 = array;
						object[] array37 = array3;
						array8 = new bool[1] { true };
						object obj23 = NewLateBinding.LateGet((object)null, typeFromHandle4, "UCase", array37, (string[])null, (Type[])null, array8);
						if (array8[0])
						{
							NewLateBinding.LateSetComplex(c[num8], (Type)null, "Propertys", new object[2]
							{
								j,
								RuntimeHelpers.GetObjectValue(array3[0])
							}, (string[])null, (Type[])null, true, false);
						}
						object obj24 = Operators.OrObject(obj20, Operators.CompareObjectEqual(obj23, (object)Strings.UCase(peremens.trans("Главное меню")), false));
						Type typeFromHandle5 = typeof(Strings);
						object[] array38 = new object[1];
						object[] array39 = array38;
						object[] array40 = c;
						int num9 = i;
						object obj25 = array40[num9];
						object[] array41 = new object[1] { j };
						object[] array42 = array41;
						bool[] array43 = new bool[1] { true };
						object obj26 = NewLateBinding.LateGet(obj25, (Type)null, "Propertys", array42, (string[])null, (Type[])null, array43);
						if (array43[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array41[0]), typeof(int));
						}
						array39[0] = RuntimeHelpers.GetObjectValue(obj26);
						object[] array44 = array38;
						object[] array45 = array44;
						bool[] array46 = new bool[1] { true };
						object obj27 = NewLateBinding.LateGet((object)null, typeFromHandle5, "UCase", array45, (string[])null, (Type[])null, array46);
						if (array46[0])
						{
							NewLateBinding.LateSetComplex(c[num9], (Type)null, "Propertys", new object[2]
							{
								j,
								RuntimeHelpers.GetObjectValue(array44[0])
							}, (string[])null, (Type[])null, true, false);
						}
						if (Conversions.ToBoolean(Operators.OrObject(obj24, Operators.CompareObjectEqual(obj27, (object)Strings.UCase(peremens.trans("Всплывающее меню")), false))))
						{
							text8 = "(True)";
						}
						string[] array5 = new string[8] { text4, compilName, ".Props.", null, null, null, null, null };
						string[] array47 = array5;
						object obj28 = c[i];
						array44 = new object[1] { j };
						object[] array48 = array44;
						array46 = new bool[1] { true };
						object obj29 = NewLateBinding.LateGet(obj28, (Type)null, "Propertys", array48, (string[])null, (Type[])null, array46);
						if (array46[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array44[0]), typeof(int));
						}
						array47[3] = peremens.trans(Conversions.ToString(obj29), toEng: true).Replace(" ", "");
						array5[4] = text8;
						array5[5] = " = perevesti(";
						array5[6] = getCompilLineLength("\"" + property.str + "\"");
						array5[7] = ", True)\r\n";
						text4 = string.Concat(array5);
					}
					int num10 = array9.Length - 1;
					for (int j = 0; j <= num10; j++)
					{
						if (Array.IndexOf((Array)NewLateBinding.LateGet(c[i], (Type)null, "PropertysUp", new object[0], (string[])null, (Type[])null, (bool[])null), array9[j]) != -1)
						{
							property.str = peremens.CreateKovich(peremens.perevesti(Props.GetProperty(RuntimeHelpers.GetObjectValue(c[i]), array9[j]).str, SdelatEnterOrSpecsimvol: false));
							text4 = text4 + compilName + ".Props." + peremens.trans(array9[j], toEng: true).Replace(" ", "") + " = perevesti(" + getCompilLineLength("\"" + property.str + "\"") + ", True)\r\n";
						}
					}
					text4 += "\r\n";
				}
				if (Iz.isPoleznie(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					text4 = Conversions.ToString(Operators.ConcatenateObject((object)text4, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(compilName + ".Props.Name = \""), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\""), (object)"\r\n"), (object)"\r\n")));
				}
				if (NewLateBinding.LateGet(c[i], (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "typeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
				{
					if (Iz.IsMMs(RuntimeHelpers.GetObjectValue(c[i])))
					{
						text2 = text2 + GetCompilName(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null))) + ".MyObj.addMMenuItem(" + compilName + ".MyObj)\r\n";
					}
					else if (Iz.IsDP(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null))))
					{
						if (NewLateBinding.LateGet(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
						{
							text2 = Conversions.ToString(Operators.ConcatenateObject((object)text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(GetCompilName(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null))) + "."), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)".Controls.Add("), (object)compilName), (object)")"), (object)"\r\n")));
						}
					}
					else
					{
						text2 = text2 + GetCompilName(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null))) + ".Controls.Add(" + compilName + ")\r\n";
					}
				}
				if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(c[i])) & !Iz.isPoleznie(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					int num11 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(c[i], (Type)null, "HistoryLevel", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int j = 0; j <= num11; j++)
					{
						object obj30 = c[i];
						object[] array44 = new object[1] { j };
						object[] array49 = array44;
						bool[] array46 = new bool[1] { true };
						object obj31 = NewLateBinding.LateGet(obj30, (Type)null, "HistoryLevel", array49, (string[])null, (Type[])null, array46);
						if (array46[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array44[0]), typeof(int));
						}
						if (NewLateBinding.LateGet(obj31, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
						{
							string text9 = text3;
							object obj32 = c[i];
							object[] array41 = new object[1] { j };
							object[] array50 = array41;
							bool[] array43 = new bool[1] { true };
							object obj33 = NewLateBinding.LateGet(obj32, (Type)null, "HistoryLevel", array50, (string[])null, (Type[])null, array43);
							if (array43[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array41[0]), typeof(int));
							}
							text3 = text9 + GetCompilName(RuntimeHelpers.GetObjectValue(obj33)) + ".BringToFront()\r\n";
						}
					}
				}
				if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(c[i])))
				{
					text10 = text10 + "Public Sub " + compilName + "_DisposedEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles " + compilName + ".Disposed\r\n    If DaOrNet(" + compilName + ".Props.MainForm) Then proj.isCLOSING = True : Application.Exit()\r\nEnd Sub\r\n\r\n";
					text10 = text10 + "Public Sub " + compilName + "_FormClosingNado(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles " + compilName + ".FormClosing\r\n    If DaOrNet(" + compilName + ".Props.ForbidClose) Then e.Cancel = True : Exit Sub\r\n    If UCase(" + compilName + ".Props.MainForm) = UCase(trans(\"Да\")) Or proj.isCLOSING Then\r\n        " + compilName + ".Hide() : Application.Exit()\r\n    Else\r\n        e.Cancel = True : " + compilName + ".Hide()\r\n    End If\r\nEnd Sub\r\n\r\n";
				}
				else if (Iz.IsMd(RuntimeHelpers.GetObjectValue(c[i])))
				{
					text10 = text10 + "Public Sub " + compilName + "_SizeChangedNado(ByVal sender As Object, ByVal e As System.EventArgs) Handles " + compilName + ".SizeChanged\r\n" + compilName + ".Props.Refresh()\r\nEnd Sub\r\n\r\n";
				}
				else if (Iz.IsRT(RuntimeHelpers.GetObjectValue(c[i])))
				{
					text10 = text10 + "Public Sub " + compilName + "_LinkClickedNado(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles " + compilName + ".LinkClicked\r\n    If DaOrNet(" + compilName + ".Props.InternetLink) Then " + compilName + ".Props.GoInternetLink(e.LinkText)\r\nEnd Sub\r\n\r\n";
				}
				else if (Iz.IsLLb(RuntimeHelpers.GetObjectValue(c[i])))
				{
					text10 = text10 + "Public Sub " + compilName + "_LinkClickedNado(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles " + compilName + ".LinkClicked\r\n    If DaOrNet(" + compilName + ".Props.InternetLink) Then " + compilName + ".Props.GoInternetLink()\r\nEnd Sub\r\n\r\n";
				}
				else if (Iz.IsTm(RuntimeHelpers.GetObjectValue(c[i])))
				{
					text10 = text10 + "Public Sub " + compilName + "_TickNado(ByVal sender As Object, ByVal e As System.EventArgs) Handles " + compilName + ".Tick\r\n" + compilName + ".Props.IntervalCount += 1\r\nEnd Sub\r\n\r\n";
				}
				else if (Iz.IsW(RuntimeHelpers.GetObjectValue(c[i])))
				{
					text10 = text10 + "Public Sub " + compilName + "_StatusTextChangedNado(ByVal sender As Object, ByVal e As System.EventArgs) Handles " + compilName + ".StatusTextChanged\r\n    If sender.StatusText <> \"\" Then\r\n        If Uri.IsWellFormedUriString(sender.StatusText, UriKind.RelativeOrAbsolute) Then\r\n             sender.lastLink = sender.StatusText\r\n        End If\r\n    End If\r\nEnd Sub\r\nPublic Sub " + compilName + "_NewWindowNado(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles " + compilName + ".NewWindow\r\n    peremens2.WebBrowser_NewWindowNado(sender, e)\r\nEnd Sub\r\n\r\n";
				}
				else if (Iz.IsTbx(RuntimeHelpers.GetObjectValue(c[i])))
				{
					text10 = text10 + "Public Sub " + compilName + "_KeyPressNado(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles " + compilName + ".KeyPress\r\n    e.Handled = TextBoxAllow(sender, e)\r\nEnd Sub\r\n\r\n";
				}
				TreeNode val = (TreeNode)NewLateBinding.LateGet(c[i], (Type)null, "GetNode", new object[2]
				{
					Missing.Value,
					true
				}, (string[])null, (Type[])null, (bool[])null);
				if (val != null)
				{
					peremens.isCompilBest = true;
					int num12 = val.get_Nodes().get_Count() - 1;
					for (int j = 0; j <= num12; j++)
					{
						text11 = text11 + getCompilEvent(RuntimeHelpers.GetObjectValue(c[i]), val.get_Nodes().get_Item(j), compilName) + "\r\n\r\n";
						if (Operators.CompareString(val.get_Nodes().get_Item(j).get_Text()
							.ToUpper(), peremens.trans("Тикнул").ToUpper(), false) == 0)
						{
							text12 = text12 + "RemoveHandler " + compilName + ".Tick, AddressOf " + compilName + "_Tick\r\n";
							text12 = text12 + "AddHandler " + compilName + ".Tick, AddressOf " + compilName + "_Tick\r\n\r\n";
						}
					}
					peremens.isCompilBest = false;
				}
				if (Iz.isPoleznie(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(c[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					continue;
				}
				text13 = text13 + compilName + ".load()\r\n";
				if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(c[i])))
				{
					if (Operators.CompareString(text14, "", false) != 0)
					{
						text12 = text12 + text14 + ".RaiseCreate()\r\n";
					}
					text14 = compilName;
				}
				else
				{
					text12 = text12 + compilName + ".RaiseCreate()\r\n";
				}
			}
			text12 = text12 + text14 + ".RaiseCreate()\r\n";
			string text15 = "Module CodeAlg\r\n\r\n";
			text15 = text15 + text7 + "\r\n\r\n";
			text15 += "    Sub Initial()\r\nRunProj.isINITIALIZATED = True\r\n\r\n";
			text15 += "' Задание переменных\r\n";
			text15 = Conversions.ToString(Operators.ConcatenateObject((object)text15, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"RunProj.iPathShort = \"", NewLateBinding.LateGet(peremens2.proj, (Type)null, "iPathShort", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\""), (object)"\r\n")));
			text15 += "RunProj.iPath = RunProj.pPath & RunProj.iPathShort\r\n\r\n";
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pProgressForm", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"yes", false))
			{
				text15 += "' Отображение полосы загрузки\r\n";
				text15 = text15 + "ProgressForm.Label1.Text = \"" + peremens.transInfc("Загрузка") + "...\"\r\n";
				text15 += "ProgressForm.Show()\r\n";
				text15 += "Application.DoEvents()\r\n";
				text15 += "ProgressForm.ProgressBarValue = 1\r\n\r\n";
			}
			text15 += "' Создание всех объектов\r\n";
			text15 = text15 + text + "\r\n\r\n";
			text15 += "' Размещение объектов на окнах\r\n";
			text15 = text15 + text2 + "\r\n\r\n";
			text15 += "' Уровнять по уровням объекты\r\n";
			text15 = text15 + text3 + "\r\n\r\n";
			text15 += "' Настройка свойств объектов\r\n";
			text15 = text15 + text4 + "\r\n";
			text15 += "' Окончательная загрузка\r\n";
			text15 = text15 + text13 + "\r\nRunProj.GetAllObjects()\r\nRunProj.isINITIALIZATED = False\r\n\r\n" + text12 + "\r\n";
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pProgressForm", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"yes", false))
			{
				text15 += "ProgressForm.Hide()\r\n";
			}
			text15 += "    End Sub\r\n\r\n";
			text15 += "' Обязательные события\r\n";
			text15 = text15 + text10 + "\r\n\r\n";
			text15 += "' Все события\r\n";
			text15 = text15 + text11 + "\r\n";
			return text15 + "End Module\r\n\r\n\r\n\r\n";
		}
	}

	public static string getCompilEvent(object myObj, TreeNode node, string name)
	{
		string text = peremens.trans(node.get_Text(), toEng: true).Replace(" ", "");
		PropertysSobyt propertysSobyt = new PropertysSobyt(null, null, null, node.get_Text());
		object obj = "";
		object obj2 = "";
		string text2 = name;
		if (Operators.ConditionalCompareObjectNotEqual(node.get_Tag(), (object)"Sobyt", false))
		{
			return "";
		}
		if ((Operators.CompareString(Strings.UCase(node.get_Text()), Strings.UCase(peremens.trans("Добавли строку")), false) == 0) | (Operators.CompareString(Strings.UCase(node.get_Text()), Strings.UCase(peremens.trans("Удалили строку")), false) == 0))
		{
			obj2 = "If " + name + ".Props.isSelecExecute Then Exit Sub\r\n";
		}
		else if (Iz.IsTbx(RuntimeHelpers.GetObjectValue(myObj)) & (Operators.CompareString(Strings.UCase(node.get_Text()), Strings.UCase(peremens.trans("Нажатие клавиатуры")), false) == 0))
		{
			obj2 = "e.Handled = TextBoxAllow(sender, e)\r\n";
			obj2 = Operators.ConcatenateObject(obj2, (object)"If e.Handled Then Exit Sub\r\n");
		}
		else if (Operators.CompareString(Strings.UCase(node.get_Text()), Strings.UCase(peremens.trans("Клик по выделенной ячейке")), false) == 0)
		{
			text = "CellMouseDown";
			obj2 = "If e.RowIndex > -1 And e.ColumnIndex > -1 Then\r\n   If " + name + ".Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = False Then Exit Sub\r\nEnd If\r\n";
		}
		else if (Operators.CompareString(Strings.UCase(node.get_Text()), Strings.UCase(peremens.trans("Движение бегунка")), false) == 0)
		{
			text = "Scroll";
		}
		else if (Iz.IsCM(RuntimeHelpers.GetObjectValue(myObj)))
		{
			text2 += "CnMn";
		}
		obj = "Public Sub " + name + "_" + text + "(ByVal sender As Object, ByVal e As ";
		obj = Operators.ConcatenateObject(obj, (object)string.Concat(string.Concat(string.Concat(string.Concat(propertysSobyt.eType + ") Handles ", text2), "."), text), "\r\n"));
		obj = Operators.ConcatenateObject(obj, (object)"If RunProj.isINITIALIZATED Then Exit Sub\r\n");
		obj = Operators.ConcatenateObject(obj, (object)string.Concat(string.Concat(string.Concat(string.Concat("Dim CurrentEvent as New PropertysSobyt(" + name, ".MyObj, e, nothing,\""), node.get_Text()), "\")"), "\r\n"));
		obj = Operators.ConcatenateObject(obj, Operators.ConcatenateObject(obj2, (object)"\r\n"));
		checked
		{
			int num = node.get_Nodes().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(node.get_Nodes().get_Item(i).get_Tag(), (object)"Comm", false), (object)(node.get_Nodes().get_Item(i).get_Text()
					.IndexOf("'") == 0)), (object)(node.get_Nodes().get_Item(i).get_Text()
					.IndexOf("#") == 0)), (object)(node.get_Nodes().get_Item(i).get_Text()
					.IndexOf("/") == 0))))
				{
					obj = Operators.ConcatenateObject(obj, (object)getCompilNode(node.get_Nodes().get_Item(i)));
				}
			}
			obj = Operators.ConcatenateObject(obj, (object)"CurrentEvent.Zavershit()\r\nEnd Sub\r\n");
			return Conversions.ToString(obj);
		}
	}

	public static string getCompilNode(TreeNode node)
	{
		string result = default(string);
		if (Operators.CompareString(Strings.UCase(node.get_Text()), Strings.UCase(peremens.trans("Добавьте сюда действия")), false) == 0)
		{
			return result;
		}
		result = rp.RunString(node.get_Text(), Conversions.ToString(node.get_Tag()), rp.Param).str + "\r\n";
		checked
		{
			int num = node.get_Nodes().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				result += getCompilNode(node.get_Nodes().get_Item(i));
			}
			return result;
		}
	}

	public static string getCompilLineLength(string str)
	{
		int i = 0;
		checked
		{
			int num2;
			for (int num = 9998; str.Length - i > num; i += num - num2)
			{
				char c = '"';
				num2 = 0;
				int j;
				for (j = 0; Operators.CompareString(str.Substring(num + i - j, 1), "\"", false) == 0; j++)
				{
				}
				if ((j > 0) & (unchecked(j % 2) == 0))
				{
					num2 = 1;
				}
				if (j == 0 && Operators.CompareString(Conversions.ToString(str[num + i - 1]), "\"", false) == 0)
				{
					for (int num3 = num + i - 1; num3 >= 0; num3--)
					{
						if (Operators.CompareString(str.Substring(num3, 1), "\"", false) == 0)
						{
							j++;
						}
					}
					if (unchecked(j % 2) == 0)
					{
						c = '\0';
					}
				}
				str = str.Substring(0, num + i - num2) + Conversions.ToString(c) + " & _\r\n" + Conversions.ToString(c) + str.Substring(num + i - num2);
			}
			return str;
		}
	}

	public static string GetCompilName(object myObj)
	{
		return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { " ", "_" }, (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Index", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { ",", "_" }, (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { " ", "_" }, (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Index", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Replace", new object[2] { ",", "_" }, (string[])null, (Type[])null, (bool[])null)));
	}
}
