using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RepositoryValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceFactory()
	{
	}
}
