using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.StartUp
{
    public  class CreateFolder
    {
        public void InitializeFolders()
        {
            // Lấy đường dẫn thư mục bin của dự án GUI
            string binFolderPath = AppDomain.CurrentDomain.BaseDirectory;

            string dataFolderPath = Path.Combine(binFolderPath, "Data");

            string contactUserFolderPath = Path.Combine(dataFolderPath, "Contactuser");

            string messagesFolderPath = Path.Combine(dataFolderPath, "Messages");

            string imagesDirectory = Path.Combine(dataFolderPath, "Messages", "Images");

            string iconsDirectory = Path.Combine(dataFolderPath, "Messages", "Icons");

            string videosDirectory = Path.Combine(dataFolderPath, "Messages", "Videos");

            //Tạo file khi khởi động ứng dụng
            if (!Directory.Exists(dataFolderPath))
            {
                Directory.CreateDirectory(dataFolderPath);
            }
            if (!Directory.Exists(contactUserFolderPath))
            {
                Directory.CreateDirectory(contactUserFolderPath);
            }
            if (!Directory.Exists(messagesFolderPath))
            {
                Directory.CreateDirectory(messagesFolderPath);
            }
            if (!Directory.Exists(imagesDirectory))
            {
                Directory.CreateDirectory(imagesDirectory);
            }
            if (!Directory.Exists(iconsDirectory))
            {
                Directory.CreateDirectory(iconsDirectory);
            }

            if (!Directory.Exists(videosDirectory))
            {
                Directory.CreateDirectory(videosDirectory);
            }

            Console.WriteLine("Folders created successfully.");
        }
    }
}
