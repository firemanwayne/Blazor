using System;

namespace Shared.Extensions
{
    public static class ConsoleEx
    {
        private readonly static string messageHeader = "********************Blazor Server 5.0************************ \n";
        public static void WriteLine(ConsoleColor? Background, ConsoleColor? Foreground, Exception Ex = null, string Message = null)
        {
            if (Background.HasValue)
                Console.BackgroundColor = Background.Value;

            if (Foreground.HasValue)
                Console.ForegroundColor = Foreground.Value;

            if (Ex == null)
            {
                var displayMessage = messageHeader;
                displayMessage += Message;

                Console.WriteLine(displayMessage);
            }
            else
                Console.WriteLine(HandleException(Ex));
        }
        public static void WriteLineRed(string Message = null, Exception Ex = null)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            if (Ex == null)
            {
                var displayMessage = messageHeader;
                displayMessage += Message;

                Console.WriteLine(displayMessage);
            }
            else
                Console.WriteLine(HandleException(Ex));
        }
        public static void WriteLineGreen(string Message = null, Exception Ex = null)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            if (Ex == null)
            {
                var displayMessage = messageHeader;
                displayMessage += Message;

                Console.WriteLine(displayMessage);
            }
            else
                Console.WriteLine(HandleException(Ex));
        }
        public static void WriteLineYellow(string Message = null, Exception Ex = null)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            if (Ex == null)
            {
                var displayMessage = messageHeader;
                displayMessage += Message;

                Console.WriteLine(displayMessage);
            }
            else
                Console.WriteLine(HandleException(Ex));
        }
        public static void WriteLineBlue(string Message = null, Exception Ex = null)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            if (Ex == null)
            {
                var displayMessage = messageHeader;
                displayMessage += Message;

                Console.WriteLine(displayMessage);
            }
            else
                Console.WriteLine(HandleException(Ex));
        }
        
        private static string HandleException(Exception e)
        {
            string message = messageHeader;
            var errorCode = "";
            var extendedErrorInfo = "";
            var additionalDetails = "";

            var RequestInfo = e.Message;
            if (RequestInfo != null)
            {
                var ExtendedInfo = e.Source;

                if (ExtendedInfo != null)
                {
                    extendedErrorInfo = ExtendedInfo;
                    errorCode = ExtendedInfo;                    
                }
                var httpStatusCode = e.HelpLink;
                var httpStatusMessage = e.HResult;

                message += $"HttpStatus Message: {httpStatusMessage}\n" +
                          $"HttpStatus Code: {httpStatusCode}\n" +
                          $"Error Code: {errorCode}\n" +
                          $"Extended Error Message: {extendedErrorInfo}\n" +
                          $"Additional Details: {additionalDetails}";
            }
            else
                message += $"Exception: {e.Message}";

            return message;
        }
    }
}
