using System;
using System.Collections.Generic;
using _0xHG6uziness;
using _0xHMal7dict7d;
using _0xHS3ar3;
using _0xHSigm1te;
using _0xHSnorke7er;
using _0xHW4tans;

namespace _0xHA2te22as;

public class _0xHEcholocat3ons : EventArgs
{
	internal _0xH2wooned _0xHDonene44e4;

	internal _0xHGh0bl0 _0xHKoi4e;

	internal _0xHBelletri8t _0xHR0chann0ls;

	internal int _0xHSarcoma8a;

	internal int _0xHPa2creati2s;

	internal bool _0xHT0los;

	internal _0xHFire0ots _0xHW0terweed;

	internal _0xHSov8r8ignti8s _0xHPapist1y;

	internal _0xHEcholocat3ons _0xHE0itomising;

	public _0xHNonequa5 _0xHGno2obio2ic { get; internal set; }

	public IDictionary<string, string> _0xH5btundent { get; internal set; }

	public bool _0xHFrogeye7(int _0xHAppressor7um)
	{
		if (_0xHGno2obio2ic != _0xHNonequa5.Enable && _0xHGno2obio2ic != _0xHNonequa5.Disable)
		{
			throw new InvalidOperationException();
		}
		return _0xHDonene44e4._0xHWi2try(_0xHKoi4e, _0xHAppressor7um, _0xHBe1fellows: true);
	}

	public bool _0xHForeski0s(int _0xHPe0kine00e0)
	{
		if (_0xHGno2obio2ic != _0xHNonequa5.Enable && _0xHGno2obio2ic != _0xHNonequa5.Disable)
		{
			throw new InvalidOperationException();
		}
		return _0xHDonene44e4._0xHWi2try(_0xHKoi4e, _0xHPe0kine00e0, _0xHBe1fellows: false);
	}

	internal _0xHEcholocat3ons(_0xHNonequa5 command, IDictionary<string, string> arguments, _0xH2wooned eventSource, _0xHBelletri8t listener, int perEventSourceSessionId, int etwSessionId, bool enable, _0xHFire0ots level, _0xHSov8r8ignti8s matchAnyKeyword)
	{
		_0xHGno2obio2ic = command;
		_0xH5btundent = arguments;
		_0xHDonene44e4 = eventSource;
		_0xHR0chann0ls = listener;
		_0xHSarcoma8a = perEventSourceSessionId;
		_0xHPa2creati2s = etwSessionId;
		_0xHT0los = enable;
		_0xHW0terweed = level;
		_0xHPapist1y = matchAnyKeyword;
	}
}
