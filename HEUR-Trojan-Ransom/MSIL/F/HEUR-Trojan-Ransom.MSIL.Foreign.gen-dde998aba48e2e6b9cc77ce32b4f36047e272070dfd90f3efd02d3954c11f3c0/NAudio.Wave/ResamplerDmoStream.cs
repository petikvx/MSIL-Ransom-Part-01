using System;
using NAudio.Dmo;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class ResamplerDmoStream : WaveStream
{
	private readonly IWaveProvider inputProvider;

	private readonly WaveStream inputStream;

	private readonly WaveFormat outputFormat;

	private DmoOutputDataBuffer outputBuffer;

	private DmoResampler dmoResampler;

	private MediaBuffer inputMediaBuffer;

	private long position;

	[NonSerialized]
	internal static GetString _0012;

	public override WaveFormat WaveFormat => outputFormat;

	public override long Length
	{
		get
		{
			if (inputStream == null)
			{
				throw new InvalidOperationException(_0012(107384795));
			}
			return InputToOutputPosition(inputStream.Length);
		}
	}

	public override long Position
	{
		get
		{
			return position;
		}
		set
		{
			if (inputStream == null)
			{
				throw new InvalidOperationException(_0012(107384722));
			}
			inputStream.Position = OutputToInputPosition(value);
			position = InputToOutputPosition(inputStream.Position);
			dmoResampler.MediaObject.Discontinuity(0);
		}
	}

	public ResamplerDmoStream(IWaveProvider inputProvider, WaveFormat outputFormat)
	{
		this.inputProvider = inputProvider;
		inputStream = inputProvider as WaveStream;
		this.outputFormat = outputFormat;
		dmoResampler = new DmoResampler();
		if (!dmoResampler.MediaObject.SupportsInputWaveFormat(0, inputProvider.WaveFormat))
		{
			throw new ArgumentException(_0012(107385382), _0012(107385841));
		}
		dmoResampler.MediaObject.SetInputWaveFormat(0, inputProvider.WaveFormat);
		if (!dmoResampler.MediaObject.SupportsOutputWaveFormat(0, outputFormat))
		{
			throw new ArgumentException(_0012(107385369), _0012(107384780));
		}
		dmoResampler.MediaObject.SetOutputWaveFormat(0, outputFormat);
		if (inputStream != null)
		{
			position = InputToOutputPosition(inputStream.Position);
		}
		inputMediaBuffer = new MediaBuffer(inputProvider.WaveFormat.AverageBytesPerSecond);
		outputBuffer = new DmoOutputDataBuffer(outputFormat.AverageBytesPerSecond);
	}

	private long InputToOutputPosition(long inputPosition)
	{
		double num = (double)outputFormat.AverageBytesPerSecond / (double)inputProvider.WaveFormat.AverageBytesPerSecond;
		long num2 = (long)((double)inputPosition * num);
		if (num2 % outputFormat.BlockAlign != 0L)
		{
			num2 -= num2 % outputFormat.BlockAlign;
		}
		return num2;
	}

	private long OutputToInputPosition(long outputPosition)
	{
		double num = (double)outputFormat.AverageBytesPerSecond / (double)inputProvider.WaveFormat.AverageBytesPerSecond;
		long num2 = (long)((double)outputPosition / num);
		if (num2 % inputProvider.WaveFormat.BlockAlign != 0L)
		{
			num2 -= num2 % inputProvider.WaveFormat.BlockAlign;
		}
		return num2;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = 0;
		while (num < count)
		{
			if (dmoResampler.MediaObject.IsAcceptingData(0))
			{
				int num2 = (int)OutputToInputPosition(count - num);
				byte[] array = new byte[num2];
				int num3 = inputProvider.Read(array, 0, num2);
				if (num3 == 0)
				{
					break;
				}
				inputMediaBuffer.LoadData(array, num3);
				dmoResampler.MediaObject.ProcessInput(0, inputMediaBuffer, DmoInputDataBufferFlags.None, 0L, 0L);
				outputBuffer.MediaBuffer.SetLength(0);
				outputBuffer.StatusFlags = DmoOutputDataBufferFlags.None;
				dmoResampler.MediaObject.ProcessOutput(DmoProcessOutputFlags.None, 1, new DmoOutputDataBuffer[1] { outputBuffer });
				if (outputBuffer.Length == 0)
				{
					break;
				}
				outputBuffer.RetrieveData(buffer, offset + num);
				num += outputBuffer.Length;
			}
		}
		position += num;
		return num;
	}

	protected override void Dispose(bool disposing)
	{
		if (inputMediaBuffer != null)
		{
			inputMediaBuffer.Dispose();
			inputMediaBuffer = null;
		}
		outputBuffer.Dispose();
		if (dmoResampler != null)
		{
			dmoResampler = null;
		}
		base.Dispose(disposing);
	}

	static ResamplerDmoStream()
	{
		Strings.CreateGetStringDelegate(typeof(ResamplerDmoStream));
	}
}
