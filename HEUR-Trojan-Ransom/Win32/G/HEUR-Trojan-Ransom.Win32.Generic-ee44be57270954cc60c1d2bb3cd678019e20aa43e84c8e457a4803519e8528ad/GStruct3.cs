using System;

[Serializable]
[Attribute0]
public struct GStruct3
{
	[Attribute1]
	public int X;

	[Attribute1]
	public int Y;

	[Attribute1]
	public int Z;

	string ValueType.ToString()
	{
		return $"{{X={X}, Y={Y}, Z={Z}}}";
	}
}
