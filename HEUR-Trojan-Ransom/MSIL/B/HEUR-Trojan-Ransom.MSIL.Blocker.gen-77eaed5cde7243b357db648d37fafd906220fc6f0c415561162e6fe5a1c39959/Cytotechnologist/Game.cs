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
			int num3 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			while (true)
			{
				int num = -48460448;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D0DE3B3u) % 12u)
					{
					case 11u:
					{
						int num6;
						int num7;
						if (finished)
						{
							num6 = 726821273;
							num7 = 726821273;
						}
						else
						{
							num6 = 1830422438;
							num7 = 1830422438;
						}
						num = num6 ^ (int)(num2 * 229923352);
						continue;
					}
					case 10u:
						result = false;
						num = ((int)num2 * -462509431) ^ 0x624B00BE;
						continue;
					case 9u:
						num = -870578381;
						continue;
					case 8u:
						num3++;
						num = -609307778;
						continue;
					case 5u:
					{
						int num5;
						if (num3 < playerStates.Length)
						{
							num = -1063610693;
							num5 = -1063610693;
						}
						else
						{
							num = -1628789266;
							num5 = -1628789266;
						}
						continue;
					}
					case 4u:
						playerStates = _playerStates;
						num = (int)((num2 * 1234882352) ^ 0x4C703594);
						continue;
					case 3u:
						num3 = 0;
						num = (int)(num2 * 861310005) ^ -1428328083;
						continue;
					case 2u:
						result = true;
						num = (int)(num2 * 563852562) ^ -645446196;
						continue;
					case 1u:
						result = true;
						num = (int)((num2 * 647204181) ^ 0x1BE16FC9);
						continue;
					case 0u:
					{
						PlayerState playerState = playerStates[num3];
						int num4;
						if (playerState.State == State.Playing)
						{
							num = -2057622571;
							num4 = -2057622571;
						}
						else
						{
							num = -909880373;
							num4 = -909880373;
						}
						continue;
					}
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
		int num3 = default(int);
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		int num4 = default(int);
		int count = default(int);
		while (true)
		{
			int num = -1602709576;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF90BB272u) % 19u)
				{
				case 18u:
					num3++;
					num = (int)(num2 * 534220832) ^ -1426152878;
					continue;
				case 17u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 678887071;
						num7 = 678887071;
					}
					else
					{
						num6 = 1224369743;
						num7 = 1224369743;
					}
					num = num6 ^ ((int)num2 * -1842633801);
					continue;
				}
				case 16u:
					_dice = new Dice();
					num = (int)(num2 * 1151064129) ^ -1992778915;
					continue;
				case 15u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num = -720097285;
					continue;
				case 14u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = ((int)num2 * -2147299855) ^ 0x6E2F66BF;
					continue;
				case 13u:
					num3 = 0;
					num = (int)((num2 * 699163462) ^ 0x30AE21C6);
					continue;
				case 12u:
					num = (int)((num2 * 514000673) ^ 0x6A23C412);
					continue;
				case 11u:
					_playerStates[num4] = new PlayerState();
					num4++;
					num = -1763368113;
					continue;
				case 10u:
					num = (int)(num2 * 1769976568) ^ -763577290;
					continue;
				case 9u:
					Players = new Player[count];
					num = ((int)num2 * -1065025117) ^ -1900330925;
					continue;
				case 8u:
				{
					int num5;
					if (num4 >= count)
					{
						num = -396039927;
						num5 = -396039927;
					}
					else
					{
						num = -1567995075;
						num5 = -1567995075;
					}
					continue;
				}
				case 7u:
					_buffer = buffer;
					num = (int)((num2 * 32655203) ^ 0x77D39256);
					continue;
				case 6u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = (int)((num2 * 977577514) ^ 0x50FC50C3);
					continue;
				case 5u:
					num4 = 0;
					num = ((int)num2 * -1384016193) ^ -363660466;
					continue;
				case 4u:
					num = (int)(num2 * 843823064) ^ -467559389;
					continue;
				case 2u:
					_playerStates = new PlayerState[count];
					num = (int)(num2 * 66571321) ^ -230120329;
					continue;
				case 0u:
					flag = num3 < count;
					num = -1626043149;
					continue;
				default:
					return;
				case 3u:
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
		_deck = new List<Card>(Rules.Cards);
	}

	public void StartNew()
	{
		while (true)
		{
			int num = -1979828761;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE34191Cu) % 11u)
				{
				case 9u:
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 1162748473) ^ 0x36469F81);
					continue;
				case 8u:
					num = ((int)num2 * -477186421) ^ 0x7FEDA0C8;
					continue;
				case 7u:
					ShuffleCards();
					num = ((int)num2 * -753186116) ^ 0x353AB837;
					continue;
				case 6u:
					_finished = false;
					num = (int)(num2 * 396846804) ^ -1876584175;
					continue;
				case 5u:
					_currentTurn = 0;
					num = ((int)num2 * -1056095822) ^ -287034596;
					continue;
				case 4u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 1004714284) ^ 0x2DA7E9C3);
					continue;
				case 3u:
					Winners.Clear();
					num = (int)(num2 * 383308177) ^ -1494999664;
					continue;
				case 1u:
					Losers.Clear();
					num = ((int)num2 * -315494372) ^ -1894599773;
					continue;
				case 0u:
					_currentChanceIndex = -1;
					num = (int)(num2 * 1064583496) ^ -1136025028;
					continue;
				default:
					return;
				case 2u:
					break;
				case 10u:
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
		int planningCardsCount = default(int);
		bool flag = default(bool);
		Player player = default(Player);
		int num4 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = -38520923;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x88EB4E74u) % 28u)
				{
				case 26u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num2 = ((int)num3 * -772071849) ^ 0x56065E3E;
					continue;
				case 25u:
					num++;
					num2 = ((int)num3 * -731671225) ^ 0x19D01D41;
					continue;
				case 24u:
				{
					int num7;
					int num8;
					if (planningCardsCount == 0)
					{
						num7 = -2086463293;
						num8 = -2086463293;
					}
					else
					{
						num7 = -1610415052;
						num8 = -1610415052;
					}
					num2 = num7 ^ ((int)num3 * -1069236314);
					continue;
				}
				case 23u:
					num2 = -1046860411;
					continue;
				case 22u:
					flag = num < Players.Length;
					num2 = -926339234;
					continue;
				case 21u:
					playerState = _playerStates[num];
					num2 = (int)(num3 * 145845728) ^ -426840200;
					continue;
				case 20u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = ((int)num3 * -401860684) ^ 0x35F7753F;
					continue;
				case 18u:
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num2 = (int)(num3 * 687020930) ^ -1427734979;
					continue;
				case 17u:
				{
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					int num11;
					int num12;
					if (!player.UseOneMorePlanningSprint)
					{
						num11 = 1793328160;
						num12 = 1793328160;
					}
					else
					{
						num11 = 739977491;
						num12 = 739977491;
					}
					num2 = num11 ^ ((int)num3 * -1645118582);
					continue;
				}
				case 16u:
					playerState.Sprint = 0;
					num2 = (int)((num3 * 1523931396) ^ 0x53CE043A);
					continue;
				case 15u:
					playerState.Sprint = 1;
					num2 = (int)((num3 * 783452457) ^ 0x19675989);
					continue;
				case 14u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num2 = -28552493;
					continue;
				case 13u:
					num2 = ((int)num3 * -652553932) ^ -1718471750;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -1587143112;
						num10 = -1587143112;
					}
					else
					{
						num9 = -1731608888;
						num10 = -1731608888;
					}
					num2 = num9 ^ ((int)num3 * -138698419);
					continue;
				}
				case 11u:
					playerState.Sprint = -1;
					num2 = ((int)num3 * -186283033) ^ -694656809;
					continue;
				case 10u:
					num2 = (int)(num3 * 248427057) ^ -837936857;
					continue;
				case 9u:
					num2 = -116907442;
					continue;
				case 8u:
					num2 = -685588439;
					continue;
				case 7u:
					num4 = 0;
					num2 = ((int)num3 * -821012910) ^ 0x3A936556;
					continue;
				case 6u:
					flag2 = num4 > 0;
					num2 = -1137818216;
					continue;
				case 5u:
					player = Players[num];
					num2 = ((int)num3 * -980407342) ^ 0x35037907;
					continue;
				case 4u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num2 = ((int)num3 * -607057871) ^ 0x3BDE39DA;
					continue;
				case 3u:
					num2 = ((int)num3 * -529281724) ^ -1980326831;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1897989355;
						num6 = -1897989355;
					}
					else
					{
						num5 = -1098379823;
						num6 = -1098379823;
					}
					num2 = num5 ^ ((int)num3 * -1661150913);
					continue;
				}
				case 1u:
					num2 = ((int)num3 * -1763016346) ^ 0x43BFD06D;
					continue;
				case 0u:
					num4 = 0;
					num2 = -2021376103;
					continue;
				default:
					return;
				case 19u:
					break;
				case 27u:
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
			int num = 175840412;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39B596BEu) % 16u)
				{
				case 15u:
					num = (int)((num2 * 1944555738) ^ 0x1818E9C4);
					continue;
				case 14u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1319059384;
						num6 = 1319059384;
					}
					else
					{
						num5 = 1285336815;
						num6 = 1285336815;
					}
					num = num5 ^ ((int)num2 * -1001734803);
					continue;
				}
				case 13u:
					num = (int)((num2 * 1975693343) ^ 0x5239232D);
					continue;
				case 12u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 1585155446) ^ 0x143D033B);
					continue;
				case 11u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 1435172785;
					continue;
				case 9u:
					flag = _currentTurn > 0;
					num = (int)(num2 * 572841004) ^ -2003260554;
					continue;
				case 8u:
					_currentPlayer = 0;
					num = ((int)num2 * -1144587234) ^ -1563539657;
					continue;
				case 7u:
					num = ((int)num2 * -87854152) ^ -1478193090;
					continue;
				case 5u:
					flag2 = _currentPlayer >= Players.Length;
					num = ((int)num2 * -2100205224) ^ -603035464;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1530075149;
						num4 = 1530075149;
					}
					else
					{
						num3 = 696528487;
						num4 = 696528487;
					}
					num = num3 ^ (int)(num2 * 1954981910);
					continue;
				}
				case 3u:
					num = (int)((num2 * 2080191565) ^ 0x625C1672);
					continue;
				case 2u:
					_currentPlayer++;
					num = ((int)num2 * -1749087246) ^ -661160097;
					continue;
				case 1u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1799884979) ^ -1787333328;
					continue;
				case 0u:
					PlayerTurn(_currentPlayer);
					num = 896744996;
					continue;
				default:
					return;
				case 6u:
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
		bool flag6 = default(bool);
		int num3 = default(int);
		bool flag5 = default(bool);
		Card card = default(Card);
		bool flag2 = default(bool);
		int num6 = default(int);
		int num11 = default(int);
		Player player = default(Player);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool onlyOneWinner = default(bool);
		PlayerState playerState = default(PlayerState);
		int num5 = default(int);
		bool flag7 = default(bool);
		PlayerState playerState3 = default(PlayerState);
		bool flag8 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -758562459;
			while (true)
			{
				uint num2;
				int num13;
				switch ((num2 = (uint)num ^ 0x98D205C2u) % 82u)
				{
				case 81u:
					flag6 = num3 < _playerStates.Length;
					num = -1618077262;
					continue;
				case 80u:
				{
					int num18;
					int num19;
					if (!flag5)
					{
						num18 = -801069478;
						num19 = -801069478;
					}
					else
					{
						num18 = -1432603750;
						num19 = -1432603750;
					}
					num = num18 ^ ((int)num2 * -1437409974);
					continue;
				}
				case 79u:
					num = (int)(num2 * 540449922) ^ -1430920876;
					continue;
				case 78u:
					card = DrawCard();
					flag2 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = -974273791;
						continue;
					}
					num13 = 0;
					goto IL_0086;
				case 77u:
					num6++;
					num = -1060806086;
					continue;
				case 76u:
					num = -1404568967;
					continue;
				case 75u:
					num11 = card.Impact - player.PlannedForCard(card.Type);
					flag3 = num11 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -413991303) ^ 0xF02B9D8;
					continue;
				case 74u:
				{
					int num16;
					int num17;
					if (flag4)
					{
						num16 = 1634224220;
						num17 = 1634224220;
					}
					else
					{
						num16 = 223387614;
						num17 = 223387614;
					}
					num = num16 ^ ((int)num2 * -497778783);
					continue;
				}
				case 73u:
				{
					int num9;
					int num10;
					if (onlyOneWinner)
					{
						num9 = 60225569;
						num10 = 60225569;
					}
					else
					{
						num9 = 1096936642;
						num10 = 1096936642;
					}
					num = num9 ^ (int)(num2 * 1112813140);
					continue;
				}
				case 72u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -2057397336) ^ 0x5B32DD67;
					continue;
				case 71u:
					num5 = Game.smethod_3(0, num11);
					num = (int)((num2 * 1974313281) ^ 0x3B4E85E);
					continue;
				case 70u:
					num = ((int)num2 * -1166228713) ^ -9525349;
					continue;
				case 69u:
					flag3 = false;
					num = -2122456678;
					continue;
				case 68u:
					num = ((int)num2 * -2051308875) ^ 0x6D9D304E;
					continue;
				case 67u:
					num = ((int)num2 * -1180812044) ^ 0x58DD160E;
					continue;
				case 66u:
					flag7 = num6 < _playerStates.Length;
					num = -2137804815;
					continue;
				case 65u:
					Losers.Add(num3);
					num = (int)((num2 * 1641200844) ^ 0x12A1AF3D);
					continue;
				case 64u:
					num = (int)((num2 * 458661905) ^ 0x787347B1);
					continue;
				case 63u:
					playerState3 = _playerStates[num3];
					playerState3.Resources -= Game.smethod_3(0, num5 - Players[num3].PlannedForCard(card.Type));
					flag5 = playerState3.Resources >= 0;
					num = ((int)num2 * -1191162839) ^ 0x18569CC1;
					continue;
				case 62u:
					Print("Still planning");
					num = (int)((num2 * 1995332586) ^ 0x268199FB);
					continue;
				case 61u:
					num3 = 0;
					num = (int)((num2 * 855019380) ^ 0x66F9A6D2);
					continue;
				case 60u:
					flag4 = !Losers.Contains(num6);
					num = -1867423932;
					continue;
				case 59u:
					playerState.State = State.Lose;
					flag8 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1191760777) ^ -440431360;
					continue;
				case 58u:
					num = ((int)num2 * -1731370435) ^ 0x3C2716B7;
					continue;
				case 57u:
					player = Players[playerIndex];
					num = (int)(num2 * 1752677233) ^ -1800779410;
					continue;
				case 56u:
				{
					int num27;
					if (playerState.Sprint <= Rules.SprintCount)
					{
						num = -1404568967;
						num27 = -1404568967;
					}
					else
					{
						num = -1972987880;
						num27 = -1972987880;
					}
					continue;
				}
				case 55u:
					flag3 = true;
					num5 = card.Impact;
					num = ((int)num2 * -1561467237) ^ 0x119B700;
					continue;
				case 54u:
					playerState.Sprint++;
					num = ((int)num2 * -1370706919) ^ -2056766388;
					continue;
				case 53u:
				{
					int num20;
					int num21;
					if (flag2)
					{
						num20 = 2043388066;
						num21 = 2043388066;
					}
					else
					{
						num20 = 1176555495;
						num21 = 1176555495;
					}
					num = num20 ^ (int)(num2 * 1323582359);
					continue;
				}
				case 52u:
					playerState3.State = State.Lose;
					num = -61445362;
					continue;
				case 51u:
					num = -584005337;
					continue;
				case 50u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num5), flag3 ? "advance" : "stay");
					num = -193167329;
					continue;
				case 49u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1343173316) ^ -413103093;
					continue;
				case 48u:
					Print(playerState.State);
					num = ((int)num2 * -525874930) ^ 0x38A7EE98;
					continue;
				case 47u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -143124069) ^ 0x2A6307D4;
					continue;
				case 46u:
					playerState.Sprint++;
					num = (int)(num2 * 27709035) ^ -612893304;
					continue;
				case 45u:
					num = ((int)num2 * -1361612382) ^ -234256018;
					continue;
				case 43u:
				{
					int num34;
					int num35;
					if (flag8)
					{
						num34 = 1647897931;
						num35 = 1647897931;
					}
					else
					{
						num34 = 1236972775;
						num35 = 1236972775;
					}
					num = num34 ^ ((int)num2 * -1485439184);
					continue;
				}
				case 42u:
				{
					int num32;
					int num33;
					if (playerState.Resources >= 0)
					{
						num32 = -1445939099;
						num33 = -1445939099;
					}
					else
					{
						num32 = -71902403;
						num33 = -71902403;
					}
					num = num32 ^ (int)(num2 * 948984239);
					continue;
				}
				case 41u:
					num13 = ((card.Type == 4) ? 1 : 0);
					goto IL_0086;
				case 40u:
					num = -893069738;
					continue;
				case 39u:
					num = ((int)num2 * -823571252) ^ 0x4994175A;
					continue;
				case 37u:
					num = (int)(num2 * 134251670) ^ -1528996378;
					continue;
				case 36u:
					num = -1029941189;
					continue;
				case 35u:
					num = ((int)num2 * -1850028663) ^ 0x21B7D90C;
					continue;
				case 34u:
					playerState.Resources -= num5;
					num = (int)((num2 * 172740219) ^ 0x275CA1E4);
					continue;
				case 33u:
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -519183585) ^ -904409105;
					continue;
				case 32u:
				{
					int num30;
					int num31;
					if (Losers.Contains(num3))
					{
						num30 = -1461875690;
						num31 = -1461875690;
					}
					else
					{
						num30 = -935616097;
						num31 = -935616097;
					}
					num = num30 ^ ((int)num2 * -1040967905);
					continue;
				}
				case 31u:
					num = (int)(num2 * 1132587280) ^ -1725305304;
					continue;
				case 30u:
				{
					int num28;
					int num29;
					if (num6 != playerIndex)
					{
						num28 = -1563001480;
						num29 = -1563001480;
					}
					else
					{
						num28 = -1479764550;
						num29 = -1479764550;
					}
					num = num28 ^ (int)(num2 * 1137464590);
					continue;
				}
				case 29u:
					num = ((int)num2 * -570936773) ^ 0x4CF226AD;
					continue;
				case 28u:
				{
					int num25;
					int num26;
					if (!flag6)
					{
						num25 = -1991824555;
						num26 = -1991824555;
					}
					else
					{
						num25 = -1904593568;
						num26 = -1904593568;
					}
					num = num25 ^ ((int)num2 * -753587721);
					continue;
				}
				case 27u:
					num = -632494240;
					continue;
				case 26u:
					num = -473117743;
					continue;
				case 25u:
				{
					int num23;
					int num24;
					if (flag7)
					{
						num23 = 1246108421;
						num24 = 1246108421;
					}
					else
					{
						num23 = 1053526278;
						num24 = 1053526278;
					}
					num = num23 ^ (int)(num2 * 746137159);
					continue;
				}
				case 24u:
					num = (int)((num2 * 2127845523) ^ 0x771BC121);
					continue;
				case 23u:
					_finished = true;
					num = ((int)num2 * -1219329121) ^ -679920419;
					continue;
				case 22u:
				{
					int num22;
					if (playerState.Sprint < 0)
					{
						num = -1215923598;
						num22 = -1215923598;
					}
					else
					{
						num = -1982257739;
						num22 = -1982257739;
					}
					continue;
				}
				case 21u:
					num = (int)((num2 * 1534249243) ^ 0x6AFFCA07);
					continue;
				case 20u:
					num = ((int)num2 * -1592886866) ^ 0x5EA8DF04;
					continue;
				case 19u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = -170046270;
					continue;
				}
				case 18u:
				{
					int num14;
					int num15;
					if (playerState.State == State.Playing)
					{
						num14 = 1216361470;
						num15 = 1216361470;
					}
					else
					{
						num14 = 1050998170;
						num15 = 1050998170;
					}
					num = num14 ^ ((int)num2 * -556834199);
					continue;
				}
				case 17u:
				{
					int num12;
					if (flag3)
					{
						num = -1539002236;
						num12 = -1539002236;
					}
					else
					{
						num = -1321736758;
						num12 = -1321736758;
					}
					continue;
				}
				case 16u:
					num = ((int)num2 * -205940369) ^ -547330479;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -1159824412;
						num8 = -1159824412;
					}
					else
					{
						num7 = -759377684;
						num8 = -759377684;
					}
					num = num7 ^ (int)(num2 * 165164091);
					continue;
				}
				case 14u:
					num = (int)((num2 * 1139954418) ^ 0x7580EC47);
					continue;
				case 13u:
					num = (int)((num2 * 211409431) ^ 0x5FFD45B5);
					continue;
				case 12u:
					num6 = 0;
					num = (int)((num2 * 1481678467) ^ 0x1C525897);
					continue;
				case 11u:
					num = (int)((num2 * 1015576116) ^ 0x4EE40C7E);
					continue;
				case 10u:
					Losers.Add(num6);
					num = ((int)num2 * -260553321) ^ 0x52266CE5;
					continue;
				case 9u:
					flag3 = true;
					Print("CARD: none, advance");
					num = (int)(num2 * 120124373) ^ -754324549;
					continue;
				case 8u:
					num = ((int)num2 * -604029242) ^ -1727419372;
					continue;
				case 7u:
				{
					int num4;
					if (!_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = -1487630960;
						num4 = -1487630960;
					}
					else
					{
						num = -421536620;
						num4 = -421536620;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -1275122940) ^ 0x3E0E88A9;
					continue;
				case 5u:
					num3++;
					num = -413114061;
					continue;
				case 4u:
					num = -2120034081;
					continue;
				case 3u:
					num = -1639158327;
					continue;
				case 2u:
					num = (int)((num2 * 1108210955) ^ 0x2970A437);
					continue;
				case 1u:
					num = (int)(num2 * 2060252168) ^ -1470829895;
					continue;
				case 0u:
					num = -1758076639;
					continue;
				default:
					return;
				case 44u:
					break;
				case 38u:
					return;
					IL_0086:
					flag = (byte)num13 != 0;
					num = -690725453;
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
			int num = 1014201749;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5065E313u) % 9u)
				{
				case 8u:
					_deck.RemoveAt(0);
					num = ((int)num2 * -1959859204) ^ -215092033;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2106951831;
						num4 = -2106951831;
					}
					else
					{
						num3 = -1123756572;
						num4 = -1123756572;
					}
					num = num3 ^ (int)(num2 * 1919995546);
					continue;
				}
				case 6u:
					card = _deck[0];
					num = 403389940;
					continue;
				case 4u:
					ShuffleCards();
					num = ((int)num2 * -442844898) ^ 0x3CB40058;
					continue;
				case 3u:
					result = card;
					num = (int)(num2 * 993378546) ^ -66188315;
					continue;
				case 2u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -304211904) ^ -886313509;
					continue;
				case 1u:
					num = (int)(num2 * 799796956) ^ -1021097862;
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
		string text = "";
		int num = 0;
		string result = default(string);
		while (true)
		{
			bool flag = num < _playerStates.Length;
			int num2 = 1934967954;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD4816ACu) % 7u)
				{
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
					num2 = 936664452;
					continue;
				}
				case 5u:
					num2 = 52850461;
					continue;
				case 4u:
					result = text;
					num2 = (int)((num3 * 338597450) ^ 0x3050985D);
					continue;
				case 3u:
					num++;
					num2 = ((int)num3 * -621611120) ^ -2088259268;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 449667233;
						num5 = 449667233;
					}
					else
					{
						num4 = 1969895811;
						num5 = 1969895811;
					}
					num2 = num4 ^ (int)(num3 * 562820706);
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
		string result = default(string);
		while (true)
		{
			int num = 1565105666;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11912C51u) % 4u)
				{
				case 3u:
					result = ToString(initial: false);
					num = (int)(num2 * 785887685) ^ -755737042;
					continue;
				case 0u:
					num = (int)(num2 * 1364327154) ^ -1665524448;
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
