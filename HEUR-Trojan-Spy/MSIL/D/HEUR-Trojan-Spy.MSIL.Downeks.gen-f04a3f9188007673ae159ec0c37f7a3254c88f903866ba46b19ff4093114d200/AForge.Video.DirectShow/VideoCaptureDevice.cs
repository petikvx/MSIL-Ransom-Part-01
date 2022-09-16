using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace AForge.Video.DirectShow;

public class VideoCaptureDevice : GInterface5
{
	private class Grabber : Interface18
	{
		private object parent;

		private bool snapshotMode;

		private int width;

		private int height;

		private static object NQJC8MT0mAPeXBtGGty;

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
			m7TiNxTTZsPBSE0ZyxN();
		}

		internal static bool hqgNdCT1JqcTb8UhICH()
		{
			return true;
		}

		internal static Grabber OZ3wwZTIfn3iaSFAe9W()
		{
			return null;
		}

		internal static void BiAn1WTK27Ag3ExZ7a3()
		{
		}

		internal static void Y3f850TO1LdG7EyPW23()
		{
		}

		internal static object FwASngTYDRd7HfHTSPj(object object_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0)
		{
			return null;
		}

		internal static int QLJbyyT6WK99Tr7rQfE(object object_0)
		{
			return 0;
		}

		internal static IntPtr H7y0y3Tk0MA1RFDgQbB(object object_0)
		{
			return (IntPtr)(object)null;
		}

		internal static void oDkvNKTsC5wPqvG8pxQ(object object_0, object object_1)
		{
		}

		internal static void vSKxJtTuZLIk4nZ1QaA(object object_0, object object_1)
		{
		}

		internal static void NM7ndITAVYdvx9xUXND(object object_0, object object_1)
		{
		}

		internal static void UT2si3TQO2qbNkDrm2I(object object_0)
		{
		}

		internal static void m7TiNxTTZsPBSE0ZyxN()
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

	internal static VideoCaptureDevice vkV4waQ8jQi0RDadtxq;

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
		LoUTBhTooIrRwcvrwpX();
		RYdxVgQ5uS8gZiRHeQ9();
		hHEYokUTtehNq5ji0d.xInixXOzdqnqK();
		cacheVideoCapabilities = new Dictionary<string, GClass60[]>();
		cacheSnapshotCapabilities = new Dictionary<string, GClass60[]>();
		cacheCrossbarVideoInputs = new Dictionary<string, GClass61[]>();
	}

	internal static bool JuaEDDQrTcAmtYiwUcA()
	{
		return true;
	}

	internal static VideoCaptureDevice YMgDDKQhxtM2j3VtAfG()
	{
		return null;
	}

	internal static bool u6bxWsQRoBEeuUDtHky(object object_0)
	{
		return true;
	}

	internal static void OZAlYCQpgv1veWSkHXB(object object_0)
	{
	}

	internal static void jSXT69QcNJWh2BocFbP(int int_0)
	{
	}

	internal static object TCSMtwQBjS7RbCMi7Qq(object object_0, object object_1)
	{
		return null;
	}

	internal static object Jdat5iQfMm61g7VIE1b(object object_0, object object_1)
	{
		return null;
	}

	internal static bool RixjN8QG8VuijIk96Vx(object object_0, int int_0)
	{
		return true;
	}

	internal static void RYdxVgQ5uS8gZiRHeQ9()
	{
	}

	internal static object GOfZ4PQJn7BRRBAJ12q()
	{
		return null;
	}

	internal static void HLWouiQWSNPRG8Ijunc()
	{
	}

	internal static object XiuQMsQHCgpRK6Z7jRs(int int_0)
	{
		return null;
	}

	internal static void JqXXO1QZnr8LfekS9Wn(object object_0, object object_1)
	{
	}

	internal static bool BtYXXhQlZ9jcb1OnHWb(object object_0)
	{
		return true;
	}

	internal static void U4ynQCQ9cwS91QgEebT(object object_0)
	{
	}

	internal static void Od9mR6QD0JbgWOt0NTN(object object_0)
	{
	}

	internal static bool y3VvYaQdnxyFQ25NrCO(object object_0, object object_1)
	{
		return true;
	}

	internal static object rKWNeCQzu3CW2UifOO5(object object_0)
	{
		return null;
	}

	internal static int PmPAYJTbswqG6D3Ko6n(object object_0)
	{
		return 0;
	}

	internal static Type QcloMfT4s2ZwMKUmDRe(Guid guid_0)
	{
		return null;
	}

	internal static bool HFtTT4Tn3Amm358kKnd(Type type_0, Type type_1)
	{
		return true;
	}

	internal static object KB0e7jTUo9sFhrMyrNx(Type type_0)
	{
		return null;
	}

	internal static RuntimeTypeHandle EJXr70TLnJJrlukQRJL(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static int QcmV95TNZiKt0fgtoSY(object object_0, object object_1, int whichMethodToCallback)
	{
		return 0;
	}

	internal static Type pskXsOTjjI8kHWYfuJM(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static object oEDZqUTa7ZqBxW7KLQH(IntPtr intptr_0, Type type_0)
	{
		return null;
	}

	internal static void va49ZNTMLPMoAFSN7Fw(object object_0, int value)
	{
	}

	internal static void j7Y82kTqkniUV9kAqjn(object object_0, int value)
	{
	}

	internal static void lxGNU0TemAAa3EQtYMJ(object object_0)
	{
	}

	internal static DateTime yj4VyrTXOSOPvJhI3r9()
	{
		return (DateTime)(object)null;
	}

	internal static bool u8sSDMTgMk6SssKHfRA(object object_0, int int_0, bool bool_0)
	{
		return true;
	}

	internal static int aGgqmVT7nFwMUVS1FwJ(object object_0)
	{
		return 0;
	}

	internal static object iqegvMTSWROVnIjA42Y(object object_0)
	{
		return null;
	}

	internal static void ioZkWhT3iLSvLoFHQ8H(object object_0, object object_1, object object_2)
	{
	}

	internal static void iWHdLkTvaMoml8a6GDw(object object_0, object object_1, GEnum9 reason)
	{
	}

	internal static bool ItKYYVTyBBNDtEm1HJH(object object_0, object object_1)
	{
		return true;
	}

	internal static object PML72MTPkWJLXokx1D2(object object_0)
	{
		return null;
	}

	internal static object zxOT2QTVB5wQGiljM1c(object object_0)
	{
		return null;
	}

	internal static void Anvs1eTFIJAdPQ2sE5u(IntPtr intptr_0)
	{
	}

	internal static int FcluXYTE732eEk3isbu(object object_0)
	{
		return 0;
	}

	internal static void nVARZ3TwOjAKtu0LwEp(object object_0, object object_1)
	{
	}

	internal static int kvZEdnTmEMKfU8N2t2n(object object_0)
	{
		return 0;
	}

	internal static int CA6KmgT2n83r0NNawXs(object object_0)
	{
		return 0;
	}

	internal static PixelFormat UpwIsdTtkToufX9VPFj(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (PixelFormat)(object)null;
	}

	internal static int tEh3BGTCQ0AnerKYDVk(PixelFormat pixelFormat_0)
	{
		return 0;
	}

	internal static TimeSpan BAYyfQTxJUBSYKKd89x(DateTime dateTime_0, DateTime dateTime_1)
	{
		return (TimeSpan)(object)null;
	}

	internal static void LoUTBhTooIrRwcvrwpX()
	{
	}
}
