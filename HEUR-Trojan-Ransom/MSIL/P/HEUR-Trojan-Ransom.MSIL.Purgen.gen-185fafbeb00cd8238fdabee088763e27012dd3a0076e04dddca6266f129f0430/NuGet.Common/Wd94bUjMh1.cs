using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NuGet.Common;

public static class Wd94bUjMh1
{
	[CompilerGenerated]
	private sealed class C1eWkUf3OL
	{
		public string DCxrpY8FFD;

		internal bool JItth0kmzT(ZipArchiveEntry Gp2vWM7oJ3)
		{
			return string.Equals(Uri.UnescapeDataString(Gp2vWM7oJ3.FullName), hHU8ln8Div(DCxrpY8FFD), StringComparison.OrdinalIgnoreCase);
		}
	}

	private static readonly Lazy<bool> FVqarKbTuB = new Lazy<bool>(zPfuMBByXW);

	public static bool _92A1qiV1w5 => FVqarKbTuB.Value;

	public static StringComparer oVX3n8Ffyv()
	{
		if (_92A1qiV1w5)
		{
			return StringComparer.OrdinalIgnoreCase;
		}
		return StringComparer.Ordinal;
	}

	public static StringComparison OKozL7W3e1()
	{
		if (_92A1qiV1w5)
		{
			return StringComparison.OrdinalIgnoreCase;
		}
		return StringComparison.Ordinal;
	}

	[IteratorStateMachine(typeof(_003CGetUniquePathsBasedOnOS_003Ed__3))]
	public static IEnumerable<string> FjHeATah5A(IEnumerable<string> tgDppHFU1S)
	{
		//yield-return decompiler failed: Method not found
		return new Q0oL7JN5CO(-2)
		{
			ff5zfVfxfe = tgDppHFU1S
		};
	}

	public static string UME0ZVjoNu(string cajKwfy9I5)
	{
		if (cajKwfy9I5 != null && cajKwfy9I5.IndexOf('\\') > -1)
		{
			return cajKwfy9I5.Replace('\\', '/');
		}
		return cajKwfy9I5;
	}

	public static string HI0UnGpWt7(string _4HqC178z4T)
	{
		return kx6Zcsmhff(_4HqC178z4T, Path.DirectorySeparatorChar);
	}

	public static string fWEasICwul(string ZCnccFElL0)
	{
		return kx6Zcsmhff(ZCnccFElL0, '/');
	}

	private static string kx6Zcsmhff(string jZEK6RTAyV, char NVPbDbCC3a)
	{
		if (jZEK6RTAyV == null)
		{
			throw new ArgumentNullException("path");
		}
		if (jZEK6RTAyV.Length == 0 || jZEK6RTAyV[jZEK6RTAyV.Length - 1] == NVPbDbCC3a)
		{
			return jZEK6RTAyV;
		}
		if (rxIaXQyNsQ(jZEK6RTAyV))
		{
			return jZEK6RTAyV.Substring(0, jZEK6RTAyV.Length - 1) + NVPbDbCC3a;
		}
		return jZEK6RTAyV + NVPbDbCC3a;
	}

	public static bool krql8HBQol(string cXP5pxYgZp, string _48UsK7d3Jb)
	{
		if (cXP5pxYgZp == null)
		{
			throw new ArgumentNullException("dir");
		}
		if (_48UsK7d3Jb == null)
		{
			throw new ArgumentNullException("candidate");
		}
		cXP5pxYgZp = Path.GetFullPath(cXP5pxYgZp);
		cXP5pxYgZp = HI0UnGpWt7(cXP5pxYgZp);
		_48UsK7d3Jb = Path.GetFullPath(_48UsK7d3Jb);
		return _48UsK7d3Jb.StartsWith(cXP5pxYgZp, StringComparison.OrdinalIgnoreCase);
	}

	public static bool rxIaXQyNsQ(string BfcLbJWGRM)
	{
		if (string.IsNullOrEmpty(BfcLbJWGRM))
		{
			return false;
		}
		return CuCp4Hq3YQ(BfcLbJWGRM[BfcLbJWGRM.Length - 1]);
	}

	public static bool CuCp4Hq3YQ(char _5KhYCDwwNE)
	{
		if (l6BkPTcFbv.ooEPhgvzVK)
		{
			if (_5KhYCDwwNE != Path.DirectorySeparatorChar)
			{
				return _5KhYCDwwNE == Path.AltDirectorySeparatorChar;
			}
			return true;
		}
		return _5KhYCDwwNE == Path.DirectorySeparatorChar;
	}

