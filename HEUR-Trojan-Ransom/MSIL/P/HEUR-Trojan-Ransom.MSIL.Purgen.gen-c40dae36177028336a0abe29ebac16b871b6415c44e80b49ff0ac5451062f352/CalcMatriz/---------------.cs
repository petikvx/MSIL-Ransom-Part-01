using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Media;

namespace CalcMatriz;

public class _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1
{
	public int 睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌;

	public int 炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎;

	public double[,] _2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ;

	public double _288C_2888_289E_288F_2890_288F_28C6_28B9_28BC_28B9_28BA_28D0_288F_28BA_2891;

	public static List<double> 䵗䵓䶇䶊䵛䶏䵻䵚䵹䶅䶅䵨䵱䵙䵬 = new List<double>();

	public static double 啑喂喖喀啳啝啍啍啞啯喀喂啱啬啾(string 濑濋濩濓濍瀀濎濓濒濻濤濑瀌濍瀄)
	{
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add(_003CModule_003E._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD(), typeof(string), 濑濋濩濓濍瀀濎濓濒濻濤濑瀌濍瀄);
		DataRow dataRow = dataTable.NewRow();
		dataTable.Rows.Add(dataRow);
		return double.Parse((string)dataRow[_003CModule_003E.蚗蚏蚔蚎蚒蚣蚕蚖蛃蛀蚿蚎蛀蚏蚿()]);
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 籧粕籤籽籧粄籪籬籸粘粛籧粥粮籧(string _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD)
	{
		if (!string.IsNullOrEmpty(_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD))
		{
			string[] array = _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
			_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(array.Length, array[0].Split(new char[1] { ' ' }).Length);
			string[] array2 = array[0].Split(new char[1] { ' ' });
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array2.Length; j++)
				{
					obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, double.Parse((!string.IsNullOrWhiteSpace(array[i].Split(new char[1] { ' ' })[j])) ? array[i].Split(new char[1] { ' ' })[j] : _003CModule_003E.ﵖﴪﴩﴷ_FD42ﵖﴤ_FD41ﵗﵔﵗﵖﵩﴬﴫ()));
				}
			}
			return obj;
		}
		return new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(0, 0);
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 _᪁_1AAD᪁_1A7B_1AAC᪃᪃᪃_1AB8_1AB0_1AAC_1AAD_1A7E᪀_1A7E(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 덬덻덹덿뎐덹덏덈덎덎덊덌덿덋덙, double _2272_2243_223C_226E_2244_2255_2241_226E_2242_2264_2270_227F_2270_2271_2243, double 킨킫킪킥킿킫탗킧키킿킥탩탙탉탗)
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(2, 2);
		obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(0, 0, _2272_2243_223C_226E_2244_2255_2241_226E_2242_2264_2270_227F_2270_2271_2243);
		obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(0, 1, 0.0);
		obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(1, 0, 0.0);
		obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(1, 1, 킨킫킪킥킿킫탗킧키킿킥탩탙탉탗);
		return _F2C8_F2BA_F2B9_F2CB_F2A1_F290_F290_F2C1_F28F_F2B9_F2C3_F28F_F28D_F290_F2A4(obj, 덬덻덹덿뎐덹덏덈덎덎덊덌덿덋덙);
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 곪곪괨곫괘괩곪곫곬괙곤곤곤곤괕(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 뵗뵆뵃봒봎봩뵒뵃봔봵뵌뵂봎봎봩, double 撋撝撆撋撊撛撕撊撴撸撸撴撆撜擁, double ὴ_1F46ὃἵὡὲὟἶὣἱ_1F46Ἥἲ_1F5Eἴ)
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(뵗뵆뵃봒봎봩뵒뵃봔봵뵌뵂봎봎봩.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌, 뵗뵆뵃봒봎봩뵒뵃봔봵뵌뵂봎봎봩.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎);
		for (int i = 0; i < 뵗뵆뵃봒봎봩뵒뵃봔봵뵌뵂봎봎봩.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; i++)
		{
			obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(0, i, 撋撝撆撋撊撛撕撊撴撸撸撴撆撜擁);
			obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(1, i, 0.0 - ὴ_1F46ὃἵὡὲὟἶὣἱ_1F46Ἥἲ_1F5Eἴ);
		}
		return 䘴䙒䘳䘮䙰䙟䙂䙡䙅䙢䘴䘱䘯䙟䘾(obj, 뵗뵆뵃봒봎봩뵒뵃봔봵뵌뵂봎봎봩);
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 躣蹴躣蹴躣躅躓蹲蹸躧蹹躬躧躍躬(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 _F696_F697_F6A6_F668_F66B_F669_F6AC_F695_F6A5_F66B_F68C_F696_F69C_F698_F669)
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(_F696_F697_F6A6_F668_F66B_F669_F6AC_F695_F6A5_F66B_F68C_F696_F69C_F698_F669.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌, _F696_F697_F6A6_F668_F66B_F669_F6AC_F695_F6A5_F66B_F68C_F696_F69C_F698_F669.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎);
		for (int i = 0; i < _F696_F697_F6A6_F668_F66B_F669_F6AC_F695_F6A5_F66B_F68C_F696_F69C_F698_F669.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
		{
			for (int j = 0; j < _F696_F697_F6A6_F668_F66B_F669_F6AC_F695_F6A5_F66B_F68C_F696_F69C_F698_F669.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
			{
				obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, Math.Pow(-1.0, i + j) * 맓맗맮맘먈맘맛맔먇맛맰먅맗매맛(뀦끦뀠끀끕끧끑뀣끖끟뀠끕뀡뀧뀩(i, j, _F696_F697_F6A6_F668_F66B_F669_F6AC_F695_F6A5_F66B_F68C_F696_F69C_F698_F669)));
			}
		}
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj2 = obj.ᕮᕓᕏᕎᕒᕬᕋᕵᖀᖀᕌᕐᕋᖀᖀ();
		return ᐨᑚᑢᑈᑝᑂᑀᑛᐮᑜᑛᑛᑀᐰᐫ(맓맗맮맘먈맘맛맔먇맛맰먅맗매맛(_F696_F697_F6A6_F668_F66B_F669_F6AC_F695_F6A5_F66B_F68C_F696_F69C_F698_F669), obj2, _003CModule_003E.쉛숓숚수숒숓숒숒쉙숒숗숕숗숙숗());
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 䛽䜱䛾䜶䜺䜅䜃䜄䜯䜂䜳䜮䜆䛽䜿(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD, double 䌆䍀䍅䌆䌈䌥䌶䌃䌳䍂䌲䌶䌆䌵䌶)
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(2, 2);
		obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(0, 0, Math.Round(Math.Cos(䌆䍀䍅䌆䌈䌥䌶䌃䌳䍂䌲䌶䌆䌵䌶 * (Math.PI / 180.0)), 2));
		obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(0, 1, Math.Round(0.0 - Math.Sin(䌆䍀䍅䌆䌈䌥䌶䌃䌳䍂䌲䌶䌆䌵䌶 * (Math.PI / 180.0)), 2));
		obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(1, 0, Math.Round(Math.Sin(䌆䍀䍅䌆䌈䌥䌶䌃䌳䍂䌲䌶䌆䌵䌶 * (Math.PI / 180.0)), 2));
		obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(1, 1, Math.Round(Math.Cos(䌆䍀䍅䌆䌈䌥䌶䌃䌳䍂䌲䌶䌆䌵䌶 * (Math.PI / 180.0)), 2));
		return _F2C8_F2BA_F2B9_F2CB_F2A1_F290_F290_F2C1_F28F_F2B9_F2C3_F28F_F28D_F290_F2A4(obj, _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD);
	}

	public _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 阮阔陆阭阑阐际阑阐阑附陁阗阐阩(int _E9F7_EA21_EA0C_EA2C_EA0E_EA14_EA03_EA14_EA06_EA0F_EA38_EA19_E9F2_EA25_E9F7, int 㗴㘠㗴㘲㘒㗬㗯㗬㗫㘊㘡㗱㗳㗯㗰)
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌, 炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎);
		for (int i = 0; i < 睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
		{
			for (int j = 0; j < 炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
			{
				if (i == _E9F7_EA21_EA0C_EA2C_EA0E_EA14_EA03_EA14_EA06_EA0F_EA38_EA19_E9F2_EA25_E9F7)
				{
					obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(_E9F7_EA21_EA0C_EA2C_EA0E_EA14_EA03_EA14_EA06_EA0F_EA38_EA19_E9F2_EA25_E9F7, j, _F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(㗴㘠㗴㘲㘒㗬㗯㗬㗫㘊㘡㗱㗳㗯㗰, j));
				}
				else if (i == 㗴㘠㗴㘲㘒㗬㗯㗬㗫㘊㘡㗱㗳㗯㗰)
				{
					obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(㗴㘠㗴㘲㘒㗬㗯㗬㗫㘊㘡㗱㗳㗯㗰, j, _F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(_E9F7_EA21_EA0C_EA2C_EA0E_EA14_EA03_EA14_EA06_EA0F_EA38_EA19_E9F2_EA25_E9F7, j));
				}
				else
				{
					obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, _F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, j));
				}
			}
		}
		return obj;
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 溍湉湻溎湐湰湏湊湺溈湦湻湽湐湾(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 ᚇᙬᙓᙖᙓᙔ_169Cᙹᚈᚉᙔᙰᙔᚅᙤ, double _E229_E21F_E23E_E20B_E23D_E22A_E1FD_E1F9_E23B_E218_E200_E229_E237_E214_E22D)
	{
		for (int i = 0; i < ᚇᙬᙓᙖᙓᙔ_169Cᙹᚈᚉᙔᙰᙔᚅᙤ.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; i++)
		{
			ᚇᙬᙓᙖᙓᙔ_169Cᙹᚈᚉᙔᙰᙔᚅᙤ.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(0, i, ᚇᙬᙓᙖᙓᙔ_169Cᙹᚈᚉᙔᙰᙔᚅᙤ._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(0, i) * _E229_E21F_E23E_E20B_E23D_E22A_E1FD_E1F9_E23B_E218_E200_E229_E237_E214_E22D);
		}
		return ᚇᙬᙓᙖᙓᙔ_169Cᙹᚈᚉᙔᙰᙔᚅᙤ;
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 뀦끦뀠끀끕끧끑뀣끖끟뀠끕뀡뀧뀩(int 먠멋먝멐먝먝멤멍멍먹먣먡먷먛먬, int ɵɲʢʟɭʣʬʢɭʢɰʞʕɶʣ, _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 䧝䧪䦮䧫䦪䦯䧜䧙䧍䦬䦸䧚䧚䧚䦬)
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(䧝䧪䦮䧫䦪䦯䧜䧙䧍䦬䦸䧚䧚䧚䦬.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 - 1, 䧝䧪䦮䧫䦪䦯䧜䧙䧍䦬䦸䧚䧚䧚䦬.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎 - 1);
		int num = 0;
		for (int i = 0; i < 䧝䧪䦮䧫䦪䦯䧜䧙䧍䦬䦸䧚䧚䧚䦬.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
		{
			num = 0;
			for (int j = 0; j < 䧝䧪䦮䧫䦪䦯䧜䧙䧍䦬䦸䧚䧚䧚䦬.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
			{
				if (j == ɵɲʢʟɭʣʬʢɭʢɰʞʕɶʣ || i == 먠멋먝멐먝먝멤멍멍먹먣먡먷먛먬)
				{
					num++;
				}
				else if (j > ɵɲʢʟɭʣʬʢɭʢɰʞʕɶʣ)
				{
					if (i > 먠멋먝멐먝먝멤멍멍먹먣먡먷먛먬)
					{
						obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i - 1, j - 1, 䧝䧪䦮䧫䦪䦯䧜䧙䧍䦬䦸䧚䧚䧚䦬._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, j));
					}
					if (i < 먠멋먝멐먝먝멤멍멍먹먣먡먷먛먬)
					{
						obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j - 1, 䧝䧪䦮䧫䦪䦯䧜䧙䧍䦬䦸䧚䧚䧚䦬._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, j));
					}
				}
				else if (j < ɵɲʢʟɭʣʬʢɭʢɰʞʕɶʣ)
				{
					if (i > 먠멋먝멐먝먝멤멍멍먹먣먡먷먛먬)
					{
						obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i - 1, j, 䧝䧪䦮䧫䦪䦯䧜䧙䧍䦬䦸䧚䧚䧚䦬._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, j));
					}
					if (i < 먠멋먝멐먝먝멤멍멍먹먣먡먷먛먬)
					{
						obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, 䧝䧪䦮䧫䦪䦯䧜䧙䧍䦬䦸䧚䧚䧚䦬._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, j));
					}
				}
			}
		}
		return obj;
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 ᐨᑚᑢᑈᑝᑂᑀᑛᐮᑜᑛᑛᑀᐰᐫ(double _EFEF_EFD0_EFEA_EFC0_EFEF_EFF5_EFEA_EFF8_EFC1_EFBA_EFBE_EFC1_EFBB_EFE2_EFED, _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 _E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0, string _3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9)
	{
		for (int i = 0; i < _E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
		{
			for (int j = 0; j < _E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
			{
				switch (횔횖홪횘황횁홤홻횘홪횓홢횫황횝._1316ጁጳጃገጀጶጁፅፆጧጴጠጁጱ(_3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9))
				{
				case 3712891560u:
					if (_3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9 == _003CModule_003E.㟉㞟㞞㟋㞗㞚㞛㞛㞘㟐㟌㞛㞚㞲㞚())
					{
						_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, _E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j] + _EFEF_EFD0_EFEA_EFC0_EFEF_EFF5_EFEA_EFF8_EFC1_EFBA_EFBE_EFC1_EFBB_EFE2_EFED);
					}
					break;
				case 3696113941u:
					if (_3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9 == _003CModule_003E.墆墦墉墉墁墩墉墲墈墁墷墟墜壃墄())
					{
						_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, _E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j] - _EFEF_EFD0_EFEA_EFC0_EFEF_EFF5_EFEA_EFF8_EFC1_EFBA_EFBE_EFC1_EFBB_EFE2_EFED);
					}
					break;
				case 3951357313u:
					if (_3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9 == _003CModule_003E.ᓵᓺᓸᔙᓸᔧᓸᓵᓹᓳᓹᔧᓹᓺᔵ())
					{
						_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, _E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j] * _EFEF_EFD0_EFEA_EFC0_EFEF_EFF5_EFEA_EFF8_EFC1_EFBA_EFBE_EFC1_EFBB_EFE2_EFED);
					}
					break;
				case 3848448840u:
					if (_3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9 == _003CModule_003E.갸갷걊걜걥갳갶갶갶걨갷걫걕갳걧())
					{
						_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, _E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j] / _EFEF_EFD0_EFEA_EFC0_EFEF_EFF5_EFEA_EFF8_EFC1_EFBA_EFBE_EFC1_EFBB_EFE2_EFED);
					}
					break;
				case 804546073u:
					if (_3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9 == _003CModule_003E.튰틀틜튩튰틃튽틅튫튯틏틚튰튽틙())
					{
						_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, _E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j] % _EFEF_EFD0_EFEA_EFC0_EFEF_EFF5_EFEA_EFF8_EFC1_EFBA_EFBE_EFC1_EFBB_EFE2_EFED);
					}
					break;
				case 2112764879u:
					if (_3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9 == _003CModule_003E.쓆쓅씋쓆쓊쓅쓇쓷쓓쓊쓴쓖쓳쓳쓇())
					{
						_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, Math.Sqrt(_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j]));
					}
					break;
				case 1479764693u:
					if (_3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9 == _003CModule_003E._E56F_E588_E574_E575_E586_E574_E574_E571_E5A2_E584_E56D_E574_E574_E56E_E5A1())
					{
						_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, Math.Pow(_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j], _EFEF_EFD0_EFEA_EFC0_EFEF_EFF5_EFEA_EFF8_EFC1_EFBA_EFBE_EFC1_EFBB_EFE2_EFED));
					}
					break;
				case 1062293841u:
					if (_3012_300E_300D_2FFF_2FDA_2FE1_2FFD_2FFB_2FE1_2FD9_2FDA_300B_2FDC_2FEE_2FD9 == _003CModule_003E._E9E3_E9B1_E9BF_E9B2_E9AE_E9F4_E9D5_E9B5_E9F6_E9B0_E9C0_E9B5_E9E1_E9D3_E9AE())
					{
						_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, Math.Log10(_E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j]));
					}
					break;
				}
			}
		}
		return _E4F1_E4ED_E4F3_E4EC_E4BF_E4E3_E4BB_E4FE_E4BC_E505_E4C2_E4EF_E4F4_E4EC_E4E0;
	}

	public double 겲겲곀곡겷곭고곡곯곥곣곡겸곤곋(int 履臨醴流瑩鈴律醴例離領瑩履泥羚, int 窦窟窞竢窧窥竦窣窟窥窧窱竓竂竚, bool 硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧)
	{
		double num = _2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[履臨醴流瑩鈴律醴例離領瑩履泥羚, 窦窟窞竢窧窥竦窣窟窥窧窱竓竂竚];
		履臨醴流瑩鈴律醴例離領瑩履泥羚++;
		窦窟窞竢窧窥竦窣窟窥窧窱竓竂竚 = (硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧 ? (窦窟窞竢窧窥竦窣窟窥窧窱竓竂竚 + 1) : (窦窟窞竢窧窥竦窣窟窥窧窱竓竂竚 - 1));
		for (int i = 0; i < 睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 - 1; i++)
		{
			num *= _2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[履臨醴流瑩鈴律醴例離領瑩履泥羚, 窦窟窞竢窧窥竦窣窟窥窧窱竓竂竚];
			履臨醴流瑩鈴律醴例離領瑩履泥羚++;
			窦窟窞竢窧窥竦窣窟窥窧窱竓竂竚 = (硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧 ? (窦窟窞竢窧窥竦窣窟窥窧窱竓竂竚 + 1) : (窦窟窞竢窧窥竦窣窟窥窧窱竓竂竚 - 1));
		}
		return num;
	}

	public double _F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(int ᒨᒜᓈᒛᒔᓉᓖᓅᒜᒓᒺᓈᒚᓄᒬ, int 觮觖觙覷覼覾覶覶覽觞覾覸觪覾觴)
	{
		return _2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[ᒨᒜᓈᒛᒔᓉᓖᓅᒜᒓᒺᓈᒚᓄᒬ, 觮觖觙覷覼覾覶覶覽觞覾覸觪覾觴];
	}

	public _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 蝫蝰蜿蝮蝱蜼蜻螁蝙蝫蜺蜽蝂蝫蝯()
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌, 炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎 + 2);
		for (int i = 0; i < 睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
		{
			for (int j = 0; j < 炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
			{
				obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, _2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j]);
			}
		}
		for (int k = 0; k < 睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; k++)
		{
			for (int l = 0; l < 2; l++)
			{
				obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(k, l + 3, _2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[k, l]);
			}
		}
		return obj;
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 䝠䝱䜮䝠䝠䜰䝒䜴䝇䝠䝬䜳䝭䝟䜭(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 _ED8F_ED5E_ED64_ED85_ED8D_ED72_ED7B_ED91_ED8F_ED62_ED62_ED8F_ED91_ED5D_ED8D)
	{
		for (int i = 1; i < _ED8F_ED5E_ED64_ED85_ED8D_ED72_ED7B_ED91_ED8F_ED62_ED62_ED8F_ED91_ED5D_ED8D.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
		{
			for (int j = 1; j < _ED8F_ED5E_ED64_ED85_ED8D_ED72_ED7B_ED91_ED8F_ED62_ED62_ED8F_ED91_ED5D_ED8D.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
			{
				_ED8F_ED5E_ED64_ED85_ED8D_ED72_ED7B_ED91_ED8F_ED62_ED62_ED8F_ED91_ED5D_ED8D.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, _ED8F_ED5E_ED64_ED85_ED8D_ED72_ED7B_ED91_ED8F_ED62_ED62_ED8F_ED91_ED5D_ED8D._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, j) - _ED8F_ED5E_ED64_ED85_ED8D_ED72_ED7B_ED91_ED8F_ED62_ED62_ED8F_ED91_ED5D_ED8D._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[0, j] * _ED8F_ED5E_ED64_ED85_ED8D_ED72_ED7B_ED91_ED8F_ED62_ED62_ED8F_ED91_ED5D_ED8D._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, 0]);
			}
		}
		return 뀦끦뀠끀끕끧끑뀣끖끟뀠끕뀡뀧뀩(0, 0, _ED8F_ED5E_ED64_ED85_ED8D_ED72_ED7B_ED91_ED8F_ED62_ED62_ED8F_ED91_ED5D_ED8D);
	}

	public static double 맓맗맮맘먈맘맛맔먇맛맰먅맗매맛(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷)
	{
		double num = 0.0;
		if (鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 == 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎)
		{
			if (鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 == 1)
			{
				return 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(0, 0);
			}
			if (鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 == 2)
			{
				return 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.겲겲곀곡겷곭고곡곯곥곣곡겸곤곋(0, 0, 硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧: true) - 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.겲겲곀곡겷곭고곡곯곥곣곡겸곤곋(0, 1, 硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧: false);
			}
			if (鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 == 3)
			{
				_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.蝫蝰蜿蝮蝱蜼蜻螁蝙蝫蜺蜽蝂蝫蝯();
				num = obj.겲겲곀곡겷곭고곡곯곥곣곡겸곤곋(0, 0, 硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧: true) + obj.겲겲곀곡겷곭고곡곯곥곣곡겸곤곋(0, 1, 硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧: true) + obj.겲겲곀곡겷곭고곡곯곥곣곡겸곤곋(0, 2, 硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧: true) - (obj.겲겲곀곡겷곭고곡곯곥곣곡겸곤곋(0, 2, 硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧: false) + obj.겲겲곀곡겷곭고곡곯곥곣곡겸곤곋(0, 3, 硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧: false) + obj.겲겲곀곡겷곭고곡곯곥곣곡겸곤곋(0, 4, 硶碎碩硺硹硻碷碿硸硶碾硻硽碫碧: false));
				foreach (double item in 䵗䵓䶇䶊䵛䶏䵻䵚䵹䶅䶅䵨䵱䵙䵬)
				{
					num *= item;
				}
				return Math.Round(num);
			}
			if (鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(0, 0) == 0.0)
			{
				int num2 = 0;
				for (int i = 1; i < 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
				{
					num2++;
					if (鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, 0) == 0.0)
					{
						continue;
					}
					if (鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, 0) == 1.0)
					{
						䵗䵓䶇䶊䵛䶏䵻䵚䵹䶅䶅䵨䵱䵙䵬.Add(-1.0);
						return 맓맗맮맘먈맘맛맔먇맛맰먅맗매맛(䝠䝱䜮䝠䝠䜰䝒䜴䝇䝠䝬䜳䝭䝟䜭(鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.阮阔陆阭阑阐际阑阐阑附陁阗阐阩(0, i)));
					}
					if (鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, 0) != 1.0)
					{
						䵗䵓䶇䶊䵛䶏䵻䵚䵹䶅䶅䵨䵱䵙䵬.Add(鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, 0));
						䵗䵓䶇䶊䵛䶏䵻䵚䵹䶅䶅䵨䵱䵙䵬.Add(-1.0);
						double num3 = 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, 0);
						for (int j = 0; j < 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
						{
							鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(i, j) / num3);
						}
						return 맓맗맮맘먈맘맛맔먇맛맰먅맗매맛(䝠䝱䜮䝠䝠䜰䝒䜴䝇䝠䝬䜳䝭䝟䜭(鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.阮阔陆阭阑阐际阑阐阑附陁阗阐阩(0, i)));
					}
				}
				if (num2 == 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌)
				{
					return 0.0;
				}
				return 0.0;
			}
			if (鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(0, 0) == 1.0)
			{
				return 맓맗맮맘먈맘맛맔먇맛맰먅맗매맛(䝠䝱䜮䝠䝠䜰䝒䜴䝇䝠䝬䜳䝭䝟䜭(鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷));
			}
			䵗䵓䶇䶊䵛䶏䵻䵚䵹䶅䶅䵨䵱䵙䵬.Add(鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(0, 0));
			double num4 = 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(0, 0);
			for (int k = 0; k < 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; k++)
			{
				鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(0, k, 鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(0, k) / num4);
			}
			return 맓맗맮맘먈맘맛맔먇맛맰먅맗매맛(䝠䝱䜮䝠䝠䜰䝒䜴䝇䝠䝬䜳䝭䝟䜭(鸊鷹鸁鷹鷅鷄鷷鷊鷇鷋鷸鷕鸂鷄鷷));
		}
		return double.NaN;
	}

	public string 䭲䭓䭔䭙䮚䮄䮇䮈䭻䭰䮃䭳䭙䮄䭕()
	{
		string text = _003CModule_003E._F76D_F743_F76D_F76F_F73D_F76C_F782_F740_F782_F73B_F770_F76F_F743_F73E_F77E();
		for (int i = 0; i < 睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
		{
			for (int j = 0; j < 炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
			{
				text += ((j == 炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎 - 1) ? _2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j].ToString() : (_2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j] + _003CModule_003E.碛碶碢碍碖碅碹碈碅碌碸碹碍碠碅()));
			}
			text += "\n";
		}
		return text;
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 䘴䙒䘳䘮䙰䙟䙂䙡䙅䙢䘴䘱䘯䙟䘾(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 ꦘꧏ_A9CCꦢꦖꦖꦔ_A9C5ꦑꦐꦖ_A9C2ꦗ_A9C2ꦐ, _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 _33FD㑀_33FF㐭_33FD㐯_33FF㐴_33FA_33F9_33FA_33FF_33FB㐨_33FC)
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(ꦘꧏ_A9CCꦢꦖꦖꦔ_A9C5ꦑꦐꦖ_A9C2ꦗ_A9C2ꦐ.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌, ꦘꧏ_A9CCꦢꦖꦖꦔ_A9C5ꦑꦐꦖ_A9C2ꦗ_A9C2ꦐ.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎);
		if (ꦘꧏ_A9CCꦢꦖꦖꦔ_A9C5ꦑꦐꦖ_A9C2ꦗ_A9C2ꦐ.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 == _33FD㑀_33FF㐭_33FD㐯_33FF㐴_33FA_33F9_33FA_33FF_33FB㐨_33FC.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 && ꦘꧏ_A9CCꦢꦖꦖꦔ_A9C5ꦑꦐꦖ_A9C2ꦗ_A9C2ꦐ.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎 == _33FD㑀_33FF㐭_33FD㐯_33FF㐴_33FA_33F9_33FA_33FF_33FB㐨_33FC.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎)
		{
			for (int i = 0; i < ꦘꧏ_A9CCꦢꦖꦖꦔ_A9C5ꦑꦐꦖ_A9C2ꦗ_A9C2ꦐ.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
			{
				for (int j = 0; j < ꦘꧏ_A9CCꦢꦖꦖꦔ_A9C5ꦑꦐꦖ_A9C2ꦗ_A9C2ꦐ.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
				{
					obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, ꦘꧏ_A9CCꦢꦖꦖꦔ_A9C5ꦑꦐꦖ_A9C2ꦗ_A9C2ꦐ._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j] + _33FD㑀_33FF㐭_33FD㐯_33FF㐴_33FA_33F9_33FA_33FF_33FB㐨_33FC._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j]);
				}
			}
			return obj;
		}
		return new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(0, 0);
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 ﯘ_FBB4ﮪ_FBCAﯔﮢﮣﯖﮣ_FBC4ﯛ_FBBAﯗﮪﯓ(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 貳貸貳貸賢賙貳買賌賘買貴貱賡買, _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 웄욡욛욛웜웏욠욛욣웋욞욡욞욞원)
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(貳貸貳貸賢賙貳買賌賘買貴貱賡買.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌, 貳貸貳貸賢賙貳買賌賘買貴貱賡買.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎);
		if (貳貸貳貸賢賙貳買賌賘買貴貱賡買.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 == 웄욡욛욛웜웏욠욛욣웋욞욡욞욞원.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 && 貳貸貳貸賢賙貳買賌賘買貴貱賡買.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎 == 웄욡욛욛웜웏욠욛욣웋욞욡욞욞원.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎)
		{
			for (int i = 0; i < 貳貸貳貸賢賙貳買賌賘買貴貱賡買.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
			{
				for (int j = 0; j < 貳貸貳貸賢賙貳買賌賘買貴貱賡買.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
				{
					obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, 貳貸貳貸賢賙貳買賌賘買貴貱賡買._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j] - 웄욡욛욛웜웏욠욛욣웋욞욡욞욞원._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j]);
				}
			}
			return obj;
		}
		return new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(0, 0);
	}

	public _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 ᕮᕓᕏᕎᕒᕬᕋᕵᖀᖀᕌᕐᕋᖀᖀ()
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎, 睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌);
		for (int i = 0; i < 睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
		{
			for (int j = 0; j < 炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
			{
				obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(j, i, _2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, j]);
			}
		}
		return obj;
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 _F2C8_F2BA_F2B9_F2CB_F2A1_F290_F290_F2C1_F28F_F2B9_F2C3_F28F_F28D_F290_F2A4(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 痭痐瘌痲痕痗瘃瘅瘎瘀痗痔痖瘃痯, _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 镧閊镞镊閂閇閑镻镍閅镟长镌镽镱)
	{
		if (痭痐瘌痲痕痗瘃瘅瘎瘀痗痔痖瘃痯.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎 == 镧閊镞镊閂閇閑镻镍閅镟长镌镽镱.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌)
		{
			_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(痭痐瘌痲痕痗瘃瘅瘎瘀痗痔痖瘃痯.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌, 镧閊镞镊閂閇閑镻镍閅镟长镌镽镱.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎);
			double num = 0.0;
			for (int i = 0; i < 痭痐瘌痲痕痗瘃瘅瘎瘀痗痔痖瘃痯.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌; i++)
			{
				for (int j = 0; j < 镧閊镞镊閂閇閑镻镍閅镟长镌镽镱.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; j++)
				{
					for (int k = 0; k < 痭痐瘌痲痕痗瘃瘅瘎瘀痗痔痖瘃痯.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; k++)
					{
						num += 痭痐瘌痲痕痗瘃瘅瘎瘀痗痔痖瘃痯._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[i, k] * 镧閊镞镊閂閇閑镻镍閅镟长镌镽镱._2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[k, j];
					}
					obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, num);
					num = 0.0;
				}
			}
			return obj;
		}
		return new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(0, 0);
	}

	public void ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(int 裗袥袼裏袮裞袩裖裚袨裙裖袦袬袭, int 傚傌傋偻偫偪偦偭備健傣健傇傃傩, double 喊喉喱喊喊喐喋喻喌喛喍喍喎喜喎)
	{
		_2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ[裗袥袼裏袮裞袩裖裚袨裙裖袦袬袭, 傚傌傋偻偫偪偦偭備健傣健傇傃傩] = 喊喉喱喊喊喐喋喻喌喛喍喍喎喜喎;
	}

	public _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(int rowN, int columN, string formula)
	{
		睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 = rowN;
		炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎 = columN;
		_2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ = new double[rowN, columN];
		for (int i = 0; i < rowN; i++)
		{
			for (int j = 0; j < columN; j++)
			{
				string text = formula.Replace(_003CModule_003E._16FB_171F_16FEᜫᜨᜨᜫᜨᜭᛸ_171B_173Eᛸᜠ_16FA(), (i + 1).ToString());
				text = text.Replace(_003CModule_003E.뷭븎븕뷱븶븠뷲븬뷵뷳뷲븢븞뷭븐(), (j + 1).ToString());
				ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(i, j, 啑喂喖喀啳啝啍啍啞啯喀喂啱啬啾(text));
			}
		}
	}

	public static _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 졅졺졮졯졭조졭젿조졭졥조졶족졃(PointCollection ꡠꡭꢌꢎꡛꢋꡡꢏꢞꢛꢒꡛꢍ_A879ꡡ, double 붣붟붢붠뷞붧붢붞붡뷧붽뷐뷏붡붦, double 鎶鎻鏋鏩鏦鎻鏜鎼鏦鏇鏎鏏鏨鏇鎼)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(2, ꡠꡭꢌꢎꡛꢋꡡꢏꢞꢛꢒꡛꢍ_A879ꡡ.get_Count());
		for (int i = 0; i < ꡠꡭꢌꢎꡛꢋꡡꢏꢞꢛꢒꡛꢍ_A879ꡡ.get_Count(); i++)
		{
			int 傚傌傋偻偫偪偦偭備健傣健傇傃傩 = i;
			Point val = ꡠꡭꢌꢎꡛꢋꡡꢏꢞꢛꢒꡛꢍ_A879ꡡ.get_Item(i);
			obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(0, 傚傌傋偻偫偪偦偭備健傣健傇傃傩, ((Point)(ref val)).get_X() + 붣붟붢붠뷞붧붢붞붡뷧붽뷐뷏붡붦);
			int 傚傌傋偻偫偪偦偭備健傣健傇傃傩2 = i;
			val = ꡠꡭꢌꢎꡛꢋꡡꢏꢞꢛꢒꡛꢍ_A879ꡡ.get_Item(i);
			obj.ᤁᤘ_1922ᣩᣨ_192Dᣦᤛᤍᣭᣦᣦ_18F8ᣭᣫ(1, 傚傌傋偻偫偪偦偭備健傣健傇傃傩2, ((Point)(ref val)).get_Y() + 鎶鎻鏋鏩鏦鎻鏜鎼鏦鏇鏎鏏鏨鏇鎼);
		}
		return obj;
	}

	public static PointCollection 묣묲묲묳묆묧뭇뫿뭂묂묳묇묄묂묲(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 _17C1ណឍផ_17C3_17C1_17C1ឰថ_17D6ឤផ_17D0ឥឦ, double 脇胞脉胛胖胙胕能脒胝胙脟脋脇胝, double 쇼숋쇕숇숆쇵숝쇛숇숉쇞숉쇸쇷쇘)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		PointCollection val = new PointCollection();
		for (int i = 0; i < _17C1ណឍផ_17C3_17C1_17C1ឰថ_17D6ឤផ_17D0ឥឦ.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎; i++)
		{
			Point val2 = default(Point);
			((Point)(ref val2)).set_X(_17C1ណឍផ_17C3_17C1_17C1ឰថ_17D6ឤផ_17D0ឥឦ._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(0, i) + 脇胞脉胛胖胙胕能脒胝胙脟脋脇胝);
			((Point)(ref val2)).set_Y(_17C1ណឍផ_17C3_17C1_17C1ឰថ_17D6ឤផ_17D0ឥឦ._F00E_F01F_F029_F01B_F010_EFEF_EFF1_F01C_EFEA_F01F_EFF1_EFF2_EFED_EFF3_EFEF(1, i) + 쇼숋쇕숇숆쇵숝쇛숇숉쇞숉쇸쇷쇘);
			val.Add(val2);
		}
		return val;
	}

	public _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(int rowN, int columN)
	{
		睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 = rowN;
		炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎 = columN;
		_2CE8ⲨⲺⲫⳔⲪⲦⲩ_2CE9ⳊⳜⲼⲪⳔⲥ = new double[rowN, columN];
	}
}
