using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RequestFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetupPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupPrototype()
	{
	}
}
