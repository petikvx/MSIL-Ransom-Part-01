using System;

namespace ns0;

public interface ICellEditControl
{
	object CurrentValue { get; set; }

	bool EditWordWrap { get; set; }

	event EventHandler EditComplete;

	event EventHandler CancelEdit;

	void imethod_0();

	void imethod_1();
}
