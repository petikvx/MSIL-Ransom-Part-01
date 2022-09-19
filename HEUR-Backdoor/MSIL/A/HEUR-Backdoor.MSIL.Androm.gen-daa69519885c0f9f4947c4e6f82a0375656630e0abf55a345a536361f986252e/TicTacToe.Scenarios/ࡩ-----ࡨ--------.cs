using TicTacToe.Players;
using 動勔匁勑勢勥勔勡勿勒匁匁勽勯募;
using 嫷嫾嫷嫽嬮嫵嬨嬪嫻嫽嬹嫵嫷嫼嬬;
using _EDEE_EDEF_EDDA_EDC2_EDDC_EDE6_EDD5_EDBD_EDF1_EDEF_EDF0_EDFC_EDD8_EDF3_EDF2;

namespace TicTacToe.Scenarios;

internal class ࡩ_086B_0878_086C_083B_083Bࡨ_083F_086B_083B_086D_086C_0879_086C_083A : IGameScenario
{
	private IPlayer 퇢퇏툌퇘퇓툅퇖툗퇑툄툂퇓퇨퇥퇕;

	private IPlayer ힲ흵힟흴_D7AC흵힟_D7A7힠흮힢흭흳힞_D7AA;

	private IPlayer 沲泰泞沭泟沬泞波泐沩泥泱沭沮泫;

	public ࡩ_086B_0878_086C_083B_083Bࡨ_083F_086B_083B_086D_086C_0879_086C_083A(_2F33_2F2E_2F36_2F30_2F63_2F65_2F36_2F62_2F2E_2F2E_2F64_2F48_2F75_2F60_2F33 playerFactory, ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊 player)
	{
		퇢퇏툌퇘퇓툅퇖툗퇑툄툂퇓퇨퇥퇕 = playerFactory.䆞䆰䆤䆤䇑䆥䇔䇑䆠䇃䆡䇓䇔䆴䆞();
		ힲ흵힟흴_D7AC흵힟_D7A7힠흮힢흭흳힞_D7AA = playerFactory.贅贆贁贉贚贊贛贳贊贕贲贷贅贆贪();
		퇢퇏툌퇘퇓툅퇖툗퇑툄툂퇓퇨퇥퇕.Player = player;
		ힲ흵힟흴_D7AC흵힟_D7A7힠흮힢흭흳힞_D7AA.Player = ((player == ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊._F4F6_F4F6_F50E_F4DC_F4C4_F4FA_F4F6_F4F6_F4CB_F4C5_F4CC_F4F6_F4C9_F4C6_F4CD) ? ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊._F289_F28D_F29E_F2B7_F2BC_F28E_F2B7_F28D_F2CE_F2A3_F28B_F28C_F28E_F2BB_F28E : ݣޑݿޣݣޑޝݟݠݜޚލݟݞݟ.둲둭뒄뒟뒞둩둾둫둫둫둲둻둯둫뒊._F4F6_F4F6_F50E_F4DC_F4C4_F4FA_F4F6_F4F6_F4CB_F4C5_F4CC_F4F6_F4C9_F4C6_F4CD);
	}

	public _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD 扃戢懼戱戯戝懽戮戬戲懻戰戲戰戬(䢨䡶䢯䢦䡼䢩䢩䢫䢶䡺䢞䡷䡽䢧䢩 㷁㶖㶒㶣㶗㷀㶏㶓㷍㷃㶐㷘㶗㷏㷀)
	{
		//Discarded unreachable code: IL_003f, IL_0052, IL_005c, IL_006f, IL_0077, IL_007d, IL_00a3, IL_00a7
		//IL_003f: Ignored invalid 'constrained' prefix
		沲泰泞沭泟沬泞波泐沩泥泱沭沮泫 = ((沲泰泞沭泟沬泞波泐沩泥泱沭沮泫 != null && 沲泰泞沭泟沬泞波泐沩泥泱沭沮泫.Equals(퇢퇏툌퇘퇓툅퇖툗퇑툄툂퇓퇨퇥퇕)) ? ힲ흵힟흴_D7AC흵힟_D7A7힠흮힢흭흳힞_D7AA : 퇢퇏툌퇘퇓툅퇖툗퇑툄툂퇓퇨퇥퇕);
		_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD = 沲泰泞沭泟沬泞波泐沩泥泱沭沮泫.Play(㷁㶖㶒㶣㶗㷀㶏㶓㷍㷃㶐㷘㶗㷏㷀);
		/*Error near IL_003d: Could not find block for branch target IL_0045*/;
	}
}
