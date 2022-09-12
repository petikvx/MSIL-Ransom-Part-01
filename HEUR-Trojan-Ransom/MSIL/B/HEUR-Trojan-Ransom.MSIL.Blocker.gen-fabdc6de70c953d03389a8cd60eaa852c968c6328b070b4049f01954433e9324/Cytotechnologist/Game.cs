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
			PlayerState[] playerStates = default(PlayerState[]);
			bool flag = default(bool);
			int num3 = default(int);
			bool result = default(bool);
			bool finished = default(bool);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = -708935829;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC9BF9E40u) % 17u)
					{
					case 16u:
						playerStates = _playerStates;
						num = -767074477;
						continue;
					case 14u:
					{
						int num7;
						int num8;
						if (flag)
						{
							num7 = -963091144;
							num8 = -963091144;
						}
						else
						{
							num7 = -1305551344;
							num8 = -1305551344;
						}
						num = num7 ^ ((int)num2 * -1516152320);
						continue;
					}
					case 13u:
						num = (int)((num2 * 781845534) ^ 0xA6B5F39);
						continue;
					case 11u:
						num3 = 0;
						num = (int)(num2 * 1626879675) ^ -1638216226;
						continue;
					case 10u:
						result = false;
						num = ((int)num2 * -352820156) ^ -199822128;
						continue;
					case 9u:
						num = (int)(num2 * 1169394000) ^ -1085151902;
						continue;
					case 8u:
						finished = _finished;
						num = ((int)num2 * -328918879) ^ -668946042;
						continue;
					case 7u:
						num3++;
						num = -1579604005;
						continue;
					case 6u:
						playerState = playerStates[num3];
						num = -1398672855;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (finished)
						{
							num5 = -1050607222;
							num6 = -1050607222;
						}
						else
						{
							num5 = -1076592346;
							num6 = -1076592346;
						}
						num = num5 ^ (int)(num2 * 809256300);
						continue;
					}
					case 4u:
						flag = playerState.State == State.Playing;
						num = (int)(num2 * 582343200) ^ -59515353;
						continue;
					case 3u:
						num = ((int)num2 * -2013484227) ^ -1772066558;
						continue;
					case 2u:
					{
						int num4;
						if (num3 < playerStates.Length)
						{
							num = -568237774;
							num4 = -568237774;
						}
						else
						{
							num = -1384777978;
							num4 = -1384777978;
						}
						continue;
					}
					case 1u:
						result = true;
						num = (int)((num2 * 176204268) ^ 0xADEC4C1);
						continue;
					case 0u:
						result = true;
						num = ((int)num2 * -1672306149) ^ 0x4B073D80;
						continue;
					case 12u:
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
		while (true)
		{
			int num = -964889560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xABA50DC8u) % 3u)
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
				num = (int)(num2 * 843689407) ^ -1129544879;
			}
		}
	}

	public void StartNew()
	{
		while (true)
		{
			int num = 919668521;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11D30621u) % 9u)
				{
				case 7u:
					_currentTurn = 0;
					_finished = false;
					num = (int)((num2 * 1812825431) ^ 0x1EA493F3);
					continue;
				case 6u:
					_chances = new List<float>(Rules.RiskChances);
					num = (int)((num2 * 269362199) ^ 0xE976E);
					continue;
				case 5u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1814582129) ^ 0x3F06C58C;
					continue;
				case 4u:
					Winners.Clear();
					num = ((int)num2 * -101222548) ^ 0x421FC342;
					continue;
				case 3u:
					_currentChanceIndex = -1;
					num = (int)(num2 * 868226760) ^ -2102385115;
					continue;
				case 2u:
					ShuffleCards();
					num = (int)(num2 * 1207064852) ^ -1780570507;
					continue;
				case 1u:
					Losers.Clear();
					num = ((int)num2 * -1797932276) ^ 0x4D24B1D2;
					continue;
				default:
					return;
				case 8u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		PlayerState playerState = default(PlayerState);
		int num3 = default(int);
		int num4 = default(int);
		int planningCardsCount = default(int);
		bool flag = default(bool);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1856477958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64201283u) % 28u)
				{
				case 27u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = (int)(num2 * 868449907) ^ -74056671;
					continue;
				case 26u:
					playerState.Sprint = 1;
					num = (int)((num2 * 1335839887) ^ 0x3C47F69D);
					continue;
				case 25u:
					num4++;
					num = ((int)num2 * -1900647700) ^ -1552233340;
					continue;
				case 24u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = 1542126674;
					continue;
				case 23u:
					flag = num3 > 0;
					num = 1888497233;
					continue;
				case 22u:
				{
					int num8;
					int num9;
					if (useOneMorePlanningSprint)
					{
						num8 = 662727211;
						num9 = 662727211;
					}
					else
					{
						num8 = 1131758548;
						num9 = 1131758548;
					}
					num = num8 ^ (int)(num2 * 1609283516);
					continue;
				}
				case 21u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)(num2 * 1543193480) ^ -1205582315;
					continue;
				case 20u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = 455030673;
					continue;
				case 19u:
					player = Players[num4];
					playerState = _playerStates[num4];
					num = (int)(num2 * 1209158726) ^ -2147233500;
					continue;
				case 18u:
					num = 2115953147;
					continue;
				case 17u:
					num = (int)(num2 * 250949172) ^ -777390724;
					continue;
				case 16u:
					num3 = 0;
					num = 499239133;
					continue;
				case 15u:
					num = (int)((num2 * 1933408012) ^ 0x53C4BF39);
					continue;
				case 13u:
					flag2 = planningCardsCount == 0;
					num = ((int)num2 * -1092099762) ^ -289768799;
					continue;
				case 12u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = -277423973;
						num11 = -277423973;
					}
					else
					{
						num10 = -1521300875;
						num11 = -1521300875;
					}
					num = num10 ^ ((int)num2 * -1093490663);
					continue;
				}
				case 11u:
					playerState.Resources = Rules.InitialResources;
					num = (int)(num2 * 1528881846) ^ -1722813442;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -414091968;
						num7 = -414091968;
					}
					else
					{
						num6 = -1312129649;
						num7 = -1312129649;
					}
					num = num6 ^ (int)(num2 * 737450468);
					continue;
				}
				case 9u:
					num4 = 0;
					num = (int)((num2 * 1993013586) ^ 0x3E488570);
					continue;
				case 8u:
					num = ((int)num2 * -1300288747) ^ -849131569;
					continue;
				case 7u:
				{
					int num5;
					if (num4 >= Players.Length)
					{
						num = 1044583993;
						num5 = 1044583993;
					}
					else
					{
						num = 827953857;
						num5 = 827953857;
					}
					continue;
				}
				case 6u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = (int)((num2 * 624580128) ^ 0x3B51F551);
					continue;
				case 5u:
					planningCardsCount = player.PlanningCardsCount;
					num3 = 0;
					num = ((int)num2 * -1346946566) ^ -1305009512;
					continue;
				case 3u:
					playerState.State = State.Playing;
					num = ((int)num2 * -117898003) ^ -448246511;
					continue;
				case 2u:
					num = 901384828;
					continue;
				case 1u:
					playerState.Sprint = 0;
					num = ((int)num2 * -57212854) ^ -967103886;
					continue;
				case 0u:
					playerState.Sprint = -1;
					num = (int)((num2 * 988552404) ^ 0x783A445A);
					continue;
				default:
					return;
				case 4u:
					break;
				case 14u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		bool flag = _currentPlayer >= Players.Length;
		while (true)
		{
			int num = -694986607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5729B6Bu) % 14u)
				{
				case 13u:
					_currentPlayer = 0;
					num = ((int)num2 * -1830017402) ^ -664799162;
					continue;
				case 12u:
					PlayerTurn(_currentPlayer);
					num = -745679837;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (_currentTurn > 0)
					{
						num5 = 240668690;
						num6 = 240668690;
					}
					else
					{
						num5 = 352474510;
						num6 = 352474510;
					}
					num = num5 ^ ((int)num2 * -833489691);
					continue;
				}
				case 10u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1278675603) ^ 0x65A746D3;
					continue;
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)((num2 * 1033747691) ^ 0x1AC67029);
					continue;
				case 8u:
					num = (int)((num2 * 684083206) ^ 0x816020A);
					continue;
				case 7u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 1729647023) ^ 0x1624515B);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 314737723;
						num4 = 314737723;
					}
					else
					{
						num3 = 1194944148;
						num4 = 1194944148;
					}
					num = num3 ^ (int)(num2 * 2088597834);
					continue;
				}
				case 4u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -1128186169;
					continue;
				case 2u:
					num = (int)((num2 * 1175051727) ^ 0x20BC15EB);
					continue;
				case 1u:
					num = (int)((num2 * 1830874562) ^ 0x573EC981);
					continue;
				case 0u:
					num = ((int)num2 * -1843191588) ^ -780329358;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		bool flag4 = default(bool);
		int num14 = default(int);
		bool flag7 = default(bool);
		Card card = default(Card);
		PlayerState playerState = default(PlayerState);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		bool flag3 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		int num10 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag12 = default(bool);
		bool onlyOneWinner = default(bool);
		bool flag5 = default(bool);
		int num30 = default(int);
		Player player = default(Player);
		bool flag11 = default(bool);
		bool flag8 = default(bool);
		bool flag = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = -1442770292;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0x877B6D2Cu) % 86u)
				{
				case 85u:
					flag4 = true;
					num = ((int)num2 * -1492235738) ^ 0x21D5666B;
					continue;
				case 84u:
				{
					int num22;
					int num23;
					if (num14 != playerIndex)
					{
						num22 = 2018743708;
						num23 = 2018743708;
					}
					else
					{
						num22 = 166042053;
						num23 = 166042053;
					}
					num = num22 ^ ((int)num2 * -569225537);
					continue;
				}
				case 83u:
					num = ((int)num2 * -1009368829) ^ -630375063;
					continue;
				case 82u:
					flag7 = card.Impact < 0;
					num = (int)((num2 * 200288008) ^ 0x60E0456E);
					continue;
				case 81u:
					num = ((int)num2 * -144167604) ^ 0x419A4F29;
					continue;
				case 80u:
					num = (int)(num2 * 1666255421) ^ -1790534108;
					continue;
				case 79u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -1399059776;
					continue;
				}
				case 78u:
					num = ((int)num2 * -266996365) ^ 0x5980026D;
					continue;
				case 77u:
					flag10 = playerState.State != State.Playing;
					num = (int)(num2 * 1202724024) ^ -1493236153;
					continue;
				case 76u:
					flag9 = !Losers.Contains(num14);
					num = -1627310987;
					continue;
				case 75u:
					num = (int)((num2 * 639649160) ^ 0x3E85D5D7);
					continue;
				case 74u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = 454130116;
						num9 = 454130116;
					}
					else
					{
						num8 = 9566963;
						num9 = 9566963;
					}
					num = num8 ^ ((int)num2 * -1020106214);
					continue;
				}
				case 73u:
					Print("CARD: none, advance");
					num = (int)(num2 * 700530464) ^ -1216858625;
					continue;
				case 72u:
				{
					int num33;
					if (playerState.Sprint > Rules.SprintCount)
					{
						num = -658847789;
						num33 = -658847789;
					}
					else
					{
						num = -1864736839;
						num33 = -1864736839;
					}
					continue;
				}
				case 71u:
					num = ((int)num2 * -1263228544) ^ 0x3AF06E11;
					continue;
				case 70u:
					num = ((int)num2 * -462415155) ^ -1321860872;
					continue;
				case 69u:
					num = -1999833063;
					continue;
				case 68u:
					playerState2.Resources -= Game.smethod_3(0, num10 - Players[num3].PlannedForCard(card.Type));
					flag2 = playerState2.Resources >= 0;
					num = (int)(num2 * 508451090) ^ -287234301;
					continue;
				case 67u:
					num7 = ((card.Type == 4) ? 1 : 0);
					goto IL_0231;
				case 65u:
					playerState.Sprint++;
					num = ((int)num2 * -878005239) ^ 0x1C58E525;
					continue;
				case 64u:
					num = (int)(num2 * 1856965528) ^ -1051428777;
					continue;
				case 63u:
					Print("Still planning");
					num = (int)((num2 * 1689246129) ^ 0x675B456);
					continue;
				case 62u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -1685035155) ^ -1792789353;
					continue;
				case 61u:
					playerState.Resources -= num10;
					flag12 = playerState.Resources < 0;
					num = (int)(num2 * 1614069845) ^ -1885894456;
					continue;
				case 60u:
					num14++;
					num = -88921632;
					continue;
				case 59u:
				{
					int num18;
					int num19;
					if (!onlyOneWinner)
					{
						num18 = 30155009;
						num19 = 30155009;
					}
					else
					{
						num18 = 140039595;
						num19 = 140039595;
					}
					num = num18 ^ (int)(num2 * 1104364084);
					continue;
				}
				case 58u:
					num = (int)(num2 * 2114820264) ^ -568463257;
					continue;
				case 57u:
					Winners.Add(playerIndex);
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -475432309) ^ 0x737EDB84;
					continue;
				case 56u:
				{
					int num13;
					if (playerState.Sprint >= 0)
					{
						num = -1295171077;
						num13 = -1295171077;
					}
					else
					{
						num = -1285303284;
						num13 = -1285303284;
					}
					continue;
				}
				case 55u:
					num = -1656707361;
					continue;
				case 54u:
				{
					int num11;
					int num12;
					if (!flag5)
					{
						num11 = -1030563026;
						num12 = -1030563026;
					}
					else
					{
						num11 = -2023259297;
						num12 = -2023259297;
					}
					num = num11 ^ ((int)num2 * -123708128);
					continue;
				}
				case 53u:
					flag4 = false;
					num = -1482328030;
					continue;
				case 52u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -2107591798) ^ -1805741387;
						continue;
					}
					num7 = 0;
					goto IL_0231;
				case 51u:
					num = -218423088;
					continue;
				case 50u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -1325105990) ^ 0x63E3CEDB;
					continue;
				case 49u:
					num = ((int)num2 * -1881014104) ^ -470605448;
					continue;
				case 48u:
					num = ((int)num2 * -1725096715) ^ -1227256540;
					continue;
				case 47u:
					num10 = card.Impact;
					num = ((int)num2 * -1629172151) ^ 0x485FCC1;
					continue;
				case 46u:
					num30 = card.Impact - player.PlannedForCard(card.Type);
					flag4 = num30 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -1947116151) ^ 0x1CDFE0F5;
					continue;
				case 45u:
					num = -1006063974;
					continue;
				case 44u:
					playerState.State = State.Lose;
					flag11 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1251824891) ^ -219257895;
					continue;
				case 43u:
					num = ((int)num2 * -1011751547) ^ -1453035745;
					continue;
				case 42u:
					Losers.Add(num14);
					num = ((int)num2 * -993250272) ^ 0x4448F7EB;
					continue;
				case 41u:
					playerState.State = State.Won;
					num = (int)(num2 * 771263673) ^ -1382417370;
					continue;
				case 40u:
					flag3 = num14 < _playerStates.Length;
					num = -1199703666;
					continue;
				case 39u:
				{
					int num34;
					int num35;
					if (flag12)
					{
						num34 = -129896271;
						num35 = -129896271;
					}
					else
					{
						num34 = -1600636179;
						num35 = -1600636179;
					}
					num = num34 ^ (int)(num2 * 2006325743);
					continue;
				}
				case 38u:
					num14 = 0;
					num = ((int)num2 * -857699371) ^ 0x4DC27E82;
					continue;
				case 37u:
					playerState2 = _playerStates[num3];
					num = (int)(num2 * 1673650902) ^ -1654165100;
					continue;
				case 36u:
					num = -1318018761;
					continue;
				case 35u:
				{
					int num31;
					int num32;
					if (flag9)
					{
						num31 = 866792390;
						num32 = 866792390;
					}
					else
					{
						num31 = 1150522641;
						num32 = 1150522641;
					}
					num = num31 ^ ((int)num2 * -2056777846);
					continue;
				}
				case 34u:
					player = Players[playerIndex];
					playerState = _playerStates[playerIndex];
					num = (int)((num2 * 270255252) ^ 0x4125CF46);
					continue;
				case 33u:
					num = ((int)num2 * -477728085) ^ -1445503956;
					continue;
				case 32u:
					num = -622457577;
					continue;
				case 31u:
					num10 = Game.smethod_3(0, num30);
					num = (int)(num2 * 870888377) ^ -941573945;
					continue;
				case 30u:
					playerState.Sprint++;
					num = ((int)num2 * -1878207093) ^ 0x71C7FEF;
					continue;
				case 29u:
					num = -1864736839;
					continue;
				case 28u:
				{
					int num28;
					int num29;
					if (!flag7)
					{
						num28 = -505561174;
						num29 = -505561174;
					}
					else
					{
						num28 = -623664532;
						num29 = -623664532;
					}
					num = num28 ^ (int)(num2 * 1309170176);
					continue;
				}
				case 27u:
				{
					int num26;
					int num27;
					if (!flag8)
					{
						num26 = -376261347;
						num27 = -376261347;
					}
					else
					{
						num26 = -769448078;
						num27 = -769448078;
					}
					num = num26 ^ ((int)num2 * -418736562);
					continue;
				}
				case 26u:
					Print(playerState.State);
					num = (int)(num2 * 900641642) ^ -751546960;
					continue;
				case 25u:
				{
					int num24;
					int num25;
					if (flag10)
					{
						num24 = -1071226626;
						num25 = -1071226626;
					}
					else
					{
						num24 = -1727461172;
						num25 = -1727461172;
					}
					num = num24 ^ ((int)num2 * -751437718);
					continue;
				}
				case 24u:
					card = DrawCard();
					num = (int)((num2 * 2115086595) ^ 0x137E3F32);
					continue;
				case 23u:
					num3 = 0;
					num = (int)((num2 * 725838449) ^ 0x5B65EFC1);
					continue;
				case 22u:
					num = ((int)num2 * -888348863) ^ -1563879072;
					continue;
				case 21u:
				{
					int num20;
					int num21;
					if (flag11)
					{
						num20 = 1794452400;
						num21 = 1794452400;
					}
					else
					{
						num20 = 1341248417;
						num21 = 1341248417;
					}
					num = num20 ^ (int)(num2 * 922744530);
					continue;
				}
				case 20u:
					num = ((int)num2 * -2060833954) ^ 0x1DC25128;
					continue;
				case 19u:
					Losers.Add(num3);
					num = (int)(num2 * 648452927) ^ -854059544;
					continue;
				case 18u:
					num3++;
					num = -164850932;
					continue;
				case 16u:
				{
					int num16;
					int num17;
					if (!flag)
					{
						num16 = 1553589312;
						num17 = 1553589312;
					}
					else
					{
						num16 = 22863313;
						num17 = 22863313;
					}
					num = num16 ^ (int)(num2 * 1371047904);
					continue;
				}
				case 15u:
				{
					playerState2.State = State.Lose;
					int num15;
					if (!Losers.Contains(num3))
					{
						num = -1792262001;
						num15 = -1792262001;
					}
					else
					{
						num = -1037548129;
						num15 = -1037548129;
					}
					continue;
				}
				case 14u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag6 ? "ALL " : "", flag7 ? "receives" : "pays", Game.smethod_4(num10), flag4 ? "advance" : "stay");
					flag8 = !flag6;
					num = -671718131;
					continue;
				case 13u:
					num = ((int)num2 * -1668347023) ^ -1210415844;
					continue;
				case 12u:
					num = (int)((num2 * 1758116878) ^ 0x7D6C8C14);
					continue;
				case 11u:
					num = (int)((num2 * 289099527) ^ 0x758E7A3E);
					continue;
				case 10u:
					num = -678121884;
					continue;
				case 9u:
					flag4 = true;
					num = ((int)num2 * -485110816) ^ 0x5A44422D;
					continue;
				case 8u:
					num = (int)(num2 * 1494495948) ^ -472732171;
					continue;
				case 7u:
					_finished = true;
					num = (int)((num2 * 229870638) ^ 0x467E2224);
					continue;
				case 6u:
					num = -1408891552;
					continue;
				case 5u:
					flag5 = flag4;
					num = -1284639700;
					continue;
				case 4u:
					num = ((int)num2 * -958374201) ^ 0x61E11DC1;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1886959459;
						num6 = -1886959459;
					}
					else
					{
						num5 = -1030780751;
						num6 = -1030780751;
					}
					num = num5 ^ (int)(num2 * 1310656816);
					continue;
				}
				case 2u:
					num = -2141187644;
					continue;
				case 1u:
				{
					int num4;
					if (_dice.Roll(_chances[_currentChanceIndex]))
					{
						num = -993199890;
						num4 = -993199890;
					}
					else
					{
						num = -376960470;
						num4 = -376960470;
					}
					continue;
				}
				case 0u:
					flag = num3 < _playerStates.Length;
					num = -524798358;
					continue;
				default:
					return;
				case 66u:
					break;
				case 17u:
					return;
					IL_0231:
					flag6 = (byte)num7 != 0;
					num = -1617465836;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card card = default(Card);
		Card result = default(Card);
		while (true)
		{
			int num = 1922592265;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58FB0140u) % 7u)
				{
				case 5u:
					card = _deck[0];
					num = 1659747908;
					continue;
				case 3u:
					ShuffleCards();
					num = ((int)num2 * -981080725) ^ 0x364F91C1;
					continue;
				case 2u:
					_deck.RemoveAt(0);
					result = card;
					num = (int)(num2 * 1509070020) ^ -1123887746;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_deck.Count > 0)
					{
						num3 = 995536290;
						num4 = 995536290;
					}
					else
					{
						num3 = 1919418545;
						num4 = 1919418545;
					}
					num = num3 ^ (int)(num2 * 1725438634);
					continue;
				}
				case 0u:
					num = (int)(num2 * 429303553) ^ -62994728;
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
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1785119244;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x942FC4EDu) % 8u)
				{
				case 7u:
					num3++;
					num = ((int)num2 * -57854230) ^ -900290365;
					continue;
				case 6u:
					result = text;
					num = ((int)num2 * -1531437325) ^ -28514859;
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
					num = -868786214;
					continue;
				}
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 841609460;
						num5 = 841609460;
					}
					else
					{
						num4 = 466100751;
						num5 = 466100751;
					}
					num = num4 ^ ((int)num2 * -1457830171);
					continue;
				}
				case 1u:
					text = "";
					num3 = 0;
					num = ((int)num2 * -39698996) ^ -550787479;
					continue;
				case 0u:
					flag = num3 < _playerStates.Length;
					num = -48508442;
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
