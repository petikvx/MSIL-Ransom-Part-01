using System;
using System.Threading;

namespace cujkPFWFlD;

internal class cxPHukydGgqv : IAsyncResult
{
	internal bool GY1eWLyVWkNQ = (byte)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(2905113583u) != 0;

	private object QSzx6qxw0cll;

	private ManualResetEvent r3wQPeqxJuKY;

	public bool Kr0vRk6Lon1h => GY1eWLyVWkNQ;

	public bool bhN9QE3LnBPl => (byte)_003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(1565316700u) != 0;

	public object Y3lbvQpKaaPN => QSzx6qxw0cll;

	public WaitHandle WaitHandle_0
	{
		get
		{
			if (r3wQPeqxJuKY == null)
			{
				while (true)
				{
					int num = -1121878430;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-((-835668737 - num2) ^ -31709003) + 1068684857)) % 3u)
						{
						case 2u:
							r3wQPeqxJuKY = cxPHukydGgqv.fNclAZGvPhlsHgtRttbJLQNAeeqU((byte)_003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(3942883017u) != 0);
							num = (int)(num3 * 627648452) ^ -1419162455;
							continue;
						case 0u:
							break;
						default:
							goto end_IL_0058;
						}
						break;
					}
					continue;
					end_IL_0058:
					break;
				}
			}
			return r3wQPeqxJuKY;
		}
	}

	internal void yQZHfZTcRq0u(object X7uKrty6Rilb)
	{
		QSzx6qxw0cll = X7uKrty6Rilb;
		while (true)
		{
			int num = 1299918309;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-1459653067 - ((num2 * 1023991413) ^ 0x72685340 ^ -1762772545) * 474987909)) % 5u)
				{
				case 4u:
					GY1eWLyVWkNQ = (byte)_003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(965178568u) != 0;
					num = ((int)num3 * -403825443) ^ -554957837;
					continue;
				case 2u:
					cxPHukydGgqv.PgyFVefJCvEOTBbzYsFjfORaPMtoA((EventWaitHandle)r3wQPeqxJuKY);
					num = (int)((num3 * 703548115) ^ 0x2792FF21);
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (r3wQPeqxJuKY != null)
					{
						num4 = 1042058794;
						num5 = 1042058794;
					}
					else
					{
						num4 = -726452307;
						num5 = -726452307;
					}
					num = num4 ^ (int)(num3 * 1134142148);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	internal void a9D8zIIsRTqE()
	{
		QSzx6qxw0cll = null;
		while (true)
		{
			int num = -1183619107;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-1829475732 - num2))) % 4u)
				{
				case 2u:
					cxPHukydGgqv.bBKIXkBnrOYRHLmEfmwAaeuwLtFE((EventWaitHandle)r3wQPeqxJuKY);
					num = ((int)num3 * -2021635926) ^ 0x3C64E8D0;
					continue;
				case 1u:
				{
					GY1eWLyVWkNQ = (byte)_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1370470487u) != 0;
					int num4;
					int num5;
					if (r3wQPeqxJuKY != null)
					{
						num4 = -1992266400;
						num5 = -1992266400;
					}
					else
					{
						num4 = 284693338;
						num5 = 284693338;
					}
					num = num4 ^ ((int)num3 * -1817080290);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	static bool PgyFVefJCvEOTBbzYsFjfORaPMtoA(EventWaitHandle eventWaitHandle_0)
	{
		return eventWaitHandle_0.Reset();
	}

	static bool bBKIXkBnrOYRHLmEfmwAaeuwLtFE(EventWaitHandle eventWaitHandle_0)
	{
		return eventWaitHandle_0.Set();
	}

	static ManualResetEvent fNclAZGvPhlsHgtRttbJLQNAeeqU(bool bool_0)
	{
		return new ManualResetEvent(bool_0);
	}
}
