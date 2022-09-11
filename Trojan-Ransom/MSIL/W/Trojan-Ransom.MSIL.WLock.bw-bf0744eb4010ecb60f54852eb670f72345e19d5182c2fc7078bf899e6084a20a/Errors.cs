using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Errors
{
	public static string notFile(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Файл * не существует").Replace("*", str);
	}

	public static string notRegistry(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Ключ или папка * не существует в реестре").Replace("*", str);
	}

	public static string InvalidPathChars(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Путь * содержит недопустимые символы").Replace("*", str);
	}

	public static string InvalidFormatRegistry(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("Значение ** имеет недопустимый формат для ключа реестра *.").Replace("**", str1).Replace("*", str2);
	}

	public static string FileNotCreate(string str1)
	{
		return peremens.trans("Невозможно обратиться к файлу. Проверьте правильность написания пути. Ошибка:") + " " + str1;
	}

	public static string ProjNotFound(string str1)
	{
		return peremens.trans("Проект \"*\" не найден").Replace("*", str1);
	}

	public static string DivideByZero(string str1)
	{
		return peremens.trans("Попытка деления на 0 в действии \"*\". По правилам арифметики это запрещено!").Replace("*", str1);
	}

	public static string notCollection(string nameColl, string val, string[] coll)
	{
		val = "\"" + val + "\"";
		val = nameColl + peremens.trans(" * не существует. Проверьте правильность написания. Доступны следующие варианты:").Replace("*", val);
		val += " ";
		checked
		{
			int num = coll.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				val = val + "\"" + coll[i] + "\"";
				if (i < coll.Length - 1)
				{
					val += ", ";
				}
			}
			val = val + ".\r\n\r\n" + peremens.trans("Подробнее в пункте меню") + " \"" + peremens.trans("Вспомогательные слова") + "\".";
			return val;
		}
	}

	public static string notCollectionCols(string nameColl, string val, string[] coll)
	{
		val = notCollection(nameColl, val, coll);
		val = val + "\r\n\r\n" + peremens.trans("Также цвета можно задать перечисляя через точку с запятой интенсивности красного, зеленого, синего. Интенсивности задаются в диапазоне от 0 до 255.");
		return val;
	}

	public static string notDaOrNet(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Данное свойство может принимать только значения \"Да\", либо \"Нет\". А вы ввели *.").Replace("*", str);
	}

	public static string notInvers(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Инверсия может принимать только значения \"Да\", \"Нет\", \"1\", \"0\". А вы ввели *.").Replace("*", str);
	}

	public static string notTableAccess()
	{
		return peremens.trans("Для того чтобы сохранить файл Access, нужно его сначала открыть командой \"Открыть Access\".");
	}

	public static string notChar(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Строка * не является символом. Свойству требуется только символ.").Replace("*", str);
	}

	public static string noArguments(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Передано недостаточное количество информация для свойства *. Вы указали не все данные что нужны ему.").Replace("*", str);
	}

	public static string noItems(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("В свойстве ** был указан слишком большой номер записи *. В списке меньше, чем * записей.").Replace("**", str1).Replace("*", str2);
	}

	public static string noRows(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("В свойстве ** был указан слишком большой номер строки *. В таблице меньше, чем * строк.").Replace("**", str1).Replace("*", str2);
	}

	public static string noColumns(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("В свойстве ** был указан слишком большой номер столбца *. В таблице меньше, чем * столбцов.").Replace("**", str1).Replace("*", str2);
	}

	public static string notUnderstand(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Не понятно, что имеется ввиду выражением *.").Replace("*", str);
	}

	public static string notRowCount(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("В свойстве * нужно было указать строку из таблицы. А в таблице меньше чем ** строк.").Replace("**", str1).Replace("*", str2);
	}

	public static string notColumnCount(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("В свойстве * нужно было указать столбец из таблицы. А в таблице меньше чем ** столбцов.").Replace("**", str1).Replace("*", str2);
	}

	public static string notInt(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("** не является целым числом, либо слишком велико. А свойство * может принимать только целые числовые значения.").Replace("**", str1).Replace("*", str2);
	}

	public static string notLength(string str1, string str2, string str3)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		str2 = "\"" + str2 + "\"";
		return peremens.trans("В свойстве *** невозможно добраться до символа номер *, т.к. строка ** имеет длинну ****.").Replace("****", Conversions.ToString(checked(str2.Length - 2))).Replace("***", str1)
			.Replace("**", str2)
			.Replace("*", str3);
	}

	public static string notDouble(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("** не является числом, либо слишком велико. А функция * работает только с числами.").Replace("**", str1).Replace("*", str2);
	}

	public static string notLessEqZero(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("** не является положительным числом. А свойство * может принимать только положительные числовые значения.").Replace("**", str1).Replace("*", str2);
	}

	public static string notDateLimit(string str1, string str2, string str3)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		if (Operators.CompareString(str3, "", false) != 0)
		{
			str3 = "\"" + str3 + "\"";
		}
		return peremens.trans("Дата *** должна быть в диапазоне от ** до *").Replace("***", str1).Replace("**", str2)
			.Replace("*", str3);
	}

	public static string notLessZero(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("** отрицательное число. А свойство * не может принимать отрицательные числа.").Replace("**", str1).Replace("*", str2);
	}

	public static string ExistUniqName(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("У вас два объекта с одинаковым именем ** и номером *. Чтобы запустить программу сначала сделайте имена объектов разными, либо измените их свойства Номер, либо удалите ненужный объект.").Replace("**", str1).Replace("*", str2);
	}

	public static string ParseIfError(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("Неожиданное действие **. Ожидалось действие следующего типа(ов): *. Другими словами, вы ошиблись в структуре условий. Исправьте их, чтобы запустить проект.").Replace("**", str1).Replace("*", str2);
	}

	public static string NotReturn(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Строка * не возвращает никакого значения.").Replace("*", str);
	}

	public static string notIcon(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Файл * не является иконкой.").Replace("*", str);
	}

	public static string FileNoAccess(string str)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)(peremens.trans("Невозможно получить доступ к файлу, укажите другой файл. Произошла ошибка:") + "\r\n" + str), (MsgBoxStyle)48, (object)null);
		string result = default(string);
		return result;
	}

	public static string FilePathNotExist(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Файл или папка * не существует, проверьте правильность пути").Replace("*", str);
	}

	public static string FileNotExist(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Файл * не существует, проверьте правильность пути").Replace("*", str);
	}

	public static string PathNotExist(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Папка * не существует, проверьте правильность пути").Replace("*", str);
	}

	public static string isReadOnly(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Нельзя изменять свойство *, оно доступно только для чтения.").Replace("*", str);
	}

	public static string notDate(string str)
	{
		str = "\"" + str + "\"";
		string text = peremens.trans("Значение * не может перевестись в дату и время. Допустимы следующие варианты:").Replace("*", str);
		text += " ";
		checked
		{
			int num = DateAndTime.get_Now().GetDateTimeFormats().Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text = text + "\"" + DateAndTime.get_Now().GetDateTimeFormats()[i] + "\"";
				if (i < DateAndTime.get_Now().GetDateTimeFormats().Length - 1)
				{
					text += ", ";
				}
			}
			return text;
		}
	}

	public static string notTime(string str)
	{
		str = "\"" + str + "\"";
		return peremens.trans("Значение * не может перевестись во временной интервал. Допустимый формат ЧЧ:ММ:СС.мм").Replace("*", str);
	}

	public static string CreateMassive(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\" ";
		}
		return peremens.transInfc("Объект с именем *уже существует, хотите создать массив объектов?").Replace("*", str);
	}

	public static string NameExist(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\" ";
		}
		return peremens.transInfc("Объект с именем *уже существует, задайте другое имя").Replace("*", str);
	}

	public static string FontNotSupport(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Ошибка шрифта *. Возможно шрифт не сочетается с стилем (жирность, курсив, подчеркивание и т.д.), задайте другие параметры стиля и попробуйте еще раз выбрать данный шрифт:").Replace("*", str);
	}

	public static string InvalidIndex(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\" ";
		}
		return peremens.trans("Объект с индексом *уже существует, задайте другой индекс").Replace("*", str);
	}

	public static string AlreadyHaveElse()
	{
		return peremens.trans("Раздел \"В остальных случаях\" уже присутствует в данном условии. В условии может быть только один такой раздел");
	}

	public static string NameInvalid(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\" ";
		}
		return peremens.trans("Имя *задано неверно. Объект не может иметь такое имя.").Replace("*", str);
	}

	public static string NameInvalidLength(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\" ";
		}
		return peremens.trans("Имя объекта не может отсутствовать").Replace("*", str);
	}

	public static string NameInvalidSimvols(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\" ";
		}
		return peremens.transInfc("Имя *содержит недопустимые символы. В написании имени объектов можно использовать только буквы, цифры и пробелы").Replace("*", str);
	}

	public static string NameInvalidProbels(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\" ";
		}
		return peremens.trans("Имя объекта не может начинаться с побела").Replace("*", str);
	}

	public static string NameInvalidDigit(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\" ";
		}
		return peremens.trans("Имя объекта не может начинаться с цифры").Replace("*", str);
	}

	public static string NameInvalidFuns(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.transInfc("В программе существует функция c именем *, задайте другое имя.").Replace("*", str);
	}

	public static string NameInvalidHW(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.transInfc("В программе существует вспомогательное слово *, задайте другое имя.").Replace("*", str);
	}

	public static string NotSupportIncludeObj()
	{
		return peremens.transInfc("Данный объект можно разместить только на объектах такого же типа, как он сам.");
	}

	public static string InvalidPropObj()
	{
		return peremens.trans("Не известно, что означает одинарная кавычка");
	}

	public static string InvalidKovich()
	{
		return peremens.trans("Не верно задано свойство или метод объекта");
	}

	public static string ObjIsNothing()
	{
		return peremens.trans("Такой объект не существует");
	}

	public static string ObjIsNothing(string name)
	{
		if (Operators.CompareString(name, "", false) != 0)
		{
			name = "\"" + name + "\"";
		}
		return peremens.trans("Объект * не существует").Replace("*", name);
	}

	public static string MnogoRavno()
	{
		return peremens.trans("Не известно, что означают несколько знаков равно( \"=\" ). Используйте скобки, чтобы указать программе как интерпритировать эти знаки.");
	}

	public static string NotEndIF(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("Не найдено завершение условия *. Условия должны заканчиваться действием \"Конец условия\".").Replace("*", str);
	}

	public static string notPropertyMethod(string str)
	{
		if (Operators.CompareString(str, "", false) != 0)
		{
			str = "\"" + str + "\"";
		}
		return peremens.trans("У данного объекта не существует свойства или метода *. Проверьте правильность его написания.").Replace("*", str);
	}

	public static string notMainClass(string str)
	{
		return peremens.trans("Отсутствует обязательный класс MainClass, с которого начинает выполняться код. Ошибочный код:*").Replace("*", "\r\n" + str);
	}

	public static string notRunNode(string str)
	{
		str = "\"" + str + "\"";
		return peremens.trans("Невозможно выполнить строку *. Выполняться могут только Действия, Условия и Циклы.").Replace("*", str);
	}

	public static string InvalidContextMenu(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("Контектсного меню с именем **, заданного для объекта * не существует").Replace("**", str1).Replace("*", str2);
	}

	public static string InvalidWebBrowser(string str1)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		return peremens.trans("Браузера с именем * не существует").Replace("*", str1);
	}

	public static string MoreRecurs(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("Вызов функцией ** самой себя, повторился более * раз. Возможно рекурсия бесконечная. Дальнейшая работа может быть крайне нестабильна. Вы хотите продолжить выполнение данной рекурсии?").Replace("**", str1).Replace("*", str2);
	}

	public static string MoreCycles(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("Цикл ** повторился более, повторился более * раз. Возможно цикл бесконечный. Вы хотите продолжить выполнение данного цикла?").Replace("**", str1).Replace("*", str2);
	}

	public static void MessangeCritic(string str)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)(peremens.trans("Произошла непредвиденная ошибка") + ": " + str + GetAnswersMessage()), (MsgBoxStyle)16, (object)null);
	}

	public static void MessangeInfo(string str)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)str, (MsgBoxStyle)64, (object)null);
	}

	public static void MessangeExclamen(string str)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)(str + GetAnswersMessage()), (MsgBoxStyle)48, (object)null);
	}

	public static string InvalidKeys(string str1, string str2)
	{
		if (Operators.CompareString(str1, "", false) != 0)
		{
			str1 = "\"" + str1 + "\"";
		}
		if (Operators.CompareString(str2, "", false) != 0)
		{
			str2 = "\"" + str2 + "\"";
		}
		return peremens.trans("Невозможно назначить комбинацию клавиш **, объекту *").Replace("**", str1).Replace("*", str2);
	}

	public static string InvalidUrl(string str)
	{
		str = "\"" + str + "\"";
		return peremens.trans("Невозможно перейти по ссылке *. Ссылка имеет не верный формат.").Replace("*", str);
	}

	public static string GetAnswersMessage()
	{
		return "\r\n\r\n" + peremens.trans("Если в сложившейся ситуации вам необходима помощь, то поищите ответ или задайте свой вопрос на") + " " + peremens.SiteAlg + peremens.answersAlgPath;
	}
}
