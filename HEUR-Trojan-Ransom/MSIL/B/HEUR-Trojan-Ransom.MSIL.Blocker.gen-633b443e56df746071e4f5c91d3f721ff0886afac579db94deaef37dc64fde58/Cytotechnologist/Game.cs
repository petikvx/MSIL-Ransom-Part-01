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
			PlayerState[] playerStates = default(PlayerState[]);
			bool result = default(bool);
			int num5 = default(int);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = -1277379532;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0592EE6u) % 14u)
					{
					case 13u:
						playerStates = _playerStates;
						num = -1195780077;
						continue;
					case 12u:
						result = true;
						num = ((int)num2 * -817814532) ^ 0x7BDECB67;
						continue;
					case 11u:
						result = false;
						num = (int)(num2 * 905097251) ^ -989565796;
						continue;
					case 10u:
						num5++;
						num = -869008643;
						continue;
					case 9u:
						num = ((int)num2 * -1585266601) ^ 0x7347AD24;
						continue;
					case 8u:
					{
						int num7;
						int num8;
						if (_finished)
						{
							num7 = -14412266;
							num8 = -14412266;
						}
						else
						{
							num7 = -1817709967;
							num8 = -1817709967;
						}
						num = num7 ^ ((int)num2 * -266230131);
						continue;
					}
					case 7u:
						num5 = 0;
						num = ((int)num2 * -1680661074) ^ -1299470801;
						continue;
					case 5u:
					{
						int num6;
						if (num5 < playerStates.Length)
						{
							num = -1964141004;
							num6 = -1964141004;
						}
						else
						{
							num = -2031068205;
							num6 = -2031068205;
						}
						continue;
					}
					case 4u:
						playerState = playerStates[num5];
						num = -87359998;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (playerState.State != 0)
						{
							num3 = 1276855988;
							num4 = 1276855988;
						}
						else
						{
							num3 = 886995623;
							num4 = 886995623;
						}
						num = num3 ^ (int)(num2 * 1950818912);
						continue;
					}
					case 1u:
						result = true;
						num = (int)((num2 * 631487025) ^ 0x51E707B9);
						continue;
					case 0u:
						num = (int)(num2 * 183894461) ^ -367565331;
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		bool flag = default(bool);
		int count = default(int);
		int num3 = default(int);
		int num4 = default(int);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 967142861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x464F816Au) % 20u)
				{
				case 19u:
					_buffer = buffer;
					num = ((int)num2 * -1221463343) ^ 0x6BBFFE90;
					continue;
				case 18u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 91726402;
						num7 = 91726402;
					}
					else
					{
						num6 = 705424626;
						num7 = 705424626;
					}
					num = num6 ^ ((int)num2 * -942609838);
					continue;
				}
				case 17u:
					Rules = Rules.Deserialize(json["rules"]);
					_dice = new Dice();
					num = ((int)num2 * -1477764352) ^ 0x253EE7A1;
					continue;
				case 16u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -972970603) ^ 0x527B03C1;
					continue;
				case 15u:
					num3 = 0;
					num = ((int)num2 * -1550821628) ^ -1499988060;
					continue;
				case 14u:
					_playerStates[num4] = new PlayerState();
					num = 1137454903;
					continue;
				case 13u:
					num4++;
					num = (int)((num2 * 1138266991) ^ 0x30F2C64D);
					continue;
				case 12u:
					flag = num3 < count;
					num = 1293670052;
					continue;
				case 11u:
					num4 = 0;
					num = ((int)num2 * -1239898827) ^ 0x347846D;
					continue;
				case 10u:
					count = jSONNode.Count;
					num = (int)(num2 * 1738149104) ^ -444537925;
					continue;
				case 8u:
					num = (int)(num2 * 1116019428) ^ -1388569298;
					continue;
				case 7u:
					jSONNode = json["players"];
					num = ((int)num2 * -614082144) ^ 0x587D10EC;
					continue;
				case 6u:
					num = ((int)num2 * -1836079085) ^ -1686320368;
					continue;
				case 5u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					num = (int)((num2 * 319608546) ^ 0x7C146379);
					continue;
				case 4u:
				{
					int num5;
					if (num4 >= count)
					{
						num = 882156384;
						num5 = 882156384;
					}
					else
					{
						num = 1367617516;
						num5 = 1367617516;
					}
					continue;
				}
				case 3u:
					num3++;
					num = (int)((num2 * 438937661) ^ 0x779FBC15);
					continue;
				case 1u:
					Players = new Player[count];
					num = ((int)num2 * -31412207) ^ -365835044;
					continue;
				case 0u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = 1844182437;
					continue;
				default:
					return;
				case 9u:
					break;
				case 2u:
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
		while (true)
		{
			int num = 2115918994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25CD75A7u) % 7u)
				{
				case 6u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -123952189) ^ -882435694;
					continue;
				case 5u:
					_finished = false;
					num = (int)(num2 * 1231897674) ^ -1475345319;
					continue;
				case 4u:
					Winners.Clear();
					Losers.Clear();
					num = ((int)num2 * -85325661) ^ -1230530922;
					continue;
				case 2u:
					ShuffleCards();
					num = (int)(num2 * 169684073) ^ -1363698790;
					continue;
				case 1u:
					_currentTurn = 0;
					num = ((int)num2 * -679936022) ^ 0x6DEE1D80;
					continue;
				case 0u:
					break;
				default:
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
		bool flag3 = default(bool);
		int num6 = default(int);
		PlayerState playerState = default(PlayerState);
		int planningCardsCount = default(int);
		int num3 = default(int);
		Player player = default(Player);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1110747541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B504EE9u) % 22u)
				{
				case 21u:
					flag3 = num6 < Players.Length;
					num = -711153148;
					continue;
				case 20u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = -1197045616;
					continue;
				case 19u:
					num3 = 0;
					num = -705138088;
					continue;
				case 18u:
					player = Players[num6];
					playerState = _playerStates[num6];
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num = -1618179869;
					continue;
				case 16u:
					playerState.Sprint = 1;
					num = ((int)num2 * -22344216) ^ 0x1BCBAB05;
					continue;
				case 15u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = -1346269995;
						num10 = -1346269995;
					}
					else
					{
						num9 = -1658951836;
						num10 = -1658951836;
					}
					num = num9 ^ (int)(num2 * 1111369687);
					continue;
				}
				case 14u:
					flag2 = num3 > 0;
					num = -284403584;
					continue;
				case 12u:
				{
					int num11;
					int num12;
					if (!flag)
					{
						num11 = -1328372266;
						num12 = -1328372266;
					}
					else
					{
						num11 = -79518597;
						num12 = -79518597;
					}
					num = num11 ^ (int)(num2 * 558889508);
					continue;
				}
				case 11u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = -1675829753;
					continue;
				case 10u:
					num = (int)(num2 * 457992971) ^ -832695909;
					continue;
				case 9u:
					playerState.Sprint = -1;
					num = (int)((num2 * 2038008512) ^ 0x16A7833A);
					continue;
				case 8u:
					num6 = 0;
					num = (int)(num2 * 1362421110) ^ -192697609;
					continue;
				case 7u:
					num = -1517303089;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (player.UseOneMorePlanningSprint)
					{
						num7 = -1588576138;
						num8 = -1588576138;
					}
					else
					{
						num7 = -507874533;
						num8 = -507874533;
					}
					num = num7 ^ ((int)num2 * -1348183974);
					continue;
				}
				case 5u:
					num6++;
					num = (int)(num2 * 1303930122) ^ -238703558;
					continue;
				case 4u:
					num = (int)(num2 * 1557086172) ^ -184637320;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -762169269;
						num5 = -762169269;
					}
					else
					{
						num4 = -528361950;
						num5 = -528361950;
					}
					num = num4 ^ (int)(num2 * 145336008);
					continue;
				}
				case 2u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = ((int)num2 * -1488618708) ^ -1275149984;
					continue;
				case 1u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = ((int)num2 * -1576012315) ^ 0x19EF2D27;
					continue;
				case 0u:
					num3 = 0;
					flag = planningCardsCount == 0;
					num = (int)((num2 * 2105302552) ^ 0x191228BB);
					continue;
				default:
					return;
				case 13u:
					break;
				case 17u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -819588649;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA7D9C6A0u) % 13u)
				{
				case 12u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -2049226234;
						num6 = -2049226234;
					}
					else
					{
						num5 = -1044060884;
						num6 = -1044060884;
					}
					num = num5 ^ ((int)num2 * -2057828052);
					continue;
				}
				case 11u:
					_currentPlayer++;
					flag = _currentPlayer >= Players.Length;
					num = (int)((num2 * 1173357289) ^ 0x49BEA8A2);
					continue;
				case 10u:
					num = (int)(num2 * 1818806186) ^ -432791137;
					continue;
				case 9u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -1841703862;
					continue;
				case 8u:
					_currentPlayer = 0;
					num = ((int)num2 * -424446604) ^ -1377296941;
					continue;
				case 7u:
					PlayerTurn(_currentPlayer);
					num = -1826068563;
					continue;
				case 6u:
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -1215944972) ^ -1206659086;
					continue;
				case 5u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 1349735007) ^ 0x33D5B8B6);
					continue;
				case 4u:
					num = ((int)num2 * -4285955) ^ 0x1AE2294D;
					continue;
				case 3u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 1090742489) ^ -615879890;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1358137120;
						num4 = -1358137120;
					}
					else
					{
						num3 = -1260156950;
						num4 = -1260156950;
					}
					num = num3 ^ ((int)num2 * -65586867);
					continue;
				}
				default:
					return;
				case 2u:
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
		bool flag4 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag10 = default(bool);
		int num9 = default(int);
		bool flag3 = default(bool);
		bool flag9 = default(bool);
		int num10 = default(int);
		PlayerState playerState2 = default(PlayerState);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		int num30 = default(int);
		Card card = default(Card);
		Player player = default(Player);
		bool onlyOneWinner = default(bool);
		bool flag2 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = -609163373;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0x9CA73F78u) % 83u)
				{
				case 82u:
					flag4 = playerState.Resources >= 0;
					num = (int)(num2 * 1491396592) ^ -817762497;
					continue;
				case 81u:
					flag10 = !Losers.Contains(num9);
					num = -804376509;
					continue;
				case 80u:
					num = (int)((num2 * 1642123570) ^ 0x57FFB8C1);
					continue;
				case 79u:
					num = (int)(num2 * 2106748826) ^ -1996695670;
					continue;
				case 78u:
					flag3 = true;
					Print("CARD: none, advance");
					num = (int)((num2 * 420110309) ^ 0x38E7C04);
					continue;
				case 77u:
					num = ((int)num2 * -1635321859) ^ 0x3F41126A;
					continue;
				case 76u:
					num = -1492893037;
					continue;
				case 75u:
					num = ((int)num2 * -1977999828) ^ -811051779;
					continue;
				case 74u:
				{
					int num36;
					int num37;
					if (!flag9)
					{
						num36 = 56419428;
						num37 = 56419428;
					}
					else
					{
						num36 = 1635959650;
						num37 = 1635959650;
					}
					num = num36 ^ (int)(num2 * 434089290);
					continue;
				}
				case 73u:
					Losers.Add(num10);
					num = ((int)num2 * -884985238) ^ 0x5D111AD9;
					continue;
				case 72u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -528190375) ^ -817005902;
					continue;
				case 71u:
				{
					int num15;
					int num16;
					if (num9 != playerIndex)
					{
						num15 = -201426911;
						num16 = -201426911;
					}
					else
					{
						num15 = -1009171049;
						num16 = -1009171049;
					}
					num = num15 ^ ((int)num2 * -2098980744);
					continue;
				}
				case 70u:
					Print(playerState2.State);
					num = (int)((num2 * 1932725435) ^ 0x1AA7B6B0);
					continue;
				case 69u:
				{
					int num4;
					int num5;
					if (playerState2.Resources < 0)
					{
						num4 = 910749697;
						num5 = 910749697;
					}
					else
					{
						num4 = 2137338217;
						num5 = 2137338217;
					}
					num = num4 ^ ((int)num2 * -1482673491);
					continue;
				}
				case 68u:
				{
					int num32;
					int num33;
					if (flag10)
					{
						num32 = -519564179;
						num33 = -519564179;
					}
					else
					{
						num32 = -1667760238;
						num33 = -1667760238;
					}
					num = num32 ^ ((int)num2 * -802814417);
					continue;
				}
				case 67u:
				{
					int num29;
					if (playerState2.Sprint > Rules.SprintCount)
					{
						num = -949864947;
						num29 = -949864947;
					}
					else
					{
						num = -318752795;
						num29 = -318752795;
					}
					continue;
				}
				case 66u:
					Print("Still planning");
					num = (int)(num2 * 1048811373) ^ -1524185002;
					continue;
				case 65u:
					flag8 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -698087173;
					continue;
				case 64u:
					playerState2.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -2145646209) ^ -359410095;
					continue;
				case 63u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)(num2 * 643920539) ^ -2019302998;
						continue;
					}
					num8 = 0;
					goto IL_02af;
				case 62u:
					num9 = 0;
					num = ((int)num2 * -984180223) ^ 0x6B6014F7;
					continue;
				case 61u:
					num = -318752795;
					continue;
				case 60u:
					Losers.Add(num9);
					num = ((int)num2 * -399439957) ^ 0x687B1007;
					continue;
				case 59u:
					num = ((int)num2 * -1653752584) ^ 0x77D46572;
					continue;
				case 58u:
					flag7 = flag3;
					num = -1384677592;
					continue;
				case 57u:
					num = ((int)num2 * -1476425881) ^ -819147538;
					continue;
				case 56u:
					num = (int)((num2 * 1666268731) ^ 0x529AADFC);
					continue;
				case 55u:
					num = ((int)num2 * -291969721) ^ 0x5C3A24DC;
					continue;
				case 54u:
				{
					int num11;
					int num12;
					if (flag7)
					{
						num11 = -1066921821;
						num12 = -1066921821;
					}
					else
					{
						num11 = -1832172066;
						num12 = -1832172066;
					}
					num = num11 ^ (int)(num2 * 301428775);
					continue;
				}
				case 53u:
					num = -914116953;
					continue;
				case 52u:
					playerState2.Sprint++;
					num = (int)((num2 * 1660553029) ^ 0xF828470);
					continue;
				case 51u:
					num = ((int)num2 * -737307575) ^ 0x33D1B36E;
					continue;
				case 50u:
				{
					int num6;
					int num7;
					if (!flag5)
					{
						num6 = 909398617;
						num7 = 909398617;
					}
					else
					{
						num6 = 656902022;
						num7 = 656902022;
					}
					num = num6 ^ (int)(num2 * 1268698169);
					continue;
				}
				case 49u:
					num = -1338113392;
					continue;
				case 47u:
					playerState2.Resources -= num3;
					num = (int)((num2 * 48312611) ^ 0x1DAACFFE);
					continue;
				case 46u:
				{
					int num34;
					int num35;
					if (flag)
					{
						num34 = -1213469845;
						num35 = -1213469845;
					}
					else
					{
						num34 = -343659211;
						num35 = -343659211;
					}
					num = num34 ^ (int)(num2 * 1186600407);
					continue;
				}
				case 45u:
					num = ((int)num2 * -415173718) ^ -1703986010;
					continue;
				case 44u:
					num = (int)(num2 * 2100244155) ^ -1490212867;
					continue;
				case 43u:
					flag3 = false;
					num = -1468341930;
					continue;
				case 42u:
				{
					int num31;
					if (num10 >= _playerStates.Length)
					{
						num = -808403262;
						num31 = -808403262;
					}
					else
					{
						num = -1972150053;
						num31 = -1972150053;
					}
					continue;
				}
				case 41u:
					playerState.State = State.Lose;
					num = -996289711;
					continue;
				case 40u:
					num3 = Game.smethod_3(0, num30);
					num = ((int)num2 * -2048313369) ^ 0x1FDC4814;
					continue;
				case 39u:
					num10 = 0;
					num = -654521081;
					continue;
				case 38u:
					num30 = card.Impact - player.PlannedForCard(card.Type);
					flag3 = num30 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -5599495) ^ 0x5D5DF54F;
					continue;
				case 37u:
				{
					int num27;
					int num28;
					if (playerState2.State != 0)
					{
						num27 = 20145813;
						num28 = 20145813;
					}
					else
					{
						num27 = 1677741011;
						num28 = 1677741011;
					}
					num = num27 ^ (int)(num2 * 1131800272);
					continue;
				}
				case 36u:
					num = (int)(num2 * 15977044) ^ -943126472;
					continue;
				case 35u:
					num10++;
					num = -1887434567;
					continue;
				case 34u:
					num = (int)((num2 * 1089165837) ^ 0x75CAEAF6);
					continue;
				case 33u:
					num = ((int)num2 * -127675403) ^ 0x17BF4E3E;
					continue;
				case 32u:
				{
					int num25;
					int num26;
					if (onlyOneWinner)
					{
						num25 = -1351751006;
						num26 = -1351751006;
					}
					else
					{
						num25 = -1503242620;
						num26 = -1503242620;
					}
					num = num25 ^ ((int)num2 * -1070043166);
					continue;
				}
				case 31u:
					num = (int)(num2 * 1799802527) ^ -1099504238;
					continue;
				case 30u:
					num = ((int)num2 * -1849484061) ^ 0x3B78F64C;
					continue;
				case 29u:
				{
					int num23;
					int num24;
					if (flag4)
					{
						num23 = -435469816;
						num24 = -435469816;
					}
					else
					{
						num23 = -1790502456;
						num24 = -1790502456;
					}
					num = num23 ^ ((int)num2 * -2033099217);
					continue;
				}
				case 28u:
					Losers.Add(playerIndex);
					num = (int)(num2 * 960966589) ^ -1014348840;
					continue;
				case 27u:
					num = (int)(num2 * 696408196) ^ -1671362070;
					continue;
				case 26u:
					num = (int)((num2 * 1743726252) ^ 0x4AF1970F);
					continue;
				case 25u:
				{
					int num21;
					int num22;
					if (Losers.Contains(num10))
					{
						num21 = 471704572;
						num22 = 471704572;
					}
					else
					{
						num21 = 1312327001;
						num22 = 1312327001;
					}
					num = num21 ^ ((int)num2 * -279730793);
					continue;
				}
				case 24u:
				{
					playerState2.State = State.Lose;
					int num19;
					int num20;
					if (!Losers.Contains(playerIndex))
					{
						num19 = 57553100;
						num20 = 57553100;
					}
					else
					{
						num19 = 1235644761;
						num20 = 1235644761;
					}
					num = num19 ^ ((int)num2 * -1058425441);
					continue;
				}
				case 23u:
					num = -428788561;
					continue;
				case 21u:
					num = (int)((num2 * 399081166) ^ 0x52A365F3);
					continue;
				case 20u:
					flag9 = !flag2;
					num = (int)(num2 * 1694234434) ^ -33114301;
					continue;
				case 19u:
					flag5 = num9 < _playerStates.Length;
					num = -1591130034;
					continue;
				case 18u:
					num = ((int)num2 * -421084667) ^ -758449851;
					continue;
				case 17u:
					_finished = true;
					num = ((int)num2 * -677373119) ^ 0xBD24EBB;
					continue;
				case 16u:
					flag3 = true;
					num3 = card.Impact;
					num = -1035254840;
					continue;
				case 15u:
				{
					int num17;
					int num18;
					if (!flag6)
					{
						num17 = -839238063;
						num18 = -839238063;
					}
					else
					{
						num17 = -2062058382;
						num18 = -2062058382;
					}
					num = num17 ^ ((int)num2 * -1324867992);
					continue;
				}
				case 14u:
					playerState2.Sprint++;
					num = (int)(num2 * 2056431229) ^ -105831855;
					continue;
				case 13u:
					num = -532785877;
					continue;
				case 12u:
				{
					int num13;
					int num14;
					if (!flag8)
					{
						num13 = -972859724;
						num14 = -972859724;
					}
					else
					{
						num13 = -1817267819;
						num14 = -1817267819;
					}
					num = num13 ^ (int)(num2 * 996316125);
					continue;
				}
				case 11u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -1589345438;
					continue;
				}
				case 10u:
					num = -1486532492;
					continue;
				case 9u:
					num = (int)((num2 * 1910978028) ^ 0x1C31A352);
					continue;
				case 8u:
					card = DrawCard();
					flag2 = card.Impact < 0;
					num = ((int)num2 * -1127092071) ^ -1420769137;
					continue;
				case 7u:
					num = ((int)num2 * -1497311948) ^ 0x243EA248;
					continue;
				case 6u:
					flag6 = playerState2.Sprint < 0;
					num = -1487786647;
					continue;
				case 5u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -1945701867) ^ -1377609743;
					continue;
				case 4u:
					playerState = _playerStates[num10];
					playerState.Resources -= Game.smethod_3(0, num3 - Players[num10].PlannedForCard(card.Type));
					num = -1534185190;
					continue;
				case 3u:
					player = Players[playerIndex];
					playerState2 = _playerStates[playerIndex];
					num = (int)((num2 * 1762142920) ^ 0x2632A503);
					continue;
				case 2u:
					num9++;
					num = -264821845;
					continue;
				case 1u:
					num8 = ((card.Type == 4) ? 1 : 0);
					goto IL_02af;
				case 0u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num3), flag3 ? "advance" : "stay");
					num = -787512576;
					continue;
				default:
					return;
				case 48u:
					break;
				case 22u:
					return;
					IL_02af:
					flag = (byte)num8 != 0;
					num = -1745291212;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 144279299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x52989F18u) % 8u)
				{
				case 7u:
					result = card;
					num = ((int)num2 * -1956559512) ^ -1555968394;
					continue;
				case 5u:
					ShuffleCards();
					num = (int)(num2 * 2069521306) ^ -1005307394;
					continue;
				case 4u:
					card = _deck[0];
					_deck.RemoveAt(0);
					num = 1298077658;
					continue;
				case 3u:
					flag = _deck.Count <= 0;
					num = (int)(num2 * 355643167) ^ -114751700;
					continue;
				case 2u:
					num = ((int)num2 * -1099808287) ^ 0x7BA4A60D;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1043984819;
						num4 = 1043984819;
					}
					else
					{
						num3 = 1646581162;
						num4 = 1646581162;
					}
					num = num3 ^ (int)(num2 * 1023951439);
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

	public string ToString(bool initial)
	{
		string text = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1189406041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCEC1E78u) % 8u)
				{
				case 7u:
					text = "";
					num3 = 0;
					num = (int)(num2 * 1785913057) ^ -1567539610;
					continue;
				case 5u:
					num3++;
					num = (int)(num2 * 1169008341) ^ -912440181;
					continue;
				case 3u:
					result = text;
					num = ((int)num2 * -1832755365) ^ 0x5B148275;
					continue;
				case 2u:
				{
					int num4;
					if (num3 < _playerStates.Length)
					{
						num = -1885458008;
						num4 = -1885458008;
					}
					else
					{
						num = -1809423229;
						num4 = -1809423229;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -1891367233) ^ -103182203;
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
					num = -1627879819;
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

	public override string ToString()
	{
		return ToString(initial: false);
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = 481707624;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B292E4Fu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					Game.smethod_8(_buffer, string_);
					return;
				}
				break;
				IL_0003:
				string_ = Game.smethod_7(Game.smethod_5(text), more);
				num = (int)(num2 * 710741150) ^ -1262969125;
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
