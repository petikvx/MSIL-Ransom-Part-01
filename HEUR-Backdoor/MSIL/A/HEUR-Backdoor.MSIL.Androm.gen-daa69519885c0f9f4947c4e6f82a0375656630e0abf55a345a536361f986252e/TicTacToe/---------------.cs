using System.Collections.ObjectModel;
using 嫷嫾嫷嫽嬮嫵嬨嬪嫻嫽嬹嫵嫷嫼嬬;

namespace TicTacToe;

internal class _E863_E86C_E863_E896_E87F_E863_E85C_E893_E86E_E85A_E890_E890_E85E_E863_E863
{
	public bool _EDB0_ED9C_ED7E_ED7F_ED83_EDB1_EDC8_EDB9_ED8F_ED84_EDB4_EDB0_EDB3_EDB0_ED85(ObservableCollection<ObservableCollection<ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊>> 됴됛됕된됕됞둓됞됝둛됧됛둊둉됰, ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊 _2DEBⷍ_2DE9_2DF0ⶸⶺⶾ_2DEE_2DE9ⷁⷔ_2DEDⶸⷉⶾ)
	{
		//Discarded unreachable code: IL_000e, IL_001e, IL_0020, IL_0027, IL_0051, IL_0055, IL_005c, IL_006c
		//IL_000e: Ignored invalid 'constrained' prefix
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (num4 < 됴됛됕된됕됞둓됞됝둛됧됛둊둉됰.Count)
		{
			/*Error near IL_000c: Could not find block for branch target IL_0014*/;
		}
		for (int i = 0; i < 됴됛됕된됕됞둓됞됝둛됧됛둊둉됰.Count; i++)
		{
			if (num2 == 3)
			{
				break;
			}
			num2 = 0;
			for (int j = 0; j < 됴됛됕된됕됞둓됞됝둛됧됛둊둉됰.Count; j++)
			{
				if (됴됛됕된됕됞둓됞됝둛됧됛둊둉됰[j][i].Equals(_2DEBⷍ_2DE9_2DF0ⶸⶺⶾ_2DEE_2DE9ⷁⷔ_2DEDⶸⷉⶾ))
				{
					num2++;
				}
			}
		}
		for (int k = 0; k < 됴됛됕된됕됞둓됞됝둛됧됛둊둉됰.Count; k++)
		{
			if (됴됛됕된됕됞둓됞됝둛됧됛둊둉됰[k][k].Equals(_2DEBⷍ_2DE9_2DF0ⶸⶺⶾ_2DEE_2DE9ⷁⷔ_2DEDⶸⷉⶾ))
			{
				num3++;
			}
		}
		if (num3 != 3)
		{
			num3 = 0;
			for (int l = 0; l < 됴됛됕된됕됞둓됞됝둛됧됛둊둉됰.Count; l++)
			{
				if (됴됛됕된됕됞둓됞됝둛됧됛둊둉됰[l][됴됛됕된됕됞둓됞됝둛됧됛둊둉됰.Count - 1 - l].Equals(_2DEBⷍ_2DE9_2DF0ⶸⶺⶾ_2DEE_2DE9ⷁⷔ_2DEDⶸⷉⶾ))
				{
					num3++;
				}
			}
		}
		return num == 3 || num2 == 3 || num3 == 3;
	}
}
