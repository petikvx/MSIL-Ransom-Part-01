using System;

namespace NAudio.Dmo;

[Flags]
internal enum DmoInputStatusFlags
{
	None = 0,
	DMO_INPUT_STATUSF_ACCEPT_DATA = 1
}
