using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace _FFFD_0300ҟ_D997_DC9A;

[StandardModule]
public sealed class _0655콪ٵ_0609ε
{
	public struct BCRYPT_PSS_PADDING_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszAlgId;

		public int cbSalt;

		public BCRYPT_PSS_PADDING_INFO(string pszAlgId, int cbSalt)
		{
			this = default(BCRYPT_PSS_PADDING_INFO);
			this.pszAlgId = pszAlgId;
			this.cbSalt = cbSalt;
		}
	}

	public struct BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO : IDisposable
	{
		public int cbSize;

		public int dwInfoVersion;

		public IntPtr pbNonce;

		public int cbNonce;

		public IntPtr pbAuthData;

		public int cbAuthData;

		public IntPtr pbTag;

		public int cbTag;

		public IntPtr pbMacContext;

		public int cbMacContext;

		public int cbAAD;

		public long cbData;

		public int dwFlags;

		public BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(byte[] iv, byte[] aad, byte[] tag)
		{
			this = default(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO);
			dwInfoVersion = ˤj_FFFDęľ;
			cbSize = Marshal.SizeOf(typeof(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO));
			if (iv != null)
			{
				cbNonce = iv.Length;
				pbNonce = Marshal.AllocHGlobal(cbNonce);
				Marshal.Copy(iv, 0, pbNonce, cbNonce);
			}
			if (aad != null)
			{
				cbAuthData = aad.Length;
				pbAuthData = Marshal.AllocHGlobal(cbAuthData);
				Marshal.Copy(aad, 0, pbAuthData, cbAuthData);
			}
			if (tag != null)
			{
				cbTag = tag.Length;
				pbTag = Marshal.AllocHGlobal(cbTag);
				Marshal.Copy(tag, 0, pbTag, cbTag);
				cbMacContext = tag.Length;
				pbMacContext = Marshal.AllocHGlobal(cbMacContext);
			}
		}

		public void Dispose()
		{
			if (pbNonce != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pbNonce);
			}
			if (pbTag != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pbTag);
			}
			if (pbAuthData != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pbAuthData);
			}
			if (pbMacContext != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pbMacContext);
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}
	}

	public struct BCRYPT_KEY_LENGTHS_STRUCT
	{
		public int dwMinLength;

		public int dwMaxLength;

		public int dwIncrement;
	}

	public struct BCRYPT_OAEP_PADDING_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszAlgId;

		public IntPtr pbLabel;

		public int cbLabel;

		public BCRYPT_OAEP_PADDING_INFO(string alg)
		{
			this = default(BCRYPT_OAEP_PADDING_INFO);
			pszAlgId = alg;
			pbLabel = IntPtr.Zero;
			cbLabel = 0;
		}
	}

	public const uint 늻_05B4_FFFDŧľ = 0u;

	public const uint _FFFDɮ_D974_DEBAԌ = 8u;

	public const uint ӺЅ_06DA_0609_06E3 = 4u;

	public static byte[] _FFFDŚʤޤΑ = BitConverter.GetBytes(1296188491);

	public static string ʤ_0314_0026_07BBŲ = "ObjectLength";

	public static string ƜЦҟלŲ = "ChainingModeGCM";

	public static string _07BBϘ_FFFD_FFFDױ = "AuthTagLength";

	public static string _FFFD꼺Ӻ퓜_FFFD = "ChainingMode";

	public static string _2ӤߟӚœ = "KeyDataBlob";

	public static string _2964ľǎ_FFFD_061C = "AES";

	public static string یzױꓞ_00AB = "Microsoft Primitive Provider";

	public static int _FFFD㠰꾯_05B5թ = 1;

	public static int ˤj_FFFDęľ = 1;

	public static uint _FFFD_26CA_FFFDհt = 3221266434u;

	[DllImport("bcrypt.dll", CharSet = CharSet.Ansi, EntryPoint = "BCryptOpenAlgorithmProvider", ExactSpelling = true, SetLastError = true)]
	public static extern uint 䇹_0655Aҟ_06E8(out IntPtr 쐬ë_FFFD盀_FFFD, [MarshalAs(UnmanagedType.LPWStr)] string _2964ζЅ_FFFDמ, [MarshalAs(UnmanagedType.LPWStr)] string Uş_07BB皍ӓ, uint 蠺_FFFDӺҚ_FFFD);

	[DllImport("bcrypt.dll", CharSet = CharSet.Ansi, EntryPoint = "BCryptCloseAlgorithmProvider", ExactSpelling = true, SetLastError = true)]
	public static extern uint B_06E8ٵҢ_FFFD(IntPtr _05C1tœЮ䇹, uint _FFFD_0333_FFFD㠰ҡ);

	[DllImport("bcrypt.dll", CharSet = CharSet.Ansi, EntryPoint = "BCryptGetProperty", ExactSpelling = true, SetLastError = true)]
	public static extern uint ɛU_FFFDO_05C1(IntPtr Łņ_FFFD_0300_00BE, [MarshalAs(UnmanagedType.LPWStr)] string Қ_FFFD_FFFD_FFFD_05C1, byte[] _002D_0331Ӻב_FFFD, int ӓ_FFFDی鈇Ŵ, ref int _߂ٵ_FFFD_0609_FFFD, uint _FFFD㠰ŴﾭΩ);

	[DllImport("bcrypt.dll", CharSet = CharSet.Ansi, EntryPoint = "BCryptSetProperty", ExactSpelling = true, SetLastError = true)]
	internal static extern uint ջʪ_05B5_FFFDŔ(IntPtr Ң_FFFDױʓ_FFFD, [MarshalAs(UnmanagedType.LPWStr)] string ϫ_07BBԌŁ_005E, byte[] _05C3_00BEZݝӓ, int _FFFD_05C1_FFFD䇹ל, int _FFFDWܣΑ_FFFD);

	[DllImport("bcrypt.dll", CharSet = CharSet.Ansi, EntryPoint = "BCryptImportKey", ExactSpelling = true, SetLastError = true)]
	public static extern uint Īاœҏ_FFFD(IntPtr t_07B9ǎ_065A_05C1, IntPtr 콪泮ٵ_07A8_02F3, [MarshalAs(UnmanagedType.LPWStr)] string 嵱2_1CFC_FFFD_FFFD, out IntPtr Ю똛ҟӺƟ, IntPtr Ŵ_060CW_05C1ﾭ, int _FFFDƜ_00BE_FFFDş, byte[] ɮԜʪ_FFFD㠰, int _FFFD_FFFD_FFFD_058F_FFFD, uint ױޗş_FFFDٷ);

	[DllImport("bcrypt.dll", CharSet = CharSet.Ansi, EntryPoint = "BCryptDestroyKey", ExactSpelling = true, SetLastError = true)]
	public static extern uint _FFFD_FFFD븤ľՕ(IntPtr _0332tJ븤ë);

	[DllImport("bcrypt.dll", CharSet = CharSet.Ansi, EntryPoint = "BCryptEncrypt", ExactSpelling = true, SetLastError = true)]
	public static extern uint ʭב_0314Cϫ(IntPtr _D9EE_DF1A_0026_FFFDҟ, byte[] _FFFDױ_FFFDi_FFFD, int _FFFD_0327ŧɛﾭ, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO ş_FFFD_FFFD_2964ϫ, byte[] ɩĂ䕃ӓœ, int _FFFD_0609ë_1CFCߡ, byte[] أ_005E皍Ɯ嵱, int ߡܪԹɛ_FFFD, ref int Α_2964ا㹃Ӛ, uint _061D_07FBR_0331ʭ);

	[DllImport("bcrypt.dll", CharSet = CharSet.Ansi, EntryPoint = "BCryptDecrypt", ExactSpelling = true, SetLastError = true)]
	internal static extern uint ɩ_FFFDթKҚ(IntPtr _FFFDב_07A8皍_FFFD, byte[] ʭ_FFFDɛ_FFFD_1CFC, int ݝ_FFFD_06DAܣ_0332, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO ĪӤԌі_FFFD, byte[] _DB0A_DC0Bߟҟ恁, int ڿ뜸_FFFDȨƟ, byte[] _߂丐꾯Ԝô, int _07FBՕ_06E8_FFFDҡ, ref int ʤ늻盀kœ, int ŧޗƚ븤Ò);
}
