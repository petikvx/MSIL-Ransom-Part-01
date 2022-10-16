using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AuthenticationFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationFacade()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralStruct()
	{
	}
}
