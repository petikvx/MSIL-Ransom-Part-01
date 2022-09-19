using System.Runtime.InteropServices;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3C374A42-BAE4-11CF-BF7D-00AA006946EE")]
public interface GInterface2
{
	void Next(int celt, ref GStruct3 rgelt, out int pceltFetched);

	void Skip(int celt);

	void Reset();

	void Clone(out GInterface2 ppenum);

	void SetFilter([MarshalAs(UnmanagedType.LPWStr)] string poszFilter, GEnum6 dwFlags);
}
