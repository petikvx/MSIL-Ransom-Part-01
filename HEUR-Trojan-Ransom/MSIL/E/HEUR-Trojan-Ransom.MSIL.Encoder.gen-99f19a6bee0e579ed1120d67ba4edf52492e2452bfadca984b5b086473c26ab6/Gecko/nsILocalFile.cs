using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7ba8c6ba-2ce2-48b1-bd60-4c32aac35f9c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsILocalFile : nsIFile
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase node);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AppendNative([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase node);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Normalize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Create(uint type, uint permissions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetLeafNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLeafName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLeafNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLeafName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNativeLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativeLeafName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetNativeLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativeLeafName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CopyTo([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CopyToNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CopyToFollowingLinks([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CopyToFollowingLinksNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void MoveTo([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void MoveToNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RenameTo([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RenameToNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Remove([MarshalAs(UnmanagedType.U1)] bool recursive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetPermissionsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetPermissionsAttribute(uint aPermissions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetPermissionsOfLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetPermissionsOfLinkAttribute(uint aPermissionsOfLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetLastModifiedTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLastModifiedTimeAttribute(long aLastModifiedTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetLastModifiedTimeOfLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLastModifiedTimeOfLinkAttribute(long aLastModifiedTimeOfLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetFileSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetFileSizeAttribute(long aFileSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetFileSizeOfLinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNativeTargetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativeTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetPathAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNativePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Exists();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsWritable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsReadable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsExecutable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsHidden();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsDirectory();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsFile();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsSymlink();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsSpecial();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CreateUnique(uint type, uint permissions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIFile Clone();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIFile inFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Contains([MarshalAs(UnmanagedType.Interface)] nsIFile inFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIFile GetParentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetDirectoryEntriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void InitWithPath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase filePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void InitWithNativePath([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase filePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void InitWithFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetFollowLinksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetFollowLinksAttribute([MarshalAs(UnmanagedType.U1)] bool aFollowLinks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr OpenNSPRFileDesc(int flags, int mode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr OpenANSIFileDesc([MarshalAs(UnmanagedType.LPStr)] string mode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr Load();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetDiskSpaceAvailableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AppendRelativePath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase relativeFilePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AppendRelativeNativePath([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase relativeFilePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetPersistentDescriptorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPersistentDescriptor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetPersistentDescriptorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPersistentDescriptor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Reveal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Launch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase relativeDesc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetRelativePath([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetRelativePath([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase relativeDesc);
}
