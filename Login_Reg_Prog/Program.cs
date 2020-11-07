using System;
using System.IO;
namespace Login_Reg_Prog
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //cominciamo con le due opzioni R/L

            string nomeReg, passReg, SiPre;
            string SiReg = "R";


            string SiLog = "L", userNameLogFabrizio = "FabryRoot", passwordLogFabrizio = "passFab27";
            string UnameDaLoggare, passDaLoggare;

            Console.WriteLine("Registrazione/Login?[R/L]");
            //REGISTRAZIONE---------------------------------------------
            SiPre = Console.ReadLine();
            if (SiPre == SiReg)
            {
                Console.WriteLine("Inserire un nome utente:");
                nomeReg = Console.ReadLine();

                Console.WriteLine("Inserire una password:");
                passReg = Console.ReadLine();

                while (passReg.Length < 8 || passReg.Length > 14)
                {
                    Console.WriteLine("Password troppo corta o troppo lunga, i caratteri devono essere compresi tra 8 e 13 ");
                    Console.WriteLine("inserire nuova password:");
                    passReg = Console.ReadLine();

                }
                Console.WriteLine("riavvia il programma e inserisci i nuovi dati in fase di login.");
            }

                //------------------------------------------------------------REGISTRAZIONE FINITA
                //------------------------------------------------------------INIZIO LOGIN
                if (SiPre == SiLog)
                {
                    Console.WriteLine("Inserire Nome Utente");                                                 //
                    UnameDaLoggare = Console.ReadLine();                                                       //PROCESSO DI CHECKING
                    Console.WriteLine("Inserire Password:");                                                   //
                    passDaLoggare = Console.ReadLine();
                    
                if (UnameDaLoggare == userNameLogFabrizio && passDaLoggare == passwordLogFabrizio)
                {
                    Console.WriteLine("Accesso eseguito, benvenuto!");
                    Console.WriteLine("Selezionare un operazione:");
                    Console.WriteLine("Creazione File[CRE], Rimozione File[RIM]");
                    string creaPre = "CRE", rimuoviPRE = "RIM", checkOfSelection, contenutoFile = "", nomeRimozione;
                    checkOfSelection = Console.ReadLine();
                    if (checkOfSelection == creaPre)
                    {
                        Console.WriteLine("Digita il testo che vuoi inserire e premi ENTER");
                        contenutoFile = Console.ReadLine();
                        File.WriteAllText("FileCreato1", contenutoFile);
                    }
                    if (checkOfSelection == rimuoviPRE)
                    {

                        Console.WriteLine("digita il nome del file che vuoi rimuovere");
                        nomeRimozione = Console.ReadLine();
                        File.Delete($"{ nomeRimozione}");
                    }
                }
                else while (UnameDaLoggare != userNameLogFabrizio || passDaLoggare != passwordLogFabrizio)
                {
                    Console.WriteLine("una delle due credenziali è sbagliata, riprovare");
                        Console.WriteLine("Inserire Nome Utente");                                                 //
                        UnameDaLoggare = Console.ReadLine();                                                       //PROCESSO DI CHECKING
                        Console.WriteLine("Inserire Password:");                                                   //
                        passDaLoggare = Console.ReadLine();
                    }
                if (UnameDaLoggare == userNameLogFabrizio && passDaLoggare == passwordLogFabrizio)
                {
                    Console.WriteLine("Accesso eseguito, benvenuto!");
                    Console.WriteLine("Selezionare un operazione:");
                    Console.WriteLine("Creazione File[CRE], Rimozione File[RIM]");
                    string creaPre = "CRE", rimuoviPRE = "RIM", checkOfSelection, contenutoFile = "", nomeRimozione;
                    checkOfSelection = Console.ReadLine();
                    if (checkOfSelection == creaPre)
                    {
                        Console.WriteLine("Digita il testo che vuoi inserire e premi ENTER");
                        contenutoFile = Console.ReadLine();
                        File.WriteAllText("FileCreato1", contenutoFile);
                    }
                    if (checkOfSelection == rimuoviPRE)
                    {

                        Console.WriteLine("digita il nome del file che vuoi rimuovere");
                        nomeRimozione = Console.ReadLine();
                        File.Delete($"{ nomeRimozione}");
                    }
                }

            }

            }
        }
    }
