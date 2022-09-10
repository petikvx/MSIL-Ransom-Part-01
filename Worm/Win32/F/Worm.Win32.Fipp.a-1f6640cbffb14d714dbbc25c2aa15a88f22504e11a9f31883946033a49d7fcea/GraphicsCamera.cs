using System;
using Microsoft.DirectX;

public class GraphicsCamera
{
	private Vector3 eyePart;

	private Vector3 lookAtPart;

	private Vector3 upVector;

	private Vector3 viewVector;

	private Vector3 crossVector;

	private Matrix internalviewMatrix;

	private Matrix internalbillboardMatrix;

	private float fieldOfView;

	private float aspectRatio;

	private float nearPlane;

	private float farPlane;

	private Matrix projectionMatrix;

	public Vector3 EyePt => eyePart;

	public Vector3 LookatPt => lookAtPart;

	public Vector3 UpVec => upVector;

	public Vector3 ViewDir => viewVector;

	public Matrix BillboardMatrix => internalbillboardMatrix;

	public Matrix ProjMatrix => projectionMatrix;

	public Matrix ViewMatrix => internalviewMatrix;

	public Vector3 Cross => crossVector;

	public GraphicsCamera()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(0f, 0f, 0f);
		Vector3 vEyePt = val;
		Vector3 val2 = default(Vector3);
		((Vector3)(ref val2))._002Ector(0f, 0f, 1f);
		Vector3 vLookatPt = val2;
		Vector3 vUpVec = default(Vector3);
		((Vector3)(ref vUpVec))._002Ector(0f, 1f, 0f);
		SetViewParams(vEyePt, vLookatPt, vUpVec);
		SetProjParams((float)Math.PI / 4f, 1f, 1f, 1000f);
	}

	public void SetViewParams(Vector3 vEyePt, Vector3 vLookatPt, Vector3 vUpVec)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		eyePart = vEyePt;
		lookAtPart = vLookatPt;
		upVector = vUpVec;
		viewVector = Vector3.Normalize(Vector3.Subtract(lookAtPart, eyePart));
		crossVector = Vector3.Cross(viewVector, upVector);
		internalviewMatrix = Matrix.LookAtLH(eyePart, lookAtPart, upVector);
		internalbillboardMatrix = Matrix.Invert(ViewMatrix);
		internalbillboardMatrix.M41 = 0f;
		internalbillboardMatrix.M42 = 0f;
		internalbillboardMatrix.M43 = 0f;
	}

	public void SetProjParams(float fFOV, float fAspect, float fNearPlane, float fFarPlane)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		fieldOfView = fFOV;
		aspectRatio = fAspect;
		nearPlane = fNearPlane;
		farPlane = fFarPlane;
		projectionMatrix = Matrix.PerspectiveFovLH(fFOV, fAspect, fNearPlane, fFarPlane);
	}
}
