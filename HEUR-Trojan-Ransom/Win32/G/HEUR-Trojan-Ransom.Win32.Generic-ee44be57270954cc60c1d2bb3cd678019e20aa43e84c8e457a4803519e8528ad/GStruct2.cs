using System;

[Serializable]
[Attribute0]
public struct GStruct2
{
	[Attribute1]
	public float X;

	[Attribute1]
	public float Y;

	[Attribute1]
	public float Z;

	string ValueType.ToString()
	{
		return $"{{X={X}, Y={Y}, Z={Z}}}";
	}
}
