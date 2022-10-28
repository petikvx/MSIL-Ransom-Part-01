using System.Diagnostics;

namespace Ckytkvxxwmxrnwi.Configurations;

internal struct ObjectFilterConfig
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int m_Mock;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int m_List;

	internal static object CloneParams;

	public int PopDispatcher()
	{
		return m_Mock;
	}

	public void PushDispatcher(int config_amount)
	{
		m_Mock = config_amount;
		int num = 0;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_16ffce52055d45d9a1b1f5bf30e502e0 == 0)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public int LogoutDispatcher()
	{
		return m_List;
	}

	public void ForgotDispatcher(int sum_setup)
	{
		m_List = sum_setup;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_2442a4506be54238bb04d788303ff71e != 0)
		{
			switch (1)
			{
			}
		}
	}

	public void SelectDispatcher()
	{
		PushDispatcher(0);
		ForgotDispatcher(0);
		int num = 1;
		if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_4c227cc67f004e2a8e0897eea4eb605e != 0)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	internal static bool ManageParams()
	{
		return CloneParams == null;
	}

	internal static object GetParams()
	{
		return CloneParams;
	}
}
