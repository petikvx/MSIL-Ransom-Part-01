using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ModelWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutTest()
	{
	}
}
