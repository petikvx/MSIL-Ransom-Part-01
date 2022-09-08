using System;

namespace Orcus.StaticCommandManagement;

[Serializable]
public class SessionCommandInfo
{
	public int CommandId { get; set; }

	public DateTime StartupTime { get; set; }
}
