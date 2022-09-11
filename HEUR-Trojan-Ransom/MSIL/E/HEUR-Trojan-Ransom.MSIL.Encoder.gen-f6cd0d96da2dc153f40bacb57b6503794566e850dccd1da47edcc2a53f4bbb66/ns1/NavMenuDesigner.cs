using System.Drawing;
using System.Windows.Forms.Design;

namespace ns1;

public class NavMenuDesigner : ControlDesigner
{
	protected override bool vmethod_0(Point point_0)
	{
		return ((NavMenu)(object)((ControlDesigner)this).get_Control()).vmethod_0(((ControlDesigner)this).get_Control().PointToClient(point_0)) != null;
	}

	protected override void vmethod_1()
	{
		((NavMenu)(object)((ControlDesigner)this).get_Control()).method_3(null);
		((ControlDesigner)this).OnMouseLeave();
	}
}
