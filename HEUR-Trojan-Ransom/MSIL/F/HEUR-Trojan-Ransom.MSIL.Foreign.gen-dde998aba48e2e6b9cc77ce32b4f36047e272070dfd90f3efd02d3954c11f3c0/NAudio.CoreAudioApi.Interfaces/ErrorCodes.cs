using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi.Interfaces;

internal static class ErrorCodes
{
	public const int SEVERITY_ERROR = 1;

	public const int FACILITY_AUDCLNT = 2185;

	public static readonly int AUDCLNT_E_NOT_INITIALIZED;

	public static readonly int AUDCLNT_E_ALREADY_INITIALIZED;

	public static readonly int AUDCLNT_E_WRONG_ENDPOINT_TYPE;

	public static readonly int AUDCLNT_E_DEVICE_INVALIDATED;

	public static readonly int AUDCLNT_E_NOT_STOPPED;

	public static readonly int AUDCLNT_E_BUFFER_TOO_LARGE;

	public static readonly int AUDCLNT_E_OUT_OF_ORDER;

	public static readonly int AUDCLNT_E_UNSUPPORTED_FORMAT;

	public static readonly int AUDCLNT_E_INVALID_SIZE;

	public static readonly int AUDCLNT_E_DEVICE_IN_USE;

	public static readonly int AUDCLNT_E_BUFFER_OPERATION_PENDING;

	public static readonly int AUDCLNT_E_THREAD_NOT_REGISTERED;

	public static readonly int AUDCLNT_E_EXCLUSIVE_MODE_NOT_ALLOWED;

	public static readonly int AUDCLNT_E_ENDPOINT_CREATE_FAILED;

	public static readonly int AUDCLNT_E_SERVICE_NOT_RUNNING;

	public static readonly int AUDCLNT_E_EVENTHANDLE_NOT_EXPECTED;

	public static readonly int AUDCLNT_E_EXCLUSIVE_MODE_ONLY;

	public static readonly int AUDCLNT_E_BUFDURATION_PERIOD_NOT_EQUAL;

	public static readonly int AUDCLNT_E_EVENTHANDLE_NOT_SET;

	public static readonly int AUDCLNT_E_INCORRECT_BUFFER_SIZE;

	public static readonly int AUDCLNT_E_BUFFER_SIZE_ERROR;

	public static readonly int AUDCLNT_E_CPUUSAGE_EXCEEDED;

	public static readonly int AUDCLNT_E_RESOURCES_INVALIDATED;

	[NonSerialized]
	internal static GetString _0017;

	static ErrorCodes()
	{
		Strings.CreateGetStringDelegate(typeof(ErrorCodes));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0017(107400234), _0017(107400197)).Replace(_0017(107400192), _0017(107400187)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0017(107400214)))
		{
			throw new SecurityException(_0017(107400157));
		}
		AUDCLNT_E_NOT_INITIALIZED = HResult.MAKE_HRESULT(1, 2185, 1);
		AUDCLNT_E_ALREADY_INITIALIZED = HResult.MAKE_HRESULT(1, 2185, 2);
		AUDCLNT_E_WRONG_ENDPOINT_TYPE = HResult.MAKE_HRESULT(1, 2185, 3);
		AUDCLNT_E_DEVICE_INVALIDATED = HResult.MAKE_HRESULT(1, 2185, 4);
		AUDCLNT_E_NOT_STOPPED = HResult.MAKE_HRESULT(1, 2185, 5);
		AUDCLNT_E_BUFFER_TOO_LARGE = HResult.MAKE_HRESULT(1, 2185, 6);
		AUDCLNT_E_OUT_OF_ORDER = HResult.MAKE_HRESULT(1, 2185, 7);
		AUDCLNT_E_UNSUPPORTED_FORMAT = HResult.MAKE_HRESULT(1, 2185, 8);
		AUDCLNT_E_INVALID_SIZE = HResult.MAKE_HRESULT(1, 2185, 9);
		AUDCLNT_E_DEVICE_IN_USE = HResult.MAKE_HRESULT(1, 2185, 10);
		AUDCLNT_E_BUFFER_OPERATION_PENDING = HResult.MAKE_HRESULT(1, 2185, 11);
		AUDCLNT_E_THREAD_NOT_REGISTERED = HResult.MAKE_HRESULT(1, 2185, 12);
		AUDCLNT_E_EXCLUSIVE_MODE_NOT_ALLOWED = HResult.MAKE_HRESULT(1, 2185, 14);
		AUDCLNT_E_ENDPOINT_CREATE_FAILED = HResult.MAKE_HRESULT(1, 2185, 15);
		AUDCLNT_E_SERVICE_NOT_RUNNING = HResult.MAKE_HRESULT(1, 2185, 16);
		AUDCLNT_E_EVENTHANDLE_NOT_EXPECTED = HResult.MAKE_HRESULT(1, 2185, 17);
		AUDCLNT_E_EXCLUSIVE_MODE_ONLY = HResult.MAKE_HRESULT(1, 2185, 18);
		AUDCLNT_E_BUFDURATION_PERIOD_NOT_EQUAL = HResult.MAKE_HRESULT(1, 2185, 19);
		AUDCLNT_E_EVENTHANDLE_NOT_SET = HResult.MAKE_HRESULT(1, 2185, 20);
		AUDCLNT_E_INCORRECT_BUFFER_SIZE = HResult.MAKE_HRESULT(1, 2185, 21);
		AUDCLNT_E_BUFFER_SIZE_ERROR = HResult.MAKE_HRESULT(1, 2185, 22);
		AUDCLNT_E_CPUUSAGE_EXCEEDED = HResult.MAKE_HRESULT(1, 2185, 23);
		AUDCLNT_E_RESOURCES_INVALIDATED = -2004287450;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
