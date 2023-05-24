using System;
using System.Linq;
using System.Security.Cryptography;
using HidLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        //HID device(vID= 0x2341, pID= 0x8036, v= 0x0100); Arduino Leonardo
        //HID device(vID= 0x303a, pID= 0x1001, v= 0x0100); Espressif Systems; TinyUSB HID, Path: \\?\hid#vid_303a&pid_1001&mi_02&col06#8&36a00c5d&0&0005#{4d1e55b2-f16f-11cf-88cb-001111000030}

        static void Main(string[] args)
        {
            byte[] OutData;
            HidDevice[] deviceList;
            deviceList = HidDevices.Enumerate(0x2341, 0x8036).ToArray();

            for (int i= 0; i<deviceList.Length;i++) {
                Console.WriteLine("//------------DEVICE NUM "+i+" ------------//");
                Console.WriteLine(deviceList[i]);
                Console.WriteLine("Usage " + deviceList[i].Capabilities.Usage);
                Console.WriteLine("UsagePage " + deviceList[i].Capabilities.UsagePage);
                Console.WriteLine("InputReportByteLength " + deviceList[i].Capabilities.InputReportByteLength);
                Console.WriteLine("OutputReportByteLength " + deviceList[i].Capabilities.OutputReportByteLength);
                Console.WriteLine("FeatureReportByteLength " + deviceList[i].Capabilities.FeatureReportByteLength);
                Console.WriteLine("Reserved " + deviceList[i].Capabilities.Reserved);
                Console.WriteLine("NumberLinkCollectionNodes " + deviceList[i].Capabilities.NumberLinkCollectionNodes);
                Console.WriteLine("NumberInputButtonCaps " + deviceList[i].Capabilities.NumberInputButtonCaps);
                Console.WriteLine("NumberInputValueCaps " + deviceList[i].Capabilities.NumberInputValueCaps);
                Console.WriteLine("NumberInputDataIndices " + deviceList[i].Capabilities.NumberInputDataIndices);
                Console.WriteLine("NumberOutputButtonCaps " + deviceList[i].Capabilities.NumberOutputButtonCaps);
                Console.WriteLine("NumberOutputValueCaps " + deviceList[i].Capabilities.NumberOutputValueCaps);
                Console.WriteLine("NumberOutputDataIndices " + deviceList[i].Capabilities.NumberOutputDataIndices);
                Console.WriteLine("NumberFeatureButtonCaps " + deviceList[i].Capabilities.NumberFeatureButtonCaps);
                Console.WriteLine("NumberFeatureValueCaps " + deviceList[i].Capabilities.NumberFeatureValueCaps);
                Console.WriteLine("NumberFeatureDataIndices " + deviceList[i].Capabilities.NumberFeatureDataIndices);

            }

            /* Snippet per leggere input
            HidDeviceData InData;
            string text;
            InData = deviceList[5].Read();
            text = System.Text.ASCIIEncoding.ASCII.GetString(InData.Data);
            Console.WriteLine(text);
            */
            HidReport inReport, outReport;
            //int offset = 0;
            //int remainCount = 
            Console.WriteLine("Write Handle "+deviceList[0].WriteHandle);
            Console.WriteLine("Read Handle " + deviceList[0].ReadHandle);

            deviceList[0].OpenDevice();
            HidReport report = deviceList[0].CreateReport();
            OutData = new byte[deviceList[0].Capabilities.OutputReportByteLength];
            OutData[0] = 0xFF;
            // Send a report to initiate an error sound
            for (int i = 1; i < OutData.Length; i++) {
                OutData[i] = 0xFF;
            }
            report.Data = OutData;
            report.ReportId = 6;
            
            //deviceList[5].MonitorDeviceEvents = true;
            int timeout = 0;
            bool w;
            
            if (deviceList[0].IsConnected)
            {
                do {
                    //w = deviceList[5].Write(OutData, timeout);
                    w = deviceList[0].WriteReport(report);
                    Console.WriteLine("WRITE OUT " + w + " timeout " + timeout);
                    //timeout++;

                }while (true);
            }


        }
    }
}