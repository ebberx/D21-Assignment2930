﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TextClassification.Controller;
using TextClassification.Domain;
using TextClassification.FileIO;
using TextClassification.Foundation;

namespace Test
{
    [TestClass]
    public class Testing
    {

        [TestMethod]
        public void TestWordItemGetWord()
        {
            // arrange
            string expected = "nice";
            WordItem wI = new WordItem("nice", 0);

            // act
            string actual = wI.GetWord();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStringOperationsGetFileName()
        {
            // deprecated - use 
            // arrange
            string expected = "Suduko";
            string path = "c:\\users\\tha\\documents\\Suduko.txt";

            // act
            string actual = StringOperations.getFileName(path);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFileGetAllFileNames()
        {
            // arrange
            string folderA = "ClassA";
            string fileType = "txt";
            List<string> expected = new List<string>();
            expected.Add("C:\\Users\\win\\source\\repos\\D21-Assignment2930\\TextClassification\\bin\\Debug\\" + folderA+"\\bbcsportsfootball."+fileType);
            expected.Add("C:\\Users\\win\\source\\repos\\D21-Assignment2930\\TextClassification\\bin\\Debug\\"+folderA+"\\dailymirrornfl."+fileType);
            expected.Add("C:\\Users\\win\\source\\repos\\D21-Assignment2930\\TextClassification\\bin\\Debug\\" + folderA+"\\sunsportsboxing."+fileType);

            // act
            FileAdapter fa = new TextFile(fileType);
            List<string> actual = fa.GetAllFileNames(folderA);

            // assert
            Assert.AreEqual(expected.Count, actual.Count);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }
        [TestMethod]
        public void TestGetFilePathA()
        {
            // arrange
            string folderA = "ClassA";
            string fileType = "txt";
            string fileName = "filnavn";
            string expected = "C:\\Users\\win\\source\\repos\\D21-Assignment2930\\TextClassification\\bin\\Debug\\" + folderA + "\\filnavn." + fileType;

            // act
            TextFile tf = new TextFile(fileType);
            string actual = tf.GetFilePathA(fileName);

            // assert
            Assert.AreEqual(expected, actual);
        }


    }
}
