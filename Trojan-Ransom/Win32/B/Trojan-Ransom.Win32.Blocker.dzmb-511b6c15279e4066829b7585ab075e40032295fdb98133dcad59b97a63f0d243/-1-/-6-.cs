using System;
using System.IO;
using System.Reflection;

namespace _003F1_003F;

internal class _003F6_003F
{
	private static readonly Assembly _003F254_003F;

	static _003F6_003F()
	{
		_003F60_003F._003F158_003F(_003F48_003F._003F157_003F(), _003F116_003F);
		_003F71_003F._003F158_003F(_003F48_003F._003F157_003F(), _003F114_003F);
		Assembly _003F162_003F = _003F59_003F._003F157_003F();
		string _003F218_003F = _003F115_003F(_003F162_003F);
		_003F254_003F = _003F98_003F._003F157_003F(_003F218_003F);
	}

	internal static void _003F113_003F()
	{
	}

	private static Assembly _003F114_003F(object _003F160_003F, ResolveEventArgs _003F161_003F)
	{
		Assembly assembly = _003F59_003F._003F157_003F();
		string _003F218_003F = _003F115_003F(assembly);
		if (_003F63_003F._003F158_003F(_003F102_003F._003F158_003F(_003F161_003F), _003F218_003F))
		{
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					Stream _003F173_003F = _003F69_003F._003F158_003F(assembly, _003F218_003F);
					byte[] _003F218_003F2 = _003F15_003F._003F127_003F(0, _003F173_003F);
					return _003F49_003F._003F157_003F(_003F218_003F2);
				}
				}
			}
		}
		return null;
	}

	private static string _003F115_003F(Assembly _003F162_003F)
	{
		string _003F218_003F = _003F40_003F._003F158_003F(_003F162_003F);
		int num = _003F41_003F._003F158_003F(_003F218_003F, ',');
		if (num >= 0)
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			_003F218_003F = _003F81_003F._003F158_003F(_003F218_003F, 0, num);
		}
		return _003F45_003F._003F157_003F(_003F218_003F, '&');
	}

	private static Assembly _003F116_003F(object _003F160_003F, ResolveEventArgs _003F161_003F)
	{
		if ((object)_003F254_003F != null)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					string[] array = _003F38_003F._003F158_003F(_003F254_003F);
					foreach (string _003F218_003F in array)
					{
						if (_003F56_003F._003F157_003F(_003F218_003F, _003F102_003F._003F158_003F(_003F161_003F)))
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									break;
								default:
									return _003F254_003F;
								}
							}
						}
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							break;
						default:
							return null;
						}
					}
				}
				}
			}
		}
		return _003F254_003F;
	}
}
