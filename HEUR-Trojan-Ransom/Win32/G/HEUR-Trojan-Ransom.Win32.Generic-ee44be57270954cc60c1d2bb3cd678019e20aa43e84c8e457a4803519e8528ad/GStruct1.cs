using System;

[Serializable]
[Attribute0]
public struct GStruct1
{
	[Attribute1]
	public int X;

	[Attribute1]
	public int Y;

	string ValueType.ToString()
	{
		return $"{{X={X}, Y={Y}}}";
	}
}
