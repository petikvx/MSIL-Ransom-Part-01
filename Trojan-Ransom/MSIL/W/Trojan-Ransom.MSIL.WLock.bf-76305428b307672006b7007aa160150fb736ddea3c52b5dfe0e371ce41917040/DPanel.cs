public class DPanel : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public string ActivePanel;

	public DPanel(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[47]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Цвет"),
			peremens.trans("Цвет1"),
			peremens.trans("Цвет2"),
			peremens.trans("Фоновой рисунок"),
			peremens.trans("Фоновой рисунок1"),
			peremens.trans("Фоновой рисунок2"),
			peremens.trans("Стиль фона1"),
			peremens.trans("Стиль фона2"),
			peremens.trans("Стиль рамки"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Всплывающее меню1"),
			peremens.trans("Всплывающее меню2"),
			peremens.trans("Курсор"),
			peremens.trans("Курсор1"),
			peremens.trans("Курсор2"),
			peremens.trans("Прокрутка1"),
			peremens.trans("Прокрутка2"),
			peremens.trans("Растяжка"),
			peremens.trans("Работает"),
			peremens.trans("Фиксированная часть"),
			peremens.trans("Фиксированный разделитель"),
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
			peremens.trans("Ориентация"),
			peremens.trans("Панель1 скрыта"),
			peremens.trans("Панель2 скрыта"),
			peremens.trans("Ширина разделителя"),
			peremens.trans("Расстояние разделителя"),
			peremens.trans("Инкремент разделителя"),
			peremens.trans("Панель1 минимум"),
			peremens.trans("Панель2 минимум"),
			peremens.trans("В фокусе"),
			peremens.trans("Подсказка"),
			peremens.trans("Тип")
		};
		Methods = new string[4]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад")
		};
		Sobyts = new string[21]
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
			peremens.trans("Разделитель перемещается"),
			peremens.trans("Разделитель перемещен"),
			peremens.trans("Изменились размеры"),
			peremens.trans("Изменилась видимость"),
			peremens.trans("Прокрутка")
		};
		Picture = "dpanel";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runDP(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new DP(), holostoi, isRun, fromEng);
		}
	}
}
