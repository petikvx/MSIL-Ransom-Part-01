using System;
using System.Windows.Forms;

namespace C3554254475;

public sealed class C140662621 : EventArgs
{
	private string C3554254475 = string.Empty;

	private string C3904355907 = string.Empty;

	private MessageBoxButtons C3554254475 = (MessageBoxButtons)0;

	private MessageBoxIcon C3554254475 = (MessageBoxIcon)0;

	public C140662621(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		this.C3554254475 = string_0 ?? string.Empty;
		C3904355907 = string_1 ?? string.Empty;
		this.C3554254475 = messageBoxButtons_0;
		C3554254475 = messageBoxIcon_0;
	}
}
