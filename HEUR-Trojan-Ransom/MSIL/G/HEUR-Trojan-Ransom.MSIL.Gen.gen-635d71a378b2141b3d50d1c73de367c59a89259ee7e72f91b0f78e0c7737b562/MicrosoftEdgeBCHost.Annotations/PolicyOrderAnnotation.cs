using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PolicyOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralList()
	{
	}
}
