using System;
using System.Collections.Generic;
using System.Text;
using SimpleJSON;

namespace Cytotechnologist;

public class Game
{
	public readonly Rules Rules;

	public readonly Player[] Players;

	private readonly PlayerState[] _playerStates;

	private readonly Dice _dice;

	private List<Card> _deck;

	public readonly List<int> Winners = new List<int>();

	public readonly List<int> Losers = new List<int>();

	private int _currentPlayer = 2147483645;

	private int _currentTurn;

	private List<float> _chances;

	private readonly Random _random;

	private readonly StringBuilder _buffer;

	private bool _finished;

	private int _currentChanceIndex;

	public bool Finished
	{
		get
		{
			bool finished = _finished;
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool result = default(bool);
			bool flag = default(bool);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = -2076733104;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x90B5D259u) % 13u)
					{
					case 12u:
						playerStates = _playerStates;
						num3 = 0;
						num = -193245913;
						continue;
					case 11u:
						result = true;
						num = (int)(num2 * 1112569904) ^ -1917111612;
						continue;
					case 10u:
						flag = playerState.State == State.Playing;
						num = ((int)num2 * -1280876041) ^ -310554775;
						continue;
					case 9u:
						num3++;
						num = -193245913;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (finished)
						{
							num5 = 1096393760;
							num6 = 1096393760;
						}
						else
						{
							num5 = 321173108;
							num6 = 321173108;
						}
						num = num5 ^ ((int)num2 * -443530462);
						continue;
					}
					case 7u:
						playerState = playerStates[num3];
						num = -335222979;
						continue;
					case 5u:
						result = false;
						num = (int)((num2 * 1699138468) ^ 0x5FDE9CCB);
						continue;
					case 3u:
					{
						int num7;
						int num8;
						if (!flag)
						{
							num7 = 2057947771;
							num8 = 2057947771;
						}
						else
						{
							num7 = 1067665981;
							num8 = 1067665981;
						}
						num = num7 ^ ((int)num2 * -977815928);
						continue;
					}
					case 2u:
						num = (int)((num2 * 1491194038) ^ 0x4849E5B8);
						continue;
					case 1u:
						result = true;
						num = ((int)num2 * -684086212) ^ -87250044;
						continue;
					case 0u:
					{
						int num4;
						if (num3 < playerStates.Length)
						{
							num = -343710639;
							num4 = -343710639;
						}
						else
						{
							num = -678894411;
							num4 = -678894411;
						}
						continue;
					}
					case 4u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		bool flag2 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int count = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 953144491;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73214E84u) % 18u)
				{
				case 17u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1708270375;
						num8 = -1708270375;
					}
					else
					{
						num7 = -1737802788;
						num8 = -1737802788;
					}
					num = num7 ^ (int)(num2 * 1598389033);
					continue;
				}
				case 16u:
					num4++;
					num = ((int)num2 * -2051595812) ^ 0x377445CE;
					continue;
				case 15u:
					num = ((int)num2 * -943883310) ^ -1585184148;
					continue;
				case 13u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = 6535006;
					continue;
				case 12u:
					flag2 = num4 < count;
					num = 193146069;
					continue;
				case 11u:
					_playerStates = new PlayerState[count];
					num = (int)(num2 * 497039401) ^ -1051081641;
					continue;
				case 10u:
					flag = num3 < count;
					num = 1191985640;
					continue;
				case 9u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					Players = new Player[count];
					num = ((int)num2 * -1570618880) ^ 0x67320047;
					continue;
				case 8u:
					num4 = 0;
					num = (int)((num2 * 2130647821) ^ 0x15AC50CA);
					continue;
				case 7u:
					_buffer = buffer;
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = (int)(num2 * 1691924642) ^ -2145870344;
					continue;
				case 6u:
					_dice = new Dice();
					num = (int)((num2 * 943719674) ^ 0x40381B9);
					continue;
				case 5u:
					num3 = 0;
					num = (int)((num2 * 1653304774) ^ 0x7D1F2557);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1017428701;
						num6 = -1017428701;
					}
					else
					{
						num5 = -1280755517;
						num6 = -1280755517;
					}
					num = num5 ^ (int)(num2 * 1849773188);
					continue;
				}
				case 3u:
					_playerStates[num4] = new PlayerState();
					num = 154527482;
					continue;
				case 1u:
					num = (int)((num2 * 1125440167) ^ 0x79B1EAB0);
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 318346652) ^ -379267226;
					continue;
				default:
					return;
				case 14u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void ShuffleCards()
	{
		while (true)
		{
			int num = -847445658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83C0A43Au) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				_deck = new List<Card>(Rules.Cards);
				num = ((int)num2 * -2143357225) ^ -2140434907;
			}
		}
	}

	public void StartNew()
	{
		ShuffleCards();
		while (true)
		{
			int num = -1813710977;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7E9DB0Eu) % 9u)
				{
				case 7u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					_finished = false;
					num = (int)((num2 * 1944078487) ^ 0x5357242B);
					continue;
				case 5u:
					Winners.Clear();
					num = (int)((num2 * 363269360) ^ 0x67AED5E2);
					continue;
				case 4u:
					num = (int)((num2 * 1782234594) ^ 0x685C6FA9);
					continue;
				case 3u:
					num = ((int)num2 * -1618530668) ^ 0x446AC70B;
					continue;
				case 2u:
					_currentChanceIndex = -1;
					num = ((int)num2 * -244553013) ^ 0x1A842471;
					continue;
				case 1u:
					Losers.Clear();
					num = (int)((num2 * 985971856) ^ 0x38B0444B);
					continue;
				case 0u:
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -462350833) ^ -291623732;
					continue;
				default:
					return;
				case 8u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		PlayerState playerState = default(PlayerState);
		bool flag3 = default(bool);
		bool flag = default(bool);
		int num3 = default(int);
		Player player = default(Player);
		int num6 = default(int);
		bool flag2 = default(bool);
		int planningCardsCount = default(int);
		bool useOneMorePlanningSprint = default(bool);
		while (true)
		{
			int num = 31781566;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x424F8A2Bu) % 26u)
				{
				case 25u:
					playerState.Sprint = 1;
					num = (int)(num2 * 1213045926) ^ -950678501;
					continue;
				case 24u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = -108616037;
						num12 = -108616037;
					}
					else
					{
						num11 = -599196502;
						num12 = -599196502;
					}
					num = num11 ^ ((int)num2 * -1981819447);
					continue;
				}
				case 23u:
					flag = num3 > 0;
					num = 1347646455;
					continue;
				case 22u:
					player = Players[num6];
					playerState = _playerStates[num6];
					num = ((int)num2 * -1918459815) ^ 0x6CF10EC;
					continue;
				case 21u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = ((int)num2 * -1408661833) ^ -1782198782;
					continue;
				case 20u:
					num = ((int)num2 * -1077070932) ^ -743402976;
					continue;
				case 19u:
					flag3 = num6 < Players.Length;
					num = 1050846323;
					continue;
				case 18u:
					flag2 = planningCardsCount == 0;
					num = ((int)num2 * -312236498) ^ 0x463F8A66;
					continue;
				case 17u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 336130997;
						num10 = 336130997;
					}
					else
					{
						num9 = 1927280788;
						num10 = 1927280788;
					}
					num = num9 ^ (int)(num2 * 24608828);
					continue;
				}
				case 16u:
					playerState.Sprint = -1;
					num = ((int)num2 * -342094085) ^ -1177322042;
					continue;
				case 15u:
					num6 = 0;
					num = ((int)num2 * -2072362511) ^ -1185083943;
					continue;
				case 14u:
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num3 = 0;
					num = ((int)num2 * -891857179) ^ -754828791;
					continue;
				case 13u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					num = ((int)num2 * -1249208353) ^ 0x27E035B6;
					continue;
				case 12u:
					num = ((int)num2 * -1743613138) ^ -1027995245;
					continue;
				case 11u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num6++;
					num = 810636444;
					continue;
				case 10u:
					num = 1392535544;
					continue;
				case 9u:
					num = 2099988977;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (useOneMorePlanningSprint)
					{
						num7 = -571614947;
						num8 = -571614947;
					}
					else
					{
						num7 = -918881822;
						num8 = -918881822;
					}
					num = num7 ^ ((int)num2 * -1619496365);
					continue;
				}
				case 5u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -33258089) ^ 0x65FE09A0;
					continue;
				case 4u:
					num3 = 0;
					num = 836660409;
					continue;
				case 3u:
					num = (int)(num2 * 1908538912) ^ -1770957671;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -885131578;
						num5 = -885131578;
					}
					else
					{
						num4 = -2081108491;
						num5 = -2081108491;
					}
					num = num4 ^ ((int)num2 * -306387548);
					continue;
				}
				case 1u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = ((int)num2 * -1153042626) ^ -1966718364;
					continue;
				case 0u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = 582578386;
					continue;
				default:
					return;
				case 7u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		bool flag = _currentPlayer >= Players.Length;
		bool flag2 = default(bool);
		while (true)
		{
			int num = 332507324;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC52713Du) % 14u)
				{
				case 13u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 1842088743) ^ -15920389;
					continue;
				case 12u:
					num = ((int)num2 * -2038607881) ^ -978868146;
					continue;
				case 11u:
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -1243534990) ^ 0x67A6E8D5;
					continue;
				case 10u:
					num = ((int)num2 * -993208253) ^ -610565848;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 797058682;
						num6 = 797058682;
					}
					else
					{
						num5 = 1859073005;
						num6 = 1859073005;
					}
					num = num5 ^ (int)(num2 * 553503909);
					continue;
				}
				case 7u:
					num = (int)(num2 * 149862267) ^ -1892287520;
					continue;
				case 6u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 969401099;
					continue;
				case 5u:
					PlayerTurn(_currentPlayer);
					num = 1834218006;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 2119218899;
						num4 = 2119218899;
					}
					else
					{
						num3 = 347090665;
						num4 = 347090665;
					}
					num = num3 ^ ((int)num2 * -45424671);
					continue;
				}
				case 3u:
					_currentPlayer = 0;
					num = ((int)num2 * -2051869352) ^ 0x3445332A;
					continue;
				case 2u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)(num2 * 416024903) ^ -976030958;
					continue;
				case 0u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1051240111) ^ -700468249;
					continue;
				default:
					return;
				case 8u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		PlayerState playerState = default(PlayerState);
		int num19 = default(int);
		int num4 = default(int);
		Card card = default(Card);
		bool flag7 = default(bool);
		int num9 = default(int);
		bool flag3 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag9 = default(bool);
		bool flag8 = default(bool);
		bool flag = default(bool);
		bool flag5 = default(bool);
		int num3 = default(int);
		Player player = default(Player);
		bool flag13 = default(bool);
		bool flag11 = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = -754743363;
			while (true)
			{
				uint num2;
				int num29;
				switch ((num2 = (uint)num ^ 0xE9661797u) % 88u)
				{
				case 87u:
					playerState.Resources -= Game.smethod_3(0, num19 - Players[num4].PlannedForCard(card.Type));
					flag7 = playerState.Resources >= 0;
					num = ((int)num2 * -261023672) ^ -864630544;
					continue;
				case 86u:
					num9 = 0;
					num = (int)((num2 * 655431526) ^ 0x5BD915A8);
					continue;
				case 85u:
					flag3 = playerState2.Sprint > Rules.SprintCount;
					num = -851523518;
					continue;
				case 84u:
					num = -2017484848;
					continue;
				case 83u:
					num = ((int)num2 * -1345397261) ^ 0x1C023AE6;
					continue;
				case 82u:
					num29 = ((card.Type == 4) ? 1 : 0);
					goto IL_00b0;
				case 81u:
					playerState.State = State.Lose;
					num = -990016761;
					continue;
				case 80u:
				{
					int num28;
					if (Losers.Contains(num9))
					{
						num = -1553895493;
						num28 = -1553895493;
					}
					else
					{
						num = -689597158;
						num28 = -689597158;
					}
					continue;
				}
				case 79u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag9 ? "ALL " : "", flag8 ? "receives" : "pays", Game.smethod_4(num19), flag ? "advance" : "stay");
					num = -1978508911;
					continue;
				case 78u:
					num = (int)(num2 * 618497103) ^ -65513797;
					continue;
				case 77u:
					num = -1268390289;
					continue;
				case 76u:
				{
					int num11;
					int num12;
					if (!flag5)
					{
						num11 = 1234036782;
						num12 = 1234036782;
					}
					else
					{
						num11 = 1309765806;
						num12 = 1309765806;
					}
					num = num11 ^ (int)(num2 * 825946958);
					continue;
				}
				case 75u:
					Winners.Add(playerIndex);
					num = (int)((num2 * 2079611074) ^ 0x121C5A23);
					continue;
				case 74u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -2142099062) ^ 0x7880B2A9;
						continue;
					}
					num29 = 0;
					goto IL_00b0;
				case 73u:
					num = (int)((num2 * 1344726210) ^ 0x13EA018A);
					continue;
				case 72u:
					num3 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)(num2 * 186724167) ^ -180191042;
					continue;
				case 71u:
				{
					int num30;
					int num31;
					if (flag13)
					{
						num30 = 179535207;
						num31 = 179535207;
					}
					else
					{
						num30 = 486028043;
						num31 = 486028043;
					}
					num = num30 ^ (int)(num2 * 1154813824);
					continue;
				}
				case 70u:
					num = (int)(num2 * 917093996) ^ -457489589;
					continue;
				case 69u:
					Losers.Add(playerIndex);
					num = (int)(num2 * 734637) ^ -209427732;
					continue;
				case 68u:
				{
					int num22;
					int num23;
					if (!flag11)
					{
						num22 = 1695971192;
						num23 = 1695971192;
					}
					else
					{
						num22 = 2027461709;
						num23 = 2027461709;
					}
					num = num22 ^ ((int)num2 * -379055702);
					continue;
				}
				case 67u:
					flag2 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1676599773) ^ -806667203;
					continue;
				case 66u:
					num = ((int)num2 * -956399568) ^ 0x49C07871;
					continue;
				case 65u:
					num = (int)(num2 * 990679000) ^ -996488772;
					continue;
				case 64u:
					flag11 = playerState2.State != State.Playing;
					num = ((int)num2 * -356787550) ^ 0x68FD7F33;
					continue;
				case 63u:
				{
					int num15;
					int num16;
					if (flag7)
					{
						num15 = 790151648;
						num16 = 790151648;
					}
					else
					{
						num15 = 2072810943;
						num16 = 2072810943;
					}
					num = num15 ^ (int)(num2 * 799575727);
					continue;
				}
				case 62u:
					num = (int)((num2 * 1641638428) ^ 0x5C26C58E);
					continue;
				case 61u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -1695659416;
						num8 = -1695659416;
					}
					else
					{
						num7 = -1112627427;
						num8 = -1112627427;
					}
					num = num7 ^ ((int)num2 * -2063653199);
					continue;
				}
				case 60u:
					num = ((int)num2 * -1812482577) ^ 0x7DECC46A;
					continue;
				case 59u:
					playerState2.Sprint++;
					num = ((int)num2 * -1336493574) ^ 0x53F1DFFC;
					continue;
				case 58u:
					num = (int)((num2 * 321493793) ^ 0x5A75B8F5);
					continue;
				case 57u:
				{
					int num34;
					int num35;
					if (!flag4)
					{
						num34 = 770532736;
						num35 = 770532736;
					}
					else
					{
						num34 = 2024269827;
						num35 = 2024269827;
					}
					num = num34 ^ ((int)num2 * -1808559160);
					continue;
				}
				case 56u:
					num9++;
					num = -890587691;
					continue;
				case 55u:
					num = ((int)num2 * -1027646544) ^ 0x78149D6F;
					continue;
				case 54u:
					num = ((int)num2 * -1877983562) ^ -810620452;
					continue;
				case 53u:
				{
					int num32;
					int num33;
					if (num9 != playerIndex)
					{
						num32 = 1366989134;
						num33 = 1366989134;
					}
					else
					{
						num32 = 1668975089;
						num33 = 1668975089;
					}
					num = num32 ^ ((int)num2 * -541035315);
					continue;
				}
				case 52u:
					num = -1183716605;
					continue;
				case 51u:
					num = -1173897878;
					continue;
				case 50u:
					playerState2.State = State.Won;
					num = (int)((num2 * 1447782146) ^ 0x2D220D10);
					continue;
				case 49u:
					num = -294286470;
					continue;
				case 48u:
					_finished = true;
					num = ((int)num2 * -1752592135) ^ -2058061623;
					continue;
				case 47u:
				{
					int num26;
					int num27;
					if (!flag12)
					{
						num26 = 1597492545;
						num27 = 1597492545;
					}
					else
					{
						num26 = 50734051;
						num27 = 50734051;
					}
					num = num26 ^ ((int)num2 * -1416102748);
					continue;
				}
				case 46u:
					num = (int)((num2 * 626302488) ^ 0x8A9653C);
					continue;
				case 45u:
					Losers.Add(num9);
					num = (int)((num2 * 351678692) ^ 0x1279DA2F);
					continue;
				case 44u:
					num19 = card.Impact;
					num = ((int)num2 * -1235351554) ^ -714308823;
					continue;
				case 43u:
					playerState2.Resources -= num19;
					flag12 = playerState2.Resources < 0;
					num = (int)((num2 * 1427901044) ^ 0x74ADD94);
					continue;
				case 42u:
				{
					int num25;
					if (!_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = -11811722;
						num25 = -11811722;
					}
					else
					{
						num = -1175941574;
						num25 = -1175941574;
					}
					continue;
				}
				case 40u:
					num = ((int)num2 * -626975804) ^ -286199606;
					continue;
				case 39u:
				{
					int num24;
					if (playerState2.Sprint < 0)
					{
						num = -1185769575;
						num24 = -1185769575;
					}
					else
					{
						num = -1242286843;
						num24 = -1242286843;
					}
					continue;
				}
				case 38u:
					Print(playerState2.State);
					num = ((int)num2 * -1199250705) ^ 0x66D78B22;
					continue;
				case 37u:
					num = -1501968552;
					continue;
				case 36u:
					num = -1030293617;
					continue;
				case 35u:
				{
					int num20;
					int num21;
					if (!flag10)
					{
						num20 = -803532187;
						num21 = -803532187;
					}
					else
					{
						num20 = -1509254027;
						num21 = -1509254027;
					}
					num = num20 ^ ((int)num2 * -1319992965);
					continue;
				}
				case 34u:
					player = Players[playerIndex];
					num = (int)((num2 * 1810266437) ^ 0x6FEF3330);
					continue;
				case 33u:
					num19 = Game.smethod_3(0, num3);
					num = (int)((num2 * 1755505310) ^ 0x24F43F5);
					continue;
				case 32u:
					flag5 = !Losers.Contains(num4);
					num = (int)(num2 * 1571073760) ^ -1543553141;
					continue;
				case 31u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -747593391;
					continue;
				}
				case 30u:
					flag10 = !flag9;
					num = ((int)num2 * -743006510) ^ 0x3B73B320;
					continue;
				case 29u:
				{
					int num17;
					int num18;
					if (flag6)
					{
						num17 = 1216160823;
						num18 = 1216160823;
					}
					else
					{
						num17 = 1318553169;
						num18 = 1318553169;
					}
					num = num17 ^ ((int)num2 * -381230713);
					continue;
				}
				case 28u:
					num4++;
					num = -168738966;
					continue;
				case 27u:
					flag8 = card.Impact < 0;
					num = (int)(num2 * 1847836107) ^ -398218420;
					continue;
				case 26u:
				{
					int num13;
					int num14;
					if (!Rules.OnlyOneWinner)
					{
						num13 = -820393844;
						num14 = -820393844;
					}
					else
					{
						num13 = -1293993317;
						num14 = -1293993317;
					}
					num = num13 ^ ((int)num2 * -1539493541);
					continue;
				}
				case 25u:
					num = -7993661;
					continue;
				case 24u:
					flag6 = flag;
					num = -1881094734;
					continue;
				case 23u:
					flag = true;
					num = ((int)num2 * -1486727978) ^ 0x374E8269;
					continue;
				case 22u:
					num = (int)((num2 * 925201035) ^ 0x33B99FEE);
					continue;
				case 21u:
					playerState2 = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)(num2 * 539054687) ^ -1152904940;
					continue;
				case 20u:
					flag = true;
					Print("CARD: none, advance");
					num = (int)(num2 * 2131410588) ^ -1599731586;
					continue;
				case 19u:
					num = ((int)num2 * -7754353) ^ 0x448BE660;
					continue;
				case 18u:
				{
					int num10;
					if (num9 < _playerStates.Length)
					{
						num = -805985538;
						num10 = -805985538;
					}
					else
					{
						num = -1047237697;
						num10 = -1047237697;
					}
					continue;
				}
				case 17u:
					Losers.Add(num4);
					num = (int)((num2 * 1673290090) ^ 0x1FCCE13B);
					continue;
				case 16u:
					playerState2.State = State.Lose;
					num = (int)((num2 * 1843419870) ^ 0x69566ECC);
					continue;
				case 15u:
					num = (int)(num2 * 211649928) ^ -203239789;
					continue;
				case 14u:
					num = (int)(num2 * 508849829) ^ -1135804245;
					continue;
				case 13u:
					flag4 = num4 < _playerStates.Length;
					num = -1185209410;
					continue;
				case 12u:
					num = -559865793;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1191695752;
						num6 = 1191695752;
					}
					else
					{
						num5 = 1207941879;
						num6 = 1207941879;
					}
					num = num5 ^ ((int)num2 * -216485722);
					continue;
				}
				case 10u:
					flag = false;
					num = -1866938007;
					continue;
				case 9u:
					num = (int)((num2 * 2052027026) ^ 0x4E357261);
					continue;
				case 8u:
					num = (int)((num2 * 694725104) ^ 0x47FDF659);
					continue;
				case 7u:
					num = (int)(num2 * 1019318492) ^ -235469816;
					continue;
				case 6u:
					playerState2.Sprint++;
					Print("Still planning");
					num = (int)(num2 * 1404206176) ^ -1281857329;
					continue;
				case 5u:
					num4 = 0;
					num = (int)((num2 * 1257043545) ^ 0x6F8EB09F);
					continue;
				case 4u:
					playerState = _playerStates[num4];
					num = ((int)num2 * -642296962) ^ -412968648;
					continue;
				case 2u:
					num = -250823189;
					continue;
				case 1u:
					flag = num3 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -732924091) ^ 0x25CFD4C3;
					continue;
				case 0u:
					card = DrawCard();
					num = ((int)num2 * -459760515) ^ -869837756;
					continue;
				default:
					return;
				case 41u:
					break;
				case 3u:
					return;
					IL_00b0:
					flag9 = (byte)num29 != 0;
					flag13 = !flag8;
					num = -1795359512;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		bool flag = _deck.Count <= 0;
		Card card = default(Card);
		Card result = default(Card);
		while (true)
		{
			int num = -1399320009;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE355DA85u) % 8u)
				{
				case 6u:
					ShuffleCards();
					num = (int)((num2 * 2106926344) ^ 0x62FA58E9);
					continue;
				case 5u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 1549415301) ^ 0x5E49A57D);
					continue;
				case 4u:
					card = _deck[0];
					num = -1586871176;
					continue;
				case 3u:
					result = card;
					num = (int)(num2 * 585123776) ^ -455355867;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1882889819;
						num4 = -1882889819;
					}
					else
					{
						num3 = -644930601;
						num4 = -644930601;
					}
					num = num3 ^ ((int)num2 * -160332417);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1768189426) ^ -716605452;
					continue;
				case 7u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public string ToString(bool initial)
	{
		bool flag = default(bool);
		int num3 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 254443221;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3407EE23u) % 8u)
				{
				case 7u:
					flag = num3 < _playerStates.Length;
					num = 1096331257;
					continue;
				case 6u:
					text = "";
					num3 = 0;
					num = (int)((num2 * 845622730) ^ 0x53E81808);
					continue;
				case 4u:
					result = text;
					num = (int)(num2 * 1808466769) ^ -2076101974;
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -1030006523) ^ -2036699957;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1440551304;
						num5 = -1440551304;
					}
					else
					{
						num4 = -1770769747;
						num5 = -1770769747;
					}
					num = num4 ^ ((int)num2 * -1040415023);
					continue;
				}
				case 1u:
				{
					string[] obj = new string[5]
					{
						text,
						num3.ToString(),
						": ",
						null,
						null
					};
					PlayerState obj2 = _playerStates[num3];
					obj[3] = ((obj2 != null) ? Game.smethod_5((object)obj2) : null);
					obj[4] = "\n";
					text = Game.smethod_6(obj);
					num = 2012046768;
					continue;
				}
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return ToString(initial: false);
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = -1763938122;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE9A1DEC7u) % 4u)
				{
				case 2u:
					Game.smethod_8(_buffer, string_);
					num = ((int)num2 * -1576853687) ^ 0x4A8896A9;
					continue;
				case 1u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = ((int)num2 * -900896865) ^ -1160485462;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	static Random smethod_0(int int_0)
	{
		return new Random(int_0);
	}

	static string smethod_1(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static string smethod_2(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static int smethod_3(int int_0, int int_1)
	{
		return Math.Max(int_0, int_1);
	}

	static int smethod_4(int int_0)
	{
		return Math.Abs(int_0);
	}

	static string smethod_5(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_6(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_7(string string_0, object[] object_0)
	{
		return string.Format(string_0, object_0);
	}

	static StringBuilder smethod_8(StringBuilder stringBuilder_0, string string_0)
	{
		return stringBuilder_0.AppendLine(string_0);
	}
}
