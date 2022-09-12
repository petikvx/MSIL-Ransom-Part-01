using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PCImplSipccState
{
	[Description("Idle")]
	Idle,
	[Description("Starting")]
	Starting,
	[Description("Started")]
	Started
}
