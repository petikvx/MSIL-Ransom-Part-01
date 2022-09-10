using System;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic.CompilerServices;

public class GraphicsMesh : IDisposable
{
	private string fileName;

	private Mesh systemMemoryMesh;

	private Mesh localMemoryMesh;

	private Material[] materials;

	private Texture[] textures;

	private bool useMaterials;

	private VertexBuffer systemMemoryVertexBuffer;

	private VertexBuffer localMemoryVertexBuffer;

	private IndexBuffer systemMemoryIndexBuffer;

	private IndexBuffer localMemoryIndexBuffer;

	public VertexBuffer LocalVertexBuffer
	{
		get
		{
			if (localMemoryVertexBuffer != null)
			{
				return localMemoryVertexBuffer;
			}
			if (localMemoryMesh == null)
			{
				return null;
			}
			localMemoryVertexBuffer = ((BaseMesh)localMemoryMesh).get_VertexBuffer();
			return localMemoryVertexBuffer;
		}
	}

	public IndexBuffer LocalIndexBuffer
	{
		get
		{
			if (localMemoryIndexBuffer != null)
			{
				return localMemoryIndexBuffer;
			}
			if (localMemoryMesh == null)
			{
				return null;
			}
			localMemoryIndexBuffer = ((BaseMesh)localMemoryMesh).get_IndexBuffer();
			return localMemoryIndexBuffer;
		}
	}

	public Mesh SysMemMesh => systemMemoryMesh;

	public bool UseMeshMaterials
	{
		set
		{
			useMaterials = value;
		}
	}

	public Mesh LocalMesh => localMemoryMesh;

	public VertexBuffer SystemVertexBuffer
	{
		get
		{
			if (systemMemoryVertexBuffer != null)
			{
				return systemMemoryVertexBuffer;
			}
			if (systemMemoryMesh == null)
			{
				return null;
			}
			systemMemoryVertexBuffer = ((BaseMesh)systemMemoryMesh).get_VertexBuffer();
			return systemMemoryVertexBuffer;
		}
	}

	public IndexBuffer SystemIndexBuffer
	{
		get
		{
			if (systemMemoryIndexBuffer != null)
			{
				return systemMemoryIndexBuffer;
			}
			if (systemMemoryMesh == null)
			{
				return null;
			}
			systemMemoryIndexBuffer = ((BaseMesh)systemMemoryMesh).get_IndexBuffer();
			return systemMemoryIndexBuffer;
		}
	}

	public GraphicsMesh(string strName)
	{
		fileName = null;
		systemMemoryMesh = null;
		localMemoryMesh = null;
		materials = null;
		textures = null;
		useMaterials = true;
		systemMemoryVertexBuffer = null;
		localMemoryVertexBuffer = null;
		systemMemoryIndexBuffer = null;
		localMemoryIndexBuffer = null;
		fileName = strName;
	}

	public GraphicsMesh()
	{
		fileName = null;
		systemMemoryMesh = null;
		localMemoryMesh = null;
		materials = null;
		textures = null;
		useMaterials = true;
		systemMemoryVertexBuffer = null;
		localMemoryVertexBuffer = null;
		systemMemoryIndexBuffer = null;
		localMemoryIndexBuffer = null;
		fileName = "CD3DFile_Mesh";
	}

