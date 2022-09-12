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
			int num3 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			bool result = default(bool);
			bool finished = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num = -568005643;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD634D237u) % 15u)
					{
					case 14u:
					{
						int num8;
						if (num3 >= playerStates.Length)
						{
							num = -1147024394;
							num8 = -1147024394;
						}
						else
						{
							num = -955064295;
							num8 = -955064295;
						}
						continue;
					}
					case 13u:
						num = -1363023432;
						continue;
					case 12u:
						playerStates = _playerStates;
						num3 = 0;
						num = ((int)num2 * -1002865251) ^ 0x2616CD69;
						continue;
					case 11u:
						result = true;
						num = ((int)num2 * -1576638231) ^ -1569049832;
						continue;
					case 9u:
						result = true;
						num = ((int)num2 * -333932123) ^ -822838716;
						continue;
					case 8u:
						result = false;
						num = (int)((num2 * 1010400866) ^ 0x134B6813);
						continue;
					case 7u:
					{
						int num6;
						int num7;
						if (!finished)
						{
							num6 = -515591470;
							num7 = -515591470;
						}
						else
						{
							num6 = -1807946995;
							num7 = -1807946995;
						}
						num = num6 ^ ((int)num2 * -676874995);
						continue;
					}
					case 6u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -742615580;
							num5 = -742615580;
						}
						else
						{
							num4 = -327068796;
							num5 = -327068796;
						}
						num = num4 ^ ((int)num2 * -797932821);
						continue;
					}
					case 5u:
						finished = _finished;
						num = ((int)num2 * -1718126855) ^ -1363753920;
						continue;
					case 3u:
						num = ((int)num2 * -67151014) ^ -1511658301;
						continue;
					case 2u:
						num = (int)(num2 * 896943897) ^ -384989611;
						continue;
					case 1u:
					{
						PlayerState playerState = playerStates[num3];
						flag = playerState.State == State.Playing;
						num = -1419396186;
						continue;
					}
					case 0u:
						num3++;
						num = -2143960431;
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
		int num3 = default(int);
		int count = default(int);
		int num5 = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -883329771;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC79FAAA1u) % 20u)
				{
				case 19u:
					_dice = new Dice();
					num = ((int)num2 * -153706311) ^ -803344908;
					continue;
				case 18u:
					num3 = 0;
					num = ((int)num2 * -1589410714) ^ -1645923990;
					continue;
				case 17u:
					_playerStates[num3] = new PlayerState();
					num = -973492795;
					continue;
				case 16u:
					num3++;
					num = ((int)num2 * -865633259) ^ -2094374359;
					continue;
				case 15u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -309871282) ^ 0x56C37AC5;
					continue;
				case 14u:
					Players[num5] = Player.Deserialize(jSONNode[num5]);
					num = -817684872;
					continue;
				case 13u:
					num = ((int)num2 * -68147357) ^ -1220515434;
					continue;
				case 12u:
					flag = num5 < count;
					num = -992821076;
					continue;
				case 10u:
					Players = new Player[count];
					num = ((int)num2 * -149114428) ^ 0x544F01B0;
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -1136665927;
						num7 = -1136665927;
					}
					else
					{
						num6 = -1737481264;
						num7 = -1737481264;
					}
					num = num6 ^ (int)(num2 * 1443380891);
					continue;
				}
				case 8u:
					num = (int)(num2 * 428469100) ^ -414920989;
					continue;
				case 7u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = ((int)num2 * -1090434241) ^ -1099061877;
					continue;
				case 6u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = ((int)num2 * -2124521608) ^ 0x165C3E5B;
					continue;
				case 5u:
					num5++;
					num = (int)(num2 * 1460409972) ^ -280109187;
					continue;
				case 3u:
					num = (int)((num2 * 1477878311) ^ 0xB30CF34);
					continue;
				case 2u:
					_buffer = buffer;
					num = (int)((num2 * 2003705070) ^ 0x12A44646);
					continue;
				case 1u:
					num5 = 0;
					num = (int)(num2 * 1555008643) ^ -532748801;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -1563311539;
						num4 = -1563311539;
					}
					else
					{
						num = -449555800;
						num4 = -449555800;
					}
					continue;
				}
				default:
					return;
				case 11u:
					break;
				case 4u:
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
			int num = 1456925175;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD63741Bu) % 7u)
				{
				case 6u:
					_currentTurn = 0;
					_finished = false;
					num = (int)(num2 * 815612171) ^ -1538744839;
					continue;
				case 3u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 1354419322) ^ 0x18AF25E4);
					continue;
				case 2u:
					_chances = new List<float>(Rules.RiskChances);
					num = (int)(num2 * 957953875) ^ -313414364;
					continue;
				case 1u:
					Losers.Clear();
					num = (int)(num2 * 2035570127) ^ -154074811;
					continue;
				case 0u:
					_currentChanceIndex = -1;
					num = (int)((num2 * 1255558512) ^ 0x5A12579F);
					continue;
				default:
					return;
				case 4u:
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
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		int planningCardsCount = default(int);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		PlayerState playerState = default(PlayerState);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1153139894;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2823B023u) % 26u)
				{
				case 25u:
					flag2 = num5 > 0;
					num = 2034502820;
					continue;
				case 24u:
					flag = num6 < Players.Length;
					num = 1802295563;
					continue;
				case 23u:
					num5 = planningCardsCount - Rules.NormalPlanningCount;
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = 814383245;
					continue;
				case 22u:
					playerState.Sprint = 0;
					num = ((int)num2 * -1600664339) ^ 0xB140DD;
					continue;
				case 21u:
					playerState.Sprint = -1;
					playerState.Resources -= num5 * Rules.NormalPlanningCost;
					num = (int)((num2 * 500617176) ^ 0xB725B72);
					continue;
				case 20u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 1124570470;
						num10 = 1124570470;
					}
					else
					{
						num9 = 1267562288;
						num10 = 1267562288;
					}
					num = num9 ^ ((int)num2 * -1750250407);
					continue;
				}
				case 19u:
					num5 = 0;
					num = 754645605;
					continue;
				case 18u:
					num = (int)((num2 * 433385261) ^ 0x2686C294);
					continue;
				case 17u:
					num = (int)(num2 * 1892363662) ^ -1967754520;
					continue;
				case 15u:
					playerState.Resources -= (planningCardsCount - num5) * Rules.NormalPlanningCost;
					num = 1684048349;
					continue;
				case 14u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num = ((int)num2 * -2025087051) ^ 0x612B99CD;
					continue;
				case 13u:
					player = Players[num6];
					playerState = _playerStates[num6];
					num = 1467865213;
					continue;
				case 12u:
					planningCardsCount = player.PlanningCardsCount;
					num5 = 0;
					num = (int)(num2 * 1030159484) ^ -660707469;
					continue;
				case 11u:
					num6 = 0;
					num = (int)(num2 * 1909120867) ^ -1387854894;
					continue;
				case 10u:
					flag3 = planningCardsCount == 0;
					num = (int)((num2 * 1834778558) ^ 0x293B83A1);
					continue;
				case 9u:
					num = (int)((num2 * 2004446483) ^ 0x17446C8A);
					continue;
				case 8u:
					num = ((int)num2 * -535915144) ^ -133309451;
					continue;
				case 7u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = 635676995;
						num12 = 635676995;
					}
					else
					{
						num11 = 1831074347;
						num12 = 1831074347;
					}
					num = num11 ^ ((int)num2 * -639939315);
					continue;
				}
				case 6u:
				{
					int num7;
					int num8;
					if (useOneMorePlanningSprint)
					{
						num7 = -1185615535;
						num8 = -1185615535;
					}
					else
					{
						num7 = -1847083756;
						num8 = -1847083756;
					}
					num = num7 ^ (int)(num2 * 1732382642);
					continue;
				}
				case 5u:
					playerState.Resources -= num5 * Rules.OverPlanningCost;
					num = (int)(num2 * 1752562361) ^ -853731786;
					continue;
				case 4u:
					num6++;
					num = ((int)num2 * -1366406394) ^ 0x300FE6B9;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 778984614;
						num4 = 778984614;
					}
					else
					{
						num3 = 2000697411;
						num4 = 2000697411;
					}
					num = num3 ^ (int)(num2 * 1029463339);
					continue;
				}
				case 1u:
					playerState.Sprint = 1;
					num = ((int)num2 * -1185772076) ^ 0x27F51F30;
					continue;
				case 0u:
					num = 1969080828;
					continue;
				default:
					return;
				case 3u:
					break;
				case 16u:
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
			int num = 331175341;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF58B72Eu) % 16u)
				{
				case 15u:
					num = ((int)num2 * -1708541461) ^ -1571428975;
					continue;
				case 14u:
					PlayerTurn(_currentPlayer);
					num = 1625782793;
					continue;
				case 13u:
				{
					int num5;
					int num6;
					if (_currentTurn > 0)
					{
						num5 = -215141593;
						num6 = -215141593;
					}
					else
					{
						num5 = -1599781102;
						num6 = -1599781102;
					}
					num = num5 ^ ((int)num2 * -717354356);
					continue;
				}
				case 12u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1660183340;
						num4 = -1660183340;
					}
					else
					{
						num3 = -690814654;
						num4 = -690814654;
					}
					num = num3 ^ ((int)num2 * -1521458421);
					continue;
				}
				case 11u:
					num = (int)(num2 * 1233668004) ^ -1169475884;
					continue;
				case 10u:
					num = ((int)num2 * -963809923) ^ 0x16C75782;
					continue;
				case 9u:
					flag = _currentPlayer >= Players.Length;
					num = (int)((num2 * 1126274268) ^ 0x38904C6E);
					continue;
				case 8u:
					num = ((int)num2 * -604758275) ^ 0x3450B904;
					continue;
				case 6u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)((num2 * 134904148) ^ 0x482AE037);
					continue;
				case 5u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -719181492) ^ -2014454350;
					continue;
				case 3u:
					_currentPlayer++;
					num = (int)((num2 * 248426504) ^ 0x1C6DB60F);
					continue;
				case 2u:
					_currentPlayer = 0;
					num = ((int)num2 * -1447446245) ^ 0x17AF7D05;
					continue;
				case 1u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -1418387916) ^ -361583835;
					continue;
				case 0u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 19364389;
					continue;
				default:
					return;
				case 4u:
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
		PlayerState playerState = _playerStates[playerIndex];
		Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		int num10 = default(int);
		bool flag = default(bool);
		bool flag4 = default(bool);
		bool flag12 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag3 = default(bool);
		Card card = default(Card);
		bool flag5 = default(bool);
		bool flag8 = default(bool);
		int num5 = default(int);
		int num9 = default(int);
		bool flag9 = default(bool);
		bool flag13 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		int num6 = default(int);
		bool flag7 = default(bool);
		while (true)
		{
			int num = 583960463;
			while (true)
			{
				uint num2;
				int num18;
				switch ((num2 = (uint)num ^ 0x60438C18u) % 87u)
				{
				case 86u:
					num = ((int)num2 * -1717312348) ^ 0x388148AE;
					continue;
				case 85u:
				{
					int num33;
					int num34;
					if (!flag10)
					{
						num33 = 1182574953;
						num34 = 1182574953;
					}
					else
					{
						num33 = 558990559;
						num34 = 558990559;
					}
					num = num33 ^ ((int)num2 * -1612222118);
					continue;
				}
				case 84u:
				{
					int num13;
					int num14;
					if (!flag6)
					{
						num13 = -1739823715;
						num14 = -1739823715;
					}
					else
					{
						num13 = -393058107;
						num14 = -393058107;
					}
					num = num13 ^ ((int)num2 * -260039568);
					continue;
				}
				case 83u:
					flag2 = true;
					num = ((int)num2 * -498827915) ^ -544580795;
					continue;
				case 82u:
				{
					int num35;
					int num36;
					if (!flag11)
					{
						num35 = -126857918;
						num36 = -126857918;
					}
					else
					{
						num35 = -120418569;
						num36 = -120418569;
					}
					num = num35 ^ ((int)num2 * -1605609581);
					continue;
				}
				case 81u:
					num10++;
					num = 482613326;
					continue;
				case 80u:
					num = (int)(num2 * 767210646) ^ -1188338065;
					continue;
				case 79u:
				{
					int num16;
					int num17;
					if (flag)
					{
						num16 = -37453709;
						num17 = -37453709;
					}
					else
					{
						num16 = -1384956050;
						num17 = -1384956050;
					}
					num = num16 ^ (int)(num2 * 510554519);
					continue;
				}
				case 78u:
					num = (int)((num2 * 1772773648) ^ 0xCBEF3D6);
					continue;
				case 77u:
					num = 513059384;
					continue;
				case 76u:
					num = (int)((num2 * 956440590) ^ 0x464E06DC);
					continue;
				case 75u:
					flag4 = playerState.Sprint > Rules.SprintCount;
					num = 1032567977;
					continue;
				case 74u:
					num = ((int)num2 * -465677001) ^ 0x55C41B17;
					continue;
				case 73u:
					num = ((int)num2 * -1360305455) ^ 0x43BDE3B;
					continue;
				case 72u:
				{
					int num29;
					int num30;
					if (!flag12)
					{
						num29 = 1868320137;
						num30 = 1868320137;
					}
					else
					{
						num29 = 2009370856;
						num30 = 2009370856;
					}
					num = num29 ^ ((int)num2 * -1202921850);
					continue;
				}
				case 71u:
					num = (int)(num2 * 1817345941) ^ -1077221362;
					continue;
				case 70u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -2134751155) ^ -1556575456;
					continue;
				case 69u:
					flag3 = playerState.State != State.Playing;
					num = (int)(num2 * 675205853) ^ -1898663480;
					continue;
				case 68u:
					num = ((int)num2 * -863961208) ^ 0xA63EE1A;
					continue;
				case 67u:
					num18 = ((card.Type == 4) ? 1 : 0);
					goto IL_0231;
				case 66u:
					flag11 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 1993895345;
					continue;
				case 65u:
					flag12 = !flag5;
					num = (int)((num2 * 1585750000) ^ 0x65A5AB68);
					continue;
				case 64u:
					playerState.Sprint++;
					num = ((int)num2 * -1439190587) ^ -65488498;
					continue;
				case 63u:
					Print("CARD: none, advance");
					num = ((int)num2 * -1041095595) ^ -1374298852;
					continue;
				case 62u:
					flag10 = playerState.Sprint < 0;
					num = 355301206;
					continue;
				case 61u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 1708510080) ^ 0x3A5BE626);
					continue;
				case 60u:
					flag8 = !Losers.Contains(num10);
					num = ((int)num2 * -1398432692) ^ 0x602D0870;
					continue;
				case 59u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -1566578623) ^ -1168304795;
						continue;
					}
					num18 = 0;
					goto IL_0231;
				case 58u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag5 ? "ALL " : "", flag6 ? "receives" : "pays", Game.smethod_4(num5), flag2 ? "advance" : "stay");
					num = 304520688;
					continue;
				case 56u:
					flag = !Losers.Contains(playerIndex);
					num = (int)(num2 * 405332025) ^ -1125684368;
					continue;
				case 55u:
					num = (int)((num2 * 1168062354) ^ 0x4A44B158);
					continue;
				case 54u:
					flag2 = true;
					num5 = card.Impact;
					num = 644022426;
					continue;
				case 53u:
					num = ((int)num2 * -1357915525) ^ -404636723;
					continue;
				case 52u:
					playerState.Sprint++;
					num = (int)(num2 * 826865235) ^ -1959473690;
					continue;
				case 51u:
					Print(playerState.State);
					num = ((int)num2 * -2026447841) ^ 0x1546353A;
					continue;
				case 50u:
					num = ((int)num2 * -947827564) ^ 0x2CC1DD34;
					continue;
				case 49u:
					flag6 = card.Impact < 0;
					num = ((int)num2 * -567066655) ^ 0x1E2ECBD0;
					continue;
				case 48u:
					Losers.Add(num9);
					num = ((int)num2 * -1965191822) ^ 0x1FC8D82E;
					continue;
				case 47u:
				{
					int num31;
					int num32;
					if (!flag9)
					{
						num31 = -478386814;
						num32 = -478386814;
					}
					else
					{
						num31 = -1390000563;
						num32 = -1390000563;
					}
					num = num31 ^ (int)(num2 * 1641035002);
					continue;
				}
				case 46u:
				{
					int num27;
					int num28;
					if (onlyOneWinner)
					{
						num27 = -1578390674;
						num28 = -1578390674;
					}
					else
					{
						num27 = -91287808;
						num28 = -91287808;
					}
					num = num27 ^ ((int)num2 * -1828800018);
					continue;
				}
				case 45u:
					num = 1489090236;
					continue;
				case 44u:
				{
					int num25;
					int num26;
					if (flag13)
					{
						num25 = -1681146768;
						num26 = -1681146768;
					}
					else
					{
						num25 = -370992793;
						num26 = -370992793;
					}
					num = num25 ^ ((int)num2 * -1981241999);
					continue;
				}
				case 43u:
					num9++;
					num = 381871396;
					continue;
				case 42u:
					flag2 = false;
					num = 408493882;
					continue;
				case 41u:
					flag13 = !Losers.Contains(num9);
					num = 1943491502;
					continue;
				case 40u:
					Losers.Add(num10);
					num = ((int)num2 * -689702248) ^ -1045037721;
					continue;
				case 39u:
					playerState2 = _playerStates[num10];
					playerState2.Resources -= Game.smethod_3(0, num5 - Players[num10].PlannedForCard(card.Type));
					num = ((int)num2 * -522375740) ^ 0x590259D6;
					continue;
				case 38u:
					num6 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)((num2 * 342870207) ^ 0x757062EC);
					continue;
				case 37u:
					num = 1659333028;
					continue;
				case 36u:
					num = (int)(num2 * 56449718) ^ -477668338;
					continue;
				case 35u:
					num5 = Game.smethod_3(0, num6);
					num = ((int)num2 * -1231179566) ^ 0x3F7C8685;
					continue;
				case 34u:
					num = 415684395;
					continue;
				case 33u:
					num = ((int)num2 * -322314195) ^ -1939346950;
					continue;
				case 32u:
				{
					int num23;
					int num24;
					if (flag7)
					{
						num23 = -1486441394;
						num24 = -1486441394;
					}
					else
					{
						num23 = -1633293998;
						num24 = -1633293998;
					}
					num = num23 ^ (int)(num2 * 1731251363);
					continue;
				}
				case 31u:
					num = ((int)num2 * -1939416747) ^ -315351354;
					continue;
				case 30u:
				{
					int num21;
					int num22;
					if (!flag8)
					{
						num21 = -13599557;
						num22 = -13599557;
					}
					else
					{
						num21 = -375263168;
						num22 = -375263168;
					}
					num = num21 ^ ((int)num2 * -1144345951);
					continue;
				}
				case 29u:
					flag9 = playerState2.Resources >= 0;
					num = ((int)num2 * -647674876) ^ 0xF66C7DC;
					continue;
				case 28u:
					num10 = 0;
					num = 660291696;
					continue;
				case 27u:
					num = (int)(num2 * 135383112) ^ -272071792;
					continue;
				case 26u:
					Print("Still planning");
					num = (int)((num2 * 1114341582) ^ 0x5E79C55C);
					continue;
				case 25u:
					num = (int)(num2 * 30947773) ^ -1074725265;
					continue;
				case 24u:
				{
					int num20;
					if (num9 == playerIndex)
					{
						num = 1233941357;
						num20 = 1233941357;
					}
					else
					{
						num = 491828565;
						num20 = 491828565;
					}
					continue;
				}
				case 23u:
					num = (int)(num2 * 33967008) ^ -266349013;
					continue;
				case 22u:
				{
					int num19;
					if (!flag2)
					{
						num = 282902979;
						num19 = 282902979;
					}
					else
					{
						num = 781725937;
						num19 = 781725937;
					}
					continue;
				}
				case 21u:
					playerState.Resources -= num5;
					num = ((int)num2 * -651423177) ^ -839215752;
					continue;
				case 20u:
					num = (int)(num2 * 1353395048) ^ -65621880;
					continue;
				case 19u:
					playerState2.State = State.Lose;
					num = 1242433263;
					continue;
				case 18u:
					num = (int)((num2 * 1619237179) ^ 0x1E80521F);
					continue;
				case 17u:
					num = ((int)num2 * -564025975) ^ 0x46769752;
					continue;
				case 16u:
				{
					int num15;
					if (num9 >= _playerStates.Length)
					{
						num = 1886348445;
						num15 = 1886348445;
					}
					else
					{
						num = 935083999;
						num15 = 935083999;
					}
					continue;
				}
				case 14u:
					Print(Game.smethod_2("\t", (playerState != null) ? Game.smethod_5((object)playerState) : null));
					num = 1658408271;
					continue;
				case 13u:
					playerState.State = State.Lose;
					num = ((int)num2 * -1863823526) ^ 0x4211FB66;
					continue;
				case 12u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = (int)(num2 * 1213327387) ^ -1108986427;
					continue;
				case 11u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = -1069047808;
						num12 = -1069047808;
					}
					else
					{
						num11 = -1318338553;
						num12 = -1318338553;
					}
					num = num11 ^ ((int)num2 * -408240997);
					continue;
				}
				case 10u:
					flag7 = num10 < _playerStates.Length;
					num = 34293161;
					continue;
				case 9u:
					num = (int)((num2 * 1397845330) ^ 0x21A91905);
					continue;
				case 8u:
					num = 143336971;
					continue;
				case 7u:
					_finished = true;
					num9 = 0;
					num = ((int)num2 * -1643997240) ^ -1196945330;
					continue;
				case 6u:
					num = (int)((num2 * 1518028022) ^ 0x30401FDE);
					continue;
				case 5u:
					num = 2020622016;
					continue;
				case 4u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -1375946983;
						num8 = -1375946983;
					}
					else
					{
						num7 = -1033088551;
						num8 = -1033088551;
					}
					num = num7 ^ ((int)num2 * -2085298999);
					continue;
				}
				case 3u:
					flag2 = num6 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -910419161) ^ -2119438715;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (playerState.Resources < 0)
					{
						num3 = 826270407;
						num4 = 826270407;
					}
					else
					{
						num3 = 870649368;
						num4 = 870649368;
					}
					num = num3 ^ ((int)num2 * -957246450);
					continue;
				}
				case 1u:
					card = DrawCard();
					num = 1803054651;
					continue;
				case 0u:
					num = ((int)num2 * -1157352646) ^ -1937642996;
					continue;
				default:
					return;
				case 15u:
					break;
				case 57u:
					return;
					IL_0231:
					flag5 = (byte)num18 != 0;
					num = 446068632;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card result = default(Card);
		while (true)
		{
			int num = -1626302868;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB074B3EDu) % 6u)
				{
				case 4u:
					ShuffleCards();
					num = ((int)num2 * -1045436871) ^ -1294549394;
					continue;
				case 3u:
					num = (int)(num2 * 657612376) ^ -790177083;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_deck.Count > 0)
					{
						num3 = 1617993227;
						num4 = 1617993227;
					}
					else
					{
						num3 = 256200695;
						num4 = 256200695;
					}
					num = num3 ^ (int)(num2 * 626992998);
					continue;
				}
				case 0u:
				{
					Card card = _deck[0];
					_deck.RemoveAt(0);
					result = card;
					num = -1710404507;
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

	public string ToString(bool initial)
	{
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = 2084189276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6ED18B66u) % 8u)
				{
				case 6u:
					num3++;
					num = (int)((num2 * 362264361) ^ 0x7941D488);
					continue;
				case 4u:
					result = text;
					num = (int)((num2 * 2107443065) ^ 0x70486F45);
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -546723997) ^ 0x2757D457;
					continue;
				case 2u:
					text = "";
					num = ((int)num2 * -1284199306) ^ 0x629B4551;
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
					num = 2017647496;
					continue;
				}
				case 0u:
				{
					int num4;
					if (num3 >= _playerStates.Length)
					{
						num = 857416538;
						num4 = 857416538;
					}
					else
					{
						num = 1589976439;
						num4 = 1589976439;
					}
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -945613341;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFB3F089u) % 3u)
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
				num = ((int)num2 * -1288532229) ^ -873675573;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		while (true)
		{
			int num = 1694424856;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73C46669u) % 3u)
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
				string string_ = Game.smethod_7(Game.smethod_5(text), more);
				Game.smethod_8(_buffer, string_);
				num = (int)((num2 * 1596852620) ^ 0x12103AF3);
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
