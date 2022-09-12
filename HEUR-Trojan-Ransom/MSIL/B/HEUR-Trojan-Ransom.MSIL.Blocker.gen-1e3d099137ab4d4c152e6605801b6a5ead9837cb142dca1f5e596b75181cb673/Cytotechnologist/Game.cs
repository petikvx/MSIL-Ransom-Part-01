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
				goto IL_00c0;
			}
			goto IL_0166;
			IL_0166:
			PlayerState[] playerStates = _playerStates;
			int num = 1753149414;
			goto IL_0117;
			IL_0117:
			bool result = default(bool);
			bool flag = default(bool);
			PlayerState playerState = default(PlayerState);
			int num5 = default(int);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70A5A448u) % 15u)
				{
				case 14u:
					result = true;
					num = ((int)num2 * -1429643676) ^ 0x5BC86A0D;
					continue;
				case 13u:
					flag = playerState.State == State.Playing;
					num = (int)(num2 * 1488122813) ^ -743078254;
					continue;
				case 12u:
					num5 = 0;
					num = (int)(num2 * 892727682) ^ -860778641;
					continue;
				case 10u:
					result = false;
					num = ((int)num2 * -1939253501) ^ -1960280387;
					continue;
				case 9u:
					num5++;
					num = 888350338;
					continue;
				case 7u:
					num = ((int)num2 * -1539217840) ^ -1598950466;
					continue;
				case 6u:
					break;
				case 5u:
					result = true;
					num = ((int)num2 * -863772494) ^ 0x59AC0575;
					continue;
				case 4u:
					goto end_IL_0117;
				case 3u:
					num = (int)((num2 * 1306150719) ^ 0x5122C2C7);
					continue;
				case 2u:
					num = ((int)num2 * -84545904) ^ 0x6AA9B7E;
					continue;
				case 1u:
					playerState = playerStates[num5];
					num = 2004184768;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -687422802;
						num4 = -687422802;
					}
					else
					{
						num3 = -1374566329;
						num4 = -1374566329;
					}
					num = num3 ^ ((int)num2 * -1920180489);
					continue;
				}
				case 11u:
					goto IL_0166;
				default:
					return result;
				}
				int num6;
				if (num5 >= playerStates.Length)
				{
					num = 1928778078;
					num6 = 1928778078;
				}
				else
				{
					num = 1678511906;
					num6 = 1678511906;
				}
				continue;
				end_IL_0117:
				break;
			}
			goto IL_00c0;
			IL_00c0:
			num = 701518508;
			goto IL_0117;
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
			int num = 1441026815;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23E188B0u) % 9u)
				{
				case 8u:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 1232079335) ^ 0x5DB69466);
					continue;
				case 7u:
					_finished = false;
					num = ((int)num2 * -2023956886) ^ -796498299;
					continue;
				case 6u:
					ShuffleCards();
					num = ((int)num2 * -260128051) ^ 0x1F0B9876;
					continue;
				case 5u:
					Winners.Clear();
					num = ((int)num2 * -60510707) ^ -989315590;
					continue;
				case 3u:
					num = ((int)num2 * -2083358205) ^ -2084130152;
					continue;
				case 2u:
					Losers.Clear();
					num = (int)((num2 * 2105187129) ^ 0x5F05CCA5);
					continue;
				case 1u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					num = ((int)num2 * -200139790) ^ -201283496;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		PlayerState playerState = default(PlayerState);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		int planningCardsCount = default(int);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 920297173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79908E7Fu) % 28u)
				{
				case 27u:
					flag2 = num3 > 0;
					num = 983687731;
					continue;
				case 26u:
					flag = num6 < Players.Length;
					num = 1973378319;
					continue;
				case 24u:
					playerState = _playerStates[num6];
					num = (int)((num2 * 1151278403) ^ 0x4E01C30B);
					continue;
				case 23u:
					num6++;
					num = (int)(num2 * 1943043643) ^ -1041767660;
					continue;
				case 22u:
					playerState.Sprint = 1;
					num = (int)((num2 * 267648318) ^ 0x7542E3D3);
					continue;
				case 21u:
					num = 1271790901;
					continue;
				case 20u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = (int)((num2 * 121708910) ^ 0x3E05C1D6);
					continue;
				case 19u:
					num = (int)((num2 * 845583129) ^ 0x2A6C8575);
					continue;
				case 18u:
					planningCardsCount = player.PlanningCardsCount;
					num3 = 0;
					flag3 = planningCardsCount == 0;
					num = ((int)num2 * -1609537891) ^ -2033157062;
					continue;
				case 17u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = 406724916;
					continue;
				case 16u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = ((int)num2 * -1238570183) ^ -1353956814;
					continue;
				case 15u:
					num = 364376526;
					continue;
				case 14u:
					player = Players[num6];
					num = ((int)num2 * -158177024) ^ 0x4B8CFBEF;
					continue;
				case 13u:
					num = (int)((num2 * 2083690450) ^ 0x7DBF692A);
					continue;
				case 12u:
					num = (int)((num2 * 824659191) ^ 0x19B470CE);
					continue;
				case 11u:
				{
					int num11;
					int num12;
					if (flag3)
					{
						num11 = 1112233177;
						num12 = 1112233177;
					}
					else
					{
						num11 = 828580644;
						num12 = 828580644;
					}
					num = num11 ^ ((int)num2 * -689700140);
					continue;
				}
				case 9u:
				{
					int num9;
					int num10;
					if (useOneMorePlanningSprint)
					{
						num9 = -1348369865;
						num10 = -1348369865;
					}
					else
					{
						num9 = -862211437;
						num10 = -862211437;
					}
					num = num9 ^ (int)(num2 * 1397172551);
					continue;
				}
				case 8u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -461049965;
						num8 = -461049965;
					}
					else
					{
						num7 = -2069701476;
						num8 = -2069701476;
					}
					num = num7 ^ ((int)num2 * -74928834);
					continue;
				}
				case 7u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = 1175308087;
					continue;
				case 6u:
					num6 = 0;
					num = ((int)num2 * -1889231449) ^ -948988997;
					continue;
				case 5u:
					playerState.Sprint = -1;
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)(num2 * 354987964) ^ -446913244;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 181570922;
						num5 = 181570922;
					}
					else
					{
						num4 = 1980162930;
						num5 = 1980162930;
					}
					num = num4 ^ (int)(num2 * 345102858);
					continue;
				}
				case 3u:
					num3 = 0;
					num = 1438088;
					continue;
				case 2u:
					playerState.Resources = Rules.InitialResources;
					num = (int)(num2 * 972971562) ^ -1318506278;
					continue;
				case 1u:
					playerState.State = State.Playing;
					num = ((int)num2 * -1669540539) ^ 0x4D038F00;
					continue;
				case 0u:
					playerState.Sprint = 0;
					num = ((int)num2 * -422685799) ^ 0x79EBC979;
					continue;
				default:
					return;
				case 10u:
					break;
				case 25u:
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
		while (true)
		{
			int num = -719709234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF44A00Fu) % 11u)
				{
				case 10u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = -532290644;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (_currentTurn <= 0)
					{
						num5 = 1787617504;
						num6 = 1787617504;
					}
					else
					{
						num5 = 1111107403;
						num6 = 1111107403;
					}
					num = num5 ^ (int)(num2 * 872490023);
					continue;
				}
				case 8u:
					PlayerTurn(_currentPlayer);
					num = -1623400384;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -736902805;
						num4 = -736902805;
					}
					else
					{
						num3 = -453689173;
						num4 = -453689173;
					}
					num = num3 ^ (int)(num2 * 1799466432);
					continue;
				}
				case 6u:
					_currentPlayer = 0;
					num = (int)(num2 * 4366001) ^ -882588472;
					continue;
				case 3u:
					num = (int)((num2 * 1310073567) ^ 0x3338F651);
					continue;
				case 2u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 1219209239) ^ 0x64810C02);
					continue;
				case 1u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 1344730357) ^ -1372206902;
					continue;
				case 0u:
					num = (int)((num2 * 431694791) ^ 0x38B8F1BD);
					continue;
				default:
					return;
				case 5u:
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
		PlayerState playerState = _playerStates[playerIndex];
		int num10 = default(int);
		bool flag10 = default(bool);
		bool flag5 = default(bool);
		bool flag9 = default(bool);
		int num7 = default(int);
		bool flag6 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag8 = default(bool);
		int num31 = default(int);
		Card card = default(Card);
		int num6 = default(int);
		bool onlyOneWinner = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 22272067;
			while (true)
			{
				uint num2;
				int num5;
				int num9;
				switch ((num2 = (uint)num ^ 0x3153CEB5u) % 81u)
				{
				case 80u:
					playerState.Resources -= num10;
					num = (int)((num2 * 1103207093) ^ 0x33F47370);
					continue;
				case 79u:
					flag10 = flag5;
					num = 2009724894;
					continue;
				case 77u:
				{
					int num14;
					if (playerState.Sprint >= 0)
					{
						num = 92841871;
						num14 = 92841871;
					}
					else
					{
						num = 191944811;
						num14 = 191944811;
					}
					continue;
				}
				case 76u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = (int)((num2 * 1408559184) ^ 0x445DA131);
					continue;
				case 75u:
				{
					int num23;
					int num24;
					if (!flag9)
					{
						num23 = -77778968;
						num24 = -77778968;
					}
					else
					{
						num23 = -1969966302;
						num24 = -1969966302;
					}
					num = num23 ^ (int)(num2 * 333172659);
					continue;
				}
				case 74u:
				{
					int num13;
					if (_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = 95159544;
						num13 = 95159544;
					}
					else
					{
						num = 1866266663;
						num13 = 1866266663;
					}
					continue;
				}
				case 73u:
					num = (int)(num2 * 991414096) ^ -180136744;
					continue;
				case 72u:
					num = (int)(num2 * 737158142) ^ -1965813258;
					continue;
				case 71u:
					num7++;
					num = 1095203775;
					continue;
				case 70u:
					Print("Still planning");
					num = ((int)num2 * -1787149697) ^ 0x75CAAC05;
					continue;
				case 69u:
					num = (int)((num2 * 810126895) ^ 0x705DC5BB);
					continue;
				case 68u:
					flag6 = playerState2.Resources >= 0;
					num = ((int)num2 * -959387539) ^ 0x77685CD1;
					continue;
				case 67u:
					num = 820481307;
					continue;
				case 66u:
					num = (int)((num2 * 1192993116) ^ 0x496DFECE);
					continue;
				case 65u:
					Losers.Add(num7);
					num = ((int)num2 * -1868232670) ^ -1792159402;
					continue;
				case 64u:
					playerState.State = State.Lose;
					num = (int)(num2 * 677431445) ^ -1985281291;
					continue;
				case 63u:
					Print(playerState.State);
					num = (int)((num2 * 995404591) ^ 0x5EC0A420);
					continue;
				case 62u:
					flag8 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1971975025) ^ 0x22947E9;
					continue;
				case 61u:
					num31 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)((num2 * 1604245771) ^ 0x3EBF8F15);
					continue;
				case 60u:
					playerState2.Resources -= Game.smethod_3(0, num10 - Players[num6].PlannedForCard(card.Type));
					num = ((int)num2 * -1725316379) ^ -1848443361;
					continue;
				case 59u:
				{
					int num28;
					if (num7 < _playerStates.Length)
					{
						num = 2099420851;
						num28 = 2099420851;
					}
					else
					{
						num = 1643078798;
						num28 = 1643078798;
					}
					continue;
				}
				case 58u:
				{
					int num25;
					if (!Losers.Contains(num7))
					{
						num = 1874318112;
						num25 = 1874318112;
					}
					else
					{
						num = 158090396;
						num25 = 158090396;
					}
					continue;
				}
				case 57u:
					num = ((int)num2 * -211835424) ^ -1295952319;
					continue;
				case 56u:
					num6++;
					num = 812889647;
					continue;
				case 55u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)(num2 * 326686784) ^ -1342836356;
					continue;
				case 54u:
					flag5 = true;
					Print("CARD: none, advance");
					num = (int)(num2 * 1028491637) ^ -263692345;
					continue;
				case 53u:
					num = 347219171;
					continue;
				case 52u:
				{
					int num15;
					int num16;
					if (playerState.Resources >= 0)
					{
						num15 = -1128696391;
						num16 = -1128696391;
					}
					else
					{
						num15 = -1958751523;
						num16 = -1958751523;
					}
					num = num15 ^ ((int)num2 * -1551226817);
					continue;
				}
				case 51u:
					Print(Game.smethod_2("\t", (playerState != null) ? Game.smethod_5((object)playerState) : null));
					num = 167854861;
					continue;
				case 50u:
					Losers.Add(num6);
					num = ((int)num2 * -1689923146) ^ 0xC603411;
					continue;
				case 49u:
					num = ((int)num2 * -1183390237) ^ 0x3A3AE03;
					continue;
				case 48u:
					num = 1214032464;
					continue;
				case 47u:
					card = DrawCard();
					flag2 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 132884770) ^ 0x3C24094C);
						continue;
					}
					num5 = 0;
					goto IL_0430;
				case 46u:
					_finished = true;
					num = ((int)num2 * -1743423511) ^ 0x7B611357;
					continue;
				case 45u:
				{
					int num32;
					int num33;
					if (flag6)
					{
						num32 = -2006845188;
						num33 = -2006845188;
					}
					else
					{
						num32 = -54419081;
						num33 = -54419081;
					}
					num = num32 ^ (int)(num2 * 1827469167);
					continue;
				}
				case 44u:
					num = (int)(num2 * 1122576552) ^ -1699828325;
					continue;
				case 43u:
					num = (int)(num2 * 305175728) ^ -2055057924;
					continue;
				case 42u:
					num = ((int)num2 * -400802397) ^ -2107205839;
					continue;
				case 41u:
					flag = !flag4;
					num = ((int)num2 * -1037063151) ^ 0x5F750412;
					continue;
				case 40u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -1487353357) ^ 0xE010E2E;
					continue;
				case 39u:
					flag5 = num31 < Rules.StayOnSprintMinDiff;
					num10 = Game.smethod_3(0, num31);
					num = (int)((num2 * 310283012) ^ 0x7E4E4862);
					continue;
				case 38u:
					playerState.Sprint++;
					num = ((int)num2 * -148048438) ^ 0x565D40C5;
					continue;
				case 37u:
					playerState.Sprint++;
					num = ((int)num2 * -215368464) ^ -833187243;
					continue;
				case 35u:
					flag5 = false;
					num = 824382468;
					continue;
				case 34u:
				{
					int num29;
					int num30;
					if (flag10)
					{
						num29 = 118611224;
						num30 = 118611224;
					}
					else
					{
						num29 = 192060318;
						num30 = 192060318;
					}
					num = num29 ^ ((int)num2 * -1882378387);
					continue;
				}
				case 33u:
				{
					int num26;
					int num27;
					if (!onlyOneWinner)
					{
						num26 = 781890936;
						num27 = 781890936;
					}
					else
					{
						num26 = 1593918526;
						num27 = 1593918526;
					}
					num = num26 ^ (int)(num2 * 447986934);
					continue;
				}
				case 32u:
					playerState2.State = State.Lose;
					flag9 = !Losers.Contains(num6);
					num = 1784530755;
					continue;
				case 31u:
				{
					int num21;
					int num22;
					if (!flag7)
					{
						num21 = 1489804107;
						num22 = 1489804107;
					}
					else
					{
						num21 = 1019067177;
						num22 = 1019067177;
					}
					num = num21 ^ ((int)num2 * -1591406376);
					continue;
				}
				case 30u:
					num = ((int)num2 * -794882336) ^ -49043009;
					continue;
				case 29u:
					num5 = ((card.Type == 4) ? 1 : 0);
					goto IL_0430;
				case 28u:
				{
					int num19;
					int num20;
					if (flag3)
					{
						num19 = 1395337798;
						num20 = 1395337798;
					}
					else
					{
						num19 = 1292721959;
						num20 = 1292721959;
					}
					num = num19 ^ (int)(num2 * 2146567269);
					continue;
				}
				case 27u:
					num = ((int)num2 * -1409511449) ^ 0x7D82CD7;
					continue;
				case 26u:
					num = ((int)num2 * -1136244859) ^ 0x42BECC8B;
					continue;
				case 25u:
					num = (int)((num2 * 318725403) ^ 0x40C99F2);
					continue;
				case 24u:
					num10 = card.Impact;
					num = ((int)num2 * -128831596) ^ -2039776819;
					continue;
				case 23u:
				{
					int num17;
					int num18;
					if (flag8)
					{
						num17 = 1674201463;
						num18 = 1674201463;
					}
					else
					{
						num17 = 29538900;
						num18 = 29538900;
					}
					num = num17 ^ (int)(num2 * 822376706);
					continue;
				}
				case 22u:
					num = (int)(num2 * 1194967253) ^ -1221068850;
					continue;
				case 21u:
					playerState2 = _playerStates[num6];
					num = (int)((num2 * 835645057) ^ 0x6008726B);
					continue;
				case 20u:
				{
					int num11;
					int num12;
					if (playerState.State != 0)
					{
						num11 = -1391470272;
						num12 = -1391470272;
					}
					else
					{
						num11 = -902201060;
						num12 = -902201060;
					}
					num = num11 ^ (int)(num2 * 1369291143);
					continue;
				}
				case 19u:
					flag5 = true;
					num = ((int)num2 * -319518798) ^ -1215679547;
					continue;
				case 18u:
					num = ((int)num2 * -649111955) ^ -196281497;
					continue;
				case 17u:
					flag7 = playerState.Sprint > Rules.SprintCount;
					num = 1010319770;
					continue;
				case 16u:
					num7 = 0;
					num = ((int)num2 * -1453366786) ^ 0xBAC91E2;
					continue;
				case 15u:
					num = 1677474165;
					continue;
				case 14u:
					num = ((int)num2 * -1385665126) ^ 0x39C97F2D;
					continue;
				case 13u:
					num = (int)(num2 * 326543229) ^ -2109241144;
					continue;
				case 12u:
					num = 1194479998;
					continue;
				case 11u:
					num = (int)((num2 * 267246338) ^ 0x58928128);
					continue;
				case 10u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag4 ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num10), flag5 ? "advance" : "stay");
					num = 329809274;
					continue;
				case 9u:
					num = ((int)num2 * -142629513) ^ 0x4DAF256C;
					continue;
				case 8u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -997475935) ^ 0x2197F516;
					continue;
				case 7u:
					num6 = 0;
					num = 812889647;
					continue;
				case 6u:
					num = ((int)num2 * -113892690) ^ -1317214199;
					continue;
				case 5u:
				{
					int num8;
					if (num7 != playerIndex)
					{
						num = 1122671455;
						num8 = 1122671455;
					}
					else
					{
						num = 2030286820;
						num8 = 2030286820;
					}
					continue;
				}
				case 4u:
					flag3 = num6 < _playerStates.Length;
					num = 1563699472;
					continue;
				case 3u:
					num = 1389316574;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2093465880;
						num4 = 2093465880;
					}
					else
					{
						num3 = 336807354;
						num4 = 336807354;
					}
					num = num3 ^ ((int)num2 * -2090940235);
					continue;
				}
				case 1u:
					num = 407840282;
					continue;
				case 0u:
					num = 1160599174;
					continue;
				default:
					return;
				case 78u:
					break;
				case 36u:
					return;
					IL_0430:
					flag4 = (byte)num5 != 0;
					if (!flag2)
					{
						num = 48566777;
						num9 = 48566777;
					}
					else
					{
						num = 274793745;
						num9 = 274793745;
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
			int num = -1486750100;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE32B6CA0u) % 9u)
				{
				case 8u:
					result = card;
					num = ((int)num2 * -577542293) ^ -1683509683;
					continue;
				case 7u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 1821197323) ^ 0x78DA4BF5);
					continue;
				case 6u:
					flag = _deck.Count <= 0;
					num = (int)((num2 * 314290543) ^ 0x4EAF8D00);
					continue;
				case 4u:
					card = _deck[0];
					num = -374538243;
					continue;
				case 3u:
					ShuffleCards();
					num = (int)((num2 * 350664469) ^ 0x3575E173);
					continue;
				case 2u:
					num = ((int)num2 * -2069058106) ^ -1593570696;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1915400930;
						num4 = 1915400930;
					}
					else
					{
						num3 = 10320746;
						num4 = 10320746;
					}
					num = num3 ^ ((int)num2 * -1026263073);
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
		int num3 = default(int);
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1549485212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFAD4E493u) % 9u)
				{
				case 8u:
					num3 = 0;
					num = ((int)num2 * -1624543774) ^ 0x6BA6FCA7;
					continue;
				case 6u:
					text = "";
					num = ((int)num2 * -111026115) ^ -1220843844;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -146217674;
						num5 = -146217674;
					}
					else
					{
						num4 = -414295391;
						num5 = -414295391;
					}
					num = num4 ^ (int)(num2 * 817661316);
					continue;
				}
				case 3u:
					flag = num3 < _playerStates.Length;
					num = -1490811123;
					continue;
				case 2u:
					result = text;
					num = (int)(num2 * 1218287546) ^ -1594820099;
					continue;
				case 1u:
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
					num = -792910385;
					continue;
				}
				case 0u:
					num = ((int)num2 * -1873803984) ^ 0x5E876D5A;
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
		string result = default(string);
		while (true)
		{
			int num = 1635501220;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F66763Bu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = ToString(initial: false);
				num = ((int)num2 * -1016345113) ^ -345536635;
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
