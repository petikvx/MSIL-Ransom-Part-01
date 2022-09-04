using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Props
{
	private static Random rnd = new Random();

	public static peremens.ErrString GetProperty(object MyObj, string prop, string word = "")
	{
		prop = Strings.UCase(prop);
		if (MyObj == null)
		{
			return new peremens.ErrString(null);
		}
		if (NewLateBinding.LateGet(MyObj, (Type)null, "PropertysUp", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
		{
			return new peremens.ErrString(null);
		}
		if (Array.IndexOf((Array)NewLateBinding.LateGet(MyObj, (Type)null, "PropertysUp", new object[0], (string[])null, (Type[])null, (bool[])null), prop) == -1)
		{
			return new peremens.ErrString(null);
		}
		return GetPropertyMethod(RuntimeHelpers.GetObjectValue(MyObj), prop, word, null);
	}

	public static peremens.ErrString GetPropertyMethod(object MyObj, string prop, string word, string[] args)
	{
		string str = prop;
		bool flag = false;
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
		prop = Strings.UCase(prop);
		if (Conversions.ToBoolean(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			if (peremens.RunProj == null)
			{
				peremens.ErrString result = default(peremens.ErrString);
				return result;
			}
			if (peremens.RunProj.Param.Paramy != null && peremens.RunProj.Param.ParamyUp.IndexOfKey(Strings.UCase(prop)) != -1)
			{
				flag = true;
			}
		}
		if ((NewLateBinding.LateGet(MyObj, (Type)null, "PropertysUp", new object[0], (string[])null, (Type[])null, (bool[])null) == null) & (NewLateBinding.LateGet(MyObj, (Type)null, "MethodsUp", new object[0], (string[])null, (Type[])null, (bool[])null) == null))
		{
			return new peremens.ErrString("", Errors.notPropertyMethod(str));
		}
		if (NewLateBinding.LateGet(MyObj, (Type)null, "PropertysUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			if (((Array.IndexOf((Array)NewLateBinding.LateGet(MyObj, (Type)null, "PropertysUp", new object[0], (string[])null, (Type[])null, (bool[])null), prop) == -1) & (Array.IndexOf((Array)NewLateBinding.LateGet(MyObj, (Type)null, "MethodsUp", new object[0], (string[])null, (Type[])null, (bool[])null), prop) == -1)) && !flag)
			{
				return new peremens.ErrString("", Errors.notPropertyMethod(str));
			}
		}
		else if (Array.IndexOf((Array)NewLateBinding.LateGet(MyObj, (Type)null, "MethodsUp", new object[0], (string[])null, (Type[])null, (bool[])null), prop) == -1 && !flag)
		{
			return new peremens.ErrString("", Errors.notPropertyMethod(str));
		}
		if (Iz.isObjSobitiya(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			return new peremens.ErrString("");
		}
		checked
		{
			if (args != null)
			{
				int num = args.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					args[i] = peremens.perevesti(args[i], SdelatEnterOrSpecsimvol: true);
				}
			}
			if (!flag)
			{
				string text = prop;
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Имя")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фоновой рисунок")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фоновой рисунок1")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage1", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фоновой рисунок2")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage2", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет1")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor1", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет2")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor2", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позиция")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "position", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Главная форма")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "mainform", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающее меню")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenu", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающее меню1")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenu1", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающее меню2")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenu2", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запретить закрытие")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForbidClose", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Привязка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Anchor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("АвтоТроеточие")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoEllipsis", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль фона")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImageLayout", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль фона1")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImageLayout1", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль фона2")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImageLayout2", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль рисунка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SizeMode", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Курсор")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cursor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Курсор1")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cursor1", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Курсор2")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cursor2", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Растяжка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Dock", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Работает")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль кнопки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FlatStyle", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль рамки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BorderStyle", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontFamily", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт жирный")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontBold", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт курсив")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontItalic", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт подчеркнутый")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontUnderline", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт зачеркнутый")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontStrikeout", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт размер")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontSize", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет шрифта")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForeColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Рисунок")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Image", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Положение рисунка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ImageAlign", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("X")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Y")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Максимальная ширина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaximumWidth", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Максимальная вышина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaximumHeight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Минимальная ширина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MinimumWidth", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Минимальная вышина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MinimumHeight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле слева")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingLeft", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле сверху")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingTop", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле справа")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingRight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле снизу")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingBottom", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вышина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("ТабНомер")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TabIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("ТабСтоп")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TabStop", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вспомогательное поле")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Tag", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Положение текста")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextAlign", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Расположение текста")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextPosition", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст и рисунок")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextImageRelation", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Видимый")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Scroll", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка1")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Scroll1", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка2")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Scroll2", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фиксированная часть")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FixedPanel", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фиксированный разделитель")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FixedSplitter", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ориентация")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Orientation", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Панель1 скрыта")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel1Collapsed", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Панель2 скрыта")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2Collapsed", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина разделителя")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterWidth", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Расстояние разделителя")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterDistance", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Инкремент разделителя")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterIncrement", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Панель1 минимум")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel1MinSize", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Панель2 минимум")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2MinSize", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("В фокусе")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Focused", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Тип")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Type", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Файл проигрывания")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileNamePlayed", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Проигрывается")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Played", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Громкость")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Volume", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Баланс")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Balance", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Звук отключен")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Mute", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скорость")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Speed", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Длительность общая")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TotalPosition", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позиция проигрывания")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PlayPosition", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Проигралось времени")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PlayTime", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Длительность время")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TotalTime", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Оригинальная вышина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OriginalHeight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Оригинальная ширина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OriginalWidth", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скрывать выделение")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HideSelection", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Максимальная длинна")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaximumLength", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Многострочность")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Multiline", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Символ пароля")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PasswordChar", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Только для чтения")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReadOnly", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Полосы прокрутки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ScrollBars", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Перенос по словам")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WordWrap", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный текст")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedText", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Начало выделения")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionStart", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Длинна выделения")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionLength", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отмечено")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ориентация инструментов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OrientationTools", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Расположен слева")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Alignment", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Показывать подсказку")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoToolTip", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отметка по клику")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckOnClick", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль отображения")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DisplayStyle", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Родительское меню")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OwnerMenu", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Родительский пункт")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OwnerItem", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Хозяин объект")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OwnerObject", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вложенное всплывающее меню")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DropDown", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Рисунок растянут")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ImageScaling", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прозрачный цвет рисунка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ImageTransparentColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Горячая клавиша")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShortcutKeys", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать горячие клавиши")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowShortcutKeys", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Направление текста")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextDirection", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающая подсказка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Оконные кнопки и меню")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ControlBox", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль окна")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FormBorderStyle", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Главное меню")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MainMenuStrip", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прозрачность")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Opacity", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Показывать иконку")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowIcon", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать в панели задач")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowInTaskbar", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стартовая позиция")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StartPosition", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поверх всех окон")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TopMost", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Статус окна")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowState", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка минимальная ширина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoScrollMinSizeWidth", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка минимальная вышина")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoScrollMinSizeHeight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокручено по X")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoScrollPositionX", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокручено по Y")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoScrollPositionY", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Высота заголовка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CaptionHeight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Иконка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Icon", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прозрачный цвет")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TransparentcyKey", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Положение закладок")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TabAlignment", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер выделенной закладки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedTabIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позиция выделенной закладки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedTabPosition", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле по горизонтали")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingX", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле по вертикали")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingY", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Значение")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Высота раскрывающегося списка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DropDownHeight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина раскрывающегося списка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DropDownWidth", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Список упрощенный")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DropDownStyle", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Высота записей списка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ItemHeight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Записи списка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество раскрывающихся записей")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaxDropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сортирован список")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Sorted", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Список раскрыт")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DroppedDown", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер выделенной записи")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенная запись")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				peremens.ErrString result2;
				peremens.ErrString errString = default(peremens.ErrString);
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запись по номеру")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)args[0], false))
					{
						errString.err = Errors.noItems(prop, args[0]);
						return errString;
					}
					object obj = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array = new object[1] { args };
					object[] array2 = array;
					bool[] array3 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "ItemsItem", array2, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj2));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Найти номер записи")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj3 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array5 = array4;
					bool[] array3 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "ItemsIndexOf", array5, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj4));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество записей")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ItemsCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина колонок списка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnWidth", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Горизонтальная прокрутка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HorizontalScrollBar", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Многоколонность")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MultiColumn", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить выбирать записи")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionModeList", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номера отмеченых записей")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckedIndices", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отмеченные записи")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckedItems", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номера выделенных записей")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndices", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенные записи")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет активной ссылки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveLinkColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет нерабочей ссылки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DisabledLinkColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет ссылки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет посещенной ссылки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "VisitedLinkColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Начало ссылки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkStart", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Длинна ссылки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkLength", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль подчеркивания")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkBehavior", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка посещена")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkVisited", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка рабочая")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkEnabled", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Переходить в интернет по ссылке")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "InternetLink", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка надписи")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkName", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Подсвечивать ссылки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DetectUrls", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить перенос выделенного")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "EnableAutoDragDrop", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Масштаб")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ZoomFactor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("RTF код документа")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rtf", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный RTF")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedRtf", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенное положение текста")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionAlignment", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный задний фон")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionBackColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный цвет текста")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный размер красной строки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionHangingIndent", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный отступ слева")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionIndent", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный отступ справа")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionRightIndent", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный имеет маркер")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionBullet", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенное вертикальное смещение")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionCharOffset", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный шрифт")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontFamily", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный шрифт жирный")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontBold", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный шрифт курсив")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontItalic", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный шрифт подчеркнутый")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontUnderline", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный шрифт зачеркнутый")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontStrikeout", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный шрифт размер")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontSize", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный текст заблокирован")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionProtected", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбранный цвет")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DialogColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Была нажата отмена")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WasCancel", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить выбирать цвет")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить выбирать подчеркивания")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowEffects", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Надпись в окне")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбранная папка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedPath", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Добавлять расширение файлу")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultExt", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Проверять наличие файла")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckFileExists", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Проверять наличие папки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckPathExists", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Имя файла")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фильтр файлов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Filter", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер фильтра")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FilterIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Начальная папка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "InitialDirectory", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Заголовок")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Title", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбор нескольких файлов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MultiSelectFiles", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст на печать")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintText", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Документ на печать")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintDocument", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Таблица на печать")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintTable", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Объект на печать")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintObject", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Рисунок на печать")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintPicture", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Таблица в центре")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TableOnCenter", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Интервал отсчета")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Interval", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прошло интервалов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IntervalCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Формат даты")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CalendarDateFormat", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Формат даты по выбору")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CustomDateFormat", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Кнопки вверх вниз")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowUpDown", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбранная дата")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedDate", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сдвиг большой")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LargeChange", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сдвиг малый")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SmallChange", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Максимум")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Maximum", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Минимум")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Minimum", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль бегунка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TickStyle", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Частота отметок")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TickFrequency", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать в трее")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowInTray", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Подсказка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToolTip", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Добавить в автозагрузку")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoRun", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Разрешить запуск копий")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowRunCopies", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Разрешить вводить")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль загрузки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StyleProgress", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скорость анимации")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MarqueeAnimationSpeed", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шаг загрузки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StepProgress", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Справа налево")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RightToLeftLayout", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запретить минимизировать")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForbidMinimize", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запретить разворачивать")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForbidMaximize", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ассоциировать с расширениями")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AssociateWithExtensions", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ассоциированый принятый файл")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AssociationPassedFile", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Страница начала печати")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FromPage", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Страница конца печати")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToPage", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Число копий")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Copies", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина столбцов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WidthOfColumns", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вышина строк")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HeightOfRows", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("На весь экран")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OnFullScreen", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Переходить по сссылкам")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowNavigation", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Разрешить перетаскивания")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowWebBrowserDrop", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Назад возможно")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CanGoBack", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вперед возможно")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CanGoForward", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст страницы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DocumentText", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Заголовок страницы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DocumentTitle", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Тип страницы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DocumentType", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Браузер занят")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "isBusy", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Браузер offline")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "isOffline", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающее меню браузера")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "isWebBrowserContextMunuEnabled", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Статус готовности")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReadyState", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Статусная строка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StatusText", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать ошибки сценариев")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ScriptErrorsSuppressed", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Полосы прокрутки активны")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ScrollBarsEnabled", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Url", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Горячие клавиши работают")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WebBrowserShortcutsEnabled", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Кодировка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DocumentEncoding", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Кодировка по умолчанию")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "EncodingDefault", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Куки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cookie", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Открытие ссылок нового окна")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст кнопки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextButton", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст поля")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextField", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сообщение успешной активации")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MessageValid", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сообщение неудачной активации")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MessageInValid", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("ID пользователя")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IdUser", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("ID программы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IdProgram", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("ID в реестре")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IdRegistryProgram", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ключ шифрования")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyEncryption", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Дней триала всего")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DaysAll", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Дней триала осталось")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DaysLeft", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Активирована")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Activation", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Примечание")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Remark", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Триальный период запущен")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TrialStarted", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ключ активации выдать")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj5 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array6 = array4;
					bool[] array3 = new bool[1] { true };
					object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "KeyIssue", array6, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj6));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ключ активации проверить")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj7 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array7 = array4;
					bool[] array3 = new bool[1] { true };
					object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "KeyValidation", array7, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj8));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Файл отправляется")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileIsSent", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скрыть отправку файлов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HideSendingFiles", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скрыть отправку текста")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HideSendingText", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скрыть список")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HideComboBox", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Обозначение команд")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CommandSymbol", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Принятая команда")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceivedCommand", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Принятый текст")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceivedText", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Принятый файл")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceivedFile", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправленная команда")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SentCommand", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправленый текст")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SentText", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправленый файл")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SentFile", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Имя в сети")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "NameInNetwork", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("IP для соединения")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RemoteHost", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Порт для соединения")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RemotePort", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Папка для загрузок")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PathForDownloads", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Тип клиент сервера")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClientServerType", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Имена клиентов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClientsNames", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст поля ввода")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextBoxString", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст поля лога")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextBoxLog", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ip клиентов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClientsIPs", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ip клиента")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj9 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array8 = array4;
					bool[] array3 = new bool[1] { true };
					object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "GetClientIp", array8, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj10));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Удерживать соединение")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeepAlive", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Автоматически перенаправляться")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowAutoRedirect", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка запроса")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UrlToGo", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка откуда пришли")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UrlReferer", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка перенаправления")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UrlRedirect", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Тип браузера")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UserAgent", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Принимать")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Accept", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокси IP")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ProxyIp", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокси порт")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ProxyPort", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Кодировка страницы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "EncodingPage", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Язык страницы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LanguagePage", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Содержимое запроса")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContentQuery", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Тип содержимого")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContentType", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Длинна содержимого")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContentLength", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Метод запроса")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HttpMethod", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Код результата")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ResultCode", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Таймаут")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TimeOut", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Время задержки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TimeDelay", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Заголовки запроса")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Headers", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Куки запросов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CookiesQueries", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Результат запроса")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ResultQuery", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Размер буфера")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BufferSize", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скачивается файл")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileDownloading", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скачка пауза")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DownloadPause", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Наличие соединения")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckConnect", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить добавлять строки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToAddRows", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить удалять строки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToDeleteRows", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить переставлять столбцы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToOrderColumns", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить растягивать столбцы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToResizeColumns", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить растягивать строки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToResizeRows", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль рамки ячейки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CellBorderStyle", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать заголовки столбцов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnHeadersVisible", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать специальный столбец")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowHeadersVisible", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вышина заголовков столбцов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnHeadersHeight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Столбцы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Строки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет фона ячеек")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultCellStyleBackColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет фона выделенных ячеек")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultCellStyleSelectionBackColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет шрифта ячеек")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultCellStyleForeColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет шрифта выделенных ячеек")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultCellStyleSelectionForeColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Режим редактирования")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "EditMode", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет сетки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GridColor", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбор нескольких ячеек")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MultiSelect", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбор нескольких записей")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MultiSelectItems", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Только для чтения таблица")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReadOnlyTable", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Режим выделения")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionMode", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номера выделенных строк")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedRows", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номера выделенных столбцов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedColumns", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество строк таблицы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowsCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество столбцов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnsCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество выделенных строк")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedRowsCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество выделенных столбцов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedColumnsCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Значение ячейки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj11 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array9 = array4;
					bool[] array3 = new bool[1] { true };
					object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "ItemValue", array9, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj12));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ячейка выделена")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj13 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array10 = array4;
					bool[] array3 = new bool[1] { true };
					object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "ItemSelected", array10, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj14));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Строка только для чтения")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj15 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array11 = array4;
					bool[] array3 = new bool[1] { true };
					object obj16 = NewLateBinding.LateGet(obj15, (Type)null, "RowsReadOnly", array11, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj16));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Столбец только для чтения")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj17 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array12 = array4;
					bool[] array3 = new bool[1] { true };
					object obj18 = NewLateBinding.LateGet(obj17, (Type)null, "ColumnReadOnly", array12, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj18));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ячейка только для чтения")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj19 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array13 = array4;
					bool[] array3 = new bool[1] { true };
					object obj20 = NewLateBinding.LateGet(obj19, (Type)null, "ItemReadOnly", array13, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj20));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина столбца")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj21 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array14 = array4;
					bool[] array3 = new bool[1] { true };
					object obj22 = NewLateBinding.LateGet(obj21, (Type)null, "ColumnsWidth", array14, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj22));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вышина строки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj23 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array15 = array4;
					bool[] array3 = new bool[1] { true };
					object obj24 = NewLateBinding.LateGet(obj23, (Type)null, "RowsHeight", array15, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj24));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер первой строки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					args[0] = peremens.NikakoiEsli(args[0]);
					int num2 = peremens.Filters.IndexOfKey(Strings.LCase(args[0]));
					if (num2 == -1)
					{
						errString.err = Errors.notCollection(prop, args[0], peremens.HWFilters);
						return errString;
					}
					object obj25 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array16 = array4;
					bool[] array3 = new bool[1] { true };
					object obj26 = NewLateBinding.LateGet(obj25, (Type)null, "GetFirstRow", array16, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj26));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер последней строки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					args[0] = peremens.NikakoiEsli(args[0]);
					int num3 = peremens.Filters.IndexOfKey(Strings.LCase(args[0]));
					if (num3 == -1)
					{
						errString.err = Errors.notCollection(prop, args[0], peremens.HWFilters);
						return errString;
					}
					object obj27 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array17 = array4;
					bool[] array3 = new bool[1] { true };
					object obj28 = NewLateBinding.LateGet(obj27, (Type)null, "GetLastRow", array17, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj28));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер следующей строки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					args[1] = peremens.NikakoiEsli(args[1]);
					int num4 = peremens.Filters.IndexOfKey(Strings.LCase(args[1]));
					if (num4 == -1)
					{
						errString.err = Errors.notCollection(prop, args[1], peremens.HWFilters);
						return errString;
					}
					object obj29 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array18 = array4;
					bool[] array3 = new bool[1] { true };
					object obj30 = NewLateBinding.LateGet(obj29, (Type)null, "GetNextRow", array18, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj30));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер предыдущей строки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					args[1] = peremens.NikakoiEsli(args[1]);
					int num5 = peremens.Filters.IndexOfKey(Strings.LCase(args[1]));
					if (num5 == -1)
					{
						errString.err = Errors.notCollection(prop, args[1], peremens.HWFilters);
						return errString;
					}
					object obj31 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array19 = array4;
					bool[] array3 = new bool[1] { true };
					object obj32 = NewLateBinding.LateGet(obj31, (Type)null, "GetPreviousRow", array19, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj32));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Значение по координатам")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj33 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array20 = array4;
					bool[] array3 = new bool[1] { true };
					object obj34 = NewLateBinding.LateGet(obj33, (Type)null, "HitTest", array20, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj34));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер строки по координатам")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj35 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array21 = array4;
					bool[] array3 = new bool[1] { true };
					object obj36 = NewLateBinding.LateGet(obj35, (Type)null, "HitTestRow", array21, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj36));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер столбца по координатам")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj37 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array22 = array4;
					bool[] array3 = new bool[1] { true };
					object obj38 = NewLateBinding.LateGet(obj37, (Type)null, "HitTestColumn", array22, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj38));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Значение выделеных ячеек")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedItemsValue", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поиск в таблице")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 5)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj39 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array23 = array4;
					bool[] array3 = new bool[1] { true };
					object obj40 = NewLateBinding.LateGet(obj39, (Type)null, "SearchInTable", array23, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj40));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поиск в выделеных ячейках")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 3)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj41 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array24 = array4;
					bool[] array3 = new bool[1] { true };
					object obj42 = NewLateBinding.LateGet(obj41, (Type)null, "SearchInSelectedCells", array24, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj42));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Скрытый")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj43 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array25 = array4;
					bool[] array3 = new bool[1] { true };
					object obj44 = NewLateBinding.LateGet(obj43, (Type)null, "Hider", array25, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj44));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Только для чтения")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj45 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array26 = array4;
					bool[] array3 = new bool[1] { true };
					object obj46 = NewLateBinding.LateGet(obj45, (Type)null, "FileReadOnly", array26, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj46));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Архивный")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj47 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array27 = array4;
					bool[] array3 = new bool[1] { true };
					object obj48 = NewLateBinding.LateGet(obj47, (Type)null, "Archive", array27, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj48));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Папка")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj49 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array28 = array4;
					bool[] array3 = new bool[1] { true };
					object obj50 = NewLateBinding.LateGet(obj49, (Type)null, "Papka", array28, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj50));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Зашифрованный")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj51 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array29 = array4;
					bool[] array3 = new bool[1] { true };
					object obj52 = NewLateBinding.LateGet(obj51, (Type)null, "Encrypted", array29, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj52));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Не индексируется")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj53 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array30 = array4;
					bool[] array3 = new bool[1] { true };
					object obj54 = NewLateBinding.LateGet(obj53, (Type)null, "NotIndexer", array30, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj54));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Системный")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj55 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array31 = array4;
					bool[] array3 = new bool[1] { true };
					object obj56 = NewLateBinding.LateGet(obj55, (Type)null, "Systemiy", array31, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj56));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Временный")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj57 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array32 = array4;
					bool[] array3 = new bool[1] { true };
					object obj58 = NewLateBinding.LateGet(obj57, (Type)null, "Temp", array32, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj58));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Время создания")), false) == 0)
				{
					if (args == null)
					{
						return new peremens.ErrString(peremens.ToMyDate(DateAndTime.get_Now()));
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj59 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array33 = array4;
					bool[] array3 = new bool[1] { true };
					object obj60 = NewLateBinding.LateGet(obj59, (Type)null, "CreateTime", array33, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj60));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Время доступа")), false) == 0)
				{
					if (args == null)
					{
						return new peremens.ErrString(peremens.ToMyDate(DateAndTime.get_Now()));
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj61 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array34 = array4;
					bool[] array3 = new bool[1] { true };
					object obj62 = NewLateBinding.LateGet(obj61, (Type)null, "AccessTime", array34, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj62));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Время изменения")), false) == 0)
				{
					if (args == null)
					{
						return new peremens.ErrString(peremens.ToMyDate(DateAndTime.get_Now()));
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj63 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array35 = array4;
					bool[] array3 = new bool[1] { true };
					object obj64 = NewLateBinding.LateGet(obj63, (Type)null, "EditTime", array35, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj64));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Существует файл")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.FileExistInArgs(args, 0, errString).err, "", false) != 0)
					{
						return new peremens.ErrString(peremens.trans("Нет"));
					}
					object obj65 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array36 = array4;
					bool[] array3 = new bool[1] { true };
					object obj66 = NewLateBinding.LateGet(obj65, (Type)null, "ExistFile", array36, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj66));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Существует папка")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.FileExistInArgs(args, 0, errString).err, "", false) != 0)
					{
						return new peremens.ErrString(peremens.trans("Нет"));
					}
					object obj67 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array37 = array4;
					bool[] array3 = new bool[1] { true };
					object obj68 = NewLateBinding.LateGet(obj67, (Type)null, "ExistPath", array37, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj68));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Получить файлы")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj69 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array38 = array4;
					bool[] array3 = new bool[1] { true };
					object obj70 = NewLateBinding.LateGet(obj69, (Type)null, "GetFiles", array38, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj70));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Получить папки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj71 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array39 = array4;
					bool[] array3 = new bool[1] { true };
					object obj72 = NewLateBinding.LateGet(obj71, (Type)null, "ExistPath", array39, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					if (Operators.ConditionalCompareObjectEqual(obj72, (object)peremens.trans("Нет"), false))
					{
						errString.err = Errors.PathNotExist(args[0]);
						return errString;
					}
					object obj73 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					array4 = new object[1] { args };
					object[] array40 = array4;
					array3 = new bool[1] { true };
					object obj74 = NewLateBinding.LateGet(obj73, (Type)null, "GetPaths", array40, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj74));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Получить диски")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetDrives", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Определить корневую")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj75 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array41 = array4;
					bool[] array3 = new bool[1] { true };
					object obj76 = NewLateBinding.LateGet(obj75, (Type)null, "GetRoot", array41, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj76));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Определить родительскую")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
					{
						return errString;
					}
					if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
					{
						errString.err = Errors.InvalidPathChars(args[0]);
						return errString;
					}
					object obj77 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array42 = array4;
					bool[] array3 = new bool[1] { true };
					object obj78 = NewLateBinding.LateGet(obj77, (Type)null, "GetParent", array42, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj78));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Определить имя папки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					object obj79 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array43 = array4;
					bool[] array3 = new bool[1] { true };
					object obj80 = NewLateBinding.LateGet(obj79, (Type)null, "GetPathName", array43, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj80));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Определить имя файла")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
					{
						return errString;
					}
					if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
					{
						errString.err = Errors.InvalidPathChars(args[0]);
						return errString;
					}
					object obj81 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array44 = array4;
					bool[] array3 = new bool[1] { true };
					object obj82 = NewLateBinding.LateGet(obj81, (Type)null, "GetFileName", array44, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj82));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Определить расширение")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
					{
						return errString;
					}
					if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
					{
						errString.err = Errors.InvalidPathChars(args[0]);
						return errString;
					}
					object obj83 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array45 = array4;
					bool[] array3 = new bool[1] { true };
					object obj84 = NewLateBinding.LateGet(obj83, (Type)null, "GetExtension", array45, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj84));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Определить без расширения")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
					{
						return errString;
					}
					if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
					{
						errString.err = Errors.InvalidPathChars(args[0]);
						return errString;
					}
					object obj85 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array46 = array4;
					bool[] array3 = new bool[1] { true };
					object obj86 = NewLateBinding.LateGet(obj85, (Type)null, "GetFileNameWithoutExtension", array46, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj86));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Определить размер файла")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
					{
						return errString;
					}
					if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
					{
						errString.err = Errors.InvalidPathChars(args[0]);
						return errString;
					}
					object obj87 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array47 = array4;
					bool[] array3 = new bool[1] { true };
					object obj88 = NewLateBinding.LateGet(obj87, (Type)null, "GetFileSize", array47, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj88));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Поиск файлов")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					if (Operators.CompareString(peremens.NikakoiEsli(args[1]), peremens.trans("Никакой"), false) == 0)
					{
						return errString;
					}
					if (args[1].Split(Path.GetInvalidPathChars()).Length > 1)
					{
						errString.err = Errors.InvalidPathChars(args[1]);
						return errString;
					}
					object obj89 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array48 = array4;
					bool[] array3 = new bool[1] { true };
					object obj90 = NewLateBinding.LateGet(obj89, (Type)null, "FindFile", array48, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj90));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Открыть файл")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
					{
						return errString;
					}
					if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
					{
						errString.err = Errors.InvalidPathChars(args[0]);
						return errString;
					}
					errString = peremens.FileExistInArgs(args, 0, errString);
					if (Operators.CompareString(errString.err, "", false) != 0)
					{
						return errString;
					}
					args[1] = peremens.NikakoiEsli(args[1]);
					object obj91 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array49 = array4;
					bool[] array3 = new bool[1] { true };
					object obj92 = NewLateBinding.LateGet(obj91, (Type)null, "OpenFile", array49, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj92));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Количество файлов")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
					{
						return errString;
					}
					if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
					{
						errString.err = Errors.InvalidPathChars(args[0]);
						return errString;
					}
					object obj93 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array50 = array4;
					bool[] array3 = new bool[1] { true };
					object obj94 = NewLateBinding.LateGet(obj93, (Type)null, "FilesCount", array50, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj94));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Количество папок")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
					{
						return errString;
					}
					if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
					{
						errString.err = Errors.InvalidPathChars(args[0]);
						return errString;
					}
					object obj95 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array51 = array4;
					bool[] array3 = new bool[1] { true };
					object obj96 = NewLateBinding.LateGet(obj95, (Type)null, "DirectoriesCount", array51, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj96));
					return result2;
				}
				peremens.ErrString errString2 = default(peremens.ErrString);
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Завершить программу")), false) == 0)
				{
					object obj97 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BreakApplication", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj97 != null) ? ((peremens.ErrString)obj97) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Завершить событие")), false) == 0)
				{
					object obj98 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BreakEvent", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj98 != null) ? ((peremens.ErrString)obj98) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Завершить цикл")), false) == 0)
				{
					object obj99 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BreakLoop", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj99 != null) ? ((peremens.ErrString)obj99) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Завершить условие")), false) == 0)
				{
					object obj100 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StopIf", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj100 != null) ? ((peremens.ErrString)obj100) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Пропускать ошибки")), false) == 0)
				{
					object obj101 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IgnoreErrors", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj101 != null) ? ((peremens.ErrString)obj101) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Рисунок рабочего стола")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WallPaper", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Стиль рабочего стола")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DesktopStyle", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Разрешение экрана")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DesktopResolution", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Частота экрана")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DesktopFrequency", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Качество цветопередачи")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DesktopBits", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Заставка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ScreenSaver", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Скриншот")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NetTakNet(args[0]), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(args[0]);
						return errString;
					}
					args[0] = peremens.NetTakNet(args[0]);
					object obj102 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array52 = array4;
					bool[] array3 = new bool[1] { true };
					object obj103 = NewLateBinding.LateGet(obj102, (Type)null, "ScreenShot", array52, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj103));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Скриншот объекта")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj104 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array53 = array4;
					bool[] array3 = new bool[1] { true };
					object obj105 = NewLateBinding.LateGet(obj104, (Type)null, "ScreenshotOfObject", array53, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj105));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Мышь X")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MouseX", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Мышь Y")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MouseY", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Клавиша клавиатуры")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyboardKey", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Нажат альт")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyboardAlt", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Нажат шифт")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyboardShift", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Нажат контрол")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyboardControl", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Нажата мыши левая")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MouseLeft", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Нажата мыши правая")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MouseRight", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Рисунок буфера обмена")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClipboardPicture", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Текст буфера обмена")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClipboardText", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Выполнить с результатом")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 3)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj106 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array54 = array4;
					bool[] array3 = new bool[1] { true };
					object obj107 = NewLateBinding.LateGet(obj106, (Type)null, "RunWithResult", array54, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj107));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Процессы системы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ProcessesList", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Окна системы")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowsList", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Окно в фокусе")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowInFocus", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Значение реестра")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					string allPath = args[0];
					string name = "";
					if (peremens.GetRegistryKey(allPath, ref name) == null)
					{
						errString.err = Errors.notRegistry(args[0]);
						return errString;
					}
					object obj108 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array55 = array4;
					bool[] array3 = new bool[1] { true };
					object obj109 = NewLateBinding.LateGet(obj108, (Type)null, "Key", array55, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj109));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Ключ существует")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj110 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array56 = array4;
					bool[] array3 = new bool[1] { true };
					object obj111 = NewLateBinding.LateGet(obj110, (Type)null, "ExistKey", array56, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj111));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Папка существует")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj112 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array57 = array4;
					bool[] array3 = new bool[1] { true };
					object obj113 = NewLateBinding.LateGet(obj112, (Type)null, "ExistSubKey", array57, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj113));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Тип ключа")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj114 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array58 = array4;
					bool[] array3 = new bool[1] { true };
					object obj115 = NewLateBinding.LateGet(obj114, (Type)null, "TypeKey", array58, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj115));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер символа по координатам")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj116 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array59 = array4;
					bool[] array3 = new bool[1] { true };
					object obj117 = NewLateBinding.LateGet(obj116, (Type)null, "GetCharIndexFromPosition", array59, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj117));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер первого символа строки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (peremens.Int(args[0]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[0], prop);
						return errString;
					}
					object obj118 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array60 = array4;
					bool[] array3 = new bool[1] { true };
					object obj119 = NewLateBinding.LateGet(obj118, (Type)null, "GetFirstCharIndexFromLine", array60, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj119));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер первого символа текущей строки")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetFirstCharIndexOfCurrentLine", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер строки по номеру символа")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (peremens.Int(args[0]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[0], prop);
						return errString;
					}
					object obj120 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array61 = array4;
					bool[] array3 = new bool[1] { true };
					object obj121 = NewLateBinding.LateGet(obj120, (Type)null, "GetLineFromCharIndex", array61, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj121));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("X по номеру символа")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (peremens.Int(args[0]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[0], prop);
						return errString;
					}
					object obj122 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array62 = array4;
					bool[] array3 = new bool[1] { true };
					object obj123 = NewLateBinding.LateGet(obj122, (Type)null, "GetXFromCharIndex", array62, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj123));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Y по номеру символа")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (peremens.Int(args[0]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[0], prop);
						return errString;
					}
					object obj124 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array63 = array4;
					bool[] array3 = new bool[1] { true };
					object obj125 = NewLateBinding.LateGet(obj124, (Type)null, "GetYFromCharIndex", array63, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj125));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Строка")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (peremens.Int(args[0]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[0], prop);
						return errString;
					}
					object obj126 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array64 = array4;
					bool[] array3 = new bool[1] { true };
					object obj127 = NewLateBinding.LateGet(obj126, (Type)null, "Line", array64, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj127));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество строк")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinesCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Символ")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (peremens.Int(args[0]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[0], prop);
						return errString;
					}
					object obj128 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array65 = array4;
					bool[] array3 = new bool[1] { true };
					object obj129 = NewLateBinding.LateGet(obj128, (Type)null, "Chars", array65, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj129));
					return result2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество символов")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CharsLength", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Символ по номеру")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					if (Conversions.ToDouble(args[1]) > (double)(args[0].Length + 1))
					{
						errString.err = Errors.notLength(prop, args[0], args[1]);
						return errString;
					}
					if (peremens.Int(args[1]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[1], prop);
						return errString;
					}
					object obj130 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array66 = array4;
					bool[] array3 = new bool[1] { true };
					object obj131 = NewLateBinding.LateGet(obj130, (Type)null, "Chars", array66, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj131));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Сравнить тексты")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj132 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array67 = array4;
					bool[] array3 = new bool[1] { true };
					object obj133 = NewLateBinding.LateGet(obj132, (Type)null, "Compare", array67, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj133));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Текст состоит из")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj134 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array68 = array4;
					bool[] array3 = new bool[1] { true };
					object obj135 = NewLateBinding.LateGet(obj134, (Type)null, "ConsistAll", array68, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj135));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Текст есть число")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj136 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array69 = array4;
					bool[] array3 = new bool[1] { true };
					object obj137 = NewLateBinding.LateGet(obj136, (Type)null, "isNumberText", array69, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj137));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Текст есть цифры")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj138 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array70 = array4;
					bool[] array3 = new bool[1] { true };
					object obj139 = NewLateBinding.LateGet(obj138, (Type)null, "isNumericText", array70, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj139));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск номера строки")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[2]))
					{
						errString.err = Errors.notInt(args[2], prop);
						return errString;
					}
					if (Conversions.ToDouble(args[2]) > (double)(args[0].Length + 1))
					{
						errString.err = Errors.notLength(prop, args[0], args[2]);
						return errString;
					}
					if (peremens.Int(args[2]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[2], prop);
						return errString;
					}
					object obj140 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array71 = array4;
					bool[] array3 = new bool[1] { true };
					object obj141 = NewLateBinding.LateGet(obj140, (Type)null, "IndexOfLine", array71, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj141));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск в тексте")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[2]))
					{
						errString.err = Errors.notInt(args[2], prop);
						return errString;
					}
					if (Conversions.ToDouble(args[2]) > (double)(args[0].Length + 1))
					{
						errString.err = Errors.notLength(prop, args[0], args[2]);
						return errString;
					}
					if (peremens.Int(args[2]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[2], prop);
						return errString;
					}
					object obj142 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array72 = array4;
					bool[] array3 = new bool[1] { true };
					object obj143 = NewLateBinding.LateGet(obj142, (Type)null, "IndexOfIgnoreCase", array72, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj143));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск с учетом регистра")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[2]))
					{
						errString.err = Errors.notInt(args[2], prop);
						return errString;
					}
					if (Conversions.ToDouble(args[2]) > (double)(args[0].Length + 1))
					{
						errString.err = Errors.notLength(prop, args[0], args[2]);
						return errString;
					}
					if (peremens.Int(args[2]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[2], prop);
						return errString;
					}
					object obj144 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array73 = array4;
					bool[] array3 = new bool[1] { true };
					object obj145 = NewLateBinding.LateGet(obj144, (Type)null, "IndexOf", array73, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj145));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск в тексте с конца")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[2]))
					{
						errString.err = Errors.notInt(args[2], prop);
						return errString;
					}
					if (peremens.Int(args[2]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[2], prop);
						return errString;
					}
					object obj146 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array74 = array4;
					bool[] array3 = new bool[1] { true };
					object obj147 = NewLateBinding.LateGet(obj146, (Type)null, "LastIndexOfIgnoreCase", array74, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj147));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск с регулярными выражениями")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj148 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array75 = array4;
					bool[] array3 = new bool[1] { true };
					object obj149 = NewLateBinding.LateGet(obj148, (Type)null, "IndexOfRegular", array75, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj149));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Количество символов")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj150 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array76 = array4;
					bool[] array3 = new bool[1] { true };
					object obj151 = NewLateBinding.LateGet(obj150, (Type)null, "CharsLength", array76, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj151));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разбить на части")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 3)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[2]))
					{
						errString.err = Errors.notInt(args[2], prop);
						return errString;
					}
					if (peremens.Int(args[2]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[2], prop);
						return errString;
					}
					object obj152 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array77 = array4;
					bool[] array3 = new bool[1] { true };
					object obj153 = NewLateBinding.LateGet(obj152, (Type)null, "Split", array77, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj153));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Взять кусок текста")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 3)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					if (Conversions.ToDouble(args[1]) > (double)(args[0].Length + 1))
					{
						errString.err = Errors.notLength(prop, args[0], args[1]);
						return errString;
					}
					if (peremens.Int(args[1]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[1], prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[2]))
					{
						errString.err = Errors.notInt(args[2], prop);
						return errString;
					}
					object obj154 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array78 = array4;
					bool[] array3 = new bool[1] { true };
					object obj155 = NewLateBinding.LateGet(obj154, (Type)null, "Substring", array78, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj155));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Количество частей текста")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj156 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array79 = array4;
					bool[] array3 = new bool[1] { true };
					object obj157 = NewLateBinding.LateGet(obj156, (Type)null, "SplitCount", array79, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj157));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Кавычки убрать")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj158 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array80 = array4;
					bool[] array3 = new bool[1] { true };
					object obj159 = NewLateBinding.LateGet(obj158, (Type)null, "DeleteQuotes", array80, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj159));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Кавычками обособить")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj160 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array81 = array4;
					bool[] array3 = new bool[1] { true };
					object obj161 = NewLateBinding.LateGet(obj160, (Type)null, "PutInQuotes", array81, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj161));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск без кавычек")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[2]))
					{
						errString.err = Errors.notInt(args[2], prop);
						return errString;
					}
					if (Conversions.ToDouble(args[2]) > (double)(args[0].Length + 1))
					{
						errString.err = Errors.notLength(prop, args[0], args[2]);
						return errString;
					}
					if (peremens.Int(args[2]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[2], prop);
						return errString;
					}
					object obj162 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array82 = array4;
					bool[] array3 = new bool[1] { true };
					object obj163 = NewLateBinding.LateGet(obj162, (Type)null, "IndexOfWithoutQuotes", array82, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj163));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разбить на части без кавычек")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 3)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[2]))
					{
						errString.err = Errors.notInt(args[2], prop);
						return errString;
					}
					if (peremens.Int(args[2]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[2], prop);
						return errString;
					}
					object obj164 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array83 = array4;
					bool[] array3 = new bool[1] { true };
					object obj165 = NewLateBinding.LateGet(obj164, (Type)null, "SplitWithoutQuotes", array83, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj165));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Количество частей без кавычек")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj166 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array84 = array4;
					bool[] array3 = new bool[1] { true };
					object obj167 = NewLateBinding.LateGet(obj166, (Type)null, "SplitWithoutQuotesCount", array84, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj167));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Текст содержит")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj168 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array85 = array4;
					bool[] array3 = new bool[1] { true };
					object obj169 = NewLateBinding.LateGet(obj168, (Type)null, "Consist", array85, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj169));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Текст не содержит")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj170 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array86 = array4;
					bool[] array3 = new bool[1] { true };
					object obj171 = NewLateBinding.LateGet(obj170, (Type)null, "ConsistNo", array86, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj171));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Строка по номеру")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					if (peremens.Int(args[1]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[1], prop);
						return errString;
					}
					object obj172 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array87 = array4;
					bool[] array3 = new bool[1] { true };
					object obj173 = NewLateBinding.LateGet(obj172, (Type)null, "Line", array87, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj173));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Количество строк")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj174 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array88 = array4;
					bool[] array3 = new bool[1] { true };
					object obj175 = NewLateBinding.LateGet(obj174, (Type)null, "LinesCount", array88, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj175));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Зашифровать текст")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj176 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array89 = array4;
					bool[] array3 = new bool[1] { true };
					object obj177 = NewLateBinding.LateGet(obj176, (Type)null, "EncryptText", array89, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj177));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Расшифровать текст")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj178 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array90 = array4;
					bool[] array3 = new bool[1] { true };
					object obj179 = NewLateBinding.LateGet(obj178, (Type)null, "DecryptText", array90, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj179));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Вставить символы в текст")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 3)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					if (peremens.Int(args[1]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[1], prop);
						return errString;
					}
					if (Conversions.ToDouble(args[1]) > (double)(args[0].Length + 1))
					{
						errString.err = Errors.notLength(prop, args[0], args[1]);
						return errString;
					}
					object obj180 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array91 = array4;
					bool[] array3 = new bool[1] { true };
					object obj181 = NewLateBinding.LateGet(obj180, (Type)null, "Insert", array91, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj181));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Удалить кусок текста")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 3)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					if (Conversions.ToDouble(args[1]) > (double)(args[0].Length + 1))
					{
						errString.err = Errors.notLength(prop, args[0], args[1]);
						return errString;
					}
					if (peremens.Int(args[1]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[1], prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[2]))
					{
						errString.err = Errors.notInt(args[2], prop);
						return errString;
					}
					object obj182 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array92 = array4;
					bool[] array3 = new bool[1] { true };
					object obj183 = NewLateBinding.LateGet(obj182, (Type)null, "Remove", array92, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj183));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Заменить")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 3)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj184 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array93 = array4;
					bool[] array3 = new bool[1] { true };
					object obj185 = NewLateBinding.LateGet(obj184, (Type)null, "ReplaceOne", array93, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj185));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Заменить все")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 3)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj186 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array94 = array4;
					bool[] array3 = new bool[1] { true };
					object obj187 = NewLateBinding.LateGet(obj186, (Type)null, "ReplaceAll", array94, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj187));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Сделать буквы прописными")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj188 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array95 = array4;
					bool[] array3 = new bool[1] { true };
					object obj189 = NewLateBinding.LateGet(obj188, (Type)null, "toLower", array95, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj189));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Сделать буквы заглавными")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj190 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array96 = array4;
					bool[] array3 = new bool[1] { true };
					object obj191 = NewLateBinding.LateGet(obj190, (Type)null, "toUpper", array96, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj191));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Убрать пробелы")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj192 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array97 = array4;
					bool[] array3 = new bool[1] { true };
					object obj193 = NewLateBinding.LateGet(obj192, (Type)null, "TrimAll", array97, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj193));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Убрать пробелы в начале")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj194 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array98 = array4;
					bool[] array3 = new bool[1] { true };
					object obj195 = NewLateBinding.LateGet(obj194, (Type)null, "TrimStart", array98, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj195));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Убрать пробелы в конце")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj196 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array99 = array4;
					bool[] array3 = new bool[1] { true };
					object obj197 = NewLateBinding.LateGet(obj196, (Type)null, "TrimEnd", array99, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj197));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Отмена")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WasCancel", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Ок")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WasOk", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Повторить")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WasRetry", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Да")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WasYes", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Нет")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WasNo", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Прервать")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WasAbort", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Пропустить")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WasIgnore", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Справка")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WasHelp", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("День месяца")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj198 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array100 = array4;
					bool[] array3 = new bool[1] { true };
					object obj199 = NewLateBinding.LateGet(obj198, (Type)null, "DayOfMonth", array100, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj199));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("День года")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj200 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array101 = array4;
					bool[] array3 = new bool[1] { true };
					object obj201 = NewLateBinding.LateGet(obj200, (Type)null, "DayOfYear", array101, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj201));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("День в неделе")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj202 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array102 = array4;
					bool[] array3 = new bool[1] { true };
					object obj203 = NewLateBinding.LateGet(obj202, (Type)null, "DayOfWeek", array102, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj203));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Час")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj204 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array103 = array4;
					bool[] array3 = new bool[1] { true };
					object obj205 = NewLateBinding.LateGet(obj204, (Type)null, "Hour", array103, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj205));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Минута")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj206 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array104 = array4;
					bool[] array3 = new bool[1] { true };
					object obj207 = NewLateBinding.LateGet(obj206, (Type)null, "Minute", array104, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj207));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Секунда")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj208 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array105 = array4;
					bool[] array3 = new bool[1] { true };
					object obj209 = NewLateBinding.LateGet(obj208, (Type)null, "Second", array105, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj209));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Квартал")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj210 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array106 = array4;
					bool[] array3 = new bool[1] { true };
					object obj211 = NewLateBinding.LateGet(obj210, (Type)null, "Quarter", array106, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj211));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Неделя в году")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj212 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array107 = array4;
					bool[] array3 = new bool[1] { true };
					object obj213 = NewLateBinding.LateGet(obj212, (Type)null, "WeekOfYear", array107, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj213));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Год")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj214 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array108 = array4;
					bool[] array3 = new bool[1] { true };
					object obj215 = NewLateBinding.LateGet(obj214, (Type)null, "Year", array108, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj215));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Месяц")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj216 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array109 = array4;
					bool[] array3 = new bool[1] { true };
					object obj217 = NewLateBinding.LateGet(obj216, (Type)null, "Month", array109, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj217));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Время")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj218 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array110 = array4;
					bool[] array3 = new bool[1] { true };
					object obj219 = NewLateBinding.LateGet(obj218, (Type)null, "Time", array110, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj219));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Секунд всего в дате")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj220 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array111 = array4;
					bool[] array3 = new bool[1] { true };
					object obj221 = NewLateBinding.LateGet(obj220, (Type)null, "Ticks", array111, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj221));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Дней в месяце")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[0]))
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (peremens.Int(args[0]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[0], prop);
						return errString;
					}
					if (peremens.Int(args[0]) > 9999)
					{
						errString.err = Errors.notInt(args[0], prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					if (peremens.Int(args[1]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[1], prop);
						return errString;
					}
					if (peremens.Int(args[1]) > 12)
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj222 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array112 = array4;
					bool[] array3 = new bool[1] { true };
					object obj223 = NewLateBinding.LateGet(obj222, (Type)null, "DaysInMonth", array112, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj223));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Сейчас")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Now", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Сегодня")), false) == 0)
				{
					return new peremens.ErrString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Today", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить дни")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj224 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array113 = array4;
					bool[] array3 = new bool[1] { true };
					object obj225 = NewLateBinding.LateGet(obj224, (Type)null, "DateAddDay", array113, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj225));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить часы")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj226 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array114 = array4;
					bool[] array3 = new bool[1] { true };
					object obj227 = NewLateBinding.LateGet(obj226, (Type)null, "DateAddHour", array114, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj227));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить минуты")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj228 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array115 = array4;
					bool[] array3 = new bool[1] { true };
					object obj229 = NewLateBinding.LateGet(obj228, (Type)null, "DateAddMinute", array115, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj229));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить секунды")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj230 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array116 = array4;
					bool[] array3 = new bool[1] { true };
					object obj231 = NewLateBinding.LateGet(obj230, (Type)null, "DateAddSecond", array116, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj231));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить кварталы")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj232 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array117 = array4;
					bool[] array3 = new bool[1] { true };
					object obj233 = NewLateBinding.LateGet(obj232, (Type)null, "DateAddQuarter", array117, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj233));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить недели")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj234 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array118 = array4;
					bool[] array3 = new bool[1] { true };
					object obj235 = NewLateBinding.LateGet(obj234, (Type)null, "DateAddWeek", array118, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj235));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить годы")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj236 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array119 = array4;
					bool[] array3 = new bool[1] { true };
					object obj237 = NewLateBinding.LateGet(obj236, (Type)null, "DateAddYear", array119, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj237));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить месяцы")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj238 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array120 = array4;
					bool[] array3 = new bool[1] { true };
					object obj239 = NewLateBinding.LateGet(obj238, (Type)null, "DateAddMonth", array120, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj239));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в днях")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj240 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array121 = array4;
					bool[] array3 = new bool[1] { true };
					object obj241 = NewLateBinding.LateGet(obj240, (Type)null, "DateDiffDay", array121, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj241));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в часах")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj242 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array122 = array4;
					bool[] array3 = new bool[1] { true };
					object obj243 = NewLateBinding.LateGet(obj242, (Type)null, "DateDiffHour", array122, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj243));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в минутах")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj244 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array123 = array4;
					bool[] array3 = new bool[1] { true };
					object obj245 = NewLateBinding.LateGet(obj244, (Type)null, "DateDiffMinute", array123, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj245));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в секундах")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj246 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array124 = array4;
					bool[] array3 = new bool[1] { true };
					object obj247 = NewLateBinding.LateGet(obj246, (Type)null, "DateDiffSecond", array124, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj247));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в кварталах")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj248 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array125 = array4;
					bool[] array3 = new bool[1] { true };
					object obj249 = NewLateBinding.LateGet(obj248, (Type)null, "DateDiffQuarter", array125, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj249));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в неделях")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj250 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array126 = array4;
					bool[] array3 = new bool[1] { true };
					object obj251 = NewLateBinding.LateGet(obj250, (Type)null, "DateDiffWeek", array126, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj251));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в годах")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj252 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array127 = array4;
					bool[] array3 = new bool[1] { true };
					object obj253 = NewLateBinding.LateGet(obj252, (Type)null, "DateDiffYear", array127, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj253));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в месяцах")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj254 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array128 = array4;
					bool[] array3 = new bool[1] { true };
					object obj255 = NewLateBinding.LateGet(obj254, (Type)null, "DateDiffMonth", array128, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj255));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("День недели")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj256 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array129 = array4;
					bool[] array3 = new bool[1] { true };
					object obj257 = NewLateBinding.LateGet(obj256, (Type)null, "WeekdayName", array129, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj257));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Название месяца")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj258 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array130 = array4;
					bool[] array3 = new bool[1] { true };
					object obj259 = NewLateBinding.LateGet(obj258, (Type)null, "MonthName", array130, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj259));
					return result2;
				}
				if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Дата в определенном формате")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (!Iz.isInteger(ref args[1]))
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					if (peremens.Int(args[1]) <= 0)
					{
						errString.err = Errors.notLessEqZero(args[1], prop);
						return errString;
					}
					if (peremens.Int(args[1]) > 53)
					{
						errString.err = Errors.notInt(args[1], prop);
						return errString;
					}
					object obj260 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[1] { args };
					object[] array131 = array4;
					bool[] array3 = new bool[1] { true };
					object obj261 = NewLateBinding.LateGet(obj260, (Type)null, "GetDateTimeFormats", array131, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string[]));
					}
					result2 = new peremens.ErrString(Conversions.ToString(obj261));
					return result2;
				}
			}
			if (flag)
			{
				if (Conversions.ToBoolean(Operators.AndObject((object)(peremens.RunProj.Param.ParamyUp.IndexOfKey(Strings.UCase(prop)) != -1), NewLateBinding.LateGet(MyObj, (Type)null, "isrun", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					return new peremens.ErrString(Conversions.ToString(peremens.RunProj.Param.Paramy.GetByIndex(peremens.RunProj.Param.ParamyUp.IndexOfKey(Strings.UCase(prop)))));
				}
			}
			else
			{
				Sobitiya sobitiya = new Sobitiya(peremens.MyZnak + "All");
				if (Conversions.ToBoolean(Operators.AndObject((object)sobitiya.EstProperty(prop), NewLateBinding.LateGet(MyObj, (Type)null, "isrun", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					return new peremens.ErrString(Conversions.ToString(peremens.RunProj.Param.Paramy.GetByIndex(peremens.RunProj.Param.ParamyUp.IndexOfKey(Strings.UCase(prop)))));
				}
			}
			return new peremens.ErrString(word);
		}
	}

	public static MsgBoxResult SetProperty(object MyObj, string prop, string value, bool fromEng = false)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		prop = Strings.UCase(prop);
		if (MyObj != null)
		{
			if (Array.IndexOf((Array)NewLateBinding.LateGet(MyObj, (Type)null, "PropertysUp", new object[0], (string[])null, (Type[])null, (bool[])null), prop) == -1)
			{
				return (MsgBoxResult)6;
			}
			peremens.ErrString errString = SetPropertyMethod(RuntimeHelpers.GetObjectValue(MyObj), prop, value, null, fromEng);
			if (Operators.CompareString(errString.err, "", false) != 0)
			{
				if (Operators.CompareString(errString.str, "Cancel", false) == 0)
				{
					return (MsgBoxResult)2;
				}
				if ((Operators.CompareString(errString.str, "MsgBox ne nado", false) != 0) & !peremens.IsHttpCompil)
				{
					Interaction.MsgBox((object)errString.err, (MsgBoxStyle)48, (object)null);
				}
				return (MsgBoxResult)7;
			}
			return (MsgBoxResult)6;
		}
		MsgBoxResult result = default(MsgBoxResult);
		return result;
	}

	public static peremens.ErrString SetPropertyMethod(object MyObj, string prop, string value, string[] args, bool fromEng = false)
	{
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Invalid comparison between Unknown and I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Invalid comparison between Unknown and I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Invalid comparison between Unknown and I4
		//IL_126de: Unknown result type (might be due to invalid IL or missing references)
		//IL_126e8: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
		prop = Strings.UCase(prop);
		peremens.ErrString errString = default(peremens.ErrString);
		if (Array.IndexOf(peremens.ReadOnlyProps, prop) != -1)
		{
			errString.err = Errors.isReadOnly(prop);
			return errString;
		}
		value = peremens.perevesti(value, SdelatEnterOrSpecsimvol: true);
		checked
		{
			if (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить код Алгоритма2")), false) != 0 && args != null)
			{
				int num = args.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					args[i] = peremens.perevesti(args[i], SdelatEnterOrSpecsimvol: true);
				}
			}
			string text = prop;
			if (Operators.CompareString(text, Strings.UCase(peremens.trans("Имя")), false) == 0)
			{
				if (!ValidName(value))
				{
					errString.err = Errors.NameInvalid(value);
					errString.str = "MsgBox ne nado";
					return errString;
				}
				unchecked
				{
					bool flag = default(bool);
					if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), (object)(!fromEng)), (object)(!peremens.isConsole))))
					{
						object proj = peremens2.proj;
						object[] array = new object[2]
						{
							value,
							RuntimeHelpers.GetObjectValue(objectValue)
						};
						object[] array2 = array;
						bool[] array3 = new bool[2] { true, true };
						object obj = NewLateBinding.LateGet(proj, (Type)null, "ExistName", array2, (string[])null, (Type[])null, array3);
						if (array3[0])
						{
							value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
						if (array3[1])
						{
							objectValue = RuntimeHelpers.GetObjectValue(array[1]);
						}
						if (Conversions.ToBoolean(obj))
						{
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
							{
								MsgBoxResult val = ((NewLateBinding.LateGet(objectValue, (Type)null, "parent", new object[0], (string[])null, (Type[])null, (bool[])null) == null) ? ((MsgBoxResult)4) : Interaction.MsgBox((object)Errors.CreateMassive(value), (MsgBoxStyle)35, (object)null));
								if ((int)val == 6)
								{
									object obj2 = NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
									object[] array4 = new object[2]
									{
										value,
										RuntimeHelpers.GetObjectValue(MyObj)
									};
									object[] array5 = array4;
									array3 = new bool[2] { true, true };
									NewLateBinding.LateCall(obj2, (Type)null, "CreateMassive", array5, (string[])null, (Type[])null, array3, true);
									if (array3[0])
									{
										value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
									}
									if (array3[1])
									{
										MyObj = RuntimeHelpers.GetObjectValue(array4[1]);
									}
									NewLateBinding.LateSetComplex(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "recur", new object[1] { true }, (string[])null, (Type[])null, false, true);
								}
								else
								{
									if ((int)val == 7)
									{
										Interaction.MsgBox((object)Errors.NameExist(value), (MsgBoxStyle)48, (object)null);
										errString.err = "!";
										errString.str = "MsgBox ne nado";
										return errString;
									}
									if ((int)val == 2)
									{
										errString.err = "!";
										errString.str = "Cancel";
										return errString;
									}
								}
							}
							else
							{
								object obj3 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
								object[] array6 = new object[1];
								object[] array7 = array6;
								object obj4 = NewLateBinding.LateGet(MyObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
								object[] array4 = new object[3]
								{
									value,
									RuntimeHelpers.GetObjectValue(objectValue),
									null
								};
								object[] array8 = array4;
								object obj5 = objectValue;
								object obj6 = obj5;
								array = new object[0];
								object[] array9 = array;
								string[] array10 = null;
								array8[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "Props", array9, array10, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
								object[] array11 = array4;
								object[] array12 = array11;
								array3 = new bool[3] { true, true, true };
								object obj7 = NewLateBinding.LateGet(obj4, (Type)null, "GetIndex", array12, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(string));
								}
								if (array3[1])
								{
									objectValue = RuntimeHelpers.GetObjectValue(array11[1]);
								}
								if (array3[2])
								{
									NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj5, (Type)null, "Props", array, array10, (Type[])null, (bool[])null), (Type)null, "index", new object[1] { RuntimeHelpers.GetObjectValue(array11[2]) }, (string[])null, (Type[])null, true, true);
								}
								array7[0] = RuntimeHelpers.GetObjectValue(obj7);
								NewLateBinding.LateSetComplex(obj3, (Type)null, "index", array6, (string[])null, (Type[])null, false, true);
								flag = true;
							}
							NewLateBinding.LateCall(objectValue, (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						}
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { value }, (string[])null, (Type[])null, false, true);
					if (Conversions.ToBoolean(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						return errString;
					}
					if (flag)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FillListView", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					else if (peremens2.CreateDs != null)
					{
						NewLateBinding.LateCall(peremens2.CreateDs, (Type)null, "SetProperty", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
					}
					if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
					{
						NewLateBinding.LateCall(MyObj, (Type)null, "TabTextRefresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фоновой рисунок")), false) == 0)
			{
				value = peremens.GetMaxPath(value);
				if (!peremens.IsHttpCompil)
				{
					if (!File.Exists(value) & (Operators.CompareString(value, peremens.trans("Никакой"), false) != 0))
					{
						errString.err = Errors.notFile(value);
						return errString;
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
					{
						value = peremens.copyImage(value);
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фоновой рисунок1")), false) == 0)
			{
				value = peremens.GetMaxPath(value);
				if (!peremens.IsHttpCompil)
				{
					if (!File.Exists(value) & (Operators.CompareString(value, peremens.trans("Никакой"), false) != 0))
					{
						errString.err = Errors.notFile(value);
						return errString;
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
					{
						value = peremens.copyImage(value);
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage1", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фоновой рисунок2")), false) == 0)
			{
				value = peremens.GetMaxPath(value);
				if (!peremens.IsHttpCompil)
				{
					if (!File.Exists(value) & (Operators.CompareString(value, peremens.trans("Никакой"), false) != 0))
					{
						errString.err = Errors.notFile(value);
						return errString;
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
					{
						value = peremens.copyImage(value);
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage2", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj8 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj8 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { RuntimeHelpers.GetObjectValue(obj8) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет1")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj9 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj9 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor1", new object[1] { RuntimeHelpers.GetObjectValue(obj9) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет2")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj10 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj10 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor2", new object[1] { RuntimeHelpers.GetObjectValue(obj10) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер")), false) == 0)
			{
				if (NewLateBinding.LateGet(MyObj, (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
				{
					object obj11 = NewLateBinding.LateGet(MyObj, (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array11 = new object[3];
					object[] array13 = array11;
					object obj5 = MyObj;
					array13[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
					object[] array14 = array11;
					object obj12 = MyObj;
					object obj13 = obj12;
					object[] array6 = new object[0];
					object[] array15 = array6;
					string[] array10 = null;
					object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "obj", array15, array10, (Type[])null, (bool[])null);
					object[] array16 = new object[0];
					object[] array17 = array16;
					string[] array18 = null;
					array14[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj14, (Type)null, "Props", array17, array18, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
					array11[2] = value;
					object[] array = array11;
					object[] array19 = array;
					bool[] array3 = new bool[3] { true, true, true };
					object obj15 = NewLateBinding.LateGet(obj11, (Type)null, "ExistIndex", array19, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						NewLateBinding.LateSetComplex(obj5, (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, false);
					}
					if (array3[1])
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj12, (Type)null, "obj", array6, array10, (Type[])null, (bool[])null), (Type)null, "Props", array16, array18, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array[1]) }, (string[])null, (Type[])null, true, true);
					}
					if (array3[2])
					{
						value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(string));
					}
					if (Conversions.ToBoolean(obj15))
					{
						errString.err = "!";
						errString.str = "MsgBox ne nado";
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
						{
							errString.err = Errors.InvalidIndex(value);
							errString.str = "";
						}
						return errString;
					}
				}
				if (Operators.CompareString(value, "", false) == 0)
				{
					object obj16 = NewLateBinding.LateGet(MyObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[3];
					object[] array20 = array6;
					object obj12 = objectValue;
					object obj17 = obj12;
					object[] array21 = new object[0];
					object[] array22 = array21;
					string[] array18 = null;
					array20[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj17, (Type)null, "Props", array22, array18, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
					array6[1] = RuntimeHelpers.GetObjectValue(objectValue);
					array6[2] = "0";
					object[] array16 = array6;
					object[] array23 = array16;
					bool[] array3 = new bool[3] { true, true, false };
					object obj18 = NewLateBinding.LateGet(obj16, (Type)null, "GetIndex", array23, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj12, (Type)null, "Props", array21, array18, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(array16[0]) }, (string[])null, (Type[])null, true, true);
					}
					if (array3[1])
					{
						objectValue = RuntimeHelpers.GetObjectValue(array16[1]);
					}
					value = Conversions.ToString(obj18);
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null)))
				{
					return errString;
				}
				NewLateBinding.LateCall(objectValue, (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					NewLateBinding.LateCall(MyObj, (Type)null, "TabTextRefresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позиция")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "position", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Главная форма")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "mainform", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающее меню")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "contextmenu", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающее меню1")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "contextmenu1", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающее меню2")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "contextmenu2", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запретить закрытие")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForbidClose", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Привязка")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num2 = peremens.Anchors.IndexOfKey(Strings.LCase(value));
				if (num2 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWAnchors);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Anchor", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("АвтоТроеточие")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoEllipsis", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль фона")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num3 = peremens.bkImStyles.IndexOfKey(Strings.LCase(value));
				if (num3 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWbkImStyles);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImageLayout", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль фона1")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num4 = peremens.bkImStyles.IndexOfKey(Strings.LCase(value));
				if (num4 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWbkImStyles);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImageLayout1", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль фона2")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num5 = peremens.bkImStyles.IndexOfKey(Strings.LCase(value));
				if (num5 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWbkImStyles);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImageLayout2", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль рисунка")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num6 = peremens.SizeModes.IndexOfKey(Strings.LCase(value));
				if (num6 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWSizeModes);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SizeMode", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Курсор")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num7 = peremens.Cursori.IndexOfKey(Strings.LCase(value));
				if (num7 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWCursori);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cursor", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Курсор1")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num8 = peremens.Cursori.IndexOfKey(Strings.LCase(value));
				if (num8 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWCursori);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cursor1", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Курсор2")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num9 = peremens.Cursori.IndexOfKey(Strings.LCase(value));
				if (num9 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWCursori);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cursor2", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Растяжка")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num10 = peremens.Docks.IndexOfKey(Strings.LCase(value));
				if (num10 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWDocks);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Dock", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Работает")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль кнопки")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num11 = peremens.FlatStyles.IndexOfKey(Strings.LCase(value));
				if (num11 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWFlatStyles);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FlatStyle", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль рамки")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num12 = peremens.BorderStyles.IndexOfKey(Strings.LCase(value));
				if (num12 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWBorderStyles);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BorderStyle", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num13 = peremens.Fonts.IndexOfKey(Strings.LCase(value));
				if (num13 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWFonts);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontFamily", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт жирный")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontBold", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт курсив")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontItalic", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт подчеркнутый")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontUnderline", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт зачеркнутый")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontStrikeOut", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шрифт размер")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) <= 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontSize", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет шрифта")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj19 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj19 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForeColor", new object[1] { RuntimeHelpers.GetObjectValue(obj19) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Рисунок")), false) == 0)
			{
				value = peremens.GetMaxPath(value);
				if (!peremens.IsHttpCompil)
				{
					if (!File.Exists(value) & (Operators.CompareString(value, peremens.trans("Никакой"), false) != 0))
					{
						errString.err = Errors.notFile(value);
						return errString;
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
					{
						value = peremens.copyImage(value);
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Image", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Положение рисунка")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num14 = peremens.Aligns.IndexOfKey(Strings.LCase(value));
				if (num14 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWAligns);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ImageAlign", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("X")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Y")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Максимальная ширина")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaximumWidth", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Максимальная вышина")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaximumHeight", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Минимальная ширина")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MinimumWidth", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Минимальная вышина")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MinimumHeight", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле слева")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingLeft", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false)), (object)(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null))))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле сверху")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingTop", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false)), (object)(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null))))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле справа")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingRight", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false)), (object)(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null))))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле снизу")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingBottom", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false)), (object)(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null))))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вышина")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
				{
					IzmenenieBylo(withNoMarkerVis: false);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("ТабНомер")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TabIndex", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("ТабСтоп")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TabStop", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вспомогательное поле")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Tag", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Положение текста")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num15 = peremens.Aligns.IndexOfKey(Strings.LCase(value));
				if (num15 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWAligns);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextAlign", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Расположение текста")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num16 = peremens.TextPositions.IndexOfKey(Strings.LCase(value));
				if (num16 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWTextPositions);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextPosition", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст и рисунок")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num17 = peremens.TextImages.IndexOfKey(Strings.LCase(value));
				if (num17 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWTextImages);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextImageRelation", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Видимый")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Scroll", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка1")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Scroll1", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка2")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Scroll2", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фиксированная часть")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num18 = peremens.FixedPanels.IndexOfKey(Strings.LCase(value));
				if (num18 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWFixedPanels);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FixedPanel", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фиксированный разделитель")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FixedSplitter", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Панель1 скрыта")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel1Collapsed", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Панель2 скрыта")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2Collapsed", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ориентация")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num19 = peremens.Orientations.IndexOfKey(Strings.LCase(value));
				if (num19 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWOrientations);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Orientation", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина разделителя")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) <= 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterWidth", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Расстояние разделителя")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterDistance", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Инкремент разделителя")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterIncrement", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Панель1 минимум")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel1MinSize", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Панель2 минимум")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2MinSize", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Отменить перемещение")), false) == 0)
			{
				if (peremens.RunProj.Param.ParamyUp.ContainsKey(peremens.MyZnak + Strings.UCase(peremens.trans("Отменить перемещение"))))
				{
					peremens.RunProj.Param.ParamyUp[peremens.MyZnak + Strings.UCase(peremens.trans("Отменить перемещение"))] = value;
				}
				else
				{
					errString.err = "!";
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Отменить ввод")), false) == 0)
			{
				if (peremens.RunProj.Param.ParamyUp.ContainsKey(peremens.MyZnak + Strings.UCase(peremens.trans("Отменить ввод"))))
				{
					peremens.RunProj.Param.ParamyUp[peremens.MyZnak + Strings.UCase(peremens.trans("Отменить ввод"))] = value;
				}
				else
				{
					errString.err = "!";
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Отменить событие")), false) == 0)
			{
				if (peremens.RunProj.Param.ParamyUp.ContainsKey(peremens.MyZnak + Strings.UCase(peremens.trans("Отменить событие"))))
				{
					peremens.RunProj.Param.ParamyUp[peremens.MyZnak + Strings.UCase(peremens.trans("Отменить событие"))] = value;
				}
				else
				{
					errString.err = "!";
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Отменить в новом окне")), false) == 0)
			{
				if (peremens.RunProj.Param.ParamyUp.ContainsKey(peremens.MyZnak + Strings.UCase(peremens.trans("Отменить в новом окне"))))
				{
					peremens.RunProj.Param.ParamyUp[peremens.MyZnak + Strings.UCase(peremens.trans("Отменить в новом окне"))] = value;
				}
				else
				{
					errString.err = "!";
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скрывать выделение")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HideSelection", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Максимальная длинна")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaximumLength", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Многострочность")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Multiline", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Символ пароля")), false) == 0)
			{
				if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
				{
					value = "";
				}
				if (value.Length > 1)
				{
					errString.err = Errors.notChar(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PasswordChar", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Только для чтения")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReadOnly", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Полосы прокрутки")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num20 = peremens.ScrollBarz.IndexOfKey(Strings.LCase(value));
				if (num20 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWScrollBarz);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ScrollBars", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Перенос по словам")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WordWrap", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный текст")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedText", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Начало выделения")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionStart", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Длинна выделения")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionLength", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отмечено")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Checked", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ориентация инструментов")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num21 = peremens.Orientations.IndexOfKey(Strings.LCase(value));
				if (num21 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWOrientations);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OrientationTools", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Расположен слева")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Alignment", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false)), (object)(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null))))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Показывать подсказку")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoToolTip", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отметка по клику")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckOnClick", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль отображения")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num22 = peremens.DisplayStyles.IndexOfKey(Strings.LCase(value));
				if (num22 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWDisplayStyles);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DisplayStyle", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false)), (object)(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null))))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вложенное всплывающее меню")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DropDown", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Рисунок растянут")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ImageScaling", new object[1] { value }, (string[])null, (Type[])null, false, true);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(peremens2.proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false)), (object)(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null))))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прозрачный цвет рисунка")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj20 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj20 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ImageTransparentColor", new object[1] { RuntimeHelpers.GetObjectValue(obj20) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Горячая клавиша")), false) == 0)
			{
				errString = peremens.UbratKovich(value);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShortcutKeys", new object[1] { errString.str }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать горячие клавиши")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowShortcutKeys", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Направление текста")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num23 = peremens.TextDirections.IndexOfKey(Strings.LCase(value));
				if (num23 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWTextDirections);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextDirection", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающая подсказка")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToolTipText", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Переходить по сссылкам")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowNavigation", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Разрешить перетаскивания")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowWebBrowserDrop", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст страницы")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DocumentText", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Всплывающее меню браузера")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "isWebBrowserContextMunuEnabled", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать ошибки сценариев")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ScriptErrorsSuppressed", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Полосы прокрутки активны")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ScrollBarsEnabled", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Url", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка надписи")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkName", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Горячие клавиши работают")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WebBrowserShortcutsEnabled", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Кодировка")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DocumentEncoding", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Куки")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cookie", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Открытие ссылок нового окна")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Открыть в новом окне")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "NavigateNewPage", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Открыть в фрейме")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj21 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array24 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj21, (Type)null, "NavigateInFrame", array24, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Обновить страницу")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				int num24 = peremens.Refreshs.IndexOfKey(Strings.LCase(args[0]));
				if (num24 == -1)
				{
					errString.err = Errors.notCollection(prop, args[0], peremens.HWRefreshs);
					return errString;
				}
				object obj22 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array25 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj22, (Type)null, "RefreshPage", array25, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Оконные кнопки и меню")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ControlBox", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль окна")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num25 = peremens.FormBorderStyles.IndexOfKey(Strings.LCase(value));
				if (num25 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWFormBorderStyles);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FormBorderStyle", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Главное меню")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MainMenuStrip", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прозрачность")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				if (peremens.Int(value) > 100)
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Opacity", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Показывать иконку")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowIcon", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать в панели задач")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowInTaskbar", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стартовая позиция")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num26 = peremens.StartPositions.IndexOfKey(Strings.LCase(value));
				if (num26 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWStartPositions);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StartPosition", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поверх всех окон")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TopMost", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Статус окна")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num27 = peremens.WindowStates.IndexOfKey(Strings.LCase(value));
				if (num27 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWWindowStates);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowState", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка минимальная ширина")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoScrollMinSizeWidth", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутка минимальная вышина")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoScrollMinSizeHeight", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокручено по X")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoScrollPositionX", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокручено по Y")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoScrollPositionY", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Иконка")), false) == 0)
			{
				value = peremens.GetMaxPath(value);
				if (!peremens.IsHttpCompil)
				{
					if (!File.Exists(value) & (Operators.CompareString(value, peremens.trans("Никакой"), false) != 0))
					{
						errString.err = Errors.notFile(value);
						return errString;
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
					{
						value = peremens.copyImage(value);
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Icon", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прозрачный цвет")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj23 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj23 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TransparentcyKey", new object[1] { RuntimeHelpers.GetObjectValue(obj23) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Положение закладок")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num28 = peremens.Alignments.IndexOfKey(Strings.LCase(value));
				if (num28 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWAlignments);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TabAlignment", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позиция выделенной закладки")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedTabPosition", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле по горизонтали")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingX", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поле по вертикали")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PaddingX", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Значение")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Подсказка")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToolTip", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Добавить в автозагрузку")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoRun", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Разрешить запуск копий")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowRunCopies", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Разрешить вводить")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num29 = peremens.InputTypes.IndexOfKey(Strings.LCase(value));
				if (num29 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWInputTypes);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Страница начала печати")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FromPage", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Страница конца печати")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToPage", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Число копий")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Copies", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина столбцов")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WidthOfColumns", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вышина строк")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HeightOfRows", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить добавлять строки")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToAddRows", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить удалять строки")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToDeleteRows", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить переставлять столбцы")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToOrderColumns", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить растягивать столбцы")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToResizeColumns", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить растягивать строки")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowUserToResizeRows", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество строк таблицы")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowsCount", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество столбцов")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnsCount", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль рамки ячейки")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num30 = peremens.CellBorderStyles.IndexOfKey(Strings.LCase(value));
				if (num30 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWCellBorderStyles);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CellBorderStyle", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать заголовки столбцов")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnHeadersVisible", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать специальный столбец")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowHeadersVisible", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вышина заголовков столбцов")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnHeadersHeight", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Столбцы")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Строки")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет фона ячеек")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj24 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj24 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultCellStyleBackColor", new object[1] { RuntimeHelpers.GetObjectValue(obj24) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет фона выделенных ячеек")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj25 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj25 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultCellStyleSelectionBackColor", new object[1] { RuntimeHelpers.GetObjectValue(obj25) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет шрифта ячеек")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj26 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj26 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultCellStyleForeColor", new object[1] { RuntimeHelpers.GetObjectValue(obj26) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет шрифта выделенных ячеек")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj27 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj27 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultCellStyleSelectionForeColor", new object[1] { RuntimeHelpers.GetObjectValue(obj27) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Режим редактирования")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num31 = peremens.EditModes.IndexOfKey(Strings.LCase(value));
				if (num31 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWEditModes);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "EditMode", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет сетки")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj28 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj28 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GridColor", new object[1] { RuntimeHelpers.GetObjectValue(obj28) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбор нескольких ячеек")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MultiSelect", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбор нескольких записей")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MultiSelectItems", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Только для чтения таблица")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReadOnlyTable", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Режим выделения")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num32 = peremens.SelectionModes.IndexOfKey(Strings.LCase(value));
				if (num32 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWSelectionModes);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionMode", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номера выделенных строк")), false) == 0)
			{
				string[] array26 = value.Split(new char[1] { ',' });
				int num33 = array26.Length - 1;
				for (int j = 0; j <= num33; j++)
				{
					if (Operators.CompareString(array26[j], "", false) != 0)
					{
						if (!Iz.isInteger(ref array26[j]))
						{
							errString.err = Errors.notInt(array26[j], prop);
							return errString;
						}
						if (peremens.Int(array26[j]) < 0)
						{
							errString.err = Errors.notInt(array26[j], prop);
							return errString;
						}
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedRows", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номера выделенных столбцов")), false) == 0)
			{
				string[] array27 = value.Split(new char[1] { ',' });
				int num34 = array27.Length - 1;
				for (int k = 0; k <= num34; k++)
				{
					if (Operators.CompareString(array27[k], "", false) != 0)
					{
						if (!Iz.isInteger(ref array27[k]))
						{
							errString.err = Errors.notInt(array27[k], prop);
							return errString;
						}
						if (peremens.Int(array27[k]) < 0)
						{
							errString.err = Errors.notInt(array27[k], prop);
							return errString;
						}
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedColumns", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Значение ячейки")), false) == 0)
			{
				if (!peremens.isRUN())
				{
					errString.str = "MsgBox ne nado";
				}
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ItemValue", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ячейка выделена")), false) == 0)
			{
				if (!peremens.isRUN())
				{
					errString.str = "MsgBox ne nado";
				}
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ItemSelected", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Строка только для чтения")), false) == 0)
			{
				if (!peremens.isRUN())
				{
					errString.str = "MsgBox ne nado";
				}
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowsReadOnly", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Столбец только для чтения")), false) == 0)
			{
				if (!peremens.isRUN())
				{
					errString.str = "MsgBox ne nado";
				}
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnReadOnly", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ячейка только для чтения")), false) == 0)
			{
				if (!peremens.isRUN())
				{
					errString.str = "MsgBox ne nado";
				}
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ItemReadOnly", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина столбца")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!peremens.isRUN())
				{
					errString.str = "MsgBox ne nado";
				}
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnsWidth", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вышина строки")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!peremens.isRUN())
				{
					errString.str = "MsgBox ne nado";
				}
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RowsHeight", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Добавить копию строк")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				args[0] = Strings.Trim(args[0].Split(new char[1] { ',' })[0]);
				if (!Iz.isInteger(ref args[0]))
				{
					errString.err = Errors.notInt(args[0], prop);
					return errString;
				}
				if (!Iz.isInteger(ref args[1]))
				{
					errString.err = Errors.notInt(args[1], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectGreaterEqual((object)args[0], NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					errString.err = Errors.notRowCount(args[0], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectGreater((object)((double)peremens.Int(args[0]) + Conversions.ToDouble(args[1])), NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					errString.err = Errors.notRowCount(Conversions.ToString((double)peremens.Int(args[0]) + Conversions.ToDouble(args[1])), prop);
					return errString;
				}
				object obj29 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array28 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj29, (Type)null, "RowsAddCopies", array28, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вставить строку")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				args[0] = Strings.Trim(args[0].Split(new char[1] { ',' })[0]);
				if (!Iz.isInteger(ref args[0]))
				{
					errString.err = Errors.notInt(args[0], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectGreater((object)args[0], NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					errString.err = Errors.notRowCount(args[0], prop);
					return errString;
				}
				object obj30 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array29 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj30, (Type)null, "RowsInsert", array29, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вставить копию строк")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 3)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				args[0] = Strings.Trim(args[0].Split(new char[1] { ',' })[0]);
				if (!Iz.isInteger(ref args[0]))
				{
					errString.err = Errors.notInt(args[0], prop);
					return errString;
				}
				args[1] = Strings.Trim(args[1].Split(new char[1] { ',' })[0]);
				if (!Iz.isInteger(ref args[1]))
				{
					errString.err = Errors.notInt(args[1], prop);
					return errString;
				}
				if (!Iz.isInteger(ref args[2]))
				{
					errString.err = Errors.notInt(args[2], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectGreater((object)args[0], NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					errString.err = Errors.notRowCount(args[0], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectGreaterEqual((object)args[1], NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					errString.err = Errors.notRowCount(args[1], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectGreater((object)((double)peremens.Int(args[1]) + Conversions.ToDouble(args[2])), NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					errString.err = Errors.notRowCount(Conversions.ToString((double)peremens.Int(args[1]) + Conversions.ToDouble(args[2])), prop);
					return errString;
				}
				object obj31 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array30 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj31, (Type)null, "RowsInsertCopies", array30, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Удалить строку")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj32 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array31 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj32, (Type)null, "RowsRemove", array31, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сохранить таблицу")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				object obj33 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array32 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj33, (Type)null, "SaveTable", array32, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Открыть таблицу")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				object obj34 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array33 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj34, (Type)null, "OpenTable", array33, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сортировать")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (!Iz.isInteger(ref args[0]))
				{
					errString.err = Errors.notInt(args[0], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectGreaterEqual((object)args[0], NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					errString.err = Errors.notRowCount(args[0], prop);
					return errString;
				}
				object obj35 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array34 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj35, (Type)null, "SortTable", array34, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Открыть Access")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[1]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				object obj36 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array35 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj36, (Type)null, "OpenAccess", array35, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Открыть Excel")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[1]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				object obj37 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array36 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj37, (Type)null, "OpenExcel", array36, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сохранить Access")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SaveAccess", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вставить столбец")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				args[0] = Strings.Trim(args[0].Split(new char[1] { ',' })[0]);
				if (!Iz.isInteger(ref args[0]))
				{
					errString.err = Errors.notInt(args[0], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectGreater((object)args[0], NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					errString.err = Errors.notColumnCount(args[0], prop);
					return errString;
				}
				object obj38 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array37 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj38, (Type)null, "ColumnsInsert", array37, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Удалить столбец")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj39 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array38 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj39, (Type)null, "ColumnsRemove", array38, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Добавить строку")), false) == 0)
			{
				object obj40 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array39 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj40, (Type)null, "RowsAdd", array39, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Добавить столбец")), false) == 0)
			{
				object obj41 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array40 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj41, (Type)null, "ColumnsAdd", array40, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("SQL запрос выборки")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 3)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				args[0] = peremens.NikakoiEsli(args[0]);
				int num35 = peremens.BdTypes.IndexOfKey(Strings.LCase(args[0]));
				if (num35 == -1)
				{
					errString.err = Errors.notCollection(prop, args[0], peremens.HWBdTypes);
					return errString;
				}
				object obj42 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array41 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj42, (Type)null, "SQLquerySelect", array41, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("SQL запрос изменения")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 3)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				args[0] = peremens.NikakoiEsli(args[0]);
				int num36 = peremens.BdTypes.IndexOfKey(Strings.LCase(args[0]));
				if (num36 == -1)
				{
					errString.err = Errors.notCollection(prop, args[0], peremens.HWBdTypes);
					return errString;
				}
				object obj43 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array42 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj43, (Type)null, "SQLqueryInto", array42, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Поиск с выделением")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 5)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj44 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array43 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj44, (Type)null, "SearchWithSelect", array43, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Значение выделеных ячеек")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedItemsValue", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Высота раскрывающегося списка")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) <= 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DropDownHeight", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина раскрывающегося списка")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) <= 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DropDownWidth", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Список упрощенный")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DropDownStyle", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Записи списка")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Количество раскрывающихся записей")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) <= 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaxDropDownItems", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сортирован список")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Sorted", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Список раскрыт")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DroppedDown", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер выделенной записи")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) < 0)
				{
					return errString;
				}
				if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)value, false))
				{
					errString.err = Errors.noItems(prop, value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенная запись")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedItem", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запись по номеру")), false) == 0)
			{
				if (!peremens.isRUN())
				{
					errString.str = "MsgBox ne nado";
				}
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (!Iz.isInteger(ref args[0]))
				{
					errString.err = Errors.notInt(args[0], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)args[0], false))
				{
					errString.err = Errors.noItems(prop, args[0]);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ItemsItem", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Найти номер записи")), false) == 0)
			{
				if (!peremens.isRUN())
				{
					errString.str = "MsgBox ne nado";
				}
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ItemsIndexOf", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Добавить запись")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj45 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array44 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj45, (Type)null, "ItemsAdd", array44, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вставить запись")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (!Iz.isInteger(ref args[0]))
				{
					errString.err = Errors.notInt(args[0], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)args[0], false))
				{
					errString.err = Errors.noItems(prop, args[0]);
					return errString;
				}
				object obj46 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array45 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj46, (Type)null, "ItemsInsert", array45, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Удалить запись")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj47 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array46 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj47, (Type)null, "ItemsRemove", array46, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Удалить запись по номеру")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (!Iz.isInteger(ref args[0]))
				{
					errString.err = Errors.notInt(args[0], prop);
					return errString;
				}
				if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)args[0], false))
				{
					errString.err = Errors.noItems(prop, args[0]);
					return errString;
				}
				object obj48 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array47 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj48, (Type)null, "ItemsRemoveAt", array47, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ширина колонок списка")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColumnWidth", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Горизонтальная прокрутка")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HorizontalScrollBar", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Многоколонность")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MultiColumn", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить выбирать записи")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionModeList", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номера отмеченых записей")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckedIndices", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отмеченные записи")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckedItems", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номера выделенных записей")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndices", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенные записи")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedItems", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет активной ссылки")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj49 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj49 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveLinkColor", new object[1] { RuntimeHelpers.GetObjectValue(obj49) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет нерабочей ссылки")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj50 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj50 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DisabledLinkColor", new object[1] { RuntimeHelpers.GetObjectValue(obj50) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет ссылки")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj51 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj51 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkColor", new object[1] { RuntimeHelpers.GetObjectValue(obj51) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Цвет посещенной ссылки")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj52 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj52 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "VisitedLinkColor", new object[1] { RuntimeHelpers.GetObjectValue(obj52) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Начало ссылки")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkStart", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Длинна ссылки")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) <= 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkLength", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль подчеркивания")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num37 = peremens.LinkBehaviors.IndexOfKey(Strings.LCase(value));
				if (num37 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWLinkBehaviors);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkBehavior", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка посещена")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkVisited", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка рабочая")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LinkEnabled", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Переходить в интернет по ссылке")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "InternetLink", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Подсвечивать ссылки")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DetectUrls", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить перенос выделенного")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "EnableAutoDragDrop", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Масштаб")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) <= 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ZoomFactor", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("RTF код документа")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rtf", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный RTF")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedRtf", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный задний фон")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj53 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj53 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionBackColor", new object[1] { RuntimeHelpers.GetObjectValue(obj53) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный цвет текста")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj54 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj54 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionColor", new object[1] { RuntimeHelpers.GetObjectValue(obj54) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенное положение текста")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				int num38 = peremens.TextPositions.IndexOfKey(Strings.LCase(value));
				if (num38 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWTextPositions);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionAlignment", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный размер красной строки")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionHangingIndent", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный отступ слева")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionIndent", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный отступ справа")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionRightIndent", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный имеет маркер")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionBullet", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенное вертикальное смещение")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionCharOffset", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный Шрифт")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				if (Operators.CompareString(value, peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				int num39 = peremens.Fonts.IndexOfKey(Strings.LCase(value));
				if (num39 == -1)
				{
					errString.err = Errors.notCollection(prop, value, peremens.HWFonts);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontFamily", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный Шрифт жирный")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontBold", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный Шрифт курсив")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontItalic", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный Шрифт подчеркнутый")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontUnderline", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный Шрифт зачеркнутый")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontStrikeOut", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный Шрифт размер")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				if (peremens.Int(value) <= 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionFontSize", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделенный текст заблокирован")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionProtected", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сохранить документ")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				object obj55 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array48 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj55, (Type)null, "SaveFile", array48, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Открыть документ")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				object obj56 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array49 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj56, (Type)null, "OpenFile", array49, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбранный цвет")), false) == 0)
			{
				value = peremens.NikakoiEsli(value);
				object obj57 = peremens.ToMyColor(peremens.FromMyColor(value, notError: true));
				if (obj57 == null)
				{
					errString.err = Errors.notCollectionCols(prop, value, peremens.HWCols);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DialogColor", new object[1] { RuntimeHelpers.GetObjectValue(obj57) }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить выбирать цвет")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowColor", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позволить выбирать подчеркивания")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowEffects", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Надпись в окне")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Description", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбранная папка")), false) == 0)
			{
				if (value.Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedPath", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Добавлять расширение файлу")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultExt", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Проверять наличие файла")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckFileExists", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Проверять наличие папки")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CheckPathExists", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Имя файла")), false) == 0)
			{
				if (value.Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileName", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Фильтр файлов")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Filter", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Номер фильтра")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FilterIndex", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Начальная папка")), false) == 0)
			{
				if (value.Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "InitialDirectory", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Заголовок")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Title", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбор нескольких файлов")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MultiSelectFiles", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст на печать")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintText", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Объект на печать")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintObject", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Документ на печать")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintDocument", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Таблица на печать")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintTable", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Таблица в центре")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TableOnCenter", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Рисунок на печать")), false) == 0)
			{
				value = peremens.GetMaxPath(value);
				if (!peremens.IsHttpCompil)
				{
					if (!File.Exists(value) & (Operators.CompareString(value, peremens.trans("Никакой"), false) != 0))
					{
						errString.err = Errors.notFile(value);
						return errString;
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
					{
						value = peremens.copyImage(value);
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrintPicture", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Интервал отсчета")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) <= 0)
				{
					errString.err = Errors.notLessEqZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Interval", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прошло интервалов")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IntervalCount", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Хозяин объект")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OwnerObject", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отображать в трее")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowInTray", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Обновить")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Получить фокус")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Перенести наперед")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Перенести назад")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendToBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Очистить")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вырезать")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cut", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Копировать")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Copy", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вставить")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Paste", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выделить все")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectAll", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отменить")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Undo", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Повторить")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Redo", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Назад")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GoBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Вперед")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GoForward", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Домой")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GoHome", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Страница поиска")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GoSearch", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Печать")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Printing", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Окно параметров страницы")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowPageSetupDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Окно печати")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowPrintDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Окно предварительного просмотра")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowPrintPreviewDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Окно свойств")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowPropertiesDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Окно сохранить")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowSaveAsDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Остановить")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скрыть")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Закрыть")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Показать")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Очистить таблицу")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClearTable", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Перейти в интернет по ссылке")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GoInternetLink", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокрутить до курсора")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ScrollToCaret", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запустить окно")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запустить предварительный просмотр")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowPrevDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запустить настройки страницы")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowPageDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запустить окно печати")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowPrinDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Напечатать")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Print", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Старт")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стоп")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Свернуть в трей")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MinimizeToTray", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Развернуть из трея")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MaximizeFromTray", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Скрытый")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Hider", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Только для чтения")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileReadOnly", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Архивный")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "archive", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Папка")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Papka", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Зашифрованный")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Encrypted", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Не индексируется")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "NotIndexer", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Системный")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Sys", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Временный")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Temp", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Время создания")), false) == 0)
			{
				DateTime dateTime = peremens.FromMyDate(value);
				if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
				{
					errString.err = Errors.notDate(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateTime", new object[2] { args, dateTime }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Время доступа")), false) == 0)
			{
				DateTime dateTime2 = peremens.FromMyDate(value);
				if (DateTime.Compare(dateTime2, DateTime.MinValue) == 0)
				{
					errString.err = Errors.notDate(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AccessTime", new object[2] { args, dateTime2 }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Время изменения")), false) == 0)
			{
				DateTime dateTime3 = peremens.FromMyDate(value);
				if (DateTime.Compare(dateTime3, DateTime.MinValue) == 0)
				{
					errString.err = Errors.notDate(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "EditTime", new object[2] { args, dateTime3 }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Сохранить в файле")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 3)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				args[2] = peremens.NikakoiEsli(args[2]);
				object obj58 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array50 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj58, (Type)null, "SaveInFile", array50, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Добавить текст")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 3)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				args[2] = peremens.NikakoiEsli(args[2]);
				object obj59 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array51 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj59, (Type)null, "AppendText", array51, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Сохранить рисунок")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if ((Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0) | (Operators.CompareString(peremens.NikakoiEsli(args[1]), peremens.trans("Никакой"), false) == 0))
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				errString = peremens.FileExistInArgs(args, 1, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				object obj60 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array52 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj60, (Type)null, "SavePicture", array52, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Копировать")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if ((Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0) | (Operators.CompareString(peremens.NikakoiEsli(args[1]), peremens.trans("Никакой"), false) == 0))
				{
					return errString;
				}
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				if (args[1].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[1]);
					return errString;
				}
				object obj61 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array53 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj61, (Type)null, "Copy", array53, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Переименовать")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if ((Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0) | (Operators.CompareString(peremens.NikakoiEsli(args[1]), peremens.trans("Никакой"), false) == 0))
				{
					return errString;
				}
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				if (args[1].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[1]);
					return errString;
				}
				object obj62 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array54 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj62, (Type)null, "Rename", array54, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Переместить")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if ((Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0) | (Operators.CompareString(peremens.NikakoiEsli(args[1]), peremens.trans("Никакой"), false) == 0))
				{
					return errString;
				}
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				if (args[1].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[1]);
					return errString;
				}
				object obj63 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array55 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj63, (Type)null, "Move", array55, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Зашифровать")), false) == 0)
			{
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				object obj64 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array56 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj64, (Type)null, "Encrypt", array56, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Расшифровать")), false) == 0)
			{
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				object obj65 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array57 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj65, (Type)null, "Decrypt", array57, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Удалить")), false) == 0)
			{
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				object obj66 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array58 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj66, (Type)null, "Delete", array58, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Создать папку")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NikakoiEsli(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					return errString;
				}
				if (args[0].Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(args[0]);
					return errString;
				}
				object obj67 = NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array59 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj67, (Type)null, "CreateDirectory", array59, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Рисунок рабочего стола")), false) == 0)
			{
				value = peremens.GetMaxPath(value);
				if (!peremens.IsHttpCompil && (!File.Exists(value) & (Operators.CompareString(value, peremens.trans("Никакой"), false) != 0)))
				{
					errString.err = Errors.notFile(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WallPaper", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Стиль рабочего стола")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DesktopStyle", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Разрешение экрана")), false) == 0)
			{
				if (value.IndexOf("x") < 0)
				{
					errString.err = Errors.notCollection(peremens.trans("Разрешение экрана"), value, peremens.HWDeskResolution);
					return errString;
				}
				if (!Iz.isInteger(ref value.Split(new char[1] { 'x' })[0]) | !Iz.isInteger(ref value.Split(new char[1] { 'x' })[1]) | (Operators.CompareString(value.Split(new char[1] { 'x' })[0], "", false) == 0) | (Operators.CompareString(value.Split(new char[1] { 'x' })[1], "", false) == 0))
				{
					errString.err = Errors.notCollection(peremens.trans("Разрешение экрана"), value, peremens.HWDeskResolution);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DesktopResolution", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Качество цветопередачи")), false) == 0)
			{
				if ((Operators.CompareString(value, "", false) == 0) | !Iz.isInteger(ref value))
				{
					string[] coll = new string[3] { "8", "16", "32" };
					errString.err = Errors.notCollection(peremens.trans("Качество цветопередачи"), value, coll);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DesktopBits", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Частота экрана")), false) == 0)
			{
				if ((Operators.CompareString(value, "", false) == 0) | !Iz.isInteger(ref value))
				{
					errString.err = Errors.notInt(value, peremens.trans("Частота экрана"));
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DesktopFrequency", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Заставка")), false) == 0)
			{
				if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
				{
					value = peremens.trans("Никакой");
				}
				if (value.Split(Path.GetInvalidPathChars()).Length > 1)
				{
					errString.err = Errors.InvalidPathChars(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ScreenSaver", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Сделать скриншот")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (Operators.CompareString(peremens.NetTakNet(args[0]), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(args[0]);
					return errString;
				}
				args[0] = peremens.NetTakNet(args[0]);
				object obj68 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array60 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj68, (Type)null, "ScreenshotToClipboard", array60, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Сделать скриншот объекта")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj69 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array61 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj69, (Type)null, "ScreenshotOfObjectToClipboard", array61, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Файл проигрывания")), false) == 0)
			{
				value = peremens.GetMaxPath(value);
				if (!peremens.IsHttpCompil)
				{
					if (!File.Exists(value) & (Operators.CompareString(value, peremens.trans("Никакой"), false) != 0))
					{
						errString.err = Errors.notFile(value);
						return errString;
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(MyObj, (Type)null, "isRun", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
					{
						value = peremens.copyImage(value);
					}
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileNamePlayed", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Проигрывается")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Played", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Громкость")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				if (peremens.Int(value) > 2000)
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Volume", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Баланс")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				if (peremens.Int(value) > 2000)
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Balance", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Звук отключен")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Mute", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скорость")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				if (peremens.Int(value) > 2000)
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Speed", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Позиция проигрывания")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				if (peremens.Int(value) < 0)
				{
					errString.err = Errors.notLessZero(value, prop);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PlayPosition", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Проигралось времени")), false) == 0)
			{
				TimeSpan timeSpan = peremens.FromMyTimeSpan(value);
				if (timeSpan == TimeSpan.MaxValue)
				{
					errString.err = Errors.notTime(value);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PlayTime", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Плей")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PlayMovie", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Открыть медиафайл")), false) == 0)
			{
				errString = peremens.FileExistInArgs(args, 0, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				object obj70 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array62 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj70, (Type)null, "OpenMovie", array62, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Закрыть файл")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CloseMovie", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стоп медиа")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StopMovie", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Пауза")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PauseMovie", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Мышь X")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MouseX", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Мышь Y")), false) == 0)
			{
				value = peremens.NullTakNull(value);
				if (!Iz.isDouble(ref value))
				{
					errString.err = Errors.notInt(value, prop);
					return errString;
				}
				value = Conversions.ToString(peremens.Int(value));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MouseY", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Клавиша клавиатуры")), false) == 0)
			{
				errString = peremens.UbratKovich(value);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyBoardKey", new object[1] { errString.str }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Нажат альт")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyboardAlt", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Нажат шифт")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyboardShift", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Нажат контрол")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyboardControl", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Нажата мыши левая")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MouseLeft", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Нажата мыши правая")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MouseRight", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Вращается колесико")), false) == 0)
			{
				if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
				{
					errString.err = Errors.notDaOrNet(value);
					return errString;
				}
				value = peremens.NetTakNet(value);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MouseWheel", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Рисунок буфера обмена")), false) == 0)
			{
				errString = peremens.FileExistInArgs(value, errString);
				if (Operators.CompareString(errString.err, "", false) != 0)
				{
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClipboardPicture", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Текст буфера обмена")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClipboardText", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj71 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array63 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj71, (Type)null, "Run", array63, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Очистить буфер обмена")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClipboardClear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Вращать колесико")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (!Iz.isInteger(ref args[0]))
				{
					errString.err = Errors.notInt(args[0], prop);
					return errString;
				}
				object obj72 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array64 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj72, (Type)null, "WheelRun", array64, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Выключить компьютер")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShutDown", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Перезагрузить компьютер")), false) == 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Restart", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Набрать текст")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj73 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array65 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj73, (Type)null, "TypeText", array65, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Процесс убить")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj74 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array66 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj74, (Type)null, "KillProcess", array66, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Окно в фокусе")), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowInFocus", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Значение реестра")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				string allPath = args[0];
				string name = "";
				if (peremens.GetRegistryKey(allPath, ref name) == null)
				{
					errString.err = Errors.notRegistry(args[0]);
					return errString;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Key", new object[2] { args, value }, (string[])null, (Type[])null, false, true);
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Удалить значение")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				string allPath2 = args[0];
				string name = "";
				if (peremens.GetRegistryKey(allPath2, ref name) == null)
				{
					errString.err = Errors.notRegistry(args[0]);
					return errString;
				}
				object obj75 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array67 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj75, (Type)null, "DeleteKey", array67, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Удалить папку")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				string allPath3 = args[0];
				string name = "";
				if (peremens.GetRegistryKey(allPath3, ref name) == null)
				{
					errString.err = Errors.notRegistry(args[0]);
					return errString;
				}
				object obj76 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array68 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj76, (Type)null, "DeleteSubKey", array68, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Создать подпапку")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				string allPath4 = args[0];
				string name = "";
				if (peremens.GetRegistryKey(allPath4, ref name) == null)
				{
					errString.err = Errors.notRegistry(args[0]);
					return errString;
				}
				object obj77 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array69 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj77, (Type)null, "CreateSubKey", array69, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Создать ключ")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 2)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				string allPath5 = args[0];
				string name = "";
				if (peremens.GetRegistryKey(allPath5, ref name) == null)
				{
					errString.err = Errors.notRegistry(args[0]);
					return errString;
				}
				object obj78 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array70 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj78, (Type)null, "CreateKey", array70, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Запустить сообщение")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 4)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				args[1] = peremens.NikakoiEsli(args[1]);
				int num40 = peremens.MsgStyleButtons.IndexOfKey(Strings.LCase(args[1]));
				if (num40 == -1)
				{
					errString.err = Errors.notCollection(prop, args[1], peremens.HWMsgStyleButtons);
					return errString;
				}
				args[2] = peremens.NikakoiEsli(args[2]);
				num40 = peremens.MsgStyleTypes.IndexOfKey(Strings.LCase(args[2]));
				if (num40 == -1)
				{
					errString.err = Errors.notCollection(prop, args[2], peremens.HWMsgStyleTypes);
					return errString;
				}
				object obj79 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array71 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj79, (Type)null, "ShowMessage", array71, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Изменить время компьютера")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj80 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array72 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj80, (Type)null, "SetSystemData", array72, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить код VBScript")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj81 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array73 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj81, (Type)null, "runVBScript", array73, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить код Алгоритма2")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj82 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array74 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj82, (Type)null, "runAlgoritm2", array74, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить код VBNet")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj83 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array75 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj83, (Type)null, "runVBNet", array75, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить код CSharp")), false) == 0)
			{
				if (args == null)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				if (args.Length < 1)
				{
					errString.err = Errors.noArguments(prop);
					return errString;
				}
				object obj84 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array6 = new object[1] { args };
				object[] array76 = array6;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj84, (Type)null, "runCSharp", array76, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
				}
			}
			else
			{
				peremens.ErrString errString2 = default(peremens.ErrString);
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Завершить программу")), false) == 0)
				{
					object obj85 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BreakApplication", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj85 != null) ? ((peremens.ErrString)obj85) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Завершить событие")), false) == 0)
				{
					object obj86 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BreakEvent", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj86 != null) ? ((peremens.ErrString)obj86) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Завершить цикл")), false) == 0)
				{
					object obj87 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BreakLoop", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj87 != null) ? ((peremens.ErrString)obj87) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Завершить условие")), false) == 0)
				{
					object obj88 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StopIf", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj88 != null) ? ((peremens.ErrString)obj88) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.MyZnak + peremens.trans("Пропускать ошибки")), false) == 0)
				{
					object obj89 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IgnoreErrors", new object[0], (string[])null, (Type[])null, (bool[])null);
					return (obj89 != null) ? ((peremens.ErrString)obj89) : errString2;
				}
				if (Operators.CompareString(text, Strings.UCase(peremens.trans("Формат даты")), false) == 0)
				{
					value = peremens.NikakoiEsli(value);
					int num41 = peremens.DateFormats.IndexOfKey(Strings.LCase(value));
					if (num41 == -1)
					{
						errString.err = Errors.notCollection(prop, value, peremens.HWDateFormats);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CalendarDateFormat", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Формат даты по выбору")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CustomDateFormat", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Кнопки вверх вниз")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowUpDown", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выбранная дата")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedDate", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сдвиг большой")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isDouble(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LargeChange", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сдвиг малый")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isDouble(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SmallChange", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Максимум")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isDouble(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Maximum", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Минимум")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isDouble(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Minimum", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль бегунка")), false) == 0)
				{
					value = peremens.NikakoiEsli(value);
					int num42 = peremens.TickStyles.IndexOfKey(Strings.LCase(value));
					if (num42 == -1)
					{
						errString.err = Errors.notCollection(prop, value, peremens.HWTickStyles);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TickStyle", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Частота отметок")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isDouble(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TickFrequency", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст кнопки")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextButton", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст поля")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextField", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сообщение успешной активации")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MessageValid", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Сообщение неудачной активации")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MessageInValid", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("ID пользователя")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IdUser", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("ID программы")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IdProgram", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("ID в реестре")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IdRegistryProgram", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ключ шифрования")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeyEncryption", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Дней триала всего")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isInteger(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DaysAll", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Активирована")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Activation", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Триальный период запущен")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TrialStarted", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ключ активации выдать")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj90 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array77 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj90, (Type)null, "KeyIssue", array77, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ключ активации проверить")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj91 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array78 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj91, (Type)null, "KeyValidation", array78, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Триальный период запустить")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TrialStart", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Активацию отменить")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActivationCancel", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Файл отправляется")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileIsSent", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скрыть отправку файлов")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HideSendingFiles", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скрыть отправку текста")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HideSendingText", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скрыть список")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HideComboBox", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Обозначение команд")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CommandSymbol", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Принятая команда")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceivedCommand", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Принятый текст")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceivedText", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Принятый файл")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceivedFile", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправленная команда")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SentCommand", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправленый текст")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SentText", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправленый файл")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SentFile", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Имя в сети")), false) == 0)
				{
					try
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "NameInNetwork", new object[1] { value }, (string[])null, (Type[])null, false, true);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						errString.err = ex2.Message;
						peremens.ErrString result = errString;
						ProjectData.ClearProjectError();
						return result;
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("IP для соединения")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RemoteHost", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Порт для соединения")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RemotePort", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Папка для загрузок")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PathForDownloads", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Тип клиент сервера")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClientServerType", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Имена клиентов")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClientsNames", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст поля ввода")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextBoxString", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Текст поля лога")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextBoxLog", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ip клиентов")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClientsIPs", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ip клиента")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj92 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array79 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj92, (Type)null, "GetClientIp", array79, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправить серверу")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj93 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array80 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj93, (Type)null, "SendToServer", array80, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправить файл серверу")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj94 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array81 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj94, (Type)null, "SendFileToServer", array81, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправить клиентам")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj95 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array82 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj95, (Type)null, "SendToClients", array82, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправить клиентам кроме")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj96 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array83 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj96, (Type)null, "SendToClientsBut", array83, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправить клиенту")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj97 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array84 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj97, (Type)null, "SendToClient", array84, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправить файл клиентам")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj98 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array85 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj98, (Type)null, "SendFileToClients", array85, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправить файл клиентам кроме")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj99 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array86 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj99, (Type)null, "SendFileToClientsBut", array86, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отправить файл клиенту")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj100 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array87 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj100, (Type)null, "SendFileToClient", array87, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Добавить в лог")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj101 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array88 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj101, (Type)null, "Log", array88, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выполнить команду")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj102 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array89 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj102, (Type)null, "RunCommand", array89, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Соединиться с сервером")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ConnectToServer", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Создать сервер")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CreateServer", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Начать прослушку")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BeginListen", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отключить сервер")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CloseServer", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отключить прослушку")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CloseListener", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Отключиться")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CloseClient", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Удерживать соединение")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "KeepAlive", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Автоматически перенаправляться")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AllowAutoRedirect", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скачивается файл")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FileDownloading", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скачка пауза")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DownloadPause", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка запроса")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UrlToGo", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка откуда пришли")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UrlReferer", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ссылка перенаправления")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UrlRedirect", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Тип браузера")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UserAgent", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Принимать")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Accept", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокси IP")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ProxyIp", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Прокси порт")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isInteger(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ProxyPort", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Кодировка страницы")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "EncodingPage", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Язык страницы")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "LanguagePage", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Содержимое запроса")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContentQuery", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Тип содержимого")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContentType", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Метод запроса")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HttpMethod", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Таймаут")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isInteger(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TimeOut", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Время задержки")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isInteger(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TimeDelay", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Размер буфера")), false) == 0)
				{
					value = peremens.NullTakNull(value);
					if (!Iz.isInteger(ref value))
					{
						errString.err = Errors.notInt(value, prop);
						return errString;
					}
					value = Conversions.ToString(peremens.Int(value));
					if (peremens.Int(value) < 0)
					{
						errString.err = Errors.notLessZero(value, prop);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BufferSize", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Куки запросов")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CookiesQueries", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Результат запроса")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ResultQuery", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Получить код страницы")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 1)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					object obj103 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array90 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj103, (Type)null, "GetSourceCodePage", array90, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скачать файл")), false) == 0)
				{
					if (args == null)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (args.Length < 2)
					{
						errString.err = Errors.noArguments(prop);
						return errString;
					}
					if (Operators.CompareString(peremens.NetTakNet(args[1]), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(args[1]);
						return errString;
					}
					args[1] = peremens.NetTakNet(args[1]);
					object obj104 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array91 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj104, (Type)null, "DownloadFile", array91, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Выполнить запрос")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ExecuteQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Очистить куки")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClearCookie", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скачка отменить")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DownloadCancel", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скачка возобновить")), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DownloadResume", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Стиль загрузки")), false) == 0)
				{
					value = peremens.NikakoiEsli(value);
					int num43 = peremens.StylesProgress.IndexOfKey(Strings.LCase(value));
					if (num43 == -1)
					{
						errString.err = Errors.notCollection(prop, value, peremens.HWStylesProgress);
						return errString;
					}
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StyleProgress", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Скорость анимации")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MarqueeAnimationSpeed", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Шаг загрузки")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StepProgress", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Справа налево")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RightToLeftLayout", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, peremens.MyZnak + Strings.UCase(peremens.trans("Открыть папку")), false) == 0)
				{
					object obj105 = NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { args };
					object[] array92 = array6;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj105, (Type)null, "OpenDirectory", array92, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string[]));
					}
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Справа налево")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RightToLeftLayout", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запретить минимизировать")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForbidMinimize", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Запретить разворачивать")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForbidMaximize", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ассоциировать с расширениями")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AssociateWithExtensions", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("Ассоциированый принятый файл")), false) == 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AssociationPassedFile", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else if (Operators.CompareString(text, Strings.UCase(peremens.trans("На весь экран")), false) == 0)
				{
					if (Operators.CompareString(peremens.NetTakNet(value), peremens.trans("Никакой"), false) == 0)
					{
						errString.err = Errors.notDaOrNet(value);
						return errString;
					}
					value = peremens.NetTakNet(value);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OnFullScreen", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				else
				{
					if (Iz.IsSobytCalls(RuntimeHelpers.GetObjectValue(MyObj)) & (prop.Split(new char[1] { '_' }).Length == 3))
					{
						NewLateBinding.LateCall(MyObj, (Type)null, "CreateSobytCalls", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						string formName = prop.Split(new char[1] { '_' })[0];
						string name2 = prop.Split(new char[1] { '_' })[1];
						string text2 = prop.Split(new char[1] { '_' })[2];
						object myAllFromName = peremens.RunProj.GetMyAllFromName(name2, "", formName);
						if (myAllFromName == null)
						{
							errString.err = Errors.ObjIsNothing(name2);
							return errString;
						}
						if (peremens.RunProj.FindSobyt(text2, (TreeNode)NewLateBinding.LateGet(NewLateBinding.LateIndexGet(myAllFromName, new object[1] { 0 }, (string[])null), (Type)null, "Getnode", new object[2]
						{
							Missing.Value,
							true
						}, (string[])null, (Type[])null, (bool[])null)) == null)
						{
							errString.err = Errors.notPropertyMethod(prop);
							return errString;
						}
						object obj106 = NewLateBinding.LateIndexGet(myAllFromName, new object[1] { 0 }, (string[])null);
						object[] array16 = new object[4];
						object[] array93 = array16;
						object[] array6 = new object[1];
						object[] array94 = array6;
						int num44 = 0;
						array94[0] = 0;
						array93[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(myAllFromName, array6, (string[])null));
						array16[1] = text2;
						array16[2] = new EventArgs();
						array16[3] = new EventArgs().GetType();
						object[] array11 = array16;
						object[] array95 = array11;
						bool[] array3 = new bool[4] { true, true, false, false };
						NewLateBinding.LateCall(obj106, (Type)null, "RunSobyt", array95, (string[])null, (Type[])null, array3, true);
						if (array3[0])
						{
							NewLateBinding.LateIndexSetComplex(myAllFromName, new object[2]
							{
								num44,
								RuntimeHelpers.GetObjectValue(array11[0])
							}, (string[])null, true, false);
						}
						if (array3[1])
						{
							text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[1]), typeof(string));
						}
						return errString;
					}
					errString.err = "!";
				}
			}
			return errString;
		}
	}

	public static void SetReadOnlys()
	{
		string[] array = (peremens.ReadOnlyProps = new string[158]
		{
			Strings.UCase(peremens.trans("В фокусе")),
			Strings.UCase(peremens.trans("Тип")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Существует файл")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Существует папка")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Получить файлы")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Получить папки")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Определить корневую")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Поиск файлов")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Определить родительскую")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Получить диски")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Определить имя папки")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Определить имя файла")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Определить расширение")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Определить без расширения")),
			Strings.UCase(peremens.trans("Длительность общая")),
			Strings.UCase(peremens.trans("Длительность время")),
			Strings.UCase(peremens.trans("Оригинальная вышина")),
			Strings.UCase(peremens.trans("Оригинальная ширина")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Вращается колесико")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Ключ существует")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Папка существует")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Тип ключа")),
			Strings.UCase(peremens.trans("Номер символа по координатам")),
			Strings.UCase(peremens.trans("Номер первого символа строки")),
			Strings.UCase(peremens.trans("Номер первого символа текущей строки")),
			Strings.UCase(peremens.trans("Номер строки по номеру символа")),
			Strings.UCase(peremens.trans("X по номеру символа")),
			Strings.UCase(peremens.trans("Y по номеру символа")),
			Strings.UCase(peremens.trans("Строка")),
			Strings.UCase(peremens.trans("Количество строк")),
			Strings.UCase(peremens.trans("Браузер offline")),
			Strings.UCase(peremens.trans("Символ")),
			Strings.UCase(peremens.trans("Количество символов")),
			Strings.UCase(peremens.trans("Родительское меню")),
			Strings.UCase(peremens.trans("Назад возможно")),
			Strings.UCase(peremens.trans("Вперед возможно")),
			Strings.UCase(peremens.trans("Родительский пункт")),
			Strings.UCase(peremens.trans("Заголовок страницы")),
			Strings.UCase(peremens.trans("Тип страницы")),
			Strings.UCase(peremens.trans("Браузер занят")),
			Strings.UCase(peremens.trans("Статус готовности")),
			Strings.UCase(peremens.trans("Статусная строка")),
			Strings.UCase(peremens.trans("Кодировка по умолчанию")),
			Strings.UCase(peremens.trans("Высота заголовка")),
			Strings.UCase(peremens.trans("Номер выделенной закладки")),
			Strings.UCase(peremens.trans("Номер первой строки")),
			Strings.UCase(peremens.trans("Номер последней строки")),
			Strings.UCase(peremens.trans("Номер следующей строки")),
			Strings.UCase(peremens.trans("Номер предыдущей строки")),
			Strings.UCase(peremens.trans("Значение по координатам")),
			Strings.UCase(peremens.trans("Номер строки по координатам")),
			Strings.UCase(peremens.trans("Номер столбца по координатам")),
			Strings.UCase(peremens.trans("Высота записей списка")),
			Strings.UCase(peremens.trans("Количество записей")),
			Strings.UCase(peremens.trans("Номера отмеченых записей")),
			Strings.UCase(peremens.trans("Отмеченные записи")),
			Strings.UCase(peremens.trans("Была нажата отмена")),
			Strings.UCase(peremens.trans("Количество выделенных строк")),
			Strings.UCase(peremens.trans("Количество выделенных столбцов")),
			Strings.UCase(peremens.trans("Дней триала осталось")),
			Strings.UCase(peremens.trans("ID пользователя")),
			Strings.UCase(peremens.trans("Примечание")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Символ по номеру")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Сравнить тексты")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Поиск в тексте")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Поиск номера строки")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Поиск с учетом регистра")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Поиск в тексте с конца")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Поиск с регулярными выражениями")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Количество символов")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разбить на части")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Взять кусок текста")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Количество частей текста")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Кавычки убрать")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Кавычками обособить")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Поиск без кавычек")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разбить на части без кавычек")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Текст содержит")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Текст не содержит")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Строка по номеру")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Количество строк")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Вставить символы в текст")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Удалить кусок текста")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Заменить")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Заменить все")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Сделать буквы прописными")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Сделать буквы заглавными")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Убрать пробелы")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Убрать пробелы в начале")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Убрать пробелы в конце")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Количество частей без кавычек")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Была нажата Отмена")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Была нажата Ок")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Была нажата Повторить")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Была нажата Да")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Была нажата Нет")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Была нажата Прервать")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Была нажата Пропустить")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Была нажата Справка")),
			Strings.UCase(peremens.MyZnak + peremens.trans("День месяца")),
			Strings.UCase(peremens.MyZnak + peremens.trans("День года")),
			Strings.UCase(peremens.MyZnak + peremens.trans("День в неделе")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Час")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Минута")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Секунда")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Квартал")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Неделя в году")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Год")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Месяц")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Секунд всего в дате")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Дней в месяце")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Сейчас")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Сегодня")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Прибавить дни")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Прибавить часы")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Прибавить минуты")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Прибавить секунды")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Прибавить кварталы")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Прибавить недели")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Прибавить годы")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Прибавить месяцы")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разница в днях")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разница в часах")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разница в минутах")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разница в секундах")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разница в кварталах")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разница в неделях")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разница в годах")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Разница в месяцах")),
			Strings.UCase(peremens.MyZnak + peremens.trans("День недели")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Название месяца")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Дата в определенном формате")),
			Strings.UCase(peremens.trans("Найти номер записи")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Текст состоит из")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Текст есть число")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Текст есть цифры")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Определить размер файла")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Открыть файл")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Выполнить с результатом")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Зашифровать текст")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Расшифровать текст")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Количество файлов")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Количество папок")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Выполнить с результатом")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Процессы системы")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Окна системы")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Скриншот")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Скриншот объекта")),
			Strings.UCase(peremens.trans("Наличие соединения")),
			Strings.UCase(peremens.trans("Имена клиентов")),
			Strings.UCase(peremens.trans("Ip клиентов")),
			Strings.UCase(peremens.trans("Ip клиента")),
			Strings.UCase(peremens.trans("Длинна содержимого")),
			Strings.UCase(peremens.trans("Код результата")),
			Strings.UCase(peremens.trans("Заголовки запроса")),
			Strings.UCase(peremens.trans("Ассоциированый принятый файл")),
			Strings.UCase(peremens.trans("Поиск в таблице")),
			Strings.UCase(peremens.trans("Поиск в выделеных ячейках"))
		});
		string[] array2 = (peremens.MayChangeProps = new string[15]
		{
			peremens.trans("Номер символа по координатам").ToUpper(),
			peremens.trans("Номер первого символа строки").ToUpper(),
			peremens.trans("Номер первого символа текущей строки").ToUpper(),
			peremens.trans("Номер строки по номеру символа").ToUpper(),
			peremens.trans("X по номеру символа").ToUpper(),
			peremens.trans("Y по номеру символа").ToUpper(),
			peremens.trans("Строка").ToUpper(),
			peremens.trans("Символ").ToUpper(),
			peremens.trans("Запись по номеру").ToUpper(),
			peremens.trans("Найти номер записи").ToUpper(),
			peremens.trans("Ключ активации выдать").ToUpper(),
			peremens.trans("Ключ активации проверить").ToUpper(),
			peremens.trans("Ip клиента").ToUpper(),
			peremens.trans("Поиск в таблице").ToUpper(),
			peremens.trans("Поиск в выделеных ячейках").ToUpper()
		});
		string[] array3 = (peremens.ArgTypes = new string[16]
		{
			Strings.UCase(peremens.trans("Сортировать по возрастанию")),
			Strings.UCase(peremens.trans("Область выборки")),
			Strings.UCase(peremens.trans("Кнопки сообщения")),
			Strings.UCase(peremens.trans("Тип сообщения")),
			Strings.UCase(peremens.trans("Тип базы данных")),
			Strings.UCase(peremens.trans("Место для записи в списке")),
			Strings.UCase(peremens.trans("Кодировка текста")),
			Strings.UCase(peremens.trans("Показать в окне")),
			Strings.UCase(peremens.trans("Номера строк через запятую")),
			Strings.UCase(peremens.trans("Номера столбцов через запятую")),
			Strings.UCase(peremens.trans("Тип файла")),
			Strings.UCase(peremens.trans("Ждать пока скачается")),
			Strings.UCase(peremens.trans("C учетом регистра")),
			Strings.UCase(peremens.trans("Слово целиком")),
			Strings.UCase(peremens.trans("Объект съемки")),
			Strings.UCase(peremens.trans("Только активное окно"))
		});
		string[] array4 = (peremens.SobytsNotReadOnly = new string[4]
		{
			Strings.UCase(peremens.MyZnak + peremens.trans("Отменить перемещение")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Отменить ввод")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Отменить в новом окне")),
			Strings.UCase(peremens.MyZnak + peremens.trans("Отменить событие"))
		});
		string[] array5 = (peremens.NoSaveProps = new string[18]
		{
			Strings.UCase(peremens.trans("Выделенный RTF")),
			Strings.UCase(peremens.trans("Выделенное положение текста")),
			Strings.UCase(peremens.trans("Выделенный задний фон")),
			Strings.UCase(peremens.trans("Выделенный цвет текста")),
			Strings.UCase(peremens.trans("Выделенный размер красной строки")),
			Strings.UCase(peremens.trans("Выделенный отступ слева")),
			Strings.UCase(peremens.trans("Выделенный отступ справа")),
			Strings.UCase(peremens.trans("Выделенный имеет маркер")),
			Strings.UCase(peremens.trans("Выделенное вертикальное смещение")),
			Strings.UCase(peremens.trans("Выделенный шрифт размер")),
			Strings.UCase(peremens.trans("Выделенный шрифт")),
			Strings.UCase(peremens.trans("Выделенный шрифт жирный")),
			Strings.UCase(peremens.trans("Выделенный шрифт курсив")),
			Strings.UCase(peremens.trans("Выделенный шрифт подчеркнутый")),
			Strings.UCase(peremens.trans("Выделенный шрифт зачеркнутый")),
			Strings.UCase(peremens.trans("Выделенный текст заблокирован")),
			Strings.UCase(peremens.trans("Триальный период запущен")),
			Strings.UCase(peremens.trans("Активирована"))
		});
	}

	public static string GetTypeProperty(string prop)
	{
		prop = Strings.UCase(prop);
		if ((Operators.CompareString(prop, Strings.UCase(peremens.trans("Текст")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Имя")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Вспомогательное поле")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Время создания")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Время доступа")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Время изменения")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Длительность время")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Проигралось времени")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Строка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Символ")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный текст")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Символ пароля")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Значение реестра")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Всплывающая подсказка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Текст страницы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Заголовок страницы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Тип страницы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Куки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Статусная строка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ссылка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Значение")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Столбцы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номера выделенных строк")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номера выделенных столбцов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Значение ячейки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Значение по координатам")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Записи списка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенная запись")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Запись по номеру")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ссылка надписи")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номера отмеченых записей")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отмеченные записи")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номера выделенных записей")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенные записи")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("RTF код документа")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный RTF")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Надпись в окне")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выбранная папка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Добавлять расширение файлу")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Имя файла")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Фильтр файлов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный RTF")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Начальная папка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Заголовок")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Текст на печать")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Родительское меню")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Родительский пункт")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Символ по номеру")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Разбить на части")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Взять кусок текста")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Кавычки убрать")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Кавычками обособить")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Разбить на части без кавычек")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Строка по номеру")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Вставить символы в текст")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Удалить кусок текста")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Заменить")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Заменить все")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Сделать буквы прописными")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Сделать буквы заглавными")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Убрать пробелы")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Убрать пробелы в начале")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Убрать пробелы в конце")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Процессы системы")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Окна системы")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Окно в фокусе")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Тип")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Подсказка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выбранная дата")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Формат даты по выбору")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Время")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Текст кнопки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Сообщение успешной активации")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Сообщение неудачной активации")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("ID пользователя")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("ID программы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("ID в реестре")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ключ шифрования")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("KeyEncryption")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Примечание")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Текст поля")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Обозначение команд")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Принятая команда")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Принятый текст")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("IP для соединения")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Имя в сети")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Принятый файл")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Порт для соединения")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Папка для загрузок")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Имена клиентов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Текст поля ввода")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Текст поля лога")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ip клиентов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ip клиента")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отправленная команда")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отправленый файл")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отправленый текст")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ссылка запроса")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ссылка откуда пришли")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ссылка перенаправления")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Тип браузера")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Принимать")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прокси IP")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прокси порт")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Кодировка страницы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Язык страницы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Содержимое запроса")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Куки запросов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Результат запроса")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ассоциированый принятый файл")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Значение выделеных ячеек")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Поиск в таблице")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Поиск в выделеных")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ширина столбцов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Вышина строк")), false) == 0))
		{
			return peremens.trans("Текст");
		}
		if ((Operators.CompareString(prop, Strings.UCase(peremens.trans("Главная форма")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Запретить закрытие")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("АвтоТроеточие")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Работает")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Видимый")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Шрифт жирный")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Шрифт курсив")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Шрифт зачеркнутый")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Шрифт подчеркнутый")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прокрутка1")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прокрутка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прокрутка2")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Фиксированный разделитель")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Панель1 скрыта")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Панель2 скрыта")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("В фокусе")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("ТабСтоп")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Скрывать выделение")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Многострочность")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Только для чтения")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Перенос по словам")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Отменить перемещение")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Отменить в новом окне")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Отменить событие")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Отменить ввод")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Только для чтения")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Скрытый")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Архивный")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Папка")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Зашифрованный")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Не индексируется")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Системный")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Временный")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Существует файл")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Проигрывается")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Звук отключен")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отмечено")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Нажат альт")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Нажат шифт")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Нажат контрол")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Нажата мыши левая")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Нажата мыши правая")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Вращается колесико")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Ключ существует")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Папка существует")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Расположен слева")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Показывать подсказку")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отметка по клику")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Рисунок растянут")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отображать горячие клавиши")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Переходить по сссылкам")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Разрешить перетаскивания")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Назад возможно")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Вперед возможно")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Браузер занят")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Браузер offline")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Всплывающее меню браузера")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отображать ошибки сценариев")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Полосы прокрутки активны")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Горячие клавиши работают")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Оконные кнопки и меню")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Показывать иконку")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отображать в панели задач")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Поверх всех окон")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позволить добавлять строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позволить удалять строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позволить переставлять столбцы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позволить растягивать столбцы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позволить растягивать строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отображать заголовки столбцов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выбор нескольких ячеек")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Только для чтения таблица")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ячейка выделена")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Строка только для чтения")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Столбец только для чтения")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ячейка только для чтения")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Сортировать по возрастанию")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выбор нескольких записей")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Список упрощенный")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Сортирован список")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Список раскрыт")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позволить выбирать записи")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Горизонтальная прокрутка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Многоколонность")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ссылка посещена")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ссылка рабочая")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Переходить в интернет по ссылке")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Подсвечивать ссылки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позволить перенос выделенного")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный имеет маркер")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный шрифт жирный")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный шрифт курсив")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный шрифт подчеркнутый")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный шрифт зачеркнутый")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный текст заблокирован")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Была нажата отмена")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позволить выбирать цвет")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позволить выбирать подчеркивания")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Проверять наличие файла")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Проверять наличие папки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выбор нескольких файлов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Таблица в центре")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отображать специальный столбец")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Кнопки вверх вниз")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Сравнить тексты")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Текст содержит")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Текст не содержит")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Отмена")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Ок")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Повторить")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Да")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Нет")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Прервать")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Пропустить")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Была нажата Справка")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Текст состоит из")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Текст есть число")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Текст есть цифры")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Активирована")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Показать в окне")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Триальный период запущен")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Отображать в трее")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Добавить в автозагрузку")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Разрешить запуск копий")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Файл отправляется")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Скрыть отправку файлов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Скрыть отправку текста")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Скрыть список")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Скрыть отправку текста")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Удерживать соединение")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Автоматически перенаправляться")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Скачивается файл")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Скачка пауза")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ждать пока скачается")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Справа налево")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Запретить минимизировать")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Запретить разворачивать")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("C учетом регистра")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Слово целиком")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Только активное окно")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("На весь экран")), false) == 0))
		{
			return peremens.trans("ДаНет");
		}
		if ((Operators.CompareString(prop, Strings.UCase(peremens.trans("Фоновой рисунок")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Фоновой рисунок1")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Фоновой рисунок2")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Рисунок")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Рисунок рабочего стола")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Рисунок буфера обмена")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Иконка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Рисунок на печать")), false) == 0))
		{
			return peremens.trans("Рисунок");
		}
		if ((Operators.CompareString(prop, Strings.UCase(peremens.trans("Файл проигрывания")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Заставка")), false) == 0))
		{
			return peremens.trans("Файл");
		}
		if ((Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет1")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет2")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет шрифта")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прозрачный цвет рисунка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прозрачный цвет")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет сетки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет фона ячеек")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет фона выделенных ячеек")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет шрифта ячеек")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет шрифта выделенных ячеек")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет активной ссылки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет нерабочей ссылки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет ссылки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Цвет посещенной ссылки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный задний фон")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный цвет текста")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выбранный цвет")), false) == 0))
		{
			return peremens.trans("Цвет");
		}
		if ((Operators.CompareString(prop, Strings.UCase(peremens.trans("X")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Y")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Максимальная ширина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Максимальная вышина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Минимальная ширина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Минимальная вышина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Поле слева")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Поле сверху")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Поле справа")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Поле снизу")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ширина разделителя")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Расстояние разделителя")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Инкремент разделителя")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Панель1 минимум")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Панель2 минимум")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ширина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Вышина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("ТабНомер")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Частота экрана")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Качество цветопередачи")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Громкость")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Баланс")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Скорость")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Длительность общая")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позиция проигрывания")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Оригинальная вышина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Оригинальная ширина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Максимальная длинна")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Начало выделения")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер символа по координатам")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер первого символа строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер первого символа текущей строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер строки по номеру символа")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Длинна выделения")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("X по номеру символа")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Y по номеру символа")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Количество строк")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Количество символов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Оригинальная вышина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Оригинальная ширина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Оригинальная вышина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Оригинальная ширина")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Мышь X")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Мышь Y")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прокрутка минимальная ширина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прокрутка минимальная вышина")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прокручено по X")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прокручено по Y")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Высота заголовка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прозрачность")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер выделенной закладки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Позиция выделенной закладки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Поле по горизонтали")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Поле по вертикали")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Вышина заголовков столбцов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ширина столбца")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер первой строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер последней строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер следующей строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер предыдущей строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер строки по координатам")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер столбца по координатам")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Количество строк таблицы")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Количество столбцов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Высота раскрывающегося списка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ширина раскрывающегося списка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Высота записей списка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Количество раскрывающихся записей")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер выделенной записи")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Найти номер записи")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Количество записей")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Ширина колонок списка")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Начало ссылки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Длинна ссылки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Масштаб")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный размер красной строки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный отступ слева")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный отступ справа")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенное вертикальное смещение")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Номер фильтра")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Шрифт размер")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенный Шрифт размер")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Интервал отсчета")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Прошло интервалов")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск в тексте")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск с учетом регистра")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск в тексте с конца")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск с регулярными выражениями")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Количество символов")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Количество частей текста")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск без кавычек")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Количество строк")), false) == 0) | (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Количество частей без кавычек")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Сдвиг большой")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Сдвиг малый")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Максимум")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Минимум")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Частота отметок")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Количество выделенных строк")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Количество выделенных столбцов")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Дней триала всего")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Дней триала осталось")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Таймаут")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Время задержки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Размер буфера")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Скорость анимации")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Шаг загрузки")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Страница начала печати")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Страница конца печати")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Число копий")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Вышина строки")), false) == 0))
		{
			return peremens.trans("Число");
		}
		if ((Operators.CompareString(prop, Strings.UCase(peremens.trans("Положение текста")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Положение рисунка")), false) == 0))
		{
			return peremens.trans("Положение");
		}
		if ((Operators.CompareString(prop, Strings.UCase(peremens.trans("Всплывающее меню")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Всплывающее меню1")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Всплывающее меню2")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Вложенное всплывающее меню")), false) == 0))
		{
			return peremens.trans("Всплывающее меню");
		}
		if (Operators.CompareString(prop, peremens.MyZnak + Strings.UCase(peremens.trans("Тип ключа")), false) == 0)
		{
			return peremens.trans("Тип ключа");
		}
		if ((Operators.CompareString(prop, Strings.UCase(peremens.trans("Расположение текста")), false) == 0) | (Operators.CompareString(prop, Strings.UCase(peremens.trans("Выделенное положение текста")), false) == 0))
		{
			return peremens.trans("Расположение текста");
		}
		return prop;
	}

	public static void ShowPropInEditProperty(object EditPr)
	{
		peremens2.ShowPropInEditProperty(RuntimeHelpers.GetObjectValue(EditPr));
	}

	public static string[] GetArguments(string meth, object MyObj)
	{
		meth = Strings.UCase(meth);
		if ((Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Сохранить в файле")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Добавить текст")), false) == 0))
		{
			return new string[3]
			{
				peremens.trans("Путь к файлу"),
				peremens.trans("Что сохранять"),
				peremens.trans("Кодировка текста")
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Открыть файл")), false) == 0)
		{
			return new string[3]
			{
				peremens.trans("Путь к файлу"),
				peremens.trans("Кодировка текста"),
				"неважно"
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Сохранить рисунок")), false) == 0)
		{
			return new string[2]
			{
				peremens.trans("Путь к файлу"),
				peremens.trans("Рисунок для сохранения")
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Выполнить")), false) == 0)
		{
			return new string[2]
			{
				peremens.trans("Команда Windows или имя файла"),
				peremens.trans("Аргументы")
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Выполнить с результатом")), false) == 0)
		{
			return new string[4]
			{
				peremens.trans("Команда Windows или имя файла"),
				peremens.trans("Аргументы"),
				peremens.trans("Кодировка текста"),
				"неважно"
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Набрать текст")), false) == 0)
		{
			return new string[1] { peremens.trans("Симулировать набор следующего текста") };
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Вращать колесико")), false) == 0)
		{
			return new string[1] { peremens.trans("Размер вращения") };
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Поиск файлов")), false) == 0)
		{
			return new string[3]
			{
				peremens.trans("Путь к папке"),
				peremens.trans("Что искать"),
				"неважно"
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Сделать скриншот")), false) == 0)
		{
			return new string[1] { peremens.trans("Только активное окно") };
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Скриншот")), false) == 0)
		{
			return new string[2]
			{
				peremens.trans("Только активное окно"),
				"неважно"
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Сделать скриншот объекта")), false) == 0)
		{
			return new string[1] { peremens.trans("Объект съемки") };
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Скриншот объекта")), false) == 0)
		{
			return new string[2]
			{
				peremens.trans("Объект съемки"),
				"неважно"
			};
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Зашифровать")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Расшифровать")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Удалить")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Создать папку")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Открыть медиафайл")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Сохранить таблицу")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Открыть таблицу")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Сохранить документ")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Открыть документ")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить файл клиентам")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить файл серверу")), false) == 0))
		{
			return new string[1] { peremens.trans("Путь к файлу") };
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Копировать")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Переместить")), false) == 0))
		{
			return new string[2]
			{
				peremens.trans("Путь к файлу"),
				peremens.trans("Новый путь к файлу")
			};
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Скрытый")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Только для чтения")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Архивный")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Папка")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Зашифрованный")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Не индексируется")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Системный")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Временный")), false) == 0))
		{
			return new string[2]
			{
				peremens.trans("Путь к файлу или папке"),
				peremens.trans("Значение атрибута")
			};
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Существует файл")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Существует папка")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Получить файлы")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Получить папки")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Определить корневую")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Определить родительскую")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Определить имя папки")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Определить имя файла")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Определить расширение")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Определить без расширения")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Определить размер файла")), false) == 0))
		{
			return new string[2]
			{
				peremens.trans("Путь к файлу или папке"),
				"неважно"
			};
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Время создания")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Время доступа")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Время изменения")), false) == 0))
		{
			return new string[2]
			{
				peremens.trans("Путь к файлу или папке"),
				peremens.trans("Время")
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Сделать скриншот")), false) == 0)
		{
			return new string[1] { peremens.trans("Куда сохранить") };
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Удалить значение")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Удалить папку")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Создать подпапку")), false) == 0))
		{
			return new string[1] { peremens.trans("Путь реестра") };
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Значение реестра")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Ключ существует")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Папка существует")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Тип ключа")), false) == 0))
		{
			return new string[2]
			{
				peremens.trans("Путь реестра"),
				"неважно"
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Создать ключ")), false) == 0)
		{
			return new string[3]
			{
				peremens.trans("Путь реестра"),
				peremens.trans("Значение ключа"),
				peremens.trans("Тип ключа")
			};
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Номер символа по координатам")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Значение по координатам")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Номер строки по координатам")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Номер столбца по координатам")), false) == 0))
		{
			return new string[3]
			{
				peremens.trans("X"),
				peremens.trans("Y"),
				"неважно"
			};
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Номер первого символа строки")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Строка")), false) == 0))
		{
			return new string[2]
			{
				peremens.trans("Порядковый номер строки"),
				"неважно"
			};
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Номер строки по номеру символа")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Символ")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("X по номеру символа")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Y по номеру символа")), false) == 0))
		{
			return new string[2]
			{
				peremens.trans("Порядковый номер символа"),
				"неважно"
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Обновить страницу")), false) == 0)
		{
			return new string[1] { peremens.trans("Обновить страницу") };
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Тип базы данных")), false) == 0)
		{
			return new string[1] { peremens.trans("Тип базы данных") };
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Значение ячейки")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Ячейка выделена")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Ячейка только для чтения")), false) == 0))
		{
			return new string[3]
			{
				peremens.trans("Номера строк через запятую"),
				peremens.trans("Номера столбцов через запятую"),
				"неважно"
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Строка только для чтения")), false) == 0)
		{
			return new string[2]
			{
				peremens.trans("Номера строк через запятую"),
				"неважно"
			};
		}
		if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Столбец только для чтения")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Ширина столбца")), false) == 0))
		{
			return new string[2]
			{
				peremens.trans("Номера столбцов через запятую"),
				"неважно"
			};
		}
		if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Вышина строки")), false) == 0)
		{
			return new string[2]
			{
				peremens.trans("Номера строк через запятую"),
				"неважно"
			};
		}
		checked
		{
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Добавить строку")), false) == 0)
			{
				if (MyObj == null)
				{
					return null;
				}
				string[] array = new string[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(MyObj, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
				int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(MyObj, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int i = 0; i <= num; i++)
				{
					int num2 = i;
					string text = peremens.trans("Содержимое для столбца") + " \"";
					object obj = NewLateBinding.LateGet(NewLateBinding.LateIndexGet(MyObj, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array2 = new object[1] { i };
					object[] array3 = array2;
					bool[] array4 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "columns", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					array[num2] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, NewLateBinding.LateGet(obj2, (Type)null, "HeaderText", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\" ("), (object)i), (object)")"));
				}
				return array;
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Добавить копию строк")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Начальная строка копирования"),
					peremens.trans("Количество строк для копирования")
				};
			}
			if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Номер первой строки")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Номер последней строки")), false) == 0))
			{
				return new string[2]
				{
					peremens.trans("Область выборки"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Номер следующей строки")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Номер предыдущей строки")), false) == 0))
			{
				return new string[3]
				{
					peremens.trans("Номер начальной строки"),
					peremens.trans("Область выборки"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Вставить строку")), false) == 0)
			{
				if (MyObj == null)
				{
					return null;
				}
				string[] array5 = new string[Conversions.ToInteger(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(MyObj, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), (object)1)) + 1];
				array5[0] = peremens.trans("Номер строки куда вставлять");
				int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(MyObj, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = 0; j <= num3; j++)
				{
					int num4 = j + 1;
					string text2 = string.Concat(peremens.trans("Содержимое для столбца") + Conversions.ToString(j), " \"");
					object obj3 = NewLateBinding.LateGet(NewLateBinding.LateIndexGet(MyObj, new object[1] { 0 }, (string[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array6 = new object[1] { j };
					object[] array7 = array6;
					bool[] array4 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "columns", array7, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
					}
					array5[num4] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text2, NewLateBinding.LateGet(obj4, (Type)null, "HeaderText", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\""));
				}
				return array5;
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Вставить копию строк")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Номер строки куда вставлять"),
					peremens.trans("Начальная строка копирования"),
					peremens.trans("Количество строк для копирования")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Удалить строку")), false) == 0)
			{
				return new string[1] { peremens.trans("Номера строк через запятую") };
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Удалить столбец")), false) == 0)
			{
				return new string[1] { peremens.trans("Номера столбцов через запятую") };
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Вставить столбец")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Номер столбца куда вставлять"),
					peremens.trans("Текст заголовка столбца")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Добавить столбец")), false) == 0)
			{
				return new string[1] { peremens.trans("Текст заголовка столбца") };
			}
			if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Открыть Access")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Открыть Excel")), false) == 0))
			{
				return new string[2]
				{
					peremens.trans("Путь к файлу"),
					peremens.trans("Название таблицы")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("SQL запрос выборки")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Тип базы данных"),
					peremens.trans("Путь к файлу"),
					peremens.trans("SQL запрос выборки из базы данных")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("SQL запрос изменения")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Тип базы данных"),
					peremens.trans("Путь к файлу"),
					peremens.trans("SQL запрос изменения базы данных")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Сортировать")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Номер столбца"),
					peremens.trans("Сортировать по возрастанию")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Запись по номеру")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Номер записи в списке"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Найти номер записи")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Запись из списка"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Добавить запись")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Удалить запись")), false) == 0))
			{
				return new string[1] { peremens.trans("Текст записи") };
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Вставить запись")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Место для записи в списке"),
					peremens.trans("Текст записи")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Удалить запись по номеру")), false) == 0)
			{
				return new string[1] { peremens.trans("Номер записи в списке") };
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Поиск в таблице")), false) == 0)
			{
				return new string[6]
				{
					peremens.trans("Что искать в таблице"),
					peremens.trans("C учетом регистра"),
					peremens.trans("Слово целиком"),
					peremens.trans("Строка откуда начинать поиск"),
					peremens.trans("Столбец откуда начинать поиск"),
					""
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Поиск с выделением")), false) == 0)
			{
				return new string[5]
				{
					peremens.trans("Что искать в таблице"),
					peremens.trans("C учетом регистра"),
					peremens.trans("Слово целиком"),
					peremens.trans("Строка откуда начинать поиск"),
					peremens.trans("Столбец откуда начинать поиск")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Поиск в выделеных ячейках")), false) == 0)
			{
				return new string[4]
				{
					peremens.trans("Что искать в таблице"),
					peremens.trans("C учетом регистра"),
					peremens.trans("Слово целиком"),
					""
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Символ по номеру")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Порядковый номер символа в тексте"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Сравнить тексты")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Текст с которым сравнивать"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск в тексте")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск номера строки")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск с учетом регистра")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск в тексте с конца")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск без кавычек")), false) == 0))
			{
				return new string[4]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Что искать в тексте"),
					peremens.trans("Номер символа откуда начинать поиск"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Поиск с регулярными выражениями")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Шаблон регулярного выражения"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Количество символов")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Кавычки убрать")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Кавычками обособить")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Количество строк")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Сделать буквы прописными")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Сделать буквы заглавными")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Убрать пробелы")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Убрать пробелы в начале")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Убрать пробелы в конце")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Текст есть число")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Текст есть цифры")), false) == 0))
			{
				return new string[2]
				{
					peremens.trans("Исходный текст"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разбить на части")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разбить на части без кавычек")), false) == 0))
			{
				return new string[4]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Символ разделения частей"),
					peremens.trans("Номер нужной части"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Взять кусок текста")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Удалить кусок текста")), false) == 0))
			{
				return new string[4]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Номер символа начала куска"),
					peremens.trans("Длинна куска"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Количество частей текста")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Количество частей без кавычек")), false) == 0))
			{
				return new string[3]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Символ разделения частей"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Текст содержит")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Подряд символы которые должен содержать текст"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Текст не содержит")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Подряд символы которые не должен содержать текст"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Текст состоит из")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Подряд символы из которых должен состоять текст"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Строка по номеру")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Порядковый номер строки в тексте"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Вставить символы в текст")), false) == 0)
			{
				return new string[4]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Номер символа куда вставлять"),
					peremens.trans("Текст который надо вставить"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Заменить")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Заменить все")), false) == 0))
			{
				return new string[4]
				{
					peremens.trans("Исходный текст"),
					peremens.trans("Что заменять"),
					peremens.trans("На что заменять"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Запустить сообщение")), false) == 0)
			{
				return new string[4]
				{
					peremens.trans("Текст сообщения"),
					peremens.trans("Кнопки сообщения"),
					peremens.trans("Тип сообщения"),
					peremens.trans("Заголовок")
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("День месяца")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("День года")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("День в неделе")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Час")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Минута")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Секунда")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Квартал")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Неделя в году")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Год")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Месяц")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Секунд всего в дате")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("День недели")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Название месяца")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Время")), false) == 0))
			{
				return new string[2]
				{
					peremens.trans("Дата из которой брать"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить дни")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить часы")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить минуты")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить секунды")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить кварталы")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить недели")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить годы")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Прибавить месяцы")), false) == 0))
			{
				return new string[3]
				{
					peremens.trans("Дата к которой прибавлять"),
					peremens.trans("Сколько прибавить"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в днях")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в часах")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в минутах")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в секундах")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в кварталах")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в неделях")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в годах")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Разница в месяцах")), false) == 0))
			{
				return new string[3]
				{
					peremens.trans("Дата1 которую вычитать"),
					peremens.trans("Дата2 из которой вычитать"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Дней в месяце")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Год"),
					peremens.trans("Месяц"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Дата в определенном формате")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Дата"),
					peremens.trans("Номер формата вывода (от 1 до 52)"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Изменить время компьютера")), false) == 0)
			{
				return new string[1] { peremens.trans("Новая дата и время") };
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить код VBScript")), false) == 0)
			{
				return new string[1] { peremens.trans("Код VBScript") };
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить код Алгоритма2")), false) == 0)
			{
				return new string[1] { peremens.trans("Код Алгоритма 2") };
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить код VBNet")), false) == 0)
			{
				return new string[1] { peremens.trans("Код VBNet") };
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Выполнить код CSharp")), false) == 0)
			{
				return new string[1] { peremens.trans("Код CSharp") };
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Ключ активации выдать")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("ID пользователя"),
					peremens.trans("Показать в окне"),
					""
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Ключ активации проверить")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Ключ активации"),
					peremens.trans("Показать в окне"),
					""
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Переименовать")), false) == 0)
			{
				return new string[3]
				{
					peremens.trans("Путь к файлу или папке"),
					peremens.trans("Новое имя"),
					""
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Ip клиента")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Имя клиента"),
					""
				};
			}
			if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить серверу")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить клиентам")), false) == 0))
			{
				return new string[1] { peremens.trans("Содержимое сообщения") };
			}
			if ((Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить файл серверу")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить файл клиентам")), false) == 0) | (Operators.CompareString(meth, Strings.UCase(peremens.MyZnak + peremens.trans("Открыть папку")), false) == 0))
			{
				return new string[1] { peremens.trans("Путь к файлу или папке") };
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить клиентам кроме")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Имена клиентов, которым не отправлять"),
					peremens.trans("Содержимое сообщения")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить клиенту")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Имена клиентов"),
					peremens.trans("Содержимое сообщения")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить файл клиентам кроме")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Имена клиентов, которым не отправлять"),
					peremens.trans("Путь к файлу или папке")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Отправить файл клиенту")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Имена клиентов"),
					peremens.trans("Путь к файлу или папке")
				};
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Добавить в лог")), false) == 0)
			{
				return new string[1] { peremens.trans("Добавляемый текст") };
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Выполнить команду")), false) == 0)
			{
				return new string[1] { peremens.trans("Команда") };
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Получить код страницы")), false) == 0)
			{
				return new string[1] { peremens.trans("Ссылка") };
			}
			if (Operators.CompareString(meth, Strings.UCase(peremens.trans("Скачать файл")), false) == 0)
			{
				return new string[2]
				{
					peremens.trans("Ссылка"),
					peremens.trans("Ждать пока скачается")
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Количество файлов")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Количество папок")), false) == 0))
			{
				return new string[2]
				{
					peremens.trans("Путь к папке"),
					"неважно"
				};
			}
			if ((Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Зашифровать текст")), false) == 0) | (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Расшифровать текст")), false) == 0))
			{
				return new string[3]
				{
					peremens.trans("Текст"),
					peremens.trans("Ключ шифрования текста"),
					"неважно"
				};
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Процесс убить")), false) == 0)
			{
				return new string[1] { peremens.trans("Имя процесса") };
			}
			if (Operators.CompareString(meth, peremens.MyZnak + Strings.UCase(peremens.trans("Окно в фокусе")), false) == 0)
			{
				return new string[1] { peremens.trans("Заголовок окна") };
			}
			return null;
		}
	}

	public static string DefaultValue(string arg)
	{
		arg = Strings.UCase(arg);
		if ((Operators.CompareString(arg, Strings.UCase(peremens.trans("Путь к файлу")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Новый путь к файлу")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Путь к файлу или папке")), false) == 0))
		{
			return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"\"\\", NewLateBinding.LateGet(peremens2.proj, (Type)null, "iPathShort", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\\"), NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPicNameDef", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)".jpg\""));
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Путь к папке")), false) == 0)
		{
			return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"\"\\", NewLateBinding.LateGet(peremens2.proj, (Type)null, "iPathShort", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\""));
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Новое имя")), false) == 0)
		{
			return "\"" + peremens.trans("Файл") + ".txt\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Что сохранять")), false) == 0)
		{
			return peremens.trans("Окно") + "1." + peremens.trans("Окно") + "1." + peremens.trans("Текст");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Что искать")), false) == 0)
		{
			return "\"*.*\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Рисунок для сохранения")), false) == 0)
		{
			return peremens.trans("Окно") + "1." + peremens.trans("Окно") + "1." + peremens.trans("Фоновой рисунок");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Заменять совпадающие файлы")), false) == 0)
		{
			return peremens.trans("Да");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Только активное окно")), false) == 0)
		{
			return peremens.trans("Нет");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Симулировать набор следующего текста")), false) == 0)
		{
			return "\"" + peremens.trans("Этот текст печатает программа") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Команда Windows или имя файла")), false) == 0)
		{
			return "\"" + peremens.trans("explorer.exe") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Аргументы")), false) == 0)
		{
			return "\"" + peremens.trans("C:\\") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Размер вращения")), false) == 0)
		{
			return "\"" + peremens.trans("100") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Путь реестра")), false) == 0)
		{
			return "\"" + peremens.trans("HKEY_CURRENT_USER\\Control Panel\\Mouse") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Тип ключа")), false) == 0)
		{
			return peremens.trans("Строка");
		}
		if ((Operators.CompareString(arg, Strings.UCase(peremens.trans("X")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("X")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Порядковый номер строки")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Порядковый номер символа")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Y")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("У")), false) == 0))
		{
			return peremens.trans("0");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Обновить страницу")), false) == 0)
		{
			return peremens.trans("Обычно");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Область выборки")), false) == 0)
		{
			return peremens.trans("Вся таблица");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Область выборки")), false) == 0)
		{
			return peremens.trans("Вся таблица");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Сортировать по возрастанию")), false) == 0)
		{
			return peremens.trans("Да");
		}
		if ((Operators.CompareString(arg, Strings.UCase(peremens.trans("Порядковый номер символа в тексте")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Номер символа откуда начинать поиск")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Номер нужной части")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Номер символа начала куска")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Длинна куска")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Подряд символы которые должен содержать текст")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Подряд символы которые должен не содержать текст")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Порядковый номер строки в тексте")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Номер символа куда вставлять")), false) == 0))
		{
			return "1";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Кнопки сообщения")), false) == 0)
		{
			return peremens.trans("Ок");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Тип сообщения")), false) == 0)
		{
			return peremens.trans("Обычный");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Кодировка текста")), false) == 0)
		{
			return peremens.trans("По умолчанию");
		}
		if ((Operators.CompareString(arg, Strings.UCase(peremens.trans("Новая дата и время")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Дата")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Дата1 которую вычитать")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Дата2 из которой вычитать")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Дата к которой прибавлять")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Дата из которой брать")), false) == 0))
		{
			return peremens.ToMyDate(DateAndTime.get_Now());
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Номер формата вывода (от 1 до 52)")), false) == 0)
		{
			return "11";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Год")), false) == 0)
		{
			return Conversions.ToString(DateAndTime.get_Now().Year);
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Месяц")), false) == 0)
		{
			return Conversions.ToString(DateAndTime.get_Now().Month);
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Сколько прибавить")), false) == 0)
		{
			return "1";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Код VBScript")), false) == 0)
		{
			return "\"Sub main()" + Conversions.ToString(Strings.Chr(182)) + " msgbox(\"\"" + peremens.trans("Привет") + "!\"\")" + Conversions.ToString(Strings.Chr(182)) + "End Sub\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Код Алгоритма 2")), false) == 0)
		{
			return "\"_" + peremens.trans("Полезные объекты") + "._" + peremens.trans("Показать сообщение") + "._" + peremens.trans("Запустить сообщение") + "(\"\"" + peremens.trans("Привет") + "!\"\", " + peremens.trans("Ок") + ", " + peremens.trans("Обычный") + ", )\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Код VBNet")), false) == 0)
		{
			return "\"Imports System.Windows.Forms" + Conversions.ToString(Strings.Chr(182)) + "'" + peremens.trans("Класс MainClass и функция Main должны обязательно присутствовать") + Conversions.ToString(Strings.Chr(182)) + "Public Class MainClass " + Conversions.ToString(Strings.Chr(182)) + "   Public Function Main()" + Conversions.ToString(Strings.Chr(182)) + "       Dim frm as New Form" + Conversions.ToString(Strings.Chr(182)) + "       frm.Text=\"\"" + peremens.trans("Привет") + "!\"\"" + Conversions.ToString(Strings.Chr(182)) + "       frm.Show" + Conversions.ToString(Strings.Chr(182)) + "   End Function" + Conversions.ToString(Strings.Chr(182)) + "End Class\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Код CSharp")), false) == 0)
		{
			return "\"using System.Windows.Forms;" + Conversions.ToString(Strings.Chr(182)) + "//" + peremens.trans("Класс MainClass и функция Main должны обязательно присутствовать") + Conversions.ToString(Strings.Chr(182)) + "public class MainClass  {" + Conversions.ToString(Strings.Chr(182)) + "   public void Main() {" + Conversions.ToString(Strings.Chr(182)) + "       Form frm = new Form();" + Conversions.ToString(Strings.Chr(182)) + "       frm.Text=\"\"" + peremens.trans("Привет") + "!\"\";" + Conversions.ToString(Strings.Chr(182)) + "       frm.Show();" + Conversions.ToString(Strings.Chr(182)) + "   }" + Conversions.ToString(Strings.Chr(182)) + "}\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("SQL запрос выборки из базы данных")), false) == 0)
		{
			return "\"SELECT * FROM " + peremens.trans("Таблица") + "1\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("SQL запрос изменения базы данных")), false) == 0)
		{
			return "\"INSERT INTO " + peremens.trans("Таблица") + "1 VALUES ('1', 'a')\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Тип базы данных")), false) == 0)
		{
			return "Access";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Название таблицы")), false) == 0)
		{
			return "\"" + peremens.trans("Таблица") + "1\"";
		}
		if ((Operators.CompareString(arg, Strings.UCase(peremens.trans("Имена клиентов")), false) == 0) | (Operators.CompareString(arg, Strings.UCase(peremens.trans("Имена клиентов, которым не отправлять")), false) == 0))
		{
			return "\"" + peremens.trans("Клиент") + "1," + peremens.trans("Клиент") + "2," + peremens.trans("Клиент") + "3\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Тип файла")), false) == 0)
		{
			return "\"" + peremens.trans("image/gif") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Ждать пока скачается")), false) == 0)
		{
			return peremens.trans("Да");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Текст сообщения")), false) == 0)
		{
			return "\"" + peremens.trans("Текст сообщения") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Заголовок")), false) == 0)
		{
			return "\"" + peremens.trans("Заголовок") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Ключ шифрования текста")), false) == 0)
		{
			return "\"" + peremens.trans("абвгд12345") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Что искать в таблице")), false) == 0)
		{
			return "\"" + peremens.trans("Текст") + "\"";
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("C учетом регистра")), false) == 0)
		{
			return peremens.trans("Нет");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Слово целиком")), false) == 0)
		{
			return peremens.trans("Нет");
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Строка откуда начинать поиск")), false) == 0)
		{
			return Conversions.ToString(0);
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Столбец откуда начинать поиск")), false) == 0)
		{
			return Conversions.ToString(0);
		}
		if (Operators.CompareString(arg, Strings.UCase(peremens.trans("Объект съемки")), false) == 0)
		{
			return "\"" + peremens.trans("Окно") + "1\"";
		}
		return "";
	}

	public static bool ValidName(string name)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		if (name.Length == 0)
		{
			if (!peremens.IsHttpCompil)
			{
				Interaction.MsgBox((object)Errors.NameInvalidLength(name), (MsgBoxStyle)48, (object)null);
			}
			return false;
		}
		checked
		{
			int num = name.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (!char.IsLetter(name[num2]) & !char.IsDigit(name[num2]) & (Operators.CompareString(Conversions.ToString(name[num2]), " ", false) != 0))
					{
						break;
					}
					num2++;
					continue;
				}
				if (Operators.CompareString(Conversions.ToString(name[0]), " ", false) == 0)
				{
					if (!peremens.IsHttpCompil)
					{
						Interaction.MsgBox((object)Errors.NameInvalidProbels(name), (MsgBoxStyle)48, (object)null);
					}
					return false;
				}
				if (char.IsDigit(name[0]))
				{
					if (!peremens.IsHttpCompil)
					{
						Interaction.MsgBox((object)Errors.NameInvalidDigit(name), (MsgBoxStyle)48, (object)null);
					}
					return false;
				}
				int num3 = peremens.AllFuncs.Length - 1;
				num2 = 0;
				while (true)
				{
					if (num2 <= num3)
					{
						if (Operators.CompareString(Strings.LCase(peremens.AllFuncs[num2]), Strings.LCase(name), false) == 0)
						{
							break;
						}
						num2++;
						continue;
					}
					int num4 = peremens.AllHW.Length - 1;
					num2 = 0;
					while (true)
					{
						if (num2 <= num4)
						{
							if (Operators.CompareString(Strings.LCase(peremens.AllHW[num2]), Strings.LCase(name), false) == 0)
							{
								break;
							}
							num2++;
							continue;
						}
						int num5 = peremens.VBKeyWords.Length - 1;
						num2 = 0;
						while (true)
						{
							if (num2 <= num5)
							{
								if (Operators.CompareString(Strings.LCase(peremens.VBKeyWords[num2]), Strings.LCase(name), false) != 0)
								{
									if (Strings.LCase(name).IndexOf(" " + Strings.LCase(peremens.VBKeyWords[num2]) + " ") == -1)
									{
										if (Strings.LCase(name).IndexOf(Strings.LCase(peremens.VBKeyWords[num2]) + " ") != 0)
										{
											if ((Strings.LCase(name).IndexOf(" " + Strings.LCase(peremens.VBKeyWords[num2])) != -1) & (Strings.LCase(name).IndexOf(" " + Strings.LCase(peremens.VBKeyWords[num2])) == name.Length - (" " + peremens.VBKeyWords[num2]).Length))
											{
												break;
											}
											num2++;
											continue;
										}
										if (!peremens.IsHttpCompil)
										{
											Interaction.MsgBox((object)Errors.NameInvalidHW(peremens.VBKeyWords[num2]), (MsgBoxStyle)48, (object)null);
										}
										return false;
									}
									if (!peremens.IsHttpCompil)
									{
										Interaction.MsgBox((object)Errors.NameInvalidHW(peremens.VBKeyWords[num2]), (MsgBoxStyle)48, (object)null);
									}
									return false;
								}
								if (!peremens.IsHttpCompil)
								{
									Interaction.MsgBox((object)Errors.NameInvalidHW(peremens.VBKeyWords[num2]), (MsgBoxStyle)48, (object)null);
								}
								return false;
							}
							return true;
						}
						if (!peremens.IsHttpCompil)
						{
							Interaction.MsgBox((object)Errors.NameInvalidHW(peremens.VBKeyWords[num2]), (MsgBoxStyle)48, (object)null);
						}
						return false;
					}
					if (!peremens.IsHttpCompil)
					{
						Interaction.MsgBox((object)Errors.NameInvalidHW(peremens.AllHW[num2]), (MsgBoxStyle)48, (object)null);
					}
					return false;
				}
				if (!peremens.IsHttpCompil)
				{
					Interaction.MsgBox((object)Errors.NameInvalidFuns(peremens.AllFuncs[num2]), (MsgBoxStyle)48, (object)null);
				}
				return false;
			}
			if (!peremens.IsHttpCompil)
			{
				Interaction.MsgBox((object)Errors.NameInvalidSimvols(name), (MsgBoxStyle)48, (object)null);
			}
			return false;
		}
	}

	public static void IzmenenieBylo(bool withNoMarkerVis = true)
	{
		bool mozhno = false;
		if (NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) == null || NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
		{
			return;
		}
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object obj = NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { i };
			bool[] array2 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "ActiveObj", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			IzmenenieBylo2(RuntimeHelpers.GetObjectValue(obj2), ref mozhno);
		}
		if (mozhno)
		{
			NewLateBinding.LateCall(peremens2.MainForm, (Type)null, "ReSelectedListViewOneItem", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		if (Conversions.ToBoolean(Operators.AndObject((object)(!withNoMarkerVis), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "Peremeschatel", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Focused", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		peremens.fromIzmenenieBylo = false;
	}

	public static void IzmenenieBylo2(object myObj, ref bool mozhno = false)
	{
		if (!peremens.fromIzmenenieBylo)
		{
			peremens.fromIzmenenieBylo = true;
			if (!Iz.IsRT(RuntimeHelpers.GetObjectValue(myObj)))
			{
				izmenit(Strings.UCase(peremens.trans("Текст")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
			}
			if (Iz.IsTr(RuntimeHelpers.GetObjectValue(myObj)))
			{
				izmenit(Strings.UCase(peremens.trans("Текст поля")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TextB", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
			}
			if (!Iz.IsFORM(RuntimeHelpers.GetObjectValue(myObj)))
			{
				izmenit(Strings.UCase(peremens.trans("X")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
				izmenit(Strings.UCase(peremens.trans("Y")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
			}
			izmenit(Strings.UCase(peremens.trans("Вышина")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
			izmenit(Strings.UCase(peremens.trans("Ширина")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
			if (Iz.IsDP(RuntimeHelpers.GetObjectValue(myObj)))
			{
				izmenit(Strings.UCase(peremens.trans("Расстояние разделителя")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterDistance", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
			}
			if (Iz.IsTP(RuntimeHelpers.GetObjectValue(myObj)))
			{
				izmenit(Strings.UCase(peremens.trans("Позиция выделенной закладки")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
			}
			if (Iz.IsC(RuntimeHelpers.GetObjectValue(myObj)) | Iz.IsL(RuntimeHelpers.GetObjectValue(myObj)) | Iz.IsCL(RuntimeHelpers.GetObjectValue(myObj)))
			{
				izmenit(Strings.UCase(peremens.trans("Номер выделенной записи")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
				izmenit(Strings.UCase(peremens.trans("Выделенная запись")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
			}
			if (Iz.IsL(RuntimeHelpers.GetObjectValue(myObj)))
			{
				izmenit(Strings.UCase(peremens.trans("Номера выделенных записей")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedIndex", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
				izmenit(Strings.UCase(peremens.trans("Выделенные записи")), Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedItem", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(myObj), ref mozhno);
			}
			peremens.fromIzmenenieBylo = false;
		}
	}

	public static void izmenit(string prop, string value, object myObj, ref bool mozhno)
	{
		if (NewLateBinding.LateGet(myObj, (Type)null, "PropertysUp", new object[0], (string[])null, (Type[])null, (bool[])null) == null || !((Operators.CompareString(GetProperty(RuntimeHelpers.GetObjectValue(myObj), prop).str, value, false) != 0) & (Array.IndexOf((Array)NewLateBinding.LateGet(myObj, (Type)null, "PropertysUp", new object[0], (string[])null, (Type[])null, (bool[])null), prop) != -1)))
		{
			return;
		}
		if (mozhno)
		{
			NewLateBinding.LateCall(peremens2.proj, (Type)null, "UndoRedo", new object[4] { "#Union Undos(Redos)", "", "", "" }, (string[])null, (Type[])null, (bool[])null, true);
		}
		bool[] array3;
		if (NewLateBinding.LateGet(myObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			object obj = NewLateBinding.LateGet(myObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[4]
			{
				prop,
				value,
				"",
				RuntimeHelpers.GetObjectValue(myObj)
			};
			object[] array2 = array;
			array3 = new bool[4] { true, true, false, true };
			NewLateBinding.LateCall(obj, (Type)null, "SetPropertys", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				prop = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (array3[1])
			{
				value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
			if (array3[3])
			{
				myObj = RuntimeHelpers.GetObjectValue(array[3]);
			}
		}
		mozhno = true;
		object mainForm = peremens2.MainForm;
		object[] array4 = new object[2] { prop, value };
		object[] array5 = array4;
		array3 = new bool[2] { true, true };
		NewLateBinding.LateCall(mainForm, (Type)null, "RefreshListViewOneItem", array5, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			prop = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
		}
		if (array3[1])
		{
			value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(string));
		}
	}

	public static void IzmenenieByloExpert()
	{
		bool bilo = false;
		if (peremens.fromIzmenenieBylo)
		{
			return;
		}
		peremens.fromIzmenenieBylo = true;
		if (NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) == null || NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
		{
			return;
		}
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object obj = NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { i };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "ActiveObj", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			object objectValue = RuntimeHelpers.GetObjectValue(obj2);
			if (Iz.IsTl(RuntimeHelpers.GetObjectValue(objectValue)))
			{
				string prop = Strings.UCase(peremens.trans("Номера выделенных строк"));
				object obj3 = objectValue;
				object obj4 = obj3;
				array = new object[0];
				object[] array4 = array;
				string[] array5 = null;
				object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "obj", array4, array5, (Type[])null, (bool[])null);
				object[] array6 = new object[0];
				object[] array7 = array6;
				string[] array8 = null;
				object varPrivatePropertys = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "Props", array7, array8, (Type[])null, (bool[])null), (Type)null, "selRows", new object[0], (string[])null, (Type[])null, (bool[])null));
				izmenitExp(prop, ref varPrivatePropertys, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedRows", new object[0], (string[])null, (Type[])null, (bool[])null)), ref bilo);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "obj", array, array5, (Type[])null, (bool[])null), (Type)null, "Props", array6, array8, (Type[])null, (bool[])null), (Type)null, "selRows", new object[1] { RuntimeHelpers.GetObjectValue(varPrivatePropertys) }, (string[])null, (Type[])null, true, true);
				string prop2 = Strings.UCase(peremens.trans("Номера выделенных столбцов"));
				varPrivatePropertys = objectValue;
				object obj6 = varPrivatePropertys;
				object[] array9 = new object[0];
				object[] array10 = array9;
				array8 = null;
				object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "obj", array10, array8, (Type[])null, (bool[])null);
				array = new object[0];
				object[] array11 = array;
				array5 = null;
				obj3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "Props", array11, array5, (Type[])null, (bool[])null), (Type)null, "selCol", new object[0], (string[])null, (Type[])null, (bool[])null));
				izmenitExp(prop2, ref obj3, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedColumns", new object[0], (string[])null, (Type[])null, (bool[])null)), ref bilo);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(varPrivatePropertys, (Type)null, "obj", array9, array8, (Type[])null, (bool[])null), (Type)null, "Props", array, array5, (Type[])null, (bool[])null), (Type)null, "selCol", new object[1] { RuntimeHelpers.GetObjectValue(obj3) }, (string[])null, (Type[])null, true, true);
				string prop3 = Strings.UCase(peremens.trans("Ширина столбцов"));
				varPrivatePropertys = objectValue;
				object obj8 = varPrivatePropertys;
				array9 = new object[0];
				object[] array12 = array9;
				array8 = null;
				object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "obj", array12, array8, (Type[])null, (bool[])null);
				array = new object[0];
				object[] array13 = array;
				array5 = null;
				obj3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "Props", array13, array5, (Type[])null, (bool[])null), (Type)null, "colsWids", new object[0], (string[])null, (Type[])null, (bool[])null));
				izmenitExp(prop3, ref obj3, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WidthOfColumns", new object[0], (string[])null, (Type[])null, (bool[])null)), ref bilo);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(varPrivatePropertys, (Type)null, "obj", array9, array8, (Type[])null, (bool[])null), (Type)null, "Props", array, array5, (Type[])null, (bool[])null), (Type)null, "colsWids", new object[1] { RuntimeHelpers.GetObjectValue(obj3) }, (string[])null, (Type[])null, true, true);
				string prop4 = Strings.UCase(peremens.trans("Вышина строк"));
				varPrivatePropertys = objectValue;
				object obj10 = varPrivatePropertys;
				array9 = new object[0];
				object[] array14 = array9;
				array8 = null;
				object obj11 = NewLateBinding.LateGet(obj10, (Type)null, "obj", array14, array8, (Type[])null, (bool[])null);
				array = new object[0];
				object[] array15 = array;
				array5 = null;
				obj3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj11, (Type)null, "Props", array15, array5, (Type[])null, (bool[])null), (Type)null, "RowsH", new object[0], (string[])null, (Type[])null, (bool[])null));
				izmenitExp(prop4, ref obj3, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "HeightOfRows", new object[0], (string[])null, (Type[])null, (bool[])null)), ref bilo);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(varPrivatePropertys, (Type)null, "obj", array9, array8, (Type[])null, (bool[])null), (Type)null, "Props", array, array5, (Type[])null, (bool[])null), (Type)null, "RowsH", new object[1] { RuntimeHelpers.GetObjectValue(obj3) }, (string[])null, (Type[])null, true, true);
			}
		}
		if (bilo)
		{
			NewLateBinding.LateCall(peremens2.MainForm, (Type)null, "ReSelectedListViewOneItem", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		peremens.fromIzmenenieBylo = false;
	}

	public static void izmenitExp(string prop, ref object varPrivatePropertys, object varPublicPropertys, ref bool bilo)
	{
		varPrivatePropertys = RuntimeHelpers.GetObjectValue(varPublicPropertys);
		bilo = true;
		object mainForm = peremens2.MainForm;
		object[] array = new object[2]
		{
			prop,
			RuntimeHelpers.GetObjectValue(varPublicPropertys)
		};
		bool[] array2 = new bool[2] { true, true };
		NewLateBinding.LateCall(mainForm, (Type)null, "RefreshListViewOneItem", array, (string[])null, (Type[])null, array2, true);
		if (array2[0])
		{
			prop = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		if (array2[1])
		{
			varPublicPropertys = RuntimeHelpers.GetObjectValue(array[1]);
		}
	}

	public static string SrazuPerevoditHW(string word)
	{
		if (peremens.Papks.ContainsKey(Strings.LCase(word)))
		{
			if (!peremens.isCompilBest)
			{
				return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"\"", peremens.Papks[Strings.LCase(word)]), (object)"\""));
			}
			return "Papks(LCase(\"" + word + "\"))";
		}
		return null;
	}

	public static void CreateConstants()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected O, but got Unknown
		//IL_1534: Unknown result type (might be due to invalid IL or missing references)
		//IL_1545: Unknown result type (might be due to invalid IL or missing references)
		//IL_1559: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Path.GetTempFileName();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)peremens.trans("Папка с временными файлами переполнена! Очистите её. Она откроется, когда вы нажмете Ok."), (MsgBoxStyle)0, (object)null);
			Process.Start("explorer", Path.GetTempPath());
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		peremens.Colors.Clear();
		peremens.Colors.Add(Strings.LCase(peremens.trans("аква")), Color.Aqua);
		peremens.Colors.Add(Strings.LCase(peremens.trans("черный")), Color.Black);
		peremens.Colors.Add(Strings.LCase(peremens.trans("синий")), Color.Blue);
		peremens.Colors.Add(Strings.LCase(peremens.trans("коричневый")), Color.Brown);
		peremens.Colors.Add(Strings.LCase(peremens.trans("шоколадный")), Color.Chocolate);
		peremens.Colors.Add(Strings.LCase(peremens.trans("кораловый")), Color.Coral);
		peremens.Colors.Add(Strings.LCase(peremens.trans("серый")), Color.Gray);
		peremens.Colors.Add(Strings.LCase(peremens.trans("салатовый")), Color.GreenYellow);
		peremens.Colors.Add(Strings.LCase(peremens.trans("индиго")), Color.Indigo);
		peremens.Colors.Add(Strings.LCase(peremens.trans("лайм")), Color.Lime);
		peremens.Colors.Add(Strings.LCase(peremens.trans("розовый")), Color.Magenta);
		peremens.Colors.Add(Strings.LCase(peremens.trans("фиолетовый")), Color.Violet);
		peremens.Colors.Add(Strings.LCase(peremens.trans("серебряный")), Color.Silver);
		peremens.Colors.Add(Strings.LCase(peremens.trans("оранжевый")), Color.Orange);
		peremens.Colors.Add(Strings.LCase(peremens.trans("хаки")), Color.DarkKhaki);
		peremens.Colors.Add(Strings.LCase(peremens.trans("море")), Color.Teal);
		peremens.Colors.Add(Strings.LCase(peremens.trans("яркосиний")), Color.DodgerBlue);
		peremens.Colors.Add(Strings.LCase(peremens.trans("пурпурный")), Color.Purple);
		peremens.Colors.Add(Strings.LCase(peremens.trans("системный")), SystemColors.Control);
		peremens.Colors.Add(Strings.LCase(peremens.trans("системный темный")), SystemColors.ControlDark);
		peremens.Colors.Add(Strings.LCase(peremens.trans("белый")), Color.White);
		peremens.Colors.Add(Strings.LCase(peremens.trans("красный")), Color.Red);
		peremens.Colors.Add(Strings.LCase(peremens.trans("зеленый")), Color.Green);
		peremens.Colors.Add(Strings.LCase(peremens.trans("желтый")), Color.Yellow);
		peremens.Anchors.Clear();
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Никакой")), 0);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Слева")), 4);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Справа")), 8);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Сверху")), 1);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Снизу")), 2);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Слева_Сверху")), 5);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Слева_Снизу")), 6);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Справа_Слева")), 12);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Справа_Сверху")), 9);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Справа_Снизу")), 10);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Сверху_Снизу")), 3);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Слева_Сверху_Снизу")), 7);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Справа_Сверху_Снизу")), 11);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Справа_Слева_Сверху")), 13);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Справа_Слева_Снизу")), 14);
		peremens.Anchors.Add(Strings.LCase(peremens.trans("Справа_Слева_Сверху_Снизу")), 15);
		peremens.bkImStyles.Clear();
		peremens.bkImStyles.Add(Strings.LCase(peremens.trans("Никакой")), (object)(ImageLayout)0);
		peremens.bkImStyles.Add(Strings.LCase(peremens.trans("Плитка")), (object)(ImageLayout)1);
		peremens.bkImStyles.Add(Strings.LCase(peremens.trans("По центру")), (object)(ImageLayout)2);
		peremens.bkImStyles.Add(Strings.LCase(peremens.trans("Растянутый")), (object)(ImageLayout)3);
		peremens.bkImStyles.Add(Strings.LCase(peremens.trans("Масштабированный")), (object)(ImageLayout)4);
		peremens.Cursori.Clear();
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Обычный")), Cursors.get_Default());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Старт приложения")), Cursors.get_AppStarting());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Пересечение")), Cursors.get_Cross());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Рука")), Cursors.get_Hand());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Помощь")), Cursors.get_Help());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Горизонтальный разделитель")), Cursors.get_HSplit());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Текстовый")), Cursors.get_IBeam());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Запрещающий")), Cursors.get_No());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Запрещающий перемещение")), Cursors.get_NoMove2D());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Запрещающий по горизонтали")), Cursors.get_NoMoveHoriz());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Запрещающий по вертикали")), Cursors.get_NoMoveVert());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Направление восток")), Cursors.get_PanEast());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Направление СВ")), Cursors.get_PanNE());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Направление север")), Cursors.get_PanNorth());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Направление СЗ")), Cursors.get_PanNW());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Направление ЮВ")), Cursors.get_PanSE());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Направление юг")), Cursors.get_PanSouth());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Направление ЮЗ")), Cursors.get_PanSW());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Направление запад")), Cursors.get_PanWest());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Растянивание везде")), Cursors.get_SizeAll());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Растянивание СВЮЗ")), Cursors.get_SizeNESW());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Растянивание СЮ")), Cursors.get_SizeNS());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Растянивание СЗЮВ")), Cursors.get_SizeNWSE());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Растянивание ЗВ")), Cursors.get_SizeWE());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Стрелка вверх")), Cursors.get_UpArrow());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Вертикальный разделитель")), Cursors.get_VSplit());
		peremens.Cursori.Add(Strings.LCase(peremens.trans("Ожидание")), Cursors.get_WaitCursor());
		peremens.Docks.Clear();
		peremens.Docks.Add(Strings.LCase(peremens.trans("Никакой")), (object)(DockStyle)0);
		peremens.Docks.Add(Strings.LCase(peremens.trans("По верху")), (object)(DockStyle)1);
		peremens.Docks.Add(Strings.LCase(peremens.trans("По низу")), (object)(DockStyle)2);
		peremens.Docks.Add(Strings.LCase(peremens.trans("Слева")), (object)(DockStyle)3);
		peremens.Docks.Add(Strings.LCase(peremens.trans("Справа")), (object)(DockStyle)4);
		peremens.Docks.Add(Strings.LCase(peremens.trans("Везде")), (object)(DockStyle)5);
		peremens.FlatStyles.Clear();
		peremens.FlatStyles.Add(Strings.LCase(peremens.trans("Плоский")), (object)(FlatStyle)0);
		peremens.FlatStyles.Add(Strings.LCase(peremens.trans("Поднимающийся")), (object)(FlatStyle)1);
		peremens.FlatStyles.Add(Strings.LCase(peremens.trans("Обычный")), (object)(FlatStyle)2);
		peremens.FlatStyles.Add(Strings.LCase(peremens.trans("Системный")), (object)(FlatStyle)3);
		InstalledFontCollection val = new InstalledFontCollection();
		peremens.Fonts.Clear();
		checked
		{
			int num = ((FontCollection)val).get_Families().Length - 1;
			for (int i = 0; i <= num; i++)
			{
				peremens.Fonts.Add(Strings.LCase(((FontCollection)val).get_Families()[i].get_Name()), ((FontCollection)val).get_Families()[i].get_Name());
			}
			peremens.Aligns.Clear();
			peremens.Aligns.Add(Strings.LCase(peremens.trans("Верх слева")), (object)(ContentAlignment)1);
			peremens.Aligns.Add(Strings.LCase(peremens.trans("Верх")), (object)(ContentAlignment)2);
			peremens.Aligns.Add(Strings.LCase(peremens.trans("Верх справа")), (object)(ContentAlignment)4);
			peremens.Aligns.Add(Strings.LCase(peremens.trans("Слева")), (object)(ContentAlignment)16);
			peremens.Aligns.Add(Strings.LCase(peremens.trans("Центр")), (object)(ContentAlignment)32);
			peremens.Aligns.Add(Strings.LCase(peremens.trans("Справа")), (object)(ContentAlignment)64);
			peremens.Aligns.Add(Strings.LCase(peremens.trans("Низ слева")), (object)(ContentAlignment)256);
			peremens.Aligns.Add(Strings.LCase(peremens.trans("Низ")), (object)(ContentAlignment)512);
			peremens.Aligns.Add(Strings.LCase(peremens.trans("Низ справа")), (object)(ContentAlignment)1024);
			peremens.TextImages.Clear();
			peremens.TextImages.Add(Strings.LCase(peremens.trans("Поверх")), (object)(TextImageRelation)0);
			peremens.TextImages.Add(Strings.LCase(peremens.trans("Слева")), (object)(TextImageRelation)8);
			peremens.TextImages.Add(Strings.LCase(peremens.trans("Сверху")), (object)(TextImageRelation)2);
			peremens.TextImages.Add(Strings.LCase(peremens.trans("Снизу")), (object)(TextImageRelation)1);
			peremens.TextImages.Add(Strings.LCase(peremens.trans("Справа")), (object)(TextImageRelation)4);
			peremens.BorderStyles.Clear();
			peremens.BorderStyles.Add(Strings.LCase(peremens.trans("Никакой")), (object)(BorderStyle)0);
			peremens.BorderStyles.Add(Strings.LCase(peremens.trans("Линия")), (object)(BorderStyle)1);
			peremens.BorderStyles.Add(Strings.LCase(peremens.trans("Объем")), (object)(BorderStyle)2);
			peremens.FixedPanels.Clear();
			peremens.FixedPanels.Add(Strings.LCase(peremens.trans("Никакой")), (object)(FixedPanel)0);
			peremens.FixedPanels.Add(Strings.LCase(peremens.trans("Панель1")), (object)(FixedPanel)1);
			peremens.FixedPanels.Add(Strings.LCase(peremens.trans("Панель2")), (object)(FixedPanel)2);
			peremens.Orientations.Clear();
			peremens.Orientations.Add(Strings.LCase(peremens.trans("Горизонтальная")), (object)(Orientation)0);
			peremens.Orientations.Add(Strings.LCase(peremens.trans("Вертикальная")), (object)(Orientation)1);
			peremens.Papks.Clear();
			if (!peremens.isHelp)
			{
				peremens.Papks.Add(Strings.LCase(peremens.trans("Папка проекта")), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPath", new object[0], (string[])null, (Type[])null, (bool[])null)));
				peremens.Papks.Add(Strings.LCase(peremens.trans("Рисунки проекта")), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(peremens2.proj, (Type)null, "iPath", new object[0], (string[])null, (Type[])null, (bool[])null)));
			}
			else
			{
				peremens.Papks.Add(Strings.LCase(peremens.trans("Папка проекта")), "");
				peremens.Papks.Add(Strings.LCase(peremens.trans("Рисунки проекта")), "");
			}
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Куки")), Environment.GetFolderPath(Environment.SpecialFolder.Cookies) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Рабочий стол")), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Избранное")), Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Журнал")), Environment.GetFolderPath(Environment.SpecialFolder.History) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Интернет кэш")), Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase("ApplicationData"), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Мои документы")), Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Мой компьютер")), Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Моя музыка")), Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Мои рисунки")), Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase("ProgramFiles"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Пуск-программы")), Environment.GetFolderPath(Environment.SpecialFolder.Programs) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Недавние файлы")), Environment.GetFolderPath(Environment.SpecialFolder.Recent) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Отправить")), Environment.GetFolderPath(Environment.SpecialFolder.SendTo) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Пуск")), Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Автозагрузка")), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase("System32"), Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase("Windows"), Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Временная папка")), Path.GetTempPath() + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Временный файл")), Path.GetTempFileName());
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Папка пользователя")), Environment.GetEnvironmentVariable("USERPROFILE") + "\\");
			peremens.Papks.Add(peremens.MyZnak + Strings.LCase(peremens.trans("Все пользователи")), Environment.GetEnvironmentVariable("ALLUSERSPROFILE") + "\\");
			if (Environment.GetCommandLineArgs().Length > 0)
			{
				peremens.Papks.Add(Strings.LCase(peremens.trans("Имя файла")), Environment.GetCommandLineArgs()[0]);
			}
			Keys val2 = default(Keys);
			object[] array = new object[2]
			{
				Enum.GetNames(((object)val2).GetType()),
				Enum.GetValues(((object)val2).GetType())
			};
			peremens.Keyz.Clear();
			int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(array[0], (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num2; i++)
			{
				SortedList keyz = peremens.Keyz;
				Type typeFromHandle = typeof(Strings);
				object[] array2 = new object[1];
				int num3 = 0;
				array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array[0], new object[1] { i }, (string[])null));
				object[] array3 = array2;
				bool[] array4 = new bool[1] { true };
				object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "LCase", array3, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					NewLateBinding.LateIndexSetComplex(array[num3], new object[2]
					{
						i,
						RuntimeHelpers.GetObjectValue(array3[0])
					}, (string[])null, true, false);
				}
				keyz.Add(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array[1], new object[1] { i }, (string[])null)));
			}
			peremens.DeskStyle.Clear();
			peremens.DeskStyle.Add(Strings.LCase(peremens.trans("Плитка")), "0,1");
			peremens.DeskStyle.Add(Strings.LCase(peremens.trans("По центру")), "1,0");
			peremens.DeskStyle.Add(Strings.LCase(peremens.trans("Растянутый")), "2,0");
			peremens.TypeRegistry.Clear();
			peremens.TypeRegistry.Add(Strings.LCase(peremens.trans("Двоичное число")), RegistryValueKind.Binary);
			peremens.TypeRegistry.Add(Strings.LCase(peremens.trans("Число")), RegistryValueKind.DWord);
			peremens.TypeRegistry.Add(Strings.LCase(peremens.trans("Расширенная строка")), RegistryValueKind.ExpandString);
			peremens.TypeRegistry.Add(Strings.LCase(peremens.trans("Мультистрока")), RegistryValueKind.MultiString);
			peremens.TypeRegistry.Add(Strings.LCase(peremens.trans("Большое число")), RegistryValueKind.QWord);
			peremens.TypeRegistry.Add(Strings.LCase(peremens.trans("Строка")), RegistryValueKind.String);
			peremens.ScrollBarz.Clear();
			peremens.ScrollBarz.Add(Strings.LCase(peremens.trans("Нет")), (object)(ScrollBars)0);
			peremens.ScrollBarz.Add(Strings.LCase(peremens.trans("Горизонтальная")), (object)(ScrollBars)1);
			peremens.ScrollBarz.Add(Strings.LCase(peremens.trans("Вертикальная")), (object)(ScrollBars)2);
			peremens.ScrollBarz.Add(Strings.LCase(peremens.trans("Обе")), (object)(ScrollBars)3);
			peremens.TextPositions.Clear();
			peremens.TextPositions.Add(Strings.LCase(peremens.trans("Слева")), (object)(HorizontalAlignment)0);
			peremens.TextPositions.Add(Strings.LCase(peremens.trans("Справа")), (object)(HorizontalAlignment)1);
			peremens.TextPositions.Add(Strings.LCase(peremens.trans("Центр")), (object)(HorizontalAlignment)2);
			peremens.DisplayStyles.Clear();
			peremens.DisplayStyles.Add(Strings.LCase(peremens.trans("Нет")), (object)(ToolStripItemDisplayStyle)0);
			peremens.DisplayStyles.Add(Strings.LCase(peremens.trans("Текст")), (object)(ToolStripItemDisplayStyle)1);
			peremens.DisplayStyles.Add(Strings.LCase(peremens.trans("Рисунок")), (object)(ToolStripItemDisplayStyle)2);
			peremens.DisplayStyles.Add(Strings.LCase(peremens.trans("Рисунок и текст")), (object)(ToolStripItemDisplayStyle)3);
			peremens.TextDirections.Clear();
			peremens.TextDirections.Add(Strings.LCase(peremens.trans("Горизонтальный")), (object)(ToolStripTextDirection)1);
			peremens.TextDirections.Add(Strings.LCase(peremens.trans("Вертикальный 90")), (object)(ToolStripTextDirection)2);
			peremens.TextDirections.Add(Strings.LCase(peremens.trans("Вертикальный 270")), (object)(ToolStripTextDirection)3);
			peremens.ReadyStates.Clear();
			peremens.ReadyStates.Add(Strings.LCase(peremens.trans("Страницы нет")), (object)(WebBrowserReadyState)0);
			peremens.ReadyStates.Add(Strings.LCase(peremens.trans("Страница загружается")), (object)(WebBrowserReadyState)1);
			peremens.ReadyStates.Add(Strings.LCase(peremens.trans("Страница загружена")), (object)(WebBrowserReadyState)2);
			peremens.ReadyStates.Add(Strings.LCase(peremens.trans("Пользователькая активность")), (object)(WebBrowserReadyState)3);
			peremens.ReadyStates.Add(Strings.LCase(peremens.trans("Страница полностью готова")), (object)(WebBrowserReadyState)4);
			peremens.DocumentEncodings.Clear();
			peremens.DocumentEncodings.Add(Strings.LCase("Western"), Strings.LCase("Windows-1252"));
			peremens.DocumentEncodings.Add(Strings.LCase("ASCII"), Strings.LCase("us-ascii"));
			peremens.DocumentEncodings.Add(Strings.LCase("Central European (ISO)"), Strings.LCase("iso-8859-2"));
			peremens.DocumentEncodings.Add(Strings.LCase("Central European (Windows)"), Strings.LCase("Windows-1250"));
			peremens.DocumentEncodings.Add(Strings.LCase("Cyrillic (Windows)"), Strings.LCase("Windows-1251"));
			peremens.DocumentEncodings.Add(Strings.LCase("Greek (Windows)"), Strings.LCase("Windows-1253"));
			peremens.DocumentEncodings.Add(Strings.LCase("Turkish (Windows)"), Strings.LCase("Windows-1254"));
			peremens.DocumentEncodings.Add(Strings.LCase("Japanese (Shift-JIS)"), Strings.LCase("shift_jis"));
			peremens.DocumentEncodings.Add(Strings.LCase("Japanese (EUC)"), Strings.LCase("x-euc-jp"));
			peremens.DocumentEncodings.Add(Strings.LCase("Japanese (JIS)"), Strings.LCase("iso-2022-jp"));
			peremens.DocumentEncodings.Add(Strings.LCase("Baltic (Windows)"), Strings.LCase("Windows-1257"));
			peremens.DocumentEncodings.Add(Strings.LCase("Traditional Chinese (BIG5) "), Strings.LCase("big5"));
			peremens.DocumentEncodings.Add(Strings.LCase("Simplified Chinese (GB2312)"), Strings.LCase("gb2312"));
			peremens.DocumentEncodings.Add(Strings.LCase("Cyrillic (KOI8-R)"), Strings.LCase("koi8-r"));
			peremens.DocumentEncodings.Add(Strings.LCase("Korean (KSC5601)"), Strings.LCase("ks_c_5601"));
			peremens.DocumentEncodings.Add(Strings.LCase("Hebrew (ISO-logical)"), Strings.LCase("Windows-1255"));
			peremens.DocumentEncodings.Add(Strings.LCase("Hebrew (ISO-Visual)"), Strings.LCase("iso-8859-8"));
			peremens.DocumentEncodings.Add(Strings.LCase("Hebrew (DOS)"), Strings.LCase("dos-862"));
			peremens.DocumentEncodings.Add(Strings.LCase("Arabic (Windows)"), Strings.LCase("Windows-1256"));
			peremens.DocumentEncodings.Add(Strings.LCase("Arabic (DOS)"), Strings.LCase("dos-720"));
			peremens.DocumentEncodings.Add(Strings.LCase("Thai"), Strings.LCase("Windows-874"));
			peremens.DocumentEncodings.Add(Strings.LCase("Vietnamese"), Strings.LCase("Windows-1258"));
			peremens.DocumentEncodings.Add(Strings.LCase("Unicode UTF-8"), Strings.LCase("UTF-8"));
			peremens.DocumentEncodings.Add(Strings.LCase("Unicode UTF-7"), Strings.LCase("UTF-7"));
			peremens.DocumentEncodings.Add(Strings.LCase("Korean (ISO)"), Strings.LCase("ISO-2022-KR"));
			peremens.DocumentEncodings.Add(Strings.LCase("Simplified Chinese (HZ)"), Strings.LCase("HZ-GB-2312"));
			peremens.DocumentEncodings.Add(Strings.LCase("Baltic (ISO)"), Strings.LCase("iso-8869-4"));
			peremens.DocumentEncodings.Add(Strings.LCase("Cyrillic (ISO)"), Strings.LCase("iso_8859-5"));
			peremens.DocumentEncodings.Add(Strings.LCase("Greek (ISO)"), Strings.LCase("iso-8859-7"));
			peremens.DocumentEncodings.Add(Strings.LCase("Turkish (ISO)"), Strings.LCase("iso-8859-9"));
			peremens.Refreshs.Clear();
			peremens.Refreshs.Add(Strings.LCase(peremens.trans("Обычно")), (object)(WebBrowserRefreshOption)0);
			peremens.Refreshs.Add(Strings.LCase(peremens.trans("Полностью")), (object)(WebBrowserRefreshOption)3);
			peremens.Refreshs.Add(Strings.LCase(peremens.trans("Если устарела")), (object)(WebBrowserRefreshOption)1);
			peremens.FormBorderStyles.Clear();
			peremens.FormBorderStyles.Add(Strings.LCase(peremens.trans("Никакой")), (object)(FormBorderStyle)0);
			peremens.FormBorderStyles.Add(Strings.LCase(peremens.trans("Фиксированное простое")), (object)(FormBorderStyle)1);
			peremens.FormBorderStyles.Add(Strings.LCase(peremens.trans("Фиксированное объемное")), (object)(FormBorderStyle)2);
			peremens.FormBorderStyles.Add(Strings.LCase(peremens.trans("Фиксированное окно")), (object)(FormBorderStyle)3);
			peremens.FormBorderStyles.Add(Strings.LCase(peremens.trans("Нормальный")), (object)(FormBorderStyle)4);
			peremens.FormBorderStyles.Add(Strings.LCase(peremens.trans("Окно инструментов")), (object)(FormBorderStyle)6);
			peremens.FormBorderStyles.Add(Strings.LCase(peremens.trans("Фиксированное окно инструментов")), (object)(FormBorderStyle)5);
			peremens.StartPositions.Clear();
			peremens.StartPositions.Add(Strings.LCase(peremens.trans("Заданная координатами")), (object)(FormStartPosition)0);
			peremens.StartPositions.Add(Strings.LCase(peremens.trans("По центру экрана")), (object)(FormStartPosition)1);
			peremens.StartPositions.Add(Strings.LCase(peremens.trans("Размер по умолчанию")), (object)(FormStartPosition)3);
			peremens.StartPositions.Add(Strings.LCase(peremens.trans("Расположение по умолчанию")), (object)(FormStartPosition)2);
			peremens.WindowStates.Clear();
			peremens.WindowStates.Add(Strings.LCase(peremens.trans("Нормальный")), (object)(FormWindowState)0);
			peremens.WindowStates.Add(Strings.LCase(peremens.trans("Свернуто")), (object)(FormWindowState)1);
			peremens.WindowStates.Add(Strings.LCase(peremens.trans("Развернуто")), (object)(FormWindowState)2);
			peremens.Alignments.Clear();
			peremens.Alignments.Add(Strings.LCase(peremens.trans("Сверху")), (object)(TabAlignment)0);
			peremens.Alignments.Add(Strings.LCase(peremens.trans("Снизу")), (object)(TabAlignment)1);
			peremens.Alignments.Add(Strings.LCase(peremens.trans("Слева")), (object)(TabAlignment)2);
			peremens.Alignments.Add(Strings.LCase(peremens.trans("Справа")), (object)(TabAlignment)3);
			peremens.CellBorderStyles.Clear();
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Никакой")), (object)(DataGridViewCellBorderStyle)4);
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Выпуклый")), (object)(DataGridViewCellBorderStyle)2);
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Выпуклый вертикальный")), (object)(DataGridViewCellBorderStyle)6);
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Выпуклый горизонтальный")), (object)(DataGridViewCellBorderStyle)9);
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Обычный")), (object)(DataGridViewCellBorderStyle)1);
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Обычный вертикальный")), (object)(DataGridViewCellBorderStyle)5);
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Обычный горизонтальный")), (object)(DataGridViewCellBorderStyle)8);
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Вогнутый")), (object)(DataGridViewCellBorderStyle)3);
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Вогнутый вертикальный")), (object)(DataGridViewCellBorderStyle)7);
			peremens.CellBorderStyles.Add(Strings.LCase(peremens.trans("Вогнутый горизонтальный")), (object)(DataGridViewCellBorderStyle)10);
			peremens.EditModes.Clear();
			peremens.EditModes.Add(Strings.LCase(peremens.trans("Нет")), (object)(DataGridViewEditMode)4);
			peremens.EditModes.Add(Strings.LCase(peremens.trans("При получении фокуса")), (object)(DataGridViewEditMode)0);
			peremens.EditModes.Add(Strings.LCase(peremens.trans("По клавише F2")), (object)(DataGridViewEditMode)3);
			peremens.EditModes.Add(Strings.LCase(peremens.trans("Обычный")), (object)(DataGridViewEditMode)1);
			peremens.EditModes.Add(Strings.LCase(peremens.trans("Обычный и F2")), (object)(DataGridViewEditMode)2);
			peremens.SelectionModes.Clear();
			peremens.SelectionModes.Add(Strings.LCase(peremens.trans("Ячейки")), (object)(DataGridViewSelectionMode)0);
			peremens.SelectionModes.Add(Strings.LCase(peremens.trans("Строки")), (object)(DataGridViewSelectionMode)1);
			peremens.SelectionModes.Add(Strings.LCase(peremens.trans("Ячейки и строки")), (object)(DataGridViewSelectionMode)3);
			peremens.Filters.Clear();
			peremens.Filters.Add(Strings.LCase(peremens.trans("Вся таблица")), (object)(DataGridViewElementStates)0);
			peremens.Filters.Add(Strings.LCase(peremens.trans("Отображаемое на экране")), (object)(DataGridViewElementStates)1);
			peremens.Filters.Add(Strings.LCase(peremens.trans("Выделенные стоки")), (object)(DataGridViewElementStates)32);
			peremens.LinkBehaviors.Clear();
			peremens.LinkBehaviors.Add(Strings.LCase(peremens.trans("По умолчанию")), (object)(LinkBehavior)0);
			peremens.LinkBehaviors.Add(Strings.LCase(peremens.trans("Всегда")), (object)(LinkBehavior)1);
			peremens.LinkBehaviors.Add(Strings.LCase(peremens.trans("При наведении")), (object)(LinkBehavior)2);
			peremens.LinkBehaviors.Add(Strings.LCase(peremens.trans("Никогда")), (object)(LinkBehavior)3);
			peremens.MsgStyleButtons.Clear();
			peremens.MsgStyleButtons.Add(Strings.LCase(peremens.trans("Прервать Поворить Пропустить")), (object)(MsgBoxStyle)2);
			peremens.MsgStyleButtons.Add(Strings.LCase(peremens.trans("Ок Справка")), (object)(MsgBoxStyle)16384);
			peremens.MsgStyleButtons.Add(Strings.LCase(peremens.trans("Ок Отмена")), (object)(MsgBoxStyle)1);
			peremens.MsgStyleButtons.Add(Strings.LCase(peremens.trans("Ок")), (object)(MsgBoxStyle)0);
			peremens.MsgStyleButtons.Add(Strings.LCase(peremens.trans("Повторить Отмена")), (object)(MsgBoxStyle)5);
			peremens.MsgStyleButtons.Add(Strings.LCase(peremens.trans("Да Нет")), (object)(MsgBoxStyle)4);
			peremens.MsgStyleButtons.Add(Strings.LCase(peremens.trans("Да Нет Отмена")), (object)(MsgBoxStyle)3);
			peremens.MsgStyleTypes.Clear();
			peremens.MsgStyleTypes.Add(Strings.LCase(peremens.trans("Обычный")), 0);
			peremens.MsgStyleTypes.Add(Strings.LCase(peremens.trans("Ошибка")), (object)(MsgBoxStyle)16);
			peremens.MsgStyleTypes.Add(Strings.LCase(peremens.trans("Внимание")), (object)(MsgBoxStyle)48);
			peremens.MsgStyleTypes.Add(Strings.LCase(peremens.trans("Информационное")), (object)(MsgBoxStyle)64);
			peremens.MsgStyleTypes.Add(Strings.LCase(peremens.trans("Вопросительное")), (object)(MsgBoxStyle)32);
			peremens.BdTypes.Clear();
			peremens.BdTypes.Add(Strings.LCase("Access"), "Access");
			peremens.BdTypes.Add(Strings.LCase("Excel"), "Excel");
			peremens.DateFormats.Clear();
			peremens.DateFormats.Add(Strings.LCase(peremens.trans("Длинная дата")), (object)(DateTimePickerFormat)1);
			peremens.DateFormats.Add(Strings.LCase(peremens.trans("Короткая дата")), (object)(DateTimePickerFormat)2);
			peremens.DateFormats.Add(Strings.LCase(peremens.trans("Время")), (object)(DateTimePickerFormat)4);
			peremens.DateFormats.Add(Strings.LCase(peremens.trans("По выбору")), (object)(DateTimePickerFormat)8);
			peremens.TickStyles.Clear();
			peremens.TickStyles.Add(Strings.LCase(peremens.trans("Верхний")), (object)(TickStyle)1);
			peremens.TickStyles.Add(Strings.LCase(peremens.trans("Нижний")), (object)(TickStyle)2);
			peremens.TickStyles.Add(Strings.LCase(peremens.trans("Средний")), (object)(TickStyle)3);
			peremens.TickStyles.Add(Strings.LCase(peremens.trans("Никакой")), (object)(TickStyle)0);
			peremens.FileEncodings.Clear();
			peremens.FileEncodings.Add(Strings.LCase(peremens.trans("По умолчанию")), Encoding.Default);
			peremens.FileEncodings.Add(Strings.LCase("ASCII"), Encoding.ASCII);
			peremens.FileEncodings.Add(Strings.LCase("BigEndian"), Encoding.BigEndianUnicode);
			peremens.FileEncodings.Add(Strings.LCase(peremens.trans("Юникод")), Encoding.Unicode);
			peremens.FileEncodings.Add(Strings.LCase(peremens.trans("Юникод") + "32"), Encoding.UTF32);
			peremens.FileEncodings.Add(Strings.LCase(peremens.trans("Юникод") + "7"), Encoding.UTF7);
			peremens.FileEncodings.Add(Strings.LCase(peremens.trans("Юникод") + "8"), Encoding.UTF8);
			peremens.FileEncodings.Add("\"DOS-866\"", Encoding.GetEncoding(866));
			EncodingInfo[] encodings = Encoding.GetEncodings();
			int num4 = encodings.Length - 1;
			for (int i = 0; i <= num4; i++)
			{
				if (!peremens.FileEncodings.ContainsKey("\"" + encodings[i].Name + "\""))
				{
					peremens.FileEncodings.Add("\"" + encodings[i].Name + "\"", encodings[i].GetEncoding());
				}
			}
			peremens.SizeModes.Clear();
			peremens.SizeModes.Add(Strings.LCase(peremens.trans("По умолчанию")), (object)(PictureBoxSizeMode)0);
			peremens.SizeModes.Add(Strings.LCase(peremens.trans("Растянутый")), (object)(PictureBoxSizeMode)1);
			peremens.SizeModes.Add(Strings.LCase(peremens.trans("Авторазмер")), (object)(PictureBoxSizeMode)2);
			peremens.SizeModes.Add(Strings.LCase(peremens.trans("По центру")), (object)(PictureBoxSizeMode)3);
			peremens.SizeModes.Add(Strings.LCase(peremens.trans("Масштабированный")), (object)(PictureBoxSizeMode)4);
			peremens.InputTypes.Clear();
			peremens.InputTypes.Add(Strings.LCase(peremens.trans("Все")), peremens.trans("Все"));
			peremens.InputTypes.Add(Strings.LCase(peremens.trans("Только цифры")), peremens.trans("Только цифры"));
			peremens.InputTypes.Add(Strings.LCase(peremens.trans("Только буквы")), peremens.trans("Только буквы"));
			peremens.InputTypes.Add(Strings.LCase(peremens.trans("Только латинские буквы")), peremens.trans("Только латинские буквы"));
			peremens.InputTypes.Add(Strings.LCase(peremens.trans("Только буквы и цифры")), peremens.trans("Только буквы и цифры"));
			peremens.InputTypes.Add(Strings.LCase(peremens.trans("Только латинские буквы и цифры")), peremens.trans("Только латинские буквы и цифры"));
			peremens.ClientServStates.Clear();
			peremens.ClientServStates.Add(Strings.LCase(peremens.trans("Закрыт")), 0);
			peremens.ClientServStates.Add(Strings.LCase(peremens.trans("Прослушивается")), 1);
			peremens.ClientServStates.Add(Strings.LCase(peremens.trans("Вычисляется хост")), 2);
			peremens.ClientServStates.Add(Strings.LCase(peremens.trans("Вычислился хост")), 3);
			peremens.ClientServStates.Add(Strings.LCase(peremens.trans("Соединение")), 4);
			peremens.ClientServStates.Add(Strings.LCase(peremens.trans("Соединился")), 5);
			peremens.ClientServStates.Add(Strings.LCase(peremens.trans("Закрытие")), 6);
			peremens.ClientServerTypes.Clear();
			peremens.ClientServerTypes.Add(Strings.LCase(peremens.trans("Клиент")), peremens.trans("Клиент"));
			peremens.ClientServerTypes.Add(Strings.LCase(peremens.trans("Сервер")), peremens.trans("Сервер"));
			peremens.ContentTypes.Clear();
			peremens.ContentTypes.Add("\"*/*\"", "\"*/*\"");
			peremens.ContentTypes.Add("\"application/x-www-form-urlencoded\"", "\"application/x-www-form-urlencoded\"");
			peremens.ContentTypes.Add("\"text/html\"", "\"text/html\"");
			peremens.ContentTypes.Add("\"text/plain\"", "\"text/plain\"");
			peremens.ContentTypes.Add("\"text/x-server-parsed-html\"", "\"text/x-server-parsed-html\"");
			peremens.ContentTypes.Add("\"text/css\"", "\"text/css\"");
			peremens.ContentTypes.Add("\"multipart/mixed\"", "\"multipart/mixed\"");
			peremens.ContentTypes.Add("\"multipart/alternative\"", "\"multipart/alternative\"");
			peremens.ContentTypes.Add("\"multipart/x-mixed-replace\"", "\"multipart/x-mixed-replace\"");
			peremens.ContentTypes.Add("\"multipart/form-data\"", "\"multipart/form-data\"");
			peremens.ContentTypes.Add("\"image/gif\"", "\"image/gif\"");
			peremens.ContentTypes.Add("\"image/jpeg\"", "\"image/jpeg\"");
			peremens.ContentTypes.Add("\"image/bmp\"", "\"image/bmp\"");
			peremens.ContentTypes.Add("\"audio/wav\"", "\"audio/wav\"");
			peremens.ContentTypes.Add("\"audio/midi\"", "\"audio/midi\"");
			peremens.ContentTypes.Add("\"audio/mpeg\"", "\"audio/mpeg\"");
			peremens.ContentTypes.Add("\"audio/x-wav\"", "\"audio/x-wav\"");
			peremens.ContentTypes.Add("\"video/avi\"", "\"video/avi\"");
			peremens.ContentTypes.Add("\"video/mpeg\"", "\"video/mpeg\"");
			peremens.ContentTypes.Add("\"application/msword\"", "\"application/msword\"");
			peremens.ContentTypes.Add("\"application/pdf\"", "\"application/pdf\"");
			peremens.ContentTypes.Add("\"application/rtf\"", "\"application/rtf\"");
			peremens.ContentTypes.Add("\"application/zip\"", "\"application/zip\"");
			peremens.ContentTypes.Add("\"application/x-shockwave-flash\"", "\"application/x-shockwave-flash\"");
			peremens.HttpMethods.Clear();
			peremens.HttpMethods.Add("GET", "\"GET\"");
			peremens.HttpMethods.Add("POST", "\"POST\"");
			peremens.StylesProgress.Clear();
			peremens.StylesProgress.Add(Strings.LCase(peremens.trans("Блоки")), (object)(ProgressBarStyle)0);
			peremens.StylesProgress.Add(Strings.LCase(peremens.trans("Непрерывность")), (object)(ProgressBarStyle)1);
			peremens.StylesProgress.Add(Strings.LCase(peremens.trans("Анимация")), (object)(ProgressBarStyle)2);
		}
	}

	public static void CreateHelpWords()
	{
		SetReadOnlys();
		checked
		{
			peremens.HWAnchors = new string[peremens.Anchors.Count - 1 + 1];
			peremens.Anchors.Keys.CopyTo(peremens.HWAnchors, 0);
			peremens.HWbkImStyles = new string[peremens.bkImStyles.Count - 1 + 1];
			peremens.bkImStyles.Keys.CopyTo(peremens.HWbkImStyles, 0);
			peremens.HWCursori = new string[peremens.Cursori.Count - 1 + 1];
			peremens.Cursori.Keys.CopyTo(peremens.HWCursori, 0);
			peremens.HWDocks = new string[peremens.Docks.Count - 1 + 1];
			peremens.Docks.Keys.CopyTo(peremens.HWDocks, 0);
			peremens.HWFlatStyles = new string[peremens.FlatStyles.Count - 1 + 1];
			peremens.FlatStyles.Keys.CopyTo(peremens.HWFlatStyles, 0);
			peremens.HWKeys = new string[peremens.Keyz.Count - 1 + 1];
			peremens.Keyz.Keys.CopyTo(peremens.HWKeys, 0);
			peremens.HWFonts = new string[peremens.Fonts.Count - 1 + 1];
			peremens.Fonts.Keys.CopyTo(peremens.HWFonts, 0);
			peremens.HWAligns = new string[peremens.Aligns.Count - 1 + 1];
			peremens.Aligns.Keys.CopyTo(peremens.HWAligns, 0);
			peremens.HWTextImages = new string[peremens.TextImages.Count - 1 + 1];
			peremens.TextImages.Keys.CopyTo(peremens.HWTextImages, 0);
			peremens.HWBorderStyles = new string[peremens.BorderStyles.Count - 1 + 1];
			peremens.BorderStyles.Keys.CopyTo(peremens.HWBorderStyles, 0);
			peremens.HWFixedPanels = new string[peremens.FixedPanels.Count - 1 + 1];
			peremens.FixedPanels.Keys.CopyTo(peremens.HWFixedPanels, 0);
			peremens.HWOrientations = new string[peremens.Orientations.Count - 1 + 1];
			peremens.Orientations.Keys.CopyTo(peremens.HWOrientations, 0);
			peremens.HWPapki = new string[peremens.Papks.Count - 1 + 1];
			peremens.Papks.Keys.CopyTo(peremens.HWPapki, 0);
			peremens.HWDeskStyle = new string[peremens.DeskStyle.Count - 1 + 1];
			peremens.DeskStyle.Keys.CopyTo(peremens.HWDeskStyle, 0);
			peremens.HWScrollBarz = new string[peremens.ScrollBarz.Count - 1 + 1];
			peremens.ScrollBarz.Keys.CopyTo(peremens.HWScrollBarz, 0);
			peremens.HWCols = new string[peremens.Colors.GetKeyList().Count - 1 + 1];
			peremens.Colors.GetKeyList().CopyTo(peremens.HWCols, 0);
			peremens.HWTypeRegistry = new string[peremens.TypeRegistry.GetKeyList().Count - 1 + 1];
			peremens.TypeRegistry.GetKeyList().CopyTo(peremens.HWTypeRegistry, 0);
			peremens.HWTextPositions = new string[peremens.TextPositions.GetKeyList().Count - 1 + 1];
			peremens.TextPositions.GetKeyList().CopyTo(peremens.HWTextPositions, 0);
			peremens.HWDisplayStyles = new string[peremens.DisplayStyles.GetKeyList().Count - 1 + 1];
			peremens.DisplayStyles.GetKeyList().CopyTo(peremens.HWDisplayStyles, 0);
			peremens.HWTextDirections = new string[peremens.TextDirections.GetKeyList().Count - 1 + 1];
			peremens.TextDirections.GetKeyList().CopyTo(peremens.HWTextDirections, 0);
			peremens.HWReadyStates = new string[peremens.ReadyStates.GetKeyList().Count - 1 + 1];
			peremens.ReadyStates.GetKeyList().CopyTo(peremens.HWReadyStates, 0);
			peremens.HWDocumentEncodings = new string[peremens.DocumentEncodings.GetKeyList().Count - 1 + 1];
			peremens.DocumentEncodings.GetKeyList().CopyTo(peremens.HWDocumentEncodings, 0);
			peremens.HWRefreshs = new string[peremens.Refreshs.GetKeyList().Count - 1 + 1];
			peremens.Refreshs.GetKeyList().CopyTo(peremens.HWRefreshs, 0);
			peremens.HWFormBorderStyles = new string[peremens.FormBorderStyles.GetKeyList().Count - 1 + 1];
			peremens.FormBorderStyles.GetKeyList().CopyTo(peremens.HWFormBorderStyles, 0);
			peremens.HWStartPositions = new string[peremens.StartPositions.GetKeyList().Count - 1 + 1];
			peremens.StartPositions.GetKeyList().CopyTo(peremens.HWStartPositions, 0);
			peremens.HWWindowStates = new string[peremens.WindowStates.GetKeyList().Count - 1 + 1];
			peremens.WindowStates.GetKeyList().CopyTo(peremens.HWWindowStates, 0);
			peremens.HWAlignments = new string[peremens.Alignments.GetKeyList().Count - 1 + 1];
			peremens.Alignments.GetKeyList().CopyTo(peremens.HWAlignments, 0);
			peremens.HWCellBorderStyles = new string[peremens.CellBorderStyles.GetKeyList().Count - 1 + 1];
			peremens.CellBorderStyles.GetKeyList().CopyTo(peremens.HWCellBorderStyles, 0);
			peremens.HWSelectionModes = new string[peremens.SelectionModes.GetKeyList().Count - 1 + 1];
			peremens.SelectionModes.GetKeyList().CopyTo(peremens.HWSelectionModes, 0);
			peremens.HWEditModes = new string[peremens.EditModes.GetKeyList().Count - 1 + 1];
			peremens.EditModes.GetKeyList().CopyTo(peremens.HWEditModes, 0);
			peremens.HWFilters = new string[peremens.Filters.GetKeyList().Count - 1 + 1];
			peremens.Filters.GetKeyList().CopyTo(peremens.HWFilters, 0);
			peremens.HWLinkBehaviors = new string[peremens.LinkBehaviors.GetKeyList().Count - 1 + 1];
			peremens.LinkBehaviors.GetKeyList().CopyTo(peremens.HWLinkBehaviors, 0);
			peremens.HWMsgStyleButtons = new string[peremens.MsgStyleButtons.GetKeyList().Count - 1 + 1];
			peremens.MsgStyleButtons.GetKeyList().CopyTo(peremens.HWMsgStyleButtons, 0);
			peremens.HWMsgStyleTypes = new string[peremens.MsgStyleTypes.GetKeyList().Count - 1 + 1];
			peremens.MsgStyleTypes.GetKeyList().CopyTo(peremens.HWMsgStyleTypes, 0);
			peremens.HWBdTypes = new string[peremens.BdTypes.GetKeyList().Count - 1 + 1];
			peremens.BdTypes.GetKeyList().CopyTo(peremens.HWBdTypes, 0);
			peremens.HWDateFormats = new string[peremens.DateFormats.GetKeyList().Count - 1 + 1];
			peremens.DateFormats.GetKeyList().CopyTo(peremens.HWDateFormats, 0);
			peremens.HWTickStyles = new string[peremens.TickStyles.GetKeyList().Count - 1 + 1];
			peremens.TickStyles.GetKeyList().CopyTo(peremens.HWTickStyles, 0);
			peremens.HWFileEncodings = new string[peremens.FileEncodings.GetKeyList().Count - 1 + 1];
			peremens.FileEncodings.GetKeyList().CopyTo(peremens.HWFileEncodings, 0);
			peremens.HWSizeModes = new string[peremens.SizeModes.GetKeyList().Count - 1 + 1];
			peremens.SizeModes.GetKeyList().CopyTo(peremens.HWSizeModes, 0);
			peremens.HWInputTypes = new string[peremens.InputTypes.GetKeyList().Count - 1 + 1];
			peremens.InputTypes.GetKeyList().CopyTo(peremens.HWInputTypes, 0);
			peremens.HWClientServStates = new string[peremens.ClientServStates.GetKeyList().Count - 1 + 1];
			peremens.ClientServStates.GetKeyList().CopyTo(peremens.HWClientServStates, 0);
			peremens.HWClientServerTypes = new string[peremens.ClientServerTypes.GetKeyList().Count - 1 + 1];
			peremens.ClientServerTypes.GetKeyList().CopyTo(peremens.HWClientServerTypes, 0);
			peremens.HWContentTypes = new string[peremens.ContentTypes.GetKeyList().Count - 1 + 1];
			peremens.ContentTypes.GetKeyList().CopyTo(peremens.HWContentTypes, 0);
			peremens.HWHttpMethods = new string[peremens.HttpMethods.GetKeyList().Count - 1 + 1];
			peremens.HttpMethods.GetKeyList().CopyTo(peremens.HWHttpMethods, 0);
			peremens.HWStylesProgress = new string[peremens.StylesProgress.GetKeyList().Count - 1 + 1];
			peremens.StylesProgress.GetKeyList().CopyTo(peremens.HWStylesProgress, 0);
			int num = 0;
			peremens.HWDaNet = (string[])Utils.CopyArray((Array)peremens.HWDaNet, (Array)new string[1]);
			peremens.HWDaNet[0] = peremens.trans("Да");
			num = 1;
			peremens.HWDaNet = (string[])Utils.CopyArray((Array)peremens.HWDaNet, (Array)new string[2]);
			peremens.HWDaNet[1] = peremens.trans("Нет");
			num = 0;
			peremens.HWKnopkiMishi = (string[])Utils.CopyArray((Array)peremens.HWKnopkiMishi, (Array)new string[1]);
			peremens.HWKnopkiMishi[0] = peremens.trans("Левая");
			num = 1;
			peremens.HWKnopkiMishi = (string[])Utils.CopyArray((Array)peremens.HWKnopkiMishi, (Array)new string[2]);
			peremens.HWKnopkiMishi[1] = peremens.trans("Правая");
			num = 2;
			peremens.HWKnopkiMishi = (string[])Utils.CopyArray((Array)peremens.HWKnopkiMishi, (Array)new string[3]);
			peremens.HWKnopkiMishi[2] = peremens.trans("Колесико");
			num = 3;
			peremens.HWKnopkiMishi = (string[])Utils.CopyArray((Array)peremens.HWKnopkiMishi, (Array)new string[4]);
			peremens.HWKnopkiMishi[3] = peremens.trans("ДопКнопка1");
			num = 4;
			peremens.HWKnopkiMishi = (string[])Utils.CopyArray((Array)peremens.HWKnopkiMishi, (Array)new string[5]);
			peremens.HWKnopkiMishi[4] = peremens.trans("ДопКнопка2");
			num = 0;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[1]);
			peremens.HWDeskResolution[0] = "640x480";
			num = 1;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[2]);
			peremens.HWDeskResolution[1] = "800x600";
			num = 2;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[3]);
			peremens.HWDeskResolution[2] = "1024x768";
			num = 3;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[4]);
			peremens.HWDeskResolution[3] = "1152x864";
			num = 4;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[5]);
			peremens.HWDeskResolution[4] = "1280x768";
			num = 5;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[6]);
			peremens.HWDeskResolution[5] = "1280x800";
			num = 6;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[7]);
			peremens.HWDeskResolution[6] = "1280x960";
			num = 7;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[8]);
			peremens.HWDeskResolution[7] = "1280x1024";
			num = 8;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[9]);
			peremens.HWDeskResolution[8] = "1400x1050";
			num = 9;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[10]);
			peremens.HWDeskResolution[9] = "1440x900";
			num = 10;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[11]);
			peremens.HWDeskResolution[10] = "1600x900";
			num = 11;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[12]);
			peremens.HWDeskResolution[11] = "1600x1200";
			num = 12;
			peremens.HWDeskResolution = (string[])Utils.CopyArray((Array)peremens.HWDeskResolution, (Array)new string[13]);
			peremens.HWDeskResolution[12] = "1920x1080";
			num = 0;
			peremens.HWOthers = (string[])Utils.CopyArray((Array)peremens.HWOthers, (Array)new string[1]);
			peremens.HWOthers[0] = peremens.trans("Никакой");
			num = 1;
			peremens.HWOthers = (string[])Utils.CopyArray((Array)peremens.HWOthers, (Array)new string[2]);
			peremens.HWOthers[1] = peremens.trans("Да");
			num = 2;
			peremens.HWOthers = (string[])Utils.CopyArray((Array)peremens.HWOthers, (Array)new string[3]);
			peremens.HWOthers[2] = peremens.trans("Нет");
			num = 3;
			peremens.HWOthers = (string[])Utils.CopyArray((Array)peremens.HWOthers, (Array)new string[4]);
			peremens.HWOthers[3] = peremens.trans("Все");
			num = 4;
			peremens.HWOthers = (string[])Utils.CopyArray((Array)peremens.HWOthers, (Array)new string[5]);
			peremens.HWOthers[4] = peremens.trans("Символ новой строки");
			num = 0;
			object[] array = (peremens.HWCategrs2 = new object[48]
			{
				peremens.HWOthers,
				peremens.HWCols,
				peremens.HWPapki,
				peremens.HWKnopkiMishi,
				peremens.HWKeys,
				peremens.HWAnchors,
				peremens.HWbkImStyles,
				peremens.HWCursori,
				peremens.HWDocks,
				peremens.HWFlatStyles,
				peremens.HWFonts,
				peremens.HWAligns,
				peremens.HWTextImages,
				peremens.HWBorderStyles,
				peremens.HWFixedPanels,
				peremens.HWOrientations,
				peremens.HWDeskStyle,
				peremens.HWDeskResolution,
				peremens.HWTypeRegistry,
				peremens.HWTextPositions,
				peremens.HWScrollBarz,
				peremens.HWDisplayStyles,
				peremens.HWTextDirections,
				peremens.HWReadyStates,
				peremens.HWDocumentEncodings,
				peremens.HWRefreshs,
				peremens.HWFormBorderStyles,
				peremens.HWStartPositions,
				peremens.HWWindowStates,
				peremens.HWAlignments,
				peremens.HWCellBorderStyles,
				peremens.HWEditModes,
				peremens.HWSelectionModes,
				peremens.HWFilters,
				peremens.HWLinkBehaviors,
				peremens.HWMsgStyleButtons,
				peremens.HWMsgStyleTypes,
				peremens.HWBdTypes,
				peremens.HWDateFormats,
				peremens.HWTickStyles,
				peremens.HWFileEncodings,
				peremens.HWSizeModes,
				peremens.HWInputTypes,
				peremens.HWClientServStates,
				peremens.HWClientServerTypes,
				peremens.HWContentTypes,
				peremens.HWHttpMethods,
				peremens.HWStylesProgress
			});
			int num2 = array.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(array[i], (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = 0; j <= num3; j++)
				{
					peremens.AllHW = (string[])Utils.CopyArray((Array)peremens.AllHW, (Array)new string[num + 1]);
					peremens.AllHW[num] = Conversions.ToString(NewLateBinding.LateIndexGet(array[i], new object[1] { j }, (string[])null));
					num++;
				}
			}
			peremens.AllHWUp = new string[peremens.AllHW.Length - 1 + 1];
			int num4 = peremens.AllHW.Length - 1;
			for (int i = 0; i <= num4; i++)
			{
				peremens.AllHWUp[i] = Strings.UCase(peremens.AllHW[i]);
			}
			CreateHWCategrs();
			if (peremens.isDevelop & !peremens.isRUN())
			{
				CreateHWMenu();
			}
		}
	}

	public static void CreateHWCategrs()
	{
		string[] array = (peremens.HWCategrs = new string[48]
		{
			peremens.trans("Прочие"),
			peremens.trans("Цвета"),
			peremens.trans("Папки"),
			peremens.trans("Кнопки мыши"),
			peremens.trans("Клавиши"),
			peremens.trans("Привязки"),
			peremens.trans("Стиль фона"),
			peremens.trans("Курсоры"),
			peremens.trans("Растяжки"),
			peremens.trans("Стиль кнопки"),
			peremens.trans("Шрифт"),
			peremens.trans("Положения"),
			peremens.trans("Текст и рисунок"),
			peremens.trans("Фиксированная панель"),
			peremens.trans("Стиль рамки"),
			peremens.trans("Ориентация"),
			peremens.trans("Стиль рабочего стола"),
			peremens.trans("Разрешение экрана"),
			peremens.trans("Тип ключа реестра"),
			peremens.trans("Расположение текста"),
			peremens.trans("Полосы прокрутки"),
			peremens.trans("Стиль отображения"),
			peremens.trans("Направление текста"),
			peremens.trans("Статус готовности"),
			peremens.trans("Кодировка"),
			peremens.trans("Обновить страницу"),
			peremens.trans("Стиль окна"),
			peremens.trans("Стартовая позиция"),
			peremens.trans("Статус окна"),
			peremens.trans("Положение закладок"),
			peremens.trans("Стиль рамки ячейки"),
			peremens.trans("Режим редактирования"),
			peremens.trans("Режим выделения"),
			peremens.trans("Фильтры"),
			peremens.trans("Стиль подчеркивания"),
			peremens.trans("Кнопки сообщения"),
			peremens.trans("Тип сообщения"),
			peremens.trans("Тип базы данных"),
			peremens.trans("Формат даты календаря"),
			peremens.trans("Стиль бегунка"),
			peremens.trans("Кодировка текста"),
			peremens.trans("Стиль рисунка"),
			peremens.trans("Тип ввода"),
			peremens.trans("Статус клиент сервера"),
			peremens.trans("Тип клиент сервера"),
			peremens.trans("Тип содержимого"),
			peremens.trans("Метод запроса"),
			peremens.trans("Стиль загрузки")
		});
		peremens.HWCategrsSort.Clear();
		checked
		{
			if (!peremens.isHelp)
			{
				int num = peremens.HWCategrs.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					peremens.HWCategrsSort.Add(peremens.HWCategrs[i], RuntimeHelpers.GetObjectValue(peremens.HWCategrs2[i]));
				}
			}
		}
	}

	public static void CreateHWMenu()
	{
		NewLateBinding.LateCall(peremens2.MainForm, (Type)null, "CreateHWMenu", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public static void CreateArrays()
	{
		string[] array = (peremens.DopFuns = new string[19]
		{
			peremens.trans("Нет"),
			peremens.trans("Корень"),
			peremens.trans("Корень3"),
			peremens.trans("Квадрат"),
			peremens.trans("Модуль"),
			peremens.trans("Синус"),
			peremens.trans("Косинус"),
			peremens.trans("Тангенс"),
			peremens.trans("АркСинус"),
			peremens.trans("АркКосинус"),
			peremens.trans("АркТангенс"),
			peremens.trans("Экспонента"),
			peremens.trans("Логарифм"),
			peremens.trans("Логарифм10"),
			peremens.trans("Округлить"),
			peremens.trans("Округлить денежное"),
			peremens.trans("Сменить знак (+/-)"),
			peremens.trans("Инвертировать (Да/Нет)"),
			peremens.trans("Случайное число (от 1 до введенного)")
		});
		checked
		{
			peremens.DopFunsSimple = new string[peremens.DopFuns.Length - 2 + 1];
			int num = peremens.DopFuns.Length - 2;
			for (int i = 0; i <= num; i++)
			{
				if (peremens.DopFuns[i + 1].IndexOf(" (") != -1)
				{
					peremens.DopFunsSimple[i] = Strings.UCase(peremens.DopFuns[i + 1].Substring(0, peremens.DopFuns[i + 1].IndexOf(" (")));
				}
				else
				{
					peremens.DopFunsSimple[i] = Strings.UCase(peremens.DopFuns[i + 1]);
				}
			}
			string[] array2 = (peremens.Operations = new string[8]
			{
				"&    (" + peremens.transInfc("Склеить строки") + ")",
				"+    (" + peremens.transInfc("Сложить") + ")",
				"-     (" + peremens.transInfc("Вычесть") + ")",
				"*    (" + peremens.transInfc("Умножить") + ")",
				"/    (" + peremens.transInfc("Разделить") + ")",
				"\\    (" + peremens.transInfc("Разделить нацело") + ")",
				"%    (" + peremens.transInfc("Остаток деления") + ")",
				"^    (" + peremens.transInfc("Возведение в степень") + ")"
			});
			peremens.opers = new string[peremens.Operations.Length - 1 + 1];
			int num2 = peremens.Operations.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				peremens.opers[i] = peremens.Operations[i];
				if (peremens.Operations[i].IndexOf(" (") != -1)
				{
					peremens.opers[i] = peremens.opers[i].Substring(0, peremens.opers[i].IndexOf(" ("));
				}
				peremens.opers[i] = Strings.Trim(peremens.opers[i]);
			}
			string[] array3 = new string[9]
			{
				"=    (" + peremens.transInfc("Если равно") + ")",
				"<=>    (" + peremens.transInfc("Равно c учетом регистра") + ")",
				"<>   (" + peremens.transInfc("Если неравно") + ")",
				">    (" + peremens.transInfc("Если больше") + ")",
				"<   (" + peremens.transInfc("Если меньше") + ")",
				">=    (" + peremens.transInfc("Больше либо равно") + ")",
				"<=   (" + peremens.transInfc("Меньше либо равно") + ")",
				peremens.trans("_И"),
				peremens.trans("_ИЛИ")
			};
			int num3 = array3.Length;
			int num4 = peremens.Operations.Length - 1;
			for (int i = 0; i <= num4; i++)
			{
				array3 = (string[])Utils.CopyArray((Array)array3, (Array)new string[num3 + 1]);
				array3[num3] = peremens.Operations[i];
				num3++;
			}
			peremens.Usloviya = array3;
			peremens.uslovs = new string[peremens.Usloviya.Length - 1 + 1];
			int num5 = peremens.Usloviya.Length - 1;
			for (int i = 0; i <= num5; i++)
			{
				peremens.uslovs[i] = peremens.Usloviya[i];
				if (peremens.Usloviya[i].IndexOf(" (") != -1)
				{
					peremens.uslovs[i] = peremens.uslovs[i].Substring(0, peremens.uslovs[i].IndexOf(" ("));
				}
				peremens.uslovs[i] = Strings.Trim(peremens.uslovs[i]);
			}
			peremens.ReDims(ref peremens.uslovs);
			peremens.uslovs[peremens.uslovs.Length - 1] = "And";
			peremens.ReDims(ref peremens.uslovs);
			peremens.uslovs[peremens.uslovs.Length - 1] = "Or";
			string[] array4 = new string[1] { "&" };
			string[] array5 = new string[1] { "^" };
			string[] array6 = new string[4] { "*", "/", "\\", "%" };
			string[] array7 = new string[2] { "+", "-" };
			string[] array8 = new string[9] { "=", "<=>", "<", ">", "<>", "<=", ">=", "=<", "=>" };
			string[] array9 = new string[2]
			{
				peremens.trans("_И"),
				peremens.trans("_ИЛИ")
			};
			object[] array10 = (peremens.Prioritets = new object[6] { array4, array5, array6, array7, array8, array9 });
			string[] array11 = (peremens.othersSimb = new string[6] { ",", "(", ")", "[", "]", "\"" });
			object[] array12 = new object[2]
			{
				peremens.uslovs,
				peremens.othersSimb
			};
			int num6 = array12.Length - 1;
			for (int i = 0; i <= num6; i++)
			{
				int num7 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(array12[i], (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = 0; j <= num7; j++)
				{
					peremens.allSimb = (string[])Utils.CopyArray((Array)peremens.allSimb, (Array)new string[i + j + 1]);
					peremens.allSimb[i + j] = Conversions.ToString(NewLateBinding.LateIndexGet(array12[i], new object[1] { j }, (string[])null));
				}
			}
			peremens.VBKeyWords = new string[36]
			{
				"and", "or", "not", "nothing", "is", "isnot", "dim", "as", "string", "object",
				"integer", "char", "new", "public", "private", "class", "module", "array", "function", "event",
				"handles", "redim", "preserve", "if", "then", "else", "elseif", "end", "for", "to",
				"next", "step", "while", "do", "loop", "until"
			};
			peremens.noSimb = "[^\\.";
			int num8 = peremens.allSimb.Length - 1;
			for (int i = 0; i <= num8; i++)
			{
				peremens.noSimb = peremens.noSimb + "\\" + peremens.allSimb[i];
			}
			peremens.noSimb += "]";
			num3 = 0;
			object[] array13 = new object[1] { peremens.DopFunsSimple };
			int num9 = array13.Length - 1;
			for (int i = 0; i <= num9; i++)
			{
				int num10 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(array13[i], (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = 0; j <= num10; j++)
				{
					peremens.AllFuncs = (string[])Utils.CopyArray((Array)peremens.AllFuncs, (Array)new string[num3 + 1]);
					peremens.AllFuncs[num3] = Conversions.ToString(NewLateBinding.LateIndexGet(array13[i], new object[1] { j }, (string[])null));
					num3++;
				}
			}
		}
	}

	public static void CreatePustishki(ref SortedList Pustishki)
	{
		Pustishki.Clear();
		Pustishki.Add("F", new Forms(holostoi: true));
		Pustishki.Add("B", new Button(holostoi: true));
		Pustishki.Add("P", new Panel(holostoi: true));
		Pustishki.Add("M", new Memory(holostoi: true));
		Pustishki.Add("DP", new DPanel(holostoi: true));
		Pustishki.Add("TP", new TPage(holostoi: true));
		Pustishki.Add("TPs", new TPages(holostoi: true));
		Pustishki.Add("MM", new MMenu(holostoi: true));
		Pustishki.Add("CM", new CMenu(holostoi: true));
		Pustishki.Add("MMs", new MMenus(holostoi: true));
		Pustishki.Add("Md", new Media(holostoi: true));
		Pustishki.Add("A", new Audio(holostoi: true));
		Pustishki.Add("T", new TextBoks(holostoi: true));
		Pustishki.Add("CB", new CheckBoks(holostoi: true));
		Pustishki.Add("RB", new RadioBut(holostoi: true));
		Pustishki.Add("TPl", new TPanel(holostoi: true));
		Pustishki.Add("W", new WBrowser(holostoi: true));
		Pustishki.Add("Tl", new Table(holostoi: true));
		Pustishki.Add("C", new ComboBoks(holostoi: true));
		Pustishki.Add("L", new ListBoks(holostoi: true));
		Pustishki.Add("CL", new CheckedList(holostoi: true));
		Pustishki.Add("Lb", new Label(holostoi: true));
		Pustishki.Add("LLb", new LinkLabel(holostoi: true));
		Pustishki.Add("RT", new RichText(holostoi: true));
		Pustishki.Add("CD", new ColorDialog(holostoi: true));
		Pustishki.Add("FD", new FontDialog(holostoi: true));
		Pustishki.Add("PD", new PathDialog(holostoi: true));
		Pustishki.Add("SD", new SaveDialog(holostoi: true));
		Pustishki.Add("OD", new OpenDialog(holostoi: true));
		Pustishki.Add("PrD", new PrintDialog(holostoi: true));
		Pustishki.Add("Tm", new Timer(holostoi: true));
		Pustishki.Add("Pb", new PictureBoks(holostoi: true));
		Pustishki.Add("Сr", new Calendar(holostoi: true));
		Pustishki.Add("Tb", new TrackBar(holostoi: true));
		Pustishki.Add("Tr", new Trial(holostoi: true));
		Pustishki.Add("CS", new ClientServer(holostoi: true));
		Pustishki.Add("I", new Internet(holostoi: true));
		Pustishki.Add("PrB", new ProgressBar(holostoi: true));
	}

	public static void CreateNewMyObjs(string type, ref object MyObjs, bool isRun, bool fromEng)
	{
		switch (type)
		{
		case "F":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Forms(holostoi: true, polezniy: false, isRun, fromEng)
			}, (string[])null);
			break;
		case "B":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Button(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "P":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Panel(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "M":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Memory(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "DP":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new DPanel(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "TP":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new TPage(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "TPs":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new TPages(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "MM":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new MMenu(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "CM":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new CMenu(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "MMs":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new MMenus(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "Md":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Media(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "A":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Audio(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "T":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new TextBoks(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "CB":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new CheckBoks(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "RB":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new RadioBut(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "TPl":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new TPanel(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "W":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new WBrowser(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "Tl":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Table(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "C":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new ComboBoks(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "L":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new ListBoks(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "CL":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new CheckedList(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "Lb":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Label(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "LLb":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new LinkLabel(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "RT":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new RichText(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "CD":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new ColorDialog(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "FD":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new FontDialog(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "PD":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new PathDialog(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "SD":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new SaveDialog(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "OD":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new OpenDialog(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "PrD":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new PrintDialog(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "Tm":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Timer(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "Pb":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new PictureBoks(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "Cr":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Calendar(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "Tb":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new TrackBar(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "Tr":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Trial(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "CS":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new ClientServer(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "I":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new Internet(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		case "PrB":
			NewLateBinding.LateIndexSet(MyObjs, new object[2]
			{
				Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
				new ProgressBar(holostoi: true, isRun, fromEng)
			}, (string[])null);
			break;
		}
		if (peremens.isDevelop && !isRun)
		{
			SettingDevelop(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(MyObjs, new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(MyObjs, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null)));
		}
	}

	public static void CreatePoleznie()
	{
		peremens.PoleznieObjs = null;
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[1]);
		peremens.PoleznieObjs[0] = new Poleznie(peremens.MyZnak + peremens.trans("Экран"));
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[2]);
		peremens.PoleznieObjs[1] = new Poleznie(peremens.MyZnak + peremens.trans("Файлы и папки"));
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[3]);
		peremens.PoleznieObjs[2] = new Poleznie(peremens.MyZnak + peremens.trans("Прерывания"));
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[4]);
		peremens.PoleznieObjs[3] = new Poleznie(peremens.MyZnak + peremens.trans("Система"));
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[5]);
		peremens.PoleznieObjs[4] = new Poleznie(peremens.MyZnak + peremens.trans("Реестр"));
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[6]);
		peremens.PoleznieObjs[5] = new Poleznie(peremens.MyZnak + peremens.trans("Вызвать событие"));
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[7]);
		peremens.PoleznieObjs[6] = new Poleznie(peremens.MyZnak + peremens.trans("Текст"));
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[8]);
		peremens.PoleznieObjs[7] = new Poleznie(peremens.MyZnak + peremens.trans("Показать сообщение"));
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[9]);
		peremens.PoleznieObjs[8] = new Poleznie(peremens.MyZnak + peremens.trans("Дата"));
		peremens.PoleznieObjs = (object[])Utils.CopyArray((Array)peremens.PoleznieObjs, (Array)new object[10]);
		peremens.PoleznieObjs[9] = new Poleznie(peremens.MyZnak + peremens.trans("Расширенные возможности"));
	}

	public static ArrayList ObjectsInPaths(string[] ListTypes)
	{
		ArrayList arrayList = new ArrayList();
		if (Array.IndexOf(ListTypes, "ClientServer") != -1)
		{
			arrayList.Add(" \"" + peremens.CompilPath + "ClientServer\\*.vb\"");
		}
		if (Array.IndexOf(ListTypes, "Internet") != -1)
		{
			arrayList.Add(" \"" + peremens.CompilPath + "Internet\\*.vb\"");
		}
		return arrayList;
	}

	public static void SettingDevelop(object MyObj)
	{
		if (Iz.IsI(RuntimeHelpers.GetObjectValue(MyObj)) | Iz.IsCS(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "isDevelop", new object[1] { true }, (string[])null, (Type[])null, false, true);
		}
	}

	public static double Radical(string vl)
	{
		return Math.Sqrt(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double Radical3(string vl)
	{
		return Math.Pow(Conversion.Val(vl.Replace(",", ".")), 1.0 / 3.0);
	}

	public static double Square(string vl)
	{
		return Math.Pow(Conversion.Val(vl.Replace(",", ".")), 2.0);
	}

	public static double Absolute(string vl)
	{
		return Math.Abs(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double Sine(string vl)
	{
		return Math.Sin(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double Cosine(string vl)
	{
		return Math.Cos(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double Tangent(string vl)
	{
		return Math.Tan(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double ArcSine(string vl)
	{
		return Math.Asin(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double ArcCosine(string vl)
	{
		return Math.Acos(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double ArcTangent(string vl)
	{
		return Math.Atan(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double Exhibitor(string vl)
	{
		return Math.Exp(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double Logarithm(string vl)
	{
		return Math.Log(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double Logarithm10(string vl)
	{
		return Math.Log10(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double Round(string vl)
	{
		return Math.Round(Conversion.Val(vl.Replace(",", ".")));
	}

	public static double RoundMoney(string vl)
	{
		return Math.Round(Conversion.Val(vl.Replace(",", ".")), 2);
	}

	public static double ChangeSign(string vl)
	{
		return -1.0 * Conversion.Val(vl.Replace(",", "."));
	}

	public static int RandomNumber(string vl)
	{
		return rnd.Next(1, checked((int)Math.Round(Conversion.Val(vl.Replace(",", ".")))));
	}

	public static string Invert(string vl)
	{
		if ((Operators.CompareString(Strings.Trim(vl), "1", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(vl)), Strings.UCase(Strings.Trim(peremens.trans("Да"))), false) == 0))
		{
			return "\"" + peremens.trans("Нет") + "\"";
		}
		if ((Operators.CompareString(Strings.Trim(vl), "0", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(vl)), Strings.UCase(Strings.Trim(peremens.trans("Нет"))), false) == 0))
		{
			return "\"" + peremens.trans("Да") + "\"";
		}
		return "";
	}
}
