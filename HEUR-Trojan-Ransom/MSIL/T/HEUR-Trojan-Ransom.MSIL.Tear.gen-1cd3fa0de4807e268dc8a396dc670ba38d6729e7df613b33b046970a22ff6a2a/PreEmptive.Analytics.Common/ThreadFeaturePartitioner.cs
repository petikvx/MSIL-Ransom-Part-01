using System.Threading;

namespace PreEmptive.Analytics.Common;

public sealed class ThreadFeaturePartitioner : IFeaturePartitioner
{
	public string GetPartition()
	{
		int num = 31072;
		int num2 = num;
		num = 31072;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return Thread.CurrentThread.ManagedThreadId.ToString();
		}
	}
}
