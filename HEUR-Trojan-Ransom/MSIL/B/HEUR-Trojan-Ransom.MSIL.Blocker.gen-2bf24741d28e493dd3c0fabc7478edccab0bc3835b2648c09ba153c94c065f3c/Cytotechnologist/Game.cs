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
			bool result = default(bool);
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = 1571831518;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3C71859u) % 13u)
					{
					case 12u:
						result = false;
						num = ((int)num2 * -1278103405) ^ -737880792;
						continue;
					case 11u:
						result = true;
						num = ((int)num2 * -34733802) ^ -1344110342;
						continue;
					case 8u:
						playerStates = _playerStates;
						num3 = 0;
						num = ((int)num2 * -1524986511) ^ -1355748861;
						continue;
					case 7u:
					{
						int num6;
						if (num3 >= playerStates.Length)
						{
							num = 721821402;
							num6 = 721821402;
						}
						else
						{
							num = 1427221534;
							num6 = 1427221534;
						}
						continue;
					}
					case 6u:
						num3++;
						num = 1420891733;
						continue;
					case 5u:
					{
						int num7;
						int num8;
						if (!_finished)
						{
							num7 = -340693260;
							num8 = -340693260;
						}
						else
						{
							num7 = -1073379317;
							num8 = -1073379317;
						}
						num = num7 ^ (int)(num2 * 151704285);
						continue;
					}
					case 4u:
						result = true;
						num = (int)(num2 * 1771062977) ^ -111591795;
						continue;
					case 3u:
						num = (int)(num2 * 1956196953) ^ -667579091;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (playerState.State != 0)
						{
							num4 = 1207830391;
							num5 = 1207830391;
						}
						else
						{
							num4 = 1864917069;
							num5 = 1864917069;
						}
						num = num4 ^ ((int)num2 * -1738722240);
						continue;
					}
					case 1u:
						playerState = playerStates[num3];
						num = 1211747568;
						continue;
					case 0u:
						num = 677271279;
						continue;
					case 9u:
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
		bool flag = default(bool);
		int num3 = default(int);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num4 = default(int);
		while (true)
		{
			int num = -633691773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5BFAEC9u) % 17u)
				{
				case 16u:
					num = ((int)num2 * -1505105002) ^ 0x40B1F7BA;
					continue;
				case 15u:
					num = (int)(num2 * 1121079458) ^ -461599737;
					continue;
				case 13u:
					flag = num3 < count;
					num = -1944246854;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 403451799;
						num7 = 403451799;
					}
					else
					{
						num6 = 491891685;
						num7 = 491891685;
					}
					num = num6 ^ ((int)num2 * -1879378269);
					continue;
				}
				case 11u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = -548156226;
					continue;
				case 10u:
					_dice = new Dice();
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = (int)(num2 * 1901041651) ^ -1352159035;
					continue;
				case 9u:
					num4++;
					num = (int)(num2 * 992161460) ^ -982478979;
					continue;
				case 8u:
					num4 = 0;
					num = ((int)num2 * -2020658064) ^ -680088058;
					continue;
				case 7u:
					_playerStates[num4] = new PlayerState();
					num = -1400827284;
					continue;
				case 6u:
				{
					int num5;
					if (num4 < count)
					{
						num = -296271151;
						num5 = -296271151;
					}
					else
					{
						num = -362085522;
						num5 = -362085522;
					}
					continue;
				}
				case 5u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -83405226) ^ -1915446969;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -1940154676) ^ -1916648972;
					continue;
				case 2u:
					num = (int)((num2 * 1209173176) ^ 0x1A59DC98);
					continue;
				case 1u:
					_buffer = buffer;
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = (int)((num2 * 1926657673) ^ 0x57ECAC05);
					continue;
				case 0u:
					Players = new Player[count];
					num3 = 0;
					num = (int)((num2 * 78813223) ^ 0x63876443);
					continue;
				default:
					return;
				case 14u:
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
		ShuffleCards();
		while (true)
		{
			int num = 1878105088;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A74533Du) % 7u)
				{
				case 5u:
					num = ((int)num2 * -1143500454) ^ -712275173;
					continue;
				case 3u:
					Losers.Clear();
					num = ((int)num2 * -1360139227) ^ -730981670;
					continue;
				case 2u:
					num = ((int)num2 * -672630817) ^ 0x7389A516;
					continue;
				case 1u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					_finished = false;
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -1464238927) ^ -1948420153;
					continue;
				case 0u:
					Winners.Clear();
					num = (int)(num2 * 1584092177) ^ -1781413351;
					continue;
				default:
					return;
				case 4u:
					break;
				case 6u:
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
		bool flag = default(bool);
		Player player = default(Player);
		bool flag2 = default(bool);
		int planningCardsCount = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = 1242269356;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x263619BDu) % 30u)
				{
				case 28u:
					playerState.Resources = Rules.InitialResources;
					num2 = (int)(num3 * 1961618954) ^ -444425945;
					continue;
				case 27u:
					num2 = (int)(num3 * 1397579835) ^ -2015883818;
					continue;
				case 26u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = -1787682430;
						num11 = -1787682430;
					}
					else
					{
						num10 = -1989063607;
						num11 = -1989063607;
					}
					num2 = num10 ^ (int)(num3 * 626158286);
					continue;
				}
				case 25u:
					playerState.Sprint = -1;
					num2 = ((int)num3 * -790181957) ^ 0x2C0457D2;
					continue;
				case 24u:
				{
					int num6;
					int num7;
					if (player.UseOneMorePlanningSprint)
					{
						num6 = 657513664;
						num7 = 657513664;
					}
					else
					{
						num6 = 1758239505;
						num7 = 1758239505;
					}
					num2 = num6 ^ (int)(num3 * 593297521);
					continue;
				}
				case 23u:
					flag2 = planningCardsCount == 0;
					num2 = (int)(num3 * 999761785) ^ -645408539;
					continue;
				case 22u:
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = (int)(num3 * 2107197102) ^ -1632428741;
					continue;
				case 21u:
					num2 = (int)(num3 * 645057642) ^ -1973737774;
					continue;
				case 20u:
					num++;
					num2 = ((int)num3 * -1687267928) ^ -854991060;
					continue;
				case 19u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -1203587110;
						num9 = -1203587110;
					}
					else
					{
						num8 = -556608159;
						num9 = -556608159;
					}
					num2 = num8 ^ (int)(num3 * 1764966425);
					continue;
				}
				case 18u:
				{
					int num5;
					if (num4 <= 0)
					{
						num2 = 1229352046;
						num5 = 1229352046;
					}
					else
					{
						num2 = 276420521;
						num5 = 276420521;
					}
					continue;
				}
				case 17u:
					num2 = 2128129327;
					continue;
				case 16u:
					player = Players[num];
					num2 = 1010926143;
					continue;
				case 15u:
					num2 = (int)((num3 * 1278187914) ^ 0xBDDF6E6);
					continue;
				case 14u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num2 = ((int)num3 * -1036051829) ^ 0x645254CE;
					continue;
				case 13u:
					num2 = (int)(num3 * 1984460096) ^ -807489015;
					continue;
				case 12u:
					playerState.Sprint = 1;
					num2 = (int)((num3 * 440905885) ^ 0x5E3CD4EA);
					continue;
				case 11u:
					num4 = 0;
					num2 = 1578882249;
					continue;
				case 10u:
					playerState = _playerStates[num];
					playerState.Sprint = 0;
					num2 = (int)((num3 * 1401364522) ^ 0x3A8BFE19);
					continue;
				case 9u:
					flag = num < Players.Length;
					num2 = 738832823;
					continue;
				case 8u:
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num2 = (int)((num3 * 1752088690) ^ 0x3E4846F4);
					continue;
				case 7u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = (int)(num3 * 1008672785) ^ -165478130;
					continue;
				case 6u:
					num2 = 602263721;
					continue;
				case 5u:
					num2 = (int)((num3 * 453384859) ^ 0x6B172F56);
					continue;
				case 4u:
					playerState.State = State.Playing;
					num2 = ((int)num3 * -1003560021) ^ -558087776;
					continue;
				case 2u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num2 = 88942961;
					continue;
				case 1u:
					num2 = (int)((num3 * 103494536) ^ 0x1A8F8AA);
					continue;
				case 0u:
					num4 = 0;
					num2 = (int)(num3 * 799851680) ^ -683664032;
					continue;
				default:
					return;
				case 29u:
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
		_currentPlayer++;
		while (true)
		{
			int num = -324520552;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5F382EFu) % 10u)
				{
				case 9u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = -1495304585;
					continue;
				case 8u:
					num = ((int)num2 * -1589622544) ^ -318984019;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (_currentPlayer < Players.Length)
					{
						num5 = 198378620;
						num6 = 198378620;
					}
					else
					{
						num5 = 494559763;
						num6 = 494559763;
					}
					num = num5 ^ ((int)num2 * -376571098);
					continue;
				}
				case 6u:
					num = (int)(num2 * 379012649) ^ -1170368108;
					continue;
				case 4u:
					num = (int)(num2 * 98413165) ^ -1542195090;
					continue;
				case 3u:
					PlayerTurn(_currentPlayer);
					num = -1304911309;
					continue;
				case 1u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)(num2 * 407074446) ^ -1415021055;
					continue;
				case 0u:
				{
					_currentPlayer = 0;
					int num3;
					int num4;
					if (_currentTurn > 0)
					{
						num3 = -657720922;
						num4 = -657720922;
					}
					else
					{
						num3 = -165486304;
						num4 = -165486304;
					}
					num = num3 ^ (int)(num2 * 441702942);
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		bool flag5 = default(bool);
		int num3 = default(int);
		Card card = default(Card);
		bool flag14 = default(bool);
		bool flag10 = default(bool);
		int num10 = default(int);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		Player player = default(Player);
		bool flag12 = default(bool);
		int num13 = default(int);
		bool flag9 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag13 = default(bool);
		PlayerState playerState3 = default(PlayerState);
		bool flag8 = default(bool);
		bool flag11 = default(bool);
		bool flag7 = default(bool);
		bool onlyOneWinner = default(bool);
		while (true)
		{
			int num = 505549851;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x6B3357F4u) % 86u)
				{
				case 85u:
					num = ((int)num2 * -1503232340) ^ 0x5AB9369D;
					continue;
				case 84u:
					flag5 = num3 < _playerStates.Length;
					num = 1570617931;
					continue;
				case 83u:
					num = 2121338150;
					continue;
				case 82u:
					num5 = ((card.Type == 4) ? 1 : 0);
					goto IL_0045;
				case 81u:
					num = 270338834;
					continue;
				case 80u:
					num = ((int)num2 * -1658590472) ^ 0x1B3DBF07;
					continue;
				case 79u:
					num = (int)((num2 * 1571038630) ^ 0x6F53DD79);
					continue;
				case 78u:
				{
					int num35;
					int num36;
					if (flag14)
					{
						num35 = 2080696104;
						num36 = 2080696104;
					}
					else
					{
						num35 = 1934335709;
						num36 = 1934335709;
					}
					num = num35 ^ ((int)num2 * -978938967);
					continue;
				}
				case 77u:
				{
					int num25;
					int num26;
					if (!flag10)
					{
						num25 = 1894615844;
						num26 = 1894615844;
					}
					else
					{
						num25 = 1174559672;
						num26 = 1174559672;
					}
					num = num25 ^ ((int)num2 * -870930472);
					continue;
				}
				case 76u:
					num = 1718017500;
					continue;
				case 75u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1672743937) ^ -1242636236;
					continue;
				case 74u:
					num = 979458029;
					continue;
				case 73u:
					Losers.Add(num10);
					num = ((int)num2 * -1611924746) ^ -803838346;
					continue;
				case 72u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = -363624527;
						num9 = -363624527;
					}
					else
					{
						num8 = -1391904233;
						num9 = -1391904233;
					}
					num = num8 ^ ((int)num2 * -873071874);
					continue;
				}
				case 71u:
				{
					int num4;
					if (!Losers.Contains(num3))
					{
						num = 170535676;
						num4 = 170535676;
					}
					else
					{
						num = 1064810199;
						num4 = 1064810199;
					}
					continue;
				}
				case 70u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -33039910) ^ 0x923EA3F;
					continue;
				case 69u:
				{
					int num32;
					int num33;
					if (flag6)
					{
						num32 = 1301865987;
						num33 = 1301865987;
					}
					else
					{
						num32 = 387205925;
						num33 = 387205925;
					}
					num = num32 ^ ((int)num2 * -444521346);
					continue;
				}
				case 68u:
				{
					int num31 = card.Impact - player.PlannedForCard(card.Type);
					flag12 = num31 < Rules.StayOnSprintMinDiff;
					num13 = Game.smethod_3(0, num31);
					num = ((int)num2 * -953225868) ^ -1458175517;
					continue;
				}
				case 67u:
				{
					int num27;
					int num28;
					if (flag5)
					{
						num27 = -1476362939;
						num28 = -1476362939;
					}
					else
					{
						num27 = -1374660038;
						num28 = -1374660038;
					}
					num = num27 ^ ((int)num2 * -1662338664);
					continue;
				}
				case 66u:
					flag12 = true;
					num = ((int)num2 * -135706263) ^ 0x4B3B0BFB;
					continue;
				case 65u:
					num = (int)((num2 * 1381194545) ^ 0x41552713);
					continue;
				case 64u:
					num = (int)(num2 * 549342830) ^ -979606532;
					continue;
				case 63u:
					num3++;
					num = 1398765720;
					continue;
				case 62u:
					flag9 = playerState.Resources < 0;
					num = (int)(num2 * 569778627) ^ -846596356;
					continue;
				case 61u:
					_finished = true;
					num3 = 0;
					num = (int)(num2 * 425390142) ^ -1271005015;
					continue;
				case 60u:
					playerState.State = State.Lose;
					num = (int)(num2 * 959275106) ^ -1071610166;
					continue;
				case 59u:
					flag12 = false;
					num = 374984039;
					continue;
				case 58u:
				{
					int num16;
					int num17;
					if (flag3)
					{
						num16 = -350045914;
						num17 = -350045914;
					}
					else
					{
						num16 = -715998643;
						num17 = -715998643;
					}
					num = num16 ^ ((int)num2 * -397154097);
					continue;
				}
				case 57u:
					num = (int)((num2 * 943765962) ^ 0x37C5650F);
					continue;
				case 56u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num13), flag12 ? "advance" : "stay");
					flag14 = !flag;
					num = 1158020300;
					continue;
				case 54u:
				{
					int num34;
					if (num10 < _playerStates.Length)
					{
						num = 2043337095;
						num34 = 2043337095;
					}
					else
					{
						num = 560915564;
						num34 = 560915564;
					}
					continue;
				}
				case 53u:
					num = (int)(num2 * 707840012) ^ -163663334;
					continue;
				case 52u:
					playerState.Resources -= num13;
					num = (int)(num2 * 1211012830) ^ -1756509562;
					continue;
				case 51u:
				{
					int num29;
					int num30;
					if (playerState.State != 0)
					{
						num29 = 1340571469;
						num30 = 1340571469;
					}
					else
					{
						num29 = 1285792018;
						num30 = 1285792018;
					}
					num = num29 ^ ((int)num2 * -1428645796);
					continue;
				}
				case 50u:
					num = (int)(num2 * 390273440) ^ -1276312478;
					continue;
				case 49u:
					card = DrawCard();
					flag2 = card.Impact < 0;
					num = ((int)num2 * -1280772634) ^ 0x63C3D0CE;
					continue;
				case 48u:
					num = 1691882024;
					continue;
				case 47u:
				{
					int num23;
					int num24;
					if (!flag13)
					{
						num23 = -1175927747;
						num24 = -1175927747;
					}
					else
					{
						num23 = -371599357;
						num24 = -371599357;
					}
					num = num23 ^ (int)(num2 * 2090273264);
					continue;
				}
				case 46u:
				{
					int num22;
					if (!_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = 1328617916;
						num22 = 1328617916;
					}
					else
					{
						num = 1984211896;
						num22 = 1984211896;
					}
					continue;
				}
				case 45u:
					num = 615787209;
					continue;
				case 44u:
					playerState3.State = State.Lose;
					num = 226161718;
					continue;
				case 43u:
					flag4 = flag12;
					num = 19543834;
					continue;
				case 42u:
					num = ((int)num2 * -1512081271) ^ 0x566E92BA;
					continue;
				case 41u:
					num = (int)(num2 * 42405853) ^ -1554896345;
					continue;
				case 40u:
					flag12 = true;
					num13 = card.Impact;
					num = (int)((num2 * 1772254095) ^ 0x334DAD69);
					continue;
				case 39u:
				{
					int num20;
					int num21;
					if (!flag8)
					{
						num20 = 1633838275;
						num21 = 1633838275;
					}
					else
					{
						num20 = 1538773181;
						num21 = 1538773181;
					}
					num = num20 ^ ((int)num2 * -976867633);
					continue;
				}
				case 38u:
					num = (int)(num2 * 851069591) ^ -903156461;
					continue;
				case 37u:
					num = (int)(num2 * 1982981688) ^ -2123837174;
					continue;
				case 36u:
					flag13 = !Losers.Contains(playerIndex);
					num = (int)(num2 * 1731660603) ^ -1588638971;
					continue;
				case 35u:
					num = 857379928;
					continue;
				case 34u:
					num = 1783718455;
					continue;
				case 33u:
					Print("CARD: none, advance");
					num = ((int)num2 * -1750866034) ^ -236311447;
					continue;
				case 32u:
					flag11 = !Losers.Contains(num10);
					num = ((int)num2 * -727581681) ^ 0x3DD3ADF2;
					continue;
				case 31u:
				{
					int num18;
					int num19;
					if (!flag7)
					{
						num18 = 1433653991;
						num19 = 1433653991;
					}
					else
					{
						num18 = 312902944;
						num19 = 312902944;
					}
					num = num18 ^ ((int)num2 * -377487489);
					continue;
				}
				case 30u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)(num2 * 1010242117) ^ -1071508806;
						continue;
					}
					num5 = 0;
					goto IL_0045;
				case 29u:
					num = ((int)num2 * -758997453) ^ 0x6F84E23E;
					continue;
				case 28u:
					Losers.Add(num3);
					num = ((int)num2 * -1615743698) ^ -571168345;
					continue;
				case 26u:
					num = ((int)num2 * -908017476) ^ 0x4B17BB6C;
					continue;
				case 25u:
					num = ((int)num2 * -1246006534) ^ 0x15308B7A;
					continue;
				case 24u:
				{
					int num14;
					int num15;
					if (!flag11)
					{
						num14 = -869807853;
						num15 = -869807853;
					}
					else
					{
						num14 = -1482413341;
						num15 = -1482413341;
					}
					num = num14 ^ (int)(num2 * 1342461089);
					continue;
				}
				case 23u:
					num = 1675945402;
					continue;
				case 22u:
					Print("Still planning");
					num = (int)((num2 * 86275761) ^ 0x2FDFA004);
					continue;
				case 21u:
					flag10 = playerState.Sprint > Rules.SprintCount;
					num = 2094146457;
					continue;
				case 20u:
					playerState3 = _playerStates[num10];
					playerState3.Resources -= Game.smethod_3(0, num13 - Players[num10].PlannedForCard(card.Type));
					num = ((int)num2 * -1390422909) ^ 0x10484015;
					continue;
				case 19u:
					Print(playerState.State);
					num = ((int)num2 * -790160082) ^ 0x1E78B62B;
					continue;
				case 18u:
				{
					int num11;
					int num12;
					if (!flag9)
					{
						num11 = -276934090;
						num12 = -276934090;
					}
					else
					{
						num11 = -1692210049;
						num12 = -1692210049;
					}
					num = num11 ^ (int)(num2 * 244973470);
					continue;
				}
				case 17u:
					num = (int)(num2 * 1321566749) ^ -1453793303;
					continue;
				case 16u:
					num10 = 0;
					num = ((int)num2 * -275529507) ^ 0x73C3FBCD;
					continue;
				case 15u:
					playerState.Sprint++;
					num = ((int)num2 * -1513818042) ^ 0x8D4E3FF;
					continue;
				case 14u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = (int)((num2 * 1168030703) ^ 0x5C9A6C76);
					continue;
				case 13u:
					num = (int)((num2 * 1340649792) ^ 0x2FF06906);
					continue;
				case 12u:
					flag8 = playerState.Sprint < 0;
					num = 991367359;
					continue;
				case 11u:
					player = Players[playerIndex];
					playerState = _playerStates[playerIndex];
					num = (int)(num2 * 175140923) ^ -3863223;
					continue;
				case 10u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)(num2 * 2001565960) ^ -1977593933;
					continue;
				case 9u:
					flag7 = playerState3.Resources >= 0;
					num = ((int)num2 * -1613297974) ^ -996663373;
					continue;
				case 8u:
					num = ((int)num2 * -1624364728) ^ -923411971;
					continue;
				case 7u:
					num = 1504580185;
					continue;
				case 6u:
					num = (int)((num2 * 137426706) ^ 0x45E74657);
					continue;
				case 5u:
					num10++;
					num = 372556600;
					continue;
				case 4u:
					num = ((int)num2 * -1609194223) ^ 0x3254F51E;
					continue;
				case 3u:
					playerState.Sprint++;
					num = ((int)num2 * -801102111) ^ 0x553D596B;
					continue;
				case 2u:
					flag6 = num3 == playerIndex;
					num = (int)((num2 * 696327819) ^ 0x625B117D);
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (!onlyOneWinner)
					{
						num6 = -592413557;
						num7 = -592413557;
					}
					else
					{
						num6 = -1964936732;
						num7 = -1964936732;
					}
					num = num6 ^ ((int)num2 * -1551326487);
					continue;
				}
				case 0u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = 2002773167;
					continue;
				}
				default:
					return;
				case 55u:
					break;
				case 27u:
					return;
					IL_0045:
					flag = (byte)num5 != 0;
					flag3 = !flag2;
					num = 73152908;
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
			int num = 1679875759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D6C8D58u) % 8u)
				{
				case 7u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -773747140) ^ -1110734227;
					continue;
				case 6u:
					num = ((int)num2 * -1739094907) ^ -1964262085;
					continue;
				case 4u:
					ShuffleCards();
					num = ((int)num2 * -1448852420) ^ 0x32997A73;
					continue;
				case 3u:
					card = _deck[0];
					num = 834688482;
					continue;
				case 2u:
					_deck.RemoveAt(0);
					result = card;
					num = ((int)num2 * -1875015556) ^ -482845338;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1711447897;
						num4 = -1711447897;
					}
					else
					{
						num3 = -1728904064;
						num4 = -1728904064;
					}
					num = num3 ^ (int)(num2 * 2007521523);
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
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = 1095188770;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44A0A953u) % 8u)
				{
				case 7u:
					num3 = 0;
					num = (int)(num2 * 431585064) ^ -1191201903;
					continue;
				case 5u:
					result = text;
					num = (int)(num2 * 1308575970) ^ -1915489273;
					continue;
				case 3u:
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
					num = 1098494699;
					continue;
				}
				case 2u:
					num = (int)((num2 * 399751561) ^ 0x585AB181);
					continue;
				case 1u:
					text = "";
					num = ((int)num2 * -357172915) ^ -1463147039;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < _playerStates.Length)
					{
						num = 184987080;
						num4 = 184987080;
					}
					else
					{
						num = 943824014;
						num4 = 943824014;
					}
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
