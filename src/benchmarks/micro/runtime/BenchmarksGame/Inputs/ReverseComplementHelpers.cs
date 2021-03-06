// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Helper functionality to locate inputs and find outputs for
// reverse-complement benchmark in CoreCLR test harness

using System;
using System.IO;
using System.Text;

namespace BenchmarksGame
{
    class ReverseComplementHelpers
    {
        public string InputFile;
        public int FileLength;
        public string CheckSum;

        public ReverseComplementHelpers(bool bigInput)
        {
            if (bigInput)
            {
                InputFile = InputFileHelper.FindInputFile("revcomp-input25000.txt");
                CheckSum = "61-A4-CC-6D-15-8D-26-77-88-93-4F-E2-29-A2-8D-FB";
            }
            else
            {
                InputFile = InputFileHelper.FindInputFile("revcomp-input25.txt");
                CheckSum = "62-45-8E-09-2E-89-A0-69-8C-17-F5-D8-C7-63-5B-50";
            }
            
            FileLength = InputFileHelper.GetFileLength(InputFile);
        }
    }
}
