using System;

namespace ICSharpCode.SharpZipLib.Core;

public class ScanFailureEventArgs : EventArgs
{
	private bool nPreNlszaOiKdPricjwweQSuQLgV;

	private Exception qRsAlZEcDZSddwJVfgXcORuzIOkkA;

	private string sHzRvUailBFDiYKMmGMjRZIxxzc;

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

	public Exception Exception => qRsAlZEcDZSddwJVfgXcORuzIOkkA;

	public string Name => sHzRvUailBFDiYKMmGMjRZIxxzc;

	public ScanFailureEventArgs(string name, Exception exception_0)
	{
		sHzRvUailBFDiYKMmGMjRZIxxzc = name;
		qRsAlZEcDZSddwJVfgXcORuzIOkkA = exception_0;
		nPreNlszaOiKdPricjwweQSuQLgV = true;
	}
}
