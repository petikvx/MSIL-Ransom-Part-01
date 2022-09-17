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

		internal static object IFboOiv9uZuEqGInYaO;

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
			ujnmWcuSApmo8qAm7gi();
		}

		internal static bool URndLRvQGawW8lg0NdY()
		{
			return true;
		}

		internal static Grabber yYoXDIvz8nJF8ZFgtbK()
		{
			return null;
		}

		internal static void wOMtsWulOi8gIKnt0BH()
		{
		}

		internal static object Bej3NVuqmU2BhkrIG3G(object object_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0)
		{
			return null;
		}

		internal static int x9WO0Ru5l21AnUWmAIQ(object object_0)
		{
			return 0;
		}

		internal static IntPtr tDmTQIuA1SU6ZaS4ie5(object object_0)
		{
			return (IntPtr)(object)null;
		}

		internal static void lq2C52uMyHD0xbfgKQP(object object_0, object object_1)
		{
		}

		internal static void UB8U6uuXCPjFTVLQLNk(object object_0, object object_1)
		{
		}

		internal static void zFpjAEui4RhLpGySY71(object object_0, object object_1)
		{
		}

		internal static void Ibneh4uk5GEdRKpb1n5(object object_0)
		{
		}

		internal static void ujnmWcuSApmo8qAm7gi()
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

	internal static VideoCaptureDevice VXEGeBveE9uFBrYdahW;

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
		VAbTNPvpwGO5QAALEpI();
		O5ShgMvbhLKmjRb5e4B();
		hHEYokUTtehNq5ji0d.BUZgdfmzxASR9();
		cacheVideoCapabilities = new Dictionary<string, GClass60[]>();
		cacheSnapshotCapabilities = new Dictionary<string, GClass60[]>();
		cacheCrossbarVideoInputs = new Dictionary<string, GClass61[]>();
	}

	internal static bool XaYqDhvOo6i1ePEPlwX()
	{
		return true;
	}

	internal static VideoCaptureDevice SH4wI5vWINt0FZjniCY()
	{
		return null;
	}

	internal static void oOyy1UvVs3T8Spi6A2v(object object_0)
	{
	}

	internal static void PWpFhwv2yPxZIbaT8qf(int int_0)
	{
	}

	internal static object QWVmByvxYTniZtgRSnm(object object_0, object object_1)
	{
		return null;
	}

	internal static object sjRh7bvayca2m3q7FMD(object object_0, object object_1)
	{
		return null;
	}

	internal static bool BLtA3sv4sTLEoH2jRGI(object object_0)
	{
		return true;
	}

	internal static void O5ShgMvbhLKmjRb5e4B()
	{
	}

	internal static void dA0ojtvExdKkaL1cYeS()
	{
	}

	internal static object RLlf0dvB7yEQokYwEiy()
	{
		return null;
	}

	internal static void gZc5yAvTbGYkgSOfR40(object object_0, object object_1)
	{
	}

	internal static void kw9Z0WvZx6LJv4Wf2AD(object object_0)
	{
	}

	internal static void jMaQAuvgKAgldlqvb3R(object object_0)
	{
	}

	internal static void DnGpjkvFmNbm9vCc8yb(object object_0)
	{
	}

	internal static void wWjntNvUcxAmEUNMlIN(object object_0)
	{
	}

	internal static bool GTiq6pvmkWAKrAYECL5(object object_0, object object_1)
	{
		return true;
	}

	internal static object LnYWxAv3A3909F5RJlK(int int_0)
	{
		return null;
	}

	internal static object N0qwysvcrf78qnSKHBv(object object_0)
	{
		return null;
	}

	internal static int EG98pvvsP9vnkYFV0ZN(object object_0)
	{
		return 0;
	}

	internal static Type QTSkThvJVFhMLJ0iasj(Guid guid_0)
	{
		return null;
	}

	internal static object uRjxVgvGXbhBkRwaGCo(Type type_0)
	{
		return null;
	}

	internal static bool fdnvuTv7kCRZ7ifVciw(Type type_0, Type type_1)
	{
		return true;
	}

	internal static RuntimeTypeHandle kZRWEPvYH2mfCx3FBdw(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static Type PwO8U6vwVfIywy9ZCPx(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static int gctXciv8MMgoT809KwS(object object_0, object object_1, int whichMethodToCallback)
	{
		return 0;
	}

	internal static object GHJCX9v6emFj8shfjAv(IntPtr intptr_0, Type type_0)
	{
		return null;
	}

	internal static void dscqlXvnJU0ZZNhIiLy(object object_0, int value)
	{
	}

	internal static void CCTxmXvDZcDfg8DRc01(object object_0, int value)
	{
	}

	internal static void lNpfM8vj0Ca4I02XhM2(object object_0)
	{
	}

	internal static int OXCk4BvNtw5QVLIudwE(object object_0)
	{
		return 0;
	}

	internal static DateTime NXTidZvvssdNYCkhe4F()
	{
		return (DateTime)(object)null;
	}

	internal static bool J26KjqvuEiwxMvMFs4T(object object_0, int int_0, bool bool_0)
	{
		return true;
	}

	internal static object jlYFG2vrfsvZB00ePkh(object object_0)
	{
		return null;
	}

	internal static void NITfAlvoC53mRwXBHjd(object object_0, object object_1, object object_2)
	{
	}

	internal static void BiDV7CvdRTKeHY8LnNE(object object_0, object object_1, GEnum9 reason)
	{
	}

	internal static bool OMasJMvfdX7VYPGcFAx(object object_0, object object_1)
	{
		return true;
	}

	internal static object ml3AS6vK41grXQ3jtUA(object object_0)
	{
		return null;
	}

	internal static bool wjYMLWvh7hDa7ikJX5M(object object_0, object object_1)
	{
		return true;
	}

	internal static object RjaRlcvC7f2EIsLaqy0(object object_0)
	{
		return null;
	}

	internal static void KBNTA1v0x92Zfpmf3oR(IntPtr intptr_0)
	{
	}

	internal static int MbvYVSvPQJ84sTKCnCw(object object_0)
	{
		return 0;
	}

	internal static void CYSUVVvRH9y8Kow5EK8(object object_0, object object_1)
	{
	}

	internal static int leSrkMv1FO8vByIFNlK(object object_0)
	{
		return 0;
	}

	internal static int ksZ4lsvtAmXAfUrxt11(object object_0)
	{
		return 0;
	}

	internal static int yIwE4yvHKqormKY19MT(PixelFormat pixelFormat_0)
	{
		return 0;
	}

	internal static void JXu7EovIxE9Gdi8MarZ(object object_0, object object_1, object object_2)
	{
	}

	internal static TimeSpan RwW3HtvyXmIDBlV1c7p(DateTime dateTime_0, DateTime dateTime_1)
	{
		return (TimeSpan)(object)null;
	}

	internal static void VAbTNPvpwGO5QAALEpI()
	{
	}
}
