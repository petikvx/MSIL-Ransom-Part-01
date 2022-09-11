using System.Drawing;
using System.Windows.Forms;

namespace ns0;

public class GClass4 : LinkLabel
{
	public GClass4()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Control)this).set_Font(new Font("Segoe UI", 9f, (FontStyle)0));
		((Control)this).set_BackColor(Color.Transparent);
		((LinkLabel)this).set_LinkColor(Color.FromArgb(181, 41, 42));
		((LinkLabel)this).set_ActiveLinkColor(Color.FromArgb(153, 34, 34));
		((LinkLabel)this).set_VisitedLinkColor(Color.FromArgb(181, 41, 42));
		((LinkLabel)this).set_LinkBehavior((LinkBehavior)3);
	}
}
