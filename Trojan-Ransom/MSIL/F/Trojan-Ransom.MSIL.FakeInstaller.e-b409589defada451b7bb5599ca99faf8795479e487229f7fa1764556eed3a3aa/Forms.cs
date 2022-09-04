using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class Forms : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public ArrayList HistoryLevel;

	public bool recur;

	[AccessedThroughProperty("EventObjRun")]
	private runF _EventObjRun;

	public TabPage tab;

	public new SplitContainer SplitCont;

	public object[] ActiveObj;

	public object[] MyObjs;

	public bool ctrl;

	private object i;

	private virtual runF EventObjRun
	{
		get
		{
			return _EventObjRun;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_EventObjRun = value;
		}
	}

	public Forms(bool holostoi = false, bool polezniy = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[50]
		{
			peremens.trans("Текст"),
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Цвет"),
			peremens.trans("Фоновой рисунок"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Стиль фона"),
			peremens.trans("Курсор"),
			peremens.trans("Работает"),
			peremens.trans("Прокрутка"),
			peremens.trans("Цвет шрифта"),
			peremens.trans("X"),
			peremens.trans("Y"),
			peremens.trans("Максимальная ширина"),
			peremens.trans("Максимальная вышина"),
			peremens.trans("Минимальная ширина"),
			peremens.trans("Минимальная вышина"),
			peremens.trans("Ширина"),
			peremens.trans("Вышина"),
			peremens.trans("ТабНомер"),
			peremens.trans("ТабСтоп"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Видимый"),
			peremens.trans("Главная форма"),
			peremens.trans("Запретить закрытие"),
			peremens.trans("Оконные кнопки и меню"),
			peremens.trans("Стиль окна"),
			peremens.trans("Главное меню"),
			peremens.trans("Прозрачность"),
			peremens.trans("Показывать иконку"),
			peremens.trans("Отображать в панели задач"),
			peremens.trans("Стартовая позиция"),
			peremens.trans("Поверх всех окон"),
			peremens.trans("Статус окна"),
			peremens.trans("Прокрутка минимальная ширина"),
			peremens.trans("Прокрутка минимальная вышина"),
			peremens.trans("Прокручено по X"),
			peremens.trans("Прокручено по Y"),
			peremens.trans("Высота заголовка"),
			peremens.trans("Иконка"),
			peremens.trans("Прозрачный цвет"),
			peremens.trans("Тип"),
			peremens.trans("Подсказка"),
			peremens.trans("Отображать в трее"),
			peremens.trans("Добавить в автозагрузку"),
			peremens.trans("Разрешить запуск копий"),
			peremens.trans("Запретить минимизировать"),
			peremens.trans("Запретить разворачивать"),
			peremens.trans("Ассоциировать с расширениями"),
			peremens.trans("Ассоциированый принятый файл")
		};
		Methods = new string[7]
		{
			peremens.trans("Обновить"),
			peremens.trans("Скрыть"),
			peremens.trans("Показать"),
			peremens.trans("Получить фокус"),
			peremens.trans("Закрыть"),
			peremens.trans("Свернуть в трей"),
			peremens.trans("Развернуть из трея")
		};
		Sobyts = new string[23]
		{
			peremens.trans("Клик"),
			peremens.trans("Нажатие кнопки мыши"),
			peremens.trans("Отжатие кнопки мыши"),
			peremens.trans("Движение курсора"),
			peremens.trans("Наведение курсора"),
			peremens.trans("Отведение курсора"),
			peremens.trans("Курсор на объекте"),
			peremens.trans("Двойной клик"),
			peremens.trans("Вращение колесика"),
			peremens.trans("Нажатие клавиатуры"),
			peremens.trans("Нажатие вниз кнопки"),
			peremens.trans("Отжатие кнопки"),
			peremens.trans("Создание"),
			peremens.trans("Изменение текста"),
			peremens.trans("Прорисовка"),
			peremens.trans("Получение фокуса"),
			peremens.trans("Потеря фокуса"),
			peremens.trans("Изменились размеры"),
			peremens.trans("Закрытие окна"),
			peremens.trans("Прокрутка"),
			peremens.trans("Сворачивание"),
			peremens.trans("Изменилась видимость"),
			peremens.trans("Двойной клик по трею")
		};
		Picture = "window";
		HistoryLevel = new ArrayList();
		if (polezniy)
		{
			string[] array = (Propertys = new string[3]
			{
				peremens.trans("Имя"),
				peremens.trans("Текст"),
				peremens.trans("Номер")
			});
			peremens.CreatePropertySobytsUp(this);
			F ob = new F
			{
				TypeObj = "Polezniy"
			};
			MyObjs = peremens.PoleznieObjs;
			CreateObject(ob);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { peremens.MyZnak + peremens.trans("Полезные объекты") }, (string[])null, (Type[])null, false, true);
		}
		else
		{
			peremens.CreatePropertySobytsUp(this);
			Sobytia = SobytsUp;
			if (isRun)
			{
				CreateObject(new runF(), holostoi, isRun, fromEng);
			}
			else
			{
				CreateObject(new F(), holostoi, isRun, fromEng);
			}
		}
	}

	public object AddObject(object MyObj, bool withSelect = true)
	{
		if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"#NotCreateDP", false) && (proj == null || NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null) == null || (!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false), (object)(Operators.CompareString(MyObj.GetType().ToString(), peremens.ClassAplication + "Forms", false) != 0))) && !peremens.isOpening)))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
			{
				return null;
			}
			int num = ((MyObjs != null) ? MyObjs.Length : 0);
			MyObjs = (object[])Utils.CopyArray((Array)MyObjs, (Array)new object[checked(num + 1)]);
			MyObjs[num] = RuntimeHelpers.GetObjectValue(MyObj);
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"IncludeObj", false) && withSelect)
			{
				SetActiveObject(RuntimeHelpers.GetObjectValue(MyObj));
				marker_vis();
			}
			if ((peremens2.CreateDs != null) & !isRun & (NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null))
			{
				NewLateBinding.LateCall(peremens2.CreateDs, (Type)null, "SetProperty", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
			}
			return MyObj;
		}
		object result = default(object);
		return result;
	}

	public void TabTextRefresh()
	{
		if (isRun)
		{
			return;
		}
		tab.set_Text(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(base.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)));
		((Control)tab).set_Name(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(base.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)));
		if (proj != null)
		{
			object obj = proj;
			object[] array = new object[2];
			object obj2 = base.obj;
			object[] array2 = new object[0];
			string[] array3 = null;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Props", array2, array3, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[1] = RuntimeHelpers.GetObjectValue(base.obj);
			object[] array4 = array;
			bool[] array5 = new bool[2] { true, true };
			object obj3 = NewLateBinding.LateGet(obj, (Type)null, "ExistName", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Props", array2, array3, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (array5[1])
			{
				base.obj = RuntimeHelpers.GetObjectValue(array4[1]);
			}
			if (Conversions.ToBoolean(Operators.OrObject(obj3, Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(base.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
			{
				TabPage val = tab;
				val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject((object)" (", NewLateBinding.LateGet(NewLateBinding.LateGet(base.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")"))));
			}
		}
	}

	public void SelectTab()
	{
		NewLateBinding.LateSet(proj, (Type)null, "ActiveForm", new object[1] { RuntimeHelpers.GetObjectValue(MyObj) }, (string[])null, (Type[])null);
		object obj = NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[1];
		object obj2 = NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array2 = new object[1];
		object[] array3 = array2;
		TabPage val = tab;
		array3[0] = ((Control)val).get_Name();
		object[] array4 = array2;
		bool[] array5 = new bool[1] { true };
		object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "TabPages", array4, (string[])null, (Type[])null, array5);
		if (array5[0])
		{
			((Control)val).set_Name((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string)));
		}
		array[0] = RuntimeHelpers.GetObjectValue(obj3);
		NewLateBinding.LateSetComplex(obj, (Type)null, "SelectedTab", array, (string[])null, (Type[])null, false, true);
	}

	public object[] GetMyObjsFromName(object name, string index = "")
	{
		object obj = 0;
		object[] array = null;
		if (MyObjs == null)
		{
			return null;
		}
		checked
		{
			int num = MyObjs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				object obj2 = Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), name, false);
				object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array2 = new object[1] { index };
				bool[] array3 = new bool[1] { true };
				object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "indexof", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					index = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
				if (Conversions.ToBoolean(Operators.AndObject(obj2, Operators.CompareObjectEqual(obj4, (object)0, false))))
				{
					array = (object[])Utils.CopyArray((Array)array, (Array)new object[Conversions.ToInteger(obj) + 1]);
					array[Conversions.ToInteger(obj)] = RuntimeHelpers.GetObjectValue(MyObjs[i]);
					obj = Operators.AddObject(obj, (object)1);
				}
			}
			return array;
		}
	}

	public void HistoryLevelRun(string kuda, params object[] MyObjs)
	{
		if (MyObjs == null)
		{
			return;
		}
		if (kuda == null)
		{
			kuda = "";
		}
		kuda = kuda.ToLower();
		checked
		{
			if ((Operators.CompareString(kuda, "", false) == 0) | (Operators.CompareString(kuda, "на передний план", false) == 0))
			{
				for (int i = MyObjs.Length - 1; i >= 0; i += -1)
				{
					HistoryLevel.Remove(RuntimeHelpers.GetObjectValue(MyObjs[i]));
					HistoryLevel.Add(RuntimeHelpers.GetObjectValue(MyObjs[i]));
					NewLateBinding.LateCall(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (Operators.CompareString(kuda, "на задний план", false) == 0)
			{
				for (int i = MyObjs.Length - 1; i >= 0; i += -1)
				{
					HistoryLevel.Remove(RuntimeHelpers.GetObjectValue(MyObjs[i]));
					HistoryLevel.Insert(0, RuntimeHelpers.GetObjectValue(MyObjs[i]));
					NewLateBinding.LateCall(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendToBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else
			{
				if (Conversions.ToDouble(kuda) == -1.0)
				{
					return;
				}
				for (int i = MyObjs.Length - 1; i >= 0; i += -1)
				{
					HistoryLevel.Remove(RuntimeHelpers.GetObjectValue(MyObjs[i]));
					if (Conversions.ToDouble(kuda) < (double)HistoryLevel.Count)
					{
						HistoryLevel.Insert(Conversions.ToInteger(kuda), RuntimeHelpers.GetObjectValue(MyObjs[i]));
						for (int j = Conversions.ToInteger(kuda); j >= 0; j += -1)
						{
							NewLateBinding.LateCall(NewLateBinding.LateGet(HistoryLevel[j], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendToBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						}
					}
					else
					{
						HistoryLevel.Add(RuntimeHelpers.GetObjectValue(MyObjs[i]));
						NewLateBinding.LateCall(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
				}
			}
		}
	}

	public void AddActiveObject(object MyObj, bool noRefresh = false)
	{
		checked
		{
			if (ActiveObj == null)
			{
				ActiveObj = (object[])Utils.CopyArray((Array)ActiveObj, (Array)new object[1]);
				ActiveObj[0] = RuntimeHelpers.GetObjectValue(MyObj);
			}
			else if (Array.IndexOf<object>(ActiveObj, RuntimeHelpers.GetObjectValue(MyObj)) != -1)
			{
				object[] array = null;
				int num = ActiveObj.Length - 1;
				int num2 = default(int);
				for (int i = 0; i <= num; i++)
				{
					if (ActiveObj[i] != MyObj)
					{
						array = (object[])Utils.CopyArray((Array)array, (Array)new object[num2 + 1]);
						array[num2] = RuntimeHelpers.GetObjectValue(ActiveObj[i]);
						num2++;
					}
				}
				if (array == null)
				{
					ClearActiveObject();
					return;
				}
				ActiveObj = new object[array.Length - 1 + 1];
				ActiveObj = array;
			}
			else
			{
				int num3 = ActiveObj.Length;
				ActiveObj = (object[])Utils.CopyArray((Array)ActiveObj, (Array)new object[num3 + 1]);
				ActiveObj[num3] = RuntimeHelpers.GetObjectValue(MyObj);
			}
			if (!noRefresh)
			{
				FillListView();
			}
		}
	}

	public void ClearActiveObject()
	{
		ActiveObj = null;
		FillListView();
	}

	public void SetActiveObject(object MyObj, bool onlySelect = false)
	{
		if (!(((Control)peremens2.ProgressForm).get_Visible() & (peremens2.ProgressForm.ProgressBarValue < 70)))
		{
			ActiveObj = (object[])Utils.CopyArray((Array)ActiveObj, (Array)new object[1]);
			ActiveObj[0] = RuntimeHelpers.GetObjectValue(MyObj);
			FillListView(onlySelect);
		}
	}

	public bool IsActiveObject(object MyObj)
	{
		if (ActiveObj == null)
		{
			return false;
		}
		if (Array.IndexOf<object>(ActiveObj, RuntimeHelpers.GetObjectValue(MyObj)) == -1)
		{
			return false;
		}
		return true;
	}

	public bool inRectangle(object obj, Point na4Point, Point endPoint)
	{
		int x;
		int x2;
		if (na4Point.X < endPoint.X)
		{
			x = na4Point.X;
			x2 = endPoint.X;
		}
		else
		{
			x = endPoint.X;
			x2 = na4Point.X;
		}
		int y;
		int y2;
		if (na4Point.Y < endPoint.Y)
		{
			y = na4Point.Y;
			y2 = endPoint.Y;
		}
		else
		{
			y = endPoint.Y;
			y2 = na4Point.Y;
		}
		if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreater(Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(obj, (Type)null, "width", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)x, false), Operators.CompareObjectLess(NewLateBinding.LateGet(obj, (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null), (object)x2, false)), Operators.AndObject(Operators.CompareObjectGreater(Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "top", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(obj, (Type)null, "height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)y, false), Operators.CompareObjectLess(NewLateBinding.LateGet(obj, (Type)null, "top", new object[0], (string[])null, (Type[])null, (bool[])null), (object)y2, false)))))
		{
			return true;
		}
		return false;
	}

	public Point ContenerAbsXY(object MyObj)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null));
		int num = 0;
		int num2 = 0;
		if (MyObj == null)
		{
			return new Point(num, num2);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
		{
			if (Operators.CompareString(objectValue.GetType().ToString(), "System.Windows.Forms.SplitterPanel", false) == 0)
			{
				num = Conversions.ToInteger(Operators.AddObject((object)num, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null), peremens.markerX)));
				num2 = Conversions.ToInteger(Operators.AddObject((object)num2, Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterDistance", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterRectangle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)1)));
			}
			else
			{
				num = Conversions.ToInteger(Operators.AddObject((object)num, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null), peremens.markerX)));
				num2 = Conversions.ToInteger(Operators.AddObject((object)num2, Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterDistance", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterRectangle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)1)));
			}
		}
		else
		{
			object objectValue2 = RuntimeHelpers.GetObjectValue(MyObj);
			while (objectValue != null)
			{
				if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
				{
					if (Operators.CompareString(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "DP", false) == 0)
					{
						object obj = num;
						object obj2 = NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array = new object[1];
						object[] array2 = array;
						object obj3 = objectValue2;
						array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array3 = array;
						object[] array4 = array3;
						bool[] array5 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet(obj2, (Type)null, "ParentPanelLeft", array4, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							NewLateBinding.LateSetComplex(obj3, (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
						}
						num = Conversions.ToInteger(Operators.AddObject(obj, obj4));
						object obj5 = num2;
						object obj6 = NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array6 = new object[1];
						object[] array7 = array6;
						obj3 = objectValue2;
						array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
						array3 = array6;
						object[] array8 = array3;
						array5 = new bool[1] { true };
						object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "ParentPanelTop", array8, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							NewLateBinding.LateSetComplex(obj3, (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
						}
						num2 = Conversions.ToInteger(Operators.AddObject(obj5, obj7));
					}
					else
					{
						num = Conversions.ToInteger(Operators.AddObject((object)num, NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null)));
						num2 = Conversions.ToInteger(Operators.AddObject((object)num2, NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null)));
					}
					objectValue2 = RuntimeHelpers.GetObjectValue(objectValue);
					objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null));
					continue;
				}
				try
				{
					num = Conversions.ToInteger(Operators.AddObject((object)num, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null), peremens.markerX)));
					num2 = Conversions.ToInteger(Operators.AddObject((object)num2, Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterDistance", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterRectangle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)1)));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					i = RuntimeHelpers.GetObjectValue(i);
					ProjectData.ClearProjectError();
				}
				break;
			}
		}
		return new Point(num, num2);
	}

	public void marker_vis(bool vis = true)
	{
		if (((Control)peremens2.ProgressForm).get_Visible())
		{
			peremens.fromIzmenenieBylo = false;
			return;
		}
		checked
		{
			if (MyObjs != null)
			{
				int num = MyObjs.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "markers", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int j = 0; j <= num2; j++)
					{
						if (!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false), (object)(j == 8)), (object)(j == 9))))
						{
							continue;
						}
						object obj = MyObjs[i];
						object[] array = new object[1] { j };
						object[] array2 = array;
						bool[] array3 = new bool[1] { true };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, "markers", array2, (string[])null, (Type[])null, array3);
						if (array3[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
						}
						if (obj2 != null)
						{
							object obj3 = MyObjs[i];
							object[] array4 = new object[1] { j };
							object[] array5 = array4;
							bool[] array6 = new bool[1] { true };
							object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "markers", array5, (string[])null, (Type[])null, array6);
							if (array6[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
							}
							NewLateBinding.LateSetComplex(obj4, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
						}
					}
				}
			}
			if (ActiveObj == null || ActiveObj[0] == null)
			{
				return;
			}
			if (vis)
			{
				int num3 = ActiveObj.Length - 1;
				object[] mass = default(object[]);
				for (int i = 0; i <= num3; i++)
				{
					Point point = ContenerAbsXY(RuntimeHelpers.GetObjectValue(ActiveObj[i]));
					object obj5 = ActiveObj[i];
					int num4 = 0;
					int num5 = 0;
					if (NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null) == null)
					{
						continue;
					}
					if (Iz.IsMMs(RuntimeHelpers.GetObjectValue(ActiveObj[i])))
					{
						MMs mMs = (MMs)NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OwnerItem", new object[0], (string[])null, (Type[])null, (bool[])null);
						if (mMs != null)
						{
							while (mMs != null)
							{
								peremens.ReDimsO(ref mass);
								mass[mass.Length - 1] = mMs;
								mMs = (MMs)(object)((ToolStripItem)mMs).get_OwnerItem();
							}
							for (int j = mass.Length - 1; j >= 0; j += -1)
							{
								NewLateBinding.LateCall(mass[j], (Type)null, "ShowDropDown", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							}
							mMs = (MMs)mass[0];
							num4 = Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject((object)mMs.DropLocation.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ToolStripContainer1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LeftToolStripPanel", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null)));
							num5 = Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject((object)mMs.DropLocation.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ToolStripContainer1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TopToolStripPanel", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)tab).get_Bounds().Y), NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "PreferredSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null)));
						}
						else if (Iz.IsCM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null))))
						{
							object obj6 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(ActiveObj[i], (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CnMn", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array = new object[3];
							object[] array7 = array;
							object[] activeObj = ActiveObj;
							int num6 = i;
							object obj7 = activeObj[num6];
							object[] array8 = new object[0];
							object[] array9 = array8;
							string[] array10 = null;
							array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "conteiner", array9, array10, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
							object[] array11 = array;
							object[] activeObj2 = ActiveObj;
							int num7 = i;
							object obj8 = activeObj2[num7];
							object[] array4 = new object[0];
							object[] array12 = array4;
							string[] array13 = null;
							array11[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "conteiner", array12, array13, (Type[])null, (bool[])null), (Type)null, "dx", new object[0], (string[])null, (Type[])null, (bool[])null));
							object[] array14 = array;
							object[] activeObj3 = ActiveObj;
							int num8 = i;
							object obj9 = activeObj3[num8];
							object[] array15 = new object[0];
							object[] array16 = array15;
							string[] array17 = null;
							array14[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "conteiner", array16, array17, (Type[])null, (bool[])null), (Type)null, "dy", new object[0], (string[])null, (Type[])null, (bool[])null));
							object[] array18 = array;
							object[] array19 = array18;
							bool[] array6 = new bool[3] { true, true, true };
							NewLateBinding.LateCall(obj6, (Type)null, "Show", array19, (string[])null, (Type[])null, array6, true);
							if (array6[0])
							{
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(ActiveObj[num6], (Type)null, "conteiner", array8, array10, (Type[])null, (bool[])null), (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array18[0]) }, (string[])null, (Type[])null, true, true);
							}
							if (array6[1])
							{
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(ActiveObj[num7], (Type)null, "conteiner", array4, array13, (Type[])null, (bool[])null), (Type)null, "dx", new object[1] { RuntimeHelpers.GetObjectValue(array18[1]) }, (string[])null, (Type[])null, true, true);
							}
							if (array6[2])
							{
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(ActiveObj[num8], (Type)null, "conteiner", array15, array17, (Type[])null, (bool[])null), (Type)null, "dy", new object[1] { RuntimeHelpers.GetObjectValue(array18[2]) }, (string[])null, (Type[])null, true, true);
							}
							if (NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "owner", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
							{
								num4 = Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "owner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MousePosition", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(ActiveObj[i], (Type)null, "dx", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ToolStripContainer1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LeftToolStripPanel", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null)));
								num5 = Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "owner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MousePosition", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "y", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(ActiveObj[i], (Type)null, "dy", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.MultiplyObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "height", new object[0], (string[])null, (Type[])null, (bool[])null))), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ToolStripContainer1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TopToolStripPanel", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)tab).get_Bounds().Y), NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "PreferredSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null)));
							}
						}
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.SubtractObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), peremens.markerX) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.SubtractObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), peremens.markerY) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.AddObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), peremens.markerX), (object)2)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.SubtractObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), peremens.markerY) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.AddObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.SubtractObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), peremens.markerY) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.SubtractObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), peremens.markerX) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 3 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.AddObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), peremens.markerY), (object)2)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.SubtractObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), peremens.markerX) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 5 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.AddObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.AddObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 4 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.AddObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), peremens.markerY), (object)2)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.AddObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), peremens.markerX), (object)2)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 6 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.AddObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 7 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.AddObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 7 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.AddObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 8 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.AddObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), peremens.markerX) }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 8 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.SubtractObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "y", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.MultiplyObject(peremens.markerY, (object)1.5)) }, (string[])null, (Type[])null, false, true);
					if (num4 == 0)
					{
						if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 9 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.SubtractObject(Operators.AddObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.MultiplyObject(peremens.markerX, (object)2.5)) }, (string[])null, (Type[])null, false, true);
						}
						else
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 9 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.SubtractObject(Operators.AddObject(Operators.AddObject((object)point.X, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.MultiplyObject(peremens.markerX, (object)0.5)) }, (string[])null, (Type[])null, false, true);
						}
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 9 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.SubtractObject(Operators.AddObject((object)point.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.MultiplyObject(peremens.markerY, (object)1.5)) }, (string[])null, (Type[])null, false, true);
					}
					else
					{
						if (Iz.isNoMove(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 8 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.SubtractObject(Operators.SubtractObject((object)num4, Operators.MultiplyObject(peremens.markerX, (object)2.5)), (object)3) }, (string[])null, (Type[])null, false, true);
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 8 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.SubtractObject(Operators.AddObject((object)num5, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "y", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.MultiplyObject(peremens.markerY, (object)1.5)) }, (string[])null, (Type[])null, false, true);
						}
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 9 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject((object)num4, NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), peremens.markerX), (object)2) }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 9 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.SubtractObject(Operators.AddObject((object)num5, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)), Operators.MultiplyObject(peremens.markerY, (object)1.5)) }, (string[])null, (Type[])null, false, true);
					}
					if (!Iz.isNoSizeChange(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
					{
						int num9 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
						for (int j = 0; j <= num9; j++)
						{
							if (j != 9 && unchecked(Operators.CompareString(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "F", false) != 0 || j == 4 || j == 6 || j == 7))
							{
								object obj10 = obj5;
								object[] array20 = new object[1] { j };
								object[] array21 = array20;
								bool[] array6 = new bool[1] { true };
								object obj11 = NewLateBinding.LateGet(obj10, (Type)null, "markers", array21, (string[])null, (Type[])null, array6);
								if (array6[0])
								{
									j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array20[0]), typeof(int));
								}
								NewLateBinding.LateSetComplex(obj11, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
								object obj12 = obj5;
								array20 = new object[1] { j };
								object[] array22 = array20;
								array6 = new bool[1] { true };
								object obj13 = NewLateBinding.LateGet(obj12, (Type)null, "markers", array22, (string[])null, (Type[])null, array6);
								if (array6[0])
								{
									j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array20[0]), typeof(int));
								}
								NewLateBinding.LateCall(obj13, (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							}
						}
					}
					else
					{
						if (!Iz.isNoMove(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 8 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
						}
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 8 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateCall(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 8 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					if (Iz.isHavePlusik(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 9 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateCall(NewLateBinding.LateGet(obj5, (Type)null, "markers", new object[1] { 9 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					obj5 = null;
				}
			}
			peremens.fromIzmenenieBylo = false;
		}
	}

	public bool ExistIndex(object obj, string name, string ind)
	{
		object objectValue;
		object[] array;
		bool[] array3;
		object[] array4;
		if (obj == null)
		{
			object obj2 = proj;
			array = new object[1] { name };
			object[] array2 = array;
			array3 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "GetMyAllFromName", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			objectValue = RuntimeHelpers.GetObjectValue(obj3);
			if (objectValue == null)
			{
				return false;
			}
			objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, (string[])null));
		}
		else
		{
			if (proj == null)
			{
				return false;
			}
			object obj4 = proj;
			array4 = new object[1] { RuntimeHelpers.GetObjectValue(obj) };
			object[] array5 = array4;
			array3 = new bool[1] { true };
			object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "GetMyObjFromObj", array5, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				obj = RuntimeHelpers.GetObjectValue(array4[0]);
			}
			objectValue = RuntimeHelpers.GetObjectValue(obj5);
		}
		if (objectValue == null)
		{
			return false;
		}
		object obj6 = proj;
		object[] array6 = new object[1];
		object[] array7 = array6;
		object obj7 = objectValue;
		array = new object[0];
		object[] array8 = array;
		string[] array9 = null;
		object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "GetMyForm", array8, array9, (Type[])null, (bool[])null);
		array4 = new object[0];
		object[] array10 = array4;
		string[] array11 = null;
		object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "obj", array10, array11, (Type[])null, (bool[])null);
		object[] array12 = new object[0];
		object[] array13 = array12;
		string[] array14 = null;
		array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "Props", array13, array14, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array15 = array6;
		object[] array16 = array15;
		array3 = new bool[1] { true };
		object obj10 = NewLateBinding.LateGet(obj6, (Type)null, "GetMyFormsFromName", array16, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "GetMyForm", array, array9, (Type[])null, (bool[])null), (Type)null, "obj", array4, array11, (Type[])null, (bool[])null), (Type)null, "Props", array12, array14, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array15[0]) }, (string[])null, (Type[])null, true, true);
		}
		object[] array17 = (object[])obj10;
		if (array17 == null)
		{
			array17 = new object[1] { this };
		}
		checked
		{
			int num = array17.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (array17[num2] != null)
					{
						if (NewLateBinding.LateGet(array17[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null) != obj && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(array17[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)name, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(array17[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)ind, false))))
						{
							break;
						}
						if (NewLateBinding.LateGet(array17[num2], (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
						{
							int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(array17[num2], (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
							for (int i = 0; i <= num3; i++)
							{
								object obj11 = array17[num2];
								array15 = new object[1] { i };
								object[] array18 = array15;
								array3 = new bool[1] { true };
								object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "MyObjs", array18, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(int));
								}
								if (NewLateBinding.LateGet(obj12, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null) != obj)
								{
									object obj13 = array17[num2];
									array12 = new object[1] { i };
									object[] array19 = array12;
									bool[] array20 = new bool[1] { true };
									object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "MyObjs", array19, (string[])null, (Type[])null, array20);
									if (array20[0])
									{
										i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
									}
									object obj15 = Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj14, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)name, false);
									object obj16 = array17[num2];
									array4 = new object[1] { i };
									object[] array21 = array4;
									bool[] array22 = new bool[1] { true };
									object obj17 = NewLateBinding.LateGet(obj16, (Type)null, "MyObjs", array21, (string[])null, (Type[])null, array22);
									if (array22[0])
									{
										i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
									}
									if (Conversions.ToBoolean(Operators.AndObject(obj15, Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj17, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)ind, false))))
									{
										return true;
									}
								}
							}
						}
					}
					num2++;
					continue;
				}
				return false;
			}
			return true;
		}
	}

	public void CreateMassive(string name, params object[] MyObjs)
	{
		if (MyObjs == null)
		{
			return;
		}
		if (Operators.CompareString(name, "", false) == 0)
		{
			name = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[0], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		object obj = proj;
		object[] array = new object[1] { MyObjs };
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetSortMyObjsByFormsLast", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			MyObjs = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(object[]));
		}
		MyObjs = (object[])obj2;
		checked
		{
			int num = MyObjs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				recur = false;
				if (i > 0)
				{
					NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
				}
				else
				{
					NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Reverses", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
				}
				string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
				object obj3 = NewLateBinding.LateGet(MyObjs[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				array = new object[3]
				{
					peremens.trans("Номер"),
					GetIndex(name),
					null
				};
				object[] array4 = array;
				object[] array5 = MyObjs;
				int num2 = i;
				array4[2] = RuntimeHelpers.GetObjectValue(array5[num2]);
				object[] array6 = array;
				object[] array7 = array6;
				array3 = new bool[3] { false, false, true };
				NewLateBinding.LateCall(obj3, (Type)null, "SetPropertys", array7, (string[])null, (Type[])null, array3, true);
				if (array3[2])
				{
					MyObjs[num2] = RuntimeHelpers.GetObjectValue(array6[2]);
				}
				NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
				string text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
				object obj4 = NewLateBinding.LateGet(MyObjs[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				array = new object[3]
				{
					peremens.trans("Имя"),
					name,
					null
				};
				object[] array8 = array;
				object[] array9 = MyObjs;
				num2 = i;
				array8[2] = RuntimeHelpers.GetObjectValue(array9[num2]);
				array6 = array;
				object[] array10 = array6;
				array3 = new bool[3] { false, true, true };
				NewLateBinding.LateCall(obj4, (Type)null, "SetPropertys", array10, (string[])null, (Type[])null, array3, true);
				if (array3[1])
				{
					name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[1]), typeof(string));
				}
				if (array3[2])
				{
					MyObjs[num2] = RuntimeHelpers.GetObjectValue(array6[2]);
				}
				NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
				if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObjs[i])))
				{
					object obj5 = proj;
					object[] array11 = new object[4]
					{
						"Изменение свойства",
						text2 + "." + text2 + "[" + text + "]." + peremens.trans("Номер"),
						null,
						null
					};
					object[] array12 = array11;
					object[] array13 = MyObjs;
					num2 = i;
					object obj6 = array13[num2];
					array = new object[0];
					object[] array14 = array;
					string[] array15 = null;
					object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "obj", array14, array15, (Type[])null, (bool[])null);
					array6 = new object[0];
					object[] array16 = array6;
					string[] array17 = null;
					array12[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "Props", array16, array17, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
					array11[3] = text;
					object[] array18 = array11;
					object[] array19 = array18;
					array3 = new bool[4] { false, false, true, true };
					NewLateBinding.LateCall(obj5, (Type)null, "UndoRedo", array19, (string[])null, (Type[])null, array3, true);
					if (array3[2])
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[num2], (Type)null, "obj", array, array15, (Type[])null, (bool[])null), (Type)null, "Props", array6, array17, (Type[])null, (bool[])null), (Type)null, "index", new object[1] { RuntimeHelpers.GetObjectValue(array18[2]) }, (string[])null, (Type[])null, true, true);
					}
					if (array3[3])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array18[3]), typeof(string));
					}
				}
				else
				{
					object obj8 = proj;
					object[] array11 = new object[4]
					{
						"Изменение свойства",
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"."), (object)text2), (object)"["), (object)text), (object)"]"), (object)"."), (object)peremens.trans("Номер")),
						null,
						null
					};
					object[] array20 = array11;
					object[] array21 = MyObjs;
					num2 = i;
					object obj9 = array21[num2];
					object[] array22 = new object[0];
					object[] array23 = array22;
					string[] array17 = null;
					object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "obj", array23, array17, (Type[])null, (bool[])null);
					object[] array18 = new object[0];
					object[] array24 = array18;
					string[] array15 = null;
					array20[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj10, (Type)null, "Props", array24, array15, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
					array11[3] = text;
					array = array11;
					object[] array25 = array;
					array3 = new bool[4] { false, false, true, true };
					NewLateBinding.LateCall(obj8, (Type)null, "UndoRedo", array25, (string[])null, (Type[])null, array3, true);
					if (array3[2])
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[num2], (Type)null, "obj", array22, array17, (Type[])null, (bool[])null), (Type)null, "Props", array18, array15, (Type[])null, (bool[])null), (Type)null, "index", new object[1] { RuntimeHelpers.GetObjectValue(array[2]) }, (string[])null, (Type[])null, true, true);
					}
					if (array3[3])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[3]), typeof(string));
					}
				}
				NewLateBinding.LateCall(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			FillListView();
			if (peremens2.CreateDs != null)
			{
				NewLateBinding.LateCall(peremens2.CreateDs, (Type)null, "SetProperty", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	public void CreatePodMassive(object obj, params object[] MyObj)
	{
		if (MyObjs == null)
		{
			return;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(GetMassiveobjectFromObjs(RuntimeHelpers.GetObjectValue(obj), MyObj));
		if (objectValue == null)
		{
			return;
		}
		string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		string text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
		string text3 = Conversions.ToString(1);
		object obj2 = proj;
		object[] array = new object[1] { text };
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "GetMyAllFromName", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object[] array4 = (object[])obj3;
		if (array4 == null)
		{
			return;
		}
		checked
		{
			int num = array4.Length - 1;
			int num3 = default(int);
			for (int i = 0; i <= num; i++)
			{
				int num2 = MyObj.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (NewLateBinding.LateGet(MyObj[j], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null) == NewLateBinding.LateGet(array4[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))
					{
						num3 = 1;
						break;
					}
				}
				if (num3 == 0)
				{
					NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Revers Undo", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
					object obj4 = NewLateBinding.LateGet(array4[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
					array = new object[3]
					{
						peremens.trans("Номер"),
						Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(array4[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)",1"),
						null
					};
					object[] array5 = array;
					int num4 = i;
					array5[2] = RuntimeHelpers.GetObjectValue(array4[num4]);
					object[] array6 = array;
					object[] array7 = array6;
					array3 = new bool[3] { false, false, true };
					NewLateBinding.LateCall(obj4, (Type)null, "SetPropertys", array7, (string[])null, (Type[])null, array3, true);
					if (array3[2])
					{
						array4[num4] = RuntimeHelpers.GetObjectValue(array6[2]);
					}
					NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(NewLateBinding.LateGet(array4[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				num3 = 0;
			}
			int num5 = MyObj.Length - 1;
			for (int i = 0; i <= num5; i++)
			{
				object obj5 = NewLateBinding.LateGet(MyObj[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				array = new object[3]
				{
					peremens.trans("Номер"),
					text2 + "," + text3,
					null
				};
				object[] array8 = array;
				int num4 = i;
				array8[2] = RuntimeHelpers.GetObjectValue(MyObj[num4]);
				object[] array6 = array;
				object[] array9 = array6;
				array3 = new bool[3] { false, false, true };
				NewLateBinding.LateCall(obj5, (Type)null, "SetPropertys", array9, (string[])null, (Type[])null, array3, true);
				if (array3[2])
				{
					MyObj[num4] = RuntimeHelpers.GetObjectValue(array6[2]);
				}
				NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
				text3 = Conversions.ToString(Conversions.ToDouble(text3) + 1.0);
				object obj6 = NewLateBinding.LateGet(MyObj[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				array = new object[3]
				{
					peremens.trans("Имя"),
					text,
					null
				};
				object[] array10 = array;
				num4 = i;
				array10[2] = RuntimeHelpers.GetObjectValue(MyObj[num4]);
				array6 = array;
				object[] array11 = array6;
				array3 = new bool[3] { false, true, true };
				NewLateBinding.LateCall(obj6, (Type)null, "SetPropertys", array11, (string[])null, (Type[])null, array3, true);
				if (array3[1])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[1]), typeof(string));
				}
				if (array3[2])
				{
					MyObj[num4] = RuntimeHelpers.GetObjectValue(array6[2]);
				}
				if (i < MyObj.Length - 1)
				{
					NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
				}
				NewLateBinding.LateCall(NewLateBinding.LateGet(MyObj[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			FillListView();
			if (peremens2.CreateDs != null)
			{
				NewLateBinding.LateCall(peremens2.CreateDs, (Type)null, "SetProperty", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	public void UnitedPodMassive(object obj, params object[] MyObj)
	{
		if (MyObjs == null)
		{
			return;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(GetMassiveobjectFromObjs(RuntimeHelpers.GetObjectValue(obj), MyObj));
		if (objectValue == null || Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "split", new object[1] { "," }, (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
		{
			return;
		}
		string text = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		string text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Substring", new object[2]
		{
			0,
			Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)
		}, (string[])null, (Type[])null, (bool[])null));
		checked
		{
			int num = MyObj.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (i > 0)
				{
					NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
				}
				else
				{
					NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Revers Undo", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
				}
				object obj2 = NewLateBinding.LateGet(MyObj[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[3]
				{
					peremens.trans("Номер"),
					GetIndex(text, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null)), text2 + "1"),
					null
				};
				object[] array2 = array;
				int num2 = i;
				array2[2] = RuntimeHelpers.GetObjectValue(MyObj[num2]);
				object[] array3 = array;
				object[] array4 = array3;
				bool[] array5 = new bool[3] { false, false, true };
				NewLateBinding.LateCall(obj2, (Type)null, "SetPropertys", array4, (string[])null, (Type[])null, array5, true);
				if (array5[2])
				{
					MyObj[num2] = RuntimeHelpers.GetObjectValue(array3[2]);
				}
				NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
				object obj3 = NewLateBinding.LateGet(MyObj[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				array3 = new object[3]
				{
					peremens.trans("Имя"),
					text,
					null
				};
				object[] array6 = array3;
				num2 = i;
				array6[2] = RuntimeHelpers.GetObjectValue(MyObj[num2]);
				array = array3;
				object[] array7 = array;
				array5 = new bool[3] { false, true, true };
				NewLateBinding.LateCall(obj3, (Type)null, "SetPropertys", array7, (string[])null, (Type[])null, array5, true);
				if (array5[1])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
				if (array5[2])
				{
					MyObj[num2] = RuntimeHelpers.GetObjectValue(array[2]);
				}
				NewLateBinding.LateCall(NewLateBinding.LateGet(MyObj[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			FillListView();
			if (peremens2.CreateDs != null)
			{
				NewLateBinding.LateCall(peremens2.CreateDs, (Type)null, "SetProperty", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	public object GetMassiveobjectFromObjs(object MainObj, params object[] MyObj)
	{
		string[] allMassives = GetAllMassives();
		if (Array.IndexOf((Array)allMassives, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(MainObj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null))) != -1)
		{
			return MainObj;
		}
		checked
		{
			int num = MyObj.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (Array.IndexOf((Array)allMassives, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null))) != -1)
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return NewLateBinding.LateGet(MyObj[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null);
		}
	}

	public object GetObjsFromMyObjs(params object[] MyObjs)
	{
		object[] array = null;
		int num = 0;
		checked
		{
			int num2 = MyObjs.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				array = (object[])Utils.CopyArray((Array)array, (Array)new object[num + 1]);
				array[num] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
				num++;
			}
			return array;
		}
	}

	public void MassiveSelect(object obj, string index = "")
	{
		if (MyObjs == null)
		{
			return;
		}
		checked
		{
			int num = MyObjs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), false), (object)(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null) != obj))))
				{
					object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array = new object[1] { index };
					bool[] array2 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "indexof", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						index = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)0, false) && (!IsActiveObject(RuntimeHelpers.GetObjectValue(MyObjs[i])) | ctrl))
					{
						AddActiveObject(RuntimeHelpers.GetObjectValue(MyObjs[i]), noRefresh: true);
					}
				}
			}
			FillListView();
			marker_vis();
		}
	}

	public void MassiveExecute(object[] Myobj)
	{
		if (Myobj == null)
		{
			return;
		}
		object obj = proj;
		object[] array = new object[1] { Myobj };
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetSortMyObjsByFormsLast", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			Myobj = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(object[]));
		}
		Myobj = (object[])obj2;
		checked
		{
			int num = Myobj.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				object obj3 = proj;
				object[] array4 = new object[2];
				object[] array5 = array4;
				object[] array6 = Myobj;
				int num2 = i;
				object obj4 = array6[num2];
				array = new object[0];
				object[] array7 = array;
				string[] array8 = null;
				object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "obj", array7, array8, (Type[])null, (bool[])null);
				object[] array9 = new object[0];
				object[] array10 = array9;
				string[] array11 = null;
				array5[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "Props", array10, array11, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
				object[] array12 = array4;
				object[] array13 = Myobj;
				int num3 = i;
				array12[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array13[num3], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
				object[] array14 = array4;
				object[] array15 = array14;
				array3 = new bool[2] { true, true };
				object obj6 = NewLateBinding.LateGet(obj3, (Type)null, "ExistName", array15, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[num2], (Type)null, "obj", array, array8, (Type[])null, (bool[])null), (Type)null, "Props", array9, array11, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array14[0]) }, (string[])null, (Type[])null, true, true);
				}
				if (array3[1])
				{
					NewLateBinding.LateSetComplex(Myobj[num3], (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array14[1]) }, (string[])null, (Type[])null, true, false);
				}
				if (Conversions.ToBoolean(obj6))
				{
					if (i > 0)
					{
						NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
					}
					else
					{
						NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Reverses", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
					}
					string uNameObj = peremens.GetUNameObj(RuntimeHelpers.GetObjectValue(Myobj[i]));
					object[] array56;
					object[] array16;
					string[] array43;
					string[] array40;
					object[] array41;
					object[] array25;
					bool[] array27;
					object[] array50;
					int num4;
					object[] array44;
					bool[] array46;
					if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(Myobj[i])))
					{
						object obj7 = proj;
						array16 = new object[4] { "Изменение свойства", null, null, null };
						object[] array17 = array16;
						object obj8 = proj;
						object[] array18 = new object[1];
						object[] array19 = array18;
						object[] array20 = Myobj;
						num2 = i;
						object obj9 = array20[num2];
						array = new object[0];
						object[] array21 = array;
						string[] array22 = null;
						object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "obj", array21, array22, (Type[])null, (bool[])null);
						array9 = new object[0];
						object[] array23 = array9;
						string[] array24 = null;
						array19[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj10, (Type)null, "Props", array23, array24, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
						array25 = array18;
						object[] array26 = array25;
						array27 = new bool[1] { true };
						object obj11 = NewLateBinding.LateGet(obj8, (Type)null, "GiveName", array26, (string[])null, (Type[])null, array27);
						if (array27[0])
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[num2], (Type)null, "obj", array, array22, (Type[])null, (bool[])null), (Type)null, "Props", array9, array24, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array25[0]) }, (string[])null, (Type[])null, true, true);
						}
						object obj12 = Operators.ConcatenateObject(obj11, (object)".");
						object obj13 = proj;
						object[] array28 = new object[1];
						object[] array29 = array28;
						object[] array30 = Myobj;
						num3 = i;
						object obj14 = array30[num3];
						object[] array31 = new object[0];
						object[] array32 = array31;
						array11 = null;
						object obj15 = NewLateBinding.LateGet(obj14, (Type)null, "obj", array32, array11, (Type[])null, (bool[])null);
						object[] array33 = new object[0];
						object[] array34 = array33;
						array8 = null;
						array29[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj15, (Type)null, "Props", array34, array8, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
						array14 = array28;
						object[] array35 = array14;
						array3 = new bool[1] { true };
						object obj16 = NewLateBinding.LateGet(obj13, (Type)null, "GiveName", array35, (string[])null, (Type[])null, array3);
						if (array3[0])
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[num3], (Type)null, "obj", array31, array11, (Type[])null, (bool[])null), (Type)null, "Props", array33, array8, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array14[0]) }, (string[])null, (Type[])null, true, true);
						}
						array17[1] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj12, obj16), (object)"["), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"]"), (object)"."), (object)peremens.trans("Номер"));
						array16[2] = "0";
						object[] array36 = array16;
						object[] array37 = Myobj;
						num4 = i;
						object obj17 = array37[num4];
						object[] array38 = new object[0];
						object[] array39 = array38;
						array40 = null;
						object obj18 = NewLateBinding.LateGet(obj17, (Type)null, "obj", array39, array40, (Type[])null, (bool[])null);
						array41 = new object[0];
						object[] array42 = array41;
						array43 = null;
						array36[3] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj18, (Type)null, "Props", array42, array43, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
						array44 = array16;
						object[] array45 = array44;
						array46 = new bool[4] { false, false, false, true };
						NewLateBinding.LateCall(obj7, (Type)null, "UndoRedo", array45, (string[])null, (Type[])null, array46, true);
						if (array46[3])
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[num4], (Type)null, "obj", array38, array40, (Type[])null, (bool[])null), (Type)null, "Props", array41, array43, (Type[])null, (bool[])null), (Type)null, "index", new object[1] { RuntimeHelpers.GetObjectValue(array44[3]) }, (string[])null, (Type[])null, true, true);
						}
					}
					else
					{
						object obj19 = proj;
						object[] array18 = new object[4] { "Изменение свойства", null, null, null };
						object[] array47 = array18;
						object obj20 = Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[i], (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)".");
						object obj21 = proj;
						array16 = new object[1];
						object[] array48 = array16;
						object[] array49 = Myobj;
						num4 = i;
						object obj22 = array49[num4];
						array50 = new object[0];
						object[] array51 = array50;
						array43 = null;
						object obj23 = NewLateBinding.LateGet(obj22, (Type)null, "obj", array51, array43, (Type[])null, (bool[])null);
						array44 = new object[0];
						object[] array52 = array44;
						array40 = null;
						array48[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj23, (Type)null, "Props", array52, array40, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
						array41 = array16;
						object[] array53 = array41;
						array46 = new bool[1] { true };
						object obj24 = NewLateBinding.LateGet(obj21, (Type)null, "GiveName", array53, (string[])null, (Type[])null, array46);
						if (array46[0])
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[num4], (Type)null, "obj", array50, array43, (Type[])null, (bool[])null), (Type)null, "Props", array44, array40, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array41[0]) }, (string[])null, (Type[])null, true, true);
						}
						array47[1] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj20, obj24), (object)"["), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"]"), (object)"."), (object)peremens.trans("Номер"));
						array18[2] = "0";
						object[] array54 = array18;
						object[] array55 = Myobj;
						num3 = i;
						object obj25 = array55[num3];
						array56 = new object[0];
						object[] array57 = array56;
						string[] array24 = null;
						object obj26 = NewLateBinding.LateGet(obj25, (Type)null, "obj", array57, array24, (Type[])null, (bool[])null);
						array25 = new object[0];
						object[] array58 = array25;
						string[] array22 = null;
						array54[3] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj26, (Type)null, "Props", array58, array22, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array31 = array18;
						object[] array59 = array31;
						array27 = new bool[4] { false, false, false, true };
						NewLateBinding.LateCall(obj19, (Type)null, "UndoRedo", array59, (string[])null, (Type[])null, array27, true);
						if (array27[3])
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[num3], (Type)null, "obj", array56, array24, (Type[])null, (bool[])null), (Type)null, "Props", array25, array22, (Type[])null, (bool[])null), (Type)null, "index", new object[1] { RuntimeHelpers.GetObjectValue(array31[3]) }, (string[])null, (Type[])null, true, true);
						}
					}
					NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
					object obj27 = NewLateBinding.LateGet(Myobj[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
					array56 = new object[3]
					{
						peremens.trans("Имя"),
						null,
						null
					};
					object[] array60 = array56;
					object obj28 = proj;
					array16 = new object[1];
					object[] array61 = array16;
					object[] array62 = Myobj;
					num4 = i;
					object obj29 = array62[num4];
					array50 = new object[0];
					object[] array63 = array50;
					array43 = null;
					object obj30 = NewLateBinding.LateGet(obj29, (Type)null, "obj", array63, array43, (Type[])null, (bool[])null);
					array44 = new object[0];
					object[] array64 = array44;
					array40 = null;
					array61[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj30, (Type)null, "Props", array64, array40, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
					array41 = array16;
					object[] array65 = array41;
					array46 = new bool[1] { true };
					object obj31 = NewLateBinding.LateGet(obj28, (Type)null, "GiveName", array65, (string[])null, (Type[])null, array46);
					if (array46[0])
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[num4], (Type)null, "obj", array50, array43, (Type[])null, (bool[])null), (Type)null, "Props", array44, array40, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array41[0]) }, (string[])null, (Type[])null, true, true);
					}
					array60[1] = RuntimeHelpers.GetObjectValue(obj31);
					object[] array66 = array56;
					object[] array67 = Myobj;
					num3 = i;
					array66[2] = RuntimeHelpers.GetObjectValue(array67[num3]);
					array25 = array56;
					object[] array68 = array25;
					array27 = new bool[3] { false, true, true };
					NewLateBinding.LateCall(obj27, (Type)null, "SetPropertys", array68, (string[])null, (Type[])null, array27, true);
					if (array27[1])
					{
						NewLateBinding.LateSetComplex(obj28, (Type)null, "GiveName", new object[2]
						{
							RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[num4], (Type)null, "obj", array50, array43, (Type[])null, (bool[])null), (Type)null, "Props", array44, array40, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)),
							RuntimeHelpers.GetObjectValue(array25[1])
						}, (string[])null, (Type[])null, true, false);
					}
					if (array27[2])
					{
						Myobj[num3] = RuntimeHelpers.GetObjectValue(array25[2]);
					}
					NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
					object obj32 = NewLateBinding.LateGet(Myobj[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
					array50 = new object[4]
					{
						peremens.trans("Номер"),
						"0",
						uNameObj,
						null
					};
					object[] array69 = array50;
					object[] array70 = Myobj;
					num4 = i;
					array69[3] = RuntimeHelpers.GetObjectValue(array70[num4]);
					array44 = array50;
					object[] array71 = array44;
					array46 = new bool[4] { false, false, true, true };
					NewLateBinding.LateCall(obj32, (Type)null, "SetPropertys", array71, (string[])null, (Type[])null, array46, true);
					if (array46[2])
					{
						uNameObj = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array44[2]), typeof(string));
					}
					if (array46[3])
					{
						Myobj[num4] = RuntimeHelpers.GetObjectValue(array44[3]);
					}
					NewLateBinding.LateCall(NewLateBinding.LateGet(Myobj[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Myobj[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
				{
					if (i > 0)
					{
						NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
					}
					else
					{
						NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Revers Undo", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
					}
					object obj33 = NewLateBinding.LateGet(Myobj[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array50 = new object[3]
					{
						peremens.trans("Номер"),
						0,
						null
					};
					object[] array72 = array50;
					object[] array73 = Myobj;
					int num4 = i;
					array72[2] = RuntimeHelpers.GetObjectValue(array73[num4]);
					object[] array44 = array50;
					object[] array74 = array44;
					bool[] array46 = new bool[3] { false, false, true };
					NewLateBinding.LateCall(obj33, (Type)null, "SetPropertys", array74, (string[])null, (Type[])null, array46, true);
					if (array46[2])
					{
						Myobj[num4] = RuntimeHelpers.GetObjectValue(array44[2]);
					}
					NewLateBinding.LateCall(NewLateBinding.LateGet(Myobj[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			FillListView();
			if (peremens2.CreateDs != null)
			{
				NewLateBinding.LateCall(peremens2.CreateDs, (Type)null, "SetProperty", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	public string GetIndex(string name, object obj = null, string ind = "1")
	{
		int i = 1;
		object obj2 = proj;
		object[] array = new object[1] { name };
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "GetMyAllFromName", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object[] array4 = (object[])obj3;
		if (array4 == null)
		{
			return ind;
		}
		checked
		{
			if (Operators.ConditionalCompareObjectLess((object)ind.Split(new char[1] { ',' }).Length, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(array4[0], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Split", new object[1] { "," }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				ind = "";
				int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(array4[0], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Split", new object[1] { "," }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2));
				for (int j = 0; j <= num; j++)
				{
					ind += ",1";
				}
				for (; ExistIndex(RuntimeHelpers.GetObjectValue(obj), name, Conversions.ToString(i) + ind); i++)
				{
				}
				return Conversions.ToString(i) + ind;
			}
			for (ind = ((ind.Split(new char[1] { ',' }).Length <= 1) ? "" : ind.Substring(0, ind.LastIndexOf(",") + 1)); ExistIndex(RuntimeHelpers.GetObjectValue(obj), name, ind + Conversions.ToString(i)); i++)
			{
			}
			return ind + Conversions.ToString(i);
		}
	}

	public string[] GetAllMassives()
	{
		string[] array = new string[1] { "" };
		if (MyObjs == null)
		{
			return null;
		}
		checked
		{
			int num = MyObjs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				object obj = proj;
				object[] array2 = new object[2];
				object[] myObjs = MyObjs;
				int num2 = i;
				object obj2 = myObjs[num2];
				object[] array3 = new object[0];
				string[] array4 = null;
				object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "obj", array3, array4, (Type[])null, (bool[])null);
				object[] array5 = new object[0];
				string[] array6 = null;
				array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "Props", array5, array6, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
				object[] myObjs2 = MyObjs;
				int num3 = i;
				array2[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(myObjs2[num3], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
				object[] array7 = array2;
				bool[] array8 = new bool[2] { true, true };
				object obj4 = NewLateBinding.LateGet(obj, (Type)null, "ExistName", array7, (string[])null, (Type[])null, array8);
				if (array8[0])
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[num2], (Type)null, "obj", array3, array4, (Type[])null, (bool[])null), (Type)null, "Props", array5, array6, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array7[0]) }, (string[])null, (Type[])null, true, true);
				}
				if (array8[1])
				{
					NewLateBinding.LateSetComplex(MyObjs[num3], (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array7[1]) }, (string[])null, (Type[])null, true, false);
				}
				if (Conversions.ToBoolean(Operators.AndObject(obj4, (object)(Array.IndexOf((Array)array, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null))) == -1))))
				{
					int num4 = ((Operators.CompareString(array[0], "", false) != 0) ? array.Length : 0);
					array = (string[])Utils.CopyArray((Array)array, (Array)new string[num4 + 1]);
					array[num4] = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
			}
			if (Operators.CompareString(array[0], "", false) == 0)
			{
				return null;
			}
			return array;
		}
	}

	public bool ExistName(string name, object obj = null)
	{
		if (MyObjs == null)
		{
			if (obj == null)
			{
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)name, false))
			{
				return true;
			}
		}
		checked
		{
			int num = MyObjs.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (NewLateBinding.LateGet(MyObjs[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null) != obj && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObjs[num2], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)name, false))
					{
						break;
					}
					num2++;
					continue;
				}
				return false;
			}
			return true;
		}
	}

	public peremens.ErrString GetPropertys(string prop, params object[] MyObjs)
	{
		if (MyObjs == null)
		{
			return new peremens.ErrString(null);
		}
		if (MyObjs.Length == 1)
		{
			return Props.GetProperty(RuntimeHelpers.GetObjectValue(MyObjs[0]), prop);
		}
		checked
		{
			peremens.ErrString[] array = new peremens.ErrString[MyObjs.Length - 1 + 1];
			int num = MyObjs.Length - 1;
			int i;
			for (i = 0; i <= num; i++)
			{
				ref peremens.ErrString reference = ref array[i];
				reference = Props.GetProperty(RuntimeHelpers.GetObjectValue(MyObjs[i]), prop);
			}
			int num2 = -1;
			int num3 = array.Length - 1;
			i = 0;
			while (true)
			{
				if (i <= num3)
				{
					if (num2 != -1)
					{
						if (Operators.CompareString(array[i].str, (string)null, false) != 0 && Operators.CompareString(array[i].str, array[num2].str, false) != 0)
						{
							return new peremens.ErrString(null);
						}
						if (Operators.CompareString(array[i].err, "", false) != 0)
						{
							break;
						}
					}
					if (unchecked(Operators.CompareString(array[i].str, (string)null, false) != 0 && num2 == -1))
					{
						num2 = i;
					}
					i++;
					continue;
				}
				if (num2 == -1)
				{
					return array[0];
				}
				return array[num2];
			}
			return array[i];
		}
	}

	public bool SetPropertys(string prop, string value, params object[] MyObjs)
	{
		return SetPropertys(prop, value, "", MyObjs);
	}

	public bool SetPropertys(string prop, string value, string oldname, params object[] MyObjs)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		if (!((Operators.CompareString(GetPropertys(prop, MyObjs).str, "", false) == 0) & (Operators.CompareString(value, "", false) == 0)))
		{
			int num = checked(MyObjs.Length - 1);
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					string text = Props.GetProperty(RuntimeHelpers.GetObjectValue(MyObjs[num2]), prop).str;
					MsgBoxResult val = Props.SetProperty(RuntimeHelpers.GetObjectValue(MyObjs[num2]), prop, value);
					if ((int)val == 7 || (int)val == 2)
					{
						break;
					}
					if (!recur & peremens.isDevelop)
					{
						if (num2 > 0)
						{
							NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
						}
						object obj = proj;
						object[] array = new object[4]
						{
							"Изменение свойства",
							peremens.GetUNameObj(RuntimeHelpers.GetObjectValue(MyObjs[num2])) + "." + peremens.trans(prop),
							value,
							text
						};
						object[] array2 = array;
						bool[] array3 = new bool[4] { false, false, true, true };
						NewLateBinding.LateCall(obj, (Type)null, "UndoRedo", array2, (string[])null, (Type[])null, array3, true);
						if (array3[2])
						{
							value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(string));
						}
						if (array3[3])
						{
							text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[3]), typeof(string));
						}
						if (Operators.CompareString(oldname, "", false) != 0)
						{
							NewLateBinding.LateCall(proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
							object obj2 = proj;
							object[] array4 = new object[5]
							{
								"Изменение свойства",
								oldname + "." + peremens.trans(prop),
								value,
								text,
								true
							};
							object[] array5 = array4;
							array3 = new bool[5] { false, false, true, true, false };
							NewLateBinding.LateCall(obj2, (Type)null, "UndoRedo", array5, (string[])null, (Type[])null, array3, true);
							if (array3[2])
							{
								value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[2]), typeof(string));
							}
							if (array3[3])
							{
								text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[3]), typeof(string));
							}
						}
					}
					num2 = checked(num2 + 1);
					continue;
				}
				recur = false;
				return true;
			}
			return false;
		}
		bool result = default(bool);
		return result;
	}

	public string getSpisName(object MyObj)
	{
		string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(Operators.ConcatenateObject((object)"[", NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"]")));
		}
		return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(text + " - ", "{"), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "type", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"}"));
	}

	public void FillListView(bool onlySelect = false)
	{
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		string[] array = null;
		try
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ListView", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			FillListView(onlySelect);
			ProjectData.ClearProjectError();
		}
		object[] activeObj = ActiveObj;
		if (proj != null && !onlySelect)
		{
			object obj = proj;
			object[] array2 = new object[1] { ActiveObj };
			object[] array3 = array2;
			bool[] array4 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "DeistvRefresh", array3, (string[])null, (Type[])null, array4, true);
			if (array4[0])
			{
				ActiveObj = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(object[]));
			}
		}
		if (activeObj == null)
		{
			NewLateBinding.LateCall(peremens2.MainForm, (Type)null, "lwEditPropertySet", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		if (activeObj[0] == null)
		{
			NewLateBinding.LateCall(peremens2.MainForm, (Type)null, "lwEditPropertySet", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		checked
		{
			if (proj != null)
			{
				object[] array5 = (object[])NewLateBinding.LateGet(proj, (Type)null, "GetMyAllFromName", new object[1] { "" }, (string[])null, (Type[])null, (bool[])null);
				if (array5 != null)
				{
					string[] mass = default(string[]);
					peremens.ReDims(ref mass, array5.Length - 1);
					int num = array5.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						mass[i] = getSpisName(RuntimeHelpers.GetObjectValue(array5[i]));
					}
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ComboBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ComboBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { mass };
					object[] array7 = array6;
					bool[] array4 = new bool[1] { true };
					NewLateBinding.LateCall(obj2, (Type)null, "AddRange", array7, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						mass = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ComboBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Sorted", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ComboBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Tag", new object[1] { "obrabotka" }, (string[])null, (Type[])null, false, true);
			bool[] array11;
			if (activeObj.Length == 1)
			{
				string text = getSpisName(RuntimeHelpers.GetObjectValue(activeObj[0]));
				object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ComboBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { text };
				object[] array8 = array6;
				bool[] array4 = new bool[1] { true };
				object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "IndexOf", array8, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string));
				}
				if (Operators.ConditionalCompareObjectEqual(obj4, (object)(-1), false))
				{
					object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ComboBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array9 = new object[1] { text };
					object[] array10 = array9;
					array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj5, (Type)null, "Add", array10, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ComboBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { text }, (string[])null, (Type[])null, false, true);
			}
			else
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ComboBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ComboBox2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Tag", new object[1] { "" }, (string[])null, (Type[])null, false, true);
			int num2 = activeObj.Length - 1;
			object[] array13;
			for (int i = 0; i <= num2; i++)
			{
				if (array == null)
				{
					array = (string[])NewLateBinding.LateGet(activeObj[i], (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null);
				}
				else
				{
					int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(activeObj[i], (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int j = 0; j <= num3; j++)
					{
						string[] array12 = array;
						object obj6 = activeObj[i];
						array13 = new object[1] { j };
						object[] array14 = array13;
						array11 = new bool[1] { true };
						object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "Propertys", array14, (string[])null, (Type[])null, array11);
						if (array11[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array13[0]), typeof(int));
						}
						if (Array.IndexOf((Array)array12, RuntimeHelpers.GetObjectValue(obj7)) == -1)
						{
							array = (string[])Utils.CopyArray((Array)array, (Array)new string[array.Length + 1]);
							string[] array15 = array;
							int num4 = array.Length - 1;
							object obj8 = activeObj[i];
							array13 = new object[1] { j };
							object[] array16 = array13;
							array11 = new bool[1] { true };
							object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "Propertys", array16, (string[])null, (Type[])null, array11);
							if (array11[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array13[0]), typeof(int));
							}
							array15[num4] = Conversions.ToString(obj9);
						}
					}
				}
				NewLateBinding.LateCall(activeObj[i], (Type)null, "NodeRefresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			if (peremens2.CreateDs != null)
			{
				NewLateBinding.LateCall(peremens2.CreateDs, (Type)null, "SetProperty", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			ListViewItem[] array17 = (ListViewItem[])(object)new ListViewItem[array.Length - 1 + 1];
			int num5 = 0;
			int num6 = array.Length - 1;
			for (int i = 0; i <= num6; i++)
			{
				if (Array.IndexOf(peremens.MayChangeProps, array[i].ToUpper()) == -1)
				{
					peremens.ErrString propertys = GetPropertys(array[i], activeObj);
					if (Operators.CompareString(propertys.err, "", false) == 0)
					{
						array17[num5] = new ListViewItem(array[i], array[i]);
						array17[num5].set_Name(array[i]);
						array17[num5].get_SubItems().Add(propertys.str);
						num5++;
					}
				}
			}
			num5--;
			array17 = (ListViewItem[])Utils.CopyArray((Array)array17, (Array)new ListViewItem[num5 + 1]);
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ListView", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null));
			object obj10 = NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ListView", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			array13 = new object[1] { array17 };
			object[] array18 = array13;
			array11 = new bool[1] { true };
			NewLateBinding.LateCall(obj10, (Type)null, "AddRange", array18, (string[])null, (Type[])null, array11, true);
			if (array11[0])
			{
				array17 = (ListViewItem[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array13[0]), typeof(ListViewItem[]));
			}
			if (Operators.CompareString(peremens.oldLVselect, "", false) != 0)
			{
				object obj11 = NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ListView", new object[0], (string[])null, (Type[])null, (bool[])null);
				array13 = new object[1] { peremens.oldLVselect };
				object[] array19 = array13;
				array11 = new bool[1] { true };
				object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "Items", array19, (string[])null, (Type[])null, array11);
				if (array11[0])
				{
					peremens.oldLVselect = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array13[0]), typeof(string));
				}
				if (obj12 != null)
				{
					object obj13 = NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ListView", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { peremens.oldLVselect };
					object[] array20 = array6;
					bool[] array4 = new bool[1] { true };
					object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "Items", array20, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						peremens.oldLVselect = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string));
					}
					NewLateBinding.LateSetComplex(obj14, (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
					object obj15 = NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ListView", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array9 = new object[1] { peremens.oldLVselect };
					object[] array21 = array9;
					array11 = new bool[1] { true };
					object obj16 = NewLateBinding.LateGet(obj15, (Type)null, "Items", array21, (string[])null, (Type[])null, array11);
					if (array11[0])
					{
						peremens.oldLVselect = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					NewLateBinding.LateCall(obj16, (Type)null, "BeginEdit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ListView", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LabelEdit", new object[1] { false }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ListView", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LabelEdit", new object[1] { true }, (string[])null, (Type[])null, false, true);
					object obj17 = NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ListView", new object[0], (string[])null, (Type[])null, (bool[])null);
					array9 = new object[1] { peremens.oldLVselect };
					object[] array22 = array9;
					array11 = new bool[1] { true };
					object obj18 = NewLateBinding.LateGet(obj17, (Type)null, "Items", array22, (string[])null, (Type[])null, array11);
					if (array11[0])
					{
						peremens.oldLVselect = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
					}
					NewLateBinding.LateSetComplex(obj18, (Type)null, "Focused", new object[1] { false }, (string[])null, (Type[])null, false, true);
				}
			}
			if (Operators.CompareString(base.obj.GetType().ToString(), peremens.ClassAplication + "F", false) == 0)
			{
				NewLateBinding.LateCall(MyObj, (Type)null, "TabTextRefresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			NewLateBinding.LateCall(peremens2.MainForm, (Type)null, "lwEditPropertySet", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}
}
