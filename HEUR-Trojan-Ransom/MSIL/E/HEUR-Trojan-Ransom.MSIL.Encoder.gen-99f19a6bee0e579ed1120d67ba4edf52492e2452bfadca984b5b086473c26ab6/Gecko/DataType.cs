namespace Gecko;

public enum DataType : ushort
{
	Int8 = 0,
	Int16 = 1,
	Int32 = 2,
	Int64 = 3,
	UInt8 = 4,
	UInt16 = 5,
	UInt32 = 6,
	UInt64 = 7,
	Float = 8,
	Double = 9,
	Bool = 10,
	Char = 11,
	Wchar = 12,
	Void = 13,
	ID = 14,
	DomString = 15,
	CharPtr = 16,
	WCharPtr = 17,
	Interface = 18,
	InterfaceIs = 19,
	Array = 20,
	StringSizeIs = 21,
	WStringSizeIs = 22,
	Utf8String = 23,
	CString = 24,
	AString = 25,
	EmptyArray = 254,
	Empty = 255
}
