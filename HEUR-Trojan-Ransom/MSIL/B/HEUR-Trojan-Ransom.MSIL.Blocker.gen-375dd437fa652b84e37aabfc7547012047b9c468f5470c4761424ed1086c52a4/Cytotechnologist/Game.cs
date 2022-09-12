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
			bool flag = default(bool);
			PlayerState playerState = default(PlayerState);
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool finished = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = 85265022;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2535AE48u) % 18u)
					{
					case 17u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 1867053628;
							num6 = 1867053628;
						}
						else
						{
							num5 = 2044760243;
							num6 = 2044760243;
						}
						num = num5 ^ ((int)num2 * -1343339876);
						continue;
					}
					case 16u:
						playerState = playerStates[num3];
						num = 992052231;
						continue;
					case 15u:
					{
						int num7;
						int num8;
						if (!finished)
						{
							num7 = -1715078414;
							num8 = -1715078414;
						}
						else
						{
							num7 = -899031438;
							num8 = -899031438;
						}
						num = num7 ^ (int)(num2 * 262528533);
						continue;
					}
					case 13u:
						num = 1073415618;
						continue;
					case 12u:
						finished = _finished;
						num = (int)(num2 * 1459607197) ^ -643797815;
						continue;
					case 11u:
						result = true;
						num = (int)(num2 * 1983695073) ^ -1394599617;
						continue;
					case 10u:
						num = (int)((num2 * 758125858) ^ 0x4A873957);
						continue;
					case 9u:
						num3++;
						num = 809949548;
						continue;
					case 8u:
						result = false;
						num = (int)(num2 * 1935367495) ^ -1937455924;
						continue;
					case 7u:
						result = true;
						num = (int)((num2 * 1333335347) ^ 0x28CC93AC);
						continue;
					case 6u:
					{
						int num4;
						if (num3 >= playerStates.Length)
						{
							num = 929236889;
							num4 = 929236889;
						}
						else
						{
							num = 2032134736;
							num4 = 2032134736;
						}
						continue;
					}
					case 4u:
						playerStates = _playerStates;
						num = ((int)num2 * -1587635497) ^ -497656774;
						continue;
					case 3u:
						flag = playerState.State == State.Playing;
						num = ((int)num2 * -750660069) ^ -1668726660;
						continue;
					case 2u:
						num = ((int)num2 * -603085853) ^ -1666236931;
						continue;
					case 1u:
						num = (int)((num2 * 1970628013) ^ 0x5077E6B1);
						continue;
					case 0u:
						num3 = 0;
						num = (int)((num2 * 930917587) ^ 0x177D45);
						continue;
					case 14u:
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
		int num6 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		int count = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -553475502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE56EFD1Fu) % 20u)
				{
				case 19u:
					Players[num6] = Player.Deserialize(jSONNode[num6]);
					num = -1999056392;
					continue;
				case 18u:
					_buffer = buffer;
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -1522522789) ^ 0x4AC15E19;
					continue;
				case 17u:
					_playerStates[num3] = new PlayerState();
					num3++;
					num = -260894720;
					continue;
				case 16u:
					Rules = Rules.Deserialize(json["rules"]);
					num = ((int)num2 * -467738473) ^ -1912821399;
					continue;
				case 15u:
					num = (int)((num2 * 758570373) ^ 0x6308A136);
					continue;
				case 14u:
					num6 = 0;
					num = ((int)num2 * -2023126213) ^ -168004359;
					continue;
				case 13u:
					num = ((int)num2 * -1453017679) ^ -1558173019;
					continue;
				case 11u:
					num6++;
					num = ((int)num2 * -304473883) ^ -798046535;
					continue;
				case 10u:
					num = ((int)num2 * -253359912) ^ -132332912;
					continue;
				case 9u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = ((int)num2 * -2079676824) ^ -1770940902;
					continue;
				case 8u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -347727424) ^ -1556992304;
					continue;
				case 7u:
					num3 = 0;
					num = (int)(num2 * 1975394024) ^ -138858863;
					continue;
				case 5u:
				{
					int num7;
					if (num6 < count)
					{
						num = -447400504;
						num7 = -447400504;
					}
					else
					{
						num = -1934946417;
						num7 = -1934946417;
					}
					continue;
				}
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1810120874;
						num5 = -1810120874;
					}
					else
					{
						num4 = -481098571;
						num5 = -481098571;
					}
					num = num4 ^ ((int)num2 * -1348255894);
					continue;
				}
				case 3u:
					flag = num3 < count;
					num = -529159945;
					continue;
				case 2u:
					_dice = new Dice();
					num = ((int)num2 * -2064878961) ^ -1676665324;
					continue;
				case 1u:
					Players = new Player[count];
					num = ((int)num2 * -1666628449) ^ -362798722;
					continue;
				case 0u:
					num = (int)((num2 * 2088681740) ^ 0x774FAF1A);
					continue;
				default:
					return;
				case 12u:
					break;
				case 6u:
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
			int num = -1477124064;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA782E4C3u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				_deck = new List<Card>(Rules.Cards);
				num = ((int)num2 * -733054764) ^ -685314948;
			}
		}
	}

	public void StartNew()
	{
		ShuffleCards();
		while (true)
		{
			int num = -1467258465;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA13B2858u) % 7u)
				{
				case 6u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					num = ((int)num2 * -674441757) ^ -808836338;
					continue;
				case 5u:
					_finished = false;
					_currentChanceIndex = -1;
					num = ((int)num2 * -1073496993) ^ -805831067;
					continue;
				case 4u:
					Winners.Clear();
					num = (int)(num2 * 235566922) ^ -1007037829;
					continue;
				case 2u:
					Losers.Clear();
					num = ((int)num2 * -623067166) ^ -1978551046;
					continue;
				case 1u:
					num = (int)((num2 * 1399512393) ^ 0x6DAEED88);
					continue;
				case 0u:
					break;
				default:
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
		int num3 = default(int);
		int planningCardsCount = default(int);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		bool flag2 = default(bool);
		int num8 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1873240745;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC1D00ECu) % 26u)
				{
				case 25u:
					playerState.Sprint = -1;
					num = ((int)num2 * -1472794004) ^ 0x3C048A0B;
					continue;
				case 24u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = (int)(num2 * 855759009) ^ -1033570632;
					continue;
				case 23u:
					num = -1615989306;
					continue;
				case 22u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = (int)((num2 * 2028243238) ^ 0x2BB90B58);
					continue;
				case 21u:
					num = (int)(num2 * 807966161) ^ -1148239216;
					continue;
				case 20u:
					flag2 = num8 < Players.Length;
					num = -1988479125;
					continue;
				case 18u:
					flag = num3 > 0;
					num = -901386867;
					continue;
				case 17u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -246349006;
						num7 = -246349006;
					}
					else
					{
						num6 = -1194579488;
						num7 = -1194579488;
					}
					num = num6 ^ (int)(num2 * 1875517032);
					continue;
				}
				case 16u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num = (int)(num2 * 946733195) ^ -1508698314;
					continue;
				case 15u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)(num2 * 309249058) ^ -1391212182;
					continue;
				case 14u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = -328724864;
					continue;
				case 13u:
					player = Players[num8];
					num = -2117114506;
					continue;
				case 12u:
					num3 = 0;
					num = -1145495972;
					continue;
				case 11u:
					playerState.Sprint = 0;
					num = ((int)num2 * -453160833) ^ 0x5AEB7E9B;
					continue;
				case 10u:
					playerState.Sprint = 1;
					num = (int)(num2 * 488913651) ^ -221295629;
					continue;
				case 9u:
					num = (int)((num2 * 1089153332) ^ 0x6152810);
					continue;
				case 8u:
				{
					int num11;
					int num12;
					if (useOneMorePlanningSprint)
					{
						num11 = -1211046979;
						num12 = -1211046979;
					}
					else
					{
						num11 = -669368926;
						num12 = -669368926;
					}
					num = num11 ^ (int)(num2 * 2021559374);
					continue;
				}
				case 7u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -396935578;
						num10 = -396935578;
					}
					else
					{
						num9 = -282852698;
						num10 = -282852698;
					}
					num = num9 ^ ((int)num2 * -1267503527);
					continue;
				}
				case 6u:
					num8++;
					num = (int)(num2 * 708483103) ^ -1001545648;
					continue;
				case 5u:
					num = ((int)num2 * -1626494331) ^ 0xA8810EF;
					continue;
				case 4u:
					num = -1500770364;
					continue;
				case 2u:
					playerState = _playerStates[num8];
					num = (int)((num2 * 375556938) ^ 0x1F7D5FE5);
					continue;
				case 1u:
					num8 = 0;
					num = (int)((num2 * 1736623909) ^ 0x1E530442);
					continue;
				case 0u:
				{
					planningCardsCount = player.PlanningCardsCount;
					num3 = 0;
					int num4;
					int num5;
					if (planningCardsCount != 0)
					{
						num4 = -254081909;
						num5 = -254081909;
					}
					else
					{
						num4 = -1509516920;
						num5 = -1509516920;
					}
					num = num4 ^ (int)(num2 * 2136021678);
					continue;
				}
				default:
					return;
				case 19u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		bool flag = default(bool);
		while (true)
		{
			int num = -502562756;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE50217E3u) % 14u)
				{
				case 13u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 839804917) ^ 0x6537D61C);
					continue;
				case 12u:
					num = ((int)num2 * -147523461) ^ 0x20A87F49;
					continue;
				case 11u:
					PlayerTurn(_currentPlayer);
					num = -955741320;
					continue;
				case 10u:
					num = ((int)num2 * -441405466) ^ -828859934;
					continue;
				case 9u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -989811979;
					continue;
				case 8u:
					num = ((int)num2 * -1584300490) ^ -137636764;
					continue;
				case 6u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)(num2 * 83215761) ^ -1071033931;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (_currentPlayer < Players.Length)
					{
						num5 = 1193476730;
						num6 = 1193476730;
					}
					else
					{
						num5 = 1039662309;
						num6 = 1039662309;
					}
					num = num5 ^ ((int)num2 * -973927618);
					continue;
				}
				case 4u:
					_currentPlayer = 0;
					flag = _currentTurn > 0;
					num = (int)(num2 * 1221933668) ^ -1750788510;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -490090205;
						num4 = -490090205;
					}
					else
					{
						num3 = -1835479956;
						num4 = -1835479956;
					}
					num = num3 ^ (int)(num2 * 1005029345);
					continue;
				}
				case 2u:
					num = (int)((num2 * 2064028371) ^ 0x59FC0002);
					continue;
				case 1u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = ((int)num2 * -1455596298) ^ 0x28A36742;
					continue;
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		bool flag3 = default(bool);
		bool flag11 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		int num3 = default(int);
		Player player = default(Player);
		bool flag8 = default(bool);
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		PlayerState playerState = default(PlayerState);
		int num34 = default(int);
		Card card = default(Card);
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		bool flag12 = default(bool);
		bool flag9 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1800190056;
			while (true)
			{
				uint num2;
				int num12;
				switch ((num2 = (uint)num ^ 0xBC5C9E89u) % 83u)
				{
				case 82u:
				{
					int num30;
					int num31;
					if (!flag3)
					{
						num30 = -976250296;
						num31 = -976250296;
					}
					else
					{
						num30 = -877406408;
						num31 = -877406408;
					}
					num = num30 ^ (int)(num2 * 1169070905);
					continue;
				}
				case 81u:
					num = (int)((num2 * 895600978) ^ 0x4F130AC4);
					continue;
				case 79u:
					flag11 = playerState2.Sprint < 0;
					num = -1527610416;
					continue;
				case 78u:
					Losers.Add(num3);
					num = (int)((num2 * 245439329) ^ 0x4BD9FE8E);
					continue;
				case 77u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 770190821) ^ 0x648F79A9);
						continue;
					}
					num12 = 0;
					goto IL_0098;
				case 76u:
					num = (int)((num2 * 1811495294) ^ 0x10FFEC8E);
					continue;
				case 75u:
					player = Players[playerIndex];
					num = ((int)num2 * -1150361658) ^ -150424840;
					continue;
				case 74u:
				{
					int num20;
					int num21;
					if (flag8)
					{
						num20 = -906391503;
						num21 = -906391503;
					}
					else
					{
						num20 = -56126755;
						num21 = -56126755;
					}
					num = num20 ^ (int)(num2 * 1712339723);
					continue;
				}
				case 73u:
					flag10 = playerState2.Sprint > Rules.SprintCount;
					num = -104841384;
					continue;
				case 72u:
					flag6 = playerState.Resources >= 0;
					num = ((int)num2 * -28366097) ^ 0x5F2A309B;
					continue;
				case 71u:
					num = ((int)num2 * -1323294059) ^ 0x5960D7E0;
					continue;
				case 70u:
					playerState2.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -1892916575) ^ -63996506;
					continue;
				case 69u:
					num34 = card.Impact - player.PlannedForCard(card.Type);
					flag4 = num34 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -479178399) ^ 0xD766A6A;
					continue;
				case 67u:
					num = ((int)num2 * -1372762624) ^ 0x61132099;
					continue;
				case 66u:
					num = (int)((num2 * 349638688) ^ 0x6F21EC47);
					continue;
				case 65u:
					num = -1380031444;
					continue;
				case 64u:
					flag4 = true;
					num = (int)((num2 * 543035186) ^ 0x46DFB574);
					continue;
				case 63u:
				{
					int num32;
					int num33;
					if (flag7)
					{
						num32 = -458239385;
						num33 = -458239385;
					}
					else
					{
						num32 = -879823802;
						num33 = -879823802;
					}
					num = num32 ^ ((int)num2 * -1869994321);
					continue;
				}
				case 62u:
				{
					int num29;
					if (!flag4)
					{
						num = -1004845811;
						num29 = -1004845811;
					}
					else
					{
						num = -1687033635;
						num29 = -1687033635;
					}
					continue;
				}
				case 61u:
					playerState.State = State.Lose;
					num = -157634155;
					continue;
				case 60u:
					num = ((int)num2 * -1671004508) ^ -528567293;
					continue;
				case 59u:
				{
					int num27;
					int num28;
					if (flag5)
					{
						num27 = 414590462;
						num28 = 414590462;
					}
					else
					{
						num27 = 1679882824;
						num28 = 1679882824;
					}
					num = num27 ^ ((int)num2 * -739910631);
					continue;
				}
				case 58u:
					playerState2.Sprint++;
					num = ((int)num2 * -711443000) ^ 0x528D30AD;
					continue;
				case 57u:
				{
					int num22;
					int num23;
					if (playerState2.Resources >= 0)
					{
						num22 = -84397317;
						num23 = -84397317;
					}
					else
					{
						num22 = -283403928;
						num23 = -283403928;
					}
					num = num22 ^ (int)(num2 * 69731113);
					continue;
				}
				case 56u:
					num = -1420213401;
					continue;
				case 55u:
					playerState2.Resources -= num5;
					num = (int)((num2 * 1863170444) ^ 0xD191DFC);
					continue;
				case 54u:
				{
					int num15;
					if (Losers.Contains(num4))
					{
						num = -415611721;
						num15 = -415611721;
					}
					else
					{
						num = -782047380;
						num15 = -782047380;
					}
					continue;
				}
				case 53u:
					num = (int)((num2 * 986176792) ^ 0x21AE62B4);
					continue;
				case 52u:
					flag7 = num4 == playerIndex;
					num = ((int)num2 * -1232982205) ^ 0x3C4D9D30;
					continue;
				case 51u:
					num12 = ((card.Type == 4) ? 1 : 0);
					goto IL_0098;
				case 50u:
					card = DrawCard();
					flag8 = card.Impact < 0;
					num = -968107348;
					continue;
				case 49u:
					_finished = true;
					num4 = 0;
					num = ((int)num2 * -1315330490) ^ 0x5C63178F;
					continue;
				case 48u:
					num = -1605674681;
					continue;
				case 47u:
					Print("Still planning");
					num = (int)((num2 * 1775334706) ^ 0x3B8DC422);
					continue;
				case 46u:
					num3++;
					num = -1929361613;
					continue;
				case 45u:
					num = (int)(num2 * 1268785653) ^ -1044256008;
					continue;
				case 44u:
				{
					int num35;
					int num36;
					if (flag)
					{
						num35 = -792495180;
						num36 = -792495180;
					}
					else
					{
						num35 = -86035453;
						num36 = -86035453;
					}
					num = num35 ^ ((int)num2 * -905425396);
					continue;
				}
				case 43u:
					num4++;
					num = -197042023;
					continue;
				case 42u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -2136569164;
					continue;
				}
				case 41u:
					num = -1726572348;
					continue;
				case 40u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -905625134) ^ -1911006168;
					continue;
				case 39u:
					num = (int)((num2 * 178010263) ^ 0x20569FBE);
					continue;
				case 38u:
					playerState2 = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 1957543026) ^ 0x2B652C86);
					continue;
				case 37u:
					num5 = Game.smethod_3(0, num34);
					num = ((int)num2 * -707664663) ^ -1630975063;
					continue;
				case 36u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag12 ? "ALL " : "", flag8 ? "receives" : "pays", Game.smethod_4(num5), flag4 ? "advance" : "stay");
					flag9 = !flag12;
					num = -317487598;
					continue;
				case 35u:
				{
					int num25;
					int num26;
					if (flag11)
					{
						num25 = -352103561;
						num26 = -352103561;
					}
					else
					{
						num25 = -96164028;
						num26 = -96164028;
					}
					num = num25 ^ (int)(num2 * 380369874);
					continue;
				}
				case 34u:
					num = -1217661952;
					continue;
				case 33u:
					playerState = _playerStates[num3];
					num = -523503219;
					continue;
				case 32u:
					num = (int)((num2 * 641594202) ^ 0x27F41D19);
					continue;
				case 31u:
					playerState2.Sprint++;
					num = ((int)num2 * -594696660) ^ 0x8AC4FDA;
					continue;
				case 30u:
					num = ((int)num2 * -1848793880) ^ 0x3FDA9764;
					continue;
				case 29u:
				{
					int num24;
					if (num3 < _playerStates.Length)
					{
						num = -2039914117;
						num24 = -2039914117;
					}
					else
					{
						num = -216300524;
						num24 = -216300524;
					}
					continue;
				}
				case 28u:
				{
					int num18;
					int num19;
					if (!flag10)
					{
						num18 = 915277356;
						num19 = 915277356;
					}
					else
					{
						num18 = 591726796;
						num19 = 591726796;
					}
					num = num18 ^ (int)(num2 * 658358363);
					continue;
				}
				case 27u:
					num = -1989104838;
					continue;
				case 26u:
					num = ((int)num2 * -582823511) ^ 0x52A8C705;
					continue;
				case 25u:
				{
					int num16;
					int num17;
					if (onlyOneWinner)
					{
						num16 = -1401935313;
						num17 = -1401935313;
					}
					else
					{
						num16 = -1245743435;
						num17 = -1245743435;
					}
					num = num16 ^ (int)(num2 * 1302072749);
					continue;
				}
				case 24u:
					num = ((int)num2 * -1929425636) ^ -639100280;
					continue;
				case 23u:
					flag2 = num4 < _playerStates.Length;
					num = -286598975;
					continue;
				case 22u:
				{
					int num13;
					int num14;
					if (flag9)
					{
						num13 = -1696029394;
						num14 = -1696029394;
					}
					else
					{
						num13 = -1200976083;
						num14 = -1200976083;
					}
					num = num13 ^ ((int)num2 * -1987401532);
					continue;
				}
				case 21u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -563208517) ^ -1770032147;
					continue;
				case 20u:
					num = ((int)num2 * -142540318) ^ -1450598300;
					continue;
				case 19u:
					num = (int)((num2 * 523088608) ^ 0x5FA49922);
					continue;
				case 18u:
					num = -1778663363;
					continue;
				case 17u:
					Print("CARD: none, advance");
					num = ((int)num2 * -802460841) ^ -2137944372;
					continue;
				case 16u:
					flag4 = false;
					num = -1915737245;
					continue;
				case 15u:
				{
					int num10;
					int num11;
					if (!flag6)
					{
						num10 = 1475784505;
						num11 = 1475784505;
					}
					else
					{
						num10 = 1145349727;
						num11 = 1145349727;
					}
					num = num10 ^ ((int)num2 * -1211173626);
					continue;
				}
				case 14u:
					num = ((int)num2 * -199450586) ^ -1599009261;
					continue;
				case 13u:
					flag5 = playerState2.State != State.Playing;
					num = (int)(num2 * 612828681) ^ -1276844125;
					continue;
				case 12u:
					num = ((int)num2 * -1410775633) ^ -1251242460;
					continue;
				case 11u:
				{
					playerState2.State = State.Lose;
					int num8;
					int num9;
					if (Losers.Contains(playerIndex))
					{
						num8 = 167638414;
						num9 = 167638414;
					}
					else
					{
						num8 = 119300972;
						num9 = 119300972;
					}
					num = num8 ^ ((int)num2 * -1497837502);
					continue;
				}
				case 10u:
					flag4 = true;
					num = (int)((num2 * 1780339841) ^ 0x6066434D);
					continue;
				case 9u:
					Print(playerState2.State);
					num = ((int)num2 * -399417569) ^ 0xE7B86B2;
					continue;
				case 8u:
					flag3 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -487893490;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -1024425654;
						num7 = -1024425654;
					}
					else
					{
						num6 = -386428987;
						num7 = -386428987;
					}
					num = num6 ^ ((int)num2 * -1345240200);
					continue;
				}
				case 6u:
					playerState.Resources -= Game.smethod_3(0, num5 - Players[num3].PlannedForCard(card.Type));
					num = ((int)num2 * -1792911663) ^ -91991388;
					continue;
				case 5u:
					num = ((int)num2 * -1056913849) ^ -2060659470;
					continue;
				case 4u:
					num3 = 0;
					num = -1929361613;
					continue;
				case 3u:
					num5 = card.Impact;
					num = (int)((num2 * 361279908) ^ 0x42929AD);
					continue;
				case 2u:
					num = (int)((num2 * 285889865) ^ 0x180CC9D0);
					continue;
				case 1u:
					Losers.Add(num4);
					num = ((int)num2 * -841999864) ^ -899721825;
					continue;
				case 0u:
					flag = !Losers.Contains(num3);
					num = (int)((num2 * 1621474124) ^ 0x5AEEAFAF);
					continue;
				default:
					return;
				case 68u:
					break;
				case 80u:
					return;
					IL_0098:
					flag12 = (byte)num12 != 0;
					num = -1044369841;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		bool flag = default(bool);
		Card result = default(Card);
		Card card = default(Card);
		while (true)
		{
			int num = -53368545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD746FEDu) % 9u)
				{
				case 8u:
					flag = _deck.Count <= 0;
					num = (int)(num2 * 811572125) ^ -1030029591;
					continue;
				case 7u:
					result = card;
					num = ((int)num2 * -1935449553) ^ -116329080;
					continue;
				case 6u:
					card = _deck[0];
					num = -475692952;
					continue;
				case 4u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 458421411) ^ 0x79D96C7C);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1520777555;
						num4 = 1520777555;
					}
					else
					{
						num3 = 1920236052;
						num4 = 1920236052;
					}
					num = num3 ^ ((int)num2 * -896571584);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1909283957) ^ 0x54F028B0;
					continue;
				case 0u:
					ShuffleCards();
					num = ((int)num2 * -178659472) ^ -1764357452;
					continue;
				case 5u:
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
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -2065257715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD70CC3FCu) % 9u)
				{
				case 8u:
					num3++;
					num = (int)((num2 * 525718957) ^ 0x53958228);
					continue;
				case 5u:
					result = text;
					num = (int)((num2 * 408519107) ^ 0x4FF76AA0);
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 42214847;
						num5 = 42214847;
					}
					else
					{
						num4 = 1436160900;
						num5 = 1436160900;
					}
					num = num4 ^ (int)(num2 * 1174919214);
					continue;
				}
				case 3u:
					flag = num3 < _playerStates.Length;
					num = -191789857;
					continue;
				case 2u:
					text = "";
					num3 = 0;
					num = ((int)num2 * -2047444671) ^ -891540831;
					continue;
				case 1u:
					num = ((int)num2 * -1134889032) ^ -107510501;
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
					num = -86360381;
					continue;
				}
				case 6u:
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
		string result = ToString(initial: false);
		while (true)
		{
			int num = 964265712;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A3AA76Eu) % 3u)
				{
				case 2u:
					goto IL_000a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000a:
				num = ((int)num2 * -727702750) ^ -1621329308;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		while (true)
		{
			int num = -348450799;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x844166DBu) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				string string_ = Game.smethod_7(Game.smethod_5(text), more);
				Game.smethod_8(_buffer, string_);
				num = ((int)num2 * -2104979623) ^ 0x532B6815;
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
