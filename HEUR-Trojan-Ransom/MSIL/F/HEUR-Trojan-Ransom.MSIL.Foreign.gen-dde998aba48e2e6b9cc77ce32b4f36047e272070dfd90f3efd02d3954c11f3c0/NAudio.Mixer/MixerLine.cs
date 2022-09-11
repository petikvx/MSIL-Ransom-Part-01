using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Mixer;

public sealed class MixerLine
{
	private MixerInterop.MIXERLINE mixerLine;

	private IntPtr mixerHandle;

	private MixerFlags mixerHandleType;

	[NonSerialized]
	internal static GetString _0092;

	public string Name => mixerLine.szName;

	public string ShortName => mixerLine.szShortName;

	public int LineId => mixerLine.dwLineID;

	public MixerLineComponentType ComponentType => mixerLine.dwComponentType;

	public string TypeDescription => mixerLine.dwComponentType switch
	{
		MixerLineComponentType.DestinationUndefined => _0092(107395887), 
		MixerLineComponentType.DestinationDigital => _0092(107395858), 
		MixerLineComponentType.DestinationLine => _0092(107395829), 
		MixerLineComponentType.DestinationMonitor => _0092(107395796), 
		MixerLineComponentType.DestinationSpeakers => _0092(107395767), 
		MixerLineComponentType.DestinationHeadphones => _0092(107395738), 
		MixerLineComponentType.DestinationTelephone => _0092(107395705), 
		MixerLineComponentType.DestinationWaveIn => _0092(107395708), 
		MixerLineComponentType.DestinationVoiceIn => _0092(107395675), 
		MixerLineComponentType.SourceUndefined => _0092(107395090), 
		MixerLineComponentType.SourceDigital => _0092(107395065), 
		MixerLineComponentType.SourceLine => _0092(107395076), 
		MixerLineComponentType.SourceMicrophone => _0092(107395019), 
		MixerLineComponentType.SourceSynthesizer => _0092(107394994), 
		MixerLineComponentType.SourceCompactDisc => _0092(107394969), 
		MixerLineComponentType.SourceTelephone => _0092(107394972), 
		MixerLineComponentType.SourcePcSpeaker => _0092(107394947), 
		MixerLineComponentType.SourceWaveOut => _0092(107394922), 
		MixerLineComponentType.SourceAuxiliary => _0092(107395381), 
		MixerLineComponentType.SourceAnalog => _0092(107395388), 
		_ => _0092(107395367), 
	};

	public int Channels => mixerLine.cChannels;

	public int SourceCount => mixerLine.cConnections;

	public int ControlsCount => mixerLine.cControls;

	public bool IsActive => (mixerLine.fdwLine & MixerInterop.MIXERLINE_LINEF.MIXERLINE_LINEF_ACTIVE) != 0;

	public bool IsDisconnected => (mixerLine.fdwLine & MixerInterop.MIXERLINE_LINEF.MIXERLINE_LINEF_DISCONNECTED) != 0;

	public bool IsSource => (mixerLine.fdwLine & MixerInterop.MIXERLINE_LINEF.MIXERLINE_LINEF_SOURCE) != 0;

	public IEnumerable<MixerControl> Controls => MixerControl.GetMixerControls(mixerHandle, this, mixerHandleType);

	public IEnumerable<MixerLine> Sources
	{
		get
		{
			for (int source = 0; source < SourceCount; source++)
			{
				yield return GetSource(source);
			}
		}
	}

	public string TargetName => mixerLine.szPname;

	public MixerLine(IntPtr mixerHandle, int destinationIndex, MixerFlags mixerHandleType)
	{
		this.mixerHandle = mixerHandle;
		this.mixerHandleType = mixerHandleType;
		mixerLine = default(MixerInterop.MIXERLINE);
		mixerLine.cbStruct = Marshal.SizeOf((object)mixerLine);
		mixerLine.dwDestination = destinationIndex;
		MmException.Try(MixerInterop.mixerGetLineInfo(mixerHandle, ref mixerLine, mixerHandleType | MixerFlags.Mixer), _0092(107395417));
	}

	public MixerLine(IntPtr mixerHandle, int destinationIndex, int sourceIndex, MixerFlags mixerHandleType)
	{
		this.mixerHandle = mixerHandle;
		this.mixerHandleType = mixerHandleType;
		mixerLine = default(MixerInterop.MIXERLINE);
		mixerLine.cbStruct = Marshal.SizeOf((object)mixerLine);
		mixerLine.dwDestination = destinationIndex;
		mixerLine.dwSource = sourceIndex;
		MmException.Try(MixerInterop.mixerGetLineInfo(mixerHandle, ref mixerLine, mixerHandleType | MixerFlags.ListText), _0092(107395417));
	}

	public static int GetMixerIdForWaveIn(int waveInDevice)
	{
		int mixerID = -1;
		MmException.Try(MixerInterop.mixerGetID((IntPtr)waveInDevice, out mixerID, MixerFlags.WaveIn), _0092(107395424));
		return mixerID;
	}

	public MixerLine GetSource(int sourceIndex)
	{
		if (sourceIndex < 0 || sourceIndex >= SourceCount)
		{
			throw new ArgumentOutOfRangeException(_0092(107395334));
		}
		return new MixerLine(mixerHandle, mixerLine.dwDestination, sourceIndex, mixerHandleType);
	}

	public override string ToString()
	{
		return string.Format(_0092(107395285), Name, TypeDescription, ControlsCount, mixerLine.dwLineID);
	}

	static MixerLine()
	{
		Strings.CreateGetStringDelegate(typeof(MixerLine));
	}
}
