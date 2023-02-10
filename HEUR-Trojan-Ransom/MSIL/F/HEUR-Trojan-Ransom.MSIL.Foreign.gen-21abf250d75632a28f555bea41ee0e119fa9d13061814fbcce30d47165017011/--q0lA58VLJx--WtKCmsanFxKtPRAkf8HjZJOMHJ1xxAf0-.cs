using System;
using System.IO;
using System.Text;

internal sealed class _0023_003Dq0lA58VLJx_0024_0024WtKCmsanFxKtPRAkf8HjZJOMHJ1xxAf0_003D : IDisposable
{
	private _0023_003DqLNuFd4Trylp_U2bt7kOuyGXmPIdBPNmEz9XsV6_0024NqPo_003D _0023_003DzizBjOuE_003D;

	private byte[] _0023_003DzYtBeqWc_003D;

	private Decoder _0023_003Dzfze_RqI_003D;

	private byte[] _0023_003DzldAoPbg_003D;

	private char[] _0023_003DzgfHGZnM_003D;

	private char[] _0023_003DzjYs4aQ0_003D;

	private int _0023_003DzFf2lV_s_003D;

	private bool _0023_003DzloebDe0_003D;

	private bool _0023_003Dzyb_0024oYio_003D;

	private byte[] _0023_003DzJMv5LHg_003D;

	private MemoryStream _0023_003DzsA64e3Q_003D;

	private BinaryReader _0023_003DzIgpgVjY_003D;

	public _0023_003Dq0lA58VLJx_0024_0024WtKCmsanFxKtPRAkf8HjZJOMHJ1xxAf0_003D(_0023_003DqLNuFd4Trylp_U2bt7kOuyGXmPIdBPNmEz9XsV6_0024NqPo_003D _0023_003DzizBjOuE_003D)
	{
		_ = 2;
		if (1 == 0)
		{
		}
		_ = 3;
		if (3 == 0)
		{
		}
		this._002Ector(_0023_003DzizBjOuE_003D, new UTF8Encoding());
	}

	private _0023_003Dq0lA58VLJx_0024_0024WtKCmsanFxKtPRAkf8HjZJOMHJ1xxAf0_003D(_0023_003DqLNuFd4Trylp_U2bt7kOuyGXmPIdBPNmEz9XsV6_0024NqPo_003D _0023_003DzizBjOuE_003D, Encoding _0023_003DzYtBeqWc_003D)
	{
		if (_0023_003DzizBjOuE_003D == null)
		{
			throw new ArgumentNullException();
		}
		if (_0023_003DzYtBeqWc_003D == null)
		{
			throw new ArgumentNullException();
		}
		if (!_0023_003DzizBjOuE_003D._0023_003Dzv9fbZllvhcM7hPVualHh_00248VQt2irr7wAZOZF3Sgq0xcZj4mPUShnvpKK4cqblsUbdzlaYA14_0024sNI())
		{
			throw new ArgumentException();
		}
		if (7u != 0)
		{
			this._0023_003DzizBjOuE_003D = _0023_003DzizBjOuE_003D;
		}
		Decoder decoder = _0023_003DzYtBeqWc_003D.GetDecoder();
		if (0 == 0)
		{
			_0023_003Dzfze_RqI_003D = decoder;
		}
		int maxCharCount = _0023_003DzYtBeqWc_003D.GetMaxCharCount(128);
		if (3u != 0)
		{
			_0023_003DzFf2lV_s_003D = maxCharCount;
		}
		int num = _0023_003DzYtBeqWc_003D.GetMaxByteCount(1);
		if (num < 16)
		{
			num = 16;
		}
		this._0023_003DzYtBeqWc_003D = new byte[num];
		_0023_003DzjYs4aQ0_003D = null;
		_0023_003DzldAoPbg_003D = null;
		_0023_003DzloebDe0_003D = _0023_003DzYtBeqWc_003D is UnicodeEncoding;
		_0023_003Dzyb_0024oYio_003D = this._0023_003DzizBjOuE_003D is _0023_003DqNthW6BZrbFN_0024FkJOHrDRiHOaX4CF6pBbL4zlx5p1KyM_003D;
	}

	public _0023_003DqLNuFd4Trylp_U2bt7kOuyGXmPIdBPNmEz9XsV6_0024NqPo_003D _0023_003DzSTLp8rpblRzzmToHeloPzcSrwCvy()
	{
		_ = 6;
		if (7 == 0)
		{
		}
		return _0023_003DzizBjOuE_003D;
	}

