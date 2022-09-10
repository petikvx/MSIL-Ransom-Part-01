namespace abc;

internal class Wiper
{
	private int currentPass;

	private int totalPasses;

	private int currentSector;

	private int totalSectors;

	public void erase(string path)
	{
		Wipe wipe = new Wipe();
		wipe.PassInfoEvent += wipe_PassInfoEvent;
		wipe.SectorInfoEvent += wipe_SectorInfoEvent;
		wipe.WipeDoneEvent += wipe_WipeDoneEvent;
		wipe.WipeErrorEvent += wipe_WipeErrorEvent;
		wipe.WipeFile(path, 1);
	}

	private void wipe_WipeErrorEvent(WipeErrorEventArgs e)
	{
	}

	private void wipe_WipeDoneEvent(WipeDoneEventArgs e)
	{
		WipeDone();
	}

	private void wipe_PassInfoEvent(PassInfoEventArgs e)
	{
		currentPass = e.CurrentPass;
		totalPasses = e.TotalPasses;
	}

	private void WipeDone()
	{
	}

	private void wipe_SectorInfoEvent(SectorInfoEventArgs e)
	{
		currentSector = e.CurrentSector;
		totalSectors = e.TotalSectors;
	}
}
