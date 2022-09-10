using System;

[Serializable]
[Attribute0]
public struct GStruct18
{
	[Attribute1]
	public GStruct1 RawPosition;

	[Attribute1]
	public GStruct0 Position;

	[Attribute1]
	public int Size;

	[Attribute1]
	public bool Found;

	string ValueType.ToString()
	{
		return $"{{{Position}, Size={Size}, Found={Found}}}";
	}
}
