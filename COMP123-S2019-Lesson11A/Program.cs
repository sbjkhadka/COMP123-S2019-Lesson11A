using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson11A
{
   public static class Program
    {
        public static MainForm mainForm;
        public static SplashForm splashForm;
        public static AboutForm aboutForm;
        public static Student student;
        public static StudentInfo studentInfo;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashForm = new SplashForm();
            mainForm = new MainForm();
            aboutForm = new AboutForm();
            student = new Student();
            studentInfo = new StudentInfo();
            Application.Run(splashForm);
        }
    }
}
