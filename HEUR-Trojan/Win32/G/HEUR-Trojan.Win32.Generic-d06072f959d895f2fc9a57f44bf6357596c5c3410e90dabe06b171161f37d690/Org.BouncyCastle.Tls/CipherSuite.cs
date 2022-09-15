namespace Org.BouncyCastle.Tls;

public abstract class CipherSuite
{
	public const int TLS_NULL_WITH_NULL_NULL = 0;

	public const int TLS_RSA_WITH_NULL_MD5 = 1;

	public const int TLS_RSA_WITH_NULL_SHA = 2;

	public const int TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3;

	public const int TLS_RSA_WITH_RC4_128_MD5 = 4;

	public const int TLS_RSA_WITH_RC4_128_SHA = 5;

	public const int TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6;

	public const int TLS_RSA_WITH_IDEA_CBC_SHA = 7;

	public const int TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8;

	public const int TLS_RSA_WITH_DES_CBC_SHA = 9;

	public const int TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10;

	public const int TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11;

	public const int TLS_DH_DSS_WITH_DES_CBC_SHA = 12;

	public const int TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13;

	public const int TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14;

	public const int TLS_DH_RSA_WITH_DES_CBC_SHA = 15;

	public const int TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16;

	public const int TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17;

	public const int TLS_DHE_DSS_WITH_DES_CBC_SHA = 18;

	public const int TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19;

	public const int TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20;

	public const int TLS_DHE_RSA_WITH_DES_CBC_SHA = 21;

	public const int TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22;

	public const int TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23;

	public const int TLS_DH_anon_WITH_RC4_128_MD5 = 24;

	public const int TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25;

	public const int TLS_DH_anon_WITH_DES_CBC_SHA = 26;

	public const int TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27;

	public const int TLS_RSA_WITH_AES_128_CBC_SHA = 47;

	public const int TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48;

	public const int TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49;

	public const int TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50;

	public const int TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51;

	public const int TLS_DH_anon_WITH_AES_128_CBC_SHA = 52;

	public const int TLS_RSA_WITH_AES_256_CBC_SHA = 53;

	public const int TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54;

	public const int TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55;

	public const int TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56;

	public const int TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57;

	public const int TLS_DH_anon_WITH_AES_256_CBC_SHA = 58;

	public const int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65;

	public const int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66;

	public const int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67;

	public const int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68;

	public const int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69;

	public const int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70;

	public const int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132;

	public const int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133;

	public const int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134;

	public const int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135;

	public const int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136;

	public const int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137;

	public const int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186;

	public const int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187;

	public const int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188;

	public const int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189;

	public const int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190;

	public const int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191;

	public const int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192;

	public const int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193;

	public const int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194;

	public const int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195;

	public const int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196;

	public const int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197;

	public const int TLS_RSA_WITH_SEED_CBC_SHA = 150;

	public const int TLS_DH_DSS_WITH_SEED_CBC_SHA = 151;

	public const int TLS_DH_RSA_WITH_SEED_CBC_SHA = 152;

	public const int TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153;

	public const int TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154;

	public const int TLS_DH_anon_WITH_SEED_CBC_SHA = 155;

	public const int TLS_PSK_WITH_RC4_128_SHA = 138;

	public const int TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139;

	public const int TLS_PSK_WITH_AES_128_CBC_SHA = 140;

	public const int TLS_PSK_WITH_AES_256_CBC_SHA = 141;

	public const int TLS_DHE_PSK_WITH_RC4_128_SHA = 142;

	public const int TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143;

	public const int TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144;

	public const int TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145;

	public const int TLS_RSA_PSK_WITH_RC4_128_SHA = 146;

	public const int TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147;

	public const int TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148;

	public const int TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149;

	public const int TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153;

	public const int TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154;

	public const int TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155;

	public const int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156;

	public const int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157;

	public const int TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158;

	public const int TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159;

	public const int TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160;

	public const int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161;

	public const int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162;

	public const int TLS_ECDH_RSA_WITH_NULL_SHA = 49163;

	public const int TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164;

	public const int TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165;

	public const int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166;

	public const int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167;

	public const int TLS_ECDHE_RSA_WITH_NULL_SHA = 49168;

	public const int TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169;

	public const int TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170;

	public const int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171;

	public const int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172;

