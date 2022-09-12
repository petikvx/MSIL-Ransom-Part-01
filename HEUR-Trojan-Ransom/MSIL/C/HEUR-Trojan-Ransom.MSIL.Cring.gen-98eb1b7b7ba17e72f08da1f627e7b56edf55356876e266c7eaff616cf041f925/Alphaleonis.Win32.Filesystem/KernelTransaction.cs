using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Transactions;
using Alphaleonis.Win32.Security;

namespace Alphaleonis.Win32.Filesystem;

public sealed class KernelTransaction : MarshalByRefObject, IDisposable
{
	private readonly SafeKernelTransactionHandle _hTrans;

	public SafeHandle SafeHandle => _hTrans;

	[SecurityCritical]
	[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
	public KernelTransaction(Transaction transaction)
	{
		((IKernelTransaction)TransactionInterop.GetDtcTransaction(transaction)).GetHandle(out _hTrans);
	}

	[SecurityCritical]
	public KernelTransaction()
		: this(0, null)
	{
	}

	[SecurityCritical]
	public KernelTransaction(int timeout, string description)
		: this(null, timeout, description)
	{
	}

	[SecurityCritical]
	public KernelTransaction(ObjectSecurity securityDescriptor, int timeout, string description)
	{
		if (!NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		using Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes lpTransactionAttributes = new Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes(securityDescriptor);
		_hTrans = NativeMethods.CreateTransaction(lpTransactionAttributes, IntPtr.Zero, 0u, 0u, 0u, timeout, description);
		int lastWin32Error = Marshal.GetLastWin32Error();
		NativeMethods.IsValidHandle(_hTrans, lastWin32Error);
	}

	[SecurityCritical]
	public void Commit()
	{
		if (!NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		if (!NativeMethods.CommitTransaction(_hTrans))
		{
			CheckTransaction();
		}
	}

	[SecurityCritical]
	public void Rollback()
	{
		if (!NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		if (!NativeMethods.RollbackTransaction(_hTrans))
		{
			CheckTransaction();
		}
	}

	private static void CheckTransaction()
	{
		uint lastWin32Error = (uint)Marshal.GetLastWin32Error();
		int hRForLastWin32Error = Marshal.GetHRForLastWin32Error();
		switch (lastWin32Error)
		{
		case 6705u:
			throw new TransactionAlreadyAbortedException("Transaction was already committed", Marshal.GetExceptionForHR(hRForLastWin32Error));
		case 6704u:
			throw new TransactionAlreadyAbortedException("Transaction was already aborted", Marshal.GetExceptionForHR(hRForLastWin32Error));
		}
		Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public void Dispose()
	{
		_hTrans.Close();
	}
}
