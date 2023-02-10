using System;

internal static class _0023_003DqT016WyaBj2QJHvKmQ9vZQB7YI5vHJ_0024l_0024uitdTOUe3rw_003D
{
	public static Type _0023_003DzsSxjVerC9iP_jAiCl6LBnovDcObI(Type _0023_003DzizBjOuE_003D)
	{
		_ = 0;
		if (8 == 0)
		{
		}
		if (!_0023_003DzizBjOuE_003D.IsByRef)
		{
			_ = 4;
			if (2 == 0)
			{
			}
			if (!_0023_003DzizBjOuE_003D.IsArray)
			{
				_ = 2;
				if (5 == 0)
				{
				}
				if (!_0023_003DzizBjOuE_003D.IsPointer)
				{
					return _0023_003DzizBjOuE_003D;
				}
			}
		}
		return _0023_003DzsSxjVerC9iP_jAiCl6LBnovDcObI(_0023_003DzizBjOuE_003D.GetElementType());
	}

	public static Type _0023_003DzMAsAdIs6GtrSYE5MHBMFWVy2VKI5(Type _0023_003DzizBjOuE_003D)
	{
		if (_0023_003DzizBjOuE_003D.HasElementType && !_0023_003DzizBjOuE_003D.IsArray)
		{
			Type? elementType = _0023_003DzizBjOuE_003D.GetElementType();
			if (2u != 0)
			{
				_0023_003DzizBjOuE_003D = elementType;
			}
		}
		return _0023_003DzizBjOuE_003D;
	}

	public static global::_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D<_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D> _0023_003DzBcqBx1sbmH5tQ44wZTLY69rs0N7GbBdt1r0Xxbg_003D(Type _0023_003DzizBjOuE_003D)
	{
		global::_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D<_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D> obj = new global::_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D<_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D>();
		global::_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D<_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D> _0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2;
		if (uint.MaxValue != 0)
		{
			_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2 = obj;
		}
		Type type;
		if (4u != 0)
		{
			type = _0023_003DzizBjOuE_003D;
		}
		while (true)
		{
			if (type.IsArray)
			{
				_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D _0023_003DzizBjOuE_003D2 = default(_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D);
				if (7u != 0)
				{
					_0023_003DzizBjOuE_003D2._0023_003DzizBjOuE_003D = 0;
				}
				_0023_003DzizBjOuE_003D2._0023_003DzYtBeqWc_003D = type.GetArrayRank();
				_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2._0023_003DzEYH8cWwGDPA10ZjObr14wNocDH6fUEkAWWIKXAM_003D(_0023_003DzizBjOuE_003D2);
			}
			else if (type.IsByRef)
			{
				_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2._0023_003DzEYH8cWwGDPA10ZjObr14wNocDH6fUEkAWWIKXAM_003D(new _0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D
				{
					_0023_003DzizBjOuE_003D = 2
				});
			}
			else
			{
				if (!type.IsPointer)
				{
					break;
				}
				_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2._0023_003DzEYH8cWwGDPA10ZjObr14wNocDH6fUEkAWWIKXAM_003D(new _0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D
				{
					_0023_003DzizBjOuE_003D = 1
				});
			}
			type = type.GetElementType();
		}
		return _0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2;
	}

	public static global::_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D<_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D> _0023_003DzLexovrEquePFSIaSs4FDCnFBgcsjPHdaxA_003D_003D(string _0023_003DzizBjOuE_003D)
	{
		string text;
		if (6u != 0)
		{
			text = _0023_003DzizBjOuE_003D;
		}
		global::_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D<_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D> obj = new global::_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D<_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D>();
		global::_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D<_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D> _0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2;
		if (4u != 0)
		{
			_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2 = obj;
		}
		while (true)
		{
			if (text.EndsWith(_0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366345913), StringComparison.Ordinal))
			{
				_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D _0023_003DzizBjOuE_003D2 = default(_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D);
				if (0 == 0)
				{
					_0023_003DzizBjOuE_003D2._0023_003DzizBjOuE_003D = 2;
				}
				_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2._0023_003DzEYH8cWwGDPA10ZjObr14wNocDH6fUEkAWWIKXAM_003D(_0023_003DzizBjOuE_003D2);
				string text2 = text.Substring(0, text.Length - 1);
				if (0 == 0)
				{
					text = text2;
				}
				continue;
			}
			if (text.EndsWith(_0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366345905), StringComparison.Ordinal))
			{
				_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2._0023_003DzEYH8cWwGDPA10ZjObr14wNocDH6fUEkAWWIKXAM_003D(new _0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D
				{
					_0023_003DzizBjOuE_003D = 1
				});
				text = text.Substring(0, text.Length - 1);
				continue;
			}
			if (text.EndsWith(_0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366345897), StringComparison.Ordinal))
			{
				_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2._0023_003DzEYH8cWwGDPA10ZjObr14wNocDH6fUEkAWWIKXAM_003D(new _0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D
				{
					_0023_003DzizBjOuE_003D = 0,
					_0023_003DzYtBeqWc_003D = 1
				});
				text = text.Substring(0, text.Length - 2);
				continue;
			}
			if (!text.EndsWith(_0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366345888), StringComparison.Ordinal))
			{
				break;
			}
			int num = 1;
			int num2 = -1;
			for (int num3 = text.Length - 2; num3 >= 0; num3--)
			{
				switch (text[num3])
				{
				case ',':
					num++;
					break;
				case '[':
					num2 = num3;
					num3 = -1;
					break;
				default:
					throw new InvalidOperationException(_0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366345883));
				}
			}
			if (num2 < 0)
			{
				throw new InvalidOperationException(_0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366345865));
			}
			text = text.Substring(0, num2);
			_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2._0023_003DzEYH8cWwGDPA10ZjObr14wNocDH6fUEkAWWIKXAM_003D(new _0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D
			{
				_0023_003DzizBjOuE_003D = 0,
				_0023_003DzYtBeqWc_003D = num
			});
		}
		return _0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D2;
	}

	public static Type _0023_003Dzzvbc5oqo_0024ODcIo9XxFy8PfDw7FLAVf7UUz7BSWuff6Z6(Type _0023_003DzizBjOuE_003D, global::_0023_003DqiNLsFego6w3yVx1lNAI_0024LkUe_Z6FCjJ4I3L073P6mm8_003D<_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D> _0023_003DzYtBeqWc_003D)
	{
		Type type;
		if (5u != 0)
		{
			type = _0023_003DzizBjOuE_003D;
		}
		_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D _0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D2 = default(_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D);
		while (_0023_003DzYtBeqWc_003D.Count > 0)
		{
			_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D obj = _0023_003DzYtBeqWc_003D._0023_003DzRwZDUQV3h1kKaAv0FYFXB4J5e5MjIMZlLWAXXNvjO5E2();
			if (0 == 0)
			{
				_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D2 = obj;
			}
			int _0023_003DzizBjOuE_003D2 = _0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D2._0023_003DzizBjOuE_003D;
			int num;
			if (5u != 0)
			{
				num = _0023_003DzizBjOuE_003D2;
			}
			switch (num)
			{
			case 0:
				type = ((_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D2._0023_003DzYtBeqWc_003D != 1) ? type.MakeArrayType(_0023_003Dqkc_cGMtigGMwrl3GY9kPZNfAQFVkuexNvqQ0aUPdfIs_003D2._0023_003DzYtBeqWc_003D) : type.MakeArrayType());
				break;
			case 2:
				type = type.MakeByRefType();
				break;
			case 1:
				type = type.MakePointerType();
				break;
			}
		}
		return type;
	}
}
