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
				goto IL_00ec;
			}
			goto IL_0138;
			IL_0138:
			int num = -1722747154;
			goto IL_00f1;
			IL_00f1:
			PlayerState playerState = default(PlayerState);
			int num3 = default(int);
			bool result = default(bool);
			PlayerState[] playerStates = default(PlayerState[]);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFEA6C2C2u) % 13u)
				{
				case 11u:
					num = (int)(num2 * 1607230989) ^ -253827740;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (playerState.State != 0)
					{
						num4 = -823094831;
						num5 = -823094831;
					}
					else
					{
						num4 = -119204378;
						num5 = -119204378;
					}
					num = num4 ^ (int)(num2 * 1892872687);
					continue;
				}
				case 9u:
					num3++;
					num = -2078123741;
					continue;
				case 8u:
					result = true;
					num = (int)(num2 * 411910259) ^ -1844562312;
					continue;
				case 7u:
					result = true;
					num = (int)(num2 * 1589441595) ^ -104066835;
					continue;
				case 6u:
					break;
				case 5u:
					num3 = 0;
					num = (int)(num2 * 1220114961) ^ -1728379366;
					continue;
				case 4u:
					result = false;
					num = ((int)num2 * -191545846) ^ -1348116387;
					continue;
				case 3u:
					playerState = playerStates[num3];
					num = -1334604477;
					continue;
				case 1u:
					playerStates = _playerStates;
					num = (int)(num2 * 351714730) ^ -1426624463;
					continue;
				case 0u:
					goto end_IL_00f1;
				case 12u:
					goto IL_0138;
				default:
					return result;
				}
				int num6;
				if (num3 >= playerStates.Length)
				{
					num = -206771573;
					num6 = -206771573;
				}
				else
				{
					num = -1579636703;
					num6 = -1579636703;
				}
				continue;
				end_IL_00f1:
				break;
			}
			goto IL_00ec;
			IL_00ec:
			num = -44422664;
			goto IL_00f1;
		}
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		int num3 = default(int);
		bool flag = default(bool);
		int count = default(int);
		int num5 = default(int);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -1839117392;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE84A5592u) % 16u)
				{
				case 14u:
					_dice = new Dice();
					num = ((int)num2 * -291046611) ^ 0x52884C4;
					continue;
				case 13u:
					_buffer = buffer;
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = (int)((num2 * 1977195684) ^ 0x5B7ED628);
					continue;
				case 12u:
					_playerStates[num3] = new PlayerState();
					num3++;
					num = -367164348;
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -1640151990;
						num7 = -1640151990;
					}
					else
					{
						num6 = -1962361044;
						num7 = -1962361044;
					}
					num = num6 ^ ((int)num2 * -1908490085);
					continue;
				}
				case 10u:
					Players = new Player[count];
					num5 = 0;
					num = (int)(num2 * 2092030473) ^ -218186261;
					continue;
				case 9u:
					flag = num5 < count;
					num = -1154519575;
					continue;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -487631895) ^ -1060991457;
					continue;
				case 7u:
					Players[num5] = Player.Deserialize(jSONNode[num5]);
					num5++;
					num = -1234428821;
					continue;
				case 6u:
				{
					int num4;
					if (num3 < count)
					{
						num = -288512994;
						num4 = -288512994;
					}
					else
					{
						num = -1308134547;
						num4 = -1308134547;
					}
					continue;
				}
				case 5u:
					num = ((int)num2 * -1784243722) ^ -643067734;
					continue;
				case 3u:
					num = ((int)num2 * -1907345234) ^ -1119151775;
					continue;
				case 2u:
					num = ((int)num2 * -1283312755) ^ 0x3D90AF45;
					continue;
				case 1u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -291095685) ^ -986709071;
					continue;
				case 0u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = ((int)num2 * -1268420488) ^ 0x44C0B038;
					continue;
				default:
					return;
				case 4u:
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
			int num = -1306458243;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3247242u) % 8u)
				{
				case 7u:
					ShuffleCards();
					Winners.Clear();
					Losers.Clear();
					num = ((int)num2 * -637328411) ^ 0x638CB211;
					continue;
				case 5u:
					_currentPlayer = Players.Length;
					num = (int)(num2 * 892428440) ^ -1362794783;
					continue;
				case 3u:
					_currentTurn = 0;
					_finished = false;
					num = (int)(num2 * 1012075728) ^ -335572637;
					continue;
				case 2u:
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -1469316311) ^ -21471516;
					continue;
				case 1u:
					_currentChanceIndex = -1;
					num = (int)((num2 * 1177489049) ^ 0xCE0F921);
					continue;
				case 0u:
					num = (int)((num2 * 198756977) ^ 0x844C347);
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

	public void PlanningState()
	{
		bool flag = default(bool);
		int num3 = default(int);
		PlayerState playerState = default(PlayerState);
		int num4 = default(int);
		int planningCardsCount = default(int);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		while (true)
		{
			int num = -469271302;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97F2DA2Du) % 25u)
				{
				case 24u:
					flag = num3 > 0;
					num = -1353854923;
					continue;
				case 23u:
					num = ((int)num2 * -1880129192) ^ 0x52571A48;
					continue;
				case 22u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = (int)((num2 * 342864355) ^ 0x1EF9CC70);
					continue;
				case 21u:
					num4 = 0;
					num = ((int)num2 * -1198062960) ^ -2027962145;
					continue;
				case 20u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = -368423663;
					continue;
				case 19u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -2058336931) ^ -1209732388;
					continue;
				case 18u:
					num4++;
					num = (int)((num2 * 1607358391) ^ 0x5A4E9FED);
					continue;
				case 17u:
				{
					int num6;
					int num7;
					if (useOneMorePlanningSprint)
					{
						num6 = 1791920567;
						num7 = 1791920567;
					}
					else
					{
						num6 = 446537427;
						num7 = 446537427;
					}
					num = num6 ^ ((int)num2 * -165162070);
					continue;
				}
				case 16u:
					planningCardsCount = player.PlanningCardsCount;
					num = ((int)num2 * -623745622) ^ -976421051;
					continue;
				case 15u:
				{
					int num10;
					int num11;
					if (planningCardsCount != 0)
					{
						num10 = -1305196045;
						num11 = -1305196045;
					}
					else
					{
						num10 = -513242463;
						num11 = -513242463;
					}
					num = num10 ^ (int)(num2 * 506795968);
					continue;
				}
				case 14u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					num = ((int)num2 * -1281181293) ^ -994631898;
					continue;
				case 13u:
					playerState.State = State.Playing;
					num = (int)(num2 * 440404770) ^ -2031437167;
					continue;
				case 12u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)(num2 * 1328956306) ^ -387949450;
					continue;
				case 10u:
					playerState.Sprint = 1;
					num = (int)(num2 * 1933480128) ^ -1469879823;
					continue;
				case 9u:
					num3 = 0;
					num = -548986024;
					continue;
				case 8u:
					playerState.Sprint = -1;
					num = ((int)num2 * -610817294) ^ 0x39A9C190;
					continue;
				case 7u:
					num = (int)(num2 * 1258978762) ^ -1665073934;
					continue;
				case 6u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -1139287147;
						num9 = -1139287147;
					}
					else
					{
						num8 = -1249273648;
						num9 = -1249273648;
					}
					num = num8 ^ ((int)num2 * -886158368);
					continue;
				}
				case 5u:
				{
					int num5;
					if (num4 < Players.Length)
					{
						num = -488371839;
						num5 = -488371839;
					}
					else
					{
						num = -1198203799;
						num5 = -1198203799;
					}
					continue;
				}
				case 4u:
					num = -152891928;
					continue;
				case 2u:
					player = Players[num4];
					playerState = _playerStates[num4];
					num = -1628315081;
					continue;
				case 1u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = -1081394589;
					continue;
				case 0u:
					num3 = 0;
					num = (int)((num2 * 618330477) ^ 0x5ACE5125);
					continue;
				default:
					return;
				case 11u:
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 633073069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC68060u) % 15u)
				{
				case 14u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 336962389;
					continue;
				case 13u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -684339799) ^ -517478090;
					continue;
				case 10u:
					num = ((int)num2 * -751843164) ^ 0x1379DEFB;
					continue;
				case 9u:
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -826495941) ^ 0x85DAB07;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 777231511;
						num6 = 777231511;
					}
					else
					{
						num5 = 1163236408;
						num6 = 1163236408;
					}
					num = num5 ^ ((int)num2 * -2046340869);
					continue;
				}
				case 7u:
					num = ((int)num2 * -1695135525) ^ 0x742F1B3D;
					continue;
				case 6u:
					_currentPlayer = 0;
					num = (int)(num2 * 747946713) ^ -778372239;
					continue;
				case 5u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)(num2 * 1127492132) ^ -1506163061;
					continue;
				case 4u:
					num = ((int)num2 * -2031818868) ^ -1457186717;
					continue;
				case 3u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1178420908) ^ 0x1B6A6A12;
					continue;
				case 2u:
					flag = _currentPlayer >= Players.Length;
					num = (int)((num2 * 1290693110) ^ 0x3A1F4EEE);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1951204345;
						num4 = 1951204345;
					}
					else
					{
						num3 = 1573612612;
						num4 = 1573612612;
					}
					num = num3 ^ (int)(num2 * 600664956);
					continue;
				}
				case 0u:
					PlayerTurn(_currentPlayer);
					num = 1759491248;
					continue;
				default:
					return;
				case 11u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		bool flag7 = default(bool);
		int num7 = default(int);
		int num8 = default(int);
		PlayerState playerState = default(PlayerState);
		bool flag9 = default(bool);
		Card card = default(Card);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		int num6 = default(int);
		bool flag8 = default(bool);
		int num3 = default(int);
		bool flag4 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -601346433;
			while (true)
			{
				uint num2;
				int num12;
				switch ((num2 = (uint)num ^ 0xC31D48EBu) % 77u)
				{
				case 76u:
					flag7 = num7 < Rules.StayOnSprintMinDiff;
					num8 = Game.smethod_3(0, num7);
					num = ((int)num2 * -1855149031) ^ 0x5E26C5C3;
					continue;
				case 75u:
					num = ((int)num2 * -1619568444) ^ -2117383581;
					continue;
				case 74u:
					num = ((int)num2 * -1918644193) ^ -414434649;
					continue;
				case 73u:
					playerState.State = State.Lose;
					flag9 = !Losers.Contains(playerIndex);
					num = (int)(num2 * 965241996) ^ -1174708553;
					continue;
				case 72u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag2 ? "ALL " : "", flag5 ? "receives" : "pays", Game.smethod_4(num8), flag7 ? "advance" : "stay");
					num = -682414172;
					continue;
				case 71u:
					num = -168255957;
					continue;
				case 70u:
				{
					int num29;
					if (flag7)
					{
						num = -303777998;
						num29 = -303777998;
					}
					else
					{
						num = -346688810;
						num29 = -346688810;
					}
					continue;
				}
				case 69u:
				{
					int num18;
					int num19;
					if (flag6)
					{
						num18 = 1430375806;
						num19 = 1430375806;
					}
					else
					{
						num18 = 440041092;
						num19 = 440041092;
					}
					num = num18 ^ (int)(num2 * 307989698);
					continue;
				}
				case 68u:
				{
					int num13;
					if (num6 < _playerStates.Length)
					{
						num = -911586121;
						num13 = -911586121;
					}
					else
					{
						num = -2019974591;
						num13 = -2019974591;
					}
					continue;
				}
				case 67u:
					num = ((int)num2 * -1099867824) ^ 0x6778CE46;
					continue;
				case 66u:
					num = (int)(num2 * 330709608) ^ -187660385;
					continue;
				case 65u:
					num = (int)((num2 * 725075441) ^ 0x45C55DF0);
					continue;
				case 64u:
					flag8 = !Losers.Contains(num3);
					num = -692766668;
					continue;
				case 63u:
				{
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					int num30;
					int num31;
					if (playerState.State == State.Playing)
					{
						num30 = 1166116274;
						num31 = 1166116274;
					}
					else
					{
						num30 = 226746191;
						num31 = 226746191;
					}
					num = num30 ^ ((int)num2 * -1674200899);
					continue;
				}
				case 61u:
					num12 = ((card.Type == 4) ? 1 : 0);
					goto IL_0224;
				case 60u:
					num = (int)((num2 * 237559787) ^ 0x190E6F77);
					continue;
				case 59u:
					num = (int)(num2 * 180787745) ^ -563358218;
					continue;
				case 58u:
					Losers.Add(num3);
					num = ((int)num2 * -1903307849) ^ 0x2E2B4CA2;
					continue;
				case 57u:
					num = (int)(num2 * 1512839457) ^ -121761456;
					continue;
				case 56u:
					num = (int)((num2 * 499095984) ^ 0x49D0FCA8);
					continue;
				case 55u:
					num = -88479177;
					continue;
				case 54u:
					flag4 = playerState.Sprint < 0;
					num = -946233168;
					continue;
				case 53u:
					num = -256632601;
					continue;
				case 52u:
					playerState.Sprint++;
					Print("Still planning");
					num = ((int)num2 * -113412357) ^ 0x1DFE1464;
					continue;
				case 51u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -85024615;
					continue;
				}
				case 50u:
					flag6 = !flag5;
					num = ((int)num2 * -1902416314) ^ 0x4C04E837;
					continue;
				case 49u:
					flag7 = false;
					num = -118419726;
					continue;
				case 48u:
				{
					int num10;
					int num11;
					if (!flag4)
					{
						num10 = 1144769231;
						num11 = 1144769231;
					}
					else
					{
						num10 = 1534763365;
						num11 = 1534763365;
					}
					num = num10 ^ (int)(num2 * 472413254);
					continue;
				}
				case 47u:
					num6 = 0;
					num = -917144435;
					continue;
				case 45u:
					Print(playerState.State);
					num = (int)((num2 * 1000603969) ^ 0x50DFFBA4);
					continue;
				case 44u:
					_finished = true;
					num = (int)((num2 * 1127533454) ^ 0x137797C7);
					continue;
				case 43u:
					flag7 = true;
					num8 = card.Impact;
					num = (int)((num2 * 353809647) ^ 0x7C640E38);
					continue;
				case 42u:
					playerState2 = _playerStates[num6];
					num = (int)((num2 * 1953636017) ^ 0x31206522);
					continue;
				case 41u:
					num = (int)((num2 * 1026625930) ^ 0x40AFA5EB);
					continue;
				case 40u:
					Losers.Add(num6);
					num = ((int)num2 * -2032286412) ^ 0x56F76B5D;
					continue;
				case 39u:
					num = ((int)num2 * -479210737) ^ -1750557342;
					continue;
				case 38u:
					num6++;
					num = -403664906;
					continue;
				case 37u:
				{
					int num34;
					if (playerState.Sprint > Rules.SprintCount)
					{
						num = -1858514245;
						num34 = -1858514245;
					}
					else
					{
						num = -2105746957;
						num34 = -2105746957;
					}
					continue;
				}
				case 36u:
					num = (int)(num2 * 1937205727) ^ -580639351;
					continue;
				case 35u:
					num = -431587293;
					continue;
				case 34u:
				{
					int num32;
					int num33;
					if (playerState2.Resources < 0)
					{
						num32 = 1340922017;
						num33 = 1340922017;
					}
					else
					{
						num32 = 994593537;
						num33 = 994593537;
					}
					num = num32 ^ ((int)num2 * -1541232476);
					continue;
				}
				case 33u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -1497019530) ^ 0x5120B08F;
					continue;
				case 32u:
				{
					int num27;
					int num28;
					if (!flag9)
					{
						num27 = 870390306;
						num28 = 870390306;
					}
					else
					{
						num27 = 849629818;
						num28 = 849629818;
					}
					num = num27 ^ (int)(num2 * 1434497335);
					continue;
				}
				case 31u:
					flag7 = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -503373051) ^ 0x4A2873DC;
					continue;
				case 30u:
					num = ((int)num2 * -1973217749) ^ 0x18659F97;
					continue;
				case 29u:
				{
					playerState.Resources -= num8;
					int num25;
					int num26;
					if (playerState.Resources < 0)
					{
						num25 = -1777576006;
						num26 = -1777576006;
					}
					else
					{
						num25 = -828746379;
						num26 = -828746379;
					}
					num = num25 ^ ((int)num2 * -1662874065);
					continue;
				}
				case 28u:
					num = -1721068314;
					continue;
				case 27u:
					num = -1956724721;
					continue;
				case 26u:
					num3++;
					num = -1372459185;
					continue;
				case 25u:
					num3 = 0;
					num = ((int)num2 * -2034590458) ^ -646623444;
					continue;
				case 24u:
					num = (int)((num2 * 929926688) ^ 0x4E6E872B);
					continue;
				case 23u:
					num = (int)((num2 * 1366762066) ^ 0x29A7CD87);
					continue;
				case 22u:
				{
					int num23;
					int num24;
					if (num3 != playerIndex)
					{
						num23 = 1051401219;
						num24 = 1051401219;
					}
					else
					{
						num23 = 298431585;
						num24 = 298431585;
					}
					num = num23 ^ (int)(num2 * 1211157846);
					continue;
				}
				case 21u:
					num = -1339352055;
					continue;
				case 20u:
				{
					int num21;
					int num22;
					if (flag8)
					{
						num21 = 1117815066;
						num22 = 1117815066;
					}
					else
					{
						num21 = 1515713608;
						num22 = 1515713608;
					}
					num = num21 ^ ((int)num2 * -406790918);
					continue;
				}
				case 19u:
				{
					int num20;
					if (!_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = -755835734;
						num20 = -755835734;
					}
					else
					{
						num = -1513231944;
						num20 = -1513231944;
					}
					continue;
				}
				case 18u:
					num = ((int)num2 * -1309700317) ^ 0x404B66C6;
					continue;
				case 17u:
					num = (int)(num2 * 920454690) ^ -182790980;
					continue;
				case 16u:
				{
					int num16;
					int num17;
					if (flag)
					{
						num16 = -1167029935;
						num17 = -1167029935;
					}
					else
					{
						num16 = -201513728;
						num17 = -201513728;
					}
					num = num16 ^ (int)(num2 * 81290241);
					continue;
				}
				case 15u:
				{
					int num14;
					int num15;
					if (!Rules.OnlyOneWinner)
					{
						num14 = -62560665;
						num15 = -62560665;
					}
					else
					{
						num14 = -1210675490;
						num15 = -1210675490;
					}
					num = num14 ^ ((int)num2 * -1280746673);
					continue;
				}
				case 14u:
					card = DrawCard();
					flag5 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -579275910) ^ -476927275;
						continue;
					}
					num12 = 0;
					goto IL_0224;
				case 13u:
				{
					playerState2.State = State.Lose;
					int num9;
					if (Losers.Contains(num6))
					{
						num = -1188073058;
						num9 = -1188073058;
					}
					else
					{
						num = -741313395;
						num9 = -741313395;
					}
					continue;
				}
				case 12u:
					playerState2.Resources -= Game.smethod_3(0, num8 - Players[num6].PlannedForCard(card.Type));
					num = (int)((num2 * 27078665) ^ 0x31004D96);
					continue;
				case 11u:
					num = ((int)num2 * -1332709574) ^ 0x46E3BEE3;
					continue;
				case 10u:
					playerState.Sprint++;
					num = ((int)num2 * -1749432865) ^ -617797167;
					continue;
				case 9u:
					num7 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)(num2 * 922183404) ^ -1293869660;
					continue;
				case 8u:
					num = -90291139;
					continue;
				case 7u:
					num = -2105746957;
					continue;
				case 6u:
					Losers.Add(playerIndex);
					num = (int)(num2 * 1118773559) ^ -990910333;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag3)
					{
						num4 = -1259908638;
						num5 = -1259908638;
					}
					else
					{
						num4 = -1018163690;
						num5 = -1018163690;
					}
					num = num4 ^ (int)(num2 * 38957690);
					continue;
				}
				case 4u:
					num = (int)((num2 * 1360110147) ^ 0x71E62B5A);
					continue;
				case 3u:
					num = ((int)num2 * -738229558) ^ 0x305978F6;
					continue;
				case 2u:
					flag3 = !flag2;
					num = (int)((num2 * 34252116) ^ 0x251B859E);
					continue;
				case 1u:
					num = (int)((num2 * 344133842) ^ 0x51C9C2BE);
					continue;
				case 0u:
					flag = num3 < _playerStates.Length;
					num = -1141943120;
					continue;
				default:
					return;
				case 62u:
					break;
				case 46u:
					return;
					IL_0224:
					flag2 = (byte)num12 != 0;
					num = -851167415;
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
			int num = 392476589;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DFFFu) % 9u)
				{
				case 7u:
					ShuffleCards();
					num = ((int)num2 * -831550659) ^ -1024588871;
					continue;
				case 6u:
					num = (int)((num2 * 2125363859) ^ 0x1F4257D6);
					continue;
				case 5u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 1211617009) ^ 0x3D30F64C);
					continue;
				case 3u:
					result = card;
					num = (int)(num2 * 399753086) ^ -478249368;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_deck.Count <= 0)
					{
						num3 = 1448393812;
						num4 = 1448393812;
					}
					else
					{
						num3 = 272951435;
						num4 = 272951435;
					}
					num = num3 ^ ((int)num2 * -236310269);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1760800705) ^ -1468557102;
					continue;
				case 0u:
					card = _deck[0];
					num = 1566581552;
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

	public string ToString(bool initial)
	{
		string text = "";
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1960392008;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5DC6DBBu) % 10u)
				{
				case 9u:
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
					num = -744720613;
					continue;
				}
				case 8u:
					num3++;
					num = ((int)num2 * -1424846905) ^ -194228522;
					continue;
				case 7u:
					flag = num3 < _playerStates.Length;
					num = -157731712;
					continue;
				case 6u:
					num = (int)(num2 * 1893264182) ^ -478894934;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1328926837;
						num5 = 1328926837;
					}
					else
					{
						num4 = 418257844;
						num5 = 418257844;
					}
					num = num4 ^ (int)(num2 * 1152520315);
					continue;
				}
				case 3u:
					num = (int)((num2 * 1821761456) ^ 0x40DB546F);
					continue;
				case 2u:
					result = text;
					num = (int)((num2 * 1993553305) ^ 0x2235D95A);
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1411433262) ^ -127978041;
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
			int num = 1042160045;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x833972Cu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1172599385) ^ 0x7C6794ED;
					continue;
				case 1u:
					result = ToString(initial: false);
					num = (int)(num2 * 455942619) ^ -1834738711;
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
		string string_ = Game.smethod_7(Game.smethod_5(text), more);
		while (true)
		{
			int num = 909448691;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B6F358Au) % 3u)
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000f:
				Game.smethod_8(_buffer, string_);
				num = ((int)num2 * -195446312) ^ 0x5E6A8690;
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
