using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic.CompilerServices;

namespace CubeMapSample;

public class MyGraphicsSample : GraphicsSample
{
	public struct EnvMappedVertex
	{
		public Vector3 p;

		public Vector3 n;

		public const VertexFormats Format = 18;
	}

	private string[] effectString;

	public int CubeMapResolution;

	private Matrix projectionMatrix;

	private Matrix viewMatrix;

	private Matrix worldMatrix;

	private Matrix airplaneMatrix;

	private Matrix trackBallMatrix;

	private GraphicsFont drawingFont;

	private GraphicsMesh shinyTeapotMesh;

	private GraphicsMesh skyBoxMesh;

	private GraphicsMesh airplaneMesh;

	private Effect effect;

	private RenderToEnvironmentMap renderToEnvironmentMap;

	private CubeTexture cubeMap;

	private Texture sphereMap;

	public MyGraphicsSample()
	{
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		effectString = new string[70]
		{
			"texture texCubeMap;\n", "texture texSphereMap;\n", "matrix matWorld;\n", "matrix matView;\n", "matrix matProject;\n", "matrix matWorldView;\n", "technique Cube\n", "{\n", "pass P0\n", "{\n",
			"VertexShader = null;\n", "WorldTransform[0] = <matWorld>;\n", "ViewTransform = <matView>;\n", "ProjectionTransform = <matProject>;\n", "Texture[0] = <texCubeMap>;\n", "MinFilter[0] = Linear;\n", "MagFilter[0] = Linear;\n", "AddressU[0] = Clamp;\n", "AddressV[0] = Clamp;\n", "AddressW[0] = Clamp;\n",
			"ColorOp[0] = SelectArg1;\n", "ColorArg1[0] = Texture;\n", "TexCoordIndex[0] = CameraSpaceReflectionVector;\n", "TextureTransformFlags[0] = Count3;\n", "}\n", "}\n", "technique Sphere\n", "{\n", "pass P0\n", "{\n",
			"VertexShader =\n", "decl\n", "{\n", "}\n", "asm\n", "{\n", "vs.1.1\n", "def c64, 0.25f, 0.5f, 1.0f, -1.0f\n", "dcl_position v0\n", "dcl_normal v1\n",
			"m4x4 r0, v0, c0\n", "m3x3 r1.xyz, v1, c0\n", "mov r1.w, c64.z\n", "mov r2, -r0\n", "dp3 r3, r2, r2\n", "rsq r3, r3.w\n", "mul r2, r2, r3\n", "dp3 r3, r1, r2\n", "mul r1, r1, r3\n", "add r1, r1, r1\n",
			"add r3, r1, -r2\n", "mad r4.w, -r3.z, c64.y, c64.y\n", "rsq r4, r4.w\n", "mul r4, r3, r4\n", "mad r4, r4, c64.x, c64.y\n", "m4x4 oPos, r0, c4\n", "mul oT0.xy, r4.xy, c64.zw\n", "mov oT0.zw, c64.z\n", "};\n", "VertexShaderConstant4[0] = <matWorldView>;\n",
			"VertexShaderConstant4[4] = <matProject>;\n", "Texture[0] = <texSphereMap>;\n", "AddressU[0] = Wrap;\n", "AddressV[0] = Wrap;\n", "MinFilter[0] = Linear;\n", "MagFilter[0] = Linear;\n", "ColorOp[0] = SelectArg1;\n", "ColorArg1[0] = Texture;\n", "}\n", "}\n"
		};
		CubeMapResolution = 256;
		drawingFont = null;
		shinyTeapotMesh = null;
		skyBoxMesh = null;
		airplaneMesh = null;
		effect = null;
		renderToEnvironmentMap = null;
		cubeMap = null;
		sphereMap = null;
		((Control)this).set_Text("CubeMap: Environment cube-mapping");
		enumerationSettings.AppUsesDepthBuffer = true;
		drawingFont = new GraphicsFont("Arial", (FontStyle)1);
		shinyTeapotMesh = new GraphicsMesh();
		skyBoxMesh = new GraphicsMesh();
		airplaneMesh = new GraphicsMesh();
		worldMatrix = Matrix.get_Identity();
		trackBallMatrix = Matrix.get_Identity();
		viewMatrix = Matrix.Translation(0f, 0f, 3f);
	}

