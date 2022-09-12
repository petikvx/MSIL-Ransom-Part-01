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
				goto IL_000b;
			}
			goto IL_011f;
			IL_011f:
			int num = 991182234;
			goto IL_00dc;
			IL_00dc:
			int num3 = default(int);
			bool result = default(bool);
			PlayerState[] playerStates = default(PlayerState[]);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4953DFAEu) % 12u)
				{
				case 11u:
					break;
				case 10u:
					num3++;
					num = 1424902484;
					continue;
				case 9u:
					goto IL_0023;
				case 8u:
					result = true;
					num = ((int)num2 * -175769383) ^ 0x6B629584;
					continue;
				case 7u:
					result = true;
					num = ((int)num2 * -1716612305) ^ -1657612667;
					continue;
				case 6u:
					goto IL_0074;
				case 4u:
					playerStates = _playerStates;
					num = ((int)num2 * -1604678701) ^ 0x673B99C7;
					continue;
				case 3u:
					num = (int)(num2 * 694156086) ^ -732574046;
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 2105079492) ^ -747116096;
					continue;
				case 0u:
					result = false;
					num = (int)((num2 * 1115141193) ^ 0x42701E35);
					continue;
				case 5u:
					goto IL_011f;
				default:
					return result;
				}
				break;
				IL_0074:
				int num4;
				if (num3 < playerStates.Length)
				{
					num = 67425067;
					num4 = 67425067;
				}
				else
				{
					num = 1643561098;
					num4 = 1643561098;
				}
				continue;
				IL_0023:
				PlayerState playerState = playerStates[num3];
				int num5;
				if (playerState.State == State.Playing)
				{
					num = 624162550;
					num5 = 624162550;
				}
				else
				{
					num = 896663156;
					num5 = 896663156;
				}
			}
			goto IL_000b;
			IL_000b:
			num = 1685945125;
			goto IL_00dc;
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
			int num = -1221753967;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC853311Du) % 10u)
				{
				case 8u:
					_currentTurn = 0;
					num = (int)(num2 * 1975355126) ^ -155413459;
					continue;
				case 7u:
					Winners.Clear();
					num = (int)((num2 * 1782970174) ^ 0x6F0F189C);
					continue;
				case 6u:
					ShuffleCards();
					num = ((int)num2 * -934159140) ^ -591467628;
					continue;
				case 4u:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 252841516) ^ 0x76C7365E);
					continue;
				case 3u:
					num = ((int)num2 * -1171890278) ^ -2082761364;
					continue;
				case 2u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 2033878848) ^ 0x53A93EC5);
					continue;
				case 1u:
					Losers.Clear();
					num = (int)((num2 * 337505435) ^ 0x333FE778);
					continue;
				case 0u:
					_finished = false;
					num = ((int)num2 * -42010087) ^ 0x3652FCAF;
					continue;
				default:
					return;
				case 5u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		PlayerState playerState = default(PlayerState);
		bool flag2 = default(bool);
		int num8 = default(int);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		bool flag = default(bool);
		int num3 = default(int);
		int planningCardsCount = default(int);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -276208309;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0919E5Bu) % 29u)
				{
				case 27u:
					playerState.Sprint = -1;
					num = (int)(num2 * 693633958) ^ -1912448785;
					continue;
				case 26u:
					flag2 = num8 < Players.Length;
					num = -1744079210;
					continue;
				case 25u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = (int)((num2 * 778780107) ^ 0x6B4005C0);
					continue;
				case 24u:
					num = (int)(num2 * 943123618) ^ -50109022;
					continue;
				case 23u:
					player = Players[num8];
					num = -1726185071;
					continue;
				case 22u:
					playerState.Resources = Rules.InitialResources;
					num = (int)(num2 * 773405652) ^ -347873069;
					continue;
				case 21u:
					flag = num3 > 0;
					num = -1632078738;
					continue;
				case 20u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -308147275;
						num7 = -308147275;
					}
					else
					{
						num6 = -121215560;
						num7 = -121215560;
					}
					num = num6 ^ ((int)num2 * -1493137128);
					continue;
				}
				case 19u:
					num = -1785575432;
					continue;
				case 18u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = (int)((num2 * 462830623) ^ 0x1C74BA01);
					continue;
				case 17u:
					playerState = _playerStates[num8];
					num = ((int)num2 * -104536824) ^ -30718482;
					continue;
				case 16u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = 418410349;
						num12 = 418410349;
					}
					else
					{
						num11 = 1893606749;
						num12 = 1893606749;
					}
					num = num11 ^ ((int)num2 * -904084130);
					continue;
				}
				case 15u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 17373209;
						num10 = 17373209;
					}
					else
					{
						num9 = 763230711;
						num10 = 763230711;
					}
					num = num9 ^ ((int)num2 * -372369842);
					continue;
				}
				case 14u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)((num2 * 1960782187) ^ 0x61B60EE8);
					continue;
				case 13u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = -2011793216;
					continue;
				case 12u:
					planningCardsCount = player.PlanningCardsCount;
					num3 = 0;
					flag3 = planningCardsCount == 0;
					num = ((int)num2 * -1445413162) ^ 0x26A0A7ED;
					continue;
				case 11u:
					playerState.Sprint = 0;
					num = (int)(num2 * 310821933) ^ -1390619357;
					continue;
				case 10u:
					num8 = 0;
					num = ((int)num2 * -212898492) ^ 0x1D3D1AA1;
					continue;
				case 8u:
					num8++;
					num = (int)(num2 * 274671891) ^ -419762079;
					continue;
				case 7u:
					playerState.Sprint = 1;
					num = (int)((num2 * 1224842585) ^ 0x47C05CBC);
					continue;
				case 6u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = ((int)num2 * -1427919148) ^ 0x32FD041E;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (useOneMorePlanningSprint)
					{
						num4 = 1746264583;
						num5 = 1746264583;
					}
					else
					{
						num4 = 961223791;
						num5 = 961223791;
					}
					num = num4 ^ ((int)num2 * -290522949);
					continue;
				}
				case 4u:
					num3 = 0;
					num = -687189466;
					continue;
				case 3u:
					num = (int)((num2 * 2036346527) ^ 0x4BF632D3);
					continue;
				case 2u:
					num = (int)(num2 * 1067542524) ^ -1846087996;
					continue;
				case 1u:
					playerState.State = State.Playing;
					num = (int)(num2 * 910608261) ^ -1216660040;
					continue;
				case 0u:
					num = -1750384140;
					continue;
				default:
					return;
				case 9u:
					break;
				case 28u:
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
			int num = 1087334951;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x48428742u) % 16u)
				{
				case 15u:
					num = ((int)num2 * -1580124026) ^ 0x63A6BC3F;
					continue;
				case 14u:
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -238698612) ^ 0xA0048B6;
					continue;
				case 13u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -484700268) ^ 0x5CD2AE9D;
					continue;
				case 12u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -2021606919;
						num6 = -2021606919;
					}
					else
					{
						num5 = -1674873665;
						num6 = -1674873665;
					}
					num = num5 ^ ((int)num2 * -1377584808);
					continue;
				}
				case 11u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 2055523597;
					continue;
				case 10u:
					PlayerTurn(_currentPlayer);
					num = 1704458852;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1866625584;
						num4 = -1866625584;
					}
					else
					{
						num3 = -1708906182;
						num4 = -1708906182;
					}
					num = num3 ^ ((int)num2 * -2118039499);
					continue;
				}
				case 7u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)(num2 * 1506392931) ^ -1368362234;
					continue;
				case 6u:
					num = (int)(num2 * 1174978500) ^ -963740909;
					continue;
				case 5u:
					_currentPlayer++;
					flag = _currentPlayer >= Players.Length;
					num = (int)(num2 * 1674072118) ^ -1635112476;
					continue;
				case 4u:
					num = ((int)num2 * -1803092019) ^ 0x51E9887C;
					continue;
				case 2u:
					num = ((int)num2 * -293947716) ^ -762833586;
					continue;
				case 1u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 967313020) ^ -1398785428;
					continue;
				case 0u:
					_currentPlayer = 0;
					num = ((int)num2 * -2070282124) ^ 0x623AFB6C;
					continue;
				default:
					return;
				case 3u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		int num9 = default(int);
		bool flag9 = default(bool);
		bool flag7 = default(bool);
		PlayerState playerState = default(PlayerState);
		int num3 = default(int);
		Player player = default(Player);
		bool flag2 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		Card card = default(Card);
		bool flag10 = default(bool);
		bool flag = default(bool);
		int num15 = default(int);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		bool flag8 = default(bool);
		bool flag5 = default(bool);
		int num8 = default(int);
		bool flag4 = default(bool);
		bool onlyOneWinner = default(bool);
		while (true)
		{
			int num = 271915810;
			while (true)
			{
				uint num2;
				int num21;
				int num27;
				switch ((num2 = (uint)num ^ 0x100E38D4u) % 84u)
				{
				case 83u:
				{
					int num14;
					if (num9 >= _playerStates.Length)
					{
						num = 1570851916;
						num14 = 1570851916;
					}
					else
					{
						num = 892972715;
						num14 = 892972715;
					}
					continue;
				}
				case 82u:
					num = (int)(num2 * 831781793) ^ -249724346;
					continue;
				case 81u:
					num = (int)((num2 * 1925942739) ^ 0x4782D083);
					continue;
				case 80u:
					num = (int)(num2 * 1852785264) ^ -1110305619;
					continue;
				case 79u:
					num = 1246476229;
					continue;
				case 78u:
					flag9 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 387187986;
					continue;
				case 77u:
					num = 255188323;
					continue;
				case 76u:
				{
					int num30;
					int num31;
					if (!flag7)
					{
						num30 = 1088844488;
						num31 = 1088844488;
					}
					else
					{
						num30 = 2089681069;
						num31 = 2089681069;
					}
					num = num30 ^ ((int)num2 * -884241001);
					continue;
				}
				case 75u:
					playerState.Sprint++;
					num = ((int)num2 * -2139876668) ^ -1867959953;
					continue;
				case 74u:
					num3 = 0;
					num = 1989122051;
					continue;
				case 72u:
					num = ((int)num2 * -743627094) ^ 0x4DD8709E;
					continue;
				case 71u:
					num = (int)((num2 * 711644639) ^ 0x7446982B);
					continue;
				case 70u:
					player = Players[playerIndex];
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -1861815980) ^ -959298223;
					continue;
				case 69u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -756440737) ^ 0x5A605731;
						continue;
					}
					num21 = 0;
					goto IL_0188;
				case 67u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = 2144408969;
						num13 = 2144408969;
					}
					else
					{
						num12 = 565349025;
						num13 = 565349025;
					}
					num = num12 ^ ((int)num2 * -1776270699);
					continue;
				}
				case 66u:
					playerState2.State = State.Lose;
					num = 70952174;
					continue;
				case 65u:
					num = (int)((num2 * 1337923806) ^ 0x7223DEFF);
					continue;
				case 64u:
					card = DrawCard();
					num = ((int)num2 * -18768188) ^ 0x7612928A;
					continue;
				case 63u:
					num = ((int)num2 * -455873961) ^ 0x758B617D;
					continue;
				case 62u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag10 ? "ALL " : "", flag ? "receives" : "pays", Game.smethod_4(num15), flag3 ? "advance" : "stay");
					num = 1616457935;
					continue;
				case 61u:
				{
					int num24;
					if (flag3)
					{
						num = 1947930775;
						num24 = 1947930775;
					}
					else
					{
						num = 1271576611;
						num24 = 1271576611;
					}
					continue;
				}
				case 60u:
					flag6 = !Losers.Contains(num9);
					num = 637224553;
					continue;
				case 59u:
				{
					int num18;
					if (playerState.Sprint > Rules.SprintCount)
					{
						num = 497964308;
						num18 = 497964308;
					}
					else
					{
						num = 1660606993;
						num18 = 1660606993;
					}
					continue;
				}
				case 58u:
					num9++;
					num = 88998027;
					continue;
				case 57u:
					num = 1660606993;
					continue;
				case 56u:
				{
					int num6;
					int num7;
					if (playerState.State == State.Playing)
					{
						num6 = -174232649;
						num7 = -174232649;
					}
					else
					{
						num6 = -1273812717;
						num7 = -1273812717;
					}
					num = num6 ^ ((int)num2 * -1877711651);
					continue;
				}
				case 55u:
					num = ((int)num2 * -953215111) ^ 0x47CDADE6;
					continue;
				case 54u:
					Print("CARD: none, advance");
					num = ((int)num2 * -204852581) ^ 0x1664FB3F;
					continue;
				case 53u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)((num2 * 277951487) ^ 0x3DD84A80);
					continue;
				case 52u:
					num = 1420211310;
					continue;
				case 51u:
					flag8 = !flag10;
					num = (int)(num2 * 791385182) ^ -1880584327;
					continue;
				case 50u:
					num = 793308684;
					continue;
				case 49u:
					num = (int)((num2 * 1126081409) ^ 0x8AE47B0);
					continue;
				case 48u:
					num = ((int)num2 * -1894986514) ^ 0x5DFCB80B;
					continue;
				case 47u:
					num = ((int)num2 * -804592130) ^ 0x5D278031;
					continue;
				case 46u:
				{
					int num33;
					int num34;
					if (!flag9)
					{
						num33 = 1682627919;
						num34 = 1682627919;
					}
					else
					{
						num33 = 1670429926;
						num34 = 1670429926;
					}
					num = num33 ^ (int)(num2 * 975418172);
					continue;
				}
				case 45u:
				{
					int num32;
					if (num3 >= _playerStates.Length)
					{
						num = 2056870776;
						num32 = 2056870776;
					}
					else
					{
						num = 1084369664;
						num32 = 1084369664;
					}
					continue;
				}
				case 44u:
					num = ((int)num2 * -1209323052) ^ 0xC427C5A;
					continue;
				case 43u:
					num = ((int)num2 * -1499416604) ^ 0x33B52129;
					continue;
				case 42u:
				{
					int num28;
					int num29;
					if (!flag5)
					{
						num28 = -2037262840;
						num29 = -2037262840;
					}
					else
					{
						num28 = -1045997057;
						num29 = -1045997057;
					}
					num = num28 ^ (int)(num2 * 175992771);
					continue;
				}
				case 41u:
					num = (int)((num2 * 639201408) ^ 0xCC02EE);
					continue;
				case 40u:
					flag3 = true;
					num = (int)((num2 * 450355260) ^ 0x7398D30E);
					continue;
				case 39u:
					num = (int)((num2 * 538456506) ^ 0x5C9ACC6B);
					continue;
				case 38u:
					num21 = ((card.Type == 4) ? 1 : 0);
					goto IL_0188;
				case 37u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 488805376;
					continue;
				}
				case 36u:
					flag3 = num8 < Rules.StayOnSprintMinDiff;
					num = (int)((num2 * 2025654178) ^ 0x57DB67FE);
					continue;
				case 35u:
					num = (int)(num2 * 374046858) ^ -911961345;
					continue;
				case 34u:
					flag3 = true;
					num15 = card.Impact;
					num = ((int)num2 * -585740805) ^ -2013748858;
					continue;
				case 33u:
					num = ((int)num2 * -869566277) ^ -963121773;
					continue;
				case 32u:
				{
					int num25;
					int num26;
					if (flag4)
					{
						num25 = -1631896739;
						num26 = -1631896739;
					}
					else
					{
						num25 = -310016683;
						num26 = -310016683;
					}
					num = num25 ^ ((int)num2 * -1541780249);
					continue;
				}
				case 31u:
				{
					int num22;
					int num23;
					if (!flag8)
					{
						num22 = -1598687447;
						num23 = -1598687447;
					}
					else
					{
						num22 = -701110884;
						num23 = -701110884;
					}
					num = num22 ^ (int)(num2 * 1372366265);
					continue;
				}
				case 30u:
					_finished = true;
					num9 = 0;
					num = ((int)num2 * -430692751) ^ 0x5AE74B4E;
					continue;
				case 29u:
					num = ((int)num2 * -1404155953) ^ -1394434245;
					continue;
				case 28u:
					num = ((int)num2 * -1944847778) ^ -1408192107;
					continue;
				case 27u:
					flag7 = num9 == playerIndex;
					num = 357202296;
					continue;
				case 26u:
					playerState.State = State.Won;
					num = (int)((num2 * 1290504396) ^ 0x1660FE7C);
					continue;
				case 25u:
				{
					int num19;
					int num20;
					if (flag6)
					{
						num19 = -921656782;
						num20 = -921656782;
					}
					else
					{
						num19 = -1730341405;
						num20 = -1730341405;
					}
					num = num19 ^ (int)(num2 * 1026440895);
					continue;
				}
				case 24u:
					num = ((int)num2 * -600043732) ^ 0x5219E8F3;
					continue;
				case 23u:
					flag5 = playerState.Sprint < 0;
					num = 564589142;
					continue;
				case 22u:
					flag2 = !Losers.Contains(num3);
					num = (int)((num2 * 1528688835) ^ 0x410E7355);
					continue;
				case 21u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 1931513711) ^ 0x1A716522);
					continue;
				case 20u:
					playerState.State = State.Lose;
					num = ((int)num2 * -1733289388) ^ -131988219;
					continue;
				case 19u:
					num = 587897730;
					continue;
				case 18u:
					num15 = Game.smethod_3(0, num8);
					num = ((int)num2 * -1537598928) ^ 0x3BC5126F;
					continue;
				case 17u:
				{
					int num16;
					int num17;
					if (playerState2.Resources >= 0)
					{
						num16 = -1971109087;
						num17 = -1971109087;
					}
					else
					{
						num16 = -914822620;
						num17 = -914822620;
					}
					num = num16 ^ ((int)num2 * -1638544486);
					continue;
				}
				case 16u:
					Winners.Add(playerIndex);
					num = (int)(num2 * 824350419) ^ -1464060940;
					continue;
				case 15u:
					playerState.Resources -= num15;
					flag4 = playerState.Resources < 0;
					num = ((int)num2 * -955031460) ^ -436377448;
					continue;
				case 14u:
					flag3 = false;
					num = 618940700;
					continue;
				case 13u:
					Print(playerState.State);
					num = ((int)num2 * -865246048) ^ 0x26A57C1B;
					continue;
				case 12u:
					playerState2 = _playerStates[num3];
					playerState2.Resources -= Game.smethod_3(0, num15 - Players[num3].PlannedForCard(card.Type));
					num = 1468964497;
					continue;
				case 11u:
				{
					int num10;
					int num11;
					if (!onlyOneWinner)
					{
						num10 = -1528208987;
						num11 = -1528208987;
					}
					else
					{
						num10 = -312702002;
						num11 = -312702002;
					}
					num = num10 ^ ((int)num2 * -82011104);
					continue;
				}
				case 10u:
					flag = card.Impact < 0;
					num = ((int)num2 * -1690311185) ^ 0x23B0B9E7;
					continue;
				case 9u:
					Losers.Add(num9);
					num = (int)((num2 * 1544232455) ^ 0x7C98B4A6);
					continue;
				case 8u:
					num3++;
					num = 1656409949;
					continue;
				case 7u:
					num = 316892680;
					continue;
				case 6u:
					num8 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)((num2 * 1843782789) ^ 0x4417E78E);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!Losers.Contains(playerIndex))
					{
						num4 = -1652147096;
						num5 = -1652147096;
					}
					else
					{
						num4 = -243864241;
						num5 = -243864241;
					}
					num = num4 ^ ((int)num2 * -964812703);
					continue;
				}
				case 4u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)((num2 * 434063582) ^ 0x46974CEB);
					continue;
				case 3u:
					num = ((int)num2 * -1110474750) ^ -2141577232;
					continue;
				case 2u:
					Losers.Add(num3);
					num = (int)(num2 * 388559263) ^ -1272958400;
					continue;
				case 1u:
					num = (int)((num2 * 1692084538) ^ 0x4DC53CFC);
					continue;
				case 0u:
					num = ((int)num2 * -1523770836) ^ -1566360231;
					continue;
				default:
					return;
				case 68u:
					break;
				case 73u:
					return;
					IL_0188:
					flag10 = (byte)num21 != 0;
					if (flag)
					{
						num = 324109887;
						num27 = 324109887;
					}
					else
					{
						num = 1552730703;
						num27 = 1552730703;
					}
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		bool flag = default(bool);
		Card result = default(Card);
		Card card = default(Card);
		while (true)
		{
			int num = 1861551879;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9FD2CAu) % 10u)
				{
				case 9u:
					num = (int)(num2 * 387315104) ^ -725247839;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -418032871;
						num4 = -418032871;
					}
					else
					{
						num3 = -1872910386;
						num4 = -1872910386;
					}
					num = num3 ^ ((int)num2 * -1440399604);
					continue;
				}
				case 7u:
					result = card;
					num = ((int)num2 * -1704863566) ^ -1791998890;
					continue;
				case 6u:
					card = _deck[0];
					num = 2109117120;
					continue;
				case 4u:
					_deck.RemoveAt(0);
					num = (int)(num2 * 1448842329) ^ -1113896129;
					continue;
				case 3u:
					ShuffleCards();
					num = (int)((num2 * 846638094) ^ 0x362B44CC);
					continue;
				case 1u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -1331804296) ^ 0x4FECB8D0;
					continue;
				case 0u:
					num = (int)(num2 * 2010303377) ^ -961625384;
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
		string text = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 2048579887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F6E4728u) % 9u)
				{
				case 7u:
					num = ((int)num2 * -1413104269) ^ -458851236;
					continue;
				case 6u:
					text = "";
					num = ((int)num2 * -1403900408) ^ -787511633;
					continue;
				case 5u:
				{
					int num4;
					if (num3 < _playerStates.Length)
					{
						num = 1010939732;
						num4 = 1010939732;
					}
					else
					{
						num = 1620313165;
						num4 = 1620313165;
					}
					continue;
				}
				case 4u:
					num3 = 0;
					num = ((int)num2 * -514788718) ^ -801789652;
					continue;
				case 3u:
					num = (int)(num2 * 2098918953) ^ -752027462;
					continue;
				case 2u:
					result = text;
					num = (int)(num2 * 824153724) ^ -1759318266;
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
					num3++;
					num = 1542961474;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1257801935;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15774922u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = ToString(initial: false);
				num = ((int)num2 * -830086601) ^ -996730971;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = Game.smethod_7(Game.smethod_5(text), more);
		while (true)
		{
			int num = -792298297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x889D2C31u) % 3u)
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
				num = (int)(num2 * 978119504) ^ -284684419;
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
