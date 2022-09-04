namespace Loader;

internal sealed class ResourceContext
{
	internal static VectorFactory previousId/* Not supported: data(D9 2C 00 00 66 22 00 00 93 9C 00 00 34 B9 00 00 C7 69 00 00 01 3A 00 00 A0 50 00 00 FB 69 00 00 AE 50 00 00 7F 90 00 00 A1 A6 00 00 E8 84 00 00 16 64 00 00 53 39 00 00 2F D3 00 00 0F 25 00 00 31 AE 00 00 15 F3 00 00 F0 EC 00 00 38 46 00 00 A9 9B 00 00 A7 E6 00 00 60 35 00 00 97 9F 00 00 36 88 00 00 FA 7D 00 00 06 C3 00 00 39 45 00 00 3D 97 00 00 AC 51 00 00 E0 36 00 00 8D 70 00 00 2B B9 00 00 CE D4 00 00 84 5B 00 00 00 A6 00 00 85 C1 00 00 D7 6A 00 00 D1 B7 00 00 07 75 00 00 D0 7A 00 00 5C 6E 00 00 E9 A7 00 00 36 7A 00 00 9D 6D 00 00 EE FB 00 00 68 E8 00 00 1F E8 00 00 D7 90 00 00 3D 2A 00 00 9B BC 00 00 6D B3 00 00 40 D1 00 00 A8 17 00 00 7C 92 00 00 31 46 00 00 05 ED 00 00 FA FC 00 00 FD 30 00 00 CC EB 00 00 FA 76 00 00 66 0B 00 00 BD D2 00 00 01 FF 00 00 9E 59 00 00 14 36 00 00 BB CB 00 00 46 8F 00 00 CD DD 00 00 2F 2D 00 00 88 63 00 00 5A 43 00 00 44 3B 00 00 E8 77 00 00 66 CB 00 00 4C 2D 00 00 BD 3E 00 00 28 BB 00 00 FA 31 00 00 47 8C 00 00 90 95 00 00 E5 DA 00 00 61 B4 00 00 00 6D 00 00 0F 95 00 00 71 83 00 00 4B 9F 00 00 83 A1 00 00 52 42 00 00 53 15 00 00 FA B8 00 00 8A C4 00 00 D9 39 00 00 03 CC 00 00 0C FE 00 00 6A 6F 00 00 9D 9B 00 00 E7 A8 00 00 98 20 00 00 88 37 00 00 32 30 00 00 21 59 00 00 52 0A 00 00 A8 63 00 00 B3 C6 00 00 40 79 00 00 28 78 00 00 57 59 00 00 40 4C 00 00 30 65 00 00 74 07 00 00 DD 31 00 00 FF CA 00 00 B5 A4 00 00 3B 56 00 00 14 9C 00 00 03 57 00 00 BD 65 00 00 F1 69 00 00 2B D6 00 00 C7 96 00 00 37 2A 00 00 F4 4C 00 00 79 C8 00 00 33 74 00 00 FD 9E 00 00 81 09 00 00 40 6F 00 00 DB 79 00 00 FC 5B 00 00 AE 91 00 00 D4 95 00 00 8F 9A 00 00 70 FA 00 00 15 5C 00 00 6F 3C 00 00 93 D0 00 00 B9 50 00 00 4B A6 00 00 CE 1B 00 00 48 0B 00 00 F3 45 00 00 43 55 00 00 20 DD 00 00 DF 0D 00 00 1C 87 00 00 8A F9 00 00 23 95 00 00 C8 75 00 00 F7 61 00 00 66 18 00 00 DF 35 00 00 F6 3E 00 00 6B 4A 00 00 C0 A0 00 00 FA 05 00 00 2C 0C 00 00 D7 41 00 00 73 EF 00 00 B5 27 00 00 BF 6F 00 00 E8 08 00 00 7B DF 00 00 42 F0 00 00 81 D3 00 00 9E 71 00 00 4C 97 00 00 8D D0 00 00 9F 48 00 00 CC 19 00 00 80 CB 00 00 4A 06 00 00 70 BF 00 00 22 4E 00 00 E2 CA 00 00 D3 50 00 00 F3 D4 00 00 D2 6F 00 00 9A BA 00 00 16 ED 00 00 72 A5 00 00 5D 74 00 00 76 F9 00 00 E3 17 00 00 96 43 00 00 CE 5B 00 00 DE 56 00 00 24 50 00 00 B0 59 00 00 1A 56 00 00 42 30 00 00 BB 8E 00 00 45 61 00 00 96 7E 00 00 0E AC 00 00 60 02 00 00 77 66 00 00 00 65 00 00 9F 09 00 00 3F 9C 00 00 CF EF 00 00 FC 28 00 00 83 4C 00 00 FB 5B 00 00 76 96 00 00 1C 12 00 00 6E 76 00 00 D2 F0 00 00 87 7F 00 00 EC 4F 00 00 06 31 00 00 58 9C 00 00 3C 87 00 00 5D 02 00 00 42 82 00 00 61 FB 00 00 70 0F 00 00 97 C7 00 00 AB AC 00 00 B2 77 00 00 BF 1A 00 00 27 47 00 00 DC 76 00 00 84 F2 00 00 89 E9 00 00 C4 3C 00 00 04 A5 00 00 DA 40 00 00 13 A2 00 00 82 C8 00 00 5B EA 00 00 F3 6F 00 00 33 66 00 00 5A 1E 00 00 45 FD 00 00 75 7C 00 00 DA 27 00 00 7B 9D 00 00 6C 81 00 00 79 31 00 00 5F E5 00 00 0B 66 00 00 9B D0 00 00 C4 09 00 00 14 25 00 00 E8 93 00 00 7F 07 00 00 E8 5E 00 00 52 FC 00 00 AC B0 00 00 EE F2 00 00 DF 9E 00 00 53 B8 00 00 EC 91 00 00 80 81 00 00 A7 A8 00 00 1E B2 00 00 FD 59 00 00 71 72 00 00 B1 59 00 00 17 6D 00 00 93 35 00 00 BF 4E 00 00 04 B7 00 00 90 65 00 00 12 C1 00 00 25 36 00 00 E1 68 00 00 16 05 00 00 CC 05 00 00 86 D3 00 00 F4 71 00 00 2A 46 00 00 32 7B 00 00 52 92 00 00 B3 B4 00 00 8B 76 00 00 18 6D 00 00 70 CD 00 00 A1 55 00 00 45 35 00 00 1B 46 00 00 86 44 00 00 65 F1 00 00 93 D5 00 00 7C 4B 00 00 9E B7 00 00 46 D4 00 00 D9 9C 00 00 9E 54 00 00 55 CA 00 00 DB CD 00 00 09 2B 00 00 BA 27 00 00 61 C4 00 00 CB AF 00 00 4C 17 00 00 97 19 00 00 32 A4 00 00 01 64 00 00 C2 5D 00 00 9C 9E 00 00 D1 59 00 00 86 F6 00 00 24 DD 00 00 F9 80 00 00 B4 58 00 00 21 3D 00 00 98 FF 00 00 CB CC 00 00 1C 32 00 00 06 45 00 00 8C 8C 00 00 D0 1C 00 00 6B 24 00 00 FB 26 00 00 0C F1 00 00 58 5D 00 00 6F E1 00 00 14 1A 00 00 73 09 00 00 DE 61 00 00 07 CC 00 00 77 B0 00 00 75 3B 00 00 AA 05 00 00 EA 46 00 00 6F 1E 00 00 CF B6 00 00 86 E2 00 00 67 9D 00 00 F3 5C 00 00 E4 C8 00 00 6F 69 00 00 DD F7 00 00 A8 96 00 00 49 EC 00 00 FF 4D 00 00 41 14 00 00 9A 54 00 00 C6 F2 00 00 7D 7A 00 00 AC D4 00 00 0C D0 00 00 81 22 00 00 4F 85 00 00 4F 41 00 00 39 0E 00 00 4F 03 00 00 66 9D 00 00 BE BE 00 00 F3 B9 00 00 27 38 00 00 1E 8A 00 00 8D 5A 00 00 E2 FB 00 00 93 D2 00 00 59 A9 00 00 10 BB 00 00 79 D7 00 00 0E 3A 00 00 44 3A 00 00 50 86 00 00 11 1D 00 00 64 2F 00 00 27 D5 00 00 20 7C 00 00 1D 23 00 00 F1 24 00 00 C2 8D 00 00 B1 3A 00 00 0C A3 00 00 16 49 00 00 D5 8C 00 00 4C 27 00 00 F4 8E 00 00 31 8D 00 00 FA FB 00 00 F5 8D 00 00 25 B6 00 00 5A C4 00 00 B1 38 00 00 20 1B 00 00 69 19 00 00 C8 23 00 00 73 E3 00 00 CC 24 00 00 C5 3E 00 00 E1 0E 00 00 FA FB 00 00 13 C4 00 00 EF 42 00 00 ED 92 00 00 C6 3C 00 00 8B 1A 00 00 82 B8 00 00 2C F4 00 00 9B B7 00 00 A7 A0 00 00 58 4D 00 00) */;

