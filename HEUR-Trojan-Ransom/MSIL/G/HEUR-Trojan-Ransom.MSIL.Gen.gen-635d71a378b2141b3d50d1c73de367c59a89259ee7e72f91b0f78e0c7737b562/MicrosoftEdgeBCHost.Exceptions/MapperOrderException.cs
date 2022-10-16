using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapperOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceParam()
	{
	}
}
