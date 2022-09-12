using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("db0a945c-3883-424a-98d0-2ee0523b0255")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface imgIRequest : nsIRequest
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsPending();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Cancel(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Suspend();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Resume();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsILoadGroup GetLoadGroupAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetLoadFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLoadFlagsAttribute(uint aLoadFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIContainer GetImageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetImageStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetImageErrorCodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetCurrentURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgINotificationObserver GetNotificationObserverAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetMimeTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIRequest Clone(imgINotificationObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetImagePrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMultipartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCORSModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CancelAndForgetObserver(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartDecoding();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LockImage();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnlockImage();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RequestDiscard();

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIRequest GetStaticRequest();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IncrementAnimationConsumers();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DecrementAnimationConsumers();
}
