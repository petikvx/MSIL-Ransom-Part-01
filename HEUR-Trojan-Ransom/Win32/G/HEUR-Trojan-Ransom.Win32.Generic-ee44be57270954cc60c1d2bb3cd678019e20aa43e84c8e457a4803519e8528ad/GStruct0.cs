using System;

[Serializable]
[Attribute0]
public struct GStruct0
{
	[Attribute1]
	public float X;

	[Attribute1]
	public float Y;

	string ValueType.ToString()
	{
		return $"{{X={X}, Y={Y}}}";
	}
}
