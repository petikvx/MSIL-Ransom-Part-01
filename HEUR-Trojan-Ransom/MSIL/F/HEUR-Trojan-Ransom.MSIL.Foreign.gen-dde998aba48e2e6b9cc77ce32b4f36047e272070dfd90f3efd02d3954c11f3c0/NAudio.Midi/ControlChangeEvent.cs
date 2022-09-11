using System;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class ControlChangeEvent : MidiEvent
{
	private MidiController controller;

	private byte controllerValue;

	[NonSerialized]
	internal static GetString _0004;

	public MidiController Controller
	{
		get
		{
			return controller;
		}
		set
		{
			if ((int)value < 0 || (int)value > 127)
			{
				throw new ArgumentOutOfRangeException(_0004(107392352), _0004(107414674));
			}
			controller = value;
		}
	}

	public int ControllerValue
	{
		get
		{
			return controllerValue;
		}
		set
		{
			if (value < 0 || value > 127)
			{
				throw new ArgumentOutOfRangeException(_0004(107392352), _0004(107414101));
			}
			controllerValue = (byte)value;
		}
	}

	public ControlChangeEvent(BinaryReader br)
	{
		byte b = br.ReadByte();
		controllerValue = br.ReadByte();
		if ((b & 0x80u) != 0)
		{
			throw new InvalidDataException(_0004(107414789));
		}
		controller = (MidiController)b;
		if ((controllerValue & 0x80u) != 0)
		{
			throw new InvalidDataException(string.Format(_0004(107414764), controllerValue, controller, br.BaseStream.Position));
		}
	}

	public ControlChangeEvent(long absoluteTime, int channel, MidiController controller, int controllerValue)
		: base(absoluteTime, channel, MidiCommandCode.ControlChange)
	{
		Controller = controller;
		ControllerValue = controllerValue;
	}

	public override string ToString()
	{
		return string.Format(_0004(107414715), base.ToString(), controller, controllerValue);
	}

	public override int GetAsShortMessage()
	{
		byte b = (byte)controller;
		return base.GetAsShortMessage() + (b << 8) + (controllerValue << 16);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write((byte)controller);
		writer.Write(controllerValue);
	}

	static ControlChangeEvent()
	{
		Strings.CreateGetStringDelegate(typeof(ControlChangeEvent));
	}
}