	public void _0023_003DzQUXgO9ykSkkXXt4p_0024nRCnA1wBdlzWDB5sQ_003D_003D()
	{
		if (true)
		{
			_0023_003DzDHPIJQ2UVY67d2V3vg6h6BE6cpFS0aMnqn1vdMECAP3_(_0023_003DzizBjOuE_003D: true);
		}
	}

	private void _0023_003DzDHPIJQ2UVY67d2V3vg6h6BE6cpFS0aMnqn1vdMECAP3_(bool _0023_003DzizBjOuE_003D)
	{
		if (_0023_003DzizBjOuE_003D)
		{
			_0023_003DqLNuFd4Trylp_U2bt7kOuyGXmPIdBPNmEz9XsV6_0024NqPo_003D obj = this._0023_003DzizBjOuE_003D;
			_0023_003DqLNuFd4Trylp_U2bt7kOuyGXmPIdBPNmEz9XsV6_0024NqPo_003D _0023_003DqLNuFd4Trylp_U2bt7kOuyGXmPIdBPNmEz9XsV6_0024NqPo_003D2;
			if (5u != 0)
			{
				_0023_003DqLNuFd4Trylp_U2bt7kOuyGXmPIdBPNmEz9XsV6_0024NqPo_003D2 = obj;
			}
			if (4u != 0)
			{
				this._0023_003DzizBjOuE_003D = null;
			}
			_0023_003DqLNuFd4Trylp_U2bt7kOuyGXmPIdBPNmEz9XsV6_0024NqPo_003D2?._0023_003DzfYv3dhQW4NJVFJTbj6dueSOEvAH94sH2NjjYnCRfjWj_0024Rb_0024EXr7B0kkDOaehtYr894mjueS_GEAm();
		}
		if (2u != 0)
		{
			this._0023_003DzizBjOuE_003D = null;
		}
		_0023_003DzYtBeqWc_003D = null;
		_0023_003Dzfze_RqI_003D = null;
		_0023_003DzldAoPbg_003D = null;
		_0023_003DzgfHGZnM_003D = null;
		_0023_003DzjYs4aQ0_003D = null;
	}

