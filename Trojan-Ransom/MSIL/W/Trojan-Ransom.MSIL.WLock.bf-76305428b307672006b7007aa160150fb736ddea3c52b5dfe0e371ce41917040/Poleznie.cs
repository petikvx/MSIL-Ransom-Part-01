using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class Poleznie : Objetus
{
	public string[] Propertys;

	public string[] Sobyts;

	public string[] Methods;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string type;

	public Poleznie(string tip)
	{
		type = tip;
		CreateObject(new PoleznieObj(type));
		NewLateBinding.LateSet(obj, (Type)null, "defaultName", new object[1] { tip }, (string[])null, (Type[])null);
		string text = type;
		if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Экран"), false) == 0)
		{
			string[] array = (Propertys = new string[8]
			{
				peremens.MyZnak + peremens.trans("Рисунок рабочего стола"),
				peremens.MyZnak + peremens.trans("Стиль рабочего стола"),
				peremens.MyZnak + peremens.trans("Разрешение экрана"),
				peremens.MyZnak + peremens.trans("Скриншот"),
				peremens.MyZnak + peremens.trans("Скриншот объекта"),
				peremens.MyZnak + peremens.trans("Частота экрана"),
				peremens.MyZnak + peremens.trans("Качество цветопередачи"),
				peremens.MyZnak + peremens.trans("Заставка")
			});
			string[] array2 = (Methods = new string[1] { peremens.MyZnak + peremens.trans("Сделать скриншот") });
			NewLateBinding.LateSet(obj, (Type)null, "LastProp", new object[1] { peremens.MyZnak + peremens.trans("Рисунок рабочего стола") }, (string[])null, (Type[])null);
		}
		else if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Файлы и папки"), false) == 0)
		{
			string[] propertys = new string[27]
			{
				peremens.MyZnak + peremens.trans("Скрытый"),
				peremens.MyZnak + peremens.trans("Только для чтения"),
				peremens.MyZnak + peremens.trans("Архивный"),
				peremens.MyZnak + peremens.trans("Папка"),
				peremens.MyZnak + peremens.trans("Зашифрованный"),
				peremens.MyZnak + peremens.trans("Не индексируется"),
				peremens.MyZnak + peremens.trans("Системный"),
				peremens.MyZnak + peremens.trans("Временный"),
				peremens.MyZnak + peremens.trans("Время создания"),
				peremens.MyZnak + peremens.trans("Время доступа"),
				peremens.MyZnak + peremens.trans("Время изменения"),
				peremens.MyZnak + peremens.trans("Существует файл"),
				peremens.MyZnak + peremens.trans("Существует папка"),
				peremens.MyZnak + peremens.trans("Получить файлы"),
				peremens.MyZnak + peremens.trans("Получить папки"),
				peremens.MyZnak + peremens.trans("Определить корневую"),
				peremens.MyZnak + peremens.trans("Определить родительскую"),
				peremens.MyZnak + peremens.trans("Получить диски"),
				peremens.MyZnak + peremens.trans("Определить имя папки"),
				peremens.MyZnak + peremens.trans("Определить имя файла"),
				peremens.MyZnak + peremens.trans("Определить расширение"),
				peremens.MyZnak + peremens.trans("Определить без расширения"),
				peremens.MyZnak + peremens.trans("Определить размер файла"),
				peremens.MyZnak + peremens.trans("Поиск файлов"),
				peremens.MyZnak + peremens.trans("Открыть файл"),
				peremens.MyZnak + peremens.trans("Количество файлов"),
				peremens.MyZnak + peremens.trans("Количество папок")
			};
			string[] methods = new string[11]
			{
				peremens.MyZnak + peremens.trans("Сохранить в файле"),
				peremens.MyZnak + peremens.trans("Копировать"),
				peremens.MyZnak + peremens.trans("Зашифровать"),
				peremens.MyZnak + peremens.trans("Расшифровать"),
				peremens.MyZnak + peremens.trans("Добавить текст"),
				peremens.MyZnak + peremens.trans("Переместить"),
				peremens.MyZnak + peremens.trans("Удалить"),
				peremens.MyZnak + peremens.trans("Создать папку"),
				peremens.MyZnak + peremens.trans("Сохранить рисунок"),
				peremens.MyZnak + peremens.trans("Переименовать"),
				peremens.MyZnak + peremens.trans("Открыть папку")
			};
			Propertys = propertys;
			Methods = methods;
			NewLateBinding.LateSet(obj, (Type)null, "LastProp", new object[1] { peremens.MyZnak + peremens.trans("Существует файл") }, (string[])null, (Type[])null);
		}
		else if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Прерывания"), false) == 0)
		{
			string[] array3 = (Propertys = new string[0]);
			string[] array4 = (Methods = new string[4]
			{
				peremens.MyZnak + peremens.trans("Завершить программу"),
				peremens.MyZnak + peremens.trans("Завершить событие"),
				peremens.MyZnak + peremens.trans("Завершить цикл"),
				peremens.MyZnak + peremens.trans("Пропускать ошибки")
			});
			NewLateBinding.LateSet(obj, (Type)null, "LastProp", new object[1] { peremens.MyZnak + peremens.trans("Завершить программу") }, (string[])null, (Type[])null);
		}
		else if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Система"), false) == 0)
		{
			string[] propertys2 = new string[15]
			{
				peremens.MyZnak + peremens.trans("Мышь X"),
				peremens.MyZnak + peremens.trans("Мышь Y"),
				peremens.MyZnak + peremens.trans("Клавиша клавиатуры"),
				peremens.MyZnak + peremens.trans("Нажат альт"),
				peremens.MyZnak + peremens.trans("Нажат шифт"),
				peremens.MyZnak + peremens.trans("Нажат контрол"),
				peremens.MyZnak + peremens.trans("Нажата мыши левая"),
				peremens.MyZnak + peremens.trans("Нажата мыши правая"),
				peremens.MyZnak + peremens.trans("Вращается колесико"),
				peremens.MyZnak + peremens.trans("Рисунок буфера обмена"),
				peremens.MyZnak + peremens.trans("Текст буфера обмена"),
				peremens.MyZnak + peremens.trans("Выполнить с результатом"),
				peremens.MyZnak + peremens.trans("Окно в фокусе"),
				peremens.MyZnak + peremens.trans("Процессы системы"),
				peremens.MyZnak + peremens.trans("Окна системы")
			};
			string[] methods2 = new string[7]
			{
				peremens.MyZnak + peremens.trans("Выполнить"),
				peremens.MyZnak + peremens.trans("Очистить буфер обмена"),
				peremens.MyZnak + peremens.trans("Вращать колесико"),
				peremens.MyZnak + peremens.trans("Выключить компьютер"),
				peremens.MyZnak + peremens.trans("Перезагрузить компьютер"),
				peremens.MyZnak + peremens.trans("Набрать текст"),
				peremens.MyZnak + peremens.trans("Процесс убить")
			};
			Propertys = propertys2;
			Methods = methods2;
			NewLateBinding.LateSet(obj, (Type)null, "LastProp", new object[1] { peremens.MyZnak + peremens.trans("Выполнить") }, (string[])null, (Type[])null);
		}
		else if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Реестр"), false) == 0)
		{
			string[] propertys3 = new string[4]
			{
				peremens.MyZnak + peremens.trans("Значение реестра"),
				peremens.MyZnak + peremens.trans("Ключ существует"),
				peremens.MyZnak + peremens.trans("Папка существует"),
				peremens.MyZnak + peremens.trans("Тип ключа")
			};
			string[] methods3 = new string[4]
			{
				peremens.MyZnak + peremens.trans("Удалить значение"),
				peremens.MyZnak + peremens.trans("Удалить папку"),
				peremens.MyZnak + peremens.trans("Создать подпапку"),
				peremens.MyZnak + peremens.trans("Создать ключ")
			};
			Propertys = propertys3;
			Methods = methods3;
			NewLateBinding.LateSet(obj, (Type)null, "LastProp", new object[1] { peremens.MyZnak + peremens.trans("Значение реестра") }, (string[])null, (Type[])null);
		}
		else if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Вызвать событие"), false) == 0)
		{
			Propertys = null;
			Methods = null;
		}
		else if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Текст"), false) == 0)
		{
			string[] propertys4 = new string[34]
			{
				peremens.MyZnak + peremens.trans("Символ по номеру"),
				peremens.MyZnak + peremens.trans("Сравнить тексты"),
				peremens.MyZnak + peremens.trans("Поиск в тексте"),
				peremens.MyZnak + peremens.trans("Поиск номера строки"),
				peremens.MyZnak + peremens.trans("Поиск в тексте с конца"),
				peremens.MyZnak + peremens.trans("Поиск с учетом регистра"),
				peremens.MyZnak + peremens.trans("Поиск с регулярными выражениями"),
				peremens.MyZnak + peremens.trans("Количество символов"),
				peremens.MyZnak + peremens.trans("Разбить на части"),
				peremens.MyZnak + peremens.trans("Взять кусок текста"),
				peremens.MyZnak + peremens.trans("Количество частей текста"),
				peremens.MyZnak + peremens.trans("Кавычки убрать"),
				peremens.MyZnak + peremens.trans("Кавычками обособить"),
				peremens.MyZnak + peremens.trans("Поиск без кавычек"),
				peremens.MyZnak + peremens.trans("Разбить на части без кавычек"),
				peremens.MyZnak + peremens.trans("Количество частей без кавычек"),
				peremens.MyZnak + peremens.trans("Текст содержит"),
				peremens.MyZnak + peremens.trans("Текст не содержит"),
				peremens.MyZnak + peremens.trans("Строка по номеру"),
				peremens.MyZnak + peremens.trans("Количество строк"),
				peremens.MyZnak + peremens.trans("Вставить символы в текст"),
				peremens.MyZnak + peremens.trans("Удалить кусок текста"),
				peremens.MyZnak + peremens.trans("Заменить"),
				peremens.MyZnak + peremens.trans("Заменить все"),
				peremens.MyZnak + peremens.trans("Сделать буквы прописными"),
				peremens.MyZnak + peremens.trans("Сделать буквы заглавными"),
				peremens.MyZnak + peremens.trans("Убрать пробелы"),
				peremens.MyZnak + peremens.trans("Убрать пробелы в начале"),
				peremens.MyZnak + peremens.trans("Убрать пробелы в конце"),
				peremens.MyZnak + peremens.trans("Текст состоит из"),
				peremens.MyZnak + peremens.trans("Текст есть число"),
				peremens.MyZnak + peremens.trans("Текст есть цифры"),
				peremens.MyZnak + peremens.trans("Зашифровать текст"),
				peremens.MyZnak + peremens.trans("Расшифровать текст")
			};
			string[] methods4 = new string[0];
			Propertys = propertys4;
			Methods = methods4;
			NewLateBinding.LateSet(obj, (Type)null, "LastProp", new object[1] { peremens.MyZnak + peremens.trans("Взять кусок текста") }, (string[])null, (Type[])null);
		}
		else if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Показать сообщение"), false) == 0)
		{
			string[] propertys5 = new string[8]
			{
				peremens.MyZnak + peremens.trans("Была нажата Отмена"),
				peremens.MyZnak + peremens.trans("Была нажата Ок"),
				peremens.MyZnak + peremens.trans("Была нажата Повторить"),
				peremens.MyZnak + peremens.trans("Была нажата Да"),
				peremens.MyZnak + peremens.trans("Была нажата Нет"),
				peremens.MyZnak + peremens.trans("Была нажата Прервать"),
				peremens.MyZnak + peremens.trans("Была нажата Пропустить"),
				peremens.MyZnak + peremens.trans("Была нажата Справка")
			};
			string[] methods5 = new string[1] { peremens.MyZnak + peremens.trans("Запустить сообщение") };
			Propertys = propertys5;
			Methods = methods5;
			NewLateBinding.LateSet(obj, (Type)null, "LastProp", new object[1] { peremens.MyZnak + peremens.trans("Запустить сообщение") }, (string[])null, (Type[])null);
		}
		else if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Дата"), false) == 0)
		{
			string[] propertys6 = new string[34]
			{
				peremens.MyZnak + peremens.trans("День месяца"),
				peremens.MyZnak + peremens.trans("День года"),
				peremens.MyZnak + peremens.trans("День в неделе"),
				peremens.MyZnak + peremens.trans("Час"),
				peremens.MyZnak + peremens.trans("Минута"),
				peremens.MyZnak + peremens.trans("Секунда"),
				peremens.MyZnak + peremens.trans("Квартал"),
				peremens.MyZnak + peremens.trans("Неделя в году"),
				peremens.MyZnak + peremens.trans("Год"),
				peremens.MyZnak + peremens.trans("Месяц"),
				peremens.MyZnak + peremens.trans("Время"),
				peremens.MyZnak + peremens.trans("Секунд всего в дате"),
				peremens.MyZnak + peremens.trans("Дней в месяце"),
				peremens.MyZnak + peremens.trans("Сейчас"),
				peremens.MyZnak + peremens.trans("Сегодня"),
				peremens.MyZnak + peremens.trans("Прибавить дни"),
				peremens.MyZnak + peremens.trans("Прибавить часы"),
				peremens.MyZnak + peremens.trans("Прибавить минуты"),
				peremens.MyZnak + peremens.trans("Прибавить секунды"),
				peremens.MyZnak + peremens.trans("Прибавить кварталы"),
				peremens.MyZnak + peremens.trans("Прибавить недели"),
				peremens.MyZnak + peremens.trans("Прибавить годы"),
				peremens.MyZnak + peremens.trans("Прибавить месяцы"),
				peremens.MyZnak + peremens.trans("Разница в днях"),
				peremens.MyZnak + peremens.trans("Разница в часах"),
				peremens.MyZnak + peremens.trans("Разница в минутах"),
				peremens.MyZnak + peremens.trans("Разница в секундах"),
				peremens.MyZnak + peremens.trans("Разница в кварталах"),
				peremens.MyZnak + peremens.trans("Разница в неделях"),
				peremens.MyZnak + peremens.trans("Разница в годах"),
				peremens.MyZnak + peremens.trans("Разница в месяцах"),
				peremens.MyZnak + peremens.trans("День недели"),
				peremens.MyZnak + peremens.trans("Название месяца"),
				peremens.MyZnak + peremens.trans("Дата в определенном формате")
			};
			string[] methods6 = new string[1] { peremens.MyZnak + peremens.trans("Изменить время компьютера") };
			Propertys = propertys6;
			Methods = methods6;
			NewLateBinding.LateSet(obj, (Type)null, "LastProp", new object[1] { peremens.MyZnak + peremens.trans("Сейчас") }, (string[])null, (Type[])null);
		}
		else
		{
			if (Operators.CompareString(text, peremens.MyZnak + peremens.trans("Расширенные возможности"), false) != 0)
			{
				return;
			}
			string[] propertys7 = new string[0];
			string[] methods7 = new string[4]
			{
				peremens.MyZnak + peremens.trans("Выполнить код VBScript"),
				peremens.MyZnak + peremens.trans("Выполнить код Алгоритма2"),
				peremens.MyZnak + peremens.trans("Выполнить код VBNet"),
				peremens.MyZnak + peremens.trans("Выполнить код CSharp")
			};
			Propertys = propertys7;
			Methods = methods7;
			NewLateBinding.LateSet(obj, (Type)null, "LastProp", new object[1] { peremens.MyZnak + peremens.trans("Выполнить код VBNet") }, (string[])null, (Type[])null);
		}
		peremens.CreatePropertySobytsUp(this);
	}

	public void CreateSobytCalls()
	{
		string[] mass = null;
		if (!peremens.isDevelop & (peremens.ProjEvents != null))
		{
			return;
		}
		object obj = tree;
		if (!peremens.isDevelop)
		{
			obj = peremens.RunProj.tree;
		}
		TreeNode[] nodesFromTypeTag = peremens.GetNodesFromTypeTag("Sobyt", RuntimeHelpers.GetObjectValue(obj));
		if ((peremens.isDevelop & (peremens.ProjEvents != null) & peremens.isRUN()) && nodesFromTypeTag.Length == peremens.ProjEvents.Length)
		{
			return;
		}
		checked
		{
			if (nodesFromTypeTag != null)
			{
				int num = nodesFromTypeTag.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					object[] myObjsFromTreeNode = peremens.GetMyObjsFromTreeNode(nodesFromTypeTag[i]);
					if (myObjsFromTreeNode != null)
					{
						if (Operators.CompareString(myObjsFromTreeNode[0].GetType().ToString(), "System.Windows.Forms.TreeNode", false) == 0)
						{
							return;
						}
						object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(myObjsFromTreeNode[0], (Type)null, "getMyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
						peremens.ReDims(ref mass);
						mass[mass.Length - 1] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"_"), NewLateBinding.LateGet(NewLateBinding.LateGet(myObjsFromTreeNode[0], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"_"), (object)nodesFromTypeTag[i].get_Text()));
					}
				}
			}
			Methods = mass;
			peremens.ProjEvents = mass;
			peremens.CreatePropertySobytsUp(this);
		}
	}
}
