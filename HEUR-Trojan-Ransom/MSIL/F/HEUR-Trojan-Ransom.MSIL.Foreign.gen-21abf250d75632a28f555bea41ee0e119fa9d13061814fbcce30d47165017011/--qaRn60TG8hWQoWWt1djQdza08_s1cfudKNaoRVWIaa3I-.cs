using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

internal sealed class _0023_003DqaRn60TG8hWQoWWt1djQdza08_s1cfudKNaoRVWIaa3I_003D : _0023_003Dqso5_cUpX3sSQgau6ECsokRyaIPQN3e1JUFEaVUCa0A4_003D, IDisposable
{
	private SecureString _0023_003DzizBjOuE_003D;

	public _0023_003DqaRn60TG8hWQoWWt1djQdza08_s1cfudKNaoRVWIaa3I_003D()
	{
		SecureString secureString = new SecureString();
		if (8u != 0)
		{
			_0023_003DzizBjOuE_003D = secureString;
		}
		base._002Ector();
	}

	[SpecialName]
	public int _0023_003DzsmclQkWAgcVC3ReldWEfNn6V2buTb4zpA0wsKeTZBEp_002423pmYKK_0024EP7vYzyEukOv4xp9KvNiBVif()
	{
		_ = 3;
		if (2 == 0)
		{
		}
		return _0023_003DzizBjOuE_003D.Length;
	}

	public _0023_003Dqso5_cUpX3sSQgau6ECsokRyaIPQN3e1JUFEaVUCa0A4_003D _0023_003Dzhes9lbwQJIyGvnD5jNbQ6NwEpG_3KSiuc22Af8tWEiBQU1BpTkMPY9EIR7Ipt5pBDjBfPLQqq5zTGF8eWw_003D_003D()
	{
		return new _0023_003DqaRn60TG8hWQoWWt1djQdza08_s1cfudKNaoRVWIaa3I_003D();
	}

	public void _0023_003DzF6GxoG1UqHSYTQWziUS1hh0aU2nZpCx5zNaJGcPxbhdtjwu9C7_fzcn_0024NIgo_0024i0o0A_003D_003D(int _0023_003DzizBjOuE_003D, out byte _0023_003DzYtBeqWc_003D)
	{
		if (_0023_003DzizBjOuE_003D < 0 || _0023_003DzizBjOuE_003D >= _0023_003DzsmclQkWAgcVC3ReldWEfNn6V2buTb4zpA0wsKeTZBEp_002423pmYKK_0024EP7vYzyEukOv4xp9KvNiBVif())
		{
			throw new ArgumentOutOfRangeException();
		}
		IntPtr zero = IntPtr.Zero;
		IntPtr intPtr;
		if (3u != 0)
		{
			intPtr = zero;
		}
		char c;
		if (true)
		{
			c = '\0';
		}
		try
		{
			IntPtr intPtr2 = Marshal.SecureStringToGlobalAllocUnicode(this._0023_003DzizBjOuE_003D);
			if (2u != 0)
			{
				intPtr = intPtr2;
			}
			c = (char)Marshal.ReadInt16(intPtr, _0023_003DzizBjOuE_003D * 2);
			_0023_003DzYtBeqWc_003D = _0023_003Dzz0h4wdkJzeM9k4zyRj_rF_0024g_003D(c, _0023_003DzizBjOuE_003D);
		}
		finally
		{
			_0023_003DqldjtkXfK9JQPEQHv1aPQuU5HpP3Mild1EmzWBzxIaSQ_003D._0023_003DzxpsZCjDNPb0MtoqQW_00241cNasof8Qrc_E4879Y7es_003D(ref c);
			if (intPtr != IntPtr.Zero)
			{
				Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
			}
		}
	}

	public void _0023_003DzPx2_BSgKjpZiCG_0024aiuhdaa0F8hIh56vnw3G97U9b19UaoYib5WjtR5NBvSr5Jq9_0024hnxFXn1a3BmTwxNdig_003D_003D(int _0023_003DzizBjOuE_003D, ref byte _0023_003DzYtBeqWc_003D)
	{
		int length = this._0023_003DzizBjOuE_003D.Length;
		int num;
		if (2u != 0)
		{
			num = length;
		}
		while (true)
		{
			if (num > _0023_003DzizBjOuE_003D)
			{
				this._0023_003DzizBjOuE_003D.SetAt(_0023_003DzizBjOuE_003D, _0023_003Dzxp1gwP_0024nMuTc_0024AOQCfR_GSiJZJTh(_0023_003DzYtBeqWc_003D, _0023_003DzizBjOuE_003D));
				return;
			}
			if (num == _0023_003DzizBjOuE_003D)
			{
				break;
			}
			this._0023_003DzizBjOuE_003D.AppendChar(_0023_003Dzxp1gwP_0024nMuTc_0024AOQCfR_GSiJZJTh(0, num));
			int num2 = num + 1;
			if (2u != 0)
			{
				num = num2;
			}
		}
		this._0023_003DzizBjOuE_003D.AppendChar(_0023_003Dzxp1gwP_0024nMuTc_0024AOQCfR_GSiJZJTh(_0023_003DzYtBeqWc_003D, num));
	}

	private static char _0023_003Dzxp1gwP_0024nMuTc_0024AOQCfR_GSiJZJTh(byte _0023_003DzizBjOuE_003D, int _0023_003DzYtBeqWc_003D)
	{
		_ = 7;
		if (false)
		{
		}
		return (char)(_0023_003DzizBjOuE_003D + 1);
	}

	private static byte _0023_003Dzz0h4wdkJzeM9k4zyRj_rF_0024g_003D(char _0023_003DzizBjOuE_003D, int _0023_003DzYtBeqWc_003D)
	{
		_ = 1;
		if (3 == 0)
		{
		}
		return (byte)(_0023_003DzizBjOuE_003D - 1);
	}

	public void _0023_003DzqbovSyOqkrB99YruJ0GZWjXuNpZbc_0024PDBm_gNT1pIXhcJgK2gus4BW5rsHEE3IJlFvnPpUI_003D()
	{
		_ = 0;
		if (2 == 0)
		{
		}
		_0023_003DzizBjOuE_003D.Clear();
	}

	public void Dispose()
	{
		_0023_003DzizBjOuE_003D.Dispose();
		if (true)
		{
			_0023_003DzizBjOuE_003D = null;
		}
	}
}