	public const int TLS_ECDH_anon_WITH_NULL_SHA = 49173;

	public const int TLS_ECDH_anon_WITH_RC4_128_SHA = 49174;

	public const int TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175;

	public const int TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176;

	public const int TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177;

	public const int TLS_PSK_WITH_NULL_SHA = 44;

	public const int TLS_DHE_PSK_WITH_NULL_SHA = 45;

	public const int TLS_RSA_PSK_WITH_NULL_SHA = 46;

	public const int TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178;

	public const int TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179;

	public const int TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180;

	public const int TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181;

	public const int TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182;

	public const int TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183;

	public const int TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184;

	public const int TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185;

	public const int TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186;

	public const int TLS_RSA_WITH_NULL_SHA256 = 59;

	public const int TLS_RSA_WITH_AES_128_CBC_SHA256 = 60;

	public const int TLS_RSA_WITH_AES_256_CBC_SHA256 = 61;

	public const int TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62;

	public const int TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63;

	public const int TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64;

	public const int TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103;

	public const int TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104;

	public const int TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105;

	public const int TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106;

	public const int TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107;

	public const int TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108;

	public const int TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109;

	public const int TLS_RSA_WITH_AES_128_GCM_SHA256 = 156;

	public const int TLS_RSA_WITH_AES_256_GCM_SHA384 = 157;

	public const int TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158;

	public const int TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159;

	public const int TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160;

	public const int TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161;

	public const int TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162;

	public const int TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163;

	public const int TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164;

	public const int TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165;

	public const int TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166;

	public const int TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167;

	public const int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187;

	public const int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188;

	public const int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189;

	public const int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190;

	public const int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191;

	public const int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192;

	public const int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193;

	public const int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194;

	public const int TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195;

	public const int TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196;

	public const int TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197;

	public const int TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198;

	public const int TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;

	public const int TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200;

	public const int TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201;

	public const int TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202;

	public const int TLS_PSK_WITH_AES_128_GCM_SHA256 = 168;

	public const int TLS_PSK_WITH_AES_256_GCM_SHA384 = 169;

	public const int TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170;

	public const int TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171;

	public const int TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172;

	public const int TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173;

	public const int TLS_PSK_WITH_AES_128_CBC_SHA256 = 174;

	public const int TLS_PSK_WITH_AES_256_CBC_SHA384 = 175;

	public const int TLS_PSK_WITH_NULL_SHA256 = 176;

	public const int TLS_PSK_WITH_NULL_SHA384 = 177;

	public const int TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178;

	public const int TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179;

	public const int TLS_DHE_PSK_WITH_NULL_SHA256 = 180;

	public const int TLS_DHE_PSK_WITH_NULL_SHA384 = 181;

	public const int TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182;

	public const int TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183;

	public const int TLS_RSA_PSK_WITH_NULL_SHA256 = 184;

	public const int TLS_RSA_PSK_WITH_NULL_SHA384 = 185;

	public const int TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203;

	public const int TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204;

	public const int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205;

	public const int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206;

	public const int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207;

	public const int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208;

	public const int TLS_ECDHE_PSK_WITH_NULL_SHA = 49209;

	public const int TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210;

	public const int TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211;

	public const int TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255;

	public const int TLS_RSA_WITH_ARIA_128_CBC_SHA256 = 49212;

	public const int TLS_RSA_WITH_ARIA_256_CBC_SHA384 = 49213;

	public const int TLS_DH_DSS_WITH_ARIA_128_CBC_SHA256 = 49214;

	public const int TLS_DH_DSS_WITH_ARIA_256_CBC_SHA384 = 49215;

	public const int TLS_DH_RSA_WITH_ARIA_128_CBC_SHA256 = 49216;

	public const int TLS_DH_RSA_WITH_ARIA_256_CBC_SHA384 = 49217;

	public const int TLS_DHE_DSS_WITH_ARIA_128_CBC_SHA256 = 49218;

	public const int TLS_DHE_DSS_WITH_ARIA_256_CBC_SHA384 = 49219;

	public const int TLS_DHE_RSA_WITH_ARIA_128_CBC_SHA256 = 49220;

	public const int TLS_DHE_RSA_WITH_ARIA_256_CBC_SHA384 = 49221;

	public const int TLS_DH_anon_WITH_ARIA_128_CBC_SHA256 = 49222;

