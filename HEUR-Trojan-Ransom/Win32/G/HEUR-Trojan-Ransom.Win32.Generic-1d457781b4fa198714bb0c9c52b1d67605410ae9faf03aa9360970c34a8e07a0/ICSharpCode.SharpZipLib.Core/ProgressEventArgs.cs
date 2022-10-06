using System;

namespace ICSharpCode.SharpZipLib.Core;

public class ProgressEventArgs : EventArgs
{
	private string name_;

	private long processed_;

	private long target_;

	private bool continueRunning_ = true;

	public string Name => name_;

	public bool ContinueRunning
	{
		get
		{
			return continueRunning_;
		}
		set
		{
			continueRunning_ = value;
		}
	}

	public float PercentComplete
	{
		get
		{
			if (target_ <= 0L)
			{
				return 0f;
			}
			return (float)processed_ / (float)target_ * 100f;
		}
	}

	public long Processed => processed_;

	public long Target => target_;

	public ProgressEventArgs(string name, long processed, long target)
	{
		name_ = name;
		processed_ = processed;
		target_ = target;
	}
}
