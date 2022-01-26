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

namespace SatRatCalc.Windows
{
    public partial class CreateComponentForm : Form
    {
        private List<SatComponent> lComponents = new List<SatComponent>();

        public CreateComponentForm()
        {
            InitializeComponent();
        }

        public CreateComponentForm(ref List<SatComponent> _components)
        {
            InitializeComponent();

            lComponents = _components;
        }

        private void CreateComponentForm_Load(object sender, EventArgs e)
        {
            cmbobxAssemblyBuildings.Items.Add("Constructor");
            cmbobxAssemblyBuildings.Items.Add("Assembler");
            cmbobxAssemblyBuildings.Items.Add("Manufacturer");
            cmbobxAssemblyBuildings.Items.Add("Smelter");

            cmbobxAssemblyBuildings.SelectedIndex = 0;

            //Set up the drop downs for the inputs - this could all be done in the designer, but I like seeing it programmatically
            //I also initially had this as a datasource/dataview, but maaaaan that was convoluted when I could just add some items.
            foreach (SatComponent sc in lComponents)
            {
                cmbobxInputName1.Items.Add(sc.strName);
                cmbobxInputName2.Items.Add(sc.strName);
                cmbobxInputName3.Items.Add(sc.strName);
                cmbobxInputName4.Items.Add(sc.strName);
            }

            //Set the initial selections while not crashing if they don't exist.
            if (cmbobxInputName1.Items.Count > 0)
                cmbobxInputName1.SelectedIndex = 0;

            if (cmbobxInputName2.Items.Count > 0)
                cmbobxInputName2.SelectedIndex = 0;

            if (cmbobxInputName3.Items.Count > 0)
                cmbobxInputName3.SelectedIndex = 0;

            if (cmbobxInputName4.Items.Count > 0)
                cmbobxInputName4.SelectedIndex = 0;

        }

        public void UpdateEnabledLabels()
        {
            //Only caring about this nonsense if we aren't dealing with a raw resource
            if (chkbxRaw.Checked == false)
            {
                switch (cmbobxAssemblyBuildings.SelectedItem.ToString())
                {
                    case "Constructor":
                        cmbobxInputName1.Enabled = true;
                        txtbxInputNeeded1.Enabled = true;

                        cmbobxInputName2.Enabled = false;
                        txtbxInputNeeded2.Enabled = false;
                        cmbobxInputName3.Enabled = false;
                        txtbxInputNeeded3.Enabled = false;
                        cmbobxInputName4.Enabled = false;
                        txtbxInputNeeded4.Enabled = false;
                        break;
                    case "Assembler":
                        cmbobxInputName1.Enabled = true;
                        txtbxInputNeeded1.Enabled = true;
                        cmbobxInputName2.Enabled = true;
                        txtbxInputNeeded2.Enabled = true;

                        cmbobxInputName3.Enabled = false;
                        txtbxInputNeeded3.Enabled = false;
                        cmbobxInputName4.Enabled = false;
                        txtbxInputNeeded4.Enabled = false;
                        break;
                    case "Manufacturer":
                        cmbobxInputName1.Enabled = true;
                        txtbxInputNeeded1.Enabled = true;
                        cmbobxInputName2.Enabled = true;
                        txtbxInputNeeded2.Enabled = true;
                        cmbobxInputName3.Enabled = true;
                        txtbxInputNeeded3.Enabled = true;
                        cmbobxInputName4.Enabled = true;
                        txtbxInputNeeded4.Enabled = true;
                        break;
                    case "Smelter":
                        goto case "Constructor";
                    default:
                        break;
                }
            }
        }

        private void cmbobxAssemblyBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEnabledLabels();
        }

        //Enabling/disabling things based on if my checkbox has changed.
        private void chkbxRaw_CheckedChanged(object sender, EventArgs e)
        {
            bool bChecked = chkbxRaw.Checked;

            if (bChecked)
            {
                cmbobxInputName1.Enabled = false;
                txtbxInputNeeded1.Enabled = false;
                cmbobxInputName2.Enabled = false;
                txtbxInputNeeded2.Enabled = false;
                cmbobxInputName3.Enabled = false;
                txtbxInputNeeded3.Enabled = false;
                cmbobxInputName4.Enabled = false;
                txtbxInputNeeded4.Enabled = false;
            }
            else
            {
                UpdateEnabledLabels();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                bool bRaw = chkbxRaw.Checked;
                List<Flow> compInputs = new List<Flow>();

                if (!bRaw)
                {
                    //Add any input data to the new component
                    switch (cmbobxAssemblyBuildings.SelectedIndex)
                    {
                        case 3:
                            //Smelter - Single input, just go use the constructor case
                            goto case 0;
                        case 2:
                            //Manufacturer
                            compInputs.Add(new Flow(cmbobxInputName3.Text, int.Parse(txtbxInputNeeded3.Text)));
                            compInputs.Add(new Flow(cmbobxInputName4.Text, int.Parse(txtbxInputNeeded4.Text)));
                            goto case 1;
                        case 1:
                            //Assembler
                            compInputs.Add(new Flow(cmbobxInputName2.Text, int.Parse(txtbxInputNeeded2.Text)));
                            goto case 0;
                        case 0:
                            //Constructor
                            compInputs.Add(new Flow(cmbobxInputName1.Text, int.Parse(txtbxInputNeeded1.Text)));
                            break;
                        default:
                            break;
                    }
                }

                SatComponent objComp = new SatComponent(txtbxName.Text, cmbobxAssemblyBuildings.SelectedItem.ToString(), int.Parse(txtbxOutputAmount.Text), int.Parse(txtbxAssemblyTime.Text), bRaw, compInputs);
                lComponents.Add(objComp);

                SaveComponent(objComp);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentNullException _e)
            {
                Console.WriteLine("Please fill out all fields.");
            }
            catch (FormatException _e)
            {
                Console.WriteLine("Please enter a numeric value.");
            }
        }

        //Get 'em outta' here!
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Save off our newly created component
        private void SaveComponent(SatComponent _comp)
        {
            using (StreamWriter sw = File.AppendText("Components.txt"))
            {
                sw.WriteLine("COMPONENT");
                sw.WriteLine(_comp.bRaw.ToString());
                sw.WriteLine(_comp.strName);
                sw.WriteLine(_comp.strBuilding);
                sw.WriteLine(_comp.nAmount);
                sw.WriteLine(_comp.nAssemblyTime);

                foreach (Flow inputComp in _comp.lInputs)
                {
                    sw.WriteLine("INPUT");
                    sw.WriteLine(inputComp.strName);
                    sw.WriteLine(inputComp.nAmount);
                }
            }
        }
    }
}
