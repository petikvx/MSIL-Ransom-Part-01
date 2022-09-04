using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

public class MMenus : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public MMenus(bool holostoi = false, bool isRun = false, bool fromEng = false, bool ToolPanel = false)
	{
		Propertys = new string[39]
		{
			peremens.trans("Текст"),
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Позиция"),
			peremens.trans("Цвет"),
			peremens.trans("Фоновой рисунок"),
			peremens.trans("Стиль фона"),
			peremens.trans("Работает"),
			peremens.trans("Шрифт"),
			peremens.trans("Шрифт жирный"),
			peremens.trans("Шрифт курсив"),
			peremens.trans("Шрифт подчеркнутый"),
			peremens.trans("Шрифт зачеркнутый"),
			peremens.trans("Цвет шрифта"),
			peremens.trans("Рисунок"),
			peremens.trans("Положение рисунка"),
			peremens.trans("Поле слева"),
			peremens.trans("Поле сверху"),
			peremens.trans("Поле справа"),
			peremens.trans("Поле снизу"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Текст и рисунок"),
			peremens.trans("Видимый"),
			peremens.trans("Шрифт размер"),
			peremens.trans("Тип"),
			peremens.trans("Расположен слева"),
			peremens.trans("Показывать подсказку"),
			peremens.trans("Отмечено"),
			peremens.trans("Отметка по клику"),
			peremens.trans("Стиль отображения"),
			peremens.trans("Родительское меню"),
			peremens.trans("Вложенное всплывающее меню"),
			peremens.trans("Рисунок растянут"),
			peremens.trans("Прозрачный цвет рисунка"),
			peremens.trans("Горячая клавиша"),
			peremens.trans("Отображать горячие клавиши"),
			peremens.trans("Направление текста"),
			peremens.trans("Всплывающая подсказка"),
			peremens.trans("Родительский пункт")
		};
		Methods = new string[6]
		{
			peremens.trans("Обновить"),
			peremens.trans("Перенести наперед"),
			peremens.trans("Перенести назад"),
			peremens.trans("Вложенное меню закрылось"),
			peremens.trans("Вложенное меню открылось"),
			peremens.trans("Вложенное меню открывается")
		};
		Sobyts = new string[18]
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
			peremens.trans("Создание"),
			peremens.trans("Изменение текста"),
			peremens.trans("Прорисовка"),
			peremens.trans("Получение фокуса"),
			peremens.trans("Потеря фокуса"),
			peremens.trans("Изменение отметки"),
			peremens.trans("Вложенное меню закрылось"),
			peremens.trans("Вложенное меню открылось"),
			peremens.trans("Вложенное меню открывается")
		};
		Picture = "mmenu";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runMMs(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new MMs(), holostoi, isRun, fromEng);
		}
		if (ToolPanel)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Paddingleft", new object[1] { 10 }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DisplayStyle", new object[1] { peremens.trans("Рисунок") }, (string[])null, (Type[])null, false, true);
			if (File.Exists(peremens.PicturesPath + "\\Icons\\Objects\\tpanel.png"))
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Image", new object[1] { peremens.copyImage(peremens.PicturesPath + "\\Icons\\Objects\\tpanel.png") }, (string[])null, (Type[])null, false, true);
			}
		}
	}
}
