using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

public sealed class ModulatorType
{
	private bool polarity;

	private bool direction;

	private bool midiContinuousController;

	private ControllerSourceEnum controllerSource;

	private SourceTypeEnum sourceType;

	private ushort midiContinuousControllerNumber;

	[NonSerialized]
	internal static GetString _0084;

	internal ModulatorType(ushort raw)
	{
		polarity = (raw & 0x200) == 512;
		direction = (raw & 0x100) == 256;
		midiContinuousController = (raw & 0x80) == 128;
		sourceType = (SourceTypeEnum)((raw & 0xFC00) >> 10);
		controllerSource = (ControllerSourceEnum)(raw & 0x7F);
		midiContinuousControllerNumber = (ushort)(raw & 0x7Fu);
	}

	public override string ToString()
	{
		if (midiContinuousController)
		{
			return string.Format(_0084(107394670), sourceType, midiContinuousControllerNumber);
		}
		return string.Format(_0084(107395810), sourceType, controllerSource);
	}

	static ModulatorType()
	{
		Strings.CreateGetStringDelegate(typeof(ModulatorType));
	}
}
