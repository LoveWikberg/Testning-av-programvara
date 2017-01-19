using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace CardGame
{
    class ModuleTest
    {

        string[] testCases = new string[52];
        public ModuleTest()
        {
            for (int i = 0; i < 52; i++)
            {
                if (i < 13)
                {
                    if (i < 9)
                        testCases[i] = "00" + (i + 1) + ":" + ListClass.rank[i].Input + ListClass.color[0].Input + ":"
                            + ListClass.rank[i].Card + " of " + ListClass.color[0].Card;
                    else
                        testCases[i] = "0" + (i + 1) + ":" + ListClass.rank[i].Input + ListClass.color[0].Input + ":"
                            + ListClass.rank[i].Card + " of " + ListClass.color[0].Card;
                }
                else if (i >= 13 && i < 26)
                    testCases[i] = "0" + (i + 1) + ":" + ListClass.rank[i - 13].Input + ListClass.color[1].Input + ":"
                            + ListClass.rank[i - 13].Card + " of " + ListClass.color[1].Card;
                else if (i >= 26 && i < 39)
                    testCases[i] = "0" + (i + 1) + ":" + ListClass.rank[i - 26].Input + ListClass.color[2].Input + ":"
                            + ListClass.rank[i - 26].Card + " of " + ListClass.color[2].Card;
                else if (i >= 39 && i < 52)
                    testCases[i] = "0" + (i + 1) + ":" + ListClass.rank[i - 39].Input + ListClass.color[3].Input + ":"
                            + ListClass.rank[i - 39].Card + " of " + ListClass.color[3].Card;
            }
        }

        public void StartTest()
        {
            CardHandler CardHandler = new CardHandler();
            var file = Directory.GetCurrentDirectory() + "\\module testing.txt";
            File.WriteAllText(file, "Test results:" + Environment.NewLine);

            foreach (var tc in testCases)
            {
                string[] tokens = tc.Split(':');
                string caseID = tokens[0];
                string input = tokens[1];
                string expected = tokens[2];
                if (CardHandler.ConvertToCard(input) == expected)
                    File.AppendAllText(file, caseID + " PASS" + Environment.NewLine);
                else
                    File.AppendAllText(file, caseID + " FAIL" + Environment.NewLine);
            }

            Process process = new Process();
            process.StartInfo.FileName = "module testing.txt";
            process.Start();
        }
    }
}
