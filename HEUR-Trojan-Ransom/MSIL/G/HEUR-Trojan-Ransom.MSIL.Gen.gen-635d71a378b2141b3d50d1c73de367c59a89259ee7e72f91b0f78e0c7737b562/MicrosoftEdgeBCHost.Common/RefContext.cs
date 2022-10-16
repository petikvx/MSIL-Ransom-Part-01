using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RefContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefContext()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceTask()
	{
	}
}
