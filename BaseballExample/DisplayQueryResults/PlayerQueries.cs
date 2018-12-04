using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayQueryResults
{
    public partial class PlayerQueries : Form
    {

        private BaseballExample.BaseballEntitiesModel dbcontext = new BaseballExample.BaseballEntitiesModel();
        
        public PlayerQueries()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseballDataSet);

        }

        private void PlayerQueries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseballDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.baseballDataSet.Players);
            // Selects all players from the players table
            //queriesComboBox.SelectedIndex = 0;
        }

        // loads data based on user-selected query
        private void queriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the data displayed according to what is selected
            switch (queriesComboBox.SelectedIndex)
            {
                case 0: // all players
                    // use LINQ to order the players by LastName
                    break;
                case 1: // players with batting average of 0.300 or more
                    playersBindingSource.DataSource =
                        dbcontext.Players.Local
                            .Select(player => player)
                            .OrderBy(player => player.LastName);
                    // use LINQ to get players with batting average of 0.300 or more
                    // sort them by LastName
                    break;
                case 2: // players who have last name of "Allard"
                        // use LINQ to get players with last name of "Allard"
                        // sort them by FirstName

                    break;
                default:

                    break;
            }

            playersBindingSource.MoveFirst();
        }

    }
}
