using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace iPhoto.Lib
{
    public class PropertyList
    {
        public void vlah()
        {
            string filename = @"C:\Source\PerigeeSolutions\iPhoto.Lib\AlbumData.xml";
            var stream = File.OpenRead(filename);

            var plist = PListNet.PList.Load(stream);


        }

    }
}
