using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CreatorWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceVal()
	{
	}
}
