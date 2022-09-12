using System;

namespace Gecko;

[Flags]
public enum CertOverride
{
	Mismatch = 2,
	Time = 4,
	Untrusted = 1
}
