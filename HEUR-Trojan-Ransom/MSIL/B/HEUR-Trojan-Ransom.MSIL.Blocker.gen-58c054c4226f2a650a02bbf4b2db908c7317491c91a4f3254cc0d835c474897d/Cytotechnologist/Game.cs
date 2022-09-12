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
			int num3 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			bool result = default(bool);
			while (true)
			{
				int num = 994771237;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5AB3BF97u) % 14u)
					{
					case 13u:
						num3++;
						num = 1834952511;
						continue;
					case 12u:
					{
						int num6;
						int num7;
						if (finished)
						{
							num6 = 1338613072;
							num7 = 1338613072;
						}
						else
						{
							num6 = 1248486368;
							num7 = 1248486368;
						}
						num = num6 ^ (int)(num2 * 1675971357);
						continue;
					}
					case 11u:
						playerStates = _playerStates;
						num3 = 0;
						num = (int)((num2 * 1270721600) ^ 0x61343BFF);
						continue;
					case 9u:
						num = ((int)num2 * -460495525) ^ 0x3281D970;
						continue;
					case 8u:
					{
						int num5;
						if (num3 >= playerStates.Length)
						{
							num = 1450771103;
							num5 = 1450771103;
						}
						else
						{
							num = 710997421;
							num5 = 710997421;
						}
						continue;
					}
					case 6u:
					{
						PlayerState playerState = playerStates[num3];
						int num4;
						if (playerState.State == State.Playing)
						{
							num = 1058999945;
							num4 = 1058999945;
						}
						else
						{
							num = 1887844476;
							num4 = 1887844476;
						}
						continue;
					}
					case 5u:
						num = (int)(num2 * 475498977) ^ -3700270;
						continue;
					case 4u:
						result = true;
						num = (int)(num2 * 81459381) ^ -2120324998;
						continue;
					case 3u:
						num = 1765382644;
						continue;
					case 2u:
						num = (int)(num2 * 1029592959) ^ -589022297;
						continue;
					case 1u:
						result = true;
						num = ((int)num2 * -883388591) ^ 0x43F14F5A;
						continue;
					case 0u:
						result = false;
						num = ((int)num2 * -1013124627) ^ 0x7FFC3894;
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		int num6 = default(int);
		bool flag2 = default(bool);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1288209816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x405926E4u) % 17u)
				{
				case 16u:
					num = ((int)num2 * -1614295018) ^ -797343556;
					continue;
				case 15u:
					_playerStates[num6] = new PlayerState();
					num = 490119895;
					continue;
				case 14u:
					flag2 = num6 < count;
					num = 1407730589;
					continue;
				case 13u:
					num6++;
					num = ((int)num2 * -1740356670) ^ 0xE800E1F;
					continue;
				case 12u:
					count = jSONNode.Count;
					num = ((int)num2 * -1255178677) ^ 0xAC5D0C7;
					continue;
				case 11u:
					_playerStates = new PlayerState[count];
					num6 = 0;
					num = (int)(num2 * 1496096799) ^ -364642003;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1599597283;
						num8 = -1599597283;
					}
					else
					{
						num7 = -79604159;
						num8 = -79604159;
					}
					num = num7 ^ (int)(num2 * 1340370183);
					continue;
				}
				case 9u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = 1891347023;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1691722326;
						num5 = -1691722326;
					}
					else
					{
						num4 = -577343138;
						num5 = -577343138;
					}
					num = num4 ^ ((int)num2 * -540445725);
					continue;
				}
				case 7u:
					num3++;
					num = ((int)num2 * -828848287) ^ -1990323011;
					continue;
				case 6u:
					Rules = Rules.Deserialize(json["rules"]);
					_dice = new Dice();
					jSONNode = json["players"];
					num = (int)((num2 * 2049244098) ^ 0x61D72FEF);
					continue;
				case 5u:
					Players = new Player[count];
					num3 = 0;
					num = (int)(num2 * 1812748831) ^ -309683355;
					continue;
				case 2u:
					_buffer = buffer;
					num = (int)((num2 * 235160215) ^ 0x63D2C09D);
					continue;
				case 1u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -309814077) ^ 0x69A608DF;
					continue;
				case 0u:
					flag = num3 < count;
					num = 633540054;
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
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
			int num = 1181645193;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F179E70u) % 7u)
				{
				case 6u:
					Losers.Clear();
					num = (int)((num2 * 2021409986) ^ 0x14BA886C);
					continue;
				case 4u:
					Winners.Clear();
					num = ((int)num2 * -526784298) ^ -592308095;
					continue;
				case 3u:
					ShuffleCards();
					num = (int)(num2 * 364525686) ^ -917341354;
					continue;
				case 2u:
					_currentTurn = 0;
					_finished = false;
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 1313710752) ^ 0x599E538F);
					continue;
				case 1u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 1469880360) ^ 0x286A490C);
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		int num8 = default(int);
		int planningCardsCount = default(int);
		Player player = default(Player);
		int num3 = default(int);
		PlayerState playerState = default(PlayerState);
		bool useOneMorePlanningSprint = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1034853864;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF3B51B8u) % 28u)
				{
				case 27u:
					num8 = 0;
					num = -148324011;
					continue;
				case 26u:
					num = -1489120133;
					continue;
				case 25u:
					planningCardsCount = player.PlanningCardsCount;
					num8 = 0;
					num = ((int)num2 * -3562413) ^ 0x5D9F3025;
					continue;
				case 24u:
					num3 = 0;
					num = (int)((num2 * 820016159) ^ 0x2A10F00E);
					continue;
				case 23u:
					playerState.Sprint = 1;
					num = (int)(num2 * 997037505) ^ -686523596;
					continue;
				case 22u:
					num = ((int)num2 * -1555484948) ^ -130279642;
					continue;
				case 21u:
				{
					int num6;
					int num7;
					if (useOneMorePlanningSprint)
					{
						num6 = -844357310;
						num7 = -844357310;
					}
					else
					{
						num6 = -1828410403;
						num7 = -1828410403;
					}
					num = num6 ^ (int)(num2 * 1857675737);
					continue;
				}
				case 20u:
					num = ((int)num2 * -23597012) ^ 0x5574BF75;
					continue;
				case 19u:
					num8 = planningCardsCount - Rules.NormalPlanningCount;
					num = (int)(num2 * 1949916714) ^ -444272151;
					continue;
				case 18u:
					num = ((int)num2 * -1550404858) ^ -393213175;
					continue;
				case 17u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = -1995595436;
						num12 = -1995595436;
					}
					else
					{
						num11 = -1772900755;
						num12 = -1772900755;
					}
					num = num11 ^ ((int)num2 * -607873364);
					continue;
				}
				case 16u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num = (int)((num2 * 385484482) ^ 0x7881F8C1);
					continue;
				case 15u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = (int)((num2 * 1097376296) ^ 0xF729B69);
					continue;
				case 14u:
					flag = planningCardsCount == 0;
					num = ((int)num2 * -1232274068) ^ 0x654B5F9;
					continue;
				case 11u:
					playerState.Sprint = -1;
					playerState.Resources -= num8 * Rules.NormalPlanningCost;
					num = (int)((num2 * 1381811857) ^ 0x7B716B09);
					continue;
				case 10u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = -766534717;
						num10 = -766534717;
					}
					else
					{
						num9 = -164478328;
						num10 = -164478328;
					}
					num = num9 ^ (int)(num2 * 2096157110);
					continue;
				}
				case 9u:
					num = -2146686445;
					continue;
				case 8u:
					playerState.Resources -= num8 * Rules.OverPlanningCost;
					num = ((int)num2 * -887931394) ^ 0x24A65928;
					continue;
				case 7u:
					playerState.Resources -= (planningCardsCount - num8) * Rules.NormalPlanningCost;
					num = -975661234;
					continue;
				case 6u:
					num3++;
					num = ((int)num2 * -560325506) ^ -276928646;
					continue;
				case 5u:
					num = -1113968156;
					continue;
				case 4u:
					flag3 = num8 > 0;
					num = -2047979926;
					continue;
				case 3u:
					playerState = _playerStates[num3];
					num = ((int)num2 * -1937181634) ^ -1918702454;
					continue;
				case 2u:
					flag2 = num3 < Players.Length;
					num = -40454975;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -993134791;
						num5 = -993134791;
					}
					else
					{
						num4 = -2035237268;
						num5 = -2035237268;
					}
					num = num4 ^ ((int)num2 * -1290836645);
					continue;
				}
				case 0u:
					player = Players[num3];
					num = ((int)num2 * -1137005118) ^ -1258550653;
					continue;
				default:
					return;
				case 13u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		bool flag = default(bool);
		while (true)
		{
			int num = -1169580299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6A032B0u) % 11u)
				{
				case 9u:
					num = ((int)num2 * -48793481) ^ 0x1F1AD41;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 236474479;
						num6 = 236474479;
					}
					else
					{
						num5 = 2108345743;
						num6 = 2108345743;
					}
					num = num5 ^ ((int)num2 * -1783441043);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (_currentPlayer < Players.Length)
					{
						num3 = -1851559037;
						num4 = -1851559037;
					}
					else
					{
						num3 = -686832990;
						num4 = -686832990;
					}
					num = num3 ^ ((int)num2 * -2135698824);
					continue;
				}
				case 6u:
					num = ((int)num2 * -414393460) ^ 0x7EACBCC7;
					continue;
				case 5u:
					_currentPlayer = 0;
					flag = _currentTurn > 0;
					num = ((int)num2 * -1603889601) ^ -218019986;
					continue;
				case 4u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)(num2 * 413549366) ^ -1856758454;
					continue;
				case 3u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -614672963;
					continue;
				case 2u:
					num = (int)(num2 * 1612507635) ^ -1852568990;
					continue;
				case 1u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 240984409) ^ 0x4EFCB378);
					continue;
				case 10u:
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
		bool flag8 = default(bool);
		bool flag = default(bool);
		Card card = default(Card);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		int num18 = default(int);
		int num15 = default(int);
		int num12 = default(int);
		int num3 = default(int);
		bool flag12 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		PlayerState playerState = default(PlayerState);
		bool flag9 = default(bool);
		bool flag11 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = 380843057;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x33088AC1u) % 79u)
				{
				case 78u:
					num = ((int)num2 * -802648616) ^ -772526578;
					continue;
				case 77u:
					num = (int)(num2 * 115778087) ^ -581853181;
					continue;
				case 76u:
				{
					int num25;
					if (flag8)
					{
						num = 2091541641;
						num25 = 2091541641;
					}
					else
					{
						num = 1238819985;
						num25 = 1238819985;
					}
					continue;
				}
				case 75u:
					flag8 = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -2003587448) ^ 0x636CC1E5;
					continue;
				case 74u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1061284211;
						num6 = 1061284211;
					}
					else
					{
						num5 = 843369083;
						num6 = 843369083;
					}
					num = num5 ^ ((int)num2 * -2065705809);
					continue;
				}
				case 73u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag5 ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num18), flag8 ? "advance" : "stay");
					num = 663204772;
					continue;
				case 72u:
					num15++;
					num = 1691946538;
					continue;
				case 71u:
					num = ((int)num2 * -297466319) ^ -877938706;
					continue;
				case 70u:
					num18 = Game.smethod_3(0, num12);
					num = ((int)num2 * -615617024) ^ -1847530021;
					continue;
				case 69u:
					num = 825865469;
					continue;
				case 68u:
					num12 = card.Impact - player.PlannedForCard(card.Type);
					flag8 = num12 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -427500012) ^ 0x6597F07D;
					continue;
				case 67u:
					num3++;
					num = 1462931192;
					continue;
				case 66u:
				{
					int num32;
					int num33;
					if (!flag12)
					{
						num32 = -2107453051;
						num33 = -2107453051;
					}
					else
					{
						num32 = -459447692;
						num33 = -459447692;
					}
					num = num32 ^ ((int)num2 * -2130570131);
					continue;
				}
				case 65u:
					Losers.Add(num3);
					num = ((int)num2 * -805329824) ^ 0x225B6FA5;
					continue;
				case 64u:
					num = ((int)num2 * -1448869744) ^ 0x73F1AE5F;
					continue;
				case 63u:
					playerState2.State = State.Lose;
					num = 439230199;
					continue;
				case 62u:
					num = ((int)num2 * -1314646428) ^ 0x622DC447;
					continue;
				case 61u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					flag12 = playerState.State != State.Playing;
					num = ((int)num2 * -1684802442) ^ -1465276822;
					continue;
				case 60u:
					num = 260950917;
					continue;
				case 59u:
				{
					int num23;
					int num24;
					if (flag9)
					{
						num23 = 372984236;
						num24 = 372984236;
					}
					else
					{
						num23 = 974411960;
						num24 = 974411960;
					}
					num = num23 ^ ((int)num2 * -1581724597);
					continue;
				}
				case 58u:
					flag11 = num3 == playerIndex;
					num = 233370216;
					continue;
				case 57u:
					_finished = true;
					num3 = 0;
					num = ((int)num2 * -1399908496) ^ 0x799FBD4C;
					continue;
				case 56u:
					playerState2 = _playerStates[num15];
					num = 1023091808;
					continue;
				case 55u:
					playerState = _playerStates[playerIndex];
					num = (int)(num2 * 1542975016) ^ -2086049936;
					continue;
				case 54u:
					flag8 = false;
					num = 2106347491;
					continue;
				case 53u:
					num = 10137762;
					continue;
				case 52u:
				{
					int num16;
					int num17;
					if (Losers.Contains(num15))
					{
						num16 = -340990645;
						num17 = -340990645;
					}
					else
					{
						num16 = -1665234755;
						num17 = -1665234755;
					}
					num = num16 ^ (int)(num2 * 1079143681);
					continue;
				}
				case 51u:
					playerState2.Resources -= Game.smethod_3(0, num18 - Players[num15].PlannedForCard(card.Type));
					flag9 = playerState2.Resources >= 0;
					num = (int)(num2 * 1872106377) ^ -440191662;
					continue;
				case 50u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 126416096;
						num9 = 126416096;
					}
					else
					{
						num8 = 788314547;
						num9 = 788314547;
					}
					num = num8 ^ (int)(num2 * 1414089686);
					continue;
				}
				case 49u:
					card = DrawCard();
					flag2 = card.Impact < 0;
					num = ((int)num2 * -189453764) ^ 0x2472B5A5;
					continue;
				case 48u:
				{
					int num34;
					int num35;
					if (!flag11)
					{
						num34 = 660451492;
						num35 = 660451492;
					}
					else
					{
						num34 = 1705151536;
						num35 = 1705151536;
					}
					num = num34 ^ ((int)num2 * -1180486670);
					continue;
				}
				case 47u:
				{
					int num30;
					int num31;
					if (flag4)
					{
						num30 = -25442676;
						num31 = -25442676;
					}
					else
					{
						num30 = -470381232;
						num31 = -470381232;
					}
					num = num30 ^ (int)(num2 * 575824351);
					continue;
				}
				case 46u:
				{
					int num28;
					int num29;
					if (!flag10)
					{
						num28 = -772946974;
						num29 = -772946974;
					}
					else
					{
						num28 = -421663688;
						num29 = -421663688;
					}
					num = num28 ^ (int)(num2 * 2021939629);
					continue;
				}
				case 45u:
					playerState.State = State.Won;
					num = (int)((num2 * 1983026627) ^ 0x34A60F50);
					continue;
				case 44u:
					Winners.Add(playerIndex);
					num = ((int)num2 * -482223126) ^ -1221849922;
					continue;
				case 43u:
					num = (int)((num2 * 486679017) ^ 0x311ED68F);
					continue;
				case 42u:
					num = ((int)num2 * -1978813903) ^ -630109806;
					continue;
				case 41u:
					flag7 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 922564500;
					continue;
				case 40u:
					Losers.Add(num15);
					num = (int)(num2 * 2098581864) ^ -718241939;
					continue;
				case 39u:
					num = 1616282165;
					continue;
				case 38u:
				{
					int num26;
					int num27;
					if (!Rules.OnlyOneWinner)
					{
						num26 = 168247206;
						num27 = 168247206;
					}
					else
					{
						num26 = 1875070723;
						num27 = 1875070723;
					}
					num = num26 ^ ((int)num2 * -1316560458);
					continue;
				}
				case 37u:
					num = (int)(num2 * 1230672270) ^ -1779556983;
					continue;
				case 36u:
					playerState.State = State.Lose;
					flag3 = !Losers.Contains(playerIndex);
					num = (int)(num2 * 1495629669) ^ -1741595351;
					continue;
				case 34u:
					playerState.Sprint++;
					num = (int)((num2 * 488316267) ^ 0x4E792489);
					continue;
				case 33u:
					flag = playerState.Resources < 0;
					num = (int)(num2 * 1893109265) ^ -1335896453;
					continue;
				case 32u:
					num = ((int)num2 * -530965834) ^ 0x3BE0FDA6;
					continue;
				case 31u:
					playerState.Resources -= num18;
					num = ((int)num2 * -1680874329) ^ -262521359;
					continue;
				case 30u:
					num = ((int)num2 * -212026253) ^ 0x7BC77CDC;
					continue;
				case 29u:
					num = 1204308987;
					continue;
				case 28u:
				{
					int num22;
					if (num15 < _playerStates.Length)
					{
						num = 471217314;
						num22 = 471217314;
					}
					else
					{
						num = 323748572;
						num22 = 323748572;
					}
					continue;
				}
				case 27u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -953115657) ^ -217822977;
					continue;
				case 26u:
					flag8 = true;
					num18 = card.Impact;
					num = ((int)num2 * -539960225) ^ 0x47B81477;
					continue;
				case 25u:
				{
					int num21;
					if (playerState.Sprint >= 0)
					{
						num = 605719639;
						num21 = 605719639;
					}
					else
					{
						num = 1591640851;
						num21 = 1591640851;
					}
					continue;
				}
				case 24u:
					flag10 = playerState.Sprint > Rules.SprintCount;
					num = 432042674;
					continue;
				case 23u:
					Print("Still planning");
					num = (int)((num2 * 718625036) ^ 0x5F2BE534);
					continue;
				case 22u:
					num = (int)(num2 * 830442324) ^ -2115117308;
					continue;
				case 21u:
				{
					int num19;
					int num20;
					if (!flag5)
					{
						num19 = -994431209;
						num20 = -994431209;
					}
					else
					{
						num19 = -1067410230;
						num20 = -1067410230;
					}
					num = num19 ^ (int)(num2 * 1145512821);
					continue;
				}
				case 20u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 116507922;
					continue;
				}
				case 19u:
					num = ((int)num2 * -1824082601) ^ -934620897;
					continue;
				case 18u:
					num15 = 0;
					num = ((int)num2 * -575370723) ^ 0x3D896AE6;
					continue;
				case 17u:
				{
					int num13;
					int num14;
					if (flag6)
					{
						num13 = -251216029;
						num14 = -251216029;
					}
					else
					{
						num13 = -374995953;
						num14 = -374995953;
					}
					num = num13 ^ ((int)num2 * -1453258087);
					continue;
				}
				case 16u:
				{
					int num10;
					int num11;
					if (!flag7)
					{
						num10 = -264769245;
						num11 = -264769245;
					}
					else
					{
						num10 = -741768561;
						num11 = -741768561;
					}
					num = num10 ^ (int)(num2 * 1201027829);
					continue;
				}
				case 15u:
					Print(playerState.State);
					num = (int)(num2 * 1196679205) ^ -247561629;
					continue;
				case 14u:
					num = 886147690;
					continue;
				case 13u:
					num = 805325796;
					continue;
				case 12u:
					num7 = ((card.Type == 4) ? 1 : 0);
					goto IL_0804;
				case 11u:
					num = (int)((num2 * 538560655) ^ 0x38ADFF1A);
					continue;
				case 10u:
					num = 446047061;
					continue;
				case 9u:
					num = (int)((num2 * 1993916007) ^ 0x64D74BB);
					continue;
				case 8u:
					flag4 = !Losers.Contains(num3);
					num = 1054356074;
					continue;
				case 6u:
					num = ((int)num2 * -438385159) ^ -1207428729;
					continue;
				case 5u:
					playerState.Sprint++;
					num = ((int)num2 * -491676071) ^ 0x640BF725;
					continue;
				case 4u:
					num = (int)(num2 * 1865783437) ^ -2094954349;
					continue;
				case 3u:
					num = (int)(num2 * 1273611666) ^ -51960666;
					continue;
				case 2u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 1365445358) ^ 0x198CC58C);
						continue;
					}
					num7 = 0;
					goto IL_0804;
				case 1u:
					num = (int)((num2 * 1659561644) ^ 0xBB5EB2E);
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= _playerStates.Length)
					{
						num = 234260583;
						num4 = 234260583;
					}
					else
					{
						num = 855798494;
						num4 = 855798494;
					}
					continue;
				}
				default:
					return;
				case 7u:
					break;
				case 35u:
					return;
					IL_0804:
					flag5 = (byte)num7 != 0;
					flag6 = !flag2;
					num = 1354056385;
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
			int num = -1837151337;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B8FFA7Du) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1758030543) ^ -941313411;
					continue;
				case 6u:
					ShuffleCards();
					num = (int)((num2 * 380472407) ^ 0x1FF7BFFE);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 131780560;
						num4 = 131780560;
					}
					else
					{
						num3 = 1663757845;
						num4 = 1663757845;
					}
					num = num3 ^ (int)(num2 * 1328849795);
					continue;
				}
				case 4u:
					card = _deck[0];
					num = -1141214151;
					continue;
				case 2u:
					num = (int)((num2 * 60461619) ^ 0x7B790BC1);
					continue;
				case 1u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -114853427) ^ -1785513245;
					continue;
				case 0u:
					_deck.RemoveAt(0);
					result = card;
					num = (int)((num2 * 74642698) ^ 0x6FCFC66D);
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
		string text = "";
		int num = 0;
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -1205270350;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xEE988FD4u) % 8u)
				{
				case 6u:
					num2 = ((int)num3 * -244069459) ^ -1130338405;
					continue;
				case 5u:
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
					num2 = -1987574155;
					continue;
				}
				case 4u:
					result = text;
					num2 = (int)((num3 * 285469651) ^ 0x32A1C5FB);
					continue;
				case 3u:
					num2 = ((int)num3 * -1633964307) ^ -75234717;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1086230475;
						num5 = -1086230475;
					}
					else
					{
						num4 = -1909600828;
						num5 = -1909600828;
					}
					num2 = num4 ^ ((int)num3 * -98544494);
					continue;
				}
				case 1u:
					flag = num < _playerStates.Length;
					num2 = -920642874;
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
			int num = 1783590773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x28E3380Cu) % 4u)
				{
				case 1u:
					result = ToString(initial: false);
					num = (int)(num2 * 1737972273) ^ -950841287;
					continue;
				case 0u:
					num = ((int)num2 * -142153815) ^ 0x3049B046;
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
			int num = 554666444;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B3ACAB6u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					Game.smethod_8(_buffer, string_);
					return;
				}
				break;
				IL_0003:
				string_ = Game.smethod_7(Game.smethod_5(text), more);
				num = ((int)num2 * -98184021) ^ -101799314;
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
