using System;

namespace ICSharpCode.SharpZipLib.Core;

public class ProgressEventArgs : EventArgs
{
	private bool nPreNlszaOiKdPricjwweQSuQLgV = true;

	private string sHzRvUailBFDiYKMmGMjRZIxxzc;

	private long LlXQGpuGfElKdHfEXENmoThICdpV;

	private long JKMwcFqUKOUFfMXaIeoDCEmtuNRx;

	public bool ContinueRunning
	{
		get
		{
			return nPreNlszaOiKdPricjwweQSuQLgV;
		}
		set
		{
			nPreNlszaOiKdPricjwweQSuQLgV = value;
		}
	}

	public string Name => sHzRvUailBFDiYKMmGMjRZIxxzc;

	public float PercentComplete
	{
		get
		{
			if (JKMwcFqUKOUFfMXaIeoDCEmtuNRx > 0L)
			{
				return (float)LlXQGpuGfElKdHfEXENmoThICdpV / (float)JKMwcFqUKOUFfMXaIeoDCEmtuNRx * 100f;
			}
			return 0f;
		}
	}

	public long Processed => LlXQGpuGfElKdHfEXENmoThICdpV;

	public long Target => JKMwcFqUKOUFfMXaIeoDCEmtuNRx;

	public ProgressEventArgs(string name, long processed, long target)
	{
		sHzRvUailBFDiYKMmGMjRZIxxzc = name;
		LlXQGpuGfElKdHfEXENmoThICdpV = processed;
		JKMwcFqUKOUFfMXaIeoDCEmtuNRx = target;
	}
}
