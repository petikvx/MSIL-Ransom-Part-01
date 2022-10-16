using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ResolverPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralDatabase()
	{
	}
}
