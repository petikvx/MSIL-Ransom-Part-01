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
			int num5 = default(int);
			PlayerState playerState = default(PlayerState);
			PlayerState[] playerStates = default(PlayerState[]);
			while (true)
			{
				int num = 784470260;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3084F07Fu) % 14u)
					{
					case 13u:
						result = true;
						num = ((int)num2 * -638855360) ^ -1965102968;
						continue;
					case 12u:
						result = true;
						num = (int)(num2 * 1738975643) ^ -744278559;
						continue;
					case 11u:
						num5 = 0;
						num = (int)((num2 * 1914183493) ^ 0x796B7819);
						continue;
					case 10u:
						playerState = playerStates[num5];
						num = 1017472945;
						continue;
					case 9u:
					{
						int num6;
						if (num5 < playerStates.Length)
						{
							num = 761869811;
							num6 = 761869811;
						}
						else
						{
							num = 2065980198;
							num6 = 2065980198;
						}
						continue;
					}
					case 8u:
						num = (int)((num2 * 956859040) ^ 0x3ADDAFC8);
						continue;
					case 6u:
					{
						int num7;
						int num8;
						if (playerState.State != 0)
						{
							num7 = 1791112543;
							num8 = 1791112543;
						}
						else
						{
							num7 = 1562257558;
							num8 = 1562257558;
						}
						num = num7 ^ (int)(num2 * 1995050254);
						continue;
					}
					case 4u:
						num = ((int)num2 * -1549755050) ^ -1866096152;
						continue;
					case 3u:
						result = false;
						num = ((int)num2 * -1141303697) ^ -1788797396;
						continue;
					case 2u:
						num5++;
						num = 426469930;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!_finished)
						{
							num3 = 899161604;
							num4 = 899161604;
						}
						else
						{
							num3 = 1985385328;
							num4 = 1985385328;
						}
						num = num3 ^ (int)(num2 * 377189199);
						continue;
					}
					case 0u:
						playerStates = _playerStates;
						num = 276961128;
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
		ShuffleCards();
		while (true)
		{
			int num = 1928814273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x349643C1u) % 9u)
				{
				case 8u:
					_finished = false;
					_currentChanceIndex = -1;
					num = (int)((num2 * 1501350543) ^ 0x67EAA9A8);
					continue;
				case 7u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 1861755628) ^ 0x30C294C8);
					continue;
				case 5u:
					Losers.Clear();
					num = (int)(num2 * 899493836) ^ -2141938353;
					continue;
				case 3u:
					_currentTurn = 0;
					num = (int)(num2 * 842824765) ^ -807791418;
					continue;
				case 2u:
					num = ((int)num2 * -1290349410) ^ 0x7EC2BCA3;
					continue;
				case 1u:
					Winners.Clear();
					num = ((int)num2 * -2018833563) ^ 0x543BB5BC;
					continue;
				case 0u:
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -2095324049) ^ 0x710D69ED;
					continue;
				default:
					return;
				case 4u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		bool flag2 = default(bool);
		int num6 = default(int);
		PlayerState playerState = default(PlayerState);
		int planningCardsCount = default(int);
		int num3 = default(int);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		bool flag = default(bool);
		while (true)
		{
			int num = 1973987610;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F85E0CDu) % 29u)
				{
				case 28u:
					num = ((int)num2 * -1829053734) ^ -462935127;
					continue;
				case 27u:
					num = 1774852891;
					continue;
				case 26u:
					flag2 = num6 < Players.Length;
					num = 709361163;
					continue;
				case 25u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = 92153543;
					continue;
				case 24u:
				{
					int num11;
					if (num3 > 0)
					{
						num = 353753576;
						num11 = 353753576;
					}
					else
					{
						num = 745888076;
						num11 = 745888076;
					}
					continue;
				}
				case 23u:
				{
					int num7;
					int num8;
					if (useOneMorePlanningSprint)
					{
						num7 = -283387899;
						num8 = -283387899;
					}
					else
					{
						num7 = -718323216;
						num8 = -718323216;
					}
					num = num7 ^ (int)(num2 * 1765144306);
					continue;
				}
				case 22u:
					playerState.State = State.Playing;
					num = (int)((num2 * 2095351768) ^ 0x70C73BCE);
					continue;
				case 21u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = (int)(num2 * 1156094565) ^ -1973303408;
					continue;
				case 20u:
					num6++;
					num = (int)(num2 * 208853477) ^ -225390765;
					continue;
				case 19u:
					num3 = 0;
					num = 1853218755;
					continue;
				case 18u:
					num = 630960910;
					continue;
				case 17u:
					num = (int)(num2 * 787297712) ^ -1782853487;
					continue;
				case 16u:
					num6 = 0;
					num = ((int)num2 * -926772530) ^ -1880892282;
					continue;
				case 15u:
					playerState.Sprint = 1;
					num = ((int)num2 * -2147209703) ^ -314986690;
					continue;
				case 14u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1037668536;
						num10 = 1037668536;
					}
					else
					{
						num9 = 2036056691;
						num10 = 2036056691;
					}
					num = num9 ^ ((int)num2 * -1724933554);
					continue;
				}
				case 13u:
					planningCardsCount = player.PlanningCardsCount;
					num = (int)(num2 * 338186124) ^ -568030883;
					continue;
				case 11u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -367723408) ^ -1542926962;
					continue;
				case 10u:
					player = Players[num6];
					playerState = _playerStates[num6];
					num = ((int)num2 * -1072022196) ^ 0xBA60191;
					continue;
				case 9u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = (int)((num2 * 972868463) ^ 0x2D66F90);
					continue;
				case 8u:
					num3 = 0;
					flag = planningCardsCount == 0;
					num = ((int)num2 * -376379874) ^ -1292952888;
					continue;
				case 6u:
					num = 294633013;
					continue;
				case 5u:
					num = (int)(num2 * 853426939) ^ -1436097770;
					continue;
				case 4u:
					num = (int)((num2 * 429902200) ^ 0x2C583023);
					continue;
				case 3u:
					num = (int)(num2 * 1449825062) ^ -1580773527;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 751571593;
						num5 = 751571593;
					}
					else
					{
						num4 = 1778749377;
						num5 = 1778749377;
					}
					num = num4 ^ (int)(num2 * 258279705);
					continue;
				}
				case 1u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					num = (int)((num2 * 53327269) ^ 0x79B7245B);
					continue;
				case 0u:
					playerState.Sprint = -1;
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)(num2 * 885608175) ^ -1488285894;
					continue;
				default:
					return;
				case 7u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 759757347;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D33CF00u) % 16u)
				{
				case 15u:
					_currentPlayer = 0;
					num = (int)(num2 * 150002520) ^ -870886641;
					continue;
				case 14u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1664143043;
						num6 = -1664143043;
					}
					else
					{
						num5 = -899712521;
						num6 = -899712521;
					}
					num = num5 ^ (int)(num2 * 63407973);
					continue;
				}
				case 13u:
					num = (int)((num2 * 143288674) ^ 0x6C11E2B);
					continue;
				case 12u:
					num = (int)(num2 * 43973606) ^ -1457101467;
					continue;
				case 11u:
					num = ((int)num2 * -1003751588) ^ 0x30CAB6AB;
					continue;
				case 10u:
					num = (int)(num2 * 1854531297) ^ -21314238;
					continue;
				case 9u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 1925582063) ^ 0x3526155D);
					continue;
				case 8u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 1467713568;
					continue;
				case 7u:
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -167441654) ^ 0x21D57643;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 251527383;
						num4 = 251527383;
					}
					else
					{
						num3 = 644813638;
						num4 = 644813638;
					}
					num = num3 ^ ((int)num2 * -2068867501);
					continue;
				}
				case 3u:
					_currentPlayer++;
					flag = _currentPlayer >= Players.Length;
					num = (int)(num2 * 1532782311) ^ -531368645;
					continue;
				case 2u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 579368728) ^ -509807892;
					continue;
				case 1u:
					PlayerTurn(_currentPlayer);
					num = 1069758548;
					continue;
				case 0u:
					num = (int)((num2 * 2035429622) ^ 0x2C7DD092);
					continue;
				default:
					return;
				case 6u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		bool flag9 = default(bool);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag2 = default(bool);
		int num3 = default(int);
		PlayerState playerState3 = default(PlayerState);
		int num12 = default(int);
		int num17 = default(int);
		Card card = default(Card);
		bool flag8 = default(bool);
		int num30 = default(int);
		bool flag5 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 835907253;
			while (true)
			{
				uint num2;
				int num19;
				switch ((num2 = (uint)num ^ 0x3260802Bu) % 85u)
				{
				case 84u:
				{
					int num31;
					int num32;
					if (!flag9)
					{
						num31 = -367740230;
						num32 = -367740230;
					}
					else
					{
						num31 = -345567625;
						num32 = -345567625;
					}
					num = num31 ^ (int)(num2 * 2127026401);
					continue;
				}
				case 83u:
					flag7 = !flag6;
					num = (int)(num2 * 2023518247) ^ -13080149;
					continue;
				case 82u:
					flag4 = false;
					num = 1343966093;
					continue;
				case 81u:
					playerState.State = State.Lose;
					num = (int)((num2 * 237392411) ^ 0x4CEE3864);
					continue;
				case 80u:
					num = 329443470;
					continue;
				case 79u:
					num = (int)((num2 * 1056771536) ^ 0x4C6477AE);
					continue;
				case 78u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1028150892;
						num9 = -1028150892;
					}
					else
					{
						num8 = -1534216784;
						num9 = -1534216784;
					}
					num = num8 ^ ((int)num2 * -933262793);
					continue;
				}
				case 77u:
				{
					int num29;
					if (!flag4)
					{
						num = 1371493617;
						num29 = 1371493617;
					}
					else
					{
						num = 1235249993;
						num29 = 1235249993;
					}
					continue;
				}
				case 76u:
					flag2 = num3 < _playerStates.Length;
					num = 1407938798;
					continue;
				case 75u:
					num = (int)((num2 * 136638492) ^ 0x3246299A);
					continue;
				case 74u:
					num = 1836446967;
					continue;
				case 73u:
					num = 551133289;
					continue;
				case 72u:
				{
					int num14;
					if (playerState.Sprint <= Rules.SprintCount)
					{
						num = 1465373772;
						num14 = 1465373772;
					}
					else
					{
						num = 1537377469;
						num14 = 1537377469;
					}
					continue;
				}
				case 71u:
					num = ((int)num2 * -818764368) ^ 0xA8DB36D;
					continue;
				case 70u:
					num = (int)((num2 * 905502776) ^ 0x1A9AE1A9);
					continue;
				case 69u:
				{
					int num6;
					int num7;
					if (!Rules.OnlyOneWinner)
					{
						num6 = 1398440938;
						num7 = 1398440938;
					}
					else
					{
						num6 = 1604403654;
						num7 = 1604403654;
					}
					num = num6 ^ ((int)num2 * -51459999);
					continue;
				}
				case 68u:
					playerState3.State = State.Lose;
					flag9 = !Losers.Contains(num12);
					num = 550110540;
					continue;
				case 67u:
					num = 1781439831;
					continue;
				case 66u:
					num = ((int)num2 * -1562606695) ^ -2124516619;
					continue;
				case 65u:
				{
					int num26;
					int num27;
					if (!flag7)
					{
						num26 = -1974979857;
						num27 = -1974979857;
					}
					else
					{
						num26 = -22379655;
						num27 = -22379655;
					}
					num = num26 ^ (int)(num2 * 633579120);
					continue;
				}
				case 64u:
				{
					int num21;
					int num22;
					if (num3 != playerIndex)
					{
						num21 = 641075860;
						num22 = 641075860;
					}
					else
					{
						num21 = 1574796591;
						num22 = 1574796591;
					}
					num = num21 ^ (int)(num2 * 73499703);
					continue;
				}
				case 63u:
					_finished = true;
					num = (int)((num2 * 342630166) ^ 0x6D16406E);
					continue;
				case 62u:
				{
					int num18;
					if (!Losers.Contains(num3))
					{
						num = 336852676;
						num18 = 336852676;
					}
					else
					{
						num = 860593707;
						num18 = 860593707;
					}
					continue;
				}
				case 61u:
					playerState.Resources -= num17;
					num = (int)((num2 * 940543925) ^ 0x628DC092);
					continue;
				case 60u:
				{
					int num13;
					if (num12 < _playerStates.Length)
					{
						num = 1062762996;
						num13 = 1062762996;
					}
					else
					{
						num = 2086569571;
						num13 = 2086569571;
					}
					continue;
				}
				case 59u:
					num12++;
					num = 151509955;
					continue;
				case 58u:
					num3 = 0;
					num = (int)(num2 * 164960589) ^ -158221062;
					continue;
				case 57u:
					num = (int)(num2 * 149504544) ^ -422526795;
					continue;
				case 56u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag8 ? "ALL " : "", flag6 ? "receives" : "pays", Game.smethod_4(num17), flag4 ? "advance" : "stay");
					num = 163661385;
					continue;
				case 55u:
					num30 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)(num2 * 1200077938) ^ -990013191;
					continue;
				case 54u:
					num = ((int)num2 * -250704284) ^ -525025388;
					continue;
				case 53u:
					playerState.Sprint++;
					num = (int)((num2 * 747475441) ^ 0x13554DB3);
					continue;
				case 52u:
					num = (int)(num2 * 1437762506) ^ -729915969;
					continue;
				case 51u:
					Winners.Add(playerIndex);
					num = (int)((num2 * 1074737058) ^ 0xBBD747A);
					continue;
				case 50u:
					num = 1465373772;
					continue;
				case 49u:
					flag4 = num30 < Rules.StayOnSprintMinDiff;
					num17 = Game.smethod_3(0, num30);
					num = ((int)num2 * -1039172950) ^ 0x22977FAF;
					continue;
				case 48u:
					num = ((int)num2 * -1720702111) ^ -1932033963;
					continue;
				case 47u:
					num = ((int)num2 * -1009463514) ^ -1724373945;
					continue;
				case 46u:
					num12 = 0;
					num = (int)(num2 * 1303966535) ^ -883298797;
					continue;
				case 45u:
					Losers.Add(playerIndex);
					num = (int)(num2 * 1726891501) ^ -722549602;
					continue;
				case 44u:
					num = (int)((num2 * 1970123347) ^ 0x295BCACA);
					continue;
				case 43u:
					num = ((int)num2 * -1562266761) ^ 0x696052B9;
					continue;
				case 42u:
					num = ((int)num2 * -1211332875) ^ 0x19E94801;
					continue;
				case 41u:
					flag5 = !flag8;
					num = ((int)num2 * -1176620315) ^ 0x34E74A88;
					continue;
				case 40u:
					num = (int)((num2 * 591539194) ^ 0x562CD8B7);
					continue;
				case 39u:
					Print(playerState.State);
					num = ((int)num2 * -169955336) ^ 0xCD2BA31;
					continue;
				case 38u:
					num19 = ((card.Type == 4) ? 1 : 0);
					goto IL_052a;
				case 37u:
					num = 813867225;
					continue;
				case 36u:
					num = ((int)num2 * -1555797414) ^ 0x74D58E8E;
					continue;
				case 34u:
					num = (int)((num2 * 313792772) ^ 0x1C63FC7A);
					continue;
				case 33u:
					flag = playerState.Resources < 0;
					num = ((int)num2 * -55850433) ^ -670958021;
					continue;
				case 31u:
				{
					playerState3 = _playerStates[num12];
					playerState3.Resources -= Game.smethod_3(0, num17 - Players[num12].PlannedForCard(card.Type));
					int num28;
					if (playerState3.Resources >= 0)
					{
						num = 854946697;
						num28 = 854946697;
					}
					else
					{
						num = 280809652;
						num28 = 280809652;
					}
					continue;
				}
				case 30u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 191411453) ^ 0x6EA76C3A);
					continue;
				case 29u:
					Losers.Add(num12);
					num = ((int)num2 * -1559081588) ^ 0x77312DC2;
					continue;
				case 28u:
					playerState.State = State.Won;
					num = (int)((num2 * 1313708521) ^ 0x51B2215E);
					continue;
				case 27u:
					num3++;
					num = 725282709;
					continue;
				case 26u:
					num = (int)(num2 * 2146884790) ^ -509051990;
					continue;
				case 25u:
				{
					int num25;
					if (!_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = 1291398776;
						num25 = 1291398776;
					}
					else
					{
						num = 1793646169;
						num25 = 1793646169;
					}
					continue;
				}
				case 24u:
					playerState = _playerStates[playerIndex];
					num = (int)((num2 * 1555082213) ^ 0x2C8970F);
					continue;
				case 23u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)(num2 * 263010679) ^ -850229753;
					continue;
				case 22u:
					num = ((int)num2 * -130454875) ^ 0x113B37DC;
					continue;
				case 21u:
					num = (int)((num2 * 1033757009) ^ 0x56278831);
					continue;
				case 20u:
					num17 = card.Impact;
					num = (int)((num2 * 1758365201) ^ 0x2169DD6E);
					continue;
				case 19u:
				{
					int num23;
					int num24;
					if (playerState.State == State.Playing)
					{
						num23 = 223103121;
						num24 = 223103121;
					}
					else
					{
						num23 = 1338678769;
						num24 = 1338678769;
					}
					num = num23 ^ (int)(num2 * 1218504788);
					continue;
				}
				case 18u:
					flag4 = true;
					num = (int)(num2 * 1063248586) ^ -978966328;
					continue;
				case 17u:
					num = (int)(num2 * 1945928205) ^ -1885069647;
					continue;
				case 16u:
				{
					int num20;
					if (playerState.Sprint < 0)
					{
						num = 538374420;
						num20 = 538374420;
					}
					else
					{
						num = 1837653612;
						num20 = 1837653612;
					}
					continue;
				}
				case 15u:
					flag6 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 748755796) ^ 0x4A59B543);
						continue;
					}
					num19 = 0;
					goto IL_052a;
				case 14u:
					num = 3144820;
					continue;
				case 13u:
					Print("CARD: none, advance");
					num = ((int)num2 * -1429337845) ^ -150788245;
					continue;
				case 12u:
					num = (int)(num2 * 1410373883) ^ -390377870;
					continue;
				case 11u:
					num = ((int)num2 * -1293259942) ^ -651465829;
					continue;
				case 10u:
				{
					int num15;
					int num16;
					if (!flag5)
					{
						num15 = -1387622813;
						num16 = -1387622813;
					}
					else
					{
						num15 = -600862367;
						num16 = -600862367;
					}
					num = num15 ^ (int)(num2 * 1259902627);
					continue;
				}
				case 9u:
					num = 279276364;
					continue;
				case 8u:
					flag4 = true;
					num = (int)((num2 * 1472638941) ^ 0x7D512DBC);
					continue;
				case 7u:
					num = 978258282;
					continue;
				case 6u:
					num = ((int)num2 * -1270232354) ^ -367431027;
					continue;
				case 5u:
					flag3 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1269382784) ^ 0x7257604D;
					continue;
				case 4u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = -1413981198;
						num11 = -1413981198;
					}
					else
					{
						num10 = -2146130679;
						num11 = -2146130679;
					}
					num = num10 ^ (int)(num2 * 763753186);
					continue;
				}
				case 3u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = 1140484696;
					continue;
				}
				case 2u:
					card = DrawCard();
					num = ((int)num2 * -985309753) ^ -1737849849;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1389367766;
						num5 = 1389367766;
					}
					else
					{
						num4 = 963510397;
						num5 = 963510397;
					}
					num = num4 ^ ((int)num2 * -63131884);
					continue;
				}
				case 0u:
					Losers.Add(num3);
					num = ((int)num2 * -1300315763) ^ -1119539706;
					continue;
				default:
					return;
				case 32u:
					break;
				case 35u:
					return;
					IL_052a:
					flag8 = (byte)num19 != 0;
					num = 1773195777;
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
			int num = -287633710;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6CDEA55u) % 9u)
				{
				case 8u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 880393573;
						num4 = 880393573;
					}
					else
					{
						num3 = 2061428778;
						num4 = 2061428778;
					}
					num = num3 ^ ((int)num2 * -433439736);
					continue;
				}
				case 7u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 1160028545) ^ 0x28CB4B53);
					continue;
				case 5u:
					num = (int)((num2 * 1464819244) ^ 0x490BA465);
					continue;
				case 3u:
					card = _deck[0];
					num = -838558810;
					continue;
				case 2u:
					result = card;
					num = (int)((num2 * 510839779) ^ 0x1967F989);
					continue;
				case 1u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -1126757245) ^ -1898118326;
					continue;
				case 0u:
					ShuffleCards();
					num = (int)((num2 * 2008287111) ^ 0x55978BDA);
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

	public string ToString(bool initial)
	{
		bool flag = default(bool);
		int num3 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1921578158;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x98E8D5BFu) % 11u)
				{
				case 10u:
					flag = num3 < _playerStates.Length;
					num = -203841867;
					continue;
				case 9u:
					num = (int)(num2 * 847276564) ^ -102897590;
					continue;
				case 8u:
					text = "";
					num = ((int)num2 * -1684176681) ^ -566478157;
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
					num = -173987720;
					continue;
				}
				case 5u:
					result = text;
					num = (int)(num2 * 254711283) ^ -1467211709;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -140113388) ^ 0x6592919E;
					continue;
				case 2u:
					num = (int)(num2 * 360926365) ^ -2083328937;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 303736192;
						num5 = 303736192;
					}
					else
					{
						num4 = 1211330494;
						num5 = 1211330494;
					}
					num = num4 ^ (int)(num2 * 988935450);
					continue;
				}
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1086427830) ^ 0x5F709E27;
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

	public override string ToString()
	{
		return ToString(initial: false);
	}

	private void Print(object text, params object[] more)
	{
		string string_ = Game.smethod_7(Game.smethod_5(text), more);
		while (true)
		{
			int num = -122657697;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85BA9AB5u) % 3u)
				{
				case 2u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000f:
				Game.smethod_8(_buffer, string_);
				num = ((int)num2 * -1370886738) ^ 0x1F6CA1C5;
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
