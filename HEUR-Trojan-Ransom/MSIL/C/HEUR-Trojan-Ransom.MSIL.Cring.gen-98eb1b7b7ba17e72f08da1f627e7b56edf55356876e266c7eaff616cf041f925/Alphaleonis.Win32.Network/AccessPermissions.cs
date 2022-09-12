using System;

namespace Alphaleonis.Win32.Network;

[Flags]
public enum AccessPermissions
{
	None = 0,
	Read = 1,
	Write = 2,
	Create = 4,
	Execute = 8,
	Delete = 0x10,
	Attributes = 0x20,
	Permissions = 0x40,
	All = 0x8000
}
