using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("92073a54-6d78-4f30-913a-b871813208c6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIURI
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPrePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPrePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPortAttribute(int aPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsIURI other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SchemeIs([MarshalAs(UnmanagedType.LPStr)] string scheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI Clone();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase relativePath, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAsciiSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAsciiHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiHostPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAsciiHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOriginCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool EqualsExceptRef([MarshalAs(UnmanagedType.Interface)] nsIURI other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI CloneIgnoringRef();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSpecIgnoringRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpecIgnoringRef);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasRefAttribute();
}
