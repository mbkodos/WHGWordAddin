namespace WHGWordAddin
{
    partial class WHGRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WHGRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.whg = this.Factory.CreateRibbonTab();
            this.glossaryGroup = this.Factory.CreateRibbonGroup();
            this.glossaryBox = this.Factory.CreateRibbonComboBox();
            this.whgConnect = this.Factory.CreateRibbonButton();
            this.actionGroup = this.Factory.CreateRibbonGroup();
            this.getGlosButton = this.Factory.CreateRibbonButton();
            this.whg.SuspendLayout();
            this.glossaryGroup.SuspendLayout();
            this.actionGroup.SuspendLayout();
            // 
            // whg
            // 
            this.whg.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.whg.Groups.Add(this.glossaryGroup);
            this.whg.Groups.Add(this.actionGroup);
            this.whg.Label = "WHG";
            this.whg.Name = "whg";
            // 
            // glossaryGroup
            // 
            this.glossaryGroup.Items.Add(this.glossaryBox);
            this.glossaryGroup.Items.Add(this.whgConnect);
            this.glossaryGroup.Label = "glossary";
            this.glossaryGroup.Name = "glossaryGroup";
            // 
            // glossaryBox
            // 
            this.glossaryBox.Label = "Glossary";
            this.glossaryBox.Name = "glossaryBox";
            this.glossaryBox.Text = null;
            this.glossaryBox.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.comboBox1_TextChanged);
            // 
            // whgConnect
            // 
            this.whgConnect.Label = "Connect";
            this.whgConnect.Name = "whgConnect";
            this.whgConnect.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.connectionButton_Click);
            // 
            // actionGroup
            // 
            this.actionGroup.Items.Add(this.getGlosButton);
            this.actionGroup.Label = "Action";
            this.actionGroup.Name = "actionGroup";
            // 
            // getGlosButton
            // 
            this.getGlosButton.Label = "Get Glossary";
            this.getGlosButton.Name = "getGlosButton";
            this.getGlosButton.ShowImage = true;
            this.getGlosButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // WHGRibbon
            // 
            this.Name = "WHGRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.whg);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.WHGRibbon_Load);
            this.whg.ResumeLayout(false);
            this.whg.PerformLayout();
            this.glossaryGroup.ResumeLayout(false);
            this.glossaryGroup.PerformLayout();
            this.actionGroup.ResumeLayout(false);
            this.actionGroup.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab whg;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup glossaryGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox glossaryBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton whgConnect;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup actionGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton getGlosButton;
    }

    partial class ThisRibbonCollection
    {
        internal WHGRibbon WHGRibbon
        {
            get { return this.GetRibbon<WHGRibbon>(); }
        }
    }
}
