using System.Drawing;
using System.Windows.Forms;

namespace ns1;

public class LForm : MintForm
{
	public LForm()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		base.ModernFrame = true;
		((Control)this).set_BackColor(FermiColors.Control);
		((Control)this).set_Font(new Font(" ", 9f));
	}

	public override void vmethod_9(FormLayoutCaptionEventArgs formLayoutCaptionEventArgs_0)
	{
		checked
		{
			int num = formLayoutCaptionEventArgs_0.IconBounds.Y - formLayoutCaptionEventArgs_0.FrameSize;
			int num2 = formLayoutCaptionEventArgs_0.IconBounds.X - formLayoutCaptionEventArgs_0.FrameSize;
			Rectangle iconBounds = formLayoutCaptionEventArgs_0.IconBounds;
			iconBounds.Offset(-num2, -num);
			Rectangle textBounds = formLayoutCaptionEventArgs_0.TextBounds;
			textBounds.Y -= num;
			Rectangle closeButtonBounds = formLayoutCaptionEventArgs_0.CloseButtonBounds;
			closeButtonBounds.Width = 35;
			closeButtonBounds.Height = formLayoutCaptionEventArgs_0.Bounds.Height + formLayoutCaptionEventArgs_0.FrameSize;
			closeButtonBounds.Y = unchecked(checked(formLayoutCaptionEventArgs_0.Bounds.Height + formLayoutCaptionEventArgs_0.FrameSize) / 2) - unchecked(closeButtonBounds.Height / 2);
			closeButtonBounds.X = formLayoutCaptionEventArgs_0.Bounds.Right - closeButtonBounds.Width + formLayoutCaptionEventArgs_0.FrameSize;
			Rectangle rectangle = closeButtonBounds;
			rectangle.X -= closeButtonBounds.Width;
			Rectangle minimizeButtonBounds = rectangle;
			minimizeButtonBounds.X -= rectangle.Width;
			formLayoutCaptionEventArgs_0.IconBounds = iconBounds;
			formLayoutCaptionEventArgs_0.TextBounds = textBounds;
			formLayoutCaptionEventArgs_0.CloseButtonBounds = closeButtonBounds;
			formLayoutCaptionEventArgs_0.MaximizeButtonBounds = rectangle;
			formLayoutCaptionEventArgs_0.MinimizeButtonBounds = minimizeButtonBounds;
		}
	}

	public static void smethod_1(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ byte_1[i % byte_1.Length]);
		}
	}

	public override void vmethod_10(FormPaintCaptionEventArgs formPaintCaptionEventArgs_0)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		formPaintCaptionEventArgs_0.Graphics.Clear(FermiColors.Control);
		if (formPaintCaptionEventArgs_0.RenderIcon)
		{
			formPaintCaptionEventArgs_0.Graphics.DrawIcon(base.CaptionIcon, formPaintCaptionEventArgs_0.IconBounds);
		}
		TextRenderer.DrawText((IDeviceContext)(object)formPaintCaptionEventArgs_0.Graphics, ((Control)this).get_Text(), ((Control)this).get_Font(), formPaintCaptionEventArgs_0.TextBounds, FermiColors.ControlText, formPaintCaptionEventArgs_0.TextFormatFlags);
		if (formPaintCaptionEventArgs_0.RenderMinMaxButtons)
		{
			if (((Form)this).get_MaximizeBox())
			{
				switch (formPaintCaptionEventArgs_0.MaximizeButtonMouseState)
				{
				case MouseState.const_1:
					formPaintCaptionEventArgs_0.Graphics.FillRectangle((Brush)(object)FermiBrushes.ControlDark, formPaintCaptionEventArgs_0.MaximizeButtonBounds);
					break;
				case MouseState.const_2:
					formPaintCaptionEventArgs_0.Graphics.FillRectangle((Brush)(object)FermiBrushes.ControlDarkDark, formPaintCaptionEventArgs_0.MaximizeButtonBounds);
					break;
				}
			}
			WindowGlyph windowGlyph_ = WindowGlyph.const_1;
			if ((int)((Form)this).get_WindowState() == 2)
			{
				windowGlyph_ = WindowGlyph.const_2;
			}
			Rectangle maximizeButtonBounds = formPaintCaptionEventArgs_0.MaximizeButtonBounds;
			maximizeButtonBounds.Inflate(-9, -9);
			if (!((Form)this).get_MaximizeBox())
			{
				GlyphRenderer.smethod_4(formPaintCaptionEventArgs_0.Graphics, maximizeButtonBounds, windowGlyph_, FermiColors.ControlDarkDark);
			}
			else
			{
				GlyphRenderer.smethod_4(formPaintCaptionEventArgs_0.Graphics, maximizeButtonBounds, windowGlyph_, FermiColors.ControlText);
			}
			if (((Form)this).get_MinimizeBox())
			{
				switch (formPaintCaptionEventArgs_0.MinimizeButtonMouseState)
				{
				case MouseState.const_1:
					formPaintCaptionEventArgs_0.Graphics.FillRectangle((Brush)(object)FermiBrushes.ControlDark, formPaintCaptionEventArgs_0.MinimizeButtonBounds);
					break;
				case MouseState.const_2:
					formPaintCaptionEventArgs_0.Graphics.FillRectangle((Brush)(object)FermiBrushes.ControlDarkDark, formPaintCaptionEventArgs_0.MinimizeButtonBounds);
					break;
				}
			}
			Rectangle minimizeButtonBounds = formPaintCaptionEventArgs_0.MinimizeButtonBounds;
			minimizeButtonBounds.Inflate(-9, -9);
			if (!((Form)this).get_MinimizeBox())
			{
				GlyphRenderer.smethod_4(formPaintCaptionEventArgs_0.Graphics, minimizeButtonBounds, WindowGlyph.const_0, FermiColors.ControlDarkDark);
			}
			else if (formPaintCaptionEventArgs_0.MinimizeButtonMouseState != 0)
			{
				GlyphRenderer.smethod_4(formPaintCaptionEventArgs_0.Graphics, minimizeButtonBounds, WindowGlyph.const_0, FermiColors.ControlText);
			}
			else
			{
				GlyphRenderer.smethod_4(formPaintCaptionEventArgs_0.Graphics, minimizeButtonBounds, WindowGlyph.const_0, FermiColors.ControlText);
			}
		}
		if (formPaintCaptionEventArgs_0.RenderCloseButton)
		{
			switch (formPaintCaptionEventArgs_0.CloseButtonMouseState)
			{
			case MouseState.const_1:
				formPaintCaptionEventArgs_0.Graphics.FillRectangle((Brush)(object)FermiBrushes.WindowClose, formPaintCaptionEventArgs_0.CloseButtonBounds);
				break;
			case MouseState.const_2:
				formPaintCaptionEventArgs_0.Graphics.FillRectangle((Brush)(object)FermiBrushes.WindowCloseLight, formPaintCaptionEventArgs_0.CloseButtonBounds);
				break;
			}
			Rectangle closeButtonBounds = formPaintCaptionEventArgs_0.CloseButtonBounds;
			closeButtonBounds.Inflate(-9, -9);
			if (formPaintCaptionEventArgs_0.CloseButtonMouseState != 0)
			{
				GlyphRenderer.smethod_4(formPaintCaptionEventArgs_0.Graphics, closeButtonBounds, WindowGlyph.const_3, FermiColors.ControlLightLight);
			}
			else
			{
				GlyphRenderer.smethod_4(formPaintCaptionEventArgs_0.Graphics, closeButtonBounds, WindowGlyph.const_3, FermiColors.ControlText);
			}
		}
		if ((int)((Form)this).get_WindowState() == 0)
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			Rectangle rectangle2 = rectangle;
			rectangle2.Inflate(-1, -1);
			ControlPaint.DrawBorder(formPaintCaptionEventArgs_0.Graphics, rectangle, FermiColors.WindowFrame, (ButtonBorderStyle)3);
			ControlPaint.DrawBorder(formPaintCaptionEventArgs_0.Graphics, rectangle2, FermiColors.ControlDarkDark, (ButtonBorderStyle)3);
		}
	}

	public override void vmethod_11(FormPaintFrameEventArgs formPaintFrameEventArgs_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		formPaintFrameEventArgs_0.Graphics.Clear(FermiColors.Control);
		if ((int)((Form)this).get_WindowState() == 0)
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			Rectangle rectangle2 = rectangle;
			rectangle2.Inflate(-1, -1);
			ControlPaint.DrawBorder(formPaintFrameEventArgs_0.Graphics, rectangle, FermiColors.WindowFrame, (ButtonBorderStyle)3);
			ControlPaint.DrawBorder(formPaintFrameEventArgs_0.Graphics, rectangle2, FermiColors.ControlDarkDark, (ButtonBorderStyle)3);
		}
	}
}
