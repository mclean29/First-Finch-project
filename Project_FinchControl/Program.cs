using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // ***************************************************
    //
    // Title: First Finch Program
    // Description: 
    // Application Type: Console
    // Author: Tanner McLean
    // Dated Created: 2/1/2020
    // Last Modified: 2/21/2021
    //
    // **************************************************

    class Program
    {
        
        ///  
        /// first method run when the app starts up
        ///  
        static void Main(string[] args)
        {
            
            SetTheme();

            DisplayWelcomeScreen();
            menuScreen();
            DisplayClosingScreen();
        }

        #region METHODS
        ///  
        /// setup the console theme
        ///  
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        ///  
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        ///  
        static void menuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch doofus = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        connectdoofus(doofus);
                        break;

                    case "b":
                        TalentShowmenuScreen(doofus);
                        break;

                    case "c":
                        dataRecorderMenu(doofus);
                        break;

                    case "d":
                        
                        break;

                    case "e":

                        break;

                    case "f":
                        DisplayDisconnectdoofus(doofus);
                        break;

                    case "q":
                        DisplayDisconnectdoofus(doofus);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }

            } while (!quitApplication);
        }

        #region TALENT SHOW

        ///  
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        ///  
        static void TalentShowmenuScreen(Finch doofus)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Movement Talent basic");
                Console.WriteLine("\tc) Play a song");
                Console.WriteLine("\td) Color calculator");
                Console.WriteLine("\te) Alarm System");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(doofus);
                        break;

                    case "b":
                        talentShowMovement(doofus);
                        break;

                    case "c":
                        talentShowSong(doofus);
                        break;

                    case "d":
                        colorCalc(doofus);
                        break;

                    case "e":
                        alarmSystem(doofus);
                        break;


                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        static int colorCalc(Finch doofus)
        {
            
            
            bool validResponse;
            string user1;
            string user2;
            string user3;
            int RedVal;
            int GreenVal;
            int BlueVal;
            
            
            DisplayScreenHeader("Color Maker");
            Console.WriteLine("\t You will now be able to control the finch's light!");
            continueScreen();
            Console.WriteLine();
            Console.WriteLine("\t Now please enter 3 valid values for Red, Green, and Blue values");
            Console.WriteLine();
            Console.WriteLine("\t Valid values are from 0 to 255");
            //user enters value 1
            continueScreen();
            Console.WriteLine();
            Console.WriteLine("\t Please enter value 1 (Red), 0-255");
            #region Red
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\t Value 1: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out RedVal) )
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((RedVal >= 256))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: R value of: {RedVal}");
                    
                    continueScreen();
                }

            } while (!validResponse);
            #endregion
            //
            // Value 2 for green
            //
            #region Green
            Console.WriteLine();
            Console.WriteLine("\t Please enter value 2 (Green), 0-255");
            do
            {
                validResponse = true;

                //
                //insert second number
                //
                Console.WriteLine();
                Console.Write($"\t Value 2: ");
                user2 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user2, out GreenVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((GreenVal >= 256))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: G value of: {GreenVal}");
                    Console.WriteLine();
                   
                    continueScreen();
                }

            } while (!validResponse);
            #endregion
            //
            // Value 3 for blue
            //
            #region Blue/table
            Console.WriteLine();
            Console.WriteLine("\t Please enter value 3 (Blue), 0-255");
            do
            {
                validResponse = true;

                //
                //insert third number
                //
                Console.WriteLine();
                Console.Write($"\t Value 3: ");
                user3 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user3, out BlueVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((BlueVal >= 256))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: B value of: {GreenVal}");
                    Console.WriteLine();
                    
                    continueScreen();
                }
               


                //
                //display values entered
                //

                //
                //Make the table
                //
                Console.WriteLine();
                Console.WriteLine("\tYour Values Entered:");
                Console.WriteLine(
                    "R".PadLeft(10) +
                    "G".PadLeft(10) +
                    "B".PadLeft(10)
                    );
                Console.WriteLine(
                   "---".PadLeft(10) +
                   "---".PadLeft(10) +
                   "---".PadLeft(10)
               ); ;
                //Line of user values
                Console.WriteLine(
                    RedVal.ToString().PadLeft(10) +
                    GreenVal.ToString().PadLeft(10) +
                    BlueVal.ToString().PadLeft(10)
                    ) ;

            } while (!validResponse);
            continueScreen();
            #endregion

            //
            //Put it on the robot
            //
            Console.WriteLine();
            Console.WriteLine("\t Now I will put the colors to the robot!");
            continueScreen();
            doofus.setLED(RedVal,GreenVal,BlueVal);
            Console.WriteLine();
            Console.WriteLine("\t\t Ta-da!");
            continueScreen();
            calculateColor(RedVal, GreenVal, BlueVal);

            return RedVal + GreenVal + BlueVal;
            
           
        }


        static string calculateColor(int RedVal, int GreenVal, int BlueVal)
        {
            string color;
            //
            //Red value
            //
            if ((RedVal > GreenVal) || (RedVal > BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t From the colors you entered the color is mostly Red");
                continueScreen();
            }
            
            //
            //Green value 
            //
            else if ((GreenVal > RedVal) || (GreenVal > BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t From the colors you entered the color is mostly Green");
                continueScreen();
            }

            //
            //Blue Value
            //
            else if ((BlueVal > GreenVal)&&(BlueVal > RedVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t From the colors you entered the color is mostly Blue");
                continueScreen();
            }


            //****************
            //Combo Colors
            //****************

            //
            //Red and blue
            //
            if ((RedVal > GreenVal) && (BlueVal > GreenVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your color should be close to a Purple hue or color");
                continueScreen();
            }
            //
            //Red and Green
            //
            if ((RedVal > BlueVal) && (GreenVal > BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your Color should be close to a Yellow hue or color");
                continueScreen();
            }
            //
            //Green and Blue
            //
            if ((GreenVal > RedVal)&&(BlueVal > RedVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your Color should be close to a Cyan hue or color");
                continueScreen();
            }
            //
            //Color is just white
            //
            if (!((RedVal != GreenVal) || GreenVal != BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your Color should be a White color");
                continueScreen();
            }

            color = "blank";
            return color;






        }



        #region SONG
        //
        //talent show song
        //
        static void talentShowSong(Finch doofus)
        {
            DisplayScreenHeader("Song");
            Console.WriteLine();
            Console.WriteLine($"\t The Finch will now demonstrate a song!");
            continueScreen();
            Console.WriteLine();
            Console.WriteLine("\t The Song Of Storms from Legend of Zelda");
            doofus.setLED(0, 255, 0);
            //
            //song start
            //m1
            doofus.noteOn(523);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m2
            doofus.noteOn(523);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m3
            doofus.noteOn(1300);
            doofus.wait(750);
            doofus.noteOn(1380);
            doofus.wait(250);
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1380);
            doofus.wait(250);
            //m4
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1047);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(1000);
            doofus.noteOff();
            doofus.wait(100);
            //m5
            doofus.noteOn(880);
            doofus.wait(500);
            doofus.noteOn(587);
            doofus.wait(500);
            doofus.noteOn(698);
            doofus.wait(250);
            doofus.noteOn(784);
            doofus.wait(250);
            //m6
            doofus.noteOn(880);
            doofus.wait(1500);
            doofus.noteOff();
            doofus.wait(100);
            //m7
            doofus.noteOn(880);
            doofus.wait(500);
            doofus.noteOn(587);
            doofus.wait(500);
            doofus.noteOn(698);
            doofus.wait(250);
            doofus.noteOn(784);
            doofus.wait(250);
            //m8
            doofus.noteOn(659);
            doofus.wait(1500);
            doofus.noteOff();
            doofus.wait(100);
            //m9
            doofus.noteOn(587);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m10
            doofus.noteOn(523);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m11
            doofus.noteOn(1300);
            doofus.wait(750);
            doofus.noteOn(1380);
            doofus.wait(250);
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1380);
            doofus.wait(250);
            //m12
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1047);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(1000);
            doofus.noteOff();
            doofus.wait(100);
            //13
            doofus.noteOn(880);
            doofus.wait(500);
            doofus.noteOn(587);
            doofus.wait(500);
            doofus.noteOn(698);
            doofus.wait(250);
            doofus.noteOn(784);
            doofus.wait(250);
            //14
            doofus.noteOn(880);
            doofus.wait(1000);
            doofus.noteOff();
            doofus.wait(100);
            doofus.noteOn(880);
            doofus.wait(500);
            //m15
            doofus.noteOn(587);
            doofus.wait(3000);
            doofus.noteOff();
            doofus.setLED(0, 0, 0);

        }
        #endregion


        //
        // Talent show movement
        //
        static void talentShowMovement(Finch doofus)
        {
            DisplayScreenHeader("Movement");
            Console.WriteLine("\tThe Finch robot will not show its movement talent!");
            continueScreen();

            leftTurn(doofus);
            rightTurn(doofus);
            forwardMove(doofus);
            backwardMove(doofus);
            doofus.setMotors(0, 0);
            doofus.setLED(0, 0, 0);
            
        }
        #region Moves
        //
        //left turn
        //
        static void leftTurn(Finch doofus)
        {
            doofus.setLED(250, 0, 250);
            doofus.noteOn(880);
            doofus.setMotors(-100,100);
            doofus.wait(650);
            doofus.setMotors(0, 0);
            doofus.noteOff();

        }

        //
        //right turn
        //
        static void rightTurn(Finch doofus)
        {
            doofus.setLED(0,0,255);
            doofus.noteOn(1000);
            doofus.setMotors(100,-100);
            doofus.wait(650);
            doofus.setMotors(0, 0);
            doofus.noteOff();
        }

        //
        //forward
        //
        static void forwardMove(Finch doofus)
        {
            doofus.setLED(0,250,0);
            doofus.setMotors(100, 100);
            doofus.wait(650);
            doofus.setLED(0,0,0);
        }

        //
        //backward
        //
        static void backwardMove(Finch doofus)
        {
            doofus.setLED(250,0,0);
            doofus.setMotors(-100, -100);
            doofus.wait(650);
            doofus.setMotors(0, 0);

        }
        #endregion

        #region TLightAndSound
        ///  
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        ///  
        /// 
        static void TalentShowDisplayLightAndSound(Finch doofus)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light and Sound");

            Console.WriteLine("\tThe Finch robot will now show its buzzer by playing a scale!!");
            continueScreen();
            for (int i = 0; i < 2; i++)
            {
                doofus.noteOn(523);
                doofus.wait(250);
                doofus.noteOn(587);
                doofus.wait(250);
                doofus.noteOn(659);
                doofus.wait(250);
                doofus.noteOn(698);
                doofus.wait(250);
                doofus.noteOn(784);
                doofus.wait(250);
                doofus.noteOn(880);
                doofus.wait(250);
                doofus.noteOn(988);
                doofus.wait(250);
                doofus.noteOn(1047);
                doofus.wait(500);
                doofus.noteOn(988);
                doofus.wait(250);
                doofus.noteOn(880);
                doofus.wait(250);
                doofus.noteOn(784);
                doofus.wait(250);
                doofus.noteOn(698);
                doofus.wait(250);
                doofus.noteOn(659);
                doofus.wait(250);
                doofus.noteOn(587);
                doofus.wait(250);
                doofus.noteOn(523);
                doofus.wait(250);
                doofus.noteOff();


            }
            
            

            DisplayMenuPrompt("Talent Show Menu");
        }
        #endregion

        #endregion

        #region FINCH ROBOT MANAGEMENT

        ///  
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        ///  
        /// 
        static void DisplayDisconnectdoofus(Finch doofus)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            continueScreen();

            doofus.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        ///  
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        ///  
        ///
        static bool connectdoofus(Finch doofus)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            continueScreen();

            robotConnected = doofus.connect();

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            doofus.setLED(0, 0, 0);
            doofus.noteOff();

            return robotConnected;
        }

        #region DATA RECORDER

        //************************
        //
        // DATA RECORDER
        //
        //*************************
        static void dataRecorderMenu(Finch doofus)
        {
            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            int numberOfDataPoints = 0;
            double dataPointFreq = 0;
            double[] temperatures = null;

            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Number of Data Points");
                Console.WriteLine("\tb) Frequency of Data Points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        numberOfDataPoints = DataRecorderDisplayNumOfDataPoints();
                        break;

                    case "b":
                        dataPointFreq = DataRecorderDiplayGetDataPointFreq();
                        break;

                    case "c":
                        temperatures = dataRecorderDisplayGetData(numberOfDataPoints, dataPointFreq, doofus);
                        break;

                    case "d":
                        DataRecorderDisplayData(temperatures, numberOfDataPoints);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }

            } while (!quitMenu);
        }
        #region TEMPS

       
        //
        //Display Temp Table
        //
        static void displayTempTable(double[] temperatures)
        {
            //
            //display table of temperatures
            //
            Console.WriteLine(
                "Reading #".PadLeft(10) +
                "Temperature".PadLeft(15)
                );
            Console.WriteLine(
                "---------".PadLeft(10) +
                "-----------".PadLeft(15)
                );

            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                      (index + 1).ToString().PadLeft(20) +
                      (temperatures[index]).ToString("n1").PadLeft(15)
               );
            }

        }

        //
        //Convert To Farenheit
        //
        static void convertToF( double[] temperatures, int numberOfDataPoints)
        {
            double[] fTemps = new double[numberOfDataPoints];
            Console.WriteLine();
            Console.WriteLine("\t Now it will show the Temps in Farenheit");
            Console.WriteLine();

            for (int index = 0; index < temperatures.Length; index++)
            {
                
                Console.WriteLine(
                      (index + 1).ToString().PadLeft(20) +
                      ((((temperatures[index])*9)/5)+32).ToString("n1").PadLeft(15)
               );



            }


        }

        //
        //Display Data Table
        //
        static void DataRecorderDisplayData(double[] temperatures, int numberOfDataPoints)
        {


            DisplayScreenHeader("Temperatures");

            //table of temps
            displayTempTable(temperatures);


            continueScreen();

            convertToF(temperatures, numberOfDataPoints);

            continueScreen();
        }

        //
        // Get Temperature Data from robot
        //
        static double[] dataRecorderDisplayGetData(int numberOfDataPoints, double dataPointFreq, Finch doofus)
        {
            double[] temperatures = new double[numberOfDataPoints];
            int dataPointFreqMs;


            //
            //Convert data point freq from seconds to milliseconds
            //
            dataPointFreqMs = (int)(dataPointFreq * 1000);


            DisplayScreenHeader("Temperatures");

            //
            //Echo Values
            //
            Console.WriteLine($"\tThe Finch robot will now record {numberOfDataPoints} temperatures, {dataPointFreq} seconds apart.");
            Console.WriteLine("\t Press any button to begin");
            Console.ReadKey();


            for (int index = 0; index < numberOfDataPoints; index++)
            {
                temperatures[index] = doofus.getTemperature();

                //
                //echo new temp
                //
                Console.WriteLine($"\t Temperature: {index + 1}: {temperatures[index]:n1} ");
                doofus.wait(dataPointFreqMs);

                



            }
            continueScreen();

            //
            //display table of temperatures
            //
            displayTempTable(temperatures);




            DisplayMenuPrompt("Data Recorder");

            return temperatures;
        }

        //
        //Get Data Point Frequency From user
        //
        static double DataRecorderDiplayGetDataPointFreq()
        {
            string dataPointFreqP;
            double dataPointFreq;
            bool validResponse;

            DisplayScreenHeader("Frequency of data points");

            //
            // TO DO VALIDATE THE ENTRY
            //
           

            do
            {
                validResponse = true;

                //
                //insert temps
                //

                dataPointFreqP = Console.ReadLine();
                Console.WriteLine();

                if (!double.TryParse(dataPointFreqP, out dataPointFreq))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits. (10, 35.6, etc...)");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {dataPointFreqP} for frequency in seconds");
                    Console.WriteLine();
                    Console.WriteLine("\tPress any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!validResponse);





            Console.WriteLine();
            Console.WriteLine($"\tYou Chose {dataPointFreq} as the number of data points.");

            DisplayMenuPrompt("Data Recorder");

            return dataPointFreq;
        }

        //
        //Number of Data Points
        //
        static int DataRecorderDisplayNumOfDataPoints()
        {
            string numberOfDataPoints;
            int numberOfDataPointsP;
            bool validResponse;

            DisplayScreenHeader("number of data points");

           

            do
            {
                validResponse = true;

                //
                //insert data
                //
                
                numberOfDataPoints = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(numberOfDataPoints, out numberOfDataPointsP))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using Integers. (10, 35, etc...)");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {numberOfDataPointsP} data points");
                    Console.WriteLine();
                    Console.WriteLine("\tPress any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!validResponse);





            Console.WriteLine();
            Console.WriteLine($"\tYou Chose {numberOfDataPoints} as the number of data points.");

            DisplayMenuPrompt("Data Recorder");

            return numberOfDataPointsP;
        }

        #endregion

        #region Alarm System

        //
        //alarm system menu
        //
        static void alarmSystem(Finch doofus)
        {
            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            string sensorsToMonitor = "";
            string rangeType = "";
            int minMaxThresholdVal =0;
            int timeToMonitor =0;
            

            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Set Sensors To Monitor Light");
                Console.WriteLine("\tb) Set range type for Light");
                Console.WriteLine("\tc) Set min/max values for Light");
                Console.WriteLine("\td) set time to monitor for Light");
                Console.WriteLine("\te) set alarm for Light");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\tf) Temperature Alarm Time to Monitor");
                Console.WriteLine("\tg) Temperature Threshold");
                Console.WriteLine("\th) Temperature Range Type");
                Console.WriteLine("\ti) Temperature alarm");
                Console.WriteLine("\th) set alarm for both temp and light");
                Console.WriteLine("\tq) quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        sensorsToMonitor = alarmSysDisplaySetSensors();
                        break;

                    case "b":
                        rangeType = AlarmSysDisplayRangeType();
                        break;

                    case "c":
                        minMaxThresholdVal = AlarmSysDisplayThresholdVal(sensorsToMonitor, doofus);
                        break;

                    case "d":
                        timeToMonitor = AlarmSysDisplayTimeToMonitor();
                        break;

                    case "e":
                        AlarmSysDiplaySetAlarm(doofus, sensorsToMonitor, rangeType, minMaxThresholdVal, timeToMonitor);
                        break;






                    case "f":
                        tempAlarmGetTimeToMonitor();
                        break;

                    case "g":
                        AlarmSysDisplayThresholdValTemps(doofus);
                        break;

                    case "h":
                        AlarmSysDisplayRangeTypeTemps();
                        break;

                    case "i":
                        AlarmSysTempSetAlarm(doofus, rangeType, timeToMonitor, tempMinMaxThresholdVal);
                        break;

                    case "z":
                        AlarmSysTempAndLightSet(doofus, sensorsToMonitor, rangeType, minMaxThresholdVal, timeToMonitor);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }

              
            } while (!quitMenu);
        }

        // DONE
        //Get Range Type for Temps
        //
        static string AlarmSysDisplayRangeTypeTemps()
        {
            string rangeTypeT = "";
            bool validResponse;
            DisplayScreenHeader("range type");



            do
            {
                validResponse = true;
                rangeTypeT = "";
                //
                //insert rangetype
                //
                Console.WriteLine();
                Console.Write("\tEnter Range Type [minimum, maximum]:");
                rangeTypeT = Console.ReadLine();
                Console.WriteLine();

                if (rangeTypeT == "minimum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (minimum)");
                    validResponse = true;
                }
                else if (rangeTypeT == "maximum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (maximum)");
                    validResponse = true;

                }
                else
                {
                    validResponse = false;
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter either minimum or maximum ( CASE SENSITIVE )");

                    continueScreen();
                }


            } while (!validResponse);

            DisplayMenuPrompt("Alarm System");
            return rangeTypeT;
        }

        //
        //Get Threshold for Temps
        //
        static double AlarmSysDisplayThresholdValTemps(Finch doofus)
        {
            double tempMinMaxThresholdVal= 0;
            double tempSensVal;
            string tempThreshPlace = "";

            DisplayScreenHeader("Threshold Value");

            //
            //display ambient values
            //
            tempSensVal = doofus.getTemperature();
            Console.WriteLine($"\t Current ambient Temp: {tempSensVal:n1}");

            
            

            bool validResponse = true;
            

            //
            //validate threshold
            //
            do
            {
                //
                //get threshold from user and echo
                //
                Console.WriteLine();
                Console.Write("\t Please enter the threshold number you want the alarm to be triggered at:");
                tempThreshPlace = Console.ReadLine();
                validResponse = true;

                if (!double.TryParse(tempThreshPlace, out tempMinMaxThresholdVal ))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {tempMinMaxThresholdVal}");

                    continueScreen();
                }

            } while (!validResponse);

            
            DisplayMenuPrompt("Alarm System");
            return tempMinMaxThresholdVal;

        }

        // DONE
        //Get Time to monitor temps
        //
        static int tempAlarmGetTimeToMonitor()
        {

            string user1;
            string user2;
            bool validResponse;
            int timeToMonitorTemp = 0;


            DisplayScreenHeader("Time To Monitor");
            //
            //TO DO USE LOOP TO VALIDATE
            //
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tTime to monitor in seconds: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out timeToMonitorTemp))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {timeToMonitorTemp} seconds");

                    continueScreen();
                }

            } while (!validResponse);



            continueScreen();
            return timeToMonitorTemp;
            
            
        }

        //
        //alarm for temps
        //
        static void AlarmSysTempSetAlarm(Finch doofus, string rangeTypeT, int timeToMonitorTemp, double tempMinMaxThresholdVal)
        {
            Console.Clear();
            int secondsElapsed = 1;
            
            string tempThreshPlace = "";
            double tempSensVal;
            bool tempThresholdExceeded = false;
            //
            //display current temp value
            //
            tempSensVal = doofus.getTemperature();
            Console.WriteLine($"\t Current ambient Temp: {tempSensVal:n1}");

            //
            //get threshold from user and echo
            //
            Console.WriteLine();
            Console.Write("\t Please enter the threshold number you want the alarm to be triggered at:");
            tempThreshPlace = Console.ReadLine();
            tempMinMaxThresholdVal = double.Parse(tempThreshPlace);
            Console.WriteLine();
            Console.WriteLine($"\tYou entered: {tempMinMaxThresholdVal} for the threshold for Temperatures");
            Console.WriteLine();
            
           
            //
            //start test
            //
            Console.WriteLine("\tPress any button to start the test");
            Console.ReadKey();
           

            do
            {

                tempSensVal = doofus.getTemperature();
                Console.WriteLine($"\tCurrent temp value: {tempSensVal:n1}");
                //
                //wait 1 second and increment
                //
                doofus.wait(1000);
                secondsElapsed++;
                //
                //test to see if it went over limit
                //
                if (rangeTypeT == "minimum")
                {
                    tempThresholdExceeded = (tempSensVal < tempMinMaxThresholdVal);
                }
                else//max
                {
                    tempThresholdExceeded = (tempSensVal > tempMinMaxThresholdVal);
                }
                break;
                
            } while (!tempThresholdExceeded && (secondsElapsed < timeToMonitorTemp));

            Console.WriteLine($"\tCurrent temp value: {tempSensVal}");
            //
            //display result
            //
            if (tempThresholdExceeded)
            {
                Console.WriteLine("Threshold exceeded");
            }
            else
            {
                Console.WriteLine("threshold not exceeded---Time limit met");

            }
            Console.ReadKey();
        }

        //
        //
        //
        //ALARM FOR LIGHT AND TEMPS
        //
        //
        //
        static void AlarmSysTempAndLightSet(Finch doofus, string sensorsToMonitor, string rangeType, int minMaxThresholdVal, int timeToMonitor)
        {
            int tempMinMaxThresholdVal = 0;
            
            bool tempThresholdExceeded = false;
            bool lightThresholdExceeded = false;

            DisplayScreenHeader("Alarm for Temps and Light");
            Console.WriteLine("\t Enter Threshold for Temperature to check for");

            do
            {
               

            } while (!tempThresholdExceeded || !lightThresholdExceeded);
            
        }

       
        //
        //
        //
        //Set The alarm FOR LIGHT
        //
        //
        //
        static void AlarmSysDiplaySetAlarm(Finch doofus, string sensorsToMonitor, string rangeType, int minMaxThresholdVal, int timeToMonitor)
        {
            
            bool thresholdExceeded = false;
            int secondsElapsed = 1;
            int leftLightSensVal;
            int rightLightSensVal;


            DisplayScreenHeader("Set Alarm");
            //
            //echo values
            //
            Console.WriteLine("\tStart");

            //
            //Prompt Usre to start
            //
            continueScreen();




            do
            {
                //
                //get  current light levels
                //
                leftLightSensVal = doofus.getLeftLightSensor();
                rightLightSensVal = doofus.getRightLightSensor();


                //
                //display current light levels
                //
                switch (sensorsToMonitor)
                {
                    case "left":
                        Console.WriteLine($"\tCurrent left light sensor: {leftLightSensVal}");
                        break;

                    case "right":
                        Console.WriteLine($"\tCurrent right light sensor: {rightLightSensVal}");
                        break;

                    case "both":
                        Console.WriteLine($"\tCurrent left light sensor: {leftLightSensVal}");
                        Console.WriteLine($"\tCurrent right light sensor: {rightLightSensVal}");
                        break;

                    default:
                        Console.WriteLine("\tERROR: Unknown Sensor Reference");
                        break;
                }

                //
                //wait 1 second and increment
                //
                doofus.wait(1000);
                secondsElapsed++;

                //
                //test for threshold exceeded
                //
                switch (sensorsToMonitor)
                {
                    case "left":
                        if (rangeType == "minimum")
                        {
                            thresholdExceeded = (leftLightSensVal < minMaxThresholdVal);
                        }
                        else//max
                        {
                            thresholdExceeded = (leftLightSensVal > minMaxThresholdVal);
                        }
                        break;

                    case "right":
                        if (rangeType == "minimum")
                        {
                            if (rightLightSensVal < minMaxThresholdVal)
                            {
                                thresholdExceeded = true;
                            }
                        }
                        else//max
                        {
                            if (rightLightSensVal > minMaxThresholdVal)
                            {
                                thresholdExceeded = true;
                            }
                        }
                        break;

                    case "both":
                        if (rangeType == "minimum")
                        {
                            if ((leftLightSensVal < minMaxThresholdVal) || (rightLightSensVal < minMaxThresholdVal))
                            {
                                thresholdExceeded = true;
                            }

                        }
                        else//max
                        {
                            if ((leftLightSensVal < minMaxThresholdVal) || (rightLightSensVal < minMaxThresholdVal))
                            {
                                thresholdExceeded = true;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown Refernce");
                        break;
                }


            } while (!thresholdExceeded && (secondsElapsed < timeToMonitor));

            //
            //display result
            //
            if (thresholdExceeded)
            {
                Console.WriteLine("Threshold exceeded");
            }
            else
            {
                Console.WriteLine("threhold not exceeded---Time limit met");

            }

            





            DisplayMenuPrompt("Alarm System");
        }

        //
        //Get Time t monitor
        //
        static int AlarmSysDisplayTimeToMonitor()
        {

            string user1;
            string user2;
            bool validResponse;
            int timeToMonitor = 0;


            DisplayScreenHeader("Time To Monitor");
            //
            //TO DO USE LOOP TO VALIDATE
            //
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tTime to monitor in seconds: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out timeToMonitor))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {timeToMonitor} seconds");

                    continueScreen();
                }

            } while (!validResponse);
           
           

            DisplayMenuPrompt("Alarm System");
            return timeToMonitor;
        }

        //
        //Get Threshold
        //
        static int AlarmSysDisplayThresholdVal(string sensorsToMonitor, Finch doofus)
        {
            int thresholdVal = 0;

            int currentLeftSensVal = doofus.getLeftLightSensor();

            int currentRightSensVal = doofus.getRightLightSensor();

            DisplayScreenHeader("Threshold Value");

            //
            //display ambient values
            //
            switch (sensorsToMonitor)
            {
                case "left":
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentLeftSensVal}");
                    break;

                case "right":
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentRightSensVal}");
                    break;

                case "both":
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentLeftSensVal}");
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentRightSensVal}");
                    break;

                default:
                    Console.WriteLine("\tERROR: Unknown Sensor Reference");
                    break;
            }

            //
            //Get Threshold from user
            //
           
            bool validResponse = true;
            string user1;

            //
            //validate threshold
            //
            do
            {
                validResponse = true;
                
                

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tThreshold Value: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out thresholdVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {thresholdVal}");

                    continueScreen();
                }

            } while (!validResponse);

            DisplayMenuPrompt("Alarm System");

            return thresholdVal;
        }

        //
        //Get Range Type
        //
        static string AlarmSysDisplayRangeType()
        {
            string rangeType = "";
            bool validResponse;
            DisplayScreenHeader("range type");

          
          
            do
            {
                validResponse = true;
                rangeType = "";
                //
                //insert rangetype
                //
                Console.WriteLine();
                Console.Write("\tEnter Range Type [minimum, maximum]:");
                rangeType = Console.ReadLine();
                Console.WriteLine();

                if (rangeType =="minimum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (minimum)");
                    validResponse = true;
                }
                else if (rangeType == "maximum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (maximum)");
                    validResponse = true;
                    
                }
                else
                {
                    validResponse = false;
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter either minimum or maximum ( CASE SENSITIVE )");
                    
                    continueScreen();
                }
               

            } while (!validResponse);

            DisplayMenuPrompt("Alarm System");
            return rangeType;
        }

        //
        //Sensors to monitor
        //
        static string alarmSysDisplaySetSensors()
        {
            string sensorsToMonitor = "";

            DisplayScreenHeader("sensors to monitor");

            Console.Write("\tEnter Sensors to Monitor: [Left, Right, Both]");

            //
            // TO DO VALIDATE THIS
            //
            sensorsToMonitor = Console.ReadLine();

            DisplayMenuPrompt("Alarm System");

            return sensorsToMonitor;
        }









        #endregion






        #endregion


        #endregion

        #region USER INTERFACE

        ///  
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        ///  
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            continueScreen();
        }

        ///  
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        ///  
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            continueScreen();
        }

        ///
        /// continue prompt
        ///
        static void continueScreen()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        /// 
        /// menu prompt
        /// 
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// 
        /// display screen header
        ///
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
        #endregion
    }
}
