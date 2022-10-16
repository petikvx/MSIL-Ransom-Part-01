using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CodeValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PopItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopItem()
	{
	}
}
