using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SMP;

namespace SMP.BL
{

    class Methods
    {
        public MemoryStream ms = new MemoryStream();
        public byte[] by;
        // convert to byte
        public byte[]convertByte()
        {
            return ms.ToArray();
        }
        // convert byte to image
        public MemoryStream convertImage()
        {
            ms = new MemoryStream(by);
            return ms;
        }


    }
}
