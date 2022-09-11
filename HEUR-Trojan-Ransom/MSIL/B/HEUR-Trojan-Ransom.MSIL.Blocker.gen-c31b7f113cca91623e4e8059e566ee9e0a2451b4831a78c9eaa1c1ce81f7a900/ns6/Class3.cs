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
			a = 0,
			s = 1,
			B = 2,
			R = 3,
			d = 8,
			u = 16
		}

		internal enum Enum1
		{
			t = 0,
			J = 1,
			L = 2,
			o = 3,
			w = 4,
			u = 5,
			B = 6,
			x = 7,
			C = 7,
			n = 8,
			d = 9,
			h = 10,
			G = 11,
			Y = 12
		}

		internal const int k = 566;

		internal static readonly Guid V = new Guid(1876804388, 19971, 19454, 177, 133, 61, 119, 118, 141, 201, 16);

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
