using System;
using System.Collections.Generic;
using System.Text;

namespace MyC2CProject
{
    public interface IComm
    {
        int InternalMemory { get; }

      
        bool SendPicture();

        void CameraClick();
        bool CameraClick(string v);

         void ZoomIn();

        void ZoomOut();

        void GetDeviceICode();


    }
}