	public static void viMiNdL8c7(string SMwk12kNCH)
	{
		string directoryName = Path.GetDirectoryName(SMwk12kNCH);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
	}

	public static string B9kuWWeYEI(string LPEnctZYDt, string J0TQu4TOIh)
	{
		return O8x2chaxEH(LPEnctZYDt, J0TQu4TOIh, Path.DirectorySeparatorChar);
	}

	public static string O8x2chaxEH(string T23HDCMlzd, string redG7G0Ug4, char X9w3aybvk4)
	{
		if (string.IsNullOrEmpty(T23HDCMlzd))
		{
			throw new ArgumentException("Path must have a value", "path1");
		}
		if (string.IsNullOrEmpty(redG7G0Ug4))
		{
			throw new ArgumentException("Path must have a value", "path2");
		}
		StringComparison comparisonType;
		if (l6BkPTcFbv.ooEPhgvzVK)
		{
			comparisonType = StringComparison.OrdinalIgnoreCase;
			if (!string.Equals(Path.GetPathRoot(T23HDCMlzd), Path.GetPathRoot(redG7G0Ug4), comparisonType))
			{
				return redG7G0Ug4;
			}
		}
		else
		{
			comparisonType = StringComparison.Ordinal;
		}
		int i = 0;
		string[] array = T23HDCMlzd.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
		string[] array2 = redG7G0Ug4.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
		int num = array.Length - 1;
		int num2 = array2.Length;
		for (int num3 = Math.Min(num, num2); num3 > i && string.Equals(array[i], array2[i], comparisonType) && (num != i || num2 <= i + 1) && (num <= i || num2 != i + 1); i++)
		{
		}
		string text = "";
		if (num + 1 == num2 && !string.IsNullOrEmpty(array[i]) && string.Equals(array[i], array2[i], comparisonType))
		{
			return text;
		}
		for (int j = i; num > j; j++)
		{
			text = text + ".." + X9w3aybvk4;
		}
		for (int k = i; num2 - 1 > k; k++)
		{
			text = text + array2[k] + X9w3aybvk4;
		}
		if (!string.IsNullOrEmpty(array2[num2 - 1]))
		{
			text += array2[num2 - 1];
		}
		return text;
	}

	public static string _77eTKFdmz5(string R0ZVX7MpUL, string _8gqf1Q3vIl)
	{
		if (R0ZVX7MpUL == null)
		{
			throw new ArgumentNullException("basePath");
		}
		if (_8gqf1Q3vIl == null)
		{
			throw new ArgumentNullException("relativePath");
		}
		return new Uri(new Uri(R0ZVX7MpUL), new Uri(_8gqf1Q3vIl, UriKind.Relative)).LocalPath;
	}

