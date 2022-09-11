public class Internet : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public Internet(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[50]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Цвет"),
			peremens.trans("Фоновой рисунок"),
			peremens.trans("Стиль фона"),
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
			peremens.trans("Подсказка"),
			peremens.trans("Стиль рамки"),
			peremens.trans("Удерживать соединение"),
			peremens.trans("Автоматически перенаправляться"),
			peremens.trans("Ссылка запроса"),
			peremens.trans("Ссылка откуда пришли"),
			peremens.trans("Ссылка перенаправления"),
			peremens.trans("Тип браузера"),
			peremens.trans("Принимать"),
			peremens.trans("Прокси IP"),
			peremens.trans("Прокси порт"),
			peremens.trans("Кодировка страницы"),
			peremens.trans("Язык страницы"),
			peremens.trans("Содержимое запроса"),
			peremens.trans("Тип содержимого"),
			peremens.trans("Длинна содержимого"),
			peremens.trans("Метод запроса"),
			peremens.trans("Код результата"),
			peremens.trans("Таймаут"),
			peremens.trans("Время задержки"),
			peremens.trans("Заголовки запроса"),
			peremens.trans("Куки запросов"),
			peremens.trans("Результат запроса"),
			peremens.trans("Папка для загрузок"),
			peremens.trans("Размер буфера"),
			peremens.trans("Скачивается файл"),
			peremens.trans("Скачка пауза"),
			peremens.trans("Наличие соединения")
		};
		Methods = new string[10]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Получить код страницы"),
			peremens.trans("Скачать файл"),
			peremens.trans("Выполнить запрос"),
			peremens.trans("Очистить куки"),
			peremens.trans("Скачка отменить"),
			peremens.trans("Скачка возобновить")
		};
		Sobyts = new string[8]
		{
			peremens.trans("Клик"),
			peremens.trans("Прорисовка"),
			peremens.trans("Создание"),
			peremens.trans("Отправляется запрос"),
			peremens.trans("Отправился запрос"),
			peremens.trans("Пришел ответ"),
			peremens.trans("Идет прием данных"),
			peremens.trans("Загрузка отменена")
		};
		Picture = "internet";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runI(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new I(), holostoi, isRun, fromEng);
		}
	}
}
