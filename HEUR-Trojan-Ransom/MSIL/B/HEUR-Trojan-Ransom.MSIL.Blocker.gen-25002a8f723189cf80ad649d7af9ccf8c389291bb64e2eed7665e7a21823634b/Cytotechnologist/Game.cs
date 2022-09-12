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
			int num5 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			bool result = default(bool);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = 779803835;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B8E269Eu) % 12u)
					{
					case 11u:
						num5++;
						num = 1819918867;
						continue;
					case 10u:
						playerStates = _playerStates;
						num5 = 0;
						num = ((int)num2 * -307921094) ^ -2123670769;
						continue;
					case 9u:
					{
						int num8;
						if (num5 >= playerStates.Length)
						{
							num = 1059294832;
							num8 = 1059294832;
						}
						else
						{
							num = 20900884;
							num8 = 20900884;
						}
						continue;
					}
					case 8u:
						result = false;
						num = (int)((num2 * 368835109) ^ 0x2F4D3E53);
						continue;
					case 7u:
						result = true;
						num = ((int)num2 * -1915804072) ^ -1488840009;
						continue;
					case 6u:
						result = true;
						num = ((int)num2 * -983376777) ^ 0x7A0BE89D;
						continue;
					case 5u:
					{
						int num6;
						int num7;
						if (!finished)
						{
							num6 = -1635928450;
							num7 = -1635928450;
						}
						else
						{
							num6 = -1822435611;
							num7 = -1822435611;
						}
						num = num6 ^ ((int)num2 * -1412870712);
						continue;
					}
					case 4u:
						num = 1243259640;
						continue;
					case 2u:
						playerState = playerStates[num5];
						num = 54586530;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (playerState.State != 0)
						{
							num3 = -997181719;
							num4 = -997181719;
						}
						else
						{
							num3 = -653831134;
							num4 = -653831134;
						}
						num = num3 ^ ((int)num2 * -1159166096);
						continue;
					}
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
		bool flag = default(bool);
		int num4 = default(int);
		int count = default(int);
		bool flag2 = default(bool);
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -420453416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1B2309Du) % 19u)
				{
				case 18u:
					flag = num4 < count;
					num = -200352244;
					continue;
				case 17u:
					flag2 = num3 < count;
					num = -177497806;
					continue;
				case 16u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = -1169838688;
					continue;
				case 15u:
					_playerStates[num4] = new PlayerState();
					num = -1338983213;
					continue;
				case 14u:
					Players = new Player[count];
					num = (int)((num2 * 920393837) ^ 0x2CFE71D6);
					continue;
				case 13u:
					num = ((int)num2 * -453269396) ^ -1220940107;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1792213205;
						num8 = -1792213205;
					}
					else
					{
						num7 = -1970460511;
						num8 = -1970460511;
					}
					num = num7 ^ (int)(num2 * 461680221);
					continue;
				}
				case 11u:
					_buffer = buffer;
					num = (int)((num2 * 1265862359) ^ 0x74F5E2A1);
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1197491559;
						num6 = 1197491559;
					}
					else
					{
						num5 = 1730375674;
						num6 = 1730375674;
					}
					num = num5 ^ (int)(num2 * 1074638674);
					continue;
				}
				case 7u:
					num4++;
					num = ((int)num2 * -773989569) ^ -929517301;
					continue;
				case 6u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					num = (int)((num2 * 1052897885) ^ 0x523EF9E2);
					continue;
				case 5u:
					_playerStates = new PlayerState[count];
					num4 = 0;
					num = ((int)num2 * -315185684) ^ 0x32DA0698;
					continue;
				case 4u:
					count = jSONNode.Count;
					num = ((int)num2 * -1740141024) ^ -1078719081;
					continue;
				case 3u:
					Rules = Rules.Deserialize(json["rules"]);
					num = (int)((num2 * 890533494) ^ 0x795F7BAE);
					continue;
				case 2u:
					_dice = new Dice();
					jSONNode = json["players"];
					num = ((int)num2 * -904746458) ^ -518295619;
					continue;
				case 1u:
					num3 = 0;
					num = (int)((num2 * 2100026983) ^ 0x3C64260A);
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 1825299318) ^ -1770194229;
					continue;
				default:
					return;
				case 10u:
					break;
				case 8u:
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
			int num = 1227696469;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD0E886u) % 7u)
				{
				case 6u:
					_finished = false;
					_currentChanceIndex = -1;
					num = (int)(num2 * 1059772086) ^ -1910149630;
					continue;
				case 5u:
					num = (int)((num2 * 1006389766) ^ 0x6BDF2B7E);
					continue;
				case 3u:
					Winners.Clear();
					num = ((int)num2 * -1258293400) ^ -475785949;
					continue;
				case 2u:
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 3405899) ^ 0xA2188CD);
					continue;
				case 1u:
					Losers.Clear();
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					num = ((int)num2 * -484569901) ^ 0x3CA1FC36;
					continue;
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

	public void PlanningState()
	{
		Player player = default(Player);
		int num4 = default(int);
		bool flag2 = default(bool);
		int num3 = default(int);
		int planningCardsCount = default(int);
		bool flag3 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag = default(bool);
		bool useOneMorePlanningSprint = default(bool);
		while (true)
		{
			int num = 1275147159;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F6882C4u) % 28u)
				{
				case 27u:
					player = Players[num4];
					num = ((int)num2 * -474351059) ^ -1594264936;
					continue;
				case 26u:
					flag2 = num3 > 0;
					num = 747826784;
					continue;
				case 25u:
					num = 673858459;
					continue;
				case 24u:
					planningCardsCount = player.PlanningCardsCount;
					num3 = 0;
					num = ((int)num2 * -1937327288) ^ -382829256;
					continue;
				case 23u:
					flag3 = num4 < Players.Length;
					num = 1976840105;
					continue;
				case 22u:
					num = ((int)num2 * -2108071283) ^ 0x70C7EB94;
					continue;
				case 21u:
					num = ((int)num2 * -1288106150) ^ 0xE2CCE45;
					continue;
				case 19u:
					num = 531113129;
					continue;
				case 18u:
					num = ((int)num2 * -25838961) ^ -319035036;
					continue;
				case 17u:
					playerState.Sprint = 1;
					num = ((int)num2 * -823827561) ^ -241434814;
					continue;
				case 16u:
					playerState.Sprint = -1;
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)((num2 * 130458740) ^ 0x58ADF35E);
					continue;
				case 15u:
					playerState = _playerStates[num4];
					playerState.Sprint = 0;
					num = (int)(num2 * 1138066102) ^ -1098083912;
					continue;
				case 14u:
					playerState.Resources = Rules.InitialResources;
					num = ((int)num2 * -487360844) ^ -1975484455;
					continue;
				case 13u:
				{
					int num11;
					int num12;
					if (!flag3)
					{
						num11 = 1054656517;
						num12 = 1054656517;
					}
					else
					{
						num11 = 1296443056;
						num12 = 1296443056;
					}
					num = num11 ^ (int)(num2 * 224389677);
					continue;
				}
				case 12u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 1735551403;
						num10 = 1735551403;
					}
					else
					{
						num9 = 181430397;
						num10 = 181430397;
					}
					num = num9 ^ (int)(num2 * 34360956);
					continue;
				}
				case 11u:
				{
					int num7;
					int num8;
					if (useOneMorePlanningSprint)
					{
						num7 = 1204470131;
						num8 = 1204470131;
					}
					else
					{
						num7 = 1166554003;
						num8 = 1166554003;
					}
					num = num7 ^ ((int)num2 * -171265549);
					continue;
				}
				case 10u:
					num = ((int)num2 * -1884487736) ^ 0x75216A1C;
					continue;
				case 9u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -1848146492) ^ -396170053;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -760193526;
						num6 = -760193526;
					}
					else
					{
						num5 = -1625826200;
						num6 = -1625826200;
					}
					num = num5 ^ (int)(num2 * 176905752);
					continue;
				}
				case 7u:
					num4 = 0;
					num = ((int)num2 * -829479329) ^ -616776116;
					continue;
				case 6u:
					num = 218152333;
					continue;
				case 5u:
					playerState.State = State.Playing;
					num = ((int)num2 * -1485303866) ^ -1437599594;
					continue;
				case 4u:
					flag = planningCardsCount == 0;
					num = (int)((num2 * 537489549) ^ 0x4F63D09C);
					continue;
				case 2u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = (int)((num2 * 1189976721) ^ 0x51B9F514);
					continue;
				case 1u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num4++;
					num = 1237237511;
					continue;
				case 0u:
					num3 = 0;
					num = 1193753574;
					continue;
				default:
					return;
				case 3u:
					break;
				case 20u:
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
			int num = -1862231791;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6719052u) % 14u)
				{
				case 13u:
					num = ((int)num2 * -164896152) ^ -1782149591;
					continue;
				case 12u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -416267560;
						num6 = -416267560;
					}
					else
					{
						num5 = -1521618836;
						num6 = -1521618836;
					}
					num = num5 ^ ((int)num2 * -1266192970);
					continue;
				}
				case 11u:
					num = ((int)num2 * -1161764139) ^ -281034597;
					continue;
				case 10u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 1407065427) ^ 0x6AB93E2E);
					continue;
				case 9u:
					num = ((int)num2 * -1561152225) ^ 0x75F29EAE;
					continue;
				case 8u:
					PlayerTurn(_currentPlayer);
					num = -1317475643;
					continue;
				case 7u:
					_currentPlayer++;
					num = (int)(num2 * 2056201022) ^ -1834049382;
					continue;
				case 6u:
				{
					_currentPlayer = 0;
					int num3;
					int num4;
					if (_currentTurn > 0)
					{
						num3 = -1046475437;
						num4 = -1046475437;
					}
					else
					{
						num3 = -1196570013;
						num4 = -1196570013;
					}
					num = num3 ^ (int)(num2 * 972487379);
					continue;
				}
				case 5u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = -1423593062;
					continue;
				case 4u:
					num = ((int)num2 * -1510038583) ^ 0x4C6EBF89;
					continue;
				case 3u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -933462612) ^ -2024388645;
					continue;
				case 2u:
					flag = _currentPlayer >= Players.Length;
					num = (int)((num2 * 379183275) ^ 0x134E51CE);
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		PlayerState playerState3 = default(PlayerState);
		int num3 = default(int);
		int num4 = default(int);
		Card card = default(Card);
		bool flag = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		bool flag10 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag12 = default(bool);
		bool flag8 = default(bool);
		int num11 = default(int);
		bool flag5 = default(bool);
		bool flag11 = default(bool);
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		while (true)
		{
			int num = -397429414;
			while (true)
			{
				uint num2;
				int num14;
				switch ((num2 = (uint)num ^ 0xEB4E8D72u) % 84u)
				{
				case 83u:
					Print("CARD: none, advance");
					num = ((int)num2 * -1718315756) ^ -237084358;
					continue;
				case 82u:
					Losers.Add(playerIndex);
					num = (int)(num2 * 734066126) ^ -1531376699;
					continue;
				case 81u:
					playerState3.Resources -= Game.smethod_3(0, num3 - Players[num4].PlannedForCard(card.Type));
					flag = playerState3.Resources >= 0;
					num = (int)(num2 * 299791365) ^ -1930155465;
					continue;
				case 80u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)(num2 * 1208391083) ^ -710081212;
					continue;
				case 79u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 779971143) ^ 0x9208662);
						continue;
					}
					num14 = 0;
					goto IL_00f2;
				case 77u:
					flag3 = flag6;
					num = -188418725;
					continue;
				case 76u:
				{
					int num22;
					int num23;
					if (!flag9)
					{
						num22 = 242125833;
						num23 = 242125833;
					}
					else
					{
						num22 = 1140409627;
						num23 = 1140409627;
					}
					num = num22 ^ (int)(num2 * 150411780);
					continue;
				}
				case 75u:
					num = (int)((num2 * 933861828) ^ 0x66B2B574);
					continue;
				case 74u:
					num = (int)(num2 * 113844315) ^ -105430066;
					continue;
				case 73u:
					num = (int)(num2 * 1201899209) ^ -2103393551;
					continue;
				case 72u:
					num = ((int)num2 * -887706669) ^ -2060828260;
					continue;
				case 71u:
					num = (int)(num2 * 1009822737) ^ -201355421;
					continue;
				case 70u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 673451100;
						num6 = 673451100;
					}
					else
					{
						num5 = 1699496793;
						num6 = 1699496793;
					}
					num = num5 ^ ((int)num2 * -2033192916);
					continue;
				}
				case 69u:
					num = ((int)num2 * -180715373) ^ 0x62183377;
					continue;
				case 68u:
				{
					int num32;
					int num33;
					if (flag10)
					{
						num32 = 1832987749;
						num33 = 1832987749;
					}
					else
					{
						num32 = 643411548;
						num33 = 643411548;
					}
					num = num32 ^ ((int)num2 * -2082984663);
					continue;
				}
				case 67u:
					flag6 = false;
					num = -804271233;
					continue;
				case 66u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -1034547089) ^ -1792187121;
					continue;
				case 65u:
				{
					int num28 = card.Impact - player.PlannedForCard(card.Type);
					flag6 = num28 < Rules.StayOnSprintMinDiff;
					num3 = Game.smethod_3(0, num28);
					num = ((int)num2 * -46208641) ^ 0x49EB77CF;
					continue;
				}
				case 64u:
					num = ((int)num2 * -1449505243) ^ 0x6EC901EF;
					continue;
				case 63u:
					flag12 = !flag8;
					num = (int)((num2 * 1809525829) ^ 0x7BBD28E2);
					continue;
				case 62u:
					Losers.Add(num4);
					num = (int)((num2 * 1961519455) ^ 0x1ACB2B09);
					continue;
				case 61u:
					_finished = true;
					num = (int)(num2 * 1843833558) ^ -1945849496;
					continue;
				case 60u:
				{
					int num21;
					if (!Losers.Contains(num11))
					{
						num = -1857265432;
						num21 = -1857265432;
					}
					else
					{
						num = -1818717585;
						num21 = -1818717585;
					}
					continue;
				}
				case 59u:
					num4 = 0;
					num = (int)(num2 * 1400084591) ^ -779839977;
					continue;
				case 58u:
					num = (int)(num2 * 1079858269) ^ -1501655804;
					continue;
				case 57u:
				{
					int num20;
					if (num4 >= _playerStates.Length)
					{
						num = -1474295906;
						num20 = -1474295906;
					}
					else
					{
						num = -287962858;
						num20 = -287962858;
					}
					continue;
				}
				case 56u:
					num11++;
					num = -1903432419;
					continue;
				case 55u:
					flag9 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -1540584978;
					continue;
				case 54u:
				{
					int num16;
					int num17;
					if (!flag5)
					{
						num16 = 1218271005;
						num17 = 1218271005;
					}
					else
					{
						num16 = 1665041228;
						num17 = 1665041228;
					}
					num = num16 ^ ((int)num2 * -2123873242);
					continue;
				}
				case 53u:
					num = -771535469;
					continue;
				case 52u:
					playerState = _playerStates[playerIndex];
					num = (int)(num2 * 731249451) ^ -1317259032;
					continue;
				case 51u:
				{
					int num9;
					int num10;
					if (onlyOneWinner)
					{
						num9 = 1563671399;
						num10 = 1563671399;
					}
					else
					{
						num9 = 1103214086;
						num10 = 1103214086;
					}
					num = num9 ^ (int)(num2 * 2000312636);
					continue;
				}
				case 50u:
					num = (int)(num2 * 1635716060) ^ -1736772409;
					continue;
				case 49u:
					num = -1983345525;
					continue;
				case 48u:
				{
					int num34;
					int num35;
					if (flag)
					{
						num34 = -489009539;
						num35 = -489009539;
					}
					else
					{
						num34 = -997022632;
						num35 = -997022632;
					}
					num = num34 ^ (int)(num2 * 426668896);
					continue;
				}
				case 47u:
				{
					int num30;
					int num31;
					if (!flag12)
					{
						num30 = 173256207;
						num31 = 173256207;
					}
					else
					{
						num30 = 419901415;
						num31 = 419901415;
					}
					num = num30 ^ (int)(num2 * 341304864);
					continue;
				}
				case 46u:
					playerState3.State = State.Lose;
					flag5 = !Losers.Contains(num4);
					num = -1625099132;
					continue;
				case 45u:
					flag2 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -708469221) ^ 0x6B3680F7;
					continue;
				case 44u:
					num = ((int)num2 * -21909858) ^ 0x2DB8D996;
					continue;
				case 43u:
					num = (int)(num2 * 661780801) ^ -305768503;
					continue;
				case 42u:
					playerState.State = State.Won;
					num = ((int)num2 * -422961583) ^ -559578503;
					continue;
				case 41u:
					num14 = ((card.Type == 4) ? 1 : 0);
					goto IL_00f2;
				case 40u:
					num11 = 0;
					num = (int)(num2 * 1906725690) ^ -1916276427;
					continue;
				case 39u:
					num = (int)(num2 * 795137981) ^ -1689428961;
					continue;
				case 38u:
					Losers.Add(num11);
					num = (int)(num2 * 1611163652) ^ -1812687812;
					continue;
				case 37u:
				{
					int num29;
					if (playerState.Sprint < 0)
					{
						num = -1179936710;
						num29 = -1179936710;
					}
					else
					{
						num = -1108637427;
						num29 = -1108637427;
					}
					continue;
				}
				case 36u:
					num = (int)((num2 * 767811778) ^ 0x71B41BEB);
					continue;
				case 35u:
					num = -79215038;
					continue;
				case 34u:
				{
					int num26;
					int num27;
					if (flag11)
					{
						num26 = -1431120055;
						num27 = -1431120055;
					}
					else
					{
						num26 = -2115190518;
						num27 = -2115190518;
					}
					num = num26 ^ ((int)num2 * -2027556281);
					continue;
				}
				case 33u:
					playerState.Resources -= num3;
					flag11 = playerState.Resources < 0;
					num = ((int)num2 * -1150914571) ^ 0x59C21CC9;
					continue;
				case 32u:
					num = ((int)num2 * -950514997) ^ 0x6D2A8EFB;
					continue;
				case 31u:
					flag10 = num11 < _playerStates.Length;
					num = -813661886;
					continue;
				case 30u:
					flag6 = true;
					num = ((int)num2 * -612893867) ^ -888836669;
					continue;
				case 29u:
					num = ((int)num2 * -1626461587) ^ 0x408ABEE5;
					continue;
				case 28u:
					num = -1870942867;
					continue;
				case 27u:
					num = ((int)num2 * -269756301) ^ -1917490371;
					continue;
				case 26u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -655629439) ^ 0x3AE845AD;
					continue;
				case 25u:
					Winners.Add(playerIndex);
					num = ((int)num2 * -181789807) ^ 0x204D55B4;
					continue;
				case 24u:
				{
					int num24;
					int num25;
					if (!flag4)
					{
						num24 = -224374109;
						num25 = -224374109;
					}
					else
					{
						num24 = -307848271;
						num25 = -307848271;
					}
					num = num24 ^ ((int)num2 * -1850990364);
					continue;
				}
				case 23u:
					card = DrawCard();
					flag8 = card.Impact < 0;
					num = -585343215;
					continue;
				case 22u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag7 ? "ALL " : "", flag8 ? "receives" : "pays", Game.smethod_4(num3), flag6 ? "advance" : "stay");
					num = -294518323;
					continue;
				case 21u:
					num = ((int)num2 * -1943226533) ^ 0x29C77BF6;
					continue;
				case 20u:
					playerState3 = _playerStates[num4];
					num = -1689083625;
					continue;
				case 19u:
				{
					int num18;
					int num19;
					if (flag7)
					{
						num18 = -1138400822;
						num19 = -1138400822;
					}
					else
					{
						num18 = -922657481;
						num19 = -922657481;
					}
					num = num18 ^ (int)(num2 * 2054891700);
					continue;
				}
				case 18u:
					Print(playerState.State);
					num = ((int)num2 * -609857698) ^ 0x9FF2B11;
					continue;
				case 17u:
					flag6 = true;
					num3 = card.Impact;
					num = (int)((num2 * 630561914) ^ 0x737399AF);
					continue;
				case 16u:
				{
					int num15;
					if (playerState.Sprint <= Rules.SprintCount)
					{
						num = -693869576;
						num15 = -693869576;
					}
					else
					{
						num = -478962750;
						num15 = -478962750;
					}
					continue;
				}
				case 15u:
					num = (int)(num2 * 2075939116) ^ -963345287;
					continue;
				case 13u:
					playerState.State = State.Lose;
					num = (int)((num2 * 4610338) ^ 0x5A51DA09);
					continue;
				case 12u:
				{
					int num12;
					int num13;
					if (num11 == playerIndex)
					{
						num12 = -1204523323;
						num13 = -1204523323;
					}
					else
					{
						num12 = -359359878;
						num13 = -359359878;
					}
					num = num12 ^ (int)(num2 * 1458143079);
					continue;
				}
				case 11u:
					num = (int)(num2 * 348993375) ^ -190440428;
					continue;
				case 10u:
					flag4 = playerState.State != State.Playing;
					num = (int)(num2 * 2034736851) ^ -1667720264;
					continue;
				case 9u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 532623740;
						num8 = 532623740;
					}
					else
					{
						num7 = 601684248;
						num8 = 601684248;
					}
					num = num7 ^ (int)(num2 * 1352644518);
					continue;
				}
				case 8u:
					playerState.Sprint++;
					num = ((int)num2 * -669936124) ^ 0x7C47E6EE;
					continue;
				case 7u:
					num4++;
					num = -1926340341;
					continue;
				case 6u:
					num = -1389112246;
					continue;
				case 5u:
					num = ((int)num2 * -1922997448) ^ 0x7E154BD7;
					continue;
				case 4u:
					num = ((int)num2 * -1827253282) ^ 0x5BAA694F;
					continue;
				case 3u:
					num = -1277949691;
					continue;
				case 2u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = -2081166300;
					continue;
				}
				case 1u:
					num = -1855894674;
					continue;
				case 0u:
					num = -693869576;
					continue;
				default:
					return;
				case 14u:
					break;
				case 78u:
					return;
					IL_00f2:
					flag7 = (byte)num14 != 0;
					num = -748356935;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card card = default(Card);
		bool flag = default(bool);
		Card result = default(Card);
		while (true)
		{
			int num = -1431189864;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0826B01u) % 8u)
				{
				case 6u:
					card = _deck[0];
					_deck.RemoveAt(0);
					num = -546564831;
					continue;
				case 5u:
					ShuffleCards();
					num = ((int)num2 * -1900183330) ^ -336282903;
					continue;
				case 3u:
					num = (int)((num2 * 606344780) ^ 0x758C564A);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 313805965;
						num4 = 313805965;
					}
					else
					{
						num3 = 77172702;
						num4 = 77172702;
					}
					num = num3 ^ (int)(num2 * 1834354085);
					continue;
				}
				case 1u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -660576066) ^ -143678187;
					continue;
				case 0u:
					result = card;
					num = ((int)num2 * -1520299227) ^ 0x4BCF15BA;
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
		string text = "";
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 2111491292;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5492EF52u) % 8u)
				{
				case 6u:
					num3 = 0;
					num = (int)((num2 * 1713264447) ^ 0x3A68E202);
					continue;
				case 5u:
					num3++;
					num = (int)(num2 * 195049655) ^ -1605089829;
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
					num = 326905215;
					continue;
				}
				case 2u:
				{
					int num4;
					if (num3 >= _playerStates.Length)
					{
						num = 2042659602;
						num4 = 2042659602;
					}
					else
					{
						num = 1975950926;
						num4 = 1975950926;
					}
					continue;
				}
				case 1u:
					num = (int)((num2 * 2023033220) ^ 0x3DBBC649);
					continue;
				case 0u:
					result = text;
					num = (int)(num2 * 2068164197) ^ -782138285;
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
		string result = ToString(initial: false);
		while (true)
		{
			int num = -599084141;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFDB70089u) % 3u)
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
				num = (int)(num2 * 846312107) ^ -317771172;
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
