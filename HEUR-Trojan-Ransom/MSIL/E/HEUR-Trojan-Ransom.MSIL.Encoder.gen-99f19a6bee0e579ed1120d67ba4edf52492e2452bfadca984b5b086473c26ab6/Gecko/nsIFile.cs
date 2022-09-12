using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2fa6884a-ae65-412a-9d4c-ce6e34544ba1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFile
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase node);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendNative([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase node);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Normalize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Create(uint type, uint permissions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLeafNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLeafName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLeafNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLeafName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNativeLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativeLeafName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNativeLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativeLeafName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyTo([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyToNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyToFollowingLinks([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyToFollowingLinksNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MoveTo([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MoveToNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RenameTo([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RenameToNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Remove([MarshalAs(UnmanagedType.U1)] bool recursive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPermissionsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPermissionsAttribute(uint aPermissions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPermissionsOfLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPermissionsOfLinkAttribute(uint aPermissionsOfLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLastModifiedTimeAttribute(long aLastModifiedTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedTimeOfLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLastModifiedTimeOfLinkAttribute(long aLastModifiedTimeOfLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetFileSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFileSizeAttribute(long aFileSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetFileSizeOfLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNativeTargetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativeTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPathAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNativePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Exists();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsWritable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsReadable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsExecutable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsHidden();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsDirectory();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsFile();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSymlink();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSpecial();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateUnique(uint type, uint permissions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile Clone();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsIFile inFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Contains([MarshalAs(UnmanagedType.Interface)] nsIFile inFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetDirectoryEntriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithPath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase filePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithNativePath([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase filePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFollowLinksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFollowLinksAttribute([MarshalAs(UnmanagedType.U1)] bool aFollowLinks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr OpenNSPRFileDesc(int flags, int mode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr OpenANSIFileDesc([MarshalAs(UnmanagedType.LPStr)] string mode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr Load();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetDiskSpaceAvailableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendRelativePath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase relativeFilePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendRelativeNativePath([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase relativeFilePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPersistentDescriptorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPersistentDescriptor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPersistentDescriptorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPersistentDescriptor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reveal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Launch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase relativeDesc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRelativePath([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRelativePath([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase relativeDesc);
}
