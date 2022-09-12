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
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = 1743514984;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64852052u) % 14u)
					{
					case 12u:
						result = true;
						num = (int)(num2 * 481648947) ^ -1202607442;
						continue;
					case 11u:
						result = true;
						num = (int)((num2 * 1334326430) ^ 0x3DEFBC93);
						continue;
					case 10u:
						playerStates = _playerStates;
						num3 = 0;
						num = 1915529548;
						continue;
					case 9u:
						result = false;
						num = ((int)num2 * -752252884) ^ 0x5864D64A;
						continue;
					case 8u:
						playerState = playerStates[num3];
						num = 146661259;
						continue;
					case 7u:
						num = (int)(num2 * 1214431651) ^ -138483286;
						continue;
					case 6u:
						num = ((int)num2 * -775207646) ^ -976884397;
						continue;
					case 5u:
						num3++;
						num = 1915529548;
						continue;
					case 4u:
						num = (int)((num2 * 391316280) ^ 0x1F8C396F);
						continue;
					case 2u:
					{
						int num7;
						int num8;
						if (finished)
						{
							num7 = 1476687525;
							num8 = 1476687525;
						}
						else
						{
							num7 = 120431290;
							num8 = 120431290;
						}
						num = num7 ^ (int)(num2 * 111120397);
						continue;
					}
					case 1u:
					{
						int num5;
						int num6;
						if (playerState.State != 0)
						{
							num5 = 1599309987;
							num6 = 1599309987;
						}
						else
						{
							num5 = 796078407;
							num6 = 796078407;
						}
						num = num5 ^ (int)(num2 * 1306287718);
						continue;
					}
					case 0u:
					{
						int num4;
						if (num3 < playerStates.Length)
						{
							num = 2000924512;
							num4 = 2000924512;
						}
						else
						{
							num = 1721169076;
							num4 = 1721169076;
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		int num6 = default(int);
		int num5 = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int count = default(int);
		while (true)
		{
			int num = 219353896;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CDB0836u) % 18u)
				{
				case 17u:
					_dice = new Dice();
					num = ((int)num2 * -2017993650) ^ -1835563617;
					continue;
				case 16u:
					_playerStates[num6] = new PlayerState();
					num6++;
					num = 1524220290;
					continue;
				case 15u:
					Players[num5] = Player.Deserialize(jSONNode[num5]);
					num5++;
					num = 1818597862;
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1246472748;
						num8 = -1246472748;
					}
					else
					{
						num7 = -37066236;
						num8 = -37066236;
					}
					num = num7 ^ (int)(num2 * 1975976250);
					continue;
				}
				case 13u:
					num = (int)(num2 * 2133403021) ^ -1456660687;
					continue;
				case 12u:
					flag = num5 < count;
					num = 1471794793;
					continue;
				case 11u:
					_playerStates = new PlayerState[count];
					num6 = 0;
					num = ((int)num2 * -1164615397) ^ -275320235;
					continue;
				case 10u:
					num5 = 0;
					num = (int)((num2 * 1988849499) ^ 0x5D67006E);
					continue;
				case 9u:
					jSONNode = json["players"];
					num = ((int)num2 * -2105304893) ^ 0xA21E315;
					continue;
				case 8u:
					flag2 = num6 < count;
					num = 2106057316;
					continue;
				case 7u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = ((int)num2 * -408193275) ^ -389593032;
					continue;
				case 6u:
					num = (int)((num2 * 1179201454) ^ 0x8C8CE5);
					continue;
				case 4u:
					_buffer = buffer;
					num = (int)((num2 * 1908215045) ^ 0x32B68F23);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 782202733;
						num4 = 782202733;
					}
					else
					{
						num3 = 1467752765;
						num4 = 1467752765;
					}
					num = num3 ^ ((int)num2 * -741016126);
					continue;
				}
				case 2u:
					count = jSONNode.Count;
					num = ((int)num2 * -1007734494) ^ 0x7060F255;
					continue;
				case 1u:
					Players = new Player[count];
					num = ((int)num2 * -1919603078) ^ -1124525416;
					continue;
				default:
					return;
				case 5u:
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
			int num = -1503990424;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80B1AAD5u) % 7u)
				{
				case 5u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					num = ((int)num2 * -741780346) ^ 0x5B2EF79D;
					continue;
				case 4u:
					_finished = false;
					_currentChanceIndex = -1;
					num = ((int)num2 * -2111915555) ^ -1057785991;
					continue;
				case 2u:
					Losers.Clear();
					num = (int)(num2 * 341931750) ^ -325923038;
					continue;
				case 1u:
					Winners.Clear();
					num = ((int)num2 * -407469806) ^ 0x4C0B771D;
					continue;
				case 0u:
					_chances = new List<float>(Rules.RiskChances);
					num = (int)(num2 * 1146592519) ^ -1009943407;
					continue;
				default:
					return;
				case 6u:
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
		int num5 = default(int);
		int planningCardsCount = default(int);
		Player player = default(Player);
		PlayerState playerState = default(PlayerState);
		while (true)
		{
			int num2 = -839735222;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xDC1F03C3u) % 24u)
				{
				case 22u:
				{
					num5 = 0;
					int num6;
					int num7;
					if (planningCardsCount == 0)
					{
						num6 = 1123106118;
						num7 = 1123106118;
					}
					else
					{
						num6 = 2134570888;
						num7 = 2134570888;
					}
					num2 = num6 ^ ((int)num3 * -1579936872);
					continue;
				}
				case 21u:
				{
					int num9;
					if (num5 > 0)
					{
						num2 = -1921700109;
						num9 = -1921700109;
					}
					else
					{
						num2 = -818458587;
						num9 = -818458587;
					}
					continue;
				}
				case 20u:
					num2 = ((int)num3 * -1690823121) ^ -452375509;
					continue;
				case 19u:
				{
					num5 = planningCardsCount - Rules.NormalPlanningCount;
					int num8;
					if (!player.UseOneMorePlanningSprint)
					{
						num2 = -2015713330;
						num8 = -2015713330;
					}
					else
					{
						num2 = -271302862;
						num8 = -271302862;
					}
					continue;
				}
				case 17u:
					player = Players[num];
					playerState = _playerStates[num];
					num2 = (int)((num3 * 98374510) ^ 0x5D5161D7);
					continue;
				case 16u:
					playerState.Resources -= num5 * Rules.OverPlanningCost;
					num2 = ((int)num3 * -42972952) ^ 0x59B8B9AF;
					continue;
				case 15u:
					playerState.Resources -= (planningCardsCount - num5) * Rules.NormalPlanningCost;
					num++;
					num2 = -1054275437;
					continue;
				case 14u:
					num2 = (int)(num3 * 165189771) ^ -318902386;
					continue;
				case 13u:
					playerState.Resources = Rules.InitialResources;
					num2 = ((int)num3 * -19532737) ^ 0x7FA1034A;
					continue;
				case 12u:
					num2 = -213629180;
					continue;
				case 11u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = ((int)num3 * -1836876154) ^ -8217881;
					continue;
				case 10u:
					playerState.Sprint = 0;
					num2 = (int)((num3 * 546159061) ^ 0x2D5546DC);
					continue;
				case 9u:
					num2 = (int)(num3 * 387659232) ^ -1601598793;
					continue;
				case 8u:
					num2 = ((int)num3 * -1304599635) ^ -1517421177;
					continue;
				case 7u:
					num2 = -1755487526;
					continue;
				case 6u:
					num5 = 0;
					num2 = -1114696065;
					continue;
				case 5u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -1187195141) ^ -1687048822;
					continue;
				case 4u:
					playerState.Sprint = -1;
					num2 = ((int)num3 * -626136877) ^ -2053397908;
					continue;
				case 3u:
					playerState.Resources -= num5 * Rules.NormalPlanningCost;
					num2 = ((int)num3 * -1739313264) ^ -1629957461;
					continue;
				case 2u:
					playerState.State = State.Playing;
					num2 = ((int)num3 * -1514546829) ^ -436474970;
					continue;
				case 1u:
					num2 = ((int)num3 * -1718854286) ^ -1036377967;
					continue;
				case 0u:
				{
					int num4;
					if (num >= Players.Length)
					{
						num2 = -232488996;
						num4 = -232488996;
					}
					else
					{
						num2 = -1567992236;
						num4 = -1567992236;
					}
					continue;
				}
				default:
					return;
				case 18u:
					break;
				case 23u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -521570869;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3B666D6u) % 16u)
				{
				case 15u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = ((int)num2 * -1937708093) ^ 0x1B1D4962;
					continue;
				case 14u:
					num = (int)((num2 * 2031694591) ^ 0x435C1A90);
					continue;
				case 13u:
					flag2 = _currentPlayer >= Players.Length;
					num = (int)((num2 * 1264848382) ^ 0x3DF6BD72);
					continue;
				case 12u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 1778257862) ^ 0x3EAFC6F0);
					continue;
				case 11u:
					num = ((int)num2 * -31446566) ^ -1247338081;
					continue;
				case 9u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -459442381) ^ 0x5473E966;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1890103942;
						num6 = -1890103942;
					}
					else
					{
						num5 = -2123115310;
						num6 = -2123115310;
					}
					num = num5 ^ (int)(num2 * 1548536677);
					continue;
				}
				case 7u:
					num = ((int)num2 * -800211961) ^ -408856687;
					continue;
				case 6u:
					PlayerTurn(_currentPlayer);
					num = -1388933497;
					continue;
				case 5u:
					num = ((int)num2 * -1413953295) ^ 0x5EC84323;
					continue;
				case 4u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -1342735143;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 591975007;
						num4 = 591975007;
					}
					else
					{
						num3 = 942973292;
						num4 = 942973292;
					}
					num = num3 ^ ((int)num2 * -2089523314);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1956152313) ^ 0x2E3035E5);
					continue;
				case 0u:
					_currentPlayer = 0;
					flag = _currentTurn > 0;
					num = (int)((num2 * 983896377) ^ 0x4171E99E);
					continue;
				default:
					return;
				case 3u:
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool onlyOneWinner = default(bool);
		PlayerState playerState = default(PlayerState);
		int num11 = default(int);
		int num3 = default(int);
		Card card = default(Card);
		bool flag9 = default(bool);
		int num8 = default(int);
		PlayerState playerState2 = default(PlayerState);
		bool flag8 = default(bool);
		Player player = default(Player);
		bool flag7 = default(bool);
		int num21 = default(int);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		bool flag3 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = -2132720000;
			while (true)
			{
				uint num2;
				int num34;
				switch ((num2 = (uint)num ^ 0x877F8FB0u) % 83u)
				{
				case 82u:
					flag2 = flag;
					num = -495974800;
					continue;
				case 81u:
					num = -1131441656;
					continue;
				case 80u:
				{
					int num6;
					int num7;
					if (!onlyOneWinner)
					{
						num6 = 1633108898;
						num7 = 1633108898;
					}
					else
					{
						num6 = 2064799901;
						num7 = 2064799901;
					}
					num = num6 ^ ((int)num2 * -143365391);
					continue;
				}
				case 79u:
				{
					playerState.Resources -= Game.smethod_3(0, num11 - Players[num3].PlannedForCard(card.Type));
					int num12;
					int num13;
					if (playerState.Resources >= 0)
					{
						num12 = 617369617;
						num13 = 617369617;
					}
					else
					{
						num12 = 1370426194;
						num13 = 1370426194;
					}
					num = num12 ^ ((int)num2 * -606120113);
					continue;
				}
				case 78u:
				{
					int num32;
					int num33;
					if (flag9)
					{
						num32 = -2059389476;
						num33 = -2059389476;
					}
					else
					{
						num32 = -405437211;
						num33 = -405437211;
					}
					num = num32 ^ ((int)num2 * -2084360262);
					continue;
				}
				case 77u:
					num = (int)(num2 * 597686525) ^ -1371647370;
					continue;
				case 75u:
					num = ((int)num2 * -1596457646) ^ 0x12CA0120;
					continue;
				case 74u:
					flag9 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -537657621;
					continue;
				case 73u:
					_finished = true;
					num8 = 0;
					num = (int)(num2 * 64486933) ^ -1843571387;
					continue;
				case 72u:
					num = -1886348752;
					continue;
				case 71u:
					playerState2.Sprint++;
					num = (int)(num2 * 1456772253) ^ -1155764408;
					continue;
				case 70u:
				{
					int num14;
					if (num8 != playerIndex)
					{
						num = -138058037;
						num14 = -138058037;
					}
					else
					{
						num = -2040465837;
						num14 = -2040465837;
					}
					continue;
				}
				case 69u:
					num = ((int)num2 * -1680157225) ^ -1510249211;
					continue;
				case 68u:
				{
					int num35;
					if (num8 < _playerStates.Length)
					{
						num = -1540384538;
						num35 = -1540384538;
					}
					else
					{
						num = -274295083;
						num35 = -274295083;
					}
					continue;
				}
				case 67u:
					num34 = ((card.Type == 4) ? 1 : 0);
					goto IL_01d2;
				case 66u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)(num2 * 987272841) ^ -1166392603;
						continue;
					}
					num34 = 0;
					goto IL_01d2;
				case 65u:
					flag8 = !Losers.Contains(num8);
					num = -1087151852;
					continue;
				case 64u:
					flag = false;
					num = -1564000157;
					continue;
				case 63u:
					num = -836322365;
					continue;
				case 62u:
					Print(playerState2.State);
					num = ((int)num2 * -1584836845) ^ 0x578AB5D2;
					continue;
				case 61u:
					player = Players[playerIndex];
					playerState2 = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 921579887) ^ 0x53B0AA39);
					continue;
				case 60u:
					num = (int)((num2 * 1410621405) ^ 0x56F2103B);
					continue;
				case 59u:
					num = -1632233412;
					continue;
				case 58u:
					num = ((int)num2 * -1368923743) ^ 0x37E62940;
					continue;
				case 57u:
				{
					int num24;
					int num25;
					if (!flag7)
					{
						num24 = 341500983;
						num25 = 341500983;
					}
					else
					{
						num24 = 2020985867;
						num25 = 2020985867;
					}
					num = num24 ^ (int)(num2 * 1225437069);
					continue;
				}
				case 56u:
					num = ((int)num2 * -836375294) ^ 0x77F409B6;
					continue;
				case 55u:
					flag = num21 < Rules.StayOnSprintMinDiff;
					num = (int)((num2 * 2029217839) ^ 0x482229D6);
					continue;
				case 54u:
					Print("Still planning");
					num = ((int)num2 * -1007052542) ^ -366558571;
					continue;
				case 53u:
					Losers.Add(playerIndex);
					num = (int)(num2 * 200147934) ^ -1610643663;
					continue;
				case 52u:
				{
					int num16;
					if (playerState2.Sprint >= 0)
					{
						num = -1262499335;
						num16 = -1262499335;
					}
					else
					{
						num = -1179716035;
						num16 = -1179716035;
					}
					continue;
				}
				case 51u:
					num = (int)((num2 * 484831341) ^ 0x534B0168);
					continue;
				case 50u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag4 ? "ALL " : "", flag6 ? "receives" : "pays", Game.smethod_4(num11), flag ? "advance" : "stay");
					num = -827731552;
					continue;
				case 49u:
				{
					int num30;
					int num31;
					if (!Losers.Contains(playerIndex))
					{
						num30 = -41940312;
						num31 = -41940312;
					}
					else
					{
						num30 = -1257464348;
						num31 = -1257464348;
					}
					num = num30 ^ ((int)num2 * -1391963453);
					continue;
				}
				case 48u:
					card = DrawCard();
					flag6 = card.Impact < 0;
					num = ((int)num2 * -1549706066) ^ 0x456147A7;
					continue;
				case 47u:
					num = ((int)num2 * -1832699685) ^ -450475840;
					continue;
				case 46u:
					num11 = Game.smethod_3(0, num21);
					num = ((int)num2 * -1144187) ^ 0x79155169;
					continue;
				case 45u:
				{
					int num28;
					int num29;
					if (!flag3)
					{
						num28 = -774453888;
						num29 = -774453888;
					}
					else
					{
						num28 = -1614765211;
						num29 = -1614765211;
					}
					num = num28 ^ ((int)num2 * -183730068);
					continue;
				}
				case 44u:
					num = -202553487;
					continue;
				case 43u:
					playerState2.State = State.Lose;
					num = ((int)num2 * -193364771) ^ -1845107511;
					continue;
				case 42u:
					playerState2.Sprint++;
					num = (int)((num2 * 766142211) ^ 0x77639E7B);
					continue;
				case 41u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -1297020691) ^ -738982940;
					continue;
				case 40u:
					num = ((int)num2 * -1574246142) ^ 0x29D9539E;
					continue;
				case 39u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -1374577674;
					continue;
				}
				case 38u:
					num = ((int)num2 * -1787497381) ^ -2081687431;
					continue;
				case 37u:
					num21 = card.Impact - player.PlannedForCard(card.Type);
					num = ((int)num2 * -1040190040) ^ -1157539009;
					continue;
				case 36u:
					num = (int)(num2 * 130433200) ^ -1232380016;
					continue;
				case 35u:
					num = ((int)num2 * -1516825675) ^ 0x4CD3F288;
					continue;
				case 34u:
				{
					int num26;
					int num27;
					if (playerState2.State == State.Playing)
					{
						num26 = -136570727;
						num27 = -136570727;
					}
					else
					{
						num26 = -257619838;
						num27 = -257619838;
					}
					num = num26 ^ ((int)num2 * -1209204955);
					continue;
				}
				case 33u:
					num3++;
					num = -1633873455;
					continue;
				case 32u:
					Losers.Add(num3);
					num = (int)(num2 * 270159248) ^ -222942136;
					continue;
				case 31u:
					num = (int)(num2 * 794586037) ^ -1926326633;
					continue;
				case 30u:
					num = -768864845;
					continue;
				case 29u:
					playerState2.Resources -= num11;
					num = ((int)num2 * -1297868677) ^ -1900495316;
					continue;
				case 28u:
				{
					int num22;
					int num23;
					if (!flag8)
					{
						num22 = 967691394;
						num23 = 967691394;
					}
					else
					{
						num22 = 1593448969;
						num23 = 1593448969;
					}
					num = num22 ^ (int)(num2 * 1866568252);
					continue;
				}
				case 27u:
					num = ((int)num2 * -719170774) ^ -996942812;
					continue;
				case 26u:
					num = ((int)num2 * -860143755) ^ -438225569;
					continue;
				case 25u:
				{
					int num19;
					int num20;
					if (flag5)
					{
						num19 = 1336900084;
						num20 = 1336900084;
					}
					else
					{
						num19 = 2010341339;
						num20 = 2010341339;
					}
					num = num19 ^ ((int)num2 * -747198882);
					continue;
				}
				case 24u:
				{
					int num17;
					int num18;
					if (playerState2.Resources < 0)
					{
						num17 = 1430634009;
						num18 = 1430634009;
					}
					else
					{
						num17 = 338935231;
						num18 = 338935231;
					}
					num = num17 ^ ((int)num2 * -1469778892);
					continue;
				}
				case 23u:
					flag7 = !flag6;
					num = (int)((num2 * 464008758) ^ 0x360915C0);
					continue;
				case 22u:
					flag = true;
					num11 = card.Impact;
					num = ((int)num2 * -653042787) ^ -1973106398;
					continue;
				case 21u:
					playerState.State = State.Lose;
					num = -752010592;
					continue;
				case 19u:
				{
					int num15;
					if (num3 < _playerStates.Length)
					{
						num = -1204360001;
						num15 = -1204360001;
					}
					else
					{
						num = -1566791981;
						num15 = -1566791981;
					}
					continue;
				}
				case 18u:
					num = ((int)num2 * -1149586708) ^ -1426415836;
					continue;
				case 17u:
					num8++;
					num = -439715370;
					continue;
				case 16u:
					playerState2.State = State.Won;
					Winners.Add(playerIndex);
					num = (int)((num2 * 1317972774) ^ 0x12ED4F28);
					continue;
				case 15u:
					num3 = 0;
					num = (int)((num2 * 1291047008) ^ 0x5CBE9FE2);
					continue;
				case 14u:
					playerState = _playerStates[num3];
					num = ((int)num2 * -1617355038) ^ -405249080;
					continue;
				case 13u:
					num = (int)(num2 * 630713878) ^ -1158130958;
					continue;
				case 12u:
					num = -521561880;
					continue;
				case 11u:
					flag5 = !flag4;
					num = (int)((num2 * 1962199887) ^ 0x452D4D74);
					continue;
				case 10u:
					flag3 = playerState2.Sprint > Rules.SprintCount;
					num = -32755404;
					continue;
				case 9u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -850598233;
						num10 = -850598233;
					}
					else
					{
						num9 = -136298421;
						num10 = -136298421;
					}
					num = num9 ^ (int)(num2 * 1621117959);
					continue;
				}
				case 8u:
					num = ((int)num2 * -62213383) ^ -1350972883;
					continue;
				case 7u:
					flag = true;
					num = (int)(num2 * 1918525657) ^ -825556318;
					continue;
				case 6u:
					Print("CARD: none, advance");
					num = ((int)num2 * -1712000886) ^ 0x3186423C;
					continue;
				case 5u:
					Losers.Add(num8);
					num = (int)(num2 * 1422502034) ^ -729843731;
					continue;
				case 4u:
					num = ((int)num2 * -296231710) ^ -959029311;
					continue;
				case 3u:
					num = -1593652669;
					continue;
				case 2u:
					num = (int)((num2 * 1901843364) ^ 0xC860B83);
					continue;
				case 1u:
					num = -1568305073;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (Losers.Contains(num3))
					{
						num4 = -693974696;
						num5 = -693974696;
					}
					else
					{
						num4 = -925242550;
						num5 = -925242550;
					}
					num = num4 ^ (int)(num2 * 1928097659);
					continue;
				}
				default:
					return;
				case 76u:
					break;
				case 20u:
					return;
					IL_01d2:
					flag4 = (byte)num34 != 0;
					num = -1374480211;
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
			int num = 1329979269;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x103AA749u) % 8u)
				{
				case 7u:
					_deck.RemoveAt(0);
					num = ((int)num2 * -905820150) ^ -1488046825;
					continue;
				case 4u:
					flag = _deck.Count <= 0;
					num = (int)(num2 * 1896765859) ^ -1425470724;
					continue;
				case 3u:
					card = _deck[0];
					num = 1968419630;
					continue;
				case 2u:
					ShuffleCards();
					num = ((int)num2 * -1842215330) ^ 0x7AF40C36;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1921810702;
						num4 = -1921810702;
					}
					else
					{
						num3 = -1769118837;
						num4 = -1769118837;
					}
					num = num3 ^ (int)(num2 * 2024355841);
					continue;
				}
				case 0u:
					result = card;
					num = ((int)num2 * -1821983343) ^ 0x2EA0BC1C;
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
		string text = "";
		int num = 0;
		string result = default(string);
		while (true)
		{
			int num2 = 601459456;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x4345DD1u) % 8u)
				{
				case 7u:
					num2 = (int)((num3 * 829646462) ^ 0x6CA6C871);
					continue;
				case 6u:
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
					num2 = 1523666873;
					continue;
				}
				case 4u:
				{
					int num4;
					if (num >= _playerStates.Length)
					{
						num2 = 1492957722;
						num4 = 1492957722;
					}
					else
					{
						num2 = 1894975495;
						num4 = 1894975495;
					}
					continue;
				}
				case 3u:
					result = text;
					num2 = (int)(num3 * 1316139255) ^ -1047467141;
					continue;
				case 1u:
					num2 = ((int)num3 * -1023317458) ^ -1513834477;
					continue;
				case 0u:
					num++;
					num2 = ((int)num3 * -788019023) ^ -270638475;
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

	public override string ToString()
	{
		return ToString(initial: false);
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
