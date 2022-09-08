using System;
using System.Collections.Generic;

namespace Orcus.StaticCommandManagement;

[Serializable]
public class StopSchedulerSettings
{
	public List<SessionCommandInfo> Sessions { get; set; }

	public List<DurationStopEventInfo> DurationStopEventInfos { get; set; }

	public StopSchedulerSettings()
	{
		Sessions = new List<SessionCommandInfo>();
		DurationStopEventInfos = new List<DurationStopEventInfo>();
	}
}
