using System;
using Microsoft.VisualBasic.CompilerServices;

public class ColorDialog : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public ColorDialog(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[8]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Тип"),
			peremens.trans("X"),
			peremens.trans("Y"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Выбранный цвет"),
			peremens.trans("Была нажата отмена")
		};
		Methods = new string[1] { peremens.trans("Запустить окно") };
		Sobyts = new string[0];
		Picture = "colordialog";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runCD(), holostoi, isRun, fromEng);
			return;
		}
		CreateObject(new CD(), holostoi, isRun, fromEng);
		NewLateBinding.LateSet(obj, (Type)null, "image", new object[1] { peremens.Pictures32.get_Images().get_Item(Picture) }, (string[])null, (Type[])null);
	}
}
