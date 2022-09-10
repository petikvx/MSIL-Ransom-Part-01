using System.Collections;
using Microsoft.DirectX.Direct3D;

public class GraphicsAdapterInfo
{
	public int AdapterOrdinal;

	public AdapterDetails AdapterDetails;

	public ArrayList DisplayModeList;

	public ArrayList DeviceInfoList;

	public GraphicsAdapterInfo()
	{
		DisplayModeList = new ArrayList();
		DeviceInfoList = new ArrayList();
	}

	public override string ToString()
	{
		return ((AdapterDetails)(ref AdapterDetails)).get_Description();
	}
}
