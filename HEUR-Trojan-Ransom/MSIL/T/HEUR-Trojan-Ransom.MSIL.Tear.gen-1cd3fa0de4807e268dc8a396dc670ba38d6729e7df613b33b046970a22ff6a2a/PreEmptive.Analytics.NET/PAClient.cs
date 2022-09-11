using System;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common;

namespace PreEmptive.Analytics.NET;

public class PAClient : PlatformClient
{
	protected override IPlatform GetNewPlatform()
	{
		if (1 == 0)
		{
		}
		int num = 445;
		int num2 = num;
		num = 445;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			return new Platform(base.StartupConfiguration, base.Logger);
		}
	}

	public PAClient(Guid companyID, Guid applicationID, [Optional] ILogger logger)
		: base(companyID, applicationID, logger)
	{
	}

	public PAClient(string companyID, string applicationID, [Optional] ILogger logger)
		: base(companyID, applicationID, logger)
	{
	}

	public PAClient(Configuration config, [Optional] ILogger logger)
		: base(config, logger)
	{
	}
}
