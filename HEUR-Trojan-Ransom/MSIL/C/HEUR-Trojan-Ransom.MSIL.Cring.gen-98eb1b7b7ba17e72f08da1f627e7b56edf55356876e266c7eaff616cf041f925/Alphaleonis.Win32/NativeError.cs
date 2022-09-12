using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Policy;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32;

internal static class NativeError
{
	public static void ThrowException(int errorCode)
	{
		ThrowException((uint)errorCode, null, null);
	}

	public static void ThrowException(uint errorCode)
	{
		ThrowException(errorCode, null, null);
	}

	public static void ThrowException(int errorCode, string readPath)
	{
		ThrowException((uint)errorCode, readPath, null);
	}

	public static void ThrowException(int errorCode, bool? isFolder, string readPath)
	{
		if (errorCode == 2L && isFolder.HasValue && isFolder.Value)
		{
			errorCode = 3;
		}
		ThrowException((uint)errorCode, readPath, null);
	}

	public static void ThrowException(uint errorCode, string readPath)
	{
		ThrowException(errorCode, readPath, null);
	}

	public static void ThrowException(int errorCode, string readPath, string writePath)
	{
		ThrowException((uint)errorCode, readPath, writePath);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public static void ThrowException(uint errorCode, string readPath, string writePath)
	{
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		if (readPath != null)
		{
			readPath = Alphaleonis.Win32.Filesystem.Path.GetCleanExceptionPath(readPath);
		}
		if (writePath != null)
		{
			writePath = Alphaleonis.Win32.Filesystem.Path.GetCleanExceptionPath(writePath);
		}
		string text = string.Format(CultureInfo.InvariantCulture, "({0}) {1}.", new object[2]
		{
			errorCode,
			new Win32Exception((int)errorCode).Message.Trim().TrimEnd(new char[1] { '.' }).Trim()
		});
		if (!Utils.IsNullOrWhiteSpace(readPath) && !Utils.IsNullOrWhiteSpace(writePath))
		{
			text = string.Format(CultureInfo.InvariantCulture, "{0} | Read: [{1}] | Write: [{2}]", new object[3] { text, readPath, writePath });
		}
		else if (!Utils.IsNullOrWhiteSpace(readPath ?? writePath))
		{
			text = string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2]
			{
				text.TrimEnd(new char[1] { '.' }),
				readPath ?? writePath
			});
		}
		switch (errorCode)
		{
		case 15u:
			throw new DriveNotFoundException(text);
		case 2u:
			throw new FileNotFoundException(text);
		case 3u:
			throw new DirectoryNotFoundException(text);
		case 21u:
			throw new DeviceNotReadyException(text);
		case 17u:
			throw new NotSameDeviceException(text);
		case 80u:
		case 183u:
			throw new AlreadyExistsException(readPath ?? writePath, isPath: true);
		case 145u:
			throw new DirectoryNotEmptyException(text);
		case 995u:
			throw new OperationCanceledException(text);
		case 5u:
		case 65u:
		case 6009u:
			throw new UnauthorizedAccessException(text);
		case 0u:
		case 1641u:
		case 3010u:
		case 3011u:
			throw new NotImplementedException(string.Format(CultureInfo.InvariantCulture, "{0} {1}", new object[2]
			{
				Resources.Exception_From_Successful_Operation,
				text
			}));
		case 6700u:
			throw new InvalidTransactionException(Resources.Transaction_Invalid, Marshal.GetExceptionForHR(Win32Errors.GetHrFromWin32Error(errorCode)));
		case 6701u:
			throw new TransactionException(Resources.Transaction_Not_Active, Marshal.GetExceptionForHR(Win32Errors.GetHrFromWin32Error(errorCode)));
		case 6702u:
			throw new TransactionException(Resources.Invalid_Transaction_Request, Marshal.GetExceptionForHR(Win32Errors.GetHrFromWin32Error(errorCode)));
		case 6703u:
			throw new TransactionException(Resources.Transaction_Not_Requested, Marshal.GetExceptionForHR(Win32Errors.GetHrFromWin32Error(errorCode)));
		case 6704u:
			throw new TransactionAlreadyAbortedException(Resources.Transaction_Already_Aborted, Marshal.GetExceptionForHR(Win32Errors.GetHrFromWin32Error(errorCode)));
		case 6705u:
			throw new TransactionAlreadyCommittedException(Resources.Transaction_Already_Committed, Marshal.GetExceptionForHR(Win32Errors.GetHrFromWin32Error(errorCode)));
		case 6012u:
			throw new PolicyException(text);
		default:
			throw new IOException(text, Win32Errors.GetHrFromWin32Error(errorCode));
		case 6805u:
			throw new UnsupportedRemoteTransactionException(Resources.Invalid_Transaction_Request, Marshal.GetExceptionForHR(Win32Errors.GetHrFromWin32Error(errorCode)));
		case 6800u:
			throw new TransactionalConflictException(Resources.Transactional_Conflict, Marshal.GetExceptionForHR(Win32Errors.GetHrFromWin32Error(errorCode)));
		}
	}
}
