using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComposerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralRepository()
	{
	}
}
