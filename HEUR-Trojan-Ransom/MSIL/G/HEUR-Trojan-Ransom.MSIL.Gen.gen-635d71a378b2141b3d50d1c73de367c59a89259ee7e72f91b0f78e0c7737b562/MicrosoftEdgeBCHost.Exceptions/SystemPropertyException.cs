using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SystemPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralAuthentication()
	{
	}
}
