using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CreatorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorClass()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceFilter()
	{
	}
}
