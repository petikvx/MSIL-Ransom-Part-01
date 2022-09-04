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

	[AccessedThroughProperty("Окно10Текст10")]
	private static runT runT_0;

	[AccessedThroughProperty("Окно10Кнопка10")]
	private static runB runB_0;

	[AccessedThroughProperty("Окно10Надпись10")]
	private static runLb runLb_0;

	[AccessedThroughProperty("Окно10Надпись30")]
	private static runLb runLb_1;

	[AccessedThroughProperty("Окно10Надпись40")]
	private static runLb runLb_2;

	[AccessedThroughProperty("Окно10Надпись150")]
	private static runLb runLb_3;

	[AccessedThroughProperty("Окно10Надпись160")]
	private static runLb runLb_4;

	[AccessedThroughProperty("Окно10Надпись170")]
	private static runLb runLb_5;

	[AccessedThroughProperty("Окно10Надпись190")]
	private static runLb runLb_6;

	[AccessedThroughProperty("Окно10Кнопка20")]
	private static runB runB_1;

	[AccessedThroughProperty("Окно10Кнопка30")]
	private static runB runB_2;

	[AccessedThroughProperty("Окно10Надпись50")]
	private static runLb runLb_7;

	[AccessedThroughProperty("Окно10Надпись60")]
	private static runLb runLb_8;

	[AccessedThroughProperty("Окно10Надпись70")]
	private static runLb runLb_9;

	[AccessedThroughProperty("Окно10Надпись20")]
	private static runLb runLb_10;

	[AccessedThroughProperty("Окно30Окно30")]
	private static runF runF_1;

	[AccessedThroughProperty("Окно30Надпись80")]
	private static runLb runLb_11;

	[AccessedThroughProperty("Окно30Надпись20")]
	private static runLb runLb_12;

	[AccessedThroughProperty("Окно30Надпись30")]
	private static runLb runLb_13;

	[AccessedThroughProperty("Окно30Надпись40")]
	private static runLb runLb_14;

	[AccessedThroughProperty("Окно30Надпись50")]
	private static runLb runLb_15;

	[AccessedThroughProperty("Окно30Надпись100")]
	private static runLb runLb_16;

	[AccessedThroughProperty("Окно30Надпись60")]
	private static runLb runLb_17;

	[AccessedThroughProperty("Окно30Надпись110")]
	private static runLb runLb_18;

	[AccessedThroughProperty("Окно30Надпись10")]
	private static runLb runLb_19;

	[AccessedThroughProperty("Окно20Окно20")]
	private static runF runF_2;

	[AccessedThroughProperty("Окно20Надпись10")]
	private static runLb runLb_20;

	[AccessedThroughProperty("_Полезные_объекты0_Полезные_объекты0")]
	private static runF runF_3;

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


	public static runT RunT_0
	{
		get
		{
			return runT_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			if (runT_0 != null)
			{
				((TextBoxBase)runT_0).remove_Click((EventHandler)smethod_9);
				((Control)runT_0).remove_KeyPress(new KeyPressEventHandler(smethod_2));
			}
			runT_0 = value;
			if (runT_0 != null)
			{
				((TextBoxBase)runT_0).add_Click((EventHandler)smethod_9);
				((Control)runT_0).add_KeyPress(new KeyPressEventHandler(smethod_2));
			}
		}
	} = new runT();


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
				((Control)runB_0).remove_MouseHover((EventHandler)smethod_11);
				((Control)runB_0).remove_Click((EventHandler)smethod_10);
			}
			runB_0 = value;
			if (runB_0 != null)
			{
				((Control)runB_0).add_MouseHover((EventHandler)smethod_11);
				((Control)runB_0).add_Click((EventHandler)smethod_10);
			}
		}
	} = new runB();


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


	public static runLb RunLb_2
	{
		get
		{
			return runLb_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_2 = value;
		}
	} = new runLb();


	public static runLb RunLb_3
	{
		get
		{
			return runLb_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_3 = value;
		}
	} = new runLb();


	public static runLb RunLb_4
	{
		get
		{
			return runLb_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_4 = value;
		}
	} = new runLb();


	public static runLb RunLb_5
	{
		get
		{
			return runLb_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_5 = value;
		}
	} = new runLb();


	public static runLb RunLb_6
	{
		get
		{
			return runLb_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_6 = value;
		}
	} = new runLb();


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
				((Control)runB_1).remove_MouseHover((EventHandler)smethod_13);
				((Control)runB_1).remove_Click((EventHandler)smethod_12);
			}
			runB_1 = value;
			if (runB_1 != null)
			{
				((Control)runB_1).add_MouseHover((EventHandler)smethod_13);
				((Control)runB_1).add_Click((EventHandler)smethod_12);
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
				((Control)runB_2).remove_MouseHover((EventHandler)smethod_15);
				((Control)runB_2).remove_Click((EventHandler)smethod_14);
			}
			runB_2 = value;
			if (runB_2 != null)
			{
				((Control)runB_2).add_MouseHover((EventHandler)smethod_15);
				((Control)runB_2).add_Click((EventHandler)smethod_14);
			}
		}
	} = new runB();


	public static runLb RunLb_7
	{
		get
		{
			return runLb_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_7 = value;
		}
	} = new runLb();


	public static runLb RunLb_8
	{
		get
		{
			return runLb_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_8 = value;
		}
	} = new runLb();


	public static runLb RunLb_9
	{
		get
		{
			return runLb_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_9 = value;
		}
	} = new runLb();


	public static runLb RunLb_10
	{
		get
		{
			return runLb_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_10 = value;
		}
	} = new runLb();


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


	public static runLb RunLb_11
	{
		get
		{
			return runLb_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_11 = value;
		}
	} = new runLb();


	public static runLb RunLb_12
	{
		get
		{
			return runLb_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_12 = value;
		}
	} = new runLb();


	public static runLb RunLb_13
	{
		get
		{
			return runLb_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_13 = value;
		}
	} = new runLb();


	public static runLb RunLb_14
	{
		get
		{
			return runLb_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_14 = value;
		}
	} = new runLb();


	public static runLb RunLb_15
	{
		get
		{
			return runLb_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_15 = value;
		}
	} = new runLb();


	public static runLb RunLb_16
	{
		get
		{
			return runLb_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_16 = value;
		}
	} = new runLb();


	public static runLb RunLb_17
	{
		get
		{
			return runLb_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_17 = value;
		}
	} = new runLb();


	public static runLb RunLb_18
	{
		get
		{
			return runLb_18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_18 = value;
		}
	} = new runLb();


	public static runLb RunLb_19
	{
		get
		{
			return runLb_19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_19 = value;
		}
	} = new runLb();


	public static runF RunF_2
	{
		get
		{
			return runF_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			if (runF_2 != null)
			{
				((Form)runF_2).remove_FormClosing(new FormClosingEventHandler(smethod_6));
				((Component)(object)runF_2).Disposed -= smethod_5;
			}
			runF_2 = value;
			if (runF_2 != null)
			{
				((Form)runF_2).add_FormClosing(new FormClosingEventHandler(smethod_6));
				((Component)(object)runF_2).Disposed += smethod_5;
			}
		}
	} = new runF();


	public static runLb RunLb_20
	{
		get
		{
			return runLb_20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runLb_20 = value;
		}
	} = new runLb();


	public static runF RunF_3
	{
		get
		{
			return runF_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			if (runF_3 != null)
			{
				((Form)runF_3).remove_FormClosing(new FormClosingEventHandler(smethod_8));
				((Component)(object)runF_3).Disposed -= smethod_7;
			}
			runF_3 = value;
			if (runF_3 != null)
			{
				((Form)runF_3).add_FormClosing(new FormClosingEventHandler(smethod_8));
				((Component)(object)runF_3).Disposed += smethod_7;
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
		peremens.RunProj.iPathShort = "Рисунки";
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
			RunT_0.MyObj = new TextBoks(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunT_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunT_0.MyObj, (Type)null, "obj", new object[1] { RunT_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunT_0.MyObj, (Type)null, "VBname", new object[1] { "Окно10Текст10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunT_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunT_0.MyObj;
			object obj2 = mass;
			object[] array4 = new object[0];
			object[] array5 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "MyForm", array5, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunT_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunT_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunT_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_0.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_0.MyObj, (Type)null, "obj", new object[1] { RunB_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_0.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_0.MyObj;
			object obj3 = mass;
			array4 = new object[0];
			object[] array6 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "MyForm", array6, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_0.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_0.MyObj, (Type)null, "obj", new object[1] { RunLb_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_0.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_0.MyObj;
			object obj4 = mass;
			array4 = new object[0];
			object[] array7 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "MyForm", array7, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSet(RunLb_1.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись30" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_1.MyObj;
			object obj5 = mass;
			array4 = new object[0];
			object[] array8 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "MyForm", array8, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_1.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(3);
			RunLb_2.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_2.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_2.MyObj, (Type)null, "obj", new object[1] { RunLb_2 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_2.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись40" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_2.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_2.MyObj;
			object obj6 = mass;
			array4 = new object[0];
			object[] array9 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "MyForm", array9, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_2.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_3.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_3.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_3.MyObj, (Type)null, "obj", new object[1] { RunLb_3 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_3.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись150" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_3.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_3.MyObj;
			object obj7 = mass;
			array4 = new object[0];
			object[] array10 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "MyForm", array10, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_3.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_4.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_4.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_4.MyObj, (Type)null, "obj", new object[1] { RunLb_4 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_4.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись160" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_4.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_4.MyObj;
			object obj8 = mass;
			array4 = new object[0];
			object[] array11 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "MyForm", array11, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_4.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_4.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_4.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_5.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_5.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_5.MyObj, (Type)null, "obj", new object[1] { RunLb_5 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_5.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись170" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_5.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_5.MyObj;
			object obj9 = mass;
			array4 = new object[0];
			object[] array12 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "MyForm", array12, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_5.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_5.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_5.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_6.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_6.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_6.MyObj, (Type)null, "obj", new object[1] { RunLb_6 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_6.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись190" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_6.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_6.MyObj;
			object obj10 = mass;
			array4 = new object[0];
			object[] array13 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj10, (Type)null, "MyForm", array13, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_6.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_6.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_6.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(6);
			RunB_1.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_1.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_1.MyObj, (Type)null, "obj", new object[1] { RunB_1 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_1.MyObj, (Type)null, "VBname", new object[1] { "Окно10Кнопка20" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_1.MyObj;
			object obj11 = mass;
			array4 = new object[0];
			object[] array14 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj11, (Type)null, "MyForm", array14, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			object obj12 = mass;
			array4 = new object[0];
			object[] array15 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj12, (Type)null, "MyForm", array15, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_2.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_7.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_7.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_7.MyObj, (Type)null, "obj", new object[1] { RunLb_7 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_7.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись50" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_7.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_7.MyObj;
			object obj13 = mass;
			array4 = new object[0];
			object[] array16 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj13, (Type)null, "MyForm", array16, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_7.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_7.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_7.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_8.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_8.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_8.MyObj, (Type)null, "obj", new object[1] { RunLb_8 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_8.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись60" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_8.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_8.MyObj;
			object obj14 = mass;
			array4 = new object[0];
			object[] array17 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj14, (Type)null, "MyForm", array17, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_8.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_8.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_8.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_9.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_9.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_9.MyObj, (Type)null, "obj", new object[1] { RunLb_9 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_9.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись70" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_9.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_9.MyObj;
			object obj15 = mass;
			array4 = new object[0];
			object[] array18 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj15, (Type)null, "MyForm", array18, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_9.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(10);
			RunLb_10.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_10.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_10.MyObj, (Type)null, "obj", new object[1] { RunLb_10 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_10.MyObj, (Type)null, "VBname", new object[1] { "Окно10Надпись20" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_10.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_10.MyObj;
			object obj16 = mass;
			array4 = new object[0];
			object[] array19 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj16, (Type)null, "MyForm", array19, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_10.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_10.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_10.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunF_1.MyObj = new Forms(holostoi: true, polezniy: false, isRun: true);
			NewLateBinding.LateSet(RunF_1.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_1.MyObj, (Type)null, "obj", new object[1] { RunF_1 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_1.MyObj, (Type)null, "VBname", new object[1] { "Окно30Окно30" }, (string[])null, (Type[])null);
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
			RunLb_11.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_11.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_11.MyObj, (Type)null, "obj", new object[1] { RunLb_11 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_11.MyObj, (Type)null, "VBname", new object[1] { "Окно30Надпись80" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_11.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_11.MyObj;
			object obj18 = mass;
			array4 = new object[0];
			object[] array21 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj18, (Type)null, "MyForm", array21, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_11.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_11.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_11.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_12.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_12.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_12.MyObj, (Type)null, "obj", new object[1] { RunLb_12 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_12.MyObj, (Type)null, "VBname", new object[1] { "Окно30Надпись20" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_12.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_12.MyObj;
			object obj19 = mass;
			array4 = new object[0];
			object[] array22 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj19, (Type)null, "MyForm", array22, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_12.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_12.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_12.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_13.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_13.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_13.MyObj, (Type)null, "obj", new object[1] { RunLb_13 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_13.MyObj, (Type)null, "VBname", new object[1] { "Окно30Надпись30" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_13.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_13.MyObj;
			object obj20 = mass;
			array4 = new object[0];
			object[] array23 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj20, (Type)null, "MyForm", array23, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_13.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_13.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_13.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(13);
			RunLb_14.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_14.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_14.MyObj, (Type)null, "obj", new object[1] { RunLb_14 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_14.MyObj, (Type)null, "VBname", new object[1] { "Окно30Надпись40" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_14.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_14.MyObj;
			object obj21 = mass;
			array4 = new object[0];
			object[] array24 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj21, (Type)null, "MyForm", array24, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_14.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_14.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_14.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_15.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_15.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_15.MyObj, (Type)null, "obj", new object[1] { RunLb_15 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_15.MyObj, (Type)null, "VBname", new object[1] { "Окно30Надпись50" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_15.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_15.MyObj;
			object obj22 = mass;
			array4 = new object[0];
			object[] array25 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj22, (Type)null, "MyForm", array25, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_15.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_15.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_15.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_16.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_16.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_16.MyObj, (Type)null, "obj", new object[1] { RunLb_16 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_16.MyObj, (Type)null, "VBname", new object[1] { "Окно30Надпись100" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_16.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_16.MyObj;
			object obj23 = mass;
			array4 = new object[0];
			object[] array26 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj23, (Type)null, "MyForm", array26, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_16.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_16.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_16.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_17.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_17.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_17.MyObj, (Type)null, "obj", new object[1] { RunLb_17 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_17.MyObj, (Type)null, "VBname", new object[1] { "Окно30Надпись60" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_17.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_17.MyObj;
			object obj24 = mass;
			array4 = new object[0];
			object[] array27 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj24, (Type)null, "MyForm", array27, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_17.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_17.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_17.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_18.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_18.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_18.MyObj, (Type)null, "obj", new object[1] { RunLb_18 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_18.MyObj, (Type)null, "VBname", new object[1] { "Окно30Надпись110" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_18.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_18.MyObj;
			object obj25 = mass;
			array4 = new object[0];
			object[] array28 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj25, (Type)null, "MyForm", array28, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_18.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_18.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_18.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(16);
			RunLb_19.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_19.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_19.MyObj, (Type)null, "obj", new object[1] { RunLb_19 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_19.MyObj, (Type)null, "VBname", new object[1] { "Окно30Надпись10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_19.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_1.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_19.MyObj;
			object obj26 = mass;
			array4 = new object[0];
			object[] array29 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj26, (Type)null, "MyForm", array29, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_19.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_19.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_19.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunF_2.MyObj = new Forms(holostoi: true, polezniy: false, isRun: true);
			NewLateBinding.LateSet(RunF_2.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_2.MyObj, (Type)null, "obj", new object[1] { RunF_2 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_2.MyObj, (Type)null, "VBname", new object[1] { "Окно20Окно20" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_2.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_2.MyObj) }, (string[])null, (Type[])null, false, true);
			peremens.ReDims(ref peremens.RunProj.f);
			peremens.RunProj.f[peremens.RunProj.f.Length - 1] = (Forms)RunF_2.MyObj;
			mass = RunF_2.MyObj;
			object obj27 = mass;
			array4 = new object[0];
			object[] array30 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj27, (Type)null, "MyForm", array30, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunF_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunF_2.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_20.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_20.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_20.MyObj, (Type)null, "obj", new object[1] { RunLb_20 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_20.MyObj, (Type)null, "VBname", new object[1] { "Окно20Надпись10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_20.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_2.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_20.MyObj;
			object obj28 = mass;
			array4 = new object[0];
			object[] array31 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj28, (Type)null, "MyForm", array31, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_20.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_20.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_20.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunF_3.MyObj = new Forms(holostoi: true, polezniy: false, isRun: true);
			NewLateBinding.LateSet(RunF_3.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_3.MyObj, (Type)null, "obj", new object[1] { RunF_3 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_3.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Полезные_объекты0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_3.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			peremens.ReDims(ref peremens.RunProj.f);
			peremens.RunProj.f[peremens.RunProj.f.Length - 1] = (Forms)RunF_3.MyObj;
			mass = RunF_3.MyObj;
			object obj29 = mass;
			array4 = new object[0];
			object[] array32 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj29, (Type)null, "MyForm", array32, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunF_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunF_3.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_0.MyObj = new Poleznie("_Экран");
			NewLateBinding.LateSet(PoleznieObj_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_0.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_0.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Экран0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_0.MyObj;
			object obj30 = mass;
			array4 = new object[0];
			object[] array33 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj30, (Type)null, "MyForm", array33, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(19);
			PoleznieObj_1.MyObj = new Poleznie("_Файлы и папки");
			NewLateBinding.LateSet(PoleznieObj_1.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_1.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_1 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_1.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Файлы_и_папки0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_1.MyObj;
			object obj31 = mass;
			array4 = new object[0];
			object[] array34 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj31, (Type)null, "MyForm", array34, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_2.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_2.MyObj;
			object obj32 = mass;
			array4 = new object[0];
			object[] array35 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj32, (Type)null, "MyForm", array35, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_2.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_3.MyObj = new Poleznie("_Система");
			NewLateBinding.LateSet(PoleznieObj_3.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_3.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_3 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_3.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Система0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_3.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_3.MyObj;
			object obj33 = mass;
			array4 = new object[0];
			object[] array36 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj33, (Type)null, "MyForm", array36, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_4.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_4.MyObj;
			object obj34 = mass;
			array4 = new object[0];
			object[] array37 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj34, (Type)null, "MyForm", array37, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_5.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_5.MyObj;
			object obj35 = mass;
			array4 = new object[0];
			object[] array38 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj35, (Type)null, "MyForm", array38, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_5.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_5.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_5.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(22);
			PoleznieObj_6.MyObj = new Poleznie("_Текст");
			NewLateBinding.LateSet(PoleznieObj_6.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_6.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_6 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_6.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Текст0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_6.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_6.MyObj;
			object obj36 = mass;
			array4 = new object[0];
			object[] array39 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj36, (Type)null, "MyForm", array39, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_7.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_7.MyObj;
			object obj37 = mass;
			array4 = new object[0];
			object[] array40 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj37, (Type)null, "MyForm", array40, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_7.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_7.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_7.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_8.MyObj = new Poleznie("_Дата");
			NewLateBinding.LateSet(PoleznieObj_8.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_8.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_8 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_8.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Дата0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_8.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_8.MyObj;
			object obj38 = mass;
			array4 = new object[0];
			object[] array41 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj38, (Type)null, "MyForm", array41, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_9.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_3.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_9.MyObj;
			object obj39 = mass;
			array4 = new object[0];
			object[] array42 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj39, (Type)null, "MyForm", array42, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_9.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(25);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunT_0);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_0);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_0);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_1);
			peremens2.ProgressForm.ProgressBar1.set_Value(26);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_2);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_3);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_4);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_5);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_6);
			peremens2.ProgressForm.ProgressBar1.set_Value(28);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_1);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunB_2);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_7);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_8);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_9);
			peremens2.ProgressForm.ProgressBar1.set_Value(29);
			((Control)RunF_0).get_Controls().Add((Control)(object)RunLb_10);
			((Control)RunF_1).get_Controls().Add((Control)(object)RunLb_11);
			((Control)RunF_1).get_Controls().Add((Control)(object)RunLb_12);
			((Control)RunF_1).get_Controls().Add((Control)(object)RunLb_13);
			peremens2.ProgressForm.ProgressBar1.set_Value(30);
			((Control)RunF_1).get_Controls().Add((Control)(object)RunLb_14);
			((Control)RunF_1).get_Controls().Add((Control)(object)RunLb_15);
			((Control)RunF_1).get_Controls().Add((Control)(object)RunLb_16);
			((Control)RunF_1).get_Controls().Add((Control)(object)RunLb_17);
			((Control)RunF_1).get_Controls().Add((Control)(object)RunLb_18);
			peremens2.ProgressForm.ProgressBar1.set_Value(31);
			((Control)RunF_1).get_Controls().Add((Control)(object)RunLb_19);
			((Control)RunF_2).get_Controls().Add((Control)(object)RunLb_20);
			peremens2.ProgressForm.ProgressBar1.set_Value(33);
			peremens2.ProgressForm.ProgressBar1.set_Value(34);
			peremens2.ProgressForm.ProgressBar1.set_Value(35);
			((Control)RunT_0).BringToFront();
			((Control)RunB_0).BringToFront();
			((Control)RunLb_0).BringToFront();
			((Control)RunLb_1).BringToFront();
			((Control)RunLb_2).BringToFront();
			((Control)RunLb_3).BringToFront();
			((Control)RunLb_4).BringToFront();
			((Control)RunLb_5).BringToFront();
			((Control)RunLb_6).BringToFront();
			((Control)RunB_1).BringToFront();
			((Control)RunB_2).BringToFront();
			((Control)RunLb_7).BringToFront();
			((Control)RunLb_8).BringToFront();
			((Control)RunLb_9).BringToFront();
			((Control)RunLb_10).BringToFront();
			peremens2.ProgressForm.ProgressBar1.set_Value(36);
			peremens2.ProgressForm.ProgressBar1.set_Value(38);
			peremens2.ProgressForm.ProgressBar1.set_Value(39);
			((Control)RunLb_11).BringToFront();
			((Control)RunLb_12).BringToFront();
			((Control)RunLb_13).BringToFront();
			((Control)RunLb_14).BringToFront();
			((Control)RunLb_15).BringToFront();
			((Control)RunLb_16).BringToFront();
			((Control)RunLb_17).BringToFront();
			((Control)RunLb_18).BringToFront();
			((Control)RunLb_19).BringToFront();
			peremens2.ProgressForm.ProgressBar1.set_Value(40);
			peremens2.ProgressForm.ProgressBar1.set_Value(41);
			((Control)RunLb_20).BringToFront();
			peremens2.ProgressForm.ProgressBar1.set_Value(43);
			peremens2.ProgressForm.ProgressBar1.set_Value(44);
			peremens2.ProgressForm.ProgressBar1.set_Value(45);
			RunF_0.Props.X = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Y = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AssociateWithExtensions = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.MainForm = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.set_MainMenuStrip(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AutoRun = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ForbidClose = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ForbidMinimize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ForbidMaximize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Icon = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Name = peremens.perevesti("Окно1", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ControlBox = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ShowInTaskbar = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ShowInTray = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.TopMost = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ShowIcon = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Opacity = Conversions.ToInteger(peremens.perevesti("98", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.TransparentcyKey = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Scroll = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.AutoScrollMinSizeHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AutoScrollMinSizeWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AutoScrollPositionX = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.AutoScrollPositionY = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.AllowRunCopies = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.StartPosition = peremens.perevesti("по центру экрана", SdelatEnterOrSpecsimvol: true);
			RunF_0.StatusTemp = "развернуто";
			RunF_0.Props.FormBorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Text = peremens.perevesti("Окно1", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Height = Conversions.ToInteger(peremens.perevesti("403", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Width = Conversions.ToInteger(peremens.perevesti("755", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_0.Props.Height = Conversions.ToInteger(peremens.perevesti("403", SdelatEnterOrSpecsimvol: true));
			RunF_0.Props.Width = Conversions.ToInteger(peremens.perevesti("755", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(46);
			RunT_0.Props.X = Conversions.ToInteger(peremens.perevesti("236", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Y = Conversions.ToInteger(peremens.perevesti("356", SdelatEnterOrSpecsimvol: true));
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
			RunT_0.Props.TextPosition = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.PasswordChar = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.HideSelection = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.BorderStyle = peremens.perevesti("объем", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Text = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.ReadOnly = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontItalic = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Height = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Width = Conversions.ToInteger(peremens.perevesti("211", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Height = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Width = Conversions.ToInteger(peremens.perevesti("211", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(48);
			RunB_0.Props.X = Conversions.ToInteger(peremens.perevesti("460", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Y = Conversions.ToInteger(peremens.perevesti("356", SdelatEnterOrSpecsimvol: true));
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
			RunB_0.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Text = peremens.perevesti("Ок", SdelatEnterOrSpecsimvol: true);
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
			RunB_0.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(49);
			RunLb_0.Props.X = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Y = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
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
			RunLb_0.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Text = peremens.perevesti("Вы установили поддельное програмное обеспечение", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.ForeColor = peremens.perevesti("Красный", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontFamily = peremens.perevesti("arial", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontSize = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Height = Conversions.ToInteger(peremens.perevesti("33", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Width = Conversions.ToInteger(peremens.perevesti("761", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Height = Conversions.ToInteger(peremens.perevesti("33", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Width = Conversions.ToInteger(peremens.perevesti("761", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(51);
			RunLb_1.Props.X = Conversions.ToInteger(peremens.perevesti("156", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Y = Conversions.ToInteger(peremens.perevesti("88", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Name = peremens.perevesti("Надпись3", SdelatEnterOrSpecsimvol: true);
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
			RunLb_1.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Text = peremens.perevesti("Пожалуйста следуйте данной инструкции:", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Height = Conversions.ToInteger(peremens.perevesti("25", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Width = Conversions.ToInteger(peremens.perevesti("353", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_1.Props.Height = Conversions.ToInteger(peremens.perevesti("25", SdelatEnterOrSpecsimvol: true));
			RunLb_1.Props.Width = Conversions.ToInteger(peremens.perevesti("353", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(52);
			RunLb_2.Props.X = Conversions.ToInteger(peremens.perevesti("32", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.Y = Conversions.ToInteger(peremens.perevesti("116", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.Name = peremens.perevesti("Надпись4", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.TextAlign = peremens.perevesti("верх слева", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.Text = peremens.perevesti("Не пытайтесь разобратся с банером сами, вы нанесете вред своему компьютеру. Когда вы оплатите, отправте сообщение либо на моб. тел. либо на электронную почту. Вы В ЛЮБОМ СЛУЧАЕ получите пароль!!.", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.ForeColor = peremens.perevesti("Красный", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.Height = Conversions.ToInteger(peremens.perevesti("47", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.Width = Conversions.ToInteger(peremens.perevesti("663", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_2.Props.Height = Conversions.ToInteger(peremens.perevesti("47", SdelatEnterOrSpecsimvol: true));
			RunLb_2.Props.Width = Conversions.ToInteger(peremens.perevesti("663", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(53);
			RunLb_3.Props.X = Conversions.ToInteger(peremens.perevesti("32", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.Y = Conversions.ToInteger(peremens.perevesti("212", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.Name = peremens.perevesti("Надпись15", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.TextAlign = peremens.perevesti("верх слева", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.Text = peremens.perevesti("После разблокировки вы получите в подарок антивирус Касперского на 1 год Для защиты вашего компьютера.", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.ForeColor = peremens.perevesti("Красный", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.FontSize = Conversions.ToInteger(peremens.perevesti("9", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.Height = Conversions.ToInteger(peremens.perevesti("47", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.Width = Conversions.ToInteger(peremens.perevesti("615", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_3.Props.Height = Conversions.ToInteger(peremens.perevesti("47", SdelatEnterOrSpecsimvol: true));
			RunLb_3.Props.Width = Conversions.ToInteger(peremens.perevesti("615", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(55);
			RunLb_4.Props.X = Conversions.ToInteger(peremens.perevesti("380", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.Y = Conversions.ToInteger(peremens.perevesti("240", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.Name = peremens.perevesti("Надпись16", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.Text = peremens.perevesti("ya-snimu-ego@yandex.ru смс на 89261072166", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.ForeColor = peremens.perevesti("Красный", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.FontSize = Conversions.ToInteger(peremens.perevesti("12", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.Height = Conversions.ToInteger(peremens.perevesti("63", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.Width = Conversions.ToInteger(peremens.perevesti("239", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_4.Props.Height = Conversions.ToInteger(peremens.perevesti("63", SdelatEnterOrSpecsimvol: true));
			RunLb_4.Props.Width = Conversions.ToInteger(peremens.perevesti("239", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(56);
			RunLb_5.Props.X = Conversions.ToInteger(peremens.perevesti("36", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.Y = Conversions.ToInteger(peremens.perevesti("264", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.Name = peremens.perevesti("Надпись17", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.TextAlign = peremens.perevesti("верх слева", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.Text = peremens.perevesti("Если вы оплатили, и не получили код, обращайтесь :", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.Height = Conversions.ToInteger(peremens.perevesti("19", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.Width = Conversions.ToInteger(peremens.perevesti("331", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_5.Props.Height = Conversions.ToInteger(peremens.perevesti("19", SdelatEnterOrSpecsimvol: true));
			RunLb_5.Props.Width = Conversions.ToInteger(peremens.perevesti("331", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(58);
			RunLb_6.Props.X = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.Y = Conversions.ToInteger(peremens.perevesti("60", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.Name = peremens.perevesti("Надпись19", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.Text = peremens.perevesti("Вы согласились с установкой этого банера, в пункте 5.2 это было указано.", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.ForeColor = peremens.perevesti("Красный", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.FontItalic = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.Height = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.Width = Conversions.ToInteger(peremens.perevesti("643", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_6.Props.Height = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunLb_6.Props.Width = Conversions.ToInteger(peremens.perevesti("643", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(59);
			RunB_1.Props.X = Conversions.ToInteger(peremens.perevesti("616", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Y = Conversions.ToInteger(peremens.perevesti("60", SdelatEnterOrSpecsimvol: true));
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
			RunB_1.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Text = peremens.perevesti("Пункт 5.2", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.ForeColor = peremens.perevesti("Красный", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.FontSize = Conversions.ToInteger(peremens.perevesti("12", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Height = Conversions.ToInteger(peremens.perevesti("47", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Width = Conversions.ToInteger(peremens.perevesti("107", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Height = Conversions.ToInteger(peremens.perevesti("47", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Width = Conversions.ToInteger(peremens.perevesti("107", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(61);
			RunB_2.Props.X = Conversions.ToInteger(peremens.perevesti("32", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Y = Conversions.ToInteger(peremens.perevesti("160", SdelatEnterOrSpecsimvol: true));
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
			RunB_2.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Text = peremens.perevesti("Оплатить электронным платежом", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Height = Conversions.ToInteger(peremens.perevesti("43", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Width = Conversions.ToInteger(peremens.perevesti("691", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Height = Conversions.ToInteger(peremens.perevesti("43", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Width = Conversions.ToInteger(peremens.perevesti("691", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(62);
			RunLb_7.Props.X = Conversions.ToInteger(peremens.perevesti("368", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.Y = Conversions.ToInteger(peremens.perevesti("296", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.Name = peremens.perevesti("Надпись5", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.TextAlign = peremens.perevesti("верх слева", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.Text = peremens.perevesti("На звонки мы не отвечаем. Только смс!", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.Height = Conversions.ToInteger(peremens.perevesti("19", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.Width = Conversions.ToInteger(peremens.perevesti("331", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_7.Props.Height = Conversions.ToInteger(peremens.perevesti("19", SdelatEnterOrSpecsimvol: true));
			RunLb_7.Props.Width = Conversions.ToInteger(peremens.perevesti("331", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(63);
			RunLb_8.Props.X = Conversions.ToInteger(peremens.perevesti("120", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.Y = Conversions.ToInteger(peremens.perevesti("360", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.Name = peremens.perevesti("Надпись6", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.TextAlign = peremens.perevesti("верх слева", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.Text = peremens.perevesti("Введите пароль", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.Height = Conversions.ToInteger(peremens.perevesti("19", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.Width = Conversions.ToInteger(peremens.perevesti("107", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_8.Props.Height = Conversions.ToInteger(peremens.perevesti("19", SdelatEnterOrSpecsimvol: true));
			RunLb_8.Props.Width = Conversions.ToInteger(peremens.perevesti("107", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(65);
			RunLb_9.Props.X = Conversions.ToInteger(peremens.perevesti("644", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.Y = Conversions.ToInteger(peremens.perevesti("380", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.Name = peremens.perevesti("Надпись7", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.Text = peremens.perevesti("Версия 5.0", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.Height = Conversions.ToInteger(peremens.perevesti("15", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_9.Props.Height = Conversions.ToInteger(peremens.perevesti("15", SdelatEnterOrSpecsimvol: true));
			RunLb_9.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(66);
			RunLb_10.Props.X = Conversions.ToInteger(peremens.perevesti("96", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.Y = Conversions.ToInteger(peremens.perevesti("312", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.Name = peremens.perevesti("Надпись2", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.TextAlign = peremens.perevesti("верх слева", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.Text = peremens.perevesti("Ненадо писать об угразах и законе, сдесь все законно, вы сами согласились с условием лицензионного соглашения, с условием установки. Вас некто не заствлял нажать кнопку \"я согласен\". ", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.Height = Conversions.ToInteger(peremens.perevesti("39", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.Width = Conversions.ToInteger(peremens.perevesti("635", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_10.Props.Height = Conversions.ToInteger(peremens.perevesti("39", SdelatEnterOrSpecsimvol: true));
			RunLb_10.Props.Width = Conversions.ToInteger(peremens.perevesti("635", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(68);
			RunF_1.Props.X = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.Y = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.AssociateWithExtensions = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.MainForm = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.set_MainMenuStrip(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.AutoRun = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.ForbidClose = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.ForbidMinimize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.ForbidMaximize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.Icon = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.Name = peremens.perevesti("Окно3", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.ControlBox = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.ShowInTaskbar = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.ShowInTray = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.TopMost = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.ShowIcon = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.Opacity = Conversions.ToInteger(peremens.perevesti("100", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.TransparentcyKey = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.Scroll = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.AutoScrollMinSizeHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.AutoScrollMinSizeWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.AutoScrollPositionX = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.AutoScrollPositionY = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.AllowRunCopies = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.StartPosition = peremens.perevesti("по центру экрана", SdelatEnterOrSpecsimvol: true);
			RunF_1.StatusTemp = "нормальный";
			RunF_1.Props.FormBorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.Text = peremens.perevesti("Окно3", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.BackColor = peremens.perevesti("Серебряный", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.Height = Conversions.ToInteger(peremens.perevesti("283", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.Width = Conversions.ToInteger(peremens.perevesti("599", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_1.Props.Height = Conversions.ToInteger(peremens.perevesti("283", SdelatEnterOrSpecsimvol: true));
			RunF_1.Props.Width = Conversions.ToInteger(peremens.perevesti("599", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(69);
			RunLb_11.Props.X = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.Y = Conversions.ToInteger(peremens.perevesti("148", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.Name = peremens.perevesti("Надпись8", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.Text = peremens.perevesti("Мы даем 100% гарантию того, что после оплаты вы получите код, и это окно исчезнет, и компьютер будет работать в прежнем режиме!!!", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.BackColor = peremens.perevesti("Серебряный", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.ForeColor = peremens.perevesti("Красный", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.FontSize = Conversions.ToInteger(peremens.perevesti("12", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.Height = Conversions.ToInteger(peremens.perevesti("115", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.Width = Conversions.ToInteger(peremens.perevesti("563", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_11.Props.Height = Conversions.ToInteger(peremens.perevesti("115", SdelatEnterOrSpecsimvol: true));
			RunLb_11.Props.Width = Conversions.ToInteger(peremens.perevesti("563", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(70);
			RunLb_12.Props.X = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.Y = Conversions.ToInteger(peremens.perevesti("28", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.Name = peremens.perevesti("Надпись2", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.Text = peremens.perevesti("В терминале выберите пункт о Электронных платежах и ищите там услугу либо \"WebMoney\" или \"Яндекс Деньги\".Либо в банке заполните реквизиты в кивитанции.", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.BackColor = peremens.perevesti("Серебряный", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.Height = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.Width = Conversions.ToInteger(peremens.perevesti("567", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_12.Props.Height = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunLb_12.Props.Width = Conversions.ToInteger(peremens.perevesti("567", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(72);
			RunLb_13.Props.X = Conversions.ToInteger(peremens.perevesti("32", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.Y = Conversions.ToInteger(peremens.perevesti("72", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.Name = peremens.perevesti("Надпись3", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.Text = peremens.perevesti("WebMoney:", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.BackColor = peremens.perevesti("Серебряный", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.ForeColor = peremens.perevesti("Синий", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.Width = Conversions.ToInteger(peremens.perevesti("107", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_13.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_13.Props.Width = Conversions.ToInteger(peremens.perevesti("107", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(73);
			RunLb_14.Props.X = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.Y = Conversions.ToInteger(peremens.perevesti("96", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.Name = peremens.perevesti("Надпись4", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.Text = peremens.perevesti("Яндекс Деньги:", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.BackColor = peremens.perevesti("Серебряный", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.ForeColor = peremens.perevesti("Красный", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.Width = Conversions.ToInteger(peremens.perevesti("135", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_14.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_14.Props.Width = Conversions.ToInteger(peremens.perevesti("135", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(75);
			RunLb_15.Props.X = Conversions.ToInteger(peremens.perevesti("128", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.Y = Conversions.ToInteger(peremens.perevesti("72", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.Name = peremens.perevesti("Надпись5", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.Text = peremens.perevesti("R131494847149", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.BackColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.ForeColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.Width = Conversions.ToInteger(peremens.perevesti("139", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_15.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_15.Props.Width = Conversions.ToInteger(peremens.perevesti("139", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(76);
			RunLb_16.Props.X = Conversions.ToInteger(peremens.perevesti("128", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.Y = Conversions.ToInteger(peremens.perevesti("96", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.Name = peremens.perevesti("Надпись10", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.Text = peremens.perevesti("41001770967278", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.BackColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.ForeColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.Width = Conversions.ToInteger(peremens.perevesti("139", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_16.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_16.Props.Width = Conversions.ToInteger(peremens.perevesti("139", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(77);
			RunLb_17.Props.X = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.Y = Conversions.ToInteger(peremens.perevesti("120", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.Name = peremens.perevesti("Надпись6", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.Text = peremens.perevesti("Сумма перевода:", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.BackColor = peremens.perevesti("Серебряный", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.ForeColor = peremens.perevesti("Красный", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.FontSize = Conversions.ToInteger(peremens.perevesti("9", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.Width = Conversions.ToInteger(peremens.perevesti("131", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_17.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_17.Props.Width = Conversions.ToInteger(peremens.perevesti("131", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(79);
			RunLb_18.Props.X = Conversions.ToInteger(peremens.perevesti("128", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.Y = Conversions.ToInteger(peremens.perevesti("120", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.Name = peremens.perevesti("Надпись11", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.Text = peremens.perevesti("900 рублей", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.BackColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.ForeColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.Width = Conversions.ToInteger(peremens.perevesti("139", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_18.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunLb_18.Props.Width = Conversions.ToInteger(peremens.perevesti("139", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(80);
			RunLb_19.Props.X = Conversions.ToInteger(peremens.perevesti("296", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.Y = Conversions.ToInteger(peremens.perevesti("56", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.Name = peremens.perevesti("Надпись1", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.Text = peremens.perevesti("Пожалуйста после оплаты, пришите смс на номер телефона +79261072166. В нем укажите сумму которую вы положили и  которая должа быть зачислена на счет. Вы СРАЗУ ЖЕ в ответ получите код разблокировки!.", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.BackColor = peremens.perevesti("Серебряный", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.Height = Conversions.ToInteger(peremens.perevesti("87", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.Width = Conversions.ToInteger(peremens.perevesti("279", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_19.Props.Height = Conversions.ToInteger(peremens.perevesti("87", SdelatEnterOrSpecsimvol: true));
			RunLb_19.Props.Width = Conversions.ToInteger(peremens.perevesti("279", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(82);
			RunF_2.Props.X = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.Y = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.AssociateWithExtensions = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.MainForm = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.set_MainMenuStrip(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.AutoRun = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.ForbidClose = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.ForbidMinimize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.ForbidMaximize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.Icon = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.Name = peremens.perevesti("Окно2", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.ControlBox = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.ShowInTaskbar = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.ShowInTray = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.TopMost = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.ShowIcon = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.Opacity = Conversions.ToInteger(peremens.perevesti("100", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.TransparentcyKey = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.Scroll = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.AutoScrollMinSizeHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.AutoScrollMinSizeWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.AutoScrollPositionX = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.AutoScrollPositionY = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.AllowRunCopies = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.StartPosition = peremens.perevesti("по центру экрана", SdelatEnterOrSpecsimvol: true);
			RunF_2.StatusTemp = "нормальный";
			RunF_2.Props.FormBorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.BackgroundImageLayout = peremens.perevesti("по центру", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.Text = peremens.perevesti("Окно2", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.BackColor = peremens.perevesti("Серебряный", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.Height = Conversions.ToInteger(peremens.perevesti("283", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.Width = Conversions.ToInteger(peremens.perevesti("507", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunF_2.Props.Height = Conversions.ToInteger(peremens.perevesti("283", SdelatEnterOrSpecsimvol: true));
			RunF_2.Props.Width = Conversions.ToInteger(peremens.perevesti("507", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(83);
			RunLb_20.Props.X = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.Y = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.Name = peremens.perevesti("Надпись1", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.BorderStyle = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.Text = peremens.perevesti("5.2 Эта программа является Windows-баннером. После нажатия клавиши \"Все внимательно прочитал, согласен\" - этот баннер будет установлен вам на компьютер, вам необходимо будет оплатить сумму в размере 900руб. (РФ) лПосле чего вам необходимо будет сообщить на мобильный телефон о оплате. После всех этих действий вам будет выслан ключ на указанный мобильный или почтовый ящик.После введению ключа компьютер войдет в прежний режим.", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.BackColor = peremens.perevesti("Серебряный", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.FontBold = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.FontSize = Conversions.ToInteger(peremens.perevesti("10", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.Height = Conversions.ToInteger(peremens.perevesti("255", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.Width = Conversions.ToInteger(peremens.perevesti("491", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_20.Props.Height = Conversions.ToInteger(peremens.perevesti("255", SdelatEnterOrSpecsimvol: true));
			RunLb_20.Props.Width = Conversions.ToInteger(peremens.perevesti("491", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(84);
			RunF_3.Props.Name = "_Полезные объекты";
			peremens2.ProgressForm.ProgressBar1.set_Value(86);
			PoleznieObj_0.Props.Name = "_Экран";
			peremens2.ProgressForm.ProgressBar1.set_Value(87);
			PoleznieObj_1.Props.Name = "_Файлы и папки";
			peremens2.ProgressForm.ProgressBar1.set_Value(89);
			PoleznieObj_2.Props.Name = "_Прерывания";
			peremens2.ProgressForm.ProgressBar1.set_Value(90);
			PoleznieObj_3.Props.Name = "_Система";
			peremens2.ProgressForm.ProgressBar1.set_Value(92);
			PoleznieObj_4.Props.Name = "_Реестр";
			peremens2.ProgressForm.ProgressBar1.set_Value(93);
			PoleznieObj_5.Props.Name = "_Вызвать событие";
			peremens2.ProgressForm.ProgressBar1.set_Value(94);
			PoleznieObj_6.Props.Name = "_Текст";
			peremens2.ProgressForm.ProgressBar1.set_Value(96);
			PoleznieObj_7.Props.Name = "_Показать сообщение";
			peremens2.ProgressForm.ProgressBar1.set_Value(97);
			PoleznieObj_8.Props.Name = "_Дата";
			peremens2.ProgressForm.ProgressBar1.set_Value(99);
			PoleznieObj_9.Props.Name = "_Расширенные возможности";
			RunF_0.Load();
			RunT_0.Load();
			RunB_0.Load();
			RunLb_0.Load();
			RunLb_1.Load();
			RunLb_2.Load();
			RunLb_3.Load();
			RunLb_4.Load();
			RunLb_5.Load();
			RunLb_6.Load();
			RunB_1.Load();
			RunB_2.Load();
			RunLb_7.Load();
			RunLb_8.Load();
			RunLb_9.Load();
			RunLb_10.Load();
			RunF_1.Load();
			RunLb_11.Load();
			RunLb_12.Load();
			RunLb_13.Load();
			RunLb_14.Load();
			RunLb_15.Load();
			RunLb_16.Load();
			RunLb_17.Load();
			RunLb_18.Load();
			RunLb_19.Load();
			RunF_2.Load();
			RunLb_20.Load();
			peremens.RunProj.GetAllObjects();
			peremens.RunProj.isINITIALIZATED = false;
			RunT_0.RaiseCreate();
			RunB_0.RaiseCreate();
			RunLb_0.RaiseCreate();
			RunLb_1.RaiseCreate();
			RunLb_2.RaiseCreate();
			RunLb_3.RaiseCreate();
			RunLb_4.RaiseCreate();
			RunLb_5.RaiseCreate();
			RunLb_6.RaiseCreate();
			RunB_1.RaiseCreate();
			RunB_2.RaiseCreate();
			RunLb_7.RaiseCreate();
			RunLb_8.RaiseCreate();
			RunLb_9.RaiseCreate();
			RunLb_10.RaiseCreate();
			RunF_0.RaiseCreate();
			RunLb_11.RaiseCreate();
			RunLb_12.RaiseCreate();
			RunLb_13.RaiseCreate();
			RunLb_14.RaiseCreate();
			RunLb_15.RaiseCreate();
			RunLb_16.RaiseCreate();
			RunLb_17.RaiseCreate();
			RunLb_18.RaiseCreate();
			RunLb_19.RaiseCreate();
			RunF_1.RaiseCreate();
			RunLb_20.RaiseCreate();
			RunF_2.RaiseCreate();
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
		if (peremens.DaOrNet(RunF_2.Props.MainForm))
		{
			NewLateBinding.LateSet(peremens2.proj, (Type)null, "isCLOSING", new object[1] { true }, (string[])null, (Type[])null);
			Application.Exit();
		}
	}

	public static void smethod_6(object sender, FormClosingEventArgs e)
	{
		if (peremens.DaOrNet(RunF_2.Props.ForbidClose))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(Strings.UCase(RunF_2.Props.MainForm), Strings.UCase(peremens.trans("Да")), false) == 0), NewLateBinding.LateGet(peremens2.proj, (Type)null, "isCLOSING", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			((Control)RunF_2).Hide();
			Application.Exit();
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = true;
			((Control)RunF_2).Hide();
		}
	}

	public static void smethod_7(object sender, EventArgs e)
	{
		if (peremens.DaOrNet(RunF_3.Props.MainForm))
		{
			NewLateBinding.LateSet(peremens2.proj, (Type)null, "isCLOSING", new object[1] { true }, (string[])null, (Type[])null);
			Application.Exit();
		}
	}

	public static void smethod_8(object sender, FormClosingEventArgs e)
	{
		if (peremens.DaOrNet(RunF_3.Props.ForbidClose))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(Strings.UCase(RunF_3.Props.MainForm), Strings.UCase(peremens.trans("Да")), false) == 0), NewLateBinding.LateGet(peremens2.proj, (Type)null, "isCLOSING", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			((Control)RunF_3).Hide();
			Application.Exit();
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = true;
			((Control)RunF_3).Hide();
		}
	}

	public static void smethod_9(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunT_0.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Passwordchar", new object[1] { "x" }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_10(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_0.MyObj), e, null, "Клик");
			Type typeFromHandle = typeof(Strings);
			object[] array = new object[1];
			object[] array2 = array;
			object objFromUniqName = peremens.RunProj.GetObjFromUniqName("Окно1.Текст1");
			object obj = objFromUniqName;
			object[] array3 = new object[0];
			object[] array4 = array3;
			string[] array5 = null;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Props", array4, array5, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array6 = array;
			object[] array7 = array6;
			bool[] array8 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array7, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objFromUniqName, (Type)null, "Props", array3, array5, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (peremens.returnBoolean(Conversions.ToString(Operators.CompareObjectEqual(obj2, (object)Strings.UCase(Conversions.ToString(47394762)), false))))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("_Полезные объекты._Система"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Run", new object[2] { "1.reg", "" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("_Полезные объекты._Система"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Run", new object[2] { "1.bat", "" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("_Полезные объекты._Система"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Run", new object[2] { "2.bat", "" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Окно1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			Type typeFromHandle2 = typeof(Strings);
			object[] array9 = new object[1];
			object[] array10 = array9;
			objFromUniqName = peremens.RunProj.GetObjFromUniqName("Окно1.Текст1");
			object obj3 = objFromUniqName;
			object[] array11 = new object[0];
			object[] array12 = array11;
			array5 = null;
			array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Props", array12, array5, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
			array6 = array9;
			object[] array13 = array6;
			array8 = new bool[1] { true };
			object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array13, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objFromUniqName, (Type)null, "Props", array11, array5, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (peremens.returnBoolean(Conversions.ToString(Operators.CompareObjectEqual(obj4, (object)Strings.UCase(Conversions.ToString(1205167)), false))))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("_Полезные объекты._Система"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Run", new object[2] { "1.reg", "" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("_Полезные объекты._Система"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Run", new object[2] { "1.bat", "" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("_Полезные объекты._Система"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Run", new object[2] { "2.bat", "" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Окно1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_11(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_0.MyObj), e, null, "Курсор на объекте");
			NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Окно1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_12(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_1.MyObj), e, null, "Клик");
			NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно2.Окно2"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_13(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_1.MyObj), e, null, "Курсор на объекте");
			NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Окно1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_14(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_2.MyObj), e, null, "Клик");
			NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно3.Окно3"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_15(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_2.MyObj), e, null, "Курсор на объекте");
			NewLateBinding.LateCall(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Окно1.Окно1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			propertysSobyt.Zavershit();
		}
	}
}
