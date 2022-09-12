using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("607c2a2c-0a48-40b9-a956-8cf2bb9857cf")]
public interface nsICacheEntry
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPersistentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetFetchCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLastFetchedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLastModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetExpirationTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExpirationTime(uint expirationTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceValidFor(uint aSecondsToTheFuture);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsForcedValidAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream OpenInputStream(long offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIOutputStream OpenOutputStream(long offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetPredictedDataSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPredictedDataSizeAttribute(long aPredictedDataSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetSecurityInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSecurityInfoAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aSecurityInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetStorageDataSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncDoom([MarshalAs(UnmanagedType.Interface)] nsICacheEntryDoomCallback listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void VisitMetaData([MarshalAs(UnmanagedType.Interface)] nsICacheEntryMetaDataVisitor visitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MetaDataReady();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValid();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICacheEntry Recreate([MarshalAs(UnmanagedType.U1)] bool aMemoryOnly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetDataSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkValid();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MaybeMarkValid();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasWriteAccess([MarshalAs(UnmanagedType.U1)] bool aWriteAllowed);
}
