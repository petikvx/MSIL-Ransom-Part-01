using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("42a1e1dc-58cf-419d-bff0-ed3314c70016")]
public interface nsIAccessibleValue
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetMaximumValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetMinimumValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetCurrentValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentValueAttribute(double aCurrentValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetMinimumIncrementAttribute();
}
