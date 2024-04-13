using System;


namespace VLSM
{
    Console.Writeline("Type your ip address");
int number = Console.ReadLine();
    Console.Writeline("Type your subnet");
int subnet = Console.ReadLine();
    Console.Writeline("How many vlans?");
int vlan = Console.ReadLine();
    int subnethost;
    int m;
    int n;
for (i=0; i<vlan, i++)
{
Console.Writeline("Vlan number"+ vlan+"Enter your hosts");
subnethost = Console.ReadLine();
    m = 32 - subnet;
   n = Log2(subnethost);
Console.Writeline();
Console.Writeline(number);
}
}



