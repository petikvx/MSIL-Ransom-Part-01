using System;
using Microsoft.VisualBasic.CompilerServices;

public class FontDialog : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public FontDialog(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[16]
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
			peremens.trans("Позволить выбирать цвет"),
			peremens.trans("Позволить выбирать подчеркивания"),
			peremens.trans("X"),
			peremens.trans("Y")
		};
		Methods = new string[1] { peremens.trans("Запустить окно") };
		Sobyts = new string[0];
		Picture = "fontdialog";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runFD(), holostoi, isRun, fromEng);
			return;
		}
		CreateObject(new FD(), holostoi, isRun, fromEng);
		NewLateBinding.LateSet(obj, (Type)null, "image", new object[1] { peremens.Pictures32.get_Images().get_Item(Picture) }, (string[])null, (Type[])null);
	}
}
