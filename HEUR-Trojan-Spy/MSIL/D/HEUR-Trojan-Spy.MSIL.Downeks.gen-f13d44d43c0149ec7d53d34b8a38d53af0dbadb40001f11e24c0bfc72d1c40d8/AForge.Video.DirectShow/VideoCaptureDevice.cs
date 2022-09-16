using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using dg3ypDAonQcOidMs0w;

namespace AForge.Video.DirectShow;

public class VideoCaptureDevice : GInterface5
{
	private class Grabber : Interface18
	{
		private object parent;

		private bool snapshotMode;

		private int width;

		private int height;

		private static object F9x0GDPGWtCOYM0A9hO;

		public int Width
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Height
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Grabber(VideoCaptureDevice parent, bool snapshotMode)
		{
		}

		public int SampleCB(double sampleTime, IntPtr sample)
		{
			return 0;
		}

		public int BufferCB(double sampleTime, IntPtr buffer, int bufferLen)
		{
			return 0;
		}

		static Grabber()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			g8RVJvPam3XQSSwkP6o();
		}

		internal static bool YmMm3QPncbL0v1m0yXt()
		{
			return true;
		}

		internal static Grabber B4hOIcPXu0Djx2Gx6Cs()
		{
			return null;
		}

		internal static void kdMfNGPIQJliZy95rp3()
		{
		}

		internal static object PaqVFDPvtITeykkP7bR(object object_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0)
		{
			return null;
		}

		internal static int uPtJx6PkcPkAGTJgMjU(object object_0)
		{
			return 0;
		}

		internal static IntPtr ts6Hs6PfJE3WMFXY8xG(object object_0)
		{
			return (IntPtr)(object)null;
		}

		internal static void ofyvIePSWKcUVevhXe1(object object_0, object object_1)
		{
		}

		internal static void GPIv3tPcKrG2USxLqro(object object_0, object object_1)
		{
		}

		internal static void CDvMAOPYCgxMcaRRJEe(object object_0, object object_1)
		{
		}

		internal static void JJnxrbPRKatf8jTRHh8(object object_0)
		{
		}

