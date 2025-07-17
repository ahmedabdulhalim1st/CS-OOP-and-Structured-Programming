using System;
using System.ComponentModel;
namespace app
{
    public class Program
    {
        static int Main(string[] args)
        {
            IP IP1 = new IP(192, 168, 1, 1);
            IP IP2 = new IP(new int[] { 221, 266, 44, 1 });
            System.Console.WriteLine("Hello, World!");
            System.Console.WriteLine(IP1.Address());
            System.Console.WriteLine(IP2.Address());
            var FirstSegmenat = IP1[0];
            var IP4 = new IP("192.168.1.1");
            System.Console.WriteLine(IP4.Address());
            Console.ReadKey();
            return 0;
        }
    }
}
public class IP
{
    private int[] _segments = new int[4];

    private int[] Segments { get => _segments; set => _segments = value; }

    public int this[int index]
    {
        get
        {
            return Segments[index];
        }
        set
        {
            Segments[index] = value;
        }
    }

    public IP(int[] segments) => Segments = segments;

    public IP(int seg1, int seg2, int seg3, int seg4)
    {
        Segments[0] = seg1;
        Segments[1] = seg2;
        Segments[2] = seg3;
        Segments[3] = seg4;
    }

    public IP(string IPAddress)
    {
        var Segs = IPAddress.Split(".");
        for (int i = 0; i < Segs.Length; i++)
        {
            Segments[i] = Convert.ToInt32(Segs[i]);
        }
    }
    public string Address() => string.Join(".", Segments);
}
