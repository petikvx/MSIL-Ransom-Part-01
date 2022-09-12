using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6b0b7721-6746-443d-8cb0-c6199d7f28a6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUpdate
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDisplayVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisplayVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAppVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAppVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAppVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPlatformVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPlatformVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPlatformVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPlatformVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPreviousAppVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPreviousAppVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPreviousAppVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPreviousAppVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBuildIDAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBuildID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBuildIDAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBuildID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDetailsURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDetailsURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDetailsURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDetailsURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBillboardURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBillboardURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBillboardURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBillboardURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLicenseURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLicenseURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLicenseURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLicenseURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetServiceURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aServiceURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetServiceURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aServiceURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetChannelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChannelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowPromptAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowPromptAttribute([MarshalAs(UnmanagedType.U1)] bool aShowPrompt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowNeverForVersionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowNeverForVersionAttribute([MarshalAs(UnmanagedType.U1)] bool aShowNeverForVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUnsupportedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUnsupportedAttribute([MarshalAs(UnmanagedType.U1)] bool aUnsupported);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetPromptWaitTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPromptWaitTimeAttribute(long aPromptWaitTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsCompleteUpdateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsCompleteUpdateAttribute([MarshalAs(UnmanagedType.U1)] bool aIsCompleteUpdate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSecurityUpdateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsSecurityUpdateAttribute([MarshalAs(UnmanagedType.U1)] bool aIsSecurityUpdate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsOSUpdateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsOSUpdateAttribute([MarshalAs(UnmanagedType.U1)] bool aIsOSUpdate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetInstallDateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInstallDateAttribute(long aInstallDate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStatusTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStatusText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStatusTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStatusText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUpdatePatch GetSelectedPatchAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetErrorCodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetErrorCodeAttribute(int aErrorCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPatchCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUpdatePatch GetPatchAt(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement Serialize([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument updates);
}
