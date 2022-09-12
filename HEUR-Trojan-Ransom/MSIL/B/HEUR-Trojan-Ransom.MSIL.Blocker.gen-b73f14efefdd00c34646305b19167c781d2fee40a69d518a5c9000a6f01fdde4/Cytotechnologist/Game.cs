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
			PlayerState playerState = default(PlayerState);
			PlayerState[] playerStates = default(PlayerState[]);
			bool result = default(bool);
			bool finished = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num = 1701701443;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20F14F71u) % 14u)
					{
					case 13u:
						num5++;
						num = 1681328927;
						continue;
					case 12u:
						playerState = playerStates[num5];
						num = 1528461950;
						continue;
					case 11u:
						num = (int)((num2 * 793366567) ^ 0x29509B0A);
						continue;
					case 9u:
						result = true;
						num = ((int)num2 * -69315385) ^ -9842210;
						continue;
					case 7u:
						result = true;
						num = ((int)num2 * -1389708597) ^ -1496935622;
						continue;
					case 6u:
					{
						int num6;
						if (num5 >= playerStates.Length)
						{
							num = 465865564;
							num6 = 465865564;
						}
						else
						{
							num = 1739845973;
							num6 = 1739845973;
						}
						continue;
					}
					case 5u:
						playerStates = _playerStates;
						num5 = 0;
						num = 397166610;
						continue;
					case 4u:
						finished = _finished;
						num = ((int)num2 * -556032818) ^ -624781985;
						continue;
					case 3u:
						result = false;
						num = ((int)num2 * -1552935559) ^ -1139487618;
						continue;
					case 2u:
					{
						int num7;
						int num8;
						if (finished)
						{
							num7 = -352974488;
							num8 = -352974488;
						}
						else
						{
							num7 = -870814220;
							num8 = -870814220;
						}
						num = num7 ^ (int)(num2 * 344197394);
						continue;
					}
					case 1u:
						flag = playerState.State == State.Playing;
						num = (int)((num2 * 1104136473) ^ 0x49EC75CC);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1089994358;
							num4 = 1089994358;
						}
						else
						{
							num3 = 767171018;
							num4 = 767171018;
						}
						num = num3 ^ ((int)num2 * -419835924);
						continue;
					}
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
			int num = 462436087;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31003972u) % 9u)
				{
				case 8u:
					_currentTurn = 0;
					_finished = false;
					num = (int)((num2 * 782494941) ^ 0x6245F1D8);
					continue;
				case 7u:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -491755727) ^ 0x3881ABFC;
					continue;
				case 5u:
					Losers.Clear();
					num = ((int)num2 * -547711914) ^ -1875236722;
					continue;
				case 4u:
					Winners.Clear();
					num = (int)((num2 * 1607223006) ^ 0x74821BE7);
					continue;
				case 3u:
					_currentPlayer = Players.Length;
					num = (int)(num2 * 942685652) ^ -1761914618;
					continue;
				case 1u:
					ShuffleCards();
					num = (int)((num2 * 1222220919) ^ 0x18CB85FE);
					continue;
				case 0u:
					num = (int)((num2 * 586192553) ^ 0x56804948);
					continue;
				default:
					return;
				case 2u:
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
		int num = 0;
		PlayerState playerState = default(PlayerState);
		int num9 = default(int);
		int planningCardsCount = default(int);
		bool flag = default(bool);
		Player player = default(Player);
		bool useOneMorePlanningSprint = default(bool);
		while (true)
		{
			int num2;
			int num3;
			if (num < Players.Length)
			{
				num2 = -801092354;
				num3 = -801092354;
			}
			else
			{
				num2 = -1001957796;
				num3 = -1001957796;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x92F62159u) % 29u)
				{
				case 28u:
					playerState.State = State.Playing;
					num2 = (int)((num4 * 1343421078) ^ 0x4491D013);
					continue;
				case 27u:
					num9 = 0;
					num2 = ((int)num4 * -840359431) ^ -1774491906;
					continue;
				case 26u:
					num9 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = (int)(num4 * 1219765784) ^ -1833620436;
					continue;
				case 25u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -107909397;
						num8 = -107909397;
					}
					else
					{
						num7 = -1726541456;
						num8 = -1726541456;
					}
					num2 = num7 ^ ((int)num4 * -1683013130);
					continue;
				}
				case 24u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = (int)((num4 * 761380756) ^ 0x465B429F);
					continue;
				case 23u:
					num++;
					num2 = ((int)num4 * -1582441667) ^ 0x20135812;
					continue;
				case 22u:
					playerState.Sprint = 1;
					num2 = (int)(num4 * 851675097) ^ -1950260020;
					continue;
				case 21u:
					player = Players[num];
					num2 = (int)((num4 * 569677328) ^ 0x4CF90F46);
					continue;
				case 20u:
					num2 = ((int)num4 * -385107270) ^ -1329912655;
					continue;
				case 19u:
					flag = num9 > 0;
					num2 = -572274010;
					continue;
				case 18u:
				{
					int num10;
					int num11;
					if (useOneMorePlanningSprint)
					{
						num10 = 967240965;
						num11 = 967240965;
					}
					else
					{
						num10 = 1933877317;
						num11 = 1933877317;
					}
					num2 = num10 ^ (int)(num4 * 674609309);
					continue;
				}
				case 17u:
					num2 = (int)(num4 * 1843892020) ^ -2101482231;
					continue;
				case 15u:
					playerState = _playerStates[num];
					num2 = ((int)num4 * -727626202) ^ 0x62932631;
					continue;
				case 14u:
					num2 = (int)((num4 * 1000055401) ^ 0x4432CB1C);
					continue;
				case 13u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num2 = ((int)num4 * -1440105378) ^ 0x569A1BA9;
					continue;
				case 12u:
					playerState.Sprint = 0;
					num2 = ((int)num4 * -2142322038) ^ -469053337;
					continue;
				case 11u:
					num2 = -2091066277;
					continue;
				case 10u:
					playerState.Sprint = -1;
					playerState.Resources -= num9 * Rules.NormalPlanningCost;
					num2 = (int)((num4 * 215509181) ^ 0x31AE1EE);
					continue;
				case 9u:
					num9 = 0;
					num2 = -1573022231;
					continue;
				case 7u:
					num2 = -648414846;
					continue;
				case 6u:
					num2 = -801092354;
					continue;
				case 5u:
					num2 = ((int)num4 * -1265051553) ^ 0x22E07900;
					continue;
				case 4u:
					num2 = -124762263;
					continue;
				case 3u:
					playerState.Resources -= (planningCardsCount - num9) * Rules.NormalPlanningCost;
					num2 = -528638808;
					continue;
				case 2u:
					playerState.Resources = Rules.InitialResources;
					num2 = (int)((num4 * 1787560705) ^ 0x2474D851);
					continue;
				case 1u:
					playerState.Resources -= num9 * Rules.OverPlanningCost;
					num2 = (int)(num4 * 306286300) ^ -1663021083;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (planningCardsCount == 0)
					{
						num5 = 1361703400;
						num6 = 1361703400;
					}
					else
					{
						num5 = 2096771968;
						num6 = 2096771968;
					}
					num2 = num5 ^ (int)(num4 * 1518180);
					continue;
				}
				default:
					return;
				case 8u:
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
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -969840307;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6BDA0C4u) % 12u)
				{
				case 11u:
					flag = _currentPlayer >= Players.Length;
					num = (int)(num2 * 2060026130) ^ -206949442;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -55423699;
						num6 = -55423699;
					}
					else
					{
						num5 = -1404367385;
						num6 = -1404367385;
					}
					num = num5 ^ ((int)num2 * -1923268797);
					continue;
				}
				case 8u:
					PlayerTurn(_currentPlayer);
					num = -2133717586;
					continue;
				case 6u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 333781986) ^ 0x2DF1B6D8);
					continue;
				case 5u:
					_currentPlayer = 0;
					num = (int)((num2 * 1032885155) ^ 0x7D078A55);
					continue;
				case 4u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -1522004485;
					continue;
				case 3u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 761647956) ^ -1496997996;
					continue;
				case 2u:
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -1536875986) ^ -1638593399;
					continue;
				case 1u:
					_currentPlayer++;
					num = ((int)num2 * -1035683207) ^ 0x49C9F796;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -466849664;
						num4 = -466849664;
					}
					else
					{
						num3 = -1109251415;
						num4 = -1109251415;
					}
					num = num3 ^ ((int)num2 * -1841636918);
					continue;
				}
				default:
					return;
				case 7u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		PlayerState playerState = default(PlayerState);
		bool flag9 = default(bool);
		bool flag14 = default(bool);
		bool flag12 = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		int num22 = default(int);
		bool flag13 = default(bool);
		int num29 = default(int);
		PlayerState playerState2 = default(PlayerState);
		bool flag10 = default(bool);
		int num15 = default(int);
		Card card = default(Card);
		int num14 = default(int);
		bool flag4 = default(bool);
		bool flag11 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		bool flag5 = default(bool);
		bool onlyOneWinner = default(bool);
		while (true)
		{
			int num = 216640895;
			while (true)
			{
				uint num2;
				int num13;
				switch ((num2 = (uint)num ^ 0x7B870745u) % 93u)
				{
				case 92u:
					num = (int)((num2 * 1112455622) ^ 0x5130AF9E);
					continue;
				case 91u:
					num = (int)((num2 * 1793636973) ^ 0x7988845);
					continue;
				case 90u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)((num2 * 1333383842) ^ 0x6EB9D09A);
					continue;
				case 89u:
					num = ((int)num2 * -692972608) ^ -479663462;
					continue;
				case 88u:
					flag9 = !Losers.Contains(playerIndex);
					num = (int)((num2 * 1898749501) ^ 0x610273F4);
					continue;
				case 87u:
					num = 584937390;
					continue;
				case 86u:
					num = (int)((num2 * 1814619164) ^ 0x4EA72855);
					continue;
				case 85u:
				{
					int num31;
					int num32;
					if (!flag14)
					{
						num31 = -1139352177;
						num32 = -1139352177;
					}
					else
					{
						num31 = -267972398;
						num32 = -267972398;
					}
					num = num31 ^ ((int)num2 * -777549737);
					continue;
				}
				case 83u:
				{
					int num20;
					int num21;
					if (!flag12)
					{
						num20 = -866178287;
						num21 = -866178287;
					}
					else
					{
						num20 = -878251435;
						num21 = -878251435;
					}
					num = num20 ^ ((int)num2 * -1145085928);
					continue;
				}
				case 82u:
					num = ((int)num2 * -1643947977) ^ 0x218CEABE;
					continue;
				case 81u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 735928624;
						num8 = 735928624;
					}
					else
					{
						num7 = 1661861543;
						num8 = 1661861543;
					}
					num = num7 ^ ((int)num2 * -1602011118);
					continue;
				}
				case 80u:
					num = 1812242548;
					continue;
				case 79u:
					flag3 = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -577900493) ^ 0x6163393A;
					continue;
				case 78u:
					num = ((int)num2 * -2062263646) ^ 0x422D795A;
					continue;
				case 77u:
					flag = playerState.Sprint > Rules.SprintCount;
					num = 2145718684;
					continue;
				case 76u:
					flag3 = num22 < Rules.StayOnSprintMinDiff;
					num = (int)((num2 * 682781377) ^ 0x2AC85147);
					continue;
				case 75u:
					num = (int)((num2 * 1407688199) ^ 0x427D719F);
					continue;
				case 74u:
					num = 582373324;
					continue;
				case 73u:
				{
					int num27;
					int num28;
					if (flag13)
					{
						num27 = -1037799565;
						num28 = -1037799565;
					}
					else
					{
						num27 = -842498770;
						num28 = -842498770;
					}
					num = num27 ^ ((int)num2 * -787472724);
					continue;
				}
				case 72u:
					num = (int)(num2 * 1483999980) ^ -1064150846;
					continue;
				case 71u:
					num29 = 0;
					num = ((int)num2 * -724088923) ^ 0x38A0013E;
					continue;
				case 70u:
					playerState = _playerStates[playerIndex];
					num = (int)((num2 * 309346210) ^ 0x22CEC59A);
					continue;
				case 69u:
					flag13 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 1870713051;
					continue;
				case 68u:
					flag14 = playerState2.Resources >= 0;
					num = ((int)num2 * -1838135320) ^ 0x52DBE9DE;
					continue;
				case 67u:
					_finished = true;
					num = ((int)num2 * -2135467803) ^ 0x74C0561A;
					continue;
				case 66u:
					flag12 = playerState.Sprint < 0;
					num = 1467768734;
					continue;
				case 65u:
					num = 1706365116;
					continue;
				case 64u:
					playerState.State = State.Won;
					num = ((int)num2 * -1374733652) ^ 0x28A8A8E7;
					continue;
				case 63u:
					Winners.Add(playerIndex);
					num = ((int)num2 * -378775171) ^ -49501378;
					continue;
				case 62u:
					flag10 = !Losers.Contains(num15);
					num = (int)((num2 * 126496112) ^ 0x28D5627A);
					continue;
				case 61u:
					num13 = ((card.Type == 4) ? 1 : 0);
					goto IL_0345;
				case 60u:
				{
					int num18;
					int num19;
					if (flag10)
					{
						num18 = -1883730909;
						num19 = -1883730909;
					}
					else
					{
						num18 = -1897606817;
						num19 = -1897606817;
					}
					num = num18 ^ ((int)num2 * -31774885);
					continue;
				}
				case 59u:
					num14 = card.Impact;
					num = ((int)num2 * -193427418) ^ 0x28210E98;
					continue;
				case 58u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = -1138172867;
						num12 = -1138172867;
					}
					else
					{
						num11 = -1949875657;
						num12 = -1949875657;
					}
					num = num11 ^ ((int)num2 * -1541340382);
					continue;
				}
				case 57u:
					flag3 = true;
					num = (int)((num2 * 162295960) ^ 0x117E20C2);
					continue;
				case 56u:
				{
					int num5;
					int num6;
					if (playerState.Resources < 0)
					{
						num5 = -1513608173;
						num6 = -1513608173;
					}
					else
					{
						num5 = -1701204020;
						num6 = -1701204020;
					}
					num = num5 ^ (int)(num2 * 1712356889);
					continue;
				}
				case 55u:
					num = ((int)num2 * -1791316764) ^ 0x1F5B476C;
					continue;
				case 54u:
					flag2 = playerState.State != State.Playing;
					num = (int)((num2 * 1274560828) ^ 0x617F1F4C);
					continue;
				case 53u:
					playerState2.Resources -= Game.smethod_3(0, num14 - Players[num15].PlannedForCard(card.Type));
					num = (int)(num2 * 1192084381) ^ -1492724237;
					continue;
				case 52u:
				{
					int num36;
					if (!flag3)
					{
						num = 139718368;
						num36 = 139718368;
					}
					else
					{
						num = 2050177340;
						num36 = 2050177340;
					}
					continue;
				}
				case 51u:
					num = ((int)num2 * -120826848) ^ -2049573902;
					continue;
				case 50u:
					flag3 = false;
					num = 321015097;
					continue;
				case 49u:
					num = 1528558719;
					continue;
				case 48u:
					Print(playerState.State);
					num = (int)((num2 * 1945293235) ^ 0x17B473D9);
					continue;
				case 47u:
					playerState2 = _playerStates[num15];
					num = ((int)num2 * -920631292) ^ 0x1A8B8158;
					continue;
				case 46u:
					num = ((int)num2 * -1958290730) ^ 0x620F1B3B;
					continue;
				case 45u:
					Losers.Add(num29);
					num = (int)((num2 * 223670618) ^ 0x75138BE);
					continue;
				case 44u:
					num = (int)(num2 * 1903957203) ^ -409757345;
					continue;
				case 43u:
					num = (int)(num2 * 168065225) ^ -431404352;
					continue;
				case 42u:
				{
					int num35;
					if (num15 >= _playerStates.Length)
					{
						num = 539725072;
						num35 = 539725072;
					}
					else
					{
						num = 1187588446;
						num35 = 1187588446;
					}
					continue;
				}
				case 41u:
					num = ((int)num2 * -1491285724) ^ -1688272874;
					continue;
				case 40u:
					num = ((int)num2 * -954796059) ^ -1561653869;
					continue;
				case 39u:
					num15 = 0;
					num = 1882395893;
					continue;
				case 38u:
				{
					int num33;
					int num34;
					if (!flag11)
					{
						num33 = -1841769435;
						num34 = -1841769435;
					}
					else
					{
						num33 = -642087213;
						num34 = -642087213;
					}
					num = num33 ^ (int)(num2 * 1415481152);
					continue;
				}
				case 37u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 1534141665) ^ 0x416462A1);
					continue;
				case 36u:
					num15++;
					num = 395067034;
					continue;
				case 35u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -433788487) ^ -2069661156;
					continue;
				case 34u:
					flag8 = !Losers.Contains(num29);
					num = 1446380864;
					continue;
				case 33u:
					num22 = card.Impact - player.PlannedForCard(card.Type);
					num = ((int)num2 * -1518474608) ^ -1272446105;
					continue;
				case 32u:
					num = ((int)num2 * -122509178) ^ 0x7EE9DF8A;
					continue;
				case 31u:
					card = DrawCard();
					num = ((int)num2 * -1587073039) ^ 0x359E09B;
					continue;
				case 30u:
				{
					int num30;
					if (num29 == playerIndex)
					{
						num = 989267097;
						num30 = 989267097;
					}
					else
					{
						num = 1614171910;
						num30 = 1614171910;
					}
					continue;
				}
				case 29u:
					num = (int)(num2 * 1867453218) ^ -180972472;
					continue;
				case 28u:
					num = (int)((num2 * 1035376350) ^ 0x5B8CC793);
					continue;
				case 27u:
					num = (int)(num2 * 19542725) ^ -681381349;
					continue;
				case 26u:
					playerState.State = State.Lose;
					num = ((int)num2 * -1074317900) ^ -2137960469;
					continue;
				case 24u:
					playerState.Resources -= num14;
					num = (int)((num2 * 441608478) ^ 0x5355CCCC);
					continue;
				case 23u:
					num29++;
					num = 1771910714;
					continue;
				case 22u:
					flag4 = num29 < _playerStates.Length;
					num = 675068813;
					continue;
				case 21u:
					num = (int)((num2 * 554483985) ^ 0x5ABEE1AD);
					continue;
				case 20u:
				{
					int num25;
					int num26;
					if (!flag9)
					{
						num25 = -377848313;
						num26 = -377848313;
					}
					else
					{
						num25 = -769804034;
						num26 = -769804034;
					}
					num = num25 ^ (int)(num2 * 909840249);
					continue;
				}
				case 19u:
				{
					int num23;
					int num24;
					if (flag7)
					{
						num23 = 879969300;
						num24 = 879969300;
					}
					else
					{
						num23 = 1201792980;
						num24 = 1201792980;
					}
					num = num23 ^ ((int)num2 * -787304316);
					continue;
				}
				case 18u:
					num14 = Game.smethod_3(0, num22);
					num = (int)((num2 * 267551820) ^ 0x46B48087);
					continue;
				case 17u:
					num = ((int)num2 * -288360946) ^ 0x7E798A68;
					continue;
				case 16u:
					num = 1906662659;
					continue;
				case 15u:
					num = ((int)num2 * -1770493102) ^ -1325102005;
					continue;
				case 14u:
					num = (int)((num2 * 7724448) ^ 0xE4457E6);
					continue;
				case 13u:
					num = ((int)num2 * -683829167) ^ -1216372516;
					continue;
				case 12u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag6 ? "ALL " : "", flag5 ? "receives" : "pays", Game.smethod_4(num14), flag3 ? "advance" : "stay");
					num = 1332608582;
					continue;
				case 11u:
					num = 1114939130;
					continue;
				case 10u:
				{
					int num16;
					int num17;
					if (!flag8)
					{
						num16 = 1858202087;
						num17 = 1858202087;
					}
					else
					{
						num16 = 40635871;
						num17 = 40635871;
					}
					num = num16 ^ ((int)num2 * -1484021289);
					continue;
				}
				case 9u:
					Losers.Add(num15);
					num = (int)((num2 * 1322026901) ^ 0x1D079E65);
					continue;
				case 8u:
					num = 697298974;
					continue;
				case 7u:
					flag7 = !flag6;
					num = ((int)num2 * -1688546788) ^ -2060556038;
					continue;
				case 6u:
					flag5 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 1768664479) ^ 0x6920E86B);
						continue;
					}
					num13 = 0;
					goto IL_0345;
				case 5u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 1783121030;
					continue;
				}
				case 4u:
					playerState2.State = State.Lose;
					num = 556578016;
					continue;
				case 3u:
				{
					int num9;
					int num10;
					if (!onlyOneWinner)
					{
						num9 = 1191047204;
						num10 = 1191047204;
					}
					else
					{
						num9 = 1074205439;
						num10 = 1074205439;
					}
					num = num9 ^ ((int)num2 * -1587106444);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1702985669;
						num4 = 1702985669;
					}
					else
					{
						num3 = 830202522;
						num4 = 830202522;
					}
					num = num3 ^ (int)(num2 * 777748195);
					continue;
				}
				case 1u:
					playerState.Sprint++;
					num = (int)((num2 * 1725082845) ^ 0xF86D495);
					continue;
				case 0u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)(num2 * 404024846) ^ -174269543;
					continue;
				default:
					return;
				case 25u:
					break;
				case 84u:
					return;
					IL_0345:
					flag6 = (byte)num13 != 0;
					flag11 = !flag5;
					num = 1617179788;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card card = default(Card);
		Card result = default(Card);
		bool flag = default(bool);
		while (true)
		{
			int num = -1388189503;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0470540u) % 8u)
				{
				case 7u:
					card = _deck[0];
					_deck.RemoveAt(0);
					num = -1181479581;
					continue;
				case 4u:
					ShuffleCards();
					num = ((int)num2 * -534824436) ^ 0x4A4ACF6F;
					continue;
				case 3u:
					num = ((int)num2 * -206488177) ^ -736137753;
					continue;
				case 2u:
					result = card;
					num = ((int)num2 * -884310601) ^ 0x714FF383;
					continue;
				case 1u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -1568277954) ^ -656749682;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 2047177631;
						num4 = 2047177631;
					}
					else
					{
						num3 = 112663684;
						num4 = 112663684;
					}
					num = num3 ^ ((int)num2 * -1662125580);
					continue;
				}
				case 6u:
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
			int num = -505425132;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7789E5Fu) % 8u)
				{
				case 7u:
				{
					int num4;
					if (num3 >= _playerStates.Length)
					{
						num = -1767572998;
						num4 = -1767572998;
					}
					else
					{
						num = -1468822555;
						num4 = -1468822555;
					}
					continue;
				}
				case 6u:
					num = (int)((num2 * 1900360598) ^ 0x70BB6FEC);
					continue;
				case 5u:
					result = text;
					num = ((int)num2 * -1753013046) ^ -1303172220;
					continue;
				case 3u:
					text = "";
					num3 = 0;
					num = ((int)num2 * -532929947) ^ 0x3CB9200E;
					continue;
				case 2u:
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
					num = -338438785;
					continue;
				}
				case 0u:
					num3++;
					num = (int)(num2 * 1296542288) ^ -608462872;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -884904965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C807941u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = ToString(initial: false);
				num = (int)(num2 * 2106301541) ^ -1810064371;
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
