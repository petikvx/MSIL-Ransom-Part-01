using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AForge.Video.DirectShow.Internals;

namespace AForge.Video.DirectShow;

public class VideoCaptureDevice : GInterface5
{
	private class Grabber : Interface18
	{
		private VideoCaptureDevice parent;

		private bool snapshotMode;

		private int width;

		private int height;

		public int Width
		{
			get
			{
				return width;
			}
			set
			{
				width = value;
			}
		}

		public int Height
		{
			get
			{
				return height;
			}
			set
			{
				height = value;
			}
		}

		public Grabber(VideoCaptureDevice parent, bool snapshotMode)
		{
			this.parent = parent;
			this.snapshotMode = snapshotMode;
		}

		public int SampleCB(double sampleTime, IntPtr sample)
		{
			return 0;
		}

		public unsafe int BufferCB(double sampleTime, IntPtr buffer, int bufferLen)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if (parent.NewFrame != null)
			{
				Bitmap val = new Bitmap(width, height, (PixelFormat)137224);
				BitmapData val2 = val.LockBits(new Rectangle(0, 0, width, height), (ImageLockMode)3, (PixelFormat)137224);
				int stride = val2.get_Stride();
				int stride2 = val2.get_Stride();
				byte* ptr = (byte*)val2.get_Scan0().ToPointer() + stride2 * (height - 1);
				byte* ptr2 = (byte*)buffer.ToPointer();
				for (int i = 0; i < height; i++)
				{
					Class47.memcpy(ptr, ptr2, stride);
					ptr -= stride2;
					ptr2 += stride;
				}
				val.UnlockBits(val2);
				if (snapshotMode)
				{
					parent.OnSnapshotFrame(val);
				}
				else
				{
					parent.OnNewFrame(val);
				}
				((Image)val).Dispose();
			}
			return 0;
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

	private IntPtr parentWindowForPropertyPage = IntPtr.Zero;

	private object sourceObject;

	private DateTime startTime;

	private object sync = new object();

	private bool? isCrossbarAvailable;

	private GClass61[] crossbarVideoInputs;

	private GClass61 crossbarVideoInput = GClass61.Default;

	private static Dictionary<string, GClass60[]> cacheVideoCapabilities = new Dictionary<string, GClass60[]>();

	private static Dictionary<string, GClass60[]> cacheSnapshotCapabilities = new Dictionary<string, GClass60[]>();

	private static Dictionary<string, GClass61[]> cacheCrossbarVideoInputs = new Dictionary<string, GClass61[]>();

	[CompilerGenerated]
	private GDelegate7 NewFrame;

	[CompilerGenerated]
	private GDelegate8 VideoSourceError;

	[CompilerGenerated]
	private GDelegate9 PlayingFinished;

	public GClass61 CrossbarVideoInput
	{
		get
		{
			return crossbarVideoInput;
		}
		set
		{
			needToSetVideoInput = true;
			crossbarVideoInput = value;
		}
	}

	public GClass61[] AvailableCrossbarVideoInputs
	{
		get
		{
			if (crossbarVideoInputs == null)
			{
				lock (cacheCrossbarVideoInputs)
				{
					if (!string.IsNullOrEmpty(deviceMoniker) && cacheCrossbarVideoInputs.ContainsKey(deviceMoniker))
					{
						crossbarVideoInputs = cacheCrossbarVideoInputs[deviceMoniker];
					}
				}
				if (crossbarVideoInputs == null)
				{
					if (!IsRunning)
					{
						WorkerThread(runGraph: false);
					}
					else
					{
						for (int i = 0; i < 500; i++)
						{
							if (crossbarVideoInputs != null)
							{
								break;
							}
							Thread.Sleep(10);
						}
					}
				}
			}
			if (crossbarVideoInputs == null)
			{
				return new GClass61[0];
			}
			return crossbarVideoInputs;
		}
	}

	public bool ProvideSnapshots
	{
		get
		{
			return provideSnapshots;
		}
		set
		{
			provideSnapshots = value;
		}
	}

