using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CreatorFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorFacade()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralStruct()
	{
	}
}
