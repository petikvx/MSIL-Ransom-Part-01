using System.Windows.Forms;
using ns0;
using ns5;
using ns7;
using ns8;

namespace ns3;

internal sealed class Class45 : Class44
{
	protected override void vmethod_2(EventArgs2 e)
	{
		e.bool_1 = true;
	}

	protected override void vmethod_0(EventArgs1 e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		e.bool_3 = false;
		if (e.bool_0)
		{
			Class32.smethod_148(e);
		}
		else
		{
			MessageBox.Show("This feature requires that SmartAssembly is available on this computer.", "SmartAssembly Troubleshooting", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	protected override void vmethod_1(EventArgs0 e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(e.exception_0.ToString(), "SmartAssembly Unexpected Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}
}
