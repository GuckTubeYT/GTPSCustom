using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace GTPSCustom
{
    class Program
    {
        public string ip;
        public static void first()
        {
            Console.WriteLine(" ######   ######## ########   ######   ######  ##     ##  ######  ########  #######  ##     ## ");
            Console.WriteLine("##    ##     ##    ##     ## ##    ## ##    ## ##     ## ##    ##    ##    ##     ## ###   ### ");
            Console.WriteLine("##           ##    ##     ## ##       ##       ##     ## ##          ##    ##     ## #### #### ");
            Console.WriteLine("##   ####    ##    ########   ######  ##       ##     ##  ######     ##    ##     ## ## ### ## ");
            Console.WriteLine("##    ##     ##    ##              ## ##       ##     ##       ##    ##    ##     ## ##     ## ");
            Console.WriteLine("##    ##     ##    ##        ##    ## ##    ## ##     ## ##    ##    ##    ##     ## ##     ## ");
            Console.WriteLine(" ######      ##    ##         ######   ######   #######   ######     ##     #######  ##     ## ");
            Console.WriteLine("");
            Console.Write("Please input the IP GTPS: ");
            
        }
        public static void second(string a)
        {
            Console.WriteLine(" ######   ######## ########   ######   ######  ##     ##  ######  ########  #######  ##     ## ");
            Console.WriteLine("##    ##     ##    ##     ## ##    ## ##    ## ##     ## ##    ##    ##    ##     ## ###   ### ");
            Console.WriteLine("##           ##    ##     ## ##       ##       ##     ## ##          ##    ##     ## #### #### ");
            Console.WriteLine("##   ####    ##    ########   ######  ##       ##     ##  ######     ##    ##     ## ## ### ## ");
            Console.WriteLine("##    ##     ##    ##              ## ##       ##     ##       ##    ##    ##     ## ##     ## ");
            Console.WriteLine("##    ##     ##    ##        ##    ## ##    ## ##     ## ##    ##    ##    ##     ## ##     ## ");
            Console.WriteLine(" ######      ##    ##         ######   ######   #######   ######     ##     #######  ##     ## ");
            Console.WriteLine("");
            Console.WriteLine("the IP GTPS is: " + a);
        }
        public static void on(string a)
        {
            TextWriter tw = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts", false);
            tw.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ");
            tw.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ");
            tw.WriteLine("# ");
            tw.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows. ");
            tw.WriteLine("# ");
            tw.WriteLine("# This file contains the mappings of IP addresses to host names. Each ");
            tw.WriteLine("# entry should be kept on an individual line. The IP address should ");
            tw.WriteLine("# be placed in the first column followed by the corresponding host name. ");
            tw.WriteLine("# The IP address and the host name should be separated by at least one ");
            tw.WriteLine("# space. ");
            tw.WriteLine("# ");
            tw.WriteLine("# Additionally, comments (such as these) may be inserted on individual ");
            tw.WriteLine("# lines or following the machine name denoted by a '#' symbol. ");
            tw.WriteLine("# ");
            tw.WriteLine("# For example: ");
            tw.WriteLine("# ");
            tw.WriteLine("#      102.54.94.97     rhino.acme.com          # source server ");
            tw.WriteLine("#       38.25.63.10     x.acme.com              # x client host ");
            tw.WriteLine("");
            tw.WriteLine("# localhost name resolution is handled within DNS itself. ");
            tw.WriteLine("#      127.0.0.1       localhost ");
            tw.WriteLine("#      ::1             localhost ");
            tw.WriteLine(" ");
            tw.WriteLine(a + " growtopia1.com");
            tw.WriteLine(a + " growtopia2.com");
            tw.Close();
            Console.WriteLine("Custom Growtopia Private Server is Turn On");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
        public static void off()
        {
            TextWriter tw = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts", false);
            tw.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ");
            tw.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ");
            tw.WriteLine("# ");
            tw.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows. ");
            tw.WriteLine("# ");
            tw.WriteLine("# This file contains the mappings of IP addresses to host names. Each ");
            tw.WriteLine("# entry should be kept on an individual line. The IP address should ");
            tw.WriteLine("# be placed in the first column followed by the corresponding host name. ");
            tw.WriteLine("# The IP address and the host name should be separated by at least one ");
            tw.WriteLine("# space. ");
            tw.WriteLine("# ");
            tw.WriteLine("# Additionally, comments (such as these) may be inserted on individual ");
            tw.WriteLine("# lines or following the machine name denoted by a '#' symbol. ");
            tw.WriteLine("# ");
            tw.WriteLine("# For example: ");
            tw.WriteLine("# ");
            tw.WriteLine("#      102.54.94.97     rhino.acme.com          # source server ");
            tw.WriteLine("#       38.25.63.10     x.acme.com              # x client host ");
            tw.WriteLine("");
            tw.WriteLine("# localhost name resolution is handled within DNS itself. ");
            tw.WriteLine("#      127.0.0.1       localhost ");
            tw.WriteLine("#      ::1             localhost ");
            tw.WriteLine(" ");
            tw.Close();
            Console.WriteLine("Custom Growtopia Private Server is Turn Off");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
        public static void loop()
        {
            Console.Clear();
            string ip = File.ReadAllText("a.txt");
            second(ip);
            Console.WriteLine("1) Turn On");
            Console.WriteLine("2) Turn Off");
            Console.WriteLine("3) Exit");
            Console.Write("(1 - 3): ");
            string select = Console.ReadLine();
            if (select == "1")
            {
                Console.Clear();
                on(ip);
                loop();
            }
            if (select == "2")
            {
                Console.Clear();
                off();
                loop();
            }
            if (select == "3")
            {
                Console.Clear();
                File.Delete("a.txt");
                Environment.Exit(0);
            }
        }
        static void Main()
        {
            first();
            string ip = Console.ReadLine();
            Console.Clear();
            second(ip);
            TextWriter tw = new StreamWriter("a.txt", false);
            tw.Write(ip);
            tw.Close();
            Console.WriteLine("1) Turn On");
            Console.WriteLine("2) Turn Off");
            Console.WriteLine("3) Exit");
            Console.Write("(1 - 3): ");
            string select = Console.ReadLine();

            if (select == "1")
            {
                Console.Clear();
                on(ip);
                loop();
            }
            if (select == "2")
            {
                Console.Clear();
                off();
                loop();
            }
            if (select == "3")
            {
                Console.Clear();
                File.Delete("a.txt");
                Environment.Exit(0);
            }
        }
    }
}
