using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

public class GraphicsUtility
{
	private GraphicsUtility()
	{
	}

	public static Material InitMaterial(Color c)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		Material result = default(Material);
		((Material)(ref result)).set_Ambient(c);
		((Material)(ref result)).set_Diffuse(c);
		return result;
	}

	public static void InitLight(Light l, LightType ltType, float x, float y, float z)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		l.set_Type(ltType);
		l.set_Diffuse(Color.White);
		Vector3 position = default(Vector3);
		((Vector3)(ref position))._002Ector(x, y, z);
		l.set_Position(position);
		l.set_Direction(Vector3.Normalize(l.get_Position()));
		l.set_Range(1000f);
	}

	public static Texture CreateTexture(Device d3dDevice, string sTexture, Format d3dFormat)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		string text = DXUtil.FindMediaFile(null, sTexture);
		return TextureLoader.FromFile(d3dDevice, text, -1, -1, -1, (Usage)0, d3dFormat, (Pool)1, (Filter)458756, (Filter)458756, 0);
	}

	public static Texture CreateTexture(Device d3dDevice, string sTexture)
	{
		return CreateTexture(d3dDevice, sTexture, (Format)0);
	}

	public static Matrix GetCubeMapViewMatrix(CubeMapFace uiFace)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(0f, 0f, 0f);
		Vector3 val2 = default(Vector3);
		Vector3 val3 = default(Vector3);
		Vector3 val4 = default(Vector3);
		switch ((int)uiFace)
		{
		case 0:
			((Vector3)(ref val4))._002Ector(1f, 0f, 0f);
			val2 = val4;
			((Vector3)(ref val4))._002Ector(0f, 1f, 0f);
			val3 = val4;
			break;
		case 1:
			((Vector3)(ref val4))._002Ector(-1f, 0f, 0f);
			val2 = val4;
			((Vector3)(ref val4))._002Ector(0f, 1f, 0f);
			val3 = val4;
			break;
		case 2:
			((Vector3)(ref val4))._002Ector(0f, 1f, 0f);
			val2 = val4;
			((Vector3)(ref val4))._002Ector(0f, 0f, -1f);
			val3 = val4;
			break;
		case 3:
			((Vector3)(ref val4))._002Ector(0f, -1f, 0f);
			val2 = val4;
			((Vector3)(ref val4))._002Ector(0f, 0f, 1f);
			val3 = val4;
			break;
		case 4:
			((Vector3)(ref val4))._002Ector(0f, 0f, 1f);
			val2 = val4;
			((Vector3)(ref val4))._002Ector(0f, 1f, 0f);
			val3 = val4;
			break;
		case 5:
			((Vector3)(ref val4))._002Ector(0f, 0f, -1f);
			val2 = val4;
			((Vector3)(ref val4))._002Ector(0f, 1f, 0f);
			val3 = val4;
			break;
		}
		return Matrix.LookAtLH(val, val2, val3);
	}

	public static Quaternion GetRotationFromCursor(Form control, float fTrackBallRadius)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		Point position = Cursor.get_Position();
		Rectangle clientRectangle = ((Control)control).get_ClientRectangle();
		position = ((Control)control).PointToClient(position);
		float num = 2f * (float)position.X / (float)(clientRectangle.Right - clientRectangle.Left) - 1f;
		float num2 = 2f * (float)position.Y / (float)(clientRectangle.Bottom - clientRectangle.Top) - 1f;
		if (num == 0f && num2 == 0f)
		{
			Quaternion result = default(Quaternion);
			((Quaternion)(ref result))._002Ector(0f, 0f, 0f, 1f);
			return result;
		}
		float num3 = (float)Math.Sqrt(num * num + num2 * num2);
		float num4 = ((!((double)num3 < (double)fTrackBallRadius * 0.707106781186548)) ? (fTrackBallRadius * fTrackBallRadius / (2f * num3)) : ((float)Math.Sqrt(fTrackBallRadius * fTrackBallRadius - num3 * num3)));
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(num, num2, num4);
		Vector3 val2 = default(Vector3);
		((Vector3)(ref val2))._002Ector(0f, 0f, fTrackBallRadius);
		Vector3 val3 = Vector3.Cross(val, val2);
		float num5 = Vector3.Length(Vector3.Subtract(val2, val)) / (2f * fTrackBallRadius);
		if (num5 > 1f)
		{
			num5 = 1f;
		}
		if (num5 < -1f)
		{
			num5 = -1f;
		}
		float num6 = (float)(2.0 * Math.Asin(num5));
		return Quaternion.RotationAxis(val3, num6);
	}

	public static Quaternion GetRotationFromCursor(Form control)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return GetRotationFromCursor(control, 1f);
	}

	public static Quaternion D3DXQuaternionUnitAxisToUnitAxis2(Vector3 vFrom, Vector3 vTo)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Vector3.Cross(vFrom, vTo);
		Quaternion result = default(Quaternion);
		((Quaternion)(ref result))._002Ector(val.X, val.Y, val.Z, Vector3.Dot(vFrom, vTo));
		return result;
	}

	public static Quaternion D3DXQuaternionAxisToAxis(Vector3 vFrom, Vector3 vTo)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Vector3.Normalize(vFrom);
		Vector3 val2 = Vector3.Normalize(vTo);
		Vector3 val3 = Vector3.Add(val, val2);
		val3 = Vector3.Normalize(val3);
		return D3DXQuaternionUnitAxisToUnitAxis2(val, val3);
	}

	public static int ColorChannelBits(Format fmt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected I4, but got Unknown
		return (fmt - 20) switch
		{
			0 => 8, 
			1 => 8, 
			2 => 8, 
			3 => 5, 
			4 => 5, 
			5 => 5, 
			6 => 4, 
			7 => 2, 
			9 => 2, 
			10 => 4, 
			11 => 10, 
			15 => 10, 
			_ => 0, 
		};
	}

	public static int AlphaChannelBits(Format fmt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected I4, but got Unknown
		return (fmt - 20) switch
		{
			0 => 0, 
			1 => 8, 
			2 => 0, 
			3 => 0, 
			4 => 0, 
			5 => 1, 
			6 => 4, 
			7 => 0, 
			9 => 8, 
			10 => 0, 
			11 => 2, 
			15 => 2, 
			_ => 0, 
		};
	}

	public static int DepthBits(DepthFormat fmt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected I4, but got Unknown
		return (fmt - 71) switch
		{
			0 => 32, 
			2 => 15, 
			4 => 24, 
			6 => 24, 
			8 => 24, 
			9 => 16, 
			_ => 0, 
		};
	}

	public static int StencilBits(DepthFormat fmt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected I4, but got Unknown
		return (fmt - 71) switch
		{
			0 => 0, 
			2 => 1, 
			4 => 8, 
			6 => 0, 
			8 => 4, 
			9 => 0, 
			_ => 0, 
		};
	}

	public static VertexShader CreateVertexShader(Device pd3dDevice, string strFilename)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		GraphicsStream val = null;
		string text = null;
		text = DXUtil.FindMediaFile(null, strFilename);
		val = ShaderLoader.FromFile(text, (Include)null, (ShaderFlags)0);
		return new VertexShader(pd3dDevice, val);
	}
}
