namespace CelularesFinal2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvCelulares = new System.Windows.Forms.DataGridView();
            this.Mensaje = new System.Windows.Forms.Label();
            this.btCargarActualizacion = new System.Windows.Forms.Button();
            this.EliminarCelular = new System.Windows.Forms.Button();
            this.btCargarCelular = new System.Windows.Forms.Button();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtFecha_Egreso = new System.Windows.Forms.TextBox();
            this.txtFecha_Ingreso = new System.Windows.Forms.TextBox();
            this.txtCosto_Total = new System.Windows.Forms.TextBox();
            this.txtReparacion = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btActualizarT = new System.Windows.Forms.Button();
            this.dgvTecnicos = new System.Windows.Forms.DataGridView();
            this.btCargarTecnico = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCelulares)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DgvCelulares);
            this.tabPage1.Controls.Add(this.Mensaje);
            this.tabPage1.Controls.Add(this.btCargarActualizacion);
            this.tabPage1.Controls.Add(this.EliminarCelular);
            this.tabPage1.Controls.Add(this.btCargarCelular);
            this.tabPage1.Controls.Add(this.cbTecnico);
            this.tabPage1.Controls.Add(this.cbEstado);
            this.tabPage1.Controls.Add(this.txtFecha_Egreso);
            this.tabPage1.Controls.Add(this.txtFecha_Ingreso);
            this.tabPage1.Controls.Add(this.txtCosto_Total);
            this.tabPage1.Controls.Add(this.txtReparacion);
            this.tabPage1.Controls.Add(this.txtModelo);
            this.tabPage1.Controls.Add(this.txtMarca);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DgvCelulares
            // 
            this.DgvCelulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCelulares.Location = new System.Drawing.Point(20, 333);
            this.DgvCelulares.Name = "DgvCelulares";
            this.DgvCelulares.Size = new System.Drawing.Size(1026, 232);
            this.DgvCelulares.TabIndex = 0;
            this.DgvCelulares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCelulares_CellClick);
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensaje.Location = new System.Drawing.Point(556, 76);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(0, 20);
            this.Mensaje.TabIndex = 69;
            // 
            // btCargarActualizacion
            // 
            this.btCargarActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargarActualizacion.Location = new System.Drawing.Point(444, 240);
            this.btCargarActualizacion.Name = "btCargarActualizacion";
            this.btCargarActualizacion.Size = new System.Drawing.Size(335, 31);
            this.btCargarActualizacion.TabIndex = 68;
            this.btCargarActualizacion.Text = "Cargar Actualizacion";
            this.btCargarActualizacion.UseVisualStyleBackColor = true;
            this.btCargarActualizacion.Click += new System.EventHandler(this.btCargarActualizacion_Click);
            // 
            // EliminarCelular
            // 
            this.EliminarCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.EliminarCelular.Location = new System.Drawing.Point(615, 203);
            this.EliminarCelular.Name = "EliminarCelular";
            this.EliminarCelular.Size = new System.Drawing.Size(164, 31);
            this.EliminarCelular.TabIndex = 67;
            this.EliminarCelular.Text = "Eliminar";
            this.EliminarCelular.UseVisualStyleBackColor = true;
            this.EliminarCelular.Click += new System.EventHandler(this.EliminarCelular_Click);
            // 
            // btCargarCelular
            // 
            this.btCargarCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargarCelular.Location = new System.Drawing.Point(444, 203);
            this.btCargarCelular.Name = "btCargarCelular";
            this.btCargarCelular.Size = new System.Drawing.Size(165, 31);
            this.btCargarCelular.TabIndex = 47;
            this.btCargarCelular.Text = "Cargar celular";
            this.btCargarCelular.UseVisualStyleBackColor = true;
            this.btCargarCelular.Click += new System.EventHandler(this.btCargarCelular_Click);
            // 
            // cbTecnico
            // 
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(83, 191);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(183, 21);
            this.cbTecnico.TabIndex = 66;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(83, 156);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(183, 21);
            this.cbEstado.TabIndex = 65;
            // 
            // txtFecha_Egreso
            // 
            this.txtFecha_Egreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha_Egreso.Location = new System.Drawing.Point(121, 285);
            this.txtFecha_Egreso.Name = "txtFecha_Egreso";
            this.txtFecha_Egreso.Size = new System.Drawing.Size(145, 26);
            this.txtFecha_Egreso.TabIndex = 64;
            // 
            // txtFecha_Ingreso
            // 
            this.txtFecha_Ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha_Ingreso.Location = new System.Drawing.Point(115, 256);
            this.txtFecha_Ingreso.Name = "txtFecha_Ingreso";
            this.txtFecha_Ingreso.Size = new System.Drawing.Size(151, 26);
            this.txtFecha_Ingreso.TabIndex = 63;
            // 
            // txtCosto_Total
            // 
            this.txtCosto_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto_Total.Location = new System.Drawing.Point(99, 224);
            this.txtCosto_Total.Name = "txtCosto_Total";
            this.txtCosto_Total.Size = new System.Drawing.Size(167, 26);
            this.txtCosto_Total.TabIndex = 62;
            // 
            // txtReparacion
            // 
            this.txtReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReparacion.Location = new System.Drawing.Point(103, 116);
            this.txtReparacion.Name = "txtReparacion";
            this.txtReparacion.Size = new System.Drawing.Size(163, 26);
            this.txtReparacion.TabIndex = 61;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(71, 76);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(195, 26);
            this.txtModelo.TabIndex = 60;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(71, 43);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(195, 26);
            this.txtMarca.TabIndex = 59;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(71, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(195, 26);
            this.txtCodigo.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Fecha Egreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Costo Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Tecnico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Reparacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Marca";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 53;
            this.lblCodigo.Text = "Codigo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btBorrar);
            this.tabPage2.Controls.Add(this.btActualizarT);
            this.tabPage2.Controls.Add(this.dgvTecnicos);
            this.tabPage2.Controls.Add(this.btCargarTecnico);
            this.tabPage2.Controls.Add(this.txtApellido);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.txtDNI);
            this.tabPage2.Controls.Add(this.lbApellido);
            this.tabPage2.Controls.Add(this.lbNombre);
            this.tabPage2.Controls.Add(this.lbDNI);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btBorrar
            // 
            this.btBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(440, 148);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(165, 31);
            this.btBorrar.TabIndex = 70;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btActualizarT
            // 
            this.btActualizarT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizarT.Location = new System.Drawing.Point(532, 111);
            this.btActualizarT.Name = "btActualizarT";
            this.btActualizarT.Size = new System.Drawing.Size(165, 31);
            this.btActualizarT.TabIndex = 69;
            this.btActualizarT.Text = "Actualizar";
            this.btActualizarT.UseVisualStyleBackColor = true;
            this.btActualizarT.Click += new System.EventHandler(this.btActualizarT_Click);
            // 
            // dgvTecnicos
            // 
            this.dgvTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecnicos.Location = new System.Drawing.Point(6, 226);
            this.dgvTecnicos.Name = "dgvTecnicos";
            this.dgvTecnicos.Size = new System.Drawing.Size(1026, 348);
            this.dgvTecnicos.TabIndex = 68;
            this.dgvTecnicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTecnicos_CellClick);
            // 
            // btCargarTecnico
            // 
            this.btCargarTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargarTecnico.Location = new System.Drawing.Point(361, 111);
            this.btCargarTecnico.Name = "btCargarTecnico";
            this.btCargarTecnico.Size = new System.Drawing.Size(165, 31);
            this.btCargarTecnico.TabIndex = 67;
            this.btCargarTecnico.Text = "Cargar tecnico";
            this.btCargarTecnico.UseVisualStyleBackColor = true;
            this.btCargarTecnico.Click += new System.EventHandler(this.btCargarTecnico_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(361, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(339, 26);
            this.txtApellido.TabIndex = 66;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(361, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(339, 26);
            this.txtNombre.TabIndex = 65;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(361, 12);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(339, 26);
            this.txtDNI.TabIndex = 64;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(286, 82);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(69, 20);
            this.lbApellido.TabIndex = 61;
            this.lbApellido.Text = "Apellido:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(290, 46);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(69, 20);
            this.lbNombre.TabIndex = 62;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNI.Location = new System.Drawing.Point(296, 15);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(41, 20);
            this.lbDNI.TabIndex = 63;
            this.lbDNI.Text = "DNI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCelulares)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btCargarActualizacion;
        private System.Windows.Forms.Button EliminarCelular;
        private System.Windows.Forms.Button btCargarCelular;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtFecha_Egreso;
        private System.Windows.Forms.TextBox txtFecha_Ingreso;
        private System.Windows.Forms.TextBox txtCosto_Total;
        private System.Windows.Forms.TextBox txtReparacion;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView DgvCelulares;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.DataGridView dgvTecnicos;
        private System.Windows.Forms.Button btCargarTecnico;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Button btActualizarT;
        private System.Windows.Forms.Button btBorrar;
    }
}

