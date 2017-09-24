using System.Windows.Forms;
using System.Data.Odbc;
using log4net;

namespace CaseManagerContacts
{
    public partial class frmMain : Form
    {
        private static readonly ILog mobjLog = LogManager.GetLogger(typeof(frmMain));
        public frmMain()
        {

            string strMess = null;
            mobjLog.Debug("Enter");

            InitializeComponent();

            mobjLog.Debug("Exit");

        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {

            string strMess = null;
            mobjLog.Debug("Enter");

            OdbcConnection objCon = null;

            try
            {
                objCon = Program.GetDatabaseConnection();
            }   
            catch (System.Exception ex)
            {
                strMess = "Could not establish connection to the database!";
                mobjLog.Fatal(strMess, ex);
                throw;
            }
            {
                strMess = "There is no open ODBC conenction to the datbase";
                mobjLog.Debug(strMess);
                MessageBox.Show(this, strMess,"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            strMess = "Set initial screen for the contacts.";
            mobjLog.Debug(strMess);
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPreferredName.Text = "";
            buttonNewContact.Enabled = true;
            buttonDeleteContact.Enabled = false;
            buttonSaveContact.Enabled = false;
            //Set up the mask for the UTC Offset textbox
            maskedTextBoxUtcOffset.Mask = "0#";


            strMess = "Load Contacts Listview";
            mobjLog.Debug(strMess);
            LoadListViewContacts();


            mobjLog.Debug("Exit");

        }

        private void LoadListViewContacts() {
            string strMess = null;
            mobjLog.Debug("Enter");
            string strSQL = "SELECT * FROM casemanager.tblcontact";
            OdbcCommand cmd = new OdbcCommand(strSQL);
            OdbcConnection objCon = Program.GetDatabaseConnection();
            if (objCon.State != System.Data.ConnectionState.Open)
            {
                strMess = "Unable to connect to database!";
                mobjLog.Warn(strMess);
                MessageBox.Show(this, strMess, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            strMess = "Set up the ODBC command to query the database.";
            mobjLog.Debug(strMess);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = objCon;
            OdbcDataReader objRdr = null;
            try
            {

                strMess = "Attempting to read the Contacts table from the database.";
                mobjLog.Debug(strMess);
                objRdr = cmd.ExecuteReader();
                strMess = "Successfully read data from the database.";
                mobjLog.Debug(strMess);
            }
            catch (System.Exception ex)
            {
                strMess = "FAILED read data from the database.";
                mobjLog.Error(strMess, ex);
                return;
            }
            //Terrence Knoesen Now add the information to the listview.
            listViewContactList.Clear();
            /**Terrence Knoesen
             * Change the view to Details and add a first and last name
             * column
            **/
            listViewContactList.View = View.Details;
            listViewContactList.Columns.Add("FirstName", 100);
            listViewContactList.Columns.Add("LastName", 100);


            while (objRdr.Read())
            {

                strMess = string.Format("Contact FirstName:='{0}'  LastName:='{1}'", objRdr["FirstName"], objRdr["LastName"]);
                string strBuff = objRdr["FirstName"].ToString();
                strBuff += " ";
                strBuff += objRdr["LastName"].ToString();
                mobjLog.Debug(strMess);
                ListViewItem lvi = new ListViewItem(objRdr["FirstName"].ToString());
                lvi.SubItems.Add(objRdr["LastName"].ToString());

                //listViewContactList.Items.Add(strBuff);
                listViewContactList.Items.Add(lvi);
                lvi = null;
            }
            objRdr.Close();


            mobjLog.Debug("Exit");

        }

        private void CreateNewContact() {
            string strMess = null;
            mobjLog.Debug("Enter");
            //Clear the contact entry fields.

            strMess = "Set up the screen for new contact creation";
            mobjLog.Debug(strMess);

            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPreferredName.Text = "";
            buttonNewContact.Enabled = false;
            buttonDeleteContact.Enabled = false;
            buttonSaveContact.Enabled = true;
            textBoxFirstName.Focus();

            strMess = "Screen ready for new contact!";
            mobjLog.Debug(strMess);




            mobjLog.Debug("Exit");
        }


        private void SaveContact() {
            string strMess = null;
            mobjLog.Debug("Enter");
            //Check that there is a first name
            if (string.IsNullOrEmpty(textBoxFirstName.Text.Trim()))
            {
                strMess = "The contact's FirstName is blank!";
                mobjLog.Warn(strMess);
                strMess += "\nPlease enter a FirstName.";
                MessageBox.Show(this, strMess, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxFirstName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxLastName.Text.Trim()))
            {
                strMess = "The contact's LastName is blank!";
                mobjLog.Warn(strMess);
                strMess += "\nPlease enter a LastName.";
                MessageBox.Show(this, strMess, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxFirstName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxPreferredName.Text.Trim()) & !string.IsNullOrEmpty(textBoxFirstName.Text.Trim()))
            {

                strMess = "There is no PreferredName for this contact using the FirstName.";
                mobjLog.Warn(strMess);
                textBoxPreferredName.Text = textBoxFirstName.Text.Trim();
            }

            OdbcCommand objcmd = new OdbcCommand();
            string strSQL = "INSERT INTO tblContact (FirstName, LastName, PreferredName, OffsetUTC)";
            //strSQL += " VALUES(FirstName, LastName, PreferredName, OffsetUTC)";
            strSQL += " VALUES(?, ?, ?, ?)";
            objcmd.CommandText = strSQL;

            try
            {
                objcmd.Connection = Program.GetDatabaseConnection();
            }
            catch (System.Exception ex)
            {

                throw;
            }

            OdbcParameter param = new OdbcParameter();
            param.DbType = System.Data.DbType.String;
            param.Value = textBoxFirstName.Text.Trim();
            objcmd.Parameters.Add(param);

            param = new OdbcParameter();
            param.DbType = System.Data.DbType.String;
            param.Value = textBoxLastName.Text.Trim();
            objcmd.Parameters.Add(param);

            param = new OdbcParameter();
            param.DbType = System.Data.DbType.String;
            param.Value = textBoxPreferredName.Text.Trim();
            objcmd.Parameters.Add(param);

            param = new OdbcParameter();
            param.DbType = System.Data.DbType.Int16;
            param.Value = 99;
            objcmd.Parameters.Add(param);

            try
            {
                objcmd.ExecuteNonQuery();

                strMess = string.Format("Saved '{0} {1}' to database.", objcmd.Parameters[0].Value, objcmd.Parameters[1].Value);
                mobjLog.Info(strMess);
            }
            catch (System.Exception ex)
            {
                strMess = "Failed to save Contact into database!";
                mobjLog.Error(strMess,ex);
            }

            /**Terrence Knoesen 
             * Attempt to reload the Listview with the new information
             * That is the new contact
            **/
            LoadListViewContacts();

            mobjLog.Debug("Exit");

        }

        private void LoadContacts()
        {

        }



        private void buttonNewContact_Click(object sender, System.EventArgs e)
        {
            string strMess = null;
            mobjLog.Debug("Enter");


            CreateNewContact();

            mobjLog.Debug("Exit");
        }

        private void buttonSaveContact_Click(object sender, System.EventArgs e)
        {

            string strMess = null;
            mobjLog.Debug("Enter");

            SaveContact();

            mobjLog.Debug("Exit");
        }
    }
}
