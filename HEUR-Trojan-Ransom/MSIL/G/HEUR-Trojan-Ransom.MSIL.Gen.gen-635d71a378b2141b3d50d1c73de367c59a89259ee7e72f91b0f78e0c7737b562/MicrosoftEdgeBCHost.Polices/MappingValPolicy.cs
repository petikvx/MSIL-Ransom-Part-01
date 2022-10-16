using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MappingValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceGetter()
	{
	}
}
