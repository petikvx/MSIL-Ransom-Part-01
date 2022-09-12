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
			PlayerState playerState = default(PlayerState);
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			while (true)
			{
				int num = -914958968;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA95810F5u) % 14u)
					{
					case 13u:
						result = true;
						num = ((int)num2 * -527674245) ^ -892150785;
						continue;
					case 12u:
						num = (int)(num2 * 307002086) ^ -438865836;
						continue;
					case 10u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 1864254118;
							num6 = 1864254118;
						}
						else
						{
							num5 = 1233666564;
							num6 = 1233666564;
						}
						num = num5 ^ ((int)num2 * -1527127532);
						continue;
					}
					case 9u:
					{
						int num7;
						int num8;
						if (finished)
						{
							num7 = -1004526884;
							num8 = -1004526884;
						}
						else
						{
							num7 = -1478502142;
							num8 = -1478502142;
						}
						num = num7 ^ (int)(num2 * 1619246665);
						continue;
					}
					case 8u:
						result = true;
						num = (int)(num2 * 1143230866) ^ -879772093;
						continue;
					case 7u:
						result = false;
						num = (int)((num2 * 2021348621) ^ 0x6BC31717);
						continue;
					case 5u:
						playerState = playerStates[num3];
						num = -2029768054;
						continue;
					case 4u:
						num = -406732869;
						continue;
					case 3u:
						flag = playerState.State == State.Playing;
						num = ((int)num2 * -403884924) ^ -1415429455;
						continue;
					case 2u:
					{
						int num4;
						if (num3 >= playerStates.Length)
						{
							num = -2136255688;
							num4 = -2136255688;
						}
						else
						{
							num = -1642826690;
							num4 = -1642826690;
						}
						continue;
					}
					case 1u:
						num3++;
						num = -1614257529;
						continue;
					case 0u:
						playerStates = _playerStates;
						num3 = 0;
						num = (int)((num2 * 2091522997) ^ 0x663A4EA1);
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
			int num = -871159546;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x961C5DAFu) % 10u)
				{
				case 8u:
					_currentPlayer = Players.Length;
					num = (int)(num2 * 519284998) ^ -85249829;
					continue;
				case 7u:
					num = ((int)num2 * -2073540805) ^ 0x6ED0A4B7;
					continue;
				case 6u:
					_currentTurn = 0;
					num = ((int)num2 * -458792265) ^ 0x2CFEBF77;
					continue;
				case 5u:
					ShuffleCards();
					num = (int)(num2 * 1364234139) ^ -1639653170;
					continue;
				case 4u:
					_finished = false;
					num = ((int)num2 * -21548599) ^ 0x186616DE;
					continue;
				case 2u:
					Winners.Clear();
					num = ((int)num2 * -643159850) ^ 0xB7A9F14;
					continue;
				case 1u:
					Losers.Clear();
					num = (int)(num2 * 581694426) ^ -1433912347;
					continue;
				case 0u:
					num = ((int)num2 * -316161749) ^ -1739086215;
					continue;
				case 3u:
					break;
				default:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
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
		Player player = default(Player);
		PlayerState playerState = default(PlayerState);
		int num4 = default(int);
		bool flag3 = default(bool);
		int planningCardsCount = default(int);
		bool flag = default(bool);
		bool useOneMorePlanningSprint = default(bool);
		while (true)
		{
			int num2 = 1421138271;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x31814D4Fu) % 28u)
				{
				case 27u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -2091411362;
						num12 = -2091411362;
					}
					else
					{
						num11 = -1498412854;
						num12 = -1498412854;
					}
					num2 = num11 ^ ((int)num3 * -1209757889);
					continue;
				}
				case 26u:
					num++;
					num2 = (int)(num3 * 1586067021) ^ -102955356;
					continue;
				case 25u:
					player = Players[num];
					playerState = _playerStates[num];
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num2 = (int)(num3 * 1438564438) ^ -905946272;
					continue;
				case 24u:
					num2 = ((int)num3 * -1618611851) ^ -964497906;
					continue;
				case 23u:
					num4 = 0;
					num2 = (int)(num3 * 1429867932) ^ -327022390;
					continue;
				case 21u:
					flag3 = num < Players.Length;
					num2 = 780760584;
					continue;
				case 20u:
					num4 = 0;
					num2 = 1507037657;
					continue;
				case 18u:
					num2 = ((int)num3 * -154214200) ^ -374435018;
					continue;
				case 17u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = (int)(num3 * 1155476372) ^ -728438748;
					continue;
				case 16u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -1012986735;
						num10 = -1012986735;
					}
					else
					{
						num9 = -465341325;
						num10 = -465341325;
					}
					num2 = num9 ^ ((int)num3 * -1922075271);
					continue;
				}
				case 15u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num2 = 1800378390;
					continue;
				case 14u:
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num2 = (int)((num3 * 1035849192) ^ 0xAE66009);
					continue;
				case 13u:
					playerState.Sprint = -1;
					num2 = (int)(num3 * 207157152) ^ -90089427;
					continue;
				case 12u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -896899556) ^ 0x753D03F;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 825986036;
						num8 = 825986036;
					}
					else
					{
						num7 = 1910480469;
						num8 = 1910480469;
					}
					num2 = num7 ^ (int)(num3 * 673305292);
					continue;
				}
				case 10u:
					num2 = 1889817072;
					continue;
				case 9u:
					flag2 = planningCardsCount == 0;
					num2 = (int)((num3 * 2078428166) ^ 0x7AD59E7E);
					continue;
				case 8u:
					num2 = (int)(num3 * 762728975) ^ -1491523136;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!useOneMorePlanningSprint)
					{
						num5 = -1850293607;
						num6 = -1850293607;
					}
					else
					{
						num5 = -1516002938;
						num6 = -1516002938;
					}
					num2 = num5 ^ (int)(num3 * 767216585);
					continue;
				}
				case 6u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num2 = (int)(num3 * 818449291) ^ -1169234671;
					continue;
				case 5u:
					flag = num4 > 0;
					num2 = 1588549843;
					continue;
				case 4u:
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = 1333400661;
					continue;
				case 3u:
					num2 = 559671838;
					continue;
				case 2u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num2 = ((int)num3 * -1211522010) ^ 0x5CBBA50C;
					continue;
				case 1u:
					num2 = (int)((num3 * 439510359) ^ 0x65BEA792);
					continue;
				case 0u:
					num2 = ((int)num3 * -187047468) ^ -578084871;
					continue;
				default:
					return;
				case 19u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1182380404;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBC09B2Au) % 11u)
				{
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 1057670697) ^ 0x475B8441);
					continue;
				case 8u:
				{
					_currentPlayer++;
					int num5;
					int num6;
					if (_currentPlayer < Players.Length)
					{
						num5 = 460794437;
						num6 = 460794437;
					}
					else
					{
						num5 = 1911535162;
						num6 = 1911535162;
					}
					num = num5 ^ ((int)num2 * -1351778945);
					continue;
				}
				case 7u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1853505551) ^ -1163992622;
					continue;
				case 6u:
					_currentPlayer = 0;
					num = ((int)num2 * -437880559) ^ -83126275;
					continue;
				case 5u:
					PlayerTurn(_currentPlayer);
					num = -2136207846;
					continue;
				case 4u:
					flag = _currentTurn > 0;
					num = ((int)num2 * -52736030) ^ 0x4954805F;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 722745897;
						num4 = 722745897;
					}
					else
					{
						num3 = 624273745;
						num4 = 624273745;
					}
					num = num3 ^ ((int)num2 * -1300352291);
					continue;
				}
				case 2u:
					num = ((int)num2 * -129418219) ^ -385694116;
					continue;
				case 1u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -1157720042;
					continue;
				default:
					return;
				case 10u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		bool onlyOneWinner = default(bool);
		int num4 = default(int);
		bool flag = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag6 = default(bool);
		Player player = default(Player);
		PlayerState playerState = default(PlayerState);
		bool flag11 = default(bool);
		int num3 = default(int);
		int num5 = default(int);
		Card card = default(Card);
		bool flag2 = default(bool);
		bool flag12 = default(bool);
		bool flag3 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag13 = default(bool);
		bool flag9 = default(bool);
		bool flag4 = default(bool);
		int num10 = default(int);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			int num = 1542405896;
			while (true)
			{
				uint num2;
				int num17;
				switch ((num2 = (uint)num ^ 0x43E5BB0u) % 85u)
				{
				case 84u:
				{
					int num15;
					int num16;
					if (!onlyOneWinner)
					{
						num15 = 1621733374;
						num16 = 1621733374;
					}
					else
					{
						num15 = 293385040;
						num16 = 293385040;
					}
					num = num15 ^ ((int)num2 * -298402040);
					continue;
				}
				case 83u:
					num = (int)(num2 * 1757414407) ^ -787797412;
					continue;
				case 82u:
					num = ((int)num2 * -878544010) ^ -1844749793;
					continue;
				case 81u:
					Losers.Add(num4);
					num = (int)(num2 * 661907908) ^ -1152414598;
					continue;
				case 80u:
					flag = false;
					num = 717088830;
					continue;
				case 79u:
					playerState2.State = State.Lose;
					flag6 = !Losers.Contains(num4);
					num = 1227614519;
					continue;
				case 78u:
				{
					player = Players[playerIndex];
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					int num36;
					int num37;
					if (playerState.State == State.Playing)
					{
						num36 = 1468319425;
						num37 = 1468319425;
					}
					else
					{
						num36 = 1797854818;
						num37 = 1797854818;
					}
					num = num36 ^ ((int)num2 * -1132135448);
					continue;
				}
				case 77u:
					flag11 = playerState.Sprint > Rules.SprintCount;
					num = 1535213153;
					continue;
				case 76u:
				{
					int num20;
					if (!_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = 1768957098;
						num20 = 1768957098;
					}
					else
					{
						num = 1972498034;
						num20 = 1972498034;
					}
					continue;
				}
				case 75u:
					num4++;
					num = 273848908;
					continue;
				case 74u:
					flag = num3 < Rules.StayOnSprintMinDiff;
					num5 = Game.smethod_3(0, num3);
					num = (int)(num2 * 434091016) ^ -537413495;
					continue;
				case 73u:
					num = ((int)num2 * -1437623416) ^ 0x61A240D5;
					continue;
				case 72u:
					num = ((int)num2 * -123414861) ^ -1434023894;
					continue;
				case 71u:
				{
					int num11;
					int num12;
					if (flag6)
					{
						num11 = 1520917332;
						num12 = 1520917332;
					}
					else
					{
						num11 = 327251528;
						num12 = 327251528;
					}
					num = num11 ^ ((int)num2 * -1432782298);
					continue;
				}
				case 70u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -2042635593) ^ -610115238;
						continue;
					}
					num17 = 0;
					goto IL_020d;
				case 69u:
					num = ((int)num2 * -955042047) ^ 0x61B16E0A;
					continue;
				case 68u:
					num = 755281070;
					continue;
				case 67u:
					num = (int)(num2 * 1831116523) ^ -367331456;
					continue;
				case 66u:
					num = (int)((num2 * 1246606287) ^ 0x55A32859);
					continue;
				case 65u:
					num = ((int)num2 * -948115194) ^ 0x33FFF326;
					continue;
				case 64u:
					num5 = card.Impact;
					num = (int)(num2 * 1152079726) ^ -431609605;
					continue;
				case 63u:
					flag2 = num4 < _playerStates.Length;
					num = 948740420;
					continue;
				case 62u:
					playerState.State = State.Lose;
					num = ((int)num2 * -300642923) ^ -1838483850;
					continue;
				case 61u:
					num = (int)((num2 * 1889021459) ^ 0x67C45B8A);
					continue;
				case 60u:
					Print("CARD: none, advance");
					num = ((int)num2 * -1554580661) ^ -1630554567;
					continue;
				case 59u:
					playerState.Resources -= num5;
					flag12 = playerState.Resources < 0;
					num = ((int)num2 * -1887836437) ^ 0x5F0DBC1C;
					continue;
				case 58u:
				{
					int num23;
					int num24;
					if (flag3)
					{
						num23 = -1862304729;
						num24 = -1862304729;
					}
					else
					{
						num23 = -2036331470;
						num24 = -2036331470;
					}
					num = num23 ^ (int)(num2 * 1946616036);
					continue;
				}
				case 57u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 1134674958;
					continue;
				}
				case 56u:
					_finished = true;
					num = (int)(num2 * 1846393031) ^ -1689127489;
					continue;
				case 55u:
					num = (int)(num2 * 1264578095) ^ -1952808748;
					continue;
				case 54u:
				{
					int num13;
					int num14;
					if (!flag7)
					{
						num13 = -332466922;
						num14 = -332466922;
					}
					else
					{
						num13 = -55110397;
						num14 = -55110397;
					}
					num = num13 ^ ((int)num2 * -1725818509);
					continue;
				}
				case 53u:
					flag5 = card.Impact < 0;
					num = ((int)num2 * -1241023932) ^ 0x20D9D94D;
					continue;
				case 52u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1011818170;
						num9 = -1011818170;
					}
					else
					{
						num8 = -975019645;
						num9 = -975019645;
					}
					num = num8 ^ (int)(num2 * 856170526);
					continue;
				}
				case 51u:
					num = 692574737;
					continue;
				case 50u:
					num = (int)((num2 * 2143624126) ^ 0x71C68544);
					continue;
				case 49u:
				{
					int num34;
					int num35;
					if (!flag13)
					{
						num34 = 1772380354;
						num35 = 1772380354;
					}
					else
					{
						num34 = 1421888970;
						num35 = 1421888970;
					}
					num = num34 ^ ((int)num2 * -100448098);
					continue;
				}
				case 48u:
					num = 2076106973;
					continue;
				case 47u:
					num = ((int)num2 * -1601330986) ^ -1538460234;
					continue;
				case 46u:
					num = (int)(num2 * 893803537) ^ -1830684600;
					continue;
				case 45u:
					num = 169645240;
					continue;
				case 44u:
					flag = true;
					num = 1350506508;
					continue;
				case 43u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -1518755628) ^ 0x4D604F2E;
					continue;
				case 42u:
					num = (int)(num2 * 171912771) ^ -226093562;
					continue;
				case 41u:
					flag9 = flag;
					num = 148062539;
					continue;
				case 40u:
				{
					int num32;
					int num33;
					if (!flag4)
					{
						num32 = 982906910;
						num33 = 982906910;
					}
					else
					{
						num32 = 730562784;
						num33 = 730562784;
					}
					num = num32 ^ (int)(num2 * 1107930822);
					continue;
				}
				case 39u:
					Print("Still planning");
					num = (int)(num2 * 245551147) ^ -934545242;
					continue;
				case 38u:
					flag13 = num10 < _playerStates.Length;
					num = 767820269;
					continue;
				case 37u:
				{
					int num30;
					int num31;
					if (!flag12)
					{
						num30 = 208852233;
						num31 = 208852233;
					}
					else
					{
						num30 = 1910949023;
						num31 = 1910949023;
					}
					num = num30 ^ (int)(num2 * 1912422549);
					continue;
				}
				case 36u:
					card = DrawCard();
					num = ((int)num2 * -2135906049) ^ -1463192685;
					continue;
				case 35u:
					num = 210249061;
					continue;
				case 34u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 829494709) ^ 0x61D0EBC5);
					continue;
				case 33u:
					num = 1766850357;
					continue;
				case 32u:
				{
					int num29;
					if (playerState.Sprint < 0)
					{
						num = 909713945;
						num29 = 909713945;
					}
					else
					{
						num = 1976410973;
						num29 = 1976410973;
					}
					continue;
				}
				case 31u:
					num10++;
					num = 1648041391;
					continue;
				case 30u:
					num = (int)(num2 * 1614111235) ^ -249074740;
					continue;
				case 29u:
					Print(playerState.State);
					num = ((int)num2 * -343547143) ^ -1477071532;
					continue;
				case 28u:
					playerState.Sprint++;
					num = (int)((num2 * 304612326) ^ 0x61C2EC74);
					continue;
				case 27u:
				{
					int num27;
					int num28;
					if (flag10)
					{
						num27 = -1629054240;
						num28 = -1629054240;
					}
					else
					{
						num27 = -673842879;
						num28 = -673842879;
					}
					num = num27 ^ (int)(num2 * 1453541378);
					continue;
				}
				case 26u:
					num = 1012572584;
					continue;
				case 25u:
					num10 = 0;
					num = ((int)num2 * -1089700854) ^ -1572744540;
					continue;
				case 24u:
					Losers.Add(num10);
					num = ((int)num2 * -843585785) ^ 0x531CA765;
					continue;
				case 23u:
					num = ((int)num2 * -51323779) ^ 0x52E91D6;
					continue;
				case 22u:
				{
					int num25;
					int num26;
					if (!flag11)
					{
						num25 = 143682535;
						num26 = 143682535;
					}
					else
					{
						num25 = 221846013;
						num26 = 221846013;
					}
					num = num25 ^ ((int)num2 * -1070778641);
					continue;
				}
				case 21u:
					num = 1329627360;
					continue;
				case 20u:
					num = ((int)num2 * -2039980395) ^ -301448238;
					continue;
				case 19u:
					num4 = 0;
					num = (int)(num2 * 1510389167) ^ -952510761;
					continue;
				case 17u:
					flag10 = !Losers.Contains(num10);
					num = 1034626247;
					continue;
				case 16u:
				{
					int num21;
					int num22;
					if (flag9)
					{
						num21 = -1290808445;
						num22 = -1290808445;
					}
					else
					{
						num21 = -1172469698;
						num22 = -1172469698;
					}
					num = num21 ^ (int)(num2 * 1184661490);
					continue;
				}
				case 15u:
				{
					int num18;
					int num19;
					if (flag8)
					{
						num18 = -129000446;
						num19 = -129000446;
					}
					else
					{
						num18 = -999507091;
						num19 = -999507091;
					}
					num = num18 ^ (int)(num2 * 2068795908);
					continue;
				}
				case 14u:
					num17 = ((card.Type == 4) ? 1 : 0);
					goto IL_020d;
				case 13u:
					num = ((int)num2 * -1969447485) ^ -936084370;
					continue;
				case 12u:
					num = (int)((num2 * 539466555) ^ 0x2DC90850);
					continue;
				case 11u:
					flag7 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1750859527) ^ 0x55D27FA8;
					continue;
				case 10u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag4 ? "ALL " : "", flag5 ? "receives" : "pays", Game.smethod_4(num5), flag ? "advance" : "stay");
					num = 1011276502;
					continue;
				case 9u:
					flag3 = num10 == playerIndex;
					num = ((int)num2 * -2017056458) ^ -950473865;
					continue;
				case 8u:
				{
					playerState2 = _playerStates[num4];
					playerState2.Resources -= Game.smethod_3(0, num5 - Players[num4].PlannedForCard(card.Type));
					int num6;
					int num7;
					if (playerState2.Resources >= 0)
					{
						num6 = 1633125625;
						num7 = 1633125625;
					}
					else
					{
						num6 = 987792707;
						num7 = 987792707;
					}
					num = num6 ^ ((int)num2 * -564888915);
					continue;
				}
				case 7u:
					num = (int)(num2 * 687357736) ^ -456644391;
					continue;
				case 6u:
					num3 = card.Impact - player.PlannedForCard(card.Type);
					num = ((int)num2 * -931512249) ^ -890142990;
					continue;
				case 5u:
					num = ((int)num2 * -696526412) ^ 0x724D7344;
					continue;
				case 4u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)(num2 * 523610651) ^ -75936909;
					continue;
				case 2u:
					num = 331026424;
					continue;
				case 1u:
					playerState.Sprint++;
					num = ((int)num2 * -497011229) ^ 0x603A04C7;
					continue;
				case 0u:
					flag = true;
					num = ((int)num2 * -1439711386) ^ -1334616514;
					continue;
				default:
					return;
				case 3u:
					break;
				case 18u:
					return;
					IL_020d:
					flag4 = (byte)num17 != 0;
					flag8 = !flag5;
					num = 330640913;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		bool flag = _deck.Count <= 0;
		Card card = default(Card);
		Card result = default(Card);
		while (true)
		{
			int num = -1317886341;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90D9EC83u) % 9u)
				{
				case 7u:
					_deck.RemoveAt(0);
					num = ((int)num2 * -1403073131) ^ -1527193855;
					continue;
				case 6u:
					num = ((int)num2 * -1051623480) ^ -776016135;
					continue;
				case 5u:
					card = _deck[0];
					num = -94116030;
					continue;
				case 4u:
					ShuffleCards();
					num = (int)((num2 * 1984447038) ^ 0x35A745A7);
					continue;
				case 3u:
					num = (int)((num2 * 1545531506) ^ 0x1B3B9509);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 80927940;
						num4 = 80927940;
					}
					else
					{
						num3 = 874247033;
						num4 = 874247033;
					}
					num = num3 ^ (int)(num2 * 1686727882);
					continue;
				}
				case 0u:
					result = card;
					num = ((int)num2 * -1097749373) ^ -986644903;
					continue;
				case 2u:
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
		string result = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -508605908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC0EDEE2u) % 10u)
				{
				case 7u:
					num = (int)(num2 * 2020028931) ^ -1679592898;
					continue;
				case 6u:
					text = "";
					num = ((int)num2 * -398025529) ^ 0x3AF59376;
					continue;
				case 5u:
					num = ((int)num2 * -448055375) ^ 0x5B53C332;
					continue;
				case 4u:
					result = text;
					num = (int)(num2 * 2120743933) ^ -964180471;
					continue;
				case 3u:
					num3++;
					num = (int)((num2 * 1837673066) ^ 0x29F2DABB);
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
					num = -1932415119;
					continue;
				}
				case 1u:
				{
					int num4;
					if (num3 >= _playerStates.Length)
					{
						num = -1892032546;
						num4 = -1892032546;
					}
					else
					{
						num = -245053714;
						num4 = -245053714;
					}
					continue;
				}
				case 0u:
					num3 = 0;
					num = (int)((num2 * 407819063) ^ 0x2EC56E31);
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -323901971;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB726148Cu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1743337148) ^ -226796772;
					continue;
				case 1u:
					result = ToString(initial: false);
					num = (int)(num2 * 1444708812) ^ -2074683157;
					continue;
				case 2u:
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
