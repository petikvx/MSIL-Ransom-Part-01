using System;
using System.Collections.Generic;
using Microsoft.DebugEngineHost;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class A747D62C3
{
	public const string C5905135C = "VS/Diagnostics/Debugger/Kofe/LaunchFailure";

	public const string B125D6FAB = "VS.Diagnostics.Debugger.Kofe.LaunchFailureResult";

	public const string BA97AFFDD = "VS.Diagnostics.Debugger.Kofe.LaunchFailureCallStack";

	private static string FB2D41AE1(Exception C0597062F)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		JdwpException val = (JdwpException)(object)((C0597062F is JdwpException) ? C0597062F : null);
		if (val != null)
		{
			ErrorCode errorCode = val.ErrorCode;
			return ((object)(ErrorCode)(ref errorCode)).ToString();
		}
		return C0597062F.GetType().ToString();
	}

	public static void B550BC694(Exception EB3CB47CB)
	{
		KeyValuePair<string, object>[] array = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("VS.Diagnostics.Debugger.Kofe.LaunchFailureResult", FB2D41AE1(EB3CB47CB)),
			new KeyValuePair<string, object>("VS.Diagnostics.Debugger.Kofe.LaunchFailureCallStack", EB3CB47CB.StackTrace)
		};
		HostTelemetry.SendEvent("VS/Diagnostics/Debugger/Kofe/LaunchFailure", array);
	}
}