	private void _0023_003DzR1XDZ49iyjmC03_GU8Q8D51dlVTajNNx0LBBr5PW19OYjfWDbBrk31rh8_S0Tbl4JA_003D_003D()
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DzDHPIJQ2UVY67d2V3vg6h6BE6cpFS0aMnqn1vdMECAP3_(_0023_003DzizBjOuE_003D: true);
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in #=zR1XDZ49iyjmC03_GU8Q8D51dlVTajNNx0LBBr5PW19OYjfWDbBrk31rh8_S0Tbl4JA==
		this._0023_003DzR1XDZ49iyjmC03_GU8Q8D51dlVTajNNx0LBBr5PW19OYjfWDbBrk31rh8_S0Tbl4JA_003D_003D();
	}

	public int _0023_003DzV6MWHyZV_2AiWZ4UTEeHu3mGHx5g()
	{
		if (2u != 0)
		{
			_0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D();
		}
		if (!_0023_003DzizBjOuE_003D._0023_003DzwXxHiTbjGtvx58vy6yOjivXPB4H21vOqEINhDpSIdotECKTBwxph83YLDeLc8esBlt3jJ96RzjrL())
		{
			return -1;
		}
		long num = _0023_003DzizBjOuE_003D._0023_003DzLBuu_0024mny6bi1VcDg6ZTcTn3VsToFDHBin4kE9NS6MfuJigBNRZ_0024l_pId6GPxRcT8rZlix9CDac0RhzDPEHAnpwqI3K9t();
		long num2;
		if (3u != 0)
		{
			num2 = num;
		}
		int result = _0023_003Dzu71mCcsHvjTFg_0024K_0024An3OLpc_003D();
		_0023_003DzizBjOuE_003D._0023_003DzDvONlQBwBGQph6QiKG1HeHE5s_NB6yupCqO4RvtGD2uGArpzOMNkKAQ_86t_0024WXyVSId6AsfSPyHL(num2);
		return result;
	}

	public int _0023_003Dzu71mCcsHvjTFg_0024K_0024An3OLpc_003D()
	{
		if (6u != 0)
		{
			_0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D();
		}
		return _0023_003DziCARdXv_00248gSabaCtR_QUnZmN_zRo();
	}

	public bool _0023_003DzB30wgjVkIJk8ZbTDGrwTigw_003D()
	{
		if (true)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(1);
		}
		return _0023_003DzYtBeqWc_003D[0] != 0;
	}

	public byte _0023_003DzYz2v8C1A_DRkkuED2BSCs14_003D()
	{
		if (uint.MaxValue != 0)
		{
			_0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D();
		}
		int num = _0023_003DzizBjOuE_003D._0023_003DzQOtTkKlDsj_00240gHadF5xlcf5DRVwcsYmvI1aYfi__00248_0024jVW4AiH285eqmR3k4Beh8cigwNqkI_003D();
		if (num == -1)
		{
			throw new Exception();
		}
		return (byte)num;
	}

	public sbyte _0023_003DzAchfUZ3JRTrnUF9B11hdiLiqgha9()
	{
		if (true)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(1);
		}
		return (sbyte)_0023_003DzYtBeqWc_003D[0];
	}

	public char _0023_003Dz9lG5NC_CVqdHC2xj2qmjqFoViJ0U()
	{
		_ = 6;
		if (6 == 0)
		{
		}
		int num = _0023_003Dzu71mCcsHvjTFg_0024K_0024An3OLpc_003D();
		if (num == -1)
		{
			throw new Exception();
		}
		return (char)num;
	}

	private static decimal _0023_003Dz0aRnMcVRR7l0Hl_hPlCfGpbHWR7L(int _0023_003DzizBjOuE_003D, int _0023_003DzYtBeqWc_003D, int _0023_003Dzfze_RqI_003D, int _0023_003DzldAoPbg_003D)
	{
		bool num = (_0023_003DzldAoPbg_003D & int.MinValue) != 0;
		bool isNegative;
		if (4u != 0)
		{
			isNegative = num;
		}
		byte num2 = (byte)(_0023_003DzldAoPbg_003D >> 16);
		byte scale = default(byte);
		if (0 == 0)
		{
			scale = num2;
		}
		return new decimal(_0023_003DzizBjOuE_003D, _0023_003DzYtBeqWc_003D, _0023_003Dzfze_RqI_003D, isNegative, scale);
	}

	internal static decimal _0023_003Dzo2BGK_0024cPolx0mWS9KW8dRpWAmDxjDd4OxoBWyEE_003D(byte[] _0023_003DzizBjOuE_003D)
	{
		int num = _0023_003DzizBjOuE_003D[0] | (_0023_003DzizBjOuE_003D[1] << 8) | (_0023_003DzizBjOuE_003D[2] << 16) | (_0023_003DzizBjOuE_003D[3] << 24);
		int num2 = _0023_003DzizBjOuE_003D[4] | (_0023_003DzizBjOuE_003D[5] << 8) | (_0023_003DzizBjOuE_003D[6] << 16) | (_0023_003DzizBjOuE_003D[7] << 24);
		int num3;
		if (8u != 0)
		{
			num3 = num2;
		}
		int num4 = _0023_003DzizBjOuE_003D[8] | (_0023_003DzizBjOuE_003D[9] << 8) | (_0023_003DzizBjOuE_003D[10] << 16) | (_0023_003DzizBjOuE_003D[11] << 24);
		int num5;
		if (5u != 0)
		{
			num5 = num4;
		}
		int num6 = _0023_003DzizBjOuE_003D[12] | (_0023_003DzizBjOuE_003D[13] << 8) | (_0023_003DzizBjOuE_003D[14] << 16) | (_0023_003DzizBjOuE_003D[15] << 24);
		int num7 = default(int);
		if (0 == 0)
		{
			num7 = num6;
		}
		return _0023_003Dz0aRnMcVRR7l0Hl_hPlCfGpbHWR7L(num, num3, num5, num7);
	}

	public string _0023_003DzZ8J__1ZOAFcs4Y7_d5FEStY_003D()
	{
		int num;
		if (8u != 0)
		{
			num = 0;
		}
		if (6u != 0)
		{
			_0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D();
		}
		int num2 = _0023_003DzcCAwS_GAbKZTgAkcv_YPIOhdR6ZzKO_0024D6g_003D_003D();
		int num3 = default(int);
		if (0 == 0)
		{
			num3 = num2;
		}
		if (num3 < 0)
		{
			throw new IOException();
		}
		if (num3 == 0)
		{
			return string.Empty;
		}
		if (_0023_003DzldAoPbg_003D == null)
		{
			_0023_003DzldAoPbg_003D = new byte[128];
		}
		if (_0023_003DzjYs4aQ0_003D == null)
		{
			_0023_003DzjYs4aQ0_003D = new char[_0023_003DzFf2lV_s_003D];
		}
		StringBuilder stringBuilder = null;
		do
		{
			int num4 = ((num3 - num > 128) ? 128 : (num3 - num));
			int num5 = _0023_003DzizBjOuE_003D._0023_003DzMbkpDNIwZkc7AO1MBiofy8Rgr9s2sZr61nxZQj4K5mfj_0024bQ1lI022_0024S90E3Gf4hRAmvytQ0pYGPmqNTyOXPgqC4_003D(_0023_003DzldAoPbg_003D, 0, num4);
			if (num5 == 0)
			{
				throw new Exception();
			}
			int chars = _0023_003Dzfze_RqI_003D.GetChars(_0023_003DzldAoPbg_003D, 0, num5, _0023_003DzjYs4aQ0_003D, 0);
			if (num == 0 && num5 == num3)
			{
				return new string(_0023_003DzjYs4aQ0_003D, 0, chars);
			}
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(num3);
			}
			stringBuilder.Append(_0023_003DzjYs4aQ0_003D, 0, chars);
			num += num5;
		}
		while (num < num3);
		return stringBuilder.ToString();
	}

	public int _0023_003DzNVExlftRpVnKkN__0024pjcfClc_003D(char[] _0023_003DzizBjOuE_003D, int _0023_003DzYtBeqWc_003D, int _0023_003Dzfze_RqI_003D)
	{
		if (_0023_003DzizBjOuE_003D == null)
		{
			throw new ArgumentNullException(_0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366345733), _0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366345854));
		}
		if (_0023_003DzYtBeqWc_003D < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0023_003Dzfze_RqI_003D < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0023_003DzizBjOuE_003D.Length - _0023_003DzYtBeqWc_003D < _0023_003Dzfze_RqI_003D)
		{
			throw new ArgumentException();
		}
		if (5u != 0)
		{
			_0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D();
		}
		return _0023_003Dz3N19TM1JRq59CCgIT_00245YHLD15yzZ2wkaTfuxkZ4_003D(_0023_003DzizBjOuE_003D, _0023_003DzYtBeqWc_003D, _0023_003Dzfze_RqI_003D);
	}

	private int _0023_003Dz3N19TM1JRq59CCgIT_00245YHLD15yzZ2wkaTfuxkZ4_003D(char[] _0023_003DzizBjOuE_003D, int _0023_003DzYtBeqWc_003D, int _0023_003Dzfze_RqI_003D)
	{
		if (7u != 0)
		{
			int num = 0;
		}
		if (uint.MaxValue != 0)
		{
			int num2 = 0;
		}
		int num3;
		if (2u != 0)
		{
			num3 = _0023_003Dzfze_RqI_003D;
		}
		if (_0023_003DzldAoPbg_003D == null)
		{
			_0023_003DzldAoPbg_003D = new byte[128];
		}
		while (num3 > 0)
		{
			int num2 = num3;
			if (_0023_003DzloebDe0_003D)
			{
				num2 <<= 1;
			}
			if (num2 > 128)
			{
				num2 = 128;
			}
			int num;
			if (_0023_003Dzyb_0024oYio_003D)
			{
				_0023_003DqNthW6BZrbFN_0024FkJOHrDRiHOaX4CF6pBbL4zlx5p1KyM_003D _0023_003DqNthW6BZrbFN_0024FkJOHrDRiHOaX4CF6pBbL4zlx5p1KyM_003D2 = (_0023_003DqNthW6BZrbFN_0024FkJOHrDRiHOaX4CF6pBbL4zlx5p1KyM_003D)this._0023_003DzizBjOuE_003D;
				int byteIndex = _0023_003DqNthW6BZrbFN_0024FkJOHrDRiHOaX4CF6pBbL4zlx5p1KyM_003D2._0023_003DzubqNpZU_0024cZ3Qtpfi5SXKtaPZ5AxGcTyI4hqExJ8_003D();
				num2 = _0023_003DqNthW6BZrbFN_0024FkJOHrDRiHOaX4CF6pBbL4zlx5p1KyM_003D2._0023_003DzEzRaqfyHRqPro_Yi9pAXPcQ_003D(num2);
				if (num2 == 0)
				{
					return _0023_003Dzfze_RqI_003D - num3;
				}
				num = this._0023_003Dzfze_RqI_003D.GetChars(_0023_003DqNthW6BZrbFN_0024FkJOHrDRiHOaX4CF6pBbL4zlx5p1KyM_003D2._0023_003Dz8bEIZVJWsRv57VtoqeI4wsPiNf46(), byteIndex, num2, _0023_003DzizBjOuE_003D, _0023_003DzYtBeqWc_003D);
			}
			else
			{
				num2 = this._0023_003DzizBjOuE_003D._0023_003DzMbkpDNIwZkc7AO1MBiofy8Rgr9s2sZr61nxZQj4K5mfj_0024bQ1lI022_0024S90E3Gf4hRAmvytQ0pYGPmqNTyOXPgqC4_003D(_0023_003DzldAoPbg_003D, 0, num2);
				if (num2 == 0)
				{
					return _0023_003Dzfze_RqI_003D - num3;
				}
				num = this._0023_003Dzfze_RqI_003D.GetChars(_0023_003DzldAoPbg_003D, 0, num2, _0023_003DzizBjOuE_003D, _0023_003DzYtBeqWc_003D);
			}
			num3 -= num;
			_0023_003DzYtBeqWc_003D += num;
		}
		return _0023_003Dzfze_RqI_003D;
	}

	private int _0023_003DziCARdXv_00248gSabaCtR_QUnZmN_zRo()
	{
		int num;
		if (7u != 0)
		{
			num = 0;
		}
		if (uint.MaxValue != 0)
		{
			int num2 = 0;
		}
		long num3 = 0L;
		long num4;
		if (7u != 0)
		{
			num4 = num3;
		}
		num4 = num3;
		if (_0023_003DzizBjOuE_003D._0023_003DzwXxHiTbjGtvx58vy6yOjivXPB4H21vOqEINhDpSIdotECKTBwxph83YLDeLc8esBlt3jJ96RzjrL())
		{
			num4 = _0023_003DzizBjOuE_003D._0023_003DzLBuu_0024mny6bi1VcDg6ZTcTn3VsToFDHBin4kE9NS6MfuJigBNRZ_0024l_pId6GPxRcT8rZlix9CDac0RhzDPEHAnpwqI3K9t();
		}
		if (_0023_003DzldAoPbg_003D == null)
		{
			_0023_003DzldAoPbg_003D = new byte[128];
		}
		if (_0023_003DzgfHGZnM_003D == null)
		{
			_0023_003DzgfHGZnM_003D = new char[1];
		}
		while (num == 0)
		{
			int num2 = ((!_0023_003DzloebDe0_003D) ? 1 : 2);
			int num5 = _0023_003DzizBjOuE_003D._0023_003DzQOtTkKlDsj_00240gHadF5xlcf5DRVwcsYmvI1aYfi__00248_0024jVW4AiH285eqmR3k4Beh8cigwNqkI_003D();
			_0023_003DzldAoPbg_003D[0] = (byte)num5;
			if (num5 == -1)
			{
				num2 = 0;
			}
			if (num2 == 2)
			{
				num5 = _0023_003DzizBjOuE_003D._0023_003DzQOtTkKlDsj_00240gHadF5xlcf5DRVwcsYmvI1aYfi__00248_0024jVW4AiH285eqmR3k4Beh8cigwNqkI_003D();
				_0023_003DzldAoPbg_003D[1] = (byte)num5;
				if (num5 == -1)
				{
					num2 = 1;
				}
			}
			if (num2 == 0)
			{
				return -1;
			}
			try
			{
				num = _0023_003Dzfze_RqI_003D.GetChars(_0023_003DzldAoPbg_003D, 0, num2, _0023_003DzgfHGZnM_003D, 0);
			}
			catch
			{
				if (_0023_003DzizBjOuE_003D._0023_003DzwXxHiTbjGtvx58vy6yOjivXPB4H21vOqEINhDpSIdotECKTBwxph83YLDeLc8esBlt3jJ96RzjrL())
				{
					_0023_003DzizBjOuE_003D._0023_003DzX2hPj8BuVz9mWgbEAFyrXUtuEr6IctPFOn6j7iTwSQrFrGIHtFqD6qeaxaziaFgCwU8ZS9c_003D(num4 - _0023_003DzizBjOuE_003D._0023_003DzLBuu_0024mny6bi1VcDg6ZTcTn3VsToFDHBin4kE9NS6MfuJigBNRZ_0024l_pId6GPxRcT8rZlix9CDac0RhzDPEHAnpwqI3K9t(), 1);
				}
				throw;
			}
		}
		if (num == 0)
		{
			return -1;
		}
		return _0023_003DzgfHGZnM_003D[0];
	}

	public char[] _0023_003DzfF_TDBbEJHnFSZ_00247mMG80a3yfU4_(int _0023_003DzizBjOuE_003D)
	{
		if (2u != 0)
		{
			_0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D();
		}
		if (_0023_003DzizBjOuE_003D < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		char[] array = new char[_0023_003DzizBjOuE_003D];
		char[] array2 = default(char[]);
		if (0 == 0)
		{
			array2 = array;
		}
		int num = _0023_003Dz3N19TM1JRq59CCgIT_00245YHLD15yzZ2wkaTfuxkZ4_003D(array2, 0, _0023_003DzizBjOuE_003D);
		int num2;
		if (4u != 0)
		{
			num2 = num;
		}
		if (num2 != _0023_003DzizBjOuE_003D)
		{
			char[] array3 = new char[num2];
			Buffer.BlockCopy(array2, 0, array3, 0, 2 * num2);
			array2 = array3;
		}
		return array2;
	}

	public int _0023_003DzsUI2r84A980b3eCYVaKSQUY_003D(byte[] _0023_003DzizBjOuE_003D, int _0023_003DzYtBeqWc_003D, int _0023_003Dzfze_RqI_003D)
	{
		if (_0023_003DzizBjOuE_003D == null)
		{
			throw new ArgumentNullException();
		}
		if (_0023_003DzYtBeqWc_003D < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0023_003Dzfze_RqI_003D < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (_0023_003DzizBjOuE_003D.Length - _0023_003DzYtBeqWc_003D < _0023_003Dzfze_RqI_003D)
		{
			throw new ArgumentException();
		}
		if (5u != 0)
		{
			_0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D();
		}
		return this._0023_003DzizBjOuE_003D._0023_003DzMbkpDNIwZkc7AO1MBiofy8Rgr9s2sZr61nxZQj4K5mfj_0024bQ1lI022_0024S90E3Gf4hRAmvytQ0pYGPmqNTyOXPgqC4_003D(_0023_003DzizBjOuE_003D, _0023_003DzYtBeqWc_003D, _0023_003Dzfze_RqI_003D);
	}

	private void _0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D()
	{
		_ = 1;
		if (1 == 0)
		{
		}
		if (_0023_003DzizBjOuE_003D == null)
		{
			throw new Exception();
		}
	}

	public byte[] _0023_003Dz42_0024LXD56INNklDDjXgRLHkAHbIntpdNmRkuXNRg_003D(int _0023_003DzizBjOuE_003D)
	{
		if (_0023_003DzizBjOuE_003D < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (4u != 0)
		{
			_0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D();
		}
		byte[] array = new byte[_0023_003DzizBjOuE_003D];
		byte[] array2;
		if (5u != 0)
		{
			array2 = array;
		}
		int num;
		if (2u != 0)
		{
			num = 0;
		}
		do
		{
			int num2 = this._0023_003DzizBjOuE_003D._0023_003DzMbkpDNIwZkc7AO1MBiofy8Rgr9s2sZr61nxZQj4K5mfj_0024bQ1lI022_0024S90E3Gf4hRAmvytQ0pYGPmqNTyOXPgqC4_003D(array2, num, _0023_003DzizBjOuE_003D);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			_0023_003DzizBjOuE_003D -= num2;
		}
		while (_0023_003DzizBjOuE_003D > 0);
		if (num != array2.Length)
		{
			byte[] array3 = new byte[num];
			Buffer.BlockCopy(array2, 0, array3, 0, num);
			array2 = array3;
		}
		return array2;
	}

	private void _0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(int _0023_003DzizBjOuE_003D)
	{
		if (6u != 0)
		{
			_0023_003Dzr9BxRyHEy_xR5LoTh51dQgufvrEQ9XtwrvWsdxY_003D();
		}
		int num;
		if (5u != 0)
		{
			num = 0;
		}
		if (8u != 0)
		{
			int num2 = 0;
		}
		if (_0023_003DzizBjOuE_003D == 1)
		{
			int num2 = this._0023_003DzizBjOuE_003D._0023_003DzQOtTkKlDsj_00240gHadF5xlcf5DRVwcsYmvI1aYfi__00248_0024jVW4AiH285eqmR3k4Beh8cigwNqkI_003D();
			if (num2 == -1)
			{
				throw new Exception();
			}
			_0023_003DzYtBeqWc_003D[0] = (byte)num2;
			return;
		}
		do
		{
			int num2 = this._0023_003DzizBjOuE_003D._0023_003DzMbkpDNIwZkc7AO1MBiofy8Rgr9s2sZr61nxZQj4K5mfj_0024bQ1lI022_0024S90E3Gf4hRAmvytQ0pYGPmqNTyOXPgqC4_003D(_0023_003DzYtBeqWc_003D, num, _0023_003DzizBjOuE_003D - num);
			if (num2 == 0)
			{
				throw new Exception();
			}
			num += num2;
		}
		while (num < _0023_003DzizBjOuE_003D);
	}

	internal int _0023_003DzcCAwS_GAbKZTgAkcv_YPIOhdR6ZzKO_0024D6g_003D_003D()
	{
		int num;
		if (uint.MaxValue != 0)
		{
			num = 0;
		}
		int num2;
		if (5u != 0)
		{
			num2 = 0;
		}
		byte b;
		do
		{
			if (num2 == 35)
			{
				throw new FormatException();
			}
			byte num3 = _0023_003DzYz2v8C1A_DRkkuED2BSCs14_003D();
			if (3u != 0)
			{
				b = num3;
			}
			num |= (b & 0x7F) << num2;
			num2 += 7;
		}
		while ((b & 0x80u) != 0);
		return num;
	}

	public int _0023_003DzlCTFGvaoxAmHsFRMVuQCAwFEjbcxwPEMq_Nk1KPsdupm()
	{
		if (_0023_003Dzyb_0024oYio_003D)
		{
			return ((_0023_003DqNthW6BZrbFN_0024FkJOHrDRiHOaX4CF6pBbL4zlx5p1KyM_003D)_0023_003DzizBjOuE_003D)._0023_003DzZgodbc7gDGHEieylrneCLYxz1Eqq71RX9A_003D_003D();
		}
		if (5u != 0)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(4);
		}
		return (_0023_003DzYtBeqWc_003D[2] << 16) | (_0023_003DzYtBeqWc_003D[1] << 24) | _0023_003DzYtBeqWc_003D[3] | (_0023_003DzYtBeqWc_003D[0] << 8);
	}

	public uint _0023_003Dz5W_zsNVVwqJ0d0PuglrQmaF29QVcOjIZXg_003D_003D()
	{
		if (5u != 0)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(4);
		}
		return (uint)((_0023_003DzYtBeqWc_003D[0] << 24) | (_0023_003DzYtBeqWc_003D[2] << 8) | (_0023_003DzYtBeqWc_003D[1] << 16) | _0023_003DzYtBeqWc_003D[3]);
	}

	public long _0023_003Dz64uo15ku_0024z7ztZ3zr1YEOseZLWkyMkaqpiquz28_003D()
	{
		if (7u != 0)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(8);
		}
		byte[] array = _0023_003DzYtBeqWc_003D;
		byte[] array2;
		if (7u != 0)
		{
			array2 = array;
		}
		return (uint)(array2[3] | (array2[6] << 8) | (array2[7] << 24) | (array2[2] << 16)) | ((long)((array2[1] << 16) | (array2[5] << 8) | array2[0] | (array2[4] << 24)) << 32);
	}

	public ulong _0023_003DzYF3cqKGcxlTPk3RQwT3xZGdB5Kd8V61yKg_003D_003D()
	{
		if (true)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(8);
		}
		byte[] array = _0023_003DzYtBeqWc_003D;
		byte[] array2;
		if (3u != 0)
		{
			array2 = array;
		}
		return (ulong)((uint)(array2[0] | (array2[2] << 16) | (array2[1] << 24) | (array2[6] << 8)) | ((long)((array2[7] << 16) | (array2[5] << 8) | (array2[3] << 24) | array2[4]) << 32));
	}

	public short _0023_003Dzictwks0IUtzTszVHiEckkDa9_0024weyhMFtn_0024nxLxg_003D()
	{
		if (7u != 0)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(2);
		}
		byte[] array = _0023_003DzYtBeqWc_003D;
		byte[] array2;
		if (7u != 0)
		{
			array2 = array;
		}
		return (short)((array2[0] << 8) | array2[1]);
	}

	public ushort _0023_003DzX3nTeXxnGe2XbNRipoa9QvyC8GZSwBcGoA_003D_003D()
	{
		if (2u != 0)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(2);
		}
		byte[] array = _0023_003DzYtBeqWc_003D;
		byte[] array2;
		if (true)
		{
			array2 = array;
		}
		return (ushort)((array2[0] << 8) | array2[1]);
	}

	private byte[] _0023_003DziiYetCUcsQ5xDjoHOKOFOgxtQQB979MShQ_003D_003D()
	{
		byte[] array = _0023_003DzJMv5LHg_003D;
		byte[] array2;
		if (true)
		{
			array2 = array;
		}
		if (array2 == null)
		{
			byte[] array3 = new byte[16];
			if (8u != 0)
			{
				array2 = array3;
			}
			if (uint.MaxValue != 0)
			{
				_0023_003DzJMv5LHg_003D = array3;
			}
		}
		return array2;
	}

	public float _0023_003DzqFfMHwgEMA2S4kOxpckpcMR_WvUB()
	{
		if (0 == 0)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(4);
		}
		byte[] array = _0023_003DzYtBeqWc_003D;
		byte[] array2;
		if (4u != 0)
		{
			array2 = array;
		}
		byte[] array3 = _0023_003DziiYetCUcsQ5xDjoHOKOFOgxtQQB979MShQ_003D_003D();
		byte[] array4;
		if (5u != 0)
		{
			array4 = array3;
		}
		array4[0] = array2[3];
		array4[1] = array2[0];
		array4[3] = array2[1];
		array4[2] = array2[2];
		return _0023_003Dzs1vyWiUiy8lo6OcdZpQ9R1Tv_0024dFqD6dKLf40jHU_003D(array4).ReadSingle();
	}

	public double _0023_003DzxTHAL0_0024cuB_0024C2csRqIKgYsjq53CplnYO1uGBhOds195G()
	{
		if (4u != 0)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(8);
		}
		byte[] array = _0023_003DzYtBeqWc_003D;
		byte[] array2;
		if (2u != 0)
		{
			array2 = array;
		}
		byte[] array3 = _0023_003DziiYetCUcsQ5xDjoHOKOFOgxtQQB979MShQ_003D_003D();
		byte[] array4 = default(byte[]);
		if (0 == 0)
		{
			array4 = array3;
		}
		array4[2] = array2[2];
		array4[6] = array2[3];
		array4[4] = array2[0];
		array4[7] = array2[6];
		array4[3] = array2[1];
		array4[1] = array2[4];
		array4[0] = array2[5];
		array4[5] = array2[7];
		return _0023_003Dzs1vyWiUiy8lo6OcdZpQ9R1Tv_0024dFqD6dKLf40jHU_003D(array4).ReadDouble();
	}

	public decimal _0023_003DzI2GiGkmcNgM4UEec2Ypo5lHpZ5gtN0TUZ8EwskA_003D()
	{
		if (0 == 0)
		{
			_0023_003DzuurwOauPg5bdg2GljBqE_0024rmmkKBFqR7OWgVCxL8_003D(16);
		}
		byte[] array = _0023_003DzYtBeqWc_003D;
		byte[] array2;
		if (2u != 0)
		{
			array2 = array;
		}
		byte[] array3 = _0023_003DziiYetCUcsQ5xDjoHOKOFOgxtQQB979MShQ_003D_003D();
		array3[3] = array2[0];
		array3[11] = array2[1];
		array3[10] = array2[4];
		array3[0] = array2[3];
		array3[9] = array2[5];
		array3[8] = array2[7];
		array3[1] = array2[15];
		array3[12] = array2[10];
		array3[14] = array2[6];
		array3[15] = array2[9];
		array3[7] = array2[11];
		array3[5] = array2[8];
		array3[4] = array2[2];
		array3[13] = array2[12];
		array3[6] = array2[13];
		array3[2] = array2[14];
		return _0023_003Dzo2BGK_0024cPolx0mWS9KW8dRpWAmDxjDd4OxoBWyEE_003D(array3);
	}

	private BinaryReader _0023_003Dzs1vyWiUiy8lo6OcdZpQ9R1Tv_0024dFqD6dKLf40jHU_003D(byte[] _0023_003DzizBjOuE_003D)
	{
		MemoryStream memoryStream = _0023_003DzsA64e3Q_003D;
		MemoryStream memoryStream2;
		if (4u != 0)
		{
			memoryStream2 = memoryStream;
		}
		BinaryReader binaryReader = _0023_003DzIgpgVjY_003D;
		BinaryReader binaryReader2;
		if (8u != 0)
		{
			binaryReader2 = binaryReader;
		}
		if (memoryStream2 == null)
		{
			MemoryStream memoryStream3 = new MemoryStream(8);
			if (true)
			{
				memoryStream2 = memoryStream3;
			}
			_0023_003DzsA64e3Q_003D = memoryStream3;
			binaryReader2 = (_0023_003DzIgpgVjY_003D = new BinaryReader(memoryStream2));
		}
		else
		{
			binaryReader2.BaseStream.Position = 0L;
		}
		memoryStream2.Write(_0023_003DzizBjOuE_003D, 0, _0023_003DzizBjOuE_003D.Length);
		memoryStream2.Position = 0L;
		return binaryReader2;
	}
}
