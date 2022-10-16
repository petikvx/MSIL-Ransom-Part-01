using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WorkerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceListener()
	{
	}
}