	public void Create(Device pd3dDevice, string strFilename)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		if (pd3dDevice != null)
		{
			pd3dDevice.add_DeviceLost((EventHandler)InvalidateDeviceObjects);
			pd3dDevice.add_Disposing((EventHandler)InvalidateDeviceObjects);
			pd3dDevice.add_DeviceReset((EventHandler)RestoreDeviceObjects);
		}
		text = DXUtil.FindMediaFile(null, strFilename);
		ExtendedMaterial[] array = default(ExtendedMaterial[]);
		GraphicsStream val = default(GraphicsStream);
		systemMemoryMesh = Mesh.FromFile(text, (MeshFlags)272, pd3dDevice, ref val, ref array);
		systemMemoryMesh.OptimizeInPlace((MeshFlags)117440512, val);
		textures = (Texture[])(object)new Texture[array.Length + 1];
		materials = (Material[])(object)new Material[array.Length + 1];
		int num = array.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			ref Material reference = ref materials[i];
			reference = ((ExtendedMaterial)(ref array[i])).get_Material3D();
			((Material)(ref materials[i])).set_Ambient(((Material)(ref materials[i])).get_Diffuse());
			if (((ExtendedMaterial)(ref array[i])).get_TextureFilename() != null)
			{
				string text2 = DXUtil.FindMediaFile(null, ((ExtendedMaterial)(ref array[i])).get_TextureFilename());
				textures[i] = TextureLoader.FromFile(pd3dDevice, text2);
			}
		}
		val.Close();
		val = null;
	}

	public void SetFVF(Device pd3dDevice, VertexFormats format)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		Mesh val = null;
		Mesh val2 = null;
		if (systemMemoryMesh != null)
		{
			val = ((BaseMesh)systemMemoryMesh).Clone((MeshFlags)272, format, pd3dDevice);
		}
		if (localMemoryMesh != null)
		{
			try
			{
				val2 = ((BaseMesh)localMemoryMesh).Clone((MeshFlags)0, format, pd3dDevice);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				val.Dispose();
				val = null;
				throw ex2;
			}
		}
		if (systemMemoryMesh != null)
		{
			systemMemoryMesh.Dispose();
		}
		systemMemoryMesh = null;
		if (localMemoryMesh != null)
		{
			localMemoryMesh.Dispose();
		}
		localMemoryMesh = null;
		DisposeLocalBuffers(bSysBuffers: true, bLocalBuffers: true);
		if (val != null)
		{
			systemMemoryMesh = val;
		}
		if (val2 != null)
		{
			localMemoryMesh = val2;
		}
		if (systemMemoryMesh != null)
		{
			((BaseMesh)systemMemoryMesh).ComputeNormals();
		}
		if (localMemoryMesh != null)
		{
			((BaseMesh)localMemoryMesh).ComputeNormals();
		}
	}

	public void RestoreDeviceObjects(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (systemMemoryMesh == null)
		{
			throw new ArgumentException();
		}
		Device val = (Device)sender;
		localMemoryMesh = ((BaseMesh)systemMemoryMesh).Clone((MeshFlags)0, ((BaseMesh)systemMemoryMesh).get_VertexFormat(), val);
		DisposeLocalBuffers(bSysBuffers: false, bLocalBuffers: true);
	}

	public void InvalidateDeviceObjects(object sender, EventArgs e)
	{
		if (localMemoryMesh != null)
		{
			localMemoryMesh.Dispose();
		}
		localMemoryMesh = null;
		DisposeLocalBuffers(bSysBuffers: false, bLocalBuffers: true);
	}

	public void Dispose()
	{
		if (textures != null)
		{
			int num = textures.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (textures[i] != null)
				{
					((BaseTexture)textures[i]).Dispose();
				}
				textures[i] = null;
			}
			textures = null;
		}
		DisposeLocalBuffers(bSysBuffers: true, bLocalBuffers: true);
		if (systemMemoryMesh != null)
		{
			systemMemoryMesh.Dispose();
		}
		systemMemoryMesh = null;
		GC.SuppressFinalize(this);
	}

	public void Render(Device pd3dDevice, bool bDrawOpaqueSubsets, bool bDrawAlphaSubsets)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		if (localMemoryMesh == null)
		{
			throw new ArgumentException();
		}
		RenderStates renderState = pd3dDevice.get_RenderState();
		if (bDrawOpaqueSubsets)
		{
			int num = materials.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (useMaterials)
				{
					if (bDrawAlphaSubsets && ((Material)(ref materials[i])).get_Diffuse().A < byte.MaxValue)
					{
						continue;
					}
					pd3dDevice.set_Material(materials[i]);
					pd3dDevice.SetTexture(0, (BaseTexture)(object)textures[i]);
				}
				((BaseMesh)localMemoryMesh).DrawSubset(i);
			}
		}
		if (!(bDrawAlphaSubsets & useMaterials))
		{
			return;
		}
		renderState.set_AlphaBlendEnable(true);
		renderState.set_SourceBlend((Blend)5);
		renderState.set_DestinationBlend((Blend)6);
		int num2 = materials.Length - 1;
		for (int j = 0; j <= num2; j++)
		{
			if (((Material)(ref materials[j])).get_Diffuse().A != byte.MaxValue)
			{
				pd3dDevice.set_Material(materials[j]);
				pd3dDevice.SetTexture(0, (BaseTexture)(object)textures[j]);
				((BaseMesh)localMemoryMesh).DrawSubset(j);
			}
		}
		renderState.set_AlphaBlendEnable(false);
	}

	public void Render(Device pd3dDevice)
	{
		Render(pd3dDevice, bDrawOpaqueSubsets: true, bDrawAlphaSubsets: true);
	}

	private void DisposeLocalBuffers(bool bSysBuffers, bool bLocalBuffers)
	{
		if (bSysBuffers)
		{
			if (systemMemoryIndexBuffer != null)
			{
				systemMemoryIndexBuffer.Dispose();
			}
			systemMemoryIndexBuffer = null;
			if (systemMemoryVertexBuffer != null)
			{
				systemMemoryVertexBuffer.Dispose();
			}
			systemMemoryVertexBuffer = null;
		}
		if (bLocalBuffers)
		{
			if (localMemoryIndexBuffer != null)
			{
				localMemoryIndexBuffer.Dispose();
			}
			localMemoryIndexBuffer = null;
			if (localMemoryVertexBuffer != null)
			{
				localMemoryVertexBuffer.Dispose();
			}
			localMemoryVertexBuffer = null;
		}
	}
}
