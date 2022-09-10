using System.Collections.Generic;
using BZJnSPwx;
using CCfpfC7h;
using Y7FbhctW;
using ZqaFD1Ap;
using av2p5dFj;
using di1mqJMz;
using iiraiv39;

namespace qGIjTe0w;

internal class Class2
{
	public const string JYsFGCXo = "    ";

	public const string IVJvClA8 = "\r\n";

	public gMotwPfU II7dktcI;

	public int gzGpptxO;

	public Class2(ref gMotwPfU WCf3tSXC, int int_0)
	{
		II7dktcI = WCf3tSXC;
		gzGpptxO = int_0;
	}

	public string g2ereli3()
	{
		return "#include \"bit.h\"\r\n#include \"parametres.h\"\r\n#include \"main.h\"\r\n";
	}

	public string wfXBZItI()
	{
		return ivlgLlId.jnXal2jf(ivlgLlId.jnXal2jf("#define BIT0  0x0001\r\n#define BIT1  0x0002\r\n#define BIT2  0x0004\r\n#define BIT3  0x0008\r\n#define BIT4  0x0010\r\n#define BIT5  0x0020\r\n#define BIT6  0x0040\r\n#define BIT7  0x0080\r\n#define BIT8  0x0100\r\n#define BIT9  0x0200\r\n#define BIT10 0x0400\r\n#define BIT11 0x0800\r\n#define BIT12 0x1000\r\n#define BIT13 0x2000\r\n#define BIT14 0x4000\r\n#define BIT15 0x8000\r\n\r\n", "struct BITS\r\n{\r\n    unsigned bit0 : 1;\r\n    unsigned bit1 : 1;\r\n    unsigned bit2 : 1;\r\n    unsigned bit3 : 1;\r\n    unsigned bit4 : 1;\r\n    unsigned bit5 : 1;\r\n    unsigned bit6 : 1;\r\n    unsigned bit7 : 1;\r\n    unsigned bit8 : 1;\r\n    unsigned bit9 : 1;\r\n    unsigned bit10 : 1;\r\n    unsigned bit11 : 1;\r\n    unsigned bit12 : 1;\r\n    unsigned bit13 : 1;\r\n    unsigned bit14 : 1;\r\n    unsigned bit15 : 1;\r\n};\r\n\r\n", 28657), "union BIT\r\n{\r\n    unsigned int all; // variable de 16 bits\r\n    struct BITS bits; // estructura de 16 variables binàries\r\n};\r\n", 28657);
	}

	public string c3v6QDdG()
	{
		string string_ = FFXb5i9i.smethod_0("#define nGRAFCET ", II7dktcI.E8cNtPVW.Count.ToString(), "\r\n", 52605);
		string_ = FFXb5i9i.MhuSoiDL(string_, "#define nETAPES ", II7dktcI.xMSWHb4i.ToString(), "\r\n", 9407);
		string_ = FFXb5i9i.MhuSoiDL(string_, "#define nTempP ", II7dktcI.int_0.ToString(), "\r\n", 9407);
		string_ = FFXb5i9i.MhuSoiDL(string_, "#define nTempPB ", II7dktcI.adi8tF4L.ToString(), "\r\n", 9407);
		using (Dictionary<int, sm18FGKs>.Enumerator enumerator = II7dktcI.E8cNtPVW.GetEnumerator())
		{
			int num = 0;
			KeyValuePair<int, sm18FGKs> current = default(KeyValuePair<int, sm18FGKs>);
			while (true)
			{
				if (num != 0)
				{
					string_ = FFXb5i9i.Be2UxXd8(new string[6]
					{
						string_,
						"#define ",
						current.Value.mGeNVBao,
						" ",
						current.Key.ToString(),
						"\r\n"
					}, 53581);
				}
				if (enumerator.MoveNext())
				{
					current = enumerator.Current;
					num = 1;
					continue;
				}
				break;
			}
		}
		using (Dictionary<Class9, int>.Enumerator enumerator2 = II7dktcI.ej0keUOA_4.GetEnumerator())
		{
			int num2 = 0;
			KeyValuePair<Class9, int> current2 = default(KeyValuePair<Class9, int>);
			while (true)
			{
				if (num2 != 0)
				{
					string_ = FFXb5i9i.Be2UxXd8(new string[6]
					{
						string_,
						"#define ENC_INI_",
						current2.Key.mGeNVBao,
						" ",
						KcEKvRC1.smethod_0(O4s9Dog1.cI1h7tEI(current2.Value, 25972)),
						"\r\n"
					}, 53581);
				}
				if (enumerator2.MoveNext())
				{
					current2 = enumerator2.Current;
					num2 = 1;
					continue;
				}
				break;
			}
		}
		return ivlgLlId.jnXal2jf(string_, "#define N 100\r\n", 28657);
	}

