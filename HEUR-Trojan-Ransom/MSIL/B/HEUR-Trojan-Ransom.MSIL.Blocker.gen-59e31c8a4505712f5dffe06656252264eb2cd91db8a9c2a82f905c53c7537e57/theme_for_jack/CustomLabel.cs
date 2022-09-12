using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using fJpF6sGRwSPY0tjIER;
using zjWSh2Z73jBs4TcJ0x;

namespace theme_for_jack;

public class CustomLabel : Label
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Color OLilYHptvK;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private float x89l35jZPO;

	internal static CustomLabel vwmCJo7Uw8uLbt4A2Wu;

	public Color OutlineForeColor
	{
		[CompilerGenerated]
		get
		{
			return OLilYHptvK;
		}
		[CompilerGenerated]
		set
		{
			while (true)
			{
				OLilYHptvK = value;
				if (fnU4wD7kgXq6M39p9MK() == null)
				{
					switch (0)
					{
					case 1:
						break;
					default:
						return;
					case 0:
						return;
					}
					continue;
				}
				break;
			}
		}
	}

	public float OutlineWidth
	{
		[CompilerGenerated]
		get
		{
			return x89l35jZPO;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				x89l35jZPO = value;
				int num2 = 0;
				if (!ly6Mm97KQkhnowKSL5k())
				{
					num2 = num;
				}
				switch (num2)
				{
				case 1:
					break;
				default:
					return;
				case 0:
					return;
				}
			}
		}
	}

	public CustomLabel()
	{
		XaXlykERDhtdRwMnBY.jXRWMU6APG();
		TyUFOm7bmujNhINrOAf();
		((Label)this)._002Ector();
		OutlineForeColor = obvmxp7uXlkkgA3YAeI();
		OutlineWidth = 2f;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected I4, but got Unknown
		int num = 1;
		int num4 = default(int);
		GraphicsPath val5 = default(GraphicsPath);
		int num6 = default(int);
		int num8 = default(int);
		int num12 = default(int);
		while (true)
		{
			((Graphics)m4yN6H7zmts5TLxWSdQ(e)).FillRectangle((Brush)new SolidBrush(H3ajq1XFobHKhKw8w2O(this)), tU9KrqXBn3kksMZ0MLd(this));
			int num2 = 0;
			if (!ly6Mm97KQkhnowKSL5k())
			{
				goto IL_000b;
			}
			goto IL_0023;
			IL_0023:
			switch (num2)
			{
			case 1:
				continue;
			case 2:
				try
				{
					Pen val = new Pen(OutlineForeColor, OutlineWidth);
					val.set_LineJoin((LineJoin)2);
					Pen val2 = val;
					if (fnU4wD7kgXq6M39p9MK() != null)
					{
						switch (0)
						{
						case 1:
							return;
						}
					}
					try
					{
						StringFormat val3 = new StringFormat();
						if (ly6Mm97KQkhnowKSL5k())
						{
							switch (0)
							{
							case 1:
								return;
							}
						}
						try
						{
							Brush val4 = (Brush)new SolidBrush(gx4WhDXWo498mrDHLk9(this));
							int num3 = 0;
							if (!ly6Mm97KQkhnowKSL5k())
							{
								num3 = num4;
							}
							switch (num3)
							{
							case 1:
								return;
							}
							try
							{
								DHhfyBXIRaqjBovodDh(val5, ttPrmvXrZMEsqHj9yT7(this), wH49bAXj6n5R2JQSQoY(hrEAhKXhoQcpDBrgoSy(this)), (int)((Font)hrEAhKXhoQcpDBrgoSy(this)).get_Style(), j8iXFJXOMOJkopgU2vp(hrEAhKXhoQcpDBrgoSy(this)), ((Control)this).get_ClientRectangle(), val3);
								int num5 = 0;
								if (ly6Mm97KQkhnowKSL5k())
								{
									goto IL_0162;
								}
								goto IL_0186;
								IL_0186:
								switch (num5)
								{
								case 3:
									break;
								case 1:
									goto IL_0154;
								default:
									goto IL_0162;
								case 2:
									bgYWDIXM6cUj8WEPHyJ(m4yN6H7zmts5TLxWSdQ(e), val4, val5);
									num6 = 4;
									return;
								case 4:
									return;
								}
								goto IL_0132;
								IL_0132:
								oJZF03XXxwKd4ZSkEcr(m4yN6H7zmts5TLxWSdQ(e), val2, val5);
								num5 = 2;
								if (!ly6Mm97KQkhnowKSL5k())
								{
									num5 = num6;
								}
								goto IL_0186;
								IL_0162:
								B9c6OLX7x7XGrpW3eAD(m4yN6H7zmts5TLxWSdQ(e), 1.3f, 1.35f);
								num5 = 1;
								if (!ly6Mm97KQkhnowKSL5k())
								{
									goto IL_0154;
								}
								goto IL_0186;
								IL_0154:
								((Graphics)m4yN6H7zmts5TLxWSdQ(e)).set_SmoothingMode((SmoothingMode)2);
								goto IL_0132;
							}
							finally
							{
								int num7;
								if (val4 == null)
								{
									num7 = 1;
									if (ly6Mm97KQkhnowKSL5k())
									{
										goto IL_01ce;
									}
								}
								goto IL_01df;
								IL_01ce:
								switch (num7)
								{
								case 1:
								case 2:
									goto end_IL_01bb;
								}
								goto IL_01df;
								IL_01df:
								u89lvJXtEMKEuHjx2ft(val4);
								num7 = 2;
								if (fnU4wD7kgXq6M39p9MK() != null)
								{
									num7 = num8;
								}
								goto IL_01ce;
								end_IL_01bb:;
							}
						}
						finally
						{
							int num9;
							if (val3 != null)
							{
								num9 = 0;
								if (fnU4wD7kgXq6M39p9MK() == null)
								{
									goto IL_020d;
								}
								goto IL_0220;
							}
							goto end_IL_01fc;
							IL_020d:
							u89lvJXtEMKEuHjx2ft(val3);
							num9 = 1;
							if (fnU4wD7kgXq6M39p9MK() != null)
							{
								goto IL_0220;
							}
							goto end_IL_01fc;
							IL_0220:
							switch (num9)
							{
							case 1:
								goto end_IL_01fc;
							}
							goto IL_020d;
							end_IL_01fc:;
						}
					}
					finally
					{
						int num10;
						if (val2 != null)
						{
							num10 = 0;
							if (fnU4wD7kgXq6M39p9MK() == null)
							{
								goto IL_0244;
							}
							goto IL_0257;
						}
						goto end_IL_0233;
						IL_0244:
						u89lvJXtEMKEuHjx2ft(val2);
						num10 = 0;
						if (!ly6Mm97KQkhnowKSL5k())
						{
							goto IL_0257;
						}
						goto end_IL_0233;
						IL_0257:
						switch (num10)
						{
						case 1:
							break;
						default:
							goto end_IL_0233;
						case 0:
							goto end_IL_0233;
						}
						goto IL_0244;
						end_IL_0233:;
					}
				}
				finally
				{
					int num11;
					if (val5 != null)
					{
						num11 = 0;
						if (fnU4wD7kgXq6M39p9MK() != null)
						{
							goto IL_0291;
						}
						goto IL_0295;
					}
					goto end_IL_026a;
					IL_0291:
					num11 = num12;
					goto IL_0295;
					IL_0295:
					while (true)
					{
						switch (num11)
						{
						case 1:
							goto end_IL_0295;
						}
						u89lvJXtEMKEuHjx2ft(val5);
						num11 = 1;
						if (ly6Mm97KQkhnowKSL5k())
						{
							continue;
						}
						goto IL_0291;
						continue;
						end_IL_0295:
						break;
					}
					end_IL_026a:;
				}
			case 3:
				return;
			}
			goto IL_000b;
			IL_000b:
			val5 = new GraphicsPath();
			num2 = 2;
			if (!ly6Mm97KQkhnowKSL5k())
			{
				num2 = num;
			}
			goto IL_0023;
		}
	}

	internal static void TyUFOm7bmujNhINrOAf()
	{
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
	}

	internal static Color obvmxp7uXlkkgA3YAeI()
	{
		return Color.Green;
	}

	internal static bool ly6Mm97KQkhnowKSL5k()
	{
		return vwmCJo7Uw8uLbt4A2Wu == null;
	}

	internal static CustomLabel fnU4wD7kgXq6M39p9MK()
	{
		return vwmCJo7Uw8uLbt4A2Wu;
	}

	internal static object m4yN6H7zmts5TLxWSdQ(object object_0)
	{
		return ((PaintEventArgs)object_0).get_Graphics();
	}

	internal static Color H3ajq1XFobHKhKw8w2O(object object_0)
	{
		return ((Control)object_0).get_BackColor();
	}

	internal static Rectangle tU9KrqXBn3kksMZ0MLd(object object_0)
	{
		return ((Control)object_0).get_ClientRectangle();
	}

	internal static Color gx4WhDXWo498mrDHLk9(object object_0)
	{
		return ((Control)object_0).get_ForeColor();
	}

	internal static object ttPrmvXrZMEsqHj9yT7(object object_0)
	{
		return ((Control)object_0).get_Text();
	}

	internal static object hrEAhKXhoQcpDBrgoSy(object object_0)
	{
		return ((Control)object_0).get_Font();
	}

	internal static object wH49bAXj6n5R2JQSQoY(object object_0)
	{
		return ((Font)object_0).get_FontFamily();
	}

	internal static float j8iXFJXOMOJkopgU2vp(object object_0)
	{
		return ((Font)object_0).get_Size();
	}

	internal static void DHhfyBXIRaqjBovodDh(object object_0, object object_1, object object_2, int int_0, float float_0, Rectangle rectangle_0, object object_3)
	{
		((GraphicsPath)object_0).AddString((string)object_1, (FontFamily)object_2, int_0, float_0, rectangle_0, (StringFormat)object_3);
	}

	internal static void B9c6OLX7x7XGrpW3eAD(object object_0, float float_0, float float_1)
	{
		((Graphics)object_0).ScaleTransform(float_0, float_1);
	}

	internal static void oJZF03XXxwKd4ZSkEcr(object object_0, object object_1, object object_2)
	{
		((Graphics)object_0).DrawPath((Pen)object_1, (GraphicsPath)object_2);
	}

	internal static void bgYWDIXM6cUj8WEPHyJ(object object_0, object object_1, object object_2)
	{
		((Graphics)object_0).FillPath((Brush)object_1, (GraphicsPath)object_2);
	}

	internal static void u89lvJXtEMKEuHjx2ft(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}
}
