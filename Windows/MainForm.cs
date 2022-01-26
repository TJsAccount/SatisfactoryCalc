using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SatRatCalc.Windows;

namespace SatRatCalc
{
    public partial class MainForm : Form
    {
        private List<SatComponent> lComponents = new List<SatComponent>();
        private Dictionary<string, Label> dTotalTextFields = new Dictionary<string, Label>();

        public MainForm()
        {
            InitializeComponent();

            ReadComponents();

            //Set up the target component combo box
            if (lComponents.Count > 0)
            {
                foreach (SatComponent sc in lComponents)
                    cmbobxTargetComponent.Items.Add(sc.strName);

                cmbobxTargetComponent.SelectedIndex = 0;
            }
            else
                cmbobxTargetComponent.Enabled = false;

            //Format the results list view
            lvResults.View = View.Details;
            lvResults.GridLines = true;
            lvResults.Columns.Add("Component", 150, HorizontalAlignment.Right);
            lvResults.Columns.Add("Building", 100, HorizontalAlignment.Right);
            lvResults.Columns.Add("Amount", 100, HorizontalAlignment.Right);

            //Set up the totals
            dTotalTextFields["Constructor"] = lblTotalsConst;
            dTotalTextFields["Assembler"] = lblTotalsAssemb;
            dTotalTextFields["Manufacturer"] = lblTotalsMan;
            dTotalTextFields["Smelter"] = lblTotalSmelt;

        }

        private void btnCreateComponent_Click(object sender, EventArgs e)
        {
            CreateComponentForm frmCreateComponent = new CreateComponentForm(ref lComponents);
            DialogResult drReturn = frmCreateComponent.ShowDialog();

            if (drReturn == DialogResult.OK)
            {
                cmbobxTargetComponent.Items.Add(lComponents.Last().strName);

                if (lComponents.Count == 1)
                {
                    cmbobxTargetComponent.SelectedIndex = 0;
                    cmbobxTargetComponent.Enabled = true;
                }
            }

        }

        //And now to find out how many constructors I'll need to make some modular casings.....
        private void btnCalcBuildings_Click(object sender, EventArgs e)
        {
            if (numTargetAmount.Value < 1)
                MessageBox.Show("Enter a value above zero!");
            else
            {
                lvResults.Items.Clear();

                //Reset the totals
                dTotalTextFields["Constructor"].Text = "0";
                dTotalTextFields["Assembler"].Text = "0";
                dTotalTextFields["Manufacturer"].Text = "0";
                dTotalTextFields["Smelter"].Text = "0";

                string selectedItem = cmbobxTargetComponent.SelectedItem.ToString();
                StartCalculation(selectedItem, numTargetAmount.Value);
            }
        }

        private void StartCalculation(string _selectedItem, decimal _amount)
        {
            //Looking through our components
            foreach (SatComponent sc in lComponents)
            {
                if (sc.strName != _selectedItem)
                    continue;

                CalculateBuildings(sc, _amount);

                break;
            }

        }

        public void CalculateBuildings(SatComponent _satComp, decimal _amount)
        {
            //Alright.  Let's do this.

            //Variables could be saved, but I really wanted to have things a bit more readable here.
            string building = _satComp.strBuilding;
            int baseAmountPerMinute = (60 / _satComp.nAssemblyTime) * _satComp.nAmount;
            decimal numFactories = (_amount / baseAmountPerMinute);

            ListViewItem lvi = new ListViewItem(new[] { _satComp.strName, building, numFactories.ToString() });
            lvResults.Items.Add(lvi);

            //Update the totals
            dTotalTextFields[building].Text = (numFactories + decimal.Parse(dTotalTextFields[building].Text)).ToString();

            //We have input components we need to figure out baby!
            if (_satComp.lInputs.Count > 0)
            {
                foreach (Flow item in _satComp.lInputs)
                {
                    int itemsNeededPerMinute = (60 / _satComp.nAssemblyTime) * item.nAmount;
                    StartCalculation(item.strName,  itemsNeededPerMinute * numFactories);
                }
            }
        }

        private void cmbobxTargetComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateInfoBox();
        }

        public void PopulateInfoBox()
        {
            string selectedItem = cmbobxTargetComponent.SelectedItem.ToString();

            lstbxInfoInputDisplay.Items.Clear();

            //Search until we find a matching name
            foreach (SatComponent sc in lComponents)
            {
                if (sc.strName != selectedItem)
                    continue;

                lblInfoBuildingDisplay.Text = sc.strBuilding;
                lblInfoTimeDisplay.Text = sc.nAssemblyTime.ToString();
                lblInfoAmountDisplay.Text = sc.nAmount.ToString();

                //Add any input components to the info box
                for (int i = 0; i < sc.lInputs.Count; ++i)
                    lstbxInfoInputDisplay.Items.Add(sc.lInputs[i].strName + " x " + sc.lInputs[i].nAmount);

                break;
            }
        }

        private void ReadComponents()
        {
            //Load our saved components if we have any
            if (File.Exists("Components.txt"))
            {
                using (StreamReader sr = new StreamReader("Components.txt"))
                {
                    string readLine = sr.ReadLine();

                    while (readLine == "COMPONENT")
                    {
                        //It's possible to use the constructor to read in all of this on one line, but I'm going for readability here
                        SatComponent satComp = new SatComponent();

                        //First read will always be the word component, so let's just move on from that.
                        satComp.bRaw = bool.Parse(sr.ReadLine());
                        satComp.strName = sr.ReadLine();
                        satComp.strBuilding = sr.ReadLine();
                        satComp.nAmount = int.Parse(sr.ReadLine());
                        satComp.nAssemblyTime = int.Parse(sr.ReadLine());

                        //Grab the next thing to see if we have the next component, or we have to add some flows for the inputs
                        readLine = sr.ReadLine();

                        while (readLine == "INPUT")
                        {
                            Flow inFlow = new Flow();
                            inFlow.strName = sr.ReadLine();
                            inFlow.nAmount = int.Parse(sr.ReadLine());

                            readLine = sr.ReadLine();

                            satComp.lInputs.Add(inFlow);
                        }

                        lComponents.Add(satComp);
                    }

                    sr.Close();
                }
            }
        }

        private void numTargetAmount_ValueChanged(object sender, EventArgs e)
        {
            if (numTargetAmount.Value < 1)
                MessageBox.Show("Enter a value above zero!");
            else
            {
                lvResults.Items.Clear();

                //Reset the totals
                dTotalTextFields["Constructor"].Text = "0";
                dTotalTextFields["Assembler"].Text = "0";
                dTotalTextFields["Manufacturer"].Text = "0";
                dTotalTextFields["Smelter"].Text = "0";

                string selectedItem = cmbobxTargetComponent.SelectedItem.ToString();
                StartCalculation(selectedItem, numTargetAmount.Value);
            }
        }
    }
}
