using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shrug;

internal class PHTextBox : TextBox
{
	private Color DefaultColor;

	public string PlaceHolderText { get; set; }

	public PHTextBox(string placeholdertext)
	{
		DefaultColor = ((Control)this).get_ForeColor();
		((Control)this).add_GotFocus((EventHandler)delegate
		{
			((Control)this).set_Text(string.Empty);
			((Control)this).set_ForeColor(DefaultColor);
		});
		((Control)this).add_LostFocus((EventHandler)delegate
		{
			if (string.IsNullOrEmpty(((Control)this).get_Text()) || ((Control)this).get_Text() == PlaceHolderText)
			{
				((Control)this).set_ForeColor(Color.Gray);
				((Control)this).set_Text(PlaceHolderText);
			}
			else
			{
				((Control)this).set_ForeColor(DefaultColor);
			}
		});
		if (!string.IsNullOrEmpty(placeholdertext))
		{
			((Control)this).set_ForeColor(Color.Gray);
			PlaceHolderText = placeholdertext;
			((Control)this).set_Text(placeholdertext);
		}
	}
}