		internal static void g8RVJvPam3XQSSwkP6o()
		{
		}
	}

	private string deviceMoniker;

	private int framesReceived;

	private long bytesReceived;

	private GClass60 videoResolution;

	private GClass60 snapshotResolution;

	private bool provideSnapshots;

	private Thread thread;

	private ManualResetEvent stopEvent;

	private GClass60[] videoCapabilities;

	private GClass60[] snapshotCapabilities;

	private bool needToSetVideoInput;

	private bool needToSimulateTrigger;

	private bool needToDisplayPropertyPage;

	private bool needToDisplayCrossBarPropertyPage;

	private IntPtr parentWindowForPropertyPage;

	private object sourceObject;

	private DateTime startTime;

	private object sync;

	private bool? isCrossbarAvailable;

	private GClass61[] crossbarVideoInputs;

	private GClass61 crossbarVideoInput;

	private static Dictionary<string, GClass60[]> cacheVideoCapabilities;

	private static Dictionary<string, GClass60[]> cacheSnapshotCapabilities;

	private static Dictionary<string, GClass61[]> cacheCrossbarVideoInputs;

	[CompilerGenerated]
	private GDelegate7 NewFrame;

	[CompilerGenerated]
	private GDelegate8 VideoSourceError;

	[CompilerGenerated]
	private GDelegate9 PlayingFinished;

	internal static VideoCaptureDevice wBLn4JTxdx9BHjupudV;

	public GClass61 CrossbarVideoInput
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GClass61[] AvailableCrossbarVideoInputs => null;

	public bool ProvideSnapshots
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public virtual string Source
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int FramesReceived => 0;

	public long BytesReceived => 0L;

	public bool IsRunning => true;

	[Obsolete]
	public Size DesiredFrameSize
	{
		get
		{
			return (Size)(object)null;
		}
		set
		{
		}
	}

	[Obsolete]
	public Size DesiredSnapshotSize
	{
		get
		{
			return (Size)(object)null;
		}
		set
		{
		}
	}

	[Obsolete]
	public int DesiredFrameRate
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public GClass60 VideoResolution
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GClass60 SnapshotResolution
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GClass60[] VideoCapabilities => null;

	public GClass60[] SnapshotCapabilities => null;

	public object SourceObject => null;

	public event GDelegate7 Event_0
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event GDelegate7 SnapshotFrame
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event GDelegate8 Event_1
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event GDelegate9 Event_2
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public VideoCaptureDevice()
	{
	}

	public VideoCaptureDevice(string deviceMoniker)
	{
	}

	public void Start()
	{
	}

	public void SignalToStop()
	{
	}

	public void WaitForStop()
	{
	}

	public void Stop()
	{
	}

	private void Free()
	{
	}

	public void DisplayPropertyPage(IntPtr parentWindow)
	{
	}

	public void DisplayCrossbarPropertyPage(IntPtr parentWindow)
	{
	}

	public bool CheckIfCrossbarAvailable()
	{
		return true;
	}

	public void SimulateTrigger()
	{
	}

	public bool SetCameraProperty(GEnum10 property, int value, GEnum11 controlFlags)
	{
		return true;
	}

	public bool GetCameraProperty(GEnum10 property, out int value, out GEnum11 controlFlags)
	{
		return true;
	}

	public bool GetCameraPropertyRange(GEnum10 property, out int minValue, out int maxValue, out int stepSize, out int defaultValue, out GEnum11 controlFlags)
	{
		return true;
	}

	private void WorkerThread()
	{
	}

	private void WorkerThread(bool runGraph)
	{
	}

	private void SetResolution(Interface2 streamConfig, GClass60 resolution)
	{
	}

	private void GetPinCapabilitiesAndConfigureSizeAndRate(Interface5 graphBuilder, Interface4 baseFilter, Guid pinCategory, GClass60 resolutionToSet, ref GClass60[] capabilities)
	{
	}

	private void DisplayPropertyPage(IntPtr parentWindow, object sourceObject)
	{
	}

	private GClass61[] ColletCrossbarVideoInputs(Interface1 crossbar)
	{
		return null;
	}

	private GClass61 GetCurrentCrossbarInput(Interface1 crossbar)
	{
		return null;
	}

	private void SetCurrentCrossbarInput(Interface1 crossbar, GClass61 videoInput)
	{
	}

	private void OnNewFrame(Bitmap image)
	{
	}

	private void OnSnapshotFrame(Bitmap image)
	{
	}

	static VideoCaptureDevice()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		tcLODETiouOsVdS7udw();
		eiNqCMT50HS6qpT1yFU();
		cacheVideoCapabilities = new Dictionary<string, GClass60[]>();
		cacheSnapshotCapabilities = new Dictionary<string, GClass60[]>();
		cacheCrossbarVideoInputs = new Dictionary<string, GClass61[]>();
	}

	internal static bool SsFuruTLkrwraDJatkj()
	{
		return true;
	}

	internal static VideoCaptureDevice MPuqH0TJbnVbv7ntFVv()
	{
		return null;
	}

	internal static bool nnPAvyTpqf5ZJYrOXc6(object object_0)
	{
		return true;
	}

	internal static void AbIbokTmTnSDWrIlSRL(object object_0)
	{
	}

	internal static void nWKvPNT8fh6SV4mUDcO(int int_0)
	{
	}

	internal static object HoA3HmTrsQ4oUjkD4TR(object object_0, object object_1)
	{
		return null;
	}

	internal static object HJcGR3TESBwNIAcadhp(object object_0, object object_1)
	{
		return null;
	}

	internal static bool KRiKG2TOZ7y0m2AfbEH(object object_0, int int_0)
	{
		return true;
	}

	internal static void tcLODETiouOsVdS7udw()
	{
	}

	internal static object cnIv7ST92QIdIXAdp3m()
	{
		return null;
	}

	internal static void eiNqCMT50HS6qpT1yFU()
	{
	}

	internal static object OooyrlT4EJQMyavNIKg(int int_0)
	{
		return null;
	}

	internal static void k6yombThuJFpRM1RyCW(object object_0, object object_1)
	{
	}

	internal static void Jvh3HNTw6hD4rkwwHdY(object object_0)
	{
	}

	internal static bool RT5gZRTygJCXNg5LMQ0(object object_0)
	{
		return true;
	}

	internal static void bjWxNhTl1b3b6qw9vpK(object object_0)
	{
	}

	internal static void jpjO02THIBf2GtROR7Y(object object_0)
	{
	}

	internal static void IQ9xQJTVQdsglsHmbns(object object_0)
	{
	}

	internal static bool zwhJmtTMXUDHCkabo4E(object object_0, object object_1)
	{
		return true;
	}

	internal static object CDTfwjTtQP83KZlKlCv(object object_0)
	{
		return null;
	}

	internal static int yaeeVKTU8WZfUN0ByUN(object object_0)
	{
		return 0;
	}

	internal static Type Tuwtm4TTYRgbyPbY9uB(Guid guid_0)
	{
		return null;
	}

	internal static bool wXogmhTPCO5uj77hDrq(Type type_0, Type type_1)
	{
		return true;
	}

	internal static object VLul6QTeTlVoC0gWSS0(Type type_0)
	{
		return null;
	}

	internal static RuntimeTypeHandle qlYH9yT26lmssVx6Ver(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static Type pV9plHT0QDJH31oOxlw(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static int s29PBMTKuiFeUPWtnIf(object object_0, object object_1, int whichMethodToCallback)
	{
		return 0;
	}

	internal static object pSQ4IvTBF2XJ5Wt5PKJ(IntPtr intptr_0, Type type_0)
	{
		return null;
	}

	internal static void wBj1rQTN5Mi18QP5V2X(object object_0, int value)
	{
	}

	internal static void lpZQrdTZlsO2Xk17APe(object object_0, int value)
	{
	}

	internal static void lw2n3jTQyJqTgcno0P2(object object_0)
	{
	}

	internal static int kvabhbTj3W34CqSmIp5(object object_0)
	{
		return 0;
	}

	internal static bool cg75SqTsV6NGobhGpgU(object object_0, int int_0, bool bool_0)
	{
		return true;
	}

	internal static int JSlkhSTdB3McibXGKsj(object object_0)
	{
		return 0;
	}

	internal static object dZptJ3TAfdEYa9SjiAN(object object_0)
	{
		return null;
	}

	internal static void gCRpoKT3aLOh5guVaPD(object object_0, object object_1, GEnum9 reason)
	{
	}

	internal static bool SQIb3vT1srfuQnRKEyi(object object_0, object object_1)
	{
		return true;
	}

	internal static object LlxVibTqsgSpT1Oqrat(object object_0)
	{
		return null;
	}

	internal static bool GU9ToyTbBmQBOfoooQH(object object_0, object object_1)
	{
		return true;
	}

	internal static object mCJBehT7MyuPAT8ydON(object object_0)
	{
		return null;
	}

	internal static void XfGyGDTu1HNoLs4pTCh(IntPtr intptr_0)
	{
	}

	internal static void pQtENUTzMLir5itpfor(object object_0, object object_1)
	{
	}

	internal static int dYJ9YEPFreKcxCrNMX7(object object_0)
	{
		return 0;
	}

	internal static int FeTVuaPClEJyVLpELX5(object object_0)
	{
		return 0;
	}

	internal static PixelFormat DdR6a9PW6PFw3Zhww9b(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (PixelFormat)(object)null;
	}

	internal static int Q8MiQtPoqPTR7JdETVJ(PixelFormat pixelFormat_0)
	{
		return 0;
	}

	internal static void pGkGfDP6BxcpyRqJUKh(object object_0, object object_1, object object_2)
	{
	}

	internal static DateTime BkRLNSPggveuW8PtMEb()
	{
		return (DateTime)(object)null;
	}

	internal static TimeSpan iVn6x7PD5e9GD4VhCZr(DateTime dateTime_0, DateTime dateTime_1)
	{
		return (TimeSpan)(object)null;
	}
}
