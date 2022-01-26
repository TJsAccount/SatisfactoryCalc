
namespace SatRatCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateComponent = new System.Windows.Forms.Button();
            this.lblTargetComponent = new System.Windows.Forms.Label();
            this.cmbobxTargetComponent = new System.Windows.Forms.ComboBox();
            this.btnCalcBuildings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numTargetAmount = new System.Windows.Forms.NumericUpDown();
            this.lvResults = new System.Windows.Forms.ListView();
            this.grpbxInfo = new System.Windows.Forms.GroupBox();
            this.lblInfoBuilding = new System.Windows.Forms.Label();
            this.lblInfoOutputAmount = new System.Windows.Forms.Label();
            this.lblInfoAssemblyTime = new System.Windows.Forms.Label();
            this.lblInfoCreatedFrom = new System.Windows.Forms.Label();
            this.lblInfoBuildingDisplay = new System.Windows.Forms.Label();
            this.lblInfoTimeDisplay = new System.Windows.Forms.Label();
            this.lblInfoAmountDisplay = new System.Windows.Forms.Label();
            this.lstbxInfoInputDisplay = new System.Windows.Forms.ListBox();
            this.lblTotals = new System.Windows.Forms.Label();
            this.lblConstructors = new System.Windows.Forms.Label();
            this.lblAssemblers = new System.Windows.Forms.Label();
            this.lblManufacturers = new System.Windows.Forms.Label();
            this.lblSmelters = new System.Windows.Forms.Label();
            this.lblTotalsConst = new System.Windows.Forms.Label();
            this.lblTotalsAssemb = new System.Windows.Forms.Label();
            this.lblTotalsMan = new System.Windows.Forms.Label();
            this.lblTotalSmelt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetAmount)).BeginInit();
            this.grpbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateComponent
            // 
            this.btnCreateComponent.Location = new System.Drawing.Point(34, 106);
            this.btnCreateComponent.Name = "btnCreateComponent";
            this.btnCreateComponent.Size = new System.Drawing.Size(126, 35);
            this.btnCreateComponent.TabIndex = 0;
            this.btnCreateComponent.Text = "Create Component";
            this.btnCreateComponent.UseVisualStyleBackColor = true;
            this.btnCreateComponent.Click += new System.EventHandler(this.btnCreateComponent_Click);
            // 
            // lblTargetComponent
            // 
            this.lblTargetComponent.AutoSize = true;
            this.lblTargetComponent.Location = new System.Drawing.Point(31, 33);
            this.lblTargetComponent.Name = "lblTargetComponent";
            this.lblTargetComponent.Size = new System.Drawing.Size(131, 13);
            this.lblTargetComponent.TabIndex = 1;
            this.lblTargetComponent.Text = "Select Target Component:";
            // 
            // cmbobxTargetComponent
            // 
            this.cmbobxTargetComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbobxTargetComponent.FormattingEnabled = true;
            this.cmbobxTargetComponent.Location = new System.Drawing.Point(168, 25);
            this.cmbobxTargetComponent.Name = "cmbobxTargetComponent";
            this.cmbobxTargetComponent.Size = new System.Drawing.Size(121, 21);
            this.cmbobxTargetComponent.TabIndex = 2;
            this.cmbobxTargetComponent.SelectedIndexChanged += new System.EventHandler(this.cmbobxTargetComponent_SelectedIndexChanged);
            // 
            // btnCalcBuildings
            // 
            this.btnCalcBuildings.Location = new System.Drawing.Point(168, 106);
            this.btnCalcBuildings.Name = "btnCalcBuildings";
            this.btnCalcBuildings.Size = new System.Drawing.Size(126, 35);
            this.btnCalcBuildings.TabIndex = 3;
            this.btnCalcBuildings.Text = "Show me the money!";
            this.btnCalcBuildings.UseVisualStyleBackColor = true;
            this.btnCalcBuildings.Click += new System.EventHandler(this.btnCalcBuildings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target Amount per Minute:";
            // 
            // numTargetAmount
            // 
            this.numTargetAmount.Location = new System.Drawing.Point(168, 55);
            this.numTargetAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numTargetAmount.Name = "numTargetAmount";
            this.numTargetAmount.Size = new System.Drawing.Size(121, 20);
            this.numTargetAmount.TabIndex = 5;
            this.numTargetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTargetAmount.ValueChanged += new System.EventHandler(this.numTargetAmount_ValueChanged);
            // 
            // lvResults
            // 
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(322, 25);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(350, 312);
            this.lvResults.TabIndex = 6;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            // 
            // grpbxInfo
            // 
            this.grpbxInfo.Controls.Add(this.lstbxInfoInputDisplay);
            this.grpbxInfo.Controls.Add(this.lblInfoAmountDisplay);
            this.grpbxInfo.Controls.Add(this.lblInfoTimeDisplay);
            this.grpbxInfo.Controls.Add(this.lblInfoBuildingDisplay);
            this.grpbxInfo.Controls.Add(this.lblInfoCreatedFrom);
            this.grpbxInfo.Controls.Add(this.lblInfoAssemblyTime);
            this.grpbxInfo.Controls.Add(this.lblInfoOutputAmount);
            this.grpbxInfo.Controls.Add(this.lblInfoBuilding);
            this.grpbxInfo.Location = new System.Drawing.Point(34, 171);
            this.grpbxInfo.Name = "grpbxInfo";
            this.grpbxInfo.Size = new System.Drawing.Size(255, 166);
            this.grpbxInfo.TabIndex = 7;
            this.grpbxInfo.TabStop = false;
            this.grpbxInfo.Text = "Component Info";
            // 
            // lblInfoBuilding
            // 
            this.lblInfoBuilding.AutoSize = true;
            this.lblInfoBuilding.Location = new System.Drawing.Point(6, 32);
            this.lblInfoBuilding.Name = "lblInfoBuilding";
            this.lblInfoBuilding.Size = new System.Drawing.Size(94, 13);
            this.lblInfoBuilding.TabIndex = 8;
            this.lblInfoBuilding.Text = "Assembly Building:";
            // 
            // lblInfoOutputAmount
            // 
            this.lblInfoOutputAmount.AutoSize = true;
            this.lblInfoOutputAmount.Location = new System.Drawing.Point(6, 78);
            this.lblInfoOutputAmount.Name = "lblInfoOutputAmount";
            this.lblInfoOutputAmount.Size = new System.Drawing.Size(86, 13);
            this.lblInfoOutputAmount.TabIndex = 9;
            this.lblInfoOutputAmount.Text = "Amount Created:";
            // 
            // lblInfoAssemblyTime
            // 
            this.lblInfoAssemblyTime.AutoSize = true;
            this.lblInfoAssemblyTime.Location = new System.Drawing.Point(6, 54);
            this.lblInfoAssemblyTime.Name = "lblInfoAssemblyTime";
            this.lblInfoAssemblyTime.Size = new System.Drawing.Size(80, 13);
            this.lblInfoAssemblyTime.TabIndex = 9;
            this.lblInfoAssemblyTime.Text = "Assembly Time:";
            // 
            // lblInfoCreatedFrom
            // 
            this.lblInfoCreatedFrom.AutoSize = true;
            this.lblInfoCreatedFrom.Location = new System.Drawing.Point(6, 100);
            this.lblInfoCreatedFrom.Name = "lblInfoCreatedFrom";
            this.lblInfoCreatedFrom.Size = new System.Drawing.Size(73, 13);
            this.lblInfoCreatedFrom.TabIndex = 10;
            this.lblInfoCreatedFrom.Text = "Created From:";
            // 
            // lblInfoBuildingDisplay
            // 
            this.lblInfoBuildingDisplay.AutoSize = true;
            this.lblInfoBuildingDisplay.Location = new System.Drawing.Point(131, 32);
            this.lblInfoBuildingDisplay.Name = "lblInfoBuildingDisplay";
            this.lblInfoBuildingDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblInfoBuildingDisplay.TabIndex = 8;
            // 
            // lblInfoTimeDisplay
            // 
            this.lblInfoTimeDisplay.AutoSize = true;
            this.lblInfoTimeDisplay.Location = new System.Drawing.Point(131, 54);
            this.lblInfoTimeDisplay.Name = "lblInfoTimeDisplay";
            this.lblInfoTimeDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblInfoTimeDisplay.TabIndex = 11;
            // 
            // lblInfoAmountDisplay
            // 
            this.lblInfoAmountDisplay.AutoSize = true;
            this.lblInfoAmountDisplay.Location = new System.Drawing.Point(131, 78);
            this.lblInfoAmountDisplay.Name = "lblInfoAmountDisplay";
            this.lblInfoAmountDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblInfoAmountDisplay.TabIndex = 12;
            // 
            // lstbxInfoInputDisplay
            // 
            this.lstbxInfoInputDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstbxInfoInputDisplay.FormattingEnabled = true;
            this.lstbxInfoInputDisplay.Location = new System.Drawing.Point(129, 100);
            this.lstbxInfoInputDisplay.Name = "lstbxInfoInputDisplay";
            this.lstbxInfoInputDisplay.Size = new System.Drawing.Size(120, 56);
            this.lstbxInfoInputDisplay.TabIndex = 8;
            // 
            // lblTotals
            // 
            this.lblTotals.AutoSize = true;
            this.lblTotals.Location = new System.Drawing.Point(322, 344);
            this.lblTotals.Name = "lblTotals";
            this.lblTotals.Size = new System.Drawing.Size(39, 13);
            this.lblTotals.TabIndex = 8;
            this.lblTotals.Text = "Totals:";
            // 
            // lblConstructors
            // 
            this.lblConstructors.AutoSize = true;
            this.lblConstructors.Location = new System.Drawing.Point(367, 344);
            this.lblConstructors.Name = "lblConstructors";
            this.lblConstructors.Size = new System.Drawing.Size(66, 13);
            this.lblConstructors.TabIndex = 9;
            this.lblConstructors.Text = "Constructors";
            // 
            // lblAssemblers
            // 
            this.lblAssemblers.AutoSize = true;
            this.lblAssemblers.Location = new System.Drawing.Point(439, 344);
            this.lblAssemblers.Name = "lblAssemblers";
            this.lblAssemblers.Size = new System.Drawing.Size(60, 13);
            this.lblAssemblers.TabIndex = 10;
            this.lblAssemblers.Text = "Assemblers";
            // 
            // lblManufacturers
            // 
            this.lblManufacturers.AutoSize = true;
            this.lblManufacturers.Location = new System.Drawing.Point(505, 344);
            this.lblManufacturers.Name = "lblManufacturers";
            this.lblManufacturers.Size = new System.Drawing.Size(75, 13);
            this.lblManufacturers.TabIndex = 11;
            this.lblManufacturers.Text = "Manufacturers";
            // 
            // lblSmelters
            // 
            this.lblSmelters.AutoSize = true;
            this.lblSmelters.Location = new System.Drawing.Point(586, 344);
            this.lblSmelters.Name = "lblSmelters";
            this.lblSmelters.Size = new System.Drawing.Size(47, 13);
            this.lblSmelters.TabIndex = 12;
            this.lblSmelters.Text = "Smelters";
            // 
            // lblTotalsConst
            // 
            this.lblTotalsConst.AutoSize = true;
            this.lblTotalsConst.Location = new System.Drawing.Point(390, 357);
            this.lblTotalsConst.Name = "lblTotalsConst";
            this.lblTotalsConst.Size = new System.Drawing.Size(13, 13);
            this.lblTotalsConst.TabIndex = 13;
            this.lblTotalsConst.Text = "0";
            // 
            // lblTotalsAssemb
            // 
            this.lblTotalsAssemb.AutoSize = true;
            this.lblTotalsAssemb.Location = new System.Drawing.Point(459, 357);
            this.lblTotalsAssemb.Name = "lblTotalsAssemb";
            this.lblTotalsAssemb.Size = new System.Drawing.Size(13, 13);
            this.lblTotalsAssemb.TabIndex = 14;
            this.lblTotalsAssemb.Text = "0";
            // 
            // lblTotalsMan
            // 
            this.lblTotalsMan.AutoSize = true;
            this.lblTotalsMan.Location = new System.Drawing.Point(532, 357);
            this.lblTotalsMan.Name = "lblTotalsMan";
            this.lblTotalsMan.Size = new System.Drawing.Size(13, 13);
            this.lblTotalsMan.TabIndex = 15;
            this.lblTotalsMan.Text = "0";
            // 
            // lblTotalSmelt
            // 
            this.lblTotalSmelt.AutoSize = true;
            this.lblTotalSmelt.Location = new System.Drawing.Point(603, 357);
            this.lblTotalSmelt.Name = "lblTotalSmelt";
            this.lblTotalSmelt.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSmelt.TabIndex = 16;
            this.lblTotalSmelt.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 396);
            this.Controls.Add(this.lblTotalSmelt);
            this.Controls.Add(this.lblTotalsMan);
            this.Controls.Add(this.lblTotalsAssemb);
            this.Controls.Add(this.lblTotalsConst);
            this.Controls.Add(this.lblSmelters);
            this.Controls.Add(this.lblManufacturers);
            this.Controls.Add(this.lblAssemblers);
            this.Controls.Add(this.lblConstructors);
            this.Controls.Add(this.lblTotals);
            this.Controls.Add(this.grpbxInfo);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.numTargetAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcBuildings);
            this.Controls.Add(this.cmbobxTargetComponent);
            this.Controls.Add(this.lblTargetComponent);
            this.Controls.Add(this.btnCreateComponent);
            this.Name = "MainForm";
            this.Text = "Satisfactory Ratio Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numTargetAmount)).EndInit();
            this.grpbxInfo.ResumeLayout(false);
            this.grpbxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateComponent;
        private System.Windows.Forms.Label lblTargetComponent;
        private System.Windows.Forms.ComboBox cmbobxTargetComponent;
        private System.Windows.Forms.Button btnCalcBuildings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTargetAmount;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.GroupBox grpbxInfo;
        private System.Windows.Forms.ListBox lstbxInfoInputDisplay;
        private System.Windows.Forms.Label lblInfoAmountDisplay;
        private System.Windows.Forms.Label lblInfoTimeDisplay;
        private System.Windows.Forms.Label lblInfoBuildingDisplay;
        private System.Windows.Forms.Label lblInfoCreatedFrom;
        private System.Windows.Forms.Label lblInfoAssemblyTime;
        private System.Windows.Forms.Label lblInfoOutputAmount;
        private System.Windows.Forms.Label lblInfoBuilding;
        private System.Windows.Forms.Label lblTotals;
        private System.Windows.Forms.Label lblConstructors;
        private System.Windows.Forms.Label lblAssemblers;
        private System.Windows.Forms.Label lblManufacturers;
        private System.Windows.Forms.Label lblSmelters;
        private System.Windows.Forms.Label lblTotalsConst;
        private System.Windows.Forms.Label lblTotalsAssemb;
        private System.Windows.Forms.Label lblTotalsMan;
        private System.Windows.Forms.Label lblTotalSmelt;
    }
}

