using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PolicyGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceSchema()
	{
	}
}
