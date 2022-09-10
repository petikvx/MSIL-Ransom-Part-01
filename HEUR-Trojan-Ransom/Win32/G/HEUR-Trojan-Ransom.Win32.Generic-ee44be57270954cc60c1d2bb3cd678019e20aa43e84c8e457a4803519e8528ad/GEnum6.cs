using System;

[Flags]
public enum GEnum6 : ushort
{
	QUERY = 0,
	IQUERY = 0x800,
	STATUS = 0x1000
}
