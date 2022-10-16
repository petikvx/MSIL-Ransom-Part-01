using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RoleAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralFactory()
	{
	}
}
