using System;

[Serializable]
[Attribute0]
public class GClass31
{
	[Attribute1]
	public GStruct21 AccelCalibrationInfo;

	[Attribute1]
	public GStruct20 AccelState;

	[Attribute1]
	public GStruct22 ButtonState;

	[Attribute1]
	public GStruct19 IRState;

	[Attribute1]
	public byte BatteryRaw;

	[Attribute1]
	public float Battery;

	[Attribute1]
	public bool Rumble;

	[Attribute1]
	public bool Extension;

	[Attribute1]
	public GEnum9 ExtensionType;

	[Attribute1]
	public GStruct7 NunchukState;

	[Attribute1]
	public GStruct9 ClassicControllerState;

	[Attribute1]
	public GStruct10 GuitarState;

	[Attribute1]
	public GStruct13 DrumsState;

	public GStruct14 BalanceBoardState;

	[Attribute1]
	public GStruct4 LEDState;

	public GClass31()
	{
		IRState.IRSensors = new GStruct18[4];
	}
}