	public const int TLS_DH_anon_WITH_ARIA_256_CBC_SHA384 = 49223;

	public const int TLS_ECDHE_ECDSA_WITH_ARIA_128_CBC_SHA256 = 49224;

	public const int TLS_ECDHE_ECDSA_WITH_ARIA_256_CBC_SHA384 = 49225;

	public const int TLS_ECDH_ECDSA_WITH_ARIA_128_CBC_SHA256 = 49226;

	public const int TLS_ECDH_ECDSA_WITH_ARIA_256_CBC_SHA384 = 49227;

	public const int TLS_ECDHE_RSA_WITH_ARIA_128_CBC_SHA256 = 49228;

	public const int TLS_ECDHE_RSA_WITH_ARIA_256_CBC_SHA384 = 49229;

	public const int TLS_ECDH_RSA_WITH_ARIA_128_CBC_SHA256 = 49230;

	public const int TLS_ECDH_RSA_WITH_ARIA_256_CBC_SHA384 = 49231;

	public const int TLS_RSA_WITH_ARIA_128_GCM_SHA256 = 49232;

	public const int TLS_RSA_WITH_ARIA_256_GCM_SHA384 = 49233;

	public const int TLS_DHE_RSA_WITH_ARIA_128_GCM_SHA256 = 49234;

	public const int TLS_DHE_RSA_WITH_ARIA_256_GCM_SHA384 = 49235;

	public const int TLS_DH_RSA_WITH_ARIA_128_GCM_SHA256 = 49236;

	public const int TLS_DH_RSA_WITH_ARIA_256_GCM_SHA384 = 49237;

	public const int TLS_DHE_DSS_WITH_ARIA_128_GCM_SHA256 = 49238;

	public const int TLS_DHE_DSS_WITH_ARIA_256_GCM_SHA384 = 49239;

	public const int TLS_DH_DSS_WITH_ARIA_128_GCM_SHA256 = 49240;

	public const int TLS_DH_DSS_WITH_ARIA_256_GCM_SHA384 = 49241;

	public const int TLS_DH_anon_WITH_ARIA_128_GCM_SHA256 = 49242;

	public const int TLS_DH_anon_WITH_ARIA_256_GCM_SHA384 = 49243;

	public const int TLS_ECDHE_ECDSA_WITH_ARIA_128_GCM_SHA256 = 49244;

	public const int TLS_ECDHE_ECDSA_WITH_ARIA_256_GCM_SHA384 = 49245;

	public const int TLS_ECDH_ECDSA_WITH_ARIA_128_GCM_SHA256 = 49246;

	public const int TLS_ECDH_ECDSA_WITH_ARIA_256_GCM_SHA384 = 49247;

	public const int TLS_ECDHE_RSA_WITH_ARIA_128_GCM_SHA256 = 49248;

	public const int TLS_ECDHE_RSA_WITH_ARIA_256_GCM_SHA384 = 49249;

	public const int TLS_ECDH_RSA_WITH_ARIA_128_GCM_SHA256 = 49250;

	public const int TLS_ECDH_RSA_WITH_ARIA_256_GCM_SHA384 = 49251;

	public const int TLS_PSK_WITH_ARIA_128_CBC_SHA256 = 49252;

	public const int TLS_PSK_WITH_ARIA_256_CBC_SHA384 = 49253;

	public const int TLS_DHE_PSK_WITH_ARIA_128_CBC_SHA256 = 49254;

	public const int TLS_DHE_PSK_WITH_ARIA_256_CBC_SHA384 = 49255;

	public const int TLS_RSA_PSK_WITH_ARIA_128_CBC_SHA256 = 49256;

	public const int TLS_RSA_PSK_WITH_ARIA_256_CBC_SHA384 = 49257;

	public const int TLS_PSK_WITH_ARIA_128_GCM_SHA256 = 49258;

	public const int TLS_PSK_WITH_ARIA_256_GCM_SHA384 = 49259;

	public const int TLS_DHE_PSK_WITH_ARIA_128_GCM_SHA256 = 49260;

	public const int TLS_DHE_PSK_WITH_ARIA_256_GCM_SHA384 = 49261;

	public const int TLS_RSA_PSK_WITH_ARIA_128_GCM_SHA256 = 49262;

	public const int TLS_RSA_PSK_WITH_ARIA_256_GCM_SHA384 = 49263;

