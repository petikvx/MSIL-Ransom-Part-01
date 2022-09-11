using System.Runtime.InteropServices;

namespace NAudio.MediaFoundation;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5BC8A76B-869A-46A3-9B03-FA218A66AEBE")]
public interface IMFCollection
{
	void GetElementCount(out int pcElements);

	void GetElement([In] int dwElementIndex, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement);

	void AddElement([In][MarshalAs(UnmanagedType.IUnknown)] object pUnkElement);

	void RemoveElement([In] int dwElementIndex, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement);

	void InsertElementAt([In] int dwIndex, [In][MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

	void RemoveAllElements();
}
