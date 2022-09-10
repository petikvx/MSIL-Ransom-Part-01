using System;

namespace Intuit.Spc.Map.HelpSystem;

[Flags]
internal enum REGCLS : uint
{
	REGCLS_SINGLEUSE = 0u,
	REGCLS_MULTIPLEUSE = 1u,
	REGCLS_MULTI_SEPARATE = 2u,
	REGCLS_SUSPENDED = 4u,
	REGCLS_SURROGATE = 8u
}
