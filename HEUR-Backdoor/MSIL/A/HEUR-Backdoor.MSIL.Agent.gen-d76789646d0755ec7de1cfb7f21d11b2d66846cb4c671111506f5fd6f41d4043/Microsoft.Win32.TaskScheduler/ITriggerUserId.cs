using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public interface ITriggerUserId
{
	string UserId { get; set; }
}
