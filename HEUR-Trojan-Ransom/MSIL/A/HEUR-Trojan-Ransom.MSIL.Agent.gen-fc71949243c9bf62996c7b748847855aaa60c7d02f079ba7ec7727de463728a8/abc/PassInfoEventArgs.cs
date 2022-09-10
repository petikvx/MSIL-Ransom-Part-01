using System;

namespace abc;

public class PassInfoEventArgs : EventArgs
{
	private readonly int cPass;

	private readonly int tPass;

	public int CurrentPass => cPass;

	public int TotalPasses => tPass;

	public PassInfoEventArgs(int currentPass, int totalPasses)
	{
		cPass = currentPass;
		tPass = totalPasses;
	}
}
