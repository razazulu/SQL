using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SQLite_form
{
    public partial class MainForm : Form
    {
        private SQLiteConnection m_dbConnection;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Connect to SQLite
            //Connect();

            listBoxDBTables.DataSource = null;
            listBoxDBTables.DataSource = dataSetTest1.Tables["CITY"];
            listBoxDBTables.DisplayMember = "name";
       }

        private void Connect()
        {
            if (!File.Exists("TestDatabase.sqlite")) SQLiteConnection.CreateFile("TestDatabase.sqlite");
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
