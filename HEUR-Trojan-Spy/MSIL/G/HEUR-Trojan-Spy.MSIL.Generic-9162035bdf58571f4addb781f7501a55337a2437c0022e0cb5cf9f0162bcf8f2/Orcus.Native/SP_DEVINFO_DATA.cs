using System;

namespace Orcus.Native;

public struct SP_DEVINFO_DATA
{
	public int Size;

	public Guid ClassGuid;

	public int DevInst;

	public IntPtr Reserved;
}
