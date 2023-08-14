using System;

//ref link:https://www.youtube.com/watch?v=vijrmWIN1Ho&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA
//  Type Fundamentals

class MainClass
{
    static void Main()
    {
        //System.Int32 myAge = 55;  //32 bits memory(RAM)
        // myAge = 55; // -3 -2 -1 0 1 2 3 4 5     // Limits Code use -- requires binary code knowledge
        
        //System.Double myWaterBottleOunces = 32.78; // 64bits memory(RAM)
        //double myWaterBottleOunces = 32.790843298348; //  
        //int thisIsNuts = myAge + myWaterBottleOunces;

        int myAge = 55;
        int yourAge = 25;
        int combinedAge = myAge + yourAge;
        string myName = "Kulpot";
        string yourName = "Watcher";
        string combinedNames = myName + yourName;   // KulpotWatcher
        int differenceInAge = myAge - yourAge;
        //string differenceInNames = myName - yourName;   // error
        //myAge.
        //myAge.ToUpper();
        
    }
}