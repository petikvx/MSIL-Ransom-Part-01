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
			if (_finished)
			{
				goto IL_000b;
			}
			goto IL_0118;
			IL_0118:
			PlayerState[] playerStates = _playerStates;
			int num = -905804656;
			goto IL_00d5;
			IL_00d5:
			bool result = default(bool);
			int num3 = default(int);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA8BC980u) % 12u)
				{
				case 11u:
					break;
				case 10u:
					result = false;
					num = ((int)num2 * -996489335) ^ -3608876;
					continue;
				case 9u:
					goto IL_002a;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -1755913231) ^ 0x16BCD5DB;
					continue;
				case 7u:
					result = true;
					num = ((int)num2 * -1730899635) ^ -652938571;
					continue;
				case 6u:
					result = true;
					num = ((int)num2 * -654119020) ^ 0x1E07CDD5;
					continue;
				case 5u:
					goto IL_0082;
				case 4u:
					num3++;
					num = -2068813971;
					continue;
				case 3u:
					num = (int)(num2 * 1968704130) ^ -168938629;
					continue;
				case 1u:
					num = ((int)num2 * -585645848) ^ 0x5340D4FE;
					continue;
				case 0u:
					goto IL_0118;
				default:
					return result;
				}
				break;
				IL_0082:
				PlayerState playerState = playerStates[num3];
				int num4;
				if (playerState.State != 0)
				{
					num = -1985682440;
					num4 = -1985682440;
				}
				else
				{
					num = -697971886;
					num4 = -697971886;
				}
				continue;
				IL_002a:
				int num5;
				if (num3 >= playerStates.Length)
				{
					num = -1848738006;
					num5 = -1848738006;
				}
				else
				{
					num = -1717033835;
					num5 = -1717033835;
				}
			}
			goto IL_000b;
			IL_000b:
			num = -80039153;
			goto IL_00d5;
		}
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		JSONNode jSONNode = default(JSONNode);
		int count = default(int);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1639136176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEEB68D9u) % 18u)
				{
				case 17u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = (int)(num2 * 1167525632) ^ -1648027152;
					continue;
				case 16u:
					_playerStates[num5] = new PlayerState();
					num = -1771731379;
					continue;
				case 15u:
					num = ((int)num2 * -1080841453) ^ -350390587;
					continue;
				case 14u:
					Rules = Rules.Deserialize(json["rules"]);
					_dice = new Dice();
					num = (int)((num2 * 114952411) ^ 0x5B3BFBC4);
					continue;
				case 13u:
					_buffer = buffer;
					num = (int)(num2 * 446314941) ^ -350210027;
					continue;
				case 12u:
				{
					int num6;
					if (num5 < count)
					{
						num = -511209445;
						num6 = -511209445;
					}
					else
					{
						num = -634344675;
						num6 = -634344675;
					}
					continue;
				}
				case 11u:
					num3++;
					num = ((int)num2 * -1039491063) ^ 0x1DFCE46;
					continue;
				case 9u:
					num = (int)((num2 * 573502716) ^ 0x10D50669);
					continue;
				case 8u:
					_playerStates = new PlayerState[count];
					num5 = 0;
					num = (int)(num2 * 501280237) ^ -51021726;
					continue;
				case 7u:
					Players = new Player[count];
					num = (int)(num2 * 213204318) ^ -2001921741;
					continue;
				case 6u:
					num5++;
					num = ((int)num2 * -1793901199) ^ 0x33CDB6B1;
					continue;
				case 5u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = -2079279688;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -577198177) ^ 0x4C65F2B3;
					continue;
				case 3u:
					num = (int)((num2 * 234568957) ^ 0x4A380FE3);
					continue;
				case 1u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -2071756117) ^ -619037068;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -689786265;
						num4 = -689786265;
					}
					else
					{
						num = -945889062;
						num4 = -945889062;
					}
					continue;
				}
				default:
					return;
				case 10u:
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
		ShuffleCards();
		Winners.Clear();
		while (true)
		{
			int num = -1712305043;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2C9A2E3u) % 5u)
				{
				case 4u:
					_finished = false;
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -207471228) ^ -1328302787;
					continue;
				case 3u:
					_currentTurn = 0;
					num = (int)((num2 * 869251922) ^ 0xE90D7AB);
					continue;
				case 1u:
					Losers.Clear();
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1538926981) ^ -916540429;
					continue;
				default:
					return;
				case 2u:
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
		int num = 0;
		PlayerState playerState = default(PlayerState);
		int num5 = default(int);
		Player player = default(Player);
		bool flag = default(bool);
		int planningCardsCount = default(int);
		while (true)
		{
			int num2;
			int num3;
			if (num < Players.Length)
			{
				num2 = -1245213728;
				num3 = -1245213728;
			}
			else
			{
				num2 = -1265024995;
				num3 = -1265024995;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xC4EA7098u) % 25u)
				{
				case 24u:
					num2 = ((int)num4 * -902872540) ^ -988872275;
					continue;
				case 22u:
					playerState.Resources -= num5 * Rules.OverPlanningCost;
					num2 = ((int)num4 * -25960600) ^ -679110659;
					continue;
				case 21u:
					num2 = ((int)num4 * -191592060) ^ 0x6285D9D;
					continue;
				case 20u:
				{
					int num8;
					int num9;
					if (!player.UseOneMorePlanningSprint)
					{
						num8 = -772311124;
						num9 = -772311124;
					}
					else
					{
						num8 = -917285893;
						num9 = -917285893;
					}
					num2 = num8 ^ ((int)num4 * -571684868);
					continue;
				}
				case 19u:
					num5 = 0;
					num2 = -817063127;
					continue;
				case 18u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num2 = (int)((num4 * 251298478) ^ 0x41BF1832);
					continue;
				case 17u:
					num2 = -1245213728;
					continue;
				case 16u:
					num5 = 0;
					num2 = (int)((num4 * 783477911) ^ 0x7C8387A4);
					continue;
				case 15u:
					flag = num5 > 0;
					num2 = -990904277;
					continue;
				case 14u:
					num2 = -1158176702;
					continue;
				case 13u:
				{
					int num10;
					int num11;
					if (planningCardsCount == 0)
					{
						num10 = -354089984;
						num11 = -354089984;
					}
					else
					{
						num10 = -1892521103;
						num11 = -1892521103;
					}
					num2 = num10 ^ (int)(num4 * 913247505);
					continue;
				}
				case 12u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 22393120;
						num7 = 22393120;
					}
					else
					{
						num6 = 1286148576;
						num7 = 1286148576;
					}
					num2 = num6 ^ ((int)num4 * -1478763854);
					continue;
				}
				case 11u:
					num2 = ((int)num4 * -590727949) ^ -509346554;
					continue;
				case 10u:
					playerState.Sprint = -1;
					num2 = (int)((num4 * 2047523557) ^ 0x58F69BBC);
					continue;
				case 9u:
					playerState.Sprint = 1;
					num2 = ((int)num4 * -349502657) ^ -2007917229;
					continue;
				case 8u:
					playerState = _playerStates[num];
					num2 = (int)((num4 * 778366053) ^ 0x287B3C86);
					continue;
				case 7u:
					playerState.Resources -= num5 * Rules.NormalPlanningCost;
					num2 = ((int)num4 * -2003623116) ^ 0x5066E5C1;
					continue;
				case 6u:
					num5 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = -1995682188;
					continue;
				case 5u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = ((int)num4 * -605244900) ^ 0x476CD63D;
					continue;
				case 4u:
					num2 = -1867685198;
					continue;
				case 2u:
					num++;
					num2 = (int)(num4 * 15452784) ^ -934095134;
					continue;
				case 1u:
					playerState.Resources -= (planningCardsCount - num5) * Rules.NormalPlanningCost;
					num2 = -1125791992;
					continue;
				case 0u:
					player = Players[num];
					num2 = ((int)num4 * -883058060) ^ 0x2A237936;
					continue;
				default:
					return;
				case 23u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		while (true)
		{
			int num = 247966695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F896851u) % 11u)
				{
				case 10u:
					num = ((int)num2 * -344875098) ^ 0x24B14196;
					continue;
				case 8u:
					PlayerTurn(_currentPlayer);
					num = 1131152946;
					continue;
				case 7u:
					num = (int)((num2 * 706788005) ^ 0x2E7D2041);
					continue;
				case 6u:
					_currentPlayer++;
					num = (int)((num2 * 1370721302) ^ 0x40D5FBFD);
					continue;
				case 4u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = 1950509454;
					continue;
				case 3u:
				{
					_currentPlayer = 0;
					int num5;
					int num6;
					if (_currentTurn > 0)
					{
						num5 = -1432377444;
						num6 = -1432377444;
					}
					else
					{
						num5 = -1964073688;
						num6 = -1964073688;
					}
					num = num5 ^ (int)(num2 * 1575794079);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (_currentPlayer >= Players.Length)
					{
						num3 = 1569584489;
						num4 = 1569584489;
					}
					else
					{
						num3 = 645557805;
						num4 = 645557805;
					}
					num = num3 ^ ((int)num2 * -943707087);
					continue;
				}
				case 1u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 211487470) ^ 0x1B5137D9);
					continue;
				case 0u:
					num = (int)(num2 * 645361708) ^ -541685775;
					continue;
				default:
					return;
				case 9u:
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
		PlayerState playerState = default(PlayerState);
		bool flag12 = default(bool);
		bool flag5 = default(bool);
		Card card = default(Card);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		PlayerState playerState3 = default(PlayerState);
		int num5 = default(int);
		bool flag11 = default(bool);
		int num9 = default(int);
		bool flag14 = default(bool);
		bool flag3 = default(bool);
		int num8 = default(int);
		bool flag9 = default(bool);
		bool flag6 = default(bool);
		bool flag = default(bool);
		bool flag13 = default(bool);
		bool flag2 = default(bool);
		Player player = default(Player);
		int num24 = default(int);
		bool flag4 = default(bool);
		bool flag10 = default(bool);
		while (true)
		{
			int num = 2134380902;
			while (true)
			{
				uint num2;
				int num14;
				switch ((num2 = (uint)num ^ 0x1AE14895u) % 84u)
				{
				case 83u:
					playerState.Sprint++;
					Print("Still planning");
					num = ((int)num2 * -1865461668) ^ -1975848534;
					continue;
				case 82u:
					num = 1788618946;
					continue;
				case 81u:
					num = (int)((num2 * 554690323) ^ 0x1D6B31F2);
					continue;
				case 80u:
				{
					int num33;
					int num34;
					if (!flag12)
					{
						num33 = -869346745;
						num34 = -869346745;
					}
					else
					{
						num33 = -446351759;
						num34 = -446351759;
					}
					num = num33 ^ ((int)num2 * -237481902);
					continue;
				}
				case 79u:
					flag5 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -1038677953) ^ -1341084784;
						continue;
					}
					num14 = 0;
					goto IL_00ab;
				case 78u:
				{
					int num15;
					int num16;
					if (!flag8)
					{
						num15 = 1834206764;
						num16 = 1834206764;
					}
					else
					{
						num15 = 1849492840;
						num16 = 1849492840;
					}
					num = num15 ^ ((int)num2 * -599565886);
					continue;
				}
				case 77u:
				{
					int num12;
					int num13;
					if (!flag7)
					{
						num12 = -1398227620;
						num13 = -1398227620;
					}
					else
					{
						num12 = -1943934051;
						num13 = -1943934051;
					}
					num = num12 ^ ((int)num2 * -1622247757);
					continue;
				}
				case 76u:
					num14 = ((card.Type == 4) ? 1 : 0);
					goto IL_00ab;
				case 75u:
					num = ((int)num2 * -1267032300) ^ 0x7BD20265;
					continue;
				case 74u:
					num = (int)((num2 * 1655324337) ^ 0x31F6D7D4);
					continue;
				case 73u:
					playerState.State = State.Lose;
					num = (int)((num2 * 1419481686) ^ 0x20BF0EB);
					continue;
				case 72u:
					num = 182028888;
					continue;
				case 71u:
					playerState3 = _playerStates[num5];
					num = (int)(num2 * 14797022) ^ -1657010421;
					continue;
				case 70u:
					num = (int)((num2 * 1250381549) ^ 0x3370AB0);
					continue;
				case 69u:
				{
					int num29;
					int num30;
					if (!flag11)
					{
						num29 = -1398019628;
						num30 = -1398019628;
					}
					else
					{
						num29 = -1062051020;
						num30 = -1062051020;
					}
					num = num29 ^ ((int)num2 * -1539183225);
					continue;
				}
				case 68u:
					playerState3.Resources -= Game.smethod_3(0, num9 - Players[num5].PlannedForCard(card.Type));
					flag14 = playerState3.Resources >= 0;
					num = (int)((num2 * 1433152228) ^ 0x13014C27);
					continue;
				case 67u:
					num9 = card.Impact;
					num = (int)(num2 * 1869765508) ^ -43868406;
					continue;
				case 66u:
					num = 1560733666;
					continue;
				case 65u:
					Print(playerState.State);
					num = ((int)num2 * -171692317) ^ -616948102;
					continue;
				case 64u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = (int)((num2 * 466586966) ^ 0x3B1D438);
					continue;
				case 63u:
					flag7 = flag3;
					num = 1429003424;
					continue;
				case 62u:
					flag3 = false;
					num = 1476669320;
					continue;
				case 61u:
					num = (int)(num2 * 1466770112) ^ -1196382879;
					continue;
				case 60u:
					num5 = 0;
					num = ((int)num2 * -1765682261) ^ 0x309D04F;
					continue;
				case 59u:
					num = ((int)num2 * -876970516) ^ -273521950;
					continue;
				case 58u:
					Losers.Add(num8);
					num = ((int)num2 * -998049483) ^ 0x6FA83B47;
					continue;
				case 57u:
					playerState.Resources -= num9;
					num = (int)(num2 * 1207769915) ^ -1053749340;
					continue;
				case 56u:
				{
					int num17;
					int num18;
					if (!flag9)
					{
						num17 = -902610037;
						num18 = -902610037;
					}
					else
					{
						num17 = -116454742;
						num18 = -116454742;
					}
					num = num17 ^ ((int)num2 * -936055145);
					continue;
				}
				case 55u:
					num = 1677301421;
					continue;
				case 54u:
				{
					int num10;
					int num11;
					if (!flag6)
					{
						num10 = 577922842;
						num11 = 577922842;
					}
					else
					{
						num10 = 1296623255;
						num11 = 1296623255;
					}
					num = num10 ^ ((int)num2 * -331458705);
					continue;
				}
				case 53u:
					num = 962173998;
					continue;
				case 52u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1996835545;
						num4 = -1996835545;
					}
					else
					{
						num3 = -54911612;
						num4 = -54911612;
					}
					num = num3 ^ ((int)num2 * -1657979652);
					continue;
				}
				case 51u:
				{
					int num35;
					if (num8 < _playerStates.Length)
					{
						num = 1088884693;
						num35 = 1088884693;
					}
					else
					{
						num = 1177205342;
						num35 = 1177205342;
					}
					continue;
				}
				case 50u:
				{
					int num31;
					int num32;
					if (flag14)
					{
						num31 = 2062999820;
						num32 = 2062999820;
					}
					else
					{
						num31 = 2011125421;
						num32 = 2011125421;
					}
					num = num31 ^ (int)(num2 * 811284557);
					continue;
				}
				case 49u:
					num5++;
					num = 1532984515;
					continue;
				case 48u:
				{
					int num27;
					int num28;
					if (flag13)
					{
						num27 = -984311324;
						num28 = -984311324;
					}
					else
					{
						num27 = -818620037;
						num28 = -818620037;
					}
					num = num27 ^ (int)(num2 * 2011837625);
					continue;
				}
				case 47u:
					playerState.Sprint++;
					num = ((int)num2 * -1054205659) ^ 0x2BE93E50;
					continue;
				case 46u:
				{
					int num26;
					if (Losers.Contains(num8))
					{
						num = 613685969;
						num26 = 613685969;
					}
					else
					{
						num = 691080043;
						num26 = 691080043;
					}
					continue;
				}
				case 45u:
					flag13 = num8 == playerIndex;
					num = (int)(num2 * 1586028409) ^ -965306908;
					continue;
				case 43u:
					flag3 = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -1042503702) ^ -1215521669;
					continue;
				case 42u:
				{
					playerState3.State = State.Lose;
					int num25;
					if (Losers.Contains(num5))
					{
						num = 763173424;
						num25 = 763173424;
					}
					else
					{
						num = 2056660062;
						num25 = 2056660062;
					}
					continue;
				}
				case 41u:
					num = 777811516;
					continue;
				case 40u:
					flag9 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -834814737) ^ -1786957983;
					continue;
				case 39u:
					num = ((int)num2 * -1980348886) ^ 0x12A65447;
					continue;
				case 38u:
					flag8 = playerState.Resources < 0;
					num = ((int)num2 * -447605329) ^ -223862707;
					continue;
				case 37u:
					flag2 = !flag5;
					num = ((int)num2 * -1943594447) ^ 0x373E8519;
					continue;
				case 36u:
					num = (int)((num2 * 1920813210) ^ 0x3B761FF);
					continue;
				case 35u:
					player = Players[playerIndex];
					playerState = _playerStates[playerIndex];
					num = ((int)num2 * -2110297108) ^ 0x4C662455;
					continue;
				case 34u:
					num = ((int)num2 * -857750040) ^ -506217709;
					continue;
				case 33u:
					num9 = Game.smethod_3(0, num24);
					num = ((int)num2 * -565522382) ^ -966857734;
					continue;
				case 32u:
					num = ((int)num2 * -591619086) ^ 0x2F84C6C6;
					continue;
				case 31u:
					Losers.Add(num5);
					num = (int)((num2 * 1571963129) ^ 0x6C8047B7);
					continue;
				case 30u:
					num24 = card.Impact - player.PlannedForCard(card.Type);
					flag3 = num24 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -1764063483) ^ 0x4A16B86;
					continue;
				case 29u:
				{
					int num22;
					int num23;
					if (Rules.OnlyOneWinner)
					{
						num22 = 1682099956;
						num23 = 1682099956;
					}
					else
					{
						num22 = 1975527509;
						num23 = 1975527509;
					}
					num = num22 ^ (int)(num2 * 460219543);
					continue;
				}
				case 27u:
					num = (int)((num2 * 473074863) ^ 0x62432B1);
					continue;
				case 26u:
					num = (int)((num2 * 1717726158) ^ 0x6F4E3558);
					continue;
				case 25u:
					flag12 = !flag4;
					num = (int)(num2 * 357517367) ^ -1745883018;
					continue;
				case 24u:
					num = (int)(num2 * 904819864) ^ -455931344;
					continue;
				case 23u:
					card = DrawCard();
					num = ((int)num2 * -1096643098) ^ -1917617292;
					continue;
				case 22u:
					flag11 = playerState.Sprint < 0;
					num = 16503252;
					continue;
				case 21u:
					num = 2023130938;
					continue;
				case 20u:
					num = 460452974;
					continue;
				case 19u:
					num = (int)((num2 * 116987142) ^ 0x5F83BAC3);
					continue;
				case 18u:
					flag = num5 < _playerStates.Length;
					num = 1502425841;
					continue;
				case 17u:
					num = ((int)num2 * -710595411) ^ 0xB4F688F;
					continue;
				case 16u:
					num = (int)((num2 * 651168380) ^ 0x28FF57FC);
					continue;
				case 15u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -852135337) ^ -1445512062;
					continue;
				case 14u:
					flag6 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 846341899;
					continue;
				case 13u:
					num = 875053447;
					continue;
				case 12u:
				{
					int num20;
					int num21;
					if (!flag10)
					{
						num20 = -1687366117;
						num21 = -1687366117;
					}
					else
					{
						num20 = -1675957561;
						num21 = -1675957561;
					}
					num = num20 ^ (int)(num2 * 314167084);
					continue;
				}
				case 11u:
					num8++;
					num = 1039677330;
					continue;
				case 10u:
				{
					int num19;
					if (playerState.Sprint <= Rules.SprintCount)
					{
						num = 1677301421;
						num19 = 1677301421;
					}
					else
					{
						num = 1228607102;
						num19 = 1228607102;
					}
					continue;
				}
				case 9u:
					num = ((int)num2 * -1077302636) ^ -420787484;
					continue;
				case 8u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					flag10 = playerState.State != State.Playing;
					num = ((int)num2 * -1845020324) ^ 0x5545898D;
					continue;
				case 7u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag4 ? "ALL " : "", flag5 ? "receives" : "pays", Game.smethod_4(num9), flag3 ? "advance" : "stay");
					num = 1844379536;
					continue;
				case 6u:
					num = 1338806429;
					continue;
				case 5u:
					num = (int)((num2 * 1498454554) ^ 0x108B885D);
					continue;
				case 4u:
					num = ((int)num2 * -1325020177) ^ 0x10837D42;
					continue;
				case 3u:
					flag3 = true;
					num = (int)(num2 * 1329740003) ^ -1591088877;
					continue;
				case 2u:
					_finished = true;
					num8 = 0;
					num = ((int)num2 * -1414985496) ^ 0x55F2ACC2;
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -639308290;
						num7 = -639308290;
					}
					else
					{
						num6 = -1595186987;
						num7 = -1595186987;
					}
					num = num6 ^ (int)(num2 * 1744789849);
					continue;
				}
				case 0u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = 660304754;
					continue;
				}
				default:
					return;
				case 28u:
					break;
				case 44u:
					return;
					IL_00ab:
					flag4 = (byte)num14 != 0;
					num = 290310692;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		bool flag = default(bool);
		Card result = default(Card);
		while (true)
		{
			int num = 1217657886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D8644C7u) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -668841854;
						num4 = -668841854;
					}
					else
					{
						num3 = -834790681;
						num4 = -834790681;
					}
					num = num3 ^ ((int)num2 * -1121615563);
					continue;
				}
				case 6u:
				{
					Card card = _deck[0];
					_deck.RemoveAt(0);
					result = card;
					num = 649911858;
					continue;
				}
				case 5u:
					num = ((int)num2 * -1910633103) ^ 0x2B8562AE;
					continue;
				case 3u:
					ShuffleCards();
					num = ((int)num2 * -1628401533) ^ 0x37F39354;
					continue;
				case 2u:
					num = ((int)num2 * -440021412) ^ -115905439;
					continue;
				case 1u:
					flag = _deck.Count <= 0;
					num = (int)((num2 * 31598457) ^ 0x3CE92199);
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
		string text = "";
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1513422126;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34DDDEBBu) % 8u)
				{
				case 6u:
					num = (int)((num2 * 1545326263) ^ 0x7CB702A6);
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -274663303) ^ -757680342;
					continue;
				case 4u:
				{
					int num4;
					if (num3 < _playerStates.Length)
					{
						num = 889741553;
						num4 = 889741553;
					}
					else
					{
						num = 1303931298;
						num4 = 1303931298;
					}
					continue;
				}
				case 3u:
					num3++;
					num = (int)(num2 * 66296085) ^ -1313621856;
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
					num = 37083568;
					continue;
				}
				case 1u:
					result = text;
					num = ((int)num2 * -1811609175) ^ -1004589364;
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
			int num = -1015068163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5B06FE8u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -292965951) ^ 0x36D3BB75;
					continue;
				case 1u:
					result = ToString(initial: false);
					num = ((int)num2 * -328477056) ^ 0x28E10D26;
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

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = -176561449;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x981C50CEu) % 4u)
				{
				case 2u:
					Game.smethod_8(_buffer, string_);
					num = (int)(num2 * 2101010638) ^ -2068507050;
					continue;
				case 1u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = ((int)num2 * -627565628) ^ 0x667123FC;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
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
