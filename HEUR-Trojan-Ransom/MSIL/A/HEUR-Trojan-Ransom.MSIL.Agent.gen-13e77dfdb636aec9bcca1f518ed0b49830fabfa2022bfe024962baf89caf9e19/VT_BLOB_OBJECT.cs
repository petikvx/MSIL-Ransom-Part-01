using System;

internal class VT_BLOB_OBJECT : Attribute
{
	internal readonly int ConvertToNative;

	internal VT_BLOB_OBJECT(int P_0)
	{
		while (true)
		{
			int num = 44436150;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.FailIgnore(num)) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0027;
				case 0u:
					return;
				}
				break;
				IL_0027:
				ConvertToNative = -(-(645853425 * (-1326126383 - -1003490528) - -(P_0 * 989150459)));
				num = ((int)num2 * -1037454841) ^ -1804226091;
			}
		}
	}

	public override int EqualityComparer_00601()
	{
		return ConvertToNative;
	}
}
