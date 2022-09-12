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
			PlayerState playerState = default(PlayerState);
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool result = default(bool);
			while (true)
			{
				int num = 2033545080;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4F7E83ABu) % 15u)
					{
					case 14u:
						playerState = playerStates[num3];
						num = 1163587350;
						continue;
					case 13u:
					{
						int num7;
						int num8;
						if (playerState.State == State.Playing)
						{
							num7 = -1785584957;
							num8 = -1785584957;
						}
						else
						{
							num7 = -1595018914;
							num8 = -1595018914;
						}
						num = num7 ^ ((int)num2 * -1478094638);
						continue;
					}
					case 12u:
						num3 = 0;
						num = (int)((num2 * 367699734) ^ 0x2B3D2B1E);
						continue;
					case 11u:
						num = ((int)num2 * -2123986997) ^ -6601252;
						continue;
					case 10u:
						result = false;
						num = (int)(num2 * 1902272716) ^ -389853867;
						continue;
					case 8u:
						num = ((int)num2 * -589276051) ^ 0x775089D;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (finished)
						{
							num5 = -1875694114;
							num6 = -1875694114;
						}
						else
						{
							num5 = -1233494021;
							num6 = -1233494021;
						}
						num = num5 ^ ((int)num2 * -183889656);
						continue;
					}
					case 5u:
						playerStates = _playerStates;
						num = 2135035883;
						continue;
					case 4u:
					{
						int num4;
						if (num3 >= playerStates.Length)
						{
							num = 532861248;
							num4 = 532861248;
						}
						else
						{
							num = 942391134;
							num4 = 942391134;
						}
						continue;
					}
					case 3u:
						result = true;
						num = (int)((num2 * 1292861390) ^ 0x670BCE08);
						continue;
					case 2u:
						num3++;
						num = 1493248780;
						continue;
					case 1u:
						num = (int)(num2 * 708462035) ^ -1277553720;
						continue;
					case 0u:
						result = true;
						num = ((int)num2 * -331061428) ^ 0x419DD69D;
						continue;
					case 9u:
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
		bool flag2 = default(bool);
		int num6 = default(int);
		int count = default(int);
		int num5 = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -1356666935;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA2E4DB2u) % 19u)
				{
				case 18u:
					flag2 = num6 < count;
					num = -853277526;
					continue;
				case 17u:
					Players[num5] = Player.Deserialize(jSONNode[num5]);
					num = -1700649602;
					continue;
				case 16u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1832748420;
						num8 = -1832748420;
					}
					else
					{
						num7 = -2109508245;
						num8 = -2109508245;
					}
					num = num7 ^ ((int)num2 * -2106665052);
					continue;
				}
				case 15u:
					_dice = new Dice();
					num = (int)((num2 * 294061082) ^ 0x1CA761CC);
					continue;
				case 14u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -1899819991) ^ -1112657273;
					continue;
				case 12u:
					_buffer = buffer;
					num = ((int)num2 * -6830045) ^ 0x4E829FD4;
					continue;
				case 11u:
					num = ((int)num2 * -2003303393) ^ -1912657872;
					continue;
				case 10u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					Players = new Player[count];
					num = (int)(num2 * 2004259559) ^ -101739936;
					continue;
				case 9u:
					num = ((int)num2 * -2086164698) ^ -537326150;
					continue;
				case 8u:
					num6++;
					num = ((int)num2 * -258728833) ^ -1712995280;
					continue;
				case 7u:
					flag = num5 < count;
					num = -1833073704;
					continue;
				case 6u:
					num5 = 0;
					num = (int)(num2 * 676643797) ^ -28880671;
					continue;
				case 5u:
					_playerStates[num6] = new PlayerState();
					num = -372097255;
					continue;
				case 4u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = ((int)num2 * -382534685) ^ 0x7620EA1C;
					continue;
				case 3u:
					num6 = 0;
					num = ((int)num2 * -1812785726) ^ 0x741FCDD1;
					continue;
				case 2u:
					num5++;
					num = ((int)num2 * -490462312) ^ -1125768547;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -941256485;
						num4 = -941256485;
					}
					else
					{
						num3 = -1813310331;
						num4 = -1813310331;
					}
					num = num3 ^ (int)(num2 * 1159019760);
					continue;
				}
				default:
					return;
				case 13u:
					break;
				case 0u:
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
			int num = 766595157;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4B81F4E4u) % 8u)
				{
				case 7u:
					Losers.Clear();
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1036738096) ^ 0x6279BEB1;
					continue;
				case 5u:
					_currentTurn = 0;
					num = (int)(num2 * 531143540) ^ -437000092;
					continue;
				case 4u:
					_finished = false;
					num = (int)(num2 * 2004883010) ^ -1360127396;
					continue;
				case 2u:
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 169077065) ^ 0x53AC3FC8);
					continue;
				case 1u:
					Winners.Clear();
					num = (int)((num2 * 1158832922) ^ 0x5565CCB9);
					continue;
				case 0u:
					_currentChanceIndex = -1;
					num = (int)((num2 * 1491714325) ^ 0x72AA448E);
					continue;
				default:
					return;
				case 3u:
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
		PlayerState playerState = default(PlayerState);
		int planningCardsCount = default(int);
		int num3 = default(int);
		int num5 = default(int);
		Player player = default(Player);
		bool flag = default(bool);
		while (true)
		{
			int num = 1778163005;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73036FF4u) % 28u)
				{
				case 27u:
					num = 212694422;
					continue;
				case 26u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = 1905080805;
					continue;
				case 25u:
					num5 = 0;
					num = (int)((num2 * 885158365) ^ 0x3A23C88C);
					continue;
				case 24u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = ((int)num2 * -257076564) ^ 0x5E0E321;
					continue;
				case 23u:
					playerState.Sprint = -1;
					num = ((int)num2 * -1538637741) ^ -85618035;
					continue;
				case 21u:
					player = Players[num5];
					num = 2087591612;
					continue;
				case 20u:
				{
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					int num6;
					int num7;
					if (player.UseOneMorePlanningSprint)
					{
						num6 = 826369122;
						num7 = 826369122;
					}
					else
					{
						num6 = 325095750;
						num7 = 325095750;
					}
					num = num6 ^ ((int)num2 * -596193724);
					continue;
				}
				case 19u:
					num5++;
					num = ((int)num2 * -411657489) ^ 0x29F98856;
					continue;
				case 18u:
				{
					num3 = 0;
					int num10;
					int num11;
					if (planningCardsCount == 0)
					{
						num10 = -1015843720;
						num11 = -1015843720;
					}
					else
					{
						num10 = -1318475066;
						num11 = -1318475066;
					}
					num = num10 ^ (int)(num2 * 2038423982);
					continue;
				}
				case 17u:
					num = (int)(num2 * 1965846244) ^ -494074029;
					continue;
				case 16u:
					planningCardsCount = player.PlanningCardsCount;
					num = ((int)num2 * -1895153096) ^ 0x630BED86;
					continue;
				case 15u:
					playerState.Resources = Rules.InitialResources;
					num = (int)((num2 * 16180383) ^ 0x127680A4);
					continue;
				case 14u:
					num = ((int)num2 * -389686574) ^ -1676680302;
					continue;
				case 13u:
					num = (int)((num2 * 1052288590) ^ 0x4F26CE0D);
					continue;
				case 12u:
					num3 = 0;
					num = 554683155;
					continue;
				case 10u:
					num = 1909002144;
					continue;
				case 9u:
					num = (int)((num2 * 705028594) ^ 0x4E7798B9);
					continue;
				case 8u:
					playerState = _playerStates[num5];
					playerState.Sprint = 0;
					num = ((int)num2 * -292948028) ^ -934041285;
					continue;
				case 7u:
					flag = num5 < Players.Length;
					num = 865972567;
					continue;
				case 6u:
					num = (int)(num2 * 16132950) ^ -193178125;
					continue;
				case 5u:
					playerState.State = State.Playing;
					num = (int)((num2 * 47271496) ^ 0x111DB174);
					continue;
				case 4u:
					playerState.Sprint = 1;
					num = ((int)num2 * -1585364456) ^ 0x13EA25C6;
					continue;
				case 3u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -266531682;
						num9 = -266531682;
					}
					else
					{
						num8 = -566923575;
						num9 = -566923575;
					}
					num = num8 ^ (int)(num2 * 333706968);
					continue;
				}
				case 2u:
				{
					int num4;
					if (num3 > 0)
					{
						num = 957304992;
						num4 = 957304992;
					}
					else
					{
						num = 1390771140;
						num4 = 1390771140;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -1945103477) ^ 0x2BA941B4;
					continue;
				case 0u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = (int)((num2 * 1374413965) ^ 0x6B460C0D);
					continue;
				default:
					return;
				case 11u:
					break;
				case 22u:
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
			int num = 649882019;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27C56D37u) % 12u)
				{
				case 11u:
					num = (int)(num2 * 158518076) ^ -1456819408;
					continue;
				case 10u:
					num = (int)(num2 * 1596388831) ^ -855962502;
					continue;
				case 9u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 1058646737) ^ 0x5529E7D6);
					continue;
				case 8u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 1971931326;
					continue;
				case 7u:
					PlayerTurn(_currentPlayer);
					num = 593066258;
					continue;
				case 6u:
					_currentPlayer = 0;
					flag2 = _currentTurn > 0;
					num = (int)((num2 * 1431361279) ^ 0x498F73F2);
					continue;
				case 5u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)((num2 * 1007396492) ^ 0x71CA47AF);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1274048424;
						num6 = 1274048424;
					}
					else
					{
						num5 = 420432337;
						num6 = 420432337;
					}
					num = num5 ^ (int)(num2 * 1836111723);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -1958927750;
						num4 = -1958927750;
					}
					else
					{
						num3 = -1973934549;
						num4 = -1973934549;
					}
					num = num3 ^ (int)(num2 * 1472289515);
					continue;
				}
				case 0u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -1913281452) ^ -875153527;
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

	private void PlayerTurn(int playerIndex)
	{
		int num8 = default(int);
		bool flag12 = default(bool);
		int num3 = default(int);
		bool flag6 = default(bool);
		PlayerState playerState = default(PlayerState);
		Player player = default(Player);
		bool flag7 = default(bool);
		bool flag10 = default(bool);
		bool flag3 = default(bool);
		bool flag14 = default(bool);
		PlayerState playerState3 = default(PlayerState);
		int num19 = default(int);
		Card card = default(Card);
		bool flag5 = default(bool);
		bool flag13 = default(bool);
		bool flag9 = default(bool);
		bool flag11 = default(bool);
		bool flag = default(bool);
		bool flag8 = default(bool);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -139107927;
			while (true)
			{
				uint num2;
				int num9;
				switch ((num2 = (uint)num ^ 0xFBB66A98u) % 83u)
				{
				case 82u:
					num = ((int)num2 * -331561) ^ 0x47C0C1A1;
					continue;
				case 81u:
					num8++;
					num = -358501854;
					continue;
				case 80u:
					num = -13495667;
					continue;
				case 79u:
					flag12 = num3 == playerIndex;
					num = (int)(num2 * 82859614) ^ -1031350385;
					continue;
				case 78u:
					num = (int)((num2 * 2041931375) ^ 0x43A85D5F);
					continue;
				case 77u:
				{
					int num12;
					int num13;
					if (flag6)
					{
						num12 = 593527709;
						num13 = 593527709;
					}
					else
					{
						num12 = 1768455994;
						num13 = 1768455994;
					}
					num = num12 ^ ((int)num2 * -1141250049);
					continue;
				}
				case 76u:
					playerState.Sprint++;
					num = ((int)num2 * -509566028) ^ -2041901145;
					continue;
				case 75u:
					num = ((int)num2 * -257008006) ^ -566381249;
					continue;
				case 74u:
					num8 = 0;
					num = (int)(num2 * 149004624) ^ -893052542;
					continue;
				case 73u:
					player = Players[playerIndex];
					playerState = _playerStates[playerIndex];
					num = (int)(num2 * 1031334074) ^ -2057351337;
					continue;
				case 72u:
					num = -497762418;
					continue;
				case 71u:
				{
					int num30;
					int num31;
					if (flag7)
					{
						num30 = 1517149062;
						num31 = 1517149062;
					}
					else
					{
						num30 = 1995304434;
						num31 = 1995304434;
					}
					num = num30 ^ ((int)num2 * -1053925779);
					continue;
				}
				case 70u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)(num2 * 32063331) ^ -393525252;
					continue;
				case 69u:
					flag10 = flag3;
					num = -503238376;
					continue;
				case 68u:
					Print("Still planning");
					num = ((int)num2 * -800033166) ^ -795914717;
					continue;
				case 67u:
					flag7 = playerState.Resources < 0;
					num = ((int)num2 * -510588583) ^ -1620280177;
					continue;
				case 66u:
					num = (int)(num2 * 1788919959) ^ -1884005892;
					continue;
				case 65u:
				{
					int num37;
					int num38;
					if (flag14)
					{
						num37 = 757132197;
						num38 = 757132197;
					}
					else
					{
						num37 = 1288520890;
						num38 = 1288520890;
					}
					num = num37 ^ (int)(num2 * 1245947572);
					continue;
				}
				case 64u:
					num = ((int)num2 * -1342512830) ^ 0x539BCA07;
					continue;
				case 63u:
					flag3 = false;
					num = -1713013555;
					continue;
				case 62u:
					playerState3.State = State.Lose;
					num = -432865659;
					continue;
				case 61u:
					num = -183477558;
					continue;
				case 60u:
					playerState3 = _playerStates[num8];
					playerState3.Resources -= Game.smethod_3(0, num19 - Players[num8].PlannedForCard(card.Type));
					num = ((int)num2 * -2102497324) ^ 0x30AE5852;
					continue;
				case 59u:
				{
					int num33;
					int num34;
					if (!flag5)
					{
						num33 = -342622458;
						num34 = -342622458;
					}
					else
					{
						num33 = -2037339721;
						num34 = -2037339721;
					}
					num = num33 ^ ((int)num2 * -738932267);
					continue;
				}
				case 58u:
					Losers.Add(playerIndex);
					num = (int)(num2 * 1042435602) ^ -565475259;
					continue;
				case 57u:
					num = ((int)num2 * -907280191) ^ -186448359;
					continue;
				case 56u:
				{
					int num28;
					int num29;
					if (!flag13)
					{
						num28 = -1157798819;
						num29 = -1157798819;
					}
					else
					{
						num28 = -1251088152;
						num29 = -1251088152;
					}
					num = num28 ^ (int)(num2 * 741399547);
					continue;
				}
				case 55u:
				{
					int num24;
					int num25;
					if (playerState3.Resources >= 0)
					{
						num24 = -735152117;
						num25 = -735152117;
					}
					else
					{
						num24 = -339555806;
						num25 = -339555806;
					}
					num = num24 ^ ((int)num2 * -284143557);
					continue;
				}
				case 54u:
					num = ((int)num2 * -1840194149) ^ -883792364;
					continue;
				case 53u:
				{
					int num18;
					if (_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = -1698292546;
						num18 = -1698292546;
					}
					else
					{
						num = -1614792682;
						num18 = -1614792682;
					}
					continue;
				}
				case 52u:
					num3 = 0;
					num = ((int)num2 * -1517039259) ^ 0x247D9AA;
					continue;
				case 51u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = -736456861;
					continue;
				}
				case 50u:
					flag5 = !Losers.Contains(num8);
					num = (int)(num2 * 961069714) ^ -753488877;
					continue;
				case 49u:
				{
					int num6;
					int num7;
					if (!Rules.OnlyOneWinner)
					{
						num6 = 1231599404;
						num7 = 1231599404;
					}
					else
					{
						num6 = 323496039;
						num7 = 323496039;
					}
					num = num6 ^ (int)(num2 * 32662625);
					continue;
				}
				case 48u:
					flag3 = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -1326301233) ^ -824061468;
					continue;
				case 47u:
				{
					int num35;
					int num36;
					if (!flag10)
					{
						num35 = 1679645576;
						num36 = 1679645576;
					}
					else
					{
						num35 = 452708560;
						num36 = 452708560;
					}
					num = num35 ^ ((int)num2 * -1300919727);
					continue;
				}
				case 46u:
					num = ((int)num2 * -1555203341) ^ 0x764573AF;
					continue;
				case 45u:
					num = (int)((num2 * 552111235) ^ 0x2C83FD44);
					continue;
				case 43u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -2119308692) ^ 0x69969D91;
					continue;
				case 42u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag9 ? "ALL " : "", flag11 ? "receives" : "pays", Game.smethod_4(num19), flag3 ? "advance" : "stay");
					num = -473671340;
					continue;
				case 41u:
					num = -96043117;
					continue;
				case 40u:
					flag14 = num3 < _playerStates.Length;
					num = -305366794;
					continue;
				case 39u:
				{
					int num32 = card.Impact - player.PlannedForCard(card.Type);
					flag3 = num32 < Rules.StayOnSprintMinDiff;
					num19 = Game.smethod_3(0, num32);
					num = (int)((num2 * 822180413) ^ 0x71C33686);
					continue;
				}
				case 38u:
					num = ((int)num2 * -727543141) ^ 0x60820189;
					continue;
				case 37u:
					flag3 = true;
					num = (int)(num2 * 127558029) ^ -2127131945;
					continue;
				case 36u:
					flag6 = playerState.Sprint < 0;
					num = -332517651;
					continue;
				case 35u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)(num2 * 320286766) ^ -2085426823;
						continue;
					}
					num9 = 0;
					goto IL_05d3;
				case 34u:
					num = (int)(num2 * 299871224) ^ -451325728;
					continue;
				case 33u:
					num = (int)(num2 * 1654133409) ^ -1487792917;
					continue;
				case 32u:
					card = DrawCard();
					num = -1258702407;
					continue;
				case 31u:
					playerState.Resources -= num19;
					num = (int)((num2 * 1972906419) ^ 0x3EFFCEC8);
					continue;
				case 30u:
				{
					int num26;
					int num27;
					if (!flag)
					{
						num26 = -1503591518;
						num27 = -1503591518;
					}
					else
					{
						num26 = -765464212;
						num27 = -765464212;
					}
					num = num26 ^ (int)(num2 * 1890682155);
					continue;
				}
				case 29u:
					num = (int)((num2 * 1269049994) ^ 0x5A5E5155);
					continue;
				case 28u:
				{
					int num22;
					int num23;
					if (!flag12)
					{
						num22 = 1145158124;
						num23 = 1145158124;
					}
					else
					{
						num22 = 800952338;
						num23 = 800952338;
					}
					num = num22 ^ (int)(num2 * 1323758400);
					continue;
				}
				case 27u:
					num3++;
					num = -1852627656;
					continue;
				case 26u:
					playerState.Sprint++;
					num = (int)((num2 * 770032570) ^ 0x3BC76B58);
					continue;
				case 25u:
					flag11 = card.Impact < 0;
					num = ((int)num2 * -1257222983) ^ 0x691F781C;
					continue;
				case 24u:
					flag8 = num8 < _playerStates.Length;
					num = -1498289451;
					continue;
				case 23u:
					num = -971430739;
					continue;
				case 22u:
					num = (int)((num2 * 762502121) ^ 0x7709FB7C);
					continue;
				case 21u:
					_finished = true;
					num = (int)(num2 * 191951409) ^ -1184075503;
					continue;
				case 20u:
				{
					int num20;
					int num21;
					if (flag9)
					{
						num20 = 326938205;
						num21 = 326938205;
					}
					else
					{
						num20 = 57599048;
						num21 = 57599048;
					}
					num = num20 ^ (int)(num2 * 1666897355);
					continue;
				}
				case 19u:
					num19 = card.Impact;
					num = (int)(num2 * 1358836077) ^ -158930865;
					continue;
				case 18u:
					num = -386309796;
					continue;
				case 17u:
					num = -648886491;
					continue;
				case 16u:
					num = -1724708554;
					continue;
				case 15u:
				{
					int num16;
					int num17;
					if (!flag8)
					{
						num16 = -1481055873;
						num17 = -1481055873;
					}
					else
					{
						num16 = -729319999;
						num17 = -729319999;
					}
					num = num16 ^ ((int)num2 * -163544547);
					continue;
				}
				case 14u:
				{
					int num14;
					int num15;
					if (flag4)
					{
						num14 = 640911069;
						num15 = 640911069;
					}
					else
					{
						num14 = 2031038128;
						num15 = 2031038128;
					}
					num = num14 ^ (int)(num2 * 1537776745);
					continue;
				}
				case 13u:
				{
					int num10;
					int num11;
					if (playerState.State != 0)
					{
						num10 = 563733832;
						num11 = 563733832;
					}
					else
					{
						num10 = 291923627;
						num11 = 291923627;
					}
					num = num10 ^ ((int)num2 * -577939771);
					continue;
				}
				case 12u:
					num = -2077388589;
					continue;
				case 11u:
					num9 = ((card.Type == 4) ? 1 : 0);
					goto IL_05d3;
				case 10u:
					num = (int)((num2 * 1488235048) ^ 0x2C0070D);
					continue;
				case 9u:
					num = (int)((num2 * 1883419460) ^ 0x48CEF502);
					continue;
				case 8u:
					flag4 = !Losers.Contains(num3);
					num = -1884899047;
					continue;
				case 6u:
					Losers.Add(num8);
					num = ((int)num2 * -1155100413) ^ -572472510;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -892287980;
						num5 = -892287980;
					}
					else
					{
						num4 = -1571744515;
						num5 = -1571744515;
					}
					num = num4 ^ (int)(num2 * 1117849717);
					continue;
				}
				case 4u:
					num = (int)(num2 * 709344882) ^ -1186937299;
					continue;
				case 3u:
					Print(playerState.State);
					num = ((int)num2 * -1987818502) ^ -111208599;
					continue;
				case 2u:
					flag2 = playerState.Sprint > Rules.SprintCount;
					num = -2120380536;
					continue;
				case 1u:
					Losers.Add(num3);
					num = (int)((num2 * 1858461144) ^ 0x5A180079);
					continue;
				case 0u:
					playerState.State = State.Lose;
					flag = !Losers.Contains(playerIndex);
					num = (int)((num2 * 248442001) ^ 0x3FB51976);
					continue;
				default:
					return;
				case 44u:
					break;
				case 7u:
					return;
					IL_05d3:
					flag9 = (byte)num9 != 0;
					flag13 = !flag11;
					num = -1609944529;
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
			int num = -1456401275;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B15ED03u) % 7u)
				{
				case 6u:
					ShuffleCards();
					num = ((int)num2 * -455552544) ^ 0x197854EA;
					continue;
				case 5u:
					card = _deck[0];
					_deck.RemoveAt(0);
					num = -167534991;
					continue;
				case 4u:
					flag = _deck.Count <= 0;
					num = (int)((num2 * 1944315964) ^ 0x476BEFB9);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2013990665;
						num4 = 2013990665;
					}
					else
					{
						num3 = 944310604;
						num4 = 944310604;
					}
					num = num3 ^ (int)(num2 * 406965019);
					continue;
				}
				case 1u:
					result = card;
					num = ((int)num2 * -12380936) ^ 0x17E4DFF9;
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
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -1383652284;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFAD4C8C6u) % 8u)
				{
				case 7u:
					result = text;
					num = (int)(num2 * 817715369) ^ -1931638680;
					continue;
				case 6u:
					flag = num3 < _playerStates.Length;
					num = -1270326005;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1540845636;
						num5 = 1540845636;
					}
					else
					{
						num4 = 1069945311;
						num5 = 1069945311;
					}
					num = num4 ^ ((int)num2 * -660745922);
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
					num = -391245811;
					continue;
				}
				case 3u:
					num3++;
					num = (int)(num2 * 1982703563) ^ -7867391;
					continue;
				case 2u:
					text = "";
					num3 = 0;
					num = (int)((num2 * 865441514) ^ 0xBF6FB2C);
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1400254363;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85E0464Cu) % 4u)
				{
				case 1u:
					result = ToString(initial: false);
					num = ((int)num2 * -1000748137) ^ 0x4E1024DB;
					continue;
				case 0u:
					num = ((int)num2 * -954544926) ^ 0x72A9D496;
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

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = -273429000;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88DCD44Du) % 4u)
				{
				case 1u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = (int)((num2 * 1898121755) ^ 0x885A92);
					continue;
				case 0u:
					Game.smethod_8(_buffer, string_);
					num = (int)(num2 * 181702919) ^ -1014646329;
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
