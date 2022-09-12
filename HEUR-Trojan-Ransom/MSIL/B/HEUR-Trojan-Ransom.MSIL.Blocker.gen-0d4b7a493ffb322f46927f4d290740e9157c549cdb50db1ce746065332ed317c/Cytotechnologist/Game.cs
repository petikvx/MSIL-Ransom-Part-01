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
			int num3 = default(int);
			bool finished = default(bool);
			PlayerState[] playerStates = default(PlayerState[]);
			bool flag = default(bool);
			while (true)
			{
				int num = 1503598109;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3DC41E05u) % 14u)
					{
					case 12u:
						result = true;
						num = ((int)num2 * -753990430) ^ 0x79F8C9C;
						continue;
					case 10u:
						num3++;
						num = 1322263175;
						continue;
					case 9u:
					{
						int num7;
						int num8;
						if (finished)
						{
							num7 = 41723947;
							num8 = 41723947;
						}
						else
						{
							num7 = 679803387;
							num8 = 679803387;
						}
						num = num7 ^ ((int)num2 * -873212036);
						continue;
					}
					case 8u:
						playerStates = _playerStates;
						num = 959540470;
						continue;
					case 7u:
						result = false;
						num = (int)((num2 * 2043427349) ^ 0x6FA3EE73);
						continue;
					case 6u:
					{
						PlayerState playerState = playerStates[num3];
						flag = playerState.State == State.Playing;
						num = 576870060;
						continue;
					}
					case 5u:
						result = true;
						num = ((int)num2 * -1932043532) ^ -72928180;
						continue;
					case 4u:
						num = ((int)num2 * -103962553) ^ -254072061;
						continue;
					case 3u:
						num3 = 0;
						num = (int)((num2 * 1341611729) ^ 0x3D69FC3A);
						continue;
					case 2u:
						finished = _finished;
						num = (int)((num2 * 546408319) ^ 0x69EE6CF2);
						continue;
					case 1u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 595241437;
							num6 = 595241437;
						}
						else
						{
							num5 = 1343417002;
							num6 = 1343417002;
						}
						num = num5 ^ (int)(num2 * 532842687);
						continue;
					}
					case 0u:
					{
						int num4;
						if (num3 < playerStates.Length)
						{
							num = 1452334313;
							num4 = 1452334313;
						}
						else
						{
							num = 1518205376;
							num4 = 1518205376;
						}
						continue;
					}
					case 13u:
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
			int num = -370250332;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DE5BDD6u) % 5u)
				{
				case 4u:
					_finished = false;
					_currentChanceIndex = -1;
					num = ((int)num2 * -997481152) ^ -1706913719;
					continue;
				case 3u:
					ShuffleCards();
					Winners.Clear();
					num = ((int)num2 * -1422401170) ^ -1580490885;
					continue;
				case 2u:
					Losers.Clear();
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					num = ((int)num2 * -1334573076) ^ -551560675;
					continue;
				case 0u:
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
		int num = 0;
		PlayerState playerState = default(PlayerState);
		bool flag = default(bool);
		bool useOneMorePlanningSprint = default(bool);
		int planningCardsCount = default(int);
		int num9 = default(int);
		Player player = default(Player);
		while (true)
		{
			int num2 = 1987969063;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x5A4B36EBu) % 21u)
				{
				case 20u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -425329492) ^ 0x28F51497;
					continue;
				case 19u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1525424323;
						num8 = 1525424323;
					}
					else
					{
						num7 = 1416531008;
						num8 = 1416531008;
					}
					num2 = num7 ^ (int)(num3 * 633743602);
					continue;
				}
				case 18u:
					num2 = ((int)num3 * -1194022962) ^ 0x302BDEDC;
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (!useOneMorePlanningSprint)
					{
						num5 = 2004453017;
						num6 = 2004453017;
					}
					else
					{
						num5 = 1663279061;
						num6 = 1663279061;
					}
					num2 = num5 ^ (int)(num3 * 1649564741);
					continue;
				}
				case 16u:
					flag = planningCardsCount == 0;
					num2 = ((int)num3 * -2026043699) ^ 0x54F8F8D;
					continue;
				case 15u:
					num2 = 2045784242;
					continue;
				case 14u:
					num2 = (int)(num3 * 615443068) ^ -1863674286;
					continue;
				case 13u:
					playerState.Sprint = -1;
					playerState.Resources -= num9 * Rules.NormalPlanningCost;
					num2 = (int)((num3 * 11748816) ^ 0x1A01F995);
					continue;
				case 12u:
					player = Players[num];
					playerState = _playerStates[num];
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num9 = 0;
					num2 = 200024539;
					continue;
				case 11u:
					playerState.Resources -= (planningCardsCount - num9) * Rules.NormalPlanningCost;
					num2 = 1625605873;
					continue;
				case 10u:
					num2 = ((int)num3 * -1378860744) ^ -196568178;
					continue;
				case 9u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num2 = ((int)num3 * -1137128727) ^ 0x3D8D0BE9;
					continue;
				case 8u:
					num9 = 0;
					num2 = 499986328;
					continue;
				case 7u:
					playerState.Resources -= num9 * Rules.OverPlanningCost;
					num2 = (int)((num3 * 1120554703) ^ 0x24C663EC);
					continue;
				case 5u:
					num9 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = 1857843720;
					continue;
				case 4u:
					num2 = ((int)num3 * -512433388) ^ 0x17E26DB0;
					continue;
				case 2u:
				{
					int num10;
					if (num9 > 0)
					{
						num2 = 1697858560;
						num10 = 1697858560;
					}
					else
					{
						num2 = 187129570;
						num10 = 187129570;
					}
					continue;
				}
				case 1u:
					num++;
					num2 = (int)(num3 * 575274409) ^ -304324604;
					continue;
				case 0u:
				{
					int num4;
					if (num >= Players.Length)
					{
						num2 = 1611135584;
						num4 = 1611135584;
					}
					else
					{
						num2 = 1416181260;
						num4 = 1416181260;
					}
					continue;
				}
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

	public void TurnState()
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -935521868;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1553C81u) % 16u)
				{
				case 15u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 284636526) ^ -447015520;
					continue;
				case 14u:
					_currentPlayer = 0;
					num = ((int)num2 * -773501363) ^ -381810081;
					continue;
				case 13u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -505973837;
					continue;
				case 12u:
					PlayerTurn(_currentPlayer);
					num = -678461397;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1800908122;
						num6 = -1800908122;
					}
					else
					{
						num5 = -1924990156;
						num6 = -1924990156;
					}
					num = num5 ^ (int)(num2 * 832912379);
					continue;
				}
				case 10u:
					num = ((int)num2 * -1789864289) ^ 0xB7950C0;
					continue;
				case 9u:
					flag2 = _currentPlayer >= Players.Length;
					num = ((int)num2 * -1010767453) ^ -268292127;
					continue;
				case 8u:
					flag = _currentTurn > 0;
					num = ((int)num2 * -1393882347) ^ -1702561671;
					continue;
				case 6u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1894850751) ^ 0x390625CA;
					continue;
				case 5u:
					_currentPlayer++;
					num = ((int)num2 * -1718116861) ^ 0x6BCF0D37;
					continue;
				case 3u:
					num = ((int)num2 * -2086900843) ^ -1540342081;
					continue;
				case 2u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)(num2 * 1787839838) ^ -1807456302;
					continue;
				case 1u:
					num = (int)(num2 * 1022049029) ^ -1131603816;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1418461959;
						num4 = 1418461959;
					}
					else
					{
						num3 = 308462028;
						num4 = 308462028;
					}
					num = num3 ^ ((int)num2 * -1848188276);
					continue;
				}
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
		bool flag8 = default(bool);
		int num5 = default(int);
		bool flag9 = default(bool);
		Card card = default(Card);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		int num12 = default(int);
		int num32 = default(int);
		Player player = default(Player);
		bool flag11 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag14 = default(bool);
		int num13 = default(int);
		bool flag7 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag = default(bool);
		bool flag6 = default(bool);
		bool flag3 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag13 = default(bool);
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1513778733;
			while (true)
			{
				uint num2;
				int num31;
				switch ((num2 = (uint)num ^ 0x9905CD76u) % 82u)
				{
				case 81u:
					num = (int)(num2 * 1062475752) ^ -1241080685;
					continue;
				case 80u:
					flag8 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -488927359;
					continue;
				case 79u:
					Losers.Add(num5);
					num = (int)((num2 * 816850716) ^ 0x16F0E468);
					continue;
				case 78u:
					flag9 = false;
					num = -1086156445;
					continue;
				case 77u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag12 ? "ALL " : "", flag10 ? "receives" : "pays", Game.smethod_4(num12), flag9 ? "advance" : "stay");
					num = -1805760798;
					continue;
				case 76u:
					num = -2010286703;
					continue;
				case 75u:
					num32 = card.Impact - player.PlannedForCard(card.Type);
					num = ((int)num2 * -360521876) ^ -1639454711;
					continue;
				case 74u:
					num = (int)(num2 * 264848568) ^ -1305164283;
					continue;
				case 73u:
					num = ((int)num2 * -963179851) ^ -2080909538;
					continue;
				case 72u:
					num5++;
					num = -201196132;
					continue;
				case 71u:
					num = ((int)num2 * -478749372) ^ -1073477449;
					continue;
				case 70u:
					flag11 = num5 < _playerStates.Length;
					num = -816417908;
					continue;
				case 69u:
				{
					int num8;
					int num9;
					if (onlyOneWinner)
					{
						num8 = -1737355420;
						num9 = -1737355420;
					}
					else
					{
						num8 = -2121814361;
						num9 = -2121814361;
					}
					num = num8 ^ ((int)num2 * -1264838127);
					continue;
				}
				case 68u:
				{
					int num37;
					int num38;
					if (flag14)
					{
						num37 = -427254645;
						num38 = -427254645;
					}
					else
					{
						num37 = -944135721;
						num38 = -944135721;
					}
					num = num37 ^ (int)(num2 * 1856075251);
					continue;
				}
				case 67u:
					num5 = 0;
					num = -591005479;
					continue;
				case 66u:
					num13 = 0;
					num = (int)((num2 * 1247171565) ^ 0x2E3262EC);
					continue;
				case 65u:
				{
					int num33;
					int num34;
					if (!flag8)
					{
						num33 = 856945631;
						num34 = 856945631;
					}
					else
					{
						num33 = 843617505;
						num34 = 843617505;
					}
					num = num33 ^ ((int)num2 * -665124908);
					continue;
				}
				case 64u:
					flag7 = playerState.Sprint < 0;
					num = -1693381403;
					continue;
				case 63u:
					num13++;
					num = -466298918;
					continue;
				case 62u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)(num2 * 2030090047) ^ -1416264014;
					continue;
				case 61u:
					num = ((int)num2 * -16307133) ^ -381434184;
					continue;
				case 60u:
					num = ((int)num2 * -1747823310) ^ 0x6CDE9558;
					continue;
				case 59u:
					num12 = card.Impact;
					num = (int)(num2 * 2074051981) ^ -1655094268;
					continue;
				case 58u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)(num2 * 1323511955) ^ -1455289509;
					continue;
				case 57u:
					num = -931845558;
					continue;
				case 56u:
					num = ((int)num2 * -275842593) ^ -1473001750;
					continue;
				case 54u:
				{
					int num21;
					int num22;
					if (!flag)
					{
						num21 = 1255627622;
						num22 = 1255627622;
					}
					else
					{
						num21 = 129770677;
						num22 = 129770677;
					}
					num = num21 ^ (int)(num2 * 952433613);
					continue;
				}
				case 53u:
					num = ((int)num2 * -205070697) ^ 0x3CC95D61;
					continue;
				case 52u:
				{
					int num16;
					int num17;
					if (flag6)
					{
						num16 = -2130044439;
						num17 = -2130044439;
					}
					else
					{
						num16 = -873243950;
						num17 = -873243950;
					}
					num = num16 ^ (int)(num2 * 585004193);
					continue;
				}
				case 51u:
					num = ((int)num2 * -1360973039) ^ 0x1B681402;
					continue;
				case 50u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -1147747867;
						num11 = -1147747867;
					}
					else
					{
						num10 = -447851781;
						num11 = -447851781;
					}
					num = num10 ^ ((int)num2 * -900809928);
					continue;
				}
				case 49u:
					num = ((int)num2 * -2106927058) ^ -1994389519;
					continue;
				case 48u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)((num2 * 1622902901) ^ 0x4706E687);
					continue;
				case 47u:
					playerState2.State = State.Lose;
					flag = !Losers.Contains(num5);
					num = -2067780500;
					continue;
				case 46u:
					num = ((int)num2 * -789001486) ^ -1727327848;
					continue;
				case 45u:
					flag9 = num32 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -583153075) ^ -1790691358;
					continue;
				case 44u:
					num = -1708715740;
					continue;
				case 43u:
					num12 = Game.smethod_3(0, num32);
					num = (int)(num2 * 351703471) ^ -1859910180;
					continue;
				case 42u:
					Losers.Add(num13);
					num = (int)((num2 * 419908661) ^ 0x4B83AE28);
					continue;
				case 41u:
					num = -1311235123;
					continue;
				case 40u:
					playerState.Sprint++;
					num = (int)((num2 * 184040440) ^ 0x57A361BC);
					continue;
				case 39u:
					num = ((int)num2 * -900667849) ^ 0x47AF0296;
					continue;
				case 38u:
					flag6 = playerState.State != State.Playing;
					num = ((int)num2 * -1190353739) ^ -572159978;
					continue;
				case 37u:
					_finished = true;
					num = ((int)num2 * -412500330) ^ -1923559814;
					continue;
				case 36u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -1908026440) ^ -1259708171;
						continue;
					}
					num31 = 0;
					goto IL_04fa;
				case 35u:
					flag9 = true;
					num = -1860284829;
					continue;
				case 34u:
					flag14 = num13 < _playerStates.Length;
					num = -745725354;
					continue;
				case 32u:
				{
					int num35;
					int num36;
					if (flag13)
					{
						num35 = -308607104;
						num36 = -308607104;
					}
					else
					{
						num35 = -631668836;
						num36 = -631668836;
					}
					num = num35 ^ (int)(num2 * 557557562);
					continue;
				}
				case 31u:
					playerState.Resources -= num12;
					flag3 = playerState.Resources < 0;
					num = (int)((num2 * 1815359255) ^ 0x3F30BEE7);
					continue;
				case 30u:
					flag5 = playerState.Sprint > Rules.SprintCount;
					num = -1039230356;
					continue;
				case 29u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -1494971989;
					continue;
				}
				case 28u:
					num = ((int)num2 * -1435133174) ^ 0x66EAD6D;
					continue;
				case 27u:
					num = ((int)num2 * -1135209546) ^ 0x2796A602;
					continue;
				case 26u:
					flag13 = flag9;
					num = -1792374226;
					continue;
				case 25u:
					num = (int)((num2 * 785960952) ^ 0x2072BCB0);
					continue;
				case 24u:
					card = DrawCard();
					flag10 = card.Impact < 0;
					num = ((int)num2 * -1216853560) ^ -871970308;
					continue;
				case 23u:
					num31 = ((card.Type == 4) ? 1 : 0);
					goto IL_04fa;
				case 22u:
				{
					int num29;
					int num30;
					if (flag12)
					{
						num29 = -456749801;
						num30 = -456749801;
					}
					else
					{
						num29 = -343443837;
						num30 = -343443837;
					}
					num = num29 ^ ((int)num2 * -489518784);
					continue;
				}
				case 21u:
					num = (int)((num2 * 191706062) ^ 0x4851B95C);
					continue;
				case 20u:
					num = -970375488;
					continue;
				case 19u:
				{
					int num27;
					int num28;
					if (flag4)
					{
						num27 = 1074310307;
						num28 = 1074310307;
					}
					else
					{
						num27 = 2031407788;
						num28 = 2031407788;
					}
					num = num27 ^ ((int)num2 * -87398176);
					continue;
				}
				case 18u:
				{
					int num25;
					int num26;
					if (!flag11)
					{
						num25 = 356548196;
						num26 = 356548196;
					}
					else
					{
						num25 = 173599858;
						num26 = 173599858;
					}
					num = num25 ^ (int)(num2 * 1802249364);
					continue;
				}
				case 17u:
					num = (int)(num2 * 1846124246) ^ -252436522;
					continue;
				case 16u:
				{
					int num23;
					int num24;
					if (flag10)
					{
						num23 = -1541484647;
						num24 = -1541484647;
					}
					else
					{
						num23 = -775603211;
						num24 = -775603211;
					}
					num = num23 ^ ((int)num2 * -1450081474);
					continue;
				}
				case 15u:
					flag9 = true;
					Print("CARD: none, advance");
					num = (int)((num2 * 2141099895) ^ 0x776E30DB);
					continue;
				case 14u:
					Print(playerState.State);
					num = (int)((num2 * 989828061) ^ 0x3045B55);
					continue;
				case 13u:
					playerState = _playerStates[playerIndex];
					num = ((int)num2 * -292292366) ^ -271648542;
					continue;
				case 12u:
				{
					int num20;
					if (!Losers.Contains(num13))
					{
						num = -1972724116;
						num20 = -1972724116;
					}
					else
					{
						num = -1444003254;
						num20 = -1444003254;
					}
					continue;
				}
				case 11u:
					num = -281931516;
					continue;
				case 10u:
					num = -2029519973;
					continue;
				case 9u:
				{
					int num18;
					int num19;
					if (!flag7)
					{
						num18 = -458844019;
						num19 = -458844019;
					}
					else
					{
						num18 = -1084777293;
						num19 = -1084777293;
					}
					num = num18 ^ ((int)num2 * -54125251);
					continue;
				}
				case 8u:
				{
					int num14;
					int num15;
					if (!flag5)
					{
						num14 = -1140714387;
						num15 = -1140714387;
					}
					else
					{
						num14 = -414750535;
						num15 = -414750535;
					}
					num = num14 ^ ((int)num2 * -481388938);
					continue;
				}
				case 7u:
					player = Players[playerIndex];
					num = ((int)num2 * -1770956451) ^ 0x40B41322;
					continue;
				case 6u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1453617313) ^ -1210878972;
					continue;
				case 5u:
					flag4 = num13 == playerIndex;
					num = -360636181;
					continue;
				case 4u:
					playerState2 = _playerStates[num5];
					playerState2.Resources -= Game.smethod_3(0, num12 - Players[num5].PlannedForCard(card.Type));
					flag2 = playerState2.Resources >= 0;
					num = (int)(num2 * 1323760903) ^ -2111674430;
					continue;
				case 3u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -1692775230) ^ 0xE91155E;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -1885619781;
						num7 = -1885619781;
					}
					else
					{
						num6 = -1060969971;
						num7 = -1060969971;
					}
					num = num6 ^ ((int)num2 * -2094227074);
					continue;
				}
				case 1u:
				{
					playerState.State = State.Lose;
					int num3;
					int num4;
					if (Losers.Contains(playerIndex))
					{
						num3 = 1953779516;
						num4 = 1953779516;
					}
					else
					{
						num3 = 1217303512;
						num4 = 1217303512;
					}
					num = num3 ^ ((int)num2 * -1232697396);
					continue;
				}
				case 0u:
					num = ((int)num2 * -691045791) ^ 0x2CEAD1AC;
					continue;
				default:
					return;
				case 33u:
					break;
				case 55u:
					return;
					IL_04fa:
					flag12 = (byte)num31 != 0;
					num = -938619408;
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
			int num = 38705767;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A5CCC16u) % 7u)
				{
				case 6u:
					result = card;
					num = ((int)num2 * -530642305) ^ 0x3B7C4995;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 119417750;
						num4 = 119417750;
					}
					else
					{
						num3 = 1268182356;
						num4 = 1268182356;
					}
					num = num3 ^ ((int)num2 * -728237277);
					continue;
				}
				case 4u:
					ShuffleCards();
					num = ((int)num2 * -1821905134) ^ 0x72F4E531;
					continue;
				case 3u:
					_deck.RemoveAt(0);
					num = (int)(num2 * 1029770464) ^ -1681454928;
					continue;
				case 2u:
					card = _deck[0];
					num = 2195549;
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

	public string ToString(bool initial)
	{
		string text = default(string);
		string result = default(string);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1055358354;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x491FC060u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -377941923) ^ 0x6C439776;
					continue;
				case 8u:
					text = "";
					num = (int)(num2 * 1814087259) ^ -1869149028;
					continue;
				case 6u:
					result = text;
					num = ((int)num2 * -1909581816) ^ -861518085;
					continue;
				case 5u:
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
					num = 472674690;
					continue;
				}
				case 4u:
					num3++;
					num = ((int)num2 * -1826001866) ^ 0x3FCF73C5;
					continue;
				case 3u:
					flag = num3 < _playerStates.Length;
					num = 1981560704;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1435053558;
						num5 = 1435053558;
					}
					else
					{
						num4 = 1308578295;
						num5 = 1308578295;
					}
					num = num4 ^ ((int)num2 * -1896509686);
					continue;
				}
				case 0u:
					num3 = 0;
					num = ((int)num2 * -566792958) ^ 0x3879C39D;
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
			int num = -1845528190;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF37F145Cu) % 4u)
				{
				case 2u:
					result = ToString(initial: false);
					num = (int)((num2 * 1026731042) ^ 0x276E83F9);
					continue;
				case 1u:
					num = ((int)num2 * -1696212866) ^ 0x46EF6086;
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
			int num = -2105818253;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBEAD5D79u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					Game.smethod_8(_buffer, string_);
					return;
				}
				break;
				IL_0003:
				string_ = Game.smethod_7(Game.smethod_5(text), more);
				num = ((int)num2 * -1820347208) ^ 0x7D93F938;
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
