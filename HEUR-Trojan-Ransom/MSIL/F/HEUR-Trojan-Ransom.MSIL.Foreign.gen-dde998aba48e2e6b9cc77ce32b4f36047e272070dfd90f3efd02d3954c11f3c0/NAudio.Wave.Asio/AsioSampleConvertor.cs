using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.Asio;

internal sealed class AsioSampleConvertor
{
	public delegate void SampleConvertor(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples);

	[NonSerialized]
	internal static GetString _0018;

	public static SampleConvertor SelectSampleConvertor(WaveFormat waveFormat, AsioSampleType asioType)
	{
		SampleConvertor result = null;
		bool flag = waveFormat.Channels == 2;
		switch (asioType)
		{
		case AsioSampleType.Int32LSB:
			switch (waveFormat.BitsPerSample)
			{
			case 16:
				result = (flag ? new SampleConvertor(ConvertorShortToInt2Channels) : new SampleConvertor(ConvertorShortToIntGeneric));
				break;
			case 32:
				result = (flag ? new SampleConvertor(ConvertorFloatToInt2Channels) : new SampleConvertor(ConvertorFloatToIntGeneric));
				break;
			}
			break;
		case AsioSampleType.Int16LSB:
			switch (waveFormat.BitsPerSample)
			{
			case 16:
				result = (flag ? new SampleConvertor(ConvertorShortToShort2Channels) : new SampleConvertor(ConvertorShortToShortGeneric));
				break;
			case 32:
				result = (flag ? new SampleConvertor(ConvertorFloatToShort2Channels) : new SampleConvertor(ConvertorFloatToShortGeneric));
				break;
			}
			break;
		case AsioSampleType.Int24LSB:
			switch (waveFormat.BitsPerSample)
			{
			case 16:
				throw new ArgumentException(_0018(107415100));
			case 32:
				result = ConverterFloatTo24LSBGeneric;
				break;
			}
			break;
		case AsioSampleType.Float32LSB:
			switch (waveFormat.BitsPerSample)
			{
			case 16:
				throw new ArgumentException(_0018(107415100));
			case 32:
				result = ConverterFloatToFloatGeneric;
				break;
			}
			break;
		default:
			throw new ArgumentException(string.Format(_0018(107415095), Enum.GetName(typeof(AsioSampleType), asioType)));
		}
		return result;
	}

	public unsafe static void ConvertorShortToInt2Channels(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		short* ptr = (short*)(void*)inputInterleavedBuffer;
		short* ptr2 = (short*)(void*)asioOutputBuffers[0];
		short* ptr3 = (short*)(void*)asioOutputBuffers[1];
		ptr2++;
		ptr3++;
		for (int i = 0; i < nbSamples; i++)
		{
			*ptr2 = *ptr;
			*ptr3 = ptr[1];
			ptr += 2;
			ptr2 += 2;
			ptr3 += 2;
		}
	}

	public unsafe static void ConvertorShortToIntGeneric(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		short* ptr = (short*)(void*)inputInterleavedBuffer;
		short*[] array = new short*[nbChannels];
		for (int i = 0; i < nbChannels; i++)
		{
			array[i] = (short*)(void*)asioOutputBuffers[i];
			array[i]++;
		}
		for (int j = 0; j < nbSamples; j++)
		{
			for (int k = 0; k < nbChannels; k++)
			{
				short* intPtr = array[k];
				short* num = ptr;
				ptr = num + 1;
				*intPtr = *num;
				array[k] += 2;
			}
		}
	}

	public unsafe static void ConvertorFloatToInt2Channels(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		float* ptr = (float*)(void*)inputInterleavedBuffer;
		int* ptr2 = (int*)(void*)asioOutputBuffers[0];
		int* ptr3 = (int*)(void*)asioOutputBuffers[1];
		for (int i = 0; i < nbSamples; i++)
		{
			int* num = ptr2;
			ptr2 = num + 1;
			*num = clampToInt(*ptr);
			int* num2 = ptr3;
			ptr3 = num2 + 1;
			*num2 = clampToInt(ptr[1]);
			ptr += 2;
		}
	}

	public unsafe static void ConvertorFloatToIntGeneric(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		float* ptr = (float*)(void*)inputInterleavedBuffer;
		int*[] array = new int*[nbChannels];
		for (int i = 0; i < nbChannels; i++)
		{
			array[i] = (int*)(void*)asioOutputBuffers[i];
		}
		for (int j = 0; j < nbSamples; j++)
		{
			for (int k = 0; k < nbChannels; k++)
			{
				ref int* reference = ref array[k];
				int* ptr2 = reference;
				reference = ptr2 + 1;
				float* num = ptr;
				ptr = num + 1;
				*ptr2 = clampToInt(*num);
			}
		}
	}

