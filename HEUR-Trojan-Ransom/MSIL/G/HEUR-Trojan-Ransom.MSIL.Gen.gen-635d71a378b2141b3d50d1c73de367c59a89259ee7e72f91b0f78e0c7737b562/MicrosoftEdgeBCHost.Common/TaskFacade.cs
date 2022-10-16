using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TaskFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralBase()
	{
	}
}