	public const int TLS_ECDHE_PSK_WITH_ARIA_128_CBC_SHA256 = 49264;

	public const int TLS_ECDHE_PSK_WITH_ARIA_256_CBC_SHA384 = 49265;

	public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266;

	public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267;

	public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268;

	public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269;

	public const int TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270;

	public const int TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271;

	public const int TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272;

	public const int TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273;

	public const int TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274;

	public const int TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275;

	public const int TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276;

	public const int TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277;

	public const int TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278;

	public const int TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279;

	public const int TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280;

	public const int TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281;

	public const int TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282;

	public const int TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283;

	public const int TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284;

	public const int TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285;

	public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286;

	public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287;

	public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288;

	public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289;

	public const int TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290;

	public const int TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291;

	public const int TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292;

	public const int TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293;

	public const int TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294;

	public const int TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295;

	public const int TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296;

	public const int TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297;

	public const int TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298;

	public const int TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299;

	public const int TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300;

	public const int TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301;

	public const int TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302;

	public const int TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303;

	public const int TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304;

	public const int TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305;

	public const int TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306;

	public const int TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307;

	public const int TLS_RSA_WITH_AES_128_CCM = 49308;

	public const int TLS_RSA_WITH_AES_256_CCM = 49309;

	public const int TLS_DHE_RSA_WITH_AES_128_CCM = 49310;

	public const int TLS_DHE_RSA_WITH_AES_256_CCM = 49311;

	public const int TLS_RSA_WITH_AES_128_CCM_8 = 49312;

	public const int TLS_RSA_WITH_AES_256_CCM_8 = 49313;

	public const int TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314;

	public const int TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315;

	public const int TLS_PSK_WITH_AES_128_CCM = 49316;

	public const int TLS_PSK_WITH_AES_256_CCM = 49317;

	public const int TLS_DHE_PSK_WITH_AES_128_CCM = 49318;

	public const int TLS_DHE_PSK_WITH_AES_256_CCM = 49319;

	public const int TLS_PSK_WITH_AES_128_CCM_8 = 49320;

	public const int TLS_PSK_WITH_AES_256_CCM_8 = 49321;

	public const int TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322;

	public const int TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323;

	public const int TLS_ECDHE_ECDSA_WITH_AES_128_CCM = 49324;

	public const int TLS_ECDHE_ECDSA_WITH_AES_256_CCM = 49325;

	public const int TLS_ECDHE_ECDSA_WITH_AES_128_CCM_8 = 49326;

	public const int TLS_ECDHE_ECDSA_WITH_AES_256_CCM_8 = 49327;

	public const int TLS_FALLBACK_SCSV = 22016;

	public const int TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52392;

	public const int TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52393;

	public const int TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52394;

	public const int TLS_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52395;

	public const int TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52396;

	public const int TLS_DHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52397;

	public const int TLS_RSA_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52398;

	public const int TLS_ECDHE_PSK_WITH_AES_128_GCM_SHA256 = 53249;

	public const int TLS_ECDHE_PSK_WITH_AES_256_GCM_SHA384 = 53250;

	public const int TLS_ECDHE_PSK_WITH_AES_128_CCM_8_SHA256 = 53251;

	public const int TLS_ECDHE_PSK_WITH_AES_128_CCM_SHA256 = 53253;

	public const int TLS_AES_128_GCM_SHA256 = 4865;

	public const int TLS_AES_256_GCM_SHA384 = 4866;

	public const int TLS_CHACHA20_POLY1305_SHA256 = 4867;

	public const int TLS_AES_128_CCM_SHA256 = 4868;

	public const int TLS_AES_128_CCM_8_SHA256 = 4869;

	public const int TLS_SM4_GCM_SM3 = 198;

	public const int TLS_SM4_CCM_SM3 = 199;

	public const int TLS_GOSTR341112_256_WITH_KUZNYECHIK_CTR_OMAC = 49408;

	public const int TLS_GOSTR341112_256_WITH_MAGMA_CTR_OMAC = 49409;

	public const int TLS_GOSTR341112_256_WITH_28147_CNT_IMIT = 49410;

	public static bool IsScsv(int cipherSuite)
	{
		if (cipherSuite != 255 && cipherSuite != 22016)
		{
			return false;
		}
		return true;
	}
}
