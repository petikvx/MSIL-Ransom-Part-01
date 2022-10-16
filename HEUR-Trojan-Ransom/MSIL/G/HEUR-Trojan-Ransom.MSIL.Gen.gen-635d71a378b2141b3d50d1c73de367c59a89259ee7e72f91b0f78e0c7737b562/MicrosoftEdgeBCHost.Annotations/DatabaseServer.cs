using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DatabaseServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseServer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralContainer()
	{
	}
}
