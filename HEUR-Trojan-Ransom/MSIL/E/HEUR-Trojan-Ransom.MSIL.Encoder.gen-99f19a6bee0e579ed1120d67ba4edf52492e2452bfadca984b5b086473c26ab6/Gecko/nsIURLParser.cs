using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("78c5d19f-f5d2-4732-8d3d-d5a7d7133bc0")]
public interface nsIURLParser
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseURL([MarshalAs(UnmanagedType.LPStr)] string spec, int specLen, ref uint schemePos, ref int schemeLen, ref uint authorityPos, ref int authorityLen, ref uint pathPos, ref int pathLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseAuthority([MarshalAs(UnmanagedType.LPStr)] string authority, int authorityLen, ref uint usernamePos, ref int usernameLen, ref uint passwordPos, ref int passwordLen, ref uint hostnamePos, ref int hostnameLen, ref int port);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseUserInfo([MarshalAs(UnmanagedType.LPStr)] string userinfo, int userinfoLen, ref uint usernamePos, ref int usernameLen, ref uint passwordPos, ref int passwordLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseServerInfo([MarshalAs(UnmanagedType.LPStr)] string serverinfo, int serverinfoLen, ref uint hostnamePos, ref int hostnameLen, ref int port);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParsePath([MarshalAs(UnmanagedType.LPStr)] string path, int pathLen, ref uint filepathPos, ref int filepathLen, ref uint queryPos, ref int queryLen, ref uint refPos, ref int refLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseFilePath([MarshalAs(UnmanagedType.LPStr)] string filepath, int filepathLen, ref uint directoryPos, ref int directoryLen, ref uint basenamePos, ref int basenameLen, ref uint extensionPos, ref int extensionLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseFileName([MarshalAs(UnmanagedType.LPStr)] string filename, int filenameLen, ref uint basenamePos, ref int basenameLen, ref uint extensionPos, ref int extensionLen);
}
