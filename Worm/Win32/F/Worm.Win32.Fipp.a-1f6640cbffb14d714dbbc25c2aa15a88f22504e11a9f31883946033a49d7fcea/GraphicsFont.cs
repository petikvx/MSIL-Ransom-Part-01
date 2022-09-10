using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class GraphicsFont
{
	[Flags]
	public enum RenderFlags
	{
		Centered = 1,
		TwoSided = 2,
		Filtered = 4
	}

	public const int MaxNumfontVertices = 300;

	private Font systemFont;

	private bool isZEnable;

	private string ourFontName;

	private int ourFontHeight;

	private Device device;

	private TextureState textureState0;

	private TextureState textureState1;

	private Sampler samplerState0;

	private RenderStates renderState;

	private Texture fontTexture;

	private VertexBuffer vertexBuffer;

	private TransformedColoredTextured[] fontVertices;

	private int textureWidth;

	private int textureHeight;

	private float textureScale;

	private int spacingChar;

	private float[,] textureCoords;

	private StateBlock savedStateBlock;

	private StateBlock drawTextStateBlock;

	public bool ZBufferEnable
	{
		get
		{
			return isZEnable;
		}
		set
		{
			isZEnable = value;
		}
	}

	public GraphicsFont(Font f)
	{
		isZEnable = false;
		fontVertices = (TransformedColoredTextured[])(object)new TransformedColoredTextured[300];
		textureCoords = new float[97, 5];
		ourFontName = f.get_Name();
		ourFontHeight = (int)Math.Round(f.get_Size());
		systemFont = f;
	}

	public GraphicsFont(string strFontName)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		isZEnable = false;
		fontVertices = (TransformedColoredTextured[])(object)new TransformedColoredTextured[300];
		textureCoords = new float[97, 5];
		ourFontName = strFontName;
		ourFontHeight = 12;
		systemFont = new Font(ourFontName, (float)ourFontHeight);
	}

	public GraphicsFont(string strFontName, FontStyle Style)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		isZEnable = false;
		fontVertices = (TransformedColoredTextured[])(object)new TransformedColoredTextured[300];
		textureCoords = new float[97, 5];
		ourFontName = strFontName;
		ourFontHeight = 12;
		systemFont = new Font(ourFontName, (float)ourFontHeight, Style);
	}

	public GraphicsFont(string strFontName, FontStyle Style, int size)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		isZEnable = false;
		fontVertices = (TransformedColoredTextured[])(object)new TransformedColoredTextured[300];
		textureCoords = new float[97, 5];
		ourFontName = strFontName;
		ourFontHeight = size;
		systemFont = new Font(ourFontName, (float)ourFontHeight, Style);
	}

	public void PaintAlphabet(Graphics g, bool measureOnly)
	{
		string text = "";
		float num = 0f;
		float num2 = 0f;
		PointF pointF = new PointF(0f, 0f);
		Size size = new Size(0, 0);
		size = g.MeasureString(" ", systemFont).ToSize();
		num = (int)((((double)spacingChar == Math.Ceiling((double)size.Height * 0.3)) ? 1u : 0u) << 31) >> 31;
		byte b = 32;
		while (true)
		{
			text = Strings.Chr((int)b).ToString();
			Size size2 = g.MeasureString(text, systemFont).ToSize();
			size.Height = size2.Height;
			if (StringType.StrCmp(StringType.FromChar(Strings.Chr((int)b)), " ", false) == 0)
			{
				size.Width = size2.Width;
			}
			else
			{
				size.Width = g.MeasureString(text, systemFont, pointF, StringFormat.get_GenericTypographic()).ToSize().Width;
			}
			if (num + (float)size.Width + 1f > (float)textureWidth)
			{
				num = 0f;
				num2 += (float)size.Height;
			}
			if (!(num2 + (float)size.Height <= (float)textureHeight))
			{
				break;
			}
			if (!measureOnly)
			{
				if (StringType.StrCmp(StringType.FromChar(Strings.Chr((int)b)), " ", false) != 0)
				{
					string text2 = text;
					Font obj = systemFont;
					Brush white = Brushes.get_White();
					PointF pointF2 = new PointF((int)Math.Round(num), (int)Math.Round(num2));
					g.DrawString(text2, obj, white, pointF2, StringFormat.get_GenericTypographic());
				}
				else
				{
					string text3 = text;
					Font obj2 = systemFont;
					Brush white2 = Brushes.get_White();
					PointF pointF2 = new PointF((int)Math.Round(num), (int)Math.Round(num2));
					g.DrawString(text3, obj2, white2, pointF2);
				}
				textureCoords[b - 32, 0] = num / (float)textureWidth;
				textureCoords[b - 32, 1] = num2 / (float)textureHeight;
				textureCoords[b - 32, 2] = (num + (float)size.Width) / (float)textureWidth;
				textureCoords[b - 32, 3] = (num2 + (float)size.Height) / (float)textureHeight;
			}
			num += (float)(size.Width + 1);
			b = (byte)(b + 1);
			if (b > 126)
			{
				return;
			}
		}
		throw new InvalidOperationException("Texture too small for alphabet");
	}

	public void InitializeDeviceObjects(Device dev)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		if (dev != null)
		{
			dev.add_DeviceReset((EventHandler)RestoreDeviceObjects);
		}
		device = dev;
		textureState0 = device.get_TextureState().get_TextureState(0);
		textureState1 = device.get_TextureState().get_TextureState(1);
		samplerState0 = device.get_SamplerState().get_SamplerState(0);
		renderState = device.get_RenderState();
		Bitmap val = new Bitmap(1, 1, (PixelFormat)2498570);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)4);
		val2.set_TextRenderingHint((TextRenderingHint)4);
		val2.set_TextContrast(0);
		textureScale = 1f;
		textureWidth = 128;
		textureHeight = 128;
		while (true)
		{
			try
			{
				PaintAlphabet(val2, measureOnly: true);
			}
			catch (InvalidOperationException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				_ = ex;
				textureWidth *= 2;
				textureHeight *= 2;
				ProjectData.ClearProjectError();
				continue;
			}
			break;
		}
		Caps deviceCaps = device.get_DeviceCaps();
		if (textureWidth > ((Caps)(ref deviceCaps)).get_MaxTextureWidth())
		{
			textureScale = (float)((Caps)(ref deviceCaps)).get_MaxTextureWidth() / (float)textureWidth;
			textureWidth = ((Caps)(ref deviceCaps)).get_MaxTextureWidth();
			textureHeight = ((Caps)(ref deviceCaps)).get_MaxTextureWidth();
			while (true)
			{
				ourFontHeight = (int)Math.Round(Math.Floor((float)ourFontHeight * textureScale));
				systemFont = new Font(systemFont.get_Name(), (float)ourFontHeight, systemFont.get_Style());
				try
				{
					PaintAlphabet(val2, measureOnly: true);
				}
				catch (InvalidOperationException ex2)
				{
					ProjectData.SetProjectError((Exception)ex2);
					_ = ex2;
					textureScale *= 0.9f;
					ProjectData.ClearProjectError();
					continue;
				}
				break;
			}
		}
		((Image)val).Dispose();
		val = new Bitmap(textureWidth, textureHeight, (PixelFormat)2498570);
		val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)4);
		val2.set_TextRenderingHint((TextRenderingHint)4);
		val2.set_TextContrast(0);
		PaintAlphabet(val2, measureOnly: false);
		fontTexture = Texture.FromBitmap(device, val, (Usage)0, (Pool)1);
		RestoreDeviceObjects(null, null);
	}

	public void DrawText(float sx, float sy, Color color, string strText)
	{
		DrawText(sx, sy, color, strText, RenderFlags.Filtered);
	}

	public void RestoreDeviceObjects(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		vertexBuffer = new VertexBuffer(typeof(TransformedColoredTextured), 300, device, (Usage)520, (VertexFormats)0, (Pool)0);
		Surface renderTarget = device.GetRenderTarget(0);
		Caps deviceCaps = device.get_DeviceCaps();
		int adapterOrdinal = ((Caps)(ref deviceCaps)).get_AdapterOrdinal();
		Caps deviceCaps2 = device.get_DeviceCaps();
		DeviceType deviceType = ((Caps)(ref deviceCaps2)).get_DeviceType();
		DisplayMode displayMode = device.get_DisplayMode();
		Format format = ((DisplayMode)(ref displayMode)).get_Format();
		SurfaceDescription description = renderTarget.get_Description();
		bool flag = Manager.CheckDeviceFormat(adapterOrdinal, deviceType, format, (Usage)524289, (ResourceType)1, ((SurfaceDescription)(ref description)).get_Format());
		int num = 0;
		do
		{
			device.BeginStateBlock();
			device.SetTexture(0, (BaseTexture)(object)fontTexture);
			if (!isZEnable)
			{
				renderState.set_ZBufferEnable(false);
			}
			else
			{
				renderState.set_ZBufferEnable(true);
			}
			if (flag)
			{
				renderState.set_AlphaBlendEnable(true);
				renderState.set_SourceBlend((Blend)5);
				renderState.set_DestinationBlend((Blend)6);
			}
			else
			{
				renderState.set_AlphaBlendEnable(false);
			}
			renderState.set_AlphaTestEnable(true);
			renderState.set_ReferenceAlpha(8);
			renderState.set_AlphaFunction((Compare)7);
			renderState.set_FillMode((FillMode)3);
			renderState.set_CullMode((Cull)3);
			renderState.set_StencilEnable(false);
			renderState.set_Clipping(true);
			device.get_ClipPlanes().DisableAll();
			renderState.set_VertexBlend((VertexBlend)0);
			renderState.set_IndexedVertexBlendEnable(false);
			renderState.set_FogEnable(false);
			renderState.set_ColorWriteEnable((ColorWriteEnable)15);
			textureState0.set_ColorOperation((TextureOperation)4);
			textureState0.set_ColorArgument1((TextureArgument)2);
			textureState0.set_ColorArgument2((TextureArgument)0);
			textureState0.set_AlphaOperation((TextureOperation)4);
			textureState0.set_AlphaArgument1((TextureArgument)2);
			textureState0.set_AlphaArgument2((TextureArgument)0);
			textureState0.set_TextureCoordinateIndex(0);
			textureState0.set_TextureTransform((TextureTransform)0);
			textureState1.set_ColorOperation((TextureOperation)1);
			textureState1.set_AlphaOperation((TextureOperation)1);
			samplerState0.set_MinFilter((TextureFilter)1);
			samplerState0.set_MagFilter((TextureFilter)1);
			samplerState0.set_MipFilter((TextureFilter)0);
			if (num == 0)
			{
				savedStateBlock = device.EndStateBlock();
			}
			else
			{
				drawTextStateBlock = device.EndStateBlock();
			}
			num++;
		}
		while (num <= 1);
	}

	public void DrawText(float sx, float sy, Color color, string strText, RenderFlags flags)
	{
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		if (strText == null)
		{
			return;
		}
		savedStateBlock.Capture();
		drawTextStateBlock.Apply();
		device.SetTexture(0, (BaseTexture)(object)fontTexture);
		device.set_VertexFormat((VertexFormats)324);
		device.set_PixelShader((PixelShader)null);
		device.SetStreamSource(0, vertexBuffer, 0);
		if ((flags & RenderFlags.Filtered) != 0)
		{
			samplerState0.set_MinFilter((TextureFilter)2);
			samplerState0.set_MagFilter((TextureFilter)2);
		}
		float num = sx;
		int num2 = 0;
		CharEnumerator enumerator = strText.GetEnumerator();
		Vector4 val = default(Vector4);
		TransformedColoredTextured val2 = default(TransformedColoredTextured);
		int num10 = default(int);
		while (enumerator.MoveNext())
		{
			char current = enumerator.Current;
			if (current == '\n')
			{
				sx = num;
				sy += (textureCoords[0, 3] - textureCoords[0, 1]) * (float)textureHeight;
			}
			if ((Strings.Asc(current) - 32 < 0) | (Strings.Asc(current) - 32 >= 96))
			{
				continue;
			}
			float num3 = textureCoords[Strings.Asc(current) - 32, 0];
			float num4 = textureCoords[Strings.Asc(current) - 32, 1];
			float num5 = textureCoords[Strings.Asc(current) - 32, 2];
			float num6 = textureCoords[Strings.Asc(current) - 32, 3];
			float num7 = (num5 - num3) * (float)textureWidth / textureScale;
			float num8 = (num6 - num4) * (float)textureHeight / textureScale;
			int num9 = color.ToArgb();
			if (current != ' ')
			{
				ref TransformedColoredTextured reference = ref fontVertices[num10];
				((Vector4)(ref val))._002Ector(sx + 0f - 0.5f, sy + num8 - 0.5f, 0.9f, 1f);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num9, num3, num6);
				reference = val2;
				num10++;
				ref TransformedColoredTextured reference2 = ref fontVertices[num10];
				((Vector4)(ref val))._002Ector(sx + 0f - 0.5f, sy + 0f - 0.5f, 0.9f, 1f);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num9, num3, num4);
				reference2 = val2;
				num10++;
				ref TransformedColoredTextured reference3 = ref fontVertices[num10];
				((Vector4)(ref val))._002Ector(sx + num7 - 0.5f, sy + num8 - 0.5f, 0.9f, 1f);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num9, num5, num6);
				reference3 = val2;
				num10++;
				ref TransformedColoredTextured reference4 = ref fontVertices[num10];
				((Vector4)(ref val))._002Ector(sx + num7 - 0.5f, sy + 0f - 0.5f, 0.9f, 1f);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num9, num5, num4);
				reference4 = val2;
				num10++;
				ref TransformedColoredTextured reference5 = ref fontVertices[num10];
				((Vector4)(ref val))._002Ector(sx + num7 - 0.5f, sy + num8 - 0.5f, 0.9f, 1f);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num9, num5, num6);
				reference5 = val2;
				num10++;
				ref TransformedColoredTextured reference6 = ref fontVertices[num10];
				((Vector4)(ref val))._002Ector(sx + 0f - 0.5f, sy + 0f - 0.5f, 0.9f, 1f);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num9, num3, num4);
				reference6 = val2;
				num10++;
				num2 += 2;
				if (num2 * 3 > 294)
				{
					vertexBuffer.SetData((object)fontVertices, 0, (LockFlags)8192);
					device.DrawPrimitives((PrimitiveType)4, 0, num2);
					num2 = 0;
					num10 = 0;
				}
			}
			sx += num7;
		}
		vertexBuffer.SetData((object)fontVertices, 0, (LockFlags)8192);
		if (num2 > 0)
		{
			device.DrawPrimitives((PrimitiveType)4, 0, num2);
		}
		savedStateBlock.Apply();
	}

	public void DrawTextScaled(float x, float y, float z, float fXScale, float fYScale, Color color, string text, RenderFlags flags)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		if (device == null)
		{
			throw new ArgumentNullException();
		}
		savedStateBlock.Capture();
		drawTextStateBlock.Apply();
		device.set_VertexFormat((VertexFormats)324);
		device.set_PixelShader((PixelShader)null);
		device.SetStreamSource(0, vertexBuffer, 0);
		if ((flags & RenderFlags.Filtered) != 0)
		{
			samplerState0.set_MinFilter((TextureFilter)2);
			samplerState0.set_MagFilter((TextureFilter)2);
		}
		Viewport viewport = device.get_Viewport();
		float num = (x + 1f) * (float)((Viewport)(ref viewport)).get_Width() / 2f;
		float num2 = (y + 1f) * (float)((Viewport)(ref viewport)).get_Height() / 2f;
		float num3 = 1f;
		float num4 = (textureCoords[0, 3] - textureCoords[0, 1]) * (float)textureHeight;
		num -= (float)spacingChar * (fXScale * (float)((Viewport)(ref viewport)).get_Height()) / num4;
		float num5 = num;
		int num6 = 0;
		int num7 = color.ToArgb();
		int num8 = 0;
		CharEnumerator enumerator = text.GetEnumerator();
		Vector4 val = default(Vector4);
		TransformedColoredTextured val2 = default(TransformedColoredTextured);
		while (enumerator.MoveNext())
		{
			char current = enumerator.Current;
			if (current == '\n')
			{
				num = num5;
				num2 += fYScale * (float)((Viewport)(ref viewport)).get_Height();
			}
			if ((Strings.Asc(current) - 32 < 0) | (Strings.Asc(current) - 32 >= 96))
			{
				continue;
			}
			float num9 = textureCoords[Strings.Asc(current) - 32, 0];
			float num10 = textureCoords[Strings.Asc(current) - 32, 1];
			float num11 = textureCoords[Strings.Asc(current) - 32, 2];
			float num12 = textureCoords[Strings.Asc(current) - 32, 3];
			float num13 = (num11 - num9) * (float)textureWidth;
			float num14 = (num12 - num10) * (float)textureHeight;
			num13 *= fXScale * (float)((Viewport)(ref viewport)).get_Height() / num4;
			num14 *= fYScale * (float)((Viewport)(ref viewport)).get_Height() / num4;
			if (current != ' ')
			{
				ref TransformedColoredTextured reference = ref fontVertices[num8];
				((Vector4)(ref val))._002Ector(num + 0f - 0.5f, num2 + num14 - 0.5f, z, num3);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num7, num9, num12);
				reference = val2;
				num8++;
				ref TransformedColoredTextured reference2 = ref fontVertices[num8];
				((Vector4)(ref val))._002Ector(num + 0f - 0.5f, num2 + 0f - 0.5f, z, num3);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num7, num9, num10);
				reference2 = val2;
				num8++;
				ref TransformedColoredTextured reference3 = ref fontVertices[num8];
				((Vector4)(ref val))._002Ector(num + num13 - 0.5f, num2 + num14 - 0.5f, z, num3);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num7, num11, num12);
				reference3 = val2;
				num8++;
				ref TransformedColoredTextured reference4 = ref fontVertices[num8];
				((Vector4)(ref val))._002Ector(num + num13 - 0.5f, num2 + 0f - 0.5f, z, num3);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num7, num11, num10);
				reference4 = val2;
				num8++;
				ref TransformedColoredTextured reference5 = ref fontVertices[num8];
				((Vector4)(ref val))._002Ector(num + num13 - 0.5f, num2 + num14 - 0.5f, z, num3);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num7, num11, num12);
				reference5 = val2;
				num8++;
				ref TransformedColoredTextured reference6 = ref fontVertices[num8];
				((Vector4)(ref val))._002Ector(num + 0f - 0.5f, num2 + 0f - 0.5f, z, num3);
				((TransformedColoredTextured)(ref val2))._002Ector(val, num7, num9, num10);
				reference6 = val2;
				num8++;
				num6 += 2;
				if (num6 * 3 > 294)
				{
					vertexBuffer.SetData((object)fontVertices, 0, (LockFlags)8192);
					device.DrawPrimitives((PrimitiveType)4, 0, num6);
					num6 = 0;
					num8 = 0;
				}
			}
			num += num13 - (float)(2 * spacingChar) * (fXScale * (float)((Viewport)(ref viewport)).get_Height()) / num4;
		}
		vertexBuffer.SetData((object)fontVertices, 0, (LockFlags)8192);
		if (num6 > 0)
		{
			device.DrawPrimitives((PrimitiveType)4, 0, num6);
		}
		savedStateBlock.Apply();
	}

	public void DrawTextScaled(float x, float y, float z, float fXScale, float fYScale, Color color, string text)
	{
		DrawTextScaled(x, y, z, fXScale, fYScale, color, text, (RenderFlags)0);
	}

	public void Render3DText(string text, RenderFlags flags)
	{
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		if (device == null)
		{
			throw new ArgumentNullException();
		}
		savedStateBlock.Capture();
		drawTextStateBlock.Apply();
		device.set_VertexFormat((VertexFormats)274);
		device.set_PixelShader((PixelShader)null);
		device.SetStreamSource(0, vertexBuffer, 0, VertexInformation.GetFormatSize((VertexFormats)274));
		if ((flags & RenderFlags.Filtered) != 0)
		{
			samplerState0.set_MinFilter((TextureFilter)2);
			samplerState0.set_MagFilter((TextureFilter)2);
		}
		float num = 0f;
		float num2 = 0f;
		if ((flags & RenderFlags.Centered) != 0)
		{
			SizeF textExtent = GetTextExtent(text);
			num = (0f - textExtent.Width / 10f) / 2f;
			num2 = (0f - textExtent.Height / 10f) / 2f;
		}
		if ((flags & RenderFlags.TwoSided) != 0)
		{
			renderState.set_CullMode((Cull)1);
		}
		num -= (float)spacingChar / 10f;
		float num3 = num;
		GraphicsStream val = vertexBuffer.Lock(0, 0, (LockFlags)8192);
		int num4 = 0;
		CharEnumerator enumerator = text.GetEnumerator();
		Vector3 val2 = default(Vector3);
		Vector3 val4 = default(Vector3);
		PositionNormalTextured val5 = default(PositionNormalTextured);
		while (enumerator.MoveNext())
		{
			char current = enumerator.Current;
			if (current == '\n')
			{
				num = num3;
				num2 -= (textureCoords[0, 3] - textureCoords[0, 1]) * (float)textureHeight / 10f;
			}
			if ((Strings.Asc(current) - 32 < 0) | (Strings.Asc(current) - 32 >= 96))
			{
				continue;
			}
			float num5 = textureCoords[Strings.Asc(current) - 32, 0];
			float num6 = textureCoords[Strings.Asc(current) - 32, 1];
			float num7 = textureCoords[Strings.Asc(current) - 32, 2];
			float num8 = textureCoords[Strings.Asc(current) - 32, 3];
			float num9 = (num7 - num5) * (float)textureWidth / (10f * textureScale);
			float num10 = (num8 - num6) * (float)textureHeight / (10f * textureScale);
			if (current != ' ')
			{
				GraphicsStream obj = val;
				((Vector3)(ref val2))._002Ector(num + 0f, num2 + 0f, 0f);
				Vector3 val3 = val2;
				((Vector3)(ref val4))._002Ector(0f, 0f, -1f);
				((PositionNormalTextured)(ref val5))._002Ector(val3, val4, num5, num8);
				obj.Write((ValueType)(object)val5);
				GraphicsStream obj2 = val;
				((Vector3)(ref val4))._002Ector(num + 0f, num2 + num10, 0f);
				Vector3 val6 = val4;
				((Vector3)(ref val2))._002Ector(0f, 0f, -1f);
				((PositionNormalTextured)(ref val5))._002Ector(val6, val2, num5, num6);
				obj2.Write((ValueType)(object)val5);
				GraphicsStream obj3 = val;
				((Vector3)(ref val4))._002Ector(num + num9, num2 + 0f, 0f);
				Vector3 val7 = val4;
				((Vector3)(ref val2))._002Ector(0f, 0f, -1f);
				((PositionNormalTextured)(ref val5))._002Ector(val7, val2, num7, num8);
				obj3.Write((ValueType)(object)val5);
				GraphicsStream obj4 = val;
				((Vector3)(ref val4))._002Ector(num + num9, num2 + num10, 0f);
				Vector3 val8 = val4;
				((Vector3)(ref val2))._002Ector(0f, 0f, -1f);
				((PositionNormalTextured)(ref val5))._002Ector(val8, val2, num7, num6);
				obj4.Write((ValueType)(object)val5);
				GraphicsStream obj5 = val;
				((Vector3)(ref val4))._002Ector(num + num9, num2 + 0f, 0f);
				Vector3 val9 = val4;
				((Vector3)(ref val2))._002Ector(0f, 0f, -1f);
				((PositionNormalTextured)(ref val5))._002Ector(val9, val2, num7, num8);
				obj5.Write((ValueType)(object)val5);
				GraphicsStream obj6 = val;
				((Vector3)(ref val4))._002Ector(num + 0f, num2 + num10, 0f);
				Vector3 val10 = val4;
				((Vector3)(ref val2))._002Ector(0f, 0f, -1f);
				((PositionNormalTextured)(ref val5))._002Ector(val10, val2, num5, num6);
				obj6.Write((ValueType)(object)val5);
				num4 += 2;
				if (num4 * 3 > 294)
				{
					vertexBuffer.Unlock();
					device.DrawPrimitives((PrimitiveType)4, 0, num4);
					val = vertexBuffer.Lock(0, 0, (LockFlags)8192);
					num4 = 0;
				}
			}
			num += num9 - (float)(2 * spacingChar) / 10f;
		}
		vertexBuffer.Unlock();
		if (num4 > 0)
		{
			device.DrawPrimitives((PrimitiveType)4, 0, num4);
		}
		savedStateBlock.Apply();
	}

	private SizeF GetTextExtent(string text)
	{
		if ((StringType.StrCmp((string)null, text, false) == 0) | (StringType.StrCmp(text, string.Empty, false) == 0))
		{
			throw new ArgumentNullException();
		}
		float num = 0f;
		float num2 = (textureCoords[0, 3] - textureCoords[0, 1]) * (float)textureHeight;
		float num3 = 0f;
		float num4 = num2;
		CharEnumerator enumerator = text.GetEnumerator();
		while (enumerator.MoveNext())
		{
			char current = enumerator.Current;
			if (current == '\n')
			{
				num = 0f;
				num4 += num2;
			}
			if (!((Strings.Asc(current) - 32 < 0) | (Strings.Asc(current) - 32 >= 96)))
			{
				float num5 = textureCoords[Strings.Asc(current) - 32, 0];
				float num6 = textureCoords[Strings.Asc(current) - 32, 2];
				num += (num6 - num5) * (float)textureWidth - (float)(2 * spacingChar);
				if (num > num3)
				{
					num3 = num;
				}
			}
		}
		return new SizeF(num3, num4);
	}

	public void Dispose(object sender, EventArgs e)
	{
		if (systemFont != null)
		{
			systemFont.Dispose();
		}
		systemFont = null;
	}
}
