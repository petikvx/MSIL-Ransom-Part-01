using System.Threading;
using Swsokpjmjonftnmglzatftuh;
using wbem.Exporters;

namespace Ckytkvxxwmxrnwi.Bridges;

internal sealed class Importer<T> : wbem.Exporters.FactoryRecordExporter<T>
{
	private T @struct;

	private static object ComputeParams;

	public Importer()
	{
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_1f5f582734414dafae8dbb1d8c04b64e != 0)
		{
			switch (0)
			{
			}
		}
	}

	public void StopDispatcher(T last)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		Thread.Sleep(20000);
		@struct = last;
		ClassLibrary val = new ClassLibrary();
		val.Data();
	}

	public void InstantiateDispatcher()
	{
		int num = 1;
		while (true)
		{
			@struct = default(T);
			int num2 = 0;
			if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_4041a133a42b40928c0a2b76d8800ae4 != 0)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				break;
			default:
				return;
			case 0:
				return;
			}
		}
	}

	public T TestDispatcher()
	{
		return @struct;
	}

	internal static bool CollectParams()
	{
		return ComputeParams == null;
	}

	internal static object DestroyParams()
	{
		return ComputeParams;
	}
}
