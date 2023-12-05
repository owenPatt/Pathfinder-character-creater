using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmPathfinderCharacterViewer : Form
    {
        public frmPathfinderCharacterViewer()
        {
            InitializeComponent();

            //Set the form for default viewing
            enableViewer(true);
        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }

        //Form load
        private void frmPathfinderCharacterViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'charactersDataSet.tblCharacters' table. You can move, or remove it, as needed.
            this.tblCharactersTableAdapter.Fill(this.charactersDataSet.tblCharacters);

        }

        //Enables or disables the viewer
        private void enableViewer(bool enable)
        {
            tblCharactersDataGridView.Enabled = enable;
            btnCreate.Enabled = enable;
            btnExit.Enabled = enable;
            bxCharacterViewer.Enabled = !enable;

            //Needs to be enabled seperately
            btnDelete.Enabled = !enable;
        }

        //Double click on a character
        private void tblCharactersDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Tag = "Update";

            //disables the viewer
            enableViewer(false);

            //gets the character character information
            int level = Convert.ToInt32(tblCharactersDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string characterClass = tblCharactersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string firstName = tblCharactersDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            string lastName = tblCharactersDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            string backstory = tblCharactersDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

            //Gets the stats from the database
            string statString = tblCharactersDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            //stores into an array of the stats
            int[] stats;
            stats = convertStatStringToArray(statString);

            //sets the character information
            txtFirst.Text = firstName;
            txtLast.Text = lastName;
            numLevel.Value = level;
            txtClass.Text = characterClass;
            txtBoxBackstory.Text = backstory;

            //Sets the stats
            numStr.Value = stats[0];
            numDex.Value = stats[1];
            numCon.Value = stats[2];
            numIntel.Value = stats[3];
            numWis.Value = stats[4];
            numChar.Value = stats[5];

        }

        //Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Checks to make sure all fields are filled out
            if(txtFirst.Text == "" || txtLast.Text == "" || numLevel.Text == "" || txtClass.Text == "" || txtBoxBackstory.Text == "" || numStr.Text == "" || numDex.Text == "" || numCon.Text == "" || numIntel.Text == "" || numWis.Text == "" || numChar.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }

            //Check to make sure level is a number between 1 and 20
            int level = (int)numLevel.Value;
            if (level < 1 || level > 20)
            {
                //Shows error message
                MessageBox.Show("Please enter a valid level: between 1 and 20");
                return;
            }

            //Checks to make sure the stats are numbers between 1 and 20
            int str = checkStat((int)numStr.Value);
            int dex = checkStat((int)numDex.Value);
            int con = checkStat((int)numCon.Value);
            int intel = checkStat((int)numIntel.Value); 
            int wis = checkStat((int)numWis.Value);   
            int cha = checkStat((int)numChar.Value);
            if(str == -1 || dex == -1 || con == -1 || intel == -1 || wis == -1 || cha == -1)
            {
                //Shows error message
                MessageBox.Show("Please enter valid stats");
                return;
            }
            string stringStats = str + ";" + dex + ";" + con + ";" + intel + ";" + wis + ";" + cha;
            
            //Checks to see if the save button is for creating a new character
            if (btnSave.Tag.ToString() == "Create")
            {
                //Inserts the new character into the database and refreshes the table
                tblCharactersTableAdapter.InsertQuery(txtLast.Text, txtFirst.Text, level, txtBoxBackstory.Text, txtClass.Text, stringStats);
                this.tblCharactersTableAdapter.Fill(this.charactersDataSet.tblCharacters);

                //clear the viewer
                clearViewer();

                //Reenable the viewer
                enableViewer(true);
                return;
            }
            
            //Checks to see if the save button is for updating a character
            if(btnSave.Tag.ToString() == "Update")
            {
                //Updates the character in the database and refreshes the table
                tblCharactersTableAdapter.UpdateQuery(txtLast.Text, txtFirst.Text, level, txtBoxBackstory.Text, txtClass.Text, stringStats, Convert.ToInt32(tblCharactersDataGridView.Rows[tblCharactersDataGridView.CurrentCell.RowIndex].Cells[0].Value));
                this.tblCharactersTableAdapter.Fill(this.charactersDataSet.tblCharacters);
                
                //clear the viewer
                clearViewer();
                
                //Reenable the viewer
                enableViewer(true);
                return;
            }
        }

        //Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //clear the viewer and reenable it
            clearViewer();
            enableViewer(true);
        }

        private void clearViewer()
        {
            //clears the viewer
            txtLast.Text = "";
            txtFirst.Text = "";
            numLevel.Value = 0;
            txtClass.Text = "";
            txtBoxBackstory.Text = "";
            numStr.Value = 0;
            numDex.Value = 0;
            numCon.Value = 0;
            numIntel.Value = 0;
            numWis.Value = 0;
            numChar.Value = 0;
        }

        //Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Deletes the character from the database and refreshes the table
            tblCharactersTableAdapter.DeleteQuery(Convert.ToInt32(tblCharactersDataGridView.Rows[tblCharactersDataGridView.CurrentCell.RowIndex].Cells[0].Value));
            this.tblCharactersTableAdapter.Fill(this.charactersDataSet.tblCharacters);
            
            //clear the viewer and reenable it
            clearViewer();
            enableViewer(true);
        }
        
        //Create button
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //clear the viewer and disable it
            enableViewer(false);
            btnDelete.Enabled = false;

            //Sets the save button to create
            btnSave.Tag = "Create";
        }

        private int[] convertStatStringToArray(string statString)
        {
            string[] stats = statString.Split(';');
            //Converts the array into an int array
            int[] intStats = new int[stats.Length];
            for(int i = 0; i < stats.Length; i++)
            {
                intStats[i] = Convert.ToInt32(stats[i]);
            }

            return intStats;
        }

        private int checkStat(int stat) {             
            if (stat < 1 || stat > 20)
            {
                return -1;
            }
            return stat;
        }

        private void bxCharacterViewer_Enter(object sender, EventArgs e)
        {

        }
    }
}
