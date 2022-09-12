using System.Runtime.CompilerServices;

namespace ac.Messages;

public sealed class MessageCreatorMessage
{
	private string rule;

	private static MessageCreatorMessage DefineDic;

	public MessageCreatorMessage()
	{
		int num = 0;
		if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_12ab958156e942c383a45d6cbb243957 != 0)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public string ConcatMerchant()
	{
		return rule;
	}

	[SpecialName]
	[CompilerGenerated]
	public void UpdateMerchant(string task)
	{
		rule = task;
		int num = 1;
		if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_80309bb76e3044ecb7a195a305727c3b == 0)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	internal static bool LoginDic()
	{
		return DefineDic == null;
	}

	internal static MessageCreatorMessage IncludeDic()
	{
		return DefineDic;
	}
}
