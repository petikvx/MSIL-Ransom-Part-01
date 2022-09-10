using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Web.Services.Protocols;
using AFL4jM4v7qa3U8UZUq0;
using EkIJjm7vjs8xMISmTn;
using JeOqkC4MLCaZQFHOROh;
using NCDRxx4R49CZy0gNBsi;
using phhDPt4r3RFhLjHBgju;

namespace whIMhj4tJEjkpHtDJe7;

internal sealed class MIdYYE4f4APnt0t3Mj1
{
	internal static readonly string NLiHHojZ7n;

	private string lScHAX5MFL;

	private string LdOHQsUKIY;

	private IWebProxy nCcHumCfAf;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sDYHDPQOMi(IWebProxy _0020)
	{
		nCcHumCfAf = _0020;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void jUAHkEgNLG(PobY5dLzGESmMLKZEAn _0020)
	{
		//Discarded unreachable code: IL_0079
		if (LdOHQsUKIY == null)
		{
			try
			{
				B9BPuc4UBPhdX9Vdby2 b9BPuc4UBPhdX9Vdby = new B9BPuc4UBPhdX9Vdby2();
				if (nCcHumCfAf == null)
				{
					goto IL_0062;
				}
				int num = 0;
				goto IL_0082;
				IL_00cd:
				((HttpWebClientProtocol)b9BPuc4UBPhdX9Vdby).set_Proxy(nCcHumCfAf);
				num = 1;
				goto IL_0082;
				IL_0062:
				LdOHQsUKIY = b9BPuc4UBPhdX9Vdby.GetServerURL(lScHAX5MFL);
				goto IL_00b1;
				IL_00b1:
				int num2;
				if (LdOHQsUKIY.Length == 0)
				{
					num2 = 5;
					if (true)
					{
						goto IL_0086;
					}
					goto IL_00cd;
				}
				if (LdOHQsUKIY == teuVAA2ghHDQmtOkUp.dYB2ebULO8(48820))
				{
					num = 6;
					goto IL_0082;
				}
				goto end_IL_000b;
				IL_0082:
				num2 = num;
				goto IL_0086;
				IL_0086:
				while (true)
				{
					switch (num2)
					{
					case 3:
					case 5:
						throw new ApplicationException(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48779));
					case 1:
						break;
					default:
						num2 = 4;
						continue;
					case 2:
					case 4:
						goto IL_00b1;
					case 0:
						goto IL_00cd;
					case 6:
						LdOHQsUKIY = NLiHHojZ7n;
						goto end_IL_000b;
					}
					break;
				}
				goto IL_0062;
				end_IL_000b:;
			}
			catch (Exception ex)
			{
				_0020(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48829) + ex.Message);
				return;
			}
		}
		_0020(LdOHQsUKIY.StartsWith(teuVAA2ghHDQmtOkUp.dYB2ebULO8(46376)) ? LdOHQsUKIY : teuVAA2ghHDQmtOkUp.dYB2ebULO8(46318));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void gv2HTZJ5km(byte[] _0020, string _0020, string _0020, string _0020, PobY5dLzGESmMLKZEAn _0020)
	{
		//Discarded unreachable code: IL_0042
		try
		{
			vUOyY94cln1SSUK9aHa vUOyY94cln1SSUK9aHa = new vUOyY94cln1SSUK9aHa(LdOHQsUKIY);
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 2:
					((HttpWebClientProtocol)vUOyY94cln1SSUK9aHa).set_Proxy(nCcHumCfAf);
					num2 = 4;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					if (nCcHumCfAf == null)
					{
						break;
					}
					goto case 1;
				default:
					num2 = 2;
					if (X9ff6qg520wVFJVe4g0())
					{
						continue;
					}
					break;
				case 4:
					break;
				}
				break;
			}
			_0020(vUOyY94cln1SSUK9aHa.UploadReport2(lScHAX5MFL, _0020, _0020, _0020, _0020));
		}
		catch (Exception ex)
		{
			_0020(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48846) + ex.Message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MIdYYE4f4APnt0t3Mj1(string _0020)
	{
		//Discarded unreachable code: IL_0047
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
					num2 = 3;
					if (WRtK5ngACfHVIPp0PIO())
					{
					}
					continue;
				case 4:
					lScHAX5MFL = _0020;
					num = 5;
					break;
				case 1:
				case 3:
					base._002Ector();
					goto case 4;
				default:
					num = 4;
					break;
				case 5:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MIdYYE4f4APnt0t3Mj1()
	{
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		NLiHHojZ7n = teuVAA2ghHDQmtOkUp.dYB2ebULO8(48863);
	}

	internal static bool X9ff6qg520wVFJVe4g0()
	{
		return true;
	}

	internal static bool WRtK5ngACfHVIPp0PIO()
	{
		return false;
	}
}
