using System.Windows.Forms;
using Microsoft.SqlServer.Management.UI.Grid;

namespace WatsonDialog;

internal class SqlWatsonGridControl : GridControl
{
	protected override bool HandleTabOnLastOrFirstCell(bool goingLeft)
	{
		return false;
	}

	protected override void RegisterEmbeddedControlInternal(int editableCellType, Control embeddedControl)
	{
		((GridControl)this).RegisterEmbeddedControlInternal(editableCellType, embeddedControl);
		if (editableCellType == 1)
		{
			EmbeddedTextBox val = (EmbeddedTextBox)(object)((embeddedControl is EmbeddedTextBox) ? embeddedControl : null);
			if (val != null)
			{
				((TextBoxBase)val).set_MaxLength(247);
			}
		}
	}
}
