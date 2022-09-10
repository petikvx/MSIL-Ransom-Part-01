using System.Collections;
using Microsoft.DirectX.Direct3D;

public class DeviceCombo
{
	public int AdapterOrdinal;

	public DeviceType DevType;

	public Format AdapterFormat;

	public Format BackBufferFormat;

	public bool IsWindowed;

	public ArrayList DepthStencilFormatList;

	public ArrayList MultiSampleTypeList;

	public ArrayList MultiSampleQualityList;

	public ArrayList DepthStencilMultiSampleConflictList;

	public ArrayList VertexProcessingTypeList;

	public ArrayList PresentIntervalList;

	public DeviceCombo()
	{
		DepthStencilFormatList = new ArrayList();
		MultiSampleTypeList = new ArrayList();
		MultiSampleQualityList = new ArrayList();
		DepthStencilMultiSampleConflictList = new ArrayList();
		VertexProcessingTypeList = new ArrayList();
		PresentIntervalList = new ArrayList();
	}
}
