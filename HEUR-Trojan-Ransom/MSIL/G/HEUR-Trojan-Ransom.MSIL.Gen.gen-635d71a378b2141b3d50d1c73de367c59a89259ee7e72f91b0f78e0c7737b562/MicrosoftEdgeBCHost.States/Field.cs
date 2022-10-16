using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Field
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Field()
	{
		WriterPropertyProducer.ResolveStub();
		NewIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewIdentifier()
	{
	}
}
