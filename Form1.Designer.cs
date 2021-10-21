
namespace Lopushok
{
    partial class ListPrd
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdd = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductTypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionPersonCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionWorkshopNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minCostForAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.ProductTypeID,
            this.articleNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.productionPersonCountDataGridViewTextBoxColumn,
            this.productionWorkshopNumberDataGridViewTextBoxColumn,
            this.minCostForAgentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 128);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(962, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(32, 493);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(87, 51);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdd
            // 
            this.butEdd.Location = new System.Drawing.Point(491, 493);
            this.butEdd.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.butEdd.Name = "butEdd";
            this.butEdd.Size = new System.Drawing.Size(87, 51);
            this.butEdd.TabIndex = 1;
            this.butEdd.Text = "Изменить";
            this.butEdd.UseVisualStyleBackColor = true;
            this.butEdd.Click += new System.EventHandler(this.butEdd_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(907, 493);
            this.butDel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(87, 51);
            this.butDel.TabIndex = 1;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1024, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фильтрация";
            // 
            // ProductTypeID
            // 
            this.ProductTypeID.DataPropertyName = "ProductTypeID";
            this.ProductTypeID.DataSource = this.productTypeBindingSource;
            this.ProductTypeID.DisplayMember = "Title";
            this.ProductTypeID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ProductTypeID.HeaderText = "ProductTypeID";
            this.ProductTypeID.Name = "ProductTypeID";
            this.ProductTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductTypeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductTypeID.ValueMember = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(850, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 35);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 14F);
            this.label3.Location = new System.Drawing.Point(780, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поиск";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lopushok.Properties.Resources.Закрыть;
            this.pictureBox2.Location = new System.Drawing.Point(1182, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 21;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(Lopushok.ProductType);
            // 
            // articleNumberDataGridViewTextBoxColumn
            // 
            this.articleNumberDataGridViewTextBoxColumn.DataPropertyName = "ArticleNumber";
            this.articleNumberDataGridViewTextBoxColumn.HeaderText = "ArticleNumber";
            this.articleNumberDataGridViewTextBoxColumn.Name = "articleNumberDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // productionPersonCountDataGridViewTextBoxColumn
            // 
            this.productionPersonCountDataGridViewTextBoxColumn.DataPropertyName = "ProductionPersonCount";
            this.productionPersonCountDataGridViewTextBoxColumn.HeaderText = "ProductionPersonCount";
            this.productionPersonCountDataGridViewTextBoxColumn.Name = "productionPersonCountDataGridViewTextBoxColumn";
            // 
            // productionWorkshopNumberDataGridViewTextBoxColumn
            // 
            this.productionWorkshopNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductionWorkshopNumber";
            this.productionWorkshopNumberDataGridViewTextBoxColumn.HeaderText = "ProductionWorkshopNumber";
            this.productionWorkshopNumberDataGridViewTextBoxColumn.Name = "productionWorkshopNumberDataGridViewTextBoxColumn";
            // 
            // minCostForAgentDataGridViewTextBoxColumn
            // 
            this.minCostForAgentDataGridViewTextBoxColumn.DataPropertyName = "MinCostForAgent";
            this.minCostForAgentDataGridViewTextBoxColumn.HeaderText = "MinCostForAgent";
            this.minCostForAgentDataGridViewTextBoxColumn.Name = "minCostForAgentDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lopushok.Product);
            // 
            // ListPrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 560);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butEdd);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "ListPrd";
            this.Text = "Список продукции";
            this.Load += new System.EventHandler(this.ListPrd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butEdd;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionPersonCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionWorkshopNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minCostForAgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

