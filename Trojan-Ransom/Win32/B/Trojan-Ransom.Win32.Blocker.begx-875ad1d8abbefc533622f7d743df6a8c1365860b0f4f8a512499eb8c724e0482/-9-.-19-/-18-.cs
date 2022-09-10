using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

namespace _003F9_003F._003F19_003F;

public class _003F18_003F
{
	private static string _003F54_003F;

	private static string _003F55_003F;

	private static byte[] _003F56_003F;

	private static Hashtable _003F57_003F;

	private static bool _003F58_003F;

	private static int _003F41_003F;

	[_003F20_003F]
	public static string _003F36_003F(int _003F48_003F)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Incompatible stack heights: 0 vs 1
		//IL_0047: Incompatible stack heights: 0 vs 1
		//IL_0193: Incompatible stack heights: 0 vs 1
		//IL_01b4: Incompatible stack heights: 0 vs 1
		int num = _003F41_003F;
		_ = /*Error near IL_0015: Stack underflow*/- num;
		_003F48_003F = (int)/*Error near IL_019a: Stack underflow*/;
		if (_003F58_003F)
		{
			_ = _003F57_003F;
			object key = (int)/*Error near IL_0051: Stack underflow*/;
			string text = (string)((Hashtable)/*Error near IL_0056: Stack underflow*/)[key];
			if (text != null)
			{
				return text;
			}
		}
		int num2 = 0;
		int index = _003F48_003F;
		int num3 = _003F56_003F[index++];
		if (((uint)num3 & 0x80u) != 0)
		{
			num2 = ((((uint)num3 & 0x40u) != 0) ? (((num3 & 0x1F) << 24) + (_003F56_003F[index++] << 16) + (_003F56_003F[index++] << 8) + _003F56_003F[index++]) : (((num3 & 0x3F) << 8) + _003F56_003F[index++]));
		}
		else
		{
			num2 = num3;
			if (num2 == 0)
			{
				return string.Empty;
			}
		}
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(_003F56_003F, index, num2));
			string text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (_003F58_003F)
			{
				try
				{
					_003F57_003F.Add(_003F48_003F, text2);
				}
				catch
				{
				}
			}
			return text2;
		}
		catch
		{
			return null;
		}
	}

	static _003F18_003F()
	{
		//IL_004f: Incompatible stack heights: 0 vs 2
		//IL_008c: Incompatible stack heights: 0 vs 1
		//IL_0104: Incompatible stack heights: 0 vs 1
		//IL_0118: Incompatible stack heights: 0 vs 1
		//IL_012c: Incompatible stack heights: 0 vs 1
		_003F54_003F = _003F59_003F._003F60_003F("1");
		_003F55_003F = _003F59_003F._003F60_003F("1ıȶ");
		_003F56_003F = null;
		_003F57_003F = null;
		_003F58_003F = false;
		_003F41_003F = 0;
		_ = _003F54_003F;
		_003F59_003F._003F60_003F("0");
		_ = (string?)/*Error near IL_00fa: Stack underflow*/ == (string?)/*Error near IL_00fa: Stack underflow*/;
		if ((int)/*Error near IL_0063: Stack underflow*/ != 0)
		{
			_003F58_003F = true;
			new Hashtable();
			_003F57_003F = (Hashtable)/*Error near IL_007d: Stack underflow*/;
		}
		_ = _003F55_003F;
		Convert.ToInt32((string?)/*Error near IL_0122: Stack underflow*/);
		_003F41_003F = (int)/*Error near IL_0096: Stack underflow*/;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream(_003F59_003F._003F60_003F("]ēȔ\u031aрԒ\u0615ܯ\u082eर\u0a79\u0b78నൻ\u0e35༣\u1074ᅰተጾᐫᔤᘠ\u173bᠣ\u193bᨴ\u1b3a\u1c3aᵭṭἴ‴ℷ≡⍦②╼"));
		int num = Convert.ToInt32(stream.Length);
		_003F56_003F = new byte[num];
		stream.Read(_003F56_003F, 0, num);
		stream.Close();
	}
}
