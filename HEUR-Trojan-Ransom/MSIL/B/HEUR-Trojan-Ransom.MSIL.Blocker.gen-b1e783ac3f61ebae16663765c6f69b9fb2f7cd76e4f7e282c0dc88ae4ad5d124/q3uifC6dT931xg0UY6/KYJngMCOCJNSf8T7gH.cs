using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using hU4x3GePSuIEn9q1kR;
using vYQwQOBpQKxv62YWdN;

namespace q3uifC6dT931xg0UY6;

internal class KYJngMCOCJNSf8T7gH
{
	internal class KjHRR08XlRopQfagms : Attribute
	{
		internal class ghsislHGr7j3sh1vyo<T>
		{
			public ghsislHGr7j3sh1vyo()
			{
				Rul53eN1pQAkHhMgbS.OSEpUTCzh4CrB();
				base._002Ector();
			}
		}

		[KjHRR08XlRopQfagms(typeof(ghsislHGr7j3sh1vyo<object>[]))]
		public KjHRR08XlRopQfagms(object object_0)
		{
			Rul53eN1pQAkHhMgbS.OSEpUTCzh4CrB();
			base._002Ector();
		}
	}

	internal class OfWtmNPRNb6I2GO75O
	{
		[KjHRR08XlRopQfagms(typeof(KjHRR08XlRopQfagms.ghsislHGr7j3sh1vyo<object>[]))]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
			if (sHEOcC9b3g(Convert.ToBase64String(aVhy5TW9O.GetName().GetPublicKeyToken()), " ") != "  ")
			{
				while (true)
				{
					ce4DmfsmSrOT856tDgfrkMb();
				}
			}
		}

