using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineCodeChallenge
{
    public class Parser
    {
        /* Default initializer, intializes format characters to those specified in spec doc */
        public Parser()
        {
            Entries = new List<Entry>();
            IncrementCharacter = '(';
            DecrementCharacter = ')';
            EntryDelimiter = ',';
        }

        /* Entries - List of entries in found in encoded text 
         * IncrementCharacter - Character indicating deeper level of nesting
         * DecrementCharacter - Character indicating higher level of nesting
         * EntryDelimeter - Character seperating two entries
         */
        private List<Entry> Entries;
        private char IncrementCharacter;
        private char DecrementCharacter;
        private char EntryDelimiter;

        /* Getters and Setters (Mutators and Accesors) */
        public void SetIncrementCharacter(char newIncrementCharacter)
        {
            IncrementCharacter = newIncrementCharacter;
        }

        public char GetIncrementCharacter()
        {
            return IncrementCharacter;
        }

        public void SetDecrementCharacter(char newDecrementCharacter)
        {
            DecrementCharacter = newDecrementCharacter;
        }

        public char GetDecrementCharacter()
        {
            return DecrementCharacter;
        }

        public void SetEntryDelimiter(char newEntryDelimiter)
        {
            EntryDelimiter = newEntryDelimiter;
        }

        public char GetEntryDelimiter()
        {
            return EntryDelimiter;
        }
        public List<Entry> GetEntries()
        {
            return Entries;
        }

        public void AddEntry(Entry newEntry)
        {
            Entries.Add(newEntry);
        }

        public void ClearEntries()
        {
            Entries.Clear();
        }

        /* Parse method */
        public void Parse(String inputString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            int depth = -1; // Init depth to -1 as the encoding string starts with the start delimeter
            
            foreach (char character in inputString)
            {
                /* Increment Depth level and add new entry */
                if (character.Equals(IncrementCharacter))
                {
                    if (stringBuilder.Length != 0)
                    {
                        Entry nextEntry = new Entry(stringBuilder.ToString(), depth);
                        Entries.Add(nextEntry);
                        stringBuilder.Clear();
                    }

                    depth++;
                } /* Decrement Depth Level and add new entry */
                else if (character.Equals(DecrementCharacter))
                {
                    if (stringBuilder.Length != 0)
                    {
                        Entry nextEntry = new Entry(stringBuilder.ToString(), depth);
                        Entries.Add(nextEntry);
                        stringBuilder.Clear();
                    }

                    depth--;
                } /* Add new entry */
                else if (character.Equals(EntryDelimiter))
                {
                    if (stringBuilder.Length != 0)
                    {
                        Entry nextEntry = new Entry(stringBuilder.ToString(), depth);
                        Entries.Add(nextEntry);
                        stringBuilder.Clear();
                    }
                } /* Continue building string entry */
                else
                    stringBuilder.Append(character);
            }
        }

        /* PrettyString methods */
        public String GetPrettyString(Sorting.SortType sortType)
        {
            /* Ignore empty list */
            if (Entries.Count() == 0)
                return "";

            StringBuilder stringBuilder = new StringBuilder();

            /* Create copy of entries */
            List<Entry> tempEntries = new List<Entry>(Entries);
            
            if (sortType == Sorting.SortType.ASCII_SORT)
            {
                /* Create String list 
                 * Avoids Entry reference issue that occurs if I modify
                 * the Entry string directly
                 */
                List<string> entryStrings = new List<string>();

                /* PrettyString encode so that sorting takes into account
                 * '-' characters, this is what is meant by ascii sort, the
                 * pretty string is what is sorted by the characters ascii
                 * values.
                 */
                foreach (Entry entry in tempEntries)
                {
                    string prettyString = entry.GetPrettyString();
                    entryStrings.Add(prettyString);
                }
                
                entryStrings.Sort();
                
                /* Build Output */
                foreach (string entry in entryStrings)
                {
                    stringBuilder.Append(entry);
                    stringBuilder.Append('\n');
                }
            }
            else if (sortType == Sorting.SortType.ALPHABETICAL_SORT)
            {
                /* Sort normally with value of Entries, not pretty formatted */
                tempEntries.Sort();

            }

            /* Build output if not already built */
            if( sortType != Sorting.SortType.ASCII_SORT)
                foreach (Entry entry in tempEntries)
                {
                    stringBuilder.Append(entry.GetPrettyString());
                    stringBuilder.Append('\n');
                }

            return stringBuilder.ToString();
        }

        public void PrettyPrintEntries(Sorting.SortType alphabeticalOrder)
        {
            Console.Write(GetPrettyString(alphabeticalOrder));
        }


    }

}
