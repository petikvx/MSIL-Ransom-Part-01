using System.Threading;
using YoutubeFeedUpdater.Classes;

namespace ns0;

internal class Class1 : ITask
{
	private readonly int int_0;

	public Class1(int int_1)
	{
		int_0 = int_1;
	}

	public void Run(TaskSystem taskSystem)
	{
		Thread.Sleep(int_0);
	}

	public override string ToString()
	{
		return "Sleeping " + int_0 + "ms.";
	}
}
