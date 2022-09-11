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
	private struct Struct0
	{
		public byte[] J;
	}

	private IntPtr d = IntPtr.Zero;

	private IntPtr w;

	private ushort s;

	private DispatcherTimer G;

	private TimeSpan j;

	private DateTime G;

	private ResourceManager W;

	private const string I = "SplashScreen";

	internal string v;

	internal Dispatcher y;

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
		string text = (v = resourceName.ToLowerInvariant());
		w = Marshal.GetHINSTANCE(resourceAssembly.ManifestModule);
		AssemblyName assemblyName = new AssemblyName(resourceAssembly.FullName);
		W = new ResourceManager(assemblyName.Name + ".g", resourceAssembly);
	}

	internal static byte[] smethod_0(byte[] byte_0, ICryptoTransform icryptoTransform_0)
	{
		Struct0 struct0_ = default(Struct0);
		struct0_.J = byte_0;
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, icryptoTransform_0, CryptoStreamMode.Write);
		smethod_2(cryptoStream, ref struct0_);
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
		if (!(d == IntPtr.Zero))
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
			Dispatcher val = (y = Dispatcher.get_CurrentDispatcher());
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
		UnmanagedMemoryStream stream = W.GetStream(v, CultureInfo.CurrentUICulture);
		if (stream != null)
		{
			return stream;
		}
		string name = v;
		return W.GetStream(name, CultureInfo.CurrentUICulture);
	}

	public void method_3(TimeSpan timeSpan_0)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		if (y != null)
		{
			if (y.CheckAccess())
			{
				method_4(timeSpan_0);
			}
			else
			{
				y.Invoke((DispatcherPriority)9, (Delegate)new DispatcherOperationCallback(method_4), (object)timeSpan_0);
			}
		}
		method_5();
	}

	[SecurityCritical]
	private object method_4(object object_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		TimeSpan timeSpan = (TimeSpan)object_0;
		if (d == IntPtr.Zero)
		{
			method_5();
		}
		this.G = new DispatcherTimer();
		this.G.set_Interval(TimeSpan.FromMilliseconds(30.0));
		j = timeSpan;
		G = DateTime.UtcNow + j;
		this.G.add_Tick((EventHandler)G_Tick);
		this.G.Start();
		return null;
	}

	private void G_Tick(object sender, EventArgs e)
	{
		DateTime utcNow = DateTime.UtcNow;
		if (utcNow >= G)
		{
			method_5();
		}
		else
		{
			_ = (G - utcNow).TotalMilliseconds / j.TotalMilliseconds;
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
			Guid guid_2 = Class3.Class4.V;
			Class3.Class5.smethod_0(Class3.Class4.IWICFormatConverter_Initialize_Proxy(intptr_5, intptr_4, ref guid_2, 0, IntPtr.Zero, 0.0, Class3.Class4.Enum1.t));
			Class3.Class5.smethod_0(Class3.Class4.IWICImagingFactory_CreateBitmapFlipRotator_Proxy(intptr_, out intptr_6));
			Class3.Class5.smethod_0(Class3.Class4.IWICBitmapFlipRotator_Initialize_Proxy(intptr_6, intptr_5, Class3.Class4.Enum0.u));
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
	internal static void smethod_2(CryptoStream cryptoStream_0, ref Struct0 struct0_0)
	{
		cryptoStream_0.Write(struct0_0.J, 0, struct0_0.J.Length);
	}
}