	public static string _8BbGNsMEHI(string woxkVMdh5t)
	{
		woxkVMdh5t = woxkVMdh5t.TrimEnd(new char[1] { Path.DirectorySeparatorChar });
		return woxkVMdh5t.Substring(Path.GetDirectoryName(woxkVMdh5t)!.Length).Trim(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
	}

	public static string _4bjtWD0XUN(string HMUQsM3hd7)
	{
		return HMUQsM3hd7.Replace('/', '\\');
	}

	public static string _5dJLwZmqtx(string _5Tkk0cmAFA)
	{
		if (Path.DirectorySeparatorChar == '/')
		{
			return UME0ZVjoNu(_5Tkk0cmAFA);
		}
		return _4bjtWD0XUN(_5Tkk0cmAFA);
	}

	public static string _9Txwi5KLdm(Uri TvWwdVMFaF)
	{
		string text = TvWwdVMFaF.OriginalString;
		if (text.StartsWith("/", StringComparison.Ordinal))
		{
			text = text.Substring(1);
		}
		return Uri.UnescapeDataString(text.Replace('/', Path.DirectorySeparatorChar));
	}

	public static string Zbdb3ZbQwR(string WEbkJjfy32)
	{
		if (WEbkJjfy32 == null)
		{
			throw new ArgumentNullException("path");
		}
		WEbkJjfy32 = WEbkJjfy32.Replace("[", "`[").Replace("]", "`]");
		if (WEbkJjfy32.Contains("'"))
		{
			return "\"" + WEbkJjfy32.Replace("$", "`$") + "\"";
		}
		return "'" + WEbkJjfy32 + "'";
	}

	public static string AneaXnD8U9(string DURGqex9fe, int _0pz6hybi0D)
	{
		if (_0pz6hybi0D < 6)
		{
			string message = string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy.hjn6tH9CHG, 6);
			throw new ArgumentOutOfRangeException("maxWidth", message);
		}
		if (DURGqex9fe == null)
		{
			throw new ArgumentNullException("path");
		}
		if (DURGqex9fe.Length <= _0pz6hybi0D)
		{
			return DURGqex9fe;
		}
		string text = DURGqex9fe.Split(new char[1] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault() ?? string.Empty;
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		string text2 = directorySeparatorChar.ToString();
		string text3 = text;
		directorySeparatorChar = Path.DirectorySeparatorChar;
		text = text2 + text3 + directorySeparatorChar;
		string pathRoot = Path.GetPathRoot(DURGqex9fe);
		int num = _0pz6hybi0D - pathRoot.Length - 3;
		if (text.Length >= num)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}...{1}", pathRoot, text.Substring(text.Length - num));
		}
		return string.Format(CultureInfo.InvariantCulture, "{0}...{1}", pathRoot, text);
	}

	public static bool ivxAJ9Kewz(string q0pvaIYLqZ, string h22Khs8Oo0)
	{
		if (q0pvaIYLqZ == null)
		{
			throw new ArgumentNullException("basePath");
		}
		if (h22Khs8Oo0 == null)
		{
			throw new ArgumentNullException("path");
		}
		q0pvaIYLqZ = q0pvaIYLqZ.TrimEnd(new char[1] { Path.DirectorySeparatorChar });
		return h22Khs8Oo0.StartsWith(q0pvaIYLqZ, StringComparison.OrdinalIgnoreCase);
	}

	public static string ZwpcpOjGOk(string Ucvj1j15IV)
	{
		return Ucvj1j15IV.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
	}

	public static string hHU8ln8Div(string laHbNQVdPf)
	{
		return laHbNQVdPf.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
	}

	public static ZipArchiveEntry FFsJaYxg2M(ZipArchive _1Zzkg9fUfT, string euHRSiZ1zA)
	{
		return _1Zzkg9fUfT.Entries.SingleOrDefault((ZipArchiveEntry Gp2vWM7oJ3) => string.Equals(Uri.UnescapeDataString(Gp2vWM7oJ3.FullName), hHU8ln8Div(euHRSiZ1zA), StringComparison.OrdinalIgnoreCase));
	}

	private static bool zPfuMBByXW()
	{
		if (l6BkPTcFbv.ooEPhgvzVK)
		{
			return true;
		}
		string[] obj = new string[3]
		{
			hE1biszR17.SX1Br5Fk1Y(YeXhnQPbgq.NuGetHome),
			hE1biszR17.SX1Br5Fk1Y(YeXhnQPbgq.Temp),
			Directory.GetCurrentDirectory()
		};
		bool flag = true;
		string[] array = obj;
		for (int i = 0; i < array.Length; i++)
		{
			bool _2Qr8ex2nsX;
			bool flag2 = tiC8aIe1iE(array[i], out _2Qr8ex2nsX);
			if (!_2Qr8ex2nsX)
			{
				flag = flag && flag2;
			}
		}
		return flag;
	}

	private static bool tiC8aIe1iE(string yKDLhgoHcg, out bool _2Qr8ex2nsX)
	{
		bool flag = true;
		yKDLhgoHcg = Path.GetFullPath(yKDLhgoHcg);
		_2Qr8ex2nsX = true;
		while (true)
		{
			if (yKDLhgoHcg.Length <= 1)
			{
				_2Qr8ex2nsX = true;
				flag = false;
				break;
			}
			if (Directory.Exists(yKDLhgoHcg))
			{
				_2Qr8ex2nsX = false;
				break;
			}
			yKDLhgoHcg = Path.GetDirectoryName(yKDLhgoHcg);
		}
		if (flag)
		{
			if (Directory.Exists(yKDLhgoHcg.ToLowerInvariant()))
			{
				return Directory.Exists(yKDLhgoHcg.ToUpperInvariant());
			}
			return false;
		}
		return false;
	}

	public static string KbCNfyxVIp(string RYC9jJ9bm1)
	{
		RYC9jJ9bm1 = UME0ZVjoNu(RYC9jJ9bm1);
		string text = "./";
		if (RYC9jJ9bm1.StartsWith(text))
		{
			RYC9jJ9bm1 = RYC9jJ9bm1.Substring(text.Length);
		}
		return RYC9jJ9bm1.TrimStart(new char[1] { '/' });
	}
}
