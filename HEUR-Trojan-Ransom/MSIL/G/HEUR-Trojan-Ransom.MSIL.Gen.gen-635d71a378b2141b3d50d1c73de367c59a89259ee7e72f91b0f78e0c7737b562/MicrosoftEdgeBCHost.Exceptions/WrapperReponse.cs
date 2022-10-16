using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WrapperReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceBase()
	{
	}
}
