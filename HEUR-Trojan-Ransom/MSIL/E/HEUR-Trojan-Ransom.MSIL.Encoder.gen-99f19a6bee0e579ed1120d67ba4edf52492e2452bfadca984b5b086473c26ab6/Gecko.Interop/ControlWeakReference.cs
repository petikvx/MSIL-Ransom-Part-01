using System;
using System.Windows.Forms;

namespace Gecko.Interop;

internal sealed class ControlWeakReference : nsWeakReference
{
	internal ControlWeakReference(Control control)
		: base(control)
	{
	}

	protected override IntPtr QueryReferentImplementation(object obj, ref Guid uuid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Control)obj).get_IsDisposed() ? IntPtr.Zero : base.QueryReferentImplementation(obj, ref uuid);
	}
}
