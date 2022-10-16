using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RuleFacade
{
	internal delegate void IteratorFacade(object o);

	internal static object singletonFacade;

	internal static object SelectLiteralMerchant;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralProc(int typemdt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RuleFacade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleFacade()
	{
		WriterPropertyProducer.ResolveStub();
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					singletonFacade = AlgoManager.CountMethod(PageManager.CountMethod(CustomerManager.CountMethod(typeof(RuleFacade).TypeHandle, CustomerManager.CancelMethod), PageManager.DestroyManager), AlgoManager.InitManager);
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					RegisterLiteralMerchant();
					num2 = 2;
					if (true)
					{
						continue;
					}
					break;
				case 1:
					ReadLiteralMerchant();
					num2 = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 2:
					EnableLiteralMerchant();
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DefineLiteralMerchant()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuleFacade StartLiteralMerchant()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralMerchant()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralMerchant()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralMerchant()
	{
	}
}
