using System;

namespace Gecko.WebIDL;

public class AudioContext : WebIDLBase
{
	public nsISupports Destination => GetProperty<nsISupports>("destination");

	public float SampleRate => GetProperty<float>("sampleRate");

	public double CurrentTime => GetProperty<double>("currentTime");

	public nsISupports Listener => GetProperty<nsISupports>("listener");

	public AudioContextState State => GetProperty<AudioContextState>("state");

	public AudioChannel MozAudioChannelType => GetProperty<AudioChannel>("mozAudioChannelType");

	public AudioContext(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Suspend()
	{
		return CallMethod<Promise>("suspend", new object[0]);
	}

	public Promise Resume()
	{
		return CallMethod<Promise>("resume", new object[0]);
	}

	public Promise Close()
	{
		return CallMethod<Promise>("close", new object[0]);
	}

	public nsISupports CreateBuffer(uint numberOfChannels, uint length, float sampleRate)
	{
		return CallMethod<nsISupports>("createBuffer", new object[3] { numberOfChannels, length, sampleRate });
	}

	public Promise<nsISupports> DecodeAudioData(IntPtr audioData)
	{
		return CallMethod<Promise<nsISupports>>("decodeAudioData", new object[1] { audioData });
	}

	public nsISupports CreateBufferSource()
	{
		return CallMethod<nsISupports>("createBufferSource", new object[0]);
	}

	public nsISupports CreateMediaStreamDestination()
	{
		return CallMethod<nsISupports>("createMediaStreamDestination", new object[0]);
	}

	public nsISupports CreateScriptProcessor()
	{
		return CallMethod<nsISupports>("createScriptProcessor", new object[0]);
	}

	public nsISupports CreateScriptProcessor(uint bufferSize)
	{
		return CallMethod<nsISupports>("createScriptProcessor", new object[1] { bufferSize });
	}

	public nsISupports CreateScriptProcessor(uint bufferSize, uint numberOfInputChannels)
	{
		return CallMethod<nsISupports>("createScriptProcessor", new object[2] { bufferSize, numberOfInputChannels });
	}

	public nsISupports CreateScriptProcessor(uint bufferSize, uint numberOfInputChannels, uint numberOfOutputChannels)
	{
		return CallMethod<nsISupports>("createScriptProcessor", new object[3] { bufferSize, numberOfInputChannels, numberOfOutputChannels });
	}

	public nsISupports CreateStereoPanner()
	{
		return CallMethod<nsISupports>("createStereoPanner", new object[0]);
	}

	public nsISupports CreateAnalyser()
	{
		return CallMethod<nsISupports>("createAnalyser", new object[0]);
	}

	public nsISupports CreateMediaElementSource(nsISupports mediaElement)
	{
		return CallMethod<nsISupports>("createMediaElementSource", new object[1] { mediaElement });
	}

	public nsISupports CreateMediaStreamSource(nsISupports mediaStream)
	{
		return CallMethod<nsISupports>("createMediaStreamSource", new object[1] { mediaStream });
	}

	public nsISupports CreateGain()
	{
		return CallMethod<nsISupports>("createGain", new object[0]);
	}

	public nsISupports CreateDelay()
	{
		return CallMethod<nsISupports>("createDelay", new object[0]);
	}

	public nsISupports CreateDelay(double maxDelayTime)
	{
		return CallMethod<nsISupports>("createDelay", new object[1] { maxDelayTime });
	}

	public nsISupports CreateBiquadFilter()
	{
		return CallMethod<nsISupports>("createBiquadFilter", new object[0]);
	}

	public nsISupports CreateWaveShaper()
	{
		return CallMethod<nsISupports>("createWaveShaper", new object[0]);
	}

	public nsISupports CreatePanner()
	{
		return CallMethod<nsISupports>("createPanner", new object[0]);
	}

	public nsISupports CreateConvolver()
	{
		return CallMethod<nsISupports>("createConvolver", new object[0]);
	}

	public nsISupports CreateChannelSplitter()
	{
		return CallMethod<nsISupports>("createChannelSplitter", new object[0]);
	}

	public nsISupports CreateChannelSplitter(uint numberOfOutputs)
	{
		return CallMethod<nsISupports>("createChannelSplitter", new object[1] { numberOfOutputs });
	}

	public nsISupports CreateChannelMerger()
	{
		return CallMethod<nsISupports>("createChannelMerger", new object[0]);
	}

	public nsISupports CreateChannelMerger(uint numberOfInputs)
	{
		return CallMethod<nsISupports>("createChannelMerger", new object[1] { numberOfInputs });
	}

	public nsISupports CreateDynamicsCompressor()
	{
		return CallMethod<nsISupports>("createDynamicsCompressor", new object[0]);
	}

	public nsISupports CreateOscillator()
	{
		return CallMethod<nsISupports>("createOscillator", new object[0]);
	}

	public nsISupports CreatePeriodicWave(IntPtr real, IntPtr imag)
	{
		return CallMethod<nsISupports>("createPeriodicWave", new object[2] { real, imag });
	}

	public AudioChannel TestAudioChannelInAudioNodeStream()
	{
		return CallMethod<AudioChannel>("testAudioChannelInAudioNodeStream", new object[0]);
	}
}