		[KjHRR08XlRopQfagms(typeof(KjHRR08XlRopQfagms.ghsislHGr7j3sh1vyo<object>[]))]
		internal static string sHEOcC9b3g(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = F0UsY6AjH(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = z7g9Hl3ui();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		public OfWtmNPRNb6I2GO75O()
		{
			Rul53eN1pQAkHhMgbS.OSEpUTCzh4CrB();
			base._002Ector();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Wuqowb9lIc6tX3qWLt(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Ati7N1c9sYeYbQmapS();

	internal struct HaxHIysb88myuIQ4yc
	{
		internal bool BhGOsYMDdW;

		internal byte[] znTOhPijeX;
	}

	[Flags]
	private enum D4iFUWh0NXSehWdnLN
	{

	}

	private static bool TrcoeJf3R;

	private static Assembly aVhy5TW9O;

	private static uint[] rq9RYIraG;

	private static bool u2CkaNWEg;

	private static bool RdMdN7Uv2;

	private static byte[] SGlGF9S02;

	private static byte[] aMhMAigfb;

	private static byte[] QdBLb2qYc;

	private static byte[] CkNDKJKMc;

	private static IntPtr Wpj5CF6TF;

	private static IntPtr Tug3FwLJ0;

	private static object aKcjgVSlH;

	private static int[] yZUxQGV3H;

	private static int KgsvT9pRp;

	private static bool kKnZgCw2Z;

	private static SortedList WZpawDXbD;

	private static int vAuzLKIv1;

	private static long rftOIVErF6;

	internal static Wuqowb9lIc6tX3qWLt WNmOOvXKn5;

	internal static Wuqowb9lIc6tX3qWLt VaoO0qMJC7;

	private static long sCkOrMFhcp;

	private static int WqaOCGO3VR;

	private static bool O0JO6ZQEWR;

	private static bool tykO8MrcfH;

	private static int Q75OHXj0Nh;

	private static IntPtr AeXOPMTQBl;

	[KjHRR08XlRopQfagms(typeof(KjHRR08XlRopQfagms.ghsislHGr7j3sh1vyo<object>[]))]
	private static bool firstrundone;

	internal static Hashtable khdO9H49Dh;

	static KYJngMCOCJNSf8T7gH()
	{
		TrcoeJf3R = false;
		aVhy5TW9O = Type.GetTypeFromHandle(rEFd09n05jxDrTNC6b.ojGpUTgDOUKrm(33554508)).Assembly;
		rq9RYIraG = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		u2CkaNWEg = false;
		RdMdN7Uv2 = false;
		SGlGF9S02 = new byte[0];
		aMhMAigfb = new byte[0];
		QdBLb2qYc = new byte[0];
		CkNDKJKMc = new byte[0];
		Wpj5CF6TF = IntPtr.Zero;
		Tug3FwLJ0 = IntPtr.Zero;
		aKcjgVSlH = new string[0];
		yZUxQGV3H = new int[0];
		KgsvT9pRp = 1;
		kKnZgCw2Z = false;
		WZpawDXbD = new SortedList();
		vAuzLKIv1 = 0;
		rftOIVErF6 = 0L;
		WNmOOvXKn5 = null;
		VaoO0qMJC7 = null;
		sCkOrMFhcp = 0L;
		WqaOCGO3VR = 0;
		O0JO6ZQEWR = false;
		tykO8MrcfH = false;
		Q75OHXj0Nh = 0;
		AeXOPMTQBl = IntPtr.Zero;
		firstrundone = false;
		khdO9H49Dh = new Hashtable();
	}

	private void SVfpUTCgiWxWh()
	{
	}

	internal static byte[] yMM0iKRQG(byte[] byte_0)
	{
		uint[] array = new uint[16];
		int num = 448 - byte_0.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(byte_0.Length + num2 / 8u + 8L);
		ulong num4 = (ulong)(byte_0.Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < byte_0.Length; i++)
		{
			array2[i] = byte_0[i];
		}
		array2[byte_0.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFFuL);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uint_2 = 4023233417u;
		uint uint_3 = 2562383102u;
		uint uint_4 = 271733878u;
		for (uint num7 = 0u; num7 < num6 / 16u; num7++)
		{
			uint num8 = num7 << 6;
			for (uint num9 = 0u; num9 < 61; num9 += 4)
			{
				array[num9 >> 2] = (uint)((array2[num8 + (num9 + 3)] << 24) | (array2[num8 + (num9 + 2)] << 16) | (array2[num8 + (num9 + 1)] << 8) | array2[num8 + num9]);
			}
			uint num10 = uint_;
			uint num11 = uint_2;
			uint num12 = uint_3;
			uint num13 = uint_4;
			jSArnZsPB(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			jSArnZsPB(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			jSArnZsPB(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			jSArnZsPB(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			jSArnZsPB(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			jSArnZsPB(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			jSArnZsPB(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			jSArnZsPB(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			jSArnZsPB(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			jSArnZsPB(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			jSArnZsPB(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			jSArnZsPB(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			jSArnZsPB(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			jSArnZsPB(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			jSArnZsPB(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			jSArnZsPB(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			A70CR6LKR(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			A70CR6LKR(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			A70CR6LKR(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			A70CR6LKR(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			A70CR6LKR(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			A70CR6LKR(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			A70CR6LKR(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			A70CR6LKR(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			A70CR6LKR(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			A70CR6LKR(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			A70CR6LKR(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			A70CR6LKR(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			A70CR6LKR(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			A70CR6LKR(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			A70CR6LKR(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			A70CR6LKR(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			mRq6nQCRJ(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			mRq6nQCRJ(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			mRq6nQCRJ(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			mRq6nQCRJ(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			mRq6nQCRJ(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			mRq6nQCRJ(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			mRq6nQCRJ(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			mRq6nQCRJ(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			mRq6nQCRJ(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			mRq6nQCRJ(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			mRq6nQCRJ(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			mRq6nQCRJ(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			mRq6nQCRJ(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			mRq6nQCRJ(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			mRq6nQCRJ(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			mRq6nQCRJ(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			n8p8xIJKp(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			n8p8xIJKp(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			n8p8xIJKp(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			n8p8xIJKp(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			n8p8xIJKp(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			n8p8xIJKp(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			n8p8xIJKp(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			n8p8xIJKp(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			n8p8xIJKp(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			n8p8xIJKp(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			n8p8xIJKp(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			n8p8xIJKp(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			n8p8xIJKp(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			n8p8xIJKp(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			n8p8xIJKp(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			n8p8xIJKp(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num10;
			uint_2 += num11;
			uint_3 += num12;
			uint_4 += num13;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void jSArnZsPB(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + fwvHAYJng(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + rq9RYIraG[uint_5 - 1], ushort_0);
	}

	private static void A70CR6LKR(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + fwvHAYJng(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + rq9RYIraG[uint_5 - 1], ushort_0);
	}

	private static void mRq6nQCRJ(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + fwvHAYJng(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + rq9RYIraG[uint_5 - 1], ushort_0);
	}

	private static void n8p8xIJKp(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + fwvHAYJng(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + rq9RYIraG[uint_5 - 1], ushort_0);
	}

	private static uint fwvHAYJng(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool QOCPJNSf8()
	{
		if (!u2CkaNWEg)
		{
			tCdcT931x();
			u2CkaNWEg = true;
		}
		return RdMdN7Uv2;
	}

	internal static SymmetricAlgorithm z7g9Hl3ui()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (QOCPJNSf8())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider")!.Unwrap();
		}
	}

	internal static void tCdcT931x()
	{
		try
		{
			RdMdN7Uv2 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] F0UsY6AjH(byte[] byte_0)
	{
		if (!QOCPJNSf8())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return yMM0iKRQG(byte_0);
	}

	[KjHRR08XlRopQfagms(typeof(KjHRR08XlRopQfagms.ghsislHGr7j3sh1vyo<object>[]))]
	internal static bool OR0hXlRop(int int_0)
	{
		if (aMhMAigfb.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(aVhy5TW9O.GetManifestResourceStream("{11111-22222-20001-00000}"));
			binaryReader.BaseStream.Position = 0L;
			RSACryptoServiceProvider.UseMachineKeyStore = true;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] rgbKey = new KYJngMCOCJNSf8T7gH().O50iGmFDJ();
			byte[] array2 = new KYJngMCOCJNSf8T7gH().je7gypw7m();
			byte[] publicKeyToken = aVhy5TW9O.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array2[1] = publicKeyToken[0];
				array2[3] = publicKeyToken[1];
				array2[5] = publicKeyToken[2];
				array2[7] = publicKeyToken[3];
				array2[9] = publicKeyToken[4];
				array2[11] = publicKeyToken[5];
				array2[13] = publicKeyToken[6];
				array2[15] = publicKeyToken[7];
			}
			SymmetricAlgorithm symmetricAlgorithm = z7g9Hl3ui();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, array2);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			aMhMAigfb = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
		}
		if (SGlGF9S02.Length == 0)
		{
			SGlGF9S02 = xQwQQOpQK(B0NEXSehW(aVhy5TW9O).ToString());
		}
		int num = 0;
		try
		{
			num = BitConverter.ToInt32(new byte[4]
			{
				aMhMAigfb[int_0],
				aMhMAigfb[int_0 + 1],
				aMhMAigfb[int_0 + 2],
				aMhMAigfb[int_0 + 3]
			}, 0);
		}
		catch
		{
		}
		try
		{
			if (SGlGF9S02[num] == 128)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static uint BfaNgmsHh(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11111}".Length;
	}

	private static uint jiselGr7j(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	[KjHRR08XlRopQfagms(typeof(KjHRR08XlRopQfagms.ghsislHGr7j3sh1vyo<object>[]))]
	internal static string uWtBmNRNb(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int jYebYbQma()
	{
		return 5;
	}

	private static void wSuUaxHIy()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate s88fmyuIQ(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(rEFd09n05jxDrTNC6b.ojGpUTgDOUKrm(16777263)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(rEFd09n05jxDrTNC6b.ojGpUTgDOUKrm(16777262)),
			Type.GetTypeFromHandle(rEFd09n05jxDrTNC6b.ojGpUTgDOUKrm(16777253))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object B0NEXSehW(object object_0)
	{
		try
		{
			if (File.Exists(((Assembly)object_0).Location))
			{
				return ((Assembly)object_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)object_0).GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return ((Assembly)object_0).GetName().CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(object_0.GetType().GetProperty("Location")!.GetValue(object_0, new object[0])!.ToString()))
			{
				return object_0.GetType().GetProperty("Location")!.GetValue(object_0, new object[0])!.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[KjHRR08XlRopQfagms(typeof(KjHRR08XlRopQfagms.ghsislHGr7j3sh1vyo<object>[]))]
	private static byte[] xQwQQOpQK(string string_0)
	{
		using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	[KjHRR08XlRopQfagms(typeof(KjHRR08XlRopQfagms.ghsislHGr7j3sh1vyo<object>[]))]
	private static byte[] Vv642YWdN(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = z7g9Hl3ui();
		symmetricAlgorithm.Key = new byte[32]
		{
			123, 5, 74, 12, 244, 156, 221, 154, 121, 221,
			183, 41, 121, 65, 9, 43, 67, 81, 23, 43,
			74, 63, 64, 23, 95, 185, 226, 244, 45, 194,
			211, 43
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
			12, 54, 68, 241, 68, 66
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	private byte[] vTtmY9OBq()
	{
		string text = "{11111-22222-10001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] GZv2byBqH()
	{
		string text = "{11111-22222-10001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] je7gypw7m()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] O50iGmFDJ()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] mJtXJWe3Z()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] wV8u78AMI()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] SnCwjE43O()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] fSqqnJihy()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] P9tAhpLsJ()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] etQKR5t68()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}
}
