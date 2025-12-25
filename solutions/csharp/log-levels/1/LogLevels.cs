static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(['[',']',':'])[3].Trim();
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Split(['[',']',':'])[1].ToLower();
    }

    public static string Reformat(string logLine)
    {
        string logType;
        string logMessage;

        char[] delimiters = ['[',']',':'];
        string[] substrings = logLine.Split(delimiters);

        logType = substrings[1].ToLower();
        logMessage = substrings[3].Trim();

        return logMessage + " (" + logType + ")";
    }
}
