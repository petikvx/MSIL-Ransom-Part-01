using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MethodValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodValException()
	{
		WriterPropertyProducer.ResolveStub();
		DefineRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineRole()
	{
	}
}
