using System;
using System.Threading;

internal class wVkMjuDdoqsuBiJSddiuKTaEHEcjA : IAsyncResult
{
	internal bool fQxhtpcOlqmUoKBSPhjjwdtDqNnU = (byte)_003CModule_003E.dpxHirlQuRSzbXiBGQArohLuCnMj<int>(3943964843u) != 0;

	private object QRAuLlGiseJFsbMfoeNhgeDkRQXCb;

	private ManualResetEvent ZWNPoLZWwsUmFBSvooKbHaKjjPty;

	public bool IsCompleted => fQxhtpcOlqmUoKBSPhjjwdtDqNnU;

	public bool CompletedSynchronously => (byte)_003CModule_003E.WgpDFIDBthfUHHPzdxdaGkTjtimi<int>(732702483u) != 0;

	public object AsyncState => QRAuLlGiseJFsbMfoeNhgeDkRQXCb;

	public WaitHandle AsyncWaitHandle
	{
		get
		{
			if (ZWNPoLZWwsUmFBSvooKbHaKjjPty == null)
			{
				while (true)
				{
					int num = -1837109403;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-((~num2 - 549488358) * 1118978863) - 1483507393)) % 3u)
						{
						case 1u:
							ZWNPoLZWwsUmFBSvooKbHaKjjPty = wVkMjuDdoqsuBiJSddiuKTaEHEcjA.eIaAzqzoDOdbtKGbJLnmAyfNjkJFA((byte)_003CModule_003E.YldckkxrnqITblrqfUdHgXoRQPFq<int>(723557330u) != 0);
							num = (int)(num3 * 478323336) ^ -51964755;
							continue;
						case 0u:
							break;
						default:
							goto end_IL_0059;
						}
						break;
					}
					continue;
					end_IL_0059:
					break;
				}
			}
			return ZWNPoLZWwsUmFBSvooKbHaKjjPty;
		}
	}

	internal void auizcnQcLbOtxrnOAHkdkLGCtTIiA(object object_0)
	{
		QRAuLlGiseJFsbMfoeNhgeDkRQXCb = object_0;
		fQxhtpcOlqmUoKBSPhjjwdtDqNnU = (byte)_003CModule_003E.InSeajbqYmMBLFjcDEnfkUXlgyLtB<int>(3384323388u) != 0;
		if (ZWNPoLZWwsUmFBSvooKbHaKjjPty == null)
		{
			return;
		}
		while (true)
		{
			int num = 2059739196;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-(-(~num2) + -1593567151)))) % 3u)
				{
				case 2u:
					goto IL_0021;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0021:
				wVkMjuDdoqsuBiJSddiuKTaEHEcjA.qdhskjtEYAeoCRLuwRsIBOgHPDYi((EventWaitHandle)ZWNPoLZWwsUmFBSvooKbHaKjjPty);
				num = ((int)num3 * -2011896089) ^ -2009034315;
			}
		}
	}

	internal void QTAfrBxcqXqdFLQsMkvBxjNecYiS()
	{
		QRAuLlGiseJFsbMfoeNhgeDkRQXCb = null;
		fQxhtpcOlqmUoKBSPhjjwdtDqNnU = (byte)_003CModule_003E.ODkbfxpVhRhqGtIspNCsSBULKrV<int>(2846573297u) != 0;
		while (true)
		{
			int num = -829523051;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~num2 - 1787764759) * -712789595)) % 4u)
				{
				case 3u:
				{
					int num4;
					int num5;
					if (ZWNPoLZWwsUmFBSvooKbHaKjjPty == null)
					{
						num4 = 1621742077;
						num5 = 1621742077;
					}
					else
					{
						num4 = 822454328;
						num5 = 822454328;
					}
					num = num4 ^ ((int)num3 * -467660870);
					continue;
				}
				case 2u:
					wVkMjuDdoqsuBiJSddiuKTaEHEcjA.CxZpatpJSrkufgCoEwMDXJjRLYgj((EventWaitHandle)ZWNPoLZWwsUmFBSvooKbHaKjjPty);
					num = ((int)num3 * -1413980544) ^ -1554705989;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	static bool qdhskjtEYAeoCRLuwRsIBOgHPDYi(EventWaitHandle eventWaitHandle_0)
	{
		return eventWaitHandle_0.Reset();
	}

	static bool CxZpatpJSrkufgCoEwMDXJjRLYgj(EventWaitHandle eventWaitHandle_0)
	{
		return eventWaitHandle_0.Set();
	}

	static ManualResetEvent eIaAzqzoDOdbtKGbJLnmAyfNjkJFA(bool bool_0)
	{
		return new ManualResetEvent(bool_0);
	}
}
