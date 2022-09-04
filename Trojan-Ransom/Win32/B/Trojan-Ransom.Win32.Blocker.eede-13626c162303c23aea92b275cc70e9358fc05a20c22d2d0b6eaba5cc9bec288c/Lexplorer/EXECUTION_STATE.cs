using System;

namespace Lexplorer;

[Flags]
public enum EXECUTION_STATE : uint
{
	ES_SYSTEM_REQUIRED = 1u,
	ES_DISPLAY_REQUIRED = 2u,
	ES_AWAYMODE_REQUIRED = 0x40u,
	ES_CONTINUOUS = 0x80000000u
}
