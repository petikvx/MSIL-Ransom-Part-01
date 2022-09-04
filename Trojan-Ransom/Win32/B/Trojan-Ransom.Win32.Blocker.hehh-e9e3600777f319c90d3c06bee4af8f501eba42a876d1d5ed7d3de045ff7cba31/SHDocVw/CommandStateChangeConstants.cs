using System.Runtime.InteropServices;

namespace SHDocVw;

[Guid("34A226E0-DF30-11CF-89A9-00A0C9054129")]
public enum CommandStateChangeConstants
{
	CSC_UPDATECOMMANDS = -1,
	CSC_NAVIGATEFORWARD = 1,
	CSC_NAVIGATEBACK = 2
}
