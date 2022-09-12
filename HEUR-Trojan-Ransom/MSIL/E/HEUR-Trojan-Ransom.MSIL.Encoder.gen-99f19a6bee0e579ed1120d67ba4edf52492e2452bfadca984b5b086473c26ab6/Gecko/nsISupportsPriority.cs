using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("aa578b44-abd5-4c19-8b14-36d4de6fdc36")]
public interface nsISupportsPriority
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPriorityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPriorityAttribute(int aPriority);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AdjustPriority(int delta);
}
