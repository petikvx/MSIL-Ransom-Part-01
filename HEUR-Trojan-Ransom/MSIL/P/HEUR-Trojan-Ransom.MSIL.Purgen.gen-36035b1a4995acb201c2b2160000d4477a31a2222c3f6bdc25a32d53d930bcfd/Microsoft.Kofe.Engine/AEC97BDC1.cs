using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class AEC97BDC1 : BE9A0B98B, IDebugExpressionEvaluationCompleteEvent2
{
	public const string FDFA8A7F4 = "c0e13a85-238a-4800-8315-d947c960a843";

	private IDebugExpression2 B249EFE61;

	private IDebugProperty2 A6794E8F4;

	internal AEC97BDC1(IDebugExpression2 expr, IDebugProperty2 result)
	{
		B249EFE61 = expr;
		A6794E8F4 = result;
	}

	public int F7144B07D(out IDebugExpression2 A225C24F5)
	{
		A225C24F5 = B249EFE61;
		return 0;
	}

	public int E3A2FBAC9(out IDebugProperty2 BB14712A8)
	{
		BB14712A8 = A6794E8F4;
		return 0;
	}
}
