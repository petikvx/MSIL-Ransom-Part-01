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
			bool flag = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = -1604502786;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x89552BB6u) % 13u)
					{
					case 12u:
						num = ((int)num2 * -314832455) ^ 0x6B637C0D;
						continue;
					case 10u:
						num3++;
						num = -1690318783;
						continue;
					case 9u:
					{
						PlayerState playerState = playerStates[num3];
						flag = playerState.State == State.Playing;
						num = -1482537670;
						continue;
					}
					case 7u:
						playerStates = _playerStates;
						num3 = 0;
						num = -1690318783;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 124137333;
							num6 = 124137333;
						}
						else
						{
							num5 = 1059097156;
							num6 = 1059097156;
						}
						num = num5 ^ ((int)num2 * -109935464);
						continue;
					}
					case 5u:
						num = ((int)num2 * -1853359611) ^ 0x2008F0A8;
						continue;
					case 4u:
					{
						int num7;
						int num8;
						if (finished)
						{
							num7 = 1291612290;
							num8 = 1291612290;
						}
						else
						{
							num7 = 83392572;
							num8 = 83392572;
						}
						num = num7 ^ (int)(num2 * 1519947925);
						continue;
					}
					case 3u:
						result = true;
						num = (int)((num2 * 370377728) ^ 0xF3D19B4);
						continue;
					case 2u:
						result = true;
						num = (int)((num2 * 1770719096) ^ 0x6D394B31);
						continue;
					case 1u:
						result = false;
						num = ((int)num2 * -623099734) ^ 0x4B6861D6;
						continue;
					case 0u:
					{
						int num4;
						if (num3 < playerStates.Length)
						{
							num = -1966446022;
							num4 = -1966446022;
						}
						else
						{
							num = -34376922;
							num4 = -34376922;
						}
						continue;
					}
					case 11u:
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
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		int count = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1371667458;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34D7562Fu) % 12u)
				{
				case 11u:
					_buffer = buffer;
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					_dice = new Dice();
					num = (int)(num2 * 1253981445) ^ -254524401;
					continue;
				case 10u:
					Players[num4] = Player.Deserialize(jSONNode[num4]);
					num4++;
					num = 1870491730;
					continue;
				case 9u:
					num = (int)((num2 * 1278902482) ^ 0x7592F26);
					continue;
				case 8u:
					_playerStates[num3] = new PlayerState();
					num3++;
					num = 391365956;
					continue;
				case 7u:
				{
					int num7;
					if (num3 < count)
					{
						num = 130840911;
						num7 = 130840911;
					}
					else
					{
						num = 1603722295;
						num7 = 1603722295;
					}
					continue;
				}
				case 5u:
					num = ((int)num2 * -1156071106) ^ -1440020902;
					continue;
				case 3u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					Players = new Player[count];
					num4 = 0;
					num = ((int)num2 * -1365570354) ^ -271229600;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1906636621;
						num6 = 1906636621;
					}
					else
					{
						num5 = 956476095;
						num6 = 956476095;
					}
					num = num5 ^ ((int)num2 * -1025329158);
					continue;
				}
				case 1u:
					flag = num4 < count;
					num = 1037414581;
					continue;
				case 0u:
					_playerStates = new PlayerState[count];
					num3 = 0;
					num = (int)(num2 * 1758657509) ^ -980403742;
					continue;
				default:
					return;
				case 6u:
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
		while (true)
		{
			int num = 953018956;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15297249u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				_deck = new List<Card>(Rules.Cards);
				num = (int)((num2 * 1440798138) ^ 0x6C0DC30B);
			}
		}
	}

	public void StartNew()
	{
		while (true)
		{
			int num = -1492681707;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1C9F462u) % 10u)
				{
				case 9u:
					ShuffleCards();
					Winners.Clear();
					num = (int)(num2 * 634554112) ^ -1745872091;
					continue;
				case 8u:
					_finished = false;
					num = (int)(num2 * 23440839) ^ -1808394590;
					continue;
				case 7u:
					num = ((int)num2 * -147885549) ^ 0x4DE7DBAB;
					continue;
				case 6u:
					Losers.Clear();
					num = ((int)num2 * -431862227) ^ 0x76869CCE;
					continue;
				case 5u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 1950248537) ^ 0x482ED984);
					continue;
				case 4u:
					_currentChanceIndex = -1;
					num = (int)((num2 * 1239160492) ^ 0x417B9AC9);
					continue;
				case 1u:
					_currentTurn = 0;
					num = ((int)num2 * -263287028) ^ -419408374;
					continue;
				case 0u:
					num = (int)(num2 * 2027621922) ^ -211696449;
					continue;
				case 2u:
					break;
				default:
					_chances = new List<float>(Rules.RiskChances);
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		bool flag = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag2 = default(bool);
		int planningCardsCount = default(int);
		int num3 = default(int);
		int num4 = default(int);
		Player player = default(Player);
		while (true)
		{
			int num = -242878266;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1CCC9D9u) % 25u)
				{
				case 24u:
					num = ((int)num2 * -1062080573) ^ -1694050435;
					continue;
				case 23u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = -1557247374;
						num11 = -1557247374;
					}
					else
					{
						num10 = -750152681;
						num11 = -750152681;
					}
					num = num10 ^ (int)(num2 * 1362193140);
					continue;
				}
				case 22u:
					playerState.State = State.Playing;
					num = (int)(num2 * 1679408465) ^ -452693963;
					continue;
				case 21u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -1443154706;
						num7 = -1443154706;
					}
					else
					{
						num6 = -89359353;
						num7 = -89359353;
					}
					num = num6 ^ ((int)num2 * -850701010);
					continue;
				}
				case 20u:
					flag = planningCardsCount == 0;
					num = ((int)num2 * -1983139817) ^ -162323414;
					continue;
				case 19u:
					flag2 = num3 > 0;
					num = -932612069;
					continue;
				case 17u:
					num3 = 0;
					num = -1704823051;
					continue;
				case 16u:
					playerState = _playerStates[num4];
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					num = ((int)num2 * -1281658409) ^ 0x62F49F1F;
					continue;
				case 15u:
					num4 = 0;
					num = ((int)num2 * -235525294) ^ -1350302503;
					continue;
				case 14u:
				{
					int num8;
					int num9;
					if (player.UseOneMorePlanningSprint)
					{
						num8 = 1870159093;
						num9 = 1870159093;
					}
					else
					{
						num8 = 1520694707;
						num9 = 1520694707;
					}
					num = num8 ^ ((int)num2 * -1421539705);
					continue;
				}
				case 13u:
					planningCardsCount = player.PlanningCardsCount;
					num3 = 0;
					num = (int)((num2 * 1435747666) ^ 0x639CB3EC);
					continue;
				case 12u:
					playerState.Sprint = 1;
					num = (int)(num2 * 455688728) ^ -1325025132;
					continue;
				case 11u:
					playerState.Sprint = -1;
					num = ((int)num2 * -1025901787) ^ -2126115617;
					continue;
				case 10u:
					num4++;
					num = ((int)num2 * -488785776) ^ 0x5093A787;
					continue;
				case 9u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = ((int)num2 * -284912) ^ -426219802;
					continue;
				case 8u:
				{
					int num5;
					if (num4 < Players.Length)
					{
						num = -612780950;
						num5 = -612780950;
					}
					else
					{
						num = -35731863;
						num5 = -35731863;
					}
					continue;
				}
				case 7u:
					player = Players[num4];
					num = (int)((num2 * 1611498541) ^ 0x1A70FC4D);
					continue;
				case 6u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)((num2 * 1655278324) ^ 0x73F8AD5D);
					continue;
				case 5u:
					num = -154738205;
					continue;
				case 4u:
					num = -1554192956;
					continue;
				case 3u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = -96171662;
					continue;
				case 2u:
					num = ((int)num2 * -1702824027) ^ -739131426;
					continue;
				case 1u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = -780198790;
					continue;
				default:
					return;
				case 0u:
					break;
				case 18u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		while (true)
		{
			int num = -1133434326;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDADF6FF4u) % 11u)
				{
				case 10u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -625433709;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (_currentTurn > 0)
					{
						num5 = -559031124;
						num6 = -559031124;
					}
					else
					{
						num5 = -304113827;
						num6 = -304113827;
					}
					num = num5 ^ (int)(num2 * 1408440484);
					continue;
				}
				case 8u:
				{
					int num3;
					int num4;
					if (_currentPlayer < Players.Length)
					{
						num3 = -237699054;
						num4 = -237699054;
					}
					else
					{
						num3 = -466549006;
						num4 = -466549006;
					}
					num = num3 ^ ((int)num2 * -1996444205);
					continue;
				}
				case 6u:
					num = ((int)num2 * -900323317) ^ -405923450;
					continue;
				case 5u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -1687589491) ^ -1165195647;
					continue;
				case 4u:
					PlayerTurn(_currentPlayer);
					num = -1929520843;
					continue;
				case 3u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)(num2 * 1849221318) ^ -1216673261;
					continue;
				case 2u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)(num2 * 506263092) ^ -1329218223;
					continue;
				case 0u:
					_currentPlayer = 0;
					num = (int)((num2 * 20516047) ^ 0x43B16C2F);
					continue;
				default:
					return;
				case 7u:
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
		PlayerState playerState = default(PlayerState);
		bool flag7 = default(bool);
		bool flag3 = default(bool);
		bool flag9 = default(bool);
		bool flag5 = default(bool);
		Card card = default(Card);
		PlayerState playerState2 = default(PlayerState);
		int num8 = default(int);
		bool flag11 = default(bool);
		bool flag = default(bool);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		bool flag4 = default(bool);
		int num16 = default(int);
		bool flag6 = default(bool);
		int num15 = default(int);
		int num3 = default(int);
		Player player = default(Player);
		bool flag12 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 768198913;
			while (true)
			{
				uint num2;
				int num20;
				switch ((num2 = (uint)num ^ 0x4791292Du) % 86u)
				{
				case 84u:
					num = (int)((num2 * 1676426585) ^ 0x4BCB5316);
					continue;
				case 83u:
					playerState.Sprint++;
					num = ((int)num2 * -1262068826) ^ 0x755EBABD;
					continue;
				case 82u:
					num = ((int)num2 * -265414608) ^ 0x7D721FB5;
					continue;
				case 81u:
					flag7 = playerState.Sprint > Rules.SprintCount;
					num = 680533922;
					continue;
				case 80u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = -1080168250;
						num7 = -1080168250;
					}
					else
					{
						num6 = -425956404;
						num7 = -425956404;
					}
					num = num6 ^ ((int)num2 * -1431144727);
					continue;
				}
				case 79u:
					num = ((int)num2 * -406878563) ^ 0x41779C98;
					continue;
				case 78u:
					flag9 = !flag5;
					num = ((int)num2 * -1666482698) ^ 0x13ABCA9E;
					continue;
				case 77u:
					_finished = true;
					num = ((int)num2 * -927713995) ^ 0x694F683;
					continue;
				case 76u:
					card = DrawCard();
					num = 509596050;
					continue;
				case 75u:
					num = 1146824579;
					continue;
				case 74u:
				{
					int num24;
					int num25;
					if (playerState2.Resources >= 0)
					{
						num24 = 1560521624;
						num25 = 1560521624;
					}
					else
					{
						num24 = 1349134535;
						num25 = 1349134535;
					}
					num = num24 ^ ((int)num2 * -198238717);
					continue;
				}
				case 73u:
					playerState.Resources -= num8;
					flag3 = playerState.Resources < 0;
					num = ((int)num2 * -2099678829) ^ -1253504120;
					continue;
				case 72u:
				{
					int num9;
					int num10;
					if (!Rules.OnlyOneWinner)
					{
						num9 = 1014898930;
						num10 = 1014898930;
					}
					else
					{
						num9 = 745893322;
						num10 = 745893322;
					}
					num = num9 ^ ((int)num2 * -380878242);
					continue;
				}
				case 71u:
					playerState = _playerStates[playerIndex];
					num = (int)((num2 * 987607878) ^ 0x5A4103CC);
					continue;
				case 70u:
					flag11 = flag;
					num = 949705974;
					continue;
				case 69u:
				{
					int num32;
					int num33;
					if (!flag10)
					{
						num32 = 45283090;
						num33 = 45283090;
					}
					else
					{
						num32 = 221968652;
						num33 = 221968652;
					}
					num = num32 ^ (int)(num2 * 1665258596);
					continue;
				}
				case 68u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -942922004) ^ 0x404266E7;
					continue;
				case 67u:
				{
					int num28;
					int num29;
					if (!flag8)
					{
						num28 = -489049882;
						num29 = -489049882;
					}
					else
					{
						num28 = -232607823;
						num29 = -232607823;
					}
					num = num28 ^ ((int)num2 * -1847438899);
					continue;
				}
				case 66u:
					num = ((int)num2 * -129865375) ^ -1367675652;
					continue;
				case 65u:
					flag4 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)(num2 * 319314695) ^ -467475139;
						continue;
					}
					num20 = 0;
					goto IL_0265;
				case 64u:
					num = ((int)num2 * -200713115) ^ -1237565570;
					continue;
				case 63u:
					Losers.Add(num16);
					num = (int)(num2 * 2022043356) ^ -1808526213;
					continue;
				case 62u:
					num = 992980708;
					continue;
				case 61u:
					num = 1996226220;
					continue;
				case 60u:
					num = ((int)num2 * -1585907126) ^ -1455198175;
					continue;
				case 59u:
					num = (int)((num2 * 798061225) ^ 0x3569AA9F);
					continue;
				case 58u:
					flag6 = playerState.State != State.Playing;
					num = ((int)num2 * -1968268163) ^ -1171459372;
					continue;
				case 57u:
					num15 = 0;
					num = (int)((num2 * 399464297) ^ 0x1B9C31AA);
					continue;
				case 56u:
					playerState2.Resources -= Game.smethod_3(0, num8 - Players[num16].PlannedForCard(card.Type));
					num = ((int)num2 * -947217630) ^ -431044903;
					continue;
				case 55u:
					num15++;
					num = 1224353575;
					continue;
				case 54u:
					num = (int)(num2 * 580496611) ^ -1591731647;
					continue;
				case 53u:
				{
					int num13;
					int num14;
					if (Losers.Contains(playerIndex))
					{
						num13 = -880660264;
						num14 = -880660264;
					}
					else
					{
						num13 = -1786341336;
						num14 = -1786341336;
					}
					num = num13 ^ (int)(num2 * 907702861);
					continue;
				}
				case 52u:
					playerState.State = State.Won;
					num = ((int)num2 * -1864496224) ^ -1099433716;
					continue;
				case 51u:
					num = 18856885;
					continue;
				case 50u:
					playerState.Sprint++;
					num = ((int)num2 * -2063112471) ^ -1886719614;
					continue;
				case 49u:
					flag = num3 < Rules.StayOnSprintMinDiff;
					num8 = Game.smethod_3(0, num3);
					num = (int)((num2 * 616318125) ^ 0x2CF18628);
					continue;
				case 48u:
				{
					int num36;
					if (!Losers.Contains(num15))
					{
						num = 826585889;
						num36 = 826585889;
					}
					else
					{
						num = 1681377343;
						num36 = 1681377343;
					}
					continue;
				}
				case 47u:
					num = ((int)num2 * -799535498) ^ -59919526;
					continue;
				case 46u:
					player = Players[playerIndex];
					num = ((int)num2 * -888837451) ^ 0x2E33E260;
					continue;
				case 45u:
				{
					int num34;
					int num35;
					if (flag12)
					{
						num34 = 216209606;
						num35 = 216209606;
					}
					else
					{
						num34 = 716340083;
						num35 = 716340083;
					}
					num = num34 ^ ((int)num2 * -510735376);
					continue;
				}
				case 44u:
					playerState2.State = State.Lose;
					flag12 = !Losers.Contains(num16);
					num = 617697450;
					continue;
				case 43u:
					num16++;
					num = 410673054;
					continue;
				case 42u:
					Losers.Add(num15);
					num = ((int)num2 * -1464901836) ^ -235506097;
					continue;
				case 41u:
				{
					int num30;
					int num31;
					if (flag11)
					{
						num30 = 1420513600;
						num31 = 1420513600;
					}
					else
					{
						num30 = 533540671;
						num31 = 533540671;
					}
					num = num30 ^ ((int)num2 * -1168313219);
					continue;
				}
				case 40u:
					flag = true;
					num8 = card.Impact;
					num = ((int)num2 * -866585076) ^ -939318099;
					continue;
				case 39u:
					num = (int)((num2 * 1299760290) ^ 0x6E438B72);
					continue;
				case 38u:
					num = 1973508284;
					continue;
				case 37u:
					flag10 = num16 < _playerStates.Length;
					num = 419236692;
					continue;
				case 36u:
					num = (int)((num2 * 817768207) ^ 0x47C10B5);
					continue;
				case 35u:
					num = ((int)num2 * -1201080525) ^ 0x76DD04EB;
					continue;
				case 34u:
					num = (int)((num2 * 153665024) ^ 0x5BA83CE3);
					continue;
				case 33u:
					num = ((int)num2 * -1256649982) ^ 0x6FA2268D;
					continue;
				case 32u:
					flag2 = num15 < _playerStates.Length;
					num = 1956046663;
					continue;
				case 31u:
					num = 52325881;
					continue;
				case 30u:
					num = (int)((num2 * 499803370) ^ 0x1E3734A1);
					continue;
				case 29u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 371563958;
					continue;
				}
				case 28u:
					playerState.State = State.Lose;
					num = ((int)num2 * -98906064) ^ 0x15A7CE36;
					continue;
				case 27u:
				{
					int num26;
					int num27;
					if (!flag9)
					{
						num26 = 1887441925;
						num27 = 1887441925;
					}
					else
					{
						num26 = 1505262972;
						num27 = 1505262972;
					}
					num = num26 ^ (int)(num2 * 816916863);
					continue;
				}
				case 26u:
					Print("Still planning");
					num = ((int)num2 * -2105958837) ^ -1829906806;
					continue;
				case 25u:
					num = (int)(num2 * 1447698235) ^ -1895352863;
					continue;
				case 24u:
					num = (int)(num2 * 10189728) ^ -601565913;
					continue;
				case 23u:
				{
					int num22;
					int num23;
					if (!flag6)
					{
						num22 = -1972246327;
						num23 = -1972246327;
					}
					else
					{
						num22 = -597341533;
						num23 = -597341533;
					}
					num = num22 ^ ((int)num2 * -750832950);
					continue;
				}
				case 22u:
				{
					int num21;
					if (_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = 816338491;
						num21 = 816338491;
					}
					else
					{
						num = 1271264503;
						num21 = 1271264503;
					}
					continue;
				}
				case 20u:
					num = (int)((num2 * 982839055) ^ 0x1DC0E42E);
					continue;
				case 19u:
					num = ((int)num2 * -551924040) ^ -2030254332;
					continue;
				case 18u:
					playerState2 = _playerStates[num16];
					num = (int)((num2 * 1881813557) ^ 0x1C5036D7);
					continue;
				case 17u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)(num2 * 1985125811) ^ -587164778;
					continue;
				case 16u:
					flag = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -730544442) ^ 0x494E0937;
					continue;
				case 15u:
					num = ((int)num2 * -723382461) ^ 0x7A3EAF7A;
					continue;
				case 14u:
					flag8 = num15 == playerIndex;
					num = 2144617564;
					continue;
				case 13u:
					num20 = ((card.Type == 4) ? 1 : 0);
					goto IL_0265;
				case 12u:
					num = ((int)num2 * -378112530) ^ 0x59A44930;
					continue;
				case 11u:
				{
					int num18;
					int num19;
					if (!flag7)
					{
						num18 = -119664869;
						num19 = -119664869;
					}
					else
					{
						num18 = -1289127086;
						num19 = -1289127086;
					}
					num = num18 ^ ((int)num2 * -763123689);
					continue;
				}
				case 10u:
				{
					int num17;
					if (playerState.Sprint < 0)
					{
						num = 1335195005;
						num17 = 1335195005;
					}
					else
					{
						num = 935183147;
						num17 = 935183147;
					}
					continue;
				}
				case 9u:
					num16 = 0;
					num = 1828199584;
					continue;
				case 8u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag5 ? "ALL " : "", flag4 ? "receives" : "pays", Game.smethod_4(num8), flag ? "advance" : "stay");
					num = 1080296649;
					continue;
				case 7u:
					num = 113816002;
					continue;
				case 6u:
					num = ((int)num2 * -1160435944) ^ 0x7A9197A;
					continue;
				case 5u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = -1265267026;
						num12 = -1265267026;
					}
					else
					{
						num11 = -1085412804;
						num12 = -1085412804;
					}
					num = num11 ^ ((int)num2 * -1466649424);
					continue;
				}
				case 4u:
					Print(playerState.State);
					num = ((int)num2 * -320212678) ^ 0x5CB91304;
					continue;
				case 3u:
					Winners.Add(playerIndex);
					num = (int)((num2 * 1422447516) ^ 0x4F8EDF15);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = 793383057;
						num5 = 793383057;
					}
					else
					{
						num4 = 1187202203;
						num5 = 1187202203;
					}
					num = num4 ^ (int)(num2 * 2120945835);
					continue;
				}
				case 1u:
					num3 = card.Impact - player.PlannedForCard(card.Type);
					num = ((int)num2 * -1235291280) ^ 0x5924773E;
					continue;
				case 0u:
					flag = false;
					num = 934460431;
					continue;
				default:
					return;
				case 85u:
					break;
				case 21u:
					return;
					IL_0265:
					flag5 = (byte)num20 != 0;
					num = 1387172438;
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
			int num = 1124379575;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6976CEC3u) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (_deck.Count > 0)
					{
						num3 = 840423594;
						num4 = 840423594;
					}
					else
					{
						num3 = 878461764;
						num4 = 878461764;
					}
					num = num3 ^ ((int)num2 * -1491319282);
					continue;
				}
				case 4u:
					result = card;
					num = ((int)num2 * -411249324) ^ -1652229877;
					continue;
				case 3u:
					card = _deck[0];
					_deck.RemoveAt(0);
					num = 1128409107;
					continue;
				case 1u:
					ShuffleCards();
					num = ((int)num2 * -1367837810) ^ 0x2CD5BA40;
					continue;
				case 0u:
					num = (int)((num2 * 552195559) ^ 0x7FC3284F);
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

	public string ToString(bool initial)
	{
		string text = "";
		string result = default(string);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 306725376;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x28C13DE4u) % 9u)
				{
				case 8u:
					result = text;
					num = (int)((num2 * 1627983379) ^ 0x1C4FAFBB);
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -2107293975) ^ -1944398874;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1420309885;
						num5 = -1420309885;
					}
					else
					{
						num4 = -111239276;
						num5 = -111239276;
					}
					num = num4 ^ (int)(num2 * 32353949);
					continue;
				}
				case 3u:
					num = (int)(num2 * 631690061) ^ -1495069827;
					continue;
				case 2u:
					num3++;
					num = (int)((num2 * 1536393380) ^ 0x7F6DD596);
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
					num = 276232721;
					continue;
				}
				case 0u:
					flag = num3 < _playerStates.Length;
					num = 979005749;
					continue;
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
			int num = 447423682;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29F1A104u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = ToString(initial: false);
				num = (int)(num2 * 1873147411) ^ -787203278;
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
