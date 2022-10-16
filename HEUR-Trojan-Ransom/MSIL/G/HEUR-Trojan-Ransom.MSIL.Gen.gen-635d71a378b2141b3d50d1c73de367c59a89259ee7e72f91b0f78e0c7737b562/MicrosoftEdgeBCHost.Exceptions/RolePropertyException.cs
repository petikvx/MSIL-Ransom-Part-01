using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RolePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RolePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralInfo()
	{
	}
}
