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
			bool result = default(bool);
			while (true)
			{
				int num = 1654322428;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2DFF9206u) % 16u)
					{
					case 14u:
						flag = playerState.State == State.Playing;
						num = ((int)num2 * -1882833725) ^ 0x1C6D5870;
						continue;
					case 13u:
						playerState = playerStates[num3];
						num = 167955336;
						continue;
					case 12u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 248528901;
							num6 = 248528901;
						}
						else
						{
							num5 = 663345066;
							num6 = 663345066;
						}
						num = num5 ^ (int)(num2 * 1672383330);
						continue;
					}
					case 11u:
						num3++;
						num = 1746821214;
						continue;
					case 10u:
					{
						int num7;
						int num8;
						if (!_finished)
						{
							num7 = 1199584165;
							num8 = 1199584165;
						}
						else
						{
							num7 = 188690516;
							num8 = 188690516;
						}
						num = num7 ^ ((int)num2 * -145486579);
						continue;
					}
					case 9u:
						playerStates = _playerStates;
						num3 = 0;
						num = ((int)num2 * -1476184158) ^ 0x589C4176;
						continue;
					case 8u:
					{
						int num4;
						if (num3 < playerStates.Length)
						{
							num = 71883995;
							num4 = 71883995;
						}
						else
						{
							num = 366743057;
							num4 = 366743057;
						}
						continue;
					}
					case 7u:
						result = true;
						num = ((int)num2 * -1867428162) ^ 0x6FC0E0A1;
						continue;
					case 6u:
						num = (int)(num2 * 409271193) ^ -55501633;
						continue;
					case 5u:
						num = ((int)num2 * -1219165) ^ 0xDC361D6;
						continue;
					case 4u:
						result = false;
						num = ((int)num2 * -835491920) ^ -943020247;
						continue;
					case 2u:
						num = ((int)num2 * -800265448) ^ -1538957458;
						continue;
					case 1u:
						num = 2077382207;
						continue;
					case 0u:
						result = true;
						num = (int)(num2 * 838500395) ^ -1067585696;
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
			int num = -2095248961;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB3C5DBEu) % 9u)
				{
				case 7u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					num = (int)(num2 * 169493704) ^ -876398408;
					continue;
				case 6u:
					ShuffleCards();
					num = (int)(num2 * 56055781) ^ -229642306;
					continue;
				case 5u:
					_finished = false;
					num = ((int)num2 * -586331631) ^ 0x1D8669B9;
					continue;
				case 4u:
					num = ((int)num2 * -884568777) ^ 0x4FDB0300;
					continue;
				case 2u:
					Losers.Clear();
					num = (int)(num2 * 1754892276) ^ -46639911;
					continue;
				case 1u:
					_currentChanceIndex = -1;
					num = ((int)num2 * -1437325086) ^ -313653548;
					continue;
				case 0u:
					Winners.Clear();
					num = (int)((num2 * 949058760) ^ 0x11D237C);
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
		PlayerState playerState = default(PlayerState);
		bool flag3 = default(bool);
		int num4 = default(int);
		int planningCardsCount = default(int);
		Player player = default(Player);
		bool flag2 = default(bool);
		while (true)
		{
			bool flag = num < Players.Length;
			int num2 = -1906446338;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD98702BBu) % 23u)
				{
				case 22u:
					num2 = ((int)num3 * -990832453) ^ 0x410FDC0C;
					continue;
				case 21u:
					playerState.Sprint = -1;
					num2 = ((int)num3 * -1919163830) ^ 0x329D1B39;
					continue;
				case 20u:
					num2 = -1196042945;
					continue;
				case 19u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 1531211390;
						num10 = 1531211390;
					}
					else
					{
						num9 = 1797527602;
						num10 = 1797527602;
					}
					num2 = num9 ^ ((int)num3 * -1679544110);
					continue;
				}
				case 18u:
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num2 = ((int)num3 * -382339745) ^ 0x7981C2B4;
					continue;
				case 17u:
					flag3 = num4 > 0;
					num2 = -1031668556;
					continue;
				case 16u:
					num2 = -1529437321;
					continue;
				case 14u:
					num2 = ((int)num3 * -1912681089) ^ 0x39534D17;
					continue;
				case 13u:
					planningCardsCount = player.PlanningCardsCount;
					num4 = 0;
					num2 = (int)(num3 * 1723872106) ^ -1370175680;
					continue;
				case 12u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -935498921) ^ -1490913987;
					continue;
				case 11u:
					num++;
					num2 = (int)(num3 * 277851729) ^ -532462623;
					continue;
				case 10u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -1381805119;
						num12 = -1381805119;
					}
					else
					{
						num11 = -1011666414;
						num12 = -1011666414;
					}
					num2 = num11 ^ (int)(num3 * 459111281);
					continue;
				}
				case 9u:
					num4 = 0;
					num2 = -373732490;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 358047642;
						num8 = 358047642;
					}
					else
					{
						num7 = 1114665980;
						num8 = 1114665980;
					}
					num2 = num7 ^ (int)(num3 * 2036210575);
					continue;
				}
				case 7u:
					player = Players[num];
					playerState = _playerStates[num];
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num2 = -744234670;
					continue;
				case 5u:
				{
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					int num5;
					int num6;
					if (!player.UseOneMorePlanningSprint)
					{
						num5 = 415868996;
						num6 = 415868996;
					}
					else
					{
						num5 = 2130752992;
						num6 = 2130752992;
					}
					num2 = num5 ^ ((int)num3 * -1314466451);
					continue;
				}
				case 4u:
					num2 = ((int)num3 * -1490492720) ^ 0x4532200E;
					continue;
				case 3u:
					flag2 = planningCardsCount == 0;
					num2 = ((int)num3 * -1784502883) ^ -1062772036;
					continue;
				case 2u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num2 = (int)(num3 * 1251871803) ^ -1044034689;
					continue;
				case 1u:
					num2 = -1155884306;
					continue;
				case 0u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num2 = -757390211;
					continue;
				default:
					return;
				case 15u:
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
		_currentPlayer++;
		while (true)
		{
			int num = 980781658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B1B585Cu) % 13u)
				{
				case 11u:
					PlayerTurn(_currentPlayer);
					num = 1089976949;
					continue;
				case 10u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 148931173;
					continue;
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = ((int)num2 * -696196801) ^ 0x1E58559D;
					continue;
				case 8u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 1815773226) ^ -519681844;
					continue;
				case 7u:
					num = ((int)num2 * -1100846533) ^ -1768104532;
					continue;
				case 6u:
					num = (int)((num2 * 470057116) ^ 0xEC25C7D);
					continue;
				case 5u:
					num = (int)((num2 * 1706190109) ^ 0xC79723D);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (_currentPlayer < Players.Length)
					{
						num5 = -361995961;
						num6 = -361995961;
					}
					else
					{
						num5 = -360135393;
						num6 = -360135393;
					}
					num = num5 ^ ((int)num2 * -4950686);
					continue;
				}
				case 3u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 574057257) ^ 0x13440D4A);
					continue;
				case 2u:
					num = ((int)num2 * -723942080) ^ 0x311D6E02;
					continue;
				case 1u:
				{
					_currentPlayer = 0;
					int num3;
					int num4;
					if (_currentTurn > 0)
					{
						num3 = 771865919;
						num4 = 771865919;
					}
					else
					{
						num3 = 1437932473;
						num4 = 1437932473;
					}
					num = num3 ^ ((int)num2 * -1775931727);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		int num7 = default(int);
		Card card = default(Card);
		bool onlyOneWinner = default(bool);
		PlayerState playerState = default(PlayerState);
		int num8 = default(int);
		int num4 = default(int);
		bool flag7 = default(bool);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		PlayerState playerState3 = default(PlayerState);
		int num17 = default(int);
		Player player = default(Player);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 211552799;
			while (true)
			{
				uint num2;
				int num3;
				int num30;
				switch ((num2 = (uint)num ^ 0x4A8F2C7Bu) % 77u)
				{
				case 76u:
					num7 = card.Impact;
					num = (int)((num2 * 379275997) ^ 0x262B7F4B);
					continue;
				case 75u:
				{
					int num5;
					int num6;
					if (onlyOneWinner)
					{
						num5 = 998073044;
						num6 = 998073044;
					}
					else
					{
						num5 = 244474462;
						num6 = 244474462;
					}
					num = num5 ^ ((int)num2 * -70807872);
					continue;
				}
				case 74u:
					num = (int)((num2 * 32990224) ^ 0x458F78EE);
					continue;
				case 73u:
					num = 2082377107;
					continue;
				case 72u:
					num = ((int)num2 * -836850788) ^ -1571007039;
					continue;
				case 71u:
					num = 1851760332;
					continue;
				case 69u:
					playerState.Sprint++;
					num = ((int)num2 * -1456777874) ^ 0x726B4DE3;
					continue;
				case 68u:
					num = (int)(num2 * 1938431832) ^ -1791598799;
					continue;
				case 67u:
					num8 = 0;
					num = (int)(num2 * 405871187) ^ -1951965160;
					continue;
				case 66u:
					num = 1955073515;
					continue;
				case 65u:
				{
					int num33;
					int num34;
					if (Losers.Contains(num4))
					{
						num33 = 1840014903;
						num34 = 1840014903;
					}
					else
					{
						num33 = 1176718086;
						num34 = 1176718086;
					}
					num = num33 ^ (int)(num2 * 904348183);
					continue;
				}
				case 64u:
					card = DrawCard();
					num = ((int)num2 * -1931207319) ^ -982908141;
					continue;
				case 63u:
					num = (int)((num2 * 844784322) ^ 0x714F1FAC);
					continue;
				case 62u:
					num3 = ((card.Type == 4) ? 1 : 0);
					goto IL_0148;
				case 61u:
					flag7 = playerState.Sprint < 0;
					num = 191933834;
					continue;
				case 60u:
					Print(playerState.State);
					num = (int)(num2 * 1556862965) ^ -224713283;
					continue;
				case 59u:
					flag3 = true;
					Print("CARD: none, advance");
					num = (int)(num2 * 1571503771) ^ -618307070;
					continue;
				case 58u:
				{
					int num22;
					int num23;
					if (flag7)
					{
						num22 = -1081782349;
						num23 = -1081782349;
					}
					else
					{
						num22 = -623941052;
						num23 = -623941052;
					}
					num = num22 ^ (int)(num2 * 533739211);
					continue;
				}
				case 57u:
					num = 909757290;
					continue;
				case 56u:
					num = ((int)num2 * -1524645414) ^ 0x783B63ED;
					continue;
				case 55u:
					Print("Still planning");
					num = (int)(num2 * 1688297285) ^ -452306938;
					continue;
				case 54u:
					playerState.State = State.Won;
					num = ((int)num2 * -1185253853) ^ -1075474888;
					continue;
				case 53u:
					num = (int)(num2 * 2046945686) ^ -1969416221;
					continue;
				case 52u:
					flag6 = flag3;
					num = 1944935952;
					continue;
				case 51u:
					playerState3.State = State.Lose;
					num = 143020307;
					continue;
				case 50u:
					num = (int)((num2 * 1929294257) ^ 0x6167238C);
					continue;
				case 49u:
					num17 = card.Impact - player.PlannedForCard(card.Type);
					flag3 = num17 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -45660240) ^ 0x63DE2E60;
					continue;
				case 48u:
					num = 1932733377;
					continue;
				case 47u:
					num7 = Game.smethod_3(0, num17);
					num = ((int)num2 * -1110237844) ^ -1250906683;
					continue;
				case 46u:
					playerState.Sprint++;
					num = ((int)num2 * -2008172557) ^ 0x3222D83;
					continue;
				case 45u:
					num = ((int)num2 * -713862557) ^ 0x7BC03229;
					continue;
				case 44u:
					num4++;
					num = 222654105;
					continue;
				case 43u:
					playerState.Resources -= num7;
					num = ((int)num2 * -401563691) ^ -1871254544;
					continue;
				case 41u:
					num = ((int)num2 * -245311800) ^ 0x491811EA;
					continue;
				case 40u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -78396519) ^ -154139504;
					continue;
				case 39u:
					Winners.Add(playerIndex);
					num = (int)((num2 * 1180718371) ^ 0xEAC5A5F);
					continue;
				case 38u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = -1665343868;
						num13 = -1665343868;
					}
					else
					{
						num12 = -454975576;
						num13 = -454975576;
					}
					num = num12 ^ (int)(num2 * 126550824);
					continue;
				}
				case 37u:
				{
					int num9;
					if (!Losers.Contains(num8))
					{
						num = 26745406;
						num9 = 26745406;
					}
					else
					{
						num = 1259740438;
						num9 = 1259740438;
					}
					continue;
				}
				case 36u:
					Losers.Add(num4);
					num = (int)(num2 * 140361127) ^ -304079796;
					continue;
				case 35u:
					num = (int)(num2 * 568749491) ^ -1286904937;
					continue;
				case 34u:
				{
					int num32;
					if (num4 < _playerStates.Length)
					{
						num = 1794112474;
						num32 = 1794112474;
					}
					else
					{
						num = 1587814034;
						num32 = 1587814034;
					}
					continue;
				}
				case 33u:
				{
					int num31;
					if (playerState.Sprint > Rules.SprintCount)
					{
						num = 599383606;
						num31 = 599383606;
					}
					else
					{
						num = 2082377107;
						num31 = 2082377107;
					}
					continue;
				}
				case 32u:
				{
					int num28;
					int num29;
					if (flag6)
					{
						num28 = 1246465856;
						num29 = 1246465856;
					}
					else
					{
						num28 = 1239862470;
						num29 = 1239862470;
					}
					num = num28 ^ ((int)num2 * -125352277);
					continue;
				}
				case 31u:
					player = Players[playerIndex];
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -1078003573) ^ -1481914808;
					continue;
				case 30u:
					num = 2145482068;
					continue;
				case 29u:
					num8++;
					num = 1611382886;
					continue;
				case 28u:
					num = ((int)num2 * -2067220377) ^ -900556610;
					continue;
				case 27u:
					num = (int)((num2 * 1064931853) ^ 0x293D5396);
					continue;
				case 26u:
					num = 1119442658;
					continue;
				case 25u:
				{
					int num26;
					int num27;
					if (flag4)
					{
						num26 = 1964237634;
						num27 = 1964237634;
					}
					else
					{
						num26 = 1844998565;
						num27 = 1844998565;
					}
					num = num26 ^ (int)(num2 * 1840131488);
					continue;
				}
				case 24u:
					num = 1834573959;
					continue;
				case 23u:
				{
					int num24;
					int num25;
					if (playerState.State != 0)
					{
						num24 = 79666319;
						num25 = 79666319;
					}
					else
					{
						num24 = 246081363;
						num25 = 246081363;
					}
					num = num24 ^ (int)(num2 * 859487909);
					continue;
				}
				case 22u:
					flag3 = true;
					num = (int)((num2 * 1903903218) ^ 0x71D2B151);
					continue;
				case 21u:
					Losers.Add(num8);
					num = (int)((num2 * 633977411) ^ 0xD192A8F);
					continue;
				case 20u:
				{
					playerState.State = State.Lose;
					int num20;
					int num21;
					if (Losers.Contains(playerIndex))
					{
						num20 = 1406200230;
						num21 = 1406200230;
					}
					else
					{
						num20 = 553937709;
						num21 = 553937709;
					}
					num = num20 ^ (int)(num2 * 1747027609);
					continue;
				}
				case 19u:
					num = (int)(num2 * 1253415262) ^ -1168898941;
					continue;
				case 18u:
				{
					int num18;
					int num19;
					if (num8 != playerIndex)
					{
						num18 = 1548791605;
						num19 = 1548791605;
					}
					else
					{
						num18 = 1286692840;
						num19 = 1286692840;
					}
					num = num18 ^ (int)(num2 * 1904969629);
					continue;
				}
				case 17u:
					playerState3 = _playerStates[num4];
					num = (int)(num2 * 884937686) ^ -1949738785;
					continue;
				case 16u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -285740628) ^ 0x6F50CF35;
					continue;
				case 15u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag5 ? "ALL " : "", flag ? "receives" : "pays", Game.smethod_4(num7), flag3 ? "advance" : "stay");
					flag2 = !flag5;
					num = 1127822474;
					continue;
				case 14u:
				{
					int num15;
					int num16;
					if (playerState.Resources < 0)
					{
						num15 = 378074077;
						num16 = 378074077;
					}
					else
					{
						num15 = 1371862431;
						num16 = 1371862431;
					}
					num = num15 ^ (int)(num2 * 615692910);
					continue;
				}
				case 13u:
					flag4 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 1787401177;
					continue;
				case 12u:
				{
					int num14;
					if (num8 >= _playerStates.Length)
					{
						num = 1482606099;
						num14 = 1482606099;
					}
					else
					{
						num = 324638362;
						num14 = 324638362;
					}
					continue;
				}
				case 11u:
					flag3 = false;
					num = 1701222639;
					continue;
				case 10u:
					num = 1579330538;
					continue;
				case 9u:
					num = ((int)num2 * -1735766805) ^ 0x53D91AEE;
					continue;
				case 8u:
					num = (int)(num2 * 672147308) ^ -1438312082;
					continue;
				case 7u:
					num4 = 0;
					num = 211816506;
					continue;
				case 6u:
					num = ((int)num2 * -157971645) ^ 0x5CEA1FB3;
					continue;
				case 5u:
				{
					playerState3.Resources -= Game.smethod_3(0, num7 - Players[num4].PlannedForCard(card.Type));
					int num10;
					int num11;
					if (playerState3.Resources < 0)
					{
						num10 = -868195617;
						num11 = -868195617;
					}
					else
					{
						num10 = -82184553;
						num11 = -82184553;
					}
					num = num10 ^ (int)(num2 * 1031763140);
					continue;
				}
				case 4u:
					num = ((int)num2 * -2073809187) ^ -676532498;
					continue;
				case 3u:
					num = (int)((num2 * 1810785831) ^ 0x29A98638);
					continue;
				case 2u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = 1952767470;
					continue;
				}
				case 1u:
					_finished = true;
					num = (int)(num2 * 371112199) ^ -1145491194;
					continue;
				case 0u:
					flag = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -782469331) ^ 0x2A3B7BFA;
						continue;
					}
					num3 = 0;
					goto IL_0148;
				default:
					return;
				case 70u:
					break;
				case 42u:
					return;
					IL_0148:
					flag5 = (byte)num3 != 0;
					if (flag)
					{
						num = 1801788855;
						num30 = 1801788855;
					}
					else
					{
						num = 2072001283;
						num30 = 2072001283;
					}
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
			goto IL_0033;
		}
		goto IL_009a;
		IL_009a:
		Card card = _deck[0];
		int num = 1419997475;
		goto IL_006d;
		IL_006d:
		Card result = default(Card);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x4195D123u) % 7u)
			{
			case 6u:
				_deck.RemoveAt(0);
				num = ((int)num2 * -1126652829) ^ 0xE9AB0B;
				continue;
			case 3u:
				break;
			case 2u:
				ShuffleCards();
				num = ((int)num2 * -1083197759) ^ 0x15E87DB5;
				continue;
			case 1u:
				result = card;
				num = ((int)num2 * -2057426838) ^ -1341793874;
				continue;
			case 0u:
				num = ((int)num2 * -1098620666) ^ 0x26EE0402;
				continue;
			case 5u:
				goto IL_009a;
			default:
				return result;
			}
			break;
		}
		goto IL_0033;
		IL_0033:
		num = 189374841;
		goto IL_006d;
	}

	public string ToString(bool initial)
	{
		int num5 = default(int);
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 684939385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66EE0237u) % 9u)
				{
				case 8u:
					num5 = 0;
					num = ((int)num2 * -870540946) ^ 0x793DD433;
					continue;
				case 7u:
					text = "";
					num = (int)(num2 * 1542680215) ^ -1364134768;
					continue;
				case 6u:
					flag = num5 < _playerStates.Length;
					num = 1823098858;
					continue;
				case 5u:
					result = text;
					num = ((int)num2 * -694724079) ^ -1449052079;
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
					num5++;
					num = 211239819;
					continue;
				}
				case 3u:
					num = (int)(num2 * 771034036) ^ -2116613277;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -301903620;
						num4 = -301903620;
					}
					else
					{
						num3 = -1231493354;
						num4 = -1231493354;
					}
					num = num3 ^ ((int)num2 * -695623183);
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
		string result = default(string);
		while (true)
		{
			int num = 131116086;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E2DA8F4u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = ToString(initial: false);
				num = (int)(num2 * 2056741810) ^ -1311924253;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = 1742321450;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3ABE9798u) % 4u)
				{
				case 2u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = (int)((num2 * 531776300) ^ 0x722C4EA9);
					continue;
				case 1u:
					Game.smethod_8(_buffer, string_);
					num = ((int)num2 * -1625499526) ^ 0x7BE22FCD;
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
