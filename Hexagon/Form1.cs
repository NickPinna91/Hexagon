using System;
using System.Windows.Forms;
using ACSharedMemory;
using System.IO.MemoryMappedFiles;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

using HidLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Hexagon
{
    public partial class Form1 : Form
    {

        //Variabile per lettura da gioco
        private AcData acData1;
        private dataACBuffer dataACBuf;

        //Variabili per lettura/scrittura su periferica HID
        ////STM32 PID VID
        /*
        private int VendorID = 1155;
        private int ProductID = 22353;
        */
        //ESP32 PID VID
        private int VendorID = 0x303a;
        private int ProductID = 0x0002;
        //ARDUINO PID VID
        //deviceList = HidDevices.Enumerate(0x2341, 0x8036).ToArray();
        //private int VendorID = 0x2341;
        //private int ProductID = 0x8036;

        private int ReportLength = 64;
        private HidDevice device;

        private Boolean open;
        private Boolean changeData;

        public struct AcData
        {
            public AcData(Physics p, ACSharedMemory.Graphics g, StaticInfo s, bool ready)
            {
                physics = p;
                graphics = g;
                staticInfo = s;
                readyInfo = ready;
            }
            public Physics physics { get; set; }
            public ACSharedMemory.Graphics graphics { get; set; }
            public StaticInfo staticInfo { get; set; }
            public bool readyInfo { get; set; }

        }

        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 0, Size = 64)]
        public struct dataACBuffer {

            public byte padding;
            public byte codMode;
            public short speed;
            public int RPM;
            public char gear;
            
            //Pressure data
            public float frontLeftPressure;
            public float frontRightPressure;
            public float rearLeftPressure;
            public float rearRightPressure;

            //Temp data
            public short frontLeftTemp;
            public short frontRightTemp;
            public short rearLeftTemp;
            public short rearRightTemp;

            //Lap timings
            public string lastLap;
            public string bestLap;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadGameData_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //homePanel.Visible = false;
        }

        private void btnCheckDevConn_Click(object sender, EventArgs e)
        {
            openAndConnectDevice();
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            changeData = true;
            if (open) {
                Boolean exit = false;
                do
                {
                    sendFakeData();
                } while (exit == false);
            }
        }


        private Boolean openAndConnectDevice() {
            //---------Possibile Metodo Check Connection 


            device = HidDevices.Enumerate(VendorID, ProductID).FirstOrDefault();

            /*
            for (int i = 0; i< dev.Length; i++) {
                Console.WriteLine(dev[i].ToString());
            }*/


            if (device == null)
            {
                Console.WriteLine("Failed to open device.");


                //MessageBox.Show("Failed to open device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Environment.Exit(1);
                lblDevConnStatus.Text = "Device Not Connected ... Connect device and try again.";
            }
            else
            {
                lblDevConnStatus.Text = "Device Connected.";
                lblPID.Text = ProductID.ToString();
                lblVID.Text = VendorID.ToString();
            }

            //---------Possibile Metodo Open Device
            if (device == null)
            {
                Console.WriteLine("Failed to open device.");
                MessageBox.Show("Failed to open device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                open = false;
            }
            else
            {
                Console.WriteLine("Device connection successful.");
                open = true;
            }
            //----------------------------------------------

            return open;
        }

        private void ReadReportCallback(HidReport report)
        {
            Console.WriteLine("recv: {0}", string.Join(", ", report.Data.Select(b => b.ToString("X2"))));
            device.ReadReport(ReadReportCallback);
        }




        //-----Start Metodo lettura Dati-----//
        public AcData readMappedFile()
        {

            Physics p;
            Graphics g;
            StaticInfo i;

            AcData acData = new AcData(); ;

            MemoryMappedFile physicsMMF;
            MemoryMappedFile graphicsMMF;
            MemoryMappedFile staticInfoMMF;

            try
            {


                physicsMMF = MemoryMappedFile.OpenExisting("Local\\acpmf_physics");
                graphicsMMF = MemoryMappedFile.OpenExisting("Local\\acpmf_graphics");
                staticInfoMMF = MemoryMappedFile.OpenExisting("Local\\acpmf_static");


                //read physics
                using (var stream = physicsMMF.CreateViewStream())
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        var size = Marshal.SizeOf(typeof(Physics));
                        var bytes = reader.ReadBytes(size);
                        var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                        p = (Physics)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(Physics));
                        handle.Free();
                    }
                }

                //read graphics
                using (var stream = graphicsMMF.CreateViewStream())
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        var size = Marshal.SizeOf(typeof(ACSharedMemory.Graphics));
                        var bytes = reader.ReadBytes(size);
                        var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                        g = (ACSharedMemory.Graphics)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(ACSharedMemory.Graphics));
                        handle.Free();
                    }
                }

                //read static info
                using (var stream = staticInfoMMF.CreateViewStream())
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        var size = Marshal.SizeOf(typeof(StaticInfo));
                        var bytes = reader.ReadBytes(size);
                        var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                        i = (StaticInfo)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(StaticInfo));
                        handle.Free();
                    }
                }

                acData = new AcData(p, g, i, true);



            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Assetto Corsa non avviato ");
                DialogResult messageError = MessageBox.Show("Files not found", "Return", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (messageError == DialogResult.OK)
                {

                }
            }


            return acData;

        }
        //-----Fine Metodo lettura Dati-----//

        //-----Start Metodo Aggiornamento Dati-----//
        private void updateData()
        {

            Task.Factory.StartNew(() =>
            {

                do
                {
                    acData1 = readMappedFile();
                    if (acData1.readyInfo == true)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {

                            //  Tachimetro
                            lblRPM.Text = acData1.physics.Rpms.ToString();
                            lblGear.Text = adjustGear(acData1.physics.Gear);
                            lblSpeed.Text = ((int)acData1.physics.SpeedKmh).ToString() + "Km/h";

                            //tempi
                            lblBestLap.Text = acData1.graphics.BestTime;
                            lblLastLap.Text = acData1.graphics.LastTime;

                            //info gomme
                            //Front
                            lblFrontLeftPressure.Text = acData1.physics.WheelsPressure[0].ToString() + " PSI";
                            lblFrontLeftTemp.Text = ((int)acData1.physics.TyreCoreTemperature[0]).ToString() + " °c";
                            lblFrontRightPressure.Text = acData1.physics.WheelsPressure[1].ToString() + " PSI";
                            lblFrontRightTemp.Text = ((int)acData1.physics.TyreCoreTemperature[1]).ToString() + " °c";
                            //rear
                            lblRearLeftPressure.Text = acData1.physics.WheelsPressure[2].ToString() + " PSI";
                            lblRearLeftTemp.Text = ((int)acData1.physics.TyreCoreTemperature[2]).ToString() + " °c";
                            lblRearRightPressure.Text = acData1.physics.WheelsPressure[3].ToString() + " PSI";
                            lblRearRightTemp.Text = ((int)acData1.physics.TyreCoreTemperature[3]).ToString() + " °c";

                            lblMaxRPM.Text = "Max RPM: " + acData1.staticInfo.MaxRpm.ToString();

                            //updateLabel(acData1);

                            //Tachimeter data for buffer
                            dataACBuf.RPM = acData1.physics.Rpms;
                            dataACBuf.gear = (adjustGear(acData1.physics.Gear)).FirstOrDefault();
                            dataACBuf.speed = (short)acData1.physics.SpeedKmh;

                            //Front Tyres info for data buffer
                            dataACBuf.frontLeftPressure = acData1.physics.WheelsPressure[0];
                            dataACBuf.frontRightPressure = acData1.physics.WheelsPressure[1];
                            dataACBuf.frontLeftTemp = (short)acData1.physics.TyreCoreTemperature[0];
                            dataACBuf.frontRightTemp = (short)acData1.physics.TyreCoreTemperature[1];

                            //Rear Tyres info for data buffer
                            dataACBuf.rearLeftPressure = acData1.physics.WheelsPressure[2];
                            dataACBuf.rearRightPressure = acData1.physics.WheelsPressure[3];
                            dataACBuf.rearLeftTemp = (short)acData1.physics.TyreCoreTemperature[2];
                            dataACBuf.rearRightTemp = (short)acData1.physics.TyreCoreTemperature[3];

                            //Timings data for buffer
                            dataACBuf.bestLap = acData1.graphics.BestTime;
                            dataACBuf.lastLap = acData1.graphics.LastTime;

                            //fillBuffer(acData1);

                            dataACBuf.codMode = 7;

                            sendData(dataACBuf);
/*
                            if (open == true)
                            {
                                sendData(dataACBuf);
                            }
                            else {
                                Console.WriteLine("Dispositivo hid non connesso");
                            }
*/
                            //svuoto il buffer
                            dataACBuf = default(dataACBuffer);

                        });


                        Thread.Sleep(10);
                    }  
                } while (acData1.readyInfo == true);
            });
        }
        //-----Fine Metodo Aggiornamento Dati-----//

        private void updateLabel(AcData acData1) {
            //  Tachimetro
            lblRPM.Text = acData1.physics.Rpms.ToString();
            lblGear.Text = adjustGear(acData1.physics.Gear);
            lblSpeed.Text = ((int)acData1.physics.SpeedKmh).ToString() + "Km/h";

            //tempi
            lblBestLap.Text = acData1.graphics.BestTime;
            lblLastLap.Text = acData1.graphics.LastTime;

            //info gomme
            //Front
            lblFrontLeftPressure.Text = acData1.physics.WheelsPressure[0].ToString() + " PSI";
            lblFrontLeftTemp.Text = ((int)acData1.physics.TyreCoreTemperature[0]).ToString() + " °c";
            lblFrontRightPressure.Text = acData1.physics.WheelsPressure[1].ToString() + " PSI";
            lblFrontRightTemp.Text = ((int)acData1.physics.TyreCoreTemperature[1]).ToString() + " °c";
            //rear
            lblRearLeftPressure.Text = acData1.physics.WheelsPressure[2].ToString() + " PSI";
            lblRearLeftTemp.Text = ((int)acData1.physics.TyreCoreTemperature[2]).ToString() + " °c";
            lblRearRightPressure.Text = acData1.physics.WheelsPressure[3].ToString() + " PSI";
            lblRearRightTemp.Text = ((int)acData1.physics.TyreCoreTemperature[3]).ToString() + " °c";

            lblMaxRPM.Text = "Max RPM: " + acData1.staticInfo.MaxRpm.ToString();
        }

        private void fillBuffer(AcData acData1) {
            //Tachimeter data for buffer
            dataACBuf.RPM = acData1.physics.Rpms;
            dataACBuf.gear = (adjustGear(acData1.physics.Gear)).FirstOrDefault();
            dataACBuf.speed = (short)acData1.physics.SpeedKmh;

            //Front Tyres info for data buffer
            dataACBuf.frontLeftPressure = acData1.physics.WheelsPressure[0];
            dataACBuf.frontRightPressure = acData1.physics.WheelsPressure[1];
            dataACBuf.frontLeftTemp = (short)acData1.physics.TyreCoreTemperature[0];
            dataACBuf.frontRightTemp = (short)acData1.physics.TyreCoreTemperature[1];

            //Rear Tyres info for data buffer
            dataACBuf.rearLeftPressure = acData1.physics.WheelsPressure[2];
            dataACBuf.rearRightPressure = acData1.physics.WheelsPressure[3];
            dataACBuf.rearLeftTemp = (short)acData1.physics.TyreCoreTemperature[2];
            dataACBuf.rearRightTemp = (short)acData1.physics.TyreCoreTemperature[3];

            //Timings data for buffer
            dataACBuf.bestLap = acData1.graphics.BestTime;
            dataACBuf.lastLap = acData1.graphics.LastTime;
        }

        //-----Start Metodo Correzione Marce-----//
        private string adjustGear(int gear)
        {

            string gearString = "";

            if (gear > 1)
            {
                gearString = (gear - 1).ToString();
            }
            if (gear == 0)
            {
                gearString = "R";
            }
            if (gear == 1)
            {
                gearString = "N";
            }

            return gearString;
        }
        //-----Fine Metodo Correzione Marce-----//


        private void sendData(dataACBuffer buffer)
        {
            try
            {

                byte[] data = new byte[64];     

                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(dataACBuf));
                Marshal.StructureToPtr(buffer, ptr, false);
                Marshal.Copy(ptr, data, 0, Marshal.SizeOf(dataACBuf));
                Marshal.FreeHGlobal(ptr);

                Console.WriteLine("-----------Float Binary Pressure data-----------");
                Console.WriteLine("FL:  " + BitConverter.ToString(BitConverter.GetBytes(buffer.frontLeftPressure)));
                Console.WriteLine("FR:  " + BitConverter.ToString(BitConverter.GetBytes(buffer.frontRightPressure)));
                Console.WriteLine("RL:  " + BitConverter.ToString(BitConverter.GetBytes(buffer.rearLeftPressure)));
                Console.WriteLine("RR:  " + BitConverter.ToString(BitConverter.GetBytes(buffer.rearRightPressure)));

                Console.WriteLine("-------------- Dati Buffer --------------");
                for (int i = 0; i < Marshal.SizeOf(dataACBuf); i++)
                {
                    Console.WriteLine(data[i]+" "+ Convert.ToString(data[i], 2));
                }

                
                HidDeviceData dt = new HidDeviceData(data, HidDeviceData.ReadStatus.Success);
                device.WriteReport(new HidReport(data.Length, dt));
                //device.WriteFeatureData(data);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        

        private void sendFakeData()
        {
            try
            {
                //NOTE ADDED 2 Bytes for padding
                byte[] data = new byte[66];
                /*
                if (changeData == true)
                {
                    for (int i = 0; i < Marshal.SizeOf(dataACBuf) -2; i++)
                    {
                        data[i] = 0xFF;
                    }
                    changeData = false;
                }
                else {
                    for (int i = 0; i < Marshal.SizeOf(dataACBuf) - 2; i++)
                    {
                        data[i] = 0x00;
                    }
                    changeData = true;
                }
                */
                data[1] = 0;
                for (int i = 2; i < 66 ; i++)
                {
                    data[i] = 0xFF;
                    //Thread.Sleep(1000); //ms
                }
                device.WriteReport(new HidReport(data.Length, new HidDeviceData(data, HidDeviceData.ReadStatus.Success)));
                data[1] = 1;
                for (int i = 22; i < 66; i++)
                {
                    data[i] = 0xFF;
                    //Thread.Sleep(1000); //ms
                }

                device.WriteReport(new HidReport(data.Length, new HidDeviceData(data, HidDeviceData.ReadStatus.Success)));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void DoUpdate(object sender, System.EventArgs e)
        {
            //ring s = Encoding.UTF8.GetString(bytes, 2, 2 + bytes[1]);
            //textBoxRecieved.AppendText(s);
            //textBoxRecieved.AppendText("\n");

        }



    }
}
