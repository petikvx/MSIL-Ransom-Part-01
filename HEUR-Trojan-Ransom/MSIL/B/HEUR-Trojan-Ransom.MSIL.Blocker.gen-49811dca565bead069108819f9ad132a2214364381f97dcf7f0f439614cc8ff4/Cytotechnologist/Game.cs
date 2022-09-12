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
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool result = default(bool);
			while (true)
			{
				int num = -802793184;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAAF7ECD7u) % 14u)
					{
					case 13u:
					{
						int num6;
						int num7;
						if (finished)
						{
							num6 = 1114296734;
							num7 = 1114296734;
						}
						else
						{
							num6 = 403667501;
							num7 = 403667501;
						}
						num = num6 ^ ((int)num2 * -339812774);
						continue;
					}
					case 12u:
						playerStates = _playerStates;
						num3 = 0;
						num = -1487671467;
						continue;
					case 11u:
						num = (int)((num2 * 605881399) ^ 0x21499B36);
						continue;
					case 10u:
						result = true;
						num = ((int)num2 * -759613902) ^ -1473766680;
						continue;
					case 9u:
					{
						PlayerState playerState = playerStates[num3];
						int num5;
						if (playerState.State != 0)
						{
							num = -1189383118;
							num5 = -1189383118;
						}
						else
						{
							num = -1959605665;
							num5 = -1959605665;
						}
						continue;
					}
					case 8u:
						result = false;
						num = (int)((num2 * 1937925516) ^ 0x1E038E10);
						continue;
					case 7u:
						result = true;
						num = (int)(num2 * 414042421) ^ -393172435;
						continue;
					case 5u:
						num3++;
						num = -1265547699;
						continue;
					case 4u:
					{
						int num4;
						if (num3 >= playerStates.Length)
						{
							num = -1257946901;
							num4 = -1257946901;
						}
						else
						{
							num = -131730590;
							num4 = -131730590;
						}
						continue;
					}
					case 3u:
						num = ((int)num2 * -320820939) ^ -1229466542;
						continue;
					case 1u:
						num = (int)((num2 * 1408593103) ^ 0x639D88FE);
						continue;
					case 0u:
						num = (int)((num2 * 1546476087) ^ 0x59C332A3);
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
			int num = -1811424976;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC119226u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1091418214) ^ 0x76758A33;
					continue;
				case 5u:
					_currentTurn = 0;
					_finished = false;
					num = ((int)num2 * -1910927629) ^ -2085426581;
					continue;
				case 4u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -442260978) ^ -1620818067;
					continue;
				case 3u:
					ShuffleCards();
					Winners.Clear();
					num = (int)(num2 * 1837812418) ^ -1305182759;
					continue;
				case 2u:
					Losers.Clear();
					num = (int)(num2 * 477206110) ^ -2077275319;
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
		PlayerState playerState = default(PlayerState);
		int planningCardsCount = default(int);
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		Player player = default(Player);
		bool flag2 = default(bool);
		bool useOneMorePlanningSprint = default(bool);
		while (true)
		{
			int num = -1077319488;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE130C627u) % 25u)
				{
				case 24u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num3++;
					num = -1258279678;
					continue;
				case 23u:
					flag = num4 > 0;
					num = -678069165;
					continue;
				case 22u:
					num = (int)((num2 * 37783723) ^ 0x3AB5ADB8);
					continue;
				case 21u:
					playerState.Sprint = -1;
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num = (int)(num2 * 1368429033) ^ -164797941;
					continue;
				case 20u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num4 = 0;
					num = ((int)num2 * -1480728886) ^ 0x7A7AAC34;
					continue;
				case 19u:
					flag2 = num3 < Players.Length;
					num = -1104943202;
					continue;
				case 18u:
					num3 = 0;
					num = (int)((num2 * 1185705781) ^ 0x2CBB73D1);
					continue;
				case 17u:
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					num = (int)((num2 * 341817030) ^ 0x2CEE684C);
					continue;
				case 16u:
					num = -203051187;
					continue;
				case 15u:
					player = Players[num3];
					num = -326600537;
					continue;
				case 14u:
				{
					int num11;
					int num12;
					if (!useOneMorePlanningSprint)
					{
						num11 = -263812509;
						num12 = -263812509;
					}
					else
					{
						num11 = -1344216543;
						num12 = -1344216543;
					}
					num = num11 ^ (int)(num2 * 587820157);
					continue;
				}
				case 13u:
					num = -1874776384;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1293465278;
						num10 = 1293465278;
					}
					else
					{
						num9 = 675387158;
						num10 = 675387158;
					}
					num = num9 ^ ((int)num2 * -161347734);
					continue;
				}
				case 11u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 1070796145;
						num8 = 1070796145;
					}
					else
					{
						num7 = 157294299;
						num8 = 157294299;
					}
					num = num7 ^ (int)(num2 * 1501716988);
					continue;
				}
				case 10u:
				{
					int num5;
					int num6;
					if (planningCardsCount == 0)
					{
						num5 = -267948293;
						num6 = -267948293;
					}
					else
					{
						num5 = -566142066;
						num6 = -566142066;
					}
					num = num5 ^ (int)(num2 * 567412694);
					continue;
				}
				case 9u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = (int)((num2 * 308469469) ^ 0x671703E5);
					continue;
				case 8u:
					num4 = 0;
					num = -1142523132;
					continue;
				case 6u:
					num = ((int)num2 * -555991832) ^ -1239094818;
					continue;
				case 5u:
					num = ((int)num2 * -684124272) ^ 0x772F58E4;
					continue;
				case 4u:
					playerState.Sprint = 1;
					num = (int)(num2 * 523219307) ^ -159529890;
					continue;
				case 3u:
					num = ((int)num2 * -1893461488) ^ 0x59B2B6D9;
					continue;
				case 1u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num = ((int)num2 * -1235803022) ^ 0x4BA1E57F;
					continue;
				case 0u:
					playerState = _playerStates[num3];
					num = (int)((num2 * 1407144651) ^ 0x36F6346E);
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
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
			int num = 2083654568;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x500E1C9Du) % 13u)
				{
				case 11u:
					flag2 = _currentTurn > 0;
					num = (int)((num2 * 273573208) ^ 0xC5A2EED);
					continue;
				case 10u:
					num = ((int)num2 * -1366617659) ^ -1000423807;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1995021375;
						num6 = 1995021375;
					}
					else
					{
						num5 = 111216419;
						num6 = 111216419;
					}
					num = num5 ^ (int)(num2 * 1662546516);
					continue;
				}
				case 8u:
					num = (int)(num2 * 32030752) ^ -423038081;
					continue;
				case 7u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 477390869;
					continue;
				case 6u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 619985442) ^ -2127660843;
					continue;
				case 5u:
					_currentPlayer = 0;
					num = (int)((num2 * 230033540) ^ 0x7AEF3BF5);
					continue;
				case 4u:
					flag = _currentPlayer >= Players.Length;
					num = (int)((num2 * 204422330) ^ 0x673C51D8);
					continue;
				case 3u:
					_currentPlayer++;
					num = (int)((num2 * 67098369) ^ 0x81B1FCB);
					continue;
				case 2u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 1679649496) ^ 0x1485354D);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 78684300;
						num4 = 78684300;
					}
					else
					{
						num3 = 2147089203;
						num4 = 2147089203;
					}
					num = num3 ^ (int)(num2 * 1289507882);
					continue;
				}
				case 0u:
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
		Player player = Players[playerIndex];
		PlayerState playerState = _playerStates[playerIndex];
		PlayerState playerState2 = default(PlayerState);
		int num5 = default(int);
		int num14 = default(int);
		Card card = default(Card);
		int num4 = default(int);
		bool flag10 = default(bool);
		bool flag2 = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		int num3 = default(int);
		bool flag9 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -227915651;
			while (true)
			{
				uint num2;
				int num20;
				switch ((num2 = (uint)num ^ 0xB67CDA66u) % 76u)
				{
				case 75u:
					playerState2.Resources -= Game.smethod_3(0, num5 - Players[num14].PlannedForCard(card.Type));
					num = ((int)num2 * -1053657155) ^ -1894470580;
					continue;
				case 74u:
					_finished = true;
					num4 = 0;
					num = (int)(num2 * 458656139) ^ -1019868294;
					continue;
				case 73u:
				{
					int num18;
					int num19;
					if (playerState.Resources < 0)
					{
						num18 = 1566735493;
						num19 = 1566735493;
					}
					else
					{
						num18 = 603239721;
						num19 = 603239721;
					}
					num = num18 ^ ((int)num2 * -478719243);
					continue;
				}
				case 72u:
					num = -2113264781;
					continue;
				case 71u:
					Print(playerState.State);
					num = ((int)num2 * -1765052814) ^ -326347453;
					continue;
				case 70u:
					num = ((int)num2 * -1371169743) ^ 0x647CEEAF;
					continue;
				case 69u:
					playerState.Resources -= num5;
					num = ((int)num2 * -1185119827) ^ -1261273310;
					continue;
				case 68u:
					num = ((int)num2 * -519909087) ^ -640512187;
					continue;
				case 67u:
					num = (int)((num2 * 923986923) ^ 0x708E6F7D);
					continue;
				case 66u:
					num = ((int)num2 * -484414148) ^ -2140861135;
					continue;
				case 65u:
					Losers.Add(num14);
					num = (int)((num2 * 967679670) ^ 0x4B933780);
					continue;
				case 64u:
					num5 = card.Impact;
					num = (int)((num2 * 977596840) ^ 0x41200389);
					continue;
				case 63u:
					num = ((int)num2 * -320327462) ^ 0x147036FB;
					continue;
				case 62u:
					num = -893414686;
					continue;
				case 61u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1961825152) ^ 0xA7F9943;
					continue;
				case 60u:
				{
					int num17;
					if (!Losers.Contains(num4))
					{
						num = -2118021647;
						num17 = -2118021647;
					}
					else
					{
						num = -803832326;
						num17 = -803832326;
					}
					continue;
				}
				case 59u:
				{
					int num13;
					if (num4 < _playerStates.Length)
					{
						num = -1755827338;
						num13 = -1755827338;
					}
					else
					{
						num = -1301319475;
						num13 = -1301319475;
					}
					continue;
				}
				case 58u:
				{
					int num9;
					int num10;
					if (playerState.State != 0)
					{
						num9 = -1948836709;
						num10 = -1948836709;
					}
					else
					{
						num9 = -1041105083;
						num10 = -1041105083;
					}
					num = num9 ^ (int)(num2 * 949244177);
					continue;
				}
				case 57u:
				{
					int num32;
					int num33;
					if (!Rules.OnlyOneWinner)
					{
						num32 = 1020287981;
						num33 = 1020287981;
					}
					else
					{
						num32 = 1636201077;
						num33 = 1636201077;
					}
					num = num32 ^ ((int)num2 * -1709064659);
					continue;
				}
				case 56u:
				{
					int num28;
					int num29;
					if (!flag10)
					{
						num28 = -605831023;
						num29 = -605831023;
					}
					else
					{
						num28 = -1173191905;
						num29 = -1173191905;
					}
					num = num28 ^ (int)(num2 * 852228655);
					continue;
				}
				case 55u:
					num20 = ((card.Type == 4) ? 1 : 0);
					goto IL_02aa;
				case 54u:
					num = (int)(num2 * 1129563240) ^ -1940067526;
					continue;
				case 53u:
				{
					int num21;
					int num22;
					if (flag2)
					{
						num21 = -88646224;
						num22 = -88646224;
					}
					else
					{
						num21 = -1748334132;
						num22 = -1748334132;
					}
					num = num21 ^ (int)(num2 * 76997163);
					continue;
				}
				case 52u:
					flag6 = !flag4;
					num = (int)((num2 * 1890806123) ^ 0x3105C9E8);
					continue;
				case 51u:
				{
					int num15;
					int num16;
					if (!Losers.Contains(num14))
					{
						num15 = 1745920491;
						num16 = 1745920491;
					}
					else
					{
						num15 = 1729532878;
						num16 = 1729532878;
					}
					num = num15 ^ ((int)num2 * -1187436112);
					continue;
				}
				case 50u:
				{
					int num11;
					int num12;
					if (flag6)
					{
						num11 = 1695262956;
						num12 = 1695262956;
					}
					else
					{
						num11 = 1939841215;
						num12 = 1939841215;
					}
					num = num11 ^ (int)(num2 * 940337901);
					continue;
				}
				case 48u:
				{
					int num7;
					int num8;
					if (!flag5)
					{
						num7 = 31901227;
						num8 = 31901227;
					}
					else
					{
						num7 = 1390221210;
						num8 = 1390221210;
					}
					num = num7 ^ ((int)num2 * -838751621);
					continue;
				}
				case 47u:
				{
					int num34;
					if (num14 < _playerStates.Length)
					{
						num = -189381352;
						num34 = -189381352;
					}
					else
					{
						num = -1274895282;
						num34 = -1274895282;
					}
					continue;
				}
				case 46u:
					playerState2 = _playerStates[num14];
					num = -363875591;
					continue;
				case 45u:
					flag = false;
					num = -1261255807;
					continue;
				case 44u:
					flag = true;
					Print("CARD: none, advance");
					num = (int)((num2 * 843551461) ^ 0x23E66710);
					continue;
				case 43u:
					num = -1129530779;
					continue;
				case 42u:
				{
					int num30;
					int num31;
					if (!flag8)
					{
						num30 = -857794712;
						num31 = -857794712;
					}
					else
					{
						num30 = -1478117172;
						num31 = -1478117172;
					}
					num = num30 ^ ((int)num2 * -2011325460);
					continue;
				}
				case 41u:
				{
					int num26;
					int num27;
					if (!flag7)
					{
						num26 = 1583000425;
						num27 = 1583000425;
					}
					else
					{
						num26 = 2090008394;
						num27 = 2090008394;
					}
					num = num26 ^ (int)(num2 * 846871370);
					continue;
				}
				case 40u:
					num3 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)(num2 * 1540866039) ^ -1757966045;
					continue;
				case 39u:
					flag = true;
					num = (int)(num2 * 1034330273) ^ -704301795;
					continue;
				case 38u:
					num14 = 0;
					num = -354448835;
					continue;
				case 37u:
					num = (int)(num2 * 1920041401) ^ -1407221005;
					continue;
				case 36u:
					num14++;
					num = -354448835;
					continue;
				case 35u:
					num = (int)(num2 * 11197841) ^ -540332832;
					continue;
				case 34u:
					num5 = Game.smethod_3(0, num3);
					num = (int)((num2 * 1575056976) ^ 0x3091E17D);
					continue;
				case 33u:
					flag5 = playerState.Sprint < 0;
					num = -1786110658;
					continue;
				case 32u:
					num = (int)((num2 * 1872635472) ^ 0x2AA6123);
					continue;
				case 31u:
					flag10 = flag;
					num = -603553554;
					continue;
				case 30u:
					num = (int)(num2 * 1915401437) ^ -1353334411;
					continue;
				case 29u:
					num = -1082709523;
					continue;
				case 28u:
					num = (int)(num2 * 1247306894) ^ -2099973258;
					continue;
				case 27u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 1100459235) ^ 0x15B5C3A9);
					continue;
				case 26u:
					playerState2.State = State.Lose;
					num = -601498935;
					continue;
				case 25u:
					flag9 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -1839381204;
					continue;
				case 24u:
					playerState.Sprint++;
					num = ((int)num2 * -1327841860) ^ 0x769B59EE;
					continue;
				case 23u:
					num = ((int)num2 * -1267984995) ^ -805343974;
					continue;
				case 22u:
				{
					int num24;
					int num25;
					if (!flag9)
					{
						num24 = -81605334;
						num25 = -81605334;
					}
					else
					{
						num24 = -1158735546;
						num25 = -1158735546;
					}
					num = num24 ^ (int)(num2 * 186878890);
					continue;
				}
				case 21u:
					flag8 = playerState2.Resources >= 0;
					num = ((int)num2 * -1478300277) ^ -421655677;
					continue;
				case 20u:
					num = (int)((num2 * 1110737566) ^ 0x2E72F4DB);
					continue;
				case 19u:
					num = (int)((num2 * 1947180101) ^ 0x3432B807);
					continue;
				case 18u:
					num = ((int)num2 * -1248272645) ^ -469083080;
					continue;
				case 17u:
					num = ((int)num2 * -2015234002) ^ 0x55D1005F;
					continue;
				case 16u:
				{
					int num23;
					if (num4 != playerIndex)
					{
						num = -982251034;
						num23 = -982251034;
					}
					else
					{
						num = -36879040;
						num23 = -36879040;
					}
					continue;
				}
				case 15u:
					flag7 = playerState.Sprint > Rules.SprintCount;
					num = -1770144357;
					continue;
				case 14u:
					flag4 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -2044081196) ^ 0x3F77341;
						continue;
					}
					num20 = 0;
					goto IL_02aa;
				case 13u:
					Print(Game.smethod_2("\t", (playerState != null) ? Game.smethod_5((object)playerState) : null));
					num = -191067147;
					continue;
				case 12u:
					Print("Still planning");
					num = ((int)num2 * -188134773) ^ -254909634;
					continue;
				case 11u:
				{
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag3 ? "ALL " : "", flag4 ? "receives" : "pays", Game.smethod_4(num5), flag ? "advance" : "stay");
					int num6;
					if (!flag3)
					{
						num = -1304708077;
						num6 = -1304708077;
					}
					else
					{
						num = -698447292;
						num6 = -698447292;
					}
					continue;
				}
				case 10u:
					num = (int)(num2 * 1585733783) ^ -956220391;
					continue;
				case 9u:
					playerState.Sprint++;
					num = ((int)num2 * -731165762) ^ 0x563052D7;
					continue;
				case 8u:
					card = DrawCard();
					num = -803876796;
					continue;
				case 6u:
					num = -710150837;
					continue;
				case 5u:
					num4++;
					num = -2093781031;
					continue;
				case 4u:
					playerState.State = State.Lose;
					flag2 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1410395833) ^ -1433743925;
					continue;
				case 3u:
					Losers.Add(num4);
					num = (int)((num2 * 670785012) ^ 0x6DA5C35B);
					continue;
				case 2u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -1647779961) ^ -1858551058;
					continue;
				case 1u:
					flag = num3 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -1009858600) ^ -983492192;
					continue;
				case 0u:
					num = -59203862;
					continue;
				default:
					return;
				case 49u:
					break;
				case 7u:
					return;
					IL_02aa:
					flag3 = (byte)num20 != 0;
					num = -51380186;
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
			int num = 710682823;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33A8FEA9u) % 10u)
				{
				case 9u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1988218719;
						num4 = -1988218719;
					}
					else
					{
						num3 = -104297217;
						num4 = -104297217;
					}
					num = num3 ^ ((int)num2 * -249518252);
					continue;
				}
				case 8u:
					flag = _deck.Count <= 0;
					num = (int)(num2 * 1852898015) ^ -907440340;
					continue;
				case 6u:
					num = (int)((num2 * 1932683986) ^ 0x38D6788D);
					continue;
				case 5u:
					_deck.RemoveAt(0);
					num = ((int)num2 * -652483204) ^ -1708038342;
					continue;
				case 4u:
					card = _deck[0];
					num = 1482251600;
					continue;
				case 3u:
					num = ((int)num2 * -249381727) ^ -479258338;
					continue;
				case 2u:
					result = card;
					num = (int)(num2 * 607532589) ^ -1509646688;
					continue;
				case 0u:
					ShuffleCards();
					num = (int)((num2 * 100385901) ^ 0x4DB0FB2B);
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

	public string ToString(bool initial)
	{
		int num3 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1068441656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEE71538u) % 10u)
				{
				case 9u:
					num3++;
					num = ((int)num2 * -260740119) ^ 0x6EE74794;
					continue;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -1548339370) ^ 0x6400C8CC;
					continue;
				case 7u:
					num = ((int)num2 * -343303592) ^ 0x467A20CD;
					continue;
				case 6u:
					text = "";
					num = ((int)num2 * -1735592257) ^ 0x1FFAFE0A;
					continue;
				case 5u:
					result = text;
					num = (int)((num2 * 1833565040) ^ 0x551835B1);
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= _playerStates.Length)
					{
						num = -107981383;
						num4 = -107981383;
					}
					else
					{
						num = -1961995772;
						num4 = -1961995772;
					}
					continue;
				}
				case 2u:
					num = (int)(num2 * 773160879) ^ -1134241095;
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
					num = -318931131;
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
			int num = 982083117;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49AFE054u) % 4u)
				{
				case 1u:
					result = ToString(initial: false);
					num = (int)(num2 * 1645132602) ^ -1618765098;
					continue;
				case 0u:
					num = (int)(num2 * 1724308810) ^ -1700523066;
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
			int num = -1024149479;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC0D3BB7u) % 4u)
				{
				case 2u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = (int)((num2 * 1061398119) ^ 0x342AF404);
					continue;
				case 1u:
					Game.smethod_8(_buffer, string_);
					num = (int)(num2 * 615914837) ^ -1372905275;
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
