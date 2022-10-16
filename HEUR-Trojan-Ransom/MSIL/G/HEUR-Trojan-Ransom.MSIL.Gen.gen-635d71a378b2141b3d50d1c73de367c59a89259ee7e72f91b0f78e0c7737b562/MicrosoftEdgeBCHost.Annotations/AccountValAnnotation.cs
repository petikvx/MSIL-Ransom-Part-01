using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AccountValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceFilter()
	{
	}
}
