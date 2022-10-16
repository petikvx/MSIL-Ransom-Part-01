using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RefOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralRecord()
	{
	}
}