	public virtual string Source
	{
		get
		{
			return deviceMoniker;
		}
		set
		{
			deviceMoniker = value;
			videoCapabilities = null;
			snapshotCapabilities = null;
			crossbarVideoInputs = null;
			isCrossbarAvailable = null;
		}
	}

	public int FramesReceived
	{
		get
		{
			int result = framesReceived;
			framesReceived = 0;
			return result;
		}
	}

	public long BytesReceived
	{
		get
		{
			long result = bytesReceived;
			bytesReceived = 0L;
			return result;
		}
	}

	public bool IsRunning
	{
		get
		{
			if (thread != null)
			{
				if (!thread.Join(0))
				{
					return true;
				}
				Free();
			}
			return false;
		}
	}

	[Obsolete]
	public Size DesiredFrameSize
	{
		get
		{
			return Size.Empty;
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
			return Size.Empty;
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
			return videoResolution;
		}
		set
		{
			videoResolution = value;
		}
	}

	public GClass60 SnapshotResolution
	{
		get
		{
			return snapshotResolution;
		}
		set
		{
			snapshotResolution = value;
		}
	}

	public GClass60[] VideoCapabilities
	{
		get
		{
			if (videoCapabilities == null)
			{
				lock (cacheVideoCapabilities)
				{
					if (!string.IsNullOrEmpty(deviceMoniker) && cacheVideoCapabilities.ContainsKey(deviceMoniker))
					{
						videoCapabilities = cacheVideoCapabilities[deviceMoniker];
					}
				}
				if (videoCapabilities == null)
				{
					if (!IsRunning)
					{
						WorkerThread(runGraph: false);
					}
					else
					{
						for (int i = 0; i < 500; i++)
						{
							if (videoCapabilities != null)
							{
								break;
							}
							Thread.Sleep(10);
						}
					}
				}
			}
			if (videoCapabilities == null)
			{
				return new GClass60[0];
			}
			return videoCapabilities;
		}
	}

	public GClass60[] SnapshotCapabilities
	{
		get
		{
			if (snapshotCapabilities == null)
			{
				lock (cacheSnapshotCapabilities)
				{
					if (!string.IsNullOrEmpty(deviceMoniker) && cacheSnapshotCapabilities.ContainsKey(deviceMoniker))
					{
						snapshotCapabilities = cacheSnapshotCapabilities[deviceMoniker];
					}
				}
				if (snapshotCapabilities == null)
				{
					if (!IsRunning)
					{
						WorkerThread(runGraph: false);
					}
					else
					{
						for (int i = 0; i < 500; i++)
						{
							if (snapshotCapabilities != null)
							{
								break;
							}
							Thread.Sleep(10);
						}
					}
				}
			}
			if (snapshotCapabilities == null)
			{
				return new GClass60[0];
			}
			return snapshotCapabilities;
		}
	}

	public object SourceObject => sourceObject;

