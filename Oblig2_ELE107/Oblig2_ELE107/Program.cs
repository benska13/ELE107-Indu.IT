using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Oblig2_ELE107
{
    class Program
    {
        private static readonly List<string> FilenameList = new List<string>();

        enum State{ NoMessage, StepToMessage, Message, StepFromMessage }

        static void Main()
        {
            try
            {
                //START - ASCII-kode 27 og 02 
                //SLUTT - ASCII-kode 27 og 03

                FilenameList.Add("test_quotes.txt");
                FilenameList.Add("test_quotes_esc.txt");
                FilenameList.Add("test_quotes_escstx.txt");
                FilenameList.Add("test_quotes_newline_unix.txt");
                FilenameList.Add("test_quotes_newline_windows.txt");
                FilenameList.Add("test_quotes_2.txt");

                foreach (string filename in FilenameList)
                {
                    byte[] dataByte = ReadByteFrom(filename); // Save file in array

                    (String messageString, int messageCount) = StateMachine(dataByte); // Save and count message

                    var messsageA = messageString.Split(' ','\n'); //Ord skilles med mellomrom eller ny linje. Mangel på mellomrom i noen av filene.

                    messageString =
                        $"{messageString}\n\n\n\n" +
                        $"Sammendrag for sesjon: {filename}\n\n" +
                        $"Antall meldinger: {messageCount}\n" +
                        $"Antall ord totalt: {messsageA.Length}\n" +
                        $"Antall tegn totalt: {messageString.Length}";

                    WriteToFile("melding_" + filename, messageString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private static (string messageString, int messageCount) StateMachine(byte[] dataByte)
        {
            State state = State.NoMessage;
            string messageString = "";
            int messageCount = 0;

            for (int i = 0; i < dataByte.Length; i++)
            {
                switch (state)
                {
                    case State.Message:
                        if (dataByte[i] == 27)
                        {
                            state = State.StepFromMessage;
                        }
                        else
                        {
                            messageString = messageString + (char) dataByte[i];
                        }

                        break;
                    case State.StepFromMessage:
                        if (dataByte[i] == 3)
                        {
                            state = State.NoMessage;
                        }
                        else
                        {
                            state = State.Message;
                            messageString = messageString + (char) dataByte[i - 1] + (char) dataByte[i];
                        }

                        break;
                    case State.NoMessage:
                        if (dataByte[i] == 27)
                        {
                            state = State.StepToMessage;
                        }

                        break;
                    case State.StepToMessage:
                        if (dataByte[i] == 2)
                        {
                            state = State.Message;
                            messageCount++;
                        }
                        else
                        {
                            state = State.NoMessage;
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return (messageString, messageCount);


        }

        private static byte[] ReadByteFrom(string filnavn)
        {
            FileStream fileReader = File.Open(filnavn, FileMode.Open);
            byte[] dataByte = new byte[(int) fileReader.Length];
            fileReader.Read(dataByte, 0, (int) fileReader.Length);
            fileReader.Close();

            return dataByte;
        }

        private static void WriteToFile(string filnavn, string message)
        {
            StreamWriter fileWriter = new StreamWriter(filnavn);
            fileWriter.Write(message);
            fileWriter.Close();
        }
    }
}

