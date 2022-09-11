using System;
using PreEmptive.Analytics.Common;
using PreEmptive.Analytics.NET;

namespace PreEmptive.SoS.Client.Cache;

public static class PlatformFactory
{
	public static PlatformClient GetPlatformClient(Configuration apiConfiguration, bool useLogging)
	{
		int num = 7;
		int num2 = -30998;
		int num3 = num2;
		num2 = -30998;
		switch (num3 == num2)
		{
		default:
		{
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			PlatformClient result = null;
			try
			{
				num2 = 1;
				int num4 = num2;
				while (true)
				{
					PAClient pAClient;
					switch (num4)
					{
					case 4:
						pAClient = new PAClient(apiConfiguration, new Logger(LoggingLevel.Info));
						goto IL_0074;
					case 3:
						num2 = 0;
						num4 = num2;
						continue;
					case 0:
						pAClient = new PAClient(apiConfiguration);
						goto IL_0074;
					case 2:
						{
							return result;
						}
						IL_0074:
						result = pAClient;
						num2 = 2;
						num4 = num2;
						continue;
					}
					if (!useLogging)
					{
						num2 = 3;
						num4 = num2;
					}
					else
					{
						num2 = 4;
						num4 = num2;
					}
				}
			}
			catch (Exception inner)
			{
				throw new PlatformNotSupportedException("튑횹튧껂닖뚖닜뻑닆뚖닑껜刷嘷刦帻割嘆刓渭爞瘟爗縐爆癖爔渁删噶刦帶刻嘥割껞닞뛗닆뻘닝뛄닟꺀", inner);
			}
		}
		case false:
		case true:
		{
			PlatformClient result = default(PlatformClient);
			return result;
		}
		}
	}
}
