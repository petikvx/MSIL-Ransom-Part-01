using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FactoryObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryObject()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralParams()
	{
	}
}
