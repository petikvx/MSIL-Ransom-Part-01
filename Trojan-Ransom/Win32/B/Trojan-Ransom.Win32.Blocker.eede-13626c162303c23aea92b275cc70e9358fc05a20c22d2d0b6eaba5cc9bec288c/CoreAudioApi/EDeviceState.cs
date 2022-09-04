using System;

namespace CoreAudioApi;

[Flags]
public enum EDeviceState : uint
{
	DEVICE_STATE_ACTIVE = 1u,
	DEVICE_STATE_UNPLUGGED = 2u,
	DEVICE_STATE_NOTPRESENT = 4u,
	DEVICE_STATEMASK_ALL = 7u
}
