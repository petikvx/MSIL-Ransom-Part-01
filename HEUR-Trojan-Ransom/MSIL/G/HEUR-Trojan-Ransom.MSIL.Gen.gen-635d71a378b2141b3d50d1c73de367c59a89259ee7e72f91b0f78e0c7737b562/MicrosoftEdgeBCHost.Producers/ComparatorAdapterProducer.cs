using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComparatorAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralRole()
	{
	}
}
