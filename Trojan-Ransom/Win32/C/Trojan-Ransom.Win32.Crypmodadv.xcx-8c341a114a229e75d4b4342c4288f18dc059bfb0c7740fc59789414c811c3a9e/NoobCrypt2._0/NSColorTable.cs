using System.Drawing;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSColorTable : ProfessionalColorTable
{
	private Color BackColor;

	public override Color ButtonSelectedBorder => BackColor;

	public override Color CheckBackground => BackColor;

	public override Color CheckPressedBackground => BackColor;

	public override Color CheckSelectedBackground => BackColor;

	public override Color ImageMarginGradientBegin => BackColor;

	public override Color ImageMarginGradientEnd => BackColor;

	public override Color ImageMarginGradientMiddle => BackColor;

	public override Color MenuBorder => Color.FromArgb(25, 25, 25);

	public override Color MenuItemBorder => BackColor;

	public override Color MenuItemSelected => Color.FromArgb(65, 65, 65);

	public override Color SeparatorDark => Color.FromArgb(35, 35, 35);

	public override Color ToolStripDropDownBackground => BackColor;

	public NSColorTable()
	{
		BackColor = Color.FromArgb(55, 55, 55);
	}
}
