using System;
using System.Net;
using System.Web.Services.Protocols;
using ProwxkN4F4ab5Fc8FL;
using YQdkshYRTPnDUG0oU0n;
using aFheKVYMFNusru8mTwf;
using hVmeblYkSgCICUGqF6u;

namespace DnJ9w2YbLkixCnLn9Wn;

internal sealed class HrPghwYWiu38dAc2w6r
{
	internal static readonly string KTfARHMNs5 = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681942);

	private string p1mAWVnExC;

	private string g4LAbIe1yH;

	private IWebProxy oSQA1CXETJ;

	public void Bx2AhL2eJ8(IWebProxy iwebProxy_0)
	{
		oSQA1CXETJ = iwebProxy_0;
	}

	public void EK9AkuxtjW(My7ApGYLfrO4OwGmj79 my7ApGYLfrO4OwGmj79_0)
	{
		if (g4LAbIe1yH == null)
		{
			try
			{
				icVuMXYhmRPEKKjpqSK icVuMXYhmRPEKKjpqSK = new icVuMXYhmRPEKKjpqSK();
				if (oSQA1CXETJ != null)
				{
					((HttpWebClientProtocol)icVuMXYhmRPEKKjpqSK).set_Proxy(oSQA1CXETJ);
				}
				g4LAbIe1yH = icVuMXYhmRPEKKjpqSK.GetServerURL(p1mAWVnExC);
				if (g4LAbIe1yH.Length == 0)
				{
					throw new ApplicationException(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681858));
				}
				if (g4LAbIe1yH == DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681899))
				{
					g4LAbIe1yH = KTfARHMNs5;
				}
			}
			catch (Exception ex)
			{
				my7ApGYLfrO4OwGmj79_0(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681908) + ex.Message);
				return;
			}
		}
		my7ApGYLfrO4OwGmj79_0(g4LAbIe1yH.StartsWith(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(679450)) ? g4LAbIe1yH : DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(679392));
	}

	public void IAvAXNWHN6(byte[] byte_0, string string_0, string string_1, string string_2, My7ApGYLfrO4OwGmj79 my7ApGYLfrO4OwGmj79_0)
	{
		try
		{
			U26uN4YXm6M4Y337HP6 u26uN4YXm6M4Y337HP = new U26uN4YXm6M4Y337HP6(g4LAbIe1yH);
			while (oSQA1CXETJ != null)
			{
				while (true)
				{
					((HttpWebClientProtocol)u26uN4YXm6M4Y337HP).set_Proxy(oSQA1CXETJ);
					if (iMhPvjCmMdiFixx4fAI())
					{
					}
					switch (4)
					{
					case 0:
					case 3:
						goto end_IL_000e;
					case 4:
						goto end_IL_0041;
					}
					continue;
					end_IL_000e:
					break;
				}
				continue;
				end_IL_0041:
				break;
			}
			my7ApGYLfrO4OwGmj79_0(u26uN4YXm6M4Y337HP.UploadReport2(p1mAWVnExC, byte_0, string_0, string_1, string_2));
		}
		catch (Exception ex)
		{
			my7ApGYLfrO4OwGmj79_0(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681925) + ex.Message);
		}
	}

	public HrPghwYWiu38dAc2w6r(string string_0)
	{
		p1mAWVnExC = string_0;
	}

	internal static bool EDuL1D4ztBbV4qv9NCR()
	{
		return true;
	}

	internal static bool iMhPvjCmMdiFixx4fAI()
	{
		return false;
	}
}
