namespace BaiTH4
{
    internal static class Program
    {
        public static DataHelper Db;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (TestConnection())
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new frm_cấu_hình());
            }

        }
        private static bool TestConnection()
        {
            try
            {
                string quyen, sv, db, un, pw;
                string configFile = "config.ini";

                if (!File.Exists(configFile))
                {
                    File.Create(configFile).Close();
                }

                DataHelper.ReadConfig(configFile,
                    out quyen, out sv, out db, out un, out pw);

                if (string.IsNullOrWhiteSpace(sv) ||
                    string.IsNullOrWhiteSpace(db))
                    return false;

                if (quyen == "WD")
                    Db = new DataHelper(sv, db);
                else
                    Db = new DataHelper(sv, db, un, pw);

                Db.Open();
                Db.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
    
