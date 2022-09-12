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
			PlayerState[] playerStates = default(PlayerState[]);
			int num7 = default(int);
			bool flag = default(bool);
			PlayerState playerState = default(PlayerState);
			bool finished = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = 1849763719;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x74FF6E51u) % 17u)
					{
					case 16u:
						num = ((int)num2 * -632559516) ^ 0xDD66B66;
						continue;
					case 15u:
						playerStates = _playerStates;
						num7 = 0;
						num = ((int)num2 * -1761520934) ^ -898148368;
						continue;
					case 14u:
						flag = playerState.State == State.Playing;
						num = ((int)num2 * -314938892) ^ 0x785A173E;
						continue;
					case 13u:
					{
						int num5;
						int num6;
						if (!finished)
						{
							num5 = 242725324;
							num6 = 242725324;
						}
						else
						{
							num5 = 1376768766;
							num6 = 1376768766;
						}
						num = num5 ^ ((int)num2 * -1468011348);
						continue;
					}
					case 12u:
						num7++;
						num = 1350839770;
						continue;
					case 11u:
						result = false;
						num = (int)((num2 * 1398171574) ^ 0x2695496B);
						continue;
					case 10u:
						finished = _finished;
						num = (int)((num2 * 1079438391) ^ 0x4F8BB46B);
						continue;
					case 9u:
						result = true;
						num = ((int)num2 * -1439926908) ^ 0x56C2CC83;
						continue;
					case 8u:
					{
						int num8;
						if (num7 >= playerStates.Length)
						{
							num = 1957801048;
							num8 = 1957801048;
						}
						else
						{
							num = 1344272943;
							num8 = 1344272943;
						}
						continue;
					}
					case 7u:
						playerState = playerStates[num7];
						num = 316132587;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1250116455;
							num4 = 1250116455;
						}
						else
						{
							num3 = 782808681;
							num4 = 782808681;
						}
						num = num3 ^ (int)(num2 * 1865470809);
						continue;
					}
					case 5u:
						num = (int)(num2 * 883354513) ^ -2115733413;
						continue;
					case 3u:
						num = ((int)num2 * -1111199573) ^ 0x34259CA7;
						continue;
					case 1u:
						num = 366133230;
						continue;
					case 0u:
						result = true;
						num = (int)(num2 * 1059201300) ^ -2108079491;
						continue;
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
		int num5 = default(int);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = 2090802970;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B00A7A6u) % 18u)
				{
				case 17u:
					num5++;
					num = (int)(num2 * 602627147) ^ -1809579652;
					continue;
				case 16u:
					Players = new Player[count];
					num = ((int)num2 * -1443229145) ^ 0x190AF231;
					continue;
				case 15u:
					_playerStates[num5] = new PlayerState();
					num = 369833305;
					continue;
				case 14u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -607055615) ^ 0xDFCBB35;
					continue;
				case 13u:
					Rules = Rules.Deserialize(json["rules"]);
					_dice = new Dice();
					jSONNode = json["players"];
					num = (int)(num2 * 1377480679) ^ -116850457;
					continue;
				case 12u:
					_buffer = buffer;
					num = ((int)num2 * -414400898) ^ 0x5290960E;
					continue;
				case 11u:
					num = ((int)num2 * -732146194) ^ -1503711768;
					continue;
				case 10u:
					num = (int)(num2 * 1908180059) ^ -1878691214;
					continue;
				case 9u:
					flag = num5 < count;
					num = 1399846855;
					continue;
				case 8u:
					Players[num6] = Player.Deserialize(jSONNode[num6]);
					num6++;
					num = 1266066958;
					continue;
				case 7u:
					_playerStates = new PlayerState[count];
					num5 = 0;
					num = ((int)num2 * -1848356107) ^ -655943553;
					continue;
				case 4u:
					num = (int)(num2 * 1479025075) ^ -1073069573;
					continue;
				case 3u:
					num6 = 0;
					num = (int)((num2 * 798664282) ^ 0x209BE69);
					continue;
				case 2u:
				{
					int num7;
					if (num6 < count)
					{
						num = 993168194;
						num7 = 993168194;
					}
					else
					{
						num = 1305359013;
						num7 = 1305359013;
					}
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1607470;
						num4 = 1607470;
					}
					else
					{
						num3 = 491337679;
						num4 = 491337679;
					}
					num = num3 ^ (int)(num2 * 736760538);
					continue;
				}
				case 0u:
					count = jSONNode.Count;
					num = ((int)num2 * -1408754806) ^ -2062801204;
					continue;
				default:
					return;
				case 5u:
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
			int num = 1941560086;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F6AC80Au) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				_deck = new List<Card>(Rules.Cards);
				num = ((int)num2 * -1501363427) ^ 0x5CADD212;
			}
		}
	}

	public void StartNew()
	{
		ShuffleCards();
		while (true)
		{
			int num = 1692731911;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67184495u) % 7u)
				{
				case 4u:
					_currentTurn = 0;
					num = (int)(num2 * 2012148160) ^ -622538017;
					continue;
				case 3u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 1593675726) ^ 0x1A847449);
					continue;
				case 2u:
					_finished = false;
					_currentChanceIndex = -1;
					num = ((int)num2 * -1212921014) ^ -1724333367;
					continue;
				case 1u:
					Winners.Clear();
					num = ((int)num2 * -268089603) ^ -449823997;
					continue;
				case 0u:
					Losers.Clear();
					num = ((int)num2 * -2081567786) ^ -880496384;
					continue;
				case 5u:
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
		int num = 0;
		PlayerState playerState = default(PlayerState);
		int planningCardsCount = default(int);
		int num6 = default(int);
		bool flag2 = default(bool);
		Player player = default(Player);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 555916036;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x2E5E9235u) % 29u)
				{
				case 28u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num2 = 532057941;
					continue;
				case 27u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -1543681980) ^ -218569657;
					continue;
				case 26u:
					num2 = ((int)num3 * -816246572) ^ -1459780147;
					continue;
				case 24u:
					playerState = _playerStates[num];
					num2 = ((int)num3 * -276841534) ^ -1347941531;
					continue;
				case 22u:
					playerState.State = State.Playing;
					num2 = ((int)num3 * -633907401) ^ -286185442;
					continue;
				case 21u:
					flag2 = num < Players.Length;
					num2 = 915719581;
					continue;
				case 20u:
					num2 = 764588460;
					continue;
				case 19u:
					planningCardsCount = player.PlanningCardsCount;
					num6 = 0;
					num2 = ((int)num3 * -383889460) ^ 0x70C0306B;
					continue;
				case 18u:
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = 163725353;
					continue;
				case 17u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = 637199689;
						num12 = 637199689;
					}
					else
					{
						num11 = 376775876;
						num12 = 376775876;
					}
					num2 = num11 ^ (int)(num3 * 908469920);
					continue;
				}
				case 16u:
					num2 = (int)((num3 * 587760582) ^ 0x4CC4FC8E);
					continue;
				case 15u:
					playerState.Resources = Rules.InitialResources;
					num2 = (int)((num3 * 484699741) ^ 0x5B321351);
					continue;
				case 14u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -895471357;
						num10 = -895471357;
					}
					else
					{
						num9 = -1732843712;
						num10 = -1732843712;
					}
					num2 = num9 ^ ((int)num3 * -1430188243);
					continue;
				}
				case 13u:
					flag = num6 > 0;
					num2 = 1251172798;
					continue;
				case 12u:
					playerState.Sprint = 0;
					num2 = (int)((num3 * 1848580344) ^ 0x1ABAD733);
					continue;
				case 11u:
					num2 = ((int)num3 * -917291752) ^ 0x12F6670E;
					continue;
				case 10u:
					num++;
					num2 = (int)((num3 * 892503139) ^ 0x5B4A3E67);
					continue;
				case 9u:
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num2 = ((int)num3 * -440746961) ^ 0x2627079D;
					continue;
				case 8u:
					num2 = (int)((num3 * 1476939955) ^ 0x8D7A681);
					continue;
				case 7u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num2 = ((int)num3 * -812333706) ^ -1791797587;
					continue;
				case 6u:
					num6 = 0;
					num2 = 1483378641;
					continue;
				case 5u:
					player = Players[num];
					num2 = (int)(num3 * 1084369441) ^ -1018216901;
					continue;
				case 4u:
				{
					int num7;
					int num8;
					if (player.UseOneMorePlanningSprint)
					{
						num7 = 357507762;
						num8 = 357507762;
					}
					else
					{
						num7 = 1596404462;
						num8 = 1596404462;
					}
					num2 = num7 ^ (int)(num3 * 318441415);
					continue;
				}
				case 3u:
					num2 = (int)((num3 * 835745896) ^ 0xF2FEAE);
					continue;
				case 2u:
					num2 = 1894687479;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (planningCardsCount != 0)
					{
						num4 = -131316427;
						num5 = -131316427;
					}
					else
					{
						num4 = -922931961;
						num5 = -922931961;
					}
					num2 = num4 ^ ((int)num3 * -104539697);
					continue;
				}
				case 0u:
					playerState.Sprint = -1;
					num2 = ((int)num3 * -1098482772) ^ -1138074572;
					continue;
				default:
					return;
				case 23u:
					break;
				case 25u:
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
			int num = 1878287923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A564A68u) % 12u)
				{
				case 11u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)(num2 * 488161818) ^ -418170656;
					continue;
				case 10u:
					num = (int)((num2 * 1410274538) ^ 0x690A0DFD);
					continue;
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 654307235) ^ 0x2A6600DC);
					continue;
				case 8u:
					num = (int)((num2 * 366953495) ^ 0x6F6D02E0);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (_currentPlayer < Players.Length)
					{
						num5 = -878153782;
						num6 = -878153782;
					}
					else
					{
						num5 = -1739159704;
						num6 = -1739159704;
					}
					num = num5 ^ ((int)num2 * -1816118154);
					continue;
				}
				case 5u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 1733432833;
					continue;
				case 4u:
					PlayerTurn(_currentPlayer);
					num = 795852848;
					continue;
				case 3u:
					num = ((int)num2 * -1343024526) ^ -1570022418;
					continue;
				case 2u:
					_currentPlayer = 0;
					num = (int)(num2 * 611605567) ^ -1271599453;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_currentTurn > 0)
					{
						num3 = -874102938;
						num4 = -874102938;
					}
					else
					{
						num3 = -1993333092;
						num4 = -1993333092;
					}
					num = num3 ^ (int)(num2 * 1164916537);
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Card card = default(Card);
		bool flag = default(bool);
		bool flag11 = default(bool);
		int num3 = default(int);
		bool flag3 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag12 = default(bool);
		bool flag6 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		int num11 = default(int);
		int num8 = default(int);
		Player player = default(Player);
		bool flag13 = default(bool);
		bool flag5 = default(bool);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		while (true)
		{
			int num = -512381149;
			while (true)
			{
				uint num2;
				int num20;
				switch ((num2 = (uint)num ^ 0x98AA178Fu) % 94u)
				{
				case 93u:
					num = -1822199725;
					continue;
				case 92u:
					num = ((int)num2 * -1000393181) ^ -1314554734;
					continue;
				case 91u:
					num = (int)((num2 * 894056467) ^ 0x7E78A296);
					continue;
				case 90u:
					num = ((int)num2 * -826767347) ^ 0x745D36CC;
					continue;
				case 89u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag ? "ALL " : "", flag11 ? "receives" : "pays", Game.smethod_4(num3), flag3 ? "advance" : "stay");
					num = -398646984;
					continue;
				case 88u:
					playerState2.State = State.Lose;
					num = -586289950;
					continue;
				case 87u:
					num = ((int)num2 * -21056783) ^ 0x231A43AB;
					continue;
				case 86u:
					_finished = true;
					num = (int)((num2 * 650084486) ^ 0x3164EF8);
					continue;
				case 85u:
					flag12 = !flag11;
					num = (int)((num2 * 9975172) ^ 0x1EF6B6E3);
					continue;
				case 84u:
					flag6 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -651937647) ^ 0x46000BD3;
					continue;
				case 83u:
					num = (int)(num2 * 982746205) ^ -2054814246;
					continue;
				case 82u:
					num = -1018174295;
					continue;
				case 81u:
					num = ((int)num2 * -757039687) ^ -689740205;
					continue;
				case 80u:
					num = (int)((num2 * 1906403959) ^ 0x298F65D);
					continue;
				case 79u:
					playerState.Sprint++;
					num = (int)((num2 * 2141175631) ^ 0x4C93B44D);
					continue;
				case 78u:
					num20 = ((card.Type == 4) ? 1 : 0);
					goto IL_019b;
				case 77u:
					Winners.Add(playerIndex);
					num = (int)(num2 * 1898686739) ^ -281976893;
					continue;
				case 76u:
					num = ((int)num2 * -203265642) ^ -1275095708;
					continue;
				case 75u:
					num = ((int)num2 * -662432113) ^ 0x354FFBD7;
					continue;
				case 74u:
					flag4 = playerState.State != State.Playing;
					num = (int)((num2 * 1151314643) ^ 0x6BF1E90);
					continue;
				case 73u:
				{
					int num29;
					int num30;
					if (!flag2)
					{
						num29 = -1021160358;
						num30 = -1021160358;
					}
					else
					{
						num29 = -1351712357;
						num30 = -1351712357;
					}
					num = num29 ^ (int)(num2 * 71816812);
					continue;
				}
				case 72u:
				{
					int num23;
					int num24;
					if (!flag12)
					{
						num23 = -2071624989;
						num24 = -2071624989;
					}
					else
					{
						num23 = -1790034912;
						num24 = -1790034912;
					}
					num = num23 ^ (int)(num2 * 963307267);
					continue;
				}
				case 71u:
					flag11 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -787036798) ^ -627443987;
						continue;
					}
					num20 = 0;
					goto IL_019b;
				case 70u:
				{
					int num17;
					if (num11 >= _playerStates.Length)
					{
						num = -1083361228;
						num17 = -1083361228;
					}
					else
					{
						num = -381026792;
						num17 = -381026792;
					}
					continue;
				}
				case 69u:
					num = -1013169488;
					continue;
				case 68u:
					num = -1866752551;
					continue;
				case 67u:
					num = (int)((num2 * 1361430872) ^ 0x35509398);
					continue;
				case 66u:
				{
					int num12;
					if (Losers.Contains(num11))
					{
						num = -1675773740;
						num12 = -1675773740;
					}
					else
					{
						num = -269252830;
						num12 = -269252830;
					}
					continue;
				}
				case 65u:
					num = -1030363717;
					continue;
				case 64u:
					num = ((int)num2 * -1965968472) ^ -2104880293;
					continue;
				case 63u:
					playerState2 = _playerStates[num8];
					playerState2.Resources -= Game.smethod_3(0, num3 - Players[num8].PlannedForCard(card.Type));
					num = -1764732078;
					continue;
				case 62u:
					num = ((int)num2 * -175191528) ^ -182003916;
					continue;
				case 60u:
					Print("CARD: none, advance");
					num = (int)(num2 * 1683445182) ^ -1334773032;
					continue;
				case 59u:
					flag3 = true;
					num3 = card.Impact;
					num = ((int)num2 * -1111511295) ^ 0x567060A3;
					continue;
				case 58u:
					flag2 = !flag;
					num = (int)((num2 * 1135559619) ^ 0x56697094);
					continue;
				case 57u:
					num = (int)(num2 * 186986928) ^ -1184612009;
					continue;
				case 56u:
					num11++;
					num = -1060222049;
					continue;
				case 55u:
					Losers.Add(num11);
					num = ((int)num2 * -1926615604) ^ 0x3B1AA907;
					continue;
				case 54u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -1172563996;
					continue;
				}
				case 53u:
				{
					int num35 = card.Impact - player.PlannedForCard(card.Type);
					flag3 = num35 < Rules.StayOnSprintMinDiff;
					num3 = Game.smethod_3(0, num35);
					num = ((int)num2 * -1063943235) ^ 0x786F02AC;
					continue;
				}
				case 52u:
					num = ((int)num2 * -428590450) ^ -2122000256;
					continue;
				case 51u:
					num = -1185894679;
					continue;
				case 50u:
					num = ((int)num2 * -1359588569) ^ 0x41F51C4;
					continue;
				case 49u:
					playerState.State = State.Won;
					num = (int)(num2 * 707405491) ^ -294854005;
					continue;
				case 48u:
					flag13 = playerState.Sprint < 0;
					num = -677098272;
					continue;
				case 46u:
					card = DrawCard();
					num = (int)(num2 * 1555432989) ^ -1675582176;
					continue;
				case 45u:
				{
					int num34;
					if (playerState.Sprint <= Rules.SprintCount)
					{
						num = -1822199725;
						num34 = -1822199725;
					}
					else
					{
						num = -121482143;
						num34 = -121482143;
					}
					continue;
				}
				case 44u:
				{
					int num32;
					int num33;
					if (flag5)
					{
						num32 = -517615031;
						num33 = -517615031;
					}
					else
					{
						num32 = -1816062994;
						num33 = -1816062994;
					}
					num = num32 ^ (int)(num2 * 550205652);
					continue;
				}
				case 43u:
					num = ((int)num2 * -1439874078) ^ 0x48780569;
					continue;
				case 42u:
					num = -77559206;
					continue;
				case 41u:
				{
					int num31;
					if (flag3)
					{
						num = -1283060116;
						num31 = -1283060116;
					}
					else
					{
						num = -1501893056;
						num31 = -1501893056;
					}
					continue;
				}
				case 40u:
					num = (int)(num2 * 1381657607) ^ -831003203;
					continue;
				case 39u:
				{
					int num27;
					int num28;
					if (flag8)
					{
						num27 = 650283562;
						num28 = 650283562;
					}
					else
					{
						num27 = 1542575856;
						num28 = 1542575856;
					}
					num = num27 ^ ((int)num2 * -793367715);
					continue;
				}
				case 38u:
					num = (int)((num2 * 265186631) ^ 0x203A459D);
					continue;
				case 37u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)(num2 * 729899605) ^ -280532209;
					continue;
				case 36u:
					flag3 = false;
					num = -1589183762;
					continue;
				case 35u:
				{
					int num25;
					int num26;
					if (flag13)
					{
						num25 = 1895986132;
						num26 = 1895986132;
					}
					else
					{
						num25 = 1542333316;
						num26 = 1542333316;
					}
					num = num25 ^ (int)(num2 * 557106824);
					continue;
				}
				case 34u:
					flag3 = true;
					num = ((int)num2 * -308340315) ^ -1064300949;
					continue;
				case 33u:
					num = ((int)num2 * -1743145439) ^ -159473610;
					continue;
				case 32u:
					num = (int)((num2 * 422994008) ^ 0x6532F8F0);
					continue;
				case 31u:
				{
					int num21;
					int num22;
					if (flag9)
					{
						num21 = -1238629780;
						num22 = -1238629780;
					}
					else
					{
						num21 = -1912919783;
						num22 = -1912919783;
					}
					num = num21 ^ (int)(num2 * 805209008);
					continue;
				}
				case 30u:
					num = ((int)num2 * -631351973) ^ -1842540748;
					continue;
				case 29u:
					num = ((int)num2 * -2007087117) ^ -490632932;
					continue;
				case 28u:
					Print("Still planning");
					num = (int)((num2 * 691518403) ^ 0x75EB2259);
					continue;
				case 27u:
					num8 = 0;
					num = -1949276841;
					continue;
				case 26u:
				{
					int num18;
					int num19;
					if (!flag10)
					{
						num18 = -685418111;
						num19 = -685418111;
					}
					else
					{
						num18 = -1214144905;
						num19 = -1214144905;
					}
					num = num18 ^ ((int)num2 * -2114884622);
					continue;
				}
				case 25u:
					num11 = 0;
					num = (int)((num2 * 946893435) ^ 0x5185A78A);
					continue;
				case 24u:
					num = (int)(num2 * 390254745) ^ -982430374;
					continue;
				case 23u:
					flag10 = num11 == playerIndex;
					num = ((int)num2 * -1508445274) ^ -747852061;
					continue;
				case 22u:
				{
					int num15;
					int num16;
					if (!flag7)
					{
						num15 = -258127635;
						num16 = -258127635;
					}
					else
					{
						num15 = -96699906;
						num16 = -96699906;
					}
					num = num15 ^ ((int)num2 * -313855602);
					continue;
				}
				case 21u:
					num = (int)(num2 * 1270842985) ^ -1274864590;
					continue;
				case 20u:
					player = Players[playerIndex];
					num = ((int)num2 * -1198863948) ^ 0x6A383CB0;
					continue;
				case 19u:
					flag9 = playerState2.Resources >= 0;
					num = ((int)num2 * -368034257) ^ 0x71000F6B;
					continue;
				case 18u:
					num = (int)(num2 * 24122848) ^ -1721854051;
					continue;
				case 17u:
					flag8 = !Losers.Contains(num8);
					num = ((int)num2 * -490755837) ^ 0x2EA9A545;
					continue;
				case 16u:
					num8++;
					num = -764618964;
					continue;
				case 15u:
					Print(playerState.State);
					num = ((int)num2 * -1844955038) ^ -2043982898;
					continue;
				case 14u:
					Losers.Add(num8);
					num = ((int)num2 * -1461961340) ^ -1329351405;
					continue;
				case 13u:
					playerState = _playerStates[playerIndex];
					num = ((int)num2 * -1612084293) ^ 0x46C8CCFB;
					continue;
				case 12u:
					num = ((int)num2 * -1456027653) ^ 0x1AABA1FB;
					continue;
				case 11u:
					flag7 = num8 < _playerStates.Length;
					num = -709283171;
					continue;
				case 10u:
					num = ((int)num2 * -1062705187) ^ 0x3BDA93AB;
					continue;
				case 9u:
				{
					int num13;
					int num14;
					if (!Rules.OnlyOneWinner)
					{
						num13 = -528081712;
						num14 = -528081712;
					}
					else
					{
						num13 = -2023603696;
						num14 = -2023603696;
					}
					num = num13 ^ ((int)num2 * -178023632);
					continue;
				}
				case 8u:
				{
					int num9;
					int num10;
					if (flag6)
					{
						num9 = -1399640075;
						num10 = -1399640075;
					}
					else
					{
						num9 = -1382912037;
						num10 = -1382912037;
					}
					num = num9 ^ ((int)num2 * -1988759540);
					continue;
				}
				case 7u:
					flag5 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -323702679;
					continue;
				case 6u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 820814352) ^ 0x63E5E7D);
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (!flag4)
					{
						num6 = -18025306;
						num7 = -18025306;
					}
					else
					{
						num6 = -1338511628;
						num7 = -1338511628;
					}
					num = num6 ^ ((int)num2 * -995657633);
					continue;
				}
				case 4u:
					playerState.Sprint++;
					num = (int)((num2 * 873069523) ^ 0x33F901B5);
					continue;
				case 3u:
					num = -1997064234;
					continue;
				case 2u:
					num = (int)((num2 * 1126942810) ^ 0x4EAB8EE4);
					continue;
				case 1u:
					playerState.State = State.Lose;
					num = ((int)num2 * -958579514) ^ -1284292637;
					continue;
				case 0u:
				{
					playerState.Resources -= num3;
					int num4;
					int num5;
					if (playerState.Resources < 0)
					{
						num4 = 1275108443;
						num5 = 1275108443;
					}
					else
					{
						num4 = 7862147;
						num5 = 7862147;
					}
					num = num4 ^ (int)(num2 * 537727855);
					continue;
				}
				default:
					return;
				case 61u:
					break;
				case 47u:
					return;
					IL_019b:
					flag = (byte)num20 != 0;
					num = -265061792;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		if (_deck.Count <= 0)
		{
			goto IL_0077;
		}
		goto IL_00ad;
		IL_00ad:
		Card card = _deck[0];
		int num = 1265356311;
		goto IL_007c;
		IL_007c:
		Card result = default(Card);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x64548A8Eu) % 8u)
			{
			case 7u:
				ShuffleCards();
				num = (int)(num2 * 2043801034) ^ -716222570;
				continue;
			case 6u:
				num = ((int)num2 * -734249372) ^ 0x6F535904;
				continue;
			case 5u:
				result = card;
				num = (int)((num2 * 1133373427) ^ 0x647CFDCA);
				continue;
			case 4u:
				num = (int)(num2 * 770461029) ^ -99731705;
				continue;
			case 1u:
				_deck.RemoveAt(0);
				num = (int)(num2 * 1042108146) ^ -2035685264;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_00ad;
			default:
				return result;
			}
			break;
		}
		goto IL_0077;
		IL_0077:
		num = 1220912065;
		goto IL_007c;
	}

	public string ToString(bool initial)
	{
		bool flag = default(bool);
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -891150931;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8CD9A4Du) % 9u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1039487501;
						num5 = 1039487501;
					}
					else
					{
						num4 = 1484647744;
						num5 = 1484647744;
					}
					num = num4 ^ ((int)num2 * -619384481);
					continue;
				}
				case 6u:
					result = text;
					num = ((int)num2 * -698240117) ^ 0x49F5C625;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -1892719285) ^ 0xBA76928;
					continue;
				case 3u:
					num = ((int)num2 * -1473344221) ^ 0x1625EB45;
					continue;
				case 2u:
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
					num3++;
					num = -1801827784;
					continue;
				}
				case 1u:
					text = "";
					num = ((int)num2 * -1405181792) ^ -1721419395;
					continue;
				case 0u:
					flag = num3 < _playerStates.Length;
					num = -1514906219;
					continue;
				case 8u:
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
			int num = 1393452893;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79346D34u) % 4u)
				{
				case 1u:
					result = ToString(initial: false);
					num = ((int)num2 * -727136492) ^ 0x2DACDAD0;
					continue;
				case 0u:
					num = (int)((num2 * 1050438667) ^ 0xB3A8737);
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
		string string_ = Game.smethod_7(Game.smethod_5(text), more);
		Game.smethod_8(_buffer, string_);
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
