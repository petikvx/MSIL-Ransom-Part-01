using System.IO;

namespace _003F1_003F;

internal class _003F14_003F
{
	internal static readonly byte[] _003F269_003F;

	static _003F14_003F()
	{
		if (_003F269_003F != null)
		{
			return;
		}
		while (true)
		{
			switch (5)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string _003F218_003F = _003F305_003F._003F306_003F("]ŀɀ\u0335ѝԱ٥ݪ");
			byte[] array = _003F92_003F._003F157_003F(_003F218_003F);
			_003F218_003F = _003F34_003F._003F158_003F(_003F52_003F._003F157_003F(), array, 0, array.Length);
			Stream _003F173_003F = _003F69_003F._003F158_003F(_003F59_003F._003F157_003F(), _003F218_003F);
			_003F269_003F = _003F15_003F._003F127_003F(0, _003F173_003F);
			return;
		}
	}

	internal static string _003F124_003F(int _003F172_003F)
	{
		int num = 0;
		if ((_003F269_003F[_003F172_003F] & 0x80) == 0)
		{
			while (true)
			{
				switch (7)
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
			num = _003F269_003F[_003F172_003F];
			_003F172_003F++;
		}
		else if ((_003F269_003F[_003F172_003F] & 0x40) == 0)
		{
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (_003F269_003F[_003F172_003F] & -129) << 8;
			num |= _003F269_003F[_003F172_003F + 1];
			_003F172_003F += 2;
		}
		else
		{
			num = (_003F269_003F[_003F172_003F] & -193) << 24;
			num |= _003F269_003F[_003F172_003F + 1] << 16;
			num |= _003F269_003F[_003F172_003F + 2] << 8;
			num |= _003F269_003F[_003F172_003F + 3];
			_003F172_003F += 4;
		}
		if (num < 1)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					break;
				default:
					return string.Empty;
				}
			}
		}
		string _003F218_003F = _003F34_003F._003F158_003F(_003F85_003F._003F157_003F(), _003F269_003F, _003F172_003F, num);
		return _003F44_003F._003F157_003F(_003F218_003F);
	}
}
