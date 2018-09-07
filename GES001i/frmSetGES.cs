using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Reflection;
using AplicacionFalp;
using Falp;

namespace GES001i
{
    public partial class frmSetGES : Form
    {

        ConectarFalp CnnFalp;
        Configuration Config;
        string[] Conexion = { "", "", "" };
        string PCK = "PCK_GES001I";
        DataTable Tbl_Patologia = new DataTable();
        DataTable dt_canasta = new DataTable();
        string Db_Usuario;
        Int64 cod_canasta = 0;
        Int64 cod_patologia = 0;
        Int64 cod_mod = 0;
        Int64 v_modificado= 0;
        Int64 v_cont = 0;
        Int64 v_ID = 0;

        public frmSetGES()
        {            
            InitializeComponent();
            
        }

        private void frmSetGES_Load(object sender, EventArgs e)
        {
            if (!(CnnFalp != null))
            {
                ExeConfigurationFileMap FileMap = new ExeConfigurationFileMap();
                FileMap.ExeConfigFilename = Application.StartupPath + @"\..\WF.config";
                Config = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);

                CnnFalp = new ConectarFalp(Config.AppSettings.Settings["dbServer"].Value,//ConfigurationManager.AppSettings["dbServer"],
                                           Config.AppSettings.Settings["dbUser"].Value,//ConfigurationManager.AppSettings["dbUser"],
                                           Config.AppSettings.Settings["dbPass"].Value,//ConfigurationManager.AppSettings["dbPass"],
                                           ConectarFalp.TipoBase.Oracle);

                if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir(); // abre la conexion
                Conexion[0] = Config.AppSettings.Settings["dbServer"].Value;
                Conexion[1] = Config.AppSettings.Settings["dbUser"].Value;
                Conexion[2] = Config.AppSettings.Settings["dbPass"].Value;
                this.Text = this.Text + " [Versión: " + Application.ProductVersion + "] [Conectado: " + Conexion[0] + "]";

            }
            Db_Usuario = "SICI";
            Btn_Grabar.Enabled=false;
            Asignacion();
            CargaTvEsquemas();
            Carga_Tabla_Patologia();
           
        }


        private void Asignacion()
        {
            Txt_Diagnostico.Tag = string.Empty;
            Txt_Etapa.Tag = string.Empty;
            Txt_SubEtapa.Tag = string.Empty;
            Txt_Paquetes.Tag = string.Empty;
            btn_confirmar.Visible = false;

        }

        
        private void Btn_Diagnostico_Click(object sender, EventArgs e)
        { 
          DB_BUSCAR_PARAMETROS(ref Ayuda, 81, Txt_Diagnostico.Text, "P_TRAE_PARAMETROS");       
        }


