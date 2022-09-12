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
			PlayerState playerState = default(PlayerState);
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool finished = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = 1041786291;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x41B4F33u) % 13u)
					{
					case 12u:
						playerState = playerStates[num3];
						num = 1578145133;
						continue;
					case 11u:
					{
						int num7;
						int num8;
						if (!finished)
						{
							num7 = -2110610791;
							num8 = -2110610791;
						}
						else
						{
							num7 = -1729721781;
							num8 = -1729721781;
						}
						num = num7 ^ ((int)num2 * -1420448778);
						continue;
					}
					case 9u:
						playerStates = _playerStates;
						num3 = 0;
						num = 575554806;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (playerState.State == State.Playing)
						{
							num5 = 836077651;
							num6 = 836077651;
						}
						else
						{
							num5 = 1432738441;
							num6 = 1432738441;
						}
						num = num5 ^ ((int)num2 * -66504902);
						continue;
					}
					case 7u:
						result = true;
						num = ((int)num2 * -981656762) ^ -310340670;
						continue;
					case 6u:
					{
						int num4;
						if (num3 < playerStates.Length)
						{
							num = 172257858;
							num4 = 172257858;
						}
						else
						{
							num = 133975878;
							num4 = 133975878;
						}
						continue;
					}
					case 4u:
						num = ((int)num2 * -958939001) ^ 0x5B442BE;
						continue;
					case 3u:
						num3++;
						num = 1168881245;
						continue;
					case 2u:
						result = true;
						num = ((int)num2 * -1911538829) ^ 0x7123C5C0;
						continue;
					case 1u:
						finished = _finished;
						num = (int)((num2 * 1271326018) ^ 0xF0BA071);
						continue;
					case 0u:
						result = false;
						num = (int)(num2 * 1820688006) ^ -98590156;
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
		bool flag = default(bool);
		int num6 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		int count = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1289386164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6039FC50u) % 19u)
				{
				case 18u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -118312769;
						num8 = -118312769;
					}
					else
					{
						num7 = -997397494;
						num8 = -997397494;
					}
					num = num7 ^ (int)(num2 * 916990250);
					continue;
				}
				case 17u:
					Players[num6] = Player.Deserialize(jSONNode[num6]);
					num6++;
					num = 710433778;
					continue;
				case 16u:
					num3++;
					num = (int)((num2 * 1498074065) ^ 0xFE11861);
					continue;
				case 15u:
					_playerStates = new PlayerState[count];
					num3 = 0;
					num = (int)((num2 * 1218582951) ^ 0x5FF3CB1A);
					continue;
				case 14u:
					num6 = 0;
					num = (int)((num2 * 919310665) ^ 0x118AC9D6);
					continue;
				case 13u:
					Rules = Rules.Deserialize(json["rules"]);
					num = ((int)num2 * -443205370) ^ -612856853;
					continue;
				case 12u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					num = (int)(num2 * 707022126) ^ -1114096086;
					continue;
				case 10u:
					Players = new Player[count];
					num = ((int)num2 * -667981036) ^ 0x7A5A5726;
					continue;
				case 9u:
					_buffer = buffer;
					num = (int)(num2 * 836705607) ^ -878030463;
					continue;
				case 8u:
					flag2 = num6 < count;
					num = 408661727;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = 1376846978;
						num5 = 1376846978;
					}
					else
					{
						num4 = 2145500688;
						num5 = 2145500688;
					}
					num = num4 ^ ((int)num2 * -1637324061);
					continue;
				}
				case 5u:
					count = jSONNode.Count;
					num = ((int)num2 * -1130129197) ^ -1169675051;
					continue;
				case 4u:
					_playerStates[num3] = new PlayerState();
					num = 1934192592;
					continue;
				case 3u:
					_dice = new Dice();
					num = ((int)num2 * -915048180) ^ 0x28F86C9;
					continue;
				case 2u:
					flag = num3 < count;
					num = 987534470;
					continue;
				case 1u:
					num = ((int)num2 * -1813735850) ^ 0x525EF90A;
					continue;
				case 0u:
					jSONNode = json["players"];
					num = (int)(num2 * 1222777906) ^ -970514346;
					continue;
				default:
					return;
				case 6u:
					break;
				case 11u:
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
			int num = 1114046260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46A67531u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -423307485) ^ -828410670;
					continue;
				case 8u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -499259773) ^ -355477112;
					continue;
				case 7u:
					_finished = false;
					num = ((int)num2 * -1962038060) ^ 0x7BA36F4D;
					continue;
				case 6u:
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 819837572) ^ 0x87BBFB8);
					continue;
				case 5u:
					_currentTurn = 0;
					num = (int)((num2 * 1390974251) ^ 0x6C893021);
					continue;
				case 4u:
					Losers.Clear();
					num = ((int)num2 * -2085325384) ^ 0x1B1D2430;
					continue;
				case 3u:
					num = ((int)num2 * -334688335) ^ 0x4544C0BC;
					continue;
				case 0u:
					_currentChanceIndex = -1;
					num = (int)(num2 * 299644401) ^ -1758726149;
					continue;
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

	public void PlanningState()
	{
		int num6 = default(int);
		PlayerState playerState = default(PlayerState);
		int planningCardsCount = default(int);
		bool flag = default(bool);
		int num5 = default(int);
		Player player = default(Player);
		while (true)
		{
			int num = 425307854;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10FCAB05u) % 29u)
				{
				case 28u:
					num = (int)(num2 * 1804827646) ^ -1747161501;
					continue;
				case 27u:
				{
					int num11;
					if (num6 > 0)
					{
						num = 956021715;
						num11 = 956021715;
					}
					else
					{
						num = 1786472722;
						num11 = 1786472722;
					}
					continue;
				}
				case 26u:
					num = (int)((num2 * 2055413758) ^ 0x492ED44D);
					continue;
				case 25u:
					num6 = 0;
					num = 1383178221;
					continue;
				case 24u:
					playerState.Sprint = 0;
					num = (int)(num2 * 1217814874) ^ -1352197365;
					continue;
				case 23u:
					playerState.Sprint = -1;
					num = ((int)num2 * -615195278) ^ -2087656360;
					continue;
				case 22u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num = 52731564;
					continue;
				case 21u:
					flag = num5 < Players.Length;
					num = 281501530;
					continue;
				case 19u:
					num = (int)((num2 * 1497619796) ^ 0x50E6A1D5);
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if (!player.UseOneMorePlanningSprint)
					{
						num9 = 217199993;
						num10 = 217199993;
					}
					else
					{
						num9 = 987299872;
						num10 = 987299872;
					}
					num = num9 ^ (int)(num2 * 226089621);
					continue;
				}
				case 17u:
					num5 = 0;
					num = ((int)num2 * -1635337082) ^ -409841890;
					continue;
				case 16u:
				{
					int num7;
					int num8;
					if (planningCardsCount == 0)
					{
						num7 = -1165756290;
						num8 = -1165756290;
					}
					else
					{
						num7 = -523736538;
						num8 = -523736538;
					}
					num = num7 ^ ((int)num2 * -677036585);
					continue;
				}
				case 15u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num = (int)((num2 * 622589035) ^ 0x6BF3003B);
					continue;
				case 14u:
					playerState.Sprint = 1;
					num = ((int)num2 * -1930547640) ^ -1469262302;
					continue;
				case 13u:
					num = ((int)num2 * -1414710911) ^ -817665955;
					continue;
				case 12u:
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					num = (int)(num2 * 1532378500) ^ -1135146968;
					continue;
				case 11u:
					num5++;
					num = ((int)num2 * -1616720087) ^ 0x3E84F768;
					continue;
				case 10u:
					player = Players[num5];
					num = 1556557259;
					continue;
				case 9u:
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num = (int)((num2 * 1514244733) ^ 0x2CB7EE9D);
					continue;
				case 8u:
					playerState = _playerStates[num5];
					num = ((int)num2 * -1781415648) ^ 0x3FB0A91E;
					continue;
				case 7u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num = ((int)num2 * -1447401925) ^ -2010424575;
					continue;
				case 6u:
					num6 = 0;
					num = ((int)num2 * -737523495) ^ -1812103019;
					continue;
				case 5u:
					planningCardsCount = player.PlanningCardsCount;
					num = ((int)num2 * -339529813) ^ 0x536B24BE;
					continue;
				case 3u:
					num = 24795327;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -194275416;
						num4 = -194275416;
					}
					else
					{
						num3 = -1856990682;
						num4 = -1856990682;
					}
					num = num3 ^ ((int)num2 * -225362277);
					continue;
				}
				case 1u:
					num = 28926919;
					continue;
				case 0u:
					num = ((int)num2 * -741380482) ^ 0x794AC13F;
					continue;
				default:
					return;
				case 4u:
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
			int num = -1844383301;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x893F8D0Cu) % 12u)
				{
				case 11u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = -2057971710;
					continue;
				case 10u:
					num = ((int)num2 * -322659315) ^ -1356043785;
					continue;
				case 9u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 860904889) ^ 0x696408F1);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (_currentTurn <= 0)
					{
						num5 = -421612765;
						num6 = -421612765;
					}
					else
					{
						num5 = -801662867;
						num6 = -801662867;
					}
					num = num5 ^ ((int)num2 * -746619735);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1446863079;
						num4 = 1446863079;
					}
					else
					{
						num3 = 69256247;
						num4 = 69256247;
					}
					num = num3 ^ ((int)num2 * -1572024309);
					continue;
				}
				case 5u:
					_currentPlayer = 0;
					num = ((int)num2 * -1877245721) ^ -284963789;
					continue;
				case 4u:
					num = (int)((num2 * 1003483960) ^ 0x95CF617);
					continue;
				case 3u:
					_currentPlayer++;
					num = ((int)num2 * -1944191514) ^ 0x432FA47E;
					continue;
				case 1u:
					PlayerTurn(_currentPlayer);
					num = -2044367797;
					continue;
				case 0u:
					flag = _currentPlayer >= Players.Length;
					num = (int)((num2 * 1237290942) ^ 0x2517CB6E);
					continue;
				default:
					return;
				case 2u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		int num5 = default(int);
		bool flag = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag2 = default(bool);
		bool flag12 = default(bool);
		bool flag6 = default(bool);
		int num15 = default(int);
		bool flag9 = default(bool);
		bool flag4 = default(bool);
		int num13 = default(int);
		Card card = default(Card);
		bool flag5 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		int num14 = default(int);
		bool flag10 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		bool flag11 = default(bool);
		bool flag13 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -2125782015;
			while (true)
			{
				uint num2;
				int num6;
				int num16;
				switch ((num2 = (uint)num ^ 0x98BAF9FBu) % 83u)
				{
				case 82u:
					num = -900002529;
					continue;
				case 81u:
					num5++;
					num = -1062663780;
					continue;
				case 80u:
					num = (int)(num2 * 710479872) ^ -1130042549;
					continue;
				case 79u:
					num5 = 0;
					num = ((int)num2 * -996958268) ^ 0x2D873F04;
					continue;
				case 78u:
					flag = playerState.Sprint < 0;
					num = -69578324;
					continue;
				case 77u:
					num = (int)(num2 * 765949269) ^ -2100092482;
					continue;
				case 76u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -325869564;
						num8 = -325869564;
					}
					else
					{
						num7 = -1059814075;
						num8 = -1059814075;
					}
					num = num7 ^ (int)(num2 * 1588612430);
					continue;
				}
				case 75u:
					num = (int)((num2 * 11297555) ^ 0x2A61740F);
					continue;
				case 74u:
					num = (int)(num2 * 1928855241) ^ -1748770280;
					continue;
				case 73u:
				{
					int num19;
					int num20;
					if (!flag12)
					{
						num19 = -2022957331;
						num20 = -2022957331;
					}
					else
					{
						num19 = -424053711;
						num20 = -424053711;
					}
					num = num19 ^ ((int)num2 * -265908363);
					continue;
				}
				case 72u:
					flag12 = playerState.Sprint > Rules.SprintCount;
					num = -2031050026;
					continue;
				case 71u:
					num = -585557498;
					continue;
				case 70u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -763372323) ^ -488549630;
						continue;
					}
					num6 = 0;
					goto IL_013b;
				case 69u:
				{
					int num32;
					int num33;
					if (flag6)
					{
						num32 = -1644908547;
						num33 = -1644908547;
					}
					else
					{
						num32 = -653849439;
						num33 = -653849439;
					}
					num = num32 ^ ((int)num2 * -1130119323);
					continue;
				}
				case 68u:
					Print(playerState.State);
					num = ((int)num2 * -493443027) ^ -1779684319;
					continue;
				case 67u:
					num = -2136143828;
					continue;
				case 66u:
					num = (int)((num2 * 1637428776) ^ 0x7F2A76CC);
					continue;
				case 65u:
					_finished = true;
					num15 = 0;
					num = ((int)num2 * -1601457811) ^ 0x676FC659;
					continue;
				case 64u:
					num = ((int)num2 * -1852508641) ^ -261513017;
					continue;
				case 63u:
					num = (int)(num2 * 1996128580) ^ -2014839891;
					continue;
				case 62u:
					Losers.Add(num15);
					num = (int)((num2 * 849669270) ^ 0x151A2DB4);
					continue;
				case 61u:
					num = ((int)num2 * -1723271375) ^ -764622071;
					continue;
				case 60u:
				{
					int num29;
					if (!Losers.Contains(num15))
					{
						num = -1146588642;
						num29 = -1146588642;
					}
					else
					{
						num = -342672998;
						num29 = -342672998;
					}
					continue;
				}
				case 59u:
					num = (int)((num2 * 2137314951) ^ 0x23174D86);
					continue;
				case 58u:
					num = (int)(num2 * 415745043) ^ -1645586389;
					continue;
				case 57u:
					num = (int)(num2 * 1268039185) ^ -1750217132;
					continue;
				case 56u:
					num15++;
					num = -1794875083;
					continue;
				case 55u:
					num = (int)((num2 * 983519000) ^ 0x48B390AA);
					continue;
				case 54u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)(num2 * 836758991) ^ -1132387520;
					continue;
				case 53u:
					num = ((int)num2 * -2092814165) ^ 0x3A5916B7;
					continue;
				case 52u:
					num = (int)(num2 * 1488194364) ^ -2063870049;
					continue;
				case 51u:
				{
					int num21;
					int num22;
					if (flag9)
					{
						num21 = 456971571;
						num22 = 456971571;
					}
					else
					{
						num21 = 449742557;
						num22 = 449742557;
					}
					num = num21 ^ (int)(num2 * 1731495973);
					continue;
				}
				case 50u:
					num = -1627664260;
					continue;
				case 49u:
				{
					int num11;
					int num12;
					if (flag4)
					{
						num11 = 552995931;
						num12 = 552995931;
					}
					else
					{
						num11 = 1690673385;
						num12 = 1690673385;
					}
					num = num11 ^ ((int)num2 * -1811828065);
					continue;
				}
				case 48u:
					num13 = card.Impact - player.PlannedForCard(card.Type);
					flag5 = num13 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -812874821) ^ -555226510;
					continue;
				case 47u:
				{
					int num36;
					int num37;
					if (num15 != playerIndex)
					{
						num36 = -1041603669;
						num37 = -1041603669;
					}
					else
					{
						num36 = -1616258393;
						num37 = -1616258393;
					}
					num = num36 ^ ((int)num2 * -1360793040);
					continue;
				}
				case 46u:
					num = -462582789;
					continue;
				case 45u:
					playerState2.Resources -= Game.smethod_3(0, num14 - Players[num5].PlannedForCard(card.Type));
					num = (int)(num2 * 543420480) ^ -1065795789;
					continue;
				case 44u:
				{
					int num34;
					int num35;
					if (!flag10)
					{
						num34 = 1406807367;
						num35 = 1406807367;
					}
					else
					{
						num34 = 2020108460;
						num35 = 2020108460;
					}
					num = num34 ^ (int)(num2 * 1670304588);
					continue;
				}
				case 43u:
					num6 = ((card.Type == 4) ? 1 : 0);
					goto IL_013b;
				case 42u:
					num14 = Game.smethod_3(0, num13);
					num = (int)(num2 * 1935253331) ^ -1599474854;
					continue;
				case 41u:
					flag5 = true;
					Print("CARD: none, advance");
					num = (int)((num2 * 1158305189) ^ 0x7DE51AA6);
					continue;
				case 40u:
				{
					int num30;
					int num31;
					if (!onlyOneWinner)
					{
						num30 = -1096331057;
						num31 = -1096331057;
					}
					else
					{
						num30 = -1636276065;
						num31 = -1636276065;
					}
					num = num30 ^ (int)(num2 * 984682723);
					continue;
				}
				case 39u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag9 ? "ALL " : "", flag7 ? "receives" : "pays", Game.smethod_4(num14), flag5 ? "advance" : "stay");
					num = -319960531;
					continue;
				case 38u:
				{
					int num27;
					int num28;
					if (!flag8)
					{
						num27 = -836194475;
						num28 = -836194475;
					}
					else
					{
						num27 = -1200137213;
						num28 = -1200137213;
					}
					num = num27 ^ (int)(num2 * 63823707);
					continue;
				}
				case 36u:
					playerState.Sprint++;
					num = (int)((num2 * 147684249) ^ 0x738296F8);
					continue;
				case 35u:
					num = -5645346;
					continue;
				case 34u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 1420625780) ^ 0x700F3E57);
					continue;
				case 33u:
					num = (int)(num2 * 1152716142) ^ -1670847643;
					continue;
				case 32u:
					num = (int)(num2 * 1187116936) ^ -136219034;
					continue;
				case 31u:
					flag11 = !Losers.Contains(playerIndex);
					num = (int)(num2 * 939874760) ^ -2027201807;
					continue;
				case 30u:
					flag4 = num5 < _playerStates.Length;
					num = -1925435286;
					continue;
				case 29u:
					flag5 = false;
					num = -1469989071;
					continue;
				case 28u:
				{
					int num25;
					int num26;
					if (flag13)
					{
						num25 = 324630593;
						num26 = 324630593;
					}
					else
					{
						num25 = 1266289829;
						num26 = 1266289829;
					}
					num = num25 ^ (int)(num2 * 1318650254);
					continue;
				}
				case 27u:
					flag13 = playerState2.Resources >= 0;
					num = (int)(num2 * 1361166426) ^ -992450958;
					continue;
				case 26u:
				{
					int num23;
					int num24;
					if (playerState.State != 0)
					{
						num23 = -473956108;
						num24 = -473956108;
					}
					else
					{
						num23 = -197261501;
						num24 = -197261501;
					}
					num = num23 ^ (int)(num2 * 1217424406);
					continue;
				}
				case 25u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)(num2 * 1778139671) ^ -1701113902;
					continue;
				case 24u:
				{
					int num17;
					int num18;
					if (flag11)
					{
						num17 = -952590928;
						num18 = -952590928;
					}
					else
					{
						num17 = -1862568848;
						num18 = -1862568848;
					}
					num = num17 ^ (int)(num2 * 1053614144);
					continue;
				}
				case 23u:
					num = (int)((num2 * 2126549283) ^ 0x4F16E4BD);
					continue;
				case 22u:
					flag10 = flag5;
					num = -151823021;
					continue;
				case 21u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -2005362724;
					continue;
				}
				case 20u:
					playerState = _playerStates[playerIndex];
					num = ((int)num2 * -1967016541) ^ 0x7AF4217A;
					continue;
				case 19u:
					flag8 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -1975771271;
					continue;
				case 18u:
					card = DrawCard();
					flag7 = card.Impact < 0;
					num = -1407288746;
					continue;
				case 17u:
					playerState2.State = State.Lose;
					flag2 = !Losers.Contains(num5);
					num = -19069639;
					continue;
				case 16u:
					flag6 = num15 < _playerStates.Length;
					num = -1749714093;
					continue;
				case 15u:
					flag5 = true;
					num14 = card.Impact;
					num = ((int)num2 * -1032863385) ^ 0x58A21A6B;
					continue;
				case 14u:
					num = -1657938770;
					continue;
				case 12u:
					playerState2 = _playerStates[num5];
					num = ((int)num2 * -1295688771) ^ 0x60A728B1;
					continue;
				case 11u:
					playerState.Resources -= num14;
					flag3 = playerState.Resources < 0;
					num = (int)((num2 * 495376536) ^ 0x3F806B47);
					continue;
				case 10u:
					Losers.Add(num5);
					num = ((int)num2 * -1209012965) ^ -979215007;
					continue;
				case 9u:
					num = -848496344;
					continue;
				case 8u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)(num2 * 1541669777) ^ -1547311371;
					continue;
				case 7u:
					num = ((int)num2 * -107337851) ^ -310132640;
					continue;
				case 6u:
					playerState.State = State.Lose;
					num = (int)((num2 * 1980409813) ^ 0x4BC71CD3);
					continue;
				case 5u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = -1273939107;
						num10 = -1273939107;
					}
					else
					{
						num9 = -218564582;
						num10 = -218564582;
					}
					num = num9 ^ (int)(num2 * 1628944645);
					continue;
				}
				case 4u:
					num = ((int)num2 * -297272691) ^ 0x48A8E45C;
					continue;
				case 3u:
					num = (int)(num2 * 288875453) ^ -1787024790;
					continue;
				case 2u:
					num = -1052232914;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1439530301;
						num4 = -1439530301;
					}
					else
					{
						num3 = -713859294;
						num4 = -713859294;
					}
					num = num3 ^ ((int)num2 * -1153518185);
					continue;
				}
				case 0u:
					num = (int)(num2 * 25321667) ^ -1229903418;
					continue;
				default:
					return;
				case 13u:
					break;
				case 37u:
					return;
					IL_013b:
					flag9 = (byte)num6 != 0;
					if (!flag7)
					{
						num = -2039142528;
						num16 = -2039142528;
					}
					else
					{
						num = -1490535887;
						num16 = -1490535887;
					}
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
			int num = 314791188;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE02C2C7u) % 10u)
				{
				case 9u:
					result = card;
					num = (int)((num2 * 474541650) ^ 0x52B8F8E5);
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1777083945;
						num4 = -1777083945;
					}
					else
					{
						num3 = -519887190;
						num4 = -519887190;
					}
					num = num3 ^ ((int)num2 * -750551679);
					continue;
				}
				case 6u:
					num = (int)(num2 * 1700157690) ^ -726673038;
					continue;
				case 5u:
					ShuffleCards();
					num = ((int)num2 * -1584198048) ^ 0x7620482D;
					continue;
				case 4u:
					card = _deck[0];
					num = 205546728;
					continue;
				case 3u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -785985030) ^ -89211794;
					continue;
				case 2u:
					num = ((int)num2 * -1979983734) ^ 0x2C864399;
					continue;
				case 1u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 784878847) ^ 0x520E7758);
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
		bool flag = default(bool);
		int num5 = default(int);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = 831515000;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x148FD7B4u) % 9u)
				{
				case 8u:
					flag = num5 < _playerStates.Length;
					num = 336851177;
					continue;
				case 6u:
					result = text;
					num = ((int)num2 * -1160769450) ^ 0x3A4A059A;
					continue;
				case 4u:
					num = (int)((num2 * 516528455) ^ 0x31754DB0);
					continue;
				case 3u:
					text = "";
					num = (int)((num2 * 1451639722) ^ 0x4F636073);
					continue;
				case 2u:
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
					num = 424791298;
					continue;
				}
				case 1u:
					num5 = 0;
					num = ((int)num2 * -1129641843) ^ -2094595015;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -541720686;
						num4 = -541720686;
					}
					else
					{
						num3 = -751225868;
						num4 = -751225868;
					}
					num = num3 ^ (int)(num2 * 1722729594);
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
		string result = ToString(initial: false);
		while (true)
		{
			int num = 210281439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2719D8BDu) % 3u)
				{
				case 1u:
					goto IL_000a;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000a:
				num = (int)((num2 * 951512345) ^ 0x69B2FABB);
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = 1391450841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x210DB830u) % 4u)
				{
				case 2u:
					Game.smethod_8(_buffer, string_);
					num = ((int)num2 * -656708017) ^ -758967563;
					continue;
				case 1u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = ((int)num2 * -1519059744) ^ 0x23B86712;
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
