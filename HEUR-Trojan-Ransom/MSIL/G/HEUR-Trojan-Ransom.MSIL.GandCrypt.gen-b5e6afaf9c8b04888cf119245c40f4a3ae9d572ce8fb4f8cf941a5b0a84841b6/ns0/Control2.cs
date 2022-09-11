using System;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control2 : UserControl
{
	public static bool smethod_0(ResolveEventArgs resolveEventArgs_0)
	{
		return Control1.assembly_0.FullName != resolveEventArgs_0.Name;
	}
}
