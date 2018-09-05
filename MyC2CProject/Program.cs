using System;

namespace MyC2CProject
{
    class Program
    {
        public static void Main(string[] args)
        {

            IComm _CameraCommChannel =new Camera(); //reference object for Camera

            _CameraCommChannel.SendPicture();//Method without parameter
            _CameraCommChannel.CameraClick();//Overloaded method with mode as parameter 
            _CameraCommChannel.CameraClick("panorama");
            _CameraCommChannel.GetDeviceICode();
            bool message = _CameraCommChannel.SendPicture();




            DSLR dslrobj = new DSLR();   //Another device ,if someone need to use other than Camera
            dslrobj.ZoomIn();//Base class method call
            dslrobj.SendPicture();//Derive class method call
            dslrobj.CameraClick();//Derive class method call
            dslrobj.GetDeviceICode();

             Canon canonobj = new Canon();
            canonobj.HDRecording();//2nd level inheritance
          

            Console.ReadKey();
        }
    }
}
