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

		private static object JakBSBq3ppsYau0vTKy;

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
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}

		internal static bool JSSEg6qrSv8lBEnGjWE()
		{
			return true;
		}

		internal static Grabber wX6AWAqe6NeOwQCHpqT()
		{
			return null;
		}

		internal static void f1wUeDqOuTQ64VOtoiK()
		{
		}

		internal static void Yt7413q0usbHahrYJnW()
		{
		}

		internal static int bwIjJVqddC0WyD3qTJ8(object object_0)
		{
			return 0;
		}

		internal static IntPtr kJn2yCqEsZm2WcKknAN(object object_0)
		{
			return (IntPtr)(object)null;
		}

		internal static void yOFq1aqh9MjrwXswb72(object object_0, object object_1)
		{
		}

		internal static void rZyR6bqM2SbYgrtiAhk(object object_0, object object_1)
		{
		}

		internal static void sIt1JyqCgBpAWkaFq3W(object object_0, object object_1)
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

	private static VideoCaptureDevice m6tJjiJ8nCoBwUlEOnP;

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
		ptUBQxqZZLMnTPlNLel();
		hnD5TcqPEnxRX6Qowmn();
		cacheVideoCapabilities = new Dictionary<string, GClass60[]>();
		cacheSnapshotCapabilities = new Dictionary<string, GClass60[]>();
		cacheCrossbarVideoInputs = new Dictionary<string, GClass61[]>();
	}

	internal static bool bljAQ9J9ZTkMnuhs9YM()
	{
		return true;
	}

	internal static VideoCaptureDevice msQxvYJXFKenA0RsVNe()
	{
		return null;
	}

	internal static bool q3WslwJzNNDBjkDh7jb(object object_0)
	{
		return true;
	}

	internal static void rmQ6vUqtC5jmFck9D2m(object object_0)
	{
	}

	internal static object Dqn1ObqxWpGgAFNN7tw(object object_0, object object_1)
	{
		return null;
	}

	internal static object vvkaF6qc7jGdcxKLAlf(object object_0, object object_1)
	{
		return null;
	}

	internal static bool buG2DxqHEEyVOvjyfFx(object object_0, int int_0)
	{
		return true;
	}

	internal static void mPGcbuqvNQ9C67dKqvE(int int_0)
	{
	}

	internal static void hnD5TcqPEnxRX6Qowmn()
	{
	}

	internal static object Uywe7Vq1AvGXk3PJrt0()
	{
		return null;
	}

	internal static object nyIR9PqpBI3guMO3She(int int_0)
	{
		return null;
	}

	internal static void ElQ8N9qVWKhegqF6c3J(object object_0)
	{
	}

	internal static bool fp1T3UqkZ11upIkkL7T(object object_0)
	{
		return true;
	}

	internal static void W9dyyVqYXWCPvi3JSmQ(object object_0)
	{
	}

	internal static void x5WxmqqFeAdjK8mLHUA(object object_0)
	{
	}

	internal static void xCQDT2qlCViG1wE5pAi(object object_0)
	{
	}

	internal static bool QAsleiqgJNZspx5PbyI(object object_0, object object_1)
	{
		return true;
	}

	internal static object XDsNA9qaOy3fxniNbnS(object object_0)
	{
		return null;
	}

	internal static int HUerd8qjnjy6RsqbCun(object object_0)
	{
		return 0;
	}

	internal static Type JNZjVrqnFlAVJoqDNnv(Guid guid_0)
	{
		return null;
	}

	internal static bool GhAPKpq2aYuyQ3GDIvf(Type type_0, Type type_1)
	{
		return true;
	}

	internal static object eTFrUNqwSbmGwHRgWrC(Type type_0)
	{
		return null;
	}

	internal static RuntimeTypeHandle cFnpA9qS4aj4EiPW88V(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static Type cKhybNqUrc8UpTDDgHo(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static int lSS2aqq412rVCR5UreB(object object_0, object object_1, int whichMethodToCallback)
	{
		return 0;
	}

	internal static object EOL05Rq71V80qOCHEO3(IntPtr intptr_0, Type type_0)
	{
		return null;
	}

	internal static void eTM2kyq5vXmOg1BI8yA(object object_0, int value)
	{
	}

	internal static void hw60WRqGfqvaswmXwfq(object object_0, int value)
	{
	}

	internal static void XibIH5qoZjdUihMqbML(object object_0)
	{
	}

	internal static DateTime Yh5klsqfxqrt1lXVTyC()
	{
		return (DateTime)(object)null;
	}

	internal static bool rputfLqTxWkqh6qGAEA(object object_0, int int_0, bool bool_0)
	{
		return true;
	}

	internal static int icA9tpqsfxPgwxyLDUN(object object_0)
	{
		return 0;
	}

	internal static object zb4q00qiI0mHdIDiWvP(object object_0)
	{
		return null;
	}

	internal static void Ro3onNqIGSTDljmyIFu(object object_0, object object_1, object object_2)
	{
	}

	internal static void fv5PcPqKJWLxShon8ML(object object_0, object object_1, GEnum9 reason)
	{
	}

	internal static bool nmWLddqbHWlf7Rc8vYk(object object_0, object object_1)
	{
		return true;
	}

	internal static object WApqKqqB66vsJ78TCwD(object object_0)
	{
		return null;
	}

	internal static bool mtGFH6qLg4i8H5g5LSV(object object_0, object object_1)
	{
		return true;
	}

	internal static void bTSwAhqRdh0cZklpyhP(IntPtr intptr_0)
	{
	}

	internal static int aG6OCMqudIYTLOqRD1N(object object_0)
	{
		return 0;
	}

	internal static int bilf7EqWfAuR4hZ0FfH(object object_0)
	{
		return 0;
	}

	internal static int XIbwSyq6ddcxCpVxhnq(object object_0)
	{
		return 0;
	}

	internal static PixelFormat opT4YjqmXyny54ma8rN(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (PixelFormat)(object)null;
	}

	internal static int PjZCh8qJMplGUTDwpgV(PixelFormat pixelFormat_0)
	{
		return 0;
	}

	internal static void svUfMRqquKixQMmL5lT(object object_0, object object_1, object object_2)
	{
	}

	internal static TimeSpan UWnrkkqNJs3vgPd3al3(DateTime dateTime_0, DateTime dateTime_1)
	{
		return (TimeSpan)(object)null;
	}

	internal static void ptUBQxqZZLMnTPlNLel()
	{
	}
}
