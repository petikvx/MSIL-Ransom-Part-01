using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RulesClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesClass()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceWriter()
	{
	}
}
