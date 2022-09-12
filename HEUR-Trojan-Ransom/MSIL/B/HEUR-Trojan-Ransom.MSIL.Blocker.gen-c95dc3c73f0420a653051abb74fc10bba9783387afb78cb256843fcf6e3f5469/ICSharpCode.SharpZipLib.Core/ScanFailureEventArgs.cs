using System;

namespace ICSharpCode.SharpZipLib.Core;

public class ScanFailureEventArgs : EventArgs
{
	private bool cfdpmYMeyzmirebDvJdHUjVlcmtfA;

	private Exception zeJtqYCNuJelqpqcUORrjxyvqpG;

	private string tRVAXCmQaABtTkPdDStnZsUXXSwn;

	public bool ContinueRunning
	{
		get
		{
			return cfdpmYMeyzmirebDvJdHUjVlcmtfA;
		}
		set
		{
			cfdpmYMeyzmirebDvJdHUjVlcmtfA = value;
		}
	}

	public Exception Exception => zeJtqYCNuJelqpqcUORrjxyvqpG;

	public string Name => tRVAXCmQaABtTkPdDStnZsUXXSwn;

	public ScanFailureEventArgs(string name, Exception exception_0)
	{
		tRVAXCmQaABtTkPdDStnZsUXXSwn = name;
		zeJtqYCNuJelqpqcUORrjxyvqpG = exception_0;
		cfdpmYMeyzmirebDvJdHUjVlcmtfA = true;
	}
}
