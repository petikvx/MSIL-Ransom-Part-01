using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Security;

internal static class NativeMethods
{
	[Flags]
	internal enum TOKEN : uint
	{
		TOKEN_ASSIGN_PRIMARY = 1u,
		TOKEN_DUPLICATE = 2u,
		TOKEN_IMPERSONATE = 4u,
		TOKEN_QUERY = 8u,
		TOKEN_QUERY_SOURCE = 0x10u,
		TOKEN_ADJUST_PRIVILEGES = 0x20u,
		TOKEN_ADJUST_GROUPS = 0x40u,
		TOKEN_ADJUST_DEFAULT = 0x80u,
		TOKEN_ADJUST_SESSIONID = 0x100u,
		TOKEN_READ = 0x20008u,
		TOKEN_ALL_ACCESS = 0xF01FFu
	}

	internal enum TOKEN_ELEVATION_TYPE
	{
		TokenElevationTypeFull = 2
	}

	internal enum TOKEN_INFORMATION_CLASS
	{
		TokenElevationType = 18
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal sealed class SecurityAttributes : IDisposable
	{
		[MarshalAs(UnmanagedType.U4)]
		private int _length;

		private readonly SafeGlobalMemoryBufferHandle _securityDescriptor;

		public bool InheritHandle { get; set; }

		public SecurityAttributes(ObjectSecurity securityDescriptor)
		{
			SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = ToUnmanagedSecurityAttributes(securityDescriptor);
			_length = safeGlobalMemoryBufferHandle.Capacity;
			_securityDescriptor = safeGlobalMemoryBufferHandle;
		}

		public SecurityAttributes(ObjectSecurity securityDescriptor, bool inheritHandle)
			: this(securityDescriptor)
		{
			InheritHandle = inheritHandle;
		}

		[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		private static SafeGlobalMemoryBufferHandle ToUnmanagedSecurityAttributes(ObjectSecurity securityDescriptor)
		{
			if (securityDescriptor == null)
			{
				return new SafeGlobalMemoryBufferHandle();
			}
			byte[] securityDescriptorBinaryForm = securityDescriptor.GetSecurityDescriptorBinaryForm();
			SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(securityDescriptorBinaryForm.Length);
			try
			{
				safeGlobalMemoryBufferHandle.CopyFrom(securityDescriptorBinaryForm, 0, securityDescriptorBinaryForm.Length);
				return safeGlobalMemoryBufferHandle;
			}
			catch
			{
				safeGlobalMemoryBufferHandle.Close();
				throw;
			}
		}

		public void Dispose()
		{
			if (_securityDescriptor != null && !_securityDescriptor.IsClosed)
			{
				_securityDescriptor.Close();
			}
		}
	}

	public const uint STANDARD_RIGHTS_REQUIRED = 983040u;

	public const uint STANDARD_RIGHTS_READ = 131072u;

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetTokenInformation(SafeTokenHandle tokenHandle, [MarshalAs(UnmanagedType.U4)] TOKEN_INFORMATION_CLASS tokenInformationClass, SafeGlobalMemoryBufferHandle tokenInformation, [MarshalAs(UnmanagedType.U4)] uint tokenInformationLength, [MarshalAs(UnmanagedType.U4)] out uint returnLength);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool OpenProcessToken(IntPtr processHandle, [MarshalAs(UnmanagedType.U4)] TOKEN desiredAccess, out SafeTokenHandle tokenHandle);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool AdjustTokenPrivileges(IntPtr tokenHandle, [MarshalAs(UnmanagedType.Bool)] bool disableAllPrivileges, ref TOKEN_PRIVILEGES newState, uint bufferLength, out TOKEN_PRIVILEGES previousState, out uint returnLength);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool LookupPrivilegeDisplayNameW([MarshalAs(UnmanagedType.LPWStr)] string lpSystemName, [MarshalAs(UnmanagedType.LPWStr)] string lpName, ref StringBuilder lpDisplayName, ref uint cchDisplayName, out uint lpLanguageId);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool LookupPrivilegeValueW([MarshalAs(UnmanagedType.LPWStr)] string lpSystemName, [MarshalAs(UnmanagedType.LPWStr)] string lpName, out LUID lpLuid);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetNamedSecurityInfoW([MarshalAs(UnmanagedType.LPWStr)] string pObjectName, SE_OBJECT_TYPE objectType, SECURITY_INFORMATION securityInfo, out IntPtr pSidOwner, out IntPtr pSidGroup, out IntPtr pDacl, out IntPtr pSacl, out SafeGlobalMemoryBufferHandle pSecurityDescriptor);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetSecurityInfo(SafeFileHandle handle, SE_OBJECT_TYPE objectType, SECURITY_INFORMATION securityInfo, out IntPtr pSidOwner, out IntPtr pSidGroup, out IntPtr pDacl, out IntPtr pSacl, out SafeGlobalMemoryBufferHandle pSecurityDescriptor);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint SetSecurityInfo(SafeFileHandle handle, SE_OBJECT_TYPE objectType, SECURITY_INFORMATION securityInfo, IntPtr psidOwner, IntPtr psidGroup, IntPtr pDacl, IntPtr pSacl);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint SetNamedSecurityInfoW([MarshalAs(UnmanagedType.LPWStr)] string pObjectName, SE_OBJECT_TYPE objectType, SECURITY_INFORMATION securityInfo, IntPtr pSidOwner, IntPtr pSidGroup, IntPtr pDacl, IntPtr pSacl);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetSecurityDescriptorDacl(SafeGlobalMemoryBufferHandle pSecurityDescriptor, [MarshalAs(UnmanagedType.Bool)] out bool lpbDaclPresent, out IntPtr pDacl, [MarshalAs(UnmanagedType.Bool)] out bool lpbDaclDefaulted);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetSecurityDescriptorSacl(SafeGlobalMemoryBufferHandle pSecurityDescriptor, [MarshalAs(UnmanagedType.Bool)] out bool lpbSaclPresent, out IntPtr pSacl, [MarshalAs(UnmanagedType.Bool)] out bool lpbSaclDefaulted);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetSecurityDescriptorGroup(SafeGlobalMemoryBufferHandle pSecurityDescriptor, out IntPtr pGroup, [MarshalAs(UnmanagedType.Bool)] out bool lpbGroupDefaulted);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetSecurityDescriptorControl(SafeGlobalMemoryBufferHandle pSecurityDescriptor, out SECURITY_DESCRIPTOR_CONTROL pControl, out uint lpdwRevision);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetSecurityDescriptorOwner(SafeGlobalMemoryBufferHandle pSecurityDescriptor, out IntPtr pOwner, [MarshalAs(UnmanagedType.Bool)] out bool lpbOwnerDefaulted);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	[return: MarshalAs(UnmanagedType.U4)]
	internal static extern uint GetSecurityDescriptorLength(SafeGlobalMemoryBufferHandle pSecurityDescriptor);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
	[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
	internal static extern IntPtr LocalFree(IntPtr hMem);
}
