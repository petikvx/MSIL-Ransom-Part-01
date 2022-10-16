using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ReponseUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseUtils()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceRef()
	{
	}
}
