using System;
using Microsoft.VisualBasic.CompilerServices;

public class PathDialog : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public PathDialog(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[9]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Тип"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("Была нажата отмена"),
			peremens.trans("Надпись в окне"),
			peremens.trans("Выбранная папка"),
			peremens.trans("X"),
			peremens.trans("Y")
		};
		Methods = new string[1] { peremens.trans("Запустить окно") };
		Sobyts = new string[0];
		Picture = "pathdialog";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runPD(), holostoi, isRun, fromEng);
			return;
		}
		CreateObject(new PD(), holostoi, isRun, fromEng);
		NewLateBinding.LateSet(obj, (Type)null, "image", new object[1] { peremens.Pictures32.get_Images().get_Item(Picture) }, (string[])null, (Type[])null);
	}
}
