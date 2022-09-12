namespace ICSharpCode.SharpZipLib.Zip;

public class TestStatus
{
	private long hhMuAMCccYMuCWEHoePIwBCodTWJ;

	private ZipEntry cFaVCaZYpKaXBFhZzmswBJGtfGQcA;

	private bool KaJuNeDJpUCBRSgBPSREtQEntcbU;

	private int BwuqDiSWzozeUxVeOEwNihMOolaJ;

	private ZipFile zkGoIOYCJVhlYBkhbSNtMKkhqKPib;

	private TestOperation ZUVfXUzfXJjEFhBtIBFXjJUxcJJBA;

	public long BytesTested => hhMuAMCccYMuCWEHoePIwBCodTWJ;

	public ZipEntry Entry => cFaVCaZYpKaXBFhZzmswBJGtfGQcA;

	public bool EntryValid => KaJuNeDJpUCBRSgBPSREtQEntcbU;

	public int ErrorCount => BwuqDiSWzozeUxVeOEwNihMOolaJ;

	public ZipFile File => zkGoIOYCJVhlYBkhbSNtMKkhqKPib;

	public TestOperation Operation => ZUVfXUzfXJjEFhBtIBFXjJUxcJJBA;

	public TestStatus(ZipFile file)
	{
		zkGoIOYCJVhlYBkhbSNtMKkhqKPib = file;
	}

	internal void cwbBMiHvXjnRDrwPuhHtuRHvRFYy()
	{
		BwuqDiSWzozeUxVeOEwNihMOolaJ++;
		KaJuNeDJpUCBRSgBPSREtQEntcbU = false;
	}

	internal void nFbJYhhCbTzUPreUFzKnqgqedWfXA(long value)
	{
		hhMuAMCccYMuCWEHoePIwBCodTWJ = value;
	}

	internal void EJafPsLKgitPKKsbeeqypiSfAbuh(ZipEntry entry)
	{
		cFaVCaZYpKaXBFhZzmswBJGtfGQcA = entry;
		KaJuNeDJpUCBRSgBPSREtQEntcbU = true;
		hhMuAMCccYMuCWEHoePIwBCodTWJ = 0L;
	}

	internal void hBJocMANnrMIZumjXrwBzalpFdsu(TestOperation operation)
	{
		ZUVfXUzfXJjEFhBtIBFXjJUxcJJBA = operation;
	}
}
