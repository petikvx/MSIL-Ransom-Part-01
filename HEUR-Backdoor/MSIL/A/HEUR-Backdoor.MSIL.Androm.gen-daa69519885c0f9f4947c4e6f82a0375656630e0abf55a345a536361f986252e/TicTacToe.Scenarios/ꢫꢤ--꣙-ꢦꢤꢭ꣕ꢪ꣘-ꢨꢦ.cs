using TicTacToe.Players;
using 動勔匁勑勢勥勔勡勿勒匁匁勽勯募;
using 嫷嫾嫷嫽嬮嫵嬨嬪嫻嫽嬹嫵嫷嫼嬬;
using _EDEE_EDEF_EDDA_EDC2_EDDC_EDE6_EDD5_EDBD_EDF1_EDEF_EDF0_EDFC_EDD8_EDF3_EDF2;

namespace TicTacToe.Scenarios;

internal class ꢫꢤ_A8B8_A8EC꣙_A8C2ꢦꢤꢭ꣕ꢪ꣘_A8BCꢨꢦ : IGameScenario
{
	private IPlayer ꚲꚵꛥꛣꚷꛍꚶꚳꛤꛠꛠꛡ_A6E6ꚵꛡ;

	private IPlayer _ED1A_ECF3_ECF4_ECF5_ED31_ED38_ECF5_ED01_ECF4_ECF8_ECF2_ECF9_ECF4_ECF9_ED2E;

	private IPlayer 斜斆斉敮文敛敻敖斉敘敨敳斆斍敖;

	public ꢫꢤ_A8B8_A8EC꣙_A8C2ꢦꢤꢭ꣕ꢪ꣘_A8BCꢨꢦ(_2F33_2F2E_2F36_2F30_2F63_2F65_2F36_2F62_2F2E_2F2E_2F64_2F48_2F75_2F60_2F33 playerFactory, ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊 player)
	{
		ꚲꚵꛥꛣꚷꛍꚶꚳꛤꛠꛠꛡ_A6E6ꚵꛡ = playerFactory.䆞䆰䆤䆤䇑䆥䇔䇑䆠䇃䆡䇓䇔䆴䆞();
		_ED1A_ECF3_ECF4_ECF5_ED31_ED38_ECF5_ED01_ECF4_ECF8_ECF2_ECF9_ECF4_ECF9_ED2E = playerFactory.䆞䆰䆤䆤䇑䆥䇔䇑䆠䇃䆡䇓䇔䆴䆞();
		ꚲꚵꛥꛣꚷꛍꚶꚳꛤꛠꛠꛡ_A6E6ꚵꛡ.Player = player;
		_ED1A_ECF3_ECF4_ECF5_ED31_ED38_ECF5_ED01_ECF4_ECF8_ECF2_ECF9_ECF4_ECF9_ED2E.Player = ((player == ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊._F4F6_F4F6_F50E_F4DC_F4C4_F4FA_F4F6_F4F6_F4CB_F4C5_F4CC_F4F6_F4C9_F4C6_F4CD) ? ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊._F289_F28D_F29E_F2B7_F2BC_F28E_F2B7_F28D_F2CE_F2A3_F28B_F28C_F28E_F2BB_F28E : ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊._F4F6_F4F6_F50E_F4DC_F4C4_F4FA_F4F6_F4F6_F4CB_F4C5_F4CC_F4F6_F4C9_F4C6_F4CD);
	}

	public _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD 빂빬븷븴빫븷븹븹빥븴빢븲빤빤빥(䢨䡶䢯䢦䡼䢩䢩䢫䢶䡺䢞䡷䡽䢧䢩 塘堶堬塕堩塃塔堨堩塛堵堥塆堬堵)
	{
		//Discarded unreachable code: IL_003f, IL_0049
		//IL_003f: Ignored invalid 'constrained' prefix
		斜斆斉敮文敛敻敖斉敘敨敳斆斍敖 = ((斜斆斉敮文敛敻敖斉敘敨敳斆斍敖 != null && 斜斆斉敮文敛敻敖斉敘敨敳斆斍敖.Equals(ꚲꚵꛥꛣꚷꛍꚶꚳꛤꛠꛠꛡ_A6E6ꚵꛡ)) ? _ED1A_ECF3_ECF4_ECF5_ED31_ED38_ECF5_ED01_ECF4_ECF8_ECF2_ECF9_ECF4_ECF9_ED2E : ꚲꚵꛥꛣꚷꛍꚶꚳꛤꛠꛠꛡ_A6E6ꚵꛡ);
		_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD = 斜斆斉敮文敛敻敖斉敘敨敳斆斍敖.Play(塘堶堬塕堩塃塔堨堩塛堵堥塆堬堵);
		/*Error near IL_003d: Could not find block for branch target IL_0045*/;
	}
}
