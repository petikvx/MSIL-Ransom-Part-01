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
			bool result = default(bool);
			PlayerState[] playerStates = default(PlayerState[]);
			int num5 = default(int);
			bool flag = default(bool);
			bool finished = default(bool);
			while (true)
			{
				int num = -41394083;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDFD19A86u) % 14u)
					{
					case 13u:
						result = false;
						num = ((int)num2 * -2080755918) ^ 0x57FE84C;
						continue;
					case 12u:
						num = -2057423785;
						continue;
					case 11u:
						result = true;
						num = (int)((num2 * 1049739349) ^ 0x2B6F38F9);
						continue;
					case 10u:
					{
						PlayerState playerState = playerStates[num5];
						flag = playerState.State == State.Playing;
						num = -1046568149;
						continue;
					}
					case 9u:
						num = (int)((num2 * 96803179) ^ 0x4B496ECB);
						continue;
					case 8u:
						result = true;
						num = ((int)num2 * -96718581) ^ 0x7D5B1AE;
						continue;
					case 7u:
						playerStates = _playerStates;
						num5 = 0;
						num = (int)((num2 * 440201920) ^ 0x5BA47E33);
						continue;
					case 5u:
					{
						int num7;
						int num8;
						if (!finished)
						{
							num7 = 350161295;
							num8 = 350161295;
						}
						else
						{
							num7 = 584847244;
							num8 = 584847244;
						}
						num = num7 ^ ((int)num2 * -2008220005);
						continue;
					}
					case 4u:
					{
						int num6;
						if (num5 >= playerStates.Length)
						{
							num = -1056412590;
							num6 = -1056412590;
						}
						else
						{
							num = -2137226830;
							num6 = -2137226830;
						}
						continue;
					}
					case 3u:
						finished = _finished;
						num = ((int)num2 * -77429170) ^ -718208973;
						continue;
					case 2u:
						num5++;
						num = -954342100;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 579642128;
							num4 = 579642128;
						}
						else
						{
							num3 = 1202544525;
							num4 = 1202544525;
						}
						num = num3 ^ ((int)num2 * -2025108891);
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		_buffer = buffer;
		_random = Game.smethod_0((int)DateTime.Now.Ticks);
		Rules = Rules.Deserialize(json["rules"]);
		_dice = new Dice();
		JSONNode jSONNode = json["players"];
		int count = jSONNode.Count;
		Players = new Player[count];
		for (int i = 0; i < count; i++)
		{
			Players[i] = Player.Deserialize(jSONNode[i]);
		}
		_playerStates = new PlayerState[count];
		for (int j = 0; j < count; j++)
		{
			_playerStates[j] = new PlayerState();
		}
	}

	public void ShuffleCards()
	{
		_deck = new List<Card>(Rules.Cards);
	}

	public void StartNew()
	{
		while (true)
		{
			int num = 207060768;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x17C2FC11u) % 6u)
				{
				case 5u:
					ShuffleCards();
					Winners.Clear();
					num = ((int)num2 * -1507203811) ^ -335383094;
					continue;
				case 3u:
					num = ((int)num2 * -972480058) ^ 0x51A8612B;
					continue;
				case 2u:
					Losers.Clear();
					num = ((int)num2 * -1730955633) ^ -547452480;
					continue;
				case 0u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					num = ((int)num2 * -1980404258) ^ -1866363244;
					continue;
				case 4u:
					break;
				default:
					_finished = false;
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		PlayerState playerState = default(PlayerState);
		bool useOneMorePlanningSprint = default(bool);
		int num6 = default(int);
		Player player = default(Player);
		int num5 = default(int);
		int planningCardsCount = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -924702243;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB28C6625u) % 29u)
				{
				case 28u:
					playerState.Sprint = 1;
					num = (int)((num2 * 1135777250) ^ 0x541E5615);
					continue;
				case 27u:
				{
					int num10;
					int num11;
					if (useOneMorePlanningSprint)
					{
						num10 = -2071608874;
						num11 = -2071608874;
					}
					else
					{
						num10 = -318294490;
						num11 = -318294490;
					}
					num = num10 ^ (int)(num2 * 1391985464);
					continue;
				}
				case 26u:
					num6 = 0;
					num = ((int)num2 * -1746335376) ^ 0x5006B6F8;
					continue;
				case 25u:
					num = ((int)num2 * -233717246) ^ 0x45F4DC4A;
					continue;
				case 24u:
					num6++;
					num = ((int)num2 * -1484557850) ^ -403203886;
					continue;
				case 23u:
					player = Players[num6];
					playerState = _playerStates[num6];
					num = (int)(num2 * 1872053221) ^ -1363435728;
					continue;
				case 22u:
					playerState.Resources -= num5 * Rules.OverPlanningCost;
					num = (int)(num2 * 1929145845) ^ -1079849190;
					continue;
				case 21u:
				{
					int num9;
					if (num5 <= 0)
					{
						num = -583231575;
						num9 = -583231575;
					}
					else
					{
						num = -65205432;
						num9 = -65205432;
					}
					continue;
				}
				case 20u:
					num = ((int)num2 * -33347099) ^ -2086950603;
					continue;
				case 19u:
					playerState.Resources -= num5 * Rules.NormalPlanningCost;
					num = (int)((num2 * 862110731) ^ 0x287748DF);
					continue;
				case 18u:
					playerState.Resources -= (planningCardsCount - num5) * Rules.NormalPlanningCost;
					num = -1852996386;
					continue;
				case 17u:
					planningCardsCount = player.PlanningCardsCount;
					num = ((int)num2 * -802910730) ^ 0x418505B4;
					continue;
				case 16u:
					num5 = 0;
					num = -1596914646;
					continue;
				case 15u:
					num5 = 0;
					num = ((int)num2 * -1784025928) ^ 0x3655FE5E;
					continue;
				case 12u:
					flag = num6 < Players.Length;
					num = -1920136513;
					continue;
				case 11u:
					num = (int)(num2 * 454161293) ^ -1485426244;
					continue;
				case 10u:
					flag2 = planningCardsCount == 0;
					num = (int)((num2 * 230965979) ^ 0x5A8DF215);
					continue;
				case 9u:
					num5 = planningCardsCount - Rules.NormalPlanningCount;
					num = -304807276;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -477356205;
						num8 = -477356205;
					}
					else
					{
						num7 = -1191928017;
						num8 = -1191928017;
					}
					num = num7 ^ (int)(num2 * 152088994);
					continue;
				}
				case 7u:
					playerState.Sprint = -1;
					num = (int)((num2 * 1172149081) ^ 0x375C4FD0);
					continue;
				case 6u:
					num = -1292543171;
					continue;
				case 5u:
					num = -1251210475;
					continue;
				case 4u:
					playerState.State = State.Playing;
					num = ((int)num2 * -563288739) ^ 0x3FF6931D;
					continue;
				case 3u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = (int)(num2 * 701198629) ^ -366259762;
					continue;
				case 2u:
					playerState.Resources = Rules.InitialResources;
					num = (int)(num2 * 915538332) ^ -2034180577;
					continue;
				case 1u:
					playerState.Sprint = 0;
					num = ((int)num2 * -111366680) ^ -625761508;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 720709328;
						num4 = 720709328;
					}
					else
					{
						num3 = 853592637;
						num4 = 853592637;
					}
					num = num3 ^ ((int)num2 * -1899519394);
					continue;
				}
				default:
					return;
				case 14u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		while (true)
		{
			int num = 1660668604;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22AAE521u) % 12u)
				{
				case 11u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1151996492) ^ -1492741320;
					continue;
				case 10u:
				{
					_currentPlayer = 0;
					int num5;
					int num6;
					if (_currentTurn > 0)
					{
						num5 = 348156178;
						num6 = 348156178;
					}
					else
					{
						num5 = 491423924;
						num6 = 491423924;
					}
					num = num5 ^ ((int)num2 * -710179768);
					continue;
				}
				case 9u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 805783878;
					continue;
				case 8u:
					PlayerTurn(_currentPlayer);
					num = 274679667;
					continue;
				case 7u:
					num = ((int)num2 * -1378064668) ^ -1419385855;
					continue;
				case 5u:
					num = (int)((num2 * 333883027) ^ 0x376A08F0);
					continue;
				case 4u:
					num = ((int)num2 * -1385841773) ^ -1214483527;
					continue;
				case 2u:
					num = ((int)num2 * -2139895301) ^ -936584379;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_currentPlayer >= Players.Length)
					{
						num3 = -1989791346;
						num4 = -1989791346;
					}
					else
					{
						num3 = -776960881;
						num4 = -776960881;
					}
					num = num3 ^ (int)(num2 * 1800620982);
					continue;
				}
				case 0u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 1342251175) ^ 0x592F7E5D);
					continue;
				default:
					return;
				case 3u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		PlayerState playerState = _playerStates[playerIndex];
		Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
		PlayerState playerState2 = default(PlayerState);
		int num4 = default(int);
		bool flag9 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		int num7 = default(int);
		int num9 = default(int);
		Card card = default(Card);
		bool flag8 = default(bool);
		int num3 = default(int);
		bool flag11 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag = default(bool);
		bool flag10 = default(bool);
		while (true)
		{
			int num = -2028213885;
			while (true)
			{
				uint num2;
				int num21;
				switch ((num2 = (uint)num ^ 0x88AED97Cu) % 82u)
				{
				case 81u:
					num = (int)((num2 * 1435785924) ^ 0x623102A0);
					continue;
				case 80u:
					playerState2 = _playerStates[num4];
					num = ((int)num2 * -1478584775) ^ 0x1F4E4102;
					continue;
				case 79u:
					num = ((int)num2 * -907754327) ^ -111638370;
					continue;
				case 78u:
					num = -1255249828;
					continue;
				case 77u:
					num = ((int)num2 * -1877712871) ^ -155822957;
					continue;
				case 76u:
					flag9 = !flag7;
					num = ((int)num2 * -1870052389) ^ 0x11A57DD1;
					continue;
				case 75u:
					Winners.Add(playerIndex);
					num = (int)(num2 * 1114382157) ^ -1772913295;
					continue;
				case 74u:
				{
					int num22;
					int num23;
					if (flag5)
					{
						num22 = 166262605;
						num23 = 166262605;
					}
					else
					{
						num22 = 130987739;
						num23 = 130987739;
					}
					num = num22 ^ (int)(num2 * 409042604);
					continue;
				}
				case 73u:
					flag6 = !flag2;
					num = ((int)num2 * -1752887546) ^ 0x62ACCE66;
					continue;
				case 72u:
				{
					int num12;
					int num13;
					if (!flag6)
					{
						num12 = -274155696;
						num13 = -274155696;
					}
					else
					{
						num12 = -1491683801;
						num13 = -1491683801;
					}
					num = num12 ^ ((int)num2 * -1172288235);
					continue;
				}
				case 71u:
					num = (int)((num2 * 259598974) ^ 0x3C3446A6);
					continue;
				case 70u:
					num = (int)((num2 * 57467909) ^ 0x27CD1773);
					continue;
				case 69u:
					flag4 = true;
					Print("CARD: none, advance");
					num = (int)((num2 * 2031714724) ^ 0x4909284);
					continue;
				case 68u:
					num = (int)(num2 * 1253913178) ^ -706669378;
					continue;
				case 67u:
					num = -593900183;
					continue;
				case 66u:
					flag3 = num4 < _playerStates.Length;
					num = -273196994;
					continue;
				case 65u:
					_finished = true;
					num7 = 0;
					num = (int)(num2 * 2623439) ^ -1067892033;
					continue;
				case 64u:
					num = ((int)num2 * -186577635) ^ 0x45BB91F3;
					continue;
				case 63u:
					num = -1633942396;
					continue;
				case 62u:
					num9 = card.Impact - player.PlannedForCard(card.Type);
					num = ((int)num2 * -944186627) ^ -1348157202;
					continue;
				case 61u:
				{
					int num26;
					int num27;
					if (playerState.Resources >= 0)
					{
						num26 = 1966346497;
						num27 = 1966346497;
					}
					else
					{
						num26 = 1766774307;
						num27 = 1766774307;
					}
					num = num26 ^ (int)(num2 * 1026767607);
					continue;
				}
				case 60u:
					num = ((int)num2 * -19560223) ^ 0x706AAB7F;
					continue;
				case 59u:
					num = (int)((num2 * 2062222707) ^ 0x6AF1626C);
					continue;
				case 58u:
					Print("Still planning");
					num = (int)(num2 * 935733714) ^ -1285416045;
					continue;
				case 57u:
					num21 = ((card.Type == 4) ? 1 : 0);
					goto IL_02a3;
				case 56u:
				{
					int num18;
					if (num7 == playerIndex)
					{
						num = -1938725083;
						num18 = -1938725083;
					}
					else
					{
						num = -776735689;
						num18 = -776735689;
					}
					continue;
				}
				case 55u:
					playerState.Sprint++;
					num = ((int)num2 * -837847340) ^ -1951182221;
					continue;
				case 54u:
					num = (int)(num2 * 1436910142) ^ -1588316771;
					continue;
				case 53u:
					num = (int)((num2 * 583320301) ^ 0x21B235ED);
					continue;
				case 52u:
				{
					int num16;
					int num17;
					if (flag8)
					{
						num16 = -631765551;
						num17 = -631765551;
					}
					else
					{
						num16 = -1007610781;
						num17 = -1007610781;
					}
					num = num16 ^ (int)(num2 * 1429569282);
					continue;
				}
				case 51u:
				{
					int num14;
					int num15;
					if (playerState.State != 0)
					{
						num14 = 1678406069;
						num15 = 1678406069;
					}
					else
					{
						num14 = 585341584;
						num15 = 585341584;
					}
					num = num14 ^ ((int)num2 * -1635440517);
					continue;
				}
				case 50u:
					Print(playerState.State);
					num = ((int)num2 * -1121324818) ^ 0x2EAB49B9;
					continue;
				case 49u:
					playerState.Sprint++;
					num = ((int)num2 * -1935453613) ^ -439980601;
					continue;
				case 48u:
					playerState.State = State.Won;
					num = ((int)num2 * -408263240) ^ -830576065;
					continue;
				case 47u:
					num = ((int)num2 * -1478646012) ^ 0x534685C9;
					continue;
				case 45u:
					num3 = Game.smethod_3(0, num9);
					num = (int)(num2 * 59830086) ^ -831372096;
					continue;
				case 44u:
					flag4 = false;
					num = -1903232776;
					continue;
				case 43u:
				{
					int num34;
					int num35;
					if (flag11)
					{
						num34 = -33555717;
						num35 = -33555717;
					}
					else
					{
						num34 = -686384682;
						num35 = -686384682;
					}
					num = num34 ^ (int)(num2 * 570168781);
					continue;
				}
				case 42u:
					flag4 = num9 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -1753659366) ^ 0xC49BE01;
					continue;
				case 41u:
					flag4 = true;
					num3 = card.Impact;
					num = ((int)num2 * -464920694) ^ 0x5E2B3D5C;
					continue;
				case 40u:
					Losers.Add(num4);
					num = ((int)num2 * -1927723178) ^ 0x49A9BD83;
					continue;
				case 39u:
				{
					int num32;
					int num33;
					if (!onlyOneWinner)
					{
						num32 = -648739185;
						num33 = -648739185;
					}
					else
					{
						num32 = -1711169717;
						num33 = -1711169717;
					}
					num = num32 ^ (int)(num2 * 494460748);
					continue;
				}
				case 38u:
				{
					int num30;
					int num31;
					if (!flag)
					{
						num30 = 870943332;
						num31 = 870943332;
					}
					else
					{
						num30 = 1139955378;
						num31 = 1139955378;
					}
					num = num30 ^ ((int)num2 * -2086490466);
					continue;
				}
				case 37u:
				{
					int num28;
					int num29;
					if (!Losers.Contains(playerIndex))
					{
						num28 = 1830289540;
						num29 = 1830289540;
					}
					else
					{
						num28 = 1504391030;
						num29 = 1504391030;
					}
					num = num28 ^ ((int)num2 * -1194968694);
					continue;
				}
				case 36u:
					flag8 = flag4;
					num = -1034923186;
					continue;
				case 35u:
					flag10 = playerState.Sprint > Rules.SprintCount;
					num = -753359678;
					continue;
				case 34u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 938555672) ^ 0xBDE965);
						continue;
					}
					num21 = 0;
					goto IL_02a3;
				case 33u:
					num = ((int)num2 * -1430755117) ^ -164037176;
					continue;
				case 32u:
					flag11 = num7 < _playerStates.Length;
					num = -488966241;
					continue;
				case 31u:
					num = -1116078748;
					continue;
				case 29u:
					num = ((int)num2 * -393499145) ^ 0x367667B2;
					continue;
				case 28u:
					num = ((int)num2 * -1005156715) ^ 0x25485425;
					continue;
				case 27u:
				{
					int num24;
					int num25;
					if (flag9)
					{
						num24 = 753674899;
						num25 = 753674899;
					}
					else
					{
						num24 = 119151986;
						num25 = 119151986;
					}
					num = num24 ^ ((int)num2 * -405328193);
					continue;
				}
				case 26u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -785148101) ^ -2054649030;
					continue;
				case 25u:
					num4 = 0;
					num = -150874149;
					continue;
				case 24u:
					num = ((int)num2 * -1818163208) ^ 0x454BF359;
					continue;
				case 23u:
					playerState.Resources -= num3;
					num = (int)((num2 * 2066964763) ^ 0x73291972);
					continue;
				case 22u:
				{
					int num19;
					int num20;
					if (flag10)
					{
						num19 = -1352169677;
						num20 = -1352169677;
					}
					else
					{
						num19 = -138607368;
						num20 = -138607368;
					}
					num = num19 ^ (int)(num2 * 886485746);
					continue;
				}
				case 21u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag7 ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num3), flag4 ? "advance" : "stay");
					num = -1680601602;
					continue;
				case 20u:
					num7++;
					num = -184816184;
					continue;
				case 19u:
					Losers.Add(num7);
					num = ((int)num2 * -315392364) ^ 0x3FB9E4EC;
					continue;
				case 18u:
					Print(Game.smethod_2("\t", (playerState != null) ? Game.smethod_5((object)playerState) : null));
					num = -1408422844;
					continue;
				case 17u:
				{
					int num11;
					if (playerState.Sprint < 0)
					{
						num = -1658943539;
						num11 = -1658943539;
					}
					else
					{
						num = -1331669629;
						num11 = -1331669629;
					}
					continue;
				}
				case 16u:
					playerState.State = State.Lose;
					num = ((int)num2 * -2058101852) ^ 0x4913BF03;
					continue;
				case 15u:
				{
					int num10;
					if (_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = -2066518594;
						num10 = -2066518594;
					}
					else
					{
						num = -1890645501;
						num10 = -1890645501;
					}
					continue;
				}
				case 14u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -2019199907) ^ 0x7B2527CD;
					continue;
				case 13u:
					num4++;
					num = -1005233444;
					continue;
				case 12u:
				{
					playerState2.State = State.Lose;
					int num8;
					if (!Losers.Contains(num4))
					{
						num = -1509948962;
						num8 = -1509948962;
					}
					else
					{
						num = -439573883;
						num8 = -439573883;
					}
					continue;
				}
				case 11u:
					flag5 = !Losers.Contains(num7);
					num = -879242380;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = 820590773;
						num6 = 820590773;
					}
					else
					{
						num5 = 629379420;
						num6 = 629379420;
					}
					num = num5 ^ ((int)num2 * -355175936);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1700404759) ^ 0x616EEE71;
					continue;
				case 8u:
					card = DrawCard();
					flag2 = card.Impact < 0;
					num = -1183914988;
					continue;
				case 7u:
					num = (int)(num2 * 1600535229) ^ -126459305;
					continue;
				case 6u:
					playerState2.Resources -= Game.smethod_3(0, num3 - Players[num4].PlannedForCard(card.Type));
					flag = playerState2.Resources >= 0;
					num = ((int)num2 * -1817453734) ^ 0x4DF77096;
					continue;
				case 5u:
					num = (int)((num2 * 811318179) ^ 0x701C7677);
					continue;
				case 4u:
					num = -2034231048;
					continue;
				case 3u:
					num = (int)((num2 * 730069911) ^ 0x6B912D2A);
					continue;
				case 2u:
					num = -820622408;
					continue;
				case 1u:
					num = (int)(num2 * 1655579718) ^ -829483844;
					continue;
				case 0u:
					num = -333657635;
					continue;
				default:
					return;
				case 46u:
					break;
				case 30u:
					return;
					IL_02a3:
					flag7 = (byte)num21 != 0;
					num = -584147453;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card card = default(Card);
		Card result = default(Card);
		bool flag = default(bool);
		while (true)
		{
			int num = -1685878620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBF0DA09u) % 10u)
				{
				case 9u:
					ShuffleCards();
					num = (int)((num2 * 1137971268) ^ 0x58BC955E);
					continue;
				case 6u:
					card = _deck[0];
					num = -1591491636;
					continue;
				case 5u:
					num = ((int)num2 * -1177547190) ^ 0x9331F7D;
					continue;
				case 4u:
					num = ((int)num2 * -799113608) ^ -59120491;
					continue;
				case 3u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 1770092409) ^ 0x15C6812E);
					continue;
				case 2u:
					result = card;
					num = (int)(num2 * 269852278) ^ -1471699544;
					continue;
				case 1u:
					flag = _deck.Count <= 0;
					num = (int)((num2 * 1603597295) ^ 0x1B6F0560);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1819860769;
						num4 = 1819860769;
					}
					else
					{
						num3 = 759730664;
						num4 = 759730664;
					}
					num = num3 ^ ((int)num2 * -1385495611);
					continue;
				}
				case 8u:
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
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -462592164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB081EAFu) % 10u)
				{
				case 9u:
					num = ((int)num2 * -107176647) ^ -1104716101;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1273543213;
						num5 = 1273543213;
					}
					else
					{
						num4 = 1030559785;
						num5 = 1030559785;
					}
					num = num4 ^ ((int)num2 * -1217909891);
					continue;
				}
				case 6u:
					result = text;
					num = ((int)num2 * -1002580036) ^ -1946222282;
					continue;
				case 5u:
					text = "";
					num = (int)((num2 * 1874694666) ^ 0x35B7434E);
					continue;
				case 3u:
					num3 = 0;
					num = (int)((num2 * 1151458877) ^ 0x79536E35);
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1776010609) ^ -706959960;
					continue;
				case 1u:
					flag = num3 < _playerStates.Length;
					num = -11110593;
					continue;
				case 0u:
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
					num = -151085043;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1419147908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44414A1Du) % 4u)
				{
				case 3u:
					num = (int)((num2 * 974424810) ^ 0x3DE185AF);
					continue;
				case 1u:
					result = ToString(initial: false);
					num = (int)(num2 * 1211005901) ^ -1636832445;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = 59435092;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x356F5F0Du) % 4u)
				{
				case 1u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = (int)((num2 * 1864641663) ^ 0x6CE379FA);
					continue;
				case 0u:
					Game.smethod_8(_buffer, string_);
					num = (int)(num2 * 203614119) ^ -384016537;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
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
