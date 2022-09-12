using System;

internal sealed class Publisher
{
	internal static Publisher RateExpression;

	[STAThread]
	private static void DestroyPublisher()
	{
		GClass0 gClass = new GClass0();
		string string_ = gClass.method_0("{\"status\":true,\"data\":0.000041302449258564}");
		gClass.method_1(string_);
	}

	internal static bool CheckExpression()
	{
		return RateExpression == null;
	}

	internal static Publisher FillExpression()
	{
		return RateExpression;
	}
}
