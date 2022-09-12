using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f8fe5ef2-5f2b-43f3-857d-5b64d192c427")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMozIconURI : nsIURI
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
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURL GetIconURLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIconURLAttribute([MarshalAs(UnmanagedType.Interface)] nsIURL aIconURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetImageSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetImageSizeAttribute(uint aImageSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStockIconAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aStockIcon);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIconSizeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aIconSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIconStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aIconState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFileExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFileExtension);
}
