using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClassValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatRole()
	{
	}
}
