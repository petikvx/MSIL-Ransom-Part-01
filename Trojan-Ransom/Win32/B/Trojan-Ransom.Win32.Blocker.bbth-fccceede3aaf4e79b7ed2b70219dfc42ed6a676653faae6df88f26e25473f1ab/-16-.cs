using System.IO;

internal sealed class _003F16_003F
{
	private sealed class _003F17_003F
	{
		public static readonly _003F17_003F ㅔ_2786筱齂_0EA6ⱛव뮆;

		private byte[] 퐧_F614_ABFE䑰_2245䇅앦鳌;

		static _003F17_003F()
		{
			//Discarded unreachable code: IL_001d, IL_002d
			if (_003F33_003F._003F112_003F(_003F32_003F._003F111_003F(), _003F26_003F._003F105_003F(635034873737140000L)))
			{
				throw _003F27_003F._003F106_003F();
			}
			ㅔ_2786筱齂_0EA6ⱛव뮆 = new _003F17_003F();
		}

		private _003F17_003F()
		{
			//IL_0058: Incompatible stack heights: 0 vs 1
			//IL_005d: Incompatible stack heights: 0 vs 1
			((object)/*Error near IL_004c: Stack underflow*/)._002Ector();
			_003F63_003F._003F144_003F();
			Stream stream = _003F52_003F._003F132_003F((object)/*Error near IL_0010: Stack underflow*/, _003F16_003F.ㅔ_2786筱齂_0EA6ⱛव뮆);
			if (stream != null)
			{
				퐧_F614_ABFE䑰_2245䇅앦鳌 = new byte[256];
				_003F37_003F._003F116_003F(stream, 퐧_F614_ABFE䑰_2245䇅앦鳌, 0, 퐧_F614_ABFE䑰_2245䇅앦鳌.Length);
			}
		}

		public string _003F87_003F(string _003F87_003F, int _003F87_003F)
		{
			//IL_0066: Incompatible stack heights: 0 vs 1
			//IL_006b: Incompatible stack heights: 0 vs 1
			_003F70_003F._003F152_003F(_003F87_003F);
			int num = (int)/*Error near IL_0056: Stack underflow*/;
			_ = _003F87_003F & 0xFF;
			int num2 = (int)/*Error near IL_003b: Stack underflow*/;
			char[] array = _003F71_003F._003F153_003F(_003F87_003F);
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (퐧_F614_ABFE䑰_2245䇅앦鳌[num2] | _003F87_003F));
			}
			return _003F69_003F._003F151_003F(_003F31_003F._003F110_003F(array));
		}
	}

	public static string ㅔ_2786筱齂_0EA6ⱛव뮆 => (string)_003F18_003F._003F88_003F(798906204u, 804638874u);

	public static string _003F87_003F(string _003F87_003F, int _003F87_003F)
	{
		//Discarded unreachable code: IL_001d, IL_002d
		if (_003F33_003F._003F112_003F(_003F32_003F._003F111_003F(), _003F26_003F._003F105_003F(635034873737520000L)))
		{
			throw _003F27_003F._003F106_003F();
		}
		return _003F69_003F._003F151_003F(_003F17_003F.ㅔ_2786筱齂_0EA6ⱛव뮆._003F87_003F(_003F87_003F, _003F87_003F));
	}
}