	internal static int[] previousId;

	internal static CommandSite previousId/* Not supported: data(3B B3 10 B1 89 C8 82 1C B1 25 F8 F3 14 40 EF C5 FE C0 5F 02 0F B0 FD 22 F3 ED 64 CE 1F 59 21 21 B6 7F 5D AD 54 F0 71 01 4A 8E 8E 2D 15 EF 91 64 E1 91 A6 C7 9A AD E2 89 B5 EC BD 9B 63 B2 FB 58 04 D7 3D 93 E2 41 71 0E 4E 5D B7 7F 22 CF 0D 03 5C FE EC 8D B2 58 85 08 9C D2 F7 67 33 D5 9D 96 91 35 29 3D B1 FC 81 9F 20 98 79 3D F5 62 67 E4 DF B9 3E 63 C5 6E A4 AA 52 34 F6 0F 49 09 DA 78 BF 20 EC EB A6 CF 51 5E 7D 4C 6D 1A DE 47 12 39 6B 12 86 79 96 39 D0 23 8F 7D E9 7C 06 71 56 16 BC 00 7D D4 75 7B 3E 10 67 DF E4 78 00 8A CB 0B 22 BC A3 36 82 61 E0 85 4F C8 5B 28 E4 D3 57 0C F5 57 5C DD C9 3D C3 EF D3 76 11 B5 53 58 23 05 B0 DE 5A 49 CC 1F 93 5B 1F F6 84 AB 1F 16 2A 93 87 D8 81 A8 2E ED 40 E4 F8 B3 61 0B 4F 2A 32 F6 A5 56 76 06 79 0E 3F D5 C3 00 BE D1 B7 17 CF BD 4C 7D 2E 7A D5 79 D5 C2 9D 74 50 18 BC 87 0B F3 C4 8D 06 C8 9E 23 19 79 98 AB E4 2E 2F 6E 2C E0 E3 A3 BE D1 FB B6 20 2B 7F B3 68 04 BD 27 18 3B F3 C9 0D 2A 10 06 1E 28 63 B3 E0 2A 94 A7 92 2F 48 6E 33 19 C7 39 F6 0D 6C DA 49 EA BA 14 BA 71 92 A8 39 64 60 02 CF DC 84 96 6E 47 D4 F5 95 D6 20 39 BB 4F F2 FE 73 BA D2 FE BC 35 BC 33 6D 4E F8 6F 96 EB 6E 2E CD 46 9D 56 93 31 C9 AE 38 76 44 71 CA 80 58 6B 7E 93 35 7E 91 60 44 9A 20 51 29 1F 4E 65 5F A8 68 F1 6A 74 B0 9C 6A 41 EF 23 C6 46 EF 4A 68 EB F5 8C EF 02 B6 EE 9B 6C 02 02 35 42 08 AA) */;

	internal static byte[] previousId;
}
