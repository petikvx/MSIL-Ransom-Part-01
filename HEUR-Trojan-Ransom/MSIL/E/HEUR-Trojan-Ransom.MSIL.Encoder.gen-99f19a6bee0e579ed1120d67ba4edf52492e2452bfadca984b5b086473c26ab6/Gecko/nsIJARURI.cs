using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("646a508c-f786-4e14-be6d-8dda2a633c60")]
public interface nsIJARURI : nsIURL, nsIURI
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetPrePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPrePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetPortAttribute(int aPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIURI other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool SchemeIs([MarshalAs(UnmanagedType.LPStr)] string scheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI Clone();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase relativePath, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetAsciiSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetAsciiHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiHostPort);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetAsciiHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetOriginCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool EqualsExceptRef([MarshalAs(UnmanagedType.Interface)] nsIURI other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI CloneIgnoringRef();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetSpecIgnoringRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpecIgnoringRef);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetHasRefAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetFilePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetFilePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetQueryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aQuery);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetQueryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aQuery);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetDirectoryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDirectory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDirectoryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDirectory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetFileNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetFileNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetFileBaseNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileBaseName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetFileBaseNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileBaseName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetFileExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetFileExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetCommonBaseSpec([MarshalAs(UnmanagedType.Interface)] nsIURI aURIToCompare, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetRelativeSpec([MarshalAs(UnmanagedType.Interface)] nsIURI aURIToCompare, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetJARFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetJAREntryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aJAREntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetJAREntryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aJAREntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIJARURI CloneWithJARFile([MarshalAs(UnmanagedType.Interface)] nsIURI jarFile);
}
