using System;
using Microsoft.VisualBasic.CompilerServices;

public class CMenu : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public CMenu(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[6]
		{
			peremens.trans("Имя"),
			peremens.trans("Хозяин объект"),
			peremens.trans("Номер"),
			peremens.trans("X"),
			peremens.trans("Y"),
			peremens.trans("Тип")
		};
		Methods = new string[1] { peremens.trans("Обновить") };
		Sobyts = new string[4]
		{
			peremens.trans("Открытие"),
			peremens.trans("Открылось"),
			peremens.trans("Закрытие"),
			peremens.trans("Закрылось")
		};
		Picture = "cmenu";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runCM(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new CM(), holostoi, isRun, fromEng);
		}
		NewLateBinding.LateSet(obj, (Type)null, "image", new object[1] { peremens.Pictures32.get_Images().get_Item(Picture) }, (string[])null, (Type[])null);
	}
}
