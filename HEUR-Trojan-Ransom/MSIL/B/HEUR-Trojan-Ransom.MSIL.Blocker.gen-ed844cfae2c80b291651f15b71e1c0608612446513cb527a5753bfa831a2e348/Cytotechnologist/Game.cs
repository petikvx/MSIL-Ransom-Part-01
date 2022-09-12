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
			int num5 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			PlayerState playerState = default(PlayerState);
			bool flag = default(bool);
			while (true)
			{
				int num = 1388648694;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBBD2688u) % 15u)
					{
					case 14u:
						result = true;
						num = (int)(num2 * 755647184) ^ -1252396462;
						continue;
					case 13u:
						result = true;
						num = (int)((num2 * 2043194453) ^ 0x7C0D2F66);
						continue;
					case 12u:
					{
						int num8;
						if (num5 >= playerStates.Length)
						{
							num = 2024445316;
							num8 = 2024445316;
						}
						else
						{
							num = 55175755;
							num8 = 55175755;
						}
						continue;
					}
					case 11u:
						result = false;
						num = (int)((num2 * 576170877) ^ 0x320182F);
						continue;
					case 10u:
						num = (int)(num2 * 1208703146) ^ -1359653622;
						continue;
					case 9u:
						num5++;
						num = 943895562;
						continue;
					case 8u:
						playerStates = _playerStates;
						num5 = 0;
						num = (int)((num2 * 1894274411) ^ 0x718DD559);
						continue;
					case 7u:
					{
						int num6;
						int num7;
						if (finished)
						{
							num6 = 1137730468;
							num7 = 1137730468;
						}
						else
						{
							num6 = 1762945132;
							num7 = 1762945132;
						}
						num = num6 ^ ((int)num2 * -1164536982);
						continue;
					}
					case 6u:
						playerState = playerStates[num5];
						num = 1180616294;
						continue;
					case 4u:
						num = (int)((num2 * 492611367) ^ 0x5534F7D0);
						continue;
					case 2u:
						num = 527602481;
						continue;
					case 1u:
						flag = playerState.State == State.Playing;
						num = ((int)num2 * -557091644) ^ -1850970779;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1810189213;
							num4 = -1810189213;
						}
						else
						{
							num3 = -1870916330;
							num4 = -1870916330;
						}
						num = num3 ^ ((int)num2 * -2006181787);
						continue;
					}
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
		int num4 = default(int);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		while (true)
		{
			int num = -1133412196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1881A98u) % 18u)
				{
				case 17u:
					num4 = 0;
					num = ((int)num2 * -440061386) ^ 0x638D5FA0;
					continue;
				case 16u:
					_buffer = buffer;
					num = ((int)num2 * -163119234) ^ 0x5F54FE57;
					continue;
				case 15u:
					count = jSONNode.Count;
					num = (int)(num2 * 538875105) ^ -1785167180;
					continue;
				case 13u:
					Rules = Rules.Deserialize(json["rules"]);
					num = (int)((num2 * 468765652) ^ 0x10BEA102);
					continue;
				case 12u:
					_playerStates[num4] = new PlayerState();
					num = -1867607817;
					continue;
				case 10u:
					num = ((int)num2 * -1479585177) ^ -1828303476;
					continue;
				case 9u:
					num4++;
					num = ((int)num2 * -865419381) ^ -988815869;
					continue;
				case 8u:
					num3++;
					num = ((int)num2 * -1060335952) ^ -1573970367;
					continue;
				case 7u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = -828575918;
					continue;
				case 6u:
					jSONNode = json["players"];
					num = (int)(num2 * 1109879652) ^ -428867257;
					continue;
				case 5u:
				{
					int num6;
					if (num3 < count)
					{
						num = -1846101533;
						num6 = -1846101533;
					}
					else
					{
						num = -479186042;
						num6 = -479186042;
					}
					continue;
				}
				case 4u:
					_playerStates = new PlayerState[count];
					num = (int)((num2 * 782497333) ^ 0x6CA80727);
					continue;
				case 3u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -2016103873) ^ -1161530372;
					continue;
				case 2u:
				{
					int num5;
					if (num4 < count)
					{
						num = -62409962;
						num5 = -62409962;
					}
					else
					{
						num = -274555660;
						num5 = -274555660;
					}
					continue;
				}
				case 1u:
					Players = new Player[count];
					num3 = 0;
					num = ((int)num2 * -44400799) ^ -1865579390;
					continue;
				case 0u:
					_dice = new Dice();
					num = ((int)num2 * -1184990253) ^ -218715562;
					continue;
				default:
					return;
				case 11u:
					break;
				case 14u:
					return;
				}
				break;
			}
		}
	}

	public void ShuffleCards()
	{
		while (true)
		{
			int num = 35703791;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E7439D6u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				_deck = new List<Card>(Rules.Cards);
				num = (int)((num2 * 1619335776) ^ 0x6FF6448B);
			}
		}
	}

	public void StartNew()
	{
		while (true)
		{
			int num = 1439846443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C01A2C4u) % 8u)
				{
				case 7u:
					ShuffleCards();
					num = ((int)num2 * -137077747) ^ 0x1C4649F3;
					continue;
				case 6u:
					Losers.Clear();
					num = ((int)num2 * -1590301507) ^ 0x402DC670;
					continue;
				case 5u:
					num = (int)(num2 * 239320185) ^ -2132568393;
					continue;
				case 4u:
					Winners.Clear();
					num = ((int)num2 * -2074241898) ^ -664524151;
					continue;
				case 3u:
					_currentTurn = 0;
					_finished = false;
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = (int)(num2 * 1318744708) ^ -1647653079;
					continue;
				case 2u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1247936503) ^ -1137625603;
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

	public void PlanningState()
	{
		int num = 0;
		bool flag = default(bool);
		PlayerState playerState = default(PlayerState);
		int num4 = default(int);
		int planningCardsCount = default(int);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		while (true)
		{
			int num2 = 963059618;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x5B543681u) % 25u)
				{
				case 24u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -1088106977;
						num10 = -1088106977;
					}
					else
					{
						num9 = -269230755;
						num10 = -269230755;
					}
					num2 = num9 ^ (int)(num3 * 866969315);
					continue;
				}
				case 23u:
				{
					int num8;
					if (num >= Players.Length)
					{
						num2 = 1720274171;
						num8 = 1720274171;
					}
					else
					{
						num2 = 2022899346;
						num8 = 2022899346;
					}
					continue;
				}
				case 22u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -1499473814) ^ -1069329908;
					continue;
				case 21u:
					num4 = 0;
					num2 = ((int)num3 * -573781386) ^ 0x3FDF45DB;
					continue;
				case 20u:
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num2 = (int)(num3 * 1124139582) ^ -809190432;
					continue;
				case 19u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num++;
					num2 = 884300691;
					continue;
				case 18u:
					playerState.Sprint = 0;
					num2 = (int)(num3 * 588232738) ^ -1091519135;
					continue;
				case 17u:
					flag = planningCardsCount == 0;
					num2 = (int)((num3 * 334871428) ^ 0x4E6A0804);
					continue;
				case 16u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num2 = ((int)num3 * -344065230) ^ -1191763072;
					continue;
				case 15u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num2 = (int)(num3 * 1974098465) ^ -1412072868;
					continue;
				case 14u:
				{
					int num6;
					int num7;
					if (!useOneMorePlanningSprint)
					{
						num6 = -1031004832;
						num7 = -1031004832;
					}
					else
					{
						num6 = -1845290744;
						num7 = -1845290744;
					}
					num2 = num6 ^ (int)(num3 * 1644962615);
					continue;
				}
				case 13u:
				{
					int num5;
					if (num4 <= 0)
					{
						num2 = 29455299;
						num5 = 29455299;
					}
					else
					{
						num2 = 1678250499;
						num5 = 1678250499;
					}
					continue;
				}
				case 12u:
					playerState = _playerStates[num];
					num2 = (int)(num3 * 2054047292) ^ -442342294;
					continue;
				case 10u:
					num2 = ((int)num3 * -1685324368) ^ -1386118013;
					continue;
				case 9u:
					num4 = 0;
					num2 = 1504949476;
					continue;
				case 7u:
					player = Players[num];
					num2 = 893285712;
					continue;
				case 6u:
					num2 = 1386108852;
					continue;
				case 5u:
					playerState.Sprint = -1;
					num2 = ((int)num3 * -1435579487) ^ 0x6A278BF3;
					continue;
				case 4u:
					num2 = 1957518006;
					continue;
				case 3u:
					num2 = (int)(num3 * 1432942642) ^ -1797098021;
					continue;
				case 2u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num2 = ((int)num3 * -1139777501) ^ -949741750;
					continue;
				case 1u:
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = ((int)num3 * -850201999) ^ 0x7785E95F;
					continue;
				case 0u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = ((int)num3 * -1365065436) ^ 0x4180680B;
					continue;
				default:
					return;
				case 8u:
					break;
				case 11u:
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
			int num = 555257338;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A4C8BF8u) % 11u)
				{
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 830686042) ^ -373785189;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1405397683;
						num6 = -1405397683;
					}
					else
					{
						num5 = -781629872;
						num6 = -781629872;
					}
					num = num5 ^ (int)(num2 * 1502372868);
					continue;
				}
				case 6u:
					num = ((int)num2 * -562050189) ^ -690527427;
					continue;
				case 5u:
					PlayerTurn(_currentPlayer);
					num = 1079878571;
					continue;
				case 4u:
				{
					_currentPlayer = 0;
					int num3;
					int num4;
					if (_currentTurn > 0)
					{
						num3 = 96058867;
						num4 = 96058867;
					}
					else
					{
						num3 = 1871107847;
						num4 = 1871107847;
					}
					num = num3 ^ ((int)num2 * -15457366);
					continue;
				}
				case 3u:
					num = ((int)num2 * -679912252) ^ -166338447;
					continue;
				case 2u:
					_currentPlayer++;
					flag = _currentPlayer >= Players.Length;
					num = ((int)num2 * -634678232) ^ 0x73DDAA24;
					continue;
				case 1u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 329941304) ^ 0x6361EC5D);
					continue;
				case 0u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 2022031408;
					continue;
				default:
					return;
				case 8u:
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
		PlayerState playerState2 = default(PlayerState);
		int num5 = default(int);
		int num21 = default(int);
		bool flag7 = default(bool);
		Card card = default(Card);
		bool flag6 = default(bool);
		int num6 = default(int);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			int num = -1376128962;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0xED15A9DBu) % 82u)
				{
				case 81u:
					num = ((int)num2 * -1102679496) ^ -1472363203;
					continue;
				case 80u:
					num = ((int)num2 * -803526935) ^ 0x5E18BEB8;
					continue;
				case 79u:
					num = ((int)num2 * -1552294371) ^ -555054886;
					continue;
				case 78u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)(num2 * 165960708) ^ -617244243;
					continue;
				case 77u:
					playerState = _playerStates[playerIndex];
					num = (int)((num2 * 1012934323) ^ 0xDCBA869);
					continue;
				case 76u:
				{
					int num34;
					int num35;
					if (!flag9)
					{
						num34 = -1686844751;
						num35 = -1686844751;
					}
					else
					{
						num34 = -802519002;
						num35 = -802519002;
					}
					num = num34 ^ (int)(num2 * 1138421626);
					continue;
				}
				case 75u:
					playerState2 = _playerStates[num5];
					num = -1425803404;
					continue;
				case 74u:
					Print(playerState.State);
					num = ((int)num2 * -1195702014) ^ -392504508;
					continue;
				case 73u:
					flag9 = num21 < _playerStates.Length;
					num = -241623827;
					continue;
				case 72u:
				{
					int num18;
					if (flag7)
					{
						num = -1859318870;
						num18 = -1859318870;
					}
					else
					{
						num = -2034460849;
						num18 = -2034460849;
					}
					continue;
				}
				case 71u:
					num = -1718743690;
					continue;
				case 70u:
					card = DrawCard();
					num = ((int)num2 * -1287125199) ^ -1887535051;
					continue;
				case 69u:
				{
					int num16;
					int num17;
					if (flag6)
					{
						num16 = 890102177;
						num17 = 890102177;
					}
					else
					{
						num16 = 1052188938;
						num17 = 1052188938;
					}
					num = num16 ^ ((int)num2 * -760117833);
					continue;
				}
				case 68u:
					num = (int)(num2 * 709290997) ^ -1334749823;
					continue;
				case 67u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -235610390;
					continue;
				}
				case 66u:
					num = (int)((num2 * 1549237348) ^ 0x4BF406C8);
					continue;
				case 65u:
					num = ((int)num2 * -1103677417) ^ 0x3E1E59F6;
					continue;
				case 64u:
					num = (int)(num2 * 89638800) ^ -1018422010;
					continue;
				case 63u:
					flag7 = true;
					num6 = card.Impact;
					num = (int)(num2 * 2042679058) ^ -1532096069;
					continue;
				case 62u:
					_finished = true;
					num21 = 0;
					num = ((int)num2 * -1448354029) ^ 0x1FF6374;
					continue;
				case 61u:
					num = -1336167140;
					continue;
				case 60u:
					num = (int)((num2 * 120266844) ^ 0x6D6F9968);
					continue;
				case 59u:
				{
					playerState.State = State.Lose;
					int num24;
					int num25;
					if (!Losers.Contains(playerIndex))
					{
						num24 = -256138708;
						num25 = -256138708;
					}
					else
					{
						num24 = -574144443;
						num25 = -574144443;
					}
					num = num24 ^ (int)(num2 * 194937766);
					continue;
				}
				case 58u:
					flag7 = false;
					num = -1292116281;
					continue;
				case 57u:
					playerState.State = State.Won;
					num = ((int)num2 * -334632620) ^ -592257338;
					continue;
				case 55u:
				{
					int num19;
					int num20;
					if (!flag2)
					{
						num19 = 2059575609;
						num20 = 2059575609;
					}
					else
					{
						num19 = 1788105010;
						num20 = 1788105010;
					}
					num = num19 ^ (int)(num2 * 1328291065);
					continue;
				}
				case 53u:
					Losers.Add(num5);
					num = ((int)num2 * -516015197) ^ 0x3FA3107A;
					continue;
				case 52u:
					num = ((int)num2 * -916085655) ^ -158046840;
					continue;
				case 51u:
					playerState.Sprint++;
					num = ((int)num2 * -1900261063) ^ 0xA417B66;
					continue;
				case 50u:
				{
					int num14;
					int num15;
					if (!flag5)
					{
						num14 = -1832011273;
						num15 = -1832011273;
					}
					else
					{
						num14 = -1570915655;
						num15 = -1570915655;
					}
					num = num14 ^ ((int)num2 * -1058471634);
					continue;
				}
				case 49u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 1313503981;
						num10 = 1313503981;
					}
					else
					{
						num9 = 1138639008;
						num10 = 1138639008;
					}
					num = num9 ^ ((int)num2 * -433494117);
					continue;
				}
				case 48u:
					flag4 = playerState.Sprint < 0;
					num = -355282632;
					continue;
				case 47u:
					num5 = 0;
					num = (int)(num2 * 1023135269) ^ -851920726;
					continue;
				case 46u:
					num = ((int)num2 * -2626400) ^ 0x7FBC5C77;
					continue;
				case 45u:
					num = -1977364890;
					continue;
				case 44u:
					flag7 = true;
					Print("CARD: none, advance");
					num = (int)((num2 * 1969543600) ^ 0x387D2BB3);
					continue;
				case 43u:
					num = (int)((num2 * 1992548259) ^ 0x73796E9F);
					continue;
				case 42u:
					flag = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -438328672) ^ 0x113C7CB7;
						continue;
					}
					num11 = 0;
					goto IL_0436;
				case 41u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)(num2 * 1860595317) ^ -541575814;
					continue;
				case 40u:
				{
					int num32;
					int num33;
					if (flag8)
					{
						num32 = -121959595;
						num33 = -121959595;
					}
					else
					{
						num32 = -1588423240;
						num33 = -1588423240;
					}
					num = num32 ^ ((int)num2 * -1392004011);
					continue;
				}
				case 39u:
					num5++;
					num = -1977619223;
					continue;
				case 38u:
					num = -817817748;
					continue;
				case 37u:
				{
					int num30;
					int num31;
					if (flag4)
					{
						num30 = 1389180314;
						num31 = 1389180314;
					}
					else
					{
						num30 = 1073228114;
						num31 = 1073228114;
					}
					num = num30 ^ (int)(num2 * 1253870935);
					continue;
				}
				case 36u:
					num = (int)(num2 * 1321565791) ^ -976611105;
					continue;
				case 35u:
					num = (int)((num2 * 769691017) ^ 0x1EAB4602);
					continue;
				case 34u:
				{
					int num29 = card.Impact - player.PlannedForCard(card.Type);
					flag7 = num29 < Rules.StayOnSprintMinDiff;
					num6 = Game.smethod_3(0, num29);
					num = (int)((num2 * 1058556055) ^ 0x6305795A);
					continue;
				}
				case 33u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1767825667) ^ 0x5819DDB2;
					continue;
				case 32u:
					num = (int)((num2 * 1869151430) ^ 0x3091F8);
					continue;
				case 31u:
					playerState2.State = State.Lose;
					flag6 = !Losers.Contains(num5);
					num = -1460163846;
					continue;
				case 30u:
				{
					int num27;
					int num28;
					if (playerState.State != 0)
					{
						num27 = 1667537409;
						num28 = 1667537409;
					}
					else
					{
						num27 = 900855405;
						num28 = 900855405;
					}
					num = num27 ^ (int)(num2 * 1153098097);
					continue;
				}
				case 29u:
					num21++;
					num = -586883406;
					continue;
				case 28u:
				{
					int num26;
					if (playerState.Sprint <= Rules.SprintCount)
					{
						num = -1977364890;
						num26 = -1977364890;
					}
					else
					{
						num = -2087687446;
						num26 = -2087687446;
					}
					continue;
				}
				case 27u:
				{
					int num23;
					if (num21 == playerIndex)
					{
						num = -1514859733;
						num23 = -1514859733;
					}
					else
					{
						num = -863080939;
						num23 = -863080939;
					}
					continue;
				}
				case 26u:
				{
					int num22;
					if (num5 >= _playerStates.Length)
					{
						num = -1130403528;
						num22 = -1130403528;
					}
					else
					{
						num = -1396325998;
						num22 = -1396325998;
					}
					continue;
				}
				case 25u:
					num = ((int)num2 * -1525995731) ^ 0x47DFB902;
					continue;
				case 24u:
					Losers.Add(num21);
					num = (int)(num2 * 153490550) ^ -1328325737;
					continue;
				case 23u:
					num = ((int)num2 * -1719351753) ^ 0x5D845D92;
					continue;
				case 22u:
					num = (int)((num2 * 188653063) ^ 0x3C5020B5);
					continue;
				case 21u:
					num = ((int)num2 * -1207671650) ^ 0x7977CE0E;
					continue;
				case 20u:
					flag5 = !Losers.Contains(num21);
					num = -373926555;
					continue;
				case 19u:
					num = (int)((num2 * 652151638) ^ 0x2B9C6FA7);
					continue;
				case 18u:
					flag8 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -450650903;
					continue;
				case 17u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag3 ? "ALL " : "", flag ? "receives" : "pays", Game.smethod_4(num6), flag7 ? "advance" : "stay");
					num = -1180333284;
					continue;
				case 16u:
					num = ((int)num2 * -925400216) ^ -780012596;
					continue;
				case 15u:
				{
					int num12;
					int num13;
					if (playerState.Resources < 0)
					{
						num12 = -2090199633;
						num13 = -2090199633;
					}
					else
					{
						num12 = -642412541;
						num13 = -642412541;
					}
					num = num12 ^ ((int)num2 * -1316595623);
					continue;
				}
				case 14u:
					num = -867082779;
					continue;
				case 13u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -1175273154) ^ 0x3B2BDF0D;
					continue;
				case 12u:
					num = -1073370618;
					continue;
				case 11u:
					num = -260726372;
					continue;
				case 10u:
					num = (int)(num2 * 1756912474) ^ -1004929633;
					continue;
				case 9u:
					num = (int)(num2 * 1700901611) ^ -896362502;
					continue;
				case 8u:
					num11 = ((card.Type == 4) ? 1 : 0);
					goto IL_0436;
				case 7u:
				{
					playerState2.Resources -= Game.smethod_3(0, num6 - Players[num5].PlannedForCard(card.Type));
					int num7;
					int num8;
					if (playerState2.Resources < 0)
					{
						num7 = -989679411;
						num8 = -989679411;
					}
					else
					{
						num7 = -1296933508;
						num8 = -1296933508;
					}
					num = num7 ^ ((int)num2 * -1423383587);
					continue;
				}
				case 6u:
					playerState.Resources -= num6;
					num = (int)(num2 * 593441649) ^ -128240718;
					continue;
				case 5u:
					num = -1951976585;
					continue;
				case 4u:
					num = (int)((num2 * 357551831) ^ 0x6D194060);
					continue;
				case 3u:
					num = (int)((num2 * 243628666) ^ 0x4BC004BE);
					continue;
				case 2u:
					flag2 = !flag;
					num = (int)(num2 * 1399870584) ^ -1497626412;
					continue;
				case 1u:
					Winners.Add(playerIndex);
					num = (int)(num2 * 362259657) ^ -1107101965;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!onlyOneWinner)
					{
						num3 = -1210740224;
						num4 = -1210740224;
					}
					else
					{
						num3 = -617586550;
						num4 = -617586550;
					}
					num = num3 ^ ((int)num2 * -1311717865);
					continue;
				}
				default:
					return;
				case 54u:
					break;
				case 56u:
					return;
					IL_0436:
					flag3 = (byte)num11 != 0;
					num = -1059691951;
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
		while (true)
		{
			int num = -1461600919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A57E053u) % 8u)
				{
				case 7u:
					_deck.RemoveAt(0);
					result = card;
					num = ((int)num2 * -2089926200) ^ 0x299454C0;
					continue;
				case 5u:
					ShuffleCards();
					num = ((int)num2 * -1229628301) ^ 0x2EF17420;
					continue;
				case 4u:
					num = (int)(num2 * 1918710105) ^ -1370525745;
					continue;
				case 3u:
					num = (int)(num2 * 1670650382) ^ -577763744;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_deck.Count <= 0)
					{
						num3 = -76619902;
						num4 = -76619902;
					}
					else
					{
						num3 = -748067465;
						num4 = -748067465;
					}
					num = num3 ^ (int)(num2 * 591227994);
					continue;
				}
				case 0u:
					card = _deck[0];
					num = -181832380;
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

	public string ToString(bool initial)
	{
		bool flag = default(bool);
		int num3 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 862306071;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC2B00Bu) % 10u)
				{
				case 9u:
					num = ((int)num2 * -212332183) ^ 0xC006436;
					continue;
				case 7u:
					flag = num3 < _playerStates.Length;
					num = 934423983;
					continue;
				case 5u:
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
					num = 512715550;
					continue;
				}
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1154897027;
						num5 = 1154897027;
					}
					else
					{
						num4 = 300720994;
						num5 = 300720994;
					}
					num = num4 ^ ((int)num2 * -1513006746);
					continue;
				}
				case 3u:
					num = (int)(num2 * 544590535) ^ -1823818059;
					continue;
				case 2u:
					text = "";
					num = ((int)num2 * -102397384) ^ 0x6C1C4D3E;
					continue;
				case 1u:
					num3 = 0;
					num = (int)((num2 * 418974177) ^ 0x78B0A383);
					continue;
				case 0u:
					result = text;
					num = ((int)num2 * -1638512272) ^ -785230498;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -119166983;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83D8A68Eu) % 4u)
				{
				case 3u:
					result = ToString(initial: false);
					num = ((int)num2 * -358120081) ^ 0x112CF9C2;
					continue;
				case 1u:
					num = ((int)num2 * -2034024359) ^ -1577080175;
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
			int num = -975518995;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5E8B0F4u) % 3u)
				{
				case 2u:
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
				num = (int)(num2 * 467423238) ^ -1541586590;
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
