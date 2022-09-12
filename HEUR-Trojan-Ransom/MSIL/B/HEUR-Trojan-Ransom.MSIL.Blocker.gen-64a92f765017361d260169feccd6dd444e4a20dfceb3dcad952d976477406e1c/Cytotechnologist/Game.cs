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
			bool flag = default(bool);
			PlayerState[] playerStates = default(PlayerState[]);
			int num5 = default(int);
			bool result = default(bool);
			while (true)
			{
				int num = 1835275018;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x271FDB26u) % 14u)
					{
					case 13u:
					{
						int num7;
						int num8;
						if (flag)
						{
							num7 = 1210975839;
							num8 = 1210975839;
						}
						else
						{
							num7 = 281236606;
							num8 = 281236606;
						}
						num = num7 ^ ((int)num2 * -1113773732);
						continue;
					}
					case 11u:
					{
						PlayerState playerState = playerStates[num5];
						flag = playerState.State == State.Playing;
						num = 936079363;
						continue;
					}
					case 9u:
						num5 = 0;
						num = ((int)num2 * -1001210734) ^ -1138290885;
						continue;
					case 8u:
						playerStates = _playerStates;
						num = 251319827;
						continue;
					case 7u:
						num = (int)(num2 * 686800726) ^ -941095393;
						continue;
					case 6u:
						num = (int)((num2 * 276434368) ^ 0x1332BFF0);
						continue;
					case 5u:
						result = false;
						num = ((int)num2 * -1981894180) ^ -1483012740;
						continue;
					case 4u:
						num5++;
						num = 1448599557;
						continue;
					case 3u:
					{
						int num6;
						if (num5 < playerStates.Length)
						{
							num = 1524101313;
							num6 = 1524101313;
						}
						else
						{
							num = 656467170;
							num6 = 656467170;
						}
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (!finished)
						{
							num3 = 139487076;
							num4 = 139487076;
						}
						else
						{
							num3 = 300442371;
							num4 = 300442371;
						}
						num = num3 ^ (int)(num2 * 1414869212);
						continue;
					}
					case 1u:
						result = true;
						num = (int)(num2 * 214861154) ^ -1404794628;
						continue;
					case 0u:
						result = true;
						num = ((int)num2 * -1527750211) ^ 0x5DFF444;
						continue;
					case 10u:
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
			int num = -242179579;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC756ABC1u) % 11u)
				{
				case 10u:
					_currentPlayer = Players.Length;
					num = (int)(num2 * 2008711723) ^ -233384299;
					continue;
				case 9u:
					ShuffleCards();
					num = ((int)num2 * -1506966613) ^ 0x4999D5F7;
					continue;
				case 6u:
					Losers.Clear();
					num = (int)((num2 * 1632544547) ^ 0x3B5B0982);
					continue;
				case 5u:
					_currentChanceIndex = -1;
					num = (int)((num2 * 1984850163) ^ 0x271B49EB);
					continue;
				case 4u:
					_currentTurn = 0;
					num = (int)(num2 * 2078861789) ^ -29184245;
					continue;
				case 3u:
					num = ((int)num2 * -2080297924) ^ -1825248339;
					continue;
				case 2u:
					Winners.Clear();
					num = (int)((num2 * 109015961) ^ 0x52579F8F);
					continue;
				case 1u:
					num = ((int)num2 * -1115144271) ^ -459431559;
					continue;
				case 0u:
					_finished = false;
					num = ((int)num2 * -667525557) ^ -1687081165;
					continue;
				case 8u:
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
		Player player = default(Player);
		PlayerState playerState = default(PlayerState);
		int planningCardsCount = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num2 = 1670867038;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x327D02FFu) % 24u)
				{
				case 23u:
					player = Players[num];
					playerState = _playerStates[num];
					num2 = ((int)num3 * -2041883637) ^ 0x3039C88B;
					continue;
				case 22u:
				{
					int num9;
					int num10;
					if (planningCardsCount != 0)
					{
						num9 = 875279283;
						num10 = 875279283;
					}
					else
					{
						num9 = 1357155538;
						num10 = 1357155538;
					}
					num2 = num9 ^ (int)(num3 * 1556887864);
					continue;
				}
				case 21u:
					playerState.Sprint = 1;
					num2 = (int)((num3 * 1555695592) ^ 0x55727B8);
					continue;
				case 20u:
					num2 = 510837311;
					continue;
				case 19u:
					flag = num6 > 0;
					num2 = 1859542853;
					continue;
				case 18u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = ((int)num3 * -1325527844) ^ -1342578586;
					continue;
				case 17u:
					num6 = 0;
					num2 = (int)((num3 * 1742240339) ^ 0xCD507E2);
					continue;
				case 16u:
				{
					int num8;
					if (num < Players.Length)
					{
						num2 = 452830306;
						num8 = 452830306;
					}
					else
					{
						num2 = 2133306065;
						num8 = 2133306065;
					}
					continue;
				}
				case 15u:
					num2 = (int)((num3 * 2059203727) ^ 0x4B64A9C2);
					continue;
				case 14u:
					playerState.State = State.Playing;
					num2 = (int)(num3 * 1368272455) ^ -1096505985;
					continue;
				case 13u:
					num6 = 0;
					num2 = 377608587;
					continue;
				case 11u:
					playerState.Sprint = -1;
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num2 = (int)((num3 * 193589660) ^ 0x297DC44C);
					continue;
				case 10u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num2 = (int)((num3 * 2138677580) ^ 0x2D24DEB3);
					continue;
				case 9u:
					num2 = (int)((num3 * 1167198561) ^ 0x35CE5F26);
					continue;
				case 8u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num2 = 322861068;
					continue;
				case 7u:
					num2 = ((int)num3 * -1453620367) ^ -810764128;
					continue;
				case 5u:
					num2 = 630258936;
					continue;
				case 4u:
				{
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					int num7;
					if (player.UseOneMorePlanningSprint)
					{
						num2 = 1291024375;
						num7 = 1291024375;
					}
					else
					{
						num2 = 1283989740;
						num7 = 1283989740;
					}
					continue;
				}
				case 3u:
					num++;
					num2 = (int)(num3 * 147989019) ^ -1570606458;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -782923872;
						num5 = -782923872;
					}
					else
					{
						num4 = -946443281;
						num5 = -946443281;
					}
					num2 = num4 ^ (int)(num3 * 2055062681);
					continue;
				}
				case 1u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					num2 = (int)(num3 * 1202944320) ^ -1302278479;
					continue;
				case 0u:
					num2 = ((int)num3 * -1205970585) ^ -217090508;
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

	public void TurnState()
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -853914224;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE42F58B1u) % 12u)
				{
				case 11u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -1849956372;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1912658060;
						num6 = -1912658060;
					}
					else
					{
						num5 = -387071138;
						num6 = -387071138;
					}
					num = num5 ^ ((int)num2 * -1181830652);
					continue;
				}
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -1477098744) ^ -1478781825;
					continue;
				case 8u:
					flag = _currentTurn > 0;
					num = ((int)num2 * -1555983070) ^ -2072037409;
					continue;
				case 7u:
					num = ((int)num2 * -1046917842) ^ -1123015471;
					continue;
				case 6u:
					num = ((int)num2 * -1979203228) ^ -1014193886;
					continue;
				case 5u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1713749544) ^ 0x2808B89E;
					continue;
				case 4u:
					_currentPlayer = 0;
					num = ((int)num2 * -1063592773) ^ 0x5143DD11;
					continue;
				case 3u:
					num = (int)((num2 * 1495125414) ^ 0x148D552C);
					continue;
				case 1u:
				{
					_currentPlayer++;
					int num3;
					int num4;
					if (_currentPlayer < Players.Length)
					{
						num3 = 1461595225;
						num4 = 1461595225;
					}
					else
					{
						num3 = 400766111;
						num4 = 400766111;
					}
					num = num3 ^ ((int)num2 * -1472007502);
					continue;
				}
				case 0u:
					break;
				default:
					PlayerTurn(_currentPlayer);
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		PlayerState playerState2 = default(PlayerState);
		int num3 = default(int);
		int num21 = default(int);
		Card card = default(Card);
		bool flag9 = default(bool);
		bool flag13 = default(bool);
		bool flag8 = default(bool);
		int num4 = default(int);
		int num14 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag12 = default(bool);
		bool flag7 = default(bool);
		bool flag10 = default(bool);
		bool flag2 = default(bool);
		bool flag6 = default(bool);
		bool flag5 = default(bool);
		bool flag11 = default(bool);
		while (true)
		{
			int num = 1293805491;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0x2F988120u) % 81u)
				{
				case 80u:
				{
					playerState2.Resources -= Game.smethod_3(0, num3 - Players[num21].PlannedForCard(card.Type));
					int num30;
					int num31;
					if (playerState2.Resources >= 0)
					{
						num30 = -487779708;
						num31 = -487779708;
					}
					else
					{
						num30 = -1011019591;
						num31 = -1011019591;
					}
					num = num30 ^ (int)(num2 * 1666450842);
					continue;
				}
				case 79u:
				{
					int num22;
					int num23;
					if (!flag9)
					{
						num22 = 1503339572;
						num23 = 1503339572;
					}
					else
					{
						num22 = 1404401592;
						num23 = 1404401592;
					}
					num = num22 ^ ((int)num2 * -2041088088);
					continue;
				}
				case 78u:
					num11 = ((card.Type == 4) ? 1 : 0);
					goto IL_00a1;
				case 77u:
					flag13 = !flag8;
					num = (int)((num2 * 895735795) ^ 0x2F991416);
					continue;
				case 76u:
					Losers.Add(num4);
					num = (int)((num2 * 604875502) ^ 0x5A88685F);
					continue;
				case 75u:
					num14 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)((num2 * 1407006371) ^ 0x124C181E);
					continue;
				case 74u:
					num = ((int)num2 * -1660816190) ^ -1918071910;
					continue;
				case 73u:
					num = 934568885;
					continue;
				case 72u:
				{
					int num17;
					int num18;
					if (flag)
					{
						num17 = -143196025;
						num18 = -143196025;
					}
					else
					{
						num17 = -1863439817;
						num18 = -1863439817;
					}
					num = num17 ^ ((int)num2 * -499501091);
					continue;
				}
				case 71u:
					flag3 = num4 == playerIndex;
					num = (int)(num2 * 618533207) ^ -839556290;
					continue;
				case 70u:
					num3 = Game.smethod_3(0, num14);
					num = ((int)num2 * -883716772) ^ -135974753;
					continue;
				case 69u:
				{
					int num7;
					int num8;
					if (flag4)
					{
						num7 = -597557273;
						num8 = -597557273;
					}
					else
					{
						num7 = -292172174;
						num8 = -292172174;
					}
					num = num7 ^ ((int)num2 * -300642821);
					continue;
				}
				case 68u:
					num = ((int)num2 * -942396172) ^ -1076382852;
					continue;
				case 67u:
					Print(playerState.State);
					num = ((int)num2 * -846631737) ^ -693334207;
					continue;
				case 66u:
				{
					int num34;
					if (num21 >= _playerStates.Length)
					{
						num = 99931544;
						num34 = 99931544;
					}
					else
					{
						num = 1807036795;
						num34 = 1807036795;
					}
					continue;
				}
				case 65u:
					num = 817970730;
					continue;
				case 64u:
					flag4 = !Losers.Contains(num21);
					num = ((int)num2 * -643426325) ^ 0x758AD6EF;
					continue;
				case 63u:
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 1921556381) ^ 0x3ACC1056);
					continue;
				case 62u:
				{
					int num26;
					int num27;
					if (!flag12)
					{
						num26 = -1599922547;
						num27 = -1599922547;
					}
					else
					{
						num26 = -1133752096;
						num27 = -1133752096;
					}
					num = num26 ^ (int)(num2 * 1687999196);
					continue;
				}
				case 61u:
					num = 1137540812;
					continue;
				case 60u:
					num = (int)((num2 * 392424709) ^ 0xCAE965B);
					continue;
				case 59u:
					num = ((int)num2 * -2004773550) ^ -1995879985;
					continue;
				case 58u:
					playerState2.State = State.Lose;
					num = 930391543;
					continue;
				case 57u:
					num = (int)((num2 * 972140418) ^ 0x1F26EE8A);
					continue;
				case 56u:
					num = ((int)num2 * -1102606132) ^ -996372742;
					continue;
				case 55u:
					num = 40742626;
					continue;
				case 54u:
					num21++;
					num = 346590128;
					continue;
				case 53u:
					num = 57486332;
					continue;
				case 52u:
					flag7 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 1828257619;
					continue;
				case 51u:
					flag10 = num14 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -564511309) ^ 0x7451A01A;
					continue;
				case 50u:
					playerState.State = State.Won;
					num = (int)((num2 * 148829909) ^ 0x7160EB43);
					continue;
				case 49u:
					playerState2 = _playerStates[num21];
					num = (int)((num2 * 915983934) ^ 0x6220E3C7);
					continue;
				case 48u:
					flag9 = playerState.Sprint < 0;
					num = 468507610;
					continue;
				case 47u:
					flag8 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 1199347459) ^ 0x11AFBFA9);
						continue;
					}
					num11 = 0;
					goto IL_00a1;
				case 46u:
					num = ((int)num2 * -1297277478) ^ -1175361386;
					continue;
				case 45u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -1896572646;
						num10 = -1896572646;
					}
					else
					{
						num9 = -1980763571;
						num10 = -1980763571;
					}
					num = num9 ^ ((int)num2 * -1289459389);
					continue;
				}
				case 44u:
				{
					int num37;
					int num38;
					if (flag6)
					{
						num37 = -1999337103;
						num38 = -1999337103;
					}
					else
					{
						num37 = -491128639;
						num38 = -491128639;
					}
					num = num37 ^ (int)(num2 * 1418987243);
					continue;
				}
				case 43u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1990956074) ^ 0x3AB8A616;
					continue;
				case 42u:
					flag12 = flag10;
					num = 1027923187;
					continue;
				case 41u:
				{
					int num35;
					int num36;
					if (!Rules.OnlyOneWinner)
					{
						num35 = 943346074;
						num36 = 943346074;
					}
					else
					{
						num35 = 1892457429;
						num36 = 1892457429;
					}
					num = num35 ^ ((int)num2 * -1867670707);
					continue;
				}
				case 40u:
					num = (int)(num2 * 1690591980) ^ -767367860;
					continue;
				case 39u:
					_finished = true;
					num4 = 0;
					num = ((int)num2 * -533766547) ^ -544549976;
					continue;
				case 38u:
					flag10 = true;
					num = (int)((num2 * 1443536458) ^ 0xBBA4118);
					continue;
				case 37u:
				{
					int num32;
					int num33;
					if (playerState.State != 0)
					{
						num32 = 714133463;
						num33 = 714133463;
					}
					else
					{
						num32 = 1725398089;
						num33 = 1725398089;
					}
					num = num32 ^ ((int)num2 * -416260957);
					continue;
				}
				case 36u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)(num2 * 592142491) ^ -1808598631;
					continue;
				case 35u:
					num = ((int)num2 * -50492386) ^ -520452155;
					continue;
				case 34u:
					flag10 = true;
					num3 = card.Impact;
					num = 776403611;
					continue;
				case 33u:
					Winners.Add(playerIndex);
					num = ((int)num2 * -1781564039) ^ -912837611;
					continue;
				case 31u:
				{
					int num28;
					int num29;
					if (!flag13)
					{
						num28 = -1561363765;
						num29 = -1561363765;
					}
					else
					{
						num28 = -1615720721;
						num29 = -1615720721;
					}
					num = num28 ^ (int)(num2 * 230061019);
					continue;
				}
				case 30u:
					Losers.Add(num21);
					num = (int)((num2 * 455485208) ^ 0x5149677F);
					continue;
				case 29u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag5 ? "ALL " : "", flag8 ? "receives" : "pays", Game.smethod_4(num3), flag10 ? "advance" : "stay");
					num = 718961;
					continue;
				case 28u:
					playerState.State = State.Lose;
					num = (int)(num2 * 1311304758) ^ -1746945756;
					continue;
				case 27u:
					num = ((int)num2 * -1755021408) ^ 0x69513B8D;
					continue;
				case 25u:
					flag11 = playerState.Resources < 0;
					num = ((int)num2 * -1077858933) ^ 0x1BC080A5;
					continue;
				case 24u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 1398995915;
					continue;
				}
				case 23u:
					num21 = 0;
					num = (int)((num2 * 1998051184) ^ 0x17E4E9F0);
					continue;
				case 22u:
					num = (int)(num2 * 394609551) ^ -736923723;
					continue;
				case 21u:
				{
					int num24;
					int num25;
					if (flag11)
					{
						num24 = 1651634311;
						num25 = 1651634311;
					}
					else
					{
						num24 = 1885903711;
						num25 = 1885903711;
					}
					num = num24 ^ ((int)num2 * -729000772);
					continue;
				}
				case 20u:
					flag10 = false;
					num = 1135608614;
					continue;
				case 19u:
					num4++;
					num = 1901819105;
					continue;
				case 18u:
				{
					int num19;
					int num20;
					if (!Losers.Contains(playerIndex))
					{
						num19 = 77848451;
						num20 = 77848451;
					}
					else
					{
						num19 = 365061238;
						num20 = 365061238;
					}
					num = num19 ^ ((int)num2 * -1074087095);
					continue;
				}
				case 17u:
				{
					int num15;
					int num16;
					if (!flag7)
					{
						num15 = -298664488;
						num16 = -298664488;
					}
					else
					{
						num15 = -933151580;
						num16 = -933151580;
					}
					num = num15 ^ ((int)num2 * -225585900);
					continue;
				}
				case 16u:
					num = 1280578941;
					continue;
				case 15u:
					num = (int)(num2 * 934467927) ^ -1582109508;
					continue;
				case 14u:
					num = ((int)num2 * -1799603309) ^ -2131015994;
					continue;
				case 13u:
					flag6 = num4 < _playerStates.Length;
					num = 598095850;
					continue;
				case 12u:
				{
					int num12;
					int num13;
					if (flag5)
					{
						num12 = 1688252500;
						num13 = 1688252500;
					}
					else
					{
						num12 = 2066422269;
						num13 = 2066422269;
					}
					num = num12 ^ (int)(num2 * 1403081580);
					continue;
				}
				case 11u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = -1480324527;
						num6 = -1480324527;
					}
					else
					{
						num5 = -361912463;
						num6 = -361912463;
					}
					num = num5 ^ (int)(num2 * 707033078);
					continue;
				}
				case 10u:
					flag2 = !Losers.Contains(num4);
					num = 1749460135;
					continue;
				case 9u:
					Print("CARD: none, advance");
					num = (int)((num2 * 1277258616) ^ 0x4127F99C);
					continue;
				case 8u:
					num = (int)(num2 * 126018103) ^ -914942923;
					continue;
				case 7u:
					card = DrawCard();
					num = 1244152887;
					continue;
				case 6u:
					playerState.Resources -= num3;
					num = (int)(num2 * 775696972) ^ -1802064476;
					continue;
				case 5u:
					num = ((int)num2 * -1929306231) ^ 0x33CD746F;
					continue;
				case 4u:
					flag = playerState.Sprint > Rules.SprintCount;
					num = 581314657;
					continue;
				case 3u:
					num = 1173752396;
					continue;
				case 2u:
					num = 1212326620;
					continue;
				case 1u:
					num = (int)(num2 * 1285366793) ^ -579311901;
					continue;
				case 0u:
					playerState.Sprint++;
					num = (int)(num2 * 877100320) ^ -834158759;
					continue;
				default:
					return;
				case 26u:
					break;
				case 32u:
					return;
					IL_00a1:
					flag5 = (byte)num11 != 0;
					num = 470689806;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card result = default(Card);
		Card card = default(Card);
		bool flag = default(bool);
		while (true)
		{
			int num = -904784228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC658CE2Du) % 8u)
				{
				case 7u:
					result = card;
					num = ((int)num2 * -1410394762) ^ -1022317910;
					continue;
				case 5u:
					num = (int)((num2 * 532016154) ^ 0x185531);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1963646917;
						num4 = 1963646917;
					}
					else
					{
						num3 = 1478340639;
						num4 = 1478340639;
					}
					num = num3 ^ (int)(num2 * 226284368);
					continue;
				}
				case 2u:
					ShuffleCards();
					num = (int)(num2 * 981755763) ^ -1448942669;
					continue;
				case 1u:
					flag = _deck.Count <= 0;
					num = (int)(num2 * 1845347152) ^ -1783618591;
					continue;
				case 0u:
					card = _deck[0];
					_deck.RemoveAt(0);
					num = -118229766;
					continue;
				case 3u:
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
		string text = "";
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1645947147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDDA08694u) % 8u)
				{
				case 7u:
					flag = num3 < _playerStates.Length;
					num = -1800109384;
					continue;
				case 6u:
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
					num = -1069965357;
					continue;
				}
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -178352742;
						num5 = -178352742;
					}
					else
					{
						num4 = -715345450;
						num5 = -715345450;
					}
					num = num4 ^ (int)(num2 * 2115011083);
					continue;
				}
				case 2u:
					result = text;
					num = ((int)num2 * -968409807) ^ -1619012667;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1202989361) ^ -748676701;
					continue;
				case 0u:
					num = (int)((num2 * 1102650617) ^ 0x4697B74B);
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1861535081;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9B9F16Eu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1666543246) ^ -1272976771;
					continue;
				case 1u:
					result = ToString(initial: false);
					num = (int)((num2 * 829849345) ^ 0x47D6E265);
					continue;
				case 0u:
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
		while (true)
		{
			int num = 689742112;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x131A0D52u) % 3u)
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
				string string_ = Game.smethod_7(Game.smethod_5(text), more);
				Game.smethod_8(_buffer, string_);
				num = (int)((num2 * 2111840352) ^ 0xE05698F);
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
