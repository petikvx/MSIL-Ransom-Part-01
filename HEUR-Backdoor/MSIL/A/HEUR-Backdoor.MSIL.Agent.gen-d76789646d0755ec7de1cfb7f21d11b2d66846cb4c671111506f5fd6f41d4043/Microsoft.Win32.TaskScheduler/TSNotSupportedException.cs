using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[DebuggerStepThrough]
public abstract class TSNotSupportedException : Exception
{
	protected TaskCompatibility min;

	private string myMessage;

	public override string Message => myMessage;

	public TaskCompatibility MinimumSupportedVersion => min;

	internal abstract string LibName { get; }

	internal TSNotSupportedException(TaskCompatibility minComp)
	{
		min = minComp;
		StackTrace stackTrace = new StackTrace();
		StackFrame frame = stackTrace.GetFrame(2);
		MethodBase method = frame.GetMethod();
		myMessage = $"{method.DeclaringType!.Name}.{method.Name} is not supported on {LibName}";
	}

	internal TSNotSupportedException(string message, TaskCompatibility minComp)
	{
		myMessage = message;
		min = minComp;
	}
}
