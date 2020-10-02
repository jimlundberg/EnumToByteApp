using System;

enum DebugMode : byte
{
    NONE = 0,
    JOB_LIST = 1,
    CHECK_FILE = 2,
    CHECK_TCP_IP = 4
}

class EnumToByte
{
    static void Main(string[] args)
    {
        DebugMode debugMode = DebugMode.CHECK_TCP_IP;
        byte debugByte;
        string debugString;
        Console.WriteLine("myDirection = {0}", debugMode);
        debugByte = (byte)debugMode;
        debugString = Convert.ToString(debugMode);
        Console.WriteLine("byte equivalent = {0}", debugByte);
        Console.WriteLine("string equivalent = {0}", debugString);
    }
}