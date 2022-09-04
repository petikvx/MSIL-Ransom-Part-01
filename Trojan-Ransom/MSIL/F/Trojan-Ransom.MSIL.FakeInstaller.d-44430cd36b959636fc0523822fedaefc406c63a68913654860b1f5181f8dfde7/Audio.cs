using System;
using Microsoft.VisualBasic.CompilerServices;

public class Audio : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public Audio(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[34]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Привязка"),
			peremens.trans("Цвет"),
			peremens.trans("Фоновой рисунок"),
			peremens.trans("Всплывающее меню"),
			peremens.trans("Стиль фона"),
			peremens.trans("Курсор"),
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
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Видимый"),
			peremens.trans("Тип"),
			peremens.trans("Подсказка"),
			peremens.trans("Файл проигрывания"),
			peremens.trans("Проигрывается"),
			peremens.trans("Громкость"),
			peremens.trans("Баланс"),
			peremens.trans("Звук отключен"),
			peremens.trans("Скорость"),
			peremens.trans("Длительность общая"),
			peremens.trans("Длительность время"),
			peremens.trans("Проигралось времени"),
			peremens.trans("Позиция проигрывания"),
			peremens.trans("Оригинальная ширина"),
			peremens.trans("Оригинальная вышина")
		};
		Methods = new string[8]
		{
			peremens.trans("Обновить"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Плей"),
			peremens.trans("Стоп медиа"),
			peremens.trans("Пауза"),
			peremens.trans("Открыть медиафайл"),
			peremens.trans("Закрыть файл")
		};
		Sobyts = new string[15]
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
			peremens.trans("Конец проигрывания")
		};
		Picture = "audio";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runA(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new A(), holostoi, isRun, fromEng);
		}
		NewLateBinding.LateSet(obj, (Type)null, "image", new object[1] { peremens.Pictures32.get_Images().get_Item(Picture) }, (string[])null, (Type[])null);
	}
}
