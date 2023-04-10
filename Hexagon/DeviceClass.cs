using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HidLibrary;

namespace Hexagon
{
    class DeviceClass
    {
        /*
        private int VendorID = 1155;
        private int ProductID = 22353;
        private int ReportLength = 64;
        */
        private HidDevice device;

        private Boolean open;
        private Boolean connected;

        //private HidDevice device;

        public DeviceClass(int VID, int PID, int ReportLength) {
            this.vendorID = VID;
            this.productID = PID;
            this.reportLength = ReportLength;
        }

        public int vendorID{
            get;
            set;
        }

        public int productID
        {
            get;
            set;
        }

        public int reportLength
        {
            get;
            set;
        }

        public Boolean isOpen() {
            return open;
        }

        //Metodi getter e setter per le varibili private


        public Boolean openDevice() {

            //---------Possibile Metodo Check Connection 


            device = HidDevices.Enumerate(vendorID, productID).FirstOrDefault();
            if (device == null)
            {
                Console.WriteLine("Failed to open device.");


                //MessageBox.Show("Failed to open device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Device connected .");
                open = true;
                //Label di comunicazione
                /*
                lblDevConnStatus.Text = "Device Connected.";
                lblPID.Text = ProductID.ToString();
                lblVID.Text = VendorID.ToString();
                */
            }

            return open;

        }

        public Boolean connectDevice() {
            //---------Possibile Metodo Open Device
            if (device == null)
            {
                Console.WriteLine("Failed to connect device.");
                connected = false;
            }
            else
            {
                Console.WriteLine("Device connection successful.");
                connected = true;
            }
            //----------------------------------------------

            return connected;
        }



    }
}
