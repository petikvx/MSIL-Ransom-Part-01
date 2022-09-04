public class ClientServer : Objetus
{
	public new int dx;

	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public ClientServer(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[45]
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
			peremens.trans("Файл отправляется"),
			peremens.trans("Обозначение команд"),
			peremens.trans("Принятая команда"),
			peremens.trans("Принятый текст"),
			peremens.trans("Принятый файл"),
			peremens.trans("Имя в сети"),
			peremens.trans("IP для соединения"),
			peremens.trans("Порт для соединения"),
			peremens.trans("Папка для загрузок"),
			peremens.trans("Имена клиентов"),
			peremens.trans("Текст поля ввода"),
			peremens.trans("Текст поля лога"),
			peremens.trans("Ip клиентов"),
			peremens.trans("Ip клиента"),
			peremens.trans("Тип клиент сервера"),
			peremens.trans("Скрыть отправку файлов"),
			peremens.trans("Скрыть отправку текста"),
			peremens.trans("Скрыть список"),
			peremens.trans("Отправленная команда"),
			peremens.trans("Отправленый текст"),
			peremens.trans("Отправленый файл")
		};
		Methods = new string[20]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Отправить серверу"),
			peremens.trans("Отправить файл серверу"),
			peremens.trans("Отправить клиентам"),
			peremens.trans("Отправить клиентам кроме"),
			peremens.trans("Отправить клиенту"),
			peremens.trans("Отправить файл клиентам"),
			peremens.trans("Отправить файл клиентам кроме"),
			peremens.trans("Отправить файл клиенту"),
			peremens.trans("Добавить в лог"),
			peremens.trans("Соединиться с сервером"),
			peremens.trans("Создать сервер"),
			peremens.trans("Начать прослушку"),
			peremens.trans("Отключить сервер"),
			peremens.trans("Отключить прослушку"),
			peremens.trans("Отключиться"),
			peremens.trans("Выполнить команду")
		};
		Sobyts = new string[16]
		{
			peremens.trans("Клик"),
			peremens.trans("Прорисовка"),
			peremens.trans("Создание"),
			peremens.trans("Присоединились к серверу"),
			peremens.trans("Присоединился клиент"),
			peremens.trans("Изменилось число клиентов"),
			peremens.trans("Пришел текст"),
			peremens.trans("Пришла команда"),
			peremens.trans("Пришел файл"),
			peremens.trans("Отключение"),
			peremens.trans("Произошла ошибка"),
			peremens.trans("Отправился текст"),
			peremens.trans("Отправился файл"),
			peremens.trans("Идет отправление"),
			peremens.trans("Идет прием данных"),
			peremens.trans("Изменился статус")
		};
		Picture = "clientserver";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runCS(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new CS(), holostoi, isRun, fromEng);
		}
	}
}
