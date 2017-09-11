using System;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using log4net;

namespace CaseManagerContacts
{
    static class Program
    {
        // Don't forge to add the following to the Assembly.cs 
        //[assembly: log4net.Config.XmlConfigurator(Watch = true)]  this will load the config from the
        //application configuration file.
        private static readonly ILog mobjLog = LogManager.GetLogger(typeof(Program));
        public static string gstrBaseDir = null;
        //Terrence Knoesen Tracing options
        public static TraceSwitch trcswApplication = null;


        private static OdbcConnection mobjOdbcConnection = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string strMess = null;
            mobjLog.Debug("Enter");

            //Setup the Tracing for this application
            gstrBaseDir = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            
            SetupApplicationLog4Net();
            //SetupApplicationTracing();
            //SetupApplicationLog4Net();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            mobjLog.Debug("Exit");

        }

        /// <summary>
        /// This wills set up all the tracing for the application.
        /// </summary>
        public static void SetupApplicationTracing() {
            MethodBase method = MethodBase.GetCurrentMethod();
            string methodName = method.Name;
            string className = method.ReflectedType.Name;
            string fullMethodName = className + "." + methodName;

            trcswApplication = new TraceSwitch("Application", "Tracing for the entire application");
            
            TextWriterTraceListener trclsnrFile = null;
            //No need to add another console listner as there is already one there.
            
            //Get the path of the assembly.
            
            string strTraceFileName = Path.Combine(gstrBaseDir, "ApplicationDebug.log");
            trclsnrFile = new TextWriterTraceListener(strTraceFileName);
            Trace.Listeners.Add(trclsnrFile);
            //If the AutoFlush is not used the there is no output to the file at all.
            Trace.AutoFlush = true;
            if (trcswApplication.TraceVerbose)
                Trace.WriteLine(fullMethodName + " - The output!");
        }

        public static void SetupApplicationLog4Net() {
            string strMess = null;
            mobjLog.Debug("Enter");
            // Don't forge to add the following to the Assembly.cs 
            //[assembly: log4net.Config.XmlConfigurator(Watch = true)]  this will load the config from the
            //application configuration file.
            //private static readonly ILog mobjLog = LogManager.GetLogger(typeof(Program));

            strMess = "This is a test message from the application IGNORE!!";
            mobjLog.Debug(strMess);

            mobjLog.Debug("Exit");
        }
            

        public static OdbcConnection GetDatabaseConnection()
        {

            string strMess = null;
            mobjLog.Debug("Enter");


            strMess = "Attempting to get the ODBC connection to the database.";
            mobjLog.Debug(strMess);

            OdbcConnectionStringBuilder objConBuilder = null;
            OdbcConnection objCon = null;
            objConBuilder = new OdbcConnectionStringBuilder();
            objConBuilder.Dsn = "CaseManagerConnection";
            try
            {
                objCon = new OdbcConnection();
                objCon.ConnectionString = objConBuilder.ConnectionString;
                objCon.Open();
                strMess = string.Format("ODBC Connection to database using DSN '{0}' established", objConBuilder.Dsn);
                mobjLog.Debug(strMess);
                if (objCon.State == ConnectionState.Open) {
                    mobjOdbcConnection = objCon;
                }
                else
                {
                    /*Terrence Knoesen
                     * Check to see if the database is open if not then through an error
                     * */
                    if (objCon.State == ConnectionState.Closed)
                    {
                        strMess = String.Format("Couldn't open the database using DSN '{0}' please check that it exists!", objConBuilder.Dsn);
                        throw new ApplicationException(strMess);
                    }
                }

            }
            catch (Exception ex)
            {
                strMess = String.Format("Couldn't open the database using DSN '{0}' please check that it exists!", objConBuilder.Dsn);
                mobjLog.Debug(strMess, ex);
                throw new ApplicationException(strMess, ex);
            }
            finally
            {
                objConBuilder = null;
                objCon = null;
            }


            mobjLog.Debug("Exit");


            return mobjOdbcConnection;
        }
    }



}
