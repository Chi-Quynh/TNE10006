using System;



/*
public class NetworkCalculator
{
    public static void Main()
    {
        // Prompt for input and read as strings
        //*List<int> resultSubnet = new List<int>();
        //List<string> resultIPAddress = new List<string>();

        Console.Write("Type your IP address: ");
        string ipAddress = Console.ReadLine();

        Console.Write("Type your subnet mask (e.g., 24): ");
        int subnetMask = int.Parse( Console.ReadLine());

        //Console.Write("How many VLANs(e.g., 2): ");
        //int numVlans = int.Parse(Console.ReadLine()); // Parse to integer

        
        string end;
        


        for (int numVlan = 1; numVlan < 20; numVlan++)
        {
            string ipResult = ipAddress + "\n";
            Console.Write("Enter for next VLAN, type 'end' to exit): ");
            end = Console.ReadLine();
            if (end == "end")
            {
                break;
            }
            Console.Write($"VLAN {numVlan}. How many hosts: ");
            int HostPerVlan = int.Parse(Console.ReadLine());
            int usableHostsPerVlan = CalculateSubnet(subnetMask, HostPerVlan);
            Console.Write($"Subnet: {usableHostsPerVlan}\n");
            
            Console.Write(ipResult);
            
            ipAddress = String.Join(".", CalculateIPAddress(ipAddress, HostPerVlan));
            

        }
    


    }

    private static int CalculateN(int numHost)
    {
        int n = (int)Math.Ceiling(Math.Log(numHost + 2, 2));
        return n;
    }

    // Replace this with your actual calculation logic for usable hosts
    private static int CalculateSubnet(int subnetMask, int numHosts)
    {
        
        int m; //Number of hosts
        int n = CalculateN(numHosts); // Round up to nearest whole number
        int subnet; //Number of  subnets

        m = 32 - subnetMask; //Calculates leftover hosts
        subnet = m - n;
        subnet = subnet + subnetMask;
        
        return subnet; 

        // Implement your subnet mask validation and usable host calculation here
        
    }


    
    private static string[] CalculateIPAddress(string ipAddress, int numHosts)
    {

       
        string[] ipAddressList = ipAddress.Split(".");
        int h;//ipaddress result
        int n = CalculateN(numHosts);
        n = (int)Math.Pow(2, n);
        int splitby256 = n / 256;

        string vlanIPAddress;

        if ( splitby256 < 1)
        {
            h = int.Parse(ipAddressList[3]) + n;
            if (h > 255)
            {
                ipAddressList[2] = ipAddressList[2] + (h -255);
                ipAddressList[3] = 0.ToString();
            }
            else
            ipAddressList[3] = h.ToString();
        }
        else
        {
            h = int.Parse(ipAddressList[2]) + splitby256;
            ipAddressList[2] = h.ToString();
        }
        
        return ipAddressList;
    }
}


 public static void Main()
    {
        // Prompt for input and read as strings
        //*List<int> resultSubnet = new List<int>();
        //List<string> resultIPAddress = new List<string>();

        Console.Write("Type your IP address: ");
        string ipAddress = Console.ReadLine();*/
public class NetworkCalculator
{
    public static void Main()
    {

        //List<string> resultIPAddress = new List<string>();

        Console.Write("Type your IP address: ");
        string ipAddress = Console.ReadLine();
        int [] ipAddNum = int.Parse(ipAddress.Split("."));
