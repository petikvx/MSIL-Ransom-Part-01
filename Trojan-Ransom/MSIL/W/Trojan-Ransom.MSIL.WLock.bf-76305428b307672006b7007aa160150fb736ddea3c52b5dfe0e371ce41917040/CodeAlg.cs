using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class CodeAlg
{
	[AccessedThroughProperty("Окно10Окно10")]
	private static runF runF_0;

	[AccessedThroughProperty("Окно10Надпись10")]
	private static runLb runLb_0;

	[AccessedThroughProperty("Окно10Надпись20")]
	private static runLb runLb_1;

	[AccessedThroughProperty("Окно10Кнопка10")]
	private static runB runB_0;

	[AccessedThroughProperty("Окно10Текст10")]
	private static runT runT_0;

	[AccessedThroughProperty("Окно10Кнопка20")]
	private static runB runB_1;

	[AccessedThroughProperty("Окно10Кнопка30")]
	private static runB runB_2;

	[AccessedThroughProperty("Окно10Кнопка40")]
	private static runB runB_3;

	[AccessedThroughProperty("Окно10Кнопка50")]
	private static runB runB_4;

	[AccessedThroughProperty("Окно10Кнопка60")]
	private static runB runB_5;

	[AccessedThroughProperty("Окно10Кнопка70")]
	private static runB runB_6;

	[AccessedThroughProperty("Окно10Кнопка80")]
	private static runB runB_7;

	[AccessedThroughProperty("Окно10Кнопка90")]
	private static runB runB_8;

	[AccessedThroughProperty("Окно10Кнопка100")]
	private static runB runB_9;

	[AccessedThroughProperty("Окно10Кнопка110")]
	private static runB runB_10;

	[AccessedThroughProperty("Окно10РАЗБЛОКИРОВАТЬ_ВИНДУ0")]
	private static runB runB_11;

	[AccessedThroughProperty("_Полезные_объекты0_Полезные_объекты0")]
	private static runF runF_1;

	[AccessedThroughProperty("_Полезные_объекты0_Экран0")]
	private static PoleznieObj poleznieObj_0;

	[AccessedThroughProperty("_Полезные_объекты0_Файлы_и_папки0")]
	private static PoleznieObj poleznieObj_1;

	[AccessedThroughProperty("_Полезные_объекты0_Прерывания0")]
	private static PoleznieObj poleznieObj_2;

	[AccessedThroughProperty("_Полезные_объекты0_Система0")]
	private static PoleznieObj poleznieObj_3;

	[AccessedThroughProperty("_Полезные_объекты0_Реестр0")]
	private static PoleznieObj poleznieObj_4;

	[AccessedThroughProperty("_Полезные_объекты0_Вызвать_событие0")]
	private static PoleznieObj poleznieObj_5;

	[AccessedThroughProperty("_Полезные_объекты0_Текст0")]
	private static PoleznieObj poleznieObj_6;

	[AccessedThroughProperty("_Полезные_объекты0_Показать_сообщение0")]
	private static PoleznieObj poleznieObj_7;

	[AccessedThroughProperty("_Полезные_объекты0_Дата0")]
	private static PoleznieObj poleznieObj_8;

	[AccessedThroughProperty("_Полезные_объекты0_Расширенные_возможности0")]
	private static PoleznieObj poleznieObj_9;

	public static runF RunF_0
	{
		get
		{
			return runF_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			if (runF_0 != null)
			{
				((Form)runF_0).remove_FormClosing(new FormClosingEventHandler(smethod_1));
				((Component)(object)runF_0).Disposed -= smethod_0;
			}
			runF_0 = value;
			if (runF_0 != null)
			{
				((Form)runF_0).add_FormClosing(new FormClosingEventHandler(smethod_1));
				((Component)(object)runF_0).Disposed += smethod_0;
			}
		}
	} = new runF();


	public static runLb RunLb_0
	{
		get
		{
			return runLb_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_0 = value;
		}
	} = new runLb();


	public static runLb RunLb_1
	{
		get
		{
			return runLb_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_1 = value;
		}
	} = new runLb();


	public static runB RunB_0
	{
		get
		{
			return runB_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_0 != null)
			{
				((Control)runB_0).remove_Click((EventHandler)smethod_5);
			}
			runB_0 = value;
			if (runB_0 != null)
			{
				((Control)runB_0).add_Click((EventHandler)smethod_5);
			}
		}
	} = new runB();


	public static runT RunT_0
	{
		get
		{
			return runT_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			if (runT_0 != null)
			{
				((Control)runT_0).remove_KeyPress(new KeyPressEventHandler(smethod_2));
			}
			runT_0 = value;
			if (runT_0 != null)
			{
				((Control)runT_0).add_KeyPress(new KeyPressEventHandler(smethod_2));
			}
		}
	} = new runT();


	public static runB RunB_1
	{
		get
		{
			return runB_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_1 != null)
			{
				((Control)runB_1).remove_Click((EventHandler)smethod_6);
			}
			runB_1 = value;
			if (runB_1 != null)
			{
				((Control)runB_1).add_Click((EventHandler)smethod_6);
			}
		}
	} = new runB();


	public static runB RunB_2
	{
		get
		{
			return runB_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_2 != null)
			{
				((Control)runB_2).remove_Click((EventHandler)smethod_7);
			}
			runB_2 = value;
			if (runB_2 != null)
			{
				((Control)runB_2).add_Click((EventHandler)smethod_7);
			}
		}
	} = new runB();


	public static runB RunB_3
	{
		get
		{
			return runB_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_3 != null)
			{
				((Control)runB_3).remove_Click((EventHandler)smethod_8);
			}
			runB_3 = value;
			if (runB_3 != null)
			{
				((Control)runB_3).add_Click((EventHandler)smethod_8);
			}
		}
	} = new runB();


	public static runB RunB_4
	{
		get
		{
			return runB_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_4 != null)
			{
				((Control)runB_4).remove_Click((EventHandler)smethod_9);
			}
			runB_4 = value;
			if (runB_4 != null)
			{
				((Control)runB_4).add_Click((EventHandler)smethod_9);
			}
		}
	} = new runB();


	public static runB RunB_5
	{
		get
		{
			return runB_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_5 != null)
			{
				((Control)runB_5).remove_Click((EventHandler)smethod_10);
			}
			runB_5 = value;
			if (runB_5 != null)
			{
				((Control)runB_5).add_Click((EventHandler)smethod_10);
			}
		}
	} = new runB();


	public static runB RunB_6
	{
		get
		{
			return runB_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_6 != null)
			{
				((Control)runB_6).remove_Click((EventHandler)smethod_11);
			}
			runB_6 = value;
			if (runB_6 != null)
			{
				((Control)runB_6).add_Click((EventHandler)smethod_11);
			}
		}
	} = new runB();


	public static runB RunB_7
	{
		get
		{
			return runB_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_7 != null)
			{
				((Control)runB_7).remove_Click((EventHandler)smethod_12);
			}
			runB_7 = value;
			if (runB_7 != null)
			{
				((Control)runB_7).add_Click((EventHandler)smethod_12);
			}
		}
	} = new runB();


	public static runB RunB_8
	{
		get
		{
			return runB_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_8 != null)
			{
				((Control)runB_8).remove_Click((EventHandler)smethod_13);
			}
			runB_8 = value;
			if (runB_8 != null)
			{
				((Control)runB_8).add_Click((EventHandler)smethod_13);
			}
		}
	} = new runB();


	public static runB RunB_9
	{
		get
		{
			return runB_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_9 != null)
			{
				((Control)runB_9).remove_Click((EventHandler)smethod_14);
			}
			runB_9 = value;
			if (runB_9 != null)
			{
				((Control)runB_9).add_Click((EventHandler)smethod_14);
			}
		}
	} = new runB();


	public static runB RunB_10
	{
		get
		{
			return runB_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_10 != null)
			{
				((Control)runB_10).remove_Click((EventHandler)smethod_15);
			}
			runB_10 = value;
			if (runB_10 != null)
			{
				((Control)runB_10).add_Click((EventHandler)smethod_15);
			}
		}
	} = new runB();


	public static runB RunB_11
	{
		get
		{
			return runB_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runB_11 != null)
			{
				((Control)runB_11).remove_Click((EventHandler)smethod_16);
			}
			runB_11 = value;
			if (runB_11 != null)
			{
				((Control)runB_11).add_Click((EventHandler)smethod_16);
			}
		}
	} = new runB();


	public static runF RunF_1
	{
		get
		{
			return runF_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			if (runF_1 != null)
			{
				((Form)runF_1).remove_FormClosing(new FormClosingEventHandler(smethod_4));
				((Component)(object)runF_1).Disposed -= smethod_3;
			}
			runF_1 = value;
			if (runF_1 != null)
			{
				((Form)runF_1).add_FormClosing(new FormClosingEventHandler(smethod_4));
				((Component)(object)runF_1).Disposed += smethod_3;
			}
		}
	} = new runF();


	public static PoleznieObj PoleznieObj_0
	{
		get
		{
			return poleznieObj_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_0 = value;
		}
	} = new PoleznieObj("_Экран");


	public static PoleznieObj PoleznieObj_1
	{
		get
		{
			return poleznieObj_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_1 = value;
		}
	} = new PoleznieObj("_Файлы и папки");


	public static PoleznieObj PoleznieObj_2
	{
		get
		{
			return poleznieObj_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_2 = value;
		}
	} = new PoleznieObj("_Прерывания");


	public static PoleznieObj PoleznieObj_3
	{
		get
		{
			return poleznieObj_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_3 = value;
		}
	} = new PoleznieObj("_Система");


	public static PoleznieObj PoleznieObj_4
	{
		get
		{
			return poleznieObj_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_4 = value;
		}
	} = new PoleznieObj("_Реестр");


	public static PoleznieObj PoleznieObj_5
	{
		get
		{
			return poleznieObj_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_5 = value;
		}
	} = new PoleznieObj("_Вызвать событие");


	public static PoleznieObj PoleznieObj_6
	{
		get
		{
			return poleznieObj_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_6 = value;
		}
	} = new PoleznieObj("_Текст");


	public static PoleznieObj PoleznieObj_7
	{
		get
		{
			return poleznieObj_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_7 = value;
		}
	} = new PoleznieObj("_Показать сообщение");


	public static PoleznieObj PoleznieObj_8
	{
		get
		{
			return poleznieObj_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_8 = value;
		}
	} = new PoleznieObj("_Дата");


	public static PoleznieObj PoleznieObj_9
	{
		get
		{
			return poleznieObj_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			poleznieObj_9 = value;
		}
	} = new PoleznieObj("_Расширенные возможности");


	public static void Initial()
	{
		peremens.RunProj.isINITIALIZATED = true;
		peremens.RunProj.iPathShort = "Рисунки\\";
		peremens.RunProj.iPath = peremens.RunProj.pPath + peremens.RunProj.iPathShort;
		peremens2.ProgressForm.Label1.set_Text("Загрузка...");
		((Control)peremens2.ProgressForm).Show();
		Application.DoEvents();
		peremens2.ProgressForm.ProgressBarValue = 1;
		peremens2.ProgressForm.ProgressBar1.set_Value(0);
		RunF_0.MyObj = new Forms(holostoi: true, polezniy: false, isRun: true);
		NewLateBinding.LateSet(RunF_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(RunF_0.MyObj, (Type)null, "obj", new object[1] { RunF_0 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(RunF_0.MyObj, (Type)null, "VBname", new object[1] { "Окно10Окно10" }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
		peremens.ReDims(ref peremens.RunProj.f);
		checked
		{
			peremens.RunProj.f[peremens.RunProj.f.Length - 1] = (Forms)RunF_0.MyObj;
			object myObj = RunF_0.MyObj;
			object obj = myObj;
			object[] array = new object[0];
			object[] array2 = array;
			string[] array3 = null;
			object mass = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MyForm", array2, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref mass);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(myObj, (Type)null, "MyForm", array, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(mass) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunF_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunF_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_0.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_0.MyObj, (Type)null, "obj", new object[1] { RunLb_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_0.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_0.MyObj;
			object obj2 = mass;
			object[] array4 = new object[0];
			object[] array5 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "MyForm", array5, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_1.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_1.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_1.MyObj, (Type)null, "obj", new object[1] { RunLb_1 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_1.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись20" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_1.MyObj;
			object obj3 = mass;
			array4 = new object[0];
			object[] array6 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "MyForm", array6, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_1.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_0.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_0.MyObj, (Type)null, "obj", new object[1] { RunB_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_0.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_0.MyObj;
			object obj4 = mass;
			array4 = new object[0];
			object[] array7 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "MyForm", array7, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunT_0.MyObj = new TextBoks(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunT_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunT_0.MyObj, (Type)null, "obj", new object[1] { RunT_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunT_0.MyObj, (Type)null, "VBname", new object[1] { "Окно10Текст10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunT_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunT_0.MyObj;
			object obj5 = mass;
			array4 = new object[0];
			object[] array8 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "MyForm", array8, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunT_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunT_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunT_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(5);
			RunB_1.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_1.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_1.MyObj, (Type)null, "obj", new object[1] { RunB_1 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_1.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка20" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_1.MyObj;
			object obj6 = mass;
			array4 = new object[0];
			object[] array9 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "MyForm", array9, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_1.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_2.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_2.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_2.MyObj, (Type)null, "obj", new object[1] { RunB_2 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_2.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка30" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_2.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_2.MyObj;
			object obj7 = mass;
			array4 = new object[0];
			object[] array10 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "MyForm", array10, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_2.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_3.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_3.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_3.MyObj, (Type)null, "obj", new object[1] { RunB_3 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_3.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка40" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_3.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_3.MyObj;
			object obj8 = mass;
			array4 = new object[0];
			object[] array11 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "MyForm", array11, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_3.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_4.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_4.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_4.MyObj, (Type)null, "obj", new object[1] { RunB_4 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_4.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка50" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_4.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_4.MyObj;
			object obj9 = mass;
			array4 = new object[0];
			object[] array12 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "MyForm", array12, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_4.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_4.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_4.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_5.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_5.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_5.MyObj, (Type)null, "obj", new object[1] { RunB_5 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_5.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка60" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_5.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_5.MyObj;
			object obj10 = mass;
			array4 = new object[0];
			object[] array13 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj10, (Type)null, "MyForm", array13, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_5.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_5.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_5.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(9);
			RunB_6.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_6.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_6.MyObj, (Type)null, "obj", new object[1] { RunB_6 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_6.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка70" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_6.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_6.MyObj;
			object obj11 = mass;
			array4 = new object[0];
			object[] array14 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj11, (Type)null, "MyForm", array14, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_6.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_6.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_6.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_7.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_7.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_7.MyObj, (Type)null, "obj", new object[1] { RunB_7 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_7.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка80" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_7.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_7.MyObj;
			object obj12 = mass;
			array4 = new object[0];
			object[] array15 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj12, (Type)null, "MyForm", array15, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_7.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_7.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_7.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_8.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_8.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_8.MyObj, (Type)null, "obj", new object[1] { RunB_8 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_8.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка90" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_8.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_8.MyObj;
			object obj13 = mass;
			array4 = new object[0];
			object[] array16 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj13, (Type)null, "MyForm", array16, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_8.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_8.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_8.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_9.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_9.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_9.MyObj, (Type)null, "obj", new object[1] { RunB_9 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_9.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка100" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_9.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_9.MyObj;
			object obj14 = mass;
			array4 = new object[0];
			object[] array17 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj14, (Type)null, "MyForm", array17, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_9.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_10.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_10.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_10.MyObj, (Type)null, "obj", new object[1] { RunB_10 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_10.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка110" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_10.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_10.MyObj;
			object obj15 = mass;
			array4 = new object[0];
			object[] array18 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj15, (Type)null, "MyForm", array18, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_10.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_10.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_10.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(14);
			RunB_11.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_11.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_11.MyObj, (Type)null, "obj", new object[1] { RunB_11 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_11.MyObj, (Type)null, "VBname", new object[1] { "Окно10РАЗБЛОКИРОВАТЬ_ВИНДУ0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_11.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_11.MyObj;
			object obj16 = mass;
			array4 = new object[0];
			object[] array19 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj16, (Type)null, "MyForm", array19, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_11.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_11.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_11.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunF_1.MyObj = new Forms(holostoi: true, polezniy: false, isRun: true);
			NewLateBinding.LateSet(RunF_1.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_1.MyObj, (Type)null, "obj", new object[1] { RunF_1 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_1.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Полезные_объекты0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			peremens.ReDims(ref peremens.RunProj.f);
			peremens.RunProj.f[peremens.RunProj.f.Length - 1] = (Forms)RunF_1.MyObj;
			mass = RunF_1.MyObj;
			object obj17 = mass;
			array4 = new object[0];
			object[] array20 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj17, (Type)null, "MyForm", array20, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunF_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunF_1.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_0.MyObj = new Poleznie("_Экран");
			NewLateBinding.LateSet(PoleznieObj_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_0.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_0.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Экран0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_0.MyObj;
			object obj18 = mass;
			array4 = new object[0];
			object[] array21 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj18, (Type)null, "MyForm", array21, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_1.MyObj = new Poleznie("_Файлы и папки");
			NewLateBinding.LateSet(PoleznieObj_1.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_1.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_1 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_1.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Файлы_и_папки0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_1.MyObj;
			object obj19 = mass;
			array4 = new object[0];
			object[] array22 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj19, (Type)null, "MyForm", array22, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_1.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_2.MyObj = new Poleznie("_Прерывания");
			NewLateBinding.LateSet(PoleznieObj_2.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_2.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_2 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_2.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Прерывания0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_2.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_2.MyObj;
			object obj20 = mass;
			array4 = new object[0];
			object[] array23 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj20, (Type)null, "MyForm", array23, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_2.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(19);
			PoleznieObj_3.MyObj = new Poleznie("_Система");
			NewLateBinding.LateSet(PoleznieObj_3.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_3.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_3 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_3.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Система0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_3.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_3.MyObj;
			object obj21 = mass;
			array4 = new object[0];
			object[] array24 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj21, (Type)null, "MyForm", array24, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_3.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_4.MyObj = new Poleznie("_Реестр");
			NewLateBinding.LateSet(PoleznieObj_4.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_4.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_4 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_4.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Реестр0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_4.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_4.MyObj;
			object obj22 = mass;
			array4 = new object[0];
			object[] array25 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj22, (Type)null, "MyForm", array25, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_4.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_4.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_4.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_5.MyObj = new Poleznie("_Вызвать событие");
			NewLateBinding.LateSet(PoleznieObj_5.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_5.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_5 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_5.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Вызвать_событие0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_5.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_5.MyObj;
			object obj23 = mass;
			array4 = new object[0];
			object[] array26 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj23, (Type)null, "MyForm", array26, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_5.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_5.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_5.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_6.MyObj = new Poleznie("_Текст");
			NewLateBinding.LateSet(PoleznieObj_6.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_6.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_6 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_6.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Текст0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_6.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_6.MyObj;
			object obj24 = mass;
			array4 = new object[0];
			object[] array27 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj24, (Type)null, "MyForm", array27, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_6.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_6.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_6.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_7.MyObj = new Poleznie("_Показать сообщение");
			NewLateBinding.LateSet(PoleznieObj_7.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_7.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_7 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_7.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Показать_сообщение0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_7.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_7.MyObj;
			object obj25 = mass;
			array4 = new object[0];
			object[] array28 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj25, (Type)null, "MyForm", array28, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_7.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_7.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_7.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(23);
			PoleznieObj_8.MyObj = new Poleznie("_Дата");
			NewLateBinding.LateSet(PoleznieObj_8.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_8.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_8 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_8.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Дата0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_8.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_8.MyObj;
			object obj26 = mass;
			array4 = new object[0];
			object[] array29 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj26, (Type)null, "MyForm", array29, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_8.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_8.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_8.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_9.MyObj = new Poleznie("_Расширенные возможности");
			NewLateBinding.LateSet(PoleznieObj_9.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_9.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_9 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_9.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Расширенные_возможности0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_9.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_9.MyObj;
			object obj27 = mass;
			array4 = new object[0];
			object[] array30 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj27, (Type)null, "MyForm", array30, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_9.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(25);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_0);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_1);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_0);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunT_0);
			peremens2.ProgressForm.ProgressBar1.set_Value(27);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_1);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_2);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_3);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_4);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_5);
			peremens2.ProgressForm.ProgressBar1.set_Value(29);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_6);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_7);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_8);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_9);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_10);
			peremens2.ProgressForm.ProgressBar1.set_Value(31);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_11);
			peremens2.ProgressForm.ProgressBar1.set_Value(32);
			peremens2.ProgressForm.ProgressBar1.set_Value(34);
			peremens2.ProgressForm.ProgressBar1.set_Value(35);
			((Control)RunLb_0).BringToFront();
			((Control)RunLb_1).BringToFront();
			((Control)RunB_0).BringToFront();
			((Control)RunT_0).BringToFront();
			((Control)RunB_1).BringToFront();
			((Control)RunB_2).BringToFront();
			((Control)RunB_3).BringToFront();
			((Control)RunB_4).BringToFront();
			((Control)RunB_5).BringToFront();
			((Control)RunB_6).BringToFront();
			((Control)RunB_7).BringToFront();
			((Control)RunB_8).BringToFront();
			((Control)RunB_9).BringToFront();
			((Control)RunB_10).BringToFront();
			((Control)RunB_11).BringToFront();
			peremens2.ProgressForm.ProgressBar1.set_Value(37);
			peremens2.ProgressForm.ProgressBar1.set_Value(39);
			peremens2.ProgressForm.ProgressBar1.set_Value(41);
			peremens2.ProgressForm.ProgressBar1.set_Value(42);
			peremens2.ProgressForm.ProgressBar1.set_Value(44);
			peremens2.ProgressForm.ProgressBar1.set_Value(45);
			RunF_0.Props.Text = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.X = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Y = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AssociateWithExtensions = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.MainForm = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.set_MainMenuStrip(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AutoRun = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ForbidClose = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ForbidMinimize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ForbidMaximize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Icon = peremens.perevesti("Рисунки\\Рисунок1.ico", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Name = peremens.perevesti("Окно1", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ControlBox = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ShowInTaskbar = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ShowInTray = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.TopMost = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ShowIcon = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Opacity = Conversions.ToInteger(peremens.perevesti("100", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.TransparentcyKey = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Scroll = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.AutoScrollMinSizeHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AutoScrollMinSizeWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AutoScrollPositionX = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AutoScrollPositionY = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.AllowRunCopies = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.StartPosition = peremens.perevesti("По центру экрана", SdelatEnterOrSpecsimvol: true);
			RunF_0.StatusTemp = "развернуто";
			RunF_0.Props.FormBorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.BackColor = peremens.perevesti("0; 151; 0;", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Height = Conversions.ToInteger(peremens.perevesti("471", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Width = Conversions.ToInteger(peremens.perevesti("1175", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Height = Conversions.ToInteger(peremens.perevesti("471", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Width = Conversions.ToInteger(peremens.perevesti("1175", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(47);
			RunLb_0.Props.Text = peremens.perevesti("Windows заблокирован!", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.X = Conversions.ToInteger(peremens.perevesti("132", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Y = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Name = peremens.perevesti("Надпись1", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.BackColor = peremens.perevesti("244; 244; 244;", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.ForeColor = peremens.perevesti("255; 66; 66;", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontFamily = peremens.perevesti("constantia", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontSize = Conversions.ToInteger(peremens.perevesti("50", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Height = Conversions.ToInteger(peremens.perevesti("87", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Width = Conversions.ToInteger(peremens.perevesti("803", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Height = Conversions.ToInteger(peremens.perevesti("87", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Width = Conversions.ToInteger(peremens.perevesti("803", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(49);
			RunLb_1.Props.Text = peremens.perevesti("Пока вы ведете пароль вы не сможете убрать данный блокиратор!", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.X = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Y = Conversions.ToInteger(peremens.perevesti("408", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Name = peremens.perevesti("Надпись2", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.BackColor = peremens.perevesti("0; 151; 0;", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontFamily = peremens.perevesti("century gothic", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontSize = Conversions.ToInteger(peremens.perevesti("25", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Height = Conversions.ToInteger(peremens.perevesti("43", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Width = Conversions.ToInteger(peremens.perevesti("1175", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Height = Conversions.ToInteger(peremens.perevesti("43", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Width = Conversions.ToInteger(peremens.perevesti("1175", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(51);
			RunB_0.Props.Text = peremens.perevesti("1", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.X = Conversions.ToInteger(peremens.perevesti("292", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Name = peremens.perevesti("Кнопка1", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(53);
			RunT_0.Props.Text = peremens.perevesti("Веди пароль!", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.X = Conversions.ToInteger(peremens.perevesti("172", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Y = Conversions.ToInteger(peremens.perevesti("304", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.SelectedText = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.SelectionLength = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Name = peremens.perevesti("Текст1", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.MaximumLength = Conversions.ToInteger(peremens.perevesti("32767", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.MultiLine = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.SelectionStart = peremens.perevesti("1", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.WordWrap = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.ScrollBars = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.AllowInput = peremens.perevesti("Все", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.TextPosition = peremens.perevesti("Слева", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.PasswordChar = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.HideSelection = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.BorderStyle = peremens.perevesti("объем", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.ReadOnly = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontFamily = peremens.perevesti("candara", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontSize = Conversions.ToInteger(peremens.perevesti("15", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Height = Conversions.ToInteger(peremens.perevesti("32", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Width = Conversions.ToInteger(peremens.perevesti("303", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Height = Conversions.ToInteger(peremens.perevesti("32", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Width = Conversions.ToInteger(peremens.perevesti("303", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(55);
			RunB_1.Props.Text = peremens.perevesti("2", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.X = Conversions.ToInteger(peremens.perevesti("320", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Name = peremens.perevesti("Кнопка2", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(57);
			RunB_2.Props.Text = peremens.perevesti("3", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.X = Conversions.ToInteger(peremens.perevesti("348", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Name = peremens.perevesti("Кнопка3", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Width = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Width = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(59);
			RunB_3.Props.Text = peremens.perevesti("4", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.X = Conversions.ToInteger(peremens.perevesti("372", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.Name = peremens.perevesti("Кнопка4", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(61);
			RunB_4.Props.Text = peremens.perevesti("5", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.X = Conversions.ToInteger(peremens.perevesti("396", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.Name = peremens.perevesti("Кнопка5", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_4.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_4.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(63);
			RunB_5.Props.Text = peremens.perevesti("6", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.X = Conversions.ToInteger(peremens.perevesti("420", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.Name = peremens.perevesti("Кнопка6", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_5.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_5.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(65);
			RunB_6.Props.Text = peremens.perevesti("7", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.X = Conversions.ToInteger(peremens.perevesti("448", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.Name = peremens.perevesti("Кнопка7", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.Width = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_6.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_6.Props.Width = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(67);
			RunB_7.Props.Text = peremens.perevesti("8", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.X = Conversions.ToInteger(peremens.perevesti("472", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.Name = peremens.perevesti("Кнопка8", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.Width = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_7.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_7.Props.Width = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(69);
			RunB_8.Props.Text = peremens.perevesti("9", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.X = Conversions.ToInteger(peremens.perevesti("496", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.Name = peremens.perevesti("Кнопка9", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_8.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_8.Props.Width = Conversions.ToInteger(peremens.perevesti("31", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(71);
			RunB_9.Props.Text = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.X = Conversions.ToInteger(peremens.perevesti("524", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.Y = Conversions.ToInteger(peremens.perevesti("336", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.Name = peremens.perevesti("Кнопка10", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.Width = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_9.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_9.Props.Width = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(74);
			RunB_10.Props.Text = peremens.perevesti("Очистить", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.X = Conversions.ToInteger(peremens.perevesti("292", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.Y = Conversions.ToInteger(peremens.perevesti("360", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.Name = peremens.perevesti("Кнопка11", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.FontFamily = peremens.perevesti("century gothic", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.Width = Conversions.ToInteger(peremens.perevesti("83", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_10.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_10.Props.Width = Conversions.ToInteger(peremens.perevesti("83", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(76);
			RunB_11.Props.Text = peremens.perevesti("РАЗБЛОКИРОВАТЬ! ЁПТА", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.X = Conversions.ToInteger(peremens.perevesti("472", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.Y = Conversions.ToInteger(peremens.perevesti("300", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.Name = peremens.perevesti("РАЗБЛОКИРОВАТЬ ВИНДУ", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.Height = Conversions.ToInteger(peremens.perevesti("39", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.Width = Conversions.ToInteger(peremens.perevesti("127", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_11.Props.Height = Conversions.ToInteger(peremens.perevesti("39", SdelatEnterOrSpecsimvol: true));
			RunB_11.Props.Width = Conversions.ToInteger(peremens.perevesti("127", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(78);
			RunF_1.Props.Name = "_Полезные объекты";
			peremens2.ProgressForm.ProgressBar1.set_Value(80);
			PoleznieObj_0.Props.Name = "_Экран";
			peremens2.ProgressForm.ProgressBar1.set_Value(82);
			PoleznieObj_1.Props.Name = "_Файлы и папки";
			peremens2.ProgressForm.ProgressBar1.set_Value(84);
			PoleznieObj_2.Props.Name = "_Прерывания";
			peremens2.ProgressForm.ProgressBar1.set_Value(86);
			PoleznieObj_3.Props.Name = "_Система";
			peremens2.ProgressForm.ProgressBar1.set_Value(88);
			PoleznieObj_4.Props.Name = "_Реестр";
			peremens2.ProgressForm.ProgressBar1.set_Value(90);
			PoleznieObj_5.Props.Name = "_Вызвать событие";
			peremens2.ProgressForm.ProgressBar1.set_Value(92);
			PoleznieObj_6.Props.Name = "_Текст";
			peremens2.ProgressForm.ProgressBar1.set_Value(94);
			PoleznieObj_7.Props.Name = "_Показать сообщение";
			peremens2.ProgressForm.ProgressBar1.set_Value(96);
			PoleznieObj_8.Props.Name = "_Дата";
			peremens2.ProgressForm.ProgressBar1.set_Value(98);
			PoleznieObj_9.Props.Name = "_Расширенные возможности";
			RunF_0.Load();
			RunLb_0.Load();
			RunLb_1.Load();
			RunB_0.Load();
			RunT_0.Load();
			RunB_1.Load();
			RunB_2.Load();
			RunB_3.Load();
			RunB_4.Load();
			RunB_5.Load();
			RunB_6.Load();
			RunB_7.Load();
			RunB_8.Load();
			RunB_9.Load();
			RunB_10.Load();
			RunB_11.Load();
			peremens.RunProj.GetAllObjects();
			peremens.RunProj.isINITIALIZATED = false;
			RunLb_0.RaiseCreate();
			RunLb_1.RaiseCreate();
			RunB_0.RaiseCreate();
			RunT_0.RaiseCreate();
			RunB_1.RaiseCreate();
			RunB_2.RaiseCreate();
			RunB_3.RaiseCreate();
			RunB_4.RaiseCreate();
			RunB_5.RaiseCreate();
			RunB_6.RaiseCreate();
			RunB_7.RaiseCreate();
			RunB_8.RaiseCreate();
			RunB_9.RaiseCreate();
			RunB_10.RaiseCreate();
			RunB_11.RaiseCreate();
			RunF_0.RaiseCreate();
			((Control)peremens2.ProgressForm).Hide();
		}
	}

	public static void smethod_0(object sender, EventArgs e)
	{
		if (peremens.DaOrNet(RunF_0.Props.MainForm))
		{
			NewLateBinding.LateSet(peremens2.proj, (Type)null, "isCLOSING", new object[1] { true }, (string[])null, (Type[])null);
			Application.Exit();
		}
	}

	public static void smethod_1(object sender, FormClosingEventArgs e)
	{
		if (peremens.DaOrNet(RunF_0.Props.ForbidClose))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(Strings.UCase(RunF_0.Props.MainForm), Strings.UCase(peremens.trans("Да")), false) == 0), NewLateBinding.LateGet(peremens2.proj, (Type)null, "isCLOSING", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			((Control)RunF_0).Hide();
			Application.Exit();
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = true;
			((Control)RunF_0).Hide();
		}
	}

	public static void smethod_2(object sender, KeyPressEventArgs e)
	{
		e.set_Handled(peremens.TextBoxAllow(RuntimeHelpers.GetObjectValue(sender), e));
	}

	public static void smethod_3(object sender, EventArgs e)
	{
		if (peremens.DaOrNet(RunF_1.Props.MainForm))
		{
			NewLateBinding.LateSet(peremens2.proj, (Type)null, "isCLOSING", new object[1] { true }, (string[])null, (Type[])null);
			Application.Exit();
		}
	}

	public static void smethod_4(object sender, FormClosingEventArgs e)
	{
		if (peremens.DaOrNet(RunF_1.Props.ForbidClose))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(Strings.UCase(RunF_1.Props.MainForm), Strings.UCase(peremens.trans("Да")), false) == 0), NewLateBinding.LateGet(peremens2.proj, (Type)null, "isCLOSING", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			((Control)RunF_1).Hide();
			Application.Exit();
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = true;
			((Control)RunF_1).Hide();
		}
	}

	public static void smethod_5(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_0.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_6(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_1.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_7(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_2.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)3) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_8(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_3.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)4) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_9(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_4.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_10(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_5.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)6) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_11(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_6.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)7) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_12(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_7.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)8) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_13(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_8.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)9) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_14(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_9.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_15(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_10.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_16(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_11.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "Попробуй ещо 100000 раз" }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}
}
