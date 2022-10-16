using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceWriter()
	{
	}
}
