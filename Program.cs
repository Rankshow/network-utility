using System.Net.NetworkInformation;
using System.Text;
using GettingStarted;

// !Pinging Google DNS Server 4.2.2.2

PingerService pingerService = new PingerService();  
pingerService.SendPing();
Console.WriteLine();
 