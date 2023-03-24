using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSVReaderAPPTests
{
    public class Fixture
    {

        public static List<string> StringFirstDscOrder() 
        {
            return new() {"Smith 2","Clive 2","Owen 2","James 2","Brown 2","Graham 2","Howe 2","Jimmy 1","John 1"};
        }


        public static List<string> StringSecondAlphab() 
        {
            return new() { "65 Ambling Way", "8 Crimson Rd", "12 Howard St", "102 Long Lane", "94 Roland St", "82 Stewart St", "78 Short Lane", "49 Sutherland St"};




        }
    }
}
