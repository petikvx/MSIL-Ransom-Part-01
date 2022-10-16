using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RoleReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralError()
	{
	}
}
