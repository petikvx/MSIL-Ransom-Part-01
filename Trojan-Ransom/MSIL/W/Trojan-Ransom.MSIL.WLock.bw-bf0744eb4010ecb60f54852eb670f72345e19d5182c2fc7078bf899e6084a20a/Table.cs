public class Table : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public Table(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[74]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Растяжка"),
			peremens.trans("Цвет"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Курсор"),
			peremens.trans("Работает"),
			peremens.trans("Полосы прокрутки"),
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
			peremens.trans("Позволить добавлять строки"),
			peremens.trans("Позволить удалять строки"),
			peremens.trans("Позволить переставлять столбцы"),
			peremens.trans("Позволить растягивать столбцы"),
			peremens.trans("Позволить растягивать строки"),
			peremens.trans("Стиль рамки ячейки"),
			peremens.trans("Отображать заголовки столбцов"),
			peremens.trans("Вышина заголовков столбцов"),
			peremens.trans("Столбцы"),
			peremens.trans("Строки"),
			peremens.trans("Цвет фона ячеек"),
			peremens.trans("Цвет фона выделенных ячеек"),
			peremens.trans("Цвет шрифта ячеек"),
			peremens.trans("Цвет шрифта выделенных ячеек"),
			peremens.trans("Режим редактирования"),
			peremens.trans("Цвет сетки"),
			peremens.trans("Выбор нескольких ячеек"),
			peremens.trans("Только для чтения таблица"),
			peremens.trans("Режим выделения"),
			peremens.trans("Номера выделенных строк"),
			peremens.trans("Номера выделенных столбцов"),
			peremens.trans("Значение ячейки"),
			peremens.trans("Ячейка выделена"),
			peremens.trans("Строка только для чтения"),
			peremens.trans("Столбец только для чтения"),
			peremens.trans("Ячейка только для чтения"),
			peremens.trans("Ширина столбца"),
			peremens.trans("Номер первой строки"),
			peremens.trans("Номер последней строки"),
			peremens.trans("Номер следующей строки"),
			peremens.trans("Номер предыдущей строки"),
			peremens.trans("Значение по координатам"),
			peremens.trans("Номер строки по координатам"),
			peremens.trans("Номер столбца по координатам"),
			peremens.trans("Количество строк таблицы"),
			peremens.trans("Количество столбцов"),
			peremens.trans("Количество выделенных строк"),
			peremens.trans("Количество выделенных столбцов"),
			peremens.trans("Отображать специальный столбец"),
			peremens.trans("Подсказка"),
			peremens.trans("Значение выделеных ячеек"),
			peremens.trans("Поиск в таблице"),
			peremens.trans("Поиск в выделеных ячейках"),
			peremens.trans("Шрифт"),
			peremens.trans("Шрифт жирный"),
			peremens.trans("Шрифт курсив"),
			peremens.trans("Шрифт подчеркнутый"),
			peremens.trans("Шрифт зачеркнутый"),
			peremens.trans("Шрифт размер"),
			peremens.trans("Ширина столбцов"),
			peremens.trans("Вышина строки"),
			peremens.trans("Вышина строк")
		};
		Methods = new string[23]
		{
			peremens.trans("Обновить"),
			peremens.trans("Получить фокус"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Выделить все"),
			peremens.trans("Очистить таблицу"),
			peremens.trans("Добавить строку"),
			peremens.trans("Добавить копию строк"),
			peremens.trans("Вставить строку"),
			peremens.trans("Вставить копию строк"),
			peremens.trans("Удалить строку"),
			peremens.trans("Сохранить таблицу"),
			peremens.trans("Открыть таблицу"),
			peremens.trans("Сортировать"),
			peremens.trans("Открыть Access"),
			peremens.trans("Открыть Excel"),
			peremens.trans("Сохранить Access"),
			peremens.trans("SQL запрос выборки"),
			peremens.trans("SQL запрос изменения"),
			peremens.trans("Добавить столбец"),
			peremens.trans("Вставить столбец"),
			peremens.trans("Удалить столбец"),
			peremens.trans("Поиск с выделением")
		};
		Sobyts = new string[36]
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
			peremens.trans("Прокрутка"),
			peremens.trans("Изменилось выделение"),
			peremens.trans("Начало редактирования ячейки"),
			peremens.trans("Клик по ячейке"),
			peremens.trans("Двойной клик по ячейке"),
			peremens.trans("Конец редактирования ячеки"),
			peremens.trans("Ячейка в фокусе"),
			peremens.trans("Ячека потеряла фокус"),
			peremens.trans("Столбец переместили"),
			peremens.trans("Клик по заголовку столбца"),
			peremens.trans("Двойной клик по заголовку столбца"),
			peremens.trans("Сортировка столбца"),
			peremens.trans("Изменилась ширина столбца"),
			peremens.trans("Клик по заголовку строки"),
			peremens.trans("Изменилась вышина строки"),
			peremens.trans("Добавли строку"),
			peremens.trans("Удалили строку"),
			peremens.trans("Клик по выделенной ячейке")
		};
		Picture = "panel";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runTl(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new Tl(), holostoi, isRun, fromEng);
		}
	}
}
