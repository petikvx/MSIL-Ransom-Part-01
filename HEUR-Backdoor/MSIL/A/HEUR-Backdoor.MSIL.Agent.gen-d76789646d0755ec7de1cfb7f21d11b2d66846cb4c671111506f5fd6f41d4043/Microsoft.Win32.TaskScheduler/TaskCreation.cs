using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public enum TaskCreation
{
	Create = 2,
	CreateOrUpdate = 6,
	Disable = 8,
	DontAddPrincipalAce = 16,
	IgnoreRegistrationTriggers = 32,
	Update = 4,
	ValidateOnly = 1
}
