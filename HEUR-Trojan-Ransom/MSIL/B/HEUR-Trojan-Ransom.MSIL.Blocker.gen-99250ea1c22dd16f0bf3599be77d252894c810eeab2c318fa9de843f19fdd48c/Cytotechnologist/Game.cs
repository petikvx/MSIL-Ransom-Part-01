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
			if (_finished)
			{
				goto IL_007f;
			}
			goto IL_0132;
			IL_0132:
			PlayerState[] playerStates = _playerStates;
			int num = 986994619;
			goto IL_00eb;
			IL_00eb:
			bool flag = default(bool);
			PlayerState playerState = default(PlayerState);
			int num3 = default(int);
			bool result = default(bool);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D28D52Eu) % 13u)
				{
				case 12u:
					flag = playerState.State == State.Playing;
					num = (int)(num2 * 121564996) ^ -827303293;
					continue;
				case 11u:
					break;
				case 10u:
					playerState = playerStates[num3];
					num = 1851939346;
					continue;
				case 9u:
					result = true;
					num = ((int)num2 * -1222252987) ^ 0x2BFD110C;
					continue;
				case 8u:
					num = (int)((num2 * 395998802) ^ 0x398E3352);
					continue;
				case 7u:
					goto end_IL_00eb;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -2078696969;
						num5 = -2078696969;
					}
					else
					{
						num4 = -1326951115;
						num5 = -1326951115;
					}
					num = num4 ^ (int)(num2 * 1333478194);
					continue;
				}
				case 5u:
					result = true;
					num = ((int)num2 * -1671785533) ^ 0x61D2F5B3;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -674092624) ^ 0x68B4A5FB;
					continue;
				case 3u:
					result = false;
					num = (int)((num2 * 1141894061) ^ 0x4C5E5739);
					continue;
				case 1u:
					num3++;
					num = 53209992;
					continue;
				case 2u:
					goto IL_0132;
				default:
					return result;
				}
				int num6;
				if (num3 < playerStates.Length)
				{
					num = 278979412;
					num6 = 278979412;
				}
				else
				{
					num = 869208755;
					num6 = 869208755;
				}
				continue;
				end_IL_00eb:
				break;
			}
			goto IL_007f;
			IL_007f:
			num = 776483878;
			goto IL_00eb;
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
			int num = 1940675270;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74D7C42u) % 3u)
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
				num = (int)((num2 * 1398109194) ^ 0x1E155C6B);
			}
		}
	}

	public void StartNew()
	{
		ShuffleCards();
		while (true)
		{
			int num = -1142969417;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2B561DDu) % 7u)
				{
				case 4u:
					Losers.Clear();
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1652204333) ^ 0x1125FB6D;
					continue;
				case 3u:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -335744560) ^ -257545532;
					continue;
				case 2u:
					Winners.Clear();
					num = (int)(num2 * 1385213764) ^ -1693123023;
					continue;
				case 1u:
					num = (int)(num2 * 237791814) ^ -2066239669;
					continue;
				case 0u:
					_currentTurn = 0;
					_finished = false;
					num = ((int)num2 * -287337717) ^ 0x73088576;
					continue;
				default:
					return;
				case 6u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		int num6 = default(int);
		int planningCardsCount = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 169260166;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5679E4A6u) % 27u)
				{
				case 25u:
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					num = 2079773668;
					continue;
				case 24u:
					num = 834462992;
					continue;
				case 23u:
				{
					int num11;
					int num12;
					if (flag3)
					{
						num11 = -169647171;
						num12 = -169647171;
					}
					else
					{
						num11 = -948759464;
						num12 = -948759464;
					}
					num = num11 ^ ((int)num2 * -710798420);
					continue;
				}
				case 22u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 716454410;
						num8 = 716454410;
					}
					else
					{
						num7 = 1887443314;
						num8 = 1887443314;
					}
					num = num7 ^ ((int)num2 * -303767886);
					continue;
				}
				case 21u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num = (int)(num2 * 1457573903) ^ -514066626;
					continue;
				case 20u:
					playerState.Sprint = 1;
					num = ((int)num2 * -688480229) ^ 0x2477856D;
					continue;
				case 19u:
					num = ((int)num2 * -1195432986) ^ 0x690E3B9A;
					continue;
				case 18u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -2037352848) ^ -2066921387;
					continue;
				case 17u:
					playerState.Sprint = 0;
					num = (int)(num2 * 994021388) ^ -721759263;
					continue;
				case 16u:
					num6 = 0;
					num = 1323035291;
					continue;
				case 15u:
					num3 = 0;
					num = ((int)num2 * -1287287297) ^ 0x2AC17726;
					continue;
				case 14u:
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num = ((int)num2 * -1050665815) ^ 0x68346FAF;
					continue;
				case 13u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num6 = 0;
					num = ((int)num2 * -483981329) ^ 0x5E1B5ED1;
					continue;
				case 12u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num = 1838064543;
					continue;
				case 11u:
					num = (int)(num2 * 1999067849) ^ -1403882015;
					continue;
				case 10u:
					flag3 = num6 > 0;
					num = 1111201450;
					continue;
				case 8u:
					playerState.Sprint = -1;
					num = ((int)num2 * -780055865) ^ -1735697121;
					continue;
				case 7u:
					flag2 = planningCardsCount == 0;
					num = ((int)num2 * -426817491) ^ -1749470863;
					continue;
				case 6u:
					num = 3450736;
					continue;
				case 5u:
					num3++;
					num = ((int)num2 * -802184546) ^ -1334385932;
					continue;
				case 4u:
					num = ((int)num2 * -211538933) ^ -2127129440;
					continue;
				case 3u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -1671543569;
						num10 = -1671543569;
					}
					else
					{
						num9 = -1333719193;
						num10 = -1333719193;
					}
					num = num9 ^ ((int)num2 * -285648399);
					continue;
				}
				case 2u:
				{
					int num4;
					int num5;
					if (!useOneMorePlanningSprint)
					{
						num4 = -1098758624;
						num5 = -1098758624;
					}
					else
					{
						num4 = -526345493;
						num5 = -526345493;
					}
					num = num4 ^ ((int)num2 * -899558914);
					continue;
				}
				case 1u:
					flag = num3 < Players.Length;
					num = 1117352144;
					continue;
				case 0u:
					player = Players[num3];
					playerState = _playerStates[num3];
					num = (int)(num2 * 2048920973) ^ -1172529760;
					continue;
				default:
					return;
				case 9u:
					break;
				case 26u:
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
		bool flag2 = default(bool);
		while (true)
		{
			int num = 930170667;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4AB8855Bu) % 15u)
				{
				case 14u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1398461887) ^ -1962001682;
					continue;
				case 13u:
					num = (int)((num2 * 855323289) ^ 0x613B8CB4);
					continue;
				case 12u:
					_currentPlayer = 0;
					num = (int)((num2 * 1800690117) ^ 0x5D155BAE);
					continue;
				case 11u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 1773018758) ^ 0x1D6F1756);
					continue;
				case 10u:
					num = ((int)num2 * -1478703051) ^ -95511242;
					continue;
				case 9u:
					PlayerTurn(_currentPlayer);
					num = 288407747;
					continue;
				case 8u:
					num = ((int)num2 * -1551688975) ^ 0x1BF098BF;
					continue;
				case 7u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = ((int)num2 * -972247032) ^ 0x737C56C5;
					continue;
				case 6u:
					flag = _currentTurn > 0;
					num = (int)((num2 * 1462009738) ^ 0x3A9BBF39);
					continue;
				case 5u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 875937649;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1374273648;
						num6 = -1374273648;
					}
					else
					{
						num5 = -1213629094;
						num6 = -1213629094;
					}
					num = num5 ^ (int)(num2 * 1505865303);
					continue;
				}
				case 2u:
					flag2 = _currentPlayer >= Players.Length;
					num = ((int)num2 * -1839871844) ^ -592340170;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1956908603;
						num4 = -1956908603;
					}
					else
					{
						num3 = -667589948;
						num4 = -667589948;
					}
					num = num3 ^ (int)(num2 * 573818490);
					continue;
				}
				default:
					return;
				case 4u:
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
		Player player = Players[playerIndex];
		bool flag4 = default(bool);
		int num16 = default(int);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		Card card = default(Card);
		PlayerState playerState3 = default(PlayerState);
		int num7 = default(int);
		PlayerState playerState = default(PlayerState);
		int num20 = default(int);
		bool flag11 = default(bool);
		int num26 = default(int);
		bool flag = default(bool);
		bool flag15 = default(bool);
		bool flag14 = default(bool);
		bool flag10 = default(bool);
		bool flag5 = default(bool);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		bool flag12 = default(bool);
		bool flag3 = default(bool);
		bool flag13 = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			int num = 921226751;
			while (true)
			{
				uint num2;
				int num25;
				switch ((num2 = (uint)num ^ 0x565E9827u) % 89u)
				{
				case 88u:
					num = (int)(num2 * 1062326522) ^ -301972475;
					continue;
				case 87u:
					flag4 = !Losers.Contains(num16);
					num = 775946517;
					continue;
				case 86u:
				{
					int num21;
					int num22;
					if (!flag9)
					{
						num21 = -1467353167;
						num22 = -1467353167;
					}
					else
					{
						num21 = -164404564;
						num22 = -164404564;
					}
					num = num21 ^ (int)(num2 * 129726834);
					continue;
				}
				case 85u:
					Losers.Add(num16);
					num = (int)((num2 * 143900013) ^ 0x444A31AB);
					continue;
				case 84u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 977624582;
						num6 = 977624582;
					}
					else
					{
						num5 = 1675574904;
						num6 = 1675574904;
					}
					num = num5 ^ ((int)num2 * -1455911005);
					continue;
				}
				case 83u:
					num = (int)((num2 * 1030121453) ^ 0x50517EA2);
					continue;
				case 82u:
					card = DrawCard();
					num = (int)((num2 * 1182300737) ^ 0x22CBE58C);
					continue;
				case 81u:
					playerState3 = _playerStates[num7];
					num = 1877131515;
					continue;
				case 80u:
					num = ((int)num2 * -1835354044) ^ -95019588;
					continue;
				case 79u:
					num = 1676364134;
					continue;
				case 78u:
					playerState.Resources -= num20;
					num = (int)(num2 * 161368262) ^ -2079041842;
					continue;
				case 76u:
					num = 133662214;
					continue;
				case 75u:
				{
					Winners.Add(playerIndex);
					int num12;
					int num13;
					if (Rules.OnlyOneWinner)
					{
						num12 = 829943089;
						num13 = 829943089;
					}
					else
					{
						num12 = 1922048068;
						num13 = 1922048068;
					}
					num = num12 ^ (int)(num2 * 1376447295);
					continue;
				}
				case 74u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = -1133211897;
						num9 = -1133211897;
					}
					else
					{
						num8 = -1576861245;
						num9 = -1576861245;
					}
					num = num8 ^ (int)(num2 * 948456832);
					continue;
				}
				case 73u:
					num7 = 0;
					num = (int)((num2 * 611454864) ^ 0x3716EBCF);
					continue;
				case 72u:
				{
					int num33;
					int num34;
					if (!flag11)
					{
						num33 = -24485744;
						num34 = -24485744;
					}
					else
					{
						num33 = -1850282397;
						num34 = -1850282397;
					}
					num = num33 ^ (int)(num2 * 1320314495);
					continue;
				}
				case 71u:
					playerState.Sprint++;
					num = ((int)num2 * -1791775089) ^ 0x3471AAD7;
					continue;
				case 70u:
					num16 = 0;
					num = (int)((num2 * 1549714016) ^ 0x1DB4FADA);
					continue;
				case 69u:
					num26 = card.Impact - player.PlannedForCard(card.Type);
					flag = num26 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -871506006) ^ -1033261393;
					continue;
				case 68u:
					num = (int)(num2 * 1965503808) ^ -1946402432;
					continue;
				case 67u:
					playerState3.Resources -= Game.smethod_3(0, num20 - Players[num7].PlannedForCard(card.Type));
					num = (int)((num2 * 422450669) ^ 0x797FE957);
					continue;
				case 66u:
					num = (int)((num2 * 1754498845) ^ 0x77B34881);
					continue;
				case 65u:
					flag15 = playerState.Sprint > Rules.SprintCount;
					num = 1689804429;
					continue;
				case 64u:
					flag14 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 30953357;
					continue;
				case 63u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)(num2 * 1130541217) ^ -262561739;
					continue;
				case 62u:
					num = 1366092129;
					continue;
				case 61u:
				{
					int num23;
					int num24;
					if (!flag10)
					{
						num23 = -1789876730;
						num24 = -1789876730;
					}
					else
					{
						num23 = -1012802282;
						num24 = -1012802282;
					}
					num = num23 ^ ((int)num2 * -1342182378);
					continue;
				}
				case 60u:
					playerState = _playerStates[playerIndex];
					num = (int)(num2 * 1675866966) ^ -1357340269;
					continue;
				case 59u:
					num = 208829339;
					continue;
				case 58u:
					flag5 = playerState.State != State.Playing;
					num = ((int)num2 * -765270180) ^ 0x6B8FA27D;
					continue;
				case 57u:
				{
					int num18;
					int num19;
					if (flag7)
					{
						num18 = -927406245;
						num19 = -927406245;
					}
					else
					{
						num18 = -1067216287;
						num19 = -1067216287;
					}
					num = num18 ^ ((int)num2 * -598355544);
					continue;
				}
				case 56u:
					num = (int)((num2 * 1428865703) ^ 0x45AFF2F7);
					continue;
				case 55u:
					num = 1491664410;
					continue;
				case 54u:
				{
					int num14;
					int num15;
					if (flag6)
					{
						num14 = 1005527546;
						num15 = 1005527546;
					}
					else
					{
						num14 = 1915355535;
						num15 = 1915355535;
					}
					num = num14 ^ ((int)num2 * -310743423);
					continue;
				}
				case 53u:
				{
					int num37;
					int num38;
					if (!flag12)
					{
						num37 = -1416705156;
						num38 = -1416705156;
					}
					else
					{
						num37 = -632516951;
						num38 = -632516951;
					}
					num = num37 ^ (int)(num2 * 1151270664);
					continue;
				}
				case 52u:
					num = 1025078204;
					continue;
				case 51u:
					num = ((int)num2 * -838738881) ^ -1664357663;
					continue;
				case 50u:
					num = (int)(num2 * 426629776) ^ -2082580499;
					continue;
				case 48u:
					num = (int)(num2 * 1721229862) ^ -128322267;
					continue;
				case 47u:
					num = ((int)num2 * -694571554) ^ 0x2627D863;
					continue;
				case 46u:
					num16++;
					num = 975036945;
					continue;
				case 45u:
					playerState.State = State.Lose;
					flag6 = !Losers.Contains(playerIndex);
					num = (int)((num2 * 1698534237) ^ 0x5DB83C61);
					continue;
				case 44u:
					playerState3.State = State.Lose;
					num = 931695637;
					continue;
				case 43u:
					num = (int)((num2 * 110833699) ^ 0x669092CF);
					continue;
				case 42u:
					flag3 = num16 < _playerStates.Length;
					num = 488362905;
					continue;
				case 41u:
				{
					int num35;
					int num36;
					if (playerState.Resources < 0)
					{
						num35 = -838640419;
						num36 = -838640419;
					}
					else
					{
						num35 = -1165071276;
						num36 = -1165071276;
					}
					num = num35 ^ (int)(num2 * 755226945);
					continue;
				}
				case 40u:
					Losers.Add(num7);
					num = (int)((num2 * 1583341923) ^ 0x21DF53B9);
					continue;
				case 39u:
					num = (int)(num2 * 302276396) ^ -2041135763;
					continue;
				case 38u:
				{
					int num31;
					int num32;
					if (flag14)
					{
						num31 = -1396732611;
						num32 = -1396732611;
					}
					else
					{
						num31 = -847579535;
						num32 = -847579535;
					}
					num = num31 ^ ((int)num2 * -1608874069);
					continue;
				}
				case 37u:
					num = ((int)num2 * -785334308) ^ 0x75120A6F;
					continue;
				case 36u:
					num = ((int)num2 * -726592728) ^ 0x7F92AF06;
					continue;
				case 35u:
					flag10 = !Losers.Contains(num7);
					num = ((int)num2 * -780052650) ^ -55671744;
					continue;
				case 34u:
				{
					int num29;
					int num30;
					if (flag15)
					{
						num29 = -1761548005;
						num30 = -1761548005;
					}
					else
					{
						num29 = -491381006;
						num30 = -491381006;
					}
					num = num29 ^ ((int)num2 * -1462399342);
					continue;
				}
				case 33u:
					flag = true;
					num = 268335817;
					continue;
				case 32u:
					flag13 = num16 == playerIndex;
					num = (int)(num2 * 302840672) ^ -1240937483;
					continue;
				case 31u:
					Print("Still planning");
					num = ((int)num2 * -1221560161) ^ -1407145335;
					continue;
				case 30u:
					flag8 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 740327635) ^ 0x201EE144);
						continue;
					}
					num25 = 0;
					goto IL_0687;
				case 29u:
					playerState.Sprint++;
					num = ((int)num2 * -1582384634) ^ 0x2381BA14;
					continue;
				case 28u:
				{
					int num27;
					int num28;
					if (flag13)
					{
						num27 = 236058362;
						num28 = 236058362;
					}
					else
					{
						num27 = 1816967230;
						num28 = 1816967230;
					}
					num = num27 ^ ((int)num2 * -1177290951);
					continue;
				}
				case 27u:
					num = ((int)num2 * -144520294) ^ 0x7411D2C0;
					continue;
				case 26u:
					flag = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -590931010) ^ 0x162EAA49;
					continue;
				case 25u:
					Print(playerState.State);
					num = (int)(num2 * 303576239) ^ -1343873363;
					continue;
				case 24u:
					num20 = card.Impact;
					num = ((int)num2 * -690273620) ^ -2094876679;
					continue;
				case 23u:
					num20 = Game.smethod_3(0, num26);
					num = ((int)num2 * -1456228804) ^ 0x5890A7D9;
					continue;
				case 22u:
					flag12 = playerState.Sprint < 0;
					num = 976776266;
					continue;
				case 21u:
					num = (int)((num2 * 1680150797) ^ 0x759F0A7F);
					continue;
				case 20u:
					num25 = ((card.Type == 4) ? 1 : 0);
					goto IL_0687;
				case 19u:
					playerState.State = State.Won;
					num = (int)(num2 * 1748688914) ^ -1893240767;
					continue;
				case 18u:
					num = 1472669771;
					continue;
				case 17u:
					num = ((int)num2 * -1757311158) ^ 0x6CA7BD4C;
					continue;
				case 16u:
					flag11 = playerState3.Resources >= 0;
					num = ((int)num2 * -343548583) ^ 0x5D22D6ED;
					continue;
				case 15u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag7 ? "ALL " : "", flag8 ? "receives" : "pays", Game.smethod_4(num20), flag ? "advance" : "stay");
					num = 1129211211;
					continue;
				case 14u:
					flag = false;
					num = 604691304;
					continue;
				case 13u:
					num7++;
					num = 664516924;
					continue;
				case 12u:
				{
					int num17;
					if (num7 >= _playerStates.Length)
					{
						num = 1165643610;
						num17 = 1165643610;
					}
					else
					{
						num = 218022114;
						num17 = 218022114;
					}
					continue;
				}
				case 11u:
					num = (int)((num2 * 1432931366) ^ 0x6138DB85);
					continue;
				case 10u:
					num = (int)(num2 * 2075100009) ^ -755369526;
					continue;
				case 9u:
					num = ((int)num2 * -67562240) ^ 0x4CAD644D;
					continue;
				case 8u:
					num = (int)((num2 * 1324319257) ^ 0x6202C344);
					continue;
				case 7u:
					_finished = true;
					num = (int)((num2 * 781981608) ^ 0x30433F29);
					continue;
				case 6u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = 1128022349;
					continue;
				}
				case 5u:
				{
					int num10;
					int num11;
					if (flag5)
					{
						num10 = 50046039;
						num11 = 50046039;
					}
					else
					{
						num10 = 1336040630;
						num11 = 1336040630;
					}
					num = num10 ^ (int)(num2 * 544436694);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (!flag3)
					{
						num3 = -1713350836;
						num4 = -1713350836;
					}
					else
					{
						num3 = -895351935;
						num4 = -895351935;
					}
					num = num3 ^ (int)(num2 * 431854209);
					continue;
				}
				case 3u:
					flag2 = flag;
					num = 344482443;
					continue;
				case 2u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 900625251) ^ 0xDA92639);
					continue;
				case 1u:
					num = 825649404;
					continue;
				case 0u:
					num = (int)(num2 * 163869399) ^ -1097124633;
					continue;
				default:
					return;
				case 77u:
					break;
				case 49u:
					return;
					IL_0687:
					flag7 = (byte)num25 != 0;
					flag9 = !flag8;
					num = 1144677796;
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
			int num = 2071982954;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x172A76Fu) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1798582351) ^ 0x29C8BC66;
					continue;
				case 5u:
					flag = _deck.Count <= 0;
					num = (int)((num2 * 1070711152) ^ 0x6F2ACBD);
					continue;
				case 4u:
					result = card;
					num = (int)((num2 * 1887139044) ^ 0x13D6D3D0);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2144546550;
						num4 = -2144546550;
					}
					else
					{
						num3 = -2069077805;
						num4 = -2069077805;
					}
					num = num3 ^ ((int)num2 * -129335126);
					continue;
				}
				case 1u:
					card = _deck[0];
					_deck.RemoveAt(0);
					num = 16908883;
					continue;
				case 0u:
					ShuffleCards();
					num = (int)((num2 * 946285414) ^ 0x5120CFEE);
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
			int num = -618592711;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9731E47u) % 9u)
				{
				case 8u:
					flag = num3 < _playerStates.Length;
					num = -1278072988;
					continue;
				case 7u:
					num = (int)((num2 * 1239398022) ^ 0x3AF8A349);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1440739194;
						num5 = -1440739194;
					}
					else
					{
						num4 = -1823300331;
						num5 = -1823300331;
					}
					num = num4 ^ ((int)num2 * -127879192);
					continue;
				}
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
					num3++;
					num = -1065824290;
					continue;
				}
				case 3u:
					num3 = 0;
					num = ((int)num2 * -394802027) ^ -544242039;
					continue;
				case 1u:
					num = ((int)num2 * -433511268) ^ 0x15F577E;
					continue;
				case 0u:
					result = text;
					num = ((int)num2 * -483311855) ^ 0x12AA9FAF;
					continue;
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
		string result = default(string);
		while (true)
		{
			int num = -1958073695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C7CDC11u) % 3u)
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
				num = (int)(num2 * 189656990) ^ -1034774604;
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
