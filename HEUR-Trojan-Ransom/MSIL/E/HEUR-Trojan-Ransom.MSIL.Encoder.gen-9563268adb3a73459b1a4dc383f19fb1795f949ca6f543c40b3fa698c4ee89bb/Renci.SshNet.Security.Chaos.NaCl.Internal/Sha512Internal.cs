namespace Renci.SshNet.Security.Chaos.NaCl.Internal;

internal static class Sha512Internal
{
	private static readonly ulong[] K = new ulong[80]
	{
		4794697086780616226uL, 8158064640168781261uL, 13096744586834688815uL, 16840607885511220156uL, 4131703408338449720uL, 6480981068601479193uL, 10538285296894168987uL, 12329834152419229976uL, 15566598209576043074uL, 1334009975649890238uL,
		2608012711638119052uL, 6128411473006802146uL, 8268148722764581231uL, 9286055187155687089uL, 11230858885718282805uL, 13951009754708518548uL, 16472876342353939154uL, 17275323862435702243uL, 1135362057144423861uL, 2597628984639134821uL,
		3308224258029322869uL, 5365058923640841347uL, 6679025012923562964uL, 8573033837759648693uL, 10970295158949994411uL, 12119686244451234320uL, 12683024718118986047uL, 13788192230050041572uL, 14330467153632333762uL, 15395433587784984357uL,
		489312712824947311uL, 1452737877330783856uL, 2861767655752347644uL, 3322285676063803686uL, 5560940570517711597uL, 5996557281743188959uL, 7280758554555802590uL, 8532644243296465576uL, 9350256976987008742uL, 10552545826968843579uL,
		11727347734174303076uL, 12113106623233404929uL, 14000437183269869457uL, 14369950271660146224uL, 15101387698204529176uL, 15463397548674623760uL, 17586052441742319658uL, 1182934255886127544uL, 1847814050463011016uL, 2177327727835720531uL,
		2830643537854262169uL, 3796741975233480872uL, 4115178125766777443uL, 5681478168544905931uL, 6601373596472566643uL, 7507060721942968483uL, 8399075790359081724uL, 8693463985226723168uL, 9568029438360202098uL, 10144078919501101548uL,
		10430055236837252648uL, 11840083180663258601uL, 13761210420658862357uL, 14299343276471374635uL, 14566680578165727644uL, 15097957966210449927uL, 16922976911328602910uL, 17689382322260857208uL, 500013540394364858uL, 748580250866718886uL,
		1242879168328830382uL, 1977374033974150939uL, 2944078676154940804uL, 3659926193048069267uL, 4368137639120453308uL, 4836135668995329356uL, 5532061633213252278uL, 6448918945643986474uL, 6902733635092675308uL, 7801388544844847127uL
	};

	internal static void Sha512Init(out Array8<ulong> state)
	{
		state.x0 = 7640891576956012808uL;
		state.x1 = 13503953896175478587uL;
		state.x2 = 4354685564936845355uL;
		state.x3 = 11912009170470909681uL;
		state.x4 = 5840696475078001361uL;
		state.x5 = 11170449401992604703uL;
		state.x6 = 2270897969802886507uL;
		state.x7 = 6620516959819538809uL;
	}

