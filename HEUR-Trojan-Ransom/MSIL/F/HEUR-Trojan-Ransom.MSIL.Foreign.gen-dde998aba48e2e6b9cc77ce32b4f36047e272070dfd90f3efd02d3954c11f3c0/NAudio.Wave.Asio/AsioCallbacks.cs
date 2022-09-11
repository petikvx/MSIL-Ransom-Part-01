using System;
using System.Runtime.InteropServices;

namespace NAudio.Wave.Asio;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct AsioCallbacks
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AsioBufferSwitchCallBack(int doubleBufferIndex, bool directProcess);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AsioSampleRateDidChangeCallBack(double sRate);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int AsioAsioMessageCallBack(AsioMessageSelector selector, int value, IntPtr message, IntPtr opt);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr AsioBufferSwitchTimeInfoCallBack(IntPtr asioTimeParam, int doubleBufferIndex, bool directProcess);

	public AsioBufferSwitchCallBack pbufferSwitch;

	public AsioSampleRateDidChangeCallBack psampleRateDidChange;

	public AsioAsioMessageCallBack pasioMessage;

	public AsioBufferSwitchTimeInfoCallBack pbufferSwitchTimeInfo;
}
