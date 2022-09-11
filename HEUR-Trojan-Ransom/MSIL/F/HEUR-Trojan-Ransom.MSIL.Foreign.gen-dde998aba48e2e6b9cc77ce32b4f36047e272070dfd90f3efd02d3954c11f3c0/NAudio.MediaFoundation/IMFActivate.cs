using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NAudio.MediaFoundation;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7FEE9E9A-4A89-47a6-899C-B6A53A70FB67")]
public interface IMFActivate : IMFAttributes
{
	new void GetItem([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [In][Out] IntPtr pValue);

	new void GetItemType([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out int pType);

	new void CompareItem([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, IntPtr value, [MarshalAs(UnmanagedType.Bool)] out bool pbResult);

	new void Compare([MarshalAs(UnmanagedType.Interface)] IMFAttributes pTheirs, int matchType, [MarshalAs(UnmanagedType.Bool)] out bool pbResult);

	new void GetUINT32([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out int punValue);

	new void GetUINT64([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out long punValue);

	new void GetDouble([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out double pfValue);

	new void GetGUID([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out Guid pguidValue);

	new void GetStringLength([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out int pcchLength);

	new void GetString([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszValue, int cchBufSize, out int pcchLength);

	new void GetAllocatedString([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [MarshalAs(UnmanagedType.LPWStr)] out string ppwszValue, out int pcchLength);

	new void GetBlobSize([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out int pcbBlobSize);

	new void GetBlob([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pBuf, int cbBufSize, out int pcbBlobSize);

	new void GetAllocatedBlob([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, out IntPtr ip, out int pcbSize);

	new void GetUnknown([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [In][MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppv);

	new void SetItem([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, IntPtr value);

	new void DeleteItem([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey);

	new void DeleteAllItems();

	new void SetUINT32([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, int unValue);

	new void SetUINT64([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, long unValue);

	new void SetDouble([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, double fValue);

	new void SetGUID([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [In][MarshalAs(UnmanagedType.LPStruct)] Guid guidValue);

	new void SetString([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [In][MarshalAs(UnmanagedType.LPWStr)] string wszValue);

	new void SetBlob([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf, int cbBufSize);

	new void SetUnknown([MarshalAs(UnmanagedType.LPStruct)] Guid guidKey, [In][MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

	new void LockStore();

	new void UnlockStore();

	new void GetCount(out int pcItems);

	new void GetItemByIndex(int unIndex, out Guid pGuidKey, [In][Out] IntPtr pValue);

	new void CopyAllItems([In][MarshalAs(UnmanagedType.Interface)] IMFAttributes pDest);

	void ActivateObject([In][MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppv);

	void ShutdownObject();

	void DetachObject();
}
