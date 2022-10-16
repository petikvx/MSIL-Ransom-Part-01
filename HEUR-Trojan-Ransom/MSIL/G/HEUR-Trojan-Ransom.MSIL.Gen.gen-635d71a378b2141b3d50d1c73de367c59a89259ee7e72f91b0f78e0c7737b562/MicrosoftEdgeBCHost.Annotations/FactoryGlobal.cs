using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FactoryGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceTemplate()
	{
	}
}
