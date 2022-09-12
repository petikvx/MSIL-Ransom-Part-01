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
			PlayerState[] playerStates = default(PlayerState[]);
			int num5 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -372593334;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9F8F5895u) % 14u)
					{
					case 13u:
						num = ((int)num2 * -774450028) ^ -294619710;
						continue;
					case 12u:
						result = true;
						num = ((int)num2 * -1694943123) ^ -1792615400;
						continue;
					case 11u:
						playerStates = _playerStates;
						num = (int)((num2 * 745001722) ^ 0x3A702C05);
						continue;
					case 9u:
					{
						int num6;
						if (num5 >= playerStates.Length)
						{
							num = -1483651881;
							num6 = -1483651881;
						}
						else
						{
							num = -1574546661;
							num6 = -1574546661;
						}
						continue;
					}
					case 8u:
						result = false;
						num = ((int)num2 * -1259205404) ^ -1260960562;
						continue;
					case 7u:
						num = -1186791712;
						continue;
					case 6u:
						num5++;
						num = -748911596;
						continue;
					case 4u:
					{
						PlayerState playerState = playerStates[num5];
						flag = playerState.State == State.Playing;
						num = -1045858334;
						continue;
					}
					case 3u:
					{
						int num7;
						int num8;
						if (finished)
						{
							num7 = -1659810454;
							num8 = -1659810454;
						}
						else
						{
							num7 = -2091427387;
							num8 = -2091427387;
						}
						num = num7 ^ ((int)num2 * -1837138201);
						continue;
					}
					case 2u:
						num5 = 0;
						num = ((int)num2 * -547733778) ^ 0x57D6328;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1084332156;
							num4 = 1084332156;
						}
						else
						{
							num3 = 140331518;
							num4 = 140331518;
						}
						num = num3 ^ (int)(num2 * 1441824683);
						continue;
					}
					case 0u:
						result = true;
						num = (int)((num2 * 1123950815) ^ 0xEFB0E6A);
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
		int num6 = default(int);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1474685004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4003B56Du) % 18u)
				{
				case 17u:
					num6 = 0;
					num = ((int)num2 * -371549902) ^ 0x246BDDFB;
					continue;
				case 16u:
					_buffer = buffer;
					num = (int)(num2 * 1717092034) ^ -2037210016;
					continue;
				case 14u:
					count = jSONNode.Count;
					num = (int)(num2 * 1441479488) ^ -1193106285;
					continue;
				case 13u:
					num = (int)(num2 * 805529655) ^ -153352156;
					continue;
				case 12u:
					num = (int)(num2 * 147421199) ^ -458903335;
					continue;
				case 11u:
					Players[num6] = Player.Deserialize(jSONNode[num6]);
					num6++;
					num = 1523626589;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 2055017005;
						num8 = 2055017005;
					}
					else
					{
						num7 = 1061490074;
						num8 = 1061490074;
					}
					num = num7 ^ ((int)num2 * -1512572987);
					continue;
				}
				case 9u:
					num3++;
					num = (int)((num2 * 733375649) ^ 0x1BAC13E);
					continue;
				case 8u:
					Players = new Player[count];
					num = (int)(num2 * 773775030) ^ -50964046;
					continue;
				case 7u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = (int)((num2 * 1518881848) ^ 0x1892C0A4);
					continue;
				case 6u:
					flag2 = num3 < count;
					num = 1643471983;
					continue;
				case 4u:
					flag = num6 < count;
					num = 801927176;
					continue;
				case 3u:
					_dice = new Dice();
					jSONNode = json["players"];
					num = (int)((num2 * 38979067) ^ 0x2011C16C);
					continue;
				case 2u:
					_playerStates[num3] = new PlayerState();
					num = 145274320;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1555982587;
						num5 = 1555982587;
					}
					else
					{
						num4 = 1125616788;
						num5 = 1125616788;
					}
					num = num4 ^ ((int)num2 * -1264029390);
					continue;
				}
				case 0u:
					_playerStates = new PlayerState[count];
					num3 = 0;
					num = (int)(num2 * 294705801) ^ -804401977;
					continue;
				default:
					return;
				case 5u:
					break;
				case 15u:
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
		Winners.Clear();
		while (true)
		{
			int num = 1091602280;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5FC57685u) % 5u)
				{
				case 4u:
					_finished = false;
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -1250323382) ^ 0x63FE3987;
					continue;
				case 1u:
					Losers.Clear();
					_currentPlayer = Players.Length;
					num = (int)((num2 * 581748737) ^ 0x7CB80CF3);
					continue;
				case 0u:
					_currentTurn = 0;
					num = ((int)num2 * -1931679056) ^ 0x284B98E1;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
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
		int num6 = default(int);
		int planningCardsCount = default(int);
		Player player = default(Player);
		bool useOneMorePlanningSprint = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -546655186;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x927EA69Bu) % 27u)
				{
				case 26u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -45380905) ^ -1340312897;
					continue;
				case 25u:
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num2 = ((int)num3 * -1267228851) ^ 0x54ACBD99;
					continue;
				case 24u:
					planningCardsCount = player.PlanningCardsCount;
					num6 = 0;
					num2 = (int)((num3 * 957707093) ^ 0x6062CDB2);
					continue;
				case 23u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num2 = (int)(num3 * 1333309917) ^ -1363380770;
					continue;
				case 22u:
				{
					int num11;
					if (num6 <= 0)
					{
						num2 = -1647470402;
						num11 = -1647470402;
					}
					else
					{
						num2 = -524431701;
						num11 = -524431701;
					}
					continue;
				}
				case 21u:
				{
					int num7;
					int num8;
					if (!useOneMorePlanningSprint)
					{
						num7 = -1166541956;
						num8 = -1166541956;
					}
					else
					{
						num7 = -749607975;
						num8 = -749607975;
					}
					num2 = num7 ^ ((int)num3 * -1952225239);
					continue;
				}
				case 20u:
					flag2 = num < Players.Length;
					num2 = -29966647;
					continue;
				case 19u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num2 = -477068201;
					continue;
				case 18u:
					num2 = ((int)num3 * -73516382) ^ -744557393;
					continue;
				case 17u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num2 = (int)((num3 * 935825634) ^ 0x33696D98);
					continue;
				case 16u:
					flag = planningCardsCount == 0;
					num2 = (int)((num3 * 233507104) ^ 0x1AAF46AC);
					continue;
				case 15u:
					num2 = (int)(num3 * 166455151) ^ -1376527366;
					continue;
				case 14u:
					playerState.State = State.Playing;
					num2 = (int)(num3 * 2131898106) ^ -291443044;
					continue;
				case 13u:
					num++;
					num2 = ((int)num3 * -1674774917) ^ 0x10990D8D;
					continue;
				case 12u:
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = ((int)num3 * -851208793) ^ -1095190608;
					continue;
				case 11u:
					player = Players[num];
					playerState = _playerStates[num];
					num2 = ((int)num3 * -372242754) ^ -894660540;
					continue;
				case 10u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					num2 = (int)(num3 * 1948951145) ^ -1903789853;
					continue;
				case 9u:
					num2 = -724637331;
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1897645064;
						num10 = 1897645064;
					}
					else
					{
						num9 = 1079044914;
						num10 = 1079044914;
					}
					num2 = num9 ^ (int)(num3 * 955854606);
					continue;
				}
				case 6u:
					num2 = -1517370051;
					continue;
				case 5u:
					num6 = 0;
					num2 = -1157261320;
					continue;
				case 4u:
					playerState.Sprint = -1;
					num2 = (int)(num3 * 681440967) ^ -1676877350;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 802036821;
						num5 = 802036821;
					}
					else
					{
						num4 = 1791795988;
						num5 = 1791795988;
					}
					num2 = num4 ^ (int)(num3 * 1724601348);
					continue;
				}
				case 2u:
					num2 = (int)(num3 * 2040806984) ^ -564996767;
					continue;
				case 1u:
					num2 = -624677358;
					continue;
				default:
					return;
				case 0u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		bool flag = _currentPlayer >= Players.Length;
		bool flag2 = default(bool);
		while (true)
		{
			int num = -951333515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x89D694EFu) % 11u)
				{
				case 10u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)(num2 * 1636919286) ^ -1774514730;
					continue;
				case 9u:
					num = (int)((num2 * 1103513459) ^ 0x7BC179E6);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -2045291617;
						num6 = -2045291617;
					}
					else
					{
						num5 = -313914363;
						num6 = -313914363;
					}
					num = num5 ^ (int)(num2 * 857343881);
					continue;
				}
				case 7u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -260633161) ^ 0x68D13FB9;
					continue;
				case 6u:
					_currentPlayer = 0;
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -1943821567) ^ 0x485CD124;
					continue;
				case 5u:
					num = ((int)num2 * -750379495) ^ 0x349E2152;
					continue;
				case 3u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -1789524486;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2113726811;
						num4 = -2113726811;
					}
					else
					{
						num3 = -2143535539;
						num4 = -2143535539;
					}
					num = num3 ^ (int)(num2 * 1389311636);
					continue;
				}
				case 0u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -922166786) ^ -1835949422;
					continue;
				case 4u:
					break;
				default:
					PlayerTurn(_currentPlayer);
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		int num5 = default(int);
		Card card = default(Card);
		bool flag6 = default(bool);
		bool flag = default(bool);
		PlayerState playerState = default(PlayerState);
		int num6 = default(int);
		bool flag8 = default(bool);
		int num13 = default(int);
		bool flag11 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		int num7 = default(int);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		Player player = default(Player);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag7 = default(bool);
		while (true)
		{
			int num = 986038966;
			while (true)
			{
				uint num2;
				int num10;
				switch ((num2 = (uint)num ^ 0x38559D0Du) % 81u)
				{
				case 80u:
					num5 = card.Impact;
					num = ((int)num2 * -1390295866) ^ 0x11C4F28B;
					continue;
				case 79u:
					num = (int)((num2 * 570896988) ^ 0x76DB4C6E);
					continue;
				case 78u:
					num = (int)((num2 * 1247380856) ^ 0x56614EA6);
					continue;
				case 77u:
					card = DrawCard();
					flag6 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -806742597) ^ -1202045589;
						continue;
					}
					num10 = 0;
					goto IL_007d;
				case 76u:
					num = (int)(num2 * 1739163789) ^ -1549313850;
					continue;
				case 75u:
					flag = false;
					num = 1332642044;
					continue;
				case 74u:
					flag = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -1808155435) ^ -173070589;
					continue;
				case 73u:
					playerState.Resources -= Game.smethod_3(0, num5 - Players[num6].PlannedForCard(card.Type));
					num = (int)((num2 * 548296293) ^ 0x78C31B96);
					continue;
				case 72u:
				{
					int num20;
					int num21;
					if (!flag6)
					{
						num20 = -771355914;
						num21 = -771355914;
					}
					else
					{
						num20 = -1494819663;
						num21 = -1494819663;
					}
					num = num20 ^ ((int)num2 * -788463640);
					continue;
				}
				case 71u:
				{
					int num16;
					int num17;
					if (!flag8)
					{
						num16 = -1052274625;
						num17 = -1052274625;
					}
					else
					{
						num16 = -2058699134;
						num17 = -2058699134;
					}
					num = num16 ^ ((int)num2 * -99887287);
					continue;
				}
				case 70u:
					num = 1600461286;
					continue;
				case 68u:
					num = 636592206;
					continue;
				case 67u:
					num5 = Game.smethod_3(0, num13);
					num = ((int)num2 * -1652949886) ^ 0x35B20EF;
					continue;
				case 66u:
					Winners.Add(playerIndex);
					num = ((int)num2 * -593197918) ^ -230506300;
					continue;
				case 65u:
				{
					int num34;
					int num35;
					if (flag11)
					{
						num34 = 882698485;
						num35 = 882698485;
					}
					else
					{
						num34 = 1027691896;
						num35 = 1027691896;
					}
					num = num34 ^ ((int)num2 * -869069651);
					continue;
				}
				case 64u:
					flag11 = playerState2.Sprint > Rules.SprintCount;
					num = 1185893141;
					continue;
				case 63u:
					playerState2.Sprint++;
					num = ((int)num2 * -1099096161) ^ 0x1679EAF6;
					continue;
				case 62u:
					num = (int)((num2 * 807539615) ^ 0x2DAC0B7F);
					continue;
				case 61u:
					num = ((int)num2 * -1170604247) ^ -369984585;
					continue;
				case 60u:
					num = 1638953386;
					continue;
				case 59u:
				{
					int num30;
					int num31;
					if (flag10)
					{
						num30 = -34703232;
						num31 = -34703232;
					}
					else
					{
						num30 = -1813409734;
						num31 = -1813409734;
					}
					num = num30 ^ (int)(num2 * 475080066);
					continue;
				}
				case 58u:
					flag9 = flag;
					num = 554935136;
					continue;
				case 57u:
					num = (int)((num2 * 1054860798) ^ 0x7004D6F9);
					continue;
				case 56u:
					num7 = 0;
					num = (int)((num2 * 1887965215) ^ 0xD5ABDF0);
					continue;
				case 55u:
					_finished = true;
					num = ((int)num2 * -427928978) ^ -800615995;
					continue;
				case 54u:
					flag4 = playerState.Resources >= 0;
					num = ((int)num2 * -394417075) ^ 0x7CABAFA5;
					continue;
				case 53u:
					Losers.Add(num7);
					num = ((int)num2 * -1317274655) ^ -1991578420;
					continue;
				case 52u:
					num = (int)((num2 * 119528516) ^ 0x462688D8);
					continue;
				case 51u:
					flag = true;
					num = 2130246569;
					continue;
				case 50u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag5 ? "ALL " : "", flag6 ? "receives" : "pays", Game.smethod_4(num5), flag ? "advance" : "stay");
					num = 1413184818;
					continue;
				case 49u:
					num = ((int)num2 * -702993318) ^ 0xD0BCAD8;
					continue;
				case 48u:
					num10 = ((card.Type == 4) ? 1 : 0);
					goto IL_007d;
				case 47u:
					playerState2.State = State.Lose;
					num = (int)((num2 * 1010603937) ^ 0x74732EFA);
					continue;
				case 46u:
				{
					int num36;
					int num37;
					if (!flag5)
					{
						num36 = 1325591023;
						num37 = 1325591023;
					}
					else
					{
						num36 = 1265197576;
						num37 = 1265197576;
					}
					num = num36 ^ (int)(num2 * 490294341);
					continue;
				}
				case 45u:
				{
					int num33;
					if (!Losers.Contains(num7))
					{
						num = 714287285;
						num33 = 714287285;
					}
					else
					{
						num = 1433662068;
						num33 = 1433662068;
					}
					continue;
				}
				case 44u:
					num13 = card.Impact - player.PlannedForCard(card.Type);
					flag = num13 < Rules.StayOnSprintMinDiff;
					num = (int)((num2 * 330825255) ^ 0x64171AB3);
					continue;
				case 43u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 245937476;
					continue;
				}
				case 42u:
				{
					int num32;
					if (num7 < _playerStates.Length)
					{
						num = 2024224702;
						num32 = 2024224702;
					}
					else
					{
						num = 1027393226;
						num32 = 1027393226;
					}
					continue;
				}
				case 41u:
					num = ((int)num2 * -1139904225) ^ -177281919;
					continue;
				case 40u:
					num = (int)((num2 * 1509661042) ^ 0x2321D17);
					continue;
				case 39u:
					flag10 = !Losers.Contains(num6);
					num = ((int)num2 * -414885931) ^ -101841587;
					continue;
				case 38u:
					num = (int)(num2 * 1889569008) ^ -1184318117;
					continue;
				case 37u:
					num = 195940121;
					continue;
				case 36u:
					num = (int)((num2 * 1274702447) ^ 0x29F6A23D);
					continue;
				case 35u:
				{
					int num28;
					int num29;
					if (flag9)
					{
						num28 = -280180958;
						num29 = -280180958;
					}
					else
					{
						num28 = -1414995608;
						num29 = -1414995608;
					}
					num = num28 ^ (int)(num2 * 644599842);
					continue;
				}
				case 34u:
					num = 465937836;
					continue;
				case 33u:
					Losers.Add(num6);
					num = (int)((num2 * 1148806034) ^ 0x1F6D8A4C);
					continue;
				case 32u:
					Print(playerState2.State);
					num = ((int)num2 * -647874334) ^ -852274907;
					continue;
				case 31u:
					Print("Still planning");
					num = ((int)num2 * -828732144) ^ 0x560ABA85;
					continue;
				case 30u:
					num6++;
					num = 1100257892;
					continue;
				case 29u:
				{
					int num26;
					int num27;
					if (!flag3)
					{
						num26 = 391812874;
						num27 = 391812874;
					}
					else
					{
						num26 = 1497844594;
						num27 = 1497844594;
					}
					num = num26 ^ ((int)num2 * -848309818);
					continue;
				}
				case 28u:
				{
					int num24;
					int num25;
					if (Losers.Contains(playerIndex))
					{
						num24 = 1767074405;
						num25 = 1767074405;
					}
					else
					{
						num24 = 937007038;
						num25 = 937007038;
					}
					num = num24 ^ (int)(num2 * 1938698704);
					continue;
				}
				case 27u:
					num = ((int)num2 * -615313480) ^ -620694501;
					continue;
				case 26u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 734409752) ^ 0x1D88653F);
					continue;
				case 25u:
					flag8 = num7 == playerIndex;
					num = 25256835;
					continue;
				case 24u:
					num = (int)(num2 * 316768866) ^ -999555508;
					continue;
				case 23u:
					num = ((int)num2 * -1511415384) ^ 0x54450B72;
					continue;
				case 22u:
				{
					int num22;
					int num23;
					if (flag2)
					{
						num22 = 1723894188;
						num23 = 1723894188;
					}
					else
					{
						num22 = 815481785;
						num23 = 815481785;
					}
					num = num22 ^ ((int)num2 * -58455848);
					continue;
				}
				case 21u:
				{
					playerState2.Resources -= num5;
					int num18;
					int num19;
					if (playerState2.Resources < 0)
					{
						num18 = -1624541078;
						num19 = -1624541078;
					}
					else
					{
						num18 = -2137987211;
						num19 = -2137987211;
					}
					num = num18 ^ ((int)num2 * -449321377);
					continue;
				}
				case 20u:
					player = Players[playerIndex];
					playerState2 = _playerStates[playerIndex];
					num = ((int)num2 * -112846554) ^ -1361027175;
					continue;
				case 19u:
				{
					int num14;
					int num15;
					if (flag7)
					{
						num14 = -167576544;
						num15 = -167576544;
					}
					else
					{
						num14 = -99421826;
						num15 = -99421826;
					}
					num = num14 ^ (int)(num2 * 377768028);
					continue;
				}
				case 18u:
					flag7 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 2111178433;
					continue;
				case 17u:
					playerState = _playerStates[num6];
					num = 1982453637;
					continue;
				case 16u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = -1990055012;
						num12 = -1990055012;
					}
					else
					{
						num11 = -1326714568;
						num12 = -1326714568;
					}
					num = num11 ^ ((int)num2 * -1663245);
					continue;
				}
				case 15u:
					num = 1695718208;
					continue;
				case 14u:
					playerState2.Sprint++;
					num = ((int)num2 * -170955101) ^ 0x37C4070D;
					continue;
				case 13u:
					flag3 = playerState2.Sprint < 0;
					num = 1892324378;
					continue;
				case 12u:
					playerState.State = State.Lose;
					num = 1092902047;
					continue;
				case 11u:
					num6 = 0;
					num = (int)(num2 * 1590848375) ^ -558884568;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (playerState2.State != 0)
					{
						num8 = 1085849213;
						num9 = 1085849213;
					}
					else
					{
						num8 = 202047794;
						num9 = 202047794;
					}
					num = num8 ^ (int)(num2 * 680250549);
					continue;
				}
				case 9u:
					Losers.Add(playerIndex);
					num = (int)(num2 * 1880277244) ^ -971608432;
					continue;
				case 7u:
					num = ((int)num2 * -946589642) ^ -438516108;
					continue;
				case 6u:
					num = ((int)num2 * -427980055) ^ 0x55AD4483;
					continue;
				case 5u:
					playerState2.State = State.Won;
					num = (int)((num2 * 1549941875) ^ 0xB94A61C);
					continue;
				case 4u:
					num = 104989534;
					continue;
				case 3u:
					flag2 = num6 < _playerStates.Length;
					num = 1404593215;
					continue;
				case 2u:
					num7++;
					num = 1678229780;
					continue;
				case 1u:
					num = ((int)num2 * -1245537249) ^ -1306846947;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (Rules.OnlyOneWinner)
					{
						num3 = -966564409;
						num4 = -966564409;
					}
					else
					{
						num3 = -444356133;
						num4 = -444356133;
					}
					num = num3 ^ ((int)num2 * -404741511);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 69u:
					return;
					IL_007d:
					flag5 = (byte)num10 != 0;
					num = 549964305;
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
			goto IL_0056;
		}
		goto IL_0084;
		IL_0084:
		Card card = _deck[0];
		int num = 1638088231;
		goto IL_005b;
		IL_005b:
		Card result = default(Card);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x4DB1CB66u) % 6u)
			{
			case 4u:
				ShuffleCards();
				num = ((int)num2 * -2015693781) ^ -1798032051;
				continue;
			case 3u:
				_deck.RemoveAt(0);
				result = card;
				num = ((int)num2 * -706890290) ^ -1837671030;
				continue;
			case 2u:
				num = ((int)num2 * -1582369120) ^ 0x6C4B193;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0084;
			default:
				return result;
			}
			break;
		}
		goto IL_0056;
		IL_0056:
		num = 1683443248;
		goto IL_005b;
	}

	public string ToString(bool initial)
	{
		int num3 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1614945668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCA1FE91u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -180665006) ^ 0x6EC399D1;
					continue;
				case 6u:
				{
					int num4;
					if (num3 < _playerStates.Length)
					{
						num = -760988647;
						num4 = -760988647;
					}
					else
					{
						num = -895325080;
						num4 = -895325080;
					}
					continue;
				}
				case 5u:
					text = "";
					num = ((int)num2 * -444334063) ^ -1184491201;
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -494809284) ^ -1338000646;
					continue;
				case 1u:
					result = text;
					num = (int)((num2 * 591179035) ^ 0x4D837428);
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
					num3++;
					num = -1324726465;
					continue;
				}
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
			int num = 1379210655;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x250A51FFu) % 3u)
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
				num = ((int)num2 * -1673743889) ^ -1725388514;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		while (true)
		{
			int num = 1909413947;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12695933u) % 3u)
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
				string string_ = Game.smethod_7(Game.smethod_5(text), more);
				Game.smethod_8(_buffer, string_);
				num = (int)((num2 * 687456642) ^ 0x7AAC0B28);
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
