using System;

namespace GreenPixelsCalculator.IO;

[Flags]
public enum ParamType : ushort
{
	_FIXED_LENGTH = 1,
	_PREFIXED_LENGTH = 2,
	_SPECIAL = 4,
	BYTES_1 = 9,
	BYTES_2 = 0x11,
	BYTES_4 = 0x19,
	BYTES_8 = 0x21,
	BYTES_16 = 0x29,
	DYNAMIC = 0x40,
	BOOLEAN = 0x99,
	CHAR = 0xC9,
	SBYTE = 0x109,
	BYTE = 0x149,
	SHORT = 0x191,
	USHORT = 0x1D1,
	INT = 0x219,
	UINT = 0x259,
	LONG = 0x2A1,
	ULONG = 0x2E1,
	FLOAT = 0x319,
	DOUBLE = 0x361,
	DECIMAL = 0x3A9,
	DATETIME = 0x3E1,
	GUID = 0x429,
	STRING = 0x442,
	RAW = 0x4C2,
	_IF_TRUE = 0x804,
	_IF_0 = 0x1004,
	_IF_NOT_0 = 0x1804,
	_ARRAY_OF = 0x2004,
	__KINDS = 7,
	__LENGTHS = 0x38,
	__DATATYPES = 0x7C0,
	__SPECIALS = 0x7800,
	__LENGTHS_AND_KINDS = 0x3F
}