	public event GDelegate7 Event_0
	{
		[CompilerGenerated]
		add
		{
			GDelegate7 gDelegate = NewFrame;
			GDelegate7 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate7 value2 = (GDelegate7)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref NewFrame, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate7 gDelegate = NewFrame;
			GDelegate7 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate7 value2 = (GDelegate7)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref NewFrame, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public event GDelegate7 SnapshotFrame;

	public event GDelegate8 Event_1
	{
		[CompilerGenerated]
		add
		{
			GDelegate8 gDelegate = VideoSourceError;
			GDelegate8 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate8 value2 = (GDelegate8)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref VideoSourceError, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate8 gDelegate = VideoSourceError;
			GDelegate8 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate8 value2 = (GDelegate8)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref VideoSourceError, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public event GDelegate9 Event_2
	{
		[CompilerGenerated]
		add
		{
			GDelegate9 gDelegate = PlayingFinished;
			GDelegate9 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate9 value2 = (GDelegate9)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref PlayingFinished, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate9 gDelegate = PlayingFinished;
			GDelegate9 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate9 value2 = (GDelegate9)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref PlayingFinished, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public VideoCaptureDevice()
	{
	}

	public VideoCaptureDevice(string deviceMoniker)
	{
		this.deviceMoniker = deviceMoniker;
	}

	public void Start()
	{
		if (!IsRunning)
		{
			if (string.IsNullOrEmpty(deviceMoniker))
			{
				throw new ArgumentException("Video source is not specified.");
			}
			framesReceived = 0;
			bytesReceived = 0L;
			isCrossbarAvailable = null;
			needToSetVideoInput = true;
			stopEvent = new ManualResetEvent(initialState: false);
			lock (sync)
			{
				thread = new Thread(WorkerThread);
				thread.Name = deviceMoniker;
				thread.Start();
			}
		}
	}

	public void SignalToStop()
	{
		if (thread != null)
		{
			stopEvent.Set();
		}
	}

	public void WaitForStop()
	{
		if (thread != null)
		{
			thread.Join();
			Free();
		}
	}

	public void Stop()
	{
		if (IsRunning)
		{
			thread.Abort();
			WaitForStop();
		}
	}

	private void Free()
	{
		thread = null;
		stopEvent.Close();
		stopEvent = null;
	}

	public void DisplayPropertyPage(IntPtr parentWindow)
	{
		if (deviceMoniker != null && !(deviceMoniker == string.Empty))
		{
			lock (sync)
			{
				if (IsRunning)
				{
					parentWindowForPropertyPage = parentWindow;
					needToDisplayPropertyPage = true;
				}
				else
				{
					object obj = null;
					try
					{
						obj = FilterInfo.CreateFilter(deviceMoniker);
					}
					catch
					{
						throw new ApplicationException("Failed creating device object for moniker.");
					}
					if (!(obj is Interface19))
					{
						throw new NotSupportedException("The video source does not support configuration property page.");
					}
					DisplayPropertyPage(parentWindow, obj);
					Marshal.ReleaseComObject(obj);
				}
				return;
			}
		}
		throw new ArgumentException("Video source is not specified.");
	}

	public void DisplayCrossbarPropertyPage(IntPtr parentWindow)
	{
		lock (sync)
		{
			for (int i = 0; i < 500; i++)
			{
				if (isCrossbarAvailable.HasValue)
				{
					break;
				}
				if (!IsRunning)
				{
					break;
				}
				Thread.Sleep(10);
			}
			if (IsRunning && isCrossbarAvailable.HasValue)
			{
				if (!isCrossbarAvailable.Value)
				{
					throw new NotSupportedException("Crossbar configuration is not supported by currently running video source.");
				}
				parentWindowForPropertyPage = parentWindow;
				needToDisplayCrossBarPropertyPage = true;
				return;
			}
			throw new ApplicationException("The video source must be running in order to display crossbar property page.");
		}
	}

	public bool CheckIfCrossbarAvailable()
	{
		lock (sync)
		{
			if (!isCrossbarAvailable.HasValue)
			{
				if (!IsRunning)
				{
					WorkerThread(runGraph: false);
				}
				else
				{
					for (int i = 0; i < 500; i++)
					{
						if (isCrossbarAvailable.HasValue)
						{
							break;
						}
						Thread.Sleep(10);
					}
				}
			}
			return isCrossbarAvailable.HasValue && isCrossbarAvailable.Value;
		}
	}

	public void SimulateTrigger()
	{
		needToSimulateTrigger = true;
	}

	public bool SetCameraProperty(GEnum10 property, int value, GEnum11 controlFlags)
	{
		bool flag = true;
		if (deviceMoniker != null && !string.IsNullOrEmpty(deviceMoniker))
		{
			lock (sync)
			{
				object obj = null;
				try
				{
					obj = FilterInfo.CreateFilter(deviceMoniker);
				}
				catch
				{
					throw new ApplicationException("Failed creating device object for moniker.");
				}
				if (!(obj is Interface0))
				{
					throw new NotSupportedException("The video source does not support camera control.");
				}
				flag = ((Interface0)obj).Set(property, value, controlFlags) >= 0;
				Marshal.ReleaseComObject(obj);
				return flag;
			}
		}
		throw new ArgumentException("Video source is not specified.");
	}

	public bool GetCameraProperty(GEnum10 property, out int value, out GEnum11 controlFlags)
	{
		bool flag = true;
		if (deviceMoniker != null && !string.IsNullOrEmpty(deviceMoniker))
		{
			lock (sync)
			{
				object obj = null;
				try
				{
					obj = FilterInfo.CreateFilter(deviceMoniker);
				}
				catch
				{
					throw new ApplicationException("Failed creating device object for moniker.");
				}
				if (!(obj is Interface0))
				{
					throw new NotSupportedException("The video source does not support camera control.");
				}
				flag = ((Interface0)obj).Get(property, out value, out controlFlags) >= 0;
				Marshal.ReleaseComObject(obj);
				return flag;
			}
		}
		throw new ArgumentException("Video source is not specified.");
	}

	public bool GetCameraPropertyRange(GEnum10 property, out int minValue, out int maxValue, out int stepSize, out int defaultValue, out GEnum11 controlFlags)
	{
		bool flag = true;
		if (deviceMoniker != null && !string.IsNullOrEmpty(deviceMoniker))
		{
			lock (sync)
			{
				object obj = null;
				try
				{
					obj = FilterInfo.CreateFilter(deviceMoniker);
				}
				catch
				{
					throw new ApplicationException("Failed creating device object for moniker.");
				}
				if (!(obj is Interface0))
				{
					throw new NotSupportedException("The video source does not support camera control.");
				}
				flag = ((Interface0)obj).GetRange(property, out minValue, out maxValue, out stepSize, out defaultValue, out controlFlags) >= 0;
				Marshal.ReleaseComObject(obj);
				return flag;
			}
		}
		throw new ArgumentException("Video source is not specified.");
	}

	private void WorkerThread()
	{
		WorkerThread(runGraph: true);
	}

	private void WorkerThread(bool runGraph)
	{
		GEnum9 reason = GEnum9.const_1;
		bool flag = false;
		Grabber grabber = new Grabber(this, snapshotMode: false);
		Grabber grabber2 = new Grabber(this, snapshotMode: true);
		object obj = null;
		object obj2 = null;
		object obj3 = null;
		object obj4 = null;
		object retInterface = null;
		Interface5 @interface = null;
		Interface10 interface2 = null;
		Interface4 interface3 = null;
		Interface4 interface4 = null;
		Interface4 interface5 = null;
		Interface17 interface6 = null;
		Interface17 interface7 = null;
		Interface12 interface8 = null;
		Interface3 interface9 = null;
		Interface13 interface10 = null;
		Interface14 pin = null;
		Interface1 interface11 = null;
		try
		{
			Type? typeFromCLSID = Type.GetTypeFromCLSID(Class41.guid_3);
			if (typeFromCLSID == null)
			{
				throw new ApplicationException("Failed creating capture graph builder");
			}
			obj = Activator.CreateInstance(typeFromCLSID);
			@interface = (Interface5)obj;
			Type? typeFromCLSID2 = Type.GetTypeFromCLSID(Class41.guid_1);
			if (typeFromCLSID2 == null)
			{
				throw new ApplicationException("Failed creating filter graph");
			}
			obj2 = Activator.CreateInstance(typeFromCLSID2);
			interface2 = (Interface10)obj2;
			@interface.SetFiltergraph((Interface11)interface2);
			sourceObject = FilterInfo.CreateFilter(deviceMoniker);
			if (sourceObject == null)
			{
				throw new ApplicationException("Failed creating device object for moniker");
			}
			interface3 = (Interface4)sourceObject;
			try
			{
				interface9 = (Interface3)sourceObject;
			}
			catch
			{
			}
			Type? typeFromCLSID3 = Type.GetTypeFromCLSID(Class41.guid_2);
			if (typeFromCLSID3 == null)
			{
				throw new ApplicationException("Failed creating sample grabber");
			}
			obj3 = Activator.CreateInstance(typeFromCLSID3);
			interface6 = (Interface17)obj3;
			interface4 = (Interface4)obj3;
			obj4 = Activator.CreateInstance(typeFromCLSID3);
			interface7 = (Interface17)obj4;
			interface5 = (Interface4)obj4;
			interface2.AddFilter(interface3, "source");
			interface2.AddFilter(interface4, "grabber_video");
			interface2.AddFilter(interface5, "grabber_snapshot");
			AMMediaType aMMediaType = new AMMediaType();
			aMMediaType.MajorType = Class43.guid_0;
			aMMediaType.SubType = Class44.guid_8;
			interface6.SetMediaType(aMMediaType);
			interface7.SetMediaType(aMMediaType);
			@interface.FindInterface(Class46.guid_0, Guid.Empty, interface3, typeof(Interface1).GUID, out retInterface);
			if (retInterface != null)
			{
				interface11 = (Interface1)retInterface;
			}
			isCrossbarAvailable = interface11 != null;
			crossbarVideoInputs = ColletCrossbarVideoInputs(interface11);
			if (interface9 != null)
			{
				@interface.FindPin(sourceObject, Enum4.const_1, Class45.guid_1, Class43.guid_0, unconnected: false, 0, out pin);
				if (pin != null)
				{
					interface9.GetCaps(pin, out var flags);
					flag = (flags & Enum7.flag_2) != 0;
				}
			}
			interface6.SetBufferSamples(bufferThem: false);
			interface6.SetOneShot(oneShot: false);
			interface6.SetCallback(grabber, 1);
			interface7.SetBufferSamples(bufferThem: true);
			interface7.SetOneShot(oneShot: false);
			interface7.SetCallback(grabber2, 1);
			GetPinCapabilitiesAndConfigureSizeAndRate(@interface, interface3, Class45.guid_0, videoResolution, ref videoCapabilities);
			if (flag)
			{
				GetPinCapabilitiesAndConfigureSizeAndRate(@interface, interface3, Class45.guid_1, snapshotResolution, ref snapshotCapabilities);
			}
			else
			{
				snapshotCapabilities = new GClass60[0];
			}
			lock (cacheVideoCapabilities)
			{
				if (videoCapabilities != null && !cacheVideoCapabilities.ContainsKey(deviceMoniker))
				{
					cacheVideoCapabilities.Add(deviceMoniker, videoCapabilities);
				}
			}
			lock (cacheSnapshotCapabilities)
			{
				if (snapshotCapabilities != null && !cacheSnapshotCapabilities.ContainsKey(deviceMoniker))
				{
					cacheSnapshotCapabilities.Add(deviceMoniker, snapshotCapabilities);
				}
			}
			if (runGraph)
			{
				@interface.RenderStream(Class45.guid_0, Class43.guid_0, interface3, null, interface4);
				if (interface6.GetConnectedMediaType(aMMediaType) == 0)
				{
					Struct15 @struct = (Struct15)Marshal.PtrToStructure(aMMediaType.FormatPtr, typeof(Struct15));
					grabber.Width = @struct.struct17_0.int_1;
					grabber.Height = @struct.struct17_0.int_2;
					aMMediaType.Dispose();
				}
				if (flag && provideSnapshots)
				{
					@interface.RenderStream(Class45.guid_1, Class43.guid_0, interface3, null, interface5);
					if (interface7.GetConnectedMediaType(aMMediaType) == 0)
					{
						Struct15 struct2 = (Struct15)Marshal.PtrToStructure(aMMediaType.FormatPtr, typeof(Struct15));
						grabber2.Width = struct2.struct17_0.int_1;
						grabber2.Height = struct2.struct17_0.int_2;
						aMMediaType.Dispose();
					}
				}
				interface8 = (Interface12)obj2;
				interface10 = (Interface13)obj2;
				interface8.Run();
				if (flag && provideSnapshots)
				{
					startTime = DateTime.Now;
					interface9.SetMode(pin, Enum7.flag_2);
				}
				do
				{
					if (interface10 != null && interface10.GetEvent(out var lEventCode, out var lParam, out var lParam2, 0) >= 0)
					{
						interface10.FreeEventParams(lEventCode, lParam, lParam2);
						if (lEventCode == Enum5.const_2)
						{
							reason = GEnum9.const_2;
							break;
						}
					}
					if (needToSetVideoInput)
					{
						needToSetVideoInput = false;
						if (isCrossbarAvailable.Value)
						{
							SetCurrentCrossbarInput(interface11, crossbarVideoInput);
							crossbarVideoInput = GetCurrentCrossbarInput(interface11);
						}
					}
					if (needToSimulateTrigger)
					{
						needToSimulateTrigger = false;
						if (flag && provideSnapshots)
						{
							interface9.SetMode(pin, Enum7.flag_3);
						}
					}
					if (needToDisplayPropertyPage)
					{
						needToDisplayPropertyPage = false;
						DisplayPropertyPage(parentWindowForPropertyPage, sourceObject);
						if (interface11 != null)
						{
							crossbarVideoInput = GetCurrentCrossbarInput(interface11);
						}
					}
					if (needToDisplayCrossBarPropertyPage)
					{
						needToDisplayCrossBarPropertyPage = false;
						if (interface11 != null)
						{
							DisplayPropertyPage(parentWindowForPropertyPage, interface11);
							crossbarVideoInput = GetCurrentCrossbarInput(interface11);
						}
					}
				}
				while (!stopEvent.WaitOne(100, exitContext: false));
				interface8.Stop();
			}
		}
		catch (Exception ex)
		{
			if (VideoSourceError != null)
			{
				VideoSourceError(this, new GEventArgs5(ex.Message));
			}
		}
		finally
		{
			@interface = null;
			interface2 = null;
			interface3 = null;
			interface8 = null;
			interface9 = null;
			interface10 = null;
			pin = null;
			interface11 = null;
			interface4 = null;
			interface5 = null;
			interface6 = null;
			interface7 = null;
			if (obj2 != null)
			{
				Marshal.ReleaseComObject(obj2);
				obj2 = null;
			}
			if (sourceObject != null)
			{
				Marshal.ReleaseComObject(sourceObject);
				sourceObject = null;
			}
			if (obj3 != null)
			{
				Marshal.ReleaseComObject(obj3);
				obj3 = null;
			}
			if (obj4 != null)
			{
				Marshal.ReleaseComObject(obj4);
				obj4 = null;
			}
			if (obj != null)
			{
				Marshal.ReleaseComObject(obj);
				obj = null;
			}
			if (retInterface != null)
			{
				Marshal.ReleaseComObject(retInterface);
				retInterface = null;
			}
		}
		if (PlayingFinished != null)
		{
			PlayingFinished(this, reason);
		}
	}

	private void SetResolution(Interface2 streamConfig, GClass60 resolution)
	{
		if (GClass60.smethod_1(resolution, null))
		{
			return;
		}
		int count = 0;
		int size = 0;
		AMMediaType mediaType = null;
		Class40 streamConfigCaps = new Class40();
		streamConfig.GetNumberOfCapabilities(out count, out size);
		for (int i = 0; i < count; i++)
		{
			try
			{
				GClass60 b = new GClass60(streamConfig, i);
				if (GClass60.smethod_1(resolution, b) && streamConfig.GetStreamCaps(i, out mediaType, streamConfigCaps) == 0)
				{
					break;
				}
			}
			catch
			{
			}
		}
		if (mediaType != null)
		{
			streamConfig.SetFormat(mediaType);
			mediaType.Dispose();
		}
	}

	private void GetPinCapabilitiesAndConfigureSizeAndRate(Interface5 graphBuilder, Interface4 baseFilter, Guid pinCategory, GClass60 resolutionToSet, ref GClass60[] capabilities)
	{
		graphBuilder.FindInterface(pinCategory, Class43.guid_0, baseFilter, typeof(Interface2).GUID, out var retInterface);
		if (retInterface != null)
		{
			Interface2 @interface = null;
			try
			{
				@interface = (Interface2)retInterface;
			}
			catch (InvalidCastException)
			{
			}
			if (@interface != null)
			{
				if (capabilities == null)
				{
					try
					{
						capabilities = GClass60.smethod_0(@interface);
					}
					catch
					{
					}
				}
				if (GClass60.smethod_2(resolutionToSet, null))
				{
					SetResolution(@interface, resolutionToSet);
				}
			}
		}
		if (capabilities == null)
		{
			capabilities = new GClass60[0];
		}
	}

	private void DisplayPropertyPage(IntPtr parentWindow, object sourceObject)
	{
		try
		{
			((Interface19)sourceObject).GetPages(out var pPages);
			FilterInfo filterInfo = new FilterInfo(deviceMoniker);
			Class47.OleCreatePropertyFrame(parentWindow, 0, 0, filterInfo.Name, 1, ref sourceObject, pPages.int_0, pPages.intptr_0, 0, 0, IntPtr.Zero);
			Marshal.FreeCoTaskMem(pPages.intptr_0);
		}
		catch
		{
		}
	}

	private GClass61[] ColletCrossbarVideoInputs(Interface1 crossbar)
	{
		lock (cacheCrossbarVideoInputs)
		{
			if (cacheCrossbarVideoInputs.ContainsKey(deviceMoniker))
			{
				return cacheCrossbarVideoInputs[deviceMoniker];
			}
			List<GClass61> list = new List<GClass61>();
			if (crossbar != null && crossbar.get_PinCounts(out int _, out int inputPinCount) == 0)
			{
				for (int i = 0; i < inputPinCount; i++)
				{
					if (crossbar.get_CrossbarPinInfo(isInputPin: true, i, out int _, out GEnum12 physicalType) == 0 && physicalType < GEnum12.const_16)
					{
						list.Add(new GClass61(i, physicalType));
					}
				}
			}
			GClass61[] array = new GClass61[list.Count];
			list.CopyTo(array);
			cacheCrossbarVideoInputs.Add(deviceMoniker, array);
			return array;
		}
	}

	private GClass61 GetCurrentCrossbarInput(Interface1 crossbar)
	{
		GClass61 result = GClass61.Default;
		if (crossbar.get_PinCounts(out int outputPinCount, out int _) == 0)
		{
			int num = -1;
			int pinIndexRelated;
			for (int i = 0; i < outputPinCount; i++)
			{
				if (crossbar.get_CrossbarPinInfo(isInputPin: false, i, out pinIndexRelated, out GEnum12 physicalType) == 0 && physicalType == GEnum12.const_12)
				{
					num = i;
					break;
				}
			}
			if (num != -1 && crossbar.get_IsRoutedTo(num, out int inputPinIndex) == 0)
			{
				crossbar.get_CrossbarPinInfo(isInputPin: true, inputPinIndex, out pinIndexRelated, out GEnum12 physicalType2);
				result = new GClass61(inputPinIndex, physicalType2);
			}
		}
		return result;
	}

	private void SetCurrentCrossbarInput(Interface1 crossbar, GClass61 videoInput)
	{
		if (videoInput.genum12_0 == GEnum12.const_0 || crossbar.get_PinCounts(out int outputPinCount, out int inputPinCount) != 0)
		{
			return;
		}
		int num = -1;
		int num2 = -1;
		int pinIndexRelated;
		GEnum12 physicalType;
		for (int i = 0; i < outputPinCount; i++)
		{
			if (crossbar.get_CrossbarPinInfo(isInputPin: false, i, out pinIndexRelated, out physicalType) == 0 && physicalType == GEnum12.const_12)
			{
				num = i;
				break;
			}
		}
		for (int j = 0; j < inputPinCount; j++)
		{
			if (crossbar.get_CrossbarPinInfo(isInputPin: true, j, out pinIndexRelated, out physicalType) == 0 && physicalType == videoInput.genum12_0 && j == videoInput.int_0)
			{
				num2 = j;
				break;
			}
		}
		if (num2 != -1 && num != -1 && crossbar.CanRoute(num, num2) == 0)
		{
			crossbar.Route(num, num2);
		}
	}

	private void OnNewFrame(Bitmap image)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		framesReceived++;
		bytesReceived += ((Image)image).get_Width() * ((Image)image).get_Height() * (Image.GetPixelFormatSize(((Image)image).get_PixelFormat()) >> 3);
		if (!stopEvent.WaitOne(0, exitContext: false) && NewFrame != null)
		{
			NewFrame(this, new GEventArgs4(image));
		}
	}

	private void OnSnapshotFrame(Bitmap image)
	{
		if ((DateTime.Now - startTime).TotalSeconds >= 4.0 && !stopEvent.WaitOne(0, exitContext: false) && this.SnapshotFrame != null)
		{
			this.SnapshotFrame(this, new GEventArgs4(image));
		}
	}
}
