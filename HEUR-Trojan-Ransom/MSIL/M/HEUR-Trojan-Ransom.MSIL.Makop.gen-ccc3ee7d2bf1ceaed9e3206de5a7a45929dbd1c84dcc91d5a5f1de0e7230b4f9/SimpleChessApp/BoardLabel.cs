using System.Drawing;
using System.Windows.Forms;

namespace SimpleChessApp;

public class BoardLabel : Label
{
	public BoardLabel()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		BoardLabel.smethod_0((Control)(object)this, (AnchorStyles)15);
		BoardLabel.smethod_1((Control)(object)this, Color.WhiteSmoke);
		BoardLabel.smethod_2((Label)(object)this, (ContentAlignment)2);
		BoardLabel.smethod_3((Control)(object)this, new Padding(0));
		BoardLabel.smethod_6((Control)(object)this, BoardLabel.smethod_5(BoardLabel.smethod_4("Arial"), 8f, (FontStyle)1));
	}

	static void smethod_0(Control control_0, AnchorStyles anchorStyles_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Anchor(anchorStyles_0);
	}

	static void smethod_1(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_2(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_3(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static FontFamily smethod_4(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new FontFamily(string_0);
	}

	static Font smethod_5(FontFamily fontFamily_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(fontFamily_0, float_0, fontStyle_0);
	}

	static void smethod_6(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}
}
