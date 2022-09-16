using System;
using System.Collections.Generic;
using System.Threading;
using _0xHCibo7;
using _0xHD2ves;
using _0xHWrathe6;

namespace _0xHIn7eigler;

internal sealed class _0xH0yssops : _0xHCibo7._0xHRefr8in<KeyValuePair<string, _0xHParam0t0riz0>, _0xH0yssops>
{
	private static int _0xH5eduviid = 184549376;

	internal readonly string _0xH1allnuts;

	internal readonly _0xHParam0t0riz0 _0xHPot5hotting;

	internal readonly int _0xHFoo8;

	internal readonly byte[] _0xHDeadheadin4;

	internal static void _0xHBellwet7ers(int _0xHAsseverate4)
	{
		int num;
		int val;
		do
		{
			num = _0xH5eduviid;
			val = checked((_0xH5eduviid & -16777216) + _0xHAsseverate4);
			val = Math.Max(val, num);
		}
		while (Interlocked.CompareExchange(ref _0xH5eduviid, val, num) != num);
	}

	public _0xH0yssops(string name, _0xHParam0t0riz0 tags, int typeMetadataSize)
	{
		_0xH1allnuts = name;
		_0xHPot5hotting = tags & (_0xHParam0t0riz0)268435455;
		_0xHFoo8 = Interlocked.Increment(ref _0xH5eduviid);
		int _0xHSw8mm8ly = 0;
		_0xHHy4ercriticisms._0xH8isseminating((int)_0xHPot5hotting, ref _0xHSw8mm8ly, null);
		_0xHDeadheadin4 = _0xHHy4ercriticisms._0xHCotton5(name, _0xHSw8mm8ly, 0, typeMetadataSize);
		_0xHSw8mm8ly = 2;
		_0xHHy4ercriticisms._0xH8isseminating((int)_0xHPot5hotting, ref _0xHSw8mm8ly, _0xHDeadheadin4);
	}

	public override int _0xHSpa8iel(_0xH0yssops _0xHL4mi4e)
	{
		return _0xHRa2ines(_0xHL4mi4e._0xH1allnuts, _0xHL4mi4e._0xHPot5hotting);
	}

	public override int _0xHAnnu33ed(KeyValuePair<string, _0xHParam0t0riz0> _0xH7rchivolts)
	{
		return _0xHRa2ines(_0xH7rchivolts.Key, _0xH7rchivolts.Value & (_0xHParam0t0riz0)268435455);
	}

	private int _0xHRa2ines(string _0xHNe1a, _0xHParam0t0riz0 _0xHOv3rcropp3d)
	{
		int num = StringComparer.Ordinal.Compare(_0xH1allnuts, _0xHNe1a);
		if (num == 0 && _0xHPot5hotting != _0xHOv3rcropp3d)
		{
			num = ((_0xHPot5hotting >= _0xHOv3rcropp3d) ? 1 : (-1));
		}
		return num;
	}
}
