namespace MyBot
{
    public class LogHelper
    {
        public static void Write(string message, DebugLevelEnum debugLevel=DebugLevelEnum.info)
        {
            CommonWrite(message,false,debugLevel);//System.Console.Write(message);
        }
        public static void WriteLine(string message, DebugLevelEnum debugLevel=DebugLevelEnum.info)
        {
            CommonWrite(message,true,debugLevel);//System.Console.WriteLine(message);
        }
        private static void CommonWrite(string message, bool endLine=false, DebugLevelEnum debugLevel=DebugLevelEnum.info)
        {
            if(debugLevel==DebugLevelEnum.trace)
            {
                System.Console.WriteLine(" ");
                System.Console.WriteLine(" ");
                System.Console.Write("<<<");
            }
            if(endLine)
                System.Console.WriteLine(message);
            else
                System.Console.Write(message);
            if(debugLevel==DebugLevelEnum.trace)
            {
                System.Console.Write(">>>");
                System.Console.WriteLine(" ");
                System.Console.WriteLine(" ");
            }
        }
    }
}