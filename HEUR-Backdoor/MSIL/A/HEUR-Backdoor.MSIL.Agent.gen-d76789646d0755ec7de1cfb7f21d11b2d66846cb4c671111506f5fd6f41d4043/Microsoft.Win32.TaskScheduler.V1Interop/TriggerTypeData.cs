using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

[StructLayout(LayoutKind.Explicit)]
internal struct TriggerTypeData
{
	[FieldOffset(0)]
	public Daily daily;

	[FieldOffset(0)]
	public Weekly weekly;

	[FieldOffset(0)]
	public MonthlyDate monthlyDate;

	[FieldOffset(0)]
	public MonthlyDOW monthlyDOW;
}
