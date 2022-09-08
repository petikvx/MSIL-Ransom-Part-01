using System;
using CSCore;
using CSCore.SoundOut;
using CSCore.Streams;
using OpusWrapper;

namespace Orcus.Commands.VoiceChat.Utilities;

public class CSCoreDataPlayer : IDisposable
{
	private readonly bool _triggerSingleBlockRead;

	private WasapiOut _wasapiOut;

	private WriteableBufferingSource _writeableBufferingSource;

	private OpusDecoder _opusDecoder;

	private readonly object _componentsLock = new object();

	private bool _isDisposed;

	public event EventHandler<SingleBlockReadEventArgs> SingleBlockRead;

	public CSCoreDataPlayer(bool triggerSingleBlockRead)
	{
		_triggerSingleBlockRead = triggerSingleBlockRead;
	}

	public void Dispose()
	{
		if (_isDisposed)
		{
			return;
		}
		lock (_componentsLock)
		{
			_isDisposed = true;
			_wasapiOut.Dispose();
			_opusDecoder.Dispose();
			_writeableBufferingSource.Dispose();
		}
	}

	public void Initialize()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		_wasapiOut = new WasapiOut();
		_opusDecoder = OpusDecoder.Create(48000, 1);
		WaveFormat val = new WaveFormat(48000, 16, 1);
		WriteableBufferingSource val2 = new WriteableBufferingSource(val);
		val2.set_FillWithZeros(true);
		_writeableBufferingSource = val2;
		IWaveSource val4;
		if (_triggerSingleBlockRead)
		{
			SingleBlockNotificationStream val3 = new SingleBlockNotificationStream(FluentExtensions.ToSampleSource((IWaveSource)(object)_writeableBufferingSource));
			val3.add_SingleBlockRead((EventHandler<SingleBlockReadEventArgs>)SingleBlockNotificationStreamOnSingleBlockRead);
			val4 = FluentExtensions.ToWaveSource((ISampleSource)val3);
		}
		else
		{
			val4 = (IWaveSource)(object)_writeableBufferingSource;
		}
		_wasapiOut.Initialize(val4);
		_wasapiOut.Play();
	}

	private void SingleBlockNotificationStreamOnSingleBlockRead(object sender, SingleBlockReadEventArgs e)
	{
		this.SingleBlockRead?.Invoke(this, e);
	}

	public unsafe void Feed(byte[] bytes, int offset, int count)
	{
		if (_isDisposed)
		{
			return;
		}
		lock (_componentsLock)
		{
			if (_isDisposed)
			{
				return;
			}
			int num = offset;
			fixed (byte* ptr = bytes)
			{
				int num3 = default(int);
				while (num != count + offset)
				{
					int num2 = BitConverter.ToInt32(bytes, num);
					num += 4;
					byte[] array = _opusDecoder.Decode(ptr + num, num2, ref num3);
					_writeableBufferingSource.Write(array, 0, num3);
					num += num2;
				}
			}
		}
	}
}
