public class TPage : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public TPage(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[27]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Растяжка"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Курсор"),
			peremens.trans("Работает"),
			peremens.trans("X"),
			peremens.trans("Y"),
			peremens.trans("Максимальная ширина"),
			peremens.trans("Максимальная вышина"),
			peremens.trans("Минимальная ширина"),
			peremens.trans("Минимальная вышина"),
			peremens.trans("Ширина"),
			peremens.trans("Вышина"),
			peremens.trans("Многострочность"),
			peremens.trans("ТабНомер"),
			peremens.trans("ТабСтоп"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Видимый"),
			peremens.trans("Тип"),
			peremens.trans("Подсказка"),
			peremens.trans("Положение закладок"),
			peremens.trans("Номер выделенной закладки"),
			peremens.trans("Позиция выделенной закладки"),
			peremens.trans("Поле по горизонтали"),
			peremens.trans("Поле по вертикали")
		};
		Methods = new string[4]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад")
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
			peremens.trans("Прорисовка"),
			peremens.trans("Получение фокуса"),
			peremens.trans("Потеря фокуса"),
			peremens.trans("Изменились размеры"),
			peremens.trans("Изменилась видимость"),
			peremens.trans("Снялось выделение закладки"),
			peremens.trans("Снимается выделение закладки"),
			peremens.trans("Выделили закладку"),
			peremens.trans("Выделяют закладку")
		};
		Picture = "tpage";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runTP(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new TP(), holostoi, isRun, fromEng);
		}
	}
}
