using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("19b24f93-7c02-4acf-addd-2f53bbb4e3fd")]
public interface nsIMobileMessageCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyMessageSent([MarshalAs(UnmanagedType.Interface)] nsISupports message);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifySendMessageFailed(int error, [MarshalAs(UnmanagedType.Interface)] nsISupports message);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyMessageGot([MarshalAs(UnmanagedType.Interface)] nsISupports message);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyGetMessageFailed(int error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyMessageDeleted([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] bool[] deleted, uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyDeleteMessageFailed(int error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyMessageMarkedRead([MarshalAs(UnmanagedType.U1)] bool read);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyMarkMessageReadFailed(int error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifySegmentInfoForTextGot(int segments, int charsPerSegment, int charsAvailableInLastSegment);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyGetSegmentInfoForTextFailed(int error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyGetSmscAddress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSmscAddress, uint aTypeOfNumber, uint aNumberPlanIdentification);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyGetSmscAddressFailed(int error);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifySetSmscAddress();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifySetSmscAddressFailed(int error);
}
