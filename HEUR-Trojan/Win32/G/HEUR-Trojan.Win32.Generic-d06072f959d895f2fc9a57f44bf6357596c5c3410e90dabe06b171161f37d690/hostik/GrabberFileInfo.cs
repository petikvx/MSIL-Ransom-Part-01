using System.Collections.Generic;

namespace hostik;

internal class GrabberFileInfo
{
	public static List<GrabberFileInfo> gr_s = new List<GrabberFileInfo>();

	public byte[] File { get; set; }

	public string name { get; set; }

	public int Length { get; set; }
}
