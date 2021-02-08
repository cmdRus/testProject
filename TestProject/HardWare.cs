using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleService
{
    class HardWare
    {
        private DriveInfo[] allDrives;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void ReadData()
        {
            allDrives = null;
            try
            {
                allDrives = DriveInfo.GetDrives();
                logger.Info("Successfully read");
            }
            catch { logger.Error("Cant read devices"); }
            
        }

        public long GetFreeSize()
        {
            if (allDrives != null)
            {
                long size = allDrives[0].TotalFreeSpace / 1048576;

                string info = string.Format("Size of hardware {0} = {1} megabytes", allDrives[0].Name, size.ToString());
                logger.Info(info);
                
                return size;
            }
            else
            {
                logger.Error("Cant read devices");

                return 0;
            }
        }

        public string GetName()
        {
            if (allDrives != null)
            {
                return allDrives[0].Name;
            }
            else
            {
                logger.Error("Cant read devices");

                return "Cant read devices";
            }
        }
    }
    
}
