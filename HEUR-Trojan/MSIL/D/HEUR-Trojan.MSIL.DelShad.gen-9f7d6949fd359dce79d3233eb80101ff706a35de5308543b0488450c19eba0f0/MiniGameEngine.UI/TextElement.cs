using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using MiniGameEngine.Transitions;

namespace MiniGameEngine.UI;

public class TextElement : GameObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private HorizontalAlignment horizontalAlignment_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private VerticalAlignment verticalAlignment_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Font font_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Color color_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Color color_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Color color_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_2;

	private TransitionProperty transitionProperty_2;

	private TransitionProperty transitionProperty_3;

	private TransitionProperty transitionProperty_4;

	private TransitionProperty transitionProperty_5;

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public HorizontalAlignment HorizontalAlignment
	{
		[CompilerGenerated]
		get
		{
			return horizontalAlignment_0;
		}
		[CompilerGenerated]
		set
		{
			horizontalAlignment_0 = value;
		}
	}

	public VerticalAlignment VerticalAlignment
	{
		[CompilerGenerated]
		get
		{
			return verticalAlignment_0;
		}
		[CompilerGenerated]
		set
		{
			verticalAlignment_0 = value;
		}
	}

	public Font Font
	{
		[CompilerGenerated]
		get
		{
			return font_0;
		}
		[CompilerGenerated]
		set
		{
			font_0 = value;
		}
	}

	public Color Color
	{
		[CompilerGenerated]
		get
		{
			return color_0;
		}
		[CompilerGenerated]
		set
		{
			color_0 = value;
		}
	}

	public Color Background
	{
		[CompilerGenerated]
		get
		{
			return color_1;
		}
		[CompilerGenerated]
		set
		{
			color_1 = value;
		}
	}

	public Color BorderColor
	{
		[CompilerGenerated]
		get
		{
			return color_2;
		}
		[CompilerGenerated]
		set
		{
			color_2 = value;
		}
	}

	public int BorderWidth
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public TransitionProperty ColorProperty => transitionProperty_2;

	public TransitionProperty BackgroundProperty => transitionProperty_3;

	public TransitionProperty BorderColorProperty => transitionProperty_4;

	public TransitionProperty BorderWidthProperty => transitionProperty_5;

	public TextElement(string Text)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		this.Text = "";
		HorizontalAlignment = HorizontalAlignment.Left;
		VerticalAlignment = VerticalAlignment.Top;
		Font = new Font("consolas", 15f);
		Color = Color.Black;
		Background = Color.Transparent;
		BorderColor = Color.Transparent;
		BorderWidth = 0;
		GameObject Reference = this;
		transitionProperty_2 = new TransitionProperty(ref Reference, delegate(ref Transition a0)
		{
			ColorTransition Transition4 = (ColorTransition)a0;
			_Lambda_0024__44_002D0(ref Transition4);
			a0 = Transition4;
		});
		Reference = this;
		transitionProperty_3 = new TransitionProperty(ref Reference, delegate(ref Transition a0)
		{
			ColorTransition Transition3 = (ColorTransition)a0;
			_Lambda_0024__44_002D1(ref Transition3);
			a0 = Transition3;
		});
		Reference = this;
		transitionProperty_4 = new TransitionProperty(ref Reference, delegate(ref Transition a0)
		{
			ColorTransition Transition2 = (ColorTransition)a0;
			_Lambda_0024__44_002D2(ref Transition2);
			a0 = Transition2;
		});
		Reference = this;
		transitionProperty_5 = new TransitionProperty(ref Reference, delegate(ref Transition a0)
		{
			DoubleTransition Transition = (DoubleTransition)a0;
			_Lambda_0024__44_002D3(ref Transition);
			a0 = Transition;
		});
		this.Text = Text;
	}

	public override void Render(Graphics Graphics)
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		string[] array = Text.Split(new char[1] { Conversions.ToChar(Environment.NewLine) });
		int num = 0;
		int num2 = 0;
		string[] array2 = array;
		checked
		{
			foreach (string text in array2)
			{
				SizeF sizeF = Graphics.MeasureString(text, Font);
				num = (int)Math.Round((float)num + sizeF.Height);
				if (sizeF.Width > (float)num2)
				{
					num2 = (int)Math.Round(sizeF.Width);
				}
			}
			Size size = new Size(num2, num);
			double[] array3 = new double[3] { 0.0, -0.5, -1.0 };
			double[] array4 = new double[3] { 0.0, -0.5, -1.0 };
			Point point = new Point((int)Math.Round((double)base.Position.X + Math.Round((double)size.Width * array3[unchecked((int)HorizontalAlignment)], 1)), (int)Math.Round((double)base.Position.Y + Math.Round((double)size.Height * array4[unchecked((int)VerticalAlignment)], 1)));
			Graphics.DrawRectangle(new Pen(BorderColor, (float)BorderWidth), new Rectangle(point, size));
			Graphics.FillRectangle((Brush)new SolidBrush(Background), new Rectangle(point, size));
			string[] array5 = array;
			foreach (string text2 in array5)
			{
				Graphics.DrawString(text2, Font, (Brush)new SolidBrush(Color), (PointF)point);
				int num3 = (int)Math.Round(Graphics.MeasureString(text2, Font).Height);
				point.Y += num3;
			}
		}
	}

	public override void Update(double delta)
	{
	}
}
