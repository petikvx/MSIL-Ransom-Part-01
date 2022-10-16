using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TaskDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralProcess()
	{
	}
}
