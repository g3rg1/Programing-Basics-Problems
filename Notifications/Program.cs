using System;

namespace Notifications
{
    class Program
    {
        static void ShowSuccessMessage(string operation, string message)
        {
            string successOperation = "Successfully executed " + operation + ".";
            Console.WriteLine(successOperation);
            Console.WriteLine(new string('=', successOperation.Length));
            Console.WriteLine("{0}.", message);
            Console.WriteLine();
        }
        static void ShowWarningMessage(string message)
        {
            string warningMessage = "Warning: " + message + ".";
            Console.WriteLine(warningMessage);
            Console.WriteLine(new string('=', warningMessage.Length));
            Console.WriteLine();
        }
        static void ShowErrorMessage(string operation, string message, int errorCode)
        {
            string errorOperation = "Error: Failed to execute " + operation + ".";
            Console.WriteLine(errorOperation);
            Console.WriteLine(new string('=', errorOperation.Length));
            Console.WriteLine("Reason: {0}.", message);
            Console.WriteLine("Error code: {0}.", errorCode);
            Console.WriteLine();
        }
        static void ReadAndProccessMessage(int messageCount)
        {
            string[] messageTypeArray = new string[messageCount];
            string[] successOperationArray = new string[messageCount];
            string[] successMessageArray = new string[messageCount];
            string[] warningMessageArray = new string[messageCount];
            string[] errorOperationArray = new string[messageCount];
            string[] errorMessageArray = new string[messageCount];
            int[] errorCodeArray = new int[messageCount];

            for (int i = 0; i < messageCount; i++)
            {
                string messageType = Console.ReadLine().ToLower();
                messageTypeArray[i] = messageType;
                if (messageType == "success")
                {
                    successOperationArray[i] = Console.ReadLine();
                    successMessageArray[i] = Console.ReadLine();
                }
                else if (messageType == "warning")
                {
                    warningMessageArray[i] = Console.ReadLine();
                }
                else if (messageType == "error")
                {
                    errorOperationArray[i] = Console.ReadLine();
                    errorMessageArray[i] = Console.ReadLine();
                    errorCodeArray[i] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < messageCount; i++)
            {
                string messageType = messageTypeArray[i];
                if (messageType == "success")
                {
                    ShowSuccessMessage(successOperationArray[i], successMessageArray[i]);
                }
                else if (messageType == "warning")
                {
                    ShowWarningMessage(warningMessageArray[i]);
                }
                else if (messageType == "error")
                {
                    ShowErrorMessage(errorOperationArray[i], errorMessageArray[i], errorCodeArray[i]);
                }
            }

        }

        static void Main(string[] args)
        {
            int messageCount = int.Parse(Console.ReadLine());
            ReadAndProccessMessage(messageCount);
        }
    }
}
