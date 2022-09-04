public class RichText : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public RichText(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[71]
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
			peremens.trans("Шрифт размер"),
			peremens.trans("Только для чтения"),
			peremens.trans("Полосы прокрутки"),
			peremens.trans("Ширина"),
			peremens.trans("Вышина"),
			peremens.trans("ТабНомер"),
			peremens.trans("ТабСтоп"),
			peremens.trans("Вспомогательное поле"),
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
			peremens.trans("Переходить в интернет по ссылке"),
			peremens.trans("Подсвечивать ссылки"),
			peremens.trans("Позволить перенос выделенного"),
			peremens.trans("Масштаб"),
			peremens.trans("RTF код документа"),
			peremens.trans("Выделенный RTF"),
			peremens.trans("Выделенное положение текста"),
			peremens.trans("Выделенный задний фон"),
			peremens.trans("Выделенный цвет текста"),
			peremens.trans("Выделенный размер красной строки"),
			peremens.trans("Выделенный отступ слева"),
			peremens.trans("Выделенный отступ справа"),
			peremens.trans("Выделенный имеет маркер"),
			peremens.trans("Выделенное вертикальное смещение"),
			peremens.trans("Выделенный шрифт размер"),
			peremens.trans("Выделенный шрифт"),
			peremens.trans("Выделенный шрифт жирный"),
			peremens.trans("Выделенный шрифт курсив"),
			peremens.trans("Выделенный шрифт подчеркнутый"),
			peremens.trans("Выделенный шрифт зачеркнутый"),
			peremens.trans("Выделенный текст заблокирован"),
			peremens.trans("Подсказка")
		};
		Methods = new string[13]
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
			peremens.trans("Повторить"),
			peremens.trans("Сохранить документ"),
			peremens.trans("Открыть документ"),
			peremens.trans("Прокрутить до курсора")
		};
		Sobyts = new string[22]
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
			peremens.trans("Изменилась видимость"),
			peremens.trans("Горизонтальная прокрутка"),
			peremens.trans("Вертикальная прокрутка"),
			peremens.trans("Клик по ссылке документа")
		};
		Picture = "richtext";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runRT(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new RT(), holostoi, isRun, fromEng);
		}
	}
}
