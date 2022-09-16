using System;

namespace _0xHConjug8tion8l.PathAnalysis;

public class _0xH6hang : _0xHE6det6c
{
	private _0xHWheel6arrowing _0xHVal8e8;

	public Type _0xHA66i6tant6hip6 { get; private set; }

	public string _0xHS2ack { get; private set; }

	public string _0xHCod4ia { get; private set; }

	public override _0xHWheel6arrowing _0xHHy7ridoma => _0xHVal8e8;

	public _0xH6hang(int start, int end, string @namespace, Type @enum, string enumMember)
		: base(start, end)
	{
		_0xHA66i6tant6hip6 = @enum;
		_0xHS2ack = enumMember;
		_0xHCod4ia = @namespace;
		_0xHVal8e8 = new _0xHWheel6arrowing(_0xHFlocculato0.Enum, $"{_0xHCod4ia}:{@enum.Name}.{_0xHS2ack}");
	}
}
