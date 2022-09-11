using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class CodeAlg
{
	[AccessedThroughProperty("Maximally_quick0Maximally_quick0")]
	private static runF _Maximally_quick0Maximally_quick0;

	[AccessedThroughProperty("Maximally_quick0Браузер10")]
	private static runW runW_0;

	[AccessedThroughProperty("Maximally_quick0Надпись10")]
	private static runLb runLb_0;

	[AccessedThroughProperty("Maximally_quick0Текст10")]
	private static runT runT_0;

	[AccessedThroughProperty("Maximally_quick0Кнопка10")]
	private static runB runB_0;

	[AccessedThroughProperty("Maximally_quick0Полоса_загрузки10")]
	private static runPrB runPrB_0;

	[AccessedThroughProperty("Maximally_quick0Календарь10")]
	private static runCr runCr_0;

	[AccessedThroughProperty("Maximally_quick0Полоса_загрузки20")]
	private static runPrB runPrB_1;

	[AccessedThroughProperty("Maximally_quick0Одноклассники0")]
	private static runB runB_1;

	[AccessedThroughProperty("Maximally_quick0ВКонтакте0")]
	private static runB runB_2;

	[AccessedThroughProperty("Maximally_quick0Mailru0")]
	private static runB _Maximally_quick0Mailru0;

	[AccessedThroughProperty("Maximally_quick0Яндекс0")]
	private static runB runB_3;

	[AccessedThroughProperty("_Полезные_объекты0_Полезные_объекты0")]
	private static runF runF_0;

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

	public static runF Maximally_quick0Maximally_quick0
	{
		get
		{
			return _Maximally_quick0Maximally_quick0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			if (_Maximally_quick0Maximally_quick0 != null)
			{
				((Form)_Maximally_quick0Maximally_quick0).remove_FormClosing(new FormClosingEventHandler(Maximally_quick0Maximally_quick0_FormClosingNado));
				((Component)(object)_Maximally_quick0Maximally_quick0).Disposed -= Maximally_quick0Maximally_quick0_DisposedEnd;
			}
			_Maximally_quick0Maximally_quick0 = value;
			if (_Maximally_quick0Maximally_quick0 != null)
			{
				((Form)_Maximally_quick0Maximally_quick0).add_FormClosing(new FormClosingEventHandler(Maximally_quick0Maximally_quick0_FormClosingNado));
				((Component)(object)_Maximally_quick0Maximally_quick0).Disposed += Maximally_quick0Maximally_quick0_DisposedEnd;
			}
		}
	} = new runF();


	public static runW RunW_0
	{
		get
		{
			return runW_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (runW_0 != null)
			{
				((WebBrowser)runW_0).remove_NewWindow((CancelEventHandler)smethod_1);
				((WebBrowser)runW_0).remove_StatusTextChanged((EventHandler)smethod_0);
			}
			runW_0 = value;
			if (runW_0 != null)
			{
				((WebBrowser)runW_0).add_NewWindow((CancelEventHandler)smethod_1);
				((WebBrowser)runW_0).add_StatusTextChanged((EventHandler)smethod_0);
			}
		}
	} = new runW();


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
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			if (runT_0 != null)
			{
				((Control)runT_0).remove_KeyDown(new KeyEventHandler(smethod_5));
				((Control)runT_0).remove_KeyPress(new KeyPressEventHandler(smethod_2));
			}
			runT_0 = value;
			if (runT_0 != null)
			{
				((Control)runT_0).add_KeyDown(new KeyEventHandler(smethod_5));
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
				runB_0.Created -= smethod_6;
				((Control)runB_0).remove_Click((EventHandler)smethod_7);
			}
			runB_0 = value;
			if (runB_0 != null)
			{
				runB_0.Created += smethod_6;
				((Control)runB_0).add_Click((EventHandler)smethod_7);
			}
		}
	} = new runB();


	public static runPrB RunPrB_0
	{
		get
		{
			return runPrB_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runPrB_0 = value;
		}
	} = new runPrB();


	public static runCr RunCr_0
	{
		get
		{
			return runCr_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runCr_0 = value;
		}
	} = new runCr();


	public static runPrB RunPrB_1
	{
		get
		{
			return runPrB_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			runPrB_1 = value;
		}
	} = new runPrB();


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
				((Control)runB_1).remove_Click((EventHandler)smethod_8);
			}
			runB_1 = value;
			if (runB_1 != null)
			{
				((Control)runB_1).add_Click((EventHandler)smethod_8);
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
				((Control)runB_2).remove_Click((EventHandler)smethod_9);
			}
			runB_2 = value;
			if (runB_2 != null)
			{
				((Control)runB_2).add_Click((EventHandler)smethod_9);
			}
		}
	} = new runB();


	public static runB Maximally_quick0Mailru0
	{
		get
		{
			return _Maximally_quick0Mailru0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Maximally_quick0Mailru0 != null)
			{
				((Control)_Maximally_quick0Mailru0).remove_Click((EventHandler)Maximally_quick0Mailru0_Click);
			}
			_Maximally_quick0Mailru0 = value;
			if (_Maximally_quick0Mailru0 != null)
			{
				((Control)_Maximally_quick0Mailru0).add_Click((EventHandler)Maximally_quick0Mailru0_Click);
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
				((Control)runB_3).remove_Click((EventHandler)smethod_10);
			}
			runB_3 = value;
			if (runB_3 != null)
			{
				((Control)runB_3).add_Click((EventHandler)smethod_10);
			}
		}
	} = new runB();


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
				((Form)runF_0).remove_FormClosing(new FormClosingEventHandler(smethod_4));
				((Component)(object)runF_0).Disposed -= smethod_3;
			}
			runF_0 = value;
			if (runF_0 != null)
			{
				((Form)runF_0).add_FormClosing(new FormClosingEventHandler(smethod_4));
				((Component)(object)runF_0).Disposed += smethod_3;
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
		Maximally_quick0Maximally_quick0.MyObj = new Forms(holostoi: true, polezniy: false, isRun: true);
		NewLateBinding.LateSet(Maximally_quick0Maximally_quick0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Maximally_quick0Maximally_quick0.MyObj, (Type)null, "obj", new object[1] { Maximally_quick0Maximally_quick0 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(Maximally_quick0Maximally_quick0.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Maximally_quick0" }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Maximally_quick0Maximally_quick0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
		peremens.ReDims(ref peremens.RunProj.f);
		checked
		{
			peremens.RunProj.f[peremens.RunProj.f.Length - 1] = (Forms)Maximally_quick0Maximally_quick0.MyObj;
			object myObj = Maximally_quick0Maximally_quick0.MyObj;
			object obj = myObj;
			object[] array = new object[0];
			object[] array2 = array;
			string[] array3 = null;
			object mass = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MyForm", array2, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref mass);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(myObj, (Type)null, "MyForm", array, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(mass) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Maximally_quick0Maximally_quick0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Maximally_quick0Maximally_quick0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunW_0.MyObj = new WBrowser(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunW_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunW_0.MyObj, (Type)null, "obj", new object[1] { RunW_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunW_0.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Браузер10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunW_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunW_0.MyObj;
			object obj2 = mass;
			object[] array4 = new object[0];
			object[] array5 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "MyForm", array5, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunW_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunW_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunW_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunLb_0.MyObj = new Label(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunLb_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_0.MyObj, (Type)null, "obj", new object[1] { RunLb_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunLb_0.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Надпись10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunLb_0.MyObj;
			object obj3 = mass;
			array4 = new object[0];
			object[] array6 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "MyForm", array6, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunLb_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunLb_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunLb_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunT_0.MyObj = new TextBoks(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunT_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunT_0.MyObj, (Type)null, "obj", new object[1] { RunT_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunT_0.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Текст10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunT_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunT_0.MyObj;
			object obj4 = mass;
			array4 = new object[0];
			object[] array7 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "MyForm", array7, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSet(RunB_0.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Кнопка10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_0.MyObj;
			object obj5 = mass;
			array4 = new object[0];
			object[] array8 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "MyForm", array8, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(5);
			RunPrB_0.MyObj = new ProgressBar(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunPrB_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunPrB_0.MyObj, (Type)null, "obj", new object[1] { RunPrB_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunPrB_0.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Полоса_загрузки10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunPrB_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunPrB_0.MyObj;
			object obj6 = mass;
			array4 = new object[0];
			object[] array9 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "MyForm", array9, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunPrB_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunPrB_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunPrB_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunCr_0.MyObj = new Calendar(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunCr_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunCr_0.MyObj, (Type)null, "obj", new object[1] { RunCr_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunCr_0.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Календарь10" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunCr_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunCr_0.MyObj;
			object obj7 = mass;
			array4 = new object[0];
			object[] array10 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "MyForm", array10, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunCr_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunCr_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunCr_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunPrB_1.MyObj = new ProgressBar(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunPrB_1.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunPrB_1.MyObj, (Type)null, "obj", new object[1] { RunPrB_1 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunPrB_1.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Полоса_загрузки20" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunPrB_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunPrB_1.MyObj;
			object obj8 = mass;
			array4 = new object[0];
			object[] array11 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "MyForm", array11, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunPrB_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunPrB_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunPrB_1.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_1.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_1.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_1.MyObj, (Type)null, "obj", new object[1] { RunB_1 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_1.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Одноклассники0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_1.MyObj;
			object obj9 = mass;
			array4 = new object[0];
			object[] array12 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "MyForm", array12, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSet(RunB_2.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0ВКонтакте0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_2.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_2.MyObj;
			object obj10 = mass;
			array4 = new object[0];
			object[] array13 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj10, (Type)null, "MyForm", array13, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_2.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_2.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(11);
			Maximally_quick0Mailru0.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(Maximally_quick0Mailru0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Maximally_quick0Mailru0.MyObj, (Type)null, "obj", new object[1] { Maximally_quick0Mailru0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(Maximally_quick0Mailru0.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Mailru0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Maximally_quick0Mailru0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = Maximally_quick0Mailru0.MyObj;
			object obj11 = mass;
			array4 = new object[0];
			object[] array14 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj11, (Type)null, "MyForm", array14, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Maximally_quick0Mailru0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Maximally_quick0Mailru0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(Maximally_quick0Mailru0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunB_3.MyObj = new Button(holostoi: true, isRun: true);
			NewLateBinding.LateSet(RunB_3.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_3.MyObj, (Type)null, "obj", new object[1] { RunB_3 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunB_3.MyObj, (Type)null, "VBname", new object[1] { "Maximally_quick0Яндекс0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_3.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(Maximally_quick0Maximally_quick0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = RunB_3.MyObj;
			object obj12 = mass;
			array4 = new object[0];
			object[] array15 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj12, (Type)null, "MyForm", array15, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunB_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunB_3.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunB_3.MyObj)
			}, (string[])null, (Type[])null, false, true);
			RunF_0.MyObj = new Forms(holostoi: true, polezniy: false, isRun: true);
			NewLateBinding.LateSet(RunF_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_0.MyObj, (Type)null, "obj", new object[1] { RunF_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(RunF_0.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Полезные_объекты0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			peremens.ReDims(ref peremens.RunProj.f);
			peremens.RunProj.f[peremens.RunProj.f.Length - 1] = (Forms)RunF_0.MyObj;
			mass = RunF_0.MyObj;
			object obj13 = mass;
			array4 = new object[0];
			object[] array16 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj13, (Type)null, "MyForm", array16, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(RunF_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(RunF_0.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(RunF_0.MyObj)
			}, (string[])null, (Type[])null, false, true);
			PoleznieObj_0.MyObj = new Poleznie("_Экран");
			NewLateBinding.LateSet(PoleznieObj_0.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_0.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_0 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_0.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Экран0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_0.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_0.MyObj;
			object obj14 = mass;
			array4 = new object[0];
			object[] array17 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj14, (Type)null, "MyForm", array17, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_1.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_1.MyObj;
			object obj15 = mass;
			array4 = new object[0];
			object[] array18 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj15, (Type)null, "MyForm", array18, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_1.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_1.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(16);
			PoleznieObj_2.MyObj = new Poleznie("_Прерывания");
			NewLateBinding.LateSet(PoleznieObj_2.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_2.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_2 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_2.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Прерывания0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_2.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_2.MyObj;
			object obj16 = mass;
			array4 = new object[0];
			object[] array19 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj16, (Type)null, "MyForm", array19, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_3.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_3.MyObj;
			object obj17 = mass;
			array4 = new object[0];
			object[] array20 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj17, (Type)null, "MyForm", array20, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_4.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_4.MyObj;
			object obj18 = mass;
			array4 = new object[0];
			object[] array21 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj18, (Type)null, "MyForm", array21, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_5.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_5.MyObj;
			object obj19 = mass;
			array4 = new object[0];
			object[] array22 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj19, (Type)null, "MyForm", array22, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_6.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_6.MyObj;
			object obj20 = mass;
			array4 = new object[0];
			object[] array23 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj20, (Type)null, "MyForm", array23, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_6.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_6.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_6.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(22);
			PoleznieObj_7.MyObj = new Poleznie("_Показать сообщение");
			NewLateBinding.LateSet(PoleznieObj_7.MyObj, (Type)null, "proj", new object[1] { RuntimeHelpers.GetObjectValue(peremens2.proj) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_7.MyObj, (Type)null, "obj", new object[1] { PoleznieObj_7 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(PoleznieObj_7.MyObj, (Type)null, "VBname", new object[1] { "_Полезные_объекты0_Показать_сообщение0" }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_7.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_7.MyObj;
			object obj21 = mass;
			array4 = new object[0];
			object[] array24 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj21, (Type)null, "MyForm", array24, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_8.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_8.MyObj;
			object obj22 = mass;
			array4 = new object[0];
			object[] array25 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj22, (Type)null, "MyForm", array25, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
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
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_9.MyObj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyForm", new object[1] { RuntimeHelpers.GetObjectValue(RunF_0.MyObj) }, (string[])null, (Type[])null, false, true);
			mass = PoleznieObj_9.MyObj;
			object obj23 = mass;
			array4 = new object[0];
			object[] array26 = array4;
			array3 = null;
			myObj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj23, (Type)null, "MyForm", array26, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
			peremens.ReDimsO(ref myObj);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(mass, (Type)null, "MyForm", array4, array3, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(myObj) }, (string[])null, (Type[])null, true, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(PoleznieObj_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(PoleznieObj_9.MyObj, (Type)null, "MyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				RuntimeHelpers.GetObjectValue(PoleznieObj_9.MyObj)
			}, (string[])null, (Type[])null, false, true);
			peremens2.ProgressForm.ProgressBar1.set_Value(25);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunW_0);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunLb_0);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunT_0);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunB_0);
			peremens2.ProgressForm.ProgressBar1.set_Value(27);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunPrB_0);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunCr_0);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunPrB_1);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunB_1);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunB_2);
			peremens2.ProgressForm.ProgressBar1.set_Value(29);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)Maximally_quick0Mailru0);
			((Control)Maximally_quick0Maximally_quick0).get_Controls().Add((Control)(object)RunB_3);
			peremens2.ProgressForm.ProgressBar1.set_Value(32);
			peremens2.ProgressForm.ProgressBar1.set_Value(34);
			peremens2.ProgressForm.ProgressBar1.set_Value(35);
			((Control)RunW_0).BringToFront();
			((Control)RunB_0).BringToFront();
			((Control)RunLb_0).BringToFront();
			((Control)RunT_0).BringToFront();
			((Control)RunPrB_0).BringToFront();
			((Control)RunCr_0).BringToFront();
			((Control)RunPrB_1).BringToFront();
			((Control)RunB_1).BringToFront();
			((Control)RunB_2).BringToFront();
			((Control)Maximally_quick0Mailru0).BringToFront();
			((Control)RunB_3).BringToFront();
			peremens2.ProgressForm.ProgressBar1.set_Value(37);
			peremens2.ProgressForm.ProgressBar1.set_Value(39);
			peremens2.ProgressForm.ProgressBar1.set_Value(42);
			peremens2.ProgressForm.ProgressBar1.set_Value(44);
			peremens2.ProgressForm.ProgressBar1.set_Value(45);
			Maximally_quick0Maximally_quick0.Props.Text = peremens.perevesti("Maximally quick", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.X = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.Y = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.AssociateWithExtensions = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.MainForm = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.set_MainMenuStrip(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.AutoRun = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.ForbidClose = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.ForbidMinimize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.ForbidMaximize = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.Icon = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.Name = peremens.perevesti("Maximally quick", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.ControlBox = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.ShowInTaskbar = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.ShowInTray = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.TopMost = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.ShowIcon = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.Opacity = Conversions.ToInteger(peremens.perevesti("100", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.TransparentcyKey = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.Scroll = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.AutoScrollMinSizeHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.AutoScrollMinSizeWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.AutoScrollPositionX = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.AutoScrollPositionY = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.AllowRunCopies = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.StartPosition = peremens.perevesti("По центру экрана", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.StatusTemp = "Нормальный";
			Maximally_quick0Maximally_quick0.Props.FormBorderStyle = peremens.perevesti("Нормальный", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.BackColor = peremens.perevesti("240; 240; 240;", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.Height = Conversions.ToInteger(peremens.perevesti("691", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.Width = Conversions.ToInteger(peremens.perevesti("1159", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Maximally_quick0.Props.Height = Conversions.ToInteger(peremens.perevesti("691", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Maximally_quick0.Props.Width = Conversions.ToInteger(peremens.perevesti("1159", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(47);
			RunW_0.Props.X = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.Y = Conversions.ToInteger(peremens.perevesti("28", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.isWebBrowserContextMunuEnabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.WebBrowserShortcutsEnabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.Name = peremens.perevesti("Браузер1", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.DocumentEncoding = peremens.perevesti("unicode utf-8", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.Cookie = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.OpenNewWindowLink = peremens.perevesti("В данном браузере", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.ScriptErrorsSuppressed = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.AllowNavigation = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.ScrollBarsEnabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.AllowWebBrowserDrop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.DocumentText = peremens.perevesti("<HTML></HTML>\0", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.Height = Conversions.ToInteger(peremens.perevesti("663", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.Width = Conversions.ToInteger(peremens.perevesti("1167", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunW_0.Props.Height = Conversions.ToInteger(peremens.perevesti("663", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.Width = Conversions.ToInteger(peremens.perevesti("1167", SdelatEnterOrSpecsimvol: true));
			RunW_0.Props.Url = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			peremens2.ProgressForm.ProgressBar1.set_Value(50);
			RunLb_0.Props.Text = peremens.perevesti("Адрес:", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.X = Conversions.ToInteger(peremens.perevesti("364", SdelatEnterOrSpecsimvol: true));
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
			RunLb_0.Props.BackColor = peremens.perevesti("240; 240; 240;", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Height = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunLb_0.Props.Height = Conversions.ToInteger(peremens.perevesti("27", SdelatEnterOrSpecsimvol: true));
			RunLb_0.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(52);
			RunT_0.Props.Text = peremens.perevesti("yandex.ru", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.X = Conversions.ToInteger(peremens.perevesti("428", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Y = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
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
			RunT_0.Props.Anchor = peremens.perevesti("справа_слева_сверху", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.AllowInput = peremens.perevesti("Все", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.TextPosition = peremens.perevesti("Слева", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.PasswordChar = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.HideSelection = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.BorderStyle = peremens.perevesti("объем", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.ReadOnly = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.BackColor = peremens.perevesti("Белый", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Height = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Width = Conversions.ToInteger(peremens.perevesti("539", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunT_0.Props.Height = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunT_0.Props.Width = Conversions.ToInteger(peremens.perevesti("539", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(55);
			RunB_0.Props.Text = peremens.perevesti("Перейти", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.X = Conversions.ToInteger(peremens.perevesti("988", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Y = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
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
			RunB_0.Props.Anchor = peremens.perevesti("справа_сверху", SdelatEnterOrSpecsimvol: true);
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
			RunB_0.Props.Width = Conversions.ToInteger(peremens.perevesti("83", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_0.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_0.Props.Width = Conversions.ToInteger(peremens.perevesti("83", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(57);
			RunPrB_0.Props.X = Conversions.ToInteger(peremens.perevesti("320", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.Y = Conversions.ToInteger(peremens.perevesti("1108", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.Name = peremens.perevesti("Полоса загрузки1", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.Maximum = peremens.perevesti("100", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.Minimum = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.MarqueeAnimationSpeed = peremens.perevesti("100", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.RightToLeftLayout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.StyleProgress = peremens.perevesti("блоки", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.BackColor = peremens.perevesti("Системный", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.StepProgress = peremens.perevesti("10", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.Height = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.Width = Conversions.ToInteger(peremens.perevesti("250", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunPrB_0.Props.Height = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.Width = Conversions.ToInteger(peremens.perevesti("250", SdelatEnterOrSpecsimvol: true));
			RunPrB_0.Props.Value = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			peremens2.ProgressForm.ProgressBar1.set_Value(59);
			RunCr_0.Props.Text = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.X = Conversions.ToInteger(peremens.perevesti("1164", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.Y = Conversions.ToInteger(peremens.perevesti("972", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.SelectedDate = peremens.perevesti("17.11.2014 18:55:33", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.Name = peremens.perevesti("Календарь1", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.ShowUpDown = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.CalendarDateFormat = peremens.perevesti("по выбору", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.CustomDateFormat = peremens.perevesti("dd MMM yyyy г.", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.Height = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.Width = Conversions.ToInteger(peremens.perevesti("175", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunCr_0.Props.Height = Conversions.ToInteger(peremens.perevesti("20", SdelatEnterOrSpecsimvol: true));
			RunCr_0.Props.Width = Conversions.ToInteger(peremens.perevesti("175", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(62);
			RunPrB_1.Props.X = Conversions.ToInteger(peremens.perevesti("548", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.Y = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.Name = peremens.perevesti("Полоса загрузки2", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.Maximum = peremens.perevesti("100", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.Minimum = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.MarqueeAnimationSpeed = peremens.perevesti("100", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.RightToLeftLayout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.StyleProgress = peremens.perevesti("блоки", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.BackColor = peremens.perevesti("Системный", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.StepProgress = peremens.perevesti("10", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.Width = Conversions.ToInteger(peremens.perevesti("439", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunPrB_1.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.Width = Conversions.ToInteger(peremens.perevesti("439", SdelatEnterOrSpecsimvol: true));
			RunPrB_1.Props.Value = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			peremens2.ProgressForm.ProgressBar1.set_Value(64);
			RunB_1.Props.Text = peremens.perevesti("Одноклассники", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.X = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Y = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Name = peremens.perevesti("Одноклассники", SdelatEnterOrSpecsimvol: true);
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
			RunB_1.Props.Width = Conversions.ToInteger(peremens.perevesti("123", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_1.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_1.Props.Width = Conversions.ToInteger(peremens.perevesti("123", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(67);
			RunB_2.Props.Text = peremens.perevesti("ВКонтакте", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.X = Conversions.ToInteger(peremens.perevesti("128", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Y = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Name = peremens.perevesti("ВКонтакте", SdelatEnterOrSpecsimvol: true);
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
			RunB_2.Props.Width = Conversions.ToInteger(peremens.perevesti("87", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_2.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_2.Props.Width = Conversions.ToInteger(peremens.perevesti("87", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(69);
			Maximally_quick0Mailru0.Props.Text = peremens.perevesti("Mail.ru", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.X = Conversions.ToInteger(peremens.perevesti("220", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.Y = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.Name = peremens.perevesti("Mailru", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.Cursor = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.MaximumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.MaximumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.MinimumHeight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.MinimumWidth = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.Index = peremens.perevesti("0", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.ToolTip = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.PaddingTop = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.PaddingLeft = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.PaddingBottom = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.PaddingRight = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.ImageAlign = peremens.perevesti("Центр", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.TextAlign = peremens.perevesti("центр", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.Anchor = peremens.perevesti("Слева_Сверху", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.Enabled = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.Dock = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.Image = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.FlatStyle = peremens.perevesti("Обычный", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.BackgroundImageLayout = peremens.perevesti("Плитка", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.TabIndex = Conversions.ToInteger(peremens.perevesti("0", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.TabStop = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.TextImageRelation = peremens.perevesti("Поверх", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.BackgroundImage = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.BackColor = peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.ForeColor = peremens.perevesti("Черный", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.FontFamily = peremens.perevesti("Microsoft Sans Serif", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.FontBold = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.FontStrikeout = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.FontItalic = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.FontUnderline = peremens.perevesti("Нет", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.FontSize = Conversions.ToInteger(peremens.perevesti("8", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			Maximally_quick0Mailru0.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			Maximally_quick0Mailru0.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(71);
			RunB_3.Props.Text = peremens.perevesti("Яндекс", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.X = Conversions.ToInteger(peremens.perevesti("296", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Y = Conversions.ToInteger(peremens.perevesti("4", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.AutoEllipsis = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.set_ContextMenu(fromLoad: true, peremens.perevesti("Никакой", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Tag = peremens.perevesti("", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.Name = peremens.perevesti("Яндекс", SdelatEnterOrSpecsimvol: true);
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
			RunB_3.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Visible = peremens.perevesti("Да", SdelatEnterOrSpecsimvol: true);
			RunB_3.Props.Height = Conversions.ToInteger(peremens.perevesti("23", SdelatEnterOrSpecsimvol: true));
			RunB_3.Props.Width = Conversions.ToInteger(peremens.perevesti("75", SdelatEnterOrSpecsimvol: true));
			peremens2.ProgressForm.ProgressBar1.set_Value(74);
			RunF_0.Props.Name = "_Полезные объекты";
			peremens2.ProgressForm.ProgressBar1.set_Value(76);
			PoleznieObj_0.Props.Name = "_Экран";
			peremens2.ProgressForm.ProgressBar1.set_Value(78);
			PoleznieObj_1.Props.Name = "_Файлы и папки";
			peremens2.ProgressForm.ProgressBar1.set_Value(81);
			PoleznieObj_2.Props.Name = "_Прерывания";
			peremens2.ProgressForm.ProgressBar1.set_Value(83);
			PoleznieObj_3.Props.Name = "_Система";
			peremens2.ProgressForm.ProgressBar1.set_Value(86);
			PoleznieObj_4.Props.Name = "_Реестр";
			peremens2.ProgressForm.ProgressBar1.set_Value(88);
			PoleznieObj_5.Props.Name = "_Вызвать событие";
			peremens2.ProgressForm.ProgressBar1.set_Value(90);
			PoleznieObj_6.Props.Name = "_Текст";
			peremens2.ProgressForm.ProgressBar1.set_Value(93);
			PoleznieObj_7.Props.Name = "_Показать сообщение";
			peremens2.ProgressForm.ProgressBar1.set_Value(95);
			PoleznieObj_8.Props.Name = "_Дата";
			peremens2.ProgressForm.ProgressBar1.set_Value(98);
			PoleznieObj_9.Props.Name = "_Расширенные возможности";
			Maximally_quick0Maximally_quick0.Load();
			RunW_0.Load();
			RunLb_0.Load();
			RunT_0.Load();
			RunB_0.Load();
			RunPrB_0.Load();
			RunCr_0.Load();
			RunPrB_1.Load();
			RunB_1.Load();
			RunB_2.Load();
			Maximally_quick0Mailru0.Load();
			RunB_3.Load();
			peremens.RunProj.GetAllObjects();
			peremens.RunProj.isINITIALIZATED = false;
			RunW_0.RaiseCreate();
			RunLb_0.RaiseCreate();
			RunT_0.RaiseCreate();
			RunB_0.RaiseCreate();
			RunPrB_0.RaiseCreate();
			RunCr_0.RaiseCreate();
			RunPrB_1.RaiseCreate();
			RunB_1.RaiseCreate();
			RunB_2.RaiseCreate();
			Maximally_quick0Mailru0.RaiseCreate();
			RunB_3.RaiseCreate();
			Maximally_quick0Maximally_quick0.RaiseCreate();
			((Control)peremens2.ProgressForm).Hide();
		}
	}

	public static void Maximally_quick0Maximally_quick0_DisposedEnd(object sender, EventArgs e)
	{
		if (peremens.DaOrNet(Maximally_quick0Maximally_quick0.Props.MainForm))
		{
			NewLateBinding.LateSet(peremens2.proj, (Type)null, "isCLOSING", new object[1] { true }, (string[])null, (Type[])null);
			Application.Exit();
		}
	}

	public static void Maximally_quick0Maximally_quick0_FormClosingNado(object sender, FormClosingEventArgs e)
	{
		if (peremens.DaOrNet(Maximally_quick0Maximally_quick0.Props.ForbidClose))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else if (Conversions.ToBoolean(Operators.OrObject((object)(Operators.CompareString(Strings.UCase(Maximally_quick0Maximally_quick0.Props.MainForm), Strings.UCase(peremens.trans("Да")), false) == 0), NewLateBinding.LateGet(peremens2.proj, (Type)null, "isCLOSING", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			((Control)Maximally_quick0Maximally_quick0).Hide();
			Application.Exit();
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = true;
			((Control)Maximally_quick0Maximally_quick0).Hide();
		}
	}

	public static void smethod_0(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, (Type)null, "StatusText", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false) && Uri.IsWellFormedUriString(Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "StatusText", new object[0], (string[])null, (Type[])null, (bool[])null)), UriKind.RelativeOrAbsolute))
		{
			NewLateBinding.LateSet(sender, (Type)null, "lastLink", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type)null, "StatusText", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
		}
	}

	public static void smethod_1(object sender, CancelEventArgs e)
	{
		peremens2.WebBrowser_NewWindowNado(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public static void smethod_2(object sender, KeyPressEventArgs e)
	{
		e.set_Handled(peremens.TextBoxAllow(RuntimeHelpers.GetObjectValue(sender), e));
	}

	public static void smethod_3(object sender, EventArgs e)
	{
		if (peremens.DaOrNet(RunF_0.Props.MainForm))
		{
			NewLateBinding.LateSet(peremens2.proj, (Type)null, "isCLOSING", new object[1] { true }, (string[])null, (Type[])null);
			Application.Exit();
		}
	}

	public static void smethod_4(object sender, FormClosingEventArgs e)
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

	public static void smethod_5(object sender, KeyEventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunT_0.MyObj), e, null, "Нажатие вниз кнопки");
			Type typeFromHandle = typeof(Strings);
			object[] array = new object[1];
			SortedList paramyUp = propertysSobyt.ParamyUp;
			string key = peremens.MyZnak + "НАЖАТАЯ КЛАВИША";
			array[0] = RuntimeHelpers.GetObjectValue(paramyUp[key]);
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				paramyUp[key] = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			if (peremens.returnBoolean(Conversions.ToString(Operators.CompareObjectEqual(obj, (object)Strings.UCase("enter"), false))))
			{
				smethod_7(RunB_0, null);
			}
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_6(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_0.MyObj), e, null, "Создание");
			smethod_7(RunB_0, null);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_7(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_0.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Maximally quick.Браузер1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Url", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Maximally quick.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_8(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_1.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Maximally quick.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "ok.ru" }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_9(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_2.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Maximally quick.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "vk.com" }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void Maximally_quick0Mailru0_Click(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(Maximally_quick0Mailru0.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Maximally quick.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "mail.ru" }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}

	public static void smethod_10(object sender, EventArgs e)
	{
		if (!peremens.RunProj.isINITIALIZATED)
		{
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(RunB_3.MyObj), e, null, "Клик");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens.RunProj.GetObjFromUniqName("Maximally quick.Текст1"), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "yandex.ru" }, (string[])null, (Type[])null, false, true);
			propertysSobyt.Zavershit();
		}
	}
}
