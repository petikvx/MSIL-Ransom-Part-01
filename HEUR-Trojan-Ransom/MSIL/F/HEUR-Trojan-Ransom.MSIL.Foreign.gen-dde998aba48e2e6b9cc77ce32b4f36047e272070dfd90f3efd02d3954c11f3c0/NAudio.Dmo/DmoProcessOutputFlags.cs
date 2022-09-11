using System;

namespace NAudio.Dmo;

[Flags]
public enum DmoProcessOutputFlags
{
	None = 0,
	DiscardWhenNoBuffer = 1
}