	internal static void Core(out Array8<ulong> outputState, ref Array8<ulong> inputState, ref Array16<ulong> input)
	{
		ulong num = inputState.x0;
		ulong num2 = inputState.x1;
		ulong num3 = inputState.x2;
		ulong num4 = inputState.x3;
		ulong num5 = inputState.x4;
		ulong num6 = inputState.x5;
		ulong num7 = inputState.x6;
		ulong num8 = inputState.x7;
		ulong num9 = input.x0;
		ulong num10 = input.x1;
		ulong num11 = input.x2;
		ulong num12 = input.x3;
		ulong num13 = input.x4;
		ulong num14 = input.x5;
		ulong num15 = input.x6;
		ulong num16 = input.x7;
		ulong num17 = input.x8;
		ulong num18 = input.x9;
		ulong num19 = input.x10;
		ulong num20 = input.x11;
		ulong num21 = input.x12;
		ulong num22 = input.x13;
		ulong num23 = input.x14;
		ulong num24 = input.x15;
		int num25 = 0;
		while (true)
		{
			ulong num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num9;
			ulong num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num10;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num11;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num12;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num13;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num14;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num15;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num16;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num17;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num18;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num19;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num20;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num21;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num22;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num23;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			num26 = num8 + ((num5 >> 14) ^ (num5 << 50) ^ (num5 >> 18) ^ (num5 << 46) ^ (num5 >> 41) ^ (num5 << 23)) + ((num5 & num6) ^ (~num5 & num7)) + K[num25] + num24;
			num27 = ((num >> 28) ^ (num << 36) ^ (num >> 34) ^ (num << 30) ^ (num >> 39) ^ (num << 25)) + ((num & num2) ^ (num & num3) ^ (num2 & num3));
			num8 = num7;
			num7 = num6;
			num6 = num5;
			num5 = num4 + num26;
			num4 = num3;
			num3 = num2;
			num2 = num;
			num = num26 + num27;
			num25++;
			if (num25 == 80)
			{
				break;
			}
			num9 += ((num23 >> 19) ^ (num23 << 45) ^ (num23 >> 61) ^ (num23 << 3) ^ (num23 >> 6)) + num18 + ((num10 >> 1) ^ (num10 << 63) ^ (num10 >> 8) ^ (num10 << 56) ^ (num10 >> 7));
			num10 += ((num24 >> 19) ^ (num24 << 45) ^ (num24 >> 61) ^ (num24 << 3) ^ (num24 >> 6)) + num19 + ((num11 >> 1) ^ (num11 << 63) ^ (num11 >> 8) ^ (num11 << 56) ^ (num11 >> 7));
			num11 += ((num9 >> 19) ^ (num9 << 45) ^ (num9 >> 61) ^ (num9 << 3) ^ (num9 >> 6)) + num20 + ((num12 >> 1) ^ (num12 << 63) ^ (num12 >> 8) ^ (num12 << 56) ^ (num12 >> 7));
			num12 += ((num10 >> 19) ^ (num10 << 45) ^ (num10 >> 61) ^ (num10 << 3) ^ (num10 >> 6)) + num21 + ((num13 >> 1) ^ (num13 << 63) ^ (num13 >> 8) ^ (num13 << 56) ^ (num13 >> 7));
			num13 += ((num11 >> 19) ^ (num11 << 45) ^ (num11 >> 61) ^ (num11 << 3) ^ (num11 >> 6)) + num22 + ((num14 >> 1) ^ (num14 << 63) ^ (num14 >> 8) ^ (num14 << 56) ^ (num14 >> 7));
			num14 += ((num12 >> 19) ^ (num12 << 45) ^ (num12 >> 61) ^ (num12 << 3) ^ (num12 >> 6)) + num23 + ((num15 >> 1) ^ (num15 << 63) ^ (num15 >> 8) ^ (num15 << 56) ^ (num15 >> 7));
			num15 += ((num13 >> 19) ^ (num13 << 45) ^ (num13 >> 61) ^ (num13 << 3) ^ (num13 >> 6)) + num24 + ((num16 >> 1) ^ (num16 << 63) ^ (num16 >> 8) ^ (num16 << 56) ^ (num16 >> 7));
			num16 += ((num14 >> 19) ^ (num14 << 45) ^ (num14 >> 61) ^ (num14 << 3) ^ (num14 >> 6)) + num9 + ((num17 >> 1) ^ (num17 << 63) ^ (num17 >> 8) ^ (num17 << 56) ^ (num17 >> 7));
			num17 += ((num15 >> 19) ^ (num15 << 45) ^ (num15 >> 61) ^ (num15 << 3) ^ (num15 >> 6)) + num10 + ((num18 >> 1) ^ (num18 << 63) ^ (num18 >> 8) ^ (num18 << 56) ^ (num18 >> 7));
			num18 += ((num16 >> 19) ^ (num16 << 45) ^ (num16 >> 61) ^ (num16 << 3) ^ (num16 >> 6)) + num11 + ((num19 >> 1) ^ (num19 << 63) ^ (num19 >> 8) ^ (num19 << 56) ^ (num19 >> 7));
			num19 += ((num17 >> 19) ^ (num17 << 45) ^ (num17 >> 61) ^ (num17 << 3) ^ (num17 >> 6)) + num12 + ((num20 >> 1) ^ (num20 << 63) ^ (num20 >> 8) ^ (num20 << 56) ^ (num20 >> 7));
			num20 += ((num18 >> 19) ^ (num18 << 45) ^ (num18 >> 61) ^ (num18 << 3) ^ (num18 >> 6)) + num13 + ((num21 >> 1) ^ (num21 << 63) ^ (num21 >> 8) ^ (num21 << 56) ^ (num21 >> 7));
			num21 += ((num19 >> 19) ^ (num19 << 45) ^ (num19 >> 61) ^ (num19 << 3) ^ (num19 >> 6)) + num14 + ((num22 >> 1) ^ (num22 << 63) ^ (num22 >> 8) ^ (num22 << 56) ^ (num22 >> 7));
			num22 += ((num20 >> 19) ^ (num20 << 45) ^ (num20 >> 61) ^ (num20 << 3) ^ (num20 >> 6)) + num15 + ((num23 >> 1) ^ (num23 << 63) ^ (num23 >> 8) ^ (num23 << 56) ^ (num23 >> 7));
			num23 += ((num21 >> 19) ^ (num21 << 45) ^ (num21 >> 61) ^ (num21 << 3) ^ (num21 >> 6)) + num16 + ((num24 >> 1) ^ (num24 << 63) ^ (num24 >> 8) ^ (num24 << 56) ^ (num24 >> 7));
			num24 += ((num22 >> 19) ^ (num22 << 45) ^ (num22 >> 61) ^ (num22 << 3) ^ (num22 >> 6)) + num17 + ((num9 >> 1) ^ (num9 << 63) ^ (num9 >> 8) ^ (num9 << 56) ^ (num9 >> 7));
		}
		outputState.x0 = inputState.x0 + num;
		outputState.x1 = inputState.x1 + num2;
		outputState.x2 = inputState.x2 + num3;
		outputState.x3 = inputState.x3 + num4;
		outputState.x4 = inputState.x4 + num5;
		outputState.x5 = inputState.x5 + num6;
		outputState.x6 = inputState.x6 + num7;
		outputState.x7 = inputState.x7 + num8;
	}
}
