public class ListBoks : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public ListBoks(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[44]
		{
			peremens.trans("Текст"),
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Цвет"),
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
			peremens.trans("В фокусе"),
			peremens.trans("Тип"),
			peremens.trans("Подсказка"),
			peremens.trans("Записи списка"),
			peremens.trans("Сортирован список"),
			peremens.trans("Номер выделенной записи"),
			peremens.trans("Выделенная запись"),
			peremens.trans("Запись по номеру"),
			peremens.trans("Найти номер записи"),
			peremens.trans("Количество записей"),
			peremens.trans("Выбор нескольких записей"),
			peremens.trans("Ширина колонок списка"),
			peremens.trans("Горизонтальная прокрутка"),
			peremens.trans("Многоколонность"),
			peremens.trans("Позволить выбирать записи"),
			peremens.trans("Номера выделенных записей"),
			peremens.trans("Выделенные записи")
		};
		Methods = new string[10]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Очистить"),
			peremens.trans("Добавить запись"),
			peremens.trans("Вставить запись"),
			peremens.trans("Удалить запись"),
			peremens.trans("Удалить запись по номеру"),
			peremens.trans("Выделить все")
		};
		Sobyts = new string[20]
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
			peremens.trans("Изменение выбранной записи")
		};
		Picture = "listboks";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runL(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new L(), holostoi, isRun, fromEng);
		}
	}
}
