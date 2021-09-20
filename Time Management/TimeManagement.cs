using System;

namespace Time_Management
{
    public class TimeManagement
    {
        private static int intNumberOfWeeks;
        private static int intWeekNumberofMonth;
        private static double dblHoursWorked;
        private static DateTime dtStartDate;
        private static DateTime dtEndDate;
        private static DateTime dtDateStudied;
        private static int iCounter = 0;
        private static int iSizeArray = 0;

        public void setHoursWorked(double HoursWorked)
        {
            dblHoursWorked = HoursWorked;
        }
        public double getHoursWorked()
        {
            return dblHoursWorked;
        }
        public void setDateStudied(DateTime DateStudied)
        {
            dtDateStudied = DateStudied;
        }
        public DateTime getDateStudied()
        {
            return dtDateStudied;
        }
        public int getWeekNumberofMonth()
        {
            intWeekNumberofMonth = (getDateStudied().Day + ((int)getDateStudied().DayOfWeek)) / 7 + 1;
            return intNumberOfWeeks;
        }

        public void setSemesterDate(DateTime StartDate)
        {
            dtStartDate = StartDate;
        }
        public DateTime getStartDate()
        {
            return dtStartDate;
        }
        public void setSemsterEndDdate(DateTime EndDate)
        {
            dtEndDate = EndDate;
        }

        public DateTime getSemesterEndDate() 
        {
            return dtEndDate;
        }

        public void setNumberOFWeeks(int NumberofWeeks) 
        {
            intNumberOfWeeks = NumberofWeeks;
        }
        public int getNumberOfWeeks()
        {
            return intNumberOfWeeks;
        }
        private static string[] strModuleCode;
        private static string[] strModuleName;
        private static int[] intModuleCredits;
        private static double[] dblHoursPerWeek;

        public void setArray(int num)
        {

            strModuleCode = new string[num];
            strModuleName = new string[num];
            intModuleCredits = new int[num];
            dblHoursPerWeek = new double[num];

            iSizeArray = num;
        }
        public int size()
        {
            return iSizeArray;
        }
        public bool addToArray(string ModuleCode, string ModuleName, int ModuleCredits, double HoursPerWeek)
        {
            if (iCounter < iSizeArray)
            {
                strModuleCode[iCounter] = ModuleCode;
                strModuleName[iCounter] = ModuleName;
                intModuleCredits[iCounter] = ModuleCredits;
                dblHoursPerWeek[iCounter] = HoursPerWeek;
                iCounter++;
                return true;

            }
            else
            {
                return false;
            }
        }
        public string getModuleCode(int x)
        {
            return strModuleCode[x];
        }
        public string getModuleName(int x)
        {
            return strModuleName[x];
        }
        public int getModuleCredits(int x)
        {
            return intModuleCredits[x];
        }
        public double getHoursPerWeek(int x)
        {
            return dblHoursPerWeek[x];
        }
        public int getCounnter()
        {
            return iCounter;
        }
    }
}
