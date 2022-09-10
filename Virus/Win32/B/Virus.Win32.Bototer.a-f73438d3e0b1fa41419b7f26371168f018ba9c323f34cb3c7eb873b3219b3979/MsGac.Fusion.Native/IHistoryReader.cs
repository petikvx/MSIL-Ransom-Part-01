using System.Runtime.InteropServices;
using System.Text;

namespace MsGac.Fusion.Native;

[ComImport]
[Guid("1D23DF4D-A1E2-4B8B-93D6-6EA3DC285A54")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IHistoryReader
{
	[PreserveSig]
	int GetFilePath([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzFilePath, ref uint pdwSize);

	[PreserveSig]
	int GetApplicationName([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzAppName, ref uint pdwSize);

	[PreserveSig]
	int GetEXEModulePath([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzExePath, ref uint pdwSize);

	void GetNumActivations(out uint pdwNumActivations);

	void GetActivationDate(uint dwIdx, out long pftDate);

	[PreserveSig]
	int GetRunTimeVersion(ref long pftActivationDate, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzRunTimeVersion, ref uint pdwSize);

	void GetNumAssemblies(ref long pftActivationDate, out uint pdwNumAsms);

	void GetHistoryAssembly(ref long pftActivationDate, uint dwIdx, [MarshalAs(UnmanagedType.IUnknown)] out object ppHistAsm);
}
