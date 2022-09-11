public class TextBoks : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public TextBoks(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[53]
		{
			peremens.trans("Текст"),
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Цвет"),
			peremens.trans("Стиль рамки"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Растяжка"),
			peremens.trans("Работает"),
			peremens.trans("Шрифт"),
			peremens.trans("Шрифт жирный"),
			peremens.trans("Шрифт курсив"),
			peremens.trans("Шрифт подчеркнутый"),
			peremens.trans("Шрифт зачеркнутый"),
			peremens.trans("Шрифт размер"),
			peremens.trans("Цвет шрифта"),
			peremens.trans("Скрывать выделение"),
			peremens.trans("X"),
			peremens.trans("Y"),
			peremens.trans("Максимальная ширина"),
			peremens.trans("Максимальная вышина"),
			peremens.trans("Минимальная ширина"),
			peremens.trans("Минимальная вышина"),
			peremens.trans("Максимальная длинна"),
			peremens.trans("Многострочность"),
			peremens.trans("Символ пароля"),
			peremens.trans("Только для чтения"),
			peremens.trans("Полосы прокрутки"),
			peremens.trans("Ширина"),
			peremens.trans("Вышина"),
			peremens.trans("ТабНомер"),
			peremens.trans("ТабСтоп"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Расположение текста"),
			peremens.trans("Видимый"),
			peremens.trans("Перенос по словам"),
			peremens.trans("Выделенный текст"),
			peremens.trans("Начало выделения"),
			peremens.trans("Длинна выделения"),
			peremens.trans("Номер символа по координатам"),
			peremens.trans("Номер первого символа строки"),
			peremens.trans("Номер первого символа текущей строки"),
			peremens.trans("Номер строки по номеру символа"),
			peremens.trans("X по номеру символа"),
			peremens.trans("Y по номеру символа"),
			peremens.trans("Строка"),
			peremens.trans("Количество строк"),
			peremens.trans("Символ"),
			peremens.trans("Количество символов"),
			peremens.trans("В фокусе"),
			peremens.trans("Тип"),
			peremens.trans("Подсказка"),
			peremens.trans("Разрешить вводить")
		};
		Methods = new string[10]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Копировать"),
			peremens.trans("Вырезать"),
			peremens.trans("Вставить"),
			peremens.trans("Выделить все"),
			peremens.trans("Отменить"),
			peremens.trans("Повторить")
		};
		Sobyts = new string[19]
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
			peremens.trans("Изменилась видимость")
		};
		Picture = "textboks";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runT(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new T(), holostoi, isRun, fromEng);
		}
	}
}
