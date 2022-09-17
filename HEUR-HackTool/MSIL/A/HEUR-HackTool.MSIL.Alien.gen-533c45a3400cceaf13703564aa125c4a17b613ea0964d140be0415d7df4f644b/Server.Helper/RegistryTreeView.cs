using System.Windows.Forms;

namespace Server.Helper;

public class RegistryTreeView : TreeView
{
	public RegistryTreeView()
	{
		((Control)this).SetStyle((ControlStyles)139264, true);
	}
}
