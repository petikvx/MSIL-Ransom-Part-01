using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ResolverContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverContext()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceSpecification()
	{
	}
}
