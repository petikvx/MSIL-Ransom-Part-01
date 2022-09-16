using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using dg3ypDAonQcOidMs0w;

internal static class Class47
{
	[DllImport("ole32.dll")]
	public static extern int CreateBindCtx(int reserved, out IBindCtx ppbc);

	[DllImport("ole32.dll", CharSet = CharSet.Unicode)]
	public static extern int MkParseDisplayName(IBindCtx pbc, string szUserName, ref int pchEaten, out IMoniker ppmk);

	[DllImport("ntdll.dll", CallingConvention = CallingConvention.Cdecl)]
	public unsafe static extern int memcpy(byte* dst, byte* src, int count);

	[DllImport("oleaut32.dll")]
	public static extern int OleCreatePropertyFrame(IntPtr hwndOwner, int x, int y, [MarshalAs(UnmanagedType.LPWStr)] string caption, int cObjects, [MarshalAs(UnmanagedType.Interface)] ref object ppUnk, int cPages, IntPtr lpPageClsID, int lcid, int dwReserved, IntPtr lpvReserved);

	static Class47()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
