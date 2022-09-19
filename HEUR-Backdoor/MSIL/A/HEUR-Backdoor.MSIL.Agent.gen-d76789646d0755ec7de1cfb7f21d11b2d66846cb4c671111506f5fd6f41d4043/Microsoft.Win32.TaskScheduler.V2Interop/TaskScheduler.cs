using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[CoClass(typeof(TaskSchedulerClass))]
[SuppressUnmanagedCodeSecurity]
[Guid("2FABA4C7-4DA9-4013-9697-20CC3FD40F85")]
internal interface TaskScheduler : ITaskService
{
}
