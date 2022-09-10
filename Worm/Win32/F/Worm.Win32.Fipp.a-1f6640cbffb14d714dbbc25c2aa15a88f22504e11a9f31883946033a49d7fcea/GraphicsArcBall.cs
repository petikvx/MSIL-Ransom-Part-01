using System;
using System.Windows.Forms;
using Microsoft.DirectX;

public class GraphicsArcBall
{
	private int internalWidth;

	private int internalHeight;

	private float internalradius;

	private float internalradiusTranslation;

	private Quaternion internaldownQuat;

	private Quaternion internalnowQuat;

	private Matrix internalrotationMatrix;

	private Matrix internalrotationDelta;

	private Matrix internaltranslationMatrix;

	private Matrix internaltranslationDelta;

	private bool internaldragging;

	private bool internaluseRightHanded;

	private int saveMouseX;

	private int saveMouseY;

	private Vector3 internalvectorDown;

	private Control parent;

	public float Radius
	{
		set
		{
			internalradiusTranslation = value;
		}
	}

	public bool RightHanded
	{
		get
		{
			return internaluseRightHanded;
		}
		set
		{
			internaluseRightHanded = value;
		}
	}

	public Matrix RotationMatrix => internalrotationMatrix;

	public Matrix RotationDeltaMatrix => internalrotationDelta;

	public Matrix TranslationMatrix => internaltranslationMatrix;

	public Matrix TranslationDeltaMatrix => internaltranslationDelta;

	public bool IsBeingDragged => internaldragging;

	public GraphicsArcBall(Control p)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		saveMouseX = 0;
		saveMouseY = 0;
		internaldownQuat = Quaternion.get_Identity();
		internalnowQuat = Quaternion.get_Identity();
		internalrotationMatrix = Matrix.get_Identity();
		internalrotationDelta = Matrix.get_Identity();
		internaltranslationMatrix = Matrix.get_Identity();
		internaltranslationDelta = Matrix.get_Identity();
		internaldragging = false;
		internalradiusTranslation = 1f;
		internaluseRightHanded = false;
		parent = p;
		p.add_MouseDown(new MouseEventHandler(OnContainerMouseDown));
		p.add_MouseUp(new MouseEventHandler(OnContainerMouseUp));
		p.add_MouseMove(new MouseEventHandler(OnContainerMouseMove));
	}

	public void SetWindow(int iWidth, int iHeight, float fRadius)
	{
		internalWidth = iWidth;
		internalHeight = iHeight;
		internalradius = fRadius;
	}

	private Vector3 ScreenToVector(int sx, int sy)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		float num = (float)((0.0 - ((double)sx - (double)internalWidth / 2.0)) / (double)(internalradius * (float)internalWidth / 2f));
		float num2 = (float)(((double)sy - (double)internalHeight / 2.0) / (double)(internalradius * (float)internalHeight / 2f));
		if (internaluseRightHanded)
		{
			num = 0f - num;
			num2 = 0f - num2;
		}
		float num3 = 0f;
		float num4 = num * num + num2 * num2;
		if (num4 > 1f)
		{
			float num5 = 1f / (float)Math.Sqrt(num4);
			num *= num5;
			num2 *= num5;
		}
		else
		{
			num3 = (float)Math.Sqrt(1f - num4);
		}
		Vector3 result = default(Vector3);
		((Vector3)(ref result))._002Ector(num, num2, num3);
		return result;
	}

	private void OnContainerMouseDown(object sender, MouseEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		saveMouseX = e.get_X();
		saveMouseY = e.get_Y();
		if ((int)e.get_Button() == 1048576)
		{
			internaldragging = true;
			internalvectorDown = ScreenToVector(e.get_X(), e.get_Y());
			internaldownQuat = internalnowQuat;
		}
	}

	private void OnContainerMouseUp(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			internaldragging = false;
		}
	}

	private void OnContainerMouseMove(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_Button() == 1048576)
		{
			if (internaldragging)
			{
				Vector3 vTo = ScreenToVector(e.get_X(), e.get_Y());
				Quaternion val = GraphicsUtility.D3DXQuaternionAxisToAxis(internalvectorDown, vTo);
				internalnowQuat = internaldownQuat;
				internalnowQuat = Quaternion.Multiply(internalnowQuat, val);
				internalrotationDelta = Matrix.RotationQuaternion(val);
			}
			else
			{
				internalrotationDelta = Matrix.get_Identity();
			}
			internalrotationMatrix = Matrix.RotationQuaternion(internalnowQuat);
			internaldragging = true;
		}
		if (((int)e.get_Button() == 2097152) | ((int)e.get_Button() == 4194304))
		{
			float num = (float)(saveMouseX - e.get_X()) * internalradiusTranslation / (float)internalWidth;
			float num2 = (float)(saveMouseY - e.get_Y()) * internalradiusTranslation / (float)internalHeight;
			if ((int)e.get_Button() == 2097152)
			{
				internaltranslationDelta = Matrix.Translation(-2f * num, 2f * num2, 0f);
				internaltranslationMatrix = Matrix.Multiply(internaltranslationMatrix, internaltranslationDelta);
			}
			if ((int)e.get_Button() == 4194304)
			{
				internaltranslationDelta = Matrix.Translation(0f, 0f, 5f * num2);
				internaltranslationMatrix = Matrix.Multiply(internaltranslationMatrix, internaltranslationDelta);
			}
			saveMouseX = e.get_X();
			saveMouseY = e.get_Y();
		}
	}
}
