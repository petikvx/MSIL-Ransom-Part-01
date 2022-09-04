public class Trial : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public Trial(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[40]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Растяжка"),
			peremens.trans("Цвет"),
			peremens.trans("Фоновой рисунок"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Стиль фона"),
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
			peremens.trans("ТабНомер"),
			peremens.trans("ТабСтоп"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Видимый"),
			peremens.trans("Стиль рамки"),
			peremens.trans("Тип"),
			peremens.trans("Подсказка"),
			peremens.trans("Текст кнопки"),
			peremens.trans("Текст поля"),
			peremens.trans("Сообщение успешной активации"),
			peremens.trans("Сообщение неудачной активации"),
			peremens.trans("ID пользователя"),
			peremens.trans("ID программы"),
			peremens.trans("ID в реестре"),
			peremens.trans("Ключ шифрования"),
			peremens.trans("Ключ активации выдать"),
			peremens.trans("Ключ активации проверить"),
			peremens.trans("Дней триала всего"),
			peremens.trans("Дней триала осталось"),
			peremens.trans("Активирована"),
			peremens.trans("Примечание"),
			peremens.trans("Триальный период запущен")
		};
		Methods = new string[6]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Триальный период запустить"),
			peremens.trans("Активацию отменить")
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
			peremens.trans("Клик кнопки"),
			peremens.trans("Активация успешная"),
			peremens.trans("Активация неудачная")
		};
		Picture = "trial";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runTr(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new Tr(), holostoi, isRun, fromEng);
		}
	}
}
