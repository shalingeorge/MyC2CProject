using System;
using Xunit;
using MyC2CProject;


namespace C2CTestProject
{
    public class UnitTestC2CProject
    {
        [Fact]
        public void TestM2CCameraId()
        {
            IComm cameraObj = new Camera();

            bool messageflag = cameraObj.SendPicture();

            Assert.True(messageflag);

        }

        [Fact]
        public void TestM2CSendMessage()
        {
            DSLR dslrobj = new DSLR();

            bool messageflag = dslrobj.SendPicture();

            Assert.True(messageflag);

        }

        [Fact]
        public void TestM2CCamera()
        {
            IComm _CameraCommChannel = new Camera();

            bool cameraflag = _CameraCommChannel.CameraClick("panorama"); ;

            Assert.True(cameraflag);

        }

        
    }
}




