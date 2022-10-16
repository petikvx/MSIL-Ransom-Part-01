using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TaskFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralProccesor()
	{
	}
}
