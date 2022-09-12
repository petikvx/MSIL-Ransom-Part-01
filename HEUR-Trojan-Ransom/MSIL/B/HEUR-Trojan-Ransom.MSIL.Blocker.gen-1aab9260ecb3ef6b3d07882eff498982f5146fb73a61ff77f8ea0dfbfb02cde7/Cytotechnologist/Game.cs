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
			while (true)
			{
				int num = 1343224727;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1BA9573Eu) % 14u)
					{
					case 13u:
						result = true;
						num = ((int)num2 * -875480835) ^ 0x7B8C597D;
						continue;
					case 12u:
						num = (int)(num2 * 217719842) ^ -1887864283;
						continue;
					case 11u:
					{
						int num5;
						int num6;
						if (_finished)
						{
							num5 = -248027403;
							num6 = -248027403;
						}
						else
						{
							num5 = -1066695382;
							num6 = -1066695382;
						}
						num = num5 ^ (int)(num2 * 1135905657);
						continue;
					}
					case 9u:
						result = false;
						num = (int)(num2 * 138535280) ^ -1843213620;
						continue;
					case 8u:
						playerStates = _playerStates;
						num = ((int)num2 * -60079178) ^ -1280468916;
						continue;
					case 7u:
					{
						int num7;
						if (num3 < playerStates.Length)
						{
							num = 702343860;
							num7 = 702343860;
						}
						else
						{
							num = 956227819;
							num7 = 956227819;
						}
						continue;
					}
					case 5u:
						num = 948194238;
						continue;
					case 4u:
						num3 = 0;
						num = ((int)num2 * -8420205) ^ -1669306568;
						continue;
					case 3u:
						num = ((int)num2 * -1011721249) ^ -1938437917;
						continue;
					case 2u:
					{
						PlayerState playerState = playerStates[num3];
						int num4;
						if (playerState.State == State.Playing)
						{
							num = 989966763;
							num4 = 989966763;
						}
						else
						{
							num = 81869601;
							num4 = 81869601;
						}
						continue;
					}
					case 1u:
						num3++;
						num = 882528965;
						continue;
					case 0u:
						result = true;
						num = ((int)num2 * -1515543853) ^ -1334973599;
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
		ShuffleCards();
		Winners.Clear();
		while (true)
		{
			int num = -1137832650;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEC83285u) % 9u)
				{
				case 8u:
					Losers.Clear();
					num = ((int)num2 * -837973292) ^ -636193671;
					continue;
				case 6u:
					num = (int)(num2 * 983696528) ^ -1597194489;
					continue;
				case 5u:
					_currentTurn = 0;
					_finished = false;
					num = ((int)num2 * -1835975064) ^ 0x455B10BC;
					continue;
				case 4u:
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -353673572) ^ -1851811720;
					continue;
				case 3u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 175037604) ^ 0x35E4A389);
					continue;
				case 1u:
					_currentChanceIndex = -1;
					num = ((int)num2 * -348695449) ^ -1387507804;
					continue;
				case 0u:
					num = ((int)num2 * -948742323) ^ -1510081498;
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		Player player = default(Player);
		int num3 = default(int);
		PlayerState playerState = default(PlayerState);
		int planningCardsCount = default(int);
		int num6 = default(int);
		bool useOneMorePlanningSprint = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -877230442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC939E6C2u) % 25u)
				{
				case 23u:
					player = Players[num3];
					num = ((int)num2 * -578536846) ^ -1544172832;
					continue;
				case 22u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num = -1797273878;
					continue;
				case 21u:
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = (int)(num2 * 1033915730) ^ -1002314213;
					continue;
				case 20u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num6 = 0;
					num = ((int)num2 * -1803627321) ^ -381639502;
					continue;
				case 19u:
					num6 = 0;
					num = -2093897348;
					continue;
				case 18u:
					num = -1318347947;
					continue;
				case 17u:
					num = ((int)num2 * -1990134707) ^ 0x6593741C;
					continue;
				case 16u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -1751778432;
						num10 = -1751778432;
					}
					else
					{
						num9 = -589950864;
						num10 = -589950864;
					}
					num = num9 ^ (int)(num2 * 518194981);
					continue;
				}
				case 15u:
					num3 = 0;
					num = (int)((num2 * 591255710) ^ 0x28FA7FB0);
					continue;
				case 13u:
					num = -1937019258;
					continue;
				case 12u:
				{
					int num8;
					if (num6 > 0)
					{
						num = -260635636;
						num8 = -260635636;
					}
					else
					{
						num = -559285673;
						num8 = -559285673;
					}
					continue;
				}
				case 11u:
					num = -1161567795;
					continue;
				case 10u:
					playerState.Sprint = -1;
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num = ((int)num2 * -444090488) ^ -912866084;
					continue;
				case 9u:
				{
					int num7;
					if (num3 >= Players.Length)
					{
						num = -1862682537;
						num7 = -1862682537;
					}
					else
					{
						num = -1500936708;
						num7 = -1500936708;
					}
					continue;
				}
				case 8u:
					playerState = _playerStates[num3];
					num = ((int)num2 * -5252547) ^ 0x4C9B5E01;
					continue;
				case 7u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num = ((int)num2 * -1176855979) ^ -29584614;
					continue;
				case 6u:
					flag = planningCardsCount == 0;
					num = ((int)num2 * -2055150075) ^ -2004367548;
					continue;
				case 5u:
					num = (int)(num2 * 1608110916) ^ -551165596;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!useOneMorePlanningSprint)
					{
						num4 = 216616276;
						num5 = 216616276;
					}
					else
					{
						num4 = 1776784334;
						num5 = 1776784334;
					}
					num = num4 ^ (int)(num2 * 352347089);
					continue;
				}
				case 3u:
					playerState.Sprint = 1;
					num = (int)(num2 * 1575529331) ^ -821087048;
					continue;
				case 2u:
					num = (int)((num2 * 34547852) ^ 0x1EDBCDB1);
					continue;
				case 1u:
					num = (int)(num2 * 95060666) ^ -198187753;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 981889773) ^ -46275685;
					continue;
				default:
					return;
				case 14u:
					break;
				case 24u:
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
			int num = 1478610360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x284440E3u) % 13u)
				{
				case 11u:
					_currentPlayer = 0;
					flag = _currentTurn > 0;
					num = ((int)num2 * -1812144638) ^ -982039697;
					continue;
				case 10u:
					PlayerTurn(_currentPlayer);
					num = 1719391199;
					continue;
				case 9u:
					num = ((int)num2 * -2122027110) ^ -905291622;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (_currentPlayer < Players.Length)
					{
						num5 = -2132881350;
						num6 = -2132881350;
					}
					else
					{
						num5 = -1447965088;
						num6 = -1447965088;
					}
					num = num5 ^ ((int)num2 * -2050870736);
					continue;
				}
				case 7u:
					_currentPlayer++;
					num = ((int)num2 * -1837756727) ^ -846893764;
					continue;
				case 6u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1107679071) ^ -1894697646;
					continue;
				case 5u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 152340938;
					continue;
				case 4u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 501649223) ^ -101974058;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 938205202;
						num4 = 938205202;
					}
					else
					{
						num3 = 1340419510;
						num4 = 1340419510;
					}
					num = num3 ^ ((int)num2 * -408025622);
					continue;
				}
				case 2u:
					num = ((int)num2 * -817622922) ^ -355771226;
					continue;
				case 1u:
					num = ((int)num2 * -2060783645) ^ 0x3726F031;
					continue;
				default:
					return;
				case 0u:
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
		bool flag5 = default(bool);
		Card card = default(Card);
		PlayerState playerState = default(PlayerState);
		int num15 = default(int);
		bool flag11 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		bool flag12 = default(bool);
		bool flag9 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		int num14 = default(int);
		int num16 = default(int);
		bool flag3 = default(bool);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		Player player = default(Player);
		int num21 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1742357972;
			while (true)
			{
				uint num2;
				int num11;
				switch ((num2 = (uint)num ^ 0xE0AF3D5Du) % 86u)
				{
				case 85u:
					num = (int)(num2 * 1363559216) ^ -357861876;
					continue;
				case 84u:
					flag5 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)(num2 * 598277314) ^ -1637858807;
						continue;
					}
					num11 = 0;
					goto IL_0046;
				case 83u:
					num = -1622817544;
					continue;
				case 82u:
					playerState.Sprint++;
					num = (int)(num2 * 1967522440) ^ -1539716107;
					continue;
				case 81u:
					_finished = true;
					num15 = 0;
					num = (int)((num2 * 1662567691) ^ 0x19F88471);
					continue;
				case 80u:
					num = (int)((num2 * 1833010302) ^ 0x933221D);
					continue;
				case 79u:
					flag11 = num15 < _playerStates.Length;
					num = -237784717;
					continue;
				case 78u:
					Winners.Add(playerIndex);
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)(num2 * 443519887) ^ -691134753;
					continue;
				case 77u:
					num = (int)((num2 * 961371020) ^ 0x60EE64B8);
					continue;
				case 76u:
				{
					int num19;
					int num20;
					if (!onlyOneWinner)
					{
						num19 = -1996364474;
						num20 = -1996364474;
					}
					else
					{
						num19 = -1463625320;
						num20 = -1463625320;
					}
					num = num19 ^ (int)(num2 * 429847823);
					continue;
				}
				case 75u:
					num = (int)((num2 * 260406497) ^ 0x52F71B18);
					continue;
				case 74u:
					num = ((int)num2 * -1775842049) ^ 0x43680F85;
					continue;
				case 73u:
					playerState.Sprint++;
					num = ((int)num2 * -2046009683) ^ -1766832989;
					continue;
				case 72u:
					num = ((int)num2 * -2116104) ^ -1909026276;
					continue;
				case 71u:
					num = (int)((num2 * 1084988864) ^ 0x2BF85538);
					continue;
				case 70u:
				{
					int num5;
					int num6;
					if (Losers.Contains(playerIndex))
					{
						num5 = 1652563989;
						num6 = 1652563989;
					}
					else
					{
						num5 = 1290593126;
						num6 = 1290593126;
					}
					num = num5 ^ (int)(num2 * 742431681);
					continue;
				}
				case 69u:
				{
					int num35;
					int num36;
					if (!flag10)
					{
						num35 = -1199200344;
						num36 = -1199200344;
					}
					else
					{
						num35 = -1280807442;
						num36 = -1280807442;
					}
					num = num35 ^ (int)(num2 * 1257989028);
					continue;
				}
				case 68u:
					flag6 = true;
					num = ((int)num2 * -1285900580) ^ 0x67ACD47C;
					continue;
				case 67u:
				{
					int num29;
					int num30;
					if (!flag12)
					{
						num29 = -1803983703;
						num30 = -1803983703;
					}
					else
					{
						num29 = -1838108159;
						num30 = -1838108159;
					}
					num = num29 ^ ((int)num2 * -91222836);
					continue;
				}
				case 66u:
					flag9 = num15 == playerIndex;
					num = -2015647762;
					continue;
				case 65u:
					playerState = _playerStates[playerIndex];
					num = (int)((num2 * 352123170) ^ 0x64FF15C3);
					continue;
				case 64u:
					num = -1880608320;
					continue;
				case 63u:
					num = (int)((num2 * 907354659) ^ 0x4E5AFA86);
					continue;
				case 62u:
					num = -699711528;
					continue;
				case 61u:
					Print(playerState.State);
					num = ((int)num2 * -2026687124) ^ 0x9A58947;
					continue;
				case 60u:
					flag4 = playerState.Sprint < 0;
					num = -1784932477;
					continue;
				case 59u:
					num = (int)(num2 * 1984814456) ^ -8745535;
					continue;
				case 58u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag ? "ALL " : "", flag5 ? "receives" : "pays", Game.smethod_4(num14), flag6 ? "advance" : "stay");
					num = -1466966155;
					continue;
				case 57u:
					Losers.Add(num16);
					num = (int)(num2 * 9015587) ^ -1092293068;
					continue;
				case 56u:
					flag3 = playerState.State != State.Playing;
					num = (int)((num2 * 568242712) ^ 0x5714B253);
					continue;
				case 55u:
					num = -1982616388;
					continue;
				case 54u:
				{
					int num7;
					int num8;
					if (playerState.Resources >= 0)
					{
						num7 = 535587987;
						num8 = 535587987;
					}
					else
					{
						num7 = 1145681488;
						num8 = 1145681488;
					}
					num = num7 ^ ((int)num2 * -247687507);
					continue;
				}
				case 53u:
					num = (int)(num2 * 795105646) ^ -43263680;
					continue;
				case 52u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 461112521) ^ 0x5D73A87A);
					continue;
				case 51u:
					num16++;
					num = -72320794;
					continue;
				case 50u:
				{
					int num33;
					int num34;
					if (!flag7)
					{
						num33 = -1984778330;
						num34 = -1984778330;
					}
					else
					{
						num33 = -882744253;
						num34 = -882744253;
					}
					num = num33 ^ ((int)num2 * -671745525);
					continue;
				}
				case 49u:
				{
					int num31;
					int num32;
					if (!flag8)
					{
						num31 = -197239099;
						num32 = -197239099;
					}
					else
					{
						num31 = -798889089;
						num32 = -798889089;
					}
					num = num31 ^ ((int)num2 * -1683624089);
					continue;
				}
				case 48u:
					Print("Still planning");
					num = (int)((num2 * 531469462) ^ 0x23DE09C8);
					continue;
				case 47u:
				{
					playerState2.State = State.Lose;
					int num28;
					if (!Losers.Contains(num16))
					{
						num = -2106506372;
						num28 = -2106506372;
					}
					else
					{
						num = -2116277613;
						num28 = -2116277613;
					}
					continue;
				}
				case 46u:
					num = -1735062788;
					continue;
				case 45u:
					num16 = 0;
					num = (int)((num2 * 568833636) ^ 0x62D3F3B2);
					continue;
				case 44u:
					flag6 = false;
					num = -360489993;
					continue;
				case 43u:
					flag12 = num16 < _playerStates.Length;
					num = -499280156;
					continue;
				case 42u:
					num = (int)((num2 * 292008639) ^ 0x585152FF);
					continue;
				case 41u:
					num = ((int)num2 * -855782615) ^ 0x518525F6;
					continue;
				case 40u:
				{
					int num26;
					int num27;
					if (flag11)
					{
						num26 = 23792123;
						num27 = 23792123;
					}
					else
					{
						num26 = 1612720217;
						num27 = 1612720217;
					}
					num = num26 ^ ((int)num2 * -1025309597);
					continue;
				}
				case 39u:
					card = DrawCard();
					num = ((int)num2 * -341102131) ^ 0x391CECF2;
					continue;
				case 38u:
					flag6 = true;
					num14 = card.Impact;
					num = ((int)num2 * -721186851) ^ 0x69176C4D;
					continue;
				case 37u:
					player = Players[playerIndex];
					num = (int)((num2 * 1874219713) ^ 0x47D71689);
					continue;
				case 36u:
					num = (int)(num2 * 920753193) ^ -814778081;
					continue;
				case 34u:
					playerState.State = State.Lose;
					num = (int)(num2 * 1535783889) ^ -1258867613;
					continue;
				case 33u:
				{
					int num25;
					if (!Losers.Contains(num15))
					{
						num = -1258708451;
						num25 = -1258708451;
					}
					else
					{
						num = -726990500;
						num25 = -726990500;
					}
					continue;
				}
				case 32u:
					num21 = card.Impact - player.PlannedForCard(card.Type);
					flag6 = num21 < Rules.StayOnSprintMinDiff;
					num = (int)(num2 * 1168461320) ^ -880840750;
					continue;
				case 31u:
				{
					int num24;
					if (playerState.Sprint > Rules.SprintCount)
					{
						num = -413453989;
						num24 = -413453989;
					}
					else
					{
						num = -1982616388;
						num24 = -1982616388;
					}
					continue;
				}
				case 30u:
					flag10 = playerState2.Resources >= 0;
					num = ((int)num2 * -1326105328) ^ -2032366696;
					continue;
				case 29u:
					num = (int)((num2 * 491191269) ^ 0x63A5B6BC);
					continue;
				case 28u:
					num = ((int)num2 * -613562506) ^ 0x78EFD84D;
					continue;
				case 27u:
				{
					int num22;
					int num23;
					if (flag9)
					{
						num22 = -106695224;
						num23 = -106695224;
					}
					else
					{
						num22 = -1044819552;
						num23 = -1044819552;
					}
					num = num22 ^ ((int)num2 * -615856308);
					continue;
				}
				case 26u:
					playerState2 = _playerStates[num16];
					num = -891418028;
					continue;
				case 25u:
					num14 = Game.smethod_3(0, num21);
					num = ((int)num2 * -387012022) ^ -1675513522;
					continue;
				case 24u:
					playerState.State = State.Won;
					num = ((int)num2 * -132307075) ^ 0x6A335889;
					continue;
				case 23u:
					Print("CARD: none, advance");
					num = (int)((num2 * 716755319) ^ 0x676A8A00);
					continue;
				case 22u:
					num = ((int)num2 * -1736147790) ^ 0x37CFC4AE;
					continue;
				case 21u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -1433266199;
					continue;
				}
				case 20u:
					Losers.Add(num15);
					num = ((int)num2 * -1430401366) ^ 0x737CDD2E;
					continue;
				case 19u:
					playerState.Resources -= num14;
					num = (int)((num2 * 1794139005) ^ 0x733E6E9A);
					continue;
				case 18u:
					num = ((int)num2 * -761347980) ^ -1728464775;
					continue;
				case 17u:
					num15++;
					num = -769666818;
					continue;
				case 16u:
					num = -1740187838;
					continue;
				case 15u:
					playerState2.Resources -= Game.smethod_3(0, num14 - Players[num16].PlannedForCard(card.Type));
					num = (int)((num2 * 1855183065) ^ 0x55638C82);
					continue;
				case 14u:
					num = -876215819;
					continue;
				case 13u:
					flag2 = !flag5;
					num = (int)(num2 * 354764028) ^ -284648477;
					continue;
				case 12u:
				{
					int num17;
					int num18;
					if (flag3)
					{
						num17 = -1192338630;
						num18 = -1192338630;
					}
					else
					{
						num17 = -2136406975;
						num18 = -2136406975;
					}
					num = num17 ^ ((int)num2 * -1339575793);
					continue;
				}
				case 11u:
					flag8 = flag6;
					num = -1513328998;
					continue;
				case 10u:
					flag7 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -1706539259;
					continue;
				case 9u:
					num = ((int)num2 * -720400430) ^ -1401486154;
					continue;
				case 8u:
				{
					int num12;
					int num13;
					if (flag4)
					{
						num12 = 333351494;
						num13 = 333351494;
					}
					else
					{
						num12 = 1159881223;
						num13 = 1159881223;
					}
					num = num12 ^ (int)(num2 * 235548031);
					continue;
				}
				case 7u:
					num = ((int)num2 * -692680062) ^ 0x7887CBD7;
					continue;
				case 5u:
					num = (int)((num2 * 620531069) ^ 0x382AC31B);
					continue;
				case 4u:
					num11 = ((card.Type == 4) ? 1 : 0);
					goto IL_0046;
				case 3u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -358219377) ^ 0x38419CA2;
					continue;
				case 2u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1670537867;
						num10 = 1670537867;
					}
					else
					{
						num9 = 1478074665;
						num10 = 1478074665;
					}
					num = num9 ^ (int)(num2 * 1726617512);
					continue;
				}
				case 1u:
					num = -2117283876;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -435208406;
						num4 = -435208406;
					}
					else
					{
						num3 = -788146301;
						num4 = -788146301;
					}
					num = num3 ^ (int)(num2 * 1253783127);
					continue;
				}
				default:
					return;
				case 35u:
					break;
				case 6u:
					return;
					IL_0046:
					flag = (byte)num11 != 0;
					num = -143880036;
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1999670167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC0C8971u) % 10u)
				{
				case 9u:
					result = card;
					num = (int)((num2 * 1435645387) ^ 0x4B0094AC);
					continue;
				case 8u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -62627428) ^ 0x29D2B96E;
					continue;
				case 6u:
					ShuffleCards();
					num = (int)(num2 * 171636652) ^ -1170819641;
					continue;
				case 5u:
					card = _deck[0];
					num = -1186736298;
					continue;
				case 4u:
					num = (int)(num2 * 629028135) ^ -685202716;
					continue;
				case 3u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 531381754) ^ 0x6C45082A);
					continue;
				case 2u:
					num = (int)((num2 * 804947422) ^ 0x582A2032);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -62974202;
						num4 = -62974202;
					}
					else
					{
						num3 = -1924610331;
						num4 = -1924610331;
					}
					num = num3 ^ (int)(num2 * 1726725725);
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
		string text = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 643083553;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x245BDAE7u) % 9u)
				{
				case 7u:
					text = "";
					num = ((int)num2 * -1819233623) ^ 0x38F16A3;
					continue;
				case 6u:
					num = (int)((num2 * 966309154) ^ 0x2AFF11B7);
					continue;
				case 5u:
					num3++;
					num = (int)((num2 * 136444280) ^ 0x4D39650);
					continue;
				case 4u:
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
					num = 1043537564;
					continue;
				}
				case 3u:
					result = text;
					num = ((int)num2 * -1872035802) ^ 0x25D9791F;
					continue;
				case 2u:
				{
					int num4;
					if (num3 < _playerStates.Length)
					{
						num = 267978098;
						num4 = 267978098;
					}
					else
					{
						num = 2066621273;
						num4 = 2066621273;
					}
					continue;
				}
				case 1u:
					num3 = 0;
					num = ((int)num2 * -683258716) ^ -1899102736;
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
			int num = 1307326620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63E282B1u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -2093352461) ^ 0x7B481340;
					continue;
				case 1u:
					result = ToString(initial: false);
					num = (int)(num2 * 1647448020) ^ -1771063001;
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
