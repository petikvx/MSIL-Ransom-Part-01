using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ns0;

internal sealed class EventArgs0 : EventArgs
{
	private Key key_0;

	[SpecialName]
	public Key method_0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return key_0;
	}

	[SpecialName]
	private void method_1(Key key_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		key_0 = key_1;
	}

	public EventArgs0(Key key_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		method_1(key_1);
	}
}
