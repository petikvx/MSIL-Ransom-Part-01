using System;

namespace ICSharpCode.SharpZipLib.Core;

public class ProgressEventArgs : EventArgs
{
	private bool cfdpmYMeyzmirebDvJdHUjVlcmtfA = true;

	private string tRVAXCmQaABtTkPdDStnZsUXXSwn;

	private long EFBvoQWHfxRLnmnjGBSZGzaBFWuS;

	private long AXMQpgCYmhzgndJHBvFwontykNYJ;

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

	public string Name => tRVAXCmQaABtTkPdDStnZsUXXSwn;

	public float PercentComplete
	{
		get
		{
			if (AXMQpgCYmhzgndJHBvFwontykNYJ <= 0L)
			{
				return 0f;
			}
			return (float)EFBvoQWHfxRLnmnjGBSZGzaBFWuS / (float)AXMQpgCYmhzgndJHBvFwontykNYJ * 100f;
		}
	}

	public long Processed => EFBvoQWHfxRLnmnjGBSZGzaBFWuS;

	public long Target => AXMQpgCYmhzgndJHBvFwontykNYJ;

	public ProgressEventArgs(string name, long processed, long target)
	{
		tRVAXCmQaABtTkPdDStnZsUXXSwn = name;
		EFBvoQWHfxRLnmnjGBSZGzaBFWuS = processed;
		AXMQpgCYmhzgndJHBvFwontykNYJ = target;
	}
}
