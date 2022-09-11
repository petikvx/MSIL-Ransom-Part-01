using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Threading;
using ns6;

namespace ns5;

[SecurityCritical(SecurityCriticalScope.Everything)]
public class GClass1
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Struct1
	{
		public byte[] m;
	}

	private IntPtr m = IntPtr.Zero;

	private ushort m;

	private DispatcherTimer N;

	private ResourceManager y;

	private const string P = "SplashScreen";

	internal string I;

	internal IntPtr e;

	internal TimeSpan K;

	internal DateTime A;

	internal Dispatcher J;

	[SecurityCritical]
	public GClass1(string resourceName)
		: this(Assembly.GetEntryAssembly(), resourceName)
	{
	}

	[SecurityCritical]
	public GClass1(Assembly resourceAssembly, string resourceName)
	{
		if (resourceAssembly == null)
		{
			throw new ArgumentNullException("resourceAssembly");
		}
		if (string.IsNullOrEmpty(resourceName))
		{
			throw new ArgumentNullException("resourceName");
		}
		string text = (I = resourceName.ToLowerInvariant());
		IntPtr intPtr = (e = Marshal.GetHINSTANCE(resourceAssembly.ManifestModule));
		AssemblyName assemblyName = new AssemblyName(resourceAssembly.FullName);
		y = new ResourceManager(assemblyName.Name + ".g", resourceAssembly);
	}

	internal static byte[] smethod_0(byte[] byte_0, ICryptoTransform icryptoTransform_0)
	{
		Struct1 struct1_ = default(Struct1);
		struct1_.m = byte_0;
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, icryptoTransform_0, CryptoStreamMode.Write);
		smethod_2(cryptoStream, ref struct1_);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}

	[SecurityCritical]
	public void method_0(bool bool_0)
	{
		method_1(bool_0, bool_1: false);
	}

	[SecurityCritical]
	public unsafe void method_1(bool bool_0, bool bool_1)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		if (!(this.m == IntPtr.Zero))
		{
			return;
		}
		UnmanagedMemoryStream unmanagedMemoryStream;
		UnmanagedMemoryStream unmanagedMemoryStream2 = (unmanagedMemoryStream = method_2());
		try
		{
			unmanagedMemoryStream2.Seek(0L, SeekOrigin.Begin);
			IntPtr intptr_ = new IntPtr(unmanagedMemoryStream2.PositionPointer);
			if (method_6(intptr_, unmanagedMemoryStream2.Length, bool_1) && bool_0)
			{
				Dispatcher.get_CurrentDispatcher().BeginInvoke((DispatcherPriority)6, (Delegate)new DispatcherOperationCallback(smethod_1), (object)this);
			}
			Dispatcher val = (J = Dispatcher.get_CurrentDispatcher());
		}
		finally
		{
			((IDisposable)unmanagedMemoryStream)?.Dispose();
		}
	}

	[SecurityCritical]
	private static object smethod_1(object object_0)
	{
		((GClass1)object_0).method_3(TimeSpan.FromSeconds(0.3));
		return null;
	}

	private UnmanagedMemoryStream method_2()
	{
		UnmanagedMemoryStream stream = y.GetStream(I, CultureInfo.CurrentUICulture);
		if (stream != null)
		{
			return stream;
		}
		string i = I;
		return y.GetStream(i, CultureInfo.CurrentUICulture);
	}

	public void method_3(TimeSpan timeSpan_0)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		if (J != null)
		{
			if (J.CheckAccess())
			{
				method_4(timeSpan_0);
			}
			else
			{
				J.Invoke((DispatcherPriority)9, (Delegate)new DispatcherOperationCallback(method_4), (object)timeSpan_0);
			}
		}
		method_5();
	}

	[SecurityCritical]
	private object method_4(object object_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		TimeSpan k = (TimeSpan)object_0;
		if (this.m == IntPtr.Zero)
		{
			method_5();
		}
		N = new DispatcherTimer();
		N.set_Interval(TimeSpan.FromMilliseconds(30.0));
		TimeSpan timeSpan = (K = k);
		DateTime dateTime = (A = DateTime.UtcNow + K);
		N.add_Tick((EventHandler)N_Tick);
		N.Start();
		return null;
	}

	private void N_Tick(object sender, EventArgs e)
	{
		DateTime utcNow = DateTime.UtcNow;
		if (utcNow >= A)
		{
			method_5();
		}
		else
		{
			_ = (A - utcNow).TotalMilliseconds / K.TotalMilliseconds;
		}
	}

	private void method_5()
	{
	}

	[SecurityCritical]
	private bool method_6(IntPtr intptr_0, long long_0, bool bool_0)
	{
		bool flag = false;
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = IntPtr.Zero;
		IntPtr intptr_3 = IntPtr.Zero;
		IntPtr intptr_4 = IntPtr.Zero;
		IntPtr intptr_5 = IntPtr.Zero;
		IntPtr intptr_6 = IntPtr.Zero;
		try
		{
			Class3.Class5.smethod_0(Class3.Class4.WICCreateImagingFactory_Proxy(566u, out intptr_));
			Class3.Class5.smethod_0(Class3.Class4.IWICImagingFactory_CreateStream_Proxy(intptr_, out intptr_3));
			Class3.Class5.smethod_0(Class3.Class4.IWICStream_InitializeFromMemory_Proxy(intptr_3, intptr_0, (uint)long_0));
			Guid guid_ = Guid.Empty;
			Class3.Class5.smethod_0(Class3.Class4.IWICImagingFactory_CreateDecoderFromStream_Proxy(intptr_, intptr_3, ref guid_, 0u, out intptr_2));
			Class3.Class5.smethod_0(Class3.Class4.IWICBitmapDecoder_GetFrame_Proxy(intptr_2, 0u, out intptr_4));
			Class3.Class5.smethod_0(Class3.Class4.IWICImagingFactory_CreateFormatConverter_Proxy(intptr_, out intptr_5));
			Guid guid_2 = Class3.Class4.C;
			Class3.Class5.smethod_0(Class3.Class4.IWICFormatConverter_Initialize_Proxy(intptr_5, intptr_4, ref guid_2, 0, IntPtr.Zero, 0.0, Class3.Class4.Enum1.G));
			Class3.Class5.smethod_0(Class3.Class4.IWICImagingFactory_CreateBitmapFlipRotator_Proxy(intptr_, out intptr_6));
			Class3.Class5.smethod_0(Class3.Class4.IWICBitmapFlipRotator_Initialize_Proxy(intptr_6, intptr_5, Class3.Class4.Enum0.V));
			Class3.Class5.smethod_0(Class3.Class4.IWICBitmapSource_GetSize_Proxy(intptr_6, out var _, out var _));
			flag = true;
		}
		finally
		{
			if (intptr_ != IntPtr.Zero)
			{
				Marshal.Release(intptr_);
			}
			if (intptr_2 != IntPtr.Zero)
			{
				Marshal.Release(intptr_2);
			}
			if (intptr_3 != IntPtr.Zero)
			{
				Marshal.Release(intptr_3);
			}
			if (intptr_4 != IntPtr.Zero)
			{
				Marshal.Release(intptr_4);
			}
			if (intptr_5 != IntPtr.Zero)
			{
				Marshal.Release(intptr_5);
			}
			if (intptr_6 != IntPtr.Zero)
			{
				Marshal.Release(intptr_6);
			}
			if (!flag)
			{
				method_5();
			}
		}
		return flag;
	}

	[CompilerGenerated]
	internal static void smethod_2(CryptoStream cryptoStream_0, ref Struct1 struct1_0)
	{
		cryptoStream_0.Write(struct1_0.m, 0, struct1_0.m.Length);
	}
}
