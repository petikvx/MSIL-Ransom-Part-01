using System.Drawing;
using System.Windows.Forms;

namespace Orcus.Commands.TextChat.Utilities;

public static class RichTextBoxExtensions
{
	public static void AppendText(this RichTextBox box, string text, Color color)
	{
		((TextBoxBase)box).set_SelectionStart(((TextBoxBase)box).get_TextLength());
		((TextBoxBase)box).set_SelectionLength(0);
		box.set_SelectionColor(color);
		((TextBoxBase)box).AppendText(text);
		box.set_SelectionColor(((Control)box).get_ForeColor());
	}

	public static void ScrollToEnd(this RichTextBox box)
	{
		((TextBoxBase)box).set_SelectionStart(((Control)box).get_Text().Length);
		((TextBoxBase)box).ScrollToCaret();
	}
}
