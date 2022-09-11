using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using ns1;
using ns2;

namespace ns6;

internal sealed class Class3
{
	internal sealed class Class4
	{
		internal enum Enum0
		{
			V = 0,
			l = 1,
			T = 2,
			f = 3,
			A = 8,
			w = 16
		}

		internal enum Enum1
		{
			E = 0,
			y = 1,
			U = 2,
			N = 3,
			p = 4,
			M = 5,
			w = 6,
			A = 7,
			g = 7,
			Q = 8,
			v = 9,
			K = 10,
			r = 11,
			o = 12
		}

		internal const int V = 566;

		internal static readonly Guid E = new Guid(1876804388, 19971, 19454, 177, 133, 61, 119, 118, 141, 201, 16);

		[DllImport("WindowsCodecs.dll")]
		internal static extern int WICCreateImagingFactory_Proxy(uint uint_0, out IntPtr intptr_0);

		[DllImport("WindowsCodecs.dll")]
		internal static extern int IWICImagingFactory_CreateStream_Proxy(IntPtr intptr_0, out IntPtr intptr_1);

		[DllImport("WindowsCodecs.dll")]
		internal static extern int IWICStream_InitializeFromMemory_Proxy(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

		[DllImport("WindowsCodecs.dll")]
		internal static extern int IWICImagingFactory_CreateDecoderFromStream_Proxy(IntPtr intptr_0, IntPtr intptr_1, ref Guid guid_0, uint uint_0, out IntPtr intptr_2);

		[DllImport("WindowsCodecs.dll")]
		internal static extern int IWICBitmapDecoder_GetFrame_Proxy(IntPtr intptr_0, uint uint_0, out IntPtr intptr_1);

		[DllImport("WindowsCodecs.dll")]
		internal static extern int IWICImagingFactory_CreateFormatConverter_Proxy(IntPtr intptr_0, out IntPtr intptr_1);

		[DllImport("WindowsCodecs.dll")]
		internal static extern int IWICFormatConverter_Initialize_Proxy(IntPtr intptr_0, IntPtr intptr_1, ref Guid guid_0, int int_0, IntPtr intptr_2, double double_0, Enum1 enum1_0);

		[DllImport("WindowsCodecs.dll")]
		internal static extern int IWICImagingFactory_CreateBitmapFlipRotator_Proxy(IntPtr intptr_0, out IntPtr intptr_1);

		internal static byte[] smethod_0(byte[] byte_0)
		{
			byte[] byte_ = new byte[16]
			{
				58, 168, 232, 178, 49, 42, 130, 245, 60, 136,
				12, 31, 103, 88, 48, 233
			};
			using Aes aes_ = Aes.Create();
			if (GClass0.smethod_0(aes_, byte_, out var byte_2))
			{
				return byte_2;
			}
			return Class0.smethod_0(byte_0, aes_);
		}

		[DllImport("WindowsCodecs.dll")]
		internal static extern int IWICBitmapFlipRotator_Initialize_Proxy(IntPtr intptr_0, IntPtr intptr_1, Enum0 enum0_0);

		[DllImport("WindowsCodecs.dll")]
		internal static extern int IWICBitmapSource_GetSize_Proxy(IntPtr intptr_0, out int int_0, out int int_1);
	}

	internal sealed class Class5
	{
		[SecuritySafeCritical]
		public static void smethod_0(int int_0)
		{
			if (int_0 < 0)
			{
				Marshal.ThrowExceptionForHR(int_0, (IntPtr)(-1));
			}
		}
	}
}
