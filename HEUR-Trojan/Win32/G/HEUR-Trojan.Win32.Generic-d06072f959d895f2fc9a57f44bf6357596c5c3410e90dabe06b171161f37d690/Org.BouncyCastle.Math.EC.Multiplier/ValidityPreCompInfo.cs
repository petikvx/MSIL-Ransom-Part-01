namespace Org.BouncyCastle.Math.EC.Multiplier;

internal class ValidityPreCompInfo : PreCompInfo
{
	internal static readonly string PRECOMP_NAME = "bc_validity";

	private bool failed;

	private bool curveEquationPassed;

	private bool orderPassed;

	internal bool HasFailed()
	{
		return failed;
	}

	internal void ReportFailed()
	{
		failed = true;
	}

	internal bool HasCurveEquationPassed()
	{
		return curveEquationPassed;
	}

	internal void ReportCurveEquationPassed()
	{
		curveEquationPassed = true;
	}

	internal bool HasOrderPassed()
	{
		return orderPassed;
	}

	internal void ReportOrderPassed()
	{
		orderPassed = true;
	}
}
