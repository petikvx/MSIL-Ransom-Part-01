using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DefineProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineProperty()
	{
	}
}
