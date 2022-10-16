using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RepositoryClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryClass()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceRegistry()
	{
	}
}
