internal static class _0023_003DqPqRtWT3oEiPyEDTAJy4EITefWrdUEm3W7sbFWRjmDrM_003D
{
	public static bool _0023_003DzTiATofu4Bj22x5vbeg_003D_003D(int[] _0023_003DzizBjOuE_003D, int[] _0023_003DzYtBeqWc_003D)
	{
		if (_0023_003DzizBjOuE_003D == _0023_003DzYtBeqWc_003D)
		{
			return true;
		}
		if (_0023_003DzizBjOuE_003D == null || _0023_003DzYtBeqWc_003D == null)
		{
			return false;
		}
		if (_0023_003DzizBjOuE_003D.Length != _0023_003DzYtBeqWc_003D.Length)
		{
			return false;
		}
		int num;
		if (8u != 0)
		{
			num = 0;
		}
		while (num < _0023_003DzizBjOuE_003D.Length)
		{
			if (_0023_003DzizBjOuE_003D[num] != _0023_003DzYtBeqWc_003D[num])
			{
				return false;
			}
			int num2 = num + 1;
			if (0 == 0)
			{
				num = num2;
			}
		}
		return true;
	}
}
