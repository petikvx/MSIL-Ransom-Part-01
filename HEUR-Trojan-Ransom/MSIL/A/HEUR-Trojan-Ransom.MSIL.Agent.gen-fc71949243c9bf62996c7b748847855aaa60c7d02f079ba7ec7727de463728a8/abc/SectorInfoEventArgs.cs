using System;

namespace abc;

public class SectorInfoEventArgs : EventArgs
{
	private readonly int cSector;

	private readonly int tSectors;

	public int CurrentSector => cSector;

	public int TotalSectors => tSectors;

	public SectorInfoEventArgs(int currentSector, int totalSectors)
	{
		cSector = currentSector;
		tSectors = totalSectors;
	}
}
