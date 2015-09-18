using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [TestClass]
    class PUTests
    {
        static void Main(string[] args)
        {

        }

        [TestMethod]
        public int[][] populate2DArrayWithInt(int size)
        {
            //declare 2d array
            //select random int values of attributes from already existing data set (and maybe address equavalence classes)
            //select random int values for labels (as last element in each array row)
            //return 2d array
            return null;
        }


        [TestMethod]
        public string[][] populate2DArrayWithStrings(int size) 
        {
            //declare 2d array
            //select random string values of attributes from already existing data set (and maybe address equavalence classes)
            //select random string values for labels (as last element in each array row)
            //return 2d array
            return null;
        }

        /***What should be the test oracle of my PUT? My input is randomly generated
         * As my project is multiple implementation testing, I have always used the 
         * the majority vote as oracle or the actual output from the initial UCI dataset
         * I implemented a 'golden NaiveBayes algorithm' with Dafny for my 10% time.
         * https://github.com/orealeb/naivebayes_dafny
         * Dafny is a program verifier for functional correctness. Therefore, I 
         * expect my implementation to be bug free. Can this be used as an oracle?**/

    }
}
