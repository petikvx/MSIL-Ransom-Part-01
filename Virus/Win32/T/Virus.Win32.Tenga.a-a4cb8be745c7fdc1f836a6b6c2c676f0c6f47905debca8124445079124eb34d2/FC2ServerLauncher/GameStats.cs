using System.Collections.Generic;

namespace FC2ServerLauncher;

internal class GameStats
{
	internal string m_map = "";

	internal string m_mode = "";

	internal List<PlayerScore> m_players = new List<PlayerScore>();

	internal List<TeamScore> m_teams = new List<TeamScore>();
}
