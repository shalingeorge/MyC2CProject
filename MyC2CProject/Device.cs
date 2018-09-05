using System;
using System.Collections.Generic;
using System.Text;

namespace MyC2CProject
{

    public class  Device :IComm
    {

        
       
        public string  Model{ get; set; }
      
       
        public int  PixelRatio { get; set; }

        

        public void ZoomIn()
        {
            Console.WriteLine("Zoom In");
        }
        public void ZoomOut()
        {
            Console.WriteLine("ZoomOut");
        }
        public virtual bool SendPicture()
        {
            Console.WriteLine("Picture Sent");
            return true;
        }


        private string _processor;
        public string Processor
        {
            get { return _processor; }
        }

        private int _internalMemory;
        public int InternalMemory
        {
            get { return _internalMemory; }
        }

        public  virtual void GetDeviceICode()
        {
            
        }

        public  bool CameraClick(string CameraMode)
        {
            Console.WriteLine("Camera clicked in " + CameraMode + " Mode");
            return true;
        }

        public void CameraClick()
        {
            Console.WriteLine("Camera clicked");
        }


    }

    public class Camera : Device
    {

        private double cameraid = 36778787565;
        public override bool SendPicture()
        {
            Console.WriteLine("Picture Sent from Camera");
            return true;
        }


        public override void GetDeviceICode()
        {
            Console.WriteLine("Camera DeviceCode:" + cameraid);
        }



        //This is one overloaded method which shows camera functionality as well but with its camera's different mode(panarome)

    }

    //Inherited class (1st level inheritance)
    public class DSLR : Device
    {
        private string DeviceCode = "76567556757656";
        public void GetBlueToothConnection()
        {
            Console.WriteLine("Bluetooth connected");
        }

        //New implementation for this method which was available in Mobile Class
        //This is runtime polymorphism
        public override bool SendPicture()
        {
            Console.WriteLine("Picture Sent from DSLR");
            return true;
        }

        public override void GetDeviceICode()
        {
            Console.WriteLine("DSLR DeviceCode:"+ DeviceCode);
        }
       
        public void CameraClick()
        {
            Console.WriteLine("Camera Click from My DSLR");
        }

    }

    public class Canon : DSLR
    {
        public void HDRecording()
        {
            Console.WriteLine("Full HD recording supported");
        }
    }

}