	protected override void FrameMove()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		Matrix val = Matrix.Translation(0f, 2f, 0f);
		airplaneMatrix = Matrix.Scaling(0.2f, 0.2f, 0.2f);
		airplaneMatrix = Matrix.Multiply(airplaneMatrix, val);
		val = Matrix.RotationX(-2.9f * appTime);
		airplaneMatrix = Matrix.Multiply(airplaneMatrix, val);
		val = Matrix.RotationY(1.055f * appTime);
		airplaneMatrix = Matrix.Multiply(airplaneMatrix, val);
		if (((Control)this).get_Capture())
		{
			Quaternion rotationFromCursor = GraphicsUtility.GetRotationFromCursor((Form)(object)this);
			Matrix val2 = Matrix.RotationQuaternion(rotationFromCursor);
			viewMatrix = Matrix.Multiply(trackBallMatrix, val2);
			Matrix val3 = Matrix.Translation(0f, 0f, 3f);
			viewMatrix = Matrix.Multiply(viewMatrix, val3);
		}
		RenderSceneIntoEnvMap();
	}

	private void RenderSceneIntoEnvMap()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		Matrix project = Matrix.PerspectiveFovLH((float)Math.PI / 2f, 1f, 0.5f, 1000f);
		Matrix val = viewMatrix;
		val.M41 = 0f;
		val.M42 = 0f;
		val.M43 = 0f;
		if (cubeMap != null)
		{
			renderToEnvironmentMap.BeginCube(cubeMap);
		}
		else
		{
			renderToEnvironmentMap.BeginSphere(sphereMap);
		}
		int num = 0;
		do
		{
			renderToEnvironmentMap.Face((CubeMapFace)num, 1);
			Matrix view = Matrix.Multiply(val, GraphicsUtility.GetCubeMapViewMatrix((CubeMapFace)num));
			RenderScene(view, project, bRenderTeapot: false);
			num++;
		}
		while (num <= 5);
		renderToEnvironmentMap.End(1);
	}

	private void RenderScene(Matrix View, Matrix Project, bool bRenderTeapot)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		DirectXException.IgnoreExceptions();
		Matrix world = Matrix.Scaling(10f, 10f, 10f);
		Matrix view = View;
		view.M41 = 0f;
		view.M42 = 0f;
		view.M43 = 0f;
		device.get_Transform().set_World(world);
		device.get_Transform().set_View(view);
		device.get_Transform().set_Projection(Project);
		device.get_TextureState().get_TextureState(0).set_ColorArgument1((TextureArgument)2);
		device.get_TextureState().get_TextureState(0).set_ColorOperation((TextureOperation)2);
		device.get_SamplerState().get_SamplerState(0).set_MinFilter((TextureFilter)2);
		device.get_SamplerState().get_SamplerState(0).set_MagFilter((TextureFilter)2);
		device.get_SamplerState().get_SamplerState(0).set_AddressU((TextureAddress)2);
		device.get_SamplerState().get_SamplerState(0).set_AddressV((TextureAddress)2);
		device.get_RenderState().set_ZBufferFunction((Compare)8);
		skyBoxMesh.Render(device);
		device.get_RenderState().set_ZBufferFunction((Compare)4);
		device.get_Transform().set_World(airplaneMatrix);
		device.get_Transform().set_View(View);
		device.get_Transform().set_Projection(Project);
		device.get_TextureState().get_TextureState(0).set_ColorArgument1((TextureArgument)2);
		device.get_TextureState().get_TextureState(0).set_ColorOperation((TextureOperation)2);
		device.get_SamplerState().get_SamplerState(0).set_MinFilter((TextureFilter)2);
		device.get_SamplerState().get_SamplerState(0).set_MagFilter((TextureFilter)2);
		device.get_SamplerState().get_SamplerState(0).set_AddressU((TextureAddress)1);
		device.get_SamplerState().get_SamplerState(0).set_AddressV((TextureAddress)1);
		airplaneMesh.Render(device, bDrawOpaqueSubsets: true, bDrawAlphaSubsets: false);
		device.get_Transform().set_World(worldMatrix);
		if (bRenderTeapot)
		{
			if (cubeMap != null)
			{
				((BaseEffect)effect).SetValue(EffectHandle.FromString("matWorld"), worldMatrix);
				((BaseEffect)effect).SetValue(EffectHandle.FromString("matView"), View);
			}
			else
			{
				Matrix val = Matrix.Multiply(worldMatrix, View);
				((BaseEffect)effect).SetValue(EffectHandle.FromString("matWorldView"), val);
			}
			((BaseEffect)effect).SetValue(EffectHandle.FromString("matProject"), Project);
			VertexBuffer localVertexBuffer = shinyTeapotMesh.LocalVertexBuffer;
			IndexBuffer localIndexBuffer = shinyTeapotMesh.LocalIndexBuffer;
			int numberVertices = ((BaseMesh)shinyTeapotMesh.LocalMesh).get_NumberVertices();
			int numberFaces = ((BaseMesh)shinyTeapotMesh.LocalMesh).get_NumberFaces();
			device.SetStreamSource(0, localVertexBuffer, 0, DXHelp.GetTypeSize(typeof(EnvMappedVertex)));
			device.set_VertexFormat((VertexFormats)18);
			device.set_Indices(localIndexBuffer);
			int num = effect.Begin((FX)0);
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				effect.Pass(i);
				device.DrawIndexedPrimitives((PrimitiveType)4, 0, 0, numberVertices, 0, numberFaces);
			}
			effect.End();
		}
		DirectXException.EnableExceptions();
	}

	protected override void Render()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		device.BeginScene();
		DirectXException.IgnoreExceptions();
		RenderScene(viewMatrix, projectionMatrix, bRenderTeapot: true);
		drawingFont.DrawText(2f, 1f, Color.Yellow, frameStats);
		drawingFont.DrawText(2f, 21f, Color.Yellow, deviceStats);
		DirectXException.EnableExceptions();
		device.EndScene();
	}

	protected override void InitializeDeviceObjects()
	{
		try
		{
			shinyTeapotMesh.Create(device, "teapot.x");
			skyBoxMesh.Create(device, "lobby_skybox.x");
			airplaneMesh.Create(device, "airplane 2.x");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MediaNotFoundException ex = new MediaNotFoundException();
			HandleSampleException(ex, ApplicationMessage.ApplicationMustExit);
			throw ex;
		}
		airplaneMesh.SetFVF(device, (VertexFormats)274);
		shinyTeapotMesh.SetFVF(device, (VertexFormats)18);
		drawingFont.InitializeDeviceObjects(device);
		string text = null;
		int num = effectString.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			text += effectString[i];
		}
		effect = Effect.FromString(device, text, (Include)null, (ShaderFlags)0, (EffectPool)null);
	}

	protected override void RestoreDeviceObjects(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		shinyTeapotMesh.RestoreDeviceObjects(device, null);
		skyBoxMesh.RestoreDeviceObjects(device, null);
		airplaneMesh.RestoreDeviceObjects(device, null);
		renderToEnvironmentMap = new RenderToEnvironmentMap(device, CubeMapResolution, 1, device.get_PresentationParameters().get_BackBufferFormat(), true, (DepthFormat)80);
		Caps caps = Caps;
		TextureCaps textureCaps = ((Caps)(ref caps)).get_TextureCaps();
		if (((TextureCaps)(ref textureCaps)).get_SupportsCubeMap())
		{
			try
			{
				cubeMap = new CubeTexture(device, CubeMapResolution, 1, (Usage)1, device.get_PresentationParameters().get_BackBufferFormat(), (Pool)0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				try
				{
					cubeMap = new CubeTexture(device, CubeMapResolution, 1, (Usage)0, device.get_PresentationParameters().get_BackBufferFormat(), (Pool)0);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					cubeMap = null;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
		if (cubeMap == null)
		{
			try
			{
				sphereMap = new Texture(device, CubeMapResolution, CubeMapResolution, 1, (Usage)1, device.get_PresentationParameters().get_BackBufferFormat(), (Pool)0);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				sphereMap = new Texture(device, CubeMapResolution, CubeMapResolution, 1, (Usage)0, device.get_PresentationParameters().get_BackBufferFormat(), (Pool)0);
				ProjectData.ClearProjectError();
			}
		}
		((BaseEffect)effect).SetValue(EffectHandle.FromString("texCubeMap"), (BaseTexture)(object)cubeMap);
		((BaseEffect)effect).SetValue(EffectHandle.FromString("texSphereMap"), (BaseTexture)(object)sphereMap);
		if (cubeMap != null)
		{
			effect.set_Technique(EffectHandle.FromString("Cube"));
			((Control)this).set_Text("CubeMap: Environment cube-mapping");
		}
		else
		{
			effect.set_Technique(EffectHandle.FromString("Sphere"));
			((Control)this).set_Text("CubeMap: Environment cube-mapping (using dynamic spheremap)");
		}
		float num = (float)device.get_PresentationParameters().get_BackBufferWidth() / (float)device.get_PresentationParameters().get_BackBufferHeight();
		projectionMatrix = Matrix.PerspectiveFovLH((float)Math.PI * 2f / 5f, num, 0.5f, 100f);
	}

	protected override bool ConfirmDevice(Caps caps, VertexProcessingType vertexProcessingType, Format adapterFmt, Format backBufferFmt)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		TextureCaps textureCaps = ((Caps)(ref caps)).get_TextureCaps();
		if ((!((TextureCaps)(ref textureCaps)).get_SupportsCubeMap() && vertexProcessingType != VertexProcessingType.Software) & (((Caps)(ref caps)).get_VertexShaderVersion().Major < 1))
		{
			return false;
		}
		return true;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_Button() == 1048576)
		{
			Quaternion rotationFromCursor = GraphicsUtility.GetRotationFromCursor((Form)(object)this);
			Matrix val = Matrix.RotationQuaternion(rotationFromCursor);
			((Matrix)(ref val)).Transpose(val);
			trackBallMatrix = Matrix.Multiply(trackBallMatrix, val);
			((Control)this).set_Capture(true);
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_Button() == 1048576)
		{
			Quaternion rotationFromCursor = GraphicsUtility.GetRotationFromCursor((Form)(object)this);
			Matrix val = Matrix.RotationQuaternion(rotationFromCursor);
			trackBallMatrix = Matrix.Multiply(trackBallMatrix, val);
			((Control)this).set_Capture(false);
		}
		((Control)this).OnMouseUp(e);
	}

	[STAThread]
	public static void Main()
	{
		MyGraphicsSample myGraphicsSample = new MyGraphicsSample();
		if (myGraphicsSample.CreateGraphicsSample())
		{
			myGraphicsSample.Run();
		}
	}
}
