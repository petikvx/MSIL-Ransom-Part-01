using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("90b17d31-46aa-4fb1-a206-473c966cbc18")]
public interface nsICacheEntryDescriptor : nsICacheEntryInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	new string GetClientIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	new string GetDeviceIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetFetchCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetLastFetchedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetLastModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetExpirationTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetDataSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsStreamBased();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExpirationTime(uint expirationTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDataSize(uint size);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream OpenInputStream(uint offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIOutputStream OpenOutputStream(uint offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetCacheElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCacheElementAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCacheElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetPredictedDataSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPredictedDataSizeAttribute(long aPredictedDataSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetAccessGrantedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetStoragePolicyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStoragePolicyAttribute(IntPtr aStoragePolicy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetSecurityInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSecurityInfoAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aSecurityInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetStorageDataSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Doom();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoomAndFailPendingRequests(int status);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncDoom([MarshalAs(UnmanagedType.Interface)] nsICacheListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkValid();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void VisitMetaData([MarshalAs(UnmanagedType.Interface)] nsICacheMetaDataVisitor visitor);
}
