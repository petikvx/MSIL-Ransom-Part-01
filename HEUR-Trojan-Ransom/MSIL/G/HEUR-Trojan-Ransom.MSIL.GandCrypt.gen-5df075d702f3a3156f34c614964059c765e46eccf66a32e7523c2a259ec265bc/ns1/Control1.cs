using System;
using System.Windows.Forms;

namespace ns1;

internal sealed class Control1 : UserControl
{
	public static bool smethod_0(ResolveEventArgs resolveEventArgs_0)
	{
		return Control3.assembly_0.FullName != resolveEventArgs_0.Name;
	}
}
