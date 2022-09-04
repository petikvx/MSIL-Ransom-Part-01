using System;
using Microsoft.VisualBasic.CompilerServices;

public class OpenDialog : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public OpenDialog(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[16]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Тип"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Была нажата отмена"),
			peremens.trans("X"),
			peremens.trans("Y"),
			peremens.trans("Добавлять расширение файлу"),
			peremens.trans("Проверять наличие файла"),
			peremens.trans("Проверять наличие папки"),
			peremens.trans("Имя файла"),
			peremens.trans("Фильтр файлов"),
			peremens.trans("Номер фильтра"),
			peremens.trans("Начальная папка"),
			peremens.trans("Заголовок"),
			peremens.trans("Выбор нескольких файлов")
		};
		Methods = new string[1] { peremens.trans("Запустить окно") };
		Sobyts = new string[0];
		Picture = "opendialog";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runOD(), holostoi, isRun, fromEng);
			return;
		}
		CreateObject(new OD(), holostoi, isRun, fromEng);
		if (!holostoi)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Filter", new object[1] { peremens.trans("Рисунки") + "|*.jpg;*.bmp|" + peremens.trans("Все файлы") + "|*.*" }, (string[])null, (Type[])null, false, true);
		}
		NewLateBinding.LateSet(obj, (Type)null, "image", new object[1] { peremens.Pictures32.get_Images().get_Item(Picture) }, (string[])null, (Type[])null);
	}
}