	public string hll6zG8h()
	{
		string string_ = "";
		string_ = ivlgLlId.jnXal2jf(string_, "struct grafcetGENERAL\r\n{\r\n    unsigned char Forcat;     // per forçar el grafcet. \r\n    union BIT EtapaActiva;    // estat futur de les entrades\r\n    union BIT EtapaActivaAux; // estat anterior de les etapes\r\n    union BIT FlagIniciEtapa; // si l'etapa s'acaba d'activar\r\n    union BIT FlagFiEtapa;    // si l'etapa s'acaba de desactivar\r\n    union BIT Receptivitat;   // estat de les receptivitats\r\n} G[nGRAFCET];\r\n\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "struct grafcetGENERAL G[nGRAFCET];\r\n\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "union BIT EntradaDig;\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "union BIT EntradaDigAux;\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "union BIT SortidaDig;\r\n", 28657);
		foreach (KeyValuePair<string, vilSnlZy> item in II7dktcI.qFlLSVvw)
		{
			string string_2 = item.Value.String_2;
			if (ivlgLlId.smethod_3(string_2, "BOOL", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(string_2, "INT", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(string_2, "REAL", bool_0: false, 3221) == 0)
					{
						string_ = FFXb5i9i.MhuSoiDL(string_, "float ", item.Key, ";\r\n", 9407);
					}
				}
				else
				{
					string_ = FFXb5i9i.MhuSoiDL(string_, "int ", item.Key, ";\r\n", 9407);
				}
			}
			else
			{
				string_ = FFXb5i9i.MhuSoiDL(string_, "int ", item.Key, ";\r\n", 9407);
			}
		}
		string_ = ivlgLlId.jnXal2jf(string_, "\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "union BIT FlancP;\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "union BIT FlancB;\r\n", 28657);
		if (II7dktcI.int_0 > 0)
		{
			string_ = ivlgLlId.jnXal2jf(string_, "union BIT TimerP [nTempP];\r\n", 28657);
			string_ = ivlgLlId.jnXal2jf(string_, "union BIT TLimitP [nTempP];\r\n", 28657);
		}
		if (II7dktcI.adi8tF4L > 0)
		{
			string_ = ivlgLlId.jnXal2jf(string_, "union BIT TimerPB [nTempPB];\r\n", 28657);
			string_ = ivlgLlId.jnXal2jf(string_, "union BIT TLimitPB [nTempPB];\r\n", 28657);
		}
		string_ = ivlgLlId.jnXal2jf(string_, "union BIT BitTimerP;\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "union BIT BitTimerPB;\r\n\r\n", 28657);
		string_ = ivlgLlId.jnXal2jf(string_, "void IniciMicro();        // inicialitzacions pròpies del microcontrolador\r\nvoid IniciGrafcet();      // Inicialització del Grafcet\r\nvoid LecturaEntrades();   // Lectura d'entrades\r\nvoid GestioTempo();       // Gestió de temporitzadors\r\nvoid AssignaAux();        // Assignació Auxiliar del Grafcet\r\nvoid EvolucioGrafcet();   // Evolució del Grafcet\r\nvoid AccionsPuntuals();   // Execució d'Accions Puntuals\r\nunsigned char GrafcetEstable(); // Grafcet Estable? Recerca d'estabilitat\r\nvoid AccionsContinues();  // Forçament de grafcets i Execució d'Accions Contínues\r\nvoid SortidesFisiques();  // Activació de les sortides Físiques\r\n\r\n", 28657);
		return ivlgLlId.jnXal2jf(string_, "void LecturaEntradesFisiques();   // registra el valor de les entrades\r\n// del sistema en les variables corresponents.\r\nvoid AvaluaReceptivitats(unsigned char nG); // per al grafcet nG\r\n// determina l'estat de les seves receptivitats.\r\n", 28657);
	}

	public object AQzx4MeA()
	{
		Class2 evxXhOA = this;
		return new y3Lio2Dd(ref evxXhOA).Bb7EmbQI();
	}

	public string kcxeUlCm()
	{
		Class2 jaX3TzjP = this;
		return new j3huuqBG(ref jaX3TzjP).NCazJ4ux();
	}

	public string EU0wjb7D()
	{
		Class2 b5VEODfI = this;
		return new SCE0etxQ(ref b5VEODfI).mgSgP9Bs();
	}

	public string Oy9S0btP()
	{
		Class2 qS7t3j7q = this;
		return new kfb2ujLq(ref qS7t3j7q).sXz1J9Cy();
	}

	public string method_0()
	{
		Class2 Si2ScGEJ = this;
		return new xKYVDX2y(ref Si2ScGEJ).BuoiT0mu();
	}

	public object PUME6ZLV()
	{
		Class2 class2_ = this;
		return new dj4Oy23s(ref class2_).method_0();
	}
}
