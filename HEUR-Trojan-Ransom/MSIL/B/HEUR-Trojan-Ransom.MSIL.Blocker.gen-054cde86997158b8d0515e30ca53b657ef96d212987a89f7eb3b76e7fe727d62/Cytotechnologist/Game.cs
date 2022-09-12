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
			int num3 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			while (true)
			{
				int num = -1972810538;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x956468B9u) % 14u)
					{
					case 13u:
						num = (int)((num2 * 614975320) ^ 0x5A20097D);
						continue;
					case 11u:
					{
						int num6;
						int num7;
						if (!_finished)
						{
							num6 = -2015038953;
							num7 = -2015038953;
						}
						else
						{
							num6 = -1734225021;
							num7 = -1734225021;
						}
						num = num6 ^ (int)(num2 * 737676070);
						continue;
					}
					case 9u:
						result = false;
						num = ((int)num2 * -232868590) ^ 0x178879FF;
						continue;
					case 8u:
						num = (int)(num2 * 1559998243) ^ -1557424963;
						continue;
					case 7u:
					{
						int num5;
						if (num3 >= playerStates.Length)
						{
							num = -30304401;
							num5 = -30304401;
						}
						else
						{
							num = -1334643990;
							num5 = -1334643990;
						}
						continue;
					}
					case 6u:
						result = true;
						num = ((int)num2 * -1924870245) ^ -2132768861;
						continue;
					case 5u:
						num3 = 0;
						num = ((int)num2 * -1318377108) ^ -1889121870;
						continue;
					case 4u:
						result = true;
						num = (int)((num2 * 1104080127) ^ 0x26D00E58);
						continue;
					case 3u:
					{
						PlayerState playerState = playerStates[num3];
						int num4;
						if (playerState.State == State.Playing)
						{
							num = -44846468;
							num4 = -44846468;
						}
						else
						{
							num = -21754833;
							num4 = -21754833;
						}
						continue;
					}
					case 2u:
						num3++;
						num = -1481363258;
						continue;
					case 1u:
						playerStates = _playerStates;
						num = (int)((num2 * 747907458) ^ 0x2E1FAA38);
						continue;
					case 0u:
						num = -1706331926;
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
		while (true)
		{
			int num = 1813835807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x196B465Fu) % 3u)
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
				num = ((int)num2 * -1990826477) ^ -2077249166;
			}
		}
	}

	public void StartNew()
	{
		while (true)
		{
			int num = -922561768;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A756493u) % 10u)
				{
				case 9u:
					_finished = false;
					num = ((int)num2 * -1848713513) ^ -564063634;
					continue;
				case 7u:
					_currentTurn = 0;
					num = ((int)num2 * -1570620975) ^ 0x12FA15C3;
					continue;
				case 5u:
					num = (int)(num2 * 805685506) ^ -1781742409;
					continue;
				case 4u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -2047369154) ^ 0x6D38323A;
					continue;
				case 3u:
					ShuffleCards();
					num = (int)((num2 * 1243157030) ^ 0x7F25032B);
					continue;
				case 2u:
					Losers.Clear();
					num = (int)(num2 * 1254572905) ^ -556823856;
					continue;
				case 1u:
					num = (int)(num2 * 1847736900) ^ -1318212609;
					continue;
				case 0u:
					Winners.Clear();
					num = ((int)num2 * -1862836160) ^ -787811338;
					continue;
				case 6u:
					break;
				default:
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
		int num4 = default(int);
		bool flag2 = default(bool);
		int planningCardsCount = default(int);
		bool flag = default(bool);
		PlayerState playerState = default(PlayerState);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		int num3 = default(int);
		while (true)
		{
			int num = 1539536950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x538DA0B1u) % 28u)
				{
				case 27u:
					num4++;
					num = ((int)num2 * -1332398261) ^ -466042547;
					continue;
				case 26u:
					num = ((int)num2 * -2001539005) ^ -1640398189;
					continue;
				case 25u:
					flag2 = planningCardsCount == 0;
					num = (int)((num2 * 1580759093) ^ 0x2AA1D88D);
					continue;
				case 24u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 412504695;
						num9 = 412504695;
					}
					else
					{
						num8 = 1806834519;
						num9 = 1806834519;
					}
					num = num8 ^ (int)(num2 * 12428864);
					continue;
				}
				case 23u:
					playerState.Sprint = 1;
					num = ((int)num2 * -625552061) ^ -600679537;
					continue;
				case 22u:
					playerState = _playerStates[num4];
					num = (int)((num2 * 1990936055) ^ 0x3119737D);
					continue;
				case 21u:
					num = 581263433;
					continue;
				case 20u:
				{
					int num10;
					int num11;
					if (!useOneMorePlanningSprint)
					{
						num10 = -686153218;
						num11 = -686153218;
					}
					else
					{
						num10 = -2081278005;
						num11 = -2081278005;
					}
					num = num10 ^ (int)(num2 * 695465549);
					continue;
				}
				case 17u:
					playerState.Resources = Rules.InitialResources;
					num = (int)((num2 * 1937064950) ^ 0x1F31001B);
					continue;
				case 16u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -721107453) ^ 0x6281AEF9;
					continue;
				case 15u:
					num4 = 0;
					num = (int)((num2 * 594542957) ^ 0xB2D8F2F);
					continue;
				case 14u:
					player = Players[num4];
					num = 113455507;
					continue;
				case 13u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -1980146109;
						num7 = -1980146109;
					}
					else
					{
						num6 = -673857004;
						num7 = -673857004;
					}
					num = num6 ^ (int)(num2 * 2122434590);
					continue;
				}
				case 12u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = 1611207962;
					continue;
				case 11u:
					num = ((int)num2 * -606894233) ^ 0x13DEEF1;
					continue;
				case 10u:
					playerState.Sprint = 0;
					num = (int)((num2 * 1438564580) ^ 0xE5F677C);
					continue;
				case 9u:
					planningCardsCount = player.PlanningCardsCount;
					num = ((int)num2 * -463512337) ^ 0x409C3C7F;
					continue;
				case 8u:
					playerState.State = State.Playing;
					num = ((int)num2 * -397247975) ^ -441113868;
					continue;
				case 7u:
				{
					int num5;
					if (num3 > 0)
					{
						num = 1390964195;
						num5 = 1390964195;
					}
					else
					{
						num = 1984364975;
						num5 = 1984364975;
					}
					continue;
				}
				case 6u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = (int)(num2 * 1783251502) ^ -500567456;
					continue;
				case 5u:
					flag = num4 < Players.Length;
					num = 544766537;
					continue;
				case 4u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = 12254493;
					continue;
				case 3u:
					num = (int)(num2 * 1683900906) ^ -538506609;
					continue;
				case 2u:
					num3 = 0;
					num = 784857820;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1439910151) ^ -1301211915;
					continue;
				case 0u:
					playerState.Sprint = -1;
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = ((int)num2 * -586713332) ^ -1194170310;
					continue;
				default:
					return;
				case 19u:
					break;
				case 18u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1868105258;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5FA425A4u) % 18u)
				{
				case 16u:
					num = ((int)num2 * -1719776961) ^ 0x5301EE81;
					continue;
				case 15u:
					num = (int)((num2 * 452478373) ^ 0x819C6AF);
					continue;
				case 14u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 804000397) ^ 0x7EB362F1);
					continue;
				case 12u:
					PlayerTurn(_currentPlayer);
					num = 1973329652;
					continue;
				case 11u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 608520379;
					continue;
				case 10u:
					num = ((int)num2 * -489259712) ^ -316250602;
					continue;
				case 9u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1091652409) ^ -313486276;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1950359209;
						num6 = 1950359209;
					}
					else
					{
						num5 = 826083533;
						num6 = 826083533;
					}
					num = num5 ^ ((int)num2 * -1940189287);
					continue;
				}
				case 7u:
					_currentPlayer = 0;
					flag2 = _currentTurn > 0;
					num = (int)(num2 * 1030883176) ^ -1443341210;
					continue;
				case 6u:
					num = (int)((num2 * 1384224314) ^ 0x5CA531FF);
					continue;
				case 5u:
					num = (int)((num2 * 957808058) ^ 0x5364D2F3);
					continue;
				case 4u:
					_currentPlayer++;
					num = (int)(num2 * 1444023806) ^ -640404376;
					continue;
				case 3u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = ((int)num2 * -1012614027) ^ 0x3AC39F3D;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -281588208;
						num4 = -281588208;
					}
					else
					{
						num3 = -578865002;
						num4 = -578865002;
					}
					num = num3 ^ (int)(num2 * 2120726958);
					continue;
				}
				case 1u:
					num = ((int)num2 * -427941573) ^ 0xF15CE34;
					continue;
				case 0u:
					flag = _currentPlayer >= Players.Length;
					num = ((int)num2 * -1399781497) ^ 0x4B40B43C;
					continue;
				default:
					return;
				case 13u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Card card = default(Card);
		bool flag11 = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag13 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag9 = default(bool);
		int num12 = default(int);
		int num4 = default(int);
		bool flag10 = default(bool);
		bool flag12 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag7 = default(bool);
		Player player = default(Player);
		bool flag8 = default(bool);
		bool flag6 = default(bool);
		bool flag14 = default(bool);
		PlayerState playerState3 = default(PlayerState);
		bool flag4 = default(bool);
		int num18 = default(int);
		bool flag3 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = 978788814;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0x3992853Du) % 87u)
				{
				case 86u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag11 ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num3), flag ? "advance" : "stay");
					num = 1884052877;
					continue;
				case 85u:
					flag13 = playerState.Sprint < 0;
					num = 674042350;
					continue;
				case 84u:
					flag = false;
					num = 591284504;
					continue;
				case 83u:
					num = ((int)num2 * -1860664109) ^ -1210990945;
					continue;
				case 82u:
					num = (int)((num2 * 1414447279) ^ 0x7CF4D63A);
					continue;
				case 81u:
				{
					int num34;
					int num35;
					if (flag9)
					{
						num34 = 968109011;
						num35 = 968109011;
					}
					else
					{
						num34 = 626337651;
						num35 = 626337651;
					}
					num = num34 ^ ((int)num2 * -403089425);
					continue;
				}
				case 80u:
					card = DrawCard();
					flag2 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = 605466051;
						continue;
					}
					num11 = 0;
					goto IL_0109;
				case 79u:
					num12++;
					num = 1560535802;
					continue;
				case 78u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = 849304099;
					continue;
				}
				case 77u:
					num11 = ((card.Type == 4) ? 1 : 0);
					goto IL_0109;
				case 76u:
					num = (int)((num2 * 1041749930) ^ 0x9500860);
					continue;
				case 75u:
					num = (int)((num2 * 1100444909) ^ 0x6FF89F05);
					continue;
				case 74u:
					num12 = 0;
					num = ((int)num2 * -1782732655) ^ 0xC9DB865;
					continue;
				case 73u:
					num4 = 0;
					num = ((int)num2 * -87493984) ^ -373845485;
					continue;
				case 72u:
				{
					int num30;
					int num31;
					if (!flag10)
					{
						num30 = -1734536414;
						num31 = -1734536414;
					}
					else
					{
						num30 = -1455105825;
						num31 = -1455105825;
					}
					num = num30 ^ (int)(num2 * 244328977);
					continue;
				}
				case 71u:
					num = ((int)num2 * -537349950) ^ -1497731827;
					continue;
				case 70u:
					Winners.Add(playerIndex);
					num = (int)(num2 * 1812167121) ^ -975701238;
					continue;
				case 69u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -987200686) ^ -24172896;
					continue;
				case 68u:
					num = ((int)num2 * -995422801) ^ -880265239;
					continue;
				case 67u:
					num = ((int)num2 * -607415807) ^ 0x6B01B899;
					continue;
				case 66u:
					num = (int)((num2 * 1234959754) ^ 0x6D98A9F5);
					continue;
				case 65u:
				{
					int num21;
					int num22;
					if (flag12)
					{
						num21 = 153426692;
						num22 = 153426692;
					}
					else
					{
						num21 = 1543835845;
						num22 = 1543835845;
					}
					num = num21 ^ ((int)num2 * -1748718963);
					continue;
				}
				case 64u:
				{
					int num16;
					int num17;
					if (!onlyOneWinner)
					{
						num16 = 1456726665;
						num17 = 1456726665;
					}
					else
					{
						num16 = 1438759640;
						num17 = 1438759640;
					}
					num = num16 ^ ((int)num2 * -1373260445);
					continue;
				}
				case 63u:
					num = 1290227343;
					continue;
				case 61u:
					num = ((int)num2 * -722107568) ^ -64460931;
					continue;
				case 60u:
					num = (int)(num2 * 2063342519) ^ -1570965281;
					continue;
				case 59u:
				{
					int num7;
					int num8;
					if (flag7)
					{
						num7 = -2118733278;
						num8 = -2118733278;
					}
					else
					{
						num7 = -262839083;
						num8 = -262839083;
					}
					num = num7 ^ (int)(num2 * 1683063040);
					continue;
				}
				case 58u:
					player = Players[playerIndex];
					num = ((int)num2 * -2108023881) ^ -1696988570;
					continue;
				case 57u:
					flag7 = num4 == playerIndex;
					num = 759092076;
					continue;
				case 56u:
					flag = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -835976636) ^ 0x4B62213A;
					continue;
				case 55u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 768372796) ^ 0x8647AB2);
					continue;
				case 54u:
					num4++;
					num = 2032075425;
					continue;
				case 53u:
					Losers.Add(num12);
					num = ((int)num2 * -485429423) ^ -1179563500;
					continue;
				case 52u:
					flag8 = num4 < _playerStates.Length;
					num = 1773853500;
					continue;
				case 51u:
					flag6 = flag;
					num = 188199898;
					continue;
				case 50u:
					num = 1300815690;
					continue;
				case 49u:
					num = ((int)num2 * -1423219552) ^ -23360048;
					continue;
				case 48u:
					num = 261764198;
					continue;
				case 47u:
					num = 33262006;
					continue;
				case 46u:
					num = 1410426974;
					continue;
				case 45u:
					flag14 = !flag11;
					num = ((int)num2 * -977127992) ^ 0x3DB7B25C;
					continue;
				case 44u:
					Print(playerState.State);
					num = (int)(num2 * 1525214535) ^ -1517397857;
					continue;
				case 43u:
					playerState = _playerStates[playerIndex];
					num = (int)(num2 * 716019598) ^ -1579887265;
					continue;
				case 42u:
					num = (int)(num2 * 1371738316) ^ -4081050;
					continue;
				case 40u:
					num = (int)((num2 * 38160947) ^ 0x306DC4E4);
					continue;
				case 39u:
					num = ((int)num2 * -628328098) ^ 0x69BB8970;
					continue;
				case 38u:
					num = (int)((num2 * 300171936) ^ 0x3631D75E);
					continue;
				case 37u:
					num = ((int)num2 * -1095316927) ^ -1748767695;
					continue;
				case 36u:
				{
					playerState3.State = State.Lose;
					int num36;
					if (!Losers.Contains(num12))
					{
						num = 1123988833;
						num36 = 1123988833;
					}
					else
					{
						num = 294681352;
						num36 = 294681352;
					}
					continue;
				}
				case 35u:
				{
					int num32;
					int num33;
					if (flag4)
					{
						num32 = 181684613;
						num33 = 181684613;
					}
					else
					{
						num32 = 814502654;
						num33 = 814502654;
					}
					num = num32 ^ ((int)num2 * -814443926);
					continue;
				}
				case 34u:
					Losers.Add(num4);
					num = ((int)num2 * -472736170) ^ -1597553225;
					continue;
				case 33u:
				{
					int num28;
					int num29;
					if (!flag13)
					{
						num28 = 787805458;
						num29 = 787805458;
					}
					else
					{
						num28 = 1530185765;
						num29 = 1530185765;
					}
					num = num28 ^ (int)(num2 * 1344708761);
					continue;
				}
				case 32u:
					num18 = card.Impact - player.PlannedForCard(card.Type);
					flag = num18 < Rules.StayOnSprintMinDiff;
					num = (int)(num2 * 228218514) ^ -550401746;
					continue;
				case 31u:
				{
					int num27;
					if (num12 >= _playerStates.Length)
					{
						num = 1190966642;
						num27 = 1190966642;
					}
					else
					{
						num = 2035975108;
						num27 = 2035975108;
					}
					continue;
				}
				case 30u:
					playerState3.Resources -= Game.smethod_3(0, num3 - Players[num12].PlannedForCard(card.Type));
					flag12 = playerState3.Resources >= 0;
					num = (int)((num2 * 1705914730) ^ 0x1EBCB9B9);
					continue;
				case 29u:
				{
					int num25;
					int num26;
					if (playerState.State != 0)
					{
						num25 = 1346089597;
						num26 = 1346089597;
					}
					else
					{
						num25 = 351511151;
						num26 = 351511151;
					}
					num = num25 ^ (int)(num2 * 1063569756);
					continue;
				}
				case 28u:
				{
					int num23;
					int num24;
					if (flag14)
					{
						num23 = -1401715297;
						num24 = -1401715297;
					}
					else
					{
						num23 = -311563019;
						num24 = -311563019;
					}
					num = num23 ^ (int)(num2 * 262099117);
					continue;
				}
				case 27u:
				{
					int num19;
					int num20;
					if (flag3)
					{
						num19 = 240109510;
						num20 = 240109510;
					}
					else
					{
						num19 = 529555600;
						num20 = 529555600;
					}
					num = num19 ^ (int)(num2 * 1128947055);
					continue;
				}
				case 26u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)((num2 * 2103549062) ^ 0x1A2D5DB3);
					continue;
				case 25u:
					num = ((int)num2 * -1886162549) ^ -426413637;
					continue;
				case 24u:
					flag10 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 1897533696;
					continue;
				case 23u:
					num3 = Game.smethod_3(0, num18);
					num = (int)(num2 * 523325554) ^ -1708441993;
					continue;
				case 22u:
					num = (int)(num2 * 1460975697) ^ -801594240;
					continue;
				case 21u:
				{
					int num14;
					int num15;
					if (!flag5)
					{
						num14 = -697989591;
						num15 = -697989591;
					}
					else
					{
						num14 = -853673152;
						num15 = -853673152;
					}
					num = num14 ^ ((int)num2 * -1479859543);
					continue;
				}
				case 20u:
					playerState.State = State.Lose;
					num = ((int)num2 * -802680386) ^ 0x39B8825E;
					continue;
				case 19u:
				{
					int num13;
					if (playerState.Sprint > Rules.SprintCount)
					{
						num = 1564602939;
						num13 = 1564602939;
					}
					else
					{
						num = 1290227343;
						num13 = 1290227343;
					}
					continue;
				}
				case 18u:
					flag9 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1538128425) ^ -1043650363;
					continue;
				case 17u:
					num = ((int)num2 * -1580440162) ^ -1550517924;
					continue;
				case 16u:
					playerState.State = State.Won;
					num = (int)((num2 * 18660999) ^ 0x7F8073DE);
					continue;
				case 15u:
					playerState3 = _playerStates[num12];
					num = (int)((num2 * 574546973) ^ 0x63C19BDF);
					continue;
				case 14u:
				{
					int num9;
					int num10;
					if (!flag8)
					{
						num9 = 1619965030;
						num10 = 1619965030;
					}
					else
					{
						num9 = 800214717;
						num10 = 800214717;
					}
					num = num9 ^ (int)(num2 * 1138292172);
					continue;
				}
				case 13u:
					num = (int)((num2 * 2083276614) ^ 0x24C3445B);
					continue;
				case 12u:
					playerState.Sprint++;
					num = (int)(num2 * 2111378806) ^ -441262061;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (!flag6)
					{
						num5 = -1521907669;
						num6 = -1521907669;
					}
					else
					{
						num5 = -648994859;
						num6 = -648994859;
					}
					num = num5 ^ ((int)num2 * -1114762584);
					continue;
				}
				case 10u:
					num = 645094157;
					continue;
				case 9u:
					flag5 = !Losers.Contains(num4);
					num = 1631460169;
					continue;
				case 8u:
					num = 1035571724;
					continue;
				case 7u:
					num = ((int)num2 * -1286613603) ^ -1859321545;
					continue;
				case 6u:
					playerState.Resources -= num3;
					flag4 = playerState.Resources < 0;
					num = ((int)num2 * -257735834) ^ 0x3BA1FDDA;
					continue;
				case 5u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -1108190579) ^ -2005111782;
					continue;
				case 4u:
					num = ((int)num2 * -499177398) ^ 0x7B84290A;
					continue;
				case 3u:
					num = 850033749;
					continue;
				case 2u:
					_finished = true;
					num = ((int)num2 * -107839165) ^ -1898049214;
					continue;
				case 1u:
					flag3 = !flag2;
					num = ((int)num2 * -1533502887) ^ -1663555690;
					continue;
				case 0u:
					flag = true;
					num3 = card.Impact;
					num = (int)(num2 * 1045189748) ^ -1651616204;
					continue;
				default:
					return;
				case 41u:
					break;
				case 62u:
					return;
					IL_0109:
					flag11 = (byte)num11 != 0;
					num = 2047120938;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		bool flag = default(bool);
		Card card = default(Card);
		Card result = default(Card);
		while (true)
		{
			int num = 1252567911;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69C07490u) % 9u)
				{
				case 8u:
					_deck.RemoveAt(0);
					num = ((int)num2 * -1202412564) ^ -418285102;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1664940995;
						num4 = -1664940995;
					}
					else
					{
						num3 = -269044667;
						num4 = -269044667;
					}
					num = num3 ^ (int)(num2 * 1444691783);
					continue;
				}
				case 6u:
					num = (int)(num2 * 1959488392) ^ -731347233;
					continue;
				case 4u:
					card = _deck[0];
					num = 1230845264;
					continue;
				case 3u:
					flag = _deck.Count <= 0;
					num = (int)(num2 * 520586193) ^ -309239399;
					continue;
				case 2u:
					ShuffleCards();
					num = ((int)num2 * -1459295530) ^ -1545361391;
					continue;
				case 1u:
					result = card;
					num = ((int)num2 * -414274928) ^ -1716550636;
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
		string text = "";
		bool flag = default(bool);
		int num5 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -223284832;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC6BE440u) % 10u)
				{
				case 8u:
					flag = num5 < _playerStates.Length;
					num = -1187556823;
					continue;
				case 7u:
					num = ((int)num2 * -511249070) ^ -2042454725;
					continue;
				case 6u:
					num5 = 0;
					num = ((int)num2 * -1435075377) ^ 0x6A7FBA2C;
					continue;
				case 4u:
				{
					string[] obj = new string[5]
					{
						text,
						num5.ToString(),
						": ",
						null,
						null
					};
					PlayerState obj2 = _playerStates[num5];
					obj[3] = ((obj2 != null) ? Game.smethod_5((object)obj2) : null);
					obj[4] = "\n";
					text = Game.smethod_6(obj);
					num = -2012956973;
					continue;
				}
				case 3u:
					num5++;
					num = ((int)num2 * -23903009) ^ -1965542313;
					continue;
				case 2u:
					num = (int)((num2 * 1026799911) ^ 0x23E77CE);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1723081922;
						num4 = 1723081922;
					}
					else
					{
						num3 = 1790251456;
						num4 = 1790251456;
					}
					num = num3 ^ (int)(num2 * 1546858582);
					continue;
				}
				case 0u:
					result = text;
					num = (int)(num2 * 1935116766) ^ -1479847485;
					continue;
				case 9u:
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
