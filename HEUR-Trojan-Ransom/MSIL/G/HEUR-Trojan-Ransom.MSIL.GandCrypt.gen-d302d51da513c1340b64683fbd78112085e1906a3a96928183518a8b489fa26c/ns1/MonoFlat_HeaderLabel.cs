using System.Drawing;
using System.Windows.Forms;

namespace ns1;

public class MonoFlat_HeaderLabel : Label
{
	public MonoFlat_HeaderLabel()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Control)this).set_Font(new Font("Segoe UI", 11f, (FontStyle)1));
		((Control)this).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)this).set_BackColor(Color.Transparent);
	}
}
