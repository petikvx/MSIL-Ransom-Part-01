using System;
using NanoCore.ClientPluginHost;

public sealed class GClass7 : IClientLoggingHost
{
	public GClass3 gclass3_0;

	public GClass7(GClass3 gclass3_1)
	{
		gclass3_0 = gclass3_1;
	}

	public void LogClientException(Exception exception_0, string string_0)
	{
		Class8.smethod_85(gclass3_0, exception_0, string_0);
	}

	public void LogClientMessage(string string_0)
	{
		Class8.smethod_87(string_0);
	}
}
