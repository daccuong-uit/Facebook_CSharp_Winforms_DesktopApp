using BLL.Services;
using GUI.Messaging.Forms;
using GUI.NewsFeed.Forms;
using GUI.StartUp;
using GUI.UserManagement.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeFolders();

            //if (IsUserLoggedIn())
            //{
            //    Application.Run(new MainForm());
            //}
            //else
            //{
            //    Application.Run(new LoginForm());
            //}
            Application.Run(new LoginForm());
            //Application.Run(new LoginForm());
        }

        //static bool IsUserLoggedIn()
        //{
        //    string sessionId = SessionManager.GetSessionId(userId);
        //    var (isLoggedIn, userId) = SessionManager.IsUserLoggedIn(SessionManager.GetSessionId(sessionId));
        //    return isLoggedIn;
        //}

        static void InitializeFolders()
        {
            CreateFolder createFolder = new CreateFolder();
            createFolder.InitializeFolders();
        }
    }
}