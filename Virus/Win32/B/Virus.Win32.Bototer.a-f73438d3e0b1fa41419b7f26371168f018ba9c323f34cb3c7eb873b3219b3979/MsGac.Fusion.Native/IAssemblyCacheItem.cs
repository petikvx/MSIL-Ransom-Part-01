using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace MsGac.Fusion.Native;

[ComImport]
[Guid("9E3AAEB4-D1CD-11D2-BAB9-00C04F8ECEAE")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAssemblyCacheItem
{
	void CreateStream(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszStreamName, uint dwFormat, uint dwFormatFlags, out IStream ppIStream, ref long puliMaxSize);

	void Commit(uint dwFlags, out long pulDisposition);

	void AbortItem();
}
