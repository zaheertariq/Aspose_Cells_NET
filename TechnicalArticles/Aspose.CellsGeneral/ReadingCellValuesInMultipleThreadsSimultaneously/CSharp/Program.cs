//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;
using System;
using System.Threading;

namespace ReadingCellValuesInMultipleThreadsSimultaneouslyExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
        }
            
            public static Workbook testWorkbook;

public static void ThreadLoop()
{
    Random random = new Random();
    while (Thread.CurrentThread.IsAlive)
    {
        int row = random.Next(0, 10000);
        int col = random.Next(0, 100);
        var s = testWorkbook.Worksheets[0].Cells[row, col].StringValue;
        if (s != "R" + row + "C" + col)
        {
           // MessageBox.Show("This message box will show up when cells read values are incorrect.");
        }
    }
}

public static void TestMultiThreadingRead()
{
    testWorkbook = new Workbook();
    testWorkbook.Worksheets.Clear();
    testWorkbook.Worksheets.Add("Sheet1");

    for (var row = 0; row < 10000; row++)
        for (var col = 0; col < 100; col++)
            testWorkbook.Worksheets[0].Cells[row, col].Value = "R" + row + "C" + col;

    //Commenting this line will show a pop-up message
   // testWorkbook.Worksheets[0].Cells.MultiThreadReading = true;

    Thread myThread1;
    myThread1 = new Thread(new ThreadStart(ThreadLoop));
    myThread1.Start();

    Thread myThread2;
    myThread2 = new Thread(new ThreadStart(ThreadLoop));
    myThread2.Start();

    System.Threading.Thread.Sleep(5*1000);
    myThread1.Abort();
    myThread2.Abort();
}

            
        }
    }
