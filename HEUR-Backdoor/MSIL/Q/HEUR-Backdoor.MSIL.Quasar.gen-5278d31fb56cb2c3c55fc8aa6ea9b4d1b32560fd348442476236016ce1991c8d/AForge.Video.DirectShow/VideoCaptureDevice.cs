using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using AForge.Video.DirectShow.Internals;

namespace AForge.Video.DirectShow;

public class VideoCaptureDevice : IVideoSource
{
	private class Grabber : ISampleGrabberCB
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
					Win32.memcpy(ptr, ptr2, stride);
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

	private VideoCapabilities videoResolution;

	private VideoCapabilities snapshotResolution;

	private bool provideSnapshots;

	private Thread thread;

	private ManualResetEvent stopEvent;

	private VideoCapabilities[] videoCapabilities;

	private VideoCapabilities[] snapshotCapabilities;

	private bool needToSetVideoInput;

	private bool needToSimulateTrigger;

	private bool needToDisplayPropertyPage;

	private bool needToDisplayCrossBarPropertyPage;

	private IntPtr parentWindowForPropertyPage = IntPtr.Zero;

	private object sourceObject;

	private DateTime startTime;

	private object sync = new object();

	private bool? isCrossbarAvailable;

	private VideoInput[] crossbarVideoInputs;

	private VideoInput crossbarVideoInput = VideoInput.Default;

	private static Dictionary<string, VideoCapabilities[]> cacheVideoCapabilities = new Dictionary<string, VideoCapabilities[]>();

	private static Dictionary<string, VideoCapabilities[]> cacheSnapshotCapabilities = new Dictionary<string, VideoCapabilities[]>();

	private static Dictionary<string, VideoInput[]> cacheCrossbarVideoInputs = new Dictionary<string, VideoInput[]>();

	public VideoInput CrossbarVideoInput
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

	public VideoInput[] AvailableCrossbarVideoInputs
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
				return new VideoInput[0];
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

	public VideoCapabilities VideoResolution
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

	public VideoCapabilities SnapshotResolution
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

