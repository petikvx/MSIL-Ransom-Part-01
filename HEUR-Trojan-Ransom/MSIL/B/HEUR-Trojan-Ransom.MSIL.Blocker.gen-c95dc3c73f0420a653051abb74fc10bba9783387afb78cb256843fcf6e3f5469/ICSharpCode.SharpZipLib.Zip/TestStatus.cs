namespace ICSharpCode.SharpZipLib.Zip;

public class TestStatus
{
	private long cbOwGryqwlfcMdmunFzdiUNfIAHmA;

	private ZipEntry jlkwCLtFnbtkXolcutIZfZkktyRE;

	private bool JNLftXdutlfGXxGwAfWrRWLwPXcR;

	private int UkeffBkjbNHTOARBTrRsUVNDgHtS;

	private ZipFile sYGuCdoMNmPCMTqWkSaCgblckvOT;

	private TestOperation AFHjNzPuXgRDLEAIHbWeDNNuByEoA;

	public long BytesTested => cbOwGryqwlfcMdmunFzdiUNfIAHmA;

	public ZipEntry Entry => jlkwCLtFnbtkXolcutIZfZkktyRE;

	public bool EntryValid => JNLftXdutlfGXxGwAfWrRWLwPXcR;

	public int ErrorCount => UkeffBkjbNHTOARBTrRsUVNDgHtS;

	public ZipFile File => sYGuCdoMNmPCMTqWkSaCgblckvOT;

	public TestOperation Operation => AFHjNzPuXgRDLEAIHbWeDNNuByEoA;

	public TestStatus(ZipFile file)
	{
		sYGuCdoMNmPCMTqWkSaCgblckvOT = file;
	}

	internal void vMnKaDxSRWCbXkMedSWQLOAsrcDwA()
	{
		UkeffBkjbNHTOARBTrRsUVNDgHtS++;
		JNLftXdutlfGXxGwAfWrRWLwPXcR = false;
	}

	internal void mQbsCOstuciNHDdWGBdEKdeffhkF(long value)
	{
		cbOwGryqwlfcMdmunFzdiUNfIAHmA = value;
	}

	internal void VWczLRxkaDJBCdXStllZJiRsBpnZ(ZipEntry entry)
	{
		jlkwCLtFnbtkXolcutIZfZkktyRE = entry;
		JNLftXdutlfGXxGwAfWrRWLwPXcR = true;
		cbOwGryqwlfcMdmunFzdiUNfIAHmA = 0L;
	}

	internal void wIHSnlsOnWcmBRTUGkJqXgowUytH(TestOperation operation)
	{
		AFHjNzPuXgRDLEAIHbWeDNNuByEoA = operation;
	}
}
