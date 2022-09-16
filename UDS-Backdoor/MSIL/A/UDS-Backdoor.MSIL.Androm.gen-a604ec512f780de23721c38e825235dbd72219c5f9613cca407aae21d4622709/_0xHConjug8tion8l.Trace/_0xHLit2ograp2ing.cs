#define TRACE
using System.Diagnostics;
using _0xHRightfulne33e3;

namespace _0xHConjug8tion8l.Trace;

public sealed class _0xHLit2ograp2ing
{
	private readonly string _0xHBedrive3;

	private static readonly SourceSwitch _0xHA00ixations;

	private static readonly TraceSource _0xHMo4des;

	public static TraceListenerCollection _0xHSubt7l7ns => _0xHMo4des.Listeners;

	static _0xHLit2ograp2ing()
	{
		_0xHA00ixations = new SourceSwitch("_0xHConjug8tion8lTraceLevel", $"{SourceLevels.Off}");
		_0xHMo4des = new TraceSource("_0xHConjug8tion8l_0xHLit2ograp2ing")
		{
			Switch = _0xHA00ixations
		};
	}

	public _0xHLit2ograp2ing(_0xHCy4oly4ic component)
	{
		_0xHBedrive3 = component.ToString();
	}

	[Conditional("DEBUG")]
	public void _0xHFavis4(string _0xH2ucently)
	{
		_0xH3hebec(TraceEventType.Verbose, _0xH2ucently);
	}

	public void _0xHSymbol5zed(string _0xHLasso3s)
	{
		_0xH3hebec(TraceEventType.Information, _0xHLasso3s);
	}

	public void _0xH7conomized(string _0xHSentr5es)
	{
		_0xH3hebec(TraceEventType.Error, _0xHSentr5es);
	}

	private void _0xH3hebec(TraceEventType _0xHGrabble7, string _0xH8egaton)
	{
		if (_0xHA00ixations.ShouldTrace(_0xHGrabble7))
		{
			_0xHMo4des.TraceData(_0xHGrabble7, 0, _0xHBedrive3 + ": " + _0xH8egaton);
		}
	}
}
