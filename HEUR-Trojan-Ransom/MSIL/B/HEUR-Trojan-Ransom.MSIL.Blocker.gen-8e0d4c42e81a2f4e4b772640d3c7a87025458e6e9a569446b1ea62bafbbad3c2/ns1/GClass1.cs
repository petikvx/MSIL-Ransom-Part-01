using System;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace ns1;

public class GClass1 : Component, ISerializable
{
	private sealed class Class8
	{
		private static volatile CodeAccessPermission codeAccessPermission_0;

		internal static CodeAccessPermission CodeAccessPermission_0
		{
			get
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				if (codeAccessPermission_0 == null)
				{
					codeAccessPermission_0 = (CodeAccessPermission)new UIPermission((UIPermissionWindow)1);
				}
				return codeAccessPermission_0;
			}
		}

		private Class8()
		{
		}
	}

	private sealed class Class9
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal sealed class Class10
		{
			internal int int_0;

			internal int int_1;

			internal int int_2;

			internal int int_3;

			internal int int_4;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal sealed class Class11
		{
			internal short short_0;

			internal short short_1;

			internal int int_0;

			internal int int_1;

			internal short short_2;

			internal short short_3;

			internal short short_4;
		}

		internal const int int_0 = 1;

		internal const int int_1 = 2;

		internal const int int_2 = 3;

		internal const int int_3 = 0;

		internal const int int_4 = 65536;

		internal const int int_5 = 32;

		internal const int int_6 = 0;

		internal const int int_7 = 1;

		internal const int int_8 = 2;

		internal const int int_9 = 4;

		internal const int int_10 = 8;

		internal const int int_11 = 64;

		internal const int int_12 = 131072;

		internal const int int_13 = 16;

		private Class9()
		{
		}
	}

	private sealed class Class12
	{
		private Class12()
		{
		}

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern bool PlaySound([MarshalAs(UnmanagedType.LPWStr)] string string_0, IntPtr intptr_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto, EntryPoint = "PlaySound")]
		internal static extern bool PlaySound_1(byte[] byte_0, IntPtr intptr_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr mmioOpen(string string_0, IntPtr intptr_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioAscend(IntPtr intptr_0, Class9.Class10 class10_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioDescend(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStruct)] Class9.Class10 class10_0, [MarshalAs(UnmanagedType.LPStruct)] Class9.Class10 class10_1, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioRead(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioClose(IntPtr intptr_0, int int_0);
	}

	private static readonly object object_0 = new object();

	private static readonly object object_1 = new object();

	private static readonly object object_2 = new object();

	private string string_0 = string.Empty;

	private ManualResetEvent manualResetEvent_0 = new ManualResetEvent(initialState: true);

	private const int int_0 = 1024;

	private const int int_1 = 10000;

	private Thread thread_0;

	private Stream stream_0;

	private bool bool_0;

	private AsyncOperation asyncOperation_0;

	private readonly SendOrPostCallback sendOrPostCallback_0;

	internal int int_2 = 10000;

	internal Uri uri_0;

	internal object object_3;

	internal int int_3;

	internal bool bool_1;

	internal Exception exception_0;

	internal byte[] byte_0;

	public int LoadTimeout
	{
		get
		{
			return int_2;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("");
			}
			int num = (int_2 = value);
		}
	}

	public string SoundLocation
	{
		get
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			if (uri_0 != null && uri_0.IsFile)
			{
				FileIOPermission val = new FileIOPermission(PermissionState.None);
				val.set_AllFiles((FileIOPermissionAccess)8);
				((CodeAccessPermission)val).Demand();
			}
			return string_0;
		}
		set
		{
			if (value == null)
			{
				value = string.Empty;
			}
			if (!string_0.Equals(value))
			{
				method_10(value);
				vmethod_1(EventArgs.Empty);
			}
		}
	}

	public Stream Stream
	{
		get
		{
			if (uri_0 != null)
			{
				return null;
			}
			return stream_0;
		}
		set
		{
			if (stream_0 != value)
			{
				method_11(value);
				vmethod_2(EventArgs.Empty);
			}
		}
	}

	public bool IsLoadCompleted => bool_1;

	public object Tag
	{
		get
		{
			return object_3;
		}
		set
		{
			object obj = (object_3 = value);
		}
	}

	public event AsyncCompletedEventHandler LoadCompleted
	{
		add
		{
			base.Events.AddHandler(object_0, value);
		}
		remove
		{
			base.Events.RemoveHandler(object_0, value);
		}
	}

	public event EventHandler SoundLocationChanged
	{
		add
		{
			base.Events.AddHandler(object_1, value);
		}
		remove
		{
			base.Events.RemoveHandler(object_1, value);
		}
	}

	public event EventHandler StreamChanged
	{
		add
		{
			base.Events.AddHandler(object_2, value);
		}
		remove
		{
			base.Events.RemoveHandler(object_2, value);
		}
	}

	public GClass1()
	{
		sendOrPostCallback_0 = method_1;
	}

	public GClass1(string soundLocation)
		: this()
	{
		if (soundLocation == null)
		{
			soundLocation = string.Empty;
		}
		method_10(soundLocation);
	}

	public GClass1(Stream stream)
		: this()
	{
		stream_0 = stream;
	}

	protected GClass1(SerializationInfo serializationInfo, StreamingContext context)
	{
		SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SerializationEntry current = enumerator.Current;
			switch (current.Name)
			{
			case "LoadTimeout":
				LoadTimeout = (int)current.Value;
				break;
			case "Stream":
				stream_0 = (Stream)current.Value;
				if (stream_0.CanSeek)
				{
					stream_0.Seek(0L, SeekOrigin.Begin);
				}
				break;
			case "SoundLocation":
				method_10((string)current.Value);
				break;
			}
		}
	}

	public void method_0()
	{
		if (uri_0 != null && uri_0.IsFile)
		{
			bool_1 = true;
			if (!new FileInfo(uri_0.LocalPath).Exists)
			{
				throw new FileNotFoundException("");
			}
			vmethod_0(new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else if (thread_0 == null || thread_0.ThreadState != 0)
		{
			bool_1 = false;
			byte[] array = (byte_0 = null);
			int_3 = 0;
			asyncOperation_0 = AsyncOperationManager.CreateOperation(null);
			method_6(bool_2: false);
		}
	}

	private void method_1(object object_4)
	{
		vmethod_0((AsyncCompletedEventArgs)object_4);
	}

	private void method_2()
	{
		int_3 = 0;
		byte[] array = (byte_0 = null);
		bool_1 = false;
		Exception ex = (exception_0 = null);
		bool_0 = false;
		thread_0 = null;
		manualResetEvent_0.Set();
	}

	public void method_3()
	{
		if (uri_0 != null && uri_0.IsFile)
		{
			if (!new FileInfo(uri_0.LocalPath).Exists)
			{
				throw new FileNotFoundException("");
			}
			bool_1 = true;
			vmethod_0(new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else
		{
			method_5();
		}
	}

	private void method_4(int int_4)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(string_0) && stream_0 == null)
		{
			SystemSounds.get_Beep().Play();
			return;
		}
		if (uri_0 != null && uri_0.IsFile)
		{
			string localPath = uri_0.LocalPath;
			((CodeAccessPermission)new FileIOPermission((FileIOPermissionAccess)1, localPath)).Demand();
			bool_1 = true;
			Class8.CodeAccessPermission_0.Demand();
			try
			{
				method_14(localPath);
				Class12.PlaySound(localPath, IntPtr.Zero, 2 | int_4);
				return;
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
		}
		method_5();
		smethod_2(byte_0);
		Class8.CodeAccessPermission_0.Demand();
		try
		{
			Class12.PlaySound_1(byte_0, IntPtr.Zero, 6 | int_4);
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	private void method_5()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!manualResetEvent_0.WaitOne(LoadTimeout, exitContext: false))
		{
			if (thread_0 != null)
			{
				thread_0.Abort();
			}
			method_2();
			throw new TimeoutException("");
		}
		if (byte_0 != null)
		{
			return;
		}
		if (uri_0 != null && !uri_0.IsFile && stream_0 == null)
		{
			((CodeAccessPermission)new WebPermission((NetworkAccess)64, uri_0.AbsolutePath)).Demand();
			WebRequest webRequest = WebRequest.Create(uri_0);
			webRequest.Timeout = LoadTimeout;
			stream_0 = webRequest.GetResponse().GetResponseStream();
		}
		if (stream_0.CanSeek)
		{
			method_6(bool_2: true);
		}
		else
		{
			bool_0 = true;
			method_6(bool_2: false);
			if (!manualResetEvent_0.WaitOne(LoadTimeout, exitContext: false))
			{
				if (thread_0 != null)
				{
					thread_0.Abort();
				}
				method_2();
				throw new TimeoutException("");
			}
			bool_0 = false;
			if (exception_0 != null)
			{
				throw exception_0;
			}
		}
		thread_0 = null;
	}

	private void method_6(bool bool_2)
	{
		if (bool_2 && stream_0.CanSeek)
		{
			int num = (int)stream_0.Length;
			int_3 = 0;
			byte[] array = (byte_0 = new byte[num]);
			stream_0.Read(byte_0, 0, num);
			bool_1 = true;
			vmethod_0(new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else
		{
			manualResetEvent_0.Reset();
			thread_0 = new Thread(method_13);
			thread_0.Start();
		}
	}

	public void method_7()
	{
		method_4(1);
	}

	public void method_8()
	{
		method_4(0);
	}

	public void method_9()
	{
		method_4(9);
	}

	private static Uri smethod_0(string string_1)
	{
		Uri uri = null;
		try
		{
			uri = new Uri(string_1);
		}
		catch (UriFormatException)
		{
		}
		if (uri == null)
		{
			try
			{
				uri = new Uri(Path.GetFullPath(string_1));
				return uri;
			}
			catch (UriFormatException)
			{
				return uri;
			}
		}
		return uri;
	}

	internal static void smethod_1()
	{
		AppDomain.CurrentDomain.AssemblyResolve += (object object_0, ResolveEventArgs resolveEventArgs_0) => GStruct1.smethod_0(object_0, resolveEventArgs_0, out var assembly_) ? assembly_ : null;
	}

	private void method_10(string string_1)
	{
		if (thread_0 != null)
		{
			thread_0.Abort();
			method_2();
		}
		Uri uri = (uri_0 = smethod_0(string_1));
		string_0 = string_1;
		stream_0 = null;
		if (uri_0 == null)
		{
			if (!string.IsNullOrEmpty(string_1))
			{
				throw new UriFormatException("");
			}
		}
		else if (!uri_0.IsFile)
		{
			byte[] array = (byte_0 = null);
			int_3 = 0;
			bool_1 = false;
		}
	}

	private void method_11(Stream stream_1)
	{
		if (thread_0 != null)
		{
			thread_0.Abort();
			method_2();
		}
		stream_0 = stream_1;
		string_0 = string.Empty;
		byte[] array = (byte_0 = null);
		int_3 = 0;
		bool_1 = false;
		if (stream_1 != null)
		{
			Uri uri = (uri_0 = null);
		}
	}

	public void method_12()
	{
		Class8.CodeAccessPermission_0.Demand();
		Class12.PlaySound_1(null, IntPtr.Zero, 64);
	}

	protected virtual void vmethod_0(AsyncCompletedEventArgs asyncCompletedEventArgs_0)
	{
		((AsyncCompletedEventHandler)base.Events[object_0])?.Invoke(this, asyncCompletedEventArgs_0);
	}

	protected virtual void vmethod_1(EventArgs eventArgs_0)
	{
		((EventHandler)base.Events[object_1])?.Invoke(this, eventArgs_0);
	}

	protected virtual void vmethod_2(EventArgs eventArgs_0)
	{
		((EventHandler)base.Events[object_2])?.Invoke(this, eventArgs_0);
	}

	private void method_13()
	{
		try
		{
			if (uri_0 != null && !uri_0.IsFile && stream_0 == null)
			{
				stream_0 = WebRequest.Create(uri_0).GetResponse().GetResponseStream();
			}
			byte[] array = (byte_0 = new byte[1024]);
			int num = stream_0.Read(byte_0, int_3, 1024);
			int num2 = num;
			while (num > 0)
			{
				int_3 += num;
				if (byte_0.Length < int_3 + 1024)
				{
					byte[] destinationArray = new byte[byte_0.Length * 2];
					Array.Copy(byte_0, destinationArray, byte_0.Length);
					byte[] array2 = (byte_0 = destinationArray);
				}
				num = stream_0.Read(byte_0, int_3, 1024);
				num2 += num;
			}
			Exception ex = (exception_0 = null);
		}
		catch (Exception ex2)
		{
			Exception ex3 = (exception_0 = ex2);
		}
		if (!bool_0)
		{
			asyncOperation_0.PostOperationCompleted(sendOrPostCallback_0, new AsyncCompletedEventArgs(exception_0, cancelled: false, null));
		}
		bool_1 = true;
		manualResetEvent_0.Set();
	}

	private unsafe void method_14(string string_1)
	{
		Class9.Class10 @class = new Class9.Class10();
		Class9.Class10 class2 = new Class9.Class10();
		Class9.Class11 class3 = null;
		IntPtr intPtr = Class12.mmioOpen(string_1, IntPtr.Zero, 65536);
		try
		{
			@class.int_2 = smethod_5('W', 'A', 'V', 'E');
			while (true)
			{
				if (Class12.mmioDescend(intPtr, class2, @class, 0) == 0)
				{
					if (class2.int_3 + class2.int_1 <= @class.int_3 + @class.int_1)
					{
						if (class2.int_0 == smethod_5('f', 'm', 't', ' ') && class3 == null)
						{
							int num = class2.int_1;
							if (num < Marshal.SizeOf(typeof(Class9.Class11)))
							{
								num = Marshal.SizeOf(typeof(Class9.Class11));
							}
							class3 = new Class9.Class11();
							byte[] array = new byte[num];
							try
							{
								fixed (byte* ptr = array)
								{
									Marshal.PtrToStructure((IntPtr)ptr, (object)class3);
								}
							}
							finally
							{
							}
						}
						Class12.mmioAscend(intPtr, class2, 0);
						continue;
					}
					throw new InvalidOperationException("");
				}
				if (class3 == null)
				{
					throw new InvalidOperationException("");
				}
				if (class3.short_0 != 1 && class3.short_0 != 2 && class3.short_0 != 3)
				{
					throw new InvalidOperationException("");
				}
				break;
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Class12.mmioClose(intPtr, 0);
			}
		}
	}

	private static void smethod_2(byte[] byte_1)
	{
		short num = -1;
		bool flag = false;
		int num2 = 12;
		int num3 = byte_1.Length;
		while (!flag && num2 < num3 - 8)
		{
			if (byte_1[num2] == 102 && byte_1[num2 + 1] == 109 && byte_1[num2 + 2] == 116 && byte_1[num2 + 3] == 32)
			{
				flag = true;
				int num4 = smethod_4(byte_1[num2 + 7], byte_1[num2 + 6], byte_1[num2 + 5], byte_1[num2 + 4]);
				if (num4 != 16)
				{
					int num5 = 18;
					if (num3 < num2 + 8 + 18 - 1)
					{
						throw new InvalidOperationException("");
					}
					if (smethod_3(byte_1[num2 + 8 + num5 - 1], byte_1[num2 + 8 + num5 - 2]) + num5 != num4)
					{
						throw new InvalidOperationException("");
					}
				}
				if (num3 < num2 + 9)
				{
					throw new InvalidOperationException("");
				}
				num = smethod_3(byte_1[num2 + 9], byte_1[num2 + 8]);
				num2 += num4 + 8;
			}
			else
			{
				num2 += 8 + smethod_4(byte_1[num2 + 7], byte_1[num2 + 6], byte_1[num2 + 5], byte_1[num2 + 4]);
			}
		}
		if (!flag)
		{
			throw new InvalidOperationException("");
		}
		if (num != 1 && num != 2 && num != 3)
		{
			throw new InvalidOperationException("");
		}
	}

	private static short smethod_3(byte byte_1, byte byte_2)
	{
		return (short)(byte_2 | (byte_1 << 8));
	}

	private static int smethod_4(byte byte_1, byte byte_2, byte byte_3, byte byte_4)
	{
		return smethod_5((char)byte_4, (char)byte_3, (char)byte_2, (char)byte_1);
	}

	private static int smethod_5(char char_0, char char_1, char char_2, char char_3)
	{
		return 0 | char_0 | (int)((uint)char_1 << 8) | (int)((uint)char_2 << 16) | (int)((uint)char_3 << 24);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			info.AddValue("SoundLocation", string_0);
		}
		if (stream_0 != null)
		{
			info.AddValue("Stream", stream_0);
		}
		info.AddValue("LoadTimeout", int_2);
	}
}
