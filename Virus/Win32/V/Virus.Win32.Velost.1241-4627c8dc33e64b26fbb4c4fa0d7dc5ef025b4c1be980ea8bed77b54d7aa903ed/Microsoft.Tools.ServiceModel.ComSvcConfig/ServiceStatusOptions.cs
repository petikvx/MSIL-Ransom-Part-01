using System;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[Serializable]
internal enum ServiceStatusOptions
{
	Stopped,
	StartPending,
	StopPending,
	Running,
	ContinuePending,
	PausePending,
	Paused,
	UnknownState
}
