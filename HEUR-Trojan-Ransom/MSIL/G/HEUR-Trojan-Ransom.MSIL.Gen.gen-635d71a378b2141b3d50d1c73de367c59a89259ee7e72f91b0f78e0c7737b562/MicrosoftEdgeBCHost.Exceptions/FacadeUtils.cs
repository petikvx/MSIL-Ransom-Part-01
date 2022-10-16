using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FacadeUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeUtils()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceParser()
	{
	}
}
