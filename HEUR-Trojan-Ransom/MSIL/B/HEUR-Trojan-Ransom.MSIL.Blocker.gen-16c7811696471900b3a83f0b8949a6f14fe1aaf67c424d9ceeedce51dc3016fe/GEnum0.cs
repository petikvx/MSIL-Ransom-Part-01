using System;

[Flags]
public enum GEnum0
{
	Success = 0,
	Corrupted = 1,
	Invalid = 2,
	Blacklisted = 4,
	DateExpired = 8,
	RunningTimeOver = 0x10,
	BadHwid = 0x20,
	MaxBuildExpired = 0x40
}
