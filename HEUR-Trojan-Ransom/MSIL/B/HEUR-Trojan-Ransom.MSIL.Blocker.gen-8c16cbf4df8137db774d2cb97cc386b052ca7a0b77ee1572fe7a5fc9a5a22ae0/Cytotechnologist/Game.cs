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
			bool result = default(bool);
			while (true)
			{
				int num = 1014357184;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2A9FB3C2u) % 16u)
					{
					case 15u:
						playerState = playerStates[num3];
						num = 1190464581;
						continue;
					case 14u:
						num = ((int)num2 * -759620169) ^ -186493515;
						continue;
					case 13u:
						num = 784312742;
						continue;
					case 12u:
						result = true;
						num = (int)((num2 * 1774339732) ^ 0xE1EEC07);
						continue;
					case 11u:
					{
						int num6;
						if (num3 >= playerStates.Length)
						{
							num = 305983859;
							num6 = 305983859;
						}
						else
						{
							num = 118126813;
							num6 = 118126813;
						}
						continue;
					}
					case 10u:
						num3++;
						num = 34933321;
						continue;
					case 9u:
						result = false;
						num = (int)((num2 * 1528968540) ^ 0xDD9E70);
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (playerState.State != 0)
						{
							num7 = -1367299330;
							num8 = -1367299330;
						}
						else
						{
							num7 = -1373908371;
							num8 = -1373908371;
						}
						num = num7 ^ (int)(num2 * 2005497850);
						continue;
					}
					case 6u:
						num = (int)((num2 * 281728998) ^ 0x4DF6A60D);
						continue;
					case 4u:
						playerStates = _playerStates;
						num = (int)(num2 * 162925873) ^ -2105559770;
						continue;
					case 3u:
						num = ((int)num2 * -18761590) ^ -566298231;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (!_finished)
						{
							num4 = 303570069;
							num5 = 303570069;
						}
						else
						{
							num4 = 40934820;
							num5 = 40934820;
						}
						num = num4 ^ ((int)num2 * -1026890411);
						continue;
					}
					case 1u:
						result = true;
						num = (int)((num2 * 857760989) ^ 0x6D495FBC);
						continue;
					case 0u:
						num3 = 0;
						num = ((int)num2 * -1445375939) ^ 0xEF588D4;
						continue;
					case 8u:
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
		int num5 = default(int);
		bool flag = default(bool);
		int count = default(int);
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 1877570062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41AFC64Cu) % 18u)
				{
				case 17u:
					_playerStates[num5] = new PlayerState();
					num = 473056899;
					continue;
				case 16u:
					num = (int)((num2 * 387617629) ^ 0x3FB632C4);
					continue;
				case 14u:
					flag = num5 < count;
					num = 392000063;
					continue;
				case 13u:
					num3++;
					num = (int)((num2 * 1808075101) ^ 0x79BA4939);
					continue;
				case 12u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = 73884383;
					continue;
				case 11u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = (int)((num2 * 549029450) ^ 0x42354B35);
					continue;
				case 10u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					_dice = new Dice();
					num = (int)((num2 * 571554994) ^ 0x6BC6F);
					continue;
				case 9u:
					num5 = 0;
					num = ((int)num2 * -1743467791) ^ -71863531;
					continue;
				case 8u:
					num = ((int)num2 * -934788719) ^ 0x33862DE6;
					continue;
				case 6u:
					num = ((int)num2 * -1686183602) ^ -1523306536;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -261379859;
						num7 = -261379859;
					}
					else
					{
						num6 = -1052709275;
						num7 = -1052709275;
					}
					num = num6 ^ (int)(num2 * 2050120002);
					continue;
				}
				case 4u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -354517151) ^ 0x7EE87E63;
					continue;
				case 3u:
					num5++;
					num = (int)((num2 * 1558832492) ^ 0x550D81A8);
					continue;
				case 2u:
					_buffer = buffer;
					num = ((int)num2 * -1388508657) ^ -699768476;
					continue;
				case 1u:
					Players = new Player[count];
					num3 = 0;
					num = (int)(num2 * 781288720) ^ -1761882018;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= count)
					{
						num = 1417190746;
						num4 = 1417190746;
					}
					else
					{
						num = 1666291746;
						num4 = 1666291746;
					}
					continue;
				}
				default:
					return;
				case 7u:
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
		while (true)
		{
			int num = 1422943700;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4FB58345u) % 6u)
				{
				case 5u:
					ShuffleCards();
					Winners.Clear();
					num = ((int)num2 * -959735925) ^ -1002147870;
					continue;
				case 2u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					_finished = false;
					num = (int)((num2 * 854088309) ^ 0xFA00774);
					continue;
				case 1u:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 2085967711) ^ 0x207B0C74);
					continue;
				case 0u:
					Losers.Clear();
					num = (int)(num2 * 121196558) ^ -1199654861;
					continue;
				default:
					return;
				case 3u:
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
		int num = 0;
		PlayerState playerState = default(PlayerState);
		int num6 = default(int);
		bool flag2 = default(bool);
		int planningCardsCount = default(int);
		Player player = default(Player);
		bool flag = default(bool);
		bool useOneMorePlanningSprint = default(bool);
		while (true)
		{
			int num2 = -1881918814;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x9A46B992u) % 30u)
				{
				case 29u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num2 = ((int)num3 * -623894318) ^ -1338956909;
					continue;
				case 28u:
					num2 = (int)((num3 * 10333069) ^ 0x399DD62F);
					continue;
				case 27u:
					playerState.Sprint = 0;
					num2 = (int)(num3 * 730020498) ^ -1095434930;
					continue;
				case 26u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 112354722;
						num10 = 112354722;
					}
					else
					{
						num9 = 1931667759;
						num10 = 1931667759;
					}
					num2 = num9 ^ (int)(num3 * 438343903);
					continue;
				}
				case 25u:
					num2 = (int)((num3 * 1369852140) ^ 0x7B5B7025);
					continue;
				case 24u:
					num2 = (int)((num3 * 1381649583) ^ 0x6460BA5D);
					continue;
				case 23u:
					num++;
					num2 = ((int)num3 * -1027263113) ^ -1158861504;
					continue;
				case 21u:
					planningCardsCount = player.PlanningCardsCount;
					num6 = 0;
					num2 = (int)(num3 * 801669508) ^ -1536315232;
					continue;
				case 20u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num2 = -856476952;
					continue;
				case 19u:
					player = Players[num];
					playerState = _playerStates[num];
					num2 = -405550303;
					continue;
				case 18u:
					num2 = (int)(num3 * 1289631653) ^ -1311221525;
					continue;
				case 17u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -1574038935) ^ 0x4816880D;
					continue;
				case 16u:
					playerState.Sprint = -1;
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num2 = ((int)num3 * -111769045) ^ 0x18FC89A8;
					continue;
				case 15u:
					num6 = 0;
					num2 = -1778913815;
					continue;
				case 14u:
					playerState.Resources = Rules.InitialResources;
					num2 = (int)(num3 * 1368007759) ^ -1157029436;
					continue;
				case 13u:
					num2 = ((int)num3 * -1381216930) ^ 0x5BB20C13;
					continue;
				case 12u:
					playerState.State = State.Playing;
					num2 = (int)((num3 * 1604384044) ^ 0x6628691);
					continue;
				case 11u:
					flag = num6 > 0;
					num2 = -157272053;
					continue;
				case 10u:
					num2 = ((int)num3 * -168009129) ^ 0x37A9C196;
					continue;
				case 9u:
					num2 = -1449201736;
					continue;
				case 8u:
					flag2 = planningCardsCount == 0;
					num2 = (int)((num3 * 2010091778) ^ 0x284823B4);
					continue;
				case 7u:
				{
					int num11;
					if (num < Players.Length)
					{
						num2 = -311154105;
						num11 = -311154105;
					}
					else
					{
						num2 = -533056266;
						num11 = -533056266;
					}
					continue;
				}
				case 6u:
					num2 = (int)((num3 * 1754108926) ^ 0x52CE76D0);
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 873535421;
						num8 = 873535421;
					}
					else
					{
						num7 = 1435600809;
						num8 = 1435600809;
					}
					num2 = num7 ^ ((int)num3 * -1298935894);
					continue;
				}
				case 4u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num2 = ((int)num3 * -1880517358) ^ -1072583631;
					continue;
				case 3u:
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = (int)((num3 * 1002845562) ^ 0x535305AE);
					continue;
				case 2u:
					num2 = -1339630807;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!useOneMorePlanningSprint)
					{
						num4 = 1530009246;
						num5 = 1530009246;
					}
					else
					{
						num4 = 862619983;
						num5 = 862619983;
					}
					num2 = num4 ^ ((int)num3 * -816607431);
					continue;
				}
				default:
					return;
				case 0u:
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
		if (_currentPlayer >= Players.Length)
		{
			goto IL_0070;
		}
		goto IL_01c4;
		IL_01c4:
		PlayerTurn(_currentPlayer);
		int num = -53674067;
		goto IL_0182;
		IL_0182:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xF17AC55Du) % 12u)
			{
			case 11u:
				num = (int)((num2 * 266994574) ^ 0x456F5D29);
				continue;
			case 10u:
			{
				_currentPlayer = 0;
				int num3;
				int num4;
				if (_currentTurn > 0)
				{
					num3 = -1399848894;
					num4 = -1399848894;
				}
				else
				{
					num3 = -2028314101;
					num4 = -2028314101;
				}
				num = num3 ^ (int)(num2 * 145961907);
				continue;
			}
			case 9u:
				break;
			case 8u:
				Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
				num = -1975129625;
				continue;
			case 7u:
				num = (int)((num2 * 934202250) ^ 0x1A895A67);
				continue;
			case 5u:
				_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
				num = (int)((num2 * 932946970) ^ 0x51EE7C6C);
				continue;
			case 3u:
				Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
				num = (int)(num2 * 676362675) ^ -1545321432;
				continue;
			case 2u:
				num = (int)(num2 * 808436860) ^ -1141761016;
				continue;
			case 1u:
				Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
				num = (int)((num2 * 1901008370) ^ 0x3ED93CEC);
				continue;
			case 0u:
				num = (int)((num2 * 1706786699) ^ 0x433BD0F3);
				continue;
			default:
				return;
			case 6u:
				goto IL_01c4;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0070;
		IL_0070:
		num = -289378982;
		goto IL_0182;
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		int num7 = default(int);
		PlayerState playerState2 = default(PlayerState);
		bool flag = default(bool);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		bool flag6 = default(bool);
		Card card = default(Card);
		int num4 = default(int);
		bool flag7 = default(bool);
		int num3 = default(int);
		bool onlyOneWinner = default(bool);
		bool flag3 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag9 = default(bool);
		bool flag4 = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			int num = 517427046;
			while (true)
			{
				uint num2;
				int num11;
				int num15;
				switch ((num2 = (uint)num ^ 0x35C3CB0Du) % 86u)
				{
				case 85u:
					num7++;
					num = 548071449;
					continue;
				case 84u:
					num = 2104970383;
					continue;
				case 83u:
					num = (int)((num2 * 1411427444) ^ 0x6034905A);
					continue;
				case 82u:
					num = ((int)num2 * -975957914) ^ -498453652;
					continue;
				case 81u:
					num7 = 0;
					num = (int)((num2 * 1876662952) ^ 0x1954AE7E);
					continue;
				case 80u:
				{
					int num27;
					if (playerState2.Sprint < 0)
					{
						num = 2075729748;
						num27 = 2075729748;
					}
					else
					{
						num = 935036135;
						num27 = 935036135;
					}
					continue;
				}
				case 79u:
					num = (int)((num2 * 760218980) ^ 0x434656D9);
					continue;
				case 78u:
					playerState2.State = State.Lose;
					num = ((int)num2 * -1250249756) ^ 0x217F5230;
					continue;
				case 77u:
				{
					int num32;
					int num33;
					if (playerState2.Resources >= 0)
					{
						num32 = 799728218;
						num33 = 799728218;
					}
					else
					{
						num32 = 1590184907;
						num33 = 1590184907;
					}
					num = num32 ^ ((int)num2 * -504719378);
					continue;
				}
				case 76u:
					num = ((int)num2 * -1721268060) ^ -706618528;
					continue;
				case 75u:
					playerState2.Sprint++;
					num = ((int)num2 * -544103956) ^ 0x22ABE87B;
					continue;
				case 74u:
					flag = playerState2.Sprint > Rules.SprintCount;
					num = 1634695587;
					continue;
				case 73u:
					num = 617550006;
					continue;
				case 72u:
					flag5 = true;
					num = ((int)num2 * -1720582229) ^ 0x66A8680D;
					continue;
				case 71u:
				{
					int num20;
					int num21;
					if (!flag2)
					{
						num20 = 655152544;
						num21 = 655152544;
					}
					else
					{
						num20 = 1930521246;
						num21 = 1930521246;
					}
					num = num20 ^ (int)(num2 * 1441298901);
					continue;
				}
				case 70u:
					flag6 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -928953065) ^ -358216124;
						continue;
					}
					num11 = 0;
					goto IL_01b0;
				case 69u:
					Losers.Add(num4);
					num = ((int)num2 * -1843630110) ^ -1029556685;
					continue;
				case 68u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag7 ? "ALL " : "", flag6 ? "receives" : "pays", Game.smethod_4(num3), flag5 ? "advance" : "stay");
					num = 369410012;
					continue;
				case 67u:
					playerState2.Sprint++;
					num = (int)(num2 * 529765088) ^ -2024134047;
					continue;
				case 66u:
					Losers.Add(num7);
					num = ((int)num2 * -2127322837) ^ 0x4302BB7F;
					continue;
				case 64u:
				{
					int num18;
					int num19;
					if (!onlyOneWinner)
					{
						num18 = -684876274;
						num19 = -684876274;
					}
					else
					{
						num18 = -206203348;
						num19 = -206203348;
					}
					num = num18 ^ (int)(num2 * 1395626004);
					continue;
				}
				case 63u:
				{
					int num12;
					int num13;
					if (!flag7)
					{
						num12 = 1458622321;
						num13 = 1458622321;
					}
					else
					{
						num12 = 1704492364;
						num13 = 1704492364;
					}
					num = num12 ^ ((int)num2 * -1062045025);
					continue;
				}
				case 62u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = -609948;
						num10 = -609948;
					}
					else
					{
						num9 = -1198024367;
						num10 = -1198024367;
					}
					num = num9 ^ ((int)num2 * -1256985420);
					continue;
				}
				case 61u:
					num = ((int)num2 * -472490513) ^ -2104715380;
					continue;
				case 60u:
					playerState.State = State.Lose;
					num = 671661187;
					continue;
				case 59u:
					num = ((int)num2 * -1564845554) ^ 0x38811AB9;
					continue;
				case 58u:
					Print("CARD: none, advance");
					num = ((int)num2 * -1811810095) ^ 0x27231E22;
					continue;
				case 57u:
				{
					int num34;
					if (num4 < _playerStates.Length)
					{
						num = 1867323490;
						num34 = 1867323490;
					}
					else
					{
						num = 323109724;
						num34 = 323109724;
					}
					continue;
				}
				case 56u:
				{
					int num30;
					int num31;
					if (!flag9)
					{
						num30 = -1417459263;
						num31 = -1417459263;
					}
					else
					{
						num30 = -290707672;
						num31 = -290707672;
					}
					num = num30 ^ (int)(num2 * 323670493);
					continue;
				}
				case 55u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)(num2 * 332014057) ^ -2103897165;
					continue;
				case 54u:
				{
					int num28;
					int num29;
					if (!Losers.Contains(num7))
					{
						num28 = 1049000509;
						num29 = 1049000509;
					}
					else
					{
						num28 = 369174811;
						num29 = 369174811;
					}
					num = num28 ^ ((int)num2 * -206134561);
					continue;
				}
				case 53u:
					num = 960701943;
					continue;
				case 52u:
					num = (int)((num2 * 1509464392) ^ 0x97BE174);
					continue;
				case 51u:
					num = (int)(num2 * 1821875833) ^ -2123931051;
					continue;
				case 50u:
					num4 = 0;
					num = ((int)num2 * -1956262216) ^ -823613706;
					continue;
				case 49u:
					num = 251578060;
					continue;
				case 48u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 202505049) ^ 0x742B2430);
					continue;
				case 47u:
					flag9 = playerState2.State != State.Playing;
					num = (int)((num2 * 216266933) ^ 0x2E8870FE);
					continue;
				case 46u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)((num2 * 602552956) ^ 0x58B94FEF);
					continue;
				case 45u:
					num = ((int)num2 * -1019828466) ^ 0x6AD59D02;
					continue;
				case 44u:
					num = ((int)num2 * -1168470915) ^ -1957079546;
					continue;
				case 43u:
				{
					int num25;
					int num26;
					if (!flag4)
					{
						num25 = 367435696;
						num26 = 367435696;
					}
					else
					{
						num25 = 1014611478;
						num26 = 1014611478;
					}
					num = num25 ^ ((int)num2 * -743917424);
					continue;
				}
				case 42u:
				{
					int num23;
					int num24;
					if (flag8)
					{
						num23 = 2142122340;
						num24 = 2142122340;
					}
					else
					{
						num23 = 683108823;
						num24 = 683108823;
					}
					num = num23 ^ (int)(num2 * 743113124);
					continue;
				}
				case 41u:
					flag5 = false;
					num = 592270491;
					continue;
				case 39u:
					num11 = ((card.Type == 4) ? 1 : 0);
					goto IL_01b0;
				case 38u:
					num = ((int)num2 * -1687256943) ^ -576706140;
					continue;
				case 37u:
					num = ((int)num2 * -2013749797) ^ 0x453255A4;
					continue;
				case 36u:
					playerState2.Resources -= num3;
					num = (int)(num2 * 2073900094) ^ -142450528;
					continue;
				case 35u:
				{
					int num22 = card.Impact - player.PlannedForCard(card.Type);
					flag5 = num22 < Rules.StayOnSprintMinDiff;
					num3 = Game.smethod_3(0, num22);
					num = ((int)num2 * -1437533232) ^ 0x6CB48AFA;
					continue;
				}
				case 34u:
					Print(playerState2.State);
					num = ((int)num2 * -559719822) ^ -405876105;
					continue;
				case 33u:
					playerState2.State = State.Won;
					num = ((int)num2 * -418392) ^ -1315212944;
					continue;
				case 32u:
					num = ((int)num2 * -1438763753) ^ -557190974;
					continue;
				case 31u:
				{
					int num16;
					int num17;
					if (!Losers.Contains(playerIndex))
					{
						num16 = -659638798;
						num17 = -659638798;
					}
					else
					{
						num16 = -995387713;
						num17 = -995387713;
					}
					num = num16 ^ (int)(num2 * 618818665);
					continue;
				}
				case 30u:
				{
					int num14;
					if (num7 < _playerStates.Length)
					{
						num = 1972430435;
						num14 = 1972430435;
					}
					else
					{
						num = 1168939300;
						num14 = 1168939300;
					}
					continue;
				}
				case 29u:
					flag8 = flag5;
					num = 228975605;
					continue;
				case 28u:
					num = 1861134311;
					continue;
				case 27u:
					num = ((int)num2 * -1692764945) ^ -1331865359;
					continue;
				case 26u:
					num = 1122078307;
					continue;
				case 25u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 556543688;
					continue;
				}
				case 24u:
				{
					int num8;
					if (!_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = 1328345681;
						num8 = 1328345681;
					}
					else
					{
						num = 248383973;
						num8 = 248383973;
					}
					continue;
				}
				case 23u:
					flag5 = true;
					num = (int)((num2 * 1113668450) ^ 0x47D4D28D);
					continue;
				case 22u:
					num = 1630239156;
					continue;
				case 21u:
					num = (int)((num2 * 2059950125) ^ 0x4D18FFBB);
					continue;
				case 20u:
					num = ((int)num2 * -1671386405) ^ 0x125EA81B;
					continue;
				case 19u:
					num = (int)((num2 * 27673563) ^ 0x31FF9E9F);
					continue;
				case 18u:
					flag4 = num4 == playerIndex;
					num = (int)(num2 * 1197991579) ^ -1184312352;
					continue;
				case 17u:
					flag3 = !Losers.Contains(num4);
					num = 729924481;
					continue;
				case 16u:
					card = DrawCard();
					num = ((int)num2 * -465479873) ^ -424235091;
					continue;
				case 15u:
					Winners.Add(playerIndex);
					num = ((int)num2 * -2052567747) ^ 0x7CD57856;
					continue;
				case 14u:
					Print("Still planning");
					num = ((int)num2 * -1181307586) ^ -537084528;
					continue;
				case 13u:
					num = (int)((num2 * 1932805903) ^ 0x1519C055);
					continue;
				case 12u:
					playerState = _playerStates[num7];
					num = 407245314;
					continue;
				case 11u:
					playerState.Resources -= Game.smethod_3(0, num3 - Players[num7].PlannedForCard(card.Type));
					flag2 = playerState.Resources >= 0;
					num = ((int)num2 * -1606114436) ^ 0x7F337B0C;
					continue;
				case 10u:
					num = (int)(num2 * 77574662) ^ -1447615041;
					continue;
				case 9u:
					playerState2 = _playerStates[playerIndex];
					num = (int)((num2 * 1775419793) ^ 0x1A27F82F);
					continue;
				case 8u:
					num = 2044089496;
					continue;
				case 7u:
					_finished = true;
					num = (int)(num2 * 1106228439) ^ -1849926140;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1347844252;
						num6 = 1347844252;
					}
					else
					{
						num5 = 270964211;
						num6 = 270964211;
					}
					num = num5 ^ ((int)num2 * -1048471272);
					continue;
				}
				case 5u:
					num = 905317516;
					continue;
				case 4u:
					num4++;
					num = 1646940070;
					continue;
				case 3u:
					num = ((int)num2 * -1188017686) ^ -1341818699;
					continue;
				case 2u:
					num3 = card.Impact;
					num = ((int)num2 * -360726840) ^ 0x19EFB869;
					continue;
				case 1u:
					num = (int)((num2 * 1935500921) ^ 0x31441F5C);
					continue;
				case 0u:
					num = ((int)num2 * -255094654) ^ -1594857145;
					continue;
				default:
					return;
				case 40u:
					break;
				case 65u:
					return;
					IL_01b0:
					flag7 = (byte)num11 != 0;
					if (!flag6)
					{
						num = 691545794;
						num15 = 691545794;
					}
					else
					{
						num = 745024855;
						num15 = 745024855;
					}
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		bool flag = _deck.Count <= 0;
		Card result = default(Card);
		Card card = default(Card);
		while (true)
		{
			int num = -914085598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECAEC25Cu) % 8u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1027324111;
						num4 = 1027324111;
					}
					else
					{
						num3 = 1877155028;
						num4 = 1877155028;
					}
					num = num3 ^ ((int)num2 * -1333066273);
					continue;
				}
				case 5u:
					result = card;
					num = ((int)num2 * -928429177) ^ 0x27DE9C3C;
					continue;
				case 4u:
					num = (int)(num2 * 716095870) ^ -1418324447;
					continue;
				case 2u:
					ShuffleCards();
					num = ((int)num2 * -1122199527) ^ -283518490;
					continue;
				case 1u:
					card = _deck[0];
					_deck.RemoveAt(0);
					num = -2041606616;
					continue;
				case 0u:
					num = ((int)num2 * -1481911667) ^ 0xF00048D;
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
		string text = "";
		int num = 0;
		string result = default(string);
		while (true)
		{
			int num2 = 1637364332;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD34B8FCu) % 6u)
				{
				case 4u:
					num2 = (int)((num3 * 2072471293) ^ 0x1CDE0A9C);
					continue;
				case 2u:
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
					num++;
					num2 = 2071222988;
					continue;
				}
				case 1u:
					result = text;
					num2 = ((int)num3 * -441880934) ^ 0xD44B547;
					continue;
				case 0u:
				{
					int num4;
					if (num >= _playerStates.Length)
					{
						num2 = 561214413;
						num4 = 561214413;
					}
					else
					{
						num2 = 1304557288;
						num4 = 1304557288;
					}
					continue;
				}
				case 3u:
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
			int num = -379612650;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4C658AAu) % 3u)
				{
				case 1u:
					goto IL_000a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000a:
				num = (int)(num2 * 473616574) ^ -1704575338;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = -1241983836;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFFF83F96u) % 4u)
				{
				case 2u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = ((int)num2 * -594386097) ^ -1461196403;
					continue;
				case 1u:
					Game.smethod_8(_buffer, string_);
					num = ((int)num2 * -987535444) ^ 0x4EA41E4D;
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
