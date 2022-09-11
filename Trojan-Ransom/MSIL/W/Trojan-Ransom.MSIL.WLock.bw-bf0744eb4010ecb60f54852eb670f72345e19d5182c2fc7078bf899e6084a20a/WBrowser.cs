public class WBrowser : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public WBrowser(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[41]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Растяжка"),
			peremens.trans("Работает"),
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
			peremens.trans("Переходить по сссылкам"),
			peremens.trans("Разрешить перетаскивания"),
			peremens.trans("Назад возможно"),
			peremens.trans("Вперед возможно"),
			peremens.trans("Текст страницы"),
			peremens.trans("Заголовок страницы"),
			peremens.trans("Тип страницы"),
			peremens.trans("Браузер занят"),
			peremens.trans("Браузер offline"),
			peremens.trans("Всплывающее меню браузера"),
			peremens.trans("Статус готовности"),
			peremens.trans("Статусная строка"),
			peremens.trans("Отображать ошибки сценариев"),
			peremens.trans("Полосы прокрутки активны"),
			peremens.trans("Ссылка"),
			peremens.trans("Горячие клавиши работают"),
			peremens.trans("Кодировка"),
			peremens.trans("Кодировка по умолчанию"),
			peremens.trans("Куки"),
			peremens.trans("Открытие ссылок нового окна"),
			peremens.trans("Подсказка")
		};
		Methods = new string[17]
		{
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Обновить страницу"),
			peremens.trans("Назад"),
			peremens.trans("Вперед"),
			peremens.trans("Домой"),
			peremens.trans("Страница поиска"),
			peremens.trans("Открыть в новом окне"),
			peremens.trans("Открыть в фрейме"),
			peremens.trans("Печать"),
			peremens.trans("Окно параметров страницы"),
			peremens.trans("Окно печати"),
			peremens.trans("Окно предварительного просмотра"),
			peremens.trans("Окно свойств"),
			peremens.trans("Окно сохранить"),
			peremens.trans("Остановить")
		};
		Sobyts = new string[12]
		{
			peremens.trans("Назад можно изменилось"),
			peremens.trans("Вперед можно изменилось"),
			peremens.trans("Страница загрузилась"),
			peremens.trans("Страница загружается"),
			peremens.trans("Перешел по ссылке"),
			peremens.trans("Переходит по ссылке"),
			peremens.trans("Открытие в новом окне"),
			peremens.trans("Статусная строка изменилась"),
			peremens.trans("Получение фокуса"),
			peremens.trans("Потеря фокуса"),
			peremens.trans("Изменились размеры"),
			peremens.trans("Изменилась видимость")
		};
		Picture = "wbrowser";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runW(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new W(), holostoi, isRun, fromEng);
		}
	}
}
