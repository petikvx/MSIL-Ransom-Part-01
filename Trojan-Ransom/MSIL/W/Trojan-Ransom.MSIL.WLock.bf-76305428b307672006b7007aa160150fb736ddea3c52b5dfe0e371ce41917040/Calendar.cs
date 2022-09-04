public class Calendar : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public Calendar(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[34]
		{
			peremens.trans("Текст"),
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Курсор"),
			peremens.trans("Растяжка"),
			peremens.trans("Работает"),
			peremens.trans("Шрифт"),
			peremens.trans("Шрифт жирный"),
			peremens.trans("Шрифт курсив"),
			peremens.trans("Шрифт подчеркнутый"),
			peremens.trans("Шрифт зачеркнутый"),
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
			peremens.trans("Шрифт размер"),
			peremens.trans("Видимый"),
			peremens.trans("В фокусе"),
			peremens.trans("Тип"),
			peremens.trans("Формат даты"),
			peremens.trans("Формат даты по выбору"),
			peremens.trans("Кнопки вверх вниз"),
			peremens.trans("Выбранная дата"),
			peremens.trans("Подсказка")
		};
		Methods = new string[4]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад")
		};
		Sobyts = new string[20]
		{
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
			peremens.trans("Получение фокуса"),
			peremens.trans("Потеря фокуса"),
			peremens.trans("Изменились размеры"),
			peremens.trans("Изменилась видимость"),
			peremens.trans("Значение изменилось"),
			peremens.trans("Календарь раскрылся"),
			peremens.trans("Календарь закрылся")
		};
		Picture = "calendar";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runCr(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new Cr(), holostoi, isRun, fromEng);
		}
	}
}
