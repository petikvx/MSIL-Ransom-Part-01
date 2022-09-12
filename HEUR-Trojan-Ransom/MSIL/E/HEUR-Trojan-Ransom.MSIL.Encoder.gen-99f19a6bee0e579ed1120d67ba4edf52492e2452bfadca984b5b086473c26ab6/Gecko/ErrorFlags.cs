using System;

namespace Gecko;

[Flags]
public enum ErrorFlags
{
	REPORT_ERROR = 0,
	REPORT_WARNING = 1,
	REPORT_EXCEPTION = 2,
	REPORT_STRICT = 4
}
