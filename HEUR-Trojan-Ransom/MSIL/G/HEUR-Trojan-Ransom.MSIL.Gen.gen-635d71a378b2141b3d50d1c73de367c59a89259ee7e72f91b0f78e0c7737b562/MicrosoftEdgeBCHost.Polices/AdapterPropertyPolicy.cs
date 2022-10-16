using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdapterPropertyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterPropertyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralBase()
	{
	}
}
