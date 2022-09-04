using System;
using Microsoft.VisualBasic.CompilerServices;

public class Memory : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public Memory(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[8]
		{
			peremens.trans("Значение"),
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Тип"),
			peremens.trans("Работает"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("X"),
			peremens.trans("Y")
		};
		Methods = new string[0];
		Sobyts = new string[2]
		{
			peremens.trans("Изменение значения"),
			peremens.trans("Изменилось значение")
		};
		Picture = "memory";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runM(), holostoi, isRun, fromEng);
		}
		else
		{
			CreateObject(new M(), holostoi, isRun, fromEng);
		}
		NewLateBinding.LateSet(obj, (Type)null, "image", new object[1] { peremens.Pictures32.get_Images().get_Item(Picture) }, (string[])null, (Type[])null);
	}
}
