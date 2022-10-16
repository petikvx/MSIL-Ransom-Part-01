using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MappingContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingContext()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceSpecification()
	{
	}
}
