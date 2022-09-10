using System;
using System.Collections;
using Microsoft.DirectX.Direct3D;

public class GraphicsDeviceInfo
{
	public int AdapterOrdinal;

	public DeviceType DevType;

	public Caps Caps;

	public ArrayList DeviceComboList;

	public GraphicsDeviceInfo()
	{
		DeviceComboList = new ArrayList();
	}

	public override string ToString()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Enum)DevType).ToString();
	}
}
