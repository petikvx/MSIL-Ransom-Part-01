using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

public sealed class Modulator
{
	private ModulatorType sourceModulationData;

	private GeneratorEnum destinationGenerator;

	private short amount;

	private ModulatorType sourceModulationAmount;

	private TransformEnum sourceTransform;

	[NonSerialized]
	internal static GetString _0082;

	public ModulatorType SourceModulationData
	{
		get
		{
			return sourceModulationData;
		}
		set
		{
			sourceModulationData = value;
		}
	}

	public GeneratorEnum DestinationGenerator
	{
		get
		{
			return destinationGenerator;
		}
		set
		{
			destinationGenerator = value;
		}
	}

	public short Amount
	{
		get
		{
			return amount;
		}
		set
		{
			amount = value;
		}
	}

	public ModulatorType SourceModulationAmount
	{
		get
		{
			return sourceModulationAmount;
		}
		set
		{
			sourceModulationAmount = value;
		}
	}

	public TransformEnum SourceTransform
	{
		get
		{
			return sourceTransform;
		}
		set
		{
			sourceTransform = value;
		}
	}

	public override string ToString()
	{
		return string.Format(_0082(107394210), sourceModulationData, destinationGenerator, amount, sourceModulationAmount, sourceTransform);
	}

	static Modulator()
	{
		Strings.CreateGetStringDelegate(typeof(Modulator));
	}
}