	public unsafe static void ConvertorShortToShort2Channels(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		short* ptr = (short*)(void*)inputInterleavedBuffer;
		short* ptr2 = (short*)(void*)asioOutputBuffers[0];
		short* ptr3 = (short*)(void*)asioOutputBuffers[1];
		for (int i = 0; i < nbSamples; i++)
		{
			short* num = ptr2;
			ptr2 = num + 1;
			*num = *ptr;
			short* num2 = ptr3;
			ptr3 = num2 + 1;
			*num2 = ptr[1];
			ptr += 2;
		}
	}

	public unsafe static void ConvertorShortToShortGeneric(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		short* ptr = (short*)(void*)inputInterleavedBuffer;
		short*[] array = new short*[nbChannels];
		for (int i = 0; i < nbChannels; i++)
		{
			array[i] = (short*)(void*)asioOutputBuffers[i];
		}
		for (int j = 0; j < nbSamples; j++)
		{
			for (int k = 0; k < nbChannels; k++)
			{
				ref short* reference = ref array[k];
				short* ptr2 = reference;
				reference = ptr2 + 1;
				short* num = ptr;
				ptr = num + 1;
				*ptr2 = *num;
			}
		}
	}

	public unsafe static void ConvertorFloatToShort2Channels(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		float* ptr = (float*)(void*)inputInterleavedBuffer;
		short* ptr2 = (short*)(void*)asioOutputBuffers[0];
		short* ptr3 = (short*)(void*)asioOutputBuffers[1];
		for (int i = 0; i < nbSamples; i++)
		{
			short* num = ptr2;
			ptr2 = num + 1;
			*num = clampToShort(*ptr);
			short* num2 = ptr3;
			ptr3 = num2 + 1;
			*num2 = clampToShort(ptr[1]);
			ptr += 2;
		}
	}

	public unsafe static void ConvertorFloatToShortGeneric(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		float* ptr = (float*)(void*)inputInterleavedBuffer;
		short*[] array = new short*[nbChannels];
		for (int i = 0; i < nbChannels; i++)
		{
			array[i] = (short*)(void*)asioOutputBuffers[i];
		}
		for (int j = 0; j < nbSamples; j++)
		{
			for (int k = 0; k < nbChannels; k++)
			{
				ref short* reference = ref array[k];
				short* ptr2 = reference;
				reference = ptr2 + 1;
				float* num = ptr;
				ptr = num + 1;
				*ptr2 = clampToShort(*num);
			}
		}
	}

	public unsafe static void ConverterFloatTo24LSBGeneric(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		float* ptr = (float*)(void*)inputInterleavedBuffer;
		byte*[] array = new byte*[nbChannels];
		for (int i = 0; i < nbChannels; i++)
		{
			array[i] = (byte*)(void*)asioOutputBuffers[i];
		}
		for (int j = 0; j < nbSamples; j++)
		{
			for (int k = 0; k < nbChannels; k++)
			{
				float* num = ptr;
				ptr = num + 1;
				int num2 = clampTo24Bit(*num);
				*(array[k]++) = (byte)num2;
				*(array[k]++) = (byte)(num2 >> 8);
				*(array[k]++) = (byte)(num2 >> 16);
			}
		}
	}

	public unsafe static void ConverterFloatToFloatGeneric(IntPtr inputInterleavedBuffer, IntPtr[] asioOutputBuffers, int nbChannels, int nbSamples)
	{
		float* ptr = (float*)(void*)inputInterleavedBuffer;
		float*[] array = new float*[nbChannels];
		for (int i = 0; i < nbChannels; i++)
		{
			array[i] = (float*)(void*)asioOutputBuffers[i];
		}
		for (int j = 0; j < nbSamples; j++)
		{
			for (int k = 0; k < nbChannels; k++)
			{
				ref float* reference = ref array[k];
				float* ptr2 = reference;
				reference = ptr2 + 1;
				float* num = ptr;
				ptr = num + 1;
				*ptr2 = *num;
			}
		}
	}

	private static int clampTo24Bit(double sampleValue)
	{
		sampleValue = ((sampleValue < -1.0) ? (-1.0) : ((sampleValue > 1.0) ? 1.0 : sampleValue));
		return (int)(sampleValue * 8388607.0);
	}

	private static int clampToInt(double sampleValue)
	{
		sampleValue = ((sampleValue < -1.0) ? (-1.0) : ((sampleValue > 1.0) ? 1.0 : sampleValue));
		return (int)(sampleValue * 2147483647.0);
	}

	private static short clampToShort(double sampleValue)
	{
		sampleValue = ((sampleValue < -1.0) ? (-1.0) : ((sampleValue > 1.0) ? 1.0 : sampleValue));
		return (short)(sampleValue * 32767.0);
	}

	static AsioSampleConvertor()
	{
		Strings.CreateGetStringDelegate(typeof(AsioSampleConvertor));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0018(107399017), _0018(107398980)), _0018(107398975), _0018(107398970)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0018(107398997)))
		{
			return;
		}
		throw new SecurityException(_0018(107398940));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
