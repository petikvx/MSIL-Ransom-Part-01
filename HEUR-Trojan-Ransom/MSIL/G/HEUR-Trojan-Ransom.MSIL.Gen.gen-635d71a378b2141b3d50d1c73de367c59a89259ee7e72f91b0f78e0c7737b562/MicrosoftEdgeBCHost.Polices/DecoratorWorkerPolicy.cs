using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DecoratorWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceDatabase()
	{
	}
}
