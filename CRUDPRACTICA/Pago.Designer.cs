namespace CapaPresentacion
{
    partial class Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pago));
            dataGridView1 = new DataGridView();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            txt_email = new TextBox();
            label2 = new Label();
            txt_telefono = new TextBox();
            lbl_telefono = new Label();
            lbl_metodo = new Label();
            txt_cedula = new TextBox();
            lbl_cedula = new Label();
            Btn_guardar = new Button();
            Btn_editar = new Button();
            Btn_eliminar = new Button();
            cmb_metodo = new ComboBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(274, 88);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(546, 348);
            dataGridView1.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = Color.Transparent;
            lbl_nombre.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre.ForeColor = SystemColors.ControlLightLight;
            lbl_nombre.Location = new Point(75, 588);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(69, 20);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(53, 617);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(114, 27);
            txt_nombre.TabIndex = 2;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(261, 617);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(114, 27);
            txt_email.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(288, 588);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "E-mail";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(469, 617);
            txt_telefono.Margin = new Padding(3, 4, 3, 4);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(114, 27);
            txt_telefono.TabIndex = 6;
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.BackColor = Color.Transparent;
            lbl_telefono.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefono.ForeColor = SystemColors.ControlLightLight;
            lbl_telefono.Location = new Point(483, 588);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(75, 20);
            lbl_telefono.TabIndex = 5;
            lbl_telefono.Text = "Teléfono";
            // 
            // lbl_metodo
            // 
            lbl_metodo.AutoSize = true;
            lbl_metodo.BackColor = Color.Transparent;
            lbl_metodo.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_metodo.ForeColor = SystemColors.ControlLightLight;
            lbl_metodo.Location = new Point(666, 588);
            lbl_metodo.Name = "lbl_metodo";
            lbl_metodo.Size = new Size(133, 20);
            lbl_metodo.TabIndex = 7;
            lbl_metodo.Text = "Método de pago";
            // 
            // txt_cedula
            // 
            txt_cedula.Location = new Point(862, 617);
            txt_cedula.Margin = new Padding(3, 4, 3, 4);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(114, 27);
            txt_cedula.TabIndex = 10;
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.BackColor = Color.Transparent;
            lbl_cedula.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cedula.ForeColor = SystemColors.ControlLightLight;
            lbl_cedula.Location = new Point(891, 588);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(61, 20);
            lbl_cedula.TabIndex = 9;
            lbl_cedula.Text = "Cédula";
            // 
            // Btn_guardar
            // 
            Btn_guardar.BackColor = SystemColors.InfoText;
            Btn_guardar.FlatAppearance.BorderSize = 0;
            Btn_guardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_guardar.FlatStyle = FlatStyle.Flat;
            Btn_guardar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_guardar.ForeColor = SystemColors.ControlLightLight;
            Btn_guardar.Location = new Point(302, 460);
            Btn_guardar.Margin = new Padding(3, 4, 3, 4);
            Btn_guardar.Name = "Btn_guardar";
            Btn_guardar.Size = new Size(86, 44);
            Btn_guardar.TabIndex = 11;
            Btn_guardar.Text = "Guardar";
            Btn_guardar.UseVisualStyleBackColor = false;
            Btn_guardar.Click += Btn_guardar_Click;
            // 
            // Btn_editar
            // 
            Btn_editar.BackColor = SystemColors.InfoText;
            Btn_editar.FlatAppearance.BorderSize = 0;
            Btn_editar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_editar.FlatStyle = FlatStyle.Flat;
            Btn_editar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_editar.ForeColor = SystemColors.ControlLightLight;
            Btn_editar.Location = new Point(497, 460);
            Btn_editar.Margin = new Padding(3, 4, 3, 4);
            Btn_editar.Name = "Btn_editar";
            Btn_editar.Size = new Size(86, 44);
            Btn_editar.TabIndex = 12;
            Btn_editar.Text = "Editar";
            Btn_editar.UseVisualStyleBackColor = false;
            Btn_editar.Click += Btn_editar_Click;
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.BackColor = SystemColors.InfoText;
            Btn_eliminar.FlatAppearance.BorderSize = 0;
            Btn_eliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Btn_eliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Btn_eliminar.FlatStyle = FlatStyle.Flat;
            Btn_eliminar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_eliminar.ForeColor = SystemColors.ControlLightLight;
            Btn_eliminar.Location = new Point(685, 460);
            Btn_eliminar.Margin = new Padding(3, 4, 3, 4);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(86, 44);
            Btn_eliminar.TabIndex = 13;
            Btn_eliminar.Text = "Eliminar";
            Btn_eliminar.UseVisualStyleBackColor = false;
            Btn_eliminar.Click += Btn_eliminar_Click;
            // 
            // cmb_metodo
            // 
            cmb_metodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_metodo.FormattingEnabled = true;
            cmb_metodo.Items.AddRange(new object[] { "Paypal", "Tarjeta", "Transferencia" });
            cmb_metodo.Location = new Point(657, 617);
            cmb_metodo.Margin = new Padding(3, 4, 3, 4);
            cmb_metodo.Name = "cmb_metodo";
            cmb_metodo.Size = new Size(138, 28);
            cmb_metodo.TabIndex = 14;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(969, 1);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 57);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Pago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1148, 753);
            Controls.Add(pictureBox5);
            Controls.Add(cmb_metodo);
            Controls.Add(Btn_eliminar);
            Controls.Add(Btn_editar);
            Controls.Add(Btn_guardar);
            Controls.Add(txt_cedula);
            Controls.Add(lbl_cedula);
            Controls.Add(lbl_metodo);
            Controls.Add(txt_telefono);
            Controls.Add(lbl_telefono);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_nombre);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago";
            Load += Pago_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_nombre;
        private TextBox txt_nombre;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_telefono;
        private Label lbl_telefono;
        private Label lbl_metodo;
        private TextBox txt_cedula;
        private Label lbl_cedula;
        private Button Btn_guardar;
        private Button Btn_editar;
        private Button Btn_eliminar;
        private ComboBox cmb_metodo;
        private PictureBox pictureBox5;
    }
}