using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RoleUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceTests()
	{
	}
}
