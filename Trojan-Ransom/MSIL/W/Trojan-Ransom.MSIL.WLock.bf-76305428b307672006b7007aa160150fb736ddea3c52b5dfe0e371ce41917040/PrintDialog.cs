using System;
using Microsoft.VisualBasic.CompilerServices;

public class PrintDialog : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public PrintDialog(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[27]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Тип"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Выбранный цвет"),
			peremens.trans("Была нажата отмена"),
			peremens.trans("Шрифт"),
			peremens.trans("Шрифт жирный"),
			peremens.trans("Шрифт курсив"),
			peremens.trans("Шрифт подчеркнутый"),
			peremens.trans("Шрифт зачеркнутый"),
			peremens.trans("Шрифт размер"),
			peremens.trans("Текст на печать"),
			peremens.trans("Документ на печать"),
			peremens.trans("Таблица на печать"),
			peremens.trans("Рисунок на печать"),
			peremens.trans("Объект на печать"),
			peremens.trans("Поле слева"),
			peremens.trans("Поле сверху"),
			peremens.trans("Поле справа"),
			peremens.trans("Поле снизу"),
			peremens.trans("X"),
			peremens.trans("Таблица в центре"),
			peremens.trans("Y"),
			peremens.trans("Страница начала печати"),
			peremens.trans("Страница конца печати"),
			peremens.trans("Число копий")
		};
		Methods = new string[4]
		{
			peremens.trans("Запустить предварительный просмотр"),
			peremens.trans("Запустить настройки страницы"),
			peremens.trans("Запустить окно печати"),
			peremens.trans("Напечатать")
		};
		Sobyts = new string[0];
		Picture = "printdialog";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runPrD(), holostoi, isRun, fromEng);
			return;
		}
		CreateObject(new PrD(), holostoi, isRun, fromEng);
		NewLateBinding.LateSet(obj, (Type)null, "image", new object[1] { peremens.Pictures32.get_Images().get_Item(Picture) }, (string[])null, (Type[])null);
	}
}
