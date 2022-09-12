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
				int num = -1543276935;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF6AA0EAAu) % 13u)
					{
					case 12u:
						result = false;
						num = ((int)num2 * -1241348862) ^ 0x7CBF31C3;
						continue;
					case 11u:
						num3 = 0;
						num = (int)((num2 * 1132035910) ^ 0x43BC8E57);
						continue;
					case 10u:
						result = true;
						num = ((int)num2 * -274005793) ^ -1134442175;
						continue;
					case 9u:
					{
						PlayerState playerState = playerStates[num3];
						int num5;
						if (playerState.State == State.Playing)
						{
							num = -1955136181;
							num5 = -1955136181;
						}
						else
						{
							num = -223097476;
							num5 = -223097476;
						}
						continue;
					}
					case 8u:
					{
						int num6;
						int num7;
						if (!_finished)
						{
							num6 = -516744179;
							num7 = -516744179;
						}
						else
						{
							num6 = -1553466290;
							num7 = -1553466290;
						}
						num = num6 ^ ((int)num2 * -1546581837);
						continue;
					}
					case 7u:
						num3++;
						num = -56540243;
						continue;
					case 6u:
						num = (int)((num2 * 1779541634) ^ 0x138668E7);
						continue;
					case 5u:
						result = true;
						num = ((int)num2 * -1190342327) ^ 0x4B1FCD05;
						continue;
					case 3u:
						num = (int)((num2 * 174994228) ^ 0x2962E9E1);
						continue;
					case 2u:
					{
						int num4;
						if (num3 >= playerStates.Length)
						{
							num = -397257962;
							num4 = -397257962;
						}
						else
						{
							num = -604368583;
							num4 = -604368583;
						}
						continue;
					}
					case 1u:
						playerStates = _playerStates;
						num = -863918475;
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		bool flag = default(bool);
		int num3 = default(int);
		int count = default(int);
		int num4 = default(int);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -685554834;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECEE3477u) % 15u)
				{
				case 14u:
					flag = num3 < count;
					num = -1665847727;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -771044123;
						num7 = -771044123;
					}
					else
					{
						num6 = -1901928823;
						num7 = -1901928823;
					}
					num = num6 ^ (int)(num2 * 2001564570);
					continue;
				}
				case 11u:
					_dice = new Dice();
					num = (int)(num2 * 582574518) ^ -502657484;
					continue;
				case 10u:
					Players[num4] = Player.Deserialize(jSONNode[num4]);
					num4++;
					num = -1909721076;
					continue;
				case 9u:
					num = ((int)num2 * -2061150350) ^ 0x76FEC5F3;
					continue;
				case 7u:
				{
					int num5;
					if (num4 >= count)
					{
						num = -1460494418;
						num5 = -1460494418;
					}
					else
					{
						num = -1017810046;
						num5 = -1017810046;
					}
					continue;
				}
				case 6u:
					num4 = 0;
					num = (int)((num2 * 1917821023) ^ 0x74FC6D81);
					continue;
				case 5u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					Players = new Player[count];
					num = (int)((num2 * 2075791455) ^ 0x2822BFF1);
					continue;
				case 4u:
					_playerStates = new PlayerState[count];
					num3 = 0;
					num = ((int)num2 * -1011502090) ^ -1052508250;
					continue;
				case 3u:
					_buffer = buffer;
					num = ((int)num2 * -255950966) ^ 0x663F750;
					continue;
				case 2u:
					_playerStates[num3] = new PlayerState();
					num = -410205990;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1458133758) ^ -716493801;
					continue;
				case 0u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = ((int)num2 * -1094415265) ^ 0x3451EE58;
					continue;
				default:
					return;
				case 8u:
					break;
				case 13u:
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
			int num = -2135295871;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCBAA5831u) % 3u)
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
				num = ((int)num2 * -353508286) ^ -1572589595;
			}
		}
	}

	public void StartNew()
	{
		ShuffleCards();
		Winners.Clear();
		while (true)
		{
			int num = -1466580188;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA70B134Au) % 5u)
				{
				case 2u:
					num = (int)((num2 * 468101028) ^ 0x5D928E08);
					continue;
				case 1u:
					Losers.Clear();
					num = (int)(num2 * 2092578335) ^ -255258365;
					continue;
				case 0u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -565335106) ^ -700724733;
					continue;
				case 4u:
					break;
				default:
					_currentTurn = 0;
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
		int planningCardsCount = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		Player player = default(Player);
		int num4 = default(int);
		while (true)
		{
			int num = -1262145951;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2A58C29u) % 30u)
				{
				case 29u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = -151393045;
					continue;
				case 28u:
					num = ((int)num2 * -1312049807) ^ 0x15EF6EDD;
					continue;
				case 27u:
					playerState.Sprint = 1;
					num = (int)(num2 * 70126482) ^ -1350743319;
					continue;
				case 26u:
					num = ((int)num2 * -793299571) ^ -317704274;
					continue;
				case 25u:
					num = -1246496091;
					continue;
				case 24u:
					flag2 = num3 > 0;
					num = -1263736351;
					continue;
				case 23u:
					playerState.Resources = Rules.InitialResources;
					num = ((int)num2 * -28715339) ^ 0x14ABBCEB;
					continue;
				case 22u:
					playerState.Sprint = -1;
					num = ((int)num2 * -677280163) ^ 0xA0DE1EF;
					continue;
				case 21u:
				{
					int num10;
					int num11;
					if (flag)
					{
						num10 = -405326959;
						num11 = -405326959;
					}
					else
					{
						num10 = -1599147778;
						num11 = -1599147778;
					}
					num = num10 ^ (int)(num2 * 1790299847);
					continue;
				}
				case 20u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -649210684;
						num9 = -649210684;
					}
					else
					{
						num8 = -676115608;
						num9 = -676115608;
					}
					num = num8 ^ (int)(num2 * 1304314062);
					continue;
				}
				case 19u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = ((int)num2 * -1034003829) ^ 0x797E184B;
					continue;
				case 18u:
					planningCardsCount = player.PlanningCardsCount;
					num3 = 0;
					num = (int)(num2 * 499626281) ^ -2103504698;
					continue;
				case 17u:
					playerState.State = State.Playing;
					num = (int)((num2 * 1736284001) ^ 0x22ADC0AE);
					continue;
				case 16u:
				{
					int num7;
					if (num4 >= Players.Length)
					{
						num = -292350120;
						num7 = -292350120;
					}
					else
					{
						num = -1697378904;
						num7 = -1697378904;
					}
					continue;
				}
				case 15u:
					num = -1568473886;
					continue;
				case 14u:
					num = -386647032;
					continue;
				case 13u:
					num3 = 0;
					num = -1619822978;
					continue;
				case 11u:
					flag = planningCardsCount == 0;
					num = ((int)num2 * -1131328380) ^ 0x2EAD6246;
					continue;
				case 10u:
					num4 = 0;
					num = ((int)num2 * -693349610) ^ 0x4C58162D;
					continue;
				case 9u:
					num = (int)((num2 * 1419940853) ^ 0x1933C77D);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!player.UseOneMorePlanningSprint)
					{
						num5 = 146075079;
						num6 = 146075079;
					}
					else
					{
						num5 = 242849397;
						num6 = 242849397;
					}
					num = num5 ^ (int)(num2 * 1216895459);
					continue;
				}
				case 7u:
					num4++;
					num = ((int)num2 * -972188890) ^ -555388205;
					continue;
				case 6u:
					player = Players[num4];
					playerState = _playerStates[num4];
					num = (int)((num2 * 961318983) ^ 0x68F75719);
					continue;
				case 4u:
					playerState.Sprint = 0;
					num = ((int)num2 * -2123732574) ^ 0x61208A96;
					continue;
				case 3u:
					num = ((int)num2 * -1545784723) ^ 0x3BAF64FB;
					continue;
				case 2u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)(num2 * 1429483400) ^ -1393175074;
					continue;
				case 1u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = (int)(num2 * 1982631466) ^ -2088213907;
					continue;
				case 0u:
					num = ((int)num2 * -761516792) ^ -617601742;
					continue;
				default:
					return;
				case 12u:
					break;
				case 5u:
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
			int num = 1713134755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x303EB744u) % 10u)
				{
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 1846867192) ^ -406038400;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 53541987;
						num6 = 53541987;
					}
					else
					{
						num5 = 1250239915;
						num6 = 1250239915;
					}
					num = num5 ^ (int)(num2 * 473180362);
					continue;
				}
				case 7u:
					_currentPlayer = 0;
					flag = _currentTurn > 0;
					num = (int)((num2 * 1752561387) ^ 0x6E2F1CA9);
					continue;
				case 5u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1091780149) ^ 0x4DBDC0BE;
					continue;
				case 4u:
					PlayerTurn(_currentPlayer);
					num = 2074532670;
					continue;
				case 3u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 263667065;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_currentPlayer < Players.Length)
					{
						num3 = 31940204;
						num4 = 31940204;
					}
					else
					{
						num3 = 1318599447;
						num4 = 1318599447;
					}
					num = num3 ^ ((int)num2 * -1948907322);
					continue;
				}
				case 0u:
					num = ((int)num2 * -412773024) ^ 0x17DCAC46;
					continue;
				default:
					return;
				case 6u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		int num7 = default(int);
		PlayerState playerState = default(PlayerState);
		int num15 = default(int);
		bool flag13 = default(bool);
		bool flag5 = default(bool);
		bool flag8 = default(bool);
		bool flag14 = default(bool);
		bool flag9 = default(bool);
		bool flag10 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag11 = default(bool);
		bool flag4 = default(bool);
		Player player = default(Player);
		bool flag3 = default(bool);
		Card card = default(Card);
		int num11 = default(int);
		bool flag2 = default(bool);
		bool flag12 = default(bool);
		bool flag6 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag7 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1220680919;
			while (true)
			{
				uint num2;
				int num16;
				switch ((num2 = (uint)num ^ 0xF063D91Au) % 88u)
				{
				case 87u:
					num = (int)(num2 * 72742676) ^ -164894083;
					continue;
				case 86u:
					num = -417136265;
					continue;
				case 85u:
					num = (int)(num2 * 52875653) ^ -516015373;
					continue;
				case 84u:
					num = (int)((num2 * 1290670712) ^ 0x500A2456);
					continue;
				case 83u:
					num7++;
					num = -808796281;
					continue;
				case 82u:
					Losers.Add(num7);
					num = (int)((num2 * 1795880173) ^ 0x61F6BCBC);
					continue;
				case 81u:
					Print(playerState.State);
					num = ((int)num2 * -643479903) ^ 0x78EC13E2;
					continue;
				case 80u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)((num2 * 219082688) ^ 0x7052A951);
					continue;
				case 79u:
					Losers.Add(num15);
					num = (int)(num2 * 329990228) ^ -2012323637;
					continue;
				case 78u:
					flag13 = playerState.Resources < 0;
					num = (int)((num2 * 1575227965) ^ 0x185694DC);
					continue;
				case 77u:
					flag5 = num7 < _playerStates.Length;
					num = -1053883258;
					continue;
				case 76u:
				{
					int num12;
					int num13;
					if (!flag5)
					{
						num12 = 1352769130;
						num13 = 1352769130;
					}
					else
					{
						num12 = 1647088972;
						num13 = 1647088972;
					}
					num = num12 ^ ((int)num2 * -1382791077);
					continue;
				}
				case 75u:
				{
					int num36;
					int num37;
					if (!flag8)
					{
						num36 = -768697337;
						num37 = -768697337;
					}
					else
					{
						num36 = -1643100736;
						num37 = -1643100736;
					}
					num = num36 ^ (int)(num2 * 2001448087);
					continue;
				}
				case 74u:
					num = ((int)num2 * -2005329040) ^ -1978463407;
					continue;
				case 73u:
					_finished = true;
					num = (int)(num2 * 868398885) ^ -1812013947;
					continue;
				case 72u:
				{
					int num31;
					int num32;
					if (!flag14)
					{
						num31 = -1741180685;
						num32 = -1741180685;
					}
					else
					{
						num31 = -631856208;
						num32 = -631856208;
					}
					num = num31 ^ (int)(num2 * 51614880);
					continue;
				}
				case 71u:
					num = ((int)num2 * -578162674) ^ -1009340554;
					continue;
				case 70u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = (int)(num2 * 1818762234) ^ -1404978464;
					continue;
				case 69u:
				{
					int num25;
					int num26;
					if (flag9)
					{
						num25 = 942394084;
						num26 = 942394084;
					}
					else
					{
						num25 = 1001069458;
						num26 = 1001069458;
					}
					num = num25 ^ ((int)num2 * -1418670027);
					continue;
				}
				case 68u:
					num = (int)((num2 * 521417338) ^ 0x2734E07A);
					continue;
				case 67u:
					flag10 = playerState.State != State.Playing;
					num = (int)(num2 * 166182778) ^ -1731998160;
					continue;
				case 66u:
					num15 = 0;
					num = (int)(num2 * 221549299) ^ -712787093;
					continue;
				case 65u:
					num = (int)((num2 * 290354376) ^ 0x6121D5F2);
					continue;
				case 64u:
					Print("CARD: none, advance");
					num = (int)((num2 * 2115701478) ^ 0x32EBD4BB);
					continue;
				case 63u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1509792794) ^ 0x53D8D541;
					continue;
				case 62u:
					num = ((int)num2 * -369395522) ^ -849586207;
					continue;
				case 61u:
					playerState.Sprint++;
					num = ((int)num2 * -1219786185) ^ 0x2839B15E;
					continue;
				case 60u:
					num = (int)(num2 * 1246475635) ^ -9538374;
					continue;
				case 59u:
					num = -955684402;
					continue;
				case 58u:
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 191184827) ^ 0x6A4E3889);
					continue;
				case 57u:
					playerState2.State = State.Lose;
					num = -584374127;
					continue;
				case 56u:
					flag11 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -1932335660;
					continue;
				case 55u:
				{
					int num14;
					if (playerState.Sprint <= Rules.SprintCount)
					{
						num = -522359001;
						num14 = -522359001;
					}
					else
					{
						num = -494947947;
						num14 = -494947947;
					}
					continue;
				}
				case 54u:
					flag8 = !Losers.Contains(num15);
					num = -1857813927;
					continue;
				case 53u:
					flag4 = true;
					num = (int)(num2 * 247063258) ^ -1256431120;
					continue;
				case 52u:
					num = -652729542;
					continue;
				case 51u:
					player = Players[playerIndex];
					num = (int)(num2 * 17060643) ^ -85881583;
					continue;
				case 50u:
					num = ((int)num2 * -1877126423) ^ -1277134341;
					continue;
				case 49u:
					num = (int)(num2 * 1241822930) ^ -514308695;
					continue;
				case 48u:
					flag3 = flag4;
					num = -1407768352;
					continue;
				case 47u:
				{
					int num10 = card.Impact - player.PlannedForCard(card.Type);
					flag4 = num10 < Rules.StayOnSprintMinDiff;
					num11 = Game.smethod_3(0, num10);
					num = (int)(num2 * 1142528174) ^ -1591021189;
					continue;
				}
				case 46u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 2027354518;
						num6 = 2027354518;
					}
					else
					{
						num5 = 2138579612;
						num6 = 2138579612;
					}
					num = num5 ^ (int)(num2 * 1874402349);
					continue;
				}
				case 45u:
					num = (int)(num2 * 233209991) ^ -1692790709;
					continue;
				case 44u:
					flag4 = true;
					num = ((int)num2 * -1440698947) ^ 0x1E148CAE;
					continue;
				case 43u:
					flag12 = num15 == playerIndex;
					num = (int)(num2 * 541434886) ^ -155637217;
					continue;
				case 42u:
					flag2 = playerState.Sprint < 0;
					num = -2097168596;
					continue;
				case 41u:
					num = ((int)num2 * -1979247561) ^ -2102827298;
					continue;
				case 40u:
				{
					int num34;
					int num35;
					if (!flag6)
					{
						num34 = -1763143337;
						num35 = -1763143337;
					}
					else
					{
						num34 = -474768884;
						num35 = -474768884;
					}
					num = num34 ^ (int)(num2 * 1797592375);
					continue;
				}
				case 39u:
					num = (int)(num2 * 639354138) ^ -1358983582;
					continue;
				case 38u:
				{
					int num33;
					if (num15 < _playerStates.Length)
					{
						num = -2096511610;
						num33 = -2096511610;
					}
					else
					{
						num = -1185301706;
						num33 = -1185301706;
					}
					continue;
				}
				case 37u:
					num = ((int)num2 * -1671986093) ^ -853530866;
					continue;
				case 36u:
				{
					int num29;
					int num30;
					if (!onlyOneWinner)
					{
						num29 = 745015703;
						num30 = 745015703;
					}
					else
					{
						num29 = 76124991;
						num30 = 76124991;
					}
					num = num29 ^ ((int)num2 * -1904440743);
					continue;
				}
				case 34u:
					playerState.Resources -= num11;
					num = ((int)num2 * -546169976) ^ 0x75FA9AF4;
					continue;
				case 33u:
					flag14 = playerState2.Resources >= 0;
					num = (int)((num2 * 151597002) ^ 0x5FAF0330);
					continue;
				case 32u:
					num11 = card.Impact;
					num = ((int)num2 * -1445971617) ^ -1070568055;
					continue;
				case 31u:
					num = ((int)num2 * -1544729056) ^ 0x634679C;
					continue;
				case 30u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -891413574) ^ -68715222;
					continue;
				case 29u:
					num7 = 0;
					num = (int)((num2 * 1743607919) ^ 0x7EF74EAE);
					continue;
				case 28u:
					card = DrawCard();
					flag7 = card.Impact < 0;
					num = (int)(num2 * 221954898) ^ -632822683;
					continue;
				case 27u:
					num15++;
					num = -1218206828;
					continue;
				case 26u:
					num = -1109636760;
					continue;
				case 25u:
					flag4 = false;
					num = -765296739;
					continue;
				case 24u:
				{
					int num27;
					int num28;
					if (!flag13)
					{
						num27 = 739310268;
						num28 = 739310268;
					}
					else
					{
						num27 = 319717620;
						num28 = 319717620;
					}
					num = num27 ^ (int)(num2 * 116559393);
					continue;
				}
				case 23u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 1822502811) ^ 0x2AB43416);
						continue;
					}
					num16 = 0;
					goto IL_070f;
				case 22u:
					num = -245378394;
					continue;
				case 21u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -614717615;
					continue;
				}
				case 20u:
					num = -1346308431;
					continue;
				case 19u:
				{
					int num23;
					int num24;
					if (!Losers.Contains(num7))
					{
						num23 = -1043297565;
						num24 = -1043297565;
					}
					else
					{
						num23 = -97362951;
						num24 = -97362951;
					}
					num = num23 ^ ((int)num2 * -1146864527);
					continue;
				}
				case 18u:
					num = ((int)num2 * -653983921) ^ 0x6E8F637C;
					continue;
				case 17u:
					num = -522359001;
					continue;
				case 16u:
					num = -1933020367;
					continue;
				case 15u:
				{
					int num21;
					int num22;
					if (!flag12)
					{
						num21 = 1234549964;
						num22 = 1234549964;
					}
					else
					{
						num21 = 784207973;
						num22 = 784207973;
					}
					num = num21 ^ (int)(num2 * 606167104);
					continue;
				}
				case 14u:
				{
					int num19;
					int num20;
					if (flag11)
					{
						num19 = 682110463;
						num20 = 682110463;
					}
					else
					{
						num19 = 270386111;
						num20 = 270386111;
					}
					num = num19 ^ (int)(num2 * 417293992);
					continue;
				}
				case 13u:
					num = -846120218;
					continue;
				case 12u:
				{
					int num17;
					int num18;
					if (!flag10)
					{
						num17 = 539846320;
						num18 = 539846320;
					}
					else
					{
						num17 = 2071269939;
						num18 = 2071269939;
					}
					num = num17 ^ (int)(num2 * 2012637742);
					continue;
				}
				case 11u:
					num = (int)(num2 * 306824570) ^ -1683804602;
					continue;
				case 10u:
					playerState2 = _playerStates[num7];
					playerState2.Resources -= Game.smethod_3(0, num11 - Players[num7].PlannedForCard(card.Type));
					num = (int)(num2 * 822139343) ^ -494409763;
					continue;
				case 9u:
					num16 = ((card.Type == 4) ? 1 : 0);
					goto IL_070f;
				case 7u:
					num = ((int)num2 * -1004595225) ^ -482850714;
					continue;
				case 6u:
					playerState.State = State.Lose;
					flag9 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1904137506) ^ -1449768853;
					continue;
				case 5u:
					flag = !flag7;
					num = (int)((num2 * 40609236) ^ 0x5C091877);
					continue;
				case 4u:
					num = ((int)num2 * -929526779) ^ -1958906649;
					continue;
				case 3u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag6 ? "ALL " : "", flag7 ? "receives" : "pays", Game.smethod_4(num11), flag4 ? "advance" : "stay");
					num = -1504951678;
					continue;
				case 2u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = -528846513;
						num9 = -528846513;
					}
					else
					{
						num8 = -1456774611;
						num9 = -1456774611;
					}
					num = num8 ^ ((int)num2 * -1647511239);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 336919043;
						num4 = 336919043;
					}
					else
					{
						num3 = 1261799710;
						num4 = 1261799710;
					}
					num = num3 ^ ((int)num2 * -1586297278);
					continue;
				}
				case 0u:
					num = -1077043823;
					continue;
				default:
					return;
				case 8u:
					break;
				case 35u:
					return;
					IL_070f:
					flag6 = (byte)num16 != 0;
					num = -802150473;
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
			int num = -2049792054;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x81B36D92u) % 7u)
				{
				case 5u:
					num = (int)((num2 * 74744864) ^ 0x60071354);
					continue;
				case 4u:
					card = _deck[0];
					num = -49008585;
					continue;
				case 3u:
					ShuffleCards();
					num = (int)(num2 * 2145686399) ^ -1927456154;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 193770840;
						num4 = 193770840;
					}
					else
					{
						num3 = 1515026508;
						num4 = 1515026508;
					}
					num = num3 ^ (int)(num2 * 1664407105);
					continue;
				}
				case 1u:
					_deck.RemoveAt(0);
					result = card;
					num = ((int)num2 * -1943692968) ^ 0x7505B297;
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

	public string ToString(bool initial)
	{
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = -927151131;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8CC41DCu) % 8u)
				{
				case 5u:
					num3 = 0;
					num = (int)(num2 * 937638687) ^ -1497611516;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -1837716825) ^ -69607845;
					continue;
				case 3u:
				{
					int num4;
					if (num3 < _playerStates.Length)
					{
						num = -1331627076;
						num4 = -1331627076;
					}
					else
					{
						num = -1236973770;
						num4 = -1236973770;
					}
					continue;
				}
				case 2u:
					result = text;
					num = (int)(num2 * 1241082934) ^ -282423618;
					continue;
				case 1u:
					text = "";
					num = (int)(num2 * 2007204568) ^ -109925415;
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
					num = -631029480;
					continue;
				}
				case 7u:
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
			int num = 1322483909;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76223BC0u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1495480945) ^ 0x8C91945;
					continue;
				case 1u:
					result = ToString(initial: false);
					num = (int)((num2 * 1543489542) ^ 0x5AA98188);
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
		string string_ = default(string);
		while (true)
		{
			int num = 274260430;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4905DAC7u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					Game.smethod_8(_buffer, string_);
					return;
				}
				break;
				IL_0003:
				string_ = Game.smethod_7(Game.smethod_5(text), more);
				num = ((int)num2 * -1380750568) ^ -1908456131;
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