        private void DB_BUSCAR_PARAMETROS(ref AyudaSpreadNet.AyudaSprNet Ayuda, Int64 Tipo, string Desc, string Procedimiento)
        {   
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Seleccione Paquete Asignado";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = Procedimiento;
            Ayuda.Generar_ParametroBD("PIN_TIPO", Tipo, DbType.Int64, ParameterDirection.Input);
            Ayuda.Generar_ParametroBD("PIN_DESC", Desc.ToUpper(), DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

            if (!Ayuda.EOF())
            {
                if (Tipo == 81)
                {
                      Txt_Diagnostico.Tag = Ayuda.Fields(0);
                      if (!Validar_existencia_Patologia())
                      {
                          Txt_Diagnostico.Text = Ayuda.Fields(1);


                          Txt_Diagnostico.ReadOnly = true;
                          Btn_Diagnostico.Enabled = false;
                          groupBox1.Enabled = true;
                          Txt_Etapa.Focus();
                      }
                      else
                      {
                          MessageBox.Show("Estimado Usuario, La Patalogia se encuentra Registrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          Txt_Diagnostico.Focus();
                          Txt_Diagnostico.Text = string.Empty;
                          Txt_Diagnostico.Tag = null;

                      }

                }

                if (Tipo == 143)
                {
                    Txt_Etapa.Text = "";
                    Txt_Etapa.Tag = "";
                    Txt_Etapa.Text = Ayuda.Fields(1);
                    Txt_Etapa.Tag = Ayuda.Fields(0);
                    if (!Validar_existencia_dat())
                    {
                        Txt_SubEtapa.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Estimado Usuario, La Etapa " + Txt_Etapa.Text + " , Sub Etapa " + Txt_SubEtapa.Text + " y el Paquete " + Txt_Paquetes.Text + "  ya se encuentran registrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_Paquetes.Text = "";
                        Txt_Paquetes.Tag = "";
                    }
                }

                if (Tipo == 144)
                {
                    Txt_SubEtapa.Text = "";
                    Txt_SubEtapa.Tag = "";
                    Txt_SubEtapa.Text = Ayuda.Fields(1);        
                    Txt_SubEtapa.Tag = Ayuda.Fields(0);
                    if (!Validar_existencia_dat())
                    {
                        Txt_Paquetes.Focus();
                       
                    }
                    else
                    {
                        MessageBox.Show("Estimado Usuario, La Etapa " + Txt_Etapa.Text + " , Sub Etapa " + Txt_SubEtapa.Text + " y el Paquete " + Txt_Paquetes.Text + "  ya se encuentran registrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_Paquetes.Text = "";
                        Txt_Paquetes.Tag = "";
                    }
                }

                if (Tipo == 0)
                {
                    Txt_Paquetes.Text = "";
                    Txt_Paquetes.Tag = "";
                    Txt_Paquetes.Text = Ayuda.Fields(1);
                    Txt_Paquetes.Tag = Ayuda.Fields(0);
                    if (!Validar_existencia_dat())
                    {
                        Txt_DiasFonasa.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Estimado Usuario, La Etapa " + Txt_Etapa.Text + " , Sub Etapa " + Txt_SubEtapa.Text + " y el Paquete " + Txt_Paquetes.Text + "  ya se encuentran registrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_Paquetes.Text = "";
                        Txt_Paquetes.Tag = "";
                    }
                }
            }
        }   

        private void Btn_Etapa_Click(object sender, EventArgs e)
        {
            Txt_Etapa.Text = "";
            DB_BUSCAR_PARAMETROS(ref Ayuda, 143, Txt_Etapa.Text, "P_TRAE_PARAMETROS");
        }

        private void Btn_SubEtapa_Click(object sender, EventArgs e)
        {
            Txt_SubEtapa.Text = "";
            DB_BUSCAR_PARAMETROS(ref Ayuda, 144, Txt_SubEtapa.Text, "P_TRAE_PARAMETROS");
        }

        private void Btn_Paquetes_Click(object sender, EventArgs e)
        {
            Txt_Paquetes.Text = "";
            DB_BUSCAR_PARAMETROS(ref Ayuda, 0, Txt_Paquetes.Text, "P_TRAE_PAQUETES");
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Txt_Etapa.Tag.ToString() != string.Empty)
            {
                if (Txt_SubEtapa.Tag.ToString() != string.Empty)
                {
                    if (Txt_Paquetes.Tag.ToString() != string.Empty)
                    {
                        v_cont = Tbl_Patologia.Rows.Count;
                                
                                    if (Tbl_Patologia.Rows.Count == 0)
                                    {

                                        DialogResult opc = MessageBox.Show("Estimado Usuario,¿Esta Seguro de Agregar esta Patologia " + Txt_Diagnostico.Text + "", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                        if (opc == DialogResult.Yes)
                                        {
                                            DataRow NewFila = Tbl_Patologia.NewRow();
                                            NewFila["ID_FILA"] = v_cont + 1;
                                            NewFila["ID_FILA_DET"] = 0;
                                            NewFila["COD_ETAPA"] = Txt_Etapa.Tag;
                                            NewFila["NOM_ETAPA"] = Txt_Etapa.Text;
                                            NewFila["COD_SUB_ETAPA"] = Txt_SubEtapa.Tag;
                                            NewFila["NOM_SUB_ETAPA"] = Txt_SubEtapa.Text;
                                            NewFila["COD_PAQUETE"] = Txt_Paquetes.Tag;
                                            NewFila["NOM_PAQUETE"] = Txt_Paquetes.Text;
                                            NewFila["DIA_FONASA"] = Txt_DiasFonasa.Text.Equals(string.Empty)? 0:Convert.ToInt32(Txt_DiasFonasa.Text);
                                            NewFila["DIA_CONTRATO"] = Txt_DiasContrato.Text.Equals(string.Empty) ? 0 : Convert.ToInt32(Txt_DiasContrato.Text);
                                            NewFila["VIGENCIA"] = 1;
                                            Tbl_Patologia.Rows.Add(NewFila);
                                            Limpiar();
                                            Btn_Grabar.Visible = true;
                                            Txt_Diagnostico.Enabled = false;
                                        }
                                        else
                                        {

                                            Limpiar();
                                            Btn_Grabar.Visible = false;
                                        }

                                    }
                                    else
                                    {
                                        //if (!Validar_existencia())
                                        //{

                                            DataRow NewFila = Tbl_Patologia.NewRow();
                                            NewFila["ID_FILA"] = v_cont + 1;
                                            NewFila["ID_FILA_DET"] = 0;
                                            NewFila["COD_ETAPA"] = Txt_Etapa.Tag;
                                            NewFila["NOM_ETAPA"] = Txt_Etapa.Text;
                                            NewFila["COD_SUB_ETAPA"] = Txt_SubEtapa.Tag;
                                            NewFila["NOM_SUB_ETAPA"] = Txt_SubEtapa.Text;
                                            NewFila["COD_PAQUETE"] = Txt_Paquetes.Tag;
                                            NewFila["NOM_PAQUETE"] = Txt_Paquetes.Text;
                                            NewFila["DIA_FONASA"] = Txt_DiasFonasa.Text.Equals(string.Empty) ? 0 : Convert.ToInt32(Txt_DiasFonasa.Text);
                                            NewFila["DIA_CONTRATO"] = Txt_DiasContrato.Text.Equals(string.Empty) ? 0 : Convert.ToInt32(Txt_DiasContrato.Text);
                                            NewFila["VIGENCIA"] = 1;
                                            Tbl_Patologia.Rows.Add(NewFila);
                                            Limpiar();
                                            Btn_Grabar.Visible = true;
                                        //}
                                        //else
                                        //{
                                        //    MessageBox.Show("Estimado Usuario, La Etapa " + Txt_Etapa.Text + " , Sub Etapa " + Txt_SubEtapa.Text + " y el Paquete " + Txt_Paquetes.Text + "  ya se encuentran registrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //}


                                    }

                                    Tbl_Patologia.AcceptChanges();
                                    DataView Dv = new DataView(Tbl_Patologia);
                                    Dv.Sort = "NOM_ETAPA";
                                    Gv_Patologias.AutoGenerateColumns = false;
                                    Gv_Patologias.DataSource = Dv;


                                    LimpiarSeccion();
                                    //Limpiar();
                                    Txt_Etapa.Focus();
                                    Btn_Grabar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Estimado Usuario, Debe Ingresar una Canasta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_Paquetes.Tag = "";
                        Txt_Paquetes.Text="";
                    }
                }
                else
                {
                    MessageBox.Show("Estimado Usuario, Debe Ingresar una Sub - Etapa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_SubEtapa.Text = "";
                    Txt_SubEtapa.Tag = "";
                }
            }
            else
            {
                MessageBox.Show("Estimado Usuario, Debe Ingresar uan Etapa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Etapa.Text = "";
                Txt_Etapa.Tag = "";
            }
         
        }

        private void LimpiarSeccion()
        {
            Txt_Paquetes.Text = string.Empty;
            Txt_Paquetes.Tag = string.Empty;
            Txt_DiasFonasa.Text = string.Empty;
            Txt_DiasContrato.Text = string.Empty;
        }

   

        private void Txt_Diagnostico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;

                return;
            }
            else
            {
                if (e.KeyChar == 13)
                {
                    DB_BUSCAR_PARAMETROS(ref Ayuda, 81, Txt_Diagnostico.Text, "P_TRAE_PARAMETROS");
                }
            }
        }

        private void Txt_Etapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;

                return;
            }
            else
            {
                if (e.KeyChar == 13)
                {
                    Txt_Etapa.Text = "";
                    Txt_Etapa.Tag = "";
                    DB_BUSCAR_PARAMETROS(ref Ayuda, 143, Txt_Etapa.Text, "P_TRAE_PARAMETROS");
                }
            }
        }

        private void Txt_SubEtapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;

                return;
            }
            else
            {
                if (e.KeyChar == 13)
                {
                    Txt_SubEtapa.Text = "";
                    Txt_SubEtapa.Tag = "";
                    DB_BUSCAR_PARAMETROS(ref Ayuda, 144, Txt_SubEtapa.Text, "P_TRAE_PARAMETROS");
                }
            }
        }

        private void Txt_Paquetes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;

                return;
            }
            else
            {
                if (e.KeyChar == 13)
                {
                    Txt_Paquetes.Text = "";
                    Txt_Paquetes.Tag = "";
                    DB_BUSCAR_PARAMETROS(ref Ayuda, 0, Txt_Paquetes.Text, "P_TRAE_PAQUETES");
                }
            }
        }

        private void CambiarBlanco_TextLeave(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.White;

        }

        private void CambiarColor_TextEnter(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void CambiarColor_Enter(object sender, EventArgs e)
        {
            GroupBox GB = (GroupBox)sender;
            GB.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void CambiarBlanco_Leave(object sender, EventArgs e)
        {
            GroupBox GB = (GroupBox)sender;
            GB.BackColor = Color.WhiteSmoke;
        }


        private void Limpiar()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                    c.Tag = string.Empty;
                }
            }
            btn_confirmar.Visible = false;
            Btn_Agregar.Visible = true;
            Btn_Grabar.Enabled = true;
        }

        private void Txt_DiasFonasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                Txt_DiasContrato.Focus();
            }
        }

        private void Txt_DiasContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                Btn_Agregar.Focus();
            }
        }

        private void Gv_Patologias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView Grilla = (DataGridView)sender;
            if (e.RowIndex < 0)
            {
                e.PaintBackground(e.ClipBounds, false);
                Font drawFont = new Font("Trebuchet MS", 8, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                StringFormat StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Center;
                StrFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawImage(Properties.Resources.HeaderGV1024, e.CellBounds);
                e.Graphics.DrawString(Grilla.Columns[e.ColumnIndex].HeaderText, drawFont, drawBrush, e.CellBounds, StrFormat);
                e.Handled = true;
                drawBrush.Dispose();
            }
        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            DialogResult opc = MessageBox.Show("Estimado Usuario,¿Esta Seguro de Registrar esta Patología " + Txt_Diagnostico.Text + "", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opc == DialogResult.Yes)
            {

                CnnFalp.IniciarTransaccion();
                try
                {

                    Grabar_patologia();
                    CnnFalp.ConfirmarTransaccion();
                    MessageBox.Show("Estimado Usuario, Los Información fue Registrada Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    CnnFalp.ReversarTransaccion();
                    MessageBox.Show("Estimado Usuario, Error Al Registrar La Información " + ex + " ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Limpia_general();
                Txt_Diagnostico.Enabled = true;
                Btn_Diagnostico.Enabled = true;
            }

        }


        private void Grabar_patologia() 
        {
            
            if (cod_patologia == 0)
            {
                Guardar_patologia(1);
            }
            else
            {
                Guardar_patologia(0);
                Graba_Detalle(0);
            }
        }

        private void  Guardar_patologia(int num){
            

            if (v_ID == 0)
            {
                CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + ".P_GRABA_PATOLOGIA");
                CnnFalp.ParametroBD("pin_patologia", Txt_Diagnostico.Tag, DbType.Int64, ParameterDirection.Input);
                CnnFalp.ParametroBD("PIN_USUARIO", Db_Usuario, DbType.String, ParameterDirection.Input);
                CnnFalp.ParametroBD("PIN_VIGENCIA", Verificar_vigencia(), DbType.String, ParameterDirection.Input);
                CnnFalp.ParametroBD("POUT_ID", 0, DbType.Int64, ParameterDirection.Output);
                CnnFalp.ExecuteNonQuery();
                v_ID = Convert.ToInt64(CnnFalp.ParamValue("POUT_ID").ToString());
                if (num == 1)
                {
                    Graba_Detalle(v_ID);
                }
            }
           
        }

        private string Verificar_vigencia()
        {
            string vig = "";
            int cant = 0;
            int cont = 0;
            cant = Tbl_Patologia.Rows.Count;
            foreach (DataRow Dx in Tbl_Patologia.Rows)
            {
                if (Dx["VIGENCIA"].ToString() == "0")
                {
                    cont++;
                }
            }

            if (cant == cont && cant > 0)
            {
                vig = "0";
            }
            else
            {
                vig = "1";
            }

            return vig;
        }

        private void Graba_Detalle(Int64  Id)   
        {
            Int64 v_patologia = 0;
            if (Id == 0)
            {
                v_patologia = Convert.ToInt64(cod_patologia);
            }
            else
            {
                v_patologia = Id;
            }
            foreach (DataRow Dx in Tbl_Patologia.Rows)
            {
                string va = Dx["ID_FILA_DET"].ToString();
                string vig = Dx["VIGENCIA"].ToString();
                CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + ".p_graba_det");
                CnnFalp.ParametroBD("pin_id_patologia", v_patologia, DbType.Int64, ParameterDirection.Input);
                CnnFalp.ParametroBD("pin_patologia_det", Dx["ID_FILA_DET"], DbType.Int64, ParameterDirection.Input);
                CnnFalp.ParametroBD("pin_etapa", Dx["COD_ETAPA"], DbType.Int64, ParameterDirection.Input);
                CnnFalp.ParametroBD("pin_sub_etapa", Dx["COD_SUB_ETAPA"], DbType.Int64, ParameterDirection.Input);
                CnnFalp.ParametroBD("pin_paquete", Dx["COD_PAQUETE"], DbType.Int64, ParameterDirection.Input);
                CnnFalp.ParametroBD("pin_dia_fonasa", Dx["DIA_FONASA"], DbType.Int64, ParameterDirection.Input);
                CnnFalp.ParametroBD("pin_dia_contrato", Dx["DIA_CONTRATO"], DbType.Int64, ParameterDirection.Input);
                CnnFalp.ParametroBD("pin_user", Db_Usuario, DbType.String, ParameterDirection.Input);
                CnnFalp.ParametroBD("pin_vigencia", vig, DbType.String, ParameterDirection.Input);
                CnnFalp.ExecuteNonQuery();
            
            }
        }

        private void Gv_Patologias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string etapa = Gv_Patologias.Rows[e.RowIndex].Cells["NOM_ETAPA"].Value.ToString();
            Int64 fila = Convert.ToInt64(Gv_Patologias.Rows[e.RowIndex].Cells["ID_FILA"].Value.ToString());
            cod_mod = Convert.ToInt64(Gv_Patologias.Rows[e.RowIndex].Cells["ID_FILA_DET"].Value.ToString());
            if (e.RowIndex > -1)
            {
                if (Gv_Patologias.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    DialogResult opc = MessageBox.Show("Estimado Usuario,¿Esta Seguro  de Eliminar la Etapa " + etapa + " ?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opc == DialogResult.Yes)
                    {
                        if (cod_mod == 0)
                        {

                            Gv_Patologias.Rows.RemoveAt(Gv_Patologias.CurrentRow.Index);
                        }

                        else
                        {
                           
                            foreach (DataRow ad in Tbl_Patologia.Select("ID_FILA = " + fila + ""))
                            {
                                string VIG = ad["VIGENCIA"].ToString();

                                if (VIG == "1")
                                {
                                    ad["VIGENCIA"] = "0";
                                }

                            }

                        }

                        Tbl_Patologia.AcceptChanges();
                        Gv_Patologias.DataSource = new DataView(Tbl_Patologia, "VIGENCIA ='1'", "", DataViewRowState.CurrentRows);
                        MessageBox.Show("Estimado Usuario, Fue Eliminado Correctamente la Etapa " + etapa + "", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Btn_Grabar.Enabled = true;
                    }
                }
                else
                {
                    if (Gv_Patologias.Columns[e.ColumnIndex].Name == "Modificar")
                    {
                        DialogResult opc = MessageBox.Show("Estimado Usuario,¿Esta Seguro  de Modificar  la Etapa " + etapa + " ?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (opc == DialogResult.Yes)
                        {
                          
                            if (cod_mod == 0)
                            {
                                v_modificado = fila;
                            }
                            Btn_Agregar.Visible = false;
                            btn_confirmar.Visible = true;
                            groupBox1.Enabled = true;
                            Txt_Etapa.Text = etapa;
                            Txt_Etapa.Tag = Gv_Patologias.Rows[e.RowIndex].Cells["COD_ETAPA"].Value.ToString();
                            Txt_SubEtapa.Tag = Gv_Patologias.Rows[e.RowIndex].Cells["COD_SUB_ETAPA"].Value.ToString();
                            Txt_SubEtapa.Text = Gv_Patologias.Rows[e.RowIndex].Cells["NOM_SUB_ETAPA"].Value.ToString();
                            Txt_Paquetes.Text = Gv_Patologias.Rows[e.RowIndex].Cells["NOM_PAQUETE"].Value.ToString();
                            Txt_Paquetes.Tag = Gv_Patologias.Rows[e.RowIndex].Cells["COD_PAQUETE"].Value.ToString();
                            Txt_DiasFonasa.Text = Gv_Patologias.Rows[e.RowIndex].Cells["DIA_FONASA"].Value.ToString();
                            Txt_DiasContrato.Text = Gv_Patologias.Rows[e.RowIndex].Cells["DIA_CONTRATO"].Value.ToString();
                            Btn_Grabar.Enabled = true;

                        }
                    }
                }
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {

            DialogResult opc = MessageBox.Show("Estimado Usuario,¿Esta Seguro de  Limpiar los campos de Pantalla?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opc == DialogResult.Yes)
            {
                Limpia_general();
            }
            Txt_Diagnostico.Enabled = true;
            Btn_Diagnostico.Enabled = true;
        }

        //Agregar Metodo

        private void Carga_Tabla_Patologia()
        {
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + ".P_CARGAR_CANASTA");
            Tbl_Patologia.Load(CnnFalp.ExecuteReader());
            Tbl_Patologia.Clear();
        }

        private void CargaTvEsquemas()
        {
           
            dt_canasta.Clear();
            Tv_canastas_ges.Nodes.Clear();
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + ".P_CARGAR_CANASTA");
            dt_canasta.Load(CnnFalp.ExecuteReader());
          

            string[] Fil_patalogia = { "ID_FILA", "COD_PATOLOGIA", "NOM_PATOLOGIA" };
            DataTable v_dt_patologia = dt_canasta.DefaultView.ToTable(true, Fil_patalogia);

            string[] Fil_etapa = { "ID_FILA", "COD_PATOLOGIA", "COD_ETAPA", "NOM_ETAPA" };
            DataTable v_dt_etapa = dt_canasta.DefaultView.ToTable(true, Fil_etapa);

            string[] Fil_sub_etapa = { "ID_FILA", "COD_ETAPA", "COD_SUB_ETAPA", "NOM_SUB_ETAPA" };
            DataTable v_dt_sub_etapa = dt_canasta.DefaultView.ToTable(true, Fil_sub_etapa);

            Tv_canastas_ges.ImageList = ImgListTv;
            Tv_canastas_ges.Nodes.Add("0", "Falp", "Hospital.png", "Hospital.png");

            int x = 0;
            int z = 0;
            int y = 0;

            foreach (DataRow FilaPatalogia in v_dt_patologia.Select("COD_PATOLOGIA > 0"))
            {
                Int64 cod_pat = 0;
                Tv_canastas_ges.Nodes[0].Nodes.Add(x.ToString(), FilaPatalogia["NOM_PATOLOGIA"].ToString(), "cesta.png", "cesta.png");
                Tv_canastas_ges.Nodes[0].Nodes[x.ToString()].Tag= FilaPatalogia["ID_FILA"].ToString();
                cod_pat = Convert.ToInt64(FilaPatalogia["COD_PATOLOGIA"].ToString());
                cod_canasta = Convert.ToInt64(FilaPatalogia["ID_FILA"].ToString());

                foreach (DataRow FilaEtapa in v_dt_etapa.Select("COD_PATOLOGIA = " + cod_pat))
                {
                    Tv_canastas_ges.Nodes[0].Nodes[x.ToString()].Nodes.Add(z.ToString(), FilaEtapa["NOM_ETAPA"].ToString(), "App.png", "App.png");
                    string CodEtapa = FilaEtapa["COD_ETAPA"].ToString();

                    foreach (DataRow FilaSubEtapa in v_dt_sub_etapa.Select("COD_ETAPA = " + CodEtapa + " AND  ID_FILA = " + cod_canasta))
                    {
                        Tv_canastas_ges.Nodes[0].Nodes[x.ToString()].Nodes[z.ToString()].Nodes.Add(y.ToString(), FilaSubEtapa["NOM_SUB_ETAPA"].ToString(), "App.png", "App.png");
                        Tv_canastas_ges.Nodes[0].Nodes[x.ToString()].Nodes[z.ToString()].Nodes[y.ToString()].Tag = FilaSubEtapa["COD_SUB_ETAPA"].ToString();
                        y = y + 1;
                    }

                    z = z + 1;
                }
                x = x + 1;
            }
            Tv_canastas_ges.Nodes[0].Expand();
        }

      
        private void TvEsquemas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int Level = e.Node.Level;
            if (Level == 1)
            {
                cod_patologia = Convert.ToInt64(e.Node.Tag.ToString());
                v_ID = cod_patologia;
                Cargar_grilla(cod_patologia);
                groupBox1.Enabled = true;
           }
        }
     
   

        private Boolean Validar_existencia_Patologia()
        {
            Boolean var = false;
            foreach (DataRow ad in dt_canasta.Select("COD_PATOLOGIA = '" + Txt_Diagnostico.Tag + "'"))
            {
                var = true;
            }

            return var;
        }



        private void Cargar_grilla(Int64 cod_canasta)
        {
            int cont = 0;
            Tbl_Patologia.Clear();
            foreach (DataRow ad in dt_canasta.Select("ID_FILA = " + cod_canasta + ""))
            {
                Txt_Diagnostico.Tag = ad["COD_PATOLOGIA"].ToString();
                Txt_Diagnostico.Text = ad["NOM_PATOLOGIA"].ToString();
                
                    DataRow NewFila = Tbl_Patologia.NewRow();
                    NewFila["ID_FILA"] = cont + 1;
                    NewFila["ID_FILA_DET"] = ad["ID_FILA_DET"].ToString();
                    NewFila["COD_ETAPA"] = ad["COD_ETAPA"].ToString();
                    NewFila["NOM_ETAPA"] = ad["NOM_ETAPA"].ToString();
                    NewFila["COD_SUB_ETAPA"] = ad["COD_SUB_ETAPA"].ToString();
                    NewFila["NOM_SUB_ETAPA"] = ad["NOM_SUB_ETAPA"].ToString();
                    NewFila["COD_PAQUETE"] = ad["COD_PAQUETE"].ToString();
                    NewFila["NOM_PAQUETE"] = ad["NOM_PAQUETE"].ToString();
                    NewFila["DIA_FONASA"] = ad["DIA_FONASA"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(ad["DIA_FONASA"].ToString());
                    NewFila["DIA_CONTRATO"] = ad["DIA_CONTRATO"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt64(ad["DIA_CONTRATO"].ToString());
                    NewFila["VIGENCIA"] = ad["VIGENCIA"].ToString();
                    Tbl_Patologia.Rows.Add(NewFila);
                    cont++;
              
            }

            v_cont = cont;
            Gv_Patologias.AutoGenerateColumns = false;
            Gv_Patologias.DataSource = Tbl_Patologia;
            Txt_Diagnostico.Enabled = false;
            Btn_Diagnostico.Enabled = false;
            
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            
                string nom = "";

                if (cod_mod> 0)
                {
                    nom = "ID_FILA_DET";
                }
                else
                {
                    nom = "ID_FILA";
                    cod_mod = v_modificado;
                }
         
                foreach (DataRow ad in Tbl_Patologia.Select(""+ nom +" = " + cod_mod + ""))
                {

                    ad["COD_ETAPA"] = Convert.ToInt64(Txt_Etapa.Tag);
                    ad["NOM_ETAPA"] = Txt_Etapa.Text;
                    ad["COD_SUB_ETAPA"] = Convert.ToInt64(Txt_SubEtapa.Tag);
                    ad["NOM_SUB_ETAPA"] = Txt_SubEtapa.Text;
                    ad["COD_PAQUETE"] = Convert.ToInt64(Txt_Paquetes.Tag);
                    ad["NOM_PAQUETE"] = Txt_Paquetes.Text;
                    ad["DIA_FONASA"] = Txt_DiasFonasa.Text;
                    ad["DIA_CONTRATO"] = Txt_DiasContrato.Text;

                }
                MessageBox.Show("Estimado Usuario, Fue Modificada la Información ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                Txt_Diagnostico.Enabled = true;
           
        }

     


        private Boolean Validar_existencia_dat()
        {
            Boolean var = false;
            int cont = 0;


            foreach (DataRow ad in Tbl_Patologia.Rows)
            {
                
                Int64 c_etapa = Convert.ToInt64(ad["COD_ETAPA"].ToString());
                Int64 c_subetapa = Convert.ToInt64(ad["COD_SUB_ETAPA"].ToString());
                Int64 c_paquete = Convert.ToInt64(ad["COD_PAQUETE"].ToString());
                Int64 t_etapa = Txt_Etapa.Tag.Equals(string.Empty)? 0:Convert.ToInt64(Txt_Etapa.Tag);
                Int64 t_subetapa = Txt_SubEtapa.Tag.Equals(string.Empty)? 0:Convert.ToInt64(Txt_SubEtapa.Tag);
                Int64 t_paquete = Txt_Paquetes.Tag.Equals(string.Empty)? 0:Convert.ToInt64(Txt_Paquetes.Tag);
                if (c_etapa == t_etapa && c_subetapa == t_subetapa && c_paquete == t_paquete)
                {
                    cont++;
                }
            }

            if (cont > 0)
            {
                var = true;
            }

            return var;
        }

        private void btn_limpiar_etapa_Click(object sender, EventArgs e)
        {
            
            DialogResult opc = MessageBox.Show("Estimado Usuario,¿Esta Seguro de  Limpiar los Campos de la Seccion Etapas del Caso?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opc == DialogResult.Yes)
            {
                Limpiar();
                Btn_Grabar.Enabled = false;
                Btn_Agregar.Visible = true;
                btn_confirmar.Visible = false;
            }
        }

        private void Limpia_general()
        {
            LimpiarSeccion();
            Limpiar();
            Gv_Patologias.DataSource = Tbl_Patologia;
            Asignacion();
            CargaTvEsquemas();
            Carga_Tabla_Patologia();
            Txt_Diagnostico.Enabled = true;
            Btn_Diagnostico.Enabled = true;
            Txt_Diagnostico.Text = "";
            Txt_Diagnostico.Tag = "";
            cod_patologia = 0;
            Btn_Grabar.Enabled = false;
            groupBox1.Enabled = false;
            v_ID = 0;
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            if (v_ID>0)
            {
                 DialogResult opc = MessageBox.Show("Estimado Usuario,¿Esta Seguro de Eliminar la Canasta "+ Txt_Diagnostico.Text + "?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 if (opc == DialogResult.Yes)
                 {
                     CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + ".P_ANULAR");
                     CnnFalp.ParametroBD("pin_id_patologia", v_ID, DbType.Int64, ParameterDirection.Input);

                     CnnFalp.ExecuteNonQuery();

                     MessageBox.Show("Estimado Usuario,  Canasta fue Eliminada Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                     CargaTvEsquemas();
                     Limpia_general();

                 }

            }
            else{
                MessageBox.Show("Estimado Usuario, Debe Seleccionar una Canasta ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }

            v_ID = 0;
        }

    

      

     

    }
}
