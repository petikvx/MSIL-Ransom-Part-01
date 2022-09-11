using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class Mp3Frame
{
	private static readonly int[,,] bitRates;

	private static readonly int[,] samplesPerFrame;

	private static readonly int[] sampleRatesVersion1;

	private static readonly int[] sampleRatesVersion2;

	private static readonly int[] sampleRatesVersion25;

	private const int MaxFrameLength = 16384;

	[NonSerialized]
	internal static GetString _0096;

	public int SampleRate { get; private set; }

	public int FrameLength { get; private set; }

	public int BitRate { get; private set; }

	public byte[] RawData { get; private set; }

	public MpegVersion MpegVersion { get; private set; }

	public MpegLayer MpegLayer { get; private set; }

	public ChannelMode ChannelMode { get; private set; }

	public int SampleCount { get; private set; }

	public int ChannelExtension { get; private set; }

	public int BitRateIndex { get; private set; }

	public bool Copyright { get; private set; }

	public bool CrcPresent { get; private set; }

	public long FileOffset { get; private set; }

	public static Mp3Frame LoadFromStream(Stream input)
	{
		return LoadFromStream(input, readData: true);
	}

	public static Mp3Frame LoadFromStream(Stream input, bool readData)
	{
		Mp3Frame mp3Frame = new Mp3Frame();
		mp3Frame.FileOffset = input.Position;
		byte[] array = new byte[4];
		if (input.Read(array, 0, array.Length) < array.Length)
		{
			return null;
		}
		while (!IsValidHeader(array, mp3Frame))
		{
			array[0] = array[1];
			array[1] = array[2];
			array[2] = array[3];
			if (input.Read(array, 3, 1) < 1)
			{
				return null;
			}
			mp3Frame.FileOffset++;
		}
		int num = mp3Frame.FrameLength - 4;
		if (readData)
		{
			mp3Frame.RawData = new byte[mp3Frame.FrameLength];
			Array.Copy(array, mp3Frame.RawData, 4);
			if (input.Read(mp3Frame.RawData, 4, num) < num)
			{
				throw new EndOfStreamException(_0096(107390796));
			}
		}
		else
		{
			input.Position += num;
		}
		return mp3Frame;
	}

	private Mp3Frame()
	{
	}

	private static bool IsValidHeader(byte[] headerBytes, Mp3Frame frame)
	{
		if (headerBytes[0] == byte.MaxValue && (headerBytes[1] & 0xE0) == 224)
		{
			frame.MpegVersion = (MpegVersion)((headerBytes[1] & 0x18) >> 3);
			if (frame.MpegVersion == MpegVersion.Reserved)
			{
				return false;
			}
			frame.MpegLayer = (MpegLayer)((headerBytes[1] & 6) >> 1);
			if (frame.MpegLayer == MpegLayer.Reserved)
			{
				return false;
			}
			int num = ((frame.MpegLayer != MpegLayer.Layer1) ? ((frame.MpegLayer == MpegLayer.Layer2) ? 1 : 2) : 0);
			frame.CrcPresent = (headerBytes[1] & 1) == 0;
			frame.BitRateIndex = (headerBytes[2] & 0xF0) >> 4;
			if (frame.BitRateIndex == 15)
			{
				return false;
			}
			int num2 = ((frame.MpegVersion != MpegVersion.Version1) ? 1 : 0);
			frame.BitRate = bitRates[num2, num, frame.BitRateIndex] * 1000;
			if (frame.BitRate == 0)
			{
				return false;
			}
			int num3 = (headerBytes[2] & 0xC) >> 2;
			if (num3 == 3)
			{
				return false;
			}
			if (frame.MpegVersion == MpegVersion.Version1)
			{
				frame.SampleRate = sampleRatesVersion1[num3];
			}
			else if (frame.MpegVersion == MpegVersion.Version2)
			{
				frame.SampleRate = sampleRatesVersion2[num3];
			}
			else
			{
				frame.SampleRate = sampleRatesVersion25[num3];
			}
			bool flag = (headerBytes[2] & 2) == 2;
			_ = headerBytes[2];
			frame.ChannelMode = (ChannelMode)((headerBytes[3] & 0xC0) >> 6);
			frame.ChannelExtension = (headerBytes[3] & 0x30) >> 4;
			if (frame.ChannelExtension != 0 && frame.ChannelMode != ChannelMode.JointStereo)
			{
				return false;
			}
			frame.Copyright = (headerBytes[3] & 8) == 8;
			_ = headerBytes[3];
			_ = headerBytes[3];
			int num4 = (flag ? 1 : 0);
			frame.SampleCount = samplesPerFrame[num2, num];
			int num5 = frame.SampleCount / 8;
			if (frame.MpegLayer == MpegLayer.Layer1)
			{
				frame.FrameLength = (num5 * frame.BitRate / frame.SampleRate + num4) * 4;
			}
			else
			{
				frame.FrameLength = num5 * frame.BitRate / frame.SampleRate + num4;
			}
			if (frame.FrameLength > 16384)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	static Mp3Frame()
	{
		Strings.CreateGetStringDelegate(typeof(Mp3Frame));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0096(107397693), _0096(107397656)).Replace(_0096(107397651), _0096(107397646)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0096(107397673)))
		{
			throw new SecurityException(_0096(107397616));
		}
		bitRates = new int[2, 3, 15]
		{
			{
				{
					0, 32, 64, 96, 128, 160, 192, 224, 256, 288,
					320, 352, 384, 416, 448
				},
				{
					0, 32, 48, 56, 64, 80, 96, 112, 128, 160,
					192, 224, 256, 320, 384
				},
				{
					0, 32, 40, 48, 56, 64, 80, 96, 112, 128,
					160, 192, 224, 256, 320
				}
			},
			{
				{
					0, 32, 48, 56, 64, 80, 96, 112, 128, 144,
					160, 176, 192, 224, 256
				},
				{
					0, 8, 16, 24, 32, 40, 48, 56, 64, 80,
					96, 112, 128, 144, 160
				},
				{
					0, 8, 16, 24, 32, 40, 48, 56, 64, 80,
					96, 112, 128, 144, 160
				}
			}
		};
		samplesPerFrame = new int[2, 3]
		{
			{ 384, 1152, 1152 },
			{ 384, 1152, 576 }
		};
		sampleRatesVersion1 = new int[3] { 44100, 48000, 32000 };
		sampleRatesVersion2 = new int[3] { 22050, 24000, 16000 };
		sampleRatesVersion25 = new int[3] { 11025, 12000, 8000 };
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
