using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineCodeChallenge
{
    public class Entry : IComparable<Entry>
    {
        /* Initialize with value and depth */
        public Entry(String value, int depth)
        {
            Value = value;
            Depth = depth;
            Location = NextLocation++;
            IndentCharacter = '-';
        }

        /* Instance Variables 
         * Value - String value
         * NextLocation - unique ID used for keeping position word in the original string
         * Depth - Level of nesting (ie the number of open parentheses before the word)
         * IndentCharacter - the character used in PrettyString methods to show nesting level
         */
        private String Value;
        private static int NextLocation = 0;
        private int Depth;
        private int Location;
        private char IndentCharacter;

        /* Getters and Setters */
        public String GetValue()
        {
            return Value;
        }

        public void SetValue(String value)
        {
            Value = value;
        }

        public int GetNextLocation()
        {
            return NextLocation;
        }

        public int GetDepth()
        {
            return Depth;
        }

        public void SetDepth(int newDepth)
        {
            Depth = newDepth;
        }

        public int GetLocation()
        {
            return Location;
        }

        public void SetLocation(int newLocation)
        {
            Location = newLocation;
        }

        public char GetIndentCharacter()
        {
            return IndentCharacter;
        }

        public void SetIndentCharacter(char newIndentCharacter)
        {
            IndentCharacter = newIndentCharacter;
        }

        /* Pretty String methods, used to print formatted output as detailed in spec document */
        public String GetPrettyString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Depth; i++)
            {
                stringBuilder.Append(IndentCharacter);
            }

            if(Depth > 0)
                stringBuilder.Append(' ');
            
            stringBuilder.Append(Value);

            return stringBuilder.ToString();
        }

        public void PrintPrettyString()
        {
            Console.Write(GetPrettyString());
        }

        /* Compare method for comparing two entries 
         * Based off of value of element
         */
        public int CompareTo(Entry otherEntry)
        {
            if (otherEntry == null)
                return 1;
            
            return Value.CompareTo(otherEntry.GetValue());
        }

    }
}
