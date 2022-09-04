public class LinkLabel : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public LinkLabel(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[53]
		{
			peremens.trans("Текст"),
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Цвет"),
			peremens.trans("Фоновой рисунок"),
			peremens.trans("АвтоТроеточие"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Стиль фона"),
			peremens.trans("Курсор"),
			peremens.trans("Растяжка"),
			peremens.trans("Работает"),
			peremens.trans("Стиль рамки"),
			peremens.trans("Шрифт"),
			peremens.trans("Шрифт жирный"),
			peremens.trans("Шрифт курсив"),
			peremens.trans("Шрифт подчеркнутый"),
			peremens.trans("Шрифт зачеркнутый"),
			peremens.trans("Цвет шрифта"),
			peremens.trans("Рисунок"),
			peremens.trans("Положение рисунка"),
			peremens.trans("X"),
			peremens.trans("Y"),
			peremens.trans("Максимальная ширина"),
			peremens.trans("Максимальная вышина"),
			peremens.trans("Минимальная ширина"),
			peremens.trans("Минимальная вышина"),
			peremens.trans("Поле слева"),
			peremens.trans("Поле сверху"),
			peremens.trans("Поле справа"),
			peremens.trans("Поле снизу"),
			peremens.trans("Ширина"),
			peremens.trans("Вышина"),
			peremens.trans("ТабНомер"),
			peremens.trans("ТабСтоп"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Шрифт размер"),
			peremens.trans("Положение текста"),
			peremens.trans("Видимый"),
			peremens.trans("В фокусе"),
			peremens.trans("Тип"),
			peremens.trans("Цвет активной ссылки"),
			peremens.trans("Цвет нерабочей ссылки"),
			peremens.trans("Цвет ссылки"),
			peremens.trans("Цвет посещенной ссылки"),
			peremens.trans("Начало ссылки"),
			peremens.trans("Длинна ссылки"),
			peremens.trans("Стиль подчеркивания"),
			peremens.trans("Ссылка посещена"),
			peremens.trans("Ссылка рабочая"),
			peremens.trans("Переходить в интернет по ссылке"),
			peremens.trans("Ссылка надписи"),
			peremens.trans("Подсказка")
		};
		Methods = new string[5]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Перейти в интернет по ссылке")
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
			peremens.trans("Клик по ссылке")
		};
		Picture = "linklabel";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runLLb(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new LLb(), holostoi, isRun, fromEng);
		}
	}
}
