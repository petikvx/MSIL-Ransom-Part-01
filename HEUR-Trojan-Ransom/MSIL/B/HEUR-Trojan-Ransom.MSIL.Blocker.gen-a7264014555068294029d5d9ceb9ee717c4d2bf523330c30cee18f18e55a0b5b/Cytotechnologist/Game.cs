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
			bool result = default(bool);
			int num7 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = -1593491830;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE1E1AC97u) % 16u)
					{
					case 15u:
						result = false;
						num = ((int)num2 * -955656092) ^ -32716941;
						continue;
					case 14u:
						num7 = 0;
						num = ((int)num2 * -830378720) ^ -569488560;
						continue;
					case 13u:
					{
						int num5;
						int num6;
						if (!finished)
						{
							num5 = 278367767;
							num6 = 278367767;
						}
						else
						{
							num5 = 18186806;
							num6 = 18186806;
						}
						num = num5 ^ (int)(num2 * 7563557);
						continue;
					}
					case 12u:
						playerStates = _playerStates;
						num = (int)(num2 * 1423358109) ^ -303069243;
						continue;
					case 10u:
						playerState = playerStates[num7];
						num = -1541270700;
						continue;
					case 9u:
						num7++;
						num = -538889072;
						continue;
					case 8u:
						num = (int)((num2 * 163071269) ^ 0x96A0E64);
						continue;
					case 7u:
					{
						int num8;
						if (num7 >= playerStates.Length)
						{
							num = -1441684462;
							num8 = -1441684462;
						}
						else
						{
							num = -2040588499;
							num8 = -2040588499;
						}
						continue;
					}
					case 6u:
						num = (int)(num2 * 626080436) ^ -1315210172;
						continue;
					case 5u:
						result = true;
						num = ((int)num2 * -343430488) ^ 0x2513823B;
						continue;
					case 4u:
						num = (int)((num2 * 218964140) ^ 0x7D8DB94C);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (playerState.State != 0)
						{
							num3 = -1777099794;
							num4 = -1777099794;
						}
						else
						{
							num3 = -450369912;
							num4 = -450369912;
						}
						num = num3 ^ ((int)num2 * -1215919696);
						continue;
					}
					case 1u:
						num = -507903909;
						continue;
					case 0u:
						result = true;
						num = ((int)num2 * -782990910) ^ -467555919;
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		int num4 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int count = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -2032211355;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB27E0DDEu) % 18u)
				{
				case 17u:
					num4++;
					num = ((int)num2 * -1684529504) ^ -283476901;
					continue;
				case 16u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = (int)(num2 * 79044524) ^ -1143352516;
					continue;
				case 15u:
					num = (int)(num2 * 354767135) ^ -1445716413;
					continue;
				case 14u:
					Players = new Player[count];
					num = ((int)num2 * -509279130) ^ 0x2F3DBEB5;
					continue;
				case 13u:
					num3 = 0;
					num = ((int)num2 * -1888227351) ^ -753511389;
					continue;
				case 12u:
					num3++;
					num = ((int)num2 * -776149042) ^ -945689160;
					continue;
				case 11u:
					_playerStates = new PlayerState[count];
					num4 = 0;
					num = (int)(num2 * 563629987) ^ -369882364;
					continue;
				case 9u:
					num = (int)(num2 * 643585118) ^ -1707786951;
					continue;
				case 8u:
					_buffer = buffer;
					num = ((int)num2 * -1194469066) ^ -1153301254;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -654160499;
						num8 = -654160499;
					}
					else
					{
						num7 = -1767525633;
						num8 = -1767525633;
					}
					num = num7 ^ (int)(num2 * 1765090340);
					continue;
				}
				case 6u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1939173305;
						num6 = 1939173305;
					}
					else
					{
						num5 = 850026096;
						num6 = 850026096;
					}
					num = num5 ^ (int)(num2 * 481392948);
					continue;
				}
				case 5u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = -611239464;
					continue;
				case 4u:
					_playerStates[num4] = new PlayerState();
					num = -1839046279;
					continue;
				case 2u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					_dice = new Dice();
					num = (int)(num2 * 1553617411) ^ -1290105120;
					continue;
				case 1u:
					flag2 = num4 < count;
					num = -544471154;
					continue;
				case 0u:
					flag = num3 < count;
					num = -928610053;
					continue;
				default:
					return;
				case 10u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void ShuffleCards()
	{
		_deck = new List<Card>(Rules.Cards);
	}

	public void StartNew()
	{
		ShuffleCards();
		while (true)
		{
			int num = -227453744;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF744BFF2u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -333143082) ^ -1141257743;
					continue;
				case 8u:
					num = ((int)num2 * -1167139622) ^ -1173090488;
					continue;
				case 6u:
					Losers.Clear();
					num = ((int)num2 * -354668862) ^ 0x4256C88B;
					continue;
				case 5u:
					Winners.Clear();
					num = ((int)num2 * -1657429617) ^ 0x4031DC1;
					continue;
				case 4u:
					_finished = false;
					_currentChanceIndex = -1;
					num = ((int)num2 * -2098556013) ^ -1358964519;
					continue;
				case 3u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 1313307217) ^ 0x8D948ED);
					continue;
				case 2u:
					num = ((int)num2 * -1206756701) ^ -1982873081;
					continue;
				case 0u:
					_currentTurn = 0;
					num = ((int)num2 * -88838115) ^ -1941367704;
					continue;
				case 7u:
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
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool useOneMorePlanningSprint = default(bool);
		while (true)
		{
			bool flag = num < Players.Length;
			int num2 = -1198015005;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xB8C5A5DCu) % 25u)
				{
				case 24u:
					num2 = ((int)num3 * -1162517501) ^ -792605580;
					continue;
				case 23u:
					player = Players[num];
					playerState = _playerStates[num];
					num2 = (int)(num3 * 1781144829) ^ -317264596;
					continue;
				case 22u:
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num6 = 0;
					num2 = ((int)num3 * -1649732988) ^ -630255709;
					continue;
				case 21u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num2 = (int)(num3 * 214995038) ^ -1091937844;
					continue;
				case 20u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num2 = -2003129552;
					continue;
				case 19u:
					playerState.Sprint = -1;
					num2 = (int)(num3 * 275369429) ^ -1157739473;
					continue;
				case 17u:
					num6 = 0;
					num2 = -842271834;
					continue;
				case 16u:
					flag2 = num6 > 0;
					num2 = -1363538772;
					continue;
				case 15u:
					playerState.Sprint = 1;
					num2 = (int)((num3 * 626536465) ^ 0x70C0D7B7);
					continue;
				case 14u:
					num2 = -1898042106;
					continue;
				case 13u:
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num2 = (int)((num3 * 1773217401) ^ 0x305D8022);
					continue;
				case 12u:
					num2 = (int)((num3 * 740953009) ^ 0x1D534D9C);
					continue;
				case 11u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = 1295435334;
						num12 = 1295435334;
					}
					else
					{
						num11 = 587488950;
						num12 = 587488950;
					}
					num2 = num11 ^ ((int)num3 * -166161043);
					continue;
				}
				case 10u:
					flag3 = planningCardsCount == 0;
					num2 = (int)((num3 * 1292305354) ^ 0x36183BCD);
					continue;
				case 9u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 1973083672;
						num10 = 1973083672;
					}
					else
					{
						num9 = 1388242016;
						num10 = 1388242016;
					}
					num2 = num9 ^ ((int)num3 * -2038871725);
					continue;
				}
				case 8u:
					num++;
					num2 = (int)((num3 * 288669922) ^ 0x559DC26);
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (!useOneMorePlanningSprint)
					{
						num7 = 1215264082;
						num8 = 1215264082;
					}
					else
					{
						num7 = 339202399;
						num8 = 339202399;
					}
					num2 = num7 ^ (int)(num3 * 912929545);
					continue;
				}
				case 6u:
					num2 = -681381527;
					continue;
				case 4u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					num2 = ((int)num3 * -1279701948) ^ 0x1AFFE08A;
					continue;
				case 3u:
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num2 = -2129676128;
					continue;
				case 2u:
					num2 = -2032923275;
					continue;
				case 1u:
					num2 = (int)((num3 * 85225331) ^ 0x49E17270);
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -2092096515;
						num5 = -2092096515;
					}
					else
					{
						num4 = -815573405;
						num5 = -815573405;
					}
					num2 = num4 ^ ((int)num3 * -1590530833);
					continue;
				}
				default:
					return;
				case 5u:
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
		_currentPlayer++;
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 619501891;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x131DD480u) % 12u)
				{
				case 11u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1136252585;
						num6 = 1136252585;
					}
					else
					{
						num5 = 1638346179;
						num6 = 1638346179;
					}
					num = num5 ^ (int)(num2 * 698877327);
					continue;
				}
				case 10u:
					_currentPlayer = 0;
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -332250135) ^ -1590892503;
					continue;
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -794404624) ^ -41669416;
					continue;
				case 7u:
					PlayerTurn(_currentPlayer);
					num = 622903329;
					continue;
				case 6u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1083858395) ^ 0x25C91492;
					continue;
				case 4u:
					num = ((int)num2 * -180004049) ^ -632025389;
					continue;
				case 3u:
					flag = _currentPlayer >= Players.Length;
					num = ((int)num2 * -738164101) ^ -858522196;
					continue;
				case 2u:
					num = ((int)num2 * -1287019399) ^ 0x4D8AC37F;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 439450423;
						num4 = 439450423;
					}
					else
					{
						num3 = 857708642;
						num4 = 857708642;
					}
					num = num3 ^ (int)(num2 * 2535020);
					continue;
				}
				case 0u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 571110462;
					continue;
				default:
					return;
				case 8u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		PlayerState playerState = default(PlayerState);
		bool flag4 = default(bool);
		bool flag12 = default(bool);
		int num12 = default(int);
		PlayerState playerState2 = default(PlayerState);
		int num7 = default(int);
		bool flag = default(bool);
		int num15 = default(int);
		int num5 = default(int);
		Card card = default(Card);
		bool flag8 = default(bool);
		bool flag11 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag10 = default(bool);
		bool flag2 = default(bool);
		bool flag9 = default(bool);
		bool flag3 = default(bool);
		Player player = default(Player);
		bool flag6 = default(bool);
		while (true)
		{
			int num = -1330956397;
			while (true)
			{
				uint num2;
				int num19;
				switch ((num2 = (uint)num ^ 0x9529AB9Eu) % 91u)
				{
				case 90u:
					Print("CARD: none, advance");
					num = (int)(num2 * 89536324) ^ -2004267358;
					continue;
				case 89u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -609310295;
					continue;
				}
				case 87u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -1248329012) ^ 0x2CFA21C8;
					continue;
				case 86u:
					num = (int)(num2 * 594263902) ^ -1541624246;
					continue;
				case 85u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = -502422220;
						num11 = -502422220;
					}
					else
					{
						num10 = -848659508;
						num11 = -848659508;
					}
					num = num10 ^ (int)(num2 * 2055887565);
					continue;
				}
				case 84u:
					flag12 = playerState.Resources < 0;
					num = ((int)num2 * -431371604) ^ -961750472;
					continue;
				case 83u:
					num12 = 0;
					num = ((int)num2 * -1819078677) ^ -572528114;
					continue;
				case 82u:
					num = (int)((num2 * 1425923096) ^ 0x7DDCB97E);
					continue;
				case 81u:
					playerState2 = _playerStates[num7];
					num = ((int)num2 * -832259878) ^ -1269442831;
					continue;
				case 80u:
				{
					int num24;
					if (!_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = -1743829075;
						num24 = -1743829075;
					}
					else
					{
						num = -629742514;
						num24 = -629742514;
					}
					continue;
				}
				case 79u:
					flag = false;
					num = -536660201;
					continue;
				case 78u:
					flag = num15 < Rules.StayOnSprintMinDiff;
					num5 = Game.smethod_3(0, num15);
					num = ((int)num2 * -1363898957) ^ 0x38D44A7D;
					continue;
				case 77u:
				{
					int num18;
					if (num7 < _playerStates.Length)
					{
						num = -38874752;
						num18 = -38874752;
					}
					else
					{
						num = -415492768;
						num18 = -415492768;
					}
					continue;
				}
				case 76u:
					playerState2.Resources -= Game.smethod_3(0, num5 - Players[num7].PlannedForCard(card.Type));
					flag8 = playerState2.Resources >= 0;
					num = ((int)num2 * -1008507342) ^ 0x1C4365A0;
					continue;
				case 75u:
					num = ((int)num2 * -2126331538) ^ 0x4883EFE6;
					continue;
				case 74u:
				{
					int num35;
					if (num12 >= _playerStates.Length)
					{
						num = -48417628;
						num35 = -48417628;
					}
					else
					{
						num = -1376227548;
						num35 = -1376227548;
					}
					continue;
				}
				case 73u:
					playerState.Sprint++;
					num = (int)((num2 * 1228764296) ^ 0x2B2C85E);
					continue;
				case 72u:
					num = -1335201496;
					continue;
				case 71u:
					num7 = 0;
					num = ((int)num2 * -776616985) ^ -246917367;
					continue;
				case 70u:
				{
					int num29;
					int num30;
					if (!flag11)
					{
						num29 = -644677802;
						num30 = -644677802;
					}
					else
					{
						num29 = -335944971;
						num30 = -335944971;
					}
					num = num29 ^ (int)(num2 * 1485975502);
					continue;
				}
				case 69u:
					flag = true;
					num = (int)((num2 * 1842369213) ^ 0x529016F2);
					continue;
				case 67u:
					num = ((int)num2 * -2076011201) ^ -1873763433;
					continue;
				case 66u:
					num = (int)((num2 * 1315936643) ^ 0x5CCF452D);
					continue;
				case 65u:
					num = (int)(num2 * 1201496099) ^ -175409556;
					continue;
				case 64u:
					num = (int)(num2 * 842834479) ^ -47243997;
					continue;
				case 63u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag7 ? "ALL " : "", flag5 ? "receives" : "pays", Game.smethod_4(num5), flag ? "advance" : "stay");
					num = -880077238;
					continue;
				case 62u:
					flag4 = !flag7;
					num = ((int)num2 * -1844595417) ^ -406990506;
					continue;
				case 61u:
					num = -1804447735;
					continue;
				case 60u:
					num = ((int)num2 * -352646555) ^ -1528657307;
					continue;
				case 59u:
				{
					int num6;
					if (playerState.Sprint >= 0)
					{
						num = -1048569696;
						num6 = -1048569696;
					}
					else
					{
						num = -1349655530;
						num6 = -1349655530;
					}
					continue;
				}
				case 58u:
					flag = true;
					num5 = card.Impact;
					num = (int)(num2 * 311718092) ^ -2060892720;
					continue;
				case 57u:
					num7++;
					num = -1249009559;
					continue;
				case 56u:
					flag11 = flag;
					num = -1577049082;
					continue;
				case 55u:
					num = ((int)num2 * -170032022) ^ 0xC83FDF3;
					continue;
				case 54u:
					num12++;
					num = -1863115664;
					continue;
				case 53u:
					num = (int)((num2 * 749808650) ^ 0x24CFD2F1);
					continue;
				case 52u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -671072724) ^ 0x2442E90E;
					continue;
				case 51u:
					num19 = ((card.Type == 4) ? 1 : 0);
					goto IL_0474;
				case 50u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)(num2 * 264278094) ^ -283787672;
					continue;
				case 49u:
					num = ((int)num2 * -420374783) ^ 0x25792413;
					continue;
				case 48u:
					num = ((int)num2 * -503916492) ^ 0x459A0244;
					continue;
				case 47u:
				{
					int num33;
					int num34;
					if (flag10)
					{
						num33 = 550207762;
						num34 = 550207762;
					}
					else
					{
						num33 = 601545120;
						num34 = 601545120;
					}
					num = num33 ^ (int)(num2 * 1128510615);
					continue;
				}
				case 46u:
				{
					int num31;
					int num32;
					if (!flag12)
					{
						num31 = 926818945;
						num32 = 926818945;
					}
					else
					{
						num31 = 1026701632;
						num32 = 1026701632;
					}
					num = num31 ^ (int)(num2 * 553485969);
					continue;
				}
				case 45u:
					num = -2094620613;
					continue;
				case 44u:
				{
					int num27;
					int num28;
					if (flag2)
					{
						num27 = -730753050;
						num28 = -730753050;
					}
					else
					{
						num27 = -254059081;
						num28 = -254059081;
					}
					num = num27 ^ ((int)num2 * -1762779881);
					continue;
				}
				case 43u:
					_finished = true;
					num = ((int)num2 * -2093831336) ^ 0x35A60835;
					continue;
				case 42u:
					flag9 = num12 == playerIndex;
					num = (int)(num2 * 325398198) ^ -1518178985;
					continue;
				case 41u:
					num = (int)((num2 * 1680010328) ^ 0x11EE3C7E);
					continue;
				case 40u:
					flag10 = playerState.Sprint > Rules.SprintCount;
					num = -1247985986;
					continue;
				case 39u:
				{
					int num25;
					int num26;
					if (flag8)
					{
						num25 = 1149311875;
						num26 = 1149311875;
					}
					else
					{
						num25 = 1029998456;
						num26 = 1029998456;
					}
					num = num25 ^ (int)(num2 * 1701341753);
					continue;
				}
				case 38u:
					num = -1766865610;
					continue;
				case 37u:
				{
					int num22;
					int num23;
					if (!onlyOneWinner)
					{
						num22 = 1444628268;
						num23 = 1444628268;
					}
					else
					{
						num22 = 1917046145;
						num23 = 1917046145;
					}
					num = num22 ^ ((int)num2 * -1251351045);
					continue;
				}
				case 36u:
					num = -1824909539;
					continue;
				case 35u:
					flag3 = playerState.State != State.Playing;
					num = ((int)num2 * -1452463452) ^ 0x2AE1D183;
					continue;
				case 34u:
					num = (int)(num2 * 1604876611) ^ -289235754;
					continue;
				case 33u:
					num = ((int)num2 * -1264039793) ^ 0x6B5E8726;
					continue;
				case 32u:
					num = -343314583;
					continue;
				case 31u:
					Print(playerState.State);
					num = (int)(num2 * 911094692) ^ -1556052034;
					continue;
				case 30u:
					num = ((int)num2 * -1445109299) ^ 0x5AB9B476;
					continue;
				case 29u:
					Losers.Add(num7);
					num = ((int)num2 * -663909944) ^ -635063536;
					continue;
				case 28u:
				{
					int num20;
					int num21;
					if (flag9)
					{
						num20 = -2144101461;
						num21 = -2144101461;
					}
					else
					{
						num20 = -1740504046;
						num21 = -1740504046;
					}
					num = num20 ^ (int)(num2 * 559234175);
					continue;
				}
				case 27u:
					num = ((int)num2 * -1697454353) ^ 0x6F4B1A82;
					continue;
				case 26u:
					num = -1989891008;
					continue;
				case 25u:
					num = ((int)num2 * -762186025) ^ 0x3BD39A2;
					continue;
				case 24u:
					player = Players[playerIndex];
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -725160238) ^ 0x54A8865C;
					continue;
				case 23u:
					num = ((int)num2 * -51780080) ^ -1267982698;
					continue;
				case 22u:
					num = (int)((num2 * 1787407279) ^ 0x3700BE86);
					continue;
				case 21u:
					flag6 = !Losers.Contains(num12);
					num = -618852550;
					continue;
				case 20u:
					num = (int)((num2 * 987527212) ^ 0x4A657DCC);
					continue;
				case 19u:
					num = (int)((num2 * 1117513028) ^ 0x644AB67C);
					continue;
				case 18u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -1314522931) ^ 0x2323EF32;
						continue;
					}
					num19 = 0;
					goto IL_0474;
				case 17u:
				{
					int num16;
					int num17;
					if (flag5)
					{
						num16 = -1780762879;
						num17 = -1780762879;
					}
					else
					{
						num16 = -2022357749;
						num17 = -2022357749;
					}
					num = num16 ^ ((int)num2 * -1448622564);
					continue;
				}
				case 16u:
					num15 = card.Impact - player.PlannedForCard(card.Type);
					num = ((int)num2 * -1752222736) ^ 0x2987E408;
					continue;
				case 15u:
				{
					int num13;
					int num14;
					if (!flag6)
					{
						num13 = -1576468056;
						num14 = -1576468056;
					}
					else
					{
						num13 = -1173732039;
						num14 = -1173732039;
					}
					num = num13 ^ ((int)num2 * -2051027110);
					continue;
				}
				case 14u:
					Losers.Add(num12);
					num = ((int)num2 * -63179919) ^ -1993516385;
					continue;
				case 13u:
					num = ((int)num2 * -1308977802) ^ -583870584;
					continue;
				case 12u:
					num = -1692825930;
					continue;
				case 11u:
					playerState.Resources -= num5;
					num = ((int)num2 * -394049001) ^ -2026291231;
					continue;
				case 10u:
					num = -1283418898;
					continue;
				case 9u:
					num = -311121875;
					continue;
				case 8u:
					num = (int)(num2 * 1902047946) ^ -1854264864;
					continue;
				case 7u:
					card = DrawCard();
					flag5 = card.Impact < 0;
					num = ((int)num2 * -2135914447) ^ -1158662220;
					continue;
				case 6u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 511930952;
						num9 = 511930952;
					}
					else
					{
						num8 = 1181331347;
						num9 = 1181331347;
					}
					num = num8 ^ ((int)num2 * -1477491084);
					continue;
				}
				case 5u:
					playerState2.State = State.Lose;
					flag2 = !Losers.Contains(num7);
					num = -875947080;
					continue;
				case 4u:
					num = ((int)num2 * -1858975372) ^ -946496756;
					continue;
				case 3u:
					num = (int)(num2 * 924837983) ^ -839733840;
					continue;
				case 2u:
				{
					playerState.State = State.Lose;
					int num3;
					int num4;
					if (!Losers.Contains(playerIndex))
					{
						num3 = 249313558;
						num4 = 249313558;
					}
					else
					{
						num3 = 1747705023;
						num4 = 1747705023;
					}
					num = num3 ^ (int)(num2 * 1566180291);
					continue;
				}
				case 1u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 298057058) ^ 0x6BFA4AED);
					continue;
				case 0u:
					num = ((int)num2 * -900342640) ^ 0x1FA3F4AF;
					continue;
				default:
					return;
				case 88u:
					break;
				case 68u:
					return;
					IL_0474:
					flag7 = (byte)num19 != 0;
					num = -1528218374;
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
		while (true)
		{
			int num = 816798038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A79788Au) % 10u)
				{
				case 9u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 454148975) ^ 0x43122CCB);
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (_deck.Count > 0)
					{
						num3 = -1063684299;
						num4 = -1063684299;
					}
					else
					{
						num3 = -1799928004;
						num4 = -1799928004;
					}
					num = num3 ^ (int)(num2 * 413847721);
					continue;
				}
				case 6u:
					result = card;
					num = (int)(num2 * 1799773408) ^ -715699817;
					continue;
				case 4u:
					ShuffleCards();
					num = (int)((num2 * 1603401154) ^ 0x2C3002C4);
					continue;
				case 3u:
					num = (int)((num2 * 310905454) ^ 0x6C154771);
					continue;
				case 2u:
					num = ((int)num2 * -1575915575) ^ -1625230813;
					continue;
				case 1u:
					card = _deck[0];
					num = 291143283;
					continue;
				case 0u:
					num = (int)((num2 * 1065325313) ^ 0x254AA1A2);
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
		string text = "";
		int num = 0;
		string result = default(string);
		while (true)
		{
			bool flag = num < _playerStates.Length;
			int num2 = -2139687110;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x951E6162u) % 6u)
				{
				case 3u:
					result = text;
					num2 = (int)((num3 * 349660671) ^ 0x24F99DAB);
					continue;
				case 2u:
					num2 = -1037682787;
					continue;
				case 1u:
				{
					string[] obj = new string[5]
					{
						text,
						num.ToString(),
						": ",
						null,
						null
					};
					PlayerState obj2 = _playerStates[num];
					obj[3] = ((obj2 != null) ? Game.smethod_5((object)obj2) : null);
					obj[4] = "\n";
					text = Game.smethod_6(obj);
					num++;
					num2 = -1215423865;
					continue;
				}
				case 0u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1419503233;
						num5 = 1419503233;
					}
					else
					{
						num4 = 771938805;
						num5 = 771938805;
					}
					num2 = num4 ^ (int)(num3 * 219596487);
					continue;
				}
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
			int num = 1758994343;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C9DC610u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = ToString(initial: false);
				num = ((int)num2 * -25941449) ^ 0x66D712BF;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = -1036166058;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA7D3C73u) % 4u)
				{
				case 2u:
					Game.smethod_8(_buffer, string_);
					num = (int)((num2 * 2086138995) ^ 0x4838592E);
					continue;
				case 1u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = (int)((num2 * 1248749393) ^ 0x5970E9A4);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
