using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4c2383a4-931c-484d-8c4a-973590f66e3f")]
public interface imgITools
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	imgIContainer DecodeImage([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DecodeImageData([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, ref imgIContainer aContainer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream EncodeImage(imgIContainer aContainer, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase outputOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream EncodeScaledImage(imgIContainer aContainer, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, int aWidth, int aHeight, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase outputOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgILoader GetImgLoaderForDocument([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument doc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgICache GetImgCacheForDocument([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument doc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream EncodeCroppedImage(imgIContainer aContainer, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, int aOffsetX, int aOffsetY, int aWidth, int aHeight, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase outputOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	imgINotificationObserver CreateScriptedObserver(imgIScriptedNotificationObserver aObserver);
}
