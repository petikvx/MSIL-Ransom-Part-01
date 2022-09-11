using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My;

[StandardModule]
public sealed class peremens2
{
	public class Blok
	{
		public Blok(object a, object b)
		{
		}
	}

	public class Master : Control
	{
		public Master(object a, object b)
		{
		}

		public void Ok_Click(object a, object b)
		{
		}
	}

	public class mainClass
	{
		public static void Main()
		{
		}

		public void RunProj_NodeStop(object objs)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			TreeNode val = (TreeNode)NewLateBinding.LateIndexGet(objs, new object[1] { 0 }, (string[])null);
			object obj = NewLateBinding.LateIndexGet(objs, new object[1] { 1 }, (string[])null);
			PropertysSobyt propertysSobyt = default(PropertysSobyt);
			RunProj_NodeStop(val, (obj != null) ? ((PropertysSobyt)obj) : propertysSobyt);
		}

		public void RunProj_NodeStop(TreeNode node, PropertysSobyt param)
		{
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(my.Forms());
			object obj = NewLateBinding.LateGet(objectValue, (Type)null, "Main1", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2] { node, param };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, "RunProj_NodeStop", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				node = (TreeNode)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(TreeNode));
			}
			if (array2[1])
			{
				param = (PropertysSobyt)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(PropertysSobyt));
			}
		}
	}

	public class EditProperty
	{
	}

	public class ClientServerMy : Control
	{
	}

	public class InternetControl : Control
	{
	}

	public static object MnFrm;

	public static mainClass MnFrmPotok;

	public static object MainForm;

	public static object WindowsApplication1;

	public static object proj;

	public static object CreateDs;

	public static object CreateIfs;

	public static object CreateCycles;

	public static object EditPrComm;

	public static object intr;

	public static Progress ProgressForm = new Progress();

	public static void WebBrowser_NewWindowNado(object sender, CancelEventArgs e)
	{
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить в новом окне")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[2]
				{
					Strings.UCase(peremens.MyZnak + peremens.trans("Отменить в новом окне")),
					""
				}, (string[])null, (Type[])null, false, true);
				e.Cancel = true;
				return;
			}
		}
		else if (e.Cancel)
		{
			return;
		}
		if (e.Cancel)
		{
			return;
		}
		Type typeFromHandle = typeof(Strings);
		object[] array = new object[1];
		object[] array2 = array;
		object[] array3 = new object[0];
		object[] array4 = array3;
		string[] array5 = null;
		array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (Type)null, "Props", array4, array5, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array6 = array;
		bool[] array7 = new bool[1] { true };
		object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array6, (string[])null, (Type[])null, array7);
		if (array7[0])
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (Type)null, "Props", array3, array5, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
		}
		object[] array10;
		object obj2;
		object[] array8;
		bool[] array12;
		if (Operators.ConditionalCompareObjectEqual(obj, (object)Strings.UCase(peremens.trans("В данном браузере")), false))
		{
			array8 = new object[1];
			object[] array9 = array8;
			obj2 = sender;
			array9[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "lastLink", new object[0], (string[])null, (Type[])null, (bool[])null));
			array10 = array8;
			object[] array11 = array10;
			array12 = new bool[1] { true };
			NewLateBinding.LateCall(sender, (Type)null, "Navigate", array11, (string[])null, (Type[])null, array12, true);
			if (array12[0])
			{
				NewLateBinding.LateSetComplex(obj2, (Type)null, "lastLink", new object[1] { RuntimeHelpers.GetObjectValue(array10[0]) }, (string[])null, (Type[])null, true, false);
			}
			e.Cancel = true;
			return;
		}
		Type typeFromHandle2 = typeof(Strings);
		array10 = new object[1];
		object[] array13 = array10;
		obj2 = sender;
		object obj3 = obj2;
		object[] array14 = new object[0];
		object[] array15 = array14;
		array5 = null;
		array13[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Props", array15, array5, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[0], (string[])null, (Type[])null, (bool[])null));
		array8 = array10;
		object[] array16 = array8;
		array12 = new bool[1] { true };
		object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array16, (string[])null, (Type[])null, array12);
		if (array12[0])
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Props", array14, array5, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[1] { RuntimeHelpers.GetObjectValue(array8[0]) }, (string[])null, (Type[])null, true, true);
		}
		if (!Operators.ConditionalCompareObjectEqual(obj4, (object)Strings.UCase(peremens.trans("По умолчанию")), false))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(peremens.RunProj.GetObjFromUniqName(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[0], (string[])null, (Type[])null, (bool[])null))));
			if (objectValue == null)
			{
				Errors.MessangeExclamen(Errors.InvalidWebBrowser(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[0], (string[])null, (Type[])null, (bool[])null))));
				return;
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Url", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type)null, "lastLink", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			e.Cancel = true;
		}
	}

	public static void ShowPropInEditProperty(object o)
	{
	}
}
