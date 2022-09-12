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
			bool finished = default(bool);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = -615792668;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDE75542Eu) % 18u)
					{
					case 17u:
						num = (int)(num2 * 114889607) ^ -478169936;
						continue;
					case 16u:
						result = true;
						num = ((int)num2 * -2007352878) ^ -145152380;
						continue;
					case 15u:
					{
						int num6;
						if (num3 < playerStates.Length)
						{
							num = -626492403;
							num6 = -626492403;
						}
						else
						{
							num = -869452223;
							num6 = -869452223;
						}
						continue;
					}
					case 14u:
						num = (int)((num2 * 791381828) ^ 0x14D96C04);
						continue;
					case 13u:
						playerStates = _playerStates;
						num = ((int)num2 * -1968487340) ^ -1458926055;
						continue;
					case 12u:
					{
						int num7;
						int num8;
						if (finished)
						{
							num7 = 398371832;
							num8 = 398371832;
						}
						else
						{
							num7 = 1652546282;
							num8 = 1652546282;
						}
						num = num7 ^ (int)(num2 * 1741376002);
						continue;
					}
					case 11u:
					{
						int num4;
						int num5;
						if (playerState.State == State.Playing)
						{
							num4 = -2119645299;
							num5 = -2119645299;
						}
						else
						{
							num4 = -1823562120;
							num5 = -1823562120;
						}
						num = num4 ^ ((int)num2 * -196714902);
						continue;
					}
					case 10u:
						num = -989444331;
						continue;
					case 9u:
						playerState = playerStates[num3];
						num = -343104435;
						continue;
					case 8u:
						num3++;
						num = -736191099;
						continue;
					case 7u:
						num = ((int)num2 * -1863338530) ^ -1650828278;
						continue;
					case 6u:
						finished = _finished;
						num = ((int)num2 * -1805276253) ^ -1136873888;
						continue;
					case 5u:
						num3 = 0;
						num = ((int)num2 * -645961316) ^ -1407938439;
						continue;
					case 4u:
						num = (int)(num2 * 1605262384) ^ -1319924228;
						continue;
					case 3u:
						result = true;
						num = ((int)num2 * -1016981662) ^ -592844854;
						continue;
					case 1u:
						result = false;
						num = ((int)num2 * -1776138722) ^ 0x4B1FF0ED;
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
			int num = -592194052;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91606967u) % 8u)
				{
				case 7u:
					Losers.Clear();
					num = (int)(num2 * 702381687) ^ -26174286;
					continue;
				case 5u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					_finished = false;
					_currentChanceIndex = -1;
					num = ((int)num2 * -1543343613) ^ -1892268302;
					continue;
				case 4u:
					num = (int)((num2 * 802440687) ^ 0x393DB3AE);
					continue;
				case 3u:
					ShuffleCards();
					num = ((int)num2 * -683422782) ^ -531073895;
					continue;
				case 2u:
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -1797247456) ^ -1875359282;
					continue;
				case 0u:
					Winners.Clear();
					num = (int)((num2 * 273889505) ^ 0x32395828);
					continue;
				default:
					return;
				case 6u:
					break;
				case 1u:
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
		bool useOneMorePlanningSprint = default(bool);
		int planningCardsCount = default(int);
		int num4 = default(int);
		Player player = default(Player);
		while (true)
		{
			int num = 1276599022;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4FFC8406u) % 25u)
				{
				case 24u:
					playerState = _playerStates[num3];
					num = ((int)num2 * -1781958652) ^ 0x375CA6CF;
					continue;
				case 23u:
					playerState.Sprint = 0;
					num = (int)((num2 * 749557768) ^ 0x1B4F215D);
					continue;
				case 22u:
					num3 = 0;
					num = ((int)num2 * -640865656) ^ -1133072958;
					continue;
				case 21u:
					num = ((int)num2 * -44998503) ^ 0x16B932F2;
					continue;
				case 20u:
				{
					int num7;
					int num8;
					if (!useOneMorePlanningSprint)
					{
						num7 = -1321925045;
						num8 = -1321925045;
					}
					else
					{
						num7 = -1261770614;
						num8 = -1261770614;
					}
					num = num7 ^ ((int)num2 * -1643096436);
					continue;
				}
				case 19u:
					num = (int)((num2 * 1553287607) ^ 0x2C39E5A2);
					continue;
				case 18u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num = 1897584422;
					continue;
				case 17u:
					num4 = 0;
					num = 1887479545;
					continue;
				case 15u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num = (int)((num2 * 55819540) ^ 0x3837344E);
					continue;
				case 14u:
				{
					int num9;
					int num10;
					if (planningCardsCount == 0)
					{
						num9 = 46854860;
						num10 = 46854860;
					}
					else
					{
						num9 = 1762968857;
						num10 = 1762968857;
					}
					num = num9 ^ ((int)num2 * -1574718407);
					continue;
				}
				case 13u:
					num = ((int)num2 * -2110368303) ^ 0x4C6E53CD;
					continue;
				case 12u:
					player = Players[num3];
					num = (int)(num2 * 453280103) ^ -443047789;
					continue;
				case 11u:
					playerState.Sprint = -1;
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num = ((int)num2 * -758363372) ^ -1470685493;
					continue;
				case 10u:
				{
					int num6;
					if (num3 >= Players.Length)
					{
						num = 1170127960;
						num6 = 1170127960;
					}
					else
					{
						num = 1989766543;
						num6 = 1989766543;
					}
					continue;
				}
				case 9u:
				{
					int num5;
					if (num4 <= 0)
					{
						num = 1184142302;
						num5 = 1184142302;
					}
					else
					{
						num = 769521004;
						num5 = 769521004;
					}
					continue;
				}
				case 8u:
					num = 1191323862;
					continue;
				case 6u:
					num = 392875659;
					continue;
				case 5u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num4 = 0;
					num = ((int)num2 * -1078214103) ^ -647320495;
					continue;
				case 4u:
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = 78915026;
					continue;
				case 3u:
					playerState.Sprint = 1;
					num = ((int)num2 * -1507949649) ^ 0x56E3A52A;
					continue;
				case 2u:
					num = (int)((num2 * 915401120) ^ 0x3C6FB2A3);
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 719972462) ^ 0x4BD288F0);
					continue;
				case 0u:
					num = (int)(num2 * 717104430) ^ -1304698119;
					continue;
				default:
					return;
				case 7u:
					break;
				case 16u:
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
			int num = -757488478;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87FDCA80u) % 17u)
				{
				case 16u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1992184746;
						num6 = 1992184746;
					}
					else
					{
						num5 = 1213383815;
						num6 = 1213383815;
					}
					num = num5 ^ ((int)num2 * -615145804);
					continue;
				}
				case 15u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = ((int)num2 * -745857454) ^ 0x64FBB693;
					continue;
				case 13u:
					num = (int)((num2 * 334535716) ^ 0x62050DB2);
					continue;
				case 11u:
					flag2 = _currentTurn > 0;
					num = (int)((num2 * 1753406672) ^ 0x5CDD0C76);
					continue;
				case 10u:
					flag = _currentPlayer >= Players.Length;
					num = ((int)num2 * -27421524) ^ -927751294;
					continue;
				case 9u:
					num = ((int)num2 * -236668694) ^ -923295396;
					continue;
				case 8u:
					num = (int)((num2 * 263802850) ^ 0x69CB2DD0);
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 846713808;
						num4 = 846713808;
					}
					else
					{
						num3 = 2115513021;
						num4 = 2115513021;
					}
					num = num3 ^ (int)(num2 * 1756111267);
					continue;
				}
				case 6u:
					PlayerTurn(_currentPlayer);
					num = -772099384;
					continue;
				case 5u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -1753193087) ^ -1669494763;
					continue;
				case 4u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)(num2 * 1519673625) ^ -319849291;
					continue;
				case 3u:
					_currentPlayer = 0;
					num = (int)((num2 * 1244498066) ^ 0x744BCFCD);
					continue;
				case 2u:
					num = (int)(num2 * 1991752199) ^ -2062851111;
					continue;
				case 1u:
					num = ((int)num2 * -2016071080) ^ 0x1C6DB436;
					continue;
				case 0u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -388094201;
					continue;
				default:
					return;
				case 12u:
					break;
				case 14u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		bool flag = default(bool);
		bool flag8 = default(bool);
		int num8 = default(int);
		Card card = default(Card);
		int num12 = default(int);
		int num9 = default(int);
		bool flag7 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		PlayerState playerState = default(PlayerState);
		int num7 = default(int);
		bool onlyOneWinner = default(bool);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -949356389;
			while (true)
			{
				uint num2;
				int num16;
				switch ((num2 = (uint)num ^ 0xC37AD418u) % 86u)
				{
				case 85u:
					num = (int)((num2 * 275090392) ^ 0x588A8758);
					continue;
				case 84u:
					num = -2070954270;
					continue;
				case 83u:
					num = ((int)num2 * -1889104871) ^ 0xAD60C2C;
					continue;
				case 82u:
				{
					int num14;
					int num15;
					if (!flag)
					{
						num14 = 1088566065;
						num15 = 1088566065;
					}
					else
					{
						num14 = 1472099273;
						num15 = 1472099273;
					}
					num = num14 ^ (int)(num2 * 934617648);
					continue;
				}
				case 81u:
				{
					int num33;
					int num34;
					if (flag8)
					{
						num33 = 721151214;
						num34 = 721151214;
					}
					else
					{
						num33 = 2120649533;
						num34 = 2120649533;
					}
					num = num33 ^ ((int)num2 * -156934778);
					continue;
				}
				case 80u:
					num8 = card.Impact;
					num = ((int)num2 * -1400582) ^ -1996504412;
					continue;
				case 79u:
					Losers.Add(num12);
					num = (int)(num2 * 415586832) ^ -167093637;
					continue;
				case 78u:
					num = ((int)num2 * -1637976183) ^ 0x3F0E60E1;
					continue;
				case 76u:
					num = ((int)num2 * -2004826598) ^ 0x6454BFF5;
					continue;
				case 75u:
					num = (int)((num2 * 429466340) ^ 0x1F0D1C90);
					continue;
				case 74u:
					num = (int)((num2 * 1399683548) ^ 0x78BD73AA);
					continue;
				case 73u:
					Print("CARD: none, advance");
					num = (int)(num2 * 1899203517) ^ -450976047;
					continue;
				case 72u:
				{
					int num10;
					int num11;
					if (!Losers.Contains(num9))
					{
						num10 = 2091020862;
						num11 = 2091020862;
					}
					else
					{
						num10 = 1415375261;
						num11 = 1415375261;
					}
					num = num10 ^ ((int)num2 * -287712378);
					continue;
				}
				case 71u:
				{
					int num29;
					int num30;
					if (!flag7)
					{
						num29 = -1199079099;
						num30 = -1199079099;
					}
					else
					{
						num29 = -715241128;
						num30 = -715241128;
					}
					num = num29 ^ (int)(num2 * 1853212051);
					continue;
				}
				case 70u:
					num = (int)(num2 * 1873099611) ^ -1301871329;
					continue;
				case 69u:
					Print(playerState2.State);
					num = (int)((num2 * 535386737) ^ 0x3E4034B3);
					continue;
				case 68u:
					num = (int)(num2 * 1896538545) ^ -1315594003;
					continue;
				case 67u:
					_finished = true;
					num12 = 0;
					num = ((int)num2 * -637106418) ^ -1093374655;
					continue;
				case 66u:
				{
					int num23;
					int num24;
					if (!flag6)
					{
						num23 = -350281833;
						num24 = -350281833;
					}
					else
					{
						num23 = -927818696;
						num24 = -927818696;
					}
					num = num23 ^ (int)(num2 * 726183599);
					continue;
				}
				case 65u:
					num = -2059031721;
					continue;
				case 64u:
				{
					int num19;
					if (flag4)
					{
						num = -1479109528;
						num19 = -1479109528;
					}
					else
					{
						num = -991014704;
						num19 = -991014704;
					}
					continue;
				}
				case 63u:
					num = -180540587;
					continue;
				case 62u:
					num = ((int)num2 * -1812249722) ^ 0x4E26BAE4;
					continue;
				case 61u:
					num = ((int)num2 * -11220557) ^ 0xC19FFDA;
					continue;
				case 60u:
					num = (int)(num2 * 1421642242) ^ -1744729454;
					continue;
				case 59u:
					num = -943841286;
					continue;
				case 58u:
					num = ((int)num2 * -2091198900) ^ -426543543;
					continue;
				case 57u:
					num = (int)(num2 * 1450672647) ^ -608786184;
					continue;
				case 56u:
					playerState = _playerStates[num9];
					playerState.Resources -= Game.smethod_3(0, num8 - Players[num9].PlannedForCard(card.Type));
					num = (int)(num2 * 1482252988) ^ -877218418;
					continue;
				case 55u:
					num = -633644022;
					continue;
				case 54u:
					num = (int)(num2 * 748535582) ^ -626198227;
					continue;
				case 53u:
					num = ((int)num2 * -1622844022) ^ 0x66EF9E26;
					continue;
				case 52u:
				{
					int num13;
					if (Losers.Contains(num12))
					{
						num = -1143950997;
						num13 = -1143950997;
					}
					else
					{
						num = -649639159;
						num13 = -649639159;
					}
					continue;
				}
				case 51u:
				{
					int num5;
					int num6;
					if (playerState2.State == State.Playing)
					{
						num5 = -1496686750;
						num6 = -1496686750;
					}
					else
					{
						num5 = -299697458;
						num6 = -299697458;
					}
					num = num5 ^ ((int)num2 * -1617180339);
					continue;
				}
				case 50u:
					num8 = Game.smethod_3(0, num7);
					num = (int)((num2 * 1482005132) ^ 0x5FD4D04A);
					continue;
				case 49u:
					flag4 = false;
					num = -1179908788;
					continue;
				case 48u:
					num = (int)(num2 * 1151871255) ^ -874589201;
					continue;
				case 47u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)((num2 * 301536743) ^ 0x5B4C2B12);
					continue;
				case 46u:
					Losers.Add(num9);
					num = (int)(num2 * 86009736) ^ -1235902432;
					continue;
				case 45u:
					playerState.State = State.Lose;
					num = -1980615690;
					continue;
				case 44u:
					playerState2.Sprint++;
					num = (int)(num2 * 1376586483) ^ -1420043648;
					continue;
				case 43u:
					flag4 = true;
					num = (int)((num2 * 1526366067) ^ 0x53697816);
					continue;
				case 42u:
					flag6 = playerState2.Sprint > Rules.SprintCount;
					num = -598853734;
					continue;
				case 41u:
					flag8 = !flag2;
					num = ((int)num2 * -2124484330) ^ -2015903823;
					continue;
				case 40u:
					num = -200857507;
					continue;
				case 39u:
					num = -1820391121;
					continue;
				case 38u:
					num7 = card.Impact - player.PlannedForCard(card.Type);
					flag4 = num7 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -798948358) ^ -2107575166;
					continue;
				case 37u:
				{
					int num31;
					int num32;
					if (!onlyOneWinner)
					{
						num31 = 464416162;
						num32 = 464416162;
					}
					else
					{
						num31 = 1838775850;
						num32 = 1838775850;
					}
					num = num31 ^ ((int)num2 * -355165613);
					continue;
				}
				case 36u:
					num = ((int)num2 * -1673544615) ^ -2019087043;
					continue;
				case 35u:
				{
					int num27;
					int num28;
					if (flag5)
					{
						num27 = -1648952570;
						num28 = -1648952570;
					}
					else
					{
						num27 = -2073316232;
						num28 = -2073316232;
					}
					num = num27 ^ ((int)num2 * -673584580);
					continue;
				}
				case 34u:
				{
					int num25;
					int num26;
					if (num12 == playerIndex)
					{
						num25 = 1674448331;
						num26 = 1674448331;
					}
					else
					{
						num25 = 1567008080;
						num26 = 1567008080;
					}
					num = num25 ^ (int)(num2 * 164514317);
					continue;
				}
				case 33u:
					flag4 = true;
					num = ((int)num2 * -796671047) ^ -1435818165;
					continue;
				case 31u:
					num = -247005623;
					continue;
				case 30u:
					num = ((int)num2 * -2037975441) ^ 0x274624F9;
					continue;
				case 29u:
					flag7 = playerState2.Sprint < 0;
					num = -1568194109;
					continue;
				case 28u:
				{
					playerState2.Resources -= num8;
					int num21;
					int num22;
					if (playerState2.Resources >= 0)
					{
						num21 = 1291469606;
						num22 = 1291469606;
					}
					else
					{
						num21 = 928938679;
						num22 = 928938679;
					}
					num = num21 ^ ((int)num2 * -1566000835);
					continue;
				}
				case 27u:
					num = ((int)num2 * -2101516518) ^ -781765001;
					continue;
				case 26u:
				{
					int num20;
					if (!_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = -1049654466;
						num20 = -1049654466;
					}
					else
					{
						num = -730416265;
						num20 = -730416265;
					}
					continue;
				}
				case 25u:
					num9++;
					num = -1275412320;
					continue;
				case 24u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -1719636428) ^ 0x441E6178;
						continue;
					}
					num16 = 0;
					goto IL_0689;
				case 23u:
					num = ((int)num2 * -364652798) ^ 0x552FBE70;
					continue;
				case 22u:
					num = (int)((num2 * 1139157133) ^ 0xD7AFCEB);
					continue;
				case 21u:
					num12++;
					num = -454768210;
					continue;
				case 20u:
					num9 = 0;
					num = (int)((num2 * 492825580) ^ 0x33090D2D);
					continue;
				case 19u:
					flag5 = !flag3;
					num = (int)(num2 * 1089086926) ^ -1144965337;
					continue;
				case 18u:
				{
					int num18;
					if (num9 < _playerStates.Length)
					{
						num = -2097834247;
						num18 = -2097834247;
					}
					else
					{
						num = -955367175;
						num18 = -955367175;
					}
					continue;
				}
				case 17u:
					num = (int)(num2 * 336764086) ^ -1251222613;
					continue;
				case 16u:
					playerState2.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -739950931) ^ 0x4E34F9A8;
					continue;
				case 15u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1905565686) ^ 0x57C6788E;
					continue;
				case 14u:
				{
					int num17;
					if (num12 >= _playerStates.Length)
					{
						num = -1960383294;
						num17 = -1960383294;
					}
					else
					{
						num = -254198377;
						num17 = -254198377;
					}
					continue;
				}
				case 13u:
					playerState2.Sprint++;
					num = (int)(num2 * 580258156) ^ -1204284488;
					continue;
				case 12u:
					num16 = ((card.Type == 4) ? 1 : 0);
					goto IL_0689;
				case 11u:
					card = DrawCard();
					num = -117224808;
					continue;
				case 10u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag3 ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num8), flag4 ? "advance" : "stay");
					num = -434899512;
					continue;
				case 9u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -1500470340;
					continue;
				}
				case 8u:
					num = (int)(num2 * 374780175) ^ -2059457571;
					continue;
				case 7u:
					num = -229393306;
					continue;
				case 6u:
					Print("Still planning");
					num = ((int)num2 * -730267188) ^ -478123043;
					continue;
				case 5u:
					num = (int)((num2 * 912494242) ^ 0x3BC05C57);
					continue;
				case 4u:
					flag2 = card.Impact < 0;
					num = ((int)num2 * -1500554748) ^ -1717524742;
					continue;
				case 3u:
					playerState2.State = State.Lose;
					flag = !Losers.Contains(playerIndex);
					num = (int)((num2 * 1291983265) ^ 0x6497244F);
					continue;
				case 2u:
					num = (int)(num2 * 1838530782) ^ -1794956551;
					continue;
				case 1u:
					playerState2 = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 756569542) ^ 0x56AAF80C);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (playerState.Resources < 0)
					{
						num3 = -1676390747;
						num4 = -1676390747;
					}
					else
					{
						num3 = -2137711148;
						num4 = -2137711148;
					}
					num = num3 ^ (int)(num2 * 640553461);
					continue;
				}
				default:
					return;
				case 32u:
					break;
				case 77u:
					return;
					IL_0689:
					flag3 = (byte)num16 != 0;
					num = -488335989;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		bool flag = _deck.Count <= 0;
		Card result = default(Card);
		Card card = default(Card);
		while (true)
		{
			int num = 77125346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x781F7874u) % 9u)
				{
				case 8u:
					result = card;
					num = ((int)num2 * -1516845534) ^ -962795051;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1064415856;
						num4 = 1064415856;
					}
					else
					{
						num3 = 1967745102;
						num4 = 1967745102;
					}
					num = num3 ^ (int)(num2 * 1130076605);
					continue;
				}
				case 6u:
					num = ((int)num2 * -476895338) ^ -624176074;
					continue;
				case 4u:
					card = _deck[0];
					num = 1522212571;
					continue;
				case 3u:
					num = ((int)num2 * -153266184) ^ 0x6190E73;
					continue;
				case 1u:
					_deck.RemoveAt(0);
					num = (int)(num2 * 358706865) ^ -379786368;
					continue;
				case 0u:
					ShuffleCards();
					num = (int)((num2 * 2118546441) ^ 0x2BA16537);
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

	public string ToString(bool initial)
	{
		int num3 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 636217016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x210CFA57u) % 9u)
				{
				case 8u:
				{
					int num4;
					if (num3 >= _playerStates.Length)
					{
						num = 757420171;
						num4 = 757420171;
					}
					else
					{
						num = 1046341079;
						num4 = 1046341079;
					}
					continue;
				}
				case 6u:
					num3++;
					num = ((int)num2 * -1747877594) ^ -186015076;
					continue;
				case 5u:
					num = (int)(num2 * 365884148) ^ -744975613;
					continue;
				case 4u:
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
					num = 634161669;
					continue;
				}
				case 3u:
					num3 = 0;
					num = ((int)num2 * -670283565) ^ -1447335360;
					continue;
				case 2u:
					result = text;
					num = (int)(num2 * 1173530783) ^ -1967068262;
					continue;
				case 1u:
					text = "";
					num = ((int)num2 * -280226467) ^ 0x3A8F70D4;
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

	public override string ToString()
	{
		string result = ToString(initial: false);
		while (true)
		{
			int num = 743733755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63054008u) % 3u)
				{
				case 1u:
					goto IL_000a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000a:
				num = ((int)num2 * -1376505259) ^ -1030708992;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = -1242554070;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83D94BB0u) % 4u)
				{
				case 2u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = ((int)num2 * -612094879) ^ -1904809777;
					continue;
				case 1u:
					Game.smethod_8(_buffer, string_);
					num = ((int)num2 * -835053318) ^ 0x1BC13965;
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
