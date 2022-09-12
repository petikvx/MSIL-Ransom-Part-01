using System;
using System.IO;

namespace RunDll_2;

public class Wipe
{
	public event PassInfoEventHandler PassInfoEvent;

	public event SectorInfoEventHandler SectorInfoEvent;

	public event WipeDoneEventHandler WipeDoneEvent;

	public event WipeErrorEventHandler WipeErrorEvent;

	public void WipeFile(string filename, int timesToWrite)
	{
		try
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
		}
		catch (Exception e)
		{
			WipeError(e);
		}
	}

	private void UpdatePassInfo(int currentPass, int totalPasses)
	{
		this.PassInfoEvent(new PassInfoEventArgs(currentPass, totalPasses));
	}

	private void UpdateSectorInfo(int currentSector, int totalSectors)
	{
		this.SectorInfoEvent(new SectorInfoEventArgs(currentSector, totalSectors));
	}

	private void WipeDone()
	{
		this.WipeDoneEvent(new WipeDoneEventArgs());
	}

	private void WipeError(Exception e)
	{
		this.WipeErrorEvent(new WipeErrorEventArgs(e));
	}
}
