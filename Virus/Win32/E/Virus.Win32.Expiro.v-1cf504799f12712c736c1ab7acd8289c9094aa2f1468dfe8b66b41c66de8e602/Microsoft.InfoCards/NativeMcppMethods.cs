using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Principal;
using _003CCppImplementationDetails_003E;

namespace Microsoft.InfoCards;

internal class NativeMcppMethods
{
	private NativeMcppMethods()
	{
	}

	public unsafe static byte[] X931KeyGenWrapper(byte[] Xp1ByteArray, byte[] Xp2ByteArray, byte[] Xq1ByteArray, byte[] Xq2ByteArray, byte[] XpByteArray, byte[] XqByteArray, int publicExponent, ref KeyGenRestartCodes restartCode)
	{
		byte* ptr = null;
		uint num = 0u;
		byte[] array = null;
		X931_restart_t x931_restart_t = (X931_restart_t)0;
		int num2 = Xp1ByteArray.Length;
		int num3 = XpByteArray.Length;
		_003CModule_003E.AssertInternal(bool_5: true, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct1_0), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 129, bool_6: false);
		byte bool_ = (((nint)num2 == (nint)Xp2ByteArray.LongLength) ? ((byte)1) : ((byte)0));
		_003CModule_003E.AssertInternal(bool_ != 0, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct1_1), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 130, bool_6: false);
		byte bool_2 = (((nint)num2 == (nint)Xq1ByteArray.LongLength) ? ((byte)1) : ((byte)0));
		_003CModule_003E.AssertInternal(bool_2 != 0, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct1_2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 131, bool_6: false);
		byte bool_3 = (((nint)num2 == (nint)Xq2ByteArray.LongLength) ? ((byte)1) : ((byte)0));
		_003CModule_003E.AssertInternal(bool_3 != 0, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct1_3), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 132, bool_6: false);
		byte bool_4 = (((nint)num3 == (nint)XpByteArray.LongLength) ? ((byte)1) : ((byte)0));
		_003CModule_003E.AssertInternal(bool_4 != 0, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct2_0), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 133, bool_6: false);
		byte bool_5 = (((nint)num3 == (nint)XqByteArray.LongLength) ? ((byte)1) : ((byte)0));
		_003CModule_003E.AssertInternal(bool_5 != 0, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct2_1), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 134, bool_6: false);
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		IntPtr intPtr4 = IntPtr.Zero;
		IntPtr intPtr5 = IntPtr.Zero;
		IntPtr intPtr6 = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			intPtr = Marshal.AllocHGlobal(num2);
			intPtr2 = Marshal.AllocHGlobal(num2);
			intPtr3 = Marshal.AllocHGlobal(num2);
			intPtr4 = Marshal.AllocHGlobal(num2);
			intPtr5 = Marshal.AllocHGlobal(num3);
			intPtr6 = Marshal.AllocHGlobal(num3);
			Marshal.Copy(Xp1ByteArray, 0, intPtr, num2);
			Marshal.Copy(Xp2ByteArray, 0, intPtr2, num2);
			Marshal.Copy(Xq1ByteArray, 0, intPtr3, num2);
			Marshal.Copy(Xq2ByteArray, 0, intPtr4, num2);
			Marshal.Copy(XpByteArray, 0, intPtr5, num3);
			Marshal.Copy(XqByteArray, 0, intPtr6, num3);
			int num4 = _003CModule_003E.InfoCardKeyGenX931((uint)num2, (byte*)intPtr.ToPointer(), (byte*)intPtr2.ToPointer(), (byte*)intPtr3.ToPointer(), (byte*)intPtr4.ToPointer(), (uint)num3, (byte*)intPtr5.ToPointer(), (byte*)intPtr6.ToPointer(), (uint)publicExponent, &ptr, &num, &x931_restart_t);
			restartCode = (KeyGenRestartCodes)x931_restart_t;
			if (0 == num4)
			{
				try
				{
					if (KeyGenRestartCodes.X931RestartNone == restartCode)
					{
						byte bool_6 = (byte)((0 != num) ? 1 : 0);
						_003CModule_003E.AssertInternal(bool_6 != 0, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct3_0), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 193, bool_6: false);
						array = new byte[num];
						IntPtr source = new IntPtr(ptr);
						Marshal.Copy(source, array, 0, (int)num);
					}
					else
					{
						byte bool_7 = ((0 == num) ? ((byte)1) : ((byte)0));
						_003CModule_003E.AssertInternal(bool_7 != 0, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct3_1), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 203, bool_6: false);
					}
				}
				finally
				{
					_003CModule_003E.InfoCardKeyGenZeroAndFree(ptr, num);
				}
				return array;
			}
			byte bool_8 = ((0 == num) ? ((byte)1) : ((byte)0));
			_003CModule_003E.AssertInternal(bool_8 != 0, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct3_1), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 218, bool_6: false);
			throw new Win32Exception(num4);
		}
		finally
		{
			if (IntPtr.Zero != intPtr)
			{
				uint num5 = (uint)num2;
				sbyte* ptr2 = (sbyte*)intPtr.ToPointer();
				if (num2 != 0)
				{
					do
					{
						*ptr2 = 0;
						ptr2++;
						num5--;
					}
					while (num5 != 0);
				}
				Marshal.FreeHGlobal(intPtr);
			}
			if (IntPtr.Zero != intPtr2)
			{
				uint num6 = (uint)num2;
				sbyte* ptr3 = (sbyte*)intPtr2.ToPointer();
				if (num2 != 0)
				{
					do
					{
						*ptr3 = 0;
						ptr3++;
						num6--;
					}
					while (num6 != 0);
				}
				Marshal.FreeHGlobal(intPtr2);
			}
			if (IntPtr.Zero != intPtr3)
			{
				uint num7 = (uint)num2;
				sbyte* ptr4 = (sbyte*)intPtr3.ToPointer();
				if (num2 != 0)
				{
					do
					{
						*ptr4 = 0;
						ptr4++;
						num7--;
					}
					while (num7 != 0);
				}
				Marshal.FreeHGlobal(intPtr3);
			}
			if (IntPtr.Zero != intPtr4)
			{
				uint num8 = (uint)num2;
				sbyte* ptr5 = (sbyte*)intPtr4.ToPointer();
				if (num2 != 0)
				{
					do
					{
						*ptr5 = 0;
						ptr5++;
						num8--;
					}
					while (num8 != 0);
				}
				Marshal.FreeHGlobal(intPtr4);
			}
			if (IntPtr.Zero != intPtr5)
			{
				uint num9 = (uint)num3;
				sbyte* ptr6 = (sbyte*)intPtr5.ToPointer();
				if (num3 != 0)
				{
					do
					{
						*ptr6 = 0;
						ptr6++;
						num9--;
					}
					while (num9 != 0);
				}
				Marshal.FreeHGlobal(intPtr5);
			}
			if (IntPtr.Zero != intPtr6)
			{
				uint num10 = (uint)num3;
				sbyte* ptr7 = (sbyte*)intPtr6.ToPointer();
				if (num3 != 0)
				{
					do
					{
						*ptr7 = 0;
						ptr7++;
						num10--;
					}
					while (num10 != 0);
				}
				Marshal.FreeHGlobal(intPtr6);
			}
		}
	}

	public unsafe static uint InfoCardStartRpcServerWrapper(string uiAgentFullPath, IntPtr rpcCallbacks)
	{
		uint num = 0u;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Marshal.StringToHGlobalUni(uiAgentFullPath);
			return _003CModule_003E.InfoCardStartRpcServer((ushort*)intPtr.ToPointer(), (_RPCCALLBACKS*)rpcCallbacks.ToPointer());
		}
		finally
		{
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
	}

	public static uint InfoCardStopRpcServerWrapper()
	{
		return _003CModule_003E.InfoCardStopRpcServer();
	}

	public static uint AdjustPrivilegesWrapper([MarshalAs(UnmanagedType.U1)] bool isTabletPC)
	{
		return _003CModule_003E.AdjustPrivileges(isTabletPC);
	}

	public unsafe static uint CreateAndWaitForFileOpenDialogWrapper(string arguments, WindowsIdentity callerIdentity, uint userProcessPid, ref string fileName)
	{
		uint num = 0u;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		try
		{
			intPtr = Marshal.StringToHGlobalUni(arguments);
			intPtr2 = Marshal.StringToHGlobalUni(callerIdentity.Name);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct6 @struct);
			*(short*)(&@struct) = 0;
			// IL initblk instruction
			System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 2), 0, 518);
			num = _003CModule_003E.CreateAndWaitForFileOpenDialog(pVoid_0: callerIdentity.Token.ToPointer(), pUshort_0: (ushort*)intPtr.ToPointer(), uint_6: userProcessPid, pUshort_1: (ushort*)intPtr2.ToPointer(), pUshort_2: (ushort*)(&@struct));
			if (0 == num)
			{
				fileName = new string((char*)(&@struct));
				return num;
			}
			fileName = "";
			return num;
		}
		finally
		{
			if (IntPtr.Zero != intPtr2)
			{
				Marshal.FreeHGlobal(intPtr2);
				intPtr2 = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
	}

	public unsafe static uint CreateProcessAsUserHelperWrapper(string application, string commandLine, uint userProcessPid, string desktop, string userName, ref int pid)
	{
		uint num = 0u;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		IntPtr intPtr4 = IntPtr.Zero;
		void* ptr = null;
		try
		{
			intPtr = Marshal.StringToHGlobalUni(application);
			intPtr2 = Marshal.StringToHGlobalUni(commandLine);
			intPtr3 = Marshal.StringToHGlobalUni(desktop);
			intPtr4 = Marshal.StringToHGlobalUni(userName);
			uint num2 = 0u;
			num = _003CModule_003E.CreateProcessAsUserHelper((ushort*)intPtr.ToPointer(), (ushort*)intPtr2.ToPointer(), userProcessPid, (ushort*)intPtr3.ToPointer(), (ushort*)intPtr4.ToPointer(), &ptr, &num2);
			pid = (int)num2;
			return num;
		}
		finally
		{
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr2)
			{
				Marshal.FreeHGlobal(intPtr2);
				intPtr2 = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr3)
			{
				Marshal.FreeHGlobal(intPtr3);
				intPtr3 = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr4)
			{
				Marshal.FreeHGlobal(intPtr4);
				intPtr4 = IntPtr.Zero;
			}
			if (null != ptr)
			{
				_003CModule_003E.CloseHandle(ptr);
				ptr = null;
			}
		}
	}

	public unsafe static string GetLocalDataPath(WindowsIdentity identity)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct6 @struct);
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref @struct, 0, 520);
		int num = _003CModule_003E.SHGetFolderPathW(null, 28, identity.Token.ToPointer(), 0u, (ushort*)(&@struct));
		if (num < 0)
		{
			throw new Win32Exception(num);
		}
		return new string((char*)(&@struct));
	}

	public unsafe static WindowsIdentity CreateServiceExecutionIdentity(Process callingProcess)
	{
		WindowsIdentity windowsIdentity = null;
		void* ptr = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			if (_003CModule_003E.OpenProcessToken(callingProcess.Handle.ToPointer(), 14u, &ptr) == 0)
			{
				throw new Win32Exception((int)_003CModule_003E.GetLastError());
			}
			try
			{
				IntPtr userToken = new IntPtr(ptr);
				windowsIdentity = new WindowsIdentity(userToken);
				if (IsLowIntegrityIdentity(windowsIdentity))
				{
					windowsIdentity = CreateMediumIntegrityIdentity(windowsIdentity);
				}
			}
			finally
			{
				_003CModule_003E.CloseHandle(ptr);
			}
		}
		return windowsIdentity;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool IsTokenValid(Process callingProcess)
	{
		void* pVoid_ = null;
		if (_003CModule_003E.OpenProcessToken(callingProcess.Handle.ToPointer(), 14u, &pVoid_) == 0)
		{
			throw new Win32Exception((int)_003CModule_003E.GetLastError());
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _TOKEN_STATISTICS tOKEN_STATISTICS);
			*(int*)(&tOKEN_STATISTICS) = 0;
			// IL initblk instruction
			System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref tOKEN_STATISTICS, 4), 0, 52);
			uint num = 0u;
			if (_003CModule_003E.GetTokenInformation(pVoid_, (_TOKEN_INFORMATION_CLASS)10, &tOKEN_STATISTICS, 56u, &num) == 0)
			{
				throw new Win32Exception((int)_003CModule_003E.GetLastError());
			}
			_SECURITY_LOGON_SESSION_DATA* ptr = null;
			if (0 != _003CModule_003E.LsaGetLogonSessionData((_LUID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref tOKEN_STATISTICS, 8)), &ptr))
			{
				throw new Win32Exception((int)_003CModule_003E.GetLastError());
			}
			uint num2 = *(uint*)((byte*)ptr + 36);
			_003CModule_003E.LsaFreeReturnBuffer(ptr);
			return (byte)((9 != num2) ? 1u : 0u) != 0;
		}
		finally
		{
			_003CModule_003E.CloseHandle(pVoid_);
		}
	}

	public unsafe static uint CreateProcessAsTrustedUserWrapper(string application, string commandLine, uint userProcessPid, string pDesktop, string pUserName, uint userSessionId, ref IntPtr trustedUserToken, ref IntPtr processHandle, ref int pid, IntPtr jobHandle, ref string trustedUserSid, [MarshalAs(UnmanagedType.U1)] bool fElevateToken)
	{
		uint num = 0u;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		IntPtr intPtr4 = IntPtr.Zero;
		IntPtr intPtr5 = IntPtr.Zero;
		void* ptr = null;
		void* ptr2 = null;
		try
		{
			intPtr = Marshal.StringToHGlobalUni(application);
			intPtr2 = Marshal.StringToHGlobalUni(commandLine);
			intPtr3 = Marshal.StringToHGlobalUni(pDesktop);
			intPtr4 = Marshal.StringToHGlobalUni(pUserName);
			uint num2 = 0u;
			void* value = null;
			void* ptr3 = null;
			void* pVoid_ = null;
			if (IntPtr.Zero != trustedUserToken)
			{
				ptr3 = trustedUserToken.ToPointer();
			}
			if (IntPtr.Zero != jobHandle)
			{
				pVoid_ = jobHandle.ToPointer();
			}
			if (!string.IsNullOrEmpty(trustedUserSid))
			{
				intPtr5 = Marshal.StringToHGlobalUni(trustedUserSid);
				if (0 == _003CModule_003E.ConvertStringSidToSidW((ushort*)intPtr5.ToPointer(), &ptr))
				{
					num = _003CModule_003E.GetLastError();
				}
			}
			if (fElevateToken)
			{
				ptr2 = CreateHighIntegrityToken(ptr3);
				byte bool_ = (byte)((ptr2 != null) ? 1 : 0);
				_003CModule_003E.AssertInternal(bool_ != 0, (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct4_0), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0), 685, bool_6: false);
			}
			if (0 == num)
			{
				num = _003CModule_003E.CreateProcessAsTrustedUser(ppVoid_0: (ptr2 == null) ? (&ptr3) : (&ptr2), pUshort_0: (ushort*)intPtr.ToPointer(), pUshort_1: (ushort*)intPtr2.ToPointer(), uint_6: userProcessPid, pUshort_2: (ushort*)intPtr3.ToPointer(), pUshort_3: (ushort*)intPtr4.ToPointer(), uint_7: userSessionId, ppVoid_1: &value, pUint_0: &num2, pVoid_0: pVoid_, ppVoid_2: &ptr);
				if (0 != num)
				{
					return num;
				}
				IntPtr intPtr6 = (processHandle = new IntPtr(value));
				IntPtr intPtr7 = (trustedUserToken = new IntPtr(ptr3));
				pid = (int)num2;
				return num;
			}
			return num;
		}
		finally
		{
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr2)
			{
				Marshal.FreeHGlobal(intPtr2);
				intPtr2 = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr3)
			{
				Marshal.FreeHGlobal(intPtr3);
				intPtr3 = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr4)
			{
				Marshal.FreeHGlobal(intPtr4);
				intPtr4 = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr5)
			{
				Marshal.FreeHGlobal(intPtr5);
				intPtr5 = IntPtr.Zero;
			}
			if (null != ptr)
			{
				ushort* value2 = null;
				if (string.IsNullOrEmpty(trustedUserSid) && _003CModule_003E.ConvertSidToStringSidW(ptr, &value2) != 0)
				{
					IntPtr ptr4 = new IntPtr(value2);
					trustedUserSid = Marshal.PtrToStringUni(ptr4);
				}
				_003CModule_003E.LocalFree(ptr);
			}
			if (null != ptr2)
			{
				_003CModule_003E.CloseHandle(ptr2);
				ptr2 = null;
			}
		}
	}

	public unsafe static uint CreateJobObjectWithSD(ref IntPtr jobHandle, string trustedUserSid)
	{
		uint num = 0u;
		IntPtr intPtr = IntPtr.Zero;
		void* ptr = null;
		void* value = null;
		try
		{
			if (!string.IsNullOrEmpty(trustedUserSid))
			{
				intPtr = Marshal.StringToHGlobalUni(trustedUserSid);
				if (0 == _003CModule_003E.ConvertStringSidToSidW((ushort*)intPtr.ToPointer(), &ptr))
				{
					num = _003CModule_003E.GetLastError();
					if (0 != num)
					{
						return num;
					}
				}
			}
			num = _003CModule_003E.CreateJobObjectHelper(&value, ptr);
			if (0 != num)
			{
				return num;
			}
			IntPtr intPtr2 = (jobHandle = new IntPtr(value));
			return num;
		}
		finally
		{
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
			if (null != ptr)
			{
				_003CModule_003E.LocalFree(ptr);
			}
		}
	}

	public unsafe static IntPtr RpcCryptoOpen(string portName)
	{
		string s = null;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		void* ptr = null;
		ushort* ptr2 = null;
		try
		{
			intPtr = Marshal.StringToHGlobalUni(portName);
			int num = _003CModule_003E.RpcStringBindingComposeW(null, _003CModule_003E.g_lrpcProtocolSequence, null, (ushort*)intPtr.ToPointer(), null, &ptr2);
			if (0 != num)
			{
				throw new Win32Exception(num);
			}
			num = _003CModule_003E.RpcBindingFromStringBindingW(ptr2, &ptr);
			if (0 != num)
			{
				throw new Win32Exception(num);
			}
			intPtr2 = Marshal.StringToHGlobalUni(s);
			num = _003CModule_003E.RpcBindingSetAuthInfoW(ptr, null, 6u, 10u, null, 0u);
			if (0 != num)
			{
				throw new Win32Exception(num);
			}
			return new IntPtr(ptr);
		}
		catch (SEHException)
		{
			throw new Win32Exception(-2147467259);
		}
		finally
		{
			if (null != ptr2)
			{
				_003CModule_003E.RpcStringFreeW(&ptr2);
			}
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr2)
			{
				Marshal.FreeHGlobal(intPtr2);
			}
		}
	}

	public unsafe static void RpcCryptoClose(IntPtr hIdl, string contextKey)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Marshal.StringToHGlobalUni(contextKey);
			_003CModule_003E.RpcCryptoCloseContext(hIdl.ToPointer(), (ushort*)intPtr.ToPointer());
			void* ptr = hIdl.ToPointer();
			_003CModule_003E.RpcBindingFree(&ptr);
		}
		catch (SEHException)
		{
			throw new Win32Exception(-2147467259);
		}
		finally
		{
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
	}

	public unsafe static byte[] RpcCryptoDispatchRequest(IntPtr hIdl, string contextKey, string requestName, byte[] buffer, int index, int length)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _RPC_REQUEST rPC_REQUEST);
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref rPC_REQUEST, 0, 12);
		_RPC_RESPONSE* ptr = null;
		try
		{
			intPtr2 = Marshal.StringToHGlobalUni(contextKey);
			intPtr = Marshal.StringToHGlobalUni(requestName);
			IntPtr intPtr4 = Marshal.AllocHGlobal(length);
			intPtr3 = intPtr4;
			Marshal.Copy(buffer, 0, intPtr4, length);
			System.Runtime.CompilerServices.Unsafe.As<_RPC_REQUEST, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref rPC_REQUEST, 8)) = (int)intPtr3.ToPointer();
			System.Runtime.CompilerServices.Unsafe.As<_RPC_REQUEST, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref rPC_REQUEST, 4)) = length;
			*(int*)(&rPC_REQUEST) = (int)intPtr.ToPointer();
			int num = _003CModule_003E.RpcCryptoDispatchRequest(hIdl.ToPointer(), (ushort*)intPtr2.ToPointer(), &rPC_REQUEST, &ptr);
			if (num < 0)
			{
				throw new Win32Exception(num);
			}
			if (null == ptr)
			{
				throw new Win32Exception(87);
			}
			int num2 = *(int*)ptr;
			byte[] array = new byte[num2];
			_RPC_RESPONSE* ptr2 = (_RPC_RESPONSE*)((byte*)ptr + 4);
			if (*(int*)ptr2 != 0)
			{
				IntPtr source = new IntPtr((void*)(int)(*(uint*)ptr2));
				Marshal.Copy(source, array, 0, *(int*)ptr);
			}
			else if (num2 > 0)
			{
				throw new Win32Exception(87);
			}
			return array;
		}
		catch (SEHException)
		{
			throw new Win32Exception(-2147467259);
		}
		finally
		{
			if (IntPtr.Zero != intPtr2)
			{
				Marshal.FreeHGlobal(intPtr2);
				intPtr2 = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
			if (IntPtr.Zero != intPtr3)
			{
				Marshal.FreeHGlobal(intPtr3);
				intPtr3 = IntPtr.Zero;
			}
			if (null != ptr)
			{
				_RPC_RESPONSE* ptr3 = (_RPC_RESPONSE*)((byte*)ptr + 4);
				if (*(int*)ptr3 != 0)
				{
					_003CModule_003E.MIDL_user_free((void*)(int)(*(uint*)ptr3));
				}
				_003CModule_003E.MIDL_user_free(ptr);
			}
		}
	}

	public unsafe static int CryptAlgIdFromOid(string strOid)
	{
		if (string.IsNullOrEmpty(strOid))
		{
			return 32772;
		}
		string text = CryptoConfig.MapNameToOID(strOid);
		if (string.IsNullOrEmpty(text))
		{
			text = strOid;
		}
		IntPtr intPtr = Marshal.StringToHGlobalAnsi(text);
		try
		{
			_CRYPT_OID_INFO* ptr = _003CModule_003E.CryptFindOIDInfo(1u, intPtr.ToPointer(), 0u);
			if (null == ptr)
			{
				throw new Win32Exception(-2147467259);
			}
			return *(int*)((byte*)ptr + 16);
		}
		finally
		{
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool GetHighAssuranceFlags(IntPtr pcertchaincontext, ref int haFlags)
	{
		uint num = 0u;
		haFlags = 0;
		if (!(IntPtr.Zero == pcertchaincontext) && _003CModule_003E.SetHighAssuranceFlags((_CERT_CHAIN_CONTEXT*)pcertchaincontext.ToPointer(), &num) != 0)
		{
			haFlags = (int)num;
			return true;
		}
		return false;
	}

	public unsafe static int VerifyTrust(string fileName)
	{
		IntPtr intPtr = IntPtr.Zero;
		uint num = uint.MaxValue;
		try
		{
			intPtr = Marshal.StringToHGlobalUni(fileName);
			return (int)_003CModule_003E.VerifyTrust((ushort*)intPtr.ToPointer());
		}
		finally
		{
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
	}

	public unsafe static void CheckSIDAgainstCurrentRpcUser(string strSid)
	{
		IntPtr intPtr = IntPtr.Zero;
		void* ptr = null;
		int num = 0;
		int num2 = 0;
		try
		{
			intPtr = Marshal.StringToHGlobalUni(strSid);
			if (_003CModule_003E.ConvertStringSidToSidW((ushort*)intPtr.ToPointer(), &ptr) == 0)
			{
				throw new Win32Exception((int)_003CModule_003E.GetLastError());
			}
			if (0 != _003CModule_003E.RpcImpersonateClient(null))
			{
				throw new SecurityException();
			}
			num2 = 1;
			if (_003CModule_003E.CheckTokenMembership(null, ptr, &num) == 0)
			{
				throw new Win32Exception((int)_003CModule_003E.GetLastError());
			}
			if (num == 0)
			{
				throw new SecurityException();
			}
		}
		finally
		{
			if (num2 != 0 && _003CModule_003E.RevertToSelf() == 0)
			{
				throw new InvalidOperationException();
			}
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
			}
			if (null != ptr)
			{
				_003CModule_003E.LocalFree(ptr);
				ptr = null;
			}
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool IsOsVistaOrGreater()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _OSVERSIONINFOW oSVERSIONINFOW);
		*(int*)(&oSVERSIONINFOW) = 276;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref oSVERSIONINFOW, 4), 0, 272);
		if (_003CModule_003E.GetVersionExW(&oSVERSIONINFOW) == 0)
		{
			throw new Win32Exception((int)_003CModule_003E.GetLastError());
		}
		return (uint)System.Runtime.CompilerServices.Unsafe.As<_OSVERSIONINFOW, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref oSVERSIONINFOW, 4)) >= 6u;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool IsLowIntegrityIdentity(WindowsIdentity identity)
	{
		bool result = false;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _OSVERSIONINFOW oSVERSIONINFOW);
		*(int*)(&oSVERSIONINFOW) = 276;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref oSVERSIONINFOW, 4), 0, 272);
		if (_003CModule_003E.GetVersionExW(&oSVERSIONINFOW) == 0)
		{
			throw new Win32Exception((int)_003CModule_003E.GetLastError());
		}
		if ((uint)System.Runtime.CompilerServices.Unsafe.As<_OSVERSIONINFOW, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref oSVERSIONINFOW, 4)) >= 6u)
		{
			_TOKEN_MANDATORY_LABEL* ptr = null;
			void* ptr2 = null;
			uint num = 0u;
			uint uint_ = 0u;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				try
				{
					if (_003CModule_003E.GetTokenInformation(identity.Token.ToPointer(), (_TOKEN_INFORMATION_CLASS)25, null, 0u, &num) == 0)
					{
						uint lastError = _003CModule_003E.GetLastError();
						if (122 != lastError)
						{
							throw new Win32Exception((int)lastError);
						}
						ptr = (_TOKEN_MANDATORY_LABEL*)_003CModule_003E.LocalAlloc(64u, num);
						if (ptr == null)
						{
							throw new OutOfMemoryException();
						}
					}
					if (_003CModule_003E.GetTokenInformation(identity.Token.ToPointer(), (_TOKEN_INFORMATION_CLASS)25, ptr, num, &num) == 0)
					{
						uint lastError = _003CModule_003E.GetLastError();
						throw new Win32Exception((int)lastError);
					}
					if (_003CModule_003E.CreateWellKnownSid((WELL_KNOWN_SID_TYPE)66, null, null, &uint_) == 0)
					{
						uint lastError = _003CModule_003E.GetLastError();
						if (122 != lastError)
						{
							throw new Win32Exception((int)lastError);
						}
						ptr2 = _003CModule_003E.LocalAlloc(64u, uint_);
						if (ptr2 == null)
						{
							throw new OutOfMemoryException();
						}
					}
					if (_003CModule_003E.CreateWellKnownSid((WELL_KNOWN_SID_TYPE)66, null, ptr2, &uint_) == 0)
					{
						uint lastError = _003CModule_003E.GetLastError();
						throw new Win32Exception((int)lastError);
					}
					if (_003CModule_003E.EqualSid(ptr2, (void*)(int)(*(uint*)ptr)) != 0)
					{
						result = true;
					}
				}
				finally
				{
					if (ptr2 != null)
					{
						_003CModule_003E.LocalFree(ptr2);
					}
					if (ptr != null)
					{
						_003CModule_003E.LocalFree(ptr);
					}
				}
			}
		}
		return result;
	}

	public unsafe static WindowsIdentity CreateMediumIntegrityIdentity(WindowsIdentity identity)
	{
		WindowsIdentity result = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _OSVERSIONINFOW oSVERSIONINFOW);
		*(int*)(&oSVERSIONINFOW) = 276;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref oSVERSIONINFOW, 4), 0, 272);
		if (_003CModule_003E.GetVersionExW(&oSVERSIONINFOW) == 0)
		{
			throw new Win32Exception((int)_003CModule_003E.GetLastError());
		}
		if (!((uint)System.Runtime.CompilerServices.Unsafe.As<_OSVERSIONINFOW, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref oSVERSIONINFOW, 4)) >= 6u))
		{
			throw new InvalidOperationException();
		}
		void* ptr = null;
		_TOKEN_MANDATORY_LABEL* ptr2 = null;
		uint num = 0u;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			try
			{
				if (_003CModule_003E.DuplicateTokenEx(identity.Token.ToPointer(), 142u, null, (_SECURITY_IMPERSONATION_LEVEL)2, (_TOKEN_TYPE)2, &ptr) == 0)
				{
					uint lastError = _003CModule_003E.GetLastError();
					throw new Win32Exception((int)lastError);
				}
				if (_003CModule_003E.CreateWellKnownSid((WELL_KNOWN_SID_TYPE)67, null, null, &num) == 0)
				{
					uint lastError = _003CModule_003E.GetLastError();
					if (122 != lastError)
					{
						throw new Win32Exception((int)lastError);
					}
				}
				uint num2 = num + 8;
				ptr2 = (_TOKEN_MANDATORY_LABEL*)_003CModule_003E.LocalAlloc(64u, num2);
				if (ptr2 == null)
				{
					throw new OutOfMemoryException();
				}
				_TOKEN_MANDATORY_LABEL* ptr3 = (_TOKEN_MANDATORY_LABEL*)((byte*)ptr2 + 8);
				*(int*)ptr2 = (int)ptr3;
				*(int*)((byte*)ptr2 + 4) = 96;
				if (_003CModule_003E.CreateWellKnownSid((WELL_KNOWN_SID_TYPE)67, null, ptr3, &num) == 0)
				{
					uint lastError = _003CModule_003E.GetLastError();
					throw new Win32Exception((int)lastError);
				}
				if (_003CModule_003E.SetTokenInformation(ptr, (_TOKEN_INFORMATION_CLASS)25, ptr2, num2) == 0)
				{
					uint lastError = _003CModule_003E.GetLastError();
					throw new Win32Exception((int)lastError);
				}
				IntPtr userToken = new IntPtr(ptr);
				result = new WindowsIdentity(userToken);
			}
			finally
			{
				if (ptr != null)
				{
					_003CModule_003E.CloseHandle(ptr);
					ptr = null;
				}
				if (ptr2 != null)
				{
					_003CModule_003E.LocalFree(ptr2);
				}
			}
		}
		return result;
	}

	public unsafe static void* CreateHighIntegrityToken(void* hCurrentToken)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _OSVERSIONINFOW oSVERSIONINFOW);
		*(int*)(&oSVERSIONINFOW) = 276;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref oSVERSIONINFOW, 4), 0, 272);
		if (_003CModule_003E.GetVersionExW(&oSVERSIONINFOW) == 0)
		{
			throw new Win32Exception((int)_003CModule_003E.GetLastError());
		}
		if (!((uint)System.Runtime.CompilerServices.Unsafe.As<_OSVERSIONINFOW, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref oSVERSIONINFOW, 4)) >= 6u))
		{
			throw new InvalidOperationException();
		}
		void* ptr = null;
		_TOKEN_MANDATORY_LABEL* ptr2 = null;
		uint num = 0u;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			try
			{
				if (_003CModule_003E.DuplicateTokenEx(hCurrentToken, 139u, null, (_SECURITY_IMPERSONATION_LEVEL)2, (_TOKEN_TYPE)1, &ptr) == 0)
				{
					uint lastError = _003CModule_003E.GetLastError();
					throw new Win32Exception((int)lastError);
				}
				if (_003CModule_003E.CreateWellKnownSid((WELL_KNOWN_SID_TYPE)68, null, null, &num) == 0)
				{
					uint lastError = _003CModule_003E.GetLastError();
					if (122 != lastError)
					{
						throw new Win32Exception((int)lastError);
					}
				}
				uint num2 = num + 8;
				ptr2 = (_TOKEN_MANDATORY_LABEL*)_003CModule_003E.LocalAlloc(64u, num2);
				if (ptr2 == null)
				{
					throw new OutOfMemoryException();
				}
				_TOKEN_MANDATORY_LABEL* ptr3 = (_TOKEN_MANDATORY_LABEL*)((byte*)ptr2 + 8);
				*(int*)ptr2 = (int)ptr3;
				*(int*)((byte*)ptr2 + 4) = 96;
				if (_003CModule_003E.CreateWellKnownSid((WELL_KNOWN_SID_TYPE)68, null, ptr3, &num) == 0)
				{
					uint lastError = _003CModule_003E.GetLastError();
					throw new Win32Exception((int)lastError);
				}
				if (_003CModule_003E.SetTokenInformation(ptr, (_TOKEN_INFORMATION_CLASS)25, ptr2, num2) == 0)
				{
					uint lastError = _003CModule_003E.GetLastError();
					throw new Win32Exception((int)lastError);
				}
			}
			finally
			{
				if (ptr2 != null)
				{
					_003CModule_003E.LocalFree(ptr2);
				}
			}
		}
		return ptr;
	}

	public unsafe static void AdjustServiceProcessSecurity()
	{
		void* ptr = null;
		_ACL* p_ACL_ = null;
		_ACL* ptr2 = null;
		uint num = 68u;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _EXPLICIT_ACCESS_W eXPLICIT_ACCESS_W);
		*(int*)(&eXPLICIT_ACCESS_W) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 4), 0, 28);
		try
		{
			uint securityInfo = _003CModule_003E.GetSecurityInfo(_003CModule_003E.GetCurrentProcess(), (_SE_OBJECT_TYPE)6, 4u, null, null, &p_ACL_, null, &ptr);
			if (0 != securityInfo)
			{
				throw new Win32Exception((int)securityInfo);
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct5 @struct);
			if (_003CModule_003E.CreateWellKnownSid((WELL_KNOWN_SID_TYPE)11, null, &@struct, &num) == 0)
			{
				throw new Win32Exception((int)_003CModule_003E.GetLastError());
			}
			*(int*)(&eXPLICIT_ACCESS_W) = 1048576;
			System.Runtime.CompilerServices.Unsafe.As<_EXPLICIT_ACCESS_W, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 4)) = 1;
			System.Runtime.CompilerServices.Unsafe.As<_EXPLICIT_ACCESS_W, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 20)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<_EXPLICIT_ACCESS_W, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 24)) = 5;
			System.Runtime.CompilerServices.Unsafe.As<_EXPLICIT_ACCESS_W, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 28)) = (int)(&@struct);
			uint num2 = _003CModule_003E.SetEntriesInAclW(1u, &eXPLICIT_ACCESS_W, p_ACL_, &ptr2);
			if (0 != num2)
			{
				throw new Win32Exception((int)num2);
			}
			uint num3 = _003CModule_003E.SetSecurityInfo(_003CModule_003E.GetCurrentProcess(), (_SE_OBJECT_TYPE)6, 4u, null, null, ptr2, null);
			if (0 != num3)
			{
				throw new Win32Exception((int)num3);
			}
		}
		finally
		{
			if (null != ptr2)
			{
				_003CModule_003E.LocalFree(ptr2);
				ptr2 = null;
			}
			if (null != ptr)
			{
				_003CModule_003E.LocalFree(ptr);
				p_ACL_ = null;
				ptr = null;
			}
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool IsCardSpaceTcserverInstance(int pid, string trustedUserSid)
	{
		bool result = false;
		void* ptr = null;
		void* ptr2 = null;
		ushort* ptr3 = null;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			ptr = _003CModule_003E.OpenProcess(1024u, 0, (uint)pid);
			if (null != ptr)
			{
				if (_003CModule_003E.OpenProcessToken(ptr, 8u, &ptr2) != 0)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct8 @struct);
					*(sbyte*)(&@struct) = 0;
					// IL initblk instruction
					System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 1), 0, 67);
					uint num = 0u;
					if (_003CModule_003E.GetTokenInformation(ptr2, (_TOKEN_INFORMATION_CLASS)4, &@struct, 68u, &num) != 0)
					{
						if (_003CModule_003E.ConvertSidToStringSidW((void*)(int)(*(uint*)(&@struct)), &ptr3) != 0)
						{
							intPtr = Marshal.StringToHGlobalUni(trustedUserSid);
							ushort* pUshort_ = (ushort*)intPtr.ToPointer();
							return 0 == _003CModule_003E._wcsnicmp(pUshort_, ptr3, 68u);
						}
						return result;
					}
					return result;
				}
				return result;
			}
			return result;
		}
		finally
		{
			if (null != ptr3)
			{
				_003CModule_003E.LocalFree(ptr3);
			}
			if (null != ptr2)
			{
				_003CModule_003E.CloseHandle(ptr2);
			}
			if (null != ptr)
			{
				_003CModule_003E.CloseHandle(ptr);
			}
			if (IntPtr.Zero != intPtr)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	public unsafe static void AddSystemAccessToProcess(IntPtr RpcHandle, uint callerPid)
	{
		bool flag = false;
		void* ptr = null;
		_ACL* p_ACL_ = null;
		_ACL* ptr2 = null;
		void* ptr3 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _EXPLICIT_ACCESS_W eXPLICIT_ACCESS_W);
		*(int*)(&eXPLICIT_ACCESS_W) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 4), 0, 28);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct8 @struct);
		*(sbyte*)(&@struct) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 1), 0, 67);
		uint num = 68u;
		try
		{
			uint num2 = (uint)_003CModule_003E.RpcImpersonateClient(RpcHandle.ToPointer());
			if (0 != num2)
			{
				throw new Win32Exception((int)num2);
			}
			flag = true;
			ptr = _003CModule_003E.OpenProcess(393216u, 0, callerPid);
			if (null == ptr)
			{
				throw new Win32Exception((int)_003CModule_003E.GetLastError());
			}
			uint securityInfo = _003CModule_003E.GetSecurityInfo(ptr, (_SE_OBJECT_TYPE)6, 4u, null, null, &p_ACL_, null, &ptr3);
			if (0 != securityInfo)
			{
				throw new Win32Exception((int)securityInfo);
			}
			if (_003CModule_003E.CreateWellKnownSid((WELL_KNOWN_SID_TYPE)22, null, &@struct, &num) == 0)
			{
				throw new Win32Exception((int)_003CModule_003E.GetLastError());
			}
			*(int*)(&eXPLICIT_ACCESS_W) = 2035711;
			System.Runtime.CompilerServices.Unsafe.As<_EXPLICIT_ACCESS_W, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 4)) = 1;
			System.Runtime.CompilerServices.Unsafe.As<_EXPLICIT_ACCESS_W, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 20)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<_EXPLICIT_ACCESS_W, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 24)) = 1;
			System.Runtime.CompilerServices.Unsafe.As<_EXPLICIT_ACCESS_W, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref eXPLICIT_ACCESS_W, 28)) = (int)(&@struct);
			uint num3 = _003CModule_003E.SetEntriesInAclW(1u, &eXPLICIT_ACCESS_W, p_ACL_, &ptr2);
			if (0 != num3)
			{
				throw new Win32Exception((int)num3);
			}
			uint num4 = _003CModule_003E.SetSecurityInfo(ptr, (_SE_OBJECT_TYPE)6, 4u, null, null, ptr2, null);
			if (0 != num4)
			{
				throw new Win32Exception((int)num4);
			}
		}
		finally
		{
			if (null != ptr2)
			{
				_003CModule_003E.LocalFree(ptr2);
			}
			if (null != ptr3)
			{
				_003CModule_003E.LocalFree(ptr3);
			}
			if (null != ptr)
			{
				_003CModule_003E.CloseHandle(ptr);
			}
			if (flag)
			{
				_003CModule_003E.RpcRevertToSelf();
			}
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool PathSupportsPersistedSecurity(string path)
	{
		bool result = false;
		string pathRoot = Path.GetPathRoot(path);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			GCHandle gCHandle = GCHandle.Alloc(pathRoot, GCHandleType.Pinned);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct7 @struct);
			// IL initblk instruction
			System.Runtime.CompilerServices.Unsafe.InitBlock(ref @struct, 0, 522);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct7 struct2);
			// IL initblk instruction
			System.Runtime.CompilerServices.Unsafe.InitBlock(ref struct2, 0, 522);
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			if (_003CModule_003E.GetVolumeInformationW((ushort*)gCHandle.AddrOfPinnedObject().ToPointer(), (ushort*)(&@struct), 261u, &num, &num2, &num3, (ushort*)(&struct2), 261u) == 0)
			{
				gCHandle.Free();
				throw new Win32Exception((int)_003CModule_003E.GetLastError());
			}
			if ((num3 & 8u) != 0)
			{
				result = true;
			}
			gCHandle.Free();
		}
		return result;
	}
}
