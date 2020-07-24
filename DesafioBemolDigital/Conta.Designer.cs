namespace DesafioBemolDigital
{
    partial class CriarConta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarConta));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label lOGRADOUROLabel;
            System.Windows.Forms.Label bAIRROLabel;
            System.Windows.Forms.Label cIDADELabel;
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label iBGELabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btLipCampos = new System.Windows.Forms.Button();
            this.btCONSULTAR = new System.Windows.Forms.Button();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtLOGRADOURO = new System.Windows.Forms.TextBox();
            this.txtBAIRRO = new System.Windows.Forms.TextBox();
            this.txtCIDADE = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtIBGE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_ClienteDataSet = new DesafioBemolDigital.BD_ClienteDataSet();
            this.tableTableAdapter = new DesafioBemolDigital.BD_ClienteDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new DesafioBemolDigital.BD_ClienteDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            lOGRADOUROLabel = new System.Windows.Forms.Label();
            bAIRROLabel = new System.Windows.Forms.Label();
            cIDADELabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            iBGELabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ClienteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(nOMELabel);
            this.panel1.Controls.Add(this.txtNOME);
            this.panel1.Controls.Add(lOGRADOUROLabel);
            this.panel1.Controls.Add(this.txtLOGRADOURO);
            this.panel1.Controls.Add(bAIRROLabel);
            this.panel1.Controls.Add(this.txtBAIRRO);
            this.panel1.Controls.Add(cIDADELabel);
            this.panel1.Controls.Add(this.txtCIDADE);
            this.panel1.Controls.Add(uFLabel);
            this.panel1.Controls.Add(this.txtUF);
            this.panel1.Controls.Add(iBGELabel);
            this.panel1.Controls.Add(this.txtIBGE);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.btLipCampos);
            this.panel1.Controls.Add(this.btCONSULTAR);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mskCEP);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 252);
            this.panel1.TabIndex = 0;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(490, 201);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 18;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLipCampos
            // 
            this.btLipCampos.Location = new System.Drawing.Point(374, 201);
            this.btLipCampos.Name = "btLipCampos";
            this.btLipCampos.Size = new System.Drawing.Size(92, 23);
            this.btLipCampos.TabIndex = 17;
            this.btLipCampos.Text = "Limpar Campos";
            this.btLipCampos.UseVisualStyleBackColor = true;
            this.btLipCampos.Click += new System.EventHandler(this.btLipCampos_Click);
            // 
            // btCONSULTAR
            // 
            this.btCONSULTAR.Location = new System.Drawing.Point(169, 39);
            this.btCONSULTAR.Name = "btCONSULTAR";
            this.btCONSULTAR.Size = new System.Drawing.Size(82, 23);
            this.btCONSULTAR.TabIndex = 6;
            this.btCONSULTAR.Text = "CONSULTAR";
            this.btCONSULTAR.UseVisualStyleBackColor = true;
            this.btCONSULTAR.Click += new System.EventHandler(this.btCONSULTAR_Click);
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(612, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(61, 22);
            this.tableBindingNavigatorSaveItem.Text = "Salvar ";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(424, 17);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(446, 14);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(61, 20);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.TabStop = false;
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(56, 17);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 0;
            nOMELabel.Text = "NOME:";
            // 
            // txtNOME
            // 
            this.txtNOME.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "NOME", true));
            this.txtNOME.Location = new System.Drawing.Point(102, 14);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(307, 20);
            this.txtNOME.TabIndex = 1;
            // 
            // lOGRADOUROLabel
            // 
            lOGRADOUROLabel.AutoSize = true;
            lOGRADOUROLabel.Location = new System.Drawing.Point(11, 71);
            lOGRADOUROLabel.Name = "lOGRADOUROLabel";
            lOGRADOUROLabel.Size = new System.Drawing.Size(87, 13);
            lOGRADOUROLabel.TabIndex = 7;
            lOGRADOUROLabel.Text = "LOGRADOURO:";
            // 
            // txtLOGRADOURO
            // 
            this.txtLOGRADOURO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "LOGRADOURO", true));
            this.txtLOGRADOURO.Location = new System.Drawing.Point(102, 68);
            this.txtLOGRADOURO.Name = "txtLOGRADOURO";
            this.txtLOGRADOURO.Size = new System.Drawing.Size(100, 20);
            this.txtLOGRADOURO.TabIndex = 8;
            // 
            // bAIRROLabel
            // 
            bAIRROLabel.AutoSize = true;
            bAIRROLabel.Location = new System.Drawing.Point(48, 97);
            bAIRROLabel.Name = "bAIRROLabel";
            bAIRROLabel.Size = new System.Drawing.Size(51, 13);
            bAIRROLabel.TabIndex = 9;
            bAIRROLabel.Text = "BAIRRO:";
            // 
            // txtBAIRRO
            // 
            this.txtBAIRRO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "BAIRRO", true));
            this.txtBAIRRO.Location = new System.Drawing.Point(102, 94);
            this.txtBAIRRO.Name = "txtBAIRRO";
            this.txtBAIRRO.Size = new System.Drawing.Size(100, 20);
            this.txtBAIRRO.TabIndex = 10;
            // 
            // cIDADELabel
            // 
            cIDADELabel.AutoSize = true;
            cIDADELabel.Location = new System.Drawing.Point(49, 123);
            cIDADELabel.Name = "cIDADELabel";
            cIDADELabel.Size = new System.Drawing.Size(50, 13);
            cIDADELabel.TabIndex = 11;
            cIDADELabel.Text = "CIDADE:";
            // 
            // txtCIDADE
            // 
            this.txtCIDADE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "CIDADE", true));
            this.txtCIDADE.Location = new System.Drawing.Point(102, 120);
            this.txtCIDADE.Name = "txtCIDADE";
            this.txtCIDADE.Size = new System.Drawing.Size(100, 20);
            this.txtCIDADE.TabIndex = 12;
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(75, 149);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(24, 13);
            uFLabel.TabIndex = 13;
            uFLabel.Text = "UF:";
            // 
            // txtUF
            // 
            this.txtUF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "UF", true));
            this.txtUF.Location = new System.Drawing.Point(102, 146);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(100, 20);
            this.txtUF.TabIndex = 14;
            // 
            // iBGELabel
            // 
            iBGELabel.AutoSize = true;
            iBGELabel.Location = new System.Drawing.Point(63, 174);
            iBGELabel.Name = "iBGELabel";
            iBGELabel.Size = new System.Drawing.Size(35, 13);
            iBGELabel.TabIndex = 15;
            iBGELabel.Text = "IBGE:";
            // 
            // txtIBGE
            // 
            this.txtIBGE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "IBGE", true));
            this.txtIBGE.Location = new System.Drawing.Point(102, 172);
            this.txtIBGE.Name = "txtIBGE";
            this.txtIBGE.Size = new System.Drawing.Size(100, 20);
            this.txtIBGE.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEP:";
            // 
            // mskCEP
            // 
            this.mskCEP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "CEP", true));
            this.mskCEP.Location = new System.Drawing.Point(102, 40);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(61, 20);
            this.mskCEP.TabIndex = 5;
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.bD_ClienteDataSet;
            // 
            // bD_ClienteDataSet
            // 
            this.bD_ClienteDataSet.DataSetName = "BD_ClienteDataSet";
            this.bD_ClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = DesafioBemolDigital.BD_ClienteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 283);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "CriarConta";
            this.Text = "Criar Conta";
            this.Load += new System.EventHandler(this.CriarConta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ClienteDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCONSULTAR;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btLipCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BD_ClienteDataSet bD_ClienteDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private BD_ClienteDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private BD_ClienteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtLOGRADOURO;
        private System.Windows.Forms.TextBox txtBAIRRO;
        private System.Windows.Forms.TextBox txtCIDADE;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtIBGE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCEP;
    }
}

