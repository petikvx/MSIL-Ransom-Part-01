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
			bool flag = default(bool);
			int num3 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = 773473127;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x370661CBu) % 15u)
					{
					case 14u:
						num = 1266415463;
						continue;
					case 13u:
						result = true;
						num = ((int)num2 * -1278572447) ^ 0x42B52A4;
						continue;
					case 12u:
					{
						int num6;
						int num7;
						if (!flag)
						{
							num6 = 932366604;
							num7 = 932366604;
						}
						else
						{
							num6 = 1984303857;
							num7 = 1984303857;
						}
						num = num6 ^ ((int)num2 * -1700290266);
						continue;
					}
					case 11u:
						num3++;
						num = 1182634773;
						continue;
					case 10u:
					{
						int num8;
						if (num3 >= playerStates.Length)
						{
							num = 233961174;
							num8 = 233961174;
						}
						else
						{
							num = 876648125;
							num8 = 876648125;
						}
						continue;
					}
					case 8u:
						num = ((int)num2 * -626615161) ^ -1891813666;
						continue;
					case 7u:
						num3 = 0;
						num = ((int)num2 * -90385665) ^ -1613779923;
						continue;
					case 6u:
						result = false;
						num = ((int)num2 * -1267636782) ^ 0x438F7EA7;
						continue;
					case 5u:
						result = true;
						num = ((int)num2 * -1820755600) ^ -802449173;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (!finished)
						{
							num4 = -1645788946;
							num5 = -1645788946;
						}
						else
						{
							num4 = -1279506621;
							num5 = -1279506621;
						}
						num = num4 ^ ((int)num2 * -163220873);
						continue;
					}
					case 3u:
						playerState = playerStates[num3];
						num = 1651771228;
						continue;
					case 2u:
						flag = playerState.State == State.Playing;
						num = (int)((num2 * 78179397) ^ 0x562DEB66);
						continue;
					case 1u:
						playerStates = _playerStates;
						num = ((int)num2 * -1193060902) ^ -1151233157;
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1657898038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84019A56u) % 18u)
				{
				case 17u:
					count = jSONNode.Count;
					num = ((int)num2 * -1806811147) ^ -1878395045;
					continue;
				case 16u:
					num = ((int)num2 * -880540790) ^ -1193082140;
					continue;
				case 15u:
					num3++;
					num = ((int)num2 * -1955466288) ^ 0x64EDA54;
					continue;
				case 14u:
					num4++;
					num = ((int)num2 * -1250875714) ^ -1539204217;
					continue;
				case 13u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					_dice = new Dice();
					jSONNode = json["players"];
					num = (int)((num2 * 381693811) ^ 0x6E9B6362);
					continue;
				case 12u:
					flag = num3 < count;
					num = -961524114;
					continue;
				case 11u:
					_buffer = buffer;
					num = ((int)num2 * -522861458) ^ 0x3254A241;
					continue;
				case 10u:
					Players = new Player[count];
					num = ((int)num2 * -188600087) ^ 0x761BCE37;
					continue;
				case 9u:
					num4 = 0;
					num = ((int)num2 * -794208576) ^ -1053143620;
					continue;
				case 8u:
					num = ((int)num2 * -558670575) ^ -137006339;
					continue;
				case 6u:
					num = (int)(num2 * 85359429) ^ -827768349;
					continue;
				case 5u:
					Players[num4] = Player.Deserialize(jSONNode[num4]);
					num = -487782210;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 1720567215;
						num7 = 1720567215;
					}
					else
					{
						num6 = 895181153;
						num7 = 895181153;
					}
					num = num6 ^ ((int)num2 * -1134540988);
					continue;
				}
				case 3u:
					_playerStates[num3] = new PlayerState();
					num = -785192483;
					continue;
				case 1u:
				{
					int num5;
					if (num4 < count)
					{
						num = -363964155;
						num5 = -363964155;
					}
					else
					{
						num = -186537780;
						num5 = -186537780;
					}
					continue;
				}
				case 0u:
					_playerStates = new PlayerState[count];
					num3 = 0;
					num = (int)(num2 * 1369629589) ^ -2133538860;
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

	public void ShuffleCards()
	{
		_deck = new List<Card>(Rules.Cards);
	}

	public void StartNew()
	{
		while (true)
		{
			int num = -17090645;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D5FABBCu) % 11u)
				{
				case 10u:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 876608217) ^ 0x1CCC2435);
					continue;
				case 9u:
					Winners.Clear();
					num = (int)((num2 * 1958318337) ^ 0x64DDB3F7);
					continue;
				case 7u:
					Losers.Clear();
					num = ((int)num2 * -1715610020) ^ 0x31F77237;
					continue;
				case 6u:
					num = ((int)num2 * -603972093) ^ -794673951;
					continue;
				case 5u:
					num = (int)(num2 * 655726747) ^ -380315714;
					continue;
				case 4u:
					_finished = false;
					num = ((int)num2 * -754866708) ^ 0x62A518B0;
					continue;
				case 2u:
					_currentTurn = 0;
					num = (int)((num2 * 1324342892) ^ 0x1A76B562);
					continue;
				case 1u:
					ShuffleCards();
					num = ((int)num2 * -724680889) ^ -613970673;
					continue;
				case 0u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1059695424) ^ -774841584;
					continue;
				default:
					return;
				case 8u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		int num = 0;
		bool flag2 = default(bool);
		int num8 = default(int);
		int planningCardsCount = default(int);
		PlayerState playerState = default(PlayerState);
		Player player = default(Player);
		while (true)
		{
			bool flag = num < Players.Length;
			int num2 = -516219397;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA73137BCu) % 26u)
				{
				case 25u:
					num2 = -1096279543;
					continue;
				case 24u:
					num2 = (int)(num3 * 875718933) ^ -1158168639;
					continue;
				case 22u:
					flag2 = num8 > 0;
					num2 = -228418957;
					continue;
				case 21u:
					num8 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = ((int)num3 * -312850455) ^ -472568876;
					continue;
				case 20u:
					playerState.Sprint = -1;
					playerState.Resources -= num8 * Rules.NormalPlanningCost;
					num2 = ((int)num3 * -2032913351) ^ -297298190;
					continue;
				case 19u:
					num2 = ((int)num3 * -1386685834) ^ 0x34AE4D8F;
					continue;
				case 18u:
					num2 = -899307379;
					continue;
				case 17u:
					playerState.Resources -= (planningCardsCount - num8) * Rules.NormalPlanningCost;
					num2 = -2116586169;
					continue;
				case 16u:
					playerState = _playerStates[num];
					num2 = (int)(num3 * 356925645) ^ -1856016174;
					continue;
				case 14u:
					playerState.Sprint = 0;
					num2 = ((int)num3 * -309085301) ^ -1173567537;
					continue;
				case 13u:
					num++;
					num2 = ((int)num3 * -1996117797) ^ -664435780;
					continue;
				case 12u:
					num2 = -1657880146;
					continue;
				case 11u:
					playerState.Resources -= num8 * Rules.OverPlanningCost;
					num2 = (int)((num3 * 144494828) ^ 0x57E0BAEB);
					continue;
				case 10u:
					num2 = (int)(num3 * 189259786) ^ -635278084;
					continue;
				case 9u:
				{
					int num11;
					int num12;
					if (!player.UseOneMorePlanningSprint)
					{
						num11 = -1854197045;
						num12 = -1854197045;
					}
					else
					{
						num11 = -847700793;
						num12 = -847700793;
					}
					num2 = num11 ^ ((int)num3 * -1569610253);
					continue;
				}
				case 8u:
				{
					num8 = 0;
					int num9;
					int num10;
					if (planningCardsCount != 0)
					{
						num9 = 303216740;
						num10 = 303216740;
					}
					else
					{
						num9 = 2032317149;
						num10 = 2032317149;
					}
					num2 = num9 ^ (int)(num3 * 1316873587);
					continue;
				}
				case 7u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num2 = ((int)num3 * -584071327) ^ 0x3B4CAF8D;
					continue;
				case 6u:
					num8 = 0;
					num2 = -864814515;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -675821315;
						num7 = -675821315;
					}
					else
					{
						num6 = -41250260;
						num7 = -41250260;
					}
					num2 = num6 ^ (int)(num3 * 1682104222);
					continue;
				}
				case 4u:
					player = Players[num];
					num2 = -1923065202;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 2089078271;
						num5 = 2089078271;
					}
					else
					{
						num4 = 218457388;
						num5 = 218457388;
					}
					num2 = num4 ^ (int)(num3 * 527943847);
					continue;
				}
				case 2u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = (int)(num3 * 1391491011) ^ -823430680;
					continue;
				case 1u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -1604152257) ^ 0x376F433D;
					continue;
				case 0u:
					num2 = (int)((num3 * 995232752) ^ 0xE5127C9);
					continue;
				default:
					return;
				case 23u:
					break;
				case 15u:
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
			int num = 39481414;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F0FF405u) % 15u)
				{
				case 14u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -1320823034) ^ -608025119;
					continue;
				case 13u:
					_currentPlayer++;
					flag2 = _currentPlayer >= Players.Length;
					num = (int)(num2 * 2008508996) ^ -39391234;
					continue;
				case 12u:
					num = (int)((num2 * 1330494184) ^ 0x3EA9421D);
					continue;
				case 11u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)(num2 * 1123064642) ^ -2065184966;
					continue;
				case 9u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -755958307) ^ -2031116524;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 262379966;
						num6 = 262379966;
					}
					else
					{
						num5 = 276994078;
						num6 = 276994078;
					}
					num = num5 ^ (int)(num2 * 1686584407);
					continue;
				}
				case 7u:
					num = (int)((num2 * 934604529) ^ 0x2F7CC8C7);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -18003676;
						num4 = -18003676;
					}
					else
					{
						num3 = -849648552;
						num4 = -849648552;
					}
					num = num3 ^ (int)(num2 * 69327129);
					continue;
				}
				case 5u:
					flag = _currentTurn > 0;
					num = (int)((num2 * 1874347200) ^ 0x7B1E2C9D);
					continue;
				case 4u:
					num = (int)((num2 * 27804057) ^ 0x11BC858);
					continue;
				case 3u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 1659539835;
					continue;
				case 2u:
					num = (int)((num2 * 1850423904) ^ 0x5A23A080);
					continue;
				case 1u:
					_currentPlayer = 0;
					num = (int)((num2 * 907644339) ^ 0x7108F48A);
					continue;
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
		Player player = default(Player);
		PlayerState playerState2 = default(PlayerState);
		bool flag12 = default(bool);
		int num13 = default(int);
		Card card = default(Card);
		bool onlyOneWinner = default(bool);
		PlayerState playerState = default(PlayerState);
		int num5 = default(int);
		int num6 = default(int);
		bool flag11 = default(bool);
		bool flag2 = default(bool);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		int num24 = default(int);
		bool flag8 = default(bool);
		bool flag6 = default(bool);
		bool flag7 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = 1464792504;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x124B7C30u) % 87u)
				{
				case 86u:
					player = Players[playerIndex];
					playerState2 = _playerStates[playerIndex];
					num = ((int)num2 * -1847891430) ^ -288028317;
					continue;
				case 85u:
				{
					int num33;
					int num34;
					if (flag12)
					{
						num33 = -372142828;
						num34 = -372142828;
					}
					else
					{
						num33 = -1088243552;
						num34 = -1088243552;
					}
					num = num33 ^ (int)(num2 * 823882754);
					continue;
				}
				case 84u:
					num13++;
					num = 275710516;
					continue;
				case 83u:
					num7 = ((card.Type == 4) ? 1 : 0);
					goto IL_006e;
				case 82u:
				{
					int num15;
					int num16;
					if (onlyOneWinner)
					{
						num15 = 1920251389;
						num16 = 1920251389;
					}
					else
					{
						num15 = 662820773;
						num16 = 662820773;
					}
					num = num15 ^ ((int)num2 * -936147374);
					continue;
				}
				case 81u:
					playerState.Resources -= Game.smethod_3(0, num5 - Players[num6].PlannedForCard(card.Type));
					num = (int)(num2 * 1398971568) ^ -1379042250;
					continue;
				case 80u:
					num = 319501091;
					continue;
				case 79u:
				{
					int num8;
					if (playerState2.Sprint >= 0)
					{
						num = 1321336802;
						num8 = 1321336802;
					}
					else
					{
						num = 1258047562;
						num8 = 1258047562;
					}
					continue;
				}
				case 78u:
				{
					int num27;
					int num28;
					if (flag11)
					{
						num27 = -514869581;
						num28 = -514869581;
					}
					else
					{
						num27 = -1681412320;
						num28 = -1681412320;
					}
					num = num27 ^ ((int)num2 * -969024361);
					continue;
				}
				case 77u:
					num = 1094829245;
					continue;
				case 76u:
					num = ((int)num2 * -207222941) ^ -2052546444;
					continue;
				case 75u:
					num = ((int)num2 * -481171116) ^ 0x54FD9B58;
					continue;
				case 74u:
					num = (int)(num2 * 188204566) ^ -200807849;
					continue;
				case 73u:
					num = (int)(num2 * 513991698) ^ -406158584;
					continue;
				case 72u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag2 ? "ALL " : "", flag10 ? "receives" : "pays", Game.smethod_4(num5), flag9 ? "advance" : "stay");
					num = 318473349;
					continue;
				case 71u:
					flag9 = num24 < Rules.StayOnSprintMinDiff;
					num = (int)((num2 * 445464357) ^ 0x129B46D2);
					continue;
				case 70u:
					num = (int)((num2 * 1725713429) ^ 0x7B1403FC);
					continue;
				case 69u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)(num2 * 932719036) ^ -1241198516;
						continue;
					}
					num7 = 0;
					goto IL_006e;
				case 68u:
					flag9 = false;
					num = 86534427;
					continue;
				case 67u:
					num24 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)((num2 * 1543470114) ^ 0x2CBBC66F);
					continue;
				case 66u:
				{
					int num18;
					int num19;
					if (!flag8)
					{
						num18 = -45511848;
						num19 = -45511848;
					}
					else
					{
						num18 = -738903530;
						num19 = -738903530;
					}
					num = num18 ^ ((int)num2 * -1913575562);
					continue;
				}
				case 65u:
					Print(playerState2.State);
					num = (int)((num2 * 1436741916) ^ 0x3B6D7364);
					continue;
				case 64u:
				{
					int num11;
					int num12;
					if (flag6)
					{
						num11 = 139597230;
						num12 = 139597230;
					}
					else
					{
						num11 = 1167976922;
						num12 = 1167976922;
					}
					num = num11 ^ ((int)num2 * -1012353089);
					continue;
				}
				case 63u:
					num = (int)(num2 * 1929819168) ^ -2091820124;
					continue;
				case 62u:
					num = (int)((num2 * 1815948095) ^ 0x138C48C5);
					continue;
				case 61u:
					num = (int)(num2 * 2111805541) ^ -1368510822;
					continue;
				case 60u:
					num = (int)((num2 * 691576390) ^ 0x2C0A257C);
					continue;
				case 59u:
				{
					int num35;
					int num36;
					if (playerState2.State != 0)
					{
						num35 = -1589356864;
						num36 = -1589356864;
					}
					else
					{
						num35 = -79897070;
						num36 = -79897070;
					}
					num = num35 ^ (int)(num2 * 721092803);
					continue;
				}
				case 58u:
					card = DrawCard();
					flag10 = card.Impact < 0;
					num = ((int)num2 * -1725870438) ^ 0x2E8B23CC;
					continue;
				case 57u:
				{
					int num31;
					int num32;
					if (!flag7)
					{
						num31 = -590939476;
						num32 = -590939476;
					}
					else
					{
						num31 = -1129528468;
						num32 = -1129528468;
					}
					num = num31 ^ (int)(num2 * 182516051);
					continue;
				}
				case 56u:
					num6 = 0;
					num = 1927504953;
					continue;
				case 55u:
					playerState = _playerStates[num6];
					num = (int)(num2 * 574191909) ^ -1676848670;
					continue;
				case 54u:
				{
					int num29;
					int num30;
					if (playerState2.Resources < 0)
					{
						num29 = 1024200424;
						num30 = 1024200424;
					}
					else
					{
						num29 = 415634997;
						num30 = 415634997;
					}
					num = num29 ^ (int)(num2 * 359178279);
					continue;
				}
				case 53u:
					num = (int)((num2 * 1114784817) ^ 0x2C0665AA);
					continue;
				case 52u:
					num = ((int)num2 * -1114877043) ^ -130453836;
					continue;
				case 51u:
					num = (int)((num2 * 164936548) ^ 0x31AAC817);
					continue;
				case 50u:
					Losers.Add(num13);
					num = (int)(num2 * 1543401758) ^ -54773549;
					continue;
				case 49u:
					num = (int)(num2 * 1193123005) ^ -89887186;
					continue;
				case 48u:
					flag12 = !Losers.Contains(num13);
					num = 1190091485;
					continue;
				case 47u:
					flag9 = true;
					num5 = card.Impact;
					num = 340292373;
					continue;
				case 46u:
					flag9 = true;
					Print("CARD: none, advance");
					num = (int)((num2 * 928207377) ^ 0x404B9AAD);
					continue;
				case 44u:
					num5 = Game.smethod_3(0, num24);
					num = ((int)num2 * -1092544882) ^ 0x45177D65;
					continue;
				case 43u:
				{
					int num25;
					int num26;
					if (!flag3)
					{
						num25 = 928285925;
						num26 = 928285925;
					}
					else
					{
						num25 = 1478981645;
						num26 = 1478981645;
					}
					num = num25 ^ (int)(num2 * 980463862);
					continue;
				}
				case 42u:
					flag11 = !flag10;
					num = (int)((num2 * 2005360976) ^ 0x22B5412C);
					continue;
				case 41u:
					num6++;
					num = 1927504953;
					continue;
				case 40u:
				{
					int num22;
					int num23;
					if (flag4)
					{
						num22 = -1043482605;
						num23 = -1043482605;
					}
					else
					{
						num22 = -2125566841;
						num23 = -2125566841;
					}
					num = num22 ^ (int)(num2 * 1679888947);
					continue;
				}
				case 39u:
					num = 992050739;
					continue;
				case 38u:
					playerState2.Resources -= num5;
					num = ((int)num2 * -1108684942) ^ 0xB0CCE11;
					continue;
				case 37u:
					num = ((int)num2 * -2069054480) ^ 0x5FC5FFC3;
					continue;
				case 36u:
					flag = playerState2.Sprint > Rules.SprintCount;
					num = 971160016;
					continue;
				case 35u:
					num = ((int)num2 * -766121373) ^ 0x68FAC788;
					continue;
				case 34u:
					num = ((int)num2 * -1516915558) ^ -1310254676;
					continue;
				case 33u:
				{
					int num20;
					int num21;
					if (num13 != playerIndex)
					{
						num20 = -1456535302;
						num21 = -1456535302;
					}
					else
					{
						num20 = -106966754;
						num21 = -106966754;
					}
					num = num20 ^ ((int)num2 * -1311933423);
					continue;
				}
				case 32u:
					playerState2.State = State.Lose;
					num = (int)((num2 * 1235265138) ^ 0x69FA6591);
					continue;
				case 31u:
				{
					int num17;
					if (_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = 1866486143;
						num17 = 1866486143;
					}
					else
					{
						num = 1327996812;
						num17 = 1327996812;
					}
					continue;
				}
				case 30u:
					num = 101939253;
					continue;
				case 29u:
				{
					int num14;
					if (!flag9)
					{
						num = 737619069;
						num14 = 737619069;
					}
					else
					{
						num = 843975148;
						num14 = 843975148;
					}
					continue;
				}
				case 28u:
					_finished = true;
					num = (int)((num2 * 859956898) ^ 0x68BC0E02);
					continue;
				case 27u:
					flag8 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -428465949) ^ 0x381E296;
					continue;
				case 26u:
					num = (int)(num2 * 86178837) ^ -679838815;
					continue;
				case 25u:
					num = 1848260360;
					continue;
				case 24u:
					flag7 = num13 < _playerStates.Length;
					num = 2033111133;
					continue;
				case 23u:
					playerState2.Sprint++;
					num = ((int)num2 * -689207220) ^ -1428623059;
					continue;
				case 22u:
					playerState2.Sprint++;
					Print("Still planning");
					num = (int)((num2 * 488692804) ^ 0x521F21B5);
					continue;
				case 21u:
					num = 15609426;
					continue;
				case 20u:
					num = (int)(num2 * 1491431913) ^ -643578325;
					continue;
				case 19u:
					num = ((int)num2 * -1166869226) ^ -263715307;
					continue;
				case 18u:
					num13 = 0;
					num = (int)(num2 * 1957144362) ^ -566964137;
					continue;
				case 17u:
					num = (int)((num2 * 707356563) ^ 0x6D763D1F);
					continue;
				case 16u:
					playerState.State = State.Lose;
					flag5 = !Losers.Contains(num6);
					num = 1788996037;
					continue;
				case 15u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 676499858) ^ 0x16C393D4);
					continue;
				case 14u:
					flag6 = !flag2;
					num = ((int)num2 * -1808883940) ^ -1127385663;
					continue;
				case 13u:
					num = ((int)num2 * -1558897211) ^ 0x26B650E1;
					continue;
				case 12u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -1331956270) ^ -1469562430;
					continue;
				case 11u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -61009764) ^ 0x29CE40B2;
					continue;
				case 10u:
					Losers.Add(num6);
					num = (int)(num2 * 1505772652) ^ -685968905;
					continue;
				case 9u:
					playerState2.State = State.Won;
					Winners.Add(playerIndex);
					num = (int)(num2 * 1976295494) ^ -767077116;
					continue;
				case 8u:
					num = 14151906;
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (!flag5)
					{
						num9 = 1087539063;
						num10 = 1087539063;
					}
					else
					{
						num9 = 2097176453;
						num10 = 2097176453;
					}
					num = num9 ^ ((int)num2 * -1887215225);
					continue;
				}
				case 6u:
					flag4 = num6 < _playerStates.Length;
					num = 1715309617;
					continue;
				case 5u:
					flag3 = playerState.Resources >= 0;
					num = ((int)num2 * -1209106713) ^ 0x15B4A6C0;
					continue;
				case 4u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 23735160;
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1826509967;
						num4 = -1826509967;
					}
					else
					{
						num3 = -1782916088;
						num4 = -1782916088;
					}
					num = num3 ^ ((int)num2 * -2097631192);
					continue;
				}
				case 2u:
					num = 1648528551;
					continue;
				case 0u:
					num = (int)((num2 * 1476999487) ^ 0xACDF5AF);
					continue;
				default:
					return;
				case 45u:
					break;
				case 1u:
					return;
					IL_006e:
					flag2 = (byte)num7 != 0;
					num = 1124801504;
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
			int num = -81784490;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9012A091u) % 9u)
				{
				case 7u:
					ShuffleCards();
					num = ((int)num2 * -1472178936) ^ -1526694213;
					continue;
				case 6u:
					card = _deck[0];
					num = -316324549;
					continue;
				case 5u:
					flag = _deck.Count <= 0;
					num = (int)(num2 * 1455027626) ^ -897667156;
					continue;
				case 4u:
					result = card;
					num = ((int)num2 * -1968963765) ^ -1339044517;
					continue;
				case 3u:
					_deck.RemoveAt(0);
					num = ((int)num2 * -1776800163) ^ 0x18B58300;
					continue;
				case 1u:
					num = ((int)num2 * -2136412797) ^ 0x49E21B8A;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1173047986;
						num4 = 1173047986;
					}
					else
					{
						num3 = 245404573;
						num4 = 245404573;
					}
					num = num3 ^ (int)(num2 * 1440858314);
					continue;
				}
				case 8u:
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
		string text = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 921050473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x622A5B5Du) % 9u)
				{
				case 8u:
					text = "";
					num = ((int)num2 * -65871309) ^ 0x176845F;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -1222555569) ^ 0x5B5EFA44;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -752438547) ^ -1639855948;
					continue;
				case 5u:
				{
					int num4;
					if (num3 < _playerStates.Length)
					{
						num = 1551444124;
						num4 = 1551444124;
					}
					else
					{
						num = 918313375;
						num4 = 918313375;
					}
					continue;
				}
				case 4u:
					result = text;
					num = (int)((num2 * 427562297) ^ 0x78D414CA);
					continue;
				case 1u:
					num = ((int)num2 * -219908898) ^ -1244623243;
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
					num = 1012164471;
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
		string result = default(string);
		while (true)
		{
			int num = -304375001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2C162D3u) % 3u)
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
				num = ((int)num2 * -1826738623) ^ -2129273731;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = 1820364349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x478C2783u) % 4u)
				{
				case 3u:
					Game.smethod_8(_buffer, string_);
					num = ((int)num2 * -1847615164) ^ 0x3410AA62;
					continue;
				case 2u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = (int)((num2 * 615114866) ^ 0x7B3B5728);
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
