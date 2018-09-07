namespace GES001i
{
    partial class frmSetGES
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetGES));
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_SubEtapa = new System.Windows.Forms.TextBox();
            this.Txt_DiasContrato = new System.Windows.Forms.TextBox();
            this.Txt_DiasFonasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Paquetes = new System.Windows.Forms.TextBox();
            this.Gv_Patologias = new System.Windows.Forms.DataGridView();
            this.ID_FILA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_FILA_DET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_SUB_ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_SUB_ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_PAQUETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_PAQUETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nuevo_Paq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_FONASA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDiagnostico = new System.Windows.Forms.GroupBox();
            this.Txt_Diagnostico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Etapa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Ayuda = new AyudaSpreadNet.AyudaSprNet();
            this.ImgListTv = new System.Windows.Forms.ImageList(this.components);
            this.Tv_canastas_ges = new System.Windows.Forms.TreeView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_anular = new System.Windows.Forms.Button();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_limpiar_etapa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Etapa = new System.Windows.Forms.Button();
            this.Btn_SubEtapa = new System.Windows.Forms.Button();
            this.Btn_Paquetes = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Diagnostico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Patologias)).BeginInit();
            this.grpDiagnostico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sub Etapas:";
            // 
            // Txt_SubEtapa
            // 
            this.Txt_SubEtapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_SubEtapa.Location = new System.Drawing.Point(79, 53);
            this.Txt_SubEtapa.MaxLength = 20;
            this.Txt_SubEtapa.Name = "Txt_SubEtapa";
            this.Txt_SubEtapa.Size = new System.Drawing.Size(307, 20);
            this.Txt_SubEtapa.TabIndex = 3;
            this.Txt_SubEtapa.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.Txt_SubEtapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SubEtapa_KeyPress);
            this.Txt_SubEtapa.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // Txt_DiasContrato
            // 
            this.Txt_DiasContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_DiasContrato.Location = new System.Drawing.Point(244, 107);
            this.Txt_DiasContrato.MaxLength = 3;
            this.Txt_DiasContrato.Name = "Txt_DiasContrato";
            this.Txt_DiasContrato.Size = new System.Drawing.Size(65, 20);
            this.Txt_DiasContrato.TabIndex = 8;
            this.Txt_DiasContrato.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.Txt_DiasContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DiasContrato_KeyPress);
            this.Txt_DiasContrato.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // Txt_DiasFonasa
            // 
            this.Txt_DiasFonasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_DiasFonasa.Location = new System.Drawing.Point(79, 107);
            this.Txt_DiasFonasa.MaxLength = 3;
            this.Txt_DiasFonasa.Name = "Txt_DiasFonasa";
            this.Txt_DiasFonasa.Size = new System.Drawing.Size(65, 20);
            this.Txt_DiasFonasa.TabIndex = 7;
            this.Txt_DiasFonasa.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.Txt_DiasFonasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DiasFonasa_KeyPress);
            this.Txt_DiasFonasa.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Canasta";
            // 
            // Txt_Paquetes
            // 
            this.Txt_Paquetes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Paquetes.Location = new System.Drawing.Point(79, 80);
            this.Txt_Paquetes.MaxLength = 30;
            this.Txt_Paquetes.Name = "Txt_Paquetes";
            this.Txt_Paquetes.Size = new System.Drawing.Size(472, 20);
            this.Txt_Paquetes.TabIndex = 5;
            this.Txt_Paquetes.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.Txt_Paquetes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Paquetes_KeyPress);
            this.Txt_Paquetes.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // Gv_Patologias
            // 
            this.Gv_Patologias.AllowUserToAddRows = false;
            this.Gv_Patologias.AllowUserToDeleteRows = false;
            this.Gv_Patologias.AllowUserToResizeColumns = false;
            this.Gv_Patologias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_Patologias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_Patologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_Patologias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Modificar,
            this.ID_FILA,
            this.ID_FILA_DET,
            this.COD_ETAPA,
            this.NOM_ETAPA,
            this.COD_SUB_ETAPA,
            this.NOM_SUB_ETAPA,
            this.COD_PAQUETE,
            this.NOM_PAQUETE,
            this.Nuevo_Paq,
            this.DIA_FONASA,
            this.DIA_CONTRATO,
            this.Vigencia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gv_Patologias.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gv_Patologias.Location = new System.Drawing.Point(308, 281);
            this.Gv_Patologias.Name = "Gv_Patologias";
            this.Gv_Patologias.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_Patologias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Gv_Patologias.RowHeadersVisible = false;
            this.Gv_Patologias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gv_Patologias.Size = new System.Drawing.Size(632, 256);
            this.Gv_Patologias.TabIndex = 0;
            this.Gv_Patologias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Patologias_CellDoubleClick);
            this.Gv_Patologias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Gv_Patologias_CellPainting);
            // 
            // ID_FILA
            // 
            this.ID_FILA.DataPropertyName = "ID_FILA";
            this.ID_FILA.HeaderText = "ID_FILA";
            this.ID_FILA.Name = "ID_FILA";
            this.ID_FILA.ReadOnly = true;
            this.ID_FILA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_FILA.Visible = false;
            // 
            // ID_FILA_DET
            // 
            this.ID_FILA_DET.DataPropertyName = "ID_FILA_DET";
            this.ID_FILA_DET.HeaderText = "FILA_DET";
            this.ID_FILA_DET.Name = "ID_FILA_DET";
            this.ID_FILA_DET.ReadOnly = true;
            this.ID_FILA_DET.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_FILA_DET.Visible = false;
            // 
            // COD_ETAPA
            // 
            this.COD_ETAPA.DataPropertyName = "COD_ETAPA";
            this.COD_ETAPA.HeaderText = "Cod_etapa";
            this.COD_ETAPA.Name = "COD_ETAPA";
            this.COD_ETAPA.ReadOnly = true;
            this.COD_ETAPA.Visible = false;
            // 
            // NOM_ETAPA
            // 
            this.NOM_ETAPA.DataPropertyName = "NOM_ETAPA";
            this.NOM_ETAPA.HeaderText = "Etapa";
            this.NOM_ETAPA.MaxInputLength = 400000;
            this.NOM_ETAPA.Name = "NOM_ETAPA";
            this.NOM_ETAPA.ReadOnly = true;
            this.NOM_ETAPA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // COD_SUB_ETAPA
            // 
            this.COD_SUB_ETAPA.DataPropertyName = "COD_SUB_ETAPA";
            this.COD_SUB_ETAPA.HeaderText = "Cod_sub_etapa";
            this.COD_SUB_ETAPA.Name = "COD_SUB_ETAPA";
            this.COD_SUB_ETAPA.ReadOnly = true;
            this.COD_SUB_ETAPA.Visible = false;
            // 
            // NOM_SUB_ETAPA
            // 
            this.NOM_SUB_ETAPA.DataPropertyName = "NOM_SUB_ETAPA";
            this.NOM_SUB_ETAPA.HeaderText = "Sub Etapa";
            this.NOM_SUB_ETAPA.Name = "NOM_SUB_ETAPA";
            this.NOM_SUB_ETAPA.ReadOnly = true;
            this.NOM_SUB_ETAPA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // COD_PAQUETE
            // 
            this.COD_PAQUETE.DataPropertyName = "COD_PAQUETE";
            this.COD_PAQUETE.HeaderText = "Cod Paquete";
            this.COD_PAQUETE.Name = "COD_PAQUETE";
            this.COD_PAQUETE.ReadOnly = true;
            this.COD_PAQUETE.Visible = false;
            this.COD_PAQUETE.Width = 205;
            // 
            // NOM_PAQUETE
            // 
            this.NOM_PAQUETE.DataPropertyName = "NOM_PAQUETE";
            this.NOM_PAQUETE.HeaderText = "Paquete";
            this.NOM_PAQUETE.Name = "NOM_PAQUETE";
            this.NOM_PAQUETE.ReadOnly = true;
            this.NOM_PAQUETE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOM_PAQUETE.Width = 280;
            // 
            // Nuevo_Paq
            // 
            this.Nuevo_Paq.DataPropertyName = "Nuevo";
            this.Nuevo_Paq.HeaderText = "Nuevo";
            this.Nuevo_Paq.Name = "Nuevo_Paq";
            this.Nuevo_Paq.ReadOnly = true;
            this.Nuevo_Paq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nuevo_Paq.Visible = false;
            // 
            // DIA_FONASA
            // 
            this.DIA_FONASA.DataPropertyName = "DIA_FONASA";
            this.DIA_FONASA.HeaderText = "Dias Vigencia";
            this.DIA_FONASA.Name = "DIA_FONASA";
            this.DIA_FONASA.ReadOnly = true;
            this.DIA_FONASA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIA_FONASA.Width = 50;
            // 
            // DIA_CONTRATO
            // 
            this.DIA_CONTRATO.DataPropertyName = "DIA_CONTRATO";
            this.DIA_CONTRATO.HeaderText = "Dias Contrato";
            this.DIA_CONTRATO.Name = "DIA_CONTRATO";
            this.DIA_CONTRATO.ReadOnly = true;
            this.DIA_CONTRATO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIA_CONTRATO.Width = 50;
            // 
            // Vigencia
            // 
            this.Vigencia.DataPropertyName = "Vigencia";
            this.Vigencia.HeaderText = "Vigencia";
            this.Vigencia.Name = "Vigencia";
            this.Vigencia.ReadOnly = true;
            this.Vigencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Vigencia.Visible = false;
            this.Vigencia.Width = 50;
            // 
            // grpDiagnostico
            // 
            this.grpDiagnostico.BackColor = System.Drawing.SystemColors.Control;
            this.grpDiagnostico.Controls.Add(this.Btn_Diagnostico);
            this.grpDiagnostico.Controls.Add(this.label3);
            this.grpDiagnostico.Controls.Add(this.Txt_Diagnostico);
            this.grpDiagnostico.Controls.Add(this.label1);
            this.grpDiagnostico.Location = new System.Drawing.Point(308, 51);
            this.grpDiagnostico.Name = "grpDiagnostico";
            this.grpDiagnostico.Size = new System.Drawing.Size(632, 64);
            this.grpDiagnostico.TabIndex = 1;
            this.grpDiagnostico.TabStop = false;
            this.grpDiagnostico.Enter += new System.EventHandler(this.CambiarColor_Enter);
            this.grpDiagnostico.Leave += new System.EventHandler(this.CambiarBlanco_Leave);
            // 
            // Txt_Diagnostico
            // 
            this.Txt_Diagnostico.BackColor = System.Drawing.Color.White;
            this.Txt_Diagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Diagnostico.Location = new System.Drawing.Point(79, 33);
            this.Txt_Diagnostico.MaxLength = 30;
            this.Txt_Diagnostico.Name = "Txt_Diagnostico";
            this.Txt_Diagnostico.Size = new System.Drawing.Size(472, 20);
            this.Txt_Diagnostico.TabIndex = 1;
            this.Txt_Diagnostico.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.Txt_Diagnostico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Diagnostico_KeyPress);
            this.Txt_Diagnostico.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patología:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.BackColor = System.Drawing.Color.Silver;
            this.LblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(2, 8);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(139, 25);
            this.LblUsuario.TabIndex = 74;
            this.LblUsuario.Text = "Usuario: SICI";
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Días Fonasa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Días Contrato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpiar_etapa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Btn_Agregar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_DiasContrato);
            this.groupBox1.Controls.Add(this.Txt_DiasFonasa);
            this.groupBox1.Controls.Add(this.Btn_Etapa);
            this.groupBox1.Controls.Add(this.Txt_SubEtapa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_Etapa);
            this.groupBox1.Controls.Add(this.Txt_Paquetes);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Btn_SubEtapa);
            this.groupBox1.Controls.Add(this.Btn_Paquetes);
            this.groupBox1.Controls.Add(this.btn_confirmar);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(308, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.CambiarColor_Enter);
            this.groupBox1.Leave += new System.EventHandler(this.CambiarBlanco_Leave);
            // 
            // Txt_Etapa
            // 
            this.Txt_Etapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Etapa.Location = new System.Drawing.Point(79, 27);
            this.Txt_Etapa.MaxLength = 20;
            this.Txt_Etapa.Name = "Txt_Etapa";
            this.Txt_Etapa.Size = new System.Drawing.Size(307, 20);
            this.Txt_Etapa.TabIndex = 1;
            this.Txt_Etapa.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.Txt_Etapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Etapa_KeyPress);
            this.Txt_Etapa.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Etapa";
            // 
            // Ayuda
            // 
            this.Ayuda.AnchoColumnas = null;
            this.Ayuda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Ayuda.Location = new System.Drawing.Point(864, 8);
            this.Ayuda.Multi_Seleccion = false;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Nombre_BD_Datos = null;
            this.Ayuda.NombreColumnas = null;
            this.Ayuda.Package = null;
            this.Ayuda.Pass = null;
            this.Ayuda.Procedimiento = null;
            this.Ayuda.Size = new System.Drawing.Size(59, 59);
            this.Ayuda.TabIndex = 75;
            this.Ayuda.TipoBase = 0;
            this.Ayuda.TituloConsulta = null;
            this.Ayuda.User = null;
            this.Ayuda.UseWaitCursor = true;
            this.Ayuda.Visible = false;
            // 
            // ImgListTv
            // 
            this.ImgListTv.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListTv.ImageStream")));
            this.ImgListTv.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListTv.Images.SetKeyName(0, "Anatomy.png");
            this.ImgListTv.Images.SetKeyName(1, "Chemicals.png");
            this.ImgListTv.Images.SetKeyName(2, "Hospital.png");
            this.ImgListTv.Images.SetKeyName(3, "Calendar.png");
            this.ImgListTv.Images.SetKeyName(4, "Allergy Vials.png");
            this.ImgListTv.Images.SetKeyName(5, "Medical Invoice Flat.png");
            this.ImgListTv.Images.SetKeyName(6, "App.png");
            this.ImgListTv.Images.SetKeyName(7, "cesta.png");
            // 
            // Tv_canastas_ges
            // 
            this.Tv_canastas_ges.Location = new System.Drawing.Point(5, 74);
            this.Tv_canastas_ges.Name = "Tv_canastas_ges";
            this.Tv_canastas_ges.Size = new System.Drawing.Size(296, 464);
            this.Tv_canastas_ges.TabIndex = 83;
            this.Tv_canastas_ges.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvEsquemas_AfterSelect);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "E";
            this.dataGridViewImageColumn1.Image = global::GES001i.Properties.Resources.Delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 20;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "M";
            this.dataGridViewImageColumn2.Image = global::GES001i.Properties.Resources.ver_ficha;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 20;
            // 
            // btn_anular
            // 
            this.btn_anular.Image = global::GES001i.Properties.Resources.delete_doc;
            this.btn_anular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anular.Location = new System.Drawing.Point(615, 9);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(79, 36);
            this.btn_anular.TabIndex = 233;
            this.btn_anular.Text = "Anular";
            this.btn_anular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_anular.UseVisualStyleBackColor = true;
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.Image = global::GES001i.Properties.Resources.save;
            this.Btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Grabar.Location = new System.Drawing.Point(447, 8);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(77, 37);
            this.Btn_Grabar.TabIndex = 84;
            this.Btn_Grabar.Text = "Guardar";
            this.Btn_Grabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            this.Btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::GES001i.Properties.Resources.HeaderGV1024;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "PATOLOGÍAS GES CONFIGURADAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::GES001i.Properties.Resources.HeaderGV1024;
            this.label6.Location = new System.Drawing.Point(308, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(632, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "DETALLE CANASTA ASOCIADAS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_limpiar_etapa
            // 
            this.btn_limpiar_etapa.Image = global::GES001i.Properties.Resources.limpiar;
            this.btn_limpiar_etapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar_etapa.Location = new System.Drawing.Point(521, 106);
            this.btn_limpiar_etapa.Name = "btn_limpiar_etapa";
            this.btn_limpiar_etapa.Size = new System.Drawing.Size(72, 32);
            this.btn_limpiar_etapa.TabIndex = 76;
            this.btn_limpiar_etapa.Text = "Limpiar";
            this.btn_limpiar_etapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar_etapa.UseVisualStyleBackColor = true;
            this.btn_limpiar_etapa.Click += new System.EventHandler(this.btn_limpiar_etapa_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = global::GES001i.Properties.Resources.HeaderGV1024;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(632, 20);
            this.label10.TabIndex = 80;
            this.label10.Text = "CONFIGURACIÓN PATOLOGÍA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Image = global::GES001i.Properties.Resources.add;
            this.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar.Location = new System.Drawing.Point(433, 106);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(82, 32);
            this.Btn_Agregar.TabIndex = 9;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Etapa
            // 
            this.Btn_Etapa.Image = global::GES001i.Properties.Resources.Search21;
            this.Btn_Etapa.Location = new System.Drawing.Point(392, 23);
            this.Btn_Etapa.Name = "Btn_Etapa";
            this.Btn_Etapa.Size = new System.Drawing.Size(24, 24);
            this.Btn_Etapa.TabIndex = 2;
            this.Btn_Etapa.UseVisualStyleBackColor = true;
            this.Btn_Etapa.Click += new System.EventHandler(this.Btn_Etapa_Click);
            // 
            // Btn_SubEtapa
            // 
            this.Btn_SubEtapa.Image = global::GES001i.Properties.Resources.Search21;
            this.Btn_SubEtapa.Location = new System.Drawing.Point(392, 49);
            this.Btn_SubEtapa.Name = "Btn_SubEtapa";
            this.Btn_SubEtapa.Size = new System.Drawing.Size(24, 24);
            this.Btn_SubEtapa.TabIndex = 4;
            this.Btn_SubEtapa.UseVisualStyleBackColor = true;
            this.Btn_SubEtapa.Click += new System.EventHandler(this.Btn_SubEtapa_Click);
            // 
            // Btn_Paquetes
            // 
            this.Btn_Paquetes.Image = global::GES001i.Properties.Resources.Search21;
            this.Btn_Paquetes.Location = new System.Drawing.Point(557, 76);
            this.Btn_Paquetes.Name = "Btn_Paquetes";
            this.Btn_Paquetes.Size = new System.Drawing.Size(29, 24);
            this.Btn_Paquetes.TabIndex = 6;
            this.Btn_Paquetes.UseVisualStyleBackColor = true;
            this.Btn_Paquetes.Click += new System.EventHandler(this.Btn_Paquetes_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Image = ((System.Drawing.Image)(resources.GetObject("btn_confirmar.Image")));
            this.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmar.Location = new System.Drawing.Point(433, 108);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(82, 31);
            this.btn_confirmar.TabIndex = 95;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "E";
            this.Eliminar.Image = global::GES001i.Properties.Resources.Delete;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 20;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "M";
            this.Modificar.Image = global::GES001i.Properties.Resources.ver_ficha;
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Width = 20;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Image = global::GES001i.Properties.Resources.limpiar;
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.Location = new System.Drawing.Point(530, 8);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(77, 37);
            this.Btn_Limpiar.TabIndex = 3;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Diagnostico
            // 
            this.Btn_Diagnostico.Image = global::GES001i.Properties.Resources.Search21;
            this.Btn_Diagnostico.Location = new System.Drawing.Point(556, 29);
            this.Btn_Diagnostico.Name = "Btn_Diagnostico";
            this.Btn_Diagnostico.Size = new System.Drawing.Size(25, 24);
            this.Btn_Diagnostico.TabIndex = 2;
            this.Btn_Diagnostico.UseVisualStyleBackColor = true;
            this.Btn_Diagnostico.Click += new System.EventHandler(this.Btn_Diagnostico_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::GES001i.Properties.Resources.HeaderGV1024;
            this.label3.Location = new System.Drawing.Point(-2, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(634, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "PATOLOGÍA GES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSetGES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 556);
            this.Controls.Add(this.btn_anular);
            this.Controls.Add(this.Btn_Grabar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tv_canastas_ges);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.Gv_Patologias);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.grpDiagnostico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetGES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociación de Canastas a Patologías";
            this.Load += new System.EventHandler(this.frmSetGES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Patologias)).EndInit();
            this.grpDiagnostico.ResumeLayout(false);
            this.grpDiagnostico.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDiagnostico;
        private System.Windows.Forms.Button Btn_Diagnostico;
        private System.Windows.Forms.TextBox Txt_Diagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Gv_Patologias;
        private System.Windows.Forms.Button Btn_SubEtapa;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_SubEtapa;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Paquetes;
        private System.Windows.Forms.Button Btn_Paquetes;
        private System.Windows.Forms.TextBox Txt_DiasContrato;
        private System.Windows.Forms.TextBox Txt_DiasFonasa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_Etapa;
        private System.Windows.Forms.TextBox Txt_Etapa;
        private System.Windows.Forms.Label label11;
        private AyudaSpreadNet.AyudaSprNet Ayuda;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btn_limpiar_etapa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList ImgListTv;
        private System.Windows.Forms.TreeView Tv_canastas_ges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button Btn_Grabar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FILA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FILA_DET;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_SUB_ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_SUB_ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PAQUETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_PAQUETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nuevo_Paq;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_FONASA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vigencia;
        private System.Windows.Forms.Button btn_anular;
    }
}