	public VideoCapabilities[] VideoCapabilities
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
				return new VideoCapabilities[0];
			}
			return videoCapabilities;
		}
	}

	public VideoCapabilities[] SnapshotCapabilities
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
				return new VideoCapabilities[0];
			}
			return snapshotCapabilities;
		}
	}

	public object SourceObject => sourceObject;

	public event NewFrameEventHandler NewFrame;

	public event NewFrameEventHandler SnapshotFrame;

	public event VideoSourceErrorEventHandler VideoSourceError;

	public event PlayingFinishedEventHandler PlayingFinished;

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
		if (deviceMoniker == null || deviceMoniker == string.Empty)
		{
			throw new ArgumentException("Video source is not specified.");
		}
		lock (sync)
		{
			if (IsRunning)
			{
				parentWindowForPropertyPage = parentWindow;
				needToDisplayPropertyPage = true;
				return;
			}
			object obj = null;
			try
			{
				obj = FilterInfo.CreateFilter(deviceMoniker);
			}
			catch
			{
				throw new ApplicationException("Failed creating device object for moniker.");
			}
			if (!(obj is ISpecifyPropertyPages))
			{
				throw new NotSupportedException("The video source does not support configuration property page.");
			}
			DisplayPropertyPage(parentWindow, obj);
			Marshal.ReleaseComObject(obj);
		}
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
			if (!IsRunning || !isCrossbarAvailable.HasValue)
			{
				throw new ApplicationException("The video source must be running in order to display crossbar property page.");
			}
			if (!isCrossbarAvailable.Value)
			{
				throw new NotSupportedException("Crossbar configuration is not supported by currently running video source.");
			}
			parentWindowForPropertyPage = parentWindow;
			needToDisplayCrossBarPropertyPage = true;
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

	public bool SetCameraProperty(CameraControlProperty property, int value, CameraControlFlags controlFlags)
	{
		bool flag = true;
		if (deviceMoniker == null || string.IsNullOrEmpty(deviceMoniker))
		{
			throw new ArgumentException("Video source is not specified.");
		}
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
			if (!(obj is IAMCameraControl))
			{
				throw new NotSupportedException("The video source does not support camera control.");
			}
			flag = ((IAMCameraControl)obj).Set(property, value, controlFlags) >= 0;
			Marshal.ReleaseComObject(obj);
			return flag;
		}
	}

	public bool GetCameraProperty(CameraControlProperty property, out int value, out CameraControlFlags controlFlags)
	{
		bool flag = true;
		if (deviceMoniker == null || string.IsNullOrEmpty(deviceMoniker))
		{
			throw new ArgumentException("Video source is not specified.");
		}
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
			if (!(obj is IAMCameraControl))
			{
				throw new NotSupportedException("The video source does not support camera control.");
			}
			flag = ((IAMCameraControl)obj).Get(property, out value, out controlFlags) >= 0;
			Marshal.ReleaseComObject(obj);
			return flag;
		}
	}

	public bool GetCameraPropertyRange(CameraControlProperty property, out int minValue, out int maxValue, out int stepSize, out int defaultValue, out CameraControlFlags controlFlags)
	{
		bool flag = true;
		if (deviceMoniker == null || string.IsNullOrEmpty(deviceMoniker))
		{
			throw new ArgumentException("Video source is not specified.");
		}
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
			if (!(obj is IAMCameraControl))
			{
				throw new NotSupportedException("The video source does not support camera control.");
			}
			flag = ((IAMCameraControl)obj).GetRange(property, out minValue, out maxValue, out stepSize, out defaultValue, out controlFlags) >= 0;
			Marshal.ReleaseComObject(obj);
			return flag;
		}
	}

	private void WorkerThread()
	{
		WorkerThread(runGraph: true);
	}

	private void WorkerThread(bool runGraph)
	{
		ReasonToFinishPlaying reason = ReasonToFinishPlaying.StoppedByUser;
		bool flag = false;
		Grabber grabber = new Grabber(this, snapshotMode: false);
		Grabber grabber2 = new Grabber(this, snapshotMode: true);
		object obj = null;
		object obj2 = null;
		object obj3 = null;
		object obj4 = null;
		object retInterface = null;
		ICaptureGraphBuilder2 captureGraphBuilder = null;
		IFilterGraph2 filterGraph = null;
		IBaseFilter baseFilter = null;
		IBaseFilter baseFilter2 = null;
		IBaseFilter baseFilter3 = null;
		ISampleGrabber sampleGrabber = null;
		ISampleGrabber sampleGrabber2 = null;
		IMediaControl mediaControl = null;
		IAMVideoControl iAMVideoControl = null;
		IMediaEventEx mediaEventEx = null;
		IPin pin = null;
		IAMCrossbar iAMCrossbar = null;
		try
		{
			Type? typeFromCLSID = Type.GetTypeFromCLSID(Clsid.CaptureGraphBuilder2);
			if (typeFromCLSID == null)
			{
				throw new ApplicationException("Failed creating capture graph builder");
			}
			obj = Activator.CreateInstance(typeFromCLSID);
			captureGraphBuilder = (ICaptureGraphBuilder2)obj;
			Type? typeFromCLSID2 = Type.GetTypeFromCLSID(Clsid.FilterGraph);
			if (typeFromCLSID2 == null)
			{
				throw new ApplicationException("Failed creating filter graph");
			}
			obj2 = Activator.CreateInstance(typeFromCLSID2);
			filterGraph = (IFilterGraph2)obj2;
			captureGraphBuilder.SetFiltergraph((IGraphBuilder)filterGraph);
			sourceObject = FilterInfo.CreateFilter(deviceMoniker);
			if (sourceObject == null)
			{
				throw new ApplicationException("Failed creating device object for moniker");
			}
			baseFilter = (IBaseFilter)sourceObject;
			try
			{
				iAMVideoControl = (IAMVideoControl)sourceObject;
			}
			catch
			{
			}
			Type? typeFromCLSID3 = Type.GetTypeFromCLSID(Clsid.SampleGrabber);
			if (typeFromCLSID3 == null)
			{
				throw new ApplicationException("Failed creating sample grabber");
			}
			obj3 = Activator.CreateInstance(typeFromCLSID3);
			sampleGrabber = (ISampleGrabber)obj3;
			baseFilter2 = (IBaseFilter)obj3;
			obj4 = Activator.CreateInstance(typeFromCLSID3);
			sampleGrabber2 = (ISampleGrabber)obj4;
			baseFilter3 = (IBaseFilter)obj4;
			filterGraph.AddFilter(baseFilter, "source");
			filterGraph.AddFilter(baseFilter2, "grabber_video");
			filterGraph.AddFilter(baseFilter3, "grabber_snapshot");
			AMMediaType aMMediaType = new AMMediaType();
			aMMediaType.MajorType = MediaType.Video;
			aMMediaType.SubType = MediaSubType.RGB24;
			sampleGrabber.SetMediaType(aMMediaType);
			sampleGrabber2.SetMediaType(aMMediaType);
			captureGraphBuilder.FindInterface(FindDirection.UpstreamOnly, Guid.Empty, baseFilter, typeof(IAMCrossbar).GUID, out retInterface);
			if (retInterface != null)
			{
				iAMCrossbar = (IAMCrossbar)retInterface;
			}
			isCrossbarAvailable = iAMCrossbar != null;
			crossbarVideoInputs = ColletCrossbarVideoInputs(iAMCrossbar);
			if (iAMVideoControl != null)
			{
				captureGraphBuilder.FindPin(sourceObject, PinDirection.Output, PinCategory.StillImage, MediaType.Video, unconnected: false, 0, out pin);
				if (pin != null)
				{
					iAMVideoControl.GetCaps(pin, out var flags);
					flag = (flags & VideoControlFlags.ExternalTriggerEnable) != 0;
				}
			}
			sampleGrabber.SetBufferSamples(bufferThem: false);
			sampleGrabber.SetOneShot(oneShot: false);
			sampleGrabber.SetCallback(grabber, 1);
			sampleGrabber2.SetBufferSamples(bufferThem: true);
			sampleGrabber2.SetOneShot(oneShot: false);
			sampleGrabber2.SetCallback(grabber2, 1);
			GetPinCapabilitiesAndConfigureSizeAndRate(captureGraphBuilder, baseFilter, PinCategory.Capture, videoResolution, ref videoCapabilities);
			if (flag)
			{
				GetPinCapabilitiesAndConfigureSizeAndRate(captureGraphBuilder, baseFilter, PinCategory.StillImage, snapshotResolution, ref snapshotCapabilities);
			}
			else
			{
				snapshotCapabilities = new VideoCapabilities[0];
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
				captureGraphBuilder.RenderStream(PinCategory.Capture, MediaType.Video, baseFilter, null, baseFilter2);
				if (sampleGrabber.GetConnectedMediaType(aMMediaType) == 0)
				{
					VideoInfoHeader videoInfoHeader = (VideoInfoHeader)Marshal.PtrToStructure(aMMediaType.FormatPtr, typeof(VideoInfoHeader));
					grabber.Width = videoInfoHeader.BmiHeader.Width;
					grabber.Height = videoInfoHeader.BmiHeader.Height;
					aMMediaType.Dispose();
				}
				if (flag && provideSnapshots)
				{
					captureGraphBuilder.RenderStream(PinCategory.StillImage, MediaType.Video, baseFilter, null, baseFilter3);
					if (sampleGrabber2.GetConnectedMediaType(aMMediaType) == 0)
					{
						VideoInfoHeader videoInfoHeader2 = (VideoInfoHeader)Marshal.PtrToStructure(aMMediaType.FormatPtr, typeof(VideoInfoHeader));
						grabber2.Width = videoInfoHeader2.BmiHeader.Width;
						grabber2.Height = videoInfoHeader2.BmiHeader.Height;
						aMMediaType.Dispose();
					}
				}
				mediaControl = (IMediaControl)obj2;
				mediaEventEx = (IMediaEventEx)obj2;
				mediaControl.Run();
				if (flag && provideSnapshots)
				{
					startTime = DateTime.Now;
					iAMVideoControl.SetMode(pin, VideoControlFlags.ExternalTriggerEnable);
				}
				do
				{
					if (mediaEventEx != null && mediaEventEx.GetEvent(out var lEventCode, out var lParam, out var lParam2, 0) >= 0)
					{
						mediaEventEx.FreeEventParams(lEventCode, lParam, lParam2);
						if (lEventCode == DsEvCode.DeviceLost)
						{
							reason = ReasonToFinishPlaying.DeviceLost;
							break;
						}
					}
					if (needToSetVideoInput)
					{
						needToSetVideoInput = false;
						if (isCrossbarAvailable.Value)
						{
							SetCurrentCrossbarInput(iAMCrossbar, crossbarVideoInput);
							crossbarVideoInput = GetCurrentCrossbarInput(iAMCrossbar);
						}
					}
					if (needToSimulateTrigger)
					{
						needToSimulateTrigger = false;
						if (flag && provideSnapshots)
						{
							iAMVideoControl.SetMode(pin, VideoControlFlags.Trigger);
						}
					}
					if (needToDisplayPropertyPage)
					{
						needToDisplayPropertyPage = false;
						DisplayPropertyPage(parentWindowForPropertyPage, sourceObject);
						if (iAMCrossbar != null)
						{
							crossbarVideoInput = GetCurrentCrossbarInput(iAMCrossbar);
						}
					}
					if (needToDisplayCrossBarPropertyPage)
					{
						needToDisplayCrossBarPropertyPage = false;
						if (iAMCrossbar != null)
						{
							DisplayPropertyPage(parentWindowForPropertyPage, iAMCrossbar);
							crossbarVideoInput = GetCurrentCrossbarInput(iAMCrossbar);
						}
					}
				}
				while (!stopEvent.WaitOne(100, exitContext: false));
				mediaControl.Stop();
			}
		}
		catch (Exception ex)
		{
			if (this.VideoSourceError != null)
			{
				this.VideoSourceError(this, new VideoSourceErrorEventArgs(ex.Message));
			}
		}
		finally
		{
			captureGraphBuilder = null;
			filterGraph = null;
			baseFilter = null;
			mediaControl = null;
			iAMVideoControl = null;
			mediaEventEx = null;
			pin = null;
			iAMCrossbar = null;
			baseFilter2 = null;
			baseFilter3 = null;
			sampleGrabber = null;
			sampleGrabber2 = null;
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
		if (this.PlayingFinished != null)
		{
			this.PlayingFinished(this, reason);
		}
	}

	private void SetResolution(IAMStreamConfig streamConfig, VideoCapabilities resolution)
	{
		if (resolution == null)
		{
			return;
		}
		int count = 0;
		int size = 0;
		AMMediaType mediaType = null;
		VideoStreamConfigCaps streamConfigCaps = new VideoStreamConfigCaps();
		streamConfig.GetNumberOfCapabilities(out count, out size);
		for (int i = 0; i < count; i++)
		{
			try
			{
				VideoCapabilities videoCapabilities = new VideoCapabilities(streamConfig, i);
				if (resolution == videoCapabilities && streamConfig.GetStreamCaps(i, out mediaType, streamConfigCaps) == 0)
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

	private void GetPinCapabilitiesAndConfigureSizeAndRate(ICaptureGraphBuilder2 graphBuilder, IBaseFilter baseFilter, Guid pinCategory, VideoCapabilities resolutionToSet, ref VideoCapabilities[] capabilities)
	{
		graphBuilder.FindInterface(pinCategory, MediaType.Video, baseFilter, typeof(IAMStreamConfig).GUID, out var retInterface);
		if (retInterface != null)
		{
			IAMStreamConfig iAMStreamConfig = null;
			try
			{
				iAMStreamConfig = (IAMStreamConfig)retInterface;
			}
			catch (InvalidCastException)
			{
			}
			if (iAMStreamConfig != null)
			{
				if (capabilities == null)
				{
					try
					{
						capabilities = AForge.Video.DirectShow.VideoCapabilities.FromStreamConfig(iAMStreamConfig);
					}
					catch
					{
					}
				}
				if (resolutionToSet != null)
				{
					SetResolution(iAMStreamConfig, resolutionToSet);
				}
			}
		}
		if (capabilities == null)
		{
			capabilities = new VideoCapabilities[0];
		}
	}

	private void DisplayPropertyPage(IntPtr parentWindow, object sourceObject)
	{
		try
		{
			((ISpecifyPropertyPages)sourceObject).GetPages(out var pPages);
			FilterInfo filterInfo = new FilterInfo(deviceMoniker);
			Win32.OleCreatePropertyFrame(parentWindow, 0, 0, filterInfo.Name, 1, ref sourceObject, pPages.cElems, pPages.pElems, 0, 0, IntPtr.Zero);
			Marshal.FreeCoTaskMem(pPages.pElems);
		}
		catch
		{
		}
	}

	private VideoInput[] ColletCrossbarVideoInputs(IAMCrossbar crossbar)
	{
		lock (cacheCrossbarVideoInputs)
		{
			if (cacheCrossbarVideoInputs.ContainsKey(deviceMoniker))
			{
				return cacheCrossbarVideoInputs[deviceMoniker];
			}
			List<VideoInput> list = new List<VideoInput>();
			if (crossbar != null && crossbar.get_PinCounts(out var _, out var inputPinCount) == 0)
			{
				for (int i = 0; i < inputPinCount; i++)
				{
					if (crossbar.get_CrossbarPinInfo(isInputPin: true, i, out var _, out var physicalType) == 0 && physicalType < PhysicalConnectorType.AudioTuner)
					{
						list.Add(new VideoInput(i, physicalType));
					}
				}
			}
			VideoInput[] array = new VideoInput[list.Count];
			list.CopyTo(array);
			cacheCrossbarVideoInputs.Add(deviceMoniker, array);
			return array;
		}
	}

	private VideoInput GetCurrentCrossbarInput(IAMCrossbar crossbar)
	{
		VideoInput result = VideoInput.Default;
		if (crossbar.get_PinCounts(out var outputPinCount, out var _) == 0)
		{
			int num = -1;
			int pinIndexRelated;
			for (int i = 0; i < outputPinCount; i++)
			{
				if (crossbar.get_CrossbarPinInfo(isInputPin: false, i, out pinIndexRelated, out var physicalType) == 0 && physicalType == PhysicalConnectorType.VideoDecoder)
				{
					num = i;
					break;
				}
			}
			if (num != -1 && crossbar.get_IsRoutedTo(num, out var inputPinIndex) == 0)
			{
				crossbar.get_CrossbarPinInfo(isInputPin: true, inputPinIndex, out pinIndexRelated, out var physicalType2);
				result = new VideoInput(inputPinIndex, physicalType2);
			}
		}
		return result;
	}

	private void SetCurrentCrossbarInput(IAMCrossbar crossbar, VideoInput videoInput)
	{
		if (videoInput.Type == PhysicalConnectorType.Default || crossbar.get_PinCounts(out var outputPinCount, out var inputPinCount) != 0)
		{
			return;
		}
		int num = -1;
		int num2 = -1;
		int pinIndexRelated;
		PhysicalConnectorType physicalType;
		for (int i = 0; i < outputPinCount; i++)
		{
			if (crossbar.get_CrossbarPinInfo(isInputPin: false, i, out pinIndexRelated, out physicalType) == 0 && physicalType == PhysicalConnectorType.VideoDecoder)
			{
				num = i;
				break;
			}
		}
		for (int j = 0; j < inputPinCount; j++)
		{
			if (crossbar.get_CrossbarPinInfo(isInputPin: true, j, out pinIndexRelated, out physicalType) == 0 && physicalType == videoInput.Type && j == videoInput.Index)
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
		if (!stopEvent.WaitOne(0, exitContext: false) && this.NewFrame != null)
		{
			this.NewFrame(this, new NewFrameEventArgs(image));
		}
	}

	private void OnSnapshotFrame(Bitmap image)
	{
		if ((DateTime.Now - startTime).TotalSeconds >= 4.0 && !stopEvent.WaitOne(0, exitContext: false) && this.SnapshotFrame != null)
		{
			this.SnapshotFrame(this, new NewFrameEventArgs(image));
		}
	}
}
