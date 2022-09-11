using System;
using Microsoft.VisualBasic.CompilerServices;

public class Timer : Objetus
{
	public string[] Propertys;

	public string[] Methods;

	public string[] Sobyts;

	public string[] PropertysUp;

	public string[] SobytsUp;

	public string[] MethodsUp;

	public string Picture;

	public Timer(bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		Propertys = new string[9]
		{
			peremens.trans("Имя"),
			peremens.trans("Номер"),
			peremens.trans("Тип"),
			peremens.trans("Работает"),
			peremens.trans("Интервал отсчета"),
			peremens.trans("Прошло интервалов"),
			peremens.trans("Вспомогательное поле"),
			peremens.trans("X"),
			peremens.trans("Y")
		};
		Methods = new string[2]
		{
			peremens.trans("Старт"),
			peremens.trans("Стоп")
		};
		Sobyts = new string[1] { peremens.trans("Тикнул") };
		Picture = "timer";
		peremens.CreatePropertySobytsUp(this);
		Sobytia = SobytsUp;
		if (isRun)
		{
			CreateObject(new runTm(), holostoi, isRun, fromEng);
			return;
		}
		CreateObject(new Tm(), holostoi, isRun, fromEng);
		NewLateBinding.LateSet(obj, (Type)null, "image", new object[1] { peremens.Pictures32.get_Images().get_Item(Picture) }, (string[])null, (Type[])null);
		if (!holostoi)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "interval", new object[1] { 1000 }, (string[])null, (Type[])null, false, true);
		}
	}
}
