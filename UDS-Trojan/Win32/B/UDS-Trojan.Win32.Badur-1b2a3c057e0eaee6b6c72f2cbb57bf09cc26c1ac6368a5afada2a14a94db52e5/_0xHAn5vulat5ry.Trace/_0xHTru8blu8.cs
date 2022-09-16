#define TRACE
using System.Diagnostics;
using _0xH1reviced;

namespace _0xHAn5vulat5ry.Trace;

public sealed class _0xHTru8blu8
{
	private readonly string _0xHTeache2;

	private static readonly SourceSwitch _0xHEu5aine;

	private static readonly TraceSource _0xHSter1l1s1ng;

	public static TraceListenerCollection _0xHSu8acutely => _0xHSter1l1s1ng.Listeners;

	static _0xHTru8blu8()
	{
		_0xHEu5aine = new SourceSwitch("_0xHAn5vulat5ryTraceLevel", $"{SourceLevels.Off}");
		_0xHSter1l1s1ng = new TraceSource("_0xHAn5vulat5ry_0xHTru8blu8")
		{
			Switch = _0xHEu5aine
		};
	}

	public _0xHTru8blu8(_0xHOch8rous component)
	{
		_0xHTeache2 = component.ToString();
	}

	[Conditional("DEBUG")]
	public void _0xHF3etwo3k(string _0xHWom7n)
	{
		_0xHDan0ing(TraceEventType.Verbose, _0xHWom7n);
	}

	public void _0xHChim6erisms(string _0xH6yperparasitic)
	{
		_0xHDan0ing(TraceEventType.Information, _0xH6yperparasitic);
	}

	public void _0xHConf3ated(string _0xHNutga77)
	{
		_0xHDan0ing(TraceEventType.Error, _0xHNutga77);
	}

	private void _0xHDan0ing(TraceEventType _0xHInci2ion, string _0xHAtheroge5esis)
	{
		if (_0xHEu5aine.ShouldTrace(_0xHInci2ion))
		{
			_0xHSter1l1s1ng.TraceData(_0xHInci2ion, 0, _0xHTeache2 + ": " + _0xHAtheroge5esis);
		}
	}
}
