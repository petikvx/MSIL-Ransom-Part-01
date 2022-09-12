using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("150ef720-bbe2-4169-b9f3-ef7ec0654ced")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBrowserSearchService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIBrowserSearchInitObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInitializedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetToOriginalDefaultEngine();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEngine([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase engineURL, int dataType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase iconURL, [MarshalAs(UnmanagedType.U1)] bool confirm, [MarshalAs(UnmanagedType.Interface)] nsISearchInstallCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEngineWithDetails([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase iconURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase alias, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase description, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase method, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase url, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase extensionID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RestoreDefaultEngines();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISearchEngine GetEngineByAlias([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase alias);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISearchEngine GetEngineByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEngineName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEngines(ref uint engineCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsISearchEngine[] engines);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVisibleEngines(ref uint engineCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsISearchEngine[] engines);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDefaultEngines(ref uint engineCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsISearchEngine[] engines);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MoveEngine([MarshalAs(UnmanagedType.Interface)] nsISearchEngine engine, int newIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveEngine([MarshalAs(UnmanagedType.Interface)] nsISearchEngine engine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISearchEngine GetDefaultEngineAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultEngineAttribute([MarshalAs(UnmanagedType.Interface)] nsISearchEngine aDefaultEngine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISearchEngine GetCurrentEngineAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentEngineAttribute([MarshalAs(UnmanagedType.Interface)] nsISearchEngine aCurrentEngine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetDefaultEngineInfo();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISearchParseSubmissionResult ParseSubmissionURL([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase url);
}
