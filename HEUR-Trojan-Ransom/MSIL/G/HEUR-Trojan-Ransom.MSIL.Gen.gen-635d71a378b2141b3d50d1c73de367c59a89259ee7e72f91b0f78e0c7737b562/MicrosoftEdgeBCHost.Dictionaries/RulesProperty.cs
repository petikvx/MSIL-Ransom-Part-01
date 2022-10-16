using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RulesProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesProperty()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceProccesor()
	{
	}
}
