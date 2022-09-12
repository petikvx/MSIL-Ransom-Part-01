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
			int num5 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			bool result = default(bool);
			bool flag = default(bool);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = 210575004;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4355AC32u) % 17u)
					{
					case 16u:
						num = 145846908;
						continue;
					case 15u:
						num = ((int)num2 * -465703689) ^ -234220234;
						continue;
					case 14u:
						num = (int)(num2 * 1664179334) ^ -1195557656;
						continue;
					case 13u:
						num = (int)((num2 * 23267804) ^ 0x9042004);
						continue;
					case 11u:
					{
						int num6;
						if (num5 < playerStates.Length)
						{
							num = 145796550;
							num6 = 145796550;
						}
						else
						{
							num = 1711264160;
							num6 = 1711264160;
						}
						continue;
					}
					case 10u:
						result = false;
						num = (int)(num2 * 947930729) ^ -1977342874;
						continue;
					case 9u:
						num5++;
						num = 1834991550;
						continue;
					case 8u:
						playerStates = _playerStates;
						num5 = 0;
						num = (int)(num2 * 1769658270) ^ -1379191378;
						continue;
					case 7u:
						num = (int)(num2 * 1440996026) ^ -1479101242;
						continue;
					case 6u:
					{
						int num7;
						int num8;
						if (!flag)
						{
							num7 = 1542686992;
							num8 = 1542686992;
						}
						else
						{
							num7 = 1935103929;
							num8 = 1935103929;
						}
						num = num7 ^ (int)(num2 * 991082614);
						continue;
					}
					case 5u:
						playerState = playerStates[num5];
						num = 780443583;
						continue;
					case 3u:
						result = true;
						num = (int)((num2 * 1925807940) ^ 0x718603BC);
						continue;
					case 2u:
						result = true;
						num = (int)(num2 * 1896405437) ^ -649705107;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!_finished)
						{
							num3 = 263840942;
							num4 = 263840942;
						}
						else
						{
							num3 = 1407457075;
							num4 = 1407457075;
						}
						num = num3 ^ (int)(num2 * 1901208950);
						continue;
					}
					case 0u:
						flag = playerState.State == State.Playing;
						num = ((int)num2 * -976665165) ^ 0x5756FCB8;
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
			int num = -815106360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA1DB83Eu) % 9u)
				{
				case 8u:
					_currentTurn = 0;
					_finished = false;
					num = (int)((num2 * 1945339727) ^ 0x80609E3);
					continue;
				case 6u:
					_currentChanceIndex = -1;
					num = (int)(num2 * 1052742747) ^ -1521443503;
					continue;
				case 5u:
					Winners.Clear();
					num = (int)((num2 * 1252694262) ^ 0x6AE3B3AF);
					continue;
				case 4u:
					Losers.Clear();
					num = ((int)num2 * -1231749181) ^ -1971220737;
					continue;
				case 2u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1400179138) ^ -486243855;
					continue;
				case 1u:
					num = ((int)num2 * -1931935269) ^ 0x73288902;
					continue;
				case 0u:
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -2075201307) ^ 0x2AE5F611;
					continue;
				default:
					return;
				case 7u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		PlayerState playerState = default(PlayerState);
		bool useOneMorePlanningSprint = default(bool);
		bool flag2 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		Player player = default(Player);
		bool flag = default(bool);
		int planningCardsCount = default(int);
		while (true)
		{
			int num = 1084830432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29F574B9u) % 30u)
				{
				case 29u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					num = ((int)num2 * -83898247) ^ 0x4B6F9306;
					continue;
				case 28u:
				{
					int num11;
					int num12;
					if (!useOneMorePlanningSprint)
					{
						num11 = 2095684556;
						num12 = 2095684556;
					}
					else
					{
						num11 = 1229412719;
						num12 = 1229412719;
					}
					num = num11 ^ (int)(num2 * 1458208843);
					continue;
				}
				case 27u:
					flag2 = num4 > 0;
					num = 426115485;
					continue;
				case 26u:
					playerState = _playerStates[num3];
					num = (int)(num2 * 2081757675) ^ -1376029976;
					continue;
				case 25u:
					num = 635790346;
					continue;
				case 24u:
					playerState.Sprint = 1;
					num = (int)(num2 * 791715565) ^ -194605543;
					continue;
				case 22u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -1248811414) ^ 0x7F67654F;
					continue;
				case 20u:
					num = (int)((num2 * 1819180461) ^ 0x408DC14A);
					continue;
				case 19u:
					num = ((int)num2 * -1374810088) ^ 0x6316A2B0;
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 570119619;
						num10 = 570119619;
					}
					else
					{
						num9 = 1904414490;
						num10 = 1904414490;
					}
					num = num9 ^ ((int)num2 * -1811314921);
					continue;
				}
				case 17u:
					num4 = 0;
					num = 1263832184;
					continue;
				case 16u:
					flag = num3 < Players.Length;
					num = 1416885356;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -1572146784;
						num8 = -1572146784;
					}
					else
					{
						num7 = -1585436644;
						num8 = -1585436644;
					}
					num = num7 ^ (int)(num2 * 759866908);
					continue;
				}
				case 14u:
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num = (int)((num2 * 2094192809) ^ 0x18F1DD55);
					continue;
				case 13u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num = 443652364;
					continue;
				case 12u:
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					num = ((int)num2 * -1082518636) ^ 0x3385A79B;
					continue;
				case 11u:
					num3 = 0;
					num = (int)(num2 * 41597434) ^ -408825485;
					continue;
				case 10u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num = ((int)num2 * -1652332893) ^ 0x2D83F2D8;
					continue;
				case 9u:
					player = Players[num3];
					num = (int)((num2 * 967269509) ^ 0x682408F2);
					continue;
				case 8u:
					playerState.Sprint = -1;
					num = (int)((num2 * 1822903974) ^ 0x324B9A07);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (planningCardsCount == 0)
					{
						num5 = -1636559506;
						num6 = -1636559506;
					}
					else
					{
						num5 = -618640119;
						num6 = -618640119;
					}
					num = num5 ^ ((int)num2 * -1047544975);
					continue;
				}
				case 6u:
					num = ((int)num2 * -92199658) ^ 0x3EF5DE6;
					continue;
				case 5u:
					num = 741320292;
					continue;
				case 4u:
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num4 = 0;
					num = ((int)num2 * -1041648827) ^ 0x64E5BC9C;
					continue;
				case 3u:
					num = 268254153;
					continue;
				case 2u:
					num = ((int)num2 * -463635629) ^ 0xFD78B49;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -542061381) ^ -1213175778;
					continue;
				case 0u:
					num = ((int)num2 * -1776818594) ^ 0x3F09605D;
					continue;
				default:
					return;
				case 21u:
					break;
				case 23u:
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
			int num = 1777562020;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6625C322u) % 11u)
				{
				case 9u:
					num = ((int)num2 * -1023249672) ^ 0x1D2AF4D7;
					continue;
				case 8u:
				{
					_currentPlayer = 0;
					int num5;
					int num6;
					if (_currentTurn <= 0)
					{
						num5 = 1025068692;
						num6 = 1025068692;
					}
					else
					{
						num5 = 1099302016;
						num6 = 1099302016;
					}
					num = num5 ^ ((int)num2 * -726247736);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (_currentPlayer < Players.Length)
					{
						num3 = 605142602;
						num4 = 605142602;
					}
					else
					{
						num3 = 13610566;
						num4 = 13610566;
					}
					num = num3 ^ ((int)num2 * -1936728723);
					continue;
				}
				case 6u:
					num = ((int)num2 * -703499705) ^ -1449633390;
					continue;
				case 4u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1105108752) ^ 0x336025B8;
					continue;
				case 3u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 235646096) ^ -1144567234;
					continue;
				case 2u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 1631166296;
					continue;
				case 1u:
					PlayerTurn(_currentPlayer);
					num = 471411587;
					continue;
				case 0u:
					num = (int)((num2 * 438665725) ^ 0x73245BC5);
					continue;
				default:
					return;
				case 10u:
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
		bool flag3 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag = default(bool);
		bool flag12 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		int num19 = default(int);
		int num13 = default(int);
		Card card = default(Card);
		bool flag13 = default(bool);
		bool flag6 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		int num14 = default(int);
		bool flag10 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag4 = default(bool);
		bool flag8 = default(bool);
		bool flag15 = default(bool);
		bool flag16 = default(bool);
		bool flag2 = default(bool);
		bool flag14 = default(bool);
		bool flag9 = default(bool);
		Player player = default(Player);
		bool flag11 = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 73174527;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0x12BE51EBu) % 89u)
				{
				case 88u:
					flag3 = playerState.Sprint > Rules.SprintCount;
					num = 150230848;
					continue;
				case 87u:
					num = ((int)num2 * -1623797927) ^ 0x4EECE477;
					continue;
				case 86u:
					flag = false;
					num = 632493926;
					continue;
				case 85u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -86601368;
						num8 = -86601368;
					}
					else
					{
						num7 = -1298667342;
						num8 = -1298667342;
					}
					num = num7 ^ ((int)num2 * -1280921133);
					continue;
				}
				case 84u:
					playerState.State = State.Lose;
					num = ((int)num2 * -1364649331) ^ -1944624815;
					continue;
				case 83u:
				{
					int num36;
					int num37;
					if (flag12)
					{
						num36 = 2144433329;
						num37 = 2144433329;
					}
					else
					{
						num36 = 909670142;
						num37 = 909670142;
					}
					num = num36 ^ ((int)num2 * -1020363774);
					continue;
				}
				case 82u:
					num = (int)((num2 * 1516017059) ^ 0x441975D2);
					continue;
				case 81u:
					playerState2 = _playerStates[num19];
					playerState2.Resources -= Game.smethod_3(0, num13 - Players[num19].PlannedForCard(card.Type));
					num = (int)(num2 * 50415828) ^ -1109932183;
					continue;
				case 80u:
					num = ((int)num2 * -1004696669) ^ -2101736185;
					continue;
				case 79u:
				{
					int num34;
					int num35;
					if (flag13)
					{
						num34 = -656930369;
						num35 = -656930369;
					}
					else
					{
						num34 = -1104071092;
						num35 = -1104071092;
					}
					num = num34 ^ (int)(num2 * 356420175);
					continue;
				}
				case 78u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag6 ? "ALL " : "", flag7 ? "receives" : "pays", Game.smethod_4(num13), flag ? "advance" : "stay");
					num = 416535059;
					continue;
				case 77u:
					num = 1995655650;
					continue;
				case 76u:
				{
					int num31;
					if (_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = 1690098156;
						num31 = 1690098156;
					}
					else
					{
						num = 1401501218;
						num31 = 1401501218;
					}
					continue;
				}
				case 75u:
					num19 = 0;
					num = (int)(num2 * 1733788245) ^ -322781616;
					continue;
				case 74u:
					playerState.Resources -= num13;
					num = (int)((num2 * 839076612) ^ 0x637393B9);
					continue;
				case 72u:
					flag5 = !flag7;
					num = ((int)num2 * -791605109) ^ -393852563;
					continue;
				case 71u:
					num = ((int)num2 * -1768746169) ^ -1343430972;
					continue;
				case 70u:
					num = ((int)num2 * -549488285) ^ 0x65520662;
					continue;
				case 69u:
					Losers.Add(num19);
					num = ((int)num2 * -1097421385) ^ -2135279751;
					continue;
				case 68u:
					playerState.Sprint++;
					num = ((int)num2 * -1783805317) ^ 0x4A393FD1;
					continue;
				case 67u:
					Losers.Add(num14);
					num = ((int)num2 * -1303470898) ^ 0x77F8BC14;
					continue;
				case 66u:
					flag10 = playerState.Resources < 0;
					num = (int)(num2 * 375953128) ^ -998962160;
					continue;
				case 65u:
				{
					int num24;
					int num25;
					if (onlyOneWinner)
					{
						num24 = 209252748;
						num25 = 209252748;
					}
					else
					{
						num24 = 204260345;
						num25 = 204260345;
					}
					num = num24 ^ ((int)num2 * -254560364);
					continue;
				}
				case 64u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = (int)(num2 * 695836978) ^ -786514987;
					continue;
				case 63u:
					flag13 = playerState2.Resources >= 0;
					num = (int)(num2 * 1737695042) ^ -1169198648;
					continue;
				case 62u:
					num = (int)((num2 * 1856108058) ^ 0x52232B41);
					continue;
				case 61u:
				{
					int num17;
					int num18;
					if (flag10)
					{
						num17 = -1917583892;
						num18 = -1917583892;
					}
					else
					{
						num17 = -372758447;
						num18 = -372758447;
					}
					num = num17 ^ ((int)num2 * -441911067);
					continue;
				}
				case 60u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -294225619) ^ -1288313840;
					continue;
				case 59u:
					flag4 = playerState.State != State.Playing;
					num = ((int)num2 * -284999468) ^ 0x519D4A90;
					continue;
				case 58u:
					num = 2127120562;
					continue;
				case 57u:
				{
					int num9;
					int num10;
					if (flag4)
					{
						num9 = -1091251612;
						num10 = -1091251612;
					}
					else
					{
						num9 = -1883960721;
						num10 = -1883960721;
					}
					num = num9 ^ ((int)num2 * -817098267);
					continue;
				}
				case 56u:
					num = ((int)num2 * -230069160) ^ 0x3767DC9;
					continue;
				case 55u:
				{
					int num32;
					int num33;
					if (!flag8)
					{
						num32 = 223070167;
						num33 = 223070167;
					}
					else
					{
						num32 = 1820488491;
						num33 = 1820488491;
					}
					num = num32 ^ (int)(num2 * 1924550217);
					continue;
				}
				case 54u:
					num = 220646078;
					continue;
				case 53u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 889830273;
					continue;
				}
				case 52u:
					flag15 = playerState.Sprint < 0;
					num = 53957199;
					continue;
				case 51u:
				{
					int num29;
					int num30;
					if (flag16)
					{
						num29 = -1776240172;
						num30 = -1776240172;
					}
					else
					{
						num29 = -261640848;
						num30 = -261640848;
					}
					num = num29 ^ (int)(num2 * 1675749388);
					continue;
				}
				case 50u:
					flag16 = !Losers.Contains(num19);
					num = (int)(num2 * 807320367) ^ -956734206;
					continue;
				case 49u:
				{
					int num28;
					if (flag)
					{
						num = 1351711715;
						num28 = 1351711715;
					}
					else
					{
						num = 873381385;
						num28 = 873381385;
					}
					continue;
				}
				case 48u:
					flag2 = num14 < _playerStates.Length;
					num = 2032163935;
					continue;
				case 47u:
					num = ((int)num2 * -1111524829) ^ 0x2427B7FD;
					continue;
				case 46u:
					num = ((int)num2 * -1453889851) ^ -502533909;
					continue;
				case 45u:
					num = (int)(num2 * 1050766986) ^ -129644065;
					continue;
				case 44u:
				{
					int num26;
					int num27;
					if (flag15)
					{
						num26 = 499581658;
						num27 = 499581658;
					}
					else
					{
						num26 = 792606327;
						num27 = 792606327;
					}
					num = num26 ^ ((int)num2 * -1773855286);
					continue;
				}
				case 43u:
					num = 1540337803;
					continue;
				case 42u:
					flag14 = num19 < _playerStates.Length;
					num = 927099449;
					continue;
				case 41u:
					Print("CARD: none, advance");
					num = (int)(num2 * 1714329106) ^ -1562170334;
					continue;
				case 40u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -1250899939) ^ -1925777119;
					continue;
				case 39u:
					num = (int)(num2 * 1389716896) ^ -1271906514;
					continue;
				case 38u:
					num = 1472945396;
					continue;
				case 37u:
					_finished = true;
					num14 = 0;
					num = ((int)num2 * -1236163846) ^ 0x4E5B414A;
					continue;
				case 36u:
					num = (int)((num2 * 738216079) ^ 0x12EBE117);
					continue;
				case 35u:
					flag9 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -692427041) ^ 0x2D8C102F;
					continue;
				case 34u:
					Print(playerState.State);
					num = (int)(num2 * 1453960609) ^ -1832101764;
					continue;
				case 33u:
					num = (int)(num2 * 1452292178) ^ -325301379;
					continue;
				case 32u:
					num = (int)(num2 * 457244712) ^ -1884927375;
					continue;
				case 31u:
					playerState.Sprint++;
					num = (int)((num2 * 915719229) ^ 0x11659B5F);
					continue;
				case 30u:
				{
					int num22;
					int num23;
					if (!flag14)
					{
						num22 = -272048556;
						num23 = -272048556;
					}
					else
					{
						num22 = -1496351375;
						num23 = -1496351375;
					}
					num = num22 ^ (int)(num2 * 2124132149);
					continue;
				}
				case 29u:
					num = ((int)num2 * -1419121583) ^ 0x7E026E59;
					continue;
				case 28u:
					flag = true;
					num13 = card.Impact;
					num = (int)(num2 * 193873272) ^ -1497422922;
					continue;
				case 27u:
					Print("Still planning");
					num = (int)((num2 * 2067202751) ^ 0x21B37C1D);
					continue;
				case 26u:
					card = DrawCard();
					num = 1359062183;
					continue;
				case 25u:
					player = Players[playerIndex];
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 632122067) ^ 0x43886C8C);
					continue;
				case 24u:
					num = (int)((num2 * 87695801) ^ 0x4F170432);
					continue;
				case 23u:
					flag7 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -188621175) ^ 0x42D91AC5;
						continue;
					}
					num4 = 0;
					goto IL_07d2;
				case 22u:
				{
					int num20;
					int num21;
					if (!flag11)
					{
						num20 = -841193206;
						num21 = -841193206;
					}
					else
					{
						num20 = -1977300704;
						num21 = -1977300704;
					}
					num = num20 ^ ((int)num2 * -261050789);
					continue;
				}
				case 21u:
					flag12 = !flag6;
					num = (int)(num2 * 1484843580) ^ -415299177;
					continue;
				case 20u:
					num = (int)(num2 * 1480654786) ^ -1331813549;
					continue;
				case 19u:
					num = ((int)num2 * -1426454226) ^ 0x456B1FAA;
					continue;
				case 18u:
					num14++;
					num = 142982250;
					continue;
				case 17u:
					flag11 = num14 == playerIndex;
					num = 176166297;
					continue;
				case 16u:
					num19++;
					num = 363660137;
					continue;
				case 15u:
				{
					int num15;
					int num16;
					if (flag9)
					{
						num15 = 1332570828;
						num16 = 1332570828;
					}
					else
					{
						num15 = 1434918427;
						num16 = 1434918427;
					}
					num = num15 ^ ((int)num2 * -588774957);
					continue;
				}
				case 14u:
					num = 97824270;
					continue;
				case 13u:
					playerState2.State = State.Lose;
					num = 604252720;
					continue;
				case 12u:
					flag = true;
					num = (int)((num2 * 982783504) ^ 0x5FF643E1);
					continue;
				case 11u:
					flag8 = !Losers.Contains(num14);
					num = 178250189;
					continue;
				case 10u:
					num13 = Game.smethod_3(0, num3);
					num = ((int)num2 * -460557196) ^ -276091765;
					continue;
				case 9u:
					num = ((int)num2 * -796534149) ^ -674898666;
					continue;
				case 8u:
				{
					int num11;
					int num12;
					if (flag5)
					{
						num11 = 916652656;
						num12 = 916652656;
					}
					else
					{
						num11 = 174493104;
						num12 = 174493104;
					}
					num = num11 ^ (int)(num2 * 1423587286);
					continue;
				}
				case 7u:
					num = 162186229;
					continue;
				case 6u:
					num = ((int)num2 * -1706086985) ^ 0x1600556B;
					continue;
				case 5u:
					num = 253120835;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -2121500491;
						num6 = -2121500491;
					}
					else
					{
						num5 = -1955992765;
						num6 = -1955992765;
					}
					num = num5 ^ ((int)num2 * -2111010628);
					continue;
				}
				case 2u:
					num4 = ((card.Type == 4) ? 1 : 0);
					goto IL_07d2;
				case 1u:
					num3 = card.Impact - player.PlannedForCard(card.Type);
					flag = num3 < Rules.StayOnSprintMinDiff;
					num = (int)((num2 * 83522173) ^ 0x585A0D52);
					continue;
				case 0u:
					num = ((int)num2 * -148334207) ^ -2057877010;
					continue;
				default:
					return;
				case 4u:
					break;
				case 73u:
					return;
					IL_07d2:
					flag6 = (byte)num4 != 0;
					num = 1543502144;
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
			goto IL_0071;
		}
		goto IL_00c1;
		IL_00c1:
		Card card = _deck[0];
		int num = 1993547853;
		goto IL_008b;
		IL_008b:
		Card result = default(Card);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x406B0784u) % 9u)
			{
			case 8u:
				num = ((int)num2 * -1044689399) ^ 0x243A79D0;
				continue;
			case 7u:
				_deck.RemoveAt(0);
				num = (int)(num2 * 652386049) ^ -1634163918;
				continue;
			case 6u:
				result = card;
				num = (int)(num2 * 1134877336) ^ -1262066357;
				continue;
			case 5u:
				num = (int)((num2 * 1909453345) ^ 0x64D3AA01);
				continue;
			case 4u:
				num = (int)(num2 * 1350608117) ^ -769475588;
				continue;
			case 2u:
				break;
			case 1u:
				ShuffleCards();
				num = ((int)num2 * -1881949254) ^ 0x7C6A1900;
				continue;
			case 3u:
				goto IL_00c1;
			default:
				return result;
			}
			break;
		}
		goto IL_0071;
		IL_0071:
		num = 1090321519;
		goto IL_008b;
	}

	public string ToString(bool initial)
	{
		string text = "";
		int num = 0;
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -1253579028;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xCC1E9BAFu) % 8u)
				{
				case 6u:
					result = text;
					num2 = (int)(num3 * 550250040) ^ -1798378825;
					continue;
				case 5u:
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
					num2 = -1062755043;
					continue;
				}
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 712566094;
						num5 = 712566094;
					}
					else
					{
						num4 = 274118789;
						num5 = 274118789;
					}
					num2 = num4 ^ (int)(num3 * 834181927);
					continue;
				}
				case 3u:
					num2 = ((int)num3 * -1517292985) ^ -1749145533;
					continue;
				case 2u:
					num++;
					num2 = ((int)num3 * -249312731) ^ -696076180;
					continue;
				case 1u:
					flag = num < _playerStates.Length;
					num2 = -1622006293;
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
