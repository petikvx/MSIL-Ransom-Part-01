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
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool result = default(bool);
			while (true)
			{
				int num = -280064124;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA437C180u) % 14u)
					{
					case 13u:
					{
						PlayerState playerState = playerStates[num3];
						int num5;
						if (playerState.State == State.Playing)
						{
							num = -846093027;
							num5 = -846093027;
						}
						else
						{
							num = -2021374803;
							num5 = -2021374803;
						}
						continue;
					}
					case 12u:
						result = true;
						num = ((int)num2 * -738542320) ^ 0x4EE30804;
						continue;
					case 11u:
						num3++;
						num = -180787513;
						continue;
					case 10u:
					{
						int num6;
						int num7;
						if (!finished)
						{
							num6 = 1527099319;
							num7 = 1527099319;
						}
						else
						{
							num6 = 1133683934;
							num7 = 1133683934;
						}
						num = num6 ^ ((int)num2 * -383108333);
						continue;
					}
					case 9u:
						num = ((int)num2 * -1116854170) ^ 0x3A175A98;
						continue;
					case 8u:
						num = ((int)num2 * -78873089) ^ -818508742;
						continue;
					case 7u:
						result = false;
						num = (int)(num2 * 1527092525) ^ -1133333699;
						continue;
					case 5u:
						playerStates = _playerStates;
						num3 = 0;
						num = ((int)num2 * -919066027) ^ 0x7DCB248;
						continue;
					case 3u:
						num = -369660205;
						continue;
					case 2u:
						result = true;
						num = ((int)num2 * -1894229762) ^ -1821783303;
						continue;
					case 1u:
					{
						int num4;
						if (num3 >= playerStates.Length)
						{
							num = -780809034;
							num4 = -780809034;
						}
						else
						{
							num = -1365175043;
							num4 = -1365175043;
						}
						continue;
					}
					case 0u:
						num = (int)(num2 * 2021273592) ^ -2085380666;
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		int num4 = default(int);
		int count = default(int);
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 529625407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EF11DA8u) % 14u)
				{
				case 13u:
					num = (int)((num2 * 1545488251) ^ 0x22C1722A);
					continue;
				case 12u:
					num4 = 0;
					num = (int)((num2 * 472871927) ^ 0x60D7CD78);
					continue;
				case 11u:
					_buffer = buffer;
					num = ((int)num2 * -1425347197) ^ 0x6B29F31D;
					continue;
				case 10u:
					num4++;
					num = ((int)num2 * -1732990475) ^ 0x65E018C0;
					continue;
				case 8u:
				{
					int num6;
					if (num4 < count)
					{
						num = 1660397280;
						num6 = 1660397280;
					}
					else
					{
						num = 1925512883;
						num6 = 1925512883;
					}
					continue;
				}
				case 7u:
					num3++;
					num = ((int)num2 * -363682647) ^ 0x2BCE69A8;
					continue;
				case 6u:
					count = jSONNode.Count;
					Players = new Player[count];
					num3 = 0;
					num = ((int)num2 * -133741390) ^ 0x2F3688C9;
					continue;
				case 5u:
				{
					int num5;
					if (num3 < count)
					{
						num = 1977972676;
						num5 = 1977972676;
					}
					else
					{
						num = 1790385659;
						num5 = 1790385659;
					}
					continue;
				}
				case 4u:
					_playerStates[num4] = new PlayerState();
					num = 380678164;
					continue;
				case 3u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -352556094) ^ -1673459198;
					continue;
				case 2u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					_dice = new Dice();
					jSONNode = json["players"];
					num = ((int)num2 * -1284674318) ^ -343729248;
					continue;
				case 0u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = 2114758145;
					continue;
				default:
					return;
				case 9u:
					break;
				case 1u:
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
			int num = -2090700266;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA069CC3u) % 3u)
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
				_deck = new List<Card>(Rules.Cards);
				num = (int)((num2 * 1127195567) ^ 0x19693E4D);
			}
		}
	}

	public void StartNew()
	{
		while (true)
		{
			int num = -1985207604;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF19F396u) % 9u)
				{
				case 7u:
					ShuffleCards();
					num = (int)(num2 * 1242262111) ^ -1734054651;
					continue;
				case 6u:
					Winners.Clear();
					num = ((int)num2 * -50454929) ^ 0x42EBCCB7;
					continue;
				case 4u:
					Losers.Clear();
					num = (int)((num2 * 1430694984) ^ 0x1EB3855C);
					continue;
				case 3u:
					num = ((int)num2 * -1535816037) ^ -67333167;
					continue;
				case 2u:
					_currentTurn = 0;
					num = ((int)num2 * -2068348124) ^ 0x181215E0;
					continue;
				case 1u:
					_finished = false;
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -1076109369) ^ 0x178F83E;
					continue;
				case 0u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1754674503) ^ -1037906395;
					continue;
				default:
					return;
				case 5u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		PlayerState playerState = default(PlayerState);
		int num6 = default(int);
		int planningCardsCount = default(int);
		bool useOneMorePlanningSprint = default(bool);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		Player player = default(Player);
		while (true)
		{
			int num = 1424684200;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F6E1341u) % 29u)
				{
				case 28u:
					playerState.State = State.Playing;
					num = ((int)num2 * -1625708870) ^ -1456488786;
					continue;
				case 27u:
					num = ((int)num2 * -530967736) ^ 0x63802690;
					continue;
				case 26u:
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					num = ((int)num2 * -684201308) ^ -433995938;
					continue;
				case 25u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num = 1152380282;
					continue;
				case 24u:
					playerState.Sprint = -1;
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num = ((int)num2 * -1167516178) ^ -382495129;
					continue;
				case 23u:
				{
					int num9;
					int num10;
					if (useOneMorePlanningSprint)
					{
						num9 = 1124919587;
						num10 = 1124919587;
					}
					else
					{
						num9 = 662047244;
						num10 = 662047244;
					}
					num = num9 ^ ((int)num2 * -655927917);
					continue;
				}
				case 22u:
					num = (int)((num2 * 274931024) ^ 0x2E49CF80);
					continue;
				case 21u:
					num5 = 0;
					num = (int)(num2 * 229055813) ^ -232526443;
					continue;
				case 20u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num = ((int)num2 * -1664081870) ^ -1508428401;
					continue;
				case 19u:
					playerState.Resources = Rules.InitialResources;
					num = ((int)num2 * -989679883) ^ 0xA6FD9E6;
					continue;
				case 18u:
				{
					int num11;
					int num12;
					if (flag3)
					{
						num11 = -157842799;
						num12 = -157842799;
					}
					else
					{
						num11 = -2113196745;
						num12 = -2113196745;
					}
					num = num11 ^ ((int)num2 * -2064683849);
					continue;
				}
				case 17u:
					flag2 = num6 > 0;
					num = 961294909;
					continue;
				case 16u:
					flag = num5 < Players.Length;
					num = 1541274898;
					continue;
				case 15u:
					flag3 = planningCardsCount == 0;
					num = (int)(num2 * 1446710959) ^ -433639774;
					continue;
				case 14u:
					num = 1910936409;
					continue;
				case 13u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = (int)((num2 * 1842427159) ^ 0x70D820B5);
					continue;
				case 11u:
					num5++;
					num = ((int)num2 * -266529174) ^ -540089149;
					continue;
				case 10u:
					num = ((int)num2 * -1867564010) ^ 0x133807C7;
					continue;
				case 9u:
					planningCardsCount = player.PlanningCardsCount;
					num = (int)(num2 * 1962752609) ^ -310876727;
					continue;
				case 8u:
					num = (int)((num2 * 747911854) ^ 0x3EC1B853);
					continue;
				case 7u:
					num = 436618944;
					continue;
				case 5u:
					player = Players[num5];
					playerState = _playerStates[num5];
					playerState.Sprint = 0;
					num = 818528548;
					continue;
				case 4u:
					num6 = 0;
					num = 795843168;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 1771082433;
						num8 = 1771082433;
					}
					else
					{
						num7 = 1396041549;
						num8 = 1396041549;
					}
					num = num7 ^ (int)(num2 * 411445308);
					continue;
				}
				case 2u:
					num6 = 0;
					num = ((int)num2 * -535984025) ^ 0x2ED0C3A9;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 182138051;
						num4 = 182138051;
					}
					else
					{
						num3 = 469599991;
						num4 = 469599991;
					}
					num = num3 ^ ((int)num2 * -1528966121);
					continue;
				}
				case 0u:
					playerState.Sprint = 1;
					num = (int)((num2 * 69216417) ^ 0x7A4DBDD1);
					continue;
				default:
					return;
				case 6u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1517905985;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0350365u) % 11u)
				{
				case 10u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -2089674270;
					continue;
				case 9u:
				{
					_currentPlayer++;
					int num5;
					int num6;
					if (_currentPlayer < Players.Length)
					{
						num5 = 559053922;
						num6 = 559053922;
					}
					else
					{
						num5 = 1318249968;
						num6 = 1318249968;
					}
					num = num5 ^ (int)(num2 * 689307376);
					continue;
				}
				case 8u:
					num = ((int)num2 * -2089470613) ^ 0x19976561;
					continue;
				case 7u:
					flag = _currentTurn > 0;
					num = ((int)num2 * -1132029597) ^ -1860428333;
					continue;
				case 6u:
					_currentPlayer = 0;
					num = ((int)num2 * -1502802149) ^ -1456625026;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2063092480;
						num4 = -2063092480;
					}
					else
					{
						num3 = -1953876485;
						num4 = -1953876485;
					}
					num = num3 ^ (int)(num2 * 1931121858);
					continue;
				}
				case 3u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -496143324) ^ 0x23FBC70C;
					continue;
				case 2u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = ((int)num2 * -95143701) ^ 0x187A60D;
					continue;
				case 1u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -587764572) ^ 0x1CA52BB8;
					continue;
				case 4u:
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
		bool flag9 = default(bool);
		bool flag11 = default(bool);
		int num7 = default(int);
		Card card = default(Card);
		bool flag8 = default(bool);
		bool flag2 = default(bool);
		int num17 = default(int);
		bool flag6 = default(bool);
		int num24 = default(int);
		int num18 = default(int);
		PlayerState playerState = default(PlayerState);
		PlayerState playerState2 = default(PlayerState);
		bool flag10 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag12 = default(bool);
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = -1581229650;
			while (true)
			{
				uint num2;
				int num16;
				switch ((num2 = (uint)num ^ 0xC28DF29Eu) % 85u)
				{
				case 84u:
				{
					int num35;
					if (!flag9)
					{
						num = -1117960427;
						num35 = -1117960427;
					}
					else
					{
						num = -316144756;
						num35 = -316144756;
					}
					continue;
				}
				case 83u:
					flag11 = num7 == playerIndex;
					num = (int)(num2 * 1762193376) ^ -250542550;
					continue;
				case 81u:
					num = (int)((num2 * 1395905280) ^ 0xAE2C6C9);
					continue;
				case 80u:
					num7 = 0;
					num = ((int)num2 * -1339226289) ^ 0x629F5EB7;
					continue;
				case 79u:
					num = -1249416924;
					continue;
				case 78u:
					Losers.Add(num7);
					num = (int)((num2 * 2114134634) ^ 0x1DC30700);
					continue;
				case 77u:
				{
					int num27;
					int num28;
					if (flag11)
					{
						num27 = -504141993;
						num28 = -504141993;
					}
					else
					{
						num27 = -155272984;
						num28 = -155272984;
					}
					num = num27 ^ (int)(num2 * 615365179);
					continue;
				}
				case 76u:
					num16 = ((card.Type == 4) ? 1 : 0);
					goto IL_00cd;
				case 75u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag8 ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num17), flag9 ? "advance" : "stay");
					num = -2069301144;
					continue;
				case 74u:
				{
					int num10;
					int num11;
					if (!flag6)
					{
						num10 = 393510657;
						num11 = 393510657;
					}
					else
					{
						num10 = 1409203266;
						num11 = 1409203266;
					}
					num = num10 ^ ((int)num2 * -1052582447);
					continue;
				}
				case 73u:
					num = (int)((num2 * 1218436642) ^ 0x7F938249);
					continue;
				case 72u:
					num24 = 0;
					num = -370525419;
					continue;
				case 71u:
					num = -1952545874;
					continue;
				case 69u:
					Losers.Add(num24);
					num = ((int)num2 * -581720918) ^ 0x2580E0FC;
					continue;
				case 68u:
					num = (int)(num2 * 1279030654) ^ -884758482;
					continue;
				case 67u:
					num18 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)(num2 * 1069404540) ^ -676422448;
					continue;
				case 66u:
					num = ((int)num2 * -835219220) ^ -1374627041;
					continue;
				case 65u:
					num = -1238968431;
					continue;
				case 64u:
				{
					int num31;
					int num32;
					if (!flag8)
					{
						num31 = -520513486;
						num32 = -520513486;
					}
					else
					{
						num31 = -1211448202;
						num32 = -1211448202;
					}
					num = num31 ^ (int)(num2 * 318298508);
					continue;
				}
				case 63u:
					num = ((int)num2 * -344027610) ^ -1826489813;
					continue;
				case 62u:
					num = (int)(num2 * 1340957397) ^ -292235818;
					continue;
				case 61u:
					num = ((int)num2 * -1688763542) ^ 0x5C7C866E;
					continue;
				case 60u:
				{
					int num23;
					if (playerState.Sprint <= Rules.SprintCount)
					{
						num = -1249416924;
						num23 = -1249416924;
					}
					else
					{
						num = -1420724614;
						num23 = -1420724614;
					}
					continue;
				}
				case 59u:
					num = ((int)num2 * -1409893205) ^ -1326676084;
					continue;
				case 58u:
					playerState2 = _playerStates[num24];
					playerState2.Resources -= Game.smethod_3(0, num17 - Players[num24].PlannedForCard(card.Type));
					flag10 = playerState2.Resources >= 0;
					num = -612279490;
					continue;
				case 57u:
					num = (int)((num2 * 389150678) ^ 0x1D6E8C2B);
					continue;
				case 56u:
					flag9 = true;
					num = ((int)num2 * -1612606744) ^ 0x459439B2;
					continue;
				case 55u:
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 1851385181) ^ 0x7A183FEA);
					continue;
				case 54u:
				{
					int num12;
					int num13;
					if (playerState.State != 0)
					{
						num12 = -396775725;
						num13 = -396775725;
					}
					else
					{
						num12 = -980328227;
						num13 = -980328227;
					}
					num = num12 ^ (int)(num2 * 1977067886);
					continue;
				}
				case 53u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -819707823;
						num6 = -819707823;
					}
					else
					{
						num5 = -53812602;
						num6 = -53812602;
					}
					num = num5 ^ (int)(num2 * 34203750);
					continue;
				}
				case 52u:
				{
					int num36;
					int num37;
					if (flag3)
					{
						num36 = -770343935;
						num37 = -770343935;
					}
					else
					{
						num36 = -210788229;
						num37 = -210788229;
					}
					num = num36 ^ ((int)num2 * -323437499);
					continue;
				}
				case 51u:
					num24++;
					num = -534506784;
					continue;
				case 50u:
					card = DrawCard();
					num = (int)((num2 * 1950063878) ^ 0x1CAD4EC2);
					continue;
				case 49u:
					num = -944390811;
					continue;
				case 48u:
					num = ((int)num2 * -529320321) ^ -1417145169;
					continue;
				case 47u:
					num = -645576560;
					continue;
				case 46u:
					playerState.Sprint++;
					num = ((int)num2 * -316821566) ^ 0x39C8BAB1;
					continue;
				case 45u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -1658139607;
					continue;
				}
				case 44u:
					num = ((int)num2 * -2083241923) ^ -174244361;
					continue;
				case 43u:
					flag12 = num24 < _playerStates.Length;
					num = -837066123;
					continue;
				case 42u:
					playerState.State = State.Won;
					num = ((int)num2 * -1393869548) ^ 0xC48DB79;
					continue;
				case 41u:
					num = ((int)num2 * -466482731) ^ 0x21129786;
					continue;
				case 40u:
					playerState.Sprint++;
					num = (int)(num2 * 1132790026) ^ -1427455640;
					continue;
				case 39u:
					flag = !Losers.Contains(num7);
					num = -1301339760;
					continue;
				case 38u:
				{
					int num33;
					int num34;
					if (flag4)
					{
						num33 = 976096462;
						num34 = 976096462;
					}
					else
					{
						num33 = 459499510;
						num34 = 459499510;
					}
					num = num33 ^ ((int)num2 * -2013146532);
					continue;
				}
				case 37u:
					Winners.Add(playerIndex);
					num = ((int)num2 * -262643440) ^ 0x385A7362;
					continue;
				case 36u:
					flag9 = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -1737114709) ^ 0x1B83016D;
					continue;
				case 35u:
					num = -2015886513;
					continue;
				case 34u:
					num = ((int)num2 * -525613173) ^ -11782132;
					continue;
				case 33u:
					flag2 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 2140541234) ^ 0x69CD99CA);
						continue;
					}
					num16 = 0;
					goto IL_00cd;
				case 32u:
					flag7 = playerState.Sprint < 0;
					num = -890640980;
					continue;
				case 31u:
				{
					int num29;
					int num30;
					if (flag12)
					{
						num29 = 769491036;
						num30 = 769491036;
					}
					else
					{
						num29 = 200409703;
						num30 = 200409703;
					}
					num = num29 ^ ((int)num2 * -518824623);
					continue;
				}
				case 30u:
					_finished = true;
					num = ((int)num2 * -12391833) ^ 0xA508895;
					continue;
				case 29u:
				{
					int num25;
					int num26;
					if (playerState.Resources < 0)
					{
						num25 = -944720144;
						num26 = -944720144;
					}
					else
					{
						num25 = -2000476122;
						num26 = -2000476122;
					}
					num = num25 ^ ((int)num2 * -445533951);
					continue;
				}
				case 28u:
					playerState2.State = State.Lose;
					flag6 = !Losers.Contains(num24);
					num = -938326771;
					continue;
				case 27u:
					num = ((int)num2 * -370979591) ^ -752006079;
					continue;
				case 26u:
				{
					int num21;
					int num22;
					if (!flag10)
					{
						num21 = -1573584093;
						num22 = -1573584093;
					}
					else
					{
						num21 = -1311532711;
						num22 = -1311532711;
					}
					num = num21 ^ ((int)num2 * -1981290279);
					continue;
				}
				case 25u:
					Print("Still planning");
					num = (int)(num2 * 428528822) ^ -144618129;
					continue;
				case 24u:
					flag9 = false;
					num = -1626451672;
					continue;
				case 23u:
					num = ((int)num2 * -1724006545) ^ 0x173B5727;
					continue;
				case 22u:
					num = (int)((num2 * 1840136847) ^ 0x7ECC8954);
					continue;
				case 21u:
				{
					int num19;
					int num20;
					if (onlyOneWinner)
					{
						num19 = -482463517;
						num20 = -482463517;
					}
					else
					{
						num19 = -1712760845;
						num20 = -1712760845;
					}
					num = num19 ^ (int)(num2 * 1813539585);
					continue;
				}
				case 20u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)((num2 * 490482717) ^ 0xC05926B);
					continue;
				case 19u:
					flag5 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -1767357883;
					continue;
				case 18u:
					num = -1265927909;
					continue;
				case 17u:
					flag9 = num18 < Rules.StayOnSprintMinDiff;
					num17 = Game.smethod_3(0, num18);
					num = (int)((num2 * 28716193) ^ 0x74DCE20F);
					continue;
				case 16u:
					num = (int)((num2 * 921798817) ^ 0x79869672);
					continue;
				case 15u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1793765547) ^ -1335852635;
					continue;
				case 14u:
					num17 = card.Impact;
					num = (int)(num2 * 281489432) ^ -438787039;
					continue;
				case 13u:
					num = (int)(num2 * 287068447) ^ -1315022025;
					continue;
				case 12u:
					playerState.Resources -= num17;
					num = (int)((num2 * 722735798) ^ 0x5B5BE796);
					continue;
				case 11u:
				{
					int num14;
					int num15;
					if (flag7)
					{
						num14 = -529488255;
						num15 = -529488255;
					}
					else
					{
						num14 = -1256746134;
						num15 = -1256746134;
					}
					num = num14 ^ (int)(num2 * 1230115524);
					continue;
				}
				case 10u:
					num = (int)((num2 * 19675983) ^ 0x3B99363B);
					continue;
				case 9u:
					num7++;
					num = -1534114436;
					continue;
				case 8u:
					Print(playerState.State);
					num = (int)((num2 * 2083668109) ^ 0x119520B);
					continue;
				case 7u:
					num = -478999007;
					continue;
				case 6u:
				{
					int num8;
					int num9;
					if (!flag5)
					{
						num8 = 1170029905;
						num9 = 1170029905;
					}
					else
					{
						num8 = 1828049520;
						num9 = 1828049520;
					}
					num = num8 ^ ((int)num2 * -2144452660);
					continue;
				}
				case 5u:
					num = ((int)num2 * -965341503) ^ -1076467798;
					continue;
				case 4u:
					num = ((int)num2 * -1984339799) ^ -1120932931;
					continue;
				case 3u:
					flag4 = num7 < _playerStates.Length;
					num = -276346816;
					continue;
				case 2u:
					num = (int)((num2 * 1866979030) ^ 0x4AB80F7F);
					continue;
				case 1u:
					flag3 = !flag2;
					num = ((int)num2 * -687174625) ^ 0x4536D04B;
					continue;
				case 0u:
				{
					playerState.State = State.Lose;
					int num3;
					int num4;
					if (Losers.Contains(playerIndex))
					{
						num3 = 1007945879;
						num4 = 1007945879;
					}
					else
					{
						num3 = 1477773572;
						num4 = 1477773572;
					}
					num = num3 ^ ((int)num2 * -1497600518);
					continue;
				}
				default:
					return;
				case 70u:
					break;
				case 82u:
					return;
					IL_00cd:
					flag8 = (byte)num16 != 0;
					num = -740286965;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card result = default(Card);
		bool flag = default(bool);
		while (true)
		{
			int num = 1794348302;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x528230D9u) % 7u)
				{
				case 6u:
					ShuffleCards();
					num = ((int)num2 * -441706985) ^ -1832776223;
					continue;
				case 5u:
				{
					Card card = _deck[0];
					_deck.RemoveAt(0);
					result = card;
					num = 223439629;
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 925402615;
						num4 = 925402615;
					}
					else
					{
						num3 = 1412411123;
						num4 = 1412411123;
					}
					num = num3 ^ (int)(num2 * 957635820);
					continue;
				}
				case 2u:
					flag = _deck.Count <= 0;
					num = (int)((num2 * 1169313114) ^ 0x3C04A24C);
					continue;
				case 0u:
					num = (int)((num2 * 118960209) ^ 0x52268B49);
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

	public string ToString(bool initial)
	{
		string text = "";
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1827953783;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1BAF7DCu) % 9u)
				{
				case 8u:
					flag = num3 < _playerStates.Length;
					num = -38670641;
					continue;
				case 7u:
					result = text;
					num = (int)((num2 * 1380711253) ^ 0x6DF40296);
					continue;
				case 6u:
					num = (int)(num2 * 2013961546) ^ -327010604;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -326262063) ^ 0x58ABEA98;
					continue;
				case 3u:
					num3 = 0;
					num = (int)(num2 * 989711353) ^ -1811422334;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 773168963;
						num5 = 773168963;
					}
					else
					{
						num4 = 1076128068;
						num5 = 1076128068;
					}
					num = num4 ^ ((int)num2 * -1365490716);
					continue;
				}
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
					num = -1718495525;
					continue;
				}
				case 2u:
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
		string result = ToString(initial: false);
		while (true)
		{
			int num = 1660989600;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x972D62Au) % 3u)
				{
				case 1u:
					goto IL_000a;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000a:
				num = (int)((num2 * 2023991679) ^ 0x7890CFE2);
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = Game.smethod_7(Game.smethod_5(text), more);
		while (true)
		{
			int num = 1660698126;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x62D76CAFu) % 3u)
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000f:
				Game.smethod_8(_buffer, string_);
				num = ((int)num2 * -430775962) ^ 0x1EA9FF21;
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
