using System;

namespace com.bloomberg.emsx.samples {

    public static class Log {
	
	    public enum LogLevels {
		    NONE,
		    BASIC,
		    DETAILED
	    }
	
	    public static LogLevels logLevel=LogLevels.NONE;
        public static String logPrefix = "";

        public static void LogMessage(LogLevels level, string str) {
	
		    if(logLevel==LogLevels.NONE) return;
		    if(level==LogLevels.DETAILED && logLevel==LogLevels.BASIC) return;

            System.Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssfffzzz") + logPrefix + ": \t" + str);

        }

    }
}